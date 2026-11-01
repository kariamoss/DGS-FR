using System;
using System.IO;
using System.Text.RegularExpressions;
using DgsPatcher;

class Program {
    static void Main() {
        string frBase = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\";
        string[] arcFiles = new string[] {
            frBase + @"GO\sce00_eng.arc",
            frBase + @"GO\sce01_eng.arc",
            frBase + @"GO\sce02_eng.arc",
            frBase + @"GO\sce03_eng.arc",
            frBase + @"GO\sce04_eng.arc",
            frBase + @"GO\msg_title_eng.arc",
            frBase + @"BB\sce00_eng.arc",
            frBase + @"BB\sce01_eng.arc",
            frBase + @"BB\msg_title_eng.arc"
        };

        int totalKanji = 0;
        foreach (var arcPath in arcFiles) {
            var arc = ArcFile.Read(arcPath);
            int count = 0;
            foreach (var entry in arc.Entries) {
                string text = System.Text.Encoding.UTF8.GetString(entry.Data);
                if (text.Contains("<RUBY>")) {
                    MatchCollection mc = Regex.Matches(text, @"<RUBY><RB>(.*?)</RB><RT>(.*?)</RT></RUBY>");
                    foreach (Match m in mc) {
                        string rb = m.Groups[1].Value;
                        foreach (char c in rb) {
                            if (c >= 0x4E00 && c <= 0x9FFF) { count++; break; }
                        }
                    }
                }
            }
            Console.WriteLine("{0,-35} : {1} kanji rubies", Path.GetFileName(arcPath) + " (" + Path.GetDirectoryName(arcPath).Substring(frBase.Length) + ")", count);
            totalKanji += count;
        }

        Console.WriteLine("\nGRAND TOTAL KANJI RUBIES ACROSS ALL ARCS: " + totalKanji);
    }
}
