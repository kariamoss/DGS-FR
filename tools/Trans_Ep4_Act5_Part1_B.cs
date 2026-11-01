using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart1_B() {
            // [23] BB\script\output\_sce03_c202_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c202_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I think <E049><E003 5><E145 3 68><E118 3 1.3><E003 15><E025 2><E330>perhaps that trunk should be turned over to the\r\npolice, <E049><E003 6>don't you?", "Je pense <E049><E003 5><E145 3 68><E118 3 1.3><E003 15><E025 2><E330>que cette malle devrait être remise à la\r\npolice, <E049><E003 6>tu ne crois pas ?");
                s = s.Replace("Wot are you on about?<E049><E003 18>\r\n<E164 122 72 1 2 9 0 3 1><E118 122 1.3><E139 122>I am the police!", "D'quoi vous causez ?<E049><E003 18>\r\n<E164 122 72 1 2 9 0 3 1><E118 122 1.3><E139 122>C'est moi, la police !");
                s = s.Replace("Gina...<E003 12><E025 3>if you wouldn't mind...", "Gina...<E003 12><E025 3>si cela ne t'ennuie pas...");
                s = s.Replace("...could we maybe examine it?", "...pourrions-nous peut-être l'examiner ?");
                s = s.Replace("Yeah, <E049><E003 8><E025 2>alright then.<E049><E003 12>\r\n<E025 1><E164 122 67 1 2 0 0 1 1><E139 122><E060 0 141 0 1>Do wot ya want wiv it.", "Ouais, <E049><E003 8><E025 2>d'accord.<E049><E003 12>\r\n<E025 1><E164 122 67 1 2 0 0 1 1><E139 122><E060 0 141 0 1>Faites c'que vous voulez avec.");
                s = s.Replace("Thank you!<E049><E003 10> We shall make a detailed record of our\r\nexamination of the evidence.", "Merci !<E049><E003 10> Nous consignerons un rapport détaillé de notre\r\nexamen des pièces à conviction.");
                s = s.Replace("Gregson's trunk has been\r\nentered into the Court Record.", "La malle de Gregson a été\r\najoutée au dossier de l'affaire.");
                s = s.Replace("Grrrr<E341>rr...", "Grrrr<E341>rr...");
                s = s.Replace("What's the matter with Toby?", "Qu'est-ce qui prend à Toby ?");
                s = s.Replace("Why's he acting so <E006>aggressively<E005> towards me all of a\r\nsudden?", "Pourquoi se montre-t-il si <E006>agressif<E005> envers moi tout à\r\ncoup ?");
                s = s.Replace("Mr Naruhodo, <E049><E003 10><E342>be careful!<E049><E003 12> <E145 3 92><E117 3 5><E003 3><E046><E025 1>It must be the trunk!", "Monsieur Naruhodo, <E049><E003 10><E342>prenez garde !<E049><E003 12> <E145 3 92><E117 3 5><E003 3><E046><E025 1>C'est sans doute la malle !");
                s = s.Replace("Ruff ruff ruff ruff ruff ruff ruff ruff<E045>\r\nruff ruff ruff ruff ruff ruff ruff!", "Ouah ouah ouah ouah ouah ouah ouah ouah<E045>\r\nouah ouah ouah ouah ouah ouah ouah !");
                s = s.Replace("AAAAAAAAAAA<E070 2 5 1>AAAAAAAAAAAAAAAAAAARGH!!!<E071>", "AAAAAAAAAAA<E070 2 5 1>AAAAAAAAAAAAAAAAAAARGH !!!<E071>");
                s = s.Replace("*Thud!*", "*Vlan !*");
                s = s.Replace("Toby!<E003 10> Oi!<E003 12> Wot are you doin'?!<E003 14>\r\n<E606>Yer gonna lick 'is face off!", "Toby !<E003 10> Eh !<E003 12> Qu'est-ce que tu fabriques ?!<E003 14>\r\n<E606>Tu vas lui décoller l'museau à force de l'lécher !");
                s = s.Replace("Mr Naruhodo!<E003 14>\r\n<E025 1><E606>Mr Naruhodooo!", "Monsieur Naruhodo !<E003 14>\r\n<E025 1><E606>Monsieur Naruhodooo !");
                s = s.Replace("Gina, <E003 10>quickly!<E049><E003 12>\r\n<E025 1><E346>Hail a carriage!", "Gina, <E003 10>vite !<E049><E003 12>\r\n<E025 1><E346>Appelle un fiacre !");
                return s;
            };

            // [24] BB\script\output\_sce03_c202_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c202_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November, 4:57 p.m.\r\n<CNTR><E003 5>Naruhodo's Legal Consultancy", "2 novembre, 16 h 57\r\n<CNTR><E003 5>Cabinet juridique Naruhodo");
                s = s.Replace("Oh, Mr Naruhodo!<E049><E003 20><E145 3 92><E117 3 6>\r\n<E607><E025 1>Are you alright?", "Oh, monsieur Naruhodo !<E049><E003 20><E145 3 92><E117 3 6>\r\n<E607><E025 1>Vous allez bien ?");
                s = s.Replace("...Miss <E145 3 88>Susato...", "...Mademoiselle <E145 3 88>Susato...");
                s = s.Replace("Ah, <E003 5>conscious again at last.<E049><E003 10>\r\n<E025 2><E338><E342>A blessed relief, <E003 4>my dear fellow!", "Ah, <E003 5>enfin revenu à vous.<E049><E003 10>\r\n<E025 2><E338><E342>Quel immense soulagement, <E003 4>mon cher ami !");
                s = s.Replace("After all, <E003 7>to drop dead after a moderate licking by\r\na small terrier...<E145 19 66><E003 8> <E025 2>Most unseemly.", "Après tout, <E003 7>trépasser sous les coups de langue modérés\r\nd'un petit terrier...<E145 19 66><E003 8> <E025 2>ce serait du plus mauvais goût.");
                s = s.Replace("What is or isn't seemly is irrelevant here, Mr Sholmes!<E049><E003 8><E086 2 10><E342><E003 10>", "Ce qui est de bon ou mauvais goût n'a rien à voir ici, monsieur Sholmes !<E049><E003 8><E086 2 10><E342><E003 10>");
                s = s.Replace("I'm so glad there's no lasting damage.<E049><E003 10>\r\n<E025 2>How are you feeling?", "Je suis tellement soulagée qu'il n'y ait pas de séquelles.<E049><E003 10>\r\n<E025 2>Comment vous sentez-vous ?");
                s = s.Replace("I'm fine, <E003 10>thank you.<E003 15>\r\n<E025 3>Did...<E003 4><E145 3 64>you bring me back here?", "Je vais bien, <E003 10>merci.<E003 15>\r\n<E025 3>C'est...<E003 4><E145 3 64>vous qui m'avez ramené ici ?");
                s = s.Replace("(Ah!<E003 8> What's this on my head?<E003 15>\r\n<E330><E025 3>A, <E003 6>a bandage?)", "(Ah !<E003 8> Qu'ai-je sur le crâne ?<E003 15>\r\n<E330><E025 3>Un... <E003 6>un bandage ?)");
                s = s.Replace("Sadly we had no ice.<E049><E003 2> <E164 19 71 1 2 6 0 0 1><E118 19 1.1><E139 19>So that's a compress of\r\nsugar water.", "Hélas, nous n'avions pas de glace.<E049><E003 2> <E164 19 71 1 2 6 0 0 1><E118 19 1.1><E139 19>C'est donc une compresse\r\nd'eau sucrée.");
                s = s.Replace("Sugar water?", "De l'eau sucrée ?");
                s = s.Replace("Don't worry, Mr Naruhodo.<E003 12> It's a first-aid treatment\r\nthat my father taught me.", "Ne vous inquiétez pas, monsieur Naruhodo.<E003 12> C'est un soin de premiers\r\nsecours que mon père m'a enseigné.");
                s = s.Replace("Oh...<E003 10><E025 2><E338><E341>thank you.", "Oh...<E003 10><E025 2><E338><E341>merci.");
                s = s.Replace("So, <E003 8>let us take tea when you're feeling up to it.", "Alors, <E003 8>prenons le thé dès que vous vous en sentirez la force.");
                s = s.Replace("But of course...<E049><E003 10><E025 2><E164 19 79 1 2 6 0 0 1><E139 19>no sugar in the patient's cup.", "Mais bien sûr...<E049><E003 10><E025 2><E164 19 79 1 2 6 0 0 1><E139 19>pas de sucre dans la tasse du patient.");
                s = s.Replace("Ugh...<E003 10><E025 3>the bump on my head is throbbing sweetly\r\nenough, don't worry.", "Argh...<E003 10><E025 3>la bosse sur mon front pulse déjà bien assez doucement,\r\nne vous en faites pas.");
                s = s.Replace("Hee hee.<E049><E003 15> <E145 3 65><E118 3 1.2><E003 12><E025 2>Whenever you feel ready, then...", "Hi hi.<E049><E003 15> <E145 3 65><E118 3 1.2><E003 12><E025 2>Quand vous serez prêt, alors...");
                return s;
            };

            // [25] BB\script\output\_sce03_c203_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\n<CNTR><E003 5>Sholmes's Suite", "2 novembre\r\n<CNTR><E003 5>Appartement de Sholmes");
                s = s.Replace("...What on earth is going on in here?<E003 15>\r\n<E025 3><E238>Am I having <E006>a bad dream<E005>?!", "...Mais que diable se passe-t-il ici ?<E003 15>\r\n<E025 3><E238>Suis-je en train de faire <E006>un cauchemar<E005> ?!");
                s = s.Replace("Ah, <E049><E003 8><E025 3>no.<E049><E003 10> <E025 2>It's an old German folk song.<E049><E003 8>\r\n<E025 1><E145 19 81><E118 19 1.2><E149 19 3 0><E144 19><E346><E342>Rather a fine rendition, I think.", "Ah, <E049><E003 8><E025 3>non.<E049><E003 10> <E025 2>C'est un vieux chant folklorique allemand.<E049><E003 8>\r\n<E025 1><E145 19 81><E118 19 1.2><E149 19 3 0><E144 19><E346><E342>Une interprétation fort réussie, ma foi.");
                s = s.Replace("...That's the least of my concerns.", "...C'est bien le cadet de mes soucis.");
                s = s.Replace("Um...<E003 10>Iris?", "Euh...<E003 10>Iris ?");
                s = s.Replace("Iris?<E003 8> <E341>What's the matter?", "Iris ?<E003 8> <E341>Qu'est-ce qui ne va pas ?");
                s = s.Replace("Um...<E003 10><E025 2>who is that sprawling–<E049><E003 10> <E338><E342><E025 1>I mean, <E049><E003 8><E025 3>that...<E003 10><E025 2>relaxed\r\ngentleman over there?", "Euh...<E003 10><E025 2>qui est cet individu affalé...<E049><E003 10> <E338><E342><E025 1>enfin, <E049><E003 8><E025 3>ce monsieur...<E003 10><E025 2>très\r\ndétendu là-bas ?");
                s = s.Replace("Iris...?<E003 10> Um...<E003 12>\r\n<E025 3><E007>(Is she even listening?)", "Iris... ?<E003 10> Euh...<E003 12>\r\n<E025 3><E007>(M'écoute-t-elle seulement ?)");
                s = s.Replace("Excuse me, sir!", "Excusez-moi, monsieur !");
                s = s.Replace("I do apologise for troubling you whilst you're singing so\r\nmerrily, <E049><E003 6><E025 3>but...", "Je vous prie de m'excuser de vous déranger pendant que vous chantez si\r\ngaillardement, <E049><E003 6><E025 3>mais...");
                s = s.Replace("...would you be kind enough to explain the situation?", "...auriez-vous l'amabilité de nous éclairer sur la situation ?");
                s = s.Replace("...Well that worked.", "...Au moins, cela a fonctionné.");
                s = s.Replace("A crooning gentleman and a mute young girl...<E049><E003 10>\r\n<E025 2><E145 19 64><E118 19 1.5><E003 15><E333>A rather tantalising juxtaposition.", "Un monsieur qui fredonne et une jeune fille muette...<E049><E003 10>\r\n<E025 2><E145 19 64><E118 19 1.5><E003 15><E333>Une bien intrigante juxtaposition.");
                s = s.Replace("And one <E049><E003 8><E145 19 66><E118 19 1.2><E003 15><E330><E092 6><E025 2>that appears to have incited the gods of\r\ndeduction within me to find their voices, too.", "Et qui semble <E049><E003 8><E145 19 66><E118 19 1.2><E003 15><E330><E092 6><E025 2>avoir incité les dieux de la\r\ndéduction en moi à donner de la voix, eux aussi.");
                s = s.Replace("Ah!<E003 12> Mr Sholmes!<E003 10> <E025 1><E338><E342>Do you mean...?", "Ah !<E003 12> Monsieur Sholmes !<E003 10> <E025 1><E338><E342>Voulez-vous dire... ?");
                s = s.Replace("The strains of reasoning within me are playing now as a\r\ndelightful duet.", "Les accords de mon raisonnement résonnent désormais en un\r\ndélicieux duo.");
                s = s.Replace("One melody <E049><E003 6><E164 19 79 1 2 5 0 1 1><E139 19><E025 1>sings of <E006>a reunion<E005> full of nostalgia.", "Une mélodie <E049><E003 6><E164 19 79 1 2 5 0 1 1><E139 19><E025 1>entonne le chant <E006>d'une réunion<E005> empreinte de nostalgie.");
                s = s.Replace("Whilst <E145 19 67>the other...", "Tandis que <E145 19 67>l'autre...");
                s = s.Replace("...is a morose theme about <E006>the great secret<E005> you're trying\r\nso desperately to conceal, <E049><E003 4><E164 19 71 1 2 6 0 0 1><E172 19 -20 220 15 2 0><E492 19 220 15 2><E149 19 3 0><E139 19><E025 1>Iris.", "...est un air sombre sur <E006>le grand secret<E005> que tu tentes si\r\ndésespérément de dissimuler, <E049><E003 4><E164 19 71 1 2 6 0 0 1><E172 19 -20 220 15 2 0><E492 19 220 15 2><E149 19 3 0><E139 19><E025 1>Iris.");
                s = s.Replace("(She's turned as white as a sheet.)", "(Elle est devenue blanche comme un linge.)");
                s = s.Replace("So as usual, <E049><E003 10><E025 1><E164 3 87 1 2 8 0 3 1><E149 3 4 4><E139 3>you've instantly seen to the very heart of the\r\nmatter!", "Comme toujours, <E049><E003 10><E025 1><E164 3 87 1 2 8 0 3 1><E149 3 4 4><E139 3>vous avez instantanément percé le cœur du\r\nmystère !");
                s = s.Replace("And by the time my own brief performance is over,<E049><E003 8> I feel\r\nsure this gentleman's song will reach its finale.", "Et le temps que s'achève ma modeste prestation,<E049><E003 8> nul doute\r\nque le chant de ce monsieur trouvera sa conclusion.");
                return s;
            };

            // [26] BB\script\output\_sce03_c203_0010_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So then...<E003 12><E025 2>to music-land, <E049><E003 10>where all is sweetness and\r\ndelicacy and harmony!", "Et maintenant...<E003 12><E025 2>en route vers le pays de la musique, <E049><E003 10>où tout est\r\ndouceur, délicatesse et harmonie !");
                s = s.Replace("Pray, <E049><E003 10>do enjoy Herlock Sholmes's latest ‘Logic and\r\nReasoning Spectacular’!", "Je vous prie <E049><E003 10>d'apprécier le nouveau « Grand Spectacle de Logique\r\net de Déduction » d'Herlock Sholmes !");
                return s;
            };

            // [27] BB\script\output\_sce03_c203_0010_eng#3
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Firstly, <E049><E003 8>we consider the gentleman's nationality.<E049><E003 10> Clearly\r\nhe's <E006>a German<E005> with no grasp of the English language...", "Examinons d'abord <E049><E003 8>la nationalité de ce monsieur.<E049><E003 10> C'est de toute\r\névidence <E006>un Allemand<E005> ne comprenant pas un traître mot d'anglais...");
                s = s.Replace("...as evidenced by the Germanic song he sings and his\r\napparent inability to understand when asked to desist.", "...comme en attestent la chanson germanique qu'il entonne et son\r\nincapacité flagrante à comprendre quand on le prie de cesser.");
                s = s.Replace("So...<E003 10><E025 2>why is the man here at all, <E049><E003 8><E330>and in such apparently\r\nhigh spirits?", "Dès lors...<E003 10><E025 2>pourquoi cet homme est-il ici, <E049><E003 8><E330>et dans une humeur\r\naussi manifestement joviale ?");
                s = s.Replace("The answer of course, <E049><E003 8>Iris...<E003 12>is clearly known to you.", "La réponse, <E049><E003 8>Iris...<E003 12>t'est naturellement bien connue.");
                s = s.Replace("Indeed, <E003 8>we need only follow the gaze of those bright,<E003 6>\r\nyoung eyes to unravel that particular part of this mystery.", "En vérité, <E003 8>il nous suffit de suivre l'éclat de tes yeux pétillants<E003 6>\r\npour percer ce premier pan du mystère.");
                s = s.Replace("The reason for the man's mildly irritating warbling<E003 10> <E025 1><E341>is\r\nrevealed by the <E006><E570><FONT 2>herbal tea<E571></FONT><E005>!", "La raison des vocalises quelque peu agaçantes de cet individu<E003 10> <E025 1><E341>est\r\nrévélée par la <E006><E570><FONT 2>tisane<E571></FONT><E005> !");
                return s;
            };

            // [28] BB\script\output\_sce03_c203_0010_eng#4
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Firstly, <E049><E003 8>we consider the gentleman's nationality.<E049><E003 10> Clearly\r\nhe's <E006>a German<E005> with no grasp of the English language...", "Examinons d'abord <E049><E003 8>la nationalité de ce monsieur.<E049><E003 10> C'est de toute\r\névidence <E006>un Allemand<E005> ne comprenant pas un traître mot d'anglais...");
                s = s.Replace("...as evidenced by the Germanic song he sings and his\r\napparent inability to understand when asked to desist.", "...comme en attestent la chanson germanique qu'il entonne et son\r\nincapacité flagrante à comprendre quand on le prie de cesser.");
                s = s.Replace("So...<E003 10><E025 2>why is the man here at all, <E049><E003 8><E330>and in such apparently\r\nhigh spirits?", "Dès lors...<E003 10><E025 2>pourquoi cet homme est-il ici, <E049><E003 8><E330>et dans une humeur\r\naussi manifestement joviale ?");
                s = s.Replace("The answer of course, <E049><E003 8>Iris...<E003 12>is clearly known to you.", "La réponse, <E049><E003 8>Iris...<E003 12>t'est naturellement bien connue.");
                s = s.Replace("Indeed, <E003 8>we need only follow the gaze of those bright,<E003 6>\r\nyoung eyes to unravel that particular part of this mystery.", "En vérité, <E003 8>il nous suffit de suivre l'éclat de tes yeux pétillants<E003 6>\r\npour percer ce premier pan du mystère.");
                s = s.Replace("The reason for the man's mildly irritating warbling<E003 10> <E025 1><E341>is\r\nrevealed by the <E006><E570><FONT 2>herbal tea<E571></FONT><E005>!", "La raison des vocalises quelque peu agaçantes de cet individu<E003 10> <E025 1><E341>est\r\nrévélée par la <E006><E570><FONT 2>tisane<E571></FONT><E005> !");
                return s;
            };

            // [29] BB\script\output\_sce03_c203_0010_eng#5
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("You obviously offered our German guest a cup of your\r\nlatest herbal blend.", "Tu as tout bonnement offert à notre invité allemand une tasse\r\nde ton dernier mélange d'herbes.");
                s = s.Replace("The tea's delectable flavour has made the man's spirits\r\nsoar...", "La saveur exquise de cette infusion a transporté l'homme de joie...");
                s = s.Replace("...and resulted in this joyful ditty tumbling incessantly\r\nfrom his lips.", "...ce qui a fait jaillir sans discontinuer ce joyeux refrain de ses lèvres.");
                s = s.Replace("I eagerly await sampling the flavour myself, <E003 6>that I may\r\njoin the fellow in his state of elation.", "J'ai hâte d'y goûter moi-même, <E003 6>afin de partager avec lui\r\ncet état d'allégresse.");
                s = s.Replace("Nnnnnn...", "Mmmmmh...");
                s = s.Replace("Now <E049><E003 10><E025 2>to the next question:", "Passons <E049><E003 10><E025 2>à la question suivante :");
                s = s.Replace("<E006>Who<E005> exactly <E049><E003 12>is this gentleman availing himself so\r\nthoroughly of the settee?", "<E006>Qui<E005> est donc exactement <E049><E003 12>ce monsieur qui prend ses aises\r\nsi copieusement sur le canapé ?");
                s = s.Replace("As it happens, <E003 8>a number of years ago now...", "Il se trouve qu'il y a quelques années d'ici...");
                s = s.Replace("...a certain gentleman of German origin engaged my\r\nservices in solving a particularly delicate case.", "...un éminent gentilhomme d'origine germanique s'est attaché mes\r\nservices pour résoudre une affaire des plus délicates.");
                s = s.Replace("He required the retrieval of letters once sent to an\r\nacquaintance, <E049><E003 8>that might have proved...<E003 10><E025 3>problematic.", "Il s'agissait de récupérer des lettres autrefois adressées à une\r\nconnaissance, <E049><E003 8>qui auraient pu s'avérer... <E003 10><E025 3>compromettantes.");
                s = s.Replace("In order to conceal his noble identity, <E049><E003 8>he also arrived at\r\nmy office in a mask.", "Afin de dissimuler son auguste identité, <E049><E003 8>il s'était également\r\nprésenté à mon bureau masqué.");
                s = s.Replace("The gentleman's name <E049><E003 10><E330>was Wilhelm Gottsreich Sigismond\r\nvon Ormstein...", "Le nom de ce monsieur <E049><E003 10><E330>était Wilhelm Gottsreich Sigismond\r\nvon Ormstein...");
                s = s.Replace("...the King of Germany.", "...le roi d'Allemagne.");
                s = s.Replace("If my memory serves...<E003 10>the mask worn by this gentleman\r\nis identical.", "Si ma mémoire ne me trahit pas...<E003 10>le masque que porte ce monsieur\r\nest rigoureusement identique.");
                s = s.Replace("Yes, <E003 8>there can be no question!<E003 10> <E025 1><E341>That mask belongs to\r\n<E006><E570><FONT 2>the King of Germany<E571></FONT><E005>!", "Oui, <E003 8>aucun doute possible !<E003 10> <E025 1><E341>Ce masque appartient au\r\n<E006><E570><FONT 2>roi d'Allemagne<E571></FONT><E005> !");
                return s;
            };

            // [30] BB\script\output\_sce03_c203_0010_eng#6
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("<E006>Who<E005> exactly <E049><E003 12>is this gentleman availing himself so\r\nthoroughly of the settee?", "<E006>Qui<E005> est donc exactement <E049><E003 12>ce monsieur qui prend ses aises\r\nsi copieusement sur le canapé ?");
                s = s.Replace("As it happens, <E003 8>a number of years ago now...", "Il se trouve qu'il y a quelques années d'ici...");
                s = s.Replace("...a certain gentleman of German origin engaged my\r\nservices in solving a particularly delicate case.", "...un éminent gentilhomme d'origine germanique s'est attaché mes\r\nservices pour résoudre une affaire des plus délicates.");
                s = s.Replace("He required the retrieval of letters once sent to an\r\nacquaintance, <E049><E003 8>that might have proved...<E003 10><E025 3>problematic.", "Il s'agissait de récupérer des lettres autrefois adressées à une\r\nconnaissance, <E049><E003 8>qui auraient pu s'avérer... <E003 10><E025 3>compromettantes.");
                s = s.Replace("In order to conceal his noble identity, <E049><E003 8>he also arrived at\r\nmy office in a mask.", "Afin de dissimuler son auguste identité, <E049><E003 8>il s'était également\r\nprésenté à mon bureau masqué.");
                s = s.Replace("The gentleman's name <E049><E003 10><E330>was Wilhelm Gottsreich Sigismond\r\nvon Ormstein...", "Le nom de ce monsieur <E049><E003 10><E330>était Wilhelm Gottsreich Sigismond\r\nvon Ormstein...");
                s = s.Replace("...the King of Germany.", "...le roi d'Allemagne.");
                s = s.Replace("If my memory serves...<E003 10>the mask worn by this gentleman\r\nis identical.", "Si ma mémoire ne me trahit pas...<E003 10>le masque que porte ce monsieur\r\nest rigoureusement identique.");
                s = s.Replace("Yes, <E003 8>there can be no question!<E003 10> <E025 1><E341>That mask belongs to\r\n<E006><E570><FONT 2>the King of Germany<E571></FONT><E005>!", "Oui, <E003 8>aucun doute possible !<E003 10> <E025 1><E341>Ce masque appartient au\r\n<E006><E570><FONT 2>roi d'Allemagne<E571></FONT><E005> !");
                return s;
            };

            // [31] BB\script\output\_sce03_c203_0010_eng#7
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("It would appear that His Majesty remembers the fine\r\nservice I afforded him...", "Il semblerait que Sa Majesté se remémore l'insigne service\r\nque je lui ai rendu...");
                s = s.Replace("...and has decided to show his face again, <E049><E003 8>mask and all,<E049><E003 8> in\r\norder to express his gratitude.", "...et ait décidé de se montrer à nouveau, <E049><E003 8>masque compris,<E049><E003 8> afin\r\nde m'exprimer sa gratitude.");
                s = s.Replace("A well-mannered monarch indeed.<E049><E003 10>\r\n<E145 4 71><E173 4 0 20 3><E492 4 195 20 3>Wouldn't you agree, <E049><E003 6>my dear fellow? ", "Voilà un souverain fort bien élevé.<E049><E003 10>\r\n<E145 4 71><E173 4 0 20 3><E492 4 195 20 3>N'êtes-vous point d'accord, <E049><E003 6>mon cher ami ? ");
                s = s.Replace("So the identity of this masked visitor<E049><E003 8> is in fact my former\r\nclient...<E003 8><E164 19 79 1 2 8 1 1 1><E003 5><E463 36.5 7 0 3 1><E465 0 15 0 3 1><E485 140 3 1><E466 15 3 1><E527 -163.191605 116.227005 -25.660400 3 1><E139 19><E025 1>the King of Germany!", "L'identité de ce visiteur masqué<E049><E003 8> n'est donc autre que mon ancien\r\nclient... <E003 8><E164 19 79 1 2 8 1 1 1><E003 5><E463 36.5 7 0 3 1><E465 0 15 0 3 1><E485 140 3 1><E466 15 3 1><E527 -163.191605 116.227005 -25.660400 3 1><E139 19><E025 1>le roi d'Allemagne !");
                s = s.Replace("Indeed, <E049><E003 8>his son is currently in London as well,<E049><E003 6> enjoying\r\nthe wonders of the Great Exhibition.", "D'ailleurs, <E049><E003 8>son fils séjourne actuellement à Londres lui aussi,<E049><E003 6> profitant\r\ndes merveilles de l'Exposition universelle.");
                return s;
            };

            // [32] BB\script\output\_sce03_c203_0010_eng#8
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Which leaves us with one remaining imponderable.<E049><E003 12>\r\n<E025 3>Yes...<E003 12>you, <E049><E003 8>young Iris.", "Ce qui nous laisse un dernier élément impondérable.<E049><E003 12>\r\n<E025 3>Oui... <E003 12>toi, <E049><E003 8>ma jeune Iris.");
                s = s.Replace("But your apparently inexplicable silence...<E003 10>is unable to\r\nhide the truth.", "Mais ton mutisme en apparence inexplicable...<E003 10>ne saurait\r\ndissimuler la vérité.");
                s = s.Replace("Yes, <E003 8>the reason for your muteness <E003 10><E025 1><E338><E341>is concealed inside\r\nthat <E006><E570><FONT 2>knapsack<E571></FONT><E005>!", "Oui, <E003 8>la raison de ton silence <E003 10><E025 1><E338><E341>est dissimulée à l'intérieur\r\nde ce <E006><E570><FONT 2>sac à dos<E571></FONT><E005> !");
                return s;
            };

            // [33] BB\script\output\_sce03_c203_0010_eng#9
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Which leaves us with one remaining imponderable.<E049><E003 12>\r\n<E025 3>Yes...<E003 12>you, <E049><E003 8>young Iris.", "Ce qui nous laisse un dernier élément impondérable.<E049><E003 12>\r\n<E025 3>Oui... <E003 12>toi, <E049><E003 8>ma jeune Iris.");
                s = s.Replace("But your apparently inexplicable silence...<E003 10>is unable to\r\nhide the truth.", "Mais ton mutisme en apparence inexplicable...<E003 10>ne saurait\r\ndissimuler la vérité.");
                s = s.Replace("Yes, <E003 8>the reason for your muteness <E003 10><E025 1><E338><E341>is concealed inside\r\nthat <E006><E570><FONT 2>knapsack<E571></FONT><E005>!", "Oui, <E003 8>la raison de ton silence <E003 10><E025 1><E338><E341>est dissimulée à l'intérieur\r\nde ce <E006><E570><FONT 2>sac à dos<E571></FONT><E005> !");
                return s;
            };

            // [34] BB\script\output\_sce03_c203_0010_eng#10
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("A five pound note, <E003 6>I believe.<E003 12>\r\nI must say, <E003 6>as your compatriot, <E003 8>I'm deeply saddened.", "Un billet de cinq livres, <E003 6>je présume.<E003 12>\r\nJe dois avouer qu'en tant que tuteur, <E003 8>j'en suis navré au plus haut point.");
                s = s.Replace("It would appear <E049><E003 8>that you've allowed yourself to be bribed\r\ninto silence by His Royal Highness.", "Il semblerait <E049><E003 8>que tu te sois laissé acheter ton silence\r\npar Son Altesse Royale.");
                s = s.Replace("Earning yourself some spending money in exchange for\r\nkeeping quiet about the King's secret.", "T'offrant un peu d'argent de poche en échange de ton silence\r\nsur le secret de Sa Majesté.");
                s = s.Replace("And now, <E049><E003 8>the final piece of the puzzle...", "Et voici à présent <E049><E003 8>la dernière pièce de notre puzzle...");
                s = s.Replace("What is this <E006>secret<E005> you strive to hide with your silence, <E049><E003 6>\r\nIris?", "Quel est ce <E006>secret<E005> que tu t'efforces de cacher derrière ton silence, <E049><E003 6>\r\nIris ?");
                s = s.Replace("Ah, yes!<E049><E003 8> We need only follow that brief, <E003 4>involuntary\r\ntwitch of your eyes to find the answer.", "Ah, oui !<E049><E003 8> Il nous suffit de suivre ce fugace et involontaire\r\ntressaillement de ton regard pour avoir la réponse.");
                s = s.Replace("You were attempting to abscond <E003 8><E025 1><E338><E341>with that <E006><E570><FONT 2>coffee cup<E571></FONT><E005>!", "Tu tentais de t'enfuir en douce <E003 8><E025 1><E338><E341>avec cette <E006><E570><FONT 2>tasse de café<E571></FONT><E005> !");
                return s;
            };

            // [35] BB\script\output\_sce03_c203_0010_eng#11
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("You were attempting to abscond <E003 8><E025 1><E338><E341>with that <E006><E570><FONT 2>coffee cup<E571></FONT><E005>!", "Tu tentais de t'enfuir en douce <E003 8><E025 1><E338><E341>avec cette <E006><E570><FONT 2>tasse de café<E571></FONT><E005> !");
                return s;
            };

            // [36] BB\script\output\_sce03_c203_0010_eng#12
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("My <E006>favourite<E005> coffee cup, <E003 6>in fact.", "Ma tasse de café <E006>favorite<E005>, en vérité.");
                s = s.Replace("Or should I say, <E049><E003 10><E333><E006>the handle<E005> of my favourite coffee cup?", "Ou plutôt devrais-je dire, <E049><E003 10><E333><E006>l'anse<E005> de ma tasse de café favorite ?");
                s = s.Replace("It appears <E049><E003 8>that His High-Spirited Highness broke it in the\r\nmidst of his high jinks.", "Il semble <E049><E003 8>que Son Altesse Exubérante l'ait brisée au cours\r\nde ses folles cabrioles.");
                s = s.Replace("Which leads us to the sad truth...", "Ce qui nous amène à la navrante vérité...");
                s = s.Replace("My favourite coffee cup has been broken by the King of\r\nGermany – <E049><E003 10><E025 2>and Iris, <E049><E003 10><E025 1>you tried to conceal it from me!", "Ma tasse de café favorite a été brisée par le roi d'Allemagne – <E049><E003 10><E025 2>et toi,\r\nIris, <E049><E003 10><E025 1>tu as tenté de me le dissimuler !");
                s = s.Replace("...I shall have a bill sent via governmental channels to the\r\nGerman royal family for its replacement.", "...Je ferai parvenir la facture par voie diplomatique à la famille\r\nroyale d'Allemagne pour son remplacement.");
                return s;
            };

            // [37] BB\script\output\_sce03_c203_0010_eng#13
            entryTranslators[@"BB\script\output\_sce03_c203_0010_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("Thus concludes Herlock Sholmes's great deduction...<E003 12>\r\nof this painful puzzle...", "Ainsi se conclut la grande déduction d'Herlock Sholmes...<E003 12>\r\nface à cette douloureuse énigme...");
                return s;
            };

            // [38] BB\script\output\_sce03_c203_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("With your silence as well, <E049><E003 8>the fellow's jovial warbling\r\nrather rings in the ears, <E049><E003 4>does it not?", "Avec votre mutisme en sus, <E049><E003 8>les vocalises réjouies de ce monsieur\r\nnous cassent passablement les oreilles, <E049><E003 4>n'est-ce pas ?");
                s = s.Replace("Haah...", "Pfffiou...");
                s = s.Replace("Um, <E049><E003 8>Mr Sholmes...", "Euh, <E049><E003 8>monsieur Sholmes...");
                s = s.Replace("...I must say something does rather trouble me.", "...je dois dire qu'un détail me chiffonne un peu.");
                s = s.Replace("Pray, <E049><E003 4>Miss Susato, <E003 10><E341>do tell.", "De grâce, <E049><E003 4>mademoiselle Susato, <E003 10><E341>dites-moi tout.");
                s = s.Replace("His Royal Highness...", "Son Altesse Royale...");
                s = s.Replace("...doesn't appear to have moved a muscle since we\r\narrived.", "...ne semble pas avoir bougé d'un cil depuis notre\r\narrivée.");
                s = s.Replace("And you haven't said a word, either, <E003 6><E025 3>Iris.", "Et tu n'as pas pipé mot non plus, <E003 6><E025 3>Iris.");
                s = s.Replace("If Mr Sholmes has it all right, <E003 8>you might as well own up to\r\nit now.", "Si M. Sholmes a vu juste, <E003 8>autant avouer tout de suite.");
                s = s.Replace("...Your reasoning isn't entirely without substance,<E003 8> <E025 3>I must\r\nadmit.", "...Votre raisonnement n'est pas totalement dénué de fondement,<E003 8> <E025 3>je dois\r\nle reconnaître.");
                s = s.Replace("And...<E003 10><E025 2><E341>one other thing, <E003 6>Mr Sholmes.", "Et...<E003 10><E025 2><E341>une autre chose, <E003 6>monsieur Sholmes.");
                s = s.Replace("Yet another grievance, <E049><E003 4>Mr Naruhodo?<E049><E003 10>\r\nSurely not.", "Encore une doléance, <E049><E003 4>monsieur Naruhodo ?<E049><E003 10>\r\nCe n'est pas possible.");
                s = s.Replace("Well, <E049><E003 8>I actually read the story of that case recently.<E049><E003 10>\r\nThe one you were just describing.", "Eh bien, <E049><E003 8>j'ai lu le récit de cette affaire récemment.<E049><E003 10>\r\nCelle dont vous parliez à l'instant.");
                s = s.Replace("And according to that at least, <E003 8><E025 3>it wasn't the King of\r\n<E006>Germany<E005>, <E003 12><E239><E089 10 2><E025 2>it was the King of <E006>Bohemia<E005>.", "Et selon ce texte du moins, <E003 8><E025 3>ce n'était pas le roi\r\n<E006>d'Allemagne<E005>, <E003 12><E239><E089 10 2><E025 2>mais bien le roi de <E006>Bohême<E005>.");
                s = s.Replace("Goodness, <E049><E003 12>was it?", "Grand dieu, <E049><E003 12>vraiment ?");
                s = s.Replace("Yes, <E049><E003 8>that's quite true.<E049><E003 10> <E025 2>Master Gotts, <E049><E003 6>the prince,<E049><E003 8> testified to\r\nthat in court.", "Oui, <E049><E003 8>c'est tout à fait exact.<E049><E003 10> <E025 2>Le jeune Gotts, <E049><E003 6>le prince,<E049><E003 8> en a\r\ntémoigné au tribunal.");
                s = s.Replace("In his words, <E049><E003 12><E044><E025 3>‘I have come to see the Great Exhibition all\r\nthe way from my home in Bohemia.’", "Selon ses propres mots : <E049><E003 12><E044><E025 3>« Je suis venu visiter l'Exposition\r\nuniverselle depuis ma lointaine Bohême natale. »");
                s = s.Replace("I would ask you to keep that minor error to yourselves.<E049><E003 12>\r\n<E025 1><E145 19 80><E149 19 0 0><E139 19><E333>...It could easily become quite a scandal.", "Je vous saurais gré de garder cette peccadille pour vous.<E049><E003 12>\r\n<E025 1><E145 19 80><E149 19 0 0><E139 19><E333>...Cela pourrait provoquer un scandale retentissant.");
                s = s.Replace("I believe, <E049><E003 6>Mr Naruhodo...", "Je crois, <E049><E003 6>monsieur Naruhodo...");
                s = s.Replace("...that it's our turn now to make some corrections to a\r\nnumber of minor errors that may have slipped in.", "...que c'est à notre tour d'apporter quelques corrections aux\r\npetites erreurs qui ont pu se glisser dans ce raisonnement.");
                s = s.Replace("Yes, <E003 8>even Mr Sholmes is willing to admit he might be\r\nslightly wide of the mark this time.", "Oui, <E003 8>même M. Sholmes est prêt à admettre qu'il a peut-être\r\nun tout petit peu manqué de précision cette fois.");
                s = s.Replace("(Although it's clear <E003 8><E025 3>that Iris is definitely hiding something.)", "(Même s'il est limpide <E003 8><E025 3>qu'Iris dissimule bel et bien quelque chose.)");
                s = s.Replace("(We need to find out <E006>the truth<E007> behind this mysterious\r\nscene!)", "(Nous devons faire éclater <E006>la vérité<E007> derrière cette scène\r\nmystérieuse !)");
                s = s.Replace("But one truth is incontrovertible.<E049><E003 14>\r\nMy favourite coffee cup is no more...", "Mais une vérité demeure incontestable.<E049><E003 14>\r\nMa tasse de café favorite n'est plus de ce monde...");
                return s;
            };

            // [39] BB\script\output\_sce03_c203_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So...<E003 10><E025 2>shall we embark again...", "Alors...<E003 10><E025 2>embarquons-nous à nouveau...");
                s = s.Replace("...on a joint presentation of Herlock Sholmes's ‘Logic and\r\nReasoning Spectacular’?", "...pour la présentation conjointe du « Grand Spectacle de Logique\r\net de Déduction » d'Herlock Sholmes ?");
                s = s.Replace("Firstly, <E049><E003 8>we consider the gentleman's nationality.<E049><E003 10> Clearly\r\nhe's <E006>a German<E005> with no grasp of the English language...", "Examinons d'abord <E049><E003 8>la nationalité de ce monsieur.<E049><E003 10> C'est de toute\r\névidence <E006>un Allemand<E005> ne comprenant pas un traître mot d'anglais...");
                s = s.Replace("...as evidenced by the Germanic song he sings and his\r\napparent inability to understand when asked to desist.", "...comme en attestent la chanson germanique qu'il entonne et son\r\nincapacité flagrante à comprendre quand on le prie de cesser.");
                s = s.Replace("So...<E003 10><E025 2>why is the man here at all, <E049><E003 8><E330>and in such apparently\r\nhigh spirits?", "Dès lors...<E003 10><E025 2>pourquoi cet homme est-il ici, <E049><E003 8><E330>et dans une humeur\r\naussi manifestement joviale ?");
                s = s.Replace("The answer of course, <E049><E003 8>Iris...<E003 12>is clearly known to you.", "La réponse, <E049><E003 8>Iris...<E003 12>t'est naturellement bien connue.");
                s = s.Replace("Indeed, <E003 8>we need only follow the gaze of those bright,<E003 6>\r\nyoung eyes to unravel that particular part of this mystery.", "En vérité, <E003 8>il nous suffit de suivre l'éclat de tes yeux pétillants<E003 6>\r\npour percer ce premier pan du mystère.");
                s = s.Replace("The reason for the man's mildly irritating warbling<E003 10> <E025 1><E341>is\r\nrevealed by the <E006><E570><FONT 2>herbal tea<E571></FONT><E005>!", "La raison des vocalises quelque peu agaçantes de cet individu<E003 10> <E025 1><E341>est\r\nrévélée par la <E006><E570><FONT 2>tisane<E571></FONT><E005> !");
                return s;
            };

            // [40] BB\script\output\_sce03_c203_0030_eng#7
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("So what, <E003 8>it's some mix of herbs that gives you the urge to\r\nsing?", "Et donc, <E003 8>ce mélange d'herbes donnerait une envie irrépressible de\r\nchanter ?");
                s = s.Replace("Goodness...<E003 12> <E330><E025 2>I should like to try some.", "Grand dieu...<E003 12> <E330><E025 2>j'aimerais bien y goûter.");
                s = s.Replace("And I'd like to hear your singing, <E003 8><E025 3>but this man...", "Et moi j'aimerais vous entendre chanter, <E003 8><E025 3>mais cet homme...");
                s = s.Replace("Just how long does he intend to keep up with that tune,<E003 6>\r\ndo you suppose?", "Combien de temps compte-t-il continuer sur ce refrain,<E003 6>\r\nà votre avis ?");
                s = s.Replace("As I said, <E003 8>he's been stock-still the entire time.<E003 10>\r\n<E025 3>And if you look closely...", "Comme je l'ai dit, <E003 8>il est resté immobile tout du long.<E003 10>\r\n<E025 3>Et si vous observez bien...");
                s = s.Replace("...his lips aren't moving either.", "...ses lèvres ne bougent pas non plus.");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("So I'm not sure what's actually responsible for the spirited\r\nsinging.", "Je ne suis donc pas certaine de ce qui produit réellement ce chant\r\nentraînant.");
                s = s.Replace("But I suspect the answer lies at the end of Iris's gaze.", "Mais je soupçonne que la clé se trouve là où se pose le regard d'Iris.");
                return s;
            };

            // [41] BB\script\output\_sce03_c203_0030_eng#8
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Wait, <E003 8><E341><E025 3>this...", "Attendez, <E003 8><E341><E025 3>ceci...");
                s = s.Replace("...Is <E006>a gramophone<E005>, <E003 6>still rarely seen in our own country.", "...est <E006>un gramophone<E005>, <E003 6>un appareil encore rare chez nous.");
                s = s.Replace("The sound certainly appears to be coming from the horn.", "Le son semble indéniablement provenir du pavillon.");
                s = s.Replace("But machines singing!<E003 12> That, <E003 8><E341>that can't be right!", "Mais des machines qui chantent !<E003 12> C'est... <E003 8><E341>c'est insensé !");
                s = s.Replace("Science and technology are changing the world rapidly,<E003 6>\r\nMr Naruhodo.<E003 10> What's right is changing, too.", "La science et la technique transforment le monde à toute allure,<E003 6>\r\nmonsieur Naruhodo.<E003 10> Ce qui est possible évolue aussi.");
                s = s.Replace("Ugh...<E003 12><E025 3>it's too much for my brain.", "Ouf...<E003 12><E025 3>c'est un peu trop pour mon cerveau.");
                s = s.Replace("Well, <E003 8><E333>at least we've found our answer.", "En tout cas, <E003 8><E333>nous avons trouvé notre explication.");
                return s;
            };

            // [42] BB\script\output\_sce03_c203_0030_eng#9
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Well, <E003 8><E025 2>the cup's empty, <E003 6>that's for sure.", "Eh bien, <E003 8><E025 2>la tasse est vide, <E003 6>c'est une certitude.");
                s = s.Replace("So I suppose this mysterious gentleman must have drunk\r\nthe contents.", "J'imagine donc que ce mystérieux personnage a dû en boire\r\nle contenu.");
                s = s.Replace("Iris's special blends are quite delicious, <E003 4>I agree.<E003 10>\r\nThey always make my heart sing.", "Les mélanges d'Iris sont délicieux, <E003 4>j'en conviens.<E003 10>\r\nIls font toujours chanter mon cœur.");
                s = s.Replace("So I can understand wanting to vocalise those feelings,<E003 8>\r\ncertainly.", "Je conçois donc que l'on ait envie d'extérioriser de tels sentiments,<E003 8>\r\nassurément.");
                s = s.Replace("In fact, Mr Naruhodo, <E003 8><E330>you often erupt in boisterous\r\nlaughter after drinking Iris's tea.", "D'ailleurs, monsieur Naruhodo, <E003 8><E330>vous partez souvent d'un rire tonitruant\r\naprès avoir bu le thé d'Iris.");
                s = s.Replace("(I do?<E003 12> <E025 2>Maybe I should take some lighter laughter lessons\r\nfrom Susato-san in the near future...)", "(Vraiment ?<E003 12> <E025 2>Je devrais peut-être prendre des cours de rire discret\r\nauprès de Susato-san prochainement...)");
                return s;
            };

            // [43] BB\script\output\_sce03_c203_0030_eng#10
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("We, <E003 14><E025 1><E332>we know this mask!", "Nous... <E003 14><E025 1><E332>nous connaissons ce masque !");
                s = s.Replace("Oh!<E003 14> You're right!", "Oh !<E003 14> Vous avez raison !");
                s = s.Replace("So...<E003 12>does that mean...?", "Alors...<E003 12>cela voudrait dire... ?");
                s = s.Replace("No, <E003 10><E025 2><E341>surely not!<E003 12>\r\n<E025 1><E335>It couldn't be...<E003 12><E025 3>could it?", "Non, <E003 10><E025 2><E341>impossible !<E003 12>\r\n<E025 1><E335>Ce ne pourrait pas être...<E003 12><E025 3>si ?");
                s = s.Replace("No, <E003 8>it's most definitely not him.", "Non, <E003 8>ce n'est incontestablement pas lui.");
                s = s.Replace("Oh, no...<E003 10>of course it's not.<E003 10>\r\n<E025 2>...Thank goodness.", "Oh, non...<E003 10>bien sûr que non.<E003 10>\r\n<E025 2>...Dieu merci.");
                s = s.Replace("But then, <E003 10><E025 3><E330>why is this gentleman now wearing it?", "Mais alors, <E003 10><E025 3><E330>pourquoi ce monsieur le porte-t-il ?");
                s = s.Replace("I'm afraid once again, <E003 8><E025 2>I really have no idea.", "J'ai bien peur, une fois encore, <E003 8><E025 2>de n'en avoir pas la moindre idée.");
                return s;
            };

            // [44] BB\script\output\_sce03_c203_0030_eng#11
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("The song starts to get inside your head after a time,<E003 6>\r\ndoesn't it?<E049><E003 10> <E025 3>But...<E003 10>is he really singing it?", "Cette chanson finit par vous trotter dans la tête au bout d'un moment,<E003 6>\r\nnon ?<E049><E003 10> <E025 3>Mais...<E003 10>est-ce vraiment lui qui chante ?");
                s = s.Replace("You're right.<E003 8> <E025 3>And if you look closely...", "Vous avez raison.<E003 8> <E025 3>Et en regardant de plus près...");
                s = s.Replace("...the man's mouth is open, <E003 6>but his lips aren't moving at all.", "...la bouche de cet homme est ouverte, <E003 6>mais ses lèvres ne bougent pas d'un millimètre.");
                s = s.Replace("The gentleman...<E003 12><E025 2><E043>couldn't be a waxwork, <E003 6>could he?", "Ce monsieur...<E003 12><E025 2><E043>ne serait pas un mannequin de cire, <E003 6>par hasard ?");
                s = s.Replace("One step at a time, <E003 6>Mr Naruhodo.<E003 8> Let's identify the\r\nsource of the singing first.", "Chaque chose en son temps, <E003 6>monsieur Naruhodo.<E003 8> Identifions\r\nd'abord la source du chant.");
                s = s.Replace("(...I thought that was an insightful suggestion.)", "(...Je trouvais pourtant ma suggestion pertinente.)");
                return s;
            };

            // [45] BB\script\output\_sce03_c203_0030_eng#13
            entryTranslators[@"BB\script\output\_sce03_c203_0030_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("Who else could brew a tea so delicious that it makes you\r\nwant to sing?", "Qui d'autre pourrait infuser un thé si délicieux qu'il vous\r\ndonne envie de pousser la chansonnette ?");
                s = s.Replace("And such a long and curious tune, too!<E049><E003 12>\r\nClearly this melody can only be...", "Et un air si long et singulier par-dessus le marché !<E049><E003 12>\r\nÀ l'évidence, cette mélodie ne peut être que...");
                s = s.Replace("...the famous Iris Wilson's ‘Bohemian Rhapso-tea’!<E049><E003 12>\r\nShe really is the queen of blends.", "...la célèbre « Rhapsodie bohém-thé » d'Iris Wilson !<E049><E003 12>\r\nC'est véritablement la reine des mélanges.");
                return s;
            };
        }
    }
}
