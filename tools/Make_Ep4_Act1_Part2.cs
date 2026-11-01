using System;
using System.IO;
using System.Text;

class MakeEp4Act1Part2 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act1 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart2() {");

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

        // [33] KEY:BB\script\output\_sce03_bg0206_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0206_1_check_eng#1", new string[,] {
            { "Um...thank you for your concern, Mr Sholmes.", "Euh... merci de vous soucier de moi, Monsieur Holmes." },
            { "My dear fellow, think nothing of it.\r\nI must say I was quite startled...", "Mon cher ami, je vous en prie, ce n'est rien.\r\nJe dois admettre que j'ai été passablement sidéré..." },
            { "...when I heard that you'd been attacked by a dog.", "...en apprenant que vous aviez été attaqué par un chien." },
            { "For a moment, I feared that infamous murderer of so\r\nmany had come back from the dead!", "Un instant, j'ai craint que ce sinistre assassin d'une foule\r\nd'innocents ne soit revenu d'entre les morts !" },
            { "...You mean, the Professor?", "...Vous voulez dire... le Démon Assassin ?" },
            { "Fortunately, I see your prized throat is unscathed.", "Heureusement, je constate que votre précieux gosier est indemne." },
            { "That stiff, turned-up collar of yours obviously afforded\r\nsome welcome protection.", "Ce col haut et rigide que vous arborez vous a manifestement procuré\r\nune protection salutaire." },
            { "(...Was I that close to death?)", "(...Étais-je à ce point proche de trépasser ?)" },
            { "All I really remember is the dog licking my face over\r\nand over and over again...", "Tout ce dont je me rappelle, c'est du chien qui me léchait le visage\r\nencore, encore et encore..." },
            { "Well, if you wish to avoid such troubles in future, a little\r\nmustard spread on the cheeks should do the trick.", "Eh bien, si vous souhaitez éviter pareille mésaventure à l'avenir,\r\nun peu de moutarde étalée sur vos joues devrait faire l'affaire." },
            { "I should think that would balance the sweetness of your\r\nbandage rather splendidly.", "Cela équilibrerait à merveille la douceur de votre pansement,\r\nà n'en pas douter." }
        });

        // [34] KEY:BB\script\output\_sce03_bg0214_1_00_eng#5
        add(@"BB\script\output\_sce03_bg0214_1_00_eng#5", new string[,] {
            { "2nd November\r\nSt Synner's Hospital, Ward 3", "2 novembre\r\nHôpital Saint-Pénitent, Salle 3" }
        });

        // [35] KEY:BB\script\output\_sce03_bg0214_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [36] KEY:BB\script\output\_sce03_bg0214_1_check_eng#2
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#2", new string[,] {
            { "There are lots of bottles in that cabinet there, aren't there?", "Il y a une foule de bouteilles dans cette armoire, n'est-ce pas ?" },
            { "Do you think it's safe to keep them there?", "Pensez-vous qu'il soit bien prudent de les laisser là ?" },
            { "Hee hee! If you were a patient here, I feel sure you'd take\r\nsome medicine by mistake when you were half asleep!", "Hé hé ! Si vous étiez patient ici, je suis sûre que vous avaleriez\r\nun remède par erreur en étant à demi endormi !" },
            { "...That is a worry. But at least the cabinet has a lock, even\r\nif it's only a flimsy-looking one.", "...C'est une crainte légitime. Mais au moins l'armoire est fermée à clé,\r\nmême si le verrou semble fragile." },
            { "Oh, I've no doubt you'd manage to unlock that somehow\r\nwhile you were half asleep as well.", "Oh, je ne doute pas que vous parviendriez à l'ouvrir d'une façon\r\nou d'une autre dans votre demi-sommeil aussi." },
            { "...There are limits even to what I can do when I'm half\r\nasleep, you know, Miss Susato.", "...Il y a des limites à ce que je peux faire à moitié endormi,\r\nvous savez, Mademoiselle Susato." }
        });

        // [37] KEY:BB\script\output\_sce03_bg0214_1_check_eng#3
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#3", new string[,] {
            { "There are all sorts of medicines in this cabinet, look.", "Il y a toutes sortes de médicaments dans ce placard, regardez." },
            { "I'm not sure if it's safe leaving them in reach of everyone\r\nlike this.", "Je ne sais pas s'il est sage de les laisser à portée de tout le monde\r\ncomme ça." },
            { "Yes, you're right. I can imagine if you were peckish, you\r\nmight try some of the pills.", "Oui, vous avez raison. J'imagine que si vous aviez un creux, vous\r\npourriez être tenté de goûter aux pilules." },
            { "...Well, at least there seems to be a little lock to secure\r\nthe cabinet doors.", "...Eh bien, au moins il y a une petite serrure pour verrouiller\r\nles portes." },
            { "I don't imagine that would stop you if you were hungry.\r\nI worry that you'd break the lock.", "Je ne pense pas que cela vous arrêterait si vous aviez faim.\r\nJ'ai peur que vous ne fracturiez la serrure." },
            { "...Hunger doesn't turn me into a criminal, you know,\r\nMiss Susato.", "...La faim ne fait pas de moi un forçat, vous savez,\r\nMademoiselle Susato." }
        });

        // [38] KEY:BB\script\output\_sce03_bg0214_1_check_eng#4
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#4", new string[,] {
            { "Ah look, a pair of crutches. Before we came to Britain,\r\nI hadn't realised they were used here as well.", "Tiens regardez, une paire de béquilles. Avant de venir en Grande-Bretagne,\r\nj'ignorais qu'on en utilisait ici également." },
            { "I imagine they were imported into Japan from Great\r\nBritain in the first place.", "J'imagine qu'elles ont été importées au Japon depuis la\r\nGrande-Bretagne à l'origine." },
            { "Oh, so no one in all of Japan broke a leg before their\r\narrival?", "Ah, personne dans tout le Japon ne s'était donc cassé une jambe avant\r\nleur arrivée ?" },
            { "Anyway, the sight of these things doesn't bring back good\r\nmemories for me.", "Bref, la vue de ces engins ne me rappelle pas de très bons souvenirs." },
            { "Oh dear. Did you injure yourself once and need to use\r\nsome?", "Grands dieux. Vous êtes-vous blessé jadis au point d'en avoir\r\nbesoin ?" },
            { "When I was little. I thought they looked fun, so I borrowed\r\na pair to play with.", "Quand j'étais petit. Je trouvais ça drôle, alors j'en ai emprunté\r\nune paire pour m'amuser." },
            { "But then I slipped and sprained my ankle.", "Mais j'ai dérapé et me suis foulé la cheville." },
            { "...I see.", "...Je vois." },
            { "They contain powerful magic, those wooden staffs:\r\nthe power to heal, and the power to harm!", "Elles renferment une puissante magie, ces béquilles de bois :\r\nle pouvoir de guérir, et le pouvoir de blesser !" },
            { "...I think a certain cheeky little boy managed to cause the\r\nharm all by himself.", "...Je crois surtout qu'un gamin turbulent a fort bien réussi à se faire\r\nmal tout seul." }
        });

        // [39] KEY:BB\script\output\_sce03_bg0214_1_check_eng#5
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#5", new string[,] {
            { "These must be the patient's treatment notes.\r\nLet's see...", "Ce doivent être les observations médicales du malade.\r\nVoyons..." },
            { "‘Tendency to jump from windows.\r\nRemember to place cushion at base of wall outside.’", "« Tendance à sauter par la fenêtre.\r\nPenser à disposer un coussin au pied du mur extérieur. »" },
            { "...Aren't we a storey up from the ground here?", "...Ne sommes-nous pas à l'étage ici ?" },
            { "Oh dear... Poor Mr Vigil.", "Grand bien m'en fasse... Pauvre M. Vigil." },
            { "I can't help feeling that there's a better solution to the\r\nproblem than a cushion, though...", "Je ne peux m'empêcher de songer qu'il existe de meilleures parades\r\nqu'un simple coussin..." },
            { "(Finding something you'd lost isn't always a happy\r\nexperience, it turns out.)", "(Retrouver ce que l'on avait perdu n'est pas toujours une expérience\r\njoyeuse, dirait-on.)" },
            { "Pursuing the truth can be...a very dark business\r\nsometimes, can't it?", "La quête de la vérité peut s'avérer... bien sombre et pesante\r\nparfois, n'est-ce pas ?" },
            { "Yes...I'm afraid it can.", "Oui... je le crains fort." }
        });

        // [40] KEY:BB\script\output\_sce03_bg0214_1_check_eng#6
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#6", new string[,] {
            { "This notice caught my eye before, actually.", "Cette pancarte m'avait déjà sauté aux yeux plus tôt, en fait." },
            { "I suppose it's some sort of slogan for the ward?\r\nA cheerful welcome message perhaps.", "J'imagine que c'est une sorte de slogan pour la salle ?\r\nUn mot de bienvenue chaleureux peut-être." },
            { "Let's see...\r\n‘Pay with good cheer; leave with good cheer.’", "Voyons...\r\n« Payez de bon cœur, partez dans le bonheur. »" },
            { "Well look at that! You were spot on, Miss Susato.\r\nIt is full of ‘cheer’.", "Ça alors ! Vous aviez vu parfaitement juste, Mademoiselle Susato.\r\nC'est plein de « bonheur »." },
            { "...I wonder how many discharged patients pay their\r\nmedical bills with good cheer, though.", "...Je me demande tout de même combien de patients sortants règlent\r\nleur facture d'un si bon cœur." },
            { "Once I had to have a very painful injection when I fell ill\r\nwith a cold.", "Une fois, j'ai dû subir une piqûre atrocement douloureuse alors que\r\nj'avais attrapé un gros rhume." },
            { "I felt awful already. So why did I have to suffer the sting\r\nof the injection as well as the bill? I yelled at the doctor.", "J'étais déjà à l'agonie. Pourquoi devais-je endurer la morsure\r\nde l'aiguille en plus de la douloureuse ? J'ai crié sur le médecin." },
            { "Oh dear...what terrible treatment.", "Grands dieux... quel traitement barbare." }
        });

        // [41] KEY:BB\script\output\_sce03_bg0214_1_check_eng#7
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#7", new string[,] {
            { "Ah, patient treatment notes...\r\nWhat do these say, I wonder?", "Ah, les notes de soins du patient...\r\nQue disent-elles, je me le demande ?" },
            { "‘Endlessly obliging.’", "« Serviable à l'excès. »" },
            { "I suppose that's referring to the patient in this bed.", "J'imagine que cela désigne le malade de ce lit." },
            { "I would think so. And until Mr Vigil is a little more\r\nstable...", "Je le pense aussi. Et en attendant que M. Vigil soit un peu plus\r\nstable..." }
        });

        // [42] KEY:BB\script\output\_sce03_bg0214_1_check_eng#8
        add(@"BB\script\output\_sce03_bg0214_1_check_eng#8", new string[,] {
            { "(Well...at least he seems to be on the mend.)", "(Eh bien... au moins, il semble sur la voie de la guérison.)" },
            { "You know...\r\n...his disguise as Mr Gossip was really quite masterful,\r\nwasn't it?", "Vous savez...\r\n...son déguisement en M. Potin était franchement magistral,\r\nvous ne trouvez pas ?" },
            { "I can't remember anything about it except for the floppy\r\nlip.", "Je ne me souviens de rien d'autre que de sa lèvre tombante." },
            { "I imagine not even his wife would have recognised him.", "J'imagine que même sa propre épouse ne l'aurait pas reconnu." },
            { "Perhaps. But did he really have to take it quite so far?", "Peut-être. Mais devait-il vraiment pousser la comédie si loin ?" }
        });

        // [43] KEY:BB\script\output\_sce03_bg0306_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [44] KEY:BB\script\output\_sce03_bg0306_1_check_eng#2
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#2", new string[,] {
            { "There's Lord van Zieks's incredibly stylish desk.", "Voici le bureau au style si raffiné de Lord Van Peers." },
            { "It's not my style, though.", "Ce n'est guère mon genre, toutefois." },
            { "No, I notice you've been working at the little table on the\r\nfloor, kneeling down seiza-style.", "Non, j'ai vu que tu travaillais sur la petite table par terre,\r\nagenouillé en posture de seiza." },
            { "I thought it was some kind of punishment set up by Lord\r\nvan Zieks when I first saw it.", "J'ai d'abord cru que c'était une punition infligée par Lord\r\nVan Peers quand je l'ai aperçue." },
            { "I find it the most comfortable way to work.", "C'est la position la plus confortable pour étudier à mes yeux." },
            { "I can't do it. After a couple of minutes of sitting with my\r\nlegs folded under me, they start to go tingly.", "J'en suis bien incapable. Après quelques minutes assis sur mes\r\njambes repliées, des fourmis m'envahissent." },
            { "Don't exaggerate, Ryunosuke. ...We both know you can't\r\neven manage a minute.", "N'exagère rien, Ryunosuke. ...Nous savons tous deux que tu ne tiens\r\nmême pas une seule minute." }
        });

        // [45] KEY:BB\script\output\_sce03_bg0306_1_check_eng#3
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#3", new string[,] {
            { "Wh-What the...?", "Q-Qu'est-ce que... ?" },
            { "It's a scale model of the crime scene.", "C'est une maquette à l'échelle du lieu du crime." },
            { "Oh...yes, I realise that.", "Oh... oui, je m'en doute bien." },
            { "...Does the prosecution office make a model of the scene\r\nfor every single case?", "...Le parquet fabrique-t-il une maquette pour chaque\r\naffaire ?" },
            { "Apparently so.", "Il semblerait bien." },
            { "Sometimes it helps to visualise things better and notice\r\nthings you hadn't spotted before.", "Cela aide parfois à mieux appréhender la scène et à remarquer\r\ndes détails passés inaperçus." },
            { "Actually, the miniature noticeboard is my work.", "À vrai dire, le petit panneau d'affichage miniature est de ma main." },
            { "(Be honest...you enjoyed making that.)", "(Sois franc... tu as adoré fabriquer ça.)" }
        });

        // [46] KEY:BB\script\output\_sce03_bg0306_1_check_eng#4
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#4", new string[,] {
            { "Lord van Zieks's fine collection of hallowed chalices and\r\nbottles, all neatly lined up.", "La splendide collection de calices et de bouteilles sacrées de\r\nLord Van Peers, impeccablement alignées." },
            { "Yes, he's extremely particular about all that.", "Oui, il est d'une minutie extrême avec tout cela." },
            { "He has a strict regime for everything, from the storage of\r\nthe casks to the bottling of their contents.", "Il a instauré un protocole très strict pour tout, de la conservation\r\ndes fûts jusqu'à la mise en bouteille de leur précieux nectar." },
            { "Gosh, you must be having a really tough time of it being\r\nhis apprentice.", "Bigre, ton rôle d'apprenti auprès de lui doit être un vrai chemin\r\nde croix au quotidien." },
            { "Actually, no.", "En fait, non." },
            { "Oh?", "Ah bon ?" },
            { "He's so particular about it all, he refuses to let anybody\r\nelse touch any of it.", "Il est si maniaque avec tout cela qu'il refuse que quiconque\r\nd'autre n'y porte la main." },
            { "So it's been quite easy for me, in fact.", "C'est donc un vrai repos pour moi, en réalité." },
            { "(...Talk about weird.)", "(...Quelle drôle d'ambiance.)" }
        });

        // [47] KEY:BB\script\output\_sce03_bg0306_1_check_eng#5
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#5", new string[,] {
            { "Casks floor to ceiling, just like the last time we were here.", "Des tonneaux du sol au plafond, tout comme lors de notre dernière visite." },
            { "Hallowed barrels, I suppose.", "Des barils sacrés, j'imagine." },
            { "They're arranged according to vintage, flavour and region.", "Ils sont classés selon le millésime, le bouquet et le vignoble." },
            { "Every week, they're all taken out and put back in order.", "Chaque semaine, ils sont tous déplacés puis réordonnés." },
            { "What?! Every week?", "Quoi ?! Chaque semaine ?" },
            { "Lord van Zieks can't seem to settle on the perfect way of\r\narranging them, you see.", "Lord Van Peers ne parvient pas à arrêter l'agencement parfait,\r\nvoyez-vous." },
            { "Vintage, flavour and region don't neatly coincide, that's the\r\ntrouble.", "Le millésime, le bouquet et le terroir ne coïncident pas toujours,\r\nvoilà le souci." },
            { "Gosh, being his apprentice must be a real challenge.", "Diable, être son apprenti doit être une épreuve de chaque instant." },
            { "Actually, no.", "En vérité, non." },
            { "Oh?", "Ah ?" },
            { "He considers the task too important to entrust to anybody\r\nelse, so he does it entirely on his own.", "Il juge la tâche bien trop noble pour la confier à quiconque,\r\nalors il s'en charge entièrement tout seul." },
            { "(...So he's a barrel of laughs here AND in court, then.)", "(...Il est aussi joyeux et détendu ici qu'au prétoire, donc.)" }
        });

        // [48] KEY:BB\script\output\_sce03_bg0306_1_check_eng#6
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#6", new string[,] {
            { "Do you know who the man in the portrait is?", "Sais-tu qui est l'homme représenté sur ce tableau ?" },
            { "Why would I?", "Pourquoi le saurais-je ?" },
            { "What?! But you're Lord van Zieks's apprentice!", "Quoi ?! Mais tu es l'apprenti de Lord Van Peers !" },
            { "Yes, apprentice, not friend.", "Oui, apprenti, pas ami intime." },
            { "And during the time I was suffering from amnesia, I didn't\r\neven notice that picture.", "Et pendant toute la période où j'étais amnésique, je n'avais\r\nmême pas remarqué cette toile." },
            { "Oh...really?\r\n(I mean, it's not the smallest picture...)", "Oh... vraiment ?\r\n(Faut dire que ce n'est pas le plus discret des tableaux...)" },
            { "I wouldn't have the first idea what the man decorates his\r\noffice with.", "Je n'ai pas la moindre idée de ce dont cet homme pare son bureau." }
        });

        // [49] KEY:BB\script\output\_sce03_bg0306_1_check_eng#7
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#7", new string[,] {
            { "Wah!", "Ouah !" },
            { "You disturbed the bats, did you? Fitting companions of\r\nLord van Zieks, wouldn't you say?", "Tu as effarouché les chauves-souris ? De parfaites compagnes pour\r\nLord Van Peers, ne trouves-tu pas ?" },
            { "Actually...", "En fait..." },
            { "...I've seen things flying in Lord Stronghart's office, too.\r\nDoves, I think.", "...j'ai vu des animaux ailés dans le bureau de Lord Harry Caine aussi.\r\nDes colombes, je crois." },
            { "Perhaps you have to like birds to attain rank in the\r\njudiciary here...", "Sans doute faut-il aimer les volatiles pour faire carrière dans la\r\nmagistrature ici..." },
            { "Although bats aren't birds, of course.", "Bien que les chauves-souris ne soient point des oiseaux, bien entendu." },
            { "How about a sparrow for you?", "Et que dirais-tu d'un moineau pour toi ?" },
            { "What's that supposed to mean?", "Qu'est-ce que cela signifie ?" },
            { "Oh! Nothing. Sorry.\r\nJust thinking out loud...", "Oh ! Rien. Pardon.\r\nJe pensais tout haut..." }
        });

        // [50] KEY:BB\script\output\_sce03_bg0306_1_check_eng#8
        add(@"BB\script\output\_sce03_bg0306_1_check_eng#8", new string[,] {
            { "Let's see, what have we here...?", "Voyons un peu ce que nous avons là..." },
            { "Mr Naruhodo...\r\n...it would be very underhand to glean information from\r\nKazuma-sama's office while he's absent.", "Monsieur Naruhodo...\r\n...ce serait un procédé bien vil que de chercher des indices dans le\r\nbureau de Monsieur Kiyô en son absence." },
            { "Hm?", "Hein ?" },
            { "We should wait until he's here before we start nosing\r\naround!", "Nous devrions attendre qu'il soit là avant de fureter !" },
            { "Oh! Of, of course, yes.", "Oh ! B-Bien sûr, oui." },
            { "(She doesn't take any nonsense when it comes to Kazuma,\r\ndoes she?)", "(Elle ne badine vraiment pas dès qu'il s'agit de Kazuma, ma parole...)" }
        });

        // [51] KEY:BB\script\output\_sce03_bg0400_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [52] KEY:BB\script\output\_sce03_bg0400_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#2", new string[,] {
            { "Look at those cases just left there on that trolley.\r\nAren't they worried about thieves? I know I am.", "Regardez ces valises laissées là sur ce chariot.\r\nNe craignent-ils pas les pickpockets ? Moi en tout cas, oui." },
            { "Haven't you seen the porter over there? Don't worry, he's\r\nobviously keeping an eye on everything.", "N'avez-vous pas vu le bagagiste là-bas ? Ne craignez rien,\r\nil surveille manifestement tout avec attention." },
            { "Ah, so it's a trap, designed to catch any chancers who\r\nmight be tempted!", "Ah, c'est donc un piège pour pincer les opportunistes tentés\r\nde s'en emparer !" },
            { "Why did the porter give me such a scathing look just now,\r\ndo you suppose?", "Pourquoi ce porteur m'a-t-il lancé un regard si glacial,\r\nd'après vous ?" },
            { "Well...some might say you look a little suspicious with\r\nyour jet-black clothes.", "Eh bien... certains diraient que votre tenue d'un noir de jais\r\nparaît quelque peu suspecte." },
            { "Not everyone clad in black is some sort of ninja with\r\nintent to steal, you know!", "Tous ceux qui s'habillent de noir ne sont pas des ninjas venus\r\nchaparder, vous savez !" }
        });

        // [53] KEY:BB\script\output\_sce03_bg0400_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#3", new string[,] {
            { "Have you seen all those sparkling jewels up there? They\r\nmust have gathered every gem in the world for that!", "Avez-vous vu tous ces joyaux étincelants là-haut ? Ils ont\r\ndû rassembler toutes les pierres précieuses du globe pour ça !" },
            { "Ah...it's called a chandelier, I believe.", "Ah... on appelle cela un lustre, si je ne m'abuse." },
            { "It's designed to provide elegant lighting in large, spacious\r\nrooms like this.", "C'est conçu pour éclairer avec faste les grandes salles\r\nmajestueuses comme celle-ci." },
            { "So they had to gather every gem in the world just to\r\nilluminate one room?", "Il a donc fallu piller toutes les gemmes du monde pour\r\néclairer une seule pièce ?" },
            { "...It's probably electric light bulbs that are actually\r\nthrowing the light.", "...Ce sont très probablement de simples ampoules électriques\r\nqui diffusent cette lumière." },
            { "If I tried to hang something like that from the ceiling in\r\nthe office, it would be scraping on the floor.", "Si j'essayais de pendre un tel engin au plafond de notre cabinet,\r\nil frotterait contre le parquet." },
            { "I think perhaps chandeliers aren't for you, Mr Naruhodo.", "Je crois bien que les lustres ne sont pas faits pour vous,\r\nMonsieur Naruhodo." }
        });

        // [54] KEY:BB\script\output\_sce03_bg0400_0_check_eng#4
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#4", new string[,] {
            { "That desk is known as the hotel reception.", "Ce guichet s'appelle la réception de l'hôtel." },
            { "Anyone wanting to spend the night has to report there to\r\nsign in for their stay.", "Toute personne désirant y passer la nuit doit s'y présenter\r\npour enregistrer son séjour." },
            { "Oh, so do you think that's the head clerk behind the desk\r\nthere?", "Ah, pensez-vous que ce soit le réceptionniste derrière ce comptoir ?" },
            { "Yes, I'm sure it must be.", "Oui, j'en suis persuadée." },
            { "I'd love to stay in a grand hotel like this for a little while,\r\nwouldn't you? Just to know what it's like.", "J'adorerais passer quelques jours dans un palace comme celui-ci,\r\npas vous ? Juste pour goûter à ce train de vie." },
            { "...If the hotel fee was paid through our stipend, I'm afraid\r\nit might bankrupt our homeland.", "...Si la note devait être réglée sur notre bourse d'études, je crains\r\nque notre patrie ne soit mise sur la paille." },
            { "(True. London gives the word ‘expensive’ a whole new\r\nmeaning.)", "(C'est vrai. Londres confère au mot « ruineux » une signification\r\ntout à fait inédite.)" }
        });

        // [55] KEY:BB\script\output\_sce03_bg0400_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#5", new string[,] {
            { "Look at that. It's a picture of the Crystal Tower.", "Regardez là. C'est une gravure de la Tour de Cristal." },
            { "Well, the Great Exhibition is one of Britain's most\r\nprestigious achievements in recent years.", "Eh bien, l'Exposition universelle est l'une des plus éclatantes\r\nréussites de la Grande-Bretagne de ces dernières années." },
            { "I wonder how tall it is? It really does represent the\r\npinnacle of scientific achievement in so many ways...", "Je me demande quelle hauteur elle fait ? Elle représente l'apogée\r\nde la science à tant d'égards..." },
            { "There's a twenty-metre-tall chimney on the bathhouse\r\nnear my lodgings at Yumei University.", "Il y a une cheminée de vingt mètres de haut sur les bains publics\r\nprès de mon logis à l'université Yumei." },
            { "The attendant there is always boasting that it's the tallest\r\nobject in the neighbourhood.", "Le tenancier se vante toujours qu'elle domine tous les toits\r\ndes alentours." },
            { "I'm sure. Did you know that over the Channel in Paris,\r\nthere's a tower that's three hundred metres tall?", "Sans doute. Saviez-vous que de l'autre côté du détroit, à Paris,\r\nil y a une tour haute de trois cents mètres ?" },
            { "WHAT?! How, how many times taller than the chimney\r\nat Yumei Sokin hot-springs is that?", "QUOI ?! Mais combien... combien de fois plus haut que la cheminée\r\ndes bains de Yumei Sokin est-ce que cela fait ?" },
            { "And if it's that tall, how does it draw properly?\r\nThe smoke would get stuck, surely?", "Et à une telle hauteur, comment le conduit peut-il tirer ?\r\nLa fumée ne peut que rester bloquée !" },
            { "...I don't think it's that sort of tower, Mr Naruhodo.", "...Je ne crois pas que ce soit ce genre de tour, Monsieur Naruhodo." }
        });

        // [56] KEY:BB\script\output\_sce03_bg0400_0_check_eng#6
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#6", new string[,] {
            { "(That's Professor Mikotoba over there...)", "(C'est le professeur Mikotoba là-bas...)" },
            { "Ah, hello, you two! I was just taking a moment to catch up\r\non the world now that I'm unpacked.", "Ah, bonjour à tous les deux ! Je profitais d'un instant pour m'informer\r\ndes nouvelles du monde maintenant que mes valises sont défaites." },
            { "But where's Judge Jigoku?", "Mais où est passé le juge Jigoku ?" },
            { "Yes...he's not the relaxing sort.", "Eh bien... il n'est guère enclin à la flânerie." },
            { "He's taken himself off to pay his respects to all the legal\r\nbigwigs.", "Il est déjà parti présenter ses hommages aux hautes instances\r\nde la magistrature." },
            { "Having only just arrived in the country today?\r\nGoodness, he is full of energy.", "Alors qu'il a débarqué dans ce pays aujourd'hui même ?\r\nGrands dieux, quelle énergie débordante." },
            { "Um, Professor, you mentioned something before...\r\nAbout how you'd known the prison governor at Barclay\r\nPrison.", "Dites, professeur, vous avez évoqué une chose tout à l'heure...\r\nÀ propos de votre lien avec le directeur de la prison\r\nde Barclay." },
            { "Oh! ...Governor Caidin, you mean?", "Oh ! ...Le directeur Caidin, vous voulez dire ?" },
            { "(So it is the same man!)", "(C'est donc bien le même homme !)" },
            { "Father!\r\nWe must speak with the governor!", "Père !\r\nNous devons impérativement nous entretenir avec ce directeur !" }
        });

        // [57] KEY:BB\script\output\_sce03_bg0400_0_check_eng#7
        add(@"BB\script\output\_sce03_bg0400_0_check_eng#7", new string[,] {
            { "(Professor Mikotoba is obviously trying to relax on that\r\nsettee there.)", "(Le professeur Mikotoba cherche visiblement à se reposer sur cette\r\nbanquette.)" },
            { "Father has only just arrived after a very long voyage from\r\nhome.", "Mon père arrive tout juste au terme d'une éprouvante traversée depuis\r\nle Japon." },
            { "And tomorrow, he will speak at an important symposium\r\nthat will garner the attention of the whole world.", "Et dès demain, il s'exprimera lors d'un colloque capital qui retiendra\r\nl'attention du monde entier." },
            { "He needs a little peace and quiet now.", "Il a besoin de calme et de sérénité pour l'heure." },
            { "I, I was just about to think that!", "C-C'est exactement ce que j'allais me dire !" },
            { "Pardon?", "Pardon ?" },
            { "It's one thing reading my thoughts, but at least let me have\r\nthem first!", "C'est une chose de deviner mes pensées, mais laissez-moi au moins\r\nle temps de les formuler !" },
            { "Oh dear... Perhaps my brain works too quickly...", "Grand dieu... Mon esprit s'emballe peut-être un peu trop vite..." }
        });

        // [58] KEY:BB\script\output\_sce03_bg0401_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [59] KEY:BB\script\output\_sce03_bg0401_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#2", new string[,] {
            { "An axe, a hunting rifle and four pairs of handcuffs...\r\nThat's a daunting collection.", "Une hache, un fusil de chasse et quatre paires de menottes...\r\nVoilà une panoplie pour le moins intimidante." },
            { "Ah, there's a story behind every one of those.", "Ah, il y a une histoire derrière chacun de ces objets." },
            { "You mean...\r\n...the rifle was a famous killer's murder weapon?\r\nAnd the axe was wielded by an infamous executioner?\r\nAnd the handcuffs were once used to immobilise a fierce\r\nfour-legged beast when it was arrested?!", "Vous voulez dire...\r\n...que ce fusil était l'arme d'un meurtrier sanguinaire ?\r\nQue cette hache a été brandie par un infâme bourreau ?\r\nEt que ces menottes ont servi à ligoter un féroce fauve\r\nquadrupède lors de sa capture ?!" },
            { "I think you're in the realms of fantasy now, Mr Naruhodo.", "Je crois que vous nagez en pleine affabulation, Monsieur Naruhodo." },
            { "Not those kind of stories, Jimmy.\r\nThat axe was the one I used to chop down the cherry\r\ntree at my hoose. Mrs Caidin was'nae best pleased.", "Pas ce genre de contes, mon garçon.\r\nCette hache m'a servi à abattre le cerisier dans mon jardin.\r\nMadame Caidin n'a pas franchement rigolé." },
            { "And the cuffs on the left are the ones I caught my first\r\nburglar with back when I was a bobby.", "Et les fers sur la gauche sont ceux avec lesquels j'ai épinglé mon\r\npremier monte-en-l'air à mes débuts dans la police." },
            { "The stories were a little different to those you imagined,\r\nI think, weren't they?", "Ces anecdotes étaient un tantinet différentes de ce que vous aviez\r\nimaginé, n'est-ce pas ?" },
            { "Yes, to my relief...and in some small way, my\r\ndisappointment.", "Oui, à mon grand soulagement... et avec une légère pointe de\r\ndéception." }
        });

        // [60] KEY:BB\script\output\_sce03_bg0401_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#3", new string[,] {
            { "Th-This grandfather clock is...", "C-Cette horloge comtoise est..." },
            { "...Is fitted with a terrifying blade that keeps dropping\r\ndown!", "...Est munie d'un couperet terrifiant qui n'arrête pas\r\nde s'abattre !" },
            { "It's modelled on the guillotine – a French execution\r\ndevice. You might have heard of it.", "Elle est inspirée de la guillotine, cet instrument de supplice\r\nfrançais. Vous en avez sans doute ouï parler." },
            { "And yes, afore you ask: it can chop.", "Et oui, avant que vous ne le demandiez : elle tranche." },
            { "Heads off, you mean?!", "Des têtes, vous voulez dire ?!" },
            { "Havers, no! Carrots and parsnips and so forth.", "Fichtre, non ! Des carottes, des panais et le reste." },
            { "If you place a large carrot at the bottom there in the morn,\r\nby evening it'll have been cut clean in two.", "Si vous y glissez une belle carotte le matin,\r\nau soir elle est coupée net en deux." },
            { "...Well...the blade must have an almost indescribable edge\r\non it, then.", "...Eh bien... la lame doit avoir un tranchant pour le moins\r\nimperceptible, alors." }
        });

        // [61] KEY:BB\script\output\_sce03_bg0401_0_check_eng#4
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#4", new string[,] {
            { "I suppose these are all former governors of Barclay\r\nPrison, are they?", "J'imagine que ce sont tous d'anciens directeurs de la prison\r\nde Barclay, n'est-ce pas ?" },
            { "Either that or former inmates who the governor has sent\r\nto the gallows.", "Soit cela, soit d'anciens détenus que le directeur a envoyés\r\nà la potence." },
            { "Oh dear...they all have such severe expressions, I really\r\ncouldn't deny either possibility.", "Grands dieux... ils ont tous l'air si patibulaire qu'aucune de ces\r\nhypothèses ne me paraît exclue." },
            { "Especially the one on the extreme right. His expression\r\ngoes beyond ‘severe’ into a whole new territory...", "Surtout celui tout à fait à droite. Sa mine va bien au-delà\r\nde la sévérité, c'est carrément effrayant..." },
            { "...That one's me.", "...Ce portrait-là, c'est moi." },
            { "Aaaaaah!\r\nI'm, I'm terribly sorry, sir!", "Aaaaaah !\r\nJ-Je vous demande mille fois pardon, monsieur !" },
            { "...Is it a prerequisite of the job, perhaps?\r\nHaving a severe expression, I mean.", "...Est-ce une exigence du poste, peut-être ?\r\nAvoir un air implacable, je veux dire." },
            { "Of course it's not!\r\nAlthough...it is taken into consideration.", "Bien sûr que non !\r\nQuoique... cela soit pris en considération." },
            { "(...A lot.)", "(...Beaucoup, même.)" }
        });

        // [62] KEY:BB\script\output\_sce03_bg0401_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#5", new string[,] {
            { "I'd never have expected to find a parrot in a prison!\r\nIt must be the governor's pet.", "Je n'aurais jamais pensé trouver un perroquet dans un pénitencier !\r\nCe doit être l'oiseau de compagnie du directeur." },
            { "Given where we are...it's hard not to see the poor\r\ncreature as a prisoner.", "Étant donné le lieu... difficile de ne pas considérer cette pauvre\r\nbête comme une captive." },
            { "Lemme-oot!\r\nDinnae-kill-me!", "Laissez-moi sortir !\r\nMe tuez pas !" },
            { "Has, has the bird learnt to mimic the plaintive cries of the\r\ninmates in the cells?", "Cet... cet oiseau a-t-il appris à imiter les supplications déchirantes\r\ndes prisonniers au fond de leurs geôles ?" },
            { "Och, no! He was one of three siblings, you see.\r\nAnd he still calls oot the names of his two brothers like\r\nthat all the time.", "Mais non, voyons ! Il faisait partie d'une nichée de trois poussins.\r\nEt il appelle encore ses deux frères de cette façon à longueur de journée." },
            { "Aye, aye, I hear ya, laddie.\r\nYou want your dinner, eh, Did'nae-do-it?", "Oui, oui, je t'entends, mon grand.\r\nTu veux ta pâtée, hein, Pas-coupable ?" }
        });

        // [63] KEY:BB\script\output\_sce03_bg0401_0_check_eng#6
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#6", new string[,] {
            { "That deer has been staring at me for a while now.", "Ce cerf ne me quitte pas des yeux depuis tout à l'heure." },
            { "The poor thing can't fit through the small hole in the wall\r\nbut it can't get its head back out again now, either.\r\nIt's giving me a woefully imploring look.", "La pauvre bête ne peut passer à travers le trou du mur,\r\nmais elle ne parvient plus à ressortir la tête non plus.\r\nElle me lance un regard désespéré." },
            { "It's not real, Mr Naruhodo.\r\nIt's stuffed.", "Ce n'est pas un vrai cerf, Monsieur Naruhodo.\r\nIl est empaillé." },
            { "For a moment, I thought it was another assassin sneaking\r\nin via the ventilator.", "Un instant, j'ai cru que c'était un autre assassin qui s'infiltrait\r\npar le conduit d'aération." },
            { "I don't like to say...\r\n...but I think perhaps you need to reread ‘The Adventures\r\nof Herlock Sholmes’.", "Cela m'ennuie de le dire...\r\n...mais vous feriez bien de relire « Les Aventures de\r\nSherlock Holmes »." }
        });

        // [64] KEY:BB\script\output\_sce03_bg0401_0_check_eng#7
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#7", new string[,] {
            { "That's a very large cabinet full of papers, isn't it?\r\nIt's labelled ‘Inmate Register’, look.\r\nAnd all the files are in alphabetical order.", "C'est une bien grande armoire remplie de dossiers, n'est-ce pas ?\r\nElle est étiquetée « Registre des écrous », regardez.\r\nEt tout est classé par ordre alphabétique." },
            { "That's fifty years worth of records of Barclay's inmates.\r\nWhether or no they left alive after serving their term.\r\nAll the details aboot the crimes they committed are\r\nrecorded in there. Like an epitaph, you might say.", "Ce sont cinquante années d'archives des forçats de Barclay.\r\nQu'ils soient ressortis vivants ou non après leur peine.\r\nTous les détails sur les crimes qu'ils ont commis y figurent.\r\nComme une épitaphe, pour ainsi dire." },
            { "...A record of crimes and punishments...\r\nHow dispiriting.", "...Le registre des crimes et des châtiments...\r\nC'est bien sinistre." },
            { "(And yet...)\r\n(...this man seems to be enjoying tea and biscuits as he\r\ntalks about it.)", "(Et pourtant...)\r\n(...cet homme déguste son thé et ses biscuits comme si de rien n'était.)" }
        });

        // [65] KEY:BB\script\output\_sce03_bg0401_0_check_eng#8
        add(@"BB\script\output\_sce03_bg0401_0_check_eng#8", new string[,] {
            { "Ah, look, we have an opportunity here now, while the\r\ngovernor is away...", "Ah, regardez, voici notre chance pendant que le directeur\r\nest absent..." },
            { "Mr Naruhodo! You could be imprisoned if you were\r\ncaught!", "Monsieur Naruhodo ! Vous pourriez finir sous les verrous si vous\r\nétiez pris !" },
            { "(That's a good point. Perhaps not, then.)", "(Elle a raison. Laissons tomber, dans ce cas.)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Ep4_Act1_Part2.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part2 written.");
    }
}
