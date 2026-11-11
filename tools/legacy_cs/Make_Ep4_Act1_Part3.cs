using System;
using System.IO;
using System.Text;

class MakeEp4Act1Part3 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act1 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart3() {");

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

        // [66] KEY:BB\script\output\_sce03_bg0402_0_check_eng#1
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à signaler...)" }
        });

        // [67] KEY:BB\script\output\_sce03_bg0402_0_check_eng#2
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#2", new string[,] {
            { "So I suppose...", "Alors je suppose..." },
            { "this is where the victim...?", "que c'est là que la victime... ?" },
            { "That's right.", "C'est exact." },
            { "The rope is laid around the body to show\r\nexactly how it was found.", "La corde a été disposée autour du corps pour montrer\r\nprécisément comment il a été découvert." },
            { "Poor Inspector Gregson himself", "Le pauvre inspecteur Gregson lui-même" },
            { "has already been taken\r\naway.", "a déjà été emporté." },
            { "(And would probably be under Dr Sithe's scalpel by now\r\nif not for what happened last week...)", "(Et il serait probablement sous le scalpel de la Dre Pétrie à l'heure qu'il est\r\ns'il ne s'était pas passé ce qui s'est produit la semaine dernière...)" },
            { "From the shape of the rope...", "D'après la disposition de la corde..." },
            { "...it would appear that the inspector was", "...il semblerait que l'inspecteur était" },
            { "curled up in a\r\nball", "recroquevillé en\r\nboule" },
            { "Are you feeling alright,", "Vous vous sentez bien," },
            { "Mr Naruhodo?", "Monsieur Naruhodo ?" },
            { "You look like you've just seen a ghost.", "On dirait que vous venez de voir un fantôme." },
            { "I know it's just a rope,", "Je sais que ce n'est qu'une corde," },
            { "but... Well, it conjures up quite a\r\nterrifying image, that's all.", "mais... Disons qu'elle évoque une vision\r\nassez terrifiante, voilà tout." },
            { "Especially with that bloodstain next to it.", "Surtout avec cette tache de sang juste à côté." },
            { "Oh, I do understand.", "Oh, je comprends fort bien." },
            { "In some ways, what we picture in our minds can be even\r\nworse than reality.", "Par certains côtés, ce que nous imaginons peut être encore pire\r\nque la réalité." },
            { "(Susato-san is so strong, though.\r\nShe's taking this far better than I am...)", "(Susato est si forte, pourtant.\r\nElle prend tout cela bien plus vaillamment que moi...)" }
        });

        // [68] KEY:BB\script\output\_sce03_bg0402_0_check_eng#3
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#3", new string[,] {
            { "Ever since we came in here...", "Depuis que nous sommes entrés ici..." },
            { "I can't take my eyes off\r\nthis thing.", "je n'arrive pas à détacher mes yeux\r\nde cette chose." },
            { "Oh!", "Oh !" },
            { "Funnily enough, neither can I!", "Curieusement, moi non plus !" },
            { "It's...", "C'est..." },
            { "a hairpiece, isn't it?", "un postiche, n'est-ce pas ?" },
            { "It is!", "C'en est un !" },
            { "It IS!", "C'en EST un !" },
            { "A bright red hairpiece", "Un postiche d'un rouge flamboyant" },
            { "And I suppose the fact that it's right there next to", "Et je suppose que le fait qu'il soit là, juste à côté de" },
            { "where\r\nthe body was found...", "l'endroit où\r\nle corps a été trouvé..." },
            { "...means we have to accept that...", "...nous oblige à admettre que..." },
            { "Inspector Gregson wore\r\nwigs", "l'inspecteur Gregson portait\r\ndes perruques" },
            { ", does it?", ", n'est-ce pas ?" },
            { "And in such a flame-coloured red, too...", "Et d'un rouge si flamboyant, qui plus est..." },
            { "Yes,", "Oui," },
            { "that's a colour we've come across very recently\r\nelsewhere, isn't it?", "c'est une couleur que nous avons croisée très récemment\r\nailleurs, n'est-ce pas ?" },
            { "Exactly!", "Exactement !" },
            { "This is a vital clue, I'm sure of it!", "C'est un indice capital, j'en suis certaine !" },
            { "The red hairpiece has been\r\nentered into the Court Record.", "Le postiche roux a été ajouté\r\nau dossier de l'affaire." }
        });

        // [69] KEY:BB\script\output\_sce03_bg0402_0_check_eng#5
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#5", new string[,] {
            { "The top of one of the candles in this candle holder has\r\nbeen completely blown off.", "Le sommet de l'une des bougies de ce chandelier a été complètement\r\npulvérisé." },
            { "Yes, there's wax spattered on the wall behind, look.", "Oui, de la cire a été projetée sur le mur derrière, regardez." },
            { "I suppose if a bullet had hit it...", "Je suppose que si une balle l'avait percutée..." },
            { "It does seem likely that the bullet hit the candle...", "Il paraît en effet probable que la balle a touché la bougie..." },
            { "...having first passed through the inspector's body.", "...après avoir d'abord traversé le corps de l'inspecteur." },
            { "Ugh...", "Brrr..." },
            { "Now that wax on the wall looks like blood to me.", "À présent, cette cire sur le mur a des allures de sang pour moi." },
            { "The candelabrum has been\r\nentered into the Court Record.", "Le candélabre a été ajouté\r\nau dossier de l'affaire." }
        });

        // [70] KEY:BB\script\output\_sce03_bg0402_0_check_eng#7
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#7", new string[,] {
            { "This is presumably", "C'est donc vraisemblablement" },
            { "the murder weapon", "l'arme du crime" },
            { ", then...", ", alors..." },
            { "Oh, oh my...", "Oh... grands dieux..." },
            { "...It is real, I suppose?", "... Il est bien réel, je suppose ?" },
            { "I, I think so.", "J-Je le crains." },
            { "Guns are so rare in Japan, I really know very little about\r\nthem.", "Les armes à feu sont si rares au Japon que je n'y connais vraiment\r\npas grand-chose." },
            { "There's one way to know for sure, Mr Naruhodo.", "Il y a un moyen d'en avoir le cœur net, Monsieur Naruhodo." },
            { "Fire a shot!", "Tirez un coup !" },
            { "No no no!", "Non non non !" },
            { "If I did that, I'd be looking for a skilled lawyer to represent\r\nme in court.", "Si je faisais ça, je serais bon pour me chercher un avocat hors pair\r\npour me représenter au tribunal." },
            { "(Slightly safer just to ask someone who might know, I\r\nthink.)", "(Il est nettement plus prudent de demander à quelqu'un qui s'y connaît,\r\nje crois.)" },
            { "The killer's revolver has been\r\nentered into the Court Record.", "Le revolver du tueur a été ajouté\r\nau dossier de l'affaire." }
        });

        // [71] KEY:BB\script\output\_sce03_bg0402_0_check_eng#9
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#9", new string[,] {
            { "Oh...what's this?", "Tiens... qu'est-ce que c'est ?" },
            { "It would appear to be a little model policeman.", "Il semblerait que ce soit une petite figurine de policier." },
            { "It's rather charming, isn't it? In a way.", "C'est assez charmant, n'est-ce pas ? En quelque sorte." },
            { "Seeing as it's on the floor here... do you think it belonged\r\nto Inspector Gregson?", "Vu qu'elle est par terre ici... pensez-vous qu'elle appartenait\r\nà l'inspecteur Gregson ?" },
            { "It's a little hard to imagine Lord van Zieks playing with\r\nsomething like this.", "On a un peu de mal à imaginer Lord Van Peers jouer avec\r\nun objet pareil." },
            { "(It's only about eight centimetres tall.\r\nIt could have fallen out of someone's pocket, I suppose.)", "(Elle ne fait qu'environ huit centimètres de haut.\r\nElle a pu tomber de la poche de quelqu'un, je suppose.)" },
            { "I think we should record it as evidence, just in case.", "Je pense que nous devrions la conserver comme pièce à conviction, au cas où." },
            { "Yes, I agree.", "Oui, je suis d'accord." },
            { "It is rather delightful, after all.\r\nIn a way.", "C'est plutôt ravissant, après tout.\r\nEn quelque sorte." },
            { "The policeman figurine has been\r\nentered into the Court Record.", "La figurine de policier a été ajoutée\r\nau dossier de l'affaire." }
        });

        // [72] KEY:BB\script\output\_sce03_bg0402_0_check_eng#10
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#10", new string[,] {
            { "It is rather endearing in a way, isn't it?", "C'est assez attachant en quelque sorte, n'est-ce pas ?" },
            { "This little London bobby.", "Ce petit bobby londonien." },
            { "You do realise that you keep saying how charming it is\r\n‘in a way’, don't you?", "Vous réalisez que vous ne cessez de répéter qu'il est charmant\r\n« en quelque sorte », n'est-ce pas ?" },
            { "The truth is... on closer inspection his face scares me a\r\nlittle.", "À vrai dire... en y regardant de plus près, son visage m'effraie\r\nun peu." },
            { "Well... it is supposed to be a policeman.", "Eh bien... c'est censé être un agent de police." },
            { "Looking charming isn't generally in the job description as\r\nfar as I can tell.", "Avoir l'air charmant ne fait généralement pas partie du cahier des charges,\r\npour autant que je sache." },
            { "No, I suppose not... In a way, that makes me a little sad,\r\nthough.", "Non, sans doute pas... En quelque sorte, cela m'attriste un peu,\r\npourtant." }
        });

        // [73] KEY:BB\script\output\_sce03_bg0402_0_check_eng#11
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#11", new string[,] {
            { "This looks like some sort of noticeboard or something.", "On dirait une sorte de panneau d'affichage ou quelque chose du genre." },
            { "And it's absolutely covered in scraps of paper.", "Et il est entièrement tapissé de morceaux de papier." },
            { "...Ah! Mr Naruhodo, look!", "... Ah ! Monsieur Naruhodo, regardez !" },
            { "This, you mean? It's an autopsy report, isn't it?", "Vous voulez dire ceci ? C'est un rapport d'autopsie, n'est-ce pas ?" },
            { "And these are case notes here.", "Et ce sont des notes d'enquête, ici." },
            { "And details of prison inmates!", "Et des fiches de détenus !" },
            { "Yes... in fact they're all the sort of documents that only a\r\ndetective could normally acquire.", "Oui... en fait, ce sont tous le genre de documents que seul un\r\ndétective pourrait normalement se procurer." },
            { "(What on earth went on in this room?)", "(Que diable s'est-il passé dans cette pièce ?)" },
            { "Some old newspaper cuttings...", "De vieilles coupures de journaux..." },
            { "Ah! And this one here!", "Ah ! Et celle-ci, là !" },
            { "Oh yes, the advertisement, you mean?\r\n‘To the Red-Headed League’!", "Oh oui, cette petite annonce, voulez-vous dire ?\r\n« À la Ligue des Rouquins » !" },
            { "B-But why? What's that doing here?", "M-Mais pourquoi ? Qu'est-ce que ça fait là ?" },
            { "Whoever occupied this room was clearly interested in it\r\nfor some reason...", "Quiconque occupait cette pièce s'y intéressait de toute évidence\r\npour une raison précise..." }
        });

        // [74] KEY:BB\script\output\_sce03_bg0402_0_check_eng#12
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#12", new string[,] {
            { "Oh... it's a photograph stand.", "Oh... c'est un cadre photo." },
            { "I suppose it must be a picture of one of Inspector\r\nGregson's family members.", "J'imagine que ce doit être le portrait d'un membre de la famille\r\nde l'inspecteur Gregson." },
            { "Wh-What's the matter? Your eyes look like they're about\r\nto pop out of your head.", "Q-Qu'y a-t-il ? Vous avez les yeux qui vous sortent\r\nde la tête." },
            { "They are! Look, Mr Naruhodo!\r\nQuickly!", "Mais oui ! Regardez, Monsieur Naruhodo !\r\nVite !" },
            { "why do I feel like this woman is familiar somehow?", "pourquoi ai-je l'impression que cette femme m'est familière ?" },
            { "Of course she's familiar!\r\nWe met her only this morning!", "Bien sûr qu'elle vous est familière !\r\nNous l'avons rencontrée ce matin même !" },
            { "Aah!\r\nIt's... It's... It's...", "Aah !\r\nC'est... C'est... C'est..." },
            { "...Mrs Vigil!", "... Mme Vigil !" },
            { "This... makes no sense.\r\nWhy would there be a picture of Mrs Vigil in here?", "Cela... n'a aucun sens.\r\nPourquoi y aurait-il une photo de Mme Vigil ici ?" },
            { "To be frank...", "Pour être franc..." },
            { "...I don't think I've ever been more stumped.", "... je crois que je n'ai jamais été aussi perplexe." },
            { "I'm sorry to say, I have no idea either.", "J'ai le regret de vous dire que je n'en ai pas la moindre idée non plus." },
            { "The framed photograph has been\r\nentered into the Court Record.", "La photo encadrée a été ajoutée\r\nau dossier de l'affaire." }
        });

        // [75] KEY:BB\script\output\_sce03_bg0402_0_check_eng#13
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#13", new string[,] {
            { "There's really no question, is there?", "Il n'y a vraiment aucun doute, n'est-ce pas ?" },
            { "It's the same woman we met only this morning!\r\nIt's definitely Mrs Vigil!", "C'est la même dame que nous avons rencontrée ce matin même !\r\nC'est bel et bien Mme Vigil !" },
            { "A little younger-looking, perhaps, but still...", "Elle a l'air un peu plus jeune, peut-être, mais tout de même..." },
            { "Aha! Perhaps she has a younger sister who looks just like\r\nher or something!", "Aha ! Peut-être a-t-elle une sœur cadette qui lui ressemble trait pour trait\r\nou quelque chose comme ça !" },
            { "But the photograph does appear to be rather old, doesn't\r\nit?", "Mais la photographie a l'air passablement ancienne, n'est-ce pas ?" },
            { "And anyway, the question remains: why would something\r\nlike this be in here?", "Et de toute façon, la question demeure : pourquoi une chose pareille\r\nse trouverait-elle ici ?" },
            { "You're right, the question does remain.", "Vous avez raison, la question reste entière." },
            { "And I remain as stumped as I ever was by it...", "Et je reste plus perplexe que jamais..." }
        });

        // [76] KEY:BB\script\output\_sce03_bg0402_0_check_eng#14
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#14", new string[,] {
            { "Somebody's very haphazardly nailed those boards over\r\nthe broken glass, haven't they?", "Quelqu'un a cloué ces planches à la va-vite par-dessus le carreau brisé,\r\nnon ?" },
            { "You couldn't even really call it a window any more.", "On ne peut même plus vraiment appeler cela une fenêtre." },
            { "Well, if you remember the window in Mr Natsume's\r\nroom, that was totally blocked up with bricks.", "Eh bien, si vous vous souvenez de la fenêtre dans la chambre de M. Natsume,\r\nelle était totalement murée de briques." },
            { "This one does at least still let in some light, so you could\r\nsay–", "Celle-ci laisse au moins passer un peu de lumière, on pourrait\r\ndire que–" },
            { "You could say nothing more about it.", "On pourrait n'en rien dire de plus." },
            { "...I'm starting to feel even more sorry for Mr Natsume\r\nnow.", "... Je commence à avoir encore plus pitié de M. Natsume,\r\nà présent." }
        });

        // [77] KEY:BB\script\output\_sce03_bg0402_0_check_eng#15
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#15", new string[,] {
            { "An empty fireplace makes a room feel even colder than it\r\nwould be otherwise, doesn't it?", "Une cheminée éteinte rend une pièce encore plus froide qu'elle ne le serait\r\nautrement, n'est-ce pas ?" },
            { "It's thick with dust, look.", "Elle est couverte d'une épaisse couche de poussière, regardez." },
            { "I think it would be fair to say it hasn't been used in a very\r\nlong time.", "On peut sans trop s'avancer affirmer qu'elle n'a pas servi depuis\r\ntrès longtemps." },
            { "In other words...", "Autrement dit..." },
            { "...whoever lived in this room must have been extremely\r\nhardy in cold weather.", "... quiconque vivait dans cette pièce devait être extrêmement\r\nrésistant au froid." },
            { "Or nobody lived here at all, and merely visited when the\r\noccasion arose.", "Ou bien personne n'y vivait, et ne s'y rendait qu'à l'occasion." },
            { "...I wouldn't like to say which is more likely.", "... Je ne saurais dire laquelle de ces hypothèses est la plus plausible." },
            { "N-No, that's right.\r\nIt's one or the other...", "N-Non, c'est vrai.\r\nC'est l'un ou l'autre..." }
        });

        // [78] KEY:BB\script\output\_sce03_bg0402_0_check_eng#16
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#16", new string[,] {
            { "Um, excuse me...", "Euh, excusez-moi..." },
            { "Oh, Inspector...", "Oh, inspecteur..." },
            { "Ohhh, sir...", "Ohhh, patron..." },
            { "(Poor man. He can't possibly be able to focus on\r\ninvestigating when he's so upset.)", "(Pauvre homme. Il ne peut manifestement pas se concentrer sur l'enquête\r\ntant il est bouleversé.)" }
        });

        // [79] KEY:BB\script\output\_sce03_bg0402_0_check_eng#17
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#17", new string[,] {
            { "Um, excuse me...", "Euh, excusez-moi..." },
            { "Sorry, sir. Can't see a thing, sir. Too many tears, sir.", "Désolé, m'sieur. J'y vois goutte, m'sieur. Trop de larmes, m'sieur." },
            { "(Right. Perhaps I'd better leave you to your work, then...)", "(Compris. Je ferais peut-être mieux de vous laisser à votre tâche, alors...)" }
        });

        // [80] KEY:BB\script\output\_sce03_bg0402_0_check_eng#18
        add(@"BB\script\output\_sce03_bg0402_0_check_eng#18", new string[,] {
            { "Um, excuse me...", "Euh, excusez-moi..." },
            { "If you're looking down on us from the great beyond,\r\nInspector, don't worry. We'll look after things at the Yard.", "Si vous nous regardez depuis l'au-delà, inspecteur, ne vous en faites pas.\r\nOn veillera sur tout au Yard." },
            { "(I've interrupted some deep thoughts there...)", "(J'ai interrompu un profond recueillement...)" }
        });

        // [81] KEY:BB\script\output\_sce03_bg0402_1_00_eng#6
        add(@"BB\script\output\_sce03_bg0402_1_00_eng#6", new string[,] {
            { "2nd November\r\nRoom on Fresno Street", "2 novembre\r\nChambre de Fresno Street" }
        });

        // [82] KEY:BB\script\output\_sce03_bg0402_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#1", new string[,] {
            { "If it turns out that Gregson didn't actually die in here at\r\nall...", "S'il s'avère que Gregson n'est pas mort ici du tout..." },
            { "...where on earth could he have been killed?", "...où diable a-t-il bien pu être tué ?" },
            { "Well one way or another, we must find out.", "D'une manière ou d'une autre, nous devons le découvrir." },
            { "For the inspector's sake.", "Pour le repos de l'inspecteur." },
            { "You know, you look awfully pale again today,\r\nMr Naruhodo.", "Vous savez, vous avez l'air affreusement pâle aujourd'hui encore,\r\nMonsieur Naruhodo." },
            { "Ugh...sorry. When I start thinking it all through, I conjure\r\nup some horrible images in my mind.", "Ouf... désolé. Quand je commence à réfléchir à tout ça, j'ai d'affreuses\r\nimages qui me viennent à l'esprit." },
            { "Your imagination is the culprit here, then.\r\nMost certainly guilty!", "C'est donc votre imagination la coupable.\r\nAssurément coupable !" }
        });

        // [83] KEY:BB\script\output\_sce03_bg0402_1_check_eng#2
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#2", new string[,] {
            { "It catches your eye as soon as you enter the room,\r\ndoesn't it?", "Il saute aux yeux dès qu'on entre dans la pièce,\r\nn'est-ce pas ?" },
            { "It's such a bright colour, it certainly makes an impression,\r\nyes.", "C'est une couleur si vive, cela marque incontestablement les esprits,\r\noui." },
            { "...They can't possibly commit any crimes, can they?\r\nI mean, red-heads stand out like a sore thumb.", "... Ils ne peuvent décemment commettre aucun crime, non ?\r\nJe veux dire, les roux se remarquent comme le nez au milieu de la figure." },
            { "I'm afraid with our jet-black Japanese hair, we stand out\r\nalmost as much, here in London.", "J'ai bien peur qu'avec nos cheveux japonais d'ébène, nous nous fassions\r\ntout autant remarquer, ici à Londres." },
            { "Haah...\r\nI suppose that's true.", "Haah...\r\nJ'imagine que c'est vrai." },
            { "You mustn't think of committing any crimes,\r\nMr Naruhodo.", "N'allez pas vous imaginer commettre le moindre forfait,\r\nMonsieur Naruhodo." },
            { "I wasn't!", "Ce n'était pas mon intention !" }
        });

        // [84] KEY:BB\script\output\_sce03_bg0402_1_check_eng#3
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#3", new string[,] {
            { "Using a candle as a timer device...\r\nVery ingenious, I must say.", "Se servir d'une bougie comme dispositif à retardement...\r\nTrès ingénieux, je dois dire." },
            { "Yes, the culprit arranged it so that the firecracker would\r\nbe set off at five o'clock, and then left.", "Oui, le coupable a fait en sorte que le pétard explose à cinq heures sonnantes,\r\npuis il est parti." },
            { "So that a loud bang was heard at precisely the moment\r\nLord van Zieks arrived, yes.", "De sorte qu'une forte détonation a retenti précisément au moment où\r\nLord Van Peers est arrivé, oui." },
            { "If only he hadn't picked up that gun from the floor...", "Si seulement il n'avait pas ramassé cette arme au sol..." },
            { "Something you probably told yourself once upon a time,\r\nI imagine?", "Une pensée que vous vous êtes sans doute formulée jadis,\r\nj'imagine ?" },
            { "Yes, I've learnt that lesson by bitter experience.\r\nI would have turned and run a mile for sure.", "Oui, j'ai appris cette leçon à mes dépens.\r\nJ'aurais tourné les talons et détalé à toute allure, pour sûr." },
            { "...Which may not have done you any favours, either.", "... Ce qui ne vous aurait peut-être guère rendu service non plus." }
        });

        // [85] KEY:BB\script\output\_sce03_bg0402_1_check_eng#4
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#4", new string[,] {
            { "This revolver... Just who does it belong to?", "Ce revolver... À qui appartient-il au juste ?" },
            { "Well, we know it's of the type issued to members of the\r\npolice force and judiciary.", "Eh bien, nous savons qu'il s'agit du modèle fourni aux membres des forces\r\nde l'ordre et du corps judiciaire." },
            { "But Gregson's own gun was found on his person.", "Mais la propre arme de Gregson a été retrouvée sur lui." },
            { "And of course Lord van Zieks has admitted to losing the\r\nfirearm with which he was issued.", "Et bien entendu, Lord Van Peers a admis avoir égaré l'arme de poing\r\nqui lui avait été allouée." },
            { "Such absent-mindedness... Not dissimilar to you,\r\nMr Naruhodo.", "Une telle étourderie... Ce n'est pas sans rappeler un certain\r\nMonsieur Naruhodo." },
            { "I'm starting to think the cold, hard prosecutor and I could\r\nbecome friends after all.", "Je commence à penser que ce procureur froid et inflexible et moi pourrions\r\nfinir par devenir amis, après tout." },
            { "Then I wish you every success!", "Dans ce cas, je vous souhaite plein succès !" }
        });

        // [86] KEY:BB\script\output\_sce03_bg0402_1_check_eng#5
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#5", new string[,] {
            { "I'd never have imagined that this little figurine would\r\nturn out to be a watch winding key.", "Je n'aurais jamais imaginé que cette petite figurine se révélerait être\r\nune clef de remontage de montre." },
            { "I suppose it's a policeman because the pocket watch was a\r\ngift from Scotland Yard.", "J'imagine qu'elle représente un policier parce que la montre à gousset était\r\nun cadeau de Scotland Yard." },
            { "It seems there was much more to Inspector Gregson than\r\nwe ever realised. He was clearly a brilliant man.", "Il semble que l'inspecteur Gregson était bien plus profond que ce que nous\r\nimaginions. C'était manifestement un homme brillant." },
            { "It's the fish and chips that threw us off.\r\nI feel as though it ruined his image.", "C'est son poisson-frites qui nous a induits en erreur.\r\nJ'ai l'impression que ça gâchait son image." },
            { "I really don't think we should blame one of Britain's\r\nstaple cuisines...", "Je ne crois vraiment pas qu'il faille blâmer l'un des fleurons de la gastronomie\r\nbritannique..." },
            { "But think about it.\r\nImagine if it was Mr Sholmes.", "Mais réfléchissez.\r\nImaginez si c'était Monsieur Holmes." },
            { "How would you feel if instead of that old briar pipe that's\r\nalways in his hand, Mr Sholmes had a bag of chips?", "Que ressentiriez-vous si au lieu de cette vieille pipe en bruyère qu'il a toujours\r\nà la main, Monsieur Holmes tenait un cornet de frites ?" },
            { "Rather disappointed, if I'm honest.", "Plutôt déçue, pour être honnête." },
            { "Exactly.", "Exactement." }
        });

        // [87] KEY:BB\script\output\_sce03_bg0402_1_check_eng#6
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#6", new string[,] {
            { "There are details of cases stretching back over ten years\r\non this noticeboard.", "Ce tableau regorge de détails d'affaires remontant à plus de dix ans." },
            { "Yes, a history of Lord van Zieks's defeats in court.", "Oui, la chronique des défaites judiciaires de Lord Van Peers." },
            { "I don't think that's an appropriate description.", "Je ne pense pas que ce soit une formule appropriée." },
            { "Although... when you consider everything on the board,\r\nit's certainly true...", "Quoique... à bien y regarder,\r\nil est bien vrai..." },
            { "...that all these people had a background of dubious\r\ndealings.", "... que toutes ces personnes avaient un passé d'affaires douteuses." },
            { "And in the end of course...", "Et à la fin, bien sûr..." },
            { "...the board itself concealed the inspector's own death.", "...le panneau lui-même dissimulait la propre mort de l'inspecteur." },
            { "Oh my... It really doesn't bear thinking about.", "Grands dieux... Cela fait froid dans le dos." }
        });

        // [88] KEY:BB\script\output\_sce03_bg0402_1_check_eng#7
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#7", new string[,] {
            { "The photograph of Mrs Vigil...", "La photographie de Mme Vigil..." },
            { "Realising the identity of this lady was a very great clue\r\nto exposing Mr Gossip's true identity.", "Découvrir l'identité de cette dame fut un indice majeur\r\npour percer à jour la véritable identité de M. Gossip." },
            { "He obviously loves his wife very dearly.", "Il aime manifestement son épouse de tout son cœur." },
            { "...Which is why he felt he couldn't tell her the truth.", "... C'est pourquoi il s'est senti incapable de lui avouer la vérité." },
            { "The transformation was incredible, wasn't it?\r\nJust from that big twisted lip.", "La métamorphose était stupéfiante, n'est-ce pas ?\r\nSimplement avec cette grosse lèvre tordue." },
            { "Yes, he went to extraordinary efforts to play the part of\r\nHugh Boone convincingly.", "Oui, il a déployé des efforts extraordinaires pour jouer le rôle de\r\nHugh Boone avec conviction." },
            { "Although... it didn't really seem like it was much of an\r\neffort to me.", "Quoique... cela ne m'avait pas vraiment l'air de lui demander un gros effort." },
            { "Hm... Now you say it, I have to agree.", "Hum... Maintenant que vous le dites, je dois convenir." },
            { "It's almost as if that was Mr Vigil's true character.", "C'est presque comme si c'était là le véritable caractère de M. Vigil." },
            { "...People really are very hard to fathom at times.", "... La nature humaine est parfois bien impénétrable." }
        });

        // [89] KEY:BB\script\output\_sce03_bg0402_1_check_eng#8
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#8", new string[,] {
            { "...This little trunk wasn't here before, was it?", "... Cette petite malle n'était pas là tout à l'heure, si ?" },
            { "Oh! ...It appears to be made of metal.\r\nIt must be very heavy.", "Oh ! ... Elle semble faite de métal.\r\nElle doit être très lourde." },
            { "I wonder to whom it belongs...", "Je me demande à qui elle appartient..." },
            { "There are some initials on the outside, look.\r\n‘T. G.’", "Il y a des initiales à l'extérieur, regardez.\r\n« T. G. »" },
            { "Let's ask one of the policemen if they know how it came\r\nto be here.", "Demandons à l'un des policiers s'ils savent comment elle a atterri ici." },
            { "Ooooooi!", "Hééééééé !" },
            { "Wot d'ya think yer doin'?!", "Qu'est-ce que vous manigancez, vous deux ?!" },
            { "That's my trunk, that is!", "C'est ma malle à moi, ça !" },
            { "'Ands off!", "Pas touche !" },
            { "Gina!", "Gina !" },
            { "Wh-Where were you hiding?!", "O-Où est-ce que tu te cachais ?!" },
            { "I dunno, ya leave somefin' unattended for a few seconds,\r\nan' every Tom, Dick an' 'Arry's got 'is greedy eyes on it!", "J'te jure, on laisse un truc sans surveillance deux secondes,\r\net le premier clampin venu y fourre ses sales pattes !" },
            { "just a wild guess, Gina, but...", "simple supposition au hasard, Gina, mais..." },
            { "Wot? Spit it out, 'Oddo.", "Quoi ? Accouche, Naruhodo !" },
            { "Is it fair to say that you've only owned that trunk since\r\nthis morning's trial?", "Ne l'aurais-tu pas récupérée seulement depuis le procès de ce matin ?" },
            { "Wot?!", "Quoi ?!" },
            { "W-Wot are you tryin' to say?!", "Q-Qu'est-ce que tu baves ?!" },
            { "Come on, this trunk goes wiv me everywhere!", "Mais non, cette malle m'accompagne partout !" },
            { "Always 'as! Where've ya been the last year?!", "Depuis toujours ! T'étais où, l'année passée ?!" },
            { "(Trying not to incur your wrath, mainly...)", "(À essayer de ne pas m'attirer tes foudres, principalement...)" }
        });

        // [90] KEY:BB\script\output\_sce03_bg0402_1_check_eng#9
        add(@"BB\script\output\_sce03_bg0402_1_check_eng#9", new string[,] {
            { "Gina, I'm... really sorry.", "Gina, je suis... vraiment désolé." },
            { "It's daft, innit? If ya asked me a year ago, the cops could go\r\n'ang for all I cared.", "C'est bête, pas vrai ? Si tu m'avais demandé y a un an, les cognes pouvaient\r\ncrever que ça m'aurait fait ni chaud ni froid." },
            { "But we've gotta 'ave police, ain't we?\r\nTo catch the bludgers.", "Mais faut bien des flics, pas vrai ?\r\nPour choper les truands." },
            { "So us divers can go about our business in peace.", "Pour que nous autres tire-laines, on puisse faire nos affaires peinards." },
            { "Wait... sorry? I, I don't think I can have heard that\r\nproperly...", "Attends... pardon ? J-Je crois que j'ai mal entendu..." },
            { "'E said 'e was gonna teach me everyfin' I needed to know\r\nto be a detective.", "Il disait qu'il allait m'apprendre tout c'qu'il fallait savoir\r\npour être détective." },
            { "But all 'e got round to showin' me is where the best\r\nflamin' fish 'n' chip shops are!", "Mais tout c'qu'il a trouvé à m'montrer, c'est les meilleures bicoques\r\nde poisson-frites de la ville !" },
            { "(Actually, that reminds me...)", "(À vrai dire, ça me rappelle...)" },
            { "(Gregson said he was supposed to be going to Paris in the\r\nnear future, didn't he?)", "(Gregson avait dit qu'il devait partir pour Paris incessamment sous peu,\r\nn'est-ce pas ?)" },
            { "Is something wrong?", "Quelque chose ne va pas ?" },
            { "Oh... no. I'm sure I'm reading too much into things.", "Oh... non. Je me fais sûrement des idées." },
            { "It's just that the timing seems very coincidental.", "C'est juste que la coïncidence temporelle est troublante." },
            { "Hm?", "Hein ?" },
            { "You know, the boss was actin' a bit strange recently.", "Tu sais, le patron agissait bizarrement ces derniers temps." },
            { "Like 'e was always in a rush...", "Comme s'il était tout l'temps pressé..." }
        });

        // [91] KEY:BB\script\output\_sce03_bg0404_1_check_eng#1
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#1", new string[,] {
            { "(Nothing particular of note...)", "(Rien de particulier à signaler...)" }
        });

        // [92] KEY:BB\script\output\_sce03_bg0404_1_check_eng#2
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#2", new string[,] {
            { "Those large jars seem to have pale things floating around\r\ninside them.", "Ces grands bocaux renferment des choses blanchâtres qui flottent à l'intérieur." },
            { "I suppose they're fruit liquors or something.\r\nOr like the pickled umeboshi plums we make back home.", "J'imagine que ce sont des liqueurs de fruits ou quelque chose du genre.\r\nOu des prunes umeboshi marinées comme chez nous." },
            { "...Yes, let's assume they're something completely innocent\r\nlike that!", "... Oui, partons du principe que c'est une chose tout à fait inoffensive\r\nde ce genre !" },
            { "Ah, that jar you're looking at up there contains monkey\r\nbrains.", "Ah, ce bocal que vous observez là-haut contient des cervelles\r\nde singe." },
            { "Oh my...", "Grands dieux..." },
            { "The composition is similar to the human brain, so they\r\nmake for interesting study material.", "Leur constitution est semblable à celle du cerveau humain, cela en fait\r\nun sujet d'étude fascinant." },
            { "And in the next jar along, we have monkey–", "Et dans le bocal d'à côté, nous avons du singe–" },
            { "No no no! No more monkey anythings!\r\n...Please.", "Non non non ! Plus rien qui vienne d'un singe !\r\n... De grâce." },
            { "...If you say so.", "... Comme vous voudrez." },
            { "Oh dear...\r\nThe time when I still thought it was just some pickled\r\numeboshi plums seems so long ago already...", "Misère...\r\nL'époque où je croyais encore que c'étaient des prunes umeboshi marinées\r\nsemble déjà si lointaine..." }
        });

        // [93] KEY:BB\script\output\_sce03_bg0404_1_check_eng#3
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#3", new string[,] {
            { "A table and a set of sharp tools... When you consider each\r\nin isolation, it all looks quite innocent.", "Une table et un assortiment d'instruments tranchants... Pris isolément,\r\ntout cela a l'air bien anodin." },
            { "So why is it that when you put them side by side, they\r\nseem so horribly disturbing?", "Alors pourquoi, lorsqu'on les réunit côte à côte, cela paraît-il\r\nsi horriblement dérangeant ?" },
            { "...It might be best not to ponder it too deeply.", "... Il vaut peut-être mieux ne pas trop méditer là-dessus." },
            { "That's Mama's dissection table.\r\nIt's too high for me, though.", "C'est la table de dissection de maman.\r\nElle est trop haute pour moi, par contre." },
            { "It, it is...?", "V-Vraiment... ?" },
            { "If I fell from that height in my sleep, it would really hurt.", "Si je tombais de cette hauteur dans mon sommeil, je me ferais très mal." },
            { "Wha...?! You, you mean you sleep in here?", "Quoi... ?! Vous... vous voulez dire que vous dormez ici ?" },
            { "...Autopsy work is very involved. It's usually too late to\r\nthink about going home when I'm finished.", "... Le travail d'autopsie est très exigeant. Il est généralement trop tard\r\npour penser à rentrer chez moi quand j'ai fini." },
            { "But I have bad dreams when I sleep here, and I always\r\nend up falling onto the floor.", "Mais je fais de mauvais rêves quand je dors ici, et je finis toujours\r\npar tomber par terre." },
            { "So I'd like to exchange that table for a lower one.", "Alors j'aimerais bien changer cette table pour une plus basse." },
            { "...Maybe you should just go home.", "... Peut-être devriez-vous simplement rentrer chez vous." }
        });

        // [94] KEY:BB\script\output\_sce03_bg0404_1_check_eng#4
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#4", new string[,] {
            { "Look at all the bottles on the shelves in these cabinets!\r\nWhat an assortment of chemicals!", "Regardez toutes ces bouteilles sur les étagères de ces armoires !\r\nQuel assortiment de produits chimiques !" },
            { "These ones here are labelled ‘Highly Toxic’.", "Celles-ci portent l'étiquette « Hautement toxique »." },
            { "Ugh, that's worrying. Because there are also things that\r\nlook like salt and pepper shakers in there.", "Brrr, c'est inquiétant. Parce qu'il y a aussi des récipients qui ressemblent\r\nà des salières et poivrières à l'intérieur." },
            { "Oh yes! And they actually say ‘salt’ and ‘pepper’ on them!", "Oh oui ! Et il est bel et bien écrit « sel » et « poivre » dessus !" },
            { "The doctor probably spends a lot of time in this room, I\r\nsuppose. Perhaps she has meals here sometimes.", "Le médecin passe sans doute beaucoup de temps dans cette pièce, je suppose.\r\nPeut-être y prend-elle ses repas parfois." },
            { "Life goes on... even when you're surrounded by death...", "La vie continue... même lorsqu'on est entouré par la mort..." }
        });

        // [95] KEY:BB\script\output\_sce03_bg0404_1_check_eng#5
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#5", new string[,] {
            { "This looks... different to before.", "Cela semble... différent d'avant." },
            { "Of course, Mr Naruhodo.", "Bien sûr, Monsieur Naruhodo." },
            { "Miss Gorey is a young maiden.", "Mademoiselle Pétrie est une jeune fille." },
            { "She has all sorts of charming little dolls and the like\r\naround her place of work, look.", "Elle a toutes sortes de charmantes petites poupées disséminées sur son lieu\r\nde travail, regardez." },
            { "Oh yes, you're right. Perhaps she's not so strange after all.", "Oh oui, vous avez raison. Peut-être n'est-elle pas si étrange après tout." },
            { "...They're how I practise.", "... C'est comme ça que je m'entraîne." },
            { "Sorry?", "Pardon ?" },
            { "Mama always says that operations and dissections require\r\nspeed and accuracy.", "Maman dit toujours que les opérations et les dissections exigent\r\nrapidité et précision." },
            { "So I take out my needle and thread and stitch three new\r\ndolls every day.", "Alors je sors mon fil et mon aiguille et je recouds trois nouvelles\r\npoupées chaque jour." },
            { "Ah... right...", "Ah... d'accord..." },
            { "I used to make livers or kidneys or intestines...", "Avant, je cousais des foies, des reins ou des intestins..." },
            { "...but Mama told me to make something more friendly\r\ninstead.", "... mais maman m'a dit de fabriquer des choses plus avenantes à la place." },
            { "That's... quite different to what I'd imagined.", "C'est... assez éloigné de ce que j'avais imaginé." }
        });

        // [96] KEY:BB\script\output\_sce03_bg0404_1_check_eng#6
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#6", new string[,] {
            { "That looks like an owl and a crow up there.", "On dirait une chouette et un corbeau, là-haut." },
            { "I know. And they haven't even twitched since we came\r\nin here...", "Je sais. Et ils n'ont pas bronché d'un millimètre depuis que nous sommes\r\nentrés ici..." },
            { "Well no, they wouldn't have. They're taxidermy mounts, Mr Naruhodo.", "Eh bien non, évidemment. Ce sont des spécimens naturalisés, Monsieur Naruhodo." },
            { "Ugh... I was afraid you were going to say that.", "Ouf... j'avais peur que vous ne disiez ça." },
            { "I've been trying very hard to tell myself they're just\r\nsleeping with their eyes open.", "Je m'efforçais de me convaincre qu'ils dormaient les yeux ouverts." },
            { "Yes, I think perhaps you were wise to put something like\r\nyour daruma doll on display in the office instead...", "Oui, je crois que vous avez été bien avisé d'exposer plutôt votre poupée\r\ndaruma au bureau..." }
        });

        // [97] KEY:BB\script\output\_sce03_bg0404_1_check_eng#7
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#7", new string[,] {
            { "Well, look at this! What a magnificent display case!", "Eh bien, regardez-moi ça ! Quelle magnifique vitrine !" },
            { "The cherry wood has been polished to a high sheen, and\r\nthe intricate carving is a joy to behold.", "Le bois de cerisier a été poli à la perfection, et\r\nces sculptures ouvragées sont un pur ravissement." },
            { "Western cabinet makers really are very skilled, aren't\r\nthey?", "Les ébénistes occidentaux sont vraiment très doués, n'est-ce pas ?" },
            { "It's ten people.", "C'est dix personnes." },
            { "Pardon?", "Pardon ?" },
            { "It's made from the bones of ten different people, all mixed\r\ntogether.", "C'est fait avec les os de dix personnes différentes, tous mélangés." },
            { "Some of my best work!", "Une de mes plus belles créations !" },
            { "I was admiring the case, actually.", "J'admirais la vitrine, à vrai dire." },
            { "The scary skeleton inside is... something I intend to ignore\r\nas best I can.", "L'effrayant squelette à l'intérieur est... quelque chose que j'entends ignorer\r\nde mon mieux." },
            { "You're strange.", "Vous êtes étrange." },
            { "...I wonder who is the strangest...", "... Je me demande qui de nous deux est le plus étrange..." }
        });

        // [98] KEY:BB\script\output\_sce03_bg0404_1_check_eng#8
        add(@"BB\script\output\_sce03_bg0404_1_check_eng#8", new string[,] {
            { "Let's have a closer look at this...", "Regardons ceci de plus près..." },
            { "(Then again, let's not. At least, not while she's armed.)", "(D'un autre côté, abstenons-nous. Du moins, pas tant qu'elle est armée.)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(@"tools\Trans_Ep4_Act1_Part3.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Wrote tools\\Trans_Ep4_Act1_Part3.cs");
    }
}
