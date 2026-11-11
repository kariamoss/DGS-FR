using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act4 {
    public partial class Program {
        public static void RegisterPart3() {
            // [55] BB\script\output\_sce03_c106_0040_eng#2
            entryTranslators[@"BB\script\output\_sce03_c106_0040_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I must ask <E145 15 5>the counsel for the defence to elaborate\r\nposthaste.", "Je dois demander <E145 15 5>au conseil de la défense de s'expliquer\r\nsans délai.");
                return s;
            };

            // [56] BB\script\output\_sce03_c106_0040_eng#3
            entryTranslators[@"BB\script\output\_sce03_c106_0040_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Who did the witnesses encounter in the park <E049><E003 8><E025 1><E338>posing as\r\nInspector Gregson?", "Qui les témoins ont-ils croisé dans le parc <E049><E003 8><E025 1><E338>se faisant passer pour\r\nl'inspecteur Gregson ?");
                return s;
            };

            // [57] BB\script\output\_sce03_c106_0040_eng#4
            entryTranslators[@"BB\script\output\_sce03_c106_0040_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("It's surely no secret!<E049><E003 8>\r\n<E025 1><E145 1 7><E003 10><E346>THIS is the identity of the imposter!", "Ce n'est assurément pas un secret !<E049><E003 8>\r\n<E025 1><E145 1 7><E003 10><E346>VOICI l'identité de l'imposteur !");
                s = s.Replace("...Oh really?<E049><E003 10>\r\n<E025 2><E145 112 13><E144 112><E330>On what grounds?", "... Ah vraiment ?<E049><E003 10>\r\n<E025 2><E145 112 13><E144 112><E330>Et sur quoi vous basez-vous ?");
                s = s.Replace("<E341>Well...<E003 10><E025 2>I said it was no secret, <E049><E003 8><E025 3>but...<E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1><E092 2>that part is!", "<E341>Eh bien...<E003 10><E025 2> j'ai dit que ce n'était pas un secret, <E049><E003 8><E025 3>mais...<E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1><E092 2>cette partie-là l'est !");
                s = s.Replace("Dear me.<E049><E003 10><E025 2> If ever a penalty was in order, <E049><E003 8>it's now, I feel.", "Miséricorde.<E049><E003 10><E025 2> Si jamais une pénalité s'imposait, <E049><E003 8>je crains que ce soit maintenant.");
                s = s.Replace("<E333>Like-a the punishment?<E049><E003 10> <E145 81 76><E025 1><E338><E341>The capo can lend you his collare\r\nif you want, <E003 6><E025 2>uh?", "<E333>Comme une punition ?<E049><E003 10> <E145 81 76><E025 1><E338><E341>Le capo peut vous prêter son collare\r\nsi vous voulez, <E003 6><E025 2>hein ?");
                s = s.Replace("Perhaps my learned friend needs to experience what it\r\nfeels like to be dragged around the streets by the neck?", "Mon confrère a peut-être besoin d'expérimenter ce que\r\nl'on ressent à être traîné dans les rues par le cou ?");
                s = s.Replace("<E331>...I'll use my imagination, <E049><E003 6>thanks.", "<E331>... Je ferai plutôt appel à mon imagination, <E049><E003 6>merci.");
                s = s.Replace("Well, Mr Naruhodo, <E049><E003 8><E025 2>the red ring produced by the collar is\r\nclearly the crux of the matter here...", "Eh bien, M. Naruhodo, <E049><E003 8><E025 2>la marque rouge laissée par le collier est\r\nmanifestement le nœud du problème ici...");
                s = s.Replace("(Yes, <E003 8>the bruising around the neck...)", "(Oui, <E003 8>l'ecchymose autour du cou...)");
                return s;
            };

            // [58] BB\script\output\_sce03_c106_0040_eng#5
            entryTranslators[@"BB\script\output\_sce03_c106_0040_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("<E333>Goodness me!<E049><E003 12> <E025 3>Isn't...<E003 12><E025 3><E341>isn't that...?", "<E333>Bonté divine !<E049><E003 12> <E025 3>N'est-ce pas...<E003 12><E025 3><E341> n'est-ce pas... ?");
                s = s.Replace("One of the witnesses who was in the stand in this very\r\ncourtroom earlier today!", "L'un des témoins qui se tenait à la barre dans ce même\r\ntribunal plus tôt aujourd'hui !");
                s = s.Replace("A nameless man, <E049><E003 8><E025 2><E330>whose only occupation appears to be\r\npeddling hearsay to passers-by.", "Un homme anonyme, <E049><E003 8><E025 2><E330>dont l'unique occupation semble être\r\nde colporter des ragots aux passants.");
                s = s.Replace("What on earth would a street seller be doing with a\r\npolice inspector's identification papers?", "Que diable ferait un camelot de rue avec la carte\r\nd'identité d'un inspecteur de police ?");
                s = s.Replace("Witnesses!<E049><E003 12> Is this the man or not?!", "Témoins !<E049><E003 12> Est-ce bien cet homme ou non ?!");
                s = s.Replace("<E330>What 'as 'appened to 'is lip?", "<E330>Qu'est-il arrivé à sa lèvre ?");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("Si, <E049><E003 8>this-a man is not for the Red-Headed League, <E003 6>ay?<E049><E003 5>\r\n<E164 81 70 1 2 7 0 0 1><E139 81>He's-a looking for the Twisted Lip League, <E049><E003 4><E164 81 81 1 2 6 0 0 1><E139 81>no?", "Si, <E049><E003 8>cet homme-là n'est pas pour la Ligue des Rouquins, <E003 6>hein ?<E049><E003 5>\r\n<E164 81 70 1 2 7 0 0 1><E139 81>Il cherche plutôt la Ligue de la Lèvre Tordue, <E049><E003 4><E164 81 81 1 2 6 0 0 1><E139 81>non ?");
                s = s.Replace("Perhaps rather than making such a rash claim next time...<E049><E003 10>\r\n<E145 112 15><E003 15><E238><E025 3>you should bite your lip instead.", "Peut-être qu'au lieu d'avancer une telle absurdité la prochaine fois...<E049><E003 10>\r\n<E145 112 15><E003 15><E238><E025 3>vous devriez plutôt vous mordre la lèvre.");
                s = s.Replace("It seems improbable, <E049><E003 6>yes.<E049><E003 15>\r\n<E025 2>But one undeniable fact remains!", "Cela paraît improbable, <E049><E003 6>oui.<E049><E003 15>\r\n<E025 2>Mais un fait indéniable demeure !");
                s = s.Replace("During his testimony earlier...", "Durant son témoignage tout à l'heure...");
                s = s.Replace("...I noted something around the man's neck:<E049><E003 16>\r\n<E025 1><E346><E006>a red ring<E005> of bruising!", "... j'ai remarqué quelque chose autour du cou de cet homme :<E049><E003 16>\r\n<E025 1><E346><E006>un cercle rouge<E005> d'ecchymoses !");
                s = s.Replace("Eh?", "Hein ?");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("The defence demands <E049><E003 15><E145 1 7><E117 1 4><E549 7 21 3 1><E131><E025 1><E046>that Mr Gossip be brought back to\r\nthe stand!", "La défense exige <E049><E003 15><E145 1 7><E117 1 4><E549 7 21 3 1><E131><E025 1><E046>que M. Ragot soit rappelé à\r\nla barre !");
                s = s.Replace("Ordaaar!<E003 4> Orrrdaaar!<E049><E003 20>\r\n<E345><E145 15 7>...Bailiff!", "Du caaalme !<E003 4> Du caaalme !<E049><E003 20>\r\n<E345><E145 15 7>... Huissier !");
                s = s.Replace("Bring the aforementioned witness back into the\r\ncourtroom!", "Ramenez le témoin susmentionné dans la\r\nsalle d'audience !");
                s = s.Replace("Immediately!", "Immédiatement !");
                return s;
            };

            // [59] BB\script\output\_sce03_c106_0040_eng#6
            entryTranslators[@"BB\script\output\_sce03_c106_0040_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu bien assez de preuves pour me forger\r\nune opinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "Puisqu'il s'agit d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront pas divulguées au public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Toutefois, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Fossoyeur comparaît\r\ndans cette salle d'audience <E049><E003 8><E025 3>ou dans toute autre.");
                s = s.Replace("<E341>B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "<E341>M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de ce\r\ntribunal, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };

            // [60] BB\script\output\_sce03_c107_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c107_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Well I never...", "Ça alors...");
                s = s.Replace("An undeniable ring of bruising indeed.", "Un cercle d'ecchymoses tout à fait indéniable.");
                s = s.Replace("And identical...<E049><E003 12><E144 15><E025 2><E145 15 3><E331>to that of the witness beside him!", "Et identique...<E049><E003 12><E144 15><E025 2><E145 15 3><E331>à celui du témoin à ses côtés !");
                s = s.Replace("Now what's going on here, <E003 6>eh?", "Qu'est-ce qui se passe ici, <E003 6>hein ?");
                s = s.Replace("I've always had this, <E003 6>me.<E049><E003 10>\r\n<E025 2><E330>It's a birthmark, <E003 4>in't it?", "J'ai toujours eu ça, <E003 6>moi.<E049><E003 10>\r\n<E025 2><E330>C'est une tache de naissance, <E003 4>pardi !");
                s = s.Replace("A birthmark, <E049><E003 6>you say?", "Une tache de naissance, <E049><E003 6>dites-vous ?");
                s = s.Replace("I assume <E049><E003 4><E145 112 13><E118 112 2.0><E003 4><E025 2>the reason you've been recalled to the stand\r\nhas been explained to you?", "Je présume <E049><E003 4><E145 112 13><E118 112 2.0><E003 4><E025 2>que la raison de votre rappel à la barre\r\nvous a été expliquée ?");
                s = s.Replace("Aye, <E049><E003 8>um...<E003 10><E025 2>summat about an inspector again.", "Ouais, <E049><E003 8>euh...<E003 10><E025 2>encore une histoire d'inspecteur.");
                s = s.Replace("But I'm telling you, <E049><E003 10><E145 79 66>you've got it all wrong as usual.", "Mais j'vous le dis, <E049><E003 10><E145 79 66>vous faites fausse route comme d'hab'.");
                s = s.Replace("You're denying all knowledge of it?", "Vous niez en avoir la moindre connaissance ?");
                s = s.Replace("Well of course I am!", "Ben évidemment que oui !");
                s = s.Replace("Are you trying to <E049><E003 10><E164 79 74 1 2 2 0 3 1><E139 79><E025 1>kill me with all this nonsense, eh?", "Vous essayez de me faire <E049><E003 10><E164 79 74 1 2 2 0 3 1><E139 79><E025 1>mourir avec toutes ces sornettes, hein ?");
                s = s.Replace("Well...<E003 10><E025 2>at least you'll have more stories to peddle back on\r\nFresno Street, <E049><E003 6>won't you?", "Eh bien...<E003 10><E025 2> au moins, vous aurez d'autres histoires à colporter\r\nsur Fresno Street, <E049><E003 6>n'est-ce pas ?");
                s = s.Replace("Now, <E049><E003 10>we're going to need you to testify again.", "À présent, <E049><E003 10>nous allons avoir besoin que vous témoigniez à nouveau.");
                s = s.Replace("And you, <E049><E003 8>Mr de Rousseau and Mr de Rossi.<E049><E003 12>\r\n<E025 3><E145 1 21>I'm sure you'll cooperate, <E003 4>won't you?", "Et vous aussi, <E049><E003 8>M. de Rousseau et M. de Rossi.<E049><E003 12>\r\n<E025 3><E145 1 21>Je suis sûr que vous allez coopérer, <E003 4>n'est-ce pas ?");
                s = s.Replace("Do we 'ave any choice?", "Avons-nous vraiment le choix ?");
                s = s.Replace("We are in big-a trouble, <E049><E003 8>ay, <E003 4>capo?", "On est dans de beaux draps, <E049><E003 8>hein, <E003 4>capo ?");
                s = s.Replace("That's quite enough dilatory chatter.<E049><E003 10>\r\n<E025 2><E145 15 5>Proceed with the testimony!", "Assez de tergiversations inutiles.<E049><E003 10>\r\n<E025 2><E145 15 5>Poursuivez avec le témoignage !");
                return s;
            };

            // [61] BB\script\output\_sce03_c107_0010_eng#2
            entryTranslators[@"BB\script\output\_sce03_c107_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Inspector and the Identification Revisited –", "– L'inspecteur et la carte d'identité (suite) –");
                s = s.Replace("Ze man who claimed to be an inspector zat day...<E003 10>\r\n<E025 3>was definitely not zis man.", "L'homme qui prétendait être inspecteur ce jour-là...<E003 10>\r\n<E025 3>n'était certainement pas cet homme.");
                s = s.Replace("Is right, <E049><E003 8><E025 2>si!<E049><E003 12> <E346><E025 1>You think we would-a forget these grand lips,\r\n<E003 6><E025 2>uh?", "C'est vrai, <E049><E003 8><E025 2>si !<E049><E003 12> <E346><E025 1>Vous croyez qu'on oublierait des lèvres pareilles,\r\n<E003 6><E025 2>hein ?");
                s = s.Replace("I never leave Fresno Street, <E049><E003 6>alright?<E049><E003 10>\r\nI've no interest in any Red-Headed League.", "Je quitte jamais Fresno Street, <E049><E003 6>compris ?<E049><E003 10>\r\nJ'ai aucun intérêt pour une Ligue des Rouquins.");
                s = s.Replace("I'm all alone in the world, <E003 6>me.<E049><E003 8> I've no kinfolk or nothing.<E049><E003 10>\r\nWhy would I be involved in something like that?", "J'suis tout seul au monde, <E003 6>moi.<E049><E003 8> J'ai pas de famille, rien.<E049><E003 10>\r\nPourquoi j'irais me mêler d'un truc pareil ?");
                s = s.Replace("Just look at me, <E003 6>eh.<E049><E003 12><E025 1><E346> Doz it look like I could carry off a\r\ndisguise with a face like this?", "Regardez-moi un peu, <E003 6>hein.<E049><E003 12><E025 1><E346> Ça a l'air de pouvoir se déguiser,\r\nune tronche pareille ?");
                return s;
            };

            // [62] BB\script\output\_sce03_c107_0010_eng#3
            entryTranslators[@"BB\script\output\_sce03_c107_0010_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("It would certainly appear <E049><E003 6><E145 15 2><E118 15 1.3>that we have the wrong man.", "Il semblerait assurément <E049><E003 6><E145 15 2><E118 15 1.3>que nous fassions fausse route.");
                s = s.Replace("What 'ave I been telling you, <E003 6>uh?<E049><E003 12>\r\n<E333>Zere was no need for zis pointless testimony.", "Qu'est-ce que je vous disais, <E003 6>hein ?<E049><E003 12>\r\n<E333>Ce témoignage inutile n'avait pas lieu d'être.");
                s = s.Replace("<E341>Uuugh...", "<E341>Grmbl...");
                s = s.Replace("That's right.<E049><E003 10> I'm just a simple pedlar, <E003 6>remember.<E049><E003 10>\r\nFresno Street's all I know.", "C'est bien vrai.<E049><E003 10> J'suis juste un simple camelot, <E003 6>j'vous rappelle.<E049><E003 10>\r\nFresno Street, c'est tout ce que je connais.");
                s = s.Replace("How would I have come by <E049><E003 3><E164 79 69 1 2 8 0 2 1><E139 79><E025 1>a police inspector's\r\nidentification book, <E003 6><E025 2>eh?", "Comment j'aurais pu mettre la main sur <E049><E003 3><E164 79 69 1 2 8 0 2 1><E139 79><E025 1>la carte d'identité\r\nd'un inspecteur de police, <E003 6><E025 2>hein ?");
                s = s.Replace("Well, <E049><E003 8><E025 3>yes, <E049><E003 10>that's hard to explain, <E049><E003 8>but...", "Eh bien, <E049><E003 8><E025 3>oui, <E049><E003 10>c'est difficile à expliquer, <E049><E003 8>mais...");
                s = s.Replace("Hmph.<E003 12> <E169 15 3><E239><E025 2>A brief cross-examination, I think, <E003 6>Counsel.<E049><E003 12>\r\n<E025 3>Very brief.", "Humph.<E003 12> <E169 15 3><E239><E025 2>Un contre-interrogatoire des plus brefs, Maître.<E049><E003 12>\r\n<E025 3>Des plus brefs.");
                s = s.Replace("(<E341>Ugh.<E003 12> Isn't there anyone in this courtroom who thinks I\r\nmight be on to something?)", "(<E341>Pff.<E003 12> N'y a-t-il donc personne dans cette salle qui pense que\r\nje tiens une piste ?)");
                s = s.Replace("I stand steadfastly at your side as always, <E049><E003 4><E164 9 15 1 2 8 0 1 1><E149 9 4 7><E171 9 17 1 1 1><E139 9><E025 1>Mr Naruhodo!", "Je me tiens fermement à vos côtés comme toujours, <E049><E003 4><E164 9 15 1 2 8 0 1 1><E149 9 4 7><E171 9 17 1 1 1><E139 9><E025 1>M. Naruhodo !");
                return s;
            };

            // [63] BB\script\output\_sce03_c107_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Inspector and the Identification Revisited –", "– L'inspecteur et la carte d'identité (suite) –");
                return s;
            };

            // [64] BB\script\output\_sce03_c107_0020_eng#4
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Ze man who claimed to be an inspector zat day...\r\nwas definitely not zis man.", "L'homme qui prétendait être inspecteur ce jour-là...\r\nn'était certainement pas cet homme.");
                return s;
            };

            // [65] BB\script\output\_sce03_c107_0020_eng#5
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Is right, si! You think we would-a forget these grand lips,\r\nuh?", "C'est vrai, si ! Vous croyez qu'on oublierait des lèvres pareilles,\r\nhein ?");
                return s;
            };

            // [66] BB\script\output\_sce03_c107_0020_eng#6
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("I never leave Fresno Street, alright?\r\nI've no interest in any Red-Headed League.", "Je quitte jamais Fresno Street, compris ?\r\nJ'ai aucun intérêt pour une Ligue des Rouquins.");
                return s;
            };

            // [67] BB\script\output\_sce03_c107_0020_eng#7
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Aye, I rent the room where that fella was found, it's true.\r\nFor what difference it makes.", "Ouais, je loue la chambre où ce gars a été trouvé, c'est vrai.\r\nPour ce que ça change.");
                return s;
            };

            // [68] BB\script\output\_sce03_c107_0020_eng#8
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("I'm all alone in the world, me. I've no kinfolk or nothing.\r\nWhy would I be involved in something like that?", "J'suis tout seul au monde, moi. J'ai pas de famille, rien.\r\nPourquoi j'irais me mêler d'un truc pareil ?");
                return s;
            };

            // [69] BB\script\output\_sce03_c107_0020_eng#9
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Just look at me, eh. Doz it look like I could carry off a\r\ndisguise with a face like this?", "Regardez-moi un peu, hein. Ça a l'air de pouvoir se déguiser,\r\nune tronche pareille ?");
                return s;
            };

            // [70] BB\script\output\_sce03_c107_0020_eng#10
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("(That's the extent of their testimony, <E003 6><E025 2>is it?)", "(C'est donc là l'étendue de leur témoignage, <E003 6><E025 2>hein ?)");
                s = s.Replace("What's your feeling, <E049><E003 6>Mr Naruhodo?", "Quelle est votre impression, <E049><E003 6>M. Naruhodo ?");
                s = s.Replace("Well, <E003 8><E025 2>what Mr Gossip says is undeniable:", "Eh bien, <E003 8><E025 2>ce que dit M. Ragot est indéniable :");
                s = s.Replace("Well, <E003 8><E025 2>what Mr Boone says is undeniable:", "Eh bien, <E003 8><E025 2>ce que dit M. Boone est indéniable :");
                s = s.Replace("It would be all but impossible to hide <E003 8><E025 3><E333>those lips with any\r\nform of disguise.", "Il serait quasiment impossible de dissimuler <E003 8><E025 3><E333>de telles lèvres avec\r\nquelque déguisement que ce soit.");
                s = s.Replace("Perhaps, yes...<E049><E003 12> <E025 2>But nevertheless, <E003 6>the mark around his\r\nneck is equally undeniable.", "Peut-être, oui...<E049><E003 12> <E025 2>Néanmoins, <E003 6>la marque autour de son cou\r\nest tout aussi indéniable.");
                s = s.Replace("<E330>And it's identical to the one that Mr de Rossi suffered.", "<E330>Et elle est identique à celle qu'a subie M. de Rossi.");
                s = s.Replace("Yes, <E003 6>that's true...", "Oui, <E003 6>c'est vrai...");
                s = s.Replace("(But why does this whole disguise idea just keep playing\r\non my mind...?)", "(Mais pourquoi cette idée de déguisement continue-t-elle\r\nde me trotter dans la tête... ?)");
                return s;
            };

            // [71] BB\script\output\_sce03_c107_0020_eng#11
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("<E335>So you say.<E049><E003 10> <E025 2>But how can you be quite so certain?", "<E335>C'est ce que vous dites.<E049><E003 10> <E025 2>Mais comment pouvez-vous en être si sûr ?");
                s = s.Replace("Zere is no need to 'urt your 'ands on ze desk, <E003 6><E025 3>monsieur.<E049><E003 10>\r\n<E025 2>Surely ze reason is obvious, <E003 6>non?", "Il n'y a pas besoin de vous faire mal aux mains sur le bureau, <E003 6><E025 3>monsieur.<E049><E003 10>\r\n<E025 2>La raison est pourtant évidente, <E003 6>non ?");
                s = s.Replace("Because <E049><E145 79 69><E003 10><E025 3><E330>I 'ave never before seen lips like zis.", "Parce que <E049><E145 79 69><E003 10><E025 3><E330>je n'ai jamais vu de lèvres pareilles.");
                s = s.Replace("<E335>Nevertheless!<E049><E003 10> There's a clear red mark around\r\nMr Gossip's neck.", "<E335>Néanmoins !<E049><E003 10> Il y a une marque rouge bien nette autour du cou\r\nde M. Ragot.");
                s = s.Replace("<E335>Nevertheless!<E049><E003 10> There's a clear red mark around\r\nMr Boone's neck.", "<E335>Néanmoins !<E049><E003 10> Il y a une marque rouge bien nette autour du cou\r\nde M. Boone.");
                s = s.Replace("And it looks very much like that left behind on the neck\r\nof your colleague by your prized collar!", "Et elle ressemble à s'y méprendre à celle laissée sur le cou\r\nde votre collègue par votre précieux collier !");
                s = s.Replace("Mon Dieu!<E049><E003 14> Wiz your words, <E049><E003 8><E331>it is like you try to wring my\r\nneck!", "Mon Dieu !<E049><E003 14> Avec vos paroles, <E049><E003 8><E331>c'est comme si vous essayiez\r\nde me tordre le cou !");
                s = s.Replace("It does look very much <E049><E003 4><E025 2><E164 81 77 1 2 6 0 0 1><E139 81>like-a my neck though, <E003 6>ay?", "Ça ressemble quand même beaucoup <E049><E003 4><E025 2><E164 81 77 1 2 6 0 0 1><E139 81>à mon cou, <E003 6>non ?");
                s = s.Replace("No no, <E049><E003 8><E025 2>this is a birthmark, lad.", "Non non, <E049><E003 8><E025 2>c'est une tache de naissance, p'tit gars.");
                s = s.Replace("The biggest lips in London and a neck to die for!<E049><E003 10>\r\n<E025 2><E341>Aye, <E049><E003 10><E333><E025 1>they broke the mould when they made me!", "Les plus grosses lèvres de Londres et un cou à tomber par terre !<E049><E003 10>\r\n<E025 2><E341>Ouais, <E049><E003 10><E333><E025 1>ils ont brisé le moule après m'avoir fabriqué !");
                s = s.Replace("For ze first time in my life...", "Pour la première fois de ma vie...");
                s = s.Replace("...I feel lucky <E049><E003 10><E025 3><E330>to 'ave been born wiz red 'air.", "... je me réjouis <E049><E003 10><E025 3><E330>d'être né avec des cheveux roux.");
                s = s.Replace("(And I thought being Japanese made you stand out in\r\nLondon...)", "(Et moi qui croyais qu'être japonais attirait les regards à\r\nLondres...)");
                s = s.Replace("So you maintain that you've never seen this man before?", "Vous maintenez donc que vous n'avez jamais vu cet homme auparavant ?");
                s = s.Replace("Oui, <E049><E003 10><E025 3>c'est ça.<E049><E003 10> <E025 2><E043>I swear to it by ze flames of my 'air.", "Oui, <E049><E003 10><E025 3>c'est ça.<E049><E003 10> <E025 2><E043>Je le jure sur les flammes de ma chevelure.");
                s = s.Replace("(...So fierce pride has outgrown the frustration with your\r\nhair now, <E003 6>has it?)", "(... Ainsi, votre immense fierté a pris le pas sur la frustration envers\r\nvos cheveux, <E003 6>à présent ?)");
                return s;
            };

            // [72] BB\script\output\_sce03_c107_0020_eng#12
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("Well, yes, <E049><E003 8><E025 2>I don't imagine I'll forget those lips in a hurry,\r\neither.", "Eh bien, oui, <E049><E003 8><E025 2>je n'imagine pas non plus oublier ces lèvres\r\nde sitôt.");
                s = s.Replace("That is what I am-a saying.<E049><E003 8> <E025 2>For some reason, <E049><E003 6>it makes me\r\nwanna eat –<E003 6><E025 3> how did Fabien call it? –<E049><E003 8> <E025 2>an ‘éclair’.", "C'est ce que je disais.<E049><E003 8> <E025 2>Pour une raison que j'ignore, <E049><E003 6>ça me donne\r\nenvie de manger...<E003 6><E025 3> comment Fabien appelle ça déjà ?<E049><E003 8> <E025 2>un « éclair ».");
                s = s.Replace("You know, <E049><E003 4><E025 2><E145 81 68><E144 81><E333>I've never seen the hair as black as-a yours\r\nbefore, either.", "Vous savez, <E049><E003 4><E025 2><E145 81 68><E144 81><E333>j'avais jamais vu de cheveux aussi noirs que les vôtres\r\nnon plus.");
                s = s.Replace("<E341>Likewise, <E049><E003 8><E025 2>I'd never seen red hair like yours until I came\r\nto Britain.", "<E341>De même, <E049><E003 8><E025 2>je n'avais jamais vu de cheveux roux comme les vôtres\r\navant de venir en Grande-Bretagne.");
                s = s.Replace("Si, <E049><E003 8><E025 2>maybe is a nationale trait, <E003 4>uh?", "Si, <E049><E003 8><E025 2>c'est peut-être un trait national, <E003 4>hein ?");
                s = s.Replace("Maybe all the people from this-a man's country<E049><E003 6> <E333>have-a\r\nthe grand lips!", "Peut-être que tous les gens du pays de cet homme<E049><E003 6> <E333>ont de\r\ngrandes lèvres pareilles !");
                s = s.Replace("No, lad, <E049><E003 8><E330><E025 2>I was born right here on Fresno Street.<E049><E003 10>\r\nAnd I've never left.", "Non, mon gars, <E049><E003 8><E330><E025 2>j'suis né ici même sur Fresno Street.<E049><E003 10>\r\nEt j'en suis jamais parti.");
                s = s.Replace("Uffa!<E049><E003 8><E025 2> That is-a the problem, <E003 4>si.", "Uffa !<E049><E003 8><E025 2> C'est bien ça le problème, <E003 4>si.");
                s = s.Replace("So you definitely didn't go to the park on Lime Street that\r\nday, <E049><E003 6>Mr Gossip?", "Vous n'êtes donc absolument pas allé dans le parc de Lime Street ce\r\njour-là, <E049><E003 6>M. Ragot ?");
                s = s.Replace("So you definitely didn't go to the park on Lime Street that\r\nday, <E049><E003 6>Mr Boone?", "Vous n'êtes donc absolument pas allé dans le parc de Lime Street ce\r\njour-là, <E049><E003 6>M. Boone ?");
                s = s.Replace("Now how many times do you want me to say it, <E003 6><E025 2>eh?", "Combien de fois vous voulez que j'vous le répète, <E003 6><E025 2>hein ?");
                return s;
            };

            // [73] BB\script\output\_sce03_c107_0020_eng#13
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("So...<E049><E003 8><E145 1 85><E003 8><E025 2>you'd heard of the Red-Headed League, <E003 6>had you?", "Alors...<E049><E003 8><E145 1 85><E003 8><E025 2>vous aviez entendu parler de la Ligue des Rouquins, <E003 6>n'est-ce pas ?");
                s = s.Replace("You don't get a name like ‘Gossip’ for nothing, <E003 4>eh?<E049><E003 10>\r\nIt's my business to know what's going off in town.", "On n'se fait pas appeler « Ragot » pour rien, <E003 4>pas vrai ?<E049><E003 10>\r\nC'est mon métier de savoir tout ce qui se trame en ville.");
                s = s.Replace("I sold that tasty titbit to a fair few red-heads that came\r\npast me.", "J'ai vendu ce savoureux tuyau à un bon paquet de rouquins qui sont\r\npassés devant moi.");
                s = s.Replace("Just between uz, <E049><E003 8><E060 1 60 0 1>I even got Sandwich to cough up for it!", "Soit dit entre nouz, <E049><E003 8><E060 1 60 0 1>j'ai même fait cracher au bassinet l'ami Sandwich !");
                s = s.Replace("Well...<E003 10><E145 9 1>he does have a very red nose, <E049><E003 6>if that counts.", "Eh bien...<E003 10><E145 9 1>il a le nez bien rouge, <E049><E003 6>si ça compte.");
                s = s.Replace("...Who knows?", "... Qui sait ?");
                s = s.Replace("But as you can see, <E049><E003 8>my own hair's not got a hint of red in\r\nit.", "Mais comme vous pouvez le voir, <E049><E003 8>mes propres tifs n'ont pas la moindre touche de roux.");
                s = s.Replace("And in any case, <E049><E025 1><E164 79 69 1 2 6 0 0 1><E139 79>Fresno Street's my patch.", "Et de toute façon, <E049><E025 1><E164 79 69 1 2 6 0 0 1><E139 79>Fresno Street, c'est mon secteur.");
                s = s.Replace("You won't catch me sidling off to some other part of town.<E049><E003 4><E145 79 66><E139 79>\r\n<E025 1>No sir, <E049><E003 8>not likely!", "Vous m'verrez pas filer en douce dans un autre coin de la ville.<E049><E003 4><E145 79 66><E139 79>\r\n<E025 1>Certainement pas, <E049><E003 8>jamais de la vie !");
                s = s.Replace("I see...", "Je vois...");
                s = s.Replace("As it happens, <E049><E003 8>after I sold Sandwich that little titbit about\r\nthe Red-Headed League...", "Et figurez-vous <E049><E003 8>qu'après avoir refilé à Sandwich ce tuyau sur\r\nla Ligue des Rouquins...");
                s = s.Replace("...he went and got himself some red paint from\r\nsomewhere.<E049><E003 8> God only knows where, mind.", "... il est allé s'dégoter de la peinture rouge chais pas où.<E049><E003 8> Dieu seul sait où d'ailleurs.");
                s = s.Replace("But just between uz...<E003 10><E025 2>he didn't have the gumption to dunk\r\nhis head in it.", "Mais soit dit entre nouz...<E003 10><E025 2> il a pas eu le cran d'y tremper sa caboche.");
                return s;
            };

            // [74] BB\script\output\_sce03_c107_0020_eng#14
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("So...<E003 6><E025 2><E145 1 0><E118 1 1.2><E003 10>you live in that room presumably, <E003 4>do you?", "Alors...<E003 6><E025 2><E145 1 0><E118 1 1.2><E003 10> vous habitez dans cette chambre, <E003 4>je suppose ?");
                s = s.Replace("No, I don't live there!<E049><E003 14> <E025 2>What do you think?<E049><E003 10>\r\nThere's no bed, <E003 4>is there?<E049><E003 8> Just a desk.", "Non, j'habite pas là-dedans !<E049><E003 14> <E025 2>Vous croyez quoi ?<E049><E003 10>\r\nY a pas de lit, <E003 4>que je sache !<E049><E003 8> Y a juste un bureau.");
                s = s.Replace("<E338><E341>Then...<E003 10><E025 2><E145 1 66><E118 1 1.3><E003 8><E330>why would you want to rent it?", "<E338><E341>Alors...<E003 10><E025 2><E145 1 66><E118 1 1.3><E003 8><E330> pourquoi donc la louer ?");
                s = s.Replace("Well, <E049><E003 6>I...<E003 13><E164 79 69 1 2 8 0 2 1><E139 79><E025 1>I don't think I should have to say, really.", "Eh bien, <E049><E003 6>j'...<E003 13><E164 79 69 1 2 8 0 2 1><E139 79><E025 1> j'vois pas pourquoi je devrais vous l'dire, franchement.");
                s = s.Replace("Then how about <E049><E003 5><E025 2><E060 0 128 0 0><E145 112 0><E118 112 1.1>the noticeboard in there?", "Dans ce cas, que dites-vous <E049><E003 5><E025 2><E060 0 128 0 0><E145 112 0><E118 112 1.1>du tableau d'affichage qui s'y trouve ?");
                s = s.Replace("Which was covered from top to bottom in confidential\r\ndocuments only the police should have had access to.", "Qui était couvert de haut en bas de documents confidentiels\r\nauxquels seule la police devrait avoir accès.");
                s = s.Replace("Ah...<E049><E003 4><E025 2><E145 79 66><E003 8>no...<E003 10><E333>that board's not mine.", "Ah...<E049><E003 4><E025 2><E145 79 66><E003 8> non...<E003 10><E333> ce tableau n'est pas à moi.");
                s = s.Replace("The inspector must have brought it along.", "L'inspecteur a dû l'apporter avec lui.");
                s = s.Replace("It's only the other bits and bobs that belong to me.<E049><E003 6>\r\n<E145 79 65><E003 6><E333><E025 1>The desk and the chair and that.", "Y a que les autres babioles qui sont à moi.<E049><E003 6>\r\n<E145 79 65><E003 6><E333><E025 1>Le bureau, la chaise et tout ça.");
                s = s.Replace("Um...<E049><E003 12><E169 1 3><E025 2>people don't generally carry enormous noticeboards\r\naround with them...", "Euh...<E049><E003 12><E169 1 3><E025 2> les gens ne se trimbalent généralement pas avec d'énormes tableaux d'affichage...");
                s = s.Replace("The real question is...<E003 12><E025 2>why was Inspector Gregson killed\r\nthere, <E003 6>in your room?", "La véritable question est...<E003 12><E025 2> pourquoi l'inspecteur Gregson a-t-il été\r\ntué là, <E003 6>dans votre chambre ?");
                s = s.Replace("Well obviously, <E003 6>I've not the faintest idea.", "Ben évidemment, <E003 6>j'en ai pas la moindre idée.");
                s = s.Replace("I mean, <E049><E003 10><E239>it's causing me no end of bother, <E003 6><E025 2>to be honest.", "J'veux dire, <E049><E003 10><E239>ça m'cause un tas d'ennuis, <E003 6><E025 2>pour être honnête.");
                s = s.Replace("I seems to me that Mr Gossip–<E049><E003 12>\r\n<E025 2><E341>Sorry, <E049><E003 6><E025 3>Mr Boone...", "Il me semble que M. Ragot...<E049><E003 12>\r\n<E025 2><E341>Pardon, <E049><E003 6><E025 3>M. Boone...");
                s = s.Replace("...would rather as little is known about his room as\r\npossible for some reason.", "... préférerait qu'on en sache le moins possible sur sa chambre\r\npour une raison quelconque.");
                s = s.Replace("Yes, <E003 6>it does come across that way.<E003 10>\r\n<E025 3>And more importantly...", "Oui, <E003 6>ça donne tout à fait cette impression.<E003 10>\r\n<E025 3>Et plus important encore...");
                s = s.Replace("...knowing that the scene of the crime is actually <E006>his room<E005>\r\ncompletely changes things.", "... savoir que la scène du crime est en réalité <E006>sa chambre<E005>\r\nchange complètement la donne.");
                s = s.Replace("In particular, <E003 8><E330><E025 2>there's <E006>one part<E005> of his testimony that's really\r\nbothering me now.", "En particulier, <E003 8><E330><E025 2>il y a <E006>un passage<E005> de son témoignage qui me\r\nturlupine vraiment maintenant.");
                s = s.Replace("(That's how I'm finally going to <E006>undo<E007> this man...)", "(C'est comme ça que je vais enfin <E006>démonter les arguments<E007> de cet homme...)");
                return s;
            };

            // [75] BB\script\output\_sce03_c107_0020_eng#15
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("You mean you have no family?", "Vous voulez dire que vous n'avez pas de famille ?");
                s = s.Replace("No, <E049><E003 4><E145 79 66><E003 6>none at all.", "Non, <E049><E003 4><E145 79 66><E003 6>aucune.");
                s = s.Replace("So I spend my days on Fresno Street peddling titbits to\r\npassers-by...", "Alors je passe mes journées sur Fresno Street à vendre des tuyaux aux passants...");
                s = s.Replace("...hoping –<E003 6><E025 1> just between uz, <E003 6>this is –<E049><E003 10><E025 2> that eventually,\r\nsomeone else with lips like mine will come along.", "... en espérant –<E003 6><E025 1> soit dit entre nouz, <E003 6>hein –<E049><E003 10><E025 2> que tôt ou tard,\r\nquelqu'un d'autre avec des lèvres comme les miennes finira par passer.");
                s = s.Replace("I don't-a think so.", "J'en-a doute fort.");
                s = s.Replace("You may be right.", "Vous avez p'têt ben raison.");
                s = s.Replace("Anyway, <E049><E003 8><E025 2>that mark on your neck is just too much of a\r\ncoincidence for us to ignore.", "De toute façon, <E049><E003 8><E025 2>cette marque sur votre cou est une coïncidence bien\r\ntrop troublante pour que nous l'ignorions.");
                s = s.Replace("Well what's a fella to do then, <E003 4>eh?<E049><E003 10>\r\n<E025 2>If you don't believe me, <E003 6>we're at an impasse.", "Ben qu'est-ce qu'un pauvre gars peut faire d'autre, <E003 4>hein ?<E049><E003 10>\r\n<E025 2>Si vous me croyez pas, <E003 6>on est dans une impasse.");
                s = s.Replace("And there's nothing I can do but flick me lip.", "Et j'ai plus rien d'autre à faire que faire claquer ma lèvre.");
                s = s.Replace("(It looks like I'm not going to get anywhere here<E003 8> <E025 3><E330>unless I\r\ncan produce some proof.)", "(On dirait bien que je n'arriverai à rien<E003 8> <E025 3><E330>si je ne présente\r\npas de preuve.)");
                s = s.Replace("You're basically saying I got dressed up and posed as\r\nsome fancy inspector, <E003 6>aren't you?", "Vous dites en gros que j'me suis déguisé pour jouer les inspecteurs chic, <E003 6>c'est ça ?");
                s = s.Replace("Well, <E049><E003 4><E025 1><E164 79 69 1 2 8 0 2 1><E139 79>it's beyond me how you think I could do that.", "Eh ben, <E049><E003 4><E025 1><E164 79 69 1 2 8 0 2 1><E139 79>ça me dépasse que vous puissiez croire que j'en serais capable.");
                return s;
            };

            // [76] BB\script\output\_sce03_c107_0020_eng#16
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("Maybe you could!<E049><E003 10> <E025 3>Say...<E049><E003 8><E025 1><E164 1 71 1 2 8 0 2 1><E139 1>with a moustache!<E049><E003 12> Or a beard to\r\ncover up that lip!", "Peut-être bien que si !<E049><E003 10> <E025 3>Disons...<E049><E003 8><E025 1><E164 1 71 1 2 8 0 2 1><E139 1> avec une moustache !<E049><E003 12> Ou une barbe pour\r\nrecouvrir cette lèvre !");
                s = s.Replace("Aye, <E003 6><E025 2>perhaps.", "Ouais, <E003 6><E025 2>peut-être.");
                s = s.Replace("But if I was going to stick some fake facial hair on to cover\r\nup this fine specimen...", "Mais si je devais m'coller des faux poils sur la figure pour\r\ncacher ce chef-d'œuvre...");
                s = s.Replace("...I'd end up looking like His Lordship over there, <E003 4><E025 2>wouldn't\r\nI?", "... je finirais par ressembler à Sa Seigneurie là-bas, <E003 4><E025 2>pas vrai ?");
                s = s.Replace("...Pardon?", "... Pardon ?");
                s = s.Replace("I, <E003 8><E025 1>I assure you my lips are entirely unremarkable!", "Je... <E003 8><E025 1>je vous assure que mes lèvres n'ont absolument rien de remarquable !");
                s = s.Replace("And I would ask you not to cast such scrutinising looks in\r\nmy direction, Counsel!", "Et je vous prierais de ne pas lancer de regards si scrutateurs dans\r\nma direction, Maître !");
                s = s.Replace("Ah!<E049><E003 10> <E025 2>Sorry...<E003 10>My Lord.<E049><E003 12>\r\n<E025 3><E007>(My imagination got the better of me there.)", "Ah !<E049><E003 10> <E025 2>Pardon...<E003 10> Votre Honneur.<E049><E003 12>\r\n<E025 3><E007>(Mon imagination a pris le dessus, là.)");
                s = s.Replace("Well, <E049><E003 8><E025 2>Inspector Gregson did wear a moustache, <E003 6>of course.", "Eh bien, <E049><E003 8><E025 2>l'inspecteur Gregson portait une moustache, <E003 6>bien sûr.");
                s = s.Replace("You're right!<E003 10> He did!<E003 10>\r\n<E025 3>So...<E003 10>perhaps he was hiding something himself...", "C'est vrai !<E003 10> En effet !<E003 10>\r\n<E025 3>Alors...<E003 10> peut-être cachait-il quelque chose lui aussi...");
                s = s.Replace("He could barely have hidden a crumb in a moustache of\r\nthat size.", "Il aurait à peine pu dissimuler une miette dans une moustache de cette taille.");
                s = s.Replace("And anyway, <E049><E003 8>ze detective we spoke wiz 'ad no facial 'air\r\nat all.", "Et de toute façon, <E049><E003 8>le détective à qui nous avons parlé n'avait\r\npas le moindre poil sur le visage.");
                s = s.Replace("Si, <E003 6>si, <E049><E003 8>the capo is-a right.<E049><E003 10>\r\nHe was-a clean shaven.", "Si, <E003 6>si, <E049><E003 8>le capo a raison.<E049><E003 10>\r\nIl était rasé de près.");
                s = s.Replace("Hmmm...", "Hummm...");
                s = s.Replace("It certainly seems beyond the realms of possibility that\r\nthis witness could have disguised himself as the victim.", "Il semble pour le moins impensable que ce témoin ait pu\r\nse déguiser en la victime.");
                s = s.Replace("Aye, <E049><E003 8><E025 1>it doz and it is!", "Ouais, <E049><E003 8><E025 1>ça l'est et c'est bien ainsi !");
                return s;
            };

            // [77] BB\script\output\_sce03_c107_0020_eng#18
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rousseau!", "Monsieur de Rousseau !");
                s = s.Replace("Uuugh!<E049><E003 15> <E145 80 64><E118 80 0.6><E003 10><E025 3><E342><E333>Ah...<E003 10>oui?<E049><E003 10>\r\n<E025 2>Can I 'elp you?", "Urrggh !<E049><E003 15> <E145 80 64><E118 80 0.6><E003 10><E025 3><E342><E333>Ah...<E003 10> oui ?<E049><E003 10>\r\n<E025 2>Puis-je vous aider ?");
                s = s.Replace("Did Mr Gossip's words just now <E145 1 85><E118 1 0.6>lead you to remember\r\nsomething relevant, perhaps?", "Les paroles de M. Ragot à l'instant <E145 1 85><E118 1 0.6>vous ont-elles rappelé\r\nquelque chose de pertinent, peut-être ?");
                s = s.Replace("It was ze other day, <E049><E003 8>when I was looking for a place near\r\nze park.<E049><E003 8> A small 'ouse or something.", "C'était l'autre jour, <E049><E003 8>quand je cherchais un endroit près\r\ndu parc.<E049><E003 8> Une petite maison ou quelque chose comme ça.");
                s = s.Replace("To be the headquarters of your Red-Headed League, <E049><E003 6>yes.", "Pour en faire le quartier général de votre Ligue des Rouquins, <E049><E003 6>oui.");
                s = s.Replace("I visited an 'ousing agent on Lime Street, <E049><E003 8><E025 3>and zere I saw\r\n'im.", "J'ai rendu visite à un agent immobilier sur Lime Street, <E049><E003 8><E025 3>et là-bas, je l'ai vu.");
                s = s.Replace("Zis man <E049><E003 6><E025 2><E130 9 0><E003 10><E239>was paying money to ze agent.", "Cet homme <E049><E003 6><E025 2><E130 9 0><E003 10><E239>payait de l'argent à l'agent.");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("Mr...<E003 8><E025 3>Mr Gossip...<E049><E003 10><E145 1 2><E025 2><E606>with a housing agent?!", "M...<E003 8><E025 3> M. Ragot...<E049><E003 10><E145 1 2><E025 2><E606>chez un agent immobilier ?!");
                s = s.Replace("Oui.<E049><E003 13> <E025 2><E145 80 64><E118 80 0.7><E003 5>'E 'ad some kind of contract in 'is 'and, <E049><E003 6>and zey were\r\nclearly discussing terms.", "Oui.<E049><E003 13> <E025 2><E145 80 64><E118 80 0.7><E003 5>Il avait une sorte de contrat en main, <E049><E003 6>et ils discutaient\r\nclairement des termes.");
                s = s.Replace("Bu...<E003 6> <E025 1><E356>No no no!<E049><E003 18>\r\n<E045>You're mistaken, chum!", "Mai...<E003 6> <E025 1><E356> Non non non !<E049><E003 18>\r\n<E045>Vous vous gourrez, mon pote !");
                s = s.Replace("I've never left Fresno Street, me.<E049><E003 10> <E341>Like I said before.", "J'ai jamais quitté Fresno Street, moi.<E049><E003 10> <E341>Comme je l'ai déjà dit !");
                s = s.Replace("You've mistaken me for someone else.<E049><E003 6>\r\n<E025 1><E164 79 69 1 2 8 0 2 1><E118 79 1.2><E139 79>Someone with the same face!", "Vous me confondez avec quelqu'un d'autre.<E049><E003 6>\r\n<E025 1><E164 79 69 1 2 8 0 2 1><E118 79 1.2><E139 79>Quelqu'un avec la même tronche !");
                s = s.Replace("No no!<E049><E003 10> The capo is right!<E049><E003 12>\r\nI remember it-a too!", "Non non !<E049><E003 10> Le capo a raison !<E049><E003 12>\r\nJe m'en souviens moi aussi !");
                s = s.Replace("He was-a paying the man with-a the <E006>banknotes<E005>!", "Il payait l'homme avec des <E006>billets de banque<E005> !");
                s = s.Replace("With notes?", "Avec des billets ?");
                s = s.Replace("L-<E003 6><E338><E342>Like I said, <E049><E003 10><E025 3>that was...<E003 8>", "C...<E003 6><E338><E342> Comme j'ai dit, <E049><E003 10><E025 3>c'était...<E003 8>");
                s = s.Replace("That wasn't me!", "C'était pas moi !");
                s = s.Replace("I was curious why this-a man with the dirty clothes had\r\nso much-a money.", "J'étais curieux de savoir pourquoi cet homme avec des habits sales\r\navait autant d'argent.");
                s = s.Replace("So I looked at-a <E006>the name<E005> on the papers.", "Alors j'ai regardé <E006>le nom<E005> sur les papiers.");
                s = s.Replace("And what name was written?<E049><E003 4>\r\n<E025 3><E145 1 66><E118 1 1.3><E003 15>‘Mr Gossip’?", "Et quel nom était écrit ?<E049><E003 4>\r\n<E025 3><E145 1 66><E118 1 1.3><E003 15>« M. Ragot » ?");
                s = s.Replace("No no, <E049><E003 10><E025 2>this-a man, <E003 6><E025 1>he lies!<E049><E003 10>\r\n<E025 2>He tells you that he has-a no name...", "Non non, <E049><E003 10><E025 2>cet homme-là, <E003 6><E025 1>il ment !<E049><E003 10>\r\n<E025 2>Il vous dit qu'il a pas de nom...");
                s = s.Replace("...but in fact his-a name is Hugh Boone, <E003 4>uh?<E049><E003 10>\r\n<E341><E025 1>Is better than Mr Gossip, I think, <E003 4><E025 2>si?", "... mais en fait son nom c'est Hugh Boone, <E003 4>hein ?<E049><E003 10>\r\n<E341><E025 1>C'est bien mieux que M. Ragot, je trouve, <E003 4><E025 2>si ?");
                s = s.Replace("NOOOOOO<E339>OOO!", "NOOOON<E339>NNN !");
                s = s.Replace("I'm a pedlar of titbits of information, like I said.<E049><E003 10>\r\n<E025 3>On Fresno Street.<E049><E003 10> And that's that.", "J'suis un camelot qui vend des tuyaux, comme j'ai dit.<E049><E003 10>\r\n<E025 3>Sur Fresno Street.<E049><E003 10> Et c'est tout.");
                s = s.Replace("I, <E049><E003 10><E025 2><E338><E342>I don't much like folk talking about my personal life.", "J'... <E049><E003 10><E025 2><E338><E342>j'aime pas trop qu'on parle de ma vie privée.");
                s = s.Replace("Hmmm, <E003 8><E025 3><E169 15 3>indeed...", "Hummm, <E003 8><E025 3><E169 15 3>en effet...");
                s = s.Replace("And it is not the intention of the court to invade the\r\nprivacy of witnesses.", "Et ce n'est point l'intention du tribunal de violer la vie\r\nprivée des témoins.");
                s = s.Replace("Very well, <E049><E003 10><E025 2>I shall respect your wishes, <E003 4>sir.", "Très bien, <E049><E003 10><E025 2>je respecterai vos souhaits, <E003 4>monsieur.");
                s = s.Replace("The aforementioned name shall be redacted from all\r\ncourt records of this trial.<E049><E003 10> <E145 15 7><E025 3>Assuming no objections?", "Le nom susmentionné sera caviardé de tous les actes judiciaires\r\nde ce procès.<E049><E003 10> <E145 15 7><E025 3>À moins qu'il n'y ait des objections ?");
                s = s.Replace("I'm sorry, My Lord, <E049><E003 8><E025 2>but the defence does object.", "Je regrette, Votre Honneur, <E049><E003 8><E025 2>mais la défense s'y oppose.");
                return s;
            };

            // [78] BB\script\output\_sce03_c107_0020_eng#19
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("Because the name just mentioned <E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>has a very deep\r\nsignificance to this case!", "Car le nom qui vient d'être mentionné <E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>revêt une importance\r\ncapitale pour cette affaire !");
                s = s.Replace("Good gracious!<E049><E003 12>\r\n<E145 15 5><E117 15 8><E338><E342>Do, <E003 6>do you similarly object, <E003 4><E341>Prosecutor Asogi?", "Grand Dieu !<E049><E003 12>\r\n<E145 15 5><E117 15 8><E338><E342>Vous... <E003 6>vous opposez-vous également, <E003 4><E341>Procureur Asogi ?");
                s = s.Replace("As it happens, My Lord...<E049><E003 10><E145 112 0><E118 112 1.4><E025 2><E006>that particular name<E005> <E049><E003 6><E145 112 4><E118 112 1.2><E003 20><E238>has already\r\nbeen mentioned during today's proceedings.", "Il se trouve, Votre Honneur...<E049><E003 10><E145 112 0><E118 112 1.4><E025 2><E006>que ce nom précis<E005> <E049><E003 6><E145 112 4><E118 112 1.2><E003 20><E238>a déjà\r\nété mentionné lors des débats d'aujourd'hui.");
                s = s.Replace("Well I never!<E049><E003 16>\r\n<E145 15 5><E117 15 8><E025 1><E335>In what capacity?", "Ça alors !<E049><E003 16>\r\n<E145 15 5><E117 15 8><E025 1><E335>À quel titre ?");
                s = s.Replace("The name <E049><E003 8><E145 9 92><E003 8><E346><E025 1><E006>of the leaseholder<E005> of the room!", "Le nom <E049><E003 8><E145 9 92><E003 8><E346><E025 1><E006>du locataire en titre<E005> de la chambre !");
                s = s.Replace("Let me put this very simply!", "Permettez-moi d'être on ne peut plus clair !");
                s = s.Replace("The victim's body was discovered...<E003 8><E145 1 21><E118 1 1.2><E003 10><E025 1><E332>in <E006>your rented room<E005>!", "Le corps de la victime a été découvert...<E003 8><E145 1 21><E118 1 1.2><E003 10><E025 1><E332>dans <E006>votre chambre louée<E005> !");
                s = s.Replace("I suggest, <E003 6>sir...<E049><E003 8><E145 112 7><E003 8><E025 1><E332><E342>that you start talking!", "Je vous suggère, <E003 6>monsieur...<E049><E003 8><E145 112 7><E003 8><E025 1><E332><E342>de vous mettre à table !");
                s = s.Replace("Well...<E003 10><E025 3><E341>alright...", "Eh bien...<E003 10><E025 3><E341> d'accord...");
                s = s.Replace("...I suppose that might be the case, <E049><E003 6><E341>aye.", "... je suppose que ça pourrait bien être le cas, <E049><E003 6><E341>ouais.");
                s = s.Replace("So your real name <E049><E003 8><E145 1 7><E003 10><E025 3>is Hugh Boone?", "Votre véritable nom <E049><E003 8><E145 1 7><E003 10><E025 3>est donc bien Hugh Boone ?");
                s = s.Replace("Well just between uz...<E003 8><E025 2>I don't like to blow me own\r\ntrumpet, <E049><E003 8><E025 2>but there's no finer pedlar of titbits in town.", "Ben soit dit entre nouz...<E003 8><E025 2> j'aime pas trop me vanter, <E049><E003 8><E025 2>mais y a pas de meilleur camelot de tuyaux en ville.");
                s = s.Replace("So aye, <E049><E003 8>I happen to be able to afford a grubby little room\r\nin a falling-down backstreet townhouse. ", "Alors ouais, <E049><E003 8>il s'trouve que j'ai les moyens de m'payer une p'tite piaule crasseuse dans une vieille bicoque délabrée. ");
                s = s.Replace("<E338><E342>You do?", "<E338><E342>Vraiment ?");
                s = s.Replace("And once every six months, <E049><E003 8>I go and pay the rent to the\r\nagent on Lime Street.", "Et une fois tous les six mois, <E049><E003 8>je vais payer le loyer à\r\nl'agent sur Lime Street.");
                s = s.Replace("Aye, <E049><E003 8><E025 2>I remember now.<E049><E003 7> <E164 79 68 1 2 6 0 0 1><E139 79><E025 1>There were two vulgar red-heads\r\nin there last time.", "Ouais, <E049><E003 8><E025 2>j'me rappelle maintenant.<E049><E003 7> <E164 79 68 1 2 6 0 0 1><E139 79><E025 1>Y avait deux rouquins vulgaires\r\nla dernière fois.");
                s = s.Replace("Ay?<E049><E003 12> <E025 2>If either of us is-a vulgar, <E049><E003 8><E045><E025 1>is not-a me!", "Hein ?<E049><E003 12> <E025 2>Si l'un de nous est vulgaire, <E049><E003 8><E045><E025 1>c'est sûrement pas moi !");
                s = s.Replace("<E239>Sink again, <E049><E003 6><E025 2>Peppino.", "<E239>Réfléchis encore un peu, <E049><E003 6><E025 2>Peppino.");
                s = s.Replace("Why didn't you <E049><E003 5><E025 1><E145 112 6><E003 6><E332>bring this up before?", "Pourquoi n'avez-vous pas <E049><E003 5><E025 1><E145 112 6><E003 6><E332>signalé cela plus tôt ?");
                s = s.Replace("It's like I told you already...", "C'est comme j'vous l'ai déjà dit...");
                s = s.Replace("...I don't like talking about my personal life.<E049><E003 12> <E025 2><E330>I'm a titbit\r\npedlar as far as everyone else is concerned.<E049><E003 10> <E025 1><E346>No fuss.", "... j'aime pas parler d'ma vie privée.<E049><E003 12> <E025 2><E330>J'suis un camelot\r\nde tuyaux pour le reste du monde.<E049><E003 10> <E025 1><E346>Pas d'chichis.");
                s = s.Replace("You will update your testimony to include this most\r\nsurprising revelation...<E049><E003 12><E145 15 5><E003 6><E025 1><E046>Mr Boone.", "Vous allez modifier votre témoignage pour y inclure cette des plus\r\nsurprenantes révélations...<E049><E003 12><E145 15 5><E003 6><E025 1><E046>M. Boone.");
                s = s.Replace("If I must.", "Si j'y suis obligé.");
                s = s.Replace("So the leaseholder Scotland Yard has been looking for\r\nsince the body was discovered...", "Ainsi donc, le locataire en titre que Scotland Yard recherche\r\ndepuis la découverte du cadavre...");
                s = s.Replace("...has been here under our noses all along.", "... s'est trouvé sous notre nez depuis le début.");
                return s;
            };

            // [79] BB\script\output\_sce03_c107_0020_eng#20
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("<E341>Mr de Rousseau!<E003 10>\r\nIs something wrong?", "<E341>Monsieur de Rousseau !<E003 10>\r\nUn problème ?");
                s = s.Replace("I was just considering something.", "J'étais juste en train de réfléchir à quelque chose.");
                s = s.Replace("<E333>About the testimony?<E049><E003 10>\r\nDid something that was just said jar with you?", "<E333>À propos du témoignage ?<E049><E003 10>\r\nQuelque chose qui vient d'être dit vous a heurté ?");
                s = s.Replace("Non.<E049><E003 12> <E025 2><E330>I was considering my next cunning plan.", "Non.<E049><E003 12> <E025 2><E330>Je réfléchissais à mon prochain plan diabolique.");
                s = s.Replace("<E333>Fantastico, capo!<E049><E003 14><E025 1><E346> The Hairlarious Brothers are-a gonna be\r\nback in action, <E003 6><E025 2>ay?", "<E333>Fantastico, capo !<E049><E003 14><E025 1><E346> Les Frères Hilaroux vont être de retour\r\nen action, <E003 6><E025 2>hein ?");
                s = s.Replace("I sink my next enterprise will be an exclusive club\r\ncalled...<E003 10><E025 3><E043>ze Four-Eyed League!", "Je pense que ma prochaine entreprise sera un club très exclusif\r\nappelé...<E003 10><E025 3><E043>la Ligue des Binoclards !");
                s = s.Replace("...Kindly discuss your upcoming criminal activities once\r\nyou're back in your cell.", "... Veuillez avoir l'amabilité de discuter de vos futurs méfaits\r\nune fois de retour en cellule.");
                return s;
            };

            // [80] BB\script\output\_sce03_c107_0020_eng#21
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("Mr Gossip!<E049><E003 10> <E025 2>Do you have something to say?", "Monsieur Ragot !<E049><E003 10> <E025 2>Vous avez quelque chose à dire ?");
                s = s.Replace("Mr Boone!<E049><E003 10> <E025 2>Do you have something to say?", "Monsieur Boone !<E049><E003 10> <E025 2>Vous avez quelque chose à dire ?");
                s = s.Replace("<E341>I do as it happens!<E049><E003 12> Your timing's perfect.", "<E341>Absolument !<E049><E003 12> Ça tombe à pic.");
                s = s.Replace("I've just got wind of a juicy tale that'll be right up your\r\nsnicket.", "J'viens d'avoir vent d'un tuyau juteux qui va vous plaire à coup sûr.");
                s = s.Replace("You don't want to let this one slip by, <E049><E003 6>I tell ya.<E049><E003 12>\r\n<E025 2>And sixpence is all I ask...", "Faut pas laisser filer une occasion pareille, <E049><E003 6>j'vous l'dis.<E049><E003 12>\r\n<E025 2>Et j'vous demande que six pence...");
                s = s.Replace("...Maybe <E003 8><E025 2>try Prosecutor Asogi instead.", "... Vous devriez peut-être <E003 8><E025 2>proposer ça au procureur Asogi plutôt.");
                s = s.Replace("<E330>I don't want your gossip, <E049><E003 8><E025 3>Ryunosuke Naruhodo.", "<E330>Je n'ai que faire de vos ragots, <E049><E003 8><E025 3>Ryunosuke Naruhodo.");
                return s;
            };
        }
    }
}
