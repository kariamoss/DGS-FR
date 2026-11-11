using System;
using System.IO;

class PrintRange {
    static void Main(string[] args) {
        string file = args[0];
        int start = int.Parse(args[1]);
        int end = int.Parse(args[2]);
        string[] lines = File.ReadAllLines(file);
        for (int i = start; i <= end && i < lines.Length; i++) {
            Console.WriteLine(lines[i]);
        }
    }
}
