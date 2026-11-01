using System;
using System.IO;
using System.Text.RegularExpressions;

class ListSlices {
    static void Main(string[] args) {
        if (args.Length < 1) return;
        string[] lines = File.ReadAllLines(args[0]);
        foreach (string line in lines) {
            Match m = Regex.Match(line, @"^\s*\[(\d+)\]\s*(.+)");
            if (m.Success) {
                Console.WriteLine("[" + m.Groups[1].Value + "] " + m.Groups[2].Value);
            }
        }
    }
}
