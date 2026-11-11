using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int start = int.Parse(args[0]);
        int end = int.Parse(args[1]);

        // Load Act1 and Act2 text
        var sb = new StringBuilder();
        foreach (var file in Directory.GetFiles("tools", "Trans_Ep4_Act*.cs"))
        {
            sb.AppendLine(File.ReadAllText(file, Encoding.UTF8));
        }
        string allActs = sb.ToString();

        // Load dumped untranslated
        string untrans = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);
        var matches = Regex.Matches(untrans, @"={50}\r?\n\[(\d+)\] ([^\r\n]+)\r?\n={50}\r?\n(.*?)(?=\r?\n={50}|\Z)", RegexOptions.Singleline);

        foreach (Match m in matches)
        {
            int idx = int.Parse(m.Groups[1].Value);
            if (idx >= start && idx <= end)
            {
                string key = m.Groups[2].Value.Trim();
                Console.WriteLine("==================================================");
                Console.WriteLine("[" + idx + "] " + key);
                Console.WriteLine("==================================================");

                // Find entry in allActs
                int kIdx = allActs.IndexOf(key);
                if (kIdx >= 0)
                {
                    int bodyStart = allActs.IndexOf("=> {", kIdx);
                    if (bodyStart >= 0)
                    {
                        int bodyEnd = allActs.IndexOf("return s;", bodyStart);
                        if (bodyEnd >= 0)
                        {
                            Console.WriteLine("--- TRANSLATIONS IN ACT FILE ---");
                            Console.WriteLine(allActs.Substring(bodyStart + 4, bodyEnd - (bodyStart + 4)).Trim());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("--- KEY NOT FOUND IN ACT FILES! ---");
                }

                Console.WriteLine("--- RAW PAGES ---");
                Console.WriteLine(m.Groups[3].Value.Trim());
            }
        }
    }
}
