using System;
using System.IO;
using System.Text.RegularExpressions;

class DebugMismatch {
    static void Main() {
        string json = File.ReadAllText(@"analyse\trans_ep4\act3_trial1.json");
        string[] testKeys = new string[] {
            "BB\\script\\output\\_sce03_c103_0050_eng#2",
            "BB\\script\\output\\_sce03_c103_0050_eng#3",
            "BB\\script\\output\\_sce03_c103_0060_eng#2",
            "BB\\script\\output\\_sce03_c103_0070_eng#2"
        };
        foreach (var tk in testKeys) {
            string[] p = tk.Split('#');
            string pattern = "\"EntryName\"\\s*:\\s*\"" + p[0].Replace("\\", "\\\\") + "\".*?\"Index\"\\s*:\\s*" + p[1] + "\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"";
            var m = Regex.Match(json, pattern, RegexOptions.Singleline);
            if (m.Success) {
                Console.WriteLine("Key: " + tk);
                Console.WriteLine("En in JSON: [" + m.Groups[1].Value.Replace("\r", "\\r").Replace("\n", "\\n") + "]");
            }
        }
    }
}
