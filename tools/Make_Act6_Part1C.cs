using System;
using System.IO;
using System.Text;

class MakeAct6Part1C {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart1_C() {");

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

        // [31] KEY:BB\script\output\_sce02_chr030_01_eng#9
        add(@"BB\script\output\_sce02_chr030_01_eng#9", new string[,] {
            { "About this paper, Miss Susato...", "À propos de ce journal, mademoiselle Susato..." },
            { "Yes, it's all about the Great Exhibition!", "Oui, tout est consacré à l'Exposition universelle !" },
            { "I've been dreaming about it, you know!", "J'en rêvais jour et nuit, vous savez !" },
            { "I was sorry that you were going to miss it when you were\r\ncalled back to Japan.", "J'étais désolé à l'idée que vous la manquiez lors de votre rappel au Japon." },
            { "So was I.", "Moi également." },
            { "I felt desperately unlucky.", "Je me sentais particulièrement malchanceuse." },
            { "But here I am, back in London while it's underway!", "Mais me revoilà à Londres en plein cœur de l'événement !" },
            { "It's a dream come true!", "C'est un véritable rêve éveillé !" },
            { "Perhaps you're not as unlucky as you thought, then.", "Peut-être n'êtes-vous pas si malchanceuse que cela, finalement." },
            { "Once we've helped Professor Harebrayne out of this\r\nterrible situation, we should all explore it together!", "Une fois le professeur Lonron sorti de cette fâcheuse passe, nous irons la visiter tous ensemble !" },
            { "And of course we must invite the professor's good friend\r\nLord van Zieks as well.", "Et nous devrons tout naturellement convier le grand ami du professeur, Lord Van Peers !" },
            { "(Your luck might not stretch that far.)", "(Votre chance risque de ne pas aller jusque-là.)" }
        });

        // [32] KEY:BB\script\output\_sce02_chr030_01_eng#10
        add(@"BB\script\output\_sce02_chr030_01_eng#10", new string[,] {
            { "This...was used to shoot down the balloon, wasn't it?", "Ceci... a servi à abattre la montgolfière, n'est-ce pas ?" },
            { "Yes, with a flaming arrow.", "Oui, au moyen d'une flèche enflammée." },
            { "It's quite a formidable weapon.", "C'est une arme redoutable." },
            { "I'm quite accomplished with a longbow myself, you know.", "Je me débrouille plutôt bien au grand arc moi-même, vous savez." },
            { "No! Really?", "Pas possible ! Vraiment ?" },
            { "If you were to balance an apple on your head,\r\nMr Naruhodo...", "Si vous posiez une pomme en équilibre sur votre tête, monsieur Naruhodo..." },
            { "...I'm quite confident I could hit it from a good fifty metres\r\naway!", "...je suis tout à fait confiante dans ma capacité à la transpercer à cinquante bons mètres !" },
            { "‘Quite’ confident, you say?", "« Tout à fait » confiante, dites-vous ?" },
            { "Does, um... Does the apple necessarily HAVE to be on my\r\nhead?", "Est-ce que, euh... est-ce que la pomme doit OBLIGATOIREMENT se trouver sur ma tête ?" }
        });

        // [33] KEY:BB\script\output\_sce02_chr030_01_eng#11
        add(@"BB\script\output\_sce02_chr030_01_eng#11", new string[,] {
            { "Do you know...?", "Savez-vous... ?" },
            { "I honestly thought I might never have the opportunity to\r\nreturn to Great Britain.", "Je pensais sincèrement ne plus jamais avoir l'occasion de revenir en Grande-Bretagne." },
            { "And certainly not so soon.", "Et certainement pas de sitôt." },
            { "It's funny. For the past six months, I haven't been able to\r\nwork in court.", "C'est amusant. Durant ces six derniers mois, je n'ai point pu plaider au tribunal." },
            { "Meanwhile, you've been raising a storm in the Supreme\r\nCourt of Judicature back in Japan!", "Pendant ce temps, vous avez fait des étincelles à la Cour suprême impériale du Japon !" },
            { "Please, Mr Naruhodo! I may have been dressed as a man,but it was a very reserved performance!", "Je vous en prie, monsieur Naruhodo ! J'étais certes déguisée en homme, mais ma plaidoirie fut très sobre !" },
            { "Please, Mr Naruhodo! I may have been dressed as a man, but it was a very reserved performance!", "Je vous en prie, monsieur Naruhodo ! J'étais certes déguisée en homme, mais ma plaidoirie fut très sobre !" },
            { "(So what your father said in his letter about a ‘Ryutaro\r\nTakedown’ is...reserved?)", "(Ce que son père a écrit dans sa lettre sur une « Prise foudroyante de Ryutaro »... était sobre ?)" },
            { "Well anyway...", "Enfin, peu importe..." },
            { "...I'm back here in this great capital now...", "...je suis de retour dans cette splendide capitale..." },
            { "...and ready to assist you again in any way I can!", "...et prête à vous seconder de nouveau de toutes mes forces !" },
            { "...Thank you, Miss Susato.", "...Merci à vous, mademoiselle Susato." },
            { "It's my pleasure, Mr Naruhodo.", "Tout le plaisir est pour moi, monsieur Naruhodo." }
        });

        // [34] KEY:BB\script\output\_sce02_chr030_01_eng#12
        add(@"BB\script\output\_sce02_chr030_01_eng#12", new string[,] {
            { "Well, I think we've done all the investigating we can here\r\nfor now.", "Bien, je crois que nous avons poussé l'enquête aussi loin que possible ici pour le moment." },
            { "If we could just determine the whereabouts of\r\nMr Drebber...", "Si seulement nous parvenions à découvrir où se terre M. Drebber..." },
            { "I'm sure Gina and little Toby won't let us down!", "Je suis certaine que Gina et le petit Toby ne nous décevront pas !" },
            { "Now then...", "À présent..." },
            { "...do you think we ought to try to speak with Mr Sholmes\r\nat this point?", "...pensez-vous qu'il serait judicieux de nous entretenir avec M. Holmes ?" },
            { "We have things to discuss and I'm dying to meet him\r\nagain after all these months.", "Nous avons tant de choses à aborder et je brûle de le revoir après tous ces mois." },
            { "Yes, it's quite possible he might know something useful,you're right.", "Oui, il est fort probable qu'il détienne des éléments précieux, vous avez raison." },
            { "Yes, it's quite possible he might know something useful,\r\nyou're right.", "Oui, il est fort probable qu'il détienne des éléments précieux, vous avez raison." },
            { "We ought to find him at Madame Tusspells. He's supposed\r\nto be working there as a temporary waxwork exhibit.", "Nous devrions le trouver chez Madame Pétrie. Il est censé y travailler comme statue de cire vivante." },
            { "Yes! Iris told me all about his latest unusual venture!", "Oui ! Iris m'a tout raconté sur sa dernière lubie saugrenue !" }
        });

        // [35] KEY:BB\script\output\_sce02_chr040_00_eng#1
        add(@"BB\script\output\_sce02_chr040_00_eng#1", new string[,] {
            { "I'm so excited about the prospect of Naruhodo's Anything\r\nConsultancy opening for business again!", "Je suis si heureuse à l'idée que le Cabinet Tout-Venant Naruhodo reprenne enfin du service !" },
            { "That's not what it's called.", "Ce n'est pas son nom." },
            { "It's Naruhodo's Legal Consultancy.", "C'est le Cabinet Juridique Naruhodo." },
            { "(I've done a lot of studying in these past six months.", "(J'ai potassé sans relâche ces six derniers mois." },
            { "Reading law texts and judicial precedents...)", "À compulser les recueils de jurisprudence et les codes de lois...)" },
            { "(I'm sure I'm a better lawyer now... I can't wait to start\r\npractising again!)", "(Je suis certain d'être un meilleur avocat à présent... J'ai hâte de plaider à nouveau !)" },
            { "Nothing's changed in here at all though, has it?", "Rien n'a changé d'un pouce ici, n'est-ce pas ?" },
            { "It's as though time has stood still in here since Susie went\r\nback to Japan.", "On dirait que le temps s'est figé depuis le retour de Susato au Japon." },
            { "I wanted to keep it ready for Miss Susato, in case she was\r\nable to return to Britain at any point.", "Je voulais que tout soit prêt pour mademoiselle Susato, au cas où elle reviendrait." },
            { "So I've just left everything the way it was.", "J'ai donc laissé chaque chose à sa place." },
            { "Oh, I see. Right...", "Oh, je vois. D'accord..." },
            { "And there was me thinking it's because of the way you\r\nare, Runo.", "Et moi qui croyais que c'était simplement dans ta nature, Ryuno." },
            { "You know, never bothering to tidy up, I mean.", "Je veux dire... cette fâcheuse manie de ne jamais rien ranger." },
            { "...Iris...", "...Iris..." },
            { "...this isn't the time or the place to bring up my tidiness...or lack of it.", "...ce n'est ni le moment ni l'endroit pour disserter sur mon sens du rangement... ou son absence." }
        });

        // [36] KEY:BB\script\output\_sce02_chr040_00_eng#3
        add(@"BB\script\output\_sce02_chr040_00_eng#3", new string[,] {
            { "Iris, have a look at this...", "Iris, jette un œil à ceci..." },
            { "That's not right. I thought you were supposed to say\r\n‘Objection!’ or the like when you present evidence?", "Ce n'est pas comme ça ! Je croyais que tu devais crier « Objection ! » quand tu montres une preuve !" },
            { "No no. That's only in court.", "Non non. Ça, c'est réservé au prétoire." },
            { "That's not fair! If you won't say it, then I won't look!\r\nHmph!", "Ce n'est pas juste ! Si tu ne le cries pas, je ne regarderai pas ! Na !" },
            { "Yay! That was great!\r\nRight...next!", "Youpi ! C'était sensationnel ! Bien... la suite !" },
            { "(Alright, I get the message. Someone's not in the mood for\r\nlooking at things...)", "(D'accord, message reçu. Mademoiselle n'a pas envie d'examiner mes pièces à conviction...)" }
        });

        // [37] KEY:BB\script\output\_sce02_chr040_00_eng#4
        add(@"BB\script\output\_sce02_chr040_00_eng#4", new string[,] {
            { "Iris, have a quick look at this...", "Iris, regarde vite ceci..." },
            { "Your lawyer's armband?\r\nHow many times have you shown me that, Runo?", "Ton brassard d'avocat ? Combien de fois vas-tu encore me le montrer, Ryuno ?" },
            { "Oh. Sorry.", "Oh. Pardon." },
            { "It's very important to me, that's all.\r\nI don't feel complete somehow if I'm not wearing it.", "C'est très précieux pour moi, c'est tout. Je me sens dénudé sans lui." },
            { "Well personally, I think you should try wrapping some\r\ndifferent things around your arm from time to time.", "Personnellement, je trouve que tu devrais essayer d'enrouler d'autres trucs autour de ton bras de temps en temps." },
            { "Oh really? Like what?", "Ah bon ? Comme quoi ?" },
            { "Perhaps a pretzel?", "Peut-être un bretzel ?" },
            { "‘Pret-zel’...?\r\nI've never heard that word before.", "Un « bret-zel »... ? Je n'ai jamais entendu ce mot auparavant." },
            { "well I think it's a kind of German defence lawyer's\r\nsymbol.", "eh bien je crois que c'est le symbole des avocats de la défense en Allemagne." },
            { "(Interesting... I'll have to try wearing one sometime...)", "(Intéressant... Il faudra que j'essaie d'en porter un à l'occasion...)" }
        });

        // [38] KEY:BB\script\output\_sce02_chr040_00_eng#5
        add(@"BB\script\output\_sce02_chr040_00_eng#5", new string[,] {
            { "Iris, about this paper...", "Iris, à propos de ce journal..." },
            { "Oh yes! It's all about the Great Exhibition!\r\nI'm so excited about it!", "Oh oui ! Tout sur l'Exposition universelle ! C'est tellement palpitant !" },
            { "Once you've done what you need to do, we should all go\r\ntogether and explore!", "Dès que tu auras fini tes affaires, nous irons tous l'explorer ensemble !" },
            { "I don't know... It sounds like it could be quite dangerous.", "Je ne sais pas trop... Ça m'a l'air plutôt risqué." },
            { "We wouldn't want to get caught in an explosion as we\r\nwere walking around in the showground.", "Il ne faudrait pas qu'on soit pris dans une explosion au détour d'une allée." },
            { "Oh...is that what you think's going to happen, is it?", "Oh... c'est ce que tu crois qu'il va arriver, vraiment ?" }
        });

        // [39] KEY:BB\script\output\_sce02_chr040_01_eng#1
        add(@"BB\script\output\_sce02_chr040_01_eng#1", new string[,] {
            { "It was completely by accident that I came to know the\r\ntitle of your manuscript, Iris.", "C'est par le plus pur des hasards que j'ai découvert le titre de ton manuscrit, Iris." },
            { "It was a short while before we left Japan. I was cleaning\r\nFather's study, and I saw something on his writing desk.", "C'était peu avant notre départ du Japon. En nettoyant le bureau de Père, j'ai aperçu un objet sur sa table de travail." },
            { "A large box of papers.", "Une épaisse boîte remplie de manuscrits." },
            { "There was a label affixed to the box that was written in\r\nEnglish. It read...", "Une étiquette en anglais y était collée. On pouvait y lire..." },
            { "...‘The Hound of the Baskervilles’.", "...« Le Chien des Baskerville »." },
            { "What?!", "Comment ?!" },
            { "My Baskerville story?!", "Mon histoire des Baskerville ?!" },
            { "Of course, I had no idea what it was at the time.", "Naturellement, j'ignorais totalement ce dont il s'agissait alors." },
            { "But Father came in, and...", "Mais Père est entré, et..." },
            { "Susato! What are you doing?", "Susato ! Que fais-tu là ?" },
            { "Oh! F-Father...", "Oh ! P-Père..." },
            { "Did you look at those papers?", "As-tu touché à ces feuillets ?" },
            { "No! I, I simply read the label, that's all.", "Non ! J'ai... j'ai simplement lu l'étiquette, rien de plus." },
            { "Well, put it out of your mind.", "Bien. Chasse cela de ton esprit." },
            { "Forget that you ever saw it, and certainly\r\ndon't tell anybody else about this.", "Oublie que tu as jamais vu cette boîte, et n'en souffle mot à quiconque." },
            { "...Do you understand?", "...M'as-tu bien compris ?" },
            { "But...what was Iris's manuscript doing...in Japan?", "Mais... que faisait le manuscrit d'Iris... au Japon ?" },
            { "I have no idea.", "Je n'en ai pas la moindre idée." },
            { "But when I heard Iris mention the word ‘Baskerville’ that\r\nday...", "Mais en entendant Iris prononcer le nom des « Baskerville » ce jour-là..." },
            { "...the title just slipped out.", "...le titre m'a tout simplement échappé." },
            { "I would never have guessed...", "Je n'aurais jamais pu soupçonner..." },
            { "...that it was an unpublished account of one of\r\nMr Sholmes's exploits.", "...qu'il s'agissait du récit inédit d'un des exploits de M. Holmes." },
            { "When I returned to Japan, I asked Father to explain.", "À mon retour au Japon, j'ai demandé des explications à Père." },
            { "But he refused to answer any of my questions.", "Mais il s'est obstinément refusé à répondre à la moindre question." },
            { "And there was no sign of the big box in his office.", "Et la boîte avait purement et simplement disparu de son cabinet." },
            { "That's really all I know about it.", "C'est là tout ce que je sais à ce sujet." },
            { "I've no doubt that Father has a very good reason for being\r\nso secretive about it. But still...", "Père a certainement d'excellentes raisons de garder le secret, mais..." },
            { "...I made up my mind to explain myself to both of you.", "...je tenais absolument à jouer cartes sur table avec vous deux." },
            { "Well, thank you for being so honest, Susie.", "Eh bien, merci pour ta franchise, Susato." }
        });

        // [40] KEY:BB\script\output\_sce02_chr050_00_eng#1
        add(@"BB\script\output\_sce02_chr050_00_eng#1", new string[,] {
            { "It was eight months ago now that I first encountered Gina,\r\nin connection with a case I was working on.", "Il y a huit mois que j'ai fait la connaissance de Gina, à l'occasion d'une affaire que je traitais." },
            { "At the time, she was living in the East End with a group of\r\nother orphans.", "À l'époque, elle vivait dans l'East End avec une bande d'orphelins." },
            { "She helped all of them survive by pickpocketing, but then\r\nshe got embroiled in a murder.", "Elle les aidait à survivre en faisant les poches, avant d'être impliquée dans un meurtre." },
            { "I 'ad a lot of time to think in prison.", "J'ai eu tout le temps de réfléchir au gnouf." },
            { "I realised I couldn't go on like I was.\r\nThe divin' weren't workin' out.", "J'ai compris que j'pouvais pas continuer comme ça. La fauche, ça menait droit dans l'mur." },
            { "Oh, I'm so pleased to hear it, Ginny!\r\nWell done!", "Oh, je suis si heureuse de l'entendre, Gina ! Bravo !" },
            { "So...you went from being a pickpocket...to a detective?", "Alors... tu es passée de pickpocket... à détective ?" },
            { "You got it! Good, innit? Inspector Lestrade!\r\nSounds like somefin' out of a book, eh?", "T'as tout pigé ! Pas mal, hein ? L'inspectrice Lestrade ! On dirait un truc sorti d'un roman, pas vrai ?" },
            { "(Talk about a sea change...)", "(Quel changement radical de cap...)" },
            { "And then there's Iris's old man to think about.", "Et puis y'a le paternel d'Iris, aussi." },
            { "Iris's father, you mean?", "Le père d'Iris, tu veux dire ?" },
            { "Yeah. I promised 'er, didn't I?", "Ouaip. J'lui ai fait la promesse, non ?" },
            { "I said I'd get all the police forces 'round the world to pull\r\nout all the stops lookin' for 'im.", "J'ai juré de mettre toutes les polices du monde sur le coup pour l'retrouver." },
            { "...Just a small promise, then. Nothing serious.", "...Une modeste promesse, en somme. Rien de bien méchant." },
            { "Oh, Ginny, you're so sweet...", "Oh, Gina, tu es tellement adorable..." },
            { "So anyway, that's 'ow come I 'ad a go at the test for\r\nScotland Yard.", "Bref, voilà comment j'me suis présentée au concours de Scotland Yard." },
            { "Only trouble is, I don't read so well, do I?", "L'seul souci, c'est qu'je sais pas des masses lire, tu vois ?" },
            { "...Just a small problem. Nothing serious.", "...Un détail insignifiant. Rien d'insurmontable." },
            { "And that's when Hurley approached Gregsy and asked\r\nfor help.", "Et c'est là que Sherlockinou est allé voir Gregsou pour lui demander d'aider." },
            { "So the inspector said he'd take full responsibility for\r\nGinny and made her a sort of apprentice.", "Alors l'inspecteur a accepté de la prendre sous son aile comme apprentie." },
            { "...That was very magnanimous of Inspector Gregson.\r\nAnd brave.", "...C'était très généreux de la part de l'inspecteur Gregson. Et bien courageux." },
            { "Well, you know Hurley. He enjoys finding ways to make\r\npeople do what he wants.", "Eh bien, tu connais Sherlockinou. Il adore trouver des moyens de faire plier les gens." },
            { "(The great detective likes digging for dirt, in other\r\nwords...)", "(Le grand détective aime le chantage, en d'autres termes...)" },
            { "So, the long and the short of it is, if you've got questions\r\nabout the case, ya can ask Inspector Lestrade!", "Bref, pour faire court, si t'as des questions sur l'affaire, tu peux t'adresser à l'inspectrice Lestrade !" },
            { "Right then...‘Inspector’...", "Très bien... « Inspectrice »..." },
            { "(Actually, there's still a big mystery surrounding Gina,\r\nisn't there?)", "(À vrai dire, il plane toujours un épais mystère autour de Gina, n'est-ce pas ?)" },
            { "Ooh, what, Runo, what?", "Ooh, quoi donc, Ryuno, quoi ?" },
            { "Well, six months ago, Gina was the defendant in a trial\r\nprosecuted by the Reaper.", "Eh bien, il y a six mois, Gina était l'accusée dans un procès instruit par le Faucheur." },
            { "A trial in which she was found not guilty.\r\nAnd yet here she is still...", "Un procès où elle fut déclarée non coupable. Et pourtant elle est toujours parmi nous..." },
            { "Come on! Yer not still on about that, are ya?\r\nThe legend o' the Reaper or wotever it's called.", "Allez ! Tu vas pas encore nous r'faire tout un plat avec ça ? La légende du Faucheur et tout l'tintouin." },
            { "Cor, ya don't 'alf worry, 'Oddo!", "La vache, qu'est-ce que tu peux t'en faire, Naruhodo !" },
            { "(If I didn't ‘half’ worry, there probably wouldn't be a\r\n‘whole’ lot of you left!)", "(Si je ne m'en faisais pas, il ne resterait plus grand-chose de toi aujourd'hui !)" },
            { "It's like I told ya before, innit?", "C'est comme j't'ai déjà dit, pas vrai ?" },
            { "The Reaper's kind o' like 'Im upstairs. So 'e knows wot I'm\r\nlike on the inside.", "Le Faucheur, c'est un peu comme le Bon Dieu là-haut. Y sait c'que j'ai dans l'ventre." },
            { "That I ain't really done nuffin' wrong.", "Que j'suis pas une mauvaise graine." },
            { "(‘Nothing wrong’ might be stretching a point...)", "(« Pas une mauvaise graine », c'est vite dit...)" },
            { "What about Mr Natsume in Japan?", "Et M. Natsume au Japon ?" },
            { "He's perfectly fine, isn't he?", "Il se porte comme un charme, non ?" },
            { "Well...that's true. Perhaps the Reaper is more discerning\r\nthan I thought...", "Eh bien... c'est vrai. Le Faucheur a peut-être plus de discernement que je ne le croyais..." },
            { "Exactly! So I ain't worried. I'm totally fine!", "Exactement ! Alors moi, j'm'en fais pas une miette. J'pète la forme !" }
        });

        // [41] KEY:BB\script\output\_sce02_chr050_00_eng#2
        add(@"BB\script\output\_sce02_chr050_00_eng#2", new string[,] {
            { "Cor, it was out o' this world, it was!", "La vache, c'était d'un autre monde, j'te jure !" },
            { "The brainy bloke pulled a bunch o' levers on 'is machine,\r\nand suddenly it started billowin' smoke.", "L'intello a tiré sur tout un tas d'manettes, et d'un coup sa machine s'est mise à cracher d'la fumée." },
            { "Then it just went pop.", "Et pis ça a fait un gros boum." },
            { "I ain't seen a better experiment 'ere yet.", "J'ai encore jamais vu une meilleure expérience par ici." },
            { "Sorry?", "Pardon ?" },
            { "You mean...you saw it, Ginny?\r\nWith your own eyes?!", "Tu veux dire... que tu as assisté à ça, Gina ? De tes propres yeux ?!" },
            { "Yeah, 'course. The boss is in charge 'ere, ain't 'e?\r\nOf keepin' everyfin' runnin' smooth, I mean.", "Bah ouais, évidemment. C'est l'patron qui commande ici, non ? Pour qu'tout tourne rond." },
            { "(The ‘boss’ being Inspector Gregson, I suppose.\r\nThat's going to take some getting used to...)", "(Le « patron » étant l'inspecteur Gregson, j'imagine. Il va falloir s'y faire...)" },
            { "So all I 'ave to say is that I'm on duty, an' I can do wotever\r\nI want to!", "Alors moi, j'ai juste à dire que j'suis d'service, et j'fais tout c'que j'veux !" },
            { "Get this! I was up in one o' them flyin' balloons when it\r\n'appened! Watchin' it from above!", "Mate un peu ! J'étais tout là-haut dans une d'ces montgolfières quand c'est arrivé ! Aux premières loges !" },
            { "No! You're so lucky, Ginny!\r\nMaybe I should join Scotland Yard, too...", "Incroyable ! Tu as trop de chance, Gina ! Je devrais peut-être m'engager à Scotland Yard moi aussi..." },
            { "Yeah, do it!", "Carrément, viens !" },
            { "You know 'ow to put the boss in 'is place already, right,\r\nIris? You'd 'ave no trouble at all.", "Tu sais déjà comment mater l'patron, pas vrai Iris ? T'aurais aucun souci." },
            { "Then it's settled!\r\nWhen do I start?", "C'est décidé alors ! Quand est-ce que je commence ?" },
            { "No no no!\r\nYou can't join Scotland Yard, Iris.", "Non, non, non ! Tu ne peux pas entrer à Scotland Yard, Iris." },
            { "We'll see... Anyway, what I don't understand is this: if the\r\nmachine exploded so spectacularly...", "On verra bien... Bref, ce que je ne saisis pas, c'est : si la machine a explosé si fort..." },
            { "...how can Professor Bunnybrain still be claiming that his\r\nexperiment was a success?", "...comment le professeur Tournesol peut-il encore prétendre que son expérience a réussi ?" },
            { "Oh, right.\r\nWell, it was a success...in a way.", "Ah, ça. Bah, c'était un succès... à sa manière." },
            { "It was?\r\n(How can it have been?)", "Vraiment ?\r\n(Comment cela se peut-il ?)" }
        });

        // [42] KEY:BB\script\output\_sce02_chr050_00_eng#3
        add(@"BB\script\output\_sce02_chr050_00_eng#3", new string[,] {
            { "Surely after the whole machine blew up, no one could\r\ncall the experiment a success.", "Après une telle déflagration, personne ne saurait qualifier cette expérience de succès." },
            { "It's like I said, it did sort of work.", "C'est comme j't'ai dit, ça a plus ou moins marché." },
            { "I mean, yeah, there was a load o' smoke an' that whoppin'\r\ngreat bang...", "J'veux dire, ouais, y'a eu un nuage de fumée et un boucan d'tous les diables..." },
            { "...but where d'ya think they found the victim's body, eh?\r\nIn the Crystal Tower over there!", "...mais où tu crois qu'ils ont r'trouvé l'macchabée, hein ? Dans la Tour de Cristal là-bas !" },
            { "What?\r\n(In the tower?)", "Quoi ?\r\n(Dans la tour ?)" },
            { "You can see for yerself, can't ya?\r\nUp there above the scaffold...", "Tu peux l'voir de tes yeux, non ? Là-haut au-dessus de l'échafaudage..." },
            { "Oh! Where all the glass is broken, you mean?", "Oh ! Là où la verrière est brisée, tu veux dire ?" },
            { "Yeah. The cage wot the victim got in to start wiv...\r\n...really did get beamed through the air or wotever and\r\nlanded all the way over there.", "Ouais. La cage dans laquelle le gars est monté au départ... elle a bel et bien été téléportée dans les airs et a atterri tout là-bas." },
            { "So, ya see?\r\nIt did kind o' work...didn't it?", "Alors, tu vois ? Ça a quand même un peu marché... non ?" },
            { "WHAAAAAAAAAT?!\r\n(I, I don't believe it...)", "QUOOOOOOOI ?!\r\n(Je... je n'arrive pas à y croire...)" },
            { "I mean, I don't get the ins an' outs of it, but anyfin's\r\npossible, right? Wiv science.", "J'veux dire, j'pige rien aux détails techniques, mais tout est possible, pas vrai ? Avec la science." },
            { "Oh, I tell ya wot. You can 'ave this.\r\nIt's a plan o' the experiment they drew up at the Yard.", "Tiens, j'te dis quoi. Tu peux prendre ça. C'est l'plan de l'expérience qu'ils ont gribouillé au Yard." },
            { "Are, are you sure?", "Tu... tu es bien sûre ?" },
            { "Yeah, go on. I 'ad three bob off ya before, so fair's fair.", "Mais ouais, vas-y. J't'ai piqué trois sous tout à l'heure, alors bon compte fait bons amis." },
            { "(Yes, I didn't actually give that to you...did I?)", "(Oui, je ne te les avais pas vraiment donnés de mon plein gré...)" },
            { "The sketch of the experiment has been\r\nentered into the Court Record.", "Le croquis de l'expérience a été\r\najouté au dossier de l'affaire." }
        });

        // [43] KEY:BB\script\output\_sce02_chr050_00_eng#5
        add(@"BB\script\output\_sce02_chr050_00_eng#5", new string[,] {
            { "Something Inspector Gregson said before seemed a little\r\nstrange.", "Une réflexion de l'inspecteur Gregson m'a semblé bien curieuse tout à l'heure." },
            { "For what it's worth, anyway. Investigatin' is off the cards\r\nfor all of us.", "De toute façon, ça ne change rien. L'enquête est bouclée pour nous tous." },
            { "Yes, naughty old Gregsy ran off after that without\r\nexplaining himself.", "Oui, le vilain Gregsou s'est enfui juste après sans donner la moindre explication." },
            { "Oh right, that.", "Ah ouais, ça." },
            { "The boss said no one's allowed to investigate that weird\r\nmachine wot blew up yesterday.", "L'patron a dit qu'personne avait l'droit d'fouiner autour de c't'étrange machine qui a sauté hier." },
            { "Well that's not fair! We're representing the defendant!", "Mais ce n'est pas juste ! Nous représentons l'accusé !" },
            { "In that case, could you at least tell us what you've learnt\r\nfrom your investigations?", "Dans ce cas, pourrais-tu au moins nous dire ce que vous avez découvert lors de vos investigations ?" },
            { "Nah, yer not gettin' it.\r\nWe ain't allowed to investigate, neither.", "Nan, t'as pas capté. Nous non plus, on a pas l'droit d'enquêter." },
            { "Why?!", "Pourquoi ?!" },
            { "Wot did the boss call 'em again?\r\nThe Forensic Investigation Team, I think.", "Comment l'patron les a appelés déjà ? L'Équipe de police scientifique, j'crois bien." },
            { "Anyway, apart from them lot, no one's allowed to lay a\r\nfinger on the scene. Bit funny, innit?", "Bref, à part cette clique-là, personne a l'droit d'poser un doigt sur les lieux. Bizarre, non ?" },
            { "So even Scotland Yard's own detectives can't investigate...\r\nYes, I've never heard something like that before.", "Même les inspecteurs de Scotland Yard en sont exclus... C'est du jamais vu." },
            { "I thought I could 'ave a gander on the quiet, though, but\r\nthe boss caught me at it.", "J'ai bien essayé d'aller jeter un coup d'œil en douce, mais l'patron m'a prise sur le fait." },
            { "You prob'ly 'eard 'im givin' me an earful about it before\r\nfrom down 'ere, didn't ya?", "Tu l'as sans doute entendu m'passer un sacré savon depuis en bas, pas vrai ?" },
            { "It's not bleedin' fair!", "C'est trop injuste !" },
            { "...I think you were giving him as much of an earful back,\r\nas I remember it.", "...Il me semble que tu lui en as rendu tout autant, si ma mémoire est bonne." },
            { "Yeah, well, sometimes I think it's all them chips wot make\r\n'im so stubborn.", "Ouais, enfin, parfois j'me dis qu'c'est toutes ses frites qui l'rendent si borné." },
            { "You say somefin' to 'im, 'Oddo.\r\nGo on! See if you can get through to 'im!", "T'as qu'à lui causer, Naruhodo. Vas-y ! Vois si tu peux lui faire entendre raison !" },
            { "(He's up on the platform above us, is he?\r\nWhere the machine that exploded is...)", "(Il est sur la plate-forme au-dessus de nous ? Là où se trouve la machine qui a explosé...)" },
            { "We can try, can't we, Runo?\r\nGregsy will listen to us!", "Nous pouvons essayer, n'est-ce pas, Ryuno ? Gregsou va nous écouter !" }
        });

        // [44] KEY:BB\script\output\_sce02_chr050_00_eng#9
        add(@"BB\script\output\_sce02_chr050_00_eng#9", new string[,] {
            { "Gina, would you take a look at–\r\nOh! Where did it go?", "Gina, pourrais-tu examiner ce... Oh ! Mais où est-ce passé ?" },
            { "Hehe! Lookin' for this, 'Oddo?", "Héhé ! Tu cherches ça, Naruhodo ?" },
            { "(When did she do that?!)", "(Quand a-t-elle réussi à me subtiliser ça ?!)" },
            { "I wonder if you've got anyfin' else to show me, eh?\r\nWot d'ya reckon?", "J'me demande si t'as d'autres trucs à m'montrer, dis ? T'en dis quoi ?" },
            { "...Give that back first, please.", "...Rends-moi ça d'abord, s'il te plaît." }
        });

        // [45] KEY:BB\script\output\_sce02_chr050_00_eng#10
        add(@"BB\script\output\_sce02_chr050_00_eng#10", new string[,] {
            { "This armband is proof – in Japan at least – that I'm a\r\ndefence lawyer.", "Ce brassard prouve – au Japon tout du moins – que je suis avocat de la défense." },
            { "And this badge is proof that I'm a detective!", "Et c'te plaque prouve que j'suis détective !" },
            { "So yer all gonna 'ave to start callin' me Inspector Lestrade!", "Alors vous allez tous devoir m'appeler inspectrice Lestrade !" },
            { "In that case, you'll have to start calling me...\r\nWell, anything but ‘'Oddo’.", "Dans ce cas, il va falloir m'appeler... enfin, tout sauf « Naruhodo » écorché comme ça." },
            { "I could call ya ‘Defender Narra-'Oddo’ if ya like.", "J'peux t'appeler « Maître Narro-hodo » si tu veux." },
            { "...But it don't really trip off the tongue.", "...Mais ça coule pas vraiment d'source." },
            { "No...it doesn't have a great ring to it, does it?", "Non... ça ne sonne pas terrible, en effet." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part1_C.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part1_C written.");
    }
}
