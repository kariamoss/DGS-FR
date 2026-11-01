using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act5 {
    public partial class Program {
        public static void RegisterPart3_B() {
            // [112] BB\script\output\_sce03_evidence_eng#18
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("The details of the noticeboard\r\nhave been updated in the Court Record.", "Les détails du tableau d'affichage\r\nont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            // [113] BB\script\output\_sce03_evidence_eng#19
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("There are details of a whole raft of cases dating back\r\nyears on here, <E003 6>aren't there?", "Il y a des détails sur tout un tas d'affaires remontant à des\r\nannées ici, <E003 6>n'est-ce pas ?");
                s = s.Replace("This paper from ten years ago is browning with age, <E003 6>look.", "Ce papier d'il y a dix ans a jauni avec le temps, <E003 6>regarde.");
                s = s.Replace("Out of interest, <E003 8><E025 2>the most recent thing appears to be this\r\nnewspaper cutting here.", "Par curiosité, <E003 8><E025 2>la chose la plus récente semble être cette\r\ncoupure de journal ici.");
                s = s.Replace("Oh.<E003 12> <E025 2>It's the same Red-Headed League advertisement that\r\nMr Sholmes had picked out.", "Oh.<E003 12> <E025 2>C'est la même annonce de la Ligue des Rouquins que\r\nM. Sholmes avait repérée.");
                s = s.Replace("And do you remember?<E003 10> There was a red hairpiece at the\r\nscene, too.", "Et vous vous souvenez ?<E003 10> Il y avait aussi un postiche roux sur\r\nles lieux.");
                s = s.Replace("(Was Inspector Gregson an exponent of the Red-Headed\r\nLeague, then?)", "(L'inspecteur Gregson faisait-il donc partie de la Ligue\r\ndes Rouquins ?)");
                return s;
            };

            // [114] BB\script\output\_sce03_evidence_eng#20
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("Have you had an idea, <E003 6>Mr Naruhodo?<E003 12>\r\nYou're staring at the end of the string of fireworks.", "Vous avez une idée, <E003 6>M. Naruhodo ?<E003 12>\r\nVous fixez le bout de la mèche des pétards.");
                s = s.Replace("Sorry.<E003 10> <E025 2>It's just that it's the ‘Venus Special’.", "Pardon.<E003 10> <E025 2>C'est juste que c'est le « Spécial Venus ».");
                s = s.Replace("I was wondering <E003 8><E025 3>what six hundred pence worth of\r\nfireworks would sound like.", "Je me demandais <E003 8><E025 3>quel bruit feraient six cents pence de pétards.");
                s = s.Replace("Shall we find out?", "On essaie pour voir ?");
                s = s.Replace("What?<E003 12> <E025 3>B-<E003 6><E341>But...<E003 12><E025 1>she said it could blow up the courtroom!", "Quoi ?<E003 12> <E025 3>M-<E003 6><E341>Mais...<E003 12><E025 1>elle a dit que ça pouvait faire sauter le tribunal !");
                s = s.Replace("...*BANG!*", "...*BAM !*");
                s = s.Replace("A-<E003 8>Alright, <E003 12>that was a fairly sizeable bang.", "D-<E003 8>D'accord, <E003 12>c'était une détonation plutôt costaude.");
                s = s.Replace("My ears are still ringing, <E003 6>Mr Naruhodo.", "Mes oreilles sifflent encore, <E003 6>M. Naruhodo.");
                s = s.Replace("It sounded almost exactly like...", "On aurait dit exactement le son de...");
                return s;
            };

            // [115] BB\script\output\_sce03_evidence_eng#21
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("The details of the Venus firecracker\r\nhave been updated in the Court Record.", "Les détails du pétard de Venus ont été mis à jour\r\ndans le dossier de l'affaire.");
                return s;
            };

            // [116] BB\script\output\_sce03_evidence_eng#23
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#23"] = (en) => {
                string s = en;
                s = s.Replace("Ah...<E003 10> There's a tiny little keyhole here.<E003 10>\r\nCan you see?", "Ah...<E003 10> Il y a un minuscule trou de serrure ici.<E003 10>\r\nVous voyez ?");
                s = s.Replace("Oh yes.<E003 8> That's probably for <E006>the winder<E005> used to wind up\r\nthe mechanism.", "Oh oui.<E003 8> C'est probablement pour <E006>le remontoir<E005> servant à remonter\r\nle mécanisme.");
                s = s.Replace("It looks a little unusual, <E003 8><E025 2>don't you think?", "Il a l'air un peu inhabituel, <E003 8><E025 2>vous ne trouvez pas ?");
                s = s.Replace("Yes, <E003 8><E025 2>you'd need just the right key to wind it,<E003 6> I imagine.", "Oui, <E003 8><E025 2>il faudrait exactement la bonne clé pour le remonter,<E003 6> j'imagine.");
                s = s.Replace("(Why do I feel as though I've seen something...?)", "(Pourquoi ai-je l'impression d'avoir vu quelque chose... ?)");
                s = s.Replace("(Something a bit like <E006>a key<E007> that's about the right size to fit\r\nin this hole...)", "(Quelque chose comme <E006>une clé<E007> de la bonne taille pour entrer\r\ndans ce trou...)");
                s = s.Replace("It would be wonderful if we had the key...<E003 10> <E025 2><E333>Let's <E006>check\r\ncarefully<E005> over what we've already found.", "Ce serait formidable si nous avions la clé...<E003 10> <E025 2><E333><E006>Examinons\r\nsoigneusement<E005> ce que nous avons déjà trouvé.");
                return s;
            };

            // [117] BB\script\output\_sce03_evidence_eng#24
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#24"] = (en) => {
                string s = en;
                s = s.Replace("So this is where the little policeman figurine's key goes in\r\nto wind the watch.", "C'est donc ici qu'entre la clé de la figurine de policier\r\npour remonter la montre.");
                s = s.Replace("Winding it up every single day for ten years without fail...", "La remonter chaque jour que Dieu fait depuis dix ans sans faillir...");
                s = s.Replace("Yes, <E003 10><E333>it was obviously a thing of great importance to the\r\ninspector.", "Oui, <E003 10><E333>c'était manifestement un objet d'une importance capitale\r\npour l'inspecteur.");
                s = s.Replace("(Or a reminder of the past, <E003 8>lest he forget...)", "(Ou un rappel du passé, <E003 8>de peur qu'il n'oublie...)");
                return s;
            };

            // [118] BB\script\output\_sce03_evidence_eng#25
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#25"] = (en) => {
                string s = en;
                s = s.Replace("The glass over the face really is badly cracked, <E003 6>look.", "Le verre du cadran est vraiment très fissuré, <E003 6>regardez.");
                s = s.Replace("What a shame when the inspector clearly looked after it\r\nso carefully.", "Quel dommage, alors que l'inspecteur en prenait si grand soin.");
                s = s.Replace("I imagine Mr Sholmes could repair it, <E003 6>don't you?", "J'imagine que M. Sholmes pourrait la réparer, <E003 6>non ?");
                s = s.Replace("Yes, <E003 8>I should think so.", "Oui, <E003 8>je suppose que oui.");
                s = s.Replace("(He's very adept at things like this.<E003 10>\r\n<E025 2><E330>A useful man to have around, <E003 6>in fact.)", "(Il est très doué pour ce genre de choses.<E003 10>\r\n<E025 2><E330>Un homme bien utile à avoir sous la main, <E003 6>en fait.)");
                s = s.Replace("But kindly remember that he's a great detective,<E003 6>\r\nMr Naruhodo!<E003 12> <E025 2>Not an odd-job man.", "Mais n'oubliez pas que c'est un grand détective,<E003 6>\r\nM. Naruhodo !<E003 12> <E025 2>Pas un homme à tout faire.");
                return s;
            };

            // [119] BB\script\output\_sce03_evidence_eng#26
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#26"] = (en) => {
                string s = en;
                s = s.Replace("There's a tiny little stub sticking out from this small hole\r\nhere, <E003 6>look.", "Il y a une minuscule tige qui dépasse de ce petit trou\r\nici, <E003 6>regardez.");
                s = s.Replace("I suppose there must have been a little knob or something\r\non that for setting the time.", "J'imagine qu'il devait y avoir un petit bouton ou quelque\r\nchose pour régler l'heure.");
                s = s.Replace("In that case, <E003 8>seeing as we know the inspector took such\r\ngood care of this watch...", "Dans ce cas, <E003 8>puisqu'on sait que l'inspecteur prenait un tel\r\nsoin de cette montre...");
                s = s.Replace("...it probably broke when the incident occurred,<E003 6> didn't it?", "...elle s'est probablement cassée lors de l'incident,<E003 6> n'est-ce pas ?");
                s = s.Replace("Yes!<E003 12> <E025 2>Of course!", "Oui !<E003 12> <E025 2>Bien sûr !");
                s = s.Replace("Which could mean <E003 8><E025 3><E330>that there's a small part of the watch\r\nstill at the scene, <E003 8>maybe...", "Ce qui signifierait <E003 8><E025 3><E330>qu'une petite pièce de la montre\r\nest peut-être encore sur les lieux...");
                return s;
            };

            // [120] BB\script\output\_sce03_evidence_eng#27
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#27"] = (en) => {
                string s = en;
                s = s.Replace("Well, <E003 8>I suppose we should see what this inspector's\r\nidentification looks like inside...", "Eh bien, <E003 8>je suppose qu'on devrait regarder à quoi ressemble\r\nce carnet d'inspecteur à l'intérieur...");
                return s;
            };

            // [121] BB\script\output\_sce03_evidence_eng#28
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#28"] = (en) => {
                string s = en;
                s = s.Replace("Yes, <E003 8>it definitely looks fake, <E003 6>doesn't it?", "Oui, <E003 8>ça a vraiment l'air faux, <E003 6>n'est-ce pas ?");
                s = s.Replace("Out of interest, <E003 8>what name is given?", "Par curiosité, <E003 8>quel nom est indiqué ?");
                s = s.Replace("Probably just something plucked out of the air.<E003 15>\r\n<E025 4>It's...<E003 10><E330>‘<E006>Tobias Gregson<E005>’...", "Sans doute un nom inventé de toutes pièces.<E003 15>\r\n<E025 4>C'est...<E003 10><E330>« <E006>Tobias Gregson<E005> »...");
                s = s.Replace("Wait, <E003 12>what?", "Attendez, <E003 12>quoi ?!");
                s = s.Replace("This Scotland Yard insignia...", "Cet insigne de Scotland Yard...");
                s = s.Replace("...looks <E006>genuine<E005> to me.", "...m'a tout l'air d'être <E006>authentique<E005>.");
                s = s.Replace("But how?!", "Mais comment ?!");
                s = s.Replace("And the department and identification number details\r\nare all correct as well.", "Et les détails du département et du matricule\r\nsont parfaitement exacts eux aussi.");
                s = s.Replace("(Since when have you known those?)", "(Depuis quand connaissez-vous ces détails ?)");
                s = s.Replace("Do, <E003 10>do you mean to say...?", "V-...<E003 10> vous voulez dire... ?");
                s = s.Replace("I know it seems incredible, <E003 8>but yes...", "Je sais que ça paraît incroyable, <E003 8>mais oui...");
                s = s.Replace("...I think this is a genuine identification book issued by\r\nScotland Yard.", "...je crois que c'est un véritable carnet de service délivré\r\npar Scotland Yard.");
                s = s.Replace("But that's...<E003 12> <E604><E025 1>That's unbelievable!<E003 14>\r\n<E025 2><E338><E341><E007>(This is <E006>the real thing<E007> after all?!)<E005>", "Mais c'est...<E003 12> <E604><E025 1>C'est incroyable !<E003 14>\r\n<E025 2><E338><E341><E007>(C'est le <E006>vrai de vrai<E007> après tout ?!)<E005>");
                return s;
            };

            // [122] BB\script\output\_sce03_evidence_eng#29
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#29"] = (en) => {
                string s = en;
                s = s.Replace("This Scotland Yard insignia looks genuine to me.", "Cet insigne de Scotland Yard m'a l'air authentique.");
                s = s.Replace("And the department and identification number details<E003 8> <E333>are\r\nall correct as well.", "Et les détails du département et du matricule<E003 8> <E333>sont\r\ntous exacts eux aussi.");
                s = s.Replace("There's no doubt that this really is Inspector Gregson's\r\nidentification.", "Il n'y a aucun doute que c'est bien la pièce d'identité de\r\nl'inspecteur Gregson.");
                return s;
            };

            // [123] BB\script\output\_sce03_evidence_eng#30
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#30"] = (en) => {
                string s = en;
                s = s.Replace("The details of the inspector's identification\r\nhave been updated in the Court Record.", "Les détails de la pièce d'identité de l'inspecteur\r\nont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            // [124] BB\script\output\_sce03_evidence_eng#31
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#31"] = (en) => {
                string s = en;
                s = s.Replace("Look at this dark stain here.<E003 10>\r\n<E025 3>Do you think...?", "Regardez cette tache sombre ici.<E003 10>\r\n<E025 3>Pensez-vous... ?");
                s = s.Replace("Yes, <E003 8>I'm afraid so.<E003 12>\r\n<E330>I think it's <E006>blood<E005>.", "Oui, <E003 8>j'en ai bien peur.<E003 12>\r\n<E330>Je crains que ce ne soit du <E006>sang<E005>.");
                s = s.Replace("Ugh, <E003 10>I knew you were going to say that.<E003 12>\r\n<E025 3><E341>So that presumably means...", "Ouh, <E003 10>je savais que vous alliez dire ça.<E003 12>\r\n<E025 3><E341>Donc cela signifie sans doute...");
                s = s.Replace("...That this was present at <E006>the scene<E005> <E003 8><E025 3>when Inspector\r\nGregson was killed.", "...Que ceci se trouvait sur <E006>les lieux<E005> <E003 8><E025 3>lorsque l'inspecteur\r\nGregson a été tué.");
                s = s.Replace("It's the most logical conclusion, <E003 6><E025 3>yes.", "C'est la conclusion la plus logique, <E003 6><E025 3>oui.");
                s = s.Replace("To think Gina's been carrying this around with her...", "Quand on pense que Gina transportait ça avec elle...");
                s = s.Replace("(If you didn't know any better, <E003 8>I suppose it does look like a\r\ngrease stain from all the fish and chips...)", "(Si on ne savait pas, <E003 8>j'imagine qu'on pourrait la prendre pour une\r\ntache de graisse due au fish and chips...)");
                return s;
            };

            // [125] BB\script\output\_sce03_evidence_eng#32
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#32"] = (en) => {
                string s = en;
                s = s.Replace("Look, <E003 14><E341><E338>there's something inside!", "Regardez, <E003 14><E341><E338>il y a quelque chose à l'intérieur !");
                s = s.Replace("Ooh, <E003 8>let's see...", "Oh, <E003 8>voyons voir...");
                s = s.Replace("It appears to be <E006>a passport<E005>...<E003 12><E025 2>authorising him to travel\r\noverseas.", "Il semble que ce soit <E006>un passeport<E005>...<E003 12><E025 2>l'autorisant à voyager\r\nà l'étranger.");
                s = s.Replace("Was Inspector Gregson about to go on a trip abroad, then?", "L'inspecteur Gregson s'apprêtait-il donc à partir à l'étranger ?");
                s = s.Replace("Perhaps the date of departure might tell us something.<E003 10>\r\n<E025 3>That was...", "Peut-être que la date de départ pourrait nous éclairer.<E003 10>\r\n<E025 3>C'était le...");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("What is it?", "Qu'y a-t-il ?");
                s = s.Replace("It was for travel on 31st October!<E003 15>\r\n<E335><E025 1>Just <E006>one day before<E005> the incident!", "C'était pour voyager le 31 octobre !<E003 15>\r\n<E335><E025 1>Soit à peine <E006>un jour avant<E005> le drame !");
                s = s.Replace("What?<E003 12> <E045><E025 2>Really?!", "Quoi ?<E003 12> <E045><E025 2>Vraiment ?!");
                s = s.Replace("The passport has been\r\nentered into the Court Record.", "Le passeport a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // [126] BB\script\output\_sce03_evidence_eng#33
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#33"] = (en) => {
                string s = en;
                s = s.Replace("(Gregson went to France the day before his body was\r\ndiscovered...?)", "(Gregson s'est rendu en France la veille du jour où son corps\r\na été découvert... ?)");
                return s;
            };

            // [127] BB\script\output\_sce03_evidence_eng#34
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#34"] = (en) => {
                string s = en;
                s = s.Replace("Do you see that?<E003 10> There's something stuck in the side\r\nof the trunk there.<E003 12> <E330>It's glinting.", "Vous voyez ça ?<E003 10> Quelque chose est coincé sur le côté\r\nde la malle.<E003 12> <E330>Ça brille.");
                s = s.Replace("It looks like <E006>a fragment of metal<E005> of some sort.", "On dirait <E006>un éclat de métal<E005> d'une certaine sorte.");
                s = s.Replace("But it's wedged in so tightly, <E003 8><E025 3>I can't remove it.", "Mais c'est si profondément encastré <E003 8><E025 3>que je n'arrive pas à l'enlever.");
                s = s.Replace("Well don't cut yourself.<E003 10>\r\nYou'd better leave it, I think.", "Ne vous coupez pas surtout.<E003 10>\r\nIl vaut mieux le laisser là, je pense.");
                return s;
            };

            // [128] BB\script\output\_sce03_evidence_eng#36
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#36"] = (en) => {
                string s = en;
                s = s.Replace("(Let's have a look inside...)", "(Regardons à l'intérieur...)");
                return s;
            };

            // [129] BB\script\output\_sce03_evidence_eng#37
            entryTranslators[@"BB\script\output\_sce03_evidence_eng#37"] = (en) => {
                string s = en;
                s = s.Replace("Have you seen this huge gash across the side of the trunk\r\nhere?", "Avez-vous vu cette énorme entaille sur le côté de la malle\r\nici ?");
                s = s.Replace("It's gone right through the leather and into the metal\r\nbehind.", "Elle a traversé le cuir et entaillé le métal en dessous.");
                s = s.Replace("Gosh, <E003 8><E025 2>for a metal chest like this to have been so badly\r\ndamaged...", "Nom d'un chien, <E003 8><E025 2>pour qu'un coffre en métal pareil soit aussi sévèrement\r\nendommagé...");
                s = s.Replace("Whatever made the gash must have struck the side of the\r\ntrunk with considerable force.", "Ce qui a causé cette entaille a dû frapper le flanc de la\r\nmalle avec une force prodigieuse.");
                s = s.Replace("(I wonder how it happened...)", "(Je me demande comment c'est arrivé...)");
                return s;
            };

            // [130] BB\script\output\_macro03_eng#8
            entryTranslators[@"BB\script\output\_macro03_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu bien assez de preuves pour me forger\r\nune opinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "Puisqu'il s'agit d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal\r\nne seront pas divulguées au public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Quoi qu'il en soit, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Revenant comparaîtra\r\ndans cette salle <E049><E003 8><E025 3>ou dans toute autre.");
                s = s.Replace("B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Lord Drake Van Peers, <E049><E003 8>conformément aux conclusions de ce\r\ntribunal, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "La séance est levée !");
                return s;
            };

            // [131] BB\script\output\_macro03_eng#9
            entryTranslators[@"BB\script\output\_macro03_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("The witness's last statement<E049><E003 12> <E335><E025 1>is clearly contradictory when\r\nyou consider this piece of evidence here!", "La dernière déclaration du témoin<E049><E003 12> <E335><E025 1>est clairement en contradiction\r\navec cette pièce à conviction !");
                s = s.Replace("Yes!<E049><E003 8> <E025 1><E164 1 8 1 2 8 0 1 1><E139 1>Undeniably!", "Oui !<E049><E003 8> <E025 1><E164 1 8 1 2 8 0 1 1><E139 1>Incontestablement !");
                s = s.Replace("You say it's undeniable, Counsel,<E049><E003 8> <E025 2>but I fail to see any\r\ncontradiction here at all.", "Vous dites que c'est incontestable, Maître,<E049><E003 8> <E025 2>mais je ne vois\r\nabsolument pas la moindre contradiction ici.");
                s = s.Replace("I think perhaps<E003 6> that itself<E003 4> is the contradiction.", "Je pense que peut-être<E003 6> c'est cela même<E003 4> la contradiction.");
                s = s.Replace("...Indeed.", "...En effet.");
                return s;
            };

            // [132] BB\script\output\_macro03_eng#10
            entryTranslators[@"BB\script\output\_macro03_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("(Ugh...<E003 12> <E025 2>Time for a rethink...)", "(Ouh...<E003 12> <E025 2>Il est temps de revoir ma copie...)");
                return s;
            };

            // [133] BB\script\output\_macro03_eng#11
            entryTranslators[@"BB\script\output\_macro03_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("That last statement<E049><E003 12> <E025 1><E335>was contradictory in a number of\r\nways, I think you'll find!", "Cette dernière déclaration<E049><E003 12> <E025 1><E335>était contradictoire sur bien des\r\npoints, comme vous allez le voir !");
                s = s.Replace("In a number of ways,<E003 6> you say?", "Sur bien des points,<E003 6> dites-vous ?");
                s = s.Replace("That's right,<E003 6> My Lord.<E049><E003 12>\r\n<E025 1><E145 1 65><E335>In a number of ways!", "C'est exact,<E003 6> Votre Honneur.<E049><E003 12>\r\n<E025 1><E145 1 65><E335>Sur bien des points !");
                s = s.Replace("Perhaps it would serve you well<E003 6> to concentrate your\r\nefforts on one contradiction at a time,<E003 4> Counsel.", "Peut-être devriez-vous<E003 6> concentrer vos efforts sur\r\nune seule contradiction à la fois,<E003 4> Maître.");
                return s;
            };

            // [134] BB\script\output\_macro03_eng#12
            entryTranslators[@"BB\script\output\_macro03_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("(Ugh...<E003 10> <E025 2>I made a bit of a mess of that.<E003 14>\r\n<E335>In a number of ways, actually.)", "(Ouh...<E003 10> <E025 2>Je me suis un peu mélangé les pinceaux.<E003 14>\r\n<E335>Sur bien des points, d'ailleurs.)");
                return s;
            };

            // [135] BB\script\output\_macro03_eng#13
            entryTranslators[@"BB\script\output\_macro03_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("My Lord!<E049><E003 14> <E025 2>There are clearly grounds<E049><E003 4> <E025 1><E145 1 71><E139 1><E346>for being suspicious\r\nof that last statement!", "Votre Honneur !<E049><E003 14> <E025 2>Il y a clairement matière<E049><E003 4> <E025 1><E145 1 71><E139 1><E346>à douter\r\nde cette dernière déclaration !");
                s = s.Replace("I'm sorry, Counsel,<E003 8> <E025 2>but I fail to see why.", "Je regrette, Maître,<E003 8> <E025 2>mais je ne vois pas du tout pourquoi.");
                s = s.Replace("Well,<E003 8> you know...<E049><E003 10><E025 1><E145 1 71><E139 1><E346>I was just playing devil's advocate!", "Eh bien,<E003 8> vous savez...<E049><E003 10><E025 1><E145 1 71><E139 1><E346>je me faisais juste l'avocat du diable !");
                s = s.Replace("...Yes.<E003 12> <E025 2>You do appear to have something of the devil in\r\nyou, Mr Naruhodo.", "...Oui.<E003 12> <E025 2>Il semble bien que vous ayez un brin du diable\r\nen vous, M. Naruhodo.");
                return s;
            };
        }
    }
}
