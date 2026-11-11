using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorAct6 {
    public partial class Program {
        public static void RegisterPart4_C() {
            entryTranslators[@"BB\script\output\_macro02_eng#22"] = (en) => {
                string s = en;
                s = s.Replace("These are the Scales of Justice.", "Voici la Balance de la Justice.");
                s = s.Replace("They're a symbol of the defence, aren't they?", "C'est un symbole de la défense, n'est-ce pas ?");
                s = s.Replace("Yes, that's right.", "Oui, c'est exact.");
                s = s.Replace("The scales are a symbol of fairness, to show that all\r\nare treated equally in the eyes of the law.", "La balance est un symbole d'équité, pour montrer que tous\r\nsont traités sur un pied d'égalité aux yeux de la loi.");
                s = s.Replace("And they're a warning to those who enter the courtroom\r\nwithout an impartial mind.", "Et c'est un avertissement pour tous ceux qui pénètrent dans le tribunal\r\nsans un esprit impartial.");
                s = s.Replace("But if they're the mark of the defence...", "Mais si c'est la marque de la défense...");
                s = s.Replace("...it would be more auspicious if they were weighing\r\nmore heavily on the ‘not guilty’ side, I think.", "...ce serait plus de bon augure si elle penchait\r\nun peu plus lourdement du côté « non coupable », je trouve.");
                s = s.Replace("Very impartial, I'm sure.", "Très impartial, n'en doutons point.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#23"] = (en) => {
                string s = en;
                s = s.Replace("The lawyer's name is embroidered on the inside\r\nhere, look.", "Le nom de l'avocat est brodé à l'intérieur\r\nici, regardez.");
                s = s.Replace("‘Kazuma Asogi’...This was his band, of course.", "« Kazuma Asogi »... C'était son brassard, bien sûr.");
                s = s.Replace("He had his heart set on this study tour in Great Britain.", "Il tenait tant à cette mission d'études en Grande-Bretagne.");
                s = s.Replace("I'm sure he would have found the truth he longed\r\nfor here.", "Je suis certain qu'il aurait trouvé la vérité à laquelle il aspirait\r\nici.");
                s = s.Replace("(...But he lost his life before he even had the chance\r\nto see the place.)", "(...Mais il a perdu la vie avant même d'avoir pu\r\nvoir ce pays.)");
                s = s.Replace("I have such a strong sense of his hopes and dreams\r\nwhen I look at this armband, though.", "Pourtant, je ressens si intensément tous ses espoirs et ses idéaux\r\nquand je regarde ce brassard.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#26"] = (en) => {
                string s = en;
                s = s.Replace("(Nothing particular of note...)", "(Rien de particulier à noter...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#27"] = (en) => {
                string s = en;
                s = s.Replace("I can't find anything out of place.", "Je ne trouve rien d'anormal.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#35"] = (en) => {
                string s = en;
                s = s.Replace("If I may, Mr Lune!", "Si vous me le permettez, Monsieur Lune !");
                s = s.Replace("Ah! You like one of a balloons, eh?\r\nPrego, prego. Ten shillings for one!", "Ah ! Vous voulez un de mes ballons, hein ?\r\nPrego, prego. Dix shillings pièce !");
                s = s.Replace("No no, I was going to ask you if that last statement\r\nbothered you for some reason...", "Non non, j'allais vous demander si cette dernière déposition\r\nvous dérangeait pour une raison quelconque...");
                s = s.Replace("People say things to me all the time.", "Les gens me disent des choses en permanence.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("They say avaricious, they say money-grabbing, they say\r\ncheat, full of hot air, stripy swindler!", "On dit avare, on dit rapace, on dit\r\nescroc, plein de vent, fripouille en rayures !");
                s = s.Replace("If I let what the people say bother me, how can I fly my\r\nballoons, uh?", "Si je laissais ce que racontent les gens me troubler, comment pourrais-je faire\r\nvoler mes ballons, hein ?");
                s = s.Replace("Well...I think you just need to fill them up and the gas\r\ndoes most of the work, really.", "Eh bien... je crois qu'il suffit de les gonfler et le gaz\r\nfait le plus gros du travail, en réalité.");
                s = s.Replace("Allora! That is why I refuse to listen to what the people\r\nsay!", "Allora ! Voilà pourquoi je refuse d'écouter ce que racontent\r\nles gens !");
                s = s.Replace("Why should I?! It is nothing good!", "Pourquoi devrais-je ?! Ce n'est jamais rien de bon !");
                s = s.Replace("(Well...if he doesn't listen, that explains a lot.)", "(Eh bien... s'il n'écoute rien, cela explique bien des choses.)");
                s = s.Replace("A balloon with arms and legs, but no faculties with which\r\nto hear...", "Un ballon pourvu de bras et de jambes, mais dénué de tout\r\nappareil auditif...");
                s = s.Replace("...There's no need to get carried away.", "...Inutile de s'emporter à ce point.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#36"] = (en) => {
                string s = en;
                s = s.Replace("Master Gotts, do you have something to say?", "Jeune prince Gotts, avez-vous quelque chose à dire ?");
                s = s.Replace("Something that struck you about what you just heard,\r\nperhaps?", "Quelque chose vous a frappé dans ce qu'on vient d'entendre,\r\npeut-être ?");
                s = s.Replace("Vot I just heard voz you failing to remember my full\r\nname.", "Ce que je viens d'entendre, c'est que vous avez été incapable de vous souvenir de mon\r\nnom complet.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Vich is Wilhelm Gottsreich Sigismond Ormstein.", "Qui est Wilhelm Gottsreich Sigismund Ormstein.");
                s = s.Replace("Uh... Vil...um...", "Euh... Vil... hum...");
                s = s.Replace("My learned friend's powers of recollection are clearly\r\nabysmal. Perhaps he has forgotten where he is...", "La mémoire de mon docte confrère est visiblement\r\ndésastreuse. Peut-être a-t-il oublié où il se trouve...");
                s = s.Replace("Mein teacher at elementary school said zat if you are\r\nrude enough to forget somevun's name...", "Mon maître à l'école élémentaire disait que si vous êtes\r\nassez impoli pour oublier le nom de quelqu'un...");
                s = s.Replace("...you vill have ze most awful life imaginable!", "...vous aurez la vie la plus abominable qui soit !");
                s = s.Replace("(Are all Bohemians brought up to endure a life of such\r\ngreat pain?)", "(Tous les Bohémiens sont-ils éduqués à supporter une vie\r\nde telles souffrances ?)");
                s = s.Replace("Well...well it's important to listen, too!\r\nSo please pay attention to the testimony!", "Eh bien... il est important d'écouter aussi !\r\nAlors prêtez attention au témoignage, je vous prie !");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#37"] = (en) => {
                string s = en;
                s = s.Replace("Miss Lestrade!", "Mademoiselle Lestrade !");
                s = s.Replace("Eh? Blimey, wot's up wiv you?", "Hein ? Bonté divine, qu'est-ce qui t'arrive ?");
                s = s.Replace("Did that last statement strike you as odd in some way,\r\nperhaps?", "Cette dernière déposition vous a-t-elle paru curieuse d'une façon\r\nou d'une autre ?");
                s = s.Replace("You're the expert on bein' odd, ain't ya, 'Oddo?", "C'est toi l'expert en curiosités, pas vrai, 'Hodo ?");
                s = s.Replace("So why don't you tell me?", "Alors pourquoi tu m'le dis pas ?");
                s = s.Replace("No no...I'm the one asking the questions here, Gina.", "Non non... C'est moi qui pose les questions ici, Gina.");
                s = s.Replace("Hah! Askin' other people wot ya don't even know the\r\nanswer to yerself! I don't believe it!", "Hah ! Demander aux autres ce dont tu connais même pas la\r\nréponse toi-même ! J'y crois pas !");
                s = s.Replace("An' I'm INSPECTOR Lestrade, an' all!", "Et j'te rappelle que j'suis L'INSPECTEUR Lestrade, en plus !");
                s = s.Replace("(She just had to drop that title in somehow, didn't she?)", "(Il fallait qu'elle place son titre d'une manière ou d'une autre, pas vrai ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#38"] = (en) => {
                string s = en;
                s = s.Replace("Mr Drebber! Is something wrong?", "Monsieur Drebber ! Quelque chose ne va pas ?");
                s = s.Replace("Mr Drebber!", "Monsieur Drebber !");
                s = s.Replace("It would appear his only answer is that rather bewitching\r\nmechanical wiggle.", "Il semblerait que sa seule réponse soit cette ondulation\r\nmécanique assez fascinante.");
                s = s.Replace("...He could have just said no.", "...Il aurait pu simplement dire non.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#39"] = (en) => {
                string s = en;
                s = s.Replace("Dr Sithe!", "Dre Pétrie !");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("You were clearly just lost in thought about something!", "Vous étiez manifestement perdue dans vos pensées !");
                s = s.Replace("Your jet-black Japanese hair.", "Vos cheveux de jais japonais.");
                s = s.Replace("Pardon?", "Pardon ?");
                s = s.Replace("It made me wonder if perhaps your head was filled with\r\nequally jet-black Indian ink.", "Je me demandais si votre tête n'était pas remplie d'une\r\nencre de Chine tout aussi noire.");
                s = s.Replace("And that the only way to know for sure, would be to cut\r\nyour head open and see.", "Et que le seul moyen de le savoir avec certitude serait de vous ouvrir\r\nla tête pour voir.");
                s = s.Replace("That's what I was thinking.", "Voilà ce à quoi je pensais.");
                s = s.Replace("(Alright, mental note in black sumi ink:\r\nnever pursue Dr Sithe again.)", "(Compris, note mentale à l'encre de Chine noire :\r\nne plus jamais insister auprès de la Dre Pétrie.)");
                s = s.Replace("Mr Naruhodo! You mustn't be intimidated!", "Monsieur Naruhodo ! Ne vous laissez pas intimider !");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#100"] = (en) => {
                string s = en;
                s = s.Replace("Every article on the front page is news about the Great\r\nExhibition.", "Tous les articles en une parlent de la Grande\r\nExposition.");
                s = s.Replace("Public experiments to demonstrate brand-new scientific\r\nideas, cultural exhibits from around the globe...", "Démonstrations publiques d'idées scientifiques novatrices,\r\npavillons culturels des quatre coins du globe...");
                s = s.Replace("It's all so positive and hopeful about the coming century.", "Tout est si positif et porteur d'espoir pour le siècle à venir.");
                s = s.Replace("We must all go to see it properly before too long.", "Nous devrions tous aller la visiter convenablement dès que possible.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#101"] = (en) => {
                string s = en;
                s = s.Replace("‘The Reaper Attacked’...", "« Le Faucheur attaqué »...");
                s = s.Replace("It's the kingpins of the criminal underworld generally\r\nmanaging to escape conviction in the Reaper's trials.", "Ce sont généralement les pontes de la pègre qui réussissent à\r\néchapper à la condamnation lors des procès du Faucheur.");
                s = s.Replace("And this isn't the first time their henchmen have tried to\r\nattack Lord van Zieks as a result, by the sound of it.", "Et ce n'est pas la première fois que leurs hommes de main essaient\r\nd'attaquer Lord Van Peers en représailles, à ce qu'on dit.");
                s = s.Replace("...It makes you think.\r\nIf that's how the justice system works in London...", "...Cela donne à réfléchir.\r\nSi c'est ainsi que fonctionne la justice à Londres...");
                s = s.Replace("...then there must be dark forces at work.", "...alors de bien sombres puissances sont à l'œuvre.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#102"] = (en) => {
                string s = en;
                s = s.Replace("It looks like layers of thick canvas with a thick rubber\r\nlining of sorts.", "On dirait des couches de toile épaisse doublées d'une sorte de\r\ncaoutchouc très lourd.");
                s = s.Replace("I've never seen anything like it before.", "Je n'ai jamais rien vu de tel auparavant.");
                s = s.Replace("But applying Mr Sholmes's methods...", "Mais en appliquant les méthodes de M. Holmes...");
                s = s.Replace("...you might deduce it was part of a raincoat worn by\r\nsomeone who really, really didn't want to get wet.", "...on pourrait en déduire qu'il s'agit d'un fragment d'imperméable porté par\r\nquelqu'un qui ne voulait vraiment, vraiment pas être mouillé.");
                s = s.Replace("And the charring...must have occurred when the person\r\nwas struck by lightning!", "Et les traces de brûlure... proviennent forcément du fait que la personne\r\na été frappée par la foudre !");
                s = s.Replace("Or maybe not.", "Ou peut-être pas.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#103"] = (en) => {
                string s = en;
                s = s.Replace("Ah, there's some sort of lever here...", "Ah, il y a une sorte de levier par ici...");
                s = s.Replace("What the–\r\nWhat is this?!", "Mais qu'est-ce que–\r\nQu'est-ce que c'est que ça ?!");
                s = s.Replace("It, it looks like a cross between a bow and a gun!", "On, on dirait un croisement entre un arc et un fusil !");
                s = s.Replace("(I think it's probably used for the same thing, too.)", "(Et je parie que ça sert probablement au même dessein.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#104"] = (en) => {
                string s = en;
                s = s.Replace("This groove here...must be where the arrows are loaded,\r\nI suppose.", "Cette rainure ici... doit servir à charger les flèches,\r\nje suppose.");
                s = s.Replace("So I was right, it's a sort of bow with an automatic firing\r\nmechanism.", "J'avais donc raison, c'est une sorte d'arc muni d'un mécanisme de tir\r\nautomatique.");
                s = s.Replace("This would be perfect for someone like me who catches\r\nhis ear with the bowstring two times out of three.", "Ce serait parfait pour quelqu'un comme moi qui s'accroche\r\nl'oreille avec la corde deux fois sur trois.");
                s = s.Replace("(In fact, if I'd had one of these, maybe I could have beaten\r\nKazuma in kyudo archery training.)", "(En fait, si j'en avais eu une comme ça, j'aurais peut-être pu battre\r\nKazuma au tir à l'arc kyudo.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#105"] = (en) => {
                string s = en;
                s = s.Replace("It looks like you wind this around in order to draw the\r\nbowstring back and create tension.", "On dirait qu'on tourne ceci pour tendre la corde de l'arc\r\net accumuler la tension.");
                s = s.Replace("You must be able to fire arrows with a huge amount of\r\nforce using this device, then.", "On doit pouvoir décocher des flèches avec une force prodigieuse\r\ngrâce à cet engin, alors.");
                s = s.Replace("In fact, I would imagine it's far more accurate and\r\npowerful than a Japanese longbow.", "À vrai dire, j'imagine que c'est bien plus précis et\r\npuissant qu'un grand arc japonais.");
                s = s.Replace("Ugh... I really had no idea what I was picking up when I\r\nspotted this at the exhibition grounds.", "Argh... Je n'avais vraiment aucune idée de ce que je ramassais quand j'ai\r\nrepéré ça sur le terrain de l'exposition.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#106"] = (en) => {
                string s = en;
                s = s.Replace("There's no question considering the unusual shape of the\r\nhandle...", "Aucun doute possible vu la forme insolite du\r\nmanche...");
                s = s.Replace("This is the screwdriver that was poking through the floor\r\nof the kinesis machine.", "C'est le tournevis qui traversait le plancher\r\nde la machine cinétique.");
                s = s.Replace("It looks a little bit like a capital ‘A’.", "On dirait un peu un « A » majuscule.");
                s = s.Replace("(For ‘Andrew’ I suppose...)", "(Pour « Andrew », j'imagine...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#107"] = (en) => {
                string s = en;
                s = s.Replace("This...is blood. Mr Asman's, no doubt.", "C'est... du sang. Celui de M. Asman, sans doute.");
                s = s.Replace("This is the problem with looking at murder weapons...", "C'est tout le problème quand on examine l'arme d'un crime...");
                return s;
            };

        }
    }
}
