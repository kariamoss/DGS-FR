using System;
using System.IO;
using System.Text;

class MakeAct6Part2A {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart2_A() {");

        Action<string, string[,]> add = (key, reps) => {
            sb.AppendLine("            entryTranslators[@\"" + key + "\"] = (en) => {");
            sb.AppendLine("                string s = en;");
            for (int i = 0; i < reps.GetLength(0); i++) {
                string enStr = reps[i, 0].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
                string frStr = reps[i, 1].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
                sb.AppendLine("                s = s.Replace(\"" + enStr + "\", \"" + frStr + "\");");
            }
            sb.AppendLine("                return s;");
            sb.AppendLine("            };");
            sb.AppendLine();
        };

        // [46] KEY:BB\script\output\_sce02_chr050_00_eng#12
        add(@"BB\script\output\_sce02_chr050_00_eng#12", new string[,] {
            { "Gina, have a look at this photograph...", "Gina, regarde cette photographie..." },
            { "It's amazin' lookin' down on everyfin' from up there.\r\nI love 'igh places, me.", "C'est dément d'tout voir d'en haut comme ça. J'adore les endroits perchés, moi." },
            { "Really? If I'm honest, I can't stand looking down at the\r\nground when I'm high up. I always have to look up.", "Vraiment ? Pour être franc, j'ai le vertige dès que je regarde en bas. Je dois toujours lever les yeux vers le ciel." },
            { "Shame, I wanted to show ya wot it's like.\r\nBut there ain't no point now.", "Dommage, j'voulais t'montrer c'que ça fait. Mais là, ça sert plus à rien." },
            { "...Why not?", "...Pourquoi donc ?" },
            { "If all yer gonna do is look up at the sky, I ain't gonna be\r\nable to look down on ya– Wiv ya, sorry.", "Si tu fais qu'regarder les nuages, j'pourrai pas t'prendre de haut... Enfin, contempler avec toi, pardon." },
            { "I mean, I don't look down on ya or nuffin'.\r\nIf ya don't wanna do it, it's your choice.", "J'veux dire, j'te méprise pas ni rien. Si tu veux pas monter, c'est ton choix." },
            { "I didn't think I'd ever go up in a balloon, to be honest.\r\nNot in my whole life.", "Je ne pensais pas monter un jour dans une montgolfière, à vrai dire. Jamais de ma vie." },
            { "But now I'm starting to think I might like to...", "Mais maintenant, je commence à me dire que ça me plairait bien..." }
        });

        // [47] KEY:BB\script\output\_sce02_chr050_00_eng#13
        add(@"BB\script\output\_sce02_chr050_00_eng#13", new string[,] {
            { "About this, Gina...", "À ce propos, Gina..." },
            { "...Yeah, I'm...still learnin' me letters at the moment.", "...Ouais, j'suis... encore en train d'apprendre mes lettres pour l'moment." },
            { "I only know ‘A’ to ‘E’!\r\nSo if it ain't too much bleedin' trouble?!", "J'connais qu'de « A » à « E » ! Alors si tu pouvais éviter d'm'embêter avec ça ?!" },
            { "Ah, actually, Gina, it's the back of the card that's\r\nimportant.", "Ah, en fait, Gina, c'est le verso de la carte qui compte." },
            { "Eh? 'Ow come?", "Hein ? Pourquoi donc ?" },
            { "There's just a dirty old smudge on the back, that's all.", "Y'a juste une vieille tache crasseuse au dos, c'est tout." },
            { "It turns out that this is very high-quality French machine\r\noil.", "Il s'avère qu'il s'agit d'huile pour machine française de première qualité." },
            { "It has a very particular scent, apparently.", "Elle possède une odeur très particulière, paraît-il." },
            { "You don't say!\r\nLet's 'ave a whiff then...", "Pas croyable ! Fais voir que j'renifle un peu..." },
            { "You sure?\r\nI don't smell nuffin'.", "T'es sûr ? J'sens que dalle." },
            { "No no, we didn't mean that YOU should smell it!", "Non non, nous ne voulions pas dire que TU devais la renifler !" },
            { "Oh, right! Ya mean Toby!", "Ah, pigé ! Tu parles de Toby !" },
            { "Woof!", "Wouf !" },
            { "His sense of smell is so good, he can track people over\r\nthe oceans, can't he?", "Son flair est si prodigieux qu'il pourrait pister quelqu'un par-delà les océans, n'est-ce pas ?" },
            { "Professor Harebrayne informs us that this oil is unique to\r\nMr Drebber's workshop.", "Le professeur Lonron nous a appris que cette huile est spécifique à l'atelier de M. Drebber." },
            { "*Sniff sniff sniff*\r\n*Sniff sniff sniff*", "*Renifle renifle renifle*\r\n*Renifle renifle renifle*" },
            { "(I think he's picked up a scent...)", "(Je crois qu'il a repéré la piste...)" },
            { "So ya mean, if 'e follows the scent o' this oil...", "Tu veux dire que s'il suit l'odeur de c'te huile..." },
            { "...Toby could lead us to that dodgy cove's workshop?!", "...Toby pourrait nous guider jusqu'à l'atelier de ce drôle de zèbre ?!" },
            { "That's right! That's exactly what we were hoping.", "C'est exact ! C'est exactement ce que nous espérions." },
            { "Alright then, we'll give it a go!\r\nI'll just borrow that.", "Marché conclu, on va tenter l'coup ! J'te pique ça en attendant." },
            { "Wha...? Wait, when did you...?\r\n(Once a pickpocket...)", "Quoi... ? Attends, quand as-tu... ? (Chassez le naturel...)" },
            { "If I can lead everyone to that Drebber's workshop...", "Si j'arrive à mener tout l'monde à l'atelier de ce Drebber..." },
            { "...I'll be the boss's boss before next week!", "...j'deviendrai la cheffe du patron avant la semaine prochaine !" },
            { "Oh yes, Gina!\r\nI'm sure you'll be promoted!", "Oh oui, Gina ! Tu auras ta promotion à coup sûr !" },
            { "(Poor, poor Gregson...)", "(Pauvre, pauvre inspecteur Gregson...)" }
        });

        // [48] KEY:BB\script\output\_sce02_chr050_00_eng#14
        add(@"BB\script\output\_sce02_chr050_00_eng#14", new string[,] {
            { "There were a bunch of reporters at the trial today, eh?", "Y'avait un paquet d'journalistes au procès aujourd'hui, dis donc !" },
            { "One of 'em got a sketch of me in the witness stand!", "Y'en a un qui a fait un portrait de moi à la barre !" },
            { "Oh really?", "Ah bon ?" },
            { "Yeah, I looked pretty good, right?\r\nAn' that testimony o' mine was spot on!", "Ouais, j'ai une sacrée dégaine, pas vrai ? Et mon témoignage a fait mouche !" },
            { "I'm not sure that ‘spot on’ is quite the right description...", "Je ne jurerais pas que « faire mouche » soit le terme approprié..." },
            { "And look, it was in the special edition an' all!\r\nI bought a copy.", "Et mate un peu, c'était dans l'édition spéciale en plus ! J'en ai acheté un exemplaire." },
            { "Oh, that's a lovely picture of you, Gina!", "Oh, quel charmant dessin de toi, Gina !" },
            { "But I thought you couldn't read?", "Mais je croyais que tu ne savais pas lire ?" },
            { "Wot d'ya take me for?\r\nI'm crammin' every day!", "Tu m'prends pour qui ? J'bûche tous les jours, moi !" },
            { "Ah, I see...", "Ah, je vois..." },
            { "I started at ‘A’...an' I've already got all the way to ‘E’!", "J'ai commencé au « A »... et j'suis déjà rendue jusqu'au « E » !" },
            { "...It could be a long journey for you.", "...La route risque d'être encore bien longue." }
        });

        // [49] KEY:BB\script\output\_sce02_chr050_01_eng#1
        add(@"BB\script\output\_sce02_chr050_01_eng#1", new string[,] {
            { "Um, Gina...", "Euh, Gina..." },
            { "...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus..." },
            { "Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez." },
            { "Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?" },
            { "I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là." },
            { "(Ah yes, Toby...)", "(Ah oui, Toby...)" },
            { "Woof!", "Wouf !" }
        });

        // [50] KEY:BB\script\output\_sce02_chr050_01_eng#2
        add(@"BB\script\output\_sce02_chr050_01_eng#2", new string[,] {
            { "Um, Gina...", "Euh, Gina..." },
            { "...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus..." },
            { "Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez." },
            { "Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?" },
            { "I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là." },
            { "(Ah yes, Toby...)", "(Ah oui, Toby...)" },
            { "Woof!", "Wouf !" },
            { "The machine that exploded must be at the top of those\r\nstairs, I presume?", "La machine qui a explosé se trouve en haut de ces marches, je suppose ?" },
            { "I haven't actually seen it yet, so if you don't mind...", "Je ne l'ai pas encore vue de mes yeux, alors si cela ne vous dérange pas..." },
            { "Sorry, ya can't go up there, Sooze.", "Désolée, pas l'droit d'monter là-haut, Susato." },
            { "Oh!", "Oh !" },
            { "It's like I told 'Oddo yesterday. Even I ain't allowed near\r\nthat wreck.", "C'est comme j'disais à Naruhodo hier. Même moi j'ai pas l'droit d'm'approcher d'c'te épave." },
            { "Wot's it called again? The reason we ain't s'posed to touch\r\nit... The Special...", "C'est quoi l'nom déjà ? Le truc qui nous interdit d'y toucher... La Dérogation..." },
            { "The Special Dispensation for Scientific Equipment Act?\r\nIs that what you were thinking of?", "La Loi de dérogation spéciale pour le matériel scientifique ? Est-ce à cela que tu pensais ?" },
            { "That's the one! That's why only them lot are allowed to\r\ninvestigate it.", "C'est ça tout craché ! Voilà pourquoi y'a qu'eux qui ont l'droit d'fouiller." },
            { "Wot are they called again? The Friend Sick somefin'...", "Comment ils s'appellent déjà ? La Police Scien-machin..." },
            { "The Forensic Investigation Team?\r\nIs that what you were thinking of?", "L'Équipe de police scientifique ? C'est ce à quoi tu pensais ?" },
            { "That's the one, yeah!", "C'est ça, ouais !" },
            { "But isn't it the case that the special dispensation has been\r\nlifted?", "Mais la dérogation spéciale n'a-t-elle point été levée ?" },
            { "I think so... I don't really get it, to be truthful wiv ya.", "J'crois bien... J'y pige pas grand-chose pour être franche." },
            { "Yer still s'posed to get permission from some bigwig or\r\nother as far as I know.", "Faut toujours l'accord d'un gros bonnet ou j'sais pas quoi d'après c'qu'on m'a dit." },
            { "Wot was 'is name again? Um, Lord Strange-somefin'...", "C'était quoi son blase déjà ? Euh, Lord Bizarre-machin..." },
            { "I'm not sure that's quite right, Gina.\r\nI think you mean Lord Stronghart perhaps?", "Je ne crois pas que ce soit tout à fait exact, Gina. Tu penses sans doute à Lord Harry Caine ?" },
            { "That's the one, yeah!\r\nApparently, 'e's always watchin' the time or somefin'!", "C'est lui, ouais ! Y paraît qu'il regarde toujours sa montre ou un truc du genre !" },
            { "(So without Lord Stronghart's express permission, we can't\r\ninvestigate on the stage...)", "(Sans la permission expresse de Lord Harry Caine, impossible d'enquêter sur la scène...)" }
        });

        // [51] KEY:BB\script\output\_sce02_chr050_01_eng#3
        add(@"BB\script\output\_sce02_chr050_01_eng#3", new string[,] {
            { "Actually, we've just recently been to see Lord Stronghart!", "À vrai dire, nous venons tout juste de rendre visite à Lord Harry Caine !" },
            { "Eh?! You wot?\r\nYou've met 'im?!", "Hein ?! Vous quoi ? Vous l'avez rencontré ?!" },
            { "Last time the boss was called to go an' see 'im...\r\n...'e waited for three hours at the cove's office an' came\r\nback snivellin'.", "La dernière fois que l'patron a été convoqué chez lui... y a poireauté trois heures dans son antichambre et il est r'venu en chouinant." },
            { "(Tragic...)", "(Tragique...)" },
            { "Well, Lord Stronghart has given us permission to examine\r\nthe scene, as long as we touch nothing.", "Eh bien, Lord Harry Caine nous a octroyé la permission d'inspecter les lieux, tant que nous ne touchons à rien." },
            { "Oh yeah?", "Ah ouais ?" },
            { "Honestly.", "Très sincèrement." },
            { "Alright then, go ahead.\r\nBut if it turns out yer lyin'...", "Bon, alors allez-y. Mais si jamais vous m'avez raconté des bobards..." },
            { "...it'll be the boss who gets it. He'll never eat another chip\r\nagain in 'is life.", "...c'est l'patron qui va trinquer. Il r'mangera plus jamais une frite de sa vie." },
            { "So...yer still sayin' all this is above board, are ya?", "Alors... vous m'garantissez toujours que tout est réglo ?" },
            { "I'm, I'm sure everything will be fine.", "Je... je suis certaine que tout se passera au mieux." },
            { "(That really would be tragic.)", "(Ce serait une véritable tragédie pour lui.)" },
            { "Alright then, them's the stairs.\r\nOff ya go.", "Très bien, voilà l'escalier. En route." },
            { "Oh, thank you, Gina!", "Oh, merci infiniment, Gina !" }
        });

        // [52] KEY:BB\script\output\_sce02_chr050_01_eng#4
        add(@"BB\script\output\_sce02_chr050_01_eng#4", new string[,] {
            { "Um, Gina...", "Euh, Gina..." },
            { "...we were actually hoping that we could investigate the\r\nscene again...", "...nous espérions pouvoir examiner la scène une fois de plus..." },
            { "Yeah, alright. If it's around 'ere, ya can do wot ya like.", "Ouais, d'accord. Si c'est par ici, faites c'que vous voulez." },
            { "Oh! That's alright, is it?", "Oh ! C'est d'accord alors ?" },
            { "I'm gonna be playin' wiv me new friend 'ere.", "Moi j'vais jouer avec mon nouvel ami là." },
            { "(Ah yes, Toby...)", "(Ah oui, Toby...)" },
            { "Woof!", "Wouf !" },
            { "Apparently we can't look around on the stage now\r\nbecause the Forensic Investigation Team are at work.", "Il semblerait qu'on ne puisse pas inspecter l'estrade maintenant car l'Équipe de police scientifique y travaille." },
            { "Can't you do anything, Gina?\r\nIn your capacity as Inspector Lestrade?", "Ne pourrais-tu rien faire, Gina ? En ta qualité d'inspectrice Lestrade ?" },
            { "Look, I'd like to 'elp you out.\r\nBut I'm just a trainee, ain't I?\r\nAin't nuffin' I can do.", "Écoute, j'aimerais bien vous aider. Mais j'suis qu'une apprentie, pas vrai ? J'peux rien faire." },
            { "(When it suits you, yes...)", "(Quand ça t'arrange, oui...)" }
        });

        // [53] KEY:BB\script\output\_sce02_chr050_01_eng#5
        add(@"BB\script\output\_sce02_chr050_01_eng#5", new string[,] {
            { "It was great, weren't it? I 'ad a right laugh.\r\nIt was a new one on me, that.", "C'était bath, non ? J'me suis bien marrée. C'était une première pour moi." },
            { "Ya know, bein' in court an' not spendin' the whole time\r\nworryin' I'm about to be found out!", "Tu vois, être au tribunal sans trembler tout l'temps d'me faire pincer !" },
            { "...You did keep an awful lot of secrets in all your previous\r\ncourt appearances, didn't you?", "...Il est vrai que vous dissimuliez un nombre incalculable de secrets lors de vos précédentes comparutions." },
            { "Yeah, and 'Oddo's made things 'ard for me every single\r\ntime an' all!", "Ouais, et Naruhodo m'a mené la vie dure à chaque fois en plus !" },
            { "...Just doing my job, Gina.", "...Je ne faisais que mon travail, Gina." },
            { "But watchin' someone else get it in the neck is a lot o' fun,\r\nactually.", "Mais voir quelqu'un d'autre se faire passer à la casserole, c'est drôlement distrayant, en fait." },
            { "It was amazin' when you showed that dodgy professor's\r\ndodgy experiment was a total fix!", "C'était dément quand t'as prouvé que l'expérience bidon de ce prof suspect était une arnaque totale !" },
            { "...The ‘dodgy’ professor as you put it, Gina, is\r\nMr Naruhodo's client.", "...Le professeur « suspect », comme tu l'appelles, Gina, n'est autre que le client de M. Naruhodo." },
            { "Yes. I'm starting to wish he wasn't, though...", "Oui. Je commence presque à regretter d'avoir accepté sa cause..." },
            { "It's the boss I feel sorry for. Sent off to do the impossible.", "C'est pour l'patron qu'j'ai d'la peine. Envoyé accomplir l'impossible." },
            { "What do you mean?", "Que veux-tu dire par là ?" },
            { "'E's supposed to arrest that other cove, ain't 'e?\r\nAn' in time for tomorrow an' all!\r\nYa know, the dodgy engineer. Wot's 'is name again?", "Y doit cravater l'autre zèbre, non ? Et avant demain matin qui plus est ! Tu sais, l'ingénieur véreux. C'est quoi son nom déjà ?" },
            { "Mr Drebber, you mean?\r\nEnoch Drebber.", "M. Drebber, tu veux dire ? Enoch Drebber." },
            { "That's the one, yeah!", "C'est lui, ouais !" },
            { "(So the police are looking for this mysterious man with\r\nthe black monocle... I guessed they would be.)", "(La police traque donc cet homme mystérieux au monocle noir... Je m'en doutais un peu.)" },
            { "It's puttin' too much on the boss if you ask me.\r\n'E says it's givin' 'im gut ache.", "On en d'mande trop au patron si tu veux mon avis. Y dit qu'ça lui flanque des aigreurs d'estomac." },
            { "...Oh dear. But I do wonder if that isn't actually from all\r\nthe fried food.", "...Oh là là. Mais je me demande si cela ne provient pas plutôt de toutes ces fritures." }
        });

        // [54] KEY:BB\script\output\_sce02_chr050_01_eng#6
        add(@"BB\script\output\_sce02_chr050_01_eng#6", new string[,] {
            { "So Scotland Yard are trying to track down Mr Enoch\r\nDrebber. I wonder if they've had any luck...", "Scotland Yard est donc aux trousses de M. Enoch Drebber. Je me demande si leurs recherches avancent..." },
            { "'E's really funny lookin'. Got two eyes wot don't match.\r\nStole a glimpse of a picture of 'im earlier.", "Y'a une drôle de trombine. Deux yeux pas pareils. J'ai jeté un œil à sa photo tout à l'heure." },
            { "I mean, I didn't actually pinch it or nuffin'.\r\nThe old devil's got it.", "J'veux dire, j'l'ai pas chouravée hein. C'est l'vieux démon qui l'a." },
            { "Sorry? Who?", "Pardon ? Qui donc ?" },
            { "Ya know. That scowlin' Reaper wot's always gluggin'\r\ndown glasses o' that blood-red plonk.", "Tu sais bien. Ce Faucheur renfrogné qui s'enfile des verres de c'te piquette rouge sang à longueur de journée." },
            { "Ah, Lord van Zieks.", "Ah, Lord Van Peers." },
            { "'E's always 'ad it in for me, that cove.\r\nDunno wot 'e's always scowlin' about, mind.\r\nProb'ly would've been a pretty good boss, as it goes.", "Y m'a toujours eue dans l'collimateur, c'type-là. J'sais pas pourquoi y tire toujours c'te tête. Y f'rait sans doute un bon patron pourtant." },
            { "(She'd rather be the Reaper's apprentice than a detective's\r\ntrainee?)", "(Elle préférerait être l'apprentie du Faucheur plutôt que celle d'un inspecteur ?)" },
            { "The way I see it...\r\n...if the choice is between a chip-guzzling detective and a\r\nchalice-glugging demigod...", "À mon humble avis... si le dilemme se résume à choisir entre un inspecteur gobeur de frites et un demi-dieu buveur de calices..." },
            { "...you're equally badly off with both.", "...l'un ne vaut guère mieux que l'autre." },
            { "...I s'pose yer right. I 'adn't thought of it like that.", "...J'suppose qu't'as raison. J'avais pas vu les choses comme ça." },
            { "(Glad we've put that one to bed...)", "(Ravi qu'on ait classé cette idée saugrenue...)" },
            { "Anyway, the point is, everyone at the Yard's dead set on\r\nfindin' the fishy engineer...", "Bref, toujours est-il que tout le monde au Yard est sur les dents pour dégoter l'ingénieur louche..." },
            { "...but there don't seem to be no clues to go on.\r\nSo they're stuck.", "...mais y'a aucun indice sous la main. Alors ils rament." },
            { "(There's nothing that can lead us to Drebber at all...?)", "(Rien qui puisse nous mettre sur la piste de Drebber...?)" }
        });

        // [55] KEY:BB\script\output\_sce02_chr050_01_eng#7
        add(@"BB\script\output\_sce02_chr050_01_eng#7", new string[,] {
            { "Where did you find that little mutt then, Gina?", "Où as-tu déniché ce petit bâtard, Gina ?" },
            { "Oi! Don't be so flamin' rude, 'Oddo!", "Hé ! Sois pas si malpoli, Naruhodo !" },
            { "...Slight overreaction, don't you think?", "...Une réaction un peu disproportionnée, non ?" },
            { "'E ain't no mutt, alright?\r\nToby's... 'ow did they put it...?", "C'est pas un bâtard, pigé ? Toby, c'est... comment ils ont dit... ?" },
            { "...Oh, yeah!\r\nA ‘bone-fide’ detective!", "...Ah ouais ! Un fin limier aux dents longues !" },
            { "Sorry?", "Pardon ?" },
            { "I've given 'im a proper title an' everyfin'.\r\nIt's Chief Inspector Toby to you!", "J'lui ai donné un vrai titre officiel et tout. C'est l'inspecteur principal Toby pour toi !" },
            { "(More senior than Inspector Gregson, is he?)", "(Plus gradé que l'inspecteur Gregson lui-même ?)" },
            { "Ooh, so he's a police dog, is he?", "Ooh, c'est donc un chien policier ?" },
            { "The police recruit dogs now?", "La police enrôle des chiens à présent ?" },
            { "I've heard that they're already being used officially in\r\nGermany as part of their city policing.", "J'ai entendu dire qu'on les utilise déjà officiellement en Allemagne pour les patrouilles urbaines." },
            { "They're used for chasing criminals and suchlike!\r\nThey have a wonderful sense of smell, after all.", "On s'en sert pour pourchasser les criminels et autres ! Ils ont un odorat exceptionnel, après tout." },
            { "I have a fairly good sense of smell myself, as it happens.", "J'ai moi-même un assez bon odorat, pour tout dire." },
            { "I can tell undergarments that have been freshly\r\nlaundered from undergarments that...haven't.", "Je peux distinguer les sous-vêtements fraîchement lavés de ceux qui... ne le sont pas." },
            { "Haaah... That's nuffin' compared to this little fella, 'Oddo.", "Pfff... C'est de la roupie de sansonnet comparé à mon p'tit gars, Naruhodo." },
            { "Oh really?", "Ah oui ?" },
            { "Accordin' to wot the boss said...\r\n...once Toby 'ere's got a good whiff of yer drawers...", "D'après c'que l'patron m'a raconté... une fois qu'Toby a bien reniflé ton caleçon..." },
            { "...'e could chase that scent to the other side o' the world!", "...y pourrait pister c't'odeur jusqu'au bout du monde !" },
            { "WHAT?! To, to the other side of the world?\r\nYou mean...\r\n...he can swim?!", "QUOI ?! Jusqu'au... jusqu'au bout du monde ? Tu veux dire qu'il sait nager ?!" },
            { "Mr Naruhodo...\r\n...I think you may have missed the point...by rather a\r\nwide margin.", "Monsieur Naruhodo... je crois que vous passez totalement à côté du sujet." },
            { "I, I just can't believe this little dog has such an incredible\r\nskill...", "J-Je n'arrive pas à croire qu'un si petit chien possède un don aussi extraordinaire..." },
            { "I'm tellin' ya, 'Oddo, there's gonna be more an' more dogs\r\ndoin' their bit for the police in future.", "J'te l'dis, Naruhodo, y'aura d'plus en plus d'chiens dans la police à l'avenir." },
            { "Yes! I agree!", "Oui ! J'en suis convaincue !" },
            { "Right! One o' these days, they'll be barkin' orders at us lot,\r\nnot the other way round!", "Exact ! Un d'ces quatre, c'est eux qui vont nous aboyer des ordres et pas l'contraire !" },
            { "Oh dear... Sorry, Gina, I don't think I agree with your\r\nvision quite that much...", "Oh là là... Désolé Gina, mais je ne partage pas tout à fait cette vision du futur..." },
            { "Well anyway. Wotever ya think about that, Toby 'ere is\r\nBritain's first police dog!", "Bref. Quoi qu't'en penses, Toby ici présent est le premier chien policier de Grande-Bretagne !" },
            { "I found 'im down the East End the other day.\r\nSomeone 'ad just chucked 'im out on the street.", "J'l'ai trouvé dans l'East End l'autre jour. Quelqu'un l'avait lâchement balancé sur l'trottoir." },
            { "(There you go. I knew she'd lifted him from somewhere...)", "(Et voilà. Je savais bien qu'elle l'avait dégoté quelque part...)" },
            { "Oh Gina, you're such a kind-hearted soul, aren't you?\r\nTo children and to animals!", "Oh Gina, tu as le cœur sur la main, n'est-ce pas ? Envers les enfants comme envers les bêtes !" }
        });

        // [56] KEY:BB\script\output\_sce02_chr060_00_eng#1
        add(@"BB\script\output\_sce02_chr060_00_eng#1", new string[,] {
            { "Lord Stronghart said that the assault last night was some\r\nsort of revenge attack?", "Lord Harry Caine a affirmé que l'assaut d'hier soir était une sorte de vengeance ?" },
            { "True. Carried out by henchmen of Odie Asman's criminal\r\norganisation.", "Exact. Mené par les séides de l'organisation criminelle d'Odoril Asman." },
            { "The investigation meant their arrests were imminent.\r\nPresumably some hoped to kill me before that happened.", "L'enquête touchait au but, leurs arrestations étaient imminentes. Certains espéraient sans doute m'abattre avant." },
            { "Odie Asman...", "Odoril Asman..." },
            { "He's always masqueraded as one of London's most\r\npowerful financiers. A global investor.", "Il s'est toujours drapé dans le costume d'un puissant financier londonien. Un investisseur d'envergure internationale." },
            { "But his enormous wealth came to him by underhand\r\nmeans, via his criminal activities.", "Mais son immense fortune provenait d'activités frauduleuses et crapuleuses." },
            { "And he used that money to buy himself a verdict of not\r\nguilty when he found himself in court, didn't he?", "Et il s'est servi de cet argent pour s'acheter un verdict de non-culpabilité au tribunal, n'est-ce pas ?" },
            { "Being prosecuted by you, Mr Reaper.", "Face à votre réquisitoire, monsieur le Faucheur." },
            { "But the man got his comeuppance in the end.", "Mais cet individu a fini par recevoir son juste châtiment." },
            { "Yesterday in fact, in extraordinary circumstances.\r\nIt was a most unusual cause of death.", "Hier même, dans des circonstances extraordinaires. Une cause de décès pour le moins singulière." },
            { "I, I know about that! It was super-high-voltage\r\ninstantaneous kinesis gone wrong!", "J-Je suis au courant ! La téléportation instantanée à très haute tension qui a mal tourné !" },
            { "Mr Asman died when the demonstration on the public\r\nexperimentation stage ended in an enormous explosion.", "M. Asman a péri lors de l'explosion qui a ravagé la scène d'expérimentation publique." },
            { "...Correct.", "...C'est exact." },
            { "And you think I have some kind of divine ability to cause\r\nan accident like that to happen, do you?", "Et vous vous imaginez que je possède un quelconque pouvoir divin capable de provoquer un tel accident ?" },
            { "Well...no, that does seem a little far-fetched.", "Eh bien... non, cela semble passablement invraisemblable." },
            { "(If this man really is the fabled Reaper, then he has to be\r\ninnocent of this particular death, at least.)", "(Si cet homme est bien le légendaire Faucheur, il est en tout cas innocent de cette mort-là.)" },
            { "It's strange how this has worked out, isn't it, Runo?", "C'est une drôle d'ironie du sort, n'est-ce pas, Ryuno ?" },
            { "I mean, what with you taking on the professor's defence\r\nfor the trial tomorrow.", "Je veux dire, le fait que tu prennes la défense du professeur pour le procès de demain." },
            { "What?!\r\nYou're going to be defending him?", "Quoi ?!\r\nVous allez assurer sa défense ?" },
            { "Oh, yes, that's right.\r\nThough I barely know the man's name yet, to be honest.", "Oh, oui, tout à fait. Bien que je connaisse à peine son nom, pour être honnête." },
            { "Albert.", "Albert." },
            { "Albert Harebrayne.", "Samba Lonron." },
            { "That's right. ...Do you know him, by any chance?", "C'est bien cela. Le connaissez-vous par hasard ?" },
            { "Of course.", "Naturellement." }
        });

        // [57] KEY:BB\script\output\_sce02_chr060_00_eng#3
        add(@"BB\script\output\_sce02_chr060_00_eng#3", new string[,] {
            { "He's a contemporary of mine.\r\nWe were at university together.", "C'est un condisciple. Nous étions ensemble à l'université." },
            { "Your...", "Vos..." },
            { "WHAT?!", "QUOI ?!" }
        });

        // [58] KEY:BB\script\output\_sce02_chr060_00_eng#4
        add(@"BB\script\output\_sce02_chr060_00_eng#4", new string[,] {
            { "I'd understood that Professor Harebrayne was from\r\nGermany, though.", "J'avais pourtant cru comprendre que le professeur Lonron venait d'Allemagne." },
            { "Harebrayne's from a respectable British family.", "Lonron est issu d'une honorable famille britannique." },
            { "After graduating from the University of London, he\r\nmoved to Germany to carry out research, that's all.", "Après son diplôme à l'université de Londres, il est parti poursuivre ses recherches en Allemagne, voilà tout." },
            { "So you were students together...", "Vous étiez donc étudiants à la même époque..." },
            { "I was in the faculty of law, of course. And he in science.\r\nSo our paths rarely crossed.", "J'étais à la faculté de droit, naturellement. Et lui en sciences. Nos chemins se croisaient rarement." },
            { "But curiously, we got along.\r\nThough I've not met him since my university days.", "Mais curieusement, nous nous entendions fort bien. Quoique je ne l'aie plus revu depuis cette époque." },
            { "I certainly didn't expect our next encounter to take this\r\nform.", "Je ne m'attendais certes point à ce que nos retrouvailles prennent une telle tournure." },
            { "And with you of all people representing him.", "Et avec vous, par-dessus le marché, pour plaider sa cause." },
            { "(Ugh... Only if I make it out of this office alive...)", "(Glps... Si je sors vivant de ce bureau, déjà...)" },
            { "He's actually been charged with murder, it seems.", "Il est formellement inculpé de meurtre, semble-t-il." },
            { "Yes, I know.\r\nBecause the prosecution...\r\n...will be handled by me.", "Oui, je ne le sais que trop. Car l'accusation... sera portée par moi-même." },
            { "By you?!\r\nBut...but you made it sound as if you and the professor\r\nhad been friends.", "Par vous ?!\r\nMais... vous laissiez entendre que vous étiez amis !" },
            { "We are friends, it's true.", "Nous le sommes, en effet." },
            { "Then why would you do this?", "Alors pourquoi vous charger de l'accusation ?" },
            { "If the Reaper is the prosecutor, there's nothing anyone can\r\ndo to save him! He's doomed!", "Si le Faucheur mène l'accusation, personne ne pourra le sauver ! Il est condamné d'avance !" }
        });

        // [59] KEY:BB\script\output\_sce02_chr060_00_eng#5
        add(@"BB\script\output\_sce02_chr060_00_eng#5", new string[,] {
            { "(What's Lord van Zieks thinking...?)", "(À quoi peut bien penser Lord Van Peers...?)" }
        });

        // [60] KEY:BB\script\output\_sce02_chr060_00_eng#6
        add(@"BB\script\output\_sce02_chr060_00_eng#6", new string[,] {
            { "(What's Lord van Zieks thinking...?)", "(À quoi peut bien penser Lord Van Peers...?)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part2_A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part2_A written.");
    }
}
