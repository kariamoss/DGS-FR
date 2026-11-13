"""Audit dialogue pacing, text speed, and pause placement across DGS-FR.

Scans all game archives and loose .gmd files to detect orphan pause tags (<E003>),
quantify alignment with punctuation, and evaluate dialogue speed distribution.
"""

from __future__ import annotations

import argparse
import collections
import re
import sys
from pathlib import Path

# Ensure UTF-8 output on Windows consoles
if sys.stdout and hasattr(sys.stdout, "reconfigure"):
    sys.stdout.reconfigure(encoding="utf-8")

sys.path.insert(0, str(Path(__file__).resolve().parent))
from dgs_lib import DEFAULT_FR_DIR, iter_game_gmds, parse_gmd

PUNCT_BEFORE_RE = re.compile(r"[,.!?…:;—\-\"]\s*(?:<[^>]+>)*$")
WORD_BEFORE_RE = re.compile(r"[a-zA-ZÀ-ÿ\d]\s*(?:<[^>]+>)*$")
WORD_AFTER_RE = re.compile(r"^(?:<[^>]+>)*\s*[a-zA-ZÀ-ÿ\d]")


def audit_game_pacing(game_dir: Path, detailed: bool = False, container_filter: str | None = None) -> int:
    stats: dict[str, dict[str, int]] = collections.defaultdict(
        lambda: {
            "total_e003": 0,
            "after_punct": 0,
            "between_words": 0,
            "engine_cutscene": 0,
            "speed_0": 0,
            "speed_1": 0,
            "speed_2": 0,
            "speed_3": 0,
            "speed_other": 0,
        }
    )

    orphan_samples: list[dict[str, str]] = []

    for src in iter_game_gmds(game_dir, include_archives=True, include_loose=False):
        if container_filter and container_filter.lower() not in src.container_rel.lower():
            continue

        gmd = parse_gmd(src.raw_bytes)
        if not gmd:
            continue

        st = stats[src.container_rel]

        for s_idx, s in enumerate(gmd.strings):
            # Speed distribution
            for sm in re.finditer(r"<E025\s+(\d+)>", s):
                sp = sm.group(1)
                if sp == "0":
                    st["speed_0"] += 1
                elif sp == "1":
                    st["speed_1"] += 1
                elif sp == "2":
                    st["speed_2"] += 1
                elif sp == "3":
                    st["speed_3"] += 1
                else:
                    st["speed_other"] += 1

            # Pause audit
            for p_idx, page in enumerate(s.split("<PAGE>")):
                for m in re.finditer(r"<E003\s+(\d+)>", page):
                    st["total_e003"] += 1
                    frames = m.group(1)
                    before_ctx = page[max(0, m.start() - 30) : m.start()]
                    after_ctx = page[m.end() : min(len(page), m.end() + 30)]

                    if PUNCT_BEFORE_RE.search(before_ctx):
                        st["after_punct"] += 1
                    elif WORD_BEFORE_RE.search(before_ctx) and WORD_AFTER_RE.search(after_ctx):
                        st["between_words"] += 1
                        if len(orphan_samples) < 50:
                            clean_before = re.sub(r"<[^>]+>", "", before_ctx).strip()[-15:]
                            clean_after = re.sub(r"<[^>]+>", "", after_ctx).strip()[:15]
                            orphan_samples.append(
                                {
                                    "container": src.container_rel,
                                    "key": src.gmd_key,
                                    "pos": f"#{s_idx} p{p_idx}",
                                    "frames": frames,
                                    "phrase": f"{clean_before} <E003 {frames}> {clean_after}",
                                }
                            )
                    else:
                        st["engine_cutscene"] += 1

    print("=" * 85)
    print(" DGS-FR DIALOGUE PACING & SPEED AUDIT")
    print("=" * 85)
    hdr = f"{'Container':<25} | {'Total E003':<10} | {'After Punct':<11} | {'Broken/Orphan':<13} | {'Broken %':<9} | {'Spd 1/2/3':<12}"
    print(hdr)
    print("-" * 85)

    grand_total_e003 = 0
    grand_punct = 0
    grand_broken = 0
    grand_s1 = 0
    grand_s2 = 0
    grand_s3 = 0

    for c in sorted(stats.keys()):
        v = stats[c]
        tot = v["total_e003"]
        bw = v["between_words"]
        ap = v["after_punct"]
        pct = (bw / tot * 100) if tot > 0 else 0.0

        grand_total_e003 += tot
        grand_punct += ap
        grand_broken += bw
        grand_s1 += v["speed_1"]
        grand_s2 += v["speed_2"]
        grand_s3 += v["speed_3"]

        spd_str = f"{v['speed_1']}/{v['speed_2']}/{v['speed_3']}"
        print(f"{c:<25} | {tot:<10d} | {ap:<11d} | {bw:<13d} | {pct:<8.1f}% | {spd_str:<12}")

    print("-" * 85)
    grand_pct = (grand_broken / grand_total_e003 * 100) if grand_total_e003 > 0 else 0.0
    print(
        f"{'TOTAL GLOBAL':<25} | {grand_total_e003:<10d} | {grand_punct:<11d} | "
        f"{grand_broken:<13d} | {grand_pct:<8.1f}% | {grand_s1}/{grand_s2}/{grand_s3}"
    )
    print("=" * 85)

    if detailed and orphan_samples:
        print("\nExemples de pauses orphelines (coupant des mots sans ponctuation) :")
        for s in orphan_samples[:25]:
            print(f"  [{s['container']} {s['pos']}] {s['phrase']}")

    return grand_broken


def main() -> int:
    parser = argparse.ArgumentParser(description="Audit dialogue pacing & speeds in DGS-FR.")
    parser.add_argument("--game-dir", type=Path, default=DEFAULT_FR_DIR, help="Path to patched game directory")
    parser.add_argument("--detailed", action="store_true", help="Print detailed orphan samples")
    parser.add_argument("--container", type=str, default=None, help="Filter by container name")
    args = parser.parse_args()

    broken = audit_game_pacing(args.game_dir, detailed=args.detailed, container_filter=args.container)
    return 1 if broken > 0 else 0


if __name__ == "__main__":
    sys.exit(main())
