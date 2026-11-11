using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Splitter {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            string inJson = @"analyse\data\sce02_en.json";
            string outDir = @"analyse\trans_ep3";
            if (!Directory.Exists(outDir)) Directory.CreateDirectory(outDir);

            string json = File.ReadAllText(inJson, Encoding.UTF8);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

            var batches = new Dictionary<string, StringBuilder> {
                { "act1_intro", new StringBuilder("[\n") },
                { "act2_trial1", new StringBuilder("[\n") },
                { "act3_investigation", new StringBuilder("[\n") },
                { "act4_trial2", new StringBuilder("[\n") },
                { "act5_trial3", new StringBuilder("[\n") },
                { "act6_characters_evidence", new StringBuilder("[\n") }
            };

            var firstInBatch = new Dictionary<string, bool> {
                { "act1_intro", true }, { "act2_trial1", true }, { "act3_investigation", true },
                { "act4_trial2", true }, { "act5_trial3", true }, { "act6_characters_evidence", true }
            };

            var counts = new Dictionary<string, int> {
                { "act1_intro", 0 }, { "act2_trial1", 0 }, { "act3_investigation", 0 },
                { "act4_trial2", 0 }, { "act5_trial3", 0 }, { "act6_characters_evidence", 0 }
            };

            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;

                // Vérifier s'il y a du texte traduisible
                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
                bool hasText = false;
                foreach (Match im in itemMatches) {
                    string en = im.Groups[2].Value;
                    string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                    if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                        hasText = true;
                        break;
                    }
                }
                if (!hasText) continue;

                // Déterminer le lot
                string batchKey = "act6_characters_evidence";
                if (Regex.IsMatch(entryName, "_sce02_c00[0-3]_")) batchKey = "act1_intro";
                else if (Regex.IsMatch(entryName, "_sce02_c10[0-7]_")) batchKey = "act2_trial1";
                else if (Regex.IsMatch(entryName, "_sce02_bg[0-9]+_")) batchKey = "act3_investigation";
                else if (Regex.IsMatch(entryName, "_sce02_c20[0-2]_")) batchKey = "act4_trial2";
                else if (Regex.IsMatch(entryName, "_sce02_c30[0-8]_")) batchKey = "act5_trial3";

                if (!firstInBatch[batchKey]) batches[batchKey].AppendLine(",");
                firstInBatch[batchKey] = false;

                batches[batchKey].AppendLine("  {");
                batches[batchKey].AppendLine("    \"EntryName\": \"" + entryName.Replace("\\", "\\\\") + "\",");
                batches[batchKey].AppendLine("    \"Items\": [");

                bool firstItem = true;
                foreach (Match im in itemMatches) {
                    string idx = im.Groups[1].Value;
                    string en = im.Groups[2].Value;
                    string fr = im.Groups[3].Value;

                    if (!firstItem) batches[batchKey].AppendLine(",");
                    firstItem = false;
                    batches[batchKey].Append("      { \"Index\": " + idx + ", \"En\": \"" + en + "\", \"Fr\": \"" + fr + "\" }");

                    string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                    if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                        counts[batchKey]++;
                    }
                }
                batches[batchKey].AppendLine("\n    ]");
                batches[batchKey].Append("  }");
            }

            foreach (var kvp in batches) {
                kvp.Value.AppendLine("\n]");
                string filePath = Path.Combine(outDir, kvp.Key + ".json");
                File.WriteAllText(filePath, kvp.Value.ToString(), Encoding.UTF8);
                Console.WriteLine("Lot " + kvp.Key + " : " + counts[kvp.Key] + " répliques de dialogue écrites dans " + filePath);
            }
        }
    }
}
