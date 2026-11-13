"""Recalibrate dialogue pauses (<E003>) and timing across DGS-FR.

1. Anchors dialogue pauses to preceding French punctuation (.,!?:;…—).
2. Slightly reduces overly long dialogue pauses (compressed by ~20-25%) to maintain brisk pacing.
3. Preserves character stuttering (e.g. N-<E003 8>Non !).
4. Eliminates orphan pauses stuck between words (e.g. 'je suis <E003> l\'avocat').
5. Preserves all cutscene / animation / camera sequence pauses.
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
from dgs_lib import DEFAULT_FR_DIR, apply_transform_to_all

STUTTER_RE = re.compile(r"\b[a-zA-ZÀ-ÿ]{1,3}-\s*(?:<[^>]+>)*$")
PUNCT_BEFORE_RE = re.compile(r"[,.!?…:;—\-\"]\s*(?:<[^>]+>)*$")
WORD_BEFORE_RE = re.compile(r"\b[a-zA-ZÀ-ÿ\d]+\s*(?:<[^>]+>)*$")
WORD_AFTER_RE = re.compile(r"^(?:<[^>]+>)*\s*[a-zA-ZÀ-ÿ\d]")


def compress_pause_frames(frames: int) -> int:
    """Slightly reduce dialogue pause duration to maintain brisk reading flow."""
    if frames <= 4:
        return frames  # Already a micro-breath (~0.05-0.07s)
    elif frames <= 6:
        return 5
    elif frames <= 8:
        return 6
    elif frames <= 10:
        return 7
    elif frames <= 12:
        return 8
    elif frames <= 16:
        return 12
    elif frames <= 20:
        return 15
    elif frames <= 25:
        return 18
    # Pauses >= 30 are dramatic / scene silences: keep intact
    return frames


def clean_spaces_outside_tags(text: str) -> str:
    """Collapse consecutive spaces only outside Capcom formatting tags."""
    parts = re.split(r"(<[^>]+>)", text)
    for i in range(0, len(parts), 2):
        parts[i] = re.sub(r"[ \t]{2,}", " ", parts[i])
    return "".join(parts)


def retime_page_pacing(page: str, compress_only: bool = False) -> str:
    """Retime pauses in a single dialogue page."""
    # Only touch dialogue pages (marked by prompt / speaker tags)
    if "<E023>" not in page and "<E024>" not in page and "<E041" not in page:
        return page

    pattern = re.compile(r"(<E358>)?<E003\s+(\d+)>")

    pos_to_action: list[tuple[int, int, str, int, bool, str]] = []
    for m in pattern.finditer(page):
        start, end = m.start(), m.end()
        has_e358 = bool(m.group(1))
        frames = int(m.group(2))
        before = page[:start]
        after = page[end:]

        if STUTTER_RE.search(before):
            pos_to_action.append((start, end, m.group(0), frames, has_e358, "stutter"))
        elif PUNCT_BEFORE_RE.search(before):
            pos_to_action.append((start, end, m.group(0), frames, has_e358, "punct"))
        elif WORD_BEFORE_RE.search(before) and WORD_AFTER_RE.search(after):
            pos_to_action.append((start, end, m.group(0), frames, has_e358, "orphan"))
        else:
            pos_to_action.append((start, end, m.group(0), frames, has_e358, "other"))

    if compress_only or not any(p[5] == "orphan" for p in pos_to_action):
        def _comp(m: re.Match[str]) -> str:
            e358 = m.group(1) or ""
            fr = compress_pause_frames(int(m.group(2)))
            return f"{e358}<E003 {fr}>"

        return pattern.sub(_comp, page)

    # Rebuild page by retiming / removing orphan pauses
    out: list[str] = []
    last_idx = 0
    for start, end, full_tag, frames, has_e358, kind in pos_to_action:
        out.append(page[last_idx:start])
        compressed_fr = compress_pause_frames(frames)
        tag_str = f"<E358><E003 {compressed_fr}>" if has_e358 else f"<E003 {compressed_fr}>"

        if kind in ("punct", "stutter", "other"):
            out.append(tag_str)
        elif kind == "orphan":
            # Check preceding text chunk for an unpaused punctuation mark in this clause
            chunk = page[last_idx:start]
            m_punct = re.search(r"([,.!?…:;—])\s*(?:<[^>]+>)*\s*$", chunk)
            if m_punct:
                # Relocate tag right behind punctuation
                p_end = m_punct.end(1)
                chunk_new = chunk[:p_end] + tag_str + " " + chunk[p_end:].lstrip()
                out[-1] = chunk_new
            else:
                # Stray word-to-word pause: remove it to eliminate dialogue stutter
                out.append(" ")
        last_idx = end

    out.append(page[last_idx:])
    return clean_spaces_outside_tags("".join(out))


def retime_string(gmd_key: str, idx: int, text: str, compress_only: bool = False) -> str:
    pages = [retime_page_pacing(p, compress_only=compress_only) for p in text.split("<PAGE>")]
    return "<PAGE>".join(pages)


def main() -> int:
    parser = argparse.ArgumentParser(description="Retime dialogue pauses and pacing in DGS-FR.")
    parser.add_argument("--game-dir", type=Path, default=DEFAULT_FR_DIR, help="Path to patched game directory")
    parser.add_argument("--compress-only", action="store_true", help="Only compress pause durations, leave orphan positions")
    parser.add_argument("--dry-run", action="store_true", help="Preview modifications without writing to disk")
    args = parser.parse_args()

    print(f"Applying dialogue pacing retiming (compress_only={args.compress_only}, dry-run={args.dry_run})...")
    trans_fn = lambda k, i, t: retime_string(k, i, t, compress_only=args.compress_only)
    stats = apply_transform_to_all(args.game_dir, trans_fn, dry_run=args.dry_run)

    touched_keys = len(stats)
    touched_lines = sum(stats.values())
    print(f"Completed: {touched_keys} GMD keys touched, {touched_lines} strings modified.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
