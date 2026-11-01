using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var ep4Keys = new List<string>();
        foreach (var line in File.ReadAllLines(@"tools\ep4_untranslated_81.txt", Encoding.UTF8))
        {
            var m = Regex.Match(line, @"^\[\d+\] (.*)");
            if (m.Success)
            {
                ep4Keys.Add(m.Groups[1].Value.Trim());
            }
        }

        var sb = new StringBuilder();
        foreach (var file in Directory.GetFiles("tools", "Trans_Ep4_Act*.cs"))
        {
            sb.AppendLine(File.ReadAllText(file, Encoding.UTF8));
        }
        string allText = sb.ToString();

        int found = 0;
        int missing = 0;
        foreach (var k in ep4Keys)
        {
            if (allText.Contains(k))
            {
                found++;
            }
            else
            {
                Console.WriteLine("Missing key in Act*.cs: " + k);
                missing++;
            }
        }
        Console.WriteLine("Summary: Found=" + found + ", Missing=" + missing);
    }
}
