using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act4 {
    public partial class Program {
        public static void RegisterPart4_A() {
            // [81] BB\script\output\_sce03_c107_0020_eng#22
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("<E341>Mr de Rossi!<E049><E003 10>\r\nDo you have something to say?", "<E341>Monsieur de Rossi !<E049><E003 10>\r\nAvez-vous quelque chose à ajouter ?");
                s = s.Replace("Che?<E003 8> What?", "Che ?<E003 8> Quoi ?");
                s = s.Replace("You looked as though you were thinking something...<E003 10>\r\n<E341>whilst eating a mouthful of pasta.", "On aurait dit que vous pensiez à quelque chose...<E003 10>\r\n<E341>tout en avalant une bouchée de pâtes.");
                s = s.Replace("Ah, <E003 8>si.<E003 10> <E025 2>I was-a thinking...", "Ah, <E003 8>si.<E003 10> <E025 2>J'étais en train de penser...");
                s = s.Replace("<E330>...perhaps my hair is this-a colour because I eat too much\r\nBolognese sauce.", "<E330>... que mes cheveux ont peut-être cette couleur parce que je mange trop de sauce bolognaise.");
                s = s.Replace("...No comment.", "... Sans commentaire.");
                return s;
            };

            // [82] BB\script\output\_sce03_c107_0020_eng#29
            entryTranslators[@"BB\script\output\_sce03_c107_0020_eng#29"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu bien assez de preuves pour me forger\r\nune opinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "Puisqu'il s'agit d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront pas divulguées au public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Toutefois, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Fossoyeur comparaît\r\ndans cette salle d'audience <E049><E003 8><E025 3>ou dans toute autre.");
                s = s.Replace("<E341>B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "<E341>M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de ce\r\ntribunal, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };

            // [83] BB\script\output\_sce03_c107_0030_eng#2
            entryTranslators[@"BB\script\output\_sce03_c107_0030_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("If you have no ‘kinfolk’ <E049><E003 10><E025 2><E145 1 7>as you put it...", "Si vous n'avez « pas de famille » <E049><E003 10><E025 2><E145 1 7>comme vous dites...");
                s = s.Replace("...then explain why it is that among the sparce furnishings,<E049><E003 8><E060 0 122 1 0>\r\n<E239>we found this photograph in the room?", "... alors expliquez-nous pourquoi, parmi ce modeste mobilier,<E049><E003 8><E060 0 122 1 0>\r\n<E239>nous avons trouvé cette photo dans la pièce ?");
                s = s.Replace("<E333><E342>Ah!", "<E333><E342>Ah !");
                s = s.Replace("I presume, <E049><E003 8>as you've been renting the room,<E049><E003 6> <E145 1 21><E003 15><E025 3><E238>that this\r\nphotograph belongs to you, <E003 6>does it not?", "Je présume, <E049><E003 8>puisque vous louez cette chambre,<E049><E003 6> <E145 1 21><E003 15><E025 3><E238>que cette\r\nphotographie vous appartient, <E003 6>n'est-ce pas ?");
                s = s.Replace("<E333><E025 2><E342>Oh, <E049><E003 8><E025 3>um...<E003 8><E025 3><E341>well...", "<E333><E025 2><E342>Oh, <E049><E003 8><E025 3>euh...<E003 8><E025 3><E341> eh bien...");
                s = s.Replace("Mr Boone, <E049><E003 10><E025 2>drop the pretence...<E049><E003 10><E164 1 8 1 2 5 0 2 1><E139 1><E025 1>and tell the court exactly\r\nwho you really are!", "Monsieur Boone, <E049><E003 10><E025 2>cessez cette comédie...<E049><E003 10><E164 1 8 1 2 5 0 2 1><E139 1><E025 1> et dites au tribunal\r\nqui vous êtes réellement !");
                s = s.Replace("I, <E003 8>I don't know what...<E003 6>what you mean.<E049><E003 14>\r\n<E025 1>I'm a pedlar!<E049><E003 10> I, <E003 6>I keep telling you so!", "J'... <E003 8>j'sais pas ce que... <E003 6>ce que vous voulez dire.<E049><E003 14>\r\n<E025 1>J'suis un camelot !<E049><E003 10> J'... <E003 6>j'arrête pas d'vous l'dire !");
                s = s.Replace("You really don't need to bother with me.<E049><E003 15>\r\n<E025 3><E145 79 79><E117 79 15>Please, <E003 6>just...<E003 10><E025 1><E046>just leave it alone!", "Vous n'avez pas besoin d'vous occuper d'moi.<E049><E003 15>\r\n<E025 3><E145 79 79><E117 79 15>S'il vous plaît, <E003 6>laissez...<E003 10><E025 1><E046> laissez tomber !");
                s = s.Replace("As the man says...", "Comme dit cet homme...");
                s = s.Replace("...leave it alone.<E049><E003 10> Whatever the truth is about this man's\r\nlife, <E049><E003 6>it has no bearing on this case.", "... laissez tomber.<E049><E003 10> Quelle que soit la vérité sur la vie de cet homme,\r\n<E049><E003 6>cela n'a aucun rapport avec cette affaire.");
                s = s.Replace("Because it's simply <E006>not possible<E005> that he impersonated\r\nInspector Gregson!", "Car il est tout bonnement <E006>impossible<E005> qu'il se soit fait passer pour\r\nl'inspecteur Gregson !");
                s = s.Replace("<E335>How can you be so sure?", "<E335>Comment pouvez-vous en être si sûr ?");
                s = s.Replace("Just look at the man!", "Regardez donc cet homme !");
                s = s.Replace("No amount of disguise could ever hide <E049><E003 8><E025 1><E046>those <E006>unmissable\r\nfeatures<E005>!", "Aucun déguisement au monde ne pourrait dissimuler <E049><E003 8><E025 1><E046>ces <E006>traits\r\nimmanquables<E005> !");
                s = s.Replace("But what if...<E049><E003 8><E025 2><E145 1 7><E003 6><E330>we were to look at this <E006>the other way\r\naround<E005>?", "Mais et si...<E049><E003 8><E025 2><E145 1 7><E003 6><E330> nous envisagions la situation <E006>dans l'autre\r\nsens<E005> ?");
                s = s.Replace("<E338><E341><E025 2>What do you mean?", "<E338><E341><E025 2>Que voulez-vous dire ?");
                s = s.Replace("Yes, Counsel, <E049><E003 6><E341>what do you mean?", "Oui, Maître, <E049><E003 6><E341>que voulez-vous dire ?");
                s = s.Replace("Well...<E049><E003 8>there's no denying that Mr Boone's lip is very\r\nprominent indeed.", "Eh bien...<E049><E003 8> nul ne peut nier que la lèvre de M. Boone est en effet\r\nparticulièrement proéminente.");
                s = s.Replace("But consider the possibility...<E049><E003 10><E145 1 21><E003 6><E025 2><E330>that his prominent lip is <E006>itself<E005>\r\npart of an elaborate disguise!", "Mais envisagez cette possibilité...<E049><E003 10><E145 1 21><E003 6><E025 2><E330> et si cette lèvre proéminente était <E006>elle-même<E005>\r\nla pièce maîtresse d'un savant déguisement ?");
                s = s.Replace("Then hiding that prominent feature – <E049><E003 8><E025 3>in other words<E049><E003 8>\r\n<E025 2><E006>revealing his true face<E005>...", "Alors cacher cette caractéristique – <E049><E003 8><E025 3>autrement dit<E049><E003 8>\r\n<E025 2><E006>dévoiler son vrai visage<E005>...");
                s = s.Replace("...would make an utterly impenetrable disguise!", "... constituerait un déguisement parfaitement indécelable !");
                s = s.Replace("Wouldn't you agree...<E049><E003 15><E549 7 19 0 1><E131><E346>Mr Hugh Boone?", "Ne trouvez-vous pas...<E049><E003 15><E549 7 19 0 1><E131><E346> Monsieur Hugh Boone ?");
                s = s.Replace("<E341>Aaah...<E049><E003 20>\r\n<E025 1><E145 79 74><E606>AAAAAAAAAA<E045>AARGH!", "<E341>Aaah...<E049><E003 20>\r\n<E025 1><E145 79 74><E606>AAAAAAAAAA<E045>AARGH !");
                s = s.Replace("Good–<E049><E003 8> <E145 15 3><E025 1><E335>Witness!<E003 10> <E049><E003 10><E145 15 5><E117 15 5><E025 1><E332>Are you still hiding the truth from this\r\ncourt?!", "Bonté...<E049><E003 8> <E145 15 3><E025 1><E335>Témoin !<E003 10> <E049><E003 10><E145 15 5><E117 15 5><E025 1><E332>Dissimulez-vous encore la vérité devant ce\r\ntribunal ?!");
                s = s.Replace("If, <E145 1 0><E118 1 0.5><E049><E003 6><E025 2>if that's <E006>a disguise<E005>, <E049><E003 8><E025 3>then...", "Si, <E145 1 0><E118 1 0.5><E049><E003 6><E025 2>si c'est <E006>un déguisement<E005>, <E049><E003 8><E025 3>alors...");
                s = s.Replace("...underneath it, <E049><E003 6><E145 9 92><E118 9 0.6><E003 8><E025 3>his true identity must be...", "... dessous, <E049><E003 6><E145 9 92><E118 9 0.6><E003 8><E025 3>sa véritable identité doit être...");
                s = s.Replace("Yes, <E049><E171 9 17 1 9 1><E003 10><E145 1 21>that's right.<E049><E003 12>\r\n<E025 2><E333>There's really only one person he could really be.", "Oui, <E049><E171 9 17 1 9 1><E003 10><E145 1 21>c'est bien cela.<E049><E003 12>\r\n<E025 2><E333>Il n'y a qu'une seule personne qu'il puisse réellement être.");
                s = s.Replace("<E338><E341>My Lord!", "<E338><E341>Votre Honneur !");
                s = s.Replace("The defence believes <E049><E003 8><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>it can reveal Mr Boone's true\r\nidentity to the court!", "La défense est en mesure <E049><E003 8><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>de révéler la véritable\r\nidentité de M. Boone à la cour !");
                s = s.Replace("<E341>No...<E003 8> <E025 3><E338><E342>Please...<E003 8><E025 4>no...", "<E341>Non...<E003 8> <E025 3><E338><E342>Je vous en prie...<E003 8><E025 4> non...");
                return s;
            };

            // [84] BB\script\output\_sce03_c107_0040_eng#2
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("<E341>Very well then, Counsel...", "<E341>Très bien alors, Maître...");
                return s;
            };

            // [85] BB\script\output\_sce03_c107_0040_eng#3
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("What is the true identity of this pedlar <E049><E003 8><E025 1><E346>who goes simply\r\nby the name of ‘Gossip’ on the street?", "Quelle est la véritable identité de ce camelot <E049><E003 8><E025 1><E346>connu dans\r\nla rue sous le simple nom de « Ragot » ?");
                return s;
            };

            // [86] BB\script\output\_sce03_c107_0040_eng#4
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("<E333><E341>Heavens above!<E049><E003 12> <E025 3>That's, <E049><E003 8><E025 2>that's who's hiding under this\r\nman's disguise, <E003 4><E025 2>you say?!", "<E333><E341>Grand Dieu !<E049><E003 12> <E025 3>C'est... <E049><E003 8><E025 2>c'est lui qui se cacherait sous le déguisement\r\nde cet homme, <E003 4><E025 2>dites-vous ?!");
                s = s.Replace("It's really not much of an exaggeration to say...", "Ce n'est vraiment pas exagéré de dire...");
                s = s.Replace("...that anybody could be Mr Gossip <E049><E003 10><E332>just by attaching that\r\nenormous bottom lip!", "... que n'importe qui pourrait devenir M. Ragot <E049><E003 10><E332>en se collant simplement\r\ncette énorme lèvre inférieure !");
                s = s.Replace("If that's what you think...", "Si c'est ce que vous pensez...");
                s = s.Replace("...then why don't you put on some fake lips <E049><E003 10><E332>and try living\r\nas a street pedlar yourself?!", "... alors pourquoi n'enfilez-vous pas de fausses lèvres <E049><E003 10><E332>pour essayer de\r\nvivre en camelot de rue vous-même ?!");
                return s;
            };

            // [87] BB\script\output\_sce03_c107_0040_eng#5
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("<E356>GAAAAAAAAAH<E345>!", "<E356>GAAAAAAAAAH<E345> !");
                s = s.Replace("<E341>Ugh...<E003 10><E025 3>I walked right into that one, <E003 6>didn't I?", "<E341>Argh...<E003 10><E025 3> Je l'ai bien cherché, <E003 6>n'est-ce pas ?");
                s = s.Replace("I'm afraid so.<E049><E003 10> And I really can't sympathise.", "J'en ai bien peur.<E049><E003 10> Et je ne peux vraiment pas vous plaindre.");
                s = s.Replace("<E333>(I can't help being a little curious <E003 6><E025 2>about how it would feel\r\nto have a lip like that, <E003 4>actually...)", "<E333>(Je ne peux m'empêcher d'être un peu curieux <E003 6><E025 2>de savoir ce que ça\r\nferait d'avoir une lèvre pareille, <E003 4>en fait...)");
                s = s.Replace("<E238>Don't dig yourself in any deeper now, <E003 4>Mr Naruhodo.", "<E238>N'aggravez pas votre cas, <E003 4>M. Naruhodo.");
                return s;
            };

            // [88] BB\script\output\_sce03_c107_0040_eng#6
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("<E333><E341>This is the person that lies beneath the disguise,<E049><E003 4> <E025 2>you say?", "<E333><E341>C'est donc cette personne qui se cacherait sous le déguisement,<E049><E003 4> <E025 2>dites-vous ?");
                s = s.Replace("<E346>Without question, <E049><E003 6>My Lord!", "<E346>Sans aucun doute, <E049><E003 6>Votre Honneur !");
                s = s.Replace("But...<E003 10>would it therefore not be the case...", "Mais...<E003 10> n'en découlerait-il pas...");
                s = s.Replace("<E345>...that those lips are no disguise at all?", "<E345>... que ces lèvres ne sont aucunement un déguisement ?");
                return s;
            };

            // [89] BB\script\output\_sce03_c107_0040_eng#7
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Your <E006>real name<E005>...<E003 10><E330><E025 3>is actually Mr Vigil, <E049><E003 6>isn't it?<E049><E003 8><E145 1 21><E003 6>\r\nMr Daley Vigil.", "Votre <E006>vrai nom<E005>...<E003 10><E330><E025 3> est en réalité M. Vigil, <E049><E003 6>n'est-ce pas ?<E049><E003 8><E145 1 21><E003 6>\r\nM. Daley Vigil.");
                s = s.Replace("<E606><E339>YAAAAAAAAAAAAGH!!!", "<E606><E339>YAAAAAAAAAAAAGH !!!");
                s = s.Replace("I don't recall that name, Counsel.<E049><E003 10>\r\n<E025 2><E341>Who is this Mr Vigil?", "Ce nom ne me dit rien, Maître.<E049><E003 10>\r\n<E025 2><E341>Qui est donc ce M. Vigil ?");
                s = s.Replace("It's a name I encountered yesterday, <E003 4>My Lord.", "C'est un nom que j'ai découvert hier, <E003 4>Votre Honneur.");
                s = s.Replace("It has to do with a certain client of Mr Herlock Sholmes.", "Il est lié à une certaine cliente de M. Herlock Sholmes.");
                s = s.Replace("A young gentlewoman came to the detective <E049><E003 10><E025 2>asking him\r\nto locate her missing husband.", "Une jeune dame s'est présentée au détective <E049><E003 10><E025 2>pour lui demander\r\nde retrouver son mari disparu.");
                s = s.Replace("The woman in this photograph, <E049><E003 6>in fact.<E049><E003 12>\r\n<E330>This is Mrs Vigil.", "La femme sur cette photo, <E049><E003 6>précisément.<E049><E003 12>\r\n<E330>Voici Mme Vigil.");
                s = s.Replace("<E338><E341>W-<E003 6><E025 2>What?", "<E338><E341>Q-<E003 6><E025 2>Quoi ?");
                s = s.Replace("From what I understand, <E049><E003 7><E145 1 85><E003 6><E025 2>you haven't returned home\r\nsince the night before the inspector was found dead.", "D'après ce que j'ai compris, <E049><E003 7><E145 1 85><E003 6><E025 2>vous n'êtes pas rentré chez vous\r\ndepuis la veille du jour où l'inspecteur a été retrouvé mort.");
                s = s.Replace("But of course <E049><E003 8><E025 3>on that night, <E049><E003 10><E025 2>you were being held captive\r\nby the two Red-Headed League men.", "Mais bien sûr, <E049><E003 8><E025 3>cette nuit-là, <E049><E003 10><E025 2>vous étiez retenu captif\r\npar les deux membres de la Ligue des Rouquins.");
                s = s.Replace("And last night, <E049><E003 8><E025 2>you were put up by the prosecution\r\nservice in preparation for testifying in this trial.", "Et la nuit dernière, <E049><E003 8><E025 2>vous avez été logé par l'accusation\r\nen vue de témoigner à ce procès.");
                s = s.Replace("Because we'd been led to believe that you, <E003 6><E025 3>Miss Venus\r\n<E049><E003 8>and Mr Sandwich were all homeless.", "Car on nous avait laissé entendre que vous, <E003 6><E025 3>Mlle Venus\r\n<E049><E003 8>et M. Sandwich étiez tous sans domicile.");
                s = s.Replace("Being important witnesses in this case, <E049><E003 8>we needed to\r\nknow where we could find you, <E003 6>of course.", "En tant que témoins cruciaux de cette affaire, <E049><E003 8>nous devions\r\nsavoir où vous joindre, <E003 6>bien entendu.");
                s = s.Replace("And that explains why you've not only been unable to\r\nreturn home, <E049><E003 8>but also unable to contact your wife...", "Et cela explique pourquoi vous n'avez pas pu rentrer chez vous,\r\n<E049><E003 8>ni même contacter votre épouse...");
                s = s.Replace("...who's been beside herself with worry, <E003 6>waiting for you\r\nat the Vigil residence.", "... qui se rongeait les sangs en vous attendant\r\nau domicile des Vigil.");
                s = s.Replace("Now, <E049><E003 6><E025 1>now just you hold on a minute!<E049><E003 14>\r\n<E341><E025 2>I don't have <E342>the first idea–", "Minute, <E049><E003 6><E025 1>attendez une minute !<E049><E003 14>\r\n<E341><E025 2>J'ai pas la moindre idée...");
                s = s.Replace("<E238>What I'm talking about?<E049><E003 12> Really?", "<E238>De quoi je parle ?<E049><E003 12> Vraiment ?");
                s = s.Replace("It's a simple enough matter to confirm my suspicions!", "Il est pourtant bien simple de confirmer mes soupçons !");
                s = s.Replace("All we have to do <E049><E003 8><E346><E025 1>is pull off that disguise!", "Tout ce que nous avons à faire, <E049><E003 8><E346><E025 1>c'est de retirer ce déguisement !");
                s = s.Replace("<E239><E025 3><E342>N-<E049><E003 12><E025 4>No...<E003 10> Please!", "<E239><E025 3><E342>N-<E049><E003 12><E025 4>Non...<E003 10> Pitié !");
                s = s.Replace("Bailiff!<E049><E003 12> <E025 1>Bring soap, <E003 6>a sponge <E049><E003 10><E025 1><E335>and a washbowl at once!", "Huissier !<E049><E003 12> <E025 1>Apportez du savon, <E003 6>une éponge <E049><E003 10><E025 1><E335>et une bassine sans tarder !");
                s = s.Replace("Mr de Rousseau and Mr de Rossi, <E049><E003 12><E025 1><E145 15 5><E332>you will restrain the\r\nwitness!", "Monsieur de Rousseau et Monsieur de Rossi, <E049><E003 12><E025 1><E145 15 5><E332>maîtrisez le\r\ntémoin !");
                s = s.Replace("Oui, <E003 8>My Lord!", "Oui, <E003 8>Votre Honneur !");
                s = s.Replace("Si, <E003 8>My Lord!", "Si, <E003 8>Votre Honneur !");
                s = s.Replace("UWAAAAAAAAAGH!", "OUAAAAAAAH !");
                s = s.Replace("<E342>N-<E003 12><E025 3><E341>No...<E049><E003 8> <E342><E025 4>Stop...<E003 20>\r\n<E070 2 5 1><E342><E025 2>Get off...<E003 8> <E025 4><E054 0>Please...", "<E342>N-<E003 12><E025 3><E341>Non...<E049><E003 8> <E342><E025 4>Arrêtez...<E003 20>\r\n<E070 2 5 1><E342><E025 2>Lâchez-moi...<E003 8> <E025 4><E054 0>Pitié...");
                s = s.Replace("DOOOOOOOOOOOON'T!!!", "ARRÊTEEEEEEEEEEZ !!!");
                return s;
            };

            // [90] BB\script\output\_sce03_c107_0040_eng#8
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("...we are now seeing your <E006>true features<E005>, <E003 6>I presume?", "... nous voyons désormais vos <E006>véritables traits<E005>, <E003 6>je présume ?");
                s = s.Replace("Lift your head, <E003 6>sir.<E049><E003 10> <E025 2>So the court can see your face.", "Relevez la tête, <E003 6>monsieur.<E049><E003 10> <E025 2>Que le tribunal voie votre visage.");
                s = s.Replace("It would appear <E049><E003 8><E025 2>that the defence counsel's assertion was\r\nentirely correct.", "Il semblerait <E049><E003 8><E025 2>que l'affirmation de la défense fût\r\nparfaitement exacte.");
                s = s.Replace("This has all been a very elaborate deception.", "Tout ceci n'était qu'une mise en scène des plus élaborées.");
                s = s.Replace("So, witnesses, <E049><E003 8>tell the court:<E049><E003 20>\r\n<E238><E130 15 1><E025 2>have you seen this man before?", "Alors, témoins, <E049><E003 8>dites à la cour :<E049><E003 20>\r\n<E238><E130 15 1><E025 2>avez-vous déjà vu cet homme auparavant ?");
                s = s.Replace("<E334>I, <E049><E003 15><E145 80 74><E331>I don't believe it, <E049><E003 8>but...", "<E334>Je... <E049><E003 15><E145 80 74><E331>je n'en crois pas mes yeux, <E049><E003 8>mais...");
                s = s.Replace("<E334>Si, <E049><E003 15><E136 81 71 5><E117 81 5><E139 81><E149 81 1 4><E331><E025 1>there is-a no question.", "<E334>Si, <E049><E003 15><E136 81 71 5><E117 81 5><E139 81><E149 81 1 4><E331><E025 1>ça fait aucun doute.");
                s = s.Replace("This <E049><E003 12><E025 1><E145 126 70><E117 126 5><E607><E339>is-a <E006>the inspector<E005> we saw in the park!", "C'est <E049><E003 12><E025 1><E145 126 70><E117 126 5><E607><E339>bien <E006>l'inspecteur<E005> qu'on a vu dans le parc !");
                s = s.Replace("Extraordinary!", "Extraordinaire !");
                s = s.Replace("On the day of the Red-Headed League enrolment...", "Le jour de l'inscription à la Ligue des Rouquins...");
                s = s.Replace("...the man claiming to be Inspector Gregson who appeared\r\nbefore Mr de Rousseau and Mr de Rossi in the park...", "... l'homme prétendant être l'inspecteur Gregson qui s'est présenté\r\nà MM. de Rousseau et de Rossi dans le parc...");
                s = s.Replace("...Was you, <E049><E003 10>disguised as the inspector!<E049><E003 15>\r\n<E341><E025 3>Or rather...", "... C'était vous, <E049><E003 10>déguisé en inspecteur !<E049><E003 15>\r\n<E341><E025 3>Ou plutôt...");
                s = s.Replace("...was you posing as the inspector in no disguise at all!", "... c'était vous vous faisant passer pour l'inspecteur sans le moindre déguisement !");
                s = s.Replace("Mr Vigil was formerly employed as the chief warder at\r\nBarclay Prison.", "M. Vigil était auparavant employé comme surveillant-chef à\r\nla prison de Barclay.");
                s = s.Replace("The chief warder?", "Le surveillant-chef ?");
                s = s.Replace("Then your career had promise.<E049><E003 8> Why, <E003 4>you would quite\r\npossibly have become the future governor of the prison.", "Votre carrière était donc prometteuse.<E049><E003 8> Mais enfin, <E003 4>vous seriez\r\ntrès certainement devenu le gouverneur de la prison.");
                s = s.Replace("What on earth have you been doing peddling tittle-tattle\r\non Fresno Street?", "Que diable faisiez-vous à colporter des cancans sur\r\nFresno Street ?");
                s = s.Replace("Well, <E049><E003 8><E145 1 0><E118 1 1.3><E003 12><E333>it's been ten years since Mr Vigil worked at the\r\nprison.", "Eh bien, <E049><E003 8><E145 1 0><E118 1 1.3><E003 12><E333>cela fait dix ans que M. Vigil ne travaille plus à\r\nla prison.");
                s = s.Replace("Ten years?", "Dix ans ?");
                s = s.Replace("I'm...<E003 10>I'm really dreadfully sorry about all of this.", "Je...<E003 10> je suis vraiment terriblement désolé pour tout cela.");
                s = s.Replace("Yes, <E049><E003 8>it's true...<E049><E003 12>\r\n<E025 2>I am Daley Vigil.", "Oui, <E049><E003 8>c'est la vérité...<E049><E003 12>\r\n<E025 2>Je suis Daley Vigil.");
                s = s.Replace("And you were the chief warder at Barclay Prison ten\r\nyears ago...?", "Et vous étiez surveillant-chef à la prison de Barclay il y a\r\ndix ans... ?");
                s = s.Replace("So where did Mr Hugh Boone come from?", "D'où vient donc ce M. Hugh Boone alors ?");
                s = s.Replace("Boone is...<E049><E003 10><E145 126 64><E118 126 0.5><E003 20><E025 3><E330><E006>the other me<E005>.<E049><E003 12>\r\nIt's a name I invented.", "Boone est...<E049><E003 10><E145 126 64><E118 126 0.5><E003 20><E025 3><E330><E006>mon autre moi<E005>.<E049><E003 12>\r\nC'est un nom que j'ai inventé.");
                s = s.Replace("Well...<E003 12>evidently <E049><E003 6><E025 2><E145 15 5>there is a great deal under the surface\r\nhere.", "Eh bien...<E003 12> de toute évidence, <E049><E003 6><E025 2><E145 15 5>cette histoire recèle de\r\nnombreux mystères.");
                s = s.Replace("I'll...<E003 8>explain everything.", "Je vais...<E003 8> tout vous expliquer.");
                s = s.Replace("I'll tell you just how wretched my life has become.", "Je vais vous raconter à quel point ma vie est devenue misérable.");
                return s;
            };

            // [91] BB\script\output\_sce03_c107_0040_eng#9
            entryTranslators[@"BB\script\output\_sce03_c107_0040_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("That will do!", "Cela suffit !");
                s = s.Replace("I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu bien assez de preuves pour me forger\r\nune opinion impartiale.");
                s = s.Replace("As this is a closed trial, <E049><E003 8><E025 2>the findings of this court will not\r\nbe disclosed to the public.", "Puisqu'il s'agit d'un procès à huis clos, <E049><E003 8><E025 2>les conclusions de ce tribunal ne\r\nseront pas divulguées au public.");
                s = s.Replace("However, <E049><E003 8><E025 2>this will be the very last time the Reaper stands\r\nin this <E049><E003 8><E025 3>or any other courtroom.", "Toutefois, <E049><E003 8><E025 2>ce sera la toute dernière fois que le Fossoyeur comparaît\r\ndans cette salle d'audience <E049><E003 8><E025 3>ou dans toute autre.");
                s = s.Replace("<E341>B-<E003 8>But, <E049><E003 8>My Lord!<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Wait!", "<E341>M-<E003 8>Mais, <E049><E003 8>Votre Honneur !<E049><E003 6> <E025 2><E164 1 71 1 2 1 0 2 1><E139 1>Attendez !");
                s = s.Replace("Barok van Zieks, <E049><E003 8>in accordance with the findings of this\r\ncourt, <E049><E003 8><E025 3>I pronounce you...", "Barok van Zieks, <E049><E003 8>conformément aux conclusions de ce\r\ntribunal, <E049><E003 8><E025 3>je vous déclare...");
                s = s.Replace("That is all.<E049><E003 10> <E025 1>Court is adjourned!", "C'est tout.<E049><E003 10> <E025 1>L'audience est levée !");
                return s;
            };

            // [92] BB\script\output\_sce03_c108_0000_eng#2
            entryTranslators[@"BB\script\output\_sce03_c108_0000_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("As you say, <E003 10><E025 2>it was ten years ago now that my\r\nemployment as Barclay's chief warder came to an end.", "Comme vous l'avez dit, <E003 10><E025 2>c'était il y a dix ans que mes\r\nfonctions de surveillant-chef à Barclay ont pris fin.");
                s = s.Replace("Having left the prison service, <E049><E003 12><E025 2>I searched for some new\r\noccupation by which to earn a wage.", "Ayant quitté l'administration pénitentiaire, <E049><E003 12><E025 2>j'ai cherché un nouvel\r\nemploi pour gagner ma vie.");
                s = s.Replace("But times were hard in London, <E049><E003 12><E025 3>and I found no suitable\r\nengagements at all.", "Mais les temps étaient durs à Londres, <E049><E003 12><E025 3>et je n'ai trouvé aucun\r\nposte convenable.");
                s = s.Replace("In desperation one day, <E049><E003 6><E164 126 67 1 2 42 0 0 1><E118 126 1.2><E139 126><E025 3>I turned my hand at selling wares\r\non Fresno Street.", "Désespéré, un jour, <E049><E003 6><E164 126 67 1 2 42 0 0 1><E118 126 1.2><E139 126><E025 3>je me suis mis à vendre des bricoles\r\nsur Fresno Street.");
                s = s.Replace("But your wife appears to know nothing of this.", "Mais votre épouse semble n'en rien savoir.");
                s = s.Replace("She still maintains that you are the chief warder at\r\nBarclay Prison.", "Elle affirme toujours que vous êtes le surveillant-chef de\r\nla prison de Barclay.");
                s = s.Replace("I was utterly determined that my wife should not know\r\nof my failings.<E049><E003 12> <E341><E025 2>Which is why I've never told her.", "J'étais absolument déterminé à ce que ma femme n'apprenne rien de\r\nmes échecs.<E049><E003 12> <E341><E025 2>C'est pourquoi je ne lui ai jamais rien dit.");
                s = s.Replace("I opened an account at the bank under the name of Hugh\r\nBoone...", "J'ai ouvert un compte en banque sous le nom de Hugh\r\nBoone...");
                s = s.Replace("...and I rented the cheapest room I could find on Fresno\r\nStreet.", "... et j'ai loué la chambre la moins chère possible sur Fresno\r\nStreet.");
                s = s.Replace("The scene of the very crime we're investigating.", "La scène du crime même sur lequel nous enquêtons.");
                s = s.Replace("...Yes, <E049><E003 12><E025 2>that's right.", "... Oui, <E049><E003 12><E025 2>c'est exact.");
                s = s.Replace("A place from which I could <E006>emerge<E005> every morning at\r\neight <E003 10><E025 3>as a squalid pedlar...", "Un endroit d'où je pouvais <E006>sortir<E005> chaque matin à\r\nhuit heures, <E003 10><E025 3>en pitoyable camelot...");
                s = s.Replace("...and transform myself back every evening at five <E003 10>into a\r\nwell-dressed man about town before returning home.", "... et me retransformer chaque soir à cinq heures <E003 10>en homme élégant\r\navant de rentrer chez moi.");
                s = s.Replace("That quickly became my daily routine.", "C'est vite devenu ma routine quotidienne.");
                s = s.Replace("I was puzzled by the lack of furniture in the room...", "J'étais intrigué par l'absence de meubles dans la pièce...");
                s = s.Replace("...but that explains it.", "... mais cela explique tout.");
                s = s.Replace("But why on earth <E049><E003 8><E025 1><E335>didn't you just tell us this in the first\r\nplace?", "Mais pourquoi diable <E049><E003 8><E025 1><E335>ne pas nous l'avoir dit dès\r\nle début ?");
                s = s.Replace("I have a wife, <E049><E003 8>sir.<E003 12> <E025 3>And two sons.", "J'ai une femme, <E049><E003 8>monsieur.<E003 12> <E025 3>Et deux fils.");
                s = s.Replace("And without wishing to sound self-conceited, <E049><E003 10><E025 2>they regard\r\nme with some pride.", "Et sans vouloir paraître vaniteux, <E049><E003 10><E025 2>ils me regardent\r\navec une certaine fierté.");
                s = s.Replace("I...<E049><E003 10><E145 126 66><E118 126 1.3><E003 6><E025 3>couldn't bring myself to disappoint them.", "Je...<E049><E003 10><E145 126 66><E118 126 1.3><E003 6><E025 3> ne pouvais me résoudre à les décevoir.");
                s = s.Replace("So instead <E049><E003 8><E025 2>you decided to conceal your occupation from\r\nthem?", "Alors à la place, <E049><E003 8><E025 2>vous avez préféré leur dissimuler\r\nvotre métier ?");
                s = s.Replace("...Yes.", "... Oui.");
                s = s.Replace("I've made such a terrible mess of everything...", "J'ai gâché ma vie de façon si lamentable...");
                s = s.Replace("Still, <E049><E003 10><E025 2>one thing doesn't add up.", "Pourtant, <E049><E003 10><E025 2>une chose ne colle pas.");
                s = s.Replace("No matter how many ‘titbits’ of information you could\r\nsell to passing gentlemen, <E003 6>even at sixpence a piece...", "Peu importe le nombre de « tuyaux » que vous vendiez\r\naux passants, <E003 6>même à six pence l'unité...");
                s = s.Replace("...you couldn't hope to match the salary you must have\r\ncommanded as chief warder at the prison.", "... vous ne pouviez espérer égaler le salaire que vous perceviez\r\nen tant que surveillant-chef de prison.");
                s = s.Replace("Very true.", "C'est très vrai.");
                s = s.Replace("To have kept your family in comfort, <E049><E003 8><E025 2><E333>despite ten years of\r\nsomewhat misbegotten employment...", "Pour avoir maintenu votre famille à l'abri du besoin <E049><E003 8><E025 2><E333>malgré dix ans\r\nd'un emploi pour le moins précaire...");
                s = s.Replace("That was <E049><E003 8>all thanks to Inspector Gregson.", "C'était <E049><E003 8>uniquement grâce à l'inspecteur Gregson.");
                s = s.Replace("Wha...?", "Quo... ?");
                s = s.Replace("Inspector Gregson?!<E049><E003 14> <E025 1><E346>What on earth...?", "L'inspecteur Gregson ?!<E049><E003 14> <E025 1><E346>Mais que diable... ?");
                s = s.Replace("It was some years after I'd invented Boone and begun my\r\nother life as a street seller.", "C'était quelques années après avoir inventé Boone et entamé ma\r\nseconde vie comme camelot.");
                s = s.Replace("He –<E049><E003 6> the inspector, <E003 4>that is – <E049><E003 10><E145 126 64><E118 126 0.4><E003 10><E025 2><E239>recognised me one day.", "Il... <E049><E003 6>l'inspecteur, s'entend... <E049><E003 10><E145 126 64><E118 126 0.4><E003 10><E025 2><E239>m'a reconnu un jour.");
                s = s.Replace("Do you mean to say...<E049><E003 15><E025 1><E145 15 3><E046>the victim was an acquaintance of\r\nyours?!", "Voulez-vous dire...<E049><E003 15><E025 1><E145 15 3><E046> que la victime était une de vos\r\nconnaissances ?!");
                return s;
            };

            // [93] BB\script\output\_sce03_c108_0000_eng#3
            entryTranslators[@"BB\script\output\_sce03_c108_0000_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("I knew him from my time working at the prison.", "Je le connaissais depuis l'époque où je travaillais à la prison.");
                s = s.Replace("When he saw what I'd become, <E003 8>he...<E003 10><E025 3>was deeply troubled\r\nfor me and my family.", "Quand il a vu ce que j'étais devenu, <E003 8>il...<E003 10><E025 3> s'est fait beaucoup\r\nde souci pour moi et pour ma famille.");
                s = s.Replace("And from that day forward, <E003 12>he visited me on Fresno\r\nStreet with increasing regularity.", "Et à compter de ce jour, <E003 12>il m'a rendu visite sur Fresno\r\nStreet de plus en plus régulièrement.");
                s = s.Replace("Then one day...<E049><E003 5><E049><E145 126 71><E144 126><E025 2>he asked me if I would carry out<E049><E003 10> <E333><E025 3><E006>a secret\r\nassignment<E005> for him.", "Puis un jour...<E049><E003 5><E049><E145 126 71><E144 126><E025 2> il m'a demandé d'accomplir<E049><E003 10> <E333><E025 3><E006>une mission\r\nsecrète<E005> pour lui.");
                s = s.Replace("A, <E049><E003 6>a secret...?!<E049><E003 12>\r\n<E145 1 17><E117 1 10><E003 4><E335><E025 1><E342>What was it?!", "U... <E049><E003 6>une mission secrète... ?!<E049><E003 12>\r\n<E145 1 17><E117 1 10><E003 4><E335><E025 1><E342>De quoi s'agissait-il ?!");
                s = s.Replace("I was to...<E049><E003 5><E145 126 74><E144 126><E025 3><E333><E006>impersonate<E005> the inspector.", "Je devais...<E049><E003 5><E145 126 74><E144 126><E025 3><E333><E006>me faire passer<E005> pour l'inspecteur.");
                s = s.Replace("What?!<E049><E003 20>\r\n<E238><E025 2><E006>Impersonate<E005> him?!", "Quoi ?!<E049><E003 20>\r\n<E238><E025 2><E006>Vous faire passer<E005> pour lui ?!");
                s = s.Replace("We always met in that little room so the inspector could\r\nbrief me.", "Nous nous retrouvions toujours dans cette petite pièce pour que\r\nl'inspecteur m'explique ce que je devais faire.");
                s = s.Replace("‘Visit Orczy's tomorrow and take a statement from the\r\nproprietress.’", "« Allez chez Orczy demain et recueillez une déposition de\r\nla gérante. »");
                s = s.Replace("It was always something along those lines.<E049><E003 12>\r\n<E025 2>Surveillance work, <E049><E003 10>interviewing people...", "C'était toujours du même genre.<E049><E003 12>\r\n<E025 2>Des filatures, <E049><E003 10>des interrogatoires...");
                s = s.Replace("On those occasions, <E049><E003 5><E025 2><E145 126 74><E144 126><E333>he would lend me his <E006>identification<E005>\r\nso people would believe who I was.", "Dans ces occasions, <E049><E003 5><E025 2><E145 126 74><E144 126><E333>il me prêtait sa <E006>carte d'identité<E005>\r\npour que les gens me croient.");
                s = s.Replace("My instructions were to make an impression.<E049><E003 12> To let\r\npeople know that Inspector Gregson had been at work.", "J'avais pour consigne de me faire remarquer.<E049><E003 12> Pour que\r\ntout le monde sache que l'inspecteur Gregson était intervenu.");
                s = s.Replace("And for <E006>those services<E005>, <E049><E003 10><E025 2><E145 126 71><E144 126><E333>he compensated me financially.", "Et pour <E006>ces services<E005>, <E049><E003 10><E025 2><E145 126 71><E144 126><E333>il m'accordait une généreuse compensation financière.");
                s = s.Replace("A Scotland Yard inspector willingly relinquished his\r\nidentification into your care with intent to deceive?!", "Un inspecteur de Scotland Yard vous remettait volontairement sa\r\ncarte d'identité avec l'intention de tromper les gens ?!");
                s = s.Replace("That –<E049><E003 6> as I'm sure I need not point out – <E049><E003 10><E145 15 5><E117 15 5><E025 1><E046>is a very serious\r\n<E006>criminal offence<E005>.", "C'est – <E049><E003 6>comme je n'ai point besoin de le rappeler – <E049><E003 10><E145 15 5><E117 15 5><E025 1><E046>une infraction\r\npénale <E006>des plus graves<E005>.");
                s = s.Replace("But why?<E049><E003 15> <E145 112 0><E118 112 0.8><E003 8><E238><E025 2>What was the point of you impersonating him?", "Mais pourquoi ?<E049><E003 15> <E145 112 0><E118 112 0.8><E003 8><E238><E025 2>Quel intérêt avait-il à ce que vous vous fassiez passer pour lui ?");
                s = s.Replace("I...<E049><E003 10><E025 2>I truthfully do not know.<E049><E003 12>\r\n<E025 3>All I can say...", "Je... <E049><E003 10><E025 2>à vrai dire, je l'ignore totalement.<E049><E003 12>\r\n<E025 3>Tout ce que je peux dire...");
                s = s.Replace("...is that the inspector warned me on numerous occasions:", "... c'est que l'inspecteur m'a mis en garde à de multiples reprises :");
                s = s.Replace("Now remember, Vigil.<E049><E003 12>\r\n<E025 3>I need your solemn word.", "Souviens-toi bien de ça, Vigil.<E049><E003 12>\r\n<E025 3>J'veux ta parole d'honneur.");
                s = s.Replace("You don't blab about this to anyone, <E049><E003 6>alright?<E049><E003 18>\r\n<E025 2>Ever!", "Tu n'baves rien sur tout ça à personne, <E049><E003 6>compris ?<E049><E003 18>\r\n<E025 2>Jamais !");
                s = s.Replace("Even if...<E049><E003 14>\r\n<E025 2>Well, <E049><E145 7 70><E118 7 0.7><E003 14><E025 3><E330>if I end up a croaker.", "Même si...<E049><E003 14>\r\n<E025 2>Enfin, <E049><E145 7 70><E118 7 0.7><E003 14><E025 3><E330>si j'viens à casser ma pipe.");
                s = s.Replace("In time, <E003 8>he started to bring papers with him to the room\r\nas well.", "Avec le temps, <E003 8>il a commencé à apporter des dossiers dans la pièce\r\nlui aussi.");
                s = s.Replace("It became something of a second office for him.", "C'était devenu une sorte de second bureau pour lui.");
                s = s.Replace("So...<E003 12>in fact...", "Ainsi...<E003 12> en réalité...");
                s = s.Replace("...the person who declared himself to be Inspector\r\nGregson at the park on Lime Street <E049><E003 10><E025 3><E341>was really...", "... la personne qui a prétendu être l'inspecteur\r\nGregson au parc de Lime Street <E049><E003 10><E025 3><E341>était bel et bien...");
                s = s.Replace("Yes.<E049><E003 12> It was me.<E049><E003 12>\r\nActing on the inspector's orders.", "Oui.<E049><E003 12> C'était moi.<E049><E003 12>\r\nJ'agissais sur les ordres de l'inspecteur.");
                s = s.Replace("As usual, <E049><E003 10><E025 2>I removed my Boone disguise...", "Comme d'habitude, <E049><E003 10><E025 2>j'ai ôté mon déguisement de Boone...");
                s = s.Replace("...and then went as instructed to the park, <E049><E003 10><E025 2>armed with the\r\ninspector's identification book.", "... et je me suis rendu au parc selon ses instructions, <E049><E003 10><E025 2>muni de la\r\ncarte d'identité de l'inspecteur.");
                s = s.Replace("It never occurred to me...<E049><E003 12><E025 3><E333>that the bruise on my neck\r\nmight give me away.", "Il ne m'était jamais venu à l'esprit...<E049><E003 12><E025 3><E333> que la marque sur mon cou\r\npourrait me trahir.");
                return s;
            };
        }
    }
}
