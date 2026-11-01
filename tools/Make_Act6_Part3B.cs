using System;
using System.IO;
using System.Text;

class MakeAct6Part3B {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart3_B() {");

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

        // [106] KEY:BB\script\output\_sce02_chr230_01_eng#3
        add(@"BB\script\output\_sce02_chr230_01_eng#3", new string[,] {
            { "Do, do you think he set out to trick me from the very\r\nstart?", "P-Pensez-vous qu'il ait eu l'intention de me berner depuis le tout début ?" },
            { "I'm sorry to say...that does seem likely, yes.", "J'ai bien peur... que cela ne soit fort probable, oui." },
            { "When I first met him, he introduced himself as a wealthy\r\nfinancier.", "Quand je l'ai rencontré pour la première fois, il s'est présenté comme un riche financier." },
            { "He looked over the paper I'd written and said my work\r\nwould benefit all humanity and MUST be pursued!", "Il a parcouru l'article que j'avais rédigé et a affirmé que mes travaux bénéficieraient à l'humanité entière et DEVAIENT être poursuivis !" },
            { "He was so enthused!\r\nHe was so emphatic!", "Il était si enthousiaste ! Il y mettait tant de conviction !" },
            { "But in reality...he was the mastermind of some vast\r\ncriminal network, it seems.", "Mais en réalité... c'était le cerveau d'une vaste pègre locale, semble-t-il." },
            { "I, I still can't believe it...", "Je... je n'arrive toujours pas à y croire..." },
            { "As the machine was essentially a set decoration for some\r\nstage magic...", "Comme la machine n'était au fond qu'un décor de scène pour un tour de magie..." },
            { "...it probably didn't require a large amount of investment,\r\nactually.", "...elle n'a probablement pas nécessité d'investissements colossaux, en réalité." },
            { "But the scale of it! It wasn't just some small trick.", "Mais quelle mise en scène ! Ce n'était pas un vulgaire tour de passe-passe." },
            { "It was a very elaborate feat of deception.", "C'était une supercherie prodigieusement élaborée." },
            { "All young scientists are full of hope about their\r\nburgeoning ideas. Full of zeal.", "Tous les jeunes savants débordent d'espoir pour leurs théories naissantes. Pleins de ferveur." },
            { "But none of us have any money!\r\nWe want to do research, but we can't afford it!", "Mais aucun de nous n'a le sou ! Nous brûlons de chercher, mais manquons de moyens !" },
            { "Many of us take on barely legal part-time work to try to\r\nearn just a few measly pennies to carry on!", "Beaucoup d'entre nous acceptent des besognes à la limite de la légalité pour grappiller quelques maigres sous et survivre !" },
            { "To go through all of that, only to be taken for a complete\r\nfool! It's too rotten to believe...", "Endurer tout cela pour finalement se faire pigeonner de la sorte... C'est d'une cruauté sans nom..." },
            { "It is, I agree.\r\nAnd that's why we have to find those responsible and\r\nbring them to justice.", "C'est vrai, je vous l'accorde. Et c'est pourquoi nous devons démasquer les coupables et les traduire en justice." },
            { "Mr Asman is no more, of course.\r\nWhich leaves only the engineer...\r\n...Mr Enoch Drebber.", "M. Asman n'est plus de ce monde, évidemment. Ce qui ne laisse plus que l'ingénieur... M. Enoch Drebber." }
        });

        // [107] KEY:BB\script\output\_sce02_chr230_01_eng#4
        add(@"BB\script\output\_sce02_chr230_01_eng#4", new string[,] {
            { "Is he an engineer...or a magician...or a swindler?", "Est-il un ingénieur... un illusionniste... ou un escroc ?" },
            { "It, it was about a year ago when Mr Asman first brought\r\nDrebber to meet me at my laboratory.\r\nSince then I've met him many times to discuss details\r\nabout the kinesis machine.", "C'est... c'était il y a environ un an que M. Asman m'a présenté Drebber à mon laboratoire. Depuis, nous nous sommes rencontrés à maintes reprises pour régler les détails de l'appareil cinétique." },
            { "But at no point did you have any inkling that he was just\r\nan illusionist?", "Mais à aucun moment vous n'avez soupçonné qu'il n'était qu'un illusionniste ?" },
            { "Oh, he definitely wasn't just an illusionist.\r\n...What do you mean?\r\nHe was a wealth of deep scientific knowledge.", "Oh, il n'était assurément pas qu'un simple illusionniste. ...Que voulez-vous dire ? C'était un puits de science aux connaissances approfondies." }
        });

        // [108] KEY:BB\script\output\_sce02_chr230_01_eng#5
        add(@"BB\script\output\_sce02_chr230_01_eng#5", new string[,] {
            { "So you've been to Drebber's place of work, then?", "Vous vous êtes donc rendu dans l'atelier de Drebber ?" },
            { "Yes...just once, you understand.\r\nIt, it was an enormous place. Plenty of room to construct\r\nthe kinesis machine, you see.", "Oui... une seule fois, comprenez bien. C-C'était un endroit gigantesque. Tout l'espace nécessaire pour y bâtir l'appareil cinétique." },
            { "Where can we find it?!\r\nWe have to go there at once!\r\nThere's a good chance that we'll find Drebber there!", "Où pouvons-nous le trouver ?!\r\nNous devons nous y rendre sans attendre !\r\nIl y a de fortes chances que Drebber s'y terre !" },
            { "Well, yes... Definitely. I'm sure! As in...\r\nI'm sure you're not going to want to hear this...", "Eh bien, oui... Absolument. J'en suis sûr ! Enfin...\r\nJe suis sûr que vous n'allez pas aimer ce qui va suivre..." },
            { "...but I have absolutely no idea where the workshop is at\r\nall.\r\nI'm so sorry!", "...mais je n'ai absolument aucune idée de l'endroit où se situe cet atelier.\r\nJe suis sincèrement navré !" },
            { "...I was more than half expecting that.", "...Je m'y attendais plus qu'à moitié." },
            { "You see, I was blindfolded in the carriage the entire way\r\nthere.", "Voyez-vous, j'ai eu les yeux bandés dans le fiacre pendant tout le trajet." },
            { "He blindfolded you?\r\nHe wasn't taking any chances then...", "Il vous a bandé les yeux ?\r\nIl ne laissait rien au hasard..." },
            { "The place was incredible!\r\nThe pinnacle of modern engineering!", "L'endroit était stupéfiant !\r\nLe summum de la mécanique moderne !" },
            { "E-Even the oil he used was the very best. A special\r\nFrench machine oil that's impossible to obtain in Britain.\r\nAah, the indescribable scent of that imported oil...\r\nPerfumers across the world should forget their secret\r\nformulae and use that instead!", "M-Même l'huile qu'il utilisait était la plus raffinée. Une huile pour machine française introuvable en Grande-Bretagne. Ah, l'arôme indescriptible de cette huile d'importation... Les parfumeurs du monde entier devraient jeter leurs formules secrètes et utiliser cela à la place !" },
            { "What do you think, Miss Susato?\r\nEau de Machine for your next birthday?", "Qu'en pensez-vous, Mademoiselle Susato ?\r\nDe « l'Eau de Machine » pour votre prochain anniversaire ?" },
            { "I've never used any kind of perfume, Mr Naruhodo.\r\nAnd I'm not sure I'd like to start with that...", "Je n'ai jamais porté le moindre parfum, Monsieur Naruhodo.\r\nEt je ne suis guère tentée de commencer par celui-ci..." }
        });

        // [109] KEY:BB\script\output\_sce02_chr230_01_eng#6
        add(@"BB\script\output\_sce02_chr230_01_eng#6", new string[,] {
            { "I don't suppose you know even part of the workshop's\r\naddress, Professor?\r\nYou...don't have a business card from Mr Drebber, for\r\nexample?", "Je suppose que vous n'avez pas retenu le moindre fragment d'adresse, Professeur ? Vous... n'auriez pas une carte de visite de M. Drebber par exemple ?" },
            { "The man was clearly very cautious, Miss Susato.\r\nI'm sure he would never have–", "L'homme était d'une prudence extrême, Mademoiselle Susato. Je doute fort qu'il ait jamais..." },
            { "AAAH-HAAAAAAAAAH!\r\nYes, I do! He gave me his business card once!\r\nIt's right here, look!", "AAAH-HAAAAAAAAAH !\r\nMais si ! Il m'a donné sa carte de visite une fois !\r\nElle est juste là, regardez !" },
            { "What?!", "Quoi ?!" },
            { "Let me see that!", "Faites-moi voir ça !" },
            { "(Throw etiquette to the wind, why don't you?)", "(Et voilà les bonnes manières jetées aux orties...)" }
        });

        // [110] KEY:BB\script\output\_sce02_chr231_01_eng#1
        add(@"BB\script\output\_sce02_chr231_01_eng#1", new string[,] {
            { "What on earth happened in here?", "Que diable s'est-il passé ici ?" },
            { "You've found me, haven't you?\r\nNo need to screw me down any further.\r\nEverything in here...is precisely what it seems.", "Vous m'avez trouvé, n'est-ce pas ? Inutile de me serrer la vis davantage. Tout ici... est exactement ce qu'il paraît." },
            { "Yeah, well we'll be givin' it a thorough goin' over, don't\r\nyou worry, Drebber.", "Ouais, eh bien on va passer tout ça au peigne fin, t'en fais pas pour ça, Drebber." },
            { "What fails to click with me...\r\n...is how you were able to locate my workshop.\r\nThat I was not expecting.", "Ce qui échappe à mes rouages...\r\n...c'est la façon dont vous avez localisé mon atelier.\r\nVoilà qui m'a pris de court." },
            { "When I heard whistling from the other room, I knew it\r\nwas time to bolt.", "En entendant siffloter dans la pièce d'à côté, j'ai compris qu'il était temps de déguerpir." },
            { "Whistling?", "Siffloter ?" },
            { "Ah. That would have been me.", "Ah. C'était sans doute moi." },
            { "Oh!", "Oh !" },
            { "For some reason, I woke in fine fettle today!", "Sans doute parce que j'étais d'une humeur massacrante et pétillante ce matin !" },
            { "(No words...just tightly squeezed chips...)", "(Pas un mot... juste ses frites broyées dans ses doigts...)" },
            { "Clearly I must have a screw loose, though, as I couldn't\r\nremember the combination for the safe.\r\nAnd another one loose, as I couldn't remember on which\r\npiece of furniture I'd written it down.", "J'avais manifestement un boulon de travers, car impossible de me souvenir de la combinaison du coffre-fort. Et un autre bien desserré, car je ne savais plus sur quel meuble je l'avais notée." },
            { "We also found a rope over by the wall...", "Nous avons aussi trouvé une corde près du mur..." },
            { "Yes, I had hoped to exit through the skylight, but sadly\r\nthe rope was too short.\r\nSo...I then set about searching for the combination code\r\nto open the safe.", "En effet, j'espérais fuir par la lucarne, mais hélas la corde était trop courte. Alors... je me suis mis en quête du code secret pour ouvrir le coffre." },
            { "And burning the incriminating blueprints, don't forget.\r\nRegrettably, though, you failed to retrieve the head from\r\nthe balloon among the rafters.", "Sans oublier de brûler les plans compromettants. Hélas pour vous, vous n'avez pas pu récupérer la tête de cire suspendue dans le ballon sous la charpente." },
            { "And after that you hid yourself inside the safe?\r\nHaving first set this ‘parcel’ ticking.", "Et après cela, vous vous êtes terré dans le coffre ? Après avoir amorcé le compte à rebours de ce « colis »." },
            { "Well...I had no intention of being nailed by the police.", "Eh bien... je n'avais aucune envie de me faire pincer par la maréchaussée." }
        });

        // [111] KEY:BB\script\output\_sce02_chr231_01_eng#2
        add(@"BB\script\output\_sce02_chr231_01_eng#2", new string[,] {
            { "Got a death wish, have ya? Hidin' right beside a tickin'\r\ntime bomb.", "T'as des envies d'suicide ou quoi ? Te planquer juste à côté d'une bombe à retardement !" },
            { "Please... Why do you suppose I chose to hide inside the\r\nsafe?\r\nIt's no ordinary safe. It's specially designed. A dynamite\r\nexplosion wouldn't leave a scratch on it.", "De grâce... Pourquoi croyez-vous que j'aie choisi de m'enfermer dans ce coffre ? Ce n'est pas un coffre ordinaire. Il est blindé. Une déflagration de dynamite ne lui causerait pas la moindre égratignure." },
            { "So in fact, the safe was the only ‘safe’ place.\r\nPrecisely.", "En clair, le coffre-fort était le seul endroit sûr.\r\nPrécisément." },
            { "But once you'd climbed inside, you wouldn't have been\r\nable to get out again...", "Mais une fois à l'intérieur, vous n'auriez jamais pu en ressortir..." },
            { "I invite you to look more closely.\r\nThe safe is fitted with a handle on the inside, to allow the\r\ndoor to be unlocked from within.", "Je vous invite à y regarder de plus près. Le coffre est muni d'une poignée intérieure permettant de le déverrouiller depuis les entrailles." },
            { "Ah! So it is...", "Ah ! En effet..." },
            { "I had always intended to blow this place to smithers in\r\nany case.\r\nI just wasn't expecting uninvited guests to come along and\r\nscrew up my plans.", "J'avais de toute façon prévu de réduire cet endroit en miettes. Je ne m'attendais simplement pas à ce que des intrus viennent gripper mes rouages." },
            { "Do you...do you mean to say...you were plannin' to blow\r\nus all up?!", "Tu... tu veux dire... que tu comptais tous nous faire sauter avec ?!" },
            { "No. No. That was unforeseen.\r\nWhat do you mean?\r\nMost people run, you see. When they see a ticking time\r\nbomb at their feet.\r\nAh...\r\nI calculated the time required for retreat to a safe\r\ndistance, and set the device accordingly.\r\nBut your seemingly endless discourse in here threw a\r\nspanner in the works.", "Non. Non. C'était imprévu. Que voulez-vous dire ? Le commun des mortels prend la fuite, voyez-vous. Quand il découvre une bombe amorcée à ses pieds. Ah... J'avais minutieusement calculé le temps nécessaire pour évacuer à bonne distance, et réglé le minuteur en conséquence. Mais vos palabres interminables ont tout fait dérailler." },
            { "Is something wrong, Gregson?\r\nDo I have something on my face...besides the usual eyes,\r\nears, nose and mouth?", "Un souci, Gregson ? Ai-je quelque chose sur la figure... hormis mes yeux, mon nez et ma bouche habituels ?" }
        });

        // [112] KEY:BB\script\output\_sce02_chr231_01_eng#4
        add(@"BB\script\output\_sce02_chr231_01_eng#4", new string[,] {
            { "Mr Drebber, look at this, please.", "M. Drebber, regardez ceci s'il vous plaît." },
            { "Do you, um...have anything to say about it?", "Avez-vous, hum... quelque chose à déclarer à ce sujet ?" },
            { "(Are these strange mechanical movements supposed to be\r\nsome sort of answer...?)", "(Ces mouvements mécaniques saccadés sont-ils censés constituer une réponse...?)" }
        });

        // [113] KEY:BB\script\output\_sce02_chr231_01_eng#5
        add(@"BB\script\output\_sce02_chr231_01_eng#5", new string[,] {
            { "It might surprise you to learn that I'm actually a lawyer\r\nfrom the Empire of Japan.", "Cela pourrait vous surprendre, mais je suis en réalité avocat de la défense venu de l'Empire du Japon." },
            { "...I detest lawyers.\r\nThey wield so-called ‘special powers’ in an attempt to\r\ngrind down our freedoms.\r\nYes, let me be quite clear:\r\nI detest lawyers very much.", "...J'abhorre les hommes de loi. Ils brandissent de prétendus « pouvoirs extraordinaires » pour rogner nos libertés. Oui, laissez-moi être on ne peut plus clair : j'exècre souverainement les avocats." },
            { "(Any chance two negatives make a positive...?)", "(Une chance que deux négations s'annulent...?)" }
        });

        // [114] KEY:BB\script\output\_sce02_chr322_00_eng#1
        add(@"BB\script\output\_sce02_chr322_00_eng#1", new string[,] {
            { "Did you make all these waxworks, Madame Tusspells?", "Avez-vous sculpté toutes ces statues de cire, Madame Pétrie ?" },
            { "I did. I am the third generation of waxwork artisans, you\r\nknow.", "En effet. Je représente la troisième génération de maîtres cirières, voyez-vous." },
            { "Gosh!\r\nIt was my grandmother who began the tradition in my\r\nfamily.\r\nHer fortunes were chequered, living through the\r\nturbulent times of the French Revolution as she did.\r\nThough that is when she acquired the savoir-faire that\r\nleads to the astonishing lifelikeness.", "Ça alors !\r\nC'est ma grand-mère qui a initié la tradition familiale.\r\nSon destin fut tourmenté, ayant traversé les affres de la Révolution française.\r\nMais c'est là qu'elle a acquis le savoir-faire conférant ce réalisme si saisissant." },
            { "All these waxworks really do look as though they're alive!\r\nIn fact, they look more alive than Hurley.", "Toutes ces statues ont vraiment l'air vivantes ! À vrai dire, elles ont l'air plus vivantes que Sherlockinou." },
            { "Hehe...\r\nWhat you see exhibited here represents the most\r\natrocious of London's criminal past.\r\nAll the waxworks were created in the presence of the\r\nreal people on which they are modelled...\r\n...in the hours immediately following their executions.\r\nThat...is the secret to the extraordinary lifelikeness.", "Hé hé... Ce que vous contemplez ici rassemble le passé criminel le plus abominable de Londres. Toutes ces statues ont été moulées sur le vif, d'après les modèles réels... dans les heures qui ont suivi leur exécution. Voilà... le secret de leur réalisme stupéfiant." },
            { "That sounds...terrifying.", "Cela paraît... terrifiant." },
            { "All walks of life have similar challenges, I'm sure.\r\nTo carry out one's trade par excellence, one must go to\r\nextraordinary lengths.\r\nMy exhibits are a reflection of society. I create only that\r\nwhich the public wishes to see.", "Chaque métier a ses exigences, n'est-ce pas. Pour exercer son art avec excellence, il faut savoir consentir à de grands sacrifices. Mes œuvres sont le miroir de notre société. Je ne modèle que ce que le public réclame." },
            { "(Ugh... Why couldn't the public have wished for something\r\nless horrifying?)", "(Pfff... Pourquoi le public ne réclame-t-il pas des choses un peu moins morbides ?)" },
            { "Do not fear...\r\nSorry?\r\nThis room is the only one in the museum with such a\r\nmacabre theme. I do hope you'll explore.\r\nThere are models of famous singers, actors, politicians...\r\nSomething for every taste, I hope.", "Ne craignez rien... Pardon ? Cette galerie est la seule du musée à afficher un thème aussi macabre. J'espère que vous visiterez le reste. Il s'y trouve des représentations d'illustres chanteurs, de comédiens, d'hommes d'État... De quoi combler tous les goûts, je l'espère." },
            { "(It was Iris who dragged me straight in here, come to\r\nthink of it.)", "(À bien y réfléchir, c'est Iris qui m'a traîné directement ici.)" }
        });

        // [115] KEY:BB\script\output\_sce02_chr322_00_eng#2
        add(@"BB\script\output\_sce02_chr322_00_eng#2", new string[,] {
            { "Um, what's the situation with...that?", "Hum, quelle est la situation avec... ça ?" },
            { "Ah, my temporary waxwork model?\r\nHe approached me some days ago, you see.\r\nWith a business proposal.", "Ah, mon modèle de cire temporaire ? Il est venu me trouver il y a quelques jours, voyez-vous. Avec une proposition commerciale." },
            { "Oh. What sort of proposal?", "Oh. Quel genre de proposition ?" },
            { "My dear madame, what these sparse exhibits need is the\r\naddition of a world-famous great detective!", "Ma chère madame, ce dont votre modeste musée a besoin, c'est de l'adjonction d'un grand détective de renommée mondiale !" },
            { "...Or words to that effect.\r\nHaah...\r\nNaturally, I am well aware that Mr Sholmes is widely\r\nknown in London as a talented detective.", "...Ou quelque chose d'approchant. Soupir... Naturellement, je n'ignore pas que M. Holmes jouit à Londres de la réputation d'un détective talentueux." },
            { "It's ‘great detective’ actually. He's very specific about it.", "« Grand détective », en réalité. Il y tient énormément." },
            { "Yes, the crème de la crème. So I was keen to come to\r\nsome arrangement with him, of course.\r\nBut sadly, we were unable to agree terms.", "Oui, la crème de la crème. J'étais donc disposée à conclure un arrangement avec lui, bien sûr. Mais hélas, nous n'avons pu nous accorder sur les conditions." },
            { "Let me guess: someone wanted to charge an exorbitant\r\nprice for his services?", "Laissez-moi deviner : quelqu'un demandait des honoraires exorbitants ?" },
            { "For a mere five hundred pounds, I will dive into your\r\ncauldron of wax this very moment!", "Pour la modique somme de cinq cents livres, je plonge dans votre chaudron de cire à l'instant même !" },
            { "...Or words to that effect.\r\n(Mr Sholmes might have overdone it slightly with the\r\nsales pitch...)", "...Ou quelque chose du genre. (M. Holmes a peut-être eu les yeux un peu plus gros que le ventre...)" },
            { "Regrettably...the museum has a shortage of funds at the\r\nmoment, due to...unforeseen circumstances.\r\nSo we came to the current arrangement instead.", "Malheureusement... le musée traverse une passe financière difficile, due à des... circonstances imprévues. Nous avons donc convenu de cet arrangement temporaire." },
            { "Surely he doesn't really need to do what he's doing\r\nthough, does he?\r\nI would think not, but...he was very insistent.", "Mais enfin, il n'a tout de même pas besoin de faire le piquet comme ça, si ? Je ne pense pas, mais... il a insisté lourdement." },
            { "I have a fifty-shilling problem that must be resolved by\r\nthe morning!", "J'ai une ardoise de cinquante shillings à régler avant demain matin !" }
        });

        // [116] KEY:BB\script\output\_sce02_chr322_00_eng#3
        add(@"BB\script\output\_sce02_chr322_00_eng#3", new string[,] {
            { "Um, I wonder...could I ask you something?", "Hum, dites-moi... pourrais-je vous poser une question ?" },
            { "Bien sûr...", "Bien sûr..." },
            { "I'm just curious. Is anything going on in the museum at the\r\nmoment. Some kind of incident, perhaps?", "Je suis simplement curieux. Se passe-t-il quelque chose d'anormal au musée en ce moment ? Un incident particulier, peut-être ?" },
            { "Whoever suggested such a thing to you?", "Qui a bien pu vous suggérer une chose pareille ?" },
            { "Oh, well, it was...\r\n...your temporary waxwork over there who mentioned\r\nit to me a little–\r\nOh!\r\n(He's disappeared!)", "Oh, eh bien... c'est... votre statue de cire vivante là-bas qui m'a glissé deux mots sur... Oh ! (Il a disparu !)" }
        });

        // [117] KEY:BB\script\output\_sce02_chr322_00_eng#5
        add(@"BB\script\output\_sce02_chr322_00_eng#5", new string[,] {
            { "Could I show you this?", "Puis-je vous montrer ceci ?" },
            { "Oh, how fascinating! Is this made of wax?", "Oh, quelle merveille ! Est-ce moulé dans la cire ?" },
            { "...No. Sorry. It's a piece of evidence.", "...Non. Désolé. C'est une pièce à conviction." },
            { "Why would you want to show me this?", "Dans ce cas, pourquoi vouloir me montrer cela ?" },
            { "(She can only wax lyrical about wax, is that it?)", "(Elle ne jure que par la cire, on dirait bien...)" }
        });

        // [118] KEY:BB\script\output\_sce02_chr322_00_eng#6
        add(@"BB\script\output\_sce02_chr322_00_eng#6", new string[,] {
            { "Madame, there's something I'd like to show you...", "Madame, il y a quelque chose que j'aimerais vous montrer..." },
            { "Yes, what is that? I remarked on it to myself immediately\r\nand I've been very curious since.", "Oui, de quoi s'agit-il ? Je l'ai remarqué immédiatement et cela attisait ma curiosité." },
            { "Ah, well, it's actually the mark of a defence lawyer...in the\r\nEmpire of Japan.", "Ah, eh bien, c'est le brassard d'avocat de la défense... de l'Empire du Japon." },
            { "Oh. Quel dommage.\r\nNot quite as interesting as I'd hoped.", "Oh. Quel dommage. Ce n'est guère aussi captivant que je l'espérais." },
            { "(What exactly were you expecting from an armband?)", "(Qu'attendiez-vous donc d'un simple brassard ?)" }
        });

        // [119] KEY:BB\script\output\_sce02_chr322_00_eng#7
        add(@"BB\script\output\_sce02_chr322_00_eng#7", new string[,] {
            { "Tell us more about the stolen waxwork, please.", "Racontez-nous davantage au sujet de la statue dérobée, s'il vous plaît." },
            { "It was some days ago now, when I came in here one\r\nmorning.\r\nI immediately noticed that a waxwork was missing from\r\nthe special exhibit here!", "C'était il y a quelques jours, alors que je venais ouvrir un matin. J'ai immédiatement constaté la disparition d'une statue dans cette exposition spéciale !" },
            { "It is your most prominent display.\r\nSo...that's why the curtains were closed.", "C'est votre attraction principale. Voilà donc... pourquoi les rideaux étaient tirés." },
            { "And I found the ransom note in its place.", "Et j'ai trouvé la demande de rançon à sa place." },
            { "The culprit must have broken in during the night and\r\ntaken it, then?", "Le malfaiteur a dû s'introduire de nuit pour s'en emparer, alors ?" },
            { "So this waxwork that was stolen...\r\nIt was a model of some horrible criminal, I suppose?", "Cette statue qui a été volée... C'était la réplique d'un sinistre malfrat, j'imagine ?" },
            { "Of a particularly horrible criminal, in fact.\r\nThe killer who left a more profound scar on society than\r\nany other, I would say: the Professor.", "D'un criminel particulièrement abominable, à dire vrai. Du meurtrier qui a laissé la balafre la plus indélébile dans notre société : le Démon Assassin." },
            { "(Not a name I've heard of.)", "(Un nom dont je n'ai jamais entendu parler.)" },
            { "So, Mr Naruhodo...it seems the circle is complete.", "Ainsi, Monsieur Naruhodo... la boucle est bouclée." },
            { "Sorry?", "Pardon ?" },
            { "The Professor case happened at around the time I was\r\nborn, didn't it?", "L'affaire du Démon Assassin a eu lieu vers l'époque de ma naissance, n'est-ce pas ?" },
            { "Indeed it did, Iris.\r\nTen years ago. A series of murders that rocked the\r\ncapital.", "Tout à fait, Iris. Il y a dix ans. Une série de meurtres effroyables qui a ébranlé la capitale." },
            { "Ten years ago?\r\nYes. At exactly the time...\r\n...that Barok van Zieks graduated from university, in fact.", "Il y a dix ans ? Oui. Très exactement au moment... où Drake Van Peers achevait ses études de droit, en fait." },
            { "What? (S-Surely he's not saying...?)", "Quoi ? (I-Il ne veut tout de même pas insinuer que...?)" },
            { "So the big event that changed Mr Reaper's life...\r\nAs you've surmised. It was the Professor case.", "Alors le grand drame qui a bouleversé la vie de M. le Faucheur... Vous l'avez deviné. C'était l'affaire du Démon Assassin." },
            { "Who was this Professor then?", "Qui était donc ce Démon Assassin ?" }
        });

        // [120] KEY:BB\script\output\_sce02_chr322_00_eng#8
        add(@"BB\script\output\_sce02_chr322_00_eng#8", new string[,] {
            { "It was a series of gruesome murders that had all of\r\nLondon gripped in terror a decade ago.\r\nAfter five victims were killed, the man was arrested, and\r\nput to death.", "C'était une série d'homicides barbares qui a plongé tout Londres dans l'épouvante il y a dix ans. Après cinq victimes massacrées, le coupable a été arrêté et exécuté." },
            { "And now he's immortalised here in wax for all Londoners\r\nto admire and enjoy!\r\nThough of course, he happens to be absent at present, on\r\naccount of the abduction.", "Et le voilà désormais immortalisé dans la cire pour le frisson de tous les Londoniens ! Bien que pour l'heure, il brille par son absence pour cause d'enlèvement." },
            { "But I don't understand.\r\nHow is all this related to Lord van Zieks?", "Mais je ne comprends pas. Quel est le lien avec Lord Van Peers ?" },
            { "You must first understand, my dear fellow, why it is that\r\nthe Professor earnt such infamy.\r\nIt was due to the victims he chose. Some of Whitehall's finest.", "Vous devez d'abord saisir, mon cher ami, la raison pour laquelle le Démon Assassin s'est forgé une réputation aussi sinistre. Tout réside dans le choix de ses victimes. L'élite de la haute société." },
            { "What do you mean, Hurley?", "Que veux-tu dire, Sherlockinou ?" },
            { "Those murdered by the Professor were some of the\r\nhighest members of the British aristocracy.\r\nMembers of the nobility. Even royalty. It sent\r\nshockwaves through the country's administration.", "Les victimes du Démon Assassin comptaient parmi les plus hauts dignitaires de l'aristocratie britannique. Des membres de la noblesse. Et même un prince de sang. Cela a provoqué un véritable séisme au sommet de l'État." },
            { "Members of the...\r\nAh! Wait! Of course!\r\nWhat Professor Harebrayne said!\r\nLord van Zieks is from a family with noble blood!", "Des membres de la...\r\nAh ! Attendez ! Évidemment !\r\nCe que disait le professeur Lonron !\r\nLord Van Peers est issu d'une illustre lignée noble !" },
            { "Oh gosh!", "Bonté du ciel !" },
            { "It was the fifth victim that led to the Professor's arrest.\r\nThe last of the killer's prey was a young noble by the\r\nname of...\r\n...Klint van Zieks.", "C'est la cinquième victime qui a conduit à la capture du Démon Assassin. La toute dernière proie du boucher était un jeune aristocrate du nom de... Klimt Van Peers." },
            { "No!\r\nI don't believe it!\r\nVan Zieks?!", "Non !\r\nCe n'est pas possible !\r\nVan Peers ?!" },
            { "I'm sure you can piece together the rest for yourself.\r\nIn the wake of his older brother's murder, the young\r\nBarok pursued a career as a prosecutor.\r\nAnd eventually...became the Reaper we know today.", "Je suis certain que vous pouvez reconstituer la suite par vous-même. Au lendemain du meurtre de son frère aîné, le jeune Drake a embrassé la carrière de procureur. Pour devenir par la suite... le Faucheur que nous connaissons aujourd'hui." },
            { "I had no idea Lord van Zieks had such a tragic past...", "J'ignorais totalement que Lord Van Peers avait un passé aussi tragique..." },
            { "Well, I'm afraid that's all I can say on the matter.\r\nFor the time being at least.\r\nAfter all, I have work to do...\r\n...as a waxwork exhibit.", "Bien, j'ai peur que ce ne soit tout ce que je puisse révéler. Pour l'instant du moins. Après tout, j'ai du pain sur la planche... en tant que statue de cire vivante." },
            { "I am afraid I shall have to excuse myself as well.", "Je crains de devoir prendre congé également." },
            { "Oh, yes, of course.\r\nIt's, it's been a pleasure. Thank you.", "Oh, oui, bien entendu. C-C'était un réel plaisir. Merci." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part3_B.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part3_B written.");
    }
}
