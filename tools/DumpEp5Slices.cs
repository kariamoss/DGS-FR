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

    static void Main(string[] args)
    {
        string actFile = args[0];
        int startIdx = int.Parse(args[1]);
        int endIdx = int.Parse(args[2]);
        string outFile = args[3];

        string json = File.ReadAllText(actFile, Encoding.UTF8);
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

        int count = 0;
        var sb = new StringBuilder();

        foreach (Match em in entryMatches)
        {
            string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
            string itemsContent = em.Groups[2].Value;
            var itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);

            foreach (Match im in itemMatches)
            {
                if (count >= startIdx && count <= endIdx)
                {
                    string idx = im.Groups[1].Value;
                    string en = UnescapeJson(im.Groups[2].Value);
                    sb.AppendLine("==================================================");
                    sb.AppendLine("[" + count + "] " + entryName + "#" + idx);
                    sb.AppendLine("==================================================");

                    var pages = Regex.Split(en, @"<PAGE>\r?\n");
                    for (int p = 0; p < pages.Length; p++)
                    {
                        sb.AppendLine("--- PAGE " + (p + 1) + " ---");
                        sb.AppendLine(pages[p].Trim());
                    }
                    sb.AppendLine();
                }
                count++;
            }
        }

        File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Dumped items " + startIdx + " to " + endIdx + " (total seen: " + count + ") -> " + outFile);
    }
}
