"""Unified fast pre-build verification gate (binary, tags, glossary, duplicates, ratchet).

Exit codes:
    0 -> All blocking checks passed.
    1 -> At least one blocking error detected (do not build/release).
"""

from __future__ import annotations

import argparse
import re
import subprocess
import sys
import time
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib


def _check_tag_balance(text: str) -> list[str]:
    errs: list[str] = []
    pairs = [
        ("<RUBY>", "</RUBY>"),
        ("<RB>", "</RB>"),
        ("<RT>", "</RT>"),
    ]
    for p_idx, page in enumerate(text.split("<PAGE>")):
        for op, cl in pairs:
            c_op = page.count(op)
            c_cl = page.count(cl)
            if c_op != c_cl:
                errs.append(f"p{p_idx} unbalanced {op}({c_op})/{cl}({c_cl})")
    return errs


def verify_all(fr_dir: Path, orig_dir: Path, check_version: bool = True) -> dict:
    t0 = time.time()
    errors: list[str] = []
    warnings: list[str] = []

    # 1. Load origin string counts & pages for binary parity + episode ratchet
    origin_counts: dict[str, int] = {}
    origin_clean_pages: dict[tuple[str, int], set[str]] = {}
    if orig_dir.exists():
        for src in dgs_lib.iter_game_gmds(orig_dir):
            k = src.gmd_key.lower()
            doc = dgs_lib.parse_gmd(src.raw_bytes)
            if doc is None:
                continue
            origin_counts.setdefault(k, len(doc.strings))
            for idx, s in enumerate(doc.strings):
                if (k, idx) not in origin_clean_pages:
                    origin_clean_pages[(k, idx)] = {
                        c for p in s.split("<PAGE>") if (c := dgs_lib.clean_page_text(p))
                    }
    else:
        warnings.append(f"Original game directory not found: {orig_dir} (parity checks skipped)")

    # 2. Scan ALL 18 GMD-bearing .arc + ALL loose .gmd files
    checked_sources = 0
    checked_strings = 0
    by_key: dict[str, list[tuple[dgs_lib.GmdSource, dgs_lib.GmdDocument]]] = {}

    for src in dgs_lib.iter_game_gmds(fr_dir):
        checked_sources += 1
        doc = dgs_lib.parse_gmd(src.raw_bytes)
        if doc is None:
            errors.append(f"[BINARY] Invalid GMD header/ssz: {src.container_rel} -> {src.gmd_key}")
            continue
        if doc.utf8_errors:
            errors.append(
                f"[UTF8] Invalid UTF-8 sequences in {src.container_rel} -> {src.gmd_key} indices={doc.utf8_errors[:5]}"
            )

        k_lower = src.gmd_key.lower()
        if k_lower in origin_counts and len(doc.strings) != origin_counts[k_lower]:
            errors.append(
                f"[PARITY] String count mismatch for {src.container_rel} -> {src.gmd_key}: "
                f"FR={len(doc.strings)} vs ORIG={origin_counts[k_lower]}"
            )

        by_key.setdefault(k_lower, []).append((src, doc))
        is_strict_arc = (not src.is_loose) and (src.container_rel in dgs_lib.STRICT_ZERO_ENGLISH_ARCS)

        for idx, s in enumerate(doc.strings):
            checked_strings += 1
            for tb in _check_tag_balance(s):
                errors.append(f"[TAGS] {src.container_rel} -> {src.gmd_key} #{idx}: {tb}")

            # Editorial / glossary regressions: filter legacy punctuation-spacing noise only as warning unless critical phrase
            for reg in dgs_lib.find_editorial_regressions(s):
                if reg == "punctuation_spacing" and not re.search(
                    r"toutel'Europe|de Saô ,|l'Europe<E519> \.", s
                ):
                    warnings.append(
                        f"[TYPO] {src.container_rel} -> {src.gmd_key} #{idx}: {reg}"
                    )
                else:
                    errors.append(
                        f"[EDITORIAL] {src.container_rel} -> {src.gmd_key} #{idx}: {reg}"
                    )

            # Strict episode ratchet on finished episodes
            if is_strict_arc:
                orig_set = origin_clean_pages.get((k_lower, idx))
                for pi, p in enumerate(s.split("<PAGE>")):
                    is_en, reason = dgs_lib.analyze_page_english(p, orig_pages_clean=orig_set)
                    if is_en:
                        clean = dgs_lib.clean_page_text(p)
                        errors.append(
                            f"[RATCHET] {src.container_rel} -> {src.gmd_key} #{idx} p{pi} ({reason}): {clean[:80]!r}"
                        )

    # 3. Duplicate synchronization check across loose + multi-.arc
    for k_lower, items in sorted(by_key.items()):
        if len(items) < 2:
            continue
        ref_src, ref_doc = items[0]
        for other_src, other_doc in items[1:]:
            if other_doc.strings != ref_doc.strings:
                diff_cnt = sum(1 for a, b in zip(ref_doc.strings, other_doc.strings) if a != b)
                errors.append(
                    f"[SYNC] Duplicate divergence on {k_lower} ({diff_cnt} strings): "
                    f"{ref_src.container_rel} != {other_src.container_rel}"
                )

    # 4. Version alignment check (build_steam_aapatch.py vs README badge vs latest git tag)
    if check_version:
        build_py = (dgs_lib.REPO_ROOT / "tools" / "build_steam_aapatch.py").read_text(encoding="utf-8")
        m_maj = re.search(r"patch\.major\s*=\s*(\d+)", build_py)
        m_min = re.search(r"patch\.minor\s*=\s*(\d+)", build_py)
        m_mic = re.search(r"patch\.micro\s*=\s*(\d+)", build_py)
        if m_maj and m_min and m_mic:
            build_ver = f"{m_maj.group(1)}.{m_min.group(1)}.{m_mic.group(1)}"
            readme_txt = (dgs_lib.REPO_ROOT / "README.md").read_text(encoding="utf-8")
            m_badge = re.search(r"version-([0-9]+\.[0-9]+\.[0-9]+)--", readme_txt)
            if m_badge and m_badge.group(1) != build_ver:
                warnings.append(
                    f"[VERSION] README.md badge is {m_badge.group(1)} while build_steam_aapatch.py is {build_ver}"
                )
            try:
                tag = subprocess.check_output(
                    ["git", "describe", "--tags", "--abbrev=0"],
                    cwd=str(dgs_lib.REPO_ROOT),
                    text=True,
                ).strip()
                if tag.lstrip("v") != build_ver:
                    warnings.append(
                        f"[VERSION] Latest git tag is {tag} while build_steam_aapatch.py is {build_ver}"
                    )
            except Exception:
                pass

    return {
        "elapsed_sec": round(time.time() - t0, 2),
        "checked_sources": checked_sources,
        "checked_strings": checked_strings,
        "errors": errors,
        "warnings": warnings,
    }


def main() -> int:
    parser = argparse.ArgumentParser(description="Pre-build verification gate for DGS-FR.")
    parser.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    parser.add_argument("--orig-dir", type=Path, default=dgs_lib.DEFAULT_ORIG_DIR)
    parser.add_argument("--no-version-check", action="store_true")
    parser.add_argument("--max-show", type=int, default=30)
    args = parser.parse_args()

    res = verify_all(args.fr_dir, args.orig_dir, check_version=not args.no_version_check)
    print(
        f"=== VERIFY ALL ({res['elapsed_sec']}s) | sources={res['checked_sources']} "
        f"| strings={res['checked_strings']} ==="
    )
    print(f"Errors  : {len(res['errors'])}")
    print(f"Warnings: {len(res['warnings'])}")

    if res["errors"]:
        print("\n--- BLOCKING ERRORS ---")
        for e in res["errors"][: args.max_show]:
            print(" ", e)
        if len(res["errors"]) > args.max_show:
            print(f"  ... and {len(res['errors']) - args.max_show} more errors.")

    if res["warnings"]:
        print("\n--- WARNINGS (summary) ---")
        from collections import Counter

        by_type = Counter(w.split("]", 1)[0] + "]" for w in res["warnings"])
        print(" ", dict(by_type))
        for w in res["warnings"][:10]:
            print(" ", w)

    return 1 if res["errors"] else 0


if __name__ == "__main__":
    raise SystemExit(main())
