import struct, sys
from pathlib import Path

# Add project root to path
sys.path.insert(0, str(Path(__file__).parent))
from apply_step1_fixes import patch_gmd_bytes

root = Path(r'D:\The Great Ace Attorney Chronicles FR\nativeDX11x64')

# Find all loose .gmd files outside archive directory
loose_count = 0
patched_count = 0

for p in root.rglob('*.gmd'):
    if 'archive' in p.parts:
        continue
    loose_count += 1
    data = p.read_bytes()
    new_data, mod = patch_gmd_bytes(data, str(p.relative_to(root)))
    if mod > 0:
        p.write_bytes(new_data)
        patched_count += 1
        print(f"Patched loose file: {p.relative_to(root)} ({mod} strings)")

print(f"Checked {loose_count} loose .gmd files, patched {patched_count}.")
