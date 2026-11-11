using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act3 {
    public partial class Program {
        public static void RegisterPart3() {
            entryTranslators[@"BB\script\output\_sce03_c102_0040_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale.");
                s = s.Replace("As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public.");
                s = s.Replace("However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre.");
                s = s.Replace("B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !");
                s = s.Replace("Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare...");
                s = s.Replace("That is all. Court is adjourned!", "C'est tout. L'audience est levée !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c102_0050_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So, Counsel, I must ask you to clarify your assertion for\r\nthe court.", "Maître, je vous prie d'éclaircir votre affirmation devant ce\r\ntribunal.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c102_0050_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("At the time of the incident, where do you maintain the\r\nnoticeboard was situated?", "Au moment des faits, où soutenez-vous que se trouvait le\r\npanneau d'affichage ?");
                s = s.Replace("It was right here, My Lord!", "Il se trouvait juste ici, Votre Honneur !");
                s = s.Replace("Goodness!\r\nHm, no... I'm afraid I don't quite see your logic.", "Bonté divine !\r\nHum, non... j'avoue ne pas bien saisir votre logique.");
                s = s.Replace("I'm disappointed, Ryunosuke. In Japan, we're taught to\r\nhave patience and respect for our elders.", "Je suis déçu, Ryunosuke. Au Japon, on nous enseigne la patience\r\net le respect envers nos aînés.");
                s = s.Replace("So until His Lordship sees your logic, you will know your\r\nplace and not move from that spot!", "Alors tant que Sa Seigneurie ne comprendra pas votre logique,\r\nvous resterez à votre place sans bouger d'un pouce !");
                s = s.Replace("UAAAAAAGH!", "UAAAAAAGH !");
                s = s.Replace("How brilliant of Kazuma-sama! That almost sounded\r\nunreasonable at first, but he was just thinking of you.", "Quelle grandeur d'âme chez Kazuma-sama ! Cela paraissait\r\ndéraisonnable de prime abord, mais il ne pensait qu'à vous.");
                s = s.Replace("Unreasonable? Try unfathomable.", "Déraisonnable ? Dites plutôt insondable.");
                s = s.Replace("Anyway, I think I have the answer now.", "Quoi qu'il en soit, je crois détenir la solution désormais.");
                s = s.Replace("I know my place! ...Or rather, I know the board's place!", "Je connais ma place ! ...Ou plutôt, je connais la place du panneau !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c102_0050_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("This is the only possible location!", "C'est le seul emplacement envisageable !");
                s = s.Replace("Immediately adjacent to the doorway...?", "Juste à côté de l'entrée... ?");
                s = s.Replace("If the court would think back to the testimony given by\r\nthe defendant earlier...\r\n...he said that when he entered the room it was dark, and\r\nhe couldn't see the body.", "Si le tribunal veut bien se remémorer la déposition faite par\r\nl'accusé plus tôt...\r\n...il a déclaré qu'à son entrée dans la pièce, il faisait sombre\r\net qu'il ne voyait pas le corps.");
                s = s.Replace("By 'eck!", "Cré nom d'un chien !");
                s = s.Replace("If the noticeboard had been here, the body would have\r\nbeen completely hidden from view.", "Si le panneau se trouvait ici, le corps aurait été\r\ntotalement dérobé aux regards.");
                s = s.Replace("And the light from the candles would have been blocked,\r\nmaking the room appear darker.", "Et la lueur des bougies aurait été masquée,\r\nrendant la pièce bien plus obscure.");
                s = s.Replace("But the accused also claims that the victim's body simply\r\n‘appeared’ before him.", "Mais l'accusé a également prétendu que le corps de la victime\r\nétait simplement « apparu » devant lui.");
                s = s.Replace("That's true. Or, in his precise words...", "C'est exact. Ou, pour reprendre ses termes exacts...");
                s = s.Replace("Just as I picked the firearm up to examine it, the door\r\nflew open and I heard a man scream.", "Au moment où je ramassais l'arme pour l'examiner, la porte\r\ns'est ouverte avec fracas et j'ai entendu un homme crier.");
                s = s.Replace("It was only then that the body of Inspector Gregson\r\nappeared before me.", "C'est seulement à cet instant que le corps de l'inspecteur Gregson\r\nest apparu sous mes yeux.");
                s = s.Replace("I don't know about callin' it a ‘scream’, but he woz talkin'\r\nabout me and no mistake.\r\nCos it woz me that kicked the door open.", "J'sais pas si on peut appeler ça un « hurlement », mais il parlait\r\nbien de ma pomme, sans l'ombre d'un doute.\r\nParce que c'est bien moi qui ai défoncé la porte.");
                s = s.Replace("If you look again at the floor plan...\r\n...consider what would happen if the door to the room\r\nwas thrown open with force.", "Si vous examinez à nouveau le plan...\r\n...songez à ce qui se produit lorsque la porte est ouverte\r\navec violence.");
                s = s.Replace("That, that can't...", "Ce, cela ne peut...");
                s = s.Replace("The door struck the noticeboard, knocking it over, and\r\nmaking the victim's body visible.", "Le battant de la porte a heurté le panneau et l'a renversé,\r\nrévélant soudain le corps de la victime !");
                s = s.Replace("Good gracious!", "Bonté du ciel !");
                s = s.Replace("My client has told nothing but the truth!\r\nHe has simply described what he saw.", "Mon client n'a dit que la pure vérité !\r\nIl a simplement décrit ce qu'il a vu.");
                s = s.Replace("Argh!", "Argh !");
                s = s.Replace("Ordaaar! Ordaaar!\r\nCounsel, how has this not come to light before now?", "Silence ! Silence !\r\nMaître, comment un tel fait n'a-t-il point été mis en lumière jusqu'ici ?");
                s = s.Replace("After the incident, somebody must have righted the board\r\nand moved it...\r\n...into the position where the police, myself and my\r\ncolleague saw it when investigating the room.", "Après les faits, quelqu'un a nécessairement redressé le tableau\r\net l'a déplacé...\r\n...jusqu'à l'emplacement où la police, moi-même et ma consœur\r\nl'avons constaté lors de l'inspection de la pièce.");
                s = s.Replace("Witness! What have you to say for yourself?", "Témoin ! Qu'avez-vous à répondre à cela ?");
                s = s.Replace("Whaaaaaat?\r\nMe, My Lord?", "Quôôôôôi ?\r\nMoi, Votre Honneur ?");
                s = s.Replace("You and your fellows were there at the scene before\r\nanybody else.\r\nIt goes without saying that you must know something\r\nabout the position of the noticeboard!", "Vous et vos compères étiez sur les lieux avant tout\r\nle monde.\r\nIl va sans dire que vous devez savoir quelque chose\r\nsur la disposition de ce tableau d'affichage !");
                s = s.Replace("The witnesses in the stand will testify again.\r\nYou will each explain exactly what you did upon arriving\r\nat the scene of the crime!", "Les témoins à la barre vont déposer une nouvelle fois.\r\nVous allez chacun expliquer exactement ce que vous avez fait\r\nà votre arrivée sur le théâtre du crime !");
                s = s.Replace("Eh, stop lookin' over your glasses at me!\r\nI get the message.", "Hé, arrêtez de m'lorgner par-dessus vos bésicles !\r\nJ'ai pigé l'topo.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c102_0050_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale.");
                s = s.Replace("As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public.");
                s = s.Replace("However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre.");
                s = s.Replace("B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !");
                s = s.Replace("Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare...");
                s = s.Replace("That is all. Court is adjourned!", "C'est tout. L'audience est levée !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Mystery of the Moving Board –", "– Le mystère du panneau déplacé –");
                s = s.Replace("I don't know anythin' about that there noticeboard!\r\nI just wiped my hand on it, that's all.", "J'en sais fichtre rien à propos d'ce fichu panneau !\r\nJ'y ai juste essuyé ma paluche, point barre.");
                s = s.Replace("Well don't look at me. I 'aven't got a clue about it.\r\nI was doin' business with some second years at the time.", "Ben me regardez pas ! J'en ai pas la moindre idée.\r\nJ'étais en plein négoce avec des p'tits de primaire à c'moment-là.");
                s = s.Replace("I, I don't know anything about anything. I'm j-just a\r\nbystander, me. J-Just a sign at the crossroads of life.", "J-Je ne sais rien sur rien, moi. Je ne suis qu'un s-simple spectateur.\r\nJ-Juste une enseigne au carrefour de l'existence.");
                s = s.Replace("It woz that Reaper, I bet. He's got a face that screams\r\n‘board’.", "C'était l'Faucheur, j'parierais. Il a une tronche qui crie\r\n« panneau » à des kilomètres.");
                s = s.Replace("I c-can't see how this changes anything anyway.\r\nThe detective still died w-when we heard the gunshot.", "J-Je ne vois pas ce que ça change de toute façon.\r\nL'inspecteur est bien mort q-quand on a entendu l'coup d'feu.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0000_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Hmmm... So none of you can elaborate further... ", "Hummm... Aucun de vous ne peut donc nous en dire davantage... ");
                s = s.Replace("Shaken by the crime they witnessed, and with only the\r\nlight of a few candles and an oil lamp by which to see...\r\n...we can't expect these witnesses to be able to give a\r\nmore precise account of what happened.", "Ébranlés par le crime dont ils ont été témoins, et avec pour seule\r\nlumière quelques bougies et une lampe à huile...\r\n...nous ne pouvons exiger de ces témoins un récit plus précis\r\nde ce qui s'est produit.");
                s = s.Replace("That's right, yeah. It don't pay to expect too much.", "C'est bien vrai, ouais ! Faut pas trop en demander.");
                s = s.Replace("It's m-man's endless quest for knowledge that's\r\nd-d-destroying the world. That's w-what I think.", "C'est la quête sans fin du savoir de l'h-homme qui d-d-détruit\r\nle monde. C'est c-ce que je pense.");
                s = s.Replace("...Do you? Really.", "...Vraiment ? Si vous le dites.");
                s = s.Replace("In any case, as this testimony shows...\r\n...even if the noticeboard was moved by somebody\r\nfollowing the incident, it makes no difference.", "Quoi qu'il en soit, comme le démontre cette déposition...\r\n...même si le panneau a été déplacé par quelqu'un après les faits,\r\ncela ne change strictement rien.");
                s = s.Replace("When the gunshot rang out, the accused was the only\r\nperson at the scene.", "Lorsque le coup de feu a retenti, l'accusé était la seule\r\net unique personne sur les lieux.");
                s = s.Replace("In short, the only person who could possibly have\r\ncommitted this crime... is Barok van Zieks!\r\nNone of this wrangling over the board changes that simple\r\nfact.", "En résumé, le seul individu qui ait pu commettre ce meurtre...\r\nest Drake Van Peers !\r\nToutes ces tergiversations sur ce panneau ne changeront rien à ce fait élémentaire.");
                s = s.Replace("Quite so, quite so.\r\nDoes the defence still wish to cross-examine the\r\nwitnesses despite the circumstances?", "Tout à fait, tout à fait.\r\nLa défense persiste-t-elle à vouloir contre-interroger ces témoins\r\nmalgré ces circonstances ?");
                s = s.Replace("Most certainly, My Lord!", "Assurément, Votre Honneur !");
                s = s.Replace("Very well. Then you may proceed, Counsel.", "Très bien. Dans ce cas, vous pouvez procéder, Maître.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Mystery of the Moving Board –", "– Le mystère du panneau déplacé –");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("I don't know anythin' about that there noticeboard!\r\nI just wiped my hand on it, that's all.", "J'en sais fichtre rien à propos d'ce fichu panneau !\r\nJ'y ai juste essuyé ma paluche, point barre.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Well don't look at me. I 'aven't got a clue about it.\r\nI was doin' business with some second years at the time.", "Ben me regardez pas ! J'en ai pas la moindre idée.\r\nJ'étais en plein négoce avec des p'tits de primaire à c'moment-là.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("Maybe I did sneak along behind Gossip and 'ave a little\r\npeek into the room where it all 'appened.", "C'est p't-être vrai que j'me suis faufilée derrière Ragot pour jeter un\r\ncoup d'œil dans la turne où tout s'est passé.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("I, I don't know anything about anything. I'm j-just a\r\nbystander, me. J-Just a sign at the crossroads of life.", "J-Je ne sais rien sur rien, moi. Je ne suis qu'un s-simple spectateur.\r\nJ-Juste une enseigne au carrefour de l'existence.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("It woz that Reaper, I bet. He's got a face that screams\r\n‘board’.", "C'était l'Faucheur, j'parierais. Il a une tronche qui crie\r\n« panneau » à des kilomètres.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("I c-can't see how this changes anything anyway.\r\nThe detective still died w-when we heard the gunshot.", "J-Je ne vois pas ce que ça change de toute façon.\r\nL'inspecteur est bien mort q-quand on a entendu l'coup d'feu.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("(Not much to go on...)", "(Pas grand-chose à se mettre sous la dent...)");
                s = s.Replace("As you've pointed out, Mr Naruhodo...\r\n...there's no question that the noticeboard was moved.\r\nSo somebody must have done it.", "Comme vous l'avez souligné, monsieur Naruhodo...\r\n...il est indéniable que le panneau d'affichage a été déplacé.\r\nQuelqu'un en est donc nécessairement l'auteur.");
                s = s.Replace("But it did happen after the event, so...\r\n...maybe Kazuma is right and it's not relevant to the case.", "Mais cela s'est passé après les faits, alors...\r\n...peut-être Kazuma a-t-il raison et cela n'a rien à voir avec le meurtre.");
                s = s.Replace("But it seems to have been deliberately positioned so as to\r\nhide the body from view.\r\nSo I feel sure that there's some deeper significance to all\r\nof this.", "Pourtant, il semblait placé délibérément de façon à dissimuler\r\nle corps aux regards.\r\nJe suis donc convaincue que cela cache quelque chose d'important.");
                s = s.Replace("Yes, I know what you mean.", "Oui, je vois ce que vous voulez dire.");
                s = s.Replace("I've no doubt there are more clues to be uncovered.\r\nYou're on the right track, I can feel it.\r\nSo follow your instincts!", "Je ne doute point qu'il y ait d'autres indices à dénicher.\r\nVous êtes sur la bonne voie, je le sens.\r\nFaites confiance à votre instinct !");
                s = s.Replace("...Alright, then.", "...Bien, c'est parti.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("So you admit that it was the board you wiped your bloody\r\nhand on?", "Ainsi, vous admettez que c'est sur le panneau que vous avez essuyé votre\r\nmain tachée de sang ?");
                s = s.Replace("Admit it? What's to admit? It's there plain as day for all to\r\nsee: a smashing print of my right hand!", "L'admettre ? Qu'est-ce qu'y a à admettre ? C'est gros comme une maison,\r\ntout l'monde peut l'reluquer : une superbe empreinte de ma pogne droite !");
                s = s.Replace("Perhaps you wanted to hide that handprint...\r\n...so you righted the noticeboard and pushed it into the\r\ncorner, did you?", "Peut-être souhaitiez-vous dissimuler cette marque...\r\n...et avez-vous relevé le panneau pour le pousser dans le\r\ncoin ?");
                s = s.Replace("No no! Imagine the weight of that great lump!\r\nDo I look like a powerful and well-nurtured man?", "Mais non, pardi ! Vous imaginez l'poids d'un tel mastodonte ?\r\nJ'ai l'air d'un colosse bien nourri, moi ?");
                s = s.Replace("Well did you see anybody else moving the board?", "Avez-vous vu quelqu'un d'autre déplacer ce panneau ?");
                s = s.Replace("I've got nerves of steel, I can tell you, but even I have my\r\nlimits.\r\nThere woz a body on the floor in front of me, and the\r\ngrim Reaper himself standin' over it.", "J'ai les nerfs solides, j'peux vous l'dire, mais y a des limites.\r\nY avait un macchabée étalé par terre et l'Faucheur en personne\r\ndebout au-dessus.");
                s = s.Replace("And there woz precious little light inside, either.\r\nMy bottom lip was all aquiver.", "Et y avait pas des masses de clarté non plus.\r\nMa lippe tremblotait comme une feuille.");
                s = s.Replace("In other words... this witness is unable to give definite\r\ntestimony on that point.", "En d'autres termes... ce témoin est incapable de fournir une déposition\r\nprécise sur ce point.");
                s = s.Replace("Hm, yes... so it would seem.", "Hum, oui... il semblerait en effet.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("When you say you were doing business with them, you\r\nmean you were selling them fireworks?", "Quand vous dites que vous faisiez affaire avec eux, vous voulez\r\ndire que vous leur vendiez des pétards ?");
                s = s.Replace("Yeah, what else? There's the Priory School just round the\r\ncorner, see.\r\nThose cheeky little so-and-sos 'ave got a plan to blow\r\ntheir school to kingdom come.", "Ben ouais, quoi d'autre ? Y a l'école du Prieuré juste à côté,\r\nvoyez.\r\nCes p'tits sacripants ont pour projet de faire sauter leur boîte\r\nen l'air.");
                s = s.Replace("Haah...", "Pfff...");
                s = s.Replace("So I've been tellin' on them. Lettin' their teachers know\r\nwhat they're up to.", "Alors j'vais les cafter. J'mets les profs au parfum de leurs\r\ncombines.");
                s = s.Replace("Oh... you have?", "Ah... vraiment ?");
                s = s.Replace("Yeah, wouldn't want anyone to get 'urt. So I let the school\r\nknow the kids are playin' with dodgy toys.\r\nThen – praise the Lord – the teachers take all the\r\nfireworks off 'em.", "Ben oui, j'voudrais pas qu'y ait des blessés ! Alors j'prévais la direction\r\nque les mioches s'amusent avec des trucs dangereux.\r\nEt là – loué soit l'Seigneur – les pions leur confisquent tous leurs pétards.");
                s = s.Replace("And then – praise the Lord again – the kids all come back\r\nto me to buy more. Everyone's 'appy, see?", "Et puis – loué soit encore l'Seigneur – les gosses reviennent tous m'en\r\nracheter d'autres ! Tout l'monde est content, pas vrai ?");
                s = s.Replace("...What a racket.", "...Quel commerce éhonté.");
                s = s.Replace("'Course. And sometimes the teachers give me a little\r\nbonus to thank me for lettin' 'em know.\r\nIt's a busy old life, sellin' explosives.", "Et comment ! Parfois même les profs me filent un p'tit pourboire\r\npour les avoir avertis.\r\nC'est du boulot à plein temps d'vendre des explosifs.");
                s = s.Replace("Venus is a guileful goddess indeed... ", "Vénus est une déesse bien retorse, en vérité... ");
                s = s.Replace("Well, tellin' bare-faced lies is kind of my thing, really.\r\nI'm ever so good at it.", "Bah, débiter des craques sans cligner des yeux, c'est mon truc,\r\nquoi. J'suis drôlement douée pour ça.");
                s = s.Replace("(Ugh... scary.)", "(Ouh là... quelle angoisse.)");
                s = s.Replace("...The important point is, you didn't go inside the room\r\nwhere the inspector was killed, isn't that right?", "...Le point capital est que vous n'avez pas pénétré dans la pièce\r\noù l'inspecteur a été assassiné, n'est-ce point cela ?");
                s = s.Replace("Definitely not. Wouldn't 'ave dreamed of it, would I?", "Jamais d'la vie ! J'aurais pas eu l'idée saugrenue d'faire ça !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("You make a habit of lying, do you, Miss Venus?", "Vous avez l'habitude de mentir, mademoiselle Vénus ?");
                s = s.Replace("Well... I s'pose so.\r\n...I don't really know, to be fair.\r\nIf you want my advice, though, I'd take everythin' I say\r\nwith a big pinch of salt.", "Ben... j'suppose, ouais.\r\n...J'en sais trop rien, en vérité.\r\nMais si vous voulez mon avis, vaut mieux prendre tout c'que j'raconte\r\navec de grosses pincettes.");
                s = s.Replace("Alright, but you did in fact go to the room where the\r\nvictim was killed on the day in question, didn't you?", "Soit, mais vous vous êtes bien rendue dans la pièce où la victime\r\na été abattue ce jour-là, n'est-ce pas ?");
                s = s.Replace("Oh, please! As if I would!\r\nI can't think of anythin' more terrifyin'!", "Oh, pitié ! Comme si j'avais fait ça !\r\nJ'vois rien d'plus terrifiant !");
                s = s.Replace("The truth, please.", "La vérité, je vous prie.");
                s = s.Replace("Well alright, just a bit then.\r\nI mean, a girl my age is curious about stuff, ya know!", "Bon d'accord, juste un p'tit peu alors.\r\nUne fille de mon âge, c'est curieux de tout, quoi !");
                s = s.Replace("Did you touch anything at the scene?", "Avez-vous touché quoi que ce soit sur les lieux ?");
                s = s.Replace("Oh, please! As if I would!\r\nI mean, there was a dead body on the floor!", "Oh, pitié ! Comme si j'allais toucher un truc pareil !\r\nY avait un cadavre par terre, j'vous f'rais dire !");
                s = s.Replace("The truth, please.", "La vérité, s'il vous plaît.");
                s = s.Replace("Well alright, just a bit then.\r\nI 'ad a look to see if there was anythin' I could sell.\r\nSo I did give the place a once-over. But it was nothin' to\r\nwrite 'ome about.", "Bon d'accord, juste un p'tit peu alors.\r\nJ'ai jeté un œil pour voir s'y avait pas un truc à chiner.\r\nAlors j'ai fouiné un coup. Mais y avait rien de bien terrible.");
                s = s.Replace("Right. Now, I hesitate to ask, but...\r\n...you didn't move the noticeboard by any chance, did\r\nyou?", "Bien. Maintenant, j'hésite à vous le demander, mais...\r\n...n'auriez-vous pas déplacé le panneau d'affichage, par hasard ?");
                s = s.Replace("Oh, please! As if I would touch anythin' like that!\r\nJust a few bits of loose change is all I 'ad!", "Oh, pitié ! Comme si j'allais toucher à un machin pareil !\r\nJ'ai juste piqué deux ou trois piécettes, c'est tout !");
                s = s.Replace("The truth, please.", "La vérité, je vous en conjure.");
                s = s.Replace("Well alright then. I thought there might be somethin'\r\nworth 'avin' underneath it.\r\nSo I blasted the flippin' thing–\r\nSorry, flipped the blasted thing.", "Bon d'accord ! J'me suis dit qu'y avait peut-être un truc de valeur\r\ncoincé dessous.\r\nAlors j'ai fait valser l'foutu bastringue...\r\nPardon, j'ai basculé le machin.");
                s = s.Replace("You're, you're telling us...\r\n...that you DID move that board?!", "Vous... vous êtes en train de nous dire...\r\n...que c'est bien vous qui avez déplacé ce panneau ?!");
                s = s.Replace("I think that did slip out, didn't it?", "Je crois bien que ça m'a échappé, non ?");
                s = s.Replace("Wha...? You daft barmpot!", "Quoi... ? Espèce de cruche finie !");
                s = s.Replace("I, I don't believe it...\r\nThe girl doesn't think.", "J-Je n'en reviens pas...\r\nCette gamine ne réfléchit jamais.");
                s = s.Replace("So! Did you find anything then?\r\nSomething that you might have taken, perhaps?\r\nTo sell?", "Alors ! Avez-vous trouvé quelque chose ?\r\nQuelque chose que vous auriez dérobé, peut-être ?\r\nPour le vendre ?");
                s = s.Replace("Oh, please! I should be so lucky!\r\nIn my imagination–", "Oh, pitié ! J'aurais bien aimé, tiens !\r\nDans mes rêves le plus–");
                s = s.Replace("The TRUTH now!", "La VÉRITÉ, maintenant !");
                s = s.Replace("...I might 'ave found this old pocket watch under the\r\nnoticeboard, I s'pose.\r\nBut a bit o' junk like this can't be worth much, if you ask–", "...J'ai p't-être bien dégoté cette vieille montre à gousset sous l'panneau,\r\nj'suppose.\r\nMais un vieux rossignol pareil, ça vaut pas un clou, si vous voulez–");
                s = s.Replace("AAAAAAAAAH!", "AAAAAAAAAH !");
                s = s.Replace("So it was you, was it?\r\nYou're the one wot took it!", "Alors c'était toi, hein ?!\r\nC'est toi qui l'as fauchée !");
                s = s.Replace("G-Gina?!", "G-Gina ?!");
                s = s.Replace("Young lady!\r\nMay I remind you where you are?!", "Jeune fille !\r\nPuis-je vous rappeler où vous vous trouvez ?!");
                s = s.Replace("That watch... That watch there...\r\nThat was a present to Inspector Gregson from the Yard\r\nfor a big case 'e solved ten years ago!", "Cette montre... Cette montre-là...\r\nC'était un cadeau fait à l'patron par le Yard pour une sacrée affaire\r\nqu'il a bouclée y a dix ans !");
                s = s.Replace("The Professor case, no doubt.", "L'affaire du Démon Assassin, assurément.");
                s = s.Replace("The boss used to wind it up every evenin' wivout fail\r\nwhen 'e was waitin' for 'is grub to come at the pub.", "L'patron la r'montait tous les soirs sans faute au pub\r\nen attendant qu'on lui serve sa pitance.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("The boss used to wind it up every evenin' wivout fail\r\nwhen 'e was waitin' for 'is grub to come at the pub.", "L'patron la r'montait tous les soirs sans faute au pub\r\nen attendant qu'on lui serve sa pitance.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("...I see.", "...Je vois.");
                s = s.Replace("I swiped it off 'im once an' blimey was 'e upset!\r\n'E gave me a right earful.\r\nSaid 'e 'adn't missed a day in the last ten years, polishin' it\r\nan' windin' it.\r\nIt meant the world to 'im, that watch did.", "J'lui avais fauchée une fois et bon sang, qu'est-ce qu'il était furax !\r\nJ'ai pris une de ces avoinées !\r\nIl disait qu'il avait pas raté un seul jour en dix piges pour la frotter\r\net la remonter.\r\nElle comptait plus que tout au monde pour lui, c'te toquante.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("Said 'e 'adn't missed a day in the last ten years, polishin' it\r\nan' windin' it.\r\nIt meant the world to 'im, that watch did.", "Il disait qu'il avait pas raté un seul jour en dix piges pour la frotter\r\net la remonter.\r\nElle comptait plus que tout au monde pour lui, c'te toquante.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("(Possibly not the best thing to go diving for, then...)", "(Ce n'était peut-être pas la meilleure trouvaille à chaparder...)");
                s = s.Replace("It's not all that, though.\r\nI took it to Jabez's that night to ask 'ow much it was worth.\r\nBut the old dealer wouldn't touch it.\r\nWouldn't give me a penny for it. Said it wasn't workin'.\r\nKnocked about and worthless he called it.", "Elle est pas si terrible que ça, pour de vrai.\r\nJ'l'ai emmenée chez Jabez le soir même pour savoir combien elle valait.\r\nMais l'vieux brocanteur a refusé d'la toucher.\r\nIl m'en donnait pas un kopeck. Il a dit qu'elle marchait plus.\r\nCabossée et bonne pour la ferraille, qu'il a dit.");
                s = s.Replace("Agh! I knew I should've lifted it!", "Aargh ! J'savais bien qu'j'aurais dû l'embarquer !");
                s = s.Replace("That watch must be submitted as evidence at once!", "Cette montre doit être immédiatement remise au tribunal comme pièce à conviction !");
                s = s.Replace("Oh, please! Just, just so long as you promise to give it back\r\nwhen we're done!", "Oh, pitié ! D'accord, mais à condition que vous promettiez d'me la rendre\r\nquand on aura fini !");
                s = s.Replace("Not a chance! I'll swipe it from ya if you try to get your\r\ngrubby mitts on it again!", "Pas l'moindre espoir ! J'te la faucherai si t'oses remettre tes\r\nsales pattes dessus !");
                s = s.Replace("That's enough.\r\nHand the watch to the bailiff forthwith!", "Cela suffit.\r\nRemettez cette montre à l'huissier sur-le-champ !");
                s = s.Replace("(Now now, children, watch your manners...)", "(Allons, les enfants, un peu de tenue...)");
                s = s.Replace("Good Lord!\r\nThe glass appears to be broken.", "Grand Dieu !\r\nLe verre semble brisé.");
                s = s.Replace("More than likely, it shattered when the inspector was\r\nshot.", "Selon toute vraisemblance, il a volé en éclats lorsque l'inspecteur\r\na reçu la balle.");
                s = s.Replace("It doesn't tick any more, either.\r\nWhich is why Jabez didn't want it.\r\nWhat a waste, eh?", "Elle fait plus tic-tac non plus.\r\nC'est pour ça que Jabez en a pas voulu.\r\nQuel gâchis, hein ?");
                s = s.Replace("Yes, indeed. It appears to have stopped at the hour of five.", "Oui, en effet. Elle semble s'être arrêtée sur le coup de cinq heures.");
                s = s.Replace("(Exactly when the gunshot was heard, then...)", "(Exactement au moment où la détonation a été entendue...)");
                s = s.Replace("Which supports the prosecution's claim, of course...", "Ce qui conforte la thèse de l'accusation, naturellement...");
                s = s.Replace("Gregson's pocket watch has been\r\nentered into the Court Record.", "La montre à gousset de Gregson a été\r\nversée au dossier de l'affaire.");
                s = s.Replace("Well, it would appear that the mystery of the moving\r\nnoticeboard has been solved at least.", "Eh bien, il semblerait que le mystère du panneau déplacé\r\nsoit pour le moins éclairci.");
                s = s.Replace("And as predicted, it had very little bearing on the case.", "Et comme prévu, cela n'a que fort peu d'incidence sur l'affaire.");
                s = s.Replace("Ugh...", "Ouh...");
                s = s.Replace("Now then, continue with your cross-examination, please,\r\nCounsel.", "À présent, poursuivez votre contre-interrogatoire, je vous prie,\r\nMaître.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("You... certainly know how to lie...\r\nOh, it was nothin' really.\r\nJust a little porky.\r\nWith not-so-little implications...", "Vous... savez assurément comment mentir...\r\nOh, c'était trois fois rien, voyons.\r\nJuste une p'tite craque.\r\nAux conséquences pas si anodines...");
                s = s.Replace("Did you know?\r\nEverythin' in the world apart from the truth is a big fat\r\nlie!\r\n...If you believe that, of course.", "Vous l'saviez ?\r\nTout dans ce bas monde, à part la vérité, n'est qu'un gros\r\nmensonge éhonté !\r\n...Enfin, si on gobe ça, bien sûr.");
                s = s.Replace("...I'm lost.\r\nAs am I. This desecration of the truth is really rather\r\ndisturbing.\r\nI think perhaps we should move on to the next witness,\r\nhm?", "...Je suis dépassé.\r\nMoi de même. Une telle profanation de la vérité est fort déconcertante.\r\nPeut-être devrions-nous passer au témoin suivant, n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("But... you did go to see what had happened in the room,\r\ndidn't you?", "Mais... vous êtes bien allé voir ce qui s'était passé dans la pièce,\r\nn'est-ce pas ?");
                s = s.Replace("Fresno Street is my whole w-w-world. It's all I know.\r\nAnd I know all of it.\r\nI have to make it my b-business to know, if I want to\r\nh-hold my sign up high.", "Fresno Street est tout m-mon univers. C'est tout ce que je sais.\r\nEt je sais tout d'elle.\r\nJe dois en faire m-mon affaire si je veux p-porter haut mon panneau.");
                s = s.Replace("So you did go to see what had happened.", "Vous êtes donc bien allé voir ce qui s'était passé.");
                s = s.Replace("It's not the d-destination that's important... it's h-how you\r\nget there, isn't it?", "Ce n'est pas la d-destination qui compte... c'est le c-chemin,\r\nnon ?");
                s = s.Replace("Did you notice the noticeboard in the room?", "Avez-vous remarqué le panneau d'affichage dans la pièce ?");
                s = s.Replace("...If you think about it, we're b-both the same species,\r\naren't we? Both different members of the sign family.\r\nSo if I'd spotted it, I m-might have tried to t-trip it up out\r\nof a sense of rivalry, I admit.", "...Si on y réfléchit bien, nous appartenons à la m-même espèce,\r\npas vrai ? Deux membres distincts de la famille des enseignes.\r\nAlors si je l'avais vu, j-j'aurais p-peut-être essayé de lui faire un croque-en-jambe\r\npar pure rivalité, je l'avoue.");
                s = s.Replace("(Someone really needs to tell you that you're Homo\r\nsapiens not Homo signiens...)", "(Il faudrait vraiment que quelqu'un lui explique qu'il est un Homo\r\nsapiens et non un Homo pancartus...)");
                s = s.Replace("Does that mean that you didn't notice the board?", "Cela signifie-t-il que vous n'avez pas remarqué le panneau ?");
                s = s.Replace("I, I can only r-r-repeat what I said before:\r\nI, I don't know anything about anything. I'm j-just a\r\nbystander, me. J-Just a sign at the crossroads of life.", "J-Je ne peux que r-r-répéter ce que j'ai dit plus tôt :\r\nJ-Je ne sais rien sur rien, moi. Je ne suis qu'un s-simple spectateur.\r\nJ-Juste une enseigne au carrefour de l'existence.");
                s = s.Replace("...In which case, just who was responsible for moving the\r\nnoticeboard?", "...Dans ce cas, qui donc a bien pu déplacer ce tableau\r\nd'affichage ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("What exactly do you mean by that?", "Que voulez-vous dire exactement par là ?");
                s = s.Replace("Oh, come on now, don't tell uz you've not noticed.\r\nHe looks like he hates everythin' in the world, that fella.\r\nBut not noticeboards. They're the one thing he likes.\r\nYou can see it in his eyes.", "Oh allez, venez pas nous dire que vous l'avez point remarqué.\r\nCe gars-là a l'air de haïr la terre entière.\r\nMais pas les panneaux d'affichage. Y a qu'ça qui trouve grâce à ses yeux.\r\nÇa s'lit dans son regard.");
                s = s.Replace("...I can't say I'd ever noticed.", "...Je ne peux pas dire que j'aie remarqué cela.");
                s = s.Replace("I'll tell you one thing for free, though:\r\nI never took my eyes off that man on the floor.\r\nOr off the Reaper. Not for a second.", "J'vais vous dire un truc gratis, par contre :\r\nJ'ai jamais quitté des yeux l'gars par terre.\r\nNi l'Faucheur. Pas une seule seconde.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Well, I was that scared, I couldn't. You never know what\r\na fiend like that might do if you look away, do you?", "Ben, j'avais une de ces frousses ! On sait jamais c'qu'un démon pareil\r\npourrait vous faire si on r'garde ailleurs, pas vrai ?");
                s = s.Replace("If you didn't take your eyes off the defendant...\r\n...you should be able to confirm categorically whether or\r\nnot he was the one who moved the noticeboard.", "Si vous n'avez pas quitté l'accusé des yeux...\r\n...vous devriez pouvoir affirmer de façon catégorique s'il a\r\nou non déplacé ce panneau d'affichage.");
                s = s.Replace("Aye, that I can. The Reaper did nothin' of the sort.\r\nI can swear to that!\r\nI couldn't have missed it if he'd heaved the thing upright\r\nagain and dragged it into the corner!", "Ouaip, ça j'peux l'garantir ! Le Faucheur a rien fait d'la sorte.\r\nJ'peux l'jurer sur ma tête !\r\nJ'l'aurais point loupé s'il avait hissé l'machin à la verticale\r\npour l'traîner dans l'coin !");
                s = s.Replace("Right... glad we've cleared that up.", "Bien... ravi que ce point soit éclairci.");
                s = s.Replace("What happened to the face that screams ‘board’?", "Qu'est devenue cette tête qui crie « panneau » ?");
                s = s.Replace("(I feel your pain, Kazuma.)", "(Je compatis à ta détresse, Kazuma.)");
                return s;
            };

        }
    }
}
