using System;
using System.IO;
using System.Text;

class MakeEp4Act1Part1 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act1 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart1() {");

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

        // [1] KEY:BB\script\output\_sce03_bg0200_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [2] KEY:BB\script\output\_sce03_bg0200_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#2", new string[,] {
            { "These very European suits of armour are still glaring at\r\neach other across the carpet, I see.", "Ces armures si typiquement européennes continuent de se dévisager\r\nde chaque côté du tapis, à ce que je vois." },
            { "In a way, they feel like guardians of the Lord Chief\r\nJustice's office.", "D'une certaine façon, on dirait des sentinelles gardant le bureau\r\ndu lord grand juge." },
            { "I suppose...they're rather like the lion-dogs that guard\r\nshrines in Japan, aren't they?", "J'imagine... qu'elles ressemblent un peu aux chiens-lions qui veillent\r\nsur les sanctuaires au Japon, n'est-ce pas ?" },
            { "...Aren't they a bit too human to be called ‘lion-dogs’?", "...Ne sont-elles pas un peu trop humaines pour être appelées « chiens-lions » ?" },
            { "Did you know that it's a dream of mine to keep two cats\r\none day?", "Saviez-vous que j'ai toujours rêvé d'adopter deux chats\r\nun jour ?" },
            { "I feel as though we've gone off at a bit of a tangent, don't\r\nyou?", "J'ai l'impression que nous nous égarons un peu, vous ne\r\ntrouvez pas ?" }
        });

        // [3] KEY:BB\script\output\_sce03_bg0200_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#3", new string[,] {
            { "You couldn't read all of these books even if you were\r\nreincarnated six times over as a bookworm!", "On ne pourrait pas lire tous ces livres, même en se réincarnant\r\nsix fois d'affilée en rat de bibliothèque !" },
            { "(Can Lord Stronghart really have read all of these?)", "(Lord Harry Caine peut-il vraiment avoir lu tout cela ?)" },
            { "Thinking about it...Father's study is full of books that look\r\nas though they've never been read, too.", "À bien y réfléchir... le cabinet de mon père déborde aussi de livres\r\nqui semblent n'avoir jamais été ouverts." },
            { "Oh, really?", "Ah, vraiment ?" },
            { "Pedlars of books are forever pushing their wares on him,\r\nyou see.", "C'est que des marchands ambulants lui forcent constamment la main,\r\nvoyez-vous." },
            { "And I think he's just too kind-hearted to refuse them.", "Et je crois qu'il a le cœur trop tendre pour leur refuser quoi que ce soit." },
            { "There's a phrase for that in Britain. People would say\r\nthey ‘saw him coming’.", "Il y a une expression pour cela ici. Les gens diraient\r\nqu'ils l'ont « vu venir de loin »." },
            { "It makes me wonder if perhaps the vast number of books\r\non the shelves in here...", "Je me demande si par hasard le nombre impressionnant d'ouvrages\r\nsur ces rayonnages..." },
            { "...are a sign of Lord Stronghart's overwhelming\r\nkind-heartedness.", "...ne serait pas le signe de l'immense bonté d'âme\r\nde Lord Harry Caine." },
            { "...I'm not sure you could afford to have a kind heart if you\r\nhad to keep Lord van Zieks in line, could you?", "...Je ne crois pas qu'on puisse se payer le luxe d'avoir le cœur tendre\r\nquand on doit tenir en bride Lord Van Peers, pas vrai ?" }
        });

        // [4] KEY:BB\script\output\_sce03_bg0200_0_check_eng#4
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#4", new string[,] {
            { "As ever, the enormous clock is diligently maintaining its\r\nrhythmical tick-tock today.", "Comme toujours, l'immense horloge égrène consciencieusement\r\nson tic-tac régulier aujourd'hui." },
            { "Watching machinery at work can be quite mesmerising,\r\ncan't it? Ironically, you can completely forget the time.", "Regarder de tels rouages peut être tout à fait fascinant,\r\nnon ? Ironiquement, on en oublie complètement l'heure." },
            { "What I particularly enjoy is watching the enormous\r\nwheels of a steam locomotive turning.", "Ce qui me plaît particulièrement, c'est regarder tourner les roues\r\ngigantesques d'une locomotive à vapeur." },
            { "When I was a little girl, Grandmother often used to take\r\nme to watch the railway engines, you know.", "Quand j'étais petite, Grand-mère m'emmenait souvent\r\nregarder passer les trains, vous savez." },
            { "It's an open fire for me. I could sit and watch the flames\r\nfor hours.", "Pour ma part, c'est un bon feu de cheminée. Je pourrais contempler les flammes\r\npendant des heures." },
            { "Mr Naruhodo! We could install one in the office!", "Monsieur Naruhodo ! Nous pourrions en installer un au cabinet !" },
            { "An enormous wheel, turned by an enormous steam\r\nengine!", "Une immense roue, entraînée par une gigantesque machine\r\nà vapeur !" },
            { "...Perhaps we could start with a simple fireplace?", "...Peut-être pourrions-nous commencer par un simple âtre ?" }
        });

        // [5] KEY:BB\script\output\_sce03_bg0200_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#5", new string[,] {
            { "Just sitting behind that desk must make you feel so\r\nimportant, don't you think?", "Rien que s'asseoir derrière ce bureau doit donner un tel sentiment\r\nd'importance, vous ne trouvez pas ?" },
            { "Would you like to have an office like this, Mr Naruhodo?\r\nWith such a grand desk?", "Aimeriez-vous avoir un bureau comme celui-ci, Monsieur Naruhodo ?\r\nAvec une table aussi imposante ?" },
            { "Who, me? No...I don't think so.", "Qui, moi ? Non... je ne crois pas." },
            { "Oh?", "Ah bon ?" },
            { "Well, imagine if you suddenly found yourself needing the\r\ntoilet. You'd have so far to go!", "Eh bien, imaginez qu'une envie pressante vous prenne soudain.\r\nIl y aurait tellement de chemin à parcourir !" },
            { "How...true.", "C'est... bien vrai." },
            { "Perhaps the important people who work in ostentatious\r\noffices like this haven't considered such things.", "Peut-être que les hauts dignitaires installés dans ces bureaux\r\nfastueux n'ont jamais songé à ces détails pratiques." },
            { "(...I'm going to take that as a compliment.)", "(...Je vais prendre cela comme un compliment.)" }
        });

        // [6] KEY:BB\script\output\_sce03_bg0200_0_check_eng#6
        add(@"BB\script\output\_sce03_bg0200_0_check_eng#6", new string[,] {
            { "I'm sorry for all the worry I've caused you.\r\nBut...it'll be alright now.", "Je vous demande pardon pour tous les soucis que je vous ai causés.\r\nMais... tout ira bien à présent." },
            { "Has your memory completely returned?", "Tes souvenirs te sont-ils entièrement revenus ?" },
            { "Yes, completely.\r\nI remember everything.", "Oui, tout à fait.\r\nJe me souviens de tout." },
            { "Including what I was coming here to do.", "Y compris de ce que j'étais venu faire ici." },
            { "Right...", "Je vois..." },
            { "Kazuma-sama...", "Monsieur Kiyô..." },
            { "...I can't tell you how happy I am to see you alive and well\r\nlike this.", "...Je ne saurais vous dire à quel point je suis heureuse de vous revoir\r\nsain et sauf ainsi." },
            { "But...how did you come to be here in London when you\r\nwere suffering from amnesia?", "Mais... comment vous êtes-vous retrouvé ici à Londres alors\r\nque vous aviez perdu la mémoire ?" },
            { "...It was the voice.", "...C'était la voix." },
            { "This past year...", "Pendant toute cette année passée..." },
            { "...I've been hearing it in my head constantly, saying the\r\nsame thing over and over:", "...je l'entendais sans cesse dans mon esprit, qui me répétait\r\ntoujours la même chose :" },
            { "‘Go to London. That's where your destiny awaits.’", "« Rends-toi à Londres. C'est là que ton destin t'attend. »" },
            { "It was that voice that guided me here to London.", "C'est cette voix qui m'a guidé jusqu'ici, à Londres." },
            { "I'm so sorry for what's happened...", "Je suis tellement désolée pour tout ce qui est arrivé..." },
            { "Anyway, my memory might have returned to me...", "Quoi qu'il en soit, même si mes souvenirs me sont revenus..." },
            { "...but there's something that won't return to the way it\r\nwas before.", "...il y a une chose qui ne redeviendra plus jamais\r\ncomme autrefois." },
            { "Huh?\r\nWhat do you mean?", "Hein ?\r\nQue veux-tu dire ?" },
            { "I'm a prosecutor now.\r\n...So I'm sure our paths will cross again very soon.", "Je suis désormais procureur.\r\n...Je suis donc certain que nos chemins vont se recroiser très bientôt." }
        });

        // [7] KEY:BB\script\output\_sce03_bg0204_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [8] KEY:BB\script\output\_sce03_bg0204_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#2", new string[,] {
            { "I've finally managed to remember this behemoth's name.\r\nThe Great Analytiscope.", "J'ai enfin réussi à mémoriser le nom de ce mastodonte.\r\nLe Grand Analytiscope." },
            { "I don't think it was here when I left for Japan, was it?", "Je ne crois pas qu'il fût là quand je suis partie pour le Japon, si ?" },
            { "Oh, is that right?", "Ah, vraiment ?" },
            { "Yes, because it was with the pawnbroker.", "Oui, car il avait été déposé chez le prêteur sur gages." },
            { "Ah, of course...", "Ah, évidemment..." },
            { "Oh! That's given me a wonderful idea!", "Oh ! Cela me donne une idée formidable !" },
            { "I could pawn everything that's on your desk!\r\nThe office would be tidy at last!", "Je pourrais mettre en gage tout ce qui traîne sur votre bureau !\r\nLe cabinet serait enfin ordonné !" },
            { "Don't even joke about it, Miss Susato.\r\n...You are joking...aren't you?", "Ne plaisantez même pas avec ça, Mademoiselle Susato.\r\n...Vous plaisantez... n'est-ce pas ?" }
        });

        // [9] KEY:BB\script\output\_sce03_bg0204_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#3", new string[,] {
            { "This is Mr Sholmes's famous violin.", "Voici le célèbre violon de M. Holmes." },
            { "The one he found being sold for a song at a pawnbrokery.\r\nWhat's it called again? A ‘Shodi-something’...", "Celui qu'il a déniché pour une bouchée de pain au mont-de-piété.\r\nComment s'appelle-t-il déjà ? Un « Stradi-machin »..." },
            { "Oh yes, this wonderful instrument features in ‘The\r\nAdventures of Herlock Sholmes’.", "Oh oui, ce magnifique instrument figure dans « Les\r\nAventures de Sherlock Holmes »." },
            { "It's a world-famous Stradivarius!", "C'est un mondialement célèbre Stradivarius !" },
            { "Stradi...what?", "Stradi... quoi ?" },
            { "Stradivarius, Mr Naruhodo.", "Stradivarius, Monsieur Naruhodo." },
            { "Stragi... Stragivor...", "Stragi... Stragivari..." },
            { "...Are you even trying now?", "...Faites-vous seulement un effort, là ?" },
            { "We'll come back to this another time, I think.", "Nous y reviendrons une autre fois, je crois bien." }
        });

        // [10] KEY:BB\script\output\_sce03_bg0204_0_check_eng#4
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#4", new string[,] {
            { "As it happens, I'm quite well practised when it comes to\r\nstacking shelves myself.", "Il se trouve que je suis moi-même assez expérimenté dans l'art\r\nd'empiler les étagères." },
            { "Just the other day, the shelf in my office finally gave way\r\nunder the strain, though.", "Mais l'autre jour, l'étagère de mon bureau a fini par céder\r\nsous le poids." },
            { "It looks as though it might topple, and it does.\r\nYes, the epitome of your disarray!", "Elle semblait prête à s'écrouler, et c'est ce qu'elle a fait.\r\nOui, la parfaite illustration de votre désordre !" },
            { "...I really don't get it.", "...Je ne comprends vraiment rien à tout ça." }
        });

        // [11] KEY:BB\script\output\_sce03_bg0204_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#5", new string[,] {
            { "My eye is always drawn to this big metal chest that\r\nMr Sholmes and Iris use as a coffee table.", "Mon regard est toujours attiré par cette grande malle en métal\r\nque M. Holmes et Iris utilisent comme table basse." },
            { "Isn't it where Iris keeps her very important papers?", "N'est-ce pas là qu'Iris conserve ses papiers les plus importants ?" },
            { "It is. So you'd think that they'd treat it with more care,\r\nreally.", "En effet. On pourrait donc penser qu'ils en prendraient plus grand\r\nsoin, à vrai dire." },
            { "But only the other day, I saw Mr Sholmes kick it.", "Mais l'autre jour encore, j'ai vu M. Holmes lui asséner un coup de pied." },
            { "Oh no!", "Oh non !" },
            { "I suppose something must have been frustrating him.", "J'imagine que quelque chose devait le contrarier." },
            { "What a shame to mistreat the furniture, though.\r\nWas it damaged?", "Quel dommage de maltraiter ainsi le mobilier.\r\nA-t-elle été abîmée ?" },
            { "The chest was fine, but Mr Sholmes was doubled up on\r\nthe floor for almost ten minutes!", "La malle n'a rien eu, mais M. Holmes est resté plié en deux sur\r\nle sol pendant près de dix minutes !" },
            { "Oh dear... That is a painful tale.", "Grand bien m'en fasse... Voilà une histoire bien douloureuse." }
        });

        // [12] KEY:BB\script\output\_sce03_bg0204_0_check_eng#6
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#6", new string[,] {
            { "I do like this fireplace. It's one of the best things I've seen\r\nsince we arrived in the country, in fact.", "J'apprécie beaucoup cette cheminée. C'est l'un des agréments les plus chaleureux\r\nque j'aie vus depuis notre arrivée ici." },
            { "Although...I do yearn for a Japanese kotatsu. Putting your\r\nlegs under a warm, blanketed table is so comforting.", "Quoique... un kotatsu japonais me manque un peu. Glisser ses\r\njambes sous une table chauffante et bien emmitouflée est si réconfortant." },
            { "Do be careful, Mr Naruhodo. Don't mistakenly put your\r\nfeet into the fire, will you?", "Soyez prudent, Monsieur Naruhodo. N'allez pas par mégarde étendre\r\nvos pieds dans le foyer, n'est-ce pas ?" },
            { "You'd suffer terrible burns, you know.", "Vous subiriez de cruelles brûlures, vous savez." },
            { "(I worry sometimes about how Susato-san sees me...)", "(Je m'inquiète parfois de l'image que Mademoiselle Susato a de moi...)" }
        });

        // [13] KEY:BB\script\output\_sce03_bg0204_0_check_eng#7
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#7", new string[,] {
            { "Ah yes, Mr Sholmes's curious collection of trinkets from\r\nthe various mysteries he's solved.", "Ah oui, l'étrange assortiment de curiosités récoltées par M. Holmes\r\nau fil des mystères qu'il a résolus." },
            { "It's one of my favourite parts of this room.\r\nFull of items with such exciting tales to tell!", "C'est l'un de mes recoins préférés dans ce salon.\r\nTous ces objets ont de si palpitantes aventures à conter !" },
            { "And I do believe he's added to it since I last looked.", "Et je crois bien qu'il l'a encore enrichi depuis mon dernier coup d'œil." },
            { "Now there's a mysterious pince-nez, a mysterious little\r\nbox, a mysterious horseshoe, a mysterious biscuit...", "Il y a désormais un mystérieux pince-nez, une mystérieuse boîte,\r\nun mystérieux fer à cheval, un mystérieux biscuit..." },
            { "I think that last one might just be one of Iris's unfinished\r\nsnacks.", "Je crois que ce dernier n'est qu'un goûter qu'Iris n'a pas\r\nterminé." }
        });

        // [14] KEY:BB\script\output\_sce03_bg0204_0_check_eng#8
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#8", new string[,] {
            { "Iris's pretty little tea set is set out beautifully as ever,\r\nlook.", "Le ravissant petit service à thé d'Iris est toujours aussi impeccablement\r\ndisposé, regardez." },
            { "Well, it's only by carefully taking care of a tea set that\r\nyou can make good tea.", "Eh bien, ce n'est qu'en apportant un soin jaloux à son service que\r\nl'on peut préparer un bon thé." },
            { "Is...that a roundabout way of telling me I need to tidy my\r\ndesk?", "Est-ce... une manière détournée de me faire remarquer que je devrais\r\nranger mon bureau ?" },
            { "Oh, Mr Naruhodo, you do overthink things at times.", "Oh, Monsieur Naruhodo, vous cherchez vraiment midi à quatorze heures parfois." }
        });

        // [15] KEY:BB\script\output\_sce03_bg0204_0_check_eng#9
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#9", new string[,] {
            { "If I've remembered correctly, this large and imposing\r\nlump of iron is called a ‘typewriter’.", "Si mes souvenirs sont bons, cet imposant bloc de ferraille\r\ns'appelle une « machine à écrire »." },
            { "To think that every single one of ‘The Adventures of\r\nHerlock Sholmes’ blossomed from this very machine!", "Dire que chacun des récits des « Aventures de\r\nSherlock Holmes » a pris vie sur cette machine !" },
            { "Ah...it's such a dreamy thought...", "Ah... quelle merveilleuse pensée..." },
            { "I actually had a go on it the other day.", "J'ai justement essayé de m'en servir l'autre jour." },
            { "The metal bars that move when you hit the keys got all\r\ntangled up somehow and that made Iris angry.", "Les tiges qui montent quand on frappe sur les touches se sont\r\ntoutes emmêlées, et Iris s'est fâchée tout rouge." },
            { "Mr Naruhodo...", "Monsieur Naruhodo..." },
            { "...you're ruining my dreamy thoughts.\r\nPlease don't do that again.", "...vous gâchez mes songes poétiques.\r\nNe recommencez plus jamais ça." },
            { "(Ugh...now I've made Susato-san angry as well...)", "(Argh... voilà que j'ai fâché Mademoiselle Susato aussi...)" }
        });

        // [16] KEY:BB\script\output\_sce03_bg0204_0_check_eng#10
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#10", new string[,] {
            { "That's Iris's wonderful collection of medicines, potions and\r\nchemicals.", "C'est la prodigieuse collection de remèdes, potions et poudres\r\nchimiques d'Iris." },
            { "Just look at all the little bottles she's squeezed onto the\r\nshelves.", "Regardez toutes ces petites fioles entassées sur les étagères." },
            { "Yes, and there are charming little ribbons tied around the\r\nbottles, too.", "Oui, et de ravissants petits rubans sont noués autour des cols,\r\nen plus." },
            { "But the labels aren't quite so charming, are they?\r\nThis one here reads ‘Deadly Poison’.", "Mais les étiquettes ne sont pas tout à fait aussi charmantes, n'est-ce pas ?\r\nCelle-ci indique « Poison mortel »." },
            { "Oh, I've been so excited about the idea of helping Iris with\r\nher experiments, you know!", "Oh, j'étais si impatiente d'aider Iris dans ses expériences,\r\nvous savez !" },
            { "Just try to avoid any bottles labelled ‘Deadly Poison’ or\r\n‘Highly Explosive’.", "Veillez simplement à éviter les flacons étiquetés « Poison mortel » ou\r\n« Hautement explosif »." }
        });

        // [17] KEY:BB\script\output\_sce03_bg0204_0_check_eng#11
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#11", new string[,] {
            { "This blackboard is where Iris scribbles down her latest\r\nideas, isn't it?", "C'est sur ce tableau noir qu'Iris gribouille ses dernières\r\nidées, n'est-ce pas ?" },
            { "Let's see... Oh, she seems to have drawn a lot of little stick\r\nfigures all lined up, look.", "Voyons... Oh, elle a dessiné toute une rangée de petits bonshommes\r\nallumettes, regardez." },
            { "‘Cheap apples at the market’ is what all of them say.", "« Pommes au rabais au marché », voilà ce qu'ils disent tous." },
            { "What?! The little figures can speak?!", "Quoi ?! Ces petits bonshommes savent parler ?!" },
            { "All your questions would be answered if only you would\r\nread this month's Randst Magazine.", "Toutes vos questions trouveraient réponse si seulement vous lisiez\r\nle Randst Magazine de ce mois-ci." },
            { "(...So I'm the only one who can't make any sense of this?)", "(...Je suis donc le seul à n'y rien comprendre ?)" }
        });

        // [18] KEY:BB\script\output\_sce03_bg0204_0_check_eng#12
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#12", new string[,] {
            { "This looks like last week's edition.", "On dirait l'édition de la semaine dernière." },
            { "What's that article circled in red ink there?", "Quel est cet article entouré à l'encre rouge, là ?" },
            { "It's in an advertisement column.\r\nIt says...", "C'est dans la colonne des réclames.\r\nIl est écrit..." },
            { "‘To the Red-Headed League’!", "« À la Ligue des Rouquins » !" },
            { "The Red-Headed League?\r\nWhat's that?", "La Ligue des Rouquins ?\r\nQu'est-ce que c'est ?" },
            { "I don't know.\r\nI've never heard of it before, but...", "Je ne sais pas.\r\nJe n'en ai jamais entendu parler, mais..." },
            { "Is something on my face?", "J'ai quelque chose sur le visage ?" },
            { "(Clearly this has something to do with that...lively hair.)", "(Cela a manifestement un lien avec cette... crinière flamboyante.)" },
            { "The Red-Headed League article has been\r\nentered into the Court Record.", "L'article sur la Ligue des Rouquins a été\r\nconsigné dans le dossier." }
        });

        // [19] KEY:BB\script\output\_sce03_bg0204_0_check_eng#13
        add(@"BB\script\output\_sce03_bg0204_0_check_eng#13", new string[,] {
            { "...The mask Kazuma wore when he was assigned to Lord\r\nvan Zieks as his apprentice.", "...Le masque que portait Kazuma lorsqu'il était affecté auprès\r\nde Lord Van Peers comme apprenti." },
            { "When he cast it aside after the trial the other day, I just\r\nsort of picked it up.", "Quand il l'a jeté après le procès l'autre jour, je l'ai\r\nsimplement ramassé." },
            { "We ought to give it back to him, I suppose.", "Nous devrions le lui rendre, j'imagine." },
            { "But he has his memory back now, doesn't he?", "Mais sa mémoire lui est revenue maintenant, n'est-ce pas ?" },
            { "And I can't help feeling he might turn around and tell me\r\ncoldly to wear it myself...", "Et je crains qu'il ne se retourne pour me dire froidement\r\nde le porter moi-même..." },
            { "But...isn't he your best friend?", "Mais... n'est-il pas votre meilleur ami ?" }
        });

        // [20] KEY:BB\script\output\_sce03_bg0204_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0204_1_check_eng#1", new string[,] {
            { "Who'd have thought Professor Mikotoba would wear\r\nsomething like this?", "Qui aurait pu croire que le professeur Mikotoba porterait\r\nune chose pareille ?" },
            { "Life can be...very unexpected sometimes.", "La vie peut être... pleine d'imprévus, parfois." },
            { "You know, in tomorrow's trial, it might be an idea...\r\n...if you wore this, Miss Susato.", "Vous savez, lors du procès de demain, ce serait une idée...\r\n...si vous portiez cela, Mademoiselle Susato." },
            { "Hm?!", "Hein ?!" },
            { "I'm sure Kazuma would be thunderstruck.", "Je suis certain que Kazuma en resterait foudroyé." },
            { "I've no doubt he would. But...\r\n...I'm not sure I'm quite up to it.", "Je n'en doute pas un instant. Mais...\r\n...je ne suis pas sûre d'avoir le cran pour cela." }
        });

        // [21] KEY:BB\script\output\_sce03_bg0206_0_00_eng#4
        add(@"BB\script\output\_sce03_bg0206_0_00_eng#4", new string[,] {
            { "1st November\r\nNaruhodo's Legal Consultancy", "1er novembre\r\nCabinet d'avocats Naruhodo" }
        });

        // [22] KEY:BB\script\output\_sce03_bg0206_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à noter...)" }
        });

        // [23] KEY:BB\script\output\_sce03_bg0206_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#2", new string[,] {
            { "My desk is just as it was before I left.", "Mon bureau est exactement tel qu'il était avant mon départ." },
            { "Sumi ink and a calligraphy brush...even though we're in\r\nEngland now.", "De l'encre de Chine et un pinceau de calligraphie... alors même que\r\nnous sommes en Angleterre à présent." },
            { "That strikes me as typically you, Miss Susato, and\r\ntypically not you at the same time, somehow.", "Cela me semble tellement typique de vous, Mademoiselle Susato, et pas\r\ndu tout à la fois, bizarrement." }
        });

        // [24] KEY:BB\script\output\_sce03_bg0206_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#3", new string[,] {
            { "You see? I've been keeping my desk beautifully covered\r\nin papers as always.", "Vous voyez ? J'ai gardé mon bureau harmonieusement enseveli\r\nsous les papiers, comme toujours." },
            { "You really must tidy it all up, Mr Naruhodo.\r\nNo more excuses.", "Vous devez absolument faire de l'ordre, Monsieur Naruhodo.\r\nAssez d'excuses." },
            { "But Miss Susato, the way I see it...", "Mais Mademoiselle Susato, à mes yeux..." },
            { "...all these papers building up on my desk like this are a\r\nreminder of my wonderfully diverse daily life.", "...tous ces papiers qui s'entassent sur mon bureau témoignent\r\nde la richesse de mon quotidien." },
            { "I like to leave them as they are so I never forget how\r\nlucky I am to have such varied experiences.", "J'aime les laisser ainsi pour ne jamais oublier la chance\r\nque j'ai de vivre tant d'aventures variées." },
            { "In that case, you should definitely have a thorough tidy.", "Dans ce cas, vous devriez incontestablement tout ranger de fond en comble." },
            { "Then you'll be able to see your papers building up all\r\nover again and feel that joy renewed.", "Ainsi vous aurez le plaisir de voir les papiers s'accumuler\r\nà nouveau et d'éprouver cette joie renouvelée." },
            { "(Still can't beat her in an argument.\r\nEven though I'm the lawyer here...)", "(Toujours impossible d'avoir le dessus sur elle.\r\nEt dire que c'est moi l'avocat...)" }
        });

        // [25] KEY:BB\script\output\_sce03_bg0206_0_check_eng#4
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#4", new string[,] {
            { "That daruma doll is still winking at me, look.", "Ce daruma continue de me faire un clin d'œil, regardez." },
            { "I wonder when he'll finally get his other eye filled in...", "Je me demande quand on lui dessinera enfin son autre œil..." },
            { "Yes, I wonder...", "Oui, je me le demande..." },
            { "(Well you should know, Susato-san.\r\nI entrusted the task to you.)", "(Eh bien vous devriez le savoir, Mademoiselle Susato.\r\nJe vous ai confié cette tâche.)" },
            { "The truth is...", "La vérité est que..." },
            { "...I have already decided when that will be.", "...j'ai déjà décidé du moment propice." },
            { "What?! Really?\r\nWhen?", "Quoi ?! Vraiment ?\r\nQuand ?" },
            { "...That's my little secret.", "...C'est mon petit secret." }
        });

        // [26] KEY:BB\script\output\_sce03_bg0206_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#5", new string[,] {
            { "The steam is rising gently from the kettle as always.", "La vapeur s'élève doucement de la bouilloire, comme toujours." },
            { "Yes. It doesn't feel right somehow unless it is.", "Oui. Il manquerait quelque chose si elle ne fumait pas." },
            { "But...the steam has an unusual scent today.", "Mais... la vapeur a un parfum inhabituel aujourd'hui." },
            { "Perhaps the sweet potatoes that I brought back from Japan\r\nwith me are ready.", "Peut-être que les patates douces rapportées du Japon\r\nsont cuites à point." },
            { "*Gulp...*", "*Gloup...*" },
            { "Oh, Mr Naruhodo! I heard that, you know!", "Oh, Monsieur Naruhodo ! J'ai très bien entendu, vous savez !" },
            { "Tears of joy, Miss Susato.\r\nFrom my mouth.", "Des larmes d'émotion, Mademoiselle Susato.\r\nQui me montent à la bouche." }
        });

        // [27] KEY:BB\script\output\_sce03_bg0206_0_check_eng#6
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#6", new string[,] {
            { "The spade is still here, look.", "La bêche est toujours là, regardez." },
            { "Please, Mr Naruhodo. It's not a spade, as I think you well\r\nknow. It's a shovel.", "De grâce, Monsieur Naruhodo. Ce n'est pas une bêche, comme vous\r\nle savez pertinemment. C'est une pelle." },
            { "(It didn't take long to reignite that old argument.)", "(Il n'aura pas fallu longtemps pour ranimer ce vieux débat.)" },
            { "Ah, I have an idea!", "Ah, j'ai une idée !" },
            { "Let's give the implement a name, like Professor\r\nHarebrayne named his tools.", "Donnons un petit nom à cet outil, comme le professeur\r\nLonron baptisait les siens." },
            { "Ooh! I never thought of doing that.", "Oh ! Je n'aurais jamais pensé à faire une chose pareille." },
            { "From now on, then, let's call it ‘Ryunosuke’.", "Dès lors, appelons-la donc « Ryunosuke »." },
            { "No no no no! It's clearly much more of a ‘Susato’!", "Non non non non ! Elle ressemble bien plus à une « Susato » !" },
            { "(The old argument has taken a new and unexpected turn,\r\nit seems...)", "(Cette vieille querelle prend une tournure pour le moins\r\ninattendue, dirait-on...)" }
        });

        // [28] KEY:BB\script\output\_sce03_bg0206_0_check_eng#7
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#7", new string[,] {
            { "Whenever you serve me tea, it always takes me back to\r\nJapan.", "Chaque fois que vous me servez du thé, cela me ramène\r\nau Japon." },
            { "I know you're not particularly fond of the bitter taste, are\r\nyou?", "Je sais que vous n'avez pas un faible pour l'amertume,\r\nn'est-ce pas ?" },
            { "So I do always try to pick out less bitter matcha for you.", "Alors je veille toujours à sélectionner pour vous un matcha plus doux." },
            { "(She does often serve up an unusually mellow blend, it's\r\ntrue.)", "(C'est vrai qu'elle prépare souvent une infusion d'une douceur inhabituelle.)" },
            { "(But the anticipation of the taste in my mouth makes me\r\nbitterly worried anyway...)", "(Mais l'appréhension de son goût sur mon palais m'emplit\r\nd'une amère angoisse malgré tout...)" },
            { "It is very difficult for you, isn't it?", "C'est une terrible épreuve pour vous, n'est-ce pas ?" }
        });

        // [29] KEY:BB\script\output\_sce03_bg0206_0_check_eng#8
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#8", new string[,] {
            { "All the sea life seem very content in there, I must say.", "Toutes ces créatures marines ont l'air très heureuses là-dedans, je dois dire." },
            { "I've noticed something recently, actually...\r\nThe anemones breed at a most extraordinary rate.", "J'ai remarqué une chose récemment, à vrai dire...\r\nLes anémones prolifèrent à un rythme absolument stupéfiant." },
            { "Oh, really?", "Oh, vraiment ?" },
            { "It's a mystery why the whole seabed isn't buried in a\r\nmountain of them, actually.", "C'est un mystère que le fond marin ne disparaisse pas sous\r\nune montagne d'anémones, en fait." },
            { "Oh, how splendid!\r\nThat really is a mystery, isn't it?", "Oh, comme c'est merveilleux !\r\nVoilà une véritable énigme, n'est-ce pas ?" },
            { "(I wish there was someone here to explain Susato-san's\r\nstrange reaction to that.)", "(J'aimerais bien que quelqu'un m'explique la curieuse\r\nréaction de Mademoiselle Susato à ce propos.)" }
        });

        // [30] KEY:BB\script\output\_sce03_bg0206_0_check_eng#9
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#9", new string[,] {
            { "Your room across the hall is undisturbed, of course.", "Votre chambre de l'autre côté du palier est restée intacte, bien sûr." },
            { "I don't suppose I'd be permitted to see inside now that\r\nyou're back though, would I?", "Je ne suppose pas qu'il me soit permis d'y jeter un œil maintenant\r\nque vous êtes revenue, si ?" },
            { "You know very well that only Iris is allowed inside.", "Vous savez pertinemment que seule Iris y est autorisée." },
            { "(Yes, I heard you two giggling together in there again last\r\nnight.)", "(Oui, je vous ai encore entendues glousser toutes les deux là-dedans\r\nhier soir.)" },
            { "You can visit Mr Sholmes in his room, Mr Naruhodo.", "Vous pouvez aller voir M. Holmes dans sa chambre, Monsieur Naruhodo." },
            { "Last time I did that, he tried to convince me to drink some\r\nstrange concoction he'd mixed up.", "La dernière fois que j'ai fait ça, il a tenté de me faire avaler une\r\nmixture suspecte qu'il venait d'inventer." }
        });

        // [31] KEY:BB\script\output\_sce03_bg0206_0_check_eng#10
        add(@"BB\script\output\_sce03_bg0206_0_check_eng#10", new string[,] {
            { "It's a lovely photograph we took together when I had to\r\nleave London. Though it was a sad day.", "C'est une très belle photographie que nous avons prise ensemble lorsque j'ai dû\r\nquitter Londres. Même si ce fut une triste journée." },
            { "But I happily have the same photograph on display in my\r\nroom at home, you know.", "Mais j'ai heureusement la même photo exposée dans ma\r\nchambre chez moi, vous savez." },
            { "Now that we're all back together again...\r\n...it would be nice to take a new photograph.", "Maintenant que nous voilà à nouveau réunis...\r\n...ce serait une bonne idée d'en prendre une nouvelle." },
            { "Oh yes! That would be wonderful!", "Oh oui ! Ce serait formidable !" }
        });

        // [32] KEY:BB\script\output\_sce03_bg0206_1_00_eng#6
        add(@"BB\script\output\_sce03_bg0206_1_00_eng#6", new string[,] {
            { "2nd November\r\nNaruhodo's Legal Consultancy", "2 novembre\r\nCabinet d'avocats Naruhodo" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Ep4_Act1_Part1.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part1 written.");
    }
}
