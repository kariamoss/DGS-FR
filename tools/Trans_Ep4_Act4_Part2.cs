using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act4 {
    public partial class Program {
        public static void RegisterPart2() {
            // [28] BB\script\output\_sce03_c106_0000_eng#3
            entryTranslators[@"BB\script\output\_sce03_c106_0000_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("This, <E049><E003 8><E341>this is outrageous!<E049><E003 12>\r\n<E160 15><E046><E025 1>You imprisoned the man?!", "C'est... <E049><E003 8><E341>c'est intolérable !<E049><E003 12>\r\n<E160 15><E046><E025 1>Vous avez séquestré cet homme ?!");
                s = s.Replace("But!<E049><E003 8> No!<E049><E003 8> <E606>Si!<E049><E003 8> No!<E049><E003 15>\r\n<E145 81 74><E118 81 1.3><E149 81 2 4><E144 81><E045><E025 1>It, <E049><E003 10><E607>it was not-a like a prison!", "Mais !<E049><E003 8> Non !<E049><E003 8> <E606>Si !<E049><E003 8> Non !<E049><E003 15>\r\n<E145 81 74><E118 81 1.3><E149 81 2 4><E144 81><E045><E025 1>Ce... <E049><E003 10><E607>ce n'était pas comme une prison !");
                s = s.Replace("He was-a <E049><E003 8><E025 2>very comfortable and-a <E049><E003 8>calm and-a <E049><E003 8><E025 1><E335>happy!", "Il était <E049><E003 8><E025 2>très bien installé, <E049><E003 8>calme et <E049><E003 8><E025 1><E335>heureux !");
                s = s.Replace("Ay, <E003 4>capo?", "Pas vrai, <E003 4>capo ?");
                s = s.Replace("It, <E049><E003 12><E025 2>it was never part of my plan!<E049><E003 16>\r\n<E145 80 77><E117 80 5><E149 80 4 4><E045><E025 1>I swear it!", "Ce... <E049><E003 12><E025 2>cela n'a jamais fait partie de mon plan !<E049><E003 16>\r\n<E145 80 77><E117 80 5><E149 80 4 4><E045><E025 1>Je le jure !");
                s = s.Replace("Uffa!<E049><E003 12> <E025 2>So...<E003 10><E025 1><E025 1><E331>so you think it was-a my fault, <E049><E003 6><E025 2>ay?", "Uffa !<E049><E003 12> <E025 2>Alors... <E003 10><E025 1><E025 1><E331>tu crois que c'est de ma faute, <E049><E003 6><E025 2>hein ?");
                s = s.Replace("Just because I got the date of the ferry wrong...<E049><E003 8>\r\n<E164 81 74 1 2 9 0 3 1><E149 81 2 4><E139 81><E025 1>by one-a little-a day!", "Tout ça parce que je me suis trompé de date pour le ferry...<E049><E003 8>\r\n<E164 81 74 1 2 9 0 3 1><E149 81 2 4><E139 81><E025 1>d'un tout petit jour !");
                s = s.Replace("I do not sink it was your fault, Peppino.<E145 81 68><E117 81 6><E149 81 0 0><E049><E003 16>\r\n<E346>I know it!", "Je ne pense pas que c'était de ta faute, Peppino.<E145 81 68><E117 81 6><E149 81 0 0><E049><E003 16>\r\n<E346>J'en suis certain !");
                s = s.Replace("No no no no!<E049><E003 10> <E025 1>Per favore, <E049><E003 4>capo.<E049><E003 12>\r\n<E025 1><E335>Is not-a fair.", "Non non non non !<E049><E003 10> <E025 1>Per favore, <E049><E003 4>capo.<E049><E003 12>\r\n<E025 1><E335>C'est pas juste.");
                s = s.Replace("You shall have plenty of time for squabbling back at the\r\nprison, <E049><E003 6>gentlemen.", "Vous aurez tout le loisir de vous chamailler une fois de\r\nretour en cellule, <E049><E003 6>messieurs.");
                s = s.Replace("Uff!<E049><E003 15> <E169 80 3><E025 3>I don't believe zis...<E003 12>\r\n'Ow could 'e 'ave been a real detective...?", "Pfff !<E049><E003 15> <E169 80 3><E025 3>Je n'arrive pas à y croire...<E003 12>\r\nComment pouvait-il être un vrai détective... ?");
                s = s.Replace("Counsel for the Defence, <E049><E003 8><E145 15 5><E025 2><E338><E341>proceed with the\r\ncross-examination!", "Maître pour la défense, <E049><E003 8><E145 15 5><E025 2><E338><E341>veuillez poursuivre votre\r\ncontre-interrogatoire !");
                s = s.Replace("(So on the day before the incident...)", "(Ainsi donc, la veille du meurtre...)");
                s = s.Replace("(...Gregson spent the night <E049><E003 8><E025 2><E338><E341>confined in this pair's hideout...)", "(...Gregson a passé la nuit <E049><E003 8><E025 2><E338><E341>séquestré dans le repaire de ces deux compères...)");
                return s;
            };

            // [29] BB\script\output\_sce03_c106_0010_eng#2
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Detective and the Identification –", "– Le détective et la carte d'identité –");
                return s;
            };

            // [30] BB\script\output\_sce03_c106_0010_eng#4
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Ze, ze truth is, we took 'im prisoner and kept 'im for ze\r\nnight at our secret 'ideout.", "La, la vérité, c'est que nous l'avons fait prisonnier et l'avons\r\ngardé pour la nuit dans notre repaire secret.");
                return s;
            };

            // [31] BB\script\output\_sce03_c106_0010_eng#5
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Even though I didn't sink 'e was a real detective, I, I was\r\ntoo scared to let 'im go zat day, just in case.", "Même si je ne croyais guère qu'il fût un vrai détective, j'ai... j'ai\r\neu trop peur de le relâcher ce jour-là, au cas où.");
                return s;
            };

            // [32] BB\script\output\_sce03_c106_0010_eng#6
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("We took the man's identification from him and shut-a him\r\nin the room next to ours!", "On a pris la carte d'identité de cet homme et on l'a enfermé\r\ndans la chambre à côté de la nôtre !");
                return s;
            };

            // [33] BB\script\output\_sce03_c106_0010_eng#7
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Zere might 'ave been a little tussle, but we did 'im no\r\n'arm. And ze next mornin', we let 'im go.", "Il y a bien eu une petite empoignade, mais on ne lui a fait aucun\r\nmal. Et le lendemain matin, on l'a laissé partir.");
                return s;
            };

            // [34] BB\script\output\_sce03_c106_0010_eng#8
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("He tried to escape, but the capo put-a the collare on him\r\nand dragged him back...like what he did-a to me, see?", "Il a essayé de s'enfuir, mais le capo lui a mis le collier\r\net l'a ramené de force... comme il m'a fait à moi, vous voyez ?");
                return s;
            };

            // [35] BB\script\output\_sce03_c106_0010_eng#9
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("He spent-a the night in a nice room! It was-a nothing like\r\nprison really! Uèèèèèè!", "Il a passé la nuit dans une jolie chambre ! Ça ne ressemblait\r\npas du tout à une prison ! Ouaaaah !");
                return s;
            };

            // [36] BB\script\output\_sce03_c106_0010_eng#10
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("(Not much to go on, <E049><E003 6><E025 2>really...)", "(Pas grand-chose à se mettre sous la dent, <E049><E003 6><E025 2>en vérité...)");
                s = s.Replace("Their testimony does make me wonder, <E003 4>you know.", "Leur déposition m'amène à me poser une question, <E003 4>voyez-vous.");
                s = s.Replace("About this pocket watch belonging to the inspector,<E049><E003 6><E025 3> I\r\nmean.", "À propos de cette montre à gousset appartenant à l'inspecteur,<E049><E003 6><E025 3> je\r\nveux dire.");
                s = s.Replace("(Ah yes, <E049><E003 8>the one he treasured so much, <E003 4>apparently.)", "(Ah oui, <E049><E003 8>celle à laquelle il tenait tant, <E003 4>paraît-il.)");
                s = s.Replace("If he was confined but not restrained, <E049><E003 8>as the witnesses\r\nare implying...", "S'il était enfermé mais libre de ses mouvements, <E049><E003 8>comme les\r\ntémoins semblent l'indiquer...");
                s = s.Replace("...he would still have been able to wind his watch.", "...il aurait tout de même été en mesure de remonter sa montre.");
                s = s.Replace("That's very true, <E003 6><E025 3>yes.", "C'est tout à fait vrai, <E003 6><E025 3>en effet.");
                s = s.Replace("(So did Inspector Gregson actually die while he was being\r\nheld captive by these red-heads?)", "(L'inspecteur Gregson est-il réellement mort pendant qu'il\r\nétait retenu captif par ces deux rouquins ?)");
                s = s.Replace("In which case, <E049><E003 10><E025 2>is it possible that these two young men\r\nare responsible for Inspector Gregson's...?", "Auquel cas, <E049><E003 10><E025 2>serait-il possible que ces deux jeunes hommes\r\nsoient responsables de la... de l'inspecteur ?");
                s = s.Replace("To be honest...<E049><E003 15><E130 15 1><E330>I find that hard to believe.", "Pour être franc... <E049><E003 15><E130 15 1><E330>j'ai bien du mal à y croire.");
                s = s.Replace("Perhaps we should try to find out exactly what happened.", "Peut-être devrions-nous chercher à découvrir ce qui s'est passé.");
                s = s.Replace("Very wise, <E049><E003 8>Mr Naruhodo, <E049><E003 8><E341>yes.", "C'est très sage, <E049><E003 8>monsieur Naruhodo, <E049><E003 8><E341>oui.");
                return s;
            };

            // [37] BB\script\output\_sce03_c106_0010_eng#11
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("Do, <E049><E003 10><E341>do you realise what you're saying?!", "Vous... <E049><E003 10><E341>vous rendez-vous compte de ce que vous dites ?!");
                s = s.Replace("You 'ave to believe me!<E049><E003 12> <E025 1><E338><E341>I never intended for zat to 'appen.", "Vous devez me croire !<E049><E003 12> <E025 1><E338><E341>Je n'ai jamais voulu que cela arrive.");
                s = s.Replace("And I'm sure ze detective did not intend it, either.", "Et je suis certain que le détective ne le voulait pas non plus.");
                s = s.Replace("...Do you think?", "...Vous croyez ?");
                s = s.Replace("But, <E049><E003 10><E025 1><E145 80 77><E117 80 5><E149 80 1 1><E332>but zere was nothing else I could do!", "Mais... <E049><E003 10><E025 1><E145 80 77><E117 80 5><E149 80 1 1><E332>mais je ne pouvais rien faire d'autre !");
                s = s.Replace("Si!<E049><E003 14> Nothing else!", "Si !<E049><E003 14> Rien d'autre !");
                s = s.Replace("This was-a the first crime for the capo!<E049><E003 10>\r\n<E025 1><E164 81 74 1 2 8 0 2 1><E149 81 1 4><E139 81>He was at the end of his-a wits!", "C'était le tout premier délit du capo !<E049><E003 10>\r\n<E025 1><E164 81 74 1 2 8 0 2 1><E149 81 1 4><E139 81>Il était à bout de nerfs !");
                s = s.Replace("I 'ave told you before, Peppino.<E049><E003 4><E145 81 81><E003 6>\r\n<E239>Zat is not ze way to describe a criminal mastermind!", "Je te l'ai déjà dit, Peppino.<E049><E003 4><E145 81 81><E003 6>\r\n<E239>Ce n'est pas ainsi qu'on dépeint un génie criminel !");
                s = s.Replace("What about <E145 112 13><E118 112 1.3>this hideout of yours?", "Qu'en est-il <E145 112 13><E118 112 1.3>de ce fameux repaire ?");
                s = s.Replace("...An old, <E003 4>empty 'ouse behind ze park on Lime Street.", "...Une vieille maison abandonnée derrière le parc de Lime Street.");
                s = s.Replace("We rented the place for-a two days.<E049><E003 4>\r\n<E025 1><E164 81 69 1 2 8 0 2 1><E139 81>It was an inspired idea by the capo here.", "On a loué cet endroit pour deux jours.<E049><E003 4>\r\n<E025 1><E164 81 69 1 2 8 0 2 1><E139 81>C'était une idée de génie du capo ici présent.");
                s = s.Replace("An impulsive idea, <E049><E003 8>I would say.", "Une idée impulsive, <E049><E003 8>dirais-je plutôt.");
                s = s.Replace("No no no!<E049><E003 10> Not impulsive!<E049><E003 12> Inspired!<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81><E025 2>Ay, <E003 4>capo?", "Non non non !<E049><E003 10> Pas impulsive !<E049><E003 12> Inspirée !<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81><E025 2>Pas vrai, <E003 4>capo ?");
                s = s.Replace("What am I supposed to say to zat, <E003 4>uh, <E003 4>Peppino?", "Que veux-tu que je réponde à cela, <E003 4>hein, <E003 4>Peppino ?");
                s = s.Replace("And it was in the house described that you confined\r\nInspector Gregson, <E003 6>was it?", "Et c'est dans la maison décrite que vous avez séquestré\r\nl'inspecteur Gregson, <E003 6>n'est-ce pas ?");
                s = s.Replace("Ugh...<E003 10><E169 80 3><E025 4>oui.", "Ugh...<E003 10><E169 80 3><E025 4>oui.");
                s = s.Replace("But you 'ave to remember:<E049><E003 12> <E025 2>I was under ze impression zat\r\n'e was <E006>a pretender<E005>.<E049><E003 10> <E025 1><E338><E341>Not a real inspector!", "Mais n'oubliez pas :<E049><E003 12> <E025 2>j'étais persuadé qu'il s'agissait\r\nd'un <E006>imposteur<E005>.<E049><E003 10> <E025 1><E338><E341>Pas d'un véritable inspecteur !");
                s = s.Replace("That doesn't quite add up, though.<E049><E003 10> <E145 1 0><E118 1 1.3><E149 1 0 8><E003 15><E025 2>If you didn't think the\r\nman was a real inspector...", "Pourtant, cela ne colle pas tout à fait.<E049><E003 10> <E145 1 0><E118 1 1.3><E149 1 0 8><E003 15><E025 2>Si vous pensiez que\r\ncet homme n'était pas un vrai policier...");
                s = s.Replace("...there would have been no reason to take him prisoner,<E049><E003 8>\r\nwould there?", "...il n'y avait aucune raison de le faire prisonnier,<E049><E003 8>\r\nn'est-ce pas ?");
                s = s.Replace("Non, <E049><E003 8>you are right.<E049><E003 8> <E025 3>But we couldn't be completely certain.", "Non, <E049><E003 8>vous avez raison.<E049><E003 8> <E025 3>Mais nous n'en étions pas totalement certains.");
                return s;
            };

            // [38] BB\script\output\_sce03_c106_0010_eng#12
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("Too scared?<E049><E003 10> Why?", "Trop peur ?<E049><E003 10> Pourquoi ?");
                s = s.Replace("Because!<E049><E003 12> Why 'ad 'e come to ze park?<E049><E003 10>\r\nWe didn't know.", "Parce que !<E049><E003 12> Pourquoi était-il venu dans le parc ?<E049><E003 10>\r\nNous n'en savions rien.");
                s = s.Replace("Zere was a chance <E049><E003 8><E025 2><E333>zat 'e 'ad seen through my plan.", "Il y avait un risque <E049><E003 8><E025 2><E333>qu'il ait percé mon plan à jour.");
                s = s.Replace("And if that was-a the case, <E049><E003 10><E025 1><E164 81 75 1 2 1 0 2 1><E118 81 1.5><E139 81>he would go straight to the\r\npolice station to blow-a the whistle on us!", "Et si c'était le cas, <E049><E003 10><E025 1><E164 81 75 1 2 1 0 2 1><E118 81 1.5><E139 81>il serait allé tout droit au commissariat\r\npour nous dénoncer !");
                s = s.Replace("Even if he was just-a feigning to be an inspector,<E049><E003 8> <E025 1><E164 81 74 1 2 8 0 2 1><E118 81 1.3><E149 81 2 4><E139 81>he was\r\n<E006>up to no good<E005>, <E003 6><E025 2>uh?<E049><E003 12> Without-a doubt-a.", "Même s'il faisait semblant d'être inspecteur,<E049><E003 8> <E025 1><E164 81 74 1 2 8 0 2 1><E118 81 1.3><E149 81 2 4><E139 81>il\r\n<E006>ne préparait rien de bon<E005>, <E003 6><E025 2>non ?<E049><E003 12> Sans aucun doute !");
                s = s.Replace("I think most people would agree <E049><E003 8><E145 112 0><E118 112 1.3><E003 10><E025 2><E330>that it's you two who\r\nwere up to no good.", "Je pense que tout le monde s'accordera à dire <E049><E003 8><E145 112 0><E118 112 1.3><E003 10><E025 2><E330>que c'est vous deux\r\nqui ne prépariez rien de bon.");
                s = s.Replace("Well-a...<E003 6><E145 81 64><E118 81 1.3><E003 10><E149 81 0 0><E003 10><E025 2><E330>si, <E003 6>you may be right.<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81>Ay, <E003 4>capo?", "Eh bien... <E003 6><E145 81 64><E118 81 1.3><E003 10><E149 81 0 0><E003 10><E025 2><E330>si, <E003 6>vous avez peut-être raison.<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81>Pas vrai, <E003 4>capo ?");
                s = s.Replace("Ze point is, <E049><E003 8>we were not able to escape from England\r\nimmediately.", "Toujours est-il que nous ne pouvions pas fuir l'Angleterre\r\nsur-le-champ.");
                s = s.Replace("Zat is why we 'ad no choice <E049><E003 8><E025 2>but to take ze man prisoner.", "Voilà pourquoi nous n'avions d'autre choix <E049><E003 8><E025 2>que de capturer cet individu.");
                s = s.Replace("What I don't understand is <E049><E003 6><E145 1 85><E118 1 1.2><E003 10><E025 2>why the inspector felt the need\r\nto show you his identification in the first place.", "Ce que je ne saisis pas, <E049><E003 6><E145 1 85><E118 1 1.2><E003 10><E025 2>c'est pourquoi l'inspecteur a jugé nécessaire\r\nde vous montrer sa carte en premier lieu.");
                s = s.Replace("Si!<E049><E003 16> <E335>I ask myself the same question!", "Si !<E049><E003 16> <E335>Je me pose la même question !");
                s = s.Replace("We were<E149 81 0 0> writing down ze names and addresses of all ze\r\npeople who we took five shillings from zat day.", "Nous étions<E149 81 0 0> en train de noter les noms et adresses de tous les\r\ngens à qui nous avions soutiré cinq shillings ce jour-là.");
                s = s.Replace("I have forgotten what name 'e said, <E049><E003 10><E330><E025 2>but <E006>ze address<E005>, <E049><E003 8>it\r\nstartled me.", "J'ai oublié quel nom il a donné, <E049><E003 10><E330><E025 2>mais <E006>l'adresse<E005>, <E049><E003 8>elle m'a\r\nlaissé sans voix.");
                s = s.Replace("Si <E003 4>si!<E049><E003 12> <E025 1>‘Address: <E049><E003 12><E335>Scotland Yard, <E003 6>Homicide Division,’ <E049><E003 10><E025 1>he said!", "Si, <E003 4>si !<E049><E003 12> <E025 1>« Adresse : <E049><E003 12><E335>Scotland Yard, <E003 6>brigade des homicides », <E049><E003 10><E025 1>qu'il a dit !");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("'E probably didn't like your face, <E003 6>Peppino.", "Il n'aimait sans doute pas ta tête, <E003 6>Peppino.");
                s = s.Replace("Anyway, <E049><E003 8>I was not rude.<E049><E003 8> I just politely asked 'im why 'e\r\n'ad said it...", "Quoi qu'il en soit, <E049><E003 8>je n'ai pas été impoli.<E049><E003 8> Je lui ai simplement demandé pourquoi il\r\navait répondu cela...");
                s = s.Replace("...and zat's when 'e started to say 'e was an inspector.<E049><E003 12>\r\n<E025 2><E239>Not long afterwards, <E049><E003 6>'e took out 'is identification.", "...et c'est là qu'il s'est mis à prétendre qu'il était inspecteur.<E049><E003 12>\r\n<E025 2><E239>Peu après, <E049><E003 6>il a exhibé ses papiers d'identité.");
                s = s.Replace("(What was Inspector Gregson playing at?)", "(À quoi jouait donc l'inspecteur Gregson ?)");
                s = s.Replace("Tell the court what happened next.", "Dites à la cour ce qui s'est produit ensuite.");
                s = s.Replace("You took him back to your hideout, <E003 6>you say?", "Vous l'avez emmené à votre repaire, <E003 6>dites-vous ?");
                s = s.Replace("Si!<E049><E003 12> We did-a, <E049><E003 8>we did-a!", "Si !<E049><E003 12> C'est ce qu'on a fait, <E049><E003 8>exactement !");
                return s;
            };

            // [39] BB\script\output\_sce03_c106_0010_eng#13
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("That being this identification book here, <E049><E003 6>correct?", "À savoir ce carnet d'identité que voici, <E049><E003 6>correct ?");
                s = s.Replace("Si!<E049><E003 12> That is-a the one!", "Si !<E049><E003 12> C'est bien celui-là !");
                s = s.Replace("What made you believe <E049><E145 15 5><E118 15 0.5><E003 6>that it was a forgery?", "Qu'est-ce qui vous a fait croire <E049><E145 15 5><E118 15 0.5><E003 6>qu'il s'agissait d'un faux ?");
                s = s.Replace("I never seen a real one, <E145 81 64><E003 4>of course.<E049><E003 12>\r\n<E025 1><E164 81 71 1 2 1 0 2 1><E149 81 0 0><E139 81>But he was so suspicious, <E049><E003 8><E025 2>this-a man.", "J'en avais jamais vu de vrai, <E145 81 64><E003 4>bien sûr.<E049><E003 12>\r\n<E025 1><E164 81 71 1 2 1 0 2 1><E149 81 0 0><E139 81>Mais il était tellement suspect, <E049><E003 8><E025 2>cet homme-là.");
                s = s.Replace("Allora, <E049><E003 8><E025 2>I was-a thinking, <E049><E003 10><E025 1>it must be falso!<E049><E003 10>\r\n<E025 2><E164 81 81 1 2 6 0 0 1><E139 81>Ay, <E003 6>capo?", "Allora, <E049><E003 8><E025 2>je me suis dit : <E049><E003 10><E025 1>c'est forcément un faux !<E049><E003 10>\r\n<E025 2><E164 81 81 1 2 6 0 0 1><E139 81>Pas vrai, <E003 6>capo ?");
                s = s.Replace("Oui, <E049><E003 8><E025 2>it is just as Peppino 'as said.<E049><E145 81 64><E118 81 0.6><E003 10>\r\n<E025 2>We were convinced it was not genuine.", "Oui, <E049><E003 8><E025 2>c'est exactement ce que Peppino a dit.<E049><E145 81 64><E118 81 0.6><E003 10>\r\n<E025 2>Nous étions convaincus que ce document était falsifié.");
                s = s.Replace("And so together, <E049><E003 8>the Hairlarious Brothers, <E049><E003 2><E164 81 67 1 2 8 0 2 1><E139 81><E025 1>we took-a the\r\nman captive!", "Et c'est ainsi qu'ensemble, <E049><E003 8>les Frères Hilaroux, <E049><E003 2><E164 81 67 1 2 8 0 2 1><E139 81><E025 1>nous avons fait\r\ncet homme prisonnier !");
                s = s.Replace("All we did <E049><E003 8><E025 2>was shove 'im inside a locked room.", "Tout ce que nous avons fait, <E049><E003 8><E025 2>c'est le pousser dans une chambre fermée à clé.");
                s = s.Replace("Zen we made preparations to transport all of ze money.", "Ensuite, nous avons préparé le transport de tout l'argent.");
                s = s.Replace("In for a penny, <E049><E003 8>in for a pound...", "Tant qu'à faire, <E049><E003 8>autant aller jusqu'au bout...");
                return s;
            };

            // [40] BB\script\output\_sce03_c106_0010_eng#14
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("Um...<E003 10><E025 2>what do you mean by <E049><E003 4><E145 1 85><E003 12><E025 3><E330>‘a little tussle’ exactly?", "Euh... <E003 10><E025 2>qu'entendez-vous par <E049><E003 4><E145 1 85><E003 12><E025 3><E330>« une petite empoignade » au juste ?");
                s = s.Replace("Hm?<E049><E003 15> <E169 80 3><E025 1><E341>Bof!<E049><E003 8> <E025 2><E145 80 66><E149 80 0 0>It was nothing.<E049><E003 10>\r\nJust a minor incident.", "Hm ?<E049><E003 15> <E169 80 3><E025 1><E341>Bof !<E049><E003 8> <E025 2><E145 80 66><E149 80 0 0>Ce n'était rien.<E049><E003 10>\r\nUn incident mineur.");
                s = s.Replace("The falso inspector, <E049><E003 8>he was a real piece of-a the work!<E049><E003 4>\r\n<E145 81 64><E049><E003 6><E025 2><E164 81 81 1 2 6 0 0 1><E139 81>Ay, <E003 6>capo?", "Le faux inspecteur, <E049><E003 8>c'était un sacré numéro !<E049><E003 4>\r\n<E145 81 64><E049><E003 6><E025 2><E164 81 81 1 2 6 0 0 1><E139 81>Pas vrai, <E003 6>capo ?");
                s = s.Replace("What happened?", "Que s'est-il passé ?");
                s = s.Replace("Uffa!<E049><E003 10> It was a disaster!<E049><E003 10> <E025 2>We give him a nice room,<E049><E003 6> and what\r\ndoes he-a do, <E003 4>uh?", "Uffa !<E049><E003 10> C'était un désastre !<E049><E003 10> <E025 2>On lui donne une jolie chambre,<E049><E003 6> et qu'est-ce\r\nqu'il fait, <E003 4>hein ?");
                s = s.Replace("In the middle of the night, <E049><E003 3><E164 81 74 1 2 8 0 2 1><E118 81 1.2><E149 81 2 4><E139 81><E025 1>he tries to escape-a through\r\nthe ventilatore!", "En plein milieu de la nuit, <E049><E003 3><E164 81 74 1 2 8 0 2 1><E118 81 1.2><E149 81 2 4><E139 81><E025 1>il tente de s'échapper par\r\nle ventilatore !");
                s = s.Replace("...Can you blame him?", "...Peut-on vraiment lui en vouloir ?");
                s = s.Replace("We chased 'im, <E049><E003 6><E025 3>bien sûr.<E049><E003 10>\r\n<E025 2><E145 80 64><E118 80 0.5>And we caught 'im again.", "Nous l'avons poursuivi, <E049><E003 6><E025 3>bien sûr.<E049><E003 10>\r\n<E025 2><E145 80 64><E118 80 0.5>Et nous l'avons rattrapé.");
                s = s.Replace("...Can you-a blame us?", "...Peut-on nous en vouloir à nous ?");
                s = s.Replace("Wait!<E049><E003 14> <E025 1><E342>You, <E049><E003 8>you didn't...", "Attendez !<E049><E003 14> <E025 1><E342>Vous... <E049><E003 8>vous n'avez pas...");
                s = s.Replace("...shoot the man in your haste, <E049><E003 8><E342>did you?", "...tiré sur cet homme dans la précipitation, <E049><E003 8><E342>tout de même ?");
                s = s.Replace("Zut!<E049><E003 14> Who do you sink we are?!<E049><E003 14>\r\n<E332>Of course not!", "Zut !<E049><E003 14> Pour qui nous prenez-vous ?!<E049><E003 14>\r\n<E332>Certainement pas !");
                s = s.Replace("I simply caught 'old of 'im again <E049><E003 2><E145 80 66><E003 8><E025 3>and took 'im back to ze\r\nroom.", "Je l'ai simplement empoigné à nouveau <E049><E003 2><E145 80 66><E003 8><E025 3>et ramené dans la\r\nchambre.");
                s = s.Replace("Zere was really nothing more to it zan zat.", "Il n'y a vraiment rien eu d'autre.");
                s = s.Replace("And the following morning, <E049><E003 8>you let him go, <E049><E003 4>you say?", "Et le lendemain matin, <E049><E003 8>vous l'avez laissé partir, <E049><E003 4>dites-vous ?");
                s = s.Replace("Correct.<E049><E003 12> <E025 2>And it was an amicable parting.<E049><E003 12>\r\nZere was no trouble.", "Exact.<E049><E003 12> <E025 2>Et nous nous sommes séparés bons amis.<E049><E003 12>\r\nSans la moindre dispute.");
                s = s.Replace("Si <E003 6>si.<E049><E003 12> <E164 81 67 1 2 8 0 2 1><E139 81>We shake-a the hands <E049><E003 10><E025 2><E145 81 68>and say let's-a do it again, <E003 4>uh!", "Si, <E003 6>si.<E049><E003 12> <E164 81 67 1 2 8 0 2 1><E139 81>On s'est serré la main <E049><E003 10><E025 2><E145 81 68>en se disant à la prochaine !");
                s = s.Replace("(Not a whiff of perjury here...)", "(Pas l'ombre d'un parjure, c'est limpide...)");
                return s;
            };

            // [41] BB\script\output\_sce03_c106_0010_eng#15
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("Are, <E003 8><E025 3>are you saying <E049><E003 10><E341>that red mark was caused by...", "Êtes... <E003 8><E025 3>êtes-vous en train de dire <E049><E003 10><E341>que cette marque rouge a été causée par...");
                s = s.Replace("Si <E003 4>si!<E049><E003 10> <E025 1>A big <E006>collare<E005> made from-a the leather!", "Si, <E003 4>si !<E049><E003 10> <E025 1>Un gros <E006>collare<E005> fait en cuir !");
                s = s.Replace("A leather collar...", "Un collier en cuir...");
                s = s.Replace("Is this true, <E049><E003 8>Mr de Rousseau?", "Est-ce vrai, <E049><E003 8>monsieur de Rousseau ?");
                s = s.Replace("What?<E049><E003 12> We 'ad a St Bernard at 'ome when I was younger.", "Quoi ?<E049><E003 12> Nous avions un saint-bernard à la maison quand j'étais jeune.");
                s = s.Replace("It is a souvenir from zat time, <E049><E003 10><E025 3>wiz a very strong chain.", "C'est un souvenir de cette époque, <E049><E003 10><E025 3>avec une chaîne très solide.");
                s = s.Replace("A strong chain?", "Une chaîne solide ?");
                s = s.Replace("And you put that around your friend's neck?", "Et vous avez mis ça autour du cou de votre ami ?");
                s = s.Replace("I'm sorry!<E049><E003 18><E085 2 0> <E025 2><E342><E338>I was so angry zat 'e was leaving me alone.", "Je suis désolé !<E049><E003 18><E085 2 0> <E025 2><E342><E338>J'étais tellement furieux qu'il veuille m'abandonner.");
                s = s.Replace("You did not have to tie the chain to the leg-a of the bed-a,\r\nthough, <E049><E003 8><E025 2>uh?<E049><E003 10> <E025 2>I would not have tried to run again.", "Mais tu n'avais pas besoin d'attacher la chaîne au pied du lit,\r\n<E049><E003 8><E025 2>hein ?<E049><E003 10> <E025 2>J'aurais plus essayé de m'enfuir.");
                s = s.Replace("You...<E003 10><E025 1><E145 1 2><E331>you didn't do that to Inspector Gregson as well,<E049><E003 8> <E025 2>did\r\nyou?", "Vous... <E003 10><E025 1><E145 1 2><E331>vous n'avez tout de même pas fait subir ça aussi à l'inspecteur Gregson,<E049><E003 8> <E025 2>si ?");
                s = s.Replace("‘Treat-a the people-a equal-a!’<E049><E003 10>\r\n<E025 2><E164 81 69 1 2 6 0 0 1><E130 15 0><E139 81>Is the capo here's motto, <E003 4>ay?", "« Égalité pour tous ! »<E049><E003 10>\r\n<E025 2><E164 81 69 1 2 6 0 0 1><E130 15 0><E139 81>C'est la devise du capo, <E003 4>pas vrai ?");
                s = s.Replace("It's starting to sound <E049><E003 5><E145 112 13><E118 112 2.0><E003 10><E025 2><E330>a lot more <E006>like a prison<E005> all of a\r\nsudden.", "Cela commence à ressembler <E049><E003 5><E145 112 13><E118 112 2.0><E003 10><E025 2><E330>bien plus à <E006>une prison<E005> tout\r\nd'un coup.");
                s = s.Replace("The capo is-a tough!<E049><E003 15>\r\n<E025 2><E164 81 69 1 2 6 0 0 1><E130 15 0><E139 81>But the capo is-a rough!", "Le capo est sévère !<E049><E003 15>\r\n<E025 2><E164 81 69 1 2 6 0 0 1><E130 15 0><E139 81>Mais le capo est dur !");
                s = s.Replace("Uuugh...<E003 12><E169 80 3>\r\n<E025 2>I, <E049><E003 8>I shouldn't 'ave done it...", "Uuugh...<E003 12><E169 80 3>\r\n<E025 2>Je... <E049><E003 8>je n'aurais pas dû...");
                s = s.Replace("So...<E049><E003 8><E025 2><E145 1 85><E003 5>the following morning <E049><E003 8><E025 3>when you released the\r\ninspector...", "Alors... <E049><E003 8><E025 2><E145 1 85><E003 5>le lendemain matin <E049><E003 8><E025 3>quand vous avez relâché\r\nl'inspecteur...");
                s = s.Replace("He had-a the red ring around his neck <E049><E003 10><E145 81 77><E003 5><E025 1><E333>just like-a me!", "Il avait le cercle rouge autour du cou, <E049><E003 10><E145 81 77><E003 5><E025 1><E333>exactement comme moi !");
                s = s.Replace("Peppino, <E049><E003 8><E025 3>s'il vous plaît...<E049><E003 12>\r\n<E025 3>Leave it now.", "Peppino, <E049><E003 8><E025 3>s'il te plaît...<E049><E003 12>\r\n<E025 3>Tais-toi maintenant.");
                s = s.Replace("Now you know, <E049><E003 6><E025 2>uh?<E049><E003 14><E091 0 6 6> <E025 2>The capo here, <E049><E003 8>you don't-a wanna\r\ntangle with him, <E003 4>ay?<E049><E003 10> But for the inspector, <E003 6>is not so bad...", "Maintenant vous savez, <E049><E003 6><E025 2>hein ?<E049><E003 14><E091 0 6 6> <E025 2>Le capo, <E049><E003 8>faut pas lui chercher des\r\nnoises, <E003 4>pas vrai ?<E049><E003 10> Mais pour l'inspecteur, c'était pas si grave...");
                return s;
            };

            // [42] BB\script\output\_sce03_c106_0010_eng#16
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("You took away the man's freedom!<E049><E003 10> <E025 2>However comfortable\r\nyou make it sound, <E049><E003 10><E025 1><E345>you were still holding him prisoner.", "Vous avez privé cet homme de sa liberté !<E049><E003 10> <E025 2>Aussi confortable\r\nque vous le prétendiez, <E049><E003 10><E025 1><E345>vous le reteniez captif !");
                s = s.Replace("If you say-a that, <E049><E003 8><E341>then I say-a this:", "Si vous dites ça, <E049><E003 8><E341>alors moi je dis ceci :");
                s = s.Replace("There is something that takes away our freedom too.<E049><E003 12>\r\n<E025 1><E341>The lack of-a money!", "Il y a une chose qui nous prive aussi de liberté.<E049><E003 12>\r\n<E025 1><E341>Le manque d'argent !");
                s = s.Replace("So we are the prisoners as well, <E003 4>uh?<E049><E003 13>\r\n<E145 81 67><E149 81 0 0><E003 5><E346><E025 1>All of us!", "Alors nous sommes nous aussi des prisonniers, <E003 4>hein ?<E049><E003 13>\r\n<E145 81 67><E149 81 0 0><E003 5><E346><E025 1>Nous tous !");
                s = s.Replace("Huh?", "Hein ?");
                s = s.Replace("No money, <E049><E003 8>no freedom.<E049><E003 10> This is the truth!", "Pas d'argent, <E049><E003 8>pas de liberté.<E049><E003 10> C'est la pure vérité !");
                s = s.Replace("It-a makes me mad!<E049><E003 8> And it-a makes me sad!<E049><E003 10>\r\n<E025 1><E164 81 74 1 2 9 0 2 1><E118 81 1.3><E149 81 2 4><E139 81>What can-a we do?", "Ça me rend fou !<E049><E003 8> Et ça me rend triste !<E049><E003 10>\r\n<E025 1><E164 81 74 1 2 9 0 2 1><E118 81 1.3><E149 81 2 4><E139 81>Qu'est-ce qu'on peut faire ?");
                s = s.Replace("Um...<E003 10>well...", "Euh... <E003 10>eh bien...");
                s = s.Replace("If you feel so disenfranchised, <E049><E003 8><E330>take ‘money’ to court.<E049><E003 4>\r\n<E025 3><E145 112 14><E003 20>...Though it'll cost you, <E049><E003 6>of course.", "Si vous vous sentez si dépossédé, <E049><E003 8><E330>faites un procès à « l'argent ».<E049><E003 4>\r\n<E025 3><E145 112 14><E003 20>...Bien que cela vous en coûte, <E049><E003 6>naturellement.");
                s = s.Replace("Uffa, <E049><E003 8>there you-a have it!", "Uffa, <E049><E003 8>vous voyez bien !");
                s = s.Replace("You see?<E049><E003 8> That is why we need the Red-Headed League,<E049><E003 8>\r\n<E145 81 67><E003 5><E346><E025 1>to fight for the justice!", "Vous voyez ?<E049><E003 8> C'est pour ça qu'on a besoin de la Ligue des Rouquins,<E049><E003 8>\r\n<E145 81 67><E003 5><E346><E025 1>pour lutter pour la justice !");
                s = s.Replace("(Hm...<E003 10>perhaps he has a point.)", "(Hm... <E003 10>il n'a pas tout à fait tort.)");
                s = s.Replace("No, <E049><E003 6>Mr Naruhodo.", "Non, <E049><E003 6>monsieur Naruhodo.");
                s = s.Replace("All we did-a <E049><E003 8><E025 2>was to give the man a comfortable place to\r\nsleep for the night.", "Tout ce qu'on a fait, <E049><E003 8><E025 2>c'est lui offrir un endroit douillet\r\noù pioncer pour la nuit.");
                s = s.Replace("And you say it was a prison, <E049><E003 8><E025 2>uh?<E049><E003 14> <E332>UH?!", "Et vous dites que c'était une prison, <E049><E003 8><E025 2>hein ?<E049><E003 14> <E332>HEIN ?!");
                s = s.Replace("(Hm...<E003 10>perhaps he has a point again.)", "(Hm... <E003 10>il marque un point à nouveau.)");
                s = s.Replace("No again, <E049><E003 6>Mr Naruhodo.", "Encore non, <E049><E003 6>monsieur Naruhodo.");
                s = s.Replace("You should have heard him-a snoring!", "Vous auriez dû l'entendre ronfler !");
                s = s.Replace("Ma dai!<E049><E003 8> <E145 81 74><E139 81><E045>If anyone was disturbed, <E049><E003 8>it was us!", "Ma dai !<E049><E003 8> <E145 81 74><E139 81><E045>S'il y a quelqu'un qui a été dérangé, <E049><E003 8>c'est bien nous !");
                return s;
            };

            // [43] BB\script\output\_sce03_c106_0010_eng#18
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rossi!<E049><E003 10> <E025 2>Is something wrong?", "Monsieur de Rossi !<E049><E003 10> <E025 2>Quelque chose ne va pas ?");
                s = s.Replace("Ay?!<E049><E003 20> <E335>Me?", "Hein ?!<E049><E003 20> <E335>Moi ?");
                s = s.Replace("Something Mr de Rousseau just said seemed to make you,<E049><E003 10>\r\n<E025 3><E145 1 85><E118 1 1.3><E003 6><E341>um...", "Quelque chose que vient de dire monsieur de Rousseau vous a rendu,<E049><E003 10>\r\n<E025 3><E145 1 85><E118 1 1.3><E003 6><E341>euh...");
                s = s.Replace("Well, <E049><E003 4><E145 1 79><E003 8><E330>it seemed to make you act even more strangely\r\nthan usual.<E049><E003 10> What was that all about?", "Eh bien, <E049><E003 4><E145 1 79><E003 8><E330>vous sembliez agir de manière encore plus étrange\r\nque d'habitude.<E049><E003 10> Qu'est-ce que cela signifie ?");
                s = s.Replace("Cavolo!<E049><E003 12> <E025 2>At times like that, <E049><E003 8>you don't-a wanna have the\r\ncapo after you, <E049><E003 6><E025 1>believe me!", "Cavolo !<E049><E003 12> <E025 2>Dans des moments pareils, <E049><E003 8>vous n'avez pas envie d'avoir le\r\ncapo à vos trousses, <E049><E003 6><E025 1>croyez-moi !");
                s = s.Replace("And I speak-a from personal-a esperienza!", "Et je parle en connaissance de cause !");
                s = s.Replace("Personal experience?", "En connaissance de cause ?");
                s = s.Replace("Zat is enough, Peppino.<E049><E003 10>\r\n<E025 3><E145 80 75><E118 80 0.8>Zere is no need to say more.", "Cela suffit, Peppino.<E049><E003 10>\r\n<E025 3><E145 80 75><E118 80 0.8>Inutile d'en rajouter.");
                s = s.Replace("The truth is, <E049><E003 10><E025 2>the night-a before we put the Red-Headed\r\nLeague plan into action, <E049><E003 6>I was-a scared.", "La vérité, <E049><E003 10><E025 2>c'est que la nuit avant de lancer l'opération de la\r\nLigue des Rouquins, <E049><E003 6>j'avais peur.");
                s = s.Replace("It was not-a fair to the capo, <E049><E003 6><E025 3>but...<E049><E003 10><E025 3>I tried to run away.", "Ce n'était pas juste envers le capo, <E049><E003 6><E025 3>mais...<E049><E003 10><E025 3>j'ai tenté de fuir.");
                s = s.Replace("It's a shame you didn't manage it.", "C'est bien dommage que vous n'ayez pas réussi.");
                s = s.Replace("But the capo here, <E049><E003 5><E164 81 69 1 2 6 0 0 1><E139 81>he came after me like-a the turbine,<E049><E003 6>\r\nuh?", "Mais le capo, <E049><E003 5><E164 81 69 1 2 6 0 0 1><E139 81>il a foncé sur moi comme une trombe,<E049><E003 6>\r\npas vrai ?");
                s = s.Replace("And he dragged me back to the house, <E049><E003 8><E025 2><E145 81 65>kicking and-a\r\nscreaming.", "Et il m'a ramené à la maison, <E049><E003 8><E025 2><E145 81 65>alors que je me débattais\r\net hurlais.");
                s = s.Replace("I still have-a the bruises to prove it!<E145 80 70><E049><E003 15><E164 81 81 1 2 6 0 0 1><E139 81>\r\n<E025 2>Ay, <E003 6>capo?", "J'ai encore les bleus pour le prouver !<E145 80 70><E049><E003 15><E164 81 81 1 2 6 0 0 1><E139 81>\r\n<E025 2>Pas vrai, <E003 6>capo ?");
                s = s.Replace("Bruises, <E049><E003 8><E025 2>you say?", "Des bleus, <E049><E003 8><E025 2>dites-vous ?");
                s = s.Replace("Ah...<E003 12>you wanna see, <E003 6>uh?<E049><E003 12>\r\n<E025 1>You wanna see my-a fantastico bruises!", "Ah... <E003 12>vous voulez voir, <E003 6>hein ?<E049><E003 12>\r\n<E025 1>Vous voulez admirer mes superbes hématomes !");
                s = s.Replace("Zat's enough now, <E049><E003 6>Peppino.<E049><E003 10>\r\nNo one wants to look at any part of you.", "Ça suffit maintenant, <E049><E003 6>Peppino.<E049><E003 10>\r\nPersonne n'a envie de regarder la moindre partie de ton anatomie.");
                s = s.Replace("What-a to do, <E049><E003 6>uh?<E049><E003 8> I-a show you, <E003 6>or I-a don't...?<E049><E003 10>\r\nI-a show you, <E003 6>or I-a don't...?", "Alors on fait quoi ?<E049><E003 8> Je vous montre, <E003 6>ou pas... ?<E049><E003 10>\r\nJe montre, <E003 6>ou je montre pas... ?");
                s = s.Replace("You do!<E049><E003 16> NOW!", "Montrez-les !<E049><E003 16> TOUT DE SUITE !");
                s = s.Replace("Allora, <E049><E003 8><E025 2>if everybody wants to see, <E049><E003 8><E025 1>then I-a do it!", "Allora, <E049><E003 8><E025 2>si tout le monde veut voir, <E049><E003 8><E025 1>alors je montre !");
                s = s.Replace("Ecco!<E049><E003 10> <E025 2>You see?<E049><E003 10>\r\nIs still very-a visible, <E003 4>ay?", "Ecco !<E049><E003 10> <E025 2>Vous voyez ?<E049><E003 10>\r\nC'est encore très visible, <E003 4>non ?");
                s = s.Replace("That, <E049><E003 8><E239>that <E006>red ring<E005> around your neck?<E049><E003 6><E145 1 0><E118 1 1.2><E003 8>\r\n<E025 2>You got that when you were dragged back to the house?", "Ce... <E049><E003 8><E239>ce <E006>cercle rouge<E005> autour de votre cou ?<E049><E003 6><E145 1 0><E118 1 1.2><E003 8>\r\n<E025 2>Vous avez eu ça quand on vous a ramené à la maison ?");
                s = s.Replace("Si!<E049><E003 12> <E025 2>The capo, <E049><E003 6>sometimes he is-a very rough!<E049><E003 12>\r\n<E025 3>And–", "Si !<E049><E003 12> <E025 2>Le capo, <E049><E003 6>parfois il y va fort !<E049><E003 12>\r\n<E025 3>Et–");
                s = s.Replace("I said zat's enough!", "J'ai dit que ça suffisait !");
                s = s.Replace("Peppino's neck <E049><E003 8><E025 2>is nothing to do wiz what we are talking\r\nabout 'ere.<E049><E003 10> <E145 80 67><E003 15><E025 3>You 'ave my word.", "Le cou de Peppino <E049><E003 8><E025 2>n'a absolument aucun rapport avec ce dont nous\r\nparlons ici.<E049><E003 10> <E145 80 67><E003 15><E025 3>Vous avez ma parole.");
                s = s.Replace("Hm, <E003 8><E169 15 3>yes...<E003 15><E145 15 7>\r\n<E025 2>What is your opinion, <E003 6>Counsel?", "Hm, <E003 8><E169 15 3>oui...<E003 15><E145 15 7>\r\n<E025 2>Quel est votre avis, <E003 6>maître ?");
                s = s.Replace("(About this red ring around Mr de Rossi's neck?<E003 10>\r\n<E025 3>I wonder...<E003 10> <E025 2>Does it matter?)", "(À propos de cette marque rouge autour du cou de monsieur de Rossi ?<E003 10>\r\n<E025 3>Je me demande... <E003 10><E025 2>est-ce que cela a son importance ?)");
                return s;
            };

            // [44] BB\script\output\_sce03_c106_0010_eng#19
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rossi!<E049><E003 12>\r\n<E025 2>I'm going to have to ask you...", "Monsieur de Rossi !<E049><E003 12>\r\n<E025 2>Je vais devoir vous demander...");
                s = s.Replace("...to amend your testimony with details about that mark\r\non your neck!", "...de modifier votre déposition en y ajoutant les détails sur cette marque\r\nà votre cou !");
                s = s.Replace("Ay, <E003 8>capo?<E049><E003 10> You see?<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81><E025 2>Everyone is interested in what I say, <E003 6>uh?", "Tu vois, <E003 8>capo ?<E049><E003 10> Tu as vu ?<E049><E003 10>\r\n<E164 81 81 1 2 6 0 0 1><E139 81><E025 2>Tout le monde s'intéresse à ce que je dis, <E003 6>hein ?");
                s = s.Replace("Uuugh...", "Uuuugh...");
                s = s.Replace("Very well.<E049><E003 8> <E025 2>You will amend you testimony as requested,<E003 6>\r\nMr de Rossi.", "Très bien.<E049><E003 8> <E025 2>Vous allez modifier votre témoignage comme demandé,<E003 6>\r\nmonsieur de Rossi.");
                s = s.Replace("Si <E049><E003 8>si, <E049><E003 12><E025 1>if you really want-a to know!", "Si, <E049><E003 8>si, <E049><E003 12><E025 1>si vous voulez vraiment savoir !");
                return s;
            };

            // [45] BB\script\output\_sce03_c106_0010_eng#20
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("(I don't suppose there's any cause for alarm.<E049><E003 12>\r\n<E025 2><E333>I'm sure it'll heal up in time.)", "(Je suppose qu'il n'y a pas lieu de s'alarmer.<E049><E003 12>\r\n<E025 2><E333>Je suis certain que ça va guérir avec le temps.)");
                s = s.Replace("I'm not quite sure that's what His Lordship meant,<E003 6>\r\nMr Naruhodo.", "Je ne suis pas tout à fait certaine que ce soit ce que Son Honneur sous-entendait,<E003 6>\r\nmonsieur Naruhodo.");
                s = s.Replace("So!<E049><E003 10> <E025 2>If you have-a seen enough, <E049><E003 8><E025 2>then I go back to what I\r\nwas-a saying before.", "Alors !<E049><E003 10> <E025 2>Si vous en avez assez vu, <E049><E003 8><E025 2>je retourne à ce que\r\nje disais avant.");
                return s;
            };

            // [46] BB\script\output\_sce03_c106_0010_eng#21
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rousseau!<E003 10>\r\nIs something wrong?", "Monsieur de Rousseau !<E003 10>\r\nQuelque chose ne va pas ?");
                s = s.Replace("I was just considering something.", "J'étais simplement en train de réfléchir.");
                s = s.Replace("About the testimony?<E049><E003 10>\r\nDid something that was just said jar with you?", "Au sujet de la déposition ?<E049><E003 10>\r\nQuelque chose qui vient d'être dit vous a contrarié ?");
                s = s.Replace("Non.<E049><E003 12> <E025 2><E330>I was considering my next cunning plan.", "Non.<E049><E003 12> <E025 2><E330>Je songeais à mon prochain plan de génie.");
                s = s.Replace("Fantastico, capo!<E049><E003 14><E025 1><E346> The Hairlarious Brothers are-a gonna be\r\nback in action, <E003 6><E025 2>ay?", "Fantastico, capo !<E049><E003 14><E025 1><E346> Les Frères Hilaroux vont reprendre\r\ndu service, <E003 6><E025 2>hein ?");
                s = s.Replace("I sink my next enterprise will be an exclusive club\r\ncalled...<E003 10><E025 3><E043>ze Four-Eyed League!", "Je songe que ma prochaine entreprise sera un club très sélect\r\nnommé... <E003 10><E025 3><E043>la Ligue des Binoclards !");
                s = s.Replace("...Kindly discuss your upcoming criminal activities once\r\nyou're back in your cell.", "...Ayez l'amabilité de discuter de vos futurs délits une fois\r\nde retour dans votre cellule.");
                return s;
            };

            // [47] BB\script\output\_sce03_c106_0010_eng#22
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rossi!<E049><E003 10>\r\nDo you have something to say?", "Monsieur de Rossi !<E049><E003 10>\r\nAvez-vous quelque chose à ajouter ?");
                s = s.Replace("Che?<E003 8> What?", "Che ?<E003 8> Quoi ?");
                s = s.Replace("You looked as though you were thinking something...<E003 10>\r\n<E341>whilst eating a mouthful of pasta.", "Vous aviez l'air de méditer sur quelque chose...<E003 10>\r\n<E341>tout en engloutissant une bouchée de pâtes.");
                s = s.Replace("Ah, <E003 8>si.<E003 10> <E025 2>I was-a thinking...", "Ah, <E003 8>si.<E003 10> <E025 2>J'étais en train de me dire...");
                s = s.Replace("...perhaps my hair is this-a colour because I eat too much\r\nBolognese sauce.", "...que mes cheveux sont peut-être de cette couleur parce que je mange trop\r\nde sauce bolognaise.");
                s = s.Replace("...No comment.", "...Sans commentaire.");
                return s;
            };

            // [48] BB\script\output\_sce03_c106_0010_eng#29
            entryTranslators[@"BB\script\output\_sce03_c106_0010_eng#29"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour forger une\r\nopinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront point divulguées au grand public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Néanmoins, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle <E049><E003 8><E025 3>ou dans tout autre prétoire.");
                s = s.Replace("B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de cette\r\ncour, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };

            // [49] BB\script\output\_sce03_c106_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c106_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So the day before his body was discovered, <E049><E003 5><E145 1 0><E118 1 1.4><E003 10><E025 3>Inspector\r\nGregson was taken prisoner while working incognito...", "Ainsi donc, la veille de la découverte de son corps, <E049><E003 5><E145 1 0><E118 1 1.4><E003 10><E025 3>l'inspecteur\r\nGregson a été fait prisonnier alors qu'il opérait sous couverture...");
                s = s.Replace("Non non!<E049><E003 16> It was not like zat!<E049><E003 10> <E025 2>It was 'ardly <E006>a prison<E005>.<E049><E003 10>\r\n<E025 3>It was an...<E003 10><E025 2><E006>invitation to stay<E005>.<E049><E003 4> <E145 80 64><E118 80 0.7><E003 10><E025 2><E341>It was <E006>'omely<E005>.", "Non non !<E049><E003 16> Ce n'était pas ainsi !<E049><E003 10> <E025 2>Ce n'était guère <E006>une prison<E005>.<E049><E003 10>\r\n<E025 3>C'était une... <E003 10><E025 2><E006>invitation à séjourner<E005>.<E049><E003 4> <E145 80 64><E118 80 0.7><E003 10><E025 2><E341>C'était <E006>chaleureux<E005>.");
                s = s.Replace("However you describe it, <E049><E003 10><E145 1 7><E330>there's one glaring\r\n<E006>inconsistency<E005> that remains.", "Peu importe la manière dont vous le décrivez, <E049><E003 10><E145 1 7><E330>il subsiste une\r\n<E006>incohérence<E005> flagrante.");
                s = s.Replace("What inconsistency is this, <E003 4>Counsel?", "De quelle incohérence s'agit-il, <E003 4>maître ?");
                s = s.Replace("I would ask the court to look closely at this photograph\r\nof the victim, <E049><E003 6>Inspector Gregson.", "Je demande à la cour d'examiner attentivement cette photographie\r\nde la victime, <E049><E003 6>l'inspecteur Gregson.");
                s = s.Replace("You will see...<E003 15><E298 22 1 0><E294><E025 2><E330>that there is no red ring visible around his\r\nneck!", "Vous constaterez... <E003 15><E298 22 1 0><E294><E025 2><E330>qu'il n'y a aucun cercle rouge visible autour\r\nde son cou !");
                s = s.Replace("Eh?!<E049><E003 12> <E025 1>But, <E049><E003 10><E341>but that-a makes no sense!", "Hein ?!<E049><E003 12> <E025 1>Mais... <E049><E003 10><E341>mais ça n'a aucun sens !");
                s = s.Replace("It was me <E145 81 64><E118 81 0.5><E149 81 0 3>who took-a the collare off the man in the\r\nmorning.", "C'est moi <E145 81 64><E118 81 0.5><E149 81 0 3>qui ai retiré le collier à cet homme au\r\nmatin !");
                s = s.Replace("And I saw the red bruises on his-a neck, <E049><E003 8><E025 1>just like I have!", "Et j'ai vu les marques rouges sur son cou, <E049><E003 8><E025 1>exactement comme sur le mien !");
                s = s.Replace("Given that <E145 1 85>the mark is still clearly visible on this\r\nwitness's neck...", "Étant donné que <E145 1 85>la marque est encore nettement visible au cou\r\nde ce témoin...");
                s = s.Replace("...we'd expect to see <E006>bruising<E005> on the victim, <E049><E003 8>who was put\r\nin the collar <E006>more recently<E005> than Mr de Rossi!", "...nous devrions voir des <E006>hématomes<E005> sur la victime, <E049><E003 8>qui a porté\r\nle collier <E006>plus récemment<E005> que monsieur de Rossi !");
                s = s.Replace("I-<E003 8><E025 2>Indeed!<E049><E003 15>\r\n<E338><E341><E145 15 5><E117 15 10>That is most peculiar...", "E-<E003 8><E025 2>En effet !<E049><E003 15>\r\n<E338><E341><E145 15 5><E117 15 10>Voilà qui est des plus singulier...");
                s = s.Replace("But what we-a tell you, <E049><E003 8><E025 2>uh?<E049><E003 12> <E025 2><E341>Uh?", "Mais qu'est-ce qu'on vous tue à vous dire, <E049><E003 8><E025 2>hein ?<E049><E003 12> <E025 2><E341>Hein ?");
                s = s.Replace("We say this...<E049><E003 12>from-a the beginning...<E049><E003 15>\r\n<E145 81 73><E118 81 1.5><E025 1><E045>Many times!<E049><E003 10> Uèèèèèèèèèèèè!", "On vous le répète... <E049><E003 12>depuis le début...<E049><E003 15>\r\n<E145 81 73><E118 81 1.5><E025 1><E045>Plein de fois !<E049><E003 10> Ouaaaaaaaaaah !");
                s = s.Replace("Oui, <E049><E003 8><E025 3>Peppino is right.<E049><E003 10>\r\nZe man in ze photograph...", "Oui, <E049><E003 8><E025 3>Peppino a raison.<E049><E003 10>\r\nL'homme sur la photo...");
                s = s.Replace("...'e is <E006>someone different<E005> to ze man we 'eld captive zat\r\nniiiiiiiiight!", "...il est <E006>quelqu'un de différent<E005> de l'homme que nous avons retenu cette\r\nnuuuuuuuit-là !");
                s = s.Replace("Ordaaar!<E003 5> Ordaaar!<E003 5> Ordaaaaaar!!!", "Du caaaalme !<E003 5> Du caaaalme !<E003 5> Du caaaalme !!!");
                s = s.Replace("It would appear then, <E049><E003 8><E025 2>that on the day before the incident...", "Il semblerait donc <E049><E003 8><E025 2>que la veille des faits...");
                s = s.Replace("...the man who visited the park on Lime Street posing as\r\nan incognito inspector...", "...l'individu qui s'est rendu au parc de Lime Street en se faisant\r\npasser pour un inspecteur incognito...");
                s = s.Replace("...was not Inspector Gregson at all!", "...n'était absolument pas l'inspecteur Gregson !");
                s = s.Replace("If that's true, <E049><E003 8>however, <E049><E003 5><E060 0 137 1 0><E346><E025 1>how do you explain the inspector's\r\nidentification?", "Mais si cela est vrai, <E049><E003 8>cependant, <E049><E003 5><E060 0 137 1 0><E346><E025 1>comment expliquez-vous la présence de la carte\r\nd'identité de l'inspecteur ?");
                s = s.Replace("This is a genuine identification book, <E003 6>issued by Scotland\r\nYard.", "Il s'agit d'un carnet d'identité authentique, <E003 6>délivré par Scotland\r\nYard.");
                s = s.Replace("It's inconceivable that someone could have stolen such an\r\nimportant item from the inspector.", "Il est inconcevable que quiconque ait pu dérober une pièce aussi\r\nessentielle à l'inspecteur.");
                s = s.Replace("The prosecution made that assertion itself!", "L'accusation l'a elle-même affirmé !");
                s = s.Replace("And we also know <E049><E003 8><E025 2>that the inspector had made a note\r\nabout the Red-Headed League in his diary for that day.", "Et nous savons également <E049><E003 8><E025 2>que l'inspecteur avait mentionné\r\nla Ligue des Rouquins dans son carnet pour ce jour-là.");
                s = s.Replace("Which surely means <E049><E003 8>we can't divorce the two events\r\ncompletely.", "Ce qui signifie <E049><E003 8>que nous ne pouvons dissocier totalement\r\nces deux événements.");
                s = s.Replace("<E006>The inconsistency<E005> noted <E145 15 5>by the defence is most troubling.", "<E006>L'incohérence<E005> soulevée <E145 15 5>par la défense est des plus troublantes.");
                s = s.Replace("If it were the real Inspector Gregson whom these two\r\nred-headed gentleman encountered...", "S'il s'agissait du véritable inspecteur Gregson qu'ont rencontré ces deux\r\ngentilshommes roux...");
                s = s.Replace("...the fact that <E006>no bruising<E005> can be seen around his neck\r\ndefies explanation.", "...le fait <E006>qu'aucune ecchymose<E005> n'apparaisse autour de son cou\r\ndéfie toute explication.");
                s = s.Replace("But equally, <E049><E003 8><E025 2>if they actually encountered an imposter...", "Mais tout autant, <E049><E003 8><E025 2>s'ils ont eu affaire à un imposteur...");
                s = s.Replace("...how did that person come to be in possession of the real\r\ninspector's <E006>identification<E005>?", "...comment cet individu s'est-il retrouvé en possession de la véritable\r\n<E006>carte d'identité<E005> de l'inspecteur ?");
                s = s.Replace("Does the defence <E145 15 5>have some plausible explanation,<E003 4>\r\nCounsel?", "La défense aurait-elle <E145 15 5>une explication plausible à nous fournir,<E003 4>\r\nmaître ?");
                s = s.Replace("(The whole thing defies explanation.)", "(Toute cette affaire dépasse l'entendement.)");
                s = s.Replace("It is for precisely these occasions <E049><E003 8><E025 2><E164 9 13 1 2 7 0 0 1><E139 9>that we keep meticulous\r\nnotes in the Court Record, <E003 4>Mr Naruhodo.", "C'est précisément pour ces occasions <E049><E003 8><E025 2><E164 9 13 1 2 7 0 0 1><E139 9>que nous consignons méticuleusement\r\nchaque détail dans le dossier de l'affaire, <E003 4>monsieur Naruhodo.");
                s = s.Replace("Because those are the facts, <E049><E003 4><E164 9 15 1 2 6 0 0 1><E139 9>and the facts cannot lie!", "Car ce sont là les faits, <E049><E003 4><E164 9 15 1 2 6 0 0 1><E139 9>et les faits ne mentent jamais !");
                s = s.Replace("(No, <E003 8><E025 3>the facts can't lie...)", "(Non, <E003 8><E025 3>les faits ne peuvent mentir...)");
                s = s.Replace("(...even when they point to something so incredible,<E003 10> it's\r\n<E006>almost unbelievable<E007>!)", "(...même lorsqu'ils pointent vers quelque chose de si incroyable<E003 10> que c'en est\r\n<E006>presque inconcevable<E007> !)");
                s = s.Replace("Well, <E049><E003 4>My Lord, <E049><E003 8>the true identity of the person who turned\r\nup in the park for the Red-Headed League's enrolment...", "Eh bien, <E049><E003 4>Votre Honneur, <E049><E003 8>la véritable identité de la personne venue\r\ndans le parc pour l'inscription à la Ligue des Rouquins...");
                s = s.Replace("...is revealed by information in the Court Record, <E049><E003 6>I\r\nbelieve.", "...nous est révélée par les éléments du dossier de l'affaire, <E049><E003 6>j'en\r\nsuis convaincu.");
                s = s.Replace("Good <E003 6>gracious!", "Bonté <E003 6>divine !");
                return s;
            };

            // [50] BB\script\output\_sce03_c106_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c106_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Very tantalising, <E049><E003 6><E025 2>Mr Naruhodo.", "Voilà qui est bien intrigant, <E049><E003 6><E025 2>monsieur Naruhodo.");
                s = s.Replace("So, why don't you help us all to see <E049><E003 6><E145 112 6><E003 6><E330>whatever truth it is\r\nthat you've apparently seen?", "Alors, pourquoi ne pas nous éclairer <E049><E003 6><E145 112 6><E003 6><E330>sur cette vérité\r\nque vous semblez avoir découverte ?");
                return s;
            };

            // [51] BB\script\output\_sce03_c106_0030_eng#3
            entryTranslators[@"BB\script\output\_sce03_c106_0030_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Who exactly was this ‘inspector’ that appeared before\r\nMr de Rousseau and Mr de Rossi?", "Qui était exactement cet « inspecteur » qui s'est présenté devant\r\nmonsieur de Rousseau et monsieur de Rossi ?");
                return s;
            };

            // [52] BB\script\output\_sce03_c106_0030_eng#4
            entryTranslators[@"BB\script\output\_sce03_c106_0030_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Obviously <E049><E003 8><E025 2>there's nothing to deliberate here.<E049><E003 12>\r\n<E338><E341><E025 1>It was Inspector Gregson himself!", "À l'évidence, <E049><E003 8><E025 2>il n'y a pas matière à débattre.<E049><E003 12>\r\n<E338><E341><E025 1>C'était l'inspecteur Gregson en personne !");
                s = s.Replace("There's no other explanation, <E049><E003 8><E025 1><E164 1 8 1 2 8 1 2 1><E139 1>since he was in possession\r\nof genuine Scotland Yard identification!", "Il n'y a pas d'autre explication, <E049><E003 8><E025 1><E164 1 8 1 2 8 1 2 1><E139 1>puisqu'il était en possession\r\nd'une véritable carte de Scotland Yard !");
                s = s.Replace("In that case, <E049><E003 12><E145 112 0><E118 112 1.3><E238><E025 2>I believe I speak for everyone here present\r\nwhen I ask...", "Dans ce cas, <E049><E003 12><E145 112 0><E118 112 1.3><E238><E025 2>je crois être la voix de toutes les personnes ici présentes\r\nen posant cette question...");
                s = s.Replace("...how do you explain the lack of bruising around the\r\nvictim's neck, <E049><E003 8><E025 3>which you yourself brought up?", "...comment expliquez-vous l'absence d'ecchymoses autour du cou\r\nde la victime, <E049><E003 8><E025 3>que vous avez vous-même soulevée ?");
                s = s.Replace("Ah, <E003 6>yes...<E049><E003 12><E025 2>that is the burning unresolved question, <E003 4>isn't it?", "Ah, <E003 6>oui... <E049><E003 12><E025 2>c'est la question brûlante restée sans réponse, <E003 4>n'est-ce pas ?");
                s = s.Replace("You claim there's nothing to deliberate, <E003 4>Counsel.<E049><E003 12>\r\nHowever...", "Vous affirmez qu'il n'y a rien à débattre, <E003 4>maître.<E049><E003 12>\r\nNéanmoins...");
                s = s.Replace("...I would implore you give your answers a little more\r\nthought in future!", "...je vous exhorte à réfléchir davantage à vos réponses à l'avenir !");
                s = s.Replace("(It's possible I oversimplified that...)", "(Il se peut que j'aie un peu trop simplifié la chose...)");
                s = s.Replace("It seems to me <E049><E003 8><E025 2><E333>that the lack of bruising around the\r\nvictim's neck is the hardest discrepancy to reconcile.", "Il me semble <E049><E003 8><E025 2><E333>que l'absence de marques au cou de la victime\r\nest la contradiction la plus difficile à concilier.");
                s = s.Replace("Yes, <E003 6>I...<E003 10><E025 1><E346>think I can see how to tackle this now...", "Oui, <E003 6>je... <E003 10><E025 1><E346>je crois voir comment aborder le problème à présent...");
                return s;
            };

            // [53] BB\script\output\_sce03_c106_0030_eng#5
            entryTranslators[@"BB\script\output\_sce03_c106_0030_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Though it seems incredible, <E049><E003 6><E025 3>I admit, <E049><E003 8>the undeniable facts\r\npoint to only one thing:", "Bien que cela semble inconcevable, <E049><E003 6><E025 3>je l'admets, <E049><E003 8>les faits indiscutables\r\nne pointent que vers une seule conclusion :");
                s = s.Replace("Since no bruising can be seen on the victim's neck...", "Puisqu'aucune ecchymose n'est visible sur le cou de la victime...");
                s = s.Replace("...the person who these two red-headed men took\r\nprisoner that day <E049><E003 5><E145 1 0><E118 1 1.2><E003 15><E330><E025 3>cannot have been Inspector Gregson.", "...la personne que ces deux hommes roux ont faite prisonnière\r\nce jour-là <E049><E003 5><E145 1 0><E118 1 1.2><E003 15><E330><E025 3>ne peut en aucun cas être l'inspecteur Gregson.");
                s = s.Replace("In other words, <E049><E003 10><E025 2>your whole argument up to now <E049><E003 8><E025 3>has been\r\n<E006>a waste of time<E005>.", "Autrement dit, <E049><E003 10><E025 2>toute votre argumentation jusqu'ici <E049><E003 8><E025 3>n'a été qu'une\r\n<E006>pure perte de temps<E005>.");
                s = s.Replace("On the contrary.<E049><E003 12> <E025 3>I haven't finished.", "Bien au contraire.<E049><E003 12> <E025 3>Je n'ai pas terminé.");
                s = s.Replace("There's no bruising on the victim's neck, <E049><E003 6><E145 1 85><E003 10><E025 3>so the question\r\nimmediately posed next is...", "Il n'y a pas d'ecchymoses au cou de la victime, <E049><E003 6><E145 1 85><E003 10><E025 3>la question qui\r\nse pose immédiatement ensuite est donc la suivante...");
                s = s.Replace("...who exactly was this man in the park on Lime Street\r\nfound to be carrying Inspector Gregson's identification?", "...qui était exactement cet homme trouvé dans le parc de Lime Street\r\nen possession de la carte d'identité de l'inspecteur Gregson ?");
                s = s.Replace("Si...<E049><E003 8> <E025 1><E164 81 75 1 2 1 0 2 1><E118 81 1.5><E139 81>Si!<E049><E003 10> <E025 1>That's-a right!<E049><E003 12>\r\n<E338><E341>We tell the same story every time:", "Si...<E049><E003 8> <E025 1><E164 81 75 1 2 1 0 2 1><E118 81 1.5><E139 81>Si !<E049><E003 10> <E025 1>C'est exact !<E049><E003 12>\r\n<E338><E341>On raconte la même histoire à chaque fois :");
                s = s.Replace("Whoever this man was, <E049><E003 8><E164 81 74 1 2 5 0 3 1><E118 81 1.2><E149 81 2 4><E139 81><E025 1>the capo dragged him from-a\r\npillar to-a post with the dog collare!", "Qui que fût cet homme, <E049><E003 8><E164 81 74 1 2 5 0 3 1><E118 81 1.2><E149 81 2 4><E139 81><E025 1>le capo l'a traîné d'un\r\nbout à l'autre avec le collier de chien !");
                s = s.Replace("Mon Dieu, Peppino!<E049><E003 10> <E025 1><E049><E003 8><E045><E145 80 75><E117 80 10><E149 80 1 1>I was not so 'arsh as you say, <E003 6><E025 2>uh?", "Mon Dieu, Peppino !<E049><E003 10> <E025 1><E049><E003 8><E045><E145 80 75><E117 80 10><E149 80 1 1>Je n'ai pas été si cruel que tu le dis, <E003 6><E025 2>voyons !");
                s = s.Replace("So who was that-a falso inspector, <E049><E003 6><E025 2>ay?<E049><E003 10>\r\n<E136 81 67 3><E117 81 3><E139 81><E025 1><E346>Who was he?!", "Alors qui c'était, ce faux inspecteur, <E049><E003 6><E025 2>hein ?<E049><E003 10>\r\n<E136 81 67 3><E117 81 3><E139 81><E025 1><E346>Qui c'était ?!");
                s = s.Replace("Clearly <E049><E003 8><E025 2>the defence has an idea about that.", "Visiblement, <E049><E003 8><E025 2>la défense a une idée sur la question.");
                s = s.Replace("About the true identity of the man these two imprisoned\r\nthat night...", "Sur la véritable identité de l'homme que ces deux-là ont enfermé\r\ncette nuit-là...");
                return s;
            };

            // [54] BB\script\output\_sce03_c106_0030_eng#6
            entryTranslators[@"BB\script\output\_sce03_c106_0030_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour forger une\r\nopinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront point divulguées au grand public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Néanmoins, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle <E049><E003 8><E025 3>ou dans tout autre prétoire.");
                s = s.Replace("B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de cette\r\ncour, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };
        }
    }
}
