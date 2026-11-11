using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TranslatorEp4Act2 {
    public partial class Program {
        public static Dictionary<string, Func<string, string>> entryTranslators = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase);

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            string inPath = @"analyse\trans_ep4\act2_characters.json";
            string outPath = @"analyse\trans_ep4\act2_characters_translated.json";

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

                    sb.AppendLine("      {");
                    sb.AppendLine("        \"Index\": " + idx + ",");
                    sb.AppendLine("        \"En\": \"" + EscapeJson(en) + "\",");
                    sb.AppendLine("        \"Fr\": \"" + EscapeJson(fr) + "\"");
                    sb.Append("      }");
                }

                sb.AppendLine();
                sb.AppendLine("    ]");
                sb.Append("  }");
            }

            sb.AppendLine();
            sb.AppendLine("]");

            File.WriteAllText(outPath, sb.ToString(), Encoding.UTF8);
            Console.WriteLine("=== RESULTAT EP4 ACTE 2 ===");
            Console.WriteLine("Traduits : " + translatedCount);
            Console.WriteLine("Manquants : " + missingCount);
            Console.WriteLine("Sortie : " + outPath);
        }

        static string UnescapeJson(string s) {
            return s.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");
        }

        static string EscapeJson(string s) {
            return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
        }
    }
}
