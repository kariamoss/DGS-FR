using System;
using System.IO;
using System.Text;

class MakeAct6Part2B {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart2_B() {");

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

        // [61] KEY:BB\script\output\_sce02_chr060_00_eng#7
        add(@"BB\script\output\_sce02_chr060_00_eng#7", new string[,] {
            { "What do you mean by what you said before?", "Qu'entendez-vous par ce que vous avez dit tout à l'heure ?" },
            { "If you'd like to know the Reaper's true identity, does that\r\nmean...?", "Si vous voulez connaître la véritable identité du Faucheur, cela veut-il dire... ?" },
            { "I'm a Crown prosecutor and a mortal like any other.\r\nI'm no demigod.", "Je suis un procureur de la Couronne et un mortel comme les autres. Je ne suis pas un demi-dieu." },
            { "But they've all died, haven't they?\r\nThe people you've prosecuted, I mean.", "Mais ils sont tous morts, n'est-ce pas ? Ceux que vous avez poursuivis en justice, je veux dire." },
            { "...Whether or not the trial ended in a conviction or an\r\nacquittal...", "...Qu'ils aient été condamnés ou acquittés..." },
            { "Those I prosecute are the vilest wretches of our society.", "Ceux que je poursuis sont les pires rebuts de notre société." },
            { "People who without question deserve to be found guilty.\r\n...The world is a better place without them.", "Des individus qui méritent incontestablement d'être jugés coupables. ...Le monde ne s'en porte que mieux sans eux." },
            { "But...\r\n...that's not true of Mr Natsume, for example.\r\nHe wasn't a vile wretch at all.", "Mais... ce n'était pas le cas de M. Soseki, par exemple. Ce n'était pas un ignoble criminel." },
            { "Nor was Ginny!\r\nIn fact, she's ever so hard-working now.", "Et Gina non plus ! D'ailleurs, elle travaille d'arrache-pied maintenant." },
            { "I can't deny that since I encountered you, things have\r\ntaken a turn. But the point is this:", "Je ne puis nier que depuis notre rencontre, le cours des choses a quelque peu changé. Mais l'essentiel est là :" },
            { "If any of those vile wretches that escaped justice\r\nsubsequently died in mysterious circumstances...\r\n...it was at the hand of their own kind.\r\nIt's not my work.", "Si certains de ces misérables ayant échappé à la justice ont trouvé la mort dans d'étranges circonstances... c'était de la main de leurs pairs. Je n'y suis pour rien." },
            { "Lord Stronghart said the same.\r\nHe believes you're not involved in any way.", "Lord Harry Caine a dit la même chose. Il est convaincu que vous n'êtes impliqué en aucune manière." },
            { "But you were attacked by those ruffians because they\r\nbelieve it's true!", "Mais vous avez été attaqué par ces voyous parce qu'ils croient à cette légende !" },
            { "The fact is, since people started to call me the Reaper of\r\nthe Bailey...\r\n...the number of serious crimes in the capital has dropped\r\nsubstantially.", "Le fait est que depuis qu'on m'appelle le Faucheur d'Old Bailey... la criminalité grave a considérablement diminué dans la capitale." },
            { "Oh!", "Oh !" },
            { "It would appear that even the most hardened criminals\r\ncan be made fearful for their lives.", "Il semblerait que même les pires scélérats puissent trembler pour leur existence." },
            { "Do you mean to say...?", "Voulez-vous dire... ?" },
            { "I mean to say that if my pseudonym serves a useful\r\npurpose...\r\n...I adopt it gladly, and with honour.", "Je veux dire que si ce sobriquet est utile à la cause de la justice... je l'endosse avec fierté et honneur." },
            { "But it's putting you in danger!\r\nYou could be killed!", "Mais cela vous met en danger de mort ! Vous pourriez vous faire tuer !" },
            { "If that is my fate, let God decide.", "Si tel est mon destin, que Dieu en soit le juge." },
            { "Lord van Zieks...", "Lord Van Peers..." }
        });

        // [62] KEY:BB\script\output\_sce02_chr060_00_eng#8
        add(@"BB\script\output\_sce02_chr060_00_eng#8", new string[,] {
            { "He's in my tutelage to become a prosecutor.", "Il étudie sous ma tutelle afin de devenir procureur." },
            { "So you could say he's my apprentice, I suppose.", "Vous pourriez donc dire qu'il est mon disciple, j'imagine." },
            { "Ah, like you are to Hurley then, Runo.", "Ah, comme toi avec Sherlockinou alors, Mister Yûno." },
            { "(I don't remember taking an apprenticeship with a great\r\ndetective...)", "(Je ne me rappelle pas être entré en apprentissage chez un grand détective...)" },
            { "He's currently compiling a report about last night's attack.", "Il rédige actuellement un rapport sur l'agression d'hier soir." },
            { "It looks like he's wearing some kind of mask...?", "On dirait qu'il porte une sorte de masque... ?" },
            { "On Lord Stronghart's orders.", "Sur ordre de Lord Harry Caine." },
            { "Nobody knows the man's face.\r\n...Or indeed his identity.", "Nul ne connaît le visage de cet homme. ...Ni sa véritable identité." },
            { "But why would you agree to take on such a clearly\r\nsuspicious individual?", "Mais pourquoi avoir accepté d'accueillir un individu aussi suspect ?" },
            { "Lord Stronghart's orders again.", "Les ordres de Lord Harry Caine, encore une fois." },
            { "He's not one for meaningless follies.\r\nThere will be a good reason for his actions.", "Ce n'est pas un homme porté sur les caprices futiles. Ses décisions reposent toujours sur une solide raison." },
            { "...I hope you're right.", "...J'espère que vous avez raison." },
            { "The task is complete? Good.\r\nIn that case, you can collate all the briefs.", "La tâche est achevée ? Bien. Dans ce cas, rassemblez tous les mémoires." },
            { "N-Nice to meet you...?", "R-Ravi de vous rencontrer... ?" },
            { "(Back to work again...)", "(Il s'est déjà remis au travail...)" },
            { "(That was really strange, though.)", "(C'était vraiment curieux, pourtant.)" },
            { "(I've never met the man before.\r\nI didn't even know he existed. And yet...)", "(Je n'avais jamais rencontré cet homme auparavant. J'ignorais même qu'il existait. Et pourtant...)" },
            { "(...somehow it didn't feel like our first encounter.)", "(...j'ai l'impression que ce n'est pas notre première rencontre.)" }
        });

        // [63] KEY:BB\script\output\_sce02_chr060_00_eng#9
        add(@"BB\script\output\_sce02_chr060_00_eng#9", new string[,] {
            { "Ah!", "Ah !" },
            { "The task is complete? Good.\r\nIn that case, you can collate all the briefs.", "La tâche est achevée ? Bien. Dans ce cas, rassemblez tous les mémoires." },
            { "N-Nice to meet you...?", "R-Ravi de vous rencontrer... ?" },
            { "(Back to work again...)", "(Il s'est déjà remis au travail...)" },
            { "(That was really strange, though.)", "(C'était vraiment curieux, pourtant.)" },
            { "(I've never met the man before.\r\nI didn't even know he existed. And yet...)", "(Je n'avais jamais rencontré cet homme auparavant. J'ignorais même qu'il existait. Et pourtant...)" },
            { "(...somehow it didn't feel like our first encounter.)", "(...j'ai l'impression que ce n'est pas notre première rencontre.)" }
        });

        // [64] KEY:BB\script\output\_sce02_chr060_00_eng#10
        add(@"BB\script\output\_sce02_chr060_00_eng#10", new string[,] {
            { "Don't bother trying to converse with him. He says nothing\r\nto anybody from outside this office.", "Inutile d'essayer de converser avec lui. Il n'adresse la parole à quiconque étranger à ce bureau." },
            { "Lord Stronghart has strictly forbidden it.", "Lord Harry Caine le lui a formellement interdit." },
            { "Oh. I see...", "Oh. Je vois..." },
            { "Why are you so interested in my apprentice anyway?", "Pourquoi cet intérêt si vif pour mon disciple d'ailleurs ?" },
            { "Hm? Oh, no! I mean...\r\nSorry, I didn't mean to...", "Hein ? Oh, non ! Je veux dire... Pardonnez-moi, je ne voulais pas..." },
            { "(The way he stood there so casually, yet with that\r\nflawless posture...)", "(Cette façon de se tenir si décontractée, mais avec cette posture impeccable...)" },
            { "(It, it couldn't be...)", "(Ce... ce ne peut tout de même pas être...)" }
        });

        // [65] KEY:BB\script\output\_sce02_chr060_00_eng#13
        add(@"BB\script\output\_sce02_chr060_00_eng#13", new string[,] {
            { "What's that?", "Qu'est-ce donc ?" },
            { "Ah, it's just something I was hoping to ask your opinion\r\nabout, that's all.", "Ah, c'est juste un détail sur lequel j'espérais avoir votre avis, c'est tout." },
            { "It's a serious crime for the defence to attempt to extract\r\ninformation from the prosecution by illegal means.", "C'est un délit très grave pour la défense que de tenter d'extorquer des informations à l'accusation par des voies détournées." },
            { "...Alright, I get the message.\r\nBut I don't see what's illegal about me asking...", "...Très bien, j'ai compris le message. Mais je ne vois pas ce qu'il y a d'illégal à poser une simple question..." }
        });

        // [66] KEY:BB\script\output\_sce02_chr060_00_eng#14
        add(@"BB\script\output\_sce02_chr060_00_eng#14", new string[,] {
            { "Lord van Zieks, about the article in this paper...", "Lord Van Peers, au sujet de l'article dans ce journal..." },
            { "Ah, yes... It seems there was a reporter nearby when that\r\nlittle skirmish took place.", "Ah, oui... Il semble qu'un journaliste se trouvait à proximité lorsque cette petite échauffourée a eu lieu." },
            { "I had no idea I'd been photographed.\r\nIt was careless of me.", "J'ignorais que j'avais été photographié. Cela dénote un manque de vigilance de ma part." },
            { "It looks as though it was taken after the people who\r\nattacked you had run away, though.", "La photo semble pourtant avoir été prise après que vos agresseurs ont pris la fuite." },
            { "Rest assured, the police have already apprehended every\r\nlast one of them.", "Rassurez-vous, les forces de police ont d'ores et déjà appréhendé jusqu'au dernier d'entre eux." },
            { "But there's someone else fighting alongside you, it seems.", "Mais quelqu'un d'autre se battait à vos côtés, semble-t-il." },
            { "And I think it's the same man who's sitting over there as\r\nwe speak, isn't it?", "Et je suis convaincu qu'il s'agit du même homme assis là-bas en ce moment même, n'est-ce pas ?" },
            { "As I mentioned already...\r\n...he's my apprentice.", "Comme je l'ai déjà dit... c'est mon disciple." },
            { "Perhaps you could tell us a little more about him?", "Pourriez-vous nous en dire un peu plus à son sujet ?" }
        });

        // [67] KEY:BB\script\output\_sce02_chr060_00_eng#15
        add(@"BB\script\output\_sce02_chr060_00_eng#15", new string[,] {
            { "Having read what happened to you, it's lucky you weren't\r\ninjured...or worse.", "Vu ce qui vous est arrivé, vous avez bien de la chance de ne pas être blessé... ou pire." },
            { "My highly skilled apprentice was with me. Our attackers\r\nare the lucky ones...for escaping with their lives.", "Mon disciple est un épéiste d'exception. Ce sont plutôt nos assaillants qui ont eu de la chance... d'en réchapper vivants." },
            { "Right...", "Je vois..." },
            { "What I really can't believe is that the incident was\r\ncaptured on film.", "Ce que j'ai du mal à concevoir, c'est que la scène ait été immortalisée sur pellicule." },
            { "If the journalist had been spotted, it would have ended\r\nvery badly for him indeed.", "Si ce journaleux avait été repéré, les choses se seraient fort mal terminées pour lui." },
            { "(It sounds like the luckiest person there...)\r\n(...was whoever wrote the article for the paper.)", "(À en croire ses propos, la personne la plus chanceuse... était sans conteste l'auteur de l'article.)" }
        });

        // [68] KEY:BB\script\output\_sce02_chr060_00_eng#16
        add(@"BB\script\output\_sce02_chr060_00_eng#16", new string[,] {
            { "Um, I know you've seen this around my arm before, but...", "Hum, je sais que vous avez déjà vu ceci à mon bras, mais..." },
            { "What is it, exactly?", "De quoi s'agit-il au juste ?" },
            { "It's the mark of a defence lawyer. ...In Japan at least.", "C'est l'insigne d'un avocat de la défense. ...Au Japon du moins." },
            { "And what's your reason for showing it to a British\r\nprosecutor?", "Et pour quelle raison le montrez-vous à un procureur britannique ?" },
            { "Oh...well... I don't know, really.", "Oh... eh bien... Je ne sais pas trop, en réalité." },
            { "I can understand, at least...\r\n...there's merit in reminding yourself of who helped you\r\nbecome what you are today.", "Je puis comprendre, à tout le moins... qu'il est précieux de se remémorer ceux qui vous ont aidé à devenir ce que vous êtes aujourd'hui." },
            { "Oh.", "Oh." },
            { "But that's a personal matter. Something you may want\r\nto keep close at all times, not something to flaunt.", "Mais c'est une affaire personnelle. Quelque chose que l'on garde au fond de soi, pas un trophée à brandir." },
            { "No...I suppose not.\r\nThank you for understanding, though.", "Non... vous avez sans doute raison. Merci tout de même de comprendre." }
        });

        // [69] KEY:BB\script\output\_sce02_chr060_01_eng#1
        add(@"BB\script\output\_sce02_chr060_01_eng#1", new string[,] {
            { "has been stolen from the\r\nplace...and held for ransom.", "a été dérobée... pour obtenir une rançon." },
            { "A particular waxwork? Which–\r\nWait! You mean...?!", "Une statue de cire en particulier ? Laquelle... Attendez ! Vous voulez dire...?!" },
            { "Yes. It's the Professor.", "Oui. C'est le Démon Assassin." },
            { "Mr Sholmes is investigating the case as we speak.", "M. Holmes enquête sur cette affaire en ce moment même." },
            { "I...was unaware of that.", "Je... l'ignorais." },
            { "(He's turned as white as a sheet...)", "(Il est devenu blanc comme un linge...)" }
        });

        // [70] KEY:BB\script\output\_sce02_chr060_01_eng#2
        add(@"BB\script\output\_sce02_chr060_01_eng#2", new string[,] {
            { "Are the police trying to locate the engineer, Mr Drebber,\r\nalready?", "La police tente-t-elle déjà de localiser l'ingénieur, M. Drebber ?" },
            { "Surely that goes without saying.", "Cela va sans dire." },
            { "We're very keen to see him found as well.", "Nous tenons également beaucoup à ce qu'il soit retrouvé." },
            { "The trouble is, we don't have much to go on aside from\r\nthe description of the man we heard in court earlier.", "Le problème, c'est que nous n'avons pas grand-chose à part la description entendue au tribunal tout à l'heure." },
            { "Which, according to Professor Harebrayne...", "Laquelle, d'après le professeur Lonron..." },
            { "...was of a tall, thin gentleman who has straight, white hair\r\nand wears a black monocle.", "...était celle d'un homme grand et mince aux cheveux raides et blancs, portant un monocle noir." },
            { "So...I was just wondering... I mean, I realise it's probably\r\nnot possible, but...erm...", "Alors... je me demandais... Je veux dire, je sais bien que ce n'est probablement pas possible, mais... hum..." },
            { "We'd very much appreciate any more clues you can give\r\nus!", "Nous vous serions infiniment reconnaissants si vous pouviez nous donner d'autres indices !" },
            { "(Wow. Susato-san...really knows how to take the bull by\r\nthe horns...)", "(Waouh. Susato... sait vraiment prendre le taureau par les cornes...)" },
            { "Fine. Why not?", "Soit. Pourquoi pas ?" },
            { "I have a photograph of the man here from an investigation\r\nten years ago.", "J'ai ici une photographie de l'homme, issue d'une enquête menée il y a dix ans." },
            { "Though it appears he already had that black monocle at\r\nthe time.", "Bien qu'il semble qu'il portait déjà ce monocle noir à l'époque." },
            { "What?", "Quoi ?" },
            { "Oh...no, nothing. I, I was just surprised that you shared\r\nthat with us.", "Oh... non, rien. J-J'étais simplement surpris que vous partagiez cela avec nous." },
            { "We all need the man's testimony in court tomorrow.", "Nous avons tous besoin du témoignage de cet homme au procès demain." },
            { "Which means we have to do everything we possibly can\r\nto track him down in the short time available.", "Ce qui signifie que nous devons tout mettre en œuvre pour le retrouver dans le peu de temps qui nous reste." },
            { "...So why wouldn't I show you the photograph?", "...Pourquoi refuserais-je donc de vous montrer cette photographie ?" },
            { "(What is it about Lord van Zieks?)", "(Qu'en est-il donc de Lord Van Peers ?)" },
            { "(Sometimes I just can't work him out at all.)", "(Parfois, il m'est tout simplement impossible de le cerner.)" },
            { "The photograph of Drebber has been\r\nentered into the Court Record.", "La photo de Drebber a été\r\najoutée au dossier de l'affaire." }
        });

        // [71] KEY:BB\script\output\_sce02_chr060_01_eng#4
        add(@"BB\script\output\_sce02_chr060_01_eng#4", new string[,] {
            { "What is your interest in my apprentice exactly?", "Pourquoi vous intéressez-vous tant à mon disciple au juste ?" },
            { "You act as if you know the man or something.", "Vous agissez comme si vous connaissiez cet homme." },
            { "Well, um...", "Eh bien, hum..." },
            { "Since when has he been in your care?!", "Depuis quand est-il placé sous votre tutelle ?!" },
            { "I don't recall you having an apprentice before I left Britain\r\nsix months ago.", "Je n'ai pas souvenir que vous aviez un apprenti avant mon départ de Grande-Bretagne il y a six mois." },
            { "Lord Stronghart introduced him to me about three months\r\nago now.", "Lord Harry Caine me l'a présenté il y a environ trois mois." },
            { "With instructions to mentor him as a prosecutor.", "Avec pour consigne de le former au métier de procureur." },
            { "But he didn't tell you why, did he?", "Mais il ne vous a pas dit pourquoi, n'est-ce pas ?" },
            { "The man appears to be suffering from amnesia.\r\nHe's forgotten every last detail about himself.", "Cet homme semble souffrir d'amnésie. Il a tout oublié jusqu'au moindre détail sur son passé." },
            { "He has amnesia?!", "Il est amnésique ?!" },
            { "Tomorrow he will appear in court at my side.", "Demain, il paraîtra au tribunal à mes côtés." },
            { "What?", "Quoi ?" },
            { "He's to serve as my judicial assistant.\r\nOn Lord Stronghart's orders.", "Il officiera comme mon assistant judiciaire. Sur ordre de Lord Harry Caine." },
            { "(He'll...be in court with us...?)", "(Il va... être au tribunal avec nous...?)" },
            { "Now then, unless I'm much mistaken, I believe this\r\nconversation has run its course...", "À présent, à moins que je ne me trompe, j'estime que cette conversation a assez duré..." },
            { "Oh...\r\nYes, um, thank you.", "Oh...\r\nOui, hum, merci." },
            { "(I definitely saw a reaction there...)", "(J'ai distinctement perçu une réaction chez lui...)" },
            { "(When Susato-san called out like that, it really seemed to\r\nhit a nerve...)", "(Quand Susato s'est écriée ainsi, cela a semblé toucher une corde sensible...)" },
            { "(When she called out ‘Kazuma-sama’...)", "(Quand elle a crié « Monsieur Kiyô »...)" }
        });

        // [72] KEY:BB\script\output\_sce02_chr070_00_eng#1
        add(@"BB\script\output\_sce02_chr070_00_eng#1", new string[,] {
            { "Using high-voltage electricity to somehow ‘disassemble’\r\na man's body...", "Utiliser de l'électricité à haute tension pour en quelque sorte « désassembler » un corps humain..." },
            { "...and then beam him across to the Crystal Tower...\r\nIt's an extraordinary thing to attempt...especially in public.", "...et le téléporter jusqu'à la Tour de Cristal... C'est une expérience inouïe... surtout devant un tel public." },
            { "True. It was by far the most unusual of the experiments\r\nplanned for the exhibition, mind.", "C'est vrai. C'était de loin la plus insolite des expériences prévues pour l'exposition, remarquez." },
            { "To be honest...I'm a bit surprised it was allowed.\r\nCarrying out something so dangerous with so many\r\nspectators present, I mean.", "Pour être franc... je suis un peu surpris que cela ait été autorisé. Entreprendre une chose aussi risquée en présence d'une telle foule, je veux dire." },
            { "The government's doin' everythin' it can to promote new\r\nscience and technology at the moment.", "L'gouvernement fait des pieds et des mains pour promouvoir les sciences et techniques en c'moment." },
            { "They're more worried about bein' ahead of the game than\r\nthe odd spot of public safety infringements.", "Ils s'soucient plus d'avoir une longueur d'avance que de trois accrocs à la sécurité publique." },
            { "If they can be the first to develop some new technology,\r\nit makes Britain more powerful in the future, you see.", "S'ils sont les premiers à pondre une technologie d'pointe, ça rend la Grande-Bretagne plus puissante pour l'avenir, voyez-vous." },
            { "Yes, I suppose that's true, in a way.", "Oui, j'imagine que c'est exact, d'une certaine façon." },
            { "So the powers that be are placin' a heavy emphasis on\r\nscientists' rights at the moment.", "Alors les huiles haut placées mettent le paquet sur les droits des scientifiques en c'moment." },
            { "What sort of rights?", "Quelle sorte de droits ?" },
            { "They're makin' it so that any theories the brains have\r\nremain their legal ‘property’, as it were...\r\n...right through developin' it into a practical idea and even\r\ngoin' into production.", "Ils font en sorte que toutes les théories des grosses têtes restent leur « propriété légale », si vous voulez... d'la conception jusqu'à la réalisation concrète et même la production industrielle." },
            { "Which is the infuriatin' reason us coppers aren't allowed\r\nto touch this crime scene!", "Et c'est la raison bien rageante pour laquelle nous autres flics avons pas l'droit d'toucher à cette scène d'crime !" },
            { "Because the new highfalutin Special Dispensation for\r\nScientific Equipment Act forbids it!", "Tout ça parce que cette sacrée Loi sur la dérogation spéciale pour matériel scientifique nous l'interdit !" },
            { "Ah, I see now...", "Ah, je comprends mieux..." },
            { "The only people with permission to investigate here are\r\nfrom some brand new department at the Yard.", "Les seuls pèlerins autorisés à enquêter ici font partie d'un tout nouveau département du Yard." },
            { "The ‘Forensic Investigation Team’ it's called.\r\nWe've been relegated to keepin' guard.", "La « brigade de police scientifique », qu'ils l'appellent. Nous autres, on a été relégués à faire les plantons." },
            { "(The Forensic Investigation Team...)", "(La brigade de police scientifique...)" },
            { "Any old fool can see that this heap of scrap metal was a\r\nsham to begin with!", "N'importe quel imbécile verrait que cet empilement d'ferraille est une supercherie depuis l'début !" },
            { "But just because it says ‘scientific equipment’ on the\r\npaperwork, we can't do a flamin' thing with it!", "Mais sous prétexte qu'y a marqué « matériel scientifique » sur les papelards, on a pas l'droit d'y toucher d'un millimètre !" },
            { "Poor Gregsy...\r\nHe's very het up, isn't he?", "Pauvre inspecteur...\r\nIl est sacrément remonté, n'est-ce pas ?" }
        });

        // [73] KEY:BB\script\output\_sce02_chr070_00_eng#2
        add(@"BB\script\output\_sce02_chr070_00_eng#2", new string[,] {
            { "Remind me again, what's this new legal act that means\r\nwe're not allowed to touch the scene here?", "Rappelez-moi, quelle est cette nouvelle loi qui nous interdit de toucher à la scène ici ?" },
            { "Are you havin' me at it, sunshine?\r\nIt's the Special Dispensation for Scientific Equipment Act.", "Vous vous payez ma fiole, mon gars ? C'est la Loi sur la dérogation spéciale pour matériel scientifique." },
            { "Hm, yes... I think Hurley mentioned that recently.\r\nWith a real twinkle in his eye as I remember.", "Hum, oui... Je crois que Sherlockinou en a parlé récemment. Avec une vraie lueur malicieuse dans le regard, si je me souviens bien." },
            { "I'm sure he did, Your Ladyship, I'm sure he did.\r\nPassed especially for this Great Exhibition, it was.", "Ça m'étonne pas, Votre Seigneurie, ça m'étonne pas. Votée tout spécialement pour cette Exposition universelle." },
            { "All scientists have to do is present some theoretical\r\nplans to the ministry...\r\n...and if they're rubber-stamped, their device is exempt\r\nfrom standard police inspections.", "Tout c'que les savants ont à faire, c'est d'présenter des plans théoriques au ministère... et si c'est tamponné, leur bidule est exempté d'toute fouille policière habituelle." },
            { "The idea was to stop industrial espionage by competitors\r\nfrom other countries.\r\nInstead, it's just tying Scotland Yard's hands behind its\r\nback.", "L'idée, c'était d'empêcher l'espionnage industriel par les concurrents étrangers. Mais au lieu d'ça, ça nous lie les mains dans l'dos à Scotland Yard." },
            { "Oh, I don't think so. That sounds like my dream job.", "Oh, je ne trouve pas. Ça ressemble plutôt au travail de mes rêves." },
            { "You'd soon think otherwise after spendin' a day guardin'\r\nall these shammers' bogus contraptions.", "Vous changeriez vite d'avis après avoir passé une journée à monter la garde devant les machines bidons de ces charlatans." },
            { "But if they're all bogus, how can anyone hope to\r\ndemonstrate them? There'd be no point.", "Mais si elles sont toutes fausses, comment peut-on espérer les présenter ? Cela n'aurait aucun sens." },
            { "Yeah, well...there is a point, sadly.", "Ouais, hélas... y'a un intérêt, tristement." },
            { "Sorry?", "Pardon ?" },
            { "Thanks to another of our government's bright ideas.", "Grâce à une autre idée lumineuse de nos gouvernants." },
            { "If any theory or invention is deemed to show ‘potential’,\r\nthe government hands out a research grant.", "Dès qu'une théorie ou invention est jugée avoir du « potentiel », le gouvernement arrose ça d'une subvention de recherche." },
            { "The scientists get funding?", "Les scientifiques touchent des fonds ?" },
            { "Exactly. And that's what they're all after. All these\r\nshammers comin' from far and wide to clog up Hyde Park.", "Exactement. Et c'est après ça qu'ils courent tous. Tous ces imposteurs venus des quatre coins du globe pour encombrer Hyde Park." },
            { "And who has to keep 'em all safe, eh? Who has to smile\r\npolitely and welcome them? Us coppers, that's who!", "Et qui doit veiller sur leur sécurité, hein ? Qui doit faire risette et leur souhaiter la bienvenue ? Nous autres pauvres flics, pardi !" },
            { "So you can see why I say it now, can't ya?\r\nHang science! Hang it!", "Alors vous comprenez pourquoi je dis ça, pas vrai ? Au diable la science ! Au diable !" },
            { "Oh...maybe I can see your point...", "Oh... je commence peut-être à comprendre votre point de vue..." }
        });

        // [74] KEY:BB\script\output\_sce02_chr070_00_eng#3
        add(@"BB\script\output\_sce02_chr070_00_eng#3", new string[,] {
            { "Apparently Professor Harebrayne lives and works in\r\nGermany now conducting his research.", "Il paraît que le professeur Lonron vit et travaille en Allemagne désormais pour ses recherches." },
            { "That's right. Came back to Britain especially for the Great\r\nExhibition, as I understand it.\r\nProbably after one of the government's research grants.\r\nHmph.", "C'est exact. Revenu en Grande-Bretagne exprès pour l'Exposition universelle, d'après ce que j'ai compris. Probablement pour décrocher une des bourses de recherche du gouvernement. Hmph." },
            { "Actually, we learnt something else about the professor\r\nearlier today.\r\nAbout his time in further education. It turns out he was\r\nat university with someone we both know:\r\nLord van Zieks.", "En fait, nous avons appris autre chose sur le professeur plus tôt aujourd'hui. Sur ses années d'études. Il s'avère qu'il était à l'université avec quelqu'un que nous connaissons tous les deux : Lord Van Peers." },
            { "Eh? What's that?\r\nThat's news to me!\r\nBut, but if van Zieks mans the prosecution, then as the\r\naccused, the professor's fate is...", "Hein ? Qu'est-ce que vous dites ? Ça alors, j'l'ignorais ! Mais... mais si Van Peers mène l'accusation, alors en tant qu'accusé, le sort du professeur est..." },
            { "(Sealed? Because the Reaper will get him one way or\r\nanother...)", "(Scellé ? Parce que le Faucheur l'aura d'une manière ou d'une autre...)" },
            { "Blimey. That man's beyond me. I dunno what goes on in\r\nthat head of his.", "Purée. Cet homme me dépasse. J'sais pas c'qui s'passe dans sa caboche." },
            { "Talkin' of van Zieks, this mornin's paper ran the story of\r\nhim bein' attacked. Read that?", "En parlant de Van Peers, le journal de c'matin relatait son agression. Vous avez lu ça ?" },
            { "Oh yes! But Mr Reaper is completely fine.\r\nNothing to worry about!", "Oh oui ! Mais M. le Faucheur va parfaitement bien. Rien d'inquiétant !" },
            { "Yes, right... Glad to hear it.\r\nStill, the Reaper, huh...\r\nHow long's that business gonna keep up, I wonder?", "Oui, bon... Tant mieux pour lui. Reste que... ce Faucheur, hein... Combien d'temps c'manège va continuer, j'me l'demande ?" }
        });

        // [75] KEY:BB\script\output\_sce02_chr070_00_eng#4
        add(@"BB\script\output\_sce02_chr070_00_eng#4", new string[,] {
            { "The victim of this case, the investor, Mr Asman...\r\nHe was another of the Reaper's victims...or so I heard.", "La victime de cette affaire, l'investisseur, M. Asman... C'était une autre victime du Faucheur... d'après ce que j'ai entendu." },
            { "Lord Barok van Zieks is a top-class prosecutor.\r\nBut even he can't always push the right verdict through.\r\nSometimes justice can't win.", "Lord Drake Van Peers est un procureur de tout premier ordre. Mais même lui ne peut pas toujours obtenir le juste verdict. Parfois, la justice ne peut pas vaincre." },
            { "Yes, I've heard about jurors being bribed and evidence\r\nbeing falsified.\r\nAnd...that's how the notion of the Reaper of the Bailey\r\ncame about, isn't it?", "Oui, j'ai entendu parler de jurés soudoyés et de preuves falsifiées. Et... c'est comme ça qu'est née la légende du Faucheur d'Old Bailey, n'est-ce pas ?" },
            { "Obviously, Scotland Yard suspected van Zieks initially.\r\nWe all assumed he was takin' matters into his own hands\r\nif he failed to seal the deal in court.", "Évidemment, Scotland Yard a d'abord soupçonné Van Peers. On s'disait tous qu'il prenait les choses en main lui-même s'il échouait à faire condamner l'accusé au procès." },
            { "Although the man himself denies that charge.", "Bien que l'intéressé nie farouchement cette accusation." },
            { "Well, we've done a very thorough investigation.\r\nAnd the conclusion we reached...\r\n...is that Lord van Zieks is in no way related to the deaths\r\nof those people outside the courtroom.\r\nThere's no question in my mind.\r\nI'd stake my reputation on it, I would.", "Eh bien, on a mené une enquête très approfondie. Et la conclusion à laquelle nous sommes parvenus... c'est que Lord Van Peers n'est mêlé en rien à la mort de ces gens en dehors du tribunal. Y'a pas l'ombre d'un doute dans mon esprit. J'y mettrais ma réputation en jeu, foi de Gregson." },
            { "But if that's true, then how do you explain it?\r\nAll those defendants couldn't just have coincidentally died\r\nif nobody killed them!", "Mais si c'est vrai, alors comment l'expliquez-vous ? Tous ces prévenus n'ont pas pu mourir par hasard sans que personne ne les tue !" },
            { "I know that!\r\nBut...I can't explain it.\r\nIt's a mystery, after all, isn't it?\r\nThat's the whole point of the Reaper.", "J'le sais bien ! Mais... j'peux pas l'expliquer. C'est un mystère, après tout, pas vrai ? C'est tout le principe du Faucheur." },
            { "Professor Harebrayne mentioned something else.\r\nHe said that at university, Lord van Zieks was a totally\r\ndifferent person. Easygoing and kind.", "Le professeur Lonron a mentionné autre chose. Il disait qu'à l'université, Lord Van Peers était une personne complètement différente. Jovial et bienveillant." },
            { "You what?", "Vous dites ?" },
            { "He said that it was after they both graduated that\r\nsomething happened to change the man.\r\n...Do you have any idea what it was?", "Il m'a dit que c'est après l'obtention de leurs diplômes qu'un événement s'est produit et l'a changé du tout au tout. ...Avez-vous la moindre idée de ce dont il s'agit ?" },
            { "No clue.", "Pas la moindre idée." },
            { "Really?", "Vraiment ?" },
            { "Look, I've got my hands full watchin' over this frustratin'\r\ncrime scene.\r\nWhy don't you go and make a nuisance of yourself\r\nelsewhere, eh?", "Écoutez, j'ai déjà bien assez à faire à surveiller cette maudite scène de crime. Alors pourquoi vous n'iriez pas vous rendre utile ailleurs, hein ?" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part2_B.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part2_B written.");
    }
}
