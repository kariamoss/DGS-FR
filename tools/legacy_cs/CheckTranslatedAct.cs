using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CheckAct {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0) {
                Console.WriteLine("Usage: CheckTranslatedAct.exe <path_to_json>");
                return;
            }
            string path = args[0];
            string json = File.ReadAllText(path);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
            int total = 0;
            int same = 0;
            int empty = 0;
            int translated = 0;

            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;
                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
                foreach (Match m in itemMatches) {
                    total++;
                    string idx = m.Groups[1].Value;
                    string en = m.Groups[2].Value;
                    string fr = m.Groups[3].Value;
                    string strippedEn = Regex.Replace(en, "<[^>]+>", "").Trim();

                    if (string.IsNullOrEmpty(fr)) {
                        empty++;
                    } else if (en == fr && strippedEn.Length > 2 && Regex.IsMatch(strippedEn, "[a-zA-Z]{3,}")) {
                        Console.WriteLine("SAME: " + entryName + "#" + idx + " => " + (strippedEn.Length > 40 ? strippedEn.Substring(0, 40) : strippedEn));
                        same++;
                    } else {
                        translated++;
                    }
                }
            }

            Console.WriteLine("=== VERIFICATION " + Path.GetFileName(path) + " ===");
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Translated: " + translated);
            Console.WriteLine("Same (En==Fr): " + same);
            Console.WriteLine("Empty Fr: " + empty);
        }
    }
}
