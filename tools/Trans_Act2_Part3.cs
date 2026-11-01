using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct2 {
    public partial class Program {
        public static void RegisterPart3() {
            // BB\script\output\\_sce02_c105_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("– Mr Lune's Balloons –", "– Les ballons de Signor Lune –");
                s = s.Replace("As I said, <E049><E003 8>Balthazar Lune is no liar!",
                              "Je le répète, <E049><E003 8>Balthazar Lune n'est pas un menteur !");
                s = s.Replace("All three of my balloons were carrying passengers. <E049><E003 8><E025 2>If they\r\nhad crashed, <E003 6>many people would have died!",
                              "Mes trois ballons transportaient des passagers. <E049><E003 8><E025 2>S'ils\r\ns'étaient écrasés, <E003 6>il y aurait eu une hécatombe !");
                s = s.Replace("But ya can't get away from the fact that a burnt-up bit o'\r\ngreen balloon fabric was found at the scene.",
                              "Mais vous n'pouvez pas nier qu'un bout d'toile de ballon vert\r\ncalciné a été retrouvé sur place.");
                s = s.Replace("The coppers at the Yard reckoned it was prob'ly some\r\nfirework or somethin'!",
                              "Les gars du Yard ont pensé qu'il s'agissait sans doute d'un feu d'artifice !");
                s = s.Replace("This stupido ragazzo is mistaken! <E049><E003 10><E025 1><E335>My balloons have the\r\nbest safety record in London!",
                              "Ce stupido ragazzo se trompe ! <E049><E003 10><E025 1><E335>Mes ballons ont la\r\nmeilleure réputation de sécurité de tout Londres !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0000_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c105_0000_eng#3"] = en => {
                string s = en;
                s = s.Replace("Hmmm...so your assertion is that the balloon this child\r\nsaw was not one of yours?",
                              "Hum... votre position est donc que le ballon aperçu par cet enfant n'était pas l'un des vôtres ?");
                s = s.Replace("Exactamente! None of my three balloons were green,<E049><E003 8> and none\r\nof them exploded!",
                              "Esattamente ! Aucun de mes trois ballons n'était vert,<E049><E003 8> et aucun n'a explosé !");
                s = s.Replace("Then where did that green balloon come from, <E003 4>and who\r\nwas flying it?",
                              "Dans ce cas, d'où venait ce ballon vert, <E003 4>et qui était aux commandes ?");
                s = s.Replace("That is for the police to discover, <E003 6>not me!",
                              "C'est à la police de le découvrir, <E003 6>pas à moi !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#2"] = en => {
                return en.Replace("– Mr Lune's Balloons –", "– Les ballons de Signor Lune –");
            };

            // BB\script\output\\_sce02_c105_0010_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#4"] = en => {
                return en.Replace("As I said, Balthazar Lune is no liar!", "Comme je l'ai dit, Balthazar Lune n'est pas un menteur !");
            };

            // BB\script\output\\_sce02_c105_0010_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#5"] = en => {
                string s = en;
                s = s.Replace("All three of my balloons were carrying passengers. If they\r\nhad crashed, many people would have died!",
                              "Mes trois ballons transportaient des passagers. S'ils s'étaient écrasés, il y aurait eu bien des morts !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#6"] = en => {
                string s = en;
                s = s.Replace("But ya can't get away from the fact that a burnt-up bit o'\r\ngreen balloon fabric was found at the scene.",
                              "Mais on n'peut pas esquiver le fait qu'un lambeau de toile de ballon vert brûlé a été retrouvé sur place.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#7"] = en => {
                string s = en;
                s = s.Replace("The coppers at the Yard reckoned it was prob'ly some\r\nfirework or somethin'!",
                              "Les flics du Yard ont supposé qu'c'était un restant de feu d'artifice !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#8
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#8"] = en => {
                string s = en;
                s = s.Replace("This stupido ragazzo is mistaken! My balloons have the\r\nbest safety record in London!",
                              "Ce stupido ragazzo se trompe ! Mes montgolfières affichent la sécurité la plus irréprochable de Londres !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#9
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#9"] = en => {
                string s = en;
                s = s.Replace("You couldn't just...have forgotten one, maybe?",
                              "N'auriez-vous pas... oublié un aérostat par hasard ?");
                s = s.Replace("Forget a balloon?! <E049><E003 8>A balloon is forty feet high!",
                              "Oublier un ballon ?! <E049><E003 8>Une montgolfière fait douze mètres de haut !");
                s = s.Replace("How does one forget such a thing?!", "Comment voulez-vous qu'on oublie une chose pareille ?!");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#10
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#10"] = en => {
                string s = en;
                s = s.Replace("It would be quite a catastrophe if they fell to the ground,\r\nwouldn't it?",
                              "Ce serait une terrible tragédie s'ils venaient à s'écraser, n'est-ce pas ?");
                s = s.Replace("Catastrophe?! <E003 6>It would ruin my business!", "Une tragédie ?! <E003 6>Ce serait la ruine de mon entreprise !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#11
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#11"] = en => {
                string s = en;
                s = s.Replace("I was surprised to find the piece of fabric still at the scene,\r\nInspector.",
                              "J'ai été surpris de trouver ce morceau de toile encore sur place, Inspecteur.");
                s = s.Replace("We don't collect every bit o' scrap after an explosion,\r\nsunshine!",
                              "On ramasse pas chaque confetti après une déflagration, mon garçon !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#12
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#12"] = en => {
                string s = en;
                s = s.Replace("There was considerable damage to the stage and\r\nsurrounding area, wasn't there?",
                              "Les dégâts sur l'estrade et aux alentours étaient considérables, n'est-ce pas ?");
                s = s.Replace("The explosion shattered timber and broke glass for fifty\r\nyards around!",
                              "Le souffle a pulvérisé le bois et brisé du verre à cinquante mètres à la ronde !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#13
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#13"] = en => {
                string s = en;
                s = s.Replace("You mean...the colour is wrong?", "Vous voulez dire... que la couleur ne colle pas ?");
                s = s.Replace("Mine are red, <E003 4>yellow and blue!<E049><E003 8> No green!",
                              "Les miens sont rouge, <E003 4>jaune et bleu !<E049><E003 8> Point de vert !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#14
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#14"] = en => {
                string s = en;
                s = s.Replace("But the prince took a photograph as proof.", "Mais le prince a pris une photographie en guise de preuve.");
                s = s.Replace("A photograph does not lie, <E003 4>Mr Lune.", "Une photographie ne ment pas, <E003 4>Signor Lune.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#15
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#15"] = en => {
                string s = en;
                s = s.Replace("Is something wrong, Master Gotts?", "Un problème, Monsieur Gotts ?");
                s = s.Replace("Ze camera...it does not lie!", "L'appareil photo... il ne ment chamais !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#17
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#17"] = en => {
                string s = en;
                s = s.Replace("If I may, Mr Lune!", "Si vous permettez, Signor Lune !");
                s = s.Replace("Could this green balloon have been an unlicensed craft?",
                              "Ce ballon vert n'aurait-il pas pu être un aéronef sans autorisation ?");
                s = s.Replace("Unlicensed in my airspace?! <E049><E003 8>Over my dead body!",
                              "Sans brevet dans mon espace aérien ?! <E049><E003 8>Il aurait fallu me passer sur le corps !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#18
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#18"] = en => {
                string s = en;
                s = s.Replace("Master Gotts, do you have something to say?", "Monsieur Gotts, avez-vous quelque chose à ajouter ?");
                s = s.Replace("Look closely at ze photograph! You will see!", "Regardez bien la photo ! Vous ferrez !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#19
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#19"] = en => {
                string s = en;
                s = s.Replace("Miss Lestrade!", "Mademoiselle Lestrade !");
                s = s.Replace("Did you see anyone operating that green balloon?",
                              "Avez-vous vu qui que ce soit manœuvrer ce ballon vert ?");
                s = s.Replace("Nah, <E003 4>not a soul! Just the big green envelope floating\r\nthere!",
                              "Nan, <E003 4>pas une âme qui vive ! Juste la grosse enveloppe verte qui flottait là !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#25
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#25"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                s = s.Replace("The court has heard enough on this matter.", "La cour en a assez entendu sur ce point.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0010_eng#27
            entryTranslators["BB\\script\\output\\_sce02_c105_0010_eng#27"] = en => {
                string s = en;
                s = s.Replace("(As I thought, Mr Lune's testimony just doesn't quite add\r\nup...)",
                              "(Comme je le pensais, le témoignage de Signor Lune ne colle pas tout à fait...)");
                s = s.Replace("(The photograph must contain the definitive contradiction!)",
                              "(La photographie doit contenir la contradiction irréfutable !)");
                return s;
            };

            // BB\script\output\\_sce02_c105_0020_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("Unfortunately, the photograph Master Gotts took can't\r\nsubstantiate that claim.",
                              "Hélas, la photo prise par le prince Gotts ne permet pas d'étayer cette affirmation.");
                s = s.Replace("Look here!", "Regardez ici !");
                s = s.Replace("The balloon in the sky isn't green at all...it's red!",
                              "Le ballon dans les airs n'est pas vert du tout... il est rouge !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0030_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0030_eng#2"] = en => {
                return en.Replace("(No, I can't let this opportunity slip away.)",
                                  "(Non, je ne peux pas laisser passer cette chance.)");
            };

            // BB\script\output\\_sce02_c105_0030_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c105_0030_eng#3"] = en => {
                return en.Replace("(What else can this photograph tell us?)",
                                  "(Que peut bien nous apprendre d'autre cette photo ?)");
            };

            // BB\script\output\\_sce02_c105_0030_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c105_0030_eng#4"] = en => {
                return en.Replace("(I'm really not sure that there is, but if I say there isn't, it's\r\nall over...)",
                                  "(Je n'en suis pas certain, mais si j'abandonne, tout est fini...)");
            };

            // BB\script\output\\_sce02_c105_0030_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c105_0030_eng#5"] = en => {
                string s = en;
                s = s.Replace("Ladies and gentlemen of the jury, wait!", "Mesdames et messieurs les jurés, attendez !");
                s = s.Replace("There is something else in this photograph!", "Il y a un autre détail crucial sur ce cliché !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#2"] = en => {
                string s = en;
                s = s.Replace("We're well past the point of mere possibilities.", "Nous avons largement dépassé le stade des simples suppositions.");
                s = s.Replace("The defence must present concrete facts.", "La défense doit présenter des faits tangibles.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#3"] = en => {
                string s = en;
                s = s.Replace("What exactly does this alleged clue in the photograph\r\nshow us?",
                              "Que montre exactement cet indice présumé sur la photo ?");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#4"] = en => {
                string s = en;
                s = s.Replace("The owner of the fourth balloon! That's what this\r\nphotograph reveals!",
                              "Le propriétaire du quatrième ballon ! Voilà ce que révèle ce cliché !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#5"] = en => {
                string s = en;
                s = s.Replace("The balloon's colour! That's what this photograph tells us!",
                              "La couleur du ballon ! Voilà ce que nous apprend cette photo !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#6"] = en => {
                string s = en;
                s = s.Replace("We can reasonably assume that the pictured balloon was\r\nused to stage the whole affair!",
                              "On peut raisonnablement penser que ce ballon a servi à monter toute cette mise en scène !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0040_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c105_0040_eng#7"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0050_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0050_eng#2"] = en => {
                string s = en;
                s = s.Replace("It would appear that this photograph requires closer\r\nexamination.",
                              "Il semblerait que cette photographie requière un examen plus approfondi.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0050_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c105_0050_eng#3"] = en => {
                string s = en;
                s = s.Replace("(If you look closely, it's plain enough to see.)",
                              "(En y regardant de plus près, cela saute aux yeux.)");
                return s;
            };

            // BB\script\output\\_sce02_c105_0050_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c105_0050_eng#4"] = en => {
                string s = en;
                s = s.Replace("Without a doubt...it's right here!", "Sans l'ombre d'un doute... c'est juste ici !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0050_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c105_0050_eng#5"] = en => {
                string s = en;
                s = s.Replace("The timing of this photograph can only be described as\r\nmiraculous.",
                              "Le moment auquel cette photo a été prise relève tout bonnement du miracle.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0050_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c105_0050_eng#6"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#2"] = en => {
                string s = en;
                s = s.Replace("If such evidence exists, Counsel, then for goodness' sake\r\npresent it!",
                              "Si une telle preuve existe, Maître, présentez-la donc sans tarder !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#3"] = en => {
                string s = en;
                s = s.Replace("Which evidence explains this mysterious streak of flame\r\nin the photograph?",
                              "Quelle pièce à conviction explique cette mystérieuse traînée de feu sur la photo ?");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#4"] = en => {
                string s = en;
                s = s.Replace("The true nature of the curious, slim streak of light is\r\nrevealed by this item!",
                              "La véritable nature de cet étrange éclat lumineux est révélée par cette pièce !");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#5"] = en => {
                string s = en;
                s = s.Replace("This was found hidden at the foot of a small ornamental\r\nstructure near the stage.",
                              "Ceci a été trouvé dissimulé au pied d'une structure ornementale près de l'estrade.");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#6"] = en => {
                string s = en;
                s = s.Replace("Let's assume, as I said, that the birdcage was hidden\r\nin the Crystal Tower all along...",
                              "Supposons, comme je l'affirme, que la cage était dissimulée dans la Tour de Cristal depuis le début...");
                return s;
            };

            // BB\script\output\\_sce02_c105_0060_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c105_0060_eng#7"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                return s;
            };

            // BB\script\output\\_sce02_c106_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c106_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("Mr Naruhodo...<E049><E003 15><E330><E025 2>I appreciate your efforts.<E049><E003 12>\r\nThank you.",
                              "Mr Naruhodo... <E049><E003 15><E330><E025 2>J'apprécie vos efforts.<E049><E003 12>\r\nMerci.");
                s = s.Replace("P-<E049><E003 10><E338><E342>Professor?!", "D-<E049><E003 10><E338><E342>Docteur ?!");
                s = s.Replace("But you can stop now.<E049><E003 15><E145 68 67>\r\n<E025 2>Just keep your mouth shut, please.",
                              "Mais vous pouvez cesser.<E049><E003 15><E145 68 67>\r\n<E025 2>Taisez-vous désormais, je vous en prie.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("What's all this about...<E049><E003 10><E025 3>Mr Harebrayne?",
                              "Que signifie cette comédie... <E049><E003 10><E025 3>Mr Lonron ?");
                s = s.Replace("I, <E003 5>Albert Harebrayne, <E049><E003 8><E025 2>hereby confess...",
                              "Moi, <E003 5>Samba Lonron, <E049><E003 8><E025 2>je passe aux aveux...");
                s = s.Replace("...that it...<E003 8> <E342><E025 3>That it was...<E049><E003 15>\r\n<E025 2><E343>That it was me <E049><E003 10><E164 68 77 1 2 8 0 2 1><E139 68>who stabbed Mr Odie Asman!",
                              "...que c'est... <E003 8><E342><E025 3>que c'est... <E049><E003 15>\r\n<E025 2><E343>que c'est moi <E049><E003 10><E164 68 77 1 2 8 0 2 1><E139 68>qui ai poignardé Mr Odie Asman !");
                s = s.Replace("Yes!<E003 10> It was me!<E049><E003 12> <E025 2>With my faithful friend and partner...<E049><E003 15>\r\n<E025 1><E145 68 71><E117 68 8><E046>Andrew the Screwdriver!",
                              "Oui !<E003 10> C'était moi !<E049><E003 12> <E025 2>Avec mon fidèle ami et associé...<E049><E003 15>\r\n<E025 1><E145 68 71><E117 68 8><E046>Andrew le Tournevis !");
                s = s.Replace("WHAT ARE YOU DO<E345>IIIIIING?!", "MAIS QU'EST-CE QUE VOUS FAIIIIIIITES ?!");
                s = s.Replace("Ordaaar!<E003 4> Ordaaar!<E003 4> Ordaaaaaar!!!", "Silence !<E003 4> Silence !<E003 4> Silence !!!");
                s = s.Replace("Defendant!<E049><E003 10> <E025 2>Explain this sudden confession!",
                              "Accusé !<E049><E003 10> <E025 2>Expliquez cet aveu impromptu !");
                s = s.Replace("Professor Harebrayne!<E049><E003 12>\r\n<E335>What are you talking about?!",
                              "Dr Samba Lonron !<E049><E003 12>\r\n<E335>Mais qu'est-ce qui vous prend ?!");
                s = s.Replace("It's<E025 7>...<E003 10><E025 2><E342><E338>it's what I've said all along!",
                              "C'est... <E025 7>...<E003 10><E025 2><E342><E338>ce que je répète depuis le départ !");
                s = s.Replace("I must protect <E341>my hypothesis!<E049><E003 10>\r\n<E025 2><E342><E338>And my precious machine!",
                              "Je dois défendre <E341>mon hypothèse !<E049><E003 10>\r\n<E025 2><E342><E338>Et ma précieuse machine !");
                s = s.Replace("You stand there and claim it was all a trick!<E049><E003 12>\r\n<E239><E145 68 70><E118 68 0.7><E025 2>All an elaborate prank!<E049><E003 8> But where's your proof?!",
                              "Vous êtes là à prétendre que ce n'était qu'un tour de passe-passe !<E049><E003 12>\r\n<E239><E145 68 70><E118 68 0.7><E025 2>Une supercherie montée de toutes pièces !<E049><E003 8> Mais où sont vos preuves ?!");
                s = s.Replace("No, <E049><E003 8>y-<E049><E003 6>you'd have to examine the machine if you wanted\r\nto prove it.<E049><E003 10> <E025 1><E338><E341>But then it would all be over!",
                              "Non, <E049><E003 8>i-il faudrait démonter la machine pour prouver cela.<E049><E003 10> <E025 1><E338><E341>Mais alors tout serait fichu !");
                s = s.Replace("My beautiful hypothesis would be laid bare...<E049><E003 15>\r\n<E086 5 31><E164 68 71 1 2 2 0 3 1><E139 68><E025 1>I mean, <E049><E003 8>the indignity of it!",
                              "Ma sublime découverte serait profanée...<E049><E003 15>\r\n<E086 5 31><E164 68 71 1 2 2 0 3 1><E139 68><E025 1>Quelle humiliation pour la science !");
                return s;
            };

            // BB\script\output\\_sce02_c106_0010_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c106_0010_eng#2"] = en => {
                string s = en;
                s = s.Replace("Well, Counsel...what is the defence's official position on\r\nthis matter?",
                              "Alors, Maître... quelle est la position officielle de la défense ?");
                s = s.Replace("Do you stand by your claim of trickery, <E003 6>or do you accept\r\nyour client's confession?",
                              "Maintenez-vous la thèse de la supercherie, <E003 6>ou acceptez-vous les aveux de votre client ?");
                return s;
            };

            // BB\script\output\\_sce02_c106_0020_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c106_0020_eng#2"] = en => {
                return en.Replace("You've been silent long enough!", "Vous êtes resté silencieux bien assez longtemps !");
            };

            // BB\script\output\\_sce02_c106_0020_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c106_0020_eng#3"] = en => {
                string s = en;
                s = s.Replace("The defence asserts...that the defendant's instantaneous\r\nkinesis was nothing more than an elaborate illusion!",
                              "La défense affirme... que la téléportation de l'accusé n'était rien de plus qu'une illusion savamment orchestrée !");
                return s;
            };

            // BB\script\output\\_sce02_c106_0020_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c106_0020_eng#4"] = en => en;

            // BB\script\output\\_sce02_c106_0020_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c106_0020_eng#5"] = en => {
                return en.Replace("Professor Harebrayne!", "Dr Samba Lonron !");
            };

            // BB\script\output\\_sce02_c106_0020_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c106_0020_eng#6"] = en => en;

            // BB\script\output\\_sce02_c106_0030_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c106_0030_eng#2"] = en => {
                string s = en;
                s = s.Replace("So it's true then...", "C'est donc vrai...");
                s = s.Replace("The machine that cost Mr Asman his life...<E003 8>was a fake.",
                              "La machine qui a coûté la vie à Mr Asman... <E003 8>n'était qu'un leurre.");
                s = s.Replace("The court orders the immediate forensic examination of the\r\nwreckage on the stage!",
                              "Le tribunal ordonne l'expertise scientifique immédiate des débris sur l'estrade !");
                s = s.Replace("Court is adjourned for today!", "L'audience est suspendue pour aujourd'hui !");
                return s;
            };

            // BB\script\output\\_sce02_c107_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c107_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("23rd October, 1:36 p.m.", "23 octobre, 13h36");
                s = s.Replace("The Old Bailey, Defendants' Antechamber", "Old Bailey, Antichambre des accusés");
                s = s.Replace("I was surprised alright!<E049><E003 12>\r\n<E025 2><E330>Especially when she threw me to the ground!",
                              "Surpris, je l'ai été !<E049><E003 12>\r\n<E025 2><E330>Surtout quand elle m'a projeté au sol !");
                s = s.Replace("Oh dear!<E003 12> I'm so sorry!", "Mon Dieu !<E003 12> Pardonnez-moi !");
                s = s.Replace("I, <E049><E003 8>I was just so happy to see you again that...<E049><E003 10><E330><E025 4>it sort of\r\nslipped out.",
                              "J-Je... <E049><E003 8>j'étais si heureuse de vous revoir que... <E049><E003 10><E330><E025 4>le geste m'a échappé.");
                s = s.Replace("(Maybe we could stick to more traditional displays of\r\nemotion in future...?)",
                              "(Peut-être pourrions-nous nous en tenir à des effusions plus traditionnelles à l'avenir... ?)");
                s = s.Replace("Susie's train was late into London Victoria this morning,<E049><E003 8>\r\nyou see.",
                              "Le train de Susato est arrivé en retard à la gare Victoria ce matin,<E049><E003 8>\r\ntu comprends.");
                s = s.Replace("But we made the coachman really whip the horses hard\r\nso she didn't miss the whole trial!",
                              "Mais on a fait cravacher le cocher pour qu'elle ne rate pas tout le procès !");
                s = s.Replace("I was watching from the gallery for a while, <E049><E003 8><E145 3 72><E003 10><E025 3>but in the\r\nend...<E049><E003 10><E025 3>I'm afraid I couldn't contain myself...",
                              "J'ai observé depuis les bancs du public pendant un moment, <E049><E003 8><E145 3 72><E003 10><E025 3>mais à la\r\nfin... <E049><E003 10><E025 3>je n'ai pas pu m'en empêcher...");
                s = s.Replace("Well, <E003 10><E330><E025 2>I'm glad you didn't.",
                              "Eh bien, <E003 10><E330><E025 2>je suis bien soulagé que vous soyez intervenue.");
                s = s.Replace("Having you at my side in court gives me the strength I\r\nneed to win.",
                              "Vous avoir à mes côtés à la barre me donne la force nécessaire pour vaincre.");
                s = s.Replace("So<E025 7>...<E145 3 64><E003 12><E341><E025 5>I'm, <E003 8>um, <E003 15><E025 2><E338><E342>delighted to see you...<E003 12><E025 2>back in London.",
                              "Alors<E025 7>... <E145 3 64><E003 12><E341><E025 5>je suis, <E003 8>euh... <E003 15><E025 2><E338><E342>infiniment heureux de vous revoir... <E003 12><E025 2>de retour à Londres.");
                s = s.Replace("Oh, <E049><E003 8><E025 2>you're too kind, <E049><E003 6>Mr Naruhodo!<E049><E003 12>\r\n<E025 2>I'm delighted to be here!",
                              "Oh, <E049><E003 8><E025 2>vous êtes trop bon, <E049><E003 6>Mr Naruhodo !<E049><E003 12>\r\n<E025 2>C'est un bonheur indicible d'être auprès de vous !");
                s = s.Replace("I hope I can continue to be of service to you.",
                              "J'espère pouvoir continuer à vous être utile.");
                s = s.Replace("Of course.<E003 12> So<E025 7>...<E003 10><E025 3>what's brought you back?",
                              "Naturellement.<E003 12> Mais<E025 7>... <E003 10><E025 3>qu'est-ce qui vous ramène ?");
                s = s.Replace("Did Professor Mikotoba not protest?",
                              "Le professeur Mikotoba n'a-t-il rien trouvé à y redire ?");
                s = s.Replace("Let's save all that conversation for when we're back at\r\nhome, <E049><E003 6><E025 2>shall we?",
                              "Gardons tout cela pour notre retour à la maison, <E049><E003 6><E025 2>d'accord ?");
                s = s.Replace("You know <E049><E003 12><E333>I've made one of my most special blends ever\r\nfor this special occasion!",
                              "Tu sais bien <E049><E003 12><E333>que j'ai concocté un de mes meilleurs thés pour fêter l'événement !");
                s = s.Replace("Oh, Iris, <E049><E003 8><E025 2>how wonderful!<E049><E003 12>\r\n<E025 2>I can't wait!",
                              "Oh, Iris, <E049><E003 8><E025 2>c'est merveilleux !<E049><E003 12>\r\n<E025 2>J'ai hâte de le goûter !");
                s = s.Replace("Susato-san was back in London.", "Susato-san était de retour à Londres.");
                s = s.Replace("It's hard to describe how happy that made me feel at the\r\ntime.<E003 10> <E025 3>But despite my elation...",
                              "Difficile de décrire à quel point cela me rendait heureux à cet instant.<E003 10> <E025 3>Mais malgré cette joie...");
                s = s.Replace("...our tale was about to take yet another extraordinary\r\nturn.",
                              "... notre aventure s'apprêtait à prendre un nouveau tournant extraordinaire.");
                return s;
            };
        }
    }
}

