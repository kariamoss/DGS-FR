using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static string UnescapeJson(string s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '\\' && i + 1 < s.Length) {
                char next = s[i + 1];
                if (next == '\\') { sb.Append('\\'); i++; }
                else if (next == '"') { sb.Append('"'); i++; }
                else if (next == 'n') { sb.Append('\n'); i++; }
                else if (next == 'r') { sb.Append('\r'); i++; }
                else if (next == 't') { sb.Append('\t'); i++; }
                else if (next == 'u' && i + 5 < s.Length) {
                    string hex = s.Substring(i + 2, 4);
                    sb.Append((char)Convert.ToInt32(hex, 16));
                    i += 5;
                } else {
                    sb.Append(next); i++;
                }
            } else {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }

    static string EscapeJson(string s) {
        if (s == null) return "";
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            switch (c) {
                case '\\': sb.Append("\\\\"); break;
                case '"': sb.Append("\\\""); break;
                case '\b': sb.Append("\\b"); break;
                case '\f': sb.Append("\\f"); break;
                case '\n': sb.Append("\\n"); break;
                case '\r': sb.Append("\\r"); break;
                case '\t': sb.Append("\\t"); break;
                default:
                    if (c < ' ') {
                        sb.AppendFormat("\\u{0:x4}", (int)c);
                    } else {
                        sb.Append(c);
                    }
                    break;
            }
        }
        return sb.ToString();
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var d = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase);
        Ep4Fixes.Part1.Register(d);
        Ep4Fixes.Part2.Register(d);
        Ep4Fixes.Part3.Register(d);
        Console.WriteLine("Fixes enregistres : " + d.Count);

        string jsonPath = @"analyse\data\sce03_fr.json";
        string json = File.ReadAllText(jsonPath, Encoding.UTF8);
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        var sb = new StringBuilder();
        sb.AppendLine("[");
        bool firstEntry = true;
        int fixedCount = 0;
        int totalItems = 0;
        int stillSame = 0;

        foreach (Match em in entryMatches)
        {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;

            if (!firstEntry) sb.AppendLine(",");
            firstEntry = false;

            sb.AppendLine("  {");
            sb.AppendLine("    \"EntryName\": \"" + entryName.Replace("\\", "\\\\") + "\",");
            sb.AppendLine("    \"Items\": [");

            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            bool firstItem = true;

            foreach (Match im in itemMatches)
            {
                totalItems++;
                string idx = im.Groups[1].Value;
                string en = UnescapeJson(im.Groups[2].Value);
                string fr = UnescapeJson(im.Groups[3].Value);

                string key = entryName + "#" + idx;
                if (d.ContainsKey(key))
                {
                    string fixedFr = d[key](en);
                    if (fixedFr != en)
                    {
                        fr = fixedFr;
                        fixedCount++;
                    }
                }

                if (fr == en)
                {
                    stillSame++;
                }

                if (!firstItem) sb.AppendLine(",");
                firstItem = false;

                sb.Append("      {\n");
                sb.Append("        \"Index\": " + idx + ",\n");
                sb.Append("        \"En\": \"" + EscapeJson(en) + "\",\n");
                sb.Append("        \"Fr\": \"" + EscapeJson(fr) + "\"\n");
                sb.Append("      }");
            }

            sb.AppendLine();
            sb.AppendLine("    ]");
            sb.Append("  }");
        }
        sb.AppendLine();
        sb.AppendLine("]");

        File.WriteAllText(jsonPath, sb.ToString(), Encoding.UTF8);

        Console.WriteLine("Total items inspectes : " + totalItems);
        Console.WriteLine("Items corriges par Fix_Ep4 : " + fixedCount);
        Console.WriteLine("Items avec En == Fr restants : " + stillSame);

        // Inject into arc
        string baseArc = @"backup_bb\sce03_eng.arc";
        string outArc = @"analyse\patched\BB\sce03_eng.arc";
        DgsTranslatorTool.Program.Inject(baseArc, jsonPath, outArc);
        Console.WriteLine("ARC sce03_eng.arc injecte avec succes dans : " + outArc);
    }
}
