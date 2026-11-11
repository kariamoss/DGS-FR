using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DgsPatcher;

class ApplyRubanMouchete
{
    static string ReplaceMouchet(string text)
    {
        // Handle precise patterns first (gender agreements)
        // Title / Capitlized
        text = text.Replace("The Speckled Band [La Bande Mouchetée]", "The Speckled Band [Le Ruban Moucheté]");
        text = text.Replace("Ｌａ Ｂａｎｄｅ Ｍｏｕｃｈｅｔ￉ｅ", "Ｌｅ Ｒｕｂａｎ Ｍｏｕｃｈｅｔ￉");
        text = text.Replace("L-La \\\"Bande Mouchetée\\\"", "L-Le \\\"Ruban Moucheté\\\"");
        text = text.Replace("L-La \"Bande Mouchetée\"", "L-Le \"Ruban Moucheté\"");
        text = text.Replace("de \\\"La bande mouchetée\\\"", "du \\\"Ruban moucheté\\\"");
        text = text.Replace("de \"La bande mouchetée\"", "du \"Ruban moucheté\"");
        text = text.Replace("de \\\"La \\u003cE516 33\\u003ebande\\u003cE519\\u003e mouchetée\\\"", "du \\\"\\u003cE516 33\\u003eRuban\\u003cE519\\u003e moucheté\\\"");
        text = text.Replace("de \"La <E516 33>bande<E519> mouchetée\"", "du \"<E516 33>Ruban<E519> moucheté\"");
        text = text.Replace("Bande Mouchetée", "Ruban Moucheté");
        text = text.Replace("Bande mouchetée", "Ruban moucheté");

        // Feminine -> Masculine agreements
        text = text.Replace("la terrifiante bande mouchetée", "le terrifiant ruban moucheté");
        text = text.Replace("la mystérieuse bande mouchetée", "le mystérieux ruban moucheté");
        text = text.Replace("la véritable identité de la terrifiante bande mouchetée", "la véritable identité du terrifiant ruban moucheté");
        text = text.Replace("la véritable identité de la bande mouchetée", "la véritable identité du ruban moucheté");
        text = text.Replace("la véritable nature de la bande mouchetée", "la véritable nature du ruban moucheté");
        text = text.Replace("de la bande mouchetée", "du ruban moucheté");
        text = text.Replace("sur la bande mouchetée", "sur le ruban moucheté");
        text = text.Replace("cette bande mouchetée", "ce ruban moucheté");
        text = text.Replace("cette \\\"bande mouchetée\\\"", "ce \\\"ruban moucheté\\\"");
        text = text.Replace("cette \"bande mouchetée\"", "ce \"ruban moucheté\"");
        text = text.Replace("pour cette bande mouchetée", "pour ce ruban moucheté");
        text = text.Replace("le sens de cette bande mouchetée", "le sens de ce ruban moucheté");
        text = text.Replace("remarquant cette bande mouchetée", "remarquant ce ruban moucheté");
        text = text.Replace("Une bande... mouchetée", "Un ruban... moucheté");
        text = text.Replace("Une bande...... mouchetée", "Un ruban...... moucheté");
        text = text.Replace("Une bande mouchetée", "Un ruban moucheté");
        text = text.Replace("une bande mouchetée", "un ruban moucheté");
        text = text.Replace("une \\\"bande mouchetée\\\"", "un \\\"ruban moucheté\\\"");
        text = text.Replace("une \"bande mouchetée\"", "un \"ruban moucheté\"");
        text = text.Replace("bande mouchetée", "ruban moucheté");

        // Handle tags in raw strings:
        // bande <E516 33>mouchetée<E519> -> ruban <E516 33>moucheté<E519>
        text = text.Replace("cette \\\"\\u003cE006\\u003ebande \\u003cE516 33\\u003emouchetée", "ce \\\"\\u003cE006\\u003eruban \\u003cE516 33\\u003emoucheté");
        text = text.Replace("cette \"<E006>bande <E516 33>mouchetée", "ce \"<E006>ruban <E516 33>moucheté");
        text = text.Replace("une \\\"\\u003cE006\\u003ebande mouchetée", "un \\\"\\u003cE006\\u003eruban moucheté");
        text = text.Replace("une \"<E006>bande mouchetée", "un \"<E006>ruban moucheté");
        text = text.Replace("une \\u003cE006\\u003ebande mouchetée", "un \\u003cE006\\u003eruban moucheté");
        text = text.Replace("une <E006>bande mouchetée", "un <E006>ruban moucheté");
        text = text.Replace("la \\u003cE006\\u003ebande mouchetée", "le \\u003cE006\\u003eruban moucheté");
        text = text.Replace("la <E006>bande mouchetée", "le <E006>ruban moucheté");
        text = text.Replace("Une bande\\u003cE025 6\\u003e......\\u003cE003 10\\u003e\\u003cE025 3\\u003e mouchetée", "Un ruban\\u003cE025 6\\u003e......\\u003cE003 10\\u003e\\u003cE025 3\\u003e moucheté");
        text = text.Replace("Une bande<E025 6>......<E003 10><E025 3> mouchetée", "Un ruban<E025 6>......<E003 10><E025 3> moucheté");

        return text;
    }

    static void PatchJsonl(string path)
    {
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);
        int changed = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("mouchet") || lines[i].Contains("Mouchet"))
            {
                // Preserve "ce serpent, il n'est pas très moucheté" and "on ne peut pas le qualifier de moucheté"
                string before = lines[i];
                string after = ReplaceMouchet(before);
                if (before != after)
                {
                    lines[i] = after;
                    changed++;
                }
            }
        }
        File.WriteAllLines(path, lines, Encoding.UTF8);
        Console.WriteLine("Patched {0} lines in {1}", changed, Path.GetFileName(path));
    }

    static void PatchArc(string arcPath)
    {
        var arc = ArcFile.Read(arcPath);
        int totalReplaced = 0;

        foreach (var entry in arc.Entries)
        {
            byte[] gmd = entry.Data;
            if (gmd == null || gmd.Length < 40) continue;
            string magic = Encoding.ASCII.GetString(gmd, 0, 4);
            if (magic != "GMD\0") continue;

            uint strBlockSize = BitConverter.ToUInt32(gmd, 32);
            int strStart = gmd.Length - (int)strBlockSize;
            if (strStart < 40 || strStart >= gmd.Length) continue;

            List<string> strings = new List<string>();
            List<byte> curr = new List<byte>();
            for (int i = strStart; i < gmd.Length; i++)
            {
                if (gmd[i] == 0)
                {
                    strings.Add(Encoding.UTF8.GetString(curr.ToArray()));
                    curr.Clear();
                }
                else
                {
                    curr.Add(gmd[i]);
                }
            }

            bool anyReplaced = false;
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].Contains("mouchet") || strings[i].Contains("Mouchet"))
                {
                    string before = strings[i];
                    string after = ReplaceMouchet(before);
                    if (before != after)
                    {
                        strings[i] = after;
                        anyReplaced = true;
                        totalReplaced++;
                    }
                }
            }

            if (anyReplaced)
            {
                using (MemoryStream newStrBlock = new MemoryStream())
                {
                    foreach (var s in strings)
                    {
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

        arc.Save(arcPath);
        Console.WriteLine("Replaced {0} strings in {1}", totalReplaced, Path.GetFileName(arcPath));
    }

    static void Main()
    {
        Console.WriteLine("=== Applying 'Le Ruban moucheté' ===");
        PatchJsonl(@"analyse\data\DGS1_ep2.jsonl");
        PatchJsonl(@"analyse\data\DGS1_ep4.jsonl");

        PatchArc(@"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO\sce01_eng.arc");
        PatchArc(@"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO\sce03_eng.arc");
        Console.WriteLine("=== Done applying 'Le Ruban moucheté' ===");
    }
}
