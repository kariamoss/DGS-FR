using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart2_B() {
            // [69] BB\script\output\_sce03_c203_0040_eng#26
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#26"] = (en) => {
                string s = en;
                s = s.Replace("That's a key she's holding, <E003 8>look.", "C'est une clé qu'elle tient, <E003 8>regardez.");
                s = s.Replace("I'm sure that wasn't in her hands before, <E003 6>was it?", "Je suis certain qu'elle n'avait rien en main auparavant, <E003 6>si ?");
                s = s.Replace("No, <E003 6>you're quite right.<E003 10>\r\nIt's appeared...<E003 10><E025 3>as if by magic.", "Non, <E003 6>vous avez tout à fait raison.<E003 10>\r\nElle est apparue...<E003 10><E025 3>comme par magie.");
                s = s.Replace("That's strange...<E003 12>\r\n<E025 3>A big, <E003 4>old iron key...", "C'est étrange...<E003 12>\r\n<E025 3>Une grosse et vieille clé en fer...");
                s = s.Replace("(Where did it materialise from?)", "(D'où a-t-elle bien pu sortir ?)");
                return s;
            };

            // [70] BB\script\output\_sce03_c203_0040_eng#27
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#27"] = (en) => {
                string s = en;
                s = s.Replace("For some reason, <E003 10><E025 1><E333>this knapsack is really standing out as\r\nsuspicious to me today!", "Pour une raison que j'ignore, <E003 10><E025 1><E333>ce sac à dos me paraît\r\nterriblement suspect aujourd'hui !");
                s = s.Replace("Oh, <E003 8>is it?", "Ah, <E003 8>vraiment ?");
                s = s.Replace("It's quite sizeable enough for a sizeable secret,<E003 10> <E341>that's what\r\nI say!", "Il est bien assez grand pour un secret colossal,<E003 10> <E341>voilà ce\r\nque je dis !");
                s = s.Replace("Perhaps it is.<E003 10> But we certainly can't open it up to look\r\ninside without Iris's permission.", "C'est possible.<E003 10> Mais nous ne pouvons certes pas l'ouvrir pour\r\nregarder dedans sans la permission d'Iris.");
                s = s.Replace("...No...<E003 10>you're right.", "...Non...<E003 10>vous avez raison.");
                s = s.Replace("Who knows what might pop out and punch us?", "Qui sait ce qui pourrait en jaillir pour nous flanquer un coup de poing ?");
                return s;
            };

            // [71] BB\script\output\_sce03_c203_0040_eng#28
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#28"] = (en) => {
                string s = en;
                s = s.Replace("Iris always dresses in these frilly clothes, <E003 6>doesn't she?", "Iris porte toujours ces vêtements à volants, <E003 6>n'est-ce pas ?");
                s = s.Replace("I've always thought this skirt is rather delightful.", "J'ai toujours trouvé que cette jupe était absolument ravissante.");
                s = s.Replace("It's pretty sizeable with all those frills.<E003 12>\r\n<E341>Sizeable enough for a sizeable secret!", "Elle est plutôt volumineuse avec tous ces froufrous.<E003 12>\r\n<E341>Assez volumineuse pour un secret colossal !");
                s = s.Replace("...You seem to be rather fond of that idea.", "...Vous semblez bien entiché de cette idée.");
                s = s.Replace("But you certainly can't go investigating further.", "Mais vous ne pouvez certes pas aller fouiller plus avant.");
                s = s.Replace("(Does it look like that's what I was thinking?)", "(Est-ce que ça avait l'air d'être ce que je pensais ?)");
                return s;
            };

            // [72] BB\script\output\_sce03_c203_0040_eng#29
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#29"] = (en) => {
                string s = en;
                s = s.Replace("How wonderful to hear Iris's voice again.", "Quel bonheur d'entendre à nouveau la voix d'Iris.");
                s = s.Replace("It's just a shame it took Mr Sholmes being thrown across\r\nthe room to make it happen.", "C'est juste dommage qu'il ait fallu que M. Sholmes soit projeté\r\nà travers la pièce pour y parvenir.");
                s = s.Replace("Oh, <E003 8>that gives me an idea...", "Oh, <E003 8>cela me donne une idée...");
                s = s.Replace("If we threw you across the room as well, <E003 8><E341>she might talk\r\nsome more!", "Si nous vous projetions vous aussi à travers la pièce, <E003 8><E341>elle parlerait\r\npeut-être encore plus !");
                s = s.Replace("(...Iris made a sudden movement just before she spoke\r\nthat's playing on my mind.)", "(...Iris a fait un mouvement brusque juste avant de parler,\r\net cela me tracasse.)");
                s = s.Replace("(I think we'd better have another good look around,<E003 8> <E330>whilst\r\ntrying not to be too rude by staring at her.)", "(Je pense qu'on ferait mieux de bien regarder autour de nous,<E003 8> <E330>tout en\r\névitant d'être trop impoli en la fixant.)");
                s = s.Replace("Yes, <E003 8><E025 2>do try to be sensitive, <E003 6>Mr Naruhodo...", "Oui, <E003 8><E025 2>essayez d'être délicat, <E003 6>M. Naruhodo...");
                return s;
            };

            // [73] BB\script\output\_sce03_c203_0040_eng#31
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#31"] = (en) => {
                string s = en;
                s = s.Replace("Clearly <E049><E003 8><E025 3>the reason you've said nothing all this time, <E049><E003 6>Iris,<E049><E003 10>\r\n<E025 2>is something to do with what's in your knapsack.", "À l'évidence, <E049><E003 8><E025 3>la raison pour laquelle tu n'as rien dit tout ce temps, <E049><E003 6>Iris,<E049><E003 10>\r\n<E025 2>est liée à ce que contient ton sac à dos.");
                s = s.Replace("It's a sizeable bag...<E049><E003 6><E025 1><E164 1 56 1 2 8 0 2 1><E139 1>for a sizeable secret!", "C'est un sac d'une belle taille...<E049><E003 6><E025 1><E164 1 56 1 2 8 0 2 1><E139 1>pour un secret tout aussi colossal !");
                s = s.Replace("My dear fellow, <E049><E003 6><E025 1><E164 3 107 1 2 5 0 2 1><E492 3 190 15 2><E139 3><E145 1 2><E492 1 -132 0 0>you would appear to be rather caught up\r\nin that idea!", "Mon cher ami, <E049><E003 6><E025 1><E164 3 107 1 2 5 0 2 1><E492 3 190 15 2><E139 3><E145 1 2><E492 1 -132 0 0>vous semblez pour le moins omnibulé\r\npar cette idée !");
                s = s.Replace("M-<E049><E003 8>Miss Susato, <E049><E003 10><E025 2>what are you...?", "M-... <E049><E003 8>Mademoiselle Susato, <E049><E003 10><E025 2>que faites-vous... ?");
                s = s.Replace("Well, <E049><E003 8><E025 2>you've been left alone on the dance floor, <E003 6>as you\r\nsay.<E049><E003 10> So I'm trying to fill Mr Sholmes's shoes.", "Eh bien, <E049><E003 8><E025 2>vous avez été laissé seul sur la piste de danse, <E003 6>comme vous\r\nle disiez.<E049><E003 10> J'essaie donc d'assumer le rôle de M. Sholmes.");
                s = s.Replace("Well, <E049><E003 10>it's, <E049><E003 8><E169 1 0><E341>um...<E003 10><E169 1 3>very refreshing.", "Eh bien, <E049><E003 10>c'est... <E049><E003 8><E169 1 0><E341>hum...<E003 10><E169 1 3>très rafraîchissant.");
                s = s.Replace("Oh, <E049><E003 6>but of course!<E049><E003 10>\r\nI nearly forgot...", "Oh, <E049><E003 6>mais bien sûr !<E049><E003 10>\r\nJ'ai failli oublier...");
                s = s.Replace("You don't need to imitate every move, <E049><E003 4>you know...", "Vous n'avez pas besoin d'imiter chacun de ses gestes, <E049><E003 4>vous savez...");
                return s;
            };

            // [74] BB\script\output\_sce03_c203_0040_eng#32
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#32"] = (en) => {
                string s = en;
                s = s.Replace("Clearly <E049><E003 8><E025 3>the reason you've said nothing all this time, <E049><E003 6>Iris,<E049><E003 10>\r\n<E025 2><E164 1 56 1 2 5 0 2 1><E139 1>is because you're hiding something in your frilly skirt.", "À l'évidence, <E049><E003 8><E025 3>la raison pour laquelle tu n'as rien dit tout ce temps, <E049><E003 6>Iris,<E049><E003 10>\r\n<E025 2><E164 1 56 1 2 5 0 2 1><E139 1>est que tu caches quelque chose sous ta jupe à froufrous.");
                s = s.Replace("And what sizeable frills they are...<E003 8><E025 1><E346>for a sizeable secret!", "Et quels froufrous volumineux...<E003 8><E025 1><E346>pour un secret tout aussi colossal !");
                s = s.Replace("A typical answer of yours, <E049><E003 8>my dear fellow...<E049><E003 6><E025 1><E164 3 107 1 2 5 0 2 1><E492 3 190 15 2><E139 3><E145 1 2><E492 1 -132 0 0>being wide of\r\nthe mark by a sizeable margin.", "Une réponse bien typique de votre part, <E049><E003 8>mon cher ami...<E049><E003 6><E025 1><E164 3 107 1 2 5 0 2 1><E492 3 190 15 2><E139 3><E145 1 2><E492 1 -132 0 0>qui tombe\r\nà côté de la cible avec une marge tout aussi colossale.");
                s = s.Replace("M-<E049><E003 8>Miss Susato, <E049><E003 10><E025 2>what are you...?", "M-... <E049><E003 8>Mademoiselle Susato, <E049><E003 10><E025 2>que faites-vous... ?");
                s = s.Replace("Well, <E049><E003 8><E025 2>you've been left alone on the dance floor, <E003 6>as you\r\nsay.<E049><E003 10> So I'm trying to fill Mr Sholmes's shoes.", "Eh bien, <E049><E003 8><E025 2>vous avez été laissé seul sur la piste de danse, <E003 6>comme vous\r\nle disiez.<E049><E003 10> J'essaie donc d'assumer le rôle de M. Sholmes.");
                s = s.Replace("Well...<E003 10><E341>you've certainly captured the cutting sarcasm.", "Eh bien...<E003 10><E341>vous avez parfaitement restitué son sarcasme mordant.");
                s = s.Replace("Oh, <E049><E003 6>of course!<E049><E003 10>\r\nI nearly forgot...", "Oh, <E049><E003 6>bien sûr !<E049><E003 10>\r\nJ'ai failli oublier...");
                s = s.Replace("You really didn't need to capture that part, though.", "Vous n'aviez vraiment pas besoin d'imiter cette partie-là, en revanche.");
                return s;
            };

            // [75] BB\script\output\_sce03_c203_0040_eng#33
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#33"] = (en) => {
                string s = en;
                s = s.Replace("Yes, the real reason for your silence until now is...", "Oui, la véritable raison de ton silence jusqu'ici est...");
                return s;
            };

            // [76] BB\script\output\_sce03_c203_0040_eng#34
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#34"] = (en) => {
                string s = en;
                s = s.Replace("Yes, <E003 10>the real reason for your silence until now is...<E003 12><E025 1><E607>that\r\n<E007><E570><FONT 2>key<E571></FONT><E005> behind your back!", "Oui, <E003 10>la véritable raison de ton silence jusqu'ici est...<E003 12><E025 1><E607>cette\r\n<E007><E570><FONT 2>clé<E571></FONT><E005> derrière ton dos !");
                s = s.Replace("When Mr Sholmes was thrown into the air before...", "Quand M. Sholmes a été projeté en l'air tout à l'heure...");
                return s;
            };

            // [77] BB\script\output\_sce03_c203_0040_eng#35
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#35"] = (en) => {
                string s = en;
                s = s.Replace("Just before you called out to try to stop him, <E003 8>you slipped\r\nsomething out of your mouth.", "Juste avant de crier pour tenter de l'arrêter, <E003 8>tu as retiré\r\nquelque chose de ta bouche.");
                s = s.Replace("That ‘something’ <E003 8>is the key now in your hands.<E003 10>\r\n<E025 3>No doubt <E003 8><E025 2><E333>the key to <E006>the chest<E005>.", "Ce « quelque chose » <E003 8>est la clé que tu as entre les mains.<E003 10>\r\n<E025 3>Sans nul doute <E003 8><E025 2><E333>la clé de <E006>ce coffre<E005>.");
                return s;
            };

            // [78] BB\script\output\_sce03_c203_0040_eng#36
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#36"] = (en) => {
                string s = en;
                s = s.Replace("You're so...", "Tu es si...");
                s = s.Replace("You're so clever, Runo!", "Tu es si perspicace, Runo !");
                s = s.Replace("So now it becomes clear.", "Tout s'éclaire enfin.");
                s = s.Replace("Thanks to Mr Sholmes's graphic demonstration...", "Grâce à la démonstration percutante de M. Sholmes...");
                s = s.Replace("...we can well imagine what happened here.", "...nous pouvons sans peine imaginer ce qui s'est produit ici.");
                s = s.Replace("B-<E003 8>But...", "M-<E003 8>Mais...");
                s = s.Replace("Professor Mikotoba also opened that metal chest<E049><E003 6> only to\r\nbe punched into the air...", "Le professeur Mikotoba a lui aussi ouvert ce coffre en métal,<E049><E003 6> pour se\r\nfaire expédier dans les airs d'un coup de poing...");
                s = s.Replace("...and land sprawled on the settee.", "...et atterrir affalé sur le canapé.");
                return s;
            };

            // [79] BB\script\output\_sce03_c203_0040_eng#37
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#37"] = (en) => {
                string s = en;
                s = s.Replace("But, wait!<E049><E003 10> That doesn't explain all the facts.", "Mais attendez !<E049><E003 10> Cela n'explique pas tous les faits.");
                s = s.Replace("What about <E006>the stylish scarf<E005>...<E003 10><E527 -1775.576660 86.299377 170.336411 8 3><E528 0.150000 0.150000 8 3><E525><E043>and <E006>the cup of tea<E005>.<E049><E003 12>\r\n<E025 2>And above all...", "Qu'en est-il de <E006>cette écharpe élégante<E005>...<E003 10><E527 -1775.576660 86.299377 170.336411 8 3><E528 0.150000 0.150000 8 3><E525><E043>et de <E006>cette tasse de thé<E005> ?<E049><E003 12>\r\n<E025 2>Et par-dessus tout...");
                s = s.Replace("...why would he be wearing <E006>Kazuma-sama's mask<E005>?", "...pourquoi porterait-il <E006>le masque de maître Kazuma<E005> ?");
                return s;
            };

            // [80] BB\script\output\_sce03_c203_0040_eng#38
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#38"] = (en) => {
                string s = en;
                s = s.Replace("Well, <E049><E003 8>for those curious details...<E003 10>I can think of only one\r\nexplanation.", "Eh bien, <E049><E003 8>pour ces curieux détails...<E003 10>je ne vois qu'une seule\r\nexplication possible.");
                s = s.Replace("Clearly <E003 6>an unbelievable miracle took place in this room.", "À l'évidence, <E003 6>un incroyable miracle s'est produit dans cette pièce.");
                s = s.Replace("Isn't that right, <E049><E003 8><E025 3>Iris?", "N'est-ce pas, <E049><E003 8><E025 3>Iris ?");
                return s;
            };

            // [81] BB\script\output\_sce03_c203_0040_eng#39
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#39"] = (en) => {
                string s = en;
                s = s.Replace("Consider how the room was arranged before this whole\r\npainful experience took place.", "Songez à la disposition de la pièce avant que cette douloureuse\r\nexpérience n'ait lieu.");
                s = s.Replace("When Professor Mikotoba opened the chest,<E003 8> completely\r\nunaware of what awaited him inside...", "Quand le professeur Mikotoba a ouvert le coffre,<E003 8> ignorant totalement\r\nce qui l'attendait à l'intérieur...");
                s = s.Replace("...<E006>the mask<E005> was flung into the air just as he was,<E003 8> only to\r\nland neatly on his face when it fell back down.", "...<E006>le masque<E005> a été projeté en l'air en même temps que lui,<E003 8> pour\r\nretomber pile sur son visage dans sa chute.");
                s = s.Replace("And <E006>the teacup<E005>'s journey through the air ended when it\r\ncaught on the unconscious professor's finger.", "Et le périple aérien de <E006>la tasse de thé<E005> s'est achevé lorsqu'elle\r\ns'est accrochée au doigt du professeur évanoui.");
                s = s.Replace("You, <E049><E003 8><E025 2>you mean to say that the stylish scarf...", "Vous... <E049><E003 8><E025 2>vous voulez dire que cette écharpe élégante...");
                s = s.Replace("...is actually just <E006>a tablecloth<E005>.", "...n'est en réalité qu'<E006>une nappe de table<E005>.");
                s = s.Replace("This is the great detective's office, after all –<E049><E003 8><E025 3> a place of\r\nmiraculous deductions.", "Nous sommes dans le cabinet du grand détective après tout...<E049><E003 8><E025 3> un lieu de\r\ndéductions miraculeuses.");
                return s;
            };

            // [82] BB\script\output\_sce03_c203_0040_eng#40
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#40"] = (en) => {
                string s = en;
                s = s.Replace("Would you expect anything less?", "En attendiez-vous moins de moi ?");
                return s;
            };

            // [83] BB\script\output\_sce03_c203_0040_eng#41
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#41"] = (en) => {
                string s = en;
                s = s.Replace("Yes.<E049><E003 8> You're right.<E049><E003 10>\r\nIt happened exactly as you said.", "Oui.<E049><E003 8> Tu as raison.<E049><E003 10>\r\nC'est arrivé exactement comme tu l'as dit.");
                s = s.Replace("...Brilliant, Runo!", "...Brillant, Runo !");
                s = s.Replace("Thus concludes Ryunosuke Naruhodo's great deduction...<E003 10>\r\n<E025 2>of this punchy puzzle!", "Ainsi s'achève le grand spectacle de déduction de Ryunosuke Naruhodo...<E003 10>\r\n<E025 2>sur cette énigme frappante !");
                s = s.Replace("So then...<E003 10>why don't I make a fresh pot of tea for us all?", "Et si...<E003 10>je préparais une nouvelle théière pour nous tous ?");
                s = s.Replace("An admirable performance, <E049><E003 8>Mr Naruhodo.", "Une performance admirable, <E049><E003 8>M. Naruhodo.");
                s = s.Replace("But in the final act of the show there, <E049><E003 8>you rather missed\r\neverything of importance.", "Mais dans le dernier acte de votre numéro, <E049><E003 8>vous avez quelque peu manqué\r\ntout ce qui avait de l'importance.");
                s = s.Replace("M-<E049><E003 10><E331><E025 1>Mr Sholmes!", "M-...<E049><E003 10><E331><E025 1>M. Sholmes !");
                s = s.Replace("If you would cast your mind back to my earlier\r\ndeduction...", "Si vous voulez bien vous remémorer ma déduction précédente...");
                s = s.Replace("Iris...<E003 10>clearly you're hiding <E006>a great secret<E005>.", "Iris...<E003 10>tu caches manifestement <E006>un grand secret<E005>.");
                s = s.Replace("...She is...?<E003 12>\r\n<E025 2><E007>(From the look on her face...)", "...Vraiment... ?<E003 12>\r\n<E025 2><E007>(À en juger par son expression...)");
                s = s.Replace("(...Mr Sholmes must be right.<E003 12> Whatever that <E006>great secret<E007>\r\nis...<E003 10>the cat isn't out of the bag yet.)", "(...M. Sholmes doit avoir raison.<E003 12> Quel que soit ce <E006>grand secret<E007>...<E003 10>le pot aux roses n'a pas encore été découvert.)");
                s = s.Replace("So I put it to you again...", "Je vous pose donc à nouveau la question...");
                s = s.Replace("You were attempting to abscond <E003 10><E025 1><E332>with that <E006><E570><FONT 2>coffee cup<E571></FONT><E005>!", "Tu tentais de t'éclipser en douce <E003 10><E025 1><E332>avec cette <E006><E570><FONT 2>tasse de café<E571></FONT><E005> !");
                return s;
            };

            // [84] BB\script\output\_sce03_c203_0040_eng#46
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#46"] = (en) => {
                string s = en;
                s = s.Replace("It really is a shame about Mr Sholmes's cup.", "C'est vraiment dommage pour la tasse de M. Sholmes.");
                s = s.Replace("It must have been smashed when Professor Mikotoba\r\nopened the chest.", "Elle a dû voler en éclats quand le professeur Mikotoba\r\na ouvert le coffre.");
                s = s.Replace("Oh dear...<E003 10><E025 3>so many things seem to have been broken here.", "Oh là là...<E003 10><E025 3>tant de choses semblent avoir été brisées ici.");
                s = s.Replace("But now that the deduction has taken a different\r\ndirection...", "Mais maintenant que la déduction a pris une tout autre direction...");
                s = s.Replace("...Iris doesn't seem to be trying to hide the broken cup any\r\nmore.", "...Iris ne semble plus du tout essayer de cacher la tasse brisée.");
                s = s.Replace("In other words, <E003 8>her great secret is something else.", "En d'autres termes, <E003 8>son grand secret est tout autre.");
                s = s.Replace("(Let's put our <E006>observational skills<E007> to work here one final\r\ntime then...)", "(Mettons donc nos <E006>talents d'observation<E007> à l'épreuve une ultime fois...)");
                return s;
            };

            // [85] BB\script\output\_sce03_c203_0040_eng#47
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#47"] = (en) => {
                string s = en;
                s = s.Replace("Ah!<E003 10> Look!<E003 12> <E025 3>There, <E003 6><E025 2>there seem to be more papers there...", "Ah !<E003 10> Regardez !<E003 12> <E025 3>Là, <E003 6><E025 2>il semble y avoir d'autres documents...");
                s = s.Replace("(Is Iris trying to hide them underneath the tray?)", "(Est-ce qu'Iris essaie de les cacher sous le plateau ?)");
                s = s.Replace("The, <E003 8>the insignia, <E003 8>Mr Naruhodo!", "L'...<E003 8>l'insigne, <E003 8>M. Naruhodo !");
                s = s.Replace("It's an official <E006>Scotland Yard<E005> document!", "C'est un document officiel de <E006>Scotland Yard<E005> !");
                s = s.Replace("What?<E003 14> <E604><E025 1>But...<E003 12>why would Iris have...?", "Quoi ?<E003 14> <E604><E025 1>Mais...<E003 12>pourquoi Iris aurait-elle... ?");
                s = s.Replace("We must ask her!", "Nous devons lui demander !");
                s = s.Replace("(An official Scotland Yard document...)", "(Un document officiel de Scotland Yard...)");
                return s;
            };

            // [86] BB\script\output\_sce03_c203_0040_eng#48
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#48"] = (en) => {
                string s = en;
                s = s.Replace("Mr Sholmes's favourite cup...", "La tasse préférée de M. Sholmes...");
                s = s.Replace("Or what's left of it.<E003 12> <E043><E025 3>Just the handle.", "Ou ce qu'il en reste.<E003 12> <E043><E025 3>Juste l'anse.");
                s = s.Replace("It was obviously hurled into the air along with Professor\r\nMikotoba.", "Elle a visiblement été projetée en l'air en même temps que le professeur Mikotoba.");
                s = s.Replace("If only it had been this cup that had caught on his finger\r\nbefore it hit the floor.", "Si seulement c'était cette tasse qui s'était accrochée à son doigt avant de toucher le sol.");
                s = s.Replace("Yes...<E003 10> But anyway, <E003 6><E025 3>whatever Iris is trying to hide...", "Oui...<E003 10>Mais quoi qu'il en soit, <E003 6><E025 3>quoi qu'Iris essaie de cacher...");
                s = s.Replace("...it's clearly not this handle.", "...ce n'est manifestement pas cette anse.");
                return s;
            };

            // [87] BB\script\output\_sce03_c203_0040_eng#49
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#49"] = (en) => {
                string s = en;
                s = s.Replace("Surely this time –<E003 6> at last –<E003 10> <E025 1><E333>the knapsack is going to be the\r\nanswer!", "Cette fois à coup sûr –<E003 6> enfin ! –<E003 10> <E025 1><E333>ce sac à dos va être la réponse !");
                s = s.Replace("...I'm really not sure why you're so intent on showing\r\nIris's bag to be complicit in these events.", "...Je ne comprends vraiment pas pourquoi vous tenez tant à prouver que le sac d'Iris est complice de ces événements.");
                s = s.Replace("Because!<E003 12> <E341>It's a sizeable bag, <E003 8>big enough for a sizeable–", "Parce que !<E003 12> <E341>C'est un sac colossal, <E003 8>assez grand pour un secret–");
                s = s.Replace("Big enough to carry things around, <E003 6>Mr Naruhodo!<E003 12>\r\n<E025 2>That's what bags are for.", "Assez grand pour transporter des affaires, <E003 6>M. Naruhodo !<E003 12>\r\n<E025 2>C'est à ça que servent les sacs.");
                s = s.Replace("...So...<E003 14><E025 2><E239>the knapsack might never see the limelight,<E003 6> you\r\nmean?", "...Alors...<E003 14><E025 2><E239>le sac à dos ne connaîtra peut-être jamais la gloire des projecteurs, <E003 6>vous voulez dire ?");
                s = s.Replace("...I really wouldn't like to say.", "...Je préfère ne pas me prononcer.");
                return s;
            };

            // [88] BB\script\output\_sce03_c203_0040_eng#50
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#50"] = (en) => {
                string s = en;
                s = s.Replace("We were very nearly taken in completely by Iris then,<E003 8>\r\nweren't we?", "Nous avons bien failli être totalement bernés par Iris, <E003 8>n'est-ce pas ?");
                s = s.Replace("It's rather charming that you could be deceived by a\r\nten-year-old girl, <E003 6>I think.", "Je trouve plutôt charmant que vous puissiez vous faire berner par une fillette de dix ans, <E003 6>à vrai dire.");
                s = s.Replace("...I don't think it was only me.", "...Je ne crois pas avoir été le seul.");
                s = s.Replace("No, <E003 8>you're right.", "Non, <E003 8>vous avez raison.");
                s = s.Replace("I think what Iris is hiding...", "Je pense que ce qu'Iris dissimule...");
                s = s.Replace("...must be extremely important somehow.<E003 10>\r\n<E025 2>Don't you?", "...doit être d'une importance capitale d'une manière ou d'une autre.<E003 10>\r\n<E025 2>Vous ne croyez pas ?");
                s = s.Replace("...Yes.", "...Oui.");
                s = s.Replace("(We're so close now!<E003 10>\r\n<E025 1><E346>This <E006>great deduction<E007> is within our grasp,<E003 6> I'm sure!)", "(Nous touchons au but !<E003 10>\r\n<E025 1><E346>Ce <E006>grand spectacle de déduction<E007> est à portée de main, <E003 6>j'en suis sûr !)");
                return s;
            };

            // [89] BB\script\output\_sce03_c203_0040_eng#52
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#52"] = (en) => {
                string s = en;
                s = s.Replace("Yes, <E049><E003 8><E025 2>it's Mr Sholmes's coffee cup.", "Oui, <E049><E003 8><E025 2>c'est la tasse de café de M. Sholmes.");
                s = s.Replace("That's what Iris was trying to leave with, <E049><E003 6>before anyone\r\nnoticed it was broken.", "C'est ce avec quoi Iris tentait de partir, <E049><E003 6>avant que quiconque ne remarque qu'elle était cassée.");
                s = s.Replace("But she doesn't appear to be making any attempt to shield\r\nit from view.", "Mais elle ne semble aucunement chercher à la dissimuler aux regards.");
                return s;
            };

            // [90] BB\script\output\_sce03_c203_0040_eng#53
            entryTranslators[@"BB\script\output\_sce03_c203_0040_eng#53"] = (en) => {
                string s = en;
                s = s.Replace("If Iris was attempting to sneak away with something else,<E049><E003 8>\r\nthen she must be hiding it somewhere.", "Si Iris essayait de s'éclipser avec autre chose, <E049><E003 8>elle doit forcément le cacher quelque part.");
                s = s.Replace("And as far as I can tell...", "Et d'après ce que je peux en juger...");
                s = s.Replace("...there's really nowhere else she could conceal anything\r\nbut in that bag.", "...il n'y a nulle part ailleurs où elle pourrait cacher quoi que ce soit, si ce n'est dans ce sac.");
                s = s.Replace("Perhaps you'll allow me to offer an opinion here.", "Peut-être me permettrez-vous de donner mon avis là-dessus.");
                s = s.Replace("As far as I can tell...<E003 10>much like that bag, <E049><E003 6><E025 1><E164 19 113 1 2 5 0 2 1><E139 19><E145 1 2><E492 1 -143 0 0>your deduction\r\ndoesn't hold water, <E049><E003 6>my dear fellow", "Pour autant que je sache...<E003 10>tout comme ce sac, <E049><E003 6><E025 1><E164 19 113 1 2 5 0 2 1><E139 19><E145 1 2><E492 1 -143 0 0>votre déduction ne tient pas la route, <E049><E003 6>mon cher ami");
                s = s.Replace("I wasn't suggesting she was trying to make off with a bag\r\nfull of water.", "Je ne suggérais pas qu'elle essayait de s'enfuir avec un sac rempli d'eau.");
                s = s.Replace("Indeed.<E003 10> <E341>That would be madness.", "En effet.<E003 10> <E341>Ce serait de la folie pure.");
                return s;
            };
        }
    }
}
