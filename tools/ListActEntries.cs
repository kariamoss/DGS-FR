using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ListEntries {
    class Program {
        static void Main(string[] args) {
            string file = args.Length > 0 ? args[0] : @"tools\ep5_act4.txt";
            string[] lines = File.ReadAllLines(file);
            for (int i = 0; i < lines.Length; i++) {
                if (Regex.IsMatch(lines[i], @"^\[\d+\]")) {
                    Console.WriteLine(lines[i] + " (Line " + (i+1) + ")");
                }
            }
        }
    }
}
