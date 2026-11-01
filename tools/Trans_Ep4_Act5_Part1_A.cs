using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart1_A() {
            // [1] BB\script\output\_sce03_c200_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c200_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November, 3:38 p.m.\r\n<CNTR><E003 5>Sholmes's Suite", "2 novembre, 15 h 38\r\n<CNTR><E003 5>Appartement de Sholmes");
                s = s.Replace("I still can't quite believe what just happened.", "J'ai encore du mal à croire ce qui vient de se passer.");
                s = s.Replace("I know.<E049><E003 10> I enquired with the bailiff after the court session\r\nwas adjourned...", "Je sais.<E049><E003 10> Je me suis renseignée auprès de l'huissier après\r\nla suspension de l'audience...");
                s = s.Replace("...and it seems <E049><E003 8><E025 3><E330>Mr Vigil was taken to hospital to recover.", "...et il semble que <E049><E003 8><E025 3><E330>M. Vigil ait été transporté à l'hôpital pour se remettre.");
                s = s.Replace("Right...", "Je vois...");
                s = s.Replace("Ten years ago now...", "Il y a dix ans déjà...");
                s = s.Replace("...Mr Vigil attempted to commit suicide by jumping\r\n<E042><CNTR>out of the window of the prison governor's office.", "...M. Vigil a tenté de se suicider en sautant par la\r\n<E042><CNTR>fenêtre du bureau du gouverneur de la prison.");
                s = s.Replace("But ever since then...<E003 10>he's completely blocked\r\n<E042><CNTR>the memory of those events from his mind.", "Mais depuis lors...<E003 10>il a complètement occulté\r\n<E042><CNTR>le souvenir de ces événements de sa mémoire.");
                s = s.Replace("Nobody knew his secret.<E003 12> Not his family.<E003 10> Not even the\r\n<E042><CNTR>man himself.<E003 10> But I...<E003 10> I forced it out into the open.", "Personne ne connaissait son secret.<E003 12> Ni sa famille.<E003 10> Pas même le\r\n<E042><CNTR>principal intéressé.<E003 10> Mais moi...<E003 10> je l'ai forcé à se faire jour.");
                s = s.Replace("Was it wrong of me to do that?<E003 12>\r\n<E042><CNTR>Did I overstep the mark, <E003 8>I wonder...?", "Ai-je eu tort de faire cela ?<E003 12>\r\n<E042><CNTR>Ai-je dépassé les bornes, <E003 8>je me le demande... ?");
                s = s.Replace("Ruuunooo!", "Ruuunooo !");
                s = s.Replace("Oh!<E003 12> Iris...", "Oh !<E003 12> Iris...");
                s = s.Replace("You were miles away!<E049><E003 10>\r\n<E025 2>Anyway, <E003 4>I've brewed a fresh pot of soothing tea for you.", "Tu étais à mille lieues d'ici !<E049><E003 10>\r\n<E025 2>Quoi qu'il en soit, <E003 4>j'ai préparé une théière de thé apaisant pour vous.");
                s = s.Replace("Oh, <E003 8><E025 3>thank you.", "Oh, <E003 8><E025 3>merci.");
                s = s.Replace("You and Susie have had an exhausting day so far,<E049><E003 6><E145 4 77><E003 5> haven't\r\nyou?", "Susie et toi avez eu une journée épuisante jusqu'ici,<E049><E003 6><E145 4 77><E003 5> n'est-ce\r\npas ?");
                s = s.Replace("Thank you, Iris.<E049><E003 12>\r\n<E025 2>How thoughtful of you.", "Merci, Iris.<E049><E003 12>\r\n<E025 2>C'est si attentionné de ta part.");
                s = s.Replace("Do you happen to know <E003 8><E025 2><E330>where Mr Sholmes is?<E145 4 64>", "Sais-tu par hasard <E003 8><E025 2><E330>où se trouve M. Sholmes ?<E145 4 64>");
                s = s.Replace("When we came out of the courtroom back into the\r\ndefendants' antechamber, <E003 6><E025 3>he'd disappeared.", "Quand nous sommes sortis de la salle d'audience pour regagner\r\nl'antichambre des accusés, <E003 6><E025 3>il avait disparu.");
                s = s.Replace("Oh...<E003 10><E025 3>no, <E049><E003 8><E025 2>I don't know.", "Oh...<E003 10><E025 3>non, <E049><E003 8><E025 2>je ne sais pas.");
                s = s.Replace("He just suddenly sprang to his feet and left.<E049><E003 12>\r\nAll he said was, <E049><E003 6><E025 3>‘I must leave.’", "Il s'est levé d'un bond soudain et est parti.<E049><E003 12>\r\nIl a simplement dit : <E049><E003 6><E025 3>« Je dois partir. »");
                s = s.Replace("I wonder if he's pursuing the mystery of Inspector\r\nGregson's death...", "Je me demande s'il est parti éclaircir le mystère de la\r\nmort de l'inspecteur Gregson...");
                s = s.Replace("Well, <E049><E003 6>you know what Hurley's always saying, <E003 4>don't you?", "Eh bien, <E049><E003 6>tu sais ce que dit toujours Hurley, <E003 4>n'est-ce pas ?");
                s = s.Replace("‘There are mysteries in this world that should perhaps\r\nnever be solved.’", "« Il est des mystères en ce monde qui ne devraient peut-être\r\njamais être résolus. »");
                s = s.Replace("‘For the construction of a solution comes only at the\r\nexpense of the destruction of something else...’", "« Car l'édification d'une solution ne se fait jamais qu'au\r\ndétriment de la destruction d'autre chose... »");
                s = s.Replace("(What does that mean...?)", "(Qu'est-ce que cela veut dire... ?)");
                s = s.Replace("He knows very well that when you open someone else's\r\nold wounds, <E049><E003 6>you often open your own, too.", "Il sait pertinemment que lorsqu'on rouvre les vieilles\r\nblessures d'autrui, <E049><E003 6>on rouvre souvent les siennes.");
                s = s.Replace("But he just can't take his own advice and leave well alone.<E049><E145 4 64><E118 4 1.3><E003 15>\r\n<E025 2>Solving mysteries is too important to him.", "Mais il est incapable de suivre ses propres conseils.<E049><E145 4 64><E118 4 1.3><E003 15>\r\n<E025 2>Résoudre les mystères compte bien trop pour lui.");
                s = s.Replace("That's so true.", "C'est bien vrai.");
                s = s.Replace("But that's what I like about Hurley, after all!", "Mais c'est pour ça que j'aime Hurley, après tout !");
                s = s.Replace("(I suppose that's the lot of a great detective in some\r\nways...)", "(J'imagine que c'est le lot d'un grand détective par\r\nbien des aspects...)");
                s = s.Replace("So then...", "Alors...");
                s = s.Replace("...let's have tea <E049><E003 4><E164 4 67 1 2 8 0 1 1><E139 4><E025 1>and then I'll give you a hand!", "...prenons le thé <E049><E003 4><E164 4 67 1 2 8 0 1 1><E139 4><E025 1>et ensuite je vous donnerai un coup de main !");
                s = s.Replace("Oh!<E003 12> Do you have time, <E003 4>Iris?", "Oh !<E003 12> As-tu le temps, <E003 4>Iris ?");
                s = s.Replace("Yes, <E049><E003 6>I've finished this month's manuscript at last.<E049><E003 6>\r\n<E025 1><E145 4 65><E003 8><E341>With barely a day to spare before the deadline!", "Oui, <E049><E003 6>j'ai enfin terminé le manuscrit de ce mois.<E049><E003 6>\r\n<E025 1><E145 4 65><E003 8><E341>Avec à peine un jour d'avance sur la date limite !");
                s = s.Replace("Oh, <E049><E003 8>I'm so looking forward to it.<E049><E003 6> <E025 1><E136 3 75 5><E117 3 15><E003 3><E149 3 0 0><E003 6><E346>A brand new story to\r\nread in ‘The Adventures of Herlock Sholmes’!", "Oh, <E049><E003 8>j'ai tellement hâte de le lire.<E049><E003 6> <E025 1><E136 3 75 5><E117 3 15><E003 3><E149 3 0 0><E003 6><E346>Une toute nouvelle aventure\r\nà découvrir dans « Les Aventures d'Herlock Sholmes » !");
                s = s.Replace("You know, <E049><E003 4><E164 4 68 1 2 6 0 0 1><E139 4><E025 1>I always hide Hurley's violin in the days\r\nbefore I have a deadline.", "Vous savez, <E049><E003 4><E164 4 68 1 2 6 0 0 1><E139 4><E025 1>je cache toujours le violon d'Hurley les jours\r\nqui précèdent la date de remise.");
                s = s.Replace("You, <E003 8>you do?<E003 10>\r\n<E025 3><E007>(Poor Mr Sholmes...)", "V-... <E003 8>Vraiment ?<E003 10>\r\n<E025 3><E007>(Pauvre M. Sholmes...)");
                s = s.Replace("I'm sure that's very wise, Iris.<E049><E003 6>\r\n<E025 1><E164 3 87 1 2 8 0 1 1><E139 3>How sensible of you!", "Je suis sûre que c'est très sage, Iris.<E049><E003 6>\r\n<E025 1><E164 3 87 1 2 8 0 1 1><E139 3>Quelle prévoyance !");
                s = s.Replace("Now then, <E049><E003 8>my dear fellows, <E049><E003 2><E164 4 66 1 2 8 1 1 1><E118 4 1.3><E139 4><E025 1>let's make a plan of action\r\nbefore we continue our investigation!", "À présent, <E049><E003 8>mes chers amis, <E049><E003 2><E164 4 66 1 2 8 1 1 1><E118 4 1.3><E139 4><E025 1>établissons un plan d'action\r\navant de poursuivre notre enquête !");
                return s;
            };

            // [2] BB\script\output\_sce03_c200_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c200_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Well, <E049><E003 10>I think it's clear what we need to do, <E003 4>isn't it?", "Eh bien, <E049><E003 10>je pense que la marche à suivre est claire, <E003 4>n'est-ce pas ?");
                s = s.Replace("Let us investigate, <E049><E003 8>my dear fellows!", "Menons l'enquête, <E049><E003 8>mes chers amis !");
                s = s.Replace("Oh, <E049><E003 8>Iris!<E049><E003 6> <E025 1><E164 3 87 1 2 8 0 1 1><E139 3>You're even more enthusiastic than usual today.", "Oh, <E049><E003 8>Iris !<E049><E003 6> <E025 1><E164 3 87 1 2 8 0 1 1><E139 3>Tu es encore plus enthousiaste que d'habitude aujourd'hui.");
                s = s.Replace("If anyone has anything to hide, <E049><E003 4><E025 1><E164 4 85 1 2 5 0 2 1><E487 4 27 5 3><E204 132 16 0><E139 4>my special Wilson\r\nShooting Iron will soon set them straight!", "Si quiconque a quelque chose à cacher, <E049><E003 4><E025 1><E164 4 85 1 2 5 0 2 1><E487 4 27 5 3><E204 132 16 0><E139 4>mon flingue spécial\r\nWilson aura vite fait de lui délier la langue !");
                s = s.Replace("...That...<E003 10>water pistol?<E145 3 64><E171 3 1 1 9 2>", "...Ce...<E003 10>pistolet à eau ?<E145 3 64><E171 3 1 1 9 2>");
                s = s.Replace("It's stuffed full of a piping-hot extra-special blend of mine!", "Il est rempli à ras bord d'une mixture brûlante extra-spéciale de mon cru !");
                s = s.Replace("Then I'm quite sure it will be very effective.", "Dans ce cas, je suis tout à fait certaine de son efficacité.");
                s = s.Replace("(...I'd better be careful not to hide anything.)", "(...J'ai plutôt intérêt à ne rien cacher.)");
                s = s.Replace("Well...<E145 4 64><E171 4 2 1 1 2><E003 8><E025 2>it feels a little strange that Mr Sholmes is nowhere<E145 3 64><E171 3 1 0 0 3>\r\nto be seen, <E003 6><E025 3>but still...", "Bien...<E145 4 64><E171 4 2 1 1 2><E003 8><E025 2>c'est un peu étrange que M. Sholmes demeure introuvable,<E145 3 64><E171 3 1 0 0 3>\r\n<E003 6><E025 3>mais quoi qu'il en soit...");
                s = s.Replace("...let's go and see what we can find out!", "...allons voir ce que nous pouvons découvrir !");
                s = s.Replace("Yes!", "Oui !");
                return s;
            };

            // [3] BB\script\output\_sce03_c201_0010_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Local Prison, Cell 1", "2 novembre\r\n<CNTR><E003 5>Prison locale, cellule 1");
                s = s.Replace("...Lord van Zieks is reading, <E003 4>look.", "...Lord Van Peers est en train de lire, <E003 4>regardez.");
                s = s.Replace("He doesn't seem like he wants visitors, <E003 4>does he?", "Il n'a pas vraiment l'air de vouloir des visites, <E003 4>n'est-ce pas ?");
                s = s.Replace("But he must have noticed that we're here, <E003 6><E025 3>surely?", "Mais il a forcément remarqué notre présence, <E003 6><E025 3>non ?");
                s = s.Replace("What do you Nipponese want?", "Que voulez-vous, les Japonais ?");
                s = s.Replace("That's no way to greet the lawyer who's trying his\r\nhardest to prove your innocence, <E003 4>is it?", "Ce n'est pas une façon d'accueillir l'avocat qui fait tout\r\nson possible pour prouver votre innocence, <E003 4>si ?");
                s = s.Replace("Perhaps not.", "Peut-être pas.");
                s = s.Replace("Hm?!", "Hein ?!");
                s = s.Replace("I apologise.<E049><E003 14>\r\n<E025 2><E239>So, <E049><E003 8>what can I do for you, <E049><E003 6>Mr Naruhodo?", "Je vous présente mes excuses.<E049><E003 14>\r\n<E025 2><E239>Alors, <E049><E003 8>que puis-je faire pour vous, <E049><E003 6>monsieur Naruhodo ?");
                s = s.Replace("Lord van Zieks...<E049><E003 10><E342>speaking earnestly!", "Lord Van Peers...<E049><E003 10><E342>qui parle avec sincérité !");
                s = s.Replace("Oh, <E049><E003 8><E342>the fog will lift over London for the first time in\r\nmonths tomorrow!", "Oh, <E049><E003 8><E342>le brouillard va se dissiper sur Londres pour la\r\npremière fois depuis des mois, demain !");
                s = s.Replace("(This does feel very, <E003 8>very strange...)", "(C'est vraiment, <E003 8>très curieux comme sensation...)");
                s = s.Replace("I must say, <E049><E003 8>I was impressed.", "Je dois dire <E049><E003 8>que j'ai été impressionné.");
                s = s.Replace("Oh!<E003 15> Well...<E003 12><E342>thank you!", "Oh !<E003 15> Eh bien...<E003 12><E342>merci !");
                s = s.Replace("Not by you.<E049><E003 12> <E025 2>By your fellow Nipponese.<E049><E003 14>\r\n<E025 3>Your prosecutor friend.", "Pas par vous.<E049><E003 12> <E025 2>Par votre compatriote japonais.<E049><E003 14>\r\n<E025 3>Votre ami procureur.");
                s = s.Replace("Oh...<E003 10><E341>I see.<E003 12> Yes.", "Oh...<E003 10><E341>je vois.<E003 12> Oui.");
                s = s.Replace("It's sardonic, <E049><E003 8><E025 2>don't you think?", "C'est ironique, <E049><E003 8><E025 2>ne trouvez-vous pas ?");
                s = s.Replace("For a man such as me, <E049><E003 8>so loathing of the Nipponese,<E049><E003 12> <E025 3>to be\r\nentirely at the mercy of the two of you.", "Qu'un homme tel que moi, <E049><E003 8>qui voue un tel mépris aux Japonais,<E049><E003 12> <E025 3>se\r\nretrouve entièrement à votre merci à tous les deux.");
                s = s.Replace("I suppose...", "J'imagine que...");
                s = s.Replace("...it's retribution for having played the part of the Reaper\r\nall these years.", "...c'est le juste châtiment pour avoir joué le rôle du\r\nRevenant toutes ces années durant.");
                s = s.Replace("(Played the part...?)", "(Joué le rôle... ?)");
                return s;
            };

            // [4] BB\script\output\_sce03_c201_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("That's the end of my miserable tale.<E049><E003 10>\r\n<E025 3><E145 18 9><E003 10>...I never thought I'd recount it to anyone.", "Voilà qui conclut mon misérable récit.<E049><E003 10>\r\n<E025 3><E145 18 9><E003 10>...Je n'aurais jamais cru devoir le relater à quiconque.");
                s = s.Replace("Well, <E003 8><E025 3>thank you...<E003 10><E025 3>for confiding in me.", "Eh bien, <E003 8><E025 3>merci...<E003 10><E025 3>de vous être confié à moi.");
                s = s.Replace("The Professor, <E049><E003 8>the Reaper <E049><E003 8><E145 3 83><E025 3>and Inspector Gregson...", "Le Professeur, <E049><E003 8>le Revenant <E049><E003 8><E145 3 83><E025 3>et l'inspecteur Gregson...");
                s = s.Replace("I wonder just how intimately related they all are...", "Je me demande à quel point tout cela est intimement lié...");
                s = s.Replace("I still can't quite believe <E003 10><E341>that Gregson was essentially<E145 110 73> the\r\nReaper.", "J'ai encore du mal à croire <E003 10><E341>que Gregson était en réalité<E145 110 73> le\r\nRevenant.");
                s = s.Replace("(Giving assassination orders <E145 3 77><E149 3 0 4><E003 6><E239>to Jezaille Brett...)", "(Donnant des ordres d'assassinat <E145 3 77><E149 3 0 4><E003 6><E239>à Jezaille Brett...)");
                s = s.Replace("Mr Naruhodo, <E049><E003 5><E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3><E025 1>let's go and inform my father!", "Monsieur Naruhodo, <E049><E003 5><E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3><E025 1>allons en informer mon père !");
                s = s.Replace("I'm sure our government will want to hear about this new\r\ninformation.", "Je suis sûre que notre gouvernement voudra être tenu informé de ces révélations.");
                s = s.Replace("Oh!<E049><E003 8> That means I get to meet your daddy, <E003 4>Susie!<E049><E003 8>\r\n<E025 1><E164 110 68 1 2 8 0 1 1><E139 110>Hurray!", "Oh !<E049><E003 8> Ça veut dire que je vais pouvoir rencontrer ton papa, <E003 4>Susie !<E049><E003 8>\r\n<E025 1><E164 110 68 1 2 8 0 1 1><E139 110>Hourra !");
                s = s.Replace("Yes, <E003 8>alright.", "Oui, <E003 8>entendu.");
                s = s.Replace("(Let's head back to the Great Waterloo Hotel then!)", "(Retournons donc au Grand Hôtel Waterloo !)");
                return s;
            };

            // [5] BB\script\output\_sce03_c201_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Great Waterloo Hotel Foyer", "2 novembre\r\n<CNTR><E003 5>Hall du Grand Hôtel Waterloo");
                s = s.Replace("I thought it yesterday and I think it again today.<E049><E003 10>\r\nThis place is so...<E003 8><E025 3>princely.", "Je le pensais hier et je le pense encore aujourd'hui.<E049><E003 10>\r\nCet endroit est tellement...<E003 8><E025 3>princier.");
                s = s.Replace("It's a wild guess, <E003 8><E025 2>but I have a feeling <E145 110 64><E118 110 1.2>you'll think the same\r\ntomorrow, too.", "C'est une supposition hasardeuse, <E003 8><E025 2>mais j'ai le sentiment <E145 110 64><E118 110 1.2>que vous\r\npenserez la même chose demain.");
                s = s.Replace("My tea <E164 110 66 1 2 6 0 0 1><E118 110 1.3>has a finer fragrance <E171 3 1 1 1 1><E139 110>than whatever they're\r\nserving in the tea room here though, <E049><E003 6>wouldn't you say?", "Mon thé <E164 110 66 1 2 6 0 0 1><E118 110 1.3>a un arôme bien plus délicat <E171 3 1 1 1 1><E139 110>que tout ce qu'ils\r\nservent dans leur salon, <E049><E003 6>vous ne trouvez pas ?");
                s = s.Replace("Ah, <E003 4><E145 3 67><E145 110 72><E003 6>look who we have here!<E003 15>\r\n<E025 2>This is an unexpected pleasure.", "Ah, <E003 4><E145 3 67><E145 110 72><E003 6>regardez qui voilà !<E003 15>\r\n<E025 2>Quel plaisir inattendu.");
                s = s.Replace("Ah...<E049><E003 12><E164 3 87 1 2 1 0 1 1><E139 3><E025 1>Father!", "Ah...<E049><E003 12><E164 3 87 1 2 1 0 1 1><E139 3><E025 1>Père !");
                s = s.Replace("Ooh!<E049><E003 16> Is this your daddy, Susie?<E049><E003 14>\r\n<E145 46 68><E118 46 2.0><E346>How lovely!", "Ooh !<E049><E003 16> C'est ton papa, Susie ?<E049><E003 14>\r\n<E145 46 68><E118 46 2.0><E346>Comme c'est merveilleux !");
                s = s.Replace("...What a charming <E145 110 64><E118 110 1.2>young lady.<E049><E003 8><E145 46 71><E117 46 10><E003 4>\r\n<E025 2>And you are...?", "...Quelle charmante <E145 110 64><E118 110 1.2>jeune demoiselle.<E049><E003 8><E145 46 71><E117 46 10><E003 4>\r\n<E025 2>Et vous êtes... ?");
                s = s.Replace("Ah, really?<E049><E003 10> <E025 2>So you're the author of ‘The Adventures of\r\nHerlock Sholmes’, <E003 6>are you?", "Ah, vraiment ?<E049><E003 10> <E025 2>Vous êtes donc l'autrice des « Aventures\r\nd'Herlock Sholmes », <E003 6>n'est-ce pas ?");
                s = s.Replace("That's me!<E049><E003 15>\r\n<E025 2>Iris Wilson, <E003 6>at your service, sir!", "C'est bien moi !<E049><E003 15>\r\n<E025 2>Iris Wilson, <E003 6>à votre service, monsieur !");
                s = s.Replace("Susie's been such a wonderful friend to me over the last\r\nyear, <E003 6>you know!", "Susie a été une amie si formidable pour moi tout au long\r\nde cette année, <E003 6>vous savez !");
                s = s.Replace("Well, <E049><E003 6><E025 3>Miss Wilson...<E049><E003 10> <E145 46 71><E117 46 20><E025 2>I must say I read your work regularly\r\nand with much interest.", "Eh bien, <E049><E003 6><E025 3>mademoiselle Wilson...<E049><E003 10> <E145 46 71><E117 46 20><E025 2>je dois dire que je vous lis\r\nrégulièrement et avec un très vif intérêt.");
                s = s.Replace("Iris actually <E160 3><E118 3 1.2><E139 3><E333>lives with Mr Sholmes, you know, <E003 4>Father.", "En réalité, Iris <E160 3><E118 3 1.2><E139 3><E333>vit avec M. Sholmes, tu sais, <E003 4>Père.");
                s = s.Replace("Is that so?<E049><E003 12> <E025 2>Well, <E049><E003 8><E145 46 71><E117 46 15><E003 6><E333>perhaps that goes some way to explaining\r\nthat bright look in your eyes.", "Vraiment ?<E049><E003 12> <E025 2>Eh bien, <E049><E003 8><E145 46 71><E117 46 15><E003 6><E333>cela explique peut-être en partie\r\nla vivacité qui brille dans votre regard.");
                s = s.Replace("Hee hee!", "Hé hé !");
                s = s.Replace("(You wouldn't be smiling so airily <E003 8><E025 3><E333>if you knew just how\r\nbright she is, <E003 6>believe me.)", "(Vous ne souririez pas d'un air si détaché <E003 8><E025 3><E333>si vous saviez à\r\nquel point elle est brillante, <E003 6>croyez-moi.)");
                s = s.Replace("Now then, <E049><E003 6><E025 2>young Naruhodo.<E049><E003 10> It was a pleasure seeing you\r\nin action earlier.", "À présent, <E049><E003 6><E025 2>jeune Naruhodo.<E049><E003 10> Ce fut un plaisir de vous voir à\r\nl'œuvre tout à l'heure.");
                s = s.Replace("As an invitee of the symposium, <E049><E003 6>I was allowed to observe\r\nfrom the gallery.<E049><E003 10> ...After I twisted some arms.", "En tant qu'invité du colloque, <E049><E003 6>j'ai pu assister aux débats\r\ndepuis la galerie.<E049><E003 10> ...Après avoir forcé la main à quelques personnes.");
                s = s.Replace("And I must say, <E049><E003 8><E025 2>it was a truly exemplary performance!", "Et je dois dire <E049><E003 8><E025 2>que c'était une plaidoirie exemplaire !");
                s = s.Replace("Oh!<E003 12> <E025 3>Well...<E003 12><E025 1><E338><E341>thank you very much.", "Oh !<E003 12> <E025 3>Eh bien...<E003 12><E025 1><E338><E341>merci beaucoup.");
                s = s.Replace("(Although I'm fairly sure you omitted <E003 8><E239><E025 3>‘<E006>by Kazuma<E007>’ <E003 6>on the\r\nend there.)", "(Bien que je sois presque sûr que vous avez omis <E003 8><E239><E025 3>« <E006>de Kazuma<E007> » <E003 6>à la fin...)");
                s = s.Replace("No no no, <E049><E003 10>please don't misunderstand!<E049><E003 12>\r\n<E341>It was you who impressed me.", "Non non non, <E049><E003 10>ne vous méprenez pas !<E049><E003 12>\r\n<E341>C'est bien vous qui m'avez impressionné.");
                s = s.Replace("Really?!", "Vraiment ?!");
                s = s.Replace("You didn't miss a step against Asogi.<E049><E003 10> <E025 3>And we all know\r\nhow capable he is.", "Vous n'avez pas bronché face à Asogi.<E049><E003 10> <E025 3>Et nous savons tous\r\nà quel point il est brillant.");
                s = s.Replace("Really, <E049><E003 8><E025 2>to have matured into such a fine defence lawyer\r\nin less than a year <E049><E003 10><E338><E342><E025 3>is quite extraordinary.", "Vraiment, <E049><E003 8><E025 2>être devenu un avocat de la défense aussi accompli\r\nen moins d'un an, <E049><E003 10><E338><E342><E025 3>c'est tout bonnement extraordinaire.");
                s = s.Replace("It's...<E003 10><E025 2><E341>very kind of you to say so.", "C'est...<E003 10><E025 2><E341>très aimable à vous.");
                s = s.Replace("(And really nice to hear.)", "(Et ça fait vraiment plaisir à entendre.)");
                s = s.Replace("What I saw in court today <E049><E003 8><E330><E025 3>confirmed what I'd been hoping\r\nfor.", "Ce que j'ai vu au tribunal aujourd'hui <E049><E003 8><E330><E025 3>a confirmé tous mes\r\nespoirs.");
                s = s.Replace("The favour I mentioned yesterday, <E003 4>Naruhodo.<E049><E003 12>\r\n<E025 3>I trust you haven't forgotten?", "Le service dont je vous ai parlé hier, <E003 4>Naruhodo.<E049><E003 12>\r\n<E025 3>J'ose espérer que vous ne l'avez pas oublié ?");
                s = s.Replace("Oh!<E003 10> <E025 3>No, <E003 8><E025 2>you...<E003 10>you did mention something, <E003 4>didn't you?", "Oh !<E003 10> <E025 3>Non, <E003 8><E025 2>vous...<E003 10>vous en avez parlé, <E003 4>en effet...");
                s = s.Replace("But first!<E049><E003 6> <E025 1><E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3>We have something to report, <E003 6>Father.", "Mais d'abord !<E049><E003 6> <E025 1><E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3>Nous avons quelque chose à te rapporter, <E003 6>Père.");
                s = s.Replace("Of course, <E049><E003 4>of course.<E049><E003 12> <E025 2>Shall we take tea while we discuss\r\nmatters further?", "Bien sûr, <E049><E003 4>bien sûr.<E049><E003 12> <E025 2>Prendrions-nous un thé tout en approfondissant\r\nla question ?");
                s = s.Replace("(Hm...)", "(Hm...)");
                s = s.Replace("(...I wonder where Judge Jigoku has got to.)", "(...Je me demande où le juge Jigoku a bien pu passer.)");
                return s;
            };

            // [6] BB\script\output\_sce03_c201_0040_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0040_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Well...<E049><E003 8>if you'll excuse me now.", "Bien...<E049><E003 8>si vous voulez bien m'excuser.");
                s = s.Replace("I need to telegram government ministers and the\r\nJapanese police with this information about Asa Shinn.", "Je dois envoyer un télégramme aux ministres du gouvernement\r\net à la police japonaise concernant ces informations sur Asa Shinn.");
                s = s.Replace("Of course, <E049><E003 6>Father.<E049><E003 10>\r\nThank you.", "Bien entendu, <E049><E003 6>Père.<E049><E003 10>\r\nMerci.");
                s = s.Replace("I look forward to next month's instalment, <E049><E003 6>Miss Wilson.", "J'attends avec impatience le numéro du mois prochain, <E049><E003 6>mademoiselle Wilson.");
                s = s.Replace("Oh good!<E049><E003 10> And please, <E049><E003 6><E338><E341>do come to Baker Street sometime,<E049><E003 8>\r\nwon't you?", "Merveilleux !<E049><E003 10> Et de grâce, <E049><E003 6><E338><E341>passez donc nous voir à Baker Street,<E049><E003 8>\r\nà l'occasion !");
                s = s.Replace("We'd love to entertain you!", "Nous serions ravis de vous recevoir !");
                s = s.Replace("I would be delighted.", "Ce serait un véritable plaisir.");
                s = s.Replace("The best of luck for tomorrow, <E049><E003 8><E025 3>Naruhodo.", "Bonne chance pour demain, <E049><E003 8><E025 3>Naruhodo.");
                s = s.Replace("And...", "Et...");
                s = s.Replace("...give my suggestion your full consideration, <E049><E003 6>won't you?", "...réfléchissez mûrement à ma proposition, <E049><E003 6>d'accord ?");
                s = s.Replace("Yes, <E003 8>I will.<E003 13>\r\n<E025 3><E007>(Going back home...?)", "Oui, <E003 8>je le ferai.<E003 13>\r\n<E025 3><E007>(Rentrer au pays... ?)");
                s = s.Replace("You know, <E049><E003 8>Kazuma-sama has always meant a great deal\r\nto my father.", "Vous savez, <E049><E003 8>Kazuma-sama a toujours compté énormément\r\npour mon père.");
                s = s.Replace("I'm sure he'd love the chance <E049><E003 8><E145 3 72><E003 15><E330>to meet with him and talk\r\nto him about all of this.", "Je suis certaine qu'il aimerait avoir l'occasion <E049><E003 8><E145 3 72><E003 15><E330>de le voir\r\net de lui parler de tout ceci.");
                s = s.Replace("Yes, <E003 8><E025 2>no doubt...", "Oui, <E003 8><E025 2>sans aucun doute...");
                s = s.Replace("Asa <E145 3 67>Shinn...", "Asa <E145 3 67>Shinn...");
                s = s.Replace("Of course!<E003 15>\r\n<E341><E025 1>It's so obvious!", "Bien sûr !<E003 15>\r\n<E341><E025 1>C'est tellement évident !");
                s = s.Replace("How could I have neglected <E049><E003 12><E346>to consider the possibility\r\nbefore now?!", "Comment ai-je pu négliger <E049><E003 12><E346>d'envisager cette possibilité\r\njusqu'à maintenant ?!");
                s = s.Replace("Agh!<E003 14>\r\n<E025 2>M-<E145 2 64><E117 2 25><E003 10><E025 1><E331>Mr Sholmes!", "Aah !<E003 14>\r\n<E025 2>M-<E145 2 64><E117 2 25><E003 10><E025 1><E331>M. Sholmes !");
                s = s.Replace("Hurley!<E049><E003 14>\r\n<E025 2>Where have you been?", "Hurley !<E049><E003 14>\r\n<E025 2>Où étais-tu passé ?");
                s = s.Replace("Why, <E049><E003 8>I joined you all for tea, <E003 4>of course.<E049><E003 8>\r\n<E025 1><E164 2 81 1 2 8 0 2 1><E118 2 1.2><E139 2>What an extraordinary question.", "Mais enfin, <E049><E003 8>j'étais avec vous pour le thé, <E003 4>naturellement.<E049><E003 8>\r\n<E025 1><E164 2 81 1 2 8 0 2 1><E118 2 1.2><E139 2>Quelle singulière question.");
                s = s.Replace("I...<E003 10>didn't notice you at all.", "Je...<E003 10>ne vous ai pas vu du tout.");
                s = s.Replace("No matter, <E003 6>no matter!<E049><E003 10> <E145 2 67><E003 8><E025 2>Anyway, <E003 6>to more pressing concerns.<E049><E003 10>\r\n<E025 1><E341><E338>...Mr Naruhodo!", "Qu'importe, <E003 6>qu'importe !<E049><E003 10> <E145 2 67><E003 8><E025 2>Venons-en à des affaires plus urgentes.<E049><E003 10>\r\n<E025 1><E341><E338>...Monsieur Naruhodo !");
                s = s.Replace("Oh!<E003 12> <E025 1><E342>...Yes?", "Oh !<E003 12> <E025 1><E342>...Oui ?");
                s = s.Replace("I must dispatch a telegram to your country at once.<E049><E003 12>\r\nIt is a matter of much urgency.", "Je dois expédier un télégramme dans votre pays immédiatement.<E049><E003 12>\r\nC'est de la plus haute urgence.");
                s = s.Replace("To...<E003 8>Japan, <E003 10>you mean?", "Au...<E003 8>Japon, <E003 10>vous voulez dire ?");
                s = s.Replace("Tell me, <E049><E003 8>to whom can I entrust the task?<E049><E003 12>\r\n<E335>Quickly now!<E049><E003 10> Who?", "Dites-moi, <E049><E003 8>à qui puis-je confier cette mission ?<E049><E003 12>\r\n<E335>Plus vite !<E049><E003 10> À qui ?");
                s = s.Replace("Ah, <E049><E003 10><E025 3>well...", "Ah, <E049><E003 10><E025 3>eh bien...");
                s = s.Replace("...my father has just now left <E049><E003 6><E145 3 92><E118 3 1.4>to send a telegram to the\r\nImperial Police Bureau of Japan himself.", "...mon père vient tout juste de partir <E049><E003 6><E145 3 92><E118 3 1.4>pour envoyer lui-même\r\nun télégramme au bureau de la police impériale du Japon.");
                s = s.Replace("I see.", "Je vois.");
                s = s.Replace("Well, <E049><E003 6><E164 2 71 1 2 6 0 0 1><E139 2><E025 2>he looked reliable enough for a bearded fellow.", "Eh bien, <E049><E003 6><E164 2 71 1 2 6 0 0 1><E139 2><E025 2>il avait l'air plutôt digne de confiance pour un barbu.");
                s = s.Replace("...I don't think what Father sports could be considered a\r\nbeard, <E003 6>Mr Sholmes...", "...Je ne crois pas que ce que porte mon père puisse être qualifié\r\nde barbe, <E003 6>monsieur Sholmes...");
                s = s.Replace("There's not a moment to lose!<E049><E003 12> <E060 0 145 0 0>Kindly ask your trusty\r\nunshaven father to see this is sent!", "Il n'y a pas un instant à perdre !<E049><E003 12> <E060 0 145 0 0>Demandez sans tarder\r\nà votre vénérable père mal rasé de s'assurer de cet envoi !");
                s = s.Replace("I, <E049><E003 8>I will, <E049><E003 8>but...<E003 8><E025 2><E145 3 92><E117 3 10><E003 5><E330>what is it?", "J-Je vais le faire, <E049><E003 8>mais...<E003 8><E025 2><E145 3 92><E117 3 10><E003 5><E330>qu'est-ce que c'est ?");
                s = s.Replace("No questions at this time, if you please, <E049><E003 6>Miss Susato.", "Pas de questions pour l'instant, je vous prie, <E049><E003 6>mademoiselle Susato.");
                s = s.Replace("All we can do is pray...", "Tout ce que nous pouvons faire, c'est prier...");
                s = s.Replace("...that for once <E049><E003 12><E136 2 74 30><E117 2 20><E118 2 0.8><E003 10><E238><E025 3>my deduction is awry.", "...pour qu'une fois n'est pas coutume, <E049><E003 12><E136 2 74 30><E117 2 20><E118 2 0.8><E003 10><E238><E025 3>ma déduction soit erronée.");
                s = s.Replace("Doesn't that imply that your deductions <E003 6><E341>are normally\r\ncorrect, <E003 4>Mr Sholmes?<E003 10> <E330><E025 3>Which isn't exactly<E145 2 70>–", "Cela ne sous-entend-il pas que vos déductions <E003 6><E341>sont toujours\r\nexactes d'ordinaire, <E003 4>M. Sholmes ?<E003 10> <E330><E025 3>Ce qui n'est pas tout à fait<E145 2 70>–");
                s = s.Replace("Now then!", "Allons, allons !");
                s = s.Replace("You may be surprised to learn that I am a very busy man.", "Vous serez peut-être surpris d'apprendre que je suis un homme très occupé.");
                s = s.Replace("I certainly have no time to hide behind settees <E049><E003 8><E333>and\r\neavesdrop on other people's conversations.", "Je n'ai certainement pas le loisir de me tapir derrière les canapés <E049><E003 8><E333>pour\r\nécouter aux portes des conversations d'autrui.");
                s = s.Replace("(So that's what ‘joining us for tea’ meant...)", "(C'est donc ça qu'il entendait par « être avec nous pour le thé »...)");
                s = s.Replace("I leave the sending of this in your hands then,<E049><E003 8><E025 1><E164 2 70 1 2 8 0 1 1><E139 2> my dear\r\nfellows.", "Je remets donc l'envoi de ce pli entre vos mains,<E049><E003 8><E025 1><E164 2 70 1 2 8 0 1 1><E139 2> mes chers\r\namis.");
                s = s.Replace("Ah!<E003 14> <E025 1><E335>Wait a minute!<E003 10>\r\n<E341>Mr Sholmes!", "Ah !<E003 14> <E025 1><E335>Un instant !<E003 10>\r\n<E341>Monsieur Sholmes !");
                s = s.Replace("He just sort of ran off, <E049><E003 6>didn't he?<E049><E003 12>\r\n<E025 2><E136 110 71 3><E117 110 15><E139 110><E333>At quite a pace.", "Il a détalé comme un lièvre, <E049><E003 6>n'est-ce pas ?<E049><E003 12>\r\n<E025 2><E136 110 71 3><E117 110 15><E139 110><E333>À une sacrée allure.");
                s = s.Replace("And left the unpaid bill <E145 110 72>for his tea behind, too.", "En nous laissant la note impayée <E145 110 72>de son thé au passage.");
                s = s.Replace("I must catch up with Father at the telegraph office<E049><E003 8> <E164 3 87 1 2 8 0 2 1><E139 3><E025 1>at\r\nonce!", "Je dois rattraper Père au bureau télégraphique<E049><E003 8> <E164 3 87 1 2 8 0 2 1><E139 3><E025 1>immédiatement !");
                s = s.Replace("And I'll run and call us a cab<E049><E003 8> <E164 110 67 1 2 8 0 2 1><E139 110><E025 1>straight away!", "Et je cours nous héler un fiacre<E049><E003 8> <E164 110 67 1 2 8 0 2 1><E139 110><E025 1>sans plus attendre !");
                s = s.Replace("(And there was me thinking everyone would be\r\nclamouring to pay Mr Sholmes's bill...)", "(Et moi qui pensais naïvement que tout le monde allait se disputer pour payer la note de M. Sholmes...)");
                return s;
            };

            // [7] BB\script\output\_sce03_c201_0050_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0050_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>St Synner's Hospital, Ward 3", "2 novembre\r\n<CNTR><E003 5>Hôpital St Synner, salle 3");
                s = s.Replace("This is the ward where Mr Vigil was brought, <E003 4>apparently.", "C'est la salle où M. Vigil a été amené, <E003 4>apparemment.");
                s = s.Replace("(To be frank, <E003 8><E025 3><E341>I'm a little worried about seeing him again.)", "(Pour être franc, <E003 8><E025 3><E341>j'appréhende un peu de le revoir.)");
                s = s.Replace("Ah.<E049><E003 12> The lawyer.<E049><E003 12>\r\nHello again.", "Ah.<E049><E003 12> L'avocat.<E049><E003 12>\r\nRebonjour.");
                s = s.Replace("Are, <E049><E003 10><E025 3><E341>are you feeling better now, <E003 4>Mr Vigil?", "Vous, <E049><E003 10><E025 3><E341>vous sentez-vous mieux à présent, <E003 4>M. Vigil ?");
                s = s.Replace("Yes, <E049><E003 8><E025 3>thank you.<E049><E003 12> <E025 2>Somewhat better.", "Oui, <E049><E003 8><E025 3>merci.<E049><E003 12> <E025 2>Un peu mieux.");
                s = s.Replace("I'm so sorry to have caused you to...<E003 15>\r\n<E025 3>I mean, <E003 6>it was because of me.", "Je suis tellement navré de vous avoir provoqué ce...<E003 15>\r\n<E025 3>Enfin, <E003 6>c'est à cause de moi.");
                s = s.Replace("If I hadn't exposed your secret and forced you to\r\nremember things you'd obviously tried to forget...", "Si je n'avais pas étalé votre secret au grand jour et forcé ces souvenirs\r\nque vous cherchiez désespérément à oublier...");
                s = s.Replace("The prosecutor was here until a few moments ago, too.<E049><E003 12>\r\n<E025 2>You just missed him.", "Le procureur était ici jusqu'à il y a quelques instants lui aussi.<E049><E003 12>\r\n<E025 2>Vous l'avez manqué de peu.");
                s = s.Replace("Oh!<E003 10>\r\n<E025 2><E007><E341>(Kazuma beat us to it...)", "Oh !<E003 10>\r\n<E025 2><E007><E341>(Kazuma nous a devancés...)");
                s = s.Replace("He said much the same as you.<E049><E003 12>\r\nHe was very apologetic.", "Il a tenu à peu près les mêmes propos que vous.<E049><E003 12>\r\nIl s'est confondu en excuses.");
                s = s.Replace("But the truth is...<E049><E003 12><E025 2>I brought all this upon myself.", "Mais la vérité est...<E049><E003 12><E025 2>que je ne peux m'en prendre qu'à moi-même.");
                s = s.Replace("Please, <E003 6>don't think like that...", "Je vous en prie, <E003 6>ne dites pas cela...");
                s = s.Replace("Keeping it from Evie –<E049><E003 6> my wife –<E049><E003 8> all these years...<E003 12>\r\n<E025 2>I've carried such a sense of guilt.", "L'avoir caché à Evie –<E049><E003 6> ma femme –<E049><E003 8> durant toutes ces années...<E003 12>\r\n<E025 2>J'ai traîné une telle culpabilité.");
                s = s.Replace("But <E049><E003 10><E025 3><E145 126 77><E117 126 35>that's not the worst of it.", "Mais <E049><E003 10><E025 3><E145 126 77><E117 126 35>ce n'est pas le pire.");
                s = s.Replace("Over time...<E003 2><E145 126 71><E144 126><E025 2><E238>I obviously came <E049><E003 8><E025 3><E341>to deceive myself as well.", "Avec le temps...<E003 2><E145 126 71><E144 126><E025 2><E238>j'ai fini par <E049><E003 8><E025 3><E341>me duper moi-même.");
                s = s.Replace("You mean...<E003 10><E333><E025 3>about your dismissal?", "Vous voulez dire...<E003 10><E333><E025 3>au sujet de votre licenciement ?");
                s = s.Replace("Looking back now...", "Avec le recul à présent...");
                s = s.Replace("...I'm beginning to think <E049><E003 10><E333><E025 3>that perhaps Inspector Gregson\r\ndidn't stumble across me by accident at all.", "...je commence à croire <E049><E003 10><E333><E025 3>que l'inspecteur Gregson ne m'a pas trouvé\r\npar hasard.");
                s = s.Replace("I mean, <E049><E003 8>he compensated me so generously for acting as\r\nhis stand-in.", "Après tout, <E049><E003 8>il me dédommageait si généreusement pour lui servir\r\nde doublure.");
                s = s.Replace("He was clearly concerned for my wellbeing and...<E003 12>\r\n<E025 3>doing what he could to help.", "Il se souciait manifestement de ma situation et...<E003 12>\r\n<E025 3>faisait ce qu'il pouvait pour m'aider.");
                s = s.Replace("(So perhaps Gregson knew exactly what had become of\r\nMr Vigil all along, then...)", "(L'inspecteur Gregson savait peut-être très bien ce qu'était devenu\r\nM. Vigil depuis le début...)");
                s = s.Replace("I'm sure this is <E006>just deserts<E005> for ten years of lies \r\nand deception, <E049><E003 15><E025 4>but...", "C'est sans doute un <E006>juste retour des choses<E005> pour dix ans de\r\nmensonges et d'illusions, <E049><E003 15><E025 4>mais...");
                s = s.Replace("...it wasn't me that helped the Professor escape ten years\r\nago!<E049><E003 12> <E335>It wasn't me!", "...ce n'est pas moi qui ai fait évader le Professeur il y a\r\ndix ans !<E049><E003 12> <E335>Ce n'était pas moi !");
                s = s.Replace("I swear it!<E049><E003 15> <E025 1><E160 126><E118 126 0.8><E139 126><E346>I swear it's true!", "Je le jure !<E049><E003 15> <E025 1><E160 126><E118 126 0.8><E139 126><E346>Je jure que c'est la vérité !");
                s = s.Replace("Oh, <E003 6>Mr Vigil...", "Oh, <E003 6>monsieur Vigil...");
                s = s.Replace("I'm sure you'd rather not dredge up even more from your\r\npast at this time, <E003 8>but...", "J'imagine que vous préféreriez ne pas remuer encore votre passé\r\nen ce moment, <E003 8>mais...");
                s = s.Replace("...if possible, <E003 12>could you tell us exactly what really<E145 126 79><E118 126 1.4>\r\nhappened?", "...si c'est possible, <E003 12>pourriez-vous nous relater ce qui s'est réellement<E145 126 79><E118 126 1.4>\r\npassé ?");
                s = s.Replace("I want to.<E049><E003 12> <E341>I need to get all this off my chest.", "Je le veux.<E049><E003 12> <E341>J'ai besoin de vider mon sac.");
                s = s.Replace("I just <E049><E003 10><E145 126 69><E118 126 1.5><E003 15><E335><E025 1>want someone to tell me what I should have done!", "Je veux juste <E049><E003 10><E145 126 69><E118 126 1.5><E003 15><E335><E025 1>que quelqu'un me dise ce que j'aurais dû faire !");
                return s;
            };

            // [8] BB\script\output\_sce03_c201_0060_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0060_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I'm afraid there's really little more I can tell you.", "J'ai bien peur de ne rien pouvoir vous apprendre de plus.");
                s = s.Replace("My wife Evie will be here shortly.<E049><E003 12>\r\n<E025 3>So I do hope I don't appear rude, <E049><E003 8>but...", "Mon épouse Evie ne va pas tarder.<E049><E003 12>\r\n<E025 3>J'espère ne pas paraître impoli, <E049><E003 8>mais...");
                s = s.Replace("No no, <E003 8>not at all.<E003 10>\r\nThank you again.", "Non, non, <E003 8>pas du tout.<E003 10>\r\nMerci encore.");
                s = s.Replace("But what will become of you now?", "Mais qu'adviendra-t-il de vous à présent ?");
                s = s.Replace("Well, <E049><E003 8>impersonating a police officer is a criminal offence,<E049><E003 8>\r\nof course.", "Eh bien, <E049><E003 8>l'usurpation d'identité d'un policier est un délit,<E049><E003 8>\r\ncela va de soi.");
                s = s.Replace("I imagine that once I'm fully recovered, <E049><E003 10><E333><E025 3>I shall be\r\narrested.", "J'imagine qu'une fois rétabli, <E049><E003 10><E333><E025 3>je serai placé en état d'arrestation.");
                s = s.Replace("I'm so sorry.", "Je suis tellement navré.");
                s = s.Replace("Don't be, <E049><E003 8>please.<E049><E003 12>\r\nThis was all my own doing.", "Ne le soyez pas, <E049><E003 8>je vous prie.<E049><E003 12>\r\nJe suis l'unique responsable de cette situation.");
                s = s.Replace("I always knew <E049><E003 8><E025 3>that this day would come.", "J'ai toujours su <E049><E003 8><E025 3>que ce jour viendrait.");
                s = s.Replace("Well...<E003 10>I wish you well.<E049><E003 12>\r\n<E025 3>Goodbye, <E003 6>Mr Vigil.", "Eh bien...<E003 10>bon rétablissement.<E049><E003 12>\r\n<E025 3>Au revoir, <E003 6>monsieur Vigil.");
                s = s.Replace("AAAAAAAAAAAAAAAAAAAAAH!", "AAAAAAAAAAAAAAAAAAAAAH !");
                s = s.Replace("Before you go!<E003 3><E145 126 71><E118 126 3><E003 15> <E345>There's <E003 3><E145 126 78><E118 126 1><E003 15><E046>just one thing!", "Avant de partir !<E003 3><E145 126 71><E118 126 3><E003 15> <E345>Il y a <E003 3><E145 126 78><E118 126 1><E003 15><E046>encore une chose !");
                s = s.Replace("Oh!<E003 12> Y-<E003 10>Yes?<E003 15>\r\n<E342><E025 2>What is it?", "Oh !<E003 12> O-<E003 10>Oui ?<E003 15>\r\n<E342><E025 2>Qu'y a-t-il ?");
                s = s.Replace("The Asogi Papers...", "Les dossiers Asogi...");
                s = s.Replace("I'd be very grateful if you'd make no mention of the things\r\nI told you about them.", "Je vous serais infiniment reconnaissant de ne rien ébruiter\r\nde ce que je vous ai confié à leur sujet.");
                s = s.Replace("...Presumably for some good reason?", "...J'imagine qu'il y a une bonne raison à cela ?");
                s = s.Replace("It's my understanding that their very existence is <E006>a\r\nclosely guarded secret<E005>.", "Si j'ai bien compris, leur existence même est un <E006>secret\r\nfarouchement gardé<E005>.");
                s = s.Replace("If it became known that I'd remembered...", "S'il venait à se savoir que je m'en suis souvenu...");
                s = s.Replace("Well...<E003 6><E145 126 74><E144 126><E239><E025 3>it could be rather troublesome, <E049><E003 6>I think.", "Eh bien...<E003 6><E145 126 74><E144 126><E239><E025 3>cela pourrait être fort fâcheux, <E049><E003 6>je le crains.");
                s = s.Replace("...I understand.", "...Je comprends.");
                s = s.Replace("(Some sort of <E006>will<E007> <E003 6>that Genshin Asogi penned just before\r\nhis death.)", "(Une sorte de <E006>testament<E007> <E003 6>que Genshin Asogi aurait rédigé juste avant\r\nsa mort.)");
                s = s.Replace("(Which the man himself claimed was his last ‘<E006>weapon<E007>’...)", "(Et dont il affirmait que c'était sa dernière « <E006>arme<E007> »...)");
                s = s.Replace("(I wonder...)", "(Je me demande...)");
                s = s.Replace("(Perhaps it had something to do with his <E006>plan to escape<E007>...)", "(Peut-être cela avait-il un rapport avec son <E006>projet d'évasion<E007>...)");
                s = s.Replace("If there's anyone who might know more about a document\r\nthat Kazuma's father left behind...", "S'il est quelqu'un susceptible d'en savoir plus sur un document\r\nlaissé par le père de Kazuma...");
                s = s.Replace("...It would be Mr Vigil's governor!", "...ce serait le gouverneur de M. Vigil !");
                s = s.Replace("Then we know precisely where we must go.<E049><E003 12>\r\n<E025 2><E338><E341>Back to Barclay Prison!", "Alors nous savons exactement où nous rendre.<E049><E003 12>\r\n<E025 2><E338><E341>Retournons à la prison de Barclay !");
                return s;
            };

            // [9] BB\script\output\_sce03_c201_0070_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0070_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Barclay Prison, Governor's Office", "2 novembre\r\n<CNTR><E003 5>Prison de Barclay, bureau du gouverneur");
                s = s.Replace("Och, <E049><E003 10>back again, <E003 4>are you?", "Och, <E049><E003 10>déjà d'retour, <E003 4>hein ?");
                s = s.Replace("Um, <E003 8>yes...<E003 12> <E025 3>Hello.", "Euh, <E003 8>oui...<E003 12> <E025 3>bonjour.");
                s = s.Replace("I've heard all aboot your investigations.<E049><E003 12>\r\n<E025 3>I read the report just now.", "J'ai tout appris sur votre enquête.<E049><E003 12>\r\n<E025 3>Je viens tout juste d'lire le rapport.");
                s = s.Replace("You've found him, <E003 4>eh?<E049><E003 10> <E025 3>Vigil.", "Vous l'avez r'trouvé, <E003 4>pas vrai ?<E049><E003 10> <E025 3>Vigil.");
                s = s.Replace("Yes, <E003 6><E025 2>luckily.", "Oui, <E003 6><E025 2>heureusement.");
                s = s.Replace("Well, <E049><E003 8><E025 3>anyhoo...", "Bon, <E049><E003 8><E025 3>peu importe...");
                s = s.Replace("...the laddie does'nae work here no more.<E049><E003 12>\r\n<E335><E025 1>So your case is <E006>nowt to do<E005> wi' Barclay.", "...le bougre ne travaille plus ici d'puis belle lurette.<E049><E003 12>\r\n<E335><E025 1>Alors votre affaire n'a <E006>rien à voir<E005> avec Barclay.");
                s = s.Replace("I would'nae like you...<E049><E025 3><E164 127 69 1 2 8 0 2 1><E118 127 1.3><E139 127><E025 2>to get the wrong idea aboot that.", "J'voudrais point...<E049><E025 3><E164 127 69 1 2 8 0 2 1><E118 127 1.3><E139 127><E025 2>que vous alliez vous fourrer des idées pareilles en tête.");
                s = s.Replace("Of course, <E003 8>yes.<E003 12> <E025 2>Mr Vigil stopped working here ten years\r\nago now, <E003 8><E025 3>so...", "Bien sûr, <E003 8>oui.<E003 12> <E025 2>M. Vigil a cessé d'exercer ici il y a dix ans\r\nde cela, <E003 8><E025 3>alors...");
                s = s.Replace("Yes, <E049><E003 6>we've seen his dismissal notice, <E049><E003 6>haven't we?<E049><E003 10>\r\n<E025 1>He was given the chop!", "Oui, <E049><E003 6>nous avons vu son avis de licenciement !<E049><E003 10>\r\n<E025 1>Il a été remercié sans ménagement !");
                s = s.Replace("Aye, <E049><E003 6>kimmer.<E049><E003 8> You ken very well.<E049><E003 10>\r\n<E025 3>So...<E003 10><E025 2>how aboot a wee handcuff biscuit?", "Tout juste, <E049><E003 6>la p'tiote.<E049><E003 8> T'as tout compris.<E049><E003 10>\r\n<E025 3>Alors...<E003 10><E025 2>que diriez-vous d'un p'tit biscuit en forme de menottes ?");
                s = s.Replace("Oh, <E049><E003 10>they really are like little handcuffs!<E049><E003 10>\r\n<E025 1><E331>...And as hard as irons, too!", "Oh, <E049><E003 10>ils ressemblent vraiment à des petites menottes !<E049><E003 10>\r\n<E025 1><E331>...Et durs comme du fer, aussi !");
                s = s.Replace("So?<E049><E003 12> <E025 2>What's brought you doon here the day?", "Alors ?<E049><E003 12> <E025 2>Qu'est-ce qui vous amène par ici au juste ?");
                s = s.Replace("Well...<E003 10><E025 2>there's something else we'd like to ask you about,<E003 8>\r\nactually.", "Eh bien...<E003 10><E025 2>il y a autre chose dont nous aimerions vous entretenir,<E003 8>\r\nen vérité.");
                s = s.Replace("Is that so?", "Ah oui ?");
                s = s.Replace("We believe there might have been a document that\r\ndisappeared from Genshin Asogi's cell.", "Nous pensons qu'un document aurait pu disparaître de la cellule\r\nde Genshin Asogi.");
                s = s.Replace("I think it's been called <E003 12><E025 3><E043><E006>the Asogi Papers<E005> or something?", "On l'appelle <E003 12><E025 3><E043>« <E006>les dossiers Asogi<E005> », si je ne m'abuse ?");
                s = s.Replace("Did I no say?<E049><E003 15> <E025 2>Gregson's death is nowt to do wi' things that\r\nmight have happened at Barclay.", "J'vous l'ai point déjà dit ?<E049><E003 15> <E025 2>La mort de Gregson n'a rien à voir avec\r\nce qui a bien pu s'passer à Barclay.");
                s = s.Replace("Leave the past in the past, <E049><E003 6><E025 3>laddie.<E049><E003 14>\r\n<E025 1><E346>Let's not footer aboot wi' irrelevant details.", "Laissez l'passé là où il est, <E049><E003 6><E025 3>l'ami.<E049><E003 14>\r\n<E025 1><E346>Inutile de r'muer la poussière avec des fadaises.");
                s = s.Replace("(His expression's changed completely.)", "(Son expression a complètement changé.)");
                s = s.Replace("(We're clearly <E145 127 64><E003 3><E341>onto something here.)", "(Nous touchons <E145 127 64><E003 3><E341>clairement une corde sensible.)");
                return s;
            };

            // [10] BB\script\output\_sce03_c201_0080_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0080_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>British Supreme Court, Lord Chief Justice's Office", "2 novembre\r\n<CNTR><E003 5>Cour suprême britannique, bureau du lord grand justicier");
                s = s.Replace("No arguments, <E003 10>Prosecutor Asogi.", "Pas de contestation, <E003 10>procureur Asogi.");
                s = s.Replace("You will continue with the trial exactly as I instructed.<E049><E003 12>\r\n<E025 3>Is that clear?", "Vous poursuivrez le procès exactement selon mes instructions.<E049><E003 12>\r\n<E025 3>Est-ce bien clair ?");
                s = s.Replace("...Perfectly.", "...Parfaitement.");
                s = s.Replace("It's Kazuma-sama!", "C'est Kazuma-sama !");
                s = s.Replace("Defying Lord Stronghart, <E003 6>by the sound of it.<E003 12>\r\n<E342><E025 3>He never did know when to back down.", "Qui tient tête à Lord Vortex, <E003 6>à ce qu'il paraît.<E003 12>\r\n<E342><E025 3>Il n'a jamais su quand reculer.");
                s = s.Replace("On your way now, <E049><E003 8><E025 3>Asogi.", "Disposez à présent, <E049><E003 8><E025 3>Asogi.");
                s = s.Replace("...My Lord.", "...Votre Seigneurie.");
                s = s.Replace("Kazuma...", "Kazuma...");
                s = s.Replace("(He left without saying a word...)", "(Il est parti sans piper mot...)");
                s = s.Replace("Yes?<E049><E003 8> <E025 2>What are you doing here?", "Oui ?<E049><E003 8> <E025 2>Que faites-vous ici ?");
                s = s.Replace("Oh!<E003 12> <E338><E342><E025 3>Um...<E003 8>well, <E003 6>erm...<E003 15><E025 2><E341>I was just hoping to ask you a few\r\nquestions, <E003 8><E025 3>if you wouldn't mind.", "Oh !<E003 12> <E338><E342><E025 3>Euh...<E003 8>eh bien, <E003 6>hum...<E003 15><E025 2><E341>j'espérais seulement vous poser quelques\r\nquestions, <E003 8><E025 3>si cela ne vous dérange pas.");
                s = s.Replace("I wanted van Zieks's trial concluded today.", "Je voulais que le procès de Van Peers se termine aujourd'hui.");
                s = s.Replace("But Prosecutor Asogi's unwelcome inquiries <E049><E003 8><E025 3>are going to\r\nmake it take longer than necessary.", "Mais les investigations intempestives du procureur Asogi <E049><E003 8><E025 3>vont\r\nle faire durer plus longtemps que nécessaire.");
                s = s.Replace("Unwelcome inquiries...?", "Des investigations intempestives... ?");
                s = s.Replace("As a result, <E049><E003 10><E025 2><E145 14 74>I'm losing even more precious time.", "Par conséquent, <E049><E003 10><E025 2><E145 14 74>je perds un temps encore plus précieux.");
                s = s.Replace("Currently two hours, <E049><E003 6>fifty-five minutes <E049><E003 6>and forty-one\r\nseconds.<E003 15> <E025 3><E338><E341>...Forty-two...<E003 15><E025 3><E338><E341>forty-three...", "Actuellement deux heures, <E049><E003 6>cinquante-cinq minutes <E049><E003 6>et quarante et une\r\nsecondes.<E003 15> <E025 3><E338><E341>...Quarante-deux...<E003 15><E025 3><E338><E341>quarante-trois...");
                s = s.Replace("Then we must resolve everything before three hours\r\nhave passed, <E049><E003 8>Mr Naruhodo!", "Dans ce cas, nous devons tout résoudre avant que les trois\r\nheures ne soient écoulées, <E049><E003 8>monsieur Naruhodo !");
                s = s.Replace("...In a miraculous not-even-five minutes?", "...En l'espace miraculeux de moins de cinq minutes ?");
                s = s.Replace("(Anyway, <E003 8><E025 2>I can't let the man's obvious bad mood put me\r\noff...)", "(Quoi qu'il en soit, <E003 8><E025 2>je ne dois pas me laisser intimider par la mauvaise humeur\r\névidente de cet homme...)");
                s = s.Replace("(I need information!)", "(J'ai besoin de renseignements !)");
                return s;
            };

            // [11] BB\script\output\_sce03_c201_0090_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0090_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Now, <E049><E003 10><E025 2>I shall have to ask you to excuse me.", "À présent, <E049><E003 10><E025 2>je vous prie de bien vouloir m'excuser.");
                s = s.Replace("As of this moment, <E049><E003 10><E239><E025 2>I've been delayed from attending my\r\nnext meeting by precisely three hours.", "À cette seconde précise, <E049><E003 10><E239><E025 2>mon prochain rendez-vous a pris\r\nexactement trois heures de retard.");
                s = s.Replace("Oh my!<E049><E003 12> That is a long time!", "Grand dieu !<E049><E003 12> C'est une éternité !");
                s = s.Replace("And I hold you entirely responsible.", "Et je vous en tiens pour pleinement responsables.");
                s = s.Replace("(Even though we miraculously managed to fit everything\r\ninto not-even-five minutes?)", "(Alors que nous avons miraculeusement réussi à tout caser en\r\nmoins de cinq minutes ?)");
                s = s.Replace("Um, <E003 10><E025 3>I wonder if you might agree...", "Hum, <E003 10><E025 3>je me demandais si vous accepteriez...");
                s = s.Replace("...to us, <E003 8>um...<E003 14><E330><E092 6><E341>talking with Prosecutor Asogi?", "...que nous puissions, <E003 8>euh...<E003 14><E330><E092 6><E341>nous entretenir avec le procureur Asogi ?");
                s = s.Replace("Discussions between the defence and the prosecution\r\noutside of the courtroom are generally frowned upon.", "Les entretiens entre défense et accusation en dehors\r\ndu prétoire sont généralement très mal vus.");
                s = s.Replace("However, <E049><E003 8><E025 2>I will make an exception in this case.<E049><E003 10>\r\n<E025 2><E164 14 73 1 2 42 0 0 1><E139 14>Now go!<E049><E003 12> You can find him in his office.", "Cependant, <E049><E003 8><E025 2>je ferai une exception pour cette affaire.<E049><E003 10>\r\n<E025 2><E164 14 73 1 2 42 0 0 1><E139 14>Allez-y !<E049><E003 12> Il se trouve dans son bureau.");
                s = s.Replace("Oh!<E003 14> <E025 1><E346>Thank you!<E145 14 64>", "Oh !<E003 14> <E025 1><E346>Merci !<E145 14 64>");
                s = s.Replace("Let's go to see him at once, <E049><E003 6><E025 1><E164 3 87 1 2 8 0 1 1><E139 3>Mr Naruhodo!", "Allons le voir sur-le-champ, <E049><E003 6><E025 1><E164 3 87 1 2 8 0 1 1><E139 3>monsieur Naruhodo !");
                s = s.Replace("(Kazuma's my best friend in the world, <E003 8>but...)", "(Kazuma est mon meilleur ami au monde, <E003 8>mais...)");
                s = s.Replace("(...I'm really not at all sure <E003 10><E025 2><E341>I know how to talk to him at\r\nthe moment.)", "(...je ne suis vraiment pas sûr <E003 10><E025 2><E341>de savoir comment lui parler\r\nen ce moment.)");
                return s;
            };

            // [12] BB\script\output\_sce03_c201_0100_eng#6
            entryTranslators[@"BB\script\output\_sce03_c201_0100_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Prosecutor's Office", "2 novembre\r\n<CNTR><E003 5>Bureau du procureur");
                s = s.Replace("(So...<E003 10><E025 3><E330>this is the office of ‘Prosecutor Asogi’ now, <E003 6>is it?)", "(Ainsi...<E003 10><E025 3><E330>c'est ici le bureau du « procureur Asogi » désormais ?)");
                s = s.Replace("Kazuma-sama is...<E049><E003 13><E025 3><E341><E239>doing so well for himself.", "Kazuma-sama...<E049><E003 13><E025 3><E341><E239>a si bien réussi.");
                s = s.Replace("(Even though he's always forced to kneel on the floor\r\n<E006>Japanese-style<E007> in that dark corner?)", "(Même s'il s'assoit toujours à genoux sur le sol, <E006>à la japonaise<E007>,\r\ndans ce coin sombre ?)");
                s = s.Replace("It's his habit to sit seiza-style whenever he's working!", "Il a toujours eu pour habitude de s'asseoir en seiza quand il travaille !");
                return s;
            };

            // [13] BB\script\output\_sce03_c201_0100_eng#7
            entryTranslators[@"BB\script\output\_sce03_c201_0100_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("(Well, <E003 8>it looks like our journey here was wasted.)", "(Eh bien, <E003 8>on dirait que nous nous sommes déplacés pour rien.)");
                s = s.Replace("(The prosecutor appears to be out.)", "(Le procureur semble absent.)");
                s = s.Replace("...Perhaps we should discuss things with another\r\nprosecutor we know first?", "...Peut-être devrions-nous d'abord discuter avec un autre\r\nprocureur de notre connaissance ?");
                return s;
            };

            // [14] BB\script\output\_sce03_c201_0100_eng#8
            entryTranslators[@"BB\script\output\_sce03_c201_0100_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("I thought it wouldn't be long before you paid me a visit,<E049><E003 10>\r\n<E025 3>Ryunosuke.", "Je savais que tu ne tarderais pas à me rendre visite,<E049><E003 10>\r\n<E025 3>Ryunosuke.");
                s = s.Replace("I was right about what I said, <E049><E003 8>wasn't I?", "J'avais vu juste, <E049><E003 8>n'est-ce pas ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("That you have all the makings of a great defence lawyer.", "Tu as toute l'étoffe d'un grand avocat de la défense.");
                s = s.Replace("Well I...<E003 10>always believed that you'd fulfil your dream of\r\nadvocating in the British courts.", "Et moi...<E003 10>j'ai toujours cru que tu réaliserais ton rêve de plaider\r\ndevant les cours britanniques.");
                s = s.Replace("(I just never imagined for one second <E003 8><E333>that it would be as a\r\nprosecutor.)", "(Je n'avais simplement jamais imaginé une seconde <E003 8><E333>que ce serait en tant que\r\nprocureur.)");
                s = s.Replace("Seeing you stand in a foreign courtroom, <E049><E003 10><E342>so gallantly\r\nrealising your dream, <E049><E003 10><E025 3><E338><E341>Kazuma-sama...", "Vous voir dans ce prétoire étranger, <E049><E003 10><E342>accomplir votre rêve avec\r\ntant de panache, <E049><E003 10><E025 3><E338><E341>Kazuma-sama...");
                s = s.Replace("I'm...<E049><E003 10><E160 3><E118 3 1.2><E149 3 0 1><E003 12><E341><E330><E025 3>truly happy for you.", "J'en suis...<E049><E003 10><E160 3><E118 3 1.2><E149 3 0 1><E003 12><E341><E330><E025 3>sincèrement heureuse pour vous.");
                s = s.Replace("And I am truly thankful to you, <E049><E003 12><E025 3>Judicial Assistant\r\nMikotoba.", "Et je vous suis profondément reconnaissant, <E049><E003 12><E025 3>assistante juridique\r\nMikotoba.");
                s = s.Replace("Ryunosuke...", "Ryunosuke...");
                s = s.Replace("...I always thought it would be fun for you and I to shake\r\nup the British legal system a little together.", "...J'ai toujours pensé qu'il serait stimulant d'ébranler\r\nle système judiciaire britannique ensemble.");
                s = s.Replace("This isn't quite how I envisaged it, <E049><E003 8>but...", "Ce n'est pas tout à fait ce que j'avais envisagé, <E049><E003 8>mais...");
                s = s.Replace("...I suppose it's just another twist of fate.", "...j'imagine que ce n'est qu'un autre coup du destin.");
                s = s.Replace("...I've learnt a lot of things during my time in London.", "...J'ai appris bien des choses durant mon séjour à Londres.");
                s = s.Replace("About how Susato-san's father was himself a visiting\r\nstudent here once, <E003 8>along with Judge Jigoku.", "Sur le fait que le père de Susato-san fut lui-même un étudiant invité\r\nici autrefois, <E003 8>aux côtés du juge Jigoku.");
                s = s.Replace("...about what happened <E145 112 64>with your father.", "...sur ce qui est arrivé <E145 112 64>à ton père.");
                s = s.Replace("Then you'll have no difficulty understanding.", "Alors tu n'auras aucun mal à comprendre.");
                s = s.Replace("Why I had no choice.<E049><E003 14> <E145 112 65><E118 112 1.7><E046><E025 2>Why I had to find a way to get to\r\nBritain as a visiting student myself.", "Pourquoi je n'avais pas le choix.<E049><E003 14> <E145 112 65><E118 112 1.7><E046><E025 2>Pourquoi je devais à tout prix\r\nvenir en Grande-Bretagne en tant qu'étudiant.");
                s = s.Replace("I want to hear it from you, <E003 8>Kazuma.", "Je veux l'entendre de ta bouche, <E003 8>Kazuma.");
                s = s.Replace("...As you wish, <E049><E003 10><E025 3>Ryunosuke Naruhodo.", "...Comme tu voudras, <E049><E003 10><E025 3>Ryunosuke Naruhodo.");
                return s;
            };

            // [15] BB\script\output\_sce03_c201_0110_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0110_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I...<E003 8><E145 112 64><E003 15><E238>want to thank you.", "Je...<E003 8><E145 112 64><E003 15><E238>tiens à te remercier.");
                s = s.Replace("What for?", "Pour quoi ?");
                s = s.Replace("For this.", "Pour ceci.");
                s = s.Replace("You safeguarded the soul of the Asogi clan.", "Tu as veillé sur l'âme du clan Asogi.");
                s = s.Replace("Well, <E003 10><E025 2>it is a famous sword that's been in your family for\r\ngenerations.<E145 112 88><E118 112 0.8>", "Eh bien, <E003 10><E025 2>c'est une lame célèbre transmise dans ta famille depuis\r\ndes générations.<E145 112 88><E118 112 0.8>");
                s = s.Replace("My only slight regret is that I never got the chance to\r\ndraw it before I returned it to you.", "Mon seul petit regret est de n'avoir jamais eu l'occasion de la\r\ndégainer avant de te la rendre.");
                s = s.Replace("Karuma is said to have been forged by a master\r\nswordsmith during the Sengoku warring states period.", "On dit que Karuma a été forgée par un maître forgeron\r\ndurant l'ère Sengoku.");
                s = s.Replace("I come from a long lineage of warriors, <E049><E003 8>many of whom\r\nwere expert swordsmen.", "Je descends d'une longue lignée de guerriers, <E049><E003 8>dont beaucoup\r\nétaient de redoutables bretteurs.");
                s = s.Replace("...Well then, <E003 10>you're <E145 112 88>a chip off the old block, <E003 4>I'd say.", "...Eh bien, <E003 10>tu es <E145 112 88>digne de tes ancêtres, <E003 4>je dirais.");
                s = s.Replace("This blade –<E049><E003 6> Karuma –<E049><E003 8> <E025 2>is the symbol of the Asogi clan's\r\nhonour and might.", "Cette lame –<E049><E003 6> Karuma –<E049><E003 8> <E025 2>est le symbole de l'honneur et de\r\nla puissance du clan Asogi.");
                s = s.Replace("Apparently, <E049><E003 8><E025 2>one of my father's apprentices even took the\r\nblade's name for a surname.", "D'ailleurs, <E049><E003 8><E025 2>l'un des apprentis de mon père a même pris le nom\r\nde cette épée comme nom de famille.");
                s = s.Replace("Really?<E003 10> <E025 3>Karuma...<E003 15>\r\n<E025 3>It does sound formidable, <E003 6>that's for sure.", "Vraiment ?<E003 10> <E025 3>Karuma...<E003 15>\r\n<E025 3>C'est un nom imposant, <E003 6>c'est certain.");
                s = s.Replace("Sixteen years ago, <E049><E003 8><E025 2>when my father was a visiting student\r\nhere in London, <E049><E003 8><E025 3>he had this sword forever at his side.", "Il y a seize ans, <E049><E003 8><E025 2>quand mon père était étudiant invité\r\nici à Londres, <E049><E003 8><E025 3>il portait toujours cette épée à son côté.");
                s = s.Replace("Which is why it means so much to me <E049><E003 8>that I have it by\r\nmy side again now too.", "Voilà pourquoi il m'est si cher <E049><E003 8>de la porter à nouveau à mes côtés\r\naujourd'hui.");
                s = s.Replace("And that...<E049><E003 13>is all thanks to you.", "Et cela...<E049><E003 13>c'est grâce à toi.");
                s = s.Replace("...It was an honour.", "...Ce fut un honneur.");
                s = s.Replace("Now...<E003 10>I have preparations to make for tomorrow.<E049><E003 10>\r\n<E025 2>Perhaps I said a little too much.", "Maintenant...<E003 10>j'ai des préparatifs pour demain.<E049><E003 10>\r\n<E025 2>J'en ai peut-être déjà trop dit.");
                s = s.Replace("Kazuma, <E003 8><E025 4>you've...<E003 5><E145 112 0><E118 112 0.5><E003 15><E025 3><E330>changed.", "Kazuma, <E003 8><E025 4>tu as...<E003 5><E145 112 0><E118 112 0.5><E003 15><E025 3><E330>changé.");
                s = s.Replace("No, <E049><E003 6>Ryunosuke, <E049><E003 10>I haven't changed at all.<E049><E003 10>\r\n<E145 112 4><E003 30><E238><E025 2>It's you who's changed.", "Non, <E049><E003 6>Ryunosuke, <E049><E003 10>je n'ai pas changé le moins du monde.<E049><E003 10>\r\n<E145 112 4><E003 30><E238><E025 2>C'est toi qui as changé.");
                s = s.Replace("I can completely understand your resentment of Lord van\r\nZieks given what happened.", "Je comprends parfaitement ton ressentiment envers Lord Van Peers\r\nvu ce qui s'est produit.");
                s = s.Replace("But the fact is, <E003 10><E025 3><E341>those events and this case are, <E003 8>well...", "Mais la réalité, <E003 10><E025 3><E341>c'est que ces événements et cette affaire sont, <E003 8>eh bien...");
                s = s.Replace("...Unrelated?<E049><E003 12> <E025 2>Is that what you want to say?<E049><E003 15>\r\n<E025 3><E145 112 3><E118 112 0.6><E003 10>How can you be so sure?", "...Sans rapport ?<E049><E003 12> <E025 2>C'est ce que tu allais dire ?<E049><E003 15>\r\n<E025 3><E145 112 3><E118 112 0.6><E003 10>Comment peux-tu en être si sûr ?");
                s = s.Replace("What do you mean?", "Que veux-tu dire ?");
                s = s.Replace("...Never mind.", "...Laisse tomber.");
                s = s.Replace("That man is the Reaper.<E049><E003 12> <E025 3>And it's for that reason that the\r\ninspector was killed.", "Cet homme est le Revenant.<E049><E003 12> <E025 3>Et c'est pour cette raison que l'inspecteur\r\na été abattu.");
                s = s.Replace("I'm going to prove as much in court tomorrow...<E049><E003 8>\r\n<E164 112 72 1 2 5 0 3 1><E139 112><E025 1>by whatever means necessary!", "Et je vais le prouver demain au tribunal...<E049><E003 8>\r\n<E164 112 72 1 2 5 0 3 1><E139 112><E025 1>par tous les moyens nécessaires !");
                s = s.Replace("I can't let you do that, <E003 6>Kazuma.", "Je ne peux pas te laisser faire cela, <E003 6>Kazuma.");
                s = s.Replace("I know you'll do what you have to as a lawyer.", "Je sais que tu feras ton devoir en tant qu'avocat.");
                s = s.Replace("But I'm sure I don't need to tell you <E049><E003 10><E145 112 65><E118 112 1.3><E003 6><E025 1><E338><E341>that I won't be taking\r\nany prisoners in the courtroom.", "Mais je n'ai sans doute pas besoin de te préciser <E049><E003 10><E145 112 65><E118 112 1.3><E003 6><E025 1><E338><E341>que je ne ferai\r\naucun quartier dans ce tribunal.");
                s = s.Replace("...I would expect nothing less.", "...Je n'en attendais pas moins.");
                s = s.Replace("Until tomorrow then...<E049><E003 15><E025 3>in the Old Bailey.", "À demain alors...<E049><E003 15><E025 3>à l'Old Bailey.");
                return s;
            };

            // [16] BB\script\output\_sce03_c201_0120_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0120_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Forensics Laboratory", "2 novembre\r\n<CNTR><E003 5>Laboratoire de police scientifique");
                s = s.Replace("This place...<E003 15><E025 3><E341>really is creepy, <E003 6>isn't it?", "Cet endroit...<E003 15><E025 3><E341>est vraiment lugubre, <E003 6>non ?");
                s = s.Replace("Well...<E003 12><E025 2>being a dead room, <E049><E003 2><E164 110 66 1 2 42 0 0 1><E118 110 1.2><E171 110 2 1 1 1><E139 110>it's probably full of the spirits of\r\nthe dissected.", "Eh bien...<E003 12><E025 2>puisque c'est une morgue, <E049><E003 2><E164 110 66 1 2 42 0 0 1><E118 110 1.2><E171 110 2 1 1 1><E139 110>elle est sans doute peuplée\r\ndes esprits des cadavres disséqués.");
                s = s.Replace("But actually...<E049><E003 3><E025 1><E164 3 71 1 2 6 0 0 1><E171 3 1 0 2 2><E139 3>there's a rather pleasing scent of roses in the\r\nair!", "Mais au fond...<E049><E003 3><E025 1><E164 3 71 1 2 6 0 0 1><E171 3 1 0 2 2><E139 3>il flotte un parfum de roses plutôt agréable dans\r\nl'air !");
                s = s.Replace("Well...<E003 10><E025 2>being a dead room...", "Eh bien...<E003 10><E025 2>puisque c'est une morgue...");
                s = s.Replace("...the coroner probably needs a bold scent <E136 3 88 2><E117 3 25><E173 3 1 10 2>like that to\r\nmask the odour of death.", "...le médecin légiste a probablement besoin d'un fort arôme <E136 3 88 2><E117 3 25><E173 3 1 10 2>pour\r\nmasquer l'odeur de la mort.");
                s = s.Replace("Um, <E003 8>Iris...", "Euh, <E003 8>Iris...");
                s = s.Replace("...do you think <E145 110 68>we could change the subject?", "...penses-tu <E145 110 68>que nous pourrions changer de sujet ?");
                s = s.Replace("*Shink, <E003 16>shink, <E003 20>shink, <E003 20>shink*", "*Scritch, <E003 16>scritch, <E003 20>scritch, <E003 20>scritch*");
                s = s.Replace("Wh-<E049><E003 8><E025 2><E145 3 88><E173 3 0 20 2><E144 3><E341>What was that?", "Qu-... <E049><E003 8><E025 2><E145 3 88><E173 3 0 20 2><E144 3><E341>Qu'est-ce que c'était ?");
                s = s.Replace("Ah...<E003 10> <E341>Erm...<E003 15>\r\n<E025 3>Dr Gorey?", "Ah...<E003 10> <E341>Hum...<E003 15>\r\n<E025 3>Docteur Gorey ?");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("Um...<E003 12><E025 3><E341>that noise before...", "Hum...<E003 12><E025 3><E341>ce bruit à l'instant...");
                s = s.Replace("I was sharpening my tools.", "J'aiguisais mes outils.");
                s = s.Replace("I'd be dead meat if I didn't keep a perfectly keen edge on\r\nthem.", "Je ne serais bonne qu'à découper si je ne leur maintenais pas\r\nun tranchant parfait.");
                s = s.Replace("R-<E003 10>Right...", "J-<E003 10>Je vois...");
                s = s.Replace("When following the collagen fibres in the dermis,<E003 8> an\r\nexpertly sharpened scalpel...", "En longeant les fibres de collagène du derme,<E003 8> un\r\nbistouri parfaitement affûté...");
                s = s.Replace("...cuts like cheese.<E049><E003 8>\r\n<E025 2><E145 42 73><E144 42>Would you like a demonstration?", "...tranche comme dans du beurre.<E049><E003 8>\r\n<E025 2><E145 42 73><E144 42>Voulez-vous une démonstration ?");
                s = s.Replace("Oh, <E049><E003 10>yes please!<E049><E003 10> <E025 1>I'd love to see!", "Oh, <E049><E003 10>oui avec joie !<E049><E003 10> <E025 1>J'adorerais voir !");
                s = s.Replace("Then...<E003 8><E164 42 72 1 2 7 0 0 1><E139 42><E025 2>I think you'll do nicely.", "Alors...<E003 8><E164 42 72 1 2 7 0 0 1><E139 42><E025 2>je crois que vous ferez parfaitement l'affaire.");
                s = s.Replace("Huh?!<E003 10> <E025 3>N-<E003 10><E025 1><E356>No!<E003 12>\r\n<E341>No, <E003 6>I wouldn't do nicely at all!", "Hein ?!<E003 10> <E025 3>N-<E003 10><E025 1><E356>Non !<E003 12>\r\n<E341>Non, <E003 6>pas du tout, je ne ferai pas l'affaire !");
                s = s.Replace("I mean...<E145 42 68><E003 14><E025 1><E331>maybe some other time!", "Enfin...<E145 42 68><E003 14><E025 1><E331>une autre fois peut-être !");
                s = s.Replace("Tsk.", "Tss.");
                s = s.Replace("(Was that a tut?)", "(Elle a claqué de la langue ?)");
                s = s.Replace("(Well...<E003 10><E025 2>we came here to ask questions, <E003 8><E025 3>so...)", "(Eh bien...<E003 10><E025 2>nous sommes venus pour poser des questions, <E003 8><E025 3>alors...)");
                return s;
            };

            // [17] BB\script\output\_sce03_c201_0125_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0125_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("If you don't mind, then...", "Si vous voulez bien m'excuser...");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("*Shink, <E003 16>shink, <E003 20>shink, <E003 20>shink*", "*Scritch, <E003 16>scritch, <E003 20>scritch, <E003 20>scritch*");
                s = s.Replace("(She's gone back to sharpening her blades.)", "(Elle s'est remise à affûter ses lames.)");
                s = s.Replace("Erm...", "Hum...");
                s = s.Replace("Not now.<E049><E003 12>\r\n<E025 2>Or my baby here might start to rust.", "Pas maintenant.<E049><E003 12>\r\n<E025 2>Ou mon p'tit bijou va rouiller.");
                s = s.Replace("I think perhaps we'd better leave Dr Gorey alone.", "Je crois qu'il vaut mieux laisser le docteur Gorey tranquille.");
                s = s.Replace("(Maybe we could try again later if we manage to find\r\nsome more clues...)", "(Peut-être pourrions-nous retenter plus tard si nous découvrons d'autres indices...)");
                return s;
            };

            // [18] BB\script\output\_sce03_c201_0130_eng#4
            entryTranslators[@"BB\script\output\_sce03_c201_0130_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Oh yes, <E003 8>one other thing...<E003 10> <E025 2>It's something the governor of\r\nBarclay Prison told us.", "Ah oui, <E003 8>autre chose...<E003 10> <E025 2>C'est une chose que le gouverneur\r\nde la prison de Barclay nous a dite.");
                s = s.Replace("He said that your mother, <E003 8><E025 3>Dr Sithe...", "Il a dit que votre mère, <E003 8><E025 3>le docteur Sithe...");
                s = s.Replace("...was responsible for <E006>confirming the death<E005> of the\r\nProfessor after his execution.", "...était chargée de <E006>confirmer le décès<E005> du\r\nProfesseur après son exécution.");
                s = s.Replace("The Professor...", "Le Professeur...");
                s = s.Replace("Apparently <E003 8>you always enjoyed listening to your mother's\r\nstories about her work, <E003 6><E025 3>so...", "Apparemment, <E003 8>vous aimiez beaucoup écouter votre mère vous\r\nraconter son travail, <E003 6><E025 3>alors...");
                s = s.Replace("...we were wondering if you might know something<E003 4><E145 42 65><E118 42 0.5><E003 8>\r\n<E025 3>about what happened ten years ago.", "...nous nous demandions si vous saviez quelque chose<E003 4><E145 42 65><E118 42 0.5><E003 8>\r\n<E025 3>sur ce qui s'est produit il y a dix ans.");
                return s;
            };

            // [19] BB\script\output\_sce03_c201_0130_eng#5
            entryTranslators[@"BB\script\output\_sce03_c201_0130_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Forensics Laboratory", "2 novembre\r\n<CNTR><E003 5>Laboratoire de police scientifique");
                s = s.Replace("*Shink, <E003 16>shink, <E003 20>shink, <E003 20>shink*", "*Scritch, <E003 16>scritch, <E003 20>scritch, <E003 20>scritch*");
                s = s.Replace("Someone's sharpening again...", "Elle est encore en train d'affûter ses lames...");
                s = s.Replace("You're still not dead?", "Vous n'êtes toujours pas mort ?");
                s = s.Replace("Anyway, <E003 8><E338><E342>I don't have anything more to tell you about that\r\nspecimen.", "De toute façon, <E003 8><E338><E342>je n'ai plus rien à vous dire sur ce spécimen.");
                s = s.Replace("Actually, <E003 8>we're not here to ask you about Inspector\r\nGregson.", "En fait, <E003 8>nous ne venons pas vous interroger sur l'inspecteur\r\nGregson.");
                s = s.Replace("We were hoping to talk about your mother, <E049><E003 15><E025 3><E333><E006>Dr Sithe<E005>.", "Nous espérions vous parler de votre mère, <E049><E003 15><E025 3><E333>le <E006>docteur Sithe<E005>.");
                s = s.Replace("It's something the governor of Barclay Prison mentioned.", "C'est à propos de propos tenus par le gouverneur de la prison de Barclay.");
                s = s.Replace("He said that she <E145 42 65><E117 42 25>was responsible <E003 12><E330>for <E006>confirming the death<E005>\r\nof the Professor after his execution.", "Il disait qu'elle <E145 42 65><E117 42 25>était chargée <E003 12><E330>de <E006>constater le décès<E005>\r\ndu Professeur suite à son exécution.");
                return s;
            };

            // [20] BB\script\output\_sce03_c201_0130_eng#6
            entryTranslators[@"BB\script\output\_sce03_c201_0130_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("That's not all Mama did.", "Ce n'est pas tout ce que Maman a fait.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("My mama...", "Ma maman...");
                s = s.Replace("...carried out the autopsy of <E006>Klint van Zieks<E005> as well!", "...a pratiqué l'autopsie de <E006>Klint Van Peers<E005> elle aussi !");
                s = s.Replace("What?!<E003 20>\r\n<E025 2><E342>Really?!", "Quoi ?!<E003 20>\r\n<E025 2><E342>Vraiment ?!");
                s = s.Replace("(The brother of Lord van Zieks.<E003 12> <E025 2><E338><E341>The Professor's <E006>final\r\nvictim<E007>...)", "(Le frère de Lord Van Peers.<E003 12> <E025 2><E338><E341>La <E006>dernière victime<E007> du\r\nProfesseur...)");
                s = s.Replace("The idea of carrying out an autopsy on a member of the\r\naristocracy was completely unthinkable back then.", "L'idée même de pratiquer une autopsie sur un membre de l'aristocratie\r\nétait totalement inconcevable à l'époque.");
                s = s.Replace("But the detective in charge of the investigation insisted<E003 8>\r\nand it was miraculously authorised.", "Mais le policier chargé de l'enquête a insisté<E003 8>\r\net l'autorisation a été miraculeusement accordée.");
                s = s.Replace("That detective being Inspector Gregson, <E049><E003 6>of course.", "Ce détective n'étant autre que l'inspecteur Gregson, <E049><E003 6>évidemment.");
                s = s.Replace("(Quite an accomplishment for one man...)", "(Un sacré tour de force...)");
                s = s.Replace("That autopsy provided the vital clue needed to arrest the\r\nkiller.", "Cette autopsie a fourni l'indice capital qui a permis d'arrêter\r\nle meurtrier.");
                s = s.Replace("And Mama was there for that historic event.", "Et Maman était présente pour cet événement historique.");
                s = s.Replace("(What does all this mean...?)", "(Qu'est-ce que tout cela signifie... ?)");
                s = s.Replace("You know, <E049><E003 10><E025 2><E238>that amazing autopsy happened right\r\nhere in this very room.", "Vous savez, <E049><E003 10><E025 2><E238>cette autopsie historique a eu lieu ici même,\r\ndans cette salle.");
                s = s.Replace("The Professor <E049><E003 8><E025 3>and Klint van Zieks...", "Le Professeur <E049><E003 8><E025 3>et Klint Van Peers...");
                s = s.Replace("...they both spent their final moments before their burial\r\non that dissection table there.", "...ils ont tous deux reposé avant leur inhumation\r\nsur cette table de dissection là-bas.");
                s = s.Replace("So this lab –<E049><E003 6> Mama's lab –<E049><E003 8> <E173 42 0 16 3><E003 16><E239>was instrumental in some of\r\nthe country's most important events.", "Ce laboratoire –<E049><E003 6> le labo de Maman –<E049><E003 8> <E173 42 0 16 3><E003 16><E239>a joué un rôle clé\r\ndans les événements les plus marquants du pays.");
                s = s.Replace("(She really is proud of her mother.)", "(Elle est vraiment fière de sa mère.)");
                s = s.Replace("I wonder if you'd tell us more about exactly what\r\nhappened back then, <E003 4>Dr Gorey?", "Pourriez-vous nous en dire davantage sur ce qui s'est passé\r\nà cette époque, <E003 4>docteur Gorey ?");
                return s;
            };

            // [21] BB\script\output\_sce03_c201_0150_eng#2
            entryTranslators[@"BB\script\output\_sce03_c201_0150_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Um, <E003 8>Runo...", "Euh, <E003 8>Runo...");
                s = s.Replace("...I hope you don't mind, <E049><E003 8>but...", "...J'espère que ça ne t'ennuie pas, <E049><E003 8>mais...");
                s = s.Replace("What is it, <E003 4>Iris?", "Qu'y a-t-il, <E003 4>Iris ?");
                s = s.Replace("I've just remembered something very important I have to\r\ndo.", "Je viens de me rappeler une chose très importante que je dois\r\nfaire.");
                s = s.Replace("I'm going to have to leave you now!", "Je vais devoir vous laisser !");
                s = s.Replace("Oh!<E049><E003 12> <E025 2>This is very sudden, Iris...", "Oh !<E049><E003 12> <E025 2>C'est bien soudain, Iris...");
                s = s.Replace("Well, <E049><E003 8>we'll come with you, then.", "Eh bien, <E049><E003 8>nous allons t'accompagner.");
                s = s.Replace("Oh no!<E049><E003 12> No no, <E049><E003 6>there's no need!<E049><E003 12><E145 110 77><E003 4>\r\n<E342><E025 2>You and Runo can take your time here.", "Oh non !<E049><E003 12> Non non, <E049><E003 6>ce n'est pas nécessaire !<E049><E003 12><E145 110 77><E003 4>\r\n<E342><E025 2>Runo et toi pouvez prendre votre temps ici.");
                s = s.Replace("Bye for now, then!<E049><E003 4><E164 110 68 1 2 6 0 1 1><E139 110>\r\n<E025 1>Good luck!", "À plus tard alors !<E049><E003 4><E164 110 68 1 2 6 0 1 1><E139 110>\r\n<E025 1>Bonne chance !");
                s = s.Replace("Wait a minute, <E049><E003 8>little girl.", "Attendez une minute, <E049><E003 8>la fillette.");
                s = s.Replace("Hm?<E003 16> <E169 110 3><E341>...Me?", "Hein ?<E003 16> <E169 110 3><E341>...Moi ?");
                s = s.Replace("I remember now.<E049><E003 15>\r\n<E025 2><E145 42 65><E117 42 20><E144 42><E330>You've been here before, <E049><E003 6>haven't you?", "Je me rappelle maintenant.<E049><E003 15>\r\n<E025 2><E145 42 65><E117 42 20><E144 42><E330>Vous êtes déjà venue ici, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("Have you, <E003 8><E025 3>Iris?", "C'est vrai, <E003 8><E025 3>Iris ?");
                s = s.Replace("Yes, <E049><E003 8>two years ago.<E049><E003 10> <E025 2>When that detective came...", "Oui, <E049><E003 8>il y a deux ans.<E049><E003 10> <E025 2>Quand ce policier est venu...");
                s = s.Replace("...you were with him, <E049><E003 8>weren't you?<E049><E003 8><E164 42 72 1 2 22 0 0 1><E139 42>\r\n<E025 2>You were a living specimen then, too.", "...vous étiez avec lui, <E049><E003 8>n'est-ce pas ?<E049><E003 8><E164 42 72 1 2 22 0 0 1><E139 42>\r\n<E025 2>Vous étiez déjà un spécimen vivant à l'époque.");
                s = s.Replace("(That's the way it usually works, <E003 6>yes...)", "(C'est ainsi que cela fonctionne en général, <E003 6>oui...)");
                s = s.Replace("Was I...?<E049><E003 14>\r\nI, <E049><E003 8>I really don't remember.", "Moi... ?<E049><E003 14>\r\nJe... <E049><E003 8>je ne m'en souviens vraiment pas.");
                s = s.Replace("Anyway, <E049><E003 8>sorry, <E049><E003 6><E025 1><E164 110 68 1 2 6 0 1 1><E149 110 0 0><E139 110>but I must dash!", "Bref, <E049><E003 8>désolée, <E049><E003 6><E025 1><E164 110 68 1 2 6 0 1 1><E149 110 0 0><E139 110>mais je dois filer !");
                s = s.Replace("Wait, <E003 6><E025 3><E341>Iris...", "Attends, <E003 6><E025 3><E341>Iris...");
                s = s.Replace("I'll brew up a pot for you when you get home!", "Je vous préparerai une théière pour votre retour !");
                s = s.Replace("(What's the matter with her?)", "(Qu'est-ce qui lui prend ?)");
                s = s.Replace("(She's behaving really strangely all of a sudden.)", "(Elle a un comportement tout à fait bizarre d'un coup.)");
                s = s.Replace("Well, <E003 8><E025 2>in that case, <E003 8>we won't keep you any longer, either.", "Eh bien, <E003 8><E025 2>dans ce cas, <E003 8>nous ne vous retenons pas plus longtemps non plus.");
                s = s.Replace("It's been quite a while since I had any visitors.<E049><E003 10>\r\nThis was really fun!", "Cela faisait un bon moment que je n'avais pas eu de visites.<E049><E003 10>\r\nC'était fort divertissant !");
                s = s.Replace("But next time you come, <E049><E003 8>I'd prefer it if you were ready\r\nfor dissection.", "Mais la prochaine fois, <E049><E003 8>je préférerais que vous soyez prêts\r\npour la dissection.");
                s = s.Replace("...I can't make any promises, <E003 8><E025 3>sorry.", "...Je ne peux rien promettre, <E003 8><E025 3>navré.");
                s = s.Replace("(It's a bit strange that the records of Klint van Zieks's\r\nautopsy have disappeared...)", "(C'est plutôt curieux que les archives de l'autopsie de\r\nKlint Van Peers aient disparu...)");
                s = s.Replace("(...but I think we've asked all we came to ask now.)", "(...mais je crois que nous avons demandé tout ce que nous devions savoir.)");
                return s;
            };

            // [22] BB\script\output\_sce03_c202_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c202_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Room on Fresno Street", "2 novembre\r\n<CNTR><E003 5>Chambre de Fresno Street");
                s = s.Replace("The police are still busily investigating in here then.", "La police est donc toujours occupée à fouiller les lieux.");
                s = s.Replace("But Gina's nowhere to be seen.<E049><E003 10>\r\n<E145 3 92><E117 3 10><E003 8><E333>Where is she?", "Mais Gina n'est nulle part en vue.<E049><E003 10>\r\n<E145 3 92><E117 3 10><E003 8><E333>Où est-elle passée ?");
                s = s.Replace("Yes, <E003 12>it has been blissfully quiet, <E003 6>hasn't it?", "Oui, <E003 12>le silence était presque divin, <E003 6>non ?");
                s = s.Replace("(Perhaps she's out investigating on her own,<E003 5><E145 3 68><E003 3> <E025 2>practising\r\nwhat her boss taught her...)", "(Peut-être enquête-t-elle de son côté,<E003 5><E145 3 68><E003 3> <E025 2>en appliquant\r\nce que lui a appris son patron...)");
                s = s.Replace("Well, <E049><E003 8>I expect she'll be back before too long.<E049><E003 8><E145 3 65><E003 8>\r\nShall we wait?", "Eh bien, <E049><E003 8>elle ne devrait plus tarder à revenir.<E049><E003 8><E145 3 65><E003 8>\r\nAttendons-nous ?");
                s = s.Replace("(Actually...)", "(À vrai dire...)");
                s = s.Replace("(...there's <E006>something different<E007> about this room since the\r\nlast time we were here, <E003 8>isn't there?)", "(...il y a <E006>quelque chose de changé<E007> dans cette pièce depuis notre\r\ndernière visite, <E003 8>non ?)");
                s = s.Replace("We could always use the time to investigate more\r\nthoroughly!", "Nous pourrions mettre ce temps à profit pour fouiller plus en détail !");
                return s;
            };
        }
    }
}
