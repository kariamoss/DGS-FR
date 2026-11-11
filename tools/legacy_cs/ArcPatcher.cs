using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Collections.Generic;

namespace DgsPatcher {
    public static class ZlibHelper {
        public static uint ComputeAdler32(byte[] data) {
            uint a = 1, b = 0;
            for (int i = 0; i < data.Length; i++) {
                a = (a + data[i]) % 65521;
                b = (b + data[i] * (uint)(data.Length - i)) % 65521; // standard adler-32
            }
            // Standard loop
            a = 1; b = 0;
            for (int i = 0; i < data.Length; i++) {
                a = (a + data[i]) % 65521;
                b = (b + a) % 65521;
            }
            return (b << 16) | a;
        }

        public static byte[] CompressZlib(byte[] data) {
            using (MemoryStream ms = new MemoryStream()) {
                ms.WriteByte(0x78);
                ms.WriteByte(0x9C);
                using (DeflateStream deflate = new DeflateStream(ms, CompressionMode.Compress, true)) {
                    deflate.Write(data, 0, data.Length);
                }
                uint adler = ComputeAdler32(data);
                ms.WriteByte((byte)((adler >> 24) & 0xFF));
                ms.WriteByte((byte)((adler >> 16) & 0xFF));
                ms.WriteByte((byte)((adler >> 8) & 0xFF));
                ms.WriteByte((byte)(adler & 0xFF));
                return ms.ToArray();
            }
        }

        public static byte[] DecompressZlib(byte[] zlib) {
            using (MemoryStream ms = new MemoryStream(zlib, 2, zlib.Length - 6))
            using (DeflateStream deflate = new DeflateStream(ms, CompressionMode.Decompress))
            using (MemoryStream outMs = new MemoryStream()) {
                deflate.CopyTo(outMs);
                return outMs.ToArray();
            }
        }
    }

    public class ArcEntry {
        public string Name;
        public uint TypeHash;
        public uint CSize;
        public uint USize;
        public uint Flags;
        public uint Offset;
        public byte[] Data; // Decompressed data
    }

    public class ArcFile {
        public ushort Version;
        public ushort FileCount;
        public List<ArcEntry> Entries = new List<ArcEntry>();

        public static ArcFile Read(string path) {
            byte[] bytes = File.ReadAllBytes(path);
            ArcFile arc = new ArcFile();
            arc.Version = BitConverter.ToUInt16(bytes, 4);
            arc.FileCount = BitConverter.ToUInt16(bytes, 6);

            int offset = 8;
            for (int i = 0; i < arc.FileCount; i++) {
                ArcEntry entry = new ArcEntry();
                entry.Name = Encoding.ASCII.GetString(bytes, offset, 128).TrimEnd('\0');
                entry.TypeHash = BitConverter.ToUInt32(bytes, offset + 128);
                entry.CSize = BitConverter.ToUInt32(bytes, offset + 132);
                uint uSizeWithFlags = BitConverter.ToUInt32(bytes, offset + 136);
                entry.USize = uSizeWithFlags & 0x1FFFFFFF;
                entry.Flags = uSizeWithFlags & 0xE0000000;
                entry.Offset = BitConverter.ToUInt32(bytes, offset + 140);

                if (entry.CSize > 6) {
                    byte[] compData = new byte[entry.CSize];
                    Array.Copy(bytes, entry.Offset, compData, 0, entry.CSize);
                    entry.Data = ZlibHelper.DecompressZlib(compData);
                } else {
                    entry.Data = new byte[0];
                }

                arc.Entries.Add(entry);
                offset += 144;
            }

            return arc;
        }

        public void Save(string path) {
            uint tableEnd = (uint)(8 + Entries.Count * 144);
            uint firstDataOffset = 0x8000; // 32768
            if (firstDataOffset < tableEnd) {
                firstDataOffset = ((tableEnd + 0x7FFF) / 0x8000) * 0x8000;
            }

            using (MemoryStream ms = new MemoryStream()) {
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(Encoding.ASCII.GetBytes("ARC\0"));
                bw.Write(Version);
                bw.Write((ushort)Entries.Count);

                List<byte[]> compDatas = new List<byte[]>();
                uint currentOffset = firstDataOffset;

                for (int i = 0; i < Entries.Count; i++) {
                    byte[] comp = ZlibHelper.CompressZlib(Entries[i].Data);
                    compDatas.Add(comp);
                    Entries[i].CSize = (uint)comp.Length;
                    Entries[i].USize = (uint)Entries[i].Data.Length;
                    Entries[i].Offset = currentOffset;
                    currentOffset += (uint)comp.Length;
                }

                for (int i = 0; i < Entries.Count; i++) {
                    byte[] nameBytes = new byte[128];
                    byte[] asciiName = Encoding.ASCII.GetBytes(Entries[i].Name);
                    Array.Copy(asciiName, nameBytes, Math.Min(asciiName.Length, 128));
                    bw.Write(nameBytes);
                    bw.Write(Entries[i].TypeHash);
                    bw.Write(Entries[i].CSize);
                    uint uSizeWithFlags = (Entries[i].USize & 0x1FFFFFFF) | Entries[i].Flags;
                    bw.Write(uSizeWithFlags);
                    bw.Write(Entries[i].Offset);
                }

                long currentPos = ms.Position;
                if (currentPos < firstDataOffset) {
                    byte[] pad = new byte[firstDataOffset - currentPos];
                    bw.Write(pad);
                }

                for (int i = 0; i < Entries.Count; i++) {
                    bw.Write(compDatas[i]);
                }

                File.WriteAllBytes(path, ms.ToArray());
            }
        }

        // Remplace chirurgicalement une chaîne dans un fichier GMD
        public bool ReplaceInGMD(string entryName, string targetText, string replacementText) {
            foreach (var entry in Entries) {
                if (entry.Name.Equals(entryName, StringComparison.OrdinalIgnoreCase)) {
                    byte[] gmd = entry.Data;
                    if (gmd.Length < 40) return false;
                    string magic = Encoding.ASCII.GetString(gmd, 0, 4);
                    if (magic != "GMD\0") return false;

                    uint strBlockSize = BitConverter.ToUInt32(gmd, 32);
                    int strStart = gmd.Length - (int)strBlockSize;

                    // Découper les chaînes null-terminated
                    List<string> strings = new List<string>();
                    List<byte> curr = new List<byte>();
                    for (int i = strStart; i < gmd.Length; i++) {
                        if (gmd[i] == 0) {
                            strings.Add(Encoding.UTF8.GetString(curr.ToArray()));
                            curr.Clear();
                        } else {
                            curr.Add(gmd[i]);
                        }
                    }

                    bool replaced = false;
                    for (int i = 0; i < strings.Count; i++) {
                        if (strings[i].Contains(targetText)) {
                            strings[i] = strings[i].Replace(targetText, replacementText);
                            replaced = true;
                        }
                    }

                    if (replaced) {
                        // Reconstruire le StringBlock
                        using (MemoryStream newStrBlock = new MemoryStream()) {
                            foreach (var s in strings) {
                                byte[] strBytes = Encoding.UTF8.GetBytes(s);
                                newStrBlock.Write(strBytes, 0, strBytes.Length);
                                newStrBlock.WriteByte(0); // terminateur null
                            }
                            byte[] newBlockBytes = newStrBlock.ToArray();
                            uint newStrBlockSize = (uint)newBlockBytes.Length;

                            // Reconstruire tout le GMD : header + tables + new string block
                            byte[] newGmd = new byte[strStart + newBlockBytes.Length];
                            Array.Copy(gmd, 0, newGmd, 0, strStart);
                            // Mettre à jour StrBlockSize à l'offset 32
                            byte[] sizeBytes = BitConverter.GetBytes(newStrBlockSize);
                            Array.Copy(sizeBytes, 0, newGmd, 32, 4);
                            // Copier le nouveau StringBlock
                            Array.Copy(newBlockBytes, 0, newGmd, strStart, newBlockBytes.Length);

                            entry.Data = newGmd;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Remplace une chaîne dans TOUS les fichiers GMD de l'archive
        public int ReplaceInAllGMDs(string targetText, string replacementText) {
            int totalCount = 0;
            foreach (var entry in Entries) {
                byte[] gmd = entry.Data;
                if (gmd == null || gmd.Length < 40) continue;
                string magic = Encoding.ASCII.GetString(gmd, 0, 4);
                if (magic != "GMD\0") continue;

                uint strBlockSize = BitConverter.ToUInt32(gmd, 32);
                int strStart = gmd.Length - (int)strBlockSize;
                if (strStart < 40 || strStart >= gmd.Length) continue;

                List<string> strings = new List<string>();
                List<byte> curr = new List<byte>();
                for (int i = strStart; i < gmd.Length; i++) {
                    if (gmd[i] == 0) {
                        strings.Add(Encoding.UTF8.GetString(curr.ToArray()));
                        curr.Clear();
                    } else {
                        curr.Add(gmd[i]);
                    }
                }

                bool modified = false;
                for (int i = 0; i < strings.Count; i++) {
                    if (strings[i].Contains(targetText)) {
                        strings[i] = strings[i].Replace(targetText, replacementText);
                        modified = true;
                        totalCount++;
                    }
                }

                if (modified) {
                    using (MemoryStream newStrBlock = new MemoryStream()) {
                        foreach (var s in strings) {
                            byte[] strBytes = Encoding.UTF8.GetBytes(s);
                            newStrBlock.Write(strBytes, 0, strBytes.Length);
                            newStrBlock.WriteByte(0);
                        }
                        byte[] newBlockBytes = newStrBlock.ToArray();
                        uint newStrBlockSize = (uint)newBlockBytes.Length;

                        byte[] newGmd = new byte[strStart + newBlockBytes.Length];
                        Array.Copy(gmd, 0, newGmd, 0, strStart);
                        byte[] sizeBytes = BitConverter.GetBytes(newStrBlockSize);
                        Array.Copy(sizeBytes, 0, newGmd, 32, 4);
                        Array.Copy(newBlockBytes, 0, newGmd, strStart, newBlockBytes.Length);

                        entry.Data = newGmd;
                    }
                }
            }
            return totalCount;
        }
    }
}
