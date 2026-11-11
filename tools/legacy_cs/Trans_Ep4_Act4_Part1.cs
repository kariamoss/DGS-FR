using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act4 {
    public partial class Program {
        public static void RegisterPart1() {
            // [1] BB\script\output\_sce03_c105_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c105_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("2nd November, 1:00 p.m.\r\n<CNTR><E003 5>The Old Bailey Courtroom", "2 novembre, 13 h 00\r\n<CNTR><E003 5>Salle d'audience de l'Old Bailey");
                s = s.Replace("In the name of Her Majesty the Queen, <E049><E003 8>I hereby declare\r\nthis court to be in session again.", "Au nom de Sa Majesté la Reine, <E049><E003 8>je déclare par la présente\r\nque cette séance d'audience est reprise.");
                s = s.Replace("We resume the closed court hearing of Barok van Zieks,<E049><E003 13>\r\n<E239><E025 2><E130 15 1><E131><E003 6>here present, <E003 6>who stands accused of murder.", "Nous reprenons l'audience à huis clos de Barok van Zieks,<E049><E003 13>\r\n<E239><E025 2><E130 15 1><E131><E003 6>ici présent, <E003 6>qui est accusé de meurtre.");
                s = s.Replace("Now then, <E049><E003 8>Prosecutor Asogi...", "À présent, <E049><E003 8>procureur Asogi...");
                s = s.Replace("My Lord?", "Votre Honneur ?");
                s = s.Replace("Have you summoned the witnesses as requested?", "Avez-vous convoqué les témoins comme convenu ?");
                s = s.Replace("Yes.<E049><E003 8> <E025 2>The two members of the Red-Headed League who\r\nplanned and carried out the deception.", "Oui.<E049><E003 8> <E025 2>Les deux membres de la Ligue des Rouquins qui ont\r\nplanifié et orchestré cette supercherie.");
                s = s.Replace("They arrived not long ago from the local prison by police\r\ncarriage.", "Ils sont arrivés de la prison locale il y a peu par voiture\r\nde police.");
                s = s.Replace("Very good.", "Très bien.");
                s = s.Replace("Bailiff, <E049><E003 8><E025 1><E338><E341>usher the two men into the courtroom!", "Huissier, <E049><E003 8><E025 1><E338><E341>faites entrer ces deux hommes dans le tribunal !");
                return s;
            };

            // [2] BB\script\output\_sce03_c105_0010_eng#2
            entryTranslators[@"BB\script\output\_sce03_c105_0010_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("These two men are currently being held by the police on\r\nsuspicion of attempted extortion.", "Ces deux hommes sont actuellement retenus par la police car\r\nsoupçonnés de tentative d'extorsion de fonds.");
                s = s.Replace("You may omit your occupations.<E049><E003 10>\r\nBut state your names now for the court.", "Vous pouvez omettre vos professions.<E049><E003 10>\r\nVeuillez décliner vos identités devant la cour.");
                s = s.Replace("I am <E049><E003 8><E025 2><E006>Fabien de Rousseau<E005>.", "Je suis <E049><E003 8><E025 2><E006>Fabien de Rousseau<E005>.");
                s = s.Replace("A descendant of ze great de Rousseau family from Nice,<E049><E003 8>\r\n<E025 4>en France.", "Descendant de la grande famille de Rousseau de Nice,<E049><E003 8>\r\n<E025 4>en France.");
                s = s.Replace("And my-a name <E049><E003 10>is <E006>Peppino de Rossi<E005>!", "Et mon-a nom <E049><E003 10>est <E006>Peppino de Rossi<E005> !");
                s = s.Replace("I am the third son of the great familia de Rossi – <E049><E003 8><E025 1><E136 81 67 3><E117 81 3><E003 5><E346>the\r\nlandowners from Napoli!", "Je suis le troisième fils de la grande familia de Rossi – <E049><E003 8><E025 1><E136 81 67 3><E117 81 3><E003 5><E346>les\r\ngrand-a propriétaires de Napoli !");
                s = s.Replace("The two men first became acquainted at a boarding\r\nschool for European nobility.", "Ces deux hommes ont fait connaissance dans un pensionnat\r\npour la noblesse européenne.");
                s = s.Replace("Zose who graduate from Temsik are ze future leaders of\r\nEurope.", "Ceux qui sortent diplômés de Temsik sont l'élite de l'Europe\r\nde demain.");
                s = s.Replace("...But!", "...Mais !");
                s = s.Replace("Do you 'ave any idea 'ow boring it is to be born wiz\r\nnoble blood?", "Avez-vous la moindre idée du terrible ennui que procure une\r\nnaissance au sein de la noblesse ?");
                s = s.Replace("...Alors!", "...Alors !");
                s = s.Replace("I make it my mission to get ze better of ze world by\r\nemploying ze little grey cells of my brain.", "Je me suis donné pour mission de triompher du monde en\r\nfaisant fonctionner les petites cellules grises de mon cerveau.");
                s = s.Replace("Zat is all I am trying to do, <E003 6><E025 3>uh.", "Voilà tout ce que j'ai tenté d'accomplir, <E003 6><E025 3>voyez-vous.");
                s = s.Replace("So<E025 7>...<E049><E003 14><E025 2><E145 1 79><E003 15><E239>that's the only reason for this whole grand deception\r\nyou've been carrying out?", "Alors<E025 7>...<E049><E003 14><E025 2><E145 1 79><E003 15><E239>c'est la seule et unique raison de toute cette grande\r\nsupercherie que vous avez manigancée ?");
                s = s.Replace("...Oui.<E049><E003 14> <E025 3>You could say zat.", "...Oui.<E049><E003 14> <E025 3>On pourrait dire cela.");
                s = s.Replace("Not bad, <E049><E003 10>ay?", "Pas mal, <E049><E003 10>non ?");
                s = s.Replace("He has the grand <E006>ideals<E005>, <E049><E003 10><E025 1><E330>but the petty <E006>plans<E005>!", "Il a les grands <E006>idéaux<E005>, <E049><E003 10><E025 1><E330>mais les petits <E006>plans<E005> !");
                s = s.Replace("This <E006>strange combination<E005> is-a<E049><E003 8><E164 81 67 1 2 8 0 2 1><E139 81><E025 1> the charm of the\r\nHairlarious Brothers!", "Cette <E006>étrange combinaison<E005>, c'est-a<E049><E003 8><E164 81 67 1 2 8 0 2 1><E139 81><E025 1> tout le charme des\r\nFrères Hilaroux !");
                s = s.Replace("Si, <E003 6>capo?", "Si, <E003 6>capo ?");
                s = s.Replace("Listen to me, <E049><E003 4>Peppino.<E049><E003 12> <E025 2>I 'ave two sings to say to you:", "Écoute-moi bien, <E049><E003 4>Peppino.<E049><E003 12> <E025 2>J'ai deux choses à te dire :");
                s = s.Replace("Eh?<E003 6> Che?<E003 8> <E341>Are you about to tell me one of your <E006>grandi\r\nanecdotes<E005>?<E049><E003 12> Evviva!", "Eh ?<E003 6> Che ?<E003 8> <E341>Tu vas me raconter une de tes <E006>grandes\r\nanecdotes<E005> ?<E049><E003 12> Evviva !");
                s = s.Replace("Firstly, <E049><E003 10><E330><E025 2>I want you to stop <E145 81 81>calling me zis ‘capo’.", "Premièrement, <E049><E003 10><E330><E025 2>je veux que tu cesses <E145 81 81>de m'appeler « capo ».");
                s = s.Replace("And secondly...", "Et deuxièmement...");
                s = s.Replace("...we are not ze 'Airlarious Brothers.<E049><E003 12>\r\n<E025 3><E238>Zis is serious business.", "...nous ne sommes pas les Frères Hilaroux.<E049><E003 12>\r\n<E025 3><E238>C'est une entreprise tout ce qu'il y a de plus sérieux.");
                s = s.Replace("Che bello!<E049><E003 10> There it is!<E049><E003 10> <E025 2>The capo's trump-a card:<E049><E003 10>\r\n<E025 1>the furrowed brow!", "Che bello !<E049><E003 10> La voilà !<E049><E003 10> <E025 2>L'arme secrète du capo :<E049><E003 10>\r\n<E025 1>le sourcil froncé !");
                s = s.Replace("It is deep, <E049><E003 10><E025 2>uh, capo?<E049><E003 10> <E025 1>The furrow, <E049><E003 10>and the meaning of your\r\nwords!", "Il est profond, <E049><E003 10><E025 2>hein, capo ?<E049><E003 10> <E025 1>Le froncement, <E049><E003 10>et le sens de tes\r\nparoles !");
                s = s.Replace("The court has been led to believe that under the banner\r\nof the ‘Red-Headed League’...", "La cour a été informée que sous la bannière\r\nde la « Ligue des Rouquins »...");
                s = s.Replace("...you have conspired to swindle money from\r\nunsuspecting members of the public.<E049><E003 10> <E025 3>Is this true?", "...vous avez conspiré pour escroquer de l'argent à des\r\nmembres du public naïfs.<E049><E003 10> <E025 3>Est-ce exact ?");
                s = s.Replace("Oui.<E049><E003 10> <E025 3>C'est ça.", "Oui.<E049><E003 10> <E025 3>C'est bien cela.");
                s = s.Replace("And what exactly was the nature of this deception<E049><E003 8><E145 15 5> by\r\nwhich you planned to defraud?", "Et quelle était exactement la nature de cette supercherie<E049><E003 8><E145 15 5> par\r\nlaquelle vous comptiez frauder ?");
                s = s.Replace("...Alors, <E049><E003 10><E025 3>I will explain it.", "...Alors, <E049><E003 10><E025 3>je vais vous expliquer.");
                s = s.Replace("No, <E003 8>capo!<E049><E003 20> <E164 81 74 1 2 8 0 2 1><E149 81 5 5><E139 81><E025 1>Leave it to-a me!", "Non, <E003 8>capo !<E049><E003 20> <E164 81 74 1 2 8 0 2 1><E149 81 5 5><E139 81><E025 1>Laisse-moi faire !");
                s = s.Replace("As you see, <E049><E003 8><E025 2>we both have the vivid red hair, <E003 4>no?", "Comme vous le voyez, <E049><E003 8><E025 2>nous avons tous deux des cheveux roux flamboyant, <E003 4>non ?");
                s = s.Replace("At school, <E049><E003 8>we were teased for this without pity.", "À l'école, <E049><E003 8>on se moquait de nous sans aucune pitié.");
                s = s.Replace("The capo here, <E049><E003 8>he was many times behind the\r\nschoolhouse,<E003 4> crying like the Trevi Fountain.", "Le capo ici présent, <E049><E003 8>il était souvent caché derrière\r\nl'école,<E003 4> à pleurer comme la fontaine de Trevi.");
                s = s.Replace("‘Uèèè!<E049><E003 16> Zose dogs!<E049><E003 12> One day<E003 8> <E342>ze world will respect us\r\nred-'eads!’", "« Ouin !<E049><E003 16> Ces chiens !<E049><E003 12> Un jour<E003 8> <E342>le monde respectera enfin les\r\nrouquins ! »");
                s = s.Replace("Every night, <E049><E003 8><E025 2>he would bury his-a head in his-a pillow\r\nand weep for the injustice.", "Chaque nuit, <E049><E003 8><E025 2>il enfouissait sa tête sous son oreiller\r\net pleurait sur cette injustice.");
                s = s.Replace("C'est bien, <E003 6>Peppino!<E049><E003 12> Enough!<E049><E003 15>\r\n<E025 3>I will explain ze rest.", "C'est bien, <E003 6>Peppino !<E049><E003 12> Ça suffit !<E049><E003 15>\r\n<E025 3>Je vais expliquer le reste.");
                return s;
            };

            // [3] BB\script\output\_sce03_c105_0010_eng#3
            entryTranslators[@"BB\script\output\_sce03_c105_0010_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Ze first step <E049><E003 12><E330><E025 2>was ze newspaper advertisement.", "La première étape <E049><E003 12><E330><E025 2>a été l'annonce dans le journal.");
                s = s.Replace("About one week before ze plan was put into operation,<E049><E003 8>\r\n<E025 3>we listed ze same notice in every paper in London.", "Environ une semaine avant de lancer l'opération,<E049><E003 8>\r\n<E025 3>nous avons fait publier la même annonce dans tous les journaux de Londres.");
                s = s.Replace("Yes, <E049><E003 8>we saw that notice.", "Oui, <E049><E003 8>nous avons vu cette annonce.");
                s = s.Replace("It was this one, <E003 6>I believe.<E049><E003 10>\r\n<E025 2><E341>Entitled ‘To the Red-Headed League’.", "C'était celle-ci, <E003 6>je crois.<E049><E003 10>\r\n<E025 2><E341>Intitulée « À la Ligue des Rouquins ».");
                s = s.Replace("Oui.<E049><E003 10> <E025 2>C'est ça.<E049><E003 10>\r\nI am honoured zat you 'ave seen it.", "Oui.<E049><E003 10> <E025 2>C'est exact.<E049><E003 10>\r\nJe suis honoré que vous l'ayez vue.");
                s = s.Replace("It states that the only condition for joining the league<E049><E003 8> <E025 3>is\r\nhaving flame-coloured hair.", "Elle stipule que la seule condition pour rejoindre la ligue<E049><E003 8> <E025 3>est\r\nd'avoir des cheveux d'une rousseur flamboyante.");
                s = s.Replace("And that if you satisfy the interview panel and are\r\nadmitted into the league...", "Et que si vous donnez satisfaction lors de l'entretien et êtes\r\nadmis dans la ligue...");
                s = s.Replace("...you could receive a weekly income of four pounds.", "...vous pourriez percevoir un salaire de quatre livres par semaine.");
                s = s.Replace("On the date specified, <E049><E003 8>red-headed hopefuls gathered in\r\ndroves at a park<E003 6> specified in the advertisement.", "À la date convenue, <E049><E003 8>des rouquins pleins d'espoir ont afflué\r\nen masse dans le parc<E003 6> désigné dans l'annonce.");
                s = s.Replace("And from each person present, <E049><E003 8><E238>this pair took an\r\napplication fee of five shillings.", "Et à chaque personne présente, <E049><E003 8><E238>ce duo a soutiré des\r\nfrais d'inscription de cinq shillings.");
                s = s.Replace("And wiz ze money, <E049><E003 8>to France!<E049><E003 12>\r\n<E025 2>It was a plan most elegant, <E003 6><E025 3>non?", "Et avec l'argent, <E049><E003 8>en route pour la France !<E049><E003 12>\r\n<E025 2>C'était un plan d'une grande élégance, <E003 6><E025 3>non ?");
                s = s.Replace("No, <E049><E003 8>it was most dishonourable.", "Non, <E049><E003 8>c'était particulièrement déshonorant.");
                s = s.Replace("But to be frank, <E049><E003 8><E025 2>I'm stunned anybody was foolish enough\r\nto be taken in by such an obvious trick.", "Mais à franchement parler, <E049><E003 8><E025 2>je suis sidéré que des gens aient\r\nété assez naïfs pour se laisser duper par un piège si grossier.");
                s = s.Replace("The park was described by one witness as <E049><E003 4><E164 9 70 1 2 6 0 0 1><E118 9 1.2><E139 9><E025 2>‘choked with\r\nred-headed folk, <E049><E003 6>like a coster's orange barrow’.", "Un témoin a décrit le parc comme étant <E049><E003 4><E164 9 70 1 2 6 0 0 1><E118 9 1.2><E139 9><E025 2>« bondé de\r\nrouquins, <E049><E003 6>pareil à une charrette d'oranges ».");
                s = s.Replace("And the day on which all these men gathered to apply<E049><E003 10>\r\n<E025 3>was <E006>the day before the victim was discovered<E005>.", "Et le jour où tous ces hommes se sont rassemblés<E049><E003 10>\r\n<E025 3>était <E006>la veille de la découverte du corps de la victime<E005>.");
                s = s.Replace("Crucially, <E049><E003 8><E025 3><E238>these two men <E006>spoke face to face<E005> with every\r\nsingle person present that day.", "Détail crucial : <E049><E003 8><E025 3><E238>ces deux hommes ont <E006>parlé en face-à-face<E005> avec chaque\r\npersonne présente ce jour-là.");
                s = s.Replace("Oui.<E049><E003 12><E025 2> I 'ave seen more red-'eaded people in one day zan I\r\nwill see in ze rest of my life.", "Oui.<E049><E003 12><E025 2> J'ai vu plus de têtes rousses en un jour que je n'en\r\nverrai durant tout le restant de mon existence.");
                s = s.Replace("Si, <E003 6>si.<E049><E003 6> <E164 81 69 1 2 8 0 2 1><E139 81><E025 1>And-a now, <E003 6>every time I see the capo's hair,<E049><E003 8> I feel\r\nsick to my stomach!", "Si, <E003 6>si.<E049><E003 6> <E164 81 69 1 2 8 0 2 1><E139 81><E025 1>Et maintenant, <E003 6>chaque fois que je vois les cheveux du capo,<E049><E003 8> j'ai\r\nenvie de vomir !");
                s = s.Replace("Anyway, <E049><E003 15><E145 80 77><E118 80 0.3><E003 20><E025 3><E330>why 'ave we been summoned 'ere today?", "Bref, <E049><E003 15><E145 80 77><E118 80 0.3><E003 20><E025 3><E330>pourquoi avons-nous été convoqués ici aujourd'hui ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Ze date for our trial was not until tomorrow,<E049><E003 8> <E025 3>I was told.", "La date de notre propre procès n'était prévue que pour demain,<E049><E003 8> <E025 3>à ce qu'on m'a dit.");
                s = s.Replace("Naturally, <E049><E003 8><E025 3>neither of these men have been told any details\r\nabout this trial.", "Naturellement, <E049><E003 8><E025 3>aucun détail concernant le présent procès n'a\r\nété divulgué à ces deux hommes.");
                s = s.Replace("They've only been shown <E049><E003 11><E025 3><E333><E061 1><E300 85 0>this photograph.", "On leur a seulement montré <E049><E003 11><E025 3><E333><E061 1><E300 85 0>cette photographie.");
                s = s.Replace("So, <E049><E003 8><E025 2>Mr de Rousseau and Mr de Rossi, <E049><E003 8>you will now give\r\nyour formal testimony for the court...", "Ainsi donc, <E049><E003 8><E025 2>monsieur de Rousseau et monsieur de Rossi, <E049><E003 8>vous allez\r\nmaintenant livrer votre témoignage officiel à la cour...");
                s = s.Replace("...on the subject of the gentleman pictured in this\r\nphotograph.", "...au sujet du monsieur figurant sur cette photographie.");
                s = s.Replace("Of course.<E049><E003 6> <E145 80 66><E003 8><E025 3><E333>We are always ready to 'elp wiz ze law.", "Naturellement.<E049><E003 6> <E145 80 66><E003 8><E025 3><E333>Nous sommes toujours ravis de prêter main-forte à la justice.");
                return s;
            };

            // [4] BB\script\output\_sce03_c105_0020_eng#2
            entryTranslators[@"BB\script\output\_sce03_c105_0020_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Man in the Photograph –", "– L'homme sur la photographie –");
                s = s.Replace("We 'ad more zan one thousand red-'eaded people\r\nassemble in ze park on Lime Street zat day.", "Nous avons réuni plus d'un millier de rouquins dans le\r\nparc de Lime Street ce jour-là.");
                s = s.Replace("But <E145 81 66>I don't recall the man in this-a photograph.<E049><E003 13>\r\n<E164 81 81 1 2 6 0 0 1><E139 81>Ay, <E003 4>capo?", "Mais <E145 81 66>je ne me souviens pas de l'homme sur cette photo.<E049><E003 13>\r\n<E164 81 81 1 2 6 0 0 1><E139 81>Pas vrai, <E003 4>capo ?");
                s = s.Replace("Non, <E049><E003 8><E025 2>I don't remember 'im.<E049><E003 8> Obviously 'e is dead now.<E049><E003 10>\r\n<E025 2>But I assure you, <E049><E003 8><E025 3><E330>'e was not in ze park.", "Non, <E049><E003 8><E025 2>je ne me rappelle pas de lui.<E049><E003 8> À l'évidence, il est mort.<E049><E003 10>\r\n<E025 2>Mais je vous l'assure, <E049><E003 8><E025 3><E330>il n'était pas dans le parc.");
                s = s.Replace("Allora!<E049><E003 10> This victim <E049><E003 5><E164 81 67 1 2 8 0 2 1><E139 81><E025 1>is-a nothing to do with us!", "Allora !<E049><E003 10> Cette victime <E049><E003 5><E164 81 67 1 2 8 0 2 1><E139 81><E025 1>n'a rien à voir avec nous !");
                s = s.Replace("You 'ave a lot to answer for, Peppino.<E049><E003 10> <E025 3>It is your fault zat\r\nwe got caught in ze first place.", "Tu as des comptes à rendre, Peppino.<E049><E003 10> <E025 3>C'est de ta faute si\r\nnous nous sommes fait pincer pour commencer.");
                return s;
            };

            // [5] BB\script\output\_sce03_c105_0020_eng#3
            entryTranslators[@"BB\script\output\_sce03_c105_0020_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("You've given sworn testimony <E049><E003 8><E333><E025 3>that this man in the\r\nphotograph was not present.<E049><E003 10> <E025 2><E145 112 0><E118 112 1.6><E003 15>Can you be certain?", "Vous venez de déclarer sous serment <E049><E003 8><E333><E025 3>que l'homme sur la\r\nphotographie n'était pas présent.<E049><E003 10> <E025 2><E145 112 0><E118 112 1.6><E003 15>En êtes-vous certains ?");
                s = s.Replace("Oui, <E003 6>oui.<E049><E003 10> <E025 2>I am quite certain.<E049><E003 14>\r\n<E333>We did not interview zis man.", "Oui, <E003 6>oui.<E049><E003 10> <E025 2>J'en suis absolument certain.<E049><E003 14>\r\n<E333>Nous n'avons jamais reçu cet individu.");
                s = s.Replace("Nobody looking like-a this came to the park.<E049><E003 12>\r\n<E136 81 67 3><E117 81 3><E139 81><E346><E025 1>This, I can promise!", "Personne qui ressemblait à ça n'est venu dans le parc.<E049><E003 12>\r\n<E136 81 67 3><E117 81 3><E139 81><E346><E025 1>Ça, je peux vous le jurer !");
                s = s.Replace("It must be noted <E145 15 2><E118 15 1.2>that you have been arrested for a grand\r\ndeception, <E003 6>however.", "Il convient toutefois de rappeler <E145 15 2><E118 15 1.2>que vous avez été arrêtés\r\npour une vaste escroquerie.");
                s = s.Replace("Accordingly, <E049><E003 10><E145 15 5><E025 2><E330>this court has little confidence in your\r\nassurances.", "En conséquence, <E049><E003 10><E145 15 5><E025 2><E330>cette cour n'accorde que peu de crédit à vos\r\naffirmations.");
                s = s.Replace("...Uffa!<E049><E003 10> With this attitude, <E049><E003 10><E164 81 71 1 2 8 0 2 1><E118 81 1.2><E139 81><E025 2>we get-a nowhere, <E003 6>uh?", "...Uffa !<E049><E003 10> Avec une attitude pareille, <E049><E003 10><E164 81 71 1 2 8 0 2 1><E118 81 1.2><E139 81><E025 2>on n'ira nulle part, <E003 6>hein ?");
                s = s.Replace("(He's really-a sulking now...)", "(Le voilà qui boude pour de bon...)");
                s = s.Replace("This confidential document was obtained directly from\r\nScotland Yard.", "Ce document confidentiel a été obtenu directement auprès\r\nde Scotland Yard.");
                s = s.Replace("It records an entry from the inspector's private diary\r\ndated the day before the incident.", "Il reproduit une note du carnet privé de l'inspecteur,\r\nen date de la veille des faits.");
                s = s.Replace("It reads, <E049><E003 10><E025 3><E330>‘Lime Street, <E049><E003 8>Red-Headed League, <E049><E003 8>Undercover.’", "On peut y lire : <E049><E003 10><E025 3><E330>« Lime Street, <E049><E003 8>Ligue des Rouquins, <E049><E003 8>Sous couverture. »");
                s = s.Replace("Ah!<E049><E003 10> I have the answer!", "Ah !<E049><E003 10> J'ai trouvé la solution !");
                s = s.Replace("Maybe there was another, <E049><E003 5><E164 81 67 1 2 8 0 2 1><E025 1>similar event in the park on\r\nthe day in question, <E049><E003 14><E025 2><E341><E338>ay?", "Peut-être qu'il y avait un autre événement <E049><E003 5><E164 81 67 1 2 8 0 2 1><E025 1>similaire dans le parc\r\nce jour-là, <E049><E003 14><E025 2><E341><E338>non ?");
                s = s.Replace("Zat is ridiculous.", "C'est ridicule.");
                s = s.Replace("(There's no question that Inspector Gregson was\r\ninvestigating the Red-Headed League.)", "(Il ne fait aucun doute que l'inspecteur Gregson\r\nenquêtait sur la Ligue des Rouquins.)");
                s = s.Replace("(Which means <E003 10><E025 2><E338><E341>it's quite possible that's when he was\r\nkilled!)", "(Ce qui signifie <E003 10><E025 2><E338><E341>qu'il a très bien pu être assassiné\r\nà ce moment-là !)");
                s = s.Replace("Very well.<E049><E003 10> <E025 2>The defence may proceed with the\r\ncross-examination now.", "Très bien.<E049><E003 10> <E025 2>La défense peut entamer son contre-interrogatoire.");
                s = s.Replace("Ah.<E049><E003 10> <E025 1><E169 1 0><E145 1 65><E003 5><E346>Yes, <E049><E003 10>My Lord!<E169 1 3>", "Ah.<E049><E003 10> <E025 1><E169 1 0><E145 1 65><E003 5><E346>Bien, <E049><E003 10>Votre Honneur !<E169 1 3>");
                return s;
            };

            // [6] BB\script\output\_sce03_c105_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Man in the Photograph –", "– L'homme sur la photographie –");
                return s;
            };

            // [7] BB\script\output\_sce03_c105_0030_eng#4
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("We 'ad more zan one thousand red-'eaded people\r\nassemble in ze park on Lime Street zat day.", "Nous avons réuni plus d'un millier de rouquins dans le\r\nparc de Lime Street ce jour-là.");
                return s;
            };

            // [8] BB\script\output\_sce03_c105_0030_eng#5
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("But I don't recall the man in this a-photograph.\r\nAy, capo?", "Mais je ne me souviens pas de l'homme sur cette photo.\r\nPas vrai, capo ?");
                return s;
            };

            // [9] BB\script\output\_sce03_c105_0030_eng#6
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("Non, I don't remember 'im. And obviously 'e is dead now.\r\nBut I assure you, 'e was not in ze park.", "Non, je ne me rappelle pas de lui. Et visiblement, il est mort.\r\nMais je vous assure qu'il n'était pas dans le parc.");
                return s;
            };

            // [10] BB\script\output\_sce03_c105_0030_eng#7
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Allora! This victim is-a nothing to do with us!", "Allora ! Cette victime n'a rien à voir avec nous !");
                return s;
            };

            // [11] BB\script\output\_sce03_c105_0030_eng#8
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("You 'ave a lot to answer for, Peppino. It is your fault zat\r\nwe got caught in ze first place.", "Tu as des comptes à rendre, Peppino. C'est de ta faute si\r\nnous nous sommes fait pincer pour commencer.");
                return s;
            };

            // [12] BB\script\output\_sce03_c105_0030_eng#9
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("(They haven't told us much we didn't already know...)", "(Ils ne nous ont pas appris grand-chose de nouveau...)");
                s = s.Replace("What do you think, <E003 4><E025 3>Mr Naruhodo?", "Qu'en pensez-vous, <E003 4><E025 3>monsieur Naruhodo ?");
                s = s.Replace("Well, <E003 8>if it was in the inspector's diary, <E003 8>it seems likely that\r\nhe must have gone to Lime Street that day.", "Eh bien, <E003 8>si c'était noté dans le carnet de l'inspecteur, <E003 8>il semble\r\nplus que probable qu'il s'est bien rendu à Lime Street ce jour-là.");
                s = s.Replace("And yet <E145 9 4><E118 9 0.8><E003 8>these two both claim they didn't see him...", "Et pourtant, <E145 9 4><E118 9 0.8><E003 8>ces deux-là affirment ne pas l'avoir vu...");
                s = s.Replace("I have to say...", "Je dois bien reconnaître...");
                s = s.Replace("...they don't appear to be telling lies.", "...qu'ils n'ont pas l'air de mentir.");
                s = s.Replace("Well, <E003 8>they are experts in deception, <E003 4>don't forget.<E003 12>\r\n<E333>Sounding plausible is their speciality.", "N'oubliez pas <E003 8>que ce sont des professionnels de l'escroquerie.<E003 12>\r\n<E333>Avoir l'air convaincant est leur fonds de commerce.");
                s = s.Replace("They may be lying simply to avoid being implicated in\r\nthis case as well.", "Ils mentent peut-être simplement pour ne pas être également\r\nimpliqués dans cette sombre affaire.");
                s = s.Replace("Surely if they were truly experts in deception,<E049><E003 10> <E333>they\r\nwouldn't have been caught.", "S'ils étaient réellement des experts de la supercherie,<E049><E003 10> <E333>ils\r\nne se seraient pas fait attraper.");
                s = s.Replace("(Well, <E003 6>yes, <E003 8>you do have a point there...)", "(C'est... <E003 6>vrai, <E003 8>vous marquez un point...)");
                s = s.Replace("...It seems to me like <E145 9 0>we need more information.", "...Il me semble que <E145 9 0>nous avons besoin de plus d'informations.");
                s = s.Replace("Definitely!", "Absolument !");
                return s;
            };

            // [13] BB\script\output\_sce03_c105_0030_eng#10
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("A thousand people?<E049><E003 10> <E145 1 85><E025 2>That's a very big crowd.", "Un millier de personnes ?<E049><E003 10> <E145 1 85><E025 2>C'est une foule colossale.");
                s = s.Replace("It was quite a spectacle.<E049><E003 8> Red-'eads 'ad come from all over\r\nze capital.", "C'était un bien beau spectacle.<E049><E003 8> Les rouquins affluaient de tous\r\nles recoins de la capitale.");
                s = s.Replace("Si, <E049><E003 4><E164 81 69 1 2 6 0 0 1><E139 81>the capo here, <E049><E003 8><E025 1>he has the magnetismo animale, <E049><E003 8><E025 2>ay?", "Si, <E049><E003 4><E164 81 69 1 2 6 0 0 1><E139 81>le capo ici présent, <E049><E003 8><E025 1>il a le magnetismo animale, <E049><E003 8><E025 2>hein ?");
                s = s.Replace("Nobody else could attract-a so many people.", "Personne d'autre ne pouvait attirer autant de monde.");
                s = s.Replace("If I could be born again, <E049><E003 8><E025 1>I would be the capo!", "Si je pouvais renaître, <E049><E003 8><E025 1>je voudrais être le capo !");
                s = s.Replace("All zose people wanted was ze money, <E003 4>Peppino.<E049><E003 12><E145 80 75>\r\n<E025 3>Ze four pounds per week.", "Tout ce que voulaient ces gens, c'était l'argent, <E003 4>Peppino.<E049><E003 12><E145 80 75>\r\n<E025 3>Les quatre livres par semaine.");
                s = s.Replace("Are you suggesting <E049><E003 10><E145 15 7><E025 2>that you spoke personally with all one\r\nthousand applicants?", "Êtes-vous en train de prétendre <E049><E003 10><E145 15 7><E025 2>que vous avez parlé en personne\r\navec ce millier de candidats ?");
                s = s.Replace("Oui, <E049><E003 6>oui, <E049><E003 10><E025 2>zat we did.<E049><E003 12> <E333>Because every one of zem paid us\r\nfive shillings.", "Oui, <E049><E003 6>oui, <E049><E003 10><E025 2>absolument.<E049><E003 12> <E333>Parce que chacun d'entre eux nous a payé\r\ncinq shillings.");
                s = s.Replace("We take-a their names and we take-a their money!<E145 80 64><E003 10>\r\nAnd we take-a their addresses as well.", "On a pris leurs noms et on a pris leur argent !<E145 80 64><E003 10>\r\nEt on a pris leurs adresses aussi.");
                s = s.Replace("Then I tell them we take-a some days to let them know\r\nby-a post, <E049><E003 8><E025 1>e finito!<E049><E003 10> <E025 3>Maybe...<E003 8><E025 2>two minuti a person?", "Ensuite je leur disais qu'on leur répondrait par la poste d'ici\r\nquelques jours, <E049><E003 8><E025 1>e finito !<E049><E003 10> <E025 3>Peut-être...<E003 8><E025 2>deux minuti par personne ?");
                s = s.Replace("We start early in the morning, <E049><E003 6>and we stop late in the\r\nnight.", "On a commencé tôt le matin, <E049><E003 6>et on s'est arrêtés tard dans\r\nla nuit.");
                s = s.Replace("So...<E003 12><E330>you earnt five thousand shillings in one day?!<E049><E003 12>\r\n<E025 1><E007>(That's a small fortune!)", "Alors... <E003 12><E330>vous avez empoché cinq mille shillings en un seul jour ?!<E049><E003 12>\r\n<E025 1><E007>(Mais c'est une petite fortune !)");
                s = s.Replace("Who'd have thought there were a thousand such gullible\r\nred-heads in London to start with.", "Qui aurait cru qu'il y avait un millier de rouquins aussi crédules\r\nà Londres pour commencer.");
                s = s.Replace("(One of whom <E003 8><E025 3>was a great detective with chemically\r\naltered hair...)", "(Et parmi eux, <E003 8><E025 3>un grand détective aux cheveux chimiquement\r\nmodifiés...)");
                return s;
            };

            // [14] BB\script\output\_sce03_c105_0030_eng#11
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("He doesn't look at all familiar?", "Il ne vous rappelle absolument rien ?");
                s = s.Replace("No, <E003 8><E025 2>I don't-a think so.<E049><E003 8> <E025 2>And this is a wig, <E003 4>ay?<E049><E003 12>\r\n<E025 1>He was trying to trick us!", "Non, <E003 8><E025 2>je ne pense pas.<E049><E003 8> <E025 2>Et en plus c'est une perruque, <E003 4>non ?<E049><E003 12>\r\n<E025 1>Il essayait de nous rouler !");
                s = s.Replace("I do not like the people <E049><E003 4><E025 1><E145 81 65><E139 81><E333>who are trying to trick the other\r\npeople!", "Je n'aime pas les gens <E049><E003 4><E025 1><E145 81 65><E139 81><E333>qui essaient d'escroquer les autres\r\ngens !");
                s = s.Replace("...Says the con artist.", "...Dit l'escroc.");
                s = s.Replace("If between them they interviewed a thousand people with\r\nred hair...", "S'ils ont reçu à eux deux un bon millier de personnes rousses...");
                s = s.Replace("...it would be unreasonable to expect them to remember\r\nevery face.", "...il serait déraisonnable d'attendre d'eux qu'ils retiennent\r\nchaque visage.");
                s = s.Replace("No no, <E049><E003 6>signore.<E049><E003 12>\r\n<E025 2>I may be small...", "Non non, <E049><E003 6>signore.<E049><E003 12>\r\n<E025 2>Je suis peut-être petit...");
                s = s.Replace("...but my memory is very large!<E049><E003 12>\r\nI never forget a thing!", "...mais ma mémoire est gigantesque !<E049><E003 12>\r\nJe n'oublie jamais rien !");
                s = s.Replace("In my opinion, <E049><E003 8>I do not think this-a man was in the park.", "À mon avis, <E049><E003 8>je ne pense pas que cet homme était dans le parc.");
                s = s.Replace("(But he's not going to give the court a definite,<E003 4> it seems.)", "(Mais il ne semble pas prêt à l'affirmer formellement,<E003 4> visiblement.)");
                s = s.Replace("Eh, <E003 2>capo?<E049><E003 10> <E025 1>You didn't see a man like this, <E003 6><E025 2>uh?", "Hein, <E003 2>capo ?<E049><E003 10> <E025 1>Tu n'as pas vu un homme comme ça, <E003 6><E025 2>pas vrai ?");
                return s;
            };

            // [15] BB\script\output\_sce03_c105_0030_eng#12
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("But according to what you've said, <E049><E003 6><E145 1 0><E118 1 1.4><E149 1 0 8><E003 6>you spoke with a\r\nthousand or more people that day.", "Mais d'après ce que vous avez dit, <E049><E003 6><E145 1 0><E118 1 1.4><E149 1 0 8><E003 6>vous avez parlé avec un\r\nmillier de personnes ce jour-là.");
                s = s.Replace("Oui, <E049><E003 8>zat's true.<E049><E003 10> <E025 2><E333>My eyes were burning by ze end of ze\r\nday.", "Oui, <E049><E003 8>c'est exact.<E049><E003 10> <E025 2><E333>J'en avais les yeux qui me brûlaient à la fin\r\nde la journée.");
                s = s.Replace("Surely then, <E049><E003 6>you can't actually remember every single\r\nface.<E049><E003 8> <E145 1 21><E025 3>How are you so certain...", "Dès lors, <E049><E003 6>vous ne pouvez pas vous remémorer chaque\r\nvisage individuellement.<E049><E003 8> <E145 1 21><E025 3>Comment pouvez-vous être si sûrs...");
                s = s.Replace("...that this particular man <E006>wasn't present<E005>?", "...que cet homme en particulier <E006>n'était pas présent<E005> ?");
                s = s.Replace("Normally, <E003 6>the red hair is very distinctive, <E003 4>ay?", "Normalement, <E003 6>les cheveux roux, ça saute aux yeux, <E003 4>non ?");
                s = s.Replace("But not when you have one thousand red-heads crowding\r\naround.<E049><E003 8> <E025 1>Then it is just <E006>an eyesore<E005>!", "Mais pas quand vous avez un millier de rouquins agglutinés tout\r\nautour.<E049><E003 8> <E025 1>Là, ça devient juste <E006>une horreur pour les yeux<E005> !");
                s = s.Replace("But if there was some other <E006>information<E005> you could-a give\r\nus, <E049><E003 8><E025 2>maybe then we would recall.", "Mais s'il y avait une autre <E006>information<E005> que vous pourriez nous donner,\r\n<E049><E003 8><E025 2>peut-être qu'on s'en souviendrait.");
                s = s.Replace("Zat is not ze line, <E003 6>Peppino.", "Ce n'est pas ce qui est convenu, <E003 6>Peppino.");
                s = s.Replace("Remember, <E049><E003 8>we do not remember 'im.<E049><E003 4><E145 81 81><E003 8>\r\n<E025 2>We are sure of zat fact, <E049><E003 6>uh?", "Rappelle-toi : <E049><E003 8>nous ne nous souvenons pas de lui.<E049><E003 4><E145 81 81><E003 8>\r\n<E025 2>Nous en sommes absolument certains, <E049><E003 6>d'accord ?");
                s = s.Replace("If zere was a man wiz a red 'airpiece, <E049><E003 6><E025 2>but 'is moustache\r\ndid not match ze colour...", "S'il y avait eu un homme avec un postiche roux, <E049><E003 6><E025 2>mais dont la moustache\r\nn'était pas de la même couleur...");
                s = s.Replace("...zen I do not sink I could 'ave forgotten 'im.", "...alors je ne pense pas que j'aurais pu l'oublier.");
                s = s.Replace("(Kazuma said these two had only been shown that\r\nphotograph and they'd been told nothing else at all.)", "(Kazuma a affirmé qu'on leur avait seulement montré cette\r\nphotographie et qu'on ne leur avait rien dit d'autre.)");
                s = s.Replace("(But what if I fed them just one other detail about the\r\nvictim.<E003 10> <E025 3>For example...)", "(Mais que se passerait-il si je leur donnais un autre détail sur\r\nla victime ?<E003 10> <E025 3>Par exemple...)");
                return s;
            };

            // [16] BB\script\output\_sce03_c105_0030_eng#13
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("I can certainly appreciate that just knowing the man had\r\nred hair wouldn't help you remember in this situation.", "Je conçois parfaitement que savoir qu'il avait des cheveux\r\nroux ne vous aide guère dans cette situation.");
                s = s.Replace("But what if I told you <E049><E003 8><E025 3><E330>that the man's name was Gregson?", "Mais si je vous disais <E049><E003 8><E025 3><E330>que cet homme s'appelait Gregson ?");
                s = s.Replace("Ze man in ze photograph <E049><E003 8><E025 3>is a Monsieur Gregson?", "L'homme sur la photographie <E049><E003 8><E025 3>s'appelait monsieur Gregson ?");
                s = s.Replace("Yes.", "Oui.");
                s = s.Replace("Names, <E049><E003 8>they are boring!<E049><E003 10>\r\n<E025 1>I did not-a listen to any of them.", "Les noms, <E049><E003 8>c'est ennuyeux !<E049><E003 10>\r\n<E025 1>Je n'en ai écouté aucun.");
                s = s.Replace("...Oh.", "...Oh.");
                s = s.Replace("It was not a real interview, <E003 4>uh?<E049><E003 10> It was just for-a show.<E049><E003 10>\r\nWhy would I remember the names?", "Ce n'était pas un vrai entretien, <E003 4>non ?<E049><E003 10> C'était juste pour le spectacle.<E049><E003 10>\r\nPourquoi je me souviendrais des noms ?");
                s = s.Replace("Zat's right.<E049><E003 10> <E025 2>Zis changes nothing.", "C'est exact.<E049><E003 10> <E025 2>Cela ne change rien.");
                s = s.Replace("Ze man in ze photograph was not zere.<E049><E003 12>\r\n<E025 3>As we 'ave already said.", "L'homme sur la photo n'était pas là.<E049><E003 12>\r\n<E025 3>Comme nous l'avons déjà précisé.");
                s = s.Replace("I see...", "Je vois...");
                s = s.Replace("Hm...<E003 10> <E145 15 7><E144 15><E169 15 3><E025 2>It seems there's little to be gained from pursuing\r\nthis point further.", "Hm...<E003 10> <E145 15 7><E144 15><E169 15 3><E025 2>Il semble qu'il n'y ait rien à tirer en poursuivant\r\nsur cette voie.");
                s = s.Replace("Tell zem again what you said before, <E049><E003 4><E025 2>Peppino.", "Répète-leur ce que tu as dit tout à l'heure, <E049><E003 4><E025 2>Peppino.");
                s = s.Replace("Si, <E003 6>capo, <E003 8>si!<E049><E003 10> <E025 1>I say it again and again!", "Si, <E003 6>capo, <E003 8>si !<E049><E003 10> <E025 1>Je le répète autant de fois qu'il faut !");
                return s;
            };

            // [17] BB\script\output\_sce03_c105_0030_eng#14
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("I can certainly appreciate that just knowing the man had\r\nred hair wouldn't help you remember in this situation.", "Je conçois parfaitement que savoir qu'il avait des cheveux\r\nroux ne vous aide guère dans cette situation.");
                s = s.Replace("But what if I told you that the man in the red hairpiece<E049><E003 10>\r\n<E333>was actually <E006>a detective<E005>?", "Mais si je vous disais que l'homme au postiche roux<E049><E003 10>\r\n<E333>était en réalité <E006>un détective<E005> ?");
                s = s.Replace("Ze man in ze photograph?<E049><E003 8> <E025 3>A detective?", "L'homme sur la photo ?<E049><E003 8> <E025 3>Un détective ?");
                s = s.Replace("Yes.", "Oui.");
                s = s.Replace("It would appear he found your notice in the paper\r\nsuspicious and decided to investigate incognito.", "Il semblerait qu'il ait jugé votre annonce suspecte et ait\r\ndécidé d'enquêter sous couverture.");
                s = s.Replace("...Sorry, <E049><E003 10><E025 2>but zis changes nothing.", "...Désolé, <E049><E003 10><E025 2>mais cela ne change rien.");
                s = s.Replace("No detective came to ze park.<E049><E003 12>\r\n<E025 2>I am certain of zat.", "Aucun détective n'est venu dans le parc.<E049><E003 12>\r\n<E025 2>J'en suis absolument convaincu.");
                s = s.Replace("I see...", "Je vois...");
                s = s.Replace("In any case, <E049><E003 8>if such a man 'ad come incognito...", "De toute façon, <E049><E003 8>si un tel homme était venu sous couverture...");
                return s;
            };

            // [18] BB\script\output\_sce03_c105_0030_eng#15
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("...'e wouldn't 'ave just said, <E049><E003 8><E025 3><E333><E145 81 79>‘I am a detective,’<E049><E003 8> would 'e?", "...il n'aurait pas dit bêtement : <E049><E003 8><E025 3><E333><E145 81 79>« Je suis un détective »,<E049><E003 8> n'est-ce pas ?");
                s = s.Replace("Well...<E003 10>no, <E049><E003 8><E025 2>I suppose not.", "Eh bien... <E003 10>non, <E049><E003 8><E025 2>j'imagine que non.");
                s = s.Replace("Hm...<E003 12><E025 3><E145 15 0><E169 15 3>sound logic, <E049><E003 6><E025 2>I must agree.", "Hm... <E003 12><E025 3><E145 15 0><E169 15 3>c'est parfaitement logique, <E049><E003 6><E025 2>je dois en convenir.");
                s = s.Replace("Tell zem again what you said before, <E049><E003 4><E025 2>Peppino.", "Répète-leur ce que tu as dit tout à l'heure, <E049><E003 4><E025 2>Peppino.");
                s = s.Replace("Ay?<E049><E003 8> Ah!<E049><E003 12> <E342><E025 2>Si, capo, <E003 8>si!<E049><E003 6> <E025 1><E145 81 65><E003 6><E025 1><E335>\r\n<E341>Is-a best we move on!", "Hein ?<E049><E003 8> Ah !<E049><E003 12> <E342><E025 2>Si, capo, <E003 8>si !<E049><E003 6> <E025 1><E145 81 65><E003 6><E025 1><E335>\r\n<E341>C'est mieux de passer à la suite !");
                return s;
            };

            // [19] BB\script\output\_sce03_c105_0030_eng#16
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("I can certainly appreciate that just knowing the man had\r\nred hair wouldn't help you remember in this situation.", "Je conçois parfaitement que savoir qu'il avait des cheveux\r\nroux ne vous aide guère dans cette situation.");
                s = s.Replace("But what if I told you <E049><E003 8><E330>that the man was always munching\r\non a packet of fish and chips?", "Mais que diriez-vous si je vous apprenais <E049><E003 8><E330>que cet homme grignotait\r\nconstamment un cornet de fish and chips ?");
                s = s.Replace("Do you remember a man who was eating incessantly?", "Vous souvenez-vous d'un individu mangeant sans arrêt ?");
                s = s.Replace("Not really.<E049><E003 10> <E025 2>I was looking only at ze 'eads of ze applicants.", "Pas vraiment.<E049><E003 10> <E025 2>Je ne regardais que la tête des postulants.");
                s = s.Replace("I wouldn't 'ave noticed ze fish and chips any more zan ze\r\ncaviar and smoked salmon.", "Je n'aurais pas remarqué de fish and chips plus que du\r\ncaviar ou du saumon fumé.");
                s = s.Replace("Or-a spaghetti!<E049><E003 10> <E025 2>Me, <E049><E003 10><E346><E025 1>I love the spaghetti!", "Ou des spaghettis !<E049><E003 10> <E025 2>Moi, <E049><E003 10><E346><E025 1>j'adore les spaghettis !");
                s = s.Replace("Really?<E003 8> I had no idea...", "Vraiment ?<E003 8> Je n'en avais aucune idée...");
                s = s.Replace("Tell zem again what you said before, <E049><E003 4><E025 2>Peppino.", "Répète-leur ce que tu as dit tout à l'heure, <E049><E003 4><E025 2>Peppino.");
                s = s.Replace("Si, <E003 6>capo, <E003 8>si!<E049><E003 10> <E025 1>I say it again and again!", "Si, <E003 6>capo, <E003 8>si !<E049><E003 10> <E025 1>Je le répète autant de fois qu'il faut !");
                return s;
            };

            // [20] BB\script\output\_sce03_c105_0030_eng#17
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("But we only have your word for that.", "Mais nous n'avons que votre parole pour appuyer cela.");
                s = s.Replace("Si, <E049><E003 10>but what else can we do, <E003 6><E341><E025 2>uh?", "Si, <E049><E003 10>mais que voulez-vous qu'on fasse d'autre, <E003 6><E341><E025 2>hein ?");
                s = s.Replace("(True...)", "(C'est vrai...)");
                s = s.Replace("Uffa!<E049><E003 16> <E025 1>We are not having much-a fun these days!", "Uffa !<E049><E003 16> <E025 1>On ne rigole pas beaucoup ces temps-ci !");
                s = s.Replace("First we are arrested, <E003 6>then we are shown the horrible\r\npicture of a dead man...", "D'abord on nous arrête, <E003 6>ensuite on nous montre l'horrible\r\nphoto d'un mort...");
                s = s.Replace("...and now you question every single-a thing we say!<E049><E003 12>\r\n<E331>WE are the victims here!", "...et maintenant vous remettez en doute chaque mot qu'on dit !<E049><E003 12>\r\n<E331>C'est NOUS les victimes ici !");
                s = s.Replace("Ay, <E003 4>capo?", "Pas vrai, <E003 4>capo ?");
                s = s.Replace("No, <E049><E003 5><E145 1 85><E003 5><E025 2><E330>you were caught carrying out a plot to swindle\r\nhundreds of innocent people.", "Non, <E049><E003 5><E145 1 85><E003 5><E025 2><E330>vous avez été pris en train d'escroquer des\r\ncentaines de pauvres innocents.");
                s = s.Replace("Hmph!<E049><E003 10> You had to bring that up, <E003 4>ay?<E049><E003 12>\r\n<E025 1>It's not fair!", "Hmph !<E049><E003 10> Il fallait que vous ressortiez ça, <E003 4>hein ?<E049><E003 12>\r\n<E025 1>C'est pas juste !");
                return s;
            };

            // [21] BB\script\output\_sce03_c105_0030_eng#18
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("What do you mean by that?", "Qu'entendez-vous par là ?");
                s = s.Replace("Cavolo!<E049><E003 12> <E025 1><E164 81 81 1 2 6 0 0 1><E139 81>You promised not to say!<E049><E003 12>\r\n<E025 2>Ay, <E003 4>capo?", "Cavolo !<E049><E003 12> <E025 1><E164 81 81 1 2 6 0 0 1><E139 81>Tu avais promis de te taire !<E049><E003 12>\r\n<E025 2>Pas vrai, <E003 4>capo ?");
                s = s.Replace("After we 'ad taken all ze money zat day, <E003 4>we should 'ave\r\nleft ze country.", "Après avoir amassé tout cet argent ce jour-là, <E003 4>nous aurions dû\r\nquitter le pays.");
                s = s.Replace("Zat was my plan.", "C'était cela, mon plan.");
                s = s.Replace("I left ze purchasing of ze tickets for ze ferry to\r\nDunkerque to my companion 'ere.", "J'avais confié l'achat des billets de ferry pour\r\nDunkerque à mon compagnon que voici.");
                s = s.Replace("But 'e bought zem for ze wrong day.", "Mais il s'est trompé de date.");
                s = s.Replace("Oops.", "Oups.");
                s = s.Replace("Si, <E049><E003 8>but is an easy mistake-a to make-a, <E003 4>uh?<E049><E003 4>\r\n<E025 1><E164 81 69 1 2 6 0 0 1><E139 81>The first, <E003 6>the thirty-first...", "Si, <E049><E003 8>mais c'est une erreur facile à faire, <E003 4>non ?<E049><E003 4>\r\n<E025 1><E164 81 69 1 2 6 0 0 1><E139 81>Le premier, <E003 6>le trente-et-un...");
                s = s.Replace("Bof!<E003 16> I 'ave no sympathy for you!", "Bof !<E003 16> Je n'ai aucune pitié pour toi !");
                s = s.Replace("We were an 'ole day late for ze boat because of your\r\nstupidity!", "Nous avions un jour entier de retard pour le bateau à cause de\r\nta bêtise !");
                s = s.Replace("And it's only because of zis, <E049><E003 8>zat ze so-called<E049><E003 6><E160 80><E606><E145 81 70> ‘great<E049><E003 8>\r\nred-'eaded detective’ caught us!", "Et c'est uniquement pour cela <E049><E003 8>que le prétendu<E049><E003 6><E160 80><E606><E145 81 70> « grand<E049><E003 8>\r\ndétective rouquin » nous a coincés !");
                s = s.Replace("Capo...<E049><E003 10><E025 2>you know what I think?", "Capo...<E049><E003 10><E025 2>tu sais ce que je pense ?");
                s = s.Replace("This is the work of God!<E049><E003 12>\r\n<E025 2><E164 81 81 1 2 6 0 0 1>Is <E006>a holy punishment<E005>, <E003 4>ay?", "C'est la volonté divine !<E049><E003 12>\r\n<E025 2><E164 81 81 1 2 6 0 0 1>C'est <E006>un châtiment sacré<E005>, <E003 4>non ?");
                s = s.Replace("Peppino, <E049><E003 10><E025 3>for ze last time...", "Peppino, <E049><E003 10><E025 3>pour la dernière fois...");
                s = s.Replace("...zis is not 'oly punishment.<E049><E003 12>\r\n<E025 2><E238>Zis is <E006>'olly your fault<E005>!", "...ce n'est pas un châtiment divin.<E049><E003 12>\r\n<E025 2><E238>C'est <E006>entièrement de ta faute<E005> !");
                s = s.Replace("Don't blame God for your unholy mistakes.", "Ne rejette pas tes fautes impardonnables sur le Bon Dieu.");
                s = s.Replace("You are makin' me sick wiz anger!", "Tu me rends malade de rage !");
                s = s.Replace("Maybe I make-a mistake-a.<E049><E003 8> <E025 1><E335>But when is time to\r\neat-a the pasta, <E003 6>no one is-a faster!", "J'ai peut-être fait une erreur.<E049><E003 8> <E025 1><E335>Mais quand il s'agit\r\nde manger les pâtes, <E003 6>personne n'est plus rapide !");
                s = s.Replace("(And I've seen the evidence...)", "(Et j'en ai vu les preuves concrètes...)");
                return s;
            };

            // [22] BB\script\output\_sce03_c105_0030_eng#21
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("Something to add, <E049><E003 8><E025 2><E338><E341>Mr de Rossi?!", "Quelque chose à ajouter, <E049><E003 8><E025 2><E338><E341>monsieur de Rossi ?!");
                s = s.Replace("Che?<E003 10> Si, <E049><E003 6><E164 81 69 1 2 8 0 2 1><E139 81><E025 1>I am always adding something!<E049><E003 12>\r\n<E025 2>Parmesan, <E003 6>olive oil, <E003 6>pepper...", "Che ?<E003 10> Si, <E049><E003 6><E164 81 69 1 2 8 0 2 1><E139 81><E025 1>j'ajoute toujours quelque chose !<E049><E003 12>\r\n<E025 2>Du parmesan, <E003 6>de l'huile d'olive, <E003 6>du poivre...");
                s = s.Replace("What I mean is...<E003 10><E145 1 21><E025 3>did you not agree with your friend's\r\nlast remark by any chance?", "Ce que je voulais dire, c'est...<E003 10><E145 1 21><E025 3>n'étiez-vous pas en désaccord\r\navec la dernière remarque de votre ami, par hasard ?");
                s = s.Replace("Eh?<E049><E003 10> <E025 1>What-a did he just-a say?<E049><E003 20>\r\n<E145 81 68><E025 2><E330>About the detective?", "Eh ?<E049><E003 10> <E025 1>Qu'est-ce qu'il vient de dire ?<E049><E003 20>\r\n<E145 81 68><E025 2><E330>À propos du détective ?");
                s = s.Replace("Yes, <E049><E003 10><E025 3>that.", "Oui, <E049><E003 10><E025 3>exactement.");
                s = s.Replace("Keep your mouth shut, Peppino!<E049><E003 20>\r\n<E025 2>You 'ave said enough already.", "La ferme, Peppino !<E049><E003 20>\r\n<E025 2>Tu en as déjà bien trop dit.");
                s = s.Replace("But-a why, <E003 4>capo?<E049><E003 10>\r\n<E025 2>What is the problem?", "Mais pourquoi, <E003 4>capo ?<E049><E003 10>\r\n<E025 2>Quel est le problème ?");
                s = s.Replace("There was a man who said-a, <E049><E003 15><E164 81 69 1 2 7 0 0 1><E139 81><E025 1>‘I am an inspector from\r\nScotland Yard.’", "Il y avait un homme qui a dit : <E049><E003 15><E164 81 69 1 2 7 0 0 1><E139 81><E025 1>« Je suis un inspecteur\r\nde Scotland Yard. »");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("Good Lord!", "Bonté divine !");
                s = s.Replace("Ordaaar!<E003 5> Ordaaar!<E003 5> Orrrdaaar!", "Du caaaalme !<E003 5> Du caaaalme !<E003 5> Du caaaalme !");
                s = s.Replace("Explain this volte-face in your testimony, <E049><E003 10><E025 2><E335>witness!", "Expliquez ce revirement dans votre déposition, <E049><E003 10><E025 2><E335>témoin !");
                s = s.Replace("Is simple.<E049><E003 10> A man who was at-a the park said to us <E049><E003 6><E003 3>that he\r\nwas an inspect–", "C'est simple.<E049><E003 10> Un homme au parc nous a dit <E049><E003 6><E003 3>qu'il\r\nétait inspect–");
                s = s.Replace("Zere was no such man.", "Il n'y a jamais eu un tel individu.");
                s = s.Replace("Ma dai!<E049><E003 10> <E025 2>What are you saying, <E003 4>capo?<E049><E003 10>\r\nHave you forgotten, <E003 4>ay?", "Ma dai !<E049><E003 10> <E025 2>Qu'est-ce que tu racontes, <E003 4>capo ?<E049><E003 10>\r\nTu as oublié, <E003 4>hein ?");
                s = s.Replace("I 'ave forgotten nothing.<E049><E003 15>\r\n<E145 80 75><E117 80 5><E025 1><E332><E145 81 70>Nobody like zis came to ze park.", "Je n'ai rien oublié du tout.<E049><E003 15>\r\n<E145 80 75><E117 80 5><E025 1><E332><E145 81 70>Personne de ce genre n'est venu dans ce parc.");
                s = s.Replace("Basta, <E003 6>capo, <E003 8>basta!<E049> <E145 80 64><E118 80 0.6><E003 10><E025 3>You beat me at-a many things,<E049><E003 6> but not\r\ntwo:<E049><E003 10> <E025 1><E335>the memory and the meals!", "Basta, <E003 6>capo, <E003 8>basta !<E049> <E145 80 64><E118 80 0.6><E003 10><E025 3>Tu me bats sur plein de trucs,<E049><E003 6> mais pas\r\nsur deux :<E049><E003 10> <E025 1><E335>la mémoire et la bouffe !");
                s = s.Replace("Like I said, <E049><E003 8>when is time to eat-a the pasta,<E049><E003 12><E145 81 68><E117 81 5><E025 1><E346> no one is-a\r\nfaster!", "Comme je l'ai dit, <E049><E003 8>quand il s'agit d'avaler les pâtes,<E049><E003 12><E145 81 68><E117 81 5><E025 1><E346> personne n'est\r\nplus rapide !");
                s = s.Replace("But you are inferior to me in every other way...<E049><E003 12>\r\n<E025 1><E341>so shut up!", "Mais tu m'es inférieur en tout autre point...<E049><E003 12>\r\n<E025 1><E341>alors tais-toi !");
                s = s.Replace("Uuurgh...", "Arrrgh...");
                s = s.Replace("Trop tard...<E049><E003 10>\r\n<E025 3><E239><E006>Ze damage is done<E005>...", "Trop tard...<E049><E003 10>\r\n<E025 3><E239><E006>Le mal est fait<E005>...");
                s = s.Replace("Indeed it is, <E003 6>sir.", "En effet, <E003 6>monsieur.");
                s = s.Replace("Oui, <E049><E003 10><E025 2>zere was a man who came to ze park and 'e said 'e\r\nwas an inspector from Scotland Yard.", "Oui, <E049><E003 10><E025 2>un homme s'est présenté au parc en disant qu'il\r\nétait inspecteur à Scotland Yard.");
                s = s.Replace("'Owever!<E049><E003 12> <E025 2>'E looked nothing like ze man in ze photograph.<E049><E003 12>\r\n<E025 2>'E was <E006>someone else<E005>!", "Cependant !<E049><E003 12> <E025 2>Il ne ressemblait en rien à l'homme sur la photo.<E049><E003 12>\r\n<E025 2>C'était <E006>quelqu'un d'autre<E005> !");
                s = s.Replace("How can you be so sure?", "Comment pouvez-vous en être si sûr ?");
                s = s.Replace("Because!<E049><E003 12> <E025 2>To start wiz, <E049><E003 6><E060 0 132 0 0>'is face was completely different.", "Parce que !<E049><E003 12> <E025 2>Pour commencer, <E049><E003 6><E060 0 132 0 0>son visage était entièrement différent.");
                s = s.Replace("Si...<E003 8><E025 2>is true, <E049><E003 6>is true.<E049><E003 15>\r\n<E330>The man who came was-a younger.", "Si...<E003 8><E025 2>c'est vrai, <E049><E003 6>c'est vrai.<E049><E003 15>\r\n<E330>L'homme qui est venu était plus jeune.");
                s = s.Replace("His-a face was clean-shaven.<E049><E003 8> <E025 2>His-a eyes were sadder.<E049><E003 10>\r\n<E044>His-a chin was thinner.", "Il était rasé de près.<E049><E003 8> <E025 2>Ses yeux étaient plus tristes.<E049><E003 10>\r\n<E044>Son menton était plus fin.");
                s = s.Replace("No resemblance whatsoever, then!", "Aucune ressemblance, donc !");
                s = s.Replace("Anyway, <E049><E003 8>I was not going to be fooled.<E049><E003 10>\r\nI took ze obvious precaution and said to 'im...", "Quoi qu'il en soit, <E049><E003 8>je n'allais pas me laisser berner.<E049><E003 10>\r\nJ'ai pris les précautions d'usage et lui ai dit...");
                s = s.Replace("...‘If you are really a detective, <E049><E003 8>show us ze proof!’", "...« Si vous êtes vraiment détective, <E049><E003 8>montrez-nous une preuve ! »");
                s = s.Replace("Si, <E003 6>si, <E003 8>the capo here, <E049><E003 10>he doesn't take-a no nonsense, <E003 4>ay?", "Si, <E003 6>si, <E003 8>le capo ici présent, <E049><E003 10>il ne se laisse pas faire, <E003 4>hein ?");
                s = s.Replace("But 'e was well prepared.<E049><E003 12><E025 3><E238> 'E said 'e 'ad <E006>identification<E005>.", "Mais il était bien préparé.<E049><E003 12><E025 3><E238> Il a affirmé posséder une <E006>pièce d'identité<E005>.");
                s = s.Replace("I-<E049><E003 8>Identification?<E049><E003 10>\r\n<E025 2><E145 1 0><E118 1 0.5><E003 10>You mean, <E049><E003 6>official police inspector's identification?", "U-<E049><E003 8>Une pièce d'identité ?<E049><E003 10>\r\n<E025 2><E145 1 0><E118 1 0.5><E003 10>Vous voulez dire, <E049><E003 6>la carte officielle d'inspecteur de police ?");
                s = s.Replace("That is most unconvincing.", "C'est bien peu convaincant.");
                s = s.Replace("Sorry, <E049><E003 6>My Lord?", "Pardon, <E049><E003 6>Votre Honneur ?");
                s = s.Replace("Counsel, <E049><E003 8>no incognito inspector would offer his\r\nidentification for inspection.<E049><E003 12> <E145 15 5><E330>It's quite <E006>out of the question<E005>.", "Maître, <E049><E003 8>aucun inspecteur sous couverture ne sortirait ainsi sa\r\ncarte pour vérification.<E049><E003 12> <E145 15 5><E330>C'est totalement <E006>hors de question<E005>.");
                s = s.Replace("Definitely.<E049><E003 10> <E025 2>Why would he expose his true identity?", "Sans le moindre doute.<E049><E003 10> <E025 2>Pourquoi exposerait-il sa véritable identité ?");
                s = s.Replace("Clearly <E049><E003 8><E025 2>ze papers were fake.", "De toute évidence, <E049><E003 8><E025 2>ses papiers étaient faux.");
                s = s.Replace("Certo, <E003 4>capo!<E049><E003 12> You are a genius!", "Certo, <E003 4>capo !<E049><E003 12> Tu es un génie !");
                s = s.Replace("As we say in-a Italia, <E049><E003 8><E025 1><E338><E341>it takes a thief to recognise another,<E049><E003 6>\r\n<E025 3>ay?", "Comme on dit chez nous en Italie : <E049><E003 8><E025 1><E338><E341>il faut un voleur pour en reconnaître un autre,<E049><E003 6>\r\n<E025 3>pas vrai ?");
                s = s.Replace("And what happened <E049><E003 4><E025 2><E145 1 85><E003 6>after he announced that he was a\r\ndetective?", "Et que s'est-il passé <E049><E003 4><E025 2><E145 1 85><E003 6>après qu'il a annoncé être\r\nun détective ?");
                s = s.Replace("'E became very annoying.<E049><E003 10>\r\n'E said, <E049><E003 8>‘You are under investigation.’", "Il est devenu très agaçant.<E049><E003 10>\r\nIl a dit : <E049><E003 8>« Vous faites l'objet d'une enquête. »");
                s = s.Replace("So I took 'is papers from 'im and chased 'im out of ze park.", "Alors je lui ai arraché ses papiers et je l'ai chassé du parc.");
                s = s.Replace("It was fantastico!<E049><E003 15>\r\n<E060 0 137 1 0>And look, <E049><E003 10><E333>here is-a the identification!", "C'était fantastico !<E049><E003 15>\r\n<E060 0 137 1 0>Et regardez, <E049><E003 10><E333>voici la carte d'identité !");
                s = s.Replace("So you stole it from the man?", "Vous l'avez donc volée à cet homme ?");
                s = s.Replace("He had it-a coming!<E049><E003 10>\r\nHe made us very scared.", "Il l'avait bien cherché !<E049><E003 10>\r\nIl nous a fait très peur.");
                s = s.Replace("But he was-a not who he said-a he was!", "Mais il n'était pas celui qu'il prétendait être !");
                s = s.Replace("Indeed, <E049><E003 8><E025 2>the person described does not appear to have\r\nbehaved as a true inspector would.", "En vérité, <E049><E003 8><E025 2>la personne décrite ne semble guère s'être\r\ncomportée comme un véritable inspecteur.");
                s = s.Replace("However, <E049><E003 8>I believe it would be prudent for these\r\nidentification papers to be entered into evidence.", "Néanmoins, <E049><E003 8>j'estime qu'il serait prudent de verser\r\nces papiers d'identité aux pièces à conviction.");
                s = s.Replace("Hmph.<E169 81 3><E049><E003 8> But I-a like them!", "Hmph.<E169 81 3><E049><E003 8> Mais je les aimais bien !");
                s = s.Replace("The inspector's identification has been\r\nentered into the Court Record.", "La carte d'inspecteur a été versée\r\nau dossier de l'affaire.");
                s = s.Replace("Now, <E049><E003 8><E025 2><E145 15 5><E003 6><E341><E338>let us return to the witnesses' testimony.", "À présent, <E049><E003 8><E025 2><E145 15 5><E003 6><E341><E338>revenons à la déposition des témoins.");
                return s;
            };

            // [23] BB\script\output\_sce03_c105_0030_eng#22
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rousseau!<E003 10>\r\nIs something wrong?", "Monsieur de Rousseau !<E003 10>\r\nQuelque chose ne va pas ?");
                s = s.Replace("I was just considering something.", "J'étais simplement en train de réfléchir.");
                s = s.Replace("About the testimony?<E049><E003 10>\r\nDid something that was just said jar with you?", "Au sujet de la déposition ?<E049><E003 10>\r\nQuelque chose qui vient d'être dit vous a contrarié ?");
                s = s.Replace("Non.<E049><E003 12> <E025 2><E330>I was considering my next cunning plan.", "Non.<E049><E003 12> <E025 2><E330>Je songeais à mon prochain plan de génie.");
                s = s.Replace("Fantastico, capo!<E049><E003 14><E025 1><E346> The Hairlarious Brothers are-a gonna be\r\nback in action, <E003 6><E025 2>ay?", "Fantastico, capo !<E049><E003 14><E025 1><E346> Les Frères Hilaroux vont reprendre\r\ndu service, <E003 6><E025 2>hein ?");
                s = s.Replace("I sink my next enterprise will be an exclusive club\r\ncalled...<E003 10><E025 3><E043>ze Four-Eyed League!", "Je songe que ma prochaine entreprise sera un club très sélect\r\nnommé... <E003 10><E025 3><E043>la Ligue des Binoclards !");
                s = s.Replace("...Kindly discuss your upcoming criminal activities once\r\nyou're back in your cell.", "...Ayez l'amabilité de discuter de vos futurs délits une fois\r\nde retour dans votre cellule.");
                return s;
            };

            // [24] BB\script\output\_sce03_c105_0030_eng#23
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#23"] = (en) => {
                string s = en;
                s = s.Replace("Mr de Rossi!<E049><E003 10>\r\nDo you have something to say?", "Monsieur de Rossi !<E049><E003 10>\r\nAvez-vous quelque chose à ajouter ?");
                s = s.Replace("Che?<E003 8> What?", "Che ?<E003 8> Quoi ?");
                s = s.Replace("You looked as though you were thinking something...<E003 10>\r\n<E341>whilst eating a mouthful of pasta.", "Vous aviez l'air de méditer sur quelque chose...<E003 10>\r\n<E341>tout en engloutissant une bouchée de pâtes.");
                s = s.Replace("Ah, <E003 8>si.<E003 10> <E025 2>I was-a thinking...", "Ah, <E003 8>si.<E003 10> <E025 2>J'étais en train de me dire...");
                s = s.Replace("...perhaps my hair is this-a colour because I eat too much\r\nBolognese sauce.", "...que mes cheveux sont peut-être de cette couleur parce que je mange trop\r\nde sauce bolognaise.");
                s = s.Replace("...No comment.", "...Sans commentaire.");
                return s;
            };

            // [25] BB\script\output\_sce03_c105_0030_eng#30
            entryTranslators[@"BB\script\output\_sce03_c105_0030_eng#30"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour forger une\r\nopinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront point divulguées au grand public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Néanmoins, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle <E049><E003 8><E025 3>ou dans tout autre prétoire.");
                s = s.Replace("B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de cette\r\ncour, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };

            // [26] BB\script\output\_sce03_c105_0040_eng#2
            entryTranslators[@"BB\script\output\_sce03_c105_0040_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I wonder <E049><E003 4><E145 1 85><E003 4><E025 2>if I could ask you to examine this identification\r\nbook very closely...", "Je me demande <E049><E003 4><E145 1 85><E003 4><E025 2>si vous accepteriez d'examiner ce carnet d'identité\r\ntrès attentivement...");
                s = s.Replace("...Miss Lestrade?", "...mademoiselle Lestrade ?");
                s = s.Replace("Why Miss Lestrade?", "Pourquoi mademoiselle Lestrade ?");
                s = s.Replace("What is your intention here, <E049><E003 6><E025 3>Counsel?", "Quelle est votre intention, <E049><E003 6><E025 3>maître ?");
                s = s.Replace("Is this really a fake, <E049><E003 8>or is it genuine?<E049><E003 10> That's the question.<E049><E003 10><E145 1 11><E003 15>\r\n<E025 2><E330>...Which we can't answer ourselves.", "Est-ce réellement un faux, <E049><E003 8>ou bien est-il authentique ?<E049><E003 10> C'est toute la question.<E049><E003 10><E145 1 11><E003 15>\r\n<E025 2><E330>...À laquelle nous ne saurions répondre nous-mêmes.");
                s = s.Replace("Don't be ridiculous.", "Ne soyez pas ridicule.");
                s = s.Replace("No Scotland Yard detective would allow his –<E049><E003 6> or her –<E049><E003 8>\r\n<E025 2>identification to be stolen.", "Aucun détective de Scotland Yard ne se laisserait dérober sa\r\ncarte d'identité.");
                s = s.Replace("That...<E003 12><E025 3><E342><E338><E341>that...", "C'est... <E003 12><E025 3><E342><E338><E341>c'est...");
                s = s.Replace("That IS the boss's!<E049><E003 15>\r\n<E025 3>...No question about it.", "C'EST celle du patron !<E049><E003 15>\r\n<E025 3>...Ça fait pas un pli !");
                s = s.Replace("It can't be!", "C'est impossible !");
                s = s.Replace("As I suspected.", "Exactement comme je le pressentais.");
                s = s.Replace("The ‘undercover detective’ who attended the Red-Headed\r\nLeague's enrolment on the day in question...", "Le « détective sous couverture » venu s'inscrire à la Ligue\r\ndes Rouquins ce fameux jour...");
                s = s.Replace("...was the real Inspector Gregson <E049><E003 8><E025 1><E164 1 9 1 2 8 0 2 1><E139 1>carrying out an\r\nincognito investigation!", "...n'était autre que le véritable inspecteur Gregson <E049><E003 8><E025 1><E164 1 9 1 2 8 0 2 1><E139 1>menant une\r\nenquête incognito !");
                s = s.Replace("Zu...<E003 20>\r\n<E025 1><E145 80 71><E118 80 1.2><E606>Zut aloooooors!", "Zu...<E003 20>\r\n<E025 1><E145 80 71><E118 80 1.2><E606>Zut aloooooors !");
                s = s.Replace("O-<E003 6><E025 1><E603>Ordaaar!<E003 6> Ordaaar!", "Du <E003 6><E025 1><E603>caaaalme !<E003 6> Du caaaalme !");
                s = s.Replace("But...<E003 10><E025 2>if the boss 'ad 'is identification stolen...", "Mais... <E003 10><E025 2>si l'patron s'était fait chourer ses papiers...");
                s = s.Replace("...'e would've reported it straight away.", "...y l'aurait signalé illico presto.");
                s = s.Replace("I mean, <E049><E003 8><E025 2>'e was always on at me about it.<E049><E003 12>\r\nIf ya lose summat, <E003 6>report it at once, <E049><E003 8><E025 2>'e'd say.", "J'veux dire, <E049><E003 8><E025 2>y m'serinait tout l'temps avec ça.<E049><E003 12>\r\nSi tu paumes un truc, <E003 6>déclare-le direct, <E049><E003 8><E025 2>qu'y disait.");
                s = s.Replace("Could it be, then...", "Serait-il envisageable, dans ce cas...");
                s = s.Replace("...that the inspector <E049><E003 8><E330><E025 3>was physically unable to report it?", "...que l'inspecteur <E049><E003 8><E330><E025 3>ait été dans l'impossibilité physique de le déclarer ?");
                s = s.Replace("Physically...<E049><E003 12> <E145 81 75><E118 81 1.4><E025 1><E604>Ay?!<E049><E003 14>\r\nWhat are you-a saying?", "Physiquement... <E049><E003 12> <E145 81 75><E118 81 1.4><E025 1><E604>Hein ?!<E049><E003 14>\r\nQu'est-ce que vous racontez ?");
                s = s.Replace("Unable to...?<E049><E003 15>\r\n<E145 112 8><E117 112 12><E149 112 0 4><E333><E342><E025 2>You're, <E049><E003 8><E025 1><E338><E341>you're not suggesting...?", "Dans l'impossibilité de... ?<E049><E003 15>\r\n<E145 112 8><E117 112 12><E149 112 0 4><E333><E342><E025 2>Vous... <E049><E003 8><E025 1><E338><E341>vous ne suggérez tout de même pas... ?");
                s = s.Replace("Yes!<E049><E003 12> <E239>It's quite possible <E049><E003 12><E346><E025 1>that he was <E006>killed<E005> before he had\r\nthe chance to report his identification stolen!", "Si !<E049><E003 12> <E239>Il est fort probable <E049><E003 12><E346><E025 1>qu'il ait été <E006>tué<E005> avant même d'avoir\r\neu l'opportunité de signaler le vol de sa carte !");
                s = s.Replace("No!", "Non !");
                s = s.Replace("Ordaaar!<E003 4> Ordaaar!<E003 4> Ordaaaaaar!!!", "Du caaaalme !<E003 4> Du caaaalme !<E003 4> Du caaaalme !!!");
                s = s.Replace("The defence posits <E049><E003 8><E025 2>that the victim was killed the day\r\nbefore his body was discovered, <E049><E003 8>at <E006>a different location<E005>.", "La défense soutient <E049><E003 8><E025 2>que la victime a été assassinée la veille\r\nde la découverte de sa dépouille, <E049><E003 8>dans <E006>un tout autre lieu<E005>.");
                s = s.Replace("Do you two...<E049><E003 16><E025 1><E046><E145 80 71><E136 81 67 5><E118 81 1.3><E149 81 4 4>have anything to say about that?!", "Avez-vous tous les deux...<E049><E003 16><E025 1><E046><E145 80 71><E136 81 67 5><E118 81 1.3><E149 81 4 4>quelque chose à déclarer là-dessus ?!");
                s = s.Replace("Uèèèèèèèèèèèè!", "Ouaaaah !");
                s = s.Replace("I know-a nothing!<E049><E003 12> Uèèèèèèèèè!<E049><E003 8><E160 81><E118 81 1.5><E139 81>\r\n<E046>I done-a nothing!<E049><E003 12> Uèèèèèèèèè!", "J'en sais rien du tout !<E049><E003 12> Ouaaaah !<E049><E003 8><E160 81><E118 81 1.5><E139 81>\r\n<E046>J'ai rien fait du tout !<E049><E003 12> Ouaaaah !");
                s = s.Replace("Pull yourself together, <E049><E003 8>Peppino!", "Reprends-toi immédiatement, <E049><E003 8>Peppino !");
                s = s.Replace("Mon Dieu!<E049><E003 12> <E025 2><E341>You can behave a little more like a master\r\ncriminal zan zat, <E003 6><E342>non?", "Mon Dieu !<E049><E003 12> <E025 2><E341>Tu pourrais te comporter un peu plus comme un grand\r\ncriminel que cela, <E003 6><E342>non ?");
                s = s.Replace("Uèèèèèèèèè!<E003 14> <E160 81><E118 81 1.5><E139 81><E046>Now I wish I had-a returned to Italia!", "Ouaaaah !<E003 14> <E160 81><E118 81 1.5><E139 81><E046>Maintenant je regrette de ne pas être rentré en Italie !");
                s = s.Replace("Uèèèèèèèèèèèèèèèèèè!", "Ouaaaaaaaaaaaaah !");
                s = s.Replace("Stop crying, Peppino, <E049><E003 8><E025 1><E342>please!<E049><E003 20>\r\n<E239><E145 80 72><E003 30><E341><E025 3>Otherwise <E049><E003 8><E025 4>I...<E003 14><E342>I...", "Cesse de pleurnicher, Peppino, <E049><E003 8><E025 1><E342>je t'en prie !<E049><E003 20>\r\n<E239><E145 80 72><E003 30><E341><E025 3>Sinon... <E049><E003 8><E025 4>je...<E003 14><E342>je...");
                s = s.Replace("Lumme!<E049><E003 18> <E046>Stop yer whinin' an' start talkin'!", "La barbe !<E049><E003 18> <E046>Arrête de chouiner et commence à causer !");
                s = s.Replace("Well...<E049><E003 12><E025 2><E145 15 5>I believe the court will need to hear your story in\r\nconsiderably greater detail.", "Bien...<E049><E003 12><E025 2><E145 15 5>j'estime que la cour doit entendre vos explications de\r\nmanière bien plus détaillée.");
                s = s.Replace("I know-a nothing!<E003 12> Uèèèèèèèèè!<E003 16>\r\n<E606>I done-a nothing!<E003 12> Uèèèèèèèèè!", "J'en sais rien !<E003 12> Ouaaaah !<E003 16>\r\n<E606>J'ai rien fait !<E003 12> Ouaaaah !");
                s = s.Replace("But you will tell everything!<E049><E003 12>\r\n<E025 3><E145 112 6><E118 112 0.7><E003 15><E330>...Or face the worst possible outcome.", "Vous allez pourtant tout nous dire !<E049><E003 12>\r\n<E025 3><E145 112 6><E118 112 0.7><E003 15><E330>...Ou en subir les pires conséquences.");
                s = s.Replace("Ugh...<E003 12> <E025 3><E341>Uuuuuugh...", "Ugh...<E003 12> <E025 3><E341>Uuuuugh...");
                s = s.Replace("You will dry your eyes and testify again...", "Vous allez sécher vos larmes et témoigner à nouveau...");
                s = s.Replace("...about these identification papers, <E049><E003 12><E025 1><E346><E145 15 5>and the precise\r\ncircumstances under which you came by them!", "...concernant cette carte d'identité, <E049><E003 12><E025 1><E346><E145 15 5>et les circonstances\r\nexactes dans lesquelles elle s'est retrouvée en votre possession !");
                s = s.Replace("(For crying out loud...)", "(Grand Dieu, achevez-moi...)");
                return s;
            };

            // [27] BB\script\output\_sce03_c106_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c106_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("– The Detective and the Identification –", "– Le détective et la carte d'identité –");
                s = s.Replace("Ze, <E049><E003 8>ze truth is, <E049><E003 8>we took 'im prisoner <E049><E003 8><E025 2><E330>and kept 'im for ze\r\nnight at our secret 'ideout.", "La, <E049><E003 8>la vérité, <E049><E003 8>c'est que nous l'avons fait prisonnier <E049><E003 8><E025 2><E330>et l'avons gardé pour la\r\nnuit dans notre repaire secret.");
                s = s.Replace("Even though I didn't sink 'e was a real detective,<E049><E003 8> <E025 2>I, <E049><E003 10><E025 3><E338><E341>I was\r\ntoo scared to let 'im go zat day, <E049><E003 8>just in case.", "Même si je ne croyais guère qu'il fût un vrai détective,<E049><E003 8> <E025 2>j'ai... <E049><E003 10><E025 3><E338><E341>j'ai\r\neu trop peur de le relâcher ce jour-là, <E049><E003 8>au cas où.");
                s = s.Replace("We took the man's identification from him <E049><E003 10><E346>and shut-a him\r\nin the room next to ours!", "On a pris la carte d'identité de cet homme <E049><E003 10><E346>et on l'a enfermé\r\ndans la chambre à côté de la nôtre !");
                s = s.Replace("Zere might 'ave been a little tussle, <E049><E003 8>but we did 'im no\r\n'arm.<E049><E003 10> And ze next mornin', <E049><E003 6>we let 'im go.", "Il y a bien eu une petite empoignade, <E049><E003 8>mais on ne lui a fait aucun\r\nmal.<E049><E003 10> Et le lendemain matin, <E049><E003 6>on l'a laissé partir.");
                s = s.Replace("He spent-a the night in a nice room!<E049><E003 12> <E145 81 73><E118 81 1.3><E025 1><E045>It was-a nothing like\r\nprison really!<E049><E003 10> Uèèèèè!", "Il a passé la nuit dans une jolie chambre !<E049><E003 12> <E145 81 73><E118 81 1.3><E025 1><E045>Ça ne ressemblait pas du tout\r\nà une prison !<E049><E003 10> Ouaaah !");
                return s;
            };
        }
    }
}
