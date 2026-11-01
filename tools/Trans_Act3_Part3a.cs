using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct3 {
    public partial class Program {
        public static void RegisterPart3a() {
            // BB\script\output\_sce02_bg0305_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("I'm sorry, Mr Naruhodo.<E003 8> That machine is covered by the\r\nSpecial Dispensation for Scientific Equipment Act.",
                              "Je suis désolée, Mr Naruhodo.<E003 8> Cette machine relève de la loi\r\nsur la dispense spéciale pour équipements scientifiques.");
                s = s.Replace("There would be serious repercussions if you were to\r\nexamine it!<E049><E003 8> From the Crown and the government.",
                              "Il y aurait de graves répercussions si vous vous avisiez de\r\nl'examiner !<E049><E003 8> De la Couronne et du gouvernement.");
                s = s.Replace("(Well those two don't seem to be holding back.)",
                              "(Eh bien, ces deux-là ne semblent guère s'embarrasser de scrupules.)");
                s = s.Replace("It's quite hollow inside.<E049><E003 8> No working parts or devices of\r\ndeception to be seen,<E003 6> my dear fellow.",
                              "C'est parfaitement creux à l'intérieur.<E049><E003 8> Pas la moindre pièce\r\nmécanique ni trucage en vue,<E003 6> mon cher ami.");
                s = s.Replace("No loose change dropped on the floor or nuffin'.<E049><E003 8>\r\nNot even a bone for Toby 'ere...<E003 10>my dear fella.",
                              "Pas une piécette tombée par terre ni rien.<E049><E003 8>\r\nMême pas un os pour Toby...<E003 10> mon cher ami.");
                s = s.Replace("British people are very much ruled by their own ideals,<E003 6>\r\naren't they?",
                              "Les Britanniques sont vraiment guidés par leurs propres principes,<E003 6>\r\nn'est-ce pas ?");
                s = s.Replace("...I think that's just these two,<E003 6> Miss Susato.",
                              "... Je crois que ça ne concerne que ces deux-là,<E003 6> Mlle Susato.");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Ah...<E003 8><E145 2 66><E003 8><E025 2>this appears to be most interesting.<E049><E003 12>\r\nYes,<E003 8> most interesting indeed, wouldn't you say?",
                              "Ah...<E003 8><E145 2 66><E003 8><E025 2> ceci paraît des plus intéressants.<E049><E003 12>\r\nOui,<E003 8> tout à fait fascinant, ne trouvez-vous pas ?");
                s = s.Replace("It's an impressive-looking back massager,<E003 6> that's for sure.",
                              "C'est un masseur de dos impressionnant,<E003 6> c'est bien certain.");
                s = s.Replace("I've no doubt that if you hit your shoulders a few times\r\nwith that,<E145 2 64><E003 6> your aches and pains would soon go away.",
                              "Je ne doute pas qu'en se tapotant les épaules avec ceci,<E145 2 64><E003 6>\r\ntoutes vos courbatures s'envoleraient.");
                s = s.Replace("It's a Royal Society trophy for excellence in science.<E049><E003 10>\r\nA young scientist could wish for no higher honour.",
                              "C'est un trophée de la Société Royale récompensant l'excellence scientifique.<E049><E003 10>\r\nUn jeune chercheur ne saurait rêver de plus grand honneur.");
                s = s.Replace("Ah.", "Ah.");
                s = s.Replace("Would you<E049><E003 8> like a massage?", "Désirez-vous<E049><E003 8> un petit massage ?");
                s = s.Replace("No no!<E003 12>\r\n<E025 3>No,<E003 6> I'm fine,<E003 10> <E025 1><E331>thank you!",
                              "Non non !<E003 12>\r\n<E025 3>Non,<E003 6> tout va bien,<E003 10> <E025 1><E331>merci !");
                s = s.Replace("(I had no idea it was such a grand thing.)",
                              "(Je n'avais aucune idée qu'il s'agissait d'un prix si prestigieux.)");
                s = s.Replace("I think it's becoming increasingly clear...",
                              "Je pense qu'il devient de plus en plus évident...");
                s = s.Replace("...that there's much more to this Mr Enoch Drebber<E049><E003 8> than\r\nconjuring tricks.",
                              "... que cet Enoch Drebber est bien plus<E049><E003 8> qu'un simple faiseur de tours.");
                s = s.Replace("...I couldn't agree more,<E003 4> my dear madam.",
                              "... Je ne saurais être plus d'accord,<E003 4> ma chère demoiselle.");
                s = s.Replace("And how about you,<E003 6> Mr Naruhodo?<E049> <E145 3 64><E172 3 -12 -7 16 2 0><E003 12>\r\nWouldn't you like to take it with you?",
                              "Et qu'en est-il de vous,<E003 6> Mr Naruhodo ?<E049> <E145 3 64><E172 3 -12 -7 16 2 0><E003 12>\r\nNe souhaiteriez-vous pas l'emporter ?");
                s = s.Replace("For your tired shoulders,<E003 6> of course.<E145 3 76><E173 3 1 23 2>",
                              "Pour soulager vos épaules endolories,<E003 6> naturellement.<E145 3 76><E173 3 1 23 2>");
                s = s.Replace("(He's not going to let that go,<E003 8> is he?)",
                              "(Il ne va pas lâcher l'affaire de sitôt,<E003 8> n'est-ce pas ?)");
                s = s.Replace("It's curious though,<E003 4> isn't it?<E145 2 64>",
                              "C'est curieux quand même,<E003 4> non ?<E145 2 64>");
                s = s.Replace("You would expect such an important trophy to be proudly\r\non display somewhere,<E003 4> not haphazardly cast aside.",
                              "On s'attendrait à ce qu'une récompense si prestigieuse soit fièrement\r\nexposée,<E003 4> et non négligemment jetée au rebut.");
                s = s.Replace("English gentlemen<E049><E003 6> can be quite a mystery at times...",
                              "Les gentlemen anglais<E049><E003 6> sont parfois un bien grand mystère...");
                s = s.Replace("The science trophy has been\r\nentered into the Court Record.",
                              "Le trophée scientifique a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("This door...<E003 15><E330><E025 2>doesn't want to open.",
                              "Cette porte...<E003 15><E330><E025 2> refuse de s'ouvrir.");
                s = s.Replace("Yeah,<E049> <E145 122 74><E118 122 1.4><E003 15><E025 2>looks like it's got a pretty hefty lock on it.",
                              "Ouaip,<E049> <E145 122 74><E118 122 1.4><E003 15><E025 2>on dirait bien qu'y a un sacré verrou dessus.");
                s = s.Replace("There's a specialist locksmith on his way over from the\r\nYard.<E049><E003 4> <E164 7 75 1 2 6 0 2 1><E139 7>So hands off till he gets here!",
                              "Y a un serrurier d'Scotland Yard qui arrive.<E049><E003 4> <E164 7 75 1 2 6 0 2 1><E139 7>Alors pas touche avant qu'il s'ramène !");
                s = s.Replace("With permission,<E145 7 65><E117 7 25><E003 6> Inspector,<E049><E003 8> <E164 2 79 1 2 8 0 2 1><E139 2><E025 1>I could have that lock open in\r\nless than a minute.",
                              "Si vous me le permettez,<E145 7 65><E117 7 25><E003 6> inspecteur,<E049><E003 8> <E164 2 79 1 2 8 0 2 1><E139 2><E025 1>je pourrais forcer cette serrure\r\nen moins d'une minute.");
                s = s.Replace("Well you don't have permission.<E049><E003 18>\r\n<E149 7 1 1><E330>An' no one's<E003 8> <E145 2 76>givin' it to you.",
                              "Ben t'as pas ma permission.<E049><E003 18>\r\n<E149 7 1 1><E330>Et personne<E003 8> <E145 2 76>va t'la donner.");
                s = s.Replace("(Gregson looked as though he really enjoyed that...)",
                              "(Gregson avait l'air de savourer ce moment...)");
                s = s.Replace("Well,<E049><E003 8> <E145 3 64><E118 3 1.2><E149 3 0 3><E003 6>there's no sound of anybody on the other side.",
                              "En tout cas,<E049><E003 8> <E145 3 64><E118 3 1.2><E149 3 0 3><E003 6>on n'entend aucun bruit de l'autre côté.");
                s = s.Replace("No.<E003 10> Drebber must have fled at the first sign of danger.",
                              "Non.<E003 10> Drebber a dû prendre la fuite dès les premiers signes de danger.");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Mr Sholmes managed to open that door in almost no time\r\nat all.<E003 14> <E333><E025 1>It was incredible!",
                              "Mr Holmes a réussi à ouvrir cette porte en un clin d'œil.<E003 14> <E333><E025 1>C'était incroyable !");
                s = s.Replace("Thanks to one of his great deductions, no doubt!<E049><E003 4>\r\n<E164 3 87 1 2 1 0 1 1><E139 3><E025 1>About the shape of the lock set into the door!",
                              "Grâce à l'une de ses grandes déductions, sans doute !<E049><E003 4>\r\n<E164 3 87 1 2 1 0 1 1><E139 3><E025 1>Sur le mécanisme interne du verrou !");
                s = s.Replace("...I think maybe you're putting too much stock in his\r\ndeductive abilities.",
                              "... Je crois que vous surestimez quelque peu ses talents de déduction.");
                s = s.Replace("Aaanyway,<E003 10> <E025 2>what's waiting for us on the other side,<E003 6> that's\r\nthe question, isn't it?",
                              "Breeef,<E003 10> <E025 2>la question est plutôt de savoir ce qui nous attend\r\nde l'autre côté, n'est-ce pas ?");
                s = s.Replace("(And there's no point trying to deduce that.<E003 14>\r\n<E025 1><E346>Let's just go and see!)",
                              "(Et inutile d'échafauder des théories là-dessus.<E003 14>\r\n<E025 1><E346>Allons simplement voir !)");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("This...<E003 12> This is...", "C'est...<E003 12> C'est...");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("This...<E003 12> This is...", "C'est...<E003 12> C'est...");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("It's a European-style quiver of arrows!<E003 12>\r\n<E025 1><E338><E341>With steel bolts inside!",
                              "C'est un carquois de style européen !<E003 12>\r\n<E025 1><E338><E341>Garni de carreaux d'acier !");
                s = s.Replace("Oh!<E003 16> <E025 2>Do you suppose...?", "Oh !<E003 16> <E025 2>Pensez-vous que... ?");
                s = s.Replace("Crossbow bolts,<E003 4> these.", "Des carreaux d'arbalète,<E003 4> ouais.");
                s = s.Replace("And just the right size for the bow you lot turned up at\r\nthe exhibition grounds.",
                              "Et pile de la bonne taille pour l'arbalète que vous avez dénichée\r\nsur le site de l'exposition.");
                s = s.Replace("In other words...", "Autrement dit...");
                s = s.Replace("Yup.<E003 12> <E025 2>That's more evidence to support your theory.",
                              "Ouaip.<E003 12> <E025 2>Ça fait une preuve de plus pour étayer vot' théorie.");
                s = s.Replace("It all goes to show that Drebber was the one pullin' the\r\nstrings behind the scenes of the whole scam.",
                              "Tout indique que c'est Drebber qui tirait les ficelles en douce\r\nde toute cette arnaque.");
                s = s.Replace("The details of the crossbow\r\nhave been updated in the Court Record.",
                              "Les détails concernant l'arbalète ont été mis\r\nà jour dans le dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0305_1_check_eng#12
            entryTranslators["BB\\script\\output\\_sce02_bg0305_1_check_eng#12"] = en => {
                string s = en;
                s = s.Replace("What<E003 10> <E341>on earth is this?", "Mais qu'est-ce que<E003 10> <E341>c'est que ça ?");
                s = s.Replace("An ‘aeroplane’, Mr Naruhodo.<E049><E003 10> <E025 2><E145 3 64><E003 15>One day,<E003 4> scientists believe\r\nit will allow humans to fly freely in the skies.",
                              "Un « aéroplane », Mr Naruhodo.<E049><E003 10> <E025 2><E145 3 64><E003 15>Un jour,<E003 4> les scientifiques\r\npensent qu'il permettra aux hommes de fendre les cieux.");
                s = s.Replace("...Is that how the trick will be described,<E003 6> is it?",
                              "... C'est ainsi qu'on présentera le tour de magie,<E003 6> n'est-ce pas ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Well,<E003 10> <E330>it's actually <E006>suspended<E005> by a thin,<E003 4> but very strong\r\ncable,<E003 8> isn't it?",
                              "Eh bien,<E003 10> <E330>il est en fait <E006>suspendu<E005> par un câble mince,<E003 4> mais très\r\nrésistant,<E003 8> pas vrai ?");
                s = s.Replace("Oh!<E003 12> <E025 3>Well...<E003 8><E025 2>this model is,<E003 4> yes.<E049><E003 10> But a real aeroplane would\r\nactually fly high in the sky.",
                              "Oh !<E003 12> <E025 3>Eh bien...<E003 8><E025 2> cette maquette l'est,<E003 4> oui.<E049><E003 10> Mais un véritable aéroplane\r\nvolerait réellement tout là-haut dans le ciel.");
                s = s.Replace("...While suspended from somewhere <E006>even higher in the\r\nsky<E005>,<E003 6> of course.",
                              "... Tout en restant suspendu depuis un point <E006>encore plus élevé dans\r\nle ciel<E005>,<E003 6> bien évidemment.");
                s = s.Replace("Because<E003 6> <E346>large metal objects obviously can't really stay in\r\nmid-air unsupported!",
                              "Parce que<E003 6> <E346>de gros objets de ferraille ne peuvent visiblement\r\npas flotter dans les airs sans soutien !");
                s = s.Replace("...So to you<E003 6> the solution is...<E003 8>ever taller towers?",
                              "... Donc pour vous,<E003 6> la solution serait...<E003 8> des tours toujours plus hautes ?");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("(It really looks like a punishment to me...)",
                              "(Ça ressemble à une vraie punition à mes yeux...)");
                s = s.Replace("I've never seen someone sitting like that before!",
                              "Je n'ai jamais vu quelqu'un assis de la sorte !");
                s = s.Replace("He hasn't moved a muscle since we arrived.",
                              "Il n'a pas bougé d'un cil depuis notre arrivée.");
                s = s.Replace("Do you think perhaps he's dead?", "Penses-tu qu'il soit mort ?");
                s = s.Replace("If he was dead, Runo, <E049><E003 6>he wouldn't be sitting up, <E003 4>would he?",
                              "S'il était mort, Nicky, <E049><E003 6>il ne tiendrait pas assis tout droit, <E003 4>non ?");
                s = s.Replace("Well anyway, <E003 6>dead or alive, <E003 8><E025 2>he's not overly approachable,<E003 8>\r\nis he?<E003 8> <E025 2>I don't think he's going to talk to us.",
                              "Quoi qu'il en soit, <E003 6>mort ou vif, <E003 8><E025 2>il n'a pas l'air très abordable,<E003 8>\r\nhein ?<E003 8> <E025 2>Je ne pense pas qu'il veuille nous adresser la parole.");
                s = s.Replace("He's not dead!", "Il n'est pas mort !");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Lord van Zieks's desk, <E003 4>look.<E003 10>\r\nIt's so stylish.",
                              "Le bureau de Lord Van Peers, <E003 4>regarde.<E003 10>\r\nIl a tant d'allure.");
                s = s.Replace("And that's a marble chess set beside it.",
                              "Et il y a un jeu d'échecs en marbre juste à côté.");
                s = s.Replace("Chess<E025 7>...<E003 12> <E025 2><E338><E341>That's the Western version of our Japanese ‘shogi’\r\ngame, <E003 6>isn't it?",
                              "Les échecs<E025 7>...<E003 12> <E025 2><E338><E341>C'est l'équivalent occidental de notre jeu de\r\n« shogi », <E003 6>n'est-ce pas ?");
                s = s.Replace("You know, <E003 8><E330>I'm actually quite good at shogi problems.",
                              "Tu sais, <E003 8><E330>je suis plutôt doué pour résoudre des problèmes de shogi.");
                s = s.Replace("Oh, really?<E049><E003 6> <E164 110 66 1 2 6 0 0 1><E118 110 1.2><E139 110><E025 2>You'd probably like chess problems, in that\r\ncase.",
                              "Oh, vraiment ?<E049><E003 6> <E164 110 66 1 2 6 0 0 1><E118 110 1.2><E139 110><E025 2>Tu aimerais sûrement les problèmes d'échecs, dans\r\nce cas.");
                s = s.Replace("...I'd love to challenge Lord van Zieks sometime.",
                              "... J'aimerais beaucoup défier Lord Van Peers un jour.");
                s = s.Replace("To a bout of shogi problems.", "Sur une série d'énigmes de shogi.");
                s = s.Replace("If you only really want to challenge yourself, <E049><E003 6>you can\r\nalways do that on your own at home.",
                              "Si tu veux simplement te lancer des défis, <E049><E003 6>tu peux toujours\r\nle faire tout seul à la maison.");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Ooh, <E049><E003 10>look!<E049><E003 12> It's a scale model of the Great Exhibition\r\nshowground!",
                              "Oh, <E049><E003 10>regarde !<E049><E003 12> C'est une maquette à l'échelle de toute l'Exposition\r\nUniverselle !");
                s = s.Replace("That's amazing.<E003 10> I wonder why it's here...",
                              "C'est fantastique.<E003 10> Je me demande ce qu'elle fait là...");
                s = s.Replace("Perhaps he made it to take his mind off the sadness of\r\nbeing too busy to attend in person?",
                              "Peut-être l'a-t-il fabriquée pour compenser la tristesse d'être\r\ntrop occupé pour s'y rendre en personne ?");
                s = s.Replace("Or perhaps he's too embarrassed to queue up for a ticket.",
                              "Ou alors il a trop honte de faire la queue pour un billet.");
                s = s.Replace("Surely it's obvious that I'm using it as an investigative aid!",
                              "Il est pourtant évident que je l'utilise comme outil d'enquête !");
                s = s.Replace("Agh!", "Argh !");
                s = s.Replace("You Nipponese have no business painting others as overly\r\nreserved.",
                              "Vous autres Nippons feriez mieux d'éviter de juger la réserve d'autrui.");
                s = s.Replace("(Ugh<E025 7>...<E003 12> <E025 3>I really didn't think he'd overhear that.)",
                              "(Argh<E025 7>...<E003 12> <E025 3>je ne pensais vraiment pas qu'il entendrait cela.)");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("Look at that fine collection of hallowed chalices and\r\nbottles neatly lined up there...",
                              "Regarde cette remarquable collection de calices sacrés et de\r\nflacons soigneusement alignés...");
                s = s.Replace("My hallowed bottles <E049><E003 8><E025 2>are filled with the essence of the\r\nfinest grapes from the finest vineyards I visit.",
                              "Mes bouteilles bénies <E049><E003 8><E025 2>sont remplies du nectar des\r\nraisins les plus nobles récoltés dans les plus grands domaines.");
                s = s.Replace("And I personally oversee these chalices <E049><E003 8><E025 2>being made by\r\nthe finest crystal craftsmen in the world.",
                              "Et je supervise moi-même la taille de ces calices <E049><E003 8><E025 2>confiée\r\naux meilleurs artisans verriers du monde.");
                s = s.Replace("And yet <E164 110 71 1 2 6 0 0 1><E118 110 1.3>you throw them around <E139 110>in court like they were\r\nworthless.",
                              "Et pourtant <E164 110 71 1 2 6 0 0 1><E118 110 1.3>vous les jetez <E139 110>dans le prétoire comme s'ils\r\nne valaient rien.");
                s = s.Replace("Yes...<E003 8><E145 18 9><E003 10><E025 3><E330>because this imbecile is so unimaginably and\r\nrepeatedly wide of the mark sometimes.",
                              "En effet...<E003 8><E145 18 9><E003 10><E025 3><E330> parce que cet imbécile tape si impensablement et\r\nsi souvent à côté de la plaque.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("Before you open your mouth next time,<E049><E003 10> <E025 2><E239>you should\r\nconsider the poor artisans<E003 6> whose work you defile.",
                              "Avant d'ouvrir la bouche la prochaine fois,<E049><E003 10> <E025 2><E239>vous devriez avoir\r\nune pensée pour les pauvres artisans<E003 6> dont vous souillez le labeur.");
                s = s.Replace("So<E025 7>...<E003 8><E025 3>it's my fault?<E003 14>\r\n...Silly me.<E003 8> <E025 2>How could I ever have thought otherwise?",
                              "Alors<E025 7>...<E003 8><E025 3> c'est de ma faute ?<E003 14>\r\n... Quel étourdi je fais.<E003 8> <E025 2>Comment ai-je pu penser l'inverse ?");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Look at all those ancient casks lining the wall there.",
                              "Regarde tous ces tonneaux séculaires le long du mur.");
                s = s.Replace("Casks in the Reaper's chamber...<E049><E003 4>\r\n<E025 3><E145 110 73><E003 15><E330>...Or are they caskets?",
                              "Des tonneaux dans l'antre du Faucheur...<E049><E003 4>\r\n<E025 3><E145 110 73><E003 15><E330>... Ou bien des cercueils ?");
                s = s.Replace("You, <E003 10><E341>you don't think...", "Tu... <E003 10><E341>tu ne penses pas quand même que...");
                s = s.Replace("...all those <E003 6>p-<E003 6><E239>people who escaped <E003 6>c-<E003 6>c-<E003 8><E342>conviction <E145 110 72><E117 110 95>in court\r\nare lying inside them...<E003 8><E025 4>d-<E003 10><E342>dead, <E003 8>do you?",
                              "... tous ces <E003 6>g-<E003 6><E239>gens qui ont échappé à une <E003 6>c-<E003 6>c-<E003 8><E342>condamnation <E145 110 72><E117 110 95>au tribunal\r\nreposent là-dedans... <E003 8><E025 4>m-<E003 10><E342>morts, <E003 8>si ?");
                s = s.Replace("What ridiculous notions are going through your head,\r\nman?<E049><E003 12> <E025 1><E335>This is my collection of fine vintages!",
                              "Quelles fadaises absurdes vous traversent l'esprit ?<E049><E003 12>\r\n<E025 1><E335>Il s'agit de ma collection de grands crus classés !");
                s = s.Replace("Oh...<E003 10>yes, <E003 6>of course.<E145 18 0><E003 10>\r\nThank you for clearing that up...",
                              "Oh...<E003 10> oui, <E003 6>bien entendu.<E145 18 0><E003 10>\r\nMerci d'avoir éclairci ce point...");
                s = s.Replace("Runo and I were just musing to ourselves.<E049><E003 8>\r\n<E164 110 66 1 2 6 0 0 1><E139 110>Don't mind us, Mr Reaper.",
                              "Nicky et moi discutions simplement entre nous.<E049><E003 8>\r\n<E164 110 66 1 2 6 0 0 1><E139 110>Ne faites pas attention à nous, Mr le Faucheur.");
                s = s.Replace("I wouldn't, <E049><E003 8><E025 2><E603>if you hadn't invited yourselves to my office\r\nto talk nonsense within my earshot.",
                              "C'est ce que je ferais, <E049><E003 8><E025 2><E603>si vous ne vous étiez pas invités\r\ndans mes appartements pour débiter des insanités à portée de voix.");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("That portrait really dominates the room, <E003 8>doesn't it?",
                              "Ce portrait impose vraiment sa présence dans la pièce, <E003 8>non ?");
                s = s.Replace("It's a very majestic outfit and pose.<E003 15>\r\nBut sadly...",
                              "La pose et la tenue sont d'une grande majesté.<E003 15>\r\nMais hélas...");
                s = s.Replace("...whoever painted it didn't do a very good job of capturing\r\nLord van Zieks's facial features.",
                              "... l'artiste n'a pas franchement réussi à restituer les traits\r\nde Lord Van Peers.");
                s = s.Replace("Yes, <E003 6>you're right.<E049><E003 10> I mean, <E003 6>it's not far off, <E003 6>but the artist has\r\nexaggerated his subject's handsomeness, I think.",
                              "Oui, <E003 6>tu as raison.<E049><E003 10> C'est-à-dire que ce n'est pas si loin, <E003 6>mais le peintre a\r\nnettement embelli son modèle, je trouve.");
                s = s.Replace("Ah!<E003 14> <E025 2>That reminds me...", "Ah !<E003 14> <E025 2>Ça me rappelle quelque chose...");
                s = s.Replace("I heard Emperor Napoleon of France ordered artists to<E145 110 64>\r\nmake him look more attractive when they painted him.",
                              "J'ai entendu dire que l'empereur Napoléon ordonnait aux peintres<E145 110 64>\r\nde le rendre plus séduisant sur ses portraits.");
                s = s.Replace("How vain.<E049><E003 10> <E025 2><E330>That's really not an attractive quality in a\r\nperson, <E003 4>is it?",
                              "Quelle vanité.<E049><E003 10> <E025 2><E330>Ce n'est vraiment pas un trait de caractère\r\nreluisant, <E003 4>n'est-ce pas ?");
                s = s.Replace("That portrait does not depict me.<E049><E003 12>\r\n<E025 1><E204 140 0 0><E164 18 13 1 2 9 0 2 1><E139 18>Surely that's immediately obvious!",
                              "Ce portrait ne me représente aucunement.<E049><E003 12>\r\n<E025 1><E204 140 0 0><E164 18 13 1 2 9 0 2 1><E139 18>C'est pourtant d'une évidence limpide !");
                s = s.Replace("Oh!<E003 10> Then...<E003 10><E025 2>who is it?",
                              "Oh !<E003 10> Mais alors...<E003 10><E025 2> de qui s'agit-il ?");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Wah!<E003 20>\r\n<E025 1><E332>They were bats!",
                              "Waaah !<E003 20>\r\n<E025 1><E332>C'étaient des chauves-souris !");
                s = s.Replace("Yes.<E049><E003 8> The Reaper's familiars, <E003 4>I expect.",
                              "Oui.<E049><E003 8> Les familiers du Faucheur, <E003 4>j'imagine.");
                s = s.Replace("But what about the mute man in the dark cloak?<E003 10>\r\nI thought he was the familiar.",
                              "Mais qu'en est-il de l'homme muet sous sa cape noire ?<E003 10>\r\nJe pensais que c'était lui son familier.");
                s = s.Replace("Just not the flying kind.", "En version non volante, du moins.");
                s = s.Replace("He must be a dear friend of Mr Reaper, then.",
                              "Il doit être un ami très cher de Mr le Faucheur, alors.");
                s = s.Replace("I think the familiar idea is more likely.",
                              "L'idée du familier me paraît plus plausible.");
                s = s.Replace("(Scary though, <E003 8><E025 3>either way.)",
                              "(Effrayant dans les deux cas, <E003 8><E025 3>de toute façon.)");
                return s;
            };

            // BB\script\output\_sce02_bg0306_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0306_0_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("Um, <E003 8><E025 2>Lord van Zieks...", "Euh, <E003 8><E025 2>Lord Van Peers...");
                s = s.Replace("I think he's ignoring you, Runo.", "Je crois qu'il t'ignore superbement, Nicky.");
                s = s.Replace("The prosecution and defence should avoid speaking\r\noutside of the courtroom as a rule.",
                              "L'accusation et la défense se doivent d'éviter toute conversation\r\nen dehors du tribunal par principe.");
                s = s.Replace("So if anyone is being rude here,<E049><E003 10> <E025 2><E333>it's most certainly the\r\nman in black there standing before us.",
                              "Si quelqu'un se montre impoli ici,<E049><E003 10> <E025 2><E333>c'est très certainement cet\r\nindividu vêtu de noir devant nous.");
                s = s.Replace("Oh, <E003 10><E025 1>I see!<E049><E003 8> <E145 110 77><E139 110>Well, thank you for setting the record straight!",
                              "Oh, <E003 10><E025 1>je vois !<E049><E003 8> <E145 110 77><E139 110>Eh bien, merci d'avoir remis les pendules à l'heure !");
                s = s.Replace("Hehe!<E003 10> Did you see that?<E003 12>\r\n<E025 1>He spoke to me, Runo!",
                              "Hé hé !<E003 10> Tu as vu ça ?<E003 12>\r\n<E025 1>Il m'a parlé, Nicky !");
                s = s.Replace("So, <E003 8>Lord van Zieks, <E003 10><E025 2>have you managed to visit the Great\r\nExhibition yet?",
                              "Dites, <E003 8>Lord Van Peers, <E003 10><E025 2>avez-vous déjà eu l'occasion de visiter\r\nl'Exposition Universelle ?");
                s = s.Replace("He's definitely ignoring you.", "Il t'ignore totalement, cette fois.");
                s = s.Replace("(Right.<E003 8> No niceties either, then...)",
                              "(D'accord.<E003 8> Pas de politesses superflues non plus, alors...)");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("Look at this big thick book here.", "Regardez ce gros registre épais ici.");
                s = s.Replace("Ah, it appears to be an accounting ledger.<E049><E003 8> It's a record of\r\nthe Forensic Investigation Team's spending, I think.",
                              "Ah, on dirait un registre de comptabilité.<E049><E003 8> C'est l'état des dépenses\r\nde la police scientifique, je crois.");
                s = s.Replace("What is it?", "Qu'y a-t-il ?");
                s = s.Replace("It's clear that the team purchases various equipment and\r\nsupplies on a monthly basis, but...",
                              "Le service achète régulièrement du matériel et des fournitures\r\nchaque mois, mais...");
                s = s.Replace("Well,<E003 8> one entry seems rather strange.",
                              "Eh bien,<E003 8> une ligne semble particulièrement étrange.");
                s = s.Replace("Really?<E003 8> In what way?", "Vraiment ?<E003 8> En quoi ?");
                s = s.Replace("They're buying five hundred scalpels every month!",
                              "Ils achètent cinq cents scalpels chaque mois !");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Look at this big thick book here.", "Regardez ce gros registre épais ici.");
                s = s.Replace("Ah, it appears to be an accounting ledger.<E049><E003 8> It's a record of\r\nthe Forensic Investigation Team's spending, I think.",
                              "Ah, on dirait un registre de comptabilité.<E049><E003 8> C'est l'état des dépenses\r\nde la police scientifique, je crois.");
                s = s.Replace("What is it?", "Qu'y a-t-il ?");
                s = s.Replace("It's clear that the team purchases various equipment and\r\nsupplies on a monthly basis, but...",
                              "Le service achète régulièrement du matériel et des fournitures\r\nchaque mois, mais...");
                s = s.Replace("Well,<E003 8> one entry seems rather strange.",
                              "Eh bien,<E003 8> une ligne semble particulièrement étrange.");
                s = s.Replace("Really?<E003 8> In what way?", "Vraiment ?<E003 8> En quoi ?");
                s = s.Replace("They're buying five hundred scalpels every month!",
                              "Ils achètent cinq cents scalpels chaque mois !");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Five,<E003 8> <E025 2>five hundred?!", "Cinq...<E003 8> <E025 2>cinq cents ?!");
                s = s.Replace("They must be<E003 8> <E145 3 67><E333>working really hard on dissecting corpses.",
                              "Ils doivent<E003 8> <E145 3 67><E333>travailler d'arrache-pied sur les autopsies.");
                s = s.Replace("I don't know...<E049><E003 8> Judicial autopsies are only carried out in\r\ncertain special circumstances.",
                              "Je ne sais pas...<E049><E003 8> Les autopsies judiciaires ne sont pratiquées\r\nque dans des cas bien précis.");
                s = s.Replace("And scalpel blades can be sharpened, too.",
                              "Et les lames de scalpel s'affûtent, également.");
                s = s.Replace("It,<E003 8> it does seem a bit strange, <E145 3 92><E003 10>you're right...",
                              "C'est...<E003 8> c'est vrai que c'est bizarre, <E145 3 92><E003 10>vous avez raison...");
                s = s.Replace("(Five hundred scalpels a month...<E003 12>\r\nWhat could they possibly be using all them for?)",
                              "(Cinq cents scalpels par mois...<E003 12>\r\nÀ quoi peuvent-ils bien employer tout cet attirail ?)");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Those large jars<E003 8> <E330>seem to have pale things floating around\r\ninside them.",
                              "Ces grands bocaux...<E003 8> <E330>on dirait que des formes blanchâtres flottent\r\nà l'intérieur.");
                s = s.Replace("I suppose they're fruit liquors or something.<E003 8>\r\n<E025 2>Or like the pickled umeboshi plums we make back home.",
                              "J'imagine que ce sont des liqueurs de fruits.<E003 8>\r\n<E025 2>Ou des prunes umeboshi marinées comme chez nous.");
                s = s.Replace("Ah, <E003 5>Father had jars like that in his laboratory as well.",
                              "Ah, <E003 5>mon père avait aussi des bocaux similaires dans son laboratoire.");
                s = s.Replace("I expect they're human organs in a preserving solution.<E003 8>\r\nProbably as examples of some rare medical condition.",
                              "J'imagine qu'il s'agit d'organes humains dans du formol.<E003 8>\r\nSans doute des spécimens illustrant de rares pathologies.");
                s = s.Replace("...Miss Susato.<E003 13> <E025 2>There are some things in the world<E003 8> <E025 3><E239>that it's\r\nperfectly fine never to know about.<E003 12> Ever.",
                              "... Mlle Susato.<E003 13> <E025 2>Il y a certaines choses en ce monde<E003 8> <E025 3><E239>qu'il vaut\r\nmieux ne jamais, jamais savoir.<E003 12> Jamais.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("So as I said,<E003 8> I'm sure they're fruit liquors or umeboshi.<E003 18>\r\n<E025 2><E346><E342>Aren't they?",
                              "Comme je le disais,<E003 8> je suis certain que ce sont des fruits au sirop.<E003 18>\r\n<E025 2><E346><E342>N'est-ce pas ?");
                s = s.Replace("Of,<E003 10> <E341>of course.", "Bien...<E003 10> <E341>bien entendu.");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("A table and a set of sharp tools...<E003 10> When you consider each\r\nin isolation,<E003 4> it all looks quite innocent.",
                              "Une table et un assortiment d'instruments tranchants...<E003 10> Pris\r\nséparément,<E003 4> cela semble tout à fait anodin.");
                s = s.Replace("So why is it that when you put them side by side,<E003 8> <E025 3><E330><E341>they\r\nseem so horribly disturbing?",
                              "Alors pourquoi réunis au même endroit,<E003 8> <E025 3><E330><E341>ont-ils un air si\r\nterriblement angoissant ?");
                s = s.Replace("...It might be best not to ponder it too deeply.",
                              "... Il vaudrait mieux ne pas trop y songer.");
                s = s.Replace("Seeing the large tome that's open on the desk does make\r\nme wonder, though:",
                              "En voyant ce grand volume ouvert sur le bureau, je me demande tout de même :");
                s = s.Replace("How can anybody concentrate on bookwork<E003 6> with this\r\nacrid odour of chemicals in the air?",
                              "Comment peut-on se concentrer sur des lectures<E003 6> avec cette âcre\r\nodeur de produits chimiques dans la pièce ?");
                s = s.Replace("You'd either have to have a cast-iron constitution...",
                              "Il faut avoir les nerfs d'acier...");
                s = s.Replace("...or a really terrible sense of smell.",
                              "... ou un odorat complètement détruit.");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Look at all the bottles on the shelves in these cabinets!<E003 12>\r\nWhat an assortment of chemicals!",
                              "Regardez tous ces flacons alignés dans ces armoires !<E003 12>\r\nQuel incroyable assortiment de produits chimiques !");
                s = s.Replace("These ones here are labelled ‘Highly Toxic’.",
                              "Ceux-ci portent l'étiquette « Hautement Toxique ».");
                s = s.Replace("Ugh,<E003 8> <E025 2>that's worrying.<E003 8> Because there are also things that\r\nlook like salt and pepper shakers in there.",
                              "Ouh là,<E003 8> <E025 2>c'est inquiétant.<E003 8> Car il y a aussi ce qui ressemble à une\r\nsalière et une poivrière juste à côté.");
                s = s.Replace("Oh yes!<E003 10> <E333>And they actually say ‘salt’ and ‘pepper’ on them!",
                              "Oh oui !<E003 10> <E333>Et il y a bien écrit « sel » et « poivre » dessus !");
                s = s.Replace("The doctor probably spends a lot of time in this room, I\r\nsuppose.<E003 8> Perhaps she has meals here sometimes.",
                              "Le médecin passe probablement le plus clair de son temps ici.<E003 8>\r\nPeut-être y prend-elle ses repas parfois.");
                s = s.Replace("Life goes on...<E003 8>even when you're surrounded by death...",
                              "La vie continue...<E003 8> même entouré par la mort...");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I suppose this is Dr Sithe's desk.",
                              "J'imagine que c'est le bureau de la Dre Pétrie.");
                s = s.Replace("Ugh.<E003 10> <E025 2>I would NOT like to work in a place like this.",
                              "Brrr.<E003 10> <E025 2>Je ne VOUDRAIS PAS travailler dans un endroit pareil.");
                s = s.Replace("It's very tidy though,<E003 4> isn't it, Mr Naruhodo?<E049><E003 10>\r\nImagine how efficiently she must work.",
                              "C'est pourtant très ordonné,<E003 4> n'est-ce pas, Mr Naruhodo ?<E049><E003 10>\r\nImaginez son efficacité au travail.");
                s = s.Replace("The lighting is poor,<E003 4> which is bad for the eyes.<E003 8>\r\n<E043>And the chemical smell<E003 4> can't be good for you.",
                              "L'éclairage est médiocre,<E003 4> ce qui abîme les yeux.<E003 8>\r\n<E043>Et l'odeur chimique<E003 4> ne doit rien avoir de sain.");
                s = s.Replace("Not to mention the skeleton watching over you as you\r\nwork.<E003 10> <E335>Which is definitely bad for the nerves.",
                              "Sans parler du squelette qui vous observe pendant que vous\r\ntravaillez.<E003 10> <E335>Ce qui est désastreux pour les nerfs.");
                s = s.Replace("Well, yes...<E003 6>those are valid concerns, I suppose.",
                              "C'est vrai...<E003 6> ce sont des réserves légitimes, je l'accorde.");
                s = s.Replace("I can just about cope with a one-eyed daruma doll\r\nwatching over me,<E003 10> <E341>but that's all!",
                              "Je peux tolérer une poupée daruma borgne qui me regarde,<E003 10>\r\n<E341>mais c'est ma limite absolue !");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("That looks like an owl and a crow up there.",
                              "On dirait une chouette et un corbeau là-haut.");
                s = s.Replace("I know.<E003 8> And they haven't even twitched since we came\r\nin here...",
                              "Je sais.<E003 8> Et ils n'ont pas bronché d'un pouce depuis notre arrivée...");
                s = s.Replace("Well no, <E003 8><E025 2>they wouldn't have.<E049><E003 12>\r\n<E333>They're taxidermy mounts, Mr Naruhodo.",
                              "Eh bien non, <E003 8><E025 2>évidemment.<E049><E003 12>\r\n<E333>Ce sont des animaux naturalisés, Mr Naruhodo.");
                s = s.Replace("Ugh...<E003 10><E025 2>I was afraid you were going to say that.<E145 3 64>",
                              "Ouf...<E003 10><E025 2> je craignais que vous ne disiez ça.<E145 3 64>");
                s = s.Replace("I've been trying very hard to tell myself they're just\r\nsleeping with their eyes open.",
                              "J'essayais désespérément de me convaincre qu'ils dormaient les yeux ouverts.");
                s = s.Replace("Yes,<E003 8> <E025 2>I think perhaps you were wise to put something like\r\nyour daruma doll on display in the office instead...",
                              "Oui,<E003 8> <E025 2>je crois que vous avez été bien inspiré d'exposer plutôt\r\nvotre daruma dans le cabinet...");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("Well, look at this!<E003 12> <E025 2><E333>What a magnificent display case!",
                              "Regardez-moi ça !<E003 12> <E025 2><E333>Quelle vitrine remarquable !");
                s = s.Replace("The cherry wood has been polished to a high sheen,<E003 4> and\r\nthe intricate carving is a joy to behold.",
                              "Le bois de merisier a été poli à la perfection,<E003 4> et les fines\r\nsculptures sont un ravissement.");
                s = s.Replace("Western cabinet makers really are very skilled,<E003 6> aren't\r\nthey?",
                              "Les ébénistes occidentaux sont très talentueux,<E003 6> n'est-ce pas ?");
                s = s.Replace("...Do you have nothing to say about the skeleton inside,\r\nMr Naruhodo?",
                              "... N'avez-vous rien à dire sur le squelette à l'intérieur,\r\nMr Naruhodo ?");
                s = s.Replace("Miss Susato...", "Mlle Susato...");
                s = s.Replace("...can't you tell that I'm trying very hard to avoid talking\r\nabout the terrifying contents of the case?",
                              "... ne voyez-vous pas que je m'efforce d'ignorer le contenu terrifiant\r\nde cette vitrine ?");
                s = s.Replace("It's how I cope!", "C'est ma façon de faire face !");
                s = s.Replace("I'll...<E003 10><E025 2><E341>be sure to remember that from now on.",
                              "Je tâcherai...<E003 10><E025 2><E341> de m'en souvenir dorénavant.");
                return s;
            };

            // BB\script\output\_sce02_bg0307_1_check_eng#12
            entryTranslators["BB\\script\\output\\_sce02_bg0307_1_check_eng#12"] = en => {
                string s = en;
                s = s.Replace("So...<E003 10><E025 2>what are you doing at the moment,<E003 8> Doctor?",
                              "Alors...<E003 10><E025 2> que faites-vous en ce moment,<E003 8> Docteur ?");
                s = s.Replace("Keeping a close eye on things<E003 6> <E025 2><E330>so no impertinent\r\nEasterners think they can look around my office.",
                              "Je surveille mes affaires<E003 6> <E025 2><E330>pour éviter que des Orientaux\r\nimpertinents ne fassent les curieux dans mon laboratoire.");
                s = s.Replace("...Are there such impertinent Easterners around?<E003 12>\r\n<E025 3>How terrible.",
                              "... Y a-t-il donc des Orientaux si insolents par ici ?<E003 12>\r\n<E025 3>Quel scandale.");
                s = s.Replace("Yes.<E003 14> <E333>You.", "Oui.<E003 14> <E333>Vous.");
                s = s.Replace("She doesn't mince her words, Miss Susato.",
                              "Elle ne mâche pas ses mots, Mlle Susato.");
                s = s.Replace("I think perhaps it's time we left...",
                              "Je crois qu'il est grand temps de partir...");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("It ripped itself apart magnificently, <E003 6>didn't it?",
                              "Elle s'est disloquée de façon spectaculaire, <E003 6>non ?");
                s = s.Replace("Magnificently...<E003 8><E025 2><E136 110 71 6><E117 110 18><E149 110 9 0><E003 7><E149 110 0 0><E139 110><E333>and mercilessly.",
                              "Spectaculaire...<E003 8><E025 2><E136 110 71 6><E117 110 18><E149 110 9 0><E003 7><E149 110 0 0><E139 110><E333> et impitoyable.");
                s = s.Replace("So someone stands in the middle of the machine to be<E145 110 64>\r\ndisassembled and then ‘beamed’ through the air...",
                              "Donc quelqu'un se tient au milieu pour être dématérialisé<E145 110 64>\r\net « téléporté » dans les airs...");
                s = s.Replace("Yes,<E049><E003 8> ‘beamed’ <E049><E003 2><E164 110 66 1 2 6 0 0 1><E139 110>not ‘<E006>blasted<E005>’.<E049><E003 12><E025 2> That's the point.",
                              "Oui,<E049><E003 8> « téléporté », <E049><E003 2><E164 110 66 1 2 6 0 0 1><E139 110>pas « <E006>pulvérisé<E005> ».<E049><E003 12><E025 2> C'est toute la nuance.");
                s = s.Replace("(Yes, <E003 8><E025 2>that part's crucial, <E003 6>really.)",
                              "(Oui, <E003 8><E025 2>ce détail a son importance, <E003 6>en effet.)");
                s = s.Replace("Is something like that even possible, though, <E003 4>Iris?",
                              "Mais une telle prouesse est-elle seulement possible, <E003 4>Iris ?");
                s = s.Replace("Oh, Runo.<E003 10> <E025 2>I'm just a child.<E049><E003 8> How should I know?",
                              "Oh, Nicky.<E003 10> <E025 2>Je ne suis qu'une enfant.<E049><E003 8> Comment le saurais-je ?");
                s = s.Replace("(A child when it suits you, <E003 8>you mean...)",
                              "(Une enfant quand ça t'arrange, <E003 8>tu veux dire...)");
                s = s.Replace("From what I can tell, <E049><E003 8>I think if you were to pull this\r\nlever here–",
                              "D'après ce que je vois, <E049><E003 8>si l'on tirait sur cette manette ici...");
                s = s.Replace("STOOOOOOOOOOOOP!<E049><E003 25>\r\n<E332>Don't touch that!",
                              "STOOOOOOOOOOP !<E049><E003 25>\r\n<E332>Touche pas à ça !");
                s = s.Replace("Ah ha ha!<E003 8> That was practically instantaneous kinesis the\r\nway you flew over just now, Gregsy!",
                              "Ah ah ah !<E003 8> On aurait dit une téléportation instantanée la façon\r\ndont tu as bondi ici, mon p'tit Gregson !");
                s = s.Replace("Please, <E003 10><E342>Your Ladyship...<E049><E003 6> <E025 2>I didn't mean to startle you,<E049><E003 8> but I\r\ncan't let you touch anything up here.",
                              "De grâce, <E003 10><E342>Votre Grâce...<E049><E003 6> <E025 2>J'voulais pas vous effrayer,<E049><E003 8> mais j'peux\r\npas vous laisser toucher à quoi qu'ce soit ici !");
                s = s.Replace("So sorry.<E003 10> <E025 2>You can have some of my latest special blend\r\nto make up for it.",
                              "Toutes mes excuses.<E003 10> <E025 2>Tu auras droit à un peu de mon dernier thé\r\npour me faire pardonner.");
                s = s.Replace("Aaah!<E003 10> <E043>Wonderful!<E049><E003 18> \r\n<E044><E025 2><E342>This stuff really is wonderful!",
                              "Aaaah !<E003 10> <E043>Merveilleux !<E049><E003 18> \r\n<E044><E025 2><E342>Ce breuvage est une pure merveille !");
                s = s.Replace("(It's just like old times, <E003 6>this is...)",
                              "(C'est comme au bon vieux temps...)");
                s = s.Replace("We're representing Professor Harebrayne in court\r\ntomorrow, <E003 6>Inspector.",
                              "Nous défendons le Dr Samba Lonron au tribunal demain,\r\n<E003 6>inspecteur.");
                s = s.Replace("So we should be allowed to examine the scene!",
                              "Nous devrions donc pouvoir examiner la scène !");
                s = s.Replace("Hah!<E049><E003 12> Listen, sunshine, <E049><E003 12>even I'm not allowed to touch\r\nanythin' up here!",
                              "Ha !<E049><E003 12> Écoute un peu, mon gars :<E049><E003 12> même moi j'ai pas le droit de\r\ntoucher au moindre boulon ici !");
                s = s.Replace("It's that blasted Special Dispensation for Scientific\r\nEquipment Act to blame.<E049><E003 10> It's drivin' me potty!",
                              "La faute à cette fichue loi sur la dispense spéciale pour\r\néquipements scientifiques.<E049><E003 10> Ça m'rend chèvre !");
                s = s.Replace("Oh yes, <E003 6>that special dispensation...<E003 10>\r\n<E025 3><E007>(The professor mentioned that, too.)",
                              "Ah oui, <E003 6>cette dispense spéciale...<E003 10>\r\n<E025 3><E007>(Le docteur en a parlé lui aussi.)");
                s = s.Replace("More red tape's all we need.<E049><E003 8> I dunno what the\r\ngovernment thinks it's playin' at sometimes.",
                              "Encore d'la paperasse inutile.<E049><E003 8> J'sais pas à quoi rime la politique\r\ndu gouvernement par moments.");
                s = s.Replace("But...<E049><E003 4><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>we're allowed to just look, <E003 4>aren't we?",
                              "Mais...<E049><E003 4><E164 110 68 1 2 7 0 0 1><E139 110><E025 2> on a le droit de regarder avec les yeux, <E003 4>non ?");
                s = s.Replace("Eh?", "Hein ?");
                s = s.Replace("Surely that's alright...<E049><E003 8>isn't it, <E003 4>Gregsy?",
                              "C'est permis, n'est-ce pas...<E049><E003 8> mon cher <E003 4>Gregson ?");
                s = s.Replace("'Course, Your Ladyship!<E049><E003 12> Anythin' you say, Your Ladyship!<E049><E003 12>\r\n<E025 2><E341>But please don't get your dainty hands dirty, <E049><E003 6>will you?",
                              "Bien sûr, Votre Grâce !<E049><E003 12> Tout c'que vous voulez, Votre Grâce !<E049><E003 12>\r\n<E025 2><E341>Mais n'allez pas salir vos jolies mimines, <E049><E003 6>entendu ?");
                s = s.Replace("Don't worry.<E049><E003 4> <E164 110 66 1 2 6 0 0 1><E118 110 1.1><E139 110>We wouldn't dream of touching anything,\r\n<E003 6>would we, Runo?",
                              "Ne t'en fais pas.<E049><E003 4> <E164 110 66 1 2 6 0 0 1><E118 110 1.1><E139 110>On n'oserait jamais toucher à quoi que ce soit,\r\n<E003 6>pas vrai, Nicky ?");
                s = s.Replace("(She really knows how to get what she wants...)",
                              "(Elle sait drôlement bien obtenir ce qu'elle veut...)");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Considering how badly damaged everything is, <E003 8>Professor\r\nHarebrayne was lucky to escape unscathed, I'd say.",
                              "Vu l'état de dévastation, <E003 8>on peut dire que le Dr Samba Lonron\r\na eu une chance inouïe de s'en tirer indemne.");
                s = s.Replace("(We should have a good look around the machine while\r\nwe can, <E003 6>I think...)",
                              "(Profitons-en pour examiner la machine de fond en comble\r\ntant que nous le pouvons...)");
                s = s.Replace("Touch anythin' and I'll make sure I kill you before I get\r\nstrung up myself, <E003 10>you hear?",
                              "Touche à un seul truc et j't'étripe avant d'finir pendu moi-même,\r\n<E003 10>tu m'entends ?!");
                s = s.Replace("I, <E003 10><E025 2>I won't touch a thing, <E003 8><E025 1>I promise.<E003 12>\r\n<E342><E025 2>So please...<E003 8><E025 1>spare a thought for your digestion!",
                              "Je... <E003 10><E025 2>je ne toucherai à rien, <E003 8><E025 1>promis !<E003 12>\r\n<E342><E025 2>Alors pitié... <E003 8><E025 1>ménagez votre estomac !");
                s = s.Replace("Anyway...<E003 10><E043><E145 7 65><E025 2>do you really think this machine could actually\r\ndisassemble people like the professor claims?",
                              "Bref...<E003 10><E043><E145 7 65><E025 2> croyez-vous vraiment que cet engin puisse\r\ndématérialiser des êtres humains comme le prétend le docteur ?");
                s = s.Replace("He asks, <E003 6>lookin' totally incredulous.<E049><E003 12>\r\n<E025 2>Give it a rest, sunshine.",
                              "Qu'il m'demande avec sa tête d'ahuri.<E049><E003 12>\r\n<E025 2>Lâche-moi la grappe, l'ami.");
                s = s.Replace("If we were allowed to examine all this bleedin' scrap\r\nmetal, <E003 8>maybe we could answer that question.",
                              "Si on avait le droit d'fouiller c'tas de ferraille,<E003 8> on aurait peut-être\r\nla réponse à ta question.");
                s = s.Replace("But we can't, <E049><E003 12>can we?!", "Mais on peut pas, <E049><E003 12>pas vrai ?!");
                s = s.Replace("Because of the annoying rules, <E003 4>you mean?",
                              "À cause des règles rébarbatives, <E003 4>c'est ça ?");
                s = s.Replace("Exactly!<E049><E003 10> <E145 7 81><E117 7 5><E045>The annoyin', <E003 10><E025 1><E346>obstructive flamin' rules!",
                              "Pile poil !<E049><E003 10> <E145 7 81><E117 7 5><E045>Ces satanées, <E003 10><E025 1><E346>ces fichues règles de malheur !");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("...Oh.<E003 10> <E025 3>Look at the base of the machine there...",
                              "... Tiens.<E003 10> <E025 3>Regarde à la base de la machine...");
                s = s.Replace("Oh yes!<E003 10> <E025 2><E341>There's <E006>a tool<E005> of some kind poking through the\r\nwire mesh.",
                              "Oh oui !<E003 10> <E025 2><E341>Il y a <E006>un outil<E005> qui dépasse à travers le\r\ngrillage.");
                s = s.Replace("It's<E025 7>...<E003 12><E025 3><E330>a screwdriver, <E003 8>I think.",
                              "C'est<E025 7>...<E003 12><E025 3><E330> un tournevis, <E003 8>on dirait.");
                s = s.Replace("Oh, <E049><E003 8><E025 2>isn't it a lovely one!<E049><E003 8> The handle is in the shape of a\r\ncapital letter ‘A’!",
                              "Oh, <E049><E003 8><E025 2>comme il est mignon !<E049><E003 8> Le manche a la forme d'un « A »\r\nmajuscule !");
                s = s.Replace("It is?<E003 12>\r\n<E025 2>...Oh yes, <E003 8>you're right.",
                              "Ah bon ?<E003 12>\r\n<E025 2>... Ah oui, <E003 8>tu as raison.");
                s = s.Replace("WHAT'S THE MATTER WITH YOU?!<E049><E003 25>\r\n<E332>Don't touch anythin', I said!",
                              "MAIS QU'EST-CE QUI TOURNE PAS ROND CHEZ VOUS ?!<E049><E003 25>\r\n<E332>J'ai dit pas touche, bon sang !");
                s = s.Replace("Touch anythin' and I'll make sure I kill you before I get\r\nstrung up myself, <E003 10>I said!",
                              "Touche à un truc et j'te découpe en morceaux avant qu'on m'pende,\r\n<E003 10>j'avais prévenu !");
                s = s.Replace("Yes yes!<E003 5> <E025 2>I understand!<E003 8> Sorry!<E003 12>\r\n<E025 3><E007>(I only touched it a teeny weeny bit...)",
                              "Oui oui !<E003 5> <E025 2>J'ai compris !<E003 8> Pardon !<E003 12>\r\n<E025 3><E007>(J'ai à peine effleuré le manche...)");
                s = s.Replace("But Gregsy!<E003 12> <E025 2>I'm very curious about this screwdriver.<E049><E003 12>\r\n<E025 2><E341>Really very, <E049><E003 8>very <E049><E003 8>curious.",
                              "Mais mon p'tit Gregson !<E003 12> <E025 2>Ce tournevis m'intrigue beaucoup.<E049><E003 12>\r\n<E025 2><E341>Vraiment très, <E049><E003 8>très <E049><E003 8>curieuse !");
                s = s.Replace("'Course, Your Ladyship!<E003 8> <E025 1>You're so clever, Your Ladyship!<E049><E003 12>\r\n<E025 1><E345>Fancy spottin' somethin' like this!",
                              "Bien sûr, Votre Grâce !<E003 8> <E025 1>Vous êtes si perspicace, Votre Grâce !<E049><E003 12>\r\n<E025 1><E345>Avoir l'œil pour repérer un machin pareil !");
                s = s.Replace("But I'm afraid, <E049><E003 10><E145 7 66><E003 6>I can't let you have it.",
                              "Mais j'ai bien peur <E049><E003 10><E145 7 66><E003 6>d'pas pouvoir vous l'donner.");
                s = s.Replace("But Runo found it first!", "Mais c'est Nicky qui l'a vu le premier !");
                s = s.Replace("I assure you, <E049><E003 14>I'll investigate it thoroughly!",
                              "J'vous assure <E049><E003 14>qu'j'vais l'examiner sous toutes ses coutures !");
                s = s.Replace("(He's gone off with it...)", "(Il est parti avec...)");
                s = s.Replace("Hmph!<E049><E003 12> That was very mean!<E003 12>\r\n<E025 2>I'm afraid...",
                              "Pff !<E049><E003 12> Ce n'est pas très gentil !<E003 12>\r\n<E025 2>J'ai bien peur...");
                s = s.Replace("‘Inspector Gregson’ <E003 6><E356><E025 1>is going to make a very clumsy and\r\nembarrassing mistake in next month's instalment now!",
                              "que « l'inspecteur Gregson » <E003 6><E356><E025 1>ne commette une bourde monumentale\r\ndans le prochain numéro de mon histoire !");
                s = s.Replace("(Poor ‘Gregsy’...)", "(Pauvre Gregson...)");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("That amazing horn-shaped device is pointing towards the\r\nCrystal Tower.",
                              "Ce curieux dispositif en forme de pavillon est braqué vers la\r\nTour de Cristal.");
                s = s.Replace("I suppose once people are disassembled by the machine,<E003 10>\r\n<E330>they're shot out of that thing to wherever they're going.",
                              "J'imagine qu'une fois dématérialisées par la machine,<E003 10>\r\n<E330>les personnes sont propulsées par cet engin vers leur destination.");
                s = s.Replace("I don't think it was supposed to shoot anything, Runo.",
                              "Je ne crois pas qu'il propulse quoi que ce soit, Nicky.");
                s = s.Replace("It was set up to ‘beam’ people to the Crystal Tower<E003 10> <E333>where\r\nthey'd be reconstructed in their original form.",
                              "Il a été conçu pour projeter l'énergie vers la tour<E003 10> <E333>où\r\nle corps se recompose sous sa forme originelle.");
                s = s.Replace("Well...<E003 10><E025 2>I don't like the look of it.",
                              "Eh bien...<E003 10><E025 2> ça ne m'inspire rien qui vaille.");
                s = s.Replace("If it was as amazing as it looks, <E003 6>the accident wouldn't have\r\nhappened in the first place, <E003 6>of course.",
                              "Si c'était si extraordinaire, <E003 6>l'accident n'aurait pas eu lieu\r\nen premier lieu, <E003 6>évidemment.");
                s = s.Replace("I suppose that's true, <E003 6><E025 3>yes...",
                              "J'imagine que c'est vrai, <E003 6><E025 3>oui...");
                s = s.Replace("But nothing ever goes according to plan, <E003 8>does it?",
                              "Mais rien ne se passe jamais comme prévu, <E003 8>n'est-ce pas ?");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("There are all sorts of strange buildings here in the Great\r\nExhibition grounds, <E003 6>aren't there?",
                              "Il y a toutes sortes de pavillons insolites dans l'enceinte de\r\nl'exposition, <E003 6>n'est-ce pas ?");
                s = s.Replace("I<E025 7>...<E003 8><E025 3>seem to remember something similar being exhibited\r\nin Japan one time...",
                              "J'ai<E025 7>...<E003 8><E025 3> l'impression de me rappeler quelque chose de similaire\r\nexposé au Japon...");
                s = s.Replace("Oh!<E003 12> <E025 2>In your country, Runo?<E049><E003 10>\r\nI do wish I could go and see it!",
                              "Oh !<E003 12> <E025 2>Dans ton pays, Nicky ?<E049><E003 10>\r\nJ'aimerais tellement pouvoir visiter ça !");
                s = s.Replace("I'd present a particularly steely samurai with a present of\r\none of Hurley's stories I'd written especially...",
                              "J'offrirais à un fier samouraï un exemplaire d'une aventure\r\nde Sherlockinou écrite tout spécialement...");
                s = s.Replace("...and see if I couldn't get Hurley into a jam against some\r\nbartitsu-master ninjas!",
                              "... et je verrais bien si Sherlockinou parvient à se dépêtrer\r\nface à des ninjas experts en baritsu !");
                s = s.Replace("Erm<E025 7>...<E003 10><E025 3><E330>you might not find as many of those sorts of people\r\naround as you think.",
                              "Euh<E025 7>...<E003 10><E025 3><E330> je ne suis pas certain qu'on croise autant de gens\r\nde ce genre que tu l'imagines.");
                s = s.Replace("Oh...<E003 10> Well that's dull...", "Oh...<E003 10> Quelle déception...");
                s = s.Replace("Ooh!<E003 12> <E025 2><E333>But I do know a prosecutor with a chonmage topknot\r\nI could introduce you to!",
                              "Oh !<E003 12> <E025 2><E333>Mais je connais un procureur avec un chignon chonmage\r\nque je pourrais te présenter !");
                s = s.Replace("A chonmage!<E003 12> Really?!<E049><E003 12> <E341>Do you think I could have my\r\npicture taken with him?<E003 10> Do you?",
                              "Un chonmage !<E003 12> Vraiment ?!<E049><E003 12> <E341>Tu crois que je pourrais poser\r\nen photo avec lui ? Tu crois ?");
                s = s.Replace("(...Assuming he's recovered from the <E003 6><E330>‘trim’ <E003 6>Kazuma gave\r\nhim a year ago, <E003 8>yes.)",
                              "(... En supposant qu'il se soit remis du <E003 6><E330>« rafraîchissement »<E003 6>\r\nque Kazuma lui a infligé il y a un an, <E003 8>oui.)");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("So those are people-carrying balloons, <E003 6><E025 3>dangling silently in\r\nthe skies over London...",
                              "Ce sont donc des ballons transportant des passagers,<E003 6><E025 3> suspendus\r\ndans le ciel de Londres...");
                s = s.Replace("I always thought the day would come when humans\r\nwould discover how to fly.",
                              "J'ai toujours pensé que le jour viendrait où l'homme saurait voler.");
                s = s.Replace("But I never imagined it would involve them being\r\nsuspended from colourful, <E003 8>floating <E003 6>temari handballs<E025 7>...",
                              "Mais je n'avais jamais imaginé que cela consisterait à flotter\r\nsous des <E003 6>balles temari<E025 7>... <E003 8>multicolores...");
                s = s.Replace("I'm sure it must feel amazing, <E003 6>being up there among the\r\nclouds!<E049><E003 4> <E025 1><E164 110 68 1 2 8 0 1 1><E139 110>Let's take a ride together, Runo!<E003 8> Please!",
                              "La sensation doit être grisante, <E003 6>là-haut au milieu des\r\nnuages !<E049><E003 4> <E025 1><E164 110 68 1 2 8 0 1 1><E139 110>Faisons un tour ensemble, Nicky !<E003 8> S'il te plaît !");
                s = s.Replace("If I'm being perfectly honest, <E003 6>I would like to try it.",
                              "Pour être tout à fait honnête, <E003 6>j'aimerais bien essayer.");
                s = s.Replace("But without a cast-iron guarantee that the thing won't\r\nplummet to the ground...<E003 12><E025 3>I'm too scared.",
                              "Mais sans une garantie absolue que l'engin ne s'écrasera pas au\r\nsol...<E003 12><E025 3> j'ai trop peur.");
                s = s.Replace("Oh well, <E003 10>in that case, <E003 8>I should tell you what Hurley said.",
                              "Oh, <E003 10>dans ce cas, <E003 8>je devrais te répéter ce qu'a dit Sherlockinou.");
                s = s.Replace("‘It's physically impossible for a flying balloon to plummet\r\nto the ground...<E003 8><E025 3>as long as it doesn't explode.’",
                              "« Il est physiquement impossible pour un ballon de s'écraser au\r\nsol...<E003 8><E025 3> tant qu'il n'explose pas. »");
                s = s.Replace("Yes<E025 7>...<E003 8><E025 3>call me crazy, <E003 6><E025 2><E341>but I think that exploding part might\r\nplay on my mind a little...",
                              "Oui<E025 7>...<E003 8><E025 3> traite-moi de trouillard, <E003 6><E025 2><E341>mais c'est justement ce détail\r\nd'explosion qui me taraude l'esprit...");
                return s;
            };

            // BB\script\output\_sce02_bg0308_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0308_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Wh-<E003 10><E025 2><E341>What is that gigantic thing over there?<E003 12>\r\n<E025 2>It looks like an enormous waterwheel...",
                              "Qu... <E003 10><E025 2><E341>Qu'est-ce que c'est que ce truc titanesque là-bas ?<E003 12>\r\n<E025 2>On dirait une gigantesque roue à aubes...");
                s = s.Replace("Oh, <E049><E003 12><E338><E341>that's a Ferris wheel.<E049><E003 10> There'll be people riding inside\r\nthose little cabins you can see.",
                              "Oh, <E049><E003 12><E338><E341>c'est une grande roue.<E049><E003 10> Des passagers montent à bord\r\nde ces petites cabines suspendues.");
                s = s.Replace("Why?", "Pourquoi ?");
                s = s.Replace("Well...<E003 6><E025 2><E164 110 66 1 2 6 0 0 1><E139 110>they rotate nice and slowly, <E003 6>so it's a wonderful way\r\nto see the surrounding scenery.",
                              "Eh bien...<E003 6><E025 2><E164 110 66 1 2 6 0 0 1><E139 110> elles tournent très lentement, <E003 6>c'est une façon\r\nmerveilleuse de contempler le panorama.");
                s = s.Replace("Wait...<E003 12>it's turning?<E003 14>\r\n<E145 110 64>But it looks completely still.",
                              "Attends...<E003 12> elle tourne ?<E003 14>\r\n<E145 110 64>Elle paraît complètement immobile.");
                s = s.Replace("Yes.<E049><E003 12> That's because it's turning so slowly.<E049><E003 10> One complete\r\nrevolution takes about half an hour.",
                              "Oui.<E049><E003 12> C'est parce qu'elle tourne très doucement.<E049><E003 10> Un tour\r\ncomplet prend environ une demi-heure.");
                s = s.Replace("If you were mad enough to go in one, <E003 6>it would be more\r\nfun to whizz around fast, <E003 8>don't you think?",
                              "Si l'on est assez fou pour monter là-dedans, <E003 6>ce serait bien plus drôle\r\nde tournoyer à toute vitesse, <E003 8>non ?");
                s = s.Replace("...I feel as though you might have just invented a new\r\nsort of ride there, <E003 4>Runo.",
                              "... J'ai l'impression que tu viens d'inventer une nouvelle attraction\r\nforaine là, <E003 4>Nicky.");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("What a terrible explosion it must have been...",
                              "Quelle effroyable déflagration ce dut être...");
                s = s.Replace("Even the steel girders have buckled and twisted in the\r\nblast.",
                              "Même les poutrelles d'acier ont plié sous le choc.");
                s = s.Replace("And what they call the ‘birdcage’<E003 4> was right in the middle\r\nof it all,<E003 6> just here.",
                              "Et ce qu'ils appellent la « cage d'oiseau »<E003 4> se trouvait au beau\r\nmilieu de tout ceci,<E003 6> juste là.");
                s = s.Replace("But look, Mr Naruhodo.<E003 10>\r\n<E025 3>That metal grille on the floor...",
                              "Mais regardez, Mr Naruhodo.<E003 10>\r\n<E025 3>Cette trappe métallique au sol...");
                s = s.Replace("...looks as though it's designed to open.",
                              "... semble faite pour s'ouvrir.");
                s = s.Replace("It does...<E003 8>doesn't it?", "En effet...<E003 8> n'est-ce pas ?");
                s = s.Replace("(If the floor had opened at the precise moment the\r\nexplosion occurred...)",
                              "(Si le plancher s'est ouvert à la seconde précise de\r\nl'explosion...)");
                s = s.Replace("(...the birdcage could have dropped through and\r\ndisappeared from sight.)",
                              "(... la cage a pu basculer en dessous et disparaître des regards.)");
                s = s.Replace("I don't think there's any doubt<E003 4> that this was a very\r\nelaborate hoax, is there?",
                              "Il ne fait aucun doute qu'il s'agissait d'une supercherie\r\nsoigneusement orchestrée, non ?");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Look at that horn-shaped transmitting device.<E003 10>\r\nIsn't it amazing?",
                              "Regardez ce pavillon émetteur.<E003 10>\r\nN'est-ce pas saisissant ?");
                s = s.Replace("That's<E003 8> <E025 2><E330>exactly what I thought when I first saw it.",
                              "C'est<E003 8> <E025 2><E330>exactement ce que je me suis dit en le découvrant.");
                s = s.Replace("It makes you think, doesn't it?", "Ça fait réfléchir, n'est-ce pas ?");
                s = s.Replace("If only it had just been a normal horn,<E003 6> none of this would\r\nhave happened.",
                              "Si seulement cela n'avait été qu'un simple cornet acoustique,<E003 6>\r\nrien de tout cela ne serait arrivé.");
                s = s.Replace("That's<E003 8> <E025 2><E043>almost exactly what I thought as well!",
                              "C'est<E003 8> <E025 2><E043>presque mot pour mot ce que j'ai pensé aussi !");
                s = s.Replace("I bet I can predict what you're going to say next in that\r\ncase.",
                              "Je parie que je peux deviner votre prochaine réplique.");
                s = s.Replace("You're about to say<E003 8> <E025 3><E333>‘nothing ever goes to plan’,<E003 12> <E025 1><E335>aren't you?",
                              "Vous allez dire<E003 8> <E025 3><E333>« rien ne se passe jamais comme prévu »,<E003 12> <E025 1><E335>pas vrai ?");
                s = s.Replace("Oh no.<E003 8> I would never say something like that.",
                              "Oh non.<E003 8> Je ne dirais jamais une chose pareille.");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("(Ugh...<E003 12> ‘Least Approachable Man in the World’ winner,<E003 6>\r\nten years in a row...)",
                              "(Argh...<E003 12> élu l'homme le moins aimable au monde,<E003 6>\r\ndix années consécutives...)");
                s = s.Replace("Be strong, Mr Naruhodo!<E049><E003 8>\r\n<E164 3 87 1 2 8 0 2 1><E149 3 4 4><E139 3>Your country and your assistant<E003 8> stand firm behind you!",
                              "Courage, Mr Naruhodo !<E049><E003 8>\r\n<E164 3 87 1 2 8 0 2 1><E149 3 4 4><E139 3>Votre patrie et votre assistante<E003 8> sont fidèlement à vos côtés !");
                s = s.Replace("Um...<E003 10>Lord van Zieks...", "Euh...<E003 10> Lord Van Peers...");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("Erm...<E003 8><E025 4>well...", "Euh...<E003 8><E025 4> eh bien...");
                s = s.Replace("Beautiful weather we're having,<E003 8> isn't it?",
                              "Il fait bien beau aujourd'hui,<E003 8> vous ne trouvez pas ?");
                s = s.Replace("I thought I was making it quite clear<E049><E003 8> that I didn't want to\r\nbe disturbed.",
                              "Je croyais avoir été clair<E049><E003 8> sur mon désir de ne pas être dérangé.");
                s = s.Replace("Apparently you Nipponese<E003 6> are unequipped to read the\r\nsigns.",
                              "Visiblement, vous autres Nippons<E003 6> êtes incapables de comprendre les signaux.");
                s = s.Replace("(Oh, I read them...)", "(Oh, j'ai très bien compris...)");
                s = s.Replace("So?<E049><E003 8> What are you doing here?",
                              "Alors ?<E049><E003 8> Que venez-vous faire ici ?");
                s = s.Replace("Entry to this area is prohibited.", "L'accès à ce périmètre est rigoureusement interdit.");
                s = s.Replace("Ah...<E003 8>well,<E003 6> <E025 2>the thing is...",
                              "Ah...<E003 8> eh bien,<E003 6> <E025 2>le fait est que...");
                s = s.Replace("Lord Chief Justice Stronghart granted us permission to\r\ninvestigate.",
                              "Le Premier ministre Lord Caine nous a accordé l'autorisation d'enquêter.");
                s = s.Replace("On the condition that we didn't disturb anything.",
                              "À la stricte condition de ne toucher à rien.");
                s = s.Replace("...And yet you've managed to disturb me.",
                              "... Et pourtant, vous avez réussi à me déranger, moi.");
                s = s.Replace("Never mind.<E049><E003 12>\r\nState your business, then.",
                              "Peu importe.<E049><E003 12>\r\nExposez votre requête.");
                s = s.Replace("(Come to think of it...)", "(En y repensant...)");
                s = s.Replace("(...there are quite a few things I'd like to ask Lord van\r\nZieks about.)",
                              "(... il y a pas mal de points que j'aimerais aborder avec Lord Van Peers.)");
                s = s.Replace("(Not least of which is <E006>that awful case<E007>,<E003 8> even though it's\r\nnothing to do with this.)",
                              "(À commencer par <E006>cette sinistre affaire<E007>,<E003 8> même si elle semble étrangère à tout ceci.)");
                s = s.Replace("Ask away, Mr Naruhodo!<E003 14>\r\nYou won't know unless you try!",
                              "Posez vos questions, Mr Naruhodo !<E003 14>\r\nQui ne tente rien n'a rien !");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("This...<E003 10><E025 2>wasn't here yesterday.",
                              "Ceci...<E003 10><E025 2> n'était pas là hier.");
                s = s.Replace("Really?<E049><E003 12>\r\n<E025 2>But if I'm not mistaken...",
                              "Vraiment ?<E049><E003 12>\r\n<E025 2>Mais si je ne m'abuse...");
                s = s.Replace("...it's the cage in which the victim was standing before he\r\nwas apparently ‘beamed’ through the air.",
                              "... c'est la cage dans laquelle se tenait la victime avant d'être\r\nprétendument « téléportée ».");
                s = s.Replace("That's right.<E003 8> The birdcage.<E003 12> According to what Professor\r\nHarebrayne said in court,<E003 4> it's made of wood.",
                              "Exactement.<E003 8> La cage d'oiseau.<E003 12> D'après le Dr Samba Lonron au\r\ntribunal,<E003 4> elle est faite de bois.");
                s = s.Replace("Or more precisely...<E003 10><E025 2>Japanese cypress,<E003 6> I think.",
                              "Plus précisément...<E003 10><E025 2> de cyprès japonais hinoki, je crois.");
                s = s.Replace("And despite having been in an explosion<E003 4> and then falling\r\nfrom a great height,<E049><E003 8> it's relatively unharmed.",
                              "Et malgré l'explosion<E003 4> et la chute vertigineuse qui a suivi,<E049><E003 8>\r\nelle est presque intacte.");
                s = s.Replace("What wonderfully durable construction,<E003 6> wouldn't you\r\nsay, Mr Naruhodo?",
                              "Quelle robustesse remarquable,<E003 6> vous ne trouvez pas,\r\nMr Naruhodo ?");
                s = s.Replace("I'd understood that the Forensic Investigation Team had\r\ntaken it away yesterday to examine it.",
                              "J'avais cru comprendre que la police scientifique l'avait emportée\r\nhier pour l'examiner.");
                s = s.Replace("I suppose they must have brought it back here when\r\nthey'd finished their work...",
                              "J'imagine qu'ils l'ont rapportée ici une fois leur travail achevé...");
                s = s.Replace("But sadly<E003 6> not with the body inside it.",
                              "Mais hélas<E003 6> sans le corps à l'intérieur.");
                s = s.Replace("...No,<E003 6> that's right.", "... Non,<E003 6> c'est exact.");
                s = s.Replace("(I know we were given strict instructions not to touch\r\nanything,<E003 8> <E025 3>but still...)",
                              "(Je sais qu'on nous a interdit de toucher à quoi que ce soit,<E003 8>\r\n<E025 3>mais tout de même...)");
                s = s.Replace("(...this is too important a piece of evidence to overlook.<E003 10>\r\nWe might need it for the trial!)",
                              "(... c'est une preuve trop cruciale pour passer à côté.<E003 10>\r\nElle sera indispensable pour le procès !)");
                s = s.Replace("The birdcage from the machine has been\r\nentered into the Court Record.",
                              "La cage d'oiseau a été ajoutée\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Oh,<E003 8> isn't it exhilarating?<E049><E003 12> <E332>All this different architecture<E003 8>\r\nfrom all corners of the world!",
                              "Oh,<E003 8> n'est-ce pas enivrant ?<E049><E003 12> <E332>Tous ces styles architecturaux<E003 8>\r\nvenus des quatre coins du globe !");
                s = s.Replace("It does make you feel a bit like an explorer, doesn't it?",
                              "On se sent un peu l'âme d'un explorateur, c'est vrai.");
                s = s.Replace("I know it's all subjective,<E003 6> but the<E145 3 64> onion-shaped roofs have\r\nrather caught my attention, personally.",
                              "Je sais que c'est subjectif,<E003 6> mais ces toits en forme d'oignon<E145 3 64>\r\nattirent particulièrement mon regard.");
                s = s.Replace("...It IS very subjective,<E003 8> isn't it?",
                              "... C'est EN EFFET très subjectif,<E003 8> n'est-ce pas ?");
                s = s.Replace("Japanese buildings,<E003 4> with their wood and paper\r\nconstruction,<E003 4> have excellent ventilation.",
                              "Les bâtisses japonaises,<E003 4> faites de bois et de papier,<E003 4> offrent une\r\nexcellente aération.");
                s = s.Replace("And I've realised that British buildings,<E003 4> being made from\r\nbrick and stone,<E003 4> are very strong and long-lasting.",
                              "Et j'ai remarqué que les immeubles britanniques,<E003 4> en pierre et brique,<E003 4>\r\nsont extrêmement solides et durables.");
                s = s.Replace("The more you know about how things are done in other\r\ncountries,<E003 4> the more you understand your own, I feel.",
                              "Mieux on connaît les méthodes des autres pays,<E003 4> mieux on apprécie\r\nles nôtres, j'ai l'impression.");
                s = s.Replace("Oh yes,<E049><E003 10> <E025 1><E341>I do agree with you there!",
                              "Oh oui,<E049><E003 10> <E025 1><E341>je vous rejoins tout à fait sur ce point !");
                s = s.Replace("But I can't help wondering what<E145 3 67> an onion does for the roof\r\nof a building...",
                              "Mais je me demande quel intérêt<E145 3 67> présente un oignon sur le toit\r\nd'un édifice...");
                s = s.Replace("I mean,<E003 8> <E025 2>I suppose it's playing on my mind because I don't\r\nlike the taste of onions.",
                              "Enfin,<E003 8> <E025 2>j'imagine que ça me préoccupe parce que je déteste le\r\ngoût des oignons.");
                s = s.Replace("...You really oughtn't let your taste in vegetables<E003 4> dictate\r\nyour taste in roofs, Mr Naruhodo.",
                              "... Vous ne devriez vraiment pas laisser vos goûts culinaires<E003 4> dicter\r\nvos goûts architecturaux, Mr Naruhodo.");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("However much I look at them,<E003 6> I just can't come to terms\r\nwith those temari handballs<E003 4> floating in the sky.",
                              "J'ai beau les regarder,<E003 6> je n'arrive pas à me faire à ces balles\r\ntemari<E003 4> en suspension dans le ciel.");
                s = s.Replace("You've been glaring at them constantly since we came up\r\nhere.",
                              "Vous les fixez d'un œil noir depuis que nous sommes montés.");
                s = s.Replace("Sorry.<E003 8> <E330>The feelings of wanting to ride in one<E003 6> <E043>and wanting\r\nnever to set foot in one<E003 4> are fighting it out inside me.",
                              "Pardon.<E003 8> <E330>L'envie d'y monter<E003 6> <E043>et la terreur absolue d'y poser le\r\npied<E003 4> se livrent un combat acharné en moi.");
                s = s.Replace("But if you don't look where you're walking,<E049><E003 8> <E341>you might fall\r\nfrom the stage.",
                              "Mais si vous ne regardez pas où vous marchez,<E049><E003 8> <E341>vous allez tomber de\r\nl'estrade !");
                s = s.Replace("I don't think I'd notice.<E003 12> <E335>That's how fiercely the battle\r\ninside me is raging.",
                              "Je ne m'en apercevrais même pas.<E003 12> <E335>Voilà à quel point la guerre\r\nintérieure fait rage.");
                s = s.Replace("...I think you should make peace with riding in one,\r\nMr Naruhodo.<E003 10> <E333>It really would be much safer that way.",
                              "... Je crois que vous devriez vous résigner à faire un tour dedans,\r\nMr Naruhodo.<E003 10> <E333>Ce serait nettement plus prudent.");
                return s;
            };

            // BB\script\output\_sce02_bg0308_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0308_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I hear that a ride on the Ferris wheel<E003 4> is a favourite\r\nromantic outing among young London couples.",
                              "J'ai entendu dire qu'un tour sur la grande roue<E003 4> est la sortie romantique\r\npréférée des jeunes couples londoniens.");
                s = s.Replace("I think the romance would be slightly spoilt by the abject\r\nterror, personally.<E003 10> But then<E003 6> I'm not a Londoner.",
                              "Je trouve que la terreur viscérale gâcherait un peu le romantisme,<E003 10>\r\npersonnellement.<E003 6> Mais je ne suis pas un Londonien.");
                s = s.Replace("...Are you<E003 6> a little scared of heights, Mr Naruhodo?",
                              "... Auriez-vous<E003 6> le vertige, Mr Naruhodo ?");
                s = s.Replace("It's<E003 6> not that I'm scared,<E003 8> <E025 1><E335>not at all!",
                              "Ce...<E003 6> ce n'est pas que j'ai peur,<E003 8> <E025 1><E335>pas du tout !");
                s = s.Replace("It's just that staying on the ground <E145 3 64>seems so much safer.",
                              "C'est juste que rester les deux pieds sur terre <E145 3 64>semble bien plus sûr.");
                s = s.Replace("Well,<E003 10> <E025 2><E333>perhaps I shall have to ask Iris and Mr Sholmes to\r\naccompany me on it, in that case.",
                              "Eh bien,<E003 10> <E025 2><E333>dans ce cas, je demanderai à Iris et à Mr Holmes\r\nde m'accompagner.");
                s = s.Replace("When you put it like that,<E003 6> part of me does want to give it\r\na try...<E145 3 64>",
                              "Présenté ainsi,<E003 6> une part de moi a bien envie de tenter le coup...<E145 3 64>");
                s = s.Replace("Oh dear...<E003 8> <E025 2>It is complicated for you,<E003 6> isn't it?",
                              "Mon Dieu...<E003 8> <E025 2>C'est bien compliqué dans votre tête,<E003 6> n'est-ce pas ?");
                return s;
            };
        }
    }
}
