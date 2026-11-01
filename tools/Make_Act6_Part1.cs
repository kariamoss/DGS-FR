using System;
using System.IO;
using System.Text;

class MakeAct6Part1 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart1() {");

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
            { "(That's two hours of gas,that is...)", "(Ça fait deux heures de gaz, ça...)" },
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

        File.WriteAllText(@"tools\Make_Act6_Part1A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Make_Act6_Part1A prepared.");
    }
}
