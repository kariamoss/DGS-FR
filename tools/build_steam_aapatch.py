import os
import sys
import time
from pathlib import Path

# Add project root to path
sys.path.insert(0, str(Path(__file__).parent.parent))

from src.aapatch import AAPatch
from src.utils import uprint

def build_steam_patch():
    ori_dir = r"D:\The Great Ace Attorney Chronicles Non patché"
    dst_dir = r"D:\The Great Ace Attorney Chronicles FR"
    out_patch = r"C:\Users\Karia\.gemini\antigravity\scratch\DGS-FR\patch_steam.aapatch"

    print("Initializing AAPatch for Steam (flag=2)...")
    patch = AAPatch()
    patch.version = 0
    patch.flag = 2  # Steam
    patch.major = 2
    patch.minor = 0
    patch.micro = 2

    print("Scanning original game files...")
    t0 = time.time()
    patch.load_origin(ori_dir)
    print(f"Loaded {len(patch._original_files)} origin files in {time.time()-t0:.1f}s")

    print("Scanning destination patched files...")
    t1 = time.time()
    patch.load_destination(dst_dir, flag=0)
    print(f"Loaded {len(patch._destination_files)} dest files in {time.time()-t1:.1f}s")

    # Exclude config.ini, env_option.ini and any log or temp or backup files
    excluded_files = {"config.ini", "env_option.ini", "dgs.ini", "dgsfix_dinput8.log", "DINPUT8.dll"}
    for excl in list(patch._original_files.keys()):
        if excl in excluded_files or excl.endswith(".bak") or excl.endswith(".bak_stable"):
            del patch._original_files[excl]
    for excl in list(patch._destination_files.keys()):
        if excl in excluded_files or excl.endswith(".bak") or excl.endswith(".bak_stable"):
            del patch._destination_files[excl]

    print("Writing AAPatch file (computing bsdiffs)...")
    t2 = time.time()
    patch.write(out_patch)
    print(f"Successfully generated {out_patch} in {time.time()-t2:.1f}s!")

    sz = os.path.getsize(out_patch) / (1024 * 1024)
    print(f"Patch file size: {sz:.2f} MB")

if __name__ == "__main__":
    build_steam_patch()
