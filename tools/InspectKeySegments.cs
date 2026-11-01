using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class InspectSegments {
    static void Main(string[] args) {
        string[] files = new string[] { "tools\\act3_81_95_raw.txt", "tools\\act3_96_107_raw.txt" };
        foreach (var file in files) {
            string[] lines = File.ReadAllLines(file, Encoding.UTF8);
            string curKey = "";
            StringBuilder sb = new StringBuilder();
            foreach (var l in lines) {
                if (l.StartsWith("KEY:")) {
                    if (curKey != "") Process(curKey, sb.ToString());
                    curKey = l.Substring(4);
                    sb.Clear();
                } else if (l.StartsWith("-----------------")) {
                    // separator
                } else {
                    sb.AppendLine(l);
                }
            }
            if (curKey != "") Process(curKey, sb.ToString());
        }
    }

    static void Process(string key, string content) {
        Console.WriteLine("==================================================");
        Console.WriteLine("KEY: " + key);
        Console.WriteLine("==================================================");
        // Split by <PAGE> or analyze text chunks
        string[] pages = content.Split(new string[] { "<PAGE>" }, StringSplitOptions.None);
        for (int p = 0; p < pages.Length; p++) {
            string page = pages[p];
            // Find text blocks outside of <...>
            // Or show page with tags simplified
            Console.WriteLine("--- PAGE " + (p + 1) + " ---");
            Console.WriteLine(page.Trim());
        }
    }
}
