using System;
using System.IO;
using System.Text;

class MakeAct6Part4A {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart4_A() {");

        Action<string, string[,]> add = (key, reps) => {
            sb.AppendLine("            entryTranslators[@\"" + key + "\"] = (en) => {");
            sb.AppendLine("                string s = en;");
            for (int i = 0; i < reps.GetLength(0); i++) {
                string enStr = reps[i, 0].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
                string frStr = reps[i, 1].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
                sb.AppendLine("                s = s.Replace(\"" + enStr + "\", \"" + frStr + "\");");
            }
            sb.AppendLine("                return s;");
            sb.AppendLine("            };");
            sb.AppendLine();
        };

        // [136] KEY:BB\script\output\_sce02_evidence_eng#17
        add(@"BB\script\output\_sce02_evidence_eng#17", new string[,] {
            { "Ah, there's some sort of lever here...", "Ah, il y a une sorte de levier par ici..." },
            { "What the–\r\nWhat is this?!", "Mais qu'est-ce que–\r\nQu'est-ce que c'est que ça ?!" },
            { "It, it looks like a cross between a bow and a gun!", "On, on dirait un croisement entre un arc et un fusil !" },
            { "(I think it's probably used for the same thing, too.)", "(Et je parie que ça sert probablement au même dessein.)" }
        });

        // [137] KEY:BB\script\output\_sce02_evidence_eng#19
        add(@"BB\script\output\_sce02_evidence_eng#19", new string[,] {
            { "This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose." },
            { "So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique." },
            { "This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois." },
            { "(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)" }
        });

        // [138] KEY:BB\script\output\_sce02_evidence_eng#20
        add(@"BB\script\output\_sce02_evidence_eng#20", new string[,] {
            { "This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose." },
            { "So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique." },
            { "This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois." },
            { "(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)" }
        });

        // [139] KEY:BB\script\output\_sce02_evidence_eng#21
        add(@"BB\script\output\_sce02_evidence_eng#21", new string[,] {
            { "It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension." },
            { "You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors." },
            { "In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais." },
            { "Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition." }
        });

        // [140] KEY:BB\script\output\_sce02_evidence_eng#22
        add(@"BB\script\output\_sce02_evidence_eng#22", new string[,] {
            { "It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension." },
            { "You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors." },
            { "In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais." },
            { "Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition." }
        });

        // [141] KEY:BB\script\output\_sce02_evidence_eng#24
        add(@"BB\script\output\_sce02_evidence_eng#24", new string[,] {
            { "I've seen this unusually shaped handle before.", "J'ai déjà vu ce manche à la forme inhabituelle auparavant." },
            { "It's the same screwdriver that was lodged in the grille on\r\nthe floor of the kinesis machine.", "C'est le même tournevis qui était coincé dans la grille au sol\r\nde la machine cinétique." },
            { "(Which could be important information, so I should\r\ndefinitely make a note of it.)", "(Ce qui pourrait être un indice capital, je devrais\r\nsans faute le noter.)" },
            { "The details of the screwdriver\r\nhave been updated in the Court Record.", "Les détails du tournevis\r\nont été mis à jour dans le dossier." }
        });

        // [142] KEY:BB\script\output\_sce02_evidence_eng#25
        add(@"BB\script\output\_sce02_evidence_eng#25", new string[,] {
            { "There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche..." },
            { "This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique." },
            { "It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule." },
            { "(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)" }
        });

        // [143] KEY:BB\script\output\_sce02_evidence_eng#26
        add(@"BB\script\output\_sce02_evidence_eng#26", new string[,] {
            { "There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche..." },
            { "This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique." },
            { "It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule." },
            { "(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)" }
        });

        // [144] KEY:BB\script\output\_sce02_evidence_eng#28
        add(@"BB\script\output\_sce02_evidence_eng#28", new string[,] {
            { "This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute." },
            { "This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime..." }
        });

        // [145] KEY:BB\script\output\_sce02_evidence_eng#29
        add(@"BB\script\output\_sce02_evidence_eng#29", new string[,] {
            { "This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute." },
            { "This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime..." }
        });

        // [146] KEY:BB\script\output\_sce02_evidence_eng#30
        add(@"BB\script\output\_sce02_evidence_eng#30", new string[,] {
            { "The front of the card doesn't give much away, does it?\r\n(PROVISIONAL)", "Le recto de la carte ne révèle pas grand-chose, pas vrai ?" },
            { "No, not at all.\r\n(PROVISIONAL)", "Non, pas du tout." }
        });

        // [147] KEY:BB\script\output\_sce02_evidence_eng#31
        add(@"BB\script\output\_sce02_evidence_eng#31", new string[,] {
            { "This dark smudge here...", "Cette tache sombre ici..." },
            { "I think perhaps it's machine oil.", "Je pense que c'est sans doute de l'huile pour machine." },
            { "Ah, yes, possibly. Professor Harebrayne mentioned\r\nsomething about the oil Mr Drebber uses, didn't he?", "Ah, oui, possible. Le professeur Lonron a mentionné\r\nquelque chose à propos de l'huile employée par M. Drebber, n'est-ce pas ?" },
            { "He said it was specially imported very high-quality oil\r\nthat's impossible to obtain in Britain.", "Il a dit que c'était une huile importée de très haute qualité,\r\nintrouvable en Grande-Bretagne." },
            { "Yes, that's right.\r\nBut more importantly...", "Oui, c'est exact.\r\nMais plus important encore..." },
            { "...that it's more fragrant than the finest perfume!\r\nSo...excuse me a moment...", "...qu'elle est plus parfumée que le plus fin des parfums !\r\nAlors... excusez-moi un instant..." },
            { "Oh, it doesn't appear to have any scent at all.", "Oh, elle ne semble dégager absolument aucune odeur." },
            { "Don't worry, I, I expect that's just because there's such a\r\ntiny amount on here.", "Ne vous en faites pas, j... j'imagine que c'est parce qu'il n'y en a qu'une\r\nquantité infime ici." },
            { "The details of Drebber's card\r\nhave been updated in the Court Record.", "Les détails de la carte de Drebber\r\nont été mis à jour dans le dossier." }
        });

        // [148] KEY:BB\script\output\_sce02_evidence_eng#33
        add(@"BB\script\output\_sce02_evidence_eng#33", new string[,] {
            { "Ah! Look here, Miss Susato...", "Ah ! Regardez ici, Mademoiselle Susato..." },
            { "Oh yes, the wood's cracked and broken a little.\r\nI suppose because it fell from such a height?", "Oh oui, le bois est fendu et un peu cassé.\r\nSans doute parce qu'elle est tombée de si haut ?" },
            { "Yes, from the height at which the balloon was flying,\r\ndown into the Crystal Tower below.", "Oui, depuis l'altitude à laquelle le ballon volait,\r\njusque dans la Tour de Cristal en dessous." },
            { "A fall of about thirty feet.\r\n...Or nine metres.", "Une chute d'une dizaine de mètres.\r\n...Soit une trentaine de pieds." },
            { "Leaving the man inside tragically dead.", "Laissant l'homme à l'intérieur tragiquement mort." },
            { "The details of the wooden birdcage\r\nhave been updated in the Court Record.", "Les détails de la cage en bois\r\nont été mis à jour dans le dossier." }
        });

        // [149] KEY:BB\script\output\_sce02_evidence_eng#35
        add(@"BB\script\output\_sce02_evidence_eng#35", new string[,] {
            { "This piece of glass is almost as thick as it is wide.", "Ce morceau de verre est presque aussi épais que large." },
            { "Yes, I've never seen anything like it.", "Oui, je n'ai jamais rien vu de semblable." },
            { "If you were to compare it to a human, only Mr Sholmes\r\nhas such thick skin.", "Si on devait le comparer à un être humain, seul M. Holmes\r\na une carapace aussi épaisse." },
            { "There's really no need for such a comparison,\r\nMr Naruhodo, as you well know.", "Une telle comparaison n'était vraiment pas nécessaire,\r\nMonsieur Naruhodo, comme vous le savez bien." },
            { "...Anyway, it can only be from the Crystal Tower, surely?", "...Quoi qu'il en soit, il ne peut venir que de la Tour de Cristal, sûrement ?" },
            { "Yes, I think so, too. It was probably made especially to\r\nmeet the demands of that great structure.", "Oui, je le pense aussi. Il a sans doute été façonné sur mesure pour\r\nrépondre aux contraintes de cette formidable structure." }
        });

        // [150] KEY:BB\script\output\_sce02_evidence_eng#36
        add(@"BB\script\output\_sce02_evidence_eng#36", new string[,] {
            { "What a wonderful machine!", "Quelle merveilleuse machine !" },
            { "You really love contraptions like this, don't you?", "Vous aimez vraiment ce genre d'engins, n'est-ce pas ?" },
            { "Oh yes! Anything mechanical I find absolutely irresistible.", "Oh oui ! Tout ce qui est mécanique m'est absolument irrésistible." },
            { "Almost irresistible, surely?", "Presque irrésistible, sans doute ?" },
            { "Well, whenever I see a pocket watch, for example, I can't\r\nhelp myself. I simply have to take it apart.", "Eh bien, chaque fois que je vois une montre à gousset, par exemple, je ne peux pas\r\nm'en empêcher. Il faut absolument que je la démonte." },
            { "That's...worrying.", "C'est... inquiétant." },
            { "Yes, Father tells the time by the rumblings of his stomach\r\nnow. He's given up having a watch.", "Oui, Père lit l'heure aux gargouillis de son ventre\r\nà présent. Il a renoncé à porter une montre." },
            { "(Poor Professor Mikotoba...)", "(Pauvre professeur Mikotoba...)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part4_A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part4_A written.");
    }
}
