"""High-precision page-level English, Japanese, and Ruby audit across the entire game.

Compares D:\The Great Ace Attorney Chronicles FR directly against the unpatched
original game across ALL 18 GMD-bearing .arc archives AND all 69 loose .gmd files,
splitting strings per <PAGE>, filtering out known noise, and producing:
  - analyse/rapports/00_synthese.md (tracked summary report)
  - analyse/backlog/step3_remaining_targets.json (tracked prioritized Phase 2 backlog)
"""

from __future__ import annotations

import argparse
import json
import sys
import time
from collections import defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib

REPORT_PATH = dgs_lib.REPO_ROOT / "analyse" / "rapports" / "00_synthese.md"
BACKLOG_PATH = dgs_lib.REPO_ROOT / "analyse" / "backlog" / "step3_remaining_targets.json"


def load_origin_clean_pages(orig_dir: Path) -> dict[tuple[str, int], set[str]]:
    """Load clean <PAGE> sets per (gmd_key_lower, string_idx) from unpatched origin."""
    origin_map: dict[tuple[str, int], set[str]] = {}
    for src in dgs_lib.iter_game_gmds(orig_dir):
        key = src.gmd_key.lower()
        doc = dgs_lib.parse_gmd(src.raw_bytes)
        if doc is None:
            continue
        for idx, s in enumerate(doc.strings):
            pair = (key, idx)
            if pair in origin_map:
                continue
            pages_clean = {
                c for p in s.split("<PAGE>") if (c := dgs_lib.clean_page_text(p))
            }
            origin_map[pair] = pages_clean
    return origin_map


def run_audit(
    fr_dir: Path,
    orig_dir: Path,
    write_outputs: bool = True,
) -> dict:
    t0 = time.time()
    origin_pages = load_origin_clean_pages(orig_dir)

    summary_by_container: dict[str, dict] = {}
    backlog_items: list[dict] = []
    seen_targets: set[tuple[str, str, int]] = set()

    for src in dgs_lib.iter_game_gmds(fr_dir):
        doc = dgs_lib.parse_gmd(src.raw_bytes)
        if doc is None:
            continue
        meta = dgs_lib.classify_container(src.container_rel, src.gmd_key)
        c_key = ("loose:" if src.is_loose else "arc:") + src.container_rel
        bucket = summary_by_container.setdefault(
            c_key,
            {
                "game": meta["game"],
                "episode": meta["episode"],
                "is_loose": src.is_loose,
                "container": src.container_rel,
                "total_text_pages": 0,
                "untranslated_en_pages": 0,
                "identical_origin_pages": 0,
                "lexical_en_pages": 0,
                "jp_strings": 0,
                "ruby_anomalies": 0,
                "target_strings": 0,
            },
        )

        # Skip command-only preset files when measuring dialogue/UI translation
        if meta["kind"] == "preset_cmd":
            continue

        # Also skip Japanese-locale _jpn DLC duplicates (intentional JP text)
        if src.gmd_key.lower().endswith("_jpn"):
            continue

        gmd_lower = src.gmd_key.lower()
        for s_idx, raw_str in enumerate(doc.strings):
            pages = raw_str.split("<PAGE>")
            orig_set = origin_pages.get((gmd_lower, s_idx))

            en_page_indices: list[dict] = []
            for pi, p in enumerate(pages):
                clean = dgs_lib.clean_page_text(p)
                if len(clean) >= 4:
                    bucket["total_text_pages"] += 1
                is_en, reason = dgs_lib.analyze_page_english(p, orig_pages_clean=orig_set)
                if is_en:
                    bucket["untranslated_en_pages"] += 1
                    if reason == "identical_to_origin":
                        bucket["identical_origin_pages"] += 1
                    else:
                        bucket["lexical_en_pages"] += 1
                    en_page_indices.append({"page": pi, "reason": reason, "text": clean})

            cjk_hits = dgs_lib.find_untranslated_cjk(raw_str)
            ruby_hits = dgs_lib.find_ruby_anomalies(raw_str)
            if cjk_hits:
                bucket["jp_strings"] += 1
            if ruby_hits:
                bucket["ruby_anomalies"] += len(ruby_hits)

            if en_page_indices or cjk_hits or ruby_hits:
                bucket["target_strings"] += 1
                dedup_id = (c_key, src.gmd_key, s_idx)
                if dedup_id not in seen_targets:
                    seen_targets.add(dedup_id)
                    backlog_items.append(
                        {
                            "game": meta["game"],
                            "episode": meta["episode"],
                            "kind": meta["kind"],
                            "is_loose": src.is_loose,
                            "container": src.container_rel,
                            "EntryName": src.gmd_key,
                            "Index": s_idx,
                            "total_pages": len(pages),
                            "en_pages": en_page_indices,
                            "has_cjk_outside_ruby": bool(cjk_hits),
                            "ruby_anomalies": ruby_hits,
                            "Raw": raw_str,
                        }
                    )

    elapsed = time.time() - t0
    report = {
        "generated_at": time.strftime("%Y-%m-%d %H:%M:%S"),
        "elapsed_sec": round(elapsed, 2),
        "containers": summary_by_container,
        "backlog_count": len(backlog_items),
        "backlog_items": backlog_items,
    }

    if write_outputs:
        _write_backlog(backlog_items, BACKLOG_PATH)
        _write_markdown_report(report, REPORT_PATH)

    return report


def _write_backlog(items: list[dict], out_path: Path) -> None:
    out_path.parent.mkdir(parents=True, exist_ok=True)
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(items, f, indent=2, ensure_ascii=False)


def _write_markdown_report(report: dict, out_path: Path) -> None:
    out_path.parent.mkdir(parents=True, exist_ok=True)
    lines: list[str] = [
        "# Synthèse en direct de l'audit DGS-FR (par `<PAGE>` vs original)",
        "",
        f"Généré le `{report['generated_at']}` en `{report['elapsed_sec']}s` sur l'ensemble des **18 `.arc` à `.gmd`** et des **`.gmd` libres**.",
        "",
        "## 1. État par archive `.arc`",
        "",
        "| Jeu | Épisode / Section | Conteneur | Pages texte | Pages EN restantes | Dont identiques original | Chaînes JP hors `<RUBY>` | Rubis anormaux |",
        "| :--- | :--- | :--- | ---: | ---: | ---: | ---: | ---: |",
    ]

    containers = report["containers"]
    for k, row in sorted(containers.items()):
        if row["is_loose"]:
            continue
        lines.append(
            f"| {row['game']} | {row['episode']} | `{row['container']}` | "
            f"{row['total_text_pages']} | {row['untranslated_en_pages']} | "
            f"{row['identical_origin_pages']} | {row['jp_strings']} | {row['ruby_anomalies']} |"
        )

    lines.extend(
        [
            "",
            "## 2. Fichiers `.gmd` libres présentant des restes (EN / JP / Rubis)",
            "",
            "| Jeu | Conteneur libre | Pages texte | Pages EN restantes | Chaînes JP | Rubis anormaux |",
            "| :--- | :--- | ---: | ---: | ---: | ---: |",
        ]
    )

    loose_has_issues = False
    for k, row in sorted(containers.items()):
        if not row["is_loose"]:
            continue
        if (
            row["untranslated_en_pages"] > 0
            or row["jp_strings"] > 0
            or row["ruby_anomalies"] > 0
        ):
            loose_has_issues = True
            lines.append(
                f"| {row['game']} | `{row['container']}` | {row['total_text_pages']} | "
                f"{row['untranslated_en_pages']} | {row['jp_strings']} | {row['ruby_anomalies']} |"
            )
    if not loose_has_issues:
        lines.append("| *(tous)* | *(aucun reste détecté dans les .gmd libres)* | - | 0 | 0 | 0 |")

    lines.extend(
        [
            "",
            f"**Total des cibles suivies dans `analyse/backlog/step3_remaining_targets.json` : `{report['backlog_count']}` chaînes.**",
        ]
    )
    out_path.write_text("\n".join(lines) + "\n", encoding="utf-8")


def print_console_summary(report: dict) -> None:
    print(f"=== AUDIT COMPLET ({report['elapsed_sec']}s) ===")
    for k, row in sorted(report["containers"].items()):
        en = row["untranslated_en_pages"]
        jp = row["jp_strings"]
        rb = row["ruby_anomalies"]
        if not row["is_loose"] or en or jp or rb:
            tag = "LOOSE" if row["is_loose"] else "ARC  "
            print(
                f"  [{tag}] {row['container']:48s} | EN_pages={en:4d} "
                f"(orig={row['identical_origin_pages']:4d}) | JP={jp:3d} | Ruby={rb:3d}"
            )
    print(f"\nBacklog ciblé : {report['backlog_count']} chaînes.")


def main() -> None:
    parser = argparse.ArgumentParser(description="Audit page-level remaining EN/JP/Ruby issues.")
    parser.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    parser.add_argument("--orig-dir", type=Path, default=dgs_lib.DEFAULT_ORIG_DIR)
    parser.add_argument("--no-write", action="store_true", help="Do not overwrite report/backlog JSON.")
    args = parser.parse_args()

    report = run_audit(args.fr_dir, args.orig_dir, write_outputs=not args.no_write)
    print_console_summary(report)


if __name__ == "__main__":
    main()
