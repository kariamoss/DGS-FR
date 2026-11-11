using System;
using System.IO;
using System.Text.RegularExpressions;

class CheckAct3 {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1_translated.json");
        var items = Regex.Matches(json, "\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"", RegexOptions.Singleline);
        int emptyFr = 0, identical = 0, total = 0;
        foreach (Match m in items) {
            string en = m.Groups[2].Value;
            string fr = m.Groups[3].Value;
            string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
            if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                total++;
                if (string.IsNullOrEmpty(fr)) emptyFr++;
                else if (fr == en) identical++;
            }
        }
        Console.WriteLine("Dialogue items: " + total + ", Empty Fr: " + emptyFr + ", Identical: " + identical);
    }
}
