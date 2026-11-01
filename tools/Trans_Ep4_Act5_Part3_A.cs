using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart3_A() {
            // [91] BB\script\output\_sce03_c203_0040_eng#54
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#54"] = (en) => {
                string s = en;
                s = s.Replace("You were attempting to abscond with that <E006><E570><FONT 2>coffee cup<E571></FONT><E005>!", "Tu tentais de t'éclipser en douce avec cette <E006><E570><FONT 2>tasse de café<E571></FONT><E005> !");
                return s;
            };

            // [92] BB\script\output\_sce03_c203_0040_eng#55
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#55"] = (en) => {
                string s = en;
                s = s.Replace("You were attempting to abscond with that <E007><E570><FONT 2>case file<E571></FONT><E005>!", "Tu tentais de t'éclipser en douce avec ce <E007><E570><FONT 2>dossier d'affaire<E571></FONT><E005> !");
                s = s.Replace("You were attempting to abscond <E003 10><E607><E025 1>with that <E007><E570><FONT 2>case file<E571></FONT><E005>!", "Tu tentais de t'éclipser en douce <E003 10><E607><E025 1>avec ce <E007><E570><FONT 2>dossier d'affaire<E571></FONT><E005> !");
                s = s.Replace("Iris...<E003 12><E025 2>as you know very well...", "Iris...<E003 12><E025 2>comme tu le sais fort bien...");
                s = s.Replace("...nothing escapes <E049><E003 6><E164 19 79 1 2 5 0 3 1><E172 19 -8 -178 15 2 4><E492 19 -178 15 2><E139 19><E526 2 0><E156 4 0 0><E049><E025 1>the attention of a great detective!", "...rien n'échappe <E049><E003 6><E164 19 79 1 2 5 0 3 1><E172 19 -8 -178 15 2 4><E492 19 -178 15 2><E139 19><E526 2 0><E156 4 0 0><E049><E025 1>à l'attention d'un grand détective !");
                s = s.Replace("Oh no...", "Oh non...");
                s = s.Replace("We visited Scotland Yard's autopsy laboratory earlier\r\ntoday.", "Nous nous sommes rendus à la salle d'autopsie de Scotland Yard\r\nplus tôt dans la journée.");
                s = s.Replace("And Dr Gorey informed us...", "Et le Dr Gorey nous a informés...");
                s = s.Replace("...that <E006>the autopsy report<E005> of Klint van Zieks <E049><E003 10><E239><E025 3>had gone\r\nmissing.", "...que <E006>le rapport d'autopsie<E005> de Klint Van Peers <E049><E003 10><E239><E025 3>avait\r\ndisparu.");
                s = s.Replace("Klint van Zieks...<E003 12>\r\n<E169 19 0>Hm, <E003 8><E169 19 3>yes, <E049><E003 8><E025 2>I do seem to recall...", "Klint Van Peers...<E003 12>\r\n<E169 19 0>Hum, <E003 8><E169 19 3>oui, <E049><E003 8><E025 2>il me semble bien me rappeler...");
                s = s.Replace("...that some years ago <E049><E003 8>I asked to see the report in\r\nquestion.<E003 8> <E086 2 16><E490 2 -66.000000 36.000000 -96.000000 8 2><E527 30.000000 147.000000 -120.000000 8 2><E528 0.500000 0.500000 8 2><E462 24.107811 142.562271 -319.833252 8 2><E464 27.380859 131.641724 -111.482697 10 2><E466 48 8 2><E483 -13 8 2><E131>You were with me, <E049><E003 6><E025 3>weren't you, Iris?", "...qu'il y a quelques années, <E049><E003 8>j'avais demandé à consulter le rapport en\r\nquestion.<E003 8> <E086 2 16><E490 2 -66.000000 36.000000 -96.000000 8 2><E527 30.000000 147.000000 -120.000000 8 2><E528 0.500000 0.500000 8 2><E462 24.107811 142.562271 -319.833252 8 2><E464 27.380859 131.641724 -111.482697 10 2><E466 48 8 2><E483 -13 8 2><E131>Tu étais avec moi, <E049><E003 6><E025 3>n'est-ce pas, Iris ?");
                s = s.Replace("I...<E003 12> <E341>I...", "J-...<E003 12> <E341>je...");
                s = s.Replace("You mean...<E003 12><E025 3>it...<E003 12>was you, Iris...?", "Tu veux dire...<E003 12><E025 3>c'était...<E003 12>toi, Iris... ?");
                s = s.Replace("So those papers you have there are...?", "Ces papiers que tu as là sont donc... ?");
                s = s.Replace("I'm sorry...", "Pardon...");
                s = s.Replace("FORGIVE MEEEEEEEEE!", "PARDONNEZ-MOIIIIIIII !");
                return s;
            };

            // [93] BB\script\output\_sce03_c203_0050_eng#6
            entryTranslators[@"BB\script\output\_sce03_c203_0050_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("In truth...", "À vrai dire...");
                s = s.Replace("...I would like to have thought I could have predicted the\r\nbooby-trapped chest.", "...j'aurais aimé croire que j'aurais pu prédire le piège\r\ndisposé dans ce coffre.");
                s = s.Replace("But it caught me completely off guard.<E049><E003 6> <E164 19 71 1 2 6 0 0 1><E149 19 0 0><E139 19>I was very nearly\r\nthe ‘late’ consulting detective Herlock Sholmes.", "Mais il m'a pris complètement au dépourvu.<E049><E003 6> <E164 19 71 1 2 6 0 0 1><E149 19 0 0><E139 19>J'ai bien failli\r\ndevenir le « défunt » détective consultant Herlock Sholmes.");
                s = s.Replace("Ugh...<E003 12><E169 4 3>\r\n<E025 3>I'm sorry, Hurley.", "Ooh...<E003 12><E169 4 3>\r\n<E025 3>Je suis désolée, Hurley.");
                s = s.Replace("So you mean, <E049><E003 10><E060 0 150 0 0><E025 2><E330>this <E006>autopsy report<E005> really is...", "Vous voulez dire que <E049><E003 10><E060 0 150 0 0><E025 2><E330>ce <E006>rapport d'autopsie<E005> est bel et bien...");
                s = s.Replace("Yes, <E049><E003 12><E025 2><E333>I took it from the lab.<E049><E003 8><E145 4 73><E003 8>\r\n<E025 3>Even though I knew it was very important.", "Oui, <E049><E003 12><E025 2><E333>je l'ai pris au laboratoire.<E049><E003 8><E145 4 73><E003 8>\r\n<E025 3>Même si je savais qu'il était très important.");
                s = s.Replace("Was there something in it that troubled you, <E003 4>Iris?", "Y avait-il quelque chose dedans qui te tourmentait, <E003 4>Iris ?");
                s = s.Replace("Not exactly something that troubled me.", "Pas vraiment quelque chose qui me tourmentait.");
                s = s.Replace("Something I'd been looking for.", "Quelque chose que je cherchais depuis longtemps.");
                s = s.Replace("When I saw this report...<E049><E003 15>\r\n<E025 3>When I saw the writing in it...", "Quand j'ai vu ce rapport...<E049><E003 15>\r\n<E025 3>Quand j'ai vu l'écriture dedans...");
                s = s.Replace("...I knew it was Daddy's.", "...j'ai su que c'était celle de Papa.");
                s = s.Replace("The, <E003 8><E025 3><E333><E341>the writing...?", "L'...<E003 8><E025 3><E333><E341>l'écriture... ?");
                s = s.Replace("Your father's writing?<E049><E003 10>\r\n<E025 3>What do you really mean?", "L'écriture de ton père ?<E049><E003 10>\r\n<E025 3>Que veux-tu dire par là ?");
                s = s.Replace("...Iris?<E003 15>\r\n<E025 3><E007>(It must be something that's hard for her to talk about.)", "...Iris ?<E003 15>\r\n<E025 3><E007>(Ce doit être quelque chose dont il lui est difficile de parler.)");
                s = s.Replace("Forgive me for interrupting, <E003 6>my dear fellows...", "Pardonnez-moi de vous interrompre, <E003 6>mes chers amis...");
                s = s.Replace("Mr Sholmes!<E003 10> What is it?", "M. Sholmes !<E003 10> De quoi s'agit-il ?");
                s = s.Replace("I feel as though the poor unconscious gentleman on the\r\nsettee <E003 8><E333>has been <E006>somewhat forgotten<E005>.<E085 2 4>", "J'ai l'impression que le pauvre monsieur évanoui sur le\r\ncanapé <E003 8><E333>a été <E006>quelque peu délaissé<E005>.<E085 2 4>");
                s = s.Replace("AAAH!<E049><E003 16>\r\nF-<E003 8><E335>Father!", "AAAH !<E049><E003 16>\r\nP-...<E003 8><E335>Père !");
                s = s.Replace("Perhaps we should find our guest somewhere more\r\npeaceful to rest?", "Peut-être devrions-nous trouver à notre invité un endroit plus\r\npaisible pour se reposer ?");
                s = s.Replace("Mr Naruhodo!", "M. Naruhodo !");
                s = s.Replace("Would you be so kind as to lend him your bed?<E049><E003 8> We must\r\ndo our very best to make him comfortable,<E003 4> I feel.", "Auriez-vous l'amabilité de lui prêter votre lit ?<E049><E003 8> Nous devons\r\nfaire tout notre possible pour qu'il soit bien installé, <E003 4>je pense.");
                s = s.Replace("Oh...<E003 10>yes, of course.<E003 12> <E025 1><E335>I'll help you carry him up.", "Oh...<E003 10>oui, bien sûr.<E003 12> <E025 1><E335>Je vais vous aider à le monter.");
                s = s.Replace("So will I!", "Moi aussi !");
                s = s.Replace("No no, <E049><E003 8><E025 2>I can manage alone, thank you.<E049><E003 10>\r\nYou have tea to enjoy.", "Non non, <E049><E003 8><E025 2>je peux m'en charger seul, je vous remercie.<E049><E003 10>\r\nVous avez du thé à déguster.");
                s = s.Replace("We wouldn't want Iris's brew to stew.", "Il ne faudrait pas que la décoction d'Iris infuse trop.");
                s = s.Replace("(...Because there's no better way to make the professor\r\ncomfortable<E003 6> than dragging him upstairs like a trunk.)", "(...C'est vrai qu'il n'y a pas meilleur moyen d'installer le professeur à son aise<E003 6> que de le hisser à l'étage comme une malle.)");
                s = s.Replace("I wonder...<E003 10>\r\n<E025 3><E007>(Perhaps that was deliberate.)", "Je me demande...<E003 10>\r\n<E025 3><E007>(C'était peut-être délibéré.)");
                s = s.Replace("(Maybe Mr Sholmes is making himself scarce to give Iris\r\nthe chance to talk more freely...)", "(Peut-être que M. Sholmes s'éclipse pour donner à Iris l'occasion de parler plus librement...)");
                s = s.Replace("We must use this opportunity to talk with Iris...", "Nous devons saisir cette opportunité pour discuter avec Iris...");
                s = s.Replace("...and find out what's going on!", "...et découvrir ce qui se trame !");
                return s;
            };

            // [94] BB\script\output\_sce03_c203_0070_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0070_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I must apologise...<E003 10>Iris.", "Je dois te présenter mes excuses...<E003 10>Iris.");
                s = s.Replace("This is really all my fault.", "C'est en réalité entièrement de ma faute.");
                s = s.Replace("Hurley...?", "Hurley... ?");
                s = s.Replace("I made a promise, <E049><E003 6>you see.<E049><E003 12>\r\n<E025 3>That until the time was right...", "J'ai fait une promesse, <E049><E003 6>vois-tu.<E049><E003 12>\r\n<E025 3>Tant que le moment ne serait pas venu...");
                s = s.Replace("...I'd keep the details about your father a secret.", "...je garderais le secret sur les détails concernant ton père.");
                s = s.Replace("I know...<E049><E003 12>\r\n<E025 3>I've been very naughty.", "Je sais...<E049><E003 12>\r\n<E025 3>J'ai été très vilaine.");
                s = s.Replace("I'll take the autopsy report <E003 4><E164 4 77 1 2 8 0 1 1><E149 4 4 5><E139 4>back to Dr Gorey and\r\napologise, <E049><E003 8>I promise!", "Je rapporterai le rapport d'autopsie <E003 4><E164 4 77 1 2 8 0 1 1><E149 4 4 5><E139 4>au Dr Gorey et\r\nje m'excuserai, <E049><E003 8>c'est promis !");
                s = s.Replace("Yes...<E049><E003 10><E025 2>we'll go together, I think.", "Oui...<E049><E003 10><E025 2>nous irons ensemble, je crois.");
                s = s.Replace("Then...<E049><E003 6><E060 0 143 0 0><E145 3 81><E118 3 1.6><E003 10><E025 3>let me look after it for you until we get there.", "Dans ce cas...<E049><E003 6><E060 0 143 0 0><E145 3 81><E118 3 1.6><E003 10><E025 3>laisse-moi le garder pour toi d'ici là.");
                s = s.Replace("Klint's autopsy report has been\r\nentered into the Court Record.", "Le rapport d'autopsie de Klint a été\r\najouté au dossier de l'affaire.");
                s = s.Replace("I must go and water my herbs, I think!", "Je dois aller arroser mes herbes, je crois !");
                s = s.Replace("I'll see you all later.", "À plus tard tout le monde.");
                s = s.Replace("(Poor Iris...<E003 10> <E025 3>She must be feeling awful.)", "(Pauvre Iris...<E003 10> <E025 3>Elle doit se sentir terriblement mal.)");
                s = s.Replace("(I know Mr Sholmes is here for her, <E003 8>but still...)", "(Je sais que M. Sholmes est là pour elle, <E003 8>mais quand même...)");
                s = s.Replace("Aaaaaah!", "Aaaaaah !");
                s = s.Replace("Wha...?<E003 12> <E338><E342><E025 3>H-<E003 10><E341>How...?", "Quoi... ?<E003 12> <E338><E342><E025 3>C-...<E003 10><E341>Comment... ?");
                s = s.Replace("What's the meaning of this, <E049><E003 10><E346>Mr Sholmes!", "Qu'est-ce que cela signifie, <E049><E003 10><E346>M. Sholmes !");
                s = s.Replace("...Mr Sholmes...?", "...M. Sholmes... ?");
                s = s.Replace("Oh dear me.", "Oh ciel.");
                s = s.Replace("So...<E049><E003 10><E025 2><E145 19 64><E003 23><E239>you've noticed, <E049><E003 6>I see.<E085 0 3>", "Ainsi...<E049><E003 10><E025 2><E145 19 64><E003 23><E239>vous avez remarqué, <E049><E003 6>à ce que je vois.<E085 0 3>");
                s = s.Replace("But...<E049><E003 14>\r\n<E025 3><E338><E342>That, <E049><E003 10><E338><E342>that would mean...", "Mais...<E049><E003 14>\r\n<E025 3><E338><E342>Cela...<E049><E003 10><E338><E342>cela voudrait dire que...");
                s = s.Replace("What on earth's the matter, <E003 6>Miss Susato?<E003 8><E145 3 83><E118 3 0.7><E003 8>\r\n<E025 3>You've turned as white as a sheet.", "Que vous arrive-t-il donc, <E003 6>mademoiselle Susato ?<E003 8><E145 3 83><E118 3 0.7><E003 8>\r\n<E025 3>Vous êtes devenue blanche comme un linge.");
                s = s.Replace("It's this autopsy report, <E049><E003 6>Mr Naruhodo.<E049><E003 12>\r\n<E025 3>The one from ten years ago.", "C'est ce rapport d'autopsie, <E049><E003 6>M. Naruhodo.<E049><E003 12>\r\n<E025 3>Celui d'il y a dix ans.");
                s = s.Replace("The writing...", "L'écriture...");
                s = s.Replace("...isn't Dr Wilson's at all.", "...n'est absolument pas celle du Dr Wilson.");
                s = s.Replace("Huh?<E003 16> Wh-<E003 10><E341>What do you mean?<E003 12>\r\nHow could you possibly know that?", "Hein ?<E003 16> Q-...<E003 10><E341>Que voulez-vous dire ?<E003 12>\r\nComment pourriez-vous savoir une chose pareille ?");
                s = s.Replace("Because!<E049><E003 20>\r\n<E025 1>I know this writing very well!", "Parce que !<E049><E003 20>\r\n<E025 1>Je connais cette écriture par cœur !");
                s = s.Replace("This writing...<E049><E003 15><E025 1><E164 3 87 1 2 5 1 2 1><E149 3 4 4><E139 3>\r\nIt's <E006>my father's<E005>!", "Cette écriture...<E049><E003 15><E025 1><E164 3 87 1 2 5 1 2 1><E149 3 4 4><E139 3>\r\nC'est celle de <E006>mon père<E005> !");
                s = s.Replace("WHAAAAAAAAAT?!<E003 18>\r\n<E025 1><E045>Professor <E338><E342>Mikotoba's?!", "QUOOOOOOOI ?!<E003 18>\r\n<E025 1><E045>Du professeur <E338><E342>Mikotoba ?!<E023>");
                s = s.Replace("Indeed.<E049><E003 10> <E025 3>It's true.", "En effet.<E049><E003 10> <E025 3>C'est exact.");
                s = s.Replace("And...<E049><E003 10>now you know, <E049><E003 15><E025 1><E164 19 70 1 2 8 0 1 1><E139 19>my dear fellows!<E085 1 1>", "Et...<E049><E003 10>maintenant vous savez, <E049><E003 15><E025 1><E164 19 70 1 2 8 0 1 1><E139 19>mes chers amis !<E085 1 1>");
                s = s.Replace("N-<E003 10><E025 1><E606>No!<E003 18>\r\n<E604>I don't know anything!", "N-...<E003 10><E025 1><E606>Non !<E003 18>\r\n<E604>Je ne sais rien du tout !");
                s = s.Replace("What on earth does all of this mean, Mr Sholmes?", "Mais qu'est-ce que tout cela signifie, M. Sholmes ?");
                s = s.Replace("(Because <E006>the idea<E007> that's slowly forming in my mind...)", "(Car <E006>l'idée<E007> qui commence à germer dans mon esprit...)");
                s = s.Replace("(...it's just too extraordinary to believe!)", "(...est tout simplement trop invraisemblable pour être crue !)");
                s = s.Replace("Please!<E003 10> <E338><E341><E025 1>You have to explain!", "De grâce !<E003 10> <E338><E341><E025 1>Vous devez vous expliquer !");
                return s;
            };

            // [95] BB\script\output\_sce03_c203_0090_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0090_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("That's quite enough, <E049><E003 8>my fiery fellows!", "Cela suffit amplement, <E049><E003 8>mes bouillants amis !");
                s = s.Replace("M-<E003 8>Mr Sholmes?<E003 12>\r\n<E341><E025 2><E007>(When did he get all dressed up?)", "M-...<E003 8>M. Sholmes ?<E003 12>\r\n<E341><E025 2><E007>(Quand a-t-il enfilé sa tenue d'extérieur ?)");
                s = s.Replace("Whilst I don't like to interrupt this exciting exploration of\r\nthe past...", "Bien que je répugne à interrompre cette palpitante exploration du passé...");
                s = s.Replace("...Mikotoba and I have an urgent matter that requires a\r\nshort excursion.", "...Mikotoba et moi-même avons une affaire urgente qui exige une courte excursion.");
                s = s.Replace("But it's very late, Mr Sholmes.<E049><E003 6>\r\n<E025 3><E136 3 84 3><E117 3 18><E118 3 0.8><E139 3><E330>Where must you go?", "Mais il se fait très tard, M. Sholmes.<E049><E003 6>\r\n<E025 3><E136 3 84 3><E117 3 18><E118 3 0.8><E139 3><E330>Où devez-vous donc vous rendre ?");
                s = s.Replace("Why, <E049><E003 8>my dear madam, <E049><E003 8>is that not obvious?<E049><E003 15>\r\n<E025 1>My partner and I must pursue our natural enemies!", "Mais voyons, <E049><E003 8>ma chère demoiselle, <E049><E003 8>n'est-ce pas une évidence ?<E049><E003 15>\r\n<E025 1>Mon associé et moi devons poursuivre nos ennemis naturels !");
                s = s.Replace("So, <E049><E003 10><E025 1>get your coat, Mikotoba!<E049><E003 15>\r\n<E025 1><E164 2 70 1 2 8 0 2 0><E139 2><E339>The game is afoot!<E085 2 14>", "Alors, <E049><E003 10><E025 1>prenez votre manteau, Mikotoba !<E049><E003 15>\r\n<E025 1><E164 2 70 1 2 8 0 2 0><E139 2><E339>La partie est lancée !<E085 2 14>");
                s = s.Replace("B-<E049><E003 8>But, Sholmes.<E049><E003 16> <E136 46 70 3><E117 46 15><E003 12><E025 2>I really must give Susato a full\r\nexplanation, <E049><E003 6>I think.", "M-...<E049><E003 8>mais enfin, Sholmes.<E049><E003 16> <E136 46 70 3><E117 46 15><E003 12><E025 2>Je dois vraiment fournir de franches\r\nexplications à Susato, <E049><E003 6>il me semble.");
                s = s.Replace("Later, my dear fellow, <E049><E003 8>later.<E049><E003 10>\r\n<E025 2>Our carriage awaits downstairs already.", "Plus tard, mon cher ami, <E049><E003 8>plus tard.<E049><E003 10>\r\n<E025 2>Notre fiacre nous attend déjà en bas.");
                s = s.Replace("You haven't changed one iota, <E049><E003 6><E025 3>have you?", "Vous n'avez pas changé d'un iota, <E049><E003 6><E025 3>n'est-ce pas ?");
                s = s.Replace("I mean really.<E049><E003 10>\r\n<E025 2>I visit our home after ten long years...", "Non mais sincèrement.<E049><E003 10>\r\n<E025 2>Je reviens dans notre demeure après dix longues années...");
                s = s.Replace("...and when I open that chest in a fit of nostalgia,<E049><E003 10> <E239><E025 3>I quite\r\ninexplicably pass out.", "...et dès que j'ouvre ce coffre dans un élan de nostalgie,<E049><E003 10> <E239><E025 3>je perds\r\nconnaissance de façon totalement inexplicable.");
                s = s.Replace("And as if that wasn't enough, <E049><E003 6>when I eventually regain\r\nconsciousness, <E049><E003 7><E025 1><E145 46 68><E117 46 8><E003 5><E333>I'm plunged straight into all this!", "Et comme si cela ne suffisait pas, <E049><E003 6>lorsque je reprends enfin\r\nmes esprits, <E049><E003 7><E025 1><E145 46 68><E117 46 8><E003 5><E333>je suis plongé la tête la première dans tout ce remue-ménage !");
                s = s.Replace("Father, <E049><E003 8>please...<E049><E003 12><E145 3 81><E118 3 1.5><E149 3 0 1><E003 20><E025 2>go with Mr Sholmes now.", "Père, <E049><E003 8>je vous en prie...<E049><E003 12><E145 3 81><E118 3 1.5><E149 3 0 1><E003 20><E025 2>accompagnez M. Sholmes sans tarder.");
                s = s.Replace("I've no doubt that whatever happened, <E049><E003 8>you were acting\r\nin everyone's best interests.", "Je ne doute pas un seul instant que quoi qu'il se soit passé, <E049><E003 8>vous ayez agi\r\ndans le meilleur intérêt de tous.");
                s = s.Replace("I trust you.<E049><E003 12>\r\n<E025 3>Completely.", "Je vous fais confiance.<E049><E003 12>\r\n<E025 3>Totalement.");
                s = s.Replace("Susato...", "Susato...");
                s = s.Replace("And sending the great detective and his great partner off\r\non renewed adventures together...", "Et voir le grand détective et son brillant associé repartir\r\nensemble vers de nouvelles aventures...");
                s = s.Replace("...is more than I could have hoped for in my wildest\r\ndreams!", "...dépasse de loin tout ce que j'aurais pu espérer dans mes rêves les plus fous !");
                s = s.Replace("Very well, then.<E049><E003 10> We'll speak again later.", "Très bien, alors.<E049><E003 10> Nous reparlerons plus tard.");
                s = s.Replace("So...<E049><E003 8><E145 2 64><E003 10><E025 2>I believe your own work is done for the day.", "Bien...<E049><E003 8><E145 2 64><E003 10><E025 2>je crois que votre propre tâche est accomplie pour aujourd'hui.");
                s = s.Replace("I wish you the best of luck for tomorrow.", "Je vous souhaite la meilleure des chances pour demain.");
                s = s.Replace("Yes, Naruhodo.<E049><E003 13> <E025 3>Good luck in battle.<E049><E003 14>\r\n<E025 2><E333>...And in reaching a decision.", "Oui, Naruhodo.<E049><E003 13> <E025 3>Bon courage pour cette bataille.<E049><E003 14>\r\n<E025 2><E333>...Et pour prendre votre décision.");
                s = s.Replace("(A decision?<E003 16> <E330><E025 2>About whether to go back to Japan,<E003 6><E025 3> I\r\nsuppose...)", "(Une décision ?<E003 16> <E330><E025 2>Sur le fait de rentrer ou non au Japon,<E003 6><E025 3> j'imagine...)");
                s = s.Replace("So much happened that day that I barely\r\n<E042><CNTR>knew <E003 4>what to do <E003 4>with myself.", "Tant de choses se sont produites ce jour-là que je savais\r\n<E042><CNTR>à peine <E003 4>où donner <E003 4>de la tête.");
                s = s.Replace("It would only be later that I'd come to realise...", "Ce n'est que plus tard que je comprendrais...");
                s = s.Replace("...<E025 3>how amidst the chaos I'd unleashed...", "...<E025 3>qu'au milieu du chaos que j'avais déclenché...");
                s = s.Replace("...<E025 3>were all the clues I needed<E003 14>\r\n<E042><CNTR>to finally <E003 8>unearth <E003 6><E025 3>the truth.", "...<E025 3>se trouvaient tous les indices nécessaires<E003 14>\r\n<E042><CNTR>pour enfin <E003 8>faire éclater <E003 6><E025 3>la vérité.");
                s = s.Replace("And that all the turmoil <E003 8><E025 4>was necessary...", "Et que tous ces tourments <E003 8><E025 4>étaient indispensables...");
                s = s.Replace("...<E025 3>to give me the resolve <E003 14>to see <E003 4><E025 4>everything <E003 6>through.", "...<E025 3>pour m'armer de la détermination voulue <E003 14>pour aller <E003 4><E025 4>jusqu'au bout.");
                return s;
            };

            // [96] BB\script\output\_sce03_evidence_eng#0
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#0"] = (en) => {
                string s = en;
                s = s.Replace("I can't find anything out of place.", "Je ne trouve rien d'anormal.");
                return s;
            };

            // [97] BB\script\output\_sce03_evidence_eng#1
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("I'm right in thinking that these scales are a symbol of the\r\ndefence in law,<E003 6> aren't they?", "J'ai raison de penser que cette balance est le symbole de la défense en droit, n'est-ce pas ?");
                s = s.Replace("They're supposed to symbolise treating everything\r\nequally...<E003 6>and fairly.", "Elle est censée symboliser le fait de traiter chaque élément de façon égale... et équitable.");
                s = s.Replace("That's why they're always in the middle,<E003 6> balanced.<E003 12>\r\nEqual measures on both sides.", "C'est pourquoi les plateaux sont toujours au même niveau, en équilibre. Mesure égale des deux côtés.");
                s = s.Replace("Recently though,<E003 6> whenever I see a set of scales,<E003 8> <E330>I can only\r\nthink of the enormous Scales of Justice.", "Ces derniers temps cependant, chaque fois que je vois une balance, je ne peux m'empêcher de penser à la gigantesque Balance de la Justice.");
                s = s.Replace("That's entirely understandable.<E003 8> They are such a powerful\r\nsymbol in the courtroom, aren't they?", "C'est tout à fait compréhensible. C'est un symbole tellement imposant dans la salle d'audience, n'est-ce pas ?");
                s = s.Replace("And the thing about the Scales of Justice is...", "Et ce qu'il y a avec la Balance de la Justice, c'est que...");
                s = s.Replace("...they're always leaning one way or the other.<E003 10>\r\nThey're only ever in balance<E003 6> <E330>right at the start.", "...elle penche toujours d'un côté ou de l'autre. Elle n'est en équilibre qu'au tout début.");
                s = s.Replace("...It must be something peculiar to the British...<E003 14>\r\n<E025 2>I'm afraid I can't shed any light on it,<E003 4> Mr Naruhodo.", "...Ce doit être une particularité britannique... J'ai bien peur de ne pouvoir vous éclairer là-dessus, M. Naruhodo.");
                return s;
            };

            // [98] BB\script\output\_sce03_evidence_eng#2
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("It's very fine embroidery here that shows the name of\r\nthe armband's owner.", "C'est une très fine broderie qui indique le nom du propriétaire de ce brassard.");
                s = s.Replace("In this case...<E003 8><E025 3><E330>Kazuma Asogi.", "En l'occurrence... Kazuma Asogi.");
                s = s.Replace("So I'm always carrying my best friend's hopes and dreams\r\nwith me on my right arm<E003 6> just here.<E003 10> All the time.", "Je porte donc constamment les espoirs et les rêves de mon meilleur ami à mon bras droit, juste ici. En permanence.");
                s = s.Replace("To be honest,<E003 8> <E238>it's something that weighs very heavily on\r\nme.", "Pour être honnête, c'est quelque chose qui pèse très lourd sur mes épaules.");
                s = s.Replace("...Oh,<E003 8> <E025 2>I didn't realise it was such a burden, Mr Naruhodo.", "...Oh, je ne me rendais pas compte que c'était un tel fardeau, M. Naruhodo.");
                s = s.Replace("Yes,<E003 8> <E239>I think it's why my right shoulder aches so much.", "Oui, je crois que c'est pour ça que mon épaule droite me fait si mal.");
                s = s.Replace("Are you sure<E003 10> <E025 2><E333>that's not to do with you reading in bed or\r\nthe like?", "Êtes-vous bien certain que ce n'est pas plutôt lié au fait de lire au lit ou ce genre de chose ?");
                return s;
            };

            // [99] BB\script\output\_sce03_evidence_eng#5
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Professor Mikotoba has wonderful handwriting,<E003 6> doesn't\r\nhe?", "Le professeur Mikotoba a une très belle écriture, n'est-ce pas ?");
                s = s.Replace("‘This dark-suited young man is not in the least bit\r\nuntrustworthy.’", "« Ce jeune homme vêtu de noir n'est pas le moins du monde indigne de confiance. »");
                s = s.Replace("...Is it just me, <E003 6><E043>or does that make me sound extremely\r\nuntrustworthy?", "...Est-ce une impression, ou cela me fait-il passer pour quelqu'un d'extrêmement suspect ?");
                s = s.Replace("I do wish he'd at least called you a ‘nice young man’.", "J'aurais aimé qu'il vous qualifie au moins de « jeune homme charmant ».");
                s = s.Replace("...I'm really not sure that would help.", "...Je ne suis vraiment pas sûr que cela aurait arrangé les choses.");
                return s;
            };

            // [100] BB\script\output\_sce03_evidence_eng#6
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("Oh...<E003 10><E025 2>it looks like this is some sort of <E006>steamship ticket<E005>.", "Oh... il semble que ce soit une sorte de billet de bateau à vapeur.");
                s = s.Replace("‘The SS Grouse<E003 8>\r\nFirst-class cabin <E003 6>001’", "« SS Grouse\r\nCabine de première classe 001 »");
                s = s.Replace("‘Yokohama departure: 11th September<E003 10>\r\nLondon arrival: 1st November’...", "« Départ de Yokohama : 11 septembre\r\nArrivée à Londres : 1er novembre »...");
                s = s.Replace("Ah, <E003 8>that's the boat that Professor Mikotoba and Judge\r\nJigoku came on from Japan, <E003 4>isn't it?", "Ah, c'est le navire sur lequel le professeur Mikotoba et le juge Jigoku sont venus depuis le Japon, n'est-ce pas ?");
                s = s.Replace("Yes, <E003 6>I think it called at Dunkirk on the north coast of\r\nFrance for a night before finally arriving in Dover.", "Oui, je crois qu'il a fait escale à Dunkerque sur la côte nord de la France pour une nuit avant d'arriver enfin à Douvres.");
                s = s.Replace("(To think it's been almost a year since we arrived in\r\nDover on the SS Burya...)", "(Quand je pense que cela fait presque un an que nous sommes arrivés à Douvres à bord du SS Burya...)");
                s = s.Replace("It seems a shame not to keep your ticket as a memento of\r\nyour trip, <E049><E003 6>don't you think?", "C'est dommage de ne pas garder son billet en souvenir du voyage, vous ne trouvez pas ?");
                s = s.Replace("Yes, <E003 6>I agree.<E003 10>\r\nI have mine safely in my diary.", "Oui, je suis bien d'accord. Le mien est soigneusement conservé dans mon journal intime.");
                s = s.Replace("And I keep mine in my wallet, <E003 8>so I have it with me at all\r\ntimes.", "Et moi je garde le mien dans mon portefeuille, pour l'avoir sur moi en permanence.");
                s = s.Replace("...Oh, <E049><E003 8>well how strange!<E003 10>\r\nWhere could it have gone?", "...Oh, mais c'est bien curieux ! Où a-t-il bien pu passer ?");
                s = s.Replace("...Are you like this on purpose, <E003 6>Mr Naruhodo?", "...Le faites-vous exprès, M. Naruhodo ?");
                s = s.Replace("(Did I imagine it, <E003 8><E025 3>or was that comment accompanied by a\r\nlittle sigh?)", "(L'ai-je rêvé, ou cette remarque était-elle accompagnée d'un léger soupir ?)");
                s = s.Replace("The details of the letter of introduction\r\nhave been updated in the Court Record.", "Les détails de la lettre d'introduction ont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            // [101] BB\script\output\_sce03_evidence_eng#7
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("The helmet of this charming policeman appears to be a\r\nlittle worse for wear.", "Le casque de ce charmant agent de police semble avoir connu des jours meilleurs.");
                s = s.Replace("I'm not convinced about the ‘charming’ part, <E003 8>but yes,<E003 8>\r\nyou're right...", "Je ne suis pas convaincu par le côté « charmant », mais oui, vous avez raison...");
                s = s.Replace("...the head part looks like it's been fairly heavily\r\nmanhandled.", "...la tête a l'air d'avoir été plutôt malmenée.");
                s = s.Replace("Almost as if somebody has enjoyed twisting it around\r\nand around for fun.", "Comme si quelqu'un s'était amusé à la tourner et la retourner en boucle.");
                s = s.Replace("Shall we try twisting it around and around, too?<E003 10>\r\n<E025 3>For fun.", "Si nous essayions nous aussi de la tourner et retourner ? Juste pour voir.");
                s = s.Replace("Ah!<E003 16> <E341>What's that?!", "Ah ! Qu'est-ce que c'est que ça ?!");
                s = s.Replace("It...<E003 10><E025 3>appears to be some sort of <E006>key<E005>.", "Cela... semble être une sorte de clé.");
                s = s.Replace("But it's tiny, though!<E003 10> It couldn't be a key for a door.<E003 12>\r\nNot at that size.", "Mais elle est minuscule ! Ce ne peut pas être une clé de porte. Pas avec cette taille.");
                s = s.Replace("(So what is it for, I wonder...?)", "(À quoi sert-elle donc, je me le demande... ?)");
                s = s.Replace("The details of the policeman figurine\r\nhave been updated in the Court Record.", "Les détails de la figurine de policier ont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            // [102] BB\script\output\_sce03_evidence_eng#8
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("The helmet of this charming policeman appears to be a\r\nlittle worse for wear.", "Le casque de ce charmant agent de police semble avoir connu des jours meilleurs.");
                s = s.Replace("I'm not convinced about the ‘charming’ part, <E003 8>but yes,<E003 8> \r\nyou're right...", "Je ne suis pas convaincu par le côté « charmant », mais oui, vous avez raison...");
                s = s.Replace("...the head part looks like it's been fairly heavily\r\nmanhandled.", "...la tête a l'air d'avoir été plutôt malmenée.");
                s = s.Replace("Which stands to reason, <E003 4>really, <E003 6>doesn't it?<E003 12>\r\n<E025 2>I mean, <E003 8>it gets turned around and around every day.", "Ce qui est bien compréhensible, après tout, n'est-ce pas ? Je veux dire, on la tourne et retourne tous les jours.");
                s = s.Replace("...I hope it doesn't fall off in the end.", "...J'espère qu'elle ne finira pas par se détacher.");
                return s;
            };

            // [103] BB\script\output\_sce03_evidence_eng#9
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("This looks like...<E003 10><E025 2><E333>some sort of key.", "On dirait... une sorte de clé.");
                s = s.Replace("Yes, <E003 8>it does.", "Oui, en effet.");
                s = s.Replace("A very tiny and simple key.", "Une clé minuscule et très simple.");
                s = s.Replace("(What's a little key doing inside a figurine of a policeman\r\nin the first place?)", "(Que fait une petite clé à l'intérieur d'une figurine de policier, pour commencer ?)");
                s = s.Replace("(And what's it for?)", "(Et à quoi sert-elle ?)");
                return s;
            };

            // [104] BB\script\output\_sce03_evidence_eng#10
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("So this is the little key used to wind the inspector's\r\npocket watch.", "C'est donc la petite clé qui sert à remonter la montre à gousset de l'inspecteur.");
                s = s.Replace("It was a mystery at first.<E003 8> Why it should be a policeman,<E003 6>\r\nI mean.", "C'était un mystère au départ. Pourquoi ce policier, je veux dire.");
                s = s.Replace("But it's because it was a gift from Scotland Yard,<E003 6> in\r\nrecognition of Inspector Gregson's hard work.", "Mais c'est parce que c'était un cadeau de Scotland Yard, en hommage au travail acharné de l'inspecteur Gregson.");
                s = s.Replace("...If its head did fall off from overuse, <E003 6><E025 2>it might seem a\r\nlittle inappropriate, <E003 8>don't you think?", "...Si sa tête finissait par tomber à force d'être tournée, cela paraîtrait un peu déplacé, vous ne trouvez pas ?");
                s = s.Replace("That's...<E003 10><E025 2><E333>the British sense of humour for you, <E003 6>I think.", "C'est... l'humour britannique dans toute sa splendeur, je suppose.");
                return s;
            };

            // [105] BB\script\output\_sce03_evidence_eng#11
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("Miss Susato!<E003 14> <E025 2>Do you think perhaps this key...", "Mademoiselle Susato ! Pensez-vous que cette clé...");
                s = s.Replace("...could be the key <E003 10><E025 1><E341>for Inspector Gregson's watch?", "...puisse être la clé de la montre de l'inspecteur Gregson ?");
                s = s.Replace("Oh!<E003 12> <E025 1>Yes, <E003 12><E331>it could be!", "Oh ! Mais oui, c'est bien possible !");
                s = s.Replace("Let's try it at once!<E003 12>\r\n<E335>There's not a moment to lose!", "Essayons immédiatement ! Il n'y a pas un instant à perdre !");
                s = s.Replace("(I knew it!<E003 12> <E330><E025 2>A perfect fit!)", "(Je le savais ! Elle rentre parfaitement !)");
                s = s.Replace("And look!", "Et regardez !");
                s = s.Replace("The inspector's watch <E049><E003 10><E346><E084 0 3 59><E025 1>has started going again!<E069 0 6 0 7>", "La montre de l'inspecteur s'est remise à trotter !");
                s = s.Replace("Ah, <E003 12><E025 2><E330>so it has obviously just not been wound up, <E003 6>that's all.", "Ah, elle n'était manifestement tout simplement pas remontée, voilà tout.");
                s = s.Replace("What is it, <E003 6>Miss Susato?", "Qu'y a-t-il, mademoiselle Susato ?");
                s = s.Replace("Well...<E003 12><E025 3>if the watch <E006>isn't actually broken<E005> after all...", "Eh bien... si la montre n'est en fait pas cassée du tout...");
                s = s.Replace("...I have a feeling it could have profound implications!", "...j'ai le sentiment que cela pourrait avoir d'immenses implications !");
                s = s.Replace("(She's deep in thought now.)", "(Elle est plongée dans ses pensées.)");
                s = s.Replace("(Perhaps I'd better start thinking deeply, too...)", "(Je ferais peut-être bien de me mettre à réfléchir intensément moi aussi...)");
                s = s.Replace("The details of Gregson's pocket watch\r\nhave been updated in the Court Record.", "Les détails de la montre à gousset de Gregson ont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            // [106] BB\script\output\_sce03_evidence_eng#12
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("I've always wondered <E003 8><E330>what the underside of a hairpiece\r\nlooks like.", "Je me suis toujours demandé à quoi ressemblait le dessous d'un postiche.");
                s = s.Replace("That doesn't surprise me at all, <E003 4>Mr Naruhodo.<E003 10>\r\nYou always want to see what lies beneath, <E003 4>don't you?", "Cela ne m'étonne pas du tout de vous, M. Naruhodo. Vous voulez toujours voir ce qui se cache dessous, n'est-ce pas ?");
                s = s.Replace("...I'm not sure that's quite how I'd put it.", "...Je ne suis pas sûr que je formulerais les choses ainsi.");
                s = s.Replace("You must have to use lots of bird lime to keep it in place\r\non your head.", "Il faut sans doute utiliser beaucoup de colle pour le faire tenir sur la tête.");
                s = s.Replace("So it doesn't get blown off in a gust of wind, <E003 6>I mean.", "Pour ne pas qu'il s'envole au premier coup de vent, je veux dire.");
                s = s.Replace("...That might be a little <E003 6><E238>inconvenient <E003 6><E025 2>when you wanted to\r\ntake it off again, <E003 6>don't you think?", "...Ce serait peut-être un peu gênant lorsqu'on voudrait l'enlever, vous ne croyez pas ?");
                return s;
            };

            // [107] BB\script\output\_sce03_evidence_eng#13
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("Ah!<E003 12> <E025 2>There are some black <E006>marks<E005> here, <E003 6>look.", "Ah ! Il y a des marques noires ici, regardez.");
                s = s.Replace("Yes, <E003 6>they...<E003 10><E025 2>look like some sort of <E006>scorch marks<E005>.", "Oui, on... dirait des traces de brûlure.");
                s = s.Replace("So perhaps the bullet struck the candle here,<E003 6> do you\r\nthink?", "La balle aurait-elle touché la bougie ici, selon vous ?");
                s = s.Replace("It's only this one candle that's been cracked in half,<E003 6> it\r\nseems.", "Seule cette bougie-ci a été coupée en deux, semble-t-il.");
                s = s.Replace("Yes, <E003 8><E025 2>I think you might be right.", "Oui, je crois que vous avez raison.");
                s = s.Replace("Firearms are rarely used by criminals in Japan...", "Les criminels utilisent rarement des armes à feu au Japon...");
                s = s.Replace("...so I'm afraid <E003 6><E025 3><E341>I'm not particularly knowledgeable about\r\nthem.", "...alors j'ai bien peur de ne pas être très savante à leur sujet.");
                return s;
            };

            // [108] BB\script\output\_sce03_evidence_eng#14
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("So the candle was used as a sort of timer device to set off\r\nthe firecrackers...", "Ainsi la bougie servait de détonateur à retardement pour déclencher les pétards...");
                s = s.Replace("That's a really ingenious idea...<E003 10>though obviously it's a\r\nshame it was used for such a wicked purpose.", "C'est une idée vraiment ingénieuse... bien qu'il soit bien triste qu'elle ait servi à un dessein aussi néfaste.");
                s = s.Replace("I wonder if there aren't some more positive uses for a\r\ntimer device such as that...", "Je me demande s'il n'y aurait pas des usages plus positifs pour un retardateur de ce genre...");
                s = s.Replace("Ah, <E003 8>I have the perfect application!", "Ah, j'ai trouvé l'application parfaite !");
                s = s.Replace("It would be a wonderful way of waking you in the\r\nmornings, <E003 6>Mr Naruhodo.", "Ce serait une manière fantastique de vous réveiller le matin, M. Naruhodo.");
                s = s.Replace("...I think I'd prefer that you continue to wake me in\r\nperson, <E003 8><E025 3>if it's all the same to you.", "...Je préfère que vous continuiez à me réveiller en personne, si cela ne vous dérange pas.");
                return s;
            };

            // [109] BB\script\output\_sce03_evidence_eng#15
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("So this is the type of revolver that's standard issue for\r\nmembers of the judiciary, then.", "C'est donc le type de revolver fourni de manière réglementaire aux membres de l'appareil judiciaire.");
                s = s.Replace("Yes.<E003 8> And when I asked about whether records are kept\r\nabout who they're issued to...", "Oui. Et quand j'ai demandé si des registres étaient tenus pour savoir à qui ils étaient attribués...");
                s = s.Replace("...I was told that for the past five years, <E003 8><E333>they've been\r\nengraved with a unique serial number.", "...on m'a répondu que depuis cinq ans, ils portaient un numéro de série unique gravé dessus.");
                s = s.Replace("Oh, <E003 8>but as far as I can tell...", "Oh, mais pour autant que je puisse voir...");
                s = s.Replace("...there's nothing like that on this gun.", "...il n'y a rien de tel sur cette arme.");
                s = s.Replace("Which tells us <E003 8><E043><E025 3>that it must have been issued longer ago\r\nthan that.", "Ce qui nous indique qu'elle a dû être attribuée il y a plus longtemps que ça.");
                return s;
            };

            // [110] BB\script\output\_sce03_evidence_eng#16
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("I suppose <E003 8><E025 2>this must have been the murder weapon.", "J'imagine que cela devait être l'arme du crime.");
                s = s.Replace("Oh, <E003 12><E341>oh my...<E003 16>\r\n<E025 1><E335>...It is real, <E003 10>I suppose?", "Oh... ciel... Elle est bien réelle, j'imagine ?");
                s = s.Replace("I, <E003 10><E341>I think so.", "J-... je crois bien, oui.");
                s = s.Replace("Guns are so rare in Japan, <E003 8>I really know very little about\r\nthem.", "Les armes à feu sont si rares au Japon que j'ignore presque tout à leur sujet.");
                s = s.Replace("(Perhaps someone more familiar with firearms could shed\r\na light on things here.)", "(Peut-être que quelqu'un de plus familier avec les armes à feu pourrait m'éclairer là-dessus.)");
                return s;
            };

            // [111] BB\script\output\_sce03_evidence_eng#17
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("Oh.<E003 12> <E025 2>What's this...?", "Oh. Qu'est-ce que c'est que ça... ?");
                s = s.Replace("Mr Naruhodo!<E003 14>\r\n<E025 2><E341>Look!", "M. Naruhodo ! Regardez !");
                s = s.Replace("Oh yes.<E003 12> It's a smudge of some kind.<E003 12>\r\n<E025 3>In fact...", "Ah oui. C'est une sorte de tache. En fait...");
                s = s.Replace("...it looks just like <E003 10><E238><E025 3><E006>a handprint<E005>.", "...on dirait une empreinte de main.");
                s = s.Replace("And the colour...", "Et cette couleur...");
                s = s.Replace("That's <E006>blood<E005>, <E003 10><E025 3>isn't it?", "C'est du sang, n'est-ce pas ?");
                s = s.Replace("Oh dear...<E003 12> <E025 2><E341>How disturbing...", "Oh là là... C'est bien inquiétant...");
                s = s.Replace("The details of the service revolver\r\nhave been updated in the Court Record.", "Les détails du revolver de service ont été mis à jour dans le dossier de l'affaire.");
                return s;
            };
        }
    }
}
