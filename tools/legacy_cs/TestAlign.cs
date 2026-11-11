using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Let's test on key 26: BB\script\output\_sce03_chr010_01_eng#5
        string untrans = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);
        var m = Regex.Match(untrans, @"\[26\] (BB\\script\\output\\_sce03_chr010_01_eng#5)\r?\n={50}\r?\n(.*?)(?=\r?\n={50})", RegexOptions.Singleline);
        string rawPagesBlock = m.Groups[2].Value;

        // Split pages
        var rawPages = new List<string>();
        foreach (var page in Regex.Split(rawPagesBlock, @"--- PAGE \d+ ---\r?\n"))
        {
            string p = page.Trim();
            if (!string.IsNullOrEmpty(p)) rawPages.Add(p);
        }

        Console.WriteLine("Raw pages count: " + rawPages.Count);
        for (int i = 0; i < Math.Min(5, rawPages.Count); i++)
        {
            Console.WriteLine("P" + (i + 1) + ": " + rawPages[i].Replace("\r", "").Replace("\n", " "));
        }
    }
}
