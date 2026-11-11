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

    static string EscapeString(string s)
    {
        return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
    }

    static void GeneratePart(int startIdx, int endIdx, string partName, string outFile, Dictionary<string, List<Tuple<string, string>>> dict, MatchCollection itemMatches)
    {
        var sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace Ep4Fixes");
        sb.AppendLine("{");
        sb.AppendLine("    public static class " + partName);
        sb.AppendLine("    {");
        sb.AppendLine("        public static void Register(Dictionary<string, Func<string, string>> d)");
        sb.AppendLine("        {");

        int totalPages = 0;
        int matchedPages = 0;

        foreach (Match im in itemMatches)
        {
            int idx = int.Parse(im.Groups[1].Value);
            if (idx < startIdx || idx > endIdx) continue;

            string key = im.Groups[2].Value.Trim();
            string rawBlock = im.Groups[3].Value;

            var rawPages = new List<string>();
            foreach (var p in Regex.Split(rawBlock, @"--- PAGE \d+ ---\r?\n"))
            {
                if (!string.IsNullOrWhiteSpace(p)) rawPages.Add(p.Trim());
            }

            sb.AppendLine("            // [" + idx + "] " + key);
            sb.AppendLine("            d[@\"" + key + "\"] = (s) => {");

            var pairs = dict.ContainsKey(key) ? dict[key] : new List<Tuple<string, string>>();

            foreach (var rawPage in rawPages)
            {
                totalPages++;
                var pm = Regex.Match(rawPage, @"^(?:<[^>]+>\s*)*?(?<text>.*?)<E023>|<E001>", RegexOptions.Singleline);
                string target = null;
                if (pm.Success && !string.IsNullOrWhiteSpace(pm.Groups["text"].Value))
                {
                    target = pm.Groups["text"].Value.Trim();
                }
                else
                {
                    string noTags = Regex.Replace(rawPage, @"<[^>]+>", "").Trim();
                    if (!string.IsNullOrEmpty(noTags))
                    {
                        target = noTags;
                    }
                }

                if (string.IsNullOrEmpty(target) || Regex.Replace(target, @"<[^>]+>", "").Trim().Length == 0)
                {
                    continue;
                }

                string cleanTarget = Clean(target);
                string matchedFr = null;
                foreach (var pair in pairs)
                {
                    string cleanEn = Clean(pair.Item1);
                    if (cleanEn == cleanTarget)
                    {
                        matchedFr = pair.Item2;
                        break;
                    }
                }

                if (matchedFr == null)
                {
                    foreach (var pair in pairs)
                    {
                        string cleanEn = Clean(pair.Item1);
                        if (cleanEn.Contains(cleanTarget) || cleanTarget.Contains(cleanEn))
                        {
                            matchedFr = pair.Item2;
                            break;
                        }
                    }
                }

                if (matchedFr != null)
                {
                    matchedPages++;
                    sb.AppendLine("                s = s.Replace(\"" + EscapeString(target) + "\", \"" + EscapeString(matchedFr) + "\");");
                }
                else
                {
                    sb.AppendLine("                // UNMATCHED: s = s.Replace(\"" + EscapeString(target) + "\", \"...\");");
                }
            }

            sb.AppendLine("                return s;");
            sb.AppendLine("            };");
            sb.AppendLine();
        }

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
        Console.WriteLine(partName + ": " + matchedPages + " / " + totalPages + " pages matched -> " + outFile);
    }

    static void Main(string[] args)
    {
        string[] actFiles = Directory.GetFiles("tools", "Trans_Ep4_Act*.cs");
        var allActsSb = new StringBuilder();
        foreach (var f in actFiles) allActsSb.AppendLine(File.ReadAllText(f, Encoding.UTF8));
        string allActs = allActsSb.ToString();

        var dict = new Dictionary<string, List<Tuple<string, string>>>();
        var matches = Regex.Matches(allActs, @"entryTranslators\[@""([^""]+)""\]\s*=\s*\((?:en|s)\)\s*=>\s*\{(.*?)\};", RegexOptions.Singleline);
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

        string untrans = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);
        var itemMatches = Regex.Matches(untrans, @"={50}\r?\n\[(\d+)\] ([^\r\n]+)\r?\n={50}\r?\n(.*?)(?=\r?\n={50}|\Z)", RegexOptions.Singleline);

        GeneratePart(26, 55, "Part2", @"tools\Fix_Ep4_Part2_Auto.cs", dict, itemMatches);
        GeneratePart(56, 81, "Part3", @"tools\Fix_Ep4_Part3_Auto.cs", dict, itemMatches);
    }
}
