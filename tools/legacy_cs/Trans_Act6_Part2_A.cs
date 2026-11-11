using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorAct6 {
    public partial class Program {
        public static void RegisterPart2_A() {
            entryTranslators[@"BB\script\output\_sce02_chr050_00_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("Gina, have a look at this photograph...", "Gina, regarde cette photographie...");
                s = s.Replace("It's amazin' lookin' down on everyfin' from up there.\r\nI love 'igh places, me.", "C'est dément d'tout voir d'en haut comme ça. J'adore les endroits perchés, moi.");
                s = s.Replace("Really? If I'm honest, I can't stand looking down at the\r\nground when I'm high up. I always have to look up.", "Vraiment ? Pour être franc, j'ai le vertige dès que je regarde en bas. Je dois toujours lever les yeux vers le ciel.");
                s = s.Replace("Shame, I wanted to show ya wot it's like.\r\nBut there ain't no point now.", "Dommage, j'voulais t'montrer c'que ça fait. Mais là, ça sert plus à rien.");
                s = s.Replace("...Why not?", "...Pourquoi donc ?");
                s = s.Replace("If all yer gonna do is look up at the sky, I ain't gonna be\r\nable to look down on ya– Wiv ya, sorry.", "Si tu fais qu'regarder les nuages, j'pourrai pas t'prendre de haut... Enfin, contempler avec toi, pardon.");
                s = s.Replace("I mean, I don't look down on ya or nuffin'.\r\nIf ya don't wanna do it, it's your choice.", "J'veux dire, j'te méprise pas ni rien. Si tu veux pas monter, c'est ton choix.");
                s = s.Replace("I didn't think I'd ever go up in a balloon, to be honest.\r\nNot in my whole life.", "Je ne pensais pas monter un jour dans une montgolfière, à vrai dire. Jamais de ma vie.");
                s = s.Replace("But now I'm starting to think I might like to...", "Mais maintenant, je commence à me dire que ça me plairait bien...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_00_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("About this, Gina...", "À ce propos, Gina...");
                s = s.Replace("...Yeah, I'm...still learnin' me letters at the moment.", "...Ouais, j'suis... encore en train d'apprendre mes lettres pour l'moment.");
                s = s.Replace("I only know ‘A’ to ‘E’!\r\nSo if it ain't too much bleedin' trouble?!", "J'connais qu'de « A » à « E » ! Alors si tu pouvais éviter d'm'embêter avec ça ?!");
                s = s.Replace("Ah, actually, Gina, it's the back of the card that's\r\nimportant.", "Ah, en fait, Gina, c'est le verso de la carte qui compte.");
                s = s.Replace("Eh? 'Ow come?", "Hein ? Pourquoi donc ?");
                s = s.Replace("There's just a dirty old smudge on the back, that's all.", "Y'a juste une vieille tache crasseuse au dos, c'est tout.");
                s = s.Replace("It turns out that this is very high-quality French machine\r\noil.", "Il s'avère qu'il s'agit d'huile pour machine française de première qualité.");
                s = s.Replace("It has a very particular scent, apparently.", "Elle possède une odeur très particulière, paraît-il.");
                s = s.Replace("You don't say!\r\nLet's 'ave a whiff then...", "Pas croyable ! Fais voir que j'renifle un peu...");
                s = s.Replace("You sure?\r\nI don't smell nuffin'.", "T'es sûr ? J'sens que dalle.");
                s = s.Replace("No no, we didn't mean that YOU should smell it!", "Non non, nous ne voulions pas dire que TU devais la renifler !");
                s = s.Replace("Oh, right! Ya mean Toby!", "Ah, pigé ! Tu parles de Toby !");
                s = s.Replace("Woof!", "Wouf !");
                s = s.Replace("His sense of smell is so good, he can track people over\r\nthe oceans, can't he?", "Son flair est si prodigieux qu'il pourrait pister quelqu'un par-delà les océans, n'est-ce pas ?");
                s = s.Replace("Professor Harebrayne informs us that this oil is unique to\r\nMr Drebber's workshop.", "Le professeur Lonron nous a appris que cette huile est spécifique à l'atelier de M. Drebber.");
                s = s.Replace("*Sniff sniff sniff*\r\n*Sniff sniff sniff*", "*Renifle renifle renifle*\r\n*Renifle renifle renifle*");
                s = s.Replace("(I think he's picked up a scent...)", "(Je crois qu'il a repéré la piste...)");
                s = s.Replace("So ya mean, if 'e follows the scent o' this oil...", "Tu veux dire que s'il suit l'odeur de c'te huile...");
                s = s.Replace("...Toby could lead us to that dodgy cove's workshop?!", "...Toby pourrait nous guider jusqu'à l'atelier de ce drôle de zèbre ?!");
                s = s.Replace("That's right! That's exactly what we were hoping.", "C'est exact ! C'est exactement ce que nous espérions.");
                s = s.Replace("Alright then, we'll give it a go!\r\nI'll just borrow that.", "Marché conclu, on va tenter l'coup ! J'te pique ça en attendant.");
                s = s.Replace("Wha...? Wait, when did you...?\r\n(Once a pickpocket...)", "Quoi... ? Attends, quand as-tu... ? (Chassez le naturel...)");
                s = s.Replace("If I can lead everyone to that Drebber's workshop...", "Si j'arrive à mener tout l'monde à l'atelier de ce Drebber...");
                s = s.Replace("...I'll be the boss's boss before next week!", "...j'deviendrai la cheffe du patron avant la semaine prochaine !");
                s = s.Replace("Oh yes, Gina!\r\nI'm sure you'll be promoted!", "Oh oui, Gina ! Tu auras ta promotion à coup sûr !");
                s = s.Replace("(Poor, poor Gregson...)", "(Pauvre, pauvre inspecteur Gregson...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_00_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("There were a bunch of reporters at the trial today, eh?", "Y'avait un paquet d'journalistes au procès aujourd'hui, dis donc !");
                s = s.Replace("One of 'em got a sketch of me in the witness stand!", "Y'en a un qui a fait un portrait de moi à la barre !");
                s = s.Replace("Oh really?", "Ah bon ?");
                s = s.Replace("Yeah, I looked pretty good, right?\r\nAn' that testimony o' mine was spot on!", "Ouais, j'ai une sacrée dégaine, pas vrai ? Et mon témoignage a fait mouche !");
                s = s.Replace("I'm not sure that ‘spot on’ is quite the right description...", "Je ne jurerais pas que « faire mouche » soit le terme approprié...");
                s = s.Replace("And look, it was in the special edition an' all!\r\nI bought a copy.", "Et mate un peu, c'était dans l'édition spéciale en plus ! J'en ai acheté un exemplaire.");
                s = s.Replace("Oh, that's a lovely picture of you, Gina!", "Oh, quel charmant dessin de toi, Gina !");
                s = s.Replace("But I thought you couldn't read?", "Mais je croyais que tu ne savais pas lire ?");
                s = s.Replace("Wot d'ya take me for?\r\nI'm crammin' every day!", "Tu m'prends pour qui ? J'bûche tous les jours, moi !");
                s = s.Replace("Ah, I see...", "Ah, je vois...");
                s = s.Replace("I started at ‘A’...an' I've already got all the way to ‘E’!", "J'ai commencé au « A »... et j'suis déjà rendue jusqu'au « E » !");
                s = s.Replace("...It could be a long journey for you.", "...La route risque d'être encore bien longue.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Um, Gina...", "Euh, Gina...");
                s = s.Replace("...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus...");
                s = s.Replace("Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez.");
                s = s.Replace("Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?");
                s = s.Replace("I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là.");
                s = s.Replace("(Ah yes, Toby...)", "(Ah oui, Toby...)");
                s = s.Replace("Woof!", "Wouf !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Um, Gina...", "Euh, Gina...");
                s = s.Replace("...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus...");
                s = s.Replace("Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez.");
                s = s.Replace("Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?");
                s = s.Replace("I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là.");
                s = s.Replace("(Ah yes, Toby...)", "(Ah oui, Toby...)");
                s = s.Replace("Woof!", "Wouf !");
                s = s.Replace("The machine that exploded must be at the top of those\r\nstairs, I presume?", "La machine qui a explosé se trouve en haut de ces marches, je suppose ?");
                s = s.Replace("I haven't actually seen it yet, so if you don't mind...", "Je ne l'ai pas encore vue de mes yeux, alors si cela ne vous dérange pas...");
                s = s.Replace("Sorry, ya can't go up there, Sooze.", "Désolée, pas l'droit d'monter là-haut, Susato.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("It's like I told 'Oddo yesterday. Even I ain't allowed near\r\nthat wreck.", "C'est comme j'disais à Naruhodo hier. Même moi j'ai pas l'droit d'm'approcher d'c'te épave.");
                s = s.Replace("Wot's it called again? The reason we ain't s'posed to touch\r\nit... The Special...", "C'est quoi l'nom déjà ? Le truc qui nous interdit d'y toucher... La Dérogation...");
                s = s.Replace("The Special Dispensation for Scientific Equipment Act?\r\nIs that what you were thinking of?", "La Loi de dérogation spéciale pour le matériel scientifique ? Est-ce à cela que tu pensais ?");
                s = s.Replace("That's the one! That's why only them lot are allowed to\r\ninvestigate it.", "C'est ça tout craché ! Voilà pourquoi y'a qu'eux qui ont l'droit d'fouiller.");
                s = s.Replace("Wot are they called again? The Friend Sick somefin'...", "Comment ils s'appellent déjà ? La Police Scien-machin...");
                s = s.Replace("The Forensic Investigation Team?\r\nIs that what you were thinking of?", "L'Équipe de police scientifique ? C'est ce à quoi tu pensais ?");
                s = s.Replace("That's the one, yeah!", "C'est ça, ouais !");
                s = s.Replace("But isn't it the case that the special dispensation has been\r\nlifted?", "Mais la dérogation spéciale n'a-t-elle point été levée ?");
                s = s.Replace("I think so... I don't really get it, to be truthful wiv ya.", "J'crois bien... J'y pige pas grand-chose pour être franche.");
                s = s.Replace("Yer still s'posed to get permission from some bigwig or\r\nother as far as I know.", "Faut toujours l'accord d'un gros bonnet ou j'sais pas quoi d'après c'qu'on m'a dit.");
                s = s.Replace("Wot was 'is name again? Um, Lord Strange-somefin'...", "C'était quoi son blase déjà ? Euh, Lord Bizarre-machin...");
                s = s.Replace("I'm not sure that's quite right, Gina.\r\nI think you mean Lord Stronghart perhaps?", "Je ne crois pas que ce soit tout à fait exact, Gina. Tu penses sans doute à Lord Harry Caine ?");
                s = s.Replace("That's the one, yeah!\r\nApparently, 'e's always watchin' the time or somefin'!", "C'est lui, ouais ! Y paraît qu'il regarde toujours sa montre ou un truc du genre !");
                s = s.Replace("(So without Lord Stronghart's express permission, we can't\r\ninvestigate on the stage...)", "(Sans la permission expresse de Lord Harry Caine, impossible d'enquêter sur la scène...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Actually, we've just recently been to see Lord Stronghart!", "À vrai dire, nous venons tout juste de rendre visite à Lord Harry Caine !");
                s = s.Replace("Eh?! You wot?\r\nYou've met 'im?!", "Hein ?! Vous quoi ? Vous l'avez rencontré ?!");
                s = s.Replace("Last time the boss was called to go an' see 'im...\r\n...'e waited for three hours at the cove's office an' came\r\nback snivellin'.", "La dernière fois que l'patron a été convoqué chez lui... y a poireauté trois heures dans son antichambre et il est r'venu en chouinant.");
                s = s.Replace("(Tragic...)", "(Tragique...)");
                s = s.Replace("Well, Lord Stronghart has given us permission to examine\r\nthe scene, as long as we touch nothing.", "Eh bien, Lord Harry Caine nous a octroyé la permission d'inspecter les lieux, tant que nous ne touchons à rien.");
                s = s.Replace("Oh yeah?", "Ah ouais ?");
                s = s.Replace("Honestly.", "Très sincèrement.");
                s = s.Replace("Alright then, go ahead.\r\nBut if it turns out yer lyin'...", "Bon, alors allez-y. Mais si jamais vous m'avez raconté des bobards...");
                s = s.Replace("...it'll be the boss who gets it. He'll never eat another chip\r\nagain in 'is life.", "...c'est l'patron qui va trinquer. Il r'mangera plus jamais une frite de sa vie.");
                s = s.Replace("So...yer still sayin' all this is above board, are ya?", "Alors... vous m'garantissez toujours que tout est réglo ?");
                s = s.Replace("I'm, I'm sure everything will be fine.", "Je... je suis certaine que tout se passera au mieux.");
                s = s.Replace("(That really would be tragic.)", "(Ce serait une véritable tragédie pour lui.)");
                s = s.Replace("Alright then, them's the stairs.\r\nOff ya go.", "Très bien, voilà l'escalier. En route.");
                s = s.Replace("Oh, thank you, Gina!", "Oh, merci infiniment, Gina !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Um, Gina...", "Euh, Gina...");
                s = s.Replace("...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus...");
                s = s.Replace("Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez.");
                s = s.Replace("Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?");
                s = s.Replace("I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là.");
                s = s.Replace("(Ah yes, Toby...)", "(Ah oui, Toby...)");
                s = s.Replace("Woof!", "Wouf !");
                s = s.Replace("Apparently we can't look around on the stage now\r\nbecause the Forensic Investigation Team are at work.", "Il semblerait qu'on ne puisse pas inspecter l'estrade maintenant car l'Équipe de police scientifique y travaille.");
                s = s.Replace("Can't you do anything, Gina?\r\nIn your capacity as Inspector Lestrade?", "Ne pourrais-tu rien faire, Gina ? En ta qualité d'inspectrice Lestrade ?");
                s = s.Replace("Look, I'd like to 'elp you out.\r\nBut I'm just a trainee, ain't I?\r\nAin't nuffin' I can do.", "Écoute, j'aimerais bien vous aider. Mais j'suis qu'une apprentie, pas vrai ? J'peux rien faire.");
                s = s.Replace("(When it suits you, yes...)", "(Quand ça t'arrange, oui...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("It was great, weren't it? I 'ad a right laugh.\r\nIt was a new one on me, that.", "C'était bath, non ? J'me suis bien marrée. C'était une première pour moi.");
                s = s.Replace("Ya know, bein' in court an' not spendin' the whole time\r\nworryin' I'm about to be found out!", "Tu vois, être au tribunal sans trembler tout l'temps d'me faire pincer !");
                s = s.Replace("...You did keep an awful lot of secrets in all your previous\r\ncourt appearances, didn't you?", "...Il est vrai que vous dissimuliez un nombre incalculable de secrets lors de vos précédentes comparutions.");
                s = s.Replace("Yeah, and 'Oddo's made things 'ard for me every single\r\ntime an' all!", "Ouais, et Naruhodo m'a mené la vie dure à chaque fois en plus !");
                s = s.Replace("...Just doing my job, Gina.", "...Je ne faisais que mon travail, Gina.");
                s = s.Replace("But watchin' someone else get it in the neck is a lot o' fun,\r\nactually.", "Mais voir quelqu'un d'autre se faire passer à la casserole, c'est drôlement distrayant, en fait.");
                s = s.Replace("It was amazin' when you showed that dodgy professor's\r\ndodgy experiment was a total fix!", "C'était dément quand t'as prouvé que l'expérience bidon de ce prof suspect était une arnaque totale !");
                s = s.Replace("...The ‘dodgy’ professor as you put it, Gina, is\r\nMr Naruhodo's client.", "...Le professeur « suspect », comme tu l'appelles, Gina, n'est autre que le client de M. Naruhodo.");
                s = s.Replace("Yes. I'm starting to wish he wasn't, though...", "Oui. Je commence presque à regretter d'avoir accepté sa cause...");
                s = s.Replace("It's the boss I feel sorry for. Sent off to do the impossible.", "C'est pour l'patron qu'j'ai d'la peine. Envoyé accomplir l'impossible.");
                s = s.Replace("What do you mean?", "Que veux-tu dire par là ?");
                s = s.Replace("'E's supposed to arrest that other cove, ain't 'e?\r\nAn' in time for tomorrow an' all!\r\nYa know, the dodgy engineer. Wot's 'is name again?", "Y doit cravater l'autre zèbre, non ? Et avant demain matin qui plus est ! Tu sais, l'ingénieur véreux. C'est quoi son nom déjà ?");
                s = s.Replace("Mr Drebber, you mean?\r\nEnoch Drebber.", "M. Drebber, tu veux dire ? Enoch Drebber.");
                s = s.Replace("That's the one, yeah!", "C'est lui, ouais !");
                s = s.Replace("(So the police are looking for this mysterious man with\r\nthe black monocle... I guessed they would be.)", "(La police traque donc cet homme mystérieux au monocle noir... Je m'en doutais un peu.)");
                s = s.Replace("It's puttin' too much on the boss if you ask me.\r\n'E says it's givin' 'im gut ache.", "On en d'mande trop au patron si tu veux mon avis. Y dit qu'ça lui flanque des aigreurs d'estomac.");
                s = s.Replace("...Oh dear. But I do wonder if that isn't actually from all\r\nthe fried food.", "...Oh là là. Mais je me demande si cela ne provient pas plutôt de toutes ces fritures.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("So Scotland Yard are trying to track down Mr Enoch\r\nDrebber. I wonder if they've had any luck...", "Scotland Yard est donc aux trousses de M. Enoch Drebber. Je me demande si leurs recherches avancent...");
                s = s.Replace("'E's really funny lookin'. Got two eyes wot don't match.\r\nStole a glimpse of a picture of 'im earlier.", "Y'a une drôle de trombine. Deux yeux pas pareils. J'ai jeté un œil à sa photo tout à l'heure.");
                s = s.Replace("I mean, I didn't actually pinch it or nuffin'.\r\nThe old devil's got it.", "J'veux dire, j'l'ai pas chouravée hein. C'est l'vieux démon qui l'a.");
                s = s.Replace("Sorry? Who?", "Pardon ? Qui donc ?");
                s = s.Replace("Ya know. That scowlin' Reaper wot's always gluggin'\r\ndown glasses o' that blood-red plonk.", "Tu sais bien. Ce Faucheur renfrogné qui s'enfile des verres de c'te piquette rouge sang à longueur de journée.");
                s = s.Replace("Ah, Lord van Zieks.", "Ah, Lord Van Peers.");
                s = s.Replace("'E's always 'ad it in for me, that cove.\r\nDunno wot 'e's always scowlin' about, mind.\r\nProb'ly would've been a pretty good boss, as it goes.", "Y m'a toujours eue dans l'collimateur, c'type-là. J'sais pas pourquoi y tire toujours c'te tête. Y f'rait sans doute un bon patron pourtant.");
                s = s.Replace("(She'd rather be the Reaper's apprentice than a detective's\r\ntrainee?)", "(Elle préférerait être l'apprentie du Faucheur plutôt que celle d'un inspecteur ?)");
                s = s.Replace("The way I see it...\r\n...if the choice is between a chip-guzzling detective and a\r\nchalice-glugging demigod...", "À mon humble avis... si le dilemme se résume à choisir entre un inspecteur gobeur de frites et un demi-dieu buveur de calices...");
                s = s.Replace("...you're equally badly off with both.", "...l'un ne vaut guère mieux que l'autre.");
                s = s.Replace("...I s'pose yer right. I 'adn't thought of it like that.", "...J'suppose qu't'as raison. J'avais pas vu les choses comme ça.");
                s = s.Replace("(Glad we've put that one to bed...)", "(Ravi qu'on ait classé cette idée saugrenue...)");
                s = s.Replace("Anyway, the point is, everyone at the Yard's dead set on\r\nfindin' the fishy engineer...", "Bref, toujours est-il que tout le monde au Yard est sur les dents pour dégoter l'ingénieur louche...");
                s = s.Replace("...but there don't seem to be no clues to go on.\r\nSo they're stuck.", "...mais y'a aucun indice sous la main. Alors ils rament.");
                s = s.Replace("(There's nothing that can lead us to Drebber at all...?)", "(Rien qui puisse nous mettre sur la piste de Drebber...?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr050_01_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Where did you find that little mutt then, Gina?", "Où as-tu déniché ce petit bâtard, Gina ?");
                s = s.Replace("Oi! Don't be so flamin' rude, 'Oddo!", "Hé ! Sois pas si malpoli, Naruhodo !");
                s = s.Replace("...Slight overreaction, don't you think?", "...Une réaction un peu disproportionnée, non ?");
                s = s.Replace("'E ain't no mutt, alright?\r\nToby's... 'ow did they put it...?", "C'est pas un bâtard, pigé ? Toby, c'est... comment ils ont dit... ?");
                s = s.Replace("...Oh, yeah!\r\nA ‘bone-fide’ detective!", "...Ah ouais ! Un fin limier aux dents longues !");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("I've given 'im a proper title an' everyfin'.\r\nIt's Chief Inspector Toby to you!", "J'lui ai donné un vrai titre officiel et tout. C'est l'inspecteur principal Toby pour toi !");
                s = s.Replace("(More senior than Inspector Gregson, is he?)", "(Plus gradé que l'inspecteur Gregson lui-même ?)");
                s = s.Replace("Ooh, so he's a police dog, is he?", "Ooh, c'est donc un chien policier ?");
                s = s.Replace("The police recruit dogs now?", "La police enrôle des chiens à présent ?");
                s = s.Replace("I've heard that they're already being used officially in\r\nGermany as part of their city policing.", "J'ai entendu dire qu'on les utilise déjà officiellement en Allemagne pour les patrouilles urbaines.");
                s = s.Replace("They're used for chasing criminals and suchlike!\r\nThey have a wonderful sense of smell, after all.", "On s'en sert pour pourchasser les criminels et autres ! Ils ont un odorat exceptionnel, après tout.");
                s = s.Replace("I have a fairly good sense of smell myself, as it happens.", "J'ai moi-même un assez bon odorat, pour tout dire.");
                s = s.Replace("I can tell undergarments that have been freshly\r\nlaundered from undergarments that...haven't.", "Je peux distinguer les sous-vêtements fraîchement lavés de ceux qui... ne le sont pas.");
                s = s.Replace("Haaah... That's nuffin' compared to this little fella, 'Oddo.", "Pfff... C'est de la roupie de sansonnet comparé à mon p'tit gars, Naruhodo.");
                s = s.Replace("Oh really?", "Ah oui ?");
                s = s.Replace("Accordin' to wot the boss said...\r\n...once Toby 'ere's got a good whiff of yer drawers...", "D'après c'que l'patron m'a raconté... une fois qu'Toby a bien reniflé ton caleçon...");
                s = s.Replace("...'e could chase that scent to the other side o' the world!", "...y pourrait pister c't'odeur jusqu'au bout du monde !");
                s = s.Replace("WHAT?! To, to the other side of the world?\r\nYou mean...\r\n...he can swim?!", "QUOI ?! Jusqu'au... jusqu'au bout du monde ? Tu veux dire qu'il sait nager ?!");
                s = s.Replace("Mr Naruhodo...\r\n...I think you may have missed the point...by rather a\r\nwide margin.", "Monsieur Naruhodo... je crois que vous passez totalement à côté du sujet.");
                s = s.Replace("I, I just can't believe this little dog has such an incredible\r\nskill...", "J-Je n'arrive pas à croire qu'un si petit chien possède un don aussi extraordinaire...");
                s = s.Replace("I'm tellin' ya, 'Oddo, there's gonna be more an' more dogs\r\ndoin' their bit for the police in future.", "J'te l'dis, Naruhodo, y'aura d'plus en plus d'chiens dans la police à l'avenir.");
                s = s.Replace("Yes! I agree!", "Oui ! J'en suis convaincue !");
                s = s.Replace("Right! One o' these days, they'll be barkin' orders at us lot,\r\nnot the other way round!", "Exact ! Un d'ces quatre, c'est eux qui vont nous aboyer des ordres et pas l'contraire !");
                s = s.Replace("Oh dear... Sorry, Gina, I don't think I agree with your\r\nvision quite that much...", "Oh là là... Désolé Gina, mais je ne partage pas tout à fait cette vision du futur...");
                s = s.Replace("Well anyway. Wotever ya think about that, Toby 'ere is\r\nBritain's first police dog!", "Bref. Quoi qu't'en penses, Toby ici présent est le premier chien policier de Grande-Bretagne !");
                s = s.Replace("I found 'im down the East End the other day.\r\nSomeone 'ad just chucked 'im out on the street.", "J'l'ai trouvé dans l'East End l'autre jour. Quelqu'un l'avait lâchement balancé sur l'trottoir.");
                s = s.Replace("(There you go. I knew she'd lifted him from somewhere...)", "(Et voilà. Je savais bien qu'elle l'avait dégoté quelque part...)");
                s = s.Replace("Oh Gina, you're such a kind-hearted soul, aren't you?\r\nTo children and to animals!", "Oh Gina, tu as le cœur sur la main, n'est-ce pas ? Envers les enfants comme envers les bêtes !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr060_00_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Lord Stronghart said that the assault last night was some\r\nsort of revenge attack?", "Lord Harry Caine a affirmé que l'assaut d'hier soir était une sorte de vengeance ?");
                s = s.Replace("True. Carried out by henchmen of Odie Asman's criminal\r\norganisation.", "Exact. Mené par les séides de l'organisation criminelle d'Odoril Asman.");
                s = s.Replace("The investigation meant their arrests were imminent.\r\nPresumably some hoped to kill me before that happened.", "L'enquête touchait au but, leurs arrestations étaient imminentes. Certains espéraient sans doute m'abattre avant.");
                s = s.Replace("Odie Asman...", "Odoril Asman...");
                s = s.Replace("He's always masqueraded as one of London's most\r\npowerful financiers. A global investor.", "Il s'est toujours drapé dans le costume d'un puissant financier londonien. Un investisseur d'envergure internationale.");
                s = s.Replace("But his enormous wealth came to him by underhand\r\nmeans, via his criminal activities.", "Mais son immense fortune provenait d'activités frauduleuses et crapuleuses.");
                s = s.Replace("And he used that money to buy himself a verdict of not\r\nguilty when he found himself in court, didn't he?", "Et il s'est servi de cet argent pour s'acheter un verdict de non-culpabilité au tribunal, n'est-ce pas ?");
                s = s.Replace("Being prosecuted by you, Mr Reaper.", "Face à votre réquisitoire, monsieur le Faucheur.");
                s = s.Replace("But the man got his comeuppance in the end.", "Mais cet individu a fini par recevoir son juste châtiment.");
                s = s.Replace("Yesterday in fact, in extraordinary circumstances.\r\nIt was a most unusual cause of death.", "Hier même, dans des circonstances extraordinaires. Une cause de décès pour le moins singulière.");
                s = s.Replace("I, I know about that! It was super-high-voltage\r\ninstantaneous kinesis gone wrong!", "J-Je suis au courant ! La téléportation instantanée à très haute tension qui a mal tourné !");
                s = s.Replace("Mr Asman died when the demonstration on the public\r\nexperimentation stage ended in an enormous explosion.", "M. Asman a péri lors de l'explosion qui a ravagé la scène d'expérimentation publique.");
                s = s.Replace("...Correct.", "...C'est exact.");
                s = s.Replace("And you think I have some kind of divine ability to cause\r\nan accident like that to happen, do you?", "Et vous vous imaginez que je possède un quelconque pouvoir divin capable de provoquer un tel accident ?");
                s = s.Replace("Well...no, that does seem a little far-fetched.", "Eh bien... non, cela semble passablement invraisemblable.");
                s = s.Replace("(If this man really is the fabled Reaper, then he has to be\r\ninnocent of this particular death, at least.)", "(Si cet homme est bien le légendaire Faucheur, il est en tout cas innocent de cette mort-là.)");
                s = s.Replace("It's strange how this has worked out, isn't it, Runo?", "C'est une drôle d'ironie du sort, n'est-ce pas, Ryuno ?");
                s = s.Replace("I mean, what with you taking on the professor's defence\r\nfor the trial tomorrow.", "Je veux dire, le fait que tu prennes la défense du professeur pour le procès de demain.");
                s = s.Replace("What?!\r\nYou're going to be defending him?", "Quoi ?!\r\nVous allez assurer sa défense ?");
                s = s.Replace("Oh, yes, that's right.\r\nThough I barely know the man's name yet, to be honest.", "Oh, oui, tout à fait. Bien que je connaisse à peine son nom, pour être honnête.");
                s = s.Replace("Albert.", "Albert.");
                s = s.Replace("Albert Harebrayne.", "Samba Lonron.");
                s = s.Replace("That's right. ...Do you know him, by any chance?", "C'est bien cela. Le connaissez-vous par hasard ?");
                s = s.Replace("Of course.", "Naturellement.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr060_00_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("He's a contemporary of mine.\r\nWe were at university together.", "C'est un condisciple. Nous étions ensemble à l'université.");
                s = s.Replace("Your...", "Vos...");
                s = s.Replace("WHAT?!", "QUOI ?!");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr060_00_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("I'd understood that Professor Harebrayne was from\r\nGermany, though.", "J'avais pourtant cru comprendre que le professeur Lonron venait d'Allemagne.");
                s = s.Replace("Harebrayne's from a respectable British family.", "Lonron est issu d'une honorable famille britannique.");
                s = s.Replace("After graduating from the University of London, he\r\nmoved to Germany to carry out research, that's all.", "Après son diplôme à l'université de Londres, il est parti poursuivre ses recherches en Allemagne, voilà tout.");
                s = s.Replace("So you were students together...", "Vous étiez donc étudiants à la même époque...");
                s = s.Replace("I was in the faculty of law, of course. And he in science.\r\nSo our paths rarely crossed.", "J'étais à la faculté de droit, naturellement. Et lui en sciences. Nos chemins se croisaient rarement.");
                s = s.Replace("But curiously, we got along.\r\nThough I've not met him since my university days.", "Mais curieusement, nous nous entendions fort bien. Quoique je ne l'aie plus revu depuis cette époque.");
                s = s.Replace("I certainly didn't expect our next encounter to take this\r\nform.", "Je ne m'attendais certes point à ce que nos retrouvailles prennent une telle tournure.");
                s = s.Replace("And with you of all people representing him.", "Et avec vous, par-dessus le marché, pour plaider sa cause.");
                s = s.Replace("(Ugh... Only if I make it out of this office alive...)", "(Glps... Si je sors vivant de ce bureau, déjà...)");
                s = s.Replace("He's actually been charged with murder, it seems.", "Il est formellement inculpé de meurtre, semble-t-il.");
                s = s.Replace("Yes, I know.\r\nBecause the prosecution...\r\n...will be handled by me.", "Oui, je ne le sais que trop. Car l'accusation... sera portée par moi-même.");
                s = s.Replace("By you?!\r\nBut...but you made it sound as if you and the professor\r\nhad been friends.", "Par vous ?!\r\nMais... vous laissiez entendre que vous étiez amis !");
                s = s.Replace("We are friends, it's true.", "Nous le sommes, en effet.");
                s = s.Replace("Then why would you do this?", "Alors pourquoi vous charger de l'accusation ?");
                s = s.Replace("If the Reaper is the prosecutor, there's nothing anyone can\r\ndo to save him! He's doomed!", "Si le Faucheur mène l'accusation, personne ne pourra le sauver ! Il est condamné d'avance !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr060_00_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("(What's Lord van Zieks thinking...?)", "(À quoi peut bien penser Lord Van Peers...?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr060_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("(What's Lord van Zieks thinking...?)", "(À quoi peut bien penser Lord Van Peers...?)");
                return s;
            };

        }
    }
}
