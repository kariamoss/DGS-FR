using System;
using System.IO;
using System.Text;

class MakeAct6Part3C {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart3_C() {");

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

        // [121] KEY:BB\script\output\_sce02_evidence_eng#0
        add(@"BB\script\output\_sce02_evidence_eng#0", new string[,] {
            { "I can't find anything out of place.", "Je ne trouve rien d'anormal." }
        });

        // [122] KEY:BB\script\output\_sce02_evidence_eng#1
        add(@"BB\script\output\_sce02_evidence_eng#1", new string[,] {
            { "Oh! So you have scale balances in Japan too, do you?", "Oh ! Vous avez donc des balances aussi au Japon ?" },
            { "Well yes, but nothing like the Old Bailey's huge example.", "Eh bien oui, mais rien de comparable à l'immense balance d'Old Bailey." },
            { "The thing about those scales is, they're only ever in\r\nbalance right at the start of a trial, aren't they?", "Le problème avec cette balance, c'est qu'elle n'est à l'équilibre qu'au tout début d'un procès, pas vrai ?" },
            { "Otherwise they always seem to be hanging one way or\r\nanother...", "Le reste du temps, elle penche toujours d'un côté ou de l'autre..." },
            { "(I'd noticed that exact same thing...)", "(J'avais remarqué exactement la même chose...)" }
        });

        // [123] KEY:BB\script\output\_sce02_evidence_eng#2
        add(@"BB\script\output\_sce02_evidence_eng#2", new string[,] {
            { "I'm right in thinking that these scales are a symbol of the\r\ndefence in law, aren't they?", "J'ai bien raison de croire que cette balance est l'emblème de la défense en justice, n'est-ce pas ?" },
            { "They're supposed to symbolise treating everything\r\nequally...and fairly.", "Elle est censée symboliser l'égalité de traitement... et l'équité." },
            { "That's why they're always in the middle, balanced.\r\nEqual measures on both sides.", "C'est pourquoi les plateaux sont toujours alignés, en équilibre parfait. Deux poids égaux des deux côtés." },
            { "Recently though, whenever I see a set of scales, I can only\r\nthink of the enormous Scales of Justice.", "Pourtant ces temps-ci, chaque fois que je vois une balance, je ne peux m'empêcher de penser à la gigantesque Balance de la Justice." },
            { "That's entirely understandable. They are such a powerful\r\nsymbol in the courtroom, aren't they?", "C'est tout à fait compréhensible. C'est un symbole tellement imposant dans le prétoire, n'est-ce pas ?" },
            { "And the thing about the Scales of Justice is...\r\n...they're always leaning one way or the other.\r\nThey're only ever in balance right at the start.", "Et ce qu'il y a avec cette Balance de la Justice... c'est qu'elle penche toujours d'un côté ou de l'autre. Elle n'est en équilibre qu'au tout début." },
            { "...It must be something peculiar to the British...\r\nI'm afraid I can't shed any light on it, Mr Naruhodo.", "...Ce doit être une particularité bien britannique... Je crains de ne pouvoir vous éclairer davantage à ce sujet, Monsieur Naruhodo." }
        });

        // [124] KEY:BB\script\output\_sce02_evidence_eng#3
        add(@"BB\script\output\_sce02_evidence_eng#3", new string[,] {
            { "This set of scales is supposed to be the symbol of a\r\ndefence lawyer, I think.", "Cette balance est censée représenter l'insigne d'avocat de la défense, si je ne m'abuse." },
            { "And it's set on a background of a sunflower design.", "Avec pour motif d'arrière-plan... un tournesol." },
            { "...Or was it a dandelion?", "...Ou était-ce un pissenlit ?" },
            { "...Or a chrysanthemum, perhaps...", "...Ou peut-être un chrysanthème..." },
            { "Well anyway, no one should be judged on their\r\nknowledge of flowers...or lack of it.", "Enfin bref, on ne devrait pas juger un homme sur ses connaissances horticoles... ou leur absence." }
        });

        // [125] KEY:BB\script\output\_sce02_evidence_eng#4
        add(@"BB\script\output\_sce02_evidence_eng#4", new string[,] {
            { "Ooh, is this Japanese kanji script embroidered here?", "Oh, ce sont des kanjis japonais brodés ici ?" },
            { "That's right. The name of the armband's owner.", "C'est exact. Le nom du propriétaire de ce brassard." },
            { "Ah! So that's how you write ‘Naruhodo’ is it?", "Ah ! C'est donc ainsi qu'on écrit « Naruhodo » ?" },
            { "Actually, no. It's my best friend's name, not mine.", "En réalité, non. C'est le nom de mon meilleur ami, pas le mien." },
            { "It's pronounced ‘Kazuma Asogi’.", "Cela se prononce « Kazuma Asogi »." },
            { "I actually believe this armband in some way embodies his\r\nspirit, you see.", "J'ai la conviction que ce brassard incarne en quelque sorte son âme, voyez-vous." },
            { "So you have to write all those lines just for one person's\r\nname? Kanji is funny, isn't it?", "Il faut donc tracer tous ces traits juste pour un seul nom ? Les kanjis sont amusants, pas vrai ?" },
            { "(That's right. Never mind my feelings about my best\r\nfriend. It's lines I really want to talk about...)", "(C'est cela. Ne tenons aucun compte de ce que j'éprouve pour mon ami. Parlons plutôt de calligraphie...)" }
        });

        // [126] KEY:BB\script\output\_sce02_evidence_eng#5
        add(@"BB\script\output\_sce02_evidence_eng#5", new string[,] {
            { "It's very fine embroidery here that shows the name of\r\nthe armband's owner.", "Cette broderie très fine indique le nom du propriétaire de ce brassard." },
            { "In this case...Kazuma Asogi.", "En l'occurrence... Kazuma Asogi." },
            { "So I'm always carrying my best friend's hopes and dreams\r\nwith me on my right arm just here. All the time.", "Ainsi, je porte constamment sur mon bras droit les espoirs et les rêves de mon meilleur ami, juste ici. Tout le temps." },
            { "To be honest, it's something that weighs very heavily on\r\nme.", "À vrai dire, cela pèse d'un poids immense sur mes épaules." },
            { "...Oh, I didn't realise it was such a burden, Mr Naruhodo.", "...Oh, je n'imaginais pas que ce fût un tel fardeau, Monsieur Naruhodo." },
            { "Yes, I think it's why my right shoulder aches so much.", "Oui, je crois bien que c'est pour cela que mon épaule droite me fait si mal." },
            { "Are you sure that's not to do with you reading in bed or\r\nthe like?", "Êtes-vous bien certain que cela n'a rien à voir avec le fait de lire au lit dans une mauvaise posture ?" }
        });

        // [127] KEY:BB\script\output\_sce02_evidence_eng#6
        add(@"BB\script\output\_sce02_evidence_eng#6", new string[,] {
            { "The name of the armband's owner is very finely\r\nembroidered here.", "Le nom du propriétaire de ce brassard est très finement brodé ici." },
            { "‘Kazuma Asogi’...", "« Kazuma Asogi »..." },
            { "One day, when I'm back in Japan and I've earned my\r\nofficial law qualification there...\r\n...I'll wear one band on each arm. ...That should make me\r\na very well-balanced lawyer, I suppose.", "Un jour, quand je serai de retour au Japon et que j'y aurai obtenu mes diplômes d'avocat... j'en porterai un à chaque bras. ...Cela fera de moi un avocat parfaitement équilibré, j'imagine." }
        });

        // [128] KEY:BB\script\output\_sce02_evidence_eng#9
        add(@"BB\script\output\_sce02_evidence_eng#9", new string[,] {
            { "Every article on the front page is news about the Great\r\nExhibition.", "Tous les articles en première page traitent de l'Exposition universelle." },
            { "Public experiments to demonstrate brand-new scientific\r\nideas, cultural exhibits from around the globe...", "Des démonstrations publiques de théories scientifiques novatrices, des pavillons culturels venus du monde entier..." },
            { "It's all so positive and hopeful about the coming century.\r\nWe must all go to see it properly before too long.", "Tout respire l'optimisme et la foi dans le siècle à venir. Nous devrions tous aller la visiter convenablement avant qu'elle ne ferme ses portes." }
        });

        // [129] KEY:BB\script\output\_sce02_evidence_eng#10
        add(@"BB\script\output\_sce02_evidence_eng#10", new string[,] {
            { "Every article on the front page is news about the Great\r\nExhibition.", "Tous les articles en première page traitent de l'Exposition universelle." },
            { "Public experiments to demonstrate brand-new scientific\r\nideas, cultural exhibits from around the globe...", "Des démonstrations publiques de théories scientifiques novatrices, des pavillons culturels venus du monde entier..." },
            { "It's all so positive and hopeful about the coming century.\r\nWe must all go to see it properly before too long.", "Tout respire l'optimisme et la foi dans le siècle à venir. Nous devrions tous aller la visiter convenablement avant qu'elle ne ferme ses portes." }
        });

        // [130] KEY:BB\script\output\_sce02_evidence_eng#11
        add(@"BB\script\output\_sce02_evidence_eng#11", new string[,] {
            { "(So many glowing reports about the Great Exhibition and\r\neverything that's going on there.)", "(Tant d'éloges dithyrambiques sur l'Exposition universelle et tout ce qui s'y déroule.)" },
            { "(Other than this rather gloomy-looking one, that is.)", "(Hormis cet article aux allures plutôt lugubres, s'entend.)" },
            { "Wait, what...?", "Attendez, quoi... ?" },
            { "What's the matter, Runo?", "Qu'y a-t-il, Mister Yûno ?" },
            { "‘The Reaper Attacked’...", "« Le Faucheur attaqué »..." },
            { "That's, that's Lord van Zieks!", "C'est... c'est Lord Van Peers !" },
            { "This must be what Mr Sholmes was talking about.", "C'est sans doute ce dont M. Holmes parlait." },
            { "(Does he know any more, I wonder...?)", "(En sait-il davantage, je me le demande...?)" }
        });

        // [131] KEY:BB\script\output\_sce02_evidence_eng#12
        add(@"BB\script\output\_sce02_evidence_eng#12", new string[,] {
            { "‘The Reaper Attacked’...", "« Le Faucheur attaqué »..." },
            { "It's the kingpins of the criminal underworld generally\r\nmanaging to escape conviction in the Reaper's trials.", "Ce sont généralement les pontes du crime organisé qui réussissent à échapper à la condamnation lors des procès du Faucheur." },
            { "And this isn't the first time their henchmen have tried to\r\nattack Lord van Zieks as a result, by the sound of it.", "Et à ce qu'on dit, ce n'est pas la première fois que leurs hommes de main s'en prennent à Lord Van Peers en représailles." },
            { "...It makes you think.\r\nIf that's how the justice system works in London...\r\n...then there must be dark forces at work.", "...Cela donne à réfléchir. Si c'est ainsi que fonctionne la justice à Londres... de bien sombres puissances doivent tirer les ficelles." }
        });

        // [132] KEY:BB\script\output\_sce02_evidence_eng#13
        add(@"BB\script\output\_sce02_evidence_eng#13", new string[,] {
            { "‘The Reaper Attacked’...", "« Le Faucheur attaqué »..." },
            { "It's the kingpins of the criminal underworld generally\r\nmanaging to escape conviction in the Reaper's trials.", "Ce sont généralement les pontes du crime organisé qui réussissent à échapper à la condamnation lors des procès du Faucheur." },
            { "And this isn't the first time their henchmen have tried to\r\nattack Lord van Zieks as a result, by the sound of it.", "Et à ce qu'on dit, ce n'est pas la première fois que leurs hommes de main s'en prennent à Lord Van Peers en représailles." },
            { "...It makes you think.\r\nIf that's how the justice system works in London...\r\n...then there must be dark forces at work.", "...Cela donne à réfléchir. Si c'est ainsi que fonctionne la justice à Londres... de bien sombres puissances doivent tirer les ficelles." }
        });

        // [133] KEY:BB\script\output\_sce02_evidence_eng#14
        add(@"BB\script\output\_sce02_evidence_eng#14", new string[,] {
            { "It looks like layers of thick canvas with a thick rubber\r\nlining of sorts.\r\nI've never seen anything like it before.\r\nBut applying Mr Sholmes's methods...\r\n...you might deduce it was part of a raincoat worn by\r\nsomeone who really, really didn't want to get wet.\r\nAnd the charring...must have occurred when the person\r\nwas struck by lightning!\r\nOr maybe not.", "On dirait des couches de toile épaisse doublées d'une sorte de caoutchouc très lourd. Je n'ai jamais rien vu de tel auparavant. Mais en appliquant les préceptes de M. Holmes... on pourrait en déduire qu'il s'agit d'un fragment d'imperméable porté par quelqu'un qui ne tenait vraiment, mais alors vraiment pas à être mouillé. Et ces traces de brûlure... proviennent forcément du fait que la personne a été foudroyée par l'orage ! Ou peut-être pas." }
        });

        // [134] KEY:BB\script\output\_sce02_evidence_eng#15
        add(@"BB\script\output\_sce02_evidence_eng#15", new string[,] {
            { "It looks like layers of thick canvas with a thick rubber\r\nlining of sorts.\r\nI've never seen anything like it before.\r\nBut applying Mr Sholmes's methods...\r\n...you might deduce it was part of a raincoat worn by\r\nsomeone who really, really didn't want to get wet.\r\nAnd the charring...must have occurred when the person\r\nwas struck by lightning!\r\nOr maybe not.", "On dirait des couches de toile épaisse doublées d'une sorte de caoutchouc très lourd. Je n'ai jamais rien vu de tel auparavant. Mais en appliquant les préceptes de M. Holmes... on pourrait en déduire qu'il s'agit d'un fragment d'imperméable porté par quelqu'un qui ne tenait vraiment, mais alors vraiment pas à être mouillé. Et ces traces de brûlure... proviennent forcément du fait que la personne a été foudroyée par l'orage ! Ou peut-être pas." }
        });

        // [135] KEY:BB\script\output\_sce02_evidence_eng#16
        add(@"BB\script\output\_sce02_evidence_eng#16", new string[,] {
            { "Ah, there's some sort of lever here...", "Ah, il y a une sorte de levier par ici..." },
            { "What the–\r\nWhat is this?!", "Mais qu'est-ce que...\r\nQu'est-ce que c'est que ça ?!" },
            { "It, it looks like a cross between a bow and a gun!", "On... on dirait un croisement entre un arc et un fusil !" },
            { "(I think it's probably used for the same thing, too.)", "(Et je parie que ça sert exactement au même dessein.)" },
            { "The details of the crossbow\r\nhave been updated in the Court Record.", "Les détails de l'arbalète\r\nont été mis à jour dans le dossier." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part3_C.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part3_C written.");
    }
}
