"""Build and query a fast local inverted text index across the entire game.

Usage:
    python tools/build_text_index.py                  # Rebuild analyse/cache/text_index.json
    python tools/build_text_index.py --find "phrase"  # Instant search (auto-builds if missing)
"""

from __future__ import annotations

import argparse
import json
import sys
import time
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib

INDEX_PATH = dgs_lib.REPO_ROOT / "analyse" / "cache" / "text_index.json"


def build_index(fr_dir: Path, out_path: Path = INDEX_PATH) -> list[dict]:
    t0 = time.time()
    records: list[dict] = []
    for src in dgs_lib.iter_game_gmds(fr_dir):
        doc = dgs_lib.parse_gmd(src.raw_bytes)
        if doc is None:
            continue
        meta = dgs_lib.classify_container(src.container_rel, src.gmd_key)
        for s_idx, raw_str in enumerate(doc.strings):
            clean = dgs_lib.clean_page_text(raw_str, strip_rt=True)
            if not clean:
                continue
            rdfg_m = dgs_lib.RDFG_RE.search(raw_str)
            rdfg = rdfg_m.group(1) if rdfg_m else ""
            records.append(
                {
                    "game": meta["game"],
                    "episode": meta["episode"],
                    "kind": meta["kind"],
                    "is_loose": src.is_loose,
                    "container": src.container_rel,
                    "gmd_key": src.gmd_key,
                    "index": s_idx,
                    "rdfg": rdfg,
                    "raw": raw_str,
                    "clean": clean,
                }
            )
    out_path.parent.mkdir(parents=True, exist_ok=True)
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(records, f, ensure_ascii=False)
    print(f"Indexed {len(records)} non-empty strings -> {out_path} in {time.time() - t0:.2f}s")
    return records


def query_index(query: str, index_path: Path = INDEX_PATH, limit: int = 20) -> int:
    if not index_path.exists():
        records = build_index(dgs_lib.DEFAULT_FR_DIR, index_path)
    else:
        with open(index_path, "r", encoding="utf-8") as f:
            records = json.load(f)

    q_lower = query.lower()
    hits = [
        r
        for r in records
        if q_lower in r["clean"].lower()
        or q_lower in r["raw"].lower()
        or (r["rdfg"] and q_lower == f"rdfg:{r['rdfg']}")
    ]
    print(f"Query {query!r}: {len(hits)} match(es) (showing up to {limit})")
    for h in hits[:limit]:
        layer = "LOOSE" if h["is_loose"] else "ARC"
        print(
            f"  [{layer}] {h['game']} | {h['episode']} | {h['container']} -> "
            f"{h['gmd_key']} #{h['index']} (RDFG {h['rdfg'] or '-'})"
        )
        # Highlight matching page if multi-page
        pages = h["raw"].split("<PAGE>")
        matched_pages = [
            (pi, dgs_lib.clean_page_text(p))
            for pi, p in enumerate(pages)
            if q_lower in dgs_lib.clean_page_text(p).lower() or q_lower in p.lower()
        ]
        for pi, mp in matched_pages[:3]:
            print(f"      page {pi}: {mp[:160]}")
    return len(hits)


def main() -> None:
    parser = argparse.ArgumentParser(description="Build/query DGS-FR fast text index.")
    parser.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    parser.add_argument("--out", type=Path, default=INDEX_PATH)
    parser.add_argument("--find", type=str, default=None, help="Search string or rdfg:<id>")
    parser.add_argument("--limit", type=int, default=20)
    args = parser.parse_args()

    if args.find:
        query_index(args.find, index_path=args.out, limit=args.limit)
    else:
        build_index(args.fr_dir, out_path=args.out)


if __name__ == "__main__":
    main()
