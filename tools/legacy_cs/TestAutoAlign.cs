using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static string Clean(string s)
    {
        s = Regex.Replace(s, @"<[^>]+>", "");
        s = Regex.Replace(s, @"[\r\n\s]+", " ").Trim();
        s = s.Replace("’", "'").Replace("‘", "'").Replace("“", "\"").Replace("”", "\"");
        return s;
    }

    static void Main()
    {
        // Load Act1 and Act2 pairs
        string[] files = Directory.GetFiles("tools", "Trans_Ep4_Act*.cs");
        var sb = new StringBuilder();
        foreach (var f in files) sb.AppendLine(File.ReadAllText(f, Encoding.UTF8));
        string all = sb.ToString();

        var dict = new Dictionary<string, List<Tuple<string, string>>>();
        var matches = Regex.Matches(all, @"entryTranslators\[@""([^""]+)""\]\s*=\s*\((?:en|s)\)\s*=>\s*\{(.*?)\};", RegexOptions.Singleline);
        foreach (Match m in matches)
        {
            string key = m.Groups[1].Value;
            string body = m.Groups[2].Value;
            var pairs = new List<Tuple<string, string>>();
            var pMatches = Regex.Matches(body, @"s\s*=\s*s\.Replace\(\s*""((?:[^""\\]|\\.)*)""\s*,\s*""((?:[^""\\]|\\.)*)""\s*\);", RegexOptions.Singleline);
            foreach (Match pm in pMatches)
            {
                pairs.Add(Tuple.Create(Regex.Unescape(pm.Groups[1].Value), Regex.Unescape(pm.Groups[2].Value)));
            }
            dict[key] = pairs;
        }

        // Test on key 26
        string untrans = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);
        var km = Regex.Match(untrans, @"\[26\] (BB\\script\\output\\_sce03_chr010_01_eng#5)\r?\n={50}\r?\n(.*?)(?=\r?\n={50})", RegexOptions.Singleline);
        string key26 = km.Groups[1].Value;
        string rawBlock = km.Groups[2].Value;

        var rawPages = new List<string>();
        foreach (var p in Regex.Split(rawBlock, @"--- PAGE \d+ ---\r?\n"))
        {
            if (!string.IsNullOrWhiteSpace(p)) rawPages.Add(p.Trim());
        }

        var pairs26 = dict[key26];
        Console.WriteLine("Raw pages: " + rawPages.Count + ", Pairs: " + pairs26.Count);

        for (int pIdx = 0; pIdx < rawPages.Count; pIdx++)
        {
            string rawP = rawPages[pIdx];
            // Extract text portion between prefix tags and <E023>
            var textM = Regex.Match(rawP, @"^(<[^>]+>)+(.*?)(?:<E023>|<E001>|\Z)", RegexOptions.Singleline);
            string prefix = textM.Success ? textM.Groups[1].Value : "";
            string inner = textM.Success ? textM.Groups[2].Value : rawP;

            string cleanInner = Clean(inner);
            if (string.IsNullOrEmpty(cleanInner)) continue;

            // Match with pairs
            string bestFr = null;
            foreach (var pair in pairs26)
            {
                string cleanEn = Clean(pair.Item1);
                if (cleanEn.Contains(cleanInner) || cleanInner.Contains(cleanEn))
                {
                    bestFr = pair.Item2;
                    break;
                }
            }

            Console.WriteLine("P" + (pIdx + 1) + " [" + cleanInner + "] -> " + (bestFr != null ? bestFr.Substring(0, Math.Min(30, bestFr.Length)) : "MISSING!"));
        }
    }
}
