using System;
using System.IO;
using System.Text;

class MakeEp4Act2Part1 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act2 {");
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

        // [1] KEY:BB\script\output\_sce03_chr010_00_eng#1
        add(@"BB\script\output\_sce03_chr010_00_eng#1", new string[,] {
            { "Um, ", "Euh, " },
            { "Mr Sholmes...", "monsieur Holmes..." },
            { "who were the two gentlemen that were\r\nhere before?", "qui étaient ces deux messieurs qui se trouvaient\r\nici plus tôt ?" },
            { "Oh, ", "Oh, " },
            { "just a pair of petty criminals.", "juste une paire de petits malfrats." },
            { "Nothing of significance.", "Rien de bien important." },
            { "Of course, ", "Bien sûr, " },
            { "they have to make a living somehow.", "il leur faut bien gagner leur vie d'une façon ou d'une autre." },
            { "And when the mood takes me, ", "Et quand le cœur m'en dit, " },
            { "I'm willing to turn a blind\r\neye to all manner of infractions.", "je suis disposé à fermer les yeux\r\nsur toutes sortes d'infractions." },
            { "When the mood takes you?", "Quand le cœur vous en dit ?" },
            { "All manner of infractions?!", "Toutes sortes d'infractions ?!" },
            { "when such fellows set their sights on Mr Herlock\r\nSholmes, ", "lorsque ces individus jettent leur dévolu sur M. Sherlock\r\nHolmes, " },
            { "well", "eh bien" },
            { "that's when their luck runs out.", "c'est là que leur chance tourne." },
            { "Oh my!", "Bonté divine !" },
            { "You were the target of a crime, ", "Vous avez été la cible d'un crime, " },
            { "Mr Sholmes?", "monsieur Holmes ?" },
            { "But I quickly devised a plan to entrap them and deliver\r\nthem to our young detective ally.", "Mais j'ai promptement ourdi un plan pour les piéger et les\r\nlivrer à notre jeune alliée enquêtrice." },
            { "You should have asked Gregsy to come, too.", "Tu aurais dû inviter Gregounet aussi." },
            { "We could have had an arresting tea party.", "Nous aurions pu prendre le thé en faisant des arrestations." },
            { "I did send word, ", "Je l'ai fait quérir, " },
            { "but no answer was forthcoming.", "mais aucune réponse ne m'est parvenue." },
            { "The man is consummately in the wrong place at the\r\nwrong time.", "Cet homme est irrémédiablement au mauvais endroit au\r\nmauvais moment." },
            { "There's a word for it, ", "Il existe un mot pour désigner cela, " },
            { "I'm sure...", "j'en suis certain..." },
            { "Aha, ", "Aha, " },
            { "I have it!", "je l'ai !" },
            { "A ‘bungler’.", "Un « gaffeur »." },
            { "That's the word.", "C'est bien le mot." },
            { "...It's a good job he's not here to hear you say that.", "...C'est une bonne chose qu'il ne soit pas là pour l'entendre." },
            { "(So those red-heads had been up to no good...?)", "(Ces rouquins préparaient donc un mauvais coup...?)" },
            { "I wonder what the men did...", "Je me demande ce qu'ils ont fait..." }
        });

        // [2] KEY:BB\script\output\_sce03_chr010_00_eng#2
        add(@"BB\script\output\_sce03_chr010_00_eng#2", new string[,] {
            { "Um...", "Euh..." },
            { "what was that about ‘the greatest of problems known\r\nto man’ that you mentioned before?", "c'était quoi cette histoire de « plus grand fléau de\r\nl'humanité » que vous mentionniez plus tôt ?" },
            { "Is it ", "S'agirait-il " },
            { "another ", "d'une nouvelle " },
            { "fiendishly intricate case", "affaire diaboliquement complexe" },
            { "Hm, ", "Hum, " },
            { "how should I best explain it?", "comment vous l'expliquer au mieux ?" },
            { "Are you aware of ", "Avez-vous déjà entendu parler de " },
            { "the theory of evolution", "la théorie de l'évolution" },
            { "by natural\r\nselection, ", "par sélection\r\nnaturelle, " },
            { "perchance?", "par hasard ?" },
            { "well...", "eh bien..." },
            { "I think I've heard talk of it somewhere...", "je crois en avoir entendu parler quelque part..." },
            { "possibly.", "sans doute." },
            { "It's a revolutionary scientific theory that was newly\r\nproposed forty years ago now.", "C'est une théorie scientifique révolutionnaire proposée il y a\r\nquarante ans de cela." },
            { "According to its author, ", "D'après son auteur, " },
            { "Mr Darwin, ", "M. Darwin, " },
            { "we humans were\r\nonce apes who lived in the treetops.", "nous autres humains étions jadis des\r\nsinges sautillant à la cime des arbres." },
            { "Wait, ", "Attendez, " },
            { "what?!", "quoi ?!" },
            { "We, ", "Nous, " },
            { "we were apes?", "nous étions des singes ?" },
            { "Indeed.", "Tout à fait." },
            { "And from the very moment those apes descended\r\nfrom the canopy to live as humans...", "Et dès l'instant précis où ces primates sont descendus de leur\r\ncanopée pour vivre comme des humains..." },
            { "...it has been our lot to be at the mercy of the greatest\r\nproblem known to man.", "...notre triste sort a été d'être à la merci du plus grand\r\nproblème de l'humanité." },
            { "Our lot...?", "Notre sort... ?" },
            { "What is this great problem, ", "Quel est donc ce grand problème, " },
            { "Why, ", "Mais enfin, " },
            { "is it not obvious, ", "n'est-ce point évident, " },
            { "my dear madam?", "ma chère demoiselle ?" },
            { "The problem of ", "Le problème du " },
            { "rent", "loyer" },
            { "...Haah.", "...Pffou." },
            { "But...", "Mais..." },
            { "did you not receive a rather large sum of money\r\nfrom Madame Tusspells only the other day?", "n'avez-vous point perçu une somme rondelette de\r\nMadame Pétrie pas plus tard que l'autre jour ?" },
            { "Pshaw!", "Pfff !" },
            { "A large sum?", "Une somme rondelette ?" },
            { "One potted herb for Iris and a new motor car for me later,", "Une herbe en pot pour Iris et une nouvelle automobile pour moi plus tard," },
            { "and all of it has quite disappeared, ", "et tout cela s'est complètement évaporé, " },
            { "I assure you.", "je vous l'assure." },
            { "Honestly, ", "Franchement, " },
            { "Hurley!", "Sherlockinou !" },
            { "You know you squandered it.", "Tu sais bien que tu as tout dilapidé." },
            { "Yes, ", "Oui, " },
            { "well, anyway...", "enfin, peu importe..." },
            { "two days ago...", "il y a deux jours..." },
            { "...I discovered the answer to man's greatest problem!", "...j'ai découvert la solution au plus grand fléau de l'humanité !" },
            { "For the coming month at least.", "Pour le mois à venir, tout du moins." },
            { "And what was the answer?", "Et quelle était cette solution ?" },
            { "Why", "Eh bien" },
            { "there is a substantial clue ", "il se trouve un indice révélateur " },
            { "before your very eyes", "juste sous vos yeux" },
            { "Don't tell me!", "Ne me dites rien !" },
            { "Let me see...", "Laissez-moi regarder..." },
            { "Humans are sorry creatures, ", "Les humains sont de piètres créatures, " },
            { "unable to see what is in\r\nfront of their noses.", "incapables de voir ce qui se trouve\r\nsous leur nez." },
            { "Let me give you some assistance.", "Laissez-moi vous donner un coup de main." },
            { "Don't look, ", "Ne regardez point, " },
            { "but observe me very closely.", "mais observez-moi avec attention." },
            { "There is one particular feature about my person that has\r\nchanged.", "Un détail très particulier de ma personne s'est trouvé\r\nmétamorphosé." },
            { "You should notice it in the end, I think...", "Vous devriez finir par le remarquer, je pense..." },
            { "(In the end?)", "(Finir par le remarquer ?)" },
            { "(It's been ", "(Cela me " },
            { "stabbing me in both eyes", "crève littéralement les yeux" },
            { "right from the very\r\nbeginning of our conversation!)", "depuis le tout début de notre conversation !)" },
            { "I think we might need ", "Je crains que nous n'ayons besoin " },
            { "clue", "indice" },
            { "before we uncover\r\nthe full answer, ", "avant d'élucider toute\r\nl'énigme, " },
            { "Mr Naruhodo.", "monsieur Naruhodo." },
            { "...Thanks for the hint.", "...Merci pour le tuyau." },
            { "I'll be tearing my hair out if this\r\ncharade goes on much longer.", "Je vais finir par m'arracher les cheveux si cette\r\nmascarade dure plus longtemps." }
        });

        // [3] KEY:BB\script\output\_sce03_chr010_00_eng#3
        add(@"BB\script\output\_sce03_chr010_00_eng#3", new string[,] {
            { "What did you actually do to your hair, ", "Qu'avez-vous donc fait à vos cheveux, " },
            { "I'm glad you asked, ", "Je suis ravi que vous le demandiez, " },
            { "Miss Susato.", "mademoiselle Susato." },
            { "What you see atop my\r\nhead is neither dyed nor a hairpiece.", "Ce que vous contemplez sur ma\r\ntête n'est ni teinture, ni postiche." },
            { "I changed the colour of my hair overnight...", "J'ai changé la couleur de mes cheveux en une nuit..." },
            { "by ", "grâce aux " },
            { "the\r\nwonders of chemistry", "merveilles de la chimie" },
            { "Chemistry?!", "La chimie ?!" },
            { "I was conducting some research into a method of\r\nrejuvenating spent tea leaves.", "Je menais des recherches sur une méthode pour\r\nrégénérer les feuilles de thé usagées." },
            { "And in the course of my work, ", "Et au cours de mes travaux, " },
            { "I stumbled upon a potion\r\nthat when taken, ", "je suis tombé par hasard sur une potion\r\nqui, une fois ingérée, " },
            { "turns one's hair ", "donne aux cheveux " },
            { "a flame-like red", "un roux flamboyant" },
            { "Would you like to try it?", "Aimeriez-vous l'essayer ?" },
            { "It will make every hair on your\r\nbody perfectly ", "Cela teintera chaque poil de votre\r\ncorps d'un superbe " },
            { "crimson", "carmin" },
            { "...I think I'll pass.", "...Je passe mon tour." },
            { "But Mr Sholmes, ", "Mais monsieur Holmes, " },
            { "is it quite safe to drink?", "est-ce bien sans danger d'avaler cela ?" },
            { "Surely it's bad for you, ", "C'est sûrement nocif pour la santé, " },
            { "isn't it?", "non ?" },
            { "Heh ", "Hé " },
            { "heh ", "hé " },
            { "heh...", "hé..." },
            { "Ah, ", "Ah, " },
            { "amateurs are always hampered by such fears.", "les profanes sont toujours freinés par de telles craintes." },
            { "Oh!", "Oh !" },
            { "I should never have doubted you, Mr Sholmes!", "Je n'aurais jamais dû douter de vous, monsieur Holmes !" },
            { "You mean to say...?", "Vous voulez dire que... ?" },
            { "But of course!", "Mais bien entendu !" },
            { "To earn four pounds per week, ", "Pour empocher quatre livres sterling par semaine, " },
            { "one must be prepared to\r\nturn a blind eye to a little danger.", "il faut savoir fermer les yeux face à un soupçon de danger." },
            { "(...That degree of red signals more than just a ‘little’\r\ndanger, ", "(...Un roux aussi criard signale bien plus qu'un « soupçon »\r\nde danger, " },
            { "surely.)", "à n'en pas douter.)" },
            { "So anyway, ", "Toujours est-il que, " },
            { "Hurley left full of confidence yesterday with\r\nhis new red hair...", "Sherlockinou est parti hier plein d'entrain avec\r\nsa nouvelle chevelure rousse..." },
            { "...for the park on Lime Street where the Red-Headed\r\nLeague were interviewing prospective new members.", "...pour le parc de Lime Street, où la Ligue des Rouquins\r\nfaisait passer des entretiens aux nouveaux candidats." },
            { "So what went wrong?", "Qu'est-ce qui a cloché alors ?" },
            { "The whole park was choked with red-headed folk,", "Le parc entier était noir de têtes rousses," },
            { "like a\r\ncoster's orange barrow.", "tel un étal d'oranges chez un marchand ambulant." },
            { "I queued for eight hours solid before at last,", "J'ai fait la queue pendant huit heures d'affilée avant enfin," },
            { "I reached the\r\nfront.", "d'arriver en tête de file." },
            { "But when the panel of interviewers saw me,", "Mais lorsque le jury m'a aperçu," },
            { "they\r\nimmediately said:", "ils se sont aussitôt écriés :" },
            { "‘Ah, ", "« Ah, " },
            { "Mr Herlock Sholmes!", "monsieur Sherlock Holmes ! " },
            { "Are you in disguise to conduct\r\nan investigation?’", "Êtes-vous déguisé pour mener\r\nune enquête ? »" },
            { "So naturally ", "Alors naturellement, " },
            { "I had no choice but to reply:", "je n'ai eu d'autre choix que de répondre :" },
            { "‘Shh!", "« Chut ! " },
            { "Don't give me away!’", "Ne me trahissez pas ! »" },
            { "After which, ", "Après quoi, " },
            { "I could do little else but turn and leave.", "je n'ai eu guère d'autre recours que de tourner les talons." },
            { "Then this morning!", "Et ce matin ! " },
            { "When I looked in the mirror,", "En me regardant dans le miroir," },
            { "irritation\r\nstirred within me.", "l'agacement m'a\r\nenvahi." },
            { "So I turned that pair in to the police.", "J'ai donc livré ces deux compères à la police." },
            { "Oh dear, ", "Oh là là, " },
            { "what a disaster.", "quel désastre." },
            { "For Hurley and those two red-heads.", "Pour Sherlockinou et ces deux rouquins." }
        });

        // [4] KEY:BB\script\output\_sce03_chr010_00_eng#4
        add(@"BB\script\output\_sce03_chr010_00_eng#4", new string[,] {
            { "Mr Sholmes, ", "Monsieur Holmes, " },
            { "isn't it about time you told us the truth?", "ne serait-il pas temps de nous dire la vérité ?" },
            { "Just over a week ago, ", "Il y a un peu plus d'une semaine, " },
            { "you said to us:", "vous nous disiez :" },
            { "I will now tell you something", "Je vais maintenant vous révéler une chose" },
            { "of the first importance, my\r\ndear fellow:", "de la plus haute importance, mon cher ami :" },
            { "Great detectives", "Les grands détectives" },
            { "are wont to lie.", "sont enclins à mentir." },
            { "...It will serve you well to remember that.", "...Il vous sera utile de vous en souvenir." },
            { "That case aboard the SS Burya in January...", "Cette affaire à bord du SS Burya en janvier..." },
            { "Kazuma wasn't killed.", "Kazuma n'avait pas été tué." },
            { "And you knew he wasn't dead at the time.", "Et vous saviez à ce moment-là qu'il n'était pas mort." },
            { "So what was really going on?", "Alors que se tramait-il réellement ?" },
            { "The fellow was unconscious for a very long time.", "Le pauvre bougre est resté inconscient fort longtemps." },
            { "If he hadn't regained consciousness when he did,", "S'il n'avait pas repris connaissance au moment où il l'a fait," },
            { "his life\r\nwould have been in mortal peril.", "sa vie\r\naurait été en péril de mort." },
            { "Of course, ", "Bien sûr, " },
            { "a side-effect of the prolonged comatose state\r\nwas ", "un effet secondaire de ce coma prolongé\r\nne fut autre que l'", },
            { "amnesia", "amnésie" },
            { ", as you now know.", ", comme vous le savez désormais." },
            { "It was a simple enough task to silence the crew.", "Faire taire l'équipage s'est avéré un jeu d'enfant." },
            { "But how...?", "Mais comment... ?" },
            { "After they'd carried him out of the cabin, ", "Après qu'ils l'eurent transporté hors de la cabine, " },
            { "I assembled\r\nthem in the lobby area.", "je les ai\r\nréunis dans le vestibule." },
            { "Then I made them swear...", "Puis je leur ai fait prêter serment..." },
            { "...to leave him unconscious and have him unlade from\r\nthe ship in Hong Kong ", "...de le maintenir inconscient et de le faire débarquer\r\ndu navire à Hong Kong " },
            { "as ", "comme " },
            { "a murdered corpse", "un cadavre assassiné" },
            { "Oh, ", "Oh, " },
            { "how horrible...", "quelle horreur..." },
            { "It was necessary to find some material with which to\r\npersuade the crewmen to keep their word, ", "Il fut nécessaire de trouver des arguments pour persuader\r\nles matelots de tenir parole, " },
            { "of course.", "naturellement." },
            { "But why?!", "Mais pourquoi ?!" },
            { "Why do it ", "Pourquoi faire cela " },
            { "in the first place?", "au départ ?" },
            { "I will be at liberty to elaborate in due course.", "Je serai libre de vous en dire plus en temps voulu." },
            { "But for the time being, ", "Mais pour l'heure, " },
            { "I would like to reassure you:", "j'aimerais vous rassurer :" },
            { "I didn't foresee subsequent events.", "je n'avais point prévu la suite des événements." },
            { "What events?", "Quels événements ?" },
            { "His disappearance in Hong Kong.", "Sa disparition à Hong Kong." },
            { "...I believe I may have made a gross error of judgement.", "...Je crois avoir commis une grossière erreur de jugement." },
            { "Mr Sholmes...", "Monsieur Holmes..." }
        });

        // [5] KEY:BB\script\output\_sce03_chr010_00_eng#5
        add(@"BB\script\output\_sce03_chr010_00_eng#5", new string[,] {
            { "So what is ", "Qu'est-ce donc que " },
            { "the Red-Headed League", "la Ligue des Rouquins" },
            { "which seems to be\r\nthe subject of the advertisement you've circled?", "qui semble faire\r\nl'objet de l'annonce que vous avez entourée ?" },
            { "You noticed it in the paper, then?", "Vous l'avez remarquée dans le journal, alors ?" },
            { "That, ", "Ceci, " },
            { "my dear fellow, ", "mon cher ami, " },
            { "was going to be the source of this\r\nmonth's rent payment!", "devait être le moyen de régler le\r\nloyer de ce mois-ci !" },
            { "It was?", "Vraiment ?" },
            { "How?", "Comment ?" },
            { "According to the advertisement...", "Selon les termes de l'annonce..." },
            { "...the Red-Headed League is a distinguished institution of\r\nfellows of unspecified governance.", "...la Ligue des Rouquins est une éminente confrérie d'hommes\r\naux statuts indéterminés." },
            { "In fact, ", "En vérité, " },
            { "the only condition for becoming a member...", "la seule et unique condition requise pour en être membre..." },
            { "is\r\nhaving red hair.", "est d'avoir\r\nles cheveux roux." },
            { "That...", "Cela..." },
            { "doesn't entirely surprise me.", "ne me surprend qu'à moitié." },
            { "But listen to what the lucky red-heads receive once they\r\njoin:", "Mais écoutez ce que perçoivent ces heureux rouquins une fois\r\nadmis :" },
            { "An unconditional salary of ", "Un traitement inconditionnel de " },
            { "four pounds", "quatre livres" },
            { " a week!", " par semaine !" },
            { "Four pounds a week?!", "Quatre livres par semaine ?!" },
            { "But why?", "Mais pourquoi ?" },
            { "What are they paying people for?", "Pourquoi rémunérer des gens pour ça ?" },
            { "That I don't know.", "C'est ce que j'ignore." },
            { "No details are given in the advertisement.", "Aucun détail n'est mentionné dans l'annonce." },
            { "But surely every red-headed person in the country\r\nwould be flocking to join in that case...", "Mais alors chaque personne rousse du pays\r\ndevrait s'y précipiter en foule dans ce cas..." },
            { "You're right, Susie.", "Tu as raison, Susette." },
            { "There's no time to lose!", "Il n'y a pas un instant à perdre !" },
            { "I'll put in my application at once!", "Je vais poser ma candidature sur-le-champ !" },
            { "So will I!", "Moi aussi !" },
            { "Just...on the off-chance.", "Juste... au cas où." },
            { "(That might be stretching a point, I think...)", "(C'est peut-être aller un peu loin, je pense...)" },
            { "The trouble is, ", "Le problème, " },
            { "they have a fixed number of members,", "c'est que le nombre de membres est strictement limité," },
            { "you see.", "voyez-vous." },
            { "Oh, I see.", "Oh, je vois." },
            { "So once a certain number of people have joined,no one else can.", "Une fois le quota atteint, plus personne ne peut entrer." },
            { "But as luck would have it, ", "Mais le hasard faisant bien les choses, " },
            { "one member recently passed\r\naway!", "l'un des membres est récemment passé\r\nde vie à trépas !" },
            { "It wasn't particularly lucky for the red-head in question,\r\nI feel, ", "Ce n'est pas particulièrement une chance pour le défunt,\r\nj'ai l'impression, " },
            { "...So you decided to try to join in his place?", "...Vous avez donc décidé de postuler à sa place ?" },
            { "Correct.", "Exactement." },
            { "I mean, look at me!", "Je veux dire, regardez-moi !" },
            { "Have you ever seen such a red-headed fellow?", "Avez-vous jamais contemplé individu aussi flamboyant ?" },
            { "Um...no.", "Euh... non." },
            { "So why?", "Alors pourquoi ?" },
            { "WHY did it have to go so wrong?!", "POURQUOI a-t-il fallu que cela tourne si mal ?!" },
            { "What, what on earth happened?", "Mais que s'est-il passé au juste ?" },
            { "A blunder, ", "Une bévue, " },
            { "Though it pains me to admit it.", "Bien qu'il m'en coûte de le reconnaître." }
        });

        // [6] KEY:BB\script\output\_sce03_chr010_00_eng#7
        add(@"BB\script\output\_sce03_chr010_00_eng#7", new string[,] {
            { "Um, Mr Sholmes, about this...", "Euh, monsieur Holmes, à ce propos..." },
            { "My dear fellow, without wishing to sound rude...", "Mon cher ami, sans vouloir paraître discourtois..." },
            { "...I'm currently in the middle of a very important blink.", "...je suis en train d'exécuter un clignement d'yeux capital." },
            { "Perhaps some other, more convenient time, hm?", "Peut-être à un moment plus opportun, n'est-ce pas ?" },
            { "...Is there a set time for your ‘important’ blinks, or are\r\nthey an all-day affair? Just so I know...", "...Y a-t-il un horaire précis pour vos clignements « capitaux », ou\r\nest-ce toute la journée ? C'est juste pour savoir..." }
        });

        // [7] KEY:BB\script\output\_sce03_chr010_00_eng#8
        add(@"BB\script\output\_sce03_chr010_00_eng#8", new string[,] {
            { "It looks as though someone's circled an advertisement in\r\nthis paper, ", "On dirait que quelqu'un a entouré une annonce dans\r\nce journal, " },
            { "‘To the Red-Headed League’?", "« À la Ligue des Rouquins » ?" },
            { "Does that strike you in some way?", "Cela éveille-t-il en vous un écho ?" },
            { "I was thinking that just maybe...it might be related.", "Je me disais que peut-être... cela pouvait avoir un lien." },
            { "To your bright-red hair.", "Avec vos cheveux d'un rouge écarlate." },
            { "So, at last you've learnt to apply my methods,\r\nMr Naruhodo!", "Ainsi, vous avez enfin appris à appliquer mes méthodes,\r\nmonsieur Naruhodo !" },
            { "Sorry?", "Pardon ?" },
            { "In the first instance, and quite indispensable...\r\nobservation!", "En tout premier lieu, et absolument indispensable...\r\nl'observation !" },
            { "Believe me, I could have seen that hair with my eyes\r\nshut.", "Croyez-moi, j'aurais remarqué cette chevelure même les yeux\r\nfermés." },
            { "So then! Allow me to regale you with the details of my\r\nlatest exploits.", "Dès lors ! Permettez-moi de vous régaler des détails de mes\r\nderniers exploits." },
            { "(‘Regale’ or ‘boast’...?)", "(« Régaler » ou « vous vanter »...?)" }
        });

        // [8] KEY:BB\script\output\_sce03_chr010_00_eng#9
        add(@"BB\script\output\_sce03_chr010_00_eng#9", new string[,] {
            { "‘To the Red-Headed League’... The advertisement\r\ncertainly draws one's attention, wouldn't you agree?", "« À la Ligue des Rouquins »... Cette annonce\r\nattire indiscutablement l'œil, n'êtes-vous point d'accord ?" },
            { "It does. Although the best I could do to fit in would be\r\nsome lipstick, I think.", "En effet. Mais le mieux que je puisse faire pour y entrer serait\r\nde mettre du rouge à lèvres, je crois." },
            { "You should partake yourself, Mr Naruhodo!", "Vous devriez y prendre part vous-même, monsieur Naruhodo !" },
            { "‘To the Caught Red-Handed League’...\r\nWhat do you think?", "« À la Ligue des Pris la Main dans le Sac »...\r\nQu'en dites-vous ?" },
            { "As a defence lawyer, it could be an excellent way to net\r\nmore clients.", "En tant qu'avocat de la défense, cela pourrait être une excellente\r\nmanière d'appâter de nouveaux clients." },
            { "Yeees...I can think of two problems.", "Ouiii... je vois deux inconvénients majeurs." },
            { "Oh? Pray tell...", "Ah ? Dites toujours..." },
            { "Well firstly, all of these new clients would therefore be\r\ncriminals.", "Eh bien d'abord, tous ces nouveaux clients seraient donc des\r\ncriminels." },
            { "And secondly, I would have to pay each of them four\r\npounds a week.", "Et ensuite, il me faudrait verser à chacun quatre\r\nlivres par semaine." },
            { "Well, one gets nothing for free in this life, Mr Naruhodo.\r\nYou should know that!", "Eh bien, on n'a rien pour rien en ce bas monde, monsieur Naruhodo.\r\nVous devriez le savoir !" }
        });

        // [9] KEY:BB\script\output\_sce03_chr010_00_eng#10
        add(@"BB\script\output\_sce03_chr010_00_eng#10", new string[,] {
            { "Erm, Mr Sholmes, about this...", "Euh, monsieur Holmes, à propos de ceci..." },
            { "...Tell me, Mr Naruhodo. Is this the first time you've\r\nshown me this particular trinket?", "...Dites-moi, monsieur Naruhodo. Est-ce la première fois que\r\nvous me présentez cette babiole en particulier ?" },
            { "Oh! Um...I don't really remember, to be honest.", "Oh ! Euh... je ne m'en souviens guère, à vrai dire." },
            { "If my saying that it's a collar for a breed of miniature\r\ncanine with a particularly long neck...", "Si le fait que j'affirme qu'il s'agit d'un collier pour une race\r\nde canidé miniature au cou particulièrement allongé..." },
            { "...were to precipitate a ‘here we go again’ from your lips,\r\nwe could be sure it was not the first time.", "...devait déclencher un « c'est reparti pour un tour » de votre bouche,\r\nnous aurions l'absolue certitude que ce n'est pas la première fois." },
            { "Deduction, you see, my dear fellow.\r\nDeduction!", "La déduction, voyez-vous, mon cher ami.\r\nLa déduction !" }
        });

        // [10] KEY:BB\script\output\_sce03_chr010_01_eng#1
        add(@"BB\script\output\_sce03_chr010_01_eng#1", new string[,] {
            { "So...this autopsy report was actually penned by Professor\r\nMikotoba then?", "Ainsi... ce rapport d'autopsie a en réalité été rédigé de la\r\nmain du professeur Mikotoba ?" },
            { "But that makes no sense!\r\nIt's not possible, surely?", "Mais cela n'a aucun sens !\r\nCe n'est pas possible, voyons ?" },
            { "Not possible? My dear fellow!\r\nPray, take a deep breath and think again.", "Pas possible ? Mon cher ami !\r\nDe grâce, respirez un grand coup et réfléchissez." },
            { "Yes, you're right.\r\nIn some ways...", "Oui, vous avez raison.\r\nD'un certain côté..." },
            { "...it actually makes a great deal of sense.", "...cela a au contraire tout son sens." },
            { "It, it does?", "C-C'est vrai ?" },
            { "Ten years ago...is when Father returned to Japan after his\r\nextended study tour in Britain.", "Il y a dix ans... c'est à ce moment que Père est rentré au Japon\r\naprès son long séjour d'études en Grande-Bretagne." },
            { "And prior to his return, where was Dr Mikotoba engaged?", "Et avant son retour, où le Dr Mikotoba officiait-il ?" },
            { "Ah, of course!", "Ah, bien sûr !" },
            { "He was an assistant in Dr Wilson's laboratory, learning\r\nabout forensic science.", "Il était assistant dans le laboratoire du Dr Wilson, pour\r\nse former à la médecine légale." },
            { "And as an assistant, he would have aided with the\r\ndissection work, making detailed notes...", "Et en tant qu'assistant, il aidait aux dissections,\r\nen prenant des notes méticuleuses..." },
            { "...which would be assembled into the full autopsy report.", "...qui allaient être compilées pour former le rapport d'autopsie complet." },
            { "Once the work was complete, the head coroner would\r\ncheck the contents and put his signature on the document.", "Une fois la tâche accomplie, le médecin légiste en chef vérifiait\r\nle contenu et apposait sa signature sur le document." },
            { "In other words, the only writing of Dr Wilson's in the\r\nreport would be his signature at the end.", "En d'autres termes, les seules lignes de la main du Dr Wilson dans le\r\nrapport se résumaient à sa signature à la fin." },
            { "I see...", "Je vois..." },
            { "So Iris got the wrong end of the stick, you mean?", "Iris a donc mal interprété les choses, voulez-vous dire ?" },
            { "She saw that, and assumed the whole report had been\r\nwritten by Dr John H. Wilson.", "Elle a vu cela, et a supposé que le rapport entier avait été\r\nrédigé par le Dr John H. Wilson." },
            { "Which is very understandable, of course.", "Ce qui est parfaitement compréhensible, naturellement." },
            { "(What a complicated situation...)", "(Quelle situation inextricable...)" },
            { "The details of Klint's autopsy report\r\nhave been updated in the Court Record.", "Les détails du rapport d'autopsie de Klimt\r\nont été mis à jour dans le dossier de l'affaire." }
        });

        // [11] KEY:BB\script\output\_sce03_chr010_01_eng#3
        add(@"BB\script\output\_sce03_chr010_01_eng#3", new string[,] {
            { "Thinking about it...", "En y songeant bien..." },
            { "...most of what we know about you, Mr Sholmes, comes\r\nfrom the published stories of your exploits.", "...le gros de ce que nous savons de vous, monsieur Holmes, découle\r\ndes récits publiés de vos exploits." },
            { "Yes, ‘The Adventures of Herlock Sholmes’ written by Iris.", "Oui, « Les Aventures de Sherlock Holmes » écrites par Iris." },
            { "And we really have no way of knowing...", "Et nous n'avons aucun moyen réel de démêler..." },
            { "...what's fact and what's fiction.", "...ce qui relève du fait avéré et de la fiction." },
            { "Most troubling for you, my dear fellow, I'm sure.", "Fort déconcertant pour vous, mon cher ami, j'en conviens." },
            { "So what about this supposed partner of yours?\r\nDid he really exist or not?", "Mais qu'en est-il de votre soi-disant partenaire ?\r\nA-t-il vraiment existé ou pas ?" },
            { "Ah, you've come straight to the point, I see.", "Ah, vous allez droit au but, à ce que je vois." },
            { "...And please come straight to the answer!", "...Alors venez-en directement à la réponse, je vous prie !" },
            { "I believe Iris explained it in one of her instalments.", "Je crois qu'Iris l'a consigné dans l'une de ses publications." },
            { "He was a trusted comrade, and the only person I could\r\ntruly have called a friend.", "C'était un fidèle compagnon, et le seul être que j'eusse\r\npu véritablement qualifier d'ami." },
            { "And did this partner of yours truly make a record of all\r\nyour cases?", "Et cet associé a-t-il réellement consigné par écrit chacune\r\nde vos enquêtes ?" },
            { "Are his notes really stored inside that metal chest?", "Ses carnets sont-ils véritablement enfermés dans ce coffre en métal ?" },
            { "Absolutely, my dear madam. Absolutely.", "Parfaitement, ma chère demoiselle. Parfaitement." },
            { "So...where's your partner now?", "Alors... où se trouve-t-il aujourd'hui ?" },
            { "We rarely meet.\r\nYou see...he lives on the other side of the world.", "Nous nous voyons rarement.\r\nVoyez-vous... il vit de l'autre côté du globe." },
            { "But if this autopsy report and the records of all your old\r\ncases were penned by the same hand...", "Mais si ce rapport d'autopsie et les chroniques de vos anciennes\r\naffaires ont été rédigés de la même main..." },
            { "...and if the autopsy report was written – though not\r\nsigned – by your famous partner...", "...et si ce rapport d'autopsie a été rédigé – bien que non\r\nsigné – par votre illustre compagnon..." },
            { "...there would be only one logical conclusion.", "...il n'y aurait qu'une seule conclusion logique." },
            { "Pray, impress me.", "Je vous en prie, éblouissez-moi." },
            { "Your partner would have to be Yujin Mikotoba.\r\nIn other words...Miss Susato's father.", "Votre partenaire ne saurait être nul autre que Yujin Mikotoba.\r\nAutrement dit... le père de mademoiselle Susato." },
            { "'Pon my word, Mr Naruhodo...\r\nYes?", "Ma parole, monsieur Naruhodo...\r\nOui ?" },
            { "You are coming along wonderfully.\r\nYou have hit upon the method at last!", "Vous faites des progrès fulgurants.\r\nVous avez enfin percé le secret de la méthode !" },
            { "You've finally grasped the art of deduction!", "Vous maîtrisez enfin l'art de la déduction !" },
            { "You, you mean to say...?", "Vous... vous voulez dire que... ?" },
            { "Allow me to introduce you...\r\n...to my great friend and partner...Mikotoba.", "Permettez-moi de vous présenter...\r\n...mon grand ami et précieux associé... Mikotoba." },
            { "P-Professor Mikotoba!", "P-Professeur Mikotoba !" }
        });

        // [12] KEY:BB\script\output\_sce03_chr010_01_eng#4
        add(@"BB\script\output\_sce03_chr010_01_eng#4", new string[,] {
            { "Does, does this mean...\r\n...that you're the real Dr Wilson?!", "Est-ce... est-ce que cela veut dire...\r\n...que vous êtes le véritable Dr Wilson ?!" },
            { "No no no! My dear, I'm still my old self: Yujin Mikotoba,\r\nyour father!", "Non, non, non ! Ma chérie, je suis resté le même : Yujin Mikotoba,\r\nton père !" },
            { "Oh! Of, of course...", "Oh ! Bien, bien entendu..." },
            { "(This is obviously too much for Susato-san to take in.)", "(La révélation est visiblement trop lourde à digérer pour Susato.)" },
            { "I must say, though...\r\n...how my old friend has attained world-wide celebrity\r\nas a great mystery-solver is the greatest mystery of all!", "Il faut avouer tout de même...\r\n...que la renommée planétaire acquise par mon vieil ami\r\nen tant que grand détective reste le plus insondable des mystères !" },
            { "I still remember the first time we met...", "Je me souviens encore de notre toute première rencontre..." },
            { "Ah, pray remind me...when was it again, Mikotoba?", "Ah, rafraîchissez-moi la mémoire... quand était-ce déjà, Mikotoba ?" },
            { "Sixteen years ago, Sholmes.", "Il y a seize ans, Holmes." },
            { "Ah yes, quite! Sixteen years ago!", "Ah mais oui, parfaitement ! Seize années !" },
            { "I'd just arrived from Japan with Seishiro and Genshin.", "Je venais de débarquer du Japon avec Seishiro et Genshin." },
            { "I was in search of lodgings close to the hospital.\r\nSome comfortable rooms at a reasonable price.", "Je cherchais un logis à proximité de l'hôpital.\r\nQuelques pièces confortables à tarif abordable." },
            { "But rents are devilishly high in that particular area.", "Mais les loyers sont diaboliquement prohibitifs dans ce quartier précis." },
            { "That's right. So I decided I needed someone to share\r\nlodgings and the expense...", "Exact. J'ai donc conclu qu'il me fallait un colocataire\r\npour partager le toit et les frais..." },
            { "...and was fortunate enough to be introduced to Sholmes\r\nwho found himself in a similar situation.", "...et j'ai eu la bonne fortune d'être présenté à Holmes,\r\nqui se trouvait dans la même panade." },
            { "I was a callow fellow back then. A mere shadow of the\r\ngreat detective you see before you now.", "J'étais un jeune freluquet à cette époque. Une ombre falote comparé\r\nau grand détective qui se dresse devant vous aujourd'hui." },
            { "I was working at the hospital's chemical laboratory at the\r\ntime, indulging my curiosities for little gain.", "J'œuvrais alors au laboratoire de chimie de l'hôpital,\r\nsoumettant mes lubies scientifiques pour un maigre salaire." },
            { "And the situation of our cohabitation led to us pursuing\r\ncases together, you see.", "Et cette cohabitation nous amena naturellement à élucider\r\ndes affaires de concert, voyez-vous." },
            { "Hard to believe it was a mere six years.\r\nWe had a great many adventures.", "Difficile de croire que cela n'a duré que six courtes années.\r\nNous avons vécu tant d'aventures." },
            { "But in the last year of Mikotoba's stay in Britain, that most\r\ninfamous of cases presented itself.", "Mais durant la dernière année du séjour de Mikotoba en Grande-Bretagne,\r\nla plus funeste des affaires fit son apparition." },
            { "The case with which you've become rather familiar\r\nyourselves: the Professor killings.", "Cette affaire dont vous avez vous-mêmes appris les contours :\r\nles meurtres du Démon Assassin." },
            { "After the trial...Seishiro and I were summoned back home.", "Après le procès... Seishiro et moi avons été rappelés au pays." },
            { "Hardly surprising, given the circumstances.", "Guère étonnant, au vu des circonstances." },
            { "So there you have it.\r\nAnd as you know, all the details recorded by my trusty\r\nchronicler remain in that metal chest.", "Voilà toute l'histoire.\r\nEt comme vous le savez, chaque détail consigné par mon fidèle\r\nchroniqueur repose en sûreté dans ce coffre métallique." },
            { "(This is just amazing!)\r\n(Professor Mikotoba really IS Mr Sholmes's famous\r\npartner!)", "(C'est tout simplement prodigieux !)\r\n(Le professeur Mikotoba EST bel et bien l'illustre partenaire\r\nde monsieur Holmes !)" },
            { "Father.", "Père." },
            { "Goodness, my dear. What a cutting look!", "B-Bonté du ciel, ma fille. Quel regard glacial !" },
            { "As your daughter, I'm very proud to learn that you were\r\nthe great detective's great partner.", "En tant que fille, je suis infiniment fière d'apprendre que tu fus\r\nle grand associé de cet éminent détective." },
            { "But nevertheless...\r\n...there's another mystery that I really must ask you to\r\nexplain now.", "Il n'en demeure pas moins...\r\n...qu'il subsiste une autre énigme dont j'exige désormais\r\nl'explication." },
            { "And, and that is...?", "Et... et quelle est-elle... ?" },
            { "You know very well what it is.\r\nThe unresolved matter of Iris's father!", "Tu le sais pertinemment.\r\nLa question non résolue de l'identité du père d'Iris !" },
            { "Ah!\r\n(Of course! I'd almost forgotten about that one!)", "Ah !\r\n(Bien sûr ! J'avais presque fini par oublier ce détail-là !)" },
            { "I should have seen this coming, I suppose...", "J'aurais dû m'attendre à cette question, j'imagine..." }
        });

        // [13] KEY:BB\script\output\_sce03_chr010_01_eng#5
        add(@"BB\script\output\_sce03_chr010_01_eng#5", new string[,] {
            { "Iris told us...\r\n...that all the notes about the great detective's adventures\r\nthat are in that metal chest...\r\n...were written by her father.", "Iris nous a affirmé...\r\n...que tous les carnets sur les enquêtes du grand détective\r\nqui reposent dans ce coffre...\r\n...avaient été écrits par son père." },
            { "Isn't that correct, Mr Sholmes?", "N'est-ce point exact, monsieur Holmes ?" },
            { "That is indeed what I told young Iris.", "C'est en effet ce que j'ai conté à la petite Iris." },
            { "But if you're Mr Sholmes's partner, Father, and you wrote\r\nall those case notes...\r\n...then Iris's father...must be you!", "Mais si tu es le partenaire de M. Holmes, Père, et que tu as rédigé\r\ntous ces carnets d'enquêtes...\r\n...alors le père d'Iris... ce ne peut être que toi !" },
            { "'Pon my word, Miss Susato...\r\nYou are coming along wonderfully as well.\r\nYou, too, have hit upon the method at last!\r\nYou've finally grasped the art of deduction!", "Ma parole, mademoiselle Susato...\r\nVous faites vous aussi des merveilles.\r\nVous touchez enfin du doigt la méthode sacrée !\r\nVous avez assimilé l'art noble de la déduction !" },
            { "What you've always told me, Father...\r\n...is that my mother died when I was born sixteen years\r\nago.", "Ce que tu m'as toujours raconté, Père...\r\n...c'est que ma mère est morte en me mettant au monde il y a\r\nseize ans." },
            { "And you left me in Grandmother's care whilst you\r\nembarked on your study tour of Britain.\r\nAnd I've always accepted that.\r\nBut...\r\n...all this about Iris...", "Et que tu m'as confiée à Grand-mère pour partir\r\nen mission d'études en Grande-Bretagne.\r\nEt je l'ai toujours cru sans broncher.\r\nMais...\r\n...toute cette histoire au sujet d'Iris..." },
            { "(Ooh, there it is! Susato-san's ice-cold stare!)", "(Ouh là, le voilà ! Le regard noir et glacial de Susato !)" },
            { "No! Now hold on a minute!\r\nIt, it was very complicated.\r\nI mean! It's, it's really not what you think!", "Non ! Attends un instant !\r\nC'était... c'était bien plus complexe que cela.\r\nJe t'assure ! Ce n'est absolument pas ce que tu t'imagines !" },
            { "Then perhaps you'd like to explain exactly what it IS?", "Alors peut-être serais-tu ravi de nous expliquer ce qu'il EN EST ?" },
            { "(...There it is! Now the eyes go from ice-cold to red-hot,\r\njust before she...)", "(...On y est ! Ses yeux passent du gel polaire à la lave en fusion,\r\njuste avant qu'elle ne...)" },
            { "No really! You've, you've got the wrong end of the stick!\r\nSholmes! Say something, man!", "Non, je t'en conjure ! Tu fais fausse route !\r\nHolmes ! Dites quelque chose, par pitié !" }
        });

        // [14] KEY:BB\script\output\_sce03_chr030_00_eng#1
        add(@"BB\script\output\_sce03_chr030_00_eng#1", new string[,] {
            { "It's good news that Professor Mikotoba arrived safely, isn't\r\nit?", "C'est une excellente nouvelle que le professeur Mikotoba soit bien arrivé, n'est-ce pas ?" },
            { "Yes, it's wonderful. And the fact that Father has been\r\ninvited to this important international event...\r\n...really makes me very proud to be his daughter!", "Oui, c'est merveilleux. Et le fait qu'il ait été convié\r\nà cet événement international majeur...\r\n...me remplit de fierté d'être sa fille !" },
            { "Your father, Judge Jigoku, us.\r\n...And Kazuma, of course...", "Votre père, le juge Jigoku, nous-mêmes.\r\n...Et Kazuma, évidemment..." },
            { "There's an ever-increasing number of Japanese here in\r\nBritain's capital, isn't there?", "Il y a un contingent croissant de Japonais réunis dans la\r\ncapitale britannique, vous ne trouvez pas ?" },
            { "Well, yes, I suppose so.\r\nBut...London does have a population of six million people,\r\nso I think we're still a minority.", "Eh bien, oui, j'imagine.\r\nMais... Londres compte six millions d'âmes,\r\nnous restons donc une infime minorité." },
            { "(Susato-san's father who came here as a visiting student\r\nsixteen years ago, and Kazuma...)\r\n(It's almost as if some great power has been at work,\r\ndrawing them here across the ocean to London.)\r\n(And I feel as though the waters are starting to swell again\r\nnow...)", "(Le père de Susato venu en étudiant visiteur il y a seize ans,\r\net Kazuma...)\r\n(On dirait qu'une force mystérieuse a œuvré en coulisses pour\r\nles attirer ici par-delà les mers jusqu'à Londres.)\r\n(Et j'ai l'impression que la tempête se prépare de nouveau...)" }
        });

        // [15] KEY:BB\script\output\_sce03_chr030_00_eng#2
        add(@"BB\script\output\_sce03_chr030_00_eng#2", new string[,] {
            { "I can't believe it! Inspector Gregson!", "Je n'arrive pas à y croire ! L'inspecteur Gregson !" },
            { "It's awful, isn't it? But we must carry on.", "C'est effroyable, n'est-ce pas ? Mais nous devons tenir bon." },
            { "I know, but...it's just so much to take in.\r\nI don't know where to start.", "Je sais, mais... tout cela dépasse l'entendement.\r\nJe ne sais par où commencer." },
            { "We must start with a thorough investigation of the scene.\r\nAnd we must interview Gina.\r\nThen we must go to the prison to speak with the Reaper.", "Nous devons démarrer par une inspection rigoureuse des lieux.\r\nPuis interroger Gina.\r\nEnsuite, il nous faudra nous rendre au parloir pour parler au Faucheur." },
            { "...Thank goodness I have you, Miss Susato.\r\nYou have it all under control as usual.", "...Dieu merci, vous êtes là, mademoiselle Susato.\r\nVous maîtrisez la situation d'une main de maître, comme toujours." },
            { "You're too kind, Mr Naruhodo.\r\nBut I'm afraid I don't have all the answers.\r\nI really have no idea how to be around Iris at the moment.", "Vous êtes trop aimable, monsieur Naruhodo.\r\nMais je crains de ne point tout contrôler.\r\nJ'ignore totalement quelle attitude adopter avec Iris en ce moment." },
            { "(Oh yes...that.)", "(Ah oui... cette affaire-là.)" }
        });

        // [16] KEY:BB\script\output\_sce03_chr030_00_eng#4
        add(@"BB\script\output\_sce03_chr030_00_eng#4", new string[,] {
            { "Um, about this, Miss Susato.\r\nDo you notice anything unusual about it perhaps?", "Euh, à ce propos, mademoiselle Susato.\r\nRemarquez-vous quelque chose de particulier là-dessus ?" },
            { "I'm, I'm so sorry!\r\nI don't, no...", "Je... je suis navrée !\r\nNon, rien du tout..." },
            { "I'll redouble my efforts and spend more time doing\r\nresearch so that next time I won't let you down!", "Je redoublerai d'efforts et étudierai davantage\r\npour ne plus jamais vous décevoir la prochaine fois !" },
            { "(I think perhaps you're taking your role as judicial\r\nassistant a little too far...)", "(Je crois que vous prenez votre rôle d'assistante juridique\r\nun peu trop à cœur...)" }
        });

        // [17] KEY:BB\script\output\_sce03_chr030_00_eng#5
        add(@"BB\script\output\_sce03_chr030_00_eng#5", new string[,] {
            { "I stayed up late to mend that for you the other day,\r\nMr Naruhodo.", "J'ai veillé tard pour vous recoudre cela l'autre soir,\r\nmonsieur Naruhodo." },
            { "Thank you! You did a really seamless job.", "Merci infiniment ! Vos points de suture sont parfaits." },
            { "You're very welcome. It's all in a day's work for your\r\njudicial assistant.", "Tout le plaisir est pour moi. C'est le devoir naturel de votre\r\nassistante juridique." },
            { "The only thing is...I accidentally dropped it into the\r\nThames yesterday and now it...rather smells.", "Le seul souci, c'est que... je l'ai fait tomber dans la Tamise par\r\nmégarde hier et maintenant... il sent plutôt mauvais." },
            { "Then take better care of it, please.", "Alors prenez-en davantage soin, je vous prie." },
            { "(...It was all going so well...until I ruined it.)", "(...Tout se passait si bien... avant que je ne gâche tout.)" }
        });

        // [18] KEY:BB\script\output\_sce03_chr030_00_eng#6
        add(@"BB\script\output\_sce03_chr030_00_eng#6", new string[,] {
            { "The Red-Headed League... It's not something we could\r\never aspire to, is it?", "La Ligue des Rouquins... Nous ne pourrions jamais prétendre\r\ny postuler, n'est-ce pas ?" },
            { "But I'm determined to try!\r\n...Your hair is completely black, though.\r\nBeautiful, but black.", "Pourtant je suis résolue à tenter ma chance !\r\n...Vos cheveux sont pourtant d'un noir d'ébène.\r\nMagnifiques, certes, mais noirs." },
            { "Perhaps you know that in our homeland, this colour of\r\nhair has traditionally been described as green-black.", "Vous n'ignorez point que sur notre terre natale, cette teinte\r\nde chevelure est poétiquement décrite comme « noir-vert »." },
            { "...That sounds a lot like a contradiction if you ask me.", "...Cela m'a tout l'air d'un oxymore, si vous voulez mon avis." },
            { "So some people clearly see it as green in Japan, even\r\nthough it's black!\r\nIn which case, I'm full of hope something similar may\r\nhappen here in Britain!", "Ainsi certains y voient une touche de vert au Japon, quand\r\nbien même c'est noir !\r\nDès lors, j'ai tout lieu d'espérer qu'un tel miracle se produise ici en Grande-Bretagne !" },
            { "(That level of optimism is...something I should learn a\r\nlesson from.)", "(Un tel degré d'optimisme est... une leçon de vie dont je\r\nferais bien de m'inspirer.)" }
        });

        // [19] KEY:BB\script\output\_sce03_chr030_00_eng#7
        add(@"BB\script\output\_sce03_chr030_00_eng#7", new string[,] {
            { "This is the letter of introduction your father gave us.", "Voici la lettre de recommandation que votre père nous a remise." },
            { "Yes, he's clearly well respected if he's able to give out\r\nletters like that.", "Oui, sa notoriété est indéniable s'il est en mesure d'octroyer\r\nde pareilles missives." },
            { "Definitely. Professor Mikotoba is obviously held in high\r\nregard outside Japan as well as in.", "Assurément. Le professeur Mikotoba jouit d'un profond respect\r\naussi bien hors du Japon qu'en son sein." },
            { "I'm so proud of everything he's accomplished.", "Je suis si fière de tout ce qu'il a accompli." },
            { "A letter of introduction from me would only hold good\r\nwith Mr Natsume, I expect. And Iris, maybe.", "Une lettre de recommandation de ma main n'aurait de valeur\r\nqu'auprès de M. Natsume, j'imagine. Et d'Iris, peut-être." }
        });

        // [20] KEY:BB\script\output\_sce03_chr030_01_eng#1
        add(@"BB\script\output\_sce03_chr030_01_eng#1", new string[,] {
            { "Are you alright, Mr Naruhodo? It's rather unusual to find\r\nourselves here in the middle of our investigations...", "Tout va bien, monsieur Naruhodo ? Il est plutôt inhabituel\r\nde nous retrouver ici au beau milieu de nos investigations..." },
            { "It's, it's just occurred to me that I might have forgotten\r\nsomething when we left this morning.", "C'est que... je me suis soudain demandé si je n'avais rien oublié\r\nen partant ce matin." },
            { "Please don't worry. As long as you continue to investigate\r\nthoroughly, you won't go far wrong!", "Ne vous tourmentez point. Tant que vous menez l'enquête avec\r\nrigueur, vous ne commettrez point d'erreur !" },
            { "Oh! Yes, of course!\r\nI must get back to work as soon as possible!", "Oh ! Oui, bien sûr !\r\nJe dois me remettre à l'ouvrage sans tarder !" }
        });

        // [21] KEY:BB\script\output\_sce03_chr040_01_eng#1
        add(@"BB\script\output\_sce03_chr040_01_eng#1", new string[,] {
            { "So, how did it go in court this morning?", "Alors, comment cela s'est-il passé à l'audience ce matin ?" },
            { "Well, we still don't know the truth about what really\r\nhappened, but one thing's increasingly clear:\r\nLord van Zieks definitely didn't do it.", "Eh bien, la vérité sur les faits nous échappe encore,\r\nmais une chose se confirme d'heure en heure :\r\nLord Van Peers n'est absolument pas l'auteur du crime." },
            { "Oh, goodie!\r\nYes, that's right.\r\nWe managed to uncover several new facts as well!", "Oh, chouette !\r\nOui, c'est exact.\r\nNous avons mis au jour plusieurs éléments cruciaux !" },
            { "Oh! Really?\r\nAnd...there was another development, too.\r\n(Kazuma.)", "Oh ! Vraiment ?\r\nEt... il y a eu un autre rebondissement également.\r\n(Kazuma.)" },
            { "Yes, it's quite clear now...\r\n...that Kazuma-sama is not himself.", "Oui, il est désormais limpide...\r\n...que monsieur Kiyô n'est plus lui-même." },
            { "The way he's acting, it's almost as if he's...possessed.", "À voir son attitude, on le dirait presque... possédé." },
            { "I know. I mean, at the end of the proceedings earlier...\r\n...he was like a bloodhound the way he was chasing down\r\nMr Vigil's forgotten past.", "Je sais. Tout à l'heure, à la fin des débats...\r\n...il s'est jeté comme un limier sur le passé oublié de\r\nM. Vigil sans le moindre répit." },
            { "(He's not normally so mercilessly persistent.)\r\n(What's going on in his head, I wonder.)\r\n(I really need to sit down with Kazuma and try to\r\nunderstand what he's going through...)", "(Il n'est d'ordinaire jamais aussi impitoyable.)\r\n(Que peut-il bien se passer dans sa tête ?)\r\n(Il faut impérativement que je m'assoie avec Kazuma pour\r\ncomprendre ce qu'il traverse...)" }
        });

        // [22] KEY:BB\script\output\_sce03_chr040_01_eng#2
        add(@"BB\script\output\_sce03_chr040_01_eng#2", new string[,] {
            { "If Gregson was really murdered the day before his body\r\nwas discovered...\r\n...then Lord van Zieks has to be innocent, you see.", "Si Gregson a réellement été assassiné la veille de la découverte\r\nde sa dépouille...\r\n...alors Lord Van Peers est forcément innocent, voyez-vous." },
            { "What?! The day before?\r\nWell that should be easy enough to work out just by\r\nexamining the corpse, surely?", "Quoi ?! La veille ?\r\nMais cela devrait être un jeu d'enfant à déterminer par un simple\r\nexamen du corps, non ?" },
            { "Yes, you would expect so. But curiously...\r\n...no time of death was included in the autopsy report.", "Oui, c'est ce qu'on attendrait. Mais curieusement...\r\n...l'heure exacte du décès a été omise du rapport d'autopsie." },
            { "Hm, that is curious.", "Hum, voilà qui est singulier." },
            { "There are still unanswered questions about Lord van\r\nZieks, though, aren't there?", "Mais il subsiste encore des zones d'ombre concernant Lord\r\nVan Peers, n'est-ce pas ?" },
            { "Ah, do you mean...?\r\nI mean what was he doing there on Fresno Street that day\r\nin the first place?", "Ah, voulez-vous parler de... ?\r\nJe veux dire, que faisait-il sur Fresno Street ce jour-là pour\r\ncommencer ?" },
            { "Well according to the man's testimony...\r\n...he said he was investigating Inspector Gregson, didn't\r\nhe?", "D'après son propre témoignage...\r\n...il a déclaré qu'il enquêtait sur l'inspecteur Gregson, n'est-ce\r\npas ?" },
            { "And it turns out that little room was actually the\r\ninspector's secret office...", "Et il s'avère que cette modeste pièce était en réalité\r\nle bureau secret de l'inspecteur..." },
            { "Ooh, that sounds like it has all the makings of a\r\nwonderfully devilish plot!", "Ouh, voilà qui a tous les ingrédients d'une intrigue\r\nmerveilleusement machiavélique !" },
            { "But then why was that noticeboard in there covered in all\r\nthose particular papers?\r\nPapers about cases with a link to the Reaper.\r\n...I'm starting to get a bad feeling about all this.", "Mais pourquoi ce tableau d'affichage était-il couvert de tous\r\nces coupures précises ?\r\nDes dossiers liés aux méfaits du Faucheur.\r\n...Je commence à avoir un très mauvais pressentiment." },
            { "Oh dear... That sounds more like something horribly\r\ndevilish...", "Mince alors... Cela ressemble plutôt à un plan sinistre et\r\ndiabolique..." },
            { "We must start by looking into Inspector Gregson's\r\nmovements of late!", "Commençons par retracer les faits et gestes récents de\r\nl'inspecteur Gregson !" }
        });

        // [23] KEY:BB\script\output\_sce03_chr040_01_eng#3
        add(@"BB\script\output\_sce03_chr040_01_eng#3", new string[,] {
            { "Vigil, you say?\r\nIsn't that the name of the lady who came to visit Hurley\r\nyesterday?", "Vigil, dis-tu ?\r\nN'est-ce pas le nom de la dame venue rendre visite à\r\nSherlockinou hier ?" },
            { "That's right. To ask Mr Sholmes if he would help her to\r\nfind her missing husband.\r\nOnly Mr Sholmes completely passed the buck to us.", "Tout à fait. Pour prier M. Holmes de retrouver son mari disparu.\r\nSauf que M. Holmes nous a refilé le bébé sans scrupule." },
            { "...Actually, didn't you say that Mr Vigil had been taken to\r\nhospital?\r\nDo you know which one?", "...Au fait, n'aviez-vous point dit que M. Vigil avait été conduit à\r\nl'hôpital ?\r\nSavez-vous lequel ?" },
            { "Ah, it's St Synner's.\r\n...I'm starting to wonder if all the other hospitals in London\r\nhave closed down...", "Ah, c'est l'hôpital Saint-Synner.\r\n...Je commence à me demander si tous les autres hôpitaux de Londres\r\nont mis la clé sous la porte..." },
            { "But that's amazing, Runo! You've found the lady's husband\r\nalready!", "Mais c'est épatant, Runo ! Tu as déjà retrouvé son mari !" },
            { "Well...I suppose I have. By accident.", "Eh bien... j'imagine que oui. Par pur hasard." },
            { "And ten years ago, while Mr Vigil was the chief warder at\r\nthe prison...\r\n...he was responsible for overseeing the Professor's\r\nincarceration.", "Et il y a dix ans, lorsque M. Vigil était le gardien-chef de la prison...\r\n...il avait la responsabilité de surveiller l'incarcération du Démon Assassin." },
            { "No!\r\nSo when the convict escaped, he was held responsible\r\nand immediately dismissed.", "Pas possible !\r\nAinsi, quand le condamné s'est évadé, il a été tenu responsable\r\net congédié sur-le-champ." },
            { "Ugh...sometimes I really don't want to grow up.", "Ouh... parfois je n'ai vraiment pas envie de grandir." },
            { "There's more. For ten years after that...\r\n...while he was ostensibly working as a pedlar, he also\r\nhad another secret job.\r\nHe was paid by Gregson to be his stand-in.\r\nTo impersonate the inspector.", "Ce n'est pas tout. Pendant dix ans après cela...\r\n...alors qu'il travaillait officiellement comme colporteur, il occupait\r\nun autre rôle secret.\r\nIl était payé par Gregson pour lui servir de doublure.\r\nPour se faire passer pour l'inspecteur." },
            { "To impersonate Gregsy?! But, but why?", "Se faire passer pour Gregounet ?! Mais pourquoi cela ?" },
            { "...I have absolutely no idea.", "...Je n'en ai absolument pas la moindre idée." },
            { "Ugh...Ginny was right. I'm starting to think all adults are\r\nup to no good now.\r\nIncluding you, Runo.\r\n...I haven't paid anyone to impersonate me.", "Pouah... Ginette avait raison. Je commence à croire que tous les adultes\r\ntrament des méchancetés.\r\nY compris toi, Runo.\r\n...Je n'ai jamais payé quiconque pour se faire passer pour moi." },
            { "That means he has ties to the Professor and to Inspector\r\nGregson, though.\r\nSo I do think we ought to pay a visit to Mr Vigil, don't\r\nyou?\r\n(Back to St Synner's, then...)", "Cela signifie toutefois qu'il a des liens avec le Démon Assassin\r\net avec l'inspecteur Gregson.\r\nJe crois donc que nous devrions rendre visite à M. Vigil, non ?\r\n(Retour à l'hôpital Saint-Synner, donc...)" }
        });

        // [24] KEY:BB\script\output\_sce03_chr040_01_eng#4
        add(@"BB\script\output\_sce03_chr040_01_eng#4", new string[,] {
            { "I never imagined I might have to be investigating an\r\ninspector's movements.", "Je n'aurais jamais pensé devoir enquêter un jour sur les agissements\r\nd'un inspecteur de police." },
            { "Well, according to the entry in his diary...\r\n...he was carrying out an incognito investigation of the\r\nRed-Headed League the day before his death.", "D'après les notes de son journal intime...\r\n...il menait une filature incognito sur la Ligue des Rouquins\r\nla veille de sa mort." },
            { "Oh! You, you mean he was doing the same as Hurley?", "Oh ! Tu veux dire qu'il faisait pareil que Sherlockinou ?" },
            { "Well...Mr Sholmes was trying to apply, whereas the\r\ninspector was supposed to be investigating.", "Eh bien... M. Holmes tentait d'y postuler, alors que l'inspecteur\r\nétait censé enquêter." },
            { "I do wish it had been the other way around...", "J'aurais tant souhaité que ce fût l'inverse..." },
            { "...Anyway, as it turns out, the inspector who went to\r\ninvestigate the Red-Headed League that day...\r\n...wasn't actually Gregson at all. It was Mr Vigil,\r\nin possession of Gregson's identification.", "...Quoi qu'il en soit, il s'avère que l'inspecteur qui s'est rendu\r\nà la Ligue des Rouquins ce jour-là...\r\n...n'était pas du tout Gregson. C'était M. Vigil, muni des pièces\r\nd'identité de Gregson." },
            { "Hm, you know what that sounds like to me?\r\nEstablishing an alibi.", "Hum, tu sais à quoi cela me fait penser ?\r\nÀ se forger un alibi." },
            { "Oh my! Yes, you're absolutely right, Iris!\r\nBut...why would Gregson need an alibi?", "Bonté divine ! Oui, tu as parfaitement raison, Iris !\r\nMais... pourquoi Gregson aurait-il eu besoin d'un alibi ?" },
            { "It would appear that the inspector...\r\n...had something to do that he wished to keep secret.", "Il semblerait que l'inspecteur...\r\n...ait eu des affaires urgentes à garder secrètes." },
            { "I don't believe it... I, I always thought he was just a\r\nharmless lover of fish and chips...\r\nBut perhaps they were seasoned with something a little\r\nmore potent than salt and vinegar...", "Je n'en reviens pas... J'ai toujours cru qu'il n'était qu'un\r\npaisible amateur de fish and chips...\r\nMais peut-être ses frites étaient-elles assaisonnées avec quelque chose\r\nde plus corsé que du sel et du vinaigre..." },
            { "I think perhaps...we should try to move away from food\r\nanalogies?", "Je crois... que nous devrions nous éloigner des métaphores\r\nculinaires, non ?" },
            { "...Well anyway, if Lord van Zieks felt the need to\r\ninvestigate Gregson...\r\nYes, I agree. We must try to find out what he knows.", "...Enfin bref, si Lord Van Peers a jugé utile d'enquêter\r\nsur Gregson...\r\nOui, je suis d'accord. Nous devons découvrir ce qu'il sait." }
        });

        // [25] KEY:BB\script\output\_sce03_chr040_01_eng#6
        add(@"BB\script\output\_sce03_chr040_01_eng#6", new string[,] {
            { "Iris, have a look at this...", "Iris, jette un coup d'œil à ceci..." },
            { "That's not right. I thought you were supposed to say\r\n‘Objection!’ or the like when you present evidence?", "Ce n'est pas comme ça ! Je croyais qu'on devait crier\r\n« Objection ! » quand on présente une preuve ?" },
            { "No no. That's only in court.", "Non non. C'est uniquement au tribunal." },
            { "That's not fair! If you won't say it, then I won't look!\r\nHmph!", "Ce n'est pas du jeu ! Si tu ne le dis pas, je refuse de regarder !\r\nNa !" },
            { "Yay! That was great!\r\nRight...next!", "Youpi ! C'était sensationnel !\r\nBien... suivant !" },
            { "(Alright, I get the message. Someone's not in the\r\nmood for looking at things...)", "(D'accord, message reçu. Mademoiselle n'est pas d'humeur\r\nà examiner quoi que ce soit...)" }
        });

        // [26] KEY:BB\script\output\_sce03_chr040_01_eng#7
        add(@"BB\script\output\_sce03_chr040_01_eng#7", new string[,] {
            { "Iris, have you seen this?\r\nYour armband? The symbol of a defence lawyer in Japan?\r\nRuno, you've shown that to me dozens of times.", "Iris, as-tu vu cela ?\r\nTon brassard ? Le symbole de l'avocat de la défense au Japon ?\r\nRuno, tu me l'as montré des dizaines de fois." },
            { "Oh...have I?\r\nThe thing is, I just feel wrong if I don't have it on my arm,\r\nyou know?", "Oh... vraiment ?\r\nC'est que, je me sens tout nu si je ne l'ai pas au bras,\r\ntu comprends ?" },
            { "Well if you ask me, I think you should try wearing\r\nsomething different every now and then.\r\nOh really? Like what?", "Eh bien si tu veux mon avis, tu devrais essayer de porter\r\nautre chose de temps à autre.\r\nAh oui ? Comme quoi ?" },
            { "Well...I could make something for you, if you like?\r\nHow about a band that squeezes your arm when the\r\nperson you're talking to tells a lie?", "Eh bien... je pourrais te fabriquer un gadget si tu veux !\r\nQue dirais-tu d'un bracelet qui te serre le bras dès que\r\nton interlocuteur profère un mensonge ?" },
            { "...I'll keep a space free on my left arm, then.", "...Je garderai une place libre sur mon bras gauche, alors." }
        });

        // [27] KEY:BB\script\output\_sce03_chr040_01_eng#8
        add(@"BB\script\output\_sce03_chr040_01_eng#8", new string[,] {
            { "I thought it was strange, you know.\r\nWhen Hurley suddenly decided to turn his hair red like\r\nthat, I mean.", "Je trouvais ça bizarre, tu sais.\r\nQuand Sherlockinou a subitement décidé de se teindre en roux,\r\nje veux dire." },
            { "You mean, he didn't tell you why?\r\nHe didn't mention the Red-Headed League to you?", "Tu veux dire qu'il ne t'a rien expliqué ?\r\nIl ne t'a pas parlé de la Ligue des Rouquins ?" },
            { "I'll bet it's because he wanted to keep that four pounds a\r\nweek all for himself.", "Je parie qu'il voulait garder ces quatre livres par semaine\r\nrien que pour lui." },
            { "Oh yes, I see. Because your hair has a reddish hue too,\r\nyou mean? Right...", "Ah oui, je vois. Parce que tes cheveux ont aussi un éclat cuivré,\r\ntu veux dire ? C'est vrai..." },
            { "Anyway, at least I have a good starting point for next\r\nmonth's instalment now!", "De toute façon, j'ai au moins un excellent point de départ pour\r\nle récit du mois prochain !" },
            { "(Iris must be the only person who's actually going to\r\nmanage to benefit from this whole sorry affair...)", "(Iris est bien la seule âme à tirer un quelconque profit\r\nde toute cette déplorable affaire...)" }
        });

        // [28] KEY:BB\script\output\_sce03_chr040_01_eng#9
        add(@"BB\script\output\_sce03_chr040_01_eng#9", new string[,] {
            { "Um, Iris, about this...", "Euh, Iris, à propos de ceci..." },
            { "(Oh no! What was I thinking?\r\nWhy on earth did I show her that?)\r\nPoor Gregsy...", "(Oh non ! À quoi pensais-je ?\r\nPourquoi lui avoir montré cela ?)\r\nPauvre Gregounet..." }
        });

        // [29] KEY:BB\script\output\_sce03_chr040_01_eng#10
        add(@"BB\script\output\_sce03_chr040_01_eng#10", new string[,] {
            { "Oh...this looks like it's made from real human hair.\r\nI thought it might be.", "Oh... on dirait de vrais cheveux humains.\r\nC'est bien ce qu'il me semblait." },
            { "Yes, people will pay money for long hair that's in good\r\ncondition.\r\nHurley once offered his hair up for sale, you know. He\r\ngrew it right down to his shoulders.", "Oui, les gens payent cher pour des cheveux longs en bon état.\r\nSherlockinou a essayé de vendre les siens autrefois, tu sais.\r\nIl les avait laissés pousser jusqu'aux épaules." },
            { "Really?! How much did he make?\r\nNo one would buy it.\r\nOh.", "Vraiment ?! Combien en a-t-il tiré ?\r\nPersonne n'a voulu les lui acheter.\r\nAh." },
            { "He was told it was ‘unruly’ apparently.\r\n(Oh. Maybe I'd better give up on the idea as well, then.)", "On lui a dit qu'ils étaient « indisciplinés », paraît-il.\r\n(Ah. Mieux vaut sans doute que j'abandonne cette idée moi aussi.)" }
        });

        // [30] KEY:BB\script\output\_sce03_chr040_01_eng#11
        add(@"BB\script\output\_sce03_chr040_01_eng#11", new string[,] {
            { "Would you like to tell us about it, Iris?\r\nAbout your father.", "Aimerais-tu nous en parler, Iris ?\r\nAu sujet de ton père." },
            { "I'm sure I told you before, didn't I?\r\nThat Daddy used to be Hurley's partner.", "Je vous l'ai déjà raconté, n'est-ce pas ?\r\nPapa était autrefois l'associé de Sherlockinou." },
            { "Yes. And that notes about all the cases they solved\r\ntogether are kept inside that metal chest.", "Oui. Et que les récits de toutes leurs affaires résolues\r\nsont conservés dans ce coffre en métal." },
            { "That's right. Hurley told me, you see.\r\nHe said that Daddy's somewhere far away now, so we\r\ncan't meet.", "C'est exact. C'est Sherlockinou qui me l'a confié.\r\nIl disait que Papa était parti très loin, et qu'on ne\r\npouvait pas se voir." },
            { "(That's one way of describing it.)", "(C'est une façon de tourner les choses.)" },
            { "Then, when I secretly unlocked the chest and read\r\nthrough the papers inside...\r\n...I started to build up a picture in my head of what Daddy\r\nmust be like.\r\nWell, that's only natural.", "Puis, quand j'ai ouvert le coffre en cachette et parcouru\r\nles papiers à l'intérieur...\r\n...j'ai commencé à m'imaginer comment devait être Papa.\r\nC'est bien naturel." },
            { "You're just like any other girl of your age.\r\nI read that Daddy was a professor of medical science, so I\r\nstudied and took my degree, too.", "Tu es comme n'importe quelle fille de ton âge.\r\nJ'ai lu que Papa était professeur en sciences médicales, alors j'ai\r\nétudié et décroché mon diplôme moi aussi." },
            { "W-Well, that's only natural...I suppose.\r\nIn that respect, you're not quite like any other girl of your\r\nage, though.", "E-Eh bien, c'est tout naturel... j'imagine.\r\nSur ce point précis, tu n'es pourtant pas tout à fait comme les autres filles." },
            { "But...there was one thing that I could never find out.\r\nDaddy's name.\r\nAh!\r\nHis name wasn't anywhere on any of the notes that he'd\r\nmade about his work with Hurley.", "Mais... il y a une chose que je n'ai jamais pu découvrir.\r\nLe nom de mon papa.\r\nAh !\r\nSon nom n'apparaissait nulle part sur ses notes de travail\r\navec Sherlockinou." },
            { "But then one day...\r\nThat's what happened, is it?\r\nWhen you saw this autopsy report, you finally managed to\r\nwork it out. Is that right?\r\nYes.", "Mais un beau jour...\r\nC'est ainsi que c'est arrivé, n'est-ce pas ?\r\nQuand tu as vu ce rapport d'autopsie, tu as fini par\r\nle déduire. N'est-ce pas ?\r\nOui." },
            { "(So it was the handwriting in the report that caught her\r\neye.)", "(C'est donc l'écriture manuscrite sur le rapport qui l'a frappée.)" }
        });

        // [31] KEY:BB\script\output\_sce03_chr040_01_eng#12
        add(@"BB\script\output\_sce03_chr040_01_eng#12", new string[,] {
            { "When I saw the writing on that report, I could hardly\r\nbelieve it.\r\n‘I know that handwriting,’ I thought to myself.", "Quand j'ai vu l'écriture sur ce document, je n'en croyais\r\npas mes yeux.\r\n« Je connais cette écriture », me suis-je dit." },
            { "Because it was the same as the writing you'd seen on\r\nyour father's case notes?\r\nExactly.", "Parce qu'elle était identique à celle qui figurait sur\r\nles carnets d'enquêtes de ton père ?\r\nExactement." },
            { "I was desperate to compare the two properly.\r\nI needed to see them side by side.\r\nI asked the doctor in the laboratory, but I was told I\r\ncouldn't take the report away.", "Je voulais désespérément les comparer méticuleusement.\r\nIl me fallait les voir côte à côte.\r\nJ'ai demandé au médecin du laboratoire, mais on m'a dit qu'il était\r\ninterdit d'emporter le rapport." },
            { "And even worse, I was told that was the first and last time\r\nwe'd be allowed even to look at it there.\r\nSo you decided...to steal it.", "Et pire encore, on m'a prévenue que c'était la toute première et dernière fois\r\nqu'on nous autoriserait ne serait-ce qu'à le consulter.\r\nAlors tu as décidé... de le voler." },
            { "When I compared the autopsy report with the case notes I\r\nhad here...\r\n...there was no doubt.\r\nThe handwriting was exactly the same. It was Daddy's.", "Quand j'ai comparé le rapport d'autopsie avec les notes que\r\nj'avais ici...\r\n...il n'y avait plus le moindre doute.\r\nL'écriture était rigoureusement la même. C'était celle de Papa." },
            { "And the signature of the coroner at the bottom of the\r\nautopsy report...\r\n...Read ‘Dr John H. Wilson’.", "Et la signature du médecin légiste au bas du\r\nrapport d'autopsie...\r\n...indiquait « Dr John H. Wilson »." },
            { "So that's how I finally found out.\r\nI learnt Daddy's name at last.\r\nI see...", "C'est ainsi que j'ai fini par le découvrir.\r\nJ'ai enfin appris le nom de Papa.\r\nJe vois..." },
            { "Ever since then, I've called myself Iris Wilson.\r\nAnd that's also when I had the brilliant idea...\r\n...of writing stories all about Daddy's exciting times with\r\nHurley.", "Depuis ce jour, je me fais appeler Iris Wilson.\r\nEt c'est aussi là que j'ai eu la merveilleuse idée...\r\n...d'écrire les récits palpitants des aventures de Papa\r\navec Sherlockinou." },
            { "I decided there and then that I'd write ‘The Adventures\r\nof Herlock Sholmes’!", "J'ai décidé sur-le-champ d'écrire « Les Aventures\r\nde Sherlock Holmes » !" },
            { "Oh, Iris... I had no idea the stories had quite such a deep\r\npersonal significance for you.", "Oh, Iris... j'ignorais que ces histoires avaient une telle\r\nportée personnelle à tes yeux." },
            { "(I can see why the autopsy report was so important to her\r\nnow.)\r\n(And why she was prepared to break the law to get her\r\nhands on it.)", "(Je comprends désormais pourquoi ce rapport d'autopsie comptait autant pour elle.)\r\n(Et pourquoi elle était prête à enfreindre la loi pour mettre\r\nla main dessus.)" }
        });

        // [32] KEY:BB\script\output\_sce03_chr040_01_eng#14
        add(@"BB\script\output\_sce03_chr040_01_eng#14", new string[,] {
            { "Iris, about this piece of evidence...", "Iris, à propos de cette preuve..." },
            { "(She's not in the mood to talk at the moment, then.\r\n...I suppose that's understandable.)", "(Elle n'a pas le cœur à bavarder en ce moment.\r\n...C'est bien compréhensible.)" }
        });

        // [33] KEY:BB\script\output\_sce03_chr050_00_eng#1
        add(@"BB\script\output\_sce03_chr050_00_eng#1", new string[,] {
            { "Are you serious, Gina?!\r\nInspector Gregson was...\r\nHe was really shot?!", "Tu es sérieuse, Gina ?!\r\nL'inspecteur Gregson a...\r\nIl s'est vraiment fait tirer dessus ?!" },
            { "I, I don't know much about wot 'appened meself yet.\r\nThey're still there...investigatin' the scene.", "J'en... j'en sais guère plus moi-même pour l'instant.\r\nIls sont toujours là-bas... à passer la scène au peigne fin." },
            { "Where did this take place?", "Où cela s'est-il passé ?" },
            { "A little rented room in a buildin' full o' flats on Fresno\r\nStreet.", "Une petite piaule louée dans un immeuble sur Fresno\r\nStreet." },
            { "The outskirts of town.\r\nNowhere near his home.", "Dans les faubourgs de la ville.\r\nBien loin de son domicile." },
            { "He was perhaps investigating a case then...", "Il enquêtait peut-être sur une affaire alors..." },
            { "The thing is...no one at the Yard knows nuffin' about no\r\ncase around there.", "Le hic... c'est que personne au Yard sait rien sur une quelconque\r\naffaire par là-bas." },
            { "Oh. How strange...", "Oh. Comme c'est étrange..." },
            { "The boss was...\r\n'E was so good to me.\r\nI know I ain't up to much yet, but...\r\n...one day, I was gonna show 'im! I was gonna show 'im I'd\r\nbecome a proper detective!\r\nOh, Ginny...", "Le patron était...\r\nIl était si bon avec moi.\r\nJ'sais bien qu'j'vaux pas grand-chose pour l'instant, mais...\r\n...un jour, j'allais lui montrer ! J'allais lui prouver qu'j'pouvais\r\ndevenir une vraie enquêtrice !\r\nOh, Ginette..." }
        });

        // [34] KEY:BB\script\output\_sce03_chr050_00_eng#2
        add(@"BB\script\output\_sce03_chr050_00_eng#2", new string[,] {
            { "So! Who did this?\r\nDo you have any idea who the culprit is?", "Alors ! Qui a fait ça ?\r\nAs-tu la moindre idée du coupable ?" },
            { "They got 'im already.", "Ils l'ont déjà coffré." },
            { "Already?!\r\n(They've caught the shooter so soon?)", "Déjà ?!\r\n(Ils ont alpagué le tireur aussi vite ?)" },
            { "A witness reported somefin' was goin' on, and the boys got\r\nstraight down there an' took care of 'im.", "Un témoin a prévenu qu'un truc clochait, et les gars ont déboulé\r\ndirect pour lui passer les menottes." },
            { "Who?! What awful person did this?", "Qui ?! Quelle créature ignoble a pu commettre cela ?" },
            { "I, I still can't believe it meself...\r\nGina?", "J'arrive... j'arrive toujours pas à y croire moi-même...\r\nGina ?" },
            { "It was the Reaper.", "C'était le Faucheur." },
            { "The– Wait a minute!\r\nYou don't mean...\r\n...they've arrested Lord van Zieks for it?!", "Le... Attends une seconde !\r\nTu ne veux tout de même pas dire...\r\n...qu'ils ont arrêté Lord Van Peers pour ça ?!" },
            { "That's right! That Reaper bloke's gone an' shot the boss!", "Si ! Ce satané Faucheur a descendu le patron d'une balle !" },
            { "No!\r\n(Lord van Zieks...?)", "Non !\r\n(Lord Van Peers...?)" }
        });

        // [35] KEY:BB\script\output\_sce03_chr050_00_eng#3
        add(@"BB\script\output\_sce03_chr050_00_eng#3", new string[,] {
            { "Are you quite sure, Miss Lestrade?\r\nIt's Barok van Zieks the police have arrested?", "En êtes-vous tout à fait certaine, mademoiselle Lestrade ?\r\nC'est bien Drake Van Peers que la police a arrêté ?" },
            { "I saw 'im wiv me own eyes.\r\nIn the interview room at the Yard.", "J'l'ai vu d'mes propres yeux.\r\nDans la salle d'interrogatoire du Yard." },
            { "I don't believe it...\r\nBut there were witnesses.\r\nAn' they're all sayin' it was 'im.", "Je n'arrive pas à y croire...\r\nMais y avait des témoins.\r\nEt ils disent tous que c'est bien lui." },
            { "So you mean...there were actually multiple witnesses?", "Vous voulez dire... qu'il y a eu plusieurs témoins oculaires ?" },
            { "They 'eard the gunshot, apparently.\r\nAn' when our lot got to the scene...\r\n...there was only the boss and that Reaper bloke in the\r\nroom!", "Ils ont entendu le coup de feu, paraît-il.\r\nEt quand notre brigade est arrivée sur les lieux...\r\n...y avait seulement le patron et ce type du Faucheur dans la pièce !" },
            { "(But there's no way Lord van Zieks would have taken\r\nGregson's life.)\r\n(I...I just don't believe it!)\r\nI don't believe it, either!", "(Il est impensable que Lord Van Peers ait ôté la vie à Gregson.)\r\n(C'est... c'est tout bonnement impossible !)\r\nMoi non plus, je n'y crois pas un seul instant !" }
        });

        // [36] KEY:BB\script\output\_sce03_chr050_00_eng#4
        add(@"BB\script\output\_sce03_chr050_00_eng#4", new string[,] {
            { "Um, Gina, I wanted to show you this...", "Euh, Gina, je voulais te montrer cela..." },
            { "(No, what am I thinking?\r\nThis is hardly the time, is it?)", "(Non mais à quoi je pense ?\r\nCe n'est vraiment pas le moment pour ça...)" }
        });

        // [37] KEY:BB\script\output\_sce03_chr050_00_eng#5
        add(@"BB\script\output\_sce03_chr050_00_eng#5", new string[,] {
            { "Gina, what was Inspector Gregson doing here in the first\r\nplace?", "Gina, que faisait l'inspecteur Gregson ici pour commencer ?" },
            { "That's wot I wanna know!\r\n...It's wot? 'Alf a year since I got out o' the clink?\r\nThat's when I decided to give up me divin' an' become a\r\ndetective instead.", "C'est bien c'que j'aimerais savoir !\r\n...Ça fait quoi ? Six mois qu'je suis sortie du trou ?\r\nC'est là qu'j'ai laissé tomber les pickpockets pour devenir enquêtrice." },
            { "Oh yes, Mr Sholmes twisted the inspector's arm to agree\r\nto take you on as an apprentice, didn't he?", "Ah oui, M. Holmes a forcé la main de l'inspecteur pour qu'il\r\naccepte de vous prendre comme apprentie, n'est-ce pas ?" },
            { "Summat like that, I think. Anyway, the point is, I didn't\r\nreally know much about the boss 'til then.", "Un truc dans l'genre, ouais. Enfin bref, le fait est que j'connaissais\r\npas grand-chose sur le patron jusque-là." },
            { "But it turns out, 'e's a bit of a legend at the Yard.", "Mais il s'avère qu'c'était un genre de légende au Yard." },
            { "Goodness! Really?\r\nThey say 'e managed to solve some really tricky case...\r\njust like that!", "Bonté divine ! Vraiment ?\r\nOn raconte qu'il a réussi à élucider une affaire hyper corsée...\r\ncomme ça, les doigts dans l'nez !" },
            { "He did?\r\nYup. An' ever since then, 'e started goin' out on all sorts o'\r\ninvestigations, but always on 'is own.", "C'est vrai ?\r\nOuais. Et depuis lors, il partait sur toutes sortes d'enquêtes,\r\nmais toujours en solo." },
            { "No one else at the Yard even knows wot 'alf the cases 'e's\r\nworkin' on are, apparently.", "Personne au Yard sait seulement sur quoi y bossait la moitié du temps,\r\nparaît-il." },
            { "That's not how it's supposed to work, is it?\r\n(So what was the ‘legendary inspector’ doing in a dingy\r\nlittle room like this?)", "Ce n'est pas ainsi que la police est censée fonctionner, si ?\r\n(Que faisait donc ce « légendaire inspecteur » dans une pièce\r\naussi miteuse ?)" },
            { "I know 'e 'ad a lot of respect for the Reaper an' all.\r\nAn' look where that landed 'im!\r\nRespect for the Reaper? In what way?", "J'sais qu'il avait un respect fou pour le Faucheur.\r\nEt regardez où ça l'a mené !\r\nDu respect pour le Faucheur ? En quel sens ?" },
            { "I 'eard 'im say as much.\r\n‘I take my 'at off to that fella,’ were 'is words.", "J'l'ai entendu le dire de ses propres lèvres.\r\n« J'tire mon chapeau à ce gaillard », qu'il disait." },
            { "...Not how the general public feels, is it?\r\nMost people are terrified of the Reaper.", "...Ce n'est guère le sentiment du commun des mortels, n'est-ce pas ?\r\nLa plupart des gens en sont terrifiés." },
            { "Yeah, the boss said that's exactly why 'e respected the\r\nbloke.", "Ouais, le patron disait qu'c'est justement pour ça qu'il respectait\r\nle bonhomme." }
        });

        // [38] KEY:BB\script\output\_sce03_chr050_00_eng#6
        add(@"BB\script\output\_sce03_chr050_00_eng#6", new string[,] {
            { "I 'eard 'im say as much.\r\n‘I take my 'at off to that fella,’ were 'is words.", "J'l'ai entendu le dire de ses propres lèvres.\r\n« J'tire mon chapeau à ce gaillard », qu'il disait." },
            { "...Not how the general public feels, is it?\r\nMost people are terrified of the Reaper.\r\nYeah, the boss said that's exactly why 'e respected the\r\nbloke.", "...Ce n'est guère le sentiment du commun des mortels, n'est-ce pas ?\r\nLa plupart des gens en sont terrifiés.\r\nOuais, le patron disait qu'c'est justement pour ça qu'il respectait\r\nle bonhomme." }
        });

        // [39] KEY:BB\script\output\_sce03_chr050_00_eng#7
        add(@"BB\script\output\_sce03_chr050_00_eng#7", new string[,] {
            { "(I didn't realise Gregson held the Reaper in quite such\r\nhigh regard.)", "(J'ignorais que Gregson vouait une si haute estime au Faucheur.)" },
            { "'E said somefin' else to me an' all...\r\nThat I didn't need to worry about the Reaper, cos 'e only\r\ngoes after people wot are bad.\r\nIt did kind o' set my mind at ease when 'e said that.\r\nRight...", "Il m'a dit un autre truc aussi...\r\nQue j'avais pas à m'en faire pour le Faucheur, parce qu'il s'en\r\nprend qu'aux pourris et aux crapules.\r\nÇa m'a un peu tranquillisé l'esprit quand il m'a dit ça.\r\nJe vois..." }
        });

        // [40] KEY:BB\script\output\_sce03_chr050_00_eng#8
        add(@"BB\script\output\_sce03_chr050_00_eng#8", new string[,] {
            { "What is this place, then?\r\nDoes anyone live here?", "Quel est cet endroit alors ?\r\nEst-ce habité ?" },
            { "Apparently it's bein' rented by some cove called Hugh\r\nBoone.", "Paraît qu'c'est loué par un gars du nom d'Hugh\r\nBoone." },
            { "Hugh Boone...\r\nIt's a sort of...here-today-gone-tomorrow name that, isn't\r\nit?", "Hugh Boone...\r\nC'est le genre de nom... passe-partout et volatil, non ?" },
            { "Yeah, 'e's wot we call an unidentified person.\r\nWe 'aven't been able to get in touch wiv 'im.", "Ouais, c'est ce qu'on appelle un inconnu au bataillon.\r\nOn a pas réussi à lui mettre la main dessus." },
            { "I see.\r\nWell, judging from appearances...\r\n...I'd have to say this place hasn't been lived in for a long\r\ntime. If ever.", "Je vois.\r\nEh bien, à en juger par les apparences...\r\n...je dirais que personne n'a vécu ici depuis une éternité.\r\nSi tant est que quelqu'un y ait jamais habité." },
            { "Right? All the lads from the Yard piled down to get stuck\r\ninto the investigation...\r\n...but there's so little 'ere, no one knew wot to do wiv\r\n'emselves.", "Pas vrai ? Tous les flics du Yard ont débarqué pour fouiller\r\nla piaule de fond en comble...\r\n...mais y a tellement rien que personne savait quoi faire." },
            { "I do wonder...\r\nYes, Miss Susato?", "Je me demande...\r\nOui, mademoiselle Susato ?" },
            { "Well, could it be that this Hugh Boone...\r\n...is in fact Inspector Gregson himself?", "Eh bien, se pourrait-il que cet Hugh Boone...\r\n...soit en réalité l'inspecteur Gregson en personne ?" },
            { "What?\r\nHow could that be?", "Quoi ?\r\nComment cela serait-il possible ?" },
            { "Well if he was investigating on his own...\r\n...it's quite possible that this was in fact some kind of\r\nsecret office of his.", "S'il menait des investigations en solitaire...\r\n...il est fort probable que cette pièce lui servait\r\nde bureau secret." },
            { "I'd, I'd never even considered that!", "Je... je n'y avais même pas songé !" },
            { "Nice work, Sooze! We're actually followin' a line of\r\ninquiry like that ourselves.", "Bien vu, Susette ! On suit justement une piste dans ce genre-là." },
            { "You are?\r\nIf you look around the room, you'll see.\r\nThere's a few things that hint at it.\r\n(We should really investigate this place in detail...)", "Vraiment ?\r\nRegardez autour de vous, vous verrez.\r\nY a plusieurs détails qui mettent la puce à l'oreille.\r\n(Nous devrions examiner cet endroit méticuleusement...)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        // Write output
        File.WriteAllText(@"tools\Trans_Ep4_Act2_Part1.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Done writing Trans_Ep4_Act2_Part1.cs");
    }
}
