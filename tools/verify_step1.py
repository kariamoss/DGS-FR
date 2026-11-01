import struct, zlib, sys, re
from pathlib import Path
sys.stdout.reconfigure(encoding='utf-8')

root = Path(r'D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive')

dieu_count = 0
london_ruby_count = 0
bande_mouchete_count = 0
faucheur_count = 0

sample_lines = []

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
                    
                    # Count dieu de la mort
                    m_dieu = re.findall(r'dieu de la mort', text, re.IGNORECASE)
                    dieu_count += len(m_dieu)
                    
                    # Count faucheur
                    m_fauch = re.findall(r'faucheur', text, re.IGNORECASE)
                    faucheur_count += len(m_fauch)
                    
                    # Count London rubies
                    m_lon = re.findall(r'<RUBY><RB>London</RB>', text, re.IGNORECASE)
                    london_ruby_count += len(m_lon)
                    
                    # Count bande mouchetée
                    m_bande = re.findall(r'bande mouchet', text, re.IGNORECASE)
                    bande_mouchete_count += len(m_bande)
                    
                    # Check specific samples
                    if '_sce02_c101_0000_eng' in name:
                        for line in text.split('\x00'):
                            if 'hante le tribunal' in line:
                                sample_lines.append(('Capture 2 (Yûno)', repr(line)))
                    if '_sce02_bg0200_3d_check_0_eng' in name:
                        for line in text.split('\x00'):
                            if "l'Europe" in line:
                                sample_lines.append(('Capture 1 (Amimo)', repr(line)))
                    if 'opdemo01_eng' in name:
                        for line in text.split('\x00'):
                            if 'mouchet' in line:
                                sample_lines.append(('Cinématique OpDemo01', repr(line)))
                    if 'title_slot_eng' in name:
                        for line in text.split('\x00'):
                            if 'mouchet' in line:
                                sample_lines.append(('Sauvegardes title_slot', repr(line)))
    except Exception as e:
        pass

print('=== AUDIT RESULTS AFTER STEP 1 ===')
print(f'Remaining "Dieu de la Mort": {dieu_count}')
print(f'New "Faucheur" count      : {faucheur_count}')
print(f'Remaining London rubies    : {london_ruby_count}')
print(f'Remaining "bande mouchetée": {bande_mouchete_count}')
print('\n=== SAMPLES VERIFICATION ===')
for label, content in sample_lines:
    print(f'[{label}]:\n  {content}\n')
