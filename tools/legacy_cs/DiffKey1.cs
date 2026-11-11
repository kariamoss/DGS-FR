using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string p1 = File.ReadAllText(@"tools\Fix_Ep4_Part1.cs", Encoding.UTF8);
        int idx = p1.IndexOf(@"BB\script\output\_sce03_bg0200_0_check_eng#2");
        int next = p1.IndexOf(@"// [2]", idx);
        Console.WriteLine("--- Fix_Ep4_Part1.cs ---");
        Console.WriteLine(p1.Substring(idx, next - idx));

        // Now see Trans_Ep4_Act1
        string act1 = File.ReadAllText(@"tools\Trans_Ep4_Act1_Part4.cs", Encoding.UTF8);
        int aIdx = act1.IndexOf(@"BB\script\output\_sce03_bg0200_0_check_eng#2");
        if (aIdx >= 0)
        {
            int aNext = act1.IndexOf(@"entryTranslators[", aIdx + 10);
            Console.WriteLine("--- Trans_Ep4_Act1 ---");
            Console.WriteLine(act1.Substring(aIdx, (aNext > 0 ? aNext : aIdx + 500) - aIdx));
        }
    }
}
