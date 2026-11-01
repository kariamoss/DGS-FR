using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TranslatorAct1 {
    class Program {
        static Dictionary<string, Func<string, string>> entryTranslators = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase);

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            string inPath = @"analyse\trans_ep3\act1_intro.json";
            string outPath = @"analyse\trans_ep3\act1_intro_translated.json";

            RegisterTranslators();
            RegisterDeductionTranslators();

            string json = File.ReadAllText(inPath, Encoding.UTF8);
            MatchCollection entryMatches = Regex.Matches(json, "\"EntryName\"\\s*:\\s*\"([^\"]+)\"\\s*,\\s*\"Items\"\\s*:\\s*\\[(.*?)\\]\\s*\\}", RegexOptions.Singleline);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            bool firstEntry = true;
            int translatedCount = 0;
            int missingCount = 0;

            foreach (Match em in entryMatches) {
                string entryName = em.Groups[1].Value.Replace("\\\\", "\\");
                string itemsContent = em.Groups[2].Value;

                if (!firstEntry) sb.AppendLine(",");
                firstEntry = false;

                sb.AppendLine("  {");
                sb.AppendLine("    \"EntryName\": \"" + entryName.Replace("\\", "\\\\") + "\",");
                sb.AppendLine("    \"Items\": [");

                MatchCollection itemMatches = Regex.Matches(itemsContent, "\\{\\s*\"Index\"\\s*:\\s*(\\d+)\\s*,\\s*\"En\"\\s*:\\s*\"(.*?)\"\\s*,\\s*\"Fr\"\\s*:\\s*\"(.*?)\"\\s*\\}", RegexOptions.Singleline);
                bool firstItem = true;

                foreach (Match im in itemMatches) {
                    string idx = im.Groups[1].Value;
                    string en = UnescapeJson(im.Groups[2].Value);
                    string fr = "";

                    string stripped = Regex.Replace(en, "<[^>]+>", "").Trim();
                    if (stripped.Length > 0 && Regex.IsMatch(stripped, "[a-zA-Z]{2,}")) {
                        string key = entryName + "#" + idx;
                        if (entryTranslators.ContainsKey(key)) {
                            fr = entryTranslators[key](en);
                            translatedCount++;
                        } else {
                            Console.WriteLine("ATTENTION: Manquant pour " + key);
                            missingCount++;
                        }
                    }

                    if (!firstItem) sb.AppendLine(",");
                    firstItem = false;
                    sb.Append("      { \"Index\": " + idx + ", \"En\": \"" + EscapeJson(en) + "\", \"Fr\": \"" + EscapeJson(fr) + "\" }");
                }

                sb.AppendLine("\n    ]");
                sb.Append("  }");
            }

            sb.AppendLine("\n]");
            File.WriteAllText(outPath, sb.ToString(), Encoding.UTF8);
            Console.WriteLine("=== BILAN ACT 1 ===");
            Console.WriteLine("Traduits : " + translatedCount);
            Console.WriteLine("Manquants : " + missingCount);
            Console.WriteLine("Fichier généré : " + outPath);
        }

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
                        if (c < ' ') { sb.AppendFormat("\\u{0:x4}", (int)c); }
                        else { sb.Append(c); }
                        break;
                }
            }
            return sb.ToString();
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

        static void RegisterTranslators() {
            // _sce02_c000_0010_eng
            entryTranslators["BB\\script\\output\\_sce02_c000_0010_eng#2"] = en => {
                string s = en;
                s = s.Replace("We're here at the showground of the Great Exhibition,<E003 10>\r\n<E042><CNTR>which is absolutely packed with people...",
                              "Nous voici sur le site de l'Exposition universelle,<E003 10>\r\n<E042><CNTR>qui déborde d'une foule immense et enthousiaste...");
                s = s.Replace("The weather is unusually fine, <E003 11><E025 3>and we're about to\r\n<E042><CNTR>witness a most extraordinary scientific experiment!",
                              "Le temps est radieux, <E003 11><E025 3>et nous allons assister\r\n<E042><CNTR>à une expérience scientifique extraordinaire !");
                s = s.Replace("Ladies and gentlemen, <E003 10>the twentieth century will see\r\n<E042><CNTR>steam engines <E003 4><E025 4>and electrical power<E003 4><E025 3> dominate the world!",
                              "Mesdames et messieurs, <E003 10>le vingtième siècle verra\r\n<E042><CNTR>la vapeur <E003 4><E025 4>et l'électricité<E003 4><E025 3> conquérir le monde entier !");
                s = s.Replace("Horse-drawn carts <E003 4>will give way <E003 4><E025 3>to the motor car!<E003 36>\r\n<E042><CNTR><E025 4>Ships <E003 4>will sprout wings <E003 4>and <E003 4><E025 4>take to the skies!",
                              "Les calèches <E003 4>céderont le pas <E003 4><E025 3>à l'automobile !<E003 36>\r\n<E042><CNTR><E025 4>Les navires <E003 4>déploieront des ailes <E003 4>pour <E003 4><E025 4>fendre les cieux !");
                s = s.Replace("And today, <E003 6><E025 3>we showcase <E003 4>even more advanced\r\n<E042><CNTR><E003 6>technology!<E003 20> <E025 3>A glimpse <E003 8>into the future!",
                              "Et aujourd'hui, <E003 6><E025 3>nous vous dévoilons <E003 4>une technologie\r\n<E042><CNTR><E003 6>plus prodigieuse encore !<E003 20> <E025 3>Un aperçu <E003 8>du futur !");
                s = s.Replace("A world first!<E003 18> <E025 3>A demonstration of my\r\n<E042><CNTR>super-high-voltage <E025 4>instantaneous <E003 6><E025 3>kinesis <E003 4>machine!",
                              "Une première mondiale !<E003 18> <E025 3>La démonstration de mon\r\n<E042><CNTR>dispositif de téléportation <E025 4>instantanée <E003 6><E025 3>par supratension !<E003 4>");
                s = s.Replace("A man <E003 6>will literally be <E025 4>disassembled <E003 4><E025 3>by a pulse <E003 4>of\r\n<E042><CNTR>high-voltage <E025 4>electricity, <E003 12><E025 2>and <E025 3>beamed <E003 6>to another location...",
                              "Un homme <E003 6>va être littéralement <E025 4>dématérialisé <E003 4><E025 3>par une impulsion <E003 4>de\r\n<E042><CNTR>haute tension, <E003 12><E025 2>puis <E025 3>projeté <E003 6>en un autre lieu...");
                s = s.Replace("...whereupon his body will be <E003 4><E025 6>reassembled <E003 4><E025 3>by a series of<E003 16>\r\n<E042><CNTR><E025 3>complex calculations <E003 10>exactly <E003 8>as it was <E003 4>before!",
                              "...où son corps sera <E003 4><E025 6>reconstitué <E003 4><E025 3>par une série de<E003 16>\r\n<E042><CNTR><E025 3>calculs complexes, <E003 10>exactement <E003 8>à l'identique !<E003 4>");
                s = s.Replace("In <E003 8>but a few moments from now...",
                              "D'ici <E003 8>quelques secondes à peine...");
                s = s.Replace("...this gentleman will, <E003 8><E025 1>in the blink of an eye,\r\n<E042><CNTR><E003 16><E025 2>complete an incredible journey through the air...",
                              "...ce brave monsieur va, <E003 8><E025 1>en un clin d'œil,\r\n<E042><CNTR><E003 16><E025 2>accomplir un voyage foudroyant à travers les airs...");
                s = s.Replace("...to arrive an instant later,<E003 8>\r\n<E042><CNTR>on the <E003 6><E025 5>Crystal Tower behind you!",
                              "...pour réapparaître aussitôt,<E003 8>\r\n<E042><CNTR>au sommet de la <E003 6><E025 5>Tour de Cristal derrière vous !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c000_0010_eng#3"] = en => {
                string s = en;
                s = s.Replace("...to arrive an instant later,<E003 8>\r\n<E042><CNTR>on the <E003 6><E025 5>Crystal Tower behind you!",
                              "...pour réapparaître aussitôt,<E003 8>\r\n<E042><CNTR>au sommet de la <E003 6><E025 5>Tour de Cristal derrière vous !");
                return s;
            };

            // _sce02_c000_0020_eng
            entryTranslators["BB\\script\\output\\_sce02_c000_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("22nd October, 9:36 a.m.\r\n<CNTR><E003 5>Sholmes's Suite",
                              "22 octobre, 9h36\r\n<CNTR><E003 5>Appartement de Mr Holmes");
                s = s.Replace("...Runo!<E049><E003 10> Runo, <E049><E003 8><E025 2>are you listening?",
                              "...Nicky !<E049><E003 10> Nicky, <E049><E003 8><E025 2>tu m'écoutes ?");
                s = s.Replace("Oh!<E003 10> <E025 3>Sorry, <E003 8>um...<E003 8><E025 2>what was that, Iris?",
                              "Oh !<E003 10> <E025 3>Pardon, <E003 8>euh...<E003 8><E025 2> tu disais quoi, Iris ?");
                s = s.Replace("Hmph.<E003 12> <E169 4 3><E025 2>What's the matter with you?<E049><E003 10>\r\nYou've been miles away all morning.",
                              "Hmph.<E003 12> <E169 4 3><E025 2>Qu'est-ce qui t'arrive ?<E049><E003 10>\r\nTu as la tête ailleurs depuis ce matin.");
                s = s.Replace("Didn't you like what I cooked for breakfast?",
                              "C'est mon petit déjeuner qui ne t'a pas plu ?");
                s = s.Replace("No no, <E003 8>that's not it at all.",
                              "Non non, <E003 8>ce n'est pas ça du tout.");
                s = s.Replace("what were we talking about again?",
                              "de quoi parlions-nous, déjà ?");
                s = s.Replace("Today's paper!<E049><E003 10> It's full of news about the Great Exhibition\r\nagain!",
                              "Du journal !<E049><E003 10> Ça ne parle que de l'Exposition universelle,\r\nune fois de plus !");
                s = s.Replace("Ah yes...<E003 10><E025 2>the Great Exhibition...<E003 8>\r\nI'd like to go sometime.",
                              "Ah oui...<E003 10><E025 2> l'Exposition universelle...<E003 8>\r\nJ'aimerais bien y aller un jour.");
                s = s.Replace("You're really not your usual self today.<E049><E003 10>\r\nYou seem very down.",
                              "Tu n'es vraiment pas dans ton assiette aujourd'hui.<E049><E003 10>\r\nTu as l'air tout triste.");
                s = s.Replace("Don't you agree, <E003 4>Hurley?",
                              "Tu ne trouves pas, <E003 4>Sherlockinou ?");
                s = s.Replace("Hm<E025 10>...?<E049><E003 15> <E145 19 87><E144 19><E025 4>Did you say something?<E049><E003 12>\r\n<E025 5>Iris?",
                              "Hm<E025 10>... ?<E049><E003 15> <E145 19 87><E144 19><E025 4>Tu as dit quelque chose ?<E049><E003 12>\r\n<E025 5>Iris ?");
                s = s.Replace("Oh gosh!<E003 12> You're even more down!",
                              "Ça alors !<E003 12> Tu as l'air encore plus déprimé que lui !");
                s = s.Replace("Wh-<E003 10><E332>When did you arrive, <E049><E003 8>Mr Naruhodo?",
                              "Q-<E003 10><E332>Quand êtes-vous arrivé, <E049><E003 8>Mister Yûno ?");
                s = s.Replace("I've...<E003 8><E025 2>been here for about half an hour already.<E003 10>\r\nWe had breakfast together.",
                              "Je...<E003 8><E025 2> suis là depuis une demi-heure déjà.<E003 10>\r\nNous avons pris le petit déjeuner ensemble.");
                s = s.Replace("What?!<E049><E003 15>\r\n<E025 1><E346>Why didn't you mention it before?",
                              "Quoi ?!<E049><E003 15>\r\n<E025 1><E346>Pourquoi ne m'avez-vous rien dit plus tôt ?");
                s = s.Replace("I, <E003 8>um...<E003 10><E025 2>thought you might have known I was here.<E145 19 64><E117 19 30><E003 12>\r\nYou know, <E003 6><E025 3>because...<E003 8>breakfast?",
                              "Je, <E003 8>euh...<E003 10><E025 2> je pensais que vous aviez remarqué ma présence.<E145 19 64><E117 19 30><E003 12>\r\nEnfin, <E003 6><E025 3>puisqu'on...<E003 8> mangeait ensemble ?");
                s = s.Replace("Hm, <E003 8><E169 19 3>Iris is quite right.<E049><E003 8> You're clearly lacking in vim.<E049><E003 10>\r\n<E164 19 79 1 2 7 0 0 1><E139 19>So much so that I didn't notice your presence.",
                              "Hm, <E003 8><E169 19 3>Iris a tout à fait raison.<E049><E003 8> Vous manquez cruellement d'énergie.<E049><E003 10>\r\n<E164 19 79 1 2 7 0 0 1><E139 19>À tel point que je n'ai même pas décelé votre présence.");
                s = s.Replace("(...Thanks.)", "(... Merci beaucoup.)");
                s = s.Replace("Of course, <E049><E003 10><E025 2>I could deduce the reason perfectly well with\r\nsome simple observations.",
                              "Naturellement, <E049><E003 10><E025 2>je pourrais en déduire la cause exacte à l'aide\r\nde quelques simples observations.");
                s = s.Replace("What?!<E023><PAGE>", "Quoi ?!<E023><PAGE>");
                s = s.Replace("Let's see...<E049><E003 12> Yes, <E003 6>for example, <E049><E003 8><E025 2>your tussled hair this\r\nmorning, <E049><E003 6>with all its unruly spikes.",
                              "Voyons voir...<E049><E003 12> Oui, <E003 6>par exemple, <E049><E003 8><E025 2>vos cheveux ébouriffés ce matin,<E049><E003 6>\r\navec tous ces épis indomptables.");
                s = s.Replace("Clearly it can be deduced therefore, <E049><E003 8><E025 3>that–",
                              "On peut dès lors en déduire sans équivoque <E049><E003 8><E025 3>que...");
                s = s.Replace("Um, <E003 8><E025 2>let me stop you there, Mr Sholmes, <E003 10>because I think I\r\ncan see where this is going.",
                              "Euh, <E003 8><E025 2>je vous arrête tout de suite, Mr Holmes, <E003 10>car je vois très\r\nbien où vous voulez en venir.");
                s = s.Replace("My hair always looks like this.<E003 10> <E043><E145 19 64><E025 3>It always has.<E003 12>\r\n<E025 2>Ever since we first met,<E003 6> in fact.",
                              "Mes cheveux sont toujours coiffés comme ça.<E003 10> <E043><E145 19 64><E025 3>Depuis toujours.<E003 12>\r\n<E025 2>Depuis notre toute première rencontre, en fait.<E003 6>");
                s = s.Replace("Oh really?<E049><E003 10> How interesting.<E049><E003 8> It just doesn't look like a\r\nhaircut as such, <E003 4>I suppose.",
                              "Ah bon ?<E049><E003 10> Comme c'est fascinant.<E049><E003 8> Cela ne ressemble guère à une coupe\r\nde cheveux digne de ce nom, <E003 4>j'imagine.");
                s = s.Replace("(...Thanks again.)", "(... Merci encore.)");
                s = s.Replace("It crossed my mind recently...<E145 19 64><E117 19 30><E003 15><E238><E025 3>that it's been six months\r\nnow.",
                              "Je me faisais la réflexion récemment...<E145 19 64><E117 19 30><E003 15><E238><E025 3> que cela fait six mois\r\ndéjà.");
                s = s.Replace("Six months?", "Six mois ?");
                s = s.Replace("Since I was forbidden from working in court.", "Depuis qu'on m'a interdit de plaider au tribunal.");
                s = s.Replace("So I've been wondering how much longer I'm going to be\r\nbanned.",
                              "Alors je me demande combien de temps va encore durer\r\ncette interdiction.");
                s = s.Replace("Well, <E049><E003 8>that would explain why you seem rather glum.",
                              "Eh bien, <E049><E003 8>cela expliquerait pourquoi tu as l'air si morose.");
                s = s.Replace("Don't you agree, <E003 5>Hurley?", "Tu ne trouves pas, <E003 5>Sherlockinou ?");
                s = s.Replace("(Ah...<E003 8><E025 3>back to moping...)", "(Ah...<E003 8><E025 3> le revoilà dans ses pensées...)");
                s = s.Replace("What's the matter with Mr Sholmes today?", "Qu'est-ce qu'il a aujourd'hui, Mr Holmes ?");
                s = s.Replace("He seems even more down in the dumps than me.", "Il a l'air encore plus déprimé que moi.");
                s = s.Replace("I know!<E049><E003 10> <E025 2>And the Great Exhibition has opened!<E049><E003 10>\r\nYou'd think he'd be excited.",
                              "C'est vrai !<E049><E003 10> <E025 2>Et l'Exposition universelle vient d'ouvrir !<E049><E003 10>\r\nOn aurait pu penser qu'il serait surexcité.");
                s = s.Replace("Oh, <E049><E003 10>why don't we all go to see it together?",
                              "Oh, <E049><E003 10>et si on allait la visiter tous ensemble ?");
                s = s.Replace("I want to!<E049><E003 18> Of course I do!<E049><E003 12>\r\n<E025 2>But I can't!<E049><E003 12> <E025 3>...Not for the time being.",
                              "J'aimerais bien !<E049><E003 18> Bien sûr que j'aimerais !<E049><E003 12>\r\n<E025 2>Mais je ne peux point !<E049><E003 12> <E025 3>... Pas pour l'instant.");
                s = s.Replace("Why not?", "Et pourquoi donc ?");
                s = s.Replace("Why not?<E049><E003 10> <E025 1>Why not?!<E049><E003 8> <E164 19 79 1 2 8 0 1 1><E139 19><E025 1>Because!<E049><E003 12>\r\n<E025 1>I'm a great detective, after all!",
                              "Pourquoi pas ?<E049><E003 10> <E025 1>Pourquoi pas ?!<E049><E003 8> <E164 19 79 1 2 8 0 1 1><E139 19><E025 1>Parce que !<E049><E003 12>\r\n<E025 1>Je suis un grand détective, après tout !");
                s = s.Replace("(So you're embroiled in some tricky case that you can't be\r\ndistracted from?<E003 8> Is that it?)",
                              "(Alors vous êtes sur une affaire épineuse qui réclame\r\ntoute votre attention ?<E003 8> C'est bien ça ?)");
                s = s.Replace("I don't remember <E145 4 71>hearing that you're working on a case, <E049><E003 8>\r\nHurley.",
                              "Je ne me rappelle pas <E145 4 71>t'avoir entendu dire que tu enquêtais sur une affaire, <E049><E003 8>\r\nSherlockinou.");
                s = s.Replace("(I suppose I should try to find out what's going on.)",
                              "(Je suppose que je devrais essayer de comprendre ce qui se trame.)");
                return s;
            };

            // _sce02_c000_0040_eng
            entryTranslators["BB\\script\\output\\_sce02_c000_0040_eng#2"] = en => {
                string s = en;
                s = s.Replace("Well, <E049><E003 8><E025 2>I must be leaving now.",
                              "Bien, <E049><E003 8><E025 2>je dois prendre congé.");
                s = s.Replace("Yes, <E003 6>understood.<E003 12>\r\n<E025 1><E338><E341>See you later, Mr Sholmes!",
                              "Oui, <E003 6>bien compris.<E003 12>\r\n<E025 1><E338><E341>À plus tard, Mr Holmes !");
                s = s.Replace("Hah!<E049><E003 10> <E025 2>You really are a shameless liar sometimes,<E049><E003 6> <E330>my dear\r\nfellow!",
                              "Hah !<E049><E003 10> <E025 2>Vous êtes un fieffé menteur parfois,<E049><E003 6> <E330>mon cher\r\nami !");
                s = s.Replace("What?<E023><PAGE>", "Comment ?<E023><PAGE>");
                s = s.Replace("You seek to put me off my guard and follow me, <E049><E003 6>don't\r\nyou?<E049><E003 10> <E025 2>Well, <E049><E003 8>you would be wasting your time.",
                              "Vous cherchez à endormir ma méfiance pour me filer, <E049><E003 6>n'est-ce\r\npas ?<E049><E003 10> <E025 2>Eh bien, <E049><E003 8>ce serait peine perdue.");
                s = s.Replace("The thought hadn't crossed my mind!<E003 10>\r\n<E025 3><E007>(But now I'm wondering where you're going...)",
                              "L'idée ne m'avait même pas effleuré l'esprit !<E003 10>\r\n<E025 3><E007>(Mais maintenant, je me demande bien où il va...)");
                s = s.Replace("Well then, <E049><E003 8><E164 2 70 1 2 6 0 0 1><E139 2><E025 1>‘see you later’ indeed!",
                              "Dans ce cas, <E049><E003 8><E164 2 70 1 2 6 0 0 1><E139 2><E025 1>« à plus tard », en effet !");
                s = s.Replace("(Listen to him.<E003 8> He's still laughing on his way out of the\r\ndoor...)",
                              "(Écoutez-le.<E003 8> Il rigole encore en franchissant la porte...)");
                s = s.Replace("Alright then, Runo!<E049><E003 10>\r\nLet's get going!",
                              "Bon alors, Nicky !<E049><E003 10>\r\nEn route !");
                s = s.Replace("What are you wearing?", "Qu'est-ce que tu as mis sur toi ?");
                s = s.Replace("I've got changed to go to the Great Exhibition.<E049><E003 4>\r\n<E164 110 67 1 2 6 0 0 1><E139 110><E025 1>You're going to take me!",
                              "Je me suis changée pour aller à l'Exposition universelle.<E049><E003 4>\r\n<E164 110 67 1 2 6 0 0 1><E139 110><E025 1>Tu vas m'y emmener !");
                s = s.Replace("What?<E003 10> <E025 3>But, <E003 6><E025 2>but I was just about to go to the Supreme\r\nCourt...",
                              "Quoi ?<E003 10> <E025 3>Mais, <E003 6><E025 2>mais je m'apprêtais justement à aller à la Cour\r\nsuprême...");
                s = s.Replace("Oh!<E003 8> <E025 1>Well that sounds fun, too!<E049><E003 4>\r\n<E164 110 85 1 2 6 0 0 1><E204 132 16 0><E139 110><E025 1>You're going to take me there, then!",
                              "Oh !<E003 8> <E025 1>Ça a l'air amusant aussi !<E049><E003 4>\r\n<E164 110 85 1 2 6 0 0 1><E204 132 16 0><E139 110><E025 1>Alors tu m'emmènes là-bas d'abord !");
                s = s.Replace("Alright, <E003 8>fine.<E003 12>\r\n<E025 3>Just<E025 7>...<E003 10><E330><E025 3>lower that weapon, <E003 8>would you?",
                              "D'accord, <E003 8>très bien.<E003 12>\r\n<E025 3>Baisse juste<E025 7>...<E003 10><E330><E025 3> cette arme, s'il te plaît.");
                s = s.Replace("Of course!<E049><E003 10> <E025 2>And after the Supreme Court, <E049><E003 8><E025 1>then we'll go to\r\nsee the Great Exhibition!",
                              "Évidemment !<E049><E003 10> <E025 2>Et après la Cour suprême, <E049><E003 8><E025 1>on ira visiter\r\nl'Exposition universelle !");
                return s;
            };

            // _sce02_c001_0000_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>British Supreme Court, Lord Chief Justice's Office",
                              "22 octobre\r\n<CNTR><E003 5>Cour suprême britannique, Bureau du Grand Juge");
                s = s.Replace("It's been about six months now since I was last here.",
                              "Cela fait environ six mois que je ne suis pas venu ici.");
                s = s.Replace("But some things never change.<E003 8> Like the sense of\r\nforeboding I always seem to feel in this place.",
                              "Mais certaines choses ne changent jamais.<E003 8> Comme ce mauvais\r\npressentiment qui m'étreint toujours en ces lieux.");
                s = s.Replace("(It doesn't seem to be bothering Iris at all, though.<E003 10>\r\nShe's happily reading over there...)",
                              "(Ça n'a pas l'air de déranger Iris le moins du monde, par contre.<E003 10>\r\nElle lit tranquillement là-bas...)");
                s = s.Replace("Oh, <E003 6>I love this place!<E003 10><E025 1> I always find so many interesting\r\nbooks here!",
                              "Oh, <E003 6>j'adore cet endroit !<E003 10><E025 1> Il y a toujours tant de livres\r\npassionnants ici !");
                s = s.Replace("Of course.<E003 8> I was forgetting that you've been here before.",
                              "C'est vrai.<E003 8> J'oubliais que tu étais déjà venue ici.");
                s = s.Replace("(The time we came here six months ago...)", "(La fois où nous sommes venus il y a six mois...)");
                s = s.Replace("(...when Susato-san was given the news that she was to\r\nreturn to Japan.)",
                              "(... quand Susato-san a appris qu'elle devait\r\nrepartir pour le Japon.)");
                s = s.Replace("Ah.<E003 10> I understand you wish to speak with me.",
                              "Ah.<E003 10> Je crois comprendre que vous désiriez me parler.");
                s = s.Replace("L-<E003 12><E335>Lord Stronghart!<E003 15>\r\nI trust you've been <E003 6>k-<E003 10><E345>keeping well?",
                              "L-<E003 12><E335>Lord Caine !<E003 15>\r\nJ'espère que vous <E003 6>v-<E003 10><E345>vous portez bien ?");
                s = s.Replace("Let's see...<E003 8> Since you arrived and requested an audience,<E049><E003 10>\r\n<E330>it's been four hours, <E003 6>thirty-two minutes and...",
                              "Voyons voir...<E003 8> Depuis votre arrivée et votre demande d'audience,<E049><E003 10>\r\n<E330>il s'est écoulé quatre heures, <E003 6>trente-deux minutes et...");
                s = s.Replace("...twenty-six seconds.<E049><E003 12> I've kept you waiting a while.<E049><E003 10>\r\nMy apologies.",
                              "... vingt-six secondes.<E049><E003 12> Je vous ai fait attendre un peu.<E049><E003 10>\r\nVeuillez m'en excuser.");
                s = s.Replace("Oh no, <E003 10>not at all!<E003 12> I like nothing more than standing around,\r\nstaring into space.",
                              "Oh non, <E003 10>pas du tout !<E003 12> Il n'y a rien que j'aime plus que faire le piquet\r\nen regardant dans le vide.");
                s = s.Replace("...Good to know.", "... C'est bon à savoir.");
                s = s.Replace("(...Good to know that doesn't appear to bother him at all.)",
                              "(... Bon à savoir que mon ironie glisse complètement sur lui.)");
                s = s.Replace("Mael Stronghart, <E003 8>Lord Chief Justice of London.",
                              "Harry Caine, <E003 8>Grand Juge de Londres.");
                s = s.Replace("He's the man who allowed me to start practising as a\r\ndefence lawyer when I arrived in Britain as a student.",
                              "C'est lui qui m'a accordé l'autorisation d'exercer comme\r\navocat de la défense quand je suis arrivé en Grande-Bretagne.");
                s = s.Replace("You need only savour the air for a moment in this grand\r\noffice to understand his pre-eminent status.",
                              "Il suffit de respirer l'atmosphère de cet immense bureau\r\npour saisir l'écrasante autorité de son statut.");
                s = s.Replace("As you will be aware, <E049><E003 8>the Great Exhibition of London is\r\nnow underway at last.",
                              "Comme vous ne l'ignorez point, <E049><E003 8>l'Exposition universelle de Londres\r\na enfin ouvert ses portes.");
                s = s.Replace("We're extremely busy as a result.<E049><E003 10> Policing the grounds,<E049><E003 8>\r\nguarding the new technologies, <E049><E003 8>dealing with petty crime...",
                              "Nous sommes débordés de travail en conséquence.<E049><E003 10> Maintenir l'ordre sur le site,<E049><E003 8>\r\nprotéger les innovations technologiques, <E049><E003 8>gérer la petite délinquance...");
                s = s.Replace("And furthermore, <E049><E003 8><E025 2>as of next month, <E049><E003 6><E164 14 70 1 2 42 0 0 1><E139 14>we shall open the\r\nInternational Forensic Science Symposium.",
                              "Et de surcroît, <E049><E003 8><E025 2>dès le mois prochain, <E049><E003 6><E164 14 70 1 2 42 0 0 1><E139 14>nous inaugurerons le\r\nSymposium international de médecine légale.");
                s = s.Replace("Oh...<E003 10><E025 2>I've not heard about that.", "Oh...<E003 10><E025 2> Je n'en avais pas entendu parler.");
                s = s.Replace("Investigating authorities from forty countries around the\r\nglobe will be taking part.<E049><E003 8> Including from your own land.",
                              "Les autorités judiciaires de quarante nations du monde entier\r\ny participeront.<E049><E003 8> Y compris celles de votre propre pays.");
                s = s.Replace("Forensic science is the future!<E049><E003 12>\r\nThe world must embrace it!",
                              "La police scientifique est l'avenir !<E049><E003 12>\r\nLe monde entier doit l'adopter !");
                s = s.Replace("As we're the hosting nation, <E049><E003 8>I have much to do.",
                              "Puisque nous sommes le pays hôte, <E049><E003 8>la tâche m'incombe.");
                s = s.Replace("And it is my highest priority.<E049><E003 10> <E238><E025 2>If others must wait for my\r\nattention as a result, <E049><E003 8>so be it.",
                              "C'est ma priorité absolue.<E049><E003 10> <E238><E025 2>Si d'aucuns doivent attendre mon bon\r\nvouloir pour cela, <E049><E003 8>qu'il en soit ainsi.");
                s = s.Replace("(...Well, <E003 6>it's nice to know where I stand.)",
                              "(... Au moins, <E003 6>voilà qui a le mérite d'être clair.)");
                s = s.Replace("So...<E049><E003 10>you wish to consult with me?", "Alors...<E049><E003 10> vous souhaitiez me consulter ?");
                s = s.Replace("Of course, <E049><E003 8><E025 2>I can very well imagine what this is about.",
                              "Naturellement, <E049><E003 8><E025 2>je devine fort bien ce dont il retourne.");
                s = s.Replace("Thank you for agreeing to this meeting, My Lord!",
                              "Merci d'avoir accepté de me recevoir, Votre Grâce !");
                s = s.Replace("(I want to be allowed to start working as a defence lawyer\r\nagain in court.)",
                              "(Je veux qu'on m'autorise à nouveau à plaider au tribunal\r\nen tant qu'avocat de la défense.)");
                s = s.Replace("(That's what brought me here today.)", "(C'est ce qui m'amène ici aujourd'hui.)");
                s = s.Replace("(But actually, <E003 10><E025 2>there's something else playing on my mind,<E003 8>\r\nas it happens...)",
                              "(Mais en réalité, <E003 10><E025 2>il y a une autre pensée qui me préoccupe,<E003 8>\r\nà bien y réfléchir...)");
                s = s.Replace("Runo, <E049><E003 4><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>just take a deep breath and come out with it!",
                              "Nicky, <E049><E003 4><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>respire un grand coup et dis ce que tu as sur le cœur !");
                return s;
            };

            // _sce02_c001_0020_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0020_eng#4"] = en => {
                string s = en;
                s = s.Replace("Well, <E049><E003 10><E025 3><E145 14 65>I must be leaving for my next engagement.",
                              "Bien, <E049><E003 10><E025 3><E145 14 65>je dois me rendre à mon prochain engagement.");
                s = s.Replace("I'm already<E025 7>...<E003 10><E239><E025 3>eleven hours and sixteen minutes late.<E049><E003 12>\r\n<E025 2>...My colleagues may be starting to fidget.",
                              "J'ai déjà<E025 7>...<E003 10><E239><E025 3> onze heures et seize minutes de retard.<E049><E003 12>\r\n<E025 2>... Mes collègues doivent commencer à s'impatienter.");
                s = s.Replace("E-<E003 6>Eleven hours late?<E003 12>\r\n<E025 3>That's<E025 7>...<E003 8><E025 3>quite something.",
                              "O-<E003 6>Onze heures de retard ?<E003 12>\r\n<E025 3>C'est<E025 7>...<E003 8><E025 3> colossal.");
                s = s.Replace("That meeting had already started when I arrived back\r\nhere for this engagement with you.",
                              "Cette réunion avait déjà commencé lorsque je suis revenu\r\nici pour vous accorder cette entrevue.");
                s = s.Replace("So lateness was inevitable.<E049><E003 10>\r\n<E025 3>Time stops for no man.",
                              "Ce retard était donc inévitable.<E049><E003 10>\r\n<E025 3>Le temps n'attend personne.");
                s = s.Replace("(I'm sure it stopped for me during those twelve solid\r\narguments and two hundred and twenty-three reasons...)",
                              "(Je suis certain qu'il s'est arrêté pour moi pendant vos douze\r\narguments et vos deux cent vingt-trois motifs...)");
                s = s.Replace("Oh, yes!<E003 10> <E025 2>Where would I find Lord van Zieks now?",
                              "Ah, oui !<E003 10> <E025 2>Où puis-je trouver Lord Van Peers à présent ?");
                s = s.Replace("I would assume he's at his office.", "Je présume qu'il est à son bureau.");
                s = s.Replace("(Right, <E003 8><E025 2>I'll go and ask him about the attack in person.<E003 10>\r\nI want to get this straight from the horse's mouth...)",
                              "(Bien, <E003 8><E025 2>je vais aller l'interroger sur cette attaque en personne.<E003 10>\r\nJe veux entendre sa version des faits...)");
                s = s.Replace("Away with you now.<E049><E003 12> <E025 3>I'm leaving Professor Harebrayne's\r\ndefence entirely in your hands.",
                              "Allez-y maintenant.<E049><E003 12> <E025 3>Je remets la défense du Dr Samba Lonron\r\nentre vos mains.");
                s = s.Replace("Of, <E003 8><E025 1><E342>of course, yes!<E003 10>\r\nThank you very much, My Lord!",
                              "B-<E003 8><E025 1><E342>Bien entendu, oui !<E003 10>\r\nMerci infiniment, Votre Grâce !");
                return s;
            };

            // _sce02_c001_0030_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0030_eng#4"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>Prosecutor's Office",
                              "22 octobre\r\n<CNTR><E003 5>Bureau du Procureur");
                s = s.Replace("Ooh!<E049><E003 10> So this is the legendary Reaper's office?",
                              "Ooh !<E049><E003 10> Alors c'est ça, le bureau du légendaire Faucheur ?");
                s = s.Replace("Yes, <E003 6>it appears so.", "Oui, <E003 6>on dirait bien.");
                s = s.Replace("Brrr, <E049><E003 8><E025 2>it sends a chill down your spine, <E003 4>doesn't it?<E049><E003 6><E145 110 67><E139 110>\r\n<E346><E025 1>What an amazingly deathly atmosphere!",
                              "Brrr, <E049><E003 8><E025 2>ça donne des frissons dans le dos, <E003 4>non ?<E049><E003 6><E145 110 67><E139 110>\r\n<E346><E025 1>Quelle ambiance funèbre !");
                s = s.Replace("...Oh, <E003 8>is that...?", "... Oh, <E003 8>serait-ce... ?");
                s = s.Replace("(That hooded figure was so still, <E003 6>I hadn't noticed his or her\r\npresence.<E003 10> <E025 3>I wonder who it is...?)",
                              "(Cette silhouette encapuchonnée était si immobile <E003 6>que je ne l'avais\r\npas vue.<E003 10> <E025 3>Qui cela peut-il bien être... ?)");
                s = s.Replace("What are you doing here?", "Que faites-vous ici ?");
                s = s.Replace("Agh!<E003 10>", "Aaargh !<E003 10>");
                s = s.Replace("(He's as unwelcoming as I thought he'd be.)", "(Il est toujours aussi peu accueillant.)");
                s = s.Replace("(Actually, <E003 8>maybe even more so...)", "(En vérité, <E003 8>peut-être même encore plus...)");
                s = s.Replace("Oh, <E003 10><E335><E025 1>I, <E003 10><E025 3>um<E025 10>...<E003 10> <E607><E025 1>I'm glad to see you're well.",
                              "Oh, <E003 10><E335><E025 1>j-<E003 10><E025 3>je<E025 10>...<E003 10> <E607><E025 1>ravi de voir que vous allez bien.");
                s = s.Replace("...I am.", "... C'est le cas.");
                s = s.Replace("So...<E003 10><E335><E025 2>who's the person over by the wall being<E025 7>...<E003 12><E171 18 0 1 9 2><E607><E025 1>punished\r\nfor something or other?",
                              "Dites...<E003 10><E335><E025 2> qui est cette personne contre le mur ?<E025 7>...<E003 12><E171 18 0 1 9 2><E607><E025 1> Elle est punie\r\npour quelque chose ?");
                s = s.Replace("No punishment is taking place here.", "Nul châtiment n'a lieu en ces murs.");
                s = s.Replace("That's my apprentice.<E003 15>\r\n<E025 2>And he's sitting there of his own free will.",
                              "C'est mon apprenti.<E003 15>\r\n<E025 2>Et il se tient là de son plein gré.");
                s = s.Replace("I didn't know you had an apprentice.", "J'ignorais que vous aviez un apprenti.");
                s = s.Replace("(It must be the same person who was pictured in the\r\nnewspaper...)",
                              "(Ce doit être la même personne masquée que l'on voyait\r\ndans le journal...)");
                s = s.Replace("He's very able in combat.<E049><E003 10>\r\n<E025 2>...A requisite skill for anyone under my tutelage.",
                              "C'est un bretteur émérite.<E049><E003 10>\r\n<E025 2>... Une compétence requise pour quiconque étudie sous ma tutelle.");
                s = s.Replace("Are you referring to the attack on the Reaper that was\r\nreported in the papers?",
                              "Faites-vous allusion à l'agression contre le Faucheur relatée\r\ndans les journaux ?");
                s = s.Replace("The Reaper?", "Le Faucheur ?");
                s = s.Replace("I'd be interested to know the Reaper's true identity\r\nmyself.",
                              "Je serais fort curieux de connaître moi-même la véritable\r\nidentité dudit Faucheur.");
                s = s.Replace("Assuming, <E049><E003 8>that is, <E049><E003 8>such a fabled fiend genuinely inhabits\r\nour great courtrooms...",
                              "À supposer, <E049><E003 8>bien entendu, <E049><E003 8>qu'un tel démon de légende hante\r\nvraiment nos augustes prétoires...");
                return s;
            };

            // _sce02_c001_0040_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0040_eng#4"] = en => {
                string s = en;
                s = s.Replace("Ah yes, there's something I've been meaning to ask you...",
                              "Ah oui, il y a une chose que je voulais vous demander...");
                s = s.Replace("Oh! What's that?", "Oh ! Qu'est-ce donc ?");
                s = s.Replace("That Nipponese friend of yours who, six months ago...",
                              "Cet ami nippon qui vous accompagnait il y a six mois...");
                s = s.Replace("You mean Susato-san?", "Vous parlez de Susato-san ?");
                s = s.Replace("Where is she now?", "Où se trouve-t-elle à présent ?");
                s = s.Replace("She's returned to Japan. Her father was taken ill.",
                              "Elle est rentrée au Japon. Son père est tombé malade.");
                s = s.Replace("I see... A pity.", "Je vois... Quel dommage.");
                s = s.Replace("Her father is Professor Mikotoba, of course.",
                              "Son père n'est autre que le professeur Mikotoba, bien sûr.");
                s = s.Replace("He was in London, sixteen years ago...",
                              "Il a séjourné à Londres, il y a de cela seize ans...");
                s = s.Replace("A memorable man. A man of formidable intellect.",
                              "Un homme mémorable. D'une intelligence redoutable.");
                s = s.Replace("I learned a great deal from him.", "J'ai énormément appris à son contact.");
                s = s.Replace("Professor Mikotoba was your teacher, My Lord?",
                              "Le professeur Mikotoba a été votre maître, Votre Seigneurie ?");
                s = s.Replace("Indeed. He taught me forensic medicine.",
                              "En effet. Il m'a enseigné la médecine légale.");
                return s;
            };

            // _sce02_c001_0050_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0050_eng#4"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>Local Prison, Cell 11",
                              "22 octobre\r\n<CNTR><E003 5>Prison locale, Cellule 11");
                s = s.Replace("The warden said cell eleven.", "Le gardien a dit la cellule onze.");
                s = s.Replace("That's this one...", "C'est celle-ci...");
                s = s.Replace("Oh! Professor!", "Oh ! Docteur !");
                s = s.Replace("Who goes there?!", "Qui va là ?!");
                s = s.Replace("My name is Ryunosuke Naruhodo. I'm a defence lawyer.",
                              "Je m'appelle Ryunosuke Naruhodo. Je suis avocat de la défense.");
                s = s.Replace("Lord Stronghart sent me to represent you.",
                              "Lord Caine m'envoie pour assurer votre défense.");
                s = s.Replace("A defence lawyer? Send by Mael?!",
                              "Un avocat ? Envoyé par Harry ?!");
                s = s.Replace("Ah! Joy of joys! Heaven be praised!",
                              "Ah ! Joie suprême ! Loué soit le Ciel !");
                s = s.Replace("My theoretical calculations were not in vain!",
                              "Mes calculs théoriques n'étaient pas vains !");
                s = s.Replace("I am Professor Benjamin Dobinbough! Researcher of kinesis!",
                              "Je suis le docteur Samba Lonron ! Chercheur en téléportation !");
                s = s.Replace("Instantaneous super-high-voltage kinesis, to be precise!",
                              "Téléportation instantanée par supratension, pour être précis !");
                return s;
            };

            // _sce02_c001_0060_eng
            entryTranslators["BB\\script\\output\\_sce02_c001_0060_eng#2"] = en => {
                string s = en;
                s = s.Replace("So, Professor, let me just make absolutely sure I've\r\nunderstood you properly.",
                              "Docteur, permettez-moi de m'assurer que j'ai bien\r\ntout compris.");
                s = s.Replace("The huge explosion that occurred during your experiment...",
                              "La déflagration qui a eu lieu lors de votre expérience...");
                s = s.Replace("Was completely unforeseen! An inexplicable anomaly!",
                              "Était tout à fait imprévue ! Une anomalie inexplicable !");
                s = s.Replace("And the victim, Mr Asman...", "Et la victime, Mr Asman...");
                s = s.Replace("He was my investor! He financed the Crystal Tower device!",
                              "C'était mon mécène ! Il a financé la machine de la Tour de Cristal !");
                s = s.Replace("I had no reason to wish him harm!",
                              "Je n'avais aucune raison de lui vouloir du mal !");
                s = s.Replace("My machine was meant to transport him, not kill him!",
                              "Ma machine devait le téléporter, pas le tuer !");
                s = s.Replace("And yet...he was found dead inside the cage at the tower.",
                              "Et pourtant... il a été retrouvé mort dans la cage à la tour.");
                s = s.Replace("With a screwdriver lodged in his chest!",
                              "Avec un tournevis planté en plein cœur !");
                s = s.Replace("A screwdriver?! That's preposterous! I am a scientist, not an assassin!",
                              "Un tournevis ?! C'est absurde ! Je suis un scientifique, pas un assassin !");
                return s;
            };

            // _sce02_c002_0000_eng
            entryTranslators["BB\\script\\output\\_sce02_c002_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>The Great Exhibition Grounds, Foot of the Crystal Tower",
                              "22 octobre\r\n<CNTR><E003 5>Exposition universelle, Pied de la Tour de Cristal");
                s = s.Replace("Ugh... The showground is teeming with people.",
                              "Pff... Le site de l'Exposition grouille de monde.");
                s = s.Replace("And this immense tower... It's made entirely of green glass!",
                              "Et cette immense tour... Elle est entièrement faite de verre vert !");
                s = s.Replace("The Crystal Tower. Quite a sight, isn't it, mate?",
                              "La Tour de Cristal. Un sacré spectacle, pas vrai, l'ami ?");
                s = s.Replace("Gina! And Inspector Gregson!", "Gina ! Et l'inspecteur Gregson !");
                s = s.Replace("What are you doing here?", "Que faites-vous ici ?");
                s = s.Replace("Guarding the crime scene, of course.", "On garde la scène de crime, pardi.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c002_0000_eng#3"] = en => {
                string s = en;
                s = s.Replace("For what it's worth, anyway. Investigatin' is off the cards\r\nfor all of us.",
                              "Si on peut dire. L'enquête est interdite pour nous tous.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c002_0000_eng#4"] = en => {
                string s = en;
                s = s.Replace("What's that supposed to mean?", "Qu'est-ce que vous voulez dire par là ?");
                s = s.Replace("Right, well, I'll be back up top.", "Bon, allez, je remonte là-haut.");
                s = s.Replace("You hold the fort down here, Gina.", "Garde le fort ici, Gina.");
                s = s.Replace("Got it, Boss!", "Compris, Chef !");
                return s;
            };

            // _sce02_c002_0020_eng
            entryTranslators["BB\\script\\output\\_sce02_c002_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>The Great Exhibition Grounds, Experimentation Stage",
                              "22 octobre\r\n<CNTR><E003 5>Exposition universelle, Scène de l'expérience");
                s = s.Replace("So that's it, is it?", "Alors c'est ça ?");
                s = s.Replace("The super-high-voltage instantaneous kinesis machine.",
                              "La machine de téléportation instantanée par supratension.");
                s = s.Replace("Look at those giant cables and generators...",
                              "Regarde tous ces générateurs et ces câbles géants...");
                s = s.Replace("It looks like something out of a science fiction novel!",
                              "On dirait une invention tout droit sortie d'un roman de science-fiction !");
                return s;
            };

            // _sce02_c002_0030_eng
            entryTranslators["BB\\script\\output\\_sce02_c002_0030_eng#6"] = en => {
                string s = en;
                s = s.Replace("Right, are you done here, Mr Naruhodo?", "Bien, vous avez fini ici, Mr Naruhodo ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Isn't it about time you were leavin'?", "Il ne serait pas l'heure de lever le camp ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c002_0030_eng#7"] = en => {
                string s = en;
                s = s.Replace("Runo, Runo, listen!", "Nicky, Nicky, écoute !");
                s = s.Replace("What? What is it?", "Quoi ? Qu'est-ce qu'il y a ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c002_0030_eng#8"] = en => {
                string s = en;
                s = s.Replace("I've been thinking...", "Je me disais...");
                s = s.Replace("Hurley might know something, mightn't he?", "Sherlockinou doit sûrement savoir quelque chose, non ?");
                s = s.Replace("About what?", "À propos de quoi ?");
                s = s.Replace("About Mr Reaper!", "À propos de Mr le Faucheur !");
                s = s.Replace("Let's go to Madame Tusspells and ask him!", "Allons au Musée de cire de Madame Pétrie pour lui demander !");
                return s;
            };

            // _sce02_c003_0000_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>Madame Tusspells Museum of Waxworks",
                              "22 octobre\r\n<CNTR><E003 5>Musée de cire de Madame Pétrie");
                s = s.Replace("Wh-What is this place?", "Qu-Quel est cet endroit ?");
                s = s.Replace("L-Look at all those creepy wax statues...", "R-Regarde toutes ces effrayantes statues de cire...");
                s = s.Replace("They look so lifelike! It's uncanny!", "Elles ont l'air tellement vivantes ! C'en est troublant !");
                return s;
            };

            // _sce02_c003_0020_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("So I'm wondering what it was that happened to make\r\nLord van Zieks such a different person.",
                              "Alors je me demande ce qui a bien pu se produire pour rendre\r\nLord Van Peers si froid et impitoyable.");
                return s;
            };

            // _sce02_c003_0040_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0040_eng#2"] = en => {
                string s = en;
                s = s.Replace("...A wax model is a work of art.\r\nNot some tawdry object for trade.",
                              "... Une statue de cire est une œuvre d'art.\r\nEt non un vulgaire objet de marchandage.");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("Th-There you are, Mr Sholmes!", "V-Vous voilà enfin, Mr Holmes !");
                return s;
            };

            // _sce02_c003_0050_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#2"] = en => {
                string s = en;
                s = s.Replace("So, Madame Tusspells, as you've agreed to my fee...",
                              "Alors, Madame Pétrie, puisque vous avez accepté mes honoraires...");
                s = s.Replace("...you shall now have the pleasure of witnessing...",
                              "... vous allez avoir le privilège d'assister...");
                s = s.Replace("...The Great Deduction!", "... à la Grande Déduction !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#3"] = en => {
                string s = en;
                s = s.Replace("To begin with, we must ask ourselves what exactly is\r\nafoot here in this museum?",
                              "Pour commencer, demandons-nous ce qui se trame\r\nexactement en ces lieux !");
                s = s.Replace("The answer lies in that sign on the wall!", "La réponse se trouve sur cette affiche au mur !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#4"] = en => {
                string s = en;
                s = s.Replace("To begin with, we must ask ourselves what exactly is\r\nafoot here in this museum?",
                              "Pour commencer, demandons-nous ce qui se trame\r\nexactement en ces lieux !");
                s = s.Replace("The answer lies in that sign on the wall!", "La réponse se trouve sur cette affiche au mur !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#5"] = en => {
                string s = en;
                s = s.Replace("‘Waxwork for sale’?", "« Statue de cire à vendre » ?");
                s = s.Replace("Your business has hit hard times, it would seem.\r\nIn short...",
                              "Vos affaires battent de l'aile, semble-t-il.\r\nEn un mot...");
                s = s.Replace("...you've been selling off your exhibits for cash!",
                              "... vous vendez vos pièces d'exposition pour remplir vos caisses !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#6"] = en => {
                string s = en;
                s = s.Replace("Now...let us explore the next curiosity with which we are\r\npresented.",
                              "À présent... penchons-nous sur la curiosité suivante qui s'offre à nous.");
                s = s.Replace("Who is the portly gentleman lying on the floor?",
                              "Qui est ce replet personnage allongé sur le plancher ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#7"] = en => {
                string s = en;
                s = s.Replace("It would appear that you twisted this gentleman around\r\nyour little finger most effectively!",
                              "Il semblerait que vous ayez mené ce monsieur par le bout du nez avec brio !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#8"] = en => {
                string s = en;
                s = s.Replace("The question that arises then, is what has become of the\r\nwaxwork that changed hands?",
                              "La question qui se pose dès lors est : qu'est devenue la statue qui a changé de mains ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#9"] = en => {
                string s = en;
                s = s.Replace("The question that arises then, is what has become of the\r\nwaxwork that changed hands?",
                              "La question qui se pose dès lors est : qu'est devenue la statue qui a changé de mains ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#10"] = en => {
                string s = en;
                s = s.Replace("Such as is worn by policemen as a secret sign to fellow\r\nmembers of the force that a crime is in progress!",
                              "Un foulard porté par les agents en civil comme signe secret pour signaler un crime en cours !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#11"] = en => {
                string s = en;
                s = s.Replace("Next we turn our attention to the old man sat before him\r\nwith the particularly unsightly price tag!",
                              "Tournons à présent notre regard vers le vieil homme assis devant lui affublé d'une hideuse étiquette !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#12"] = en => {
                string s = en;
                s = s.Replace("‘Thruppence’...? A tragically low price, you might say.",
                              "« Trois pence »... ? Un prix tragiquement dérisoire, m'accorderez-vous.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0050_eng#13"] = en => {
                string s = en;
                s = s.Replace("Thus concludes Herlock Sholmes's great deduction...of\r\nthis horrifying puzzle!",
                              "Ainsi s'achève la grande déduction de Sherlock Holmes... sur cette énigme horrifiante !");
                return s;
            };

            // _sce02_c003_0060_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0060_eng#3"] = en => {
                string s = en;
                s = s.Replace("I see I've stunned you all into silence.", "Je vois que ma brillante logique vous a tous laissés sans voix.");
                s = s.Replace("You have, Hurley...", "C'est bien le mot, Sherlockinou...");
                return s;
            };

            // _sce02_c003_0090_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0090_eng#2"] = en => {
                string s = en;
                s = s.Replace("All sorts of people visit my museum here.\r\nMen and women, young and old.",
                              "Toutes sortes de gens visitent mon musée.\r\nDes hommes et des femmes, des jeunes et des vieux.");
                s = s.Replace("Sometimes they do strange things...", "Parfois, ils ont de bien étranges comportements...");
                return s;
            };

            // _sce02_c003_0110_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0110_eng#2"] = en => {
                string s = en;
                s = s.Replace("...Well, none of the predicted scenarios I've been\r\nanalysing involved you coming to visit me here.",
                              "... Eh bien, aucun des scénarios que j'avais modélisés\r\nne prévoyait votre visite en ces lieux.");
                return s;
            };
        }

        static void RegisterDeductionTranslators() {
            // _sce02_c003_0070_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#2"] = en => {
                string s = en;
                s = s.Replace("So, Madame Tusspells, in accordance with our\r\nagreement...", "Alors, Madame Pétrie, conformément à notre accord...");
                s = s.Replace("...you shall now have the pleasure of witnessing...", "... vous allez avoir le privilège d'assister...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#7"] = en => {
                string s = en;
                s = s.Replace("She definitely looked in this direction, it's true.", "Elle a bien regardé dans cette direction, c'est vrai.");
                s = s.Replace("But I'm not sure she'd sell any of her exhibits...", "Mais je doute qu'elle vendrait ses statues d'exposition...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#8"] = en => {
                string s = en;
                s = s.Replace("‘Dear Madame Tusspells,’", "« Chère Madame Pétrie, »");
                s = s.Replace("‘We've taken the prisoner from this room.’", "« Nous nous sommes emparés du captif de cette salle. »");
                s = s.Replace("‘The price for his safe return is two hundred pounds.’", "« La rançon pour son retour intact s'élève à deux cents livres. »");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#9"] = en => {
                string s = en;
                s = s.Replace("‘Waxwork for sale’?", "« Statue de cire à vendre » ?");
                s = s.Replace("Would anyone really buy models of mass murderers?", "Quelqu'un achèterait-il vraiment des statues de tueurs de masse ?");
                s = s.Replace("I think I'd rather buy a wax cabbage.", "J'aimerais autant acheter un chou en cire.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#10"] = en => {
                string s = en;
                s = s.Replace("It seems this well-dressed gentleman is alive after all.", "Il semble que cet élégant monsieur soit bien vivant, après tout.");
                s = s.Replace("Just not alive and kicking.", "Quoique assommé.");
                s = s.Replace("And there's two hundred pounds in his jacket...", "Et il y a deux cents livres dans sa veste...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#11"] = en => {
                string s = en;
                s = s.Replace("What's that note doing pinned on the wall there?", "Que fait ce mot épinglé là-bas au mur ?");
                s = s.Replace("Oh yes. Let's see...", "Oh oui. Voyons...");
                s = s.Replace("‘Dear Madame Tusspells...’", "« Chère Madame Pétrie... »");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#12"] = en => {
                string s = en;
                s = s.Replace("Judging by appearances...", "À en juger par les apparences...");
                s = s.Replace("...this man and the two hundred pounds are in no way\r\nrelated at all.",
                              "... cet homme et les deux cents livres n'ont aucun rapport\r\nentre eux.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#14"] = en => {
                string s = en;
                s = s.Replace("I remember it all too well myself. That feeling the day\r\nafter the elation and excitement of the Great Exhibition\r\nopening...",
                              "Je ne m'en souviens que trop bien moi-même. Cette sensation au lendemain de\r\nl'euphorie et de l'effervescence de l'inauguration de l'Exposition universelle...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#15"] = en => {
                string s = en;
                s = s.Replace("This gentleman on the floor must know the significance\r\nof the two hundred pounds!",
                              "Ce monsieur affalé sur le plancher doit connaître la signification de ces deux cents livres !");
                s = s.Replace("All we have to do is wait for him to wake up!", "Il suffit d'attendre qu'il se réveille !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#16"] = en => {
                string s = en;
                s = s.Replace("This looks very suspicious to me...", "Cela me paraît fort suspect...");
                s = s.Replace("And that's why I'm sure this is the answer we've been\r\nlooking for!",
                              "Et c'est pourquoi je suis certain que c'est la réponse que nous cherchions !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#17"] = en => {
                string s = en;
                s = s.Replace("The significance of the two hundred pounds is revealed\r\nby that public notice!",
                              "Le mystère des deux cents livres est révélé par cette affiche publique !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#18"] = en => {
                string s = en;
                s = s.Replace("The significance of the two hundred pounds is revealed\r\nby that ransom note!",
                              "Le mystère des deux cents livres est révélé par cette demande de rançon !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#23"] = en => {
                string s = en;
                s = s.Replace("So if the waxwork was kidnapped, where does that leave\r\nus in terms of who this man is?",
                              "Alors si la statue de cire a été kidnappée, où cela nous mène-t-il pour identifier cet homme ?");
                s = s.Replace("Was he attacked by Madame Tusspells?", "Aurait-il été attaqué par Madame Pétrie ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#24"] = en => {
                string s = en;
                s = s.Replace("This is just Madame Tusspells's right hand, isn't it?", "C'est bien la main droite de Madame Pétrie, n'est-ce pas ?");
                s = s.Replace("Yes, it must be. I can clearly see the delicate fingers.", "Oui, sans doute. On aperçoit nettement ses doigts délicats.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#25"] = en => entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#24"](en);
            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#26"] = en => entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#24"](en);

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#28"] = en => {
                string s = en;
                s = s.Replace("So she was prepared to pay all that money to get her\r\nwaxwork back again?",
                              "Elle était donc prête à payer toute cette somme pour récupérer sa statue ?");
                s = s.Replace("It really must be a masterpiece.", "Ce doit véritablement être un chef-d'œuvre.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#29"] = en => {
                string s = en;
                s = s.Replace("Madame Tusspells has very long hair, doesn't she?", "Madame Pétrie a de très longs cheveux, n'est-ce pas ?");
                s = s.Replace("Yes, but you couldn't tell looking at her from the front.", "Oui, mais on ne pouvait pas le deviner en la voyant de face.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#30"] = en => {
                string s = en;
                s = s.Replace("It must have been a considerable blow to have knocked\r\nthe man unconscious.",
                              "Ce dut être un coup formidable pour assommer cet homme.");
                s = s.Replace("Yes, he looks completely out cold.", "Oui, il a l'air complètement sonné.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#31"] = en => {
                string s = en;
                s = s.Replace("If this man is the one responsible for taking the\r\nwaxwork...",
                              "Si cet homme est bien le responsable du vol de la statue...");
                s = s.Replace("...then perhaps the sight of Madame Tusspells startled him!",
                              "... la vue de Madame Pétrie l'aura sans doute pris de court !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#32"] = en => {
                string s = en;
                s = s.Replace("Madame Tusspells's hair is very neatly braided...", "La chevelure de Madame Pétrie est fort soigneusement tressée...");
                s = s.Replace("...creating an effective whip that she used to strike him!",
                              "... formant un redoutable fouet dont elle s'est servie pour le frapper !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#33"] = en => {
                string s = en;
                s = s.Replace("At first glance, Madame Tusspells's hands look slender\r\nand delicate.",
                              "À première vue, les mains de Madame Pétrie paraissent graciles et délicates.");
                s = s.Replace("But obviously all that wax moulding has made them rock-hard!",
                              "Mais à force de pétrir la cire, elles sont sans doute dures comme la pierre !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#34"] = en => {
                string s = en;
                s = s.Replace("What dealt the man such a shocking blow was of course...\r\nthe two hundred pounds!",
                              "Ce qui a asséné un coup si violent à cet homme, c'est bien sûr...\r\nles deux cents livres !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0070_eng#35"] = en => {
                string s = en;
                s = s.Replace("What dealt the man such a shocking blow was of course...\r\nthe waxwork hand!",
                              "Ce qui a asséné un coup si violent à cet homme, c'est bien sûr...\r\nla main de cire !");
                return s;
            };

            // _sce02_c003_0080_eng
            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#2"] = en => {
                string s = en;
                s = s.Replace("The question that arises then, is what has become of the\r\nwaxwork that changed hands?",
                              "La question qui se pose dès lors est : qu'est devenue la statue qui a changé de mains ?");
                s = s.Replace("Let's take a closer look...", "Regardons de plus près...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#7"] = en => {
                string s = en;
                s = s.Replace("According to Mr Sholmes...", "D'après Mr Holmes...");
                s = s.Replace("...the yellow neckerchief is a sign to other policemen that\r\nsomeone is on duty.",
                              "... le foulard jaune est un signe de ralliement entre policiers pour indiquer qu'on est en service.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#8"] = en => {
                string s = en;
                s = s.Replace("What the...?", "Mais qu'est-ce que... ?");
                s = s.Replace("The man has a stub sticking out of his shoulder where his\r\narm should be!",
                              "Cet homme a un moignon qui dépasse de l'épaule à la place du bras !");
                s = s.Replace("And a hole in his head!", "Et un trou dans la tête !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#9"] = en => {
                string s = en;
                s = s.Replace("A secret scarf sign to warn other agents of an ongoing\r\ncrime...",
                              "Un foulard secret pour avertir les collègues d'un crime en cours...");
                s = s.Replace("I know! It sounds so thrilling, doesn't it?", "Je sais ! C'est palpitant, n'est-ce pas ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#10"] = en => {
                string s = en;
                s = s.Replace("I've seen hats like this in Japan as well.", "J'ai vu des casquettes comme ça au Japon aussi.");
                s = s.Replace("They're called flat caps, aren't they?", "On appelle ça des casquettes plates, non ?");
                s = s.Replace("Yes, often worn by working-class men.", "Oui, souvent portées par les ouvriers.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#11"] = en => {
                string s = en;
                s = s.Replace("According to Mr Sholmes, this young gentleman is\r\nactually a policeman in plain clothes.",
                              "D'après Mr Holmes, ce jeune homme serait un policier en civil.");
                s = s.Replace("Do you think so?", "Vous y croyez ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#13"] = en => {
                string s = en;
                s = s.Replace("Once you know that the scarf is a secret signal used by\r\ndetectives, the answer is obvious!",
                              "Une fois qu'on sait que le foulard est un code secret entre détectives, la conclusion saute aux yeux !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#14"] = en => {
                string s = en;
                s = s.Replace("Just look at the smart flat cap the man is wearing.", "Regardez cette élégante casquette plate qu'il porte.");
                s = s.Replace("It's apparent, then...", "Il est évident...");
                s = s.Replace("...that he's an undercover detective!", "... qu'il s'agit d'un détective en civil !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#15"] = en => {
                string s = en;
                s = s.Replace("Who is this fellow? To find the answer, we need only\r\nobserve...his neckerchief.",
                              "Qui est ce bonhomme ? Pour le savoir, il nous suffit d'observer... son foulard.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#16"] = en => {
                string s = en;
                s = s.Replace("Who is this fellow? To find the answer, we need only\r\nobserve...his shoulder stub.",
                              "Qui est ce bonhomme ? Pour le savoir, il nous suffit d'observer... son moignon d'épaule.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#21"] = en => {
                string s = en;
                s = s.Replace("A killer policeman...called Ottermole, was it?", "Un policier assassin... nommé Ottermole, c'est ça ?");
                s = s.Replace("Was he well known?", "Était-il célèbre ?");
                s = s.Replace("It was all over the papers a few years back.", "Toute la presse en parlait il y a quelques années.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#22"] = en => {
                string s = en;
                s = s.Replace("L-Look at this!", "R-Regardez ça !");
                s = s.Replace("The old man's tapping his foot like crazy!", "Le vieil homme bat la mesure comme un fou avec son pied !");
                s = s.Replace("He seems to be fast asleep, though.", "Pourtant il a l'air profondément endormi.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#23"] = en => {
                string s = en;
                s = s.Replace("Three pence? It's a far cry from two hundred pounds,\r\nisn't it?", "Trois pence ? On est loin des deux cents livres, n'est-ce pas ?");
                s = s.Replace("For thruppence, you could barely buy a loaf of bread.", "Pour trois pence, on a tout juste une miche de pain.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#24"] = en => {
                string s = en;
                s = s.Replace("I, I don't believe it!", "J-Je n'en crois pas mes yeux !");
                s = s.Replace("It's the secret sign that lets other detectives know some\r\ncriminal deed is underway!",
                              "C'est le signal secret qui avertit les autres policiers qu'un forfait est en train d'être commis !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#25"] = en => {
                string s = en;
                s = s.Replace("If we just poured a little bit of molten wax on him, we'd\r\nsoon find out if he was real or not!",
                              "Si on versait un peu de cire chaude sur lui, on saurait vite s'il est en chair et en os ou pas !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#26"] = en => {
                string s = en;
                s = s.Replace("You only have to look at this price tag to know exactly\r\nwhat this old man really is!",
                              "Il suffit de regarder cette étiquette de prix pour comprendre ce qu'est vraiment ce vieillard !");
                s = s.Replace("He's a waxwork!", "C'est une statue de cire !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#27"] = en => {
                string s = en;
                s = s.Replace("According to you, Mr Sholmes, a scarf like this is a secret\r\nsign used between undercover detectives.",
                              "D'après vous, Mr Holmes, un tel foulard est un code secret échangé entre détectives infiltrés.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#28"] = en => {
                string s = en;
                s = s.Replace("The telltale sign that instantly proves whether or not this\r\nold man is a waxwork is the price tag!",
                              "L'indice flagrant qui prouve immédiatement si ce vieil homme est une statue de cire est l'étiquette de prix !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce02_c003_0080_eng#29"] = en => {
                string s = en;
                s = s.Replace("The telltale sign that instantly proves whether or not this\r\nold man is a waxwork is the tapping foot!",
                              "L'indice flagrant qui prouve immédiatement si ce vieil homme est une statue de cire est son pied qui bat la mesure !");
                return s;
            };
        }
    }
}
