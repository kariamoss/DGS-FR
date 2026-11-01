using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SplitEp4 {
    static void Main() {
        Console.OutputEncoding = Encoding.UTF8;
        string inJson = @"analyse\data\sce03_en.json";
        string outDir = @"analyse\trans_ep4";
        if (!Directory.Exists(outDir)) Directory.CreateDirectory(outDir);

        string json = File.ReadAllText(inJson, Encoding.UTF8);
        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        var batches = new Dictionary<string, StringBuilder> {
            { "act1_investigation_bg", new StringBuilder("[\n") },
            { "act2_characters", new StringBuilder("[\n") },
            { "act3_trial1", new StringBuilder("[\n") },
            { "act4_trial2", new StringBuilder("[\n") },
            { "act5_trial3_evidence_macro", new StringBuilder("[\n") }
        };

        var dumps = new Dictionary<string, StringBuilder> {
            { "act1_investigation_bg", new StringBuilder() },
            { "act2_characters", new StringBuilder() },
            { "act3_trial1", new StringBuilder() },
            { "act4_trial2", new StringBuilder() },
            { "act5_trial3_evidence_macro", new StringBuilder() }
        };

        var firstInBatch = new Dictionary<string, bool> {
            { "act1_investigation_bg", true }, { "act2_characters", true }, { "act3_trial1", true },
            { "act4_trial2", true }, { "act5_trial3_evidence_macro", true }
        };

        var counts = new Dictionary<string, int> {
            { "act1_investigation_bg", 0 }, { "act2_characters", 0 }, { "act3_trial1", 0 },
            { "act4_trial2", 0 }, { "act5_trial3_evidence_macro", 0 }
        };

        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;

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

            string batchKey = "act5_trial3_evidence_macro";
            if (Regex.IsMatch(entryName, "_sce03_c00[0-9]_") || Regex.IsMatch(entryName, "_sce03_bg[0-9]+_")) {
                batchKey = "act1_investigation_bg";
            } else if (Regex.IsMatch(entryName, "_sce03_chr[0-9]+_")) {
                batchKey = "act2_characters";
            } else if (Regex.IsMatch(entryName, "_sce03_c10[0-4]_")) {
                batchKey = "act3_trial1";
            } else if (Regex.IsMatch(entryName, "_sce03_c10[5-9]_")) {
                batchKey = "act4_trial2";
            }

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
                    dumps[batchKey].AppendLine("[" + counts[batchKey] + "] KEY:" + entryName + "#" + idx);
                    dumps[batchKey].AppendLine("EN:" + en);
                    dumps[batchKey].AppendLine();
                }
            }
            batches[batchKey].AppendLine("\n    ]");
            batches[batchKey].Append("  }");
        }

        foreach (var kvp in batches) {
            kvp.Value.AppendLine("\n]");
            string jsonPath = Path.Combine(outDir, kvp.Key + ".json");
            File.WriteAllText(jsonPath, kvp.Value.ToString(), Encoding.UTF8);
            string dumpPath = Path.Combine(outDir, kvp.Key + "_dump.txt");
            File.WriteAllText(dumpPath, dumps[kvp.Key].ToString(), Encoding.UTF8);
            Console.WriteLine("Act " + kvp.Key + " : " + counts[kvp.Key] + " répliques écrites dans " + jsonPath);
        }
    }
}
