using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static string UnescapeJson(string s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '\\' && i + 1 < s.Length) {
                char next = s[i + 1];
                if (next == '\\') { sb.Append('\\'); i++; }
                else if (next == '"') { sb.Append('"'); i++; }
                else if (next == 'n') { sb.Append('\n'); i++; }
                else if (next == 'r') { sb.Append('\r'); i++; }
                else if (next == 't') { sb.Append('\t'); i++; }
                else if (next == 'u' && i + 5 < s.Length) {
                    string hex = s.Substring(i + 2, 4);
                    sb.Append((char)Convert.ToInt32(hex, 16));
                    i += 5;
                } else {
                    sb.Append(next); i++;
                }
            } else {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }

    static void Main()
    {
        var d = new Dictionary<string, Func<string, string>>();
        Ep4Fixes.Part1.Register(d);
        Console.WriteLine("Part1 registered: " + d.Count + " entries");

        string json = File.ReadAllText(@"analyse\data\sce03_fr.json", Encoding.UTF8);
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        int matchedKeys = 0;
        int changedCount = 0;
        foreach (Match em in entryMatches)
        {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
            foreach (Match im in itemMatches)
            {
                string idx = im.Groups[1].Value;
                string key = entryName + "#" + idx;
                if (d.ContainsKey(key))
                {
                    matchedKeys++;
                    string en = UnescapeJson(im.Groups[2].Value);
                    string fr = UnescapeJson(im.Groups[3].Value);
                    string fixedFr = d[key](en); // apply to en!
                    if (fixedFr != fr && fixedFr != en)
                    {
                        changedCount++;
                    }
                    else
                    {
                        Console.WriteLine("Did NOT change: " + key);
                    }
                }
            }
        }

        Console.WriteLine("Matched: " + matchedKeys + " / " + d.Count);
        Console.WriteLine("Changed: " + changedCount + " / " + d.Count);
    }
}
