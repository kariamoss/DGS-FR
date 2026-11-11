using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct2 {
    public partial class Program {
        public static void RegisterPart1() {
            // BB\script\output\_sce02_c100_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c100_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("23rd October, 8:52 a.m.", "23 octobre, 8h52");
                s = s.Replace("The Old Bailey, Defendants' Antechamber", "Old Bailey, Antichambre des accusés");
                s = s.Replace("I can't believe it's been six months since I was last\r\nallowed to work in court.",
                              "Je n'arrive pas à croire que six mois se sont écoulés depuis\r\nma dernière apparition au tribunal.");
                s = s.Replace("And now here I am, <E003 8>back at the Old Bailey...",
                              "Et me revoilà, <E003 8>de retour à Old Bailey...");
                s = s.Replace("Ah!<E049><E003 8>\r\n<E025 1>M-<E049><E003 10><E341>Mr Naruhodo!",
                              "Ah !<E049><E003 8>\r\n<E025 1>M-<E049><E003 10><E341>Mr Naruhodo !");
                s = s.Replace("Good morning, <E145 68 64><E003 8>Professor Harebrayne.",
                              "Bonjour, <E145 68 64><E003 8>Dr Samba Lonron.");
                s = s.Replace("I, <E049><E003 12>I don't understand!<E003 14>\r\n<E025 1>It doesn't make any sense!",
                              "J-Je <E049><E003 12>ne comprends pas !<E003 14>\r\n<E025 1>Ça n'a aucun sens !");
                s = s.Replace("The atmospheric pressure in here is off the charts!<E003 10>\r\n<E025 2>I've never felt anything like it!<E049><E003 10> <E025 1>It's, <E003 12><E332>it's crushing me!",
                              "La pression atmosphérique ici défie tous les baromètres !<E003 10>\r\n<E025 2>Je n'ai jamais rien ressenti de tel !<E049><E003 10> <E025 1>Elle... <E003 12><E332>elle m'écrase !");
                s = s.Replace("I feel it every time I'm here.<E003 10>\r\n<E025 3>That<E025 7>...<E003 8><E025 4>gravity.",
                              "Je ressens cela à chaque fois que je viens ici.<E003 10>\r\n<E025 3>Cette<E025 7>... <E003 8><E025 4>gravité.");
                s = s.Replace("Well, <E003 8>this is Britain's highest court...",
                              "Eh bien, <E003 8>c'est la plus haute cour de justice de Grande-Bretagne...");
                s = s.Replace("But are you telling me it's fitted with some kind of device\r\nthat can actually control air pressure?!",
                              "Mais me dites-vous qu'elle est équipée d'un dispositif\r\ncapable de contrôler la pression de l'air ?!");
                s = s.Replace("I think it's probably all in the mind.",
                              "Je pense que c'est une question d'impression psychologique.");
                s = s.Replace("Ah.<E049><E003 12> Yes, <E003 6><E342>well...<E049><E003 12>you won't let me down, <E003 6><E025 3>will you,<E049><E003 8>\r\nMr Naruhodo?",
                              "Ah.<E049><E003 12> Oui, <E003 6><E342>eh bien...<E049><E003 12> vous n'allez pas me laisser tomber, <E003 6><E025 3>n'est-ce pas,<E049><E003 8>\r\nMr Naruhodo ?");
                s = s.Replace("I'm counting on you in today's trial<E025 7>...<E003 16><E145 68 71><E117 68 5><E335><E025 1>to save my life!",
                              "Je compte sur vous lors du procès d'aujourd'hui<E025 7>...<E003 16><E145 68 71><E117 68 5><E335><E025 1>pour me sauver la vie !");
                s = s.Replace("To save <E049><E003 10><E164 68 78 1 2 8 0 2 1><E139 68><E025 1>the secret of my super-high-voltage\r\ninstantaneous kinesis machine from being made public!",
                              "Pour empêcher que le secret <E049><E003 10><E164 68 78 1 2 8 0 2 1><E139 68><E025 1>de ma machine de cinèse\r\ninstantanée à très haute tension ne soit divulgué !");
                s = s.Replace("Yes, <E145 68 64><E117 68 30><E003 8>I understand.<E003 12>\r\n<E025 3><E007>(I know what I have to do.)",
                              "Oui, <E145 68 64><E117 68 30><E003 8>je comprends.<E003 12>\r\n<E025 3><E007>(Je sais ce qu'il me reste à faire.)");
                s = s.Replace("(I have to establish that the explosion two days ago<E003 10> <E333>was\r\nnothing more than an unfortunate accident.)",
                              "(Je dois prouver que l'explosion d'il y a deux jours<E003 10> <E333>n'était\r\nrien d'autre qu'un regrettable accident.)");
                s = s.Replace("Well, <E049><E003 8>I'm sure there's nothing to worry about, <E003 6>really.<E049><E003 10>\r\nJustice will prevail!",
                              "Eh bien, <E049><E003 8>je suis sûr qu'il n'y a pas à s'inquiéter, <E003 6>vraiment.<E049><E003 10>\r\nLa justice triomphera !");
                s = s.Replace("My commiserations, <E003 6>Mr Naruhodo.<E003 10> You appear to have\r\nbeen lumbered with a most tiresome case here.",
                              "Mes condoléances, <E003 6>Mr Naruhodo.<E003 10> Vous semblez avoir\r\nhérité d'une affaire pour le moins fastidieuse.");
                s = s.Replace("Mr Sholmes!<E003 16>\r\nI didn't expect to see you here.",
                              "Mr Holmes !<E003 16>\r\nJe ne m'attendais pas à vous voir ici.");
                s = s.Replace("That was very mean, Runo, <E049><E003 8>leaving me alone at home\r\nwith Hurley.",
                              "Ce n'était pas très gentil, Nicky, <E049><E003 8>de me laisser seule à la maison\r\navec Sherlockinou.");
                s = s.Replace("It took me at least an hour to wake him!",
                              "Il m'a fallu au moins une heure pour le réveiller !");
                s = s.Replace("Is it...?<E049><E003 12> <E341>Are you...?",
                              "Est-ce...?<E049><E003 12> <E341>Êtes-vous...?");
                s = s.Replace("HEEEEEERLOCK <E049><E003 10><E607>SHOOOOOOLMES?!",
                              "HEEEEEERLOCK <E049><E003 10><E607>HOOOOOOLMES ?!");
                s = s.Replace("Indeed, <E003 4>sir.<E049><E145 2 64><E003 10> I am he.<E049><E003 12>\r\n<E025 3><E164 2 80 1 2 5 0 1 1><E139 2>Heeeeeerlock <E049><E003 10><E346>Shoooooolmes.",
                              "En effet, <E003 4>monsieur.<E049><E145 2 64><E003 10> C'est bien moi.<E049><E003 12>\r\n<E025 3><E164 2 80 1 2 5 0 1 1><E139 2>Heeeeeerlock <E049><E003 10><E346>Hoooooolmes.");
                s = s.Replace("Oh, <E003 8>I've heard all about your exploits, <E049><E003 6><E341>even whilst living\r\nin Germany.",
                              "Oh, <E003 8>j'ai entendu parler de tous vos exploits, <E049><E003 6><E341>même en vivant\r\nen Allemagne.");
                s = s.Replace("Ah yes.<E049><E003 8> <E025 2>Randst Magazine is on sale in Germany, too.",
                              "Ah oui.<E049><E003 8> <E025 2>Le Randst Magazine est également en vente en Allemagne.");
                s = s.Replace("This month's instalment was sublime!<E049><E003 14> Your deduction in\r\n‘The Adventure of Silver Blaze’ was wonderful!",
                              "L'épisode de ce mois-ci était sublime !<E049><E003 14> Votre déduction dans\r\n« Flamme d'Argent » était tout simplement magistrale !");
                s = s.Replace("Ah yes, <E049><E003 8>a memorable case indeed.<E049><E003 10>\r\n<E003 8><E164 2 81 1 2 6 0 0 1><E139 2><E025 2>It concerned a snake, <E049><E003 6>I seem to recall.",
                              "Ah oui, <E049><E003 8>une affaire mémorable en vérité.<E049><E003 10>\r\n<E003 8><E164 2 81 1 2 6 0 0 1><E139 2><E025 2>Il y était question d'un serpent, <E049><E003 6>si j'ai bonne mémoire.");
                s = s.Replace("No, <E049><E003 8><E025 2>that was ‘The Speckled Band’.",
                              "Mais non, <E049><E003 8><E025 2>ça c'était « Le Ruban Moucheté ».");
                s = s.Replace("Well, <E003 8><E025 2>thank you for coming.",
                              "Eh bien, <E003 8><E025 2>merci d'être venu.");
                s = s.Replace("I do appreciate your support.",
                              "J'apprécie sincèrement votre soutien.");
                s = s.Replace("I'm sorry to disappoint you, <E003 4>my dear fellow, <E049><E003 8><E025 2>but I'm afraid\r\nI can't stay.",
                              "Je suis désolé de vous décevoir, <E003 4>mon cher ami, <E049><E003 8><E025 2>mais je crains\r\nde ne pouvoir rester.");
                s = s.Replace("I have urgent business at Madame Tusspells.",
                              "J'ai une affaire urgente chez Madame Pétrie.");
                s = s.Replace("You mean...<E003 8><E341><E025 2>your waxwork job?",
                              "Vous voulez dire... <E003 8><E341><E025 2>votre travail sur la statue de cire ?");
                s = s.Replace("No no, <E049><E003 8>the waxwork abduction, <E049><E003 6>of course.<E049><E003 10>\r\n<E025 2>Madame has engaged my services.",
                              "Non non, <E049><E003 8>l'enlèvement de la statue, <E049><E003 6>bien entendu.<E049><E003 10>\r\n<E025 2>Madame a requis mes services.");
                s = s.Replace("Ah, <E003 10><E025 2>so you're trying to get to the bottom of that ransom\r\nnote, <E003 4>are you?",
                              "Ah, <E003 10><E025 2>vous essayez donc d'élucider cette demande\r\nde rançon, <E003 4>c'est cela ?");
                s = s.Replace("The week's wages depend on it!<E049><E003 10> <E025 2><E145 2 64><E117 2 15><E341>...As does the safe return\r\nof the waxwork, <E049><E003 8>naturally.",
                              "Mes gages de la semaine en dépendent !<E049><E003 10> <E025 2><E145 2 64><E117 2 15><E341>... Tout comme le retour sain et sauf\r\nde la statue, <E049><E003 8>naturellement.");
                s = s.Replace("As such, <E049><E003 2><E164 2 71 1 2 8 0 1 1><E139 2><E025 1>I intend to give it my undivided attention.",
                              "Par conséquent, <E049><E003 2><E164 2 71 1 2 8 0 1 1><E139 2><E025 1>j'ai l'intention de lui accorder toute mon attention.");
                s = s.Replace("Oh, <E003 6>well, <E003 8><E025 2>never mind then.<E003 10>\r\n<E025 2>I understand.",
                              "Oh, <E003 6>eh bien, <E003 8><E025 2>ce n'est pas grave alors.<E003 10>\r\n<E025 2>Je comprends.");
                return s;
            };

            // BB\script\output\_sce02_c100_0000_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c100_0000_eng#3"] = en => {
                string s = en;
                s = s.Replace("Of course, <E049><E003 8><E025 2>with my skills of observation and reasoning,<E049><E003 8>\r\n<E333>resolving the matter will be as easy as proverbial pie.",
                              "Bien sûr, <E049><E003 8><E025 2>avec mes dons d'observation et de déduction,<E049><E003 8>\r\n<E333>résoudre cette affaire sera un véritable jeu d'enfant.");
                s = s.Replace("I shall <E145 2 83>return forthwith.", "Je serai <E145 2 83>de retour sous peu.");
                s = s.Replace("For until I solve the case, <E049><E003 8>I shall have no money to afford\r\na pie of any description.",
                              "Car tant que je n'aurai pas résolu l'affaire, <E049><E003 8>je n'aurai pas un sou\r\npour m'acheter la moindre friandise.");
                s = s.Replace("Ooh, <E049><E003 4><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>then you must absolutely give it your full attention,\r\nHurley!",
                              "Ooh, <E049><E003 4><E025 1><E164 110 67 1 2 8 0 1 1><E139 110>dans ce cas tu dois absolument y mettre tout ton cœur,\r\nSherlockinou !");
                s = s.Replace("Quite, Iris, <E049><E003 8>quite.<E049><E003 12>\r\n<E025 2>But life is riddled with irony, <E049><E003 8>you know.",
                              "Tout à fait, Iris, <E049><E003 8>tout à fait.<E049><E003 12>\r\n<E025 2>Mais la vie est pleine d'ironie, <E049><E003 8>voyez-vous.");
                s = s.Replace("Whenever I give something my full attention, <E049><E003 8><E330>I have a\r\nquite insatiable desire for a pie.",
                              "Chaque fois que j'accorde toute mon attention à quelque chose, <E049><E003 8><E330>j'ai une\r\ninsatiable envie de tourte.");
                s = s.Replace("One of the universe's intractable mysteries, <E049><E003 8><E025 2>you might\r\nsay.",
                              "L'un des mystères les plus insondables de l'univers, <E049><E003 8><E025 2>en somme.");
                s = s.Replace("Oh yes!<E003 6> Quite!<E003 7> Definitely!<E003 8> Absolutely!<E049><E003 10>\r\n<E025 1><E045>I totally understand!",
                              "Oh oui !<E003 6> Tout à fait !<E003 7> Absolument !<E003 8> Tout à fait !<E049><E003 10>\r\n<E025 1><E045>Je comprends parfaitement !");
                s = s.Replace("(...Is someone a little starstruck?)",
                              "(...Quelqu'un est-il un peu sous le charme ?)");
                s = s.Replace("I wish you the very best of luck, <E049><E003 6>Professor Harebrayne.",
                              "Je vous souhaite bonne chance, <E049><E003 6>Dr Samba Lonron.");
                s = s.Replace("Oh!<E049><E003 6> Ah!<E049><E003 8> Ooh!<E049><E003 12>\r\n<E025 1><E335>Why, thank you!",
                              "Oh !<E049><E003 6> Ah !<E049><E003 8> Ooh !<E049><E003 12>\r\n<E025 1><E335>Mais merci mille fois !");
                s = s.Replace("Before I depart, <E049><E003 6><E025 2>Mr Naruhodo...<E049><E003 8>a word in your ear, if you\r\nplease?",
                              "Avant que je ne parte, <E049><E003 6><E025 2>Mr Naruhodo... <E049><E003 8>puis-je vous glisser un mot à l'oreille ?");
                s = s.Replace("What's this about?", "De quoi s'agit-il ?");
                s = s.Replace("As you have remarkably little grounding in science,<E049><E003 8> I feel\r\nI ought to inform you...",
                              "Comme vous manquez singulièrement de notions scientifiques,<E049><E003 8> j'estime\r\nqu'il est de mon devoir de vous prévenir...");
                s = s.Replace("As compelling as this ‘super-high-voltage instantaneous\r\nkinesis’ hypothesis may be...",
                              "Aussi séduisante que soit cette hypothèse de « cinèse\r\ninstantanée à très haute tension »...");
                s = s.Replace("...a practical implementation, <E049><E003 8>such as was attempted by\r\nthe professor at the Great Exhibition, <E049><E003 10><E025 3><E330>is quite <E006>impossible<E005>.",
                              "...une mise en pratique, <E049><E003 8>telle que tentée par\r\nle docteur à l'Exposition Universelle, <E049><E003 10><E025 3><E330>est tout bonnement <E006>impossible<E005>.");
                s = s.Replace("But, <E003 10><E025 1>but the professor said <E145 2 64>the demonstration was a\r\nsuccess!",
                              "Mais... <E003 10><E025 1>mais le docteur a affirmé <E145 2 64>que l'expérience avait été un succès !");
                s = s.Replace("Yes, <E049><E003 10><E025 2>it would appear that he fervently believes it was.",
                              "Oui, <E049><E003 10><E025 2>il semblerait qu'il en soit lui-même intimement persuadé.");
                s = s.Replace("I've read Professor Bunnybrain's paper about it, too, Runo.<E049><E003 10>\r\nAnd I have to say...",
                              "J'ai lu la thèse du Dr Samba Melon moi aussi, Nicky.<E049><E003 10>\r\nEt je dois dire...");
                s = s.Replace("...I'm sure it can't be done.<E049><E003 10> <E025 2>It could barely be done\r\ntheoretically, <E049><E003 6>let alone practically.",
                              "...que je suis sûre que c'est irréalisable.<E049><E003 10> <E025 2>C'est à peine concevable\r\nen théorie, <E049><E003 6>alors en pratique...");
                s = s.Replace("(So he's completely barking up the wrong tree?)",
                              "(Il fait donc complètement fausse route ?)");
                s = s.Replace("But how could an experiment that had no possibility of\r\nsucceeding in fact succeed?<E003 13> <E025 2><E145 2 64><E330>That's contradictory.",
                              "Mais comment une expérience impossible en théorie\r\na-t-elle pu réussir en réalité ?<E003 13> <E025 2><E145 2 64><E330>C'est contradictoire.");
                s = s.Replace("And it's that contradiction that will be at the heart of the\r\ntrial, <E049><E003 8><E025 3>I've no doubt.",
                              "Et c'est cette contradiction même qui sera au cœur du procès,<E049><E003 8><E025 3> je n'en doute pas.");
                s = s.Replace("(What's that supposed to mean?)", "(Qu'est-ce que cela veut dire ?)");
                s = s.Replace("Now, <E049><E003 8>I must hurry along.<E049><E003 6> <E025 2><E164 2 71 1 2 6 0 0 1><E139 2>I wish you the best of luck, <E049><E003 6>my\r\ndear fellow.",
                              "À présent, <E049><E003 8>je dois filer.<E049><E003 6> <E025 2><E164 2 71 1 2 6 0 0 1><E139 2>Je vous souhaite bonne chance, <E049><E003 6>mon\r\ncher ami.");
                s = s.Replace("See you later, <E145 2 64>Hurley!", "À plus tard, <E145 2 64>Sherlockinou !");
                s = s.Replace("Well, <E049><E003 8>it looks like you're on your own today, Runo.<E049><E003 12>\r\nBut chin up!<E049><E003 8> You can do it!",
                              "Eh bien, <E049><E003 8>on dirait que tu es tout seul aujourd'hui, Nicky.<E049><E003 12>\r\nMais courage !<E049><E003 8> Tu vas y arriver !");
                s = s.Replace("Oh!<E003 10> What about you, Iris?", "Oh !<E003 10> Et toi alors, Iris ?");
                s = s.Replace("Ah, no, <E049><E003 8>I'm afraid I can't help.<E049><E003 14>\r\n<E025 2><E330>I have something I need to do.",
                              "Ah non, <E049><E003 8>j'ai bien peur de ne pas pouvoir t'aider.<E049><E003 14>\r\n<E025 2><E330>J'ai quelque chose d'important à faire.");
                s = s.Replace("...I see.", "...Je vois.");
                s = s.Replace("Hehe!<E003 10> <E169 110 3><E025 2>It's going to be a big surprise for you <E049><E003 8><E164 110 68 1 2 6 0 0 1><E139 110><E025 1>when you\r\nfind out what it is!",
                              "Héhé !<E003 10> <E169 110 3><E025 2>Ce sera une grande surprise pour toi <E049><E003 8><E164 110 68 1 2 6 0 0 1><E139 110><E025 1>quand tu\r\ndécouvriras ce que c'est !");
                s = s.Replace("(That sounds ominous...)", "(Ça ne présage rien de bon...)");
                s = s.Replace("Counsel for the Defence!<E003 14> And the defendant!",
                              "Avocat de la défense !<E003 14> Et l'accusé !");
                s = s.Replace("Court is about to be in session.<E049><E003 12> <E025 1><E332>Make your way into the\r\ncourtroom at once!",
                              "L'audience est sur le point de commencer.<E049><E003 12> <E025 1><E332>Entrez dans la\r\nsalle d'audience sur-le-champ !");
                s = s.Replace("We're on our way!", "Nous arrivons !");
                s = s.Replace("(An experiment that the laws of science say can't possibly\r\nsucceed...)",
                              "(Une expérience que les lois de la science déclarent impossible...)");
                s = s.Replace("(...and a scientist who's convinced that it did.)",
                              "(... et un savant convaincu qu'elle a réussi.)");
                s = s.Replace("(That's the riddle you have to unlock here, <E003 8><E025 2>Ryunosuke!<E003 16>\r\n<E025 1><E338><E342>That's the key to this case!)",
                              "(C'est cette énigme qu'il faut percer, <E003 8><E025 2>Ryunosuke !<E003 16>\r\n<E025 1><E338><E342>C'est la clé de toute cette affaire !)");
                return s;
            };

            // BB\script\output\_sce02_c101_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c101_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("23rd October, 9:10 a.m.", "23 octobre, 9h10");
                s = s.Replace("The Old Bailey Courtroom", "Old Bailey, Salle d'audience");
                s = s.Replace("In the name of Her Majesty the Queen, <E003 8>I hereby declare\r\nthis court to be in session.",
                              "Au nom de Sa Majesté la Reine, <E003 8>je déclare l'audience ouverte.");
                s = s.Replace("We are sitting today <E049><E003 8>for the public trial of Professor\r\nAlbert Harebrayne.",
                              "Nous siégeons aujourd'hui <E049><E003 8>pour le procès public du Dr\r\nSamba Lonron.");
                s = s.Replace("I now call upon the counsels for the prosecution and\r\ndefence <E049><E003 8>to declare their willingness to proceed.",
                              "J'invite à présent l'accusation et la défense <E049><E003 8>à déclarer\r\nsi elles sont prêtes.");
                s = s.Replace("The prosecution is ready.", "L'accusation est prête.");
                s = s.Replace("The defence is...<E003 14>\r\n<E025 1><E145 1 65><E335>The defence is ready, <E003 8>My Lord!",
                              "La défense est...<E003 14>\r\n<E025 1><E145 1 65><E335>La défense est prête, <E003 8>Votre Honneur !");
                s = s.Replace("(I'm six months out of practice.<E003 8> And what's more...)",
                              "(Je n'ai pas plaidé depuis six mois.<E003 8> Et qui plus est...)");
                s = s.Replace("(...I'm without Susato-san today.)",
                              "(... Je suis sans Susato-san aujourd'hui.)");
                s = s.Replace("(Ugh<E025 7>...<E003 10> <E025 2>Is it just my imagination, <E003 8><E025 3>or does the air in here\r\nfeel even more oppressive than usual?)",
                              "(Ouh...<E025 7>...<E003 10> <E025 2>Est-ce juste mon imagination, <E003 8><E025 3>ou l'atmosphère semble-t-elle\r\nencore plus pesante que d'habitude ?)");
                s = s.Replace("So...", "Ainsi...");
                s = s.Replace("...I must say I recollect the victim of this case all too well.<E049><E003 10>\r\n<E025 5>Mr Odie Asman.",
                              "... je dois dire que je ne me rappelle que trop bien la victime.<E049><E003 10>\r\n<E025 5>Mr Odie Asman.");
                s = s.Replace("Mr Asman was well known as a financier...<E049><E003 10><E145 16 19><E118 16 0.6><E003 10>though that<E049><E003 12>\r\n<E330><E025 2>was merely a front for his diverse criminal activities.",
                              "Mr Asman était connu comme financier...<E049><E003 10><E145 16 19><E118 16 0.6><E003 10> bien que ce ne fût<E049><E003 12>\r\n<E330><E025 2>qu'une façade pour ses multiples activités criminelles.");
                s = s.Replace("It was only a month ago that the man appeared in court\r\nprosecuted by you, <E049><E003 6>Lord van Zieks.",
                              "Il y a un mois à peine, cet homme comparaissait ici même\r\npoursuivi par vos soins, <E049><E003 6>Lord Van Peers.");
                s = s.Replace("But the jury unanimously found him not guilty.",
                              "Mais les jurés l'ont unanimement acquitté.");
                s = s.Replace("(Because every member of the jury had been bribed,<E003 6> by\r\nthe sound of it.)",
                              "(Parce que chaque membre du jury avait été soudoyé,<E003 6> à ce qu'il paraît.)");
                s = s.Replace("(These powerful London criminals are prepared to go to\r\nextreme lengths to keep their freedom.)",
                              "(Ces puissants criminels londoniens sont prêts à tout pour conserver leur liberté.)");
                s = s.Replace("But two days ago, <E049><E003 6>on 21st October, <E049><E003 8>Mr Asman met his end.",
                              "Mais il y a deux jours, <E049><E003 6>le 21 octobre, <E049><E003 8>Mr Asman a trouvé la mort.");
                s = s.Replace("The work of the Reaper, <E049><E003 6>was it?",
                              "L'œuvre du Faucheur, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("If that is how Your Lordship would describe <E049><E003 8><E330><E025 4>divine\r\nretribution<E025 7>...",
                              "Si c'est ainsi que Votre Seigneurie souhaite qualifier <E049><E003 8><E330><E025 4>le châtiment\r\ndivin<E025 7>...");
                s = s.Replace("But the fact remains that Mr Asman's death...",
                              "Mais il n'en demeure pas moins que la mort de Mr Asman...");
                s = s.Replace("...was a direct result of the actions of the accused,<E049><E003 10>\r\n<E333>Professor Harebrayne.",
                              "...est la conséquence directe des agissements de l'accusé,<E049><E003 10>\r\n<E333>le Dr Samba Lonron.");
                s = s.Replace("Very well, then.", "Très bien, dans ce cas.");
                s = s.Replace("Now, <E049><E003 8>ladies and gentlemen of the jury...<E049><E003 10> You have been\r\nselected at random to represent the will of the people.",
                              "À présent, <E049><E003 8>mesdames et messieurs les jurés...<E049><E003 10> vous avez été\r\ntirés au sort pour incarner la volonté du peuple.");
                s = s.Replace("Are the six of you ready to fulfil your societal duty?",
                              "Êtes-vous tous les six prêts à accomplir votre devoir civique ?");
                s = s.Replace("I'm most gratified to have been selected to carry out this\r\nimportant civic duty, <E049><E003 6><E025 2>My Lord.",
                              "Je suis très honoré d'avoir été choisi pour cette noble\r\nmission civique, <E049><E003 6><E025 2>Votre Honneur.");
                s = s.Replace("To have a man's fate in the palm of one's hand...<E003 12>\r\n<E145 114 66><E025 2>Oh gosh!<E003 8> Oh golly!<E003 8> It sends shivers down my spine.",
                              "Avoir le destin d'un homme entre ses mains...<E003 12>\r\n<E145 114 66><E025 2>Oh là là !<E003 8> Mon Dieu !<E003 8> J'en ai des frissons dans le dos.");
                return s;
            };

            // BB\script\output\_sce02_c101_0000_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c101_0000_eng#3"] = en => {
                string s = en;
                s = s.Replace("To have a man's fate in the palm of one's hand...<E003 12>\r\n<E145 114 66><E025 2>Oh gosh!<E003 8> Oh golly!<E003 8> It sends shivers down my spine.",
                              "Avoir le destin d'un homme entre ses mains...<E003 12>\r\n<E145 114 66><E025 2>Oh là là !<E003 8> Mon Dieu !<E003 8> J'en ai des frissons dans le dos.");
                return s;
            };

            // BB\script\output\_sce02_c101_0000_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c101_0000_eng#4"] = en => {
                string s = en;
                s = s.Replace("Science experiments, <E049><E003 8>magic, <E049><E003 8>conjuring tricks, <E049><E003 8>courtroom\r\ntrials<E025 7>...<E003 15> <E025 2>All are nothing more than performances.",
                              "Expériences de science, <E049><E003 8>magie, <E049><E003 8>illusionnisme, <E049><E003 8>procès\r\nen cour de justice<E025 7>...<E003 15> <E025 2>Tout cela n'est que mise en scène.");
                s = s.Replace("Any spurious scholar that defiles the reputation of science<E049><E003 10>\r\n<E025 1><E332>deserves to hang!",
                              "Tout pseudo-savant qui bafoue l'honneur de la science<E049><E003 10>\r\n<E025 1><E332>mérite la potence !");
                s = s.Replace("Um, <E003 6>we 'ave to listen to what's said on both sides 'the\r\nfence, <E003 8><E025 3><E341>and um...<E003 8><E025 2>then settle on one...<E049><E003 8> That's it, isn't it?",
                              "Euh, <E003 6>faut écouter ce que chacun raconte des deux côtés\r\nde la barrière, <E003 8><E025 3><E341>et pis...<E003 8><E025 2> choisir...<E049><E003 8> C'est bien ça ?");
                s = s.Replace("Wasn't like this in my day!<E049><E003 12>\r\n<E025 1>Wasn't like this at all!",
                              "C'était pas comme ça de mon temps !<E049><E003 12>\r\n<E025 1>Pas du tout comme ça !");
                s = s.Replace("(That's...<E003 10>that's...)", "(C'est... <E003 10>c'est...)");
                s = s.Replace("(...the police killer Ottermole look-alike<E025 7>...<E003 10><E025 5>again<E025 3>.)",
                              "(... le sosie du tueur de flics Ottermole<E025 7>...<E003 10><E025 5> encore lui<E025 3>.)");
                s = s.Replace("(And he's as exhausted as ever, <E003 8>it seems.)",
                              "(Et il a l'air aussi exténué que d'habitude, <E003 8>on dirait.)");
                s = s.Replace("Now, <E049><E003 8>as I'm sure you are all aware...",
                              "Maintenant, <E049><E003 8>comme vous le savez certainement tous...");
                s = s.Replace("...the incident we are here to judge today tragically took\r\nplace at the Great Exhibition, <E049><E003 8>shortly after its opening.",
                              "...le drame que nous jugeons aujourd'hui s'est produit\r\nà l'Exposition Universelle, <E049><E003 8>peu après son inauguration.");
                s = s.Replace("Though the death toll could have been far worse.<E049><E003 12>\r\n<E025 2>With the exception of the victim, <E049><E003 6>no one was killed.",
                              "Bien que le bilan eût pu être bien plus lourd.<E049><E003 12>\r\n<E025 2>À l'exception de la victime, <E049><E003 6>nul autre n'a péri.");
                s = s.Replace("Nevertheless, <E049><E003 10><E025 2>the dream of the science being exhibited\r\nrapidly turned into a nightmare for the spectators.",
                              "Néanmoins, <E049><E003 10><E025 2>le rêve scientifique exposé au public s'est\r\nrapidement transformé en cauchemar pour les spectateurs.");
                s = s.Replace("A tragic turn of events.<E049><E003 10> <E025 2>And as such, <E049><E003 8>the eyes of all\r\nLondon–<E049><E003 10> No, <E049><E003 12>of the whole world will be on this trial.",
                              "Une tournure tragique.<E049><E003 10> <E025 2>Et à ce titre, <E049><E003 8>les yeux de tout\r\nLondres...<E049><E003 10> non, <E049><E003 12>du monde entier sont braqués sur ce procès.");
                s = s.Replace("It is our duty to reach a swift and just conclusion,<E003 6> I feel.",
                              "Il est de notre devoir de parvenir à un verdict rapide et juste.");
                s = s.Replace("So<E025 7>...<E003 8><E025 2>your opening statement please, <E049><E003 8><E025 3>Lord van Zieks.",
                              "Ainsi<E025 7>... <E003 8><E025 2>votre déclaration liminaire s'il vous plaît, <E049><E003 8><E025 3>Lord Van Peers.");
                s = s.Replace("At the heart of this incident...", "Au cœur de cette affaire...");
                s = s.Replace("...is <E006>technology<E005> never before demonstrated anywhere in\r\nthe world.",
                              "...se trouve une <E006>technologie<E005> encore jamais démontrée\r\nnulle part au monde.");
                s = s.Replace("One of science's latest developments, <E049><E003 8><E025 3>I take it?",
                              "L'un des derniers progrès de la science, <E049><E003 8><E025 3>j'imagine ?");
                s = s.Replace("The government is keen to capitalise on the Great\r\nExhibition to improve Britain's technological advantage.",
                              "Le gouvernement souhaite tirer parti de l'Exposition\r\nUniverselle pour asseoir la suprématie technique britannique.");
                s = s.Replace("The technology being demonstrated by the accused was\r\ndescribed as <E049><E003 15><E025 3>‘super-high-voltage instantaneous kinesis’.",
                              "La technologie démontrée par l'accusé était\r\nqualifiée de <E049><E003 15><E025 3>« cinèse instantanée à très haute tension ».");
                s = s.Replace("Good Lord!", "Grand Dieu !");
                s = s.Replace("It's designed to ‘disassemble’ human subjects using\r\nextremely high-voltage electricity...",
                              "Elle est conçue pour « désassembler » un corps humain grâce\r\nà une électricité à très haute tension...");
                s = s.Replace("...and ‘beam’ them instantly to another location where\r\nthey are <E145 1 84>subsequently reassembled.",
                              "... et le « téléporter » instantanément ailleurs où\r\nil est <E145 1 84>réassemblé.");
                s = s.Replace("Is...<E003 10><E025 2>is such a thing even within the realms of possibility?",
                              "Une... <E003 10><E025 2>une telle prouesse est-elle du domaine du possible ?");
                s = s.Replace("Well I don't believe it, <E049><E003 8>that's for sure.",
                              "Moi je n'y crois pas une seule seconde, <E049><E003 8>c'est certain.");
                s = s.Replace("Disassembling people with electricity?<E049><E003 10>\r\n<E025 1>My goodness!<E049><E003 12> How shocking!",
                              "Désassembler des gens avec du courant ?<E049><E003 10>\r\n<E025 1>Mon Dieu !<E049><E003 12> Quel choc !");
                s = s.Replace("Hah!<E049><E003 10> <E025 1>The whole idea is absurd!<E049><E003 12>\r\nThe hypothesis would never stand up to scrutiny!",
                              "Ha !<E049><E003 10> <E025 1>Cette idée est saugrenue !<E049><E003 12>\r\nUne telle hypothèse ne résiste pas à l'analyse !");
                s = s.Replace("Sir, <E049><E003 8><E025 2><E330>I believe you are a fellow of the Royal Society, <E049><E003 6>are\r\nyou not?<E049><E003 10> An expert in your field?",
                              "Monsieur, <E049><E003 8><E025 2><E330>vous êtes membre de la Royal Society, <E049><E003 6>n'est-ce\r\npas ?<E049><E003 10> Un éminent expert dans votre domaine ?");
                s = s.Replace("I am, <E049><E003 12>and my word on the matter can be considered final.<E049><E003 14>\r\n<E332>Instantaneous kinesis is poppycock!",
                              "Parfaitement, <E049><E003 12>et ma parole fait autorité en la matière.<E049><E003 14>\r\n<E332>La cinèse instantanée est une pure baliverne !");
                s = s.Replace("(So this expert and Mr Sholmes are in agreement.<E003 12>\r\n<E025 2><E338>It's <E006>impossible<E007>...)",
                              "(Cet expert et Mr Holmes sont donc du même avis.<E003 12>\r\n<E025 2><E338>C'est <E006>impossible<E007>...)");
                s = s.Replace("What is the prosecution's view on the matter?",
                              "Quel est l'avis de l'accusation à ce sujet ?");
                s = s.Replace("The prosecution would assert...", "L'accusation affirme...");
                s = s.Replace("...that the accused's instantaneous kinesis demonstration<E049><E003 20>\r\n<E025 2><E046>was <E006>a success<E005>.",
                              "... que la démonstration de cinèse instantanée de l'accusé<E049><E003 20>\r\n<E025 2><E046>fut <E006>un franc succès<E005>.");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("What rot!", "Quelle absurdité !");
                s = s.Replace("Ordaaar!<E003 5> Ordaaar!", "Silence !<E003 5> Silence !");
                s = s.Replace("The professor's hypothesis is currently under\r\ninvestigation by the British government.",
                              "L'hypothèse du docteur est actuellement à l'étude\r\npar le gouvernement britannique.");
                s = s.Replace("If it is deemed to have merit, <E049><E003 8><E025 2><E330>a substantial <E006>research grant<E005>\r\nwould be made available.",
                              "Si elle s'avère fondée, <E049><E003 8><E025 2><E330>une importante <E006>subvention de recherche<E005>\r\nlui sera allouée.");
                s = s.Replace("The accused made use of the invention built on his new\r\nhypothesis <E049><E003 8><E025 2><E338><E341>to take Mr Asman's life...",
                              "L'accusé a tiré parti de la machine issue de sa théorie<E049><E003 8><E025 2><E338><E341> pour ôter la vie à Mr Asman...");
                s = s.Replace("...in order to be the sole benefactor of the grant.",
                              "...afin d'être le seul et unique bénéficiaire de la subvention.");
                s = s.Replace("But, <E049><E003 8>but...", "Mais... <E049><E003 8>mais...");
                s = s.Replace("This disastrous demonstration was no accident.",
                              "Cette désastreuse démonstration n'avait rien d'un accident.");
                s = s.Replace("It was carefully designed from the outset <E049><E003 15><E046><E025 1>to end the life\r\nof the victim.",
                              "Elle a été méticuleusement préméditée dès l'origine <E049><E003 15><E046><E025 1>pour coûter la vie\r\nà la victime.");
                s = s.Replace("Thank you, <E003 4>Lord van Zieks.<E049><E003 10>\r\nThe prosecution's stance is clear.",
                              "Merci, <E003 4>Lord Van Peers.<E049><E003 10>\r\nLa position de l'accusation est claire.");
                s = s.Replace("But you will now bring forth witnesses to substantiate\r\nyour claims.",
                              "Veuillez maintenant faire entendre vos témoins pour étayer vos dires.");
                s = s.Replace("...Gladly, <E049><E003 6><E025 3>My Lord.", "...Bien volontiers, <E049><E003 6><E025 3>Votre Honneur.");
                s = s.Replace("Bailiff!<E049><E003 14> <E025 1><E346>Show the first witnesses to the stand!",
                              "Huissier !<E049><E003 14> <E025 1><E346>Faites entrer les premiers témoins à la barre !");
                return s;
            };

            // BB\script\output\_sce02_c101_0010_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c101_0010_eng#2"] = en => {
                string s = en;
                s = s.Replace("Witnesses, <E049><E003 10>state your names and occupations for the\r\ncourt.",
                              "Témoins, <E049><E003 10>veuillez décliner vos noms et professions.");
                s = s.Replace("Yes, sir!", "À vos ordres !");
                s = s.Replace("Tobias Gregson, <E049><E003 8>Detective Inspector at Scotland Yard's\r\nhomicide division.",
                              "Tobias Gregson, <E049><E003 8>inspecteur de police à la brigade des homicides de Scotland Yard.");
                s = s.Replace("I was on duty at the demonstration on the day in question\r\nand in charge of the followin' investigation.",
                              "J'étais de service lors de ladite démonstration et en charge de l'enquête qui a suivi.");
                s = s.Replace("Albert Harebrayne!<E003 8>\r\n<E025 1>S-<E003 8>S-<E049><E003 10><E607>Scientist!",
                              "Samba Lonron !<E003 8>\r\n<E025 1>S-<E003 8>S-<E049><E003 10><E607>Savant !");
                s = s.Replace("You were born in England, <E049><E003 6><E025 2>but have been carrying out\r\nresearch in Germany in recent years.<E049><E003 10><E025 3> Correct?",
                              "Vous êtes né en Angleterre, <E049><E003 6><E025 2>mais vous avez mené vos\r\nrecherches en Allemagne ces dernières années.<E049><E003 10><E025 3> C'est exact ?");
                s = s.Replace("Yes.<E049><E003 8> Yes, <E049><E003 12><E335>that's right.",
                              "Oui.<E049><E003 8> Oui, <E049><E003 12><E335>c'est tout à fait cela.");
                s = s.Replace("After graduating from university here in Britain, <E003 4>I went\r\nto work in Germany...<E003 8><E025 1>and made an amazing discovery!",
                              "Après mes études universitaires ici en Grande-Bretagne, <E003 4>je suis\r\nparti travailler en Allemagne... <E003 8><E025 1>et j'ai fait une découverte stupéfiante !");
                s = s.Replace("Which is what brought me back!<E049><E003 12> <E145 68 71><E117 68 5><E025 1><E346>I had to demonstrate my\r\nincredible hypothesis at the Great Exhibition!",
                              "C'est ce qui m'a fait revenir !<E049><E003 12> <E145 68 71><E117 68 5><E025 1><E346>Je devais démontrer mon\r\nincroyable hypothèse à l'Exposition Universelle !");
                s = s.Replace("What you demonstrated was incredible alright.<E049><E003 10>\r\n<E025 1>An incredible explosion!",
                              "Ce que vous avez démontré était incroyable, pas de doute.<E049><E003 10>\r\n<E025 1>Une incroyable explosion !");
                s = s.Replace("But the science!<E049><E003 10> The science was a success!<E049><E003 12>\r\n<E160 68><E139 68><E046>The instantaneous kinesis worked!",
                              "Mais la science !<E049><E003 10> La science a triomphé !<E049><E003 12>\r\n<E160 68><E139 68><E046>La cinèse instantanée a parfaitement fonctionné !");
                s = s.Replace("E-<E049><E003 10>Everyone saw it!<E049><E003 10> They must have done!<E049><E003 10><E086 5 31><E145 68 72><E117 68 8><E003 10>\r\n<E025 2>Yes, <E049><E003 8>there was the terrible accident, <E049><E003 8><E025 4>but<E025 7>...",
                              "T-<E049><E003 10>Tout le monde l'a vu !<E049><E003 10> Ils ont tous vu !<E049><E003 10><E086 5 31><E145 68 72><E117 68 8><E003 10>\r\n<E025 2>Certes, <E049><E003 8>il y a eu ce terrible accident, <E049><E003 8><E025 4>mais<E025 7>...");
                s = s.Replace("...the demonstration of my hypothesis was a success!",
                              "...la démonstration de mon hypothèse a été une totale réussite !");
                s = s.Replace("Well, <E049><E003 8><E025 2>that much is undeniable.<E049><E003 8> As shown in this\r\nphotograph taken by the Forensic Investigation Team.",
                              "Sur ce point, <E049><E003 8><E025 2>c'est indéniable.<E049><E003 8> Comme le montre ce\r\ncliché pris par la police scientifique.");
                s = s.Replace("This was taken inside the Crystal Tower, <E003 8>I take it?<E003 10>\r\n<E025 3>The centrepiece of the exhibition, <E003 4>no less.",
                              "Cette photo a été prise dans la Tour de Cristal, <E003 8>j'imagine ?<E003 10>\r\n<E025 3>La pièce maîtresse de l'Exposition, <E003 4>rien de moins.");
                s = s.Replace("That's right, <E003 4>My Lord.<E003 8> Seems the victim rammed straight\r\ninto it.",
                              "C'est exact, <E003 4>Votre Honneur.<E003 8> On dirait que la victime s'y est écrasée de plein fouet.");
                s = s.Replace("Hm, <E003 8><E169 15 3><E025 3>I see<E025 7>...<E003 10><E145 15 0><E003 6>\r\n<E025 2>Very well, <E049><E003 8>submit the photograph as evidence.",
                              "Hum, <E003 8><E169 15 3><E025 3>je vois<E025 7>...<E003 10><E145 15 0><E003 6>\r\n<E025 2>Très bien, <E049><E003 8>cette photographie est versée comme pièce à conviction.");
                s = s.Replace("The photograph of the victim has been\r\nentered into the Court Record.",
                              "La photographie de la victime a été ajoutée au dossier.");
                s = s.Replace("As the court's heard, <E049><E003 6>the victim of the incident was\r\nMr Odie Asman.",
                              "Comme la cour l'a entendu, <E049><E003 6>la victime n'est autre que\r\nMr Odie Asman.");
                s = s.Replace("There have been a number of allegations made against\r\nthe man, <E049><E003 8>but puttin' them aside for the time bein'...",
                              "Cet homme faisait l'objet de lourdes accusations, <E049><E003 8>mais mettons cela de côté pour l'instant...");
                s = s.Replace("...he was the man who financed the research for the\r\nexperiment and the demonstration itself.",
                              "...c'est lui qui finançait les recherches pour l'expérience et la démonstration.");
                s = s.Replace("I see.<E049><E003 12>\r\n<E025 2>So to summarise the situation...",
                              "Je vois.<E049><E003 12>\r\n<E025 2>Pour résumer les faits...");
                s = s.Replace("...the defendant is accused of taking the life of the man\r\nwho funded his work.<E049><E003 10> <E025 3>Would that be correct?",
                              "...l'accusé aurait assassiné l'homme qui finançait ses travaux.<E049><E003 10> <E025 3>Est-ce bien cela ?");
                s = s.Replace("Exactly.", "Parfaitement.");
                s = s.Replace("But couldn't it be...", "Mais ne se pourrait-il pas...");
                s = s.Replace("...that the explosion was caused by some malfunction in\r\nthe apparatus used for the demonstration?",
                              "...que l'explosion soit due à une défaillance de la machine utilisée pour l'expérience ?");
                s = s.Replace("That's right!<E003 10> That must be it!<E003 12> <E025 3>My splendid machine...<E003 12>\r\nMy poor, <E003 6>splendid machine...",
                              "C'est ça !<E003 10> Ce doit être cela !<E003 12> <E025 3>Ma splendide machine...<E003 12>\r\nMa pauvre, <E003 6>splendide machine...");
                s = s.Replace("You saw it yesterday, <E049><E003 6>didn't you?",
                              "Vous l'avez vue hier, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("We can't even examine the wreckage thanks to the<E003 4><E171 68 25 1 9 2>\r\n<E330>Special Dispensation for Scientific Equipment Act.",
                              "On ne peut même pas examiner les débris en raison de la<E003 4><E171 68 25 1 9 2>\r\n<E330>Loi d'exemption sur les équipements scientifiques.");
                s = s.Replace("WHAA<E025 8>AAAA<E025 9><E342>AAAT<E341><E025 1>?!<E003 14>\r\n<E025 1><E164 68 78 1 2 9 0 2 1><E139 68>The wreckage?!<E049><E003 14> THE WRECKAGE?!",
                              "QUOOOO<E025 8>OOOO<E025 9><E342>OOOI<E341><E025 1> ?!<E003 14>\r\n<E025 1><E164 68 78 1 2 9 0 2 1><E139 68>Les débris ?!<E049><E003 14> LES DÉBRIS ?!");
                s = s.Replace("But that being the case, <E049><E003 8><E025 2>how can the facts be established?",
                              "Mais dans ce cas, <E049><E003 8><E025 2>comment établir la vérité des faits ?");
                s = s.Replace("How can it possibly be determined whether this was an\r\naccident or a deliberate and malicious act?",
                              "Comment déterminer s'il s'agit d'un accident ou d'un acte criminel délibéré ?");
                s = s.Replace("Extremely simply, <E049><E003 8>My Lord.", "De façon fort simple, <E049><E003 8>Votre Honneur.");
                s = s.Replace("I beg your pardon?", "Pardonnez-moi ?");
                s = s.Replace("Isn't that right, <E049><E003 10><E145 6 3><E118 6 0.6><E003 6><E025 4>witness?",
                              "N'est-ce point exact, <E049><E003 10><E145 6 3><E118 6 0.6><E003 6><E025 4>témoin ?");
                s = s.Replace("Wha...?<E049><E003 14> Sorry?<E049><E003 12> ME?!",
                              "Quoi... ?<E049><E003 14> Pardon ?<E049><E003 12> MOI ?!");
                s = s.Replace("No.<E049><E003 14> <E025 3>Your neighbour.", "Non.<E049><E003 14> <E025 3>Votre voisin.");
                s = s.Replace("Yes, sir!<E049><E003 8> It was murder, <E049><E003 6>plain and simple.<E049><E003 10>\r\n<E025 2>Anyone could state that with complete certainty.",
                              "Tout à fait !<E049><E003 8> C'était un meurtre, <E049><E003 6>pur et simple.<E049><E003 10>\r\n<E025 2>N'importe qui l'affirmerait sans l'ombre d'un doute.");
                s = s.Replace("What?!<E049><E003 12>\r\n<E025 2><E007>(How can he possibly think that?)",
                              "Quoi ?!<E049><E003 12>\r\n<E025 2><E007>(Comment peut-il prétendre une chose pareille ?)");
                s = s.Replace("Thank you, Inspector.<E049><E003 10>\r\n<E025 2>I think we had better proceed to formal testimony.",
                              "Merci, Inspecteur.<E049><E003 10>\r\n<E025 2>Je vous invite à faire votre déposition formelle.");
                s = s.Replace("You will explain to the court <E049><E003 8><E346><E025 1><E342>on what grounds you claim\r\nthis experiment to have been a front for murder!",
                              "Expliquez à la cour <E049><E003 8><E346><E025 1><E342>sur quelles bases vous soutenez\r\nque cette expérience n'était qu'un prétexte pour tuer !");
                return s;
            };

            // BB\script\output\_sce02_c101_0020_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c101_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("– A Front for Murder –", "– Un prétexte pour tuer –");
                s = s.Replace("The corpse that went crashin' through the Crystal Tower\r\nhad a broken neck.",
                              "Le corps qui a traversé la vitre de la Tour de Cristal\r\navait les vertèbres cervicales brisées.");
                s = s.Replace("I, <E049><E003 12><E025 2>I made a minor miscalculation in the angle of the beam\r\nprojection, <E003 6><E025 1>that's all!<E049><E003 12> <E025 1><E335>That was my mistake!",
                              "J-Je <E049><E003 12><E025 2>n'ai fait qu'une légère erreur de calcul sur l'angle du faisceau\r\nde projection, <E003 6><E025 1>c'est tout !<E049><E003 12> <E025 1><E335>C'était ma seule faute !");
                s = s.Replace("But the post-mortem examination revealed another\r\ninjury.<E049><E003 12> <E025 3>A fatal wound.",
                              "Mais le rapport d'autopsie a révélé une autre blessure.<E049><E003 12> <E025 3>Une blessure mortelle.");
                s = s.Replace("There was <E006>a lesion<E005> in his chest where he'd clearly been\r\nstabbed by somethin' sharp right in the heart!",
                              "Il avait <E006>une plaie béante<E005> à la poitrine : il a reçu un coup d'objet pointu en plein cœur !");
                s = s.Replace("So the victim was killed <E006>before<E005> he went anywhere.<E049><E003 10>\r\nAnd this fella's the only one who could have done it!",
                              "La victime a donc été tuée <E006>avant<E005> d'être projetée.<E049><E003 10>\r\nEt ce type est le seul qui aurait pu lui porter ce coup !");
                return s;
            };

            // BB\script\output\_sce02_c101_0020_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c101_0020_eng#3"] = en => {
                string s = en;
                s = s.Replace("An extraordinary business...", "Une bien singulière affaire...");
                s = s.Replace("In addition to suffering a broken neck, <E049><E003 8>the victim was\r\nstabbed in the heart?",
                              "En plus du cou brisé, <E049><E003 8>la victime a été poignardée en plein cœur ?");
                s = s.Replace("(Information I would really like to have heard from\r\nsomeone <E003 8><E025 1><E606>other than the judge...)",
                              "(Une information capitale que j'aurais aimé entendre de la part de quelqu'un <E003 8><E025 1><E606>d'autre que le juge...)");
                s = s.Replace("The coroner says death would have been all but instant\r\nfrom a wound like that.",
                              "Le médecin légiste certifie que la mort fut quasi instantanée avec une telle blessure.");
                s = s.Replace("You could say, <E049><E003 8><E025 3>in fact...", "On peut affirmer, <E049><E003 8><E025 3>à la vérité...");
                s = s.Replace("...that the victim was <E049><E003 8><E330><E025 4><E006>killed twice<E005> <E049><E003 8><E025 3>by the accused.",
                              "... que la victime a été <E049><E003 8><E330><E025 4><E006>tuée deux fois<E005> <E049><E003 8><E025 3>par l'accusé.");
                s = s.Replace("No, <E003 10>no <E003 10>and no!<E003 14> <E025 2>That couldn't be further from the truth!",
                              "Non, <E003 10>non <E003 10>et non !<E003 14> <E025 2>Rien n'est plus faux !");
                s = s.Replace("I have here the experiment plan document that was\r\nsubmitted to the security team.",
                              "J'ai ici le plan d'expérience officiel remis au service de sécurité.");
                s = s.Replace("The victim stood himself inside somethin' called ‘the\r\nbirdcage’, <E003 8>ready to be ‘beamed’ instantly...",
                              "La victime s'est installée dans ce qu'on appelle la « cage », <E003 8>prête à être téléportée...");
                s = s.Replace("...to the second level of the Crystal Tower, <E003 6>about\r\ntwenty-five yards away.",
                              "... jusqu'au second niveau de la Tour de Cristal, <E003 6>à environ vingt-cinq mètres.");
                s = s.Replace("The experiment did not go according to plan, <E049><E003 8><E025 4>however.",
                              "L'expérience n'a cependant point fonctionné <E049><E003 8><E025 4>comme prévu.");
                s = s.Replace("As the machine was put into operation, <E003 8>there was <E006>a large\r\nexplosion<E005>.",
                              "Dès la mise en marche de l'appareil, <E003 8>il y a eu <E006>une forte explosion<E005>.");
                s = s.Replace("The blast caused the beam transmitter <E003 8><E330>to <E006>point higher<E005>\r\nthan intended.",
                              "Le souffle a dévié l'émetteur de faisceau <E003 8><E330>vers le <E006>haut<E005>.");
                s = s.Replace("Accordingly, <E003 8>the kinesis resulted in the birdcage\r\nmaterialising <E006>in mid-air<E005>...",
                              "En conséquence, <E003 8>la cage s'est matérialisée <E006>dans le vide<E005>...");
                s = s.Replace("...from where it subsequently fell, <E003 8><E025 2>crashing through the\r\nglass of the Crystal Tower's large round window.",
                              "... d'où elle a fait une chute, <E003 8><E025 2>brisant la grande verrière de la Tour de Cristal.");
                s = s.Replace("My word<E025 7>...<E003 10> <E025 2><E145 15 5>One assumes the victim's neck was broken\r\nupon impact with the tower, then?",
                              "Grands dieux...<E025 7>...<E003 10> <E025 2><E145 15 5>On en déduit que le cou de la victime a été brisé lors de l'impact ?");
                s = s.Replace("I'm, <E003 10><E025 1><E331>I'm so sorry!<E003 12> I didn't mean for this to happen!<E049><E003 14>\r\n<E025 2>The machine was just too powerful!",
                              "Je... <E003 10><E025 1><E331>je suis si désolé !<E003 12> Je ne voulais pas que cela arrive !<E049><E003 14>\r\n<E025 2>La machine a délivré trop de puissance !");
                s = s.Replace("But honestly!<E003 8> <E164 68 77 1 2 1 0 1 1><E139 68><E025 1>Really!<E003 8> I swear!<E049><E003 10>\r\n<E332>It was just an accident!<E003 8> A terrible accident!",
                              "Mais croyez-moi !<E003 8> <E164 68 77 1 2 1 0 1 1><E139 68><E025 1>Vraiment !<E003 8> Je le jure !<E049><E003 10>\r\n<E332>Ce n'était qu'un accident !<E003 8> Un terrible accident !");
                s = s.Replace("Unfortunately, <E049><E003 8><E145 6 2><E025 3>that excuse can't save you.",
                              "Malheureusement, <E049><E003 8><E145 6 2><E025 3>cette excuse ne saurait vous disculper.");
                s = s.Replace("No, <E049><E003 12><E145 7 74><E333><E025 2>not considerin' <E006>the sharp murder weapon<E005> that pierced\r\nthe victim's heart.",
                              "Non, <E049><E003 12><E145 7 74><E333><E025 2>surtout au vu de <E006>l'arme pointue<E005> qui a perforé le cœur de la victime.");
                s = s.Replace("M-<E003 8><E338><E342>Murder weapon?!<E003 12>\r\n<E025 1><E342>What are you saying?!",
                              "L-<E003 8><E338><E342>L'arme du crime ?!<E003 12>\r\n<E025 1><E342>Mais que racontez-vous ?!");
                s = s.Replace("This is the autopsy report submitted by the coroner.",
                              "Voici le rapport d'autopsie rédigé par le médecin légiste.");
                s = s.Replace("The prosecution would like it entered into the Court\r\nRecord.",
                              "L'accusation demande qu'il soit versé au dossier.");
                s = s.Replace("Your request is granted, <E049><E003 8>Counsel.", "Requête accordée, <E049><E003 8>Monsieur le Procureur.");
                s = s.Replace("The autopsy report has been\r\nentered into the Court Record.",
                              "Le rapport d'autopsie a été versé au dossier.");
                s = s.Replace("I was there in person, <E003 4>you know.<E049><E003 10>\r\nI saw the whole ludicrous performance.",
                              "J'y étais en personne, <E003 4>vous savez.<E049><E003 10>\r\nJ'ai assisté à toute cette mascarade.");
                s = s.Replace("And the only other person on the stage with Mr Asman<E049><E003 10>\r\n<E335><E025 1><E342><E338>was that disgraceful excuse for a scientist!",
                              "Et la seule autre personne sur l'estrade aux côtés de Mr Asman<E049><E003 10>\r\n<E335><E025 1><E342><E338>était ce pitoyable individu qui se prétend scientifique !");
                s = s.Replace("Then really, <E049><E003 10><E025 3>by all accounts it must have been him.",
                              "Dans ce cas, <E049><E003 10><E025 3>tout porte à croire que c'est bien lui.");
                s = s.Replace("Hmph.<E003 8> <E169 113 3><E025 3>Hard to think otherwise, <E049><E003 8>really.",
                              "Hum.<E003 8> <E169 113 3><E025 3>Difficile d'imaginer le contraire, <E049><E003 8>en vérité.");
                s = s.Replace("Very well.<E049><E003 8> Counsel for the Defence...<E003 12>proceed with the\r\ncross-examination, please.",
                              "Bien.<E049><E003 8> Maître Naruhodo...<E003 12> commencez le contre-interrogatoire, s'il vous plaît.");
                s = s.Replace("Oh, <E049><E003 8><E145 1 65><E003 5><E025 1><E335>yes, <E049><E003 12>My Lord!",
                              "Oh, <E049><E003 8><E145 1 65><E003 5><E025 1><E335>bien, <E049><E003 12>Votre Honneur !");
                s = s.Replace("I need to focus here...<E003 8>\r\n<E025 1><E164 1 75 1 2 8 0 1 1><E139 1>It's been a while!",
                              "Concentration maximale...<E003 8>\r\n<E025 1><E164 1 75 1 2 8 0 1 1><E139 1>Ça fait si longtemps !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#2"] = en => {
                return en.Replace("– A Front for Murder –", "– Un prétexte pour tuer –");
            };

            // BB\script\output\_sce02_c101_0030_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#4"] = en => {
                string s = en;
                s = s.Replace("The corpse that went crashin' through the Crystal Tower\r\nhad a broken neck.",
                              "Le cadavre qui a défoncé la vitre de la Tour de Cristal\r\navait le cou brisé.");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#5"] = en => {
                string s = en;
                s = s.Replace("I, I made a minor miscalculation in the angle of the beam\r\nprojection, that's all! That was my mistake!",
                              "J-Je n'ai fait qu'une petite erreur sur l'angle du faisceau\r\nde projection, c'est tout ! C'était ma seule faute !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#6"] = en => {
                string s = en;
                s = s.Replace("But the post-mortem examination revealed another\r\ninjury. A fatal wound.",
                              "Mais le rapport du médecin légiste a révélé une autre blessure.\r\nUne blessure mortelle.");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#7"] = en => {
                string s = en;
                s = s.Replace("There was a lesion in his chest where he'd clearly been\r\nstabbed by somethin' sharp right in the heart!",
                              "Il y avait une entaille dans sa poitrine : quelqu'un lui a planté\r\nun objet pointu en plein cœur !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#8
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#8"] = en => {
                string s = en;
                s = s.Replace("So the victim was killed before he went anywhere.\r\nAnd this fella's the only one who could have done it!",
                              "La victime a donc été tuée avant d'être téléportée.\r\nEt ce zozo est le seul qui ait pu commettre le forfait !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#9
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#9"] = en => {
                string s = en;
                s = s.Replace("The weapon the victim was stabbed with must have been\r\nleft in his body whilst he was beamed through the air!",
                              "L'arme avec laquelle on l'a frappé a dû rester fichée dans\r\nson corps pendant qu'il volait dans les airs !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#10
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#10"] = en => {
                string s = en;
                s = s.Replace("Are you suggesting <E049><E003 5><E145 1 0><E149 1 0 8><E118 1 1.25><E003 8><E025 2>that's because he fell from a\r\nconsiderable height?",
                              "Voulez-vous insinuer <E049><E003 5><E145 1 0><E149 1 0 8><E118 1 1.25><E003 8><E025 2>que c'est en raison de sa chute\r\nd'une hauteur considérable ?");
                s = s.Replace("Exactly.<E049><E003 10> <E025 2>Which highlights somethin' else about this whole\r\nrum business.",
                              "Exactement.<E049><E003 10> <E025 2>Ce qui met en lumière un autre détail de cette curieuse histoire.");
                s = s.Replace("What's that?", "Lequel ?");
                s = s.Replace("The fact that the instantaneous kinesis itself <E049><E003 10><E333>was <E006>a\r\nsuccess<E005>.",
                              "Le fait que la cinèse instantanée elle-même <E049><E003 10><E333>fût <E006>un succès<E005>.");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("After the explosion, <E049><E003 6><E025 2>the cage with the fella inside<E049><E003 2>\r\n<E145 7 74><E003 11>suddenly appeared out of nowhere in mid-air.",
                              "Après l'explosion, <E049><E003 6><E025 2>la cage contenant la victime<E049><E003 2>\r\n<E145 7 74><E003 11>est apparue comme par magie dans les airs.");
                s = s.Replace("So although the experiment ended in disaster, <E049><E003 8><E145 15 7>the\r\nso-called instantaneous kinesis did actually occur.",
                              "Ainsi, bien que l'expérience se soit soldée par un désastre, <E049><E003 8><E145 15 7>la\r\nprétendue cinèse instantanée a bel et bien eu lieu.");
                s = s.Replace("...Remind us, <E003 6>Professor, <E049><E003 8><E145 6 3><E118 6 0.6><E003 8><E025 2>what was the cause of the fatal\r\ndisaster?",
                              "...Rappelez-nous, <E003 6>Docteur, <E049><E003 8><E145 6 3><E118 6 0.6><E003 8><E025 2>quelle fut la cause de ce fatal\r\ndésastre ?");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#11
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#11"] = en => {
                string s = en;
                s = s.Replace("So the angle of projection is critical, <E003 4>is it?<E049><E003 10>\r\nAnd you calculated it yourself?<E049><E003 8> Personally?",
                              "L'angle de projection est donc crucial, <E003 4>n'est-ce pas ?<E049><E003 10>\r\nEt vous l'avez calculé vous-même ?<E049><E003 8> Personnellement ?");
                s = s.Replace("Absolutely!<E049><E003 16><E332> The calculation is far too complicated for\r\nanyone but me to carry out!",
                              "Absolument !<E049><E003 16><E332> Ce calcul est bien trop complexe pour\r\nêtre confié à qui que ce soit d'autre !");
                s = s.Replace("Only, <E049><E003 12><E330>you got it wrong, <E003 6>didn't you?",
                              "Sauf que, <E049><E003 12><E330>vous vous êtes trompé, <E003 6>n'est-ce pas ?");
                s = s.Replace("Yes!<E049><E003 10> That's right!<E049><E003 10> That's the point!<E049><E003 10> The calculation is so\r\ncomplicated, <E003 8>even I can make a mistake!",
                              "Oui !<E049><E003 10> Tout à fait !<E049><E003 10> C'est là toute la nuance !<E049><E003 10> Le calcul est si\r\nardu que même moi je puis faillir !");
                s = s.Replace("(Do people fall for that brazen confidence?<E003 12>\r\n<E025 3><E341>...I should try it.)",
                              "(Les gens se laissent-ils berner par un tel aplomb ?<E003 12>\r\n<E025 3><E341>... Il faudra que j'essaie un jour.)");
                s = s.Replace("I, <E049><E003 6>I took into account the subject's height and weight,<E049><E003 8>\r\nthe wind direction, <E049><E003 8>the ambient temperature<E025 7>...",
                              "J'ai pris en compte la taille et le poids du cobaye,<E049><E003 8>\r\nla direction du vent, <E049><E003 8>la température ambiante<E025 7>...");
                s = s.Replace("I considered every possible variable!<E049><E003 10> <E145 68 72><E117 68 8><E086 5 31><E341><E025 2>So I just don't\r\nunderstand <E049><E003 6><E025 1><E164 68 70 1 2 5 0 2 1><E139 68>how this could have happened!",
                              "J'ai envisagé chaque variable concevable !<E049><E003 10> <E145 68 72><E117 68 8><E086 5 31><E341><E025 2>Alors je ne\r\ncomprends pas <E049><E003 6><E025 1><E164 68 70 1 2 5 0 2 1><E139 68>comment cela a pu arriver !");
                s = s.Replace("Obviously then, <E049><E003 8><E330>you had to include the weight of the\r\nclothes Mr Asman was wearing at the time, I suppose?",
                              "De toute évidence, <E049><E003 8><E330>vous avez inclus le poids des\r\nvêtements que Mr Asman portait à ce moment, j'imagine ?");
                s = s.Replace("Crackling comets!<E049><E003 20>\r\n<E164 68 71 1 2 9 0 3 1><E139 68>The answer should have been <E006>three<E005>!",
                              "Par toutes les comètes !<E049><E003 20>\r\n<E164 68 71 1 2 9 0 3 1><E139 68>Le résultat aurait dû être <E006>trois<E005> !");
                s = s.Replace("(So much for safety first.<E003 12>\r\nThe three must be for safety third...)",
                              "(Adieu la sécurité d'abord.<E003 12>\r\nLe trois devait être pour la sécurité en troisième plan...)");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#12
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#12"] = en => {
                string s = en;
                s = s.Replace("Another fatal injury, <E003 8>you say?<E049><E003 12>\r\n<E025 1><E145 1 17><E139 1>That doesn't make any sense!",
                              "Une autre blessure mortelle, <E003 8>dites-vous ?<E049><E003 12>\r\n<E025 1><E145 1 17><E139 1>Ça n'a aucun sens !");
                s = s.Replace("I didn't think I'd have to spell this out, <E049><E003 6>but here we go...",
                              "Je ne pensais pas devoir vous faire un dessin, <E049><E003 6>mais allons-y...");
                s = s.Replace("Just because there were two fatal wounds <E049><E003 8><E333>doesn't mean\r\nI'm sayin' the victim had two lives to lose, <E049><E003 8>does it?",
                              "Deux blessures mortelles <E049><E003 8><E333>ne signifient pas que la victime\r\navait deux vies à perdre, <E049><E003 8>que je sache ?");
                s = s.Replace("...Too right.", "...C'est certain.");
                s = s.Replace("Obviously at first, <E049><E003 8>we thought the bloke had died due to\r\nhis spine snappin' in half as well.",
                              "Bien sûr, au début, <E049><E003 8>on croyait que le bonhomme était mort\r\ndu bris de sa colonne vertébrale.");
                s = s.Replace("But you're saying that's not the case?!",
                              "Mais vous affirmez que ce n'est pas le cas ?!");
                s = s.Replace("You'll get your answer once I've finished my fish an'\r\nchips...<E049><E003 10>if you don't keep buttin' in every few seconds!",
                              "Vous aurez votre réponse quand j'aurai fini mon fish and\r\nchips...<E049><E003 10> si vous arrêtez de m'interrompre toutes les deux secondes !");
                s = s.Replace("(But we all know <E003 8><E025 3><E330><E341>that's a bottomless bag<E025 7>...)",
                              "(Mais nous savons tous <E003 8><E025 3><E330><E341>que ce sachet est sans fond<E025 7>...)");
                s = s.Replace("The victim plummeted thirty feet into a glass tower.<E049><E003 6> <E025 3><E145 6 12><E118 6 1.3><E003 12>It\r\nwould be reasonable to assume that as the cause of death.",
                              "La victime a plongé de dix mètres dans une tour de verre.<E049><E003 6> <E025 3><E145 6 12><E118 6 1.3><E003 12>Il\r\nétait légitime d'y voir la cause de son trépas.");
                s = s.Replace("Right.<E049><E003 10> <E025 2>That's what we all thought.<E049><E003 10>\r\nBut it was a red herring, <E003 4>wasn't it?",
                              "Exact.<E049><E003 10> <E025 2>C'est ce qu'on croyait tous.<E049><E003 10>\r\nMais c'était un leurre, <E003 4>n'est-ce pas ?");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#13
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#13"] = en => {
                string s = en;
                s = s.Replace("The defence knew <E049><E003 4><E025 1><E164 1 71 1 2 1 0 1 1><E139 1>nothing of this crucial information!",
                              "La défense n'était <E049><E003 4><E025 1><E164 1 71 1 2 1 0 1 1><E139 1>nullement informée d'un tel fait !");
                s = s.Replace("The prosecution received this report from the Forensic\r\nInvestigation Team only this morning.",
                              "L'accusation n'a reçu ce rapport de la police scientifique\r\nque ce matin.");
                s = s.Replace("That was the first we knew of it as well.<E049><E003 10> <E025 2>I can only\r\napologise for the impossibility of informing the defence.",
                              "Nous n'en savions rien nous-mêmes.<E049><E003 10> <E025 2>Je ne peux que\r\nregretter l'impossibilité d'en avertir mon confrère.");
                s = s.Replace("(Sarcastic <E003 8>AND <E003 8>insincere?<E003 12> <E025 5>Thanks...)",
                              "(Sarcastique <E003 8>ET <E003 8>hypocrite ?<E003 12> <E025 5>Merci bien...)");
                s = s.Replace("So, <E049><E003 8><E025 2>what was the nature of this sharp object?",
                              "Alors, <E049><E003 8><E025 2>quelle était la nature de cet objet pointu ?");
                s = s.Replace("Among the accused's tools that were in use at the\r\ndemonstration, <E049><E003 8>one is of particular interest.",
                              "Parmi les outils de l'accusé employés lors de la démonstration,<E049><E003 8> l'un retient particulièrement l'attention.");
                s = s.Replace("This.", "Ceci.");
                s = s.Replace("Ah yes, <E049><E003 8><E145 15 5><E025 2>that would appear to be some kind of\r\nscrewdriver, <E049><E003 6>wouldn't it, <E003 4>Couns–",
                              "Ah oui, <E049><E003 8><E145 15 5><E025 2>cela ressemble à une sorte de tournevis,\r\n<E049><E003 6>n'est-ce pas, <E003 4>Maît–");
                s = s.Replace("AHAHAHAHAAAAAAAAAH!<E049><E003 25><E086 5 31><E145 68 65><E117 68 8>\r\n<E025 3><E342>There <E003 8><E025 2><E341>he <E003 8><E025 1><E341>is!",
                              "AHAHAHAHAAAAAAAAAH !<E049><E003 25><E086 5 31><E145 68 65><E117 68 8>\r\n<E025 3><E342>Le <E003 8><E025 2><E341>voilà <E003 8><E025 1><E341>enfin !");
                s = s.Replace("AHAHAHAHAAAAAAAAAH!<E049><E003 20><E086 5 31><E145 68 65><E117 68 8>\r\n<E025 3><E342>There <E003 8><E025 2><E341>he is!",
                              "AHAHAHAHAAAAAAAAAH !<E049><E003 20><E086 5 31><E145 68 65><E117 68 8>\r\n<E025 3><E342>Le <E003 8><E025 2><E341>voilà !");
                s = s.Replace("My trusty little companion, <E003 10><E086 5 31><E164 68 71 1 2 5 0 2 1><E139 68><E025 1><E006>Andrew<E005>!",
                              "Mon fidèle compagnon, <E003 10><E086 5 31><E164 68 71 1 2 5 0 2 1><E139 68><E025 1><E006>Andrew<E005> !");
                s = s.Replace("Andrew.<E049><E003 10> Of course.", "Andrew.<E049><E003 10> Évidemment.");
                s = s.Replace("Ah, <E003 8><E025 2>do you know each other already?<E003 10> He's one of my\r\ndear friends<E169 68 2>...<E003 10><E169 68 3><E025 1>like all my tools!",
                              "Ah, <E003 8><E025 2>vous connaissez-vous déjà ?<E003 10> C'est l'un de mes\r\nchers amis<E169 68 2>...<E003 10><E169 68 3><E025 1> tout comme chacun de mes outils !");
                s = s.Replace("I've named them all, you know.<E003 10> We're one big, <E003 6><E025 1>happy\r\nfamily!",
                              "Je leur ai tous donné un prénom.<E003 10> Nous formons une grande famille <E003 6><E025 1>heureuse !");
                s = s.Replace("Andrew is my flat-head screwdriver, <E003 4>of course.<E049><E003 6>\r\n<E025 1><E164 68 71 1 2 6 0 1 1><E139 68>His brother, Michael, <E003 6>is a cross-head.",
                              "Andrew est mon tournevis plat, <E003 4>évidemment.<E049><E003 6>\r\n<E025 1><E164 68 71 1 2 6 0 1 1><E139 68>Son frère, Michael, <E003 6>est un cruciforme.");
                s = s.Replace("Well, <E049><E003 8><E025 2><E145 15 2>it would appear that your beloved ‘Andrew’<E049><E003 8> <E025 3><E330>has <E006>a\r\nred stain<E005> on his shank.",
                              "Eh bien, <E049><E003 8><E025 2><E145 15 2>il semblerait que votre cher « Andrew »<E049><E003 8> <E025 3><E330>porte <E006>une\r\ntache rouge<E005> sur sa tige.");
                s = s.Replace("Ah!<E049><E003 14> <E025 2>That, <E049><E003 8>that isn't...?",
                              "Ah !<E049><E003 14> <E025 2>Ce, <E049><E003 8>ce n'est tout de même pas... ?");
                s = s.Replace("It's <E006>blood<E005>, <E049><E003 10><E060 0 74 0 0>beyond all reasonable doubt.",
                              "C'est du <E006>sang<E005>, <E049><E003 10><E060 0 74 0 0>sans l'ombre d'un doute.");
                s = s.Replace("No!", "Non !");
                s = s.Replace("And that's not all.", "Et ce n'est pas tout.");
                s = s.Replace("The long, <E003 4>sharp shape of this Andrew fellow<E049><E003 6><E145 7 76><E003 10><E333> is completely\r\nconsistent with the victim's wound.",
                              "La forme longue et affûtée de ce sieur Andrew<E049><E003 6><E145 7 76><E003 10><E333> correspond en tous points\r\nà la plaie de la victime.");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#14
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#14"] = en => {
                string s = en;
                s = s.Replace("Wha...<E003 12>\r\n<E025 1><E164 68 71 1 2 2 0 3 1><E139 68>WHAAAAAAAAAAAAAAAT?!",
                              "Quoi...<E003 12>\r\n<E025 1><E164 68 71 1 2 2 0 3 1><E139 68>QUOOOOOOOOOOOOOOOOOI ?!");
                s = s.Replace("Ordaaar!<E003 8> Ordaaar!", "Silence !<E003 8> Silence !");
                s = s.Replace("The court will enter this <E049><E003 6><E145 15 5><E338><E341>‘friend’<E049><E003 8> of the defendant as\r\nevidence!",
                              "Le tribunal verse cet « ami » du prévenu aux pièces à conviction !");
                s = s.Replace("The screwdriver has been\r\nentered into the Court Record.",
                              "Le tournevis a été ajouté au dossier.");
                s = s.Replace("(So one of Professor Harebrayne's tools is the murder\r\nweapon...?)",
                              "(L'un des outils du Dr Samba Lonron serait l'arme du crime... ?)");
                s = s.Replace("(Great...)", "(Merveilleux...)");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#15
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#15"] = en => {
                string s = en;
                s = s.Replace("What grounds do you have for saying that?",
                              "Sur quoi vous basez-vous pour affirmer cela ?");
                s = s.Replace("Hah!<E049><E003 14> <E025 2>D'you really need to ask?",
                              "Ha !<E049><E003 14> <E025 2>Faut-il vraiment le demander ?");
                s = s.Replace("There were only two people on that public\r\nexperimentation stage, <E049><E003 6>in front of the whole crowd.",
                              "Il n'y avait que deux personnes sur cette estrade devant toute la foule.");
                s = s.Replace("The victim, <E049><E003 8>Mr Odie Asman, <E049><E003 10>and the accused,<E049><E003 8> Professor\r\nHarebrayne.",
                              "La victime, <E049><E003 8>Mr Odie Asman, <E049><E003 10>et l'accusé,<E049><E003 8> le Dr\r\nSamba Lonron.");
                s = s.Replace("And we know for certain that before the experiment,<E049><E003 10><E025 3> the\r\nvictim was <E006>alive<E005>.",
                              "Et nous savons de source sûre qu'avant l'expérience,<E049><E003 10><E025 3> la\r\nvictime était <E006>bien vivante<E005>.");
                s = s.Replace("That's right.<E049><E003 12> <E025 1>I saw him with my own eyes!",
                              "C'est vrai.<E049><E003 12> <E025 1>Je l'ai vu de mes propres yeux !");
                s = s.Replace("Furthermore...", "De plus...");
                s = s.Replace("...following the explosion and ‘kinesis’, <E049><E003 10><E145 6 2><E330><E025 3>nobody went\r\nanywhere near the body.",
                              "...après l'explosion et la téléportation, <E049><E003 10><E145 6 2><E330><E025 3>personne ne s'est approché du corps.");
                s = s.Replace("In other words, <E049><E003 8>only someone else on stage with the\r\nvictim could possibly have done it.",
                              "En d'autres termes, <E049><E003 8>seule une personne présente sur l'estrade avec la victime a pu porter le coup.");
                s = s.Replace("And Albert Harebrayne is the only bloke who fits the bill.",
                              "Et Samba Lonron est le seul candidat possible.");
                s = s.Replace("Unless you've got some other bright idea, sunshine?<E049><E003 12>\r\n<E025 2>In which case, <E049><E003 10><E025 1><E341>let's hear it!",
                              "À moins que vous n'ayez une autre idée lumineuse, mon garçon ?<E049><E003 12>\r\n<E025 2>Auquel cas, <E049><E003 10><E025 1><E341>nous vous écoutons !");
                s = s.Replace("My learned friend's silence is your answer, <E049><E003 8>Inspector.",
                              "Le silence de mon confrère vous sert de réponse, <E049><E003 8>Inspecteur.");
                s = s.Replace("Ugh...<E003 10>\r\n<E025 3><E007>(Can't a man have a moment to think?)",
                              "Ugh...<E003 10>\r\n<E025 3><E007>(Ne peut-on pas me laisser le temps de réfléchir ?)");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#16
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#16"] = en => {
                string s = en;
                s = s.Replace("Why would you think that, <E049><E003 6>Inspector?",
                              "Pourquoi pensez-vous cela, <E049><E003 6>Inspecteur ?");
                s = s.Replace("With any wound, <E049><E003 8>it's only when you pull the weapon out\r\nthat profuse bleedin' occurs.",
                              "Avec n'importe quelle plaie, <E049><E003 8>c'est seulement en retirant l'arme\r\nqu'une hémorragie massive se déclenche.");
                s = s.Replace("Whilst it's still lodged in the body, <E049><E003 8><E330>it acts as a stopper of\r\nsorts, <E049><E003 6>for want of a better word.",
                              "Tant qu'elle reste logée dans les chairs, <E049><E003 8><E330>elle fait office de bouchon.");
                s = s.Replace("I, <E003 8><E025 2>I see...", "J-Je <E003 8><E025 2>vois...");
                s = s.Replace("You don't need a medical degree to be aware of this fact.<E049><E003 10>\r\n<E239><E025 2>It's <E006>common knowledge<E005> for any investigator.",
                              "Nul besoin d'un diplôme de médecine pour savoir cela.<E049><E003 10>\r\n<E239><E025 2>C'est une <E006>notion élémentaire<E005> pour tout enquêteur.");
                s = s.Replace("(Ugh, <E003 10><E025 3>where's Susato-san when you need her?)",
                              "(Ugh, <E003 10><E025 3>où est Susato-san quand on a besoin d'elle ?)");
                s = s.Replace("If you ask me, <E003 6>this bloke masked what he was doin' from\r\nview with his body before stabbin' Asman in the chest.",
                              "Si vous voulez mon avis, <E003 6>ce type a masqué son geste aux regards\r\navec son corps avant de frapper Asman en pleine poitrine.");
                s = s.Replace("Then he beamed the victim off the stage with his fancy\r\ndevice, <E049><E003 6>the screwdriver still where he planted it.",
                              "Puis il a téléporté la victime hors de l'estrade avec sa machine,\r\n<E049><E003 6>le tournevis toujours planté là où il l'avait enfoncé.");
                s = s.Replace("I, <E003 8><E025 1><E164 68 78 1 2 1 0 2 1><E171 68 25 1 9 1><E139 68>I would never do such a thing!<E049><E003 12> Not to my precious tools!<E049><E003 14>\r\n<E086 5 31><E342><E145 68 70><E117 68 8><E003 8><E606>I would never use them for such <E006>dirty work<E005>!",
                              "J-Je <E003 8><E025 1><E164 68 78 1 2 1 0 2 1><E171 68 25 1 9 1><E139 68>ne ferais jamais une chose pareille !<E049><E003 12> Pas à mes précieux outils !<E049><E003 14>\r\n<E086 5 31><E342><E145 68 70><E117 68 8><E003 8><E606>Je ne les utiliserais jamais pour une <E006>sale besogne<E005> !");
                s = s.Replace("You only use tools for their intended purpose!<E049><E003 8>\r\n<E025 1><E086 5 31><E145 68 77><E117 68 8><E003 10>That's <E006>common knowledge<E005> <E049><E003 6><E164 68 66 1 2 8 0 1 1><E139 68>for any scientist!",
                              "On n'utilise des outils que pour leur usage prévu !<E049><E003 8>\r\n<E025 1><E086 5 31><E145 68 77><E117 68 8><E003 10>C'est une <E006>règle fondamentale<E005> <E049><E003 6><E164 68 66 1 2 8 0 1 1><E139 68>pour tout homme de science !");
                s = s.Replace("...The fact remains, <E049><E003 10><E025 2><E145 6 4>the lack of blood at the scene can\r\neasily be explained.<E003 8> As the prosecution has demonstrated.",
                              "...Le fait demeure, <E049><E003 10><E025 2><E145 6 4>l'absence de sang sur place\r\ns'explique aisément.<E003 8> Comme l'accusation vient de le prouver.");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#17
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#17"] = en => {
                string s = en;
                s = s.Replace("Professor Harebrayne!<E049><E003 10> <E025 2>Do you have some information\r\nthat may be relevant here?",
                              "Dr Samba Lonron !<E049><E003 10> <E025 2>Auriez-vous une précision utile\r\nà apporter à la cour ?");
                s = s.Replace("Professor!", "Docteur !");
                s = s.Replace("Ah!<E049><E003 12> Sorry!<E049><E003 12> SORRY!", "Ah !<E049><E003 12> Pardon !<E049><E003 12> PARDON !");
                s = s.Replace("I was just calculating the optimum coefficient of\r\nelectrolysis to separate molecules in the human body...",
                              "J'étais en train de calculer le coefficient optimal d'électrolyse pour séparer les molécules du corps humain...");
                s = s.Replace("(And the witness stand is <E003 8><E238>the best place for that?)",
                              "(Et la barre des témoins est <E003 8><E238>l'endroit idéal pour cela ?)");
                s = s.Replace("It seemed as though you might have something to say?",
                              "Il semblait que vous aviez quelque chose à ajouter ?");
                s = s.Replace("About Inspector Gregson's last remark.", "À propos de la dernière remarque de l'inspecteur Gregson.");
                s = s.Replace("Ah!<E003 12>\r\n<E025 4><E342>AHAHAHAAAAAAAAAAAA<E025 5>AAAAAAAAA<E342>AAAAAAAAA<E024><PAGE>\r\n<E800 1056><E145 68 73><E118 68 1.7><E800 1059><E041 68 68><E025 1><E345>AAAAAAAAAH!<E003 2><E164 68 71 1 2 5 0 3 1><E139 68>\r\nYes!<E049><E003 12> Yes, <E049><E003 10>that's right!<E049><E003 12> <E335>Of course!",
                              "Ah !<E003 12>\r\n<E025 4><E342>AHAHAHAAAAAAAAAAAA<E025 5>AAAAAAAAA<E342>AAAAAAAAA<E024><PAGE>\r\n<E800 1056><E145 68 73><E118 68 1.7><E800 1059><E041 68 68><E025 1><E345>AAAAAAAAAH !<E003 2><E164 68 71 1 2 5 0 3 1><E139 68>\r\nOui !<E049><E003 12> Oui, <E049><E003 10>c'est exact !<E049><E003 12> <E335>Mais bien sûr !");
                s = s.Replace("He just said that nobody else could have done it,<E049><E003 6> didn't he?",
                              "Il vient de dire que personne d'autre n'aurait pu le faire,<E049><E003 6> n'est-ce pas ?");
                s = s.Replace("Yeah, that's right.<E049><E003 10> Who else could have stabbed the victim,\r\n<E003 6>eh?",
                              "Ouais, c'est bien ça.<E049><E003 10> Qui d'autre aurait pu frapper la victime,\r\n<E003 6>hein ?");
                s = s.Replace("I DON'T KNOW!<E049><E003 14>\r\n<E025 3>...But!",
                              "JE N'EN SAIS RIEN !<E049><E003 14>\r\n<E025 3>... Mais !");
                s = s.Replace("There's no way that I could possibly have stabbed\r\nMr Asman as you say.",
                              "Il m'était totalement impossible de poignarder Mr Asman comme vous le prétendez.");
                s = s.Replace("Eh?", "Plaît-il ?");
                s = s.Replace("Explain, please, <E049><E003 10><E025 1><E341><E338>Professor!",
                              "Expliquez-vous, je vous en prie, <E049><E003 10><E025 1><E341><E338>Docteur !");
                s = s.Replace("Of course.<E049><E003 12> <E025 2>This cold-hearted policeman may not be\r\naware, <E049><E003 6>I suppose...",
                              "Bien volontiers.<E049><E003 12> <E025 2>Cet homme de loi au cœur de pierre l'ignore\r\npeut-être, <E049><E003 6>j'imagine...");
                s = s.Replace("...but humans are warm-blooded mammals, <E003 5>with blood\r\nrunning continuously through their veins.",
                              "... mais l'être humain est un mammifère homéotherme, <E003 5>avec du sang\r\ncirculant sans arrêt dans ses vaisseaux.");
                s = s.Replace("I had heard...", "On m'a laissé entendre...");
                s = s.Replace("Then surely you see!", "Alors vous devez comprendre !");
                s = s.Replace("If I'd plunged something the size of Andrew into the man's\r\nchest...",
                              "Si j'avais enfoncé un outil de la taille d'Andrew dans son thorax...");
                s = s.Replace("...the whole stage would have been a bloodbath!<E049><E003 12>\r\n<E025 3>No, <E049><E003 8><E025 1><E164 68 71 1 2 5 0 2 1><E139 68><E006>a blood swimming pool<E005>!",
                              "... toute l'estrade aurait été un bain de sang !<E049><E003 12>\r\n<E025 3>Que dis-je, <E049><E003 8><E025 1><E164 68 71 1 2 5 0 2 1><E139 68><E006>une véritable piscine d'hémoglobine<E005> !");
                s = s.Replace("Aah...<E003 15>", "Aah...<E003 15>");
                s = s.Replace("But thousands of Londoners were watching me at the\r\ntime.",
                              "Or des milliers de Londoniens me regardaient à ce moment précis.");
                s = s.Replace("And yet not one of them claims to have seen<E049><E003 5><E025 1><E164 68 78 1 2 9 0 3 1><E139 68> <E006>a swimming\r\npool of blood<E005>!",
                              "Et pourtant, pas un seul n'affirme avoir vu <E049><E003 5><E025 1><E164 68 78 1 2 9 0 3 1><E139 68><E006>une piscine\r\nde sang<E005> !");
                s = s.Replace("Well, <E049><E003 8>no...<E049><E003 8><E025 3>I suppose not...",
                              "Euh, <E049><E003 8>non...<E049><E003 8><E025 3> j'imagine que non...");
                s = s.Replace("You see?!<E003 12> Not one!", "Vous voyez ?!<E003 12> Pas un seul !");
                s = s.Replace("True, <E049><E003 8><E025 2>I didn't see anything like that...",
                              "C'est vrai, <E049><E003 8><E025 2>je n'ai rien vu de tel...");
                s = s.Replace("(Well done, Professor!<E003 12>\r\n<E346><E025 1>That was a great counter-argument!)",
                              "(Bien joué, Docteur !<E003 12>\r\n<E346><E025 1>Voilà un contre-argument magistral !)");
                s = s.Replace("...Pray forgive the discourtesy <E049><E003 8><E025 2>if I savour a drop from my\r\nhallowed chalice to accompany my old friend's adducing.",
                              "...Pardonnez ma discourtoisie <E049><E003 8><E025 2>si je savoure une goutte de mon\r\nsaint calice pour saluer la démonstration de mon vieil ami.");
                s = s.Replace("Here's to you, <E049><E003 10><E025 2>Albert!", "À ta santé, <E049><E003 10><E025 2>Albert !");
                s = s.Replace("Oh,<E049><E003 10> <E025 2>you're too kind, Barok!<E049><E003 12>\r\n<E025 2>But I'm really not a patch on you...",
                              "Oh, <E049><E003 10><E025 2>tu es trop aimable, Drake !<E049><E003 12>\r\n<E025 2>Mais je ne t'arrive pas à la cheville...");
                s = s.Replace("No, <E049><E003 12><E330><E025 3>you're not.", "Non, <E049><E003 12><E330><E025 3>en effet.");
                s = s.Replace("No?", "Non ?");
                s = s.Replace("You've neglected to mention one crucial possibility.",
                              "Tu as omis de mentionner une éventualité cruciale.");
                s = s.Replace("I have?", "Vraiment ?");
                s = s.Replace("A particular situation <E049><E003 8><E025 2><E145 6 3><E144 6><E330>in which very little bleeding would\r\nresult from a stab wound.",
                              "Une circonstance particulière <E049><E003 8><E025 2><E145 6 3><E144 6><E330>où une plaie pénétrante\r\nne provoque qu'un très faible épanchement sanguin.");
                s = s.Replace("Of course!", "Bien sûr !");
                s = s.Replace("Inspector, <E049><E003 8>enlighten the court, please.",
                              "Inspecteur, <E049><E003 8>éclairez la cour, je vous prie.");
                s = s.Replace("(Where are they going with this?)", "(Où veulent-ils en venir ?)");
                s = s.Replace("Very well.<E049><E003 10> <E025 2><E341>You will amend your formal testimony now,<E049><E003 8>\r\nInspector Gregson.",
                              "Très bien.<E049><E003 10> <E025 2><E341>Veuillez modifier votre déposition officielle,<E049><E003 8>\r\nInspecteur Gregson.");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#18
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#18"] = en => {
                string s = en;
                s = s.Replace("Professor Harebrayne!<E049><E003 12>\r\n<E025 2>Are you hiding something from the court?",
                              "Dr Samba Lonron !<E049><E003 12>\r\n<E025 2>Dissimulez-vous quelque chose à la cour ?");
                s = s.Replace("Ah ha!<E003 16> It's four!", "Ah ha !<E003 16> C'est quatre !");
                s = s.Replace("AAAAAAAAAH!", "AAAAAAAAAH !");
                s = s.Replace("Um, <E049><E003 10><E330>what was that?", "Euh, <E049><E003 10><E330>qu'était-ce donc ?");
                s = s.Replace("I was calculating the neutralisation coefficient of electrical\r\ncharge required for electrolysis of a human subject.",
                              "Je calculais le coefficient de neutralisation de charge électrique nécessaire à l'électrolyse d'un corps humain.");
                s = s.Replace("I have to keep the result a secret at all costs, <E003 4>you see.<E049><E003 12>\r\nThat's why I ate the paper I did my working on.",
                              "Je dois impérativement garder ce résultat secret.<E049><E003 12>\r\nVoilà pourquoi j'ai avalé mon papier de brouillon.");
                s = s.Replace("But now I've completely forgotten the number!<E049><E003 12>\r\nDear me, <E049><E003 10>I am a scatterbrain sometimes!",
                              "Mais à présent j'ai complètement oublié le chiffre !<E049><E003 12>\r\nGrand Dieu, <E049><E003 10>quelle tête de linotte je fais parfois !");
                s = s.Replace("Well<E025 7>...<E003 10><E025 2>moments before you ate the paper, <E049><E003 8><E238>you did yell out\r\nthe number four...",
                              "Eh bien<E025 7>... <E003 10><E025 2>quelques secondes avant de manger le papier, <E049><E003 8><E238>vous avez crié le chiffre quatre...");
                s = s.Replace("NOOOOOO!<E049><E003 12> <E025 1><E341>You, <E003 10>you know it?<E049><E003 12>\r\n<E164 68 71 1 2 9 0 2 1><E139 68>You know my secret coefficient!",
                              "NOOOOOON !<E049><E003 12> <E025 1><E341>Vous... <E003 10>vous le savez ?<E049><E003 12>\r\n<E164 68 71 1 2 9 0 2 1><E139 68>Vous connaissez mon coefficient secret !");
                s = s.Replace("Oh dear!<E003 10> Oh no!<E003 10> This is bad!<E003 12> <E025 4>Oh my goodness<E025 7>...",
                              "Miséricorde !<E003 10> Oh non !<E003 10> C'est une catastrophe !<E003 12> <E025 4>Ciel tout-puissant<E025 7>...");
                s = s.Replace("Perhaps<E025 7>...<E049><E003 10><E025 3>you could just focus on the testimony?",
                              "Peut-être<E025 7>... <E049><E003 10><E025 3>pourriez-vous simplement vous concentrer sur la déposition ?");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#19
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#19"] = en => {
                string s = en;
                s = s.Replace("Inspector!<E049><E003 12>\r\n<E025 2>Did you have something to add?",
                              "Inspecteur !<E049><E003 12>\r\n<E025 2>Aviez-vous quelque chose à ajouter ?");
                s = s.Replace("Didn't that last statement set off a train of thought in your\r\nmind?",
                              "Cette dernière déclaration n'a-t-elle pas suscité une réflexion en vous ?");
                s = s.Replace("Well<E025 7>...<E003 8><E025 2>I was ponderin' somethin' that pops into my head\r\nfrom time to time, <E003 4>yes.",
                              "Eh bien<E025 7>... <E003 8><E025 2>je songeais à un truc qui me traverse l'esprit de temps en temps, oui.");
                s = s.Replace("I was thinkin' that there probably are one or two things in\r\nlife more important than a bag o' fish an' chips.",
                              "Je me disais qu'il y a sans doute une ou deux choses dans la vie plus importantes qu'un paquet de fish and chips.");
                s = s.Replace("...Sorry?", "... Pardon ?");
                s = s.Replace("But you can't deny they're bloomin' useful when you feel\r\nlike bitin' someone's head off!",
                              "Mais avouez que c'est rudement pratique quand on a envie d'arracher la tête de quelqu'un !");
                s = s.Replace("(‘No, <E003 6>nothing to add’ <E003 6>would probably have sufficed.)",
                              "(Un simple « Non, <E003 6>rien à ajouter » <E003 6>aurait suffi.)");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#25
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#25"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, <E049><E003 8><E025 2>that will do.",
                              "Merci, Maître, <E049><E003 8><E025 2>cela suffira.");
                s = s.Replace("But,<E049><E003 8> <E025 1><E164 1 71 1 2 1 0 1 1><E139 1>but, My Lord,<E049><E003 12> wait!<E049><E003 14> The defence is still in the process\r\nof establishing its argument...",
                              "Mais, <E049><E003 8><E025 1><E164 1 71 1 2 1 0 1 1><E139 1>mais Votre Honneur,<E049><E003 12> attendez !<E049><E003 14> La défense est encore en train\r\nd'étayer son argumentation...");
                s = s.Replace("No further analysis is necessary,<E003 6> I feel.",
                              "Aucune analyse supplémentaire n'est nécessaire, selon moi.");
                s = s.Replace("As such,<E003 8> I shall be requesting the final decisions of the\r\nmembers of the jury.",
                              "En conséquence,<E003 8> je demande le verdict final des membres du jury.");
                s = s.Replace("It's been an honour to serve,<E003 4> My Lord.<E049><E003 10>\r\nAnd we know exactly what we think now.",
                              "Ce fut un honneur de siéger,<E003 4> Votre Honneur.<E049><E003 10>\r\nEt notre opinion est désormais faite.");
                s = s.Replace("Guilty!", "Coupable !");
                s = s.Replace("Mr Albert Harebrayne,<E049><E003 8> in accordance with the findings of\r\nthis court,<E049><E003 8> I pronounce you...",
                              "Dr Samba Lonron,<E049><E003 8> conformément aux délibérations de ce tribunal,<E049><E003 8> je vous déclare...");
                s = s.Replace("I applaud the jurors for doing their civic duty<E003 4> and for\r\nfinding a swift resolution to this matter.",
                              "Je félicite les jurés d'avoir accompli leur devoir civique<E003 4> et permis\r\nun dénouement prompt à cette affaire.");
                s = s.Replace("That is all.<E049><E003 8> <E025 2><E145 15 5><E144 15>Court is adjourned!",
                              "La séance est levée !");
                return s;
            };

            // BB\script\output\_sce02_c101_0030_eng#27
            entryTranslators["BB\\script\\output\\_sce02_c101_0030_eng#27"] = en => {
                string s = en;
                s = s.Replace("(So that's all the testimony I have to work with...)",
                              "(C'est donc tout ce que j'ai pour travailler...)");
                s = s.Replace("(I had no idea the victim had been <E006>stabbed<E007>.<E003 10>\r\n<E025 3><E145 1 85>That changes everything...)",
                              "(J'ignorais totalement que la victime avait été <E006>poignardée<E007>.<E003 10>\r\n<E025 3><E145 1 85>Cela change absolument tout...)");
                s = s.Replace("(Did van Zieks keep that to himself until now on purpose,<E003 8>\r\nto gain the advantage?)",
                              "(Van Peers a-t-il gardé cela secret jusqu'ici exprès,<E003 8> pour prendre l'avantage ?)");
                s = s.Replace("(Oh well...<E003 8><E025 2>I suppose all I can do is press these witnesses\r\nfor as much new information as possible.)",
                              "(Enfin bon... <E003 8><E025 2>il ne me reste plus qu'à presser ces témoins pour en tirer un maximum d'informations.)");
                return s;
            };

            // BB\script\output\_sce02_c101_0040_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c101_0040_eng#2"] = en => {
                string s = en;
                s = s.Replace("You say that while the weapon remains in the body,<E049><E003 8>\r\n<E025 3>there's very little bleeding...",
                              "Vous affirmez que tant que l'arme demeure dans le corps,<E049><E003 8>\r\n<E025 3>il n'y a que peu d'hémorragie...");
                s = s.Replace("Is that unequivocal?", "En êtes-vous formel ?");
                s = s.Replace("Look, <E049><E003 8><E025 2>there was no blood on the experimentation stage,<E049><E003 8>\r\neven though that's where the fellow was stabbed.",
                              "Écoutez, <E049><E003 8><E025 2>il n'y avait pas de sang sur l'estrade d'expérience,<E049><E003 8>\r\nbien que ce soit là qu'il a été poignardé.");
                s = s.Replace("The only explanation for that is if the screwdriver was\r\nstill in his body, <E003 6>stoppin' any heavy bleedin'.",
                              "La seule explication possible est que le tournevis était encore dans son corps, empêchant toute effusion.");
                s = s.Replace("It's common medical knowledge, <E049><E025 2><E003 8>my learned friend.<E049><E003 12>\r\n<E025 3>Even on your side of the world.",
                              "C'est une évidence médicale, <E049><E025 2><E003 8>mon cher confrère.<E049><E003 12>\r\n<E025 3>Même de votre côté du globe.");
                s = s.Replace("Yes, <E049><E003 8><E060 0 74 1 0>but about this screwdriver...",
                              "Certes, <E049><E003 8><E060 0 74 1 0>mais à propos de ce tournevis...");
                s = s.Replace("The thing is, <E049><E003 8>we actually saw it at the scene ourselves.<E049><E003 10>\r\n<E330><E025 3>On the experimentation stage.",
                              "Le fait est que nous l'avons nous-mêmes vu sur les lieux.<E049><E003 10>\r\n<E330><E025 3>Sur l'estrade d'expérience.");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("It was on the floor by the wreckage of the machine,<E049><E003 8>\r\npoking through a metal grille.",
                              "Il gisait sur le sol près des débris de la machine,<E049><E003 8>\r\ncoincé à travers une grille métallique.");
                s = s.Replace("I went to pick it up, <E049><E003 6>but the detective here stopped me.",
                              "J'ai voulu le ramasser, <E049><E003 6>mais monsieur l'inspecteur ici présent m'en a empêché.");
                s = s.Replace("Isn't that right, <E049><E003 8><E025 2>Inspector Gregson?",
                              "N'est-ce pas exact, <E049><E003 8><E025 2>Inspecteur Gregson ?");
                s = s.Replace("Ah, <E049><E003 8>well, <E049><E003 8><E025 5><E169 7 0>um<E025 7>...<E003 10><E169 7 3> <E025 2>Now you come to mention it, <E049><E003 6>yes<E025 3>...",
                              "Ah, <E049><E003 8>eh bien, <E049><E003 8><E025 5><E169 7 0>euh<E025 7>...<E003 10><E169 7 3> <E025 2>maintenant que vous le dites, <E049><E003 6>oui<E025 3>...");
                s = s.Replace("Inspector, <E049><E003 10><E025 2>are we to understand that you permitted the\r\ndefence counsel to investigate?",
                              "Inspecteur, <E049><E003 10><E025 2>devons-nous comprendre que vous avez autorisé\r\nla défense à mener une enquête ?");
                s = s.Replace("That you contravened the Special Dispensation for\r\nScientific Equipment Act?",
                              "Que vous avez enfreint la Loi d'exemption sur les équipements scientifiques ?");
                s = s.Replace("Eh?<E049><E003 12> <E025 1>No!<E049><E003 12> Not at all!<E049><E003 14>\r\n<E338><E342><E025 1>I, <E003 8>I wouldn't do that!",
                              "Hein ?<E049><E003 12> <E025 1>Non !<E049><E003 12> Pas du tout !<E049><E003 14>\r\n<E338><E342><E025 1>M-Moi, <E003 8>je ne ferais jamais ça !");
                s = s.Replace("I just let him look, <E049><E003 10>nothin' more!<E049><E003 12>\r\n<E160 7><E025 1><E604>I was very clear he wasn't to touch a thing!",
                              "Je l'ai juste laissé regarder, rien de plus !<E049><E003 12>\r\n<E160 7><E025 1><E604>J'ai bien précisé qu'il n'avait le droit de toucher à rien !");
                s = s.Replace("Yes, <E049><E003 8><E025 2>that's true.", "Oui, <E049><E003 8><E025 2>c'est exact.");
                s = s.Replace("This screwdriver was in plain sight <E049><E003 8><E025 3><E330><E006>on the stage<E005>.",
                              "Ce tournevis était bien en évidence <E049><E003 8><E025 3><E330><E006>sur l'estrade<E005>.");
                s = s.Replace("But it shouldn't have been, <E049><E003 6><E025 3>should it?",
                              "Mais il n'aurait pas dû s'y trouver, <E049><E003 6><E025 3>n'est-ce pas ?");
                s = s.Replace("Wh-<E049><E003 10>What are you gettin' at?", "Où... <E049><E003 10>où voulez-vous en venir ?");
                s = s.Replace("If this tool had still been <E006>in the victim's body<E005> when the\r\nvictim was beamed away by the machine...",
                              "Si cet outil était encore <E006>dans le corps de la victime<E005> lorsque\r\nla machine l'a téléportée...");
                s = s.Replace("...then it shouldn't have still been on the stage.",
                              "... alors il n'aurait jamais dû rester sur l'estrade.");
                s = s.Replace("That's right!<E049><E003 12> <E025 2>It should have been beamed across to the\r\nCrystal Tower along with Mr Asman...",
                              "C'est cela même !<E049><E003 12> <E025 2>Il aurait dû être téléporté vers la\r\nTour de Cristal en même temps que Mr Asman...");
                s = s.Replace("...and been found <E006>still lodged<E005> in the victim's chest!",
                              "... et être retrouvé <E006>encore fiché<E005> dans son thorax !");
                s = s.Replace("UWAAAAAAAAAGH!", "OUAAAAAAAAAAAH !");
                return s;
            };

            // BB\script\output\_sce02_c101_0040_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c101_0040_eng#3"] = en => {
                string s = en;
                s = s.Replace("Ordaaar!<E003 8> Ordaaar!<E049><E003 14>\r\n<E025 2><E145 15 5>...How do you explain this, <E003 4>Inspector?",
                              "Silence !<E003 8> Silence !<E049><E003 14>\r\n<E025 2><E145 15 5>... Comment expliquez-vous cela, <E003 4>Inspecteur ?");
                s = s.Replace("I...<E049><E003 10>well...<E003 12><E169 7 0>um...<E003 8><E169 7 3>\r\n<E025 3>I don't...",
                              "Je... <E049><E003 10>eh bien... <E003 12><E169 7 0>euh...<E003 8><E169 7 3>\r\n<E025 3>je ne sais pas...");
                s = s.Replace("It looks as though everything that the victim had on his\r\nperson moved with him when he was ‘beamed’.",
                              "Il apparaît que tout ce que la victime portait sur elle\r\na été transporté au cours de la téléportation.");
                s = s.Replace("If the screwdriver was still in his chest when the\r\ninstantaneous kinesis occurred...",
                              "Si le tournevis était encore dans sa poitrine lors de la cinèse instantanée...");
                s = s.Replace("...obviously <E049><E003 10><E025 1><E346>that should have been beamed to the\r\ndestination as well!",
                              "... <E049><E003 10><E025 1><E346>il aurait dû lui aussi être téléporté jusqu'à destination !");
                s = s.Replace("You...", "Vous...");
                s = s.Replace("(This is a strange situation...)", "(C'est une situation bien étrange...)");
                s = s.Replace("(Even though people are saying that this instantaneous\r\nkinesis is a scientific impossibility...)",
                              "(Bien que tout le monde affirme que la cinèse instantanée est scientifiquement impossible...)");
                s = s.Replace("(...we're still basing arguments on the assumption that it\r\ndid actually take place.)",
                              "(... nous basons notre raisonnement sur le postulat qu'elle a réellement eu lieu.)");
                return s;
            };
        }
    }
}
