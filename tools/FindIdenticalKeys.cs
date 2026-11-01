using System;
using System.IO;
using System.Text.RegularExpressions;

class FindIdenticalKeys {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1.json");
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string en = im.Groups[2].Value;
                string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                    string key = entryName + "#" + idx;
                    // Check if it's one of the 13
                    if (stripped.StartsWith("Mr Gossip") || stripped.StartsWith("I take it that") || stripped.StartsWith("So, Counsel, I must")
                        || stripped.StartsWith("Hmmm...\r\nSo none") || stripped.StartsWith("Said 'e 'adn't") || stripped.StartsWith("You...certainly know")
                        || stripped.StartsWith("Explain yourself") || stripped.StartsWith("A noise that sounds") || stripped.StartsWith("Your extravagant")
                        || stripped.StartsWith("Pfft...") || stripped.StartsWith("Very well, Counsel") || stripped.StartsWith("Hm... I can't say")
                        || stripped.StartsWith("I believe this red")) {
                        Console.WriteLine("Key in json: " + key + " (Text start: " + stripped.Substring(0, Math.Min(30, stripped.Length)).Replace("\r", " ").Replace("\n", " ") + ")");
                    }
                }
            }
        }
    }
}
