using System;
using System.IO;
using System.Text;

class MakeAct6Part4C {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart4_C() {");

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

        // [168] KEY:BB\script\output\_macro02_eng#22
        add(@"BB\script\output\_macro02_eng#22", new string[,] {
            { "These are the Scales of Justice.", "Voici la Balance de la Justice." },
            { "They're a symbol of the defence, aren't they?", "C'est un symbole de la défense, n'est-ce pas ?" },
            { "Yes, that's right.", "Oui, c'est exact." },
            { "The scales are a symbol of fairness, to show that all\r\nare treated equally in the eyes of the law.", "La balance est un symbole d'équité, pour montrer que tous\r\nsont traités sur un pied d'égalité aux yeux de la loi." },
            { "And they're a warning to those who enter the courtroom\r\nwithout an impartial mind.", "Et c'est un avertissement pour tous ceux qui pénètrent dans le tribunal\r\nsans un esprit impartial." },
            { "But if they're the mark of the defence...", "Mais si c'est la marque de la défense..." },
            { "...it would be more auspicious if they were weighing\r\nmore heavily on the ‘not guilty’ side, I think.", "...ce serait plus de bon augure si elle penchait\r\nun peu plus lourdement du côté « non coupable », je trouve." },
            { "Very impartial, I'm sure.", "Très impartial, n'en doutons point." }
        });

        // [169] KEY:BB\script\output\_macro02_eng#23
        add(@"BB\script\output\_macro02_eng#23", new string[,] {
            { "The lawyer's name is embroidered on the inside\r\nhere, look.", "Le nom de l'avocat est brodé à l'intérieur\r\nici, regardez." },
            { "‘Kazuma Asogi’...This was his band, of course.", "« Kazuma Asogi »... C'était son brassard, bien sûr." },
            { "He had his heart set on this study tour in Great Britain.", "Il tenait tant à cette mission d'études en Grande-Bretagne." },
            { "I'm sure he would have found the truth he longed\r\nfor here.", "Je suis certain qu'il aurait trouvé la vérité à laquelle il aspirait\r\nici." },
            { "(...But he lost his life before he even had the chance\r\nto see the place.)", "(...Mais il a perdu la vie avant même d'avoir pu\r\nvoir ce pays.)" },
            { "I have such a strong sense of his hopes and dreams\r\nwhen I look at this armband, though.", "Pourtant, je ressens si intensément tous ses espoirs et ses idéaux\r\nquand je regarde ce brassard." }
        });

        // [170] KEY:BB\script\output\_macro02_eng#26
        add(@"BB\script\output\_macro02_eng#26", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [171] KEY:BB\script\output\_macro02_eng#27
        add(@"BB\script\output\_macro02_eng#27", new string[,] {
            { "I can't find anything out of place.", "Je ne trouve rien d'anormal." }
        });

        // [172] KEY:BB\script\output\_macro02_eng#35
        add(@"BB\script\output\_macro02_eng#35", new string[,] {
            { "If I may, Mr Lune!", "Si vous me le permettez, Monsieur Lune !" },
            { "Ah! You like one of a balloons, eh?\r\nPrego, prego. Ten shillings for one!", "Ah ! Vous voulez un de mes ballons, hein ?\r\nPrego, prego. Dix shillings pièce !" },
            { "No no, I was going to ask you if that last statement\r\nbothered you for some reason...", "Non non, j'allais vous demander si cette dernière déposition\r\nvous dérangeait pour une raison quelconque..." },
            { "People say things to me all the time.", "Les gens me disent des choses en permanence." },
            { "Sorry?", "Pardon ?" },
            { "They say avaricious, they say money-grabbing, they say\r\ncheat, full of hot air, stripy swindler!", "On dit avare, on dit rapace, on dit\r\nescroc, plein de vent, fripouille en rayures !" },
            { "If I let what the people say bother me, how can I fly my\r\nballoons, uh?", "Si je laissais ce que racontent les gens me troubler, comment pourrais-je faire\r\nvoler mes ballons, hein ?" },
            { "Well...I think you just need to fill them up and the gas\r\ndoes most of the work, really.", "Eh bien... je crois qu'il suffit de les gonfler et le gaz\r\nfait le plus gros du travail, en réalité." },
            { "Allora! That is why I refuse to listen to what the people\r\nsay!", "Allora ! Voilà pourquoi je refuse d'écouter ce que racontent\r\nles gens !" },
            { "Why should I?! It is nothing good!", "Pourquoi devrais-je ?! Ce n'est jamais rien de bon !" },
            { "(Well...if he doesn't listen, that explains a lot.)", "(Eh bien... s'il n'écoute rien, cela explique bien des choses.)" },
            { "A balloon with arms and legs, but no faculties with which\r\nto hear...", "Un ballon pourvu de bras et de jambes, mais dénué de tout\r\nappareil auditif..." },
            { "...There's no need to get carried away.", "...Inutile de s'emporter à ce point." }
        });

        // [173] KEY:BB\script\output\_macro02_eng#36
        add(@"BB\script\output\_macro02_eng#36", new string[,] {
            { "Master Gotts, do you have something to say?", "Jeune prince Gotts, avez-vous quelque chose à dire ?" },
            { "Something that struck you about what you just heard,\r\nperhaps?", "Quelque chose vous a frappé dans ce qu'on vient d'entendre,\r\npeut-être ?" },
            { "Vot I just heard voz you failing to remember my full\r\nname.", "Ce que je viens d'entendre, c'est que vous avez été incapable de vous souvenir de mon\r\nnom complet." },
            { "Sorry?", "Pardon ?" },
            { "Vich is Wilhelm Gottsreich Sigismond Ormstein.", "Qui est Wilhelm Gottsreich Sigismund Ormstein." },
            { "Uh... Vil...um...", "Euh... Vil... hum..." },
            { "My learned friend's powers of recollection are clearly\r\nabysmal. Perhaps he has forgotten where he is...", "La mémoire de mon docte confrère est visiblement\r\ndésastreuse. Peut-être a-t-il oublié où il se trouve..." },
            { "Mein teacher at elementary school said zat if you are\r\nrude enough to forget somevun's name...", "Mon maître à l'école élémentaire disait que si vous êtes\r\nassez impoli pour oublier le nom de quelqu'un..." },
            { "...you vill have ze most awful life imaginable!", "...vous aurez la vie la plus abominable qui soit !" },
            { "(Are all Bohemians brought up to endure a life of such\r\ngreat pain?)", "(Tous les Bohémiens sont-ils éduqués à supporter une vie\r\nde telles souffrances ?)" },
            { "Well...well it's important to listen, too!\r\nSo please pay attention to the testimony!", "Eh bien... il est important d'écouter aussi !\r\nAlors prêtez attention au témoignage, je vous prie !" }
        });

        // [174] KEY:BB\script\output\_macro02_eng#37
        add(@"BB\script\output\_macro02_eng#37", new string[,] {
            { "Miss Lestrade!", "Mademoiselle Lestrade !" },
            { "Eh? Blimey, wot's up wiv you?", "Hein ? Bonté divine, qu'est-ce qui t'arrive ?" },
            { "Did that last statement strike you as odd in some way,\r\nperhaps?", "Cette dernière déposition vous a-t-elle paru curieuse d'une façon\r\nou d'une autre ?" },
            { "You're the expert on bein' odd, ain't ya, 'Oddo?", "C'est toi l'expert en curiosités, pas vrai, 'Hodo ?" },
            { "So why don't you tell me?", "Alors pourquoi tu m'le dis pas ?" },
            { "No no...I'm the one asking the questions here, Gina.", "Non non... C'est moi qui pose les questions ici, Gina." },
            { "Hah! Askin' other people wot ya don't even know the\r\nanswer to yerself! I don't believe it!", "Hah ! Demander aux autres ce dont tu connais même pas la\r\nréponse toi-même ! J'y crois pas !" },
            { "An' I'm INSPECTOR Lestrade, an' all!", "Et j'te rappelle que j'suis L'INSPECTEUR Lestrade, en plus !" },
            { "(She just had to drop that title in somehow, didn't she?)", "(Il fallait qu'elle place son titre d'une manière ou d'une autre, pas vrai ?)" }
        });

        // [175] KEY:BB\script\output\_macro02_eng#38
        add(@"BB\script\output\_macro02_eng#38", new string[,] {
            { "Mr Drebber! Is something wrong?", "Monsieur Drebber ! Quelque chose ne va pas ?" },
            { "Mr Drebber!", "Monsieur Drebber !" },
            { "It would appear his only answer is that rather bewitching\r\nmechanical wiggle.", "Il semblerait que sa seule réponse soit cette ondulation\r\nmécanique assez fascinante." },
            { "...He could have just said no.", "...Il aurait pu simplement dire non." }
        });

        // [176] KEY:BB\script\output\_macro02_eng#39
        add(@"BB\script\output\_macro02_eng#39", new string[,] {
            { "Dr Sithe!", "Dre Pétrie !" },
            { "What?", "Quoi ?" },
            { "You were clearly just lost in thought about something!", "Vous étiez manifestement perdue dans vos pensées !" },
            { "Your jet-black Japanese hair.", "Vos cheveux de jais japonais." },
            { "Pardon?", "Pardon ?" },
            { "It made me wonder if perhaps your head was filled with\r\nequally jet-black Indian ink.", "Je me demandais si votre tête n'était pas remplie d'une\r\nencre de Chine tout aussi noire." },
            { "And that the only way to know for sure, would be to cut\r\nyour head open and see.", "Et que le seul moyen de le savoir avec certitude serait de vous ouvrir\r\nla tête pour voir." },
            { "That's what I was thinking.", "Voilà ce à quoi je pensais." },
            { "(Alright, mental note in black sumi ink:\r\nnever pursue Dr Sithe again.)", "(Compris, note mentale à l'encre de Chine noire :\r\nne plus jamais insister auprès de la Dre Pétrie.)" },
            { "Mr Naruhodo! You mustn't be intimidated!", "Monsieur Naruhodo ! Ne vous laissez pas intimider !" }
        });

        // [177] KEY:BB\script\output\_macro02_eng#100
        add(@"BB\script\output\_macro02_eng#100", new string[,] {
            { "Every article on the front page is news about the Great\r\nExhibition.", "Tous les articles en une parlent de la Grande\r\nExposition." },
            { "Public experiments to demonstrate brand-new scientific\r\nideas, cultural exhibits from around the globe...", "Démonstrations publiques d'idées scientifiques novatrices,\r\npavillons culturels des quatre coins du globe..." },
            { "It's all so positive and hopeful about the coming century.", "Tout est si positif et porteur d'espoir pour le siècle à venir." },
            { "We must all go to see it properly before too long.", "Nous devrions tous aller la visiter convenablement dès que possible." }
        });

        // [178] KEY:BB\script\output\_macro02_eng#101
        add(@"BB\script\output\_macro02_eng#101", new string[,] {
            { "‘The Reaper Attacked’...", "« Le Faucheur attaqué »..." },
            { "It's the kingpins of the criminal underworld generally\r\nmanaging to escape conviction in the Reaper's trials.", "Ce sont généralement les pontes de la pègre qui réussissent à\r\néchapper à la condamnation lors des procès du Faucheur." },
            { "And this isn't the first time their henchmen have tried to\r\nattack Lord van Zieks as a result, by the sound of it.", "Et ce n'est pas la première fois que leurs hommes de main essaient\r\nd'attaquer Lord Van Peers en représailles, à ce qu'on dit." },
            { "...It makes you think.\r\nIf that's how the justice system works in London...", "...Cela donne à réfléchir.\r\nSi c'est ainsi que fonctionne la justice à Londres..." },
            { "...then there must be dark forces at work.", "...alors de bien sombres puissances sont à l'œuvre." }
        });

        // [179] KEY:BB\script\output\_macro02_eng#102
        add(@"BB\script\output\_macro02_eng#102", new string[,] {
            { "It looks like layers of thick canvas with a thick rubber\r\nlining of sorts.", "On dirait des couches de toile épaisse doublées d'une sorte de\r\ncaoutchouc très lourd." },
            { "I've never seen anything like it before.", "Je n'ai jamais rien vu de tel auparavant." },
            { "But applying Mr Sholmes's methods...", "Mais en appliquant les méthodes de M. Holmes..." },
            { "...you might deduce it was part of a raincoat worn by\r\nsomeone who really, really didn't want to get wet.", "...on pourrait en déduire qu'il s'agit d'un fragment d'imperméable porté par\r\nquelqu'un qui ne voulait vraiment, vraiment pas être mouillé." },
            { "And the charring...must have occurred when the person\r\nwas struck by lightning!", "Et les traces de brûlure... proviennent forcément du fait que la personne\r\na été frappée par la foudre !" },
            { "Or maybe not.", "Ou peut-être pas." }
        });

        // [180] KEY:BB\script\output\_macro02_eng#103
        add(@"BB\script\output\_macro02_eng#103", new string[,] {
            { "Ah, there's some sort of lever here...", "Ah, il y a une sorte de levier par ici..." },
            { "What the–\r\nWhat is this?!", "Mais qu'est-ce que–\r\nQu'est-ce que c'est que ça ?!" },
            { "It, it looks like a cross between a bow and a gun!", "On, on dirait un croisement entre un arc et un fusil !" },
            { "(I think it's probably used for the same thing, too.)", "(Et je parie que ça sert probablement au même dessein.)" }
        });

        // [181] KEY:BB\script\output\_macro02_eng#104
        add(@"BB\script\output\_macro02_eng#104", new string[,] {
            { "This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose." },
            { "So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique." },
            { "This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois." },
            { "(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)" }
        });

        // [182] KEY:BB\script\output\_macro02_eng#105
        add(@"BB\script\output\_macro02_eng#105", new string[,] {
            { "It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension." },
            { "You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors." },
            { "In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais." },
            { "Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition." }
        });

        // [183] KEY:BB\script\output\_macro02_eng#106
        add(@"BB\script\output\_macro02_eng#106", new string[,] {
            { "There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche..." },
            { "This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique." },
            { "It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule." },
            { "(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)" }
        });

        // [184] KEY:BB\script\output\_macro02_eng#107
        add(@"BB\script\output\_macro02_eng#107", new string[,] {
            { "This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute." },
            { "This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime..." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part4_C.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part4_C written.");
    }
}
