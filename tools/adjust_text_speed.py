"""Adjust dialogue text display speed (<E025>) across DGS-FR.

Profile A (Balanced / Recommended):
  <E025 2> (standard ~30 cps) -> <E025 1> (snappy / urgent ~60 cps)
  <E025 3> (monologue ~20 cps) -> <E025 2> (standard ~30 cps)
  <E025 1> (cris / shouts)     -> untouched (<E025 1>)
  <E025 6>/<E025 7> (dots)     -> untouched (suspense preserved)
"""

from __future__ import annotations

import argparse
import re
import sys
from pathlib import Path

# Ensure UTF-8 output on Windows consoles
if sys.stdout and hasattr(sys.stdout, "reconfigure"):
    sys.stdout.reconfigure(encoding="utf-8")

sys.path.insert(0, str(Path(__file__).resolve().parent))
from dgs_lib import DEFAULT_FR_DIR, DEFAULT_ORIG_DIR, apply_transform_to_all, iter_game_gmds, parse_gmd


def make_speed_transformer(mode: str) -> callable:
    if mode == "balanced":
        def _sub(m: re.Match[str]) -> str:
            val = m.group(1)
            if val == "2":
                return "<E025 1>"
            elif val == "3":
                return "<E025 2>"
            return m.group(0)
    elif mode == "uniform":
        def _sub(m: re.Match[str]) -> str:
            val = m.group(1)
            if val in ("2", "3"):
                return "<E025 1>"
            return m.group(0)
    else:
        raise ValueError(f"Unknown mode: {mode}")

    def transform(gmd_key: str, idx: int, text: str) -> str:
        return re.sub(r"<E025\s+(\d+)>", _sub, text)

    return transform


def restore_original_speeds(game_dir: Path, orig_dir: Path, dry_run: bool = False) -> dict[str, int]:
    """Restore original E025 tags from non-patched reference."""
    orig_speeds: dict[str, dict[int, list[str]]] = {}
    for src in iter_game_gmds(orig_dir):
        doc = parse_gmd(src.raw_bytes)
        if not doc:
            continue
        k = src.gmd_key.lower()
        if k not in orig_speeds:
            orig_speeds[k] = {}
            for idx, text in enumerate(doc.strings):
                speeds = re.findall(r"<E025\s+\d+>", text)
                if speeds:
                    orig_speeds[k][idx] = speeds

    def _restore_fn(gmd_key: str, idx: int, text: str) -> str:
        k = gmd_key.lower()
        if k not in orig_speeds or idx not in orig_speeds[k]:
            return text
        speeds = orig_speeds[k][idx]
        speed_idx = 0

        def _rep(m: re.Match[str]) -> str:
            nonlocal speed_idx
            if speed_idx < len(speeds):
                res = speeds[speed_idx]
                speed_idx += 1
                return res
            return m.group(0)

        return re.sub(r"<E025\s+\d+>", _rep, text)

    return apply_transform_to_all(game_dir, _restore_fn, dry_run=dry_run)


def main() -> int:
    parser = argparse.ArgumentParser(description="Adjust dialogue scrolling speed (<E025>).")
    parser.add_argument("--game-dir", type=Path, default=DEFAULT_FR_DIR, help="Path to patched game directory")
    parser.add_argument("--orig-dir", type=Path, default=DEFAULT_ORIG_DIR, help="Path to non-patched reference")
    parser.add_argument(
        "--mode",
        choices=["balanced", "uniform"],
        default="balanced",
        help="balanced: E025 2->1 and 3->2 (recommended); uniform: 2 and 3 -> 1",
    )
    parser.add_argument("--restore", action="store_true", help="Restore original speeds from non-patched reference")
    parser.add_argument("--dry-run", action="store_true", help="Preview modifications without writing to disk")
    args = parser.parse_args()

    if args.restore:
        print(f"Restoring original text speeds from {args.orig_dir}...")
        stats = restore_original_speeds(args.game_dir, args.orig_dir, dry_run=args.dry_run)
    else:
        print(f"Applying text speed acceleration (mode: {args.mode}, dry-run={args.dry_run})...")
        trans_fn = make_speed_transformer(args.mode)
        stats = apply_transform_to_all(args.game_dir, trans_fn, dry_run=args.dry_run)

    touched_keys = len(stats)
    touched_lines = sum(stats.values())
    print(f"Completed: {touched_keys} GMD keys touched, {touched_lines} strings modified.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
