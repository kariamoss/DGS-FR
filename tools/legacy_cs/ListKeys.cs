using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        string file = args.Length > 0 ? args[0] : @"analyse\trans_ep3\act6_grp2_dump.txt";
        string[] lines = File.ReadAllLines(file);
        for (int i = 0; i < lines.Length; i++) {
            if (lines[i].StartsWith("[")) {
                Console.WriteLine(lines[i] + " (line " + i + ")");
            }
        }
    }
}
