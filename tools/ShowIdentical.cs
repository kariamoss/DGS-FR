using System;
using System.IO;
using System.Text.RegularExpressions;

class ShowIdentical {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1_translated.json");
        var items = Regex.Matches(json, "\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"", RegexOptions.Singleline);
        foreach (Match m in items) {
            string en = m.Groups[2].Value;
            string fr = m.Groups[3].Value;
            string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
            if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                if (fr == en) {
                    Console.WriteLine("Index: " + m.Groups[1].Value + " Text: " + stripped);
                }
            }
        }
    }
}
