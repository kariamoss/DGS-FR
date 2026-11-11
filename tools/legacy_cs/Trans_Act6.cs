using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TranslatorAct6 {
    public partial class Program {
        public static Dictionary<string, Func<string, string>> entryTranslators = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase);

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

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            string inPath = @"analyse\trans_ep3\act6_characters_evidence.json";
            string outPath = @"analyse\trans_ep3\act6_characters_evidence_translated.json";

            RegisterPart1();
            RegisterPart2();
            RegisterPart3();
            RegisterPart4();

            string json = File.ReadAllText(inPath, Encoding.UTF8);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            bool firstEntry = true;
            int translatedCount = 0;
            int missingCount = 0;

            foreach (Match em in entryMatches) {
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
                    if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                        string key = entryName + "#" + idx;
                        if (entryTranslators.ContainsKey(key)) {
                            fr = entryTranslators[key](en);
                            translatedCount++;
                        } else {
                            Console.WriteLine("ATTENTION: Manquant pour " + key);
                            missingCount++;
                        }
                    }

                    if (!firstItem) sb.AppendLine(",");
                    firstItem = false;
                    sb.Append("      { \"Index\": " + idx + ", \"En\": \"" + EscapeJson(en) + "\", \"Fr\": \"" + EscapeJson(fr) + "\" }");
                }

                sb.AppendLine("\n    ]");
                sb.Append("  }");
            }

            sb.AppendLine("\n]");
            File.WriteAllText(outPath, sb.ToString(), Encoding.UTF8);

            Console.WriteLine("=== BILAN ACT 6 ===");
            Console.WriteLine("Traduits : " + translatedCount);
            Console.WriteLine("Manquants : " + missingCount);
            Console.WriteLine("Fichier généré : " + outPath);
        }
    }
}
