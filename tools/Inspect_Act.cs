using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string path = args.Length > 0 ? args[0] : @"analyse\trans_ep4\act3_part1_dump.txt";
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);
        for (int i = 0; i < lines.Length; i++)
        {
            var m = Regex.Match(lines[i], @"^\[(\d+)\] KEY:(.+)");
            if (m.Success)
            {
                string text = (i + 1 < lines.Length) ? lines[i + 1] : "";
                // print preview
                string cleanText = Regex.Replace(text, @"<[^>]+>", " ");
                cleanText = Regex.Replace(cleanText, @"\s+", " ").Trim();
                if (cleanText.Length > 80) cleanText = cleanText.Substring(0, 80) + "...";
                Console.WriteLine(string.Format("[{0}] {1} (len: {2}): {3}", m.Groups[1].Value, m.Groups[2].Value, text.Length, cleanText));
            }
        }
    }
}
