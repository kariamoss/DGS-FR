import struct, zlib, sys, re
from pathlib import Path
sys.stdout.reconfigure(encoding='utf-8')

root = Path(r'D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive')

samples = []
glued_remaining = 0

for p in root.rglob('*.arc'):
    try:
        arc_data = p.read_bytes()
        ver, count = struct.unpack_from('<HH', arc_data, 4)
        off = 8
        for i in range(count):
            raw_name = arc_data[off:off+128]
            name = raw_name.split(b'\x00')[0].decode('ascii')
            type_hash, csz, usz, file_off = struct.unpack_from('<IIII', arc_data, off+128)
            off += 144
            if csz > 6:
                decomp = zlib.decompress(arc_data[file_off:file_off+csz][2:-4], -15)
                if len(decomp) >= 4 and decomp[:4] == b'GMD\x00':
                    text = decomp.decode('utf-8', errors='ignore')
                    if 'laCrystal' in text or 'cettebanquette' in text:
                        print(f"ERROR: Glued phrase still found in {p.name} | {name}!")
                    if '_sce02_c107_0001_eng' in name:
                        for line in text.split('\x00'):
                            if 'banquette' in line or 'Crystal' in line:
                                samples.append((name, line))
    except Exception as e:
        pass

print("=== CHECK USER-REPORTED SPACING TYPOS ===")
for name, s in samples:
    print(f"[{name}]:\n  {repr(s)}\n")
