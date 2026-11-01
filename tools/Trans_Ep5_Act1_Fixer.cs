using System;
using System.Collections.Generic;

namespace TranslatorEp5Act1 {
    public partial class Program {
        public static void RegisterFixes() {
            // [1] _sce04_c100_0000_eng#9
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#9"] = (s) => {
                s = s.Replace("If for some reason you completely run out of options in\r\nthe trial today...", "Si jamais vous vous retrouvez à court d'idées pendant\r\nle procès aujourd'hui...");
                s = s.Replace("If for some reason you completely run out of options in\nthe trial today...", "Si jamais vous vous retrouvez à court d'idées pendant\nle procès aujourd'hui...");
                s = s.Replace("...then just pull this little Hurley's ears ", "... tirez simplement sur les oreilles de ce petit Hurley ");
                s = s.Replace("as hard as you\r\npossibly can!", "de toutes vos\r\nforces !");
                s = s.Replace("as hard as you\npossibly can!", "de toutes vos\nforces !");
                return s;
            };

            // [2] _sce04_c100_0000_eng#10
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#10"] = (s) => {
                s = s.Replace("Wha...?", "Quoi... ?");
                s = s.Replace("Pull his ears?", "Tirer sur ses oreilles ?");
                s = s.Replace("That's right!", "C'est ça !");
                s = s.Replace("It's a way to bring good luck.", "Ça porte chance.");
                s = s.Replace("...I think you might need it!", "... Et je crois que vous allez en avoir besoin !");
                s = s.Replace("Iris's lucky charm has been\r\nentered into the Court Record.", "Le porte-bonheur d'Iris a été\r\najouté au dossier de l'affaire.");
                s = s.Replace("Iris's lucky charm has been\nentered into the Court Record.", "Le porte-bonheur d'Iris a été\najouté au dossier de l'affaire.");
                s = s.Replace("Y-<E003 8><E025 3>You think...<E049><E003 6><E145 3 68><E003 6>what we'll need is luck...?", "V-<E003 8><E025 3>Vous pensez...<E049><E003 6><E145 3 68><E003 6>qu'on aura besoin de chance... ?");
                s = s.Replace("I just sneaked a peek inside the courtroom.", "J'ai jeté un coup d'œil discret dans la salle d'audience.");
                s = s.Replace("And...<E003 10><E025 2>it seemed very different to normal.", "Et...<E003 10><E025 2>l'ambiance semblait bien différente de d'habitude.");
                s = s.Replace("Yes, <E049><E003 8>it would seem...", "Oui, <E049><E003 8>il semblerait...");
                s = s.Replace("...that a certain someone has decided to pull out all the\r\nstops.", "... qu'une certaine personne a décidé de sortir le grand\r\njeu.");
                s = s.Replace("...that a certain someone has decided to pull out all the\nstops.", "... qu'une certaine personne a décidé de sortir le grand\njeu.");
                s = s.Replace("What does that mean?", "Qu'est-ce que ça veut dire ?");
                s = s.Replace("What about Mr Sholmes, <E049><E003 6><E025 3>Iris?", "Où est M. Sholmes, <E049><E003 6><E025 3>Iris ?");
                s = s.Replace("I...<E003 10>don't know.<E049><E003 15> <E145 4 74><E003 6><E025 2>He was out all night and he hadn't come\r\nhome by the time I left this morning.", "Je...<E003 10>l'ignore.<E049><E003 15> <E145 4 74><E003 6><E025 2>Il a passé la nuit dehors et n'était pas rentré\r\nquand je suis partie ce matin.");
                s = s.Replace("I...<E003 10>don't know.<E049><E003 15> <E145 4 74><E003 6><E025 2>He was out all night and he hadn't come\nhome by the time I left this morning.", "Je...<E003 10>l'ignore.<E049><E003 15> <E145 4 74><E003 6><E025 2>Il a passé la nuit dehors et n'était pas rentré\nquand je suis partie ce matin.");
                s = s.Replace("Oh...<E049><E003 8> <E025 3><E145 3 72><E003 4>I see...", "Oh...<E049><E003 8> <E025 3><E145 3 72><E003 4>je vois...");
                s = s.Replace("Was Professor Mikotoba out all night too, do you think,<E003 8>\r\n<E025 3>Miss Susato?", "Le professeur Mikotoba a-t-il découché lui aussi, selon vous,<E003 8>\r\n<E025 3>Mlle Susato ?");
                s = s.Replace("Was Professor Mikotoba out all night too, do you think,<E003 8>\n<E025 3>Miss Susato?", "Le professeur Mikotoba a-t-il découché lui aussi, selon vous,<E003 8>\n<E025 3>Mlle Susato ?");
                s = s.Replace("Yes, <E049><E003 8>it would seem so.<E049><E003 12> <E025 2>I telegrammed the hotel this\r\nmorning...", "Oui, <E049><E003 8>c'est fort probable.<E049><E003 12> <E025 2>J'ai envoyé un télégramme à l'hôtel ce\r\nmatin...");
                s = s.Replace("Yes, <E049><E003 8>it would seem so.<E049><E003 12> <E025 2>I telegrammed the hotel this\nmorning...", "Oui, <E049><E003 8>c'est fort probable.<E049><E003 12> <E025 2>J'ai envoyé un télégramme à l'hôtel ce\nmatin...");
                s = s.Replace("...and apparently they didn't come back to their rooms last\r\nnight at all.", "... et ils ne sont visiblement pas rentrés dans leur chambre\r\nde la nuit.");
                s = s.Replace("...and apparently they didn't come back to their rooms last\nnight at all.", "... et ils ne sont visiblement pas rentrés dans leur chambre\nde la nuit.");
                s = s.Replace("‘They’?", "« Ils » ?");
                s = s.Replace("Father <E049><E003 13><E333>and Judge Jigoku, <E049><E003 6>I mean.", "Mon père <E049><E003 13><E333>et le juge Jigoku, <E049><E003 6>je veux dire.");
                s = s.Replace("Judge Jigoku, too?", "Le juge Jigoku également ?");
                s = s.Replace("That's right.<E049><E003 10> <E145 3 77>Nobody appears to have seen either of them\r\nsince yesterday.", "Tout à fait.<E049><E003 10> <E145 3 77>Personne ne semble les avoir vus\r\ndepuis hier.");
                s = s.Replace("That's right.<E049><E003 10> <E145 3 77>Nobody appears to have seen either of them\nsince yesterday.", "Tout à fait.<E049><E003 10> <E145 3 77>Personne ne semble les avoir vus\ndepuis hier.");
                s = s.Replace("Counsel for the Defence and the defendant!", "L'avocat de la défense et l'accusé !");
                s = s.Replace("Court is about to be in session.<E049><E003 12>\r\n<E025 1><E332>Please make your way inside the courtroom at once!", "L'audience est sur le point de s'ouvrir.<E049><E003 12>\r\n<E025 1><E332>Veuillez rejoindre la salle d'audience immédiatement !");
                s = s.Replace("Court is about to be in session.<E049><E003 12>\n<E025 1><E332>Please make your way inside the courtroom at once!", "L'audience est sur le point de s'ouvrir.<E049><E003 12>\n<E025 1><E332>Veuillez rejoindre la salle d'audience immédiatement !");
                s = s.Replace("Good luck then, Runo!<E049><E003 10>\r\nGood luck, Susie!", "Bonne chance alors, Runo !<E049><E003 10>\r\nBonne chance, Susie !");
                s = s.Replace("Good luck then, Runo!<E049><E003 10>\nGood luck, Susie!", "Bonne chance alors, Runo !<E049><E003 10>\nBonne chance, Susie !");
                s = s.Replace("Yes...<E049><E003 12><E025 2>thanks, Iris.", "Merci...<E049><E003 12><E025 2>Iris.");
                s = s.Replace("And you, Mr Reaper.<E049><E003 12>\r\n<E025 1>I hope it goes well!", "Et vous aussi, m'sieur le Faucheur.<E049><E003 12>\r\n<E025 1>J'espère que tout se passera bien !");
                s = s.Replace("And you, Mr Reaper.<E049><E003 12>\n<E025 1>I hope it goes well!", "Et vous aussi, m'sieur le Faucheur.<E049><E003 12>\n<E025 1>J'espère que tout se passera bien !");
                s = s.Replace("Once again, <E049><E003 8><E025 2>I thank you for the delicious tea.<E049><E003 12>\r\nIt was very soothing.", "Une fois encore, <E049><E003 8><E025 2>je vous remercie pour ce délicieux thé.<E049><E003 12>\r\nIl était très réconfortant.");
                s = s.Replace("Once again, <E049><E003 8><E025 2>I thank you for the delicious tea.<E049><E003 12>\nIt was very soothing.", "Une fois encore, <E049><E003 8><E025 2>je vous remercie pour ce délicieux thé.<E049><E003 12>\nIl était très réconfortant.");
                s = s.Replace("Oh, <E049><E003 8><E025 1>I'm so glad!", "Oh, <E049><E003 8><E025 1>j'en suis tellement heureuse !");
                s = s.Replace("We must go inside now, <E049><E003 8><E025 1><E145 3 92><E118 3 0.7><E003 8>Lord van Zieks!", "Nous devons entrer maintenant, <E049><E003 8><E025 1><E145 3 92><E118 3 0.7><E003 8>Lord Van Peers !");
                s = s.Replace("Hm...", "Hum...");
                s = s.Replace("(Lord van Zieks has always been the formidable\r\nprosecutor I've had to lock horns with in court.)", "(Lord Van Peers a toujours été le redoutable\r\nprocureur auquel j'ai dû me confronter au tribunal.)");
                s = s.Replace("(Lord van Zieks has always been the formidable\nprosecutor I've had to lock horns with in court.)", "(Lord Van Peers a toujours été le redoutable\nprocureur auquel j'ai dû me confronter au tribunal.)");
                s = s.Replace("(But not today.<E003 12> <E025 3>Today <E003 6>I battle with another in pursuit of\r\nthe truth.)", "(Mais pas aujourd'hui.<E003 12> <E025 3>Aujourd'hui, <E003 6>c'est avec un autre que je combats\r\npour la vérité.)");
                s = s.Replace("(But not today.<E003 12> <E025 3>Today <E003 6>I battle with another in pursuit of\nthe truth.)", "(Mais pas aujourd'hui.<E003 12> <E025 3>Aujourd'hui, <E003 6>c'est avec un autre que je combats\npour la vérité.)");
                s = s.Replace("(My best friend, <E003 6>Kazuma Asogi, <E003 10><E025 2>who I trust more than\r\nanyone else in the world.)", "(Mon meilleur ami, <E003 6>Kazuma Asogi, <E003 10><E025 2>en qui j'ai plus confiance\r\nqu'en quiconque au monde.)");
                s = s.Replace("(My best friend, <E003 6>Kazuma Asogi, <E003 10><E025 2>who I trust more than\nanyone else in the world.)", "(Mon meilleur ami, <E003 6>Kazuma Asogi, <E003 10><E025 2>en qui j'ai plus confiance\nqu'en quiconque au monde.)");
                s = s.Replace("(Now I understand what it was that drew me here to\r\nBritain all those months ago.)", "(À présent, je comprends ce qui m'a guidé vers la\r\nGrande-Bretagne il y a tant de mois.)");
                s = s.Replace("(Now I understand what it was that drew me here to\nBritain all those months ago.)", "(À présent, je comprends ce qui m'a guidé vers la\nGrande-Bretagne il y a tant de mois.)");
                s = s.Replace("(Now I know exactly what destiny had in store for me.)", "(Je sais désormais exactement ce que le destin me réservait.)");
                s = s.Replace("(It's all been leading up to this one day...<E003 12>\r\n<E025 2>To this one trial...<E003 12> <E025 1><E338><E341>To this one final reckoning!)", "(Tout convergeait vers cet unique jour...<E003 12>\r\n<E025 2>Vers ce seul procès...<E003 12> <E025 1><E338><E341>Vers cet ultime règlement de comptes !)");
                s = s.Replace("(It's all been leading up to this one day...<E003 12>\n<E025 2>To this one trial...<E003 12> <E025 1><E338><E341>To this one final reckoning!)", "(Tout convergeait vers cet unique jour...<E003 12>\n<E025 2>Vers ce seul procès...<E003 12> <E025 1><E338><E341>Vers cet ultime règlement de comptes !)");
                return s;
            };

            // [3] _sce04_c101_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0000_eng#2"] = (s) => {
                s = s.Replace("3rd November, 9:30 a.m.", "3 novembre, 9 h 30");
                s = s.Replace("The Old Bailey Courtroom", "Tribunal de l'Old Bailey");
                s = s.Replace("It feels even more oppressive here than it did yesterday...", "L'ambiance semble encore plus pesante qu'hier...");
                s = s.Replace("(There are cold stares piercing me like knives from all\r\nsides today.)", "(Des regards glacials me transpercent de toutes parts\r\naujourd'hui.)");
                s = s.Replace("(There are cold stares piercing me like knives from all\nsides today.)", "(Des regards glacials me transpercent de toutes parts\naujourd'hui.)");
                s = s.Replace("M-<E049><E003 8><E025 1><E341>Mr Naruhodo!<E049><E003 16><E335> Look!", "M-<E049><E003 8><E025 1><E341>M. Naruhodo !<E049><E003 16><E335> Regardez !");
                s = s.Replace("Lord Stronghart!", "Lord Stronghart !");
                s = s.Replace("(Kazuma must have known beforehand...)", "(Kazuma devait le savoir à l'avance...)");
                s = s.Replace("The ramifications of this trial now extend far beyond the\r\nmurder of one Scotland Yard inspector.", "Les répercussions de ce procès dépassent de loin le meurtre\r\nd'un inspecteur de Scotland Yard.");
                s = s.Replace("The ramifications of this trial now extend far beyond the\nmurder of one Scotland Yard inspector.", "Les répercussions de ce procès dépassent de loin le meurtre\nd'un inspecteur de Scotland Yard.");
                s = s.Replace("In fact, <E049><E003 8><E025 2>events have come to light that threaten to rock\r\nthe very foundations of our country's legal system.", "En vérité, <E049><E003 8><E025 2>des faits ont été révélés qui menacent\r\nd'ébranler les fondements mêmes de notre système judiciaire.");
                s = s.Replace("In fact, <E049><E003 8><E025 2>events have come to light that threaten to rock\nthe very foundations of our country's legal system.", "En vérité, <E049><E003 8><E025 2>des faits ont été révélés qui menacent\nd'ébranler les fondements mêmes de notre système judiciaire.");
                s = s.Replace("The escape of a condemned criminal on the night of his\r\nexecution...<E003 10>the subsequent unlawful shooting of the man...", "L'évasion d'un condamné à mort la nuit de son exécution...<E003 10>\r\npuis son assassinat illégal par arme à feu...");
                s = s.Replace("The escape of a condemned criminal on the night of his\nexecution...<E003 10>the subsequent unlawful shooting of the man...", "L'évasion d'un condamné à mort la nuit de son exécution...<E003 10>\npuis son assassinat illégal par arme à feu...");
                s = s.Replace("...and the revelation<E049><E003 10> that prison staff must have been\r\ncomplicit in the jailbreak.", "... et la révélation<E049><E003 10> de la complicité probable du personnel\r\npénitentiaire dans cette évasion.");
                s = s.Replace("...and the revelation<E049><E003 10> that prison staff must have been\ncomplicit in the jailbreak.", "... et la révélation<E049><E003 10> de la complicité probable du personnel\npénitentiaire dans cette évasion.");
                s = s.Replace("Britain is currently hosting influential members of the\r\njudiciary from countries all around the world.", "La Grande-Bretagne accueille actuellement d'éminents membres\r\nde la magistrature venus du monde entier.");
                s = s.Replace("Britain is currently hosting influential members of the\njudiciary from countries all around the world.", "La Grande-Bretagne accueille actuellement d'éminents membres\nde la magistrature venus du monde entier.");
                s = s.Replace("It is imperative <E049><E003 8><E025 2>that we uncover the truth in these\r\nproceedings to avoid international embarrassment.", "Il est impératif <E049><E003 8><E025 2>de faire toute la lumière au cours\r\nde ces débats pour éviter un scandale international.");
                s = s.Replace("It is imperative <E049><E003 8><E025 2>that we uncover the truth in these\nproceedings to avoid international embarrassment.", "Il est impératif <E049><E003 8><E025 2>de faire toute la lumière au cours\nde ces débats pour éviter un scandale international.");
                s = s.Replace("By royal decree, <E049><E003 8><E025 2>this will continue to be a closed trial...", "Par décret royal, <E049><E003 8><E025 2>ce procès continuera de se tenir à huis clos...");
                s = s.Replace("...and one over which I, <E049><E003 6>Mael Stronghart, <E049><E003 8><E164 61 12 1 2 5 0 2 1><E118 61 1.2><E139 61><E025 1>exercise total\r\nand unequivocal authority.", "... sous la présidence de ma personne, <E049><E003 6>Mael Stronghart, <E049><E003 8><E164 61 12 1 2 5 0 2 1><E118 61 1.2><E139 61><E025 1>qui\r\nexercerai une autorité totale et absolue.");
                s = s.Replace("...and one over which I, <E049><E003 6>Mael Stronghart, <E049><E003 8><E164 61 12 1 2 5 0 2 1><E118 61 1.2><E139 61><E025 1>exercise total\nand unequivocal authority.", "... sous la présidence de ma personne, <E049><E003 6>Mael Stronghart, <E049><E003 8><E164 61 12 1 2 5 0 2 1><E118 61 1.2><E139 61><E025 1>qui\nexercerai une autorité totale et absolue.");
                s = s.Replace("The, <E049><E003 8><E338><E341><E025 1>the six jurors' flames just...", "Les, <E049><E003 8><E338><E341><E025 1>les flammes des six jurés viennent de...");
                s = s.Replace("As was the case in yesterday's proceedings, <E049><E003 8>those here\r\npresent in the public gallery...", "Comme lors de l'audience d'hier, <E049><E003 8>les personnes présentes\r\ndans la tribune du public...");
                s = s.Replace("As was the case in yesterday's proceedings, <E049><E003 8>those here\npresent in the public gallery...", "Comme lors de l'audience d'hier, <E049><E003 8>les personnes présentes\ndans la tribune du public...");
                s = s.Replace("...are distinguished members of our judiciary, <E049><E003 6><E145 61 7><E118 61 0.6><E003 6><E025 3>assembled\r\nto bear witness to a fair judicial process.", "... sont d'illustres membres de notre magistrature, <E049><E003 6><E145 61 7><E118 61 0.6><E003 6><E025 3>réunis pour\r\ntémoigner de l'équité du cours de la justice.");
                s = s.Replace("...are distinguished members of our judiciary, <E049><E003 6><E145 61 7><E118 61 0.6><E003 6><E025 3>assembled\nto bear witness to a fair judicial process.", "... sont d'illustres membres de notre magistrature, <E049><E003 6><E145 61 7><E118 61 0.6><E003 6><E025 3>réunis pour\ntémoigner de l'équité du cours de la justice.");
                s = s.Replace("In other words...<E049><E003 10><E025 3><E145 18 3><E118 18 0.5><E003 10><E330>a collection of your acolytes,<E049><E003 8> Lord\r\nStronghart.", "En d'autres termes...<E049><E003 10><E025 3><E145 18 3><E118 18 0.5><E003 10><E330>un rassemblement de vos acolytes,<E049><E003 8> Lord\r\nStronghart.");
                s = s.Replace("In other words...<E049><E003 10><E025 3><E145 18 3><E118 18 0.5><E003 10><E330>a collection of your acolytes,<E049><E003 8> Lord\nStronghart.", "En d'autres termes...<E049><E003 10><E025 3><E145 18 3><E118 18 0.5><E003 10><E330>un rassemblement de vos acolytes,<E049><E003 8> Lord\nStronghart.");
                s = s.Replace("On a personal note, <E049><E003 8>I find this most distressing, Lord van\r\nZieks.", "À titre personnel, <E049><E003 8>j'en suis navré au plus haut point, Lord Van\r\nPeers.");
                s = s.Replace("On a personal note, <E049><E003 8>I find this most distressing, Lord van\nZieks.", "À titre personnel, <E049><E003 8>j'en suis navré au plus haut point, Lord Van\nPeers.");
                s = s.Replace("You were a prosecutor of exceptional talent.", "Vous étiez un procureur au talent exceptionnel.");
                s = s.Replace("Much like your brother Klint <E049><E003 6>in fact...", "Tout comme votre frère Clint <E049><E003 6>en vérité...");
                return s;
            };

            // [4] _sce04_c101_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0020_eng#2"] = (s) => {
                s = s.Replace("State your name and occupation for the court.", "Déclinez votre nom et profession pour la cour.");
                s = s.Replace("Inspector Gina Lestrade,<E003 10> reportin'!\r\n<E025 2>Reper...<E003 14><E025 1><E046>sentive o' Scotland Yard!", "Inspectrice Gina Lestrade,<E003 10> au rapport !\r\n<E025 2>Repré...<E003 14><E025 1><E046>sentante de Scotland Yard !");
                s = s.Replace("Inspector Gina Lestrade,<E003 10> reportin'!\n<E025 2>Reper...<E003 14><E025 1><E046>sentive o' Scotland Yard!", "Inspectrice Gina Lestrade,<E003 10> au rapport !\n<E025 2>Repré...<E003 14><E025 1><E046>sentante de Scotland Yard !");
                s = s.Replace("...A self-conferred rank, <E049><E003 6><E025 2>but never mind.", "... Un titre autoproclamé, <E049><E003 6><E025 2>mais passons.");
                s = s.Replace("(Gina?<E003 10> Again?)", "(Gina ?<E003 10> Encore ?)");
                s = s.Replace("Wot's yer problem, 'Oddo?", "C'est quoi ton problème, Naruhodo ?");
                s = s.Replace("Wot's wiv that <E049><E003 8><E330>‘Gina?<E049><E003 10> Again?’<E049><E003 12> <E145 122 71><E117 122 6><E335><E025 1>look,<E003 8> eh?", "C'est quoi cet air de faire <E049><E003 8><E330>« Gina ?<E049><E003 10> Encore ? »<E049><E003 12> <E145 122 71><E117 122 6><E335><E025 1>hein ?<E003 8>");
                s = s.Replace("The boss meant the world to me.<E049><E003 6>\r\n<E025 1><E164 122 72 1 2 9 0 2 1><E118 122 1.2><E139 122>'E done more for me than anyone else ever did!", "L'patron, c'était tout pour moi.<E049><E003 6>\r\n<E025 1><E164 122 72 1 2 9 0 2 1><E118 122 1.2><E139 122>Y a fait plus pour moi que n'importe qui d'autre !");
                s = s.Replace("The boss meant the world to me.<E049><E003 6>\n<E025 1><E164 122 72 1 2 9 0 2 1><E118 122 1.2><E139 122>'E done more for me than anyone else ever did!", "L'patron, c'était tout pour moi.<E049><E003 6>\n<E025 1><E164 122 72 1 2 9 0 2 1><E118 122 1.2><E139 122>Y a fait plus pour moi que n'importe qui d'autre !");
                s = s.Replace("Inspector Gregson, <E049><E003 6>you mean?", "L'inspecteur Gregson, <E049><E003 6>voulez-vous dire ?");
                s = s.Replace("'E got me out the back slums o' the East End<E049><E003 6> <E025 3>an' took me\r\nunder 'is wing.", "Y m'a sortie des taudis d'l'East End<E049><E003 6> <E025 3>et m'a prise sous son\r\naile.");
                s = s.Replace("'E got me out the back slums o' the East End<E049><E003 6> <E025 3>an' took me\nunder 'is wing.", "Y m'a sortie des taudis d'l'East End<E049><E003 6> <E025 3>et m'a prise sous son\naile.");
                s = s.Replace("Taught me that life can 'ave a purpose.", "Y m'a appris qu'la vie pouvait avoir un sens.");
                s = s.Replace("So that's why<E049><E003 4> <E025 1><E164 122 72 1 2 8 0 1 1><E118 122 1.2><E139 122>I'm the best person to be standin' 'ere<E003 10>\r\nspeakin' for 'im!", "C'est pour ça qu'<E049><E003 4><E025 1><E164 122 72 1 2 8 0 1 1><E118 122 1.2><E139 122>chuis la mieux placée pour me tenir là<E003 10>\r\net parler pour lui !");
                s = s.Replace("So that's why<E049><E003 4> <E025 1><E164 122 72 1 2 8 0 1 1><E118 122 1.2><E139 122>I'm the best person to be standin' 'ere<E003 10>\nspeakin' for 'im!", "C'est pour ça qu'<E049><E003 4><E025 1><E164 122 72 1 2 8 0 1 1><E118 122 1.2><E139 122>chuis la mieux placée pour me tenir là<E003 10>\net parler pour lui !");
                s = s.Replace("Oh Gina...", "Oh Gina...");
                s = s.Replace("(Right,<E003 8> all out of the goodness of Gregson's heart.<E003 10> <E025 2>Not at\r\nall that he had his arm twisted by Mr Sholmes.<E003 8> <E025 3>No...)", "(C'est ça,<E003 8> par pure bonté de cœur de Gregson.<E003 10> <E025 2>Pas du\r\ntout parce que M. Sholmes lui a forcé la main.<E003 8> <E025 3>Non...)");
                s = s.Replace("(Right,<E003 8> all out of the goodness of Gregson's heart.<E003 10> <E025 2>Not at\nall that he had his arm twisted by Mr Sholmes.<E003 8> <E025 3>No...)", "(C'est ça,<E003 8> par pure bonté de cœur de Gregson.<E003 10> <E025 2>Pas du\ntout parce que M. Sholmes lui a forcé la main.<E003 8> <E025 3>Non...)");
                s = s.Replace("What's relevant to these proceedings<E049><E003 8> is that the outcome\r\nof Scotland Yard's investigations yesterday...", "Ce qui importe pour cette cour,<E049><E003 8> c'est que l'enquête menée\r\nhier par Scotland Yard...");
                s = s.Replace("What's relevant to these proceedings<E049><E003 8> is that the outcome\nof Scotland Yard's investigations yesterday...", "Ce qui importe pour cette cour,<E049><E003 8> c'est que l'enquête menée\nhier par Scotland Yard...");
                s = s.Replace("...has revealed that the victim was carrying out some\r\nassignment the police knew nothing about.", "... a révélé que la victime menait une mission dont la police\r\nignorait tout.");
                s = s.Replace("...has revealed that the victim was carrying out some\nassignment the police knew nothing about.", "... a révélé que la victime menait une mission dont la police\nignorait tout.");
                s = s.Replace("Very troubling...", "Fort troublant...");
                s = s.Replace("(That face...)", "(Cette expression...)");
                s = s.Replace("(Lord Stronghart knew!)", "(Lord Stronghart le savait !)");
                s = s.Replace("So...<E049><E003 12><E025 1>Inspector Lestrade!", "Alors...<E049><E003 12><E025 1>Inspectrice Lestrade !");
                s = s.Replace("Let's hear exactly what it says in that report!", "Voyons voir ce que contient exactement ce rapport !");
                s = s.Replace("Comin' right up, sir!", "Ça vient, m'sieur !");
                return s;
            };

            // [5] _sce04_c101_0030_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0030_eng#2"] = (s) => {
                s = s.Replace("– The Victim's Movements –", "– Les déplacements de la victime –");
                s = s.Replace("All Yard detectives are s'posed to follow orders an'\r\ninvestigate wot they're told.", "Tous les inspecteurs du Yard sont censés obéir aux ordres\r\net enquêter sur c'qu'on leur dit.");
                s = s.Replace("All Yard detectives are s'posed to follow orders an'\ninvestigate wot they're told.", "Tous les inspecteurs du Yard sont censés obéir aux ordres\net enquêter sur c'qu'on leur dit.");
                s = s.Replace("But a little search o' the boss's office <E049><E003 6>turned up a notebook\r\nthat 'ad a load of secret meetin's in it.", "Mais une p'tite fouille du bureau du patron <E049><E003 6>a permis d'trouver\r\nun carnet plein d'rendez-vous secrets.");
                s = s.Replace("But a little search o' the boss's office <E049><E003 6>turned up a notebook\nthat 'ad a load of secret meetin's in it.", "Mais une p'tite fouille du bureau du patron <E049><E003 6>a permis d'trouver\nun carnet plein d'rendez-vous secrets.");
                s = s.Replace("Accordin' to that, <E049><E003 10><E330>the boss was lookin' into some smuggled\r\ngoods dealin's that day.", "D'après c'qui est écrit, <E049><E003 10><E330>l'patron enquêtait sur un trafic\r\nde contrebande ce jour-là.");
                s = s.Replace("Accordin' to that, <E049><E003 10><E330>the boss was lookin' into some smuggled\ngoods dealin's that day.", "D'après c'qui est écrit, <E049><E003 10><E330>l'patron enquêtait sur un trafic\nde contrebande ce jour-là.");
                s = s.Replace("Looks like it was a big job an' all.<E049><E003 10> But the coppers weren't\r\non to it yet.", "On dirait qu'c'était une grosse affaire.<E049><E003 10> Mais la police était\r\npas encore au courant.");
                s = s.Replace("Looks like it was a big job an' all.<E049><E003 10> But the coppers weren't\non to it yet.", "On dirait qu'c'était une grosse affaire.<E049><E003 10> Mais la police était\npas encore au courant.");
                s = s.Replace("Wot matters most is, <E049><E003 4><E164 122 72 1 2 1 0 2 1><E118 122 1.2><E139 122><E025 1>there's witnesses wot saw the Reaper\r\nat the place, too!", "C'qui compte le plus, <E049><E003 4><E164 122 72 1 2 1 0 2 1><E118 122 1.2><E139 122><E025 1>c'est qu'des témoins ont vu le Faucheur\r\nsur les lieux, lui aussi !");
                s = s.Replace("Wot matters most is, <E049><E003 4><E164 122 72 1 2 1 0 2 1><E118 122 1.2><E139 122><E025 1>there's witnesses wot saw the Reaper\nat the place, too!", "C'qui compte le plus, <E049><E003 4><E164 122 72 1 2 1 0 2 1><E118 122 1.2><E139 122><E025 1>c'est qu'des témoins ont vu le Faucheur\nsur les lieux, lui aussi !");
                return s;
            };

            // [6] _sce04_c101_0040_eng#12
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#12"] = (s) => {
                s = s.Replace("Do you have any idea <E145 1 85>where those dealings were taking\r\nplace?", "Avez-vous la moindre idée de l'endroit <E145 1 85>où ces transactions\r\ndevaient avoir lieu ?");
                s = s.Replace("Do you have any idea <E145 1 85>where those dealings were taking\nplace?", "Avez-vous la moindre idée de l'endroit <E145 1 85>où ces transactions\ndevaient avoir lieu ?");
                s = s.Replace("Yup!<E049><E003 10> <E025 2><E145 122 89><E139 122><E060 0 153 0 0><E025 1>It was all there in the boss's notes!", "Ouaip !<E049><E003 10> <E025 2><E145 122 89><E139 122><E060 0 153 0 0><E025 1>Tout était écrit dans les notes du patron !");
                s = s.Replace("Let's see if I can remember...<E003 10> <E169 5 0><E025 4>Erm...<E169 5 3>", "Voyons voir si j'peux m'souvenir...<E003 10> <E169 5 0><E025 4>Euh...<E169 5 3>");
                s = s.Replace("As I already said, <E049><E003 8>the illegal dealings were due to take\r\nplace at a gentleman's club.", "Comme je l'ai déjà dit, <E049><E003 8>cette transaction illégale devait\r\nse dérouler dans un club pour gentlemen.");
                s = s.Replace("As I already said, <E049><E003 8>the illegal dealings were due to take\nplace at a gentleman's club.", "Comme je l'ai déjà dit, <E049><E003 8>cette transaction illégale devait\nse dérouler dans un club pour gentlemen.");
                s = s.Replace("Yes, <E049><E003 8>I remember.<E049><E003 10> <E145 1 1>But I was hoping to find out the name of\r\nthe club.", "Oui, <E049><E003 8>je m'en souviens.<E049><E003 10> <E145 1 1>Mais j'espérais apprendre le nom de ce\r\nclub.");
                s = s.Replace("Yes, <E049><E003 8>I remember.<E049><E003 10> <E145 1 1>But I was hoping to find out the name of\nthe club.", "Oui, <E049><E003 8>je m'en souviens.<E049><E003 10> <E145 1 1>Mais j'espérais apprendre le nom de ce\nclub.");
                s = s.Replace("That won't be necessary.", "Ce ne sera pas nécessaire.");
                s = s.Replace("What?!", "Comment ?!");
                s = s.Replace("It's conceivable that the club might be used again by the\r\nsmugglers in future.", "Il est envisageable que ce club soit de nouveau utilisé par\r\nles contrebandiers à l'avenir.");
                s = s.Replace("It's conceivable that the club might be used again by the\nsmugglers in future.", "Il est envisageable que ce club soit de nouveau utilisé par\nles contrebandiers à l'avenir.");
                s = s.Replace("Therefore...<E049><E003 12><E025 2>the prosecution has been asked not to reveal\r\nthe name in these proceedings.", "Par conséquent...<E049><E003 12><E025 2>l'accusation a reçu l'ordre de ne pas\r\ndivulguer ce nom au cours de l'audience.");
                s = s.Replace("Therefore...<E049><E003 12><E025 2>the prosecution has been asked not to reveal\nthe name in these proceedings.", "Par conséquent...<E049><E003 12><E025 2>l'accusation a reçu l'ordre de ne pas\ndivulguer ce nom au cours de l'audience.");
                s = s.Replace("I dunno wot all the fuss is about.<E049><E003 15>\r\n<E025 2><E136 122 74 25><E117 122 20><E003 10><E060 0 153 0 0>It's right 'ere.<E049><E003 12> All I've gotta do is read it out.", "J'vois pas pourquoi vous faites des histoires.<E049><E003 15>\r\n<E025 2><E136 122 74 25><E117 122 20><E003 10><E060 0 153 0 0>C'est écrit là.<E049><E003 12> J'ai juste à l'lire tout haut.");
                s = s.Replace("I dunno wot all the fuss is about.<E049><E003 15>\n<E025 2><E136 122 74 25><E117 122 20><E003 10><E060 0 153 0 0>It's right 'ere.<E049><E003 12> All I've gotta do is read it out.", "J'vois pas pourquoi vous faites des histoires.<E049><E003 15>\n<E025 2><E136 122 74 25><E117 122 20><E003 10><E060 0 153 0 0>C'est écrit là.<E049><E003 12> J'ai juste à l'lire tout haut.");
                s = s.Replace("An' I could, too!<E049><E003 12>\r\n<E025 1>I've got this readin' game buttoned up now!", "Et j'pourrais l'faire !<E049><E003 12>\r\n<E025 1>La lecture, j'maîtrise ça les doigts dans l'nez maintenant !");
                s = s.Replace("An' I could, too!<E049><E003 12>\n<E025 1>I've got this readin' game buttoned up now!", "Et j'pourrais l'faire !<E049><E003 12>\n<E025 1>La lecture, j'maîtrise ça les doigts dans l'nez maintenant !");
                s = s.Replace("Can't I show ya wot I can do?<E049><E003 12>\r\n<E025 2>Go on, <E049><E003 6>wot's the 'arm?", "J'peux pas vous montrer c'que j'sais faire ?<E049><E003 12>\r\n<E025 2>Allez, <E049><E003 6>quel mal y a-t-il ?");
                s = s.Replace("Can't I show ya wot I can do?<E049><E003 12>\n<E025 2>Go on, <E049><E003 6>wot's the 'arm?", "J'peux pas vous montrer c'que j'sais faire ?<E049><E003 12>\n<E025 2>Allez, <E049><E003 6>quel mal y a-t-il ?");
                s = s.Replace("(The judge hasn't signalled his objection yet.)", "(Le président n'a pas encore signalé son objection.)");
                s = s.Replace("(I could try to find out...<E003 12>\r\n<E025 2>What should I do?)", "(Je pourrais essayer d'en savoir plus...<E003 12>\r\n<E025 2>Que dois-je faire ?)");
                s = s.Replace("(I could try to find out...<E003 12>\n<E025 2>What should I do?)", "(Je pourrais essayer d'en savoir plus...<E003 12>\n<E025 2>Que dois-je faire ?)");
                return s;
            };

            // [7] _sce04_c101_0040_eng#17
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#17"] = (s) => {
                s = s.Replace("Lord van Zieks was at the club?", "Lord Van Peers était au club ?");
                s = s.Replace("He was.", "En effet.");
                s = s.Replace("Detectives who visited the club yesterday to make\r\ninquiries have confirmed it.", "Les inspecteurs envoyés enquêter au club hier\r\nl'ont confirmé.");
                s = s.Replace("Detectives who visited the club yesterday to make\ninquiries have confirmed it.", "Les inspecteurs envoyés enquêter au club hier\nl'ont confirmé.");
                s = s.Replace("Several members report having seen the accused being\r\nadmitted to the room in question as a guest.", "Plusieurs membres ont affirmé avoir vu l'accusé entrer\r\ndans la salle en question en qualité d'invité.");
                s = s.Replace("Several members report having seen the accused being\nadmitted to the room in question as a guest.", "Plusieurs membres ont affirmé avoir vu l'accusé entrer\ndans la salle en question en qualité d'invité.");
                s = s.Replace("(It looks like there's no disputing that he was there then.)", "(Sa présence semble donc indiscutable.)");
                s = s.Replace("Well we know that Lord van Zieks was investigating\r\nInspector Gregson, <E049><E003 4>don't we?", "Nous savons bien que Lord Van Peers enquêtait sur\r\nl'inspecteur Gregson, <E049><E003 4>n'est-ce pas ?");
                s = s.Replace("Well we know that Lord van Zieks was investigating\nInspector Gregson, <E049><E003 4>don't we?", "Nous savons bien que Lord Van Peers enquêtait sur\nl'inspecteur Gregson, <E049><E003 4>don't we?");
                s = s.Replace("Perhaps he'd already discovered the inspector's secret\r\nnotebook.", "Peut-être avait-il déjà découvert le carnet secret\r\nde l'inspecteur.");
                s = s.Replace("Perhaps he'd already discovered the inspector's secret\nnotebook.", "Peut-être avait-il déjà découvert le carnet secret\nde l'inspecteur.");
                s = s.Replace("(Which led him to the club, you mean?<E003 12>\r\n<E025 3>Maybe...)", "(Ce qui l'aurait conduit au club, tu penses ?<E003 12>\r\n<E025 3>Peut-être...)");
                s = s.Replace("(Which led him to the club, you mean?<E003 12>\n<E025 3>Maybe...)", "(Ce qui l'aurait conduit au club, tu penses ?<E003 12>\n<E025 3>Peut-être...)");
                s = s.Replace("Presumably then, <E049><E003 10><E330>there are also eyewitnesses who can\r\ntestify that Gregson was there?", "On imagine alors <E049><E003 10><E330>qu'il y a des témoins oculaires pour\r\nattester de la présence de Gregson ?");
                s = s.Replace("Presumably then, <E049><E003 10><E330>there are also eyewitnesses who can\ntestify that Gregson was there?", "On imagine alors <E049><E003 10><E330>qu'il y a des témoins oculaires pour\nattester de la présence de Gregson ?");
                s = s.Replace("None have been identified at this time, <E049><E003 8><E025 3>no.", "Aucun témoin n'a été identifié pour l'heure, <E049><E003 8><E025 3>non.");
                s = s.Replace("(So the all-important victim wasn't seen at this mysterious\r\nclub...)", "(Ainsi, personne n'a vu la victime dans ce mystérieux\r\nclub...)");
                s = s.Replace("(So the all-important victim wasn't seen at this mysterious\nclub...)", "(Ainsi, personne n'a vu la victime dans ce mystérieux\nclub...)");
                s = s.Replace("Oi!<E049><E003 12> <E335>Why ain't you askin' Inspector Lestrade 'ere, <E049><E003 6>eh?", "Hé !<E049><E003 12> <E335>Pourquoi vous d'mandez pas à l'inspectrice Lestrade,<E049><E003 6> hein ?");
                return s;
            };

            // [8] _sce04_c101_0040_eng#18
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#18"] = (s) => {
                s = s.Replace("(So that's all I've got to work with...)", "(C'est donc tout ce que j'ai sous la main...)");
                s = s.Replace("(Gina's not holding back with that ice-cold stare of hers,<E003 8>\r\nis she?)", "(Gina ne retient pas son regard glacial,<E003 8>\r\nà ce que je vois.)");
                s = s.Replace("(Gina's not holding back with that ice-cold stare of hers,<E003 8>\nis she?)", "(Gina ne retient pas son regard glacial,<E003 8>\nis she?)");
                s = s.Replace("I really don't know what to make of all this.", "Je ne sais vraiment pas quoi penser de tout cela.");
                s = s.Replace("Lord van Zieks told us that he was investigating Inspector\r\nGregson...", "Lord Van Peers nous a confié qu'il enquêtait sur\r\nl'inspecteur Gregson...");
                s = s.Replace("Lord van Zieks told us that he was investigating Inspector\nGregson...", "Lord Van Peers nous a confié qu'il enquêtait sur\nl'inspecteur Gregson...");
                s = s.Replace("...but he never once mentioned that he met the inspector\r\nthe day before the incident.", "... mais il n'a jamais dit qu'il avait rencontré l'inspecteur\r\nla veille du drame.");
                s = s.Replace("...but he never once mentioned that he met the inspector\nthe day before the incident.", "... mais il n'a jamais dit qu'il avait rencontré l'inspecteur\nla veille du drame.");
                s = s.Replace("You don't think Lord van Zieks could have been lying to\r\nus, <E049><E003 6>do you?", "Vous ne croyez pas que Lord Van Peers ait pu nous\r\nmentir, <E049><E003 6>si ?");
                s = s.Replace("You don't think Lord van Zieks could have been lying to\nus, <E049><E003 6>do you?", "Vous ne croyez pas que Lord Van Peers ait pu nous\nmentir, <E049><E003 6>si ?");
                s = s.Replace("...That's not the only way to explain this.", "... Ce n'est pas la seule explication possible.");
                s = s.Replace("If everything Lord van Zieks <E145 9 17><E117 9 25>has told us is true...", "Si tout ce que Lord Van Peers <E145 9 17><E117 9 25>nous a dit est vrai...");
                s = s.Replace("...then there must be <E006>a mistake<E005> in this testimony\r\nsomewhere.", "... alors il doit y avoir <E006>une faille<E005> dans ce témoignage\r\nquelque part.");
                s = s.Replace("...then there must be <E006>a mistake<E005> in this testimony\nsomewhere.", "... alors il doit y avoir <E006>une faille<E005> dans ce témoignage\nquelque part.");
                s = s.Replace("You mean, <E049><E003 10><E025 3>there are details we've yet to uncover?", "Vous voulez dire <E049><E003 10><E025 3>qu'il y a des détails encore ignorés ?");
                s = s.Replace("Exactly.", "Exactement.");
                s = s.Replace("(<E006>A clue<E007> perhaps, <E003 8><E025 3>that even Gina hasn't noticed.)", "(<E006>Un indice<E007> peut-être, <E003 8><E025 3>auquel même Gina n'a pas fait attention.)");
                s = s.Replace("(That's what we should be looking for here!)", "(C'est exactement ce que nous devons chercher !)");
                return s;
            };

            // [9] _sce04_c101_0040_eng#26
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#26"] = (s) => {
                s = s.Replace("We've wasted enough time!", "Nous avons perdu assez de temps !");
                s = s.Replace("It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.", "Il est clair à mes yeux <E049><E003 8><E025 2>que prolonger les débats sur\r\ncette affaire ne mènera à rien.");
                s = s.Replace("It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\nbe fruitless.", "Il est clair à mes yeux <E049><E003 8><E025 2>que prolonger les débats sur\ncette affaire ne mènera à rien.");
                s = s.Replace("Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...", "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que même si vos actes\r\nétaient dévoyés...");
                s = s.Replace("Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\nmisguided...", "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que même si vos actes\nétaient dévoyés...");
                s = s.Replace("...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...", "... vous avez agi par soif de justice.<E049><E003 12>\r\n<E025 3>Même s'il m'est pénible d'aboutir à une telle conclusion...");
                s = s.Replace("...you acted out of a sense of justice nonetheless.<E049><E003 12>\n<E025 3>Though it pains me to have reached this conclusion...", "... vous avez agi par soif de justice.<E049><E003 12>\n<E025 3>Même s'il m'est pénible d'aboutir à une telle conclusion...");
                s = s.Replace("No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!", "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                s = s.Replace("No!<E049><E003 8>\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!", "Non !<E049><E003 8>\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                s = s.Replace("In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "Au vu des éléments apportés devant cette cour, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                s = s.Replace("In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "Au vu des éléments apportés devant cette cour, <E049><E003 6><E025 3>je déclare\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                s = s.Replace("That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!", "L'affaire est close.<E049><E003 10>\r\n<E025 2>La séance est levée !");
                s = s.Replace("That concludes business.<E049><E003 10>\n<E025 2>Court is adjourned!", "L'affaire est close.<E049><E003 10>\n<E025 2>La séance est levée !");
                return s;
            };

            // [10] _sce04_c101_0060_eng#6
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#6"] = entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#26"];

            // [11] _sce04_c101_0070_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0070_eng#2"] = (s) => {
                s = s.Replace("We also arrived at the same conclusion, <E049><E003 6>didn't we?", "Nous sommes aussi arrivés à la même conclusion, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("That Inspector Gregson was operating as the Reaper.", "Que l'inspecteur Gregson opérait en tant que Faucheur.");
                s = s.Replace("Even so...<E003 10><E025 2>there's no way that the person giving him his\r\norders...", "Malgré tout...<E003 10><E025 2>il est inconcevable que le donneur\r\nd'ordres...");
                s = s.Replace("Even so...<E003 10><E025 2>there's no way that the person giving him his\norders...", "Malgré tout...<E003 10><E025 2>il est inconcevable que le donneur\nd'ordres...");
                s = s.Replace("...was Lord van Zieks!<E003 2><E145 9 13><E118 9 0.7><E003 18>\r\n<E025 3><E007>(No, <E003 8><E025 3><E338><E341>the true Reaper is somebody else...)", "... soit Lord Van Peers !<E003 2><E145 9 13><E118 9 0.7><E003 18>\r\n<E025 3><E007>(Non, <E003 8><E025 3><E338><E341>le véritable Faucheur est quelqu'un d'autre...)");
                s = s.Replace("...was Lord van Zieks!<E003 2><E145 9 13><E118 9 0.7><E003 18>\n<E025 3><E007>(No, <E003 8><E025 3><E338><E341>the true Reaper is somebody else...)", "... soit Lord Van Peers !<E003 2><E145 9 13><E118 9 0.7><E003 18>\n<E025 3><E007>(Non, <E003 8><E025 3><E338><E341>le véritable Faucheur est quelqu'un d'autre...)");
                s = s.Replace("Barok van Zieks is not the Reaper!", "Drake Van Peers n'est pas le Faucheur !");
                s = s.Replace("A predictable response...<E049><E003 12><E025 2>from someone who's advocating\r\nfor the man.", "Réaction prévisible...<E049><E003 12><E025 2>de la part de celui qui assure\r\nsa défense.");
                s = s.Replace("A predictable response...<E049><E003 12><E025 2>from someone who's advocating\nfor the man.", "Réaction prévisible...<E049><E003 12><E025 2>de la part de celui qui assure\nsa défense.");
                s = s.Replace("And even if it's true that Gregson was operating as an\r\nagent of the Reaper...", "Et quand bien même Gregson aurait agi pour le compte\r\ndu Faucheur...");
                s = s.Replace("And even if it's true that Gregson was operating as an\nagent of the Reaper...", "Et quand bien même Gregson aurait agi pour le compte\ndu Faucheur...");
                s = s.Replace("...the suggestion that he went aboard the SS Grouse on an\r\nassassination mission doesn't follow at all.", "... prétendre qu'il est monté à bord du SS Grouse pour\r\nassassiner quelqu'un n'a aucun sens.");
                s = s.Replace("...the suggestion that he went aboard the SS Grouse on an\nassassination mission doesn't follow at all.", "... prétendre qu'il est monté à bord du SS Grouse pour\nassassiner quelqu'un n'a aucun sens.");
                s = s.Replace("Oh?<E049><E003 14> <E145 61 5><E118 61 0.5><E025 2>You have some solid reason for doubting the\r\nassertion, <E049><E003 6>do you, Counsel?", "Vraiment ?<E049><E003 14> <E145 61 5><E118 61 0.5><E025 2>Auriez-vous une raison valable de douter\r\nde cette affirmation, <E049><E003 6>Maître ?");
                s = s.Replace("Oh?<E049><E003 14> <E145 61 5><E118 61 0.5><E025 2>You have some solid reason for doubting the\nassertion, <E049><E003 6>do you, Counsel?", "Vraiment ?<E049><E003 14> <E145 61 5><E118 61 0.5><E025 2>Auriez-vous une raison valable de douter\nde cette affirmation, <E049><E003 6>Maître ?");
                s = s.Replace("Absolutely.<E049><E003 12> <E025 2>It's very simple.<E049><E003 8><E145 1 66><E118 1 1.2><E003 10>\r\n<E025 2>On the day in question...", "Tout à fait.<E049><E003 12> <E025 2>C'est élémentaire.<E049><E003 8><E145 1 66><E118 1 1.2><E003 10>\r\n<E025 2>Le jour en question...");
                s = s.Replace("Absolutely.<E049><E003 12> <E025 2>It's very simple.<E049><E003 8><E145 1 66><E118 1 1.2><E003 10>\n<E025 2>On the day in question...", "Tout à fait.<E049><E003 12> <E025 2>C'est élémentaire.<E049><E003 8><E145 1 66><E118 1 1.2><E003 10>\n<E025 2>Le jour en question...");
                s = s.Replace("...nobody was killed aboard that steamship.", "... personne n'a été tué à bord de ce navire.");
                s = s.Replace("(Professor Mikotoba and Judge Jigoku were on that very\r\nship.)", "(Le professeur Mikotoba et le juge Jigoku étaient à bord\r\nde ce navire.)");
                s = s.Replace("(Professor Mikotoba and Judge Jigoku were on that very\nship.)", "(Le professeur Mikotoba et le juge Jigoku étaient à bord\nde ce navire.)");
                s = s.Replace("(If someone had been assassinated, <E003 8>I'm certain we would\r\nhave heard about it!)", "(Si quelqu'un y avait été assassiné, <E003 8>nous en aurions\r\nforcément entendu parler !)");
                s = s.Replace("(If someone had been assassinated, <E003 8>I'm certain we would\nhave heard about it!)", "(Si quelqu'un y avait été assassiné, <E003 8>nous en aurions\nhave heard about it!)");
                s = s.Replace("...Pfft!", "... Pff !");
                s = s.Replace("What's so funny?", "Qu'est-ce qui vous fait rire ?");
                s = s.Replace("You're right, <E049><E003 6>of course.<E049><E003 8> No suspicious deaths were\r\nreported on board the ship.", "Vous avez raison, <E049><E003 6>bien sûr.<E049><E003 8> Aucun décès suspect n'a été\r\nsignalé à bord.");
                s = s.Replace("You're right, <E049><E003 6>of course.<E049><E003 8> No suspicious deaths were\nreported on board the ship.", "Vous avez raison, <E049><E003 6>bien sûr.<E049><E003 8> Aucun décès suspect n'a été\nsignalé à bord.");
                s = s.Replace("But I think <E049><E003 8><E025 3>perhaps you've missed the point.", "Mais je crains <E049><E003 8><E025 3>que vous n'ayez manqué l'essentiel.");
                s = s.Replace("That's precisely why <E049><E003 8><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>Inspector Gregson himself lost his\r\nlife!", "C'est précisément la raison pour laquelle <E049><E003 8><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>l'inspecteur\r\nGregson y a perdu la vie !");
                s = s.Replace("That's precisely why <E049><E003 8><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>Inspector Gregson himself lost his\nlife!", "C'est précisément la raison pour laquelle <E049><E003 8><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>l'inspecteur\nGregson y a perdu la vie !");
                s = s.Replace("Gregson did board the SS Grouse that night, <E049><E003 6>with the\r\nintention of dispatching his mark.", "Gregson est bien monté à bord du SS Grouse ce soir-là, <E049><E003 6>avec\r\nl'intention d'éliminer sa cible.");
                s = s.Replace("Gregson did board the SS Grouse that night, <E049><E003 6>with the\nintention of dispatching his mark.", "Gregson est bien monté à bord du SS Grouse ce soir-là, <E049><E003 6>avec\nl'intention d'éliminer sa cible.");
                s = s.Replace("But his mission...<E003 10><E025 3>ended in failure.", "Mais sa mission...<E003 10><E025 3>s'est soldée par un échec.");
                s = s.Replace("Failure...?", "Un échec... ?");
                s = s.Replace("It seems that the defence<E049><E003 8> <E145 112 3><E118 112 1.5><E003 10><E025 3><E238>hasn't yet grasped <E006>a very\r\nimportant detail<E005> here.", "Il semble que la défense<E049><E003 8> <E145 112 3><E118 112 1.5><E003 10><E025 3><E238>n'ait pas saisi <E006>un détail\r\ncapital<E005>.");
                s = s.Replace("It seems that the defence<E049><E003 8> <E145 112 3><E118 112 1.5><E003 10><E025 3><E238>hasn't yet grasped <E006>a very\nimportant detail<E005> here.", "Il semble que la défense<E049><E003 8> <E145 112 3><E118 112 1.5><E003 10><E025 3><E238>n'ait pas saisi <E006>un détail\ncapital<E005>.");
                s = s.Replace("What are you talking about?<E049><E003 12>\r\n<E025 3><E007>(What detail?)", "De quoi parlez-vous ?<E049><E003 12>\r\n<E025 3><E007>(Quel détail ?)");
                s = s.Replace("What are you talking about?<E049><E003 12>\n<E025 3><E007>(What detail?)", "De quoi parlez-vous ?<E049><E003 12>\n<E025 3><E007>(Quel détail ?)");
                s = s.Replace("Inspector Gina Lestrade!", "Inspectrice Gina Lestrade !");
                s = s.Replace("Eh?!<E049><E003 12> <E025 2>Wot?", "Hein ?!<E049><E003 12> <E025 2>Quoi ?");
                s = s.Replace("The victim's notebook that you read an excerpt from\r\nearlier...", "Le carnet de la victime dont vous avez lu un passage tout\r\nà l'heure...");
                s = s.Replace("The victim's notebook that you read an excerpt from\nearlier...", "Le carnet de la victime dont vous avez lu un passage tout\nà l'heure...");
                s = s.Replace("That doesn't contain details of secret investigations at all.", "Il ne contient nullement des détails sur de prétendues enquêtes.");
                s = s.Replace("It describes ten years of <E006>assassination plots<E005> to be carried\r\nout by the Reaper of the Bailey.", "Il consigne dix années de <E006>projets d'assassinats<E005> perpétrés\r\npar le Faucheur de l'Old Bailey.");
                s = s.Replace("It describes ten years of <E006>assassination plots<E005> to be carried\nout by the Reaper of the Bailey.", "Il consigne dix années de <E006>projets d'assassinats<E005> perpétrés\npar le Faucheur de l'Old Bailey.");
                s = s.Replace("Yer lyin'!", "C'est des mensonges !");
                s = s.Replace("Even if all them bludgers wot got taken out 'ad it comin'...", "Même si tous ces vauriens qui s'sont fait descendre l'avaient mérité...");
                s = s.Replace("...the boss <E049><E003 10><E025 1><E335>weren't the Reaper!", "... l'patron <E049><E003 10><E025 1><E335>était pas le Faucheur !");
                s = s.Replace("Poor Gina...", "Pauvre Gina...");
                s = s.Replace("There's no question that Tobias Gregson was heavily\r\ninvolved in the Reaper's activities.", "Il ne fait aucun doute que Tobias Gregson était au cœur\r\ndes activités du Faucheur.");
                s = s.Replace("There's no question that Tobias Gregson was heavily\ninvolved in the Reaper's activities.", "Il ne fait aucun doute que Tobias Gregson était au cœur\ndes activités du Faucheur.");
                s = s.Replace("You may just be an apprentice, <E049><E003 8><E025 2>but if you've spent any\r\ntime at Scotland Yard, <E049><E003 8>you must have heard rumours...", "Vous n'êtes qu'une apprentie, <E049><E003 8><E025 2>mais quiconque a mis les\r\npieds au Yard <E049><E003 8>a forcément entendu ces rumeurs...");
                s = s.Replace("You may just be an apprentice, <E049><E003 8><E025 2>but if you've spent any\ntime at Scotland Yard, <E049><E003 8>you must have heard rumours...", "Vous n'êtes qu'une apprentie, <E049><E003 8><E025 2>mais quiconque a mis les\npieds au Yard <E049><E003 8>a forcément entendu ces rumeurs...");
                s = s.Replace("I ain't 'eard nuffin'!<E049><E003 14>\r\n<E341>An' I don't believe a word of it!", "J'ai rien entendu du tout !<E049><E003 14>\r\n<E341>Et j'crois pas un traître mot de tout ça !");
                s = s.Replace("I ain't 'eard nuffin'!<E049><E003 14>\n<E341>An' I don't believe a word of it!", "J'ai rien entendu du tout !<E049><E003 14>\n<E341>Et j'crois pas un traître mot de tout ça !");
                s = s.Replace("Then testify again.<E049><E003 10>\r\n<E025 3>As a representative of Scotland Yard.", "Alors témoignez à nouveau.<E049><E003 10>\r\n<E025 3>En tant que représentante de Scotland Yard.");
                s = s.Replace("Then testify again.<E049><E003 10>\n<E025 3>As a representative of Scotland Yard.", "Alors témoignez à nouveau.<E049><E003 10>\n<E025 3>En tant que représentante de Scotland Yard.");
                s = s.Replace("Consider it...<E003 7><E145 112 1><E118 112 0.85><E003 10><E025 2>your chance to defend your ‘boss’.", "Voyez cela...<E003 7><E145 112 1><E118 112 0.85><E003 10><E025 2>comme l'occasion de défendre votre « patron ».");
                s = s.Replace("I, <E049><E003 8>I don't...", "Je, <E049><E003 8>j'sais pas...");
                s = s.Replace("I concur.<E049><E003 10> <E025 3>The witness will give a new formal testimony.", "J'acquiesce.<E049><E003 10> <E025 3>Le témoin va déposer à nouveau dans les règles.");
                s = s.Replace("Miss Lestrade, <E049><E003 8><E025 1>you will tell the court everything you\r\nknow about Inspector Gregson's secret notebook!", "Mademoiselle Lestrade, <E049><E003 8><E025 1>vous direz à la cour tout ce que vous\r\nsavez sur le carnet secret de l'inspecteur Gregson !");
                s = s.Replace("Miss Lestrade, <E049><E003 8><E025 1>you will tell the court everything you\nknow about Inspector Gregson's secret notebook!", "Mademoiselle Lestrade, <E049><E003 8><E025 1>vous direz à la cour tout ce que vous\nsavez sur le carnet secret de l'inspecteur Gregson !");
                return s;
            };

            // [12] _sce04_c102_0000_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0000_eng#4"] = (s) => {
                s = s.Replace("...Pray forgive the discourtesy <E049><E003 8><E025 2>of filling my hallowed\r\nchalice whilst I stand accused of murder.", "... Pardonnez-moi l'outrecuidance <E049><E003 8><E025 2>d'emplir mon calice\r\nsacré alors que je réponds d'une accusation de meurtre.");
                s = s.Replace("...Pray forgive the discourtesy <E049><E003 8><E025 2>of filling my hallowed\nchalice whilst I stand accused of murder.", "... Pardonnez-moi l'outrecuidance <E049><E003 8><E025 2>d'emplir mon calice\nsacré alors que je réponds d'une accusation de meurtre.");
                s = s.Replace("L-<E049><E003 12><E025 1><E331><E342>Lord van Zieks!", "L-<E049><E003 12><E025 1><E331><E342>Lord Van Peers !");
                s = s.Replace("The accused has no right to speak uninvited in court.<E049><E003 15>\r\n<E025 1><E145 112 65><E117 112 6><E346>You will return to the dock.", "L'accusé n'a pas le droit de parler sans y être convié.<E049><E003 15>\r\n<E025 1><E145 112 65><E117 112 6><E346>Regagnez immédiatement le banc des accusés.");
                s = s.Replace("The accused has no right to speak uninvited in court.<E049><E003 15>\n<E025 1><E145 112 65><E117 112 6><E346>You will return to the dock.", "L'accusé n'a pas le droit de parler sans y être convié.<E049><E003 15>\n<E025 1><E145 112 65><E117 112 6><E346>Regagnez immédiatement le banc des accusés.");
                s = s.Replace("I say nothing of whether or not I'm the Reaper.<E049><E003 12>", "Je ne me prononcerai point sur le fait d'être le Faucheur.<E049><E003 12>");
                s = s.Replace("That's the task of this court to decide.", "C'est à cette cour d'en juger.");
                s = s.Replace("But there is one thing I can say unequivocally:", "Mais il est une chose que j'affirme sans détour :");
                s = s.Replace("That girl is no detective.", "Cette gamine n'est en rien une détective.");
                s = s.Replace("Eh?<E049><E003 10> <E025 3>Wha...?<E049><E003 15>\r\n<E164 122 71 1 2 1 0 2 1><E118 122 1.5><E139 122><E025 2>Nah, that's right, <E049><E003 8>I ain't.<E049><E003 10> <E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.3><E139 122>I'm an inspector!", "Hein ?<E049><E003 10> <E025 3>Quoi... ?<E049><E003 15>\r\n<E164 122 71 1 2 1 0 2 1><E118 122 1.5><E139 122><E025 2>Bah ouais, c'est vrai, <E049><E003 8>chuis pas détective.<E049><E003 10> <E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.3><E139 122>Chuis inspectrice !");
                s = s.Replace("Eh?<E049><E003 10> <E025 3>Wha...?<E049><E003 15>\n<E164 122 71 1 2 1 0 2 1><E118 122 1.5><E139 122><E025 2>Nah, that's right, <E049><E003 8>I ain't.<E049><E003 10> <E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.3><E139 122>I'm an inspector!", "Hein ?<E049><E003 10> <E025 3>Quoi... ?<E049><E003 15>\n<E164 122 71 1 2 1 0 2 1><E118 122 1.5><E139 122><E025 2>Bah ouais, c'est vrai, <E049><E003 8>chuis pas détective.<E049><E003 10> <E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.3><E139 122>Chuis inspectrice !");
                s = s.Replace("Repeating rumours heard around the Yard...<E049><E003 12>\r\n<E025 3>Reading entries from a notebook of unconfirmed origin...", "Répéter des ouï-dire entendus au Yard...<E049><E003 12>\r\n<E025 3>Lire les pages d'un carnet à l'authenticité douteuse...");
                s = s.Replace("Repeating rumours heard around the Yard...<E049><E003 12>\n<E025 3>Reading entries from a notebook of unconfirmed origin...", "Répéter des ouï-dire entendus au Yard...<E049><E003 12>\n<E025 3>Lire les pages d'un carnet à l'authenticité douteuse...");
                s = s.Replace("That's not testimony.<E049><E003 10> <E025 2>It's practically a script.<E049><E003 15> <E145 18 2><E239>No doubt the\r\nrest of this trial will go exactly as you've clearly planned.", "Ce n'est pas un témoignage.<E049><E003 10> <E025 2>C'est une vulgaire récitation.<E049><E003 15> <E145 18 2><E239>Nul doute que la\r\nsuite de ce procès suivra fidèlement vos plans.");
                s = s.Replace("That's not testimony.<E049><E003 10> <E025 2>It's practically a script.<E049><E003 15> <E145 18 2><E239>No doubt the\nrest of this trial will go exactly as you've clearly planned.", "Ce n'est pas un témoignage.<E049><E003 10> <E025 2>C'est une vulgaire récitation.<E049><E003 15> <E145 18 2><E239>Nul doute que la\nsuite de ce procès suivra fidèlement vos plans.");
                s = s.Replace("Your hatred of me is understandable.", "Votre haine à mon encontre est concevable.");
                s = s.Replace("In your mind, I'm sure<E049><E003 12> I am the Reaper...<E049><E003 10><E145 18 3><E118 18 0.6><E003 7><E333>who sent your\r\nfather to the gallows all those years ago.", "Dans votre esprit, <E049><E003 12>je suis le Faucheur...<E049><E003 10><E145 18 3><E118 18 0.6><E003 7><E333>celui qui a envoyé\r\nvotre père à l'échafaud jadis.");
                s = s.Replace("In your mind, I'm sure<E049><E003 12> I am the Reaper...<E049><E003 10><E145 18 3><E118 18 0.6><E003 7><E333>who sent your\nfather to the gallows all those years ago.", "Dans votre esprit, <E049><E003 12>je suis le Faucheur...<E049><E003 10><E145 18 3><E118 18 0.6><E003 7><E333>celui qui a envoyé\nvotre père à l'échafaud jadis.");
                s = s.Replace("But you're in danger of becoming a far more sinister\r\nReaper yourself...", "Mais vous courez le risque de devenir vous-même un Faucheur\r\nbien plus redoutable...");
                s = s.Replace("But you're in danger of becoming a far more sinister\nReaper yourself...", "Mais vous courez le risque de devenir vous-même un Faucheur\nbien plus redoutable...");
                s = s.Replace("...by attempting to have me condemned with this feeble\r\nexcuse for testimony.", "... en essayant de me faire condamner sur un simulacre de\r\ndéposition aussi bancal.");
                s = s.Replace("...by attempting to have me condemned with this feeble\nexcuse for testimony.", "... en essayant de me faire condamner sur un simulacre de\ndéposition aussi bancal.");
                s = s.Replace("What did you say?", "Qu'avez-vous dit ?");
                s = s.Replace("Mr Naruhodo, <E049><E003 7><E145 9 16><E003 6><E025 1><E333>this is our chance!", "M. Naruhodo, <E049><E003 7><E145 9 16><E003 6><E025 1><E333>voilà notre chance !");
                s = s.Replace("My Lord!<E049><E003 12> <E025 1><E335>The defence requests that the defendant be\r\nallowed to speak!", "Votre Honneur !<E049><E003 12> <E025 1><E335>La défense demande que l'accusé soit\r\nautorisé à s'exprimer !");
                s = s.Replace("My Lord!<E049><E003 12> <E025 1><E335>The defence requests that the defendant be\nallowed to speak!", "Votre Honneur !<E049><E003 12> <E025 1><E335>La défense demande que l'accusé soit\nallowed to speak!");
                s = s.Replace("He may be <E006>privy<E005> <E049><E003 10><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>to important information relating to the\r\ntestimony just given by the witness!", "Il détient peut-être <E006>des éléments<E005> <E049><E003 10><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>cruciaux sur\r\nla déposition que le témoin vient de formuler !");
                s = s.Replace("He may be <E006>privy<E005> <E049><E003 10><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>to important information relating to the\ntestimony just given by the witness!", "Il détient peut-être <E006>des éléments<E005> <E049><E003 10><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>cruciaux sur\nla déposition que le témoin vient de formuler !");
                s = s.Replace("Very well.<E049><E003 15> <E025 2>I'll make an exception and grant the request.", "Qu'il en soit ainsi.<E049><E003 15> <E025 2>Je ferai une exception et accède à la requête.");
                s = s.Replace("The defendant may remain in the witness stand for the\r\ncross-examination.", "L'accusé restera à la barre pour le contre-interrogatoire.");
                s = s.Replace("The defendant may remain in the witness stand for the\ncross-examination.", "L'accusé restera à la barre pour le contre-interrogatoire.");
                s = s.Replace("Then allow me to toast <E049><E003 10>the court's impartiality.", "Permettez-moi alors de trinquer <E049><E003 10>à l'impartialité de la cour.");
                s = s.Replace("...Don't raise your glass in my direction, <E049><E003 8><E025 3>sir.", "... Ne levez pas votre coupe dans ma direction, <E049><E003 8><E025 3>monsieur.");
                s = s.Replace("Counsel for the Defence, <E049><E003 10><E025 1>begin the cross-examination\r\nimmediately!", "Maître de la défense, <E049><E003 10><E025 1>commencez le contre-interrogatoire\r\nsans plus tarder !");
                s = s.Replace("Counsel for the Defence, <E049><E003 10><E025 1>begin the cross-examination\nimmediately!", "Maître de la défense, <E049><E003 10><E025 1>commencez le contre-interrogatoire\nsans plus tarder !");
                s = s.Replace("At once, <E049><E003 6>My Lord!", "Sur-le-champ, <E049><E003 6>Votre Honneur !");
                return s;
            };

            // [13] _sce04_c102_0010_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#4"] = (s) => {
                s = s.Replace("Yeah, this notebook does 'ave a load o' stuff about wot the\r\nReaper got up to these past ten years.", "Ouais, ce carnet contient plein d'trucs sur c'que l'Faucheur\r\na manigancé ces dix dernières années.");
                s = s.Replace("Yeah, this notebook does 'ave a load o' stuff about wot the\nReaper got up to these past ten years.", "Ouais, ce carnet contient plein d'trucs sur c'que l'Faucheur\na manigancé ces dix dernières années.");
                return s;
            };

            // [14] _sce04_c102_0010_eng#5
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#5"] = (s) => {
                s = s.Replace("Names o' victims, dates an' places an' stuff...\r\nAn' the last entry in there was 31st October.", "Des noms d'victimes, des dates, des lieux et tout...\r\nEt la dernière note remonte au 31 octobre.");
                s = s.Replace("Names o' victims, dates an' places an' stuff...\nAn' the last entry in there was 31st October.", "Des noms d'victimes, des dates, des lieux et tout...\nEt la dernière note remonte au 31 octobre.");
                return s;
            };

            // [15] _sce04_c102_0010_eng#6
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#6"] = (s) => {
                s = s.Replace("It said ‘Grouse’ for the place on that date, and then the\r\nname o' the mark.", "Y avait marqué « Grouse » comme lieu à cette date, puis le\r\nnom d'la cible.");
                s = s.Replace("It said ‘Grouse’ for the place on that date, and then the\nname o' the mark.", "Y avait marqué « Grouse » comme lieu à cette date, puis le\nnom d'la cible.");
                return s;
            };

            // [16] _sce04_c102_0010_eng#8
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#8"] = (s) => {
                s = s.Replace("But honest! The boss didn't do none of it!\r\n'E was... 'E was just investigatin' the Reaper, that's all!", "Mais juré craché ! L'patron a rien fait de tout ça !\r\nY menait... y menait juste l'enquête sur le Faucheur, c'est tout !");
                s = s.Replace("But honest! The boss didn't do none of it!\n'E was... 'E was just investigatin' the Reaper, that's all!", "Mais juré craché ! L'patron a rien fait de tout ça !\nY menait... y menait juste l'enquête sur le Faucheur, c'est tout !");
                return s;
            };

            // [17] _sce04_c102_0010_eng#9
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#9"] = (s) => {
                s = s.Replace("Come on, 'Oddo! 'Elp!\r\nYou've gotta find a flaw somewhere!", "Allez, Naruhodo ! Aide-moi !\r\nTu dois bien trouver une faille quelque part !");
                s = s.Replace("Come on, 'Oddo! 'Elp!\nYou've gotta find a flaw somewhere!", "Allez, Naruhodo ! Aide-moi !\nTu dois bien trouver une faille quelque part !");
                return s;
            };

            // [18] _sce04_c102_0010_eng#14
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#14"] = (s) => {
                s = s.Replace("And you're saying that the mark listed <E049><E003 12><E025 1><E332>was Seishiro\r\nJigoku?", "Et vous dites que la cible inscrite <E049><E003 12><E025 1><E332>était Seishiro\r\nJigoku ?");
                s = s.Replace("And you're saying that the mark listed <E049><E003 12><E025 1><E332>was Seishiro\nJigoku?", "Et vous dites que la cible inscrite <E049><E003 12><E025 1><E332>était Seishiro\nJigoku ?");
                s = s.Replace("That's wot it said.<E049><E003 12>\r\n<E025 3><E145 122 73><E118 122 1.3><E003 8>Funny name, <E049><E003 6>if you ask me.", "C'est c'qui est écrit.<E049><E003 12>\r\n<E025 3><E145 122 73><E118 122 1.3><E003 8>Un drôle de nom, <E049><E003 6>si vous voulez mon avis.");
                s = s.Replace("That's wot it said.<E049><E003 12>\n<E025 3><E145 122 73><E118 122 1.3><E003 8>Funny name, <E049><E003 6>if you ask me.", "C'est c'qui est écrit.<E049><E003 12>\n<E025 3><E145 122 73><E118 122 1.3><E003 8>Un drôle de nom, <E049><E003 6>si vous voulez mon avis.");
                s = s.Replace("An' I thought your name was odd!", "Et dire que j'trouvais déjà ton nom pas commun !");
                s = s.Replace("So pleased to have lost my crown there...", "Ravi d'avoir cédé ma couronne sur ce point...");
                s = s.Replace("Mr Jigoku is the presiding judge of Japan's Supreme Court\r\nof Judicature.", "M. Jigoku est le juge président de la Cour suprême\r\nde justice du Japon.");
                s = s.Replace("Mr Jigoku is the presiding judge of Japan's Supreme Court\nof Judicature.", "M. Jigoku est le juge président de la Cour suprême\nde justice du Japon.");
                s = s.Replace("I remember the man.<E049><E003 12> <E025 2>He came to our country as a\r\nvisiting student sixteen years ago.", "Je me souviens de cet homme.<E049><E003 12> <E025 2>Il a séjourné dans notre\r\npays comme étudiant il y a seize ans.");
                s = s.Replace("I remember the man.<E049><E003 12> <E025 2>He came to our country as a\nvisiting student sixteen years ago.", "Je me souviens de cet homme.<E049><E003 12> <E025 2>Il a séjourné dans notre\npays comme étudiant il y a seize ans.");
                s = s.Replace("Studying international law and diplomacy under your\r\ntutelage, <E049><E003 8><E025 3>Lord Stronghart.", "Étudiant le droit international et la diplomatie sous votre\r\ntutelle, <E049><E003 8><E025 3>Lord Stronghart.");
                s = s.Replace("Studying international law and diplomacy under your\ntutelage, <E049><E003 8><E025 3>Lord Stronghart.", "Étudiant le droit international et la diplomatie sous votre\ntutelle, <E049><E003 8><E025 3>Lord Stronghart.");
                s = s.Replace("That bearded young fellow <E049><E003 12><E145 61 7><E118 61 0.5><E025 3>was a very able man,<E049><E003 8><E025 3> I must\r\nsay.", "Ce jeune barbu <E049><E003 12><E145 61 7><E118 61 0.5><E025 3>était fort doué,<E049><E003 8><E025 3> je dois\r\nle reconnaître.");
                s = s.Replace("That bearded young fellow <E049><E003 12><E145 61 7><E118 61 0.5><E025 3>was a very able man,<E049><E003 8><E025 3> I must\nsay.", "Ce jeune barbu <E049><E003 12><E145 61 7><E118 61 0.5><E025 3>était fort doué,<E049><E003 8><E025 3> je dois\nle reconnaître.");
                s = s.Replace("(So Lord Stronghart was <E145 1 64><E025 3>Judge Jigoku's mentor...)", "(Lord Stronghart était donc <E145 1 64><E025 3>le mentor du juge Jigoku...)");
                s = s.Replace("If I'm not mistaken, <E049><E003 8>he returned to Japan ten years ago\r\nnow.", "Si ma mémoire est bonne, <E049><E003 8>il est reparti pour le Japon il y a\r\ndix ans.");
                s = s.Replace("If I'm not mistaken, <E049><E003 8>he returned to Japan ten years ago\nnow.", "Si ma mémoire est bonne, <E049><E003 8>il est reparti pour le Japon il y a\ndix ans.");
                s = s.Replace("Ten years ago...<E003 6><E025 3><E164 9 83 1 2 7 0 0 1><E139 9>after that fateful case...", "Il y a dix ans...<E003 6><E025 3><E164 9 83 1 2 7 0 0 1><E139 9>après cette fatale affaire...");
                s = s.Replace("...Precisely.", "... Exactement.");
                s = s.Replace("In the aftermath of the Professor case, <E049><E003 8>his repatriation was\r\norganised immediately.", "Au lendemain de l'affaire du Professeur, <E049><E003 8>son rapatriement a\r\nété promptement organisé.");
                s = s.Replace("In the aftermath of the Professor case, <E049><E003 8>his repatriation was\norganised immediately.", "Au lendemain de l'affaire du Professeur, <E049><E003 8>son rapatriement a\nété promptement organisé.");
                s = s.Replace("It's a mystery why such a man would be listed in the\r\ninspector's notebook.", "On ignore pour quelle raison un tel magistrat figurerait\r\ndans le carnet de l'inspecteur.");
                s = s.Replace("It's a mystery why such a man would be listed in the\ninspector's notebook.", "On ignore pour quelle raison un tel magistrat figurerait\ndans le carnet de l'inspecteur.");
                s = s.Replace("I didn't think it was possible, <E049><E003 6>but the mood in 'ere's got\r\neven worse now.<E049><E003 10> Maybe I'll just keep talkin'...", "J'pensais pas qu'c'était possible, <E049><E003 6>mais l'ambiance est encore\r\nplus glaciale.<E049><E003 10> J'vais p'têt continuer à causer...");
                s = s.Replace("I didn't think it was possible, <E049><E003 6>but the mood in 'ere's got\neven worse now.<E049><E003 10> Maybe I'll just keep talkin'...", "J'pensais pas qu'c'était possible, <E049><E003 6>mais l'ambiance est encore\nplus glaciale.<E049><E003 10> J'vais p'têt continuer à causer...");
                return s;
            };

            // [19] _sce04_c102_0010_eng#15
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#15"] = (s) => {
                s = s.Replace("What do you mean, <E006>a criminal<E005>?!<E049><E003 16>\r\n<E025 1><E046>Judge Jigoku is no criminal!", "Qu'entendez-vous par <E006>un criminel<E005> ?!<E049><E003 16>\r\n<E025 1><E046>Le juge Jigoku n'est pas un criminel !");
                s = s.Replace("What do you mean, <E006>a criminal<E005>?!<E049><E003 16>\n<E025 1><E046>Judge Jigoku is no criminal!", "Qu'entendez-vous par <E006>un criminel<E005> ?!<E049><E003 16>\n<E025 1><E046>Le juge Jigoku n'est pas un criminel !");
                s = s.Replace("Well don't ask me!<E049><E003 14>\r\nI don't know nuffin' about it!", "Me d'mandez pas à moi !<E049><E003 14>\r\nJ'en sais fichtre rien !");
                s = s.Replace("Well don't ask me!<E049><E003 14>\nI don't know nuffin' about it!", "Me d'mandez pas à moi !<E049><E003 14>\nJ'en sais fichtre rien !");
                s = s.Replace("Oh, <E049><E003 12><E025 1><E145 9 16><E117 9 7><E003 4><E346>do you remember what Father told us?", "Oh, <E049><E003 12><E025 1><E145 9 16><E117 9 7><E003 4><E346>vous rappelez-vous ce que père nous a dit ?");
                s = s.Replace("That Judge Jigoku did once appear in court here in Britain.", "Le juge Jigoku a comparu un jour devant un tribunal ici en Grande-Bretagne.");
                s = s.Replace("It was related to the Professor case, <E049><E003 6><E025 2>I'm sure!", "C'était en lien avec l'affaire du Professeur, <E049><E003 6><E025 2>j'en suis sûre !");
                s = s.Replace("Yes, <E003 8>of course!<E003 12> <E025 1><E341>You're right!", "Oui, <E003 8>bien sûr !<E003 12> <E025 1><E341>Vous avez raison !");
                s = s.Replace("Seishiro was trying to mitigate Genshin's guilt, <E049><E003 8>so he took\r\nto the stand to testify.", "Seishiro voulait alléger la culpabilité de Genshin, <E049><E003 8>alors il est\r\nmonté à la barre pour témoigner.");
                s = s.Replace("Seishiro was trying to mitigate Genshin's guilt, <E049><E003 8>so he took\nto the stand to testify.", "Seishiro voulait alléger la culpabilité de Genshin, <E049><E003 8>so he took\nto the stand to testify.");
                s = s.Replace("But he...<E003 12><E025 2>got a little carried away and, <E049><E003 4><E025 3><E136 46 76 14><E117 46 12><E003 15>um...<E003 12><E330>actually\r\nmanaged to break the witness stand.", "Mais il...<E003 12><E025 2>s'est un peu emporté et, <E049><E003 4><E025 3><E136 46 76 14><E117 46 12><E003 15>hum...<E003 12><E330>a carrément\r\nréussi à briser la barre des témoins.");
                s = s.Replace("But he...<E003 12><E025 2>got a little carried away and, <E049><E003 4><E025 3><E136 46 76 14><E117 46 12><E003 15>um...<E003 12><E330>actually\nmanaged to break the witness stand.", "Mais il...<E003 12><E025 2>s'est un peu emporté et, <E049><E003 4><E025 3><E136 46 76 14><E117 46 12><E003 15>hum...<E003 12><E330>a carrément\nréussi à briser la barre des témoins.");
                s = s.Replace("He also said some contemptuous words about the British\r\nEmpire...<E003 12><E330><E025 3>for which he was charged.", "Il a également tenu des propos injurieux envers l'Empire\r\nbritannique...<E003 12><E330><E025 3>ce qui lui a valu d'être inculpé.");
                s = s.Replace("He also said some contemptuous words about the British\nEmpire...<E003 12><E330><E025 3>for which he was charged.", "Il a également tenu des propos injurieux envers l'Empire\nbritannique...<E003 12><E330><E025 3>ce qui lui a valu d'être inculpé.");
                s = s.Replace("It was a pitiful situation, <E049><E003 8>yes.", "C'était une bien triste scène, <E049><E003 8>en effet.");
                s = s.Replace("I'd forgotten all about it.<E049><E003 14>\r\n<E025 2><E239>But I prosecuted that trial too, <E049><E003 6>as it happens.", "J'avais complètement rayé cela de ma mémoire.<E049><E003 14>\r\n<E025 2><E239>Mais il se trouve que je menais l'accusation ce jour-là, <E049><E003 6>moi aussi.");
                s = s.Replace("I'd forgotten all about it.<E049><E003 14>\n<E025 2><E239>But I prosecuted that trial too, <E049><E003 6>as it happens.", "J'avais complètement rayé cela de ma mémoire.<E049><E003 14>\n<E025 2><E239>Mais il se trouve que je menais l'accusation ce jour-là, <E049><E003 6>moi aussi.");
                s = s.Replace("You did?!", "Vraiment ?!");
                s = s.Replace("It was considered to be an adjunct to the Professor\r\nproceedings, <E049><E003 6><E025 3>you see.", "C'était considéré comme une annexe au procès du\r\nProfesseur, <E049><E003 6><E025 3>voyez-vous.");
                s = s.Replace("It was considered to be an adjunct to the Professor\nproceedings, <E049><E003 6><E025 3>you see.", "C'était considéré comme une annexe au procès du\nproceedings, <E049><E003 6><E025 3>you see.");
                s = s.Replace("But he was acquitted after being told to make reparation\r\nfor the damage caused to the stand.", "Mais il fut acquitté après sommation de rembourser\r\nles dégradations infligées au mobilier.");
                s = s.Replace("But he was acquitted after being told to make reparation\nfor the damage caused to the stand.", "Mais il fut acquitté après sommation de rembourser\nles dégradations infligées au mobilier.");
                s = s.Replace("And there you have it.", "Et voilà toute l'histoire.");
                s = s.Replace("Have what?", "Quelle histoire ?");
                s = s.Replace("Surely the accused hasn't forgotten his own rule?", "L'accusé n'aurait tout de même pas oublié sa propre règle ?");
                s = s.Replace("That there's no saving anyone who faces the Reaper in\r\ncourt...<E003 14><E025 3><E238>guilty or innocent alike.", "Que nul n'échappe au sort du Faucheur après l'avoir croisé\r\nen cour...<E003 14><E025 3><E238>coupable ou innocent, sans distinction.");
                s = s.Replace("That there's no saving anyone who faces the Reaper in\ncourt...<E003 14><E025 3><E238>guilty or innocent alike.", "Que nul n'échappe au sort du Faucheur après l'avoir croisé\nen cour...<E003 14><E025 3><E238>coupable ou innocent, sans distinction.");
                s = s.Replace("Noooooo!", "Noooon !");
                s = s.Replace("Are, <E049><E003 10><E025 2><E341>are you suggesting that the reason Judge Jigoku was\r\ntargeted for assassination...", "Êtes, <E049><E003 10><E025 2><E341>êtes-vous en train de suggérer que la cible du\r\nmeurtre était le juge Jigoku...");
                s = s.Replace("Are, <E049><E003 10><E025 2><E341>are you suggesting that the reason Judge Jigoku was\ntargeted for assassination...", "Êtes, <E049><E003 10><E025 2><E341>êtes-vous en train de suggérer que la cible du\nmeurtre était le juge Jigoku...");
                s = s.Replace("The man was sent back to Japan immediately after that\r\ntrial.", "Cet homme a été renvoyé au Japon aussitôt après\r\nce procès.");
                s = s.Replace("The man was sent back to Japan immediately after that\ntrial.", "Cet homme a été renvoyé au Japon aussitôt après\nce procès.");
                s = s.Replace("The Reaper had no time to do his work.", "Le Faucheur n'a point eu le temps d'accomplir son forfait.");
                s = s.Replace("But then –<E049><E003 6> ten years later –<E049><E003 8> the mark returns to Britain\r\nonce more.", "Mais voilà que –<E049><E003 6> dix ans plus tard –<E049><E003 8> la cible remet les pieds\r\nen Grande-Bretagne.");
                s = s.Replace("But then –<E049><E003 6> ten years later –<E049><E003 8> the mark returns to Britain\nonce more.", "Mais voilà que –<E049><E003 6> dix ans plus tard –<E049><E003 8> la cible remet les pieds\nonce more.");
                s = s.Replace("Perhaps now you start to see...<E049><E003 12><E333>just how vindictive the\r\nReaper is.", "Peut-être commencez-vous à mesurer...<E049><E003 12><E333>toute la noirceur\r\net la rancœur du Faucheur.");
                s = s.Replace("Perhaps now you start to see...<E049><E003 12><E333>just how vindictive the\nReaper is.", "Peut-être commencez-vous à mesurer...<E049><E003 12><E333>toute la noirceur\net la rancœur du Faucheur.");
                s = s.Replace("Come on, <E049><E003 14>that's absurd!<E049><E003 14>\r\n<E346>To take someone's life for that?", "Mais enfin, <E049><E003 14>c'est absurde !<E049><E003 14>\r\n<E346>Prendre la vie d'un homme pour ça ?");
                s = s.Replace("Come on, <E049><E003 14>that's absurd!<E049><E003 14>\n<E346>To take someone's life for that?", "Mais enfin, <E049><E003 14>c'est absurde !<E049><E003 14>\n<E346>Prendre la vie d'un homme pour ça ?");
                s = s.Replace("Isn't the whole premise of the Reaper absurd,<E049><E003 8> killing those\r\nwho have been found innocent?", "Le principe même du Faucheur n'est-il pas absurde,<E049><E003 8> fauchant\r\nceux déclarés innocents ?");
                s = s.Replace("Isn't the whole premise of the Reaper absurd,<E049><E003 8> killing those\nwho have been found innocent?", "Le principe même du Faucheur n'est-il pas absurde,<E049><E003 8> fauchant\nceux déclarés innocents ?");
                s = s.Replace("Clearly the rules by which the man operates...<E049><E003 6><E164 112 10 1 2 5 0 1 1><E139 112><E025 1>are beyond\r\na sane person's comprehension!", "À l'évidence, la logique de cet individu...<E049><E003 6><E164 112 10 1 2 5 0 1 1><E139 112><E025 1>défie\r\ntoute raison humaine !");
                s = s.Replace("Clearly the rules by which the man operates...<E049><E003 6><E164 112 10 1 2 5 0 1 1><E139 112><E025 1>are beyond\na sane person's comprehension!", "À l'évidence, la logique de cet individu...<E049><E003 6><E164 112 10 1 2 5 0 1 1><E139 112><E025 1>défie\ntoute raison humaine !");
                s = s.Replace("But...", "Mais...");
                return s;
            };

            // [20] _sce04_c102_0010_eng#16
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#16"] = (s) => {
                s = s.Replace("So you have complete faith <E049><E003 6><E145 1 85><E003 6><E025 2>that Inspector Gregson is\r\ninnocent in all of this?", "Tu as donc une confiance absolue <E049><E003 6><E145 1 85><E003 6><E025 2>dans l'innocence de\r\nl'inspecteur Gregson dans cette histoire ?");
                s = s.Replace("So you have complete faith <E049><E003 6><E145 1 85><E003 6><E025 2>that Inspector Gregson is\ninnocent in all of this?", "Tu as donc une confiance absolue <E049><E003 6><E145 1 85><E003 6><E025 2>dans l'innocence de\nl'inspecteur Gregson dans cette histoire ?");
                s = s.Replace("'Course I do!", "Évidemment que oui !");
                s = s.Replace("I mean...", "J'veux dire...");
                s = s.Replace("...I owe 'im that, <E049><E003 4>don't I?<E049><E003 12>\r\n<E025 2>Because 'e's the only one wot 'ad faith in me.", "... j'lui dois bien ça, <E049><E003 4>pas vrai ?<E049><E003 12>\r\n<E025 2>Parce que c'est l'seul qui a cru en moi.");
                s = s.Replace("...I owe 'im that, <E049><E003 4>don't I?<E049><E003 12>\n<E025 2>Because 'e's the only one wot 'ad faith in me.", "... j'lui dois bien ça, <E049><E003 4>pas vrai ?<E049><E003 12>\n<E025 2>Parce que c'est l'seul qui a cru en moi.");
                s = s.Replace("The boss promised me,<E049><E003 6> 'e did.", "L'patron m'a promis,<E049><E003 6> juré craché.");
                s = s.Replace("'E promised me that even though I was just a diver,<E049><E003 8><E025 1> 'e\r\ncould turn me into a top-notch detective!", "Y m'a promis que même si j'étais qu'une tireuse,<E049><E003 8><E025 1> y ferait\r\nde moi une sacrée détective !");
                s = s.Replace("'E promised me that even though I was just a diver,<E049><E003 8><E025 1> 'e\ncould turn me into a top-notch detective!", "Y m'a promis que même si j'étais qu'une tireuse,<E049><E003 8><E025 1> y ferait\nde moi une sacrée détective !");
                s = s.Replace("A cove wiv a good 'eart like that <E049><E003 12><E025 1><E332>ain't gonna go an' rob\r\npeople o' their futures, <E049><E003 8><E025 2>is 'e?", "Un type avec un si grand cœur <E049><E003 12><E025 1><E332>va pas aller faucher\r\nl'avenir des honnêtes gens, <E049><E003 8><E025 2>pas vrai ?");
                s = s.Replace("A cove wiv a good 'eart like that <E049><E003 12><E025 1><E332>ain't gonna go an' rob\npeople o' their futures, <E049><E003 8><E025 2>is 'e?", "Un type avec un si grand cœur <E049><E003 12><E025 1><E332>va pas aller faucher\nl'avenir des honnêtes gens, <E049><E003 8><E025 2>is 'e?");
                s = s.Replace("Every single person killed by the Reaper was a criminal\r\nof the first order.", "Chacun des individus supprimés par le Faucheur était un\r\ncriminel de la pire engeance.");
                s = s.Replace("Every single person killed by the Reaper was a criminal\nof the first order.", "Chacun des individus supprimés par le Faucheur était un\ncriminel de la pire engeance.");
                s = s.Replace("Lowlifes like that <E049><E003 12><E025 2><E238>have no compunction about robbing\r\nhundreds of others of their futures.", "Des racailles pareilles <E049><E003 12><E025 2><E238>n'ont pas le moindre scrupule à\r\nbriser l'avenir de centaines d'innocents.");
                s = s.Replace("Lowlifes like that <E049><E003 12><E025 2><E238>have no compunction about robbing\nhundreds of others of their futures.", "Des racailles pareilles <E049><E003 12><E025 2><E238>n'ont pas le moindre scrupule à\nbriser l'avenir de centaines d'innocents.");
                s = s.Replace("Their ludicrous acquittals in court give them the freedom<E049><E003 8>\r\n<E145 18 3><E118 18 0.5><E003 8><E239>to make hundreds more suffer.", "Leurs acquittements dérisoires leur rendent la liberté<E049><E003 8>\r\n<E145 18 3><E118 18 0.5><E003 8><E239>de semer le malheur à nouveau.");
                s = s.Replace("Their ludicrous acquittals in court give them the freedom<E049><E003 8>\n<E145 18 3><E118 18 0.5><E003 8><E239>to make hundreds more suffer.", "Leurs acquittements dérisoires leur rendent la liberté<E049><E003 8>\n<E145 18 3><E118 18 0.5><E003 8><E239>de semer le malheur à nouveau.");
                s = s.Replace("So what?<E049><E003 6> <E025 2><E145 112 13><E003 10><E333>You justified your actions because you were\r\nprotecting innocent people's futures?", "Et alors ?<E049><E003 6> <E025 2><E145 112 13><E003 10><E333>Vous vous donniez bonne conscience en prétendant\r\nprotéger l'avenir d'innocents ?");
                s = s.Replace("So what?<E049><E003 6> <E025 2><E145 112 13><E003 10><E333>You justified your actions because you were\nprotecting innocent people's futures?", "Et alors ?<E049><E003 6> <E025 2><E145 112 13><E003 10><E333>Vous vous donniez bonne conscience en prétendant\nprotéger l'avenir d'innocents ?");
                s = s.Replace("...<E145 18 2>I'm not suggesting that the Reaper's methods are justified\r\nat all.", "...<E145 18 2>Je ne prétends nullement que les actes du Faucheur\r\nsoient justifiés.");
                s = s.Replace("...<E145 18 2>I'm not suggesting that the Reaper's methods are justified\nat all.", "...<E145 18 2>Je ne prétends nullement que les actes du Faucheur\nsoient justifiés.");
                s = s.Replace("But life isn't black and white.<E049><E003 14>\r\n<E025 3>That's all I'm saying.", "Mais le monde n'est pas tout blanc ou tout noir.<E049><E003 14>\r\n<E025 3>C'est tout ce que je dis.");
                s = s.Replace("But life isn't black and white.<E049><E003 14>\n<E025 3>That's all I'm saying.", "Mais le monde n'est pas tout blanc ou tout noir.<E049><E003 14>\n<E025 3>C'est tout ce que je dis.");
                s = s.Replace("Uhhh...", "Euhhh...");
                return s;
            };

            // [21] _sce04_c102_0010_eng#17
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#17"] = (s) => {
                s = s.Replace("I want to thank you, <E049><E003 4><E025 3>Gina.", "Je tiens à te remercier, <E049><E003 4><E025 3>Gina.");
                s = s.Replace("You helped me find my resolve.", "Tu m'as aidé à trouver ma résolution.");
                s = s.Replace("Eh?", "Hein ?");
                s = s.Replace("What do you mean?", "Que voulez-vous dire ?");
                return s;
            };

            // [22] _sce04_c102_0010_eng#18
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#18"] = (s) => {
                s = s.Replace("Amongst everything we've heard during this cross-\r\nexamination, <E049><E003 8><E025 3>there's one thing...", "Parmi tout ce que nous avons entendu au cours de ce\r\ncontre-interrogatoire, <E049><E003 8><E025 3>il y a une chose...");
                s = s.Replace("Amongst everything we've heard during this cross-\nexamination, <E049><E003 8><E025 3>there's one thing...", "Parmi tout ce que nous avons entendu au cours de ce\ncontre-interrogatoire, <E049><E003 8><E025 3>il y a une chose...");
                s = s.Replace("...that defies explanation.<E049><E003 14> <E330>One <E006>inconsistency<E005>.", "... qui défie la raison.<E049><E003 14> <E330>Une <E006>contradiction<E005>.");
                s = s.Replace("What?<E049><E003 10> <E145 61 5><E118 61 0.5><E003 8><E025 3><E239>An inconsistency?", "Quoi ?<E049><E003 10> <E145 61 5><E118 61 0.5><E003 8><E025 3><E239>Une contradiction ?");
                s = s.Replace("Really, 'Oddo?!", "C'est vrai, Naruhodo ?!");
                s = s.Replace("(I don't quite know what it means yet, <E003 8><E025 3>but...)", "(Je ne sais pas encore exactement ce que cela signifie, <E003 8><E025 3>mais...)");
                return s;
            };

            // [23] _sce04_c102_0010_eng#19
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#19"] = (s) => {
                s = s.Replace("Yes, <E049><E003 8><E341><E338>there's an inconsistency in something that was said\r\nby...", "Oui, <E049><E003 8><E341><E338>il y a une contradiction dans ce qui a été dit\r\npar...");
                s = s.Replace("Yes, <E049><E003 8><E341><E338>there's an inconsistency in something that was said\nby...", "Oui, <E049><E003 8><E341><E338>il y a une contradiction dans ce qui a été dit\npar...");
                return s;
            };

            // [24] _sce04_c102_0010_eng#20
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#20"] = (s) => {
                s = s.Replace("Of course...<E003 12><E025 3>by you, <E049><E003 6>Gina.", "Par toi, <E003 12><E025 3>bien entendu, <E049><E003 6>Gina.");
                s = s.Replace("‘Of course’?<E049><E003 12>\r\nWot's that s'posed to mean, <E049><E003 6><E025 2>eh?", "« Bien entendu » ?<E049><E003 12>\r\nQu'est-ce que t'entends par là, <E049><E003 6><E025 2>hein ?");
                s = s.Replace("‘Of course’?<E049><E003 12>\nWot's that s'posed to mean, <E049><E003 6><E025 2>eh?", "« Bien entendu » ?<E049><E003 12>\nQu'est-ce que t'entends par là, <E049><E003 6><E025 2>hein ?");
                s = s.Replace("Gina, <E049><E003 8><E025 2>Mr Naruhodo?", "Gina, <E049><E003 8><E025 2>M. Naruhodo ?");
                s = s.Replace("Gina is the person giving testimony here, <E049><E003 8><E025 3>so...", "C'est Gina qui dépose à la barre, <E049><E003 8><E025 3>donc...");
                s = s.Replace("...if there are any inconsistencies, <E049><E003 10><E025 1><E346>they can only have\r\nbeen introduced by her!", "... si faille il y a, <E049><E003 10><E025 1><E346>elle ne peut venir\r\nque d'elle !");
                s = s.Replace("...if there are any inconsistencies, <E049><E003 10><E025 1><E346>they can only have\nbeen introduced by her!", "... si faille il y a, <E049><E003 10><E025 1><E346>elle ne peut venir\nque d'elle !");
                s = s.Replace("I don't know where you're going with this, <E049><E003 8><E025 3>but...", "J'ignore où vous voulez en venir, <E049><E003 8><E025 3>mais...");
                s = s.Replace("...maybe the evidence you're obviously about to show the\r\ncourt will clarify.", "... la pièce que vous vous apprêtez à nous montrer\r\néclairera sans doute la cour.");
                s = s.Replace("...maybe the evidence you're obviously about to show the\ncourt will clarify.", "... la pièce que vous vous apprêtez à nous montrer\ncourt will clarify.");
                return s;
            };

            // [25] _sce04_c102_0010_eng#28
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#28"] = (s) => {
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to\r\nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\r\nde ce qu'elle avance.");
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to\nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\nde ce qu'elle avance.");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged\r\ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\r\ncontradiction se rapporte-t-elle ?");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged\ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\ncontradiction se rapporte-t-elle ?");
                return s;
            };

            // [26] _sce04_c102_0010_eng#29
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#29"] = (s) => {
                s = s.Replace("It's this!<E049><E003 10> <E025 1><E164 1 8 1 2 8 0 2 1><E139 1>This is the proof that the apprentice detective's\r\nearlier statement is flawed!", "C'est ceci !<E049><E003 10> <E025 1><E164 1 8 1 2 8 0 2 1><E139 1>Voici la preuve que les dires de l'apprentie\r\ndétective sont erronés !");
                s = s.Replace("It's this!<E049><E003 10> <E025 1><E164 1 8 1 2 8 0 2 1><E139 1>This is the proof that the apprentice detective's\nearlier statement is flawed!", "C'est ceci !<E049><E003 10> <E025 1><E164 1 8 1 2 8 0 2 1><E139 1>Voici la preuve que les dires de l'apprentie\ndétective sont erronés !");
                s = s.Replace("It...<E003 12><E025 3><E330>it is?", "C'est...<E003 12><E025 3><E330>vrai ?");
                s = s.Replace("The only thing that evidence proves...", "La seule chose que prouve cette pièce...");
                s = s.Replace("...is that the man advocating for the defendant <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>is nothing\r\nmore than an apprentice lawyer!", "... c'est que l'avocat de l'accusé <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>n'est rien de plus\r\nqu'un apprenti homme de loi !");
                s = s.Replace("...is that the man advocating for the defendant <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>is nothing\nmore than an apprentice lawyer!", "... c'est que l'avocat de l'accusé <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>n'est rien de plus\nqu'un apprenti homme de loi !");
                s = s.Replace("That'll learn ya to go bandyin' that ‘apprentice’ claptrap\r\nabout!", "Ça t'apprendra à m'balancer ce mot d'« apprentie »\r\nà la figure !");
                s = s.Replace("That'll learn ya to go bandyin' that ‘apprentice’ claptrap\nabout!", "Ça t'apprendra à m'balancer ce mot d'« apprentie »\nà la figure !");
                s = s.Replace("Sorry...<E003 12>\r\n<E025 3><E007>(I really put my foot in it there.)", "Pardon...<E003 12>\r\n<E025 3><E007>(J'ai vraiment mis les pieds dans le plat.)");
                s = s.Replace("Sorry...<E003 12>\n<E025 3><E007>(I really put my foot in it there.)", "Pardon...<E003 12>\n<E025 3><E007>(J'ai vraiment mis les pieds dans le plat.)");
                s = s.Replace("I think this line of argument has run its course.", "J'estime que cette piste est épuisée.");
                s = s.Replace("And let its failure be a lesson <E049><E003 10><E239><E025 3>to all you apprentices.", "Et que cet échec serve de leçon <E049><E003 10><E239><E025 3>à tous vos pareils.");
                s = s.Replace("(I'd better listen very carefully to the testimony again...)", "(Je ferais mieux de réécouter très attentivement la déposition...)");
                return s;
            };

            // [27] _sce04_c102_0010_eng#30
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#30"] = (s) => {
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to \r\nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\r\nde ce qu'elle avance.");
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to \nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\nde ce qu'elle avance.");
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to\r\nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\r\nde ce qu'elle avance.");
                s = s.Replace("In that case, <E049><E003 8><E025 2>the defence will present evidence to\nsubstantiate its claim.", "Dans ce cas, <E049><E003 8><E025 2>la défense va produire la preuve\nde ce qu'elle avance.");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged \r\ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\r\ncontradiction se rapporte-t-elle ?");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged \ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\ncontradiction se rapporte-t-elle ?");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged\r\ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\r\ncontradiction se rapporte-t-elle ?");
                s = s.Replace("To which piece of evidence <E049><E003 10><E025 1><E346>does this alleged\ninconsistency relate?", "À quelle pièce à conviction <E049><E003 10><E025 1><E346>cette prétendue\ncontradiction se rapporte-t-elle ?");
                return s;
            };

            // [28] _sce04_c102_0010_eng#31
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#31"] = (s) => {
                s = s.Replace("I had hoped not to have to present this evidence,<E049><E003 8> <E341>but you\r\nleave me no choice.", "J'avais espéré ne pas devoir exhiber cette pièce,<E049><E003 8> <E341>mais vous\r\nne me laissez pas le choix.");
                s = s.Replace("I had hoped not to have to present this evidence,<E049><E003 8> <E341>but you\nleave me no choice.", "J'avais espéré ne pas devoir exhiber cette pièce,<E049><E003 8> <E341>mais vous\nleave me no choice.");
                s = s.Replace("What do you say to this, <E049><E003 6><E025 1>Lord van Zieks?!", "Qu'avez-vous à dire à cela, <E049><E003 6><E025 1>Lord Van Peers ?!");
                s = s.Replace("Your feelings were correct.<E049><E003 10> Presenting that evidence was\r\na mistake.<E049><E003 10> <E145 18 0><E003 8><E025 2><E330>I suggest you withdraw it.", "Votre intuition était juste.<E049><E003 10> Présenter cette preuve était\r\nune erreur.<E049><E003 10> <E145 18 0><E003 8><E025 2><E330>Je vous conseille de la retirer.");
                s = s.Replace("Your feelings were correct.<E049><E003 10> Presenting that evidence was\na mistake.<E049><E003 10> <E145 18 0><E003 8><E025 2><E330>I suggest you withdraw it.", "Votre intuition était juste.<E049><E003 10> Présenter cette preuve était\na mistake.<E049><E003 10> <E145 18 0><E003 8><E025 2><E330>Je vous conseille de la retirer.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Good advice.", "Bon conseil.");
                s = s.Replace("Because <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>you've turned decidedly ashen!", "Car <E049><E003 6><E025 1><E164 112 10 1 2 5 1 2 1><E139 112>vous venez de devenir affreusement pâle !");
                s = s.Replace("I only hope the Reaper doesn't hold that against you.", "J'espère simplement que le Faucheur ne vous en tiendra pas rigueur.");
                s = s.Replace("(Ugh...<E003 12>fingers crossed...)", "(Ouh là...<E003 12>croisons les doigts...)");
                s = s.Replace("I think this line of argument has run its course.", "J'estime que cette argumentation a fait son temps.");
                s = s.Replace("I suggest you learn from your mistakes...<E049><E003 10><E239>before you make\r\na fatal one in the eyes of the Reaper.", "Tirez les leçons de vos erreurs...<E049><E003 10><E239>avant d'en commettre\r\nune fatale aux yeux du Faucheur.");
                s = s.Replace("I suggest you learn from your mistakes...<E049><E003 10><E239>before you make\na fatal one in the eyes of the Reaper.", "Tirez les leçons de vos erreurs...<E049><E003 10><E239>avant d'en commettre\na fatal one in the eyes of the Reaper.");
                s = s.Replace("(I'd better listen very carefully to the testimony again...)", "(Je ferais bien de réécouter très attentivement la déposition...)");
                return s;
            };

            // [29] _sce04_c102_0010_eng#32
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#32"] = (s) => {
                s = s.Replace("Right, <E049><E003 10>I've 'ad just about enough o' this!", "Bon, <E049><E003 10>j'en ai ma claque de tout ça !");
                s = s.Replace("Gina?", "Gina ?");
                s = s.Replace("All this nonsense about the boss plannin' to kill people...<E003 16>\r\n<E025 1><E345><E342>It's cobblers! ", "Toutes ces salades sur l'patron qui prévoyait d'tuer des gens...<E003 16>\r\n<E025 1><E345><E342>C'est des bobards ! ");
                s = s.Replace("All this nonsense about the boss plannin' to kill people...<E003 16>\n<E025 1><E345><E342>It's cobblers! ", "Toutes ces salades sur l'patron qui prévoyait d'tuer des gens...<E003 16>\n<E025 1><E345><E342>C'est des bobards ! ");
                s = s.Replace("Come on, 'Oddo!", "Allez, Naruhodo !");
                s = s.Replace("Yes?", "Oui ?");
                s = s.Replace("Why ain't you sayin' nuffin'?", "Pourquoi tu dis rien ?");
                s = s.Replace("Why, <E049><E003 8>why ain't you yellin' out <E049><E003 15><E025 1><E338><E341><E239>‘objection’<E049><E003 10><E025 2> or summat?", "Pourquoi, <E049><E003 8>pourquoi tu cries pas <E049><E003 15><E025 1><E338><E341><E239>« objection ! »<E049><E003 10><E025 2> ou un truc dans l'genre ?");
                s = s.Replace("Wha...?", "Quoi... ?");
                s = s.Replace("You've gotta find a flaw!<E049><E003 15>\r\n<E025 1><E341>You do usually!", "Tu dois trouver une faille !<E049><E003 15>\r\n<E025 1><E341>C'est c'que tu fais d'habitude !");
                s = s.Replace("You've gotta find a flaw!<E049><E003 15>\n<E025 1><E341>You do usually!", "Tu dois trouver une faille !<E049><E003 15>\n<E025 1><E341>C'est c'que tu fais d'habitude !");
                s = s.Replace("Someone's lyin' 'ere, <E049><E003 6>no question!<E049><E003 12>\r\n<E335>You've gotta work out who it is!", "Y a quelqu'un qui ment ici, <E049><E003 6>c'est clair et net !<E049><E003 12>\r\n<E335>Tu dois découvrir qui c'est !");
                s = s.Replace("Someone's lyin' 'ere, <E049><E003 6>no question!<E049><E003 12>\n<E335>You've gotta work out who it is!", "Y a quelqu'un qui ment ici, <E049><E003 6>c'est clair et net !<E049><E003 12>\n<E335>Tu dois découvrir qui c'est !");
                s = s.Replace("Please...<E003 13>\r\n<E025 3>For the boss...", "Je t'en prie...<E003 13>\r\n<E025 3>Pour l'patron...");
                s = s.Replace("Please...<E003 13>\n<E025 3>For the boss...", "Je t'en prie...<E003 13>\n<E025 3>Pour l'patron...");
                s = s.Replace("That outburst <E049><E003 8><E025 2>was an insult to the court and to your own\r\ntestimony.", "Cet esclandre <E049><E003 8><E025 2>est une insulte à cette cour et à votre propre\r\ndéposition.");
                s = s.Replace("That outburst <E049><E003 8><E025 2>was an insult to the court and to your own\ntestimony.", "Cet esclandre <E049><E003 8><E025 2>est une insulte à cette cour et à votre propre\ndéposition.");
                s = s.Replace("I might have known <E049><E003 10><E239>that a common pickpocket from the\r\nback slums couldn't make a detective.", "J'aurais dû m'en douter : <E049><E003 10><E239>une vulgaire pickpocket des bas-fonds\r\nne fera jamais une détective.");
                s = s.Replace("I might have known <E049><E003 10><E239>that a common pickpocket from the\nback slums couldn't make a detective.", "J'aurais dû m'en douter : <E049><E003 10><E239>une vulgaire pickpocket des bas-fonds\nne fera jamais une détective.");
                s = s.Replace("When this trial is over, <E049><E003 10>you will forfeit your warrant card,<E049><E003 8>\r\nMiss Lestrade.", "Une fois ce procès achevé, <E049><E003 10>vous restituerez votre plaque de police,<E049><E003 8>\r\nMademoiselle Lestrade.");
                s = s.Replace("When this trial is over, <E049><E003 10>you will forfeit your warrant card,<E049><E003 8>\nMiss Lestrade.", "Une fois ce procès achevé, <E049><E003 10>vous restituerez votre plaque de police,<E049><E003 8>\nMademoiselle Lestrade.");
                s = s.Replace("Is that clear?", "Est-ce clair ?");
                s = s.Replace("I've 'ad it wiv the lot o' ya!<E003 10> <E025 1>It's lies every bleedin' place\r\nya look in this world, <E049><E003 6>innit?<E049><E003 18> <E346>Well I've 'ad enough!", "J'en ai ras l'bol de vous tous !<E003 10> <E025 1>Y a qu'des mensonges où qu'on\r\nregarde dans c'fichu monde, <E049><E003 6>pas vrai ?<E049><E003 18> <E346>Eh ben j'en ai assez !");
                s = s.Replace("I've 'ad it wiv the lot o' ya!<E003 10> <E025 1>It's lies every bleedin' place\nya look in this world, <E049><E003 6>innit?<E049><E003 18> <E346>Well I've 'ad enough!", "J'en ai ras l'bol de vous tous !<E003 10> <E025 1>Y a qu'des mensonges où qu'on\nregarde dans c'fichu monde, <E049><E003 6>pas vrai ?<E049><E003 18> <E346>Eh ben j'en ai assez !");
                s = s.Replace("So have I.<E003 12> <E025 2>After that little speech of Gina's,<E003 8> <E025 3>I've made up\r\nmy mind...", "Moi aussi.<E003 12> <E025 2>Après ces paroles de Gina,<E003 8> <E025 3>ma décision\r\nest prise...");
                s = s.Replace("So have I.<E003 12> <E025 2>After that little speech of Gina's,<E003 8> <E025 3>I've made up\nmy mind...", "Moi aussi.<E003 12> <E025 2>Après ces paroles de Gina,<E003 8> <E025 3>ma décision\nest prise...");
                s = s.Replace("To do what, <E049><E003 6>Mr Naruhodo?", "Prendre quelle décision, <E049><E003 6>M. Naruhodo ?");
                s = s.Replace("There was one point in this cross-examination...", "À un certain moment de ce contre-interrogatoire...");
                s = s.Replace("...when something that was said just didn't sit right with\r\nme.<E003 14> <E238><E006><E025 3>One statement that seemed odd<E005>.", "... quelque chose qui a été dit m'a paru incongru.<E003 14>\r\n<E238><E006><E025 3>Une déclaration pour le moins suspecte<E005>.");
                s = s.Replace("...when something that was said just didn't sit right with\nme.<E003 14> <E238><E006><E025 3>One statement that seemed odd<E005>.", "... quelque chose qui a été dit m'a paru incongru.<E003 14>\n<E238><E006><E025 3>Une déclaration pour le moins suspecte<E005>.");
                s = s.Replace("Oh!<E049><E003 12> <E025 2>Do, <E049><E003 8><E341>do you mean...?", "Oh !<E049><E003 12> <E025 2>Vou... <E049><E003 8><E341>vous voulez dire... ?");
                s = s.Replace("(I'm not going to let Gina's plea for help <E003 8><E145 1 7><E118 1 1.3><E003 8><E025 1><E346><E342>fall on deaf ears.)", "(Je ne laisserai pas le cri du cœur de Gina <E003 8><E145 1 7><E118 1 1.3><E003 8><E025 1><E346><E342>rester lettre morte.)");
                return s;
            };

            // [30] _sce04_c102_0010_eng#33
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#33"] = (s) => {
                s = s.Replace("Do you have something to say about that, <E049><E003 4><E025 3>Gina?", "As-tu quelque chose à dire là-dessus, <E049><E003 4><E025 3>Gina ?");
                s = s.Replace("...'Ow'd it come to this, <E003 4>eh, boss...?", "... Comment on a pu en arriver là, <E003 4>hein, patron... ?");
                s = s.Replace("(She's lost in her thoughts about Gregson...<E003 12>\r\n<E025 2>I suppose I shouldn't be surprised.)", "(Elle est perdue dans ses pensées au sujet de Gregson...<E003 12>\r\n<E025 2>Rien de surprenant à cela.)");
                s = s.Replace("(She's lost in her thoughts about Gregson...<E003 12>\n<E025 2>I suppose I shouldn't be surprised.)", "(Elle est perdue dans ses pensées au sujet de Gregson...<E003 12>\n<E025 2>Rien de surprenant à cela.)");
                s = s.Replace("(I probably shouldn't pursue her too hard unless she\r\nreally reacts strangely to something.)", "(Je devrais éviter d'insister à moins qu'elle\r\nne réagisse curieusement à quelque chose.)");
                s = s.Replace("(I probably shouldn't pursue her too hard unless she\nreally reacts strangely to something.)", "(Je devrais éviter d'insister à moins qu'elle\nne réagisse curieusement à quelque chose.)");
                s = s.Replace("Let's focus on the testimony, please, <E049><E003 4><E025 3>Counsel.", "Revenons au témoignage, je vous prie, <E049><E003 4><E025 3>Maître.");
                return s;
            };
        }
    }
}
