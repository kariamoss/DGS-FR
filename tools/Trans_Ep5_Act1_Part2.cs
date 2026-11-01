using System;
using System.Collections.Generic;

namespace TranslatorEp5Act1 {
    public partial class Program {
        public static void RegisterPart2() {

            // [35] BB\script\output\_sce04_c102_0000_eng#3
            entryTranslators[@"BB\script\output\_sce04_c102_0000_eng#3"] = (s) => {
                s = s.Replace("Keep personal opinion out of your testimony, <E049><E003 6>witness.<E049><E003 12>\r\n<E145 61 7><E118 61 0.5><E025 3>We require only established fact here.", "Gardez vos impressions personnelles hors de votre déposition, <E049><E003 6>témoin.<E049><E003 12>\r\n<E145 61 7><E118 61 0.5><E025 3>Cette cour n'exige que des faits avérés.");
                s = s.Replace("(This must be so hard for her.)", "(Cela doit être tellement cruel pour elle.)");
                s = s.Replace("You can't deny it now, surely...<E049><E003 10><E025 3>Ryunosuke Naruhodo.", "Vous ne pouvez plus le contester à présent...<E049><E003 10><E025 3>Ryunosuke Naruhodo.");
                s = s.Replace("What can't I deny?", "Que ne puis-je contester ?");
                s = s.Replace("The notebook contained the name of <E006>the final mark<E005><E049><E003 4> <E025 3><E145 112 0><E118 112 1.4><E003 12><E238>and\r\nthe location where the assassination would take place.", "Ce carnet consigne le nom de <E006>la cible ultime<E005><E049><E003 4> <E025 3><E145 112 0><E118 112 1.4><E003 12><E238>ainsi que\r\nl'endroit où l'exécution devait avoir lieu.");
                s = s.Replace("That's information that the victim could only have known<E049><E003 10><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>\r\nif he was working with the Reaper!", "Une telle information ne pouvait être connue de la victime<E049><E003 10><E164 112 10 1 2 8 0 1 1><E139 112><E025 1>\r\nque si elle était de mèche avec le Faucheur !");
                s = s.Replace("So...<E049><E003 8><E145 61 5><E118 61 0.5><E003 6><E025 2>who was to be this ‘final mark’?", "Alors...<E049><E003 8><E145 61 5><E118 61 0.5><E003 6><E025 2>qui donc devait être cette « ultime cible » ?");
                s = s.Replace("Go ahead, <E049><E003 6>Inspector Lestrade!<E049><E003 12>\r\n<E025 2>Read the name for the court.", "Allez-y, <E049><E003 6>inspectrice Lestrade !<E049><E003 12>\r\n<E025 2>Lisez ce nom à l'intention de la cour.");
                s = s.Replace("The name that's written alongside the entry that mentions\r\n‘The Grouse’ on 31st October.", "Le nom inscrit à côté de la mention de « The Grouse »\r\nà la date du 31 octobre.");
                s = s.Replace("Eh?<E049><E003 12> <E060 0 153 0 0><E025 3>Oh, <E169 5 0><E003 8>um...<E003 4>\r\n<E025 2><E145 122 88><E139 122><E169 5 3>'Ow d'you read this then...?", "Hein ?<E049><E003 12> <E060 0 153 0 0><E025 3>Euh, <E169 5 0><E003 8>ben...<E003 4>\r\n<E025 2><E145 122 88><E139 122><E169 5 3>comment ça s'épelle, ce truc... ?");
                s = s.Replace("(Reading's still not her strong suit...)", "(La lecture n'est toujours pas son fort...)");
                s = s.Replace("That ain't the problem, alright, <E049><E003 6><E025 1>'Oddo!", "C'est pas ça l'souci, <E049><E003 6><E025 1>'Odoh !");
                s = s.Replace("It's a funny name.<E049><E003 12> <E330>It ain't English.<E049><E003 12>\r\nIt's 'ard to read.", "C'est un nom pas ordinaire.<E049><E003 12> <E330>C'est pas d'l'anglais.<E049><E003 12>\r\nC'est coton à prononcer.");
                s = s.Replace("So it's someone from overseas?", "C'est donc quelqu'un d'étranger ?");
                s = s.Replace("Let me 'ave a bash at it.<E049><E003 15>\r\n<E341><E025 4>‘Seh...<E003 12>ish...<E003 12>iro...’<E049><E003 12> <E025 3>is it?", "Laissez-moi essayer.<E049><E003 15>\r\n<E341><E025 4>« Sé...<E003 12>i...<E003 12>shi...<E003 12>ro... »<E049><E003 12> <E025 3>c'est ça ?");
                s = s.Replace("Yeah, <E049><E003 8>‘Seishiro...’", "Ouais, <E049><E003 8>« Seishiro... »");
                s = s.Replace("‘...Jig...<E003 12>ok...<E003 8>you...’<E049><E003 12> <E025 2>maybe?", "« ...Dji...<E003 12>go...<E003 8>kou... »<E049><E003 12> <E025 2>peut-être ?");
                s = s.Replace("Wha...?<E049><E003 12>\r\n<E025 3><E007><E341>(It, <E003 8>it can't be...)", "Quoi... ?<E049><E003 12>\r\n<E025 3><E007><E341>(Ce, <E003 8>ce n'est pas possible...)");
                s = s.Replace("Seishiro <E049><E003 10><E341>Jigoku?", "Seishiro <E049><E003 10><E341>Jigoku ?");
                s = s.Replace("But that's...<E003 16><E145 9 67><E117 9 10><E025 1>Japan's Minister for Foreign Affairs!", "Mais c'est...<E003 16><E145 9 67><E117 9 10><E025 1>le ministre japonais des Affaires étrangères !");
                s = s.Replace("And the visiting judge who was in Britain for the scientific\r\nconference, My Lord.", "Et le juge plénipotentiaire en visite en Grande-Bretagne pour le symposium scientifique, Votre Honneur.");
                s = s.Replace("The Reaper's plan <E049><E003 8><E025 3>was to assassinate the Japanese foreign\r\nminister on 31st October.", "Le dessein du Faucheur <E049><E003 8><E025 3>était d'assassiner le ministre japonais des Affaires étrangères le 31 octobre.");
                s = s.Replace("Order! Order!", "Silence ! Silence !");
                s = s.Replace("Inspector Gregson <E049><E003 8><E025 2>went to France to put that plan into\r\naction.", "L'inspecteur Gregson <E049><E003 8><E025 2>s'est rendu en France pour mettre ce funeste complot à exécution.");
                s = s.Replace("And then...<E049><E003 8><E025 3>something happened there that led to his death.", "Et là-bas...<E049><E003 8><E025 3>un événement tragique a causé sa propre mort.");
                s = s.Replace("And the accused, <E049><E003 6>Barok van Zieks, <E049><E003 8><E025 2>brought his body back to\r\nFresno Street to frame someone else!", "Et l'accusé, <E049><E003 6>Drake Van Peers, <E049><E003 8><E025 2>a rapatrié son cadavre rue Fresno pour faire accuser un tiers !");
                s = s.Replace("The Reaper's conspiracy <E049><E003 8><E025 1>is fully exposed!", "La conspiration du Faucheur <E049><E003 8><E025 1>est désormais mise à nu !");
                s = s.Replace("This is preposterous!", "C'est purement insensé !");
                s = s.Replace("My Lord, <E049><E003 8>the defence demands to cross-examine this\r\ntestimony!", "Votre Honneur, <E049><E003 8>la défense exige de contre-interroger ce témoignage sans attendre !");
                return s;
            };

            // [36] BB\script\output\_sce04_c102_0000_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0000_eng#4"] = (s) => {
                s = s.Replace("Very well, Counsel. <E049><E003 8>You may cross-examine the witness.", "Très bien, Maître. <E049><E003 8>Vous pouvez entamer votre contre-interrogatoire.");
                s = s.Replace("Miss Lestrade, <E049><E003 6>repeat your testimony.", "Mademoiselle Lestrade, <E049><E003 6>répétez votre déposition.");
                return s;
            };

            // [37] BB\script\output\_sce04_c102_0010_eng#2
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#2"] = (s) => {
                s = s.Replace("– The Reaper's Notebook –", "– Le carnet du Faucheur –");
                return s;
            };

            // [38] BB\script\output\_sce04_c102_0010_eng#4
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#4"] = (s) => {
                s = s.Replace("Yeah, <E049><E003 6><E025 2>this notebook does 'ave a load o' stuff about wot the\r\nReaper got up to these past ten years.", "Ouais, <E049><E003 6><E025 2>ce carnet contient un tas d'trucs sur les coups montés\r\npar l'Faucheur ces dix dernières années.");
                return s;
            };

            // [39] BB\script\output\_sce04_c102_0010_eng#5
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#5"] = (s) => {
                s = s.Replace("Names o' victims, <E049><E003 6>dates <E049><E003 6>an' places an' stuff...<E049><E003 12>\r\n<E025 2>An' the last entry in there was 31st October.", "Des noms d'victimes, <E049><E003 6>des dates, <E049><E003 6>des endroits...<E049><E003 12>\r\n<E025 2>Et la dernière ligne, c'était l'31 octobre.");
                return s;
            };

            // [40] BB\script\output\_sce04_c102_0010_eng#6
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#6"] = (s) => {
                s = s.Replace("It said ‘Grouse’ for the place on that date, <E049><E003 10><E333>and then the\r\nname o' the mark.", "Y avait écrit « Grouse » pour le lieu, <E049><E003 10><E333>et l'nom de la cible juste à côté.");
                return s;
            };

            // [41] BB\script\output\_sce04_c102_0010_eng#7
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#7"] = (s) => {
                s = s.Replace("There was a note about 'im bein' a criminal wot got away\r\nfrom the Reaper in court ten years ago or summat.", "Y avait une note disant qu'c'était un truand qui avait échappé au\r\nFaucheur au tribunal y a dix piges.");
                return s;
            };

            // [42] BB\script\output\_sce04_c102_0010_eng#8
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#8"] = (s) => {
                s = s.Replace("But honest!<E049><E003 12> The boss didn't do none of it!<E049><E003 12>\r\n<E025 3>'E was...<E003 12> <E025 1><E345>'E was just investigatin' the Reaper,<E049><E003 6> that's all!", "Mais j'vous jure !<E049><E003 12> L'patron a rien fait d'tout ça !<E049><E003 12>\r\n<E025 3>Il était...<E003 12> <E025 1><E345>il enquêtait juste sur l'Faucheur,<E049><E003 6> c'est tout !");
                return s;
            };

            // [43] BB\script\output\_sce04_c102_0010_eng#9
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#9"] = (s) => {
                s = s.Replace("Gregson had been investigatin' the Reaper in secret<E049><E003 18> <E145 122 72><E117 122 6><E335><E025 1>and\r\nthat notebook said wot 'e found out!", "Gregson enquêtait sur l'Faucheur en cachette<E049><E003 18> <E145 122 72><E117 122 6><E335><E025 1>et\r\nce carnet disait tout c'qu'il avait découvert !");
                return s;
            };

            // [44] BB\script\output\_sce04_c102_0010_eng#10
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#10"] = (s) => {
                s = s.Replace("If I may...", "Si vous me permettez...");
                s = s.Replace("When originally people began referring to me as the\r\nReaper, <E049><E003 10><E025 3>I didn't object.", "Lorsqu'au commencement le peuple s'est mis à me désigner sous le nom\r\nde Faucheur, <E049><E003 10><E025 3>je n'ai point contesté.");
                s = s.Replace("I believed the power to intimidate London's criminal\r\nclasses into compliance with the law to be beneficial.", "Je tenais la terreur inspirée à la pègre londonienne pour un précieux levier\r\nen faveur du respect de la loi.");
                s = s.Replace("But you carried out your own investigations into the true\r\nidentity of the Reaper, <E049><E003 6>didn't you?", "Mais vous avez mené vos propres enquêtes sur l'identité véritable\r\ndu Faucheur, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("Yes.<E049><E003 10> <E025 2>And those investigations proved conclusively<E049><E003 12> <E025 3><E145 18 4><E118 18 1.5><E003 10><E239>that\r\nGregson was <E006>one arm<E005> of the Reaper.", "Oui.<E049><E003 10> <E025 2>Et ces investigations ont établi avec certitude<E049><E003 12> <E025 3><E145 18 4><E118 18 1.5><E003 10><E239>que\r\nGregson constituait <E006>l'un des bras armés<E005> du Faucheur.");
                s = s.Replace("One arm?<E049><E003 16>\r\nWot are you on about?", "Un bras armé ?<E049><E003 16>\r\nQu'est-ce que vous baragouinez là ?");
                s = s.Replace("The Reaper's victims were all extremely shrewd\r\ncriminals at the top of their game.", "Les proies du Faucheur étaient toutes de redoutables malfaiteurs,\r\nrompus aux arcanes du crime.");
                s = s.Replace("There's simply no way one person could have taken them\r\non alone.<E049><E003 12> <E025 3>The ‘Reaper’...<E003 14><E333>is <E006>an organisation<E005>.", "Il était purement impossible qu'un homme seul pût les éliminer\r\nsans complices.<E049><E003 12> <E025 3>Le « Faucheur »...<E003 14><E333>est <E006>une organisation<E005>.");
                s = s.Replace("With you at its head?", "Avec vous à sa tête ?");
                s = s.Replace("I had spies at the Yard keeping me abreast of Gregson's\r\nmovements, <E049><E003 8>letting me know when he was elsewhere.", "J'avais des informateurs au Yard qui m'informaient des mouvements\r\nde Gregson, <E049><E003 8>m'avisant de chacune de ses absences.");
                s = s.Replace("So I'd been able to check the most recent entry in his\r\nbook.<E049><E003 10> <E025 3>I knew the location.", "J'ai ainsi pu consulter la dernière inscription dans son carnet.<E049><E003 10> <E025 3>J'en connaissais le lieu.");
                s = s.Replace("You knew it said ‘Grouse’?!", "Vous saviez qu'il était écrit « Grouse » ?!");
                s = s.Replace("Believing it to be a reference to the gentleman's club,<E049><E003 10>\r\n<E025 2>I went there on the day in question to investigate.<E049><E003 8><E025 3> Alone.", "Pensant qu'il s'agissait du club de gentlemen éponyme,<E049><E003 10>\r\n<E025 2>je m'y suis rendu le jour en question pour enquêter.<E049><E003 8><E025 3> Seul.");
                s = s.Replace("Ah, <E049><E003 6><E025 2><E145 9 68><E118 9 1.2>so that explains why several members of the club\r\nclaimed to have seen you there.", "Ah, <E049><E003 6><E025 2><E145 9 68><E118 9 1.2>voilà donc pourquoi plusieurs membres du club\r\naffirment vous y avoir croisé.");
                s = s.Replace("But of course <E049><E003 10>the inspector was not there.", "Mais de toute évidence, <E049><E003 10>l'inspecteur n'y était point.");
                s = s.Replace("Because at the time <E049><E003 8>he was making his way to the\r\nsteamship docked on the northern coast of France.", "Puisqu'à cet instant précis, <E049><E003 8>il gagnait le vapeur amarré\r\nsur les côtes de France.");
                s = s.Replace("As shown by the passport found in the victim's metal\r\ntrunk.", "Comme en atteste le passeport retrouvé dans sa malle en métal.");
                return s;
            };

            // [45] BB\script\output\_sce04_c102_0010_eng#11
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#11"] = (s) => {
                s = s.Replace("Because at the time <E049><E003 8>he was making his way to the\r\nsteamship docked on the northern coast of France.", "Puisqu'à cet instant précis, <E049><E003 8>il gagnait le vapeur amarré\r\nsur les côtes de France.");
                s = s.Replace("As shown by the passport found in the victim's metal\r\ntrunk.", "Comme en atteste le passeport retrouvé dans sa malle en métal.");
                return s;
            };

            // [46] BB\script\output\_sce04_c102_0010_eng#12
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#12"] = (s) => {
                s = s.Replace("Very well then.<E049><E003 10> <E025 2>Back to your testimony about the\r\ncontents of this notebook...", "Fort bien.<E049><E003 10> <E025 2>Revenons à votre déposition concernant le contenu\r\nde ce carnet...");
                s = s.Replace("Fine...", "Bien...");
                s = s.Replace("Is something wrong, <E049><E003 6>Mr Naruhodo?", "Quelque chose ne va pas, <E049><E003 6>M. Naruhodo ?");
                s = s.Replace("You seemed <E049><E003 2><E025 3><E164 9 14 1 2 7 0 0 1><E139 9>a little shocked by something a moment ago.", "Vous aviez l'air <E049><E003 2><E025 3><E164 9 14 1 2 7 0 0 1><E139 9>terriblement troublé il y a un instant.");
                s = s.Replace("Oh...<E003 12> <E025 3><E342>No, <E003 6>it's...<E003 10>it's alright.<E003 10>\r\n<E025 3><E007>(I'm overthinking this, <E003 6><E025 2>aren't I?)", "Oh...<E003 12> <E025 3><E342>Non, <E003 6>ce...<E003 10>ce n'est rien.<E003 10>\r\n<E025 3><E007>(Je dois me faire des idées, <E003 6><E025 2>sans doute ?)");
                return s;
            };

            // [47] BB\script\output\_sce04_c102_0010_eng#13
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#13"] = (s) => {
                s = s.Replace("Names of victims, <E049><E003 6>dates, <E049><E003 6>places and ‘stuff’?<E049><E003 10>\r\n<E025 2><E145 1 85><E118 1 1.2><E003 15>What in particular?", "Des noms de victimes, <E049><E003 6>des dates, <E049><E003 6>des lieux... ?<E049><E003 10>\r\n<E025 2><E145 1 85><E118 1 1.2><E003 15>Que voulez-vous dire par là ?");
                s = s.Replace("Well, <E049><E003 10><E025 2>beside the victims' names, <E049><E003 6>this other name kept\r\ncroppin' up.", "Ben, <E049><E003 10><E025 2>à côté du nom des victimes, <E049><E003 6>y a cet autre blase\r\nqui r'venait sans arrêt.");
                s = s.Replace("What other name was that?", "Quel autre nom était-ce ?");
                s = s.Replace("It's the one I told ya yesterday.<E049><E003 10> <E145 122 64><E118 122 1.2><E003 6>The same name,<E049><E003 6> written\r\nover an' over again.", "Celui dont j'vous ai parlé hier.<E049><E003 10> <E145 122 64><E118 122 1.2><E003 6>L'même blase,<E049><E003 6> gribouillé\r\nencore et encore.");
                s = s.Replace("You mean...<E049><E003 10><E146 1 21><E118 1 0.5><E003 20><E025 3><E330><E006>Asa Shinn<E005>?", "Vous voulez dire...<E049><E003 10><E146 1 21><E118 1 0.5><E003 20><E025 3><E330><E006>Asa Shinn<E005> ?");
                s = s.Replace("Yeah, <E049><E003 6><E164 122 89 1 2 6 0 0 1><E118 122 1.4><E139 122>that's the one!<E049><E003 12>\r\n<E025 2>She's a friend o' yours or summat, <E049><E003 6>isn't she?", "Ouais, <E049><E003 6><E164 122 89 1 2 6 0 0 1><E118 122 1.4><E139 122>c'est ça !<E049><E003 12>\r\n<E025 2>C'est une copine à vous ou un truc du genre, <E049><E003 6>non ?");
                s = s.Replace("Were you even listening yesterday?", "Écoutiez-vous seulement ce qui s'est dit hier ?");
                s = s.Replace("Asa Shinn...<E049><E003 12>\r\n<E025 3><E145 18 11><E118 18 0.8><E003 30><E239>...<E006>The assassin<E005>.", "Asa Shinn...<E049><E003 12>\r\n<E025 3><E145 18 11><E118 18 0.8><E003 30><E239>...<E006>La tueuse à gages<E005>.");
                s = s.Replace("Wot?!<E049><E003 15> <E025 3>Like...<E003 12>a killer, <E049><E003 4>you mean?", "Quoi ?!<E049><E003 15> <E025 3>Genre...<E003 12>une meurtrière, <E049><E003 4>vous voulez dire ?");
                s = s.Replace("Gregson was the tactician –<E049><E003 10><E025 2> the one who came up with\r\nthe plan of attack.", "Gregson était le stratège...<E049><E003 10><E025 2> celui qui échafaudait le plan d'attaque.");
                s = s.Replace("He investigated the marks thoroughly, <E049><E003 8><E025 2>finding out when\r\nthey would be vulnerable, <E049><E003 8><E025 3>and who to use to get at them.", "Il étudiait méticuleusement les cibles, <E049><E003 8><E025 2>guettant leurs failles, <E049><E003 8><E025 3>et désignant les pions pour frapper.");
                s = s.Replace("But the person actually executing his plans was someone\r\nelse, <E049><E003 8><E025 3>you're saying.", "Mais le bras armé exécutant ses desseins était un tiers, <E049><E003 8><E025 3>à vous entendre.");
                s = s.Replace("If that's true...<E049><E003 8><E145 61 2><E003 10><E025 2>then the ‘Reaper’ does indeed start to sound\r\nlike an organised group of vigilantes.", "Si cela s'avérait...<E049><E003 8><E145 61 2><E003 10><E025 2>alors le « Faucheur » s'apparenterait en effet à une organisation secrète de justiciers.");
                s = s.Replace("(That's it!)", "(C'est cela même !)");
                s = s.Replace("(That's the truth of the Reaper!)", "(Telle est la vérité sur le Faucheur !)");
                return s;
            };

            // [48] BB\script\output\_sce04_c102_0010_eng#14
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#14"] = (s) => {
                s = s.Replace("Wait...<E049><E003 8><E025 2>didn't you say the last entry in the notebook was\r\n31st October?", "Attendez...<E049><E003 8><E025 2>n'avez-vous point affirmé que la dernière mention remontait au 31 octobre ?");
                s = s.Replace("Yeah, <E049><E003 6>that's right.", "Ouais, <E049><E003 6>c'est ça.");
                s = s.Replace("And the name of the mark on that date was ‘Seishiro\r\nJigoku’?", "Et le nom de la cible à cette date était « Seishiro Jigoku » ?");
                s = s.Replace("Yup, <E049><E003 6>the Japanese bloke.", "Ouaip, <E049><E003 6>le gars du Japon.");
                s = s.Replace("Then that doesn't make any sense!", "Mais alors, cela n'a aucun sens !");
                s = s.Replace("Judge Jigoku was not acquitted by Lord van Zieks ten years\r\nago!", "Le juge Jigoku n'a jamais été acquitté par Lord Van Peers il y a dix ans !");
                s = s.Replace("He wasn't even a criminal in Britain!", "Il n'a jamais commis le moindre crime en Grande-Bretagne !");
                s = s.Replace("Why would the Reaper target him?", "Pourquoi donc le Faucheur l'aurait-il pris pour cible ?");
                s = s.Replace("I don't know the answer to that.", "J'en sais rien, moi.");
                s = s.Replace("I just read what's in the book.", "Moi j'fais qu'lire c'qui a marqué dans l'carnet.");
                return s;
            };

            // [49] BB\script\output\_sce04_c102_0010_eng#15
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#15"] = (s) => {
                s = s.Replace("Hold on! <E003 6>Are you certain that was the last entry?", "Un instant ! <E003 6>Êtes-vous certaine qu'il s'agissait de la dernière mention ?");
                s = s.Replace("Yeah, <E049><E003 6>'course I am.<E049><E003 10> <E025 2>Nuffin' written on the pages after that.", "Ben ouais, <E049><E003 6>évidemment.<E049><E003 10> <E025 2>Y a plus rien d'écrit sur les pages d'après.");
                s = s.Replace("...Because the victim died on that mission.", "...Puisque la victime a péri au cours de cette mission.");
                s = s.Replace("Inspector Gregson's operations as the Reaper<E049><E003 8> <E025 2>ended with the\r\nexecution of that final mark.", "Les agissements de l'inspecteur Gregson sous l'égide du Faucheur<E049><E003 8> <E025 2>ont pris fin avec l'exécution de cette ultime cible.");
                s = s.Replace("...And his own untimely demise.", "...Et sa propre mort prématurée.");
                return s;
            };

            // [50] BB\script\output\_sce04_c102_0010_eng#16
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#16"] = (s) => {
                s = s.Replace("You still maintain that Inspector Gregson wasn't the\r\nReaper, <E049><E003 6>then?", "Vous soutenez toujours que l'inspecteur Gregson n'était pas le Faucheur, alors ?");
                s = s.Replace("I know 'e wasn't!<E049><E003 12> <E025 1><E346>'E was a good copper!", "J'en suis sûre et certaine !<E049><E003 12> <E025 1><E346>C'était un bon flic !");
                s = s.Replace("A good copper who kept records of assassinations?", "Un bon policier qui consignait le registre de meurtres commandités ?");
                s = s.Replace("He was investigatin'!<E049><E003 10> <E025 2>Gatherin' evidence!", "Il menait l'enquête !<E049><E003 10> <E025 2>Il accumulait des preuves !");
                s = s.Replace("If only that were true, Miss Lestrade.", "Si seulement c'était vrai, mademoiselle Lestrade.");
                s = s.Replace("Unfortunately, <E049><E003 8><E025 2>the weight of evidence tells a very\r\ndifferent story.", "Malheureusement, <E049><E003 8><E025 2>l'accablant faisceau d'indices raconte une tout autre histoire.");
                return s;
            };

            // [51] BB\script\output\_sce04_c102_0010_eng#17
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#17"] = (s) => {
                s = s.Replace("Is that everything you have to tell the court, witness?", "Est-ce là tout ce que vous avez à déposer devant la cour, témoin ?");
                s = s.Replace("Yeah...<E049><E003 8>that's all of it.", "Ouais...<E049><E003 8>c'est tout.");
                return s;
            };

            // [52] BB\script\output\_sce04_c102_0010_eng#18
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#18"] = (s) => {
                s = s.Replace("You seem uneasy, <E049><E003 6>Mr Naruhodo.", "Vous semblez bien fébrile, <E049><E003 6>M. Naruhodo.");
                s = s.Replace("Are you troubled by something in the testimony?", "Quelque chose vous contrarie-t-il dans cette déposition ?");
                s = s.Replace("Yes...<E049><E003 8>there's a glaring contradiction here.", "Oui...<E049><E003 8>il y a une contradiction flagrante.");
                s = s.Replace("A contradiction?", "Une contradiction ?");
                s = s.Replace("Someone said something...<E049><E003 8>that doesn't fit with the facts.", "Quelqu'un a dit quelque chose...<E049><E003 8>qui jure complètement avec les faits.");
                return s;
            };

            // [53] BB\script\output\_sce04_c102_0010_eng#19
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#19"] = (s) => {
                s = s.Replace("Who made this contradictory statement, <E049><E003 6>Counsel?", "Qui a formulé cette déclaration contradictoire, <E049><E003 6>Maître ?");
                return s;
            };

            // [54] BB\script\output\_sce04_c102_0010_eng#20
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#20"] = (s) => {
                s = s.Replace("The person whose words contradict the evidence is...", "La personne dont les paroles contredisent les faits est...");
                return s;
            };

            // [55] BB\script\output\_sce04_c102_0010_eng#21
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#21"] = (s) => {
                s = s.Replace("The person whose words contain a fatal contradiction...<E049><E003 10>\r\n<E025 1><E346>is you, <E049><E003 8>Lord van Zieks!", "La personne dont les propos recèlent une contradiction fatale...<E049><E003 10>\r\n<E025 1><E346>c'est vous, <E049><E003 8>Lord Van Peers !");
                s = s.Replace("Me?<E049><E003 12> What?", "Moi ?<E049><E003 12> Quoi donc ?");
                s = s.Replace("Your face has turned ashen.<E049><E003 12>\r\n<E025 1><E346>‘How could he know?’<E049><E003 16> <E025 2>Is that what you're thinking?", "Votre visage a blêmi d'un coup.<E049><E003 12>\r\n<E025 1><E346>« Comment peut-il savoir ? »<E049><E003 16> <E025 2>Est-ce là ce qui vous traverse l'esprit ?");
                s = s.Replace("If my face has turned ashen, <E049><E003 10>it's because I'm thinking,<E049><E003 12>\r\n<E330><E025 2>‘How could he!’", "Si mon visage a pâli, <E049><E003 10>c'est parce que je me dis :<E049><E003 12>\r\n<E330><E025 2>« Comment ose-t-il ! »");
                s = s.Replace("I don't know where you're going with this, <E049><E003 8><E025 3>but...", "J'ignore où vous voulez en venir, <E049><E003 8><E025 3>mais...");
                s = s.Replace("...maybe the evidence you're obviously about to show the\r\ncourt will clarify.", "...la preuve que vous vous apprêtez à nous soumettre éclairera sans doute nos lanternes.");
                return s;
            };

            // [56] BB\script\output\_sce04_c102_0010_eng#22
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#22"] = (s) => {
                s = s.Replace("(There was definitely something strange about it that\r\ndidn't add up.)", "(Il y avait sans conteste une anomalie flagrante qui clochait.)");
                s = s.Replace("The inconsistency...<E049><E003 8><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>is in a statement made by this person!", "La contradiction...<E049><E003 8><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>réside dans une déclaration faite par cette personne !");
                s = s.Replace("People can only be inconsistent in what they say<E049><E003 8> <E025 3>if they\r\nactually testify.", "Des déclarations ne peuvent être contradictoires<E049><E003 8> <E025 3>que si la personne\ndépose formellement à la barre.");
                s = s.Replace("But in case you hadn't noticed...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 2 1><E139 112>the person you're accusing\r\nisn't even in the stand!", "Mais au cas où cela vous aurait échappé...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 2 1><E139 112>l'individu que vous visez\nne se trouve même pas à la barre !");
                s = s.Replace("The defence appears unable to respond to that replication.", "La défense semble bien en peine de répliquer à cette objection.");
                s = s.Replace("Any further obviously deliberate obstructions to these\r\nproceedings will not be tolerated, <E049><E003 6><E025 3>Counsel.", "Toute nouvelle manœuvre dilatoire visant à entraver ces débats\nne sera pas tolérée, <E049><E003 6><E025 3>Maître.");
                s = s.Replace("Wait!<E049><E003 10>\r\n<E025 2><E007>(That's not strictly true, <E003 4>is it?)", "Attendez !<E049><E003 10>\r\n<E025 2><E007>(Ce n'est pas tout à fait exact, <E003 4>si ?)");
                s = s.Replace("(A person doesn't necessarily have to be in the stand to\r\nsay something that doesn't add up in court.)", "(Une personne n'a pas nécessairement besoin d'être à la barre pour dire une chose contradictoire au tribunal.)");
                s = s.Replace("Mr Naruhodo, <E049><E003 6>I'm quite sure...", "M. Naruhodo, <E049><E003 6>j'en suis persuadée...");
                s = s.Replace("...that you're just a step away from the right answer!", "...vous n'êtes qu'à un pas de la bonne réponse !");
                s = s.Replace("(I just need to listen carefully to what people are saying\r\nagain...)", "(Il me suffit de réécouter attentivement ce que chacun a dit...)");
                return s;
            };

            // [57] BB\script\output\_sce04_c102_0010_eng#23
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#23"] = (s) => {
                s = s.Replace("By you...<E049><E003 10><E145 1 7><E144 1><E330><E025 2>Kazuma Asogi.", "Par vous...<E049><E003 10><E145 1 7><E144 1><E330><E025 2>Kazuma Asogi.");
                s = s.Replace("Is this some attempt at filibustering, <E049><E003 6><E025 3>Counsel?", "Est-ce là une pitoyable tentative d'obstruction, <E049><E003 6><E025 3>Maître ?");
                s = s.Replace("Prosecutor Asogi has given no testimony.", "Le procureur Asogi n'a fait aucune déposition en qualité de témoin.");
                return s;
            };

            // [58] BB\script\output\_sce04_c102_0010_eng#24
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#24"] = (s) => {
                s = s.Replace("What are you suggesting I said that was inconsistent?", "Que prétendez-vous que j'aie dit de contradictoire ?");
                s = s.Replace("You let something slip <E049><E003 10><E145 1 21><E118 1 0.6><E003 20><E025 2>that you shouldn't have.", "Une parole vous a échappé, <E049><E003 10><E145 1 21><E118 1 0.6><E003 20><E025 2>qui n'aurait jamais dû être prononcée.");
                s = s.Replace("When I present the relevant piece of evidence, <E049><E003 8><E025 2>I imagine\r\nyou'll realise what you've done.", "Lorsque je produirai la pièce à conviction appropriée, <E049><E003 8><E025 2>j'imagine\r\nque vous réaliserez votre bévue.");
                s = s.Replace("Very well then, Counsel, <E049><E003 10><E025 3>go ahead.", "Fort bien dans ce cas, Maître, <E049><E003 10><E025 3>poursuivez.");
                return s;
            };

            // [59] BB\script\output\_sce04_c102_0010_eng#25
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#25"] = (s) => {
                s = s.Replace("What evidence reveals this alleged inconsistency<E049><E003 10> <E025 1><E346>in\r\nsomething Prosecutor Asogi has said?", "Quelle preuve matérielle révèle cette prétendue contradiction<E049><E003 10> <E025 1><E346>dans\r\nles propos tenus par le procureur Asogi ?");
                return s;
            };

            // [60] BB\script\output\_sce04_c102_0010_eng#26
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#26"] = (s) => {
                s = s.Replace("So...<E049><E003 12><E025 3>my initial impressions were correct.", "Ainsi...<E049><E003 12><E025 3>mes impressions premières étaient fondées.");
                s = s.Replace("This is nonsense.", "C'est un non-sens absolu.");
                s = s.Replace("You accuse your best friend and back it up with that?", "Tu oses accuser ton meilleur ami et tu t'appuies sur cela ?");
                s = s.Replace("Clearly...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 3 1><E139 112>the Ryunosuke Naruhodo I knew is dead!", "À l'évidence...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 3 1><E139 112>le Ryunosuke Naruhodo que j'ai connu est bel et bien mort !");
                s = s.Replace("(Ugh...<E003 12>struck down by my best friend...)", "(Ouch...<E003 12>frappé en plein cœur par mon meilleur ami...)");
                s = s.Replace("I believe what you intended to point out, <E003 4>Mr Naruhodo,<E049><E003 4><E145 9 13><E003 8>\r\n<E025 3>was when Kazuma said...", "Je crois que ce que vous souhaitiez souligner, <E003 4>M. Naruhodo,<E049><E003 4><E145 9 13><E003 8>\r\n<E025 3>c'est lorsque Kazuma a affirmé...");
                s = s.Replace("Because at the time <E049><E003 8>he was making his way to the\r\nsteamship docked on the northern coast of France.", "Puisqu'à cet instant précis, <E049><E003 8>il gagnait le vapeur amarré\r\nsur les côtes de France.");
                s = s.Replace("As shown by the passport found in the victim's metal\r\ntrunk.", "Comme en atteste le passeport retrouvé dans sa malle en métal.");
                s = s.Replace("Yes, <E003 8><E025 3>that's exactly it.", "Oui, <E003 8><E025 3>c'est exactement cela.");
                s = s.Replace("...I take it from your expression that you're not going to let\r\nthis go.", "...Je déduis de votre regard que vous ne lâcherez pas prise si facilement.");
                s = s.Replace("Correct, <E049><E003 8>My Lord.<E049><E003 12>\r\n<E025 2><E341>I made a mistake, <E049><E003 6>that's all.", "En effet, <E049><E003 8>Votre Honneur.<E049><E003 12>\r\n<E025 2><E341>J'ai simplement commis une erreur de précipitation.");
                return s;
            };

            // [61] BB\script\output\_sce04_c102_0010_eng#28
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#28"] = (s) => {
                s = s.Replace("You said the victim's passport was found in his ‘metal trunk’...", "Vous avez dit que le passeport de la victime a été retrouvé dans sa « malle en métal »...");
                s = s.Replace("Yes, what of it?", "Oui, et alors ?");
                s = s.Replace("The passport was found on the victim's person, not in any trunk!", "Le passeport se trouvait sur le cadavre lui-même, pas dans une malle !");
                s = s.Replace("How could you have known about that metal trunk?!", "Comment pouviez-vous connaître l'existence de cette malle en métal ?!");
                s = s.Replace("That trunk was hidden in Gregson's secret office!", "Cette malle était dissimulée dans le bureau secret de Gregson !");
                s = s.Replace("And only the killer could have known about it!", "Et seul l'assassin pouvait en avoir connaissance !");
                return s;
            };

            // [62] BB\script\output\_sce04_c102_0010_eng#29
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#29"] = (s) => {
                s = s.Replace("What is the meaning of this, Prosecutor Asogi?!", "Qu'est-ce que cela signifie, procureur Asogi ?!");
                s = s.Replace("How did you know about the metal trunk?", "Comment étiez-vous au courant pour cette malle en métal ?");
                s = s.Replace("I...<E049><E003 8>I was informed of it during Scotland Yard's search.", "J'en ai... <E049><E003 8>j'en ai été informé lors des perquisitions de Scotland Yard.");
                s = s.Replace("That's impossible! The search team hasn't filed any report on a trunk!", "C'est impossible ! Les enquêteurs n'ont encore consigné aucun rapport sur une malle !");
                return s;
            };

            // [63] BB\script\output\_sce04_c102_0010_eng#30
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#30"] = (s) => {
                s = s.Replace("Quiet! Order in the courtroom!", "Silence ! Du calme dans le prétoire !");
                s = s.Replace("Prosecutor Asogi, <E049><E003 6>explain your slip of the tongue.", "Procureur Asogi, <E049><E003 6>expliquez ce lapsus révélateur.");
                s = s.Replace("It was no slip of the tongue.", "Ce n'était nullement un lapsus.");
                s = s.Replace("I knew about the trunk because I investigated the scene myself.", "Je connaissais l'existence de cette malle pour m'être rendu sur les lieux moi-même.");
                return s;
            };

            // [64] BB\script\output\_sce04_c102_0010_eng#31
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#31"] = (s) => {
                s = s.Replace("You went to Fresno Street yourself?", "Vous vous êtes rendu rue Fresno en personne ?");
                s = s.Replace("Yes. Late yesterday evening.", "Oui. Tard hier soir.");
                s = s.Replace("And I found the trunk in that hidden room.", "Et j'ai trouvé cette malle dans la pièce dérobée.");
                s = s.Replace("Inside it were documents that prove beyond all doubt...", "Elle renfermait des documents qui prouvent sans l'ombre d'un doute...");
                s = s.Replace("...that the Reaper was none other than Barok van Zieks!", "...que le Faucheur n'était nul autre que Drake Van Peers !");
                return s;
            };

            // [65] BB\script\output\_sce04_c102_0010_eng#32
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#32"] = (s) => {
                s = s.Replace("What documents?!", "Quels documents ?!");
                s = s.Replace("Letters exchanged between Tobias Gregson and Lord van Zieks.", "Des correspondances secrètes échangées entre Tobias Gregson et Lord Van Peers.");
                s = s.Replace("Directly discussing the assassination of targets!", "Où il est fait mention explicite de l'assassinat de leurs cibles !");
                s = s.Replace("The prosecution submits these letters into evidence!", "L'accusation verse ces missives au dossier en tant que preuves !");
                s = s.Replace("The Reaper's Letters have been entered into the Court Record.", "Les lettres du Faucheur ont été versées au dossier de l'affaire.");
                return s;
            };

            // [66] BB\script\output\_sce04_c102_0010_eng#33
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#33"] = (s) => {
                s = s.Replace("Is this true, Lord van Zieks?!", "Est-ce la vérité, Lord Van Peers ?!");
                s = s.Replace("Did you write these letters?!", "Avez-vous rédigé ces lettres ?!");
                s = s.Replace("I have never seen those letters before in my life.", "Je n'ai jamais posé les yeux sur ces écrits de toute mon existence.");
                s = s.Replace("They are forgeries!", "Ce sont des faux éhontés !");
                return s;
            };

            // [67] BB\script\output\_sce04_c102_0010_eng#34
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#34"] = (s) => {
                s = s.Replace("Forgeries? With your wax seal on every envelope?", "Des faux ? Alors qu'ils portent tous l'empreinte de votre sceau personnel ?");
                s = s.Replace("You really need to learn how to read your fellow man...<E049><E003 12>\r\n<E025 3>my Nipponese friend.", "Vous devriez vraiment apprendre à sonder le cœur des hommes...<E049><E003 12>\r\n<E025 3>mon cher ami japonais.");
                s = s.Replace("(...Read them...<E003 12>or ‘reap’ them?)", "(...Les sonder...<E003 12>ou les faucher ?)");
                return s;
            };

            // [68] BB\script\output\_sce04_c102_0010_eng#35
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#35"] = (s) => {
                s = s.Replace("(So that's what we have to work with...)", "(Voilà donc les éléments avec lesquels nous devons composer...)");
                s = s.Replace("It may help us that Lord van Zieks is in the stand, too.", "La présence de Lord Van Peers à la barre pourrait nous être précieuse.");
                s = s.Replace("Yes, <E003 8>perhaps.", "Oui, <E003 8>sans doute.");
                s = s.Replace("I'm sure Gina knows nothing she hasn't already told us.<E049><E003 10>\r\n<E025 2>There's no point trying to get more out of her.", "Je suis certain que Gina a déjà dit tout ce qu'elle savait.<E049><E003 10>\r\n<E025 2>Inutile d'insister auprès d'elle.");
                s = s.Replace("...Did you notice how Kazuma-sama reacted to Lord van\r\nZieks's words?", "...Avez-vous remarqué la réaction de Kazuma face aux propos de Lord Van Peers ?");
                s = s.Replace("When he called him an even more sinister Reaper,<E003 6> you\r\nmean?", "Quand il l'a qualifié de Faucheur encore plus sinistre, <E003 6>vous voulez dire ?");
                s = s.Replace("Well, <E003 8><E025 2>I'm sure Kazuma intends to eliminate <E145 9 8>any shred of\r\ndoubt that the man is guilty.", "Eh bien, <E003 8><E025 2>je suis convaincu que Kazuma veut balayer <E145 9 8>le moindre doute sur sa culpabilité.");
                s = s.Replace("He's looking for revenge against the person he considers\r\nto be his father's killer, <E003 4><E025 3>after all.", "Il cherche à venger celui qu'il tient pour le meurtrier de son père, <E003 4><E025 3>après tout.");
                s = s.Replace("I do worry that if we fail to find a discrepancy in this\r\ntestimony somewhere...", "Je crains que si nous ne décelons point de contradiction dans cette déposition...");
                s = s.Replace("...the trial may end <E049><E003 8><E025 3>and adjudication won't go in our\r\nfavour.", "...le procès ne prenne fin <E049><E003 8><E025 3>et que le verdict nous soit fatal.");
                s = s.Replace("Let's listen carefully again to what everybody is saying...", "Écoutons de nouveau attentivement ce que chacun déclare...");
                return s;
            };

            // [69] BB\script\output\_sce04_c102_0010_eng#42
            entryTranslators[@"BB\script\output\_sce04_c102_0010_eng#42"] = (s) => {
                s = s.Replace("We've wasted enough time!", "Nous avons perdu bien assez de temps !");
                s = s.Replace("It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.", "Il m'apparaît avec évidence <E049><E003 8><E025 2>que prolonger ces débats serait vain et stérile.");
                s = s.Replace("Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...", "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que malgré vos égarements...");
                s = s.Replace("...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...", "...vous n'agissiez pas moins guidé par un idéal de justice.<E049><E003 12>\r\n<E025 3>Qu'il m'en coûte d'en arriver à cette funeste conclusion...");
                s = s.Replace("Wait, My Lord!", "Attendez, Votre Honneur !");
                s = s.Replace("In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "En vertu des conclusions de ce tribunal, <E049><E003 6><E025 3>je déclare l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                s = s.Replace("That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!", "L'affaire est entendue.<E049><E003 10>\r\n<E025 2>L'audience est levée !");
                return s;
            };

        }
    }
}
