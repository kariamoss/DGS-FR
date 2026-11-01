using System;
using System.Collections.Generic;

namespace Ep4Fixes
{
    public static class Part1
    {
        public static void Register(Dictionary<string, Func<string, string>> d)
        {
            // [1] BB\script\output\_sce03_bg0200_0_check_eng#2
            d[@"BB\script\output\_sce03_bg0200_0_check_eng#2"] = (s) => {
                s = s.Replace("These very European suits of armour<E003 4> are still glaring at\r\neach other across the carpet, I see.", "Ces armures si européennes<E003 4> continuent de se dévisager\r\nde chaque côté du tapis, à ce que je vois.");
                s = s.Replace("In a way,<E003 4> they feel like guardians of the Lord Chief\r\nJustice's office.", "D'une certaine façon,<E003 4> elles font office de gardiennes du\r\nbureau du juge suprême.");
                s = s.Replace("I suppose...<E003 10><E145 3 78><E003 7><E333><E025 2>they're rather like the lion-dogs that guard\r\nshrines in Japan,<E003 6> aren't they?", "J'imagine que...<E003 10><E145 3 78><E003 7><E333><E025 2>ce sont un peu comme les chiens-lions qui\r\ngardent les sanctuaires au Japon,<E003 6> non ?");
                s = s.Replace("...Aren't they a bit too human to be called <E145 3 64>‘lion-dogs’?", "...Ne sont-elles pas un peu trop humaines pour être appelées <E145 3 64>« chiens-lions » ?");
                s = s.Replace("Did you know that it's a dream of mine<E003 6> to keep two cats\r\none day?", "Saviez-vous que c'est un de mes rêves<E003 6> d'avoir deux chats\r\nun jour ?");
                s = s.Replace("I feel as though we've gone off at a bit of a tangent,<E003 8> don't\r\nyou?", "J'ai l'impression qu'on s'éloigne un peu du sujet,<E003 8> non ?");
                return s;
            };

            // [2] BB\script\output\_sce03_bg0204_0_check_eng#4
            d[@"BB\script\output\_sce03_bg0204_0_check_eng#4"] = (s) => {
                s = s.Replace("There's all sorts on these shelves:<E003 8> chemistry apparatus,<E003 8>\r\nbooks,<E003 8> papers<E003 10> <E025 3>and...<E003 12>lots of things I've never seen before.", "Il y a de tout sur ces étagères :<E003 8> du matériel de chimie,<E003 8>\r\ndes livres,<E003 8> des papiers<E003 10> <E025 3>et...<E003 12>un tas de choses jamais vues.");
                s = s.Replace("It's all heaped up so high,<E003 6> I can't help feeling that the\r\nwhole lot is going to topple at any moment.", "Tout est empilé si haut<E003 6> que j'ai l'impression que tout\r\nva s'écrouler d'un instant à l'autre.");
                s = s.Replace("It looks as though it might topple,<E003 4> and yet it doesn't.<E049><E003 12>\r\nThe epitome of Mr Sholmes's brilliance!", "On dirait que ça va tomber,<E003 4> et pourtant non.<E049><E003 12>\r\nLa quintessence du génie de M. Sholmes !");
                s = s.Replace("...I don't get it.", "...Je ne saisis pas.");
                s = s.Replace("As it happens,<E003 8> I'm quite well practised when it comes to\r\nstacking shelves myself.", "Il se trouve que,<E003 8> je m'y connais assez pour empiler\r\ndes choses sur les étagères moi-même.");
                s = s.Replace("Just the other day,<E003 6> the shelf in my office finally gave way\r\nunder the strain, though.", "L'autre jour encore,<E003 6> l'étagère de mon bureau a fini par céder\r\nsous le poids.");
                s = s.Replace("It looks as though it might topple,<E003 4> and it does.<E049><E003 16>\r\n<E333>Yes,<E003 8> the epitome of your disarray!", "On dirait que ça va tomber,<E003 4> et ça tombe.<E049><E003 16>\r\n<E333>Oui,<E003 8> la quintessence de votre désordre !");
                s = s.Replace("...I really<E003 8> don't get it.", "...Je ne comprends vraiment<E003 8> rien à tout ça.");
                return s;
            };

            // [3] BB\script\output\_sce03_bg0204_0_check_eng#7
            d[@"BB\script\output\_sce03_bg0204_0_check_eng#7"] = (s) => {
                s = s.Replace("Ah yes,<E003 8> Mr Sholmes's curious collection of trinkets from\r\nthe various mysteries he's solved.", "Ah oui,<E003 8> la curieuse collection de babioles de M. Sholmes tirées\r\ndes diverses énigmes qu'il a résolues.");
                s = s.Replace("It's one of my favourite parts of this room.<E049><E003 8>\r\n<E333>Full of items with such exciting tales to tell!", "C'est l'un de mes recoins préférés de cette pièce.<E049><E003 8>\r\n<E333>Rempli d'objets avec des histoires si passionnantes à raconter !");
                s = s.Replace("And I do believe<E049> <E160 3><E139 3><E346>he's added to it since I last looked.", "Et je crois bien<E049> <E160 3><E139 3><E346>qu'il en a ajouté depuis la dernière fois.");
                s = s.Replace("Now there's a mysterious pince-nez, <E003 4>a mysterious little\r\nbox, <E003 6>a mysterious horseshoe, <E003 4>a mysterious biscuit...", "Il y a maintenant un mystérieux pince-nez, <E003 4>une mystérieuse boîte,\r\n<E003 6>un fer à cheval mystérieux, <E003 4>un mystérieux biscuit...");
                s = s.Replace("I think that last one<E003 6> <E025 2><E330>might just be one of Iris's unfinished\r\nsnacks.", "Je pense que ce dernier<E003 6> <E025 2><E330>n'est qu'un reste du goûter\r\nd'Iris.");
                return s;
            };

            // [4] BB\script\output\_sce03_bg0204_0_check_eng#8
            d[@"BB\script\output\_sce03_bg0204_0_check_eng#8"] = (s) => {
                s = s.Replace("Iris's pretty little tea set is set out beautifully as ever,<E003 8>\r\nlook.", "Le ravissant service à thé d'Iris est toujours aussi joliment\r\ndisposé,<E003 8> regardez.");
                s = s.Replace("Well,<E003 10> <E025 2><E333>it's only by carefully taking care of a tea set that\r\nyou can make good tea.", "Eh bien,<E003 10> <E025 2><E333>ce n'est qu'en prenant grand soin de son service qu'on\r\npeut préparer du bon thé.");
                s = s.Replace("Is...<E003 10><E330><E025 2>that a roundabout way of telling me I need to tidy my\r\ndesk?", "Est-ce...<E003 10><E330><E025 2>une manière détournée de me dire de ranger mon\r\nbureau ?");
                s = s.Replace("Oh, Mr Naruhodo,<E003 8> you do overthink things at times.", "Oh, M. Naruhodo,<E003 8> vous vous posez bien trop de questions.");
                return s;
            };

            // [5] BB\script\output\_sce03_bg0206_0_00_eng#4
            d[@"BB\script\output\_sce03_bg0206_0_00_eng#4"] = (s) => {
                s = s.Replace("1st November\r\n<CNTR><E003 5>Naruhodo's Legal Consultancy", "1er novembre\r\n<CNTR><E003 5>Cabinet d'avocat de Naruhodo");
                return s;
            };

            // [6] BB\script\output\_sce03_bg0206_0_check_eng#3
            d[@"BB\script\output\_sce03_bg0206_0_check_eng#3"] = (s) => {
                s = s.Replace("You see?<E003 10> <E333>I've been keeping my desk beautifully covered\r\nin papers as always.", "Vous voyez ?<E003 10> <E333>J'ai gardé mon bureau magnifiquement couvert\r\nde papiers, comme toujours.");
                s = s.Replace("You really must tidy it all up,<E003 4> Mr Naruhodo.<E049><E003 10>\r\n<E025 3>No more excuses.", "Vous devez vraiment ranger tout cela,<E003 4> M. Naruhodo.<E049><E003 10>\r\n<E025 3>Plus d'excuses.");
                s = s.Replace("But Miss Susato,<E003 8> <E025 3>the way I see it...<E145 3 77>", "Mais mademoiselle Susato,<E003 8> <E025 3>de mon point de vue...<E145 3 77>");
                s = s.Replace("...all these papers building up on my desk like this<E003 4> are a\r\nreminder of my wonderfully diverse daily life.", "...tous ces papiers empilés ainsi sur mon bureau<E003 4> me rappellent\r\nma vie quotidienne si riche et variée.");
                s = s.Replace("I like to leave them as they are<E003 6> so I never forget how\r\nlucky I am to have such varied experiences.", "J'aime les laisser ainsi<E003 6> pour ne jamais oublier la chance que\r\nj'ai de vivre de telles expériences.");
                s = s.Replace("In that case,<E049><E003 12> <E164 3 83 1 2 7 0 0 1><E139 3><E025 2>you should definitely have a thorough tidy.", "Dans ce cas,<E049><E003 12> <E164 3 83 1 2 7 0 0 1><E139 3><E025 2>vous devriez faire un grand rangement.");
                s = s.Replace("Then you'll be able to see your papers building up all\r\nover again<E003 6> and feel that joy renewed.", "Ainsi vous pourrez voir vos papiers s'accumuler de nouveau<E003 6>\r\net ressentir cette joie renouvelée.");
                s = s.Replace("(Still can't beat her in an argument.<E003 10>\r\n<E025 3>Even though I'm the lawyer here...)", "(Impossible de la battre dans une dispute.<E003 10>\r\n<E025 3>Même si c'est moi l'avocat...)");
                return s;
            };

            // [7] BB\script\output\_sce03_bg0206_0_check_eng#9
            d[@"BB\script\output\_sce03_bg0206_0_check_eng#9"] = (s) => {
                s = s.Replace("Your room across the hall is undisturbed, <E003 6>of course.", "Votre chambre de l'autre côté du couloir est intacte, <E003 6>bien sûr.");
                s = s.Replace("I don't suppose I'd be permitted to see inside now that\r\nyou're back though, <E003 8><E025 3>would I?", "Je suppose qu'il ne me sera pas permis de jeter un œil maintenant\r\nque vous êtes rentrée, <E003 8><E025 3>n'est-ce pas ?");
                s = s.Replace("You know very well <E049><E003 8><E333>that only Iris is allowed inside.", "Vous savez très bien <E049><E003 8><E333>que seule Iris a le droit d'y entrer.");
                s = s.Replace("(Yes, <E003 8><E025 2>I heard you two giggling together in there again last\r\nnight.)", "(Oui, <E003 8><E025 2>je vous ai entendues glousser ensemble là-dedans la nuit\r\ndernière.)");
                s = s.Replace("You can visit Mr Sholmes in his room, <E049><E003 6>Mr Naruhodo.", "Vous pouvez toujours rendre visite à M. Sholmes dans sa chambre,\r\n<E049><E003 6>M. Naruhodo.");
                s = s.Replace("Last time I did that, <E003 6><E025 2><E330><E145 3 67>he tried to convince me to drink some\r\nstrange concoction he'd mixed up.", "La dernière fois que j'ai fait ça, <E003 6><E025 2><E330><E145 3 67>il a essayé de me faire\r\navaler une mixture bizarre de sa composition.");
                return s;
            };

            // [8] BB\script\output\_sce03_bg0206_0_check_eng#10
            d[@"BB\script\output\_sce03_bg0206_0_check_eng#10"] = (s) => {
                s = s.Replace("It's a lovely photograph we took together when I had to\r\nleave London.<E049><E003 10> <E025 3>Though it was a sad day.", "C'est une charmante photo que nous avons prise lorsque j'ai dû\r\nquitter Londres.<E049><E003 10> <E025 3>Bien que ce fût un jour bien triste.");
                s = s.Replace("But I happily have<E049><E003 4> <E145 3 65><E003 10><E346>the same photograph on display in my\r\nroom at home, you know.", "Mais j'ai la joie<E049><E003 4> <E145 3 65><E003 10><E346>d'avoir la même photo exposée dans ma chambre\r\nau Japon, vous savez.");
                s = s.Replace("Now that we're all back together again...", "Maintenant que nous voilà tous réunis...");
                s = s.Replace("...it would be nice to take a new photograph.", "...ce serait bien d'en reprendre une nouvelle.");
                s = s.Replace("Oh yes!<E049><E003 12> That would be wonderful!", "Oh oui !<E049><E003 12> Ce serait merveilleux !");
                return s;
            };

            // [9] BB\script\output\_sce03_bg0206_1_00_eng#6
            d[@"BB\script\output\_sce03_bg0206_1_00_eng#6"] = (s) => {
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Naruhodo's Legal Consultancy", "2 novembre\r\n<CNTR><E003 5>Cabinet juridique Naruhodo");
                return s;
            };

            // [10] BB\script\output\_sce03_bg0214_1_00_eng#5
            d[@"BB\script\output\_sce03_bg0214_1_00_eng#5"] = (s) => {
                s = s.Replace("2nd November\r\n<CNTR><E003 5>St Synner's Hospital, Ward 3", "2 novembre\r\n<CNTR><E003 5>Hôpital St Synner, Salle 3");
                return s;
            };

            // [11] BB\script\output\_sce03_bg0400_0_check_eng#2
            d[@"BB\script\output\_sce03_bg0400_0_check_eng#2"] = (s) => {
                s = s.Replace("Look at those cases just left there on that trolley.<E003 10>\r\n<E025 2>Aren't they worried about thieves?<E003 8> <E003 3>I know I am.", "Regardez ces malles laissées là sur ce chariot.<E003 10>\r\n<E025 2>Ne craignent-ils pas les voleurs ?<E003 8> <E003 3>Moi, ça m'inquiéterait.");
                s = s.Replace("Haven't you seen the porter over there?<E049><E003 8> <E025 2>Don't worry,<E049><E003 6> he's\r\nobviously keeping an eye on everything.", "N'avez-vous pas vu le porteur là-bas ?<E049><E003 8> <E025 2>Ne craignez rien,<E049><E003 6> il\r\ngarde l'œil sur tout, manifestement.");
                s = s.Replace("Ah, <E003 10><E025 2>so it's a trap, <E003 8>designed to catch any chancers who\r\nmight be tempted!", "Ah, <E003 10><E025 2>c'est donc un piège, <E003 8>conçu pour attraper les imprudents\r\nqui se laisseraient tenter !");
                s = s.Replace("Why did the porter give me such a scathing look just now,<E003 8>\r\n<E025 3>do you suppose?", "Pourquoi le porteur m'a-t-il lancé un regard si noir tout à l'heure,<E003 8>\r\n<E025 3>d'après vous ?");
                s = s.Replace("Well...<E003 8>some might say you look a little suspicious with\r\nyour jet-black clothes.", "Eh bien...<E003 8>certains diraient que vous paraissez suspect avec vos\r\nhabits d'un noir d'encre.");
                s = s.Replace("Not everyone clad in black is some sort of ninja with\r\nintent to steal, <E003 6><E341>you know!", "Tous ceux vêtus de noir ne sont pas des ninjas venus pour voler,\r\n<E003 6><E341>vous savez !");
                return s;
            };

            // [12] BB\script\output\_sce03_bg0401_0_check_eng#2
            d[@"BB\script\output\_sce03_bg0401_0_check_eng#2"] = (s) => {
                s = s.Replace("An axe, <E003 8>a hunting rifle <E003 8>and four pairs of handcuffs...<E003 15>\r\nThat's a daunting collection.", "Une hache, <E003 8>un fusil de chasse <E003 8>et quatre paires de menottes...<E003 15>\r\nVoilà une bien intimidante collection.");
                s = s.Replace("Ah, <E049><E003 10><E333><E025 2>there's <E006>a story<E005> behind every one of those.", "Ah, <E049><E003 10><E333><E025 2>il y a <E006>une histoire<E005> derrière chacun d'entre eux.");
                s = s.Replace("You mean...", "Vous voulez dire...");
                s = s.Replace("...the rifle was a famous killer's murder weapon?<E003 12>\r\n<E346>And the axe was wielded by an infamous executioner?", "...que le fusil était l'arme du crime d'un tueur célèbre ?<E003 12>\r\n<E346>Et que la hache a été maniée par un sinistre bourreau ?");
                s = s.Replace("And the handcuffs were once used to immobilise a fierce\r\nfour-legged beast when it was arrested?!", "Et que les menottes ont servi à entraver une féroce bête\r\nà quatre pattes lors de son arrestation ?!");
                s = s.Replace("I think you're in the realms of fantasy now, <E049><E003 6>Mr Naruhodo.", "Je crois que vous êtes en plein délire, <E049><E003 6>M. Naruhodo.");
                s = s.Replace("Not those kind of stories, <E049><E003 6>Jimmy.", "Pas ce genre d'histoires, <E049><E003 6>gamin.");
                s = s.Replace("That axe <E049><E003 8><E330>was the one I used to chop down the cherry\r\ntree at my hoose.<E049><E003 10> Mrs Caidin was'nae best pleased.", "Cette hache, <E049><E003 8><E330>c'est celle qu'j'ai prise pour abattre l'cerisier\r\nchez moi.<E049><E003 10> Mme Caidin n'a point été ravie, j'vous l'dis.");
                s = s.Replace("Haah...", "Haah...");
                s = s.Replace("And the cuffs on the left <E003 6><E025 2><E043>are the ones I caught my first\r\nburglar with back when I was a bobby.", "Et les fers à gauche, <E003 6><E025 2><E043>c'est ceux avec lesquels j'ai coffré mon\r\npremier cambrioleur quand j'étais bobby.");
                s = s.Replace("The stories were a little different to those you imagined, \r\nI think, <E049><E003 6>weren't they?", "Les histoires étaient un brin différentes de ce que vous aviez\r\nimaginé, <E049><E003 6>non ?");
                s = s.Replace("Yes, <E003 8>to my relief...<E003 10>and in some small way,<E003 8> my\r\ndisappointment.", "Oui, <E003 8>à mon grand soulagement...<E003 10> et un peu à ma\r\ndéception aussi.");
                return s;
            };

            // [13] BB\script\output\_sce03_bg0401_0_check_eng#5
            d[@"BB\script\output\_sce03_bg0401_0_check_eng#5"] = (s) => {
                s = s.Replace("I'd never have expected to find a parrot in a prison!<E003 10>\r\nIt must be the governor's pet.", "Je n'aurais jamais pensé trouver un perroquet dans une prison !<E003 10>\r\nCe doit être l'animal de compagnie du gouverneur.");
                s = s.Replace("Given where we are...<E003 8><E025 2><E164 3 84 1 2 7 0 0 1><E139 3>it's hard not to see the poor\r\ncreature as a prisoner.", "Vu où nous sommes...<E003 8><E025 2><E164 3 84 1 2 7 0 0 1><E139 3>difficile de ne pas voir cette pauvre\r\nbête comme une prisonnière.");
                s = s.Replace("Lemme-oot!<E003 20>\r\n<E607>Dinnae-kill-me!", "Laissez-m'sortir !<E003 20>\r\n<E607>M'tuez-pas !");
                s = s.Replace("Aaaaaah!", "Aaaaaah !");
                s = s.Replace("Has, <E003 10><E342>has the bird learnt to mimic <E003 10><E025 1><E046>the last words of\r\ncondemned men?!", "Le...<E003 10><E342> l'oiseau a-t-il appris à imiter <E003 10><E025 1><E046>les dernières paroles\r\ndes condamnés à mort ?!");
                s = s.Replace("Dinnae-kill-me!<E003 20>\r\n<E607>Lemme-oot!", "M'tuez-pas !<E003 20>\r\n<E607>Laissez-m'sortir !");
                s = s.Replace("What a terrible thing to teach a parrot!<E003 12>\r\n<E025 1><E346>This is animal cruelty, <E003 8>surely?!", "Quelle abomination à apprendre à un perroquet !<E003 12>\r\n<E025 1><E346>C'est de la cruauté envers les animaux !");
                s = s.Replace("Nay, <E049><E003 8>nay.<E049><E003 10> It's not like that at all, <E049><E003 6>Jimmy.", "Mais non, <E049><E003 8>mais non.<E049><E003 10> C'est point ça du tout, <E049><E003 6>gamin.");
                s = s.Replace("That wee fellow's mimicking my mother-in-law.<E049><E003 10>\r\n<E145 127 71><E118 127 1.3><E139 127>She's a terrible one for squawking and squabbling.", "Ce p'tiot piaf imite ma belle-mère.<E049><E003 10>\r\n<E145 127 71><E118 127 1.3><E139 127>Elle passe son temps à piailler et à faire des histoires.");
                s = s.Replace("Oh... <E003 10><E025 2><E341>I see.", "Oh... <E003 10><E025 2><E341>Je vois.");
                s = s.Replace("Her pet terrier bit her on the posterior the other day.<E049><E003 12>\r\n<E164 127 72 1 2 6 0 0 1><E118 127 1.3><E139 127>That's what she was screeching.", "Son roquet d'terrier lui a mordu l'postérieur l'aut' jour.<E049><E003 12>\r\n<E164 127 72 1 2 6 0 0 1><E118 127 1.3><E139 127>C'est ça qu'elle braillait.");
                return s;
            };

            // [14] BB\script\output\_sce03_bg0401_0_check_eng#7
            d[@"BB\script\output\_sce03_bg0401_0_check_eng#7"] = (s) => {
                s = s.Replace("Governor Caidin seems to be rather fond of weapons and\r\nmanacles.", "Le gouverneur Caidin semble bien apprécier les armes et\r\nles menottes.");
                s = s.Replace("They're arranged so precisely on the wall...", "Elles sont disposées avec tant de soin sur le mur...");
                s = s.Replace("Aye, <E049><E003 8>they are that.<E049><E003 12> <E025 2>I'm a great believer in strict discipline.", "Ouais, <E049><E003 8>c'est bien vrai.<E049><E003 12> <E025 2>J'suis un grand partisan d'une stricte discipline.");
                s = s.Replace("I take no prisoners, <E049><E003 6>Jimmy.<E049><E003 10> <E164 127 71 1 2 6 0 0 1><E118 127 1.3><E139 127>I'm a tough man to get the\r\nbetter of!", "J'fais point d'cadeau, <E049><E003 6>gamin.<E049><E003 10> <E164 127 71 1 2 6 0 0 1><E118 127 1.3><E139 127>Faut s'lever d'bonne heure pour m'faire plier !");
                s = s.Replace("Strict discipline... <E003 8><E025 2>It must be exhausting to be around someone\r\nlike that all day, <E003 6>don't you think?", "Une stricte discipline... <E003 8><E025 2>Ce doit être épuisant d'être auprès de\r\nquelqu'un comme ça toute la journée, <E003 6>non ?");
                s = s.Replace("Yes, <E003 8>I imagine it might be.", "Oui, <E003 8>j'imagine que ça doit l'être.");
                s = s.Replace("(And yet...)", "(Et pourtant...)");
                s = s.Replace("(...this man seems to be enjoying tea and biscuits as he\r\ntalks about it.)", "(...cet homme a l'air de savourer son thé et ses biscuits tout\r\nen racontant tout ça.)");
                return s;
            };

            // [15] BB\script\output\_sce03_bg0401_0_check_eng#8
            d[@"BB\script\output\_sce03_bg0401_0_check_eng#8"] = (s) => {
                s = s.Replace("Ah, <E003 8>look, <E003 8><E025 2>we have an opportunity here now,<E003 6> while the\r\ngovernor is away...", "Ah, <E003 8>regardez, <E003 8><E025 2>l'occasion se présente à nous,<E003 6> pendant que\r\nle gouverneur est absent...");
                s = s.Replace("Mr Naruhodo!<E049><E003 12> <E025 1><E346>You could be imprisoned if you were\r\ncaught!", "M. Naruhodo !<E049><E003 12> <E025 1><E346>Vous pourriez être jeté en prison si on vous\r\nprenait !");
                s = s.Replace("(That's a good point.<E003 8> <E025 2>Perhaps not, then.)", "(C'est bien vrai.<E003 8> <E025 2>Peut-être pas, alors.)");
                return s;
            };

            // [16] BB\script\output\_sce03_bg0402_0_check_eng#13
            d[@"BB\script\output\_sce03_bg0402_0_check_eng#13"] = (s) => {
                s = s.Replace("There's really no question, <E003 6>is there?", "Il n'y a vraiment aucun doute, <E003 6>n'est-ce pas ?");
                s = s.Replace("It's the same woman we met only this morning!<E049><E003 4>\r\n<E025 1><E164 3 87 1 2 8 0 2 1><E149 3 4 4><E139 3>It's definitely Mrs Vigil!", "C'est la même femme que nous avons rencontrée ce matin !<E049><E003 4>\r\n<E025 1><E164 3 87 1 2 8 0 2 1><E149 3 4 4><E139 3>C'est assurément Mme Vigil !");
                s = s.Replace("A little younger-looking, perhaps, <E049><E003 6>but still...", "Un peu plus jeune peut-être, <E049><E003 6>mais tout de même...");
                s = s.Replace("Aha!<E003 12> <E025 1><E335>Perhaps she has a younger sister who looks just like\r\nher or something!", "Aha !<E003 12> <E025 1><E335>Elle a peut-être une sœur cadette qui lui ressemble comme\r\ndeux gouttes d'eau !");
                s = s.Replace("But the photograph does appear to be rather old,<E049><E003 6> doesn't\r\nit?", "Mais la photo semble être assez ancienne,<E049><E003 6> ne trouvez-vous\r\npas ?");
                s = s.Replace("And anyway, <E049><E003 6>the question remains:<E049><E003 10> <E025 3><E330>why would something\r\nlike this be in here?", "Et de toute façon, <E049><E003 6>la question demeure :<E049><E003 10> <E025 3><E330>que ferait une\r\ntelle photo ici ?");
                s = s.Replace("You're right, <E003 10><E025 2>the question does remain.", "Vous avez raison, <E003 10><E025 2>la question demeure.");
                s = s.Replace("And <E146 3 68>I remain as stumped as I ever was by it...", "Et <E146 3 68>je reste tout aussi perplexe qu'avant...");
                return s;
            };

            // [17] BB\script\output\_sce03_bg0402_0_check_eng#16
            d[@"BB\script\output\_sce03_bg0402_0_check_eng#16"] = (s) => {
                s = s.Replace("Um, <E003 8><E025 2>excuse me...", "Euh, <E003 8><E025 2>excusez-moi...");
                s = s.Replace("Oh, <E049><E003 10><E025 3>Inspector<E025 7>...<E049><E003 12>\r\n<E025 4><E341>Ohhh, <E049><E003 10><E025 3><E342>sir<E025 7>...", "Oh, <E049><E003 10><E025 3>Inspecteur<E025 7>...<E049><E003 12>\r\n<E025 4><E341>Ohhh, <E049><E003 10><E025 3><E342>patron<E025 7>...");
                s = s.Replace("(Poor man.<E003 10> He can't possibly be able to focus on\r\ninvestigating when he's so upset.)", "(Pauvre homme.<E003 10> Impossible pour lui de se concentrer sur\r\nl'enquête dans un tel état.)");
                return s;
            };

            // [18] BB\script\output\_sce03_bg0402_0_check_eng#17
            d[@"BB\script\output\_sce03_bg0402_0_check_eng#17"] = (s) => {
                s = s.Replace("Um, <E003 8><E025 2>excuse me...", "Euh, <E003 8><E025 2>excusez-moi...");
                s = s.Replace("Sorry, <E003 4>sir.<E049><E003 10> Can't see a thing, <E003 4>sir.<E049><E003 10>\r\n<E025 3><E239>Too many tears, <E003 4>sir.", "Désolé, <E003 4>m'sieur.<E049><E003 10> J'vois rien du tout, <E003 4>m'sieur.<E049><E003 10>\r\n<E025 3><E239>Trop de larmes dans les yeux, <E003 4>m'sieur.");
                s = s.Replace("(Right.<E003 8> Perhaps I'd better leave you to your work, then...)", "(Je vois.<E003 8> Je ferais mieux de vous laisser travailler...)");
                return s;
            };

            // [19] BB\script\output\_sce03_bg0402_1_00_eng#6
            d[@"BB\script\output\_sce03_bg0402_1_00_eng#6"] = (s) => {
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Room on Fresno Street", "2 novembre\r\n<CNTR><E003 5>Chambre de Fresno Street");
                return s;
            };

            // [20] BB\script\output\_sce03_c000_0010_eng#3
            d[@"BB\script\output\_sce03_c000_0010_eng#3"] = (s) => {
                s = s.Replace("Guilty!", "Coupable !");
                return s;
            };

            // [21] BB\script\output\_sce03_c000_0010_eng#5
            d[@"BB\script\output\_sce03_c000_0010_eng#5"] = (s) => {
                s = s.Replace("Well, <E049><E003 8>all those passport checks and luggage searches at\r\nthe border took rather a lot of time.", "Eh bien, <E049><E003 8>tous ces contrôles de passeports et fouilles de bagages\r\nà la frontière ont pris pas mal de temps.");
                s = s.Replace("I must say, <E049><E003 8>I'm very envious of your ministerial status.<E049><E003 12>\r\n<E145 46 65><E118 46 0.7><E025 3>You didn't have to go through any of that, <E049><E003 6>did you?", "Je dois dire <E049><E003 8>que j'envie votre statut ministériel.<E049><E003 12>\r\n<E145 46 65><E118 46 0.7><E025 3>Vous n'avez pas eu à subir tout cela, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("Ah, <E003 10><E341><E025 2>I knew you were jealous!<E049><E003 15>\r\n<E025 1><E145 47 68><E149 47 0 0><E169 47 0><E045>Hah <E003 9>hah <E003 9>hah <E003 9>hah <E003 9>hah!<E169 47 3>", "Ah, <E003 10><E341><E025 2>je savais que vous étiez jaloux !<E049><E003 15>\r\n<E025 1><E145 47 68><E149 47 0 0><E169 47 0><E045>Hah <E003 9>hah <E003 9>hah <E003 9>hah <E003 9>hah !<E169 47 3>");
                return s;
            };

            // [22] BB\script\output\_sce03_c001_0020_eng#3
            d[@"BB\script\output\_sce03_c001_0020_eng#3"] = (s) => {
                s = s.Replace("I don't-a do it any more!", "J'le f'rai plus jamais !");
                return s;
            };

            // [23] BB\script\output\_sce03_c001_0020_eng#5
            d[@"BB\script\output\_sce03_c001_0020_eng#5"] = (s) => {
                s = s.Replace("Right, <E049><E003 8>you two.<E049><E003 8> Yer comin' wiv me now.<E003 10>\r\nDown to the clink.", "Bien, <E049><E003 8>vous deux.<E049><E003 8> Vous v'nez avec moi maint'nant.<E003 10>\r\nDirection l'trou.");
                s = s.Replace("No!<E003 14> Not in prison!<E003 10>\r\n<E160 81><E003 4><E025 1><E607>It is dark and damp and I don't-a like it!<E169 81 3>", "Non !<E003 14> Pas en prison !<E003 10>\r\n<E160 81><E003 4><E025 1><E607>C'est tout noir et humide et j'aime pas ça !<E169 81 3>");
                s = s.Replace("Bof!<E049><E003 4><E145 122 64><E003 6> <E025 3>Ze darkness, <E049><E003 8><E025 2>it is my friend.<E049><E003 8>\r\n<E145 80 70><E003 8><E333>I am not scared!", "Bof !<E049><E003 4><E145 122 64><E003 6> <E025 3>L'obscurité, <E049><E003 8><E025 2>c'est mon amie.<E049><E003 8>\r\n<E145 80 70><E003 8><E333>Moi, j'ai pas peur !");
                return s;
            };

            // [24] BB\script\output\_sce03_chr010_00_eng#9
            d[@"BB\script\output\_sce03_chr010_00_eng#9"] = (s) => {
                s = s.Replace("‘To the Red-Headed League’...<E049><E003 8> <E145 19 66><E144 19><E025 2>The advertisement\r\ncertainly draws one's attention, <E049><E003 6>wouldn't you agree?", "« À la Ligue des Rouquins »...<E049><E003 8> <E145 19 66><E144 19><E025 2>L'annonce attire\r\nassurément l'œil, <E049><E003 6>n'êtes-vous pas d'accord ?");
                s = s.Replace("It does.<E003 10> <E025 2>Although the best I could do to fit in would be\r\nsome lipstick, <E003 6>I think.<E145 19 64>", "Tout à fait.<E003 10> <E025 2>Même si le mieux que je pourrais faire pour\r\ny entrer serait un peu de rouge à lèvres, <E003 6>je crois.<E145 19 64>");
                s = s.Replace("You should partake yourself, <E049><E003 6>Mr Naruhodo!", "Vous devriez y participer vous-même, <E049><E003 6>M. Naruhodo !");
                s = s.Replace("‘To the Caught Red-Handed League’...<E003 12>\r\n<E025 2>What do you think?", "« À la Ligue des Pris la Main dans le Sac »...<E003 12>\r\n<E025 2>Qu'en pensez-vous ?");
                s = s.Replace("As a defence lawyer, <E049><E003 8>it could be an excellent way to net\r\nmore clients.", "En tant qu'avocat de la défense, <E049><E003 8>ce serait une excellente façon\r\nde trouver plus de clients.");
                s = s.Replace("Yeees...<E003 8><E025 3>I can think of two problems.", "Ouiii...<E003 8><E025 3>je vois deux petits problèmes.");
                s = s.Replace("Oh?<E049><E003 10> <E025 2>Pray tell...", "Ah ?<E049><E003 10> <E025 2>Dites toujours...");
                s = s.Replace("Well firstly, <E003 10><E025 2><E330>all of these new clients would therefore be\r\ncriminals.", "D'abord, <E003 10><E025 2><E330>tous ces nouveaux clients seraient donc\r\ndes criminels.");
                s = s.Replace("And secondly, <E003 8><E025 2>I would have to pay each of them<E003 6> <E043>four\r\npounds a week.", "Et ensuite, <E003 8><E025 2>je devrais verser à chacun<E003 6> <E043>quatre livres\r\npar semaine.");
                s = s.Replace("Well, one gets nothing for free in this life,<E049><E003 6> Mr Naruhodo.<E003 12>\r\n<E025 1>You should know that!", "Eh bien, rien n'est gratuit en ce bas monde,<E049><E003 6> M. Naruhodo.<E003 12>\r\n<E025 1>Vous devriez le savoir !");
                return s;
            };

            // [25] BB\script\output\_sce03_chr010_00_eng#10
            d[@"BB\script\output\_sce03_chr010_00_eng#10"] = (s) => {
                s = s.Replace("Erm, <E003 8>Mr Sholmes, <E003 10><E025 3>about this...", "Hum, <E003 8>M. Sholmes, <E003 10><E025 3>à propos de ceci...");
                s = s.Replace("...Tell me, <E049><E003 8>Mr Naruhodo.<E049><E003 12> <E025 2><E330>Is this the first time you've\r\nshown me this particular trinket?", "...Dites-moi, <E049><E003 8>M. Naruhodo.<E049><E003 12> <E025 2><E330>Est-ce la première fois que vous\r\nme présentez cette babiole ?");
                s = s.Replace("Oh!<E003 10> <E025 3><E341>Um...<E003 12><E025 2>I don't really <E145 19 64>remember, <E003 6>to be honest.", "Oh !<E003 10> <E025 3><E341>Euh...<E003 12><E025 2>je ne m'en <E145 19 64>souviens plus très bien, pour être franc.");
                s = s.Replace("I thought as much.<E049><E003 12> <E164 19 70 1 2 5 0 2 1><E139 19><E025 1>It is not!<E049><E003 12>\r\n<E025 2>You have already shown it to me multiple times.", "C'est bien ce que je pensais.<E049><E003 12> <E164 19 70 1 2 5 0 2 1><E139 19><E025 1>Ce n'est pas le cas !<E049><E003 12>\r\n<E025 2>Vous me l'avez déjà montrée à plusieurs reprises.");
                s = s.Replace("And on each occasion, <E049><E003 6><E145 19 66><E003 6><E025 2>I gave you the very same answer:<E049><E003 10>\r\n<E025 3>‘I am not interested’.", "Et à chaque fois, <E049><E003 6><E145 19 66><E003 6><E025 2>je vous ai fait exactement la même réponse :<E049><E003 10>\r\n<E025 3>« Cela ne m'intéresse pas ».");
                s = s.Replace("(...I could have sworn he said something quite different\r\nlast time...)", "(...J'aurais juré qu'il avait dit tout autre chose la dernière\r\nfois...)");
                return s;
            };
        }
    }
}
