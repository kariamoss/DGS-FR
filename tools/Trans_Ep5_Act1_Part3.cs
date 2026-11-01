using System;
using System.Collections.Generic;

namespace TranslatorEp5Act1 {
    public partial class Program {
        public static void RegisterPart3() {

            // [70] BB\script\output\_sce04_c102_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c102_0020_eng#2"] = (s) => {
                s = s.Replace("This...<E049><E003 10><E025 2><E145 1 85><E003 8>is a trunk that belonged to Inspector Gregson.", "Ceci...<E049><E003 10><E025 2><E145 1 85><E003 8>est une malle qui appartenait à l'inspecteur Gregson.");
                s = s.Replace("A metal construction, <E003 4>is it?<E049><E003 12>\r\n<E025 2>It's certainly very heavy.", "Une structure métallique, <E003 4>n'est-ce pas ?<E049><E003 12>\r\n<E025 2>Elle est particulièrement lourde en tout cas.");
                s = s.Replace("...!<E003 10>\r\n<E025 3>What's this?", "... !<E003 10>\r\n<E025 3>Qu'est-ce donc ?");
                s = s.Replace("A bloodstain<E005>?<E049><E003 12>\r\n<E025 2>And a relatively fresh one, too.", "Une tache de sang<E005> ?<E049><E003 12>\r\n<E025 2>Et relativement fraîche, de surcroît.");
                s = s.Replace("Wot?!<E049><E003 15> <E025 2>You, <E049><E003 8><E330>you mean that ain't grease from all the boss's\r\nfish an' chips?!", "Quoi ?!<E049><E003 15> <E025 2>Vous... <E049><E003 8><E330>vous voulez dire que c'est pas du gras de fish and chips\r\ndu patron ?!");
                s = s.Replace("Fresh blood on the inspector's trunk...", "Du sang frais sur la malle de l'inspecteur...");
                s = s.Replace("That suggests <E049><E003 10><E025 2><E239>that the victim was <E006>travelling with that\r\nluggage<E005> when he was killed.", "Cela suggère <E049><E003 10><E025 2><E239>que la victime <E006>voyageait avec ce\r\nbagage<E005> au moment où elle a été tuée.");
                s = s.Replace("That can't be.<E049><E003 14> <E025 2><E338><E341>There was no mention of any trunk in\r\nScotland Yard's report.", "C'est impossible.<E049><E003 14> <E025 2><E338><E341>Le rapport de Scotland Yard ne fait aucune\r\nmention d'une quelconque malle.");
                s = s.Replace("Yes, <E049><E003 8>there's a reason for that.", "En effet, <E049><E003 8>et il y a une bonne raison à cela.");
                s = s.Replace("Immediately after the inspector's body was discovered,<E049><E003 14>\r\n<E333>one of the street pedlars made off with the trunk...", "Aussitôt après la découverte du corps de l'inspecteur,<E049><E003 14>\r\n<E333>l'un des camelots des rues a chipé la malle...");
                s = s.Replace("...hoping to sell it.", "...dans l'espoir de la revendre.");
                s = s.Replace("But I found it!<E049><E003 12> <E025 2>Me, <E049><E003 14><E025 1><E341>wiv me nose for trouble!", "Mais j'l'ai retrouvée !<E049><E003 12> <E025 2>Moi, <E049><E003 14><E025 1><E341>avec mon flair pour dégoter les ennuis !");
                s = s.Replace("Which means that nobody should have known anything\r\nabout the trunk.", "Ce qui signifie que nul n'aurait dû avoir connaissance\r\nde l'existence de cette malle.");
                s = s.Replace("Unless of course...<E049><E003 8><E145 1 21><E118 1 0.7><E003 12><E330>we're talking about somebody who was\r\n<E006>present<E005> when the victim was killed.", "À moins, bien sûr...<E049><E003 8><E145 1 21><E118 1 0.7><E003 12><E330>qu'il ne s'agisse de quelqu'un qui était\r\n<E006>présent<E005> au moment où la victime a été tuée.");
                s = s.Replace("And yet...<E049><E003 10><E025 2>during the cross-examination of the witness\r\njust now, <E049><E003 8>you said this, <E003 4>Kazuma:", "Et pourtant...<E049><E003 10><E025 2>lors du contre-interrogatoire du témoin\r\ntout à l'heure, <E049><E003 8>tu as dit ceci, <E003 4>Kazuma :");
                s = s.Replace("Because at the time <E049><E003 8>he was making his way to the\r\nsteamship docked on the northern coast of France.", "Car à ce moment-là, <E049><E003 8>il se rendait à bord du navire à vapeur\r\namarré sur la côte nord de la France.");
                s = s.Replace("As shown by the passport found in the victim's metal\r\ntrunk.", "Comme le prouve le passeport trouvé dans la malle métallique\r\nde la victime.");
                s = s.Replace("So the question is...<E049><E003 14><E025 2>how did you know about the\r\ninspector's trunk?", "La question est donc...<E049><E003 14><E025 2>comment savais-tu pour la malle\r\nde l'inspecteur ?");
                s = s.Replace("We know the man went on a trip to France.", "Nous savons que cet homme a fait un voyage en France.");
                s = s.Replace("Where else would he have put his passport?", "Où d'autre aurait-il bien pu ranger son passeport ?");
                s = s.Replace("But <E049><E003 10><E025 1><E330>you knew it was <E006>a metal trunk<E005>!", "Mais <E049><E003 10><E025 1><E330>tu savais que c'était <E006>une malle métallique<E005> !");
                s = s.Replace("Answer me honestly, <E049><E003 8>Kazuma!", "Réponds-moi franchement, <E049><E003 8>Kazuma !");
                s = s.Replace("On 31st October...<E049><E003 15><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>where exactly were you?!", "Le 31 octobre...<E049><E003 15><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>où étais-tu exactement ?!");
                s = s.Replace("At the Port of Dunkirk, <E049><E003 10>on board the SS Grouse...", "Au port de Dunkerque, <E049><E003 10>à bord du SS Grouse...");
                s = s.Replace("Is that the answer you're looking for, <E049><E003 6>Ryunosuke?", "Est-ce la réponse que tu attendais, <E049><E003 6>Ryunosuke ?");
                s = s.Replace("Kazuma!<E049><E003 14> <E025 2><E341>What did you...?!", "Kazuma !<E049><E003 14> <E025 2><E341>Qu'as-tu... ?!");
                s = s.Replace("(I hadn't considered the possibility before, <E003 10><E341><E025 3>but...)", "(Je n'avais jamais envisagé cette possibilité auparavant, <E003 10><E341><E025 3>mais...)");
                s = s.Replace("(...if Kazuma was there <E006>on the ship<E007>, then...<E003 15><E025 3>it can only have\r\nbeen<E003 6> for <E006>one purpose<E007>...)", "(...si Kazuma était là-bas, <E006>sur le navire<E007>, alors...<E003 15><E025 3>ce ne pouvait être<E003 6> que pour <E006>une seule raison<E007>...)");
                s = s.Replace("Oh no, Mr Naruhodo!<E049><E003 15>\r\n<E025 3><E145 9 88><E118 9 0.7><E149 9 8 0><E003 10><E341>Surely...<E049><E003 8><E341>surely you don't think...?", "Oh non, M. Naruhodo !<E049><E003 15>\r\n<E025 3><E145 9 88><E118 9 0.7><E149 9 8 0><E003 10><E341>Vous ne pensez tout de même pas...<E049><E003 8><E341>tout de même pas que... ?");
                s = s.Replace("Come on, Ryunosuke, <E049><E003 6>you know the rules.", "Allons, Ryunosuke, <E049><E003 6>tu connais les règles.");
                s = s.Replace("The only thing that really talks in the courtroom<E049><E003 12> is hard\r\nevidence.", "La seule chose qui compte vraiment dans ce prétoire,<E049><E003 12> ce sont les preuves\r\nirréfutables.");
                s = s.Replace("As I understand it, <E049><E003 8>Inspector Gregson always took that\r\ncase with him when he travelled.", "Si j'ai bien compris, <E049><E003 8>l'inspecteur Gregson emportait toujours cette\r\nmalle avec lui lors de ses déplacements.");
                s = s.Replace("So as it stands...<E003 10><E025 3>you've proved nothing.", "En l'état...<E003 10><E025 3>tu n'as absolument rien prouvé.");
                s = s.Replace("...are you challenging me to prove it, <E049><E003 8>beyond all\r\nreasonable doubt?", "...es-tu en train de me mettre au défi de le prouver, <E049><E003 8>au-delà de tout\r\ndoute raisonnable ?");
                s = s.Replace("That you were there that day...<E049><E003 8><E145 1 21><E118 1 0.8><E003 10><E025 1><E330>in <E006>the same place<E005> as the\r\ninspector!", "Que tu te trouvais là-bas ce jour-là...<E049><E003 8><E145 1 21><E118 1 0.8><E003 10><E025 1><E330>au <E006>même endroit<E005> que\r\nl'inspecteur !");
                s = s.Replace("He, <E049><E003 10><E335><E025 2>he was there?<E049><E003 12>\r\n<E025 3><E341>With Gregson?", "I-, <E049><E003 10><E335><E025 2>il était là-bas ?<E049><E003 12>\r\n<E025 3><E341>Avec Gregson ?");
                s = s.Replace("There's a clue that you've overlooked!<E049><E003 14>\r\n<E025 1><E346>A secret that trunk can tell us.", "Il y a un indice qui t'a échappé !<E049><E003 14>\r\n<E025 1><E346>Un secret que cette malle peut nous révéler.");
                s = s.Replace("(I can't be sure at this point.<E003 10>\r\n<E025 2>I'll need to verify it.)", "(Je ne peux pas en être certain à ce stade.<E003 10>\r\n<E025 2>Je dois le vérifier.)");
                s = s.Replace("(But I have a nasty feeling...<E003 10><E338><E341><E025 2>that I'm going to be right.)", "(Mais j'ai le terrible pressentiment...<E003 10><E338><E341><E025 2>que je ne me trompe pas.)");
                return s;
            };

            // [71] BB\script\output\_sce04_c102_0030_eng#2
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#2"] = (s) => {
                s = s.Replace("The accusation being made is deeply disturbing.<E049><E003 10>\r\n<E025 3>But nevertheless...<E003 12>we must test it.", "L'accusation portée ici est extrêmement troublante.<E049><E003 10>\r\n<E025 3>Cependant...<E003 12>il nous faut l'examiner.");
                return s;
            };

            // [72] BB\script\output\_sce04_c102_0030_eng#3
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#3"] = (s) => {
                s = s.Replace("The defence will identify for the court where in the\r\ntrunk this alleged clue is to be found.", "La défense va indiquer au tribunal où se trouve\r\ncet indice présumé sur la malle.");
                return s;
            };

            // [73] BB\script\output\_sce04_c102_0030_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#4"] = (s) => {
                s = s.Replace("Where is the evidence that ties Prosecutor Asogi to\r\nInspector Gregson?", "Où est la preuve qui relie le procureur Asogi à\r\nl'inspecteur Gregson ?");
                return s;
            };

            // [74] BB\script\output\_sce04_c102_0030_eng#5
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#5"] = (s) => {
                s = s.Replace("I can't find anything out of place.", "Je ne vois rien d'anormal.");
                return s;
            };

            // [75] BB\script\output\_sce04_c102_0030_eng#6
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#6"] = (s) => {
                s = s.Replace("Look at this dark stain here.<E003 10>\r\n<E025 3>Do you think...?", "Regardez cette sombre tache ici.<E003 10>\r\n<E025 3>Pensez-vous que... ?");
                s = s.Replace("Yes, <E003 8>I'm afraid so.<E003 12>\r\n<E330>I think it's <E006>blood<E005>.", "Oui, <E003 8>j'en ai bien peur.<E003 12>\r\n<E330>Je crains qu'il ne s'agisse de <E006>sang<E005>.");
                s = s.Replace("Ugh, <E003 10>I knew you were going to say that.<E003 12>\r\n<E025 3><E341>So that presumably means...", "Argh, <E003 10>je savais que vous alliez dire cela.<E003 12>\r\n<E025 3><E341>Ce qui signifie probablement...");
                s = s.Replace("...That this was present at <E006>the scene<E005> <E003 8><E025 3>when Inspector\r\nGregson was killed.", "...Que cette malle se trouvait sur <E006>les lieux<E005> <E003 8><E025 3>quand l'inspecteur\r\nGregson a été tué.");
                s = s.Replace("It's the most logical conclusion, <E003 6><E025 3>yes.", "C'est la conclusion la plus logique, <E003 6><E025 3>en effet.");
                s = s.Replace("To think Gina's been carrying this around with her...", "Quand on pense que Gina a trimballé ça avec elle...");
                s = s.Replace("(If you didn't know any better, <E003 8>I suppose it does look like a\r\ngrease stain from all the fish and chips...)", "(Si l'on ne savait pas, <E003 8>j'imagine que ça ressemble vraiment à une tache\r\nde graisse de fish and chips...)");
                return s;
            };

            // [76] BB\script\output\_sce04_c102_0030_eng#7
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#7"] = (s) => {
                s = s.Replace("31st October...<E003 12> So this passport is for the day before\r\nGregson's body was found.", "Le 31 octobre...<E003 12> Ce passeport date donc de la veille\r\nde la découverte du corps de Gregson.");
                s = s.Replace("He needed this document for his trip to France.", "Il avait besoin de ce document pour son voyage en France.");
                s = s.Replace("And when it says <E003 10><E025 3><E330>‘permission for the applicant and one\r\nadditional person to travel’...", "Et quand il est écrit <E003 10><E025 3><E330>« autorisation accordée au demandeur et à une\r\npersonne supplémentaire pour voyager »...");
                s = s.Replace("(...I can't believe it was you, <E003 10><E025 3>Kazuma...)", "(...je n'arrive pas à croire qu'il s'agissait de toi, <E003 10><E025 3>Kazuma...)");
                return s;
            };

            // [77] BB\script\output\_sce04_c102_0030_eng#8
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#8"] = (s) => {
                s = s.Replace("Do you see that?<E003 10> There's something stuck in the side\r\nof the trunk there.<E003 12> <E330>It's glinting.", "Vous voyez ça ?<E003 10> Il y a quelque chose de coincé sur le flanc\r\nde la malle.<E003 12> <E330>Ça brille.");
                s = s.Replace("It looks like <E006>a fragment of metal<E005> of some sort.", "On dirait <E006>un fragment de métal<E005> d'une certaine sorte.");
                s = s.Replace("But it's wedged in so tightly, <E003 8><E025 3>I can't remove it.", "Mais il est si fermement incrusté <E003 8><E025 3>que je n'arrive pas à le retirer.");
                s = s.Replace("Well don't cut yourself.<E003 10>\r\nYou'd better leave it, I think.", "Faites attention à ne pas vous couper.<E003 10>\r\nIl vaut mieux le laisser là, je pense.");
                return s;
            };

            // [78] BB\script\output\_sce04_c102_0030_eng#9
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#9"] = (s) => {
                s = s.Replace("(Let's have a look inside...)", "(Regardons à l'intérieur...)");
                return s;
            };

            // [79] BB\script\output\_sce04_c102_0030_eng#10
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#10"] = (s) => {
                s = s.Replace("Have you seen this huge gash across the side of the trunk\r\nhere?", "Avez-vous vu cette énorme entaille sur le côté de la malle\r\nici ?");
                s = s.Replace("It's gone right through the leather and into the metal\r\nbehind.", "Elle a traversé le cuir pour entailler le métal\r\nen dessous.");
                s = s.Replace("Gosh, <E003 8><E025 2>for a metal chest like this to have been so badly\r\ndamaged...", "Grand Dieu, <E003 8><E025 2>pour qu'un coffre en métal comme celui-ci ait été si lourdement\r\nendommagé...");
                s = s.Replace("Whatever made the gash must have struck the side of the\r\ntrunk with considerable force.", "Ce qui a causé cette entaille a dû frapper le flanc de la\r\nmalle avec une violence considérable.");
                s = s.Replace("(I wonder how it happened...)", "(Je me demande comment cela s'est produit...)");
                return s;
            };

            // [80] BB\script\output\_sce04_c102_0030_eng#13
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#13"] = (s) => {
                s = s.Replace("This is your proof?<E049><E003 10>\r\n<E025 2><E145 61 5><E003 6>What do you say to that, <E049><E003 6>Prosecutor Asogi?", "C'est là votre preuve ?<E049><E003 10>\r\n<E025 2><E145 61 5><E003 6>Qu'avez-vous à répondre à cela, <E049><E003 6>procureur Asogi ?");
                s = s.Replace("Personally...", "Personnellement...");
                s = s.Replace("...I think tying the defence counsel to the inspector's\r\ntrunk and tossing it into the sea would be more helpful.", "...je pense qu'attacher l'avocat de la défense à la malle de l'inspecteur\r\net jeter le tout à la mer serait bien plus utile.");
                s = s.Replace("At least that way, <E049><E003 10><E238>London's courtrooms will be safe from\r\nhis destructive accusations.", "Au moins de cette manière, <E049><E003 10><E238>les prétoires londoniens seront épargnés\r\npar ses accusations pernicieuses.");
                s = s.Replace("I believe that was a rather long-winded way<E049><E003 10> <E346>of telling\r\nyou that you're wrong, Mr Naruhodo.", "Je crois que c'était une manière plutôt alambiquée<E049><E003 10> <E346>de vous\r\nfaire comprendre que vous vous trompez, M. Naruhodo.");
                s = s.Replace("Very well.<E049><E003 12> <E239><E025 2>Then let us see if you sink or swim under the\r\nweight of this penalty, <E049><E003 6>Counsel.", "Très bien.<E049><E003 12> <E239><E025 2>Voyons donc si vous coulerez ou nagerez sous le\r\npoids de cette pénalité, <E049><E003 6>maître.");
                s = s.Replace("AAAAAAAAA<E345>GH!", "AAAAAAAAA<E345>ARGH !");
                s = s.Replace("Mr Naruhodo!<E049><E003 16> <E025 1><E346>You can't allow yourself to be drowned at\r\nsea yet!", "M. Naruhodo !<E049><E003 16> <E025 1><E346>Vous ne pouvez pas vous laisser noyer en haute\r\nmer pour le moment !");
                s = s.Replace("I...<E003 10>was hoping never to let that happen, <E003 6>funnily enough.", "J'...<E003 10>espérais bien que cela n'arrive jamais, <E003 6>curieusement.");
                return s;
            };

            // [81] BB\script\output\_sce04_c102_0030_eng#14
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#14"] = (s) => {
                s = s.Replace("There's a small piece of metal lodged in the wall of the\r\ntrunk here.<E049><E003 5> <E145 1 0><E118 1 1.3><E149 1 0 8><E003 20><E025 3><E330>Like <E006>the tip of a blade<E005>.", "Il y a un petit morceau de métal incrusté dans la paroi de la\r\nmalle ici.<E049><E003 5> <E145 1 0><E118 1 1.3><E149 1 0 8><E003 20><E025 3><E330>Comme <E006>la pointe d'une lame<E005>.");
                s = s.Replace("Eh?<E049><E003 12> <E025 2>A blade?", "Hein ?<E049><E003 12> <E025 2>Une lame ?");
                s = s.Replace("Kazuma, <E049><E003 10>slung around your waist as ever today...", "Kazuma, <E049><E003 10>attachée à ta ceinture comme toujours aujourd'hui...");
                s = s.Replace("...is the esteemed blade Karuma!", "...se trouve la noble lame Karuma !");
                s = s.Replace("Of course it is.", "Bien évidemment.");
                s = s.Replace("Won't you draw it?<E049><E003 12> <E025 2>Here in this courtroom...<E049><E003 10><E025 3><E145 1 0><E118 1 0.7><E003 30>for all to see.", "Ne voudrais-tu pas la dégainer ?<E049><E003 12> <E025 2>Ici, dans ce prétoire...<E049><E003 10><E025 3><E145 1 0><E118 1 0.7><E003 30>aux yeux de tous ?");
                s = s.Replace("Exercise caution, <E049><E003 8>my learned friend.", "Faites preuve de prudence, <E049><E003 8>mon cher confrère.");
                s = s.Replace("That man <E049><E003 10><E025 2><E145 18 0><E118 18 1.3><E003 12><E239>is the son of London's most notorious killer.", "Cet homme <E049><E003 10><E025 2><E145 18 0><E118 18 1.3><E003 12><E239>est le fils du meurtrier le plus tristement célèbre de Londres.");
                s = s.Replace("Bailiff!<E049><E003 13><E145 61 7><E118 61 0.5><E003 10>\r\n<E025 1>Watch Prosecutor Asogi like a hawk!", "Huissier !<E049><E003 13><E145 61 7><E118 61 0.5><E003 10>\r\n<E025 1>Surveillez le procureur Asogi comme le lait sur le feu !");
                s = s.Replace("...That won't be necessary.", "...Ce ne sera pas nécessaire.");
                s = s.Replace("The tip...<E003 16><E239><E462 -206.445007 206.655182 -699.071228 0 1><E464 -321.951477 212.700516 -597.422546 0 1><E466 15 0 1><E485 45 0 1><E025 2>is broken...", "La pointe...<E003 16><E239><E462 -206.445007 206.655182 -699.071228 0 1><E464 -321.951477 212.700516 -597.422546 0 1><E466 15 0 1><E485 45 0 1><E025 2>est brisée...");
                s = s.Replace("If the fragment of metal from the trunk fits together with\r\nthe end of the sword...", "Si le fragment de métal de la malle correspond parfaitement\r\nà l'extrémité du sabre...");
                s = s.Replace("...the question of who was there with Inspector Gregson\r\nwill be answered.", "...la question de savoir qui se trouvait avec l'inspecteur Gregson\r\ntrouvera sa réponse.");
                s = s.Replace("Agreed...<E049><E003 14><E145 1 7><E549 7 21 5 1><E131><E332>Kazuma Asogi?!", "Tu ne trouves pas...<E049><E003 14><E145 1 7><E549 7 21 5 1><E131><E332>Kazuma Asogi ?!");
                s = s.Replace("Expertly done, <E003 6><E025 2>Ryunosuke!<E049><E003 13>\r\n<E025 2><E145 112 6><E118 112 0.5><E003 15>That's a point to you, <E049><E003 10><E025 3>and well deserved.", "Remarquablement joué, <E003 6><E025 2>Ryunosuke !<E049><E003 13>\r\n<E025 2><E145 112 6><E118 112 0.5><E003 15>C'est un point pour toi, <E049><E003 10><E025 3>et bien mérité.");
                s = s.Replace("Do you mean to tell the court, <E049><E003 8><E145 61 5><E118 61 0.6><E025 3><E342><E338>Prosecutor Asogi...?", "Voulez-vous signifier au tribunal, <E049><E003 8><E145 61 5><E118 61 0.6><E025 3><E342><E338>procureur Asogi... ?");
                s = s.Replace("Yes, <E049><E003 6>on 31st October, <E049><E003 10><E025 2>I accompanied Inspector Gregson to\r\nDunkirk...", "Oui, <E049><E003 6>le 31 octobre, <E049><E003 10><E025 2>j'ai accompagné l'inspecteur Gregson à\r\nDunkerque...");
                s = s.Replace("...in order to carry out a mission.", "...afin d'exécuter une mission.");
                return s;
            };

            // [82] BB\script\output\_sce04_c102_0030_eng#15
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#15"] = (s) => {
                s = s.Replace("Yes, <E049><E003 6>on 31st October, <E049><E003 10><E025 2>I accompanied Inspector Gregson to\r\nDunkirk...", "Oui, <E049><E003 6>le 31 octobre, <E049><E003 10><E025 2>j'ai accompagné l'inspecteur Gregson à\r\nDunkerque...");
                s = s.Replace("...in order to carry out a mission.", "...afin d'exécuter une mission.");
                return s;
            };

            // [83] BB\script\output\_sce04_c102_0030_eng#16
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#16"] = (s) => {
                s = s.Replace("So the ‘<E006>additional person<E005>’ authorised to travel...", "Ainsi, la « <E006>personne supplémentaire<E005> » autorisée à voyager...");
                s = s.Replace("...Was me.", "...C'était moi.");
                s = s.Replace("And the mission was...?", "Et cette mission était... ?");
                s = s.Replace("...The assassination of the mark.", "...L'assassinat de la cible.");
                return s;
            };

            // [84] BB\script\output\_sce04_c102_0030_eng#17
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#17"] = (s) => {
                s = s.Replace("And the mission was...?", "Et cette mission était... ?");
                s = s.Replace("...The assassination of the mark.", "...L'assassinat de la cible.");
                return s;
            };

            // [85] BB\script\output\_sce04_c102_0030_eng#18
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#18"] = (s) => {
                s = s.Replace("Wha...<E003 15><E024>", "Qu...<E003 15><E024>");
                s = s.Replace("WHAAAAAAT?!", "QUOOOOOOOOI ?!");
                s = s.Replace("You mean...<E003 15><E025 1><E060 0 153 1 0><E346>you're the killer whose name was omitted\r\nfrom this notebook?!", "Tu veux dire que...<E003 15><E025 1><E060 0 153 1 0><E346>tu es le tueur dont le nom a été omis\r\nde ce carnet ?!");
                s = s.Replace("You were following the Reaper's orders...<E003 10><E025 3>to dispatch Judge\r\nJigoku...?", "Tu suivais les ordres du Faucheur...<E003 10><E025 3>pour éliminer le juge\r\nJigoku... ?");
                s = s.Replace("Let me make one thing perfectly clear:", "Que les choses soient parfaitement claires :");
                s = s.Replace("I have killed no one.", "Je n'ai tué personne.");
                s = s.Replace("Explain.", "Expliquez-vous.");
                s = s.Replace("I accepted the assassination mission, <E049><E003 6><E025 3>yes.<E049><E003 10>\r\n<E025 2>And I accompanied Gregson to Dunkirk.", "J'ai accepté cette mission d'assassinat, <E049><E003 6><E025 3>oui.<E049><E003 10>\r\n<E025 2>Et j'ai bien accompagné Gregson à Dunkerque.");
                s = s.Replace("But I never had any intention of carrying out the plan.", "Mais je n'ai jamais eu la moindre intention de mettre ce plan à exécution.");
                s = s.Replace("You were never going to do it...?", "Tu n'allais jamais le faire... ?");
                s = s.Replace("...We can believe Kazuma-sama, <E049><E145 1 85><E171 1 16 0 10 2><E003 10><E145 9 77><E149 9 4 0><E003 10><E025 3>I'm sure.", "...Nous pouvons croire Kazuma-sama, <E049><E145 1 85><E171 1 16 0 10 2><E003 10><E145 9 77><E149 9 4 0><E003 10><E025 3>j'en suis convaincue.");
                s = s.Replace("After all, <E049><E003 10><E333>Judge Jigoku arrived safely in London the\r\nfollowing day.", "Après tout, <E049><E003 10><E333>le juge Jigoku est arrivé sain et sauf à Londres le\r\nlendemain.");
                return s;
            };

            // [86] BB\script\output\_sce04_c102_0030_eng#19
            entryTranslators[@"BB\script\output\_sce04_c102_0030_eng#19"] = (s) => {
                s = s.Replace("We've wasted enough time!", "Nous avons perdu assez de temps !");
                s = s.Replace("It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.", "Il m'apparaît évident <E049><E003 8><E025 2>que tout débat supplémentaire sur cette affaire\r\nserait stérile.");
                s = s.Replace("Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...", "Lord Drake Van Peers, <E049><E003 8><E025 2>j'ose espérer que, bien qu'égaré...");
                s = s.Replace("...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...", "...vous avez néanmoins agi animé par un sens de la justice.<E049><E003 12>\r\n<E025 3>Bien qu'il me soit douloureux d'en arriver à cette conclusion...");
                s = s.Replace("No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!", "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                s = s.Replace("In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "Conformément aux conclusions de ce tribunal, <E049><E003 6><E025 3>je déclare par\r\nla présente l'accusé, <E049><E003 6><E025 3>Lord Drake Van Peers...");
                s = s.Replace("That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!", "L'audience est levée !<E049><E003 10>\r\n<E025 2>La séance est close !");
                return s;
            };

            // [87] BB\script\output\_sce04_c102_0040_eng#2
            entryTranslators[@"BB\script\output\_sce04_c102_0040_eng#2"] = (s) => {
                s = s.Replace("On the 31st, <E049><E003 10><E025 2>I boarded a train from London with Inspector\r\nGregson.", "Le 31, <E049><E003 10><E025 2>j'ai pris un train depuis Londres avec l'inspecteur\r\nGregson.");
                s = s.Replace("We travelled to Dover, <E049><E003 8>from where we crossed the\r\nChannel to Dunkirk.", "Nous avons gagné Douvres, <E049><E003 8>d'où nous avons traversé la\r\nManche jusqu'à Dunkerque.");
                s = s.Replace("Then we boarded the SS Grouse and made for the cabin\r\ndeck –<E049><E003 10> <E025 3>as indicated in the plan.", "Ensuite, nous sommes montés à bord du SS Grouse et nous sommes dirigés vers le pont des cabines –<E049><E003 10> <E025 3>comme l'indiquait le plan.");
                s = s.Replace("You went to Judge Jigoku's cabin?", "Vous êtes allés jusqu'à la cabine du juge Jigoku ?");
                s = s.Replace("Exactly.", "Exactement.");
                s = s.Replace("He wasn't there, though.<E049><E003 12> <E025 2>We decided to wait, <E049><E003 6><E025 3>but...", "Il n'y était pas, cependant.<E049><E003 12> <E025 2>Nous avons décidé d'attendre, <E049><E003 6><E025 3>mais...");
                s = s.Replace("But you've already told us you had no intention of going\r\nthrough with it anyway.", "Mais vous venez de nous dire que vous n'aviez aucune intention d'aller\r\njusqu'au bout de toute façon.");
                return s;
            };

            // [88] BB\script\output\_sce04_c102_0040_eng#3
            entryTranslators[@"BB\script\output\_sce04_c102_0040_eng#3"] = (s) => {
                s = s.Replace("I didn't come to Great Britain to take anyone's life.", "Je ne suis pas venu en Grande-Bretagne pour ôter la vie à qui que ce soit.");
                s = s.Replace("So I left Gregson <E049><E003 8><E025 3>and disembarked the ship.", "J'ai donc laissé Gregson <E049><E003 8><E025 3>et j'ai débarqué du navire.");
                s = s.Replace("I spent that night at a boarding house in the town,<E049><E003 8> and\r\nreturned to England the following morning.", "J'ai passé la nuit dans une pension de famille de la ville,<E049><E003 8> et\r\nje suis rentré en Angleterre le lendemain matin.");
                return s;
            };

            // [89] BB\script\output\_sce04_c102_0040_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0040_eng#4"] = (s) => {
                s = s.Replace("A boarding house...<E003 10>in Dunkirk?", "Une pension de famille...<E003 10>à Dunkerque ?");
                s = s.Replace("My signature will be in the register book.<E049><E003 8><E145 112 3><E118 112 1.5><E003 6>\r\n<E025 3>It would be simple enough to verify.", "Ma signature figurera sur le registre des arrivées.<E049><E003 8><E145 112 3><E118 112 1.5><E003 6>\r\n<E025 3>Ce sera bien assez simple à vérifier.");
                s = s.Replace("Then <E049><E003 10><E145 61 7><E118 61 0.5><E003 10><E025 3>what became of Jigoku?", "Alors, <E049><E003 10><E145 61 7><E118 61 0.5><E003 10><E025 3>qu'est-il advenu de Jigoku ?");
                s = s.Replace("Gregson was no assassin.<E049><E003 7> <E145 112 0><E118 112 1.5><E003 12><E025 3>So the mark was spared.", "Gregson n'était pas un assassin.<E049><E003 7> <E145 112 0><E118 112 1.5><E003 12><E025 3>La cible a donc été épargnée.");
                s = s.Replace("I'm sure it's easy enough to imagine what happened after\r\nthat.", "Je suis certain qu'il est aisé d'imaginer la suite des événements.");
                s = s.Replace("Gregson returned to England as well, <E003 6>having failed to\r\ncomplete the mission.", "Gregson est retourné en Angleterre lui aussi, <E003 6>après avoir échoué\r\nà accomplir sa mission.");
                s = s.Replace("He met with the Reaper in that room on Fresno Street to\r\nreport the failure...", "Il a rencontré le Faucheur dans cette chambre de Fresno Street pour lui\r\nrapporter son échec...");
                s = s.Replace("...causing the infuriated mastermind<E049><E003 12> <E085 3 31><E338><E342>to pull the trigger...", "...provoquant la fureur du commanditaire,<E049><E003 12> <E085 3 31><E338><E342>qui a pressé la détente...");
                s = s.Replace("...and end his wretched agent's life.", "...mettant fin aux jours de son misérable sbire.");
                s = s.Replace("That's the real truth <E049><E003 15><E025 1><E346>behind Inspector Gregson's murder!", "Voilà la stricte vérité <E049><E003 15><E025 1><E346>derrière le meurtre de l'inspecteur Gregson !");
                s = s.Replace("But if you did nothing as you claim...", "Mais si vous n'avez rien fait comme vous le prétendez...");
                s = s.Replace("...how did <E006>the tip of your sword<E005> come to be lodged in the\r\ninspector's trunk?", "...comment <E006>la pointe de votre sabre<E005> s'est-elle retrouvée logée dans\r\nla malle de l'inspecteur ?");
                s = s.Replace("I don't need to answer that.", "Je n'ai pas à répondre à cette question.");
                s = s.Replace("The victim was killed by a gunshot.<E049><E003 10> <E025 2>A small fragment of a\r\nJapanese blade isn't relevant to the case.", "La victime a été tuée par arme à feu.<E049><E003 10> <E025 2>Un infime fragment de lame\r\njaponaise n'a aucun rapport avec l'affaire.");
                s = s.Replace("And accordingly...<E049><E003 12><E025 2>I choose to exercise my right to silence\r\non that matter.", "Par conséquent...<E049><E003 12><E025 2>je choisis d'exercer mon droit au silence\r\nsur ce point.");
                s = s.Replace("Be that as it may, <E049><E003 8><E338><E341><E025 2>the court will sequester the sword as\r\nevidence.", "Quoi qu'il en soit, <E049><E003 8><E338><E341><E025 2>le tribunal ordonne la mise sous séquestre de ce sabre\r\ncomme pièce à conviction.");
                s = s.Replace("As you wish, <E003 8>My Lord.", "Comme vous voudrez, <E003 8>Votre Seigneurie.");
                s = s.Replace("The great sword ‘Karuma’ has been\r\nentered into the Court Record.", "Le grand sabre « Karuma » a été\r\najouté au dossier de l'affaire.");
                s = s.Replace("We must take immediate action now...", "Nous devons agir sans plus tarder...");
                s = s.Replace("...to verify <E049><E003 10><E145 61 0><E118 61 0.5><E003 8><E025 2><E239>whether Seishiro Jigoku remains unharmed.", "...afin de vérifier <E049><E003 10><E145 61 0><E118 61 0.5><E003 8><E025 2><E239>si Seishiro Jigoku est toujours sain et sauf.");
                s = s.Replace("What?!<E049><E003 13>\r\n<E025 3>R-<E003 8>Remains unharmed?", "Quoi ?!<E049><E003 13>\r\n<E025 3>S-<E003 8>Sain et sauf ?");
                s = s.Replace("I agree.<E049><E003 6> <E145 112 1><E003 8><E025 2>That should be our first priority.", "Je suis d'accord.<E049><E003 6> <E145 112 1><E003 8><E025 2>Cela doit être notre priorité absolue.");
                s = s.Replace("It's recently come to my attention <E049><E003 10><E238><E025 3>that he hasn't been\r\nseen since yesterday.", "On m'a récemment informé <E049><E003 10><E238><E025 3>qu'il n'avait plus été vu\r\ndepuis hier.");
                s = s.Replace("H-<E049><E003 8>How did you...?", "C-<E049><E003 8>Comment savais-tu... ?");
                s = s.Replace("When a foreign dignitary invited to Great Britain goes\r\nmissing for twenty-four hours...", "Quand un dignitaire étranger invité en Grande-Bretagne vient à\r\ndisparaître pendant vingt-quatre heures...");
                s = s.Replace("...it's only natural <E049><E003 8><E333><E025 3>that <E006>the question of his safety<E005> should\r\narise.", "...il est tout naturel <E049><E003 8><E333><E025 3>que <E006>la question de sa sécurité<E005> vienne\r\nà se poser.");
                s = s.Replace("You don't mean to say...", "Tu ne veux tout de même pas dire...");
                s = s.Replace("...that you think Judge Jigoku<E049><E003 8> <E145 1 80><E118 1 1.1><E144 1><E332>may have been <E006>killed<E005>?!", "...que tu penses que le juge Jigoku<E049><E003 8> <E145 1 80><E118 1 1.1><E144 1><E332>pourrait avoir été <E006>tué<E005> ?!");
                s = s.Replace("The Reaper has more than one assassin at his disposal.", "Le Faucheur dispose de plus d'un assassin.");
                s = s.Replace("And he has the power and influence to give orders from\r\nthe inside of a prison cell.", "Et il a l'influence et le pouvoir nécessaires pour donner des ordres depuis\r\nl'intérieur d'une cellule de prison.");
                s = s.Replace("Isn't that right...<E049><E003 15><E346>Lord van Zieks?", "N'est-ce pas...<E049><E003 15><E346>Lord Van Peers ?");
                s = s.Replace("...If I were truly the Reaper, <E003 6>I'd be able to tell you.", "...Si j'étais véritablement le Faucheur, <E003 6>je serais en mesure de vous répondre.");
                s = s.Replace("Order!<E003 6> <E025 1>Order in court!<E003 6> <E025 2>Order!", "Silence !<E003 6> <E025 1>Du calme dans la salle !<E003 6> <E025 2>Silence !");
                s = s.Replace("We will take an emergency recess for thirty minutes.", "Nous allons suspendre la séance pour une pause d'urgence de trente minutes.");
                s = s.Replace("Now?", "Maintenant ?");
                s = s.Replace("Guests of the symposium have been told to maintain\r\nregular contact with the organisers' office.", "Les invités du colloque ont pour consigne de maintenir un\r\ncontact régulier avec le bureau des organisateurs.");
                s = s.Replace("If the man can't be located within half an hour...", "Si cet homme ne peut être localisé d'ici une demi-heure...");
                s = s.Replace("...we will have to assume <E006>the worst<E005>.", "...nous devrons nous résoudre au <E006>pire<E005>.");
                s = s.Replace("Oh no!<E049><E003 13>\r\n<E025 1>Not Judge Jigoku!", "Oh non !<E049><E003 13>\r\n<E025 1>Pas le juge Jigoku !");
                s = s.Replace("No one would want to kill a harmless Japanese man who'd\r\nonly just arrived in the country.", "Personne n'aurait d'intérêt à tuer un inoffensif Japonais qui vient\r\nà peine de débarquer dans ce pays.");
                s = s.Replace("Except, that is...", "À l'exception, bien sûr...");
                s = s.Replace("...for the Reaper, <E049><E003 10><E025 2>wanting to finish off a mark that slipped\r\nthrough the net ten years ago.", "...du Faucheur, <E049><E003 10><E025 2>désireux d'éliminer une cible qui lui avait\r\néchappé il y a dix ans.");
                s = s.Replace("I would have to agree.", "Je ne peux qu'abonder en ce sens.");
                s = s.Replace("Mr Naruhodo,<E049><E003 16> <E025 3>for the defence's sake...", "M. Naruhodo,<E049><E003 16> <E025 3>dans l'intérêt de la défense...");
                s = s.Replace("M-<E003 10>My Lord?", "V-<E003 10>Votre Honneur ?");
                s = s.Replace("...I sincerely hope we are successful.", "...j'espère sincèrement que nos recherches aboutiront.");
                s = s.Replace("If we're unable to confirm Mr Jigoku's healthy existence\r\nin the next thirty minutes, <E049><E003 8><E145 61 0><E118 61 0.5><E003 8><E239><E025 3>you will face grave difficulties.", "Si nous sommes incapables de confirmer que M. Jigoku est bien vivant\r\nd'ici trente minutes, <E049><E003 8><E145 61 0><E118 61 0.5><E003 8><E239><E025 3>votre position deviendra intenable.");
                s = s.Replace("Court is adjourned for thirty minutes!", "L'audience est suspendue pour trente minutes !");
                return s;
            };

            // [90] BB\script\output\_sce04_c103_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c103_0000_eng#2"] = (s) => {
                s = s.Replace("Kazuma-sama, <E049><E003 8>the Reaper's assassin...<E003 15>\r\n<E025 3>I feel as though I'm in a nightmare.", "Kazuma-sama, <E049><E003 8>l'assassin du Faucheur...<E003 15>\r\n<E025 3>J'ai l'impression de vivre un cauchemar éveillé.");
                s = s.Replace("I can hardly believe it either.<E003 12>\r\n<E025 3>But on the other hand...", "J'ai moi aussi beaucoup de peine à y croire.<E003 12>\r\n<E025 3>Mais d'un autre côté...");
                s = s.Replace("...Kazuma isn't in the habit of making up stories.", "...Kazuma n'est pas du genre à inventer des fables.");
                s = s.Replace("I have such a terrible sense of foreboding.", "J'ai un pressentiment si funeste.");
                s = s.Replace("If something awful has happened to Judge Jigoku...", "S'il est arrivé quelque chose d'horrible au juge Jigoku...");
                s = s.Replace("...then I feel as though things will only spiral further and\r\nfurther out of control.", "...alors j'ai le sentiment que la situation va dégénérer de manière\r\nincontrôlable.");
                s = s.Replace("(I felt it from the moment I stepped into the courthouse\r\nthis morning.)", "(Je l'ai senti dès le moment où j'ai posé le pied dans ce tribunal\r\nce matin.)");
                s = s.Replace("(That strange sensation <E003 10><E238>that we were careering towards\r\na foregone conclusion...)", "(Cette étrange sensation <E003 10><E238>que nous courions tout droit vers\r\nune issue inéluctable...)");
                s = s.Replace("Well, <E049><E003 10><E025 2>in the worst case, <E003 6>we might only have thirty\r\nminutes left.", "Eh bien, <E049><E003 10><E025 2>au pire des cas, <E003 6>il ne nous reste peut-être qu'une\r\ntrentaine de minutes.");
                s = s.Replace("Unfortunately though, <E003 8>I don't think there's anything we\r\ncan do but wait now.<E003 10> <E025 3>We're out of options.", "Malheureusement, <E003 8>je ne crois pas qu'il y ait autre chose à faire\r\nqu'attendre désormais.<E003 10> <E025 3>Nous sommes à court d'options.");
                s = s.Replace("Actually, <E049><E003 10><E025 2><E333>there may be one last hand we can play.", "En réalité, <E049><E003 10><E025 2><E333>il nous reste peut-être une toute dernière carte à jouer.");
                s = s.Replace("Or rather...<E049><E003 15><E025 3><E330>one last ear.", "Ou plutôt...<E049><E003 15><E025 3><E330>une dernière oreille.");
                s = s.Replace("Of course!", "Mais bien sûr !");
                s = s.Replace("The little Mr Sholmes doll <E145 9 1><E118 9 1.2>that Iris gave us!", "La petite poupée de M. Sholmes <E145 9 1><E118 9 1.2>qu'Iris nous a offerte !");
                s = s.Replace("If for some reason you completely run out of options in\r\nthe trial today...", "Si pour une raison ou une autre vous êtes complètement à court d'idées\r\npendant le procès aujourd'hui...");
                s = s.Replace("...then just pull this little Hurley's ears <E049><E003 4><E164 4 68 1 2 6 0 0 1><E139 4><E025 1>as hard as you\r\npossibly can!", "...alors tirez les oreilles de ce petit Hurley <E049><E003 4><E164 4 68 1 2 6 0 0 1><E139 4><E025 1>aussi fort que vous\r\nle pourrez !");
                return s;
            };

            // [91] BB\script\output\_sce04_c103_0010_eng#2
            entryTranslators[@"BB\script\output\_sce04_c103_0010_eng#2"] = (s) => {
                s = s.Replace("(Perhaps <E006>now<E007> is the time.)", "(C'est peut-être le <E006>moment<E007> rêvé.)");
                s = s.Replace("(What should I do?<E003 8><E060 0 151 1 0>\r\nPull <E006>Hareley<E007>'s ears <E003 8><E025 3>or not...)", "(Que dois-je faire ?<E003 8><E060 0 151 1 0>\r\nTirer les oreilles de <E006>Hurley<E007> <E003 8><E025 3>ou non...)");
                return s;
            };

            // [92] BB\script\output\_sce04_c103_0010_eng#3
            entryTranslators[@"BB\script\output\_sce04_c103_0010_eng#3"] = (s) => {
                s = s.Replace("Here goes then.<E049><E003 10> <E025 1>I'm going to do it!", "C'est parti, alors.<E049><E003 10> <E025 1>Je le fais !");
                s = s.Replace("Good luck, <E049><E003 8>Mr Naruhodo!", "Bonne chance, <E049><E003 8>M. Naruhodo !");
                s = s.Replace("No looking back...<E003 17>\r\n<E025 1><E346><E342><E092 1>HEEEAVE!!!", "Plus de retour en arrière possible...<E003 17>\r\n<E025 1><E346><E342><E092 1>HIIIIISSEZ !!!");
                s = s.Replace("OOOOOOOOOO<E338>OOW!", "OUUUUUUUUUU<E338>OUILLE !");
                s = s.Replace("That scream...<E049><E003 18><E145 9 16><E117 9 6><E025 1><E346>sounded like Mr Sholmes!", "Ce cri...<E049><E003 18><E145 9 16><E117 9 6><E025 1><E346>on aurait dit M. Sholmes !");
                s = s.Replace("M-<E003 8><E025 1><E335>Mr Sholmes?!<E003 16><E145 9 13>\r\n...Where are you?", "M-<E003 8><E025 1><E335>M. Sholmes ?!<E003 16><E145 9 13>\r\n...Où êtes-vous ?");
                s = s.Replace("Here, <E003 8>my dear fellow!<E003 12>\r\n<E025 1>Here!", "Ici, <E003 8>mon cher ami !<E003 12>\r\n<E025 1>Par ici !");
                s = s.Replace("It's...<E003 15><E025 1><E145 9 2><E046>it's the felt doll talking!", "C'est...<E003 15><E025 1><E145 9 2><E046>c'est la poupée de feutre qui parle !");
                return s;
            };

            // [93] BB\script\output\_sce04_c103_0010_eng#4
            entryTranslators[@"BB\script\output\_sce04_c103_0010_eng#4"] = (s) => {
                s = s.Replace("(This is one of Iris's inventions...<E003 8><E145 1 4><E003 10>\r\n<E025 1><E331>There's no telling what might happen.)", "(C'est une invention d'Iris...<E003 8><E145 1 4><E003 10>\r\n<E025 1><E331>Impossible de prédire ce qui pourrait se passer.)");
                s = s.Replace("(For all I know, <E003 10><E025 1><E239>it could cause a huge explosion!)", "(Pour ce que j'en sais, <E003 10><E025 1><E239>ça pourrait déclencher une explosion monumentale !)");
                s = s.Replace("I'm not sure you should be thinking like that,<E049><E003 6>\r\nMr Naruhodo.", "Je ne suis pas sûre que vous devriez avoir de telles pensées,<E049><E003 6>\r\nM. Naruhodo.");
                s = s.Replace("Compared to the trial ending immediately after this\r\nrecess, <E049><E003 8><E145 9 16><E003 8><E025 1><E345>a huge explosion might be preferable!", "Comparée à une fin de procès immédiate après cette\r\nsuspension, <E049><E003 8><E145 9 16><E003 8><E025 1><E345>une grosse explosion serait presque préférable !");
                s = s.Replace("I'm not sure you should be thinking like that,<E003 6> Miss Susato.", "Je ne suis pas sûr que vous devriez tenir ce genre de propos,<E003 6> mademoiselle Susato.");
                s = s.Replace("But I suppose you're right.<E003 10> <E025 3>If there was ever a time for\r\ntaking a <E145 9 15>risk, <E003 8><E346><E025 2>it's now!", "Mais j'imagine que vous avez raison.<E003 10> <E025 3>S'il y a bien un moment pour\r\nprendre un <E145 9 15>risque, <E003 8><E346><E025 2>c'est maintenant !");
                return s;
            };

            // [94] BB\script\output\_sce04_c104_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0000_eng#2"] = (s) => {
                s = s.Replace("Pull the ears again, Mr Naruhodo!<E049><E003 12>\r\n<E025 1><E335>As hard as you can!", "Tirez de nouveau sur les oreilles, M. Naruhodo !<E049><E003 12>\r\n<E025 1><E335>Aussi fort que possible !");
                s = s.Replace("Alright then.<E003 8> <E025 3>I'll put all my strength into it.<E003 15>\r\n<E025 1><E346><E342>HEEEEEEAVE!", "Entendu.<E003 8> <E025 3>Je vais y mettre toute mon énergie.<E003 15>\r\n<E025 1><E346><E342>HIIIIIIISSEZ !");
                s = s.Replace("OOOOOOOOOOOOW!<E003 30><E024>", "OUUUUUUUUUUUILLE !<E003 30><E024>");
                s = s.Replace("Please, <E003 4>my dear fellows!<E049><E003 12>\r\n<E341>You don't need to pull my ear off!", "Je vous en conjure, <E003 4>mes chers amis !<E049><E003 12>\r\n<E341>Ce n'est pas la peine de m'arracher le pavillon !");
                s = s.Replace("Mr Sholmes!<E003 12>\r\n<E025 2>Where, <E003 6>where are you?", "M. Sholmes !<E003 12>\r\n<E025 2>Où, <E003 6>où vous trouvez-vous ?");
                s = s.Replace("Myself and my trusty partner...", "Mon fidèle associé et moi-même...");
                s = s.Replace("...are presently in the first-class cabin area <E049><E003 8>of <E006>the SS\r\nGrouse<E005>.", "...sommes actuellement dans la zone des cabines de première classe <E049><E003 8>du <E006>SS\r\nGrouse<E005>.");
                s = s.Replace("The, <E003 8>the SS Grouse?", "Le... <E003 8>le SS Grouse ?");
                s = s.Replace("She left Dover last night, <E049><E003 8>after the final pieces of cargo\r\nwere loaded.", "Il a appareillé de Douvres hier soir, <E049><E003 8>après le chargement des dernières\r\nmarchandises.");
                s = s.Replace("We are currently docked at Dunkirk, <E049><E003 8>but due to be\r\nunderway again in half an hour.", "Nous sommes présentement amarrés à Dunkerque, <E049><E003 8>mais nous devons\r\nreprendre la mer dans une demi-heure.");
                s = s.Replace("You've...<E003 12><E025 1><E331>taken a ship to France?!", "Vous avez...<E003 12><E025 1><E331>pris un bateau pour la France ?!");
                s = s.Replace("Please, <E049><E003 8>even with my athletic prowess, <E049><E003 6>I would struggle\r\nto jump the Straits of Dover.", "Je vous en prie, <E049><E003 8>même avec mes prouesses athlétiques, <E049><E003 6>j'aurais peine\r\nà franchir le pas de Calais d'un bond.");
                s = s.Replace("After we left Baker Street last night, <E049><E003 8>we hurried by cab to\r\nthe station and by train to the port...", "Après avoir quitté Baker Street hier soir, <E049><E003 8>nous avons filé en fiacre\r\nvers la gare, puis pris le train pour le port...");
                s = s.Replace("...in order to board this vessel in time.", "...afin d'embarquer sur ce navire à temps.");
                s = s.Replace("So...<E003 12><E025 3>you mean...<E003 12><E025 1><E341>you'd already worked it out?", "Alors...<E003 12><E025 3>vous voulez dire...<E003 12><E025 1><E341>que vous aviez déjà tout déduit ?");
                s = s.Replace("That the steamship was <E003 10><E025 1><E332>where everything<E006> really took\r\nplace<E008>!", "Que ce vapeur était <E003 10><E025 1><E332>l'endroit où tout<E006> s'était réellement\r\npassé<E008> !");
                s = s.Replace("Mr Naruhodo...<E049><E003 12><E330><E149 2 0 0><E025 2>pray, <E049><E003 6>what is my name?", "M. Naruhodo...<E049><E003 12><E330><E149 2 0 0><E025 2>dites-moi, <E049><E003 6>quel est mon nom ?");
                s = s.Replace("Herlock Sholmes...<E003 12><E046><E025 1>world-famous great detective!", "Herlock Sholmes...<E003 12><E046><E025 1>le grand détective mondialement renommé !");
                s = s.Replace("Recited to perfection.<E049><E003 10> <E025 2>Well done.", "Récité à la perfection.<E049><E003 10> <E025 2>Bravo.");
                s = s.Replace("You're a genius, Mr Sholmes!<E049><E003 14> <E025 1><E045><E147 2 88><E149 2 0 0><E147 75 65>That's the only word for it! ", "Vous êtes un génie, M. Sholmes !<E049><E003 14> <E025 1><E045><E147 2 88><E149 2 0 0><E147 75 65>Il n'y a pas d'autre mot ! ");
                s = s.Replace("Ow <E003 2>ow <E003 2>ow <E003 2>ow <E003 2>ow!<E003 20><E024>", "Aïe <E003 2>aïe <E003 2>aïe <E003 2>aïe <E003 2>aïe !<E003 20><E024>");
                s = s.Replace("M-<E049><E003 8>Miss Susato!<E049><E003 12>\r\n<E341>Gently with this genius's ear, please!", "M-<E049><E003 8>Mademoiselle Susato !<E049><E003 12>\r\n<E341>Doucement avec l'oreille du génie, de grâce !");
                s = s.Replace("Oh my!<E003 15>\r\n<E356>I'm ever so sorry!", "Ciel !<E003 15>\r\n<E356>Je suis infiniment désolée !");
                return s;
            };

            // [95] BB\script\output\_sce04_c104_0000_eng#3
            entryTranslators[@"BB\script\output\_sce04_c104_0000_eng#3"] = (s) => {
                s = s.Replace("If I may, <E003 10>Sholmes...?", "Si vous me le permettez, <E003 10>Sholmes... ?");
                s = s.Replace("Ah, <E049><E003 6><E164 2 79 1 2 6 0 0 1><E139 2><E025 2>there you are, <E003 6>Mikotoba.", "Ah, <E049><E003 6><E164 2 79 1 2 6 0 0 1><E139 2><E025 2>vous voilà, <E003 6>Mikotoba.");
                s = s.Replace("You may remember that <E003 8><E341>it was in fact I who made the\r\nconnection to the SS Grouse.", "Vous vous souviendrez peut-être que <E003 8><E341>c'est en fait moi qui ai fait\r\nle lien avec le SS Grouse.");
                s = s.Replace("At Scotland Yard yesterday, <E003 6>when we examined that\r\nnotebook and <E145 2 64>I recalled my steamship ticket.", "À Scotland Yard hier, <E003 6>quand nous avons examiné ce\r\ncarnet et que <E145 2 64>je me suis rappelé mon billet de vapeur.");
                s = s.Replace("Ah <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>hah!<E049><E003 12>\r\n<E025 1>But of course it was, <E049><E003 8>my dear fellow!", "Ah <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>hah !<E049><E003 12>\r\n<E025 1>Mais bien sûr que oui, <E049><E003 8>mon cher ami !");
                s = s.Replace("And not once did I controvert that fact.<E049><E003 8> I merely had our\r\ncourt-bound companions utter my name.", "Et à aucun moment je n'ai contesté ce fait.<E049><E003 8> J'ai simplement laissé nos\r\nconfrères du tribunal déclamer mon nom.");
                s = s.Replace("Yes, <E003 8>you did, <E003 6>didn't you?", "Oui, <E003 8>c'est ce que vous avez fait, <E003 6>n'est-ce pas ?");
                s = s.Replace("We've just entered a recess.<E145 2 64><E149 2 0 0><E003 12> The trial resumes in thirty\r\nminutes from now.", "Le tribunal vient d'ordonner une suspension de séance.<E145 2 64><E149 2 0 0><E003 12> Le procès reprend\r\ndans trente minutes.");
                s = s.Replace("And if we're unable to present any new leads then,<E003 10> <E025 3><E341>I'm\r\nafraid to say...", "Et si nous sommes incapables de fournir de nouvelles pistes à ce moment-là,<E003 10> <E025 3><E341>j'ai bien\r\npeur que...");
                s = s.Replace("Do not fret, please.<E049><E003 8> It's for precisely that purpose that my\r\npartner and I have made this journey.", "Ne vous tracassez point, je vous prie.<E049><E003 8> C'est précisément pour cela que mon\r\nassocié et moi-même avons fait ce périple.");
                s = s.Replace("I have no doubt we shall have welcome news for you\r\nwithin the half hour.", "Je ne doute pas que nous aurons d'excellentes nouvelles pour vous\r\nd'ici une demi-heure.");
                s = s.Replace("Thank you, Mr Sholmes!<E003 12>\r\n<E025 1>That would be wonderful.", "Merci infiniment, M. Sholmes !<E003 12>\r\n<E025 1>Ce serait formidable.");
                s = s.Replace("Until later, then.", "À tout à l'heure, alors.");
                s = s.Replace("Yes!<E003 15> <E607><E147 2 88><E147 75 65><E149 2 0 0><E025 1>You'll be hearing from us if you're not in touch first.<E003 5><E061 0>", "Oui !<E003 15> <E607><E147 2 88><E147 75 65><E149 2 0 0><E025 1>Nous vous rappellerons si vous ne nous donnez pas de nouvelles !<E003 5><E061 0>");
                s = s.Replace("I shan't be hearing anything if you keep tugging my ear in\r\nthat mindless fashion!", "Je ne risque pas d'entendre grand-chose si vous continuez à me tirer l'oreille\r\navec une telle fougue inconsciente !");
                s = s.Replace("Whatever was the idea behind making a receiver\r\noperated in that way in the first place, <E003 4><E025 3>Sholmes?", "Quelle mouche a donc piqué la conception d'un récepteur fonctionnant\r\nde cette manière, <E003 4><E025 3>Sholmes ?");
                s = s.Replace("Why the deuce would I know?!<E049><E003 12>\r\n<E341>It's Iris's invention, <E049><E003 8>not mine.", "Comment diable le saurais-je ?!<E049><E003 12>\r\n<E341>C'est l'invention d'Iris, <E049><E003 8>pas la mienne.");
                s = s.Replace("Whilst I know how much you enjoy being the hero of the\r\nhour, <E003 4>Sholmes...", "Bien que je sache à quel point vous appréciez jouer les héros du\r\njour, <E003 4>Sholmes...");
                s = s.Replace("...we have but half that now<E003 8> before the Grouse puts to sea\r\nagain.", "...il ne nous reste qu'un quart d'heure<E003 8> avant que le Grouse ne reprenne\r\nla mer.");
                s = s.Replace("If we don't conclude our investigations rapidly, <E003 9>we shall\r\nfind ourselves in Naples before long.", "Si nous ne concluons pas promptement notre enquête, <E003 9>nous allons\r\nnous retrouver à Naples sous peu.");
                s = s.Replace("Hm...<E003 12>there are times, <E049><E003 4>Mikotoba, <E049><E003 8>when you make a\r\nsurprising amount of sense.", "Hm...<E003 12>il y a des moments, <E049><E003 4>Mikotoba, <E049><E003 8>où vous faites preuve\r\nd'un bon sens stupéfiant.");
                s = s.Replace("So, <E049><E003 8><E025 1><E164 2 79 1 2 8 1 1 1><E139 2>let us begin!", "Sur ce, <E049><E003 8><E025 1><E164 2 79 1 2 8 1 1 1><E139 2>au travail !");
                s = s.Replace("‘First-Class Cabin No. 2’...<E003 12>\r\n<E025 2>Yes, <E003 8>this is the one.", "« Cabine de première classe n° 2 »...<E003 12>\r\n<E025 2>Oui, <E003 8>c'est bien celle-ci.");
                s = s.Replace("But I don't believe an investigation of the cabin <E049><E003 10><E333>is going to\r\nbe plain sailing.", "Mais je ne pense pas qu'inspecter cette cabine <E049><E003 10><E333>soit une simple\r\npartie de plaisir.");
                s = s.Replace("(That crewman standing in front of the door <E003 6><E025 3>is an\r\nangry-looking fellow.)", "(Ce marin en faction devant la porte <E003 6><E025 3>a une mine fort\r\npatibulaire.)");
                s = s.Replace("Why you are loitering here?<E049><E003 12>\r\nWho are you?", "Pourquoi vous traîner ici ?<E049><E003 12>\r\nQui vous êtes ?");
                s = s.Replace("My dear fellow, <E049><E003 10><E149 51 3 0><E330>do you not recognise a world-famous\r\ngreat detective when you see one?", "Mon brave, <E049><E003 10><E149 51 3 0><E330>ne reconnaissez-vous donc pas un grand détective\r\nde renommée mondiale quand vous en voyez un ?");
                s = s.Replace("The question really ought to be, <E049><E003 8><E025 3>who are you?", "La question devrait plutôt être : <E049><E003 8><E025 3>qui êtes-vous ?");
                s = s.Replace("Do you not recognise world-travelling great sailor<E049><E003 10>\r\n<E332>Tchikin Strogenov when you see?", "Vous ne reconnaissez pas grand marin du monde entier<E049><E003 10>\r\n<E332>Tchikin Strogenov quand vous voyez ?");
                s = s.Replace("Great detective?<E049><E003 15>\r\n<E025 1><E331>Hah!<E049><E003 12> <E341>I don't think so.", "Grand détective ?<E049><E003 15>\r\n<E025 1><E331>Ha !<E049><E003 12> <E341>Moi pas croire ça du tout.");
                return s;
            };

            // [96] BB\script\output\_sce04_c104_0000_eng#4
            entryTranslators[@"BB\script\output\_sce04_c104_0000_eng#4"] = (s) => {
                s = s.Replace("Do you see that, <E049><E003 8>Mikotoba?", "Voyez-vous cela, <E049><E003 8>Mikotoba ?");
                s = s.Replace("It would appear that this man <E049><E003 10><E239><E025 2>is <E006>a devoted follower<E005> of\r\nmine.", "Il semblerait que cet homme <E049><E003 10><E239><E025 2>soit l'un de mes <E006>fervents admirateurs<E005>.");
                s = s.Replace("Goodness me!<E003 15> <E025 2>Is, <E003 8>is that a tattoo?<E003 15>\r\n<E025 1><E332>That says ‘<E006>Sholmes<E005>’?!", "Grand Dieu !<E003 15> <E025 2>C'est... <E003 8>est-ce un tatouage ?<E003 15>\r\n<E025 1><E332>Il y est écrit « <E006>Sholmes<E005> » ?!");
                s = s.Replace("...I must say, <E003 8>whilst such <E006>adoration<E005> is flattering,<E003 6> naturally,<E003 10>\r\nit does leave me a little cold.", "...Je dois avouer que, bien qu'une telle <E006>dévotion<E005> soit flatteuse,<E003 6> naturellement,<E003 10>\r\nelle me laisse quelque peu perplexe.");
                s = s.Replace("What are you talking about?<E049><E003 15>\r\n<E607>Leave!<E003 15> Now!", "De quoi vous parlez ?<E049><E003 15>\r\n<E607>Partez !<E003 15> Maintenant !");
                s = s.Replace("How distressing.<E049><E003 10> <E025 2>My loyal devotee knows me only by\r\nname and not by appearance.", "Comme c'est affligeant.<E049><E003 10> <E025 2>Mon loyal dévot ne me connaît que de nom\r\net non de visage.");
                s = s.Replace("And yet <E049><E003 4><E164 2 79 1 2 8 0 1 1><E149 2 3 0><E139 2><E025 1>I already know a great deal about you, sir.", "Et pourtant, <E049><E003 4><E164 2 79 1 2 8 0 1 1><E149 2 3 0><E139 2><E025 1>j'en sais déjà long sur votre compte, monsieur.");
                s = s.Replace("You have a brother, <E003 6>I believe.", "Vous avez un frère, <E003 6>me semble-t-il.");
                s = s.Replace("Like yourself, <E003 8>he's a shipman.", "Tout comme vous, <E003 8>c'est un marin.");
                s = s.Replace("Currently travelling the world aboard a Russian\r\nsteamship, <E003 6>in fact.", "Qui parcourt actuellement le monde à bord d'un vapeur\r\nrusse, <E003 6>en réalité.");
                s = s.Replace("H-<E049><E003 15><E025 1><E045>How could you know this?!", "C-<E049><E003 15><E025 1><E045>Comment vous pouvez savoir ça ?!");
                s = s.Replace("Elementary, <E049><E003 8>my dear Mikotoba.", "Élémentaire, <E049><E003 8>mon cher Mikotoba.");
                s = s.Replace("...I'm sure it was.", "...Je n'en doute absolument pas.");
                s = s.Replace("Three days ago, <E003 8>I was bound for London aboard this ship,<E003 6>\r\nyou see.", "Il y a trois jours, <E003 8>je faisais route vers Londres à bord de ce navire,<E003 6>\r\nvoyez-vous.");
                s = s.Replace("We're looking for one of my fellow passengers.<E003 10>\r\nA man by the name of Jigoku.", "Nous recherchons l'un de mes compagnons de traversée.<E003 10>\r\nUn homme du nom de Jigoku.");
                return s;
            };

            // [97] BB\script\output\_sce04_c104_0000_eng#5
            entryTranslators[@"BB\script\output\_sce04_c104_0000_eng#5"] = (s) => {
                s = s.Replace("There is no one with this name on board.", "Y a personne de ce nom-là à bord.");
                s = s.Replace("But we know that he purchased a ticket for passage.", "Mais nous savons pertinemment qu'il a acheté un billet de passage.");
                s = s.Replace("Ah, <E049><E003 8>you mean Eastern man.<E049><E003 12>\r\nHe left ship two hours ago.", "Ah, <E049><E003 8>vous voulez dire homme d'Orient.<E049><E003 12>\r\nLui a quitté navire il y a deux heures.");
                s = s.Replace("Here at Dunkirk.<E049><E003 10> He said something about emergency,<E049><E003 8> I\r\nthink.", "Ici à Dunkerque.<E049><E003 10> Lui a parlé d'une urgence,<E049><E003 8> je\r\ncrois.");
                s = s.Replace("What?!<E003 15>\r\n<E025 2>Are, <E003 8><E341>are you sure?", "Quoi ?!<E003 15>\r\n<E025 2>En... <E003 8><E341>en êtes-vous certain ?");
                s = s.Replace("(So Seishiro's realised that we're after him, <E003 6>has he?)", "(Seishiro a donc compris que nous étions à ses trousses... ?)");
                s = s.Replace("His cabin is the one behind you.<E049><E003 10>\r\nWe should like to investigate, please.", "Sa cabine est celle juste derrière vous.<E049><E003 10>\r\nNous souhaiterions l'inspecter, s'il vous plaît.");
                s = s.Replace("No!<E049><E003 15> <E341>I have orders not to let even mouse inside!", "Niet !<E049><E003 15> <E341>Moi avoir ordre de pas laisser entrer même une souris !");
                s = s.Replace("Mikotoba, <E049><E003 10>be a good man and draw this sailor's attention\r\naway, <E049><E003 6>would you?", "Mikotoba, <E049><E003 10>soyez brave et détournez l'attention de ce marin,\r\n<E049><E003 6>voudriez-vous ?");
                s = s.Replace("Make up some excuse so that he leaves the area.", "Inventez un prétexte pour qu'il s'éloigne d'ici.");
                s = s.Replace("Doesn't great detective see...?", "Grand détective pas voir... ?");
                s = s.Replace("That even sailors have ears.<E049><E003 12> <E333>Both left and right.", "Que même les marins ont des oreilles.<E049><E003 12> <E333>Celle de gauche et celle de droite.");
                s = s.Replace("Curses!<E003 16> The plan is ruined!", "Peste !<E003 16> Le plan est fichu !");
                s = s.Replace("...And you have only yourself to blame, <E003 4>I'm afraid,\r\n<E025 3>Sholmes.", "...Et vous ne pouvez vous en prendre qu'à vous-même, j'en ai peur,\r\n<E025 3>Sholmes.");
                s = s.Replace("Forget it.<E049><E003 10> Cabin door is locked.", "Oubliez.<E049><E003 10> Porte de cabine est verrouillée.");
                s = s.Replace("Even if I am not here, <E049><E003 8>you cannot get inside.", "Même si moi pas là, <E049><E003 8>vous pas pouvoir entrer.");
                s = s.Replace("...I'm sure you haven't forgotten my ‘special talent’<E003 10> <E025 3>have\r\nyou?", "...je suis certain que vous n'avez pas oublié mon « talent particulier »,<E003 10> <E025 3>n'est-ce\r\npas ?");
                s = s.Replace("(Opening any lock?)", "(Ouvrir n'importe quelle serrure ?)");
                s = s.Replace("...Within a mere five seconds.", "...En l'espace de cinq petites secondes.");
                s = s.Replace("So if you'd be so kind as to afford me the requisite time,<E003 8>\r\nold friend, <E049><E003 6><E025 2><E145 2 64><E003 10>in your typically accommodating manner.", "Si vous vouliez bien m'accorder ce court laps de temps requis,<E003 8>\r\nmon vieil ami, <E049><E003 6><E025 2><E145 2 64><E003 10>avec votre complaisance légendaire.");
                s = s.Replace("How could I refuse such a typically unappealing request,<E003 10>\r\n<E025 3>old friend?", "Comment pourrais-je refuser une requête aussi typiquement déraisonnable,<E003 10>\r\n<E025 3>mon vieil ami ?");
                s = s.Replace("(So I need to distract that burly sailor for five seconds, <E003 8>\r\n<E025 3>do I?)", "(Je dois donc distraire ce robuste gaillard pendant cinq secondes, <E003 8>\r\n<E025 3>c'est bien cela ?)");
                s = s.Replace("Good man!<E049><E003 12> <E025 3>So...<E049><E003 10><E025 1><E164 2 70 1 2 8 0 1 1><E149 2 0 0><E139 2>the game is afoot!", "Parfait !<E049><E003 12> <E025 3>Alors...<E049><E003 10><E025 1><E164 2 70 1 2 8 0 1 1><E149 2 0 0><E139 2>la partie est lancée !");
                return s;
            };

            // [98] BB\script\output\_sce04_c104_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0020_eng#2"] = (s) => {
                s = s.Replace("3rd November\r\n<CNTR><E003 5>SS Grouse, First-Class Cabin No. 2", "3 novembre\r\n<CNTR><E003 5>SS Grouse, cabine de première classe n° 2");
                s = s.Replace("Good gracious...", "Mon Dieu...");
                s = s.Replace("It would appear <E049><E003 10><E025 2>that the occupant of this cabin did\r\nindeed disembark rather hurriedly.", "Il semblerait <E049><E003 10><E025 2>que l'occupant de cette cabine ait en\r\neffet débarqué avec une hâte singulière.");
                s = s.Replace("Those clothes on the floor there...<E003 12>\r\n<E330><E025 2>They're Seishiro's, <E003 8>without question.", "Ces vêtements sur le plancher, là...<E003 12>\r\n<E330><E025 2>Ce sont ceux de Seishiro, <E003 8>sans le moindre doute.");
                s = s.Replace("Well, <E003 8><E025 2>it seems we are just a little too late.", "Eh bien, <E003 8><E025 2>il semble que nous arrivions un tout petit peu trop tard.");
                s = s.Replace("Yes, <E003 10><E025 2>by about two hours.", "Oui, <E003 10><E025 2>d'environ deux heures.");
                s = s.Replace("Still, <E049><E003 10><E025 2>whilst we're here, <E049><E003 6>we should investigate thoroughly.", "Néanmoins, <E049><E003 10><E025 2>puisque nous y sommes, <E049><E003 6>nous devrions fouiller minutieusement.");
                s = s.Replace("There may well be two hours' worth of clues to find in\r\nhere.", "Il pourrait fort bien y avoir deux heures d'indices précieux à glaner ici.");
                s = s.Replace("But <E145 2 64>that burly crewman may return at any moment,<E003 6><E025 3>\r\nSholmes.", "Mais <E145 2 64>ce colossal marin peut faire irruption à tout moment,<E003 6><E025 3>\r\nSholmes.");
                s = s.Replace("Indeed he may.<E049><E003 8>\r\n<E164 2 71 1 2 6 0 0 1><E139 2><E025 1>...Which makes this all the more thrilling!", "C'est fort possible, en vérité.<E049><E003 8>\r\n<E164 2 71 1 2 6 0 0 1><E139 2><E025 1>...Ce qui rend l'aventure d'autant plus grisante !");
                return s;
            };

            // [99] BB\script\output\_sce04_c104_0040_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0040_eng#2"] = (s) => {
                s = s.Replace("You!<E049><E003 18> <E341><E025 1>You are still here?!", "Vous !<E049><E003 18> <E341><E025 1>Vous encore là ?!");
                s = s.Replace("Ah, <E003 8>Able Seaman Strogenov.<E003 10>\r\nHello again.", "Ah, <E003 8>matelot breveté Strogenov.<E003 10>\r\nRebonjour.");
                s = s.Replace("...I was beginning to think <E049><E003 12><E330><E025 2>you'd never materialise.", "...Je commençais à craindre <E049><E003 12><E330><E025 2>que vous ne daigniez jamais vous matérialiser.");
                s = s.Replace("Eh?<E049><E003 12>\r\n<E025 2>You...<E003 10>you are waiting for me?", "Hein ?<E049><E003 12>\r\n<E025 2>Vous... <E003 10>vous attendre moi ?");
                s = s.Replace("Of course!<E049><E003 12> <E338><E342>I was expecting you to burst in with a hearty\r\nRussian profanity far sooner.", "Mais évidemment !<E049><E003 12> <E338><E342>Je m'attendais à ce que vous fassiez irruption bien plus tôt avec un juron bien russe.");
                s = s.Replace("I was in trouble with captain because of trick you play\r\nbefore!", "Moi avoir eu des ennuis avec capitaine à cause de tour de passe-passe de vous !");
                s = s.Replace("(Poor, innocent Tchikin...)", "(Pauvre et candide Tchikin...)");
                s = s.Replace("It is all your fault!", "Tout est votre faute !");
                s = s.Replace("Ship is leaving port soon.<E049><E003 10> <E025 1>Get off!<E049><E003 12> Now!", "Navire quitte le port bientôt.<E049><E003 10> <E025 1>Descendez !<E049><E003 12> Tout de suite !");
                s = s.Replace("Of course, <E003 8>we shall disembark presently, my dear fellow.<E049><E003 12>\r\n<E145 2 67><E025 3>But first...", "Bien entendu, <E003 8>nous allons débarquer incessamment, mon cher.<E049><E003 12>\r\n<E145 2 67><E025 3>Mais avant cela...");
                s = s.Replace("...there is something that must be done.", "...il y a une chose qui doit impérativement être faite.");
                s = s.Replace("What are you talking about?", "De quoi vous parlez encore ?");
                s = s.Replace("Why naturally...", "Mais naturellement...");
                s = s.Replace("...the debunking of your <E006>deceit<E005> <E049><E003 8>and the baring of <E006>the truth<E005>!", "...dissiper votre <E006>supercherie<E005> <E049><E003 8>et faire éclater <E006>la vérité<E005> !");
                s = s.Replace("Kakoy?!", "Kakoy ?!");
                s = s.Replace("I'm afraid <E049><E003 10><E145 2 64>I see through your lies.", "J'ai bien peur <E049><E003 10><E145 2 64>de voir clair à travers vos mensonges.");
                s = s.Replace("For one thing...", "D'une part...");
                s = s.Replace("...Mr Jigoku has <E006>not yet left<E005> this vessel at all.", "...M. Jigoku n'a <E006>absolument pas quitté<E005> ce navire.");
                s = s.Replace("And for another, <E049><E003 8>my dear Seaman Strogenov...", "Et d'autre part, <E049><E003 8>mon cher matelot Strogenov...");
                s = s.Replace("...<E006>you know<E005> exactly where the man is<E003 6> even as we speak,<E049><E003 10>\r\ndon't you?", "...<E006>vous savez<E005> exactement où se terre cet homme <E003 6>à l'instant même où nous parlons,<E049><E003 10>\r\nn'est-ce pas ?");
                s = s.Replace("How, <E049><E003 10>how can you...?", "Comment... <E049><E003 10>comment vous pouvez... ?");
                s = s.Replace("Good gracious, Sholmes!<E003 12> You mean...<E003 12><E025 1><E335>you've worked it out?<E003 16>\r\n<E332><E025 1>All of it?!", "Grand Dieu, Sholmes !<E003 12> Vous voulez dire...<E003 12><E025 1><E335>vous avez tout compris ?<E003 16>\r\n<E332><E025 1>L'intégralité ?!");
                s = s.Replace("It's really been too long, <E049><E003 8>hasn't it, old friend?<E049><E003 14>\r\n<E025 2>Ten years, <E049><E003 8><E025 1>no less!", "Cela faisait vraiment trop longtemps, <E049><E003 8>n'est-ce pas, mon vieil ami ?<E049><E003 14>\r\n<E025 2>Dix ans, <E049><E003 8><E025 1>pas moins !");
                s = s.Replace("So...<E003 12>would you care to join me for a dance...<E003 12><E330>of my\r\ninimitable logic and reasoning?", "Alors...<E003 12>me feriez-vous l'honneur de m'accompagner pour une danse...<E003 12><E330>de mon\r\ninimitable logique et déduction ?");
                s = s.Replace("Nothing would please me more!", "Rien ne pourrait me faire plus plaisir !");
                return s;
            };

        }
    }
}
