using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReadPartSummary {
    static void Main(string[] args) {
        string file = args[0];
        string text = File.ReadAllText(file, Encoding.UTF8);
        string[] blocks = Regex.Split(text, "(?=\\[\\d+\\] KEY:)");
        foreach (var b in blocks) {
            if (string.IsNullOrWhiteSpace(b)) continue;
            var m = Regex.Match(b, "\\[(\\d+)\\] KEY:([^\\r\\n]+)");
            if (m.Success) {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("[" + m.Groups[1].Value + "] " + m.Groups[2].Value);
                // Strip tags and show first 3 lines of dialogue
                string raw = b.Substring(b.IndexOf("EN:") + 3);
                string clean = Regex.Replace(raw, "<[^>]+>", "").Trim();
                string[] lines = clean.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < Math.Min(4, lines.Length); i++) {
                    Console.WriteLine("  " + lines[i]);
                }
                if (lines.Length > 4) Console.WriteLine("  ... (" + lines.Length + " lines total)");
            }
        }
    }
}
