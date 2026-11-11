using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorEp5Act5 {
    public partial class Program {
        public static void RegisterPart2_B() {
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#21"] = en => {
                string s = en;
                R(ref s, "So this little part of Inspector Gregson's pocket watch was\r\nfound inside Judge Jigoku's trunk.",
                         "Cette petite pièce de la montre de l'inspecteur Gregson\r\na donc été trouvée dans la malle du juge Jigoku.");
                R(ref s, "That's right.<E003 10> <E025 2>Which it cannot possibly be denied is\r\nextremely significant.",
                         "C'est exact.<E003 10> <E025 2>Et nul ne peut nier qu'il s'agit là\r\nd'un fait capital.");
                R(ref s, "And what do you call it again?<E003 12>\r\n<E025 2><E330>This small, <E003 6>round piece of the watch.",
                         "Et comment l'appelle-t-on, déjà ?<E003 12>\r\n<E025 2><E330>Cette petite pièce ronde <E003 6>de la montre.");
                R(ref s, "The crown.<E003 12> A pocket watch is quite useless without it.",
                         "La couronne.<E003 12> Une montre à gousset est tout à fait inutile sans elle.");
                R(ref s, "Yes, <E003 6>that's right.<E003 8> The crown.<E003 10> <E025 2>What a very grand name for\r\nsuch a tiny part.",
                         "Oui, <E003 6>c'est cela.<E003 8> La couronne.<E003 10> <E025 2>Quel nom bien noble pour\r\nune si modeste pièce !");
                R(ref s, "...That's exactly what you said the last time we discussed\r\nit, <E003 6>Mr Naruhodo.",
                         "... C'est exactement ce que vous aviez dit la dernière fois\r\nque nous en avons parlé, <E003 6>monsieur Naruhodo.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#22"] = en => {
                string s = en;
                R(ref s, "These fat claws are doing a good job of protecting the\r\nequally fat gemstone in the middle of this ring.",
                         "Ces griffes épaisses protègent fort bien l'imposante\r\npierre précieuse au centre de cette bague.");
                R(ref s, "Yes, <E003 10><E025 2>if you were clumsy, <E003 6>you could give yourself a rather\r\nnasty cut on them, <E003 6>I should think.",
                         "En effet.<E003 10><E025 2> Pour peu qu'on soit maladroit, <E003 6>on pourrait s'y couper\r\nassez vilainement, <E003 6>je présume.");
                R(ref s, "Ow!",
                         "Aïe !");
                R(ref s, "Now my finger's bleeding!<E003 12>\r\n<E025 2>The claws really are sharp.",
                         "Mon doigt saigne !<E003 12>\r\n<E025 2>Ces griffes sont vraiment acérées.");
                R(ref s, "Oh my!<E003 12> That was very quick clumsiness, <E003 6>Mr Naruhodo,<E003 10>\r\n<E025 3>even for you.",
                         "Grands dieux !<E003 12> Quelle maladresse fulgurante, <E003 6>monsieur Naruhodo,<E003 10>\r\n<E025 3>même venant de votre part.");
                R(ref s, "Uuugh...<E003 14> <E025 2>Who would make such a dangerous ring?!",
                         "Ouuuh...<E003 14> <E025 2>Mais qui fabriquerait un anneau aussi dangereux ?!");
                R(ref s, "(You couldn't swallow it without doing yourself some\r\nfairly serious damage, <E003 8>surely...)",
                         "(On ne pourrait pas l'avaler sans s'infliger de sérieuses\r\nblessures, <E003 8>à n'en pas douter...)");
                R(ref s, "<E006>A sticky mochi bun<E005> of about that size would go down\r\nmuch better.<E003 10> <E025 1>With some red bean paste in the middle!",
                         "<E006>Un bon mochi gluant<E005> de cette taille passerait bien\r\nmieux.<E003 10> <E025 1>Fourré d'une bonne pâte de haricots rouges !");
                R(ref s, "...Someone as clumsy as me <E003 6><E238>would probably manage to\r\nchoke on it somehow.",
                         "... Quelqu'un d'aussi maladroit que moi <E003 6><E238>trouverait sans doute\r\nle moyen de s'étouffer avec.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#23"] = en => {
                string s = en;
                R(ref s, "Professor Mikotoba has wonderful handwriting,<E003 6> doesn't\r\nhe?",
                         "Le professeur Mikotoba a une calligraphie admirable,<E003 6> n'est-ce\r\npas ?");
                R(ref s, "‘This dark-suited young man is not in the least bit\r\nuntrustworthy.’",
                         "« Ce jeune homme vêtu de noir n'est pas le moins du monde\r\nindigne de confiance. »");
                R(ref s, "...Is it just me, <E003 6><E043>or does that make me sound extremely\r\nuntrustworthy?",
                         "... Est-ce une impression, <E003 6><E043>ou cela donne l'impression que je suis\r\ntout sauf digne de confiance ?");
                R(ref s, "I do wish he'd at least called you a ‘nice young man’.",
                         "J'aurais tant aimé qu'il vous qualifie au moins de « charmant jeune homme ».");
                R(ref s, "...I'm really not sure that would help.",
                         "... Je ne suis pas certain que cela aurait arrangé les choses.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#24"] = en => {
                string s = en;
                R(ref s, "Oh...<E003 10><E025 2>it looks like this is some sort of <E006>steamship ticket<E005>.",
                         "Oh...<E003 10><E025 2> on dirait bien une sorte de <E006>billet de bateau à vapeur<E005>.");
                R(ref s, "‘The SS Grouse<E003 8>\r\nFirst-class cabin <E003 6>001’",
                         "« Le SS Grouse<E003 8>\r\nCabine de première classe <E003 6>001 »");
                R(ref s, "‘Yokohama departure: 11th September<E003 10>\r\nLondon arrival: 1st November’...",
                         "« Départ de Yokohama : 11 septembre<E003 10>\r\nArrivée à Londres : 1er novembre »...");
                R(ref s, "Ah, <E003 8>that's the boat that Professor Mikotoba and Judge\r\nJigoku came on from Japan, <E003 4>isn't it?",
                         "Ah, <E003 8>c'est le navire à bord duquel le professeur Mikotoba et le juge\r\nJigoku sont arrivés du Japon, <E003 4>n'est-ce pas ?");
                R(ref s, "Yes, <E003 6>I think it called at Dunkirk on the north coast of\r\nFrance for a night before finally arriving in Dover.",
                         "Oui, <E003 6>il me semble qu'il a fait escale une nuit à Dunkerque, sur la côte\r\nnord de la France, avant d'accoster enfin à Douvres.");
                R(ref s, "(To think it's been almost a year since we arrived in\r\nDover on the SS Burya...)",
                         "(Quand je pense que cela fait presque un an que nous avons débarqué\r\nà Douvres à bord du SS Burya...)");
                R(ref s, "It seems a shame not to keep your ticket as a memento of\r\nyour trip, <E049><E003 6>don't you think?",
                         "Il serait bien dommage de ne pas conserver son billet en souvenir\r\nde la traversée, <E049><E003 6>vous ne trouvez pas ?");
                R(ref s, "Yes, <E003 6>I agree.<E003 10>\r\nI have mine safely in my diary.",
                         "Oui, <E003 6>je suis d'accord.<E003 10>\r\nLe mien est précieusement conservé dans mon journal.");
                R(ref s, "And I keep mine in my wallet, <E003 8>so I have it with me at all\r\ntimes.",
                         "Et je garde le mien dans mon portefeuille, <E003 8>pour l'avoir constamment\r\nsur moi.");
                R(ref s, "...Oh, <E049><E003 8>well how strange!<E003 10>\r\nWhere could it have gone?",
                         "... Oh, <E049><E003 8>comme c'est curieux !<E003 10>\r\nOù a-t-il bien pu passer ?");
                R(ref s, "...Are you like this on purpose, <E003 6>Mr Naruhodo?",
                         "... Vous le faites exprès, <E003 6>monsieur Naruhodo ?");
                R(ref s, "(Did I imagine it, <E003 8><E025 3>or was that comment accompanied by a\r\nlittle sigh?)",
                         "(Est-ce mon imagination, <E003 8><E025 3>ou cette remarque était-elle ponctuée\r\nd'un petit soupir ?)");
                R(ref s, "The details of the letter of introduction\r\nhave been updated in the Court Record.<E104>",
                         "La description de la lettre d'introduction\r\na été mise à jour dans le dossier de l'affaire.<E104>");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#25"] = en => {
                string s = en;
                R(ref s, "The helmet of this charming policeman appears to be a\r\nlittle worse for wear.",
                         "Le casque de ce charmant policier semble avoir connu\r\ndes jours meilleurs.");
                R(ref s, "I'm not convinced about the ‘charming’ part, <E003 8>but yes,<E003 8> \r\nyou're right...",
                         "Je ne suis guère convaincu par le mot « charmant », <E003 8>mais oui,<E003 8>\r\nvous avez raison...");
                R(ref s, "...the head part looks like it's been fairly heavily\r\nmanhandled.",
                         "... la partie de la tête semble avoir été rudement\r\nmanipulée.");
                R(ref s, "Which stands to reason, <E003 4>really, <E003 6>doesn't it?<E003 12>\r\n<E025 2>I mean, <E003 8>it gets turned around and around every day.",
                         "Ce qui est bien compréhensible, <E003 4>après tout, <E003 6>non ?<E003 12>\r\n<E025 2>Je veux dire, <E003 8>on la tourne et retourne jour après jour.");
                R(ref s, "...I hope it doesn't fall off in the end.",
                         "... J'espère qu'elle ne finira pas par se détacher.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#26"] = en => {
                string s = en;
                R(ref s, "So this is the little key used to wind the inspector's\r\npocket watch.",
                         "Voici donc la petite clef servant à remonter la montre\r\nà gousset de l'inspecteur.");
                R(ref s, "It was a mystery at first.<E003 8> Why it should be a policeman,<E003 6>\r\nI mean.",
                         "C'était bien mystérieux au début.<E003 8> Qu'elle représente un policier,<E003 6>\r\nje veux dire.");
                R(ref s, "But it's because it was a gift from Scotland Yard,<E003 6> in\r\nrecognition of Inspector Gregson's hard work.",
                         "Mais c'est parce qu'il s'agissait d'un présent de Scotland Yard,<E003 6>\r\nen hommage au dévouement de l'inspecteur Gregson.");
                R(ref s, "...If its head did fall off from overuse, <E003 6><E025 2>it might seem a\r\nlittle inappropriate, <E003 8>don't you think?",
                         "... Si la tête finissait par tomber à force d'usure, <E003 6><E025 2>cela pourrait\r\nparaître de fort mauvais goût, <E003 8>non ?");
                R(ref s, "That's...<E003 10><E025 2><E333>the British sense of humour for you, <E003 6>I think.",
                         "C'est...<E003 10><E025 2><E333> tout l'humour britannique, <E003 6>j'imagine.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#27"] = en => {
                string s = en;
                R(ref s, "I've always wondered <E003 8><E330>what the underside of a hairpiece\r\nlooks like.",
                         "Je me suis toujours demandé <E003 8><E330>à quoi ressemblait le dessous\r\nd'un postiche.");
                R(ref s, "That doesn't surprise me at all, <E003 4>Mr Naruhodo.<E003 10>\r\nYou always want to see what lies beneath, <E003 4>don't you?",
                         "Cela ne m'étonne nullement de votre part, <E003 4>monsieur Naruhodo.<E003 10>\r\nVous voulez toujours voir ce qui se cache dessous, <E003 4>n'est-ce pas ?");
                R(ref s, "...I'm not sure that's quite how I'd put it.",
                         "... Je ne suis pas sûr que je l'aurais formulé ainsi.");
                R(ref s, "You must have to use lots of bird lime to keep it in place\r\non your head.",
                         "Il doit falloir une bonne dose de glu pour le maintenir\r\nbien arrimé sur le crâne.");
                R(ref s, "So it doesn't get blown off in a gust of wind, <E003 6>I mean.",
                         "Pour ne pas qu'il s'envole au premier coup de vent, <E003 6>je veux dire.");
                R(ref s, "...That might be a little <E003 6><E238>inconvenient <E003 6><E025 2>when you wanted to\r\ntake it off again, <E003 6>don't you think?",
                         "... Cela risquerait d'être un peu <E003 6><E238>fâcheux <E003 6><E025 2>le jour où l'on souhaite\r\nle retirer, <E003 6>vous ne croyez pas ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#28"] = en => {
                string s = en;
                R(ref s, "So the candle was used as a sort of timer device to set off\r\nthe firecrackers...",
                         "La bougie servait donc de minuterie pour allumer\r\nles pétards...");
                R(ref s, "That's a really ingenious idea...<E003 10>though obviously it's a\r\nshame it was used for such a wicked purpose.",
                         "C'est un procédé des plus ingénieux...<E003 10> bien qu'il soit triste\r\nqu'il ait servi à de si sombres desseins.");
                R(ref s, "I wonder if there aren't some more positive uses for a\r\ntimer device such as that...",
                         "Je me demande s'il n'existerait pas des usages plus vertueux\r\npour un tel mécanisme à retardement...");
                R(ref s, "Ah, <E003 8>I have the perfect application!",
                         "Ah, <E003 8>j'ai trouvé l'application idéale !");
                R(ref s, "It would be a wonderful way of waking you in the\r\nmornings, <E003 6>Mr Naruhodo.",
                         "Ce serait un moyen merveilleux de vous réveiller chaque\r\nmatin, <E003 6>monsieur Naruhodo !");
                R(ref s, "...I think I'd prefer that you continue to wake me in\r\nperson, <E003 8><E025 3>if it's all the same to you.",
                         "... Je crois que je préfère encore que vous continuiez à me réveiller\r\nen personne, <E003 8><E025 3>si cela ne vous dérange pas.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#29"] = en => {
                string s = en;
                R(ref s, "So this is the type of revolver that's standard issue for\r\nmembers of the judiciary, then.",
                         "C'est donc le modèle de revolver réglementaire fourni\r\naux membres du corps judiciaire.");
                R(ref s, "Yes.<E003 8> And when I asked about whether records are kept\r\nabout who they're issued to...",
                         "Oui.<E003 8> Et quand j'ai demandé si un registre permettait de savoir\r\nà qui ils ont été attribués...");
                R(ref s, "...I was told that for the past five years, <E003 8><E333>they've been\r\nengraved with a unique serial number.",
                         "... on m'a répondu que depuis cinq ans, <E003 8><E333>un numéro de série\r\nunique y est gravé.");
                R(ref s, "Oh, <E003 8>but as far as I can tell...",
                         "Oh, <E003 8>mais à ce que je vois...");
                R(ref s, "...there's nothing like that on this gun.",
                         "... il n'y a rien de semblable sur cette arme.");
                R(ref s, "Which tells us <E003 8><E043><E025 3>that it must have been issued longer ago\r\nthan that.",
                         "Ce qui nous prouve <E003 8><E043><E025 3>qu'elle a été attribuée il y a bien plus\r\nlongtemps.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#30"] = en => {
                string s = en;
                R(ref s, "There are details of a whole raft of cases dating back\r\nyears on here, <E003 6>aren't there?",
                         "On trouve ici des détails sur une multitude d'affaires remontant\r\nà des années, <E003 6>n'est-ce pas ?");
                R(ref s, "This paper from ten years ago is browning with age, <E003 6>look.",
                         "Ce papier vieux de dix ans a jauni sous l'effet du temps, <E003 6>regardez.");
                R(ref s, "Out of interest, <E003 8><E025 2>the most recent thing appears to be this\r\nnewspaper cutting here.",
                         "Curieusement, <E003 8><E025 2>l'élément le plus récent semble être cette\r\ncoupure de journal.");
                R(ref s, "Oh.<E003 12> <E025 2>It's the same Red-Headed League advertisement that\r\nMr Sholmes had picked out.",
                         "Oh.<E003 12> <E025 2>C'est la même annonce de la Ligue des Rouquins que\r\nM. Sholmes avait dénichée.");
                R(ref s, "And do you remember?<E003 10> There was a red hairpiece at the\r\nscene, too.",
                         "Et vous vous rappelez ?<E003 10> Il y avait aussi un postiche roux sur les\r\nlieux du crime.");
                R(ref s, "(Was Inspector Gregson an exponent of the Red-Headed\r\nLeague, then?)",
                         "(L'inspecteur Gregson était-il donc partisan de la Ligue\r\ndes Rouquins ?)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#31"] = en => {
                string s = en;
                R(ref s, "Oh.<E003 12> <E025 2>What's this...?",
                         "Oh.<E003 12> <E025 2>Qu'est-ce que c'est... ?");
                R(ref s, "Mr Naruhodo!<E003 14>\r\n<E025 2><E341>Look!",
                         "Monsieur Naruhodo !<E003 14>\r\n<E025 2><E341>Regardez !");
                R(ref s, "Oh yes.<E003 12> It's a smudge of some kind.<E003 12>\r\n<E025 3>In fact...",
                         "Oh oui.<E003 12> C'est une tache quelconque.<E003 12>\r\n<E025 3>En réalité...");
                R(ref s, "...it looks just like <E003 10><E238><E025 3><E006>a handprint<E005>.",
                         "... on dirait bien <E003 10><E238><E025 3><E006>une empreinte de main<E005>.");
                R(ref s, "And the colour...",
                         "Et cette couleur...");
                R(ref s, "That's <E006>blood<E005>, <E003 10><E025 3>isn't it?",
                         "C'est du <E006>sang<E005>, <E003 10><E025 3>n'est-ce pas ?");
                R(ref s, "Oh dear...<E003 12> <E025 2><E341>How disturbing...",
                         "Grands dieux...<E003 12> <E025 2><E341>Comme c'est troublant...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#32"] = en => {
                string s = en;
                R(ref s, "Have you had an idea, <E003 6>Mr Naruhodo?<E003 12>\r\nYou're staring at the end of the string of fireworks.",
                         "Une idée vous traverse l'esprit, <E003 6>monsieur Naruhodo ?<E003 12>\r\nVous fixez l'extrémité de cette rangée de pétards.");
                R(ref s, "Sorry.<E003 10> <E025 2>It's just that it's the ‘Venus Special’.",
                         "Pardon.<E003 10> <E025 2>C'est juste qu'il s'agit du « Spécial Vénus ».");
                R(ref s, "I was wondering <E003 8><E025 3>what six hundred pence worth of\r\nfireworks would sound like.",
                         "Je me demandais <E003 8><E025 3>quel bruit pouvaient bien faire six cents pence\r\nde pétards.");
                R(ref s, "Shall we find out?",
                         "Et si nous essayions ?");
                R(ref s, "What?<E003 12> <E025 3>B-<E003 6><E341>But...<E003 12><E025 1>she said it could blow up the courtroom!",
                         "Quoi ?<E003 12> <E025 3>M-<E003 6><E341>Mais...<E003 12><E025 1> elle a dit que ça pourrait faire sauter le tribunal !");
                R(ref s, "...*BANG!*",
                         "... *BAAANG !*");
                R(ref s, "A-<E003 8>Alright, <E003 12>that was a fairly sizeable bang.",
                         "D-<E003 8>D'accord, <E003 12>c'était une détonation des plus retentissantes.");
                R(ref s, "My ears are still ringing, <E003 6>Mr Naruhodo.",
                         "Les oreilles m'en sifflent encore, <E003 6>monsieur Naruhodo.");
                R(ref s, "It sounded almost exactly like...",
                         "On aurait dit très exactement...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#33"] = en => {
                string s = en;
                R(ref s, "So this is where the little policeman figurine's key goes in\r\nto wind the watch.",
                         "C'est donc ici que s'insère la clef du petit policier pour\r\nremonter la montre.");
                R(ref s, "Winding it up every single day for ten years without fail...",
                         "La remonter chaque jour que Dieu fait sans faillir dix ans durant...");
                R(ref s, "Yes, <E003 10><E333>it was obviously a thing of great importance to the\r\ninspector.",
                         "Oui, <E003 10><E333>cet objet revêtait sans nul doute une importance capitale\r\npour l'inspecteur.");
                R(ref s, "(Or a reminder of the past, <E003 8>lest he forget...)",
                         "(Ou un rappel du passé, <E003 8>pour ne jamais oublier...)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#34"] = en => {
                string s = en;
                R(ref s, "The glass over the face really is badly cracked, <E003 6>look.",
                         "Le verre du cadran est terriblement fissuré, <E003 6>regardez.");
                R(ref s, "What a shame when the inspector clearly looked after it\r\nso carefully.",
                         "Quel dommage, quand l'inspecteur en prenait visiblement\r\nun si grand soin.");
                R(ref s, "I imagine Mr Sholmes could repair it, <E003 6>don't you?",
                         "J'imagine que M. Sholmes pourrait la réparer, <E003 6>vous ne croyez pas ?");
                R(ref s, "Yes, <E003 8>I should think so.",
                         "Oui, <E003 8>je le pense aussi.");
                R(ref s, "(He's very adept at things like this.<E003 10>\r\n<E025 2><E330>A useful man to have around, <E003 6>in fact.)",
                         "(Il est fort habile de ses mains pour ces choses-là.<E003 10>\r\n<E025 2><E330>Un homme bien utile à avoir sous la main, <E003 6>au fond.)");
                R(ref s, "But kindly remember that he's a great detective,<E003 6>\r\nMr Naruhodo!<E003 12> <E025 2>Not an odd-job man.",
                         "Mais souvenez-vous qu'il est un grand détective,<E003 6>\r\nmonsieur Naruhodo !<E003 12> <E025 2>Pas un homme à tout faire !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#35"] = en => {
                string s = en;
                R(ref s, "There's a tiny little stub sticking out from this small hole\r\nhere, <E003 6>look.",
                         "Il y a une minuscule tige qui dépasse de ce petit orifice,<E003 6>\r\nregardez.");
                R(ref s, "I suppose there must have been a little knob or something\r\non that for setting the time.",
                         "J'imagine qu'un petit bouton devait s'y trouver pour régler\r\nl'heure.");
                R(ref s, "In that case, <E003 8>seeing as we know the inspector took such\r\ngood care of this watch...",
                         "Dans ce cas, <E003 8>sachant que l'inspecteur prenait grand soin\r\nde cette montre...");
                R(ref s, "...it probably broke when the incident occurred,<E003 6> didn't it?",
                         "... il s'est sans doute brisé lors du drame,<E003 6> n'est-ce pas ?");
                R(ref s, "Yes!<E003 12> <E025 2>Of course!",
                         "Oui !<E003 12> <E025 2>Bien évidemment !");
                R(ref s, "Which could mean <E003 8><E025 3><E330>that there's a small part of the watch\r\nstill at the scene, <E003 8>maybe...",
                         "Ce qui pourrait signifier <E003 8><E025 3><E330>qu'une petite pièce de la montre\r\nse trouverait encore sur les lieux, <E003 8>peut-être...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#36"] = en => {
                string s = en;
                R(ref s, "What do you think, <E003 6>Miss Susato?",
                         "Qu'en pensez-vous, <E003 6>mademoiselle Susato ?");
                R(ref s, "I feel sure I know exactly what will fit here.",
                         "Je suis persuadée de savoir exactement ce qui s'insère ici.");
                R(ref s, "R-<E003 8><E025 1>Really?!<E003 10> <E025 2>I was just thinking precisely the same thing!",
                         "V-<E003 8><E025 1>Vraiment ?!<E003 10> <E025 2>Je songeais très exactement à la même chose !");
                R(ref s, "We're about to see that the little round component...",
                         "Nous allons voir que ce petit composant rond...");
                R(ref s, "...is actually part of Inspector Gregson's broken pocket\r\nwatch!",
                         "... fait en réalité partie de la montre à gousset brisée\r\nde l'inspecteur Gregson !");
                R(ref s, "R-<E003 8><E025 1>Really?!<E003 10> <E025 2>I was just thinking precisely that, too!",
                         "V-<E003 8><E025 1>Vraiment ?!<E003 10> <E025 2>C'est très exactement ce à quoi je pensais aussi !");
                R(ref s, "A perfect fit!",
                         "Il s'emboîte parfaitement !");
                R(ref s, "I, <E003 10>I knew it!",
                         "J-<E003 10>Je le savais !");
                R(ref s, "(...Alright, <E003 6><E025 2>perhaps you knew it.)",
                         "(... D'accord, <E003 6><E025 2>peut-être que vous le saviez.)");
                R(ref s, "I'll make a note of this new information at once!",
                         "Je consigne immédiatement cette nouvelle information !");
                R(ref s, "The details of the small component\r\nhave been updated in the Court Record.<E104>",
                         "La description du petit composant\r\na été mise à jour dans le dossier de l'affaire.<E104>");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#37"] = en => {
                string s = en;
                R(ref s, "So a small part of Inspector Gregson's pocket watch<E003 6> was\r\nfound inside Judge Jigoku's trunk...",
                         "Ainsi donc, une petite pièce de la montre de l'inspecteur Gregson<E003 6>\r\na été retrouvée dans la malle du juge Jigoku...");
                R(ref s, "Yes.<E003 10> <E025 2>I believe that could be very significant indeed.",
                         "Oui.<E003 10> <E025 2>Je crois que cela pourrait être d'une importance capitale.");
                R(ref s, "And,<E003 6> <E341>um...<E003 10><E330>what do you call it again?",
                         "Et,<E003 6> <E341>euh...<E003 10><E330> comment l'appelle-t-on, déjà ?");
                R(ref s, "The crown.<E003 12> A pocket watch is quite useless without it.",
                         "La couronne.<E003 12> Une montre à gousset est tout à fait inutile sans elle.");
                R(ref s, "Yes, <E003 6>that's right.<E003 8> The crown.<E003 10> <E025 2>What a very grand name for\r\nsuch a tiny part.",
                         "Oui, <E003 6>c'est cela.<E003 8> La couronne.<E003 10> <E025 2>Quel nom bien noble pour\r\nune si modeste pièce !");
                R(ref s, "...That's exactly what you said the last time we discussed\r\nit, <E003 6>Mr Naruhodo.",
                         "... C'est exactement ce que vous aviez dit la dernière fois\r\nque nous en avons parlé, <E003 6>monsieur Naruhodo.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#38"] = en => {
                string s = en;
                R(ref s, "Well, <E003 8>I suppose we should see what this inspector's\r\nidentification looks like inside...",
                         "Eh bien, <E003 8>je suppose que nous devrions examiner l'intérieur\r\nde ce carnet d'inspecteur...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#39"] = en => {
                string s = en;
                R(ref s, "This Scotland Yard insignia looks genuine to me.",
                         "Cet insigne de Scotland Yard me paraît authentique.");
                R(ref s, "And the department and identification number details<E003 8> <E333>are\r\nall correct as well.",
                         "Et les mentions du service et du matricule<E003 8> <E333>sont également\r\ntoutes exactes.");
                R(ref s, "There's no doubt that this really is Inspector Gregson's\r\nidentification.",
                         "Il ne fait aucun doute qu'il s'agit bien des papiers d'identité\r\nde l'inspecteur Gregson.");
                return s;
            };
        }
    }
}
