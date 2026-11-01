using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string actFile = args[0];
        string json = File.ReadAllText(actFile, Encoding.UTF8);
        var entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
        Console.WriteLine("Entries in " + actFile + ": " + entryMatches.Count);

        int totalItems = 0;
        int max = Math.Min(entryMatches.Count, 15);
        for (int i = 0; i < max; i++)
        {
            var em = entryMatches[i];
            string name = em.Groups[1].Value.Replace("\\\\", "\\");
            var itemMatches = Regex.Matches(em.Groups[2].Value, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)", RegexOptions.Singleline);
            totalItems += itemMatches.Count;
            Console.WriteLine("  [" + i + "] " + name + " (" + itemMatches.Count + " items)");
        }
        for (int i = max; i < entryMatches.Count; i++)
        {
            var em = entryMatches[i];
            var itemMatches = Regex.Matches(em.Groups[2].Value, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)", RegexOptions.Singleline);
            totalItems += itemMatches.Count;
        }
        Console.WriteLine("Total items across all entries: " + totalItems);
    }
}
