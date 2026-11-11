using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Let's test chr010_01_eng#5
        string key = @"BB\script\output\_sce03_chr010_01_eng#5";
        
        // Let's see what's in analyse\data\sce03_fr.json for this key
        string json = File.ReadAllText(@"analyse\data\sce03_fr.json", Encoding.UTF8);
        // Find key in json
        int idx = json.IndexOf(key);
        if (idx >= 0)
        {
            int frIdx = json.IndexOf("\"Fr\":", idx);
            int enIdx = json.IndexOf("\"En\":", idx);
            Console.WriteLine("Key found in sce03_fr.json");
            Console.WriteLine("Fr starts at: " + frIdx);
        }

        // Also let's check Trans_Ep4_Act2_Part1.cs for chr010_01_eng#5
        string act2 = File.ReadAllText(@"tools\Trans_Ep4_Act2_Part1.cs", Encoding.UTF8);
        int actKeyIdx = act2.IndexOf(key);
        if (actKeyIdx >= 0)
        {
            int nextEntry = act2.IndexOf("entryTranslators[", actKeyIdx + 10);
            string snippet = act2.Substring(actKeyIdx, (nextEntry > 0 ? nextEntry : actKeyIdx + 1000) - actKeyIdx);
            Console.WriteLine("--- Snippet from Trans_Ep4_Act2_Part1.cs ---");
            Console.WriteLine(snippet);
        }
    }
}
