using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using DgsPatcher;

class ApplyFixes
{
    static void Main()
    {
        Console.WriteLine("Applying immediate fixes to GO\\sce01_eng.arc...");
        string goSce01Path = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO\sce01_eng.arc";
        if (File.Exists(goSce01Path))
        {
            var arc = ArcFile.Read(goSce01Path);
            bool modified = false;

            // Fix 1: "de ces griffures" in _sce01_c004_0008_eng
            var eGriffures = arc.Entries.Find(e => e.Name.Contains("_sce01_c004_0008"));
            if (eGriffures != null)
            {
                string text = Encoding.UTF8.GetString(eGriffures.Data);
                if (text.Contains("la douleur dans ces"))
                {
                    text = text.Replace("la douleur dans ces", "la douleur de ces");
                    eGriffures.Data = Encoding.UTF8.GetBytes(text);
                    modified = true;
                    Console.WriteLine("Fixed 'la douleur de ces griffures' in GO\\sce01_eng.arc!");
                }
            }

            // Fix 4: "to the wardrobe" and "of seasoning" in _sce01_c005_0003_eng
            var eWardrobe = arc.Entries.Find(e => e.Name.Contains("_sce01_c005_0003"));
            if (eWardrobe != null)
            {
                string text = Encoding.UTF8.GetString(eWardrobe.Data);
                // Replace ruby to the wardrobe
                string patternWardrobe = @"<RUBY><RB>to the wardrobe</RB><RT><COL f9e041ff>\s*ｊｕｓｑｕ＇￀\s*ｌ＇ａｒｍｏｉｒｅ</COL></RT></RUBY>";
                if (Regex.IsMatch(text, patternWardrobe))
                {
                    text = Regex.Replace(text, patternWardrobe, "jusqu'à l'armoire");
                    modified = true;
                    Console.WriteLine("Fixed 'to the wardrobe' -> 'jusqu'à l'armoire' in GO\\sce01_eng.arc!");
                }
                
                // Replace ruby of seasoning
                string patternSeasoning = @"<RUBY><RB>of seasoning</RB><RT><COL f9e041ff>\s*ｄ＇ａｓｓａｉｓｏｎｎｅｍｅｎｔ</COL></RT></RUBY>";
                if (Regex.IsMatch(text, patternSeasoning))
                {
                    text = Regex.Replace(text, patternSeasoning, "d'assaisonnement");
                    modified = true;
                    Console.WriteLine("Fixed 'of seasoning' -> 'd'assaisonnement' in GO\\sce01_eng.arc!");
                }
                
                eWardrobe.Data = Encoding.UTF8.GetBytes(text);
            }

            if (modified)
            {
                arc.Save(goSce01Path);
                Console.WriteLine("Saved GO\\sce01_eng.arc!");
            }
        }

        Console.WriteLine("Applying fixes to BB\\sce04_eng.arc...");
        string bbSce04Path = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\BB\sce04_eng.arc";
        if (File.Exists(bbSce04Path))
        {
            var arc = ArcFile.Read(bbSce04Path);
            bool modified = false;

            // Fix duel lines in _sce04_c500_0080_eng
            var eDuel = arc.Entries.Find(e => e.Name.Contains("_sce04_c500_0080"));
            if (eDuel != null)
            {
                string text = Encoding.UTF8.GetString(eDuel.Data);
                if (text.Contains("... we'll fight a duel.   A duel of words,   across the  courtroom."))
                {
                    text = text.Replace("... we'll fight a duel.   A duel of words,   across the  courtroom.",
                                        "... nous nous battrons en duel.   Un duel de mots,   à travers le  prétoire.");
                    eDuel.Data = Encoding.UTF8.GetBytes(text);
                    modified = true;
                    Console.WriteLine("Fixed duel line in BB\\sce04_eng.arc!");
                }
            }

            // Fix man's gaze in _sce04_c104_0080_eng
            var eGaze = arc.Entries.Find(e => e.Name.Contains("_sce04_c104_0080"));
            if (eGaze != null)
            {
                string text = Encoding.UTF8.GetString(eGaze.Data);
                if (text.Contains("We need only follow the man's gaze             pour savoir où notre"))
                {
                    text = text.Replace("We need only follow the man's gaze             pour savoir où notre",
                                        "Il suffit de suivre le regard de cet homme             pour savoir où notre");
                    eGaze.Data = Encoding.UTF8.GetBytes(text);
                    modified = true;
                    Console.WriteLine("Fixed man's gaze line in BB\\sce04_eng.arc!");
                }
            }

            if (modified)
            {
                arc.Save(bbSce04Path);
                Console.WriteLine("Saved BB\\sce04_eng.arc!");
            }
        }

        Console.WriteLine("Done applying immediate fixes.");
    }
}
