using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act1 {
    public partial class Program {
        public static void RegisterPart1() {
            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à noter...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("These very European suits of armour are still glaring at\r\neach other across the carpet, I see.", "Ces armures si typiquement européennes continuent de se dévisager\r\nde chaque côté du tapis, à ce que je vois.");
                s = s.Replace("In a way, they feel like guardians of the Lord Chief\r\nJustice's office.", "D'une certaine façon, on dirait des sentinelles gardant le bureau\r\ndu lord grand juge.");
                s = s.Replace("I suppose...they're rather like the lion-dogs that guard\r\nshrines in Japan, aren't they?", "J'imagine... qu'elles ressemblent un peu aux chiens-lions qui veillent\r\nsur les sanctuaires au Japon, n'est-ce pas ?");
                s = s.Replace("...Aren't they a bit too human to be called ‘lion-dogs’?", "...Ne sont-elles pas un peu trop humaines pour être appelées « chiens-lions » ?");
                s = s.Replace("Did you know that it's a dream of mine to keep two cats\r\none day?", "Saviez-vous que j'ai toujours rêvé d'adopter deux chats\r\nun jour ?");
                s = s.Replace("I feel as though we've gone off at a bit of a tangent, don't\r\nyou?", "J'ai l'impression que nous nous égarons un peu, vous ne\r\ntrouvez pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("You couldn't read all of these books even if you were\r\nreincarnated six times over as a bookworm!", "On ne pourrait pas lire tous ces livres, même en se réincarnant\r\nsix fois d'affilée en rat de bibliothèque !");
                s = s.Replace("(Can Lord Stronghart really have read all of these?)", "(Lord Harry Caine peut-il vraiment avoir lu tout cela ?)");
                s = s.Replace("Thinking about it...Father's study is full of books that look\r\nas though they've never been read, too.", "À bien y réfléchir... le cabinet de mon père déborde aussi de livres\r\nqui semblent n'avoir jamais été ouverts.");
                s = s.Replace("Oh, really?", "Ah, vraiment ?");
                s = s.Replace("Pedlars of books are forever pushing their wares on him,\r\nyou see.", "C'est que des marchands ambulants lui forcent constamment la main,\r\nvoyez-vous.");
                s = s.Replace("And I think he's just too kind-hearted to refuse them.", "Et je crois qu'il a le cœur trop tendre pour leur refuser quoi que ce soit.");
                s = s.Replace("There's a phrase for that in Britain. People would say\r\nthey ‘saw him coming’.", "Il y a une expression pour cela ici. Les gens diraient\r\nqu'ils l'ont « vu venir de loin ».");
                s = s.Replace("It makes me wonder if perhaps the vast number of books\r\non the shelves in here...", "Je me demande si par hasard le nombre impressionnant d'ouvrages\r\nsur ces rayonnages...");
                s = s.Replace("...are a sign of Lord Stronghart's overwhelming\r\nkind-heartedness.", "...ne serait pas le signe de l'immense bonté d'âme\r\nde Lord Harry Caine.");
                s = s.Replace("...I'm not sure you could afford to have a kind heart if you\r\nhad to keep Lord van Zieks in line, could you?", "...Je ne crois pas qu'on puisse se payer le luxe d'avoir le cœur tendre\r\nquand on doit tenir en bride Lord Van Peers, pas vrai ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("As ever, the enormous clock is diligently maintaining its\r\nrhythmical tick-tock today.", "Comme toujours, l'immense horloge égrène consciencieusement\r\nson tic-tac régulier aujourd'hui.");
                s = s.Replace("Watching machinery at work can be quite mesmerising,\r\ncan't it? Ironically, you can completely forget the time.", "Regarder de tels rouages peut être tout à fait fascinant,\r\nnon ? Ironiquement, on en oublie complètement l'heure.");
                s = s.Replace("What I particularly enjoy is watching the enormous\r\nwheels of a steam locomotive turning.", "Ce qui me plaît particulièrement, c'est regarder tourner les roues\r\ngigantesques d'une locomotive à vapeur.");
                s = s.Replace("When I was a little girl, Grandmother often used to take\r\nme to watch the railway engines, you know.", "Quand j'étais petite, Grand-mère m'emmenait souvent\r\nregarder passer les trains, vous savez.");
                s = s.Replace("It's an open fire for me. I could sit and watch the flames\r\nfor hours.", "Pour ma part, c'est un bon feu de cheminée. Je pourrais contempler les flammes\r\npendant des heures.");
                s = s.Replace("Mr Naruhodo! We could install one in the office!", "Monsieur Naruhodo ! Nous pourrions en installer un au cabinet !");
                s = s.Replace("An enormous wheel, turned by an enormous steam\r\nengine!", "Une immense roue, entraînée par une gigantesque machine\r\nà vapeur !");
                s = s.Replace("...Perhaps we could start with a simple fireplace?", "...Peut-être pourrions-nous commencer par un simple âtre ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Just sitting behind that desk must make you feel so\r\nimportant, don't you think?", "Rien que s'asseoir derrière ce bureau doit donner un tel sentiment\r\nd'importance, vous ne trouvez pas ?");
                s = s.Replace("Would you like to have an office like this, Mr Naruhodo?\r\nWith such a grand desk?", "Aimeriez-vous avoir un bureau comme celui-ci, Monsieur Naruhodo ?\r\nAvec une table aussi imposante ?");
                s = s.Replace("Who, me? No...I don't think so.", "Qui, moi ? Non... je ne crois pas.");
                s = s.Replace("Oh?", "Ah bon ?");
                s = s.Replace("Well, imagine if you suddenly found yourself needing the\r\ntoilet. You'd have so far to go!", "Eh bien, imaginez qu'une envie pressante vous prenne soudain.\r\nIl y aurait tellement de chemin à parcourir !");
                s = s.Replace("How...true.", "C'est... bien vrai.");
                s = s.Replace("Perhaps the important people who work in ostentatious\r\noffices like this haven't considered such things.", "Peut-être que les hauts dignitaires installés dans ces bureaux\r\nfastueux n'ont jamais songé à ces détails pratiques.");
                s = s.Replace("(...I'm going to take that as a compliment.)", "(...Je vais prendre cela comme un compliment.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0200_0_check_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("I'm sorry for all the worry I've caused you.\r\nBut...it'll be alright now.", "Je vous demande pardon pour tous les soucis que je vous ai causés.\r\nMais... tout ira bien à présent.");
                s = s.Replace("Has your memory completely returned?", "Tes souvenirs te sont-ils entièrement revenus ?");
                s = s.Replace("Yes, completely.\r\nI remember everything.", "Oui, tout à fait.\r\nJe me souviens de tout.");
                s = s.Replace("Including what I was coming here to do.", "Y compris de ce que j'étais venu faire ici.");
                s = s.Replace("Right...", "Je vois...");
                s = s.Replace("Kazuma-sama...", "Monsieur Kiyô...");
                s = s.Replace("...I can't tell you how happy I am to see you alive and well\r\nlike this.", "...Je ne saurais vous dire à quel point je suis heureuse de vous revoir\r\nsain et sauf ainsi.");
                s = s.Replace("But...how did you come to be here in London when you\r\nwere suffering from amnesia?", "Mais... comment vous êtes-vous retrouvé ici à Londres alors\r\nque vous aviez perdu la mémoire ?");
                s = s.Replace("...It was the voice.", "...C'était la voix.");
                s = s.Replace("This past year...", "Pendant toute cette année passée...");
                s = s.Replace("...I've been hearing it in my head constantly, saying the\r\nsame thing over and over:", "...je l'entendais sans cesse dans mon esprit, qui me répétait\r\ntoujours la même chose :");
                s = s.Replace("‘Go to London. That's where your destiny awaits.’", "« Rends-toi à Londres. C'est là que ton destin t'attend. »");
                s = s.Replace("It was that voice that guided me here to London.", "C'est cette voix qui m'a guidé jusqu'ici, à Londres.");
                s = s.Replace("I'm so sorry for what's happened...", "Je suis tellement désolée pour tout ce qui est arrivé...");
                s = s.Replace("Anyway, my memory might have returned to me...", "Quoi qu'il en soit, même si mes souvenirs me sont revenus...");
                s = s.Replace("...but there's something that won't return to the way it\r\nwas before.", "...il y a une chose qui ne redeviendra plus jamais\r\ncomme autrefois.");
                s = s.Replace("Huh?\r\nWhat do you mean?", "Hein ?\r\nQue veux-tu dire ?");
                s = s.Replace("I'm a prosecutor now.\r\n...So I'm sure our paths will cross again very soon.", "Je suis désormais procureur.\r\n...Je suis donc certain que nos chemins vont se recroiser très bientôt.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à noter...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I've finally managed to remember this behemoth's name.\r\nThe Great Analytiscope.", "J'ai enfin réussi à mémoriser le nom de ce mastodonte.\r\nLe Grand Analytiscope.");
                s = s.Replace("I don't think it was here when I left for Japan, was it?", "Je ne crois pas qu'il fût là quand je suis partie pour le Japon, si ?");
                s = s.Replace("Oh, is that right?", "Ah, vraiment ?");
                s = s.Replace("Yes, because it was with the pawnbroker.", "Oui, car il avait été déposé chez le prêteur sur gages.");
                s = s.Replace("Ah, of course...", "Ah, évidemment...");
                s = s.Replace("Oh! That's given me a wonderful idea!", "Oh ! Cela me donne une idée formidable !");
                s = s.Replace("I could pawn everything that's on your desk!\r\nThe office would be tidy at last!", "Je pourrais mettre en gage tout ce qui traîne sur votre bureau !\r\nLe cabinet serait enfin ordonné !");
                s = s.Replace("Don't even joke about it, Miss Susato.\r\n...You are joking...aren't you?", "Ne plaisantez même pas avec ça, Mademoiselle Susato.\r\n...Vous plaisantez... n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("This is Mr Sholmes's famous violin.", "Voici le célèbre violon de M. Holmes.");
                s = s.Replace("The one he found being sold for a song at a pawnbrokery.\r\nWhat's it called again? A ‘Shodi-something’...", "Celui qu'il a déniché pour une bouchée de pain au mont-de-piété.\r\nComment s'appelle-t-il déjà ? Un « Stradi-machin »...");
                s = s.Replace("Oh yes, this wonderful instrument features in ‘The\r\nAdventures of Herlock Sholmes’.", "Oh oui, ce magnifique instrument figure dans « Les\r\nAventures de Sherlock Holmes ».");
                s = s.Replace("It's a world-famous Stradivarius!", "C'est un mondialement célèbre Stradivarius !");
                s = s.Replace("Stradi...what?", "Stradi... quoi ?");
                s = s.Replace("Stradivarius, Mr Naruhodo.", "Stradivarius, Monsieur Naruhodo.");
                s = s.Replace("Stragi... Stragivor...", "Stragi... Stragivari...");
                s = s.Replace("...Are you even trying now?", "...Faites-vous seulement un effort, là ?");
                s = s.Replace("We'll come back to this another time, I think.", "Nous y reviendrons une autre fois, je crois bien.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("As it happens, I'm quite well practised when it comes to\r\nstacking shelves myself.", "Il se trouve que je suis moi-même assez expérimenté dans l'art\r\nd'empiler les étagères.");
                s = s.Replace("Just the other day, the shelf in my office finally gave way\r\nunder the strain, though.", "Mais l'autre jour, l'étagère de mon bureau a fini par céder\r\nsous le poids.");
                s = s.Replace("It looks as though it might topple, and it does.\r\nYes, the epitome of your disarray!", "Elle semblait prête à s'écrouler, et c'est ce qu'elle a fait.\r\nOui, la parfaite illustration de votre désordre !");
                s = s.Replace("...I really don't get it.", "...Je ne comprends vraiment rien à tout ça.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("My eye is always drawn to this big metal chest that\r\nMr Sholmes and Iris use as a coffee table.", "Mon regard est toujours attiré par cette grande malle en métal\r\nque M. Holmes et Iris utilisent comme table basse.");
                s = s.Replace("Isn't it where Iris keeps her very important papers?", "N'est-ce pas là qu'Iris conserve ses papiers les plus importants ?");
                s = s.Replace("It is. So you'd think that they'd treat it with more care,\r\nreally.", "En effet. On pourrait donc penser qu'ils en prendraient plus grand\r\nsoin, à vrai dire.");
                s = s.Replace("But only the other day, I saw Mr Sholmes kick it.", "Mais l'autre jour encore, j'ai vu M. Holmes lui asséner un coup de pied.");
                s = s.Replace("Oh no!", "Oh non !");
                s = s.Replace("I suppose something must have been frustrating him.", "J'imagine que quelque chose devait le contrarier.");
                s = s.Replace("What a shame to mistreat the furniture, though.\r\nWas it damaged?", "Quel dommage de maltraiter ainsi le mobilier.\r\nA-t-elle été abîmée ?");
                s = s.Replace("The chest was fine, but Mr Sholmes was doubled up on\r\nthe floor for almost ten minutes!", "La malle n'a rien eu, mais M. Holmes est resté plié en deux sur\r\nle sol pendant près de dix minutes !");
                s = s.Replace("Oh dear... That is a painful tale.", "Grand bien m'en fasse... Voilà une histoire bien douloureuse.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("I do like this fireplace. It's one of the best things I've seen\r\nsince we arrived in the country, in fact.", "J'apprécie beaucoup cette cheminée. C'est l'un des agréments les plus chaleureux\r\nque j'aie vus depuis notre arrivée ici.");
                s = s.Replace("Although...I do yearn for a Japanese kotatsu. Putting your\r\nlegs under a warm, blanketed table is so comforting.", "Quoique... un kotatsu japonais me manque un peu. Glisser ses\r\njambes sous une table chauffante et bien emmitouflée est si réconfortant.");
                s = s.Replace("Do be careful, Mr Naruhodo. Don't mistakenly put your\r\nfeet into the fire, will you?", "Soyez prudent, Monsieur Naruhodo. N'allez pas par mégarde étendre\r\nvos pieds dans le foyer, n'est-ce pas ?");
                s = s.Replace("You'd suffer terrible burns, you know.", "Vous subiriez de cruelles brûlures, vous savez.");
                s = s.Replace("(I worry sometimes about how Susato-san sees me...)", "(Je m'inquiète parfois de l'image que Mademoiselle Susato a de moi...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Ah yes, Mr Sholmes's curious collection of trinkets from\r\nthe various mysteries he's solved.", "Ah oui, l'étrange assortiment de curiosités récoltées par M. Holmes\r\nau fil des mystères qu'il a résolus.");
                s = s.Replace("It's one of my favourite parts of this room.\r\nFull of items with such exciting tales to tell!", "C'est l'un de mes recoins préférés dans ce salon.\r\nTous ces objets ont de si palpitantes aventures à conter !");
                s = s.Replace("And I do believe he's added to it since I last looked.", "Et je crois bien qu'il l'a encore enrichi depuis mon dernier coup d'œil.");
                s = s.Replace("Now there's a mysterious pince-nez, a mysterious little\r\nbox, a mysterious horseshoe, a mysterious biscuit...", "Il y a désormais un mystérieux pince-nez, une mystérieuse boîte,\r\nun mystérieux fer à cheval, un mystérieux biscuit...");
                s = s.Replace("I think that last one might just be one of Iris's unfinished\r\nsnacks.", "Je crois que ce dernier n'est qu'un goûter qu'Iris n'a pas\r\nterminé.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Iris's pretty little tea set is set out beautifully as ever,\r\nlook.", "Le ravissant petit service à thé d'Iris est toujours aussi impeccablement\r\ndisposé, regardez.");
                s = s.Replace("Well, it's only by carefully taking care of a tea set that\r\nyou can make good tea.", "Eh bien, ce n'est qu'en apportant un soin jaloux à son service que\r\nl'on peut préparer un bon thé.");
                s = s.Replace("Is...that a roundabout way of telling me I need to tidy my\r\ndesk?", "Est-ce... une manière détournée de me faire remarquer que je devrais\r\nranger mon bureau ?");
                s = s.Replace("Oh, Mr Naruhodo, you do overthink things at times.", "Oh, Monsieur Naruhodo, vous cherchez vraiment midi à quatorze heures parfois.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("If I've remembered correctly, this large and imposing\r\nlump of iron is called a ‘typewriter’.", "Si mes souvenirs sont bons, cet imposant bloc de ferraille\r\ns'appelle une « machine à écrire ».");
                s = s.Replace("To think that every single one of ‘The Adventures of\r\nHerlock Sholmes’ blossomed from this very machine!", "Dire que chacun des récits des « Aventures de\r\nSherlock Holmes » a pris vie sur cette machine !");
                s = s.Replace("Ah...it's such a dreamy thought...", "Ah... quelle merveilleuse pensée...");
                s = s.Replace("I actually had a go on it the other day.", "J'ai justement essayé de m'en servir l'autre jour.");
                s = s.Replace("The metal bars that move when you hit the keys got all\r\ntangled up somehow and that made Iris angry.", "Les tiges qui montent quand on frappe sur les touches se sont\r\ntoutes emmêlées, et Iris s'est fâchée tout rouge.");
                s = s.Replace("Mr Naruhodo...", "Monsieur Naruhodo...");
                s = s.Replace("...you're ruining my dreamy thoughts.\r\nPlease don't do that again.", "...vous gâchez mes songes poétiques.\r\nNe recommencez plus jamais ça.");
                s = s.Replace("(Ugh...now I've made Susato-san angry as well...)", "(Argh... voilà que j'ai fâché Mademoiselle Susato aussi...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("That's Iris's wonderful collection of medicines, potions and\r\nchemicals.", "C'est la prodigieuse collection de remèdes, potions et poudres\r\nchimiques d'Iris.");
                s = s.Replace("Just look at all the little bottles she's squeezed onto the\r\nshelves.", "Regardez toutes ces petites fioles entassées sur les étagères.");
                s = s.Replace("Yes, and there are charming little ribbons tied around the\r\nbottles, too.", "Oui, et de ravissants petits rubans sont noués autour des cols,\r\nen plus.");
                s = s.Replace("But the labels aren't quite so charming, are they?\r\nThis one here reads ‘Deadly Poison’.", "Mais les étiquettes ne sont pas tout à fait aussi charmantes, n'est-ce pas ?\r\nCelle-ci indique « Poison mortel ».");
                s = s.Replace("Oh, I've been so excited about the idea of helping Iris with\r\nher experiments, you know!", "Oh, j'étais si impatiente d'aider Iris dans ses expériences,\r\nvous savez !");
                s = s.Replace("Just try to avoid any bottles labelled ‘Deadly Poison’ or\r\n‘Highly Explosive’.", "Veillez simplement à éviter les flacons étiquetés « Poison mortel » ou\r\n« Hautement explosif ».");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("This blackboard is where Iris scribbles down her latest\r\nideas, isn't it?", "C'est sur ce tableau noir qu'Iris gribouille ses dernières\r\nidées, n'est-ce pas ?");
                s = s.Replace("Let's see... Oh, she seems to have drawn a lot of little stick\r\nfigures all lined up, look.", "Voyons... Oh, elle a dessiné toute une rangée de petits bonshommes\r\nallumettes, regardez.");
                s = s.Replace("‘Cheap apples at the market’ is what all of them say.", "« Pommes au rabais au marché », voilà ce qu'ils disent tous.");
                s = s.Replace("What?! The little figures can speak?!", "Quoi ?! Ces petits bonshommes savent parler ?!");
                s = s.Replace("All your questions would be answered if only you would\r\nread this month's Randst Magazine.", "Toutes vos questions trouveraient réponse si seulement vous lisiez\r\nle Randst Magazine de ce mois-ci.");
                s = s.Replace("(...So I'm the only one who can't make any sense of this?)", "(...Je suis donc le seul à n'y rien comprendre ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("This looks like last week's edition.", "On dirait l'édition de la semaine dernière.");
                s = s.Replace("What's that article circled in red ink there?", "Quel est cet article entouré à l'encre rouge, là ?");
                s = s.Replace("It's in an advertisement column.\r\nIt says...", "C'est dans la colonne des réclames.\r\nIl est écrit...");
                s = s.Replace("‘To the Red-Headed League’!", "« À la Ligue des Rouquins » !");
                s = s.Replace("The Red-Headed League?\r\nWhat's that?", "La Ligue des Rouquins ?\r\nQu'est-ce que c'est ?");
                s = s.Replace("I don't know.\r\nI've never heard of it before, but...", "Je ne sais pas.\r\nJe n'en ai jamais entendu parler, mais...");
                s = s.Replace("Is something on my face?", "J'ai quelque chose sur le visage ?");
                s = s.Replace("(Clearly this has something to do with that...lively hair.)", "(Cela a manifestement un lien avec cette... crinière flamboyante.)");
                s = s.Replace("The Red-Headed League article has been\r\nentered into the Court Record.", "L'article sur la Ligue des Rouquins a été\r\nconsigné dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_0_check_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("...The mask Kazuma wore when he was assigned to Lord\r\nvan Zieks as his apprentice.", "...Le masque que portait Kazuma lorsqu'il était affecté auprès\r\nde Lord Van Peers comme apprenti.");
                s = s.Replace("When he cast it aside after the trial the other day, I just\r\nsort of picked it up.", "Quand il l'a jeté après le procès l'autre jour, je l'ai\r\nsimplement ramassé.");
                s = s.Replace("We ought to give it back to him, I suppose.", "Nous devrions le lui rendre, j'imagine.");
                s = s.Replace("But he has his memory back now, doesn't he?", "Mais sa mémoire lui est revenue maintenant, n'est-ce pas ?");
                s = s.Replace("And I can't help feeling he might turn around and tell me\r\ncoldly to wear it myself...", "Et je crains qu'il ne se retourne pour me dire froidement\r\nde le porter moi-même...");
                s = s.Replace("But...isn't he your best friend?", "Mais... n'est-il pas votre meilleur ami ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0204_1_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Who'd have thought Professor Mikotoba would wear\r\nsomething like this?", "Qui aurait pu croire que le professeur Mikotoba porterait\r\nune chose pareille ?");
                s = s.Replace("Life can be...very unexpected sometimes.", "La vie peut être... pleine d'imprévus, parfois.");
                s = s.Replace("You know, in tomorrow's trial, it might be an idea...\r\n...if you wore this, Miss Susato.", "Vous savez, lors du procès de demain, ce serait une idée...\r\n...si vous portiez cela, Mademoiselle Susato.");
                s = s.Replace("Hm?!", "Hein ?!");
                s = s.Replace("I'm sure Kazuma would be thunderstruck.", "Je suis certain que Kazuma en resterait foudroyé.");
                s = s.Replace("I've no doubt he would. But...\r\n...I'm not sure I'm quite up to it.", "Je n'en doute pas un instant. Mais...\r\n...je ne suis pas sûre d'avoir le cran pour cela.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_00_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("1st November\r\nNaruhodo's Legal Consultancy", "1er novembre\r\nCabinet d'avocats Naruhodo");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à noter...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("My desk is just as it was before I left.", "Mon bureau est exactement tel qu'il était avant mon départ.");
                s = s.Replace("Sumi ink and a calligraphy brush...even though we're in\r\nEngland now.", "De l'encre de Chine et un pinceau de calligraphie... alors même que\r\nnous sommes en Angleterre à présent.");
                s = s.Replace("That strikes me as typically you, Miss Susato, and\r\ntypically not you at the same time, somehow.", "Cela me semble tellement typique de vous, Mademoiselle Susato, et pas\r\ndu tout à la fois, bizarrement.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("You see? I've been keeping my desk beautifully covered\r\nin papers as always.", "Vous voyez ? J'ai gardé mon bureau harmonieusement enseveli\r\nsous les papiers, comme toujours.");
                s = s.Replace("You really must tidy it all up, Mr Naruhodo.\r\nNo more excuses.", "Vous devez absolument faire de l'ordre, Monsieur Naruhodo.\r\nAssez d'excuses.");
                s = s.Replace("But Miss Susato, the way I see it...", "Mais Mademoiselle Susato, à mes yeux...");
                s = s.Replace("...all these papers building up on my desk like this are a\r\nreminder of my wonderfully diverse daily life.", "...tous ces papiers qui s'entassent sur mon bureau témoignent\r\nde la richesse de mon quotidien.");
                s = s.Replace("I like to leave them as they are so I never forget how\r\nlucky I am to have such varied experiences.", "J'aime les laisser ainsi pour ne jamais oublier la chance\r\nque j'ai de vivre tant d'aventures variées.");
                s = s.Replace("In that case, you should definitely have a thorough tidy.", "Dans ce cas, vous devriez incontestablement tout ranger de fond en comble.");
                s = s.Replace("Then you'll be able to see your papers building up all\r\nover again and feel that joy renewed.", "Ainsi vous aurez le plaisir de voir les papiers s'accumuler\r\nà nouveau et d'éprouver cette joie renouvelée.");
                s = s.Replace("(Still can't beat her in an argument.\r\nEven though I'm the lawyer here...)", "(Toujours impossible d'avoir le dessus sur elle.\r\nEt dire que c'est moi l'avocat...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("That daruma doll is still winking at me, look.", "Ce daruma continue de me faire un clin d'œil, regardez.");
                s = s.Replace("I wonder when he'll finally get his other eye filled in...", "Je me demande quand on lui dessinera enfin son autre œil...");
                s = s.Replace("Yes, I wonder...", "Oui, je me le demande...");
                s = s.Replace("(Well you should know, Susato-san.\r\nI entrusted the task to you.)", "(Eh bien vous devriez le savoir, Mademoiselle Susato.\r\nJe vous ai confié cette tâche.)");
                s = s.Replace("The truth is...", "La vérité est que...");
                s = s.Replace("...I have already decided when that will be.", "...j'ai déjà décidé du moment propice.");
                s = s.Replace("What?! Really?\r\nWhen?", "Quoi ?! Vraiment ?\r\nQuand ?");
                s = s.Replace("...That's my little secret.", "...C'est mon petit secret.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("The steam is rising gently from the kettle as always.", "La vapeur s'élève doucement de la bouilloire, comme toujours.");
                s = s.Replace("Yes. It doesn't feel right somehow unless it is.", "Oui. Il manquerait quelque chose si elle ne fumait pas.");
                s = s.Replace("But...the steam has an unusual scent today.", "Mais... la vapeur a un parfum inhabituel aujourd'hui.");
                s = s.Replace("Perhaps the sweet potatoes that I brought back from Japan\r\nwith me are ready.", "Peut-être que les patates douces rapportées du Japon\r\nsont cuites à point.");
                s = s.Replace("*Gulp...*", "*Gloup...*");
                s = s.Replace("Oh, Mr Naruhodo! I heard that, you know!", "Oh, Monsieur Naruhodo ! J'ai très bien entendu, vous savez !");
                s = s.Replace("Tears of joy, Miss Susato.\r\nFrom my mouth.", "Des larmes d'émotion, Mademoiselle Susato.\r\nQui me montent à la bouche.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("The spade is still here, look.", "La bêche est toujours là, regardez.");
                s = s.Replace("Please, Mr Naruhodo. It's not a spade, as I think you well\r\nknow. It's a shovel.", "De grâce, Monsieur Naruhodo. Ce n'est pas une bêche, comme vous\r\nle savez pertinemment. C'est une pelle.");
                s = s.Replace("(It didn't take long to reignite that old argument.)", "(Il n'aura pas fallu longtemps pour ranimer ce vieux débat.)");
                s = s.Replace("Ah, I have an idea!", "Ah, j'ai une idée !");
                s = s.Replace("Let's give the implement a name, like Professor\r\nHarebrayne named his tools.", "Donnons un petit nom à cet outil, comme le professeur\r\nLonron baptisait les siens.");
                s = s.Replace("Ooh! I never thought of doing that.", "Oh ! Je n'aurais jamais pensé à faire une chose pareille.");
                s = s.Replace("From now on, then, let's call it ‘Ryunosuke’.", "Dès lors, appelons-la donc « Ryunosuke ».");
                s = s.Replace("No no no no! It's clearly much more of a ‘Susato’!", "Non non non non ! Elle ressemble bien plus à une « Susato » !");
                s = s.Replace("(The old argument has taken a new and unexpected turn,\r\nit seems...)", "(Cette vieille querelle prend une tournure pour le moins\r\ninattendue, dirait-on...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Whenever you serve me tea, it always takes me back to\r\nJapan.", "Chaque fois que vous me servez du thé, cela me ramène\r\nau Japon.");
                s = s.Replace("I know you're not particularly fond of the bitter taste, are\r\nyou?", "Je sais que vous n'avez pas un faible pour l'amertume,\r\nn'est-ce pas ?");
                s = s.Replace("So I do always try to pick out less bitter matcha for you.", "Alors je veille toujours à sélectionner pour vous un matcha plus doux.");
                s = s.Replace("(She does often serve up an unusually mellow blend, it's\r\ntrue.)", "(C'est vrai qu'elle prépare souvent une infusion d'une douceur inhabituelle.)");
                s = s.Replace("(But the anticipation of the taste in my mouth makes me\r\nbitterly worried anyway...)", "(Mais l'appréhension de son goût sur mon palais m'emplit\r\nd'une amère angoisse malgré tout...)");
                s = s.Replace("It is very difficult for you, isn't it?", "C'est une terrible épreuve pour vous, n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("All the sea life seem very content in there, I must say.", "Toutes ces créatures marines ont l'air très heureuses là-dedans, je dois dire.");
                s = s.Replace("I've noticed something recently, actually...\r\nThe anemones breed at a most extraordinary rate.", "J'ai remarqué une chose récemment, à vrai dire...\r\nLes anémones prolifèrent à un rythme absolument stupéfiant.");
                s = s.Replace("Oh, really?", "Oh, vraiment ?");
                s = s.Replace("It's a mystery why the whole seabed isn't buried in a\r\nmountain of them, actually.", "C'est un mystère que le fond marin ne disparaisse pas sous\r\nune montagne d'anémones, en fait.");
                s = s.Replace("Oh, how splendid!\r\nThat really is a mystery, isn't it?", "Oh, comme c'est merveilleux !\r\nVoilà une véritable énigme, n'est-ce pas ?");
                s = s.Replace("(I wish there was someone here to explain Susato-san's\r\nstrange reaction to that.)", "(J'aimerais bien que quelqu'un m'explique la curieuse\r\nréaction de Mademoiselle Susato à ce propos.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Your room across the hall is undisturbed, of course.", "Votre chambre de l'autre côté du palier est restée intacte, bien sûr.");
                s = s.Replace("I don't suppose I'd be permitted to see inside now that\r\nyou're back though, would I?", "Je ne suppose pas qu'il me soit permis d'y jeter un œil maintenant\r\nque vous êtes revenue, si ?");
                s = s.Replace("You know very well that only Iris is allowed inside.", "Vous savez pertinemment que seule Iris y est autorisée.");
                s = s.Replace("(Yes, I heard you two giggling together in there again last\r\nnight.)", "(Oui, je vous ai encore entendues glousser toutes les deux là-dedans\r\nhier soir.)");
                s = s.Replace("You can visit Mr Sholmes in his room, Mr Naruhodo.", "Vous pouvez aller voir M. Holmes dans sa chambre, Monsieur Naruhodo.");
                s = s.Replace("Last time I did that, he tried to convince me to drink some\r\nstrange concoction he'd mixed up.", "La dernière fois que j'ai fait ça, il a tenté de me faire avaler une\r\nmixture suspecte qu'il venait d'inventer.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_0_check_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("It's a lovely photograph we took together when I had to\r\nleave London. Though it was a sad day.", "C'est une très belle photographie que nous avons prise ensemble lorsque j'ai dû\r\nquitter Londres. Même si ce fut une triste journée.");
                s = s.Replace("But I happily have the same photograph on display in my\r\nroom at home, you know.", "Mais j'ai heureusement la même photo exposée dans ma\r\nchambre chez moi, vous savez.");
                s = s.Replace("Now that we're all back together again...\r\n...it would be nice to take a new photograph.", "Maintenant que nous voilà à nouveau réunis...\r\n...ce serait une bonne idée d'en prendre une nouvelle.");
                s = s.Replace("Oh yes! That would be wonderful!", "Oh oui ! Ce serait formidable !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0206_1_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\nNaruhodo's Legal Consultancy", "2 novembre\r\nCabinet d'avocats Naruhodo");
                return s;
            };

        }
    }
}
