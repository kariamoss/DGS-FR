using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act2 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart3() {");

        Action<string, Action<StringBuilder>> addKey = (key, fill) =>
        {
            sb.AppendLine("            entryTranslators[@\"" + key + "\"] = (en) => {");
            sb.AppendLine("                string s = en;");
            var body = new StringBuilder();
            fill(body);
            sb.Append(body.ToString());
            sb.AppendLine("                return s;");
            sb.AppendLine("            };");
            sb.AppendLine();
        };

        Action<StringBuilder, string, string> rep = (b, en, fr) =>
        {
            b.AppendLine("                s = s.Replace(\"" + en.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n") + "\", \"" + fr.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n") + "\");");
        };

        // Key 81
        addKey(@"BB\script\output\_sce03_chr060_01_eng#11", b => {
            rep(b, "All of our assailants were armed with pistols,", "Tous nos assaillants étaient armés de pistolets,");
            rep(b, "their faces\r\nobscured by scarves.", "le visage\r\ndissimulé par des écharpes.");
        });

        // Key 82
        addKey(@"BB\script\output\_sce03_chr060_01_eng#12", b => {
            rep(b, "Klint was not only from noble heritage, ", "Non seulement Klimt était de noble lignée, ");
            rep(b, "he was a brilliant\r\nprosecutor as well.", "mais il était également un brillant\r\nprocureur.");
            rep(b, "The scum of London hated the sight of him.", "La racaille de Londres ne pouvait pas le voir en peinture.");
            rep(b, "And they had\r\nno sympathy for his younger brother, either.", "Et ils n'avaient aucune sympathie\r\npour son jeune frère non plus.");
            rep(b, "I'd been targeted several times before already.", "J'avais déjà été pris pour cible à plusieurs reprises par le passé.");
            rep(b, "...Yeah, ", "... Ouais, ");
            rep(b, "it's van Zieks alright.", "c'est bien Van Peers.");
            rep(b, "We've got 'im!", "On l'tient !");
            rep(b, "I could hear them murmuring amongst themselves.", "Je pouvais les entendre murmurer entre eux.");
            rep(b, "I knew they were after me.", "Je savais qu'ils en avaient après moi.");
            rep(b, "But just when I thought my time had come...", "Mais au moment précis où je crus que mon heure était venue...");
            rep(b, "...If I let them kill you,", "... Si je les laisse te tuer,");
            rep(b, "Klint would never forgive me.", "Klimt ne me le pardonnerait jamais.");
            rep(b, "It was Asogi's voice.", "C'était la voix d'Asogi.");
            rep(b, "Just a whisper in my ear.", "Un simple murmure à mon oreille.");
            rep(b, "*Bang!*", "*Pan !*");
        });

        // Key 83
        addKey(@"BB\script\output\_sce03_chr060_01_eng#13", b => {
            rep(b, "*Bang!*", "*Pan !*");
        });

        // Key 84
        addKey(@"BB\script\output\_sce03_chr060_01_eng#14", b => {
            rep(b, "After that, ", "Après cela, ");
            rep(b, "I don't remember exactly what happened.", "je ne me rappelle pas exactement ce qui s'est passé.");
            rep(b, "The next thing I knew, ", "Lorsque j'ai repris mes esprits, ");
            rep(b, "there was silence all around.", "un silence de mort régnait partout.");
            rep(b, "Genshin lay on the cobbled street.", "Genshin gisait sur la chaussée pavée.");
            rep(b, "Blood was seeping from his left hand.", "Le sang coulait de sa main gauche.");
            rep(b, "He'd shielded me.", "Il m'avait servi de bouclier.");
        });

        // Key 85
        addKey(@"BB\script\output\_sce03_chr060_01_eng#15", b => {
            rep(b, "The next thing I knew, ", "Lorsque j'ai repris mes esprits, ");
            rep(b, "there was silence all around.", "un silence de mort régnait partout.");
            rep(b, "Genshin lay on the cobbled street.", "Genshin gisait sur la chaussée pavée.");
            rep(b, "Blood was seeping from his left hand.", "Le sang coulait de sa main gauche.");
            rep(b, "He'd shielded me.", "Il m'avait servi de bouclier.");
        });

        // Key 86
        addKey(@"BB\script\output\_sce03_chr060_01_eng#16", b => {
            rep(b, "Two days later...", "Deux jours plus tard...");
            rep(b, "they arrested him.", "ils l'ont arrêté.");
            rep(b, "On suspicion of being London's most notorious mass\r\nmurderer ever:", "Soupçonné d'être le tueur en série le plus notoire\r\nque Londres ait jamais connu :");
            rep(b, "the Professor.", "le Démon Assassin.");
            rep(b, "How ", "Comme c'est ");
            rep(b, "awful for you...", "affreux pour vous...");
            rep(b, "All at once, ", "D'un seul coup, ");
            rep(b, "I lost the brother I revered ", "j'ai perdu le frère que je vénérais ");
            rep(b, "and the foreign\r\nfriend I held in such high regard.", "et l'ami venu d'ailleurs\r\nque je tenais en si haute estime.");
            rep(b, "I'm so sorry, ", "Je suis tellement navré, ");
            rep(b, "Lord van Zieks...", "Lord Van Peers...");
        });

        // Key 87
        addKey(@"BB\script\output\_sce03_chr101_00_eng#1", b => {
            rep(b, "So, ", "Alors, ");
            rep(b, "how was the voyage here?", "comment s'est passé votre voyage jusqu'ici ?");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "fifty days at sea is a long time by anyone's\r\nstandards.", "cinquante jours en mer, c'est long, peu importe vos\r\nstandards habituels.");
            rep(b, "But it wasn't as bad as when we first came sixteen years\r\nago.", "Mais ce ne fut pas aussi pénible que lors de notre première venue,\r\nil y a seize ans.");
            rep(b, "No, ", "Non, ");
            rep(b, "that's true.", "c'est vrai.");
            rep(b, "Then I truly wondered if we wouldn't be\r\ndrifting in the vast ocean for the rest of our lives.", "À l'époque, je me demandais vraiment si nous n'allions pas\r\ndériver sur l'océan infini jusqu'à la fin de nos jours.");
            rep(b, "This time ", "Cette fois, ");
            rep(b, "we followed the same route as you, ", "nous avons suivi le même itinéraire que vous, ");
            rep(b, "so we were\r\nable to relax and enjoy the experience.", "ce qui nous a\r\npermis de nous détendre et de profiter du voyage.");
            rep(b, "...Ah, ", "... Ah, ");
            rep(b, "so you stopped in France's beautiful capital, ", "vous avez donc fait escale dans la magnifique capitale française, ");
            rep(b, "Paris?", "Paris ?");
            rep(b, "We did, ", "Tout à fait, ");
            rep(b, "yes.", "oui.");
            rep(b, "Though only for one night.", "Même si ce ne fut que pour une seule nuit.");
            rep(b, "And yesterday evening ", "Et hier soir, ");
            rep(b, "we left the Port of Dunkirk for\r\nDover.", "nous avons quitté le port de Dunkerque pour\r\nDouvres.");
            rep(b, "Just in time for the symposium, ", "Juste à temps pour le colloque, ");
            rep(b, "in fact.", "en vérité.");
            rep(b, "It starts tomorrow!", "Il commence demain !");
            rep(b, "It's wonderful that you were invited to attend such an\r\nimportant international event.", "C'est merveilleux que vous ayez été invités à assister à un\r\névénement international d'une telle importance.");
            rep(b, "I'm very proud of you, ", "Je suis très fière de vous, ");
            rep(b, "Father.", "Père.");
            rep(b, "It's thanks to Seishiro here.", "C'est grâce à Seishiro que voici.");
            rep(b, "Sixteen years ago ", "Il y a seize ans de cela, ");
            rep(b, "he managed\r\nto ingratiate himself with Britain's Attorney General.", "il a su\r\nse faire apprécier du procureur général de Grande-Bretagne.");
            rep(b, "I'm sure that's why he was invited.", "Je suis convaincu que c'est pour cela qu'il a été convié.");
            rep(b, "And I suppose you\r\ncould say I'm something of an appendage by default.", "Et j'imagine qu'on\r\npourrait dire que je ne suis qu'une sorte de pièce rapportée.");
            rep(b, "Speak for yourself, ", "Parle pour toi, ");
            rep(b, "Yujin.", "Yujin.");
            rep(b, "You were close friends with the\r\nprofessor of forensic science at a major hospital.", "Tu étais un ami intime du professeur\r\nde médecine légale d'un grand hôpital.");
            rep(b, "Yes, ", "Oui, ");
            rep(b, "well", "enfin");
            rep(b, "I'd rather not dredge all that up, ", "je préférerais ne pas remuer tout cela, ");
            rep(b, "really.", "à vrai dire.");
            rep(b, "No", "Non");
            rep(b, "There's been a lot of water under the bridge since\r\nthen, ", "Bien de l'eau a coulé sous les ponts depuis,\r\n");
            rep(b, "but it doesn't bring him back.", "mais cela ne le ramènera pas pour autant.");
            rep(b, "(Kazuma's father, ", "(Le père de Kazuma, ");
            rep(b, "I suppose...)", "j'imagine...)");
        });

        // Key 88
        addKey(@"BB\script\output\_sce03_chr101_00_eng#2", b => {
            rep(b, "The Professor...", "Le Démon Assassin...");
            rep(b, " The killer who took the lives of five\r\nmembers of the British aristocracy...", " Le meurtrier qui a ôté la vie à cinq\r\nmembres de l'aristocratie britannique...");
            rep(b, "...was actually Kazuma's father, ", "... était en réalité le père de Kazuma, ");
            rep(b, "wasn't he?", "n'est-ce pas ?");
            rep(b, "That's correct.", "C'est exact.");
            rep(b, "Genshin ", "Genshin ");
            rep(b, "Asogi", "Asogi");
            rep(b, "Genshin...", "Genshin...");
            rep(b, "You knew, ", "Vous le saviez, ");
            rep(b, "I presume, ", "je présume, ");
            rep(b, "Father?", "Père ?");
            rep(b, "Yes.", "Oui.");
            rep(b, " He was a close friend at the time.", " C'était un ami très proche à l'époque.");
            rep(b, "Genshin came to Britain as a police detective.", "Genshin est venu en Grande-Bretagne en tant qu'inspecteur.");
            rep(b, "He was\r\nstudying investigative techniques at Scotland Yard.", "Il étudiait\r\nles techniques d'enquête criminelle à Scotland Yard.");
            rep(b, "I've never understood what drove the man to commit\r\nsuch heinous acts.", "Je n'ai jamais compris ce qui a pu pousser cet homme à commettre\r\ndes actes aussi ignobles.");
            rep(b, "It was a closed trial, ", "Le procès s'est tenu à huis clos, ");
            rep(b, "so the public never knew the truth.", "donc le public n'a jamais su la vérité.");
            rep(b, "And he was executed with little ado.", "Et il fut exécuté en toute discrétion.");
            rep(b, "To this day, ", "À ce jour, ");
            rep(b, "very few people know what really happened,", "très peu de gens savent ce qui s'est réellement passé,");
            rep(b, "even in our homeland.", "même dans notre pays natal.");
            rep(b, "But what about Kazuma?", "Mais qu'en était-il pour Kazuma ?");
            rep(b, "Did he know?", "Le savait-il ?");
            rep(b, "Did he know ", "Connaissait-il ");
            rep(b, "the truth", "la vérité");
            rep(b, " about his father?", " au sujet de son père ?");
            rep(b, "No no, ", "Non non, ");
            rep(b, "of course not.", "bien sûr que non.");
            rep(b, "He was told his father passed from sickness.", "On lui a dit que son père s'était éteint des suites d'une maladie.");
            rep(b, "However...", "Cependant...");
            rep(b, "...I suspect he may have had his ", "... je soupçonne qu'il a pu nourrir des ");
            rep(b, "doubts", "doutes");
            rep(b, "Oh!", "Oh !");
            rep(b, " Why?", " Pourquoi ?");
            rep(b, "As you know, ", "Comme vous le savez, ");
            rep(b, "I tried to guide Kazuma growing up, ", "j'ai essayé de guider Kazuma en grandissant, ");
            rep(b, "as if\r\nhe were my own son.", "comme si\r\nc'était mon propre fils.");
            rep(b, "Then one day, ", "Puis un jour, ");
            rep(b, "he came to my office at the university and\r\nsaid:", "il est venu dans mon bureau à l'université et\r\nm'a dit :");
            rep(b, "I've decided...", "J'ai pris ma décision...");
            rep(b, "I want to travel to Great Britain and study\r\nthere!", "je veux partir étudier en Grande-Bretagne !");
            rep(b, "Do, ", "Pensez... ");
            rep(b, "do you think...", "pensez-vous...");
            rep(b, "...he wanted to come here ", "... qu'il souhaitait venir ici ");
            rep(b, "to investigate his father's\r\ndeath?!", "pour enquêter sur la mort\r\nde son père ?!");
            rep(b, "I don't know.", "Je l'ignore.");
            rep(b, "But when I looked into his eyes, ", "Mais en plongeant mon regard dans le sien, ");
            rep(b, "I did know that there\r\nwas no way I'd be able to stop him.", "j'ai compris qu'il n'y avait\r\naucun moyen de l'en dissuader.");
        });

        // Key 89
        addKey(@"BB\script\output\_sce03_chr101_00_eng#3", b => {
            rep(b, "Something else came to light in that trial the other day,", "Autre chose a également été révélé lors de ce procès l'autre jour,");
            rep(b, "actually.", "à vrai dire.");
            rep(b, "Oh?", "Ah bon ?");
            rep(b, " What?", " Quoi donc ?");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "having disappeared in Hong Kong and been missing\r\nfor almost a year...", "après avoir disparu à Hong Kong et s'être volatilisé\r\npendant près d'un an...");
            rep(b, "...Kazuma's since turned up here in London, ", "... Kazuma a fini par réapparaître ici même à Londres, ");
            rep(b, "working as\r\nthe apprentice of Lord van Zieks.", "où il officie\r\nen tant que disciple de Lord Van Peers.");
            rep(b, "What?", "Quoi ?");
            rep(b, "WHAT?!", "QUOI ?!");
            rep(b, "That's news to us!", "C'est une nouvelle tout à fait stupéfiante !");
            rep(b, "(So...)", "(Ainsi...)");
            rep(b, "(...Lord Stronghart's telegram neglected to mention that\r\npart, then.)", "(... le télégramme de Lord Caine avait donc omis de mentionner\r\nce détail.)");
        });

        // Key 90
        addKey(@"BB\script\output\_sce03_chr101_00_eng#4", b => {
            rep(b, "As you know, ", "Comme vous le savez, ");
            rep(b, "we both thought Kazuma had died on the\r\nsteamship during our voyage to Great Britain in January.", "nous pensions tous deux que Kazuma avait péri à bord du\r\npaquebot lors de notre voyage vers la Grande-Bretagne en janvier.");
            rep(b, "But he didn't die.", "Mais il n'est pas mort.");
            rep(b, "He's alive.", "Il est bien vivant.");
            rep(b, "...As you knew, ", "... Comme vous le saviez déjà, ");
            rep(b, "didn't you, ", "n'est-ce pas, ");
            rep(b, "Father?", "Père ?");
            rep(b, "In actual fact, ", "En réalité, ");
            rep(b, "no.", "non.");
            rep(b, "What I did know...", "Ce que je savais, en revanche...");
            rep(b, "...is that when your ship docked in Hong Kong,", "... c'est que lorsque votre navire a accosté à Hong Kong,");
            rep(b, "he\r\nmysteriously ", "il a\r\nmystérieusement ");
            rep(b, "vanished", "disparu");
            rep(b, "We sent a team of investigators to Hong Kong to try to\r\nascertain what had happened, ", "Nous avons envoyé une équipe d'enquêteurs à Hong Kong afin d'élucider\r\nce qui s'était produit, ");
            rep(b, "but to no avail.", "mais sans le moindre résultat.");
            rep(b, "But he's still alive?", "Mais il est bel et bien en vie ?");
            rep(b, "And here, in London, ", "Et ici même, à Londres, ");
            rep(b, "you say?", "dites-vous ?");
            rep(b, "...I never dared even to dream it.", "... Je n'avais même jamais osé en rêver.");
            rep(b, "Why on earth did the young man not make contact?!", "Mais pourquoi diable ce jeune homme n'a-t-il pas pris contact ?!");
            rep(b, "The government and the police have been chasing clues\r\nfruitlessly for months now!", "Le gouvernement et la police recherchent désespérément des indices\r\nen vain depuis des mois !");
            rep(b, "Well...", "Eh bien...");
            rep(b, "it seems that he was suffering from amnesia.", "il semble qu'il souffrait d'amnésie.");
            rep(b, "What?", "Comment ?");
            rep(b, "Amnesia?!", "Amnésie ?!");
            rep(b, "When we first came across him again here in London...", "Lorsque nous sommes tombés sur lui à Londres...");
            rep(b, "...he didn't know who either of us were.", "... il ne savait absolument pas qui nous étions.");
            rep(b, "Hm, ", "Hum, ");
            rep(b, "I see...", "je vois...");
            rep(b, "He only regained his memory eight days ago.", "Il n'a retrouvé la mémoire qu'il y a huit jours de cela.");
            rep(b, "This is unbelievable...", "C'est tout simplement incroyable...");
            rep(b, "Yes", "Oui");
            rep(b, "It's quite miraculous...", "C'est un véritable miracle...");
            rep(b, "I wonder why Lord Stronghart didn't let us know.", "Je me demande pourquoi Lord Caine ne nous a pas prévenus.");
            rep(b, "I must speak with him urgently.", "Il faut absolument que je m'entretienne avec lui d'urgence.");
            rep(b, "(I wonder how Kazuma's been these past few days...)", "(Je me demande comment Kazuma va depuis quelques jours...)");
            rep(b, "(Would it be wrong of us to go and visit him?)", "(Serait-ce déplacé de notre part d'aller lui rendre visite ?)");
        });

        // Key 91
        addKey(@"BB\script\output\_sce03_chr101_00_eng#5", b => {
            rep(b, "That began sixteen years ago now.", "Tout a commencé il y a seize ans de cela.");
            rep(b, "It's a distant memory, ", "C'est un souvenir lointain, ");
            rep(b, "really.", "en vérité.");
            rep(b, "It was Yujin here, ", "Il y avait Yujin, ");
            rep(b, "Genshin Asogi ", "Genshin Asogi ");
            rep(b, "and myself.", "et moi-même.");
            rep(b, "We were the original three.", "Nous étions les trois pionniers.");
            rep(b, "The first judicial scholars from Japan to travel overseas to\r\nstudy.", "Les tout premiers étudiants en droit du Japon à voyager outre-mer\r\npour étudier.");
            rep(b, "Ocean voyages were not what they are today,", "Les traversées maritimes n'avaient rien à voir avec ce qu'elles sont aujourd'hui,");
            rep(b, "I can tell\r\nyou.", "je peux vous l'assurer.");
            rep(b, "(Sixteen years ago...", "(Il y a seize ans...");
            rep(b, "Things were tough for their\r\ngeneration.)", "La vie était rude pour leur\r\ngénération.)");
            rep(b, "Your father was an exceptionally fine medical student at\r\nYumei University at the time, you know, ", "Votre père était un étudiant en médecine particulièrement brillant\r\nà l'Université Yumei à cette époque, vous savez, ");
            rep(b, "young lady.", "jeune fille.");
            rep(b, "Grandmother told me.", "Grand-mère me l'a raconté.");
            rep(b, "He went to do research ", "Il est parti mener des recherches ");
            rep(b, "at a great London hospital to\r\nstudy autopsy –", "dans un grand hôpital londonien pour\r\ny étudier l'autopsie –");
            rep(b, " practically unheard of in Japan.", " une discipline quasiment inconnue au Japon.");
            rep(b, "Yes, ", "Oui, ");
            rep(b, "it was an eerie place, ", "c'était un endroit sinistre, ");
            rep(b, "sandwiched between the back\r\nof a prison and a burial ground.", "coincé entre l'arrière\r\nd'une prison et un cimetière.");
            rep(b, "Ugh, ", "Beurk, ");
            rep(b, "not more talk of graves...", "encore des histoires de tombes...");
            rep(b, "Very often, ", "Bien souvent, ");
            rep(b, "there's no one willing to deal with bodies\r\nfollowing autopsy work.", "il n'y a personne pour prendre en charge les corps\r\naprès les examens d'autopsie.");
            rep(b, "So you see, ", "Vous comprenez donc que ");
            rep(b, "autopsy labs have something of an\r\nunavoidable relationship with graveyards and prisons.", "les salles d'autopsie ont un lien plutôt\r\ninévitable avec les cimetières et les prisons.");
            rep(b, "Not my cup of tea at all...", "Ce n'est vraiment pas ma tasse de thé...");
            rep(b, "Do you remember that Scottish prison governor?", "Te souviens-tu de ce directeur de prison écossais ?");
            rep(b, "Caidin, ", "Caidin, ");
            rep(b, "his name was.", "il s'appelait.");
            rep(b, " He was a good man.", " C'était un homme de bien.");
            rep(b, "Yes.", "Oui.");
            rep(b, " But then of course, ", " Mais par la suite, évidemment, ");
            rep(b, "in our sixth year here,", "durant notre sixième année ici,");
            rep(b, "everything changed with that dreadful case.", "tout a basculé avec cette épouvantable affaire.");
            rep(b, "When Genshin was arrested...", "Quand Genshin a été arrêté...");
            rep(b, "for a series of the most\r\ngruesome murders.", "pour une série de meurtres parmi les plus\r\natroces.");
            rep(b, "I simply couldn't believe it.", "Je n'arrivais tout bonnement pas à y croire.");
            rep(b, "I'd known the man for years.", "Je connaissais cet homme depuis des années.");
            rep(b, "I was a witness at the secret hearing and I tried to speak\r\nin his defence, ", "J'étais témoin lors de ce procès secret et j'ai tenté d'intercéder\r\nen sa faveur, ");
            rep(b, "but", "mais");
            rep(b, "But you went a little too far ", "Mais tu es allé un peu trop loin ");
            rep(b, "and ended up facing charges\r\nyourself, ", "et tu t'es retrouvé toi-même accusé, ");
            rep(b, "didn't you?", "n'est-ce pas ?");
            rep(b, "suffice to say that after that trial ", "disons simplement qu'après ce procès, ");
            rep(b, "we were sent back\r\nto Japan.", "nous avons été renvoyés\r\nau Japon.");
            rep(b, "There was nothing more we could do to save Genshin.", "Nous ne pouvions plus rien faire pour sauver Genshin.");
            rep(b, "He was a lost cause, ", "Son sort était scellé, ");
            rep(b, "sadly.", "hélas.");
        });

        // Key 92
        addKey(@"BB\script\output\_sce03_chr101_00_eng#8", b => {
            rep(b, "Professor Mikotoba, ", "Professeur Mikotoba, ");
            rep(b, "I wonder...", "je me demandais...");
            rep(b, "could, ", "pourrais, ");
            rep(b, "could I show you\r\nsomething?", "pourrais-je vous montrer\r\nquelque chose ?");
            rep(b, "Why do you seem so nervous?", "Pourquoi semblez-vous si anxieux ?");
            rep(b, "I, ", "Je, ");
            rep(b, "I suppose because I'm a student showing something to a\r\nprofessor.", "j'imagine que c'est parce que je suis un étudiant montrant quelque chose à un\r\nprofesseur.");
            rep(b, "That's always quite nerve-racking.", "C'est toujours un peu intimidant.");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "I'm sorry I perturb you in that way, ", "je suis navré de vous intimider ainsi, ");
            rep(b, "but anyway...", "mais quoi qu'il en soit...");
            rep(b, "I'm afraid I have nothing useful to say about that, ", "j'ai bien peur de n'avoir rien de constructif à vous dire là-dessus, ");
            rep(b, "really.", "en vérité.");
        });

        // Key 93
        addKey(@"BB\script\output\_sce03_chr101_00_eng#9", b => {
            rep(b, "Look at this, ", "Regardez cela, ");
            rep(b, "Professor Mikotoba.", "professeur Mikotoba.");
            rep(b, "Ah...", "Ah...");
            rep(b, "Kazuma's armband.", "Le brassard de Kazuma.");
            rep(b, "He was wearing that when he\r\nleft for Great Britain.", "Il le portait lorsqu'il a\r\npris la mer pour la Grande-Bretagne.");
            rep(b, "How curious.", "Comme c'est curieux.");
            rep(b, "It doesn't strike me at all as odd to see you\r\nwearing it.", "Cela ne me semble pas étrange du tout de vous voir\r\nle porter.");
            rep(b, "It rather suits you.", "Il vous sied plutôt bien.");
            rep(b, "Oh...", "Oh...");
            rep(b, "Are you intending to return it to him?", "Avez-vous l'intention de le lui rendre ?");
            rep(b, "yes...", "oui...");
            rep(b, "I mean, ", "C'est-à-dire que, ");
            rep(b, "it has his name on it.", "son nom est inscrit dessus.");
            rep(b, "Now that we've found out he's alive, ", "Maintenant que nous avons découvert qu'il est vivant, ");
            rep(b, "it doesn't make sense\r\nfor me to keep it.", "cela n'a plus grand sens\r\nque je le conserve.");
            rep(b, "if you ask me...", "si vous voulez mon avis...");
            rep(b, "...I think Kazuma would be delighted to see you wearing\r\nit.", "... je pense que Kazuma serait enchanté de vous voir le porter.");
            rep(b, "I'd feel honoured if that were true.", "je me sentirais honoré si c'était vrai.");
        });

        // Key 94
        addKey(@"BB\script\output\_sce03_chr101_00_eng#10", b => {
            rep(b, "Professor, ", "Professeur, ");
            rep(b, "thank you very much for this letter of\r\nintroduction.", "merci infiniment pour cette lettre de\r\nrecommandation.");
            rep(b, "You're welcome.", "Je vous en prie.");
            rep(b, "Only too pleased to help if I can.", "Ravi de pouvoir vous apporter mon aide.");
            rep(b, "The words Easterner and Westerner mean nothing,\r\nreally.", "Les mots Oriental et Occidental n'ont aucun sens réel,\r\nen vérité.");
            rep(b, "If you spend time to get to know people...", "Si l'on prend le temps d'apprendre à connaître autrui...");
            rep(b, "...it soon becomes apparent ", "... il devient vite évident ");
            rep(b, "that we're all just humans at\r\nthe end of the day.", "qu'au fond nous sommes tous simplement des êtres humains.");
            rep(b, "Far more alike than most will admit.", "Bien plus semblables que la plupart ne veulent l'admettre.");
            rep(b, "It would be wonderful if everybody saw it that way.", "Ce serait magnifique si tout le monde pouvait voir les choses ainsi.");
            rep(b, "Sadly, ", "Hélas, ");
            rep(b, "not everybody can.", "ce n'est pas donné à tout le monde.");
            rep(b, "We all have our failings,\r\nthough.", "Nous avons tous nos faiblesses,\r\naprès tout.");
            rep(b, "As I said, ", "Comme je l'ai dit, ");
            rep(b, "we're all human.", "nous sommes tous humains.");
            rep(b, "(I see now why he's such a respected scholar.", "(Je comprends à présent pourquoi c'est un érudit si respecté.");
            rep(b, "It's his magnanimous spirit.)", "C'est toute sa grandeur d'âme.)");
        });

        // Key 95
        addKey(@"BB\script\output\_sce03_chr101_01_eng#1", b => {
            rep(b, "Father, ", "Père, ");
            rep(b, "do you know about the so-called Reaper of the\r\nBailey?", "avez-vous entendu parler du prétendu Faucheur\r\nde l'Old Bailey ?");
            rep(b, "I've heard rumours.", "J'en ai entendu parler par la rumeur.");
            rep(b, "Some members of the judiciary\r\nexplained it all to me yesterday.", "Des membres de l'appareil judiciaire\r\nm'ont tout expliqué hier.");
            rep(b, "Of course, ", "Naturellement, ");
            rep(b, "when I was a visiting student here in London,", "lorsque j'étais étudiant invité ici à Londres,");
            rep(b, "the Reaper was yet to emerge.", "le Faucheur n'avait pas encore fait son apparition.");
            rep(b, "(Right, ", "(C'est vrai, ");
            rep(b, "he didn't appear until ", "il n'est apparu qu'");
            rep(b, "after", "après");
            rep(b, " that case when the\r\nvisiting students had already returned home.)", " cette affaire, quand les\r\nétudiants invités étaient déjà rentrés chez eux.)");
            rep(b, "Lord van Zieks ", "Lord Van Peers ");
            rep(b, "who was in the dock today...", "qui se trouvait au banc des accusés aujourd'hui...");
            rep(b, "That was Barok, ", "C'était bien Drake, ");
            rep(b, "the younger brother", "le jeune frère");
            rep(b, " of Klint van Zieks,", " de Klimt Van Peers,");
            rep(b, "I believe.", "si je ne m'abuse.");
            rep(b, "That's right.", "C'est exact.");
            rep(b, "And he's known throughout London as the\r\nReaper, ", "Et il est connu dans tout Londres sous le nom du\r\nFaucheur, ");
            rep(b, "as you've heard.", "comme on vous l'a dit.");
            rep(b, "But the truth is...", "Mais la vérité est...");
            rep(b, "...it wasn't him behind all of those mysterious deaths.", "... que ce n'était pas lui derrière toutes ces morts mystérieuses.");
            rep(b, "It was ", "C'était ");
            rep(b, "somebody else", "quelqu'un d'autre");
            rep(b, "!", " !");
            rep(b, "I see...", "Je vois...");
            rep(b, "So what you're saying is, ", "Ce que vous voulez dire, c'est qu'");
            rep(b, "there's been ", "il y aurait eu ");
            rep(b, "a professional killer", "un tueur professionnel");
            rep(b, "at work here?", "à l'œuvre ici ?");
            rep(b, "Exactly.", "Exactement.");
            rep(b, "Someone by the name of ", "Une personne répondant au nom d'");
            rep(b, "Asa Shinn, ", "Asa Shinn, ");
            rep(b, "in fact.", "en réalité.");
            rep(b, "...I beg your pardon?", "... Comment dites-vous ?");
            rep(b, "Did, ", "Avez, ");
            rep(b, "did you say...", "avez-vous dit...");
            rep(b, "Asa Shinn?!", "Asa Shinn ?!");
            rep(b, "You mean that Jezaille Brett woman ", "Vous voulez parler de cette femme, Jezail Brett, ");
            rep(b, "who was responsible\r\nfor killing my great friend?!", "qui a lâchement assassiné\r\nmon grand ami ?!");
            rep(b, "Oh no!", "Oh non !");
            rep(b, "A friend of yours was killed?", "Un de vos amis a été tué ?");
            rep(b, "Ah!", "Ah !");
            rep(b, "Um...", "Euh...");
            rep(b, "Professor Mikotoba, ", "professeur Mikotoba, ");
            rep(b, "I think perhaps we shouldn't\r\ndiscuss this right now...", "je pense que nous ne devrions peut-être pas\r\naborder ce sujet maintenant...");
            rep(b, "(Because the friend the professor is talking about", "(Car l'ami dont parle le professeur");
            rep(b, "is\r\nDr John H. Wilson.)", "n'est autre que\r\nle Dr John H. Wilson.)");
            rep(b, "(And that's not something we want Iris to find out about.", "(Et ce n'est pas quelque chose que nous souhaitons qu'Iris apprenne.");
            rep(b, "Not like this, ", "Pas de cette manière, ");
            rep(b, "anyway...)", "en tout cas...)");
        });

        // Key 96
        addKey(@"BB\script\output\_sce03_chr101_01_eng#2", b => {
            rep(b, "...Ah!", "... Ah !");
            rep(b, "I've, ", "Je, ");
            rep(b, "I've just remembered something...", "je viens de me souvenir de quelque chose...");
            rep(b, "Biscuits!", "Des biscuits !");
            rep(b, "This hotel...", "Cet hôtel...");
            rep(b, "has the most delicious-looking\r\nbiscuits!", "propose des biscuits\r\nqui ont l'air délicieux !");
            rep(b, "That was rather out of the blue.", "Voilà qui arrive bien comme un cheveu sur la soupe.");
            rep(b, "(She's doing this ", "(Elle fait cela ");
            rep(b, "deliberately", "délibérément");
            rep(b, ".)", ".)");
            rep(b, "I think I'll go ", "Je pense que je vais aller voir ");
            rep(b, "and see if I can purchase some.", "si je peux en acheter.");
            rep(b, "would you like to come too, ", "aimerais-tu m'accompagner, ");
            rep(b, "Iris?", "Iris ?");
            rep(b, "Oh yes!", "Oh oui !");
            rep(b, "You just try to leave me behind!", "Tu n'as pas intérêt à partir sans moi !");
            rep(b, "So that young girl...", "Ainsi, cette jeune demoiselle...");
            rep(b, "...is called Iris Wilson, ", "... s'appelle Iris Wilson, ");
            rep(b, "is she?", "c'est bien cela ?");
            rep(b, "Yes, ", "Oui, ");
            rep(b, "that's right.", "c'est exact.");
            rep(b, "And she's the author of all those adventure stories\r\nstarring the great detective Sholmes?", "Et c'est l'auteure de tous ces récits d'aventures\r\nmettant en scène le grand détective Holmes ?");
            rep(b, "But the name of the credited ", "Mais le nom crédité comme ");
            rep(b, "author", "auteur");
            rep(b, " isn't Iris, ", " n'est pas Iris, ");
            rep(b, "is it?", "n'est-ce pas ?");
            rep(b, "It's Dr John H. Wilson.", "C'est le Dr John H. Wilson.");
            rep(b, "Yes, ", "Oui, ");
            rep(b, "I know.", "je sais.");
            rep(b, "That's the name of her ", "C'est le nom de son ");
            rep(b, "father", "père");
            rep(b, ", you see.", ", voyez-vous.");
            rep(b, "Her father?", "Son père ?");
            rep(b, "Dr John H. Wilson...", "Le Dr John H. Wilson...");
            rep(b, "I was deeply indebted to the man for all the kindness he\r\nshowed me during my time in London.", "J'avais une dette immense envers cet homme pour toute la bonté dont il\r\na fait preuve à mon égard lors de mon séjour londonien.");
            rep(b, "That's why I was keen to reciprocate and invite him to\r\nthe Imperial Yumei University four years ago.", "C'est pour cela que je tenais à lui rendre la pareille en l'invitant\r\nà l'Université Impériale Yumei il y a quatre ans.");
            rep(b, "But he was murdered last year...", "Mais il a été assassiné l'an dernier...");
            rep(b, "by Jezaille Brett.", "par Jezail Brett.");
            rep(b, "(Why?", "(Pourquoi ?");
            rep(b, "Why would the hand of the Reaper stretch all the\r\nway to Japan?)", "Pourquoi la griffe du Faucheur s'étendrait-elle\r\njusqu'au Japon ?)");
            rep(b, "Iris knows nothing about that case.", "Iris ne sait absolument rien de cette affaire.");
            rep(b, "But it seems very likely that the victim, ", "Mais il semble fort probable que la victime, ");
            rep(b, "Dr Wilson,", "le Dr Wilson,");
            rep(b, "was\r\nher father.", "était\r\nson père.");
            rep(b, "I can't say that we ever spoke about his family.", "je ne peux pas affirmer que nous ayons jamais parlé de sa famille.");
            rep(b, "So I don't know if he had a daughter or not.", "J'ignore donc totalement s'il avait une fille ou non.");
            rep(b, "But I think I can say with some certainty...", "Mais je crois pouvoir affirmer avec une quasi-certitude...");
            rep(b, "that he was\r\nnever the great detective's partner.", "qu'il n'a\r\njamais été l'associé du grand détective.");
            rep(b, "So...", "Alors...");
            rep(b, "it could have been another Dr Wilson, ", "ce pourrait être un autre Dr Wilson, ");
            rep(b, "you think?", "d'après vous ?");
            rep(b, "John and Wilson are both common names, after all.", "John et Wilson sont tous deux des noms très répandus, après tout.");
            rep(b, "Still, ", "Néanmoins, ");
            rep(b, "it's probably best not to mention this to the young\r\nlady until we can be sure.", "il vaut sans doute mieux ne pas en parler à la demoiselle\r\ntant que nous n'en avons pas le cœur net.");
            rep(b, "...That's what we thought, ", "... C'est bien ce que nous pensions, ");
            rep(b, "yes.", "oui.");
            rep(b, "We're back!", "Nous sommes de retour !");
            rep(b, "With cinnamon biscuits!", "Avec des biscuits à la cannelle !");
            rep(b, "Ooh!", "Ooh !");
            rep(b, "They smell delicious, Iris!", "Ils sentent divinement bon, Iris !");
            rep(b, "I think cinnamon will go very well with the tea they\r\nserve here.", "Je pense que la cannelle accompagnera parfaitement le thé\r\nqu'ils servent ici.");
            rep(b, "Don't you, Susie?", "Tu ne trouves pas, Susette ?");
            rep(b, "I'm sure you're right, Iris!", "J'en suis certaine, Iris !");
        });

        // Key 97
        addKey(@"BB\script\output\_sce03_chr101_01_eng#3", b => {
            rep(b, "I haven't seen Judge Jigoku for a while, ", "Je n'ai pas vu le juge Jigoku depuis un moment, ");
            rep(b, "have you?", "et vous ?");
            rep(b, "Guilty!", "Coupable !");
            rep(b, "Hah ", "Hah ");
            rep(b, "hah ", "hah ");
            rep(b, "hah!", "hah !");
            rep(b, "(But that ‘guilty’ is still ringing in my ears...)", "(Mais ce « coupable » résonne encore dans mes oreilles...)");
            rep(b, "No, ", "Non, ");
            rep(b, "now you mention it, ", "maintenant que vous le dites, ");
            rep(b, "I haven't seen him since this\r\nmorning, either.", "je ne l'ai pas revu depuis ce\r\nmatin non plus.");
            rep(b, "I suppose since the symposium's opening was postponed", "J'imagine que l'ouverture du colloque ayant été ajournée,");
            rep(b, "he'll have gone to explore at the Great Exhibition.", "il est parti visiter l'Exposition universelle.");
            rep(b, "That reminds me of something you mentioned yesterday.", "Cela me rappelle une chose que vous avez évoquée hier.");
            rep(b, "About Judge Jigoku having once ", "À propos du juge Jigoku qui se serait lui-même ");
            rep(b, "been in the dock himself?", "retrouvé sur le banc des accusés jadis ?");
            rep(b, "Ah yes...", "Ah oui...");
            rep(b, "It was all tied up with that accursed trial.", "C'était étroitement lié à ce maudit procès.");
            rep(b, "(The closed trial...", "(Le procès à huis clos...");
            rep(b, "of Kazuma's father...)", "du père de Kazuma...)");
            rep(b, "Seishiro was trying to mitigate Genshin's guilt, ", "Seishiro tentait d'atténuer la culpabilité de Genshin, ");
            rep(b, "so he took\r\nto the stand to testify.", "il s'est donc\r\nprésenté à la barre pour témoigner.");
            rep(b, "But he...", "Mais il...");
            rep(b, "got a little carried away and, ", "s'est un peu emporté et, ");
            rep(b, "um...", "euh...");
            rep(b, "actually\r\nmanaged to break the witness stand.", "a purement et\r\nsimplement fracassé la barre des témoins.");
        });

        // Key 98
        addKey(@"BB\script\output\_sce03_chr101_01_eng#4", b => {
            rep(b, "Seishiro was trying to mitigate Genshin's guilt, ", "Seishiro tentait d'atténuer la culpabilité de Genshin, ");
            rep(b, "so he took\r\nto the stand to testify.", "il s'est donc\r\nprésenté à la barre pour témoigner.");
            rep(b, "But he...", "Mais il...");
            rep(b, "got a little carried away and, ", "s'est un peu emporté et, ");
            rep(b, "um...", "euh...");
            rep(b, "actually\r\nmanaged to break the witness stand.", "a purement et\r\nsimplement fracassé la barre des témoins.");
        });

        // Key 99
        addKey(@"BB\script\output\_sce03_chr101_01_eng#5", b => {
            rep(b, "Oh my!", "Bonté divine !");
            rep(b, "He also said some contemptuous words about the British\r\nEmpire...", "Il a également tenu des propos méprisants envers l'Empire\r\nbritannique...");
            rep(b, "for which he was charged.", "ce qui lui a valu d'être inculpé.");
        });

        // Key 100
        addKey(@"BB\script\output\_sce03_chr101_01_eng#6", b => {
            rep(b, "He also said some contemptuous words about the British\r\nEmpire...", "Il a également tenu des propos méprisants envers l'Empire\r\nbritannique...");
            rep(b, "for which he was charged.", "ce qui lui a valu d'être inculpé.");
        });

        // Key 101
        addKey(@"BB\script\output\_sce03_chr101_01_eng#7", b => {
            rep(b, "Oh dear...", "Misère...");
            rep(b, "Although it's worryingly ", "Même s'il est étrangement ");
            rep(b, "easy to imagine him\r\ndoing that.", "facile de l'imaginer\r\nfaire une chose pareille.");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "it was all alright in the end.", "tout s'est bien terminé au bout du compte.");
            rep(b, "He was acquitted and\r\nwe returned home to Japan together.", "Il a été acquitté et\r\nnous sommes rentrés au Japon ensemble.");
            rep(b, "Thank goodness!", "Grand bien fasse !");
            rep(b, "Ah yes, ", "Ah oui, ");
            rep(b, "talking of Seishiro...", "en parlant de Seishiro...");
            rep(b, "...I have a copy of the photograph we all took together\r\nhere yesterday.", "... j'ai un tirage de la photographie que nous avons prise ensemble\r\nici hier.");
            rep(b, "...Please.", "... Je vous en prie.");
            rep(b, "Oh, ", "Oh, ");
            rep(b, "what a lovely picture!", "quelle splendide photographie !");
            rep(b, "It certainly seems to shout, ", "Elle semble véritablement proclamer : ");
            rep(b, "‘We've arrived in Britain!’", "« Nous voilà en Grande-Bretagne ! »");
            rep(b, "The commemorative photograph has been\r\nentered into the Court Record.", "La photo commémorative a été\r\najoutée au dossier de l'affaire.");
            rep(b, "None of us had any idea what was coming when we took\r\nthat, ", "Aucun d'entre nous ne se doutait de ce qui allait arriver quand nous l'avons prise,\r\n");
            rep(b, "did we?", "n'est-ce pas ?");
            rep(b, "No...", "Non...");
            rep(b, "No, ", "Non, ");
            rep(b, "that's so true...", "c'est tellement vrai...");
        });

        // Key 102
        addKey(@"BB\script\output\_sce03_chr101_01_eng#8", b => {
            rep(b, "So...", "Alors...");
            rep(b, "you mentioned a favour that you'd like to ask me.", "vous disiez avoir un service à me demander.");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "this...", "ce...");
            rep(b, "fateful trial that you're fighting...", "procès fatidique que vous menez...");
            rep(b, "One way or another, ", "D'une manière ou d'une autre, ");
            rep(b, "it will be over before long.", "il touchera bientôt à son terme.");
            rep(b, "And when it is, ", "Et dès qu'il sera achevé, ");
            rep(b, "I'd like you to accompany me back to\r\nJapan.", "j'aimerais que vous m'accompagniez pour rentrer au\r\nJapon.");
            rep(b, "You want me to do...", "Vous voulez que je...");
            rep(b, "WHAAAT?!", "QUOOOI ?!");
            rep(b, "F-", "P-");
            rep(b, "Father!", "Père !");
            rep(b, "What's the meaning of this?", "Qu'est-ce que cela signifie ?");
            rep(b, "Now Susato, ", "Voyons Susato, ");
            rep(b, "you should understand.", "tu devrais comprendre.");
            rep(b, "You've seen how our courts work firsthand.", "Tu as pu constater de tes propres yeux le fonctionnement de nos tribunaux.");
            rep(b, "Japan's judicial system ", "Le système judiciaire japonais ");
            rep(b, "is in its infancy.", "n'en est qu'à ses balbutiements.");
            rep(b, "Especially when it comes to defence.", "Tout particulièrement en matière de défense.");
            rep(b, "Oh!", "Oh !");
            rep(b, "You mean...?", "Vous voulez dire... ?");
            rep(b, "The Supreme Court of Judicature is in desperate need of\r\n", "La Cour Suprême de Justice a un besoin impérieux d'\r\n");
            rep(b, "a good defence lawyer", "un brillant avocat de la défense");
            rep(b, "As soon as possible.", "Le plus tôt possible.");
            rep(b, "Really quite urgently, ", "C'est même d'une urgence absolue, ");
            rep(b, "in fact.", "en réalité.");
            rep(b, "B-", "M-");
            rep(b, "But...", "Mais...");
            rep(b, "I've not even ", "je ne suis même pas ");
            rep(b, "been in London a year yet!", "à Londres depuis un an !");
            rep(b, "I've read all of Susato's reports.", "J'ai lu tous les rapports de Susato.");
            rep(b, "I'm well aware of your\r\nextraordinary talents.", "Je suis pleinement conscient de vos\r\ntalents remarquables.");
            rep(b, "And having seen you in action with my own eyes\r\nearlier today, ", "Et pour vous avoir vu à l'œuvre de mes propres yeux\r\nplus tôt aujourd'hui, ");
            rep(b, "there's no question:", "cela ne fait aucun doute :");
            rep(b, "You, ", "Vous, ");
            rep(b, "Naruhodo, ", "Naruhodo, ");
            rep(b, "are precisely ", "êtes très exactement ");
            rep(b, "the man our country needs", "l'homme dont notre nation a besoin");
            rep(b, "So...", "Alors...");
            rep(b, "you'd be leaving then, ", "tu partirais donc, ");
            rep(b, "Runo?", "Runo ?");
            rep(b, "But then...", "Mais alors...");
            rep(b, "what am I supposed to do, ", "que suis-je censée faire, ");
            rep(b, "Father?", "Père ?");
            rep(b, "You came here ", "Tu es venue ici ");
            rep(b, "to serve as Asogi's judicial assistant.", "pour servir d'assistante juridique à Asogi.");
            rep(b, "(Oh, yes...", "(Ah, c'est vrai...");
            rep(b, "she's supposed to be Kazuma's assistant...)", "elle est censée être l'assistante de Kazuma...)");
            rep(b, "Our government ", "Notre gouvernement ");
            rep(b, "is still in the process of deciding ", "est encore en train d'examiner ");
            rep(b, "how\r\nbest to deal with his situation, though.", "la meilleure façon\r\nde gérer sa situation, cela dit.");
            rep(b, "You've always chosen your own path, ", "Tu as toujours choisi ta propre voie, ");
            rep(b, "Susato.", "Susato.");
            rep(b, "And I trust your judgement.", "Et j'ai toute confiance en ton jugement.");
            rep(b, "...In this matter also.", "... Pour cette affaire également.");
            rep(b, "Father!", "Père !");
            rep(b, "Please, ", "De grâce, ");
            rep(b, "the pair of you...", "tous les deux...");
            rep(b, "Don't look so downcast.", "Ne prenez pas cet air si abattu.");
            rep(b, "It's merely a suggestion, ", "Ce n'est qu'une proposition, ");
            rep(b, "you understand.", "vous le concevez bien.");
            rep(b, "A hope, ", "Un vœu pieux, ");
            rep(b, "if I'm honest.", "à vrai dire.");
            rep(b, "But I won't force you.", "Mais je ne vous forcerai jamais la main.");
            rep(b, "All I ask is that you consider it, ", "Tout ce que je vous demande, c'est d'y réfléchir, ");
            rep(b, "and come to a decision by\r\nthe time this trial concludes.", "et d'arrêter votre décision d'ici\r\nà ce que ce procès s'achève.");
            rep(b, "alright.", "d'accord.");
            rep(b, "You, ", "Tu, ");
            rep(b, "you won't leave...", "tu ne vas pas partir...");
            rep(b, "will you, ", "n'est-ce pas, ");
            rep(b, "(The thought hadn't even crossed my mind.)", "(Cette pensée ne m'avait même pas effleuré l'esprit.)");
            rep(b, "(Up until now, ", "(Jusqu'à présent, ");
            rep(b, "I've just been trying to do what I believed\r\nto be Kazuma's will.)", "je m'efforçais simplement d'accomplir ce que je croyais\r\nêtre la volonté de Kazuma.)");
            rep(b, "(But it turns out ", "(Mais il s'avère ");
            rep(b, "that ", "qu'");
            rep(b, "he's still alive", "il est toujours vivant");
            rep(b, ", so...)", ", alors...)");
            rep(b, "(...where does that leave me?)", "(... quelle est ma place à présent ?)");
        });

        // Key 103
        addKey(@"BB\script\output\_sce03_chr103_00_eng#1", b => {
            rep(b, "Not long ago, ", "Récemment, ");
            rep(b, "visitor numbers to the Great Exhibition\r\nexceeded thirty million.", "le nombre de visiteurs à l'Exposition universelle\r\na dépassé les trente millions.");
            rep(b, "Th-", "T-");
            rep(b, "Thirty million?!", "Trente millions ?!");
            rep(b, "(Are there even that many people in the world?)", "(Y a-t-il seulement autant d'habitants sur Terre ?)");
            rep(b, "As a comparison, ", "À titre de comparaison, ");
            rep(b, "Mr Naruhodo, ", "monsieur Naruhodo, ");
            rep(b, "the population of the\r\nimperial capital Tokyo is two million.", "la population de la capitale\r\nimpériale Tokyo est de deux millions d'âmes.");
            rep(b, "I will be opening the International Forensic Science\r\nSymposium in the exhibition's main auditorium.", "C'est moi qui présiderai l'ouverture du Colloque international\r\nde médecine légale dans l'auditorium principal de l'Exposition.");
            rep(b, "This event has been two years in the making.", "Cet événement est l'aboutissement de deux ans de labeur.");
            rep(b, "Two years\r\nof preparations and negotiations with other countries.", "Deux années\r\nde préparatifs et de tractations diplomatiques.");
            rep(b, "It sounds like a tremendous achievement.", "Cela ressemble à un accomplissement colossal.");
            rep(b, "Congratulations.", "Toutes mes félicitations.");
            rep(b, "The twentieth century will see the wholesale adoption of\r\n", "Le vingtième siècle verra l'adoption généralisée de\r\n");
            rep(b, "forensic investigation", "l'investigation médico-légale");
            rep(b, " techniques.", ".");
            rep(b, "And cooperation between policing organisations around\r\nthe globe will be essential.", "Et la coopération entre les forces de police du monde entier\r\nsera absolument capitale.");
            rep(b, "Which is why...", "C'est pourquoi...");
            rep(b, "...this landmark first symposium had to be hosted here at\r\nthe heart of our great British Empire!", "... ce premier colloque historique devait impérativement se tenir ici,\r\nau cœur même de notre grand Empire britannique !");
            rep(b, "In order that Scotland Yard can become the leading\r\ninvestigative organisation in the new world!", "Afin que Scotland Yard devienne la référence mondiale des organisations\r\nd'investigation dans l'ère nouvelle !");
            rep(b, "(He's the same as ever, ", "(Il n'a pas changé d'un pouce, ");
            rep(b, "I see.", "à ce que je vois.");
            rep(b, "That passion of his is quite something...)", "Cette ferveur qui l'anime est impressionnante...)");
            rep(b, "You're every bit as passionate in your own way,", "Vous êtes tout aussi passionné à votre manière,");
            rep(b, " I'm sure,\r\nMr Naruhodo!", " j'en suis convaincue,\r\nmonsieur Naruhodo !");
            rep(b, "I'm the only person in this country who truly cares about\r\na future that embraces forensic science.", "Je suis la seule personne en ce pays qui se soucie réellement d'un\r\navenir s'appuyant sur la médecine légale.");
            rep(b, "It was my intention to become Her Majesty's Attorney\r\nGeneral and reform the Yard from the ground up.", "Mon dessein était d'accéder au rang de Procureur général de Sa Majesté\r\net de refondre Scotland Yard de fond en comble.");
            rep(b, "So ", "Ainsi, ");
            rep(b, "the disgrace of the Forensic Investigation Team has\r\nbeen a bitter blow to my ambitions.", "le déshonneur jeté sur l'équipe de police scientifique a été\r\nun rude coup porté à mes ambitions.");
        });

        // Key 104
        addKey(@"BB\script\output\_sce03_chr103_00_eng#2", b => {
            rep(b, "I first established the Forensic Investigation Team a year\r\nago.", "J'ai créé l'équipe de police scientifique il y a un an de cela.");
            rep(b, "Experimentally, ", "À titre expérimental, ");
            rep(b, "to start with.", "pour commencer.");
            rep(b, "With Dr Sithe at the helm, ", "Avec la Dre Pétrie à sa tête, ");
            rep(b, "it was steadily accruing an\r\nimpressive record of achievement.", "elle accumulait méthodiquement des\r\nsuccès remarquables.");
            rep(b, "I was on the verge of changing its name and elevating its\r\nstatus to a full-blown Forensic Investigation Department.", "J'étais sur le point de modifier son statut pour en faire un véritable\r\ndépartement ministériel de police scientifique.");
            rep(b, "And...", "Et...");
            rep(b, "can you ", "vous ne pouvez ");
            rep(b, "not do that", "plus le faire");
            rep(b, " now?", " désormais ?");
            rep(b, "Obviously.", "Évidemment.");
            rep(b, "Nobody wants to hear anything about it at the\r\nmoment.", "Personne ne veut plus entendre parler de cela pour le moment.");
            rep(b, "Even I can't keep this story out of the papers.", "Même mon autorité ne peut étouffer cette affaire dans la presse.");
            rep(b, "Six million Londoners will be cursing forensic science\r\nnow.", "Six millions de Londoniens vont désormais maudire la police scientifique.");
            rep(b, "This incident ", "Cet incident ");
            rep(b, "will set back our country's advancement\r\nin the field by a good ten years, ", "retardera les progrès de notre nation dans ce domaine\r\nd'une bonne décennie, ");
            rep(b, "I'd say.", "à n'en pas douter.");
            rep(b, "(Unintended ", "(Les ");
            rep(b, "repercussions", "répercussions involontaires");
            rep(b, " of our trial...)", " de notre procès...)");
            rep(b, "We simply couldn't have overlooked what had happened,\r\nthough.", "Nous ne pouvions tout simplement pas fermer les yeux sur ce qui s'était passé,\r\npourtant.");
            rep(b, "Of course not.", "Bien entendu.");
            rep(b, "We should all be grateful to you both.", "Nous devrions tous vous être reconnaissants à tous deux.");
            rep(b, "Anyway, ", "Quoi qu'il en soit, ");
            rep(b, "I'll still reform this country's policing when I\r\nbecome Attorney General.", "je réformerai tout de même la police de ce pays une fois nommé\r\nProcureur général.");
            rep(b, "This might delay my plans, ", "Cela retardera peut-être mes desseins, ");
            rep(b, "but it won't alter them.", "mais ne les infléchira point.");
            rep(b, "Nothing will stand in my way.", "Rien ne se mettra en travers de mon chemin.");
        });

        // Key 105
        addKey(@"BB\script\output\_sce03_chr103_00_eng#3", b => {
            rep(b, "Um, ", "Hum, ");
            rep(b, "about Lord van Zieks's apprentice...", "à propos du disciple de Lord Van Peers...");
            rep(b, "Ah yes, ", "Ah oui, ");
            rep(b, "that came as a surprise to me, ", "ce fut une surprise pour moi, ");
            rep(b, "I must say.", "je dois bien le concéder.");
            rep(b, "That you and he are old friends.", "Que vous et lui soyez de vieux amis.");
            rep(b, "...How did he become an apprentice to Lord van Zieks in\r\nthe first place?", "... Comment en est-il venu à devenir le disciple de Lord Van Peers\r\nau juste ?");
            rep(b, "It came about three months ago.", "Tout cela a commencé il y a trois mois.");
            rep(b, "An unidentified Asian man", "Un homme asiatique non identifié");
            rep(b, "was apprehended by border\r\npolice.", "a été appréhendé par la police\r\ndes frontières.");
            rep(b, "They found him hiding aboard a large goods vessel.", "Ils l'ont découvert tapi à bord d'un cargo de marchandises.");
            rep(b, "Oh my!", "Bonté divine !");
            rep(b, "So he stowed away to get here!", "Il a donc voyagé en passager clandestin !");
            rep(b, "He had ", "Il n'avait ");
            rep(b, "no papers to identify him.", "aucun papier d'identité sur lui.");
            rep(b, "No passport.", "Aucun passeport.");
            rep(b, "And he was suffering from amnesia, too.", "Et de surcroît, il était frappé d'amnésie.");
            rep(b, "Other than the fact he was clearly of Eastern descent,", "Mis à part le fait qu'il était manifestement d'origine orientale,");
            rep(b, "there were no clues as to who he was.", "il n'existait aucun indice quant à son identité.");
            rep(b, "So I decided to assign him to Lord van Zieks.", "J'ai donc pris la décision de l'assigner à Lord Van Peers.");
            rep(b, "That way I could keep an eye on him.", "De cette manière, je gardais un œil sur lui.");
            rep(b, "But then...", "Mais alors...");
            rep(b, "why the mask?", "pourquoi ce masque ?");
            rep(b, "I didn't want to burden Lord van Zieks with tiresome\r\nexplanations about why he had an Eastern apprentice.", "Je refusais d'embarrasser Lord Van Peers avec de fastidieuses explications\r\nsur la raison pour laquelle son disciple était un Oriental.");
            rep(b, "(Because it would be so much easier to explain why he\r\nwas wearing a mask...?)", "(Parce qu'il serait tellement plus simple d'expliquer pourquoi il portait un masque... ?)");
            rep(b, "He's proving to be a great help to Lord van Zieks.", "Il s'avère d'une aide précieuse pour Lord Van Peers.");
            rep(b, "I have high hopes for his future.", "Je nourris de grands espoirs pour son avenir.");
            rep(b, "By the way, ", "Au fait, ");
            rep(b, "do you know where he's gone?", "savez-vous où il s'est rendu ?");
            rep(b, "No idea.", "Aucune idée.");
            rep(b, "But I believe he's left London for the time being.", "Mais je crois qu'il a quitté Londres pour l'instant.");
            rep(b, "Oh...", "Oh...");
            rep(b, "I take it you also didn't know.", "J'en déduis que vous ne le saviez pas non plus.");
            rep(b, "That the man's father was one of our country's most\r\ninfamous criminals, ", "Que le père de cet homme était l'un des criminels les plus tristement\r\ncélèbres de notre histoire, ");
            rep(b, "I mean.", "je veux dire.");
            rep(b, "(Genshin Asogi...)", "(Genshin Asogi...)");
        });

        // Key 106
        addKey(@"BB\script\output\_sce03_chr103_00_eng#4", b => {
            rep(b, "What we learnt from that trial eight days ago was a huge\r\nshock.", "Ce que nous avons appris lors de ce procès il y a huit jours a été un choc terrible.");
            rep(b, "Finding out my friend's father was...", "Découvrir que le père de mon ami était...");
            rep(b, "Ah yes.", "Ah oui.");
            rep(b, "Genshin Asogi.", "Genshin Asogi.");
            rep(b, "The Professor case ten years ago caused a great stir here\r\nin Britain.", "L'affaire du Démon Assassin il y a dix ans a provoqué un émoi considérable ici en Grande-Bretagne.");
            rep(b, "They were such awful murders.", "C'étaient des meurtres tellement effroyables.");
            rep(b, "And unprecedented.", "Et sans aucun précédent.");
            rep(b, "Using ", "Utiliser ");
            rep(b, "a ferocious dog", "un chien féroce");
            rep(b, " as a murder weapon.", " comme arme du crime.");
            rep(b, "And no one would have believed the culprit was a foreign\r\nstudent invited to study here by the government.", "Et personne n'aurait pu croire que le coupable était un étudiant étranger\r\ninvité à séjourner ici par le gouvernement.");
            rep(b, "So the true identity of the killer couldn't be made public\r\nthen, ", "La véritable identité du meurtrier ne pouvait donc pas être divulguée à l'époque, ");
            rep(b, "and can't be made public now.", "et ne peut l'être davantage aujourd'hui.");
            rep(b, "Nobody in your country knows it was him.", "Nul dans votre pays ne sait qu'il s'agissait de lui.");
            rep(b, "And neither do the citizens of London.", "Pas plus que les citoyens de Londres.");
            rep(b, "The main motivation ", "La motivation principale ");
            rep(b, "was to avoid aggravating relations\r\nbetween our two nations at the time, ", "était d'éviter d'envenimer les relations\r\nentre nos deux nations à cette période, ");
            rep(b, "I understand.", "d'après ce que j'ai cru comprendre.");
            rep(b, "Correct.", "C'est exact.");
            rep(b, "However...", "Cependant...");
            rep(b, "...it has to be noted ", "... force est de constater ");
            rep(b, "that there were some ", "qu'il y a eu des ");
            rep(b, "supporters", "partisans");
            rep(b, " of\r\nthe Professor's apparent cause.", " de\r\nla prétendue cause du Démon Assassin.");
            rep(b, "What?!", "Quoi ?!");
            rep(b, "Supporters of a mass murderer?", "Des partisans d'un tueur en série ?!");
            rep(b, "The majority of the man's victims were a blight on the\r\naristocracy of the day.", "La majorité des victimes de cet homme constituaient un fléau pour l'aristocratie d'alors.");
            rep(b, "Somewhat ironically, ", "Non sans ironie, ");
            rep(b, "their deaths actually benefitted\r\nsociety as a whole.", "leur disparition s'est en réalité avérée bénéfique pour la société dans son ensemble.");
            rep(b, "...Or so a fair few thinkers in London believed anyway.", "... Du moins est-ce ce que pensaient bon nombre d'esprits éclairés à Londres.");
            rep(b, "Right...", "Bien...");
            rep(b, "I see...", "je vois...");
            rep(b, "(But it was still ", "(Mais cela n'en demeurait pas moins un ");
            rep(b, "murder", "meurtre");
            rep(b, ", wasn't it?)", ", n'est-ce pas ?)");
            rep(b, "It seems very similar, ", "Cela semble tout à fait similaire, ");
            rep(b, "doesn't it?", "n'est-ce pas ?");
            rep(b, "To the idea of the Reaper of the Bailey.", "À l'idée même du Faucheur de l'Old Bailey.");
        });

        // Key 107
        addKey(@"BB\script\output\_sce03_chr103_00_eng#7", b => {
            rep(b, "could I show you this, ", "pourrais-je vous montrer ceci, ");
            rep(b, "Lord Stronghart?", "Lord Caine ?");
            rep(b, "...I'm the Lord Chief Justice.", "... Je suis le Lord grand justicier.");
            rep(b, "I'm not here to offer advice\r\nabout evidence.", "Je ne suis pas ici pour dispenser des conseils sur des pièces à conviction.");
            rep(b, "Especially when the evidence in question is so dull.", "Tout particulièrement quand la pièce en question s'avère aussi insipide.");
            rep(b, "(Ah, ", "(Ah, ");
            rep(b, "so that's the real reason.)", "voilà donc la véritable raison.)");
        });

        // Key 108
        addKey(@"BB\script\output\_sce03_chr103_00_eng#8", b => {
            rep(b, "Your defence lawyer's blazon?", "Votre insigne d'avocat de la défense ?");
            rep(b, "It clearly means a lot to you.", "Il a manifestement une immense valeur à vos yeux.");
            rep(b, "Oh yes.", "Oh oui.");
            rep(b, "It's a keepsake from my best friend as well as a\r\nsymbol of what I'm trying to achieve.", "C'est à la fois un souvenir précieux de mon meilleur ami et le symbole de ce que je m'efforce d'accomplir.");
            rep(b, "But that friend ", "Mais cet ami ");
            rep(b, "has returned to us now, ", "nous est revenu à présent, ");
            rep(b, "Mr Naruhodo.", "monsieur Naruhodo.");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "until it's time to return this to him, ", "en attendant qu'il soit temps de le lui restituer, ");
            rep(b, "I intend to keep\r\nwearing it proudly on my arm.", "j'ai bien l'intention de continuer à le porter fièrement à mon bras.");
            rep(b, "is going to face you in court, ", "va vous affronter au tribunal, ");
            rep(b, "...A complicated situation by the sound of it.", "... Une situation pour le moins intriquée, à ce qu'il paraît.");
        });

        // Key 109
        addKey(@"BB\script\output\_sce03_chr103_00_eng#9", b => {
            rep(b, "Are you aware of the Red-Headed League,", "Avez-vous entendu parler de la Ligue des Rouquins,");
            rep(b, " Lord\r\nStronghart?", " Lord\r\nCaine ?");
            rep(b, "No.", "Non.");
            rep(b, "I didn't read that advertisement.", "Je n'ai pas lu cette petite annonce.");
            rep(b, "It seems they were trying to swindle red-heads.", "Il semble qu'ils cherchaient à escroquer les personnes rousses.");
            rep(b, "I see.", "Je vois.");
            rep(b, "I suppose I would be in the White-Headed\r\nLeague, ", "J'imagine que je ferais plutôt partie de la Ligue des Têtes Blanches,\r\n");
            rep(b, "if anything.", "si tant est qu'elle existât.");
            rep(b, "That sounds rather like ", "Cela ressemble plutôt à ");
            rep(b, "an elderly gentlemen's club.", "un cercle de vieux gentilshommes.");
            rep(b, "(Oops, ", "(Oups, ");
            rep(b, "I have a feeling...)", "j'ai l'impression...)");
            rep(b, "(...I might have made a bit of a faux pas there.)", "(... que j'ai peut-être commis un impair.)");
        });

        // Key 110
        addKey(@"BB\script\output\_sce03_chr103_00_eng#10", b => {
            rep(b, "Penned by Dr Mikotoba, ", "Rédigée de la main du Dr Mikotoba, ");
            rep(b, "I see.", "je vois.");
            rep(b, "It's been ten long years...", "Dix longues années ont passé...");
            rep(b, "But you remember my father, ", "Vous vous souvenez donc de mon père, ");
            rep(b, "do you?", "n'est-ce pas ?");
            rep(b, "Certainly, ", "Tout à fait, ");
            rep(b, "I remember him.", "je me souviens de lui.");
            rep(b, "And the two other visiting\r\nstudents.", "Tout comme des deux autres étudiants\r\ninvités.");
            rep(b, "Of course...", "Évidemment...");
            rep(b, "Mikotoba was assigned to the hospital\r\nlaboratory, ", "Mikotoba était affecté au laboratoire de l'hôpital,\r\n");
            rep(b, "so we rarely met.", "nous nous croisions donc rarement.");
            rep(b, "Jigoku ", "Jigoku, ");
            rep(b, "on the other hand ", "en revanche, ");
            rep(b, "studied our justice system under\r\nmy personal supervision.", "a étudié notre système judiciaire sous\r\nma supervision personnelle.");
            rep(b, "Oh, ", "Oh, ");
            rep(b, "I see...", "je vois...");
            rep(b, "As I said, ", "Comme je l'ai dit, ");
            rep(b, "that was ten years ago now.", "c'était il y a dix ans de cela.");
            rep(b, "But I'm pleased to see they've both made names for\r\nthemselves in their particular disciplines.", "Mais je me réjouis de voir qu'ils se sont tous deux forgé un nom dans leurs domaines respectifs.");
        });

        // Key 111
        addKey(@"BB\script\output\_sce03_chr103_00_eng#11", b => {
            rep(b, "I'm sure you can imagine that tomorrow's trial will be\r\nclosely followed all over London.", "Vous imaginez bien que le procès de demain sera suivi avec la plus grande attention dans tout Londres.");
            rep(b, "In fact, ", "En vérité, ");
            rep(b, "no.", "non.");
            rep(b, "People all over the empire will be watching\r\nclosely to see how it unfolds.", "C'est l'Empire tout entier qui observera attentivement son déroulement.");
            rep(b, "There's no salvation for anyone in a trial prosecuted by\r\nthe Reaper of the Bailey.", "Il n'y a aucun salut pour quiconque affronte le Faucheur de l'Old Bailey.");
            rep(b, "And now...", "Et désormais...");
            rep(b, "...the Reaper ", "... le Faucheur ");
            rep(b, "himself", "en personne");
            rep(b, " must stand in the dock.", " doit se tenir au banc des accusés.");
            rep(b, "Quite so.", "Parfaitement.");
            rep(b, "The public want answers about the Reaper.", "Le public exige des réponses au sujet du Faucheur.");
            rep(b, "Answers about how and why those who escaped\r\nconviction subsequently died ", "Des réponses sur la façon dont ceux ayant échappé à une condamnation ont fini par mourir ");
            rep(b, "mysterious deaths", "de mort mystérieuse");
            rep(b, "But Lord van Zieks ", "Mais Lord Van Peers ");
            rep(b, "firmly ", "nie formellement ");
            rep(b, "denies any involvement", "toute implication");
            rep(b, " in\r\nsuch matters.", " dans de tels agissements.");
            rep(b, "And there have been thorough investigations that have\r\nproven him to be ", "Et des enquêtes approfondies ont prouvé son ");
            rep(b, "innocent", "innocence");
            rep(b, "That's certainly true.", "C'est incontestablement vrai.");
            rep(b, "Or it has been, ", "Ou du moins, cela l'a été ");
            rep(b, "at least, ", "jusqu'à ");
            rep(b, "until now.", "présent.");
            rep(b, "Ah!", "Ah !");
            rep(b, "No, ", "Non, ");
            rep(b, "tomorrow's trial...", "le procès de demain...");
            rep(b, "...will mark the start of a new chapter in our country's\r\ngreat judicial history!", "... marquera le commencement d'un nouveau chapitre dans la grande histoire judiciaire de notre nation !");
        });

        // Key 112
        addKey(@"BB\script\output\_sce03_chr103_00_eng#12", b => {
            rep(b, "So...", "Ainsi...");
            rep(b, "Kazuma will be prosecuting tomorrow?", "Kazuma mènera l'accusation demain ?");
            rep(b, "That's right.", "C'est exact.");
            rep(b, "But...", "Mais...");
            rep(b, "he's a defence lawyer, Lord Stronghart!", "c'est un avocat de la défense, Lord Caine !");
            rep(b, "Accomplished young law practitioners cannot pick and\r\nchoose their roles.", "Les jeunes praticiens du droit chevronnés ne choisissent pas leurs rôles à leur guise.");
            rep(b, "And imagine what it will mean for the prosecution to\r\nknow the strategies commonly employed by the defence.", "Et songez à l'atout que représente pour l'accusation la parfaite connaissance des stratégies de la défense.");
            rep(b, "A devastating combination, ", "Une combinaison dévastatrice, ");
            rep(b, "wouldn't you agree?", "n'en convenez-vous pas ?");
            rep(b, "(Absolutely.)", "(Absolument.)");
            rep(b, "(I've no doubt at all that Kazuma will be ", "(Je ne doute pas un instant que Kazuma sera d'une ");
            rep(b, "razor-sharp", "redoutable acuité");
            rep(b, " as a\r\nprosecutor.)", " en tant que procureur.)");
            rep(b, "why Kazuma-sama?", "pourquoi Kazuma-sama ?");
            rep(b, "There are surely many other highly skilled prosecutors\r\nin Great Britain.", "Il existe assurément bien d'autres procureurs émérites en Grande-Bretagne.");
            rep(b, "It was a personal request.", "Il s'agissait d'une requête personnelle.");
            rep(b, "I asked to be assigned to the trial.", "J'ai expressément demandé à être assigné à ce procès.");
            rep(b, "You, ", "Tu, ");
            rep(b, "you asked for this?", "tu as demandé cela ?");
            rep(b, "But why?!", "Mais pourquoi ?!");
            rep(b, "It'll all become clear tomorrow.", "Tout deviendra limpide demain.");
            rep(b, "I'm guessing you intend to stand for the defence,", "J'imagine que tu as l'intention de te charger de la défense,");
            rep(b, " don't\r\nyou?", " n'est-ce pas ?");
            rep(b, "Although ", "Même si ");
            rep(b, "the Reaper appears to be turning down all offers\r\nof representation.", "le Faucheur semble décliner toute proposition pour sa défense.");
            rep(b, "...I'm surprised such a personal request would have been\r\nupheld.", "... Je m'étonne qu'une telle requête personnelle ait été accordée.");
            rep(b, "It seems...", "Cela me paraît...");
            rep(b, "unprecedented.", "inédit.");
            rep(b, "Quite exceptional, ", "Tout à fait exceptionnel, ");
            rep(b, "in fact.", "en réalité.");
            rep(b, "You are quite right, ", "Vous avez parfaitement raison, ");
            rep(b, "Miss Mikotoba.", "mademoiselle Mikotoba.");
            rep(b, "Tomorrow's trial will be unprecedented and exceptional", "Le procès de demain sera inédit et exceptionnel");
            rep(b, "in every way.", "à tous égards.");
            rep(b, "After all, ", "Après tout, ");
            rep(b, "the accused is one of Britain's greatest\r\nprosecutors.", "l'accusé est l'un des plus illustres procureurs de Grande-Bretagne.");
            rep(b, "The pride of the empire.", "La fierté de l'Empire.");
            rep(b, "It would be unwise to give the public a reason to perceive\r\nit as the judiciary closing ranks.", "Il serait maladroit de donner au public l'impression que le corps judiciaire fait corps pour se protéger.");
            rep(b, "So that's why you're happy to let a foreigner handle the\r\nprosecution?", "C'est donc pour cela que vous consentez à confier l'accusation à un étranger ?");
            rep(b, "Ryunosuke...", "Ryunosuke...");
            rep(b, "...let's see how your skills have been honed ", "... voyons comment tes talents se sont affûtés ");
            rep(b, "after\r\npractising law in this land for so many months!", "après\r\navoir pratiqué le droit sur ces terres durant tous ces mois !");
            rep(b, "Kazuma, ", "Kazuma, ");
            rep(b, "I...", "je...");
            rep(b, "(I don't understand why you're being so hostile to me\r\nnow.", "(Je ne comprends pas pourquoi tu te montres si hostile envers moi désormais.");
            rep(b, "This isn't going to end well, ", "Cela va mal se terminer, ");
            rep(b, "my friend...)", "mon ami...)");
        });

        // Key 113
        addKey(@"BB\script\output\_sce03_chr103_00_eng#13", b => {
            rep(b, "Oh yes, ", "Ah oui, ");
            rep(b, "we noticed that there was a gun at the scene of\r\nInspector Gregson's death.", "nous avons remarqué qu'il y avait une arme à feu sur la scène du meurtre de l'inspecteur Gregson.");
            rep(b, "Do you know if it belongs to Lord van Zieks?", "Savez-vous si elle appartient à Lord Van Peers ?");
            rep(b, "That would be a question for the lead detective\r\ninvestigating the scene.", "Cette question relève de l'enquêtrice chargée des investigations sur les lieux.");
            rep(b, "Well ", "Eh bien, ");
            rep(b, "the thing is...", "le fait est que...");
            rep(b, "...she wasn't sure,", "... elle n'en était pas sûre,");
            rep(b, "so she told me I should ask", "elle m'a donc dit de demander à");
            rep(b, " somebody\r\nhigher up who might know.", " quelqu'un\r\nde plus haut placé qui pourrait le savoir.");
            rep(b, "That's right, ", "C'est bien cela, ");
            rep(b, "Mr Naruhodo.", "monsieur Naruhodo.");
            rep(b, "Be direct!", "Allez droit au but !");
            rep(b, "It's certainly a model that's issued to all personnel\r\ninvolved in law enforcement, ", "C'est indubitablement un modèle attribué à tous les officiers de l'autorité publique, ");
            rep(b, "yes.", "oui.");
            rep(b, "Which includes prosecutors, ", "Ce qui inclut les procureurs, ");
            rep(b, "as I'm sure you can imagine.", "comme vous l'imaginez sans peine.");
            rep(b, "In that case...", "Dans ce cas...");
            rep(b, "it could actually have ", "elle aurait très bien pu ");
            rep(b, "belonged to the victim", "appartenir à la victime");
            rep(b, "No.", "Non.");
            rep(b, " Gregson had his gun on his person.", " Gregson avait sa propre arme sur lui.");
            rep(b, "What about ", "Et qu'en est-il de ");
            rep(b, "Lord van Zieks?", "Lord Van Peers ?");
            rep(b, "He claims it's currently ", "Il affirme qu'elle n'est pas ");
            rep(b, "not in his possession", "en sa possession actuellement");
            rep(b, "According to his story, ", "D'après ses dires, ");
            rep(b, "he lost it.", "il l'aurait égarée.");
            rep(b, "In short...", "En somme...");
            rep(b, "it's more than a little ", "c'est plus que ");
            rep(b, "suspicious", "suspect");
            rep(b, "But just because the gun in question is the same type as\r\nthe defendant's ", "Mais le simple fait que cette arme soit du même modèle que celle du prévenu ");
            rep(b, "is no proof that it's actually his.", "ne prouve en rien qu'il s'agisse de la sienne.");
            rep(b, "No, ", "Non, ");
            rep(b, "of course not.", "évidemment.");
            rep(b, "(Nevertheless, ", "(Néanmoins, ");
            rep(b, "the situation is grave for Lord van Zieks...)", "la situation est très délicate pour Lord Van Peers...)");
        });

        // Key 114
        addKey(@"BB\script\output\_sce03_chr103_01_eng#1", b => {
            rep(b, "Does Prosecutor Asogi believe...", "Le procureur Asogi croit-il...");
            rep(b, "that Lord van Zieks is the\r\nReaper?", "que Lord Van Peers est le\r\nFaucheur ?");
            rep(b, "I wouldn't know.", "Je l'ignore.");
            rep(b, "It was ten years ago, ", "C'était il y a dix ans, ");
            rep(b, "in that fateful closed trial, ", "lors de ce sinistre procès à huis clos, ");
            rep(b, "that Lord\r\nvan Zieks made a name for himself among the judiciary.", "que Lord\r\nVan Peers s'est fait un nom au sein de la magistrature.");
            rep(b, "But the next trial he fought, ", "Mais au procès suivant qu'il a disputé, ");
            rep(b, "he lost.", "il a échoué.");
            rep(b, "It meant the ringleader of a criminal organisation was\r\nacquitted...", "Cela signifiait que le chef d'une organisation criminelle était acquitté...");
            rep(b, "thanks to all the jurors being ", "grâce aux jurés qui étaient tous ");
            rep(b, "under duress", "sous pression et menaces");
            rep(b, "But that's awful!", "Mais c'est ignoble !");
            rep(b, "The man's freedom was short-lived.", "La liberté de cet individu fut de courte durée.");
            rep(b, "He lasted just three\r\ndays.", "Il n'a survécu que trois\r\npetits jours.");
            rep(b, "Yes, ", "Oui, ");
            rep(b, "let me see...", "voyons voir...");
            rep(b, "he died in a rockslide at his place of\r\nwork, ", "il a péri lors d'un éboulement sur son lieu\r\nde travail, ");
            rep(b, "I believe!", "si mes souvenirs sont exacts !");
            rep(b, "Correct.", "C'est exact.");
            rep(b, "That was the inauguration of the Reaper of the\r\nBailey.", "Ce fut l'inauguration de la légende du Faucheur de l'Old Bailey.");
            rep(b, "And people believed Lord van Zieks was responsible?", "Et les gens ont cru que Lord Van Peers en était responsable ?");
            rep(b, "He was brought to trial himself.", "Il a lui-même été traduit en justice.");
            rep(b, "...But it was shown to have been an accident.", "... Mais les faits ont conclu à un tragique accident.");
            rep(b, "(So he must have had a solid ", "(Il devait donc avoir un solide ");
            rep(b, "alibi", "alibi");
            rep(b, " then.)", " à l'époque.)");
            rep(b, "Nevertheless, ", "Néanmoins, ");
            rep(b, "the mysterious deaths continued.", "les décès mystérieux se sont poursuivis.");
            rep(b, "In total, ", "Au total, ");
            rep(b, "sixteen persons perished in unusual\r\ncircumstances, ", "seize individus ont péri dans des circonstances suspectes, ");
            rep(b, "ostensibly at the hand of the Reaper.", "soi-disant de la main du Faucheur.");
            rep(b, "...That's a long run of coincidences.", "... Cela fait beaucoup de coïncidences.");
            rep(b, "Well, ", "Eh bien, ");
            rep(b, "the Reaper's true identity may well be revealed by\r\nthis trial.", "la véritable identité du Faucheur pourrait fort bien éclater au grand jour lors de ce procès.");
            rep(b, "And the impact that revelation would have on the British\r\npublic cannot be understated.", "Et l'impact d'une telle révélation sur le peuple britannique sera considérable.");
            rep(b, "...Is that why it's a closed trial?", "... Est-ce la raison pour laquelle le procès se tient à huis clos ?");
            rep(b, "Precisely.", "Précisément.");
        });

        // Key 115
        addKey(@"BB\script\output\_sce03_chr103_01_eng#2", b => {
            rep(b, "This country hasn't seen a closed trial for ten years.", "Ce pays n'a pas connu de procès à huis clos depuis dix ans.");
            rep(b, "So the last one...", "Le dernier en date...");
            rep(b, "was the Professor's?", "était celui du Démon Assassin ?");
            rep(b, "The trial of Genshin Asogi?", "Le procès de Genshin Asogi ?");
            rep(b, "Correct.", "Exactement.");
            rep(b, "Actually, ", "En vérité, ");
            rep(b, "we heard that originally...", "nous avons entendu dire qu'à l'origine...");
            rep(b, "...you were going to prosecute that trial yourself,", "... vous deviez mener vous-même l'accusation lors de ce procès,");
            rep(b, " Lord\r\nStronghart.", " Lord\r\nCaine.");
            rep(b, "Van Zieks entreated me to relinquish the prosecution to\r\nhim.", "Van Peers m'a imploré de lui céder le dossier de l'accusation.");
            rep(b, "That he might avenge his brother's death.", "Pour qu'il puisse venger la mort de son frère.");
            rep(b, "And here we are, ", "Et nous voici, ");
            rep(b, "ten years later...", "dix années plus tard...");
            rep(b, "...with the son of the man van Zieks had condemned ", "... avec le fils de l'homme que Van Peers avait fait condamner, ");
            rep(b, "now\r\nlooking to avenge his father's death in the same way.", "qui\r\ncherche à présent à venger la mort de son père de la même manière.");
            rep(b, "(They do say ", "(Comme on dit, ");
            rep(b, "that what goes around comes around...)", "on finit toujours par récolter ce que l'on a semé...)");
            rep(b, "However, ", "Toutefois, ");
            rep(b, "it would seem...", "il semblerait...");
            rep(b, "...that the new young prosecutor ", "... que ce jeune procureur novice ");
            rep(b, "is harbouring some\r\n", "nourrisse également d'\r\n");
            rep(b, "ulterior motive", "autres desseins cachés");
            rep(b, " as well.", ".");
            rep(b, "Kazuma is?", "Kazuma ?");
            rep(b, "I like my organisation to run smoothly, ", "J'aime que mon institution fonctionne sans accroc, ");
            rep(b, "in the exact\r\nmanner that I prescribe.", "à la manière exacte que je prescris.");
            rep(b, "As with ", "Tout comme ");
            rep(b, "the giant clock in here, ", "l'horloge colossale de cette pièce, ");
            rep(b, "I won't tolerate a single\r\ncog being out of step with the others!", "je ne tolérerai pas qu'un seul rouage déraille par rapport aux autres !");
            rep(b, "(Ah... ", "(Ah... ");
            rep(b, "so that's what all these gears are about in here...)", "voilà donc le sens de tous ces engrenages ici...)");
            rep(b, "If the young man refuses to mesh with the other parts of\r\nmy great machine...", "Si ce jeune homme refuse de s'engrener avec les autres pièces de ma grande machine...");
            rep(b, "...I will be forced to take steps.", "... je me verrai contraint de prendre des mesures.");
            rep(b, "What, ", "Que, ");
            rep(b, "what do you mean?", "que voulez-vous dire par là ?");
            rep(b, "Not something with which you need concern yourself.", "Ce n'est pas une question dont vous ayez à vous soucier.");
            rep(b, "In any case, ", "Dans tous les cas, ");
            rep(b, "all your questions will be answered\r\ntomorrow.", "toutes vos interrogations trouveront leur réponse demain.");
        });

        // Key 116
        addKey(@"BB\script\output\_sce03_chr106_01_eng#1", b => {
            rep(b, "Um, ", "Hum, ");
            rep(b, "we have actually met before.", "nous nous sommes déjà rencontrés auparavant.");
            rep(b, "I'm a lawyer, ", "Je suis avocat, ");
            rep(b, "if you remember...", "si vous vous souvenez...");
            rep(b, "You're not dead yet...", "Vous n'êtes pas encore mort...");
            rep(b, "What?", "Pardon ?");
            rep(b, "...so Mama said I wasn't to cut you open.", "... et Maman m'a dit que je ne devais pas vous disséquer.");
            rep(b, "She's so strict about things like that.", "Elle est tellement à cheval sur ce genre de principes.");
            rep(b, "Well... ", "Eh bien... ");
            rep(b, "good.", "tant mieux.");
            rep(b, "(Dr Sithe has ", "(La Dre Pétrie a ");
            rep(b, "some scruples at least...)", "au moins quelques scrupules...)");
            rep(b, "Oh dear... ", "Oh là là... ");
            rep(b, "It looks like she's not interested in talking to us.", "On dirait qu'elle n'a pas du tout envie de nous parler.");
            rep(b, "For the time being, ", "Pour l'instant, ");
            rep(b, "anyway.", "du moins.");
            rep(b, "(For the time being? ", "(Pour l'instant ? ");
            rep(b, "You mean... ", "Vous voulez dire... ");
            rep(b, "until we die? ", "jusqu'à ce qu'on meure ? ");
            rep(b, "I hope that's a way off...)", "J'espère que ce n'est pas pour tout de suite...)");
            rep(b, "Sorry, ", "Pardonnez-moi, ");
            rep(b, "but... ", "mais... ");
            rep(b, "I wasn't planning on dying any time soon.", "je n'avais pas prévu de passer l'arme à gauche de sitôt.");
            rep(b, "Tsk.", "Tss.");
            rep(b, "(Surely there's some less drastic way of making her\r\nlisten...)", "(Il doit sûrement y avoir une méthode moins radicale pour capter son attention...)");
        });

        // Key 117
        addKey(@"BB\script\output\_sce03_chr106_01_eng#2", b => {
            rep(b, "So... ", "Alors... ");
            rep(b, "why doesn't this autopsy report include the victim's\r\ntime of death then?", "pourquoi ce rapport d'autopsie n'indique-t-il pas l'heure du décès de la victime ?");
            rep(b, "It's really the most crucial detail.", "C'est pourtant le détail le plus crucial.");
            rep(b, "I was told ", "On m'a ordonné ");
            rep(b, "not to write it.", "de ne pas la mentionner.");
            rep(b, "What?!", "Quoi ?!");
            rep(b, "By whom?", "Par qui donc ?");
            rep(b, "Mael Stronghart.", "Lord Harry Caine.");
            rep(b, " The Lord Chief Justice.", " Le Lord grand justicier.");
            rep(b, "He came here.", "Il est venu en personne.");
            rep(b, "Lord Stronghart came...?", "Lord Caine est venu... ?");
            rep(b, "He said that from the witness statements about the\r\ngunshot and the other evidence, ", "Il a affirmé qu'au vu des dépositions des témoins concernant le coup de feu et des autres indices, ");
            rep(b, "it was obvious.", "c'était limpide.");
            rep(b, "The man clearly died at 5 p.m. on 1st November,", "L'homme a manifestement péri le 1er novembre à 17 heures,");
            rep(b, " when\r\nthe gunshot was heard.", " lorsque\r\nla détonation a retenti.");
            rep(b, "But that's not the time of death you wrote on the report.", "Mais ce n'est pas l'heure de la mort que vous avez inscrite sur le rapport.");
            rep(b, "You didn't write anything.", "Vous n'avez absolument rien inscrit.");
            rep(b, "Was there... ", "Y avait-il... ");
            rep(b, "some ", "une ");
            rep(b, "reason you didn't include it", "raison pour laquelle vous ne l'avez pas mise");
            rep(b, "?!", " ?!");
            rep(b, "Dr Gorey...", "Mademoiselle Pétrie...");
            rep(b, "...if you're hiding something under Lord Stronghart's\r\ninstructions...", "... si vous dissimulez quoi que ce soit sur les ordres de Lord Caine...");
            rep(b, "...then sooner or later ", "... tôt ou tard, ");
            rep(b, "you're going to go the same way as\r\nyour mother.", "vous allez finir par suivre le même chemin que votre mère.");
            rep(b, "Give it here then.", "Donnez-moi ça, alors.");
            rep(b, "Hm?", "Hein ?");
            rep(b, "(What's she scribbling so furiously?)", "(Qu'est-ce qu'elle gribouille avec une telle frénésie ?)");
            rep(b, "There.", "Voilà.");
            rep(b, "You've, ", "Vous, ");
            rep(b, "you've written...", "vous avez écrit...");
            rep(b, "What?!", "Quoi ?!");
            rep(b, "What's she written?", "Qu'est-ce qu'elle a écrit ?");
            rep(b, "Tell us!", "Dis-le-nous !");
            rep(b, "‘", "« ");
            rep(b, "Indeterminate", "Indéterminée");
            rep(b, "’.", " ».");
            rep(b, "But...", "Mais...");
            rep(b, "The details of the autopsy report\r\nhave been updated in the Court Record.", "Les détails du rapport d'autopsie\r\nont été mis à jour dans le dossier de l'affaire.");
        });

        // Key 118
        addKey(@"BB\script\output\_sce03_chr106_01_eng#3", b => {
            rep(b, "What do you mean by that?", "Qu'entendez-vous par là ?");
            rep(b, "Why was the time of death ", "Pourquoi l'heure de la mort était-elle ");
            rep(b, "indeterminate", "indéterminée");
            rep(b, "?", " ?");
            rep(b, "When the specimen was brought in, ", "Lorsque le spécimen a été apporté, ");
            rep(b, "it was still fresh.", "il était encore frais.");
            rep(b, "So the time of death could easily have coincided with\r\nwhen the gunshot was heard.", "Donc l'heure du décès pouvait facilement concorder avec le moment où la détonation a retenti.");
            rep(b, "there was one small discrepancy.", "il y avait une légère anomalie.");
            rep(b, "What ", "Quelle ");
            rep(b, "discrepancy", "anomalie");
            rep(b, "There was some fried fish in the pocket of the specimen's\r\novercoat.", "Il y avait du poisson frit dans la poche du pardessus du spécimen.");
            rep(b, "And that fish...", "Et ce poisson...");
            rep(b, "had started to rot.", "avait commencé à pourrir.");
            rep(b, "If the victim liked fried fish, ", "Si la victime appréciait le poisson frit, ");
            rep(b, "he presumably liked to eat it\r\nbefore it went off.", "il préférait sans doute le consommer avant qu'il ne se gâte.");
            rep(b, "What are you really trying to say?", "Où voulez-vous en venir au juste ?");
            rep(b, "It's possible that someone tried to ", "Il est envisageable que quelqu'un ait tenté de ");
            rep(b, "manipulate", "manipuler");
            rep(b, " the apparent\r\ntime of death.", " l'heure apparente de la mort.");
            rep(b, "Manipulate the...?", "Manipuler l'heure du... ?");
            rep(b, "Is that even possible to do?", "Est-ce seulement réalisable ?");
            rep(b, "Theoretically, ", "Théoriquement, ");
            rep(b, "if you were to chill the body in ice,", "si l'on plongeait le corps dans la glace,");
            rep(b, " you\r\ncould ", " on\r\npourrait ");
            rep(b, "delay", "retarder");
            rep(b, " the onset of putrefaction.", " le début de la putréfaction.");
            rep(b, "And if the overcoat ", "Et si le pardessus ");
            rep(b, "wasn't on the body", "n'était pas sur la dépouille");
            rep(b, " at the time...", " à ce moment-là...");
            rep(b, "...Then only the fish would have started to rot!", "... Alors seul le poisson aurait commencé à se décomposer !");
            rep(b, "With today's science, ", "Dans l'état actuel de la science, ");
            rep(b, "it's not yet possible to determine if\r\nthe body was chilled or not.", "il n'est pas encore possible d'établir avec certitude si le corps a été réfrigéré ou non.");
            rep(b, "(But today's science is advanced enough to let you freeze\r\na corpse, ", "(Mais la science actuelle est apparemment assez avancée pour permettre de congeler un corps, ");
            rep(b, "it seems...)", "à ce qu'il paraît...)");
            rep(b, "But surely...", "Mais voyons...");
            rep(b, "...to chill a corpse like that would require an enormous\r\n", "... pour refroidir un cadavre de la sorte, il faudrait un colossal\r\n");
            rep(b, "electrical refrigerator", "réfrigérateur électrique");
            rep(b, "And I don't imagine many households in London ", "Et je n'imagine guère beaucoup de foyers à Londres ");
            rep(b, "are\r\nequipped with such a device.", "équipés d'un tel appareil.");
            rep(b, "definitely not.", "assurément pas.");
            rep(b, "But maybe in a factory?", "Mais peut-être dans une usine ?");
            rep(b, "Or some other special places?", "Ou dans d'autres endroits particuliers ?");
            rep(b, "I don't recall seeing any factories or suchlike on Fresno\r\nStreet, though.", "Je ne me souviens pas avoir aperçu d'usines ou de ce genre de bâtiments sur Fresno Street, pourtant.");
            rep(b, "if the inspector's body had been chilled\r\nsomehow...", "si le corps de l'inspecteur avait été réfrigéré d'une manière ou d'une autre...");
            rep(b, "...what might the actual time of death have been?", "... quelle aurait pu être la véritable heure de sa mort ?");
            rep(b, "I couldn't say for sure.", "Je ne saurais l'affirmer catégoriquement.");
            rep(b, "But at the most, ", "Mais au maximum, ");
            rep(b, "it might have been a day earlier.", "cela aurait pu être un jour plus tôt.");
            rep(b, "No!", "Ce n'est pas possible !");
            rep(b, "In other words, ", "En d'autres termes, ");
            rep(b, "it would ", "cela ");
            rep(b, "corroborate", "corroborerait");
            rep(b, " your previous\r\ndeduction, ", " votre précédente déduction, ");
            rep(b, "That Inspector Gregson was killed a day before his body\r\nwas discovered, ", "Que l'inspecteur Gregson a été tué la veille du jour où son corps a été découvert, ");
            rep(b, "at ", "dans ");
            rep(b, "a different location", "un lieu tout à fait différent");
            rep(b, "...Did you inform Lord Stronghart of this possibility?", "... Avez-vous informé Lord Caine de cette possibilité ?");
            rep(b, "He simply said ", "Il a simplement répondu ");
            rep(b, "that there were no electrical refrigerators\r\nof that size in the vicinity.", "qu'il n'existait aucun réfrigérateur électrique d'une telle taille dans les environs.");
        });

        // Key 119
        addKey(@"BB\script\output\_sce03_chr106_01_eng#5", b => {
            rep(b, "Erm...", "Euh...");
            rep(b, "could I ask your opinion about this?", "pourrais-je avoir votre avis là-dessus ?");
            rep(b, "Don't forget...", "N'oubliez pas...");
            rep(b, "...you're responsible for putting my mama in jail.", "... que c'est de votre faute si maman est en prison.");
            rep(b, "Why should I help you?", "Pourquoi devrais-je vous aider ?");
        });

        // Key 120
        addKey(@"BB\script\output\_sce03_chr106_01_eng#6", b => {
            rep(b, "Dr Gorey...", "Mademoiselle Pétrie...");
            rep(b, "we actually came here to ask you about this.", "nous sommes venus précisément pour vous interroger à ce sujet.");
            rep(b, "He was very good.", "Il était remarquable.");
            rep(b, "Good?", "Remarquable ?");
            rep(b, "Sorry?", "Pardon ?");
            rep(b, "His skin didn't snag my blade once.", "Sa peau n'a pas accroché ma lame une seule fois.");
            rep(b, "And very little mess.", "Et presque aucune bavure.");
            rep(b, "His joints dislocated easily ", "Ses articulations se sont déboîtées sans effort ");
            rep(b, "and his muscle tissue was a\r\npleasure to work with.", "et ses tissus musculaires ont été un pur délice à inciser.");
            rep(b, "W-", "N-");
            rep(b, "We can skip those details!", "Nous pouvons nous passer de ces détails !");
            rep(b, "But...", "Mais...");
            rep(b, "there is one thing about the report that's caught my\r\nattention.", "il y a une chose sur ce rapport qui a attiré mon attention.");
            rep(b, "You don't seem to have recorded ", "Vous ne semblez pas avoir consigné ");
            rep(b, "a time of death", "l'heure du décès");
            rep(b, "!", " !");
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(@"tools\Trans_Ep4_Act2_Part3.cs", sb.ToString(), new UTF8Encoding(false));
        Console.WriteLine("Done generating tools\\Trans_Ep4_Act2_Part3.cs");
    }
}
