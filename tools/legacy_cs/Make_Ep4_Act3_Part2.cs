using System;
using System.IO;
using System.Text;

class MakeEp4Act3Part2 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act3 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart2() {");

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

        // [26] KEY:BB\script\output\_sce03_c102_0000_eng#2
        add(@"BB\script\output\_sce03_c102_0000_eng#2", new string[,] {
            { "So... witnesses.\r\nState your names and occupations for the court.", "Témoins... décliner vos noms et professions devant le tribunal." },
            { "Names?!\r\nWe don't use names.\r\nFar too fancy for the likes of uz.", "Des blases ?!\r\nOn n'utilise point d'blases.\r\nBien trop chic pour des types comme nous." },
            { "We're just free an' easy. Sell what we like, live where we\r\nwanna live...", "On est juste peinards, quoi. On vend c'qui nous chante, on crèche\r\noù on veut..." },
            { "I g-give them all a vacant stare as they w-walk down\r\nFresno, and spin a few w-words into a verse for them.", "J-Je les fixe d'un œil vide quand ils d-dévalent\r\nFresno, et je leur t-tourne deux ou trois rimes." },
            { "Would I be right in assuming that all three of you make\r\nyour living by selling wares on the street?", "Ai-je raison de supposer que vous gagnez tous les trois\r\nvotre vie en vendant vos marchandises à la sauvette ?" },
            { "Hehe, everyone calls me Gossip. I sell jaunty little titbits\r\nto passers-by, you know.", "Héhé, tout l'monde m'appelle Ragot. J'refourgue des petits potins\r\ncroustillants aux passants, voyez." },
            { "Jaunty little titbits?", "Des petits potins croustillants ?" },
            { "Got an absolute smasher for you, sir.\r\nRight up your ginnel, it is!", "J'en ai un bien juteux pour vous, m'sieur.\r\nC'est du tout cuit pour vous !" },
            { "Sixpence is the price, and not a penny less!", "Six pence le morceau, et pas un liard de moins !" },
            { "Wait! You're, you're actually trying to sell it to me now?", "Attendez ! Vous... vous essayez vraiment de me le vendre là, maintenant ?" },
            { "Oh, c'mon sir! Don't tell me you're not interested!", "Oh, allez, m'sieur ! Ne venez pas dire que ça vous branche pas !" },
            { "Try the man.", "Mettez cet homme à l'épreuve." },
            { "Give him the money and see what it is!", "Donnez-lui la pièce et voyons ce que c'est !" },
            { "Pay the man, Counsel.", "Payez cet homme, Maître." },
            { "Alright, alright, sixpence it is.", "D'accord, d'accord, voici six pence." },
            { "You won't regret it, sir!\r\nNow, got your listenin' ears on?", "Vous l'regretterez pas, m'sieur !\r\nAlors, tendez bien vos esgourdes !" },
            { "Just between uz... a young couple on Sleight Street have\r\njust had twins!", "Rien qu'entre nous... un jeune couple de Sleight Street vient\r\nd'avoir des jumeaux !" },
            { "Um... is that it?", "Euh... c'est tout ?" },
            { "No, that's not it. It's gossip, in't it? It wants to spread.\r\nBut that bit's up to you and your mouth, of course.", "Ben non, c'est pas tout. C'est du ragot, pas vrai ? Faut qu'ça tourne !\r\nMais ça, ça dépend de vous et de vot' clapet, bien sûr." },
            { "I've got more, you know. Want another juicy one?\r\nSixpence a piece, it is. If you're curious...", "J'en ai d'autres en réserve, vous savez. Un autre bien salé ?\r\nSix pence la pièce. Si vous êtes curieux..." },
            { "(I am curious, yes. About what's going on just under that\r\nfat bottom lip of yours.)", "(Je suis curieux, oui. Surtout de savoir ce qui se trame juste sous\r\ncette grosse lèvre inférieure.)" },
            { "(Namely that unusual bruise or whatever it is that's\r\npoking out from under your collar...)", "(Notamment cette étrange marque ou cicatrice qui dépasse de\r\nvotre col...)" },
            { "What about the next witness, then?\r\nWhat name do you go by and what do you sell?", "Et le témoin suivant, à présent ?\r\nQuel nom portez-vous et que vendez-vous ?" },
            { "Me? I'm Venus. That's what everyone calls me.\r\nFunny, innit?", "Moi ? Je m'appelle Vénus. C'est comme ça qu'on m'appelle.\r\nRigolo, pas vrai ?" },
            { "I sell these lovely little fireworks to all the local school\r\nkids.", "J'vends ces chouettes petits pétards à tous les galopins du\r\ncoin." }
        });

        // [27] KEY:BB\script\output\_sce03_c102_0000_eng#3
        add(@"BB\script\output\_sce03_c102_0000_eng#3", new string[,] {
            { "Sixpence a pop!\r\nWhat d'you say?", "Six pence la mèche !\r\nQu'est-ce que t'en dis ?" },
            { "You weren't exaggerating with ‘little’.\r\nDo they actually sell?", "Vous n'exagériez pas avec « petits ».\r\nIls se vendent vraiment ?" },
            { "Oh yeah. The second years can't get enough of my Venus\r\nfirecrackers.", "Oh que ouais ! Les gosses de primaire s'arrachent mes pétards\r\nVénus." },
            { "'Specially when I tell 'em that if they get a hundred they\r\ncould blow up the school!", "Surtout quand j'leur raconte qu'avec une centaine, ils pourraient\r\nfaire sauter l'école !" },
            { "Not the most savoury of ideas, young lady.", "Idée des moins ragoûtantes, jeune fille." },
            { "What d'you say then, eh?\r\nWanna part with sixpence for a pop?", "Qu'est-ce que tu dis de ça, alors, hein ?\r\nTu lâches six pence pour un coup ?" },
            { "Wait, what?! You, you want me to buy one?", "Attendez, quoi ?! Vous... vous voulez que je vous en achète un ?" },
            { "Tell you what, I'll let you in on a little secret:\r\nIf you get a hundred of 'em, you could blow up the whole\r\ncourtroom!", "J'vais t'dire un truc, c'est mon p'tit secret :\r\nSi t'en prends une centaine, tu pourrais faire sauter toute la\r\nsalle d'audience !" },
            { "Try the woman.", "Mettez cette femme à l'épreuve." },
            { "Give her the money and see if she's right!", "Donnez-lui la pièce et vérifions si elle a raison !" },
            { "Pay the woman, Counsel.", "Payez cette femme, Maître." },
            { "Alright, alright, I'll buy one.", "D'accord, d'accord, j'en achète un." },
            { "Lovely stuff! Right then... this is something a bit extra, just\r\nfor you:\r\nThe Venus Special!\r\nOnly six 'undred pence!", "Parfait ! Alors voilà... un truc un peu spécial, rien que\r\npour toi :\r\nLe Spécial Vénus !\r\nSeulement six cents pence !" },
            { "S-Six hundred!", "S-Six cents ?!" },
            { "It's a hundred of my regular fireworks.\r\nNothing ‘little’ about that, is there?", "C'est une centaine de mes pétards normaux.\r\nY a rien de « petit » là-dedans, pas vrai ?" },
            { "(And there'd be nothing little about the punishment if I\r\nblew up the Old Bailey, either.)", "(Et la peine ne serait pas petite non plus si je faisais sauter\r\nl'Old Bailey...)" },
            { "The Venus firecracker has been\r\nentered into the Court Record.", "Le pétard Vénus a été\r\nversé au dossier de l'affaire." },
            { "And the last witness...\r\nWhat name do you go by and what do you sell?", "Et le dernier témoin...\r\nQuel nom portez-vous et quel est votre commerce ?" },
            { "I'm a th-thinker me. Think all sorts of thoughts.\r\nI think, therefore I am. I am, therefore I think...\r\nI think.", "J-Je suis un p-penseur, moi. J'ai toutes sortes de pensées.\r\nJe pense, donc je suis. Je suis, donc je pense...\r\nenfin, je crois." },
            { "Because I stand there on the street, w-watchin' the\r\nw-world go on about me, they call me ‘The Observator’.", "Comme je reste planté dans la rue, à r-regarder le\r\nm-monde défiler autour de moi, on m'appelle « L'Observateur »." },
            { "Get out of it, old man! Everyone calls you Sandwich and\r\nyou know it.", "Cause toujours, le vieux ! Tout l'monde t'appelle Sandwich et\r\ntu l'sais très bien !" },
            { "So... you don't actually sell anything?", "Ainsi... vous ne vendez absolument rien ?" },
            { "A p-p-problem shared is a problem halved, as they say.\r\nI give advice, I do. And think w-what it means.", "Un p-p-problème partagé est un problème allégé, comme on dit.\r\nJe donne des avis, moi. Et je m-médite sur ce que ça veut dire." },
            { "I d-don't actually sell anything, no... come to think of it.", "J-Je ne vends rien en vrai, non... à bien y songer." },
            { "Pity.", "Quel dommage." },
            { "(No more purchases today... please.)", "(Plus aucun achat aujourd'hui... par pitié.)" },
            { "Well, we have quite a cast here, it seems.", "Eh bien, nous avons là une belle brochette de personnages, semble-t-il." },
            { "They conduct their business on Fresno Street from\r\nmorning until night, My Lord.", "Ils exercent leur activité sur Fresno Street du matin\r\nau soir, Votre Honneur." },
            { "And always in the same place: directly adjacent to the\r\ncrime scene.", "Et toujours au même endroit : juste à côté de la\r\nscène de crime." },
            { "I see. And thus they heard the gunshot, I suppose.", "Je vois. Et c'est ainsi qu'ils ont entendu la détonation, je présume." },
            { "Not only that, but they very bravely ran inside to see\r\nwhat was going on and witnessed the crime.", "Non seulement cela, mais ils ont très courageusement couru à l'intérieur pour voir\r\nce qui se passait et ont été témoins du crime." },
            { "Well I'll be beggared, I thought!\r\n...Just between uz.", "J'suis tombé sur l'derrière, que j'me suis dit !\r\n...Rien qu'entre nous." },
            { "Venus de Milo, what am I to do?\r\nWhat a terrible thing I saw!", "Vénus de Milo, qu'est-ce que j'dois faire ?\r\nQuelle vision affreuse j'ai eue !" },
            { "W-What I think is... if all w-what we see is light and\r\nshadow, p-playing with our eyes... is any of it real?", "C-Ce que je pense, c'est que... si tout c-ce qu'on voit n'est qu'ombres\r\net lumières se j-jouant de nos yeux... est-ce bien réel ?" },
            { "Very well.\r\nThe court will hear the formal testimony of these three\r\nwitnesses now.", "Bien.\r\nLe tribunal va maintenant entendre la déposition solennelle de ces trois\r\ntémoins." },
            { "You will describe in detail what you witnessed and heard\r\nat the time of the incident.", "Vous allez décrire par le menu ce que vous avez vu et entendu\r\nau moment des faits." }
        });

        // [28] KEY:BB\script\output\_sce03_c102_0010_eng#2
        add(@"BB\script\output\_sce03_c102_0010_eng#2", new string[,] {
            { "– The Witnesses' Account –", "– La version des témoins –" },
            { "We saw the whole thing from start to finish, we did.\r\nEverything from the moment they went in the building.", "On a tout vu du début à la fin, pour de vrai.\r\nTout, dès la seconde où ils ont pénétré dans l'immeuble." },
            { "It was less than a minute after the Reaper had gone inside\r\nthat we all 'eard a big bang.", "C'était moins d'une minute après que le Faucheur est entré\r\nqu'on a tous entendu une grosse détonation." },
            { "Seems to m-me that quick-to-talk is quick-to-walk.\r\nGossip couldn't wait to go and see what had happened.", "Il m-me semble que prompt au verbe est prompt au pied.\r\nRagot ne tenait plus en place pour aller voir ce qui s'était passé." },
            { "I ran into the room and there he woz. The Reaper, gun in\r\nhand, standin' over the dead body!", "J'ai foncé dans la pièce et l'v'là. Le Faucheur, flingue en\r\nmain, planté au-dessus du cadavre !" },
            { "I was scared 'alf to death, me.\r\nSo I ran off to find a copper.", "Moi, j'étais morte de trouille.\r\nAlors j'ai filé dégoter un sergot." }
        });

        // [29] KEY:BB\script\output\_sce03_c102_0010_eng#3
        add(@"BB\script\output\_sce03_c102_0010_eng#3", new string[,] {
            { "If these witnesses were there the whole day and saw\r\neverything...\r\n...who did they see going inside the building?", "Si ces témoins sont restés là toute la journée et ont tout vu...\r\n...qui ont-ils vu entrer dans le bâtiment ?" },
            { "Only the victim, Inspector Gregson, and the accused,\r\nBarok van Zieks.", "Uniquement la victime, l'inspecteur Gregson, et l'accusé,\r\nDrake Van Peers." },
            { "I've seen pictures of that Reaper in the paper.\r\nI know what he looks like.", "J'ai reluqué ses portraits dans les gazettes.\r\nJ'sais bien quelle tête il a, l'Faucheur." },
            { "And just between uz... folk love stories like this.\r\nI've made meself a tidy sum already.", "Et rien qu'entre nous... l'populo raffole de ces histoires.\r\nJ'me suis déjà fait un joli petit magot." },
            { "But wait! The room was just one of several flats in the\r\nbuilding. Someone from another flat could have done it!", "Mais attendez ! Cette pièce n'était que l'un des appartements de\r\nl'immeuble. Quelqu'un d'un autre logement aurait pu faire le coup !" },
            { "All those flats on Fresno Street are unoccupied.", "Tous ces appartements de Fresno Street sont inoccupés." },
            { "'Course they are. They're small, damp, dirty and\r\nexpensive to boot.", "Tu m'étonnes ! Ils sont minuscules, humides, crasseux et\r\nruineux par-dessus le marché." },
            { "The room in which the inspector was found is the only\r\nproperty in the building that's currently leased.", "La pièce où gisait l'inspecteur est le seul logement de tout l'immeuble\r\nqui fasse actuellement l'objet d'un bail." },
            { "And we know the leaseholder's name, don't we.\r\nIt's... Hugh Boone.", "Et nous connaissons le nom du locataire, n'est-ce pas ?\r\nC'est... Hugh Boone." },
            { "The testimony the court has just heard would appear to\r\nleave little room for doubt.", "La déposition que le tribunal vient d'entendre semble laisser\r\nfort peu de place au doute." },
            { "It's becoming increasingly difficult to see how anyone\r\nother than the defendant could have committed the crime.", "Il devient de plus en plus malaisé de concevoir qu'un autre que\r\nl'accusé ait pu commettre ce meurtre." },
            { "No!", "Non !" },
            { "Thank you for your candour, My Lord.", "Merci pour votre franchise, Votre Honneur." },
            { "Counsel for the Defence, you may proceed to\r\ncross-examine the witnesses.", "Maître Naruhodo, vous pouvez procéder au contre-interrogatoire\r\ndes témoins." },
            { "Yes, My Lord!", "Bien, Votre Honneur !" },
            { "(In a closed court like this without a jury, the judge is the\r\nonly person whose opinion matters.)", "(Dans un procès à huis clos sans jury, le juge est la seule personne\r\ndont l'avis compte.)" },
            { "(I have to break down this testimony. Somehow!)", "(Je dois démolir cette déposition. Coûte que coûte !)" }
        });

        // [30] KEY:BB\script\output\_sce03_c102_0020_eng#2
        add(@"BB\script\output\_sce03_c102_0020_eng#2", new string[,] {
            { "– The Witnesses' Account –", "– La version des témoins –" }
        });

        // [31] KEY:BB\script\output\_sce03_c102_0020_eng#4
        add(@"BB\script\output\_sce03_c102_0020_eng#4", new string[,] {
            { "We saw the whole thing from start to finish, we did.\r\nEverything from the moment they went in the building.", "On a tout vu du début à la fin, pour de vrai.\r\nTout, dès la seconde où ils ont pénétré dans l'immeuble." }
        });

        // [32] KEY:BB\script\output\_sce03_c102_0020_eng#5
        add(@"BB\script\output\_sce03_c102_0020_eng#5", new string[,] {
            { "It was less than a minute after the Reaper had gone inside\r\nthat we all 'eard a big bang.", "C'était moins d'une minute après que le Faucheur est entré\r\nqu'on a tous entendu une grosse détonation." }
        });

        // [33] KEY:BB\script\output\_sce03_c102_0020_eng#6
        add(@"BB\script\output\_sce03_c102_0020_eng#6", new string[,] {
            { "Seems to m-me that quick-to-talk is quick-to-walk.\r\nGossip couldn't wait to go and see what had happened.", "Il m-me semble que prompt au verbe est prompt au pied.\r\nRagot ne tenait plus en place pour aller voir ce qui s'était passé." }
        });

        // [34] KEY:BB\script\output\_sce03_c102_0020_eng#7
        add(@"BB\script\output\_sce03_c102_0020_eng#7", new string[,] {
            { "I ran into the room and there he woz. The Reaper, gun in\r\nhand, standin' over the dead body!", "J'ai foncé dans la pièce et l'v'là. Le Faucheur, flingue en\r\nmain, planté au-dessus du cadavre !" }
        });

        // [35] KEY:BB\script\output\_sce03_c102_0020_eng#8
        add(@"BB\script\output\_sce03_c102_0020_eng#8", new string[,] {
            { "I slipped over and got blood on my hand, so I quickly\r\nwiped it off on the floor.", "J'ai glissé et j'ai eu du sang sur la paluche, alors j'l'ai vite\r\nessuyée sur l'plancher." }
        });

        // [36] KEY:BB\script\output\_sce03_c102_0020_eng#9
        add(@"BB\script\output\_sce03_c102_0020_eng#9", new string[,] {
            { "I was scared 'alf to death, me.\r\nSo I ran off to find a copper.", "Moi, j'étais morte de trouille.\r\nAlors j'ai filé dégoter un sergot." }
        });

        // [37] KEY:BB\script\output\_sce03_c102_0020_eng#10
        add(@"BB\script\output\_sce03_c102_0020_eng#10", new string[,] {
            { "(...If I can't find any holes in this testimony...)", "(...Si je ne trouve aucune faille dans cette déposition...)" },
            { "I'm afraid the judge will give a ruling of guilty,\r\nMr Naruhodo.", "J'ai bien peur que le juge ne prononce un verdict de culpabilité,\r\nmonsieur Naruhodo." },
            { "(The truth is, though, their combined testimony is fairly\r\ndamning.)", "(Il faut reconnaître que leurs témoignages combinés sont particulièrement\r\naccablants.)" },
            { "Unfortunately, there don't seem to be any obvious\r\nproblems with their statements, do there?", "Malheureusement, leurs déclarations ne semblent comporter aucune\r\nanomalie évidente, n'est-ce pas ?" },
            { "Still... if Lord van Zieks really is innocent, then I'm almost\r\ncertain...\r\n...that we'll find something in there that doesn't quite add\r\nup.", "Pourtant... si Lord Van Peers est réellement innocent, je suis presque\r\ncertain...\r\n...que nous dénicherons quelque chose qui cloche là-dedans." },
            { "You don't think...\r\n...that one of these three could be the true culprit,\r\ndo you?", "Vous ne pensez tout de même pas...\r\n...que l'un de ces trois-là pourrait être le véritable coupable ?" },
            { "I don't know. But what I do know...\r\n...is that there's more to this case that has yet to be\r\nbrought to light!", "Je l'ignore. Mais ce dont je suis sûr...\r\n...c'est que cette affaire recèle encore bien des mystères !" }
        });

        // [38] KEY:BB\script\output\_sce03_c102_0020_eng#11
        add(@"BB\script\output\_sce03_c102_0020_eng#11", new string[,] {
            { "When you say ‘they’, who do you mean exactly?\r\nInspector Gregson and the defendant, Lord van Zieks?", "Quand vous dites « ils », de qui parlez-vous exactement ?\r\nDe l'inspecteur Gregson et de l'accusé, Lord Van Peers ?" },
            { "I suppose so. The likes of uz don't know the names of the\r\nhigh and mighty.", "J'suppose, ouais. Les gens comme nous connaissent point les blases\r\ndes grands manitous." },
            { "But I'll tell you one thing... it was the old Reaper that went\r\nin last, that's for sure and certain.", "Mais j'vas vous dire un truc... c'est bien l'Faucheur qui est entré\r\nen dernier, ça c'est dur comme fer." },
            { "Just behind Inspector Gregson? Did they arrive at the\r\nsame time as each other?", "Juste derrière l'inspecteur Gregson ? Sont-ils arrivés en même\r\ntemps l'un et l'autre ?" },
            { "No no, not at all!\r\nThe first fella must have gone inside a good fifteen\r\nminutes before we heard that gunshot.", "Non non, pas du tout !\r\nLe premier gars a dû s'enfiler à l'intérieur un bon quart\r\nd'heure avant qu'on entende cette pétarade." },
            { "The victim arrived fifteen minutes before?!\r\nAre you sure about that?", "La victime est arrivée quinze minutes plus tôt ?!\r\nEn êtes-vous bien certain ?" },
            { "Am I sure? Am I sure?!\r\nDoz it seem likely that I'd have forgotten a fella with\r\nbright red hair like that, doz it?", "Si j'en suis sûr ? Si j'en suis sûr ?!\r\nVous croyez vraiment que j'aurais oublié un zigoto avec une tignasse\r\nrouge pétard pareille, sans blague ?" },
            { "Yeah, 'is hair really were red, weren't it? Redder than my\r\nflamin' fireworks, even.", "Ouais, ses tifs étaient drôlement rouges, pas vrai ? Plus rouges\r\nque mes pétards de compet', c'est dire." },
            { "That, that fiery red mop's still b-burnt on the inside of my\r\neyelids, it is.", "C-Cette tignasse rouge de braise est encore g-gravée au fer rouge\r\nsous mes paupières, pour sûr." },
            { "Wait a minute!\r\nYou're saying the man was a red-head?", "Attendez une minute !\r\nVous dites que cet homme était roux ?" },
            { "Weren't you listenin', chum? Aye, he woz a red-head.\r\nAnd he had a big trunk with him, as well.", "T'étais sourdingue, mon pote ? Ouaip, il était roux.\r\nEt il trimballait une sacrée grosse malle avec lui, en prime." },
            { "But Inspector Gregson's hair isn't red.\r\nNot by any stretch of the imagination!", "Mais l'inspecteur Gregson n'a absolument pas les cheveux roux !\r\nPas le moins du monde !" },
            { "It seems likely that the person you saw wasn't in fact\r\nInspector Gregson at all, but some other third party.", "Il paraît fort probable que la personne aperçue n'était point\r\nl'inspecteur Gregson, mais un tiers inconnu." },
            { "No. I hate to break it to you, but the witnesses are correct.", "Non. Je suis au regret de vous contredire, mais les témoins ont raison." },
            { "What?!", "Comment ?!" },
            { "Just have a look at this photograph of the victim taken at\r\nthe scene.", "Jetez simplement un regard sur cette photographie de la victime prise\r\nsur la scène de crime." },
            { "Y-Yes, that's...\r\n(That's Inspector Gregson alright.)", "O-Oui, c'est...\r\n(C'est bien l'inspecteur Gregson, pas d'erreur.)" },
            { "And... a red hairpiece.\r\nAh!", "Et... un postiche roux.\r\nAh !" },
            { "Of course! We saw one on the floor when we investigated\r\nthe scene, didn't we?", "Évidemment ! Nous en avons vu un sur le plancher lors de notre\r\ninspection des lieux, n'est-ce pas ?" },
            { "I still refuse to believe Inspector Gregson wore a hairpiece,\r\nthough...", "Je refuse toujours de croire que l'inspecteur Gregson portait une perruque..." },
            { "(So then why on earth would he have been wearing\r\nsomething like that?)", "(Pourquoi diable aurait-il bien pu s'affubler d'une chose pareille ?)" },
            { "Hm... the colour does seem to suit the man, one might\r\nsay...", "Hum... la teinte semblait pourtant lui aller à ravir, pourrait-on\r\ndire..." },
            { "The photograph will be submitted as evidence, please,\r\nCounsel.", "Veuillez verser la photographie au dossier à titre de preuve,\r\nmonsieur le procureur." },
            { "The photograph of the victim has been\r\nentered into the Court Record.", "La photographie de la victime a été\r\nversée au dossier de l'affaire." }
        });

        // [39] KEY:BB\script\output\_sce03_c102_0020_eng#12
        add(@"BB\script\output\_sce03_c102_0020_eng#12", new string[,] {
            { "And what became of the trunk that the red-headed\r\nvictim was supposedly carrying?", "Et qu'est devenue la malle que la victime rousse\r\nétait censée transporter ?" },
            { "...I was informed that no trunk was found at the scene.", "...J'ai été informé qu'aucune malle n'a été retrouvée sur les lieux." },
            { "(So it just disappeared?)", "(Elle a donc tout bonnement disparu ?)" },
            { "What, do you expect uz to have been watchin' the buildin'\r\nevery second, do you?", "Quoi, vous vous imaginiez qu'on surveillait la bicoque à chaque\r\nseconde, par hasard ?" },
            { "We definitely saw 'im in the dock goin' in, though.\r\nNo question about that!", "On l'a vu pour de bon franchir la porte, par contre.\r\nLà-dessus, y a pas l'ombre d'un doute !" }
        });

        // [40] KEY:BB\script\output\_sce03_c102_0020_eng#13
        add(@"BB\script\output\_sce03_c102_0020_eng#13", new string[,] {
            { "By which presumably you mean the gunshot?", "Par là, vous faites sans doute référence au coup de feu ?" },
            { "I sell these little things, don't I?\r\nHow would I know what a gunshot sounds like?", "Je vends ces p'tits machins, moi, pas vrai ?\r\nComment je saurais à quoi ressemble un coup d'pistolet ?" },
            { "But I've always thought it probably sounds a bit like this...\r\ndoesn't it?", "Mais j'ai toujours pensé que ça faisait un bruit dans ce genre-là...\r\nnon ?" },
            { "And you say that you heard the noise almost as soon as\r\nyou saw the defendant here enter the building?", "Et vous affirmez avoir entendu le bruit presque aussitôt après avoir\r\nvu l'accusé ici présent entrer dans l'immeuble ?" },
            { "That's right. It was almost straight away.\r\n‘Bang!’ it went. Just like that.", "C'est ça. Presque direct.\r\n« Pan ! » que ça a fait. Pile comme ça." },
            { "Well he's the Reaper, in't he? It's what the French call a\r\nfait accompli.", "Ben c'est l'Faucheur, non ? C'est ce que les Français appellent un\r\nfait accompli." },
            { "When the Reaper's around, people are goin' in the ground!\r\nI mean, that's what he doz, in't he?", "Quand l'Faucheur rapplique, les gens finissent au cimetière !\r\nC'est son gagne-pain après tout, pas vrai ?" },
            { "I think we get the message.", "Je crois que nous avons saisi l'idée." },
            { "The Reaper couldn't allow the inspector to live after he'd\r\ndiscovered his secret hideout.", "Le Faucheur ne pouvait laisser l'inspecteur en vie après la découverte\r\nde sa planque secrète." },
            { "There can be no clearer motive for the crime.", "Il ne saurait exister de mobile plus limpide pour ce forfait." },
            { "Hmmm... yes...\r\nIt's certainly an eminently credible motive.", "Hummm... oui...\r\nC'est à n'en pas douter un mobile éminemment crédible." },
            { "(Great.)", "(Formidable.)" },
            { "And at that point, you ran inside.\r\nIs that correct?", "Et à cet instant précis, vous avez accouru à l'intérieur.\r\nEst-ce exact ?" }
        });

        // [41] KEY:BB\script\output\_sce03_c102_0020_eng#14
        add(@"BB\script\output\_sce03_c102_0020_eng#14", new string[,] {
            { "So, when Gossip ran to see what had happened, did you\r\ngo, too?", "Alors, quand Ragot a couru voir ce qui s'était passé,\r\ny êtes-vous allé aussi ?" },
            { "W-Well me... I'm a b-bit hampered, see. All the signs are\r\nthat, that I c-can't move very well.", "B-Ben moi... je suis un p-peu encombré, voyez. Tous les signes m-montrent\r\nque, que je n-ne peux pas trop gigoter." },
            { "You were a way behind, presumably. With that sandwich\r\nboard around your neck and that big sign in your hand.", "Vous étiez loin derrière, vraisemblablement. Avec cette planche-sandwich\r\nautour du cou et cette grande pancarte à la main." },
            { "...What a great burden you bear.", "...Quel lourd fardeau vous portez là." },
            { "Pardon me for asking, Mr, erm... Sandwich, but...", "Pardonnez ma curiosité, monsieur, heu... Sandwich, mais..." },
            { "...is it possible you and I have met before?", "...serait-il possible que nous nous soyons déjà rencontrés ?" },
            { "I-I'm not anybody, me. The signs are w-what make me\r\nwho I am now. I sign, therefore I am.", "J-Je ne suis personne, moi. Les panneaux f-font ce que je suis\r\nmaintenant. Je panneautte, donc je suis." },
            { "So... you weren't employed as an omnibus driver just\r\nunder a year ago then?", "Ainsi... vous n'étiez pas employé comme cocher d'omnibus il y a\r\nà peine un an de cela ?" },
            { "I might be mistaken, but I believe his trembling has\r\nintensified, Mr Naruhodo.", "Je me trompe peut-être, mais j'ai l'impression que ses tremblements ont\r\nredoublé, monsieur Naruhodo." },
            { "Yes, I agree. He's clearly been through a lot.", "Oui, tout à fait. Il a visiblement traversé de rudes épreuves." },
            { "‘Turn down King Henry Street and the Black Widowers\r\nArms is just there.’", "« Prenez King Henry Street et l'auberge des Veufs Noirs\r\nest juste là. »" },
            { "Oh dear. You've made him hide behind his sign.", "Oh là là. Vous l'avez poussé à se tapir derrière sa pancarte." },
            { "(Life is full of surprises...)", "(La vie réserve bien des surprises...)" }
        });

        // [42] KEY:BB\script\output\_sce03_c102_0020_eng#15
        add(@"BB\script\output\_sce03_c102_0020_eng#15", new string[,] {
            { "So then you were the first person to arrive on the scene.\r\nIs that right?", "Vous étiez donc la première personne à arriver sur les lieux.\r\nEst-ce exact ?" },
            { "That I woz! Kicked the door open like a professional, I did!\r\nAnd yelled out, ‘What's goin' off 'ere?!’", "Et comment ! J'ai défoncé la porte comme un vrai pro !\r\nEt j'ai braillé : « Qu'est-ce qui s'passe là-dedans ?! »" },
            { "Lord van Zieks claims all he heard was a man's scream,\r\nthough.", "Pourtant, Lord Van Peers affirme n'avoir entendu que le hurlement d'un\r\nhomme." },
            { "And was it dark inside the room?", "Et faisait-il sombre à l'intérieur de la pièce ?" },
            { "No, not dark at all! There were candles burnin' on the\r\nwall.", "Non, pas sombre du tout ! Y avait des bougies allumées sur\r\nl'mur." },
            { "Really?!", "Vraiment ?!" },
            { "And there was a fella collapsed on the floor.", "Et y avait un bonhomme écroulé par terre." },
            { "Just between uz... it's the first thing I noticed when I got\r\ninside.", "Rien qu'entre nous... c'est la toute première chose que j'ai vue\r\nen entrant." },
            { "Ah. I, I see...", "Ah. Je... je vois..." },
            { "(Even though Lord van Zieks claims not to have seen any\r\nsuch lights on the wall...)", "(Même si Lord Van Peers affirme n'avoir vu aucune lumière sur\r\nles murs...)" },
            { "The next thing I noticed was someone standin' right\r\nbeside the body.", "L'autre truc que j'ai vu, c'est quelqu'un planté juste\r\nà côté du macchabée." },
            { "The accused, Barok van Zieks...", "L'accusé, Drake Van Peers..." },
            { "That's right! The pale-faced Reaper himself!", "C'est ça ! Le Faucheur au teint blafard en personne !" },
            { "I woz a little shocked, I won't deny it.\r\nBut I'm no lily-livered coward.", "J'ai eu un coup d'chaud, j'l'admets.\r\nMais j'suis pas du genre froussard." },
            { "I stood my ground and gave that Reaper a cold, hard\r\nstare myself!", "J'ai pas bronché et j'ai toisé ce Faucheur d'un regard noir et\r\nglacial !" },
            { "And was there anyone else in the room at the time?", "Et y avait-il quelqu'un d'autre dans la pièce à ce moment-là ?" },
            { "No, of course not.\r\nNot at first.", "Ben non, pardi !\r\nPas au début." },
            { "But then this old stiff came waddlin' along behind me, of\r\ncourse. Only him, mind.", "Mais après, ce vieux machin s'est pointé en dandinant derrière moi.\r\nPersonne d'autre que lui." },
            { "I, I can't handle stairs so well, as you can imagine.\r\nEspecially on the w-w-way up.", "J-Je supporte pas très bien les escaliers, comme vous vous en doutez.\r\nSurtout pour la m-m-montée." },
            { "And you couldn't have just failed to see someone?", "Et vous n'auriez pas pu manquer de voir quelqu'un d'autre ?" },
            { "It woz a bit dingy in there, I grant you.\r\nBut there were the candles on the wall. And the lamp on\r\nthe table.", "C'était un peu glauque là-dedans, j'vous l'accorde.\r\nMais y avait les bougies sur l'mur. Et la lampe sur la table." },
            { "There was n-nowhere anyone c-could have been hiding.\r\nYou m-mark my eyes!", "Il n'y avait n-nulle part où quelqu'un a-aurait pu se cacher.\r\nJ-J'en mettrais mes yeux à couper !" },
            { "(Ugh...)", "(Ouh là...)" }
        });

        // [43] KEY:BB\script\output\_sce03_c102_0020_eng#16
        add(@"BB\script\output\_sce03_c102_0020_eng#16", new string[,] {
            { "You wiped your hand on the floor?", "Vous avez essuyé votre main sur le plancher ?" },
            { "Well... who wants blood on his hand, eh? Horrible stuff.\r\nAnd they might have thought I'd done it. Hmph! No ta!", "Ben... qui a envie d'avoir du sang sur la paluche, hein ? C'est dégoûtant.\r\nEt ils auraient pu croire que c'était mon œuvre. Pff ! Sans façon !" },
            { "And you didn't think that might be a problem?", "Et vous ne vous êtes pas dit que cela poserait un problème ?" },
            { "Doz it really matter if I left a few grubby handprints on\r\nthe floor? They'll get cleaned up in the end, won't they?", "Qu'est-ce que ça peut ficher si j'ai collé deux ou trois traces crades\r\nsur l'plancher ? Ça s'nettoie, à la fin, non ?" },
            { "Don't make such a fuss, that's the message from all of uz!", "En faites pas tout un plat, c'est notre mot à tous !" },
            { "Is something wrong, Counsel?", "Un problème, monsieur le procureur ?" },
            { "No, My Lord.\r\nI didn't remember anything in the report about a bloody\r\nhandprint on the floor, that's all.", "Non, Votre Honneur.\r\nJe n'avais aucun souvenir d'une mention d'empreinte ensanglantée\r\nsur le plancher dans le rapport, c'est tout." },
            { "D-Don't come at me with all that!\r\nYou can't intimidate me!\r\nI know what I did! I wiped it off!\r\nOn the floor! The blood!", "M-Me cherchez pas des poux dans la tête !\r\nVous m'impressionnez pas !\r\nJ'sais c'que j'ai fait ! J'l'ai essuyée !\r\nSur l'sol ! La sauce rouge !" },
            { "(I wonder... Could that be what happened...?)", "(Je me demande... Serait-ce ce qui s'est réellement passé...?)" },
            { "Mr Naruhodo?\r\nI don't have all the answers yet...\r\n...but I think we may have just uncovered a vital clue!", "Monsieur Naruhodo ?\r\nJe n'ai pas encore toutes les réponses...\r\n...mais je crois que nous venons de déterrer un indice crucial !" }
        });

        // [44] KEY:BB\script\output\_sce03_c102_0020_eng#17
        add(@"BB\script\output\_sce03_c102_0020_eng#17", new string[,] {
            { "So you didn't run into the room with your friends?", "Alors vous n'avez pas accouru dans la pièce avec vos amis ?" },
            { "I'm not that sort of girl.", "J'suis pas l'genre de fille à faire ça." },
            { "Sorry?", "Pardon ?" },
            { "I'm a timid little thing, me.\r\nI was too scared to go in there.", "J'suis une p'tite chose timide, moi.\r\nJ'avais trop la frousse pour entrer." },
            { "Ah, right... I see.", "Ah, bien... je vois." },
            { "Old Lippy and the 'Wich ran in there, an' then I 'eard a\r\nsort of old lady scream.", "L'Gros Babines et l'Sandwich ont déboulé dedans, et puis j'ai entendu\r\nune espèce de cri de vieille bique." },
            { "Well that wozn't me, I swear. If I were a gentleman, I'd\r\nstake my honour on it.", "C'était pas moi, j'le jure ! Si j'étais un gentleman, j'en mettrais\r\nmon honneur en jeu." },
            { "I wondered what on earth was goin' on.", "J'me demandais bien c'qui pouvait s'goupiller là-dedans." },
            { "Which is when you went to find a policeman?", "C'est alors que vous êtes allée chercher un agent de police ?" },
            { "And I ran into a copper as soon as I turned the corner.\r\nSo I brought him straight back to the place.\r\n...Didn't I do well, eh?", "Et j'suis tombée sur un flic dès l'coin d'la rue.\r\nAlors j'l'ai ramené direct sur les lieux.\r\n...J'ai pas bien manœuvré, dis ?" },
            { "Just between uz... that copper's eyes nearly popped out of\r\nhis head when he saw the Reaper.", "Rien qu'entre nous... le poulet a failli perdre ses mirettes\r\nen apercevant le Faucheur." },
            { "I've n-n-never felt more uncomfortable in, in all my life.", "J-J'ai j-jamais été aussi mal à l'aise de toute ma vie." },
            { "And the defendant was arrested on the spot, I believe.", "Et l'accusé a été arrêté sur-le-champ, me semble-t-il." },
            { "Considering the catalogue of killings the Reaper had\r\ncarried out...\r\n...it was a particularly inauspicious end.", "Vu la longue liste d'assassinats que le Faucheur avait perpétrés...\r\n...ce fut une fin singulièrement peu glorieuse." }
        });

        // [45] KEY:BB\script\output\_sce03_c102_0020_eng#19
        add(@"BB\script\output\_sce03_c102_0020_eng#19", new string[,] {
            { "Do you have something to add, Mr Sandwich?!", "Avez-vous quelque chose à ajouter, monsieur Sandwich ?!" },
            { "There's, there's really n-n-nothing to me. Empty in the\r\nhead, I am. Just two slices with no middle.", "Y a, y a vraiment r-rien en moi. J'ai la caboche vide, moi.\r\nJuste deux tranches sans rien entre les deux." },
            { "S-So I don't know what you could w-w-want with me.", "A-Alors je sais pas c-ce que vous p-pouvez me vouloir." },
            { "I think that maybe you just remembered something?\r\nHaving heard Mr Gossip's last statement, I mean.", "Je pense que vous venez de vous rappeler quelque chose ?\r\nEn entendant la dernière déclaration de M. Ragot, je veux dire." },
            { "W-What I think is... we're all nothings really.\r\nWe try to d-dress ourselves up as something else, but at\r\nthe end of the day, w-we're all just street sellers.", "C-Ce que je pense, c'est qu'on est tous des riens, en vérité.\r\nOn essaie de s-se faire passer pour d'autres, mais au bout du\r\ncompte, on est tous que des marchands d'rue." },
            { "That's enough out of you, Sandwich.\r\nKeep your trap shut now.\r\nUnless you want uz to make you into a real sandwich!", "Ça suffit comme ça, Sandwich !\r\nBoucle ta boîte à camembert maintenant !\r\nÀ moins qu'tu veuilles qu'on fasse un vrai sandwich de ta carcasse !" },
            { "W-When he saw the Reaper, he f-f-fell clean over on his\r\nbackside!", "Q-Quand il a vu le Faucheur, il a f-f-fait un vol plané sur son\r\nderrière !" },
            { "...That's it?", "...C'est tout ?" },
            { "Oh, you rotten beggar!\r\nI told you to keep that a secret!", "Espèce de sale pourriture !\r\nJ't'avais dit d'garder ça secret !" },
            { "He screamed, he did. Screamed and s-scrambled off on\r\nall fours. ...That's all I w-w-wanted to say.", "Il a couiné, pour sûr. Couiné et d-déguerpi à quatre pattes.\r\n...C'est tout ce que je v-v-voulais dire." },
            { "Mr Gossip!\r\nIs this true?", "Monsieur Ragot !\r\nEst-ce la vérité ?" },
            { "The floor was dead slippery, that's why.\r\nPlanted my hand in a filthy pool of blood, didn't I?\r\nYuck!", "Le plancher était glissant comme pas deux, voilà pourquoi !\r\nJ'ai flanqué ma pogne dans une mare de sang bien répugnante !\r\nBerk !" },
            { "Wha...?! (<A pool of blood>?)", "Quoi... ?! (<Une mare de sang> ?)" },
            { "But listen here!\r\nEven when I woz sprawled on the floor...\r\n...I still kept giving that Reaper a cold, hard stare!\r\nAnd don't you forget it!", "Mais écoutez bien !\r\nMême quand j'étais étalé de tout mon long...\r\n...j'ai continué à fusiller ce Faucheur d'un regard noir et glacial !\r\nEt n'allez pas l'oublier !" },
            { "Let's just go back a little.\r\nDid you say you got blood on your hand?", "Revenons un peu en arrière.\r\nAvez-vous dit que vous aviez du sang sur la main ?" },
            { "I, I did, aye.\r\nHappens to the best of uz at times, dozn't it?\r\nSo I was scared! So I slipped over!\r\n...We can keep it just between uz, can't we?", "O-Oui, c'est vrai, ouaip.\r\nÇa arrive aux meilleurs d'entre nous, non ?\r\nAlors oui, j'ai eu la frousse ! Alors j'ai dérapé !\r\n...On peut garder ça rien qu'entre nous, pas vrai ?" },
            { "No, Mr Gossip! I'm going to have to ask you to add that\r\ninformation to your formal testimony.", "Non, monsieur Ragot ! Je vais devoir vous prier d'ajouter cette\r\nprécision à votre déposition solennelle." },
            { "Oh... If I must.", "Oh... Si c'est obligatoire." },
            { "The witness will amend his testimony to include the\r\naforementioned details at once.", "Le témoin va rectifier sa déposition sur-le-champ pour y inclure\r\nles détails susmentionnés." }
        });

        // [46] KEY:BB\script\output\_sce03_c102_0020_eng#20
        add(@"BB\script\output\_sce03_c102_0020_eng#20", new string[,] {
            { "Well, Miss Venus?!\r\nWhat do you say?", "Alors, mademoiselle Vénus ?!\r\nQu'avez-vous à dire ?" },
            { "I say that'll be six 'undred pennies.", "J'dis que ça f'ra six cents pennies." },
            { "Sorry?", "Pardon ?" },
            { "That's my banter on the street whenever anyone comes\r\nalong.", "C'est mon refrain dans la rue dès qu'un pigeon pointe son nez." },
            { "W-Well... this isn't Fresno Street.", "E-Eh bien... nous ne sommes pas sur Fresno Street." },
            { "Tsk! Miser!", "Pff ! Radin !" }
        });

        // [47] KEY:BB\script\output\_sce03_c102_0020_eng#21
        add(@"BB\script\output\_sce03_c102_0020_eng#21", new string[,] {
            { "Mr Gossip! Do you have something to say?", "Monsieur Ragot ! Avez-vous quelque chose à déclarer ?" },
            { "Mr Boone! Do you have something to say?", "Monsieur Boone ! Avez-vous quelque chose à déclarer ?" },
            { "I do as it happens! Your timing's perfect.\r\nI've just got wind of a juicy tale that'll be right up your\r\nsnicket.\r\nYou don't want to let this one slip by, I tell ya.\r\nAnd sixpence is all I ask...", "Figurez-vous que oui ! Vous tombez pile poil.\r\nJ'viens d'apprendre un tuyau en or qui va vous botter un max.\r\nFaut pas laisser filer ça, j'vous l'dis.\r\nEt six pence, c'est tout c'que j'demande..." },
            { "...Maybe try Prosecutor Asogi instead.", "...Essayez plutôt auprès du procureur Asogi." },
            { "I don't want your gossip, Ryunosuke Naruhodo.", "Je n'ai que faire de vos ragots, Ryunosuke Naruhodo." }
        });

        // [48] KEY:BB\script\output\_sce03_c102_0020_eng#22
        add(@"BB\script\output\_sce03_c102_0020_eng#22", new string[,] {
            { "Mr Sandwich! Do you perhaps have something to fill us in\r\nwith?", "Monsieur Sandwich ! Auriez-vous par hasard quelque chose à\r\nnous apprendre ?" },
            { "A w-wise philosopher once said that p-people are nothing\r\nmore than mindless signposts.", "Un s-sage philosophe a dit un jour que les g-gens ne sont rien de plus\r\nque des panneaux indicateurs sans âme." },
            { "Which means...\r\n...that signposts are n-nothing more than mindless\r\npeople... if you think about it.", "Ce qui signifie...\r\n...que les panneaux ne sont r-rien de plus que des gens sans cervelle...\r\nsi on y réfléchit bien." },
            { "Perhaps mind less about philosophy and mind more\r\nabout the proceedings?", "Peut-être devriez-vous délaisser la philosophie pour vous concentrer sur\r\nles débats ?" }
        });

        // [49] KEY:BB\script\output\_sce03_c102_0020_eng#29
        add(@"BB\script\output\_sce03_c102_0020_eng#29", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [50] KEY:BB\script\output\_sce03_c102_0030_eng#2
        add(@"BB\script\output\_sce03_c102_0030_eng#2", new string[,] {
            { "So you wiped off the blood from your hand on the floor\r\nof the room...\r\nAre you quite sure about that?", "Ainsi, vous avez essuyé le sang de votre main sur le plancher\r\nde la pièce...\r\nEn êtes-vous tout à fait certain ?" },
            { "Well, well what else d'you expect me to have done, eh?\r\nDoz it really matter?", "Ben, qu'est-ce que vous vouliez que j'fasse d'autre, hein ?\r\nÇa a tant d'importance que ça ?" },
            { "The police found no such handprint on the floor during\r\ntheir investigations.", "La police n'a trouvé aucune trace de main sur le sol\r\nau cours de ses constatations." },
            { "What exactly is the defence asserting?!", "Qu'affirme donc précisément la défense ?!" },
            { "If you listen, you'll find out... Prosecutor Asogi.", "Ouvrez grand vos oreilles et vous le saurez... procureur Asogi." },
            { "Certainly, there was no bloody handprint found... on the\r\nfloor.", "Certes, aucune empreinte ensanglantée n'a été relevée... sur le\r\nplancher." },
            { "What are you trying to say?", "Où voulez-vous en venir ?" },
            { "There was a handprint in blood left very clearly at the\r\nscene...\r\n...on the back of this noticeboard.", "Une empreinte de main sanglante a été très nettement laissée sur place...\r\n...au dos de ce tableau d'affichage." },
            { "Ah... ah... AAAAAAAAAAAAH!", "Ah... ah... AAAAAAAAAAAAH !" },
            { "Ah yes, indeed. Indisputably a handprint in the distinctive\r\ncolour of blood.", "Ah oui, en effet. Incontestablement une trace de main de la couleur\r\ncaractéristique du sang." },
            { "Aye, you're dead right! That's my right hand!\r\nI'd know it anywhere!", "Ouaip, vous avez tapé dans l'mille ! C'est ma pogne droite !\r\nJ'la reconnaîtrais entre mille !" },
            { "The witness very definitely testified that he wiped his\r\nhand on the floor.", "Le témoin a très clairement déposé qu'il avait essuyé sa main\r\nsur le plancher." },
            { "Any handprints on the back of the board are irrelevant!", "Toute trace au dos de ce tableau est sans pertinence !" },
            { "Not if the board itself had fallen over onto the floor.", "Pas si le tableau lui-même s'était effondré sur le sol." },
            { "In that case, it's quite possible for the witness's handprint\r\nto have ended up there.", "Dans ce cas, il est tout à fait possible que l'empreinte du témoin\r\ns'y soit déposée." },
            { "...Just look at the floor plan of the room.", "...Regardez simplement le plan de la pièce." },
            { "The noticeboard was in the opposite corner of the room\r\nto the victim, and in an upright position.", "Le tableau se trouvait dans le coin opposé à la victime,\r\net en position verticale." },
            { "Even if it had somehow been toppled and was lying on\r\nthe floor at the time...", "Même s'il s'était renversé et gisait sur le sol à cet instant..." },
            { "...it would have been a considerable distance from the\r\nbody.", "...il se serait trouvé à une distance considérable du corps." },
            { "I fell over when I came across the body.\r\nSo I woz basically right next to the corpse.\r\nNot on the other side of the room!", "J'ai basculé quand je suis tombé nez à nez avec le corps.\r\nJ'étais donc carrément collé au macchabée.\r\nPas à l'autre bout de la turne !" },
            { "In other words, the defence's assertion is contradictory!", "En d'autres termes, l'affirmation de la défense est contradictoire !" },
            { "Yes... it is.", "Oui... c'est vrai." },
            { "There's a very definite contradiction here... for which\r\nthere must be a reason.", "Il y a une contradiction indéniable ici... qui doit avoir\r\nune explication." }
        });

        // [51] KEY:BB\script\output\_sce03_c102_0040_eng#2
        add(@"BB\script\output\_sce03_c102_0040_eng#2", new string[,] {
            { "I take it that you've formulated a proper hypothesis,\r\nCounsel?", "Dois-je comprendre que vous avez formulé une hypothèse valable,\r\nMaître ?" },
            { "Regarding this apparent discrepancy between the\r\nwitness's account and the handprint found at the scene.", "Concernant cette apparente divergence entre le récit du témoin\r\net l'empreinte relevée sur les lieux ?" },
            { "I have, My Lord.", "Tout à fait, Votre Honneur." }
        });

        // [52] KEY:BB\script\output\_sce03_c102_0040_eng#3
        add(@"BB\script\output\_sce03_c102_0040_eng#3", new string[,] {
            { "This discrepancy between the witness's account and the\r\nlocation of the handprint is explained by...", "Cette divergence entre le récit du témoin et l'emplacement\r\nde l'empreinte s'explique par..." }
        });

        // [53] KEY:BB\script\output\_sce03_c102_0040_eng#4
        add(@"BB\script\output\_sce03_c102_0040_eng#4", new string[,] {
            { "If Mr Gossip ended up with blood on his hand and wiped\r\nit off on the floor as he says...", "Si M. Ragot a eu du sang sur la main et l'a essuyée sur le\r\nsol comme il le prétend..." },
            { "...it must have left behind a mark somewhere.", "...cela a dû laisser une trace quelque part." },
            { "Just as a mark has been left behind on the back of the\r\nnoticeboard.", "Tout comme une trace a été laissée au dos du panneau\r\nd'affichage." },
            { "The prosecution has already established that the\r\nhandprint on the board is irrelevant.", "L'accusation a déjà démontré que l'empreinte sur le panneau\r\nest hors de propos." },
            { "Exactly! Which means there must be another handprint\r\nsomewhere!", "Exactement ! Ce qui implique qu'il doit y avoir une autre trace\r\nquelque part !" },
            { "No! The police report made no mention of a handprint\r\nanywhere on the floor!", "Non ! Le rapport de police ne fait mention d'aucune empreinte\r\nsur le plancher !" },
            { "And I understand that you've examined the scene in\r\nperson, too.", "Et si j'ai bien compris, vous avez également inspecté les lieux\r\nen personne." },
            { "If you'd come across something the police had missed...\r\nhow do you explain the cold sweat?", "Si vous aviez déniché ce que la police a manqué...\r\ncomment expliquez-vous ces sueurs froides ?" },
            { "Quite. The defence counsel's cold sweat is a sure\r\nindication that a penalty is due.", "En effet. Les sueurs froides de l'avocat de la défense indiquent sans\r\nambiguïté qu'une pénalité s'impose." },
            { "That sweat was just from the warm-up.", "Cette sueur ne provenait que de l'échauffement." },
            { "What?", "Quoi ?" },
            { "There should be a bloody handprint on the floor.\r\nSo where did it go...?", "Il devrait y avoir une empreinte sanglante sur le plancher.\r\nOù a-t-elle bien pu passer... ?" },
            { "I'm ready to give the proper explanation to the court now,\r\nMy Lord!", "Je suis prêt à fournir la véritable explication au tribunal,\r\nVotre Honneur !" }
        });

        // [54] KEY:BB\script\output\_sce03_c102_0040_eng#5
        add(@"BB\script\output\_sce03_c102_0040_eng#5", new string[,] {
            { "The real contradiction here is the handprint itself, not\r\nwhere it was found.", "La véritable contradiction ici réside dans l'empreinte elle-même,\r\net non dans son emplacement." },
            { "As the court can see... it's upside down.", "Comme le tribunal peut le constater... elle est la tête en bas." },
            { "Good gracious! So it is!", "Bonté divine ! C'est tout à fait vrai !" },
            { "If the witness had put his hand against the board, the\r\nfingers should be pointing upwards.", "Si le témoin avait appuyé sa main contre le tableau dressé,\r\nles doigts devraient pointer vers le haut." },
            { "What, what does that tell us?", "Qu'est-ce que cela nous révèle ?" },
            { "It tells one simple fact!\r\nWhen this handprint was made...\r\n...the board must have been lying on the floor as I\r\npreviously suggested.", "Cela révèle un fait fort simple !\r\nLorsque cette empreinte a été apposée...\r\n...le tableau devait être étendu sur le sol comme je l'avais\r\nsuggéré !" },
            { "Which means that after the incident... it must have been\r\nmoved!", "Ce qui signifie qu'après les faits... il a nécessairement été\r\ndéplacé !" },
            { "You're claiming that somebody moved the noticeboard\r\nafter the shooting?\r\nThen tell the court who!", "Vous soutenez que quelqu'un a déplacé le panneau d'affichage\r\naprès les coups de feu ?\r\nAlors dites au tribunal qui l'a fait !" },
            { "I, I don't know that yet!\r\nBut the point is...", "Je... je ne le sais pas encore !\r\nMais le fait est..." },
            { "...when you consider all the testimony we've heard so far,\r\nwe can now be very clear on one point!", "...qu'au vu de tous les témoignages entendus jusqu'ici,\r\nun fait est désormais parfaitement limpide !" },
            { "And that would be...?", "Et quel serait ce fait... ?" },
            { "The position of the noticeboard at the time of the incident,\r\nMy Lord.", "La position du panneau d'affichage au moment du drame,\r\nVotre Honneur." }
        });

        // [55] KEY:BB\script\output\_sce03_c102_0040_eng#6
        add(@"BB\script\output\_sce03_c102_0040_eng#6", new string[,] {
            { "The witness claims to have wiped his bloody hand on the\r\nfloor, yet no sign of that remains at the scene.", "Le témoin prétend avoir essuyé sa main ensanglantée sur le plancher,\r\npourtant aucune trace n'en subsiste sur les lieux." },
            { "The simplest explanation is that the witness is lying.", "L'explication la plus simple est que le témoin ment." },
            { "Just because it's the simplest explanation doesn't make it\r\nthe correct one... Ryunosuke Naruhodo.", "Ce n'est pas parce que c'est l'explication la plus simple qu'elle est\r\nla bonne... Ryunosuke Naruhodo." },
            { "Ah.", "Ah." },
            { "Positing perjury simply because it suits you...", "Invoquer le parjure simplement parce que cela vous arrange..." },
            { "You bring shame on your Japanese heritage!", "Vous couvrez de honte vos origines japonaises !" },
            { "AAAAAAAAARGH!", "AAAAAAAAARGH !" },
            { "I would ask you not to oversimplify matters again,\r\nCounsel.", "Je vous saurais gré de ne pas simplifier les choses à l'excès,\r\nMaître." },
            { "I don't remember fostering that kind of simplistic thinking\r\nin you.", "Je n'ai pas le souvenir d'avoir encouragé un tel simplisme en\r\nvous." },
            { "...Since when were you my father?", "...Depuis quand êtes-vous mon père ?" },
            { "Anyway, I was always taught to consider all possibilities.", "Quoi qu'il en soit, on m'a toujours enseigné d'envisager toutes les hypothèses." },
            { "Then show me.", "Alors prouvez-le-moi." },
            { "There should be a bloody handprint on the floor. \r\nSo where did it go...?", "Il devrait y avoir une trace ensanglantée sur le sol.\r\nOù a-t-elle bien pu passer... ?" },
            { "I'm ready to give the proper explanation to the court now, \r\nMy Lord!", "Je suis prêt à fournir la bonne explication au tribunal,\r\nVotre Honneur !" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(@"tools\Trans_Ep4_Act3_Part2.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Trans_Ep4_Act3_Part2.cs generated successfully!");
    }
}
