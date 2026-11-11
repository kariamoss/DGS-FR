using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DgsTranslatorTool;

class MergeEp3 {
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

    static void Main() {
        Console.OutputEncoding = Encoding.UTF8;
        var transMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        string[] actFiles = new string[] {
            @"analyse\trans_ep3\act1_intro_translated.json",
            @"analyse\trans_ep3\act2_trial1_translated.json",
            @"analyse\trans_ep3\act3_investigation_translated.json",
            @"analyse\trans_ep3\act4_trial2_translated.json",
            @"analyse\trans_ep3\act5_trial3_translated.json",
            @"analyse\trans_ep3\act6_characters_evidence_translated.json"
        };

        foreach (string actFile in actFiles) {
            string json = File.ReadAllText(actFile, Encoding.UTF8);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;
                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
                foreach (Match im in itemMatches) {
                    string idx = im.Groups[1].Value;
                    string fr = UnescapeJson(im.Groups[3].Value);
                    if (!string.IsNullOrEmpty(fr)) {
                        transMap[entryName + "#" + idx] = fr;
                    }
                }
            }
        }

        Console.WriteLine("Total répliques traduites chargées : " + transMap.Count);

        string baseJson = File.ReadAllText(@"analyse\data\sce02_en.json", Encoding.UTF8);
        MatchCollection baseEntryMatches = Regex.Matches(baseJson, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("[");
        bool firstEntry = true;
        int mergedCount = 0;

        foreach (Match em in baseEntryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;

            if (!firstEntry) sb.AppendLine(",");
            firstEntry = false;

            sb.AppendLine("  {");
            sb.AppendLine("    \"EntryName\": \"" + entryName.Replace("\\", "\\\\") + "\",");
            sb.AppendLine("    \"Items\": [");

            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            bool firstItem = true;

            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string en = UnescapeJson(im.Groups[2].Value);
                string fr = "";

                string key = entryName + "#" + idx;
                if (transMap.ContainsKey(key)) {
                    fr = transMap[key];
                    mergedCount++;
                }

                if (!firstItem) sb.AppendLine(",");
                firstItem = false;
                sb.Append("      { \"Index\": " + idx + ", \"En\": \"" + EscapeJson(en) + "\", \"Fr\": \"" + EscapeJson(fr) + "\" }");
            }

            sb.AppendLine("\n    ]");
            sb.Append("  }");
        }

        sb.AppendLine("\n]");
        File.WriteAllText(@"analyse\data\sce02_fr.json", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Fusion terminée : " + mergedCount + " répliques fusionnées dans analyse\\data\\sce02_fr.json");

        // Injection
        string baseArc = @"backup_bb\sce02_eng.arc";
        string outArcDir = @"analyse\patched\BB";
        if (!Directory.Exists(outArcDir)) Directory.CreateDirectory(outArcDir);
        string outArc = Path.Combine(outArcDir, "sce02_eng.arc");

        DgsTranslatorTool.Program.Inject(baseArc, @"analyse\data\sce02_fr.json", outArc);
        Console.WriteLine("ARC compilé avec succès dans : " + outArc);

        // Copie vers le jeu
        string gameTarget = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\BB\sce02_eng.arc";
        File.Copy(outArc, gameTarget, true);
        Console.WriteLine("ARC déployé avec succès dans : " + gameTarget);
    }
}
