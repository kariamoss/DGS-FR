using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DebugMismatch2 {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1.json");
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        var targetKeys = new HashSet<string>() {
            "BB\\script\\output\\_sce03_c102_0020_eng#21",
            "BB\\script\\output\\_sce03_c102_0040_eng#2",
            "BB\\script\\output\\_sce03_c102_0050_eng#2",
            "BB\\script\\output\\_sce03_c103_0010_eng#16",
            "BB\\script\\output\\_sce03_c103_0010_eng#18",
            "BB\\script\\output\\_sce03_c103_0010_eng#24",
            "BB\\script\\output\\_sce03_c103_0050_eng#2",
            "BB\\script\\output\\_sce03_c103_0050_eng#3",
            "BB\\script\\output\\_sce03_c103_0060_eng#2",
            "BB\\script\\output\\_sce03_c103_0060_eng#7",
            "BB\\script\\output\\_sce03_c103_0070_eng#2",
            "BB\\script\\output\\_sce03_c103_0070_eng#4",
            "BB\\script\\output\\_sce03_c103_0070_eng#5"
        };

        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string key = entryName + "#" + im.Groups[1].Value;
                if (targetKeys.Contains(key)) {
                    Console.WriteLine("=================================");
                    Console.WriteLine("KEY: " + key);
                    Console.WriteLine("RAW EN IN JSON:");
                    Console.WriteLine(im.Groups[2].Value);
                }
            }
        }
    }
}
