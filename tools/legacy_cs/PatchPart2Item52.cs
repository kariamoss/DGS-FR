using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string f = @"tools\Fix_Ep4_Part2_Auto.cs";
        string txt = File.ReadAllText(f, Encoding.UTF8);

        string oldStr = "s.Replace(\"(Do we have something the chief inspector could catch\\r\\nthe scent of, I wonder...?)\", \"(Avons-nous un indice dont l'inspecteur principal Toby pourrait\\r\\nsuivre la trace...?)\");";
        string newStr = "s.Replace(\"(Do we have something <E006>the chief inspector<E007> could catch\\r\\nthe scent of, <E003 6>I wonder...?)\", \"(Avons-nous un indice dont <E006>l'inspecteur principal<E007> pourrait suivre\\r\\nla trace, <E003 6>je me demande... ?)\");";

        if (txt.Contains(oldStr))
        {
            txt = txt.Replace(oldStr, newStr);
            File.WriteAllText(f, txt, Encoding.UTF8);
            Console.WriteLine("SUCCESS replacing oldStr in Part2");
        }
        else
        {
            Console.WriteLine("oldStr not found!");
        }
    }
}
