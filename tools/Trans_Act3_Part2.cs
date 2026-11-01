using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct3 {
    public partial class Program {
        public static void RegisterPart2() {
            // BB\script\output\_sce02_bg0206_0_00_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_00_eng#4"] = en => {
                string s = en;
                s = s.Replace("22nd October\r\n<CNTR><E003 5>Naruhodo's Legal Consultancy",
                              "22 octobre\r\n<CNTR><E003 5>Cabinet juridique de Naruhodo");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("It's...<E003 10>Susato-san's desk...", "C'est...<E003 10> le bureau de Susato-san...");
                s = s.Replace("It's...<E003 10>Miss Susato's desk...", "C'est...<E003 10> le bureau de Mlle Susato...");
                s = s.Replace("I suppose it won't get used<E003 4> now that she's gone back to\r\nJapan.",
                              "J'imagine qu'il ne servira plus à rien<E003 4> maintenant qu'elle est\r\nrepartie au Japon.");
                s = s.Replace("It'll just have to wait here patiently for its old friend to\r\nreturn...",
                              "Il va simplement devoir attendre patiemment le retour de\r\nson ancienne amie...");
                s = s.Replace("Even now, <E003 8><E025 2>I sometimes find myself pouring a cup of tea\r\nfor Susie by mistake.",
                              "Même maintenant, <E003 8><E025 2>il m'arrive encore de servir une tasse de thé\r\npour Susato par réflexe.");
                s = s.Replace("Ah, <E003 8><E145 110 74>that explains why I sometimes find a steaming cup on\r\nher desk here.<E003 10> It shocks me every time.",
                              "Ah, <E003 8><E145 110 74>ça explique pourquoi je trouve parfois une tasse fumante sur\r\nson bureau.<E003 10> Ça me fait un choc à chaque fois.");
                s = s.Replace("But it's just one of your pranks, I see.",
                              "Mais ce n'est qu'une de tes farces, je vois.");
                s = s.Replace("It's no prank!<E003 12> I miss her!",
                              "Ce n'est pas une farce !<E003 12> Elle me manque !");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("Now<E003 4> at first glance,<E003 8> my desk here might look as though\r\nit's in a mess.<E003 10> However...",
                              "Alors,<E003 4> à première vue,<E003 8> mon bureau semble en désordre total.<E003 10>\r\nCependant...");
                s = s.Replace("...it's not in a mess at all.<E003 10> <E333>Everything is exactly where I\r\nwant it to be.",
                              "... ce n'est pas du désordre du tout.<E003 10> <E333>Chaque chose est exactement\r\nlà où je souhaite qu'elle soit.");
                s = s.Replace("But whenever Susato-san looked at it,<E003 6> she'd put her\r\nhands on her hips and say,<E003 10> <E025 3><E341>‘Oh dear.’",
                              "Mais chaque fois que Susato-san le regardait,<E003 6> elle mettait les\r\nmains sur les hanches en soupirant :<E003 10> <E025 3><E341>« Mon Dieu. »");
                s = s.Replace("But whenever Miss Susato looked at it,<E003 6> she'd put her\r\nhands on her hips and say,<E003 10> <E025 3><E341>‘Oh dear.’",
                              "Mais chaque fois que Mlle Susato le regardait,<E003 6> elle mettait les\r\nmains sur les hanches en soupirant :<E003 10> <E025 3><E341>« Mon Dieu. »");
                s = s.Replace("Her way of saying that I should make it a more orderly<E003 6>\r\nand neat mess.",
                              "Sa façon à elle de me suggérer de transformer ce bazar en un\r\ndésordre un peu plus rangé.");
                s = s.Replace("...I miss that.", "... Ça me manque.");
                s = s.Replace("You sound just like Hurley, <E003 6>you know.<E049><E003 10>\r\nHe says the same about his mess.",
                              "Tu as exactement la même réplique que Sherlockinou, <E003 6>tu sais.<E049><E003 10>\r\nIl prétend la même chose pour son fouillis.");
                s = s.Replace("(It's the kind of logic that transcends international borders,<E003 8>\r\n<E025 3>obviously...)",
                              "(C'est visiblement le genre de logique qui transcende les frontières,<E003 8>\r\n<E025 3>sans nul doute...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Ah yes,<E003 8> the daruma doll I brought with me from Japan.",
                              "Ah oui,<E003 8> la poupée daruma que j'ai emportée du Japon.");
                s = s.Replace("I always intended to colour in the other eye<E003 4> once I'd\r\nbecome a fully-fledged lawyer.",
                              "J'ai toujours eu l'intention de lui peindre l'autre œil<E003 4> une fois\r\ndevenu un avocat à part entière.");
                s = s.Replace("But it's still winking at me.<E003 8> Like it's trying to say,<E003 8> <E333>‘I can\r\nwait.<E003 8> Take as long as you need.’",
                              "Mais elle me fait toujours un clin d'œil.<E003 8> Comme si elle me disait :<E003 8>\r\n<E333>« Je peux attendre.<E003 8> Prends tout le temps qu'il te faut. »");
                s = s.Replace("...Or<E003 8> maybe not.<E003 14> <E025 2>I'll just have to keep on doing the best I\r\ncan,<E003 6> I suppose.",
                              "... Ou<E003 8> peut-être pas.<E003 14> <E025 2>Je dois juste continuer à faire de mon mieux,<E003 6>\r\nj'imagine.");
                s = s.Replace("I could colour it in for you, Runo!<E049><E003 10>\r\n<E025 2><E333>Just that one eye, <E003 4>is it?",
                              "Je peux le colorier pour toi, Nicky !<E049><E003 10>\r\n<E025 2><E333>Juste cet œil-là, <E003 4>c'est ça ?");
                s = s.Replace("No no!<E003 12> <E145 110 64>It needs to be done with a bit of ceremony, Iris!<E003 10>\r\n<E025 2>It's not just a toy for colouring in, <E003 4>you know.",
                              "Non, non !<E003 12> <E145 110 64>Il y a tout un rituel à respecter, Iris !<E003 10>\r\n<E025 2>Ce n'est pas un simple coloriage, <E003 4>tu sais.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("The kettle's gently simmering away there on top of the\r\nstove as usual.",
                              "La bouilloire chante doucement sur le poêle, comme toujours.");
                s = s.Replace("It was kind of Susato-san to send that Japanese tea.<E003 10>\r\nIris really likes it.",
                              "C'était très gentil de la part de Susato-san d'envoyer ce thé japonais.<E003 10>\r\nIris l'apprécie énormément.");
                s = s.Replace("It was kind of Miss Susato to send that Japanese tea.<E003 10>\r\nYou really like it,<E003 6> don't you, Iris?",
                              "C'était très gentil de la part de Mlle Susato d'envoyer ce thé japonais.<E003 10>\r\nTu l'aimes beaucoup,<E003 6> n'est-ce pas, Iris ?");
                s = s.Replace("But for me,<E003 6> it's the sound of the stove and burbling kettle I\r\nlike the most.<E003 8> On biting winter mornings.",
                              "Mais pour moi,<E003 6> c'est le ronronnement du poêle et les glouglous\r\nde l'eau que je préfère.<E003 8> Par ces rudes matins d'hiver.");
                s = s.Replace("‘And it feels even cosier in here when the delightful Iris\r\npours the tea for me.’",
                              "« Et c'est encore plus réconfortant quand la ravissante Iris\r\nme sert mon thé. »");
                s = s.Replace("‘I really couldn't manage without that wonderful young\r\ngirl.’",
                              "« Je ne pourrais vraiment pas m'en sortir sans cette adorable\r\njeune fille. »");
                s = s.Replace("Oh, <E003 8>Runo!<E003 10> It's so sweet of you to say so!",
                              "Oh, <E003 8>Nicky !<E003 10> C'est tellement gentil de dire ça !");
                s = s.Replace("...Stop putting words in my mouth, please, <E003 6>Iris.",
                              "... Arrête de me faire dire ce que je n'ai pas dit, <E003 6>Iris.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("The office spade...", "La pelle du cabinet...");
                s = s.Replace("Now that Susato-san's gone,<E003 6> the shovellers aren't\r\nrepresented to correct me.",
                              "Maintenant que Susato-san est partie,<E003 6> le camp des bêcheurs n'est plus\r\nlà pour me corriger.");
                s = s.Replace("Now that Miss Susato's gone,<E003 6> the shovellers aren't\r\nrepresented to correct me.",
                              "Maintenant que Mlle Susato est partie,<E003 6> le camp des bêcheurs n'est plus\r\nlà pour me corriger.");
                s = s.Replace("Maybe I'll have to do it myself.<E003 14>\r\n<E330>‘That's not a spade,<E003 4> Naruhodo-san;<E003 8> it's a shovel!’",
                              "Je vais devoir m'en charger moi-même.<E003 14>\r\n<E330>« Ce n'est pas une pelle,<E003 4> Naruhodo-san ;<E003 8> c'est une bêche ! »");
                s = s.Replace("Maybe I'll have to do it myself.<E003 14>\r\n<E330>‘That's not a spade,<E003 4> Mr Naruhodo;<E003 8> it's a shovel!’",
                              "Je vais devoir m'en charger moi-même.<E003 14>\r\n<E330>« Ce n'est pas une pelle,<E003 4> Mr Naruhodo ;<E003 8> c'est une bêche ! »");
                s = s.Replace("Ah, <E049><E003 8>so you're a spader, <E049><E003 6>are you, Runo?",
                              "Ah, <E049><E003 8>alors tu es du côté des pelles, <E049><E003 6>hein, Nicky ?");
                s = s.Replace("What, <E003 6>you want to battle it out?",
                              "Quoi, <E003 6>tu veux qu'on règle ça en duel ?");
                s = s.Replace("(Alright, <E003 8>I'm not going to argue with a native English\r\nspeaker...<E003 10><E025 3><E330>who has some kind of gun...)",
                              "(D'accord, <E003 8>je ne vais pas contredire une Britannique de souche...<E003 10><E025 3><E330>\r\nsurtout avec l'arme à feu qu'elle a sur elle...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Susato-san's tea set that she left here with me.", "Le service à thé que Susato-san m'a laissé ici.");
                s = s.Replace("Miss Susato's tea set that she left here with me.", "Le service à thé que Mlle Susato m'a laissé ici.");
                s = s.Replace("I still think green tea is just too bitter, though.<E003 12>\r\n<E333>Thank goodness for sugar and milk!",
                              "Je trouve toujours le thé vert beaucoup trop amer, cela dit.<E003 12>\r\n<E333>Heureusement qu'il y a le lait et le sucre !");
                s = s.Replace("Mr Sholmes certainly wasn't expecting the acrid taste that\r\none time.",
                              "Mr Holmes ne s'attendait franchement pas à ce goût âcre la\r\npremière fois.");
                s = s.Replace("I've never heard anyone let out a scream like that before.<E003 10>\r\nOr seen anyone fall down the stairs quite like that either.",
                              "Je n'avais jamais entendu un cri pareil auparavant.<E003 10>\r\nNi vu quiconque dégringoler les escaliers de cette manière.");
                s = s.Replace("...It always brings a smile to my lips when I'm feeling a\r\nlittle down.",
                              "... Ça me redonne toujours le sourire quand j'ai un coup de mou.");
                s = s.Replace("Ah well, <E049><E003 8>do you know what that reminds me of?",
                              "Ah tiens, <E049><E003 8>tu sais à quoi ça me fait penser ?");
                s = s.Replace("The day I gave you some black coffee when you weren't\r\nexpecting it.",
                              "Le jour où je t'ai servi du café noir sans prévenir.");
                s = s.Replace("You fell all the way down the stairs as well, <E049><E003 8>didn't you,\r\nRuno?",
                              "Tu as dévalé tout l'escalier toi aussi, <E049><E003 8>n'est-ce pas,\r\nNicky ?");
                s = s.Replace("...Yes, <E003 8><E025 2>do you think we could try to forget that, please,\r\nIris?<E003 8> That doesn't bring a smile to my lips at all.",
                              "... Oui, <E003 8><E025 2>penses-tu qu'on pourrait oublier cet épisode, s'il te plaît,\r\nIris ?<E003 8> Ça ne me fait pas sourire du tout.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Look at the prawns and the anemones<E003 4> gently swaying\r\naround in the tank.",
                              "Regarde les crevettes et les anémones<E003 4> qui ondulent doucement\r\ndans l'aquarium.");
                s = s.Replace("Regular cleaning,<E003 6> some food<E003 6> and fresh seawater is all they\r\nneed.<E003 8> And some conversation,<E003 4> of course.",
                              "Un nettoyage régulier,<E003 6> de la nourriture<E003 6> et de l'eau de mer fraîche,\r\nc'est tout ce qu'il leur faut.<E003 8> Et un peu de conversation,<E003 4> bien sûr.");
                s = s.Replace("It seemed like a lot of effort at first,<E003 6> but it was worth it.<E003 10>\r\nI'm starting to be able to tell what they're thinking.",
                              "Ça me paraissait laborieux au début,<E003 6> mais ça en valait la peine.<E003 10>\r\nJe commence à deviner ce qu'elles pensent.");
                s = s.Replace("Funny to think that so many people in London had\r\naquariums like this once.<E003 8> When they were in vogue.",
                              "C'est drôle de penser qu'autrefois, tant de gens à Londres avaient\r\nde tels aquariums.<E003 8> Quand c'était la grande mode.");
                s = s.Replace("You'd never expect to find sea anemones in the middle of\r\nthe capital!<E003 14> <E025 3>I think I'll have to name them soon...",
                              "On ne s'attendrait jamais à trouver des anémones de mer en plein cœur\r\nde la capitale !<E003 14> <E025 3>Il va falloir que je leur donne des noms...");
                s = s.Replace("Oh no!<E049><E003 10> Runo's disappeared!",
                              "Oh non !<E049><E003 10> Nicky a disparu !");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("Ah...<E003 8><E025 2>I expect he's been eaten by Hurley...",
                              "Ah...<E003 8><E025 2> j'imagine qu'il a été dévoré par Sherlockinou...");
                s = s.Replace("...I think I'd prefer it if you used your imagination more\r\nwhen naming the sea life...",
                              "... J'aimerais que tu fasses preuve d'un peu plus d'imagination\r\npour nommer tes bestioles marines...");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I never did see what Susato-san's room looks like.", "Je n'ai jamais pu voir à quoi ressemble la chambre de Susato-san.");
                s = s.Replace("I never did see what Miss Susato's room looks like.", "Je n'ai jamais pu voir à quoi ressemble la chambre de Mlle Susato.");
                s = s.Replace("I could go in now, of course.<E003 10> <E025 3><E330>But I don't dare.",
                              "Je pourrais y entrer maintenant, bien sûr.<E003 10> <E025 3><E330>Mais je n'ose pas.");
                s = s.Replace("They say a young maiden's private chamber<E003 8> <E333>is a place of\r\nbitter-sweet secrets.",
                              "On dit que la chambre d'une jeune fille<E003 8> <E333>renferme des secrets\r\ndoux-amers.");
                s = s.Replace("Although from the laughter I used to hear when Iris\r\nwould visit,<E003 6> I imagine it's mainly sweet.",
                              "Quoique vu les éclats de rire quand Iris lui rendait visite,<E003 6>\r\nj'imagine que c'est surtout très doux.");
                s = s.Replace("Although from the laughter I used to hear when you\r\nwould visit,<E003 6> I imagine it's mainly sweet.",
                              "Quoique vu les éclats de rire quand tu lui rendais visite,<E003 6>\r\nj'imagine que c'est surtout très doux.");
                s = s.Replace("Oh, <E049><E003 8><E025 1>we used to have such fun in Susie's room!",
                              "Oh, <E049><E003 8><E025 1>on s'amusait tellement dans la chambre de Susato !");
                s = s.Replace("She told me all sorts of interesting things about your\r\ncountry, <E049><E003 6>you know.",
                              "Elle me racontait tout un tas de choses passionnantes sur votre\r\npays, <E049><E003 6>tu sais.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0206_0_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("The photograph of us<E003 4> all together that day...",
                              "La photographie de nous tous<E003 4> réunis ce jour-là...");
                s = s.Replace("It makes me a little sad to look at it now,<E003 6> which is why I'd\r\ntaken to lying it flat.",
                              "Ça me rendait un peu triste de la regarder, c'est pour cela que je\r\nl'avais posée à plat.");
                s = s.Replace("But Mr Sholmes righted it every single time.<E003 8>\r\n<E025 3>And I've grown accustomed to it.",
                              "Mais Mr Holmes la relevait à chaque fois.<E003 8>\r\n<E025 3>Et j'ai fini par m'y habituer.");
                s = s.Replace("...I hope we'll all be together again like that<E003 6> one day soon.",
                              "... J'espère que nous serons de nouveau réunis comme ça<E003 6> très bientôt.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("I left your desk completely untouched, Miss Susato.<E003 8>\r\nSo it would be ready for you whenever you returned.",
                              "J'ai laissé votre bureau absolument intact, Mlle Susato.<E003 8>\r\nPour qu'il soit prêt à votre retour.");
                s = s.Replace("It's beautifully clean.<E049><E003 8>\r\n<E145 3 65><E003 10><E025 2><E333>There isn't a speck of dust on it anywhere.",
                              "Il est parfaitement propre.<E049><E003 8>\r\n<E145 3 65><E003 10><E025 2><E333>Il n'y a pas un seul grain de poussière.");
                s = s.Replace("You've been cleaning in my absence, Mr Naruhodo?<E049><E003 12>\r\nWhatever next!",
                              "Vous avez fait le ménage pendant mon absence, Mr Naruhodo ?<E049><E003 12>\r\nTout arrive !");
                s = s.Replace("Well,<E003 8> <E025 2>I couldn't allow my great assistant's desk to sit there\r\ngathering dust,<E003 4> could I?",
                              "Eh bien,<E003 8> <E025 2>je ne pouvais pas laisser le bureau de ma précieuse\r\nassistante prendre la poussière,<E003 4> n'est-ce pas ?");
                s = s.Replace("It really is exactly as it was when I left.<E049><E003 14>\r\n<E025 2><E346>I'm so touched!",
                              "Il est exactement comme le jour de mon départ.<E049><E003 14>\r\n<E025 2><E346>Je suis très touchée !");
                s = s.Replace("But sadly...", "Mais hélas...");
                s = s.Replace("...your desk is also exactly as it was, too.",
                              "... votre bureau est également dans le même état.");
                s = s.Replace("Well,<E003 10> <E025 2>that's how it should be, after all!",
                              "Eh bien,<E003 10> <E025 2>c'est comme cela qu'il doit être, après tout !");
                s = s.Replace("Oh dear...<E003 12>I'd forgotten how that clean-cut smile<E003 4> can be\r\nso disarming.",
                              "Mon Dieu...<E003 12> j'avais oublié à quel point ce sourire candide<E003 4>\r\npouvait être désarmant.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("You see?<E003 10> <E333>I've been keeping my desk beautifully covered\r\nin papers as always.",
                              "Vous voyez ?<E003 10> <E333>J'ai conservé mon bureau artistiquement jonché\r\nde documents comme toujours.");
                s = s.Replace("You really must tidy it all up,<E003 4> Mr Naruhodo.<E049><E003 10>\r\n<E025 3>No more excuses.",
                              "Vous devez absolument ranger tout cela,<E003 4> Mr Naruhodo.<E049><E003 10>\r\n<E025 3>Plus d'excuses.");
                s = s.Replace("But Miss Susato,<E003 8> <E025 3>the way I see it...",
                              "Mais Mlle Susato,<E003 8> <E025 3>de mon point de vue...");
                s = s.Replace("...all these papers building up on my desk like this<E003 4> are a\r\nreminder of my wonderfully diverse daily life.",
                              "... tous ces dossiers accumulés sur ma table<E003 4> sont le reflet de\r\nma vie quotidienne passionnante et variée.");
                s = s.Replace("I like to leave them as they are<E003 6> so I never forget how\r\nlucky I am to have such varied experiences.",
                              "J'aime les laisser ainsi<E003 6> pour ne jamais oublier la chance que j'ai\r\nde vivre de telles aventures.");
                s = s.Replace("In that case,<E049><E003 12> <E164 3 83 1 2 7 0 0 1><E139 3><E025 2>you should definitely have a thorough tidy.",
                              "Dans ce cas,<E049><E003 12> <E164 3 83 1 2 7 0 0 1><E139 3><E025 2>vous devriez faire un grand rangement de fond en comble.");
                s = s.Replace("Then you'll be able to see your papers building up all\r\nover again<E003 6> and feel that joy renewed.",
                              "Comme cela, vous aurez le plaisir de voir vos dossiers s'accumuler\r\nà nouveau,<E003 6> et vous ressentirez cette joie décuplée.");
                s = s.Replace("(Still can't beat her in an argument.<E003 10>\r\n<E025 3>Even though I'm the lawyer here...)",
                              "(Impossible de rivaliser avec elle dans un débat d'idées.<E003 10>\r\n<E025 3>Et dire que c'est moi l'avocat...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("I see your daruma<E003 6> <E330>still has only one eye filled in.",
                              "Je vois que votre daruma<E003 6> <E330>n'a toujours qu'un seul œil de peint.");
                s = s.Replace("Well,<E003 8> we agreed that it's something we'd do together,<E003 6>\r\ndidn't we?",
                              "Eh bien,<E003 8> nous avions convenu que nous ferions cela ensemble,<E003 6>\r\nn'est-ce pas ?");
                s = s.Replace("We could do it right now if you like.<E003 8>\r\nI'd be happy with that.",
                              "Nous pourrions le faire dès maintenant si vous voulez.<E003 8>\r\nJ'en serais ravi.");
                s = s.Replace("I rather like the anticipation, I think,<E003 6> Mr Naruhodo.",
                              "Je préfère savourer l'attente, je crois,<E003 6> Mr Naruhodo.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("You have water gently boiling on the stove, I see.",
                              "Vous avez de l'eau qui frémit sur le poêle, à ce que je vois.");
                s = s.Replace("It feels wrong somehow if I can't hear the water bubbling\r\naway.",
                              "J'ai l'impression que quelque chose manque si je n'entends pas\r\nle bouillonnement de l'eau.");
                s = s.Replace("And we have plenty of logs.<E003 10> It's not like we have to worry\r\nabout paying for gas.",
                              "Et nous avons du bois en abondance.<E003 10> Pas besoin de se soucier de\r\nla facture de gaz.");
                s = s.Replace("It's important to open the window for fresh air when the\r\nfire's burning, though.",
                              "Il est essentiel d'aérer la pièce pour renouveler l'air quand le feu\r\nbrûle, cependant.");
                s = s.Replace("You can't keep it closed<E003 4> just because it's cold outside.<E049><E003 12>\r\n<E330>It could be a matter of life and death!",
                              "On ne peut pas la laisser fermée<E003 4> sous prétexte qu'il fait froid dehors.<E049><E003 12>\r\n<E330>C'est une question de vie ou de mort !");
                s = s.Replace("(Avoiding the freezing winter air is a matter of life and\r\ndeath too,<E003 6> if you ask me...)",
                              "(Éviter un coup de froid glacial est aussi une question de vie\r\nou de mort,<E003 6> si l'on me demande mon avis...)");
                s = s.Replace("Oh<E003 4> well,<E049><E003 4> <E164 3 76 1 2 6 0 0 1><E139 3>perhaps a nice cup of tea will warm you up\r\nlater.",
                              "Oh,<E003 4> eh bien,<E049><E003 4> <E164 3 76 1 2 6 0 0 1><E139 3>peut-être qu'une bonne tasse de thé vous réchauffera\r\ntout à l'heure.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("Thinking back,<E003 6> that spade's been in here since we first\r\nmoved in,<E003 6> hasn't it?",
                              "En y repensant,<E003 6> cette pelle est là depuis notre emménagement,<E003 6>\r\nn'est-ce pas ?");
                s = s.Replace("I'm sure I've told you before, Mr Naruhodo.<E003 8>\r\nIt's not a spade;<E049><E003 6> <E160 3><E139 3><E335>it's a shovel.",
                              "Je suis certaine de vous l'avoir déjà dit, Mr Naruhodo.<E003 8>\r\nCe n'est pas une pelle ;<E049><E003 6> <E160 3><E139 3><E335>c'est une bêche.");
                s = s.Replace("No,<E003 6> shovels are for digging.<E003 8>\r\nThat's for scooping up loose material.<E003 10> It's a spade.",
                              "Non,<E003 6> les bêches servent à trancher la terre.<E003 8>\r\nÇa, c'est pour ramasser des matières en vrac.<E003 10> C'est une pelle.");
                s = s.Replace("No,<E003 6> spades are for digging.<E003 8>\r\nThat's for scooping up loose material.<E049><E003 10> <E025 3><E169 3 2>It's...<E003 6>a...<E003 6>shovel.<E169 3 3>",
                              "Non,<E003 6> les pelles servent à creuser.<E003 8>\r\nÇa, c'est fait pour le déblaiement.<E049><E003 10> <E025 3><E169 3 2>C'est...<E003 6> une...<E003 6> bêche.<E169 3 3>");
                s = s.Replace("(The great spade-shovel war rages on...)",
                              "(L'éternelle guerre pelle contre bêche se poursuit...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Oh,<E003 4> I'm so looking forward to making you some tea again,\r\nMr Naruhodo.",
                              "Oh,<E003 4> j'ai tellement hâte de vous préparer du thé à nouveau,\r\nMr Naruhodo.");
                s = s.Replace("(Which you'd think I wouldn't like,<E003 6> given that I'm not keen\r\non bitter flavours.<E003 10> But it is Susato-san's tea.)",
                              "(Moi qui n'aime pas trop l'amertume en théorie...<E003 10> mais après tout,\r\nc'est le thé de Susato-san.)");
                s = s.Replace("(And it's amazing what a little cake or something on the\r\nside can do...)",
                              "(Et c'est incroyable comme une petite douceur d'accompagnement\r\npeut tout changer...)");
                s = s.Replace("I would dearly love to serve you some sort of Japanese\r\nsweet alongside your matcha green tea...",
                              "J'aimerais tant pouvoir vous servir une pâtisserie japonaise avec\r\nvotre thé matcha...");
                s = s.Replace("...but I suppose that's simply not possible given how long\r\nwe've been staying here in London.",
                              "... mais j'imagine que ce n'est guère envisageable après tout ce\r\ntemps passé ici à Londres.");
                s = s.Replace("Well...<E003 12><E145 3 64><E333><E025 2>I do like the little chocolates you put with my tea.<E003 8>\r\nThey go wonderfully.",
                              "Eh bien...<E003 12><E145 3 64><E333><E025 2> j'apprécie beaucoup les petits chocolats que vous servez.<E003 8>\r\nL'association est divine.");
                s = s.Replace("Oh, Mr Naruhodo!<E003 10> <E025 2>You would,<E003 4> wouldn't you?!",
                              "Oh, Mr Naruhodo !<E003 10> <E025 2>C'est bien votre genre,<E003 4> n'est-ce pas ?!");
                s = s.Replace("(That gives me a warm glow inside for some reason...)",
                              "(Ça me met du baume au cœur sans que je sache trop pourquoi...)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("It must be about a year ago now.", "Ça fait près d'un an maintenant.");
                s = s.Replace("I wrote a really long story<E003 4> based on some of my father's\r\nold notes.",
                              "J'ai rédigé un très long récit<E003 4> d'après les anciennes notes de mon père.");
                s = s.Replace("It's about one of Hurley's greatest exploits.<E049><E003 12>\r\nI called it<E003 8> <E025 3>‘The Hound of the Baskervilles’.",
                              "C'est sur l'un des plus grands exploits de Sherlockinou.<E049><E003 12>\r\nJe l'ai intitulé<E003 8> <E025 3>« Le Chien des Baskerville ».");
                s = s.Replace("...But then<E003 8> <E025 2>Mr Sholmes forbade you from publishing it...",
                              "... Mais ensuite,<E003 8> <E025 2>Mr Holmes t'a formellement interdit de le publier...");
                s = s.Replace("...and put the manuscript somewhere nobody could get<E145 4 64>\r\ntheir hands on it.",
                              "... et a caché le manuscrit dans un endroit introuvable.<E145 4 64>");
                s = s.Replace("So nobody knows anything about it,<E003 8> <E025 3>apart from Hurley\r\nand I.",
                              "Si bien que personne n'en sait rien,<E003 8> <E025 3>à part Sherlockinou et moi.");
                s = s.Replace("But for some reason...", "Mais curieusement...");
                s = s.Replace("...you knew the title of it,<E003 8> didn't you, Susie?",
                              "... tu en connaissais le titre,<E003 8> n'est-ce pas, Susato ?");
                s = s.Replace("Oh,<E003 6> it sounds so exciting!<E049><E003 10> ‘The Hound of the Baskervilles’!<E049><E003 12>\r\nI should love to read it!",
                              "Oh,<E003 6> ça a l'air palpitant !<E049><E003 10> « Le Chien des Baskerville » !<E049><E003 12>\r\nJ'adorerais pouvoir le lire !");
                s = s.Replace("And you wouldn't tell me...<E049><E003 12>how you'd come to know it.",
                              "Et tu n'as pas voulu me révéler...<E049><E003 12> comment tu l'avais appris.");
                s = s.Replace("...Yes.<E003 12> <E025 2>But I made you a promise that I would explain one\r\nday,<E003 6> didn't I?",
                              "... Oui.<E003 12> <E025 2>Mais je t'ai fait la promesse de tout t'expliquer un\r\njour,<E003 6> n'est-ce pas ?");
                s = s.Replace("I think it's time.", "Je crois que le moment est venu.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("I'm only sorry I've had to keep it from you for so long,<E003 10>\r\nIris.",
                              "Je suis seulement désolée d'avoir dû te le cacher si longtemps,<E003 10>\r\nIris.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I'm so pleased to see all our sea creatures doing so well in\r\nthe aquarium.",
                              "Je suis si heureuse de voir toutes nos créatures marines si vives\r\ndans cet aquarium.");
                s = s.Replace("Yes,<E003 6> the prawns are still swimming<E003 4> and the anemones are\r\nstill swaying.",
                              "Oui,<E003 6> les crevettes nagent toujours<E003 4> et les anémones se balancent.");
                s = s.Replace("Obviously,<E003 6> I've been looking after them carefully.",
                              "Évidemment,<E003 6> j'en ai pris grand soin.");
                s = s.Replace("At first,<E003 8> <E145 3 77><E330>I used to drool whenever I looked at those juicy\r\nprawns,<E003 6> but not any more.",
                              "Au début,<E003 8> <E145 3 77><E330>je salivais en voyant ces crevettes si charnues,<E003 6>\r\nmais plus maintenant.");
                s = s.Replace("They're like part of the family now.", "Elles font partie de la famille désormais.");
                s = s.Replace("...I don't suppose they'll ever know<E003 8> how close they were\r\nto meeting their maker.",
                              "... J'imagine qu'elles ne sauront jamais<E003 8> à quel point elles ont\r\nfrôlé la casserole.");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("Your room through there<E003 4> should be exactly as you left it.",
                              "Votre chambre par là<E003 4> doit être restée exactement comme vous l'avez laissée.");
                s = s.Replace("I've still never been inside.<E003 8> I've never been invited.",
                              "Je n'y suis jamais entré.<E003 8> Je n'ai jamais été invité.");
                s = s.Replace("Of course not.<E049><E003 4> <E145 3 65><E003 10><E333>Only Iris is allowed in my room.",
                              "Bien sûr que non.<E049><E003 4> <E145 3 65><E003 10><E333>Seule Iris a l'autorisation d'y pénétrer.");
                s = s.Replace("(No doubt I'll be hearing you two giggling away in there\r\nagain, then.)",
                              "(Sans nul doute que je vais vous réentendre glousser de rire\r\nlà-dedans, alors.)");
                return s;
            };

            // BB\script\output\_sce02_bg0206_1_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0206_1_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("That was taken when I left London, wasn't it?",
                              "Cette photo a été prise quand j'ai quitté Londres, n'est-ce pas ?");
                s = s.Replace("I have the<E139 3> same photograph on display in my room at\r\nhome in Japan, you know!",
                              "J'ai la<E139 3> même photo exposée dans ma chambre au Japon, vous savez !");
                s = s.Replace("I wondered if we'd ever all be together again,<E003 8> <E025 2>to be\r\nhonest.",
                              "Je me demandais si nous serions un jour réunis,<E003 8> <E025 2>pour être franc.");
                s = s.Replace("Oh,<E003 8> I know...<E003 12> So did I.",
                              "Oh,<E003 8> je sais...<E003 12> Moi aussi.");
                s = s.Replace("But here we are!<E049><E003 12> <E333>And I'm quite sure there's a reason\r\nwe've been brought back together.",
                              "Mais nous y voilà !<E049><E003 12> <E333>Et je suis convaincue qu'une bonne raison\r\nnous a rassemblés de nouveau.");
                s = s.Replace("(I can't deny that having Susato-san back again...)",
                              "(Je ne peux nier qu'avoir Susato-san de retour...)");
                s = s.Replace("(...makes me feel as though fate has something big in store\r\nfor us...)",
                              "(... me donne le sentiment que le destin nous réserve de grandes choses...)");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("These stairs obviously lead to the stage above.", "Ces escaliers mènent de toute évidence à l'estrade.");
                s = s.Replace("We should go up there and investigate the exact spot\r\nwhere the experiment was being conducted...",
                              "Nous devrions monter là-haut et examiner l'endroit exact\r\noù l'expérience s'est déroulée...");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("...Ah, <E003 8><E025 2>it looks as though somebody dropped something\r\nbehind the tree just here...",
                              "... Ah, <E003 8><E025 2>on dirait que quelqu'un a laissé tomber quelque chose\r\nderrière cet arbre...");
                s = s.Replace("Dropped...<E145 110 70><E003 10>or hid?", "Laissé tomber...<E145 110 70><E003 10> ou caché ?");
                s = s.Replace("What is this?<E003 12>\r\n<E025 2>Some part of the machine that exploded?",
                              "Qu'est-ce que c'est ?<E003 12>\r\n<E025 2>Une pièce de la machine qui a explosé ?");
                s = s.Replace("Maybe.<E049><E003 12> It could have fallen from the platform above in\r\nthe blast, perhaps.",
                              "Peut-être.<E049><E003 12> Elle est sans doute tombée de l'estrade avec\r\nle souffle de l'explosion.");
                s = s.Replace("Wot's goin' on 'ere?", "Qu'est-ce qui s'passe par là ?");
                s = s.Replace("Oh!<E003 14> <E025 1><E335>Nothing.", "Oh !<E003 14> <E025 1><E335>Rien du tout !");
                s = s.Replace("(I think I'll hang on to this, <E003 6>just in case...)",
                              "(Je ferais bien de garder ça sur moi, <E003 6>au cas où...)");
                s = s.Replace("The mysterious contraption has been\r\nentered into the Court Record.",
                              "L'étrange mécanisme a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("Oh look, <E003 8>what's this?<E049><E003 12>\r\n<E333>A ripped piece of cloth...",
                              "Oh, regarde ! <E003 8>Qu'est-ce que c'est ?<E049><E003 12>\r\n<E333>Un morceau d'étoffe déchirée...");
                s = s.Replace("Hm, <E003 10><E025 2>it's not like any fabric I've ever seen before.",
                              "Hmm, <E003 10><E025 2>ce n'est pas un tissu ordinaire.");
                s = s.Replace("(It's very thick and stiff.<E003 10>\r\n<E025 3>It looks extremely durable...)",
                              "(C'est très épais et rigide.<E003 10>\r\n<E025 3>Ça a l'air extrêmement résistant...)");
                s = s.Replace("It's canvas, I think.<E003 10>\r\n<E025 3>With some sort of rubber backing.",
                              "C'est de la toile, je pense.<E003 10>\r\n<E025 3>Avec une sorte de renfort en caoutchouc.");
                s = s.Replace("And the edges appear to be a bit charred as well.",
                              "Et les bords semblent également roussis par le feu.");
                s = s.Replace("(Maybe that means it had something to do with the\r\nexplosion...)",
                              "(Ça a sans doute un rapport direct avec l'explosion...)");
                s = s.Replace("Let's make a note of it while Ginny's mid-yawn!",
                              "Prenons-le discrètement pendant que Gina bâille aux corneilles !");
                s = s.Replace("The piece of green cloth has been\r\nentered into the Court Record.",
                              "Le morceau de tissu vert a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("That's where the cove ended up after 'is ‘instant kinesis’\r\nor wotever they call it.<E003 10> <E025 3>Dead, <E003 8>o' course.",
                              "C'est là qu'le lascar a atterri après sa « cinèse instantanée »\r\nou j'sais pas trop quoi.<E003 10> <E025 3>Mort, <E003 8>évidemment.");
                s = s.Replace("And yet they're calling the experiment a success?",
                              "Et pourtant ils qualifient l'expérience de succès ?");
                s = s.Replace("What's the wooden scaffold there for?", "À quoi sert l'échafaudage en bois là-bas ?");
                s = s.Replace("The coppers –<E003 6> our lads – set that up after the incident\r\n'appened.",
                              "Les flics...<E003 6> nos gars l'ont monté après que l'drame s'est produit.");
                s = s.Replace("To get the body down, I think.<E003 10>\r\nDunno, really...",
                              "Pour descendre le macchabée, j'suppose.<E003 10>\r\nJ'sais pas trop...");
                s = s.Replace("Didn't you help to erect the scaffold, then?",
                              "Tu n'as pas aidé à monter l'échafaudage, alors ?");
                s = s.Replace("Nah, <E049><E003 12>lookout duty's more my thing.<E049><E003 10> Wanderin' round the\r\nexhibition an' keepin' a ‘lookout’ for the fun stuff.",
                              "Nan, <E049><E003 12>la garde c'est plus mon truc.<E049><E003 10> J'me balade dans l'exposition\r\nen guettant les trucs marrants.");
                s = s.Replace("...Mind Gregson doesn't hear you saying that, <E003 8><E025 2>or he'll give\r\nyou the boot.",
                              "... Évite que Gregson t'entende dire ça, <E003 8><E025 2>ou il va te botter les fesses.");
                s = s.Replace("(It's incredible though, <E003 6>isn't it?)",
                              "(C'est invraisemblable tout de même, <E003 6>non ?)");
                s = s.Replace("(I mean...<E003 8>could the victim really have bridged that gap by\r\nsome sort of invisible kinesis<E025 7>...<E025 3>?)",
                              "(Je veux dire...<E003 8> la victime a-t-elle réellement franchi cette\r\ndistance par une téléportation invisible<E025 7>...<E025 3> ?)");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("This platform must have been set up for the experiment,\r\nI suppose.<E003 8> It's very high up.",
                              "Cette plateforme a dû être montée pour l'expérience, j'imagine.<E003 8>\r\nElle est drôlement haute.");
                s = s.Replace("About thirty feet above the ground, apparently.<E049><E003 10>\r\nThat's what a policeman I just spoke to said.",
                              "À environ trente pieds de haut, paraît-il.<E049><E003 10>\r\nC'est ce que vient de me dire un agent de police.");
                s = s.Replace("I don't really understand ‘feet’ very well.<E003 12>\r\n<E025 2>We don't use them in Japan.",
                              "Je n'ai pas trop l'habitude de compter en « pieds ».<E003 12>\r\n<E025 2>Nous n'utilisons pas cette unité au Japon.");
                s = s.Replace("Oh yes, <E003 4>sorry.<E049><E003 10> <E025 2>It's about nine metres.",
                              "Ah oui, <E003 4>pardon !<E049><E003 10> <E025 2>Ça fait environ neuf mètres.");
                s = s.Replace("But soon you'll have been in London a year, Runo.<E049>\r\n<E025 1><E164 110 70 1 2 1 0 1 1><E139 110>It's time you got used to our measurements.",
                              "Mais ça va bientôt faire un an que tu es à Londres, Nicky.<E049>\r\n<E025 1><E164 110 70 1 2 1 0 1 1><E139 110>Il serait temps de te faire à nos unités de mesure !");
                s = s.Replace("Yes, <E003 8>well...", "Oui, <E003 8>bon...");
                s = s.Replace("This thing is so tall, <E003 6>the spectators at the front <E145 110 64>would just\r\nhave seen a wall and nothing else!",
                              "Cette estrade est si haute que les spectateurs au premier rang<E145 110 64>\r\nn'auraient vu qu'un mur en bois et rien d'autre !");
                s = s.Replace("They probably thought they'd secured the best spot to\r\nwatch from, <E049><E003 6>only to be disappointed...",
                              "Ils pensaient sans doute avoir les meilleures places pour observer,<E049><E003 6>\r\npour finalement n'y rien voir...");
                s = s.Replace("There's a saying in Japan:<E003 12> <E025 3><E333>the darkest spot is right under\r\nthe lighthouse.",
                              "Il y a un proverbe au Japon :<E003 12> <E025 3><E333>c'est au pied du phare que\r\nl'obscurité est la plus dense.");
                s = s.Replace("...I feel like it probably applies here.",
                              "... J'ai comme l'impression que ça s'applique parfaitement ici.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("The Crystal Tower...<E003 12>\r\n<E025 2><E333>It's certainly an apt name.",
                              "La Tour de Cristal...<E003 12>\r\n<E025 2><E333>Le nom lui convient à merveille.");
                s = s.Replace("It was built to be the focal point of the exhibition.<E003 8> And it\r\ndefinitely is, <E003 6>being so tall and with all that glass...",
                              "Elle a été bâtie pour être le joyau de l'exposition.<E003 8> Et c'est réussi,\r\navec toute cette hauteur et ce verre scintillant...");
                s = s.Replace("I can't imagine a building like this ever being erected in\r\nJapan.",
                              "Je n'arrive pas à imaginer un tel édifice au Japon.");
                s = s.Replace("There are lots of exhibits inside the tower as well,\r\napparently.",
                              "Il y a une multitude d'expositions à l'intérieur, paraît-il.");
                s = s.Replace("Of course there's an observation deck, <E049><E003 6><E341>but there's also an\r\nart gallery, <E049><E003 8>a zoo <E049><E003 8>and a museum!",
                              "Il y a bien sûr la plateforme panoramique, <E049><E003 6><E341>mais aussi une galerie\r\nd'art, <E049><E003 8>un zoo <E049><E003 8>et un musée !");
                s = s.Replace("But I heard you have to queue for three hours just to get\r\nthrough the doors!",
                              "Mais j'ai entendu dire qu'il faut faire trois heures de queue rien\r\nque pour franchir les portes !");
                s = s.Replace("Well, <E003 8><E025 2>at the moment, <E003 6>the shattered glass from the failed\r\nexperiment may well be the biggest draw.",
                              "Eh bien, <E003 8><E025 2>en ce moment, <E003 6>le verre brisé de l'accident est peut-être\r\nla plus grande attraction.");
                s = s.Replace("And thanks to that accident, <E049><E003 6>the whole tower is shut.",
                              "Et à cause de ça, <E049><E003 6>toute la tour est fermée au public.");
                s = s.Replace("Suddenly it's not the Crystal Tower any more,<E003 8> <E025 3><E341>but the\r\nCrystal Glass Shower...",
                              "Ce n'est plus la Tour de Cristal,<E003 8> <E025 3><E341>mais la Douche de Verre de Cristal...");
                s = s.Replace("Apparently everyone's taking to the skies now to look\r\ndown on the disaster area from above instead.",
                              "Apparemment tout le monde monte en l'air pour observer le site du\r\ndésastre depuis le ciel.");
                s = s.Replace("But there's a three-hour queue to go up in a balloon now.",
                              "Mais il y a trois heures d'attente pour monter en montgolfière maintenant !");
                s = s.Replace("...Londoners must be very patient people.",
                              "... Les Londoniens doivent être d'un naturel très patient.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("I've been meaning to ask you for a while now, <E003 10><E025 3>but what\r\nare those funny round blobs floating in the sky?",
                              "Ça fait un moment que je voulais te demander, <E003 10><E025 3>mais que sont\r\nces drôles de grosses bulles qui flottent dans le ciel ?");
                s = s.Replace("Oh, <E003 10><E025 2><E333>they're the flying balloons I've been talking about.<E003 10>\r\n<E025 1>I want to go up in one sooo much!",
                              "Oh, <E003 10><E025 2><E333>ce sont les ballons captifs dont je t'ai parlé !<E003 10>\r\n<E025 1>J'ai trop envie de faire un tour dedans !");
                s = s.Replace("...I've, <E003 8><E342>I've read about situations like this in a magazine\r\nabout strange phenomena.",
                              "... J'ai, <E003 8><E342>j'ai lu des articles là-dessus dans une revue sur\r\nles phénomènes paranormaux.");
                s = s.Replace("C-<E003 10>Creatures from outer space c-<E003 8><E342>coming in round, flying\r\nobjects...<E003 10><E239><E342>t-<E003 8>t-<E003 6><E025 1>to attack Earth!",
                              "Des c-<E003 10>créatures de l'espace ar-<E003 8><E342>arrivant dans des objets\r\nvolants ronds...<E003 10><E239><E342> p-<E003 8>p-<E003 6><E025 1>pour envahir la Terre !");
                s = s.Replace("I, <E003 8>I suppose inhabitants of <E342>o-<E003 8>other planets are <E342>b-<E003 8>bound to\r\nbe interested in the <E342>G-<E003 8>Great Exhibition...",
                              "J-Je suppose que les créatures des <E342>a-<E003 8>autres planètes sont <E342>f-<E003 8>forcément\r\nintriguées par l'<E342>E-<E003 8>Exposition Universelle...");
                s = s.Replace("This is it, Iris!<E003 15> <E025 1><E346>It's happening!",
                              "C'est la fin, Iris !<E003 15> <E025 1><E346>L'invasion a commencé !");
                s = s.Replace("...It's not, <E003 6>don't worry.<E003 8> <E025 2>I'll explain it all to you later over a\r\nnice cup of tea, Runo.",
                              "... Pas du tout, <E003 6>ne t'en fais pas.<E003 8> <E025 2>Je t'expliquerai tout à l'heure\r\nautour d'une bonne tasse de thé, Nicky.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_0_check_eng#10
            entryTranslators["BB\\script\\output\\_sce02_bg0303_0_check_eng#10"] = en => {
                string s = en;
                s = s.Replace("For some reason <E003 6>the ground is damaged in this spot, <E003 8>look.",
                              "Pour une raison étrange, <E003 6>le sol est abîmé ici, <E003 8>regarde.");
                s = s.Replace("...Almost as if there was a fire here or something.",
                              "... C'est presque comme s'il y avait eu un incendie ici.");
                s = s.Replace("Yes, <E003 8><E025 2>if you look closely, <E003 6><E338><E341>there's some scattered ash and\r\nburnt embers, too...",
                              "Oui, <E003 8><E025 2>en regardant bien, <E003 6><E338><E341>il y a des cendres éparpillées\r\net des résidus carbonisés...");
                s = s.Replace("Well, <E003 8><E025 2>I suppose there was a big explosion just above here.",
                              "Eh bien, <E003 8><E025 2>j'imagine qu'il y a eu une violente explosion juste au-dessus.");
                s = s.Replace("People probably wouldn't bat an eyelid at a small fire like\r\nthis would have been.",
                              "Les gens n'ont probablement pas prêté attention à un petit départ\r\nde feu comme celui-ci.");
                s = s.Replace("...I'm not sure we English are quite that laid-back, <E003 4>Runo.",
                              "... Je ne suis pas sûre que les Anglais soient si insouciants que ça, <E003 4>Nicky.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("Oi!<E003 16> <E025 1><E346>That's off limits up there!",
                              "Hé !<E003 16> <E025 1><E346>Accès interdit là-haut !");
                s = s.Replace("Try to sneak past me again,<E049><E003 8> <E025 1><E332>an' I'll stuff yer gob full o' the\r\nboss's fish an' chips!",
                              "Essaie encore de passer en loucedé,<E049><E003 8> <E025 1><E332>et j'te bourre la panse\r\navec le fish and chips du patron !");
                s = s.Replace("(Yes please.<E003 8> I love fish and chips.)",
                              "(Avec plaisir.<E003 8> J'adore le fish and chips.)");
                s = s.Replace("I suppose we need special permission...",
                              "J'imagine qu'il nous faut une permission spéciale...");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#3
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#3"] = en => {
                string s = en;
                s = s.Replace("These stairs lead up to the experimentation stage.<E003 8>\r\n...Let's go and see what we can find out.",
                              "Ces marches mènent à l'estrade de l'expérience.<E003 8>\r\n... Allons voir ce que nous pouvons découvrir.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#4
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#4"] = en => {
                string s = en;
                s = s.Replace("We'd better not try going up those stairs to the stage area\r\nnow.",
                              "Mieux vaut ne pas tenter de monter ces marches vers l'estrade\r\npour l'instant.");
                s = s.Replace("If we were to bump into the Forensic Investigation Team,<E003 6>\r\nit sounds like it could make trouble.",
                              "Si nous tombions nez à nez avec la police scientifique,<E003 6>\r\ncela risquerait de nous attirer des ennuis.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#5
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#5"] = en => {
                string s = en;
                s = s.Replace("What a shame that the symbolic landmark of the Great\r\nExhibition has been damaged like that.",
                              "Quel dommage que le monument emblématique de l'Exposition\r\nUniverselle ait été endommagé de la sorte.");
                s = s.Replace("Yes,<E003 4> unfortunately<E003 6> <E025 2><E330>the birdcage crashed in the most\r\nprominent position possible.",
                              "Oui,<E003 4> hélas,<E003 6> <E025 2><E330>la cage d'oiseau s'est écrasée à l'endroit le plus\r\nvisible qui soit.");
                s = s.Replace("It's the gods giving us a warning,<E003 4> if you ask me:",
                              "C'est un avertissement des dieux,<E003 4> si vous voulez mon avis :");
                s = s.Replace("‘Man must travel under his own steam, <E003 6>and not cut\r\ncorners with instantaneous kinesis.’",
                              "« L'homme doit voyager par ses propres moyens, <E003 6>et non par des\r\nraccourcis comme la cinèse instantanée. »");
                s = s.Replace("But imagine what might have happened<E003 4> if the birdcage\r\nhad landed in a slightly different location.",
                              "Mais imaginez ce qui aurait pu se passer<E003 4> si la cage avait atterri\r\nquelques mètres plus loin.");
                s = s.Replace("The death toll could have been far worse.",
                              "Le bilan aurait pu être bien plus tragique.");
                s = s.Replace("So I think perhaps<E003 8> <E333>it was a blessing in disguise.",
                              "Alors je me dis que<E003 8> <E333>c'était peut-être un mal pour un bien.");
                s = s.Replace("Well,<E003 10> <E025 2><E043>the gods are <E006>benevolent<E005>,<E003 4> obviously.<E003 8>\r\nI did say it was just a warning.",
                              "Eh bien,<E003 10> <E025 2><E043>les dieux sont <E006>bienveillants<E005>,<E003 4> naturellement.<E003 8>\r\nJe vous ai bien dit que ce n'était qu'un avertissement.");
                s = s.Replace("‘Man must travel under his own steam,<E003 6> or next time<E003 8>\r\nbirdcages will rain down on all of you.’",
                              "« L'homme doit marcher par lui-même,<E003 6> sinon la prochaine fois,<E003 8>\r\nil pleuvra des cages d'oiseau sur vos têtes ! »");
                s = s.Replace("...Your faith is much stronger than I realised.",
                              "... Votre foi est bien plus ardente que je ne le pensais.");
                s = s.Replace("Well,<E003 6> how do you think I passed the entrance exam for\r\nYumei University?<E003 10> <E341>It wasn't by studying alone!",
                              "Eh bien,<E003 6> comment croyez-vous que j'aie réussi le concours\r\nde l'université Yumei ?<E003 10> <E341>Pas seulement en révisant !");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#6
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#6"] = en => {
                string s = en;
                s = s.Replace("The stage up there is where the experiment was set up.<E003 10>\r\nIt's very high,<E003 4> isn't it?",
                              "C'est sur l'estrade là-haut que l'expérience avait lieu.<E003 10>\r\nC'est vraiment très haut,<E003 4> vous ne trouvez pas ?");
                s = s.Replace("About thirty feet, I believe.<E003 8> <E025 2>Or nine metres, if you prefer.",
                              "Environ trente pieds, je crois.<E003 8> <E025 2>Ou neuf mètres, si vous préférez.");
                s = s.Replace("Craning your neck to see up to it<E003 6> starts to hurt after a\r\nwhile, doesn't it?",
                              "Se tordre le cou pour regarder là-haut<E003 6> finit par faire mal à la longue,\r\nn'est-ce pas ?");
                s = s.Replace("Yes,<E003 4> we need to get up there and look around properly.",
                              "Oui,<E003 4> il faut qu'on monte là-haut pour examiner les lieux.");
                s = s.Replace("Although if I'm honest,<E003 10> <E333>climbing all those stairs makes my\r\nchest hurt.",
                              "Même si à vrai dire,<E003 10> <E333>grimper toutes ces marches me fait un point\r\nde côté.");
                s = s.Replace("Oh dear...<E049><E003 6> <E147 3 84><E117 3 25><E003 10><E330>I think perhaps you should exercise more,\r\nMr Naruhodo.",
                              "Mon Dieu...<E049><E003 6> <E147 3 84><E117 3 25><E003 10><E330>Je crains que vous ne devriez faire un peu plus\r\nd'exercice, Mr Naruhodo.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#7
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#7"] = en => {
                string s = en;
                s = s.Replace("Ah,<E003 10> <E333>the Crystal Tower...", "Ah,<E003 10> <E333>la Tour de Cristal...");
                s = s.Replace("I can't believe I'm seeing it at such close proximity<E049><E003 10> <E346><E025 2>with\r\nmy own eyes!",
                              "Je n'arrive pas à croire que je la contemple de si près,<E049><E003 10> <E346><E025 2>de mes\r\npropres yeux !");
                s = s.Replace("You've really been looking forward to the Great<E145 3 64>\r\nExhibition, haven't you,<E003 4> Miss Susato?",
                              "Vous aviez vraiment hâte de visiter cette Exposition<E145 3 64>\r\nUniverselle, n'est-ce pas,<E003 4> Mlle Susato ?");
                s = s.Replace("Oh yes!<E003 12> <E025 2>When I found out that I had to return to Japan,<E003 4>\r\nI'm afraid I cursed my luck.",
                              "Oh, oui !<E003 12> <E025 2>Quand j'ai appris mon rappel immédiat au Japon,<E003 4>\r\nj'ai bien peur d'avoir maudit mon sort.");
                s = s.Replace("But here you are,<E003 6> back in London,<E145 3 64><E003 8> gazing up at the\r\nmagnificent tower.",
                              "Mais vous voilà de retour à Londres,<E145 3 64><E003 8> admirant cette\r\nsomptueuse tour.");
                s = s.Replace("I know.<E049><E003 6> <E025 2><E164 3 76 1 2 6 0 1 1><E139 3>...Perhaps I was wrong to curse my luck so\r\nharshly.",
                              "Je sais.<E049><E003 6> <E025 2><E164 3 76 1 2 6 0 1 1><E139 3>... Peut-être ai-je eu tort de maudire mon sort avec\r\ntant d'amertume.");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#8
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#8"] = en => {
                string s = en;
                s = s.Replace("Oh look!<E003 10> A flying balloon!<E003 12> I've never seen one in the flesh\r\nbefore!",
                              "Regardez !<E003 10> Une montgolfière !<E003 12> Je n'en avais jamais vu en vrai !");
                s = s.Replace("I can't understand how they can fly...<E003 10><E330>and so high up as\r\nwell.",
                              "Je ne comprends pas comment elles peuvent voler...<E003 10><E330> et si haut\r\nen plus.");
                s = s.Replace("Oh, but think of the view, Mr Naruhodo!<E003 12>\r\nYou must be able to see for miles and miles.",
                              "Oh, mais imaginez la vue, Mr Naruhodo !<E003 12>\r\nOn doit pouvoir admirer le paysage à des lieues à la ronde !");
                s = s.Replace("I do think of it.<E003 8> And it terrifies me.<E003 14>\r\nI mean,<E003 4> it would be certain death if you fell out.",
                              "J'y pense, oui.<E003 8> Et ça me terrifie.<E003 14>\r\nJe veux dire,<E003 4> c'est la mort assurée si on en tombe.");
                s = s.Replace("I'm sure they're perfectly safe.<E003 12> After all,<E003 6> they've been\r\ninvented by some of the brightest minds in the world.",
                              "Je suis sûre qu'elles sont très sûres.<E003 12> Après tout,<E003 6> elles ont été\r\nconçues par les plus brillants esprits du monde.");
                s = s.Replace("...Let's not forget that we know at least one has exploded.",
                              "... N'oublions pas que nous savons qu'au moins l'une d'elles a explosé.");
                s = s.Replace("I'm sure...<E003 12> <E025 1><E346>I'm sure there are other ways to fly!",
                              "Je suis sûre...<E003 12> <E025 1><E346>je suis sûre qu'il existe d'autres manières de voler !");
                return s;
            };

            // BB\script\output\_sce02_bg0303_1_check_eng#9
            entryTranslators["BB\\script\\output\\_sce02_bg0303_1_check_eng#9"] = en => {
                string s = en;
                s = s.Replace("Here's the scorching on the ground that you mentioned.",
                              "Voici les brûlures sur le sol dont vous parliez.");
                s = s.Replace("Yes, and there's what's left of the green balloon's\r\nenvelope.",
                              "Oui, et voici ce qui reste de l'enveloppe du ballon vert.");
                s = s.Replace("All clear evidence of the balloon that exploded on the day\r\nof the incident.",
                              "Des preuves évidentes du ballon qui a explosé le jour du drame.");
                s = s.Replace("Poor Professor Harebrayne.<E049><E003 10> I do feel sorry for him that\r\nhis dreams have been shattered like this...",
                              "Pauvre Dr Samba Lonron.<E049><E003 10> J'ai de la peine pour lui, voir ses\r\nrêves anéantis de la sorte...");
                s = s.Replace("Someone's well and truly burst his bubble, as it were!<E003 14>\r\n<E025 2><E345><E342>Ha ha ha ha!",
                              "On peut dire que quelqu'un a crevé sa bulle, ah ah !<E003 14>\r\n<E025 2><E345><E342>Ha ha ha ha !");
                s = s.Replace("(Ouch.<E003 12> I'm a bad person...)",
                              "(Aïe.<E003 12> Je suis un monstre...)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_00_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_00_eng#11"] = en => {
                string s = en;
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("Wh-<E003 8>What on earth...?<E003 14>\r\n<E341>How can...?",
                              "Qu-...<E003 8> Qu'est-ce que c'est que ça... ?<E003 14>\r\n<E341>Comment est-ce possible... ?");
                s = s.Replace("I,<E003 8> I don't believe it!", "J-Je n'y crois pas !");
                s = s.Replace("A black monocle!)", "Un monocle noir !)");
                s = s.Replace("Mr Naruhodo!<E003 10>\r\n<E025 3>Is, <E003 10><E025 1><E331>is it possible that this man is...",
                              "Mr Naruhodo !<E003 10>\r\n<E025 3>Est... <E003 10><E025 1><E331>est-il possible que cet homme soit...");
                s = s.Replace("Yes...", "Oui...");
                s = s.Replace("It's Enoch Drebber!", "C'est Enoch Drebber !");
                s = s.Replace("The colour of his hair is different, but...",
                              "La couleur de ses cheveux est différente, mais...");
                s = s.Replace("...It's unmistakably him!", "... C'est indiscutablement lui !");
                s = s.Replace("Indeed it is.", "En effet.");
                s = s.Replace("Mr Sholmes!", "Mr Holmes !");
                s = s.Replace("This man<E049><E003 8> <E164 2 71 1 2 6 0 0 1><E118 2 1.15><E139 2><E025 2>is the subject of your present hunt,<E003 4> I believe?",
                              "Cet individu<E049><E003 8> <E164 2 71 1 2 6 0 0 1><E118 2 1.15><E139 2><E025 2>est l'objet de votre traque actuelle,<E003 4> n'est-ce pas ?");
                s = s.Replace("Yes,<E003 6> that's...<E003 10><E025 2><E145 2 64>that's right.",
                              "Oui,<E003 6> c'est...<E003 10><E025 2><E145 2 64> c'est exact.");
                s = s.Replace("Just who is this man?<E003 16>\r\n<E025 1><E332>Why is he here in this exhibit?",
                              "Mais qui est cet homme ?<E003 16>\r\n<E025 1><E332>Pourquoi fait-il partie de cette exposition ?");
                s = s.Replace("And why does the convict behind him<E003 8> <E025 2><E346><E342>have no head?",
                              "Et pourquoi le condamné derrière lui<E003 8> <E025 2><E346><E342>n'a-t-il pas de tête ?");
                s = s.Replace("...The head was missing<E003 8> <E025 2>when the model was returned by\r\nthe thief who stole it.",
                              "... La tête manquait<E003 8> <E025 2>lorsque la statue a été restituée par\r\nle voleur qui l'avait dérobée.");
                s = s.Replace("(What a surprise.)", "(Quelle surprise.)");
                s = s.Replace("So then the case<E003 10> <E356><E342>isn't yet solved,<E003 10> is it?",
                              "Donc l'affaire<E003 10> <E356><E342>n'est pas encore résolue,<E003 10> n'est-ce pas ?");
                s = s.Replace("Did I not say so myself?<E049><E003 14>\r\n<E025 3>‘Largely solved’<E003 4> <E025 2>were my words, I believe.",
                              "Ne l'ai-je pas affirmé moi-même ?<E049><E003 14>\r\n<E025 3>« Largement résolue »<E003 4> <E025 2>furent mes mots exacts.");
                s = s.Replace("But I must locate the missing head<E003 4> ‘tout de suite’ as\r\nMadame would say,<E049> <E145 2 71><E118 2 1.2><E139 2><E330>or I'll be in grave trouble.",
                              "Mais je dois retrouver cette tête manquante <E003 4>« tout de suite » comme\r\ndirait Madame,<E049> <E145 2 71><E118 2 1.2><E139 2><E330>sans quoi j'aurai de sérieux ennuis.");
                s = s.Replace("A very hungry Iris<E003 10> still awaits my return to Baker Street...<E003 14>\r\npreferably with rations!",
                              "Une Iris affamée<E003 10> attend toujours mon retour à Baker Street...<E003 14>\r\nde préférence avec des victuailles !");
                s = s.Replace("Aaargh!", "Aaargh !");
                s = s.Replace("Do you know, though...<E049><E003 14>\r\n<E025 2>Something about this room<E049> <E003 6><E164 3 87 1 2 0 0 1 1><E149 3 4 4><E139 3>is strange!",
                              "Mais dites-moi...<E049><E003 14>\r\n<E025 2>quelque chose dans cette salle<E049> <E003 6><E164 3 87 1 2 0 0 1 1><E149 3 4 4><E139 3>est étrange !");
                s = s.Replace("Strange?<E003 10> What do you mean?", "Étrange ?<E003 10> Que voulez-vous dire ?");
                s = s.Replace("Well,<E003 4> the displays in the House of Horrors are supposed to\r\ndepict real events,<E003 6> are they not?",
                              "Eh bien,<E003 4> les scènes du Manoir des Horreurs sont censées\r\nreproduire des événements réels,<E003 6> n'est-ce pas ?");
                s = s.Replace("Indeed they are, Miss Susato.<E049><E003 12>\r\n<E025 3>Do go on...",
                              "Tout à fait, Mlle Susato.<E049><E003 12>\r\n<E025 3>Je vous en prie, poursuivez...");
                s = s.Replace("And,<E003 10> <E025 2>as terrifying as they are,<E003 6> the scenes in the other\r\nexhibits are believable.",
                              "Et,<E003 10> <E025 2>aussi terrifiantes soient-elles,<E003 6> les scènes des autres\r\nsalles restent plausibles.");
                s = s.Replace("But this one...", "Mais celle-ci...");
                s = s.Replace("This<E003 16> <E239>surely couldn't ever really have happened,<E003 8> could it?",
                              "Ceci<E003 16> <E239>n'a sûrement jamais pu se produire réellement,<E003 8> pas vrai ?");
                s = s.Replace("I think it's time I educated you a little...",
                              "Je pense qu'il est temps de vous éclairer un peu...");
                s = s.Replace("...about the nature of the incidents involving the Professor<E003 8>\r\n<E025 3>ten years ago.",
                              "... sur la nature exacte des crimes du Démon Assassin<E003 8>\r\n<E025 3>il y a dix ans.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#1
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#1"] = en => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à signaler...)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#2
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#2"] = en => {
                string s = en;
                s = s.Replace("This part of the exhibit<E049><E003 10> <E025 2><E341>is just as disturbing as the rest.<E049><E003 12>\r\n<E025 3>It looks so real...",
                              "Cette partie de la scène<E049><E003 10> <E025 2><E341>est tout aussi dérangeante que le reste.<E049><E003 12>\r\n<E025 3>C'est si réaliste...");
                s = s.Replace("It seems to be a young man<E003 8> <E145 3 88><E149 3 8 4><E025 3>in a white overcoat.",
                              "On dirait un jeune homme<E003 8> <E145 3 88><E149 3 8 4><E025 3>en manteau blanc.");
                s = s.Replace("And he has<E049><E003 8> <E145 3 79><E117 3 20><E149 3 0 0><E003 15><E330>a large shovel in his hand, too,<E049><E003 10> look.",
                              "Et il tient<E049><E003 8> <E145 3 79><E117 3 20><E149 3 0 0><E003 15><E330>une grande bêche dans sa main,<E049><E003 10> regardez.");
                s = s.Replace("(Perhaps we should investigate in a little more detail...)",
                              "(Peut-être devrions-nous examiner cela de plus près...)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#11
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#11"] = en => {
                string s = en;
                s = s.Replace("What's this here?", "Qu'avons-nous là ?");
                s = s.Replace("Well,<E003 4> this would appear to be a lens in the middle, so...",
                              "Eh bien,<E003 4> cela ressemble à un objectif au centre, alors...");
                s = s.Replace("...I believe it's probably a camera.",
                              "... je crois qu'il s'agit d'un appareil photo.");
                s = s.Replace("A,<E003 8> <E025 2>a camera!<E003 12> <E025 1><E604>But it's so small!",
                              "Un...<E003 8> <E025 2>un appareil photo !<E003 12> <E025 1><E604>Mais il est minuscule !");
                s = s.Replace("British technology is incredible,<E003 4> isn't it?<E003 12>\r\nI mean,<E003 4> what about Mr Sholmes's skin prints?",
                              "La technologie britannique est prodigieuse,<E003 4> non ?<E003 12>\r\nJe veux dire,<E003 4> pensez aux empreintes de Mr Holmes !");
                s = s.Replace("...I think perhaps you should treat Mr Sholmes's\r\ninventions as...<E003 8>exceptions to the rule.",
                              "... Je crois que vous devriez considérer les trouvailles de Mr Holmes\r\ncomme des...<E003 8> exceptions à la règle.");
                s = s.Replace("But anyway,<E003 8> why would the man be in a graveyard at\r\nnight with a camera?",
                              "Mais bref,<E003 8> pourquoi cet homme serait-il dans un cimetière la\r\nnuit avec un appareil photo ?");
                s = s.Replace("I,<E003 8> I wonder...", "Je...<E003 8> je me le demande...");
                s = s.Replace("Perhaps he was trying to capture the moment a dead\r\nbody came back as a ghost on film!",
                              "Peut-être essayait-il d'immortaliser sur pellicule le moment où\r\nle mort se réveille en fantôme !");
                s = s.Replace("We'll just borrow this for a little while, I think.",
                              "Nous allons lui emprunter ceci un petit moment, je pense.");
                s = s.Replace("The camera has been\r\nentered into the Court Record.",
                              "L'appareil photo a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#12
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#12"] = en => {
                string s = en;
                s = s.Replace("The camera has been\r\nentered into the Court Record.",
                              "L'appareil photo a été ajouté\r\nau dossier de l'affaire.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#13
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#13"] = en => {
                string s = en;
                s = s.Replace("By looking at the photographic plate inside the camera,<E003 6>\r\nwe can see what picture was taken.",
                              "En examinant la plaque photographique à l'intérieur,<E003 6>\r\nnous pourrons voir le cliché qui a été pris.");
                s = s.Replace("What's a photographic plate?", "Qu'est-ce qu'une plaque photographique ?");
                s = s.Replace("It's a piece of glass<E003 4> coated in a special emulsion that reacts\r\nto the light coming in through the lens.",
                              "C'est une lame de verre<E003 4> recouverte d'une émulsion spéciale qui\r\nréagit à la lumière pénétrant par l'objectif.");
                s = s.Replace("If we open the cover at the back of the camera,<E003 6> we should\r\nfind it.<E003 14> <E025 1><E333><E342>Let's have a look!",
                              "Si nous ouvrons le couvercle à l'arrière,<E003 6> nous devrions la\r\ntrouver.<E003 14> <E025 1><E333><E342>Regardons ça !");
                s = s.Replace("(You should see yourself, Susato-san.<E003 10>\r\nYour eyes are shining.)",
                              "(Vous devriez vous voir, Susato-san.<E003 10>\r\nVos yeux brillent d'excitation.)");
                s = s.Replace("(You really do like machinery,<E003 8> don't you?)",
                              "(Vous aimez vraiment la mécanique,<E003 8> n'est-ce pas ?)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#14
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#14"] = en => {
                string s = en;
                s = s.Replace("What a large shovel...<E003 14>\r\n<E025 2>He's holding it rather ominously,<E003 6> isn't he?",
                              "Quelle grande bêche...<E003 14>\r\n<E025 2>Il la brandit d'un air bien menaçant,<E003 6> non ?");
                s = s.Replace("What on earth was the man doing with a shovel in a\r\ngraveyard<E003 4> in the middle of the night?",
                              "Que diable faisait cet homme avec une bêche dans un cimetière<E003 4>\r\nen pleine nuit ?");
                s = s.Replace("Um...<E003 8>Miss Susato...", "Euh...<E003 8> Mlle Susato...");
                s = s.Replace("That's...<E003 10><E330><E025 2>a spade,<E003 8> isn't it?",
                              "C'est...<E003 10><E330><E025 2> une pelle,<E003 8> n'est-ce pas ?");
                s = s.Replace("No,<E003 8> it's a shovel.", "Non,<E003 8> c'est une bêche.");
                s = s.Replace("No no,<E003 10> shovels are for digging.<E003 8>\r\nThat's for scooping up loose material.<E003 8> It's a spade.",
                              "Non, non,<E003 10> les pelles servent à creuser.<E003 8>\r\nÇa, c'est pour déplacer de la terre meuble.<E003 8> C'est une pelle.");
                s = s.Replace("We've been through this, Mr Naruhodo.<E003 10>\r\nIt's a shovel.",
                              "Nous en avons déjà parlé, Mr Naruhodo.<E003 10>\r\nC'est une bêche.");
                s = s.Replace("No no no.<E003 16>\r\n<E025 3>Although...<E003 12><E025 2><E333>we haven't considered trowels...",
                              "Non, non, non.<E003 16>\r\n<E025 3>Quoique...<E003 12><E025 2><E333> nous n'avons pas évoqué les truelles...");
                s = s.Replace("We've allowed ourselves to be distracted,<E003 4> I feel.",
                              "Nous nous laissons distraire,<E003 4> j'ai l'impression.");
                s = s.Replace("Perhaps we should concentrate on what the man was\r\ndoing with the implement.",
                              "Nous devrions nous concentrer sur ce que cet homme faisait\r\navec cet outil.");
                s = s.Replace("(So we're going to bury the hatchet?)",
                              "(Alors on enterre la hache de guerre ?)");
                s = s.Replace("You're right, though...", "Vous avez raison, cela dit...");
                s = s.Replace("What was the man doing in the graveyard in the first\r\nplace,<E003 8> that's the real question.",
                              "Que faisait cet homme dans ce cimetière pour commencer,<E003 8>\r\nc'est la vraie question.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#15
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#15"] = en => {
                string s = en;
                s = s.Replace("I can't see his face very well,<E003 8> can you?",
                              "On ne voit pas très bien son visage,<E003 8> n'est-ce pas ?");
                s = s.Replace("Perhaps if I just...", "Peut-être que si je...");
                s = s.Replace("Oh!<E003 12> Do,<E003 6> do you think you should be manhandling the\r\nexhibits, Mr Naruhodo?",
                              "Oh !<E003 12> Pensez-vous qu'il soit bien sage de manipuler ainsi\r\nles statues de cire, Mr Naruhodo ?");
                s = s.Replace("I'll put it back exactly as it was,<E003 8> don't worry.",
                              "Je la remettrai exactement comme elle était,<E003 8> ne vous inquiétez pas.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#16
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#16"] = en => {
                string s = en;
                s = s.Replace("So this...<E003 8>is Enoch Drebber...", "Alors c'est lui...<E003 8> Enoch Drebber...");
                s = s.Replace("What an extraordinary coincidence,<E003 4> coming across a\r\nmodel of the very man we're looking for.",
                              "Quelle extraordinaire coïncidence,<E003 4> tomber sur la statue de cire\r\nde l'homme même que nous recherchons.");
                s = s.Replace("If only this waxwork was a living model like Mr Sholmes.<E003 10>\r\nThen we'd have found our man.",
                              "Si seulement cette statue était vivante comme Mr Holmes.<E003 10>\r\nNous aurions enfin mis la main sur notre suspect.");
                s = s.Replace("And I<E003 10> <E238>would certainly have fainted again.",
                              "Et moi,<E003 10> <E238>j'aurais certainement fait un autre évanouissement.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#17
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#17"] = en => {
                string s = en;
                s = s.Replace("That's quite a large lamp the man's carrying.",
                              "C'est une sacrée lanterne que cet homme transporte.");
                s = s.Replace("Or is it a lantern?<E003 12> It's not unlike a Japanese chochin paper\r\nlantern actually,<E003 6> is it?",
                              "Ou bien une lampe ?<E003 12> Ça ressemble un peu à un chochin japonais en papier,\r\nvous ne trouvez pas ?");
                s = s.Replace("Lamp,<E003 6> lantern,<E003 6> chochin...", "Lampe,<E003 6> lanterne,<E003 6> chochin...");
                s = s.Replace("The point is<E003 6> it casts very little light.<E003 10> To be walking alone\r\nin a graveyard at night with only this...",
                              "Le fait est<E003 6> qu'elle n'éclaire presque rien.<E003 10> Marcher seul de nuit\r\ndans un cimetière avec seulement ça...");
                s = s.Replace("Well,<E003 10> <E238>I certainly couldn't do it.",
                              "Eh bien,<E003 10> <E238>j'en serais bien incapable.");
                s = s.Replace("I'm not sure I could visit a graveyard at all,<E003 8> <E331>even in broad\r\ndaylight, to be honest.",
                              "Je ne suis même pas sûr de pouvoir visiter un cimetière en plein jour,<E003 8>\r\n<E331>pour tout vous avouer.");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#18
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#18"] = en => {
                string s = en;
                s = s.Replace("This must be the killer!<E049><E003 12>\r\n<E025 2><E239>The fiend known as the Professor!",
                              "Ce doit être le meurtrier !<E049><E003 12>\r\n<E025 2><E239>Le monstre surnommé le Démon Assassin !");
                s = s.Replace("Yes,<E003 8> <E025 2>I think so.<E003 14>\r\n<E025 3>According to what Madame Tusspells said...",
                              "Oui,<E003 8> <E025 2>je crois bien.<E003 14>\r\n<E025 3>D'après ce qu'a dit Madame Pétrie...");
                s = s.Replace("...he killed five victims,<E003 6> all of noble or royal blood.",
                              "... il a tué cinq victimes,<E003 6> toutes de sang noble ou royal.");
                s = s.Replace("The waxwork is so lifelike,<E003 8> isn't it?<E049><E003 10>\r\n<E145 3 68><E117 3 25><E003 10><E330>Like all the models in this place.",
                              "La statue est si vivante,<E003 8> n'est-ce pas ?<E049><E003 10>\r\n<E145 3 68><E117 3 25><E003 10><E330>Comme tous les mannequins de cet endroit.");
                s = s.Replace("I know.<E003 8> It looks like it could start moving at any moment,\r\ndoesn't it?<E003 12> <E025 3>...If only it had a head,<E003 6> that is.",
                              "Je sais.<E003 8> On dirait qu'elle va se mettre à bouger à tout instant,<E003 12>\r\n<E025 3>... si seulement elle avait encore sa tête, évidemment.");
                s = s.Replace("(Perhaps we should examine it in a little more detail...)",
                              "(Peut-être devrions-nous l'examiner d'un peu plus près...)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#24
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#24"] = en => {
                string s = en;
                s = s.Replace("So this is the condemned man...", "Voici donc le condamné...");
                s = s.Replace("Yes.<E003 10> The so-called ‘Professor’.", "Oui.<E003 10> Le prétendu « Démon Assassin ».");
                s = s.Replace("Then,<E003 10> <E341>then perhaps...", "Alors,<E003 10> <E341>alors peut-être que...");
                s = s.Replace("...his head<E003 12> <E341>was ch-<E003 8><E356>chopped off by a guillotine!",
                              "... sa tête<E003 12> <E341>a été tr-<E003 8><E356>tranchée par la guillotine !");
                s = s.Replace("But,<E003 10> unable to find peace,<E003 8> he,<E003 10> <E025 1><E332>he emerged from his grave\r\nas a headless g-<E003 8>g-<E003 8>ghost!",
                              "Mais,<E003 10> privé de repos éternel,<E003 8> il...<E003 10> <E025 1><E332>il est sorti de sa tombe\r\nsous la forme d'un f-<E003 8>f-<E003 8>fantôme sans tête !");
                s = s.Replace("...Do,<E003 10> <E025 2>do we have to entertain such terrifying ideas,<E003 4>\r\nMiss Susato?",
                              "... Devons-nous,<E003 10> <E025 2>devons-nous imaginer des scénarios aussi\r\neffrayants,<E003 4> Mlle Susato ?");
                s = s.Replace("Anyway,<E003 6> I'm sure the model had a head once.<E003 10> There's a\r\nmetal fitting for it,<E003 6> see?",
                              "De toute façon,<E003 6> la statue avait bien une tête à l'origine.<E003 10>\r\nIl y a une tige en métal pour la fixer, voyez-vous ?");
                s = s.Replace("Then...<E003 12><E025 2><E330>perhaps Mr Sholmes absent-mindedly forgot to\r\nreattach it?",
                              "Alors...<E003 12><E025 2><E330> peut-être que Mr Holmes a distraitement oublié de\r\nla remettre en place ?");
                s = s.Replace("That's an extremely absent-minded detective you're\r\ndescribing,<E003 6> isn't it?",
                              "Ce serait un détective drôlement distrait,<E003 6> vous ne trouvez pas ?");
                s = s.Replace("Or perhaps...", "Ou bien...");
                s = s.Replace("...the thief absent-mindedly forgot to include the head\r\nwhen he or she returned it to the museum?",
                              "... le voleur a distraitement oublié de joindre la tête en la\r\nrestituant au musée ?");
                s = s.Replace("And that would be an extremely absent-minded thief.",
                              "Et ce serait un voleur encore plus distrait.");
                s = s.Replace("(Could there have been some reason why only the head\r\nwasn't returned?)",
                              "(Y avait-il une raison particulière pour que seule la tête\r\nmanque à l'appel ?)");
                s = s.Replace("Well,<E003 6> whatever the reason...", "Eh bien,<E003 6> quelle qu'en soit la raison...");
                s = s.Replace("...it means we don't know what the face of the infamous\r\nProfessor looked like,<E003 4> do we?",
                              "... cela signifie que nous ignorons à quoi ressemblait le visage\r\ndu tristement célèbre Démon Assassin,<E003 4> n'est-ce pas ?");
                s = s.Replace("There's something caught<E003 6> just inside the convict's jacket\r\nhere...",
                              "Il y a quelque chose de coincé<E003 6> dans la veste du condamné...");
                s = s.Replace("looks like <E006>a piece of broken glass<E005>.<E003 10>\r\n<E007>(And quite a big piece, too.)",
                              "ressemble à <E006>un éclat de verre brisé<E005>.<E003 10>\r\n<E007>(Et un sacré gros morceau, en plus.)");
                s = s.Replace("It's very thick, isn't it?<E003 8> About five times thicker than\r\nnormal window glazing, I'd say.",
                              "Il est très épais, non ?<E003 8> Au moins cinq fois plus épais qu'une vitre\r\nordinaire, je dirais.");
                s = s.Replace("Where could such a thick piece of glass have come from,\r\nI wonder...?",
                              "D'où un verre aussi épais peut-il bien provenir... ?");
                s = s.Replace("I suppose it must have been made thick<E003 6> to increase its\r\nstrength?",
                              "J'imagine qu'on l'a fait épais<E003 6> pour augmenter sa résistance ?");
                s = s.Replace("But why?", "Mais pourquoi ?");
                s = s.Replace("...because the glass had to <E006>span a particularly wide area<E005>.<E003 8>\r\nSuch as in a big building, for example.",
                              "... parce que ce verre devait <E006>couvrir une surface particulièrement vaste<E005>.<E003 8>\r\nComme dans un grand édifice, par exemple.");
                s = s.Replace("Ah...<E003 12><E025 2>well we've seen a large glass building recently,\r\nhaven't we?<E003 10> And some of the glass was broken, too.",
                              "Ah...<E003 12><E025 2> nous avons justement vu une immense bâtisse de verre,\r\nn'est-ce pas ?<E003 10> Et des vitres y étaient brisées.");
                s = s.Replace("You don't mean...!", "Vous ne voulez pas dire... !");
                s = s.Replace("The Crystal Tower<E005> at the Great Exhibition.",
                              "La Tour de Cristal<E005> de l'Exposition Universelle.");
                s = s.Replace("Exactly.<E003 12>", "Exactement.<E003 12>");
                s = s.Replace("But why would glass from the Crystal Tower<E003 4> be lodged\r\ninside this waxwork's jacket?",
                              "Mais pourquoi du verre de la Tour de Cristal<E003 4> serait-il logé\r\ndans la veste de cette statue ?");
                s = s.Replace("It makes you think,<E003 6> doesn't it?", "Ça donne à réfléchir,<E003 6> n'est-ce pas ?");
                s = s.Replace("The piece of broken glass has been\r\nentered into the Court Record.",
                              "L'éclat de verre brisé a été ajouté\r\nau dossier de l'affaire.");
                s = s.Replace("(Earlier in court we established that the kinesis\r\nexperiment was a trick.)",
                              "(Plus tôt au tribunal, nous avons établi que l'expérience\r\nde téléportation était une supercherie.)");
                s = s.Replace("(And now we discover this fragment of glass here in this\r\nwaxwork.<E003 14> <E025 3>...Is it just a coincidence?)",
                              "(Et nous découvrons ce fragment de verre dans cette statue.<E003 14>\r\n<E025 3>... Est-ce une simple coïncidence ?)");
                return s;
            };

            // BB\script\output\_sce02_bg0304_1_check_eng#29
            entryTranslators["BB\\script\\output\\_sce02_bg0304_1_check_eng#29"] = en => {
                string s = en;
                s = s.Replace("It doesn't matter if they're here in Britain<E003 6> or in Japan,<E003 14>\r\n<E025 3><E341>graveyards are scary.",
                              "Peu importe qu'on soit en Grande-Bretagne<E003 6> ou au Japon,<E003 14>\r\n<E025 3><E341>les cimetières font froid dans le dos.");
                s = s.Replace("Now I come to think of it,<E003 8> this is the first time I've seen a\r\nBritish grave.",
                              "En y repensant,<E003 8> c'est la toute première fois que je vois une tombe\r\nbritannique.");
                s = s.Replace("According to what I've read,<E049><E003 10> <E333>the custom in Britain is to\r\nbury the dead as they are,<E003 6> without cremation.",
                              "D'après mes lectures,<E049><E003 10> <E333>la coutume ici est d'inhumer les corps\r\ntels quels,<E003 6> sans incinération.");
                s = s.Replace("Whaaat?!<E003 14>\r\n<E025 3>But,<E003 10> <E341><E145 3 77>but if you do that...",
                              "Quoooi ?!<E003 14>\r\n<E025 3>Mais...<E003 10> <E341><E145 3 77> si l'on fait cela...");
                s = s.Replace("...you might accidentally bury people<E003 8> <E025 1><E335>while they're still\r\nalive!",
                              "... on pourrait enterrer des gens par mégarde<E003 8> <E025 1><E335>alors qu'ils sont\r\ntoujours vivants !");
                s = s.Replace("I'm not sure that would be worse than accidentally\r\nincinerating people while they're still alive.",
                              "Je ne suis pas sûre que ce soit pire que d'incinérer des gens vivants\r\npar inadvertance.");
                s = s.Replace("I think we can both agree<E003 8> <E025 2><E341>that it's best not to be still alive\r\nwhen our time comes, then.",
                              "Je pense que nous serons d'accord<E003 8> <E025 2><E341>pour dire qu'il vaut mieux\r\nêtre bien mort quand notre heure est venue, alors.");
                s = s.Replace("...And what am I to say to that?", "... Et que suis-je censée répondre à cela ?");
                return s;
            };
        }
    }
}
