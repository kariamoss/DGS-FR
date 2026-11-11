using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DgsPatcher;

namespace DgsTranslatorTool {
    public class Program {
        // Échappe une chaîne pour du JSON simple
        static string EscapeJson(string s) {
            if (s == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (char c in s) {
                switch (c) {
                    case '\\': sb.Append("\\\\"); break;
                    case '"': sb.Append("\\\""); break;
                    case '\b': sb.Append("\\b"); break;
                    case '\f': sb.Append("\\f"); break;
                    case '\n': sb.Append("\\n"); break;
                    case '\r': sb.Append("\\r"); break;
                    case '\t': sb.Append("\\t"); break;
                    default:
                        if (c < ' ') {
                            sb.AppendFormat("\\u{0:x4}", (int)c);
                        } else {
                            sb.Append(c);
                        }
                        break;
                }
            }
            return sb.ToString();
        }

        // Extrait les chaînes d'un ARC vers un fichier JSON
        public static void Extract(string arcPath, string jsonOutPath) {
            ArcFile arc = ArcFile.Read(arcPath);
            StringBuilder json = new StringBuilder();
            json.AppendLine("[");

            bool firstEntry = true;
            int totalEntries = 0;
            int totalStrings = 0;

            foreach (var entry in arc.Entries) {
                if (entry.Data == null || entry.Data.Length < 40) continue;
                string magic = Encoding.ASCII.GetString(entry.Data, 0, 4);
                if (magic != "GMD\0") continue;

                uint strBlockSize = BitConverter.ToUInt32(entry.Data, 32);
                int strStart = entry.Data.Length - (int)strBlockSize;
                if (strStart < 40 || strStart >= entry.Data.Length) continue;

                List<string> strings = new List<string>();
                List<byte> curr = new List<byte>();
                for (int i = strStart; i < entry.Data.Length; i++) {
                    if (entry.Data[i] == 0) {
                        strings.Add(Encoding.UTF8.GetString(curr.ToArray()));
                        curr.Clear();
                    } else {
                        curr.Add(entry.Data[i]);
                    }
                }

                if (!firstEntry) json.AppendLine(",");
                firstEntry = false;

                json.AppendLine("  {");
                json.AppendLine("    \"EntryName\": \"" + EscapeJson(entry.Name) + "\",");
                json.AppendLine("    \"Items\": [");

                for (int i = 0; i < strings.Count; i++) {
                    string s = strings[i];
                    json.Append("      { \"Index\": " + i + ", \"En\": \"" + EscapeJson(s) + "\", \"Fr\": \"\" }");
                    if (i < strings.Count - 1) json.AppendLine(",");
                    else json.AppendLine();
                    totalStrings++;
                }

                json.AppendLine("    ]");
                json.Append("  }");
                totalEntries++;
            }

            json.AppendLine("\n]");
            File.WriteAllText(jsonOutPath, json.ToString(), Encoding.UTF8);
            Console.WriteLine("Extraction terminée : " + totalEntries + " entrées, " + totalStrings + " chaînes extraites dans " + jsonOutPath);
        }

        // Parseur JSON simple et rapide pour notre format
        public static Dictionary<string, List<string>> LoadTranslations(string jsonPath) {
            var result = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            string json = File.ReadAllText(jsonPath, Encoding.UTF8);

            // Rechercher chaque bloc d'entrée
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);
            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;

                var list = new List<string>();
                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
                foreach (Match im in itemMatches) {
                    string en = UnescapeJson(im.Groups[2].Value);
                    string fr = UnescapeJson(im.Groups[3].Value);
                    string chosen = !string.IsNullOrEmpty(fr) ? fr : en;
                    list.Add(chosen);
                }
                result[entryName] = list;
            }
            return result;
        }

        static string UnescapeJson(string s) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == '\\' && i + 1 < s.Length) {
                    char next = s[i + 1];
                    if (next == '\\') { sb.Append('\\'); i++; }
                    else if (next == '"') { sb.Append('"'); i++; }
                    else if (next == 'n') { sb.Append('\n'); i++; }
                    else if (next == 'r') { sb.Append('\r'); i++; }
                    else if (next == 't') { sb.Append('\t'); i++; }
                    else if (next == 'u' && i + 5 < s.Length) {
                        string hex = s.Substring(i + 2, 4);
                        sb.Append((char)Convert.ToInt32(hex, 16));
                        i += 5;
                    } else {
                        sb.Append(next); i++;
                    }
                } else {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }

        // Injecte les chaînes traduites dans un ARC et sauvegarde
        public static void Inject(string baseArcPath, string jsonPath, string outputArcPath) {
            var transDict = LoadTranslations(jsonPath);
            Console.WriteLine("Traductions chargées : " + transDict.Count + " entrées trouvées dans le JSON.");

            ArcFile arc = ArcFile.Read(baseArcPath);
            int modifiedEntries = 0;
            int totalStringsInjected = 0;

            foreach (var entry in arc.Entries) {
                if (entry.Data == null || entry.Data.Length < 40) continue;
                string magic = Encoding.ASCII.GetString(entry.Data, 0, 4);
                if (magic != "GMD\0") continue;

                if (!transDict.ContainsKey(entry.Name)) continue;
                List<string> newStrings = transDict[entry.Name];

                uint strBlockSize = BitConverter.ToUInt32(entry.Data, 32);
                int strStart = entry.Data.Length - (int)strBlockSize;
                if (strStart < 40 || strStart >= entry.Data.Length) continue;

                using (MemoryStream newStrBlock = new MemoryStream()) {
                    foreach (var s in newStrings) {
                        byte[] strBytes = Encoding.UTF8.GetBytes(s);
                        newStrBlock.Write(strBytes, 0, strBytes.Length);
                        newStrBlock.WriteByte(0); // terminateur null
                        totalStringsInjected++;
                    }
                    byte[] newBlockBytes = newStrBlock.ToArray();
                    uint newStrBlockSize = (uint)newBlockBytes.Length;

                    byte[] newGmd = new byte[strStart + newBlockBytes.Length];
                    Array.Copy(entry.Data, 0, newGmd, 0, strStart);
                    byte[] sizeBytes = BitConverter.GetBytes(newStrBlockSize);
                    Array.Copy(sizeBytes, 0, newGmd, 32, 4);
                    Array.Copy(newBlockBytes, 0, newGmd, strStart, newBlockBytes.Length);

                    entry.Data = newGmd;
                    modifiedEntries++;
                }
            }

            arc.Save(outputArcPath);
            Console.WriteLine("Injection terminée : " + modifiedEntries + " entrées mises à jour, " + totalStringsInjected + " chaînes réinjectées.");
            Console.WriteLine("Fichier de sortie généré : " + outputArcPath + " (" + new FileInfo(outputArcPath).Length + " octets)");
        }

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            if (args.Length < 3) {
                Console.WriteLine("Usage: DgsTranslator.exe extract <arcFile> <jsonOut>");
                Console.WriteLine("       DgsTranslator.exe inject <baseArcFile> <jsonIn> <arcOut>");
                return;
            }

            string mode = args[0].ToLowerInvariant();
            if (mode == "extract") {
                Extract(args[1], args[2]);
            } else if (mode == "inject" && args.Length >= 4) {
                Inject(args[1], args[2], args[3]);
            }
        }
    }
}
