using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct3 {
    public partial class Program {
        public static void RegisterPart1() {
            // BB\script\output\_sce02_bg0200_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0200_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0200_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0200_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("Oh!<E003 10> I've just had a great idea!", "Oh !<E003 10> Je viens d'avoir une idée géniale !");
                s = s.Replace("What is it?", "De quoi s'agit-il ?");
                s = s.Replace("We could hide inside these suits of armour <E049><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>and spy on the\r\nfob watch master to find out <E006>what he's really like<E005>!",
                              "On pourrait se cacher dans ces armures <E049><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>et espionner le\r\nmaître à la montre à gousset pour découvrir <E006>ce qu'il mijote vraiment<E005> !");
                s = s.Replace("I don't have much interest in what Lord Stronghart is\r\n‘really like’, though.",
                              "Je ne suis pas particulièrement curieux de savoir ce que\r\nLord Caine est « vraiment », cela dit.");
                s = s.Replace("Oh, <E003 8>please!<E049><E003 12> <E341>It would be fun!<E049><E003 12>\r\n<E025 2>You could be inside the left one, <E049><E003 6>and I'll go in the right!",
                              "Oh, <E003 8>s'il te plaît !<E049><E003 12> <E341>Ce serait amusant !<E049><E003 12>\r\n<E025 2>Tu serais dans celle de gauche, <E049><E003 6>et moi dans celle de droite !");
                s = s.Replace("...You really want to have a go in a suit of armour, <E003 6>don't\r\nyou?",
                              "... Tu as juste très envie d'essayer une armure, <E003 6>n'est-ce\r\npas ?");
                s = s.Replace("Hmph!<E003 10> <E025 2>Now you're making fun of me because I'm a child,<E049><E003 8>\r\naren't you?",
                              "Pff !<E003 10> <E025 2>Tu te moques de moi parce que je suis une enfant,<E049><E003 8>\r\nc'est ça ?");
                s = s.Replace("(I wasn't making fun of you at all.<E003 10>\r\n<E025 3>I'd like to have a go, too...)",
                              "(Je ne me moquais pas du tout d'elle.<E003 10>\r\n<E025 3>Moi aussi, j'aimerais bien en essayer une...)");
                return s;
            };

            // BB\script\output\_sce02_bg0200_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0200_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("You couldn't read all these books even if you were\r\nreincarnated three times over!<E003 8> As a bookworm!",
                              "On ne pourrait pas lire tous ces livres même en étant\r\nréincarné trois fois !<E003 8> En tant que rat de bibliothèque !");
                s = s.Replace("Oh, I know!<E003 8> So much reading material!<E003 10>\r\nI'm very envious.",
                              "Oh, je sais !<E003 8> Tant de lecture !<E003 10>\r\nJe suis très jalouse.");
                s = s.Replace("I've really been running out of things to read recently.",
                              "Je commence vraiment à être à court de lectures récemment.");
                s = s.Replace("That's because you read so fast!",
                              "C'est parce que tu lis à une vitesse folle !");
                s = s.Replace("Perhaps little by little I could swap some of the books\r\nhere with some of mine from home.",
                              "Peut-être que petit à petit je pourrais échanger certains\r\nlivres d'ici avec des miens de la maison.");
                s = s.Replace("I don't see why not.",
                              "Je ne vois pas ce qui t'en empêcherait.");
                s = s.Replace("No one would notice.<E003 10> Or at least, I wouldn't.<E003 8> Even if I was\r\nreincarnated three times over as a librarian.",
                              "Personne ne le remarquerait.<E003 10> Ou du moins, pas moi.<E003 8> Même si\r\nje me réincarnais trois fois en bibliothécaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0200_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0200_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("The cogs of the giant clock are keeping time as usual with\r\ntheir steady, <E003 6>rhythmical motion...",
                              "Les engrenages de l'horloge géante égrènent le temps comme\r\ntoujours, avec leur mouvement régulier et <E003 6>rythmé...");
                s = s.Replace("It's really quite disturbing how little sound they make\r\nconsidering their massive size.",
                              "C'est assez déconcertant de voir à quel point ils font peu de\r\nbruit vu leur taille monumentale.");
                s = s.Replace("Someone very brilliant must have designed it.<E049><E003 10>\r\nAnd whoever maintains it must be very talented, too.",
                              "Quelqu'un de très brillant a dû la concevoir.<E049><E003 10>\r\nEt la personne qui l'entretient doit être tout aussi douée.");
                s = s.Replace("But I'm not entirely convinced it's even a clock.",
                              "Mais je ne suis pas tout à fait convaincue qu'il s'agisse\r\nvraiment d'une horloge.");
                s = s.Replace("What?!<E003 12> <E025 2>But what about the huge clockface that forms the\r\nwindow over there?",
                              "Quoi ?!<E003 12> <E025 2>Mais qu'en est-il de l'immense cadran qui sert de\r\nvitrail là-bas ?");
                s = s.Replace("Some people just make machines that move for the fun of\r\nit.<E049><E003 8> Because they enjoy watching them.",
                              "Certaines personnes construisent des machines juste pour le\r\nplaisir du mouvement.<E049><E003 8> Parce qu'elles aiment les regarder.");
                s = s.Replace("Rather like how Hurley makes his rambling deductions\r\njust for the fun of it.",
                              "Un peu comme Sherlockinou et ses déductions farfelues qu'il\r\npond juste pour s'amuser.");
                s = s.Replace("Even if the outcome isn't quite right.",
                              "Même si le résultat final tombe souvent à côté.");
                s = s.Replace("(Never mind all the trouble it gets others into along the\r\nway...)",
                              "(Sans parler de tous les ennuis que cela cause aux autres\r\nen cours de route...)");
                return s;
            };

            // BB\script\output\_sce02_bg0200_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0200_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("The Lord Chief Justice's desk.<E003 10> When you look at that,<E003 8>\r\nthere's no mistaking Lord Stronghart's authority, <E003 6>is there?",
                              "Le bureau du Premier ministre de la Justice.<E003 10> En le voyant,<E003 8>\r\nimpossible de douter de l'autorité de Lord Caine, <E003 6>n'est-ce pas ?");
                s = s.Replace("But the light from that window behind is far too bright.<E049><E003 10>\r\n<E145 110 71><E118 110 1.2><E330>It would be very bad for the eyes.",
                              "Mais la lumière de cette verrière derrière est bien trop vive.<E049><E003 10>\r\n<E145 110 71><E118 110 1.2><E330>Ce doit être très mauvais pour les yeux.");
                s = s.Replace("I, <E003 8><E341>I hadn't thought of that.<E049><E003 10>\r\n<E145 110 64><E003 4>There are no curtains, <E003 6>that's for sure!",
                              "Je... <E003 8><E341>je n'y avais pas pensé.<E049><E003 10>\r\n<E145 110 64><E003 4>Il n'y a pas de rideaux, <E003 6>c'est certain !");
                s = s.Replace("What's more important, <E049><E003 6><E025 2><E164 110 66 1 2 6 0 0 1><E139 110>having a desk with an air of\r\nauthority, <E003 6>or having eyes that work?",
                              "Qu'est-ce qui compte le plus : <E049><E003 6><E025 2><E164 110 66 1 2 6 0 0 1><E139 110>avoir un bureau qui en\r\nimpose, <E003 6>ou préserver sa vue ?");
                s = s.Replace("...I can't say I'd ever considered it.",
                              "... Je ne me suis jamais posé la question.");
                s = s.Replace("(After all, <E003 10><E025 2>my little office barely has any light to speak of...<E003 10>\r\nand I haven't really seen my desk in a while.)",
                              "(Après tout, <E003 10><E025 2>mon petit cabinet n'a pour ainsi dire aucune\r\nlumière...<E003 10> et je n'ai pas vu mon bureau depuis un bail.)");
                return s;
            };

            // BB\script\output\_sce02_bg0200_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0200_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0200_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0200_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("These very European suits of armour<E003 4> are still glaring at\r\neach other across the carpet, I see.",
                              "Ces armures typiquement européennes<E003 4> continuent de se toiser\r\nd'un bout à l'autre du tapis, à ce que je vois.");
                s = s.Replace("In a way,<E003 4> they feel like guardians of the Lord Chief\r\nJustice's office.",
                              "D'une certaine façon,<E003 4> on dirait les gardiennes du bureau\r\ndu Premier ministre de la Justice.");
                s = s.Replace("I suppose...<E003 10><E145 3 78><E003 7><E333><E025 2>they're rather like the lion-dogs that guard\r\nshrines in Japan,<E003 6> aren't they?",
                              "J'imagine que...<E003 10><E145 3 78><E003 7><E333><E025 2> c'est un peu comme les chiens-lions qui gardent\r\nles sanctuaires au Japon,<E003 6> n'est-ce pas ?");
                s = s.Replace("...Aren't they a bit too human to be called <E145 3 64>‘lion-dogs’?",
                              "... Ne sont-elles pas un peu trop humaines pour être qualifiées de\r\n<E145 3 64>« chiens-lions » ?");
                s = s.Replace("Did you know that it's a dream of mine<E003 6> to keep two cats\r\none day?",
                              "Saviez-vous que mon rêve<E003 6> serait d'adopter deux chats un jour ?");
                s = s.Replace("I feel as though we've gone off at a bit of a tangent,<E003 8> don't\r\nyou?",
                              "J'ai l'impression que nous nous éloignons un peu du sujet,<E003 8>\r\nvous ne trouvez pas ?");
                return s;
            };

            // BB\script\output\_sce02_bg0200_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0200_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("You couldn't read all of these books<E003 6> even if you were\r\nreincarnated six times over as a bookworm!",
                              "On ne pourrait pas lire tous ces livres,<E003 6> même réincarné six\r\nfois de suite en rat de bibliothèque !");
                s = s.Replace("(Can Lord Stronghart really have read all of these?)",
                              "(Lord Caine a-t-il réellement pu lire tout cela ?)");
                s = s.Replace("Thinking about it...<E003 10><E025 2>Father's study is full of books that look\r\nas though they've never been read, too.",
                              "En y repensant...<E003 10><E025 2> le bureau de mon père est également rempli\r\nde livres qui n'ont manifestement jamais été ouverts.");
                s = s.Replace("Oh, really?", "Oh, vraiment ?");
                s = s.Replace("Pedlars of books are forever pushing their wares on him,\r\nyou see.",
                              "Les marchands ambulants viennent sans cesse lui vanter leurs\r\nouvrages, vous comprenez.");
                s = s.Replace("And I think he's just too kind-hearted to refuse them.",
                              "Et je crois qu'il a le cœur trop tendre pour les refuser.");
                s = s.Replace("There's a phrase for that in Britain.<E003 8> People would say<E003 8>\r\n<E025 3>they ‘saw him coming’.",
                              "Il y a une expression pour ça ici.<E003 8> On dirait qu'ils l'ont<E003 8>\r\n<E025 3>« vu venir gros comme une maison ».");
                s = s.Replace("It makes me wonder if perhaps<E003 4> the vast number of books\r\non the shelves in here...",
                              "Je me demande si<E003 4> cette impressionnante collection de livres\r\nsur ces étagères...");
                s = s.Replace("...are a sign of Lord Stronghart's overwhelming\r\n<E006>kind-heartedness<E005>.",
                              "... ne serait pas le signe de la prodigieuse <E006>générosité de cœur<E005>\r\nde Lord Caine.");
                s = s.Replace("...I'm not sure you could afford to have a kind heart<E003 6> <E341><E330>if you\r\nhad to keep Lord van Zieks in line, could you?",
                              "... Je doute qu'on puisse se permettre d'avoir un cœur tendre<E003 6> <E341><E330>si\r\nl'on doit garder Lord Van Peers au pas, vous ne croyez pas ?");
                return s;
            };

            // BB\script\output\_sce02_bg0200_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0200_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("As ever,<E003 6> the enormous clock is diligently maintaining its\r\nrhythmical tick-tock today.",
                              "Comme toujours,<E003 6> l'énorme horloge bat fidèlement la mesure\r\naujourd'hui de son tic-tac cadencé.");
                s = s.Replace("Watching machinery at work can be quite mesmerising,\r\ncan't it?<E049><E003 12> Ironically,<E003 6> you can completely forget the time.",
                              "Observer de tels mécanismes peut être fascinant, n'est-ce\r\npas ?<E049><E003 12> Ironiquement,<E003 6> on en perd toute notion du temps.");
                s = s.Replace("What I particularly enjoy<E003 4> is watching the enormous\r\nwheels of a steam locomotive turning.",
                              "Ce qui me plaît particulièrement,<E003 4> c'est de regarder tourner les\r\nroues colossales d'une locomotive à vapeur.");
                s = s.Replace("When I was a little girl,<E049><E003 8> Grandmother often used to take\r\nme to watch the railway engines, you know.",
                              "Quand j'étais petite,<E049><E003 8> ma grand-mère m'emmenait souvent voir les\r\ntrains en gare, vous savez.");
                s = s.Replace("It's an open fire for me.<E003 10> I could sit and watch the flames\r\nfor hours.",
                              "Moi, c'est le feu de cheminée.<E003 10> Je pourrais contempler les\r\nflammes pendant des heures.");
                s = s.Replace("Mr Naruhodo!<E003 14> We could install one in the office!",
                              "Mr Naruhodo !<E003 14> On pourrait en installer une au cabinet !");
                s = s.Replace("An enormous wheel,<E049><E003 4> <E164 3 87 1 2 8 0 1 1><E139 3><E025 1>turned by an enormous steam\r\nengine!",
                              "Une énorme roue,<E049><E003 4> <E164 3 87 1 2 8 0 1 1><E139 3><E025 1>entraînée par une puissante\r\nmachine à vapeur !");
                s = s.Replace("...Perhaps we could start with a simple fireplace?",
                              "... Peut-être pourrions-nous commencer par une simple cheminée ?");
                return s;
            };

            // BB\script\output\_sce02_bg0200_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0200_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("Just sitting behind that desk must make you feel so\r\nimportant,<E003 6> don't you think?",
                              "Rien que de s'asseoir derrière ce bureau, on doit se sentir\r\nsi important,<E003 6> vous ne trouvez pas ?");
                s = s.Replace("Would you like to have an office like this, Mr Naruhodo?<E049><E003 10>\r\nWith such a grand desk?",
                              "Aimeriez-vous avoir un cabinet pareil, Mr Naruhodo ?<E049><E003 10>\r\nAvec une table si majestueuse ?");
                s = s.Replace("Who, me?<E003 12> <E341>No...<E003 10><E025 2>I don't think so.",
                              "Qui, moi ?<E003 12> <E341>Non...<E003 10><E025 2> je ne crois pas.");
                s = s.Replace("Well,<E003 10> imagine if you suddenly found yourself needing the\r\ntoilet.<E003 12> <E025 1><E331><E342><E145 3 67>You'd have so far to go!",
                              "Eh bien,<E003 10> imaginez que vous ayez une envie pressante soudaine.<E003 12>\r\n<E025 1><E331><E342><E145 3 67>Il y aurait tant de chemin à parcourir !");
                s = s.Replace("How...<E003 8>true.", "C'est...<E003 8> bien vrai.");
                s = s.Replace("Perhaps the important people who work in ostentatious\r\noffices like this<E003 6> haven't considered such things.",
                              "Peut-être que les hauts dignitaires qui travaillent dans des\r\npalais ostentatoires<E003 6> ne pensent pas à ce genre de détail.");
                s = s.Replace("(...I'm going to take that as a compliment.)",
                              "(... Je vais prendre ça pour un compliment.)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("Every time I look at that machine, <E003 8>I can't help thinking\r\nwhat a monstrosity it is.<E003 8> <E025 2>What's it called again?",
                              "Chaque fois que je vois cette machine, <E003 8>je ne peux m'empêcher\r\nde penser à quel point c'est un monstre.<E003 8> <E025 2>Comment s'appelle-t-elle déjà ?");
                s = s.Replace("The Great Analytiscope!<E049><E003 6>\r\n<E164 4 68 1 2 6 0 0 1><E139 4>It can analyse absolutely anything, you know!",
                              "Le Grand Analytiscope !<E049><E003 6>\r\n<E164 4 68 1 2 6 0 0 1><E139 4>Il peut absolument tout analyser, tu sais !");
                s = s.Replace("It does seem incredible.<E003 8><E145 4 64>\r\n<E025 3>...And at the same time, <E003 8>incredibly useless.",
                              "C'est vrai que ça paraît incroyable.<E003 8><E145 4 64>\r\n<E025 3>... Et en même temps, <E003 8>incroyablement inutile.");
                s = s.Replace("Ah, <E049><E003 8><E025 2>but it looks impressive, <E049><E003 8>doesn't it?<E049><E003 10>\r\nSo that makes it very useful.",
                              "Ah, <E049><E003 8><E025 2>mais il en jette plein la vue, <E049><E003 8>non ?<E049><E003 10>\r\nCe qui le rend extrêmement utile !");
                s = s.Replace("How does that make it useful?", "En quoi est-ce que ça le rend utile ?");
                s = s.Replace("Because!<E049><E003 12> It means you can pawn it for lots of money!",
                              "Parce que !<E049><E003 12> Ça veut dire qu'on peut en tirer un bon prix au mont-de-piété !");
                s = s.Replace("The pawnbrokers always make idle remarks like<E003 10> <E025 3>‘What\r\nan incredible-looking machine...’",
                              "Les prêteurs sur gages disent toujours des choses du genre :<E003 10>\r\n<E025 3>« Quelle machine impressionnante... »");
                s = s.Replace("So Hurley often takes it to the pawn shop when he's a\r\nlittle short.",
                              "Du coup, Sherlockinou l'amène souvent chez le prêteur quand\r\nil est un peu à court d'argent.");
                s = s.Replace("(It sounds like this thing pulls its weight around here more\r\nthan I realised...<E003 10><E025 3>by having its weight pulled around.)",
                              "(On dirait bien que cet engin pèse son poids dans le budget...<E003 10><E025 3>\r\nsurtout quand on doit le trimballer là-bas.)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Ah yes, <E003 8>Mr Sholmes's faithful musical companion.<E003 10>\r\nWasn't this violin made by somebody famous?",
                              "Ah oui, <E003 8>le fidèle compagnon musical de Mr Holmes.<E003 10>\r\nCe violon n'a-t-il pas été fabriqué par quelqu'un de célèbre ?");
                s = s.Replace("Yes, <E049><E003 8>it's a Stradivarius.", "Oui, <E049><E003 8>c'est un Stradivarius.");
                s = s.Replace("I'm afraid you'd <E164 4 71 1 2 7 0 0 1>have to save up for <E139 4>a hundred years\r\nbefore you could afford one, Runo.",
                              "J'ai bien peur qu'il te faille <E164 4 71 1 2 7 0 0 1>économiser pendant <E139 4>cent ans\r\navant de pouvoir t'en offrir un, Nicky.");
                s = s.Replace("If I were to save up for a hundred years, <E003 8>I wouldn't\r\nchoose to buy a violin, <E003 8><E025 3>personally.",
                              "Si je devais économiser pendant cent ans, <E003 8>je ne choisirais pas\r\nd'acheter un violon, <E003 8><E025 3>personnellement.");
                s = s.Replace("Oh?<E049><E003 8> <E025 2>What would you buy then?",
                              "Ah ?<E049><E003 8> <E025 2>Qu'est-ce que tu achèterais alors ?");
                s = s.Replace("I really have no idea.<E003 8> <E025 2><E145 4 71><E239>I think I'll have to do it so I can find\r\nout...",
                              "Je n'en ai absolument aucune idée.<E003 8> <E025 2><E145 4 71><E239>Il faudrait que j'essaie\r\npour le savoir...");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Books,<E003 8> papers,<E003 8> scientific implements...<E003 10>\r\n<E025 2>These shelves are stuffed to the gunnels.",
                              "Des livres,<E003 8> des papiers,<E003 8> du matériel scientifique...<E003 10>\r\n<E025 2>Ces étagères sont pleines à craquer.");
                s = s.Replace("Miss Susato wouldn't be able to help herself if she were\r\nhere.<E003 10> She can't stand mess.",
                              "Mademoiselle Susato n'y tiendrait pas si elle était là.<E003 10>\r\nElle ne supporte pas le désordre.");
                s = s.Replace("Susie might not be able to stand mess,<E003 4> but she wouldn't\r\ndare touch those shelves.",
                              "Susato ne supporte peut-être pas le bazar,<E003 4> mais elle n'oserait\r\njamais toucher à ces étagères.");
                s = s.Replace("Oh?<E003 10> <E025 2>Why not?", "Ah oui ?<E003 10> <E025 2>Pourquoi donc ?");
                s = s.Replace("Everything's in intricate balance.<E003 10> Hurley spends ages on\r\nit.",
                              "Tout repose sur un équilibre très subtil.<E003 10> Sherlockinou y passe\r\ndes heures entières.");
                s = s.Replace("If you were to touch even one thing,<E003 6> the whole lot would\r\ncome tumbling down.",
                              "Si tu touchais au moindre objet,<E003 6> tout s'effondrerait dans un\r\nfracas épouvantable.");
                s = s.Replace("Susie noticed it was a very delicate arrangement<E049><E003 4> <E145 4 77><E139 4><E333>right\r\nfrom the outset.",
                              "Susato a tout de suite vu qu'il s'agissait d'un agencement très\r\ndélicat,<E049><E003 4> <E145 4 77><E139 4><E333>dès le premier regard.");
                s = s.Replace("...You make it sound like a meeting of great minds.",
                              "... On dirait une communion d'esprits supérieurs.");
                s = s.Replace("But the truth is,<E003 6> <E330>Mr Sholmes just needs to tidy up.",
                              "Mais en réalité,<E003 6> <E330>Mr Holmes a juste besoin de faire un bon\r\ngrand ménage.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("Ah yes,<E003 6> the huge metal chest with the lace cloth laid on it,<E003 4>\r\nbeing used as a table for tea and coffee.",
                              "Ah oui,<E003 6> cette grosse malle en métal recouverte d'une nappe en dentelle,<E003 4>\r\nqui fait office de table pour le thé et le café.");
                s = s.Replace("It's very sturdy,<E003 4> that's for sure.<E003 10> And firmly locked shut.",
                              "Elle est solide,<E003 4> c'est certain.<E003 10> Et fermée à double tour.");
                s = s.Replace("That chest contains my father's detailed records<E003 6> of\r\nHurley's many cases!",
                              "Cette malle renferme les dossiers détaillés de mon père<E003 6> sur les\r\ninnombrables affaires de Sherlockinou !");
                s = s.Replace("Yes,<E003 8> <E025 2>so I've been led to believe.<E003 10>\r\nThough personally,<E003 4> I've never actually seen inside.",
                              "Oui,<E003 8> <E025 2>c'est ce qu'on m'a dit.<E003 10>\r\nBien que personnellement,<E003 4> je n'aie jamais pu voir l'intérieur.");
                s = s.Replace("And that's the way it will stay!<E049><E003 10> <E330>Those papers are a secret\r\nbetween Daddy and me.",
                              "Et ça ne changera pas !<E049><E003 10> <E330>Ces dossiers sont un secret\r\nentre Papa et moi.");
                s = s.Replace("If you go opening it uninvited,<E049><E003 4> <E164 4 67 1 2 8 0 2 1><E139 4>you might find yourself\r\nbeing bitten!",
                              "Si tu l'ouvres sans y être invité,<E049><E003 4> <E164 4 67 1 2 8 0 2 1><E139 4>tu pourrais bien te faire\r\nmordre !");
                s = s.Replace("(What,<E003 8> <E025 2>is there a beast inside there, or something?)",
                              "(Quoi ?<E003 8> <E025 2>Il y a une bête féroce là-dedans ou quoi ?)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("I do love a good fire in the colder months.",
                              "J'adore un bon feu de cheminée durant les mois froids.");
                s = s.Replace("Watching the flames flickering and dancing about is just\r\nso very relaxing.",
                              "Regarder les flammes danser et vaciller est tellement\r\napaisant.");
                s = s.Replace("Cleaning out the chimney isn't so relaxing, though.",
                              "Ramoner la cheminée n'est pas aussi reposant, par contre.");
                s = s.Replace("No.<E003 10> <E025 2>Getting covered in soot isn't my idea of fun.",
                              "Non.<E003 10> <E025 2>Se couvrir de suie n'est pas franchement ma tasse de thé.");
                s = s.Replace("You know, <E003 8>Hurley decided he was going to clean it out\r\nhimself last year.",
                              "Tu sais, <E003 8>Sherlockinou a décidé de la nettoyer lui-même\r\nl'année dernière.");
                s = s.Replace("But you can guess what happened, <E049><E003 6>can't you?<E049><E003 10>\r\n<E025 3>He got himself stuck inside the flue.",
                              "Mais tu devines ce qui s'est passé, <E049><E003 6>n'est-ce pas ?<E049><E003 10>\r\n<E025 3>Il s'est coincé dans le conduit.");
                s = s.Replace("He's a very slim man, <E003 8>I admit, <E003 10><E025 2><E331>but there are limits to\r\nwhere a fully grown man can fit.",
                              "Il est svelte, <E003 8>j'en conviens, <E003 10><E025 2><E331>mais il y a des limites à l'espace\r\ndans lequel un adulte peut se faufiler.");
                s = s.Replace("Now every time he dozes off by the fire, <E049><E003 8>he has\r\nnightmares about it.",
                              "Maintenant, chaque fois qu'il s'assoupit près de l'âtre, <E049><E003 8>il\r\nen fait des cauchemars.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Ah, <E003 8><E025 2>all these different pieces of evidence from cases that\r\nMr Sholmes has solved are very interesting...",
                              "Ah, <E003 8><E025 2>toutes ces différentes pièces à conviction provenant des affaires\r\nrésolues par Mr Holmes sont fascinantes...");
                s = s.Replace("The trouble is, <E049><E003 8><E025 2>Hurley forgets things so quickly.<E049><E003 12>\r\nHe never remembers why these things are relevant.",
                              "Le souci, c'est que <E049><E003 8><E025 2>Sherlockinou oublie vite.<E049><E003 12>\r\nIl ne se souvient jamais de leur importance.");
                s = s.Replace("The other day, for example, <E049><E003 8>he saw the orange pips that\r\nwere there and decided to plant them in the garden.",
                              "L'autre jour par exemple, <E049><E003 8>il a vu des pépins d'orange qui traînaient\r\net a décidé de les planter dans le jardin.");
                s = s.Replace("Pips?", "Des pépins ?");
                s = s.Replace("Yes.<E003 8> They've all sprouted now.<E049><E003 10>\r\nWe have five new little plants.",
                              "Oui.<E003 8> Ils ont déjà germé.<E049><E003 10>\r\nNous avons cinq petites pousses toutes neuves.");
                s = s.Replace("Oh, <E003 8><E025 2>well I don't know what case they were from, <E003 8><E025 3>but...",
                              "Oh, <E003 8><E025 2>eh bien j'ignore de quelle affaire ils provenaient, <E003 8><E025 3>mais...");
                s = s.Replace("...if Mr Sholmes can get oranges to grow outside in\r\nEngland, <E003 8><E025 2><E333>he should change his profession!",
                              "... si Mr Holmes arrive à faire pousser des orangers dehors en\r\nAngleterre, <E003 8><E025 2><E333>il devrait changer de métier !");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("I look forward to finding out what aroma your tea will\r\nhave, Iris.<E003 8> Every single day.",
                              "J'ai hâte de découvrir l'arôme de ton thé, Iris.<E003 8> Chaque jour qui passe.");
                s = s.Replace("Ah,<E003 4> well,<E003 8> I infuse a different concoction of herbs from the\r\ngarden every time,<E003 4> so it's never the same twice.",
                              "Ah,<E003 4> eh bien,<E003 8> j'infuse une concoction d'herbes du jardin\r\ndifférente à chaque fois,<E003 4> ce n'est jamais le même mélange.");
                s = s.Replace("When you call it a ‘concoction’<E003 6> it sounds more like a\r\nscience experiment than something for teatime.",
                              "Quand tu appelles ça une « concoction »,<E003 6> ça ressemble plus à\r\nune expérience de chimie qu'à un goûter.");
                s = s.Replace("Oh yes!<E003 10> That's because different blends can have very\r\ndifferent properties!",
                              "Tout à fait !<E003 10> C'est parce que chaque mélange a des propriétés\r\ntrès variées !");
                s = s.Replace("Some calm you down,<E003 8> some make you feel jolly,<E003 8> some\r\ngive you energy...",
                              "Certains apaisent,<E003 8> d'autres rendent joyeux,<E003 8> d'autres\r\nencore donnent de l'énergie...");
                s = s.Replace("Today's particular blend is something quite special,<E003 8> so\r\nyou're really in for a treat!",
                              "Le mélange d'aujourd'hui est très spécial,<E003 8> tu vas te régaler !");
                s = s.Replace("(That sounds...<E003 8>ominous...)",
                              "(Ça a l'air...<E003 8> de mauvais augure...)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I can type with my eyes shut, you know.",
                              "Je peux taper les yeux fermés, tu sais.");
                s = s.Replace("I can believe it.<E003 12> When a deadline's approaching,<E003 4> you\r\nsound like a Gatling gun!",
                              "Je veux bien te croire.<E003 12> Quand une date limite approche,<E003 4> on\r\ndirait une mitrailleuse Gatling !");
                s = s.Replace("That reminds me of a dream I had the other day.<E003 8>\r\nIt was such a funny one!<E049><E003 10> It woke me,<E003 4> actually.",
                              "Ça me rappelle un rêve que j'ai fait l'autre jour.<E003 8>\r\nC'était tellement drôle !<E049><E003 10> Ça m'a réveillée,<E003 4> en fait.");
                s = s.Replace("I was typing for a whole hour in the pitch-black,<E003 6> but I\r\ndidn't make a single mistake!",
                              "Je tapais pendant une heure entière dans le noir complet,<E003 6>\r\nsans faire la moindre faute de frappe !");
                s = s.Replace("That's incredible!", "C'est incroyable !");
                s = s.Replace("But then,<E003 10> <E025 2>when it got light...<E003 8><E025 3><E145 4 73><E003 20><E239>I found that there wasn't any\r\npaper in the machine.",
                              "Mais ensuite,<E003 10> <E025 2>quand le jour s'est levé...<E003 8><E025 3><E145 4 73><E003 20><E239>je me suis rendu\r\ncompte qu'il n'y avait pas de feuille dans la machine.");
                s = s.Replace("Now I wonder if I'd actually been typing at all...",
                              "Du coup, je me demande si j'ai vraiment tapé quelque chose...");
                s = s.Replace("...I think you might just have fallen asleep on the job.",
                              "... Je crois que tu t'étais tout simplement endormie au travail.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("(There are so many different bottles up there on that\r\ncharming little set of white shelves.)",
                              "(Il y a tellement de fioles différentes sur cette charmante\r\npetite étagère blanche.)");
                s = s.Replace("Oh!<E003 12> Do be careful, Runo!<E003 10> You mustn't try the contents of\r\nany of those bottles,<E003 6> <E335>even if you're hungry!",
                              "Oh !<E003 12> Fais attention, Nicky !<E003 10> Ne bois surtout rien de ce qu'il\r\ny a là-dedans,<E003 6> <E335>même si tu as une petite faim !");
                s = s.Replace("I wouldn't do something stupid like that!<E003 10>\r\nI'm not a child, you know.",
                              "Je ne ferais jamais une bêtise pareille !<E003 10>\r\nJe ne suis pas un enfant, voyons.");
                s = s.Replace("Well, I wish I could say the same for Hurley.<E003 12> The other\r\nday,<E003 8> <E330>he polished off a full bottle of one of my alkaloids.",
                              "Eh bien, j'aimerais pouvoir en dire autant de Sherlockinou.<E003 12>\r\nL'autre jour,<E003 8> <E330>il s'est sifflé une fiole entière d'alcaloïdes.");
                s = s.Replace("He what?", "Il a fait quoi ?!");
                s = s.Replace("He said he was hungry.", "Il a dit qu'il avait un petit creux.");
                s = s.Replace("...I'll...<E003 8>be extra careful.", "... Je ferai...<E003 8> doublement attention.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_0_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0204_0_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("Ah yes,<E003 8> this is where you note down ideas,<E003 6> isn't it, Iris?",
                              "Ah oui,<E003 8> c'est là que tu griffonnes tes idées,<E003 6> n'est-ce pas, Iris ?");
                s = s.Replace("What's in the melting pot today?<E003 14>\r\n<E025 3>Hm,<E003 10> <E330>‘The Blue Carbuncle’...?",
                              "Qu'as-tu sur le feu aujourd'hui ?<E003 14>\r\n<E025 3>Hmm,<E003 10> <E330>« L'Escarboucle bleue »... ?");
                s = s.Replace("Yes,<E003 6> it's from a case of theft that Hurley solved ages ago.<E003 8>\r\nThe theft of a precious stone.",
                              "Oui,<E003 6> ça vient d'une affaire de vol résolue par Sherlockinou il y a longtemps.<E003 8>\r\nLe vol d'une pierre précieuse.");
                s = s.Replace("A carbuncle is another name for a garnet, you see.<E003 8>\r\nEspecially if it's cut with a rounded top.",
                              "Une escarboucle est un autre nom pour un grenat, tu vois.<E003 8>\r\nSurtout quand il est taillé en cabochon arrondi.");
                s = s.Replace("Oh,<E003 6> really?<E003 12> And this garnet was blue, was it?",
                              "Oh,<E003 6> vraiment ?<E003 12> Et ce grenat était bleu ?");
                s = s.Replace("Well, that's the thing...<E003 10> They're usually red.<E003 12>\r\n<E330>No blue garnets have ever been discovered.",
                              "Eh bien, c'est là tout le mystère...<E003 10> Ils sont d'ordinaire rouges.<E003 12>\r\n<E330>On n'a jamais découvert de grenat bleu.");
                s = s.Replace("So who knows what the stolen gemstone actually was.",
                              "Alors qui sait quelle était vraiment la pierre volée ?");
                s = s.Replace("That's the real mystery of the case.",
                              "C'est la véritable énigme de cette affaire.");
                s = s.Replace("...A proper Herlock Sholmes conundrum,<E003 8> huh?",
                              "... Une véritable énigme digne d'Herlock Sholmes,<E003 8> hein ?");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_00_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_00_eng#4"] = en => {
                string s = en;
                s = s.Replace("23rd October\r\n<CNTR><E003 5>Sholmes's Suite", "23 octobre\r\n<CNTR><E003 5>Appartement de Holmes");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("I've finally managed to remember this behemoth's name.<E003 14>\r\n<E025 3><E333>The Great Analytiscope.",
                              "J'ai enfin réussi à retenir le nom de ce mastodonte.<E003 14>\r\n<E025 3><E333>Le Grand Analytiscope.");
                s = s.Replace("I don't think it was here when I left for Japan, was it?",
                              "Je ne crois pas qu'il était là quand je suis partie pour le Japon, n'est-ce pas ?");
                s = s.Replace("Oh, <E003 8>is that right?", "Oh, <E003 8>vraiment ?");
                s = s.Replace("Yes,<E003 10> <E025 2>because it was with the pawnbroker.",
                              "Oui,<E003 10> <E025 2>parce qu'il était chez le prêteur sur gages.");
                s = s.Replace("Ah, <E003 8><E025 2>of course...", "Ah, <E003 8><E025 2>évidemment...");
                s = s.Replace("Oh!<E003 10> <E341>That's given me a wonderful idea!",
                              "Oh !<E003 10> <E341>Ça me donne une merveilleuse idée !");
                s = s.Replace("I could pawn everything that's on your desk!<E049><E003 10>\r\n<E025 2>The office would be tidy at last!",
                              "Je pourrais gager tout ce qui traîne sur votre bureau !<E049><E003 10>\r\n<E025 2>Le cabinet serait enfin rangé !");
                s = s.Replace("Don't even joke about it, Miss Susato.<E003 18>\r\n<E025 3>...You are joking...<E003 8>aren't you?",
                              "Ne plaisantez même pas avec ça, Mlle Susato.<E003 18>\r\n<E025 3>... Vous plaisantez... <E003 8>n'est-ce pas ?");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("This is Mr Sholmes's famous violin.", "Voici le célèbre violon de Mr Holmes.");
                s = s.Replace("The one he found being sold for a song at a pawnbrokery.<E003 10>\r\nWhat's it called again?<E003 8> A ‘Shodi-<E003 6>something’...",
                              "Celui qu'il a acheté pour une bouchée de pain chez un prêteur.<E003 10>\r\nComment ça s'appelle déjà ?<E003 8> Un « Stradé... »<E003 6> enfin un truc du genre...");
                s = s.Replace("Oh yes,<E003 8> this wonderful instrument features in ‘The\r\nAdventures of Herlock Sholmes’.",
                              "Oh oui,<E003 8> cet instrument merveilleux apparaît dans « Les\r\naventures d'Herlock Sholmes ».");
                s = s.Replace("It's a world-famous<E049><E003 4> <E164 3 87 1 2 5 0 2 1><E149 3 4 4><E139 3><E025 1>Stradivarius!",
                              "C'est un mondialement célèbre<E049><E003 4> <E164 3 87 1 2 5 0 2 1><E149 3 4 4><E139 3><E025 1>Stradivarius !");
                s = s.Replace("Stradi...<E003 8>what?", "Stradi...<E003 8> quoi ?");
                s = s.Replace("Stradivarius,<E003 8> <E025 2><E341>Mr Naruhodo.",
                              "Stradivarius,<E003 8> <E025 2><E341>Mr Naruhodo.");
                s = s.Replace("Stragi...<E003 14> <E025 4><E341>Stragivor...",
                              "Stragi...<E003 14> <E025 4><E341>Stragivoire...");
                s = s.Replace("...Are you even trying now?", "... Est-ce que vous essayez au moins ?");
                s = s.Replace("We'll come back to this another time, I think.",
                              "Nous reviendrons là-dessus plus tard, je pense.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("There's all sorts on these shelves:<E003 8> chemistry apparatus,<E003 8>\r\nbooks,<E003 8> papers<E003 10> <E025 3>and...<E003 12>lots of things I've never seen before.",
                              "Il y a de tout sur ces étagères :<E003 8> de la verrerie de chimie,<E003 8>\r\ndes livres,<E003 8> des papiers<E003 10> <E025 3>et...<E003 12> un tas de choses que je n'avais jamais vues.");
                s = s.Replace("It's all heaped up so high,<E003 6> I can't help feeling that the\r\nwhole lot is going to topple at any moment.",
                              "C'est empilé si haut<E003 6> que j'ai l'impression que tout va\r\ns'écrouler d'une seconde à l'autre.");
                s = s.Replace("It looks as though it might topple,<E003 4> and yet it doesn't.<E049><E003 12>\r\nThe epitome of Mr Sholmes's brilliance!",
                              "On a l'impression que ça va s'écrouler,<E003 4> et pourtant non.<E049><E003 12>\r\nLa preuve par excellence du génie de Mr Holmes !");
                s = s.Replace("...I don't get it.", "... Je ne vois pas le rapport.");
                s = s.Replace("As it happens,<E003 8> I'm quite well practised when it comes to\r\nstacking shelves myself.",
                              "Il se trouve que<E003 8> je m'y connais plutôt bien quand il s'agit\r\nd'empiler des affaires sur mes propres étagères.");
                s = s.Replace("Just the other day,<E003 6> the shelf in my office finally gave way\r\nunder the strain, though.",
                              "Mais pas plus tard que l'autre jour,<E003 6> l'étagère de mon cabinet\r\na fini par céder sous le poids.");
                s = s.Replace("It looks as though it might topple,<E003 4> and it does.<E049><E003 16>\r\n<E333>Yes,<E003 8> the epitome of your disarray!",
                              "On a l'impression que ça va s'écrouler,<E003 4> et ça s'écroule.<E049><E003 16>\r\n<E333>Oui,<E003 8> la preuve par excellence de votre désorganisation !");
                s = s.Replace("...I really<E003 8> don't get it.", "... Là non plus,<E003 8> je ne vois pas le rapport.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("My eye is always drawn to this big metal chest that\r\nMr Sholmes and Iris use as a coffee table.",
                              "Mon regard est toujours attiré par cette grande malle en métal\r\nque Mr Holmes et Iris utilisent en guise de table basse.");
                s = s.Replace("Isn't it where Iris keeps her very important papers?",
                              "N'est-ce pas là qu'Iris conserve ses documents les plus précieux ?");
                s = s.Replace("It is.<E003 10> <E025 2><E330>So you'd think that they'd treat it with more care,\r\nreally.",
                              "Tout à fait.<E003 10> <E025 2><E330>Alors on pourrait penser qu'ils en prendraient\r\nun peu plus soin.");
                s = s.Replace("But only the other day,<E003 10> <E333>I saw Mr Sholmes kick it.",
                              "Mais l'autre jour encore,<E003 10> <E333>j'ai vu Mr Holmes lui donner un coup de pied.");
                s = s.Replace("Oh no!", "Oh non !");
                s = s.Replace("I suppose something must have been frustrating him.",
                              "J'imagine que quelque chose devait l'agacer.");
                s = s.Replace("What a shame to mistreat the furniture, though.<E049><E003 8><E146 3 84><E139 3>\r\n<E025 3>Was it damaged?",
                              "Quelle tristesse de maltraiter le mobilier.<E049><E003 8><E146 3 84><E139 3>\r\n<E025 3>A-t-elle été abîmée ?");
                s = s.Replace("The chest was fine,<E003 8> <E145 3 67><E238>but Mr Sholmes was doubled up on\r\nthe floor for almost ten minutes!",
                              "La malle n'a rien eu,<E003 8> <E145 3 67><E238>mais Mr Holmes est resté plié en deux\r\npar terre pendant près de dix minutes !");
                s = s.Replace("Oh dear...<E003 12> That is a painful tale.",
                              "Mon Dieu...<E003 12> C'est une histoire douloureuse.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("I do like this fireplace.<E003 10> It's one of the best things I've seen\r\nsince we arrived in the country, in fact.",
                              "J'aime beaucoup cette cheminée.<E003 10> C'est l'une des meilleures choses\r\nque j'aie vues depuis notre arrivée dans ce pays, à vrai dire.");
                s = s.Replace("Although...<E003 10><E025 2><E333>I do yearn for a Japanese kotatsu.<E003 10> Putting your\r\nlegs under a warm,<E003 4> blanketed table is so comforting.",
                              "Quoique...<E003 10><E025 2><E333> le kotatsu japonais me manque.<E003 10> Glisser ses\r\njambes sous une table chauffante et bien couverte est si réconfortant.");
                s = s.Replace("Do be careful, Mr Naruhodo.<E049><E003 8> Don't mistakenly put your\r\nfeet into the fire,<E003 4> will you?",
                              "Faites bien attention, Mr Naruhodo.<E049><E003 8> N'allez pas mettre par mégarde\r\nvos pieds dans le feu,<E003 4> n'est-ce pas ?");
                s = s.Replace("You'd suffer terrible burns, you know.",
                              "Vous subiriez de terribles brûlures, vous savez.");
                s = s.Replace("(I worry sometimes about how Susato-san sees me...)",
                              "(Je m'inquiète parfois de la façon dont Susato-san me perçoit...)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Ah yes,<E003 8> Mr Sholmes's curious collection of trinkets from\r\nthe various mysteries he's solved.",
                              "Ah oui,<E003 8> la curieuse collection de babioles de Mr Holmes,\r\nprovenant des différents mystères qu'il a résolus.");
                s = s.Replace("It's one of my favourite parts of this room.<E049><E003 8>\r\n<E333>Full of items with such exciting tales to tell!",
                              "C'est l'un de mes recoins préférés dans cette pièce.<E049><E003 8>\r\n<E333>Plein d'objets aux histoires si palpitantes !");
                s = s.Replace("And I do believe<E049> <E160 3><E139 3><E346>he's added to it since I last looked.",
                              "Et je crois bien<E049> <E160 3><E139 3><E346>qu'il l'a encore enrichie depuis la dernière fois.");
                s = s.Replace("Now there's a mysterious pince-nez, <E003 4>a mysterious little\r\nbox, <E003 6>a mysterious horseshoe, <E003 4>a mysterious biscuit...",
                              "Il y a maintenant un mystérieux pince-nez, <E003 4>une mystérieuse petite\r\nboîte, <E003 6>un mystérieux fer à cheval, <E003 4>un mystérieux biscuit...");
                s = s.Replace("I think that last one<E003 6> <E025 2><E330>might just be one of Iris's unfinished\r\nsnacks.",
                              "Je crois que ce dernier<E003 6> <E025 2><E330>n'est rien d'autre qu'un goûter\r\nnon terminé par Iris.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Iris's pretty little tea set is set out beautifully as ever,<E003 8>\r\nlook.",
                              "Le joli service à thé d'Iris est superbement dressé comme\r\ntoujours,<E003 8> regardez.");
                s = s.Replace("Well,<E003 10> <E025 2><E333>it's only by carefully taking care of a tea set that\r\nyou can make good tea.",
                              "Eh bien,<E003 10> <E025 2><E333>ce n'est qu'en prenant grand soin d'un service que\r\nl'on peut préparer un bon thé.");
                s = s.Replace("Is...<E003 10><E330><E025 2>that a roundabout way of telling me I need to tidy my\r\ndesk?",
                              "Est-ce...<E003 10><E330><E025 2> une façon détournée de me dire de ranger mon\r\nbureau ?");
                s = s.Replace("Oh, Mr Naruhodo,<E003 8> you do overthink things at times.",
                              "Oh, Mr Naruhodo,<E003 8> vous vous posez trop de questions par moments.");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("If I've remembered correctly,<E003 4> this large and imposing\r\nlump of iron is called a ‘typewriter’.",
                              "Si ma mémoire est bonne,<E003 4> cet imposant bloc de métal s'appelle\r\nune « machine à écrire ».");
                s = s.Replace("To think that every single one of ‘The Adventures of\r\nHerlock Sholmes’<E049><E003 4> <E145 3 65><E003 10><E346>blossomed from this very machine!",
                              "Dire que chacune des « Aventures d'Herlock Sholmes »<E049><E003 4>\r\n<E145 3 65><E003 10><E346>a fleuri grâce à cette machine-là !");
                s = s.Replace("Ah...<E003 12><E333>it's such a dreamy thought...",
                              "Ah...<E003 12><E333> c'est une pensée si poétique...");
                s = s.Replace("I actually had a go on it the other day.",
                              "J'ai justement essayé de taper dessus l'autre jour.");
                s = s.Replace("The metal bars that move when you hit the keys<E003 4> got all\r\ntangled up somehow<E003 8> and that made Iris angry.",
                              "Les barres métalliques qui bougent en appuyant sur les touches<E003 4>\r\nse sont toutes emmêlées,<E003 8> et ça a mis Iris en colère.");
                s = s.Replace("...you're ruining my dreamy thoughts.<E049><E003 12>\r\nPlease don't do that again.",
                              "... vous gâchez ma rêverie poétique.<E049><E003 12>\r\nNe refaites pas cela, s'il vous plaît.");
                s = s.Replace("(Ugh...<E003 12>now I've made Susato-san angry as well...)",
                              "(Argh...<E003 12> voilà que j'ai énervé Susato-san elle aussi...)");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("That's Iris's wonderful collection of medicines,<E003 6> potions<E003 6> and\r\nchemicals.",
                              "C'est la magnifique collection de remèdes,<E003 6> potions<E003 6> et\r\nproduits chimiques d'Iris.");
                s = s.Replace("Just look at all the little bottles she's squeezed onto the\r\nshelves.",
                              "Regardez toutes ces fioles qu'elle a réussi à caser sur les\r\nétagères.");
                s = s.Replace("Yes,<E003 8> <E330>and there are charming little ribbons tied around the\r\nbottles, too.",
                              "Oui,<E003 8> <E330>et il y a de ravissants petits rubans noués autour des\r\nflacons, en plus.");
                s = s.Replace("But the labels aren't quite so charming,<E003 6> are they?<E003 14>\r\n<E043>This one here reads<E003 4> <E025 3>‘Deadly Poison’.",
                              "Mais les étiquettes ne sont pas aussi charmantes,<E003 6> n'est-ce pas ?<E003 14>\r\n<E043>Celle-ci indique carrément :<E003 4> <E025 3>« Poison Mortel ».");
                s = s.Replace("Oh,<E003 4> I've been so excited about the idea of helping Iris with\r\nher experiments, you know!",
                              "Oh,<E003 4> j'étais si excitée à l'idée d'aider Iris dans ses\r\nexpériences, vous savez !");
                s = s.Replace("Just try to avoid any bottles labelled<E003 6> <E238>‘Deadly Poison’<E003 6> or\r\n‘Highly Explosive’.",
                              "Essayez juste d'éviter tout ce qui porte la mention<E003 6> <E238>« Poison Mortel »<E003 6>\r\nou « Hautement Explosif ».");
                return s;
            };

            // BB\script\output\_sce02_bg0204_1_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0204_1_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("This blackboard is where Iris scribbles down her latest\r\nideas,<E003 4> isn't it?",
                              "Ce tableau noir, c'est là qu'Iris griffonne ses dernières\r\nidées,<E003 4> n'est-ce pas ?");
                s = s.Replace("Let's see...<E003 8> <E025 2>Oh,<E003 6> <E330>she seems to have drawn a lot of little stick\r\nfigures all lined up,<E003 8> look.",
                              "Voyons voir...<E003 8> <E025 2>Oh,<E003 6> <E330>on dirait qu'elle a dessiné plein de bonshommes\r\nallumettes alignés,<E003 8> regardez.");
                s = s.Replace("‘Cheap apples at the market’<E003 10> <E025 2>is what all of them say.",
                              "« Pommes pas chères au marché »,<E003 10> <E025 2>c'est ce qu'ils disent tous.");
                s = s.Replace("What?!<E003 12> <E025 3>The little figures<E003 10> <E025 1><E335>can speak?!",
                              "Quoi ?!<E003 12> <E025 3>Ces petits bonshommes<E003 10> <E025 1><E335>parlent ?!");
                s = s.Replace("All your questions would be answered<E003 4> if only you would\r\nread this month's Randst Magazine.",
                              "Vous auriez réponse à vos questions<E003 4> si seulement vous lisiez\r\nle Randst Magazine de ce mois-ci.");
                s = s.Replace("(...So I'm the only one who can't make any sense of this?)",
                              "(... Je suis donc le seul à n'y rien comprendre ?)");
                return s;
            };
        }
    }
}
