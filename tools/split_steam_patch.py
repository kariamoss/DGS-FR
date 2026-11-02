import os

def split_file(input_path, output_dir, chunk_size=78643200):
    os.makedirs(output_dir, exist_ok=True)
    base_name = os.path.basename(input_path)
    part_num = 1
    
    with open(input_path, 'rb') as f:
        while True:
            chunk = f.read(chunk_size)
            if not chunk:
                break
            part_name = f"{base_name}.{part_num:03d}"
            part_path = os.path.join(output_dir, part_name)
            with open(part_path, 'wb') as out_f:
                out_f.write(chunk)
            print(f"Wrote {part_path} ({len(chunk)} bytes)")
            part_num += 1

if __name__ == '__main__':
    patch_file = r"C:\Users\Karia\.gemini\antigravity\scratch\DGS-FR\patch_steam.aapatch"
    out_dir = r"C:\Users\Karia\.gemini\antigravity\scratch\DGS-FR\release_patches"
    split_file(patch_file, out_dir)
