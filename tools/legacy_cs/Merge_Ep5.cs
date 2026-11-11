using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DgsTranslatorTool;

class MergeEp5 {
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
            @"analyse\trans_ep5\act1_trial1_translated.json",
            @"analyse\trans_ep5\act2_investigation_translated.json",
            @"analyse\trans_ep5\act3_trial2_translated.json",
            @"analyse\trans_ep5\act4_resolution_bg_translated.json",
            @"analyse\trans_ep5\act5_evidence_macro_chr_translated.json"
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

        Console.WriteLine("Total repliques traduites chargees : " + transMap.Count);

        string baseJson = File.ReadAllText(@"analyse\data\sce04_en.json", Encoding.UTF8);
        MatchCollection baseEntryMatches = Regex.Matches(baseJson, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("[");
        bool firstEntry = true;
        int mergedCount = 0;
        int missingCount = 0;

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

                string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                bool hasText = stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}");

                string key = entryName + "#" + idx;
                if (transMap.ContainsKey(key)) {
                    fr = transMap[key];
                    mergedCount++;
                } else if (hasText) {
                    Console.WriteLine("MANQUANT DANS SCE04 : " + key + " => " + en);
                    missingCount++;
                }

                if (!firstItem) sb.AppendLine(",");
                firstItem = false;
                sb.Append("      { \"Index\": " + idx + ", \"En\": \"" + EscapeJson(en) + "\", \"Fr\": \"" + EscapeJson(fr) + "\" }");
            }

            sb.AppendLine("\n    ]");
            sb.Append("  }");
        }

        sb.AppendLine("\n]");
        File.WriteAllText(@"analyse\data\sce04_fr.json", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Fusion terminee : " + mergedCount + " repliques fusionnees dans analyse\\data\\sce04_fr.json (Manquants : " + missingCount + ")");

        // Injection
        string baseArc = @"backup_bb\sce04_eng.arc";
        string outArcDir = @"analyse\patched\BB";
        if (!Directory.Exists(outArcDir)) Directory.CreateDirectory(outArcDir);
        string outArc = Path.Combine(outArcDir, "sce04_eng.arc");

        DgsTranslatorTool.Program.Inject(baseArc, @"analyse\data\sce04_fr.json", outArc);
        Console.WriteLine("ARC compile avec succes dans : " + outArc);

        // Copie vers archive_pure
        string pureArcDir = @"analyse\archive_pure\BB";
        if (!Directory.Exists(pureArcDir)) Directory.CreateDirectory(pureArcDir);
        string pureArc = Path.Combine(pureArcDir, "sce04_eng.arc");
        File.Copy(outArc, pureArc, true);
        Console.WriteLine("ARC copie dans archive_pure : " + pureArc);

        // Copie vers le jeu
        string gameTarget = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\BB\sce04_eng.arc";
        try {
            File.Copy(outArc, gameTarget, true);
            Console.WriteLine("ARC deploye avec succes dans : " + gameTarget);
        } catch (Exception ex) {
            Console.WriteLine("Copie vers le jeu en echec (droits ou sandbox) : " + ex.Message);
        }
    }
}
