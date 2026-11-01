using System;
using System.IO;
using System.Text;

class DumpAct5 {
    static void Main() {
        string[] lines = File.ReadAllLines(@"analyse\trans_ep4\act5_trial3_evidence_macro_dump.txt", Encoding.UTF8);
        
        Action<int, int, string, string> savePart = (start, end, outFile, pagesFile) => {
            StringBuilder sb = new StringBuilder();
            StringBuilder sbPages = new StringBuilder();
            bool capture = false;
            string curKey = "";
            int curNum = 0;
            
            foreach (var l in lines) {
                if (l.StartsWith("[") && l.Contains("] KEY:")) {
                    int c = int.Parse(l.Substring(1, l.IndexOf(']') - 1));
                    if (c >= start && c <= end) {
                        capture = true;
                        curNum = c;
                        curKey = l.Substring(l.IndexOf("KEY:") + 4).Trim();
                        sb.AppendLine(l);
                        sbPages.AppendLine("==================================================");
                        sbPages.AppendLine("[" + curNum + "] " + curKey);
                        sbPages.AppendLine("==================================================");
                    } else {
                        capture = false;
                    }
                    continue;
                }
                if (capture) {
                    sb.AppendLine(l);
                    if (l.StartsWith("EN:")) {
                        string raw = l.Substring(3);
                        string[] pages = raw.Split(new string[] { "<PAGE>" }, StringSplitOptions.None);
                        for (int p = 0; p < pages.Length; p++) {
                            sbPages.AppendLine("--- PAGE " + (p + 1) + " ---");
                            sbPages.AppendLine(pages[p].Trim());
                        }
                    }
                }
            }
            File.WriteAllText(outFile, sb.ToString(), Encoding.UTF8);
            File.WriteAllText(pagesFile, sbPages.ToString(), Encoding.UTF8);
            Console.WriteLine(outFile + " written (keys " + start + " to " + end + ")");
        };

        savePart(1, 45, @"analyse\trans_ep4\act5_part1_dump.txt", @"tools\act5_part1_pages.txt");
        savePart(46, 90, @"analyse\trans_ep4\act5_part2_dump.txt", @"tools\act5_part2_pages.txt");
        savePart(91, 135, @"analyse\trans_ep4\act5_part3_dump.txt", @"tools\act5_part3_pages.txt");
        savePart(136, 173, @"analyse\trans_ep4\act5_part4_dump.txt", @"tools\act5_part4_pages.txt");
    }
}
