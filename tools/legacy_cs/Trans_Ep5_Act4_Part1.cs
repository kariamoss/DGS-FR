using System;

namespace TranslatorEp5Act4 {
    public partial class Program {
        public static void RegisterPart1() {
            // [0] _sce04_bg0500_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#1"] = (en) => {
                string s = en;
                R(ref s, "Nothing much of note here, I'd say.", "Rien de bien particulier par ici, je dirais.");
                return s;
            };

            // [1] _sce04_bg0500_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#2"] = (en) => {
                string s = en;
                R(ref s, "Quite the exquisite glass,<E049><E003 8> I must say.", "Un verre tout à fait exquis,<E049><E003 8> je dois dire.");
                R(ref s, "See here,<E049><E003 6> how it<E025 7>...<E003 2><E089 10 7>...<E003 4>...<E003 25>", "Regardez cela,<E049><E003 6> comme il<E025 7>...<E003 2><E089 10 7>...<E003 4>...<E003 25>");
                R(ref s, "Is, <E003 10>is something wrong, Sholmes?<E003 10>\r\n<E025 3>You suddenly trailed off...", "Y a-t-il, <E003 10>y a-t-il un problème, Sholmes ?<E003 10>\r\n<E025 3>Vous vous êtes interrompu si soudainement...");
                R(ref s, "<E006>Ice<E005>, <E049><E003 6>Mikotoba, <E006><E049><E003 10>ice<E005>!<E049><E003 12> <E025 2>What opulence the first-class\r\npassengers enjoy:<E049><E003 10> chilled drinks.", "De la <E006>glace<E005>, <E049><E003 6>Mikotoba, <E006><E049><E003 10>de la glace<E005> !<E049><E003 12> <E025 2>Quelle opulence pour les\r\npassagers de première classe :<E049><E003 10> des boissons fraîches.");
                R(ref s, "Pardon?", "Pardon ?");
                R(ref s, "Could it be that this steamship is equipped with an\r\nelectrically refrigerated cold room, <E049><E003 8><E025 2>do you think?<E003 5><E089 0 7>", "Se pourrait-il que ce navire soit équipé d'une chambre\r\nfroide réfrigérée à l'électricité, <E049><E003 8><E025 2>selon vous ?<E003 5><E089 0 7>");
                R(ref s, "Well...<E003 10><E025 2>it is a luxury liner, <E003 4>after all.", "Eh bien...<E003 10><E025 2>c'est un paquebot de luxe, <E003 4>après tout.");
                R(ref s, "They have enormous refrigerators for storing all sorts<E145 2 64> of\r\nlavish produce as well as ice.", "Ils possèdent d'immenses réfrigérateurs pour stocker toutes sortes<E145 2 64> de\r\nproduits somptueux ainsi que de la glace.");
                R(ref s, "On our voyage from Japan, <E003 8>we enjoyed culinary delights\r\nfrom all over the world.", "Pendant notre traversée depuis le Japon, <E003 8>nous avons savouré des mets exquis\ndu monde entier.");
                R(ref s, "Hm, <E049><E003 8><E025 2>suddenly, Mikotoba...", "Hum, <E049><E003 8><E025 2>tout à coup, Mikotoba...");
                R(ref s, "...the sight of you is making my mouth water.", "...la simple vue de votre personne me met l'eau à la bouche.");
                R(ref s, "I haven't taken on the flavour of the food I ate,<E003 6> you know.", "Je n'ai pas pris la saveur des mets que j'ai dégustés,<E003 6> vous savez.");
                return s;
            };

            // [2] _sce04_bg0500_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#3"] = (en) => {
                string s = en;
                R(ref s, "The wall is a slightly different colour just here.<E003 10>\r\n<E025 2>Do you see?", "Le mur est d'une couleur légèrement différente juste ici.<E003 10>\r\n<E025 2>Vous voyez ?");
                R(ref s, "Indeed.<E049><E003 12> What you have observed arises when a frame\r\nthat has been hanging for some time is removed.", "En effet.<E049><E003 12> Ce que vous observez arrive lorsqu'un cadre\naccroché depuis un certain temps est retiré.");
                R(ref s, "Perhaps <E049><E003 10>your friend is an art thief.", "Peut-être <E049><E003 10>que votre ami est un voleur d'œuvres d'art.");
                R(ref s, "Now there's a bold deduction worthy of a great detective,<E003 6>\r\n<E025 3>I'm sure.", "Voilà une déduction audacieuse bien digne d'un grand détective,<E003 6>\r\n<E025 3>j'en suis convaincu.");
                R(ref s, "He may very well be the illusive thief who has been\r\nplaguing France's galleries of late.", "Il pourrait très bien être cet insaisissable voleur qui\nécume les galeries françaises ces derniers temps.");
                R(ref s, "...I think perhaps we should focus our attentions\r\nelsewhere, Sholmes,<E003 8> <E025 3>don't you?", "...Je crois que nous devrions plutôt concentrer notre attention\nailleurs, Sholmes,<E003 8> <E025 3>vous ne trouvez pas ?");
                R(ref s, "(That outline on the wall...)", "(Cette trace sur le mur...)");
                R(ref s, "(I feel as though I might have spotted something of a\r\nsimilar shape and size elsewhere.)", "(J'ai l'impression d'avoir aperçu quelque chose d'une\nforme et d'une taille similaires ailleurs.)");
                return s;
            };

            // [3] _sce04_bg0500_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#4"] = (en) => {
                string s = en;
                R(ref s, "This is the wastepaper basket, <E003 6>look.<E003 12>\r\n...And there's still rubbish inside.", "Voici la corbeille à papier, <E003 6>regardez.<E003 12>\r\n... Et il y a encore des détritus à l'intérieur.");
                R(ref s, "Indeed?<E049><E003 10> Then let us pry...", "Vraiment ?<E049><E003 10> Alors furetons...");
                R(ref s, "I've discovered recently I have a penchant for exploring\r\nthe contents of others' wastepaper baskets.", "Je me suis découvert récemment un penchant pour l'exploration\ndu contenu des corbeilles à papier d'autrui.");
                R(ref s, "I sincerely hope only for your work.", "J'espère sincèrement que c'est uniquement pour votre travail.");
                R(ref s, "Here we have a notice issued to passengers <E049><E003 8><E330><E025 3>from three\r\ndays ago.", "Nous avons ici une note distribuée aux passagers <E049><E003 8><E330><E025 3>il y a trois\r\njours.");
                R(ref s, "Three days ago?<E003 10> <E025 2>The night before we arrived in London,\r\nthen.", "Il y a trois jours ?<E003 10> <E025 2>La veille de notre arrivée à Londres,\r\nalors.");
                R(ref s, "When I was still aboard myself.", "Lorsque j'étais moi-même encore à bord.");
                R(ref s, "Ah yes...<E003 12><E025 2>there was an evacuation drill.<E003 10>\r\nI remember now.", "Ah oui...<E003 12><E025 2>il y a eu un exercice d'évacuation.<E003 10>\r\nJe me souviens, maintenant.");
                R(ref s, "For our safety and security, <E003 6>all first-class passengers\r\nwere constantly under the watchful eye of the crew.", "Pour notre sécurité, <E003 6>tous les passagers de première classe\nétaient sous la surveillance constante de l'équipage.");
                R(ref s, "So it was a welcome relief to have some privacy for once.", "Ce fut donc un soulagement bienvenu que d'avoir un peu d'intimité pour une fois.");
                R(ref s, "The evacuation drill itinerary has been\r\nentered into the Court Record.", "Le programme de l'exercice d'évacuation a été\najouté au dossier de l'affaire.");
                return s;
            };

            // [4] _sce04_bg0500_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#6"] = (en) => {
                string s = en;
                R(ref s, "There's a speaking tube here, <E003 6>look.<E003 12>\r\n<E025 2><E330>Though it's been stoppered with some cloth.", "Il y a un tube acoustique ici, <E003 6>regardez.<E003 12>\r\n<E025 2><E330>Bien qu'il ait été bouché avec un morceau de tissu.");
                R(ref s, "So the voices of the crewmen on the bridge aren't an\r\nannoyance, <E003 8>I suppose.", "Pour que les voix des marins sur la passerelle ne soient pas\nune gêne, <E003 8>je suppose.");
                R(ref s, "Or indeed <E049><E003 8><E330>so that the voices in this cabin aren't heard\r\nelsewhere.", "Ou bien <E049><E003 8><E330>pour que les voix dans cette cabine ne soient pas\nentendues ailleurs.");
                R(ref s, "Could something have happened in here that was for no\r\none else's ears, <E003 4>do you think?", "Se pourrait-il qu'il se soit passé quelque chose ici qui ne devait\nêtre entendu par personne d'autre, <E003 4>selon vous ?");
                R(ref s, "Either that, <E049><E003 8>or...", "Soit cela, <E049><E003 8>soit...");
                R(ref s, "...it could be to prevent snakes from entering.", "...ce pourrait être pour empêcher les serpents d'entrer.");
                R(ref s, "...That's really become a favourite case of yours, <E003 6>hasn't it?", "...C'est vraiment devenu votre affaire préférée, <E003 6>n'est-ce pas ?");
                return s;
            };

            // [5] _sce04_bg0500_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#8"] = (en) => {
                string s = en;
                R(ref s, "That's a very sizeable trunk indeed.", "C'est en effet une malle des plus imposantes.");
                R(ref s, "Seishiro is partial to all things large.", "Seishiro a un penchant pour tout ce qui est démesuré.");
                R(ref s, "And a rather clumsy fellow,<E003 6> if he failed to notice he'd left\r\nthat behind.", "Et c'est un homme plutôt maladroit,<E003 6> s'il n'a pas remarqué qu'il l'avait\nlaissée derrière lui.");
                R(ref s, "Perhaps <E003 10><E330>he left it on purpose.", "Peut-être <E003 10><E330>l'a-t-il laissée exprès.");
                R(ref s, "It's lighter than you might think, <E003 8>but still a hindrance to a\r\nspeedy escape.", "Elle est plus légère qu'on ne pourrait le croire, <E003 8>mais reste un obstacle pour une\nfuite rapide.");
                R(ref s, "...Hm, <E003 8>pity.<E003 12> <E333><E025 2>It's <E006>locked<E005>, <E003 8>so we can't look inside.", "...Hum, <E003 8>dommage.<E003 12> <E333><E025 2>Elle est <E006>verrouillée<E005>, <E003 8>nous ne pouvons donc pas regarder à l'intérieur.");
                R(ref s, "Surely five seconds from now the situation will be quite\r\ndifferent though?", "Pourtant, d'ici cinq secondes, la situation devrait être bien\ndifférente, non ?");
                R(ref s, "Sadly not.<E049><E003 10> <E025 2><E330>It has a seven-digit <E006>combination lock<E005>.", "Hélas non.<E049><E003 10> <E025 2><E330>Elle possède une <E006>serrure à combinaison<E005> à sept chiffres.");
                R(ref s, "And I'm not in a morose enough mood to work through\r\nall the combinations at present.", "Et je ne suis pas d'humeur assez morose pour tester toutes\nles combinaisons à l'heure actuelle.");
                return s;
            };

            // [6] _sce04_bg0500_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#9"] = (en) => {
                string s = en;
                R(ref s, "Plenty of reading material to keep passengers occupied on\r\nthe long sea voyages.", "De quoi lire en abondance pour occuper les passagers durant\nles longues traversées en mer.");
                R(ref s, "I found the mixture of classic literature and easy reading\r\nto be most satisfactory,<E003 6> I must say.", "J'ai trouvé ce mélange de chefs-d'œuvre et de lectures distrayantes\ntout à fait satisfaisant,<E003 6> je dois dire.");
                R(ref s, "...Tsk!<E049><E003 12> Whoever stocked this bookcase was a hopeless\r\nheretic.", "...Tss !<E049><E003 12> Quiconque a garni cette bibliothèque est un indécrottable\nhérétique.");
                R(ref s, "There's no copy of ‘The Adventures of Herlock Sholmes’,<E003 8>\r\nmy dear fellows!", "Il n'y a pas le moindre exemplaire des « Aventures d'Herlock Sholmes »,<E003 8>\nmes chers amis !");
                R(ref s, "Um...<E003 12>I'm afraid it's just me.<E003 10> <E025 2>But no, <E003 6>you're quite right.<E003 10>\r\n<E025 2><E145 2 64><E149 2 0 4>More blasphemous than overlooking the Bible.", "Euh...<E003 12>j'ai bien peur qu'il n'y ait que moi.<E003 10> <E025 2>Mais non, <E003 6>vous avez bien raison.<E003 10>\r\n<E025 2><E145 2 64><E149 2 0 4>Plus blasphématoire encore que d'oublier la Bible.");
                R(ref s, "I shall leave a copy behind.<E003 12>\r\nI just happen to have one with me.", "Je vais en laisser un exemplaire.<E003 12>\nIl se trouve justement que j'en ai un sur moi.");
                R(ref s, "You're a true missionary of the Church of Great\r\nDetectives, <E003 6>aren't you?", "Vous êtes un véritable apôtre de l'Église des Grands\nDétectives, <E003 6>n'est-ce pas ?");
                return s;
            };

            // [7] _sce04_bg0500_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#10"] = (en) => {
                string s = en;
                R(ref s, "All the doors on this vessel have locks, <E003 6>I believe.", "Toutes les portes de ce navire ont une serrure, <E003 6>me semble-t-il.");
                R(ref s, "A wise idea.<E049><E003 10> You never know where and when criminals\r\nmay strike.", "Une sage idée.<E049><E003 10> On ne sait jamais où et quand les criminels\npeuvent frapper.");
                R(ref s, "But of course, <E049><E003 8><E025 2>to the great detective Herlock Sholmes...", "Mais bien entendu, <E049><E003 8><E025 2>pour le grand détective Herlock Sholmes...");
                R(ref s, "...lock, <E003 6>bolt <E003 6>or shirt button, <E049><E003 10><E330>it makes no difference.", "...serrure, <E003 6>verrou <E003 6>ou bouton de chemise, <E049><E003 10><E330>cela ne fait aucune différence.");
                R(ref s, "All are unfastened with equal ease!", "Tous se délient avec la même aisance !");
                R(ref s, "The way you go on, <E003 8><E341>you sound rather more like a great\r\nthief than a great detective.", "À vous entendre, <E003 8><E341>on croirait entendre un grand\ncambrioleur plutôt qu'un grand détective.");
                R(ref s, "My dear Mikotoba, <E049><E003 8>as long as there is greatness,<E049><E003 6> I am\r\nquite satisfied.", "Mon cher Mikotoba, <E049><E003 8>pourvu qu'il y ait de la grandeur,<E049><E003 6> j'en suis\npleinement satisfait.");
                R(ref s, "Haah...<E003 12> <E025 2>Of course you are.", "Haah...<E003 12> <E025 2>Évidemment.");
                return s;
            };

            // [8] _sce04_bg0500_0_check_eng#11
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#11"] = (en) => {
                string s = en;
                R(ref s, "According to the report I was given, <E003 8>Naruhodo was\r\nconcealing himself in Asogi's wardrobe.", "D'après le rapport qui m'a été remis, <E003 8>Naruhodo se\ncachait dans la penderie d'Asogi.");
                R(ref s, "Indeed he was.<E049><E003 10> <E025 2>And it was of a similar size to this one.", "Tout à fait.<E049><E003 10> <E025 2>Et elle était de taille similaire à celle-ci.");
                R(ref s, "Ah!<E003 10> <E025 1>You must climb inside yourself, <E049><E003 6>my dear fellow!", "Ah !<E003 10> <E025 1>Vous devez grimper à l'intérieur vous-même, <E049><E003 6>mon cher ami !");
                R(ref s, "What?<E003 15>\r\n<E341>Whatever for?", "Quoi ?<E003 15>\r\n<E341>Et pour quoi faire ?");
                R(ref s, "It was the site of my first fateful meeting with\r\nMr Naruhodo.", "Ce fut le théâtre de ma première rencontre fatidique avec\nM. Naruhodo.");
                R(ref s, "You can experience the moment for yourself now!<E049><E003 12>\r\nComplete with my dramatic rhetoric!", "Vous pouvez vivre ce moment par vous-même à présent !<E049><E003 12>\nAvec toute mon envolée théâtrale !");
                R(ref s, "Come along now!<E049><E003 10> In you go!<E049><E003 14>\r\n<E332>This will only take a moment.", "Allez, venez !<E049><E003 10> Hop, dedans !<E049><E003 14>\r\n<E332>Cela ne prendra qu'un instant.");
                R(ref s, "Really, Sholmes, <E003 10><E341>surely you can just tell me what you\r\nsaid!", "Voyons, Sholmes, <E003 10><E341>vous pouvez bien vous contenter de me raconter ce que vous\navez dit !");
                R(ref s, "Well...<E003 12><E025 1><E238>I uttered some brilliant remark and opened the\r\nwardrobe to reveal the stowaway murderer!", "Eh bien...<E003 12><E025 1><E238>j'ai prononcé une brillante tirade et ouvert la\npenderie pour dévoiler le meurtrier clandestin !");
                R(ref s, "...I think I'll just read about it in ‘The Adventures of\r\nHerlock Sholmes’.", "...Je crois que je me contenterai de le lire dans « Les Aventures d'Herlock Sholmes ».");
                return s;
            };

            // [9] _sce04_bg0500_0_check_eng#12
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#12"] = (en) => {
                string s = en;
                R(ref s, "These are the ‘Rules of Passage’.", "Voici le « Règlement de la traversée ».");
                R(ref s, "‘Passengers must not keep weapons or other dangerous\r\nobjects in their cabins.<E003 8> Pets are also strictly forbidden.’", "« Il est interdit aux passagers de détenir des armes ou autres\nobjets dangereux dans les cabines.<E003 8> Les animaux sont strictement prohibés. »");
                R(ref s, "‘Additionally, <E003 8>there are severe punishments for stowing\r\naway in wardrobes and/or travel cases.’", "« En outre, <E003 8>de lourdes peines sanctionnent tout clandestin\n Dissimulé dans une penderie et/ou une malle de voyage. »");
                R(ref s, "I feel the rules have increased since I last read them.<E049><E003 4><E145 2 64><E003 20>\r\n<E025 2>...Probably just my imagination.", "J'ai l'impression que les règles se sont multipliées depuis la dernière fois.<E049><E003 4><E145 2 64><E003 20>\r\n<E025 2>...Sans doute juste mon imagination.");
                R(ref s, "What about the fact that they're not straight on the wall?<E003 10>\r\nDoesn't that strike you?", "Et le fait que l'affiche ne soit pas droite sur le mur ?<E003 10>\nCela ne vous frappe pas ?");
                R(ref s, "Hm, <E003 10><E169 2 3>you may be right.<E049><E003 10>\r\n<E025 2>...Probably just your imagination, though.<E049><E003 8> A trifle.", "Hum, <E003 10><E169 2 3>vous avez peut-être raison.<E049><E003 10>\r\n<E025 2>...Mais probablement juste votre imagination.<E049><E003 8> Une broutille.");
                R(ref s, "And you know what I always say, Mikotoba:<E049><E003 4> <E164 2 71 1 2 7 0 0 1><E139 2>there is\r\nnothing important about trifles.", "Et vous savez ce que je dis toujours, Mikotoba :<E049><E003 4> <E164 2 71 1 2 7 0 0 1><E139 2>les\nbroutilles n'ont strictement aucune importance.");
                R(ref s, "...It's probably just my imagination, <E003 8>but I think THAT\r\nmight be slightly off.", "...C'est probablement juste mon imagination, <E003 8>mais je crois que CELA\nest légèrement à côté de la plaque.");
                return s;
            };

            // [10] _sce04_bg0500_0_check_eng#13
            entryTranslators["BB\\script\\output\\_sce04_bg0500_0_check_eng#13"] = (en) => {
                string s = en;
                R(ref s, "That's a substantial heap of clothes on the floor.", "Voilà un monceau de vêtements bien conséquent sur le plancher.");
                R(ref s, "An overcoat, <E003 6>shirts, <E003 6>a dressing gown...", "Un manteau, <E003 6>des chemises, <E003 6>une robe de chambre...");
                R(ref s, "Momohiki work trousers, <E003 6>a tanzen robe, <E003 6>a haramaki\r\nwaist band...<E003 10> <E341><E025 2>Clearly the clothing of a Japanese man.", "Un pantalon momohiki, <E003 6>un kimono tanzen, <E003 6>une ceinture\nharamaki...<E003 10> <E341><E025 2>Manifestement la garde-robe d'un Japonais.");
                R(ref s, "And clearly, <E049><E003 8>Japanese men are unaccustomed to the\r\nculture of the wardrobe.", "Et manifestement, <E049><E003 8>les hommes japonais sont peu familiers de la\ncoutume des penderies.");
                R(ref s, "It looks to me as if they've been thrown in a heap like that<E003 6>\r\nin something of a hurry.", "On dirait bien qu'ils ont été jetés ainsi pêle-mêle<E003 6>\ndans une hâte certaine.");
                R(ref s, "Indeed.<E049><E003 10> <E025 2>You could help yourself to a Japanese man's shirt\r\nperhaps?", "En effet.<E049><E003 10> <E025 2>Vous pourriez peut-être vous servir d'une chemise japonaise ?");
                R(ref s, "I'm sure you made mention of packing too few.", "Il me semble bien que vous disiez en avoir emporté trop peu.");
                R(ref s, "I'd very likely drown in one of Seishiro's shirts.<E003 12>\r\n<E025 3>No, <E003 8><E025 2>I'll just buy any extras I need, I think.", "Je me noierais fort probablement dans l'une des chemises de Seishiro.<E003 12>\r\n<E025 3>Non, <E003 8><E025 2>j'achèterai ce qu'il me faut, je pense.");
                return s;
            };

            // [11] _sce04_bg0501_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#1"] = (en) => {
                string s = en;
                R(ref s, "Nothing much of note here, I'd say.", "Rien de bien particulier par ici, je dirais.");
                return s;
            };

            // [12] _sce04_bg0501_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#2"] = (en) => {
                string s = en;
                R(ref s, "No, <E003 8>I think not.<E003 10>\r\n<E025 2>That would never work, surely...", "Non, <E003 8>je ne pense pas.<E003 10>\r\n<E025 2>Cela ne fonctionnerait jamais, voyons...");
                R(ref s, "I need to concoct another distraction...", "Il faut que je trouve une autre diversion...");
                return s;
            };

            // [13] _sce04_bg0501_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#3"] = (en) => {
                string s = en;
                R(ref s, "This would appear to be an alarm bell.", "Cela semble être une cloche d'alarme.");
                R(ref s, "All hell would break loose if that thing were to ring.<E003 12>\r\n<E025 3>The whole crew would know about it.", "Ce serait un branle-bas de combat général si cette chose sonnait.<E003 12>\r\n<E025 3>Tout l'équipage rappliquerait sur-le-champ.");
                return s;
            };

            // [14] _sce04_bg0501_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#4"] = (en) => {
                string s = en;
                R(ref s, "Here goes, then.<E003 15> <E025 1><E346>Pardon me in advance!", "Allons-y, alors.<E003 15> <E025 1><E346>Pardonnez-moi par avance !");
                R(ref s, "Ding-aling-aling-aling-aling-aling-aling", "Dring-drelin-drelin-drelin-drelin-drelin");
                R(ref s, "You!<E049><E003 15> <E025 1><E335>What are you doing?", "Vous !<E049><E003 15> <E025 1><E335>Qu'est-ce que vous faites ?");
                R(ref s, "If we were at sea, <E049><E003 12><E046>that would be very bad problem!", "Si nous être en pleine mer, <E049><E003 12><E046>très gros problème !");
                R(ref s, "What's going on down there?!<E003 15>\r\n<E335>Seaman Strogenov!<E003 12> <E341>Report at once!", "Que se passe-t-il là-bas ?!<E003 15>\r\n<E335>Matelot Strogenov !<E003 12> <E341>Rapportez immédiatement !");
                R(ref s, "Sorry, sir!<E049><E003 12> <E025 1><E331>Nothing to report!<E049><E003 12>\r\n<E341>It was just stupid trick!", "Pardon, capitaine !<E049><E003 12> <E025 1><E331>Rien à signaler !<E049><E003 12>\r\n<E341>C'était juste farce stupide !");
                R(ref s, "...No, <E049><E003 10>not by me!<E003 12> <E025 2>By world-famous–<E003 12>\r\n<E025 1><E331>No!<E003 12> <E025 2>As I told you...", "...Non, <E049><E003 10>pas par moi !<E003 12> <E025 2>Par un célèbre mond–<E003 12>\r\n<E025 1><E331>Non !<E003 12> <E025 2>Comme je vous disais...");
                R(ref s, "Now, Sholmes!<E003 9> Now!", "Maintenant, Sholmes !<E003 9> Allez !");
                R(ref s, "...Done.", "...C'est fait.");
                R(ref s, "Not even five seconds, <E003 4>eh?", "Pas même cinq secondes, <E003 4>hein ?");
                R(ref s, "Well don't stand there gawping at my brilliance,\r\nMikotoba!<E049><E003 6> <E025 1><E164 2 81 1 2 8 0 1 1><E118 2 1.3><E139 2>In we go!", "Ne restez pas là béat devant mon éclat de génie,\nMikotoba !<E049><E003 6> <E025 1><E164 2 81 1 2 8 0 1 1><E118 2 1.3><E139 2>Entrons !");
                R(ref s, "Oh!<E003 12> Yes...", "Oh !<E003 12> Oui...");
                return s;
            };

            // [15] _sce04_bg0501_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#5"] = (en) => {
                string s = en;
                R(ref s, "This must be a mousetrap, I think.", "Ce doit être une souricière, je pense.");
                R(ref s, "Perhaps I could distract the crewman's attention with this\r\nsomehow...", "Peut-être pourrais-je distraire l'attention du marin avec ceci\nd'une façon ou d'une autre...");
                return s;
            };

            // [16] _sce04_bg0501_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#6"] = (en) => {
                string s = en;
                R(ref s, "...*Snap!*", "...*CLAC !*");
                R(ref s, "Chuuuuuu, chuuuuuu!", "Chouuuuuu, chouuuuuu !");
                R(ref s, "That sounds like big mouse in trap.", "Ça ressemble à grosse souris dans piège.");
                R(ref s, "I will bring bucket of water later and put out of misery.", "J'amènerai seau d'eau plus tard et abrégerai ses souffrances.");
                R(ref s, "(I don't like the sound of that.)", "(Je n'aime guère la tournure de cette histoire.)");
                R(ref s, "In any case, <E049><E003 4>my dear fellow, <E049><E003 8>that was quite unconvincing.<E049><E003 4>\r\n<E025 1><E164 2 81 1 2 5 0 2 1><E139 2>Only Japanese mice make a ‘chu’ sound.", "En tout état de cause, <E049><E003 4>mon cher ami, <E049><E003 8>ce n'était guère convaincant.<E049><E003 4>\r\n<E025 1><E164 2 81 1 2 5 0 2 1><E139 2>Seules les souris japonaises font un bruit de « chū ».");
                R(ref s, "Oh really, Sholmes?<E003 12> And pray tell, <E003 8>what sound do Russian\r\nmice make?", "Vraiment, Sholmes ?<E003 12> Et dites-moi un peu, <E003 8>quel bruit font les souris\nrusses ?");
                R(ref s, "‘Pii pii’<E049><E003 8> naturally.<E049><E003 10>\r\n<E025 1><E164 2 79 1 2 7 0 0 1><E139 2>Though also quite unconvincing, <E049><E003 8>I readily admit.", "« Pii pii »,<E049><E003 8> naturellement.<E049><E003 10>\r\n<E025 1><E164 2 79 1 2 7 0 0 1><E139 2>Bien que tout aussi peu convaincant, <E049><E003 8>je le reconnais bien.");
                R(ref s, "So go ahead, Mikotoba.<E049><E003 10> Do a ‘pii pii’ this time!", "Alors allez-y, Mikotoba.<E049><E003 10> Faites-nous un « pii pii » cette fois !");
                R(ref s, "...No thank you.<E003 10>\r\n<E025 2>I'm sure I can come up with an alternative solution.", "...Non merci.<E003 10>\r\n<E025 2>Je trouverai certainement une solution de rechange.");
                return s;
            };

            // [17] _sce04_bg0501_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#7"] = (en) => {
                string s = en;
                R(ref s, "Ah, <E003 8>the switch for the electrical lights.", "Ah, <E003 8>l'interrupteur des lumières électriques.");
                R(ref s, "Perhaps if I were to turn off the lights, <E003 8>the crewman\r\nwouldn't be able to see what we were doing...", "Peut-être que si j'éteignais les lumières, <E003 8>le marin\nne pourrait pas voir ce que nous faisons...");
                return s;
            };

            // [18] _sce04_bg0501_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#8"] = (en) => {
                string s = en;
                R(ref s, "...*Click*", "...*Clic*");
                R(ref s, "Agh!<E003 10> What is happening?<E003 12>\r\n<E341>Where is light?", "Aaargh !<E003 10> Que se passe-t-il ?<E003 12>\r\n<E341>Où être la lumière ?");
                R(ref s, "Now, <E003 8>Sholmes!<E003 12> <E332>Now!", "Maintenant, <E003 8>Sholmes !<E003 12> <E332>Vite !");
                R(ref s, "*Thud!<E003 8> <E025 1><E342>Thump!*", "*VLAN !<E003 8> <E025 1><E342>PAF !*");
                R(ref s, "*Click*", "*Clic*");
                R(ref s, "Hmph.<E003 12> <E169 51 3>Nobody there...", "Humph.<E003 12> <E169 51 3>Personne...");
                R(ref s, "(That was a close shave.)", "(C'était moins une.)");
                R(ref s, "Quite a knack you have, <E049><E003 10><E025 2><E239>stumbling so violently in an\r\napparently empty corridor.", "Vous avez un sacré talent, <E049><E003 10><E025 2><E239>pour trébucher si violemment dans un\ncouloir visiblement vide.");
                R(ref s, "...Do be quiet, Sholmes.<E049><E003 10>\r\n<E025 2>I shall have to think of another approach.", "...Taisez-vous donc, Sholmes.<E049><E003 10>\r\n<E025 2>Il va falloir que je songe à une autre approche.");
                return s;
            };

            // [19] _sce04_bg0501_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#9"] = (en) => {
                string s = en;
                R(ref s, "That's the way back to the deck.<E003 10>\r\n<E025 2>But we certainly can't give up on this now...", "C'est la voie pour regagner le pont.<E003 10>\r\n<E025 2>Mais nous ne pouvons certainement pas abandonner maintenant...");
                return s;
            };

            // [20] _sce04_bg0501_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#10"] = (en) => {
                string s = en;
                R(ref s, "He's like a Nioh temple guardian statue, <E003 8>this fellow,<E003 8> <E025 2>the\r\nway he's glaring at us so fiercely.", "Il ressemble à une statue de gardien Niō, <E003 8>ce gaillard,<E003 8> <E025 2>avec son\nregard si férocement braqué sur nous.");
                R(ref s, "Tell me, <E003 8>why are you standing guard here if the cabin is\r\nunoccupied?", "Dites-moi, <E003 8>pourquoi montez-vous la garde ici si la cabine est\ninoccupée ?");
                R(ref s, "Because this area is only for first-class passengers.", "Parce que zone réservée passagers de première classe.");
                R(ref s, "We must look out for suspicious kriminals.", "Nous devons surveiller kriminels suspects.");
                R(ref s, "(He was looking straight at me when he said that.)", "(Il me fixait droit dans les yeux en disant ça.)");
                R(ref s, "My dear fellow, <E049><E003 10>as you can plainly see, <E049><E003 10><E333>we are quite\r\nunsuspicious as criminals go.", "Mon cher ami, <E049><E003 10>comme vous le voyez fort bien, <E049><E003 10><E333>nous n'avons rien\nde suspect pour des criminels.");
                R(ref s, "...But still kriminals.", "...Mais toujours kriminels.");
                R(ref s, "No no no!<E003 12> For goodness' sake, Sholmes, <E003 8>tell the man!<E003 12>\r\n<E341>We're neither suspicious nor criminals!", "Non non non !<E003 12> Par pitié, Sholmes, <E003 8>dites-lui !<E003 12>\r\n<E341>Nous ne sommes ni suspects ni criminels !");
                R(ref s, "Ah yes!<E003 10> <E025 2>Quite right, Mikotoba.", "Ah oui !<E003 10> <E025 2>Tout à fait, Mikotoba.");
                R(ref s, "Curses!<E003 12> <E341>This seaman is far too able for his own good!", "Peste !<E003 12> <E341>Ce matelot est bien trop clairvoyant pour son propre bien !");
                R(ref s, "...Be extremely careful in what you say!", "...Faites extrêmement attention à ce que vous dites !");
                R(ref s, "(One of us ought to be, <E003 6><E341><E025 3>yes.)", "(L'un de nous deux devrait l'être, <E003 6><E341><E025 3>en effet.)");
                return s;
            };

            // [21] _sce04_bg0501_0_check_eng#11
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#11"] = (en) => {
                string s = en;
                R(ref s, "That's another first-class cabin, <E003 6><E025 3>and yet its door is\r\ncompletely unguarded.", "Voilà une autre cabine de première classe, <E003 6><E025 3>et pourtant sa porte est\ntotalement sans garde.");
                R(ref s, "Empty as well.<E049><E003 10> <E025 2>I had a quick look inside earlier.", "Vide également.<E049><E003 10> <E025 2>J'ai jeté un coup d'œil à l'intérieur plus tôt.");
                R(ref s, "Though I confess, <E049><E003 8>I didn't investigate the wardrobe.", "Bien que je confesse <E049><E003 8>ne pas avoir fouillé la penderie.");
                R(ref s, "There may very well be a young Japanese fellow inside,<E049><E003 8>\r\nperspiring merrily.", "Il se pourrait fort qu'un jeune Japonais s'y trouve,<E049><E003 8>\nsuant à grosses gouttes.");
                R(ref s, "If you're referring to Naruhodo, <E003 8>you know very well that\r\nhe's currently perspiring merrily in court.", "Si vous pensez à Naruhodo, <E003 8>vous savez pertinemment qu'il\nsue actuellement à grosses gouttes au tribunal.");
                R(ref s, "Does it not strike you though, <E003 4>Mikotoba?", "Cela ne vous interpelle pas, <E003 4>Mikotoba ?");
                R(ref s, "Why the man stands guard only in front of this cabin,<E049><E003 10>\r\n<E025 3><E333>when both are apparently vacant...", "Pourquoi cet homme monte la garde devant cette seule cabine,<E049><E003 10>\r\n<E025 3><E333>alors que toutes deux sont manifestement inoccupées...");
                return s;
            };

            // [22] _sce04_bg0501_0_check_eng#12
            entryTranslators["BB\\script\\output\\_sce04_bg0501_0_check_eng#12"] = (en) => {
                string s = en;
                R(ref s, "That's a speaking tube for members of the crew to\r\ncommunicate with one another around the ship.", "C'est un tube acoustique pour permettre à l'équipage de\ncommuniquer d'un bout à l'autre du navire.");
                R(ref s, "If I could just persuade our stocky sailor friend that he\r\nneeded to use it...", "Si je pouvais persuader notre vigoureux marin qu'il\ndoit s'en servir...");
                R(ref s, "...Sholmes could unlock the door whilst he was\r\ndistracted.", "...Sholmes pourrait crocheter la serrure pendant qu'il\na le dos tourné.");
                R(ref s, "The question is...<E003 12><E330>how?", "Reste à savoir...<E003 12><E330>comment ?");
                return s;
            };
        }
    }
}
