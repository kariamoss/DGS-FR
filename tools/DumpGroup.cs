using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class DumpGroup {
    static void Main(string[] args) {
        int start = int.Parse(args[0]);
        int count = int.Parse(args[1]);
        string outPath = args[2];

        string[] keys = File.ReadAllLines(@"analyse\trans_ep3\act6_keys.txt");
        HashSet<string> targetKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        for (int i = start; i < start + count && i < keys.Length; i++) {
            targetKeys.Add(keys[i]);
        }

        string json = File.ReadAllText(@"analyse\trans_ep3\act6_characters_evidence.json", Encoding.UTF8);
        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        StringBuilder sb = new StringBuilder();
        int k = start + 1;
        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string key = entryName + "#" + idx;
                if (targetKeys.Contains(key)) {
                    string en = im.Groups[2].Value;
                    sb.AppendLine("[" + k + "] KEY:" + key);
                    sb.AppendLine("EN:" + en);
                    sb.AppendLine();
                    k++;
                }
            }
        }
        File.WriteAllText(outPath, sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Extracted " + (k - start - 1) + " keys to " + outPath);
    }
}
