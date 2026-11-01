using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ShowItems {
    static void Main(string[] args) {
        Console.OutputEncoding = Encoding.UTF8;
        if (args.Length < 2) {
            Console.WriteLine("Usage: ShowItems <json_file> <prefix_or_key>");
            return;
        }
        string json = File.ReadAllText(args[0], Encoding.UTF8);
        string query = args[1];

        MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        foreach (Match em in entryMatches) {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches) {
                string idx = im.Groups[1].Value;
                string key = entryName + "#" + idx;
                if (key.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0) {
                    string en = im.Groups[2].Value.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");
                    string fr = im.Groups[3].Value.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");
                    Console.WriteLine("======================================");
                    Console.WriteLine("KEY: " + key);
                    Console.WriteLine("--- EN ---");
                    Console.WriteLine(en);
                    Console.WriteLine("--- FR ---");
                    Console.WriteLine(fr);
                }
            }
        }
    }
}
