using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DumpMissed {
    static void Main() {
        var missedKeys = new HashSet<string> {
            @"BB\script\output\_sce04_c100_0000_eng#9",
            @"BB\script\output\_sce04_c100_0000_eng#10",
            @"BB\script\output\_sce04_c101_0000_eng#2",
            @"BB\script\output\_sce04_c101_0020_eng#2",
            @"BB\script\output\_sce04_c101_0030_eng#2",
            @"BB\script\output\_sce04_c101_0040_eng#12",
            @"BB\script\output\_sce04_c101_0040_eng#17",
            @"BB\script\output\_sce04_c101_0040_eng#18",
            @"BB\script\output\_sce04_c101_0040_eng#26",
            @"BB\script\output\_sce04_c101_0060_eng#6",
            @"BB\script\output\_sce04_c101_0070_eng#2",
            @"BB\script\output\_sce04_c102_0000_eng#4",
            @"BB\script\output\_sce04_c102_0010_eng#4",
            @"BB\script\output\_sce04_c102_0010_eng#5",
            @"BB\script\output\_sce04_c102_0010_eng#6",
            @"BB\script\output\_sce04_c102_0010_eng#8",
            @"BB\script\output\_sce04_c102_0010_eng#9",
            @"BB\script\output\_sce04_c102_0010_eng#14",
            @"BB\script\output\_sce04_c102_0010_eng#15",
            @"BB\script\output\_sce04_c102_0010_eng#16",
            @"BB\script\output\_sce04_c102_0010_eng#17",
            @"BB\script\output\_sce04_c102_0010_eng#18",
            @"BB\script\output\_sce04_c102_0010_eng#19",
            @"BB\script\output\_sce04_c102_0010_eng#20",
            @"BB\script\output\_sce04_c102_0010_eng#28",
            @"BB\script\output\_sce04_c102_0010_eng#29",
            @"BB\script\output\_sce04_c102_0010_eng#30",
            @"BB\script\output\_sce04_c102_0010_eng#31",
            @"BB\script\output\_sce04_c102_0010_eng#32",
            @"BB\script\output\_sce04_c102_0010_eng#33"
        };

        string json = File.ReadAllText(@"analyse\trans_ep5\act1_trial1.json", Encoding.UTF8);
        StringBuilder sb = new StringBuilder();

        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string key = entryName + "#" + idx;
                if (missedKeys.Contains(key)) {
                    string en = im.Groups[2].Value.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");
                    sb.AppendLine("==================================================");
                    sb.AppendLine("KEY: " + key);
                    sb.AppendLine("==================================================");
                    string[] pages = en.Split(new[] { "<PAGE>" }, StringSplitOptions.None);
                    for (int p = 0; p < pages.Length; p++) {
                        sb.AppendLine("--- PAGE " + (p + 1) + " ---");
                        sb.AppendLine(pages[p].TrimEnd());
                    }
                    sb.AppendLine();
                }
            }
        }

        File.WriteAllText(@"tools\act1_missed_30.txt", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Done dumping missed 30 to tools\\act1_missed_30.txt");
    }
}
