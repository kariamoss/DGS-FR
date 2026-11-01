using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct3 {
    public partial class Program {
        public static void RegisterPart3b() {
            // BB\script\output\_sce02_bg1300_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("<E025 3>It's<E025 7>...<E003 10><E341><E025 2>it's<E025 7>...<E023><PAGE>",
                              "<E025 3>C'est<E025 7>...<E003 10><E341><E025 2>c'est<E025 7>...<E023><PAGE>");
                s = s.Replace("...the great detective, <E003 6>Mr Herlock Sholmes!",
                              "... le grand détective, <E003 6>M. Herlock Sholmes !");
                s = s.Replace("(Mr Sholmes has his own wax statue in here?<E003 10>\r\n<E025 3>Really?)",
                              "(M. Sholmes a sa propre statue de cire ici ?<E003 10>\r\n<E025 3>Vraiment ?)");
                s = s.Replace("Well he is world-famous, after all!",
                              "Après tout, il est mondialement célèbre !");
                s = s.Replace("It's an uncanny resemblance, <E003 6>isn't it?<E003 10>\r\n<E025 3>It makes my skin crawl to look at it...",
                              "La ressemblance est frappante, <E003 6>n'est-ce pas ?<E003 10>\r\n<E025 3>Ça me donne froid dans le dos...");
                s = s.Replace("<E041 110 5><E025 2>I know!<E023><PAGE>",
                              "<E041 110 5><E025 2>Je sais !<E023><PAGE>");
                s = s.Replace("But look, Runo.<E003 12> You can kick this Hurley, <E003 8>and he doesn't\r\nmove a muscle!",
                              "Mais regarde, Nicky.<E003 12> On peut donner un coup à ce Sherlockinou, <E003 8>il ne bouge\r\npas d'un cil !");
                s = s.Replace("You can't go around kicking the exhibits, <E003 6><E145 2 77><E149 2 3 0><E118 2 0.2>Iris!<E003 12>\r\n<E025 7>...<E003 2>...<E003 4>...<E003 15><E025 3><E330>Wait.",
                              "On ne donne pas des coups de pied aux statues, <E003 6><E145 2 77><E149 2 3 0><E118 2 0.2>Iris !<E003 12>\r\n<E025 7>...<E003 2>...<E003 4>...<E003 15><E025 3><E330>Attends.");
                s = s.Replace("It, <E003 10><E025 2>it just moved, <E003 6>I'm sure.<E003 10>\r\n<E025 1>And not just a little bit, either!",
                              "Elle, <E003 10><E025 2>elle vient de bouger, <E003 6>j'en suis sûr.<E003 10>\r\n<E025 1>Et pas qu'un peu, en plus !");
                s = s.Replace("Hm? <E149 2 0 0><E003 25><E333><E149 2 3 0><E172 2 0 0 0 0 2>Really? <E149 2 0 0><E003 16><E333><E149 2 3 0><E172 2 0 0 0 0 0>Did it?",
                              "Hum ? <E149 2 0 0><E003 25><E333><E149 2 3 0><E172 2 0 0 0 0 2>Vraiment ? <E149 2 0 0><E003 16><E333><E149 2 3 0><E172 2 0 0 0 0 0>Elle a bougé ?");
                s = s.Replace("And look closely...", "Et regarde d'un peu plus près...");
                s = s.Replace("...there are beads of sweat on the face...<E003 8>of this waxwork<E025 7>...<E003 10>\r\n<E025 3>model...",
                              "... il y a des gouttes de sueur sur le visage...<E003 8>de cette statue<E025 7>...<E003 10>\r\n<E025 3>de cire...");
                s = s.Replace("Sh-<E003 8><E334>Shall we move on, Iris?",
                              "O-<E003 8><E334>On passe à la suite, Iris ?");
                s = s.Replace("...Over there, <E003 8>look!<E003 12> There's a great murder scene to enjoy!<E003 10>\r\n<E341>Much more appealing.",
                              "... Regarde par là-bas !<E003 12> Il y a une superbe scène de meurtre à admirer !<E003 10>\r\n<E341>C'est bien plus réjouissant.");
                s = s.Replace("My dear fellow!<E049><E003 12> I take exception to your recoiling in such\r\na manner, <E049><E003 8>as if you've seen something truly abhorrent!",
                              "Mon cher ami !<E049><E003 12> Je m'offusque de vous voir reculer ainsi,\r\n<E049><E003 8>comme si vous veniez d'apercevoir une horreur sans nom !");
                s = s.Replace("Mr<E025 7>...<E003 15><E607><E025 1>Mr Sholmes!<E003 20><E145 2 64><E003 8>\r\n<E025 2><E007>(I <E149 2 0 0>knew it!)",
                              "M.<E025 7>...<E003 15><E607><E025 1>M. Sholmes !<E003 20><E145 2 64><E003 8>\r\n<E025 2><E007>(Je <E149 2 0 0>le savais !)");
                s = s.Replace("Iris, <E049><E003 12><E025 2>what possessed you?!",
                              "Iris, <E049><E003 12><E025 2>quelle mouche t'a piquée ?!");
                s = s.Replace("I strictly forbade you from divulging my temporary<E145 110 64>\r\nwaxwork secret to Mr Naruhodo!",
                              "Je t'avais formellement interdit de divulguer le secret de ma statue<E145 110 64>\r\nde cire temporaire à M. Naruhodo !");
                s = s.Replace("Temporary waxwork?<E003 12>\r\n<E025 2>What do you mean?",
                              "Une statue de cire temporaire ?<E003 12>\r\n<E025 2>Que voulez-vous dire ?");
                s = s.Replace("And that kick!<E003 12> Could you not have exercised a little more\r\nrestraint?<E049><E003 12> <E025 1><E338><E342>You winded me!",
                              "Et ce coup de pied !<E003 12> N'aurais-tu pas pu faire preuve d'un soupçon\r\nde retenue ?<E049><E003 12> <E025 1><E338><E342>Tu m'as coupé le souffle !");
                s = s.Replace("But Runo has something <E145 2 64><E117 2 30>he needs to ask you.",
                              "Mais Nicky a quelque chose <E145 2 64><E117 2 30>à te demander.");
                s = s.Replace("Ah...<E003 10>a question?",
                              "Ah...<E003 10>une question ?");
                s = s.Replace("And I thought you'd probably <E145 2 64>be getting bored, too.",
                              "Et je me suis dit que tu commençais sans doute <E145 2 64>à t'ennuyer.");
                s = s.Replace("<E041 110 5><E025 1>So here we are!<E023><PAGE>",
                              "<E041 110 5><E025 1>Alors nous voilà !<E023><PAGE>");
                s = s.Replace("Hm<E025 7>...<E003 8> <E025 3>Well, <E049><E003 10><E025 2>I can't deny that your timing was impeccable.<E003 10><E145 110 64>\r\nA mere two minutes more being stationary like that...",
                              "Hum<E025 7>...<E003 8> <E025 3>Eh bien, <E049><E003 10><E025 2>votre arrivée tombe à point nommé.<E003 10><E145 110 64>\r\nDeux petites minutes de plus dans cette immobilité...");
                s = s.Replace("...and my great brain, <E049><E003 6>upon which all my success has been\r\nbuilt, <E049><E003 8><E346><E025 1>would have turned to wax!",
                              "... et ce cerveau de génie, <E049><E003 6>sur lequel repose toute ma gloire,\r\n<E049><E003 8><E346><E025 1>se serait changé en cire !");
                s = s.Replace("...Thank goodness we arrived in time.",
                              "... Grand bien nous fasse d'être arrivés à temps.");
                s = s.Replace("Indeed.<E003 12> <E025 2>In many ways, <E003 8><E025 1>the pair of you just saved the\r\nworld from an unimaginable loss!",
                              "En effet.<E003 12> <E025 2>À bien des égards, <E003 8><E025 1>vous venez d'épargner au monde\r\nune perte incommensurable !");
                s = s.Replace("Oh, Hurley!<E049><E003 10> <E025 1><E341>You do like to talk nonsense, <E049><E003 6>don't you?",
                              "Oh, Sherlockinou !<E049><E003 10> <E025 1><E341>Tu racontes vraiment n'importe quoi, <E049><E003 6>dis donc !");
                s = s.Replace("(He could know something, <E003 4>it's true.)",
                              "(Il en sait peut-être davantage, <E003 4>c'est vrai.)");
                s = s.Replace("(About Lord van Zieks, <E003 8><E025 2><E341>and what happened in the past to\r\nchange him.)",
                              "(Sur Lord Van Peers, <E003 8><E025 2><E341>et ce qui s'est produit jadis pour\r\nle changer ainsi.)");
                s = s.Replace("Now that you're here,<E003 6> let's take our time.<E049><E003 14>\r\nHow can I be of assistance?",
                              "Puisque vous êtes là,<E003 6> prenons tout notre temps.<E049><E003 14>\r\nEn quoi puis-je vous être utile ?");
                s = s.Replace("For you're in luck.<E049><E003 12> I'm suddenly quite taken with the idea\r\nof conversing!",
                              "Car la chance vous sourit.<E049><E003 12> L'envie de converser me submerge\r\nsoudainement !");
                s = s.Replace("Oh...<E003 10><E025 3>well, <E003 6>actually, <E003 8><E145 2 64><E025 2>I'm in quite a hurry.",
                              "Oh...<E003 10><E025 3>eh bien, <E003 6>en réalité, <E003 8><E145 2 64><E025 2>je suis plutôt pressé.");
                s = s.Replace("And if my eyes don't deceive me...",
                              "Et si mes yeux ne me trompent pas...");
                s = s.Replace("...I believe something is afoot within the walls of this very\r\nmuseum.<E049><E003 10> <E025 2><E164 2 79 1 2 7 0 0 1><E139 2><E092 7>A most fascinating case, <E049><E003 6>if I'm not mistaken.",
                              "... je crois que quelque chose se trame entre les murs de ce\r\nmusée.<E049><E003 10> <E025 2><E164 2 79 1 2 7 0 0 1><E139 2><E092 7>Une affaire des plus fascinantes, <E049><E003 6>si je ne m'abuse.");
                s = s.Replace("<E041 1 0><E333><E025 2>Really?<E023><PAGE>",
                              "<E041 1 0><E333><E025 2>Vraiment ?<E023><PAGE>");
                s = s.Replace("Moreover...", "De surcroît...");
                s = s.Replace("...I have a strong suspicion that it is related to the matter\r\nabout which you've come to me now.",
                              "... j'ai le pressentiment intime qu'elle n'est pas sans lien avec\r\nl'objet même de votre visite.");
                s = s.Replace("(But<E025 10>...<E003 12><E341><E025 2>how could it be?)",
                              "(Mais<E025 10>...<E003 12><E341><E025 2>comment cela se pourrait-il ?)");
                s = s.Replace("We shall speak again presently, <E049><E003 6>my dear fellow.<E049><E003 20>\r\n<E025 2>But for now, <E049><E003 6>I must return to my work.",
                              "Nous reprendrons cette discussion sous peu, <E049><E003 6>mon cher ami.<E049><E003 20>\r\n<E025 2>Mais pour l'heure, <E049><E003 6>le devoir m'appelle.");
                s = s.Replace("(What, <E003 8><E025 2>back to being a temporary waxwork exhibit?)",
                              "(Quoi, <E003 8><E025 2>redevenir une statue de cire d'exposition ?)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("(He's not even blinking now!<E003 12> <E025 1><E346>He really is a perfect model\r\nof a waxwork model!)",
                              "(Il ne cligne même plus des yeux !<E003 12> <E025 1><E346>C'est véritablement l'incarnation\r\nparfaite d'une statue de cire !)");
                s = s.Replace("I know it doesn't always seem like it, <E049><E003 8>but Hurley's quite\r\na perfectionist in fact.",
                              "Je sais que ça n'en a pas l'air, <E049><E003 8>mais Sherlockinou est un grand\r\nperfectionniste en fait.");
                s = s.Replace("He practises at night sometimes instead of sleeping.<E049><E003 10>\r\nNot blinking, <E049><E003 6><E025 3>I mean.",
                              "Parfois la nuit, il s'entraîne au lieu de dormir.<E049><E003 10>\r\nÀ ne pas cligner des yeux, <E049><E003 6><E025 3>je veux dire.");
                s = s.Replace("...Well, <E049><E003 8><E025 3>practice makes perfect, <E049><E003 8>I suppose?",
                              "... Eh bien, <E049><E003 8><E025 3>c'est en forgeant qu'on devient forgeron, <E049><E003 8>j'imagine ?");
                s = s.Replace("I've just realised, though, <E049><E003 8><E025 2>seeing him standing over there\r\nnow...",
                              "Mais en le voyant là, <E049><E003 8><E025 2>je viens de réaliser...");
                s = s.Replace("He looks like he's that murderer's accomplice,<E049><E003 6> doesn't he?<E003 12>\r\n<E043>Or henchman, even.",
                              "On dirait le complice de cette tueuse,<E049><E003 6> non ?<E003 12>\r\n<E043>Voire son homme de main.");
                s = s.Replace("(That's news to someone, <E003 6><E025 3>by the look of it...)",
                              "(L'intéressé a l'air de tomber des nues, <E003 6><E025 3>on dirait...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("That big, heavy curtain is in a very prominent position,\r\n<E003 8>isn't it?",
                              "Ce grand rideau bien lourd est placé à un endroit bien en vue,\r\n<E003 8>non ?");
                s = s.Replace("I've a nasty feeling there's going to be something<E003 10> <E025 4><E239>truly\r\nterrifying <E003 8><E025 3>behind it.",
                              "J'ai le mauvais pressentiment qu'il y a quelque chose de véritablement<E003 10> <E025 4><E239>\r\nterrifiant <E003 8><E025 3>derrière.");
                s = s.Replace("Oh yes!<E049><E003 8> <E025 2><E164 110 68 1 2 6 0 0 1><E139 110>That's the famous Tusspells Special Exhibit!",
                              "Oh oui !<E049><E003 8> <E025 2><E164 110 68 1 2 6 0 0 1><E139 110>C'est la fameuse exposition spéciale de Madame Pétrie !");
                s = s.Replace("It depicts one of England's most notorious killers.<E049><E003 10>\r\nDo you want to pay the extra fee and have a look?",
                              "Elle met en scène l'un des tueurs les plus célèbres d'Angleterre.<E049><E003 10>\r\nTu veux payer le supplément pour aller jeter un œil ?");
                s = s.Replace("Pay more money?<E003 16> <E332>To be even more terrified?<E003 14>\r\n<E025 5>Ooh, <E003 10><E025 3>let me think about that for a moment...",
                              "Payer encore ?<E003 16> <E332>Pour avoir encore plus peur ?<E003 14>\r\n<E025 5>Ouh là, <E003 10><E025 3>laisse-moi y réfléchir deux secondes...");
                s = s.Replace("...It was only a suggestion.", "... Ce n'était qu'une suggestion.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("Is, <E003 10><E341>is this s-<E003 10><E025 2><E341>some infamous m-<E003 8><E025 4>m-<E003 15><E239><E025 2>murderer?",
                              "C, <E003 10><E341>c'est une s-<E003 10><E025 2><E341>sinistre m-<E003 8><E025 4>m-<E003 15><E239><E025 2>meurtrière ?");
                s = s.Replace("Yes.<E049><E003 12> <E333>Called ‘Jane the Ripper’.<E049><E003 12>\r\nAll her victims were young women.",
                              "Oui.<E049><E003 12> <E333>Surnommée « Jeanne l'Éventreuse ».<E049><E003 12>\r\nToutes ses victimes étaient de jeunes femmes.");
                s = s.Replace("I, <E003 10><E341>I knew it!<E003 10> You can t-<E003 8>t-<E003 8><E341>tell by the way she's h-<E003 8><E341>holding\r\nthat knife.<E003 8> Sure sign of a <E003 6>m-<E003 6>m-<E003 6><E330>murderer!",
                              "J, <E003 10><E341>je le savais !<E003 10> Ça se v-<E003 8>v-<E003 8><E341>voit à la façon dont elle t-<E003 8><E341>tient\r\nce couteau.<E003 8> Signe indiscutable d'une <E003 6>m-<E003 6>m-<E003 6><E330>meurtrière !");
                s = s.Replace("...Well yes.", "... Eh bien, oui.");
                s = s.Replace("AAAAAAGH!", "AAAAAARGH !");
                s = s.Replace("What's the matter, Runo?!", "Qu'est-ce qu'il y a, Nicky ?!");
                s = s.Replace("I've worked it out!<E003 10> I know what she's doing!", "J'ai compris !<E003 10> Je sais ce qu'elle manigance !");
                s = s.Replace("She's trying to fill that bathtub with blood so she can have\r\na soak in her victims' gore!",
                              "Elle essaie de remplir cette baignoire de sang pour s'y prélasser\r\nau milieu du carnage !");
                s = s.Replace("Um<E025 7>...<E049><E003 10><E025 2>not according to the information about the exhibit\r\non the little board here.",
                              "Euh<E025 7>...<E049><E003 10><E025 2>pas d'après les explications sur le petit écriteau\r\njuste ici.");
                s = s.Replace("It doesn't mention anything about the bathtub.", "Il n'y a pas le moindre mot au sujet de la baignoire.");
                s = s.Replace("<E041 1 0><E025 2><E341>Really?<E023><PAGE>", "<E041 1 0><E025 2><E341>Vraiment ?<E023><PAGE>");
                s = s.Replace("Sorry.<E049><E003 12> I don't think it's significant.", "Désolée.<E049><E003 12> Je ne crois pas que ce soit important.");
                s = s.Replace("(I still think it has to be there for a reason...)", "(Je persiste à croire qu'elle se trouve là pour une raison...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Oh!<E003 10> That's a funny place for a little ladder.", "Oh !<E003 10> C'est un drôle d'endroit pour une petite échelle.");
                s = s.Replace("What is it?<E003 10>\r\nIs something wrong?", "Qu'y a-t-il ?<E003 10>\r\nQuelque chose ne va pas ?");
                s = s.Replace("No, <E003 10>it's just that in Japanese, <E003 8><E333>we have a totally different\r\nword for a ladder that folds in half like that.",
                              "Non, <E003 10>c'est juste qu'en japonais, <E003 8><E333>nous avons un mot totalement\r\ndifférent pour une échelle qui se plie en deux comme ça.");
                s = s.Replace("We do in English, too, <E049><E003 6>you know.<E049><E003 10>\r\nIt's a stepladder, <E049><E003 6>or just ‘steps’.",
                              "En anglais aussi, <E049><E003 6>tu sais.<E049><E003 10>\r\nC'est un escabeau, <E049><E003 6>ou une échelle double.");
                s = s.Replace("So be careful of making assumptions about other cultures,\r\nRuno.<E049><E003 8> That's how wars are started.",
                              "Alors fais attention aux jugements hâtifs sur d'autres cultures,\r\nNicky.<E049><E003 8> C'est comme ça que les guerres éclatent.");
                s = s.Replace("(...I didn't realise stepladders were an international point\r\nof contention.<E003 10> <E025 3>But the writer makes an astute point.)",
                              "(... J'ignorais que les escabeaux étaient une pomme de discorde\r\ninternationale.<E003 10> <E025 3>Mais l'écrivain marque un point.)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Ugh<E025 7>...<E003 12> <E341><E025 4>Is, <E003 10><E025 2><E341>is this an example of <E003 6><E239><E025 3>Western tsujigiri?",
                              "Ouh là<E025 7>...<E003 12> <E341><E025 4>E, <E003 10><E025 2><E341>est-ce là un exemple de <E003 6><E239><E025 3>tsujigiri occidental ?");
                s = s.Replace("I don't know what that is.", "Je ne sais pas ce que c'est.");
                s = s.Replace("You know, <E003 8><E025 2>when an unscrupulous samurai randomly\r\nattacks a passer-by to test his sword?",
                              "Tu sais, <E003 8><E025 2>quand un samouraï sans scrupules attaque un passant\r\nau hasard pour tester le tranchant de sa lame ?");
                s = s.Replace("...I still don't know, <E049><E003 8>no.", "... Je ne sais toujours pas, <E049><E003 8>non.");
                s = s.Replace("But actually, <E049><E003 10>a waxwork samurai would probably be\r\nhugely popular.",
                              "Mais en fait, <E049><E003 10>une statue de cire de samouraï aurait sans doute\r\nun succès fou.");
                s = s.Replace("Could you model it, <E049><E003 6>do you think, Runo?<E049><E003 10>\r\nDoing that tsujigiri thing you mentioned.",
                              "Tu pourrais poser comme modèle, <E049><E003 6>tu crois, Nicky ?<E049><E003 10>\r\nEn mimant ce fameux tsujigiri.");
                s = s.Replace("Well, <E003 6><E025 2>I do have a sword...<E003 8>but I've no intention of testing\r\nhow sharp it is on a human subject.<E003 8> <E025 4>For now <E003 8>at least.",
                              "Eh bien, <E003 6><E025 2>j'ai bien un sabre...<E003 8>mais je n'ai aucune intention d'en tester\r\nle tranchant sur un sujet humain.<E003 8> <E025 4>Pour l'instant <E003 8>du moins.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("These models are so well made, <E003 8><E025 3>I can't tell what's a\r\nwaxwork and what's a real human.",
                              "Ces statues sont si bien faites, <E003 8><E025 3>je n'arrive pas à distinguer la cire\r\nd'un être humain en chair et en os.");
                s = s.Replace("Or maybe...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>ALL the exhibits are real people!",
                              "Ou alors...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>TOUTES les statues sont de vraies personnes !");
                s = s.Replace("And when it's closing time and all the visitors have gone\r\nhome, <E049><E003 8><E333>they suddenly start moving about.",
                              "Et à la fermeture, quand tous les visiteurs sont rentrés chez eux,\r\n<E049><E003 8><E333>elles se mettent soudain à bouger.");
                s = s.Replace("(Ugh<E025 7>...<E003 10><E239><E025 3>just thinking about it makes me wish it was closing\r\ntime already and I was on my way home...)",
                              "(Brrr<E025 7>...<E003 10><E239><E025 3>rien que d'y penser, j'aimerais qu'on soit déjà à la fermeture\r\net que je sois bien au chaud à la maison...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("These models are so well made, <E003 8><E025 3>I can't tell what's a\r\nwaxwork and what's a real human.",
                              "Ces statues sont si bien faites, <E003 8><E025 3>je n'arrive pas à distinguer la cire\r\nd'un être humain en chair et en os.");
                s = s.Replace("That's how Hurley gets away with making himself a\r\ntemporary exhibit for the day.",
                              "C'est pour ça que Sherlockinou réussit à se faire passer pour une\r\nstatue le temps d'une journée.");
                s = s.Replace("Maybe there are other people posing as exhibits in here\r\nthen...",
                              "Il y a peut-être d'autres personnes qui se font passer pour des statues\r\nalors...");
                s = s.Replace("Or maybe...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>ALL the exhibits are real people!",
                              "Ou alors...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>TOUTES les statues sont de vraies personnes !");
                s = s.Replace("And when it's closing time and all the visitors have gone\r\nhome, <E049><E003 8><E333>they suddenly start moving about.",
                              "Et à la fermeture, quand tous les visiteurs sont rentrés chez eux,\r\n<E049><E003 8><E333>elles se mettent soudain à bouger.");
                s = s.Replace("(Ugh<E025 7>...<E003 10><E239><E025 3>just thinking about it makes me wish it was closing\r\ntime already and I was on my way home...)",
                              "(Brrr<E025 7>...<E003 10><E239><E025 3>rien que d'y penser, j'aimerais qu'on soit déjà à la fermeture\r\net que je sois bien au chaud à la maison...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("These models are so well made, <E003 8><E025 3>I can't tell what's a\r\nwaxwork and what's a real human.",
                              "Ces statues sont si bien faites, <E003 8><E025 3>je n'arrive pas à distinguer la cire\r\nd'un être humain en chair et en os.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("That's how Hurley gets away with making himself a\r\ntemporary exhibit for the day.",
                              "C'est pour ça que Sherlockinou réussit à se faire passer pour une\r\nstatue le temps d'une journée.");
                s = s.Replace("Maybe there are other people posing as exhibits in here\r\nthen...",
                              "Il y a peut-être d'autres personnes qui se font passer pour des statues\r\nalors...");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#12
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#12"] = en => {
                string s = en;
                s = s.Replace("Or maybe...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>ALL the exhibits are real people!",
                              "Ou alors...<E003 8><E164 110 68 1 2 7 0 0 1><E139 110><E025 2>TOUTES les statues sont de vraies personnes !");
                s = s.Replace("And when it's closing time and all the visitors have gone\r\nhome, <E049><E003 8><E333>they suddenly start moving about.",
                              "Et à la fermeture, quand tous les visiteurs sont rentrés chez eux,\r\n<E049><E003 8><E333>elles se mettent soudain à bouger.");
                s = s.Replace("(Ugh<E025 7>...<E003 10><E239><E025 3>just thinking about it makes me wish it was closing\r\ntime already and I was on my way home...)",
                              "(Brrr<E025 7>...<E003 10><E239><E025 3>rien que d'y penser, j'aimerais qu'on soit déjà à la fermeture\r\net que je sois bien au chaud à la maison...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#13
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#13"] = en => {
                string s = en;
                s = s.Replace("Is this an arm?", "Est-ce un bras ?");
                s = s.Replace("It looks like an arm, <E049><E003 6>doesn't it?", "On dirait bien un bras, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("Maybe one of the waxwork models has fallen over.", "Une des statues de cire est peut-être tombée.");
                s = s.Replace("You, <E003 8><E025 2>you don't think it could be the work <E003 8><E239><E025 3>of one of the\r\nmass murderers in here, <E003 6><E341>do you?",
                              "T, <E003 8><E025 2>tu ne penses pas que ce soit l'œuvre <E003 8><E239><E025 3>de l'un des\r\ntueurs en série d'ici, <E003 6><E341>si ?");
                s = s.Replace("Runo!<E003 12> <E025 2>S-<E003 8>Stop scaring me!", "Nicky !<E003 12> <E025 2>A-<E003 8>Arrête de me faire peur !");
                s = s.Replace("(Is it a wax arm...<E003 10><E145 110 64><E025 3>or a real one?)",
                              "(Est-ce un bras en cire...<E003 10><E145 110 64><E025 3>ou un vrai ?)");
                s = s.Replace("Come on, <E049><E003 8>you're always pointing that finger of yours in\r\ncourt.<E049><E003 8> Poke that arm now and see how it feels.",
                              "Allez, <E049><E003 8>tu passes ton temps à pointer ton index au\r\ntribunal.<E049><E003 8> Touche ce bras et dis-moi ce que tu ressens.");
                s = s.Replace("<E041 1 0><E025 1><E331>...Objection!<E023><PAGE>",
                              "<E041 1 0><E025 1><E331>... Objection !<E023><PAGE>");
                return s;
            };

            // BB\script\output\_sce02_bg1300_0_check_eng#14
            entryTranslators["BB\\script\\output\\_sce02_bg1300_0_check_eng#14"] = en => {
                string s = en;
                s = s.Replace("It's just a collapsed man.", "C'est juste un homme évanoui.");
                s = s.Replace("At least it turned out he's not one of the mass murderers'\r\nvictims.",
                              "Au moins, il ne s'agit pas de l'une des victimes d'un tueur\r\nsanguinaire.");
                s = s.Replace("True.<E003 10> <E025 2>But he is one of the waxworks' victims in a way,<E003 6>\r\nisn't he?",
                              "C'est vrai.<E003 10> <E025 2>Mais c'est la victime de la statue d'une certaine façon,<E003 6>\r\nnon ?");
                s = s.Replace("...He's not showing any signs of life.", "... Il ne montre aucun signe de vie.");
                s = s.Replace("(Because he really <E145 110 64>is dead...?)", "(Parce qu'il est vraiment <E145 110 64>mort... ?)");
                s = s.Replace("Come on, <E049><E003 8>you're always pointing that finger of yours in\r\ncourt.<E049><E003 8> Poke that arm now and see how it feels.",
                              "Allez, <E049><E003 8>tu passes ton temps à pointer ton index au\r\ntribunal.<E049><E003 8> Touche ce bras et dis-moi ce que tu ressens.");
                s = s.Replace("<E041 1 0><E025 1><E331>...Objection!<E023><PAGE>",
                              "<E041 1 0><E025 1><E331>... Objection !<E023><PAGE>");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("We really do need to speak with Mr Sholmes,<E049><E003 6> and I am\r\nlonging to say hello again...",
                              "Nous avons vraiment besoin de parler à M. Sholmes,<E049><E003 6> et il me\r\ntarde tant de le saluer à nouveau...");
                s = s.Replace("...but where is he?", "... mais où est-il ?");
                s = s.Replace("I think you might find...<E003 15><E025 2><E238>that he's quite nearby, actually.",
                              "Je crois que vous découvrirez...<E003 15><E025 2><E238>qu'il est tout près, en fait.");
                s = s.Replace("Oh!<E049><E003 16><E141 2 7><E172 3 35 84 30 3 0><E136 3 79 3><E117 3 18><E003 10>\r\n<E025 2>What,<E003 8> what do you...?",
                              "Oh !<E049><E003 16><E141 2 7><E172 3 35 84 30 3 0><E136 3 79 3><E117 3 18><E003 10>\r\n<E025 2>Qu,<E003 8> qu'entendez-vous... ?");
                s = s.Replace("Indeed, my dear fellows...<E049><E003 12><E341>it is I!",
                              "En effet, mes chers amis...<E049><E003 12><E341>c'est bien moi !");
                s = s.Replace("The world-famous great detective and waxwork...<E003 12>\r\nHerlock Sholmes!",
                              "Le grand détective et statue de cire mondialement célèbre...<E003 12>\r\nHerlock Sholmes !");
                s = s.Replace("Susato-san!<E003 16>\r\n<E346>Susato-saaaaaan!",
                              "Susato-san !<E003 16>\r\n<E346>Susato-saaaaaan !");
                s = s.Replace("My most <E341>humble apologies...",
                              "Toutes mes plus <E341>humbles excuses...");
                s = s.Replace("I thought I'd died<E003 6> and gone to eternal paradise for a\r\nmoment...<E003 10>via London.",
                              "J'ai cru mourir<E003 6> et m'en aller au paradis éternel un\r\ninstant...<E003 10>en passant par Londres.");
                s = s.Replace("My dear madam...<E003 15><E025 2><E164 2 71 1 2 6 0 1 1><E139 2>allow me to make amends<E003 4> by offering\r\nyou a tasty free deduction at some point.",
                              "Ma chère demoiselle...<E003 15><E025 2><E164 2 71 1 2 6 0 1 1><E139 2>permettez-moi de me racheter<E003 4> en vous offrant\r\nune savoureuse déduction gratuite à l'occasion.");
                s = s.Replace("...As long as it's not of questionable street food quality.",
                              "... Tant qu'elle n'est pas de la qualité douteuse d'un encas de rue.");
                s = s.Replace("I don't understand.<E049><E003 10> <E025 2>Why are you working as a waxwork\r\nhere, Mr Sholmes?",
                              "Je ne comprends pas.<E049><E003 10> <E025 2>Pourquoi travaillez-vous comme statue de cire\r\nici, M. Sholmes ?");
                s = s.Replace("Merely a secret identity, you understand.<E049><E003 8>\r\nThough the case is largely solved now.",
                              "Une simple couverture secrète, vous comprenez bien.<E049><E003 8>\r\nQuoique l'affaire soit pratiquement résolue désormais.");
                s = s.Replace("<E041 3 2><E330><E025 3>Largely solved?<E023><PAGE>",
                              "<E041 3 2><E330><E025 3>Pratiquement résolue ?<E023><PAGE>");
                s = s.Replace("We're talking about<E003 10> <E333><E145 2 64>the waxwork abduction, I presume?",
                              "Nous parlons de<E003 10> <E333><E145 2 64>l'enlèvement de la statue, je présume ?");
                s = s.Replace("Indeed we are, my good fellow.<E049><E003 14> <E025 2>As I predicted,<E003 10> <E025 1><E338><E341>it was as\r\neasy as proverbial pie.",
                              "Parfaitement, mon brave ami.<E049><E003 14> <E025 2>Comme je l'avais prédit,<E003 10> <E025 1><E338><E341>ce fut\r\nun vrai jeu d'enfant.");
                s = s.Replace("Though I confess...<E003 10><E333>I'm yet to partake of a pie, <E003 4>proverbial\r\nor otherwise.<E049><E003 10> Or any food so far today for that matter.",
                              "Quoique je doive confesser...<E003 10><E333>que je n'ai point encore touché au moindre gâteau,<E003 4>\r\nproverbial ou non.<E049><E003 10> Ni à la moindre nourriture aujourd'hui, d'ailleurs.");
                s = s.Replace("*Rumble rumble <E342>rumble*", "*Gargouillements <E342>retentissants*");
                s = s.Replace("(That stomach rumble echoed around the whole\r\nmuseum...)",
                              "(Ce gargouillement d'estomac a résonné dans tout le\r\nmusée...)");
                s = s.Replace("So how did you <E145 2 64>manage to solve it so quickly?",
                              "Comment avez-vous <E145 2 64>réussi à la résoudre aussi vite ?");
                s = s.Replace("Ah,<E003 8> <E025 2>well,<E049><E003 8> do remember I said it was largely solved.",
                              "Ah,<E003 8> <E025 2>eh bien,<E049><E003 8> souvenez-vous que j'ai dit pratiquement résolue.");
                s = s.Replace("Anyway,<E003 8> I simply negotiated with the culprit.<E049><E003 10><E145 2 66><E003 15>\r\nAre you familiar with the so-called<E003 6> <E330>‘telephone’?",
                              "Quoi qu'il en soit,<E003 8> j'ai tout simplement négocié avec le ravisseur.<E049><E003 10><E145 2 66><E003 15>\r\nConnaissez-vous l'invention dite du<E003 6> <E330>« téléphone » ?");
                s = s.Replace("Oh yes!<E049><E003 10> It's a most modern invention,<E003 6> allowing you to hold\r\na conversation with people far away.",
                              "Oh oui !<E049><E003 10> C'est une invention des plus modernes,<E003 6> permettant d'avoir\r\nune conversation avec des personnes éloignées.");
                s = s.Replace("In Japan,<E003 6> only the imperial capital and a handful of other\r\ncities are connected as yet.",
                              "Au Japon,<E003 6> seules la capitale impériale et une poignée d'autres\r\nvilles y sont reliées à ce jour.");
                s = s.Replace("This morning,<E003 4> a telephone call was received here from\r\nthe perpetrator of the abduction.",
                              "Ce matin,<E003 4> un appel téléphonique a été reçu ici même de la part\r\nde l'auteur de l'enlèvement.");
                s = s.Replace("As such,<E003 8> I was able to negotiate terms,<E049><E003 10> and in the end,<E049><E003 4> <E164 2 79 1 2 6 0 0 1><E139 2>the\r\nwaxwork was returned.",
                              "Dès lors,<E003 8> j'ai pu négocier les termes,<E049><E003 10> et finalement,<E049><E003 4> <E164 2 79 1 2 6 0 0 1><E139 2>la\r\nstatue de cire a été restituée.");
                s = s.Replace("<E041 1 0><E331><E025 3>That's amazing!<E023><PAGE>",
                              "<E041 1 0><E331><E025 3>C'est prodigieux !<E023><PAGE>");
                s = s.Replace("Just between you and I...", "Entre nous soit dit...");
                s = s.Replace("...it would appear the culprit had always intended to\r\nreturn the stolen waxwork in any event.",
                              "... il semblerait que le coupable ait toujours eu l'intention de\r\nrestituer la statue volée de toute façon.");
                s = s.Replace("Oh!<E003 12> But...<E003 10><E025 2>I thought whoever was responsible had\r\ndemanded a ransom,<E003 6> no?",
                              "Oh !<E003 12> Mais...<E003 10><E025 2>je croyais que le responsable avait\r\nexigé une rançon,<E003 6> non ?");
                s = s.Replace("Yes.<E003 8> I think perhaps...", "Oui.<E003 8> Je pense sans doute...");
                s = s.Replace("...the ransom demand was necessary to avoid unwanted\r\nsuspicion regarding the true motive.",
                              "... que la demande de rançon était nécessaire pour dissimuler\r\nson véritable mobile.");
                s = s.Replace("But...<E003 10>does that not mean...", "Mais...<E003 10>cela ne signifie-t-il pas...");
                s = s.Replace("...your negotiating<E049><E003 10> <E330>was entirely unnecessary?",
                              "... que votre négociation<E049><E003 10> <E330>était totalement inutile ?");
                s = s.Replace("A fact that I must ask you to keep from Madame Tusspells<E049><E003 12>\r\nat all costs!",
                              "Un détail que je vous conjure de taire à Madame Pétrie<E049><E003 12>\r\nà tout prix !");
                s = s.Replace("A hungry young Iris<E003 4> awaits my return to Baker Street,\r\nafter all.",
                              "Une petite Iris affamée<E003 4> attend mon retour à Baker Street,\r\naprès tout.");
                s = s.Replace("(Poor Iris...)", "(Pauvre Iris...)");
                s = s.Replace("Now then,<E049><E003 10> do I sense that you have some business with\r\nthis great waxwork?",
                              "Bien alors,<E049><E003 10> aurais-je l'intuition que vous avez affaire à\r\ncette illustre statue de cire ?");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("He's gone back to his wax ‘work’...", "Il est retourné à son « travail » de cire...");
                s = s.Replace("Oh yes!<E049><E003 4> <E160 3><E139 3><E333><E025 2>Mr Sholmes is renowned as being a master of\r\ndisguise, you know.",
                              "Oh oui !<E049><E003 4> <E160 3><E139 3><E333><E025 2>M. Sholmes est réputé pour être un maître du\r\ndéguisement, vous savez.");
                s = s.Replace("...Does pretending to be a waxwork<E003 4> count as a disguise?",
                              "... Faire semblant d'être une statue de cire<E003 4> compte-t-il vraiment comme un déguisement ?");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Ah yes,<E003 8> the heavy curtains in the middle of the House of\r\nHorrors...",
                              "Ah oui,<E003 8> les lourds rideaux au milieu du Musée des\r\nHorreurs...");
                s = s.Replace("Whatever's on the other side of them,<E003 8> <E239>you just know it's\r\ngoing to be terrifying,<E003 6> don't you?",
                              "Quoi qu'il y ait de l'autre côté,<E003 8> <E239>on sait d'avance que ce sera\r\nterrifiant,<E003 6> n'est-ce pas ?");
                s = s.Replace("The sign says it's the Madame Tusspells Special Exhibit.",
                              "Le panneau indique que c'est l'exposition spéciale de Madame Pétrie.");
                s = s.Replace("It seems you have to pay extra to go inside.",
                              "Il paraît qu'il faut payer un supplément pour entrer.");
                s = s.Replace("I know!<E003 10> Can you believe that?!<E003 12> <E025 3>Pay more money,<E003 14> <E025 1><E332>as if we\r\nhaven't been scared enough already!",
                              "Je sais !<E003 10> Vous y croyez, vous ?!<E003 12> <E025 3>Payer encore plus,<E003 14> <E025 1><E332>comme si on\r\nn'avait pas déjà eu assez peur comme ça !");
                s = s.Replace("...It's not my doing,<E003 6> Mr Naruhodo.", "... Ce n'est pas de mon fait,<E003 6> M. Naruhodo.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("Five shillings we've had to pay...", "Cinq shillings que nous avons dû payer...");
                s = s.Replace("It doesn't seem right somehow that Mr Sholmes slipped\r\nthe money into his own pocket,<E003 4> does it?",
                              "Il ne semble pas très convenable que M. Sholmes ait glissé\r\nl'argent dans sa propre poche,<E003 4> n'est-ce pas ?");
                s = s.Replace("Ah!<E003 12> We could ask Gina to retrieve it for us.<E049><E003 10>\r\nUsing her special skills.",
                              "Ah !<E003 12> Nous pourrions demander à Gina de le récupérer pour nous.<E049><E003 10>\r\nGrâce à ses talents particuliers.");
                s = s.Replace("Pickpocketing police officers<E003 8> <E043>and diddling detectives...<E003 14>\r\n<E025 2><E341>Is this what makes Britain<E003 8> ‘Great’?",
                              "Des policières pickpockets<E003 8> <E043>et des détectives détrousseurs...<E003 14>\r\n<E025 2><E341>Est-ce cela qui fait la « Grande » Bretagne ?");
                s = s.Replace("Not to mention<E003 8> <E238>demigod prosecutors taking the law into\r\ntheir own hands<E003 10> <E239>or chip-loving inspectors.",
                              "Sans parler<E003 8> <E238>de procureurs tout-puissants qui se placent au-dessus des lois<E003 10> <E239>ou d'inspecteurs accros aux frites.");
                s = s.Replace("...Inspector Gregson comes off rather well in that list,<E003 6> I\r\nthink.",
                              "... L'inspecteur Gregson s'en tire plutôt bien dans cette liste,<E003 6> je\r\ntrouve.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Oh,<E003 8> what a horrifying scene!<E003 12> A murderer caught in the\r\ngrisly act!",
                              "Oh,<E003 8> quelle scène macabre !<E003 12> Une meurtrière prise sur le fait\r\nle plus abominable !");
                s = s.Replace("I know.<E003 12> And in case you were wondering,<E003 6> it's the one\r\nwith the big knife that's supposed to be the killer.",
                              "Je sais.<E003 12> Et au cas où vous vous poseriez la question,<E003 6> c'est celle\r\navec le grand couteau qui est censée être la tueuse.");
                s = s.Replace("I...<E003 6>don't think anybody would be in any doubt about that,<E003 6>\r\nsurely?",
                              "Je...<E003 6>ne pense pas que quiconque puisse avoir le moindre doute là-dessus,<E003 6>\r\nfranchement.");
                s = s.Replace("And did you know that according to the description,<E003 8> the\r\nbathtub at the back<E003 4> has no particular significance.",
                              "Et saviez-vous que d'après la notice,<E003 8> la\r\nbaignoire au fond<E003 4> n'a aucune importance particulière ?");
                s = s.Replace("What?!<E003 12> <E025 2>Really?", "Quoi ?!<E003 12> <E025 2>Vraiment ?");
                s = s.Replace("I would have thought it was meant to show<E049><E003 4> <E145 3 68><E118 3 1.2><E003 15><E330>that the killer\r\nalso worked in a bathhouse<E003 4> peddling criminal wares.",
                              "J'aurais pourtant cru que cela montrait<E049><E003 4> <E145 3 68><E118 3 1.2><E003 15><E330>que la tueuse\r\ntravaillait aussi dans un établissement de bains<E003 4> pour y écouler ses forfaits.");
                s = s.Replace("(Aha!<E003 10> We have a new theory...)", "(Aha !<E003 10> Une nouvelle théorie voit le jour...)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Ah,<E003 10> <E025 2>there's a stepladder there,<E003 6> look.",
                              "Ah,<E003 10> <E025 2>il y a un escabeau là-bas,<E003 6> regardez.");
                s = s.Replace("Oh...<E003 10> <E341>Yes...<E003 12>\r\n<E333>A stepladder...",
                              "Oh...<E003 10> <E341>Oui...<E003 12>\r\n<E333>Un escabeau...");
                s = s.Replace("I think perhaps we should let the proprietress know<E003 4> that\r\nsomeone's left it out.<E049><E003 6> <E164 3 76 0 2 23 0 0 0><E139 3>The stepladder,<E003 6> I mean.",
                              "Je pense que nous devrions signaler à la propriétaire<E003 4> que\r\nquelqu'un l'a laissé là.<E049><E003 6> <E164 3 76 0 2 23 0 0 0><E139 3>L'escabeau,<E003 6> je veux dire.");
                s = s.Replace("Is something wrong?", "Quelque chose ne va pas ?");
                s = s.Replace("(Why do I feel as though<E003 10> <E341>I just managed to sidestep an\r\nargument...?)",
                              "(Pourquoi ai-je l'impression<E003 10> <E341>d'avoir échappé de justesse à une dispute... ?)");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("This one's posture<E049><E003 8> reveals his weakness.",
                              "La posture de celui-ci<E049><E003 8> trahit sa faiblesse.");
                s = s.Replace("<E041 1 0><E333><E025 2><E341>Sorry?<E023><PAGE>",
                              "<E041 1 0><E333><E025 2><E341>Pardon ?<E023><PAGE>");
                s = s.Replace("The killer's stance leaves him wide open to attack.<E049><E003 10>\r\n<E164 3 83 1 2 8 0 1 1><E139 3>I'm quite sure I could see him off...",
                              "La garde du meurtrier le laisse totalement sans défense.<E049><E003 10>\r\n<E164 3 83 1 2 8 0 1 1><E139 3>Je suis bien certaine de pouvoir le neutraliser...");
                s = s.Replace("...with a Susato Takedown,<E003 10> then a Susato Squash<E049><E003 12> and\r\nfinally<E049><E003 10> <E145 3 85><E144 3><E346>a Susato Smash.",
                              "... par une Prise Susato,<E003 10> puis un Écrasement Susato<E049><E003 12> et\r\nenfin<E049><E003 10> <E145 3 85><E144 3><E346>un Fracas Susato.");
                s = s.Replace("R-<E003 10><E341>Right...", "C-<E003 10><E341>C'est bien...");
                s = s.Replace("And if that doesn't render the culprit unconscious,<E049><E003 12> <E046><E025 1>a\r\nSusato Slam should finish him.",
                              "Et si cela n'assomme pas le coupable,<E049><E003 12> <E046><E025 1>une\r\nProjection Susato devrait l'achever.");
                s = s.Replace("A,<E003 8> <E025 3><E330>a Susato Slam?",
                              "U,<E003 8> <E025 3><E330>une Projection Susato ?");
                s = s.Replace("Oh!<E003 10> I'm sorry,<E003 8> it's...<E003 8><E025 3>rather hard to explain.",
                              "Oh !<E003 10> Pardonnez-moi,<E003 8> c'est...<E003 8><E025 3>assez difficile à expliquer.");
                s = s.Replace("Leave yourself open slightly,<E003 4> and I'll demonstrate...",
                              "Baissez un peu votre garde,<E003 4> et je vais vous faire une démonstration...");
                s = s.Replace("...Absolutely not.", "... Absolument pas question.");
                return s;
            };

            // BB\script\output\_sce02_bg1300_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg1300_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("That old policeman isn't here now,<E003 6> obviously.",
                              "Ce vieux policier n'est plus là,<E003 6> évidemment.");
                s = s.Replace("I still can't believe he just happened to be on the jury,\r\nthough.",
                              "J'ai encore du mal à croire qu'il se soit retrouvé parmi les jurés,\r\nquand même.");
                s = s.Replace("I'd understood that London has a population of six million\r\npeople.<E049><E003 10> <E025 3>And yet...",
                              "J'avais cru comprendre que Londres comptait six millions\r\nd'habitants.<E049><E003 10> <E025 3>Et pourtant...");
                s = s.Replace("...you do seem to run into the same people<E003 4>\r\ndisproportionately often, don't you?",
                              "... vous semblez recroiser les mêmes personnes<E003 4>\r\navec une fréquence stupéfiante, n'est-ce pas ?");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("Um...<E003 10><E025 2>Mr Sholmes?<E003 12>\r\n<E330>Have you found something?",
                              "Euh...<E003 10><E025 2>M. Sholmes ?<E003 12>\r\n<E330>Avez-vous trouvé quelque chose ?");
                s = s.Replace("Ah,<E003 4> Mr Naruhodo.<E049><E003 14><E145 2 67>\r\nYes,<E003 8> in point of fact,<E049><E003 12> <E025 3>something rather fascinating.",
                              "Ah,<E003 4> M. Naruhodo.<E049><E003 14><E145 2 67>\r\nOui,<E003 8> à vrai dire,<E049><E003 12> <E025 3>quelque chose de fort fascinant.");
                s = s.Replace("What do you make...<E003 4><E025 2><E164 2 71 1 2 6 0 0 1><E139 2><E060 0 99 1 1>of this?",
                              "Que pensez-vous...<E003 4><E025 2><E164 2 71 1 2 6 0 0 1><E139 2><E060 0 99 1 1>de ceci ?");
                s = s.Replace("Hm,<E003 6> let's see...<E003 14>\r\n<E007>(I've never seen anything like it before.)",
                              "Hum,<E003 6> voyons voir...<E003 14>\r\n<E007>(Je n'ai jamais rien vu de tel auparavant.)");
                s = s.Replace("It looks like a bundle of thick cigars<E003 6> wrapped up in a large\r\nwatch to me, but–",
                              "On dirait une botte de gros cigares<E003 6> enveloppée dans une grosse\r\nmontre, mais...");
                s = s.Replace("Miss Susato!<E003 14> <E025 3><E341>What's the matter?",
                              "Mademoiselle Susato !<E003 14> <E025 3><E341>Qu'y a-t-il ?");
                s = s.Replace("That, <E003 10><E342>that, <E003 7><E341>that, <E003 10><E025 4><E342>that...<E049><E003 16>\r\n<E025 2><E604>That's a...",
                              "C'est, <E003 10><E342>c'est, <E003 7><E341>c'est, <E003 10><E025 4><E342>c'est...<E049><E003 16>\r\n<E025 2><E604>C'est une...");
                s = s.Replace("Surely that's<E049><E003 8> <E330><E006>a time bomb<E005>...<E003 12>isn't it?",
                              "Ne me dites pas que c'est<E049><E003 8> <E330><E006>une bombe à retardement<E005>...<E003 12>n'est-ce pas ?");
                s = s.Replace("WHAAAAAAAAT?!<E049><E003 16>\r\n<E045><E025 3>Did you say...?!",
                              "QUOOOOOOOI ?!<E049><E003 16>\r\n<E045><E025 3>Avez-vous dit... ?!");
                s = s.Replace("A...<E003 12><E025 2><E145 122 73><E117 122 5><E003 5><E333><E342>time bomb...?",
                              "Une...<E003 12><E025 2><E145 122 73><E117 122 5><E003 5><E333><E342>bombe à retardement... ?");
                s = s.Replace("Um...<E003 8>sorry, but...", "Euh...<E003 8>pardonnez-moi, mais...");
                s = s.Replace("...what is a<E003 8> <E025 3>‘time bomb’<E003 6> <E025 2>exactly?",
                              "... qu'est-ce qu'une<E003 8> <E025 3>« bombe à retardement »<E003 6> <E025 2>au juste ?");
                s = s.Replace("<E041 7 9><E334><E025 2>Eh?<E023><PAGE>", "<E041 7 9><E334><E025 2>Hein ?<E023><PAGE>");
                s = s.Replace("Ah<E003 8> <E025 1>ha ha ha ha hah!<E049><E003 18>\r\n<E164 2 79 1 2 8 0 2 1><E118 2 1.2><E139 2>You truly are one of a kind,<E003 12> Mr Naruhodo!",
                              "Ah<E003 8> <E025 1>ha ha ha ha ha !<E049><E003 18>\r\n<E164 2 79 1 2 8 0 2 1><E118 2 1.2><E139 2>Vous êtes véritablement unique en votre genre,<E003 12> M. Naruhodo !");
                s = s.Replace("(I won't take that as a compliment...)", "(Je ne vais pas prendre ça pour un compliment...)");
                s = s.Replace("Hah!<E049><E003 18> <E136 122 74 25><E117 122 15><E003 8><E025 2>Ya don't know nuffin', do ya,<E003 6> 'Oddo!",
                              "Hah !<E049><E003 18> <E136 122 74 25><E117 122 15><E003 8><E025 2>Tu piges que dalle à rien, ma parole,<E003 6> 'Hodo !");
                s = s.Replace("...You haven't got a clue what it is, either,<E003 6> have you, Gina?",
                              "... Tu n'as pas la moindre idée de ce que c'est non plus,<E003 6> pas vrai, Gina ?");
                s = s.Replace("I invite you to consult a dictionary later,<E003 6> Mr Naruhodo.",
                              "Je vous invite à consulter un dictionnaire plus tard,<E003 6> M. Naruhodo.");
                s = s.Replace("But this particular specimen is no time bomb.<E049><E003 20>\r\n<E025 2>Though I confess it has a very similar appearance.",
                              "Mais ce spécimen particulier n'est pas une bombe à retardement.<E049><E003 20>\r\n<E025 2>Quoique j'avoue que l'apparence soit fort ressemblante.");
                s = s.Replace("Oh!<E003 14> <E341>Oh,<E003 6> well, thank goodness!<E049><E003 10>\r\n<E145 3 92><E117 3 15><E003 5>But then...<E003 8>what is it?",
                              "Oh !<E003 14> <E341>Oh,<E003 6> grand bien nous fasse !<E049><E003 10>\r\n<E145 3 92><E117 3 15><E003 5>Mais alors...<E003 8>qu'est-ce que c'est ?");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Almost every piece of furniture<E049><E003 12> <E025 1><E160 3><E335>is <E006>upside-down<E005>!",
                              "Presque tous les meubles<E049><E003 12> <E025 1><E160 3><E335>sont <E006>la tête en bas<E005> !");
                s = s.Replace("Even Mr Sholmes's suite<E003 6> <E330>isn't ever in this much of a mess.",
                              "Même les appartements de M. Sholmes<E003 6> <E330>ne sont jamais dans un tel désordre.");
                s = s.Replace("You're in no position to comment on mess,<E003 8> Mr Naruhodo!",
                              "Vous êtes mal placé pour juger du désordre,<E003 8> M. Naruhodo !");
                s = s.Replace("...But I suppose it's not quite the same thing,<E003 6> is it?",
                              "... Mais j'imagine que ce n'est pas tout à fait la même chose,<E003 6> n'est-ce pas ?");
                s = s.Replace("I mean,<E003 4> it's not messy in here per se.<E003 8> <E333>It's that everything\r\nis literally <E006>upside-down<E005>.",
                              "Je veux dire,<E003 4> ce n'est pas en bazar ici à proprement parler.<E003 8> <E333>C'est que tout\r\nest littéralement <E006>la tête en bas<E005>.");
                s = s.Replace("<E145 3 68><E800 173><E003 15><E800 174><E041 3 2><E341><E025 3>But why...?",
                              "<E145 3 68><E800 173><E003 15><E800 174><E041 3 2><E341><E025 3>Mais pourquoi... ?");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("There's no denying it, is there?<E003 10>\r\n<E330>They're <E006>footprints<E005>.",
                              "On ne peut pas le nier, n'est-ce pas ?<E003 10>\r\n<E330>Ce sont des <E006>empreintes de pas<E005>.");
                s = s.Replace("Yes,<E003 8> <E025 2>it would appear so.",
                              "Oui,<E003 8> <E025 2>c'est bien ce qu'il semble.");
                s = s.Replace("And I simply can't imagine how they came to be there.",
                              "Et je n'arrive absolument pas à m'expliquer comment elles ont pu atterrir là.");
                s = s.Replace("Isn't there <E006>a Susato Shoot-Up<E005> <E145 3 67><E003 4>or something?<E003 14>\r\nLike a Susato Takedown, I mean.",
                              "N'y aurait-il pas <E006>une Envolée Susato<E005> <E145 3 67><E003 4>ou un truc du genre ?<E003 14>\r\nComme la Prise Susato, je veux dire.");
                s = s.Replace("...I'm no wonder woman,<E003 6> Mr Naruhodo.",
                              "... Je n'ai pas de pouvoirs magiques,<E003 6> M. Naruhodo.");
                s = s.Replace("(That would make her almost superhuman,<E003 6> I suppose...)",
                              "(Cela ferait d'elle une créature surhumaine, en effet...)");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("That's a really lovely model.<E003 10> <E335>It looks just like a real flying\r\nballoon!",
                              "C'est une bien jolie maquette.<E003 10> <E335>On dirait une véritable montgolfière\r\nen vol !");
                s = s.Replace("...I think it's probably staying aloft<E003 4> on the same principle\r\nas a full-sized balloon,<E003 8> using gas.",
                              "... Je pense qu'elle flotte dans les airs<E003 4> selon le même principe\r\nqu'un vrai aérostat,<E003 8> grâce au gaz.");
                s = s.Replace("...A green flying balloon...", "... Une montgolfière verte en vol...");
                s = s.Replace("It does have the hallmarks of that amazing deception at\r\nthe Great Exhibition,<E003 6> doesn't it?",
                              "Cela a toutes les caractéristiques de cette supercherie prodigieuse\r\nà l'Exposition universelle,<E003 6> non ?");
                s = s.Replace("(Could it be...)", "(Se pourrait-il...)");
                s = s.Replace("(...that the whole thing was planned<E003 4> here in this very\r\nworkshop?)",
                              "(... que toute l'affaire ait été planifiée<E003 4> ici même, dans cet\r\natelier ?)");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("That's a very large safe.<E003 10> <E333>I don't suppose even Mr Sholmes\r\ncould open that lock.",
                              "C'est un coffre-fort gigantesque.<E003 10> <E333>Je ne pense pas que même M. Sholmes\r\npuisse crocheter cette serrure.");
                s = s.Replace("Although<E003 6> <E025 2>if you were a thief,<E003 6> <E341>you could just steal the\r\nentire thing, I suppose.",
                              "Quoique<E003 6> <E025 2>si l'on était un voleur,<E003 6> <E341>on pourrait tout simplement\r\nvoler le coffre entier, j'imagine.");
                s = s.Replace("It's bolted to the floor to prevent exactly that sort of\r\nunderhand trick,<E003 4> Mr Naruhodo.",
                              "Il est boulonné au sol pour empêcher précisément ce genre de\r\nruse grossière,<E003 4> M. Naruhodo.");
                s = s.Replace("Well then...<E003 13><E025 2><E043>you could just steal <E145 3 67>the floor as well, I suppose.",
                              "Eh bien alors...<E003 13><E025 2><E043>on pourrait aussi voler <E145 3 67>le plancher avec, j'imagine.");
                s = s.Replace("I'm sorry,<E049><E003 6> <E025 2>but you really aren't making any sense at all...",
                              "Pardonnez-moi,<E049><E003 6> <E025 2>mais vous n'avez absolument aucun sens des réalités...");
                s = s.Replace("Anyway,<E049><E003 10> <E333>I think we can agree that whatever is inside<E003 6>\r\nmust be very important.",
                              "Quoi qu'il en soit,<E049><E003 10> <E333>nous conviendrons tous que ce qui est à l'intérieur<E003 6>\r\ndoit être de la plus haute importance.");
                return s;
            };

            // BB\script\output\_sce02_bg1301_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg1301_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("I still can't believe<E003 10> <E025 2><E335>we were nearly blown up...",
                              "J'ai encore du mal à réaliser<E003 10> <E025 2><E335>que nous avons failli exploser...");
                s = s.Replace("What was that<E049><E003 10> <E025 2><E333>sideways glance in aid of, Mr Naruhodo?",
                              "À quoi rimait<E049><E003 10> <E025 2><E333>ce regard en coin, M. Naruhodo ?");
                s = s.Replace("I thought that deducing meaning from the movement of\r\npeople's eyes was your speciality,<E003 4> Mr Sholmes.",
                              "Je croyais que déduire des vérités du mouvement des\r\nyeux était votre spécialité,<E003 4> M. Sholmes.");
                s = s.Replace("Never mind that now.<E049><E003 4>\r\n<E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3>Let's see what Mr Drebber has to say for himself.",
                              "Peu importe à présent.<E049><E003 4>\r\n<E164 3 87 1 2 8 0 1 1><E149 3 4 4><E139 3>Voyons voir ce que M. Enigmar a à dire pour sa défense.");
                return s;
            };
        }
    }
}
