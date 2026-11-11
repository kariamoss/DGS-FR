using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"analyse\trans_ep4\act3_trial1_dump.txt", Encoding.UTF8);
        var p1 = new StringBuilder();
        var p2 = new StringBuilder();
        int curr = 0;

        foreach (var l in lines)
        {
            var m = Regex.Match(l, @"^\[(\d+)\] KEY:");
            if (m.Success)
            {
                curr = int.Parse(m.Groups[1].Value);
            }
            if (curr <= 55)
            {
                p1.AppendLine(l);
            }
            else
            {
                p2.AppendLine(l);
            }
        }

        File.WriteAllText(@"analyse\trans_ep4\act3_part1_dump.txt", p1.ToString(), Encoding.UTF8);
        File.WriteAllText(@"analyse\trans_ep4\act3_part2_dump.txt", p2.ToString(), Encoding.UTF8);
        Console.WriteLine("Act 3 split into part 1 (1-55) and part 2 (56-107)!");
    }
}
