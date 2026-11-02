import struct
import zlib
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

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

# Known translations dictionary for clean replacement
TITLE_MAP = {
    'the speckled band': '« Le Ruban moucheté »',
    'the hound of the baskervilles': '« Le Chien des Baskerville »',
    'a study in scarlet': '« Une étude en rouge »',
    'the beryl coronet': '« Le Diadème de béryls »',
    'the boscombe valley mystery': '« Le Mystère du Val Boscombe »',
    "the adventure of the lion's mane": "« L'Aventure de la crinière du lion »",
    'the portrait of mr lecoq': 'Portrait de Monsieur Lecoq',
    'the canterbury tales': 'Les Contes de Canterbury',
    'gaboriau and the sea': 'Gaboriau et la mer'
}

def transform_ruby(match):
    full = match.group(0)
    rb = match.group(1)
    rt = match.group(2)
    
    rb_clean = re.sub(r'<[^>]+>', '', rb).strip()
    rt_clean = decode_capcom_rt(rt)
    rb_lower = rb_clean.lower()
    
    # 1. London with any ruby -> pure London
    if rb_lower == 'london':
        return 'London'
    if rb_lower == 'london police':
        return 'police de London'
        
    # 2. Known book titles
    if rb_lower in TITLE_MAP:
        return TITLE_MAP[rb_lower]
        
    # 3. Honédé Rika special phrases
    if 'je suis waiter' in rb_lower:
        return 'Je suis serveur'
    if "j'étais in the kitchen" in rb_lower or "j'etais in the kitchen" in rb_lower:
        return "J'étais dans les cuisines"
    if rb_lower == 'waiter':
        if 'hé' in rt_clean.lower() or 'garçon' in rt_clean.lower():
            return 'Garçon'
        return 'serveur'
    if rb_lower == 'handbag':
        return 'sac à main'
        
    # 4. Common English phrases in RB with French in RT
    eng_words = {'the', 'to', 'of', 'in', 'and', 'with', 'for', 'at', 'from', 'a', 'by', 'just', 'that'}
    words = set(rb_lower.split())
    if words.intersection(eng_words) and rb_lower not in {'lord', 'old bailey'}:
        if rt_clean:
            lead_space = ' ' if rb.startswith(' ') else ''
            trail_space = ' ' if rb.endswith(' ') else ''
            return lead_space + rt_clean + trail_space

    # 5. French text in RB with English furigana in RT -> keep French text (rb) only!
    eng_rt_indicators = {
        'the', 'a', 'an', 'to', 'of', 'in', 'and', 'with', 'for', 'at', 'from', 'by',
        'big', 'chance', 'seat', 'seats', 'coach', 'coachman', 'derby', 'smoke', 'lock',
        'young', 'lady', 'horse', 'very', 'strange', 'rules', 'rule'
    }
    rt_words = set(re.findall(r'[a-zA-Z]+', rt_clean.lower()))
    if rt_words.intersection(eng_rt_indicators) and rb_lower not in {'wûnoz', 'yûno'}:
        if 'imperial police' not in rt_clean.lower():
            return rb
            
    return full

def patch_string_content(text, entry_name=""):
    orig_text = text
    
    # 1. Transform rubies (London, English-in-RB)
    ruby_pattern = re.compile(r'<RUBY><RB>(.*?)</RB><RT>(.*?)</RT></RUBY>', re.DOTALL)
    text = ruby_pattern.sub(transform_ruby, text)
    
    # 2. Harmonize 'Dieu de la Mort' -> 'Faucheur'
    # Fix double space before color tag: 'le  <E516 54>' -> 'le <E516 54>'
    text = re.sub(r'\ble\s{2,}(<E516\s+\d+>)', r'le \1', text)
    
    # Contextual replacements
    text = re.sub(r'qui hante le tribunal de Old Bailey', "qui hante le tribunal d'Old Bailey", text)
    text = re.sub(r'tribunal de Old Bailey', "tribunal d'Old Bailey", text)
    text = re.sub(r'du tribunal de Old Bailey', "du tribunal d'Old Bailey", text)
    
    # Ryûnosuke thought line
    text = text.replace('"Dieu de la Mort"? Comme un shinigami', '« Faucheur » ? Comme un shinigami')
    text = text.replace('"Dieu de la Mort" ? Comme un shinigami', '« Faucheur » ? Comme un shinigami')
    
    # Grammatical replacements for Dieu de la Mort
    text = re.sub(r'\bdu\s+Dieu\s+de\s+la\s+Mort\b', 'du Faucheur', text)
    text = re.sub(r'\bau\s+Dieu\s+de\s+la\s+Mort\b', 'au Faucheur', text)
    text = re.sub(r'\bce\s+Dieu\s+de\s+la\s+Mort\b', 'ce Faucheur', text)
    text = re.sub(r'\bun\s+Dieu\s+de\s+la\s+Mort\b', 'un Faucheur', text)
    text = re.sub(r'\bun\s+dieu\s+de\s+la\s+mort\b', 'un faucheur', text)
    text = re.sub(r'\bLe\s+Dieu\s+de\s+la\s+Mort\b', 'Le Faucheur', text)
    text = re.sub(r'\ble\s+Dieu\s+de\s+la\s+Mort\b', 'le Faucheur', text)
    text = re.sub(r'["«]\s*Dieu\s+de\s+la\s+Mort\s*["»]', '« Faucheur »', text)
    text = re.sub(r'\bDieu\s+de\s+la\s+Mort\b', 'Faucheur', text)
    text = re.sub(r'\bdieu\s+de\s+la\s+mort\b', 'faucheur', text)
    
    # 3. Harmonize 'Bande mouchetée' in titles, demo and textcuts
    text = text.replace("L'aventure de l'incassable bande mouchetée", "L'aventure de l'incassable ruban moucheté")
    text = text.replace("l'incassable bande mouchetée", "l'incassable ruban moucheté")
    text = text.replace("cette bande mouchetée...", "ce ruban moucheté...")
    text = text.replace('"bande mouchetée"', '"ruban moucheté"')
    text = text.replace("comme une bande mouchetée", "comme un ruban moucheté")
    text = text.replace("La Bande Mouchetée", "Le Ruban moucheté")
    text = text.replace("la bande mouchetée", "le ruban moucheté")
    text = text.replace("câble moucheté", "ruban moucheté")
    text = text.replace("cable moucheté", "ruban moucheté")
    
    # 4. Typographical fixes from images (Lord Chief Justice library)
    text = text.replace("mais viennent de toute<E516 231>l'Europe<E519> .", "mais viennent de toute <E516 231>l'Europe<E519>.")
    text = text.replace("toute<E516 231>l'Europe<E519> .", "toute <E516 231>l'Europe<E519>.")
    text = text.replace("de toutel'Europe .", "de toute l'Europe.")
    text = text.replace("<E516 216>France<E519> ,", "<E516 216>France<E519>,")
    text = text.replace("<E516 137>Allemagne<E519> ,", "<E516 137>Allemagne<E519>,")
    text = text.replace("<E516 232>Espagne<E519> ,", "<E516 232>Espagne<E519>,")
    text = text.replace("<E516 23>russe<E519> .", "<E516 23>russe<E519>.")
    text = text.replace("de Saô ,", "de Sôseki,")
    
    # 5. Fix spacing typos before and after formatting tags
    text = text.replace("la<E507 a b>Crystal Tower", "la <E507 a b>Crystal Tower")
    text = text.replace("cette<E516 56>banquette", "cette <E516 56>banquette")
    text = text.replace("qu'un<E516 56>kimono", "qu'un <E516 56>kimono")
    text = re.sub(r'\b([a-zA-ZÀ-ÿ]{2,})(<E5[01][67][^>]*>)', r'\1 \2', text)
    text = re.sub(r'(<E519>)([a-zA-ZÀ-ÿ]{2,})', r'\1 \2', text)
    
    # Strip dummy rubies with blank RT
    text = re.sub(r'<RUBY><RB>(.*?)</RB><RT>\s*(?:<COL[^>]*>)?\s*(?:</COL>)?\s*</RT></RUBY>', r'\1', text, flags=re.DOTALL)

    # Clean the double ruby for London World Fair in sce02
    text = re.sub(r'<E516 211><RUBY><RB>\s*pour la London\s*</RB><RT>.*?</RT></RUBY><E519>\s*<E516 160><RUBY><RB>\s*World Fair\s*</RB><RT>.*?</RT></RUBY><E519>',
                  r"pour l'Exposition Universelle de London", text, flags=re.DOTALL)
    
    # London harmonization
    text = text.replace("dans Londres", "dans London")
    text = text.replace("surnomme <E003 8><E516 211>Londres", "surnomme <E003 8><E516 211>London")
    text = text.replace("surnomme Londres", "surnomme London")
    
    return text, (text != orig_text)

def patch_gmd_bytes(gmd_bytes, entry_name=""):
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
    
    for r in raw_strings:
        try:
            s = r.decode('utf-8')
            new_s, changed = patch_string_content(s, entry_name)
            if changed:
                modified_count += 1
                new_raw_strings.append(new_s.encode('utf-8'))
            else:
                new_raw_strings.append(r)
        except UnicodeDecodeError:
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

def patch_arc_file(arc_path):
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
        patched, mod_count = patch_gmd_bytes(e['data'], e['name'])
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
    print(f"Patched {arc_path.name}: {total_mod} strings updated.")
    return total_mod

def main():
    root = Path(r'D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive')
    print("Applying Step 1 fixes to game archives...")
    
    # Archives to inspect and patch
    target_arcs = [
        # Common title/menu/slot archives
        root / 'msg_cmn_eng.arc',
        root / 'msg_sys_eng.arc',
        root / 'special_cmn_eng.arc',
        root / 'GO' / 'msg_title_eng.arc',
        root / 'BB' / 'msg_title_eng.arc',
        # DGS1 Dialogue scripts
        root / 'GO' / 'sce00_eng.arc',
        root / 'GO' / 'sce01_eng.arc',
        root / 'GO' / 'sce02_eng.arc',
        root / 'GO' / 'sce03_eng.arc',
        root / 'GO' / 'sce04_eng.arc',
        # DGS2 Dialogue scripts
        root / 'BB' / 'sce00_eng.arc',
        root / 'BB' / 'sce01_eng.arc',
        root / 'BB' / 'sce02_eng.arc',
        root / 'BB' / 'sce03_eng.arc',
        root / 'BB' / 'sce04_eng.arc',
    ]
    
    total_patched_strings = 0
    patched_files = 0
    
    for ap in target_arcs:
        if ap.exists():
            cnt = patch_arc_file(ap)
            if cnt > 0:
                total_patched_strings += cnt
                patched_files += 1
                
    print(f"\nDone! Updated {total_patched_strings} strings across {patched_files} archives.")

if __name__ == '__main__':
    main()
