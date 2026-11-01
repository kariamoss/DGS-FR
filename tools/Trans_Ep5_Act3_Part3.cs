using System;
using System.Collections.Generic;

namespace TranslatorEp5Act3 {
    public partial class Program {
        public static void RegisterPart3() {

            // [71] BB\script\output\_sce04_c402_0010_eng#20
            entryTranslators[@"BB\script\output\_sce04_c402_0010_eng#20"] = (s) => {
                R(ref s, "Mr Vigil!<E049><E003 10> Is something wrong?", "Monsieur Vigil !<E049><E003 10> Quelque chose ne va pas ?");
                R(ref s, "Oh no!<E049><E003 12>\r\nYou, <E049><E003 8><E330>you haven't lost your memory again, <E003 4>have you?", "Oh non !<E049><E003 12>\r\nVous... <E049><E003 8><E330>vous n'avez pas encore perdu la mémoire, <E003 4>n'est-ce pas ?");
                R(ref s, "No no, <E049><E003 6>not at all.<E049><E003 12> I was merely in a brown study.", "Non non, <E049><E003 6>pas du tout.<E049><E003 12> J'étais simplement plongé dans mes pensées.");
                R(ref s, "...You can think about how you want to decorate your\r\nhouse later.<E049><E003 10> <E025 3>For now, <E049><E003 6>please focus on the testimony.", "...Vous pourrez penser à la décoration de votre maison\r\nplus tard.<E049><E003 10> <E025 3>Pour l'heure, <E049><E003 6>concentrez-vous sur le témoignage.");
                R(ref s, "So sorry...", "Toutes mes excuses...");
                return s;
            };

            // [72] BB\script\output\_sce04_c402_0010_eng#21
            entryTranslators[@"BB\script\output\_sce04_c402_0010_eng#21"] = (s) => {
                R(ref s, "Lord van Zieks!", "Lord Van Peers !");
                R(ref s, "Let me guess:<E049><E003 10> <E238><E025 2>is there something about the witness's last\r\nstatement that troubles me?", "Laissez-moi deviner :<E049><E003 10> <E238><E025 2>la dernière déclaration du témoin\r\néveillerait-elle en moi quelque trouble ?");
                R(ref s, "Is that what you wish to ask?", "Est-ce bien cela que vous souhaitiez me demander ?");
                R(ref s, "Y-<E049><E003 6>Yes...<E003 12> Exactly...<E049><E003 8><E145 1 64><E003 8>\r\n<E025 2>You're very perceptive.", "O-<E049><E003 6>Oui...<E003 12> Tout à fait...<E049><E003 8><E145 1 64><E003 8>\r\n<E025 2>Vous êtes très perspicace.");
                R(ref s, "Whereas you...<E003 12><E025 3>would appear not to be.", "Alors que vous...<E003 12><E025 3>ne semblez guère l'être.");
                R(ref s, "Huh?", "Pardon ?");
                R(ref s, "You really need to learn how to read your fellow man...<E049><E003 12>\r\n<E025 3>my Nipponese friend.", "Vous devriez apprendre à sonder le cœur de vos semblables...<E049><E003 12>\r\n<E025 3>mon ami nippon.");
                R(ref s, "(...Read them...<E003 12>or ‘reap’ them?)", "(...Les sonder...<E003 12>ou les « faucher » ?)");
                return s;
            };

            // [73] BB\script\output\_sce04_c402_0010_eng#22
            entryTranslators[@"BB\script\output\_sce04_c402_0010_eng#22"] = (s) => {
                R(ref s, "Are you feeling faint, <E049><E003 6>Mr Vigil?", "Vous sentez-vous défaillir, <E049><E003 6>Monsieur Vigil ?");
                R(ref s, "Mr Vigil!", "Monsieur Vigil !");
                R(ref s, "Siiiiiir!<E049><E003 28>\r\n<E046><E339>It was <E006>scarlet<E005>, sir!", "Monsieur !<E049><E003 28>\r\n<E046><E339>C'était <E006>écarlate<E005>, monsieur !");
                R(ref s, "What?", "Quoi ?");
                R(ref s, "Oh!<E049><E003 24> I'm, <E049><E003 12><E046><E338>I'm terribly sorry!", "Oh !<E049><E003 24> Je... <E049><E003 12><E046><E338>je suis navré !");
                R(ref s, "I didn't mean to blurt it out like that.", "Je n'avais pas l'intention de le lâcher ainsi.");
                R(ref s, "Less swaying<E049><E003 10> <E045>and more explaining<E049><E003 6> <E025 2>would be helpful...", "Moins d'oscillations<E049><E003 10> <E045>et plus d'explications<E049><E003 6> <E025 2>seraient les bienvenues...");
                R(ref s, "Is it something about the testimony we just heard?<E049><E145 1 0><E003 8><E145 9 92><E118 9 0.8><E003 6>\r\n<E333>Have you recalled something of importance?", "Est-ce lié au témoignage que nous venons d'entendre ?<E049><E145 1 0><E003 8><E145 9 92><E118 9 0.8><E003 6>\r\n<E333>Vous êtes-vous rappelé quelque chose d'important ?");
                R(ref s, "Something of importance...?<E049><E003 15>\r\n<E025 3><E264 126 0.6><E360>Possibly...<E003 12>or possibly...<E003 12>not...", "Quelque chose d'important... ?<E049><E003 15>\r\n<E025 3><E264 126 0.6><E360>Peut-être...<E003 12>ou peut-être...<E003 12>pas...");
                R(ref s, "...I'm unable to tell <E006>which way<E005> he's leaning,<E003 4> I'm afraid.", "...J'ai bien peur d'être incapable de dire <E006>de quel côté<E005> il penche.");
                R(ref s, "My Lord!<E049><E003 16> <E341>The defence asks that Mr Vigil be permitted to\r\nsupplement his testimony...", "Votre Honneur !<E049><E003 16> <E341>La défense demande à ce que M. Vigil soit autorisé\r\nà compléter son témoignage...");
                R(ref s, "...with this <E049><E003 8><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>possibly-or-possibly-not important detail!", "...avec ce détail <E049><E003 8><E164 1 8 1 2 5 0 1 1><E139 1><E025 1>peut-être-ou-peut-être-pas important !");
                R(ref s, "...Permission granted.", "...Permission accordée.");
                R(ref s, "Go ahead, <E049><E003 6>Mr Vigil.", "Je vous en prie, <E049><E003 6>Monsieur Vigil.");
                R(ref s, "Yes!<E049><E003 16> It was scarlet!", "Oui !<E049><E003 16> C'était écarlate !");
                return s;
            };

            // [74] BB\script\output\_sce04_c402_0010_eng#32
            entryTranslators[@"BB\script\output\_sce04_c402_0010_eng#32"] = (s) => {
                R(ref s, "We've wasted enough time!", "Nous avons perdu assez de temps !");
                R(ref s, "It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.", "Il m'apparaît évident <E049><E003 8><E025 2>que tout débat supplémentaire sur cette\r\naffaire demeurera stérile.");
                R(ref s, "Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...", "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que malgré vos égarements...");
                R(ref s, "...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...", "...vous avez néanmoins agi guidé par un idéal de justice.<E049><E003 12>\r\n<E025 3>Qu'il me soit douloureux d'en arriver à cette conclusion...");
                R(ref s, "No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!", "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                R(ref s, "In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "Conformément aux conclusions de ce tribunal, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                R(ref s, "That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!", "L'audience est levée !<E049><E003 10>\r\n<E025 2>La séance est close !");
                return s;
            };

            // [75] BB\script\output\_sce04_c402_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c402_0020_eng#2"] = (s) => {
                R(ref s, "Scarlet-coloured writing <E049><E003 8><E025 2>is what you said you thought you\r\nsaw, <E049><E003 6>Mr Vigil.", "Des caractères de couleur écarlate, <E049><E003 8><E025 2>voilà ce que vous avez cru\r\napercevoir, <E049><E003 6>Monsieur Vigil.");
                R(ref s, "And I believe that's exactly what you did see.", "Et je suis convaincu que c'est exactement ce que vous avez vu.");
                R(ref s, "Wha...?", "Quo... ?");
                R(ref s, "Havers again!<E049><E003 16>\r\n<E335><E025 1>You've no evidence to say that!", "Des sornettes, encore !<E049><E003 16>\r\n<E335><E025 1>Vous n'avez pas l'ombre d'une preuve pour affirmer ça !");
                R(ref s, "Have a look at this report.", "Jetez un œil à ce rapport.");
                R(ref s, "That's...<E003 8><E145 18 11><E003 15><E025 2><E239>my brother's autopsy report!", "C'est...<E003 8><E145 18 11><E003 15><E025 2><E239>le rapport d'autopsie de mon frère !");
                R(ref s, "Yes.<E049><E003 10> <E025 2>And there's something in here that's bothered me\r\nsince I first read it.", "Oui.<E049><E003 10> <E025 2>Et il y a une mention ici qui me trouble\r\ndepuis ma toute première lecture.");
                R(ref s, "It states that <E049><E003 10><E025 2><E330><E006>scarlet-coloured<E005> ink stains were noted on the\r\nfingers of the victim's right hand.", "Il y est consigné que <E049><E003 10><E025 2><E330>des taches d'encre <E006>écarlate<E005> ont été relevées\r\nsur les doigts de la main droite de la victime.");
                R(ref s, "Yes, <E049><E003 8>so it does.", "En effet, <E049><E003 8>c'est écrit.");
                R(ref s, "S-<E049><E003 12><E025 3>Scarlet ink...?", "D-<E049><E003 12><E025 3>De l'encre écarlate... ?");
                R(ref s, "Now, <E049><E003 10>I'm not familiar with the habits of the British\r\naristocracy, <E049><E003 6><E025 3>I freely admit.", "Certes, <E049><E003 10>je ne suis guère coutumier des mœurs de l'aristocratie\r\nbritannique, <E049><E003 6><E025 3>je l'admets volontiers.");
                R(ref s, "But I would hazard a guess that they don't all go around\r\nwith ink stains on their fingertips, <E049><E003 6><E025 3>do they?", "Mais j'ose supposer qu'ils ne se promènent pas tous avec les\r\nbouts des doigts maculés d'encre, <E049><E003 6><E025 3>n'est-ce pas ?");
                R(ref s, "...Your wit is not appreciated.", "...Votre esprit déplacé n'a pas sa place ici.");
                R(ref s, "My brother was a well-bred and fastidious man.", "Mon frère était un gentilhomme distingué et d'un soin méticuleux.");
                R(ref s, "Should ink have sullied his fingertips, <E049><E003 3><E164 18 65 1 2 8 0 2 1><E118 18 0.9><E139 18><E025 1>he would have\r\ncleaned them immediately!", "Si de l'encre avait souillé ses doigts, <E049><E003 3><E164 18 65 1 2 8 0 2 1><E118 18 0.9><E139 18><E025 1>il les aurait\r\nnettoyés sans attendre !");
                R(ref s, "...What is your point, <E049><E003 6>Counsel?", "...Où voulez-vous en venir, <E049><E003 6>Maître ?");
                R(ref s, "My point is this!<E049><E003 12> Whatever Lord Klint van Zieks was\r\nwriting in that unusually coloured ink...", "Voici où je veux en venir !<E049><E003 12> Ce que Lord Klint Van Peers était\r\nen train de coucher avec cette encre inhabituelle...");
                R(ref s, "...it must have been <E049><E003 8><E145 1 85><E118 1 0.5><E003 12><E025 3><E239>directly before his death.", "...il l'a nécessairement écrit <E049><E003 8><E145 1 85><E118 1 0.5><E003 12><E025 3><E239>juste avant de mourir.");
                R(ref s, "Because he died before he had the opportunity to\r\nclean his hand.", "Car il a péri avant même d'avoir pu se laver les mains.");
                R(ref s, "I remember something troubled me at the time.", "Je me souviens d'un détail qui m'avait troublé à l'époque.");
                R(ref s, "At the scene, <E049><E003 10><E239>the lid of my brother's inkwell was <E006>open<E005>.", "Sur les lieux du crime, <E049><E003 10><E239>l'encrier de mon frère était <E006>ouvert<E005>.");
                R(ref s, "But Klint was punctilious about such things.<E049><E003 12>\r\n<E025 3>It seemed...<E003 12>unusual.", "Or Klint était d'une rigueur absolue en la matière.<E049><E003 12>\r\n<E025 3>Cela m'avait paru...<E003 12>inhabituel.");
                R(ref s, "And no document penned in the colour of the ink that was\r\nin the inkwell was ever found.", "Et aucun document rédigé avec l'encre présente dans cet encrier\r\nn'a jamais été retrouvé.");
                R(ref s, "So the document had <E006>disappeared<E005>...<E049><E003 10>\r\n<E025 3><E145 112 0><E118 112 1.35><E003 12>Are you suggesting...", "Le document avait donc <E006>disparu<E005>...<E049><E003 10>\r\n<E025 3><E145 112 0><E118 112 1.35><E003 12>Sous-entendez-vous...");
                R(ref s, "...that the document my father had in his hand that night\r\nin his cell was...?", "...que le document que tenait mon père cette nuit-là dans\r\nsa cellule était... ?");
                R(ref s, "The same document that Lord Klint van Zieks was\r\nwriting <E006>moments before his death<E005>.", "Le document même que Lord Klint Van Peers rédigeait\r\n<E006>quelques instants avant sa mort<E005>.");
                R(ref s, "Then...<E003 12>it was...", "Alors...<E003 12>c'était...");
                R(ref s, "If Mr Vigil's testimony is to be believed, <E049><E003 8><E025 3>it can only mean\r\nthat, <E049><E003 8>yes.", "Si l'on en croit le témoignage de M. Vigil, <E049><E003 8><E025 3>cela ne peut signifier\r\nque cela, <E049><E003 8>en effet.");
                R(ref s, "Mr Vigil!", "Monsieur Vigil !");
                R(ref s, "Siiiiiir!", "Monsieeeeur !");
                R(ref s, "When you spotted Mr Asogi with the document in his\r\ncell...", "Lorsque vous avez surpris M. Asogi avec ce document dans\r\nsa cellule...");
                R(ref s, "...his precise words were as follows, <E049><E003 8>were they not?", "...ses paroles exactes furent bien les suivantes, <E049><E003 8>n'est-ce pas ?");
                R(ref s, "Alright then.<E049><E003 12>\r\nBut what's on that paper?", "Soit.<E049><E003 12>\r\nMais qu'y a-t-il sur ce papier ?");
                R(ref s, "...A last will and testament.", "...Un testament.");
                R(ref s, "This will is...<E003 10><E025 3><E086 2 36><E354>the only weapon I have left now.", "Ce testament est...<E003 10><E025 3><E086 2 36><E354>la seule arme qu'il me reste désormais.");
                R(ref s, "A, <E049><E003 8><E025 3>a last will and testament...", "Un... <E049><E003 8><E025 3>un testament...");
                R(ref s, "Aaah...", "Aaah...");
                R(ref s, "If the conversation really did go as Mr Vigil says...", "Si la conversation s'est réellement déroulée comme l'affirme M. Vigil...");
                R(ref s, "...then what we now know <E049><E003 10><E025 2><E330>completely changes the\r\nmeaning of what Mr Asogi said.", "...alors ce que nous savons désormais <E049><E003 10><E025 2><E330>change de fond en comble\r\nle sens des paroles de M. Asogi.");
                R(ref s, "You really think...?", "Vous pensez vraiment... ?");
                R(ref s, "Mr Vigil did indeed see the convict with a will.", "M. Vigil a bel et bien vu le détenu avec un testament.");
                R(ref s, "But it wasn't that of Genshin Asogi.", "Mais ce n'était pas celui de Genshin Asogi.");
                R(ref s, "It was the last will and testament of Lord Klint van Zieks!", "C'était le testament de Lord Klint Van Peers !");
                R(ref s, "WHAAAT?!", "QUOOOI ?!");
                return s;
            };

            // [76] BB\script\output\_sce04_c402_0030_eng#2
            entryTranslators[@"BB\script\output\_sce04_c402_0030_eng#2"] = (s) => {
                R(ref s, "This...<E003 18><E025 1><E045>this is madness!<E049><E003 18>\r\n<E025 2><E341>My brother's last will and testament?", "C'est... <E003 18><E025 1><E045>c'est de la folie !<E049><E003 18>\r\n<E025 2><E341>Le testament de mon frère ?");
                R(ref s, "That would mean...<E049><E003 16><E025 1><E046>that he had chosen to die!", "Cela signifierait... <E049><E003 16><E025 1><E046>qu'il avait choisi de mourir !");
                R(ref s, "That...<E003 8><E025 3><E149 1 0 8><E338><E341>is what it would mean, <E049><E003 8>yes.", "C'est... <E003 8><E025 3><E149 1 0 8><E338><E341>ce que cela signifierait, <E049><E003 8>en effet.");
                R(ref s, "No!<E049><E003 16> <E025 1><E332><E343>Impossible!<E049><E003 12> <E164 18 72 1 2 8 0 2 1><E139 18>That is utterly out of the question!", "Non !<E049><E003 16> <E025 1><E332><E343>Impossible !<E049><E003 12> <E164 18 72 1 2 8 0 2 1><E139 18>C'est tout bonnement impensable !");
                R(ref s, "Lord van Zieks...", "Lord Van Peers...");
                R(ref s, "Klint was pursuing the Professor.<E049><E003 10> It consumed him day\r\nand night.", "Klint traquait le Professeur.<E049><E003 10> Cela l'obsédait jour\r\net nuit.");
                R(ref s, "Whatever happened, <E049><E003 6><E164 18 72 1 2 9 0 2 1><E118 18 1.2><E139 18><E025 1>he would never have abandoned\r\nhis investigation before its conclusion.<E049><E003 12> <E025 2>Never!", "Quoi qu'il arrive, <E049><E003 6><E164 18 72 1 2 9 0 2 1><E118 18 1.2><E139 18><E025 1>il n'aurait jamais abandonné\r\nson enquête avant d'avoir abouti !<E049><E003 12> <E025 2>Jamais !");
                R(ref s, "He wouldn't rest until the job was done...<E003 15>\r\n<E025 3>Until the killer was caught...", "Il ne pouvait trouver de repos avant d'avoir mené sa tâche à bien...<E003 15>\r\n<E025 3>Avant que le meurtrier ne soit sous les verrous...");
                R(ref s, "The idea that he would willingly accept his own death...<E003 15>\r\n<E025 1><E046><E339>It's obscene!", "L'idée même qu'il ait accepté de son plein gré sa propre mort...<E003 15>\r\n<E025 1><E046><E339>C'est une aberration !");
                R(ref s, "And yet <E049><E003 10><E025 2>we can be sure that he was writing his will\r\nmoments before his death.", "Et pourtant, <E049><E003 10><E025 2>nous avons la certitude qu'il rédigeait son testament\r\nquelques instants avant sa mort.");
                R(ref s, "And that Genshin Asogi came to be in possession of that\r\ndocument.", "Et que Genshin Asogi s'est retrouvé en possession de ce\r\ndocument.");
                R(ref s, "So what could the will possibly have contained...?", "Que pouvait donc bien renfermer ce testament... ?");
                R(ref s, "Clearly something that couldn't be made public under any\r\ncircumstances whatsoever.", "À l'évidence, une révélation qui ne pouvait être rendue publique\r\nsous aucun prétexte.");
                R(ref s, "Because armed with that document, <E049><E003 8><E025 3>my father was able\r\nto negotiate with the judiciary for his life.", "Car armé de cet écrit, <E049><E003 8><E025 3>mon père a été en mesure de négocier\r\nsa propre vie auprès de l'appareil judiciaire.");
                R(ref s, "It was something so damning <E049><E003 10><E025 2><E238>that it prompted the powers\r\nthat be to enact that daring jailbreak plot.", "C'était quelque chose de si accablant <E049><E003 10><E025 2><E238>que les hautes sphères\r\nont orchestré cette audacieuse tentative d'évasion.");
                R(ref s, "Yes, <E049><E003 10><E164 112 10 1 2 8 0 1 0><E139 112><E339><E025 1>there can be no question that the will contained\r\n<E006>information of the utmost secrecy<E005>!", "Oui, <E049><E003 10><E164 112 10 1 2 8 0 1 0><E139 112><E339><E025 1>il ne fait aucun doute que ce testament renfermait\r\n<E006>des informations du plus haut secret<E005> !");
                R(ref s, "Information...<E049><E003 12><E239>of the utmost <E006>secrecy<E005>...", "Des informations... <E049><E003 12><E239>du plus haut <E006>secret<E005>...");
                R(ref s, "AAAA<E339>AAH!<E049><E003 25>\r\n<E025 3><E007>(No...<E003 12> It, <E003 10><E025 3><E338><E342>it couldn't be...)", "AAAA<E339>AAH !<E049><E003 25>\r\n<E025 3><E007>(Non...<E003 12> Ce... <E003 10><E025 3><E338><E342>ce ne serait tout de même pas...)");
                R(ref s, "I've heard more than enough.", "J'en ai plus qu'assez entendu.");
                R(ref s, "Pursuing this notion of a phantom will nobody can attest\r\nto having seen <E049><E003 2><E164 61 12 1 2 9 0 2 1><E118 61 1.2><E139 61><E025 2>serves absolutely no purpose.", "Poursuivre ce mirage d'un testament fantôme dont personne ne peut\r\nattester l'existence <E049><E003 2><E164 61 12 1 2 9 0 2 1><E118 61 1.2><E139 61><E025 2>est parfaitement inutile.");
                R(ref s, "No, <E003 6>My Lord, <E049><E003 14><E025 1><E335>that's unacceptable!", "Non, <E003 6>Votre Honneur, <E049><E003 14><E025 1><E335>c'est inacceptable !");
                R(ref s, "What did you say, <E049><E003 10><E025 3>Counsel?", "Qu'avez-vous dit, <E049><E003 10><E025 3>Maître ?");
                R(ref s, "The last will and testament that Genshin Asogi had in his\r\npossession was that of Lord Klint van Zieks.", "Le testament que Genshin Asogi détenait en sa possession\r\nétait celui de Lord Klint Van Peers.");
                R(ref s, "All the testimony and evidence presented to the court has\r\nlogically led us to that as a possibility.", "Tous les témoignages et pièces versés aux débats nous mènent\r\nlogiquement à cette issue.");
                R(ref s, "We have a duty...<E003 6><E025 1><E145 112 6><E144 112><E346>to pursue the line of reasoning to its\r\nconclusion!", "Nous avons le devoir... <E003 6><E025 1><E145 112 6><E144 112><E346>de suivre ce raisonnement jusqu'à\r\nson terme !");
                R(ref s, "But with no possible means of knowing the contents <E145 61 12><E118 61 0.9>of\r\nthe document, <E049><E003 12><E025 1><E332>there is no line of reasoning to pursue!", "Mais sans le moindre moyen de connaître la teneur <E145 61 12><E118 61 0.9>de\r\nce document, <E049><E003 12><E025 1><E332>il n'y a aucun raisonnement à suivre !");
                return s;
            };

            // [77] BB\script\output\_sce04_c402_0040_eng#2
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#2"] = (s) => {
                R(ref s, "(<E006>A reason<E007> why Lord Klint van Zieks, <E003 8>a man of high noble\r\nstanding, <E003 8><E025 3>would have chosen death...)", "(<E006>Une raison<E007> pour laquelle Lord Klint Van Peers, <E003 8>noble de très\r\nhaute lignée, <E003 8><E025 3>aurait choisi de mourir...)");
                R(ref s, "(<E006>Information so secret<E007>, <E003 8><E025 2>people in the judiciary would be\r\nwilling to negotiate the jailbreak of a condemned killer...)", "(<E006>Une information si secrète<E007>, <E003 8><E025 2>que l'appareil judiciaire a accepté\r\nde négocier l'évasion d'un condamné à mort...)");
                R(ref s, "(The only explanation that fits those facts...)", "(La seule explication concordant avec tous ces faits...)");
                R(ref s, "(...is an unthinkable <E006>truth<E007> <E003 12><E346><E025 1><E339>that turns absolutely everything\r\n<E006>on its head<E007>!)", "(...est une impensable <E006>vérité<E007> <E003 12><E346><E025 1><E339>qui renverse absolument tout\r\n<E006>de fond en comble<E007> !)");
                R(ref s, "(But...<E003 20><E149 1 3 8><E338><E342>it's just too hideous...)", "(Mais... <E003 20><E149 1 3 8><E338><E342>c'est bien trop atroce...)");
                R(ref s, "Mr Naruhodo...", "Monsieur Naruhodo...");
                R(ref s, "However difficult the situation might become...", "Aussi difficile que devienne la situation...");
                R(ref s, "...you work with your client in pursuit of the truth.", "...vous devez cheminer de concert avec votre client en quête de la vérité.");
                R(ref s, "That's what you resolved to do when you entered the\r\ncourtroom this morning, <E049><E003 8><E025 3>if I'm not mistaken.", "C'est la résolution que vous avez prise en franchissant les portes de\r\nce tribunal ce matin, <E049><E003 8><E025 3>si je ne m'abuse.");
                R(ref s, "Miss Susato...", "Mademoiselle Susato...");
                R(ref s, "So hold your head high <E049><E003 10><E164 9 15 1 2 8 0 2 1><E139 9><E025 1>and keep soldiering on!", "Alors gardez la tête haute <E049><E003 10><E164 9 15 1 2 8 0 2 1><E139 9><E025 1>et poursuivez le combat !");
                R(ref s, "Yes, <E003 10>you're right.", "Oui, <E003 10>vous avez raison.");
                R(ref s, "Ten years ago, <E049><E003 10>in his final moments, <E049><E003 10><E025 3>Lord Klint van Zieks\r\nleft behind a will.", "Il y a dix ans, <E049><E003 10>à ses derniers instants, <E049><E003 10><E025 3>Lord Klint Van Peers\r\na laissé un testament.");
                R(ref s, "A will that Genshin Asogi was able to use as <E006>a weapon<E005> to\r\nnegotiate his escape from prison.", "Un testament dont Genshin Asogi s'est servi comme d'une <E006>arme<E005> pour\r\nnégocier son évasion.");
                R(ref s, "In all probability, <E049><E003 12><E330><E025 2>the details in the will were related to\r\nthe Professor case.", "Selon toute vraisemblance, <E049><E003 12><E330><E025 2>les détails contenus dans ce testament\r\nétaient liés à l'affaire du Professeur.");
                R(ref s, "The defence's last statement <E049><E003 10><E025 2><E338><E341>is mere conjecture.", "La dernière déclaration de la défense <E049><E003 10><E025 2><E338><E341>ne relève que de la conjecture.");
                R(ref s, "What are you getting at, <E049><E003 6>man?", "Où voulez-vous en venir, <E049><E003 6>à la fin ?");
                R(ref s, "Ryunosuke?!", "Ryunosuke ?!");
                return s;
            };

            // [78] BB\script\output\_sce04_c402_0040_eng#3
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#3"] = (s) => {
                R(ref s, "(As soon as these words come out of my mouth,<E049><E003 10> <E025 3><E338><E341>there's no\r\ngoing back...)", "(Dès que j'aurai prononcé ces paroles,<E049><E003 10> <E025 3><E338><E341>il n'y aura plus de\r\nretour en arrière possible...)");
                R(ref s, "I believe <E049><E003 10><E025 2><E338><E341>that the last will and testament of Lord Klint van\r\nZieks was in fact...", "J'ai la conviction <E049><E003 10><E025 2><E338><E341>que le testament de Lord Klint Van\r\nPeers était en vérité...");
                return s;
            };

            // [79] BB\script\output\_sce04_c402_0040_eng#4
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#4"] = (s) => {
                R(ref s, "It seems to me <E049><E003 8><E025 2><E145 1 1><E003 10><E330>that it was probably some kind of report.", "Il me semble <E049><E003 8><E025 2><E145 1 1><E003 10><E330>qu'il s'agissait sans doute d'une sorte de rapport.");
                R(ref s, "Some kind of...?", "Une sorte de... ?");
                R(ref s, "Well, <E049><E003 8><E025 2>remember that Lord Klint van Zieks was a\r\nwell-bred and fastidious man.", "Eh bien, <E049><E003 8><E025 2>souvenez-vous que Lord Klint Van Peers était un\r\nhomme distingué et méticuleux.");
                R(ref s, "Knowing the end was near, <E049><E003 10><E025 2><E043>he probably wanted to tie up\r\nthe loose ends of all his outstanding business.", "Sachant sa fin proche, <E049><E003 10><E025 2><E043>il souhaitait sans doute régler\r\ntoutes ses affaires en suspens.");
                R(ref s, "My brother had no outstanding business.", "Mon frère n'avait aucune affaire en suspens.");
                R(ref s, "Klint would have a full account written <E049><E003 10><E332><E025 1>the instant there\r\nwas even a hint of something to report!", "Klint rédigeait un compte-rendu exhaustif <E049><E003 10><E332><E025 1>à la moindre amorce\r\nde fait notable !");
                R(ref s, "...He must have worn out a lot of pens.", "...Il devait user bien des plumes.");
                R(ref s, "In any case, <E049><E003 8>a business report would never be penned in\r\nscarlet ink, <E049><E003 6>Counsel.", "Quoi qu'il en soit, <E049><E003 8>un rapport officiel n'aurait jamais été rédigé\r\nà l'encre écarlate, <E049><E003 6>Maître.");
                R(ref s, "Ugh...<E003 12>\r\n<E025 3><E007>(I forgot to consider the ink colour.)", "Argh...<E003 12>\r\n<E025 3><E007>(J'avais oublié de tenir compte de la couleur de l'encre.)");
                R(ref s, "It's apparent <E049><E003 8><E025 2><E341>that the defence's explanation has no real\r\nsubstance.", "Il est manifeste <E049><E003 8><E025 2><E341>que l'explication de la défense est dénuée de tout\r\nfondement.");
                R(ref s, "This line of enquiry is dead!", "Cette piste est sans issue !");
                R(ref s, "Come on, Ryunosuke!<E049><E003 12> <E025 2>I know you!<E049><E003 14>\r\n<E025 1><E346>You've seen to the heart of all this, <E049><E003 12>haven't you?", "Courage, Ryunosuke !<E049><E003 12> <E025 2>Je te connais !<E049><E003 14>\r\n<E025 1><E346>Tu as vu le fin mot de toute cette affaire, <E049><E003 12>n'est-ce pas ?");
                return s;
            };

            // [80] BB\script\output\_sce04_c402_0040_eng#5
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#5"] = (s) => {
                R(ref s, "Obviously <E049><E003 10><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>it must have been an accusation!", "À l'évidence, <E049><E003 10><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>ce devait être une accusation !");
                R(ref s, "An accusation?", "Une accusation ?");
                R(ref s, "Yes, <E049><E003 12><E025 1><E332>revealing the true identity of the Professor!", "Oui, <E049><E003 12><E025 1><E332>révélant la véritable identité du Professeur !");
                R(ref s, "Which would explain why Asogi took it, <E049><E003 10><E145 61 7><E118 61 0.6>since it was he\r\nwho was implicated by the document.", "Ce qui expliquerait pourquoi Asogi s'en est emparé, <E049><E003 10><E145 61 7><E118 61 0.6>puisqu'il\r\nétait lui-même mis en cause par cet écrit.");
                R(ref s, "No!<E049><E003 12> In that case, <E049><E003 8><E145 1 7>the will wouldn't have given Mr Asogi\r\nany bargaining power at all.", "Non !<E049><E003 12> Dans ce cas, <E049><E003 8><E145 1 7>ce testament n'aurait conféré à M. Asogi\r\naucun pouvoir de négociation.");
                R(ref s, "...Then you're suggesting the accusation was against some\r\nother person?", "...Vous suggérez donc que l'accusation visait une tierce\r\npersonne ?");
                R(ref s, "No!<E049><E003 12> If that were the case, <E049><E003 6><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>the two men would surely have\r\ncollaborated to pursue the culprit together!", "Non plus !<E049><E003 12> Si tel avait été le cas, <E049><E003 6><E164 1 8 1 2 8 0 1 1><E139 1><E025 1>les deux hommes se seraient\r\ncertainement alliés pour démasquer le coupable !");
                R(ref s, "Then your whole argument falls down!", "Alors tout votre raisonnement s'effondre !");
                R(ref s, "AAAAAAAAARGH!", "AAAAAAAAARGH !");
                R(ref s, "Uuugh...<E003 12>\r\n<E025 3><E007>(Can I object to the penalty, too?)", "Ouuugh...<E003 12>\r\n<E025 3><E007>(Puis-je contester la pénalité, aussi ?)");
                R(ref s, "It's apparent <E049><E003 8><E025 2><E341>that the defence's explanation has no real\r\nsubstance.", "Il est manifeste <E049><E003 8><E025 2><E341>que l'explication de la défense est dénuée de tout\r\nfondement.");
                R(ref s, "This line of enquiry is dead!", "Cette piste est sans issue !");
                R(ref s, "Come on, Ryunosuke!<E049><E003 12> <E025 2>I know you!<E049><E003 14>\r\n<E025 1><E346>You've seen to the heart of all this, <E049><E003 12>haven't you?", "Courage, Ryunosuke !<E049><E003 12> <E025 2>Je te connais !<E049><E003 14>\r\n<E025 1><E346>Tu as vu le fin mot de toute cette affaire, <E049><E003 12>n'est-ce pas ?");
                return s;
            };

            // [81] BB\script\output\_sce04_c402_0040_eng#6
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#6"] = (s) => {
                R(ref s, "You can do this, <E049><E003 8>Mr Naruhodo.", "Vous pouvez le faire, <E049><E003 8>Monsieur Naruhodo.");
                R(ref s, "I believe that what Lord Klint van Zieks actually penned\r\nthat day...", "J'ai la certitude que ce que Lord Klint Van Peers a rédigé\r\nce jour-là...");
                R(ref s, "...was <E006>a confession<E005>.", "...était <E006>des aveux<E005>.");
                R(ref s, "A, <E049><E003 10>a confession...?", "D... <E049><E003 10>des aveux... ?");
                R(ref s, "Regarding the mass murderer known as the Professor...<E049><E003 15><E145 1 0><E118 1 0.4><E149 1 0 8><E003 20>\r\n<E025 2><E333><E341>and his <E006>true identity<E005>!", "Concernant le tueur en série connu sous le nom du Professeur...<E049><E003 15><E145 1 0><E118 1 0.4><E149 1 0 8><E003 20>\r\n<E025 2><E333><E341>et sa <E006>véritable identité<E005> !");
                R(ref s, "Enough!<E049><E003 12> <E025 3><E338><E342>...Counsel.", "Assez !<E049><E003 12> <E025 3><E338><E342>...Maître.");
                R(ref s, "What are you saying?<E049><E003 10><E164 18 72 1 2 9 0 2 1><E118 18 1.15><E139 18>\r\n<E025 1>Do you even realise?!", "Que dites-vous là ?<E049><E003 10><E164 18 72 1 2 9 0 2 1><E118 18 1.15><E139 18>\r\n<E025 1>Mesurez-vous vos propos ?!");
                R(ref s, "A confession...<E003 14><E025 3>about the true identity of the Professor...<E049><E003 16>\r\n<E338><E342>That, <E049><E003 10><E025 2><E342>that would mean...", "Des aveux... <E003 14><E025 3>sur la véritable identité du Professeur...<E049><E003 16>\r\n<E338><E342>Cela... <E049><E003 10><E025 2><E342>cela signifierait...");
                R(ref s, "Lord van Zieks, <E049><E003 12><E025 3>I appreciate this must be hard to take in...", "Lord Van Peers, <E049><E003 12><E025 3>je conçois combien cela doit être difficile à entendre...");
                R(ref s, "...but it's the only explanation that fits!", "...mais c'est l'unique explication cohérente !");
                R(ref s, "The killer that terrorised London a decade ago, <E049><E003 8>and\r\nbecame known as the Professor...", "Le meurtrier qui sema l'effroi dans tout Londres il y a dix ans, <E049><E003 8>et\r\nque l'on surnomma le Professeur...");
                R(ref s, "The man believed to have murdered five members of the\r\naristocracy...", "L'homme tenu pour responsable du meurtre de cinq membres de\r\nl'aristocratie...");
                R(ref s, "...wasn't Genshin Asogi at all.", "...n'était absolument pas Genshin Asogi.");
                R(ref s, "No...<E049><E003 15> <E025 1><E342><E338>You can't be suggesting...?", "Non...<E049><E003 15> <E025 1><E342><E338>Vous n'allez tout de même pas insinuer... ?");
                R(ref s, "It was in fact the man believed to have been <E006>the fifth\r\nvictim<E005>...", "Il s'agissait en vérité de l'homme que l'on prenait pour <E006>la cinquième\r\nvictime<E005>...");
                R(ref s, "...Lord Klint van Zieks himself!", "...Lord Klint Van Peers en personne !");
                R(ref s, "...It's finally open, <E049><E003 6>is it?<E049><E003 20>\r\n<E025 3>Pandora's box...", "...Elle est donc enfin ouverte, <E049><E003 6>n'est-ce pas ?<E049><E003 20>\r\n<E025 3>La boîte de Pandore...");
                R(ref s, "The great van Zieks family...<E003 12> <E338><E342><E025 2>They've been\r\n<E042><CNTR><E006>thoroughbreds<E005> of the British judiciary for years...", "L'illustre famille Van Peers...<E003 12> <E338><E342><E025 2>Ce sont les\r\n<E042><CNTR><E006>purs-sangs<E005> de la magistrature britannique depuis des générations...");
                R(ref s, "And Lord Klint van Zieks!<E003 12> \r\n<E042><CNTR><E025 2>He was <E006>a paragon of justice<E005> in the capital...", "Et Lord Klint Van Peers !<E003 12> \r\n<E042><CNTR><E025 2>Il était <E006>un modèle de justice<E005> dans toute la capitale...");
                R(ref s, "But he was actually <E006>a mass murderer<E005>?<E003 12>\r\n<E042><CNTR><E025 2>A, <E003 6>a perpetrator of atrocities of the vilest nature...", "Mais était-il en vérité <E006>un tueur sanguinaire<E005> ?<E003 12>\r\n<E042><CNTR><E025 2>L'auteur d'atrocités de la pire abjection...");
                R(ref s, "If the general public ever found out...<E003 12>\r\n<E042><CNTR><E025 1><E338><E342>law and order in this country would be finished!", "Si jamais le peuple apprenait cela...<E003 12>\r\n<E042><CNTR><E025 1><E338><E342>l'ordre et la loi dans ce pays s'effondreraient à jamais !");
                R(ref s, "My...<E003 12> <E342>My brother...", "Mon...<E003 12> <E342>Mon frère...");
                R(ref s, "Oh, <E049><E003 8>this is too awful...<E049><E003 15>\r\n<E025 3><E341>Poor Lord van Zieks...", "Oh, <E049><E003 8>c'est bien trop terrible...<E049><E003 15>\r\n<E025 3><E341>Pauvre Lord Van Peers...");
                R(ref s, "I wonder, though...<E049><E003 15>\r\n<E025 3><E330>Did he never suspect?", "Je me demande tout de même...<E049><E003 15>\r\n<E025 3><E330>N'a-t-il jamais eu de soupçons ?");
                R(ref s, "Mr Naruhodo?", "Monsieur Naruhodo ?");
                R(ref s, "(Lord Barok van Zieks is a brilliant prosecutor.)", "(Lord Drake Van Peers est un procureur brillant.)");
                R(ref s, "(Is it conceivable <E003 8><E145 1 85><E003 10><E025 3><E330>that he didn't realise what his older\r\nbrother really was...?)", "(Est-il concevable <E003 8><E145 1 85><E003 10><E025 3><E330>qu'il n'ait jamais percé à jour la nature de son\r\npropre frère aîné... ?)");
                return s;
            };

            // [82] BB\script\output\_sce04_c402_0040_eng#7
            entryTranslators[@"BB\script\output\_sce04_c402_0040_eng#7"] = (s) => {
                R(ref s, "We've wasted enough time!", "Nous avons perdu assez de temps !");
                R(ref s, "It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.", "Il m'apparaît évident <E049><E003 8><E025 2>que tout débat supplémentaire sur cette\r\naffaire demeurera stérile.");
                R(ref s, "Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...", "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que malgré vos égarements...");
                R(ref s, "...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...", "...vous avez néanmoins agi guidé par un idéal de justice.<E049><E003 12>\r\n<E025 3>Qu'il me soit douloureux d'en arriver à cette conclusion...");
                R(ref s, "No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!", "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                R(ref s, "In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...", "Conformément aux conclusions de ce tribunal, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                R(ref s, "That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!", "L'audience est levée !<E049><E003 10>\r\n<E025 2>La séance est close !");
                return s;
            };

            RegisterPart3_Cont1();
        }
    }
}
