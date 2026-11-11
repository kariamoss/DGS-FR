using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorAct6 {
    public partial class Program {
        public static void RegisterPart4_A() {
            entryTranslators[@"BB\script\output\_sce02_evidence_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("Ah, there's some sort of lever here...", "Ah, il y a une sorte de levier par ici...");
                s = s.Replace("What the–\r\nWhat is this?!", "Mais qu'est-ce que–\r\nQu'est-ce que c'est que ça ?!");
                s = s.Replace("It, it looks like a cross between a bow and a gun!", "On, on dirait un croisement entre un arc et un fusil !");
                s = s.Replace("(I think it's probably used for the same thing, too.)", "(Et je parie que ça sert probablement au même dessein.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose.");
                s = s.Replace("So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique.");
                s = s.Replace("This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois.");
                s = s.Replace("(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose.");
                s = s.Replace("So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique.");
                s = s.Replace("This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois.");
                s = s.Replace("(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension.");
                s = s.Replace("You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors.");
                s = s.Replace("In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais.");
                s = s.Replace("Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension.");
                s = s.Replace("You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors.");
                s = s.Replace("In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais.");
                s = s.Replace("Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#24"] = (en) => {
                string s = en;
                s = s.Replace("I've seen this unusually shaped handle before.", "J'ai déjà vu ce manche à la forme inhabituelle auparavant.");
                s = s.Replace("It's the same screwdriver that was lodged in the grille on\r\nthe floor of the kinesis machine.", "C'est le même tournevis qui était coincé dans la grille au sol\r\nde la machine cinétique.");
                s = s.Replace("(Which could be important information, so I should\r\ndefinitely make a note of it.)", "(Ce qui pourrait être un indice capital, je devrais\r\nsans faute le noter.)");
                s = s.Replace("The details of the screwdriver\r\nhave been updated in the Court Record.", "Les détails du tournevis\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#25"] = (en) => {
                string s = en;
                s = s.Replace("There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche...");
                s = s.Replace("This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique.");
                s = s.Replace("It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule.");
                s = s.Replace("(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#26"] = (en) => {
                string s = en;
                s = s.Replace("There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche...");
                s = s.Replace("This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique.");
                s = s.Replace("It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule.");
                s = s.Replace("(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#28"] = (en) => {
                string s = en;
                s = s.Replace("This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute.");
                s = s.Replace("This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#29"] = (en) => {
                string s = en;
                s = s.Replace("This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute.");
                s = s.Replace("This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#30"] = (en) => {
                string s = en;
                s = s.Replace("The front of the card doesn't give much away, does it?\r\n(PROVISIONAL)", "Le recto de la carte ne révèle pas grand-chose, pas vrai ?");
                s = s.Replace("No, not at all.\r\n(PROVISIONAL)", "Non, pas du tout.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#31"] = (en) => {
                string s = en;
                s = s.Replace("This dark smudge here...", "Cette tache sombre ici...");
                s = s.Replace("I think perhaps it's machine oil.", "Je pense que c'est sans doute de l'huile pour machine.");
                s = s.Replace("Ah, yes, possibly. Professor Harebrayne mentioned\r\nsomething about the oil Mr Drebber uses, didn't he?", "Ah, oui, possible. Le professeur Lonron a mentionné\r\nquelque chose à propos de l'huile employée par M. Drebber, n'est-ce pas ?");
                s = s.Replace("He said it was specially imported very high-quality oil\r\nthat's impossible to obtain in Britain.", "Il a dit que c'était une huile importée de très haute qualité,\r\nintrouvable en Grande-Bretagne.");
                s = s.Replace("Yes, that's right.\r\nBut more importantly...", "Oui, c'est exact.\r\nMais plus important encore...");
                s = s.Replace("...that it's more fragrant than the finest perfume!\r\nSo...excuse me a moment...", "...qu'elle est plus parfumée que le plus fin des parfums !\r\nAlors... excusez-moi un instant...");
                s = s.Replace("Oh, it doesn't appear to have any scent at all.", "Oh, elle ne semble dégager absolument aucune odeur.");
                s = s.Replace("Don't worry, I, I expect that's just because there's such a\r\ntiny amount on here.", "Ne vous en faites pas, j... j'imagine que c'est parce qu'il n'y en a qu'une\r\nquantité infime ici.");
                s = s.Replace("The details of Drebber's card\r\nhave been updated in the Court Record.", "Les détails de la carte de Drebber\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#33"] = (en) => {
                string s = en;
                s = s.Replace("Ah! Look here, Miss Susato...", "Ah ! Regardez ici, Mademoiselle Susato...");
                s = s.Replace("Oh yes, the wood's cracked and broken a little.\r\nI suppose because it fell from such a height?", "Oh oui, le bois est fendu et un peu cassé.\r\nSans doute parce qu'elle est tombée de si haut ?");
                s = s.Replace("Yes, from the height at which the balloon was flying,\r\ndown into the Crystal Tower below.", "Oui, depuis l'altitude à laquelle le ballon volait,\r\njusque dans la Tour de Cristal en dessous.");
                s = s.Replace("A fall of about thirty feet.\r\n...Or nine metres.", "Une chute d'une dizaine de mètres.\r\n...Soit une trentaine de pieds.");
                s = s.Replace("Leaving the man inside tragically dead.", "Laissant l'homme à l'intérieur tragiquement mort.");
                s = s.Replace("The details of the wooden birdcage\r\nhave been updated in the Court Record.", "Les détails de la cage en bois\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#35"] = (en) => {
                string s = en;
                s = s.Replace("This piece of glass is almost as thick as it is wide.", "Ce morceau de verre est presque aussi épais que large.");
                s = s.Replace("Yes, I've never seen anything like it.", "Oui, je n'ai jamais rien vu de semblable.");
                s = s.Replace("If you were to compare it to a human, only Mr Sholmes\r\nhas such thick skin.", "Si on devait le comparer à un être humain, seul M. Holmes\r\na une carapace aussi épaisse.");
                s = s.Replace("There's really no need for such a comparison,\r\nMr Naruhodo, as you well know.", "Une telle comparaison n'était vraiment pas nécessaire,\r\nMonsieur Naruhodo, comme vous le savez bien.");
                s = s.Replace("...Anyway, it can only be from the Crystal Tower, surely?", "...Quoi qu'il en soit, il ne peut venir que de la Tour de Cristal, sûrement ?");
                s = s.Replace("Yes, I think so, too. It was probably made especially to\r\nmeet the demands of that great structure.", "Oui, je le pense aussi. Il a sans doute été façonné sur mesure pour\r\nrépondre aux contraintes de cette formidable structure.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#36"] = (en) => {
                string s = en;
                s = s.Replace("What a wonderful machine!", "Quelle merveilleuse machine !");
                s = s.Replace("You really love contraptions like this, don't you?", "Vous aimez vraiment ce genre d'engins, n'est-ce pas ?");
                s = s.Replace("Oh yes! Anything mechanical I find absolutely irresistible.", "Oh oui ! Tout ce qui est mécanique m'est absolument irrésistible.");
                s = s.Replace("Almost irresistible, surely?", "Presque irrésistible, sans doute ?");
                s = s.Replace("Well, whenever I see a pocket watch, for example, I can't\r\nhelp myself. I simply have to take it apart.", "Eh bien, chaque fois que je vois une montre à gousset, par exemple, je ne peux pas\r\nm'en empêcher. Il faut absolument que je la démonte.");
                s = s.Replace("That's...worrying.", "C'est... inquiétant.");
                s = s.Replace("Yes, Father tells the time by the rumblings of his stomach\r\nnow. He's given up having a watch.", "Oui, Père lit l'heure aux gargouillis de son ventre\r\nà présent. Il a renoncé à porter une montre.");
                s = s.Replace("(Poor Professor Mikotoba...)", "(Pauvre professeur Mikotoba...)");
                return s;
            };

        }
    }
}
