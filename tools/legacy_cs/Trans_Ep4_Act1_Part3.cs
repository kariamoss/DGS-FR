using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act1 {
    public partial class Program {
        public static void RegisterPart3() {
            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So I suppose...", "Alors je suppose...");
                s = s.Replace("this is where the victim...?", "que c'est là que la victime... ?");
                s = s.Replace("That's right.", "C'est exact.");
                s = s.Replace("The rope is laid around the body to show\r\nexactly how it was found.", "La corde a été disposée autour du corps pour montrer\r\nprécisément comment il a été découvert.");
                s = s.Replace("Poor Inspector Gregson himself", "Le pauvre inspecteur Gregson lui-même");
                s = s.Replace("has already been taken\r\naway.", "a déjà été emporté.");
                s = s.Replace("(And would probably be under Dr Sithe's scalpel by now\r\nif not for what happened last week...)", "(Et il serait probablement sous le scalpel de la Dre Pétrie à l'heure qu'il est\r\ns'il ne s'était pas passé ce qui s'est produit la semaine dernière...)");
                s = s.Replace("From the shape of the rope...", "D'après la disposition de la corde...");
                s = s.Replace("...it would appear that the inspector was", "...il semblerait que l'inspecteur était");
                s = s.Replace("curled up in a\r\nball", "recroquevillé en\r\nboule");
                s = s.Replace("Are you feeling alright,", "Vous vous sentez bien,");
                s = s.Replace("Mr Naruhodo?", "Monsieur Naruhodo ?");
                s = s.Replace("You look like you've just seen a ghost.", "On dirait que vous venez de voir un fantôme.");
                s = s.Replace("I know it's just a rope,", "Je sais que ce n'est qu'une corde,");
                s = s.Replace("but... Well, it conjures up quite a\r\nterrifying image, that's all.", "mais... Disons qu'elle évoque une vision\r\nassez terrifiante, voilà tout.");
                s = s.Replace("Especially with that bloodstain next to it.", "Surtout avec cette tache de sang juste à côté.");
                s = s.Replace("Oh, I do understand.", "Oh, je comprends fort bien.");
                s = s.Replace("In some ways, what we picture in our minds can be even\r\nworse than reality.", "Par certains côtés, ce que nous imaginons peut être encore pire\r\nque la réalité.");
                s = s.Replace("(Susato-san is so strong, though.\r\nShe's taking this far better than I am...)", "(Susato est si forte, pourtant.\r\nElle prend tout cela bien plus vaillamment que moi...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Ever since we came in here...", "Depuis que nous sommes entrés ici...");
                s = s.Replace("I can't take my eyes off\r\nthis thing.", "je n'arrive pas à détacher mes yeux\r\nde cette chose.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("Funnily enough, neither can I!", "Curieusement, moi non plus !");
                s = s.Replace("It's...", "C'est...");
                s = s.Replace("a hairpiece, isn't it?", "un postiche, n'est-ce pas ?");
                s = s.Replace("It is!", "C'en est un !");
                s = s.Replace("It IS!", "C'en EST un !");
                s = s.Replace("A bright red hairpiece", "Un postiche d'un rouge flamboyant");
                s = s.Replace("And I suppose the fact that it's right there next to", "Et je suppose que le fait qu'il soit là, juste à côté de");
                s = s.Replace("where\r\nthe body was found...", "l'endroit où\r\nle corps a été trouvé...");
                s = s.Replace("...means we have to accept that...", "...nous oblige à admettre que...");
                s = s.Replace("Inspector Gregson wore\r\nwigs", "l'inspecteur Gregson portait\r\ndes perruques");
                s = s.Replace(", does it?", ", n'est-ce pas ?");
                s = s.Replace("And in such a flame-coloured red, too...", "Et d'un rouge si flamboyant, qui plus est...");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("that's a colour we've come across very recently\r\nelsewhere, isn't it?", "c'est une couleur que nous avons croisée très récemment\r\nailleurs, n'est-ce pas ?");
                s = s.Replace("Exactly!", "Exactement !");
                s = s.Replace("This is a vital clue, I'm sure of it!", "C'est un indice capital, j'en suis certaine !");
                s = s.Replace("The red hairpiece has been\r\nentered into the Court Record.", "Le postiche roux a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("The top of one of the candles in this candle holder has\r\nbeen completely blown off.", "Le sommet de l'une des bougies de ce chandelier a été complètement\r\npulvérisé.");
                s = s.Replace("Yes, there's wax spattered on the wall behind, look.", "Oui, de la cire a été projetée sur le mur derrière, regardez.");
                s = s.Replace("I suppose if a bullet had hit it...", "Je suppose que si une balle l'avait percutée...");
                s = s.Replace("It does seem likely that the bullet hit the candle...", "Il paraît en effet probable que la balle a touché la bougie...");
                s = s.Replace("...having first passed through the inspector's body.", "...après avoir d'abord traversé le corps de l'inspecteur.");
                s = s.Replace("Ugh...", "Brrr...");
                s = s.Replace("Now that wax on the wall looks like blood to me.", "À présent, cette cire sur le mur a des allures de sang pour moi.");
                s = s.Replace("The candelabrum has been\r\nentered into the Court Record.", "Le candélabre a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("This is presumably", "C'est donc vraisemblablement");
                s = s.Replace("the murder weapon", "l'arme du crime");
                s = s.Replace(", then...", ", alors...");
                s = s.Replace("Oh, oh my...", "Oh... grands dieux...");
                s = s.Replace("...It is real, I suppose?", "... Il est bien réel, je suppose ?");
                s = s.Replace("I, I think so.", "J-Je le crains.");
                s = s.Replace("Guns are so rare in Japan, I really know very little about\r\nthem.", "Les armes à feu sont si rares au Japon que je n'y connais vraiment\r\npas grand-chose.");
                s = s.Replace("There's one way to know for sure, Mr Naruhodo.", "Il y a un moyen d'en avoir le cœur net, Monsieur Naruhodo.");
                s = s.Replace("Fire a shot!", "Tirez un coup !");
                s = s.Replace("No no no!", "Non non non !");
                s = s.Replace("If I did that, I'd be looking for a skilled lawyer to represent\r\nme in court.", "Si je faisais ça, je serais bon pour me chercher un avocat hors pair\r\npour me représenter au tribunal.");
                s = s.Replace("(Slightly safer just to ask someone who might know, I\r\nthink.)", "(Il est nettement plus prudent de demander à quelqu'un qui s'y connaît,\r\nje crois.)");
                s = s.Replace("The killer's revolver has been\r\nentered into the Court Record.", "Le revolver du tueur a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Oh...what's this?", "Tiens... qu'est-ce que c'est ?");
                s = s.Replace("It would appear to be a little model policeman.", "Il semblerait que ce soit une petite figurine de policier.");
                s = s.Replace("It's rather charming, isn't it? In a way.", "C'est assez charmant, n'est-ce pas ? En quelque sorte.");
                s = s.Replace("Seeing as it's on the floor here... do you think it belonged\r\nto Inspector Gregson?", "Vu qu'elle est par terre ici... pensez-vous qu'elle appartenait\r\nà l'inspecteur Gregson ?");
                s = s.Replace("It's a little hard to imagine Lord van Zieks playing with\r\nsomething like this.", "On a un peu de mal à imaginer Lord Van Peers jouer avec\r\nun objet pareil.");
                s = s.Replace("(It's only about eight centimetres tall.\r\nIt could have fallen out of someone's pocket, I suppose.)", "(Elle ne fait qu'environ huit centimètres de haut.\r\nElle a pu tomber de la poche de quelqu'un, je suppose.)");
                s = s.Replace("I think we should record it as evidence, just in case.", "Je pense que nous devrions la conserver comme pièce à conviction, au cas où.");
                s = s.Replace("Yes, I agree.", "Oui, je suis d'accord.");
                s = s.Replace("It is rather delightful, after all.\r\nIn a way.", "C'est plutôt ravissant, après tout.\r\nEn quelque sorte.");
                s = s.Replace("The policeman figurine has been\r\nentered into the Court Record.", "La figurine de policier a été ajoutée\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("It is rather endearing in a way, isn't it?", "C'est assez attachant en quelque sorte, n'est-ce pas ?");
                s = s.Replace("This little London bobby.", "Ce petit bobby londonien.");
                s = s.Replace("You do realise that you keep saying how charming it is\r\n‘in a way’, don't you?", "Vous réalisez que vous ne cessez de répéter qu'il est charmant\r\n« en quelque sorte », n'est-ce pas ?");
                s = s.Replace("The truth is... on closer inspection his face scares me a\r\nlittle.", "À vrai dire... en y regardant de plus près, son visage m'effraie\r\nun peu.");
                s = s.Replace("Well... it is supposed to be a policeman.", "Eh bien... c'est censé être un agent de police.");
                s = s.Replace("Looking charming isn't generally in the job description as\r\nfar as I can tell.", "Avoir l'air charmant ne fait généralement pas partie du cahier des charges,\r\npour autant que je sache.");
                s = s.Replace("No, I suppose not... In a way, that makes me a little sad,\r\nthough.", "Non, sans doute pas... En quelque sorte, cela m'attriste un peu,\r\npourtant.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("This looks like some sort of noticeboard or something.", "On dirait une sorte de panneau d'affichage ou quelque chose du genre.");
                s = s.Replace("And it's absolutely covered in scraps of paper.", "Et il est entièrement tapissé de morceaux de papier.");
                s = s.Replace("...Ah! Mr Naruhodo, look!", "... Ah ! Monsieur Naruhodo, regardez !");
                s = s.Replace("This, you mean? It's an autopsy report, isn't it?", "Vous voulez dire ceci ? C'est un rapport d'autopsie, n'est-ce pas ?");
                s = s.Replace("And these are case notes here.", "Et ce sont des notes d'enquête, ici.");
                s = s.Replace("And details of prison inmates!", "Et des fiches de détenus !");
                s = s.Replace("Yes... in fact they're all the sort of documents that only a\r\ndetective could normally acquire.", "Oui... en fait, ce sont tous le genre de documents que seul un\r\ndétective pourrait normalement se procurer.");
                s = s.Replace("(What on earth went on in this room?)", "(Que diable s'est-il passé dans cette pièce ?)");
                s = s.Replace("Some old newspaper cuttings...", "De vieilles coupures de journaux...");
                s = s.Replace("Ah! And this one here!", "Ah ! Et celle-ci, là !");
                s = s.Replace("Oh yes, the advertisement, you mean?\r\n‘To the Red-Headed League’!", "Oh oui, cette petite annonce, voulez-vous dire ?\r\n« À la Ligue des Rouquins » !");
                s = s.Replace("B-But why? What's that doing here?", "M-Mais pourquoi ? Qu'est-ce que ça fait là ?");
                s = s.Replace("Whoever occupied this room was clearly interested in it\r\nfor some reason...", "Quiconque occupait cette pièce s'y intéressait de toute évidence\r\npour une raison précise...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("Oh... it's a photograph stand.", "Oh... c'est un cadre photo.");
                s = s.Replace("I suppose it must be a picture of one of Inspector\r\nGregson's family members.", "J'imagine que ce doit être le portrait d'un membre de la famille\r\nde l'inspecteur Gregson.");
                s = s.Replace("Wh-What's the matter? Your eyes look like they're about\r\nto pop out of your head.", "Q-Qu'y a-t-il ? Vous avez les yeux qui vous sortent\r\nde la tête.");
                s = s.Replace("They are! Look, Mr Naruhodo!\r\nQuickly!", "Mais oui ! Regardez, Monsieur Naruhodo !\r\nVite !");
                s = s.Replace("why do I feel like this woman is familiar somehow?", "pourquoi ai-je l'impression que cette femme m'est familière ?");
                s = s.Replace("Of course she's familiar!\r\nWe met her only this morning!", "Bien sûr qu'elle vous est familière !\r\nNous l'avons rencontrée ce matin même !");
                s = s.Replace("Aah!\r\nIt's... It's... It's...", "Aah !\r\nC'est... C'est... C'est...");
                s = s.Replace("...Mrs Vigil!", "... Mme Vigil !");
                s = s.Replace("This... makes no sense.\r\nWhy would there be a picture of Mrs Vigil in here?", "Cela... n'a aucun sens.\r\nPourquoi y aurait-il une photo de Mme Vigil ici ?");
                s = s.Replace("To be frank...", "Pour être franc...");
                s = s.Replace("...I don't think I've ever been more stumped.", "... je crois que je n'ai jamais été aussi perplexe.");
                s = s.Replace("I'm sorry to say, I have no idea either.", "J'ai le regret de vous dire que je n'en ai pas la moindre idée non plus.");
                s = s.Replace("The framed photograph has been\r\nentered into the Court Record.", "La photo encadrée a été ajoutée\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("There's really no question, is there?", "Il n'y a vraiment aucun doute, n'est-ce pas ?");
                s = s.Replace("It's the same woman we met only this morning!\r\nIt's definitely Mrs Vigil!", "C'est la même dame que nous avons rencontrée ce matin même !\r\nC'est bel et bien Mme Vigil !");
                s = s.Replace("A little younger-looking, perhaps, but still...", "Elle a l'air un peu plus jeune, peut-être, mais tout de même...");
                s = s.Replace("Aha! Perhaps she has a younger sister who looks just like\r\nher or something!", "Aha ! Peut-être a-t-elle une sœur cadette qui lui ressemble trait pour trait\r\nou quelque chose comme ça !");
                s = s.Replace("But the photograph does appear to be rather old, doesn't\r\nit?", "Mais la photographie a l'air passablement ancienne, n'est-ce pas ?");
                s = s.Replace("And anyway, the question remains: why would something\r\nlike this be in here?", "Et de toute façon, la question demeure : pourquoi une chose pareille\r\nse trouverait-elle ici ?");
                s = s.Replace("You're right, the question does remain.", "Vous avez raison, la question reste entière.");
                s = s.Replace("And I remain as stumped as I ever was by it...", "Et je reste plus perplexe que jamais...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("Somebody's very haphazardly nailed those boards over\r\nthe broken glass, haven't they?", "Quelqu'un a cloué ces planches à la va-vite par-dessus le carreau brisé,\r\nnon ?");
                s = s.Replace("You couldn't even really call it a window any more.", "On ne peut même plus vraiment appeler cela une fenêtre.");
                s = s.Replace("Well, if you remember the window in Mr Natsume's\r\nroom, that was totally blocked up with bricks.", "Eh bien, si vous vous souvenez de la fenêtre dans la chambre de M. Natsume,\r\nelle était totalement murée de briques.");
                s = s.Replace("This one does at least still let in some light, so you could\r\nsay–", "Celle-ci laisse au moins passer un peu de lumière, on pourrait\r\ndire que–");
                s = s.Replace("You could say nothing more about it.", "On pourrait n'en rien dire de plus.");
                s = s.Replace("...I'm starting to feel even more sorry for Mr Natsume\r\nnow.", "... Je commence à avoir encore plus pitié de M. Natsume,\r\nà présent.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("An empty fireplace makes a room feel even colder than it\r\nwould be otherwise, doesn't it?", "Une cheminée éteinte rend une pièce encore plus froide qu'elle ne le serait\r\nautrement, n'est-ce pas ?");
                s = s.Replace("It's thick with dust, look.", "Elle est couverte d'une épaisse couche de poussière, regardez.");
                s = s.Replace("I think it would be fair to say it hasn't been used in a very\r\nlong time.", "On peut sans trop s'avancer affirmer qu'elle n'a pas servi depuis\r\ntrès longtemps.");
                s = s.Replace("In other words...", "Autrement dit...");
                s = s.Replace("...whoever lived in this room must have been extremely\r\nhardy in cold weather.", "... quiconque vivait dans cette pièce devait être extrêmement\r\nrésistant au froid.");
                s = s.Replace("Or nobody lived here at all, and merely visited when the\r\noccasion arose.", "Ou bien personne n'y vivait, et ne s'y rendait qu'à l'occasion.");
                s = s.Replace("...I wouldn't like to say which is more likely.", "... Je ne saurais dire laquelle de ces hypothèses est la plus plausible.");
                s = s.Replace("N-No, that's right.\r\nIt's one or the other...", "N-Non, c'est vrai.\r\nC'est l'un ou l'autre...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("Um, excuse me...", "Euh, excusez-moi...");
                s = s.Replace("Oh, Inspector...", "Oh, inspecteur...");
                s = s.Replace("Ohhh, sir...", "Ohhh, patron...");
                s = s.Replace("(Poor man. He can't possibly be able to focus on\r\ninvestigating when he's so upset.)", "(Pauvre homme. Il ne peut manifestement pas se concentrer sur l'enquête\r\ntant il est bouleversé.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("Um, excuse me...", "Euh, excusez-moi...");
                s = s.Replace("Sorry, sir. Can't see a thing, sir. Too many tears, sir.", "Désolé, m'sieur. J'y vois goutte, m'sieur. Trop de larmes, m'sieur.");
                s = s.Replace("(Right. Perhaps I'd better leave you to your work, then...)", "(Compris. Je ferais peut-être mieux de vous laisser à votre tâche, alors...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_0_check_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("Um, excuse me...", "Euh, excusez-moi...");
                s = s.Replace("If you're looking down on us from the great beyond,\r\nInspector, don't worry. We'll look after things at the Yard.", "Si vous nous regardez depuis l'au-delà, inspecteur, ne vous en faites pas.\r\nOn veillera sur tout au Yard.");
                s = s.Replace("(I've interrupted some deep thoughts there...)", "(J'ai interrompu un profond recueillement...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("2nd November\r\nRoom on Fresno Street", "2 novembre\r\nChambre de Fresno Street");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("If it turns out that Gregson didn't actually die in here at\r\nall...", "S'il s'avère que Gregson n'est pas mort ici du tout...");
                s = s.Replace("...where on earth could he have been killed?", "...où diable a-t-il bien pu être tué ?");
                s = s.Replace("Well one way or another, we must find out.", "D'une manière ou d'une autre, nous devons le découvrir.");
                s = s.Replace("For the inspector's sake.", "Pour le repos de l'inspecteur.");
                s = s.Replace("You know, you look awfully pale again today,\r\nMr Naruhodo.", "Vous savez, vous avez l'air affreusement pâle aujourd'hui encore,\r\nMonsieur Naruhodo.");
                s = s.Replace("Ugh...sorry. When I start thinking it all through, I conjure\r\nup some horrible images in my mind.", "Ouf... désolé. Quand je commence à réfléchir à tout ça, j'ai d'affreuses\r\nimages qui me viennent à l'esprit.");
                s = s.Replace("Your imagination is the culprit here, then.\r\nMost certainly guilty!", "C'est donc votre imagination la coupable.\r\nAssurément coupable !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("It catches your eye as soon as you enter the room,\r\ndoesn't it?", "Il saute aux yeux dès qu'on entre dans la pièce,\r\nn'est-ce pas ?");
                s = s.Replace("It's such a bright colour, it certainly makes an impression,\r\nyes.", "C'est une couleur si vive, cela marque incontestablement les esprits,\r\noui.");
                s = s.Replace("...They can't possibly commit any crimes, can they?\r\nI mean, red-heads stand out like a sore thumb.", "... Ils ne peuvent décemment commettre aucun crime, non ?\r\nJe veux dire, les roux se remarquent comme le nez au milieu de la figure.");
                s = s.Replace("I'm afraid with our jet-black Japanese hair, we stand out\r\nalmost as much, here in London.", "J'ai bien peur qu'avec nos cheveux japonais d'ébène, nous nous fassions\r\ntout autant remarquer, ici à Londres.");
                s = s.Replace("Haah...\r\nI suppose that's true.", "Haah...\r\nJ'imagine que c'est vrai.");
                s = s.Replace("You mustn't think of committing any crimes,\r\nMr Naruhodo.", "N'allez pas vous imaginer commettre le moindre forfait,\r\nMonsieur Naruhodo.");
                s = s.Replace("I wasn't!", "Ce n'était pas mon intention !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Using a candle as a timer device...\r\nVery ingenious, I must say.", "Se servir d'une bougie comme dispositif à retardement...\r\nTrès ingénieux, je dois dire.");
                s = s.Replace("Yes, the culprit arranged it so that the firecracker would\r\nbe set off at five o'clock, and then left.", "Oui, le coupable a fait en sorte que le pétard explose à cinq heures sonnantes,\r\npuis il est parti.");
                s = s.Replace("So that a loud bang was heard at precisely the moment\r\nLord van Zieks arrived, yes.", "De sorte qu'une forte détonation a retenti précisément au moment où\r\nLord Van Peers est arrivé, oui.");
                s = s.Replace("If only he hadn't picked up that gun from the floor...", "Si seulement il n'avait pas ramassé cette arme au sol...");
                s = s.Replace("Something you probably told yourself once upon a time,\r\nI imagine?", "Une pensée que vous vous êtes sans doute formulée jadis,\r\nj'imagine ?");
                s = s.Replace("Yes, I've learnt that lesson by bitter experience.\r\nI would have turned and run a mile for sure.", "Oui, j'ai appris cette leçon à mes dépens.\r\nJ'aurais tourné les talons et détalé à toute allure, pour sûr.");
                s = s.Replace("...Which may not have done you any favours, either.", "... Ce qui ne vous aurait peut-être guère rendu service non plus.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("This revolver... Just who does it belong to?", "Ce revolver... À qui appartient-il au juste ?");
                s = s.Replace("Well, we know it's of the type issued to members of the\r\npolice force and judiciary.", "Eh bien, nous savons qu'il s'agit du modèle fourni aux membres des forces\r\nde l'ordre et du corps judiciaire.");
                s = s.Replace("But Gregson's own gun was found on his person.", "Mais la propre arme de Gregson a été retrouvée sur lui.");
                s = s.Replace("And of course Lord van Zieks has admitted to losing the\r\nfirearm with which he was issued.", "Et bien entendu, Lord Van Peers a admis avoir égaré l'arme de poing\r\nqui lui avait été allouée.");
                s = s.Replace("Such absent-mindedness... Not dissimilar to you,\r\nMr Naruhodo.", "Une telle étourderie... Ce n'est pas sans rappeler un certain\r\nMonsieur Naruhodo.");
                s = s.Replace("I'm starting to think the cold, hard prosecutor and I could\r\nbecome friends after all.", "Je commence à penser que ce procureur froid et inflexible et moi pourrions\r\nfinir par devenir amis, après tout.");
                s = s.Replace("Then I wish you every success!", "Dans ce cas, je vous souhaite plein succès !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("I'd never have imagined that this little figurine would\r\nturn out to be a watch winding key.", "Je n'aurais jamais imaginé que cette petite figurine se révélerait être\r\nune clef de remontage de montre.");
                s = s.Replace("I suppose it's a policeman because the pocket watch was a\r\ngift from Scotland Yard.", "J'imagine qu'elle représente un policier parce que la montre à gousset était\r\nun cadeau de Scotland Yard.");
                s = s.Replace("It seems there was much more to Inspector Gregson than\r\nwe ever realised. He was clearly a brilliant man.", "Il semble que l'inspecteur Gregson était bien plus profond que ce que nous\r\nimaginions. C'était manifestement un homme brillant.");
                s = s.Replace("It's the fish and chips that threw us off.\r\nI feel as though it ruined his image.", "C'est son poisson-frites qui nous a induits en erreur.\r\nJ'ai l'impression que ça gâchait son image.");
                s = s.Replace("I really don't think we should blame one of Britain's\r\nstaple cuisines...", "Je ne crois vraiment pas qu'il faille blâmer l'un des fleurons de la gastronomie\r\nbritannique...");
                s = s.Replace("But think about it.\r\nImagine if it was Mr Sholmes.", "Mais réfléchissez.\r\nImaginez si c'était Monsieur Holmes.");
                s = s.Replace("How would you feel if instead of that old briar pipe that's\r\nalways in his hand, Mr Sholmes had a bag of chips?", "Que ressentiriez-vous si au lieu de cette vieille pipe en bruyère qu'il a toujours\r\nà la main, Monsieur Holmes tenait un cornet de frites ?");
                s = s.Replace("Rather disappointed, if I'm honest.", "Plutôt déçue, pour être honnête.");
                s = s.Replace("Exactly.", "Exactement.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("There are details of cases stretching back over ten years\r\non this noticeboard.", "Ce tableau regorge de détails d'affaires remontant à plus de dix ans.");
                s = s.Replace("Yes, a history of Lord van Zieks's defeats in court.", "Oui, la chronique des défaites judiciaires de Lord Van Peers.");
                s = s.Replace("I don't think that's an appropriate description.", "Je ne pense pas que ce soit une formule appropriée.");
                s = s.Replace("Although... when you consider everything on the board,\r\nit's certainly true...", "Quoique... à bien y regarder,\r\nil est bien vrai...");
                s = s.Replace("...that all these people had a background of dubious\r\ndealings.", "... que toutes ces personnes avaient un passé d'affaires douteuses.");
                s = s.Replace("And in the end of course...", "Et à la fin, bien sûr...");
                s = s.Replace("...the board itself concealed the inspector's own death.", "...le panneau lui-même dissimulait la propre mort de l'inspecteur.");
                s = s.Replace("Oh my... It really doesn't bear thinking about.", "Grands dieux... Cela fait froid dans le dos.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("The photograph of Mrs Vigil...", "La photographie de Mme Vigil...");
                s = s.Replace("Realising the identity of this lady was a very great clue\r\nto exposing Mr Gossip's true identity.", "Découvrir l'identité de cette dame fut un indice majeur\r\npour percer à jour la véritable identité de M. Gossip.");
                s = s.Replace("He obviously loves his wife very dearly.", "Il aime manifestement son épouse de tout son cœur.");
                s = s.Replace("...Which is why he felt he couldn't tell her the truth.", "... C'est pourquoi il s'est senti incapable de lui avouer la vérité.");
                s = s.Replace("The transformation was incredible, wasn't it?\r\nJust from that big twisted lip.", "La métamorphose était stupéfiante, n'est-ce pas ?\r\nSimplement avec cette grosse lèvre tordue.");
                s = s.Replace("Yes, he went to extraordinary efforts to play the part of\r\nHugh Boone convincingly.", "Oui, il a déployé des efforts extraordinaires pour jouer le rôle de\r\nHugh Boone avec conviction.");
                s = s.Replace("Although... it didn't really seem like it was much of an\r\neffort to me.", "Quoique... cela ne m'avait pas vraiment l'air de lui demander un gros effort.");
                s = s.Replace("Hm... Now you say it, I have to agree.", "Hum... Maintenant que vous le dites, je dois convenir.");
                s = s.Replace("It's almost as if that was Mr Vigil's true character.", "C'est presque comme si c'était là le véritable caractère de M. Vigil.");
                s = s.Replace("...People really are very hard to fathom at times.", "... La nature humaine est parfois bien impénétrable.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("...This little trunk wasn't here before, was it?", "... Cette petite malle n'était pas là tout à l'heure, si ?");
                s = s.Replace("Oh! ...It appears to be made of metal.\r\nIt must be very heavy.", "Oh ! ... Elle semble faite de métal.\r\nElle doit être très lourde.");
                s = s.Replace("I wonder to whom it belongs...", "Je me demande à qui elle appartient...");
                s = s.Replace("There are some initials on the outside, look.\r\n‘T. G.’", "Il y a des initiales à l'extérieur, regardez.\r\n« T. G. »");
                s = s.Replace("Let's ask one of the policemen if they know how it came\r\nto be here.", "Demandons à l'un des policiers s'ils savent comment elle a atterri ici.");
                s = s.Replace("Ooooooi!", "Hééééééé !");
                s = s.Replace("Wot d'ya think yer doin'?!", "Qu'est-ce que vous manigancez, vous deux ?!");
                s = s.Replace("That's my trunk, that is!", "C'est ma malle à moi, ça !");
                s = s.Replace("'Ands off!", "Pas touche !");
                s = s.Replace("Gina!", "Gina !");
                s = s.Replace("Wh-Where were you hiding?!", "O-Où est-ce que tu te cachais ?!");
                s = s.Replace("I dunno, ya leave somefin' unattended for a few seconds,\r\nan' every Tom, Dick an' 'Arry's got 'is greedy eyes on it!", "J'te jure, on laisse un truc sans surveillance deux secondes,\r\net le premier clampin venu y fourre ses sales pattes !");
                s = s.Replace("just a wild guess, Gina, but...", "simple supposition au hasard, Gina, mais...");
                s = s.Replace("Wot? Spit it out, 'Oddo.", "Quoi ? Accouche, Naruhodo !");
                s = s.Replace("Is it fair to say that you've only owned that trunk since\r\nthis morning's trial?", "Ne l'aurais-tu pas récupérée seulement depuis le procès de ce matin ?");
                s = s.Replace("Wot?!", "Quoi ?!");
                s = s.Replace("W-Wot are you tryin' to say?!", "Q-Qu'est-ce que tu baves ?!");
                s = s.Replace("Come on, this trunk goes wiv me everywhere!", "Mais non, cette malle m'accompagne partout !");
                s = s.Replace("Always 'as! Where've ya been the last year?!", "Depuis toujours ! T'étais où, l'année passée ?!");
                s = s.Replace("(Trying not to incur your wrath, mainly...)", "(À essayer de ne pas m'attirer tes foudres, principalement...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0402_1_check_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Gina, I'm... really sorry.", "Gina, je suis... vraiment désolé.");
                s = s.Replace("It's daft, innit? If ya asked me a year ago, the cops could go\r\n'ang for all I cared.", "C'est bête, pas vrai ? Si tu m'avais demandé y a un an, les cognes pouvaient\r\ncrever que ça m'aurait fait ni chaud ni froid.");
                s = s.Replace("But we've gotta 'ave police, ain't we?\r\nTo catch the bludgers.", "Mais faut bien des flics, pas vrai ?\r\nPour choper les truands.");
                s = s.Replace("So us divers can go about our business in peace.", "Pour que nous autres tire-laines, on puisse faire nos affaires peinards.");
                s = s.Replace("Wait... sorry? I, I don't think I can have heard that\r\nproperly...", "Attends... pardon ? J-Je crois que j'ai mal entendu...");
                s = s.Replace("'E said 'e was gonna teach me everyfin' I needed to know\r\nto be a detective.", "Il disait qu'il allait m'apprendre tout c'qu'il fallait savoir\r\npour être détective.");
                s = s.Replace("But all 'e got round to showin' me is where the best\r\nflamin' fish 'n' chip shops are!", "Mais tout c'qu'il a trouvé à m'montrer, c'est les meilleures bicoques\r\nde poisson-frites de la ville !");
                s = s.Replace("(Actually, that reminds me...)", "(À vrai dire, ça me rappelle...)");
                s = s.Replace("(Gregson said he was supposed to be going to Paris in the\r\nnear future, didn't he?)", "(Gregson avait dit qu'il devait partir pour Paris incessamment sous peu,\r\nn'est-ce pas ?)");
                s = s.Replace("Is something wrong?", "Quelque chose ne va pas ?");
                s = s.Replace("Oh... no. I'm sure I'm reading too much into things.", "Oh... non. Je me fais sûrement des idées.");
                s = s.Replace("It's just that the timing seems very coincidental.", "C'est juste que la coïncidence temporelle est troublante.");
                s = s.Replace("Hm?", "Hein ?");
                s = s.Replace("You know, the boss was actin' a bit strange recently.", "Tu sais, le patron agissait bizarrement ces derniers temps.");
                s = s.Replace("Like 'e was always in a rush...", "Comme s'il était tout l'temps pressé...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Those large jars seem to have pale things floating around\r\ninside them.", "Ces grands bocaux renferment des choses blanchâtres qui flottent à l'intérieur.");
                s = s.Replace("I suppose they're fruit liquors or something.\r\nOr like the pickled umeboshi plums we make back home.", "J'imagine que ce sont des liqueurs de fruits ou quelque chose du genre.\r\nOu des prunes umeboshi marinées comme chez nous.");
                s = s.Replace("...Yes, let's assume they're something completely innocent\r\nlike that!", "... Oui, partons du principe que c'est une chose tout à fait inoffensive\r\nde ce genre !");
                s = s.Replace("Ah, that jar you're looking at up there contains monkey\r\nbrains.", "Ah, ce bocal que vous observez là-haut contient des cervelles\r\nde singe.");
                s = s.Replace("Oh my...", "Grands dieux...");
                s = s.Replace("The composition is similar to the human brain, so they\r\nmake for interesting study material.", "Leur constitution est semblable à celle du cerveau humain, cela en fait\r\nun sujet d'étude fascinant.");
                s = s.Replace("And in the next jar along, we have monkey–", "Et dans le bocal d'à côté, nous avons du singe–");
                s = s.Replace("No no no! No more monkey anythings!\r\n...Please.", "Non non non ! Plus rien qui vienne d'un singe !\r\n... De grâce.");
                s = s.Replace("...If you say so.", "... Comme vous voudrez.");
                s = s.Replace("Oh dear...\r\nThe time when I still thought it was just some pickled\r\numeboshi plums seems so long ago already...", "Misère...\r\nL'époque où je croyais encore que c'étaient des prunes umeboshi marinées\r\nsemble déjà si lointaine...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("A table and a set of sharp tools... When you consider each\r\nin isolation, it all looks quite innocent.", "Une table et un assortiment d'instruments tranchants... Pris isolément,\r\ntout cela a l'air bien anodin.");
                s = s.Replace("So why is it that when you put them side by side, they\r\nseem so horribly disturbing?", "Alors pourquoi, lorsqu'on les réunit côte à côte, cela paraît-il\r\nsi horriblement dérangeant ?");
                s = s.Replace("...It might be best not to ponder it too deeply.", "... Il vaut peut-être mieux ne pas trop méditer là-dessus.");
                s = s.Replace("That's Mama's dissection table.\r\nIt's too high for me, though.", "C'est la table de dissection de maman.\r\nElle est trop haute pour moi, par contre.");
                s = s.Replace("It, it is...?", "V-Vraiment... ?");
                s = s.Replace("If I fell from that height in my sleep, it would really hurt.", "Si je tombais de cette hauteur dans mon sommeil, je me ferais très mal.");
                s = s.Replace("Wha...?! You, you mean you sleep in here?", "Quoi... ?! Vous... vous voulez dire que vous dormez ici ?");
                s = s.Replace("...Autopsy work is very involved. It's usually too late to\r\nthink about going home when I'm finished.", "... Le travail d'autopsie est très exigeant. Il est généralement trop tard\r\npour penser à rentrer chez moi quand j'ai fini.");
                s = s.Replace("But I have bad dreams when I sleep here, and I always\r\nend up falling onto the floor.", "Mais je fais de mauvais rêves quand je dors ici, et je finis toujours\r\npar tomber par terre.");
                s = s.Replace("So I'd like to exchange that table for a lower one.", "Alors j'aimerais bien changer cette table pour une plus basse.");
                s = s.Replace("...Maybe you should just go home.", "... Peut-être devriez-vous simplement rentrer chez vous.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Look at all the bottles on the shelves in these cabinets!\r\nWhat an assortment of chemicals!", "Regardez toutes ces bouteilles sur les étagères de ces armoires !\r\nQuel assortiment de produits chimiques !");
                s = s.Replace("These ones here are labelled ‘Highly Toxic’.", "Celles-ci portent l'étiquette « Hautement toxique ».");
                s = s.Replace("Ugh, that's worrying. Because there are also things that\r\nlook like salt and pepper shakers in there.", "Brrr, c'est inquiétant. Parce qu'il y a aussi des récipients qui ressemblent\r\nà des salières et poivrières à l'intérieur.");
                s = s.Replace("Oh yes! And they actually say ‘salt’ and ‘pepper’ on them!", "Oh oui ! Et il est bel et bien écrit « sel » et « poivre » dessus !");
                s = s.Replace("The doctor probably spends a lot of time in this room, I\r\nsuppose. Perhaps she has meals here sometimes.", "Le médecin passe sans doute beaucoup de temps dans cette pièce, je suppose.\r\nPeut-être y prend-elle ses repas parfois.");
                s = s.Replace("Life goes on... even when you're surrounded by death...", "La vie continue... même lorsqu'on est entouré par la mort...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("This looks... different to before.", "Cela semble... différent d'avant.");
                s = s.Replace("Of course, Mr Naruhodo.", "Bien sûr, Monsieur Naruhodo.");
                s = s.Replace("Miss Gorey is a young maiden.", "Mademoiselle Pétrie est une jeune fille.");
                s = s.Replace("She has all sorts of charming little dolls and the like\r\naround her place of work, look.", "Elle a toutes sortes de charmantes petites poupées disséminées sur son lieu\r\nde travail, regardez.");
                s = s.Replace("Oh yes, you're right. Perhaps she's not so strange after all.", "Oh oui, vous avez raison. Peut-être n'est-elle pas si étrange après tout.");
                s = s.Replace("...They're how I practise.", "... C'est comme ça que je m'entraîne.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Mama always says that operations and dissections require\r\nspeed and accuracy.", "Maman dit toujours que les opérations et les dissections exigent\r\nrapidité et précision.");
                s = s.Replace("So I take out my needle and thread and stitch three new\r\ndolls every day.", "Alors je sors mon fil et mon aiguille et je recouds trois nouvelles\r\npoupées chaque jour.");
                s = s.Replace("Ah... right...", "Ah... d'accord...");
                s = s.Replace("I used to make livers or kidneys or intestines...", "Avant, je cousais des foies, des reins ou des intestins...");
                s = s.Replace("...but Mama told me to make something more friendly\r\ninstead.", "... mais maman m'a dit de fabriquer des choses plus avenantes à la place.");
                s = s.Replace("That's... quite different to what I'd imagined.", "C'est... assez éloigné de ce que j'avais imaginé.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("That looks like an owl and a crow up there.", "On dirait une chouette et un corbeau, là-haut.");
                s = s.Replace("I know. And they haven't even twitched since we came\r\nin here...", "Je sais. Et ils n'ont pas bronché d'un millimètre depuis que nous sommes\r\nentrés ici...");
                s = s.Replace("Well no, they wouldn't have. They're taxidermy mounts, Mr Naruhodo.", "Eh bien non, évidemment. Ce sont des spécimens naturalisés, Monsieur Naruhodo.");
                s = s.Replace("Ugh... I was afraid you were going to say that.", "Ouf... j'avais peur que vous ne disiez ça.");
                s = s.Replace("I've been trying very hard to tell myself they're just\r\nsleeping with their eyes open.", "Je m'efforçais de me convaincre qu'ils dormaient les yeux ouverts.");
                s = s.Replace("Yes, I think perhaps you were wise to put something like\r\nyour daruma doll on display in the office instead...", "Oui, je crois que vous avez été bien avisé d'exposer plutôt votre poupée\r\ndaruma au bureau...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Well, look at this! What a magnificent display case!", "Eh bien, regardez-moi ça ! Quelle magnifique vitrine !");
                s = s.Replace("The cherry wood has been polished to a high sheen, and\r\nthe intricate carving is a joy to behold.", "Le bois de cerisier a été poli à la perfection, et\r\nces sculptures ouvragées sont un pur ravissement.");
                s = s.Replace("Western cabinet makers really are very skilled, aren't\r\nthey?", "Les ébénistes occidentaux sont vraiment très doués, n'est-ce pas ?");
                s = s.Replace("It's ten people.", "C'est dix personnes.");
                s = s.Replace("Pardon?", "Pardon ?");
                s = s.Replace("It's made from the bones of ten different people, all mixed\r\ntogether.", "C'est fait avec les os de dix personnes différentes, tous mélangés.");
                s = s.Replace("Some of my best work!", "Une de mes plus belles créations !");
                s = s.Replace("I was admiring the case, actually.", "J'admirais la vitrine, à vrai dire.");
                s = s.Replace("The scary skeleton inside is... something I intend to ignore\r\nas best I can.", "L'effrayant squelette à l'intérieur est... quelque chose que j'entends ignorer\r\nde mon mieux.");
                s = s.Replace("You're strange.", "Vous êtes étrange.");
                s = s.Replace("...I wonder who is the strangest...", "... Je me demande qui de nous deux est le plus étrange...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_bg0404_1_check_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Let's have a closer look at this...", "Regardons ceci de plus près...");
                s = s.Replace("(Then again, let's not. At least, not while she's armed.)", "(D'un autre côté, abstenons-nous. Du moins, pas tant qu'elle est armée.)");
                return s;
            };

        }
    }
}
