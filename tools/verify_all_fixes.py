import struct
import zlib
import sys
sys.stdout.reconfigure(encoding='utf-8')
from pathlib import Path

arc_data = Path(r"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO\sce01_eng.arc").read_bytes()
ver, count = struct.unpack_from('<HH', arc_data, 4)
off = 8
all_text = ""
for i in range(count):
    name = arc_data[off:off+128].split(b'\x00')[0].decode('ascii')
    type_hash, csz, usz, file_off = struct.unpack_from('<IIII', arc_data, off+128)
    off += 144
    if csz > 6:
        comp = arc_data[file_off:file_off+csz]
        decomp = zlib.decompress(comp[2:-4], -15)
        all_text += decomp.decode('utf-8', errors='ignore') + "\n"

print("1. 'de ces griffures':", "la douleur de ces" in all_text)
print("   'dans ces griffures':", "la douleur dans ces" in all_text)
print("2. 'ruban moucheté':", "ruban moucheté" in all_text)
print("   'bande mouchetée':", "bande mouchetée" in all_text)
print("3. 'jusqu\\'à l\\'armoire':", "jusqu'à l'armoire" in all_text)
print("   'to the wardrobe':", "to the wardrobe" in all_text)
print("4. 'd\\'assaisonnement':", "d'assaisonnement" in all_text)
print("   'of seasoning':", "of seasoning" in all_text)
print("5. 'diamants' instead of 金剛石:", "diamants" in all_text and "金剛石" not in all_text)
print("   'kabuki' instead of 歌舞伎:", "kabuki" in all_text and "歌舞伎" not in all_text)
