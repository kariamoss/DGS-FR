using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Dumper {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            if (args.Length < 2) {
                Console.WriteLine("Usage: DumpAct.exe <input.json> <output.txt>");
                return;
            }

            string json = File.ReadAllText(args[0], Encoding.UTF8);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

            StringBuilder sb = new StringBuilder();
            int entryIndex = 0;

            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;

                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);

                foreach (Match im in itemMatches) {
                    string idx = im.Groups[1].Value;
                    string en = im.Groups[2].Value.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");

                    string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                    if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                        sb.AppendLine("==================================================");
                        sb.AppendLine(string.Format("[{0}] {1}#{2}", entryIndex, entryName, idx));
                        sb.AppendLine("==================================================");

                        string[] pages = Regex.Split(en, "<PAGE>");
                        for (int p = 0; p < pages.Length; p++) {
                            sb.AppendLine(string.Format("--- PAGE {0} ---", p + 1));
                            sb.AppendLine(pages[p]);
                        }
                        sb.AppendLine();
                        entryIndex++;
                    }
                }
            }

            File.WriteAllText(args[1], sb.ToString(), Encoding.UTF8);
            Console.WriteLine("Total valid entries: " + entryIndex);
            Console.WriteLine("Written to: " + args[1]);
        }
    }
}
