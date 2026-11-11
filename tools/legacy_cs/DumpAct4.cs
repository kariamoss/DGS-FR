using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class DumpAct4 {
    static void Main() {
        string[] lines = File.ReadAllLines(@"analyse\trans_ep4\act4_trial2_dump.txt", Encoding.UTF8);
        List<string> curLines = new List<string>();
        int curNum = 0;
        Action<int, int, string> savePart = (start, end, outFile) => {
            StringBuilder sb = new StringBuilder();
            bool capture = false;
            foreach (var l in lines) {
                if (l.StartsWith("[") && l.Contains("] KEY:")) {
                    int c = int.Parse(l.Substring(1, l.IndexOf(']') - 1));
                    if (c >= start && c <= end) capture = true;
                    else capture = false;
                }
                if (capture) sb.AppendLine(l);
            }
            File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
            Console.WriteLine(outFile + " written (keys " + start + " to " + end + ")");
        };

        savePart(1, 27, @"analyse\trans_ep4\act4_part1_dump.txt");
        savePart(28, 54, @"analyse\trans_ep4\act4_part2_dump.txt");
        savePart(55, 80, @"analyse\trans_ep4\act4_part3_dump.txt");
        savePart(81, 106, @"analyse\trans_ep4\act4_part4_dump.txt");
    }
}
