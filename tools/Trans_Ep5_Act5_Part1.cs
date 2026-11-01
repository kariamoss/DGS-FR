using System;

namespace TranslatorEp5Act5 {
    public partial class Program {
        public static void RegisterPart1() {
            // [0] _sce04_chr010_01_eng#1
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#1"] = (en) => {
                string s = en;
                R(ref s, "So...<E003 10><E025 2>what was in the telegram you received back from\r\nJapan then?", "Alors...<E003 10><E025 2>que disait le télégramme que vous avez reçu du\r\nJapon ?");
                R(ref s, "Ah, <E049><E003 10><E060 0 158 0 0>this?<E049><E003 4> <E145 19 67><E003 15>I thank my lucky stars it arrived in time.", "Ah, <E049><E003 10><E060 0 158 0 0>ceci ?<E049><E003 4> <E145 19 67><E003 15>Je remercie ma bonne étoile qu'il soit arrivé à temps.");
                R(ref s, "‘<E006>Record<E005> found as indicated.<E049><E003 10>\r\nDuplicate follows:’", "« <E006>Dossier<E005> retrouvé comme indiqué.<E049><E003 10>\r\nCopie conforme ci-après : »");
                R(ref s, "‘K. Asogi /<E049><E003 10> A. Shin<E049><E003 10>\r\nT. Gregson /<E049><E003 10> J. Wilson’...", "« K. Asogi /<E049><E003 10> A. Shin<E049><E003 10>\r\nT. Gregson /<E049><E003 10> J. Wilson »...");
                R(ref s, "Wha...?<E003 12>\r\n<E025 1><E007>(Those <E006>four names<E007>!)<E145 19 64>", "Quo... ?<E003 12>\r\n<E025 1><E007>(Ces <E006>quatre noms<E007> !)<E145 19 64>");
                R(ref s, "<E007>(We've...<E003 12><E025 1><E332>come across that exact same list before!)<E085 0 2>", "<E007>(Nous sommes...<E003 12><E025 1><E332>déjà tombés sur cette liste exacte par le passé !)<E085 0 2>");
                R(ref s, "They came up in that unforgettable case last spring...", "Ils étaient apparus dans cette affaire inoubliable du printemps dernier...");
                R(ref s, "What appeared to be a simple case of aggravated murder<E003 8>\r\nturned out to be masking monumental intrigue.", "Ce qui semblait n'être qu'un simple meurtre avec préméditation<E003 8>\r\ns'était révélé masquer une machination monumentale.");
                R(ref s, "A plot that involved the sale of British governmental\r\nsecrets to foreign states.", "Un complot impliquant la vente de secrets d'État britanniques\r\nà des puissances étrangères.");
                R(ref s, "In exposing the means by which those secrets were being\r\nleaked, <E003 8>we deciphered a fragment of a message:", "En mettant au jour le moyen par lequel ces secrets fuitaient,<E003 8> nous avions déchiffré un fragment de message :");
                R(ref s, "‘K. Asogi /<E003 8> A. Shin,<E003 8>\r\nT. Gregson /<E003 8> J. Wilson’...", "« K. Asogi /<E003 8> A. Shin,<E003 8>\r\nT. Gregson /<E003 8> J. Wilson »...");
                R(ref s, "But we didn't find the names out until the case was over,<E003 8>\r\nand we never did get to the bottom of what they meant.", "Mais nous n'avions découvert ces noms qu'une fois le procès clos,<E003 8>\r\net nous n'avions jamais réussi à élucider leur sens.");
                R(ref s, "All we knew...", "Tout ce que nous savions...");
                R(ref s, "...was that the information had been sent by somebody in\r\nthe British government<E003 8> <E025 3><E330>to <E006>somebody in Japan<E005>.", "... c'était que ces informations avaient été transmises par un membre du gouvernement britannique<E003 8> <E025 3><E330>à <E006>quelqu'un au Japon<E005>.");
                R(ref s, "So...<E003 12><E025 3><E341><E330>why are the names coming up again now?", "Alors...<E003 12><E025 3><E341><E330>pourquoi ces noms refont-ils surface maintenant ?");
                R(ref s, "Yes!<E049><E003 4> <E164 3 87 1 2 1 0 1 1><E118 3 1.15><E149 3 4 4><E139 3><E025 1>Where did the sender of your telegram discover\r\nthem, Mr Sholmes?", "Oui !<E049><E003 4> <E164 3 87 1 2 1 0 1 1><E118 3 1.15><E149 3 4 4><E139 3><E025 1>Où l'expéditeur de votre télégramme les a-t-il\r\ndécouverts, monsieur Sholmes ?");
                R(ref s, "I have here the message I had wired yesterday.<E049><E003 10>\r\n<E025 2><E060 0 145 0 0>Allow me to read it to you.", "J'ai ici le message que j'avais câblé hier.<E049><E003 10>\r\n<E025 2><E060 0 145 0 0>Permettez-moi de vous en faire la lecture.");
                R(ref s, "‘Enter Judge Jigoku's office undetected and investigate\r\ntelegram records.’", "« S'introduire discrètement dans le bureau du juge Jigoku et examiner\r\nles registres des télégrammes. »");
                R(ref s, "‘Expect to find communication from Britain dated one\r\nyear ago.’", "« Devriez trouver une missive en provenance de Grande-Bretagne datant\r\nd'un an. »");
                R(ref s, "‘List of four names.<E049><E003 10> Need by tomorrow.<E049><E003 6> <E164 19 70 1 2 6 0 0 1><E139 19><E025 2>Naruhodo.’", "« Liste de quatre noms.<E049><E003 10> Urgent pour demain.<E049><E003 6> <E164 19 70 1 2 6 0 0 1><E139 19><E025 2>Naruhodo. »");
                R(ref s, "I sent it to a detective I know who specialises in\r\nclandestine missions of this nature.", "Je l'ai envoyé à un inspecteur de mes connaissances, spécialisé dans\r\nles missions clandestines de ce genre.");
                R(ref s, "You asked <E049><E003 8><E060 1 24 0 0>Inspector Hosonaga to undertake such an\r\nonerous task for you?", "Vous avez demandé <E049><E003 8><E060 1 24 0 0>à l'inspecteur Hosonaga de se charger d'une tâche\r\naussi périlleuse pour vous ?");
                R(ref s, "And in my name?", "Et en mon nom ?");
                R(ref s, "<E007>(I wonder what guise he opted for this time...?)", "<E007>(Je me demande quel déguisement il a bien pu choisir cette fois-ci... ?)");
                R(ref s, "My dear fellows, <E049><E003 6>it was a matter of great urgency, you\r\nunderstand!", "Mes chers amis, <E049><E003 6>l'urgence était absolue, vous comprenez\r\nbien !");
                R(ref s, "Anyway, <E049><E003 8><E136 46 76 7><E117 46 35><E139 46><E025 2><E330>the list of names was found in Seishiro's office,<E049><E003 8>\r\n<E025 3>as Sholmes predicted.", "Quoi qu'il en soit, <E049><E003 8><E136 46 76 7><E117 46 35><E139 46><E025 2><E330>la liste de noms a été trouvée dans le bureau de Seishiro,<E049><E003 8>\r\n<E025 3>comme Sholmes l'avait prédit.");
                R(ref s, "So you mean, <E003 10><E025 3>that mysterious collection of names that\r\nwas sent from Britain to Japan was...", "Vous voulez dire que <E003 10><E025 3>cette mystérieuse liste de noms envoyée\r\nde Grande-Bretagne au Japon était...");
                R(ref s, "It was sent to Judge Jigoku!<E049><E003 12>\r\n<E025 2>He was the intended recipient!", "Elle a été envoyée au juge Jigoku !<E049><E003 12>\r\n<E025 2>Il en était le véritable destinataire !");
                R(ref s, "<E007>(I don't <E145 3 83><E149 3 0 0>believe it...)", "<E007>(Je n'en <E145 3 83><E149 3 0 0>reviens pas...)");
                R(ref s, "But that doesn't answer the question of what the list of\r\nnames actually signifies...", "Mais cela ne nous dit toujours pas ce que cette liste de\r\nnoms signifie réellement...");
                R(ref s, "...I did formulate a hypothesis about that.", "... J'avais formulé une hypothèse à ce sujet.");
                R(ref s, "But without a shred of evidence, <E049><E003 8>I couldn't possibly have\r\nshared it.", "Mais sans la moindre parcelle de preuve, <E049><E003 8>je ne pouvais décemment\r\nvous en faire part.");
                R(ref s, "<E007>(Mr Sholmes...)", "<E007>(Monsieur Sholmes...)");
                R(ref s, "<E007>(...looks deadly serious for once.)", "<E007>(... a l'air d'un sérieux de marbre pour une fois.)");
                R(ref s, "<E007>The telegram from Japan has been\r\nentered into the Court Record.", "<E007>Le télégramme du Japon a été\r\najouté au dossier de l'affaire.");
                return s;
            };

            // [1] _sce04_chr010_01_eng#3
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#3"] = (en) => {
                string s = en;
                R(ref s, "As I said, <E049><E003 8>when I learnt of Dr Wilson's murder in Japan...", "Comme je le disais, <E049><E003 8>lorsque j'ai appris le meurtre du Dr Wilson au Japon...");
                R(ref s, "...my mind immediately turned to those four names.<E049><E003 12>\r\n<E025 3>Because, you see...", "... mon esprit s'est immédiatement tourné vers ces quatre noms.<E049><E003 12>\r\n<E025 3>Car, voyez-vous...");
                R(ref s, "...there was someone else on the list <E049><E003 10><E164 19 79 1 2 7 0 0 1><E139 19>who I believed to be\r\n<E006>recently deceased<E005>.", "... il y avait une autre personne sur cette liste <E049><E003 10><E164 19 79 1 2 7 0 0 1><E139 19>que je croyais\r\n<E006>récemment décédée<E005>.");
                R(ref s, "What?!<E003 16> <E025 2>Who?", "Quoi ?!<E003 16> <E025 2>Qui ?");
                R(ref s, "‘A. Shin’ <E049><E003 8><E025 2>as it was transcribed in Japanese script.<E049><E003 12>\r\n<E025 2><E333>In actual fact, <E049><E003 8><E025 3>Miss <E006>Asa Shinn<E005>.", "« A. Shin » <E049><E003 8><E025 2>selon la transcription en caractères japonais.<E049><E003 12>\r\n<E025 2><E333>En réalité, <E049><E003 8><E025 3>mademoiselle <E006>Asa Shinn<E005>.");
                R(ref s, "That was a familiar name to me.<E049><E003 10> She was <E006>a professional\r\nkiller<E005>, <E049><E003 6>well known among London's unsavoury classes.", "Ce nom m'était bien familier.<E049><E003 10> C'était <E006>une tueuse professionnelle<E005>,<E049><E003 6>\r\nnotoirement connue de la pègre londonienne.");
                R(ref s, "Oh, I see...", "Oh, je vois...");
                R(ref s, "But she had completely vanished from existence several\r\nmonths before Wilson's murder.", "Mais elle avait totalement disparu de la circulation plusieurs\r\nmois avant le meurtre de Wilson.");
                R(ref s, "So I came to the logical conclusion <E049><E003 8><E025 3><E330>that she had herself\r\nbeen killed.", "J'en ai donc tiré la conclusion logique <E049><E003 8><E025 3><E330>qu'elle avait elle-même\r\nété supprimée.");
                R(ref s, "And accordingly, <E049><E003 8>I became fearful for the lives of the\r\nremaining two persons on the list.", "Et par conséquent, <E049><E003 8>j'ai commencé à craindre pour la vie des\r\ndeux personnes restantes sur la liste.");
                R(ref s, "Ah!<E049><E003 14> <E025 3>‘K. Asogi’ <E049><E003 6>and ‘T. Gregson’...", "Ah !<E049><E003 14> <E025 3>« K. Asogi » <E049><E003 6>et « T. Gregson »...");
                R(ref s, "Owing to our proximity, <E049><E003 6>I decided to take measures to\r\nprotect Gregson myself.", "Étant donné notre proximité géographique, <E049><E003 6>j'ai résolu de prendre moi-même\r\ndes dispositions pour protéger Gregson.");
                R(ref s, "But I determined it would be safest if young Asogi were\r\nto stay away from Britain.", "Mais j'ai estimé qu'il serait plus prudent que le jeune Asogi\r\nreste loin de la Grande-Bretagne.");
                R(ref s, "Ah...<E003 10><E025 2>so that's why you went to such lengths to prevent his\r\nstudy tour from going ahead.", "Ah...<E003 10><E025 2>c'est donc pour cela que vous avez remué ciel et terre pour empêcher\r\nson voyage d'études d'avoir lieu.");
                R(ref s, "Exactly.", "Exactement.");
                R(ref s, "So...<E003 8><E145 3 92><E117 3 15><E003 7><E025 2><E341>you already knew who Kazuma-sama was,<E003 4>\r\nMr Sholmes.", "Alors...<E003 8><E145 3 92><E117 3 15><E003 7><E025 2><E341>vous saviez déjà qui était Kazuma-sama,<E003 4>\r\nmonsieur Sholmes.");
                R(ref s, "Oh yes.<E049><E003 10> <E025 2>Sholmes and I have exchanged correspondence\r\nfor years.", "Mais oui.<E049><E003 10> <E025 2>Sholmes et moi entretenons une correspondance\r\ndepuis des années.");
                R(ref s, "I'd recounted many tales about Asogi to him in my letters.<E049><E003 10>\r\n<E025 3>And the news of Dr Wilson's death, <E003 4>of course.", "Je lui avais relaté maintes histoires sur Asogi dans mes lettres.<E049><E003 10>\r\n<E025 3>Et la nouvelle de la mort du Dr Wilson, <E003 4>bien entendu.");
                R(ref s, "So...<E003 12><E341>Dr Wilson is dead then...", "Alors...<E003 12><E341>le Dr Wilson est mort...");
                R(ref s, "I didn't know.", "Je ne savais pas.");
                R(ref s, "Oh!<E003 12> <E341><E025 3>Iris...", "Oh !<E003 12> <E341><E025 3>Iris...");
                R(ref s, "I know he wasn't my daddy, <E049><E003 8>but still...<E049><E003 12><E145 4 73><E003 18>that's very sad.", "Je sais qu'il n'était pas mon papa, <E049><E003 8>mais quand même...<E049><E003 12><E145 4 73><E003 18>c'est très triste.");
                R(ref s, "I'm so sorry, Iris.", "Je suis si désolée, Iris.");
                R(ref s, "We knew the significance of the name, obviously,<E049><E003 8> <E025 3>but...", "Nous connaissions la portée de ce nom, évidemment,<E049><E003 8> <E025 3>mais...");
                R(ref s, "...we just <E049><E003 10><E025 3>couldn't bring ourselves to tell you.", "... nous n'avions <E049><E003 10><E025 3>jamais eu le courage de vous l'avouer.");
                R(ref s, "No...", "Non...");
                R(ref s, "But what you just told us, <E003 6>Mr Sholmes...", "Mais ce que vous venez de nous dire, <E003 6>monsieur Sholmes...");
                R(ref s, "...doesn't completely tie in with the facts.<E049><E003 12>\r\n<E025 3><E330>There's one big hole <E145 3 77><E118 3 0.8><E149 3 0 0>in your hypothesis.", "... ne concorde pas tout à fait avec les faits.<E049><E003 12>\r\n<E025 3><E330>Il y a une faille majeure <E145 3 77><E118 3 0.8><E149 3 0 0>dans votre hypothèse.");
                R(ref s, "A big hole, <E049><E003 4>Mr Naruhodo?", "Une faille majeure, <E049><E003 4>monsieur Naruhodo ?");
                R(ref s, "Ah yes, <E049><E003 4><E171 3 4 0 2 2><E049><E003 6><E025 3><E145 46 70><E003 15><E238>you mean about Asa Shinn, <E003 4>I presume?", "Ah oui, <E049><E003 4><E171 3 4 0 2 2><E049><E003 6><E025 3><E145 46 70><E003 15><E238>vous voulez parler d'Asa Shinn, <E003 4>je présume ?");
                R(ref s, "Oh, <E049><E003 10>of course!", "Oh, <E049><E003 10>évidemment !");
                R(ref s, "Exactly.<E003 12> She wasn't killed, <E003 6>was she?", "Exactement.<E003 12> Elle n'avait pas été tuée, <E003 6>n'est-ce pas ?");
                R(ref s, "She was in Japan, <E003 8>posing as a visiting student under the\r\nassumed name <E003 6><E025 3>of <E006>Jezaille Brett<E005>.", "Elle se trouvait au Japon, <E003 8>se faisant passer pour une étudiante étrangère sous le\r\nfaux nom <E003 6><E025 3>de <E006>Jezaille Brett<E005>.");
                R(ref s, "I'm glad you're keeping up, <E003 4>my dear fellow!", "Je me réjouis de vous voir suivre le fil, <E003 4>mon cher ami !");
                R(ref s, "But I only became aware of that fact...", "Mais je n'ai pris connaissance de ce fait...");
                R(ref s, "...two days ago, <E049><E003 10><E025 2>in the foyer of the Great Waterloo Hotel.", "... qu'il y a deux jours, <E049><E003 10><E025 2>dans le hall du Great Waterloo Hotel.");
                R(ref s, "Ah!", "Ah !");
                R(ref s, "And upon hearing that startling revelation...", "Et en entendant cette stupéfiante révélation...");
                R(ref s, "...the hypothesis that I'd formed surrounding those four\r\nnames...", "... l'hypothèse que j'avais élaborée autour de ces quatre\r\nnoms...");
                R(ref s, "...was completely turned topsy!", "... s'est trouvée sens dessus dessous !");
                R(ref s, "What?<E003 10> Topsy?", "Quoi ?<E003 10> Sens dessus dessous ?");
                return s;
            };

            // [2] _sce04_chr010_01_eng#4
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#4"] = (en) => {
                string s = en;
                R(ref s, "What do you mean when you say your hypothesis was\r\nturned topsy, <E003 4>Mr Sholmes?", "Que voulez-vous dire par là, <E003 4>monsieur Sholmes ?");
                R(ref s, "I had believed all four names on the list to be the names\r\nof <E006>victims<E005>.", "Je croyais que les quatre noms de la liste étaient ceux de\r\n<E006>victimes<E005>.");
                R(ref s, "However...<E049><E003 3><E025 3><E145 19 66><E003 20><E330>I was mistaken.", "Cependant...<E049><E003 3><E025 3><E145 19 66><E003 20><E330>je me trompais.");
                R(ref s, "Very much so!<E049><E003 15>\r\n<E025 1>Asa Shinn was <E006>a killer<E005>!", "Et de beaucoup !<E049><E003 15>\r\n<E025 1>Asa Shinn était <E006>une tueuse<E005> !");
                R(ref s, "So this telegram<E049><E003 10> <E333>is a list of <E006>both victims and killers<E005>, is it?", "Alors ce télégramme<E049><E003 10> <E333>est une liste <E006>à la fois de victimes et de tueurs<E005>, c'est bien cela ?");
                R(ref s, "Indeed.<E049><E003 12> <E025 2>And it would seem that Miss Shinn...", "En effet.<E049><E003 12> <E025 2>Et il semblerait que mademoiselle Shinn...");
                R(ref s, "...was <E006>dispatched<E005> from Britain with the sole intention of\r\ndispatching Dr Wilson.", "... ait été <E006>expédiée<E005> de Grande-Bretagne dans le seul dessein\r\nd'expédier le Dr Wilson dans l'autre monde.");
                R(ref s, "Her visiting student status being merely a front.", "Son statut d'étudiante étrangère n'était qu'une simple couverture.");
                R(ref s, "Ah!", "Ah !");
                R(ref s, "Which would of course explain why no motive could be\r\ndetermined for her actions...", "Ce qui expliquerait évidemment pourquoi aucun mobile n'a pu\r\nêtre établi pour son geste...");
                R(ref s, "So the real reason Dr Wilson was killed by Asa Shinn...", "Donc la véritable raison pour laquelle le Dr Wilson a été tué par Asa Shinn...");
                R(ref s, "...is because <E003 10><E338><E341><E025 1>he was <E006>the target<E005> of an assassination!", "... c'est parce <E003 10><E338><E341><E025 1>qu'il était <E006>la cible<E005> d'un assassinat !");
                R(ref s, "And forearmed with that knowledge, <E049><E003 8><E025 3><E060 0 158 0 0>fresh consideration\r\nof this telegram...", "Et nantis de ce savoir, <E049><E003 8><E025 3><E060 0 158 0 0>un nouvel examen\r\nde ce télégramme...");
                R(ref s, "...puts the list in a very different perspective.", "... donne à cette liste un tout autre éclairage.");
                R(ref s, "What do you mean?", "Que voulez-vous dire ?");
                R(ref s, "Well, <E049><E003 8><E025 2>does it not strike you?<E049><E003 12>\r\n<E025 3>There is another among the four...", "Eh bien, <E049><E003 8><E025 2>cela ne vous frappe-t-il point ?<E049><E003 12>\r\n<E025 3>Il y en a un autre parmi les quatre...");
                R(ref s, "...who subsequently became <E006>a visiting student<E005>.", "... qui est devenu par la suite <E006>un étudiant étranger<E005>.");
                R(ref s, "Wait, <E003 10>you mean...?", "Attendez, <E003 10>vous voulez dire... ?");
                R(ref s, "But of course.<E049><E003 10>\r\n<E025 3>A name you know only too well.", "Mais assurément.<E049><E003 10>\r\n<E025 3>Un nom que vous ne connaissez que trop bien.");
                R(ref s, "You...<E003 12> You mean...<E003 18><E025 1><E046>KAZUMA?!<E085 2 23>", "Vous...<E003 12> Vous voulez dire...<E003 18><E025 1><E046>KAZUMA ?!<E085 2 23>");
                R(ref s, "Ohhhhhh!", "Ohhhhhh !");
                R(ref s, "He...<E003 15>did say in court earlier today...", "Il...<E003 15>a bien dit au tribunal plus tôt aujourd'hui...");
                R(ref s, "Yes, <E049><E003 6>on 31st October, <E049><E003 10><E025 2>I accompanied Inspector Gregson to\r\nDunkirk...", "Oui, <E049><E003 6>le 31 octobre, <E049><E003 10><E025 2>j'ai accompagné l'inspecteur Gregson à\r\nDunkerque...");
                R(ref s, "...in order to carry out a mission.", "... afin d'accomplir une mission.");
                R(ref s, "And the mission was...?", "Et cette mission était... ?");
                R(ref s, "...The assassination of the mark.", "... L'assassinat de la cible.");
                R(ref s, "Young Mr Asogi accepted that mission a year ago now.", "Le jeune M. Asogi a accepté cette mission il y a un an de cela.");
                R(ref s, "Surely not...", "Ce n'est pas possible...");
                R(ref s, "In conclusion, <E049><E003 12><E060 0 158 0 0><E025 3>this document is <E006>a contract<E005> of sorts.", "En conclusion, <E049><E003 12><E060 0 158 0 0><E025 3>ce document est une sorte de <E006>contrat<E005>.");
                R(ref s, "An international agreement, <E049><E003 8>one might say...<E049><E003 6><E025 2><E145 19 64><E118 19 1.2><E149 19 0 0><E003 25><E330>detailing <E006>an\r\nassassin exchange<E005>.", "Un accord international, <E049><E003 8>pourrait-on dire...<E049><E003 6><E025 2><E145 19 64><E118 19 1.2><E149 19 0 0><E003 25><E330>stipulant <E006>un\r\néchange d'assassins<E005>.");
                R(ref s, "An assassin exchange?!", "Un échange d'assassins ?!");
                R(ref s, "<E007>(How could Kazuma possibly have got involved in\r\nsomething like that?!)", "<E007>(Comment Kazuma a-t-il pu être mêlé à une chose pareille ?!)");
                return s;
            };

            // [3] _sce04_chr010_01_eng#5
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#5"] = (en) => {
                string s = en;
                R(ref s, "Let's assume that we have two parties, <E049><E003 8>each wishing to\r\ndispose of a distinct individual.", "Supposons deux parties, <E049><E003 8>chacune désireuse de se\r\ndéfaire d'un individu distinct.");
                R(ref s, "Those two parties then make <E006>a contract<E005> to <E006>swap<E005> their\r\nrespective assassination targets.", "Ces deux parties concluent alors <E006>un contrat<E005> pour <E006>échanger<E005> leurs\r\ncibles d'assassinat respectives.");
                R(ref s, "That would then be <E006>an assassin exchange<E005>.", "Voilà ce que serait <E006>un échange d'assassins<E005>.");
                R(ref s, "So to begin with, <E049><E003 8><E025 2>the British assassin is dispatched as a\r\nvisiting student to Japan, <E049><E003 6><E025 3>where she kills her target.", "Ainsi, pour commencer, <E049><E003 8><E025 2>l'assassin britannique est envoyé en tant qu'étudiante\r\nétrangère au Japon, <E049><E003 6><E025 3>où elle tue sa cible.");
                R(ref s, "And then <E049><E003 8><E025 2>the Japanese assassin is dispatched as a visiting\r\nstudent to Britain <E049><E003 8><E025 3>in order to eliminate his target.", "Puis <E049><E003 8><E025 2>l'assassin japonais est envoyé en séjour d'études\r\nen Grande-Bretagne <E049><E003 8><E025 3>afin d'éliminer sa propre cible.");
                R(ref s, "...It certainly does sound like an exchange.", "... Cela ressemble en effet à un échange.");
                R(ref s, "But...", "Mais...");
                R(ref s, "...what on earth <E145 3 67>is the point?", "... quel est donc <E145 3 67>l'intérêt d'une telle manigance ?");
                R(ref s, "Don't forget, <E049><E003 6>Naruhodo, <E049><E003 10><E145 46 64><E118 46 1.2><E003 15><E025 2><E333>that the British assassin at least\r\nescaped conviction...", "N'oubliez point, <E049><E003 6>Naruhodo, <E049><E003 10><E145 46 64><E118 46 1.2><E003 15><E025 2><E333>que l'assassin britannique a au moins\r\néchappé à toute condamnation...");
                R(ref s, "...thanks to diplomatic immunity afforded by <E006>consular\r\njurisdiction<E005>.", "... grâce à l'immunité diplomatique conférée par <E006>la juridiction\r\nconsulaire<E005>.");
                R(ref s, "Oh yes...", "Oh oui...");
                R(ref s, "Such jurisdiction should be null and void under the terms\r\nof the new treaty between our two countries.", "Une telle juridiction aurait dû être caduque selon les termes\r\ndu nouveau traité entre nos deux pays.");
                R(ref s, "So the fact that it was brought into play <E049><E003 10><E025 3>suggests\r\nintervention at the very highest levels.", "Le fait qu'elle ait été invoquée <E049><E003 10><E025 3>laisse donc supposer\r\nune intervention au plus haut sommet de l'État.");
                R(ref s, "<E007>(The highest levels...?)", "<E007>(Au plus haut sommet de l'État... ?)");
                R(ref s, "These murders were two sides of the same coin.<E049><E003 8> Linked\r\nnot by a common motive, <E049><E003 6><E025 3>but by <E006>contractual agreement<E005>.", "Ces meurtres étaient les deux faces d'une même pièce.<E049><E003 8> Liés\r\nnon par un mobile commun, <E049><E003 6><E025 3>mais par <E006>un accord contractuel<E005>.");
                R(ref s, "As such, <E049><E003 6>they appeared utterly unrelated.<E049><E003 10> <E164 19 79 1 2 6 0 0 1><E139 19><E025 2>Yet in truth, <E049><E003 6>the\r\nassassins were <E006>complicit<E005> in one singular, <E003 4>devilish scheme.", "Dès lors, <E049><E003 6>ils semblaient totalement déconnectés.<E049><E003 10> <E164 19 79 1 2 6 0 0 1><E139 19><E025 2>Pourtant, en vérité, <E049><E003 6>les\r\nassassins étaient <E006>complices<E005> d'un seul et même plan machiavélique.");
                R(ref s, "That disassociation, <E049><E003 8>and the safeguard of diplomatic\r\nimmunity, were, <E049><E003 8><E025 3>I believe, <E049><E003 8>the motivation behind this plot.", "Cette dissimulation du mobile, <E049><E003 8>et la garantie de l'immunité\r\ndiplomatique, étaient, <E049><E003 8><E025 3>je pense, <E049><E003 8>la véritable motivation de ce complot.");
                R(ref s, "But wait a minute, Sholmes!", "Mais attendez un instant, Sholmes !");
                R(ref s, "If this telegram really is describing the exchange of\r\nassassins as you're suggesting...", "Si ce télégramme décrit bel et bien un échange\r\nd'assassins comme vous le suggérez...");
                R(ref s, "...it would mean <E049><E003 10><E025 2><E341><E333>that the Japanese killer's target <E006>was\r\nnever Seishiro Jigoku<E005> at all.", "... cela signifierait <E049><E003 10><E025 2><E341><E333>que la cible du tueur japonais <E006>n'a\r\njamais été Seishiro Jigoku<E005>.");
                R(ref s, "It would mean Asogi's target <E049><E003 12><E045><E025 1>was actually <E006>Inspector\r\nGregson<E005>!", "Cela signifierait que la cible d'Asogi <E049><E003 12><E045><E025 1>était en réalité <E006>l'inspecteur\r\nGregson<E005> !");
                R(ref s, "What?!<E003 16>\r\n<E025 1><E341>Kazuma was here for Gregson?!", "Quoi ?!<E003 16>\r\n<E025 1><E341>Kazuma était venu pour Gregson ?!");
                R(ref s, "<E007>(So Judge Jigoku wasn't actually the mark?)", "<E007>(Le juge Jigoku n'était donc pas la cible ?)");
                R(ref s, "Yes, <E049><E003 12><E025 1><E341>that's exactly what it would mean!", "Oui, <E049><E003 12><E025 1><E341>c'est exactement ce que cela voudrait dire !");
                R(ref s, "I hold myself personally responsible <E049><E003 8><E145 19 68><E118 19 0.6><E003 15><E025 3><E239>for failing to keep the\r\ninspector safe.", "Je me tiens pour personnellement responsable <E049><E003 8><E145 19 68><E118 19 0.6><E003 15><E025 3><E239>de n'avoir pas su\r\ngarder l'inspecteur sain et sauf.");
                R(ref s, "Mr Sholmes...", "Monsieur Sholmes...");
                R(ref s, "I told him of my fears and implored him to seek a transfer\r\nto an overseas position.", "Je lui avais fait part de mes craintes et l'avais supplié de demander\r\nune mutation à l'étranger.");
                R(ref s, "Obviously <E049><E003 6><E145 19 64><E118 19 1.2><E003 25><E330><E025 2>with the young pickpocket in tow.", "Évidemment, <E049><E003 6><E145 19 64><E118 19 1.2><E003 25><E330><E025 2>en emmenant la jeune tire-laine avec lui.");
                R(ref s, "<E007>(Yes, <E003 8>Gina...)", "<E007>(Oui, <E003 8>Gina...)");
                R(ref s, "Come to think of it, <E003 6>Inspector Gregson did mention that to\r\nus at the Great Exhibition.", "À bien y réfléchir, <E003 6>l'inspecteur Gregson nous en avait parlé\r\nà l'Exposition universelle.");
                R(ref s, "That he'd be transferring to the Paris police and taking\r\nGina with him.", "Qu'il allait être muté à la police de Paris et emmener\r\nGina avec lui.");
                R(ref s, "But without informing me, <E049><E003 10><E025 2>he engaged in one last\r\nassignment, it seems.", "Mais sans m'en aviser, <E049><E003 10><E025 2>il a accepté une ultime\r\nmission, semble-t-il.");
                R(ref s, "And sadly...<E049><E003 12><E145 19 83><E117 19 20><E118 19 0.7><E003 15><E025 3>it turned out to be his very last.", "Et hélas...<E049><E003 12><E145 19 83><E117 19 20><E118 19 0.7><E003 15><E025 3>elle s'est avérée être la dernière de sa vie.");
                R(ref s, "<E007>(This is too much to take in...)", "<E007>(C'est trop dur à assimiler...)");
                return s;
            };

            // [4] _sce04_chr010_01_eng#6
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#6"] = (en) => {
                string s = en;
                R(ref s, "That ‘tragedy’ we had to go through on the SS Burya...", "Cette « tragédie » que nous avons vécue à bord de l'Albatros...");
                R(ref s, "It was all for nothing!<E003 12>\r\n<E025 1><E332>Kazuma <E006>wasn't dead<E005> at all!", "Tout cela n'était pour rien !<E003 12>\r\n<E025 1><E332>Kazuma <E006>n'était pas mort<E005> du tout !");
                R(ref s, "We were completely taken in by the lie you told us.<E003 10>\r\n<E025 3>Your ‘great detective's lie’...", "Nous avons été totalement dupés par le mensonge que vous nous avez servi.<E003 10>\r\n<E025 3>Votre « mensonge de grand détective »...");
                R(ref s, "I took no pleasure in deceiving you.", "Je n'ai éprouvé aucun plaisir à vous tromper.");
                R(ref s, "However, <E049><E003 8><E025 3>at the time...", "Cependant, <E049><E003 8><E025 3>à l'époque...");
                R(ref s, "...all that concerned me was preventing the young man's\r\nstudy tour from taking place, <E049><E003 6><E025 3>whatever the cost.", "... mon unique préoccupation était d'empêcher le voyage d'études de ce jeune\r\nhomme d'aboutir, <E049><E003 6><E025 3>coûte que coûte.");
                R(ref s, "What?", "Quoi ?");
                R(ref s, "I capitalised on the events that transpired to see that he\r\nwas sent back to Japan.", "J'ai tiré parti des événements survenus pour m'assurer qu'il soit\r\nrenvoyé au Japon.");
                R(ref s, "His ‘remains’, <E049><E003 8>you mean?", "Sa « dépouille », <E049><E003 8>voulez-vous dire ?");
                R(ref s, "Precisely, <E049><E003 6>Miss Susato.", "Précisément, <E049><E003 6>mademoiselle Susato.");
                R(ref s, "And then <E049><E003 6><E145 19 64><E149 19 0 4><E003 18><E025 2><E330>I made sure that somebody else was sent to\r\nBritain <E006>in his stead<E005>.", "Et ensuite, <E049><E003 6><E145 19 64><E149 19 0 4><E003 18><E025 2><E330>j'ai veillé à ce que quelqu'un d'autre soit envoyé en\r\nGrande-Bretagne <E006>à sa place<E005>.");
                R(ref s, "Oh my!<E049><E003 12> <E025 3>You mean...", "Grand Dieu !<E049><E003 12> <E025 3>Vous voulez dire...");
                R(ref s, "The arrangement between our two countries was already\r\nin place:", "L'accord entre nos deux pays était déjà conclu :");
                R(ref s, "One university student lawyer and one judicial assistant\r\nto be accommodated on a study tour.", "Un avocat étudiant et une assistante juridique devaient être\r\naccueillis pour un voyage d'études.");
                R(ref s, "In other words, <E049><E003 10><E025 2>by arranging for someone else to fill the\r\nplace originally intended for Mr Asogi...", "En d'autres termes, <E049><E003 10><E025 2>en m'arrangeant pour que quelqu'un d'autre prenne la\r\nplace initialement dévolue à M. Asogi...");
                R(ref s, "...I would successfully prevent the man from arriving on\r\nour shores for several years at least.", "... j'empêcherais cet homme de fouler nos rivages pendant\r\nplusieurs années au bas mot.");
                R(ref s, "Wait, <E003 12><E025 3>do...<E003 8><E341>do you mean to say that...", "Attendez, <E003 12><E025 3>est-ce...<E003 8><E341>voulez-vous insinuer que...");
                R(ref s, "...it was all in aid of <E145 19 64><E118 19 0.6><E006>stopping Kazuma coming to Britain<E005>?<E003 10>\r\n<E025 3>That's why you...?", "... tout cela n'avait pour but que <E145 19 64><E118 19 0.6><E006>d'empêcher Kazuma de venir en Grande-Bretagne<E005> ?<E003 10>\r\n<E025 3>C'est pour ça que vous... ?");
                R(ref s, "Think back, <E049><E003 6>Mr Naruhodo...", "Souvenez-vous, <E049><E003 6>monsieur Naruhodo...");
                R(ref s, "Was there not somebody who quite casually <E006>urged<E005> you to\r\ncontinue on the voyage to England?", "N'y avait-il point quelqu'un qui vous a très innocemment <E006>incité<E005> à\r\npoursuivre la traversée jusqu'en Angleterre ?");
                R(ref s, "<E006>The terms<E005> of this study tour were negotiated by the\r\nDepartment of Justice in both Great Britain and Japan.", "<E006>Les modalités<E005> de ce voyage d'études ont été négociées par le\r\nministère de la Justice en Grande-Bretagne et au Japon.");
                R(ref s, "In the light of Mr Asogi's unfortunate death...", "À la lumière de la mort tragique de M. Asogi...");
                R(ref s, "...I'm afraid <E049><E003 13><E025 3>the study tour can no longer go ahead.", "... j'ai bien peur que <E049><E003 13><E025 3>ce voyage d'études ne puisse plus avoir lieu.");
                R(ref s, "My dear fellows, <E145 3 67><E173 3 1 20 2><E003 10><E025 2>the majority of problems have an\r\nextremely simple solution, you know!", "Mes chers amis, <E145 3 67><E173 3 1 20 2><E003 10><E025 2>la plupart des problèmes ont une\r\nsolution d'une simplicité enfantine, voyez-vous !");
                R(ref s, "All you require <E049><E003 15><E145 2 79><E025 2><E043><E025 2>is one <E006>lawyer<E005>, <E049><E003 6>and the study tour can\r\ncontinue, <E003 4>surely?", "Tout ce dont vous avez besoin <E049><E003 15><E145 2 79><E025 2><E043><E025 2>c'est d'un <E006>avocat<E005>, <E049><E003 6>et le voyage d'études peut\r\ncontinuer, <E003 4>n'est-ce pas ?");
                R(ref s, "But there is no one else with the necessary qualifications,\r\nMr Sholmes.<E049><E003 12> <E025 3>We know of no other <E006>lawyer<E005>.", "Mais personne d'autre ne possède les qualifications requises,\r\nmonsieur Sholmes.<E049><E003 12> <E025 3>Nous ne connaissons aucun autre <E006>avocat<E005>.");
                R(ref s, "...The voyage to London still promises a good month of\r\ntime.", "... Le voyage vers Londres promet encore un bon mois de\r\ntraversée.");
                R(ref s, "Ample opportunity, I would say, <E003 6>to find yourselves\r\nanother suitable <E006>lawyer<E005>.", "Une occasion rêvée, dirais-je, <E003 6>pour vous trouver\r\nun autre <E006>avocat<E005> idoine.");
                R(ref s, "So...<E003 16><E025 1><E331>you manipulated me?!", "Alors...<E003 16><E025 1><E331>vous m'avez manipulé ?!");
                R(ref s, "I've often remarked on the extraordinary lengths to which\r\nfriendship will drive a man.", "J'ai souvent remarqué jusqu'à quelles extrémités l'amitié\r\npeut pousser un homme.");
                R(ref s, "I was quite sure <E049><E003 8><E164 19 81 1 2 8 0 1 1><E139 19><E025 1>that you would <E006>rise to the challenge<E005> for\r\nyour late friend.", "J'avais l'absolue certitude <E049><E003 8><E164 19 81 1 2 8 0 1 1><E139 19><E025 1>que vous sauriez <E006>relever le défi<E005> pour\r\nvotre défunt ami.");
                R(ref s, "I don't believe it...", "Je n'arrive pas à y croire...");
                R(ref s, "But if it was all contrived...", "Mais si tout cela n'était qu'une mise en scène...");
                R(ref s, "I mean, <E049><E003 8><E025 2>what happened was treated by the authorities as\r\n<E006>murder<E005>.", "Je veux dire, <E049><E003 8><E025 2>les autorités ont qualifié ces faits de\r\n<E006>meurtre<E005>.");
                R(ref s, "A woman was mistakenly arrested as <E006>the perpetrator<E005>!<E003 10>\r\n<E025 2>What do you suppose became of her?", "Une femme a été arrêtée par erreur en tant que <E006>coupable<E005> !<E003 10>\r\n<E025 2>Qu'est-elle devenue d'après vous ?");
                R(ref s, "Naturally, <E049><E003 8>I didn't allow the misapprehension to have any\r\nserious repercussions.", "Naturellement, <E049><E003 8>je n'ai point permis que ce malentendu n'entraîne de\r\nconséquences fâcheuses.");
                R(ref s, "I subsequently explained everything and assisted the\r\nunfortunate soul in finding the foreign refuge she sought.", "J'ai par la suite tout tiré au clair et aidé cette malheureuse âme\r\nà trouver le refuge à l'étranger auquel elle aspirait.");
                R(ref s, "...I seem to remember <E003 8><E239><E145 19 64><E025 3>Miss Susato and I had some rather\r\nstrong words for her...", "... Il me semble pourtant me rappeler que <E003 8><E239><E145 19 64><E025 3>mademoiselle Susato et moi\r\navions eu des mots plutôt durs envers elle...");
                R(ref s, "Well, <E049><E003 8><E025 2>she was certainly not devoid of all guilt.<E049><E003 10>\r\n<E025 3>She deserved every word, <E003 4>I'm sure.", "Eh bien, <E049><E003 8><E025 2>elle n'était certes point exempte de tout reproche.<E049><E003 10>\r\n<E025 3>Elle ne méritait pas moins, <E003 4>j'en suis convaincu.");
                R(ref s, "<E007>(I wonder if she made it to America, then...)", "<E007>(Je me demande si elle a bien atteint l'Amérique, du coup...)");
                R(ref s, "I'm afraid I simply cannot comprehend it.", "J'ai bien peur de ne point comprendre du tout.");
                R(ref s, "Why would you go to such lengths, <E049><E003 6><E025 3>Mr Sholmes?", "Pourquoi aller si loin, <E049><E003 6><E025 3>monsieur Sholmes ?");
                R(ref s, "Why were you so determined to stop Kazuma-sama from\r\nreaching Britain?!", "Pourquoi étiez-vous si déterminé à empêcher Kazuma-sama d'arriver en\r\nGrande-Bretagne ?!");
                R(ref s, "The truth is, <E049><E003 8>twelve months ago...", "La vérité est qu'il y a douze mois de cela...");
                R(ref s, "...there was already a very tangible omen of the\r\nimpending tragedy,<E003 6> you see.", "... il existait déjà un présage bien tangible de cette\r\ntragédie imminente, <E003 6>voyez-vous.");
                R(ref s, "An omen that,<E049><E003 6> <E025 2>at this very moment in time,<E049><E003 12> <E145 19 83><E117 19 22><E003 12><E239><E025 3>is close at\r\nhand.", "Un présage qui, <E049><E003 6> <E025 2>en cet instant précis,<E049><E003 12> <E145 19 83><E117 19 22><E003 12><E239><E025 3>se trouve à portée\r\nde main.");
                R(ref s, "<E007>(<E006>An omen<E007> of all these tragic events, <E003 6>that already existed a\r\nyear ago...<E003 12>is close at hand?)", "<E007>(<E006>Un présage<E007> de tous ces événements tragiques, <E003 6>qui existait déjà il y a\r\nun an...<E003 12>se trouve à portée de main ?)");
                R(ref s, "<E007>(We need to find out exactly what Mr Sholmes knows...)", "<E007>(Il nous faut découvrir exactement ce que sait monsieur Sholmes...)");
                return s;
            };

            // [5] _sce04_chr010_01_eng#9
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#9"] = (en) => {
                string s = en;
                R(ref s, "Mr Sholmes, <E003 6><E025 2>would you mind looking at this?", "Monsieur Sholmes, <E003 6><E025 2>auriez-vous l'obligeance d'examiner ceci ?");
                R(ref s, "This is hardly the time, <E003 4>Mr Naruhodo, <E049><E003 10><E025 2><E330>as I'm sure you will\r\nappreciate.", "Ce n'est guère le moment, <E003 4>monsieur Naruhodo, <E049><E003 10><E025 2><E330>comme vous le comprendrez\r\nsans doute.");
                R(ref s, "Oh...<E003 14> <E025 2><E341>No, <E003 8>of course not.<E145 19 64>", "Oh...<E003 14> <E025 2><E341>Non, <E003 8>bien entendu.<E145 19 64>");
                R(ref s, "My attention is entirely drawn to one single matter now:<E049><E003 6>\r\n<E025 1><E164 19 80 1 2 42 0 0 1><E149 19 4 4><E139 19>...the pheasant.", "Mon attention est entièrement accaparée par une seule chose désormais :<E049><E003 6>\r\n<E025 1><E164 19 80 1 2 42 0 0 1><E149 19 4 4><E139 19>... le faisan.");
                R(ref s, "<E007><E331>(Anyone would think you hadn't eaten in weeks!)", "<E007><E331>(À vous entendre, on croirait que vous n'avez rien avalé depuis des semaines !)");
                return s;
            };

            // [6] _sce04_chr010_01_eng#10
            entryTranslators["BB\\script\\output\\_sce04_chr010_01_eng#10"] = (en) => {
                string s = en;
                R(ref s, "There was no room for doubt with your instructions in\r\nthis telegram, <E003 6>Mr Sholmes.", "Il n'y avait pas l'ombre d'un doute quant à vos instructions dans\r\nce télégramme, <E003 6>monsieur Sholmes.");
                R(ref s, "You were very clear that it was Judge Jigoku's office that\r\nshould be searched.<E003 10><E025 3> So...", "Vous étiez formel sur le fait que c'était le bureau du juge Jigoku qu'il\r\nfallait fouiller.<E003 10><E025 3> Alors...");
                R(ref s, "...you obviously knew <E003 8><E025 3><E060 0 158 0 0><E333>that's where the list of names\r\nwould be found.", "... vous saviez pertinemment <E003 8><E025 3><E060 0 158 0 0><E333>que c'était là que se trouverait\r\nla liste de noms.");
                R(ref s, "‘K. Asogi /<E049><E003 8> A. Shin,<E049><E003 8>\r\nT. Gregson /<E049><E003 8> J. Wilson’...", "« K. Asogi /<E049><E003 8> A. Shin,<E049><E003 8>\r\nT. Gregson /<E049><E003 8> J. Wilson »...");
                R(ref s, "But we only learnt of those four names just over six\r\nmonths ago now.", "Mais nous n'avons eu vent de ces quatre noms qu'il y a un peu plus de six\r\nmois.");
                R(ref s, "And only because they appeared as part of the top-secret\r\ngovernment communications that were leaked.", "Et uniquement parce qu'ils figuraient dans ces communications d'État ultra-secrètes\r\nqui avaient fuité.");
                R(ref s, "That's true, <E049><E003 6>yes.<E049><E003 10> <E145 19 67><E003 15><E025 2>But at the time, <E049><E003 6>you were unaware of the\r\nbackground.", "C'est exact, <E049><E003 6>oui.<E049><E003 10> <E145 19 67><E003 15><E025 2>Mais à l'époque, <E049><E003 6>vous ignoriez tout du\r\ncontexte.");
                R(ref s, "You see, <E049><E003 6><E025 3>those four names were wired to Japan...", "Voyez-vous, <E049><E003 6><E025 3>ces quatre noms avaient été télégraphiés au Japon...");
                R(ref s, "...around six months before that.<E049><E003 8> Approximately this time\r\nlast year in fact, <E049><E003 5><E163 19 79 1 2 7 0 0 1><E139 19><E092 5><E025 2>when you were both still in Japan.", "... environ six mois plus tôt.<E049><E003 8> Pratiquement à cette même époque l'an\r\ndernier en vérité, <E049><E003 5><E163 19 79 1 2 7 0 0 1><E139 19><E092 5><E025 2>alors que vous étiez encore tous deux au Japon.");
                R(ref s, "It really would be hypocrisy on my part to reprove others\r\nfor intercepting state secrets.", "Ce serait de la pure hypocrisie de ma part que de reprocher à quiconque\r\nd'intercepter des secrets d'État.");
                R(ref s, "Because after all...", "Car après tout...");
                R(ref s, "...I'm perpetually eavesdropping <E049><E003 10><E025 1><E346>on communications\r\nbetween the British and Japanese governments.<E085 1 10>", "... j'écoute clandestinement en permanence <E049><E003 10><E025 1><E346>les communications\r\nentre les gouvernements britannique et japonais.<E085 1 10>");
                R(ref s, "You're perpetually <E003 10><E025 1><E331>doing what?!<E003 12>\r\n<E335><E025 1>How?", "Vous écoutez clandestinement <E003 10><E025 1><E331>QUOI ?!<E003 12>\r\n<E335><E025 1>Et comment ?!");
                R(ref s, "...Never mind the details.<E049><E003 10>\r\n<E025 2>But you should know...", "... Passons sur les détails.<E049><E003 10>\r\n<E025 2>Mais sachez une chose...");
                R(ref s, "...no secret is safe from Herlock Sholmes <E049><E003 8><E164 19 81 1 2 6 0 0 1><E118 19 1.1><E139 19><E025 1>when he has\r\ndesigns on knowing it.", "... aucun secret n'est à l'abri de Herlock Sholmes <E049><E003 8><E164 19 81 1 2 6 0 0 1><E118 19 1.1><E139 19><E025 1>dès lors qu'il s'est\r\nmis en tête de le percer.");
                R(ref s, "Oh my! Mr Sholmes!<E049><E003 12>\r\n<E025 1><E164 3 87 1 2 8 0 2 1><E149 3 11 7><E139 3>...What a fabulous line!", "Grand Dieu ! Monsieur Sholmes !<E049><E003 12>\r\n<E025 1><E164 3 87 1 2 8 0 2 1><E149 3 11 7><E139 3>... Quelle réplique formidable !");
                R(ref s, "Now, <E049><E003 8>one month after that list of four names was wired to\r\nthe recipient ‘Jigoku’ in Japan...", "Or, <E049><E003 8>un mois après que cette liste de quatre noms a été câblée\r\nau destinataire nommé « Jigoku » au Japon...");
                R(ref s, "...Dr John H. Wilson was murdered.", "... le Dr John H. Wilson a été assassiné.");
                R(ref s, "As soon as I learnt of the incident, <E049><E003 10><E025 3>a hypothesis rapidly\r\ntook shape in my mind.", "Dès que j'ai appris l'incident, <E049><E003 10><E025 3>une hypothèse a rapidement\r\ngermé dans mon esprit.");
                R(ref s, "As it turned out, <E049><E003 10><E025 3>I was partly correct...<E003 12>and partly\r\nmistaken.", "Au bout du compte, <E049><E003 10><E025 3>j'avais en partie vu juste...<E003 12>et en partie\r\nfaux.");
                R(ref s, "Nevertheless, <E049><E003 10><E025 3>it was the beginning of all the tragic events\r\nthat were to follow.", "Quoi qu'il en soit, <E049><E003 10><E025 3>ce fut l'amorce de toute la suite d'événements tragiques\r\nqui allaient s'ensuivre.");
                R(ref s, "Mr Sholmes, <E049><E003 6>please...<E049><E003 8><E025 1><E164 3 87 1 2 1 0 1 1><E149 3 4 4><E139 3>tell us all you know!", "Monsieur Sholmes, <E049><E003 6>de grâce...<E049><E003 8><E025 1><E164 3 87 1 2 1 0 1 1><E149 3 4 4><E139 3>dites-nous tout ce que vous savez !");
                R(ref s, "Tell us about these four names<E049><E003 6> <E145 3 92><E118 3 1.2><E149 3 0 0><E003 8><E025 1><E346>and the tragedy to which\r\nthey're all somehow connected!", "Parlez-nous de ces quatre noms<E049><E003 6> <E145 3 92><E118 3 1.2><E149 3 0 0><E003 8><E025 1><E346>et de la tragédie à laquelle\r\nils sont tous liés d'une façon ou d'une autre !");
                return s;
            };
        }
    }
}
