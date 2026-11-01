using System;
using System.Collections.Generic;

namespace TranslatorAct5 {
    public partial class Program {
        public static void RegisterPart2() {
            // Clé 70
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#19"] = s => {
                s = s.Replace("Oh dear, this is most troubling... But surely the waxwork\nthe man stole is nothing to do with the coroner, is it?", "Oh ciel, c'est fort troublant... Mais la statue de cire\nque cet homme a volée n'a sûrement rien à voir avec le médecin légiste, n'est-ce pas ?");
                return s;
            };

            // Clé 71
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#20"] = s => {
                s = s.Replace("I have had my own problems with members of the police.\nI do not trust them much...", "J'ai eu mes propres démêlés avec les forces de police.\nJe ne leur fais guère confiance...");
                return s;
            };

            // Clé 72
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#21"] = s => {
                s = s.Replace("I've seen no rigorous proof that this waxwork was ever\ninside the birdcage. It's conjecture!", "Je n'ai vu aucune preuve rigoureuse que cette statue ait jamais\nété dans cette volière. Ce n'est que pure conjecture !");
                return s;
            };

            // Clé 73
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#22"] = s => {
                s = s.Replace("The presence of that piece of glass leaves me in little\ndoubt that the waxwork was indeed inside that birdcage.", "La présence de ce morceau de verre ne me laisse guère\nde doute : la statue de cire était bel et bien dans cette volière.");
                return s;
            };

            // Clé 74
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#23"] = s => {
                s = s.Replace("Accusin' someone without right evidences?\nEe's not a proper job, is ee? I won't 'ave it!", "Accuser q'qu'un sans vraies preuves ?\nC'est pas du travail propre, ça ! J'peux pas tolérer ça !");
                return s;
            };

            // Clé 75
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#24"] = s => {
                s = s.Replace("I've known that woman for years!\nShe'd never be an accomplice to anything!", "Je connais cette femme depuis des lustres !\nElle s'rait jamais complice de quoi que ce soit !");
                return s;
            };

            // Clé 76
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#25"] = s => {
                s = s.Replace("She was Courtney Stevens back when I knew her, of\ncourse. A legendary coroner, even then.", "Elle s'appelait Cyriella Stevens à l'époque où j'l'ai connue, bien\nsûr. Une légende de la médecine légale, déjà à l'époque.");
                return s;
            };

            // Clé 77
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#27"] = s => {
                s = s.Replace("But we're only just starting to understand this case!", "Mais nous commençons à peine à cerner cette affaire !");
                s = s.Replace("W-", "Q-");
                s = s.Replace("What are you reading there, sir?!", "Que lisez-vous donc là, monsieur ?!");
                s = s.Replace("The man behind those murders on Solar Pons Street", "L'auteur de ces meurtres sur Solar Pons Street");
                s = s.Replace("was\ncaught in two days flat.", "a été\ncapturé en deux jours chrono.");
                s = s.Replace("That's real policing for you.", "Ça, c'est du vrai travail de police.");
                s = s.Replace("That's...", "Ce n'est...");
                s = s.Replace("really not relevant to this case,", "vraiment pas pertinent pour cette affaire,");
                s = s.Replace("is it?", "si ?");
                s = s.Replace("You're wrong there.", "C'est là que vous faites erreur.");
                s = s.Replace("Because it was", "Car c'était la");
                s = s.Replace("Dr Sithe", "Dre Pétrie");
                s = s.Replace("in charge of examining the\nbodies.", "qui était chargée d'examiner les\ncorps.");
                s = s.Replace("And it was evidence arising from her work", "Et ce sont les preuves issues de son travail");
                s = s.Replace("that led to the\narrest of the scoundrel responsible.", "qui ont permis\nl'arrestation de la fripouille responsable.");
                s = s.Replace("Oh...", "Oh...");
                s = s.Replace("That's right,", "Parfaitement,");
                s = s.Replace("‘Oh.’", "« Oh. »");
                s = s.Replace("That woman is at the forefront of this\ncountry's fight against crime.", "Cette femme est aux avant-postes de la\nlutte de notre pays contre le crime.");
                s = s.Replace("The idea that she's somehow involved in this murky\nbusiness", "L'idée qu'elle soit mêlée de près ou de loin à cette sale\nhistoire");
                s = s.Replace("is a load of old tosh.", "est un tissu d'âneries pures et simples.");
                s = s.Replace("(I thought it was up to me to ‘press’ the jurors,", "(Je croyais que c'était à moi de « presser » les jurés,");
                s = s.Replace("not the\nother way around...)", "et non\nl'inverse...)");
                return s;
            };

            // Clé 78
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#28"] = s => {
                s = s.Replace("Why would you assume that?", "Pourquoi supposez-vous cela ?");
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("quite simply because...that unsettling swindler has\nno relationship with the woman,", "tout simplement parce que... cet inquiétant escroc n'a\naucun lien avec cette femme,");
                s = s.Replace("does he?", "n'est-ce pas ?");
                s = s.Replace("True.", "C'est vrai.");
                s = s.Replace("As it stands,", "En l'état,");
                s = s.Replace("we don't know of any connection.", "nous ne connaissons aucun lien.");
                s = s.Replace("Oh gosh,", "Mon Dieu,");
                s = s.Replace("but it would be delightfully romantic if they\nwere somehow to have a mutual interest in the waxwork.", "mais ce serait délicieusement romanesque s'ils\npartageaient un intérêt commun pour cette statue de cire.");
                s = s.Replace("Romantic?", "Romanesque ?");
                s = s.Replace("A woman of society such as myself", "Une femme du monde comme moi");
                s = s.Replace("views everything in\nterms of relationships, you know.", "voit tout sous\nl'angle des relations humaines, voyez-vous.");
                s = s.Replace("you learn something new every day!", "on en apprend de belles tous les jours !");
                s = s.Replace("(Even if you don't want to.)", "(Même si on s'en passerait bien.)");
                s = s.Replace("One might wonder about a possible relationship", "On pourrait s'interroger sur une possible relation");
                s = s.Replace("between\nthe defendant and this coroner woman.", "entre\nl'accusé et cette femme légiste.");
                s = s.Replace("Or perhaps", "Ou peut-être");
                s = s.Replace("between the defendant and the handsome\nprosecutor just there.", "entre l'accusé et le si séduisant\nprocureur que voici.");
                s = s.Replace("(This woman...", "(Cette femme...");
                s = s.Replace("may be more astute than I've been giving\nher credit for.)", "est peut-être plus perspicace que je ne le\npensais.)");
                s = s.Replace("If that's the woman's stance...", "Si telle est la position de cette dame...");
                s = s.Replace("...then perhaps", "... alors peut-être");
                s = s.Replace("demonstrating some connection between\nthe waxwork and Dr Sithe would be enough...", "que démontrer un lien entre la statue\nde cire et la Dre Pétrie suffirait...");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("I agree.", "je suis d'accord.");
                s = s.Replace("As soon as we have even a whiff of a connection,", "Dès que nous aurons ne serait-ce que l'ombre d'un lien,");
                s = s.Replace("she'll", "elle");
                s = s.Replace("be\nthe first to know!", "sera\nla première informée !");
                return s;
            };

            // Clé 79
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#29"] = s => {
                s = s.Replace("What sort of problems?", "Quel genre de démêlés ?");
                s = s.Replace("Let's just say we have run into each other on numerous\noccasions", "Disons que nous nous sommes croisés à maintes\nreprises");
                s = s.Replace("while I've been performing on the street.", "pendant que je me produisais dans la rue.");
                s = s.Replace("Right,", "D'accord,");
                s = s.Replace("I see.", "je vois.");
                s = s.Replace("Obviously", "Il va de soi");
                s = s.Replace("artists such as myself cannot appear on stage", "que des artistes comme moi ne peuvent se produire sur scène,");
                s = s.Replace("as we work in close proximity to our audiences.", "car nous travaillons au plus près de notre public.");
                s = s.Replace("So we perform our great magic in parks...", "Nous exécutons donc nos tours de magie dans les parcs...");
                s = s.Replace("on street\ncorners...", "au coin\ndes rues...");
                s = s.Replace("and the like.", "et autres lieux publics.");
                s = s.Replace("But the police use any excuse to make our lives difficult.", "Mais la police saisit le moindre prétexte pour nous compliquer la vie.");
                s = s.Replace("Sometimes", "Parfois,");
                s = s.Replace("they even cook up a story", "ils inventent même des histoires de toutes pièces");
                s = s.Replace("to extort monies\nfrom the poor.", "pour extorquer\nde l'argent aux pauvres gens.");
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("that's definitely not right.", "ce n'est assurément pas tolérable.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("and it is why I say that if you trust the police,", "et c'est pour cela que je dis : faire confiance à la police,");
                s = s.Replace("you\nwill have trouble.", "c'est\ncourir au désastre.");
                s = s.Replace("But here you are,", "Et pourtant, vous voilà,");
                s = s.Replace("claiming this waxwork model was\nstolen to star in an illusionary spectacular.", "affirmant que cette statue de cire a été\nvolée pour figurer dans un spectacle d'illusion.");
                s = s.Replace("The idea is so wild,", "L'idée est si saugrenue");
                s = s.Replace("I think I will take my chances and\nbelieve the authorities on this occasion.", "que je préfère encore accorder ma confiance\naux autorités pour cette fois.");
                s = s.Replace("(This is how the public at large view Scotland Yard, is it?)", "(C'est donc ainsi que l'opinion publique perçoit Scotland Yard ?)");
                s = s.Replace("Our own police force in Tokyo", "Notre propre police à Tokyo");
                s = s.Replace("is not even twenty years\nold yet, is it?", "a moins de vingt ans\nd'existence, n'est-ce pas ?");
                s = s.Replace("Perhaps we should view what's happened here in London", "Peut-être devrions-nous voir ce qui se passe à Londres");
                s = s.Replace("as a measure of what may happen at home.", "comme un avant-goût de notre avenir au pays.");
                s = s.Replace("Yes...", "Oui...");
                s = s.Replace("Like a Scotland Yardstick.", "Comme un véritable étalon de mesure.");
                s = s.Replace("(I wonder how a policeman would feel", "(Je me demande ce qu'éprouverait un policier");
                s = s.Replace("listening to the\nway this juror speaks about the force...)", "en entendant\nla façon dont ce juré parle des forces de l'ordre...)");
                s = s.Replace("(I'm sure he'd have", "(Je suis sûr qu'il aurait");
                s = s.Replace("a word or two", "deux ou trois mots");
                s = s.Replace("to say in response.)", "à répliquer.)");
                return s;
            };

            // Clé 80
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#30"] = s => {
                s = s.Replace("Do you have something to say in response to that...", "Avez-vous quelque chose à répondre à cela...");
                s = s.Replace("Mr Ottermole?!", "monsieur Ottermole ?!");
                s = s.Replace("Who are you calling a mass murderer?!", "Qui traitez-vous d'assassin sanguinaire ?!");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("Sorry,", "Pardon,");
                s = s.Replace("my mistake!", "mon erreur !");
                s = s.Replace("I,", "J'ai...");
                s = s.Replace("I got confused because I heard you look like him...", "j'ai confondu parce qu'on m'a dit que vous lui ressembliez...");
                s = s.Replace("I don't look anything like the man!", "Je ne ressemble en rien à cet individu !");
                s = s.Replace("You wanna be locked up, sonny?", "Tu veux qu'j't'embarque au trou, gamin ?");
                s = s.Replace("(Thanks, Mr Sholmes...)", "(Merci infiniment, monsieur Holmes...)");
                s = s.Replace("Perhaps we could move on...", "Peut-être pourrions-nous passer à autre chose...");
                s = s.Replace("I was really wondering if you had something you wanted\nto add", "Je me demandais surtout si vous souhaitiez ajouter\nquelque chose");
                s = s.Replace("in response to what juror number three just said.", "en réponse à ce que le juré numéro trois vient de déclarer.");
                s = s.Replace("And clearly", "Et de toute évidence,");
                s = s.Replace("you do.", "c'est le cas.");
                s = s.Replace("Back in my day...", "À mon époque...");
                s = s.Replace("Back in the good old days...", "Au bon vieux temps...");
                s = s.Replace("...it wasn't like this!", "... ce n'était pas comme ça !");
                s = s.Replace("What was it like, sir?", "Et comment était-ce alors, monsieur ?");
                s = s.Replace("We worked our fingers to the bone to earn the public's\ntrust, we did!", "On s'décarcassait jour et nuit pour mériter la confiance\ndu public, nous !");
                s = s.Replace("And by Jove we earnt it!", "Et par Jupiter, on l'avait méritée !");
                s = s.Replace("People respected us back then!", "Les gens nous respectaient, en ce temps-là !");
                s = s.Replace("Respected you?", "Vous respectaient ?");
                s = s.Replace("Hmph.", "Hmph.");
                s = s.Replace("No one would've called a coroner into question in them\ndays!", "Personne n'aurait osé remettre un légiste en question\nà cette époque !");
                s = s.Replace("A coroner's report", "Le rapport d'un médecin légiste");
                s = s.Replace("was the hallmark of an investigation\ndone right!", "était la marque d'une enquête\nmenée dans les règles de l'art !");
                s = s.Replace("Especially when Dr Courtney Stevens", "Surtout quand la Dre Cyriella Stevens");
                s = s.Replace("put her name to it!", "y apposait sa signature !");
                s = s.Replace("She was the best of the best!", "C'était la fine fleur de la profession !");
                s = s.Replace("And the apple of the force's eye!", "Et la prunelle des yeux de tout le Yard !");
                s = s.Replace("H-", "A-");
                s = s.Replace("Hold on a minute!", "Attendez une seconde !");
                s = s.Replace("What are you talking about?", "De quoi parlez-vous donc ?");
                s = s.Replace("Who's", "Qui est");
                s = s.Replace("Courtney Stevens", "Cyriella Stevens");
                s = s.Replace("Ah...", "Ah...");
                s = s.Replace("Sorry.", "Pardon.");
                s = s.Replace("Got a bit carried away there.", "J'me suis un peu emporté.");
                s = s.Replace("Stevens", "Stevens");
                s = s.Replace("is Dr Sithe's", "est le nom de jeune fille de la");
                s = s.Replace("maiden name", "Dre Pétrie");
                s = s.Replace("Her maiden name...", "Son nom de jeune fille...");
                s = s.Replace("(So that was before she was married...)", "(C'était donc avant son mariage...)");
                s = s.Replace("O' course,", "Bien sûr,");
                s = s.Replace("yes.", "oui.");
                s = s.Replace("Silly me.", "Quel étourdi.");
                s = s.Replace("It's Sithe now, isn't it?", "C'est Pétrie maintenant, n'est-ce pas ?");
                s = s.Replace("(Stevens...)", "(Stevens...)");
                s = s.Replace("(I'm sure I've seen that name somewhere recently...)", "(Je suis persuadé d'avoir vu ce nom quelque part récemment...)");
                s = s.Replace("Anyway!", "Bref !");
                s = s.Replace("The point is,", "Le fait est que");
                s = s.Replace("those were the great days of\npolicing!", "c'était le grand âge d'or de\nla police !");
                s = s.Replace("Not like now...", "Pas comme aujourd'hui...");
                s = s.Replace("Sorry to interrupt, sir...", "Désolé de vous interrompre, monsieur...");
                s = s.Replace("...but do you think you could change your statement to\ninclude that", "... mais pourriez-vous modifier votre déposition pour\ny inclure ce");
                s = s.Replace("name", "nom");
                s = s.Replace("Well, yes...", "Eh bien, oui...");
                s = s.Replace("I don't see why not.", "je n'vois pas d'inconvénient.");
                return s;
            };

            // Clé 81
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#31"] = s => {
                s = s.Replace("But you claimed the whole instantaneous kinesis\ndemonstration was a trick!", "Mais vous affirmiez que toute la démonstration de\ntéléportation n'était qu'un tour de passe-passe !");
                s = s.Replace("That I did.", "C'est exact.");
                s = s.Replace("But there's more than one way to pull a rabbit\nout of a hat,", "Mais il y a plus d'une façon de sortir un lapin\nd'un chapeau,");
                s = s.Replace("isn't there?", "n'est-ce pas ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("I grant you,", "Je vous l'accorde,");
                s = s.Replace("given that this cage appeared from amidst an\nexplosion,", "puisque cette cage est apparue au milieu d'une\nexplosion,");
                s = s.Replace("there'd have been no need to use a real person.", "il n'était nul besoin d'utiliser un être humain réel.");
                s = s.Replace("But if a waxwork had been used,", "Mais si une statue de cire a été utilisée,");
                s = s.Replace("the culprit could at least\nhave had the decency to make it look like the victim.", "le coupable aurait au moins\npu avoir la décence de lui donner les traits de la victime.");
                s = s.Replace("I'm not sure exactly how much criminals are governed\nby decency...", "Je ne suis pas certain que les criminels soient particulièrement\nguidés par la décence...");
                s = s.Replace("The point is,", "Le fait est que,");
                s = s.Replace("if you're going to make a claim about that\nwaxwork being inside the birdcage...", "si vous affirmez que cette statue\nde cire se trouvait dans cette volière...");
                s = s.Replace("...you need to give us some evidence.", "... vous devez nous en apporter la preuve.");
                s = s.Replace("Without that,", "Sans cela,");
                s = s.Replace("it's just not science!", "ce n'est pas de la science !");
                s = s.Replace("I suppose we should expect nothing less than a logical\nargument", "On n'en attendait pas moins d'un raisonnement logique");
                s = s.Replace("from a fellow of the Royal Society.", "de la part d'un membre de la Royal Society.");
                s = s.Replace("But that perhaps means his mind could be changed", "Cela signifie peut-être qu'il pourrait changer d'avis");
                s = s.Replace("if we\nmanaged to present suitable evidence...", "si nous\nparvenions à lui présenter une preuve adéquate...");
                return s;
            };

            // Clé 82
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#32"] = s => {
                s = s.Replace("(Evidence that the Professor waxwork was inside that\nbirdcage.", "(Une preuve attestant que la statue du Démon Assassin\nétait dans cette volière.");
                s = s.Replace("Hm...", "Hm...");
                s = s.Replace("Can I produce that or not?)", "Puis-je la produire ou non ?)");
                return s;
            };

            // Clé 83
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#33"] = s => {
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("I can state quite categorically, sir,", "je puis affirmer de façon tout à fait catégorique, monsieur,");
                s = s.Replace("that we have no\nsuch evidence at the present time!", "que nous n'avons aucune preuve de ce genre à l'heure actuelle !");
                s = s.Replace("That much", "C'était déjà");
                s = s.Replace("was abundantly clear before that brassy\nproclamation,", "parfaitement limpide avant cette proclamation\npéremptoire,");
                s = s.Replace("I assure you!", "je vous assure !");
                s = s.Replace("And why you can count on the fact", "Et voilà pourquoi vous pouvez être certain");
                s = s.Replace("that I shan't be\nchanging my leaning!", "que je ne changerai\npas d'avis !");
                s = s.Replace("Oh dear...", "Oh là là...");
                s = s.Replace("That proclamation was even brassier than\nyours, Mr Naruhodo.", "Cette réplique était encore plus péremptoire que la\nvôtre, M. Naruhodo.");
                s = s.Replace("(If only we had some evidence,", "(Si seulement nous avions une preuve,");
                s = s.Replace("things might be different,\nthough...)", "les choses pourraient être bien\ndifférentes...)");
                return s;
            };

            // Clé 84
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#34"] = s => {
                s = s.Replace("...Actually,", "... En vérité,");
                s = s.Replace("I have something I'd like you to see, sir.", "j'ai quelque chose que j'aimerais vous montrer, monsieur.");
                s = s.Replace("Oh?", "Oh ?");
                s = s.Replace("I must warn you that I firmly believe", "Je dois vous avertir que par principe,");
                s = s.Replace("it's only wise to\ntrust men in white coats.", "je n'accorde ma\nconfiance qu'aux hommes en blouse blanche.");
                s = s.Replace("So given your jet-black outfit,", "Ainsi, au vu de votre tenue d'un noir de jais,");
                s = s.Replace("I don't mind admitting to a\nsense of trepidation here.", "j'avoue ressentir\nune certaine appréhension.");
                s = s.Replace("(So you don't trust anyone in", "(Vous ne faites donc confiance à personne en");
                s = s.Replace("black", "noir");
                s = s.Replace("Looking in the mirror must be very trying...)", "Regarder dans un miroir doit être bien pénible...)");
                return s;
            };

            // Clé 85
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#35"] = s => {
                s = s.Replace("I do have some evidence that proves the waxwork was\ninside that birdcage.", "J'ai bel et bien une preuve attestant que la statue de cire était\ndans cette volière.");
                s = s.Replace("Namely...", "À savoir...");
                return s;
            };

            // Clé 86
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#36"] = s => {
                s = s.Replace("Let me start by showing you...", "Permettez-moi de commencer par vous montrer...");
                s = s.Replace("this!", "ceci !");
                s = s.Replace("It's an unimpressive opening,", "C'est une entrée en matière bien peu impressionnante,");
                s = s.Replace("if I'm honest.", "pour être honnête.");
                s = s.Replace("Ah, well,", "Ah, eh bien,");
                s = s.Replace("um...", "hum...");
                s = s.Replace("What comes next is the real point!", "C'est la suite qui compte vraiment !");
                s = s.Replace("It's already apparent", "Il apparaît déjà");
                s = s.Replace("that what comes next is equally\ndisappointing, Counsel.", "que la suite est tout aussi\ndécevante, maître.");
                s = s.Replace("Ugh...", "Argh...");
                s = s.Replace("(How about after that...?)", "(Et après cela... ?)");
                s = s.Replace("If the waxwork of the Professor was inside the second\nbirdcage...", "Si la statue de cire du Démon Assassin était dans la seconde\nvolière...");
                s = s.Replace("...I would assume that means", "... cela signifierait");
                s = s.Replace("it must have crashed into\nthe Crystal Tower.", "qu'elle s'est écrasée\ncontre la Tour de Cristal.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("that's right.", "c'est exact.");
                s = s.Replace("I'd managed to think it through to that\npoint myself.", "J'étais parvenu à cette conclusion moi-même.");
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("it's really only a tiny leap from there, I would think!", "il n'y a qu'un pas à franchir à partir de là, me semble-t-il !");
                return s;
            };

            // Clé 87
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#37"] = s => {
                s = s.Replace("What's that?", "Qu'est-ce donc ?");
                s = s.Replace("A piece of glass?", "Un morceau de verre ?");
                s = s.Replace("Though it's unusually thick for glass...", "Quoiqu'il soit singulièrement épais pour du verre...");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("it's a piece of broken glass that we found inside the\njacket on the waxwork.", "c'est un éclat de verre brisé que nous avons retrouvé\ndans la veste de la statue de cire.");
                s = s.Replace("As you say,", "Comme vous le soulignez,");
                s = s.Replace("it's not ordinary glass, though.", "ce n'est pas du verre ordinaire.");
                s = s.Replace("It's very thick,", "Il est particulièrement épais");
                s = s.Replace("and clearly made for extra strength.", "et conçu pour une résistance accrue.");
                s = s.Replace("Much like the special glass that was developed for the\nconstruction of the Crystal Tower.", "Tout comme le verre spécial qui a été mis au point pour\nla construction de la Tour de Cristal.");
                s = s.Replace("The Crystal To–", "La Tour de Cris...");
                s = s.Replace("Holy smoke!", "Grand Dieu !");
                s = s.Replace("Exactly!", "Exactement !");
                s = s.Replace("The centrepiece of the Great Exhibition,", "La pièce maîtresse de l'Exposition universelle,");
                s = s.Replace("where\nthe very incident we're talking about took place!", "là\nmême où s'est produit l'incident dont nous parlons !");
                s = s.Replace("On the day in question,", "Le jour en question,");
                s = s.Replace("the birdcage fell from above", "la volière est tombée d'en haut");
                s = s.Replace("and\nsmashed through a window of that special glass.", "et a\nfracassé une verrière faite de ce verre spécial.");
                s = s.Replace("From whence this small piece originated...", "D'où proviendrait ce petit morceau...");
                s = s.Replace("is that it?", "c'est bien cela ?");
                s = s.Replace("Precisely.", "Précisément.");
                s = s.Replace("So,", "Alors,");
                s = s.Replace("what do you say...", "qu'en dites-vous...");
                s = s.Replace("...now that clear evidence in support of the assertion", "... maintenant qu'une preuve irréfutable à l'appui de cette affirmation");
                s = s.Replace("has\nbeen placed before you?!", "vous\nest présentée ?!");
                s = s.Replace("Well, as I said,", "Eh bien, comme je l'ai dit,");
                s = s.Replace("I only trust men in white coats as a rule.", "je ne fais confiance par principe qu'aux hommes en blanc.");
                s = s.Replace("However...", "Toutefois...");
                s = s.Replace("...when the reasoning is sound,", "... lorsque le raisonnement est rigoureux,");
                s = s.Replace("it's fair to say colour\nshouldn't come into it.", "la couleur de\nl'habit ne saurait peser dans la balance.");
                s = s.Replace("In light of what you've shown me here,", "Au vu de ce que vous venez de me démontrer,");
                s = s.Replace("yes,", "oui,");
                s = s.Replace("I feel obliged\nto change my position on the matter.", "je me vois contraint\nde réviser ma position sur ce point.");
                s = s.Replace("In that case,", "En ce cas,");
                s = s.Replace("juror number four,", "juré numéro quatre,");
                s = s.Replace("you will amend your\nstatement now, please.", "veuillez rectifier votre\ndéposition sur-le-champ.");
                return s;
            };

            // Clé 88
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#38"] = s => {
                s = s.Replace("Thank you", "Merci");
                s = s.Replace("for reconsidering your position, sir.", "d'avoir reconsidéré votre position, monsieur.");
                s = s.Replace("Your words are misplaced, boy.", "Vos remerciements sont malvenus, jeune homme.");
                s = s.Replace("My opinion is governed\nby logic and science", "Mon jugement n'est dicté\nque par la logique et la science,");
                s = s.Replace("and nothing else.", "et rien d'autre.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("science is where you should direct your words of\ngratitude.", "c'est à la science que doivent s'adresser vos\nparoles de gratitude.");
                s = s.Replace("Ah...", "Ah...");
                s = s.Replace("What's the matter with you?!", "Qu'est-ce qui vous prend ?!");
                s = s.Replace("Too good to say some words\nof thanks", "Trop fier pour exprimer vos\nremerciements");
                s = s.Replace("to the mother of all academic subjects?!", "envers la mère de toutes les disciplines savantes ?!");
                s = s.Replace("(...What is it about scientists?", "(... Qu'ont-ils donc tous, ces scientifiques ?");
                s = s.Replace("Honestly.)", "Franchement.)");
                return s;
            };

            // Clé 89
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#39"] = s => {
                s = s.Replace("I've got to ask...", "Je me dois de vous demander...");
                s = s.Replace("why have you brought that corn into court\nwith you?", "pourquoi avoir apporté cet épi de maïs au\ntribunal avec vous ?");
                s = s.Replace("Colonel Cob?", "Le Colonel Épi ?");
                s = s.Replace("Ee's bin growin' back on the farm.", "Il poussait dans ma ferme.");
                s = s.Replace("Picked\n'im off on me way into town.", "J'l'ai\ncueilli en venant en ville.");
                s = s.Replace("Ee's a proper nibbler, ee is.", "C't'un régal à grignoter, oui !");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("the nibbling seems to be taking quite a while.", "ce grignotage semble prendre un certain temps.");
                s = s.Replace("Maybe it could wait until after the trial?", "Ne pourrait-il pas attendre la fin du procès ?");
                s = s.Replace("Ooh,", "Oh,");
                s = s.Replace("I don't like the sound o' that.", "j'aime pas trop c'que j'entends là.");
                s = s.Replace("You need colonels at times like these.", "On a grand besoin d'colonels dans des moments pareils.");
                s = s.Replace("Whenever I've summat big to decide,", "Chaque fois qu'j'ai un choix crucial à faire,");
                s = s.Replace("the colonels always\npoint me in the right direction, see.", "les colonels m'indiquent\ntoujours la bonne direction, voyez.");
                s = s.Replace("Y-", "V-");
                s = s.Replace("You're talking about", "Vous parlez...");
                s = s.Replace("your cob of corn?", "de votre épi de maïs ?");
                s = s.Replace("Nibble", "Un grain,");
                s = s.Replace("nobble", "deux grains,");
                s = s.Replace("guilty", "coupable");
                s = s.Replace("bobble,", "certain,");
                s = s.Replace("not", "non");
                s = s.Replace("out.", "demain.");
                s = s.Replace("...Perhaps", "... Peut-être");
                s = s.Replace("it's akin to fortune-telling with flower petals\nlike people do back home?", "est-ce semblable à l'effeuillage de marguerites\npour prédire l'avenir, comme chez nous ?");
                s = s.Replace("(So Professor Harebrayne's fate is to be decided", "(Ainsi, le destin du professeur Lonron va se jouer");
                s = s.Replace("by a cob\nof corn...)", "sur un épi\nde maïs...)");
                s = s.Replace("Could you not at least wait until we've had more time to\nfind the truth", "Ne pourriez-vous pas au moins attendre que nous ayons cherché\nla vérité");
                s = s.Replace("before deciding on the defendant's guilt?", "avant de sceller la culpabilité de l'accusé ?");
                s = s.Replace("I don't know about that.", "j'sais pas trop.");
                s = s.Replace("Me tum's awfully full already.", "J'ai déjà l'estomac bien rempli.");
                s = s.Replace("(A-", "(C'est épi-");
                s = s.Replace("maize-", "");
                s = s.Replace("ing...)", "que...)");
                return s;
            };

            // Clé 90
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#40"] = s => {
                s = s.Replace("Um...", "Hum...");
                s = s.Replace("the order of things seems to have changed around\nhere for some reason...", "l'ordre des choses semble avoir changé par ici\npour une raison inconnue...");
                s = s.Replace("I'm a copper, lad.", "J'suis un flic, petit.");
                s = s.Replace("It's a copper's discretion to bend the\nrules sometimes,", "C'est à la discrétion d'un agent de tordre les\nrègles parfois,");
                s = s.Replace("when needs must.", "quand la nécessité l'impose.");
                s = s.Replace("What's wrong with that?!", "Qu'est-ce qu'y a d'mal à ça ?!");
                s = s.Replace("(...Where do I start?)", "(... Par où commencer ?)");
                s = s.Replace("I've been working at the Yard", "J'ai servi à Scotland Yard");
                s = s.Replace("for forty odd years!", "pendant plus de quarante ans !");
                s = s.Replace("That's...", "C'est...");
                s = s.Replace("even more than I thought.", "encore plus que je ne l'imaginais.");
                s = s.Replace("We've only had a metropolitan police service in town for\nseventy years, you know.", "Le service de la police métropolitaine n'existe que depuis\nsoixante-dix ans dans cette ville, savez-vous.");
                s = s.Replace("'Course,", "Bien sûr,");
                s = s.Replace("times have changed.", "les temps ont changé.");
                s = s.Replace("The public didn't trust\ncoppers back when I started.", "Le public n'faisait pas\nconfiance aux poulets quand j'ai commencé.");
                s = s.Replace("It was rough.", "C'était rude.");
                s = s.Replace("We had to fight crime,", "On devait lutter contre l'crime,");
                s = s.Replace("and we had to fight to win the\npublic's trust as well.", "et lutter aussi pour gagner la\nconfiance du public.");
                s = s.Replace("And win we did.", "Et on l'a gagnée.");
                s = s.Replace("Forensic science was in its infancy too,", "La médecine légale n'en était qu'à ses balbutiements,");
                s = s.Replace("even more than\nit is now.", "encore plus\nqu'aujourd'hui.");
                s = s.Replace("And she spearheaded the revolution!", "Et c'est elle qui a mené cette révolution !");
                s = s.Replace("Dr Sithe,", "La Dre Pétrie,");
                s = s.Replace("you mean?", "voulez-vous dire ?");
                s = s.Replace("That's right.", "C'est bien ça.");
                s = s.Replace("About ten years ago now, it was.", "Il y a dix ans environ.");
                s = s.Replace("When I was still a youngish bobby on the beat.", "Quand j'étais encore un jeune sergent de quartier.");
                s = s.Replace("That's when she started making a name for herself as a\ntop-class coroner.", "C'est là qu'elle a commencé à s'faire un nom comme\nlégiste d'élite.");
                s = s.Replace("And now look at her!", "Et regardez-la maintenant !");
                s = s.Replace("Head of the Forensic Investigation\nTeam.", "Cheffe de l'équipe de médecine\nlégale.");
                s = s.Replace("And a woman, no less.", "Et une femme, qui plus est.");
                s = s.Replace("Well", "Eh bien,");
                s = s.Replace("you won't hear me complain!", "vous n'm'entendrez pas m'plaindre !");
                s = s.Replace("It's what we all dreamt of back then, I tell you!", "C'est ce dont on rêvait tous à l'époque, j'vous l'dis !");
                s = s.Replace("...Could you tell me without holding that gun in the air?!", "... Pourriez-vous me le dire sans brandir cette arme en l'air ?!");
                s = s.Replace("We were all out to uphold justice, lad!", "On voulait tous faire triompher la justice, petit !");
                s = s.Replace("Full of vim, we were.", "Pleins d'ardeur qu'on était.");
                s = s.Replace("Full of vim.", "Pleins d'ardeur.");
                s = s.Replace("...That's coming across", "... Le message est passé");
                s = s.Replace("loud and clear.", "haut et fort.");
                return s;
            };

            // Clé 91
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#41"] = s => {
                s = s.Replace("She was legendary,", "Elle était légendaire,");
                s = s.Replace("was she?", "dites-vous ?");
                s = s.Replace("What did you say?!", "Qu'est-ce que tu viens d'dire ?!");
                s = s.Replace("Agh!", "Argh !");
                s = s.Replace("That woman", "Cette femme");
                s = s.Replace("is still the best coroner in the land!", "est toujours la meilleure légiste de tout le pays !");
                s = s.Replace("Head of the Forensic Investigation Team!", "Cheffe de l'équipe d'investigation médico-légale !");
                s = s.Replace("‘legendary’", "« légendaire »");
                s = s.Replace("was your description, sir,", "était votre propre terme, monsieur,");
                s = s.Replace("not mine.", "pas le mien.");
                s = s.Replace("Rubbish!", "Foutaises !");
                s = s.Replace("That word never passed my lips!", "Ce mot n'a jamais franchi mes lèvres !");
                s = s.Replace("I'd never describe anybody that way!", "J'décrirais jamais personne comme ça !");
                s = s.Replace("Ever!", "Jamais !");
                s = s.Replace("Not if they were still in the game!", "Pas tant qu'ils sont encore en service !");
                s = s.Replace("...I think the point you're trying to make", "... Je pense que l'idée que vous essayez d'exprimer");
                s = s.Replace("is that Dr Sithe\nis an extremely talented coroner.", "est que la Dre Pétrie\nest une légiste extrêmement talentueuse.");
                s = s.Replace("Would that be fair?", "C'est bien cela ?");
                s = s.Replace("It would!", "Tout à fait !");
                s = s.Replace("If it weren't for the fact", "Si ce n'était le fait");
                s = s.Replace("that you're trying to drag that\nlegendary woman's reputation through the mud!", "que vous essayez de traîner la réputation\nde cette femme légendaire dans la boue !");
                s = s.Replace("(I'm going to pretend", "(Je vais faire semblant");
                s = s.Replace("I didn't hear that ‘legendary’.)", "de ne pas avoir entendu ce « légendaire ».)");
                return s;
            };

            // Clé 92
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#43"] = s => {
                s = s.Replace("Those two statements", "Ces deux dépositions");
                s = s.Replace("clearly contradict each other!", "sont en contradiction flagrante !");
                s = s.Replace("Good gracious!", "Bonté divine !");
                s = s.Replace("To whose statements do you refer,", "À quelles dépositions faites-vous référence,");
                s = s.Replace("Counsel?", "maître ?");
                s = s.Replace("So...", "Eh bien...");
                s = s.Replace("juror number two.", "jurée numéro deux.");
                s = s.Replace("Oh gosh!", "Oh ciel !");
                s = s.Replace("Me?", "Moi ?");
                s = s.Replace("W-", "Q-");
                s = s.Replace("What can I do for you?", "Que puis-je faire pour vous ?");
                s = s.Replace("I presume that you heard what juror number six said in\nhis statement?", "J'imagine que vous avez entendu ce que le juré numéro six a\ndéclaré dans sa déposition ?");
                s = s.Replace("It's brought to light", "Cela a mis en lumière");
                s = s.Replace("the maiden name of the coroner,\nDr Sithe.", "le nom de jeune fille de la légiste,\nla Dre Pétrie.");
                s = s.Replace("Which in turn", "Ce qui à son tour");
                s = s.Replace("has revealed a connection that wasn't\napparent before.", "a révélé un lien qui n'était pas\névident auparavant.");
                s = s.Replace("Well naturally,", "Eh bien naturellement,");
                s = s.Replace("as a woman of society,", "en tant que femme du monde,");
                s = s.Replace("I find such\nconnections and relationships irresistible.", "je trouve ces\nintrigues et ces relations irrésistibles.");
                s = s.Replace("But oh golly...", "Mais grand Dieu...");
                s = s.Replace("I'm afraid I fail to see what you mean.", "je crains de ne point saisir où vous voulez en venir.");
                s = s.Replace("Dr Sithe's maiden name", "Le nom de jeune fille de la Dre Pétrie");
                s = s.Replace("is Stevens.", "est Stevens.");
                s = s.Replace("And through that name,", "Et à travers ce nom,");
                s = s.Replace("the coroner is very definitely\nlinked to the waxwork of the killer.", "la légiste est indubitablement\nliée à la statue de cire du tueur.");
                s = s.Replace("The defence", "La défense");
                s = s.Replace("has evidence to prove it.", "dispose d'une preuve pour l'attester.");
                s = s.Replace("My goodness!", "Ciel d'azur !");
                s = s.Replace("Evidence, you say?", "Une preuve, dites-vous ?");
                s = s.Replace("How,", "Comme...");
                s = s.Replace("how utterly enthralling!", "comme c'est passionnant !");
                s = s.Replace("the court cannot overlook that last remark.", "le tribunal ne saurait ignorer une telle affirmation.");
                s = s.Replace("I very much hope there is substance to your claim.", "J'espère vivement que vos allégations reposent sur du solide.");
                s = s.Replace("Of course,", "Bien entendu,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                s = s.Replace("I would ask the court to look at this:", "Je prie la cour d'examiner ceci :");
                return s;
            };

            // Clé 93
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#44"] = s => {
                s = s.Replace("The evidence", "La preuve");
                s = s.Replace("that clearly links Dr Sithe to the mass\nmurderer known as the Professor!", "reliant sans équivoque la Dre Pétrie à l'assassin\nsanguinaire surnommé le Démon Assassin !");
                return s;
            };

            // Clé 94
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#45"] = s => {
                s = s.Replace("Are you quite alright, sir?", "Vous sentez-vous bien, monsieur ?");
                s = s.Replace("All colour has drained from\nyour cheeks.", "Vos joues ont perdu toute\ncouleur.");
                s = s.Replace("You look just like a waxwork yourself.", "Vous ressemblez vous-même à une statue de cire.");
                s = s.Replace("I think...", "Je crois que...");
                s = s.Replace("my lack of colour must reflect my lack of\nconfidence...", "ma pâleur reflète simplement mon manque\nd'assurance...");
                s = s.Replace("Hmph.", "Hmph.");
                s = s.Replace("Wait till you hit my age, lad.", "Attends d'avoir mon âge, petit.");
                s = s.Replace("You won't have any\ncolour left to drain.", "Tu n'auras plus la\nmoindre couleur à perdre.");
                s = s.Replace("I said before that the court could not overlook your claim\nof evidence.", "J'ai déclaré plus tôt que le tribunal ne pouvait ignorer votre\nprétention à détenir une preuve.");
                s = s.Replace("But it seems to me that overlooking it would have been\nthe more preferable choice by some margin.", "Mais il me semble que l'ignorer eût été de loin préférable.");
                s = s.Replace("(Ugh.", "(Argh.");
                s = s.Replace("I was sure I had something...)", "J'étais pourtant sûr de tenir quelque chose...)");
                s = s.Replace("There's,", "De la...");
                s = s.Replace("there's wax dripping from your brow!", "de la cire dégouline de votre front !");
                s = s.Replace("You're melting!", "Vous fondez !");
                s = s.Replace("Just a cold sweat.", "Ce ne sont que des sueurs froides.");
                s = s.Replace("Nothing new.", "Rien de bien nouveau.");
                s = s.Replace("Let us return to the jurors' statements", "Revenons aux déclarations des jurés");
                s = s.Replace("and put this\ndebacle behind us.", "et laissons cette\ndébâcle derrière nous.");
                return s;
            };

            // Clé 95
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#46"] = s => {
                s = s.Replace("I have here", "J'ai en ma possession");
                s = s.Replace("a certain autopsy report from ten years ago.", "un certain rapport d'autopsie datant d'il y a dix ans.");
                s = s.Replace("A ten-year-old autopsy report?", "Un rapport d'autopsie vieux de dix ans ?");
                s = s.Replace("What relevance does that have?", "Quel rapport cela a-t-il ?");
                s = s.Replace("It is of course", "Il s'agit bien sûr");
                s = s.Replace("from the autopsy of the person portrayed\nin the waxwork:", "de l'autopsie de la personne représentée\npar cette statue de cire :");
                s = s.Replace("the killer known as", "le meurtrier surnommé");
                s = s.Replace("the Professor", "le Démon Assassin");
                s = s.Replace("The Professor's...?", "Du Démon Assassin... ?");
                s = s.Replace("But the man was a capital offender,", "Mais cet homme était un criminel condamné à mort,");
                s = s.Replace("so...", "alors...");
                s = s.Replace("That's right.", "C'est exact.");
                s = s.Replace("This is the certification of death that was\ndrawn up", "Voici l'acte de décès dressé");
                s = s.Replace("after", "après");
                s = s.Replace("the convict's execution.", "l'exécution du condamné.");
                s = s.Replace("The identity of the killer was never made public,", "L'identité du meurtrier n'a jamais été rendue publique,");
                s = s.Replace("so the\nreport gives few details.", "le\nrapport donne donc peu de détails.");
                s = s.Replace("But what's important", "Mais ce qui importe,");
                s = s.Replace("is", "c'est");
                s = s.Replace("the name", "le nom");
                s = s.Replace("of the coroner who\nwrote it:", "de la légiste qui\nl'a rédigé :");
                s = s.Replace("Courtney Stevens.", "Cyriella Stevens.");
                s = s.Replace("Oh my!", "Bonté divine !");
                s = s.Replace("Courtney Stevens", "Cyriella Stevens");
                s = s.Replace("Strike a light!", "Ça alors, nom d'un chien !");
                s = s.Replace("It appears that the Professor's autopsy", "Il appert que l'autopsie du Démon Assassin");
                s = s.Replace("was conducted by\nDr Sithe ten years ago.", "a été pratiquée par\nla Dre Pétrie il y a dix ans.");
                s = s.Replace("And a few days ago,", "Et il y a quelques jours,");
                s = s.Replace("Mr Drebber very deliberately stole\nthe waxwork of the Professor from Madame Tusspells.", "M. Drebber a délibérément dérobé\nla statue de cire du Démon Assassin chez Madame Pétrie.");
                s = s.Replace("A waxwork that doesn't in fact", "Une statue de cire qui, en fait,");
                s = s.Replace("resemble the victim,\nMr Asman, at all.", "ne ressemble en\nrien à la victime, M. Asman.");
                s = s.Replace("And do you suppose...", "Et supposez-vous...");
                s = s.Replace("there's some unsavoury relationship\nbetween those events?", "qu'il existe un lien inavouable\nentre tous ces événements ?");
                s = s.Replace("Absolutely!", "Absolument !");
                s = s.Replace("I'm sure of it!", "J'en suis convaincu !");
                s = s.Replace("There's no doubt in my mind that the Professor case...", "Il ne fait aucun doute dans mon esprit que l'affaire du Démon Assassin...");
                s = s.Replace("...is at the heart of", "... est au cœur d'");
                s = s.Replace("a link", "un lien");
                s = s.Replace("that we have yet to uncover...", "que nous n'avons pas encore percé à jour...");
                s = s.Replace("...between Dr Courtney Sithe", "... entre la Dre Cyriella Pétrie");
                s = s.Replace("and Mr Enoch Drebber!", "et M. Enoch Drebber !");
                s = s.Replace("Hidden links...", "Des liens cachés...");
                s = s.Replace("mysterious connections...", "des connexions mystérieuses...");
                s = s.Replace("secret\nrelationships...", "des relations\nsecrètes...");
                s = s.Replace("This is all", "Tout cela est");
                s = s.Replace("most extraordinary.", "des plus captivants.");
                s = s.Replace("We're surely obliged now", "Nous nous devons désormais");
                s = s.Replace("to explore this further.", "d'explorer cette piste plus avant.");
                s = s.Replace("Quite right.", "Parfaitement d'accord.");
                s = s.Replace("We can't let this trial come to an end now.", "On ne peut pas laisser ce procès s'arrêter là.");
                s = s.Replace("Not while there's this cloud of suspicion hanging over the\nYard's", "Pas tant qu'un nuage de soupçon plane sur la meilleure\nlégiste");
                s = s.Replace("best coroner.", "de tout le Yard.");
                s = s.Replace("It wasn't like this in my day!", "Ce n'était pas comme ça à mon époque !");
                s = s.Replace("But we're still here", "Mais nous sommes là");
                s = s.Replace("to uphold\njustice in the end!", "pour faire triompher\nla justice au bout du compte !");
                return s;
            };

            // Clé 96
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#47"] = s => {
                s = s.Replace("Those two statements", "Ces deux dépositions");
                s = s.Replace("clearly contradict each other!", "sont en contradiction flagrante !");
                s = s.Replace("Good gracious!", "Bonté divine !");
                s = s.Replace("To whose statements do you refer,", "À quelles dépositions faites-vous référence,");
                s = s.Replace("Counsel?", "maître ?");
                s = s.Replace("If you could put down your corn for a moment,", "Si vous vouliez bien poser votre maïs un instant,");
                s = s.Replace("juror\nnumber five...!", "juré\nnuméro cinq... !");
                s = s.Replace("Ooh,", "Oh,");
                s = s.Replace("you mean me?", "c'est à moi qu'vous parlez ?");
                s = s.Replace("You've pointed out that it's wrong to make an accusation\nwithout evidence.", "Vous avez souligné qu'il était inadmissible d'accuser\nquelqu'un sans preuve.");
                s = s.Replace("But the accusation that the waxwork model was inside\nthe second birdcage on the day in question...", "Mais l'affirmation selon laquelle la statue de cire se trouvait\ndans la seconde volière le jour en question...");
                s = s.Replace("...is not without supporting evidence.", "... ne manque pas d'éléments de preuve.");
                s = s.Replace("As the defence\ndemonstrated to the juror sitting beside you.", "Comme la défense\nvient de le démontrer au juré assis à vos côtés.");
                s = s.Replace("is that right?", "c'est vrai ?");
                s = s.Replace("Would it be fair to say...", "Serait-il juste de dire...");
                s = s.Replace("...you didn't follow the argument?", "... que vous n'avez pas tout suivi à l'argumentation ?");
                s = s.Replace("I don't understand much besides Colonel Cob,", "J'y comprends pas grand-chose en dehors du Colonel Épi,");
                s = s.Replace("to be\nhonest.", "pour\nêtre honnête.");
                s = s.Replace("(Of course you don't...)", "(Évidemment...)");
                s = s.Replace("If I could interject here...", "Si je puis intervenir...");
                s = s.Replace("Please do, sir.", "Je vous en prie, monsieur.");
                s = s.Replace("Now that this assertion of yours about the waxwork", "À présent que votre affirmation concernant la statue de cire");
                s = s.Replace("has\nbeen backed up by some solid evidence...", "s'appuie\nsur des preuves tangibles...");
                s = s.Replace("...it would be wrong of me, as a man of science,", "... il serait indigne de ma part, en tant qu'homme de science,");
                s = s.Replace("not to\npursue the matter further.", "de\nne point poursuivre l'examen de cette affaire.");
                s = s.Replace("Ar,", "Ah ben,");
                s = s.Replace("well,", "moi aussi alors !");
                s = s.Replace("me too, then!", "");
                s = s.Replace("Sorry?!", "Pardon ?!");
                s = s.Replace("If this brainy gentleman says ee's right,", "Si ce monsieur si instruit dit qu'il a raison,");
                s = s.Replace("then ee must be!", "c'est qu'ça doit être vrai !");
                s = s.Replace("See...", "Voyez...");
                s = s.Replace("I, um...", "je, hum...");
                s = s.Replace("...I wouldn't dream of goin' against Colonel Cob", "... j'oserais jamais contredire le Colonel Épi");
                s = s.Replace("or anyone\nwho's got stuffin' between the ears!", "ni quiconque\nen a dans l'citron !");
                s = s.Replace("(Success!", "(Victoire !");
                s = s.Replace("...If you can call it that.)", "... Si l'on peut appeler ça ainsi.)");
                return s;
            };

            // Clé 97
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#48"] = s => {
                s = s.Replace("Thank you, Counsel,", "Merci, maître,");
                s = s.Replace("that will do.", "cela suffira.");
                s = s.Replace("But,", "Mais,");
                s = s.Replace("but, My Lord,", "mais, Votre Honneur,");
                s = s.Replace("wait!", "attendez !");
                s = s.Replace("The defence is still in the process\nof establishing its argument...", "La défense est encore en train de poser\nson argumentation...");
                s = s.Replace("No further analysis is necessary,", "Aucune analyse supplémentaire n'est requise,");
                s = s.Replace("I feel.", "à mon sens.");
                s = s.Replace("As such,", "En conséquence,");
                s = s.Replace("I shall be requesting the final decisions of the\nmembers of the jury.", "je vais demander le verdict final des\nmembres du jury.");
                s = s.Replace("It's been an honour to serve,", "Ce fut un honneur de siéger,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                s = s.Replace("And we know exactly what we think now.", "Et nous savons exactement ce que nous pensons désormais.");
                s = s.Replace("Guilty!", "Coupable !");
                s = s.Replace("Mr Albert Harebrayne,", "M. Samba Lonron,");
                s = s.Replace("in accordance with the findings of\nthis court,", "conformément aux conclusions de\nce tribunal,");
                s = s.Replace("I pronounce you...", "je vous déclare...");
                s = s.Replace("I applaud the jurors for doing their civic duty", "Je félicite les jurés d'avoir accompli leur devoir civique");
                s = s.Replace("and for\nfinding a swift resolution to this matter.", "et d'avoir\napporté une conclusion rapide à cette affaire.");
                s = s.Replace("That is all.", "C'est tout.");
                s = s.Replace("Court is adjourned!", "L'audience est levée !");
                return s;
            };

            // Clé 98
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#49"] = s => {
                s = s.Replace("Do you have something to say about that,", "Avez-vous quelque chose à dire à ce propos,");
                s = s.Replace("juror number\none?", "juré numéro\nun ?");
                s = s.Replace("Hm?", "Hum ?");
                s = s.Replace("Did something about that last remark", "Quelque chose dans cette dernière remarque");
                s = s.Replace("strike a chord with\nyou?", "a-t-il fait écho\nen vous ?");
                s = s.Replace("Do you think I'd be reading the paper like this if it did?", "Pensez-vous que je lirais mon journal ainsi si c'était le cas ?");
                s = s.Replace("Pardon?", "Pardon ?");
                s = s.Replace("‘You see,", "« Vous voyez,");
                s = s.Replace("but you do not observe, Wilson.’", "mais vous n'observez pas, Wilson. »");
                s = s.Replace("...Words of a famous detective, those.", "... Des mots d'un célèbre détective, retenez-les.");
                s = s.Replace("Perhaps if you did a little more observing,", "Peut-être que si vous observiez un peu plus,");
                s = s.Replace("we could save\nus all some time.", "nous gagnerions\ntous un temps précieux.");
                s = s.Replace("(Believe me,", "(Croyez-moi,");
                s = s.Replace("I've seen that detective observing things,", "j'ai déjà vu ce détective « observer » les choses,");
                s = s.Replace("and\nit doesn't save anyone", "et\nça ne fait gagner");
                s = s.Replace("any time.)", "de temps à personne.)");
                return s;
            };

            // Clé 99
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#50"] = s => {
                s = s.Replace("Has that given you pause for thought,", "Cela vous a-t-il donné matière à réflexion,");
                s = s.Replace("juror number two?", "jurée numéro deux ?");
                s = s.Replace("Madam!", "Madame !");
                s = s.Replace("Oh,", "Oh,");
                s = s.Replace("I do apologise.", "je vous prie de m'excuser.");
                s = s.Replace("I was quite lost in thought for a moment there.", "J'étais totalement perdue dans mes pensées.");
                s = s.Replace("Yes, I noticed.", "Oui, j'ai remarqué.");
                s = s.Replace("Clearly something about what was just said", "De toute évidence, ce qui vient d'être dit");
                s = s.Replace("made an impression on you.", "vous a marquée.");
                s = s.Replace("Oh golly,", "Grand Dieu,");
                s = s.Replace("I'm afraid you misunderstand.", "je crains que vous ne vous mépreniez.");
                s = s.Replace("I was thinking about this evening's menu.", "Je songeais au menu de ce soir.");
                s = s.Replace("Menu?", "Au menu ?");
                s = s.Replace("That's right.", "Parfaitement.");
                s = s.Replace("My dear Daley will be ravenous by the time\nI'm home.", "Mon cher Daley sera affamé quand je\nrentrerai.");
                s = s.Replace("Well for starters,", "Eh bien pour commencer,");
                s = s.Replace("perhaps you could listen to what's being\nsaid here in the courtroom?", "pourriez-vous écouter ce qui se dit\nici dans ce tribunal ?");
                s = s.Replace("...And perhaps if what you set before the jurors was more\nappetising,", "... Et peut-être que si ce que vous serviez aux jurés était plus\nappétissant,");
                s = s.Replace("you'd keep their attention better.", "vous captiveriez mieux leur attention.");
                return s;
            };

            // Clé 100
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#51"] = s => {
                s = s.Replace("Something you'd like to say,", "Quelque chose à ajouter,");
                s = s.Replace("juror number three?", "juré numéro trois ?");
                s = s.Replace("Please...", "De grâce...");
                s = s.Replace("draw a card.", "tirez une carte.");
                s = s.Replace("Any card,", "N'importe quelle carte,");
                s = s.Replace("but do not show me.", "mais ne me la montrez pas.");
                s = s.Replace("Huh?", "Pardon ?");
                s = s.Replace("I will astound you by telling you the card you have taken.", "Je vais vous époustoufler en devinant la carte tirée.");
                s = s.Replace("Sorry,", "Désolé,");
                s = s.Replace("but my arms don't magically extend,", "mais mes bras ne s'allongent pas par magie,");
                s = s.Replace("actually.", "voyez-vous.");
                s = s.Replace("Then how about this?!", "Alors que dites-vous de cela ?!");
                s = s.Replace("What would really surprise me", "Ce qui me surprendrait véritablement,");
                s = s.Replace("is if you would focus on\nthe proceedings.", "ce serait que vous vous concentriez sur\nles débats.");
                return s;
            };

            // Clé 101
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#52"] = s => {
                s = s.Replace("Do you have something to say,", "Avez-vous quelque chose à dire,");
                s = s.Replace("juror number four?!", "juré numéro quatre ?!");
                s = s.Replace("Have I observed any interesting reactions,", "Ai-je observé de curieuses réactions,");
                s = s.Replace("is that what\nyou're asking?", "est-ce là ce que\nvous me demandez ?");
                s = s.Replace("W-", "Q-");
                s = s.Replace("What made you say that?!", "Qu'est-ce qui vous fait dire cela ?!");
                s = s.Replace("Science is all about making observations and drawing\nconclusions, young man.", "La science consiste à observer et à en tirer des\nconclusions, jeune homme.");
                s = s.Replace("And I've drawn plenty about you.", "Et j'en ai tiré un grand nombre à votre sujet.");
                s = s.Replace("You have...?", "Ah oui... ?");
                s = s.Replace("At any moment,", "À tout instant,");
                s = s.Replace("some catalyst is likely to make you", "un catalyseur est susceptible de vous faire");
                s = s.Replace("explode with a cry of ‘Objection!’", "exploser dans un cri d'« Objection ! »");
                s = s.Replace("...I'm not that much of an unstable substance.", "... Je ne suis pas une substance à ce point instable.");
                return s;
            };

            // Clé 102
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#53"] = s => {
                s = s.Replace("Do you have something to say to that,", "Avez-vous quelque chose à répondre à cela,");
                s = s.Replace("juror number five?", "juré numéro cinq ?");
                s = s.Replace("I love a good bit of corn, me.", "J'adore un bon épi d'maïs, moi.");
                s = s.Replace("You don't say.", "Sans blague.");
                s = s.Replace("But what I really love more than anythin'", "Mais c'que j'aime par-d'ssus tout,");
                s = s.Replace("is bitin' into a\nfresh radish.", "c'est croquer dans un\nbon radis bien frais.");
                s = s.Replace("But then...", "Mais alors...");
                s = s.Replace("why the corn?", "pourquoi le maïs ?");
                s = s.Replace("I forgot 'im at home...", "J'l'ai oublié chez moi...");
                s = s.Replace("A lesson...", "Une leçon...");
                s = s.Replace("in life.", "de vie.");
                s = s.Replace("There may well be more to people than\nmeets the eye.", "Il y a souvent bien plus chez les gens qu'il\nn'y paraît au premier abord.");
                s = s.Replace("I'm really not sure that applies here.", "Je ne suis vraiment pas sûr que cela s'applique ici.");
                return s;
            };

            // Clé 103
            entryTranslators[@"BB\script\output\_sce02_c303_0020_eng#54"] = s => {
                s = s.Replace("Did something about that", "Quelque chose dans tout cela");
                s = s.Replace("strike a chord, sir?!", "a-t-il fait écho en vous, monsieur ?!");
                s = s.Replace("Juror number six!", "Juré numéro six !");
                s = s.Replace("...Don't suppose I could 'elp, could I?", "... J'peux p't-être vous aider, non ?");
                s = s.Replace("Always enjoy a natter, me.", "J'aime bien tailler une p'tite bavette, moi.");
                s = s.Replace("(Well this is new.)", "(Tiens, voilà qui est nouveau.)");
                s = s.Replace("Perhaps", "Peut-être");
                s = s.Replace("you could wake up the policeman next to you?", "pourriez-vous réveiller l'agent de police à vos côtés ?");
                s = s.Replace("Ar,", "Ah,");
                s = s.Replace("no problem.", "aucun problème.");
                s = s.Replace("I'll do it dreckly.", "J'm'en occupe dare-dare.");
                s = s.Replace("Just get through some more o' this first.", "Faut juste que j'termine d'abord un bout d'ceci.");
                return s;
            };

            // Clé 104
            entryTranslators[@"BB\script\output\_sce02_c303_0030_eng#2"] = s => {
                s = s.Replace("Thank you, Counsel,", "Merci, maître,");
                s = s.Replace("that will do.", "cela suffira.");
                s = s.Replace("As a result of the summation examination,", "À la suite de cette plaidoirie de sommation,");
                s = s.Replace("the jury's\noverall leaning has changed.", "l'avis\ngénéral du jury a basculé.");
                s = s.Replace("Two jurors now call guilty.", "Deux jurés votent désormais coupable.");
                s = s.Replace("Against four who call not guilty.", "Contre quatre qui votent non coupable.");
                s = s.Replace("Accordingly", "En conséquence,");
                s = s.Replace("the court has failed to reach a consensus at\nthis time...", "la cour n'est pas parvenue à un consensus\npour l'heure...");
                s = s.Replace("...and the trial must continue!", "... et le procès doit se poursuivre !");
                s = s.Replace("We,", "On...");
                s = s.Replace("we did it!", "on a réussi !");
                s = s.Replace("Oh,", "Oh,");
                s = s.Replace("well done, Mr Naruhodo!", "bravo, M. Naruhodo !");
                s = s.Replace("Another wonderful victory!", "Une autre magnifique victoire !");
                s = s.Replace("Hmmm,", "Hummm,");
                s = s.Replace("a waxwork of the despicable Professor...", "une statue de cire du méprisable Démon Assassin...");
                s = s.Replace("...used as a ‘body double’ for the victim in this quite\nextraordinary case...", "... utilisée comme « doublure corporelle » pour la victime dans\ncette affaire pour le moins extraordinaire...");
                s = s.Replace("I must say,", "Je dois dire qu'");
                s = s.Replace("it's extremely hard to believe the assertion\ncould possibly be true.", "il est fort difficile de croire que cette affirmation\npuisse être véridique.");
                s = s.Replace("However,", "Toutefois,");
                s = s.Replace("it would appear that it does at least warrant\nfurther investigation.", "il semble qu'elle mérite à tout le moins\nun examen approfondi.");
                s = s.Replace("It's the waxwork of the Professor that links Mr Drebber\nand Dr Sithe.", "C'est la statue de cire du Démon Assassin qui relie M. Drebber\net la Dre Pétrie.");
                s = s.Replace("And I'm convinced", "Et j'ai la conviction intime");
                s = s.Replace("that there's a special significance to\nthat link!", "que ce lien recèle une signification\nparticulière !");
                s = s.Replace("I don't know what you're hoping to prove, lad,", "J'ignore ce que tu espères prouver, petit,");
                s = s.Replace("I really\ndon't!", "j'l'ignore\nvraiment !");
                s = s.Replace("The truth, sir.", "La vérité, monsieur.");
                s = s.Replace("By using evidence", "En nous appuyant sur les preuves");
                s = s.Replace("and testimony.", "et les témoignages.");
                s = s.Replace("Hmph.", "Hmph.");
                s = s.Replace("If the court is to delve deeper into the alleged\ninvolvement of the waxwork in this case...", "Si le tribunal doit se pencher plus avant sur l'implication\nprésumée de la statue de cire dans cette affaire...");
                s = s.Replace("...then the prosecution calls for the owner of the model to\nbe summoned", "... alors l'accusation demande que la propriétaire de cette œuvre\nsoit convoquée");
                s = s.Replace("as a witness.", "à la barre des témoins.");
                s = s.Replace("The owner?", "La propriétaire ?");
                s = s.Replace("Madame Tusspells.", "Madame Pétrie.");
                s = s.Replace("(I,", "(J'étais...");
                s = s.Replace("I really thought...)", "vraiment persuadé...)");
                s = s.Replace("(...that Lord van Zieks would object to this whole line of\nenquiry...)", "(... que Lord Van Peers s'opposerait catégoriquement à\ncette ligne d'enquête...)");
                s = s.Replace("Very well,", "Très bien,");
                s = s.Replace("I concur.", "j'y consens.");
                s = s.Replace("Make arrangements for Madame Tusspells to appear as a\nwitness", "Prenez les dispositions nécessaires pour que Madame Pétrie comparaisse");
                s = s.Replace("with immediate effect.", "sur-le-champ.");
                s = s.Replace("Listen carefully, my learned friend.", "Écoutez attentivement, mon cher confrère.");
                s = s.Replace("Oh...", "Oh...");
                s = s.Replace("Yes?", "Oui ?");
                s = s.Replace("You should know...", "Vous devriez savoir...");
                s = s.Replace("...that you're on the brink of opening Pandora's box.", "... que vous êtes sur le point d'ouvrir la boîte de Pandore.");
                s = s.Replace("The court shall now adjourn for forty-five minutes.", "L'audience est suspendue pour quarante-cinq minutes.");
                s = s.Replace("During that time,", "Pendant cet intervalle,");
                s = s.Replace("the prosecution will summon the new\nwitness", "l'accusation fera comparaître le nouveau\ntémoin");
                s = s.Replace("and prepare her for taking the stand.", "et la préparera à monter à la barre.");
                s = s.Replace("Madame Tusspells,", "Madame Pétrie,");
                s = s.Replace("yes.", "en effet.");
                s = s.Replace("I shall see to it at once,", "Je m'en charge sur-le-champ,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                return s;
            };

            // Clé 105
            entryTranslators[@"BB\script\output\_sce02_c304_0000_eng#2"] = s => {
                s = s.Replace("24th October, 11:53 a.m.", "24 octobre, 11 h 53");
                s = s.Replace("The Old Bailey, Defendants' Antechamber", "L'Old Bailey, antichambre des accusés");
                s = s.Replace("Ah,", "Ah,");
                s = s.Replace("the knight-errant himself!", "notre chevalier servant en personne !");
                s = s.Replace("Oh,", "Oh,");
                s = s.Replace("have you been watching from the gallery,", "vous avez assisté aux débats depuis la tribune,");
                s = s.Replace("Mr Sholmes?", "monsieur Holmes ?");
                s = s.Replace("I've been on the edge of my seat the entire time!", "J'ai été tenu en haleine d'un bout à l'autre !");
                s = s.Replace("Courtroom trials are fascinating affairs.", "Les procès d'assises sont des affaires passionnantes.");
                s = s.Replace("As a spectator,", "En tant que simple spectateur,");
                s = s.Replace("at least.", "du moins.");
                s = s.Replace("I'm glad you've been enjoying yourself...", "Ravi que le spectacle vous ait plu...");
                s = s.Replace("I,", "Je...");
                s = s.Replace("I have to ask...", "je dois vous demander...");
                s = s.Replace("...what on earth is going on?!", "... que se passe-t-il enfin ?!");
                s = s.Replace("It makes no sense!", "Ça n'a aucun sens !");
                s = s.Replace("What's this Professor business all about?", "C'est quoi cette histoire de Démon Assassin ?");
                s = s.Replace("He doesn't look like any professor I've ever met before!", "Il ne ressemble à aucun professeur que j'aie jamais croisé !");
                s = s.Replace("Who even is he?", "Qui est cet individu, d'abord ?");
                s = s.Replace("of course...", "évidemment...");
                s = s.Replace("...you were in Germany already", "... vous étiez déjà en Allemagne");
                s = s.Replace("ten years ago.", "il y a dix ans.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("the Professor...", "le Démon Assassin...");
                s = s.Replace("When I discovered ‘he’ was the one who had been\nabducted,", "Quand j'ai découvert que c'était « lui » qui avait été\nenlevé,");
                s = s.Replace("a sense of foreboding stirred within me.", "un sombre pressentiment s'est emparé de moi.");
                s = s.Replace("But who knew the monster would come knocking at your\ndoor?", "Mais qui aurait cru que le monstre viendrait frapper à votre\nporte ?");
                s = s.Replace("My heartfelt sympathies!", "Toutes mes plus sincères condoléances !");
                s = s.Replace("Ah ha ha ha ha hah!", "Ah ha ha ha ha ha !");
                s = s.Replace("As it turns out...", "Il se trouve que...");
                s = s.Replace("...Lord van Zieks is even more intimately tied to this case\nthan any of us realised,", "... Lord Van Peers est encore plus intimement lié à cette\naffaire qu'aucun de nous ne le soupçonnait,");
                s = s.Replace("isn't he?", "n'est-ce pas ?");
                s = s.Replace("how true.", "c'est bien vrai.");
                s = s.Replace("His great friend from university in the dock...", "Son grand ami d'université sur le banc des accusés...");
                s = s.Replace("...And now", "... Et voilà qu'");
                s = s.Replace("a waxwork of the killer who took his\nesteemed brother's life", "une statue de cire du tueur qui a ôté la vie\nà son illustre frère");
                s = s.Replace("makes an appearance, too.", "entre aussi en scène.");
                s = s.Replace("I imagine even the shrewd Mr Reaper", "J'imagine que même ce rusé Faucheur");
                s = s.Replace("failed to foresee\nthat kick in the teeth.", "n'avait pas anticipé\nun tel coup de massue.");
                s = s.Replace("An extraordinary move on your part, my dear fellow,", "Un coup de maître de votre part, mon cher ami,");
                s = s.Replace("to\nthrow that in front of the man.", "que de\nlui jeter cela en plein visage.");
                s = s.Replace("You make it sound deliberate...", "Vous présentez cela comme si c'était prémédité...");
                s = s.Replace("I can't help feeling...", "Je ne peux m'empêcher de penser...");
                s = s.Replace("...that this Professor case", "... que cette affaire du Démon Assassin");
                s = s.Replace("is really very puzzling.", "est véritablement déroutante.");
                s = s.Replace("Oh yes?", "Ah oui ?");
                s = s.Replace("In what particular manner?", "De quelle façon précisément ?");
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("there's Mr Drebber,", "il y a M. Drebber,");
                s = s.Replace("Dr Sithe", "la Dre Pétrie");
                s = s.Replace("and Lord van Zieks...", "et Lord Van Peers...");
                s = s.Replace("It seems that everybody in the trial has a link to the case\nsomehow.", "Il semble que chacun dans ce procès ait un lien avec cette\naffaire d'une façon ou d'une autre.");
                s = s.Replace("in fact", "en réalité,");
                s = s.Replace("I, alone,", "je suis le seul");
                s = s.Replace("am not a member of the set!", "à ne pas appartenir à cet ensemble !");
                s = s.Replace("Though that leaves me as an empty set...", "Ce qui fait de moi un ensemble vide...");
                s = s.Replace("all alone with no\nintersection to any other...", "tout seul, sans aucune\nintersection avec les autres...");
                s = s.Replace("Excuse me.", "Pardonnez-moi.");
                s = s.Replace("Dr Sithe!", "Dre Pétrie !");
                s = s.Replace("Ah, Dr Courtney Sithe,", "Ah, Dre Cyriella Pétrie,");
                s = s.Replace("née Stevens.", "née Stevens.");
                s = s.Replace("Good day to you.", "Mes respects.");
                s = s.Replace("Hello, Sholmes.", "Bonjour, Holmes.");
                s = s.Replace("That was very shrewd of you.", "C'était fort habile de votre part.");
                s = s.Replace("...What in particular,", "... Qu'y avait-il donc de si habile,");
                s = s.Replace("pray?", "je vous prie ?");
                s = s.Replace("You requested", "Vous avez réclamé");
                s = s.Replace("that ten-year-old autopsy report from\nGregson,", "ce vieux rapport d'autopsie d'il y a dix ans\nà Gregson,");
                s = s.Replace("didn't you?", "n'est-ce pas ?");
                s = s.Replace("Why would you assume such a thing?", "Pourquoi supposer pareille chose ?");
                s = s.Replace("Because Gregson told me.", "Parce que Gregson me l'a dit.");
                s = s.Replace("To think it's been ten years...", "Quand je pense que dix années ont passé...");
                s = s.Replace("Ten years in the laboratory,", "Dix ans au laboratoire,");
                s = s.Replace("wielding my scalpel.", "à manier le scalpel.");
                s = s.Replace("I smell of nothing but corpses and disinfectant.", "Je n'ai plus d'autre odeur que celle des cadavres et du désinfectant.");
                s = s.Replace("A policeman on the jury", "Un policier membre du jury");
                s = s.Replace("had a lot to say about you as it\nhappens, Dr Sithe.", "ne tarissait pas d'éloges sur vous,\nDre Pétrie.");
                s = s.Replace("And I've...accused you of being complicit in what\nhappened.", "Et je vous ai... accusée d'avoir été complice de ce qui\ns'est produit.");
                s = s.Replace("I'm hoping that you'll take the stand", "J'ose espérer que vous monterez à la barre");
                s = s.Replace("and tell the truth\nabout what really happened.", "pour dire la vérité\nsur ce qui s'est réellement passé.");
                s = s.Replace("That certainly won't be possible.", "Ce ne sera absolument pas possible.");
                return s;
            };

            // Clé 106
            entryTranslators[@"BB\script\output\_sce02_c304_0000_eng#3"] = s => {
                s = s.Replace("Lord van Zieks won't be summoning me as a witness.", "Lord Van Peers ne me convoquera pas comme témoin.");
                s = s.Replace("Lord Stronghart", "Lord Harry Caine");
                s = s.Replace("has forbidden it.", "l'a formellement interdit.");
                s = s.Replace("Lord Stronghart?", "Lord Harry Caine ?");
                s = s.Replace("The Pandora's box you were warned about...is the\nProfessor case.", "La boîte de Pandore dont on vous a parlé... c'est l'affaire\ndu Démon Assassin.");
                s = s.Replace("But please don't make the mistake of thinking you'll get\nany information about it out of me.", "Mais ne commettez pas l'erreur de croire que vous obtiendrez\nla moindre information de ma part.");
                return s;
            };

            // Clé 107
            entryTranslators[@"BB\script\output\_sce02_c304_0000_eng#4"] = s => {
                s = s.Replace("But attempting to hide from the truth...", "Mais tenter de fuir la vérité...");
                s = s.Replace("That's cowardice!", "C'est de la lâcheté !");
                s = s.Replace("I've always fought crime in the way that I see fit.", "J'ai toujours combattu le crime de la manière que je jugeais opportune.");
                s = s.Replace("I have no regrets.", "Je n'ai aucun regret.");
                s = s.Replace("None at all.", "Aucun.");
                s = s.Replace("And that's all I came here to say.", "Et c'est tout ce que j'avais à vous dire.");
                s = s.Replace("So...good day to you.", "Sur ce... adieu.");
                s = s.Replace("She mentioned it, too.", "Elle l'a mentionnée, elle aussi.");
                s = s.Replace("This Pandora's box...", "Cette boîte de Pandore...");
                s = s.Replace("Whatever does it all mean?", "Que peut bien signifier tout cela ?");
                s = s.Replace("There's really no cause for concern.", "Il n'y a vraiment nulle raison de s'inquiéter.");
                s = s.Replace("I assure you, when the trial resumes...", "Je vous garantis que dès la reprise de l'audience...");
                s = s.Replace("...the meaning will become all too apparent, whether\nyou'd like it to or not.", "... son sens ne deviendra que trop évident, que cela\nvous plaise ou non.");
                s = s.Replace("Huh?", "Hein ?");
                return s;
            };

            // Clé 108
            entryTranslators[@"BB\script\output\_sce02_c304_0000_eng#5"] = s => {
                s = s.Replace("Ah yes,", "Ah oui,");
                s = s.Replace("one word of warning before I go:", "un mot d'avertissement avant que je ne parte :");
                s = s.Replace("If,", "Si,");
                s = s.Replace("in the course of the trial this afternoon,", "au cours du procès cet après-midi,");
                s = s.Replace("you perceive\neven a shadow of doubt about the truth...", "vous percevez\nne serait-ce que l'ombre d'un doute sur la vérité...");
                s = s.Replace("...don't let it out of your sight.", "... ne le quittez jamais des yeux.");
                s = s.Replace("Pursue it like a dog with a bone.", "Accrochez-vous-y comme un molosse à son os.");
                s = s.Replace("To the bitter end, you understand.", "Jusqu'au bout du bout, vous m'entendez.");
                s = s.Replace("Do not falter,", "Ne faiblissez sous aucun prétexte,");
                s = s.Replace("whatever may come to pass.", "quoi qu'il advienne.");
                return s;
            };

            // Clé 109
            entryTranslators[@"BB\script\output\_sce02_c304_0000_eng#6"] = s => {
                s = s.Replace("Alright,", "D'accord,");
                s = s.Replace("I understand.", "j'ai compris.");
                s = s.Replace("...Thank you.", "... Merci.");
                s = s.Replace("Good.", "Parfait.");
                s = s.Replace("I shall make myself scarce, then.", "Je vais m'éclipser dans ce cas.");
                s = s.Replace("I purchased a bar of caramel earlier,", "J'ai fait l'acquisition d'une barre de caramel tout à l'heure,");
                s = s.Replace("so I shall be gnawing\non that", "je m'en vais donc la grignoter avec délectation");
                s = s.Replace("as you gnaw away at the truth!", "pendant que vous mordrez à belles dents dans la vérité !");
                s = s.Replace("(What did that warning from Mr Sholmes really mean, I\nwonder?)", "(Que pouvait bien signifier cet avertissement de monsieur Holmes ?)");
                s = s.Replace("(Especially the bit about", "(Surtout la partie sur");
                s = s.Replace("‘whatever may come to pass’...)", "« quoi qu'il advienne »...)");
                s = s.Replace("It's time for the final chapter, then.", "C'est donc l'heure de l'acte final.");
                s = s.Replace("I'm determined to find the truth...", "Je suis résolu à percer la vérité...");
                s = s.Replace("...no matter what.", "... coûte que coûte.");
                return s;
            };

            // Clé 110
            entryTranslators[@"BB\script\output\_sce02_c305_0000_eng#2"] = s => {
                s = s.Replace("24th October, 12:40 p.m.", "24 octobre, 12 h 40");
                s = s.Replace("The Old Bailey Courtroom", "L'Old Bailey, salle d'audience");
                s = s.Replace("In the name of Her Majesty the Queen,", "Au nom de Sa Majesté la Reine,");
                s = s.Replace("I hereby\nreconvene the proceedings of this court.", "je déclare\nouverte la reprise des débats de cette cour.");
                s = s.Replace("Counsels for the defence and prosecution,", "Maîtres de la défense et de l'accusation,");
                s = s.Replace("are you ready\nand able to continue?", "êtes-vous prêts\net disposés à reprendre ?");
                s = s.Replace("The prosecution", "L'accusation");
                s = s.Replace("is ready, My Lord.", "est prête, Votre Honneur.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                s = s.Replace("The defence", "La défense");
                s = s.Replace("is also ready.", "est prête également.");
                s = s.Replace("As the court is aware,", "Comme la cour ne l'ignore point,");
                s = s.Replace("the case under our scrutiny began\nwith a damaging incident at the Great Exhibition.", "l'affaire qui nous occupe a débuté\npar un fâcheux incident à l'Exposition universelle.");
                s = s.Replace("Yet we now find ourselves", "Et voilà que nous nous trouvons désormais");
                s = s.Replace("embroiled in the details of a\nconvicted felon", "plongés dans les agissements d'un criminel");
                s = s.Replace("who was sent to the gallows a decade ago.", "qui fut envoyé à la potence il y a une décennie.");
                s = s.Replace("This trial", "Ce procès");
                s = s.Replace("has certainly defied all expectation.", "a incontestablement défié toutes les attentes.");
                s = s.Replace("As seems to be the fate of all trials", "Comme semble être le destin de tout procès");
                s = s.Replace("in which this\nNipponese is involved, My Lord.", "auquel ce\nJaponais se trouve mêlé, Votre Honneur.");
                s = s.Replace("So then...", "Ainsi donc...");
                s = s.Replace("...let us begin our exploration of the defence's assertion", "... débutons l'examen de la thèse soutenue par la défense");
                s = s.Replace("that the waxwork was cardinally involved in this matter.", "selon laquelle cette statue de cire aurait joué un rôle capital.");
                s = s.Replace("Lord van Zieks...", "Lord Van Peers...");
                s = s.Replace("My Lord?", "Votre Honneur ?");
                s = s.Replace("Are we still awaiting the arrival of Madame Tusspells?", "Attendons-nous toujours l'arrivée de Madame Pétrie ?");
                s = s.Replace("Not at all.", "Nullement.");
                s = s.Replace("She is in the antechamber as we speak", "Elle se trouve dans l'antichambre à l'instant même");
                s = s.Replace("and ready to be\nsummoned.", "et n'attend\nque d'être appelée.");
                s = s.Replace("Very well.", "Fort bien.");
                s = s.Replace("Bring in the witness!", "Faites entrer le témoin !");
                s = s.Replace("At once,", "Sur-le-champ,");
                s = s.Replace("Bailiff!", "Huissier !");
                s = s.Replace("Show Madame Tusspells to the stand!", "Conduisez Madame Pétrie à la barre !");
                s = s.Replace("(Things are about to become a lot more intense.)", "(Les choses vont singulièrement s'intensifier.)");
                s = s.Replace("(If Drebber is responsible,", "(Si Drebber est coupable,");
                s = s.Replace("as I'm sure he is,", "comme j'en suis persuadé,");
                s = s.Replace("it means he\nmust have had", "cela signifie qu'il\na dû avoir");
                s = s.Replace("an accomplice", "une complice");
                s = s.Replace("in Dr Sithe.)", "en la Dre Pétrie.)");
                s = s.Replace("And what", "Et ce qui");
                s = s.Replace("connects", "relie");
                s = s.Replace("the pair of them...", "ces deux individus...");
                s = s.Replace("is the waxwork.", "c'est cette statue de cire.");
                s = s.Replace("(Yes,", "(Oui,");
                s = s.Replace("the model of the Professor...)", "la reproduction du Démon Assassin...)");
                s = s.Replace("(That's the key to the link between these otherwise\nunrelated individuals.)", "(C'est la clé de voûte entre deux personnes qui n'ont par\nailleurs aucun rapport.)");
                s = s.Replace("(It's a tenuous link, admittedly.", "(C'est un lien ténu, certes.");
                s = s.Replace("But at present,", "Mais pour l'heure,");
                s = s.Replace("it's all we\nhave to go on.)", "c'est tout ce dont\nnous disposons.)");
                return s;
            };

            // Clé 111
            entryTranslators[@"BB\script\output\_sce02_c305_0010_eng#2"] = s => {
                s = s.Replace("State your name and occupation for the court, please.", "Veuillez décliner vos nom et profession pour la cour.");
                s = s.Replace("My name is Madame Esmeralda Tusspells.", "Je me nomme Madame Esméralda Pétrie.");
                s = s.Replace("I am a waxwork artisan.", "Je suis sculptrice sur cire.");
                s = s.Replace("And the proprietress of the Madame Tusspells Museum\nof Waxwork.", "Et propriétaire du Musée de cire Madame Pétrie.");
                s = s.Replace("You will have to pardon me for working as I testify.", "Vous me pardonnerez de travailler tout en témoignant.");
                s = s.Replace("My new exhibit must open very soon.", "Ma nouvelle exposition doit être inaugurée sous peu.");
                s = s.Replace("(Oh, so he finally gets a statue, does he?", "(Oh, il a donc enfin droit à sa propre statue ?");
                s = s.Replace("Now there are two of them in the world...)", "Désormais, il en existe deux exemplaires au monde...)");
                s = s.Replace("Oh my...", "Mon Dieu...");
                s = s.Replace("What expression is she carving onto that face?", "Quelle expression sculpte-t-elle donc sur ce visage ?");
                s = s.Replace("A number of days ago,", "Il y a quelques jours,");
                s = s.Replace("a particular waxwork model was\nstolen from your museum.", "une certaine statue de cire a été dérobée\ndans votre musée.");
                s = s.Replace("Can you confirm this?", "Pouvez-vous le confirmer ?");
                s = s.Replace("Oui.", "Oui.");
                s = s.Replace("That is true.", "C'est exact.");
                s = s.Replace("At first,", "Au début,");
                s = s.Replace("we believed it had been", "nous pensions qu'elle avait été");
                s = s.Replace("kidnapped", "enlevée");
                s = s.Replace("A waxwork model?", "Une statue de cire ?");
                s = s.Replace("Kidnapped?!", "Enlevée ?!");
                s = s.Replace("Yes, My Lord.", "Oui, Votre Honneur.");
                s = s.Replace("There was a demand for", "Une demande de");
                s = s.Replace("ransom money", "rançon");
                s = s.Replace("left behind by the culprit.", "a été laissée sur place par le coupable.");
                s = s.Replace("However,", "Cependant,");
                s = s.Replace("according to what I have just been told outside\nthe courtroom,", "d'après ce que l'on vient de me dire à l'extérieur\nde la salle,");
                s = s.Replace("that was not the true reason.", "ce n'était point là le véritable motif.");
                s = s.Replace("I understand it was utilised as", "J'ai cru comprendre qu'elle avait servi de");
                s = s.Replace("a substitute", "substitut");
                s = s.Replace("for the\nbody of a murder victim?", "au cadavre\nd'une victime de meurtre ?");
                s = s.Replace("At present,", "Pour l'instant,");
                s = s.Replace("that is no more than conjecture proposed by\nthe defence.", "ce n'est qu'une conjecture avancée par\nla défense.");
                s = s.Replace("This", "Voici");
                s = s.Replace("is the victim of the case in question.", "la victime de l'affaire qui nous occupe.");
                s = s.Replace("Mr Odie Asman.", "M. Odoril Asman.");
                s = s.Replace("But of course,", "Mais bien sûr,");
                s = s.Replace("I know him well.", "je le connais fort bien.");
                s = s.Replace("He is a part of my odious\npersonages exhibit.", "Il fait partie de ma galerie des personnages\nodieux.");
                s = s.Replace("...I detest to say what is evident,", "... Je répugne à énoncer des évidences,");
                s = s.Replace("but Mr Asman does not\nresemble the Professor at all.", "mais M. Asman ne\nressemble en rien au Démon Assassin.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("but...", "mais...");
                s = s.Replace("perhaps!", "peut-être !");
                s = s.Replace("Perhaps their faces are very", "Peut-être que leurs visages sont très");
                s = s.Replace("similar", "similaires");
                s = s.Replace("Are you suggesting that we should see now", "Êtes-vous en train de suggérer que nous devrions contempler");
                s = s.Replace("the demasked\nvisage", "le visage\ndémasqué");
                s = s.Replace("of the Professor?", "du Démon Assassin ?");
                s = s.Replace("I have here the key,", "J'ai la clé en ma possession,");
                s = s.Replace("but it is strictly forbidden to open the\nlock.", "mais il est formellement interdit d'ouvrir le\ncadenas.");
                s = s.Replace("This is absurd!", "C'est absurde !");
                s = s.Replace("Pardon?", "Pardon ?");
                s = s.Replace("I don't know what face you've carved onto your fancy\nfigure beneath that mask...", "J'ignore quel visage vous avez façonné sous ce masque sur\nvotre pantin de cire...");
                s = s.Replace("...but clearly", "... mais de toute évidence,");
                s = s.Replace("it won't be that of the actual killer.", "ce ne saurait être celui du véritable meurtrier.");
                s = s.Replace("Indeed.", "En effet.");
                s = s.Replace("The man's identity was never made public, after all.", "L'identité de cet individu n'a jamais été rendue publique, après tout.");
                s = s.Replace("The trial took place in a closed court.", "Le procès s'est tenu à huis clos.");
                s = s.Replace("The proceedings were strictly confidential.", "Les délibérations étaient rigoureusement confidentielles.");
                s = s.Replace("The condemned man was summarily executed.", "Le condamné a été promptement exécuté.");
                s = s.Replace("His identity remains a closely guarded national secret.", "Son identité demeure un secret d'État jalousement gardé.");
                s = s.Replace("There is no possible way that a repository of tawdry\nexhibits", "Il est rigoureusement impossible qu'une foire aux attractions\nde bas étage");
                s = s.Replace("could get its hands on that information.", "ait pu mettre la main sur cette information.");
                s = s.Replace("Quel dommage.", "Quel dommage.");
                s = s.Replace("It would seem you are unaware", "Il semblerait que vous ignoriez");
                s = s.Replace("of the Tusspells'\nprinciples.", "les principes des Pétrie.");
                s = s.Replace("What principles?", "Quels principes ?");
                s = s.Replace("The family Tusspells has always prided itself on sculpting\nits models à la perfection.", "La famille Pétrie a toujours mis un point d'honneur à sculpter\nses modèles à la perfection.");
                s = s.Replace("Every detail,", "Le moindre détail,");
                s = s.Replace("including the visage,", "y compris le visage,");
                s = s.Replace("is fashioned with\ncomplete fidelity.", "est reproduit avec une\nfidélité absolue.");
                s = s.Replace("...Et voilà:", "... Et voilà :");
                s = s.Replace("our principles.", "nos principes.");
                s = s.Replace("There is a well known legend about the Tusspells\nwaxworks from the time of the French Revolution.", "Une célèbre légende entoure les effigies de cire de la famille\nPétrie depuis la Révolution française.");
                s = s.Replace("A member of the Tusspells family", "Une aïeule de la famille Pétrie");
                s = s.Replace("is said to have made a\nwaxwork of the queen who was executed.", "aurait modelé le visage\nde la reine qui fut guillotinée.");
                s = s.Replace("Oui, that is true.", "Oui, c'est tout à fait vrai.");
                s = s.Replace("It was a century ago now.", "Il y a un siècle de cela désormais.");
                s = s.Replace("I believe the queen's face was carved in the minutes\nfollowing her death,", "Il me semble que le visage de la reine fut moulé quelques minutes\naprès son trépas,");
                s = s.Replace("actually at the guillotine site.", "au pied même de la guillotine.");
                s = s.Replace("You are correct.", "Vous êtes fort bien renseignée.");
                s = s.Replace("The model is on display still today in the\nHouse of Horrors.", "Ce modèle est exposé aujourd'hui encore dans la\nGalerie des Horreurs.");
                s = s.Replace("We Tusspells will stop at nothing to obtain a faithful\nreplica of our subjects.", "Chez les Pétrie, rien ne nous arrête pour obtenir une réplique\nparfaitement fidèle de nos sujets.");
                s = s.Replace("Dear me...", "Grand Dieu...");
                s = s.Replace("A somewhat disturbing tenacity of purpose.", "Une ténacité quelque peu dérangeante.");
                s = s.Replace("It is the only way to obtain a truly lifelike representation\nof the subject.", "C'est l'unique façon d'insuffler la vie dans une représentation\nde cire.");
                s = s.Replace("And it has been my family's secret for generations.", "Et c'est le grand secret de ma lignée depuis des générations.");
                s = s.Replace("Do, do you mean to say...", "V-Voulez-vous dire par là...");
                s = s.Replace("that beneath that mask...?", "que sous ce masque... ?");
                s = s.Replace("The true visage of the killer is there.", "Le véritable visage du tueur s'y trouve, oui.");
                s = s.Replace("...This is ludicrous.", "... C'est insensé.");
                s = s.Replace("It's out of the question!", "C'est tout bonnement inadmissible !");
                s = s.Replace("The Professor", "Le Démon Assassin");
                s = s.Replace("spread terror throughout Great Britain.", "a semé la terreur dans toute la Grande-Bretagne.");
                s = s.Replace("As a result,", "De ce fait,");
                s = s.Replace("the Madame Tusspells Special Exhibit\nremains extremely popular", "l'exposition spéciale de Madame Pétrie\nreste extrêmement populaire,");
                s = s.Replace("even today.", "aujourd'hui encore.");
                s = s.Replace("The killer...emerging from his own grave...", "Le meurtrier... sortant de sa propre tombe...");
                s = s.Replace("It is a sight to behold. You should come.", "C'est un spectacle saisissant. Vous devriez venir.");
                s = s.Replace("I think, madame, that it would be beneficial to hear your formal\ntestimony on this matter.", "Je pense, madame, qu'il serait fort utile d'entendre votre\ndéposition solennelle sur cette question.");
                s = s.Replace("You will explain every detail of this macabre model.", "Vous expliquerez chaque détail de cette macabre effigie.");
                s = s.Replace("And your personal involvement in its creation.", "Et votre implication personnelle dans sa confection.");
                s = s.Replace("...With pleasure.", "... Avec grand plaisir.");
                return s;
            };

            // Clé 112
            entryTranslators[@"BB\script\output\_sce02_c305_0020_eng#2"] = s => {
                s = s.Replace("– The Professor Waxwork –", "– La statue du Démon Assassin –");
                s = s.Replace("The special exhibit in the House of Horrors", "L'exposition spéciale de la Galerie des Horreurs");
                s = s.Replace("is based on a\nrumour that shocked society in London.", "s'inspire d'une\nrumeur qui avait bouleversé tout Londres.");
                s = s.Replace("An impression of the visage was taken directly from the\ncorpse...", "Une empreinte du visage a été moulée directement sur le\ncadavre...");
                s = s.Replace("in accordance with Tusspells family principles.", "selon les nobles principes de la famille Pétrie.");
                s = s.Replace("I enlisted the aid of the gravedigger,", "J'ai obtenu la complicité du fossoyeur,");
                s = s.Replace("and created a mould\nfor the head in the cemetery", "et moulé la tête\ndu défunt au cimetière,");
                s = s.Replace("just before the interment.", "juste avant l'inhumation.");
                s = s.Replace("I hid myself until he gave me a signal.", "Je suis restée tapie dans l'ombre jusqu'à son signal.");
                s = s.Replace("...I was there for a very long time that night.", "... J'ai patienté de longues heures cette nuit-là.");
                s = s.Replace("As dawn approached,", "Alors que l'aube pointait,");
                s = s.Replace("I was very worried that I could be\ndiscovered.", "je craignais par-dessus tout d'être\ndécouverte.");
                return s;
            };

            // Clé 113
            entryTranslators[@"BB\script\output\_sce02_c305_0020_eng#3"] = s => {
                s = s.Replace("The gravedigger?!", "Le fossoyeur ?!");
                s = s.Replace("The man sanctioned this?", "Cet homme a osé autoriser pareille infamie ?");
                s = s.Replace("Oui.", "Oui.");
                s = s.Replace("I will do all that is necessary to achieve the true\nresemblance my family is celebrated for.", "Je ferais tout ce qui est nécessaire pour obtenir la parfaite\nressemblance qui fait la renommée de ma famille.");
                s = s.Replace("Nobody else knew.", "Personne d'autre n'était au courant.");
                s = s.Replace("Only the gravedigger.", "Seul le fossoyeur.");
                s = s.Replace("What harm did it do,", "Quel mal y avait-il,");
                s = s.Replace("uh?", "hein ?");
                s = s.Replace("So you truly saw it?", "Vous l'avez donc véritablement vu ?");
                s = s.Replace("The face of that monster!", "Le visage de cette abomination !");
                s = s.Replace("Naturally,", "Naturellement,");
                s = s.Replace("I was aware at the time that his identity was a\nsecret.", "j'étais consciente à l'époque que son identité était tenue\nsecrète.");
                s = s.Replace("But Tusspells would not be Tusspells", "Mais Pétrie ne serait plus Pétrie");
                s = s.Replace("if we did not insist\non absolute fidelity to our sculptures.", "si nous ne garantissions\npas une fidélité absolue à nos sculptures.");
                s = s.Replace("I don't believe this...", "C'est inconcevable...");
                s = s.Replace("I myself", "Moi-même,");
                s = s.Replace("have seen the special exhibit at your museum,\nmadame.", "j'ai contemplé l'exposition spéciale de votre musée,\nmadame.");
                s = s.Replace("A truly blood-curdling scene,", "Une scène qui vous glace véritablement le sang,");
                s = s.Replace("in which the murderer is\nemerging from his own grave.", "dans laquelle le meurtrier semble\ns'extirper de sa propre tombe.");
                s = s.Replace("The scene it depicts was the subject of many rumours in\nLondon ten years ago.", "Cette scène s'inspire des innombrables rumeurs qui agitaient\nLondres il y a dix ans.");
                s = s.Replace("I have here", "J'ai sous la main");
                s = s.Replace("a newspaper from the time.", "un journal d'époque.");
                s = s.Replace("The special exhibit", "L'exposition spéciale");
                s = s.Replace("was based upon the picture in this\narticle.", "a été conçue d'après l'illustration de\ncet article.");
                s = s.Replace("It was the most detailed account of what happened,", "C'était le récit le plus détaillé des faits,");
                s = s.Replace("as\nreported by the eyewitness who saw it.", "tel que\nrapporté par le témoin oculaire de la scène.");
                s = s.Replace("The ten-year-old article has been\nentered into the Court Record.", "L'article d'il y a dix ans a été versé\nau dossier de l'affaire.");
                s = s.Replace("‘Man Rises from the Grave!’...", "« Un mort s'échappe de sa tombe ! »...");
                s = s.Replace("It's too absurd for words.", "C'est d'une absurdité sans nom.");
                s = s.Replace("The public enjoy absurdity, monsieur.", "Le public raffole de l'absurde, monsieur.");
                s = s.Replace("That is why I have reproduced the scene as carefully as\npossible in my museum.", "C'est pourquoi j'ai reconstitué la scène avec le plus grand\nsoin dans mon musée.");
                s = s.Replace("And it's a waxwork from that exhibit that was stolen", "Et c'est une statue de cette exposition qui a été volée");
                s = s.Replace("some\ndays before the incident at the Great Exhibition,", "quelques\njours avant l'incident de l'Exposition universelle,");
                s = s.Replace("wasn't it.", "n'est-ce pas ?");
                s = s.Replace("That is correct.", "C'est parfaitement exact.");
                s = s.Replace("The Professor", "Le Démon Assassin");
                s = s.Replace("you see before you here.", "que vous avez sous les yeux.");
                s = s.Replace("Hm...", "Hum...");
                s = s.Replace("Most puzzling...", "Fort déconcertant...");
                s = s.Replace("Counsel for the Defence...", "Maître de la défense...");
                s = s.Replace("proceed with the\ncross-examination!", "veuillez débuter le\ncontre-interrogatoire !");
                s = s.Replace("(This waxwork links Drebber to Dr Sithe...)", "(Cette statue relie Drebber à la Dre Pétrie...)");
                s = s.Replace("(And there has to be some reason for that,", "(Et il y a forcément une raison à cela,");
                s = s.Replace("which hasn't\nyet come to light.)", "qui n'a\npas encore éclaté au grand jour.)");
                s = s.Replace("(But I'll find it.", "(Mais je la trouverai.");
                s = s.Replace("I'll get to the bottom of what really happened.)", "Je ferai toute la lumière sur ce qui s'est passé.)");
                s = s.Replace("(I'll prove that Dr Sithe and Drebber", "(Je prouverai que la Dre Pétrie et Drebber");
                s = s.Replace("were in on this\ncrime together!)", "étaient complices dans\nce meurtre !)");
                return s;
            };

            // Clé 114
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#2"] = s => {
                s = s.Replace("– The Professor Waxwork –", "– La statue du Démon Assassin –");
                return s;
            };

            // Clé 115
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#4"] = s => {
                s = s.Replace("The special exhibit in the House of Horrors is based on a\nrumour that shocked society in London.", "L'exposition spéciale de la Galerie des Horreurs s'inspire d'une\nrumeur qui avait bouleversé tout Londres.");
                return s;
            };

            // Clé 116
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#5"] = s => {
                s = s.Replace("An impression of the visage was taken directly from the\ncorpse...in accordance with Tusspells family principles.", "Une empreinte du visage a été moulée directement sur le\ncadavre... selon les nobles principes de la famille Pétrie.");
                return s;
            };

            // Clé 117
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#6"] = s => {
                s = s.Replace("I enlisted the aid of the gravedigger, and created a mould\nfor the head in the cemetery just before the interment.", "J'ai obtenu la complicité du fossoyeur, et moulé la tête\ndu défunt au cimetière juste avant l'inhumation.");
                return s;
            };

            // Clé 118
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#7"] = s => {
                s = s.Replace("I hid myself until he gave me a signal.\n...I was there for a very long time that night.", "Je suis restée tapie dans l'ombre jusqu'à son signal.\n... J'ai patienté de longues heures cette nuit-là.");
                return s;
            };

            // Clé 119
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#8"] = s => {
                s = s.Replace("It took me a very long time because it was before the\nonset of rigor mortis.", "Cela m'a pris beaucoup de temps car c'était avant le\ndébut de la rigidité cadavérique.");
                return s;
            };

            // Clé 120
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#9"] = s => {
                s = s.Replace("As dawn approached, I was very worried that I could be\ndiscovered.", "Alors que l'aube pointait, je craignais par-dessus tout d'être\ndécouverte.");
                return s;
            };

            // Clé 121
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#10"] = s => {
                s = s.Replace("I hurried to finish my work in the half hour before\nsunrise. Then I left as soon as the corpse was interred.", "Je me suis dépêchée d'achever mon moulage dans la demi-heure précédant\nle lever du jour. Puis je suis partie dès l'inhumation.");
                return s;
            };

            // Clé 122
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#11"] = s => {
                s = s.Replace("And that rumour would be...?", "Et quelle était cette fameuse rumeur... ?");
                s = s.Replace("A ten-year-old tale now...", "Une vieille histoire vieille de dix ans...");
                s = s.Replace("but one that no Londoner would\never forget.", "mais qu'aucun Londonien ne saurait\noublier.");
                s = s.Replace("Ah, right.", "Ah, bien sûr.");
                s = s.Replace("I know just what you're talking about, I think.", "Je vois parfaitement de quoi vous parlez.");
                s = s.Replace("Of course,", "Naturellement,");
                s = s.Replace("it couldn't be anything else...", "ça ne pouvait être rien d'autre...");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("that story will never disappear.", "cette légende ne disparaîtra jamais.");
                s = s.Replace("The tale of the condemned killer", "L'histoire du meurtrier condamné à mort");
                s = s.Replace("rising from the dead...", "ressuscitant d'entre les morts...");
                s = s.Replace("That is the central attraction of my House of Horrors.", "C'est l'attraction phare de ma Galerie des Horreurs.");
                s = s.Replace("The rumour was whispered all over the city.", "La rumeur s'est murmurée dans tout Londres.");
                s = s.Replace("And it was like this...", "Et voici ce qu'elle contait...");
                return s;
            };

            // Clé 123
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#12"] = s => {
                s = s.Replace("It was in Lowgate Cemetery behind the prison,", "C'était au cimetière de Lowgate, derrière la prison,");
                s = s.Replace("in the dead of night after the execution of the killer.", "au cœur de la nuit après l'exécution du meurtrier.");
                s = s.Replace("The interred Professor slid back the stone slab", "Le Démon Assassin à peine mis en terre repoussa la dalle");
                s = s.Replace("covering his tomb,", "recouvrant son caveau,");
                s = s.Replace("and emerged from his grave.", "et s'extirpa de sa tombe.");
                return s;
            };

            // Clé 124
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#13"] = s => {
                s = s.Replace("A young man who witnessed this", "Un jeune homme qui fut témoin de cette scène");
                s = s.Replace("felt a scream welling up inside him...", "sentit un cri d'effroi monter en lui...");
                s = s.Replace("...but an instant later,", "... mais l'instant d'après,");
                s = s.Replace("he heard an ear-splitting", "un coup de feu assourdissant");
                s = s.Replace("gunshot from over his shoulder.", "retentit derrière son épaule.");
                s = s.Replace("The bullet struck the emerging corpse...", "La balle frappa le cadavre en train d'émerger...");
                s = s.Replace("and he fell motionless once more.", "et il s'effondra, immobile à nouveau.");
                s = s.Replace("The scream finally found its way from the mouth of\nthe young witness,", "Le cri jaillit enfin des lèvres du\njeune témoin,");
                s = s.Replace("who turned and ran for his life.", "qui prit ses jambes à son cou.");
                s = s.Replace("The, the corpse climbed out...of his own grave...?", "Le... le cadavre est sorti... de sa propre tombe... ?");
                s = s.Replace("And then somebody shot him?", "Et puis quelqu'un lui a tiré dessus ?");
                s = s.Replace("Who,", "Mais qui...");
                s = s.Replace("who was it?!", "qui a fait cela ?!");
                s = s.Replace("Nobody knows,", "Personne ne le sait,");
                s = s.Replace("even today.", "même aujourd'hui.");
                s = s.Replace("But remember,", "Mais rappelez-vous,");
                s = s.Replace("it was just a rumour.", "ce n'était qu'une rumeur.");
                s = s.Replace("...Perhaps nothing more than a ghost story.", "... Peut-être rien de plus qu'une histoire de fantômes.");
                s = s.Replace("The good people of London,", "Les braves Londoniens,");
                s = s.Replace("they love stories like this.", "ils raffolent de ce genre de récits.");
                s = s.Replace("That is why it was in every newspaper across the capital.", "C'est pour cela que tous les journaux en ont fait leurs choux gras.");
                s = s.Replace("But,", "Mais...");
                s = s.Replace("but was it just a story?", "n'était-ce vraiment qu'une histoire ?");
                s = s.Replace("I mean,", "Je veux dire,");
                s = s.Replace("this is exactly the scene that can be seen today at\nyour museum,", "c'est la scène exacte que l'on peut contempler aujourd'hui\ndans votre musée,");
                s = s.Replace("isn't it?", "n'est-ce pas ?");
                s = s.Replace("The special exhibit was modelled on that very\nillustration.", "L'exposition spéciale a été modelée d'après cette\nillustration même.");
                s = s.Replace("For a while afterwards,", "Pendant un certain temps par la suite,");
                s = s.Replace("the contents of that article were\nreproduced", "le contenu de cet article a été\nreproduit");
                s = s.Replace("in every newspaper imaginable.", "dans tous les journaux imaginables.");
                s = s.Replace("Madame,", "Madame,");
                s = s.Replace("might I say something?", "puis-je dire un mot ?");
                s = s.Replace("Please, go ahead,", "Je vous en prie, allez-y,");
                s = s.Replace("mademoiselle.", "mademoiselle.");
                s = s.Replace("When something is described as a rumour,", "Quand un fait est qualifié de simple rumeur,");
                s = s.Replace("it doesn't\nnecessarily mean", "cela ne\nsignifie pas nécessairement");
                s = s.Replace("that it's entirely made up.", "qu'il est pure invention.");
                s = s.Replace("I believe that often...", "J'ai la conviction que souvent...");
                s = s.Replace("rumours contain elements of the\ntruth.", "les rumeurs recèlent une part de\nvérité.");
                s = s.Replace("Ah,", "Ah,");
                s = s.Replace("I see that people from the East can be just as astute as\nthe people of Europe.", "je vois que les esprits d'Orient sont tout aussi perspicaces\nque ceux d'Europe.");
                s = s.Replace("Can we be sure, for instance,", "Pouvons-nous être certains, par exemple,");
                s = s.Replace("that the Professor's\nexecution was successful?", "que l'exécution du Démon Assassin\na bel et bien réussi ?");
                s = s.Replace("It is not possible", "Il est rigoureusement impossible");
                s = s.Replace("for the dead to come back to life.", "pour les défunts de revenir à la vie.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("Ten years ago,", "Il y a dix ans,");
                s = s.Replace("I was there in Lowgate Cemetery.", "j'étais présente au cimetière de Lowgate.");
                s = s.Replace("After the criminal known as the Professor was killed by\nhanging...", "Après que le criminel surnommé le Démon Assassin eut péri\npar pendaison...");
                s = s.Replace("...I took a wax impression of his visage from the corpse", "... j'ai moulé l'empreinte de son visage sur le cadavre");
                s = s.Replace("just before it was interred.", "juste avant qu'il ne soit mis en terre.");
                s = s.Replace("So I can assure you...", "Je puis donc vous assurer...");
                s = s.Replace("...the man", "... que cet homme");
                s = s.Replace("was dead.", "était bel et bien mort.");
                s = s.Replace("...I see.", "... Je vois.");
                s = s.Replace("Hmmm...", "Hummm...");
                s = s.Replace("It would certainly appear", "Il apparaît de façon certaine");
                s = s.Replace("that the condemned man\nsuffered the intended fate.", "que le condamné a bien\nsubi le châtiment prévu.");
                return s;
            };

            // Clé 125
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#14"] = s => {
                s = s.Replace("Is,", "Est-ce...");
                s = s.Replace("is that true of every waxwork in your museum then?", "est-ce vrai pour toutes les statues de votre musée ?");
                s = s.Replace("It is...", "Oui...");
                s = s.Replace("assuming the subject is dead, of course.", "en supposant que le sujet soit mort, bien sûr.");
                s = s.Replace("Live subjects have to cooperate in a similar way.", "Pour les vivants, il faut obtenir une coopération similaire.");
                s = s.Replace("I have letters from imprisoned criminals all the time, you\nknow.", "Je reçois sans cesse des lettres de criminels incarcérés, savez-vous.");
                s = s.Replace("What sort of letters?", "Quel genre de lettres ?");
                s = s.Replace("‘When my time comes,", "« Quand mon heure viendra,");
                s = s.Replace("please make a waxwork of me.’", "faites une statue de cire de moi. »");
                s = s.Replace("...Comme ça.", "... Comme ça.");
                s = s.Replace("No!", "Ce n'est pas vrai !");
                s = s.Replace("My museum is famous, monsieur.", "Mon musée est célèbre, monsieur.");
                s = s.Replace("To be made into a waxwork is an honour.", "Avoir son effigie de cire est un grand honneur.");
                s = s.Replace("And for some criminals,", "Et pour certains malfaiteurs,");
                s = s.Replace("a symbol of status, even.", "c'est même un symbole de prestige.");
                s = s.Replace("(Because nothing says hardened criminal", "(Parce que rien ne caractérise mieux un bandit endurci");
                s = s.Replace("better than...", "que de la...");
                s = s.Replace("wax.)", "cire.)");
                s = s.Replace("And it is thanks to one killer in particular,", "Et c'est grâce à un assassin en particulier");
                s = s.Replace("that my\nmuseum has gained such popularity in London.", "que mon musée\na acquis une telle renommée à Londres.");
                s = s.Replace("I refer to the star of the special exhibit, of course.", "Je fais référence à la vedette de l'exposition spéciale, bien sûr.");
                s = s.Replace("The Professor.", "Le Démon Assassin.");
                s = s.Replace("...Whose form you claim to have captured", "... Dont vous affirmez avoir immortalisé les traits");
                s = s.Replace("by taking an\nimpression from the actual corpse.", "en prenant\nune empreinte sur son propre cadavre.");
                s = s.Replace("...There are no exceptions", "... Il n'y a aucune exception");
                s = s.Replace("to the principles of Tusspells.", "aux principes de la maison Pétrie.");
                return s;
            };

            // Clé 126
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#15"] = s => {
                s = s.Replace("Surely that's illegal...", "C'est assurément illégal...");
                s = s.Replace("isn't it?", "n'est-ce pas ?");
                s = s.Replace("It would seem the proprietress of this repository of\nnovelties", "Il semblerait que la propriétaire de cette foire aux\ncuriosités");
                s = s.Replace("was blinded by monetary greed.", "ait été aveuglée par l'appât du gain.");
                s = s.Replace("It had nothing to do with money.", "Cela n'avait rien à voir avec l'argent.");
                s = s.Replace("The man is part of London's criminal history.", "Cet homme appartient à l'histoire criminelle de Londres.");
                s = s.Replace("That is why I had to sculpt him.", "Voilà pourquoi je me devais de le sculpter.");
                s = s.Replace("To record this history.", "Pour consigner cette histoire.");
                s = s.Replace("It is the raison d'être of the Tusspells museum.", "C'est la raison d'être du musée Pétrie.");
                s = s.Replace("But if the man was convicted in a closed court", "Mais si l'homme a été jugé à huis clos");
                s = s.Replace("and sent\nfor immediate execution...", "et envoyé à la\npotence sans délai...");
                s = s.Replace("...then surely nobody but the members of the judiciary\npresent", "... alors personne en dehors des membres du tribunal\nprésents");
                s = s.Replace("know the killer's true identity.", "ne connaît la véritable identité du meurtrier.");
                s = s.Replace("I assure you,", "Je vous le garantis,");
                s = s.Replace("behind that mask is hidden", "sous ce masque est dissimulé");
                s = s.Replace("the true face", "le vrai visage");
                s = s.Replace("of\nthe Professor.", "du\nDémon Assassin.");
                s = s.Replace("Do you realise", "Vous rendez-vous compte");
                s = s.Replace("what you're saying?!", "de ce que vous avancez ?!");
                s = s.Replace("The Professor's identity", "L'identité du Démon Assassin");
                s = s.Replace("is", "est");
                s = s.Replace("a national secret", "un secret d'État");
                s = s.Replace("...I understand.", "... Je comprends.");
                s = s.Replace("And now that the truth about the special exhibit has been\nrevealed,", "Et maintenant que la vérité sur cette exposition spéciale\nest étalée au grand jour,");
                s = s.Replace("it must perhaps", "elle devra peut-être");
                s = s.Replace("close.", "fermer.");
                s = s.Replace("Of course it will.", "Sans l'ombre d'un doute.");
                s = s.Replace("As will your entire museum, if you don't\ntread very carefully, madame.", "Tout comme votre musée au grand complet si vous\nne marchez pas sur des œufs, madame.");
                s = s.Replace("That could be", "Ce pourrait être");
                s = s.Replace("another interesting chapter in the history\nof my family, I think,", "un autre chapitre fascinant dans l'histoire\nde ma famille,");
                s = s.Replace("don't you?", "ne trouvez-vous pas ?");
                s = s.Replace("So ten years ago,", "Donc il y a dix ans,");
                s = s.Replace("on the night of the Professor's execution,", "la nuit de l'exécution du Démon Assassin,");
                s = s.Replace("you took a wax impression of his face from the corpse?", "vous avez moulé son visage sur son cadavre ?");
                s = s.Replace("Oui.", "Oui.");
                s = s.Replace("Exactement.", "Exactement.");
                return s;
            };

            // Clé 127
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#16"] = s => {
                s = s.Replace("You were there longer than you expected to be?", "Vous y êtes restée plus longtemps que prévu ?");
                s = s.Replace("...I had some...difficulties in capturing the subject's form\ncorrectly.", "... J'ai rencontré des... difficultés pour capturer fidèlement\nles traits du sujet.");
                s = s.Replace("As I removed the mask,", "Quand j'ai retiré le masque,");
                s = s.Replace("the mouth of the cadaver fell\nopen and", "la bouche du cadavre s'est\nouverte et");
                s = s.Replace("I had some problems with the chin.", "j'ai eu quelques ennuis avec son menton.");
                s = s.Replace("Dare I ask...?", "Oserais-je demander... ?");
                s = s.Replace("The man had been dead for a short while already, you\nsee.", "L'homme était mort depuis peu de temps, voyez-vous.");
                s = s.Replace("His muscles were relaxing", "Ses muscles étaient en phase de relâchement,");
                s = s.Replace("and consequently", "et par conséquent,");
                s = s.Replace("his chin\nwould not align itself correctly.", "sa mâchoire\nne tenait pas en place correctement.");
                s = s.Replace("Oh dear...what a horrible thought...", "Oh là là... quelle vision cauchemardesque...");
                s = s.Replace("Under normal circumstances,", "En temps normal,");
                s = s.Replace("I would have an assistant\nwith me.", "j'ai toujours un assistant à mes\ncôtés.");
                s = s.Replace("However,", "Cependant,");
                s = s.Replace("that night,", "cette nuit-là,");
                s = s.Replace("I was alone.", "j'étais seule.");
                s = s.Replace("And as a consequence,", "Et de ce fait,");
                s = s.Replace("I\nmissed my preferred window of time.", "j'ai\nmanqué le créneau idéal.");
                s = s.Replace("What do you mean?", "Que voulez-vous dire ?");
                s = s.Replace("When I take the impression of the visage of a cadaver...", "Lorsque je moule l'empreinte du visage d'un défunt...");
                s = s.Replace("...I always wait until three hours after death.", "... j'attends toujours trois heures après le décès.");
                s = s.Replace("Why three hours?", "Pourquoi trois heures ?");
                s = s.Replace("Is that amount of time significant?", "Ce délai a-t-il une signification particulière ?");
                s = s.Replace("It is because of", "C'est en raison de la");
                s = s.Replace("rigor mortis", "rigidité cadavérique");
                s = s.Replace("A...wriggly mortice?", "De la... rigidité cadavé-quoi ?");
                s = s.Replace("It's the name given to a phenomenon that occurs in\nrecently deceased bodies.", "C'est le nom donné au phénomène biomécanique qui survient\nsur les corps récemment décédés.");
                s = s.Replace("As a rule,", "En règle générale,");
                s = s.Replace("three hours post death,", "trois heures après la mort,");
                s = s.Replace("the muscles in the body\nbegin to stiffen.", "les muscles du corps\ncommencent à se raidir.");
                s = s.Replace("By approximately ten hours post death,", "Au bout d'une dizaine d'heures environ,");
                s = s.Replace("the entire body is\ncompletely rigid and inflexible.", "le corps entier est\ntotalement rigide et inflexible.");
                s = s.Replace("And then from that point on,", "Puis, passé ce délai,");
                s = s.Replace("the muscles slowly start to\nrevert to their relaxed state.", "les tissus musculaires entament leur\nrelâchement progressif.");
                s = s.Replace("The effect is often used", "Ce phénomène est couramment utilisé");
                s = s.Replace("to", "pour");
                s = s.Replace("estimate the time of death", "estimer l'heure du décès");
                s = s.Replace("when a body is discovered!", "lorsqu'un corps est découvert !");
                s = s.Replace("Well,", "Eh bien,");
                s = s.Replace("that was an education.", "voilà qui est instructif.");
                s = s.Replace("If a slightly scary one.", "Quoiqu'un peu terrifiant.");
                s = s.Replace("As the mademoiselle says,", "Comme le dit mademoiselle,");
                s = s.Replace("rigor mortis commences three\nhours after death...", "la rigidité débute trois\nheures après le trépas...");
                s = s.Replace("and it starts in the jaw.", "et commence par la mâchoire.");
                s = s.Replace("I see.", "Je vois.");
                s = s.Replace("So that's why you wait.", "C'est donc pour cela que vous attendez.");
                s = s.Replace("Before that time,", "Avant ce moment-là,");
                s = s.Replace("the mouth falls open...", "la bouche s'entrouvre...");
                s = s.Replace("and it is very\ndifficult to do my work.", "et mon travail s'en\ntrouve grandement compliqué.");
                s = s.Replace("Ugh...", "Beurk...");
                s = s.Replace("it's getting hard for me to do my work", "ça devient difficile pour moi de travailler");
                s = s.Replace("with all this\ntalk of corpses...", "avec toutes\nces histoires de cadavres...");
                return s;
            };

            // Clé 128
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#17"] = s => {
                s = s.Replace("(Hm...", "(Hm...");
                s = s.Replace("I wonder about that information the court's just\nheard from Madame Tusspells...)", "je me demande ce que vaut cette information que la cour\nvient d'entendre de Madame Pétrie...)");
                return s;
            };

            // Clé 129
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#18"] = s => {
                s = s.Replace("the information about rigor mortis that you just\nshared with us...", "les explications sur la rigidité cadavérique que vous\nvenez de nous fournir...");
                s = s.Replace("Would you mind including it in your formal testimony?", "Auriez-vous l'obligeance de les inclure dans votre déposition ?");
                s = s.Replace("I believe it could be significant, you see.", "J'ai le pressentiment que cela pourrait être déterminant.");
                s = s.Replace("Of course.", "Bien sûr.");
                s = s.Replace("I do not mind at all.", "Je n'y vois aucun inconvénient.");
                s = s.Replace("I can't help feeling that after this latest topic...", "Je ne peux m'empêcher de penser qu'après ce sujet...");
                s = s.Replace("...the atmosphere in the courtroom has become\nextremely...", "... l'atmosphère dans la salle est devenue\nextrêmement...");
                s = s.Replace("grave.", "pesante.");
                s = s.Replace("...This is no time for jokes,", "... Ce n'est pas le moment pour des calembours,");
                s = s.Replace("Miss Susato.", "mademoiselle Susato.");
                s = s.Replace("Madame,", "Madame,");
                s = s.Replace("kindly amend your testimony as discussed.", "veuillez rectifier votre déposition comme convenu.");
                s = s.Replace("Bien sûr.", "Bien sûr.");
                return s;
            };

            // Clé 130
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#19"] = s => {
                s = s.Replace("(I think I'd rather pretend I didn't hear any of those grim\ndetails", "(Je crois que je préfère faire semblant de n'avoir rien entendu\nde ces détails macabres");
                s = s.Replace("and try to forget all about it.)", "et essayer de tout oublier au plus vite.)");
                s = s.Replace("Thank you, madame.", "Merci, madame.");
                s = s.Replace("Please continue.", "Poursuivez, je vous prie.");
                s = s.Replace("Certainly.", "Certainement.");
                s = s.Replace("So,", "Ainsi,");
                s = s.Replace("you comprehend a little of the process now,", "vous comprenez un peu mieux mon procédé à présent,");
                s = s.Replace("and why it took me so long that night.", "et pourquoi cela m'a pris tant d'heures cette nuit-là.");
                return s;
            };

            // Clé 131
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#20"] = s => {
                s = s.Replace("Rigor mortis being the phenomenon you described", "La rigidité cadavérique étant le phénomène décrit");
                s = s.Replace("whereby the corpse becomes stiff after death?", "selon lequel le corps se raidit après la mort ?");
                s = s.Replace("I think you said that it starts at the jaw,", "Il me semble que vous disiez qu'elle commence par la mâchoire,");
                s = s.Replace("about three hours\npost death.", "environ trois heures\naprès le décès.");
                s = s.Replace("Is that right?", "Est-ce bien exact ?");
                s = s.Replace("Oui,", "Oui,");
                s = s.Replace("c'est ça.", "c'est bien cela.");
                s = s.Replace("Of course", "Naturellement,");
                s = s.Replace("the exact duration depends a little\non the season.", "le délai exact varie quelque peu\nselon la saison.");
                s = s.Replace("I didn't realise a waxwork artisan would be so well\nversed in the subject.", "Je n'imaginais pas qu'une sculptrice sur cire soit si versée\ndans un tel domaine.");
                s = s.Replace("Non non,", "Non, non,");
                s = s.Replace("that is only elementary knowledge in the field\nof legal medicine.", "ce ne sont là que des notions élémentaires de\nmédecine légale.");
                s = s.Replace("(Well I had no idea about it.", "(Eh bien, je n'en avais pas la moindre idée.");
                s = s.Replace("But maybe I won't admit to\nmy ignorance about forensic science.)", "Mais je vais éviter d'avouer mon ignorance crasse en matière\nde médecine légale.)");
                s = s.Replace("Hm...", "Hum...");
                s = s.Replace("I could ask my father to give you a very simple\nprimer, if you like!", "je pourrais demander à mon père de vous donner un cours\naccéléré, si vous le souhaitez !");
                s = s.Replace("I think corpses should be your domain.", "Je crois que les cadavres resteront votre domaine.");
                s = s.Replace("I'm...", "Je ne suis...");
                s = s.Replace("not good with them.", "pas très à l'aise avec tout ça.");
                s = s.Replace("Oh dear...I'll do my very best.", "Oh là là... Je ferai de mon mieux.");
                return s;
            };

            // Clé 132
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#21"] = s => {
                s = s.Replace("You say that dawn was approaching?", "Vous disiez que l'aube approchait ?");
                s = s.Replace("What was the time of day, then?", "Quelle heure pouvait-il bien être ?");
                s = s.Replace("Approximately.", "Approximativement.");
                s = s.Replace("Well...I could not say.", "Eh bien... je ne saurais le préciser.");
                s = s.Replace("But when I left the cemetery with my utensils and wax,", "Mais quand j'ai quitté le cimetière avec mes outils et ma cire,");
                s = s.Replace("the morning light was becoming visible.", "les premières lueurs du jour perçaient déjà.");
                s = s.Replace("The execution took place on 17th June...", "L'exécution a eu lieu le 17 juin...");
                s = s.Replace("which had the\nearliest sunrise of that year.", "qui correspondait au\nlever de soleil le plus matinal de l'année.");
                s = s.Replace("Indeed it did.", "C'est tout à fait exact.");
                s = s.Replace("First light would have been at around 4:40\nin the morning.", "L'aube s'est levée aux alentours de 4 h 40\ndu matin.");
                s = s.Replace("(That really is early.)", "(C'est incroyablement tôt.)");
                s = s.Replace("The fact is,", "Le fait est que");
                s = s.Replace("I had very little time.", "j'avais très peu de temps devant moi.");
                s = s.Replace("So I finished my work in\na half hour.", "J'ai donc terminé mon œuvre en\nune demi-heure.");
                s = s.Replace("It was necessary to complete the impression", "Il fallait à tout prix achever l'empreinte");
                s = s.Replace("and bury the\nbody before daybreak, of course.", "et inhumer le\ncorps avant le jour, évidemment.");
                s = s.Replace("If somebody had discovered me there,", "Si quiconque m'avait surprise en ces lieux,");
                s = s.Replace("it would have been\na catastrophe.", "ç'eût été\nune catastrophe absolue.");
                s = s.Replace("So I had to hurry.", "Je devais donc faire vite.");
                s = s.Replace("(Is it me,", "(Est-ce mon imagination,");
                s = s.Replace("or does Mr Sholmes seem to be taking shape\nmore quickly now, too?)", "ou la statue de M. Holmes semble-t-elle\nprendre forme à toute allure elle aussi ?)");
                s = s.Replace("Hm...", "Hum...");
                s = s.Replace("You certainly appear to go to extraordinary lengths\nfor your work, madame.", "Vous déployez assurément des trésors d'audace\npour votre travail, madame.");
                return s;
            };

            // Clé 133
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#22"] = s => {
                s = s.Replace("(I wonder...", "(Je me demande...");
                s = s.Replace("Is what she just said particularly significant?)", "Ce qu'elle vient de déclarer est-il capital ?)");
                return s;
            };

            // Clé 134
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#23"] = s => {
                s = s.Replace("Madame,", "Madame,");
                s = s.Replace("those details about how long it took you to\ncomplete the sculpture", "ces précisions sur le temps qu'il vous a fallu\npour achever le moulage");
                s = s.Replace("and the early sunrise...", "et ce lever de soleil si matinal...");
                s = s.Replace("Could you include them in your testimony?", "Pourriez-vous les consigner dans votre déposition ?");
                s = s.Replace("I believe they may be significant.", "J'ai le sentiment qu'ils pourraient s'avérer cruciaux.");
                s = s.Replace("Of course,", "Certainement,");
                s = s.Replace("if you would like me to.", "si vous le désirez.");
                s = s.Replace("You're quite right, Mr Naruhodo.", "Vous avez tout à fait raison, M. Naruhodo.");
                s = s.Replace("It is intriguing.", "C'est des plus intrigants.");
                s = s.Replace("A sunrise at four in the morning", "Un lever de soleil à quatre heures du matin");
                s = s.Replace("would be absolutely\nunimaginable at home, wouldn't it?", "serait absolument\ninconcevable chez nous, n'est-ce pas ?");
                s = s.Replace("...That's not quite what I meant by ‘significant’.", "... Ce n'est pas tout à fait ce que j'entendais par « crucial ».");
                s = s.Replace("Kindly amend your formal testimony then,", "Veuillez modifier votre déposition en conséquence,");
                s = s.Replace("madame.", "madame.");
                s = s.Replace("With pleasure,", "Avec plaisir,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                return s;
            };

            // Clé 135
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#24"] = s => {
                s = s.Replace("(All it really told us", "(Tout ce que cela nous apprend,");
                s = s.Replace("is that sunrise in Great Britain is\nextremely early at the height of summer, I suppose.)", "c'est que le soleil se lève fort tôt\nen Grande-Bretagne au plus fort de l'été...)");
                s = s.Replace("Thank you, madame.", "Merci, madame.");
                s = s.Replace("That's all clear now.", "C'est très clair à présent.");
                s = s.Replace("How frustrating.", "Que c'est contrariant.");
                s = s.Replace("I was not concentrating on Mr Sholmes\nhere", "Je ne me concentrais plus sur ce cher M. Holmes,");
                s = s.Replace("and I have taken away too much wax.", "et j'ai ôté trop de cire.");
                return s;
            };

            // Clé 136
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#25"] = s => {
                s = s.Replace("Did you have reason to believe you might be discovered\nonce the sun came up or something?", "Aviez-vous des raisons de craindre d'être découverte dès\nle lever du jour ?");
                s = s.Replace("I had paid the gravedigger money", "J'avais rétribué le fossoyeur");
                s = s.Replace("to keep my little secret,\nof course.", "pour qu'il garde mon petit secret,\nbien entendu.");
                s = s.Replace("But with the morning light,", "Mais aux premières lueurs de l'aube,");
                s = s.Replace("I knew that the warden from\nthe prison", "je savais que le gardien de\nla prison");
                s = s.Replace("would commence his patrol of the area.", "entamerait sa ronde habituelle dans le secteur.");
                s = s.Replace("Couldn't you just have paid off the warden too, then?", "N'auriez-vous pas pu soudoyer le gardien également ?");
                s = s.Replace("I had already paid the gravedigger,", "J'avais déjà payé le fossoyeur,");
                s = s.Replace("as I said.", "comme je vous l'ai dit.");
                s = s.Replace("You cannot buy the silence of everyone,", "On ne peut acheter le silence de tout le monde,");
                s = s.Replace("or the secret", "ou le secret");
                s = s.Replace("is\nno longer a secret,", "cesse\nd'en être un,");
                s = s.Replace("uh?", "hein ?");
                s = s.Replace("The sunrise", "Le soleil s'est levé");
                s = s.Replace("was at 4:40 a.m. that day.", "à 4 h 40 ce jour-là.");
                s = s.Replace("Which means that it would have been around four when\nyou began your sculpting work.", "Ce qui implique que vous avez débuté votre travail de\nmoulage aux environs de quatre heures.");
                s = s.Replace("Oui,", "Oui,");
                s = s.Replace("that must be correct.", "c'est bien cela.");
                s = s.Replace("That would be when the\ngravedigger gave me the signal to come out of hiding.", "C'est l'instant où le\nfossoyeur m'a fait signe de sortir de ma cachette.");
                return s;
            };

            // Clé 137
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#26"] = s => {
                s = s.Replace("(So,", "(Ainsi,");
                s = s.Replace("that's all I have to go on...)", "c'est tout ce dont je dispose...)");
                s = s.Replace("What's your feeling,", "Quel est votre sentiment,");
                s = s.Replace("Mr Naruhodo?", "M. Naruhodo ?");
                s = s.Replace("For some reason,", "Pour une raison inconnue,");
                s = s.Replace("Dr Sithe went along with Drebber's\nplan.", "la Dre Pétrie a adhéré au plan\nde Drebber.");
                s = s.Replace("Now,", "À présent,");
                s = s.Replace("if that's really true...", "si cela est vrai...");
                s = s.Replace("...then the Professor is the only other thing we know of", "... alors le Démon Assassin est le seul autre élément connu");
                s = s.Replace("that links the pair of them.", "qui les relie tous les deux.");
                s = s.Replace("So I feel sure", "J'ai donc la certitude");
                s = s.Replace("that waxwork", "que cette statue de cire");
                s = s.Replace("must be a clue to this\nmystery somehow...", "doit être la clé de cette énigme\nd'une manière ou d'une autre...");
                s = s.Replace("In that case,", "Dans ce cas,");
                s = s.Replace("we must use this cross-examination to\nuncover exactly what it means!", "ce contre-interrogatoire doit nous servir\nà percer ce mystère au grand jour !");
                s = s.Replace("Otherwise", "Faute de quoi,");
                s = s.Replace("the jurors are sure to revert their leanings", "les jurés reviendront assurément à leur verdict coupable");
                s = s.Replace("and\nthe trial will be over!", "et\nle procès sera définitivement perdu !");
                s = s.Replace("I agree.", "Je suis d'accord.");
                s = s.Replace("But interestingly...", "Mais chose curieuse...");
                s = s.Replace("...uncovering what the Professor has to do with all of this", "... découvrir le rôle du Démon Assassin dans toute cette histoire");
                s = s.Replace("means more to Lord van Zieks than anyone.", "importe plus à Lord Van Peers qu'à quiconque.");
                s = s.Replace("That's...", "C'est...");
                s = s.Replace("the impression I'm getting, anyway.", "l'impression que j'ai, en tout cas.");
                s = s.Replace("Yes,", "Oui,");
                s = s.Replace("as do I...", "à moi également...");
                s = s.Replace("(After all,", "(Après tout,");
                s = s.Replace("he has a profound connection to the Professor as\nwell...)", "il a un lien très profond avec le Démon Assassin\nlui aussi...)");
                return s;
            };

            // Clé 138
            entryTranslators[@"BB\script\output\_sce02_c305_0030_eng#34"] = s => {
                s = s.Replace("Thank you, Counsel,", "Merci, maître,");
                s = s.Replace("that will do.", "cela suffira.");
                s = s.Replace("But,", "Mais,");
                s = s.Replace("but, My Lord,", "mais, Votre Honneur,");
                s = s.Replace("wait!", "attendez !");
                s = s.Replace("The defence is still in the process\nof establishing its argument...", "La défense est encore en train de poser\nson argumentation...");
                s = s.Replace("No further analysis is necessary,", "Aucune analyse supplémentaire n'est requise,");
                s = s.Replace("I feel.", "à mon sens.");
                s = s.Replace("As such,", "En conséquence,");
                s = s.Replace("I shall be requesting the final decisions of the\nmembers of the jury.", "je vais demander le verdict final des\nmembres du jury.");
                s = s.Replace("It's been an honour to serve,", "Ce fut un honneur de siéger,");
                s = s.Replace("My Lord.", "Votre Honneur.");
                s = s.Replace("And we know exactly what we think now.", "Et nous savons exactement ce que nous pensons désormais.");
                s = s.Replace("Guilty!", "Coupable !");
                s = s.Replace("Mr Albert Harebrayne,", "M. Samba Lonron,");
                s = s.Replace("in accordance with the findings of\nthis court,", "conformément aux conclusions de\nce tribunal,");
                s = s.Replace("I pronounce you...", "je vous déclare...");
                s = s.Replace("I applaud the jurors for doing their civic duty", "Je félicite les jurés d'avoir accompli leur devoir civique");
                s = s.Replace("and for\nfinding a swift resolution to this matter.", "et d'avoir\napporté une conclusion rapide à cette affaire.");
                s = s.Replace("That is all.", "C'est tout.");
                s = s.Replace("Court is adjourned!", "L'audience est levée !");
                return s;
            };
        }
    }
}
