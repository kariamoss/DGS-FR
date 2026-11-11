using System;
using System.IO;
using System.Text;

class MakeAct6Part4B {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart4_B() {");

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

        // [151] KEY:BB\script\output\_sce02_evidence_eng#37
        add(@"BB\script\output\_sce02_evidence_eng#37", new string[,] {
            { "Look, Mr Naruhodo...", "Regardez, Monsieur Naruhodo..." },
            { "What is it?", "Qu'y a-t-il ?" },
            { "On the bellows just here...there seem to be some very\r\ndark red stains.", "Sur le soufflet juste ici... il semble y avoir des taches\r\nrouge très sombre." },
            { "Yes, you're right...", "Oui, vous avez raison..." },
            { "(It looks like blood actually...)", "(On dirait bien du sang, en vérité...)" },
            { "Oh, oh my...", "Oh, grand dieu..." },
            { "I'm, I'm sure it's not what you're thinking!\r\nHa ha ha...ha.", "Je, je suis certain que ce n'est pas ce que vous croyez !\r\nHa ha ha... ha." }
        });

        // [152] KEY:BB\script\output\_sce02_evidence_eng#38
        add(@"BB\script\output\_sce02_evidence_eng#38", new string[,] {
            { "The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier." }
        });

        // [153] KEY:BB\script\output\_sce02_evidence_eng#39
        add(@"BB\script\output\_sce02_evidence_eng#39", new string[,] {
            { "The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier." }
        });

        // [154] KEY:BB\script\output\_sce02_evidence_eng#40
        add(@"BB\script\output\_sce02_evidence_eng#40", new string[,] {
            { "The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier." }
        });

        // [155] KEY:BB\script\output\_sce02_evidence_eng#42
        add(@"BB\script\output\_sce02_evidence_eng#42", new string[,] {
            { "Oh look! The cover came open!", "Oh, regardez ! Le couvercle s'est ouvert !" },
            { "Yes, now...there should be a glass plate inside.", "Oui, à présent... il devrait y avoir une plaque de verre à l'intérieur." },
            { "You have to change the plate with each new photograph\r\nyou want to take, you see.", "Il faut changer la plaque à chaque nouvelle photographie\r\nque l'on veut prendre, voyez-vous." },
            { "There is no plate.\r\nIt's been removed.", "Il n'y a pas de plaque.\r\nElle a été retirée." },
            { "Ah, what a pity.\r\nBut I suppose if you think about it...", "Ah, quel dommage.\r\nMais à la réflexion..." },
            { "...this wouldn't be the actual camera that was used at the\r\ntime, just like the waxwork isn't the actual person.", "...ce ne doit pas être le véritable appareil utilisé à l'époque,\r\ntout comme la statue de cire n'est pas la personne vivante." },
            { "So we'd never have found a photographic print of the\r\nexecuted convict coming back to life anyway.", "Nous n'aurions donc de toute façon jamais trouvé de cliché\r\ndu condamné exécuté revenant à la vie." },
            { "Oh... Yes, you're quite right of course...", "Oh... Oui, vous avez tout à fait raison, bien sûr..." },
            { "(Poor Susato-san. She looks devastated.)", "(Pauvre Mademoiselle Susato. Elle a l'air dévastée.)" }
        });

        // [156] KEY:BB\script\output\_sce02_evidence_eng#43
        add(@"BB\script\output\_sce02_evidence_eng#43", new string[,] {
            { "This is where the photographic plate goes, I think, isn't it?", "C'est ici que vient la plaque photographique, si je ne m'abuse ?" },
            { "Yes, that's right. Isn't it incredible to think that this is the\r\nactual camera Mr Drebber used that night?", "Oui, c'est exact. N'est-ce pas incroyable de songer que c'est le\r\nvéritable appareil que M. Drebber a utilisé cette nuit-là ?" },
            { "I certainly never imagined a piece of evidence would be\r\non display in Madame Tusspells!", "Je n'aurais jamais imaginé qu'une pièce à conviction se trouverait\r\nexposée chez Madame Pétrie !" },
            { "She's very keen on everything being as true to life as\r\npossible though, isn't she?", "Elle tient tellement à ce que tout soit aussi fidèle que\r\npossible à la réalité, n'est-ce pas ?" }
        });

        // [157] KEY:BB\script\output\_sce02_evidence_eng#44
        add(@"BB\script\output\_sce02_evidence_eng#44", new string[,] {
            { "There's a little metal plaque here, look.", "Il y a une petite plaque de métal ici, regardez." },
            { "‘Fostering burgeoning talent for the future of scientific\r\ndiscovery’.", "« Encourager les jeunes talents pour l'avenir de la découverte\r\nscientifique »." },
            { "...It seems rather ironic, doesn't it?", "...C'est plutôt ironique, non ?" },
            { "But clearly Mr Drebber really was a very talented\r\nscientist.", "Mais de toute évidence, M. Drebber était un scientifique\r\nvéritablement doué." }
        });

        // [158] KEY:BB\script\output\_sce02_evidence_eng#45
        add(@"BB\script\output\_sce02_evidence_eng#45", new string[,] {
            { "This lock does look very strong, doesn't it?", "Ce verrou a l'air très solide, pas vrai ?" },
            { "There's definitely no way you could remove the mask\r\nyourself if it was put on you.", "Il est absolument impossible d'enlever le masque soi-même\r\nsi on vous le mettait sur la tête." },
            { "What a terrible way to treat someone, even a convicted\r\ncriminal.", "Quelle manière atroce de traiter quelqu'un, même un criminel\r\ncondamné." },
            { "I know. It's starting to make me livid, actually.", "Je sais. Cela commence vraiment à me mettre hors de moi." },
            { "Mr Naruhodo, please...", "Monsieur Naruhodo, je vous en prie..." },
            { "I mean, just think about it!", "Non mais pensez-y un instant !" },
            { "Imagine if you had an itch on your cheek all of a sudden!\r\nYou'd be utterly helpless!", "Imaginez que votre joue vous démange tout d'un coup !\r\nVous seriez totalement démuni !" },
            { "Well, yes, that's true.", "Eh bien, oui, c'est vrai." },
            { "But I'm not sure...that warrants quite so much anger.", "Mais je ne suis pas sûre... que cela justifie une telle colère." },
            { "Oh...right...\r\nSorry.", "Oh... évidemment...\r\nDésolé." }
        });

        // [159] KEY:BB\script\output\_macro02_eng#13
        add(@"BB\script\output\_macro02_eng#13", new string[,] {
            { "Guilty!", "Coupable !" },
            { "Mr Albert Harebrayne, in accordance with the findings of\r\nthis court, I pronounce you...", "Professeur Samba Lonron, conformément aux conclusions de\r\ncette cour, je vous déclare..." },
            { "I applaud the jurors for doing their civic duty and for\r\nfinding a swift resolution to this matter.", "Je félicite les jurés d'avoir accompli leur devoir civique et d'avoir\r\ntrouvé une issue rapide à cette affaire." },
            { "That is all. Court is adjourned!", "C'est tout. La séance est levée !" }
        });

        // [160] KEY:BB\script\output\_macro02_eng#14
        add(@"BB\script\output\_macro02_eng#14", new string[,] {
            { "That last statement would seem to be at odds somehow\r\nwith the evidence!", "Cette dernière déclaration semble être en contradiction flagrante\r\navec les preuves !" },
            { "It is your task, Counsel, to explain the ‘somehows’ to the\r\ncourt, not the other way around.", "C'est votre rôle, Maître, d'expliquer ces contradictions à la\r\ncour, et non l'inverse." }
        });

        // [161] KEY:BB\script\output\_macro02_eng#15
        add(@"BB\script\output\_macro02_eng#15", new string[,] {
            { "...It just seems to jar, though.\r\nDon't you think?", "...Cela semble pourtant discordant.\r\nVous ne trouvez pas ?" },
            { "What I think, is that this whole exchange has been\r\nextremely jarring, yes.", "Ce que je trouve, c'est que tout cet échange a été\r\nparticulièrement discordant, oui." },
            { "(Perhaps I need to reconsider this...)", "(Je devrais sans doute revoir ma copie...)" }
        });

        // [162] KEY:BB\script\output\_macro02_eng#16
        add(@"BB\script\output\_macro02_eng#16", new string[,] {
            { "The defence would have to object to that last statement,\r\nMy Lord!", "La défense doit s'opposer formellement à cette dernière déposition,\r\nVotre Honneur !" },
            { "And I would have to overrule your objection, Counsel.", "Et je me vois contraint de rejeter votre objection, Maître." }
        });

        // [163] KEY:BB\script\output\_macro02_eng#17
        add(@"BB\script\output\_macro02_eng#17", new string[,] {
            { "The defence...would have to accept the penalty given.", "La défense... se doit d'accepter la sanction infligée." },
            { "Glad to hear it.\r\nAnd you would also have to think again, hm?", "Ravi de l'entendre.\r\nEt vous feriez bien d'y réfléchir à deux fois, n'est-ce pas ?" }
        });

        // [164] KEY:BB\script\output\_macro02_eng#18
        add(@"BB\script\output\_macro02_eng#18", new string[,] {
            { "Surely something about that last statement seems odd,\r\ndoesn't it?", "Il y a assurément quelque chose qui cloche dans cette déclaration,\r\nvous ne trouvez pas ?" },
            { "Would you care to mull over precisely what you find odd\r\nabout it on your return journey to Japan?", "Souhaitez-vous méditer sur ce qui cloche exactement\r\nlors de votre voyage de retour vers le Japon ?" }
        });

        // [165] KEY:BB\script\output\_macro02_eng#19
        add(@"BB\script\output\_macro02_eng#19", new string[,] {
            { "...I wouldn't be back to give the court an answer for about\r\nfour months, though.", "...Mais je mettrais bien quatre mois avant de pouvoir apporter\r\nune réponse à la cour." },
            { "Rest assured, we should be happy to carry proceedings\r\nforward in your absence, Counsel.", "Soyez rassuré, nous nous ferons un plaisir de poursuivre les débats\r\nen votre absence, Maître." },
            { "(He sounds serious! I have to prove my worth before he\r\nreally does send me back home!)", "(Il a l'air sérieux ! Je dois faire mes preuves avant qu'il ne me\r\nrenvoie pour de bon au Japon !)" }
        });

        // [166] KEY:BB\script\output\_macro02_eng#20
        add(@"BB\script\output\_macro02_eng#20", new string[,] {
            { "Those two statements are fundamentally at odds with one\r\nanother!", "Ces deux déclarations sont en totale contradiction l'une avec\r\nl'autre !" },
            { "Well, Mr Foreman?", "Alors, Monsieur le Premier juré ?" },
            { "...Ah, there's to be a new Herlock Sholmes adventure\r\npublished next month, by the looks...", "...Ah, on dirait bien qu'une nouvelle aventure de Sherlock Holmes\r\nva être publiée le mois prochain..." },
            { "My, My Lord!\r\nThe foreman of the jury isn't listening!", "V-Votre Honneur !\r\nLe premier juré n'écoute pas un traître mot !" },
            { "Is that so? Well, I shall have to reserve myself a copy at\r\nthe local newsagent, in that case.", "Vraiment ? Eh bien, il faudra que j'en réserve un exemplaire chez\r\nle marchand de journaux, dans ce cas." },
            { "Miss Susato, no one is listening to what I'm saying...", "Mademoiselle Susato, personne n'écoute ce que je raconte..." },
            { "Perhaps this would be a good opportunity to have a\r\nrethink then, Mr Naruhodo?", "Peut-être est-ce une bonne occasion pour vous de réfléchir\r\nà nouveau, Monsieur Naruhodo ?" },
            { "Fear not, my learned friend.\r\nI heard every sorry word.", "Ne crains rien, mon docte confrère.\r\nJ'ai entendu le moindre de tes piètres propos." }
        });

        // [167] KEY:BB\script\output\_macro02_eng#21
        add(@"BB\script\output\_macro02_eng#21", new string[,] {
            { "(Ugh... It sounds like I'm on the wrong track here.\r\nI'd better think again.)", "(Argh... On dirait que je fais fausse route.\r\nJe ferais mieux de revoir ma copie.)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part4_B.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part4_B written.");
    }
}
