using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DumpEp5Acts {
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

    class Item {
        public int Index;
        public string En;
        public string Fr;
    }

    class Entry {
        public string EntryName;
        public List<Item> Items = new List<Item>();
    }

    static void Main() {
        Console.OutputEncoding = Encoding.UTF8;
        string json = File.ReadAllText(@"analyse\data\sce04_en.json", Encoding.UTF8);

        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        List<Entry> act1 = new List<Entry>();
        List<Entry> act2 = new List<Entry>();
        List<Entry> act3 = new List<Entry>();
        List<Entry> act4 = new List<Entry>();
        List<Entry> act5 = new List<Entry>();

        int totalItems = 0;

        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;

            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);

            List<Item> currentItems = new List<Item>();
            foreach (Match im in itemMatches) {
                string en = UnescapeJson(im.Groups[2].Value);
                string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                    currentItems.Add(new Item {
                        Index = int.Parse(im.Groups[1].Value),
                        En = en,
                        Fr = ""
                    });
                    totalItems++;
                }
            }

            if (currentItems.Count == 0) continue;

            Entry ent = new Entry { EntryName = entryName, Items = currentItems };
            string lower = entryName.ToLowerInvariant();

            if (lower.Contains("_c1") || lower.Contains("_c2")) {
                act1.Add(ent);
            } else if (lower.Contains("_c3")) {
                act2.Add(ent);
            } else if (lower.Contains("_c4")) {
                act3.Add(ent);
            } else if (lower.Contains("_c5") || lower.Contains("_c6") || lower.Contains("_bg05")) {
                act4.Add(ent);
            } else {
                act5.Add(ent);
            }
        }

        WriteAct(@"analyse\trans_ep5\act1_trial1.json", act1);
        WriteAct(@"analyse\trans_ep5\act2_investigation.json", act2);
        WriteAct(@"analyse\trans_ep5\act3_trial2.json", act3);
        WriteAct(@"analyse\trans_ep5\act4_resolution_bg.json", act4);
        WriteAct(@"analyse\trans_ep5\act5_evidence_macro_chr.json", act5);

        Console.WriteLine("Total items to translate: " + totalItems);
    }

    static void WriteAct(string path, List<Entry> entries) {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("[");
        int count = 0;
        for (int i = 0; i < entries.Count; i++) {
            var ent = entries[i];
            sb.AppendLine("  {");
            sb.AppendLine("    \"EntryName\": \"" + ent.EntryName.Replace("\\", "\\\\") + "\",");
            sb.AppendLine("    \"Items\": [");
            for (int j = 0; j < ent.Items.Count; j++) {
                var it = ent.Items[j];
                count++;
                sb.Append("      { \"Index\": " + it.Index + ", \"En\": \"" + EscapeJson(it.En) + "\", \"Fr\": \"\" }");
                if (j + 1 < ent.Items.Count) sb.AppendLine(",");
                else sb.AppendLine();
            }
            sb.AppendLine("    ]");
            sb.Append("  }");
            if (i + 1 < entries.Count) sb.AppendLine(",");
            else sb.AppendLine();
        }
        sb.AppendLine("]");
        File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Saved " + path + " (" + entries.Count + " entries, " + count + " items)");
    }
}
