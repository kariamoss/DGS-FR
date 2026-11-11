"""Reconcile divergent duplicate GMD files (loose .gmd vs .arc and multi-.arc).

Scores each candidate string across all copies of a duplicated gmd_key so that:
- Versions with residual Japanese outside <RUBY> or untranslated English are rejected,
- Updated Latin transliterations (without legacy kanji <RUBY>) and French UI are preferred,
- Explicit container priorities resolve tie-breaks (e.g. sce04 over sce00, msg_cmn/GO over BB/msg_title),
- Every merged decision is recorded in analyse/backlog/reconcile_v203.json and synced identically.
"""

from __future__ import annotations

import argparse
import json
import re
import sys
import time
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib
import apply_step1_fixes

REPORT_PATH = dgs_lib.REPO_ROOT / "analyse" / "backlog" / "reconcile_v203.json"

# Higher score = more authoritative container when string quality scores tie
CONTAINER_AUTHORITY: dict[str, int] = {
    "msg_cmn_eng.arc": 90,
    "GO/msg_title_eng.arc": 85,
    "BB/msg_title_eng.arc": 50,
    "BB/sce04_eng.arc": 90,
    "BB/sce00_eng.arc": 40,
    "GO/sce04_eng.arc": 90,
    "GO/sce03_eng.arc": 90,
    "GO/sce02_eng.arc": 90,
    "GO/sce01_eng.arc": 90,
    "GO/sce00_eng.arc": 80,
}


def score_candidate(text: str, container_rel: str, orig_clean: set[str] | None) -> tuple:
    """Return comparable quality tuple (higher is better)."""
    cjk_outside = len(dgs_lib.find_untranslated_cjk(text))
    kanji_in_ruby = sum(
        len(dgs_lib.CJK_RE.findall(m.group(1))) for m in dgs_lib.RUBY_RE.finditer(text)
    )
    regs = len(dgs_lib.find_editorial_regressions(text))
    en_pages = sum(
        1
        for p in text.split("<PAGE>")
        if dgs_lib.analyze_page_english(p, orig_pages_clean=orig_clean)[0]
    )
    fr_hits = len(
        [w for w in re.findall(r"[a-zA-ZÀ-ÿ]+", dgs_lib.clean_page_text(text).lower()) if w in dgs_lib.FR_WORDS]
    )
    fr_accents = len(dgs_lib.FR_DIACRITIC_RE.findall(text))
    auth = CONTAINER_AUTHORITY.get(dgs_lib.normalize_rel(container_rel), 60 if container_rel.endswith(".arc") else 55)

    return (
        -cjk_outside,     # Zero untranslated JP first
        -en_pages,        # Fewer English pages
        -regs,            # Zero editorial regressions
        -kanji_in_ruby,   # Prefer updated Latin transliterations over old kanji rubies
        fr_hits + fr_accents,
        auth,
    )


def load_origin_pages(orig_dir: Path) -> dict[tuple[str, int], set[str]]:
    res: dict[tuple[str, int], set[str]] = {}
    if not orig_dir.exists():
        return res
    for src in dgs_lib.iter_game_gmds(orig_dir):
        k = src.gmd_key.lower()
        doc = dgs_lib.parse_gmd(src.raw_bytes)
        if not doc:
            continue
        for idx, s in enumerate(doc.strings):
            if (k, idx) not in res:
                res[(k, idx)] = {c for p in s.split("<PAGE>") if (c := dgs_lib.clean_page_text(p))}
    return res


def score_document_cohesive(
    src: dgs_lib.GmdSource,
    doc: dgs_lib.GmdDocument,
    gmd_key_lower: str,
    orig_pages: dict[tuple[str, int], set[str]],
) -> tuple[bool, int, list[str]]:
    """Evaluate file-wide completeness after Step 1 normalization.

    Returns (is_clean_complete, container_authority, normalized_strings).
    Non-blocking punctuation_spacing warnings (legacy '<E519> .') do not disqualify
    an otherwise 100%-translated cohesive copy.
    """
    normalized: list[str] = []
    is_clean = True
    for idx, s in enumerate(doc.strings):
        cand = apply_step1_fixes.patch_string_content(src.gmd_key, idx, s)
        normalized.append(cand)
        if not is_clean:
            continue
        cjk_out = len(dgs_lib.find_untranslated_cjk(cand))
        kanji_ruby = sum(
            len(dgs_lib.CJK_RE.findall(m.group(1))) for m in dgs_lib.RUBY_RE.finditer(cand)
        )
        blocking_regs = [
            r
            for r in dgs_lib.find_editorial_regressions(cand)
            if not (
                r == "punctuation_spacing"
                and not re.search(r"toutel'Europe|de Saô ,|l'Europe<E519> \.", cand)
            )
        ]
        o_set = orig_pages.get((gmd_key_lower, idx))
        en_pages = sum(
            1
            for p in cand.split("<PAGE>")
            if dgs_lib.analyze_page_english(p, orig_pages_clean=o_set)[0]
        )
        if cjk_out > 0 or kanji_ruby > 0 or blocking_regs or en_pages > 0:
            is_clean = False
    auth = CONTAINER_AUTHORITY.get(
        dgs_lib.normalize_rel(src.container_rel),
        60 if src.container_rel.endswith(".arc") else 55,
    )
    return is_clean, auth, normalized


def reconcile(fr_dir: Path, orig_dir: Path, apply: bool = False) -> dict:
    dups = dgs_lib.load_duplicate_index(fr_dir)
    orig_pages = load_origin_pages(orig_dir)

    updates_by_key: dict[str, dict[int, str]] = {}
    diff_records: list[dict] = []

    for gmd_key_lower, copies in sorted(dups.items()):
        parsed = [(c, dgs_lib.parse_gmd(c.raw_bytes)) for c in copies]
        if any(doc is None for _, doc in parsed):
            continue
        docs = [(c, doc) for c, doc in parsed if doc is not None]
        n_strings = len(docs[0][1].strings)
        if any(len(doc.strings) != n_strings for _, doc in docs):
            raise RuntimeError(f"String count mismatch among duplicates for {gmd_key_lower}")

        # Check if a 100%-complete cohesive copy exists; picking that whole copy avoids
        # mixing localization styles/speaker names (e.g. Amimo vs Susato) mid-scene.
        doc_evals = [
            (score_document_cohesive(src, doc, gmd_key_lower, orig_pages), src, doc)
            for src, doc in docs
        ]
        clean_copies = [(auth, src, doc, norm) for (is_clean, auth, norm), src, doc in doc_evals if is_clean]
        cohesive_winner = None
        if clean_copies:
            clean_copies.sort(key=lambda t: t[0], reverse=True)
            cohesive_winner = clean_copies[0]  # (auth, src, doc, norm)

        norm_by_container = {
            src.container_rel: norm for (_, _, norm), src, _ in doc_evals
        }

        for idx in range(n_strings):
            variants = {doc.strings[idx] for _, doc in docs}
            if len(variants) <= 1:
                continue

            if cohesive_winner is not None:
                _, best_src, _, winner_norm = cohesive_winner
                best_text = winner_norm[idx]
                mode = "cohesive_file"
            else:
                o_set = orig_pages.get((gmd_key_lower, idx))
                scored: list[tuple[tuple, dgs_lib.GmdSource, str]] = []
                for src, _ in docs:
                    cand = norm_by_container[src.container_rel][idx]
                    scored.append((score_candidate(cand, src.container_rel, o_set), src, cand))

                scored.sort(key=lambda t: t[0], reverse=True)
                _, best_src, best_text = scored[0]
                mode = "per_string"

            updates_by_key.setdefault(gmd_key_lower, {})[idx] = best_text
            diff_records.append(
                {
                    "gmd_key": docs[0][0].gmd_key,
                    "index": idx,
                    "selection_mode": mode,
                    "chosen_from": best_src.container_rel,
                    "chosen_preview": dgs_lib.clean_page_text(best_text)[:120],
                    "rejected": [
                        {
                            "container": s.container_rel,
                            "preview": dgs_lib.clean_page_text(doc.strings[idx])[:120],
                        }
                        for s, doc in docs
                        if doc.strings[idx] != best_text
                    ],
                }
            )

    REPORT_PATH.parent.mkdir(parents=True, exist_ok=True)
    with open(REPORT_PATH, "w", encoding="utf-8") as f:
        json.dump(
            {
                "generated_at": time.strftime("%Y-%m-%d %H:%M:%S"),
                "applied": apply,
                "divergent_strings_resolved": len(diff_records),
                "records": diff_records,
            },
            f,
            indent=2,
            ensure_ascii=False,
        )

    applied_stats: dict[str, int] = {}
    if apply and updates_by_key:
        applied_stats = dgs_lib.apply_updates_to_game(fr_dir, updates_by_key, sync_duplicates=True)

    return {
        "divergent_strings": len(diff_records),
        "keys_touched": len(updates_by_key),
        "applied_stats": applied_stats,
    }


def main() -> None:
    parser = argparse.ArgumentParser(description="Reconcile duplicate .gmd/.arc copies.")
    parser.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    parser.add_argument("--orig-dir", type=Path, default=dgs_lib.DEFAULT_ORIG_DIR)
    parser.add_argument("--apply", action="store_true", help="Write synchronized winners to disk.")
    args = parser.parse_args()

    res = reconcile(args.fr_dir, args.orig_dir, apply=args.apply)
    mode = "APPLIED" if args.apply else "DRY-RUN"
    print(f"=== RECONCILE DUPLICATES [{mode}] ===")
    print(f"  Divergent strings resolved: {res['divergent_strings']} across {res['keys_touched']} GMD keys")
    print(f"  Audit report written to   : {REPORT_PATH}")
    if res["applied_stats"]:
        for k, v in sorted(res["applied_stats"].items()):
            print(f"    updated {k}: {v} strings")


if __name__ == "__main__":
    main()
