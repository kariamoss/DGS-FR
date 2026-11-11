using System;
using System.IO;
using System.Text;

class MakeEp4Act3Part4 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act3 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart4() {");

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

        // [81] KEY:BB\script\output\_sce03_c103_0010_eng#21
        add(@"BB\script\output\_sce03_c103_0010_eng#21", new string[,] {
            { "...It was five o'clock in the afternoon that you all heard\r\nthe loud bang, ", "...C'est bien à cinq heures de l'après-midi que vous avez tous\r\nentendu cette forte détonation, " },
            { "wasn't it?", "n'est-ce pas ?" },
            { "Maybe the n-noticeboard fell over, ", "P-Peut-être bien qu'le panneau est tombé, " },
            { "or maybe it d-didn't.", "ou p-peut-être pas." },
            { "Maybe I fell over, ", "Peut-être que j'suis tombé, " },
            { "or m-m-maybe I didn't...", "ou p-p-peut-être pas..." },
            { "But the Reaper's f-fate is sealed either way, ", "Mais le s-sort du Faucheur est scellé d'toute façon, " },
            { "because of\r\nthat gunshot w-we all heard.", "à cause de\r\nc'coup d'feu qu'on a t-tous entendu." },
            { "So your fate's sealed, too.", "Alors vot' sort est scellé aussi." },
            { "My fate?!", "Mon sort ?!" },
            { "That's right.", "C'est exact." },
            { "The defence is fated to lose.", "La défense est vouée à perdre." },
            { "And the prosecution to win.", "Et l'accusation à triompher." },
            { "(In other words, ", "(En d'autres termes, " },
            { "it all hinges on that single gunshot.)", "tout repose sur ce seul coup de feu.)" },
            { "(So if I could just find some problem with that part of\r\ntheir story...)", "(Si seulement je pouvais trouver une faille dans cette partie\r\nde leur récit...)" },
            { "It may be possible ", "Il est peut-être possible " },
            { "to change all our fates!", "de changer tous nos destins !" },
            { "Of course...", "Évidemment..." },
            { "n-none of that changes the fact that I heard\r\nwhat I heard...", "r-rien de tout ça n'change le fait qu'j'ai entendu\r\nce qu'j'ai entendu..." },
            { "does it?", "pas vrai ?" }
        });

        // [82] KEY:BB\script\output\_sce03_c103_0010_eng#23
        add(@"BB\script\output\_sce03_c103_0010_eng#23", new string[,] {
            { "Something wrong, ", "Un problème, " },
            { "Mr Sandwich?", "monsieur Sandwich ?" },
            { "If, ", "S-" },
            { "if I said it was, ", "si j'disais qu'oui, " },
            { "could we just l-leave it at that?", "est-ce qu'on pourrait en r-rester là ?" },
            { "Would that be the end of it?", "Est-ce que ça s'arrêterait là ?" },
            { "Um...", "Euh..." },
            { "no.", "non." },
            { "Did Miss Venus's statement just now bring something to\r\nmind, ", "La déposition de mademoiselle Vénus vous a-t-elle rappelé\r\nquelque chose, " },
            { "perhaps?", "par hasard ?" },
            { "Philosophical thoughts.", "Des pensées philosophiques." },
            { "Deep, ", "De profondes, " },
            { "philosophical thoughts.", "réflexions philosophiques." },
            { "Hm?", "Hein ?" },
            { "L-Let's say there was a great liar.", "D-Disons qu'il y avait un grand menteur." },
            { "And that g-great liar said, ", "Et qu'ce g-grand menteur disait, " },
            { "without batting an eye...", "sans sourciller..." },
            { "‘Tellin' bare-faced lies is kind of my thing.", "« Raconter des bobards éhontés, c'est un peu mon truc." },
            { "I'm ever so good at it.’", "J'y suis rudement douée. »" },
            { "W-Would those words of hers be a lie, too?", "E-Est-ce que ses paroles seraient un mensonge, elles aussi ?" },
            { "Or the truth?", "Ou la vérité ?" },
            { "In which case...", "Auquel cas..." },
            { "she's n-not a liar.", "elle n-n'est pas une menteuse." },
            { "Ooh, ", "Ooh, " },
            { "it's a h-hellish paradox, ", "c'est un p-paradoxe infernal, " },
            { "that one.", "celui-là." },
            { "Don't you think?", "Vous n'trouvez pas ?" },
            { "I'm not entirely sure, ", "Je ne suis pas tout à fait certain, " },
            { "to be honest.", "pour être honnête." },
            { "But...", "Mais..." },
            { "it seems to me you're suggesting Miss Venus has\r\nbeen lying...", "il me semble que vous insinuez que mademoiselle Vénus a\r\nmenti..." },
            { "are you?", "n'est-ce pas ?" },
            { "What are you on about, ", "Qu'est-ce que tu baves, " },
            { "old man?", "le vieux ?" },
            { "Tryin' to cause trouble, ", "Tu cherches les embrouilles, " },
            { "are you?", "ma parole ?" },
            { "Keep on like that...", "Continue comme ça..." },
            { "...and I'll wrap your whole body in firecrackers and set\r\n'em off.", "... et j't'enroule tout l'corps d'pétards avant d'les allumer." },
            { "That'll give you somethin' to tremble about!", "Ça t'donnera une vraie raison d'trembler !" },
            { "You have a startlingly disturbing mind behind that sweet\r\nand innocent face, ", "Vous avez un esprit étonnamment dérangeant derrière ce doux\r\net innocent visage, " },
            { "young lady.", "mademoiselle." },
            { "So ", "Donc " },
            { "Miss Venus HAS lied in her testimony!", "mademoiselle Vénus A menti dans sa déposition !" },
            { "Is that what you're saying, ", "Est-ce bien ce que vous dites, " },
            { "Mr Sandwich?", "monsieur Sandwich ?" },
            { "Well...", "Eh bien..." },
            { "if it m-means I'll be burnin' in hellfire for the\r\nr-rest of my days...", "si ça v-veut dire qu'je brûlerai dans les feux d'l'enfer pour\r\nle r-reste de mes jours..." },
            { "so be it.", "qu'il en soit ainsi." },
            { "Yes, ", "Oui, " },
            { "that's what I'm saying.", "c'est c'que j'suis en train d'dire." },
            { "Can you elaborate, please, ", "Pouvez-vous préciser votre pensée, " },
            { "sir?", "s'il vous plaît ?" },
            { "Old b-blabbermouth here headed for the r-room where\r\nthe g-gunshot seemed to come from...", "Ce vieux b-bavard est monté vers la p-pièce d'où le\r\nc-coup d'feu semblait venir..." },
            { "...but there w-w-was someone else who crept up the\r\nstairs b-behind him, too.", "... mais y avait q-q-quelqu'un d'autre qui s'est faufilé dans\r\nl'escalier d-derrière lui." },
            { "That's right!", "C'est bien vrai !" },
            { "That rotten liar over there!", "Cette fieffée menteuse, là-bas !" },
            { "Heh heh...", "Hé hé..." },
            { "Do you mean to say...", "Voulez-vous dire..." },
            { "...that you did in fact ", "... que vous vous êtes rendue sur les lieux du crime " },
            { "betake yourself to the scene of the\r\ncrime after all?", "après tout ?" },
            { "What did I tell you, ", "Qu'est-ce que j'vous avais dit, " },
            { "eh?", "hein ?" },
            { "I said I was good at tellin' bare-faced lies, ", "J'ai dit qu'j'étais douée pour raconter des bobards, " },
            { "didn't I?", "non ?" },
            { "(Yes, ", "(Oui, " },
            { "you mentioned it...)", "vous l'aviez mentionné...)" },
            { "...that revelation ", "... cette révélation " },
            { "rocked the whole courtroom, ", "a secoué tout le tribunal, " },
            { "Who knew firecrackers packed such a punch?", "Qui aurait cru que des pétards feraient un tel effet ?" },
            { "So you did indeed visit the scene of the crime, ", "Vous vous êtes donc bel et bien rendue sur les lieux du crime, " },
            { "did you,", "mademoiselle ?" },
            { "young lady?", "" },
            { "Good ", "Grand " },
            { "grief!", "Dieu !" },
            { "Well, ", "Ben, " },
            { "now you come to mention it...", "maintenant qu'vous l'dites..." },
            { "...I suppose perhaps ", "... j'suppose que " },
            { "I do clearly remember climbin' the\r\nstairs to the room, ", "j'me rappelle très bien avoir monté\r\nl'escalier vers la pièce, " },
            { "yeah.", "ouais." },
            { "Either you clearly remember it or you don't.", "Soit vous vous en rappelez clairement, soit non." },
            { "I shall consider a fitting punishment for this\r\nperjurious act later.", "je songerai à un châtiment approprié pour ce\r\nparjure ultérieurement." },
            { "For the time being, ", "Pour l'heure, " },
            { "you will immediately amend your\r\ntestimony to reflect the truth!", "vous allez immédiatement modifier votre\r\ndéposition pour refléter la vérité !" },
            { "Oh yes, ", "Oh oui, " },
            { "My Lord.", "Votre Honneur." },
            { "Of course!", "Bien sûr !" }
        });

        // [83] KEY:BB\script\output\_sce03_c103_0010_eng#24
        add(@"BB\script\output\_sce03_c103_0010_eng#24", new string[,] {
            { "Mr Gossip!", "Monsieur Ragot !" },
            { "Do you have something to say?", "Avez-vous quelque chose à dire ?" },
            { "Mr Boone!", "Monsieur Boone !" },
            { "I do as it happens!", "Tout à fait, parbleu !" },
            { "Your timing's perfect.", "Vous tombez à pic." },
            { "I've just got wind of a juicy tale that'll be right up your\r\nsnicket.", "J'viens d'avoir vent d'une histoire croustillante qui va vous\r\nplaire à coup sûr." },
            { "You don't want to let this one slip by, ", "Vous n'voudriez pas laisser passer ça, " },
            { "I tell ya.", "j'vous l'dis." },
            { "And sixpence is all I ask...", "Et six pence, c'est tout c'que j'demande..." },
            { "...Maybe ", "... Essayez plutôt " },
            { "try Prosecutor Asogi instead.", "auprès du procureur Asogi." },
            { "I don't want your gossip, ", "Je n'ai que faire de vos ragots, " },
            { "Ryunosuke Naruhodo.", "Ryunosuke Naruhodo." }
        });

        // [84] KEY:BB\script\output\_sce03_c103_0010_eng#25
        add(@"BB\script\output\_sce03_c103_0010_eng#25", new string[,] {
            { "Well, Miss Venus?!", "Alors, mademoiselle Vénus ?!" },
            { "What do you say?", "Qu'avez-vous à dire ?" },
            { "I say ", "J'dis " },
            { "that'll be six 'undred pennies.", "que ça f'ra six cents pennies." },
            { "Sorry?", "Pardon ?" },
            { "That's my banter on the street whenever anyone comes\r\nalong.", "C'est mon boniment dans la rue dès qu'quelqu'un s'approche." },
            { "W-", "E-" },
            { "Well...", "Eh bien..." },
            { "this isn't Fresno Street.", "nous ne sommes pas dans Fresno Street." },
            { "Tsk!", "Tss !" },
            { "Miser!", "Radin !" }
        });

        // [85] KEY:BB\script\output\_sce03_c103_0010_eng#26
        add(@"BB\script\output\_sce03_c103_0010_eng#26", new string[,] {
            { "Mr Sandwich!", "Monsieur Sandwich !" },
            { "Do you perhaps have something to fill us in\r\nwith?", "Auriez-vous peut-être quelque chose à\r\nnous apprendre ?" },
            { "A w-wise philosopher once said that p-people are nothing\r\nmore than mindless signposts.", "Un s-sage philosophe a dit un jour que les g-gens ne sont rien\r\nde plus que des panneaux indicateurs sans âme." },
            { "Sorry?", "Pardon ?" },
            { "Which means...", "Ce qui veut dire..." },
            { "...that signposts are n-nothing more than mindless\r\npeople...", "... que les panneaux n-ne sont rien de plus que des gens\r\nsans cervelle..." },
            { "if you think about it.", "si on y réfléchit bien." },
            { "Perhaps mind less about philosophy and mind more\r\nabout the proceedings?", "Peut-être devriez-vous moins penser à la philosophie et vous\r\nsoucier un peu plus de la procédure ?" }
        });

        // [86] KEY:BB\script\output\_sce03_c103_0010_eng#33
        add(@"BB\script\output\_sce03_c103_0010_eng#33", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [87] KEY:BB\script\output\_sce03_c103_0020_eng#2
        add(@"BB\script\output\_sce03_c103_0020_eng#2", new string[,] {
            { "I'm afraid that's not necessarily the case.", "J'ai bien peur que ce ne soit pas nécessairement le cas." },
            { "Oh", "Oh" },
            { "At the scene, ", "Sur les lieux, " },
            { "we found this key to the winder of the\r\ninspector's pocket watch.", "nous avons trouvé cette clef du remontoir de\r\nla montre à gousset de l'inspecteur." },
            { "A key...?", "Une clef... ?" },
            { "And having wound the pocket watch, ", "Et après avoir remonté la montre à gousset, " },
            { "we discovered that\r\nit in fact still works.", "nous avons découvert qu'elle\r\nfonctionne toujours." },
            { "You see, ", "Voyez-vous, " },
            { "the watch didn't stop because it was broken at\r\nall.", "la montre ne s'est pas arrêtée parce qu'elle était\r\ncassée." },
            { "And that fact...", "Et ce fait..." },
            { "...completely undermines one of the most fundamental\r\npremises on which this entire case has been built!", "... ébranle totalement l'une des prémisses les plus fondamentales\r\nsur lesquelles toute cette affaire s'est construite !" },
            { "What?!", "Quoi ?!" },
            { "Ordaaar!", "Du caaalme !" },
            { "Orrrdaaar!", "Du caaaalme !" },
            { "B-", "M-" },
            { "But Counsel...", "Mais Maître..." },
            { "...the watch was stopped at almost exactly five o'clock.", "... la montre s'est arrêtée à cinq heures presque pile." },
            { "Yeah, which is just when we 'eard that gunshot.", "Ouais, pile au moment où on a entendu ce coup d'feu." },
            { "It is.", "C'est vrai." },
            { "Exactly the hour.", "Pile à l'heure." },
            { "The time that was showing on the watch tells us nothing", "L'heure qu'indiquait la montre ne nous apprend rien d'autre" },
            { "other than when it wound down.", "que le moment où son mécanisme s'est épuisé." },
            { "It's merely a coincidence that it happened to be at five\r\no'clock.", "C'est une pure coïncidence si c'est tombé précisément à\r\ncinq heures." },
            { "Even if that's true...", "Même si c'était vrai..." },
            { "...the three witnesses here all heard the gunshot at five\r\no'clock.", "... les trois témoins ici présents ont tous entendu le coup de feu\r\nà cinq heures." },
            { "So that's obviously when this crime was committed!", "C'est donc évidemment là que le crime a été commis !" },
            { "No, ", "Non, " },
            { "that doesn't hold!", "cela ne tient pas !" },
            { "Why not?", "Et pourquoi donc ?" },
            { "Recall what Inspector Lestrade said only moments ago:", "Rappelez-vous ce que l'inspectrice Lestrade disait il y a un instant :" },
            { "The boss used to wind it up every evenin' wivout fail\r\nwhen 'e was waitin' for 'is grub to come at the pub.", "L'patron la r'montait tous les soirs sans faute en attendant\r\nqu'on lui serve sa pitance au pub." },
            { "Said 'e 'adn't missed a day in the last ten years, polishin' it\r\nan' windin' it.", "Y disait qu'y avait pas raté un jour depuis dix ans, à la briquer\r\net à la r'monter." },
            { "It meant the world to 'im, that watch did.", "Elle comptait plus qu'tout pour lui, c'te montre." }
        });

        // [88] KEY:BB\script\output\_sce03_c103_0020_eng#3
        add(@"BB\script\output\_sce03_c103_0020_eng#3", new string[,] {
            { "The victim was in the habit of winding his watch once a\r\nday...", "La victime avait pour habitude de remonter sa montre une fois par\r\njour..." },
            { "in the evening.", "dans la soirée." },
            { "We can reasonably assume, therefore, that he wound the\r\ntimepiece on the evening before he died as well.", "On peut donc raisonnablement supposer qu'il a également remonté\r\nson garde-temps le soir précédant sa mort." },
            { "Yes, that would be entirely reasonable.", "Oui, ce serait tout à fait raisonnable." },
            { "But if that's the case...", "Mais si tel est le cas..." },
            { "...you wouldn't expect the watch to have completely\r\nwound down by five o'clock the following day.", "... on ne s'attendrait pas à ce que la montre se soit totalement\r\narrêtée dès cinq heures le lendemain après-midi." },
            { "Oh!", "Oh !" },
            { "Aye...", "Ça alors..." },
            { "Well 'ow do you explain it then?!", "Ben comment vous expliquez ça, alors ?!" },
            { "In summary, the evening before the day of the incident, when the gunshot rang out in that room...", "En résumé, le soir précédant le jour des faits, où la détonation a\r\nretenti dans cette pièce..." },
            { "...the inspector was already unable to wind his watch.", "... l'inspecteur était déjà dans l'incapacité de remonter sa montre." },
            { "You, you can't mean...", "Vous... vous ne voulez tout de même pas dire..." },
            { "What would stop a man winding his watch if he's been in\r\nthe habit of winding it every single evening for ten years?", "Qu'est-ce qui empêcherait un homme de remonter sa montre s'il en\r\navait l'habitude tous les soirs sans exception depuis dix ans ?" },
            { "The obvious answer...", "La réponse évidente..." },
            { "is that he was already dead!", "c'est qu'il était déjà mort !" },
            { "Ordaaar!", "Du caaalme !" },
            { "Orrrdaaar!", "Du caaaalme !" },
            { "Counsel, that is a most extraordinary claim!", "Maître, c'est une allégation tout à fait extraordinaire !" },
            { "Extraordinary isn't the word!", "Extraordinaire n'est pas le mot !" },
            { "It's absurd!", "C'est absurde !" },
            { "You claim he was already dead the night before?", "Vous prétendez qu'il était déjà mort la veille au soir ?" },
            { "Do you really think that Scotland Yard's coroner would\r\nhave overlooked something like that?!", "Pensez-vous vraiment que le légiste de Scotland Yard aurait pu\r\npasser à côté d'une chose pareille ?!" },
            { "Ah!", "Ah !" },
            { "W-Well, um...", "E-Eh bien, hum..." },
            { "On that subject, there is something rather surprising...", "À ce sujet, il y a un élément pour le moins surprenant..." },
            { "There's actually an omission in the coroner's report.", "Il y a en fait une omission dans le rapport d'autopsie." },
            { "The time of death is not noted.", "L'heure du décès n'est pas indiquée." },
            { "That's, that's right!", "C'est... c'est vrai !" },
            { "Wait a minute! You're forgetting that my legs went from\r\nunder me when I kicked the door in.", "Minute papillon ! Vous oubliez qu'mes guibolles m'ont lâché\r\nquand j'ai défoncé la porte." },
            { "What do you mean?", "Que voulez-vous dire ?" },
            { "Like I said, I planted my hand in a dirty great puddle of\r\nblood.", "Comme j'ai dit, j'ai fichu ma main dans une sacrée mare de\r\nsang." },
            { "Yes. So the victim's blood hadn't dried.\r\nIt was fresh.", "Oui. Le sang de la victime n'avait donc pas séché.\r\nIl était frais." },
            { "He catches on fast, dozn't he?", "Y comprend vite, dites donc !" },
            { "But that blood could be explained in any number of ways!\r\nIt could have been put there afterwards.", "Mais ce sang pourrait s'expliquer de bien des manières !\r\nIl aurait pu être déposé là après coup." },
            { "Some fresh blood could have been poured over the\r\nvictim's body after he–", "Du sang frais aurait pu être versé sur le corps de la victime\r\naprès qu'elle..." },
            { "Does my learned friend think that fresh blood is available\r\non every street corner?", "Mon confrère s'imagine-t-il que du sang frais se trouve à chaque\r\ncoin de rue ?" },
            { "Well, it needn't necessarily have been human blood, of\r\ncourse.", "Eh bien, il n'était pas nécessairement d'origine humaine,\r\nbien entendu." }
        });

        // [89] KEY:BB\script\output\_sce03_c103_0020_eng#4
        add(@"BB\script\output\_sce03_c103_0020_eng#4", new string[,] {
            { "We've been told previously that Scotland Yard has no\r\nway to identify blood as human.", "On nous a indiqué précédemment que Scotland Yard ne possède\r\naucun moyen de déterminer si un sang est d'origine humaine." },
            { "The problem is currently being researched.", "Cette question fait actuellement l'objet de recherches." },
            { "At present, you are correct. It is beyond our abilities.", "Pour l'instant, vous avez raison. C'est au-delà de nos capacités." },
            { "So then...a chicken's blood could have been used, for\r\nexample.", "Dès lors... du sang de poulet aurait très bien pu être utilisé,\r\npar exemple." },
            { "It's certainly a possibility that it wasn't the inspector's\r\nblood at all.", "Il est tout à fait possible qu'il ne s'agisse pas du sang de\r\nl'inspecteur." },
            { "But the gunshot was heard at five o'clock that afternoon.\r\nThat's beyond question!", "Mais la détonation a été entendue à cinq heures cet après-midi-là.\r\nC'est incontestable !" },
            { "Is it, though?", "L'est-elle vraiment ?" },
            { "What?!", "Quoi ?!" },
            { "Given that the time of death of the victim has already\r\nbeen called into question...", "Étant donné que l'heure du décès de la victime a déjà été remise\r\nen question..." },
            { "...it isn't beyond the realms of possibility that what these\r\nwitnesses heard wasn't a gunshot at all.", "... il n'est pas impossible que ce que ces témoins ont entendu\r\nne fût pas un coup de feu du tout." },
            { "Oh, please! What are you tryin' to say?", "Oh, pitié ! Qu'est-ce que vous essayez d'dire ?" },
            { "Uz lot know what we heard! And it woz a loud bang that\r\ncame from that there room!", "On sait c'qu'on a entendu, nous ! Et c'était une sacrée explosion\r\nqui venait d'cette pièce-là !" },
            { "Now y-you listen to me! A street seller's ears are his\r\nl-l-livelihood.", "M-Maintenant, écoutez-moi ! Les oreilles d'un camelot, c'est son\r\ng-g-gagne-pain." },
            { "I don't doubt your ears, sir. But all you can state with\r\ncertainty is that you heard a noise.", "Je ne doute point de vos oreilles, monsieur. Mais tout ce que\r\nvous pouvez affirmer avec certitude, c'est que vous avez entendu du bruit." },
            { "Eh?", "Hein ?" }
        });

        // [90] KEY:BB\script\output\_sce03_c103_0050_eng#2
        add(@"BB\script\output\_sce03_c103_0050_eng#2", new string[,] {
            { "Explain yourself then, Counsel.", "Expliquez-vous donc, Maître." }
        });

        // [91] KEY:BB\script\output\_sce03_c103_0050_eng#3
        add(@"BB\script\output\_sce03_c103_0050_eng#3", new string[,] {
            { "A noise that sounds like a gunshot could have been made\r\nwith...", "Un bruit ressemblant à un coup de feu a pu être produit\r\navec..." }
        });

        // [92] KEY:BB\script\output\_sce03_c103_0050_eng#4
        add(@"BB\script\output\_sce03_c103_0050_eng#4", new string[,] {
            { "Well, the culprit could have used something like this, for\r\nexample.", "Eh bien, le coupable aurait pu utiliser quelque chose comme ceci,\r\npar exemple." },
            { "Oh really? A demonstration is in order then, I feel.", "Vraiment ? Une démonstration s'impose dans ce cas, me semble-t-il." },
            { "Wha...?", "Quoi... ?" },
            { "Yes, please, show the court how you could use that to\r\ncreate a noise like a gunshot.", "Oui, je vous prie, montrez au tribunal comment vous pourriez\r\nutiliser ceci pour imiter une détonation." },
            { "...We're waiting, Counsel.", "... Nous attendons, Maître." },
            { "I may have been mistaken.", "J'ai pu me tromper." },
            { "It looks like you've been making a lot of noise yourself...\r\nMr Naruhodo.", "On dirait bien que c'est vous qui faites beaucoup de bruit pour\r\nrien... monsieur Naruhodo." },
            { "Ah!", "Ah !" },
            { "(Ugh...Kazuma's got a devastating way with words in\r\nEnglish, too.)", "(Argh... Kazuma manie le verbe de façon tout aussi cinglante\r\nen anglais.)" },
            { "I realise it may be difficult to retract what you said and\r\npresent some different evidence, but perhaps...", "Je conçois qu'il soit délicat de revenir sur vos propos pour\r\nprésenter une autre preuve, mais peut-être..." },
            { "(Yes, I was thinking the same thing myself.)", "(Oui, je me faisais la même réflexion.)" },
            { "That's because I'm convinced there is some evidence that\r\ncould produce a similar noise!", "C'est parce que je suis convaincu qu'il existe une preuve capable\r\nde produire une détonation similaire !" }
        });

        // [93] KEY:BB\script\output\_sce03_c103_0050_eng#5
        add(@"BB\script\output\_sce03_c103_0050_eng#5", new string[,] {
            { "Something like this. The culprit could have set off one of\r\nthese to fake a gunshot.", "Quelque chose comme ça. Le coupable aurait pu en allumer un pour\r\nsimuler un coup de feu." },
            { "Good gracious! The very fireworks that are sold by the\r\nwitness?", "Bonté divine ! Les feux d'artifice mêmes que vend le témoin ?" },
            { "...Now 'old on a minute!\r\nAre you sayin' I did it?!", "... Minute papillon !\r\nVous êtes en train d'dire que c'est moi qui l'ai fait ?!" },
            { "My pretty little firecrackers only make a little pop\r\nanyway. See?", "Mes jolis p'tits pétards n'font qu'un tout p'tit claquement\r\nd'toute façon. Vous voyez ?" },
            { "Not a hundred of them together. The Venus Special that\r\nyou sell for six hundred pennies sounds like this:\r\n...*BANG!*", "Pas une centaine attachés ensemble. Le Spécial Vénus que vous\r\nvendez six cents pence fait un bruit comme ça :\r\n... *BAAANG !*" },
            { "As the court can now attest...it sounds very much like a\r\ngunshot in fact.", "Comme le tribunal peut le constater... cela ressemble à s'y\r\nméprendre à un coup de feu." },
            { "Agh agh agh agh agh!", "Argh argh argh argh argh !" },
            { "You're trying to suggest that somebody set one of those\r\nfireworks off at the scene?", "Vous insinuez que quelqu'un aurait allumé l'un de ces pétards\r\nsur les lieux ?" },
            { "I'm suggesting that somebody knew the defendant was in\r\nthe room at five that day...\r\n...and sought to implicate him by creating a sound like a\r\ngunshot for these pedlars on Fresno Street to hear!", "Je suggère que quelqu'un savait que l'accusé se trouverait dans la pièce\r\nà cinq heures ce jour-là...\r\n... et a cherché à l'accuser en créant un bruit de coup de feu destiné\r\naux marchands de Fresno Street !" },
            { "But even the accused himself has testified that he saw no\r\none else in the room at the time.\r\nWhether it was a gun or a firecracker, the only person\r\npresent to cause that bang was Barok van Zieks!", "Mais l'accusé lui-même a déclaré n'avoir vu personne d'autre dans\r\nla pièce à ce moment-là.\r\nQu'il s'agisse d'un pistolet ou d'un pétard, la seule personne présente\r\npour provoquer cette détonation était Drake Van Peers !" },
            { "One whiff of a match and my firecrackers go pop.\r\nSee? It's why people like 'em.", "Une flammèche d'allumette et mes pétards font pan.\r\nVous voyez ? C'est pour ça qu'les gens les aiment." },
            { "I fear for your fingers, young lady.", "Je crains fort pour vos doigts, jeune fille." },
            { "Recently during my time here in Britain, I've learnt of a\r\nvery useful invention indeed.\r\nSomething called a, um...a time bomb.", "Récemment, durant mon séjour en Grande-Bretagne, j'ai découvert une\r\ninvention fort utile ma foi.\r\nQuelque chose qu'on appelle, euh... une bombe à retardement." },
            { "Good heavens! A bomb?!", "Juste ciel ! Une bombe ?!" },
            { "Yes, a device that allows you to blow up whatever you\r\nlike, whenever you like.", "Oui, un dispositif qui permet de faire exploser tout ce qu'on veut,\r\nquand on veut." },
            { "Mr Naruhodo. I worry that your unfortunate phrasing\r\nthere...may lead to yet another international incident.", "Monsieur Naruhodo. Je crains que votre formulation malheureuse...\r\nne mène à un nouvel incident diplomatique." },
            { "Ah! No no no! Wait! ...It's, it's the ‘whenever you like’ part\r\nthat's important.", "Ah ! Non non non ! Attendez ! ... C'est la partie « quand on veut »\r\nqui est primordiale." },
            { "A timed device?", "Un dispositif à retardement ?" },
            { "Yes! Exactly!\r\nA timed device!\r\nSomething of that nature could have been planted at the\r\nscene.\r\nA device that was able to produce the sound of a gunshot\r\nlong after the culprit had left.", "Oui ! Exactement !\r\nUn dispositif à retardement !\r\nQuelque chose de cette nature a pu être installé sur les lieux.\r\nUn dispositif capable de produire le bruit d'un coup de feu bien\r\naprès le départ du coupable." }
        });

        // [94] KEY:BB\script\output\_sce03_c103_0050_eng#6
        add(@"BB\script\output\_sce03_c103_0050_eng#6", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [95] KEY:BB\script\output\_sce03_c103_0060_eng#2
        add(@"BB\script\output\_sce03_c103_0060_eng#2", new string[,] {
            { "Your extravagant claim will have to be substantiated\r\nwith evidence, Counsel.", "Votre thèse extravagante devra être étayée par des preuves,\r\nMaître." }
        });

        // [96] KEY:BB\script\output\_sce03_c103_0060_eng#3
        add(@"BB\script\output\_sce03_c103_0060_eng#3", new string[,] {
            { "What proof do you have to suggest in any way that a\r\ntimed device was employed to create the gunshot sound?", "Quelle preuve avez-vous indiquant de quelque manière qu'un\r\ndispositif à retardement a été employé pour simuler le coup de feu ?" }
        });

        // [97] KEY:BB\script\output\_sce03_c103_0060_eng#4
        add(@"BB\script\output\_sce03_c103_0060_eng#4", new string[,] {
            { "You're suggesting this could have been used as some\r\nsort of ‘time delay’ device?", "Vous suggérez que ceci a pu servir de dispositif « à retardement » ?" },
            { "I...did think so, My Lord.", "Je... le pensais, Votre Honneur." },
            { "But it's becoming increasingly clear...", "Mais il devient de plus en plus évident..." },
            { "...that we've all been very misguided here.", "... que nous avons tous été induits en erreur." },
            { "Yes, by you.", "Oui, par vous." },
            { "Wha...?", "Quoi... ?" },
            { "No, Counsel, the time has come for a penalty.\r\nWithout delay.", "Non, Maître, le moment est venu d'appliquer une sanction.\r\nSans retardement." },
            { "(Ugh...no time to clear the area before the blast...)", "(Argh... pas le temps d'évacuer la zone avant l'impact...)" }
        });

        // [98] KEY:BB\script\output\_sce03_c103_0060_eng#5
        add(@"BB\script\output\_sce03_c103_0060_eng#5", new string[,] {
            { "As the court has already discussed, the tip of one of the\r\ncandles in this candelabrum has been blown off.", "Comme le tribunal l'a déjà évoqué, l'extrémité de l'une des\r\nbougies de ce candélabre a été sectionnée." },
            { "Indeed. Because it was struck by the bullet, which\r\npresumably passed through the victim.", "En effet. Car elle a été touchée par la balle, qui a\r\nvraisemblablement traversé la victime." },
            { "I don't think that's possible, My Lord.", "Je ne pense pas que ce soit possible, Votre Honneur." },
            { "Not possible? Why?", "Pas possible ? Pourquoi cela ?" },
            { "Because of the scorching.", "En raison des brûlures." },
            { "There are gunpowder scorch marks clearly visible on the\r\nbroken candle.", "Il y a des traces de brûlure de poudre bien visibles sur la\r\nbougie brisée." },
            { "There are? ...Goodness, yes!\r\nBut is it not the case...\r\n...that there was also scorching on the victim around the\r\nbullet entry wound?", "Vraiment ? ... Bonté divine, en effet !\r\nMais n'est-il pas vrai...\r\n... qu'il y avait également des brûlures sur la victime autour de\r\nla plaie d'entrée de la balle ?" },
            { "That's right, there was.\r\nBut as we heard earlier...\r\n...scorching like that only occurs when the target is at\r\nvery close range – a matter of centimetres from the gun.", "C'est exact, il y en avait.\r\nMais comme nous l'avons entendu plus tôt...\r\n... de telles brûlures ne surviennent que lorsque la cible est à bout\r\nportant – à quelques centimètres seulement de l'arme." },
            { "Ah!\r\nWhich means that the scorching on the candle can't\r\npossibly be the result of a gunshot.", "Ah !\r\nCe qui signifie que la trace de brûlure sur la bougie ne peut en\r\naucun cas résulter d'un tir de pistolet." },
            { "You're suggesting it came from the fireworks?\r\nHow can that be, eh?", "Vous suggérez que ça viendrait des pétards ?\r\nComment c'serait possible, hein ?" },
            { "The fact that there's such visible scorching on the\r\ncandle...\r\n...suggests that the fireworks must have been right next to\r\nit when they exploded.\r\nOr to put it another way...the candle and firecrackers\r\nwere joined together.\r\nThe culprit somehow attached the firecrackers\r\nat a point partway down the candle.\r\nAfter the killer had left the scene...\r\n...the candle slowly burnt down\r\nalong with the other two...\r\n...until eventually it ignited the fuse\r\nof the firecrackers generating a loud...\r\n...*BANG!*", "Le fait qu'il y ait une trace de brûlure si nette sur la\r\nbougie...\r\n... suggère que les pétards devaient se trouver juste à côté\r\nlorsqu'ils ont explosé.\r\nOu pour le dire autrement... la bougie et les pétards\r\nétaient reliés l'un à l'autre.\r\nLe coupable a fixé les pétards d'une certaine façon\r\nà mi-hauteur de la bougie.\r\nAprès le départ du meurtrier des lieux...\r\n... la bougie s'est consumée lentement,\r\ntout comme les deux autres...\r\n... jusqu'à ce qu'elle enflamme la mèche\r\ndes pétards, produisant une violente...\r\n... *DÉTONATION !*" }
        });

        // [99] KEY:BB\script\output\_sce03_c103_0060_eng#6
        add(@"BB\script\output\_sce03_c103_0060_eng#6", new string[,] {
            { "And that is how these three witnesses came to believe\r\nthey'd heard a gunshot at five o'clock.", "Et voilà comment ces trois témoins en sont venus à croire\r\nqu'ils avaient entendu un coup de feu à cinq heures." },
            { "Well...what a plot...\r\nAnd this implies that the victim could have died earlier\r\nthan we've been led to believe. The previous day, even.", "Eh bien... quelle machination...\r\nEt cela implique que la victime aurait pu mourir plus tôt qu'on ne\r\nnous l'a fait croire. La veille, même." },
            { "Now...now...now just hold your horses!\r\nAll uz lot here saw the victim goin' into the building,\r\nremember?", "Minute... minute... minute papillon !\r\nOn a tous vu la victime entrer dans l'bâtiment, nous autres,\r\nvous vous rappelez ?" },
            { "I, I couldn't forget that flame-coloured hair even if I\r\nw-wanted to.", "J-J'pourrais pas oublier ces ch'veux couleur de feu même si j'le\r\nv-voulais." },
            { "The person you saw entering the building wasn't the\r\nvictim at all.\r\n...Consider this.", "La personne que vous avez vue entrer dans le bâtiment n'était pas\r\nla victime du tout.\r\n... Songez à ceci." },
            { "Ah!\r\nObviously anybody can wear a wig.\r\nSo the person that these witnesses saw entering the\r\nbuilding fifteen minutes before the incident occurred...\r\n...could easily have been someone else entirely wearing\r\nthe red hairpiece.", "Ah !\r\nDe toute évidence, n'importe qui peut porter une perruque.\r\nAinsi, la personne que ces témoins ont vue entrer dans le\r\nbâtiment quinze minutes avant les faits...\r\n... pouvait fort bien être quelqu'un d'autre coiffé\r\nde ce postiche roux." },
            { "Someone else?!\r\nDo, do you mean to say...?", "Quelqu'un d'autre ?!\r\nV-Voulez-vous dire... ?" },
            { "It was the same person who contrived the firecracker\r\ntrick.\r\nIn other words...Inspector Gregson's killer!", "C'était la personne même qui a orchestré la ruse des pétards.\r\nEn d'autres termes... l'assassin de l'inspecteur Gregson !" }
        });

        // [100] KEY:BB\script\output\_sce03_c103_0060_eng#7
        add(@"BB\script\output\_sce03_c103_0060_eng#7", new string[,] {
            { "Pfft...\r\nHa ha ha ha ha ha hah!\r\nOh, very impressive, Ryunosuke Naruhodo.", "Pfft...\r\nHa ha ha ha ha ha ha !\r\nOh, très impressionnant, Ryunosuke Naruhodo." },
            { "K-Kazuma?!", "K-Kazuma ?!" },
            { "I'm really quite amazed you've come this far.\r\nBut after all, wasn't I the one who told you...\r\n...that you had all the makings of a great defence lawyer?\r\n...!", "Je suis sincèrement stupéfait que tu sois parvenu jusqu'ici.\r\nMais après tout, n'est-ce point moi qui t'avais dit...\r\n... que tu avais l'étoffe d'un grand avocat de la défense ?\r\n... !" },
            { "I also noted the lack of a time of death in this report.\r\nA stark omission.\r\nBut as far as I'm concerned...this whole country's justice\r\nsystem leaves a lot to be desired!", "J'avais également remarqué l'absence d'heure du décès dans ce rapport.\r\nUne omission flagrante.\r\nMais en ce qui me concerne... tout le système judiciaire de ce pays\r\nlaisse grandement à désirer !" },
            { "Ordaaar! Ordaaar! Orrrdaaar!\r\nProsecutor Asogi!\r\nWhat on earth do you mean by that statement?", "Du caaalme ! Du caaalme ! Du caaaalme !\r\nProcureur Asogi !\r\nQue voulez-vous dire par là, grand Dieu ?" },
            { "I hear that many of the leading members of Britain's\r\njudiciary are present to observe this trial today.\r\nSo we cannot allow even the slightest doubt to be\r\noverlooked.\r\n...!\r\nThe defence's assertion about the time of death based on\r\nthe victim's stopped watch is just conjecture.\r\nBut...while the possibility exists that my learned friend\r\nmay be correct...we have a duty to explore it.", "J'ai cru comprendre que de nombreuses personnalités éminentes de\r\nla magistrature britannique assistent à ce procès aujourd'hui.\r\nNous ne pouvons donc permettre au moindre doute d'être négligé.\r\n... !\r\nL'affirmation de la défense quant à l'heure du décès reposant\r\nsur la montre arrêtée de la victime n'est qu'une conjecture.\r\nMais... tant qu'il subsiste une possibilité que mon confrère\r\nait raison... nous avons le devoir de l'examiner." },
            { "Hmmm...\r\nWell, certainly...I would agree with you.\r\nAnd what immediately comes to mind is of course...\r\n...what was Inspector Gregson doing and where did he go\r\non the day before the incident?\r\nDo you know?", "Hummm...\r\nMa foi, assurément... je partage votre avis.\r\nEt la question qui vient immédiatement à l'esprit est bien sûr...\r\n... que faisait l'inspecteur Gregson et où s'est-il rendu\r\nla veille des faits ?\r\nLe savez-vous ?" },
            { "The inspector always carried out his investigative work\r\nalone.\r\nHis movements were treated as confidential within\r\nScotland Yard.\r\nEven within the Yard?\r\nHowever, considering the evidence we've been presented\r\nwith so far...\r\n...I'd say it's fairly apparent what case the man was\r\npursuing. Wouldn't you, my learned friend?", "L'inspecteur menait toujours ses enquêtes en solitaire.\r\nSes déplacements étaient considérés comme strictement confidentiels\r\nau sein même de Scotland Yard.\r\nMême au Yard ?\r\nCependant, au vu des pièces à conviction présentées\r\njusqu'à présent...\r\n... j'estime qu'il est assez manifeste de deviner quelle affaire cet\r\nhomme poursuivait. N'est-ce pas, mon estimé confrère ?" },
            { "I do have a feeling about what case he might have been\r\ninvestigating.\r\nYes, I agree. Surely...\r\nMy Lord!\r\nThe defence believes it can explain to the court.", "J'ai en effet une idée quant à l'affaire sur laquelle il enquêtait.\r\nOui, je suis d'accord. Sûrement...\r\nVotre Honneur !\r\nLa défense estime être en mesure de l'exposer à ce tribunal." }
        });

        // [101] KEY:BB\script\output\_sce03_c103_0060_eng#8
        add(@"BB\script\output\_sce03_c103_0060_eng#8", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [102] KEY:BB\script\output\_sce03_c103_0070_eng#2
        add(@"BB\script\output\_sce03_c103_0070_eng#2", new string[,] {
            { "Very well, Counsel.\r\nPresent your argument to the court.", "Très bien, Maître.\r\nPrésentez votre raisonnement au tribunal." }
        });

        // [103] KEY:BB\script\output\_sce03_c103_0070_eng#3
        add(@"BB\script\output\_sce03_c103_0070_eng#3", new string[,] {
            { "What evidence is suggestive of the case being investigated\r\nby the inspector on the day prior to the incident?", "Quelle preuve évoque l'affaire sur laquelle enquêtait\r\nl'inspecteur la veille des faits ?" }
        });

        // [104] KEY:BB\script\output\_sce03_c103_0070_eng#4
        add(@"BB\script\output\_sce03_c103_0070_eng#4", new string[,] {
            { "Hm... I can't say that I find your answer suggestive of\r\nanything in particular.\r\nOther than perhaps that it is utterly wrong.\r\nThat much you have clarified most expertly.\r\nWha...?\r\nCongratulations, Ryunosuke Naruhodo.\r\nYou deserve a reward for that expert display!\r\nAAAAAARGH!\r\n(Did, did you just draw Karuma on me, my friend?)\r\nI think, Mr Naruhodo, that there's one particular piece of\r\nevidence...\r\n...that really does stand out in showing what case\r\nInspector Gregson was investigating.\r\nMy Lord! I have the answer now!", "Hum... je ne saurais dire en quoi votre réponse évoque\r\nquoi que ce soit de particulier.\r\nSi ce n'est peut-être qu'elle est totalement erronée.\r\nVoilà qui est clarifié de main de maître.\r\nQuoi... ?\r\nFélicitations, Ryunosuke Naruhodo.\r\nTu mérites une récompense pour cette magistrale démonstration !\r\nAAAAAARGH !\r\n(Est... est-ce que tu viens de dégainer Karuma contre moi, mon ami ?)\r\nJe crois, monsieur Naruhodo, qu'il existe une pièce à conviction\r\nen particulier...\r\n... qui indique on ne peut plus clairement quelle affaire\r\nl'inspecteur Gregson suivait.\r\nVotre Honneur ! J'ai la réponse cette fois !" }
        });

        // [105] KEY:BB\script\output\_sce03_c103_0070_eng#5
        add(@"BB\script\output\_sce03_c103_0070_eng#5", new string[,] {
            { "I believe this red hairpiece points to the answer.", "J'estime que ce postiche roux nous fournit la réponse." },
            { "We might assume it was part of a disguise used to carry\r\nout an undercover investigation.", "Nous pouvons supposer qu'il servait de déguisement dans le cadre\r\nd'une mission d'infiltration." },
            { "Surely not! Such a brightly coloured hairpiece would only\r\nserve to make the inspector more noticeable.", "Certainement point ! Un postiche d'une teinte aussi vive n'aurait\r\nfait que rendre l'inspecteur d'autant plus voyant." },
            { "Yes, that's quite true.\r\nIt would definitely have made him stand out in a crowd.\r\nExcept, that is...in a crowd of gentlemen from the\r\nRed-Headed League.", "Oui, c'est tout à fait vrai.\r\nCela l'aurait indubitablement fait ressortir dans la foule.\r\nSauf, bien sûr... au milieu d'un rassemblement de la\r\nLigue des Rouquins." },
            { "The, the Red-Headed League?", "La, la Ligue des Rouquins ?" },
            { "So...you'd already worked it out.", "Ainsi... tu l'avais déjà compris." },
            { "What on earth is this all about?\r\nIs there such an extraordinary league of gentlemen?", "De quoi s'agit-il au juste, grand Dieu ?\r\nExiste-t-il véritablement une telle et insolite congrégation ?" },
            { "The Red-Headed League is currently under investigation\r\nfor a grand deception.", "La Ligue des Rouquins fait actuellement l'objet d'une enquête\r\npour escroquerie de grande envergure." },
            { "A deception of what nature, Counsel?", "Une escroquerie de quelle nature, Maître ?" },
            { "They've been targeting red-headed men across all of\r\nLondon and tricking them out of small sums of money.\r\nTwo men were arrested for the misdemeanour only\r\nyesterday, in fact.", "Ils ont ciblé des hommes roux dans tout Londres pour leur soutirer\r\nde coquettes sommes d'argent.\r\nDeux hommes ont été appréhendés pour ce délit hier même,\r\nen réalité." },
            { "My Lord!\r\nThe defence calls for those two men to be summoned at\r\nonce!", "Votre Honneur !\r\nLa défense demande la convocation immédiate de ces deux\r\nhommes !" },
            { "T-Two red-heads?!", "D-Deux rouquins ?!" },
            { "Inspector Gregson clearly infiltrated the Red-Headed\r\nLeague using this hairpiece.\r\nSo it's very likely that he had direct contact with these\r\ncriminals.\r\nAnd it's quite possible that such contact led to...more\r\nserious events.", "L'inspecteur Gregson a manifestement infiltré la Ligue des\r\nRouquins au moyen de ce postiche.\r\nIl est donc fort probable qu'il ait été en contact direct avec\r\nces malfaiteurs.\r\nEt il est tout à fait possible qu'un tel contact ait mené à... des\r\névénements bien plus graves." },
            { "I concur that we cannot in good conscience leave this new\r\navenue unexplored.", "Je conviens que notre conscience nous interdit de laisser cette\r\nnouvelle piste inexplorée." },
            { "Well done, Mr Naruhodo!", "Bien joué, monsieur Naruhodo !" },
            { "Well...it's another possible line of enquiry for us at least.\r\nThe prosecution will make immediate arrangements for\r\nthe charged men to appear.", "Bien... voilà au moins une autre piste d'investigation pour nous.\r\nL'accusation prendra immédiatement les dispositions requises\r\npour faire comparaître les prévenus." },
            { "Bring these two Red-Headed League conspirators before\r\nme, Prosecutor Asogi!\r\nAt once, My Lord.\r\nVery good. We will have a thirty-minute recess.\r\nCourt is adjourned!", "Faites comparaître devant moi ces deux conspirateurs de la\r\nLigue des Rouquins, procureur Asogi !\r\nÀ l'instant, Votre Honneur.\r\nFort bien. Nous suspendons l'audience pour trente minutes.\r\nLa séance est levée !" }
        });

        // [106] KEY:BB\script\output\_sce03_c103_0070_eng#6
        add(@"BB\script\output\_sce03_c103_0070_eng#6", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [107] KEY:BB\script\output\_sce03_c104_0000_eng#2
        add(@"BB\script\output\_sce03_c104_0000_eng#2", new string[,] {
            { "2nd November, 12:33 p.m.\r\n<CNTR><E003 5>The Old Bailey, Defendants' Antechamber", "2 novembre, 12 h 33\r\n<CNTR><E003 5>Old Bailey, antichambre des accusés" },
            { "there you are, ", "t'es là, " },
            { "'Oddo!", "'Oddo !" },
            { "What kept you, ", "Qu'est-ce qui vous a retenu, " },
            { "my dear fellow?", "mon cher ami ?" },
            { "Hello, ", "Bonjour, " },
            { "Mr Sholmes.", "monsieur Sholmes." },
            { "Gina.", "Gina." },
            { "You sure about wot you said in there?", "T'es sûr d'c'que t'as raconté là-dedans ?" },
            { "That the boss...you know...actually died the day before?\r\nIt's pretty 'ard to swallow.", "Que l'patron... enfin tu vois... s'rait mort la veille ?\r\nC'est rudement dur à avaler." },
            { "I was shocked by the revelation too, ", "j'ai également été bouleversée par cette révélation, " },
            { "As was I! Possibly more shocked than both of you!", "Tout comme moi ! Davantage sous le choc que vous deux réunis !" },
            { "...It's not a competition, Mr Sholmes.", "... Ce n'est pas un concours, monsieur Sholmes." },
            { "(But I was more shocked than all of you put together.)", "(Mais j'étais plus choqué que vous tous réunis.)" },
            { "This is the autopsy report in question, is it?", "C'est donc là le rapport d'autopsie en question ?" },
            { "Yes. It's strange that there's no time of death noted.", "Oui. Il est étrange qu'aucune heure de décès n'y figure." },
            { "I suppose there's a simple explanation. Or perhaps...it was\r\na deliberate omission.", "J'imagine qu'il y a une explication toute simple. Ou alors... c'était\r\nune omission délibérée." },
            { "Oh dear...\r\nIf it was deliberate...\r\n...it puts me in mind of the last case we worked on...and\r\nDr Sithe.", "Oh ciel...\r\nSi c'était délibéré...\r\n... cela me rappelle notre dernière affaire... et la\r\nDre Pétrie." },
            { "I know. Anyway, it seems that on the day before Lord\r\nvan Zieks discovered his body...\r\n...Inspector Gregson was investigating the Red-Headed\r\nLeague. So perhaps something happened with them.", "Je sais. En tout cas, il semble que la veille du jour où Lord\r\nVan Peers a découvert son corps...\r\n... l'inspecteur Gregson enquêtait sur la Ligue des Rouquins.\r\nIl s'est donc peut-être passé quelque chose avec eux." },
            { "Come to think of it...\r\n...you had trouble with those league men too, didn't you,\r\nMr Sholmes? You were taken in by their trick.", "À bien y réfléchir...\r\n... vous avez eu des ennuis avec les membres de cette ligue vous aussi,\r\nn'est-ce pas, monsieur Sholmes ? Vous vous êtes fait berner par leur ruse." },
            { "No no no!\r\nNaturally, I wasn't ‘taken in’ as you put it.", "Non non non !\r\nNaturellement, je ne me suis point fait « berner », comme vous dites." },
            { "My sleuth-hound interest was merely piqued slightly by\r\nthe rare scent of a weekly four-pound income.", "Mon flair d'enquêteur s'est simplement trouvé émoustillé par\r\nle doux fumet d'une rente hebdomadaire de quatre livres." },
            { "...And that scent masked the underlying scent of\r\ndeception, I suppose.", "... Et ce parfum a masqué l'odeur sous-jacente de la supercherie,\r\nj'imagine." },
            { "The two criminals in question are the pair we saw being\r\narrested yesterday, aren't they?\r\nIn Mr Sholmes's suite, I mean.", "Les deux criminels en question sont ceux que nous avons vus se\r\nfaire arrêter hier, n'est-ce pas ?\r\nDans les appartements de monsieur Sholmes, je veux dire." },
            { "That's right, Sooze! An' it was me wot took 'em in!\r\nThanks to a tip-off by a good, law-abidin' citizen.", "C'est bien ça, Sooze ! Et c'est moi qui les ai cravatés !\r\nGrâce au tuyau d'un honnête citoyen respectueux d'la loi." },
            { "Indeed. Yours truly.", "En effet. Votre humble serviteur." },
            { "(So it's going to be that pair in the witness stand next, is\r\nit?)", "(Ce sont donc ces deux-là qui vont comparaître à la barre à présent ?)" },
            { "Something doesn't quite make sense to me, though.", "Il y a pourtant quelque chose qui m'échappe." },
            { "The day before Inspector Gregson was found, you hadn't\r\nhad trouble with the Red-Headed League yet, had you?\r\nWhy would the inspector have been investigating them?", "La veille du jour où l'inspecteur Gregson a été découvert, vous n'aviez\r\npas encore eu d'ennuis avec la Ligue des Rouquins, si ?\r\nPourquoi l'inspecteur aurait-il enquêté sur eux ?" },
            { "Well, the likely explanation would be...\r\n...that Gregson's own sleuth-hound interest was piqued\r\nby the rare scent of a weekly four-pound income.", "Eh bien, l'explication la plus plausible serait...\r\n... que le flair de ce bon vieux Gregson a lui aussi été émoustillé\r\npar le doux fumet d'une rente hebdomadaire de quatre livres." },
            { "Don't tar 'im wiv the same brush as you, Sholmes!", "L'mettez pas dans l'même panier qu'vous, Sholmes !" },
            { "Yes, well...\r\nThen there's the whole issue of Inspector Gregson being\r\ninvestigated by Lord van Zieks for some reason.\r\nThe Reaper...the Red-Headed League...\r\nInspector Gregson...Lord van Zieks...\r\n...And Kazuma.\r\n...!\r\nI feel as though he knew we'd arrive at this point\r\nsomehow.", "Oui, eh bien...\r\nIl y a aussi toute cette histoire d'enquête menée par Lord\r\nVan Peers sur l'inspecteur Gregson, pour une raison inconnue.\r\nLe Faucheur... la Ligue des Rouquins...\r\nL'inspecteur Gregson... Lord Van Peers...\r\n... et Kazuma.\r\n... !\r\nJ'ai l'impression qu'il savait que nous en arriverions là." },
            { "Gosh! I, I think you're right...", "Ciel ! Je... je crois que vous avez raison..." },
            { "(What's he really trying to achieve here today?)", "(Que cherche-t-il réellement à accomplir aujourd'hui ?)" },
            { "All the answers will soon be revealed.\r\n...Observe the time, my dear fellow.\r\nThis recess will be over very shortly.", "Toutes les réponses seront bientôt révélées.\r\n... Regardez l'heure, mon cher ami.\r\nCette suspension d'audience va s'achever sous peu." },
            { "Yes, you're right.", "Oui, vous avez raison." },
            { "(Kazuma was determined that he should be the one to\r\nprosecute this trial.)", "(Kazuma tenait absolument à être celui qui soutiendrait l'accusation.)" },
            { "(And he was determined that I should take the defence.)", "(Et il tenait à ce que j'assure la défense.)" },
            { "(Just what is it that he's hoping to make me see, I wonder?)", "(Qu'espère-t-il au juste me faire comprendre ?)" },
            { "(I get the feeling we're a long way from the end of this\r\ntrial yet...)", "(J'ai la nette impression que nous sommes encore loin de voir le bout\r\nde ce procès...)" },
            { "Are you ready then, Miss Susato?", "Êtes-vous prête, mademoiselle Susato ?" },
            { "Yes!", "Oui !" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText("tools\\Trans_Ep4_Act3_Part4.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Trans_Ep4_Act3_Part4.cs generated successfully!");
    }
}
