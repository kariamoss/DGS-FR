using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] files = Directory.GetFiles("tools", "Trans_Ep4_Act*.cs");
        var sb = new StringBuilder();
        foreach (var f in files) sb.AppendLine(File.ReadAllText(f, Encoding.UTF8));
        string all = sb.ToString();

        // Find all entryTranslators[@"..."] = (en) => { ... };
        var matches = Regex.Matches(all, @"entryTranslators\[@""([^""]+)""\]\s*=\s*\((?:en|s)\)\s*=>\s*\{(.*?)\};", RegexOptions.Singleline);
        Console.WriteLine("Total entryTranslators found: " + matches.Count);

        var dict = new Dictionary<string, List<Tuple<string, string>>>();
        foreach (Match m in matches)
        {
            string key = m.Groups[1].Value;
            string body = m.Groups[2].Value;

            var pairs = new List<Tuple<string, string>>();
            var pMatches = Regex.Matches(body, @"s\s*=\s*s\.Replace\(\s*""((?:[^""\\]|\\.)*)""\s*,\s*""((?:[^""\\]|\\.)*)""\s*\);", RegexOptions.Singleline);
            foreach (Match pm in pMatches)
            {
                string target = Regex.Unescape(pm.Groups[1].Value);
                string repl = Regex.Unescape(pm.Groups[2].Value);
                pairs.Add(Tuple.Create(target, repl));
            }
            dict[key] = pairs;
        }

        Console.WriteLine("Dict count: " + dict.Count);

        // Check keys 26 to 30
        for (int i = 26; i <= 30; i++)
        {
            // read key from ep4_untranslated_81.txt
            string untrans = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);
            var km = Regex.Match(untrans, @"\[" + i + @"\] ([^\r\n]+)");
            if (km.Success)
            {
                string key = km.Groups[1].Value.Trim();
                Console.WriteLine("Key [" + i + "]: " + key + " has " + (dict.ContainsKey(key) ? dict[key].Count : 0) + " pairs");
            }
        }
    }
}
