using System;
using System.IO;
using System.Text.RegularExpressions;

class FindKey {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1.json");
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string en = im.Groups[2].Value;
                if (en.Contains("So none of you can elaborate further")) {
                    Console.WriteLine("FOUND KEY: " + entryName + "#" + im.Groups[1].Value);
                    Console.WriteLine("RAW EN:\n" + en);
                }
            }
        }
    }
}
