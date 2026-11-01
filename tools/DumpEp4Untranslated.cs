using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int start = int.Parse(args[0]);
        int end = int.Parse(args[1]);
        string text = File.ReadAllText(@"tools\ep4_untranslated_81.txt", Encoding.UTF8);

        var matches = Regex.Matches(text, @"={50}\r?\n\[(\d+)\] ([^\r\n]+)\r?\n={50}\r?\n(.*?)(?=\r?\n={50}|\Z)", RegexOptions.Singleline);
        foreach (Match m in matches)
        {
            int idx = int.Parse(m.Groups[1].Value);
            if (idx >= start && idx <= end)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("[" + idx + "] " + m.Groups[2].Value);
                Console.WriteLine("==================================================");
                Console.WriteLine(m.Groups[3].Value);
            }
        }
    }
}
