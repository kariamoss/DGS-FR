using System;
using System.IO;
using System.Text;

class MakeAct6Part1B {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart1_B() {");

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

        // [16] KEY:BB\script\output\_sce02_chr010_01_eng#1
        add(@"BB\script\output\_sce02_chr010_01_eng#1", new string[,] {
            { "We're in the process of trying to track somebody down.", "Nous essayons actuellement de retrouver la trace de quelqu'un." },
            { "Oh?", "Vraiment ?" },
            { "Yes,", "Oui," },
            { " a man by the name of Enoch Drebber.", " un homme du nom d'Enoch Drebber." },
            { "He's the swindler who duped Professor Harebrayne,", "C'est l'escroc qui a grugé le professeur Lonron," },
            { " and\r\nthe engineer who built the kinesis machine.", " et l'ingénieur qui a conçu la machine de téléportation." },
            { "A swindler", "Un escroc" },
            { " and an engineer?", " et un ingénieur ?" },
            { "Quite the modern man.", "Voilà un homme bien moderne." },
            { "He also seems to be a conjuror of sorts, too,", "Il semble aussi être une sorte d'illusionniste," },
            { " with\r\nconsiderable knowledge of stage magic.", " possédant des connaissances poussées en prestidigitation." },
            { "We really need to locate him ", "Nous devons impérativement le débusquer " },
            { "before the trial resumes\r\ntomorrow morning.", "avant la reprise du procès demain matin." },
            { "But we have so few clues to go on,", "Mais nous avons si peu d'indices sur lesquels nous appuyer," },
            { "that's the trouble.", "voilà tout le problème." },
            { "...Do you have any good ideas?", "...Auriez-vous une bonne idée ?" },
            { "I have no data yet.", "Je n'ai pas encore de données." },
            { " It is a capital mistake to have good\r\nideas before one has data.", " C'est une erreur capitale d'échafauder des théories avant d'avoir des faits." },
            { "If I knew something of the man's appearance, at least,", "Si au moins je savais à quoi ressemble cet individu," },
            { " I\r\nmay be in a better position to help.", " je serais peut-être plus à même de vous aider." },
            { "(Yes,", "(Oui," },
            { " Drebber's appearance...)", " l'apparence de Drebber...)" },
            { "Fortunately for you, however,", "Fort heureusement pour vous, cependant," },
            { " presently I have little to\r\noccupy myself", " j'ai bien peu d'occupations pour le moment" },
            { "and little to fill my stomach.", "et bien peu de quoi me remplir l'estomac." },
            { "As soon as you find any clue –", "Dès que vous trouverez le moindre indice –" },
            { " no matter how small –", " si infime soit-il –" },
            { " I\r\nshould gladly give you my thoughts on it.", " je me ferai un plaisir de vous faire part de mes réflexions." }
        });

        // [17] KEY:BB\script\output\_sce02_chr010_01_eng#2
        add(@"BB\script\output\_sce02_chr010_01_eng#2", new string[,] {
            { "Mr Sholmes...", "Monsieur Holmes..." },
            { "did you", "nous avez-vous" },
            { " lie to us?", " menti ?" },
            { "My dear Mr Naruhodo...", "Mon cher monsieur Naruhodo..." },
            { "stay that piercing stare.", "cessez ce regard inquisiteur." },
            { "What is this about?", "De quoi s'agit-il donc ?" },
            { "Last winter,", "L'hiver dernier," },
            { " when we were first on our way to Britain\r\naboard the steamship...", " quand nous étions en route pour la Grande-Bretagne à bord du vapeur..." },
            { "...your words were very clear:", "...vos paroles étaient sans équivoque :" },
            { "‘So then...", "« Ainsi donc..." },
            { "let us unravel this mystery...’", "élucidons ce mystère... »" },
            { "‘...and discover what events", "« ...et découvrons quels événements" },
            { " led to this curious murder.’", " ont conduit à ce curieux assassinat. »" },
            { "You told us", "Vous nous avez affirmé" },
            { " that it was murder.", " qu'il s'agissait d'un meurtre." },
            { "And you examined Kazuma-sama's body.", "Et vous avez examiné la dépouille de Monsieur Kazuma." },
            { "Indeed.", "Tout à fait." },
            { " And wherein lies the problem?", " Et où se situe le problème ?" },
            { "We met him earlier today.", "Nous l'avons rencontré plus tôt aujourd'hui." },
            { "The ‘victim’,", "La « victime »," },
            { "Kazuma Asogi.", "Kazuma Asogi." },
            { "You're quite sure?", "En êtes-vous bien certain ?" },
            { "He...", "Il..." },
            { "was wearing some sort of mask,", "portait une sorte de masque," },
            { " and was apparently\r\nsuffering from amnesia.", " et semblait frappé d'amnésie." },
            { "But yes,", "Mais oui," },
            { " I'm quite sure.", " j'en suis absolument certain." },
            { "It was Kazuma-sama.", "C'était bien Monsieur Kazuma." },
            { "You must have known at the time, Mr Sholmes.", "Vous deviez le savoir à l'époque, monsieur Holmes." },
            { "That he...", "Qu'il..." },
            { "wasn't actually dead.", "n'était pas réellement mort." },
            { "Well,", "Eh bien," },
            { "I can only assume I was swept up in the murderous\r\natmosphere of the moment.", "je présume que je me suis laissé emporter par l'atmosphère funeste de l'instant." },
            { "But the fellow wasn't dead at all?", "Le bougre n'était donc point mort du tout ?" },
            { "Ah ha ha ha ha hah!", "Ah ah ah ah ah ah !" },
            { "Priceless!", "Inestimable !" },
            { "...I don't suppose that performance would pass muster,\r\nwould it,", "...J'imagine que cette explication n'est guère convaincante," },
            { "Mr Naruhodo?", "monsieur Naruhodo ?" },
            { "I could believe that the crewmen present at the time", "Je pourrais croire que les membres d'équipage présents" },
            { "made a mistake.", "aient pu commettre une erreur." },
            { "But not you...", "Mais pas vous..." },
            { "Mr Sholmes.", "monsieur Holmes." },
            { "I will now tell you something", "Je vais à présent vous révéler une chose" },
            { "of the first importance, my\r\ndear fellow:", "de la plus haute importance, mon cher ami :" },
            { "Great detectives", "Les grands détectives" },
            { " are wont to lie.", " ont coutume de mentir." },
            { "...It will serve you well to remember that.", "...Il vous sera très profitable de vous en souvenir." }
        });

        // [18] KEY:BB\script\output\_sce02_chr010_01_eng#3
        add(@"BB\script\output\_sce02_chr010_01_eng#3", new string[,] {
            { "I will now tell you something", "Je vais à présent vous révéler une chose" },
            { "of the first importance, my\r\ndear fellow:", "de la plus haute importance, mon cher ami :" },
            { "Great detectives", "Les grands détectives" },
            { " are wont to lie.", " ont coutume de mentir." },
            { "...It will serve you well to remember that.", "...Il vous sera très profitable de vous en souvenir." }
        });

        // [19] KEY:BB\script\output\_sce02_chr010_01_eng#4
        add(@"BB\script\output\_sce02_chr010_01_eng#4", new string[,] {
            { "Please, Mr Sholmes...", "Je vous en prie, monsieur Holmes..." },
            { "Tomorrow in court,", "Demain lors de l'audience," },
            { "you will find yourself on the\r\nthreshold of a very great mystery.", "vous vous retrouverez au seuil d'un insondable mystère." },
            { "For now,", "Pour l'heure," },
            { "I'm afraid that is all I can say.", "je crains que ce ne soit tout ce que je puisse déclarer." }
        });

        // [20] KEY:BB\script\output\_sce02_chr010_01_eng#5
        add(@"BB\script\output\_sce02_chr010_01_eng#5", new string[,] {
            { "I have a suggestion,", "J'ai une suggestion," },
            { "Mr Naruhodo!", "monsieur Naruhodo !" },
            { "Will you indulge me?", "Me ferez-vous l'honneur de m'écouter ?" },
            { "Oh!", "Oh !" },
            { "Well...", "Eh bien..." },
            { "what is it?", "de quoi s'agit-il ?" },
            { "As I explained to you when you arrived,", "Comme je vous l'ai exposé à votre arrivée," },
            { " the missing\r\nwaxwork has been returned.", " la statue de cire disparue a été restituée." },
            { "And I personally", "Et j'ai personnellement" },
            { " reinstalled it in the exhibit from which\r\nit was taken...", " pris soin de la réinstaller dans sa mise en scène d'origine..." },
            { "behind those thick curtains.", "derrière ces épais rideaux." },
            { "Oh, yes...", "Ah, oui..." },
            { " The ‘Professor’ exhibit,", " La scène du « Démon Assassin »," },
            { "isn't it?", "n'est-ce pas ?" },
            { "Would you like to see it?", "Aimeriez-vous l'admirer ?" },
            { " For a mere five shillings?", " Pour la modique somme de cinq shillings ?" },
            { "...That's a special", "...C'est un prix d'ami exceptionnel," },
            { "one-time-only price, you understand.", "valable une seule fois, entendez bien." },
            { "What?", "Quoi ?" },
            { "The opportunity won't come again, I might add.", "L'occasion ne se représentera point, permettez-moi de le préciser." },
            { "Wouldn't you like to see the fruits of my labour?", "Ne brûlez-vous pas d'admirer le fruit de mon labeur ?" },
            { "Well, we do have a rather pressing investigation to\r\ncarry out.", "Eh bien, nous avons une enquête plutôt urgente à mener." },
            { "Perhaps we could postpone...?", "Peut-être pourrions-nous remettre cela... ?" },
            { "The price is a very reasonable five shillings.", "Le tarif est de cinq shillings, fort raisonnable." },
            { "I think you'll find it's well worth it.", "Je crois que vous ne regretterez nullement votre dépense." },
            { "Are you...?", "Êtes-vous... ?" },
            { "Are you being quite serious, Mr Sholmes?", "Êtes-vous sérieux, monsieur Holmes ?" },
            { "Surely you need only look at my expression", "Il vous suffit de scruter les traits de mon visage" },
            { "to ascertain\r\nif this is seriousness or silliness?", "pour juger si je suis empreint de gravité ou d'espièglerie !" },
            { "(I can never tell with you,", "(Avec vous, impossible de faire la différence," },
            { " that's the point.)", " c'est bien ça le problème.)" },
            { "Very well,", "Soit," },
            { " it couldn't hurt.", " cela ne peut pas faire de mal." },
            { "Here's your five shillings.", "Voici vos cinq shillings." },
            { "...Gratefully received.", "...Reçus avec gratitude." },
            { "So,", "Ainsi donc," },
            { " the special exhibit awaits behind the curtain.", " l'attraction vous attend derrière ce rideau." },
            { "I invite you to peruse it at your leisure.", "Je vous invite à la contempler tout à votre aise." },
            { "the money's been spent, so...", "l'argent est dépensé, alors..." },
            { "Let's go and see the special exhibit!", "Allons voir cette fameuse exposition !" },
            { "(Hm,", "(Hum," },
            { " through those heavy curtains at last...)", " derrière ces lourds rideaux enfin...)" }
        });

        // [21] KEY:BB\script\output\_sce02_chr010_01_eng#6
        add(@"BB\script\output\_sce02_chr010_01_eng#6", new string[,] {
            { "I believe I told you a little about the Professor yesterday,", "Je crois vous avoir touché deux mots du Démon Assassin hier," },
            { "did I not?", "n'est-ce pas ?" },
            { "He took the lives of five victims...", "Il ôta la vie à cinq personnes..." },
            { "every one being either a\r\nmember of the aristocracy", "toutes issues de la haute aristocratie" },
            { " or royalty.", " ou de la noblesse royale." },
            { "All were attacked by an enormous hunting hound", "Toutes furent assaillies par un colossal molosse de chasse" },
            { " and had\r\ntheir throats ripped from their bodies.", "qui leur déchira sauvagement la gorge." },
            { "Oh gosh!", "Grands dieux !" },
            { "An enormous hound?", "Un colossal molosse ?" },
            { "How awful...", "Quelle horreur..." },
            { "After taking the life of his fifth victim,", "Après le meurtre de sa cinquième victime," },
            { " the killer was\r\napprehended.", "le meurtrier fut appréhendé." },
            { "It was a case of unprecedented magnitude in Britain, you\r\nunderstand.", "Cette affaire eut un retentissement sans précédent au royaume, comprenez bien." },
            { "Accordingly...", "Par conséquent..." },
            { "...the Professor was tried in a closed court.", "...le procès du Démon Assassin se tint à huis clos." },
            { "No members of the public were permitted.", "Aucun membre du public ne fut autorisé à y assister." },
            { "A closed court?", "Un procès à huis clos ?" },
            { "So you mean that the Professor's identity...?", "Vous voulez dire que l'identité du Démon Assassin... ?" },
            { "As you've surmised,", "Comme vous l'avez deviné," },
            { "His identity was never made public.", "son identité ne fut jamais rendue publique." },
            { "Naturally,", "Naturellement," },
            { "he was found guilty,", "il fut reconnu coupable," },
            { " and was summarily\r\nsentenced to death by hanging.", "et prestement condamné à mort par pendaison." },
            { "He was buried in a grave at Lowgate Cemetery,", "Il fut inhumé dans une tombe du cimetière de Lowgate," },
            { " which\r\nadjoins the rear of the prison where he had been held.", "situé juste derrière la prison où il était incarcéré." },
            { "However...", "Toutefois..." },
            { "that was not the end of the affair.", "ce ne fut point le dénouement de cette sinistre affaire." },
            { "The very night that he was buried,", "La nuit même de son enterrement," },
            { " the convicted man...", "le criminel condamné..." },
            { "came back to life.", "revint à la vie." },
            { "C-Came back to life?!", "R-Revint à la vie ?!" },
            { "He clawed his way out of the ground,", "Il s'extirpa de la terre de ses propres mains," },
            { " and emerged into\r\nthe moonlit graveyard.", "et émergea dans le cimetière baigné par le clair de lune." },
            { "The exhibit here", "La scène exposée ici" },
            { "depicts that very scene,", "dépeint ce moment précis," },
            { " as described by\r\nthe sole witness to those chilling events.", "tel que l'a décrit l'unique témoin de ces événements glaçants." },
            { "There was a witness?", "Il y avait un témoin ?" },
            { "But of course,", "Mais naturellement," },
            { "It was none other than...", "Ce ne fut nul autre que..." },
            { "the\r\nyoung man in the white overcoat.", "le jeune homme au pardessus blanc." },
            { "(Enoch Drebber...", "(Enoch Drebber..." },
            { "He saw it happen?!)", "Il a été témoin de ça ?!)" }
        });

        // [22] KEY:BB\script\output\_sce02_chr010_01_eng#7
        add(@"BB\script\output\_sce02_chr010_01_eng#7", new string[,] {
            { "So this is a waxwork model of Enoch Drebber...", "Voici donc la statue de cire d'Enoch Drebber..." },
            { "Ten years ago...", "Il y a dix ans..." },
            { "...the convicted Professor,", "...le Démon Assassin condamné," },
            { " having been gibbetted and\r\nburied,", "pendu puis enseveli," },
            { " emerged from his grave in the dead of night.", "sortit de sa fosse au cœur de la nuit." },
            { "The sole witness to that unimaginable scene...", "L'unique témoin de cette scène inimaginable..." },
            { "was this\r\nyoung man.", "fut ce jeune homme." },
            { "From appearances,", "À en juger par son allure," },
            { " I would say he was about twenty\r\nyears old.", "je dirais qu'il avait une vingtaine d'années." },
            { "It's so horrifying...", "C'est effroyable..." },
            { "Scared out of his wits,", "Mort de terreur," },
            { " the young Drebber ran to a nearby\r\npolice station to report the incident.", "le jeune Drebber courut au poste de police le plus proche pour signaler les faits." },
            { "And the sheer terror of what he'd seen", "Et l'indicible terreur provoquée par sa vision" },
            { " is said to have\r\nturned his hair white overnight.", "aurait fait blanchir sa chevelure en une seule nuit." },
            { "(Yes,", "(Oui," },
            { "as shown in the photograph we have of him.", "comme le montre la photographie en notre possession." },
            { "His hair is completely white.)", "Ses cheveux sont d'une blancheur immaculée.)" },
            { "For the following few days,", "Les jours suivants," },
            { " the story of what he'd seen\r\nwas on every front page in the capital.", "le récit de son effroyable vision fit la une de tous les quotidiens." },
            { "The public was frantic for every last detail about the\r\nkiller who'd come back to life.", "Le public s'arrachait les moindres détails sur le meurtrier revenu d'entre les morts." },
            { "As you've seen,", "Comme vous l'avez constaté," },
            { " an exhibit was even created here at\r\nMadame Tusspells.", "une reconstitution fut même façonnée ici chez Madame Pétrie." },
            { "I can quite understand why the man's hair turned white,", "Je comprends aisément que ses cheveux aient pu blanchir sous le choc," },
            { "certainly.", "assurément." },
            { "But what I don't understand...", "Mais ce que je ne m'explique pas..." },
            { "...is what Mr Drebber was doing in the first place...", "...c'est ce que monsieur Drebber fabriquait là-bas..." },
            { "...in a lonely graveyard,", "...dans un cimetière désert," },
            { " in the middle of the night.", "en plein milieu de la nuit." },
            { "what...was he up to?", "qu'est-ce qu'il mijotait ?" }
        });

        // [23] KEY:BB\script\output\_sce02_chr010_01_eng#8
        add(@"BB\script\output\_sce02_chr010_01_eng#8", new string[,] {
            { "The Professor's acts of terror thrown London's upper\r\nclasses into complete panic ten years ago.", "Les crimes de terreur du Démon Assassin plongèrent la haute société dans la panique il y a dix ans." },
            { "The Professor's acts of terror", "Les crimes de terreur du Démon Assassin" },
            { " threw London's upper\r\nclasses into complete panic ten years ago.", " plongèrent la haute société londonienne dans une terreur indicible." },
            { "It was a great scandal, one might say...", "Ce fut un immense scandale, pourrait-on dire..." },
            { "at the very highest\r\nlevels of society.", "aux plus hauts échelons du pouvoir." },
            { "And since the killer's identity was never made public,", "Et puisque le nom du meurtrier ne fut jamais divulgué," },
            { "rumours abounded.", "les rumeurs allèrent bon train." },
            { "After all,", "Après tout," },
            { " no killer had ever before systematically\r\nemployed a dog as a weapon of murder.", " jamais aucun assassin n'avait employé méthodiquement un limier sanguinaire comme arme du crime." },
            { "I can imagine the impact the case must have had.", "j'imagine le retentissement phénoménal de l'affaire." },
            { "But in time, of course,", "Mais avec le temps, naturellement," },
            { " the rumours abated.", " l'agitation retomba." },
            { "So too did talk of the shocking witness account of the\r\nconvict who came back to life.", "Il en fut de même pour le témoignage stupéfiant du condamné ressuscité." },
            { "It was forgotten.", "Ce fut relégué aux oubliettes." },
            { "Dismissed as a dubious ghost story.", "Classé comme une fable de fantômes douteuse." },
            { "As a preposterous parlour tale.", "Une légende urbaine saugrenue pour salons mondains." },
            { "But...", "Mais..." },
            { "but why did people stop believing it?", "pourquoi les gens ont-ils cessé d'y croire ?" },
            { "Why,", "Eh bien," },
            { " simply because there was no resurrection to speak\r\nof.", " pour la simple raison qu'il n'y eut aucune résurrection." },
            { " As was established in fact.", " Les faits l'ont rigoureusement établi." },
            { "What,", "Comment," },
            { "what do you mean by", "que voulez-vous dire par" },
            { "‘no resurrection’?", "« aucune résurrection » ?" },
            { "The police investigated the grave in Lowgate Cemetery", "La police a inspecté la sépulture au cimetière de Lowgate" },
            { "and published their findings.", "et a publié ses conclusions." },
            { "The convict's body was found to be buried exactly where\r\nit had been following the execution.", "Le cadavre du supplicié reposait exactement à l'endroit où il avait été inhumé après l'exécution." },
            { "No!", "Ce n'est pas possible !" },
            { "But that would mean Mr Drebber...", "Mais cela signifierait que monsieur Drebber..." },
            { "...must have lied to the police and the newspapers!", "...aurait menti à la police ainsi qu'aux journaux !" },
            { "...That would appear to be the only logical explanation,", "...Cela semble être l'unique explication rationnelle," },
            { "yes.", "en effet." },
            { "The young man subsequently vanished from society", "Le jeune homme s'est ensuite volatilisé sans laisser de trace" },
            { " and\r\nnothing has been heard of him since.", " et nul n'a plus jamais entendu parler de lui." },
            { "It's rather striking, then,", "Il est pour le moins singulier," },
            { "that he should resurface now...", "qu'il refasse surface précisément aujourd'hui..." },
            { "don't you think?", "ne trouvez-vous pas ?" },
            { "(Of course the convicted murderer couldn't really have\r\ncome back to life.", "(Il est évident qu'un meurtrier pendu ne pouvait pas ressusciter." },
            { " That's not possible.)", " C'est scientifiquement impossible.)" },
            { "(But Drebber's hair is unusually white,", "(Mais les cheveux de Drebber sont d'une blancheur anormale," },
            { " and if that really\r\ndid happen overnight as a result of shock...)", " et si cela est vraiment survenu en une nuit sous l'effet du choc...)" },
            { "(...it's hard to believe the incident", "(...difficile de croire que toute cette histoire" },
            { " was an out-and-out\r\nlie...)", " n'était qu'un tissu de mensonges...)" }
        });

        // [24] KEY:BB\script\output\_sce02_chr030_01_eng#1
        add(@"BB\script\output\_sce02_chr030_01_eng#1", new string[,] {
            { "When I first arrived back in Japan...", "Lorsque je suis rentrée au Japon..." },
            { "I really thought I'd\r\nnever be allowed to return to Britain.", "j'étais persuadée qu'on ne m'autoriserait plus jamais à revenir en Grande-Bretagne." },
            { "But curiously...", "Mais curieusement..." },
            { "...after that awful trial at the Supreme Court,", "...après ce terrible procès à la Cour suprême," },
            { "Father's\r\nmood changed entirely.", "l'attitude de Père a changé du tout au tout." },
            { "The awful trial?", "Le terrible procès ?" },
            { "Oh yes...", "Ah oui..." },
            { "...for the murder of Jezaille Brett.", "...pour le meurtre de Jezaille Brett." },
            { "Ooh, ", "Ooh, " },
            { "you dressed as a man then,", "tu t'étais déguisée en homme à ce moment-là," },
            { " didn't you, Susie?", "n'est-ce pas, Susato ?" },
            { "Well...yes...since women are forbidden in the\r\ncourtroom.", "Eh bien... oui... vu que les femmes sont interdites au tribunal." },
            { "I had no choice.", "Je n'avais point d'autre choix." },
            { "Wow!", "Ouah !" },
            { "Amazing!", "Incroyable !" },
            { "I wish I'd seen it!", "J'aurais tant voulu assister à ça !" },
            { "Don't you,", "Pas toi," },
            { "Runo?", "Ryuno ?" },
            { "Um...yes, I...suppose so.", "Euh... oui, je... présume que oui." },
            { "I want to play at being a lawyer now!", "Moi aussi je veux jouer à l'avocate à présent !" },
            { "I could wear a false moustache, maybe!", "Je pourrais porter une fausse moustache, qui sait !" },
            { "...I don't think any moustache could hide the fact that", "...Je doute qu'une moustache suffise à masquer le fait que" },
            { "you're just ten years old, Iris.", "tu n'as que dix ans, Iris." },
            { "There's something else I've been wanting to ask you,", "Il y a une autre question que je brûlais de vous poser," },
            { "Miss Susato...", "mademoiselle Susato..." },
            { "It's about the real reason why Professor Mikotoba\r\nsummoned you back to Japan.", "C'est à propos de la véritable raison pour laquelle le professeur Mikotoba vous a rappelée au Japon." },
            { "You said in your letter it was something to do with that\r\nconvict's loot we found in Mr Natsume's lodgings...", "Vous disiez dans votre lettre que c'était lié au butin de ce criminel trouvé chez M. Natsume..." },
            { "That's right.", "C'est exact." },
            { " The very large dog collar we found with the\r\n‘B’ emblem on it.", " L'énorme collier de chien orné de l'emblème « B »." },
            { "It seems Mr Natsume included a drawing of the collar in\r\nthe report he submitted about his time in Britain.", "Il semble que M. Natsume ait inclus un croquis de ce collier dans le rapport remis sur son séjour britannique." },
            { "I understand that when Father saw the report,", "J'ai cru comprendre que lorsque Père a découvert ce croquis," },
            { "he turned\r\nas white as a sheet.", "il est devenu blanc comme un linge." },
            { "(Why would that be, then?)", "(Pourquoi donc aurait-il eu une telle réaction ?)" },
            { "Father came to Britain himself, of course.", "Père a séjourné en Grande-Bretagne lui aussi, jadis." },
            { " To study.", " Pour ses études." },
            { "It was some time ago now,", "Il y a bien longtemps de cela," },
            { "but he stayed for six years.", "mais il y est resté six années entières." },
            { "I can only imagine that something must have happened\r\nduring that time.", "J'ai la certitude qu'il s'est produit un événement marquant durant cette période." },
            { "But if he refuses to tell me what it was, ", "Mais s'il persiste à garder le silence, " },
            { "then I intend to\r\nfind the answers for myself.", "j'ai la ferme intention de percer le mystère par moi-même." },
            { "And I've decided that I, for one,", "Et pour ma part, j'ai juré" },
            { "won't keep any more\r\nsecrets.", "de ne plus dissimuler le moindre secret." },
            { "Oh! Susie...", "Oh ! Susato..." },
            { "(That's a very meaningful look Susato-san's giving Iris\r\nthere...)", "(Susato lance un regard très appuyé à Iris...)" }
        });

        // [25] KEY:BB\script\output\_sce02_chr030_01_eng#2
        add(@"BB\script\output\_sce02_chr030_01_eng#2", new string[,] {
            { "Lord Stronghart mentioned something about that\r\nsymposium, too.", "Lord Harry Caine a évoqué ce fameux symposium, lui aussi." },
            { "I think he said that investigative authorities from forty\r\ndifferent countries would attend.", "Il disait que des représentants des autorités de quarante pays différents y participeraient." },
            { "Yes,", "Oui," },
            { " and from Japan,", " et pour le Japon," },
            { " my father and Judge Jigoku have\r\nbeen invited.", " mon père et le juge Jigoku ont été conviés." },
            { "It's something of an honour,", "C'est un insigne honneur," },
            { "I believe.", "je crois." },
            { "Well,", "Après tout," },
            { " Professor Mikotoba is the leading expert in forensic\r\nmedicine in our country, after all.", " le professeur Mikotoba est la plus haute autorité en médecine légale de notre empire." },
            { "But...who's the other person you mentioned?", "Mais... qui est l'autre personne que vous avez citée ?" },
            { "A judge,", "Un juge," },
            { "did you say?", "disiez-vous ?" },
            { "His Excellency, Judge Seishiro Jigoku.", "Son Excellence le juge Seishiro Jigoku." },
            { "You've met him, Mr Naruhodo.", "Vous l'avez déjà rencontré, monsieur Naruhodo." },
            { "Last year...", "L'an dernier..." },
            { "in the Supreme Court...", "à la Cour suprême..." },
            { "You can't possibly have forgotten!", "Vous ne pouvez pas l'avoir oublié !" },
            { "That terrible trial of yours,", "Ce terrible procès où vous comparussiez," },
            { " when you were accused of\r\nmurder.", " accusé d'assassinat." },
            { "Aaah... Yes, I...try to think of that as a positive turning\r\npoint in my life these days...", "Aaah... Oui, j'essaie de considérer cela comme un tournant salvateur dans ma vie à présent..." },
            { "it was Judge Jigoku who presided over that trial.", "c'est le juge Jigoku qui présidait cette audience." },
            { "...If I'm perfectly honest,", "...Pour être tout à fait franc," },
            { "I'd be happy never to see that\r\nman's face again in my life.", "je me passerais volontiers de revoir le visage de cet homme un jour." },
            { "Oh, well anyway...as Father was invited to the\r\nsymposium,", "Enfin quoi qu'il en soit... comme Père était invité au symposium," },
            { " he agreed to me returning to Britain, too.", " il a consenti à ce que je revienne en Grande-Bretagne moi aussi." },
            { "He won't actually arrive until next month, but...", "Il ne débarquera que le mois prochain, mais..." },
            { "I couldn't wait!", "je ne pouvais pas attendre !" },
            { "So I pleaded with him,", "Alors j'ai tant insisté auprès de lui" },
            { " and in the end he agreed to me\r\ngoing on ahead!", "qu'il a fini par m'autoriser à partir en éclaireur !" },
            { "Yes, about the symposium...", "Oui, à propos de ce symposium..." },
            { "It seems as though Lord Stronghart has put in an awful\r\nlot of work to make it happen.", "Il semble que Lord Harry Caine se soit démené sans compter pour organiser l'événement." },
            { "It's obviously very important.", "C'est manifestement crucial." },
            { "I believe it is, yes.", "C'est bien le cas, en effet." },
            { " As I understand it,Lord Stronghart\r\norganised the entire event himself.", " À ce que j'ai compris, Lord Harry Caine a tout orchestré de sa propre initiative." },
            { " As I understand it, Lord Stronghart\r\norganised the entire event himself.", " À ce que j'ai compris, Lord Harry Caine a tout orchestré de sa propre initiative." },
            { "I think...he's hoping that by achieving exceptional results,", "Je crois... qu'il espère qu'en obtenant un succès retentissant," },
            { "he'll get the job of Attorney General.", "il sera promu au poste de ministre de la Justice." },
            { "The most senior position in the British justice system...", "La plus haute fonction de tout le système judiciaire britannique..." },
            { "He's hoping to use his power to create the world's finest\r\npolicing institution.", "Il convoite ce pouvoir pour bâtir la plus puissante force de police du monde." },
            { "That's what Father said anyway!", "C'est en tout cas ce que Père m'a confié !" },
            { "Apparently it's Lord Stronghart's lifelong ambition!", "Il paraît que c'est l'ambition suprême de toute la vie de Lord Harry Caine !" },
            { "(Does Professor Mikotoba know Lord Stronghart\r\npersonally then, I wonder...?)", "(Le professeur Mikotoba connaîtrait-il Lord Harry Caine personnellement...?)" },
            { "Actually, Lord Stronghart gave me a long speech all about\r\nthis very subject only yesterday.", "À vrai dire, Lord Harry Caine m'a débité un interminable discours là-dessus hier encore." },
            { "But I sort of lost the will to live early on and didn't really\r\nlisten to much of it.", "Mais j'ai rapidement décroché et je n'en ai pas retenu grand-chose." },
            { "...How trying for you.", "...Quelle épreuve cela a dû être pour vous." }
        });

        // [26] KEY:BB\script\output\_sce02_chr030_01_eng#3
        add(@"BB\script\output\_sce02_chr030_01_eng#3", new string[,] {
            { "(Jezaille Brett...)", "(Jezaille Brett...)" },
            { "(The woman whose unforgivable actions ended in me\r\nbeing wrongly accused of a crime I didn't commit.)", "(La femme dont les infâmes agissements m'ont valu d'être faussement accusé d'un crime.)" },
            { "(The murder of Dr John H. Wilson.)", "(Le meurtre du Dr John H. Wilson.)" },
            { "Yes, Jezaille Brett... That's a name I won't forget for as\r\nlong as I live.", "Oui, Jezaille Brett... Un nom gravé dans ma mémoire à tout jamais." },
            { "The extraordinary thing is, though...", "La chose la plus stupéfiante pourtant..." },
            { "...it seems it's a name we should all forget.", "...c'est qu'il semblerait que ce nom n'ait jamais dû exister." },
            { "Sorry?", "Pardon ?" },
            { "Since the incident, our government's intelligence services\r\nhave been investigating Miss Brett.", "Depuis l'affaire, les services de renseignement de notre gouvernement ont enquêté sur Miss Brett." },
            { "But it turns out that an Englishwoman by the name of\r\nJezaille Brett didn't actually exist.", "Or il s'avère qu'aucune citoyenne britannique du nom de Jezaille Brett n'a jamais existé." },
            { "D-Didn't exist?", "N-N'a jamais existé ?" },
            { "how can that be?!", "comment cela se peut-il ?!" },
            { "It was a pseudonym.", "C'était un pseudonyme." },
            { " Her real name was Shinn.", " Son vrai nom de famille était Shinn." },
            { "And she wasn't a visiting student, either.", "Et elle n'avait rien d'une étudiante étrangère." },
            { " That was a front.", " Ce n'était qu'une couverture." },
            { "A front?", "Une couverture ?" },
            { "Who, who on earth was she, then?", "Mais qui... qui était-elle au juste ?!" },
            { "Miss A. Shinn.", "Miss A. Shinn." },
            { "Her name is literally all our intelligence\r\nservices have been able to ascertain about her.", "Ce nom est la seule et unique chose que nos services secrets aient pu glaner à son sujet." },
            { "Nobody knows why, or even how, she came to be in\r\nJapan.", "Nul ne sait pourquoi, ni comment elle a débarqué au Japon." },
            { "It's a complete mystery.", "Le mystère reste total." },
            { "But, but that makes no sense!", "Mais... ça n'a aucun sens !" },
            { "It's no easy task to be\r\naccepted as a foreign student anywhere!", "Obtenir un visa d'étudiant étranger n'a rien d'une sinécure !" },
            { "What could the woman have been up to?!", "Que diable tramait cette femme ?!" },
            { "I'm afraid I really don't know.", "Je l'ignore totalement, hélas." },
            { "The only thing we can be sure of...", "La seule chose dont nous puissions être certains..." },
            { "...is that she had some business in our country that we\r\ndon't yet understand.", "...c'est qu'elle poursuivait un dessein secret sur notre sol qui nous échappe encore." },
            { "And now she's been killed...", "Et voilà qu'elle a été assassinée..." },
            { "...while all the questions surrounding her existence remain unanswered!", "...emportant toutes les réponses dans la tombe !" },
            { "...I'm afraid so.", "...Hélas oui." },
            { "A. Shinn...", "A. Shinn..." },
            { "(Who on earth was she?)", "(Qui pouvait-elle bien être ?)" },
            { "(And why do I feel as though...I've heard that name before\r\nsomewhere...?)", "(Et pourquoi ai-je l'étrange impression... d'avoir déjà entendu ce nom quelque part...?)" }
        });

        // [27] KEY:BB\script\output\_sce02_chr030_01_eng#4
        add(@"BB\script\output\_sce02_chr030_01_eng#4", new string[,] {
            { "After my friend Rei's trial...", "Après le procès de mon amie Rei..." },
            { "...the reporter who actually killed Miss Brett said\r\nsomething very strange.", "...le journaliste qui a ôté la vie à Miss Brett a tenu des propos bien étranges." },
            { "I know the truth!", "Je connais la vérité !" },
            { "I know you had a hand in what went on!", "Je sais que vous avez trempé dans toute cette histoire !" },
            { "In that visiting student's fate!", "Dans le sort de cet étudiant étranger !" },
            { "Nobody here in Japan knows anything about it!", "Personne ici au Japon n'est au courant !" },
            { "They don't know that the guy never made it to England!", "Ils ignorent que le bougre n'a jamais posé le pied en Angleterre !" },
            { "That he died on that steamship!", "Qu'il est mort à bord de ce vapeur !" },
            { "And that he'll never–", "Et qu'il ne pourra jamais..." },
            { "Obviously, I couldn't ask him to elaborate at the time...", "Bien sûr, je ne pouvais pas lui demander d'en dire davantage sur le coup..." },
            { "...but later I visited the man in his prison cell and asked\r\nhim what he was going to say about Kazuma-sama.", "...mais plus tard, je suis allée l'interroger dans sa cellule sur ce qu'il savait au sujet de Monsieur Kazuma." },
            { "And what did you learn?!", "Et qu'avez-vous appris ?!" },
            { "After he died on the voyage to Great Britain...", "Après son trépas durant la traversée..." },
            { "...his body should have been unladen at the port of Hong\r\nKong and passed into the care of the consulate staff there.", "...sa dépouille devait être débarquée au port de Hong Kong et confiée aux soins du consulat." },
            { "Should have been?", "Devait l'être ?" },
            { "Well, it turns out...that his body never arrived.", "Or, il s'est avéré... que son cercueil n'est jamais arrivé à destination." },
            { "It just...disappeared.", "Il s'est... volatilisé." },
            { "Kazuma's body...vanished?", "Le corps de Kazuma... s'est volatilisé ?" },
            { "Our government tried to cover the fact up, it seems.", "Notre gouvernement a cherché à étouffer l'affaire, semble-t-il." },
            { "They erected a grave on the cliffs by our home town...", "Ils ont dressé une sépulture sur la falaise près de notre ville natale..." },
            { "Except...Kazuma-sama isn't there.", "Sauf que... la tombe de Monsieur Kazuma est vide." },
            { "Did, did Professor Mikotoba know about this?", "Le... le professeur Mikotoba était-il au courant ?" },
            { "It would seem that he did.", "Il semblerait bien que oui." },
            { "But...he didn't tell me.", "Mais... il m'a caché la vérité." },
            { "They're still investigating what happened to\r\nKazuma-sama's body as we speak.", "Des investigations sont toujours en cours pour savoir ce qu'il est advenu de son corps." },
            { "I, I just don't believe it...", "Je... je n'arrive pas à y croire..." },
            { "(And what is this acute feeling of apprehension I have all\r\nof a sudden?)", "(D'où vient cette soudaine et terrible angoisse qui m'étreint...?)" }
        });

        // [28] KEY:BB\script\output\_sce02_chr030_01_eng#5
        add(@"BB\script\output\_sce02_chr030_01_eng#5", new string[,] {
            { "Thinking back now, some of the things that happened on\r\nthe SS Burya were definitely strange.", "En y repensant, les événements survenus à bord de l'Albatros étaient pour le moins étranges." },
            { "I mean, after he died, we never saw his body again, did\r\nwe?", "Je veux dire, après sa mort, nous n'avons plus jamais revu son corps, n'est-ce pas ?" },
            { "Could it be...?", "Se pourrait-il... ?" },
            { "Could it be...that he's actually still alive?", "Se pourrait-il... qu'il soit en réalité toujours vivant ?" },
            { "Stop it, Mr Naruhodo!", "Cessez, monsieur Naruhodo !" },
            { "It's too much to bear!", "C'est insupportable !" },
            { "I'm sorry, I didn't mean to...", "Pardonnez-moi, je ne voulais pas vous froisser..." },
            { "Just thinking about the possibility pains me.", "Rien que d'envisager cette éventualité m'est un déchirement." },
            { "So very much.", "Tellement douloureux." },
            { "Cast your mind back for a moment, Mr Naruhodo...", "Remémorez-vous la scène un instant, monsieur Naruhodo..." },
            { "When Kazuma-sama was discovered, Mr Sholmes was\r\nthere, wasn't he?", "Quand Monsieur Kazuma a été découvert, monsieur Holmes était sur les lieux, n'est-ce pas ?" },
            { "And he definitely examined the body.", "Et il a indubitablement ausculté son corps." },
            { "I remember it clearly.", "Je m'en souviens très distinctement." },
            { "You're, you're right...", "Vous... vous avez raison..." },
            { "So if Kazuma hadn't actually been dead at all...", "Si Kazuma n'était en vérité point mort du tout..." },
            { "...it would mean that Mr Sholmes had lied to us.", "...cela signifierait que monsieur Holmes nous aurait menti." },
            { "But there's no reason why he would possibly have done\r\nsuch a thing.", "Mais il n'y a pas la moindre raison pour qu'il ait fait une telle chose." },
            { "I, I suppose that's true, yes...", "J-Je suppose que c'est vrai, oui..." },
            { "The idea that he might still be alive somewhere...", "L'idée qu'il puisse être vivant quelque part..." },
            { "It wants to fill me with hope, but I can't let it.", "Elle m'emplit d'espérance, mais je m'interdis d'y croire." },
            { "Because if it turned out not to be true...", "Car si tout cela devait s'avérer faux..." },
            { "...then I'd be back at the bottom of that awful pit of despair\r\nagain.", "...je replongerais alors au plus profond d'un indicible désespoir." },
            { "I'm...I'm terrified of what that might do to me...", "J'ai... j'ai si peur de ce que j'endurerais..." },
            { "Oh, Miss Susato...", "Oh, mademoiselle Susato..." },
            { "(I know she's given the idea the thought it deserves.", "(Je sais qu'elle a mûrement pesé le pour et le contre." },
            { "It's Susato-san we're talking about, after all.)", "C'est de Susato dont il s'agit, après tout.)" },
            { "(So I probably shouldn't push it now...)", "(Mieux vaut ne pas insister pour le moment...)" }
        });

        // [29] KEY:BB\script\output\_sce02_chr030_01_eng#7
        add(@"BB\script\output\_sce02_chr030_01_eng#7", new string[,] {
            { "Miss Susato!", "Mademoiselle Susato !" },
            { "Do you see...this?!", "Voyez-vous... ceci ?!" },
            { "...You have such great expectation in your eyes,Mr Naruhodo.", "...Je lis un tel espoir dans vos yeux, monsieur Naruhodo." },
            { "...You have such great expectation in your eyes, Mr Naruhodo.", "...Je lis un tel espoir dans vos yeux, monsieur Naruhodo." },
            { " But I'm afraid...", " Mais je crains..." },
            { "...nothing particularly useful comes to mind at all.", "...que rien de particulièrement concluant ne me vienne à l'esprit." },
            { "Oh. Sorry.", "Oh. Pardonnez-moi." },
            { "I'm, I'm not sure what I was expecting, really.", "Je... je ne sais pas trop à quoi je m'attendais au juste." }
        });

        // [30] KEY:BB\script\output\_sce02_chr030_01_eng#8
        add(@"BB\script\output\_sce02_chr030_01_eng#8", new string[,] {
            { "You're still taking good care of that armband, I see.", "Je vois que vous prenez grand soin de ce brassard." },
            { "I'm so pleased.", "J'en suis ravie." },
            { "Well yes. It feels like I wouldn't be me without it now, to\r\nbe honest.", "Eh bien oui. Pour être honnête, j'aurais l'impression de ne plus être moi-même sans lui." },
            { "...Oh dear. There seems to be a thread coming loose just\r\nthere, look.", "...Oh là là. On dirait qu'un fil commence à s'effilocher juste ici, regardez." },
            { "I'd be only too happy to mend it for you, Mr Naruhodo.", "Je me ferai un plaisir de le recoudre pour vous, monsieur Naruhodo." },
            { "Thank you...", "Merci..." },
            { "I must have scraped it against something again.", "J'ai encore dû l'accrocher quelque part." },
            { "I'm always doing that.", "Je n'arrête pas de faire ça." },
            { "Then take better care of it, please.", "Dans ce cas, ménagez-le un peu plus, je vous prie." },
            { "(...It was all going so well...until I ruined it.)", "(...Tout se passait si bien... jusqu'à ce que je gâche tout.)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part1_B.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part1_B written.");
    }
}
