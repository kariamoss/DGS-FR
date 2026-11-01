using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act2 {
    public partial class Program {
        public static void RegisterPart2() {
            entryTranslators[@"BB\script\output\_sce03_chr050_00_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("I see that's where the poor inspector was found, over\r\nthere.", "Je vois que c'est là-bas que ce pauvre inspecteur a été trouvé,\r\njuste là.");
                s = s.Replace("Yeah, that's right.\r\nThey said...it was a single bullet wot did 'im in.", "Ouais, c'est bien ça.\r\nIls ont dit... qu'une seule balle a suffi à le descendre.");
                s = s.Replace("Apparently the bullet went right through 'im an' struck\r\nthat candle tree on the wall.", "Paraît qu'la balle l'a traversé de part en part et a frappé\r\nce candélabre sur le mur.");
                s = s.Replace("(Oh yes. It's blown one of the candles apart completely.)", "(Ah oui. Elle a complètement pulvérisé l'une des bougies.)");
                s = s.Replace("An' the gun used is there on the floor.\r\nIt's the Reaper's, innit? No denyin' that.", "Et le flingue du crime est là par terre.\r\nC'est celui du Faucheur, pas vrai ? Y a pas photo.");
                s = s.Replace("What?! Really?\r\nHow do you know that?!", "Quoi ?! Vraiment ?\r\nComment le savez-vous ?!");
                s = s.Replace("Take it easy!\r\nI, I dunno wot to do wiv meself when you stare at me wiv\r\nthem big wide eyes.", "Du calme !\r\nJ'sais... j'sais plus où me mettre quand vous me fixez\r\navec vos yeux écarquillés comme ça !");
                s = s.Replace("I'm only sayin' wot I've 'eard.\r\nI dunno much about guns meself.\r\nBut there's some bigwig lawman or wotever who said so.\r\nWhy don't you ask 'im?", "J'dis seulement c'que j'ai entendu.\r\nJ'y connais pas grand-chose en pétoires moi-même.\r\nMais y a un gros bonnet de la justice qui l'a affirmé.\r\nVous avez qu'à lui demander à lui !");
                s = s.Replace("(A ‘bigwig lawman’ is it?)", "(Un « gros bonnet de la justice », vraiment ?)");
                s = s.Replace("Anyway, Fresno Street runs along under that window\r\nthere.\r\nThere were some street sellers just outside who 'eard the\r\ngunshot.", "Bref, Fresno Street passe juste sous cette fenêtre là-bas.\r\nY avait des marchands de rue dehors qui ont entendu le\r\ncoup d'feu.");
                s = s.Replace("Oh! But...I don't recall seeing anybody outside.", "Oh ! Mais... je ne me rappelle pas avoir vu qui que ce soit dehors.");
                s = s.Replace("Yeah, they've all been taken down the Yard for\r\nquestionin', that's why.", "Ouais, ils ont tous été embarqués au Yard pour être\r\ncuisinés, pardi.");
                s = s.Replace("We're talkin' about the Yard's legendary inspector 'ere,\r\nafter all. They'll be gettin' a grillin'.", "C'est du flic de légende du Yard qu'on cause là, après\r\ntout. Ils vont se faire passer un sacré savon.");
                s = s.Replace("Do you think we might be able to speak with those street\r\nsellers ourselves?", "Pensez-vous que nous pourrions interroger ces marchands\r\nambulants nous-mêmes ?");
                s = s.Replace("I doubt it.\r\nThe lads at the Yard will just wanna know wot yer\r\nsnoopin' for and you'll be up for a grillin' an' all.", "J'en doute fort.\r\nLes flics du Yard voudront savoir c'que vous fouinez et vous\r\nfinirez au bloc d'interrogatoire vous aussi.");
                s = s.Replace("(So we can't interview the witnesses, then. Shame...)", "(Nous ne pouvons donc pas voir les témoins. Dommage...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_00_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("Gina, what do you make of this?", "Gina, que penses-tu de ceci ?");
                s = s.Replace("Wot is that? Evidence?\r\nWorked somefin' out about wot 'appened, 'ave ya?", "C'est quoi ce truc ? Une preuve ?\r\nT'as pigé un truc sur c'qui s'est passé, dis ?");
                s = s.Replace("Oh...um...no, not exactly.", "Oh... euh... non, pas exactement.");
                s = s.Replace("I ain't been long enough in the job to get all this deductin'\r\nbusiness yet.\r\nBut I swear I'm gonna get the person wot did this to the\r\nboss!", "Ça fait pas assez longtemps qu'j'suis dans la police pour piger\r\ntoutes vos déductions d'intello.\r\nMais j'jure que j'aurai la peau de celui qui a fait ça au patron !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_00_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("You know that this armband is to show that you're a\r\ndefence lawyer in Japan. Have I told you that?", "Tu sais que ce brassard prouve que je suis avocat de la défense\r\nau Japon. Je te l'avais déjà dit ?");
                s = s.Replace("Yeah, defence lawyers...\r\nWhose side are you lot on anyway, eh?\r\nTryin' to 'elp criminals get off the 'ook.", "Ouais, les avocats d'la défense...\r\nVous êtes dans quel camp au juste, vous ?\r\nToujours à blanchir les criminels pour qu'ils filent à l'anglaise.");
                s = s.Replace("Lord van Zieks isn't the Reaper.\r\nI firmly believe that, which is why I offered to advocate\r\nfor him.", "Lord Van Peers n'est pas le Faucheur.\r\nJ'en ai l'intime conviction, c'est pourquoi je me suis proposé pour le défendre.");
                s = s.Replace("Yeah, but wot if yer wrong?\r\nWot if 'e really is the Reaper?\r\n...!", "Ouais, mais si t'as faux sur toute la ligne ?\r\nEt si c'était vraiment lui le Faucheur ?\r\n... !");
                s = s.Replace("If it turns out 'e did do it, 'ow are you gonna feel then, eh?", "S'il s'avère qu'il a bien tiré, comment tu vas t'sentir alors, hein ?");
                s = s.Replace("I have to believe in my client.\r\nIt's all I can do.", "Je dois avoir foi en mon client.\r\nC'est tout ce qui est en mon pouvoir.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_00_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("Oh, that business? Yup, Inspector Lestrade 'ere soon 'ad\r\nthat one buttoned up.", "Oh, cette affaire ? Ouais, l'inspectrice Lestrade ici présente l'a\r\nrégolée vite fait bien fait !");
                s = s.Replace("I thought it was Mr Sholmes who led that pair into a trap,\r\nwasn't it?", "Je croyais que c'était M. Holmes qui avait attiré ces deux types dans un piège,\r\nnon ?");
                s = s.Replace("Listen, 'Oddo.\r\nIt ain't easy goin' from East End diver to Scotland Yard\r\ndetective, right?", "Écoute-moi bien, 'Oddo.\r\nC'est pas du gâteau de passer de pickpocket de l'East End à\r\nenquêtrice de Scotland Yard, pigé ?");
                s = s.Replace("But anyway, it's all part o' the charm, innit?\r\nBein' a bit loose wiv the truth when it 'elps.\r\n...That's wrong for so many reasons.", "Mais bref, ça fait partie du charme, non ?\r\nArranger un peu la vérité quand ça peut servir.\r\n...C'est tellement discutable à tant d'égards.");
                s = s.Replace("Maybe...I should get Iris to write stories about me!\r\n‘The Adventures of Inspector Lestrade’!", "P't-être... que j'devrais demander à Iris d'écrire des bouquins sur moi !\r\n« Les Aventures de l'inspectrice Lestrade » !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_00_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("This armband is proof – in Japan at least – that I'm a\r\ndefence lawyer.", "Ce brassard prouve – au Japon tout du moins – que je suis\r\navocat de la défense.");
                s = s.Replace("And this badge is proof that I'm a detective!\r\nSo yer all gonna 'ave to start callin' me Inspector Lestrade!", "Et cette plaque prouve que j'suis enquêtrice !\r\nAlors va falloir commencer à m'appeler inspectrice Lestrade !");
                s = s.Replace("In that case, you'll have to start calling me...\r\nWell, anything but ‘'Oddo’.", "Dans ce cas, il va falloir commencer à m'appeler...\r\nEh bien, n'importe quoi d'autre que « 'Oddo ».");
                s = s.Replace("I could call ya ‘Defender Narra-'Oddo’ if ya like.\r\n...But it don't really trip off the tongue.\r\nNo...it doesn't have a great ring to it, does it?", "J'pourrais t'appeler « Maître Narra-'Oddo » si tu veux.\r\n...Mais ça glisse pas terrible sous la langue.\r\nNon... ce n'est pas particulièrement mélodieux, en effet.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("You should 'ear them talkin' at the Yard now...\r\nThey should be ashamed o' themselves.", "Vous devriez entendre les ragots au Yard en ce moment...\r\nIls devraient avoir honte d'eux !");
                s = s.Replace("They're sayin'...that it was the boss who killed all them\r\nbludgers.", "Ils racontent... que c'est le patron qui a liquidé toutes ces\r\ncrapules !");
                s = s.Replace("Ah...you mean the whole Reaper thing?\r\nYeah...", "Ah... vous parlez de l'affaire du Faucheur ?\r\nOuais...");
                s = s.Replace("Apparently the boss was investigatin' stuff that no one\r\nelse at the Yard knew nuffin' about.\r\nStuff to do wiv all them criminals wot got off scot-free.", "Paraît que l'patron enquêtait sur des dossiers dont personne\r\nau Yard avait la moindre idée.\r\nDes trucs en rapport avec tous ces voyous qui ont filé entre les mailles du filet.");
                s = s.Replace("Yes, the ones prosecuted by Lord van Zieks who used\r\nbribery and corruption to evade conviction.", "Oui, ceux poursuivis par Lord Van Peers qui ont échappé à la justice\r\npar pots-de-vin et corruption.");
                s = s.Replace("Well then obviously it was that bloomin' Reaper givin' the\r\norders, weren't it?", "Alors évidemment c'était c'foutu Faucheur qui donnait les ordres,\r\npas vrai ?");
                s = s.Replace("But...why would people be suspecting Inspector Gregson\r\nof being involved in the killings?", "Mais... pourquoi soupçonnerait-on l'inspecteur Gregson d'être\r\nmêlé à ces meurtres ?");
                s = s.Replace("There was a notebook 'idden in 'is office.\r\nOh no...\r\n(This doesn't sound good...)", "Y avait un carnet planqué dans son bureau.\r\nOh non...\r\n(Cela n'augure rien de bon...)");
                s = s.Replace("It...'ad details about all the crimes that 'ave been pegged as\r\nthe Reaper's work.\r\nWHAT?!", "Il... y avait les détails de tous les crimes mis sur le dos\r\ndu Faucheur.\r\nQUOI ?!");
                s = s.Replace("No...Did you see it, Gina?!\r\nDid you see that notebook?!", "Non... L'avez-vous vu, Gina ?!\r\nAvez-vous vu ce carnet ?!");
                s = s.Replace("They wouldn't flamin' let me!\r\nCos I'm ‘just an apprentice’ apparently!\r\nBut it was me who found it!\r\nAnd 'e was my boss!", "Ces crétins ont pas voulu me laisser regarder !\r\nSous prétexte que j'suis « juste une apprentie » !\r\nMais c'est moi qui l'ai déniché !\r\nEt c'était mon patron !");
                s = s.Replace("That's right!\r\nI was pretty miffed about it, so...\r\n...I sneaked a peek at wot it said anyway.\r\nOh!\r\n(That's our Gina!)", "C'est bien vrai !\r\nJ'étais furax, alors...\r\n...j'ai jeté un coup d'œil en douce à ce qu'il y avait dedans.\r\nOh !\r\n(Sacrée Gina !)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So...you managed to see what was written in Gregson's\r\nsecret notebook anyway, did you?\r\nWay I see it, it's my right to read wot 'e wrote.", "Ainsi... vous avez quand même réussi à lire le contenu\r\ndu carnet secret de Gregson ?\r\nDe mon point d'vue, j'avais bien l'droit d'lire ses notes.");
                s = s.Replace("And what had he written, Gina?\r\nDates, times, places, names...\r\nAn 'ole long list of 'em.\r\nAll details about the bludgers supposed to 'ave been done\r\nin by the Reaper.", "Et qu'avait-il consigné, Gina ?\r\nDes dates, des heures, des lieux, des noms...\r\nUne sacrée longue tartine de tout ça.\r\nTous les détails sur les truands censés avoir été refroidis par le Faucheur.");
                s = s.Replace("But...there could be an explanation for that!\r\nPerhaps it was a record of the inspector's investigations\r\ninto the Reaper's activities.", "Mais... il pourrait y avoir une explication à cela !\r\nC'était peut-être le compte-rendu des investigations de\r\nl'inspecteur sur les agissements du Faucheur.");
                s = s.Replace("Exactly! That's wot I said!\r\nThat's the first thing you'd think, right?\r\nAs it 'appens, it was full o' names I recognised anyway.", "Pile poil ! C'est c'que j'me suis dit !\r\nC'est la première chose qui vient à l'esprit, non ?\r\nEn plus, c'était bourré de noms que j'connaissais de toute façon.");
                s = s.Replace("Well, the Reaper's targets were almost exclusively known\r\nleaders of London's criminal underworld.", "Eh bien, les proies du Faucheur étaient presque exclusivement des\r\ncaïds notoires de la pègre londonienne.");
                s = s.Replace("Well yeah, but...there was one name right at the end that\r\nwas a bit odd.\r\nAt the end of the list, you mean?", "Ouais, mais... y avait un nom tout à la fin qui était\r\nun peu bizarre.\r\nÀ la toute fin de la liste, voulez-vous dire ?");
                s = s.Replace("I'm pretty sure the date against it was 31st October.\r\nOh! The day before the inspector was found dead!", "J'suis quasiment sûre que la date en face était le 31 octobre.\r\nOh ! La veille de la découverte de la dépouille de l'inspecteur !");
                s = s.Replace("So? What was the odd name?", "Alors ? Quel était ce nom curieux ?");
                s = s.Replace("It weren't like a name I've ever seen before.\r\nIt was somefin' like, erm...", "C'était pas un nom ordinaire que j'avais déjà croisé.\r\nC'était un truc du style, euh...");
                s = s.Replace("Nah, it's no good. I can't remember it.\r\nI don't think it was an English name, put it that way.\r\nOh dear...What a pity.", "Nan, rien à faire, ça veut pas r'venir.\r\nC'était pas un nom anglais, pour tout vous dire.\r\nFlûte... Quel dommage.");
                s = s.Replace("There was somefin' else, too. I dunno if it matters,\r\nbut the same name kept comin' up over and over.\r\n‘Shinn’ it was.\r\nDon't s'pose it means anyfin' but...", "Y avait un autre truc aussi. J'sais pas si ça compte,\r\nmais le même nom revenait encore et encore.\r\n« Shinn » que c'était.\r\nÇa veut sûrement rien dire, mais...");
                s = s.Replace("Did you say ‘Shinn’?\r\nEh?! Wot, it does mean somefin'?!", "Avez-vous bien dit « Shinn » ?\r\nHein ?! Quoi, ça vous dit quelque chose ?!");
                s = s.Replace("(Lord van Zieks knew the name, too.\r\nHe mentioned her as well.)\r\n(The woman who actually did the deeds...)\r\n(And now we find out her name appeared in Gregson's\r\nsecret notebook...)", "(Lord Van Peers connaissait ce nom lui aussi.\r\nIl l'a mentionnée lui aussi.)\r\n(La femme qui exécutait véritablement les meurtres...)\r\n(Et voilà que son nom refait surface dans le carnet secret\r\nde Gregson...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("We haven't seen you for a little while, have we, Gina...", "Nous ne t'avons pas vue depuis un moment, dis-moi, Gina...");
                s = s.Replace("Well o' course not! I've been busy, ain't I?\r\nInvestigatin' an' that.\r\nThe lads at the Yard are tryin' to trace the boss's\r\nmovements the day before it 'appened.", "Ben évidemment ! J'avais du pain sur la planche pardi !\r\nEntre les enquêtes et tout l'reste.\r\nLes gars du Yard essaient de reconstituer la journée du patron\r\nla veille du drame.");
                s = s.Replace("The day before... That would be the undercover\r\ninvestigation into the Red-Headed League, then.", "La veille... Cela correspondrait donc à son enquête incognito\r\nsur la Ligue des Rouquins.");
                s = s.Replace("Only the boss didn't go, did 'e? You found some cove wot\r\nwas pretendin' to be 'im, didn't ya, 'Oddo?", "Sauf que l'patron y est jamais allé, hein ? T'as trouvé un clampin\r\nqui s'faisait passer pour lui, pas vrai, 'Oddo ?");
                s = s.Replace("(Yes, it was Mr Vigil who actually went to the park on\r\nLime Street that day, posing as Gregson.)", "(Oui, c'était M. Vigil qui s'est rendu au parc de Lime\r\nStreet ce jour-là, sous l'identité de Gregson.)");
                s = s.Replace("Well anyway, you ain't the only one turnin' stuff up.\r\nI've got me own ways of gettin' results!\r\nWhen me an' me partner 'ere get together, there's nuffin'\r\nwe can't track down!", "Enfin bref, t'es pas l'seul à déterrer des pistes.\r\nJ'ai mes propres combines pour faire parler les indices !\r\nQuand mon coéquipier et moi on s'y met, y a rien qui\r\npeut nous échapper !");
                s = s.Replace("Oh, little Toby!\r\nHe's such a faithful friend!", "Oh, le brave Toby !\r\nC'est un compagnon si fidèle !");
                s = s.Replace("So...have you tracked anything down, then?\r\nWot d'ya think, eh? 'Course we 'ave!\r\nCan't tell you, though. Police business, innit?\r\nUgh...", "Et alors... avez-vous pisté quelque chose ?\r\nTu penses bien ! Évidemment qu'oui !\r\nMais secret d'l'instruction, pas touche aux civils !\r\nPfff...");
                s = s.Replace("Anyway, the point is, if you lot ever need any 'elp...\r\n...you know who to turn to, right?\r\nMe an' the 'ellhound 'ere!", "Bref, si vous avez besoin d'un coup d'main un d'ces quatre...\r\n...vous savez à qui vous adresser, pas vrai ?\r\nÀ moi et à mon molosse de l'enfer !");
                s = s.Replace("Right...\r\n(Because he looks oh-so hellish, honest.)", "C'est ça...\r\n(C'est vrai qu'il a l'air férocement diabolique, sans rire.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Um, Gina, about your ‘hellhound’ there...", "Euh, Gina, à propos de ton « molosse de l'enfer »...");
                s = s.Replace("Chief Inspector Toby, you mean?\r\n'E's the pride o' the force, 'e is!", "L'inspecteur principal Toby, tu veux dire ?\r\nC'est la fierté de toute la brigade, oui !");
                s = s.Replace("In Japanese, ‘police dog’ means something quite different,\r\nand not altogether nice to those involved in crime.", "En japonais, « chien de police » a une connotation bien particulière,\r\npas très flatteuse pour ceux qui côtoient le crime.");
                s = s.Replace("But here in Britain, it's a wonderful compliment, it seems!\r\nFor a canine, at least.", "Mais en Grande-Bretagne, cela sonne comme un éloge mérité !\r\nPour un canidé, tout du moins.");
                s = s.Replace("It should be. After all, in the Great Exhibition case the\r\nother day...\r\n...it was Toby here who managed to locate Drebber's\r\nworkshop.", "Et pour cause. Lors de l'affaire de l'Exposition universelle l'autre jour...\r\n...c'est bien Toby qui a déniché l'atelier clandestin de Drebber.");
                s = s.Replace("Maybe it's time for another demonstration of wot this\r\nsuperdog can do, eh?", "C'est p't-être l'moment de vous r'montrer c'que ce super-limier a\r\ndans l'flair, non ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("Um, Gina, about your ‘hellhound’ there...\r\nOh! Ya wanna see another demonstration of 'is amazin'\r\nnose, eh?\r\nWell, we're trying to trace Inspector Gregson's\r\nmovements, so...\r\nCome on, 'Oddo, wot ya got for 'im?", "Euh, Gina, au sujet de ton « molosse »...\r\nOh ! Tu veux une autre démonstration de son flair magique, dis ?\r\nEh bien, nous tentons de retracer le parcours de Gregson, alors...\r\nAllez, 'Oddo, sors-lui un truc à renifler !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("(Do we have something the chief inspector could catch\r\nthe scent of, I wonder...?)", "(Avons-nous un indice dont l'inspecteur principal Toby pourrait\r\nsuivre la trace...?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Well, Chief Inspector Toby, if you wouldn't mind having a\r\nsniff of this...", "Bien, inspecteur principal Toby, si vous vouliez bien prêter\r\nvotre truffe à cet objet...");
                s = s.Replace("The chief inspector said ‘woof’ to that, 'Oddo.\r\nYes...I heard.", "L'inspecteur principal a fait « wouf », 'Oddo.\r\nOui... j'ai bien entendu.");
                s = s.Replace("I think perhaps...that particular item didn't excite him\r\nvery much.\r\nAin't you got nuffin' else?\r\nI'll have a think...", "Je crois... que cet objet-là ne le stimule pas des masses.\r\nT'as rien d'autre sous la main ?\r\nJe vais réfléchir...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Well, Chief Inspector Toby, if you wouldn't mind having a\r\nsniff of this...", "Bien, inspecteur principal Toby, si vous vouliez bien prêter\r\nvotre truffe à cet objet...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("Well, Chief Inspector Toby, if you wouldn't mind having a\r\nsniff of this...\r\nHe...might be a little too keen, don't you think?", "Bien, inspecteur principal Toby, si vous vouliez bien prêter\r\nvotre truffe à cet objet...\r\nIl... est peut-être un peu trop enthousiaste, non ?");
                s = s.Replace("(The chief inspector made short work of Gina there.)", "(L'inspecteur principal n'a fait qu'une bouchée de Gina.)");
                s = s.Replace("Ah! Look what he's gone to!\r\nOh my! That trunk clearly still has a very strong scent...\r\n...of Inspector Gregson!\r\nIn other words...\r\n...it must have belonged to him!", "Ah ! Regardez vers quoi il fonce !\r\nBonté divine ! Cette malle dégage encore une très forte odeur...\r\n...de l'inspecteur Gregson !\r\nEn d'autres termes...\r\n...elle devait lui appartenir !");
                s = s.Replace("Oh alright! It's a fair cop, I s'pose.\r\nAnd you nearly got away with it, too...", "Bon d'accord ! Vous m'avez coincée, j'avoue.\r\nEt tu as failli réussir ton coup en plus...");
                s = s.Replace("You always talk so proudly of Chief Inspector Toby's nose\r\nand what it can achieve...\r\nDid it not cross your mind that he might identify\r\nsomething that was right next to us?", "Vous ne tarissez jamais d'éloges sur l'odorat de l'inspecteur Toby\r\net ses prouesses phénoménales...\r\nNe vous est-il point venu à l'esprit qu'il repérerait un objet\r\njuste à côté de nous ?");
                s = s.Replace("Yeah...that was a bit of a bloomer, weren't it?\r\nThat's enough now then, Gina!\r\nEh?!\r\nI think it's time you told us the truth about that trunk!", "Ouais... j'ai un peu manqué d'clairvoyance là, pas vrai ?\r\nÇa suffit les cachotteries maintenant, Gina !\r\nHein ?!\r\nIl est temps de cracher le morceau sur cette malle !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr050_01_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("It, it weren't like that! It, it just weren't!\r\nWhat are you talking about?", "C'était... c'était pas comme ça ! J'vous jure que non !\r\nDe quoi parles-tu donc ?");
                s = s.Replace("I know wot's going through that 'ead of yours!\r\nBut that ain't wot 'appened!\r\nAlright then...what DID happen?", "J'sais bien c'qui vous trotte dans l'cigare !\r\nMais c'est pas du tout ça !\r\nTrès bien alors... raconte-nous ce qui s'est passé !");
                s = s.Replace("Well...like I said before, we were tryin' to trace the boss's\r\nmovements.\r\nSo I let Toby 'ere 'ave a whiff o' the boss's overcoat.\r\nAnd as soon as I done that, 'e went off like a shot...\r\n...straight to that Sandwich.", "Ben... comme j'vous disais, on essayait d'pister les allées et venues du patron.\r\nAlors j'ai fait renifler le pardessus du patron à Toby.\r\nEt aussitôt, il a détartré comme une flèche...\r\n...droit sur ce Sandwich !");
                s = s.Replace("To a sandwich?\r\nNot to a bag of chips?\r\nMr Naruhodo!\r\nI believe Gina means the witness!", "Sur un sandwich ?\r\nPas sur un cornet de frites ?\r\nMonsieur Naruhodo !\r\nJe crois que Gina fait référence au témoin !");
                s = s.Replace("(Oh, I forgot about THAT Sandwich...)\r\nYeah, 'e 'ad it 'idden between them wooden boards of 'is!\r\nThe boss's trunk!", "(Ah, j'avais oublié CET homme-sandwich...)\r\nOuais, il l'avait planquée entre ses deux pancartes en bois !\r\nLa malle du patron !");
                s = s.Replace("You mean, when they heard the sound like a gunshot and\r\nall piled in here...\r\nExactly! 'E nabbed it from the scene!\r\nGoodness!", "Tu veux dire que lorsqu'ils ont entendu la détonation et ont débarqué...\r\nExact ! Il l'a fauchée direct sur la scène de crime !\r\nMon Dieu !");
                s = s.Replace("Me and the chief inspector gave that Sandwich a good\r\ngrillin', an' ya know wot 'e said?", "Moi et l'inspecteur principal, on a cuisiné ce Sandwich aux petits oignons, et vous savez c'qu'il a bafouillé ?");
                s = s.Replace("I, I thought it might fetch a g-good price, and the chap\r\nwouldn't be n-needing it any more, so...\r\nB-But that's all I did! Nothing more, n-n-nothing less!", "J-J'ai pensé qu'elle se revendrait à un b-bon prix, et l'bonhomme\r\nen avait p-plus besoin vu qu'il était froid, alors...\r\nM-Mais j'ai rien fait d'autre ! Rien d'plus, r-r-rien d'moins !");
                s = s.Replace("Would you Adam an' Eve the cheek of it, eh?!\r\nStealin' the dead boss's stuff to flog!\r\nSo Miss Venus wasn't the only one to meddle with the\r\nscene of the crime, then...\r\nHow could they?!", "Tu y crois à un culot pareil ?!\r\nPiquer les affaires du patron refroidi pour aller les refourguer !\r\nAinsi mademoiselle Vénus n'a pas été la seule à piller les lieux...\r\nComment ont-ils osé ?!");
                s = s.Replace("So anyway, that's 'ow it 'appened.\r\nAn' it's a pretty decent trunk, so I figured I might as well\r\nmake use of it.\r\nIs there summat wrong wiv that, eh?\r\nWell?", "Bref, voilà comment ça s'est goupillé.\r\nEt comme c'est une sacrée belle malle, j'me suis dit qu'autant en profiter.\r\nY a un problème avec ça, dites ?\r\nAlors ?");
                s = s.Replace("...Maybe you and Mr Sandwich should try to find the\r\nanswer to that question together.", "...Peut-être devriez-vous chercher la réponse à cette question en tête-à-tête avec M. Sandwich.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Can you at least tell us your side of the story, Lord van\r\nZieks? What happened?", "Pouvez-vous au moins nous donner votre version des faits, Lord\r\nVan Peers ? Que s'est-il passé ?");
                s = s.Replace("How much do you already know?", "Que savez-vous déjà ?");
                s = s.Replace("We know that the inspector was shot dead in a small,\r\nrented room on Fresno Street.\r\nAnd that you were found there by the police when they\r\narrived on the scene and immediately arrested.", "Nous savons que l'inspecteur a été abattu dans une modeste\r\npièce louée sur Fresno Street.\r\nEt que la police vous a découvert sur place à son arrivée\r\net vous a aussitôt arrêté.");
                s = s.Replace("We were told that there was nobody else in the room,\r\nand that some witnesses heard the gunshot.", "On nous a rapporté que personne d'autre ne se trouvait dans la pièce,\r\net que des témoins ont entendu le coup de feu.");
                s = s.Replace("Then you're well informed.\r\nAnd there's really nothing I can add.\r\nThe truth is, I don't know what happened myself.", "Alors vous êtes bien renseigné.\r\nEt je n'ai rien de plus à y ajouter.\r\nÀ dire vrai, j'ignore moi-même ce qui est survenu.");
                s = s.Replace("But...the gunshot! Obviously you didn't fire the gun,\r\ndid you?", "Mais... la détonation ! Vous n'avez évidemment pas fait feu,\r\nn'est-ce pas ?");
                s = s.Replace("I'm not in the habit of shooting the people I work\r\nalongside.\r\nI also heard the noise. However...\r\n...before I had a chance to investigate, I was apprehended\r\nby the arriving officers.", "Je n'ai point pour coutume d'abattre mes collaborateurs.\r\nJ'ai moi aussi entendu cette déflagration. Cependant...\r\n...avant même que je n'aie pu inspecter les lieux, j'ai été appréhendé par les agents accourus.");
                s = s.Replace("(So he doesn't actually know what happened...)\r\nIf I might ask, what were you doing in that place to begin\r\nwith?", "(Il ignore donc réellement ce qui s'est produit...)\r\nSi je puis me permettre, que faisiez-vous en ces lieux pour\r\ncommencer ?");
                s = s.Replace("I don't need to answer that.\r\nOh!\r\nAfter all, you're not representing me.\r\n(He is going to need a lawyer, though...)", "Je n'ai pas à répondre à cette question.\r\nOh !\r\nAprès tout, vous n'êtes point mon avocat.\r\n(Il va pourtant bien avoir besoin d'un défenseur...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Who is going to be representing you in court, Lord van\r\nZieks?\r\nAnyone other than you, I should imagine.\r\nHaaah...", "Qui assurera votre défense au tribunal, Lord\r\nVan Peers ?\r\nN'importe qui d'autre que vous, j'ose l'espérer.\r\nPffou...");
                s = s.Replace("Would I be right in assuming...that you have no\r\nrepresentation as yet?", "Aurai-je raison de présumer... que vous n'avez encore\r\naucun conseil pour vous assister ?");
                s = s.Replace("Defence lawyers shy away from any trial involving the\r\nReaper, as I'm sure you know.\r\nBut this is different.", "Les avocats fuient tout procès impliquant le\r\nFaucheur, vous ne l'ignorez point.\r\nMais cette affaire est différente.");
                s = s.Replace("In my career, of all the defendants I've prosecuted, only\r\nnineteen have ever been acquitted.\r\nOf them, sixteen subsequently died in mysterious\r\ncircumstances. Questions will be asked now.", "Au fil de ma carrière, de tous les prévenus que j'ai poursuivis, dix-neuf\r\nseulement ont été acquittés.\r\nParmi eux, seize ont péri par la suite dans de mystérieuses\r\ncirconstances. L'opinion va réclamer des comptes.");
                s = s.Replace("Surely not!\r\nI assure you, no defence lawyer will want to touch me\r\nwith the end of a barge pole.", "Ce n'est pas possible !\r\nJe vous le garantis, aucun avocat ne voudra m'approcher,\r\nfût-ce avec une perche de dix mètres.");
                s = s.Replace("But you didn't actually have anything to do with those\r\npeople's deaths...did you?", "Mais vous n'avez rien à voir avec la disparition de ces\r\ngens... n'est-ce pas ?");
                s = s.Replace("It's been ten years now that I've been known as the\r\nReaper of the Bailey.\r\nBelieve me, nobody wants to know the true identity of\r\nthis killer more than I. However...\r\n...it seems things may come to a head before I have the\r\nchance to uncover the truth about that.\r\n(What does he mean by that?)", "Voilà dix ans désormais que l'on me nomme le\r\nFaucheur de l'Old Bailey.\r\nCroyez-moi, nul ne désire davantage démasquer ce criminel que moi. Cependant...\r\n...il semble que le couperet doive tomber avant que je n'aie\r\nle temps d'élucider la vérité.\r\n(Que veut-il dire par là ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("(After the trial...)\r\n(...Professor Harebrayne was supposed to go straight back\r\nto Germany, I thought.)", "(Après le procès...)\r\n(...le Pr Lonron devait regagner l'Allemagne sans attendre,\r\nme semblait-il.)");
                s = s.Replace("It's a letter to inform me of his safe arrival at home.\r\nI arranged his passage by sea and rail.\r\nIt's a relief, I must say. He should now be beyond the\r\nreaches of the Reaper.", "C'est une missive m'annonçant qu'il a regagné ses pénates sain et sauf.\r\nJ'ai veillé personnellement à ses billets de train et de vapeur.\r\nC'est un profond soulagement. Il est désormais hors d'atteinte\r\ndu Faucheur.");
                s = s.Replace("Because the Reaper doesn't follow people abroad, you \r\nmean?\r\nYes. So it seems.", "Parce que le Faucheur ne frappe jamais hors des frontières,\r\nvoulez-vous dire ?\r\nOui. Tout porte à le croire.");
                s = s.Replace("Your stooped little Nipponese friend, for example.\r\nYou told me he was keeping well in Japan when I\r\nenquired the other day.\r\nYes, that's right. He's an author now. Happily working in\r\nTokyo.", "Votre petit ami nippon voûté, par exemple.\r\nVous m'avez certifié qu'il se portait à merveille au Japon\r\nlorsque je m'en suis enquis l'autre jour.\r\nOui, tout à fait. Il s'adonne à l'écriture désormais, serein à\r\nTokyo.");
                s = s.Replace("So Professor Harebrayne is safely back in Germany now.\r\nHe is.", "Le professeur Lonron est donc bien rentré en Allemagne.\r\nParfaitement.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("What's that?\r\nAh, it's just something I was hoping to ask your opinion\r\nabout, that's all.", "Qu'est-ce donc ?\r\nAh, c'est seulement un détail sur lequel j'espérais avoir votre avis,\r\nc'est tout.");
                s = s.Replace("It's a serious crime for the defence to attempt to extract\r\ninformation from the prosecution by illegal means.", "C'est un délit passible de prison pour la défense que de chercher\r\nà soutirer des informations à l'accusation par des voies illicites.");
                s = s.Replace("...I think we have more of a defence and client\r\nrelationship now...don't we?", "...Il me semble que nos liens relèvent désormais d'avocat à\r\nclient... n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("What's that?\r\nAh, it's just something I was hoping to ask your opinion\r\nabout, that's all.", "Qu'est-ce donc ?\r\nAh, c'est seulement un détail sur lequel j'espérais avoir votre avis,\r\nc'est tout.");
                s = s.Replace("It's a serious crime for the defence to attempt to extract\r\ninformation from the prosecution by illegal means.", "C'est un délit passible de prison pour la défense que de chercher\r\nà soutirer des informations à l'accusation par des voies illicites.");
                s = s.Replace("...Alright, I get the message.\r\nBut I don't see what's illegal about me asking...", "...Entendu, message reçu.\r\nMais je ne vois guère ce qu'il y a d'illégal à poser une simple question...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Lord van Zieks, we came by this old photograph...\r\n...!\r\nWhere did you get that?!", "Lord Van Peers, nous sommes tombés sur cette ancienne photographie...\r\n... !\r\nOù vous êtes-vous procuré ce cliché ?!");
                s = s.Replace("It was taken when I became a qualified prosecutor.\r\nIt's almost unbelievable.\r\nI, I assumed it was long lost.", "Il a été pris le jour de ma titularisation comme procureur.\r\nC'est à peine croyable.\r\nJe... je la croyais perdue à jamais.");
                s = s.Replace("Um, is the man on the left there...?\r\nYes, that's my brother.\r\nKlint.", "Euh, l'homme à gauche sur la photo est-il... ?\r\nOui, c'est mon frère.\r\nKlimt.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("The details of Gregson's photograph\r\nhave been updated in the Court Record.", "Les détails de la photographie de Gregson\r\nont été mis à jour dans le dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("(It had to be, really.)\r\nApparently this picture was prominently displayed in\r\nGregson's office.\r\nHe had a deep respect for you, you know.\r\n...Were you aware of that?", "(C'était évident, au fond.)\r\nParaît-il que cette photo trônait en bonne place dans le\r\nbureau de Gregson.\r\nIl vous portait une estime infinie, vous savez.\r\n...En aviez-vous conscience ?");
                s = s.Replace("Respect?!\r\nThat's...nonsense!", "De l'estime ?!\r\nC'est... une ineptie !");
                s = s.Replace("No, we've heard someone attest to it very clearly.\r\n(Inspector Gina Lestrade, no less.)", "Non, une personne nous l'a certifié sans la moindre ambiguïté.\r\n(L'inspectrice Gina Lestrade en personne.)");
                s = s.Replace("Well...maybe once, yes.\r\nThere was a time things were like that.\r\nWe were brothers in arms...jovially discussing the future\r\nof justice and other such lofty subject matter.", "Eh bien... autrefois peut-être, oui.\r\nIl fut un temps où les choses étaient ainsi.\r\nNous étions compagnons d'armes... dissertant avec ferveur de l'avenir\r\nde la justice et d'autres nobles idéaux.");
                s = s.Replace("That was a nice glimpse of the past.\r\nI thank you.", "Ce fut une douce évocation du passé.\r\nJe vous en remercie.");
                s = s.Replace("(I feel as though I got a nice glimpse of the past then, too.)\r\n(There was a glimmer of light in his eyes.\r\nA brief twinkle.)\r\n(An insight into the true nature of this man known to all\r\nas the stone-cold Reaper of the Bailey.)", "(J'ai le sentiment d'avoir moi aussi entrevu un pan de ce passé.)\r\n(Une lueur a brillé dans son regard.\r\nUne étincelle fugitive.)\r\n(Un aperçu de la vraie nature de cet homme réputé\r\nêtre l'impitoyable Faucheur de l'Old Bailey.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("I think you know that this is worn by people in my\r\ncountry to show that they're defence lawyers, don't you?", "Vous savez pertinemment que ceci est porté chez moi pour attester\r\ndu statut d'avocat de la défense, n'est-ce pas ?");
                s = s.Replace("And I think you know that I believed you to be merely\r\nplaying at lawyer-craft...initially.\r\nBut it would seem your armband may actually imply\r\nsome dormant talent after all.\r\nLord van Zieks!\r\nDo you mean...?", "Et vous savez sans doute que je vous croyais simple amateur jouant\r\nà l'homme de loi... au commencement.\r\nMais il semblerait que votre brassard dissimule après tout\r\nquelque talent assoupi.\r\nLord Van Peers !\r\nVoulez-vous dire que... ?");
                s = s.Replace("Let's hope you wake up soon.\r\n(Yes, I was clearly daydreaming. I almost thought I got a\r\ncompliment there.)", "Espérons que vous sortiez bientôt de votre torpeur.\r\n(Oui, j'étais manifestement en plein songe. J'ai presque cru à un\r\ncompliment.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("...It's not for me.\r\nAh, that's...not why I was showing you it.\r\nI suppose...\r\n...if it was a Black-Headed League, you would have no\r\nhesitation.\r\nNone whatsoever!", "...Ce n'est point pour moi.\r\nAh, ce n'est... pas pour cela que je vous le montrais.\r\nJ'imagine que...\r\n...s'il s'agissait d'une Ligue des Têtes Noires, vous n'auriez nulle\r\nhésitation.\r\nAucune, assurément !");
                s = s.Replace("Sadly my own hair could no more be described as black\r\nas it could red.\r\nWhat coloured league should I then join?\r\nPeople are troubled by the most unexpected problems at\r\ntimes...", "Hélas, ma chevelure ne saurait être qualifiée de noire\r\npas plus que de rousse.\r\nQuelle ligue de couleur devrais-je donc rallier ?\r\nLes gens se tourmentent parfois pour des futilités bien inattendues...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("Ten years ago, my older brother, who was the Director of\r\nProsecutions at the time, was murdered.\r\nAnd the killer, as you know...was a visiting student from\r\nthe Far East.", "Il y a dix ans, mon frère aîné, alors chef des procureurs,\r\nfut assassiné.\r\nEt le meurtrier, vous ne l'ignorez point... était un étudiant visiteur venu\r\nd'Extrême-Orient.");
                s = s.Replace("Not a single day goes by...when I don't curse the name\r\nAsogi!", "Il ne se passe pas un seul jour... sans que je ne maudisse le nom\r\nd'Asogi !");
                s = s.Replace("Genshin Asogi was Kazuma-sama's father.\r\nSo what cruel twist of fate is this now, ten years later?\r\nThe man's son is to crucify me in some kangaroo court?", "Genshin Asogi était le père de monsieur Kiyô.\r\nQuelle cruelle ironie du sort est-ce là, dix ans plus tard ?\r\nLe fils de cet homme va me crucifier dans un simulacre de procès ?");
                s = s.Replace("I still don't understand why Lord Stronghart apprenticed\r\nKazuma to you.\r\nIt's what he does. No doubt he knew of the young man's\r\ntrue identity from the outset.", "Je ne comprends toujours pas pourquoi Lord Harry Caine a placé Kazuma en apprentissage auprès de vous.\r\nC'est sa méthode. Il connaissait sans doute la véritable identité\r\ndu jeune homme depuis le début.");
                s = s.Replace("But what could he have been hoping to achieve?\r\nAnd let's not forget that it was only eight days ago that\r\nKazuma recovered from his amnesia.\r\nWhy would Lord Stronghart assign this trial to somebody\r\nlike that?", "Mais quel pouvait bien être son but ?\r\nEt n'oublions pas que cela ne fait que huit jours que Kazuma a recouvré la mémoire.\r\nPourquoi Lord Harry Caine confierait-il ce procès à une telle personne ?");
                s = s.Replace("Hm...Asogi...\r\nThat name is the very epitome of my bane.\r\nThe bane that is you Nipponese.\r\n(Right... Your hatred of all us Japanese...)", "Hum... Asogi...\r\nCe nom est l'incarnation même de mon supplice.\r\nLe fléau que vous représentez, vous autres Japonais.\r\n(C'est cela... Votre haine viscérale envers nous tous...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("I'd only just been appointed as a prosecutor when it\r\nhappened ten years ago.\r\nMy brother Klint, the Director of Prosecutions, was\r\nhunting down a mass murderer.\r\nThe so-called ‘Professor’...", "Je venais tout juste d'être nommé procureur lorsque le drame est survenu il y a dix ans.\r\nMon frère Klimt, le chef des procureurs, traquait\r\nun tueur de masse sanguinaire.\r\nLe sinistre « Démon Assassin »...");
                s = s.Replace("Assigned to the investigation as his partner...\r\n...was a certain visiting student dispatched from Scotland\r\nYard.\r\nAnd that was Genshin Asogi?\r\nExactly.", "Affecté à cette enquête comme son partenaire...\r\n...se trouvait un certain étudiant visiteur détaché auprès de Scotland Yard.\r\nEt c'était Genshin Asogi ?\r\nPrécisément.");
                s = s.Replace("I developed a deep respect for the man. He seemed\r\nnoble-minded and chivalrous in the extreme to me.\r\n...But none of us saw the true nature of the man.", "J'avais conçu une profonde admiration pour cet individu. Il m'apparaissait\r\nd'une noblesse d'âme et d'une bravoure incomparables.\r\n...Mais aucun de nous n'avait percé à jour sa véritable nature.");
                s = s.Replace("So I lost everything when it happened.\r\nMy esteemed brother...the people I believed in...and\r\nany semblance of right prevailing over wrong!\r\nOh...how awful...", "J'ai donc tout perdu lorsque le malheur a frappé.\r\nMon frère vénéré... les êtres en qui j'avais foi... et\r\ntoute illusion de voir la justice triompher de l'infamie !\r\nOh... quelle horreur...");
                s = s.Replace("To avenge my brother, I prosecuted in Asogi's trial.\r\nIt wouldn't ordinarily have been allowed, but I\r\nbeleaguered the ascribed prosecutor until he consented.", "Pour venger mon frère, j'ai porté l'accusation au procès d'Asogi.\r\nCela n'aurait jamais dû m'être accordé, mais j'ai harcelé\r\nle procureur en titre jusqu'à ce qu'il cède.");
                s = s.Replace("What do you mean by the ascribed prosecutor?\r\nThe man in charge of the Professor case inquiry:\r\nLord Mael Stronghart.\r\nWait, what?! Lord Stronghart?", "Que voulez-vous dire par le procureur en titre ?\r\nL'homme qui supervisait l'enquête du Démon Assassin :\r\nLord Harry Caine.\r\nAttendez, quoi ?! Lord Harry Caine ?");
                s = s.Replace("He was a highly accomplished prosecutor. But he agreed\r\nto relinquish the trial to me and act as my adviser instead.\r\nSince that time, he's the one person to whom I've felt\r\nindebted.", "C'était un magistrat hors pair. Il a consenti à me céder\r\nle siège et à me guider comme conseiller.\r\nDepuis lors, il est l'unique individu envers qui je nourrisse\r\nune dette infinie.");
                s = s.Replace("I'm sure he must have seen your zeal for the case and\r\nrecognised your potential as a prosecutor.\r\nAnyway, time passed, but then earlier this year, who\r\nshould arrive in London...but you.\r\nAh!\r\nAnd, of all things...as a lawyer.", "Il a sûrement décelé votre ferveur pour cette cause et\r\npressenti votre prodigieux avenir de procureur.\r\nQuoi qu'il en soit, les années ont passé, et voici que plus tôt cette année débarquait à Londres...\r\nnul autre que vous.\r\nAh !\r\nEt pour couronner le tout... sous les traits d'un avocat.");
                s = s.Replace("I felt your animosity the first time I ever faced you in the\r\ncourtroom.\r\nYour obvious deep loathing of us Japanese.\r\nI kept telling myself it was illogical.\r\nBut for so many years, that hatred had festered inside me,\r\nI could no longer control it.", "J'ai ressenti votre hostilité dès notre premier face-à-face dans l'enceinte du tribunal.\r\nVotre dégoût viscéral et manifeste envers nous, les Japonais.\r\nJe me répétais sans cesse que c'était insensé.\r\nMais pendant tant d'années, cette rancœur avait fermenté en moi,\r\nau point que je ne pouvais plus la contenir.");
                s = s.Replace("And I can understand why, now I know the history.\r\nBut in the same way that I've long felt the Nipponese to be\r\nthe bane of my life...\r\n...to Kazuma Asogi, I am the bane of his. The Reaper who\r\nsent his father to the gallows.\r\nHe's looking for revenge, and he intends to take it in\r\ncourt tomorrow.", "Et je peux le comprendre, maintenant que je connais l'histoire.\r\nMais de la même façon que les Japonais ont été le poison de mon existence...\r\n...aux yeux de Kazuma Asogi, je suis le bourreau de la sienne. Le Faucheur qui\r\na expédié son père à l'échafaud.\r\nIl veut sa vengeance, et il compte bien l'assouvir à l'audience demain.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("Gregson's transfer to the Paris Police Prefecture had\r\nfinally been arranged for the coming month.\r\nBut he'll never make it to France now.\r\n...It's a tragedy.", "La mutation de Gregson à la préfecture de police de Paris avait\r\nenfin été entérinée pour le mois prochain.\r\nMais il ne verra jamais la France désormais.\r\n...C'est une tragédie.");
                s = s.Replace("Oh yes, come to think of it he did mention something\r\nabout that, didn't he?\r\nI wonder...does it happen often?\r\nBeing transferred internationally, I mean?\r\n...It's the first time I've ever encountered it.", "Ah oui, en y repensant, il avait mentionné quelque chose à ce sujet,\r\nn'est-ce pas ?\r\nJe me demande... est-ce chose fréquente ?\r\nÊtre muté à l'étranger, je veux dire ?\r\n...C'est la toute première fois que je vois pareille chose.");
                s = s.Replace("The Paris police welcoming an English detective is...\r\nalmost inconceivable.\r\nI can't imagine what kind of magic Gregson must have\r\nworked to put that arrangement in place.\r\n(...It sounds like that mystery has even the Reaper\r\nperplexed.)", "Voir la police parisienne accueillir un inspecteur anglais à bras ouverts est...\r\npour ainsi dire impensable.\r\nJ'ignore par quel tour de passe-passe Gregson a bien pu négocier un tel accord.\r\n(...On dirait que ce mystère laisse même le Faucheur pantois.)");
                s = s.Replace("I'm afraid to say...\r\n...that we were very ignorant about Inspector Gregson's\r\nstanding.\r\nWe hear that he was considered something of a legend at\r\nScotland Yard.", "Je dois humblement avouer...\r\n...que nous ignorions tout du statut réel de l'inspecteur Gregson.\r\nOn raconte qu'il passait pour une véritable légende vivante à Scotland Yard.");
                s = s.Replace("Again, it was ten years ago that he first made a name for\r\nhimself.\r\nBy uncovering a decisive piece of evidence that exposed\r\nthe Professor's identity.\r\nIf it wasn't for Gregson's singular approach to the case,\r\nthe discovery would never have been made.", "Là encore, c'est il y a dix ans qu'il s'est illustré pour la première fois.\r\nEn mettant au jour une preuve décisive qui révéla l'identité du Démon Assassin.\r\nSans l'approche singulière de Gregson sur cette affaire,\r\ncette découverte n'aurait jamais vu le jour.");
                s = s.Replace("What sort of approach?\r\nAfter my brother's life was taken, the inspector pushed\r\nfor a full autopsy.\r\nOh my! Ten years ago?\r\n...Why is that so surprising?", "Quelle sorte d'approche ?\r\nAprès l'assassinat de mon frère, l'inspecteur a exigé une autopsie complète.\r\nBonté divine ! Il y a dix ans ?\r\n...En quoi cela est-il si surprenant ?");
                s = s.Replace("Autopsy was considered a desecration of the body at the\r\ntime, and rarely performed.\r\nAnd my brother was of course a noble. That made the\r\nidea of it even more unthinkable.", "L'autopsie passait pour une profanation de sépulture à l'époque, et n'était que très rarement pratiquée.\r\nEt mon frère appartenait bien sûr à la haute noblesse. Cela rendait l'idée plus impensable encore.");
                s = s.Replace("But something Gregson had dug up in his investigations\r\nmade him determined it was necessary.\r\nHis powerful conviction somehow influenced the House of\r\nLords and as a result...\r\nI could avenge my brother's death.", "Mais un indice déterré par Gregson lors de ses fouilles l'a convaincu de cette absolue nécessité.\r\nSa force de persuasion a fini par emporter l'adhésion de la Chambre des lords et grâce à cela...\r\nj'ai pu venger la mort de mon frère.");
                s = s.Replace("So...you must have had great confidence in the inspector's\r\nabilities, then.\r\nAnd it's even more inconceivable that you would have\r\ntaken his life!\r\n...I don't have confidence in anyone.", "Ainsi... vous deviez vouer une immense confiance aux compétences\r\nde l'inspecteur.\r\nEt il est encore plus invraisemblable que vous ayez pu attenter à ses jours !\r\n...Je n'accorde ma confiance à personne.");
                s = s.Replace("And I'm sure Gregson felt the same way.\r\nI've no doubt he thought of me only as the ominous\r\nReaper, just like the rest of London.", "Et nul doute que Gregson éprouvait la même méfiance.\r\nIl ne voyait en moi que le sinistre Faucheur, à l'instar\r\nde tout Londres.");
                s = s.Replace("(What really went on between Lord van Zieks and\r\nGregson, I wonder?)\r\n(What was the true nature of their relationship?)", "(Que s'est-il réellement passé entre Lord Van Peers et Gregson ?)\r\n(Quelle était la véritable nature de leurs relations ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("Inspector Gregson...", "L'inspecteur Gregson...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_00_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("About the gun used to shoot the inspector that was found\r\nat the scene...\r\nAh yes... That's not mine.", "À propos de l'arme du crime retrouvée sur les lieux qui a servi à abattre l'inspecteur...\r\nAh oui... Ce n'est point la mienne.");
                s = s.Replace("Really? Because common opinion seems to be that it is.\r\nWhat do you expect me to say to that?", "Vraiment ? Pourtant tout le monde s'accorde à dire le contraire.\r\nQu'attendez-vous que je réponde à cela ?");
                s = s.Replace("Lord Stronghart informs us that you claim to have\r\nmisplaced your firearm.\r\nAs embarrassing as that is, I'm afraid it's true.\r\nWhen did you lose it, then?", "Lord Harry Caine nous a informés que vous prétendiez avoir\r\négaré votre arme de service.\r\nAussi déshonorant que cela soit, je crains que ce ne soit la vérité.\r\nQuand l'avez-vous perdue alors ?");
                s = s.Replace("That...I don't know.\r\nOh!\r\nI was issued with a revolver when I first became a\r\nprosecutor ten years ago.\r\nI must have stowed it somewhere, I suppose.\r\nOr left it somewhere, perhaps.", "Cela... je l'ignore.\r\nOh !\r\nOn m'a remis un revolver lors de mon entrée en fonction il y a dix ans.\r\nJ'ai dû le ranger quelque part, j'imagine.\r\nOu l'oublier dans un tiroir, sans doute.");
                s = s.Replace("You have something in common with Lord van Zieks after\r\nall, Mr Naruhodo: a talent for misplacing things.", "Vous avez un point commun avec Lord Van Peers après\r\ntout, monsieur Naruhodo : le don d'égarer vos affaires.");
                s = s.Replace("No no no! This is nothing to do with me!\r\nDon't drag me into it!\r\nDon't make the mistake of associating me with this...\r\nNipponese!", "Non non non ! Cela n'a rien à voir avec moi !\r\nNe me mêlez point à cela !\r\nNe commettez point l'outrecuidance de m'associer à ce...\r\nJaponais !");
                s = s.Replace("Oh dear... The rift is very wide, isn't it?\r\n(So it's not decisive evidence, clearly.\r\nBut it doesn't look good, that's for sure.)", "Mince alors... Le fossé reste immense, n'est-ce pas ?\r\n(Ce n'est certes pas une preuve irréfutable.\r\nMais cela sent mauvais, c'est une certitude.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("You once told me that you gladly allowed people to\r\nbelieve you were the Reaper...\r\n...because it helped reduce the amount of serious crime\r\nthat took place in London.", "Vous m'avez dit jadis que vous laissiez volontiers les gens croire\r\nque vous étiez le Faucheur...\r\n...car cela contribuait à endiguer le grand banditisme à Londres.");
                s = s.Replace("If keeping quiet and playing the part benefits the cause –\r\na cause I myself am committed to pursuing...\r\n...then why would I choose to say anything?", "Si garder le silence et endosser ce rôle sert la cause –\r\nune cause pour laquelle j'ai dédié mon existence...\r\n...pourquoi choisirais-je de démentir quoi que ce soit ?");
                s = s.Replace("But the henchmen of a criminal killed by the Reaper\r\nattacked you only the other day.\r\nAnd that was just the most recent of many attempts on\r\nyour life, wasn't it?\r\nSomeone is clearly profiting from your silence about all\r\nthis! Someone is using you!", "Mais les sbires d'un criminel exécuté par le Faucheur vous ont\r\nagressé pas plus tard que l'autre jour.\r\nEt ce n'était que le dernier d'une longue série d'attentats contre vous, non ?\r\nQuelqu'un tire clairement profit de votre mutisme !\r\nOn vous manipule !");
                s = s.Replace("Believe me, ever since the Reaper first appeared...\r\n...I've been doing my utmost to expose him.\r\nOr rather...expose the organisation.", "Croyez-moi, depuis l'apparition des premiers méfaits du Faucheur...\r\n...j'ai tout tenté pour le démasquer.\r\nOu plutôt... démanteler l'organisation.");
                s = s.Replace("Ah! It's a whole organisation?!\r\nIt's inconceivable that all those ‘accidents’ were\r\norchestrated by one man.", "Ah ! Il s'agit de tout un réseau ?!\r\nIl est impensable que tous ces « accidents » aient été orchestrés\r\npar un seul homme.");
                s = s.Replace("No, the Reaper always appears to have very accurate\r\ninformation about the accused in each case.\r\nWhich can only mean...\r\n...that somebody at Scotland Yard is involved.", "Non, le Faucheur dispose systématiquement de renseignements\r\nd'une précision chirurgicale sur les accusés.\r\nCe qui ne peut signifier qu'une chose...\r\n...qu'un membre influent de Scotland Yard tire les ficelles.");
                s = s.Replace("Someone at... You, you can't mean...?!\r\nIt's taken me many years, but I've finally identified the\r\ncentral figure in this Reaper organisation:\r\n...Tobias Gregson.", "Quelqu'un au... Vous ne voulez tout de même pas dire...?!\r\nIl m'a fallu de longues années, mais j'ai fini par identifier la\r\npièce maîtresse de cette confrérie du Faucheur :\r\n...Tobias Gregson.");
                s = s.Replace("No...NOOOOOO!\r\n(Gregson! The Reaper?!)", "Non... NOOOON !\r\n(Gregson ! Le Faucheur ?!)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So...the reason you were investigating Inspector Gregson\r\nis because...\r\n...you intended to expose him as the Reaper?!", "Ainsi... la raison pour laquelle vous espionniez l'inspecteur Gregson\r\nétait que...\r\n...vous aviez l'intention de prouver qu'il était le Faucheur ?!");
                s = s.Replace("As I said, the Reaper of the Bailey is no single person.\r\nIt's a highly secret organisation with close ties to Scotland\r\nYard.\r\nBut there's no doubt that Gregson was a key member of\r\nthat organisation.", "Comme je l'ai dit, le Faucheur de l'Old Bailey n'est pas un individu isolé.\r\nC'est une société secrète ramifiée au cœur de Scotland Yard.\r\nMais il est indéniable que Gregson était un maillon clé de cette organisation.");
                s = s.Replace("I, I don't believe it...\r\nAre you saying that Gregsy...? That he was behind all\r\nthose awful criminals meeting their...?", "Je... je n'arrive pas à y croire...\r\nÊtes-vous en train de dire que Gregounet... ? Qu'il était derrière\r\nla mort violente de tous ces scélérats... ?");
                s = s.Replace("Gregson didn't do the dirty work himself.\r\nOh!\r\nHe was the tactician. His job was to covertly investigate\r\nthe marks and plot their assassinations.", "Gregson n'accomplissait point les basses besognes lui-même.\r\nOh !\r\nIl était le stratège. Son rôle consistait à pister les cibles et planifier\r\nleur exécution.");
                s = s.Replace("In order to do that without arousing suspicion, he\r\nregularly needed a firm alibi.\r\n...Which is where Mr Vigil came in.\r\nPosing as the inspector...", "Afin d'agir sans éveiller les soupçons, il lui fallait\r\nsystématiquement un alibi en béton armé.\r\n...Et c'est là que M. Vigil entrait en scène.\r\nEn se faisant passer pour l'inspecteur...");
                s = s.Replace("Vigil knows nothing of the Reaper.\r\nBut the room he rents on Fresno Street was almost\r\ncertainly the headquarters of the operation.\r\nGregson would have met the assassin there for briefings.", "Vigil ne sait rien du Faucheur.\r\nMais la piaule qu'il loue sur Fresno Street servait quasi\r\ncertainement de quartier général à l'opération.\r\nGregson devait y retrouver l'assassin pour lui donner ses instructions.");
                s = s.Replace("So we don't actually know who carried out the killings,\r\nthen?\r\n...Actually, I do have a name.\r\nYou...WHAT?!", "Nous ignorons donc qui a réellement exécuté ces assassinats ?\r\n...En réalité, j'ai bel et bien un nom.\r\nVous... QUOI ?!");
                s = s.Replace("Well if you can name the man, you have the true identity\r\nof the Reaper already, then!\r\nOr...if I can name the woman.\r\nOh...\r\nShe's a young woman by the name of Asa Shinn.", "Mais si vous pouvez nommer cet homme, vous détenez déjà la véritable identité du Faucheur !\r\nOu plutôt... si je peux nommer cette femme.\r\nOh...\r\nIl s'agit d'une jeune femme répondant au nom d'Asa Shinn.");
                s = s.Replace("Wait... WHAAAT?!\r\n(‘Shinn’?!)", "Attendez... QUOOOI ?!\r\n(« Shinn » ?!)");
                s = s.Replace("Miss Asa Shinn...\r\nThe true name of a terrifying killer I know only too well.", "Mademoiselle Asa Shinn...\r\nLe véritable patronyme d'une redoutable meurtrière que je ne connais que trop bien.");
                s = s.Replace("She came to Japan posing as a visiting student\r\nand murdered Dr John H. Wilson.", "Elle est venue au Japon sous les traits d'une étudiante britannique\r\net a empoisonné le Dr John H. Wilson.");
                s = s.Replace("Then, just when it seemed that diplomatic protection\r\nwould help her escape Japan and conviction...\r\n...the mysterious woman was herself\r\nmurdered in a small summer beach hut.\r\nAnd that woman...\r\nwas actually the Reaper of the Bailey?!", "Puis, au moment précis où l'immunité diplomatique\r\ndevait lui permettre de fuir le Japon sans être inquiétée...\r\n...cette mystérieuse femme fut elle-même\r\nassassinée dans une cabine de bain de plage.\r\nEt cette femme...\r\nétait en réalité le bras armé du Faucheur de l'Old Bailey ?!");
                s = s.Replace("Mr Naruhodo, this perhaps isn't the place to discuss...\r\nNo. No, of course not.\r\n(We can't mention it here.)\r\n(The fact that she killed Dr John H. Wilson.)\r\n(Because Iris doesn't know and it's very likely that the\r\nman was her father.)\r\n...?\r\nAsa Shinn...\r\nI should let Father know at once!\r\nYes, I agree.", "Monsieur Naruhodo, ce n'est peut-être pas l'endroit pour évoquer...\r\nNon. Non, évidemment.\r\n(Nous ne pouvons point aborder cela ici.)\r\n(Le fait qu'elle ait assassiné le Dr John H. Wilson.)\r\n(Car Iris l'ignore, et tout porte à croire que cet homme était son père.)\r\n... ?\r\nAsa Shinn...\r\nJe dois en avertir Père sans attendre !\r\nOui, je suis bien d'accord.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Kazuma, isn't it? Kazuma Asogi.\r\nYou say he's a friend of yours.\r\nMy best friend.", "Kazuma, n'est-ce pas ? Kazuma Asogi.\r\nVous affirmez qu'il est votre ami.\r\nMon meilleur ami.");
                s = s.Replace("He's the whole reason I got to come to Britain.\r\nIt was all on his merits.\r\nI have nothing but respect for him.", "Il est la seule raison de ma venue en Grande-Bretagne.\r\nTout s'est fait grâce à ses mérites exceptionnels.\r\nJe n'ai qu'une admiration sans bornes pour lui.");
                s = s.Replace("Yes, I understand that only the very best students are\r\nselected for such opportunities.\r\nAnd I had a fine demonstration of how sharp he is in the\r\nproceedings earlier today. He missed nothing.", "Oui, je sais que seule l'élite des étudiants est\r\nchoisie pour de tels honneurs.\r\nEt j'ai pu mesurer toute la vivacité de son esprit lors des\r\ndébats de ce matin. Rien ne lui a échappé.");
                s = s.Replace("In fact, his flawless performance very much reminded\r\nme...of his father.\r\n(Genshin Asogi.\r\nThe Professor...)", "À dire vrai, sa prestation magistrale m'a douloureusement\r\nrappelé... son père.\r\n(Genshin Asogi.\r\nLe Démon Assassin...)");
                s = s.Replace("It's true that the aristocracy at the time was the root of\r\nnumerous grave societal problems.\r\nThey were abusing their power. Playing with the\r\ncommon man as pawns in politics...in economics...in war.", "Il est indéniable que la noblesse d'alors était le terreau\r\nde profonds fléaux sociaux.\r\nIls abusaient de leurs privilèges. Utilisant le petit peuple comme des pions\r\nen politique... en économie... à la guerre.");
                s = s.Replace("In many ways, Asogi was carving out a canker from\r\nsociety that we British couldn't deal with ourselves.\r\nAh, I... I see...", "À bien des égards, Asogi extirpait une tumeur sociale que nous autres Britanniques étions impuissants à guérir.\r\nAh, je... je vois...");
                s = s.Replace("But that's precisely why it makes no sense.\r\nKlint van Zieks was a noble and upstanding man.\r\nHe wasn't corrupt.", "Mais c'est précisément pour cela que son acte est incompréhensible.\r\nKlimt Van Peers était un gentilhomme intègre et exemplaire.\r\nIl était incorruptible.");
                s = s.Replace("Why did that damned Nipponese have to go and take my\r\nbrother's life?\r\n...In spite of having once saved mine.", "Pourquoi ce maudit Japonais a-t-il fallu qu'il prenne\r\nla vie de mon frère ?\r\n...Après avoir pourtant jadis sauvé la mienne.");
                s = s.Replace("He saved your life?\r\n(How did that happen?)", "Il vous a sauvé la vie ?\r\n(Comment cela est-il arrivé ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("It was ten years ago, on a foggy night.", "C'était il y a dix ans, par une nuit de brouillard épais.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("It was ten years ago, on a foggy night.", "C'était il y a dix ans, par une nuit de brouillard épais.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("What was to be the Professor's final strike had...sent\r\n a wave of panic through the capital.\r\n(So Klint van Zieks had already been killed at this point,\r\nthen.)", "Ce qui devait être le coup fatal du Démon Assassin avait... semé\r\nune panique sans précédent dans toute la capitale.\r\n(Klimt Van Peers avait donc déjà été assassiné à ce moment-là.)");
                s = s.Replace("Genshin and I were walking down some back streets at a\r\nlate hour.", "Genshin et moi marchions dans des ruelles désertes à une\r\nheure fort tardive.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Genshin and I were walking down some back streets at a\r\nlate hour.", "Genshin et moi marchions dans des ruelles désertes à une\r\nheure fort tardive.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Of course, at that point, I had no idea of the true nature of\r\nthe man at my side.\r\nAll of a sudden...\r\nDon't make a peep!\r\nYou're comin' with us!", "Évidemment, à cet instant, j'ignorais la nature monstrueuse de\r\nl'homme qui marchait à mes côtés.\r\nTout à coup...\r\nPas un geste !\r\nVous venez avec nous !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("All of a sudden...\r\nDon't make a peep!\r\nYou're comin' with us!", "Tout à coup...\r\nPas un geste !\r\nVous venez avec nous !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr060_01_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("We were surrounded.\r\nAll of our assailants were armed with pistols, their faces\r\nobscured by scarves.", "Nous étions encerclés.\r\nTous nos agresseurs étaient armés de pistolets, leurs visages\r\ndissimulés par des écharpes.");
                return s;
            };

        }
    }
}
