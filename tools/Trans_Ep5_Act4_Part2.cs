using System;

namespace TranslatorEp5Act4 {
    public partial class Program {
        public static void RegisterPart2() {
            // [23] _sce04_bg0503_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#1"] = (en) => {
                string s = en;
                R(ref s, "Nothing particular of note...", "Rien de particulier à signaler...");
                return s;
            };

            // [24] _sce04_bg0503_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#2"] = (en) => {
                string s = en;
                R(ref s, "I've finally managed to remember this behemoth's name.<E003 14>\r\n<E025 3><E333>The Great Analytiscope.", "J'ai enfin réussi à retenir le nom de ce mastodonte.<E003 14>\r\n<E025 3><E333>Le Grand Analytiscope.");
                R(ref s, "I don't think it was here when I left for Japan, was it?", "Je ne crois pas qu'il fût ici quand je suis partie pour le Japon, si ?");
                R(ref s, "Oh, <E003 8>is that right?", "Ah, <E003 8>vraiment ?");
                R(ref s, "Yes,<E003 10> <E025 2>because it was with the pawnbroker.", "Oui,<E003 10> <E025 2>parce qu'il était chez le prêteur sur gages.");
                R(ref s, "Ah, <E003 8><E025 2>of course...", "Ah, <E003 8><E025 2>évidemment...");
                R(ref s, "Oh!<E003 10> <E341>That's given me a wonderful idea!", "Oh !<E003 10> <E341>Cela me donne une idée formidable !");
                R(ref s, "I could pawn everything that's on your desk!<E049><E003 10>\r\n<E025 2>The office would be tidy at last!", "Je pourrais mettre en gage tout ce qui traîne sur votre bureau !<E049><E003 10>\r\n<E025 2>Le cabinet serait enfin bien rangé !");
                R(ref s, "Don't even joke about it, Miss Susato.<E003 18>\r\n<E025 3>...You are joking...<E003 8>aren't you?", "Ne plaisantez même pas avec ça, mademoiselle Susato.<E003 18>\r\n<E025 3>... Vous plaisantez...<E003 8>n'est-ce pas ?");
                return s;
            };

            // [25] _sce04_bg0503_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#3"] = (en) => {
                string s = en;
                R(ref s, "This is Mr Sholmes's famous violin.", "Voici le fameux violon de M. Sholmes.");
                R(ref s, "The one he found being sold for a song at a pawnbrokery.<E003 10>\r\nWhat's it called again?<E003 8> A ‘Shodi-<E003 6>something’...", "Celui qu'il a trouvé pour trois sous chez un prêteur sur gages.<E003 10>\r\nComment ça s'appelle déjà ?<E003 8> Un « Stradé... »<E003 6>ou quelque chose comme ça...");
                R(ref s, "Oh yes,<E003 8> this wonderful instrument features in ‘The\r\nAdventures of Herlock Sholmes’.", "Oh oui,<E003 8> ce merveilleux instrument figure dans « Les\nAventures d'Herlock Sholmes ».");
                R(ref s, "It's a world-famous<E049><E003 4> <E164 3 87 1 2 5 0 2 1><E149 3 4 4><E139 3><E025 1>Stradivarius!", "C'est un célébrissime<E049><E003 4> <E164 3 87 1 2 5 0 2 1><E149 3 4 4><E139 3><E025 1>Stradivarius !");
                R(ref s, "Stradi...<E003 8>what?", "Stradi...<E003 8>quoi ?");
                R(ref s, "Stradivarius,<E003 8> <E025 2><E341>Mr Naruhodo.", "Stradivarius,<E003 8> <E025 2><E341>monsieur Naruhodo.");
                R(ref s, "Stragi...<E003 14> <E025 4><E341>Stragivor...", "Stradi...<E003 14> <E025 4><E341>Stradivor...");
                R(ref s, "...Are you even trying now?", "...Faites-vous seulement un effort ?");
                R(ref s, "We'll come back to this another time, I think.", "Nous y reviendrons une autre fois, je crois.");
                return s;
            };

            // [26] _sce04_bg0503_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#4"] = (en) => {
                string s = en;
                R(ref s, "There's all sorts on these shelves:<E003 8> chemistry apparatus,<E003 8>\r\nbooks,<E003 8> papers<E003 10> <E025 3>and...<E003 12>lots of things I've never seen before.", "Il y a de tout sur ces étagères :<E003 8> de la verrerie de chimie,<E003 8>\ndes livres,<E003 8> des papiers<E003 10> <E025 3>et...<E003 12>des tas de choses inconnues au bataillon.");
                R(ref s, "It's all heaped up so high,<E003 6> I can't help feeling that the\r\nwhole lot is going to topple at any moment.", "Tout est empilé si haut<E003 6> qu'on s'attend à ce que l'ensemble\ns'effondre d'une seconde à l'autre.");
                R(ref s, "It looks as though it might topple,<E003 4> and yet it doesn't.<E049><E003 12>\r\nThe epitome of Mr Sholmes's brilliance!", "On croirait que cela va s'effondrer,<E003 4> et pourtant non.<E049><E003 12>\nL'incarnation suprême du brio de M. Sholmes !");
                R(ref s, "...I don't get it.", "...Je ne comprends pas.");
                R(ref s, "As it happens,<E003 8> I'm quite well practised when it comes to\r\nstacking shelves myself.", "Il se trouve justement<E003 8> que j'ai une certaine pratique pour empiler\ndes affaires sur les étagères, moi aussi.");
                R(ref s, "Just the other day,<E003 6> the shelf in my office finally gave way\r\nunder the strain, though.", "Mais l'autre jour encore,<E003 6> l'étagère de mon bureau a fini par céder\nsous le poids.");
                R(ref s, "It looks as though it might topple,<E003 4> and it does.<E049><E003 16>\r\n<E333>Yes,<E003 8> the epitome of your disarray!", "On croirait que cela va s'effondrer,<E003 4> et cela s'effondre.<E049><E003 16>\r\n<E333>Oui,<E003 8> l'incarnation suprême de votre pagaille !");
                R(ref s, "...I really<E003 8> don't get it.", "...Je ne comprends vraiment<E003 8> pas.");
                return s;
            };

            // [27] _sce04_bg0503_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#5"] = (en) => {
                string s = en;
                R(ref s, "Roast beef, <E003 6>kippers, <E003 6>stew, <E003 6>steak and kidney pie,<E003 6> Yorkshire\r\npudding...", "Rosbif, <E003 6>harengs fumés, <E003 6>ragoût, <E003 6>tourte au bœuf et rognons,<E003 6> Yorkshire\npudding...");
                R(ref s, "It all looks mouth-wateringly good.", "Tout cela met prodigieusement l'eau à la bouche.");
                R(ref s, "Indeed it does!", "En vérité, oui !");
                R(ref s, "And if it were accompanied by even a morsel of pheasant,<E049><E003 8><E025 1>\r\nit would be perfection.", "Et si c'était accompagné ne fût-ce que d'une miette de faisan,<E049><E003 8><E025 1>\nce serait la perfection absolue.");
                R(ref s, "...You're still on that?", "...Vous en êtes encore là ?");
                R(ref s, "Oh, <E049><E003 4><E164 3 75 1 2 8 0 1 1><E139 3><E025 1>it really does look like a feast for celebrating a victory\r\nin court!", "Oh, <E049><E003 4><E164 3 75 1 2 8 0 1 1><E139 3><E025 1>on dirait un banquet dressé pour fêter une victoire\nau tribunal !");
                R(ref s, "Or indeed <E049><E003 10><E333><E025 2>for drowning one's sorrows after defeat.", "Ou bien <E049><E003 10><E333><E025 2>pour noyer son chagrin après une cuisante défaite.");
                R(ref s, "...I hope you weren't referring to the trial tomorrow,<E049><E003 6>\r\nMr Sholmes.", "...J'espère que vous ne parliez pas du procès de demain,<E049><E003 6>\nmonsieur Sholmes.");
                R(ref s, "(He's clearly still in mourning over the pheasant at the\r\nmoment...)", "(Il porte visiblement encore le deuil de son faisan pour le\nmoment...)");
                return s;
            };

            // [28] _sce04_bg0503_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#6"] = (en) => {
                string s = en;
                R(ref s, "I do like this fireplace.<E003 10> It's one of the best things I've seen\r\nsince we arrived in the country, in fact.", "J'aime beaucoup cette cheminée.<E003 10> C'est l'une des meilleures choses que j'aie vues\ndepuis notre arrivée en Angleterre.");
                R(ref s, "Although...<E003 10><E025 2><E333>I do yearn for a Japanese kotatsu.<E003 10> Putting your\r\nlegs under a warm,<E003 4> blanketed table is so comforting.", "Quoique...<E003 10><E025 2><E333>un kotatsu japonais me manque parfois.<E003 10> Glisser ses\njambes sous une table chaude<E003 4> et recouverte d'édredons est si doux.");
                R(ref s, "Do be careful, Mr Naruhodo.<E049><E003 8> Don't mistakenly put your\r\nfeet into the fire,<E003 4> will you?", "Faites bien attention, monsieur Naruhodo.<E049><E003 8> N'allez pas mettre vos pieds\ndans les braises par inadvertance,<E003 4> d'accord ?");
                R(ref s, "You'd suffer terrible burns, you know.", "Vous seriez affreusement brûlé, vous savez.");
                R(ref s, "(I worry sometimes about how Susato-san sees me...)", "(Je me demande parfois comment Susato-san me perçoit...)");
                return s;
            };

            // [29] _sce04_bg0503_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#7"] = (en) => {
                string s = en;
                R(ref s, "Ah yes,<E003 8> Mr Sholmes's curious collection of trinkets from\r\nthe various mysteries he's solved.", "Ah oui,<E003 8> la curieuse collection de bricoles de M. Sholmes issues\ndes diverses énigmes qu'il a élucidées.");
                R(ref s, "It's one of my favourite parts of this room.<E049><E003 8>\r\n<E333>Full of items with such exciting tales to tell!", "C'est l'un de mes coins préférés dans cette pièce.<E049><E003 8>\r\n<E333>Rempli d'objets aux histoires si captivantes !");
                R(ref s, "And I do believe<E049> <E160 3><E139 3><E346>he's added to it since I last looked.", "Et je crois bien<E049> <E160 3><E139 3><E346>qu'il y a ajouté des nouveautés depuis la dernière fois.");
                R(ref s, "Now there's a mysterious pince-nez, <E003 4>a mysterious little\r\nbox, <E003 6>a mysterious horseshoe, <E003 4>a mysterious biscuit...", "Il y a un mystérieux pince-nez, <E003 4>une mystérieuse petite\nboîte, <E003 6>un mystérieux fer à cheval, <E003 4>un mystérieux biscuit...");
                R(ref s, "I think that last one<E003 6> <E025 2><E330>might just be one of Iris's unfinished\r\nsnacks.", "Je pense que ce dernier<E003 6> <E025 2><E330>n'est qu'un biscuit entamé laissé là\npar Iris.");
                return s;
            };

            // [30] _sce04_bg0503_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#8"] = (en) => {
                string s = en;
                R(ref s, "Iris's pretty little tea set is set out beautifully as ever,<E003 8>\r\nlook.", "Le joli petit service à thé d'Iris est superbement dressé comme toujours,<E003 8>\nregardez.");
                R(ref s, "Well,<E003 10> <E025 2><E333>it's only by carefully taking care of a tea set that\r\nyou can make good tea.", "Eh bien,<E003 10> <E025 2><E333>ce n'est qu'en prenant grand soin de son service que\nl'on peut faire du bon thé.");
                R(ref s, "Is...<E003 10><E330><E025 2>that a roundabout way of telling me I need to tidy my\r\ndesk?", "Est-ce...<E003 10><E330><E025 2>une façon détournée de me suggérer de ranger mon\nbureau ?");
                R(ref s, "Oh, Mr Naruhodo,<E003 8> you do overthink things at times.", "Oh, monsieur Naruhodo,<E003 8> vous cherchez toujours trop loin.");
                return s;
            };

            // [31] _sce04_bg0503_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#9"] = (en) => {
                string s = en;
                R(ref s, "If I've remembered correctly,<E003 4> this large and imposing\r\nlump of iron is called a ‘typewriter’.", "Si ma mémoire est bonne,<E003 4> cette lourde machine de fonte\ns'appelle une « machine à écrire ».");
                R(ref s, "To think that every single one of ‘The Adventures of\r\nHerlock Sholmes’<E049><E003 4> <E145 3 65><E003 10><E346>blossomed from this very machine!", "Quand on songe que chaque épisode des « Aventures d'Herlock\nSholmes »<E049><E003 4> <E145 3 65><E003 10><E346>a jailli de cette même machine !");
                R(ref s, "Ah...<E003 12><E333>it's such a dreamy thought...", "Ah...<E003 12><E333>c'est une pensée si enivrante...");
                R(ref s, "I actually had a go on it the other day.", "J'ai essayé d'y pianoter l'autre jour, en vérité.");
                R(ref s, "The metal bars that move when you hit the keys<E003 4> got all\r\ntangled up somehow<E003 8> and that made Iris angry.", "Les tiges métalliques qui frappent les touches<E003 4> se sont toutes\nentremêlées<E003 8> et cela a fâché Iris.");
                R(ref s, "Mr Naruhodo...", "Monsieur Naruhodo...");
                R(ref s, "...you're ruining my dreamy thoughts.<E049><E003 12>\r\n    Please don't do that again.", "...vous brisez toute ma rêverie.<E049><E003 12>\r\n    Ne recommencez pas cela, je vous en conjure.");
                R(ref s, "...you're ruining my dreamy thoughts.<E049><E003 12>\r\nPlease don't do that again.", "...vous brisez toute ma rêverie.<E049><E003 12>\r\nNe recommencez pas cela, je vous en conjure.");
                R(ref s, "(Ugh...<E003 12>now I've made Susato-san angry as well...)", "(Aïe...<E003 12>voilà que j'ai fâché Susato-san à son tour...)");
                return s;
            };

            // [32] _sce04_bg0503_1_check_eng#10
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#10"] = (en) => {
                string s = en;
                R(ref s, "That's Iris's wonderful collection of medicines,<E003 6> potions<E003 6> and\r\nchemicals.", "Voilà la remarquable collection de remèdes,<E003 6> potions<E003 6> et\nproduits chimiques d'Iris.");
                R(ref s, "Just look at all the little bottles she's squeezed onto the\r\nshelves.", "Regardez un peu toutes ces fioles entassées sur les\nétagères.");
                R(ref s, "Yes,<E003 8> <E330>and there are charming little ribbons tied around the\r\nbottles, too.", "Oui,<E003 8> <E330>et il y a de ravissants petits rubans noués autour des\nflacons, aussi.");
                R(ref s, "But the labels aren't quite so charming,<E003 6> are they?<E003 14>\r\n<E043>This one here reads<E003 4> <E025 3>‘Deadly Poison’.", "Mais les étiquettes sont beaucoup moins engageantes,<E003 6> n'est-ce pas ?<E003 14>\r\n<E043>Celle-ci indique<E003 4> <E025 3>« Poison mortel ».");
                R(ref s, "Oh,<E003 4> I've been so excited about the idea of helping Iris with\r\nher experiments, you know!", "Oh,<E003 4> j'étais si impatiente à l'idée d'aider Iris dans\nses expériences, vous savez !");
                R(ref s, "Just try to avoid any bottles labelled<E003 6> <E238>‘Deadly Poison’<E003 6> or\r\n‘Highly Explosive’.", "Tâchez simplement d'éviter tout ce qui est étiqueté<E003 6> <E238>« Poison mortel »<E003 6> ou\n« Hautement explosif ».");
                return s;
            };

            // [33] _sce04_bg0503_1_check_eng#11
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#11"] = (en) => {
                string s = en;
                R(ref s, "This blackboard is where Iris scribbles down her latest\r\nideas,<E003 4> isn't it?", "Ce tableau noir est l'endroit où Iris note ses dernières\nidées au vol,<E003 4> n'est-ce pas ?");
                R(ref s, "Let's see...<E003 8> <E025 2>Oh,<E003 6> <E330>she seems to have drawn a lot of little stick\r\nfigures all lined up,<E003 8> look.", "Voyons voir...<E003 8> <E025 2>Oh,<E003 6> <E330>on dirait qu'elle a dessiné une ribambelle de bonshommes\nallumettes alignés,<E003 8> regardez.");
                R(ref s, "‘Cheap apples at the market’<E003 10> <E025 2>is what all of them say.", "« Pommes bon marché au marché »,<E003 10> <E025 2>voilà ce qu'ils disent tous.");
                R(ref s, "What?!<E003 12> <E025 3>The little figures<E003 10> <E025 1><E335>can speak?!", "Quoi ?!<E003 12> <E025 3>Ces petits bonshommes<E003 10> <E025 1><E335>parlent ?!");
                R(ref s, "All your questions would be answered<E003 4> if only you would\r\nread this month's Randst Magazine.", "Toutes vos questions trouveraient réponse<E003 4> si seulement vous aviez\nlu le Randst Magazine de ce mois-ci.");
                R(ref s, "(...So I'm the only one who can't make any sense of this?)", "(...Alors je suis le seul à n'y rien comprendre ?)");
                return s;
            };

            // [34] _sce04_bg0503_1_check_eng#12
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#12"] = (en) => {
                string s = en;
                R(ref s, "...The mask Kazuma wore when he was assigned to Lord\r\nvan Zieks as his apprentice.", "...Le masque que portait Kazuma lorsqu'il était assigné à Lord\nVan Peers en tant que disciple.");
                R(ref s, "When he cast it aside after the trial the other day,<E003 6> <E025 3>I just\r\nsort of picked it up.", "Lorsqu'il s'en est défait après le procès l'autre jour,<E003 6> <E025 3>je l'ai tout\nsimplement ramassé.");
                R(ref s, "We ought to give it back to him, <E003 4>I suppose.", "Nous devrions le lui rendre, <E003 4>je suppose.");
                R(ref s, "But he has his <E145 3 77><E118 3 0.6>memory back now, <E003 6>doesn't he?", "Mais il a recouvré la <E145 3 77><E118 3 0.6>mémoire à présent, <E003 6>n'est-ce pas ?");
                R(ref s, "And I can't help feeling he might turn around and tell me\r\ncoldly to wear it myself...", "Et je pressens qu'il pourrait bien me répondre d'un ton\nglacial de le porter moi-même...");
                R(ref s, "But...<E049><E003 6><E164 3 84 1 2 42 0 0 1><E139 3>isn't he your best friend?", "Mais...<E049><E003 6><E164 3 84 1 2 42 0 0 1><E139 3>n'est-il pas votre meilleur ami ?");
                return s;
            };

            // [35] _sce04_bg0503_1_check_eng#13
            entryTranslators["BB\\script\\output\\_sce04_bg0503_1_check_eng#13"] = (en) => {
                string s = en;
                R(ref s, "Um, <E003 8>Mr Sholmes...<E003 12><E341>what are you doing?", "Euh, <E003 8>monsieur Sholmes...<E003 12><E341>que faites-vous ?");
                R(ref s, "Surely it's abundantly clear...", "N'est-ce point limpide comme de l'eau de roche...");
                R(ref s, "...that I wasn't brooding over Mikotoba's refusal to share\r\nhis pheasant with me.<E049><E003 10> Nevertheless... ", "...que je ne ruminais point le refus de Mikotoba de partager\nson faisan avec moi.<E049><E003 10> Néanmoins... ");
                R(ref s, "...I felt the need to withdraw from the social circle for a\r\nwhile and look on with hungry eyes.", "...j'ai ressenti le besoin de me retirer du monde un instant\npour contempler l'existence d'un œil affamé.");
                R(ref s, "Haah...", "Haah...");
                R(ref s, "Sorry, Hurley, <E049><E003 14><E025 2>but I cooked that pheasant especially for\r\nSusie's daddy.", "Désolée, Hurley, <E049><E003 14><E025 2>mais j'ai mijoté ce faisan tout spécialement pour\nle papa de Susette.");
                R(ref s, "...Even though I've played the role of father to you for far\r\nlonger...", "...Alors même que j'ai endossé le rôle de père auprès de toi depuis bien plus\nlongtemps...");
                R(ref s, "Um, <E003 8>Mr Sholmes...", "Euh, <E003 8>monsieur Sholmes...");
                R(ref s, "...could I discuss some things with you?", "...puis-je m'entretenir de certaines choses avec vous ?");
                R(ref s, "Certainly, my dear fellow!<E049><E003 12> <E025 2>I find myself quite in the mood\r\nfor a spell of conversation.", "Certainement, mon cher ami !<E049><E003 12> <E025 2>Je me trouve tout à fait disposé\npour un brin de conversation.");
                R(ref s, "No doubt <E049><E003 6><E164 19 79 1 2 8 0 1 1><E139 19><E025 1>you're hungry to learn more of my deep love of\r\ngame!", "Nul doute que <E049><E003 6><E164 19 79 1 2 8 0 1 1><E139 19><E025 1>vous brûlez de découvrir toute l'étendue de ma passion\npour le gibier !");
                R(ref s, "...I can probably contain my curiosity on that one.", "...Je parviendrai sans doute à contenir ma curiosité sur ce point.");
                R(ref s, "You needn't look at me in that fashion.", "Il n'est pas nécessaire de me dévisager de la sorte.");
                R(ref s, "In what fashion?", "De quelle sorte ?");
                R(ref s, "It seems...<E049><E003 12><E025 2>that before we discuss the pheasant, <E049><E003 10><E164 19 70 1 2 8 0 2 1><E139 19>we have\r\nsome rather ‘unpheasant’ matters to discuss.", "Il semble...<E049><E003 12><E025 2>qu'avant d'évoquer le faisan, <E049><E003 10><E164 19 70 1 2 8 0 2 1><E139 19>nous ayons\nquelques questions fort peu « réjouis-faisantes » à élucider.");
                return s;
            };
        }
    }
}
