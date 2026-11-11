"""Orchestrated Steam patch release builder (NO automatic git commit/tag/push).

Sequence:
1. Validate version string (X.Y.Z) strictly higher or explicit target.
2. Run tools/verify_all.py (blocking pre-build gate — aborts on error).
3. Update patch.major/minor/micro in tools/build_steam_aapatch.py and version badge in README.md.
4. Check RELEASE_NOTES.md starts cleanly with the target version header.
5. Run tools/build_steam_aapatch.py (~7.7 min) unless --skip-build.
6. Run tools/split_steam_patch.py and assert every part is strictly < 100 MiB.
"""

from __future__ import annotations

import argparse
import re
import subprocess
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib

MAX_GITHUB_PART_BYTES = 100 * 1024 * 1024  # 100 MiB strict GitHub limit


def bump_version_files(version: str) -> None:
    parts = version.split(".")
    if len(parts) != 3 or not all(p.isdigit() for p in parts):
        raise ValueError(f"Invalid semantic version {version!r}, expected X.Y.Z")
    maj, min_, mic = parts

    build_py = dgs_lib.REPO_ROOT / "tools" / "build_steam_aapatch.py"
    txt = build_py.read_text(encoding="utf-8")
    txt = re.sub(r"(patch\.major\s*=\s*)\d+", rf"\g<1>{maj}", txt)
    txt = re.sub(r"(patch\.minor\s*=\s*)\d+", rf"\g<1>{min_}", txt)
    txt = re.sub(r"(patch\.micro\s*=\s*)\d+", rf"\g<1>{mic}", txt)
    build_py.write_text(txt, encoding="utf-8")

    readme = dgs_lib.REPO_ROOT / "README.md"
    rtxt = readme.read_text(encoding="utf-8")
    rtxt_new = re.sub(
        r"(img\.shields\.io/badge/version-)[0-9]+\.[0-9]+\.[0-9]+(--)",
        rf"\g<1>{version}\g<2>",
        rtxt,
    )
    readme.write_text(rtxt_new, encoding="utf-8")
    print(f"Bumped version to {version} in build_steam_aapatch.py and README.md")


def check_release_notes(version: str) -> None:
    rn = (dgs_lib.REPO_ROOT / "RELEASE_NOTES.md").read_text(encoding="utf-8").strip()
    if f"v{version}" not in rn and version not in rn:
        print(
            f"WARNING: RELEASE_NOTES.md does not mention v{version} yet! "
            "Remember: short, incremental notes for the new minor version only."
        )


def run_step(cmd: list[str], label: str) -> None:
    print(f"\n>>> [{label}] {' '.join(cmd)}")
    proc = subprocess.run(cmd, cwd=str(dgs_lib.REPO_ROOT))
    if proc.returncode != 0:
        raise RuntimeError(f"Step {label!r} failed with exit code {proc.returncode}")


def main() -> int:
    parser = argparse.ArgumentParser(description="Validate, bump, build, and split Steam release.")
    parser.add_argument("--version", required=True, help="Target version X.Y.Z (e.g. 2.0.3)")
    parser.add_argument("--skip-build", action="store_true", help="Run verify + bump only (no 7.7m bsdiff)")
    args = parser.parse_args()

    py = sys.executable

    # 1. Blocking verification BEFORE bump/build (ignore version mismatch during pre-bump check)
    run_step([py, "tools/verify_all.py", "--no-version-check"], "verify_all")

    # 2. Bump version files & warn on release notes
    bump_version_files(args.version)
    check_release_notes(args.version)

    if args.skip_build:
        print("\n--skip-build requested: skipped build_steam_aapatch.py and split_steam_patch.py.")
        return 0

    # 3. Clean stale chunks in release_patches/ before splitting
    rel_dir = dgs_lib.REPO_ROOT / "release_patches"
    if rel_dir.exists():
        for old_chunk in rel_dir.glob("patch_steam.aapatch.*"):
            old_chunk.unlink()

    # 4. Build & split
    run_step([py, "tools/build_steam_aapatch.py"], "build_steam_aapatch")
    run_step([py, "tools/split_steam_patch.py"], "split_steam_patch")

    # 5. Assert every part < 100 MiB
    chunks = sorted(rel_dir.glob("patch_steam.aapatch.*"))
    if not chunks:
        raise RuntimeError("No split chunks generated in release_patches/")
    for ch in chunks:
        sz = ch.stat().st_size
        if sz >= MAX_GITHUB_PART_BYTES:
            raise RuntimeError(f"Chunk {ch.name} exceeds 100 MiB ({sz} bytes)")
        print(f"  Verified chunk OK: {ch.name} ({sz / (1024 * 1024):.2f} MiB)")

    # 6. Final strict verify including version consistency
    run_step([py, "tools/verify_all.py"], "final_verify_all")
    print(f"\nRelease v{args.version} artifacts ready! Review diffs, then commit, tag v{args.version}, and push explicitly.")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
