"""Phase 2 extraction, validation, and lossless application pipeline for DGS-FR.

Extracts all remaining untranslated <PAGE> segments from the live FR game files
into structured JSON batches under analyse/backlog/phase2/, preserving every Capcom
binary control tag via positional [[T0]], [[T1]], ... placeholders, speaker metadata,
and surrounding French dialogue context.
"""

from __future__ import annotations

import argparse
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib
import apply_step1_fixes

PHASE2_DIR = dgs_lib.REPO_ROOT / "analyse" / "backlog" / "phase2"
TARGETS_JSON = dgs_lib.REPO_ROOT / "analyse" / "backlog" / "step3_remaining_targets.json"

# Tags that visually format or delimit inline words and must stay inside masked middle text
_INLINE_FORMAT_PREFIXES = (
    "<E005", "<E006", "<E007", "<E507", "<E516", "<E519",
    "<RUBY", "</RUBY", "<RB", "</RB", "<RT", "</RT", "<COL", "</COL",
    "<E042", "<CNTR",
)
# Pure page-end terminator tags that belong in suffix
_SUFFIX_TAGS = frozenset({"<E023>", "<E024>", "<E001>", "<0006>"})
_PLACEHOLDER_RE = re.compile(r"\[\[T(\d+)\]\]")
_SPEAKER_TAG_RE = re.compile(r"<E041\s+(\d+)\s+\d+>")


def load_cast_map(fr_dir: Path) -> dict[int, str]:
    """Load DGS2 (BB) speaker ID -> clean display name from BB/msg/cast_name_eng."""
    cast: dict[int, str] = {}
    for src in dgs_lib.iter_game_gmds(fr_dir, include_loose=False, arc_list=("BB/msg_title_eng.arc",)):
        if src.gmd_key.lower() == "bb/msg/cast_name_eng":
            doc = dgs_lib.parse_gmd(src.raw_bytes)
            if doc:
                for idx, s in enumerate(doc.strings):
                    cast[idx] = dgs_lib.clean_page_text(s)
            break
    return cast


def tokenize_page(raw_page: str) -> dict:
    """Losslessly split raw_page into (prefix, suffix, en_masked, tags, newline)."""
    newline = "\r\n" if "\r\n" in raw_page else ("\n" if "\n" in raw_page else "")
    tokens = [tok for tok in re.split(r"(<[^>]+>)", raw_page) if tok != ""]

    # Pull pure structural prefix before first visible text or inline formatting tag
    start = 0
    while start < len(tokens):
        tok = tokens[start]
        if tok.startswith("<") and tok.endswith(">"):
            if any(tok.startswith(pfx) for pfx in _INLINE_FORMAT_PREFIXES):
                break
            start += 1
        elif tok.strip() == "":
            start += 1
        else:
            break

    # Pull pure end-of-page terminator tags from the tail
    end = len(tokens)
    while end > start:
        tok = tokens[end - 1]
        if tok in _SUFFIX_TAGS:
            end -= 1
        else:
            break

    prefix = "".join(tokens[:start])
    suffix = "".join(tokens[end:])
    middle_tokens = tokens[start:end]

    tags: list[str] = []
    masked_parts: list[str] = []
    for tok in middle_tokens:
        if tok.startswith("<") and tok.endswith(">"):
            idx = len(tags)
            tags.append(tok)
            masked_parts.append(f"[[T{idx}]]")
        else:
            masked_parts.append(tok.replace("\r\n", "\n") if newline == "\r\n" else tok)

    en_masked = "".join(masked_parts)
    rebuilt = reconstruct_page(prefix, suffix, en_masked, tags, newline)
    if rebuilt != raw_page:
        raise AssertionError(
            f"Lossy page tokenization detected!\n  ORIG: {raw_page!r}\n  REBT: {rebuilt!r}"
        )
    return {
        "prefix": prefix,
        "suffix": suffix,
        "tags": tags,
        "newline": newline,
        "en_masked": en_masked,
    }


def reconstruct_page(prefix: str, suffix: str, body_masked: str, tags: list[str], newline: str) -> str:
    """Rebuild raw <PAGE> text from prefix/suffix/masked body/tags."""
    if newline == "\r\n":
        body = body_masked.replace("\r\n", "\n").replace("\n", "\r\n")
    else:
        body = body_masked

    def _sub(m: re.Match[str]) -> str:
        t_idx = int(m.group(1))
        return tags[t_idx]

    return prefix + _PLACEHOLDER_RE.sub(_sub, body) + suffix


def _resolve_speaker(pages: list[str], p_idx: int, cast_map: dict[int, str]) -> str:
    for i in range(p_idx, -1, -1):
        m = _SPEAKER_TAG_RE.search(pages[i])
        if m:
            cid = int(m.group(1))
            return cast_map.get(cid, f"id:{cid}")
    return ""


def _surrounding_fr_hint(pages: list[str], p_idx: int, step: int) -> str:
    i = p_idx + step
    while 0 <= i < len(pages):
        is_en, _ = dgs_lib.analyze_page_english(pages[i])
        cl = dgs_lib.clean_page_text(pages[i])
        if not is_en and cl:
            return cl[:140]
        i += step
    return ""


def _split_into_page_chunks(records: list[dict], max_pages: int) -> list[list[dict]]:
    chunks: list[list[dict]] = []
    cur: list[dict] = []
    cur_pages = 0
    for rec in records:
        p_cnt = len(rec["pages"])
        if cur and cur_pages + p_cnt > max_pages:
            chunks.append(cur)
            cur = []
            cur_pages = 0
        cur.append(rec)
        cur_pages += p_cnt
    if cur:
        chunks.append(cur)
    return chunks


def extract_batches(fr_dir: Path) -> None:
    if not TARGETS_JSON.exists():
        raise FileNotFoundError(f"Missing {TARGETS_JSON}; run tools/audit_english.py first.")
    targets = json.load(open(TARGETS_JSON, encoding="utf-8"))
    cast_map = load_cast_map(fr_dir)

    # Deduplicate by (gmd_key_lower, index); skip proper-name credit_staff_name and credit job names except #78
    seen: set[tuple[str, int]] = set()
    by_bucket: dict[str, list[dict]] = {
        "dlc": [],
        "ep5": [],
        "ep4": [],
        "ep3": [],
    }

    for t in targets:
        if not t["en_pages"]:
            continue
        cont = t["container"]
        gmd_key = t["EntryName"]
        idx = int(t["Index"])
        dedup_k = (gmd_key.lower(), idx)
        if dedup_k in seen:
            continue
        if cont == "special_cmn_eng.arc":
            # Skip credits staff names & company titles; keep only #78 if needed as special item
            if not (gmd_key == "msgCommon/credit_job_name_eng" and idx == 78):
                continue
        seen.add(dedup_k)

        raw_str = t["Raw"]
        pages = raw_str.split("<PAGE>")
        page_entries = []
        for ep in t["en_pages"]:
            pi = int(ep["page"])
            raw_p = pages[pi]
            tok = tokenize_page(raw_p)
            page_entries.append(
                {
                    "page": pi,
                    "speaker": _resolve_speaker(pages, pi, cast_map),
                    "prev_fr": _surrounding_fr_hint(pages, pi, -1),
                    "next_fr": _surrounding_fr_hint(pages, pi, 1),
                    "en_clean": dgs_lib.clean_page_text(raw_p),
                    "prefix": tok["prefix"],
                    "suffix": tok["suffix"],
                    "tags": tok["tags"],
                    "newline": tok["newline"],
                    "en_masked": tok["en_masked"],
                    "fr_masked": "",
                }
            )

        rec = {
            "container": cont,
            "gmd_key": gmd_key,
            "index": idx,
            "total_pages": len(pages),
            "pages": page_entries,
        }
        if cont == "BB/sce04_eng.arc":
            by_bucket["ep5"].append(rec)
        elif cont == "BB/sce03_eng.arc":
            by_bucket["ep4"].append(rec)
        elif cont == "BB/sce02_eng.arc" or gmd_key.lower() == "bb/script/output/_macro02_eng":
            by_bucket["ep3"].append(rec)
        else:
            by_bucket["dlc"].append(rec)

    PHASE2_DIR.mkdir(parents=True, exist_ok=True)
    # Remove any older generated batch_* before rewriting cleanly
    for old in PHASE2_DIR.glob("batch_*.json"):
        old.unlink()

    manifest: list[tuple[str, list[dict]]] = []
    manifest.append(("batch_01_dlc_credits.json", by_bucket["dlc"]))
    manifest.append(("batch_02_ep5.json", by_bucket["ep5"]))
    for idx_c, ch in enumerate(_split_into_page_chunks(by_bucket["ep4"], 760), 1):
        suffix = chr(ord("a") + idx_c - 1)
        manifest.append((f"batch_{2 + idx_c:02d}_ep4_{suffix}.json", ch))
    base_ep3 = 2 + len(_split_into_page_chunks(by_bucket["ep4"], 760))
    for idx_c, ch in enumerate(_split_into_page_chunks(by_bucket["ep3"], 700), 1):
        suffix = chr(ord("a") + idx_c - 1)
        manifest.append((f"batch_{base_ep3 + idx_c:02d}_ep3_{suffix}.json", ch))

    total_str = 0
    total_pg = 0
    print(f"=== PHASE 2 EXTRACTED BATCHES -> {PHASE2_DIR} ===")
    for fname, recs in manifest:
        out_path = PHASE2_DIR / fname
        out_path.write_text(json.dumps(recs, indent=2, ensure_ascii=False), encoding="utf-8")
        pg = sum(len(r["pages"]) for r in recs)
        total_str += len(recs)
        total_pg += pg
        print(f"  {fname:30s} | strings={len(recs):3d} | pages={pg:4d}")
    print(f"TOTAL extracted: {total_str} strings, {total_pg} EN pages (100% roundtrip verified).")


def validate_and_apply(fr_dir: Path, batch_paths: list[Path], dry_run: bool = False) -> None:
    """Validate translated batch JSONs strictly and sync updates across .arc + loose .gmd."""
    # Load current game strings once by gmd_key_lower
    current_docs: dict[str, dgs_lib.GmdDocument] = {}
    for src in dgs_lib.iter_game_gmds(fr_dir):
        k = src.gmd_key.lower()
        if k not in current_docs:
            doc = dgs_lib.parse_gmd(src.raw_bytes)
            if doc:
                current_docs[k] = doc

    errors: list[str] = []
    updates_by_key: dict[str, dict[int, str]] = {}
    seen_pages: dict[tuple[str, int, int], str] = {}
    pages_applied = 0

    for bp in batch_paths:
        recs = json.load(open(bp, encoding="utf-8"))
        for rec in recs:
            gk_lower = rec["gmd_key"].lower()
            s_idx = int(rec["index"])
            doc = current_docs.get(gk_lower)
            if doc is None or not (0 <= s_idx < len(doc.strings)):
                errors.append(f"{bp.name}: invalid gmd_key/index {rec['gmd_key']} #{s_idx}")
                continue

            base_str = updates_by_key.get(gk_lower, {}).get(s_idx, doc.strings[s_idx])
            pages = base_str.split("<PAGE>")
            if len(pages) != int(rec["total_pages"]):
                errors.append(
                    f"{bp.name}: page count mismatch for {rec['gmd_key']} #{s_idx}: "
                    f"live={len(pages)} vs batch={rec['total_pages']}"
                )
                continue

            for pe in rec["pages"]:
                p_idx = int(pe["page"])
                pk = (gk_lower, s_idx, p_idx)
                if pk in seen_pages:
                    errors.append(
                        f"{bp.name}: duplicate page {rec['gmd_key']} #{s_idx} p{p_idx} (already in {seen_pages[pk]})"
                    )
                    continue
                seen_pages[pk] = bp.name
                fr_masked = pe.get("fr_masked", "")
                if not fr_masked or not fr_masked.strip():
                    errors.append(f"{bp.name}: empty fr_masked for {rec['gmd_key']} #{s_idx} p{p_idx}")
                    continue

                # Check exact placeholder preservation
                expected_tags = list(range(len(pe["tags"])))
                found_tags = [int(m.group(1)) for m in _PLACEHOLDER_RE.finditer(fr_masked)]
                if sorted(found_tags) != expected_tags or len(found_tags) != len(expected_tags):
                    errors.append(
                        f"{bp.name}: placeholder mismatch in {rec['gmd_key']} #{s_idx} p{p_idx}: "
                        f"expected={expected_tags} got={found_tags}"
                    )
                    continue
                if "[[T" in _PLACEHOLDER_RE.sub("", fr_masked):
                    errors.append(f"{bp.name}: malformed placeholder token in {rec['gmd_key']} #{s_idx} p{p_idx}")
                    continue

                nl = pe["newline"]
                if nl == "" and "\n" in pe["en_masked"]:
                    nl = "\n"
                rebuilt_p = reconstruct_page(pe["prefix"], pe["suffix"], fr_masked, pe["tags"], nl)
                if "\x00" in rebuilt_p:
                    errors.append(f"{bp.name}: null byte in {rec['gmd_key']} #{s_idx} p{p_idx}")
                    continue

                is_en, reason = dgs_lib.analyze_page_english(rebuilt_p)
                if is_en:
                    errors.append(
                        f"{bp.name}: still flagged as English ({reason}) in {rec['gmd_key']} #{s_idx} p{p_idx}: "
                        f"{dgs_lib.clean_page_text(rebuilt_p)[:80]!r}"
                    )
                    continue

                pages[p_idx] = rebuilt_p
                pages_applied += 1

            rebuilt_str = "<PAGE>".join(pages)
            rebuilt_str = apply_step1_fixes.patch_string_content(rec["gmd_key"], s_idx, rebuilt_str)

            # Editorial + Ruby balance checks on full rebuilt string
            for tag_pair in (("<RUBY>", "</RUBY>"), ("<RB>", "</RB>"), ("<RT>", "</RT>")):
                if rebuilt_str.count(tag_pair[0]) != rebuilt_str.count(tag_pair[1]):
                    errors.append(f"{bp.name}: unbalanced {tag_pair} in {rec['gmd_key']} #{s_idx}")
            for reg in dgs_lib.find_editorial_regressions(rebuilt_str):
                if reg == "punctuation_spacing" and not re.search(
                    r"toutel'Europe|de Saô ,|l'Europe<E519> \.", rebuilt_str
                ):
                    continue
                errors.append(f"{bp.name}: editorial regression [{reg}] in {rec['gmd_key']} #{s_idx}")

            updates_by_key.setdefault(gk_lower, {})[s_idx] = rebuilt_str

    if errors:
        print(f"VALIDATION FAILED ({len(errors)} errors):")
        for e in errors[:30]:
            print(" ", e)
        if len(errors) > 30:
            print(f"  ... and {len(errors) - 30} more errors.")
        raise SystemExit(1)

    if dry_run:
        print(f"DRY-RUN VALIDATION OK: {pages_applied} pages across {len(updates_by_key)} GMD keys ready.")
        return

    stats = dgs_lib.apply_updates_to_game(fr_dir, updates_by_key, sync_duplicates=True)
    print(f"APPLIED Phase 2 updates: {pages_applied} pages across {len(stats)} container(s).")
    for cont, cnt in sorted(stats.items()):
        print(f"  {cont}: {cnt} strings")


def main() -> None:
    parser = argparse.ArgumentParser(description="Phase 2 batch extractor and synchronized applier.")
    sub = parser.add_subparsers(dest="cmd", required=True)

    p_ext = sub.add_parser("extract", help="Extract untranslated pages into batch JSONs.")
    p_ext.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)

    p_app = sub.add_parser("apply", help="Validate and apply translated batch JSON(s).")
    p_app.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    p_app.add_argument("--batches", nargs="+", type=Path)
    p_app.add_argument("--all", action="store_true")
    p_app.add_argument("--dry-run", action="store_true")

    args = parser.parse_args()
    if args.cmd == "extract":
        extract_batches(args.fr_dir)
    elif args.cmd == "apply":
        if args.all:
            bps = sorted(PHASE2_DIR.glob("batch_*.json"))
        elif args.batches:
            bps = args.batches
        else:
            raise SystemExit("Provide --batches ... or --all")
        validate_and_apply(args.fr_dir, bps, dry_run=args.dry_run)


if __name__ == "__main__":
    main()
