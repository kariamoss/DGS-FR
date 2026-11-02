import json, struct, zlib, sys, re, os
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

def unescape_gmd(s):
    return s

def escape_gmd(s):
    return s

def patch_gmd_with_items(gmd_bytes, item_map):
    """item_map: dict of int index -> str fr_text"""
    if len(gmd_bytes) < 40 or gmd_bytes[:4] != b'GMD\x00':
        return gmd_bytes, 0

    ssz = struct.unpack_from('<I', gmd_bytes, 32)[0]
    str_start = len(gmd_bytes) - ssz
    if str_start < 40 or str_start >= len(gmd_bytes):
        return gmd_bytes, 0

    header_and_tables = gmd_bytes[:str_start]
    str_block = gmd_bytes[str_start:]

    raw_strings = str_block.split(b'\x00')
    has_trailing_null = (raw_strings and raw_strings[-1] == b'')
    if has_trailing_null:
        raw_strings.pop()

    modified_count = 0
    new_raw_strings = []

    for idx, r in enumerate(raw_strings):
        if idx in item_map:
            fr_text = item_map[idx]
            new_raw_strings.append(fr_text.encode('utf-8'))
            modified_count += 1
        else:
            new_raw_strings.append(r)

    if modified_count == 0:
        return gmd_bytes, 0

    new_str_block = b'\x00'.join(new_raw_strings)
    if has_trailing_null:
        new_str_block += b'\x00'

    new_ssz = len(new_str_block)
    new_header = bytearray(header_and_tables)
    struct.pack_into('<I', new_header, 32, new_ssz)

    return bytes(new_header) + new_str_block, modified_count

def patch_arc_with_file_map(arc_path, file_map):
    """file_map: dict of str entry_name -> dict of int index -> str fr_text"""
    arc_data = arc_path.read_bytes()
    if arc_data[:4] != b'ARC\x00':
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

    total_mod = 0
    for e in entries:
        norm_name = e['name'].replace('/', '\\')
        if norm_name in file_map:
            patched, mod_count = patch_gmd_with_items(e['data'], file_map[norm_name])
            if mod_count > 0:
                e['data'] = patched
                total_mod += mod_count

    if total_mod == 0:
        return 0

    # Rebuild ARC
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

        entry_bytes = bytearray(e['raw_name'])
        entry_bytes.extend(struct.pack('<IIII', e['type_hash'], csz, usz, file_off))
        out_table.extend(entry_bytes)

    out_arc = bytearray(struct.pack('<4sHH', b'ARC\x00', ver, count))
    out_arc.extend(out_table)

    if len(out_arc) < first_data_offset:
        out_arc.extend(b'\x00' * (first_data_offset - len(out_arc)))

    out_arc.extend(out_data)
    arc_path.write_bytes(out_arc)
    print(f"Injected into {arc_path.name}: {total_mod} dialogue strings updated.")
    return total_mod

def run_step2():
    print("=== STARTING STEP 2 INTEGRATION ===")
    batches_dir = Path('analyse/step2_batches')

    # Load all 5 batch files
    ep3_batches = [
        batches_dir / 'batch1_ep3_intro_wax_translated.json',
        batches_dir / 'batch2_ep3_trial1_mid_translated.json',
        batches_dir / 'batch3_ep3_inv_day2_a_translated.json',
        batches_dir / 'batch4_ep3_inv_day2_b_translated.json'
    ]
    ep4_batches = [
        batches_dir / 'batch5_ep4_all_translated.json'
    ]

    ep3_file_map = {} # norm_name -> {index -> fr_text}
    for bp in ep3_batches:
        if not bp.exists():
            print(f"ERROR: {bp.name} not found!")
            return False
        with open(bp, 'r', encoding='utf-8') as f:
            data = json.load(f)
        for it in data:
            ename = it['EntryName'].replace('/', '\\')
            idx = it['Index']
            fr = it['Fr']
            if ename not in ep3_file_map:
                ep3_file_map[ename] = {}
            ep3_file_map[ename][idx] = fr
        print(f"Loaded {len(data)} items from {bp.name}")

    ep4_file_map = {} # norm_name -> {index -> fr_text}
    for bp in ep4_batches:
        if not bp.exists():
            print(f"ERROR: {bp.name} not found!")
            return False
        with open(bp, 'r', encoding='utf-8') as f:
            data = json.load(f)
        for it in data:
            ename = it['EntryName'].replace('/', '\\')
            idx = it['Index']
            fr = it['Fr']
            if ename not in ep4_file_map:
                ep4_file_map[ename] = {}
            ep4_file_map[ename][idx] = fr
        print(f"Loaded {len(data)} items from {bp.name}")

    # Inject into live game archives
    root = Path(r'D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\BB')
    arc_ep3 = root / 'sce02_eng.arc'
    arc_ep4 = root / 'sce03_eng.arc'

    print("\nInjecting EP3 translations...")
    cnt3 = patch_arc_with_file_map(arc_ep3, ep3_file_map)

    print("\nInjecting EP4 translations...")
    cnt4 = patch_arc_with_file_map(arc_ep4, ep4_file_map)

    print(f"\nTotal injected: EP3={cnt3}, EP4={cnt4}")

    # Update analyse/data/sce02_fr.json and sce03_fr.json
    print("\nUpdating analyse/data/sce02_fr.json and sce03_fr.json...")
    for json_path, fmap in [('analyse/data/sce02_fr.json', ep3_file_map), ('analyse/data/sce03_fr.json', ep4_file_map)]:
        p_json = Path(json_path)
        if p_json.exists():
            with open(p_json, 'r', encoding='utf-8-sig') as f:
                jdata = json.load(f)
            updated_items = 0
            for entry in jdata:
                ename = entry.get('EntryName', '').replace('/', '\\')
                if ename in fmap:
                    for it in entry.get('Items', []):
                        idx = it['Index']
                        if idx in fmap[ename]:
                            it['Fr'] = fmap[ename][idx]
                            updated_items += 1
            with open(p_json, 'w', encoding='utf-8') as f:
                json.dump(jdata, f, indent=2, ensure_ascii=False)
            print(f"Updated {updated_items} entries in {json_path}")

    # Now run apply_step1_fixes.py to enforce all spacing rules & Faucheur/London harmonizations
    sys.path.insert(0, os.path.abspath('tools'))
    import apply_step1_fixes as step1
    step1.main()

    print("\n=== STEP 2 INTEGRATION COMPLETE ===")
    return True

if __name__ == '__main__':
    run_step2()
