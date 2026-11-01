using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DgsPatcher;

class OccidentalizeAllKanji
{
    static bool ContainsKanji(string s)
    {
        foreach (char c in s)
        {
            if (c >= 0x4E00 && c <= 0x9FFF) return true;
        }
        return false;
    }

    static string DecodeCapcomString(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";
        string s = Regex.Replace(input, @"<COL [^>]*>", "");
        s = s.Replace("</COL>", "");

        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if (c >= 0xFF01 && c <= 0xFF5E)
            {
                sb.Append((char)(c - 0xFEE0));
            }
            else if (c == 0x3000)
            {
                sb.Append(' ');
            }
            else if (c == 'ﾩ')
            {
                sb.Append('É');
            }
            else if (c == '￀')
            {
                sb.Append('à');
            }
            else if (c == 'ￂ')
            {
                sb.Append('â');
            }
            else if (c == 'ￇ')
            {
                sb.Append('ç');
            }
            else if (c == '￈')
            {
                sb.Append('è');
            }
            else if (c == '￉')
            {
                sb.Append('é');
            }
            else if (c == 'ￊ')
            {
                sb.Append('ê');
            }
            else if (c == 'ￎ')
            {
                sb.Append('î');
            }
            else if (c == 'ￏ')
            {
                sb.Append('ï');
            }
            else if (c == 'ￔ')
            {
                sb.Append('ô');
            }
            else if (c == 'ￛ')
            {
                sb.Append('û');
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString().Trim();
    }

    static string OccidentalizeRaw(string raw)
    {
        if (!raw.Contains("<RUBY>") || !ContainsKanji(raw)) return raw;

        string res = Regex.Replace(raw, @"(<E507[^>]*>|<E516[^>]*>)?\s*<RUBY><RB>(.*?)</RB><RT>(.*?)</RT></RUBY>\s*(<E519>)?", m => {
            string rb = m.Groups[2].Value.Trim();
            string rt = m.Groups[3].Value.Trim();
            if (ContainsKanji(rb))
            {
                return DecodeCapcomString(rt);
            }
            return m.Value;
        });

        res = Regex.Replace(res, @"([a-zàâéèêëîïôûç])([A-ZÀÂÉÈÊËÎÏÔÛÇ])", "$1 $2");
        res = Regex.Replace(res, @"\b(mes|mon|ton|son|un|une|le|la|les|ce|cet|cette|ces|du|de|des|en|au|aux|dans|par|sur|sous)([a-zA-ZàâéèêëîïôûçÀÂÉÈÊËÎÏÔÛÇ]+)\b", "$1 $2");
        res = Regex.Replace(res, @"[ \t]{2,}", " ");
        return res;
    }

    static string FixTextFR(string text)
    {
        string latin = @"[a-zA-Z0-9'’àâéèêëîïôûçÀÂÉÈÊËÎÏÔÛÇ]";
        string pattern = @"(" + latin + @"+)?([\u4e00-\u9fff\s]+)\[(.*?)\](" + latin + @"+)?";
        string res = Regex.Replace(text, pattern, m => {
            string preWord = m.Groups[1].Value;
            string kanji = m.Groups[2].Value.Trim();
            string content = DecodeCapcomString(m.Groups[3].Value.Trim());
            string postWord = m.Groups[4].Value;

            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(preWord))
            {
                sb.Append(preWord);
                if (!preWord.EndsWith("'") && !preWord.EndsWith("’")) sb.Append(' ');
            }
            sb.Append(content);
            if (!string.IsNullOrEmpty(postWord))
            {
                sb.Append(' ');
                sb.Append(postWord);
            }
            return sb.ToString();
        });

        res = Regex.Replace(res, @"([a-zàâéèêëîïôûç])([A-ZÀÂÉÈÊËÎÏÔÛÇ])", "$1 $2");
        res = Regex.Replace(res, @"[ \t]{2,}", " ");
        res = Regex.Replace(res, @" +([,.:;?!])", "$1");
        return res;
    }

    static string PatchJsonlLine(string line)
    {
        if (!line.Contains("TextFR") || !ContainsKanji(line)) return line;

        // Patch RawFR
        string patternRaw = @"\""RawFR\""\s*:\s*\""(.*?)\""(\s*,\s*\""|})";
        Match mRaw = Regex.Match(line, patternRaw, RegexOptions.Singleline);
        if (mRaw.Success && ContainsKanji(mRaw.Groups[1].Value))
        {
            string rawEscaped = mRaw.Groups[1].Value;
            string rawUnescaped = rawEscaped.Replace("\\u003c", "<").Replace("\\u003e", ">").Replace("\\\"", "\"");
            string patched = OccidentalizeRaw(rawUnescaped);
            string patchedEscaped = patched.Replace("\"", "\\\"").Replace("<", "\\u003c").Replace(">", "\\u003e");
            line = line.Substring(0, mRaw.Groups[1].Index) + patchedEscaped + line.Substring(mRaw.Groups[1].Index + mRaw.Groups[1].Length);
        }

        // Patch TextFR
        string patternText = @"\""TextFR\""\s*:\s*\""(.*?)\""(\s*,\s*\""|})";
        Match mText = Regex.Match(line, patternText, RegexOptions.Singleline);
        if (mText.Success && ContainsKanji(mText.Groups[1].Value))
        {
            string textVal = mText.Groups[1].Value;
            string patchedText = FixTextFR(textVal);
            line = line.Substring(0, mText.Groups[1].Index) + patchedText + line.Substring(mText.Groups[1].Index + mText.Groups[1].Length);
        }

        return line;
    }

    static void PatchJsonl(string path)
    {
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);
        int changed = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            if (ContainsKanji(lines[i]))
            {
                string before = lines[i];
                string after = PatchJsonlLine(before);
                if (before != after)
                {
                    lines[i] = after;
                    changed++;
                }
            }
        }
        File.WriteAllLines(path, lines, Encoding.UTF8);
        Console.WriteLine("Patched {0,4} lines in {1}", changed, Path.GetFileName(path));
    }

    static void PatchArc(string arcPath)
    {
        if (!File.Exists(arcPath))
        {
            Console.WriteLine("ARC not found: " + arcPath);
            return;
        }

        var arc = ArcFile.Read(arcPath);
        int totalStringsPatched = 0;

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
                if (ContainsKanji(strings[i]) && strings[i].Contains("<RUBY>"))
                {
                    string before = strings[i];
                    string after = OccidentalizeRaw(before);
                    if (before != after)
                    {
                        strings[i] = after;
                        anyReplaced = true;
                        totalStringsPatched++;
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
        Console.WriteLine("Replaced {0,4} strings in {1}", totalStringsPatched, Path.GetFileName(arcPath));
    }

    static void Main()
    {
        Console.WriteLine("=== 1. PATCHING JSONL FILES ===");
        string[] jsonlFiles = new string[] {
            @"analyse\data\DGS1_ep1.jsonl",
            @"analyse\data\DGS1_ep2.jsonl",
            @"analyse\data\DGS1_ep3.jsonl",
            @"analyse\data\DGS1_ep4.jsonl",
            @"analyse\data\DGS1_ep5.jsonl",
            @"analyse\data\DGS2_ep1.jsonl",
            @"analyse\data\DGS2_ep2.jsonl"
        };
        foreach (var jf in jsonlFiles)
        {
            PatchJsonl(jf);
        }

        Console.WriteLine("\n=== 2. PATCHING ARC ARCHIVES ===");
        string frBase = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\";
        string[] arcFiles = new string[] {
            frBase + @"GO\sce00_eng.arc",
            frBase + @"GO\sce01_eng.arc",
            frBase + @"GO\sce02_eng.arc",
            frBase + @"GO\sce03_eng.arc",
            frBase + @"GO\sce04_eng.arc",
            frBase + @"GO\msg_title_eng.arc",
            frBase + @"BB\sce00_eng.arc",
            frBase + @"BB\sce01_eng.arc",
            frBase + @"BB\msg_title_eng.arc"
        };
        foreach (var af in arcFiles)
        {
            PatchArc(af);
        }

        Console.WriteLine("\n=== OCCIDENTALIZATION COMPLETED SUCCESSFULLY ===");
    }
}
