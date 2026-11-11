using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart4() {
            // [136] BB\script\output\_macro03_eng#14
            entryTranslators[@"BB\script\output\_macro03_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("(Says the man merrily dishing out penalties...)", "(Dit l'homme qui distribue gaiement les pénalités...)");
                return s;
            };

            // [137] BB\script\output\_macro03_eng#15
            entryTranslators[@"BB\script\output\_macro03_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à noter...)");
                return s;
            };

            // [138] BB\script\output\_macro03_eng#16
            entryTranslators[@"BB\script\output\_macro03_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("I can't find anything out of place.", "Je ne trouve rien d'anormal.");
                return s;
            };

            // [139] BB\script\output\_macro03_eng#17
            entryTranslators[@"BB\script\output\_macro03_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("Well, Miss Venus?!<E049><E003 10>\r\n<E025 2>What do you say?", "Alors, Mlle Venus ?!<E049><E003 10>\r\n<E025 2>Qu'avez-vous à dire ?");
                s = s.Replace("I say <E049><E003 12><E025 2><E333>that'll be six 'undred pennies.", "J'dis <E049><E003 12><E025 2><E333>qu'ça f'ra six cents pennies.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("That's my banter on the street whenever anyone comes\r\nalong.", "C'est c'que j'débite dans la rue à chaque fois qu'quelqu'un\r\npasse.");
                s = s.Replace("W-<E003 8>Well...<E003 10><E025 2>this isn't Fresno Street.", "E-<E003 8>Eh bien...<E003 10><E025 2>on n'est pas sur Fresno Street ici.");
                s = s.Replace("Tsk!<E049><E003 16> Miser!<E049><E339><E086 6 12><E342><E003 10>", "Pfft !<E049><E003 16> Radin !<E049><E339><E086 6 12><E342><E003 10>");
                return s;
            };

            // [140] BB\script\output\_macro03_eng#18
            entryTranslators[@"BB\script\output\_macro03_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("Mr Gossip!<E049><E003 10> <E025 2>Do you have something to say?", "M. Ragot !<E049><E003 10> <E025 2>Avez-vous quelque chose à dire ?");
                s = s.Replace("Mr Boone!<E049><E003 10> <E025 2>Do you have something to say?", "M. Boone !<E049><E003 10> <E025 2>Avez-vous quelque chose à dire ?");
                s = s.Replace("I do as it happens!<E049><E003 12> Your timing's perfect.", "Il s'trouve que oui !<E049><E003 12> Vous tombez à pic !");
                s = s.Replace("I've just got wind of a juicy tale that'll be right up your\r\nsnicket.", "J'viens d'avoir vent d'un ragot croustillant qui va vous plaire\r\nà coup sûr.");
                s = s.Replace("You don't want to let this one slip by, <E049><E003 6>I tell ya.<E049><E003 12>\r\n<E025 2>And sixpence is all I ask...", "Vous voulez pas laisser passer ça, <E049><E003 6>j'vous l'dis.<E049><E003 12>\r\n<E025 2>Et six pence, c'est tout c'que j'demande...");
                s = s.Replace("...Maybe <E003 8><E025 2>try Prosecutor Asogi instead.", "...Vous devriez <E003 8><E025 2>peut-être essayer avec le procureur Asogi.");
                s = s.Replace("I don't want your gossip, <E049><E003 8><E025 3>Ryunosuke Naruhodo.", "Je ne veux pas de vos ragots, <E049><E003 8><E025 3>Ryunosuke Naruhodo.");
                return s;
            };

            // [141] BB\script\output\_macro03_eng#19
            entryTranslators[@"BB\script\output\_macro03_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("Mr Sandwich!<E049><E003 10> <E025 2>Do you perhaps have something to fill us in\r\nwith?", "M. Sandwich !<E049><E003 10> <E025 2>Auriez-vous de quoi nous mettre sous la dent ?");
                s = s.Replace("A w-<E003 6>wise philosopher once said that p-<E003 6>people are nothing\r\nmore than mindless signposts.", "Un s-<E003 6>sage philosophe a dit un jour que les h-<E003 6>hommes ne sont\r\nrien de plus que des pancartes écérébrées.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Which means...", "Ce qui veut dire...");
                s = s.Replace("...that signposts are n-<E003 6>nothing more than mindless\r\npeople...<E003 8>if you think about it.", "...que les pancartes ne s-<E003 6>sont rien de plus que des hommes\r\nécérébrés...<E003 8>si l'on y réfléchit bien.");
                s = s.Replace("Perhaps mind less about philosophy and mind more\r\nabout the proceedings?", "Peut-être devriez-vous songer moins à la philosophie et\r\nplus aux débats ?");
                return s;
            };

            // [142] BB\script\output\_macro03_eng#20
            entryTranslators[@"BB\script\output\_macro03_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rousseau!<E003 10>\r\nIs something wrong?", "M. de Rousseau !<E003 10>\r\nQuelque chose ne va pas ?");
                s = s.Replace("I was just considering something.", "J'étais en train de réfléchir à quelque chose.");
                s = s.Replace("About the testimony?<E049><E003 10>\r\nDid something that was just said jar with you?", "À propos du témoignage ?<E049><E003 10>\r\nUne parole prononcée vous a fait tiquer ?");
                s = s.Replace("Non.<E049><E003 12> <E025 2><E330>I was considering my next cunning plan.", "Non.<E049><E003 12> <E025 2><E330>Je peaufinais mon prochain coup de maître.");
                s = s.Replace("Fantastico, capo!<E049><E003 14><E025 1><E346> The Hairlarious Brothers are-a gonna be\r\nback in action, <E003 6><E025 2>ay?", "Fantastico, capo !<E049><E003 14><E025 1><E346> Les Frères Toupet vont r'prendre du\r\nservice, <E003 6><E025 2>hein ?");
                s = s.Replace("I sink my next enterprise will be an exclusive club\r\ncalled...<E003 10><E025 3><E043>ze Four-Eyed League!", "Je crois que ma prochaine entreprise sera un club très fermé\r\nappelé...<E003 10><E025 3><E043>la Ligue des Binoclards !");
                return s;
            };

            // [143] BB\script\output\_macro03_eng#21
            entryTranslators[@"BB\script\output\_macro03_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("...Kindly discuss your upcoming criminal activities once\r\nyou're back in your cell.", "...Ayez l'obligeance de discuter de vos futures activités\r\ncriminelles une fois de retour dans votre cellule.");
                return s;
            };

            // [144] BB\script\output\_macro03_eng#22
            entryTranslators[@"BB\script\output\_macro03_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("...Kindly discuss your upcoming criminal activities once\r\nyou're back in your cell.", "...Ayez l'obligeance de discuter de vos futures activités\r\ncriminelles une fois de retour dans votre cellule.");
                return s;
            };

            // [145] BB\script\output\_macro03_eng#23
            entryTranslators[@"BB\script\output\_macro03_eng#23"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rossi!<E049><E003 10>\r\nDo you have something to say?", "M. de Rossi !<E049><E003 10>\r\nAvez-vous quelque chose à dire ?");
                s = s.Replace("Che?<E003 8> What?", "Che ?<E003 8> Quoi ?");
                s = s.Replace("You looked as though you were thinking something...<E003 10>\r\n<E341>whilst eating a mouthful of pasta.", "On aurait dit que vous pensiez à quelque chose...<E003 10>\r\n<E341>tout en avalant une bouchée de pâtes.");
                s = s.Replace("Ah, <E003 8>si.<E003 10> <E025 2>I was-a thinking...", "Ah, <E003 8>si.<E003 10> <E025 2>J'me disais...");
                s = s.Replace("...perhaps my hair is this-a colour because I eat too much\r\nBolognese sauce.", "...qu'mes cheveux sont peut-être de cette couleur parce que\r\nj'mange trop d'sauce bolognaise.");
                return s;
            };

            // [146] BB\script\output\_macro03_eng#24
            entryTranslators[@"BB\script\output\_macro03_eng#24"] = (en) => {
                string s = en;
                s = s.Replace("...No comment.", "...Sans commentaire.");
                return s;
            };

            // [147] BB\script\output\_macro03_eng#25
            entryTranslators[@"BB\script\output\_macro03_eng#25"] = (en) => {
                string s = en;
                s = s.Replace("...No comment.", "...Sans commentaire.");
                return s;
            };

            // [148] BB\script\output\_macro03_eng#88
            entryTranslators[@"BB\script\output\_macro03_eng#88"] = (en) => {
                string s = en;
                s = s.Replace("Ah!<E003 12> <E025 2>There are some black <E006>marks<E005> here, <E003 6>look.", "Ah !<E003 12> <E025 2>Il y a des <E006>marques<E005> noires ici, <E003 6>regardez.");
                s = s.Replace("Yes, <E003 6>they...<E003 10><E025 2>look like some sort of <E006>scorch marks<E005>.", "Oui, <E003 6>on dirait...<E003 10><E025 2>une sorte de <E006>traces de brûlure<E005>.");
                s = s.Replace("So perhaps the bullet struck the candle here,<E003 6> do you\r\nthink?", "Se pourrait-il que la balle ait touché la bougie ici,<E003 6> à\r\nvotre avis ?");
                s = s.Replace("It's only this one candle that's been cracked in half,<E003 6> it\r\nseems.", "Il semble qu'il n'y ait que cette bougie qui ait été brisée en\r\ndeux.");
                s = s.Replace("Yes, <E003 8><E025 2>I think you might be right.", "Oui, <E003 8><E025 2>je crois que vous avez raison.");
                s = s.Replace("Firearms are rarely used by criminals in Japan...", "Les criminels utilisent rarement des armes à feu au Japon...");
                s = s.Replace("...so I'm afraid <E003 6><E025 3><E341>I'm not particularly knowledgeable about\r\nthem.", "...alors je crains de <E003 6><E025 3><E341>ne pas être très calée dans ce domaine.");
                return s;
            };

            // [149] BB\script\output\_macro03_eng#90
            entryTranslators[@"BB\script\output\_macro03_eng#90"] = (en) => {
                string s = en;
                s = s.Replace("So the candle was used as a sort of timer device to set off\r\nthe firecrackers...", "La bougie servait donc de détonateur à retardement pour allumer\r\nles pétards...");
                s = s.Replace("That's a really ingenious idea...<E003 10>though obviously it's a\r\nshame it was used for such a wicked purpose.", "C'est une idée fort ingénieuse...<E003 10> bien qu'il soit regrettable\r\nqu'elle ait servi à un dessein aussi néfaste.");
                s = s.Replace("I wonder if there aren't some more positive uses for a\r\ntimer device such as that...", "Je me demande s'il n'y aurait pas des applications plus\r\npositives pour un tel mécanisme à retardement...");
                s = s.Replace("Ah, <E003 8>I have the perfect application!", "Ah, <E003 8>j'ai l'application idéale !");
                s = s.Replace("It would be wonderful way of waking you in the\r\nmornings, <E003 6>Mr Naruhodo.", "Ce serait une merveilleuse façon de vous réveiller le matin,\r\n<E003 6>M. Naruhodo.");
                s = s.Replace("...I think I'd prefer that you continue to wake me in\r\nperson, <E003 8><E025 3>if it's all the same to you.", "...Je crois que je préfère encore que vous me réveilliez en\r\npersonne, <E003 8><E025 3>si cela ne vous dérange pas.");
                return s;
            };

            // [150] BB\script\output\_macro03_eng#91
            entryTranslators[@"BB\script\output\_macro03_eng#91"] = (en) => {
                string s = en;
                s = s.Replace("Look at this dark stain here.<E003 10>\r\n<E025 3>Do you think...?", "Regardez cette tache sombre ici.<E003 10>\r\n<E025 3>Pensez-vous... ?");
                s = s.Replace("Yes, <E003 8>I'm afraid so.<E003 12>\r\n<E330>I think it's <E006>blood<E005>.", "Oui, <E003 8>j'en ai bien peur.<E003 12>\r\n<E330>Je crains que ce ne soit du <E006>sang<E005>.");
                s = s.Replace("Ugh, <E003 10>I knew you were going to say that.<E003 12>\r\n<E025 3><E341>So that presumably means...", "Ouh, <E003 10>je savais que vous alliez dire ça.<E003 12>\r\n<E025 3><E341>Donc cela signifie sans doute...");
                s = s.Replace("...That this was present at <E006>the scene<E005> <E003 8><E025 3>when Inspector\r\nGregson was killed.", "...Que ceci se trouvait sur <E006>les lieux<E005> <E003 8><E025 3>lorsque l'inspecteur\r\nGregson a été tué.");
                s = s.Replace("It's the most logical conclusion, <E003 6><E025 3>yes.", "C'est la conclusion la plus logique, <E003 6><E025 3>oui.");
                s = s.Replace("To think Gina's been carrying this around with her...", "Quand on pense que Gina transportait ça avec elle...");
                s = s.Replace("(If you didn't know any better, <E003 8>I suppose it does look like a\r\ngrease stain from all the fish and chips...)", "(Si on ne savait pas, <E003 8>j'imagine qu'on pourrait la prendre pour une\r\ntache de graisse due au fish and chips...)");
                return s;
            };

            // [151] BB\script\output\_macro03_eng#92
            entryTranslators[@"BB\script\output\_macro03_eng#92"] = (en) => {
                string s = en;
                s = s.Replace("Look, <E003 14><E341><E338>there's something inside!", "Regardez, <E003 14><E341><E338>il y a quelque chose à l'intérieur !");
                s = s.Replace("Ooh, <E003 8>let's see...", "Oh, <E003 8>voyons voir...");
                s = s.Replace("It appears to be <E006>a passport<E005>...<E003 12><E025 2>authorising him to travel\r\noverseas.", "Il semble que ce soit <E006>un passeport<E005>...<E003 12><E025 2>l'autorisant à voyager\r\nà l'étranger.");
                s = s.Replace("Was Inspector Gregson about to go on a trip abroad, then?", "L'inspecteur Gregson s'apprêtait-il donc à partir à l'étranger ?");
                s = s.Replace("Perhaps the date of departure might tell us something.<E003 10>\r\n<E025 3>That was...", "Peut-être que la date de départ pourrait nous éclairer.<E003 10>\r\n<E025 3>C'était le...");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("What is it?", "Qu'y a-t-il ?");
                s = s.Replace("It was for travel on 31st October!<E003 15>\r\n<E335><E025 1>Just <E006>one day before<E005> the incident!", "C'était pour voyager le 31 octobre !<E003 15>\r\n<E335><E025 1>Soit à peine <E006>un jour avant<E005> le drame !");
                s = s.Replace("What?<E003 12> <E045><E025 2>Really?!", "Quoi ?<E003 12> <E045><E025 2>Vraiment ?!");
                return s;
            };

            // [152] BB\script\output\_macro03_eng#93
            entryTranslators[@"BB\script\output\_macro03_eng#93"] = (en) => {
                string s = en;
                s = s.Replace("(Gregson went to France the day before his body was\r\ndiscovered...?)", "(Gregson s'est rendu en France la veille du jour où son corps\r\na été découvert... ?)");
                return s;
            };

            // [153] BB\script\output\_macro03_eng#94
            entryTranslators[@"BB\script\output\_macro03_eng#94"] = (en) => {
                string s = en;
                s = s.Replace("31st October...<E003 12> So this passport is for the day before\r\nGregson's body was found.", "Le 31 octobre...<E003 12> Ce passeport date donc de la veille du jour où\r\nle corps de Gregson a été découvert.");
                s = s.Replace("He needed this document for his trip to France.", "Il avait besoin de ce document pour son voyage en France.");
                s = s.Replace("And when it says <E003 10><E025 3>‘permission for the applicant and one\r\nadditional person to travel’...", "Et quand il est écrit <E003 10><E025 3>« autorisation accordée au titulaire\r\net à un passager accompagnateur »...");
                s = s.Replace("Kazuma...", "Kazuma...");
                return s;
            };

            // [154] BB\script\output\_macro03_eng#95
            entryTranslators[@"BB\script\output\_macro03_eng#95"] = (en) => {
                string s = en;
                s = s.Replace("Do you see that?<E003 10> There's something stuck in the side\r\nof the trunk there.<E003 12> <E330>It's glinting.", "Vous voyez ça ?<E003 10> Quelque chose est coincé sur le côté\r\nde la malle.<E003 12> <E330>Ça brille.");
                s = s.Replace("It looks like <E006>a fragment of metal<E005> of some sort.", "On dirait <E006>un éclat de métal<E005> d'une certaine sorte.");
                s = s.Replace("But it's wedged in so tightly, <E003 8><E025 3>I can't remove it.", "Mais c'est si profondément encastré <E003 8><E025 3>que je n'arrive pas à l'enlever.");
                s = s.Replace("Well don't cut yourself.<E003 10>\r\nYou'd better leave it, I think.", "Ne vous coupez pas surtout.<E003 10>\r\nIl vaut mieux le laisser là, je pense.");
                return s;
            };

            // [155] BB\script\output\_macro03_eng#96
            entryTranslators[@"BB\script\output\_macro03_eng#96"] = (en) => {
                string s = en;
                s = s.Replace("(Let's have a look inside...)", "(Regardons à l'intérieur...)");
                return s;
            };

            // [156] BB\script\output\_macro03_eng#98
            entryTranslators[@"BB\script\output\_macro03_eng#98"] = (en) => {
                string s = en;
                s = s.Replace("Have you seen this huge gash across the side of the trunk\r\nhere?", "Avez-vous vu cette énorme entaille sur le côté de la malle\r\nici ?");
                s = s.Replace("It's gone right through the leather and into the metal\r\nbehind.", "Elle a traversé le cuir et entaillé le métal en dessous.");
                s = s.Replace("Gosh, <E003 8><E025 2>for a metal chest like this to have been so badly\r\ndamaged...", "Nom d'un chien, <E003 8><E025 2>pour qu'un coffre en métal pareil soit aussi sévèrement\r\nendommagé...");
                s = s.Replace("Whatever made the gash must have struck the side of the\r\ntrunk with considerable force.", "Ce qui a causé cette entaille a dû frapper le flanc de la\r\nmalle avec une force prodigieuse.");
                s = s.Replace("(I wonder how it happened...)", "(Je me demande comment c'est arrivé...)");
                return s;
            };

            // [157] BB\script\output\_macro03_eng#99
            entryTranslators[@"BB\script\output\_macro03_eng#99"] = (en) => {
                string s = en;
                s = s.Replace("Professor Mikotoba has wonderful handwriting,<E003 6> doesn't\r\nhe?", "Le professeur Mikotoba a une calligraphie magnifique,\r\n<E003 6>n'est-ce pas ?");
                s = s.Replace("‘This dark-suited young man is not in the least bit\r\nuntrustworthy.’", "« Ce jeune homme vêtu de noir n'est absolument pas indigne de\r\nconfiance. »");
                s = s.Replace("...Is it just me, <E003 6><E043>or does that make me sound extremely\r\nuntrustworthy?", "...C'est moi, <E003 6><E043>ou cela donne l'impression que je ne suis pas\r\ndigne de confiance du tout ?");
                s = s.Replace("I do wish he'd at least called you a ‘nice young man’.", "J'aurais aimé qu'il vous qualifie au moins de « charmant jeune homme ».");
                s = s.Replace("...I'm really not sure that would help.", "...Je ne suis vraiment pas sûr que ça aurait arrangé les choses.");
                return s;
            };

            // [158] BB\script\output\_macro03_eng#100
            entryTranslators[@"BB\script\output\_macro03_eng#100"] = (en) => {
                string s = en;
                s = s.Replace("Oh...<E003 10><E025 2>it looks like this is some sort of <E006>steamship ticket<E005>.", "Oh...<E003 10><E025 2>on dirait une sorte de <E006>billet de bateau à vapeur<E005>.");
                s = s.Replace("‘The SS Grouse<E003 8>\r\nFirst-class cabin <E003 6>001’", "« SS Grouse<E003 8>\r\nCabine de première classe <E003 6>001 »");
                s = s.Replace("‘Yokohama departure: 11th September<E003 10>\r\nLondon arrival: 1st November’...", "« Départ de Yokohama : 11 septembre<E003 10>\r\nArrivée à Londres : 1er novembre »...");
                s = s.Replace("Ah, <E003 8>that's the boat that Professor Mikotoba and Judge\r\nJigoku came on from Japan, <E003 4>isn't it?", "Ah, <E003 8>c'est le bateau sur lequel le professeur Mikotoba et le juge\r\nJigoku sont venus du Japon, <E003 4>n'est-ce pas ?");
                s = s.Replace("Yes, <E003 6>I think it called at Dunkirk on the north coast of\r\nFrance for a night before finally arriving in Dover.", "Oui, <E003 6>je crois qu'il a fait escale à Dunkerque, sur la côte nord\r\nde la France, pendant une nuit avant d'arriver à Douvres.");
                s = s.Replace("(To think it's been almost a year since we arrived in\r\nDover on the SS Burya...)", "(Quand on pense que cela fait presque un an que nous sommes\r\narrivés à Douvres à bord du SS Burya...)");
                s = s.Replace("It seems a shame not to keep your ticket as a memento of\r\nyour trip, <E049><E003 6>don't you think?", "Ce serait dommage de ne pas garder son billet en souvenir du\r\nvoyage, <E049><E003 6>vous ne trouvez pas ?");
                s = s.Replace("Yes, <E003 6>I agree.<E003 10>\r\nI have mine safely in my diary.", "Oui, <E003 6>je suis d'accord.<E003 10>\r\nJ'ai gardé le mien précieusement dans mon journal intime.");
                s = s.Replace("And I keep mine in my wallet, <E003 8>so I have it with me at all\r\ntimes.", "Et moi je garde le mien dans mon portefeuille, <E003 8>pour l'avoir en\r\npermanence sur moi.");
                s = s.Replace("...Oh, <E049><E003 8>well how strange!<E003 10>\r\nWhere could it have gone?", "...Oh, <E049><E003 8>mais comme c'est bizarre !<E003 10>\r\nOù a-t-il bien pu passer ?");
                s = s.Replace("...Are you like this on purpose, <E003 6>Mr Naruhodo?", "...Vous le faites exprès, <E003 6>M. Naruhodo ?");
                s = s.Replace("(Did I imagine it, <E003 8><E025 3>or was that comment accompanied by a\r\nlittle sigh?)", "(Ai-je rêvé, <E003 8><E025 3>ou cette remarque était-elle accompagnée d'un\r\npetit soupir ?)");
                return s;
            };

            // [159] BB\script\output\_macro03_eng#101
            entryTranslators[@"BB\script\output\_macro03_eng#101"] = (en) => {
                string s = en;
                s = s.Replace("The helmet of this charming policeman appears to be a\r\nlittle worse for wear.", "Le casque de ce charmant policier semble un peu défraîchi.");
                s = s.Replace("I'm not convinced about the ‘charming’ part, <E003 8>but yes,<E003 8>\r\nyou're right...", "Je ne suis pas convaincu par le mot « charmant », <E003 8>mais oui,<E003 8>\r\nvous avez raison...");
                s = s.Replace("...the head part looks like it's been fairly heavily\r\nmanhandled.", "...la tête a l'air d'avoir été pas mal malmenée.");
                s = s.Replace("Almost as if somebody has enjoyed twisting it around\r\nand around for fun.", "Presque comme si quelqu'un s'était amusé à la tourner et\r\nretourner pour passer le temps.");
                s = s.Replace("Shall we try twisting it around and around, too?<E003 10>\r\n<E025 3>For fun.", "On essaie de la faire tourner nous aussi ?<E003 10>\r\n<E025 3>Pour s'amuser.");
                return s;
            };

            // [160] BB\script\output\_macro03_eng#102
            entryTranslators[@"BB\script\output\_macro03_eng#102"] = (en) => {
                string s = en;
                s = s.Replace("The helmet of this charming policeman appears to be a\r\nlittle worse for wear.", "Le casque de ce charmant policier semble un peu défraîchi.");
                s = s.Replace("...the head part looks like it's been fairly heavily\r\nmanhandled.", "...la tête a l'air d'avoir été pas mal malmenée.");
                s = s.Replace("Which stands to reason, <E003 4>really, <E003 6>doesn't it?<E003 12>\r\n<E025 2>I mean, <E003 8>it gets turned around and around every day.", "Ce qui est bien compréhensible, <E003 4>après tout, <E003 6>non ?<E003 12>\r\n<E025 2>Je veux dire, <E003 8>elle est tournée tous les jours.");
                s = s.Replace("...I hope it doesn't fall off in the end.", "...J'espère qu'elle ne finira pas par tomber.");
                return s;
            };

            // [161] BB\script\output\_macro03_eng#103
            entryTranslators[@"BB\script\output\_macro03_eng#103"] = (en) => {
                string s = en;
                s = s.Replace("So this is the little key used to wind the inspector's\r\npocket watch.", "C'est donc la petite clé servant à remonter la montre de poche\r\nde l'inspecteur.");
                s = s.Replace("It was a mystery at first.<E003 8> Why it should be a policeman,<E003 6>\r\nI mean.", "C'était un mystère au début.<E003 8> Pourquoi un policier,\r\nje veux dire.");
                s = s.Replace("But it's because it was a gift from Scotland Yard,<E003 6> in\r\nrecognition of Inspector Gregson's hard work.", "Mais c'était en fait un cadeau de Scotland Yard,<E003 6> pour saluer\r\nles loyaux services de l'inspecteur Gregson.");
                s = s.Replace("...If its head did fall off from overuse, <E003 6><E025 2>it might seem a\r\nlittle inappropriate, <E003 8>don't you think?", "...Si sa tête venait à tomber à force d'usage, <E003 6><E025 2>cela paraîtrait\r\nun peu déplacé, <E003 8>vous ne pensez pas ?");
                s = s.Replace("That's...<E003 10><E025 2><E333>the British sense of humour for you, <E003 6>I think.", "C'est ça...<E003 10><E025 2><E333>le sens de l'humour britannique, <E003 6>j'imagine.");
                return s;
            };

            // [162] BB\script\output\_macro03_eng#104
            entryTranslators[@"BB\script\output\_macro03_eng#104"] = (en) => {
                string s = en;
                s = s.Replace("I've always wondered <E003 8><E330>what the underside of a hairpiece\r\nlooks like.", "Je me suis toujours demandé <E003 8><E330>à quoi ressemblait le dessous\r\nd'un postiche.");
                s = s.Replace("That doesn't surprise me at all, <E003 4>Mr Naruhodo.<E003 10>\r\nYou always want to see what lies beneath, <E003 4>don't you?", "Cela ne me surprend pas du tout, <E003 4>M. Naruhodo.<E003 10>\r\nVous voulez toujours savoir ce qui se cache sous la surface, <E003 4>non ?");
                s = s.Replace("...I'm not sure that's quite how I'd put it.", "...Je ne suis pas certain que je l'aurais formulé ainsi.");
                s = s.Replace("You must have to use lots of bird lime to keep it in place\r\non your head.", "Il faut sûrement une bonne dose de glu pour le maintenir\r\nsur le crâne.");
                s = s.Replace("So it doesn't get blown off in a gust of wind, <E003 6>I mean.", "Pour éviter qu'il ne s'envole au premier coup de vent, je veux dire.");
                s = s.Replace("...That might be a little <E003 6><E238>inconvenient <E003 6><E025 2>when you wanted to\r\ntake it off again, <E003 6>don't you think?", "...Ce serait peut-être un peu <E003 6><E238>contraignant <E003 6><E025 2>quand on veut\r\nle retirer, <E003 6>non ?");
                return s;
            };

            // [163] BB\script\output\_macro03_eng#105
            entryTranslators[@"BB\script\output\_macro03_eng#105"] = (en) => {
                string s = en;
                s = s.Replace("So this is the type of revolver that's standard issue for\r\nmembers of the judiciary, then.", "C'est donc le type de revolver standard fourni aux membres\r\nde l'appareil judiciaire.");
                s = s.Replace("Yes.<E003 8> And when I asked about whether records are kept\r\nabout who they're issued to...", "Oui.<E003 8> Et quand j'ai demandé si des registres étaient tenus\r\npour savoir à qui ils sont attribués...");
                s = s.Replace("...I was told that for the past five years, <E003 8><E333>they've been\r\nengraved with a unique serial number.", "...on m'a répondu que depuis cinq ans, <E003 8><E333>ils sont tous gravés\r\nd'un numéro de série unique.");
                s = s.Replace("Oh, <E003 8>but as far as I can tell...", "Oh, <E003 8>mais d'après ce que je vois...");
                s = s.Replace("...there's nothing like that on this gun.", "...il n'y a rien de tel sur cette arme.");
                s = s.Replace("Which tells us <E003 8><E043><E025 3>that it must have been issued longer ago\r\nthan that.", "Ce qui nous indique <E003 8><E043><E025 3>qu'elle a dû être attribuée il y a plus\r\nlongtemps que cela.");
                return s;
            };

            // [164] BB\script\output\_macro03_eng#106
            entryTranslators[@"BB\script\output\_macro03_eng#106"] = (en) => {
                string s = en;
                s = s.Replace("There are details of a whole raft of cases dating back\r\nyears on here, <E003 6>aren't there?", "Il y a des détails sur tout un tas d'affaires remontant à des\r\nannées ici, <E003 6>n'est-ce pas ?");
                s = s.Replace("This paper from ten years ago is browning with age, <E003 6>look.", "Ce papier d'il y a dix ans a jauni avec le temps, <E003 6>regarde.");
                s = s.Replace("Out of interest, <E003 8><E025 2>the most recent thing appears to be this\r\nnewspaper cutting here.", "Par curiosité, <E003 8><E025 2>la chose la plus récente semble être cette\r\ncoupure de journal ici.");
                s = s.Replace("Oh.<E003 12> <E025 2>It's the same Red-Headed League advertisement that\r\nMr Sholmes had picked out.", "Oh.<E003 12> <E025 2>C'est la même annonce de la Ligue des Rouquins que\r\nM. Sholmes avait repérée.");
                s = s.Replace("And do you remember?<E003 10> There was a red hairpiece at the\r\nscene, too.", "Et vous vous souvenez ?<E003 10> Il y avait aussi un postiche roux sur\r\nles lieux.");
                s = s.Replace("(Was Inspector Gregson an exponent of the Red-Headed\r\nLeague, then?)", "(L'inspecteur Gregson faisait-il donc partie de la Ligue\r\ndes Rouquins ?)");
                return s;
            };

            // [165] BB\script\output\_macro03_eng#107
            entryTranslators[@"BB\script\output\_macro03_eng#107"] = (en) => {
                string s = en;
                s = s.Replace("Oh.<E003 12> <E025 2>What's this...?", "Oh.<E003 12> <E025 2>Qu'est-ce que c'est... ?");
                s = s.Replace("Mr Naruhodo!<E003 14>\r\n<E025 2><E341>Look!", "M. Naruhodo !<E003 14>\r\n<E025 2><E341>Regardez !");
                s = s.Replace("Oh yes.<E003 12> It's a smudge of some kind.<E003 12>\r\n<E025 3>In fact...", "Ah oui.<E003 12> C'est une sorte de tache.<E003 12>\r\n<E025 3>En fait...");
                s = s.Replace("...it looks just like <E003 10><E238><E025 3><E006>a handprint<E005>.", "...on dirait bien <E003 10><E238><E025 3><E006>une empreinte de main<E005>.");
                s = s.Replace("And the colour...", "Et cette couleur...");
                s = s.Replace("That's <E006>blood<E005>, <E003 10><E025 3>isn't it?", "C'est du <E006>sang<E005>, <E003 10><E025 3>n'est-ce pas ?");
                s = s.Replace("Oh dear...<E003 12> <E025 2><E341>How disturbing...", "Grand Dieu...<E003 12> <E025 2><E341>C'est troublant...");
                return s;
            };

            // [166] BB\script\output\_macro03_eng#108
            entryTranslators[@"BB\script\output\_macro03_eng#108"] = (en) => {
                string s = en;
                s = s.Replace("Have you had an idea, <E003 6>Mr Naruhodo?<E003 12>\r\nYou're staring at the end of the string of fireworks.", "Vous avez une idée, <E003 6>M. Naruhodo ?<E003 12>\r\nVous fixez le bout de la mèche des pétards.");
                s = s.Replace("Sorry.<E003 10> <E025 2>It's just that it's the ‘Venus Special’.", "Pardon.<E003 10> <E025 2>C'est juste que c'est le « Spécial Venus ».");
                s = s.Replace("I was wondering <E003 8><E025 3>what six hundred pence worth of\r\nfireworks would sound like.", "Je me demandais <E003 8><E025 3>quel bruit feraient six cents pence de pétards.");
                s = s.Replace("Shall we find out?", "On essaie pour voir ?");
                s = s.Replace("What?<E003 12> <E025 3>B-<E003 6><E341>But...<E003 12><E025 1>she said it could blow up the courtroom!", "Quoi ?<E003 12> <E025 3>M-<E003 6><E341>Mais...<E003 12><E025 1>elle a dit que ça pouvait faire sauter le tribunal !");
                s = s.Replace("...*BANG!*", "...*BAM !*");
                s = s.Replace("A-<E003 8>Alright, <E003 12>that was a fairly sizeable bang.", "D-<E003 8>D'accord, <E003 12>c'était une détonation plutôt costaude.");
                s = s.Replace("My ears are still ringing, <E003 6>Mr Naruhodo.", "Mes oreilles sifflent encore, <E003 6>M. Naruhodo.");
                s = s.Replace("It sounded almost exactly like...", "On aurait dit exactement le son de...");
                return s;
            };

            // [167] BB\script\output\_macro03_eng#109
            entryTranslators[@"BB\script\output\_macro03_eng#109"] = (en) => {
                string s = en;
                s = s.Replace("Ah...<E003 10> There's a tiny little keyhole here.<E003 10>\r\nCan you see?", "Ah...<E003 10> Il y a un minuscule trou de serrure ici.<E003 10>\r\nVous voyez ?");
                s = s.Replace("Oh yes.<E003 8> That's probably for <E006>the winder<E005> used to wind up\r\nthe mechanism.", "Oh oui.<E003 8> C'est probablement pour <E006>le remontoir<E005> servant à remonter\r\nle mécanisme.");
                s = s.Replace("It looks a little unusual, <E003 8><E025 2>don't you think?", "Il a l'air un peu inhabituel, <E003 8><E025 2>vous ne trouvez pas ?");
                s = s.Replace("Yes, <E003 8><E025 2>you'd need just the right key to wind it,<E003 6> I imagine.", "Oui, <E003 8><E025 2>il faudrait exactement la bonne clé pour le remonter,<E003 6> j'imagine.");
                s = s.Replace("(Why do I feel as though I've seen something...?)", "(Pourquoi ai-je l'impression d'avoir vu quelque chose... ?)");
                s = s.Replace("(Something a bit like <E006>a key<E007> that's about the right size to fit\r\nin this hole...)", "(Quelque chose comme <E006>une clé<E007> de la bonne taille pour entrer\r\ndans ce trou...)");
                s = s.Replace("It would be wonderful if we had the key...<E003 10> <E025 2><E333>Let's <E006>check\r\ncarefully<E005> over what we've already found.", "Ce serait formidable si nous avions la clé...<E003 10> <E025 2><E333><E006>Examinons\r\nsoigneusement<E005> ce que nous avons déjà trouvé.");
                return s;
            };

            // [168] BB\script\output\_macro03_eng#110
            entryTranslators[@"BB\script\output\_macro03_eng#110"] = (en) => {
                string s = en;
                s = s.Replace("So this is where the little policeman figurine's key goes in\r\nto wind the watch.", "C'est donc ici qu'entre la clé de la figurine de policier\r\npour remonter la montre.");
                s = s.Replace("Winding it up every single day for ten years without fail...", "La remonter chaque jour que Dieu fait depuis dix ans sans faillir...");
                s = s.Replace("Yes, <E003 10><E333>it was obviously a thing of great importance to the\r\ninspector.", "Oui, <E003 10><E333>c'était manifestement un objet d'une importance capitale\r\npour l'inspecteur.");
                s = s.Replace("(Or a reminder of the past, <E003 8>lest he forget...)", "(Ou un rappel du passé, <E003 8>de peur qu'il n'oublie...)");
                return s;
            };

            // [169] BB\script\output\_macro03_eng#111
            entryTranslators[@"BB\script\output\_macro03_eng#111"] = (en) => {
                string s = en;
                s = s.Replace("The glass over the face really is badly cracked, <E003 6>look.", "Le verre du cadran est vraiment très fissuré, <E003 6>regardez.");
                s = s.Replace("What a shame when the inspector clearly looked after it\r\nso carefully.", "Quel dommage, alors que l'inspecteur en prenait si grand soin.");
                s = s.Replace("I imagine Mr Sholmes could repair it, <E003 6>don't you?", "J'imagine que M. Sholmes pourrait la réparer, <E003 6>non ?");
                s = s.Replace("Yes, <E003 8>I should think so.", "Oui, <E003 8>je suppose que oui.");
                s = s.Replace("(He's very adept at things like this.<E003 10>\r\n<E025 2><E330>A useful man to have around, <E003 6>in fact.)", "(Il est très doué pour ce genre de choses.<E003 10>\r\n<E025 2><E330>Un homme bien utile à avoir sous la main, <E003 6>en fait.)");
                s = s.Replace("But kindly remember that he's a great detective,<E003 6>\r\nMr Naruhodo!<E003 12> <E025 2>Not an odd-job man.", "Mais n'oubliez pas que c'est un grand détective,<E003 6>\r\nM. Naruhodo !<E003 12> <E025 2>Pas un homme à tout faire.");
                return s;
            };

            // [170] BB\script\output\_macro03_eng#112
            entryTranslators[@"BB\script\output\_macro03_eng#112"] = (en) => {
                string s = en;
                s = s.Replace("There's a tiny little stub sticking out from this small hole\r\nhere, <E003 6>look.", "Il y a une minuscule tige qui dépasse de ce petit trou\r\nici, <E003 6>regardez.");
                s = s.Replace("I suppose there must have been a little knob or something\r\non that for setting the time.", "J'imagine qu'il devait y avoir un petit bouton ou quelque\r\nchose pour régler l'heure.");
                s = s.Replace("In that case, <E003 8>seeing as we know the inspector took such\r\ngood care of this watch...", "Dans ce cas, <E003 8>puisqu'on sait que l'inspecteur prenait un tel\r\nsoin de cette montre...");
                s = s.Replace("...it probably broke when the incident occurred,<E003 6> didn't it?", "...elle s'est probablement cassée lors de l'incident,<E003 6> n'est-ce pas ?");
                s = s.Replace("Yes!<E003 12> <E025 2>Of course!", "Oui !<E003 12> <E025 2>Bien sûr !");
                s = s.Replace("Which could mean <E003 8><E025 3><E330>that there's a small part of the watch\r\nstill at the scene, <E003 8>maybe...", "Ce qui signifierait <E003 8><E025 3><E330>qu'une petite pièce de la montre\r\nest peut-être encore sur les lieux...");
                return s;
            };

            // [171] BB\script\output\_macro03_eng#113
            entryTranslators[@"BB\script\output\_macro03_eng#113"] = (en) => {
                string s = en;
                s = s.Replace("Well, <E003 8>I suppose we should see what this inspector's\r\nidentification looks like inside...", "Eh bien, <E003 8>je suppose qu'on devrait regarder à quoi ressemble\r\nce carnet d'inspecteur à l'intérieur...");
                return s;
            };

            // [172] BB\script\output\_macro03_eng#114
            entryTranslators[@"BB\script\output\_macro03_eng#114"] = (en) => {
                string s = en;
                s = s.Replace("Yes, <E003 8>it definitely looks fake, <E003 6>doesn't it?", "Oui, <E003 8>ça a vraiment l'air faux, <E003 6>n'est-ce pas ?");
                s = s.Replace("Out of interest, <E003 8>what name is given?", "Par curiosité, <E003 8>quel nom est indiqué ?");
                s = s.Replace("Probably just something plucked out of the air.<E003 15>\r\n<E025 4>It's...<E003 10><E330>‘<E006>Tobias Gregson<E005>’...", "Sans doute un nom inventé de toutes pièces.<E003 15>\r\n<E025 4>C'est...<E003 10><E330>« <E006>Tobias Gregson<E005> »...");
                s = s.Replace("Wait, <E003 12>what?", "Attendez, <E003 12>quoi ?!");
                s = s.Replace("This Scotland Yard insignia...", "Cet insigne de Scotland Yard...");
                s = s.Replace("...looks <E006>genuine<E005> to me.", "...m'a tout l'air d'être <E006>authentique<E005>.");
                s = s.Replace("But how?!", "Mais comment ?!");
                s = s.Replace("And the department and identification number details\r\nare all correct as well.", "Et les détails du département et du matricule\r\nsont parfaitement exacts eux aussi.");
                s = s.Replace("(Since when have you known those?)", "(Depuis quand connaissez-vous ces détails ?)");
                s = s.Replace("Do, <E003 10>do you mean to say...?", "V-...<E003 10> vous voulez dire... ?");
                s = s.Replace("I know it seems incredible, <E003 8>but yes...", "Je sais que ça paraît incroyable, <E003 8>mais oui...");
                s = s.Replace("...I think this is a genuine identification book issued by\r\nScotland Yard.", "...je crois que c'est un véritable carnet de service délivré\r\npar Scotland Yard.");
                s = s.Replace("But that's...<E003 12> <E604><E025 1>That's unbelievable!<E003 14>\r\n<E025 2><E338><E341><E007>(This is <E006>the real thing<E007> after all?!)<E005>", "Mais c'est...<E003 12> <E604><E025 1>C'est incroyable !<E003 14>\r\n<E025 2><E338><E341><E007>(C'est le <E006>vrai de vrai<E007> après tout ?!)<E005>");
                return s;
            };

            // [173] BB\script\output\_macro03_eng#115
            entryTranslators[@"BB\script\output\_macro03_eng#115"] = (en) => {
                string s = en;
                s = s.Replace("This Scotland Yard insignia looks genuine to me.", "Cet insigne de Scotland Yard m'a l'air authentique.");
                s = s.Replace("And the department and identification number details<E003 8> <E333>are\r\nall correct as well.", "Et les détails du département et du matricule<E003 8> <E333>sont\r\ntous exacts eux aussi.");
                s = s.Replace("There's no doubt that this really is Inspector Gregson's\r\nidentification.", "Il n'y a aucun doute que c'est bien la pièce d'identité de\r\nl'inspecteur Gregson.");
                return s;
            };
        }
    }
}
