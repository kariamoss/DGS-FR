using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class DumpPages {
    static void Main(string[] args) {
        string file = args[0];
        string outFile = args[1];
        string text = File.ReadAllText(file, Encoding.UTF8);
        string[] blocks = Regex.Split(text, "(?=\\[\\d+\\] KEY:)");
        StringBuilder sb = new StringBuilder();
        foreach (var b in blocks) {
            if (string.IsNullOrWhiteSpace(b)) continue;
            var m = Regex.Match(b, "\\[(\\d+)\\] KEY:([^\\r\\n]+)");
            if (m.Success) {
                sb.AppendLine("==================================================");
                sb.AppendLine("[" + m.Groups[1].Value + "] " + m.Groups[2].Value);
                sb.AppendLine("==================================================");
                int enIdx = b.IndexOf("EN:");
                if (enIdx >= 0) {
                    string raw = b.Substring(enIdx + 3).Trim();
                    string[] pages = raw.Split(new string[] { "<PAGE>" }, StringSplitOptions.None);
                    for (int p = 0; p < pages.Length; p++) {
                        sb.AppendLine("--- PAGE " + (p + 1) + " ---");
                        sb.AppendLine(pages[p].Trim());
                    }
                }
            }
        }
        File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
        Console.WriteLine(outFile + " created.");
    }
}
