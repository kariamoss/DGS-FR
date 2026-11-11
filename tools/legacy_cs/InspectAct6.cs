using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class InspectAct6 {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep3\act6_characters_evidence.json");
        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        int total = 0;
        List<string> keys = new List<string>();

        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string en = im.Groups[2].Value;
                string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                    total++;
                    keys.Add(entryName + "#" + idx);
                }
            }
        }
        Console.WriteLine("Total items: " + total);
        File.WriteAllLines(@"analyse\trans_ep3\act6_keys.txt", keys.ToArray());
    }
}
