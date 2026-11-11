using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class InspectEp4 {
    static void Main() {
        Console.OutputEncoding = Encoding.UTF8;
        string inJson = @"analyse\data\sce03_en.json";
        string json = File.ReadAllText(inJson, Encoding.UTF8);

        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        Console.WriteLine("Total entries in sce03_en.json: " + entryMatches.Count);

        int totalDialogs = 0;
        var entryCounts = new Dictionary<string, int>();

        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            
            int c = 0;
            foreach (Match im in itemMatches) {
                string en = im.Groups[2].Value;
                string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                    c++;
                    totalDialogs++;
                }
            }
            if (c > 0) {
                entryCounts[entryName] = c;
            }
        }

        Console.WriteLine("Total répliques textuelles avec dialogue : " + totalDialogs);
        Console.WriteLine("Entrées avec texte (" + entryCounts.Count + ") :");
        foreach (var kvp in entryCounts) {
            Console.WriteLine("  " + kvp.Key + " : " + kvp.Value + " répliques");
        }
    }
}
