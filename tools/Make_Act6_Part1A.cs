using System;
using System.IO;
using System.Text;

class MakeAct6Part1A {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart1_A() {");

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

        // [1] KEY:BB\script\output\_sce02_chr010_00_eng#1
        add(@"BB\script\output\_sce02_chr010_00_eng#1", new string[,] {
            { "Half a year ago now...", "Il y a six mois maintenant..." },
            { "...I took on the defence of a young girl in a trial heard at\r\nthe Old Bailey.", "...j'ai pris la défense d'une jeune fille lors d'un procès\r\nà l'Old Bailey." },
            { "What at first seemed like a simple case of murder that\r\ntook place at a London pawnbrokery...", "Ce qui semblait être une simple affaire de meurtre\r\ndans une boutique de prêt sur gage londonienne..." },
            { "...turned out to be one part of a much more far-reaching\r\nplot that involved the British government.", "...s'est révélé faire partie d'un complot bien plus vaste\r\nimpliquant le gouvernement britannique." },
            { "During the course of the trial...", "Au cours du procès..." },
            { "...it was found that I made an unavoidable, ", "...il est apparu que j'avais commis une inévitable, " },
            { "yet at the same\r\ntime, ", "et pourtant, " },
            { "unforgivable mistake.", "impardonnable erreur." },
            { "Words fail me.", "Les mots me manquent." },
            { " This situation is...", " Cette situation est..." },
            { "utterly deplorable.", "absolument déplorable." },
            { "Mr Naruhodo!", "Monsieur Naruhodo !" },
            { "Yes, ", "Oui, " },
            { "My Lord!", "Votre Seigneurie !" },
            { "I will decide upon your fate following the conclusion of\r\nthis trial.", "Je scellerai votre sort dès la conclusion de ce procès." },
            { "Of course, ", "Bien entendu, " },
            { "My Lord.", "Votre Seigneurie." },
            { "In the end, ", "Au bout du compte, " },
            { "I had my right to represent people in court\r\nrevoked.", "mon droit d'exercer au barreau m'a été retiré." },
            { "I was told I had to spend my time in research and study,", "On m'a ordonné de consacrer mon temps à l'étude et aux recherches," },
            { "so that's what I've been doing.", "c'est donc exactement ce que j'ai fait." },
            { "You have, ", "C'est bien vrai, " },
            { "haven't you, Runo?", "n'est-ce pas, Ryuno ?" },
            { "Reading all those big, ", "À lire tous ces gros, " },
            { "fat tomes about British law up in\r\nyour room.", "énormes tomes de droit britannique là-haut dans ta chambre." },
            { " And the notes about Sholmes's old cases.", " Et les notes sur les vieilles affaires de Sherlock." },
            { "Brewing Iris's special blends of tea...", "À préparer les mélanges de thé spéciaux d'Iris..." },
            { "Fetching my daily bread for me...", "À aller chercher mon pain quotidien..." },
            { "You've become something of a manservant around here.", "Tu es devenu une sorte de majordome par ici." },
            { "Start on the silverware next, ", "Occupe-toi de l'argenterie la prochaine fois, " },
            { "Master Naruhodo.", "Maître Naruhodo." },
            { "Well", "Eh bien" },
            { "I'm thinking of going to ask the powers that be to\r\nreconsider.", "je songe à aller demander aux hautes instances de reconsidérer la chose." },
            { "Specifically Lord Stronghart, ", "Plus particulièrement à Lord Harry Caine, " },
            { "at the British Supreme Court\r\non Whitehall.", "à la Cour suprême britannique de Whitehall." },
            { "Lord Stronghart?!", "Lord Harry Caine ?!" },
            { "Ah, ", "Ah, " },
            { "the delightful Lord Chief Justice?", "notre si charmant Lord Chancelier ?" },
            { "...Not my favourite fellow.", "...Pas vraiment ma tasse de thé." },
            { "He's not mine, either.", "La mienne non plus." },
            { "But he's the man I have to talk to.", "Mais c'est à lui que je dois m'adresser." },
            { "He's the only one who can grant permission for me to\r\nstart working in the courts again.", "Lui seul peut m'autoriser à plaider à nouveau dans les tribunaux." },
            { "(I came to Britain to become the best lawyer I could.)", "(Je suis venu en Grande-Bretagne pour devenir le meilleur avocat possible.)" },
            { "(And I can't do that just sitting around here!)", "(Et ce n'est pas en restant assis ici que j'y parviendrai !)" }
        });

        // [2] KEY:BB\script\output\_sce02_chr010_00_eng#2
        add(@"BB\script\output\_sce02_chr010_00_eng#2", new string[,] {
            { "The whole of London has been swept up in this Great\r\nExhibition, ", "Tout Londres est emporté par la fièvre de cette Exposition universelle, " },
            { "hasn't it?", "n'est-ce pas ?" },
            { "The most advanced science, ", "La science la plus avancée, " },
            { "the most modern technology,", "la technologie la plus moderne," },
            { "the finest works of art and feats of engineering...", "les plus beaux chefs-d'œuvre et exploits d'ingénierie..." },
            { "For the next six months, ", "Durant les six prochains mois, " },
            { "our capital will be showcasing\r\nthese things, ", "notre capitale sera la vitrine de toutes ces merveilles, " },
            { "and the world will be watching!", "et le monde entier aura les yeux rivés sur nous !" },
            { "Oh, ", "Oh, " },
            { "do you know what I'd like to do?", "tu sais ce que j'aimerais faire ?" },
            { "I'd like to look down\r\non London from one of those lovely balloons!", "J'aimerais contempler Londres depuis l'une de ces magnifiques montgolfières !" },
            { "L-", "C-" },
            { "Look down on", "Contempler" },
            { "Do, ", "Tu... " },
            { "do you mean ", "tu veux dire que " },
            { "those things...", "ces engins..." },
            { "...fly?", "...volent ?" },
            { "Yes, ", "Oui, " },
            { "of course!", "bien sûr !" },
            { "They fly high in the sky and don't even\r\nneed wings to do it!", "Ils s'élèvent tout en haut dans le ciel sans même avoir besoin d'ailes !" },
            { " All you need is hot air!", " Tout ce qu'il faut, c'est de l'air chaud !" },
            { "But how?!", "Mais comment ?!" },
            { "How does hot air have anything to do with\r\nflying?!", "Quel rapport l'air chaud peut-il bien avoir avec le vol ?!" },
            { "It makes no sense!", "Ça n'a aucun sens !" },
            { "I can't ", "Je n'y comprends " },
            { "understand it at all...", "absolument rien..." },
            { "That's true of a lot of new scientific discoveries.", "C'est le propre de bien des découvertes scientifiques." },
            { "Most people can't understand them at first.", "La plupart des gens ne les comprennent pas au début." },
            { "But in a hundred years' time, ", "Mais dans cent ans d'ici, " },
            { "all these things will just be\r\ncommon knowledge.", "tout cela fera partie du savoir commun." },
            { "I...", "Je..." },
            { "suppose they might be.", "suppose que c'est possible." },
            { "Mind you, ", "Remarquez, " },
            { "some of the science being demonstrated seems\r\nvery questionable. ", "certaines expériences présentées semblent bien douteuses. " },
            { "Something went wrong on the open experimentation stage\r\nyesterday, apparently.", "Quelque chose a mal tourné sur la scène d'expérimentation hier, paraît-il." },
            { " There was a huge explosion.", " Il y a eu une terrible explosion." },
            { "Still, ", "Pourtant, " },
            { "I wish I'd seen it, though! ", "j'aurais tant voulu voir ça ! " },
            { "I'd love to see how bad\r\nsome of these scam experiments really are!", "J'adorerais voir à quel point ces expériences d'arnaqueurs tournent au fiasco !" },
            { "(Says the innocent ten-year-old girl...)", "(Dit la petite fille innocente de dix ans...)" },
            { "See here.", "Regardez ici." },
            { "Every page of this paper carries some article or\r\nother about the Great Exhibition.", "Chaque page de ce journal contient un article ou un autre sur l'Exposition universelle." },
            { "But the brighter things shine, ", "Mais plus la lumière est vive, " },
            { "the darker the shadows that\r\nare cast behind them.", "plus sombres sont les ombres projetées à l'arrière." },
            { "Personally, ", "Personnellement, " },
            { "I find myself drawn to the darkness.", "je me sens irrésistiblement attiré par les ténèbres." },
            { "To the impenetrable.", "Vers l'impénétrable." },
            { " That is my proper atmosphere.", " Tel est mon élément naturel." },
            { "(‘Shadows cast behind’...?", "(« Des ombres à l'arrière »... ?" },
            { "Is that a metaphorical way of\r\nreferring to the back page of the paper?)", "Est-ce une métaphore pour désigner la dernière page du journal ?)" }
        });

        // [3] KEY:BB\script\output\_sce02_chr010_00_eng#3
        add(@"BB\script\output\_sce02_chr010_00_eng#3", new string[,] {
            { "The Great Exhibition newspaper has been\r\nentered into the Court Record.", "Le journal de l'Exposition universelle a été\r\najouté au dossier de l'affaire." },
            { "(‘Shadows cast behind’...?", "(« Des ombres à l'arrière »... ?" },
            { "Is that a metaphorical way of\r\nreferring to the back page of the paper?)", "Est-ce une métaphore pour désigner la dernière page du journal ?)" }
        });

        // [4] KEY:BB\script\output\_sce02_chr010_00_eng#4
        add(@"BB\script\output\_sce02_chr010_00_eng#4", new string[,] {
            { "Are you investigating a particularly tricky case at the\r\nmoment, ", "Êtes-vous sur une affaire particulièrement épineuse en ce moment, " },
            { "Mr Sholmes?", "monsieur Holmes ?" },
            { "Hm, ", "Hum, " },
            { "you could say that, ", "on pourrait dire cela, " },
            { "I suppose.", "je présume." },
            { "(Nothing more to add?", "(Rien de plus à ajouter ?" },
            { "That's not like you...)", "Ça ne lui ressemble guère...)" },
            { "What sort of case is it?", "De quel genre d'affaire s'agit-il ?" },
            { "Shh!", "Chut !" },
            { "Quiet, ", "Silence, " },
            { "Mr Naruhodo!", "monsieur Naruhodo !" },
            { "We must not discuss it here.", "Nous ne devons pas en discuter ici." },
            { "You never know who might be listening.", "On ne sait jamais qui pourrait nous écouter." },
            { "You're acting very strangely, ", "Tu te comportes très bizarrement, " },
            { "Hurley.", "Sherlockinou." },
            { "What do you mean, ", "Que veux-tu dire par là, " },
            { "Iris?", "Iris ?" },
            { "Well usually...", "D'habitude..." },
            { "...the more mysterious and complicated a case is,", "...plus une affaire est mystérieuse et complexe," },
            { " the\r\nbetter Hurley's mood. ", " meilleure est l'humeur de Sherlockinou. " },
            { "Ah.", "Ah." },
            { "Is it really a case that's bothering you?", "Est-ce vraiment une enquête qui te tracasse ?" },
            { "Iris, ", "Iris, " },
            { "please!", "je t'en prie !" },
            { " You mustn't exercise your astute powers of\r\nobservation and deduction on me without invitation!", " Tu ne dois point exercer tes remarquables déductions sur ma personne sans y avoir été conviée !" },
            { "Remember what I always say:", "Rappelle-toi ce que je répète toujours :" },
            { "put yourself in the shoes of\r\nthe individual about whom you're making deductions!", "mets-toi à la place de la personne sur laquelle tu déduis !" },
            { "You say that, ", "C'est vous qui dites ça, " },
            { "do you?", "n'est-ce pas ?" },
            { "You...", "Vous..." },
            { "Mr Sholmes...", "monsieur Holmes..." },
            { "Never mind.", "Peu importe." },
            { " Once I've had a cup of tea, ", " Une fois que j'aurai bu ma tasse de thé, " },
            { "I must make my\r\nway at once to the crime scene.", "je devrai me rendre sur-le-champ sur la scène du crime." },
            { "Haaaaaah...", "Haaaaaah..." },
            { "(That was a deep sigh...)", "(Quel profond soupir...)" }
        });

        // [5] KEY:BB\script\output\_sce02_chr010_00_eng#5
        add(@"BB\script\output\_sce02_chr010_00_eng#5", new string[,] {
            { "It says in the paper that Lord van Zieks was attacked!", "Le journal annonce que Lord Van Peers a été attaqué !" },
            { "That's terrible!", "C'est épouvantable !" },
            { "You know the legend of the Reaper of the Bailey of\r\ncourse, ", "Vous connaissez la légende du Faucheur de l'Old Bailey, " },
            { "don't you?", "n'est-ce pas ?" },
            { "Only too well, ", "Bien trop bien, " },
            { "in fact.", "en vérité." },
            { "Yes.", "Oui." },
            { "(Prosecutor Barok van Zieks...)", "(Le procureur Drake Van Peers...)" },
            { "They say that if the Reaper is the prosecutor in a case,", "On raconte que si le Faucheur mène l'accusation lors d'un procès," },
            { "there's no salvation for whoever's in the dock...", "il n'y a nul salut pour l'accusé sur le banc d'infamie..." },
            { "...even if the defendant is found not guilty.", "...quand bien même il serait déclaré non coupable." },
            { "Once the Reaper has someone in his sights...", "Dès lors que le Faucheur a posé son regard sur quelqu'un..." },
            { "one way or\r\nanother, ", "d'une manière ou d'une autre, " },
            { "that person's time left on this earth will be short.", "les jours de cette personne sur terre sont comptés." },
            { "London's finest rogues always find ways around the law.", "La pègre londonienne trouve toujours des subterfuges pour contourner la loi." },
            { "They'll stop at nothing to secure an acquittal at trial.", "Ces criminels ne reculent devant rien pour obtenir un acquittement." },
            { "Falsifying evidence, ", "Falsification de preuves, " },
            { "paying sham witnesses, ", "faux témoins soudoyés, " },
            { "threatening\r\njurors, ", "jurés menacés, " },
            { "bribing judges.", "juges corrompus." },
            { "But even such devious tactics as these cannot save them\r\nfrom the hand of the Reaper.", "Pourtant, même de tels stratagèmes ne peuvent les arracher à la faux du Faucheur." },
            { "As you've experienced yourself, ", "Vous en avez fait vous-même l'expérience, " },
            { "haven't you,", "n'est-ce pas," },
            { "Mr Naruhodo?", "monsieur Naruhodo ?" },
            { "...Yes.", "...Oui." },
            { "I've seen the Reaper's ‘retribution’ at work.", "J'ai vu le « châtiment » du Faucheur à l'œuvre." },
            { "Many of these criminal rogues are reckless and quite\r\nunafraid to die.", "Bon nombre de ces scélérats sont téméraires et n'ont pas peur de la mort." },
            { "If a leader among their fraternity is seen to have been\r\n‘taken’ by the Reaper, ", "Si l'un des caïds de leur confrérie est « fauché », " },
            { "retaliation like this does occur.", "de telles représailles peuvent se produire." },
            { "Really, ", "À vrai dire, " },
            { "the capital has a never-ending supply of such\r\nscoundrels.", "la capitale regorge d'une réserve inépuisable de vauriens." },
            { "So...", "Alors..." },
            { "Do you mean...", "Voulez-vous dire..." },
            { "...Lord van Zieks has been attacked like this before?", "...que Lord Van Peers a déjà été attaqué de la sorte ?" },
            { "This isn't the first time?", "Ce n'est pas la première fois ?" },
            { "He's quite an accomplished combatant, ", "C'est un combattant hors pair, " },
            { "you know.", "vous savez." },
            { "He doesn't take these attacks lying down.", "Il ne s'en laisse pas conter lors de ces assauts." },
            { "Although...", "Cependant..." },
            { "it seems that his assailants were armed with\r\nguns this time.", "il paraît que cette fois, ses agresseurs étaient armés de fusils." },
            { "Oh my goodness!", "Grands dieux !" },
            { "Is, ", "Est-il... " },
            { "is he alright, then?", "va-t-il bien ?" },
            { "Is Lord van Zieks hurt?", "Lord Van Peers est-il blessé ?" },
            { "My dear fellow...", "Mon cher ami..." },
            { "how on earth would I know?", "comment diable pourrais-je le savoir ?" },
            { "Well, ", "Eh bien, " },
            { "in the article here it says:", "il est écrit dans l'article :" },
            { "‘As to what of Lord van Zieks and his condition?", "« Qu'en est-il de Lord Van Peers et de son état ?" },
            { "All will be revealed in tomorrow's morning edition!’", "Tout vous sera révélé dans notre édition matinale de demain ! »" },
            { "Ah, ", "Ah, " },
            { "I see.", "je vois." },
            { "Well, ", "Dans ce cas, " },
            { "we shall have to be patient then.", "il nous faudra patienter." },
            { "No no no!", "Non, non, non !" },
            { "I can't wait until tomorrow!", "Je ne peux pas attendre jusqu'à demain !" },
            { "In that case, ", "Dans ce cas, " },
            { "you shall have to enquire with somebody in\r\nthe know.", "il vous faudra vous renseigner auprès d'une personne bien informée." },
            { "But...", "Mais..." },
            { "who?", "qui ?" },
            { "(Lord Stronghart...perhaps?)", "(Lord Harry Caine... peut-être ?)" }
        });

        // [6] KEY:BB\script\output\_sce02_chr010_00_eng#10
        add(@"BB\script\output\_sce02_chr010_00_eng#10", new string[,] {
            { "Um, Mr Sholmes, ", "Euh, monsieur Holmes, " },
            { "about this...", "à propos de ceci..." },
            { "My dear fellow, ", "Mon cher ami, " },
            { "without wishing to sound rude...", "sans vouloir paraître discourtois..." },
            { "...I'm currently in the middle of a very important blink.", "...je suis actuellement en plein milieu d'un clignement de paupières crucial." },
            { "Perhaps some other, more convenient time, ", "Peut-être un autre moment plus opportun, " },
            { "hm?", "hum ?" },
            { "...Is there a set time for your ‘important’ blinks, ", "...Y a-t-il une heure précise pour vos clignements « cruciaux », " },
            { "or are\r\nthey an all-day affair?", "ou est-ce une affaire qui dure toute la journée ?" },
            { " Just so I know...", " C'est juste pour savoir..." }
        });

        // [7] KEY:BB\script\output\_sce02_chr010_00_eng#11
        add(@"BB\script\output\_sce02_chr010_00_eng#11", new string[,] {
            { "Mr Sholmes, ", "Monsieur Holmes, " },
            { "would you cast your eyes over this\r\nphotographic print?", "voudriez-vous jeter un œil à ce cliché photographique ?" },
            { "It's of Mr Enoch Drebber...", "Il s'agit de M. Enoch Drebber..." },
            { "The face of the engineer we seek.", "Le visage de l'ingénieur que nous cherchons." },
            { "all Englishmen look broadly the same, of course.", "tous les Anglais se ressemblent plus ou moins, évidemment." },
            { "So looking at the photograph won't...", "Alors regarder cette photographie ne sera pas particulièrement..." },
            { "be particularly", "" },
            { "instructive", "instructif" },
            { "Are you alright,", "Vous vous sentez bien," },
            { " Mr Sholmes?", " monsieur Holmes ?" },
            { "Ah.", "Ah." },
            { "Yes,", "Oui," },
            { " forgive me.", " pardonnez-moi." },
            { "Very interesting, this.", "Très intéressant, ma foi." },
            { " Very interesting indeed.", " Vraiment très intéressant." },
            { "What's wrong,", "Qu'y a-t-il," },
            { " Mr Sholmes?", " monsieur Holmes ?" },
            { " You've turned quite pale all\r\nof a sudden...", " Vous avez blêmi d'un seul coup..." }
        });

        // [8] KEY:BB\script\output\_sce02_chr010_00_eng#12
        add(@"BB\script\output\_sce02_chr010_00_eng#12", new string[,] {
            { "Mr Sholmes, ", "Monsieur Holmes, " },
            { "about this...", "à propos de ceci..." },
            { "As you will see,", "Comme vous pouvez le constater," },
            { " I'm rather busy at the moment.", " je suis quelque peu occupé présentement." },
            { "If it's advice you seek, ", "Si vous cherchez un conseil, " },
            { "come to my office tomorrow and I\r\nshall be happy to help you.", "venez à mon bureau demain et je me ferai une joie de vous aider." },
            { "Shall we say", "Disons" },
            { "thruppence per item as a consultation fee?", "trois pence par pièce en guise d'honoraires de consultation ?" },
            { "(That's two hours of gas, that is...)", "(Ça fait deux heures de gaz, ça...)" }
        });

        // [9] KEY:BB\script\output\_sce02_chr010_00_eng#13
        add(@"BB\script\output\_sce02_chr010_00_eng#13", new string[,] {
            { "Oh,", "Oh," },
            { " um,", " euh," },
            { " Mr Sholmes,", " monsieur Holmes," },
            { "about this...", "à propos de ceci..." },
            { "Shh!", "Chut !" },
            { " Not another word!", " Pas un mot de plus !" },
            { "...Ah, yes,", "...Ah, oui," },
            { " I see...", " je vois..." },
            { "This would be a collar...", "Il s'agirait d'un collier..." },
            { "for a breed of miniature canine", "pour une race de canidé miniature" },
            { "with a particularly long neck.", "au cou singulièrement allongé." },
            { "And for winter use!", "Et taillé pour l'hiver !" },
            { "Actually...", "En réalité..." },
            { "it's the armband I always wear", "c'est le brassard que je porte toujours" },
            { " that symbolises\r\nmy role as a defence lawyer...", " attestant de ma fonction d'avocat de la défense..." },
            { "Precisely!", "Précisément !" },
            { " Which leads us to but one conclusion:", " Ce qui ne nous amène qu'à une seule et unique conclusion :" },
            { "Your arm is", "Votre bras est" },
            { " in fact", " en vérité" },
            { "the particularly long neck of a\r\nminiature canine!", "le cou particulièrement long d'un canidé miniature !" },
            { "(I'm starting to wish I'd never shown him this now.", "(Je commence à regretter de lui avoir montré ça." },
            { "The man's barking mad...)", "Cet homme est complètement timbré...)" }
        });

        // [10] KEY:BB\script\output\_sce02_chr010_00_eng#14
        add(@"BB\script\output\_sce02_chr010_00_eng#14", new string[,] {
            { "Mr Sholmes, ", "Monsieur Holmes, " },
            { "would you have a look at this newspaper?", "auriez-vous l'obligeance de regarder ce journal ?" },
            { "You've been into my room and helped yourself,", "Vous êtes allé dans ma chambre vous servir sans vergogne," },
            { " have\r\nyou?", "n'est-ce pas ?" },
            { "...Let's not turn this into a scandal, ", "...Ne transformons point cela en incident diplomatique, " },
            { "shall we?", "voulez-vous ?" },
            { "considering I've already read it, ", "étant donné que je l'ai déjà lu, " },
            { "one thing\r\nimmediately strikes me:", "une chose me frappe immédiatement :" },
            { "this paper is old news!", "ce journal date d'hier !" },
            { "Haah...", "Haah..." },
            { "What would possess you to show me this?", "Quelle mouche vous a piqué pour me montrer ceci ?" },
            { "What's done is done!", "Ce qui est fait est fait !" },
            { "You must distinguish, ", "Vous devez faire le tri, " },
            { "my dear fellow!", "mon cher ami !" },
            { "Distinguish the old from the new!", "Distinguer le révolu de l'inédit !" },
            { "(There are some conversations you wish you'd never\r\nstarted...)", "(Il y a des conversations qu'on aimerait n'avoir jamais engagées...)" }
        });

        // [11] KEY:BB\script\output\_sce02_chr010_00_eng#15
        add(@"BB\script\output\_sce02_chr010_00_eng#15", new string[,] {
            { "Mr Sholmes, ", "Monsieur Holmes, " },
            { "could you look at this photograph again?", "pourriez-vous regarder cette photographie à nouveau ?" },
            { "I see.", "Je vois." },
            { " So that's it...", " Ainsi donc..." },
            { "What?", "Quoi ?" },
            { "Have you worked something out?!", "Avez-vous compris quelque chose ?!" },
            { "There is indeed", "Il y a en effet" },
            { " one deduction to be made from this\r\nphotograph,", " une déduction à tirer de cette photographie," },
            { " yes.", " oui." },
            { "Each time you show it to me,", "Chaque fois que vous me la montrerez," },
            { " it will cost you five shillings.", " il vous en coûtera cinq shillings." },
            { "Otherwise...", "Autrement..." },
            { "I have nothing to add.", "je n'ai rien d'autre à ajouter." },
            { "...Wonderful.", "...Merveilleux." },
            { " And nothing for me to take away either.", " Et moi rien à en tirer non plus." }
        });

        // [12] KEY:BB\script\output\_sce02_chr010_00_eng#16
        add(@"BB\script\output\_sce02_chr010_00_eng#16", new string[,] {
            { "Odie Asman...", "Odoril Asman..." },
            { "Yes,", "Oui," },
            { " a fearsome adversary.", " un adversaire redoutable." },
            { "What?", "Comment ?" },
            { "You,", "Vous..." },
            { " you mean you've fought him?", " vous voulez dire que vous l'avez affronté ?" },
            { "I once infiltrated his criminal organisation in order to\r\ninvestigate the man and his activities.", "J'ai jadis infiltré son organisation criminelle afin d'enquêter sur l'individu et ses agissements." },
            { "But he saw through my disguise instantly.", "Mais il a percé mon déguisement à jour instantanément." },
            { "I still remember ", "Je me rappelle encore " },
            { "what the man said to me now.", "ce que cet homme m'a lancé." },
            { "...What was it?", "...Et qu'a-t-il dit ?" },
            { "‘Whoever saw", "« Qui a jamais vu" },
            { " such a tall old lady?’", " une si grande vieille dame ? »" },
            { "Old lady?", "Vieille dame ?" },
            { "Indeed!", "Parfaitement !" },
            { " But my special disguise hasn't seen the light of\r\nday again since that humiliation.", " Mais mon déguisement secret n'a plus jamais revu la lumière du jour depuis cette humiliation." },
            { "Mrs Minicle", "Mme Minicle" },
            { " is retired!", " a pris sa retraite !" },
            { "(Mrs Minicle?", "(Mme Minicle ?" },
            { " I would give my right arm to see that!)", " Je donnerais mon bras droit pour voir ça !)" }
        });

        // [13] KEY:BB\script\output\_sce02_chr010_00_eng#17
        add(@"BB\script\output\_sce02_chr010_00_eng#17", new string[,] {
            { "What is this place?", "Quel est cet endroit ?" },
            { "Madame Tusspells came to London from France three\r\nyears ago, ", "Madame Pétrie est arrivée de France à Londres il y a trois ans de cela, " },
            { "I understand.", "si j'ai bien compris." },
            { "Since she opened this little waxwork museum last year,", "Depuis qu'elle a ouvert ce petit musée de cire l'an dernier," },
            { "it's enjoyed great popularity in London.", "il connaît un immense succès à Londres." },
            { "There are museums like this in Japan, too.", "Il existe des musées de ce genre au Japon également." },
            { "But these displays are something else!", "Mais ces statues sont tout bonnement stupéfiantes !" },
            { "I mean...", "Je veux dire..." },
            { "they aren't made from actual real people, ", "elles ne sont pas faites à partir de vraies personnes, " },
            { "are\r\nthey?", "au moins ?" },
            { "The extreme realism of these waxwork models is a\r\nparticular secret of the Tusspells family, ", "Le réalisme saisissant de ces statues de cire est le grand secret de la famille Pétrie, " },
            { "they say.", "dit-on." },
            { "They earned renown during the French Revolution for\r\nwaxworks of victims of the guillotine.", "Leur renommée s'est forgée lors de la Révolution française grâce aux bustes des suppliciés de la guillotine." },
            { "Ugh...", "Pouah..." },
            { " That sounds grim.", " C'est plutôt macabre." },
            { "The gruesome scenes were portrayed with such realism\r\nin the expressions of the faces of the condemned.", "Les scènes d'horreur étaient immortalisées avec un tel réalisme dans l'expression des visages des condamnés." },
            { "Apparently, ", "À ce qu'il paraît, " },
            { "the sculptors would make the models directly\r\nfrom the corpses, ", "les sculpteurs moulaient directement les visages sur les cadavres, " },
            { "right there at the site of the executions.", "à même le lieu des exécutions." },
            { "At the...?", "À même le... ?" },
            { "(That really turns my stomach...)", "(Ça me soulève le cœur...)" },
            { "That's just one of several legends about the Tusspells\r\nfamily.", "Ce n'est qu'une des nombreuses légendes entourant la famille Pétrie." },
            { " Whether there's any truth in it, ", " Quant à savoir s'il y a une part de vérité là-dedans, " },
            { "I couldn't say.", "je ne saurais me prononcer." },
            { "But anyway...", "Mais quoi qu'il en soit..." },
            { "...this museum houses models of famous people from all\r\nover the globe.", "...ce musée abrite les effigies de célébrités du monde entier." },
            { "Nevertheless, ", "Néanmoins, " },
            { "the most popular area of the museum by\r\nquite some margin ", "la section la plus courue du musée, et de loin, " },
            { "is this House of Horrors.", "est cette Galerie des Horreurs." },
            { "H-", "G-" },
            { "House...", "Galerie..." },
            { "of H-H-Horrors...?", "des H-H-Horreurs... ?" },
            { "Of course, ", "Certes, " },
            { "visitor numbers are dwindling now as a result\r\nof the Great Exhibition.", "l'affluence diminue quelque peu en ce moment en raison de l'Exposition universelle." },
            { "But people usually flock here to see the exhibits of some\r\nof London's most vile criminals at their gruesome work.", "Mais les foules se pressent d'ordinaire pour admirer les plus vils criminels de Londres à l'œuvre." },
            { "Naturally, ", "Naturellement, " },
            { "most of the miscreants portrayed here ", "la plupart des malfaiteurs représentés ici " },
            { "were\r\nsent to the gallows.", "ont fini au bout d'une corde." },
            { "So they're even stiffer now than the models of them!", "Ils sont donc encore plus raides aujourd'hui que leurs répliques de cire !" },
            { "Ah ha ha ha hah!", "Ah ah ah ah ah !" },
            { "...Have you heard of poor taste?", "...Avez-vous déjà entendu parler de mauvais goût ?" },
            { "My dear fellow, ", "Mon cher ami, " },
            { "the public live for poor taste!", "le bon peuple ne vit que pour le mauvais goût !" },
            { "They yearn to be shocked.", "Les gens ne demandent qu'à être horrifiés." },
            { "So...", "Alors..." },
            { "the hideous exhibits in here are...", "les abominations exposées ici sont..." },
            { "They're all portrayals of real events that actually took\r\nplace!", "Ce sont toutes des reconstitutions d'événements qui ont réellement eu lieu !" },
            { "(Is it just me, ", "(Est-ce une impression, " },
            { "or did the temperature in here just seem to\r\ndrop?)", "ou la température vient-elle de chuter d'un coup ?)" },
            { "Anyway, ", "Quoi qu'il en soit, " },
            { "I advise you not to think too deeply about what\r\nyou see here.", "je vous déconseille de méditer trop profondément sur ce que vous voyez ici." },
            { "(...Oh. ", "(...Oh. " },
            { "He's back to being a waxwork, ", "Il s'est retransformé en statue de cire, " },
            { "is he?)", "on dirait ?)" }
        });

        // [14] KEY:BB\script\output\_sce02_chr010_00_eng#14
        add(@"BB\script\output\_sce02_chr010_00_eng#18", new string[,] {
            { "What do you mean by ", "Que voulez-vous dire par " },
            { "a ‘temporary waxwork’,", "« statue de cire temporaire », " },
            { "Mr Sholmes?", "monsieur Holmes ?" },
            { "Exactly what you see.", "Exactement ce que vous voyez." },
            { "I'm part of the exhibits here!", "Je fais partie de l'exposition !" },
            { "Catching these criminals in the act!", "Surprenant ces criminels en flagrant délit !" },
            { "Catching them...?", "Les surprenant... ?" },
            { "Every half an hour, ", "Toutes les demi-heures, " },
            { "I home in on a different killer in one\r\nof the displays and adopt a new pose to ensnare him.", "je cible un assassin différent dans l'une des scènes et j'adopte une nouvelle pose pour le piéger." },
            { "When members of the public come for a closer look,", "Lorsque les visiteurs s'approchent pour mieux observer," },
            { "I offer them my hand to shake.", "je leur tends galamment la main." },
            { "For a shilling, ", "Moyennant un shilling, " },
            { "I'll happily allow them to take a photograph\r\nwith us!", "je les autorise gracieusement à prendre une photographie à nos côtés !" },
            { "(‘Us’?", "(« Nos côtés » ?" },
            { "Does he mean him and the waxwork murderers in\r\nhere?)", "Veut-il dire lui et les statues de cire d'assassins ici présentes ?)" },
            { "why, ", "pourquoi donc, " },
            { "Mr Sholmes?", "monsieur Holmes ?" },
            { "My dear fellow, ", "Mon cher ami, " },
            { "isn't it obvious?", "n'est-ce point évident ?" },
            { "For the money!", "Pour l'argent !" },
            { "(...He really roared at me there.", "(...Il m'a vraiment hurlé dessus, là." },
            { "Very fitting for the House of Horrors.)", "Tout à fait digne de la Galerie des Horreurs.)" },
            { "As it stands, ", "Dans l'état actuel des choses, " },
            { "I may struggle to pay this month's rent.", "je risque de peiner à régler mon loyer ce mois-ci." },
            { "And I have the ravenous Iris to consider.", "Et je dois veiller à ce que l'insatiable Iris ne meure point de faim." },
            { "Oh, Hurley...", "Oh, Sherlockinou..." },
            { "I'm sooo hungry...", "J'ai siii faim..." },
            { "If push comes to shove, ", "Si la situation empire, " },
            { "I shall have to ask you to do your\r\nbit, ", "je devrai vous demander de mettre la main à la pâte, " },
            { "Mr Naruhodo.", "monsieur Naruhodo." },
            { "(What's he threatening to rope me into now?!)", "(Dans quel pétrin compte-t-il encore m'embarquer ?!)" },
            { "with that in mind, ", "gardant cela à l'esprit, " },
            { "how about a photograph?", "que diriez-vous d'une photographie ?" },
            { "As a special treat, ", "En guise de faveur, " },
            { "you may have your pick of the\r\nmurderers and scoundrels in here.", "vous pouvez choisir le criminel ou le scélérat de votre choix." },
            { "The choice is yours!", "L'honneur vous en revient !" },
            { "...Maybe some other time.", "...Une autre fois peut-être." },
            { "Hmph. ", "Humph. " },
            { "Remember, Mr Naruhodo:", "Rappelez-vous, monsieur Naruhodo :" },
            { "ignore me at your\r\nperil!", "m'ignorer se fera à vos risques et périls !" },
            { "(...Back to being a waxwork again.", "(...Le revoilà transformé en statue de cire." },
            { "Is it just me, ", "Est-ce une impression, " },
            { "or did his\r\nfinal remark there sound a lot like a curse?)", "ou sa dernière remarque sonnait-elle comme une malédiction ?)" }
        });

        // [15] KEY:BB\script\output\_sce02_chr010_00_eng#19
        add(@"BB\script\output\_sce02_chr010_00_eng#19", new string[,] {
            { "What is it you'd like to ask me, then?", "Qu'aimeriez-vous me demander, alors ?" },
            { "Um.", "Hum." },
            { "Actually, ", "En fait, " },
            { "it's...", "c'est..." },
            { "It's about Lord van Zieks.", "C'est au sujet de Lord Van Peers." },
            { "Ah, ", "Ah, " },
            { "our friend Mr Reaper.", "notre ami M. le Faucheur." },
            { "How did you find him?", "Comment l'avez-vous trouvé ?" },
            { "Well, ", "En forme, " },
            { "I trust?", "j'espère ?" },
            { "And so I filled Mr Sholmes in about everything I'd learnt.", "Et c'est ainsi que j'expliquai tout ce que j'avais appris à M. Holmes." },
            { "About Lord van Zieks...", "Au sujet de Lord Van Peers..." },
            { "About Professor Harebrayne...", "Au sujet du professeur Lonron..." },
            { "And about the strange coincidence that they had been at\r\nuniversity together.", "Et au sujet de l'étrange coïncidence de leurs années d'études communes à l'université." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part1_A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part1_A written.");
    }
}
