using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorAct2 {
    public partial class Program {
        public static void RegisterPart2() {
            // BB\script\output\\_sce02_c102_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c102_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("– The Inconsistency Explained –", "– L'incohérence expliquée –");
                s = s.Replace("To be clear, <E049><E003 6>I'm still at the stage of gathering data in my\r\nresearch.",
                              "Qu'on se comprenne bien, <E049><E003 6>je n'en suis encore qu'à la collecte des données.");
                s = s.Replace("My hypothesis states <E049><E003 8><E025 3><E333>the kinesis cannot transport <E006>metal<E005>,\r\nthough.<E049><E003 8> <E025 2>Hence the metal weapon would have stayed put.",
                              "Mais mon hypothèse stipule <E049><E003 8><E025 3><E333>que la cinèse ne peut transporter le <E006>métal<E005>.<E049><E003 8>\r\n<E025 2>Par conséquent, l'arme métallique serait restée sur place.");
                s = s.Replace("In other words, <E049><E003 8>the point just raised by Mr Naruhodo<E049><E003 8> <E025 2><E333><E145 68 67>isn't\r\nan inconsistency at all.",
                              "En d'autres termes, <E049><E003 8>le point soulevé par Mr Naruhodo<E049><E003 8> <E025 2><E333><E145 68 67>n'est\r\nen rien une contradiction.");
                s = s.Replace("Mr Asman was the patron of my research.<E003 12>\r\nWithout him, <E003 6>my work wouldn't have been possible.",
                              "Mr Asman était le mécène de mes recherches.<E003 12>\r\nSans lui, <E003 6>mes travaux n'auraient jamais vu le jour.");
                s = s.Replace("Now I have a duty to protect the incredible machine that\r\nwe built together!",
                              "J'ai maintenant le devoir de protéger l'incroyable machine que\r\nnous avons bâtie ensemble !");
                return s;
            };

            // BB\script\output\\_sce02_c102_0000_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c102_0000_eng#3"] = en => {
                string s = en;
                s = s.Replace("So, <E049><E003 12><E025 2>the thrust of your testimony, <E003 4>Professor, <E049><E003 6><E025 5>is<E025 7>...?",
                              "Ainsi, <E049><E003 12><E025 2>la teneur de votre déposition, <E003 4>Docteur, <E049><E003 6><E025 5>serait<E025 7>... ?");
                s = s.Replace("...That based upon his hypothesis, <E049><E003 10><E025 3>metal objects cannot be\r\nmoved by this method of instantaneous kinesis.",
                              "...Qu'en vertu de son hypothèse, <E049><E003 10><E025 3>les objets métalliques ne peuvent\r\nêtre déplacés par ce procédé de téléportation.");
                s = s.Replace("In other words...?", "Autrement dit... ?");
                s = s.Replace("In other words, <E049><E003 8><E025 2>since the screwdriver is made of metal,<E049><E003 8>\r\neven if it remained lodged in the victim's chest...",
                              "Autrement dit, <E049><E003 8><E025 2>le tournevis étant en métal,<E049><E003 8>\r\nmême s'il était demeuré fiché dans le torse de la victime...");
                s = s.Replace("...its subsequent discovery on the stage despite the victim\r\nbeing found elsewhere <E049><E003 8><E025 3><E333>is not an inconsistency.",
                              "...sa présence sur l'estrade alors que la victime a atterri ailleurs\r\n<E049><E003 8><E025 3><E333>ne constitue nullement une anomalie.");
                s = s.Replace("And therefore...?", "Et par conséquent... ?");
                s = s.Replace("And therefore <E049><E003 8>Professor Albert Harebrayne <E049><E003 10><E025 1><E332>could still\r\nhave been the killer.",
                              "Et par conséquent, <E049><E003 8>le Dr Samba Lonron <E049><E003 10><E025 1><E332>demeure\r\nparfaitement en mesure d'être le meurtrier.");
                s = s.Replace("My great hypothesis holds, <E003 8>you see!",
                              "Ma fabuleuse théorie tient la route, <E003 8>vous voyez !");
                s = s.Replace("We, <E049><E003 8><E025 2>we had to make the cage used to contain the subject\r\nfrom wood for that very reason.",
                              "Nous <E049><E003 8><E025 2>avons dû fabriquer la cage en bois précisément\r\npour cette raison !");
                s = s.Replace("I was not addressing you, <E049><E003 6>witness!",
                              "Je ne m'adressais pas à vous, <E049><E003 6>témoin !");
                s = s.Replace("Um...<E003 8><E025 3>Professor Harebrayne...", "Euh... <E003 8><E025 3>Dr Samba Lonron...");
                s = s.Replace("Yes?", "Oui ?");
                s = s.Replace("Whose side are you on here?", "Mais de quel côté êtes-vous, à la fin ?");
                s = s.Replace("I don't take sides, <E049><E003 6>Mr Naruhodo!<E049><E003 12>\r\n<E025 1>No no no!",
                              "Je ne choisis aucun camp, <E049><E003 6>Mr Naruhodo !<E049><E003 12>\r\n<E025 1>Non, non et non !");
                s = s.Replace("I'm on the side of <E049><E003 10><E025 1><E346>SCIENCE!<E085 2 20>",
                              "Je suis du côté de la <E049><E003 10><E025 1><E346>SCIENCE !<E085 2 20>");
                s = s.Replace("And not only science, <E049><E003 8><E025 1><E335>TRUTH!",
                              "Et pas seulement de la science, de la <E049><E003 8><E025 1><E335>VÉRITÉ !");
                s = s.Replace("(He's quite something...)", "(Il est vraiment incroyable...)");
                s = s.Replace("Very well.<E049><E003 8> Proceed to the cross-examination, Counsel.",
                              "Très bien.<E049><E003 8> Passez au contre-interrogatoire, Maître.");
                s = s.Replace("Yes, <E049><E003 8><E145 1 65><E335>My Lord!", "Bien, <E049><E003 8><E145 1 65><E335>Votre Honneur !");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#2"] = en => {
                return en.Replace("– The Inconsistency Explained –", "– L'incohérence expliquée –");
            };

            // BB\script\output\\_sce02_c102_0010_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#4"] = en => {
                string s = en;
                s = s.Replace("To be clear, I'm still at the stage of gathering data in my\r\nresearch.",
                              "Qu'on se comprenne bien, je n'en suis encore qu'à la collecte des données.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#5"] = en => {
                string s = en;
                s = s.Replace("My hypothesis states the kinesis cannot transport metal,\r\nthough. Hence the metal weapon would have stayed put.",
                              "Mon hypothèse stipule que la cinèse ne peut transporter le métal.\r\nPar conséquent, l'arme métallique serait restée sur place.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#6"] = en => {
                string s = en;
                s = s.Replace("In other words, the point just raised by Mr Naruhodo isn't\r\nan inconsistency at all.",
                              "En d'autres termes, le point soulevé par Mr Naruhodo n'est en rien une contradiction.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#7"] = en => {
                string s = en;
                s = s.Replace("Mr Asman was the patron of my research.\r\nWithout him, my work wouldn't have been possible.",
                              "Mr Asman était le mécène de mes recherches.\r\nSans lui, mes travaux n'auraient jamais vu le jour.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#8
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#8"] = en => {
                string s = en;
                s = s.Replace("Now I have a duty to protect the incredible machine that\r\nwe built together!",
                              "J'ai maintenant le devoir de protéger l'incroyable machine que\r\nnous avons bâtie ensemble !");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#9
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#9"] = en => {
                string s = en;
                s = s.Replace("And yet your retort to my argument wasn't lacking in\r\nconfidence, <E003 6>Professor.",
                              "Pourtant votre réplique ne manquait nullement d'assurance, <E003 6>Docteur.");
                s = s.Replace("Confidence is the mother of all discovery, <E049><E003 6>Mr Naruhodo!",
                              "La confiance est la mère de toute découverte, <E049><E003 6>Mr Naruhodo !");
                s = s.Replace("You only get to test hypotheses in the first place because\r\nyou believe that they'll work!",
                              "On ne teste une théorie que parce qu'on croit fermement qu'elle fonctionnera !");
                s = s.Replace("You have to have complete confidence!",
                              "Il faut une foi inébranlable !");
                s = s.Replace("I suppose that's true.", "C'est sans doute vrai.");
                s = s.Replace("When your hypothesis is proven, <E049><E003 8>then you can publish it in\r\na journal.",
                              "Quand une théorie est prouvée, <E049><E003 8>on peut la publier dans une revue savante.");
                s = s.Replace("I had no intention of making this discovery public at\r\nthe Great Exhibition.",
                              "Je n'avais aucunement l'intention de rendre cette découverte publique à l'Exposition.");
                s = s.Replace("I just wanted to test it, <E049><E003 6>that's all.", "Je voulais seulement la tester, <E049><E003 6>c'est tout.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#10
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#10"] = en => {
                string s = en;
                s = s.Replace("Your ‘hypothesis’ states it? <E049><E003 8>So this isn't proven then?",
                              "Votre « hypothèse » le stipule ? <E049><E003 8>Ce n'est donc pas encore prouvé ?");
                s = s.Replace("Of course not!<E049><E003 12> It's an untested hypothesis!",
                              "Bien sûr que non !<E049><E003 12> C'est une hypothèse non vérifiée !");
                s = s.Replace("The laws of electromagnetism suggest that high-density\r\nconductive metals repel the transmission beam.",
                              "Les lois de l'électromagnétisme suggèrent que les métaux conducteurs denses repoussent le faisceau.");
                s = s.Replace("So the metal parts of the machine, <E003 6>the screwdrivers, <E003 6>the\r\ncopper wires<E025 7>...<E003 10>they would never be transported.",
                              "Donc les pièces en métal, <E003 6>les tournevis, <E003 6>les fils de cuivre<E025 7>...<E003 10> ne pouvaient pas être transportés.");
                s = s.Replace("And what about the clothes the victim was wearing?",
                              "Et qu'en est-il des vêtements que portait la victime ?");
                s = s.Replace("Wool, <E003 6>cotton, <E003 6>silk...<E003 8>organic matter is perfectly\r\ntransportable!",
                              "Laine, <E003 6>coton, <E003 6>soie... <E003 8>la matière organique est parfaitement transportable !");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#11
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#11"] = en => {
                string s = en;
                s = s.Replace("...You seem to be pleased by that.", "... Vous semblez ravi de cette déduction.");
                s = s.Replace("Of course I am!<E049><E003 10> The truth is always beautiful!",
                              "Bien sûr que je le suis !<E049><E003 10> La vérité est toujours admirable !");
                s = s.Replace("Even if that truth leads directly to the gallows?",
                              "Même si cette vérité vous mène tout droit à la potence ?");
                s = s.Replace("I would rather hang for the truth than walk free on a\r\nfalsehood!",
                              "Je préfère être pendu pour la vérité que libéré sur un mensonge !");
                s = s.Replace("(He's dangerously sincere...)", "(Il est d'une sincérité désarmante...)");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#12
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#12"] = en => {
                string s = en;
                s = s.Replace("How did you come to know Mr Asman in the first place?",
                              "Comment avez-vous fait la connaissance de Mr Asman au départ ?");
                s = s.Replace("He approached me in Germany.<E049><E003 8> Offered to finance everything.",
                              "Il est venu me trouver en Allemagne.<E049><E003 8> Il a proposé de tout financer.");
                s = s.Replace("He said he saw great commercial potential in instantaneous\r\nkinesis.",
                              "Il disait voir un immense potentiel commercial dans la cinèse instantanée.");
                s = s.Replace("Transporting goods across the empire in seconds...<E049><E003 10>a thrilling\r\nprospect for a businessman.",
                              "Transporter des marchandises à travers l'empire en quelques secondes...<E049><E003 10> une perspective enivrante pour un financier.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#13
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#13"] = en => {
                string s = en;
                s = s.Replace("When you say that you built the machine together, does\r\nthat mean Mr Asman helped with the construction?",
                              "Quand vous dites que vous avez bâti la machine ensemble, Mr Asman a-t-il participé à sa construction ?");
                s = s.Replace("He provided the capital, <E049><E003 6>I provided the intellect!",
                              "Il a apporté les capitaux, <E049><E003 6>j'ai fourni le génie !");
                s = s.Replace("And the materials were sourced from the finest suppliers\r\nin Europe.",
                              "Et les matériaux provenaient des meilleurs fournisseurs d'Europe.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#19
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#19"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                s = s.Replace("The jury has heard sufficient arguments.", "Le jury en a entendu assez.");
                return s;
            };

            // BB\script\output\\_sce02_c102_0010_eng#21
            entryTranslators["BB\\script\\output\\_sce02_c102_0010_eng#21"] = en => {
                string s = en;
                s = s.Replace("(That's the extent of the testimony then...",
                              "(Voilà donc où s'arrête son témoignage...)");
                s = s.Replace("(There must be some evidence to disprove his claim that\r\nmetal cannot be teleported!)",
                              "(Il doit exister une preuve contredisant son affirmation sur le métal !)");
                return s;
            };

            // BB\script\output\\_sce02_c102_0020_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c102_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("Professor Harebrayne, you say that according to your\r\nhypothesis, metal cannot be teleported...",
                              "Dr Samba Lonron, vous affirmez que d'après votre hypothèse, le métal ne peut être téléporté...");
                s = s.Replace("Take a look at this evidence!", "Regardez donc cette pièce à conviction !");
                s = s.Replace("The victim was wearing clothing with metallic fasteners\r\nand buttons!",
                              "La victime portait des vêtements dotés d'attaches et de boutons en métal !");
                s = s.Replace("And yet those metal items were found right there on the\r\ncorpse in the Crystal Tower!",
                              "Et pourtant, ces pièces métalliques ont bien été retrouvées sur le cadavre dans la Tour de Cristal !");
                s = s.Replace("Wha... WHAT?!", "Qu... QUOI ?!");
                s = s.Replace("Then... my hypothesis... it's flawed?!", "Alors... mon hypothèse... elle est fausse ?!");
                return s;
            };

            // BB\script\output\\_sce02_c102_0030_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c102_0030_eng#2"] = en => {
                return en.Replace("(I don't like the way this seems to be going...)",
                                  "(Je n'aime pas la tournure que prennent les événements...)");
            };

            // BB\script\output\\_sce02_c102_0030_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c102_0030_eng#3"] = en => {
                return en.Replace("(What's the best way for me to help the professor?)",
                                  "(Quel est le meilleur moyen d'aider le docteur ?)");
            };

            // BB\script\output\\_sce02_c102_0030_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c102_0030_eng#4"] = en => {
                return en.Replace("(Maybe I should watch and wait for the time being...)",
                                  "(Peut-être devrais-je observer et attendre pour le moment...)");
            };

            // BB\script\output\\_sce02_c102_0030_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c102_0030_eng#5"] = en => {
                string s = en;
                s = s.Replace("Professor Harebrayne has yet to perfect his invention!",
                              "Le Dr Samba Lonron n'a pas encore perfectionné son invention !");
                s = s.Replace("The court will grant a short recess.", "Le tribunal accorde une courte suspension de séance.");
                return s;
            };

            // BB\script\output\\_sce02_c103_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c103_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("23rd October, 10:44 a.m.", "23 octobre, 10h44");
                s = s.Replace("The Old Bailey, Defendants' Antechamber", "Old Bailey, Antichambre des accusés");
                s = s.Replace("That was a close call, <E003 6>Professor.", "Nous l'avons échappé belle, <E003 6>Docteur.");
                s = s.Replace("My equations... <E003 8>where did I go wrong?", "Mes équations... <E003 8>où ai-je commis une erreur ?");
                return s;
            };

            // BB\script\output\\_sce02_c104_0000_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c104_0000_eng#2"] = en => {
                string s = en;
                s = s.Replace("23rd October, 11:00 a.m.", "23 octobre, 11h00");
                s = s.Replace("The Old Bailey, Defendants' Antechamber", "Old Bailey, Antichambre des accusés");
                s = s.Replace("And while we're on the subject...", "Et pendant qu'on y est...");
                s = s.Replace("...wh-<E003 8>what about Barok?<E003 10>\r\n<E025 1>He's being awful!",
                              "...et <E003 8>Drake ?<E003 10>\r\n<E025 1>Il se montre absolument odieux !");
                s = s.Replace("Claiming his old university friend to be a murderer,<E086 5 31><E145 68 69><E003 8> you\r\nmean?",
                              "Prétendre que son vieil ami d'université est un meurtrier,<E086 5 31><E145 68 69><E003 8> vous\r\nvoulez dire ?");
                s = s.Replace("He's a disaster!<E003 8> <E025 3>Not just as a prosecutor...<E003 6><E164 68 71 1 2 5 0 2 1><E139 68><E025 1>but as <E006>a human\r\nbeing<E005>!",
                              "C'est un désastre !<E003 8> <E025 3>Pas seulement comme procureur... <E003 6><E164 68 71 1 2 5 0 2 1><E139 68><E025 1>mais en tant <E006>qu'être\r\nhumain<E005> !");
                s = s.Replace("Oh!<E003 5> But no!<E003 8> Wait!<E049><E003 12> He's the Reaper, <E003 4>isn't he?<E049><E003 10>\r\nPerhaps he's not classified as Homo sapiens any more...?",
                              "Oh !<E003 5> Mais non !<E003 8> Attendez !<E049><E003 12> C'est le Faucheur, <E003 4>n'est-ce pas ?<E049><E003 10>\r\nPeut-être n'est-il plus répertorié parmi les Homo sapiens... ?");
                s = s.Replace("(...Glad that's cleared up...)", "(... Heureux que ce soit tiré au clair...)");
                s = s.Replace("Can I double-check something with you?", "Puis-je vérifier un point avec vous ?");
                s = s.Replace("Ah.<E049><E003 10> Yes?<E049><E003 10> What?", "Ah.<E049><E003 10> Oui ?<E049><E003 10> Quoi ?");
                s = s.Replace("The machine and demonstration you prepared...<E003 12>\r\nThey were based entirely on your hypothesis, <E003 6>I presume?",
                              "La machine et l'expérience préparée...<E003 12>\r\nelles reposaient entièrement sur votre théorie, je présume ?");
                s = s.Replace("There was no<E025 7>...<E003 10><E330><E025 3>trickery involved?",
                              "Il n'y avait aucune... <E003 10><E330><E025 3>tromperie ?");
                s = s.Replace("I drew the plans for the machine with my very own\r\nhands.",
                              "J'ai dessiné les plans de la machine de mes propres mains.");
                s = s.Replace("Every line was painstakingly drawn with the firm belief\r\nthat science is the only future.",
                              "Chaque trait a été tracé avec la foi inébranlable que la science est notre seul avenir.");
                s = s.Replace("So yes, <E049><E003 8>it's true that my hypothesis hasn't reach maturity\r\nyet, <E049><E003 10><E025 3><E145 68 64><E144 68>but please, <E049><E003 6>Mr Naruhodo...<E003 10>you must believe in it.",
                              "Alors oui, <E049><E003 8>mon hypothèse n'est pas encore parfaite, <E049><E003 10><E025 3><E145 68 64><E144 68>mais je vous en conjure, <E049><E003 6>Mr Naruhodo... <E003 10>vous devez y croire.");
                s = s.Replace("Alright, <E003 6>Professor, <E003 10>I understand.",
                              "Très bien, <E003 6>Docteur, <E003 10>je comprends.");
                s = s.Replace("Counsel!<E003 12> Defendant!", "Maître !<E003 12> L'accusé !");
                s = s.Replace("The prosecution's witnesses are ready to take the stand.<E049><E003 10>\r\nCourt is about to be in session again.",
                              "Les témoins de l'accusation sont prêts à comparaître.<E049><E003 10>\r\nL'audience reprend dans un instant.");
                s = s.Replace("Make your way into the courtroom, please!", "Regagnez la salle d'audience, s'il vous plaît !");
                s = s.Replace("(It all hinges on that demonstration.)", "(Tout repose sur cette démonstration.)");
                s = s.Replace("(If the professor's hypothesis is sound as he claims...)",
                              "(Si la théorie du docteur est exacte comme il le soutient...)");
                s = s.Replace("(...it leaves him as the only person who could possibly\r\nhave killed the victim.)",
                              "(... cela fait de lui la seule personne à avoir pu tuer la victime.)");
                s = s.Replace("(But on the other hand, <E003 8>Mr Sholmes was adamant...)",
                              "(Mais d'un autre côté, <E003 8>Mr Holmes était formel...)");
                s = s.Replace("A practical implementation, <E049><E003 8>such as was attempted by the\r\nprofessor at the Great Exhibition, <E049><E003 10><E025 3><E330>is quite impossible.",
                              "Une application pratique, <E049><E003 8>telle que tentée par le\r\ndocteur à l'Exposition Universelle, <E049><E003 10><E025 3><E330>est tout bonnement impossible.");
                s = s.Replace("(So really, <E003 10>what should I be trying to prove here?)",
                              "(Alors que dois-je réellement tenter de prouver ici ?)");
                return s;
            };

            // BB\script\output\\_sce02_c104_0010_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c104_0010_eng#2"] = en => {
                string s = en;
                s = s.Replace("Witnesses, <E049><E003 8>state your names and occupations for the\r\ncourt to hear.",
                              "Témoins, <E049><E003 8>déclinez vos noms et professions pour la cour.");
                s = s.Replace("My name is <E006>Balthazar Lune<E005>.", "Je m'appelle <E006>Balthazar Lune<E005>.");
                s = s.Replace("I am...<E003 14><E025 2>the impresario of all the hot-air balloons in vicinity\r\nof the esperimento stage.",
                              "Je suis... <E003 14><E025 2>l'imprésario des montgolfières évoluant aux abords de l'estrade de l'esperimento.");
                s = s.Replace("Mein name ist <E049><E003 8><E006>Wilhelm <E003 4>Gottsreich <E003 4>Sigismond <E003 4>Ormstein<E005>.",
                              "Mein Name ist <E049><E003 8><E006>Wilhelm <E003 4>Gottsreich <E003 4>Sigismond <E003 4>Ormstein<E005>.");
                s = s.Replace("I have come to see ze Great Exhibition all ze vay from\r\nmy home in Bohemia.",
                              "Ch'ai fait tout le froyage depuis la Bohême pour foir la Crante Exposition.");
                s = s.Replace("...I'm very rich.", "...Et ch'e suis très riche.");
                s = s.Replace("Inspector <E006>Gina Lestrade<E005>, <E049><E003 6>Scotland Yard.<E049><E003 4>\r\n<E025 1><E164 122 83 1 2 8 0 1 1><E139 122>I'm a great detective.<E049><E003 12> Even 'Erlock Sholmes agrees.",
                              "Inspectrice stagiaire <E006>Gina Lestrade<E005>, <E049><E003 6>Scotland Yard.<E049><E003 4>\r\n<E025 1><E164 122 83 1 2 8 0 1 1><E139 122>Une détective hors pair.<E049><E003 12> Même Herlock Holmes le dit.");
                s = s.Replace("I was on security duty at the exhibition...<E003 8>and I got to go up\r\nin one o' them balloons!<E049><E003 4> <E164 122 89 1 2 7 0 0 1><E139 122><E025 1>It was amazin'!",
                              "J'étais de service à l'Expo... <E003 8>et j'suis montée dans un d'leurs ballons !<E049><E003 4> <E164 122 89 1 2 7 0 0 1><E139 122><E025 1>C'était grandiose !");
                s = s.Replace("(Gina...<E003 14>again.)", "(Gina... <E003 14>encore elle.)");
                s = s.Replace("(But she did mention that she'd seen the disaster from up\r\nin a balloon actually, <E003 8>didn't she?)",
                              "(Mais elle m'avait bien dit avoir assisté au drame depuis un ballon, <E003 8>n'est-ce pas ?)");
                s = s.Replace("(And she clearly<E003 6> <E330><E025 3>loved every minute of it.)",
                              "(Et visiblement, elle en a adoré chaque seconde.)");
                s = s.Replace("There were three balloons flying near the public\r\nexperimentation stage when the incident occurred.",
                              "Trois montgolfières volaient à proximité de l'estrade lors du drame.");
                s = s.Replace("Two of these witnesses were in one such balloon at the\r\ntime, <E049><E003 8>and saw events unfold from the skies above.",
                              "Deux de ces témoins se trouvaient à bord de l'une d'elles et ont vu la scène depuis les cieux.");
                s = s.Replace("You make it sound like they were in the clouds.<E049><E003 10>\r\nIt was only an altitude of circa sixty feet.<E049><E003 10><E025 3> Very low.",
                              "Vous parlez comme s'ils touchaient les nuages.<E049><E003 10>\r\nIls n'étaient qu'à environ dix-huit mètres d'altitude.<E049><E003 10><E025 3> Tout près.");
                s = s.Replace("Well ya can't see nuffin' if ya fly too 'igh, <E003 6>can ya?",
                              "Bah on voit rien du tout si on vole trop haut, pas vrai ?");
                s = s.Replace("(Sixty feet<E025 7>...<E003 10> <E025 2>About eighteen metres, then.)",
                              "(Soixante pieds<E025 7>...<E003 10> <E025 2>environ dix-huit mètres, donc.)");
                s = s.Replace("Thank you for your introductions.<E049><E003 10>\r\n<E025 3>Now, <E049><E003 8><E025 2>you will give your formal testimony for the court.",
                              "Merci pour ces présentations.<E049><E003 10>\r\n<E025 3>À présent, <E049><E003 8><E025 2>livrez votre témoignage officiel.");
                s = s.Replace("Kindly describe exactly what you witnessed...<E049><E003 10><E346><E025 1>especially\r\nthose of you who had a vantage point above the stage!",
                              "Décrivez avec exactitude ce que vous avez vu...<E049><E003 10><E346><E025 1> tout particulièrement\r\nceux ayant bénéficié d'une vue plongeante !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0020_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c104_0020_eng#2"] = en => {
                string s = en;
                s = s.Replace("– The View From Sixty Feet Up –", "– La vue à dix-huit mètres d'altitude –");
                s = s.Replace("It was an <E006>incidente terribile<E005>. I am only grateful that my\r\nballoons, they did not explode as well.",
                              "Ce fut un <E006>incidente terribile<E005>. Je remercie le ciel que mes\r\nballons n'aient point explosé eux aussi.");
                s = s.Replace("There's this huge bang from the stage, and then the next\r\nminute, the sky's full of green smoke!",
                              "Y a eu un grand bang sur l'estrade, et la seconde d'après, le ciel était plein d'une fumée verte !");
                s = s.Replace("And from amid ze smoke...<E003 8>a cage appeared out of novhere<E049><E003 8>\r\nright in front of us!",
                              "Et au milieu de la fumée... <E003 8>une kache est apparue de nulle part<E049><E003 8>\r\nchuste sous nos yeux !");
                s = s.Replace("It voz not ze sky zat exploded. It voz a green balloon zat\r\nburst! Bang! Like a great firevork!",
                              "Ce n'est pas le ciel qui a explosé. C'est un ballon fert qui a\r\néclaté ! Paf ! Comme un feu d'artifice !");
                s = s.Replace("The cage, it fell from the sky like a stone.<E049><E003 10> Straight into\r\nthe Crystal Tower with a terrible crash.",
                              "La cage est tombée du ciel comme une pierre.<E049><E003 10> Droit dans\r\nla Tour de Cristal avec un fracas épouvantable.");
                s = s.Replace("I didn't get a good look inside the cage, <E003 6>but no one went\r\nnear it afterwards. <E049><E003 8><E006>I made sure o' that<E005>.",
                              "J'ai pas bien vu l'intérieur d'la cage, <E003 6>mais personne s'en est\r\napproché après. <E049><E003 8><E006>J'y ai veillé en personne<E005>.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0020_eng#3
            entryTranslators["BB\\script\\output\\_sce02_c104_0020_eng#3"] = en => {
                string s = en;
                s = s.Replace("...A most extraordinary collective account, I must say.",
                              "...Un récit collectif tout à fait extraordinaire, ma foi.");
                s = s.Replace("A green balloon exploding mid-air...?", "Une montgolfière verte explosant en plein vol... ?");
                s = s.Replace("Mr Lune, <E003 4>as the balloon impresario, <E049><E003 8>can you explain this?",
                              "Signor Lune, <E003 4>en votre qualité d'exploitant, <E049><E003 8>pouvez-vous expliquer cela ?");
                s = s.Replace("Non, non! There were only <E006>three<E005> balloons in the sky that\r\nday, and none of them were green!",
                              "Non, non ! Il n'y avait que <E006>trois<E005> ballons dans le ciel ce\r\njour-là, et aucun n'était vert !");
                s = s.Replace("So where did this green balloon come from?", "D'où sortait donc ce ballon vert ?");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#2"] = en => {
                return en.Replace("– The View From Sixty Feet Up –", "– La vue à dix-huit mètres d'altitude –");
            };

            // BB\script\output\\_sce02_c104_0030_eng#4
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#4"] = en => {
                string s = en;
                s = s.Replace("It was an incidente terribile. I am only grateful that my\r\nballoons, they did not explode as well.",
                              "Ce fut un incidente terribile. Je suis seulement soulagé que mes\r\npropres ballons n'aient point explosé eux aussi.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#5
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#5"] = en => {
                string s = en;
                s = s.Replace("There's this huge bang from the stage, and then the next\r\nminute, the sky's full of green smoke!",
                              "Y a eu une énorme détonation sur l'estrade, et aussitôt après,\r\nle ciel s'est rempli d'une fumée verte !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#6
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#6"] = en => {
                string s = en;
                s = s.Replace("And from amid ze smoke...a cage appeared out of\r\nnovhere right in front of us!",
                              "Et du milieu de la fumée... une kache est apparue de nulle\r\npart chuste devant nous !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#7
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#7"] = en => {
                string s = en;
                s = s.Replace("It voz not ze sky zat exploded. It voz a green balloon zat\r\nburst! Bang! Like a great firevork!",
                              "Ce n'est pas le ciel qui a explosé. C'est un ballon fert qui a\r\néclaté ! Paf ! Comme un krand feu d'artifice !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#8
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#8"] = en => {
                string s = en;
                s = s.Replace("The cage, it fell from the sky like a stone.\r\nStraight into the Crystal Tower with a terrible crash.",
                              "La cage est tombée du ciel comme une pierre.\r\nDroit dans la Tour de Cristal avec un bruit d'enfer.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#9
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#9"] = en => {
                string s = en;
                s = s.Replace("I didn't get a good look inside the cage, but no one went\r\nnear it afterwards. I made sure o' that.",
                              "J'ai pas pu reluquer l'intérieur d'la cage, mais personne s'en\r\nest approché après. J'ai monté la garde.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#10
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#10"] = en => {
                string s = en;
                s = s.Replace("There were three balloons flying above the\r\nexperimentation area, <E003 4>correct?",
                              "Trois ballons survolaient la zone d'expérience, n'est-ce pas ?");
                s = s.Replace("Si, <E003 4>three. Two tethered balloons for sightseers,<E003 6> and one\r\nsmaller observation balloon.",
                              "Si, <E003 4>trois. Deux captifs pour les touristes,<E003 6> et un plus petit pour l'observation.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#11
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#11"] = en => {
                string s = en;
                s = s.Replace("So you actually saw the accident happen from up in the\r\nair, Gina?",
                              "Tu as donc réellement vu l'accident depuis les airs, Gina ?");
                s = s.Replace("Course I did! Me an' Master Gotts 'ere was in the basket\r\ntogether!",
                              "Bien sûr que oui ! Moi et monsieur Gotts là, on était ensemble dans la nacelle !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#12
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#12"] = en => {
                string s = en;
                s = s.Replace("So you're saying that you witnessed the actual moment\r\nof materialisation?",
                              "Vous soutenez donc avoir vu l'instant précis de la matérialisation ?");
                s = s.Replace("Ja, ja! Poof! Out of ze green smoke, ze wooden birdcage\r\nappeared!",
                              "Ja, ja ! Pouf ! De la fumée ferte a surgi la cage en bois !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#13
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#13"] = en => {
                string s = en;
                s = s.Replace("A green balloon, you say?", "Un ballon vert, dites-vous ?");
                s = s.Replace("It voz round and green, floating right below us before it\r\nburst!",
                              "Il était tout rond et fert, il flottait chuste sous nous afant d'éclater !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#14
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#14"] = en => {
                string s = en;
                s = s.Replace("Did you see that actually happen?", "Avez-vous vu la chute de vos propres yeux ?");
                s = s.Replace("I saw the glass of the Crystal Tower shatter into ten\r\nthousand pieces!",
                              "J'ai vu la vitre de la Tour de Cristal voler en dix mille morceaux !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#15
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#15"] = en => {
                string s = en;
                s = s.Replace("Was it you who gave the order to keep people away?",
                              "Est-ce vous qui avez donné l'ordre d'éloigner la foule ?");
                s = s.Replace("I was the first copper down the rope! Kept all the gawkers\r\nback until Gregson arrived!",
                              "J'ai été la première à glisser le long de la corde ! J'ai tenu les curieux à distance jusqu'à l'arrivée de Gregson !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#16
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#16"] = en => {
                string s = en;
                s = s.Replace("Um, er...Master Gotts!", "Euh... Monsieur Gotts !");
                s = s.Replace("Are you certain it was a balloon that exploded?",
                              "Êtes-vous certain que c'était un ballon qui a explosé ?");
                s = s.Replace("I am a connoisseur of hot-air balloons! I know a balloon\r\nven I see one!",
                              "Ch'e suis un connaisseur de montgolfières ! Ch'e reconnais un ballon quand ch'en fpois un !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#17
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#17"] = en => {
                string s = en;
                s = s.Replace("If I may, Mr Lune!", "Si vous me permettez, Signor Lune !");
                s = s.Replace("Could another balloon have entered the airspace without\r\nyour knowledge?",
                              "Un autre aérostat aurait-il pu pénétrer dans le ciel sans votre accord ?");
                s = s.Replace("Impossibile! All aviation over London is strictly regulated\r\nby myself!",
                              "Impossibile ! Toute l'aviation au-dessus de Londres est sous mon contrôle rigoureux !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#18
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#18"] = en => {
                string s = en;
                s = s.Replace("Master Gotts, do you have something to say?", "Monsieur Gotts, avez-vous quelque chose à ajouter ?");
                s = s.Replace("Ja! Ze green balloon voz tethered to ze Crystal Tower!",
                              "Ja ! Le ballon fert était amarré à la Tour de Cristal !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#19
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#19"] = en => {
                string s = en;
                s = s.Replace("Miss Lestrade!", "Mademoiselle Lestrade !");
                s = s.Replace("Did you notice any ropes attached to this mysterious balloon?",
                              "Avez-vous remarqué des cordages reliés à ce mystérieux ballon ?");
                s = s.Replace("Now that ya mention it...there was a thick cord running\r\nstraight down!",
                              "Maintenant qu'vous l'dites... y avait bien un gros câble qui filait tout droit vers le bas !");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#25
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#25"] = en => {
                string s = en;
                s = s.Replace("Thank you, Counsel, that will do.", "Merci, Maître, cela suffira.");
                s = s.Replace("The court has heard enough on this point.", "La cour en a suffisamment entendu sur ce sujet.");
                return s;
            };

            // BB\script\output\\_sce02_c104_0030_eng#27
            entryTranslators["BB\\script\\output\\_sce02_c104_0030_eng#27"] = en => {
                string s = en;
                s = s.Replace("(The prosecution really is asserting that the demonstration\r\nwas genuine...)",
                              "(L'accusation prétend réellement que la démonstration était authentique...)");
                s = s.Replace("(There must be a rational explanation for this mysterious\r\nballoon!)",
                              "(Il doit y avoir une explication rationnelle à ce mystérieux ballon !)");
                return s;
            };

            // BB\script\output\\_sce02_c104_0040_eng#2
            entryTranslators["BB\\script\\output\\_sce02_c104_0040_eng#2"] = en => {
                string s = en;
                s = s.Replace("Mr Lune, in your testimony...", "Signor Lune, lors de votre témoignage...");
                s = s.Replace("The instantaneous kinesis did occur!<E049><E003 10>\r\n<E025 3>But after the explosion on the stage...",
                              "La cinèse instantanée a bien eu lieu !<E049><E003 10>\r\n<E025 3>Mais après l'explosion sur l'estrade...");
                s = s.Replace("...the point of materialisation shifted <E049><E003 10><E025 3><E333>to <E006>a location occupied\r\nby a balloon<E005>.",
                              "... le point de matérialisation a dévié <E049><E003 10><E025 3><E333>vers <E006>l'emplacement occupé par un ballon<E005>.");
                s = s.Replace("Causing the balloon to explode?<E049><E003 12>\r\n<E145 15 0>Yes, <E049><E003 8><E025 2>eminently plausible.",
                              "Provoquant l'explosion dudit ballon ?<E049><E003 12>\r\n<E145 15 0>Oui, <E049><E003 8><E025 2>c'est éminemment plausible.");
                s = s.Replace("An unfortunate traffic accident, <E049><E003 8>as it were.<E049><E003 12>\r\n<E145 6 3><E118 6 0.7><E025 2>But it changes nothing about the pertinent facts.",
                              "Un malencontreux accident de la circulation aérienne, <E049><E003 8>pour ainsi dire.<E049><E003 12>\r\n<E145 6 3><E118 6 0.7><E025 2>Mais cela ne change rien aux faits reprochés.");
                s = s.Replace("This, <E003 12><E025 1><E338><E342>I cannot accept!",
                              "Cela, <E003 12><E025 1><E338><E342>je ne puis l'admettre !");
                s = s.Replace("Why not, <E049><E003 6>Mr Lune?", "Pourquoi donc, <E049><E003 6>Signor Lune ?");
                s = s.Replace("You are suggesting that I am a liar!", "Vous insinuez que je suis un menteur !");
                s = s.Replace("That persons died in a balloon incidente!", "Que des personnes sont mortes dans un incidente de ballon !");
                s = s.Replace("There's no need to get ‘fired up’, <E049><E003 8>Mr Lune.<E049><E003 12>\r\nThe victim was the sole fatality that day.",
                              "Nul besoin de vous enflammer, <E049><E003 8>Signor Lune.<E049><E003 12>\r\nLa victime fut le seul décès à déplorer ce jour-là.");
                s = s.Replace("That's right!<E049><E003 12> And I prove it!", "Parfaitement !<E049><E003 12> Et j'en apporte la preuve !");
                s = s.Replace("Balthazar Lune <E049><E003 10><E025 1><E607>is not a liar!<E049><E003 14><E025 2> There was no such balloon\r\nin the sky!<E049><E003 12> <E045><E025 1>It is non possibile!",
                              "Balthazar Lune <E049><E003 10><E025 1><E607>n'est pas un menteur !<E049><E003 14><E025 2> Il n'y avait aucun ballon semblable dans le ciel !<E049><E003 12> <E045><E025 1>C'est non possibile !");
                s = s.Replace("You're saying it's impossible?<E049><E003 10> <E025 4>Why?",
                              "Vous dites que c'est impossible ?<E049><E003 10> <E025 4>Pourquoi ?");
                s = s.Replace("This court has more important matters to discuss than the\r\nnumber of balloons that were operating that day.",
                              "Ce tribunal a des questions plus sérieuses à débattre que le nombre d'aérostats en vol ce jour-là.");
                s = s.Replace("AIIIIIIEEE<E338><E342>!", "AÏÏÏÏÏÏÏÏE !");
                s = s.Replace("But we can't ignore the fact that nobody appears to have\r\nknown anything about this other balloon until now!",
                              "Mais nous ne pouvons ignorer que personne ne semblait au courant de l'existence de cet autre ballon jusqu'à présent !");
                s = s.Replace("My Lord!", "Votre Honneur !");
                s = s.Replace("The defence calls for further testimony from Mr Lune!",
                              "La défense réclame un complément de déposition de la part du Signor Lune !");
                s = s.Replace("I concur.<E049><E003 12> There is clearly more to the truth here than\r\nmeets the eye.",
                              "Je souscris à cette demande.<E049><E003 12> Il y a manifestement anguille sous roche.");
                s = s.Replace("It's imperative that we clear up the issue of this phantom\r\nballoon, <E003 4>I feel.",
                              "Il est impératif d'élucider le mystère de ce ballon fantôme.");
                s = s.Replace("Witness, <E049><E003 8><E025 2>you will give supplementary testimony about\r\nthe balloons you were operating at the exhibition.",
                              "Témoin, <E049><E003 8><E025 2>veuillez apporter des éclaircissements sur les aérostats que vous exploitiez.");
                s = s.Replace("Ah...<E003 10><E164 120 71 1 2 8 0 2 1><E139 120><E025 1>grazie, <E049><E003 8><E025 2>My Lord!",
                              "Ah... <E003 10><E164 120 71 1 2 8 0 2 1><E139 120><E025 1>grazie, <E049><E003 8><E025 2>Votre Honneur !");
                return s;
            };
        }
    }
}

