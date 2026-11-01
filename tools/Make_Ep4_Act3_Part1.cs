using System;
using System.IO;
using System.Text;

class MakeEp4Act3Part1 {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorEp4Act3 {");
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

        // [1] KEY:BB\script\output\_sce03_c100_0000_eng#2
        add(@"BB\script\output\_sce03_c100_0000_eng#2", new string[,] {
            { "2nd November, 8:56 a.m.", "2 novembre, 8 h 56" },
            { "The Old Bailey, Defendants' Antechamber", "L'Old Bailey, antichambre des accusés" },
            { "(There's that old familiar feeling again...)", "(Voilà à nouveau cette vieille sensation familière...)" },
            { "(The crushing pressure of this historic courthouse.)", "(La pression écrasante de ce tribunal historique.)" },
            { "(Actually, no... It's a little different today.)", "(En réalité, non... C'est un peu différent aujourd'hui.)" },
            { "(There's an even more menacing tension in the air.)", "(Il y a une tension encore plus menaçante dans l'air.)" },
            { "There is a menacing tension in the air here today, isn't\r\nthere? I suppose...", "Il y a une tension menaçante dans l'air ici aujourd'hui,\r\nn'est-ce pas ? Enfin, j'imagine..." },
            { "Yes, I think so.", "Oui, je le pense aussi." },
            { "It can only be the result of the menacing appearance of\r\nthe defendant.", "Ce ne peut être que la conséquence de l'allure menaçante\r\nde l'accusé." },
            { "A little more courtesy, if you please.", "Un peu plus de courtoisie, je vous prie." },
            { "Oh my!\r\nI, I do apologise!", "Bonté divine !\r\nJe, je vous présente toutes mes excuses !" },
            { "However... you're certainly not mistaken that this trial is\r\nfar from ordinary.", "Toutefois... vous ne vous trompez guère en affirmant que ce\r\nprocès est loin d'être ordinaire." },
            { "What do you mean?", "Que voulez-vous dire ?" },
            { "I'm not privy to the details. However...", "Je ne suis pas dans le secret des dieux. Cependant..." },
            { "...I understand that no jury has been selected.", "...si j'ai bien compris, aucun jury n'a été sélectionné." },
            { "A trial without a jury?!\r\nWell, well that's just like...", "Un procès sans jury ?!\r\nMais, mais c'est exactement comme..." },
            { "...the trial of the Professor ten years ago!", "...le procès du Démon Assassin il y a dix ans !" },
            { "(A closed court...)", "(Un procès à huis clos...)" },
            { "Good morning, my dear fellows!", "Bonjour, mes chers amis !" },
            { "Mr Sholmes!", "Monsieur Holmes !" },
            { "Have you made note of my hair, Mr Naruhodo?\r\nAn outright victory for science, you must agree!", "Avez-vous remarqué mes cheveux, monsieur Naruhodo ?\r\nUne éclatante victoire de la science, vous en conviendrez !" },
            { "To be perfectly honest, so much happened yesterday that,\r\nwell...", "Pour être tout à fait honnête, il s'est passé tellement de choses hier que,\r\neh bien..." },
            { "...I completely forgot about your little hair problem.", "...j'avais complètement oublié votre petit problème de cheveux." },
            { "Hah! What to one man is a ‘little hair problem’...", "Ha ! Ce qui est pour l'un un « petit problème de cheveux »..." },
            { "...is to another a day of drinking dubious potion after\r\ndubious potion.", "...est pour l'autre une journée entière à avaler breuvage douteux\r\nsur breuvage douteux." },
            { "You have no idea how my stomach ails me this morning!", "Vous n'avez pas idée à quel point mon estomac me fait souffrir ce matin !" },
            { "Oh dear!\r\nHow awful for you.", "Oh là là !\r\nQuelle épreuve pour vous." },
            { "I'm afraid you only have yourself to blame, Mr Sholmes.", "J'ai bien peur que vous ne puissiez vous en prendre qu'à vous-même, monsieur Holmes." },
            { "And good morning to you, Mr Reaper.\r\nI'm delighted to see you looking so full of vim.", "Et bien le bonjour à vous, seigneur Faucheur.\r\nJe suis ravi de vous voir si vigoureux." },
            { "And I you. I see London's celebrated great detective is as\r\nactive as ever.", "Tout le plaisir est pour moi. Je constate que le grand détective londonien est\r\ntoujours aussi actif." },
            { "Oh, you exaggerate, my dear fellow. Compared to my\r\npaltry engagements with a few trivial cases...", "Oh, vous exagérez, mon cher confrère. Comparé à mes\r\nmaigres participations dans quelques broutilles..." },
            { "...the Reaper's overbearing presence is a far greater\r\ndeterrent to the black roots of crime in our capital.", "...la présence oppressante du Faucheur est un frein bien plus\r\npuissant aux racines ténébreuses du crime dans notre capitale." },
            { "And whilst I may not agree with your methods...", "Et bien que je ne cautionne guère vos méthodes..." },
            { "...there is at least one point on which I would readily\r\ncommend you.", "...il est au moins un point sur lequel je vous féliciterais\r\nvolontiers." },
            { "What an honour.\r\nAnd that would be...?", "Quel honneur.\r\nEt quel serait ce point... ?" },
            { "Your eye for a good lawyer, sir.", "Votre flair pour dénicher un bon avocat, cher monsieur." },
            { "M-Mr Sholmes!", "M-Monsieur Holmes !" },
            { "After all...", "Après tout..." },
            { "...behind this lawyer there is a very great mind.\r\nMy own.", "...derrière cet avocat se trouve un esprit hors du commun.\r\nLe mien." },
            { "What are you trying to say?", "Où voulez-vous en venir ?" },
            { "I wish only to say that you should be prepared for quite a\r\ntrial, Mr Reaper.", "Je souhaite simplement vous dire que vous devriez vous préparer à un\r\nprocès mémorable, seigneur Faucheur." },
            { "Sorry to barge in...", "Pardonnez-nous d'interrompre..." }
        });

        // [2] KEY:BB\script\output\_sce03_c100_0000_eng#3
        add(@"BB\script\output\_sce03_c100_0000_eng#3", new string[,] {
            { "Gina!", "Gina !" },
            { "(What's that on her arm?\r\nIt's a mourning band, I suppose...)", "(Qu'est-ce qu'elle a au bras ?\r\nC'est un brassard de deuil, j'imagine...)" },
            { "Father!\r\nShouldn't you be at the symposium?", "Père !\r\nNe devriez-vous pas être au colloque ?" },
            { "It's been postponed.\r\nSo I have some free time.", "Il a été reporté.\r\nJ'ai donc un peu de temps libre." },
            { "I decided to come along with the police inspector to see\r\nour country's up-and-coming student in action.", "J'ai décidé d'accompagner l'inspectrice pour voir le brillant\r\nétudiant de notre patrie à l'œuvre." },
            { "I shall be very interested to see the fruits of your studies\r\nover the past year.", "Je serai fort curieux de voir les fruits de vos études\r\nau cours de l'année écoulée." },
            { "Well... it's an honour to have you here!\r\n(Let's hope there are some fruits to see...)", "Eh bien... c'est un honneur de vous avoir parmi nous !\r\n(Espérons qu'il y aura des fruits à observer...)" },
            { "'Oddo...", "'Oddo..." },
            { "Oh! ...Yes, Gina?", "Oh ! ...Oui, Gina ?" },
            { "Why d'you agree to this, eh?\r\nWhy d'you take 'im on?", "Pourquoi t'as accepté ça, hein ?\r\nPourquoi tu prends sa défense ?" },
            { "This, this Reaper bloke...\r\nEveryone says it was 'im wot...", "Ce, ce type du Faucheur...\r\nTout le monde dit que c'est lui qui..." },
            { "...wot killed the boss.", "...qui a refroidi l'patron." },
            { "I'm sorry, Gina.", "Je suis désolé, Gina." },
            { "But I just don't believe that.", "Mais je refuse tout simplement de croire cela." },
            { "Well if it weren't 'im, who was it?!", "Ben si c'était pas lui, c'était qui alors ?!" },
            { "I don't know that... yet.", "Je ne le sais pas encore..." },
            { "I don't care who calls 'im wot. The Reaper's just a name.\r\n'E's just a person at the end o' the day.", "J'm'en fiche de comment on l'appelle. Le Faucheur, c'est juste un nom.\r\nAu bout du compte, c'est un bonhomme comme un autre." },
            { "An' if it turns out it was 'im wot killed the boss... then God\r\n'elp 'im!", "Et s'il s'avère que c'est lui qui a zigouillé l'patron... alors que Dieu\r\nlui vienne en aide !" },
            { "Fiery eyes indeed...", "Un regard de braise, en vérité..." },
            { "Yes, the culprit deserves every ounce of your loathing.", "Oui, le coupable mérite la moindre once de votre haine." },
            { "Eh?", "Hein ?" },
            { "At least that may be some solace to the deceased.", "Au moins, cela apportera peut-être quelque réconfort au défunt." },
            { "P-Please, 'Oddo...", "S-S'te plaît, 'Oddo..." },
            { "...get whoever did this.\r\nFor the boss.", "...coince celui qui a fait ça.\r\nPour l'patron." },
            { "Oh, Gina...", "Oh, Gina..." },
            { "I 'ate feelin' this useless, but there's nuffin' I can do.", "J'ai horreur de m'sentir aussi inutile, mais j'peux rien faire." },
            { "So you've gotta find who done this and make the wretch\r\npay!", "Alors tu dois trouver qui a fait ça et faire payer cette\r\ncrapule !" },
            { "Counsel for the Defence! And the defendant!", "L'avocat de la défense ! Et l'accusé !" },
            { "Court will be in session shortly.\r\nMake your way into the courtroom at once, please!", "L'audience va bientôt commencer.\r\nVeuillez rejoindre la salle d'audience sans attendre !" },
            { "(Alright then, here we go...)", "(Très bien, nous y voilà...)" },
            { "It's time, Mr Naruhodo!\r\nLord van Zieks!", "C'est l'heure, monsieur Naruhodo !\r\nLord Van Peers !" },
            { "One who lost his treasured brother to a mass murderer...", "Celui qui a perdu son frère bien-aimé aux mains d'un assassin de masse..." },
            { "One who lost his treasured father in a foreign court of\r\nlaw...", "Celui qui a perdu son père adoré devant un tribunal\r\nétranger..." },
            { "And one who lost the man who helped her escape\r\ndestitution... ", "Et celle qui a perdu l'homme qui l'a arrachée à la\r\nmisère... " },
            { "All that misfortune... all that pain... on course to collide\r\nheadlong in this trial.", "Toute cette infortune... toute cette souffrance... sur le point d'entrer\r\nen collision frontale lors de ce procès." },
            { "It's time to shine a light on all these dark events.", "Il est temps de faire toute la lumière sur ces sombres événements." },
            { "And whatever truth is revealed...", "Et quelle que soit la vérité qui éclatera..." },
            { "...we're going to have to look it straight in the eye.", "...nous devrons la regarder droit dans les yeux." }
        });

        // [3] KEY:BB\script\output\_sce03_c101_0000_eng#2
        add(@"BB\script\output\_sce03_c101_0000_eng#2", new string[,] {
            { "2nd November, 9:20 a.m.", "2 novembre, 9 h 20" },
            { "The Old Bailey Courtroom", "La salle d'audience de l'Old Bailey" },
            { "In the name of Her Majesty the Queen, I hereby declare\r\nthis court to be in session.", "Au nom de Sa Majesté la Reine, je déclare la présente\r\naudience ouverte." },
            { "We are here to conduct the fair and just trial of the\r\ndefendant, Barok van Zieks.", "Nous sommes ici réunis pour tenir le procès juste et équitable\r\nde l'accusé, Drake Van Peers." },
            { "Counsels for the defence and prosecution, are you ready\r\nto begin?", "Maître Naruhodo, procureur Asogi, êtes-vous prêts à\r\ncommencer ?" },
            { "...The defence is ready, My Lord.", "...La défense est prête, Votre Honneur." },
            { "The prosecution... is more than ready.", "L'accusation... est plus que prête." },
            { "Oh, Kazuma-sama...", "Oh, Kazuma-sama..." },
            { "(I've been wishing to see you in court again for so long, it\r\nfeels...)", "(J'ai tellement espéré te revoir dans un tribunal...)" },
            { "(But I never pictured it happening like this.)", "(Mais je n'avais jamais imaginé que cela se passerait ainsi.)" },
            { "(I never thought I'd be facing you behind the prosecution's\r\nbench.)", "(Je n'aurais jamais pensé te faire face depuis le banc de la\r\ndéfense.)" },
            { "The so-called ‘Reaper of the Bailey’...", "Celui que l'on nomme le « Faucheur de l'Old Bailey »..." },
            { "...has been a scourge like no other, undermining\r\nHer Majesty's justice system.", "...a été un fléau sans pareil, sapant l'autorité du système\r\njudiciaire de Sa Majesté." },
            { "Today we must uncover the truth behind this scourge.", "Aujourd'hui, nous devons dévoiler la vérité qui se cache derrière ce fléau." },
            { "(In other words...)", "(Autrement dit...)" },
            { "(...this trial is going to be a lot more far-reaching than\r\nInspector Gregson's murder.)", "(...ce procès va avoir une portée bien plus vaste que le seul\r\nmeurtre de l'inspecteur Gregson.)" },
            { "The truths revealed by these proceedings may have\r\nunpredictable repercussions through the judiciary.", "Les vérités révélées par ces débats pourraient avoir des\r\nrépercussions imprévisibles sur tout le système judiciaire." },
            { "Accordingly, they are to be conducted as a closed trial,\r\nwith no members of the public present.", "En conséquence, ils se tiendront sous forme d'un procès à huis clos,\r\nsans aucun membre du public." },
            { "By Her Majesty's direct orders.", "Sur ordre direct de Sa Majesté." },
            { "How will that work, My Lord?", "Comment cela fonctionnera-t-il, Votre Honneur ?" },
            { "The burden of all arbitration and adjudication falls on my\r\nshoulders.", "La charge de tout arbitrage et de tout jugement repose\r\nentièrement sur mes épaules." },
            { "Therefore, as you will see...", "Par conséquent, comme vous pouvez le constater..." },
            { "...the jurors' bench shall remain vacant today.", "...le banc des jurés restera vacant aujourd'hui." },
            { "If no members of the public are present, might I ask who\r\nis currently occupying the gallery, My Lord?", "Si aucun membre du public n'est admis, puis-je demander qui\r\noccupe actuellement la galerie, Votre Honneur ?" },
            { "They are members of the judiciary, here to witness\r\nproceedings and ensure an equitable trial.", "Ce sont des membres du corps judiciaire, venus assister aux\r\ndébats et garantir l'équité du procès." },
            { "Members of the judiciary...", "Des membres du corps judiciaire..." },
            { "Oh my... this is a very unusual trial already.", "Bonté divine... ce procès est déjà fort inhabituel." },
            { "There is of course another, unprecedented aspect to these\r\nproceedings on which I must elaborate.", "Il y a bien sûr un autre aspect sans précédent à ces\r\ndébats sur lequel je dois m'attarder." },
            { "The counsels for the prosecution and the defence are both\r\naliens of Great Britain.", "L'accusation et la défense sont toutes deux assurées par\r\ndes ressortissants étrangers à la Grande-Bretagne." },
            { "I believe it takes an outsider to see the truth sometimes.", "J'estime qu'il faut parfois le regard d'un étranger pour voir la vérité." },
            { "And as I stand here in this courtroom now, I'm quite\r\ncertain...", "Et alors que je me tiens dans ce tribunal à cet instant, je suis tout à fait\r\ncertain..." },
            { "...this is the reason why I had to come to Britain.", "...que c'est précisément la raison pour laquelle je devais venir en Grande-Bretagne." },
            { "Kazuma...?", "Kazuma... ?" }
        });

        // [4] KEY:BB\script\output\_sce03_c101_0010_eng#2
        add(@"BB\script\output\_sce03_c101_0010_eng#2", new string[,] {
            { "Very well. Let us commence proceedings.", "Très bien. Entamons les débats." },
            { "Prosecutor Asogi... your opening statement, if you please.", "Procureur Asogi... votre déclaration préliminaire, je vous prie." },
            { "Certainly, My Lord.", "Certainement, Votre Honneur." },
            { "The incident took place on 1st November at just after\r\nfive o'clock in the afternoon.", "Les faits se sont déroulés le 1er novembre, peu après\r\ndix-sept heures." },
            { "The location was a building of flats on Fresno Street on\r\nthe outskirts of the city.", "Le lieu était un immeuble d'habitation sur Fresno Street, dans\r\nles faubourgs de la ville." },
            { "The victim's body was discovered there in an old\r\nsingle-room rental property.", "Le corps de la victime y a été découvert dans un vieux logement\r\nd'une seule pièce en location." },
            { "Yes, Inspector Tobias Gregson. A name known very well indeed to this court.", "Oui, l'inspecteur Tobias Gregson. Un nom fort bien connu de ce tribunal." },
            { "Not least for his miraculous resolution of one of this\r\ncountry's grimmest cases ten years ago.", "Notamment pour sa miraculeuse résolution de l'une des affaires les\r\nplus sinistres de ce pays il y a dix ans." },
            { "The Professor case.", "L'affaire du Démon Assassin." },
            { "How sure are you about the time of the incident?", "Quelle est votre certitude quant à l'heure des faits ?" },
            { "Several witnesses on the street outside heard the gunshot,\r\nand all have reported the same time.", "Plusieurs témoins dans la rue ont entendu le coup de feu,\r\net tous ont rapporté la même heure." },
            { "(Yes, that's what Gina told us, too.\r\nThere were a number of witnesses.)", "(Oui, c'est aussi ce que Gina nous a dit.\r\nIl y avait plusieurs témoins.)" },
            { "I have here a plan of the room.", "J'ai ici le plan de la pièce." },
            { "The victim was found curled up in one corner.", "La victime a été découverte recroquevillée dans un coin." },
            { "It's believed that he was shot from the front at point-blank\r\nrange and died instantly.", "On estime qu'il a essuyé un tir de face à bout portant\r\net qu'il a été tué sur le coup." },
            { "Hm... How has the range been determined?", "Hum... Comment la distance de tir a-t-elle été établie ?" },
            { "There were scorch marks around the entry wound.", "Il y avait des traces de brûlure autour de la plaie d'entrée." },
            { "Such marks are caused by the gunpowder used to fire the\r\nbullet.", "Ces traces sont causées par la poudre à canon propulsant\r\nle projectile." },
            { "But powder hot enough to leave scorch marks is only\r\nejected a few inches beyond the end of the barrel.", "Mais une poudre assez chaude pour laisser des brûlures n'est\r\nprojetée qu'à quelques pouces au-delà du canon." },
            { "In other words, it only happens when the target is at\r\npoint-blank range.", "En d'autres termes, cela ne survient que lorsque la cible est\r\nà bout portant." },
            { "I see, yes. Thank you for the detailed explanation,\r\nCounsel.", "Je vois, parfaitement. Merci pour cette explication détaillée,\r\nmonsieur le procureur." },
            { "The autopsy report has been\r\nentered into the Court Record.", "Le rapport d'autopsie a été\r\nversé au dossier de l'affaire." },
            { "The murder weapon was found lying beside the victim.", "L'arme du crime a été retrouvée gisant aux côtés de la victime." },
            { "And have you managed to ascertain the owner of this\r\nfirearm?", "Et êtes-vous parvenu à établir qui est le propriétaire de cette\r\narme à feu ?" },
            { "No, My Lord. Not conclusively.", "Non, Votre Honneur. Pas de façon concluante." },
            { "Bravo, Kazuma-sama...", "Bravo, Kazuma-sama..." },
            { "...for not trying to use the gun as evidence when its\r\nprovenance can't be proven.", "...pour ne pas tenter d'utiliser cette arme comme preuve alors\r\nque sa provenance ne peut être attestée." },
            { "Furthermore, My Lord...", "En outre, Votre Honneur..." },
            { "As I've explained, the revolver was fired at extremely\r\nclose range.", "Comme je l'ai expliqué, le revolver a été tiré à très\r\ncourte distance." },
            { "The bullet passed through the victim and struck the wall\r\nbehind him.", "Le projectile a traversé la victime et a heurté le mur\r\nderrière elle." },
            { "There is a candelabrum mounted on that wall...", "Un chandelier mural est fixé sur cette cloison..." },
            { "...and the tip of one of the candles in it was found to have\r\nbeen blown off by the projectile.", "...et l'extrémité de l'une de ses bougies a été pulvérisée\r\npar le projectile." },
            { "We noticed that too, didn't we?", "Nous l'avions remarqué nous aussi, n'est-ce pas ?" },
            { "(Yes, that's right.)", "(Oui, c'est exact.)" },
            { "Thank you for the thorough report, Counsel.\r\nThe setting of the crime is clear to me.", "Merci pour ce compte rendu minutieux, monsieur le procureur.\r\nLe théâtre du crime m'apparaît clairement." },
            { "You will submit the plan of the crime scene as evidence,\r\nplease.", "Veuillez verser le plan de la scène de crime comme pièce à conviction,\r\nje vous prie." },
            { "As you wish, My Lord.", "À vos ordres, Votre Honneur." },
            { "The crime scene floor plan has been\r\nentered into the Court Record.", "Le plan de la scène de crime a été\r\nversé au dossier de l'affaire." },
            { "Is this Fresno Street room Inspector Gregson's private\r\nabode?", "Cette chambre de Fresno Street était-elle le domicile privé\r\nde l'inspecteur Gregson ?" },
            { "No, My Lord. The room is rented to a Mr Hugh Boone.", "Non, Votre Honneur. Cette pièce est louée à un certain M. Hugh Boone." },
            { "But there is precious little furniture inside, and it is\r\ngenerally in a poor state of repair.", "Mais elle ne contient presque aucun meuble, et son état général\r\nest fort délabré." },
            { "(So what on earth was Gregson even doing there?)", "(Mais que diable Gregson fabriquait-il là-bas ?)" },
            { "Presumably he was investigating some case or other...", "Sans doute enquêtait-il sur quelque affaire..." },
            { "When a policeman was informed of the gunshot from the\r\nwitnesses and rushed to the scene...", "Lorsqu'un agent de police, alerté par les témoins ayant entendu le coup de feu, s'est précipité sur les lieux..." },
            { "...he found only the deceased inspector and the accused\r\nstanding alongside holding the revolver.", "...il n'a trouvé que le défunt inspecteur et l'accusé debout\r\nà ses côtés, tenant le revolver." },
            { "The attending officer arrested the accused on the spot.", "L'agent présent a arrêté l'accusé sur-le-champ." },
            { "So... the details of the case are clear.", "Ainsi... les détails des faits sont clairs." },
            { "In that case, the prosecution would like to call its first\r\nwitness.", "Dans ce cas, l'accusation souhaiterait appeler son premier\r\ntémoin." },
            { "A name please, Counsel.", "Un nom, je vous prie, monsieur le procureur." },
            { "Naturally... the accused himself.", "Naturellement... l'accusé lui-même." },
            { "L-Lord van Zieks?!", "L-Lord Van Peers ?!" },
            { "As a prosecutor, he believes in the oath of office he's\r\ntaken and will be compelled to tell the truth.", "En tant que procureur, il a prêté serment devant la justice\r\net se trouvera tenu de dire la vérité." },
            { "Very well, let the defendant take the witness stand!", "Très bien, que l'accusé s'avance à la barre !" }
        });

        // [5] KEY:BB\script\output\_sce03_c101_0020_eng#2
        add(@"BB\script\output\_sce03_c101_0020_eng#2", new string[,] {
            { "So, witness... state your name and occupation for the court.", "Témoin... déclinez vos nom et profession devant ce tribunal." },
            { "Barok van Zieks, Old Bailey prosecutor.", "Drake Van Peers, procureur de l'Old Bailey." },
            { "I presume, Lord van Zieks, that you heard Prosecutor\r\nAsogi's opening precis.", "Je présume, Lord Van Peers, que vous avez entendu le résumé\r\npréliminaire du procureur Asogi." },
            { "I did.", "Parfaitement." },
            { "It is alleged that you were found at the scene of the\r\ncrime...", "Il est affirmé que vous vous trouviez sur les lieux du crime..." },
            { "...and that you were arrested by the arriving police\r\nofficer. Can you confirm this?", "...et que vous avez été appréhendé par le premier agent de police arrivé sur place.\r\nConfirmez-vous ces faits ?" },
            { "Yes, My Lord.", "Oui, Votre Honneur." },
            { "Then I'm sure the court would like to hear you explain\r\nsome things away.", "Dans ce cas, le tribunal aimerait entendre vos explications\r\nsur certains points." },
            { "Namely why you were there in the room on Fresno\r\nStreet at the time in question.", "Notamment la raison de votre présence dans cette pièce de Fresno\r\nStreet à l'heure fatidique." },
            { "And what exactly took place.", "Et ce qui s'y est exactement déroulé." },
            { "I intend to explain away nothing.\r\nI will simply tell the truth.", "Je n'ai nullement l'intention d'inventer des prétextes.\r\nJe me contenterai de dire la vérité." },
            { "I must say, Lord van Zieks, I never imagined this day\r\nwould come.", "Je dois dire, Lord Van Peers, que je n'aurais jamais imaginé que\r\nce jour viendrait." },
            { "Or rather...\r\n...I didn't want to imagine it would come.", "Ou plutôt...\r\n...je ne voulais point imaginer qu'il adviendrait." },
            { "But since you became known as the Reaper...\r\n...a part of me has been dreading it.", "Mais depuis que vous êtes surnommé le Faucheur...\r\n...une part de moi n'a cessé de le redouter." },
            { "Your formal testimony then, witness!", "Votre déposition officielle à présent, témoin !" }
        });

        // [6] KEY:BB\script\output\_sce03_c101_0030_eng#2
        add(@"BB\script\output\_sce03_c101_0030_eng#2", new string[,] {
            { "– The Facts of the Incident –", "– Les faits de l'affaire –" },
            { "I was investigating Gregson, and my inquiries had led me\r\nto that address.", "J'enquêtais sur Gregson, et mes investigations m'avaient conduit\r\nà cette adresse." },
            { "When I first entered the room that day, it was dark inside\r\nand I saw no one.", "Lorsque je suis entré dans la pièce, il y faisait sombre\r\net je n'ai vu personne." },
            { "A moment later, I heard the gunshot. I spun around, and\r\nsaw the revolver on the floor.", "Un instant plus tard, j'ai entendu le coup de feu. Je me suis retourné\r\net j'ai vu le revolver sur le sol." }
        });

        // [7] KEY:BB\script\output\_sce03_c101_0030_eng#3
        add(@"BB\script\output\_sce03_c101_0030_eng#3", new string[,] {
            { "Just as I picked the firearm up to examine it, the door\r\nflew open and I heard a man scream.", "Au moment où je ramassais l'arme pour l'examiner, la porte\r\ns'est ouverte avec fracas et j'ai entendu un homme crier." },
            { "It was only then that the body of Inspector Gregson\r\nappeared before me.", "C'est seulement à cet instant que le corps de l'inspecteur Gregson\r\nest apparu sous mes yeux." }
        });

        // [8] KEY:BB\script\output\_sce03_c101_0030_eng#5
        add(@"BB\script\output\_sce03_c101_0030_eng#5", new string[,] {
            { "That testimony was the whole truth?\r\nIt was.", "Cette déposition était-elle l'exacte vérité ?\r\nElle l'était." },
            { "So... you heard a shot being fired in a room with no living\r\noccupants...", "Ainsi... vous avez entendu un tir résonner dans une pièce sans occupant\r\nvivant..." },
            { "...and moments later a corpse somehow appeared before\r\nyour eyes. Is that it?", "...et quelques instants après, un cadavre s'est matérialisé par enchantement\r\ndevant vos yeux. C'est bien cela ?" },
            { "You're right, you haven't explained away anything.\r\nIn fact that would barely qualify as an excuse.", "Vous avez raison, vous n'avez absolument rien élucidé.\r\nÀ vrai dire, cela ressemble à peine à une excuse." },
            { "I thought you were my mute apprentice.", "Je pensais que vous étiez mon apprenti muet." },
            { "Yet it turns out you have a way with words...\r\nProsecutor Asogi.", "Mais il s'avère que vous avez le sens de la formule...\r\nprocureur Asogi." },
            { "Hmmm... It would appear to be a singular tale indeed.", "Hummm... Cela apparaît en effet comme un récit des plus singuliers." },
            { "Singular isn't the word. It's laughable.", "Singulier n'est pas le mot. C'est risible." },
            { "(What's got into Kazuma? He's not behaving like himself at\r\nall...)", "(Qu'est-ce qui prend à Kazuma ? Il ne se conduit pas du tout\r\ncomme d'habitude...)" },
            { "Very well, then.\r\nCounsel, you may begin your cross-examination.", "Bien, dans ce cas.\r\nMaître Naruhodo, vous pouvez débuter votre contre-interrogatoire." },
            { "Yes, My Lord!", "À vos ordres, Votre Honneur !" }
        });

        // [9] KEY:BB\script\output\_sce03_c101_0040_eng#2
        add(@"BB\script\output\_sce03_c101_0040_eng#2", new string[,] {
            { "– The Facts of the Incident –", "– Les faits de l'affaire –" }
        });

        // [10] KEY:BB\script\output\_sce03_c101_0040_eng#4
        add(@"BB\script\output\_sce03_c101_0040_eng#4", new string[,] {
            { "I was investigating Gregson, and my inquiries had led me\r\nto that address.", "J'enquêtais sur Gregson, et mes investigations m'avaient conduit\r\nà cette adresse." }
        });

        // [11] KEY:BB\script\output\_sce03_c101_0040_eng#5
        add(@"BB\script\output\_sce03_c101_0040_eng#5", new string[,] {
            { "When I first entered the room that day, it was dark inside\r\nand I saw no one.", "Lorsque je suis entré dans la pièce, il y faisait sombre\r\net je n'ai vu personne." }
        });

        // [12] KEY:BB\script\output\_sce03_c101_0040_eng#6
        add(@"BB\script\output\_sce03_c101_0040_eng#6", new string[,] {
            { "A moment later, I heard the gunshot. I spun around, and\r\nsaw the revolver on the floor.", "Un instant plus tard, j'ai entendu le coup de feu. Je me suis retourné\r\net j'ai vu le revolver sur le sol." }
        });

        // [13] KEY:BB\script\output\_sce03_c101_0040_eng#7
        add(@"BB\script\output\_sce03_c101_0040_eng#7", new string[,] {
            { "Just as I picked the firearm up to examine it, the door\r\nflew open and I heard a man scream.", "Au moment où je ramassais l'arme pour l'examiner, la porte\r\ns'est ouverte avec fracas et j'ai entendu un homme crier." }
        });

        // [14] KEY:BB\script\output\_sce03_c101_0040_eng#8
        add(@"BB\script\output\_sce03_c101_0040_eng#8", new string[,] {
            { "It was only then that the body of Inspector Gregson\r\nappeared before me.", "C'est seulement à cet instant que le corps de l'inspecteur Gregson\r\nest apparu sous mes yeux." }
        });

        // [15] KEY:BB\script\output\_sce03_c101_0040_eng#9
        add(@"BB\script\output\_sce03_c101_0040_eng#9", new string[,] {
            { "(So... that's Lord van Zieks's account.)", "(Ainsi... voilà la version de Lord Van Peers.)" },
            { "Do you have any thoughts, Mr Naruhodo?", "Avez-vous une opinion, monsieur Naruhodo ?" },
            { "Yes... mainly that it really doesn't ring true in all sorts of\r\nways.", "Oui... surtout qu'elle sonne terriblement faux à bien des\r\négards." },
            { "Who fired the gun if there was nobody else there?\r\nAnd how did the corpse just appear in front of him?", "Qui a tiré si personne d'autre ne s'y trouvait ?\r\nEt comment le cadavre a-t-il pu apparaître devant lui ?" },
            { "So... you think Lord van Zieks is lying?", "Alors... vous pensez que Lord Van Peers ment ?" },
            { "No, I don't think that.\r\nI mean, if he was going to lie...", "Non, je ne crois pas cela.\r\nJe veux dire, s'il devait mentir..." },
            { "...I would expect him to have come up with a more\r\ncredible story, wouldn't you?", "...on pourrait s'attendre à ce qu'il invente une histoire plus\r\ncrédible, vous ne croyez pas ?" },
            { "Yes, I completely agree.", "Oui, je suis entièrement d'accord." },
            { "I think he genuinely doesn't know what really happened\r\nhimself.", "Je pense qu'il ignore lui-même sincèrement ce qui s'est passé." },
            { "So we must do what we can to fill in the gaps.", "Nous devons donc faire tout notre possible pour combler les manques." },
            { "Yes, first and foremost, we need more information!", "Oui, avant toute chose, il nous faut plus d'informations !" }
        });

        // [16] KEY:BB\script\output\_sce03_c101_0040_eng#11
        add(@"BB\script\output\_sce03_c101_0040_eng#11", new string[,] {
            { "You were investigating the inspector?\r\nWhat on earth for?", "Vous enquêtiez sur l'inspecteur ?\r\nPour quelle raison ?" },
            { "I'm not at liberty to say.", "Je ne suis pas en mesure de le divulguer." },
            { "Sorry?", "Pardon ?" },
            { "I'd identified a distinct possibility that Gregson was\r\ninvolved in a case I was investigating.", "J'avais identifié une nette possibilité que Gregson fût\r\nimpliqué dans une affaire sur laquelle j'enquêtais." },
            { "Regrettably, though... he was killed before I could secure\r\nthe proof I needed.", "Malheureusement... il a été tué avant que je ne puisse obtenir\r\nla preuve requise." },
            { "Is the court to understand then, that on the day in\r\nquestion you followed the victim to the scene?", "Le tribunal doit-il en déduire que le jour dit,\r\nvous avez filé la victime jusqu'aux lieux du drame ?" },
            { "...No. I was privy to his movements in advance.", "...Non. J'avais connaissance de ses déplacements à l'avance." },
            { "How?", "Comment cela ?" },
            { "I stole into his office in the Yard and consulted his diary.", "Je me suis introduit dans son bureau au Yard et j'ai consulté son carnet." },
            { "The address on Fresno Street was noted in the 5 p.m.\r\nentry.", "L'adresse de Fresno Street était consignée à la case\r\nde dix-sept heures." },
            { "You illegally entered the man's office? In Japan that alone\r\nwould constitute a very serious offence.", "Vous vous êtes introduit illégalement dans son bureau ? Au Japon,\r\ncela constituerait à soi seul un délit gravissime." },
            { "As it does in Great Britain, I assure you.\r\nIs that not the case, Lord van Zieks?", "Comme en Grande-Bretagne, je vous l'assure.\r\nN'est-ce point le cas, Lord Van Peers ?" },
            { "...I was aware of the possible consequences.", "...J'étais conscient des conséquences éventuelles." },
            { "So, in summary, you were investigating the victim...", "Ainsi, pour résumer, vous enquêtiez sur la victime..." },
            { "...and yet you refuse to tell the court why.", "...et pourtant vous refusez de dire pourquoi à ce tribunal." },
            { "I didn't realise British prosecutors enjoyed such freedom\r\nto choose what to divulge under oath.", "J'ignorais que les procureurs britanniques jouissaient d'une telle liberté\r\nde choisir ce qu'ils daignent révéler sous serment." },
            { "Ugh...\r\n(Why did I ever think I could defend this man?)", "Ouh...\r\n(Pourquoi ai-je cru un instant pouvoir défendre cet homme ?)" }
        });

        // [17] KEY:BB\script\output\_sce03_c101_0040_eng#12
        add(@"BB\script\output\_sce03_c101_0040_eng#12", new string[,] {
            { "Had you ever been to the address before?", "Vous étiez-vous déjà rendu à cette adresse auparavant ?" },
            { "No, never. I only learnt of the place as a result of my\r\ninvestigations into Gregson's activities.", "Non, jamais. Je n'ai découvert cet endroit qu'au fil de mes\r\nrecherches sur les agissements de Gregson." },
            { "There was no light inside when I entered, so it was all\r\nbut impossible to make out anything.", "Il n'y avait aucune lumière quand je suis entré, si bien qu'il était\r\npresque impossible de distinguer quoi que ce soit." },
            { "But at 5 p.m. the sun would only just have gone down.\r\nIt would still have been reasonably light outside.", "Mais à dix-sept heures, le soleil venait tout juste de se coucher.\r\nIl devait encore faire relativement jour dehors." },
            { "The room has a window, but it was boarded shut.", "La pièce possède une fenêtre, mais elle était barricadée par des planches." },
            { "Very little light found its way into the room from outside,\r\nso it was extremely murky inside.", "Très peu de clarté pénétrait depuis l'extérieur,\r\nl'intérieur était donc plongé dans une grande pénombre." },
            { "I wouldn't have noticed if the victim was already lying\r\non the floor.", "Je n'aurais pas remarqué si la victime gisait déjà\r\nsur le sol." },
            { "There was no artificial light in the room, you say?\r\nYou're quite sure?", "Il n'y avait aucun éclairage artificiel dans la pièce, dites-vous ?\r\nEn êtes-vous tout à fait certain ?" },
            { "I'm quite sure that the part of the room where the body\r\nwas found was very dark.", "Je suis certain que l'endroit où le corps a été découvert\r\nétait fort obscur." },
            { "I have a feeling there was a small oil lamp burning on the\r\ndesk, though I couldn't say for certain.", "J'ai le sentiment qu'une petite lampe à huile brûlait sur le\r\nbureau, mais je ne saurais l'affirmer catégoriquement." },
            { "Look, Mr Naruhodo...", "Regardez, monsieur Naruhodo..." },
            { "There is a small desk in the room just here.", "Il y a un petit bureau dans la pièce, juste ici." },
            { "Yes, I remember. And there was an oil lamp on it.\r\nAs well as the framed photograph.", "Oui, je me rappelle. Et une lampe à huile s'y trouvait.\r\nAinsi qu'une photographie encadrée." },
            { "When I entered the room, I closed the door behind me\r\nand started towards the desk to investigate.", "Lorsque je suis entré, j'ai refermé la porte derrière moi\r\net me suis dirigé vers le bureau pour inspecter les lieux." },
            { "And what did you find?", "Et qu'avez-vous trouvé ?" },
            { "Nothing. I never actually reached the desk.", "Rien. Je n'ai en vérité jamais atteint ce bureau." }
        });

        // [18] KEY:BB\script\output\_sce03_c101_0040_eng#13
        add(@"BB\script\output\_sce03_c101_0040_eng#13", new string[,] {
            { "So... who fired the gun?", "Alors... qui a tiré le coup de feu ?" },
            { "I have no idea.\r\nI didn't see anybody else in the room.", "Je n'en ai aucune idée.\r\nJe n'ai vu personne d'autre dans la pièce." },
            { "But you say it was very dark in there?", "Mais vous disiez qu'il y faisait très sombre ?" },
            { "Yes, that's right.", "Oui, c'est exact." },
            { "All I can tell you is, I didn't sense another's presence.", "Tout ce que je puis vous dire, c'est que je n'ai senti nulle autre présence." },
            { "Aha! Then could it be...", "Aha ! Serait-il possible alors..." },
            { "...that the gunshot actually originated from somewhere\r\noutside the room?!", "...que la détonation provienne en réalité de quelque part\r\nà l'extérieur de la pièce ?!" },
            { "No, that's out of the question.", "Non, c'est hors de question." },
            { "Oh.", "Oh." },
            { "Without doubt, the sound emanated from inside the room.\r\nI could smell the gunpowder.", "Sans le moindre doute, le bruit émanait de l'intérieur de la pièce.\r\nJ'ai senti l'odeur de la poudre à canon." },
            { "(Ugh, this is going from bad to worse...)", "(Ouh là, cela va de mal en pis...)" },
            { "And you say that's the point at which you noticed the\r\nrevolver on the floor?", "Et vous dites que c'est à cet instant que vous avez remarqué\r\nle revolver sur le plancher ?" },
            { "Correct. And I foolishly picked it up.\r\nThat was carelessness on my part.", "Exactement. Et je l'ai sottement ramassé.\r\nCe fut une négligence de ma part." },
            { "Presumably then, the gunshot you heard came from the\r\nfirearm that you somewhat hastily took in your hands.", "Dès lors, le coup de feu entendu provenait sans doute de l'arme\r\nque vous avez saisie avec tant de précipitation." },
            { "In point of fact, My Lord... I believe it did not.", "En réalité, Votre Honneur... je crois qu'il n'en était rien." },
            { "What?", "Quoi ?" },
            { "The barrel of the revolver I picked up was cold, and\r\nthere was no smell of spent powder.", "Le canon du revolver que j'ai ramassé était froid, et\r\nil ne dégageait aucune odeur de poudre consumée." },
            { "But, but then... where on earth is the gun that WAS fired?", "Mais alors... où diable est passée l'arme qui A tiré ?" },
            { "Whilst I would like to oblige you with an answer...\r\n...I'm afraid I can't. I, too, would dearly like to know that.", "Bien que j'aimerais vous éclairer de mes lumières...\r\n...j'en suis incapable. Moi aussi, j'aimerais fort le savoir." },
            { "Uuuuuugh...", "Ouuuuuh..." }
        });

        // [19] KEY:BB\script\output\_sce03_c101_0040_eng#14
        add(@"BB\script\output\_sce03_c101_0040_eng#14", new string[,] {
            { "A man, you say?\r\nOne of the witnesses, I presume?", "Un homme, dites-vous ?\r\nL'un des témoins, je présume ?" },
            { "That's right. One of the street merchants working on\r\nFresno Street.", "C'est exact. L'un des marchands ambulants qui travaillent\r\nsur Fresno Street." },
            { "Who are these merchants?", "Qui sont ces marchands ?" },
            { "A number of them had set up their stalls directly beneath\r\nthe boarded window of the crime scene.", "Plusieurs d'entre eux avaient installé leurs étals juste sous\r\nla fenêtre condamnée de la scène de crime." },
            { "A match-seller, a newsmonger and a pedlar. They've all\r\ngiven statements saying they heard the gunshot.", "Un vendeur d'allumettes, un colporteur de nouvelles et un camelot. Ils ont\r\ntous déclaré avoir entendu la détonation." },
            { "And without thought of danger, they ran inside to see\r\nwhat had happened.", "Et au mépris du danger, ils ont accouru à l'intérieur pour voir\r\nce qui s'était passé." },
            { "Yes... Gina told us about that yesterday, didn't she?", "Oui... Gina nous a raconté cela hier, n'est-ce pas ?" },
            { "They burst through the door with some force, it would\r\nseem.", "Ils ont enfoncé la porte avec une certaine vigueur,\r\nsemble-t-il." },
            { "They did. And almost gave me a heart attack in the\r\nprocess.", "Parfaitement. Et ont failli me provoquer une crise cardiaque\r\npar la même occasion." },
            { "(But you're supposed to be the Reaper...)", "(Venant du redoutable Faucheur...)" },
            { "The first man to come in immediately noticed the\r\nrevolver in my hand and fled.", "Le premier homme à entrer a aussitôt remarqué le\r\nrevolver dans ma main et s'est enfui." },
            { "A policeman patrolling on Fresno Street heard the\r\ncommotion...", "Un agent de police patrouillant sur Fresno Street a entendu\r\nle vacarme..." },
            { "...and was able to arrest the accused shortly after the\r\nincident occurred.", "...et a pu interpeller l'accusé peu de temps après que les faits\r\nse soient produits." },
            { "Anyway, the man's scream drew my attention in that\r\ndirection.", "Quoi qu'il en soit, le cri de cet individu a attiré mon attention\r\ndans cette direction." }
        });

        // [20] KEY:BB\script\output\_sce03_c101_0040_eng#15
        add(@"BB\script\output\_sce03_c101_0040_eng#15", new string[,] {
            { "Um... what do you mean by that?\r\nIn what way did the body ‘appear’?", "Euh... que voulez-vous dire par là ?\r\nDe quelle manière le corps est-il « apparu » ?" },
            { "I honestly can't explain it.\r\nBut it's the truth.", "Je ne saurais l'expliquer, en toute honnêteté.\r\nMais c'est la vérité." },
            { "As far as I was concerned, the body hadn't been there\r\nuntil that point, and then suddenly... there it was.", "Pour autant que je sache, le corps ne se trouvait pas là\r\njusqu'à cet instant, et soudainement... il était là." },
            { "Did you perhaps hear the sound of the victim falling to\r\nthe ground just beforehand?", "Avez-vous peut-être entendu le bruit de la victime s'effondrant\r\nsur le plancher juste avant ?" },
            { "At that moment, what I heard...", "À cet instant précis, ce que j'ai entendu..." },
            { "...was the sound of the door flying open and the scream\r\nof the man who came inside first. Nothing more.", "...c'était le fracas de la porte et le hurlement de l'homme\r\nqui est entré le premier. Rien de plus." },
            { "I see...", "Je vois..." },
            { "After the man fled, I examined the body.", "Après la fuite de cet homme, j'ai examiné le corps." },
            { "I was stunned to find that it was Gregson.", "Je fus stupéfait de constater qu'il s'agissait de Gregson." },
            { "Hmmm... Most curious circumstances indeed.", "Hummm... Circonstances fort curieuses, en vérité." },
            { "How the inspector was killed, or how his body seemed\r\nto appear out of nowhere...", "Comment l'inspecteur a été assassiné, ou comment son corps a semblé\r\nsurgir de nulle part..." },
            { "...I have no idea.", "...je n'en ai pas la moindre idée." }
        });

        // [21] KEY:BB\script\output\_sce03_c101_0040_eng#22
        add(@"BB\script\output\_sce03_c101_0040_eng#22", new string[,] {
            { "That will do!", "Cela suffit !" },
            { "I believe I have heard quite enough evidence to form an\r\nunbiased opinion.", "J'estime avoir entendu suffisamment d'éléments pour me forger une\r\nopinion impartiale." },
            { "As this is a closed trial, the findings of this court will not\r\nbe disclosed to the public.", "S'agissant d'un procès à huis clos, les conclusions de ce tribunal\r\nne seront point divulguées au public." },
            { "However, this will be the very last time the Reaper stands\r\nin this or any other courtroom.", "Toutefois, ce sera la toute dernière fois que le Faucheur comparaîtra\r\ndans cette salle d'audience ou toute autre." },
            { "B-But, My Lord! Wait!", "M-Mais, Votre Honneur ! Attendez !" },
            { "Barok van Zieks, in accordance with the findings of this\r\ncourt, I pronounce you...", "Drake Van Peers, conformément aux constatations de ce\r\ntribunal, je vous déclare..." },
            { "That is all. Court is adjourned!", "C'est tout. L'audience est levée !" }
        });

        // [22] KEY:BB\script\output\_sce03_c101_0050_eng#2
        add(@"BB\script\output\_sce03_c101_0050_eng#2", new string[,] {
            { "Surely the court has heard enough!", "Le tribunal en a assurément assez entendu !" },
            { "My Lord, the cross-examination has clearly revealed...", "Votre Honneur, ce contre-interrogatoire a clairement révélé..." },
            { "...that the accused, Barok van Zieks... is lying on multiple\r\nfronts!", "...que l'accusé, Drake Van Peers... ment sur toute la\r\nligne !" },
            { "Wha...\r\nWhat is THAT supposed to mean?!", "Quoi...\r\nQu'est-ce que CELA signifie ?!" },
            { "...Good gracious, Counsel!", "...Bonté divine, monsieur le procureur !" },
            { "The defendant is lying, you say?", "L'accusé ment, dites-vous ?" },
            { "In his testimony just now...", "Dans sa déposition à l'instant..." },
            { "...he claims that he failed to notice the victim's body\r\nbecause the room was dark.", "...il prétend qu'il n'a pas remarqué le corps de la victime\r\nparce qu'il faisait sombre dans la pièce." },
            { "That's correct.", "C'est exact." },
            { "No... that's impossible.", "Non... c'est impossible." },
            { "As proven by this candelabrum.", "Comme le démontre ce chandelier mural." },
            { "How does that prove anything?", "En quoi cela prouve-t-il quoi que ce soit ?" },
            { "It you examine the tip of the long candle, you can see it\r\nhas been blown off by a powerful impact.", "Si l'on examine l'extrémité de la longue bougie, on constate qu'elle\r\na été soufflée par un impact puissant." },
            { "One would assume that the projectile from the firearm\r\npassed through the victim and struck the candle.", "On pourrait en déduire que le projectile a traversé\r\nla victime avant de frapper la bougie." },
            { "The problem comes when you consider the other two\r\ncandles, which are clearly of a different length.", "Le problème survient lorsqu'on examine les deux autres bougies,\r\nqui sont visiblement d'une longueur différente." },
            { "Yes, I can see that only the candle that appears to have\r\nbeen struck by the bullet is long.", "Oui, je constate en effet que seule la bougie heurtée par la balle\r\nest longue." },
            { "We could reasonably expect someone to have lit all\r\nthree candles together.", "On peut raisonnablement supposer qu'une personne avait allumé les trois\r\nbougies ensemble." },
            { "Which begs the question of why only one has ended up\r\nlonger than the others.", "Ce qui soulève la question : pourquoi une seule est-elle\r\ndemeurée plus longue que les autres ?" },
            { "That... must be because that particular candle was\r\nextinguished when the others were still burning...", "Ce... cela doit être parce que cette bougie précise a été\r\néteinte pendant que les autres continuaient de se consumer..." },
            { "...Ah!", "...Ah !" },
            { "That's right. When the candle was hit by the bullet, it\r\nobviously went out.", "C'est exact. Lorsque la bougie a été frappée par la balle,\r\nelle s'est de toute évidence éteinte." },
            { "But the other two candles would still have been burning.\r\nSo the fact is...", "Mais les deux autres ont continué à brûler.\r\nDès lors..." },
            { "...the victim's body would have been illuminated by the\r\nlight still thrown by the candelabrum!", "...le corps de la victime a obligatoirement été illuminé par la\r\nlumière que projetait encore le chandelier mural !" },
            { "And the accused's claim that he couldn't see the body...\r\nclearly contradicts those facts!", "Et l'affirmation de l'accusé prétendant qu'il ne pouvait voir le corps...\r\ncontredit de manière flagrante la réalité des faits !" },
            { "And now to the next lie.", "Et passons à présent au mensonge suivant." },
            { "There's more?!", "Il y en a d'autres ?!" },
            { "The accused also claims never to have visited the scene\r\nof the crime before.", "L'accusé prétend également ne s'être jamais rendu sur la scène\r\ndu crime auparavant." },
            { "That's the truth.", "C'est la stricte vérité." },
            { "In that almost empty room, the police discovered\r\nsomething very unusual.", "Dans cette pièce presque vide, la police a découvert\r\nquelque chose de fort inhabituel." },
            { "A board covered from top to bottom in police documents\r\nand newspaper cuttings.", "Un tableau d'affichage recouvert de haut en bas de documents de police\r\net de coupures de journaux." },
            { "Yes, that's right. We saw it, too.", "Oui, c'est exact. Nous l'avons vu nous aussi." },
            { "It goes without saying that the contents of the police\r\ndocuments cannot be divulged. However...", "Il va sans dire que le contenu de ces dossiers ne saurait être divulgué.\r\nCependant..." },
            { "...they included a number of reports from various\r\nhistorical cases.", "...ils comprenaient plusieurs rapports d'affaires criminelles\r\npassées." },
            { "The oldest of which... was from ten years ago.", "La plus ancienne d'entre elles... remonte à dix ans." },
            { "(Ten years ago? This is starting to sound familiar...)", "(Il y a dix ans ? Cela commence à me rappeler quelque chose...)" },
            { "And there is a common thread linking all of the\r\ndocuments on that board.", "Et il existe un fil conducteur reliant l'ensemble des\r\ndocuments fixés sur ce tableau." },
            { "Indeed? What is this common thread, Counsel?", "Vraiment ? Quel est ce fil conducteur, monsieur le procureur ?" },
            { "They all relate to cases prosecuted in court by Barok van\r\nZieks.", "Ils se rapportent tous à des affaires instruites au tribunal par Drake\r\nVan Peers." },
            { "All of them?", "Toutes sans exception ?" },
            { "And furthermore... all those cases are ones in which the\r\ndefendant was acquitted.", "Et qui plus est... il s'agit pour chacune d'entre elles de dossiers où\r\nl'accusé a été acquitté." },
            { "Good Lord!", "Grand Dieu !" },
            { "Interestingly, none of those defendants are alive today.", "Fait troublant : aucun de ces accusés n'est en vie aujourd'hui." },
            { "Because all of them have been sent to their graves... by\r\nthe Reaper.", "Car tous ont été précipités dans la tombe... par\r\nle Faucheur." },
            { "Ah!", "Ah !" },
            { "Oh no...", "Oh non..." },
            { "In short! That dingy little room...", "En résumé ! Cette misérable petite chambre..." },
            { "...is the Reaper's secret hideout... and his base of\r\noperations!", "...n'est autre que le repaire secret du Faucheur... et sa base\r\nd'opérations !" },
            { "The, the Reaper's hideout?!", "Le, le repaire du Faucheur ?!" },
            { "And yet the Reaper would claim never to have been to\r\nhis own secret hideout?", "Et le Faucheur oserait prétendre ne s'être jamais rendu dans\r\nson propre repaire secret ?" },
            { "No one would believe that.\r\nNo, the truth is... we've been looking at this backwards.", "Personne n'y croirait.\r\nNon, la vérité... c'est que nous avons pris le problème à l'envers." },
            { "Backwards?\r\nExplain, Counsel!", "À l'envers ?\r\nExpliquez-vous, monsieur le procureur !" },
            { "Inspector Gregson was investigating the identity of the\r\nReaper.", "L'inspecteur Gregson enquêtait sur l'identité du\r\nFaucheur." },
            { "When he discovered the location of the man's secret\r\nhideout... he was killed.", "Lorsqu'il a localisé le repaire secret de cet individu...\r\nil a été abattu." },
            { "As I'm sure everyone can imagine... by the Reaper's hand!", "Comme chacun peut aisément l'imaginer... de la main même du Faucheur !" }
        });

        // [23] KEY:BB\script\output\_sce03_c101_0050_eng#3
        add(@"BB\script\output\_sce03_c101_0050_eng#3", new string[,] {
            { "Inspector Gregson was investigating the identity of the\r\nReaper.", "L'inspecteur Gregson enquêtait sur l'identité du\r\nFaucheur." },
            { "When he discovered the location of the man's secret\r\nhideout... he was killed.", "Lorsqu'il a localisé le repaire secret de cet individu...\r\nil a été abattu." },
            { "As I'm sure everyone can imagine... by the Reaper's hand!", "Comme chacun peut aisément l'imaginer... de la main même du Faucheur !" }
        });

        // [24] KEY:BB\script\output\_sce03_c101_0050_eng#4
        add(@"BB\script\output\_sce03_c101_0050_eng#4", new string[,] {
            { "Wha...", "Quoi..." },
            { "WHAAAAAAAAAT?!", "QUÔÔÔÔÔÔÔÔÔÔI ?!" }
        });

        // [25] KEY:BB\script\output\_sce03_c101_0060_eng#2
        add(@"BB\script\output\_sce03_c101_0060_eng#2", new string[,] {
            { "Ordaaar! Ordaaar! Orrrdaaar!", "Silence ! Silence ! Silence dans la salle !" },
            { "Very well. I hereby state the current opinion of the court.", "Très bien. J'énonce ici la position actuelle de ce tribunal." },
            { "Barok van Zieks is an outstanding prosecutor who has\r\nrendered great service to his country.", "Drake Van Peers est un procureur éminent qui a rendu\r\nd'inestimables services à sa patrie." },
            { "However, it is with deep regret that I must concur with\r\nProsecutor Asogi's contention...", "Néanmoins, c'est avec un profond regret que je dois souscrire à\r\nl'argumentation du procureur Asogi..." },
            { "...that the defendant's testimony exhibits a number of\r\nstark inconsistencies with the known facts.", "...selon laquelle la déposition de l'accusé présente de criantes\r\nincohérences avec les faits avérés." },
            { "All I have done is state the truth as I know it.", "Je n'ai fait qu'énoncer la vérité telle que je la connais." },
            { "(Kazuma's done a brilliant job as ever.)", "(Kazuma a fait un travail remarquable, comme d'habitude.)" },
            { "(He's drawing on his experience as a defence attorney to\r\nbuild his prosecution case... and it's formidable.)", "(Il s'appuie sur son expérience d'avocat de la défense pour\r\nbâtir son accusation... et c'est redoutable.)" },
            { "Counsel...", "Monsieur le procureur..." },
            { "...you will submit the board that you just showed the\r\ncourt as evidence.", "...vous verserez le tableau que vous venez de présenter\r\nau dossier de ce tribunal." },
            { "I believe it to be fundamental in establishing the facts\r\nsurrounding the Reaper's existence.", "J'estime qu'il est capital pour établir les faits entourant\r\nl'existence du Faucheur." },
            { "Thank you, My Lord.", "Merci, Votre Honneur." },
            { "The noticeboard has been\r\nentered into the Court Record.", "Le tableau d'affichage a été\r\nversé au dossier de l'affaire." },
            { "And now, the prosecution would like to call new\r\nwitnesses to the stand.", "Et à présent, l'accusation souhaite appeler de nouveaux\r\ntémoins à la barre." },
            { "Witnesses who saw events unfold on the day in question.", "Des témoins qui ont assisté aux événements le jour fatidique." },
            { "They were mentioned in the previous testimony too, if\r\nyou remember.", "Ils ont été mentionnés dans la déposition précédente, si\r\nvous vous rappelez." },
            { "Yes. The street sellers who heard the gunshot and went\r\nrunning into the room.", "Oui. Les marchands ambulants qui ont entendu le coup de feu et ont\r\naccouru dans la chambre." },
            { "Very well, lead the witnesses in!", "Très bien, faites entrer les témoins !" },
            { "The defendant may step down from the witness stand.", "L'accusé peut se retirer de la barre." },
            { "Certainly, My Lord.", "Parfaitement, Votre Honneur." }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(@"tools\Trans_Ep4_Act3_Part1.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Trans_Ep4_Act3_Part1.cs generated successfully!");
    }
}
