import struct
import zlib
import re
import sys
from pathlib import Path

def decode_capcom_rt(rt):
    s = re.sub(r'<[^>]+>', '', rt)
    res = []
    char_map = {
        0xFFA9: 'É', 0xFFB4: 'Ô', 0xFFC0: 'à', 0xFFC2: 'â',
        0xFFC7: 'ç', 0xFFC8: 'è', 0xFFC9: 'é', 0xFFCA: 'ê',
        0xFFCE: 'î', 0xFFCF: 'ï', 0xFFD4: 'ô', 0xFFDB: 'û'
    }
    for c in s:
        code = ord(c)
        if 0xFF01 <= code <= 0xFF5E:
            res.append(chr(code - 0xFEE0))
        elif code in char_map:
            res.append(char_map[code])
        elif code == 0x3000 or code == 0x20:
            res.append(' ')
        else:
            res.append(c)
    clean = re.sub(r'\s+', ' ', ''.join(res)).strip()
    return clean

def patch_gmd_strings(gmd_bytes, entry_name=""):
    if len(gmd_bytes) < 40 or gmd_bytes[:4] != b'GMD\x00':
        return gmd_bytes, 0
    
    # We only patch dialogue / script files, NEVER msg_title or system files
    if 'script' not in entry_name and 'msg' not in entry_name:
        return gmd_bytes, 0

    ssz = struct.unpack_from('<I', gmd_bytes, 32)[0]
    str_start = len(gmd_bytes) - ssz
    if str_start < 40 or str_start >= len(gmd_bytes):
        return gmd_bytes, 0

    header_and_tables = gmd_bytes[:str_start]
    str_block = gmd_bytes[str_start:]
    
    raw_strings = str_block.split(b'\x00')
    if raw_strings and raw_strings[-1] == b'':
        raw_strings.pop()
    
    modified_count = 0
    new_strings = []
    
    for raw in raw_strings:
        try:
            s = raw.decode('utf-8')
        except:
            new_strings.append(raw)
            continue
        
        orig_s = s
        
        # 1. Griffures fix
        if 'la douleur dans ces' in s:
            s = s.replace('la douleur dans ces', 'la douleur de ces')
        
        # 2. Ruban moucheté replacements
        mouchet_map = [
            ('une bande <E516 33>mouchetée<E519>', 'un ruban <E516 33>moucheté<E519>'),
            ('une <E006>bande mouchetée<E005>', 'un <E006>ruban moucheté<E005>'),
            ('une <E006>bande <E516 33>mouchetée<E519><E005>', 'un <E006>ruban <E516 33>moucheté<E519><E005>'),
            ('cette "bande mouchetée"', 'ce "ruban moucheté"'),
            ('de la "bande mouchetée"', 'du "ruban moucheté"'),
            ('de la terrifiante <E006>bande<E516 33> mouchetée<E519><E005>', 'du terrifiant <E006>ruban<E516 33> moucheté<E519><E005>'),
            ('de la "<E006>bande mouchetée<E005>"', 'du "<E006>ruban moucheté<E005>"'),
            ('de la "<E006>bande\r\n<E516 33>mouchetée<E519><E005>"', 'du "<E006>ruban\r\n<E516 33>moucheté<E519><E005>"'),
            ('bande mouchetée dans le conduit', 'ruban moucheté dans le conduit'),
            ('Bande Mouchetée', 'Ruban Moucheté'),
            ('La bande mouchetée', 'Le ruban moucheté'),
            ('la bande mouchetée', 'le ruban moucheté'),
            ('une bande mouchetée', 'un ruban moucheté'),
            ('bande mouchetée', 'ruban moucheté'),
            ('bande <E516 33>mouchetée<E519>', 'ruban <E516 33>moucheté<E519>'),
        ]
        for src, dst in mouchet_map:
            if src in s:
                # safeguard
                if "ce serpent, il n'est pas très moucheté" in s and 'bande' not in s:
                    continue
                s = s.replace(src, dst)
        
        # 3. Yûno wardrobe / seasoning monologues
        s = re.sub(r'<RUBY><RB>to the wardrobe</RB><RT>.*?</RT></RUBY>', "jusqu'à l'armoire", s)
        s = re.sub(r'<RUBY><RB>of seasoning</RB><RT>.*?</RT></RUBY>', "d'assaisonnement", s)
        
        # 4. Occidentalize kanji rubies in dialogue (surgical replacement)
        def replace_kanji_ruby(m):
            rb = m.group(1)
            rt = m.group(2)
            if any(0x4E00 <= ord(c) <= 0x9FFF for c in rb):
                decoded = decode_capcom_rt(rt)
                if decoded:
                    return decoded
            return m.group(0)
        
        s = re.sub(r'<RUBY><RB>([^<]+)</RB><RT>(.*?)</RT></RUBY>', replace_kanji_ruby, s)
        
        if s != orig_s:
            modified_count += 1
            new_strings.append(s.encode('utf-8'))
        else:
            new_strings.append(raw)
            
    if modified_count > 0:
        new_str_block = b'\x00'.join(new_strings) + b'\x00'
        new_ssz = len(new_str_block)
        new_header = bytearray(header_and_tables)
        struct.pack_into('<I', new_header, 32, new_ssz)
        return bytes(new_header) + new_str_block, modified_count
    
    return gmd_bytes, 0

def patch_arc_file(arc_path):
    print(f"Processing {arc_path.name}...")
    arc_data = arc_path.read_bytes()
    if arc_data[:4] != b'ARC\x00':
        print(f"Error: {arc_path.name} is not an ARC file.")
        return 0
    
    ver, count = struct.unpack_from('<HH', arc_data, 4)
    entries = []
    off = 8
    
    for i in range(count):
        raw_name = arc_data[off:off+128]
        name = raw_name.split(b'\x00')[0].decode('ascii')
        type_hash, csz, usz, file_off = struct.unpack_from('<IIII', arc_data, off+128)
        off += 144
        
        if csz > 6:
            comp = arc_data[file_off:file_off+csz]
            decomp = zlib.decompress(comp[2:-4], -15)
        else:
            decomp = b''
            
        entries.append({
            'raw_name': raw_name,
            'name': name,
            'type_hash': type_hash,
            'data': decomp
        })
        
    total_strings_patched = 0
    total_entries_patched = 0
    
    for e in entries:
        patched_data, count_mod = patch_gmd_strings(e['data'], e['name'])
        if count_mod > 0:
            e['data'] = patched_data
            total_strings_patched += count_mod
            total_entries_patched += 1
            
    if total_strings_patched == 0:
        print(f"  No strings needed patching in {arc_path.name}.")
        return 0
        
    # Rebuild ARC
    # Header: 4 bytes magic, 2 bytes ver, 2 bytes count
    out_header = bytearray(struct.pack('<4sHH', b'ARC\x00', ver, count))
    
    # Table offset
    table_size = count * 144
    first_data_offset = 0x8000
    if 8 + table_size > first_data_offset:
        first_data_offset = (8 + table_size + 0x7FFF) & ~0x7FFF
        
    out_table = bytearray()
    out_data = bytearray()
    curr_data_offset = first_data_offset
    
    for e in entries:
        decomp = e['data']
        if len(decomp) > 0:
            # Compress with zlib
            # MT Framework uses zlib default
            comp = zlib.compress(decomp)
            csz = len(comp)
            usz = len(decomp)
            file_off = curr_data_offset
            curr_data_offset += csz
            out_data.extend(comp)
        else:
            csz = 0
            usz = 0
            file_off = 0
            
        entry_header = bytearray(e['raw_name'])
        entry_header.extend(struct.pack('<IIII', e['type_hash'], csz, usz, file_off))
        out_table.extend(entry_header)
        
    # Assemble full ARC
    padding_len = first_data_offset - (8 + table_size)
    full_arc = out_header + out_table + (b'\x00' * padding_len) + out_data
    
    # Backup original before overwriting
    bak_path = arc_path.with_suffix('.arc.bak_stable')
    if not bak_path.exists():
        import shutil
        shutil.copyfile(arc_path, bak_path)
        print(f"  Backup saved to {bak_path.name}")
        
    arc_path.write_bytes(full_arc)
    print(f"  Successfully patched {total_strings_patched} strings across {total_entries_patched} entries in {arc_path.name}! New size: {len(full_arc)} bytes")
    return total_strings_patched

if __name__ == '__main__':
    fr_base = Path(r"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive")
    target_arcs = [
        fr_base / "GO" / "sce00_eng.arc",
        fr_base / "GO" / "sce01_eng.arc",
        fr_base / "GO" / "sce02_eng.arc",
        fr_base / "GO" / "sce03_eng.arc",
        fr_base / "GO" / "sce04_eng.arc",
        fr_base / "BB" / "sce00_eng.arc",
        fr_base / "BB" / "sce01_eng.arc",
    ]
    for ta in target_arcs:
        patch_arc_file(ta)
