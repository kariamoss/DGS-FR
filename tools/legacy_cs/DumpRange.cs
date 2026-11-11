using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class DumpRange {
    static void Main(string[] args) {
        if (args.Length < 3) {
            Console.WriteLine("Usage: DumpRange <dump_file> <start_num> <end_num> [out_file]");
            return;
        }
        string dumpFile = args[0];
        int start = int.Parse(args[1]);
        int end = int.Parse(args[2]);
        string outFile = args.Length >= 4 ? args[3] : null;

        string[] lines = File.ReadAllLines(dumpFile, Encoding.UTF8);
        StringBuilder sb = new StringBuilder();
        bool capturing = false;

        foreach (var line in lines) {
            var m = Regex.Match(line, @"^\[(\d+)\] KEY:(.+)");
            if (m.Success) {
                int num = int.Parse(m.Groups[1].Value);
                if (num >= start && num <= end) {
                    capturing = true;
                } else if (num > end) {
                    capturing = false;
                } else {
                    capturing = false;
                }
            }
            if (capturing) {
                sb.AppendLine(line);
            }
        }

        if (outFile != null) {
            File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
            Console.WriteLine("Wrote " + outFile);
        } else {
            Console.WriteLine(sb.ToString());
        }
    }
}
