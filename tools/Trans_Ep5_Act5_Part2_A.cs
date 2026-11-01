using System;

namespace TranslatorEp5Act5 {
    public partial class Program {
        public static void RegisterPart2_A() {
            // [7] _sce04_evidence_eng#0
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#0"] = (en) => {
                string s = en;
                R(ref s, "I can't find anything out of place.", "Je ne trouve rien d'anormal.");
                return s;
            };

            // [8] _sce04_evidence_eng#3
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#3"] = (en) => {
                string s = en;
                R(ref s, "I'm right in thinking that these scales are a symbol of the\r\ndefence in law,<E003 6> aren't they?", "J'ai raison de penser que cette balance est le symbole de la\r\ndéfense en justice,<E003 6> n'est-ce pas ?");
                R(ref s, "They're supposed to symbolise treating everything\r\nequally...<E003 6>and fairly.", "Elle est censée symboliser le traitement de chaque chose avec\r\négalité...<E003 6>et impartialité.");
                R(ref s, "That's why they're always in the middle,<E003 6> balanced.<E003 12>\r\nEqual measures on both sides.", "C'est pourquoi elle est toujours au centre,<E003 6> en équilibre.<E003 12>\r\nUn poids égal de chaque côté.");
                R(ref s, "Recently though,<E003 6> whenever I see a set of scales,<E003 8> <E330>I can only\r\nthink of the enormous Scales of Justice.", "Pourtant ces derniers temps,<E003 6> dès que je vois une balance,<E003 8> <E330>je ne peux\r\nm'empêcher de penser à la gigantesque Balance de la Justice.");
                R(ref s, "That's entirely understandable.<E003 8> They are such a powerful\r\nsymbol in the courtroom, aren't they?", "C'est tout à fait compréhensible.<E003 8> Elle est un symbole si\r\npuissant dans le prétoire, n'est-ce pas ?");
                R(ref s, "And the thing about the Scales of Justice is...", "Et ce qu'il y a avec la Balance de la Justice, c'est...");
                R(ref s, "...they're always leaning one way or the other.<E003 10>\r\nThey're only ever in balance<E003 6> <E330>right at the start.", "... qu'elle penche toujours d'un côté ou de l'autre.<E003 10>\r\nElle n'est en équilibre parfait<E003 6> <E330>qu'au tout début.");
                R(ref s, "...It must be something peculiar to the British...<E003 14>\r\n<E025 2>I'm afraid I can't shed any light on it,<E003 4> Mr Naruhodo.", "... Cela doit être une particularité bien britannique...<E003 14>\r\n<E025 2>J'ai bien peur de ne pouvoir vous éclairer là-dessus,<E003 4> monsieur Naruhodo.");
                return s;
            };

            // [9] _sce04_evidence_eng#4
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#4"] = (en) => {
                string s = en;
                R(ref s, "It's very fine embroidery here that shows the name of\r\nthe armband's owner.", "C'est une très fine broderie qui indique le nom du\r\npropriétaire du brassard.");
                R(ref s, "In this case...<E003 8><E025 3><E330>Kazuma Asogi.", "En l'occurrence...<E003 8><E025 3><E330>Kazuma Asogi.");
                R(ref s, "So I'm always carrying my best friend's hopes and dreams\r\nwith me on my right arm<E003 6> just here.<E003 10> All the time.", "Je porte donc toujours les espoirs et les rêves de mon meilleur ami\r\nà mon bras droit,<E003 6> juste ici.<E003 10> En permanence.");
                R(ref s, "To be honest,<E003 8> <E238>it's something that weighs very heavily on\r\nme.", "À vrai dire,<E003 8> <E238>c'est quelque chose qui pèse très lourd\r\nsur mes épaules.");
                R(ref s, "...Oh,<E003 8> <E025 2>I didn't realise it was such a burden, Mr Naruhodo.", "... Oh,<E003 8> <E025 2>je ne réalisais pas que c'était un tel fardeau, monsieur Naruhodo.");
                R(ref s, "Yes,<E003 8> <E239>I think it's why my right shoulder aches so much.", "Oui,<E003 8> <E239>je crois que c'est pour ça que mon épaule droite me fait si mal.");
                R(ref s, "Are you sure<E003 10> <E025 2><E333>that's not to do with you reading in bed or\r\nthe like?", "Êtes-vous certain<E003 10> <E025 2><E333>que cela n'a rien à voir avec vos lectures au lit\r\nou quelque chose du genre ?");
                return s;
            };

            // [10] _sce04_evidence_eng#5
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#5"] = (en) => {
                string s = en;
                R(ref s, "Look at this dark stain here.<E003 10>\r\n<E025 3>Do you think...?", "Regardez cette tache sombre ici.<E003 10>\r\n<E025 3>Pensez-vous que... ?");
                R(ref s, "Yes, <E003 8>I'm afraid so.<E003 12>\r\n<E330>I think it's <E006>blood<E005>.", "Oui, <E003 8>j'en ai bien peur.<E003 12>\r\n<E330>Je crains que ce ne soit du <E006>sang<E005>.");
                R(ref s, "Ugh, <E003 10>I knew you were going to say that.<E003 12>\r\n<E025 3><E341>So that presumably means...", "Pouah, <E003 10>je savais que vous alliez dire ça.<E003 12>\r\n<E025 3><E341>Ce qui signifie sans doute...");
                R(ref s, "...That this was present at <E006>the scene<E005> <E003 8><E025 3>when Inspector\r\nGregson was killed.", "... que cet objet se trouvait sur les <E006>lieux du crime<E005> <E003 8><E025 3>lorsque l'inspecteur\r\nGregson a été tué.");
                R(ref s, "It's the most logical conclusion, <E003 6><E025 3>yes.", "C'est la conclusion la plus logique, <E003 6><E025 3>oui.");
                R(ref s, "To think Gina's been carrying this around with her...", "Quand on pense que Gina a gardé cela sur elle...");
                R(ref s, "<E007>(If you didn't know any better, <E003 8>I suppose it does look like a\r\ngrease stain from all the fish and chips...)", "<E007>(Si on ne savait pas, <E003 8>on pourrait croire à une tache de gras provenant\r\nde ses éternels fish and chips...)");
                return s;
            };

            // [11] _sce04_evidence_eng#6
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#6"] = (en) => {
                string s = en;
                R(ref s, "<E333>Look, <E003 14><E341><E338>there's something inside!", "<E333>Regardez, <E003 14><E341><E338>il y a quelque chose à l'intérieur !");
                R(ref s, "Ooh, <E003 8>let's see...", "Oh, <E003 8>voyons...");
                R(ref s, "<E330>It appears to be <E006>a passport<E005>...<E003 12><E025 2>authorising him to travel\r\noverseas.", "<E330>Il semblerait que ce soit <E006>un passeport<E005>...<E003 12><E025 2>l'autorisant à voyager\r\nà l'étranger.");
                R(ref s, "Was Inspector Gregson about to go on a trip abroad, then?", "L'inspecteur Gregson s'apprêtait-il donc à partir à l'étranger ?");
                R(ref s, "Perhaps the date of departure might tell us something.<E003 10>\r\n<E025 3>That was...", "Peut-être que la date de départ pourrait nous éclairer.<E003 10>\r\n<E025 3>C'était le...");
                R(ref s, "Oh!", "Oh !");
                R(ref s, "What is it?", "Qu'y a-t-il ?");
                R(ref s, "It was for travel on 31st October!<E003 15>\r\n<E335><E025 1>Just <E006>one day before<E005> the incident!", "Il était valable pour le 31 octobre !<E003 15>\r\n<E335><E025 1>Soit <E006>la veille<E005> de l'incident !");
                R(ref s, "What?<E003 12> <E045><E025 2>Really?!", "Quoi ?<E003 12> <E045><E025 2>Vraiment ?!");
                R(ref s, "<E007>The passport has been\r\nentered into the Court Record.", "<E007>Le passeport a été\r\najouté au dossier de l'affaire.");
                return s;
            };

            // [12] _sce04_evidence_eng#7
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#7"] = (en) => {
                string s = en;
                R(ref s, "<E239><E007>(Gregson went to France the day before his body was\r\ndiscovered...?)", "<E239><E007>(Gregson est allé en France la veille du jour où son corps a été\r\ndécouvert... ?)");
                return s;
            };

            // [13] _sce04_evidence_eng#8
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#8"] = (en) => {
                string s = en;
                R(ref s, "31st October...<E003 12> So this passport is for the day before\r\nGregson's body was found.", "Le 31 octobre...<E003 12> Ce passeport date donc de la veille de la découverte\r\ndu corps de Gregson.");
                R(ref s, "He needed this document for his trip to France.", "Il avait besoin de ce document pour son voyage en France.");
                R(ref s, "And when it says <E003 10><E025 3><E330>‘permission for the applicant and one\r\nadditional person to travel’...", "Et lorsqu'il est écrit <E003 10><E025 3><E330>« autorisation pour le demandeur et un\r\naccompagnateur »...");
                R(ref s, "<E007><E338><E341>(...I can't believe it was you, <E003 10><E025 3>Kazuma...)", "<E007><E338><E341>(... Je ne peux croire qu'il s'agissait de toi, <E003 10><E025 3>Kazuma...)");
                return s;
            };

            // [14] _sce04_evidence_eng#9
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#9"] = (en) => {
                string s = en;
                R(ref s, "Do you see that?<E003 10> There's something stuck in the side\r\nof the trunk there.<E003 12> <E330>It's glinting.", "Vous voyez ça ?<E003 10> Il y a quelque chose de coincé sur le côté\r\nde la malle.<E003 12> <E330>Ça brille.");
                R(ref s, "<E333>It looks like <E006>a fragment of metal<E005> of some sort.", "<E333>On dirait une sorte de <E006>fragment de métal<E005>.");
                R(ref s, "<E338><E342><E025 2>But it's wedged in so tightly, <E003 8><E025 3>I can't remove it.", "<E338><E342><E025 2>Mais c'est coincé si fort <E003 8><E025 3>que je n'arrive pas à l'extraire.");
                R(ref s, "Well don't cut yourself.<E003 10>\r\nYou'd better leave it, I think.", "Ne vous coupez pas surtout.<E003 10>\r\nMieux vaut le laisser là, je pense.");
                return s;
            };

            // [15] _sce04_evidence_eng#10
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#10"] = (en) => {
                string s = en;
                R(ref s, "The tip of Karuma...<E003 10> <E025 2>So this is how it was broken.", "La pointe de Karuma...<E003 10> <E025 2>C'est donc ainsi qu'elle s'est brisée.");
                R(ref s, "Kazuma's swordsmanship is second to none.<E003 12>\r\n<E025 3>I can't believe he'd misjudge it like that.", "La maîtrise du sabre de Kazuma est sans égale.<E003 12>\r\n<E025 3>Je ne peux croire qu'il ait ainsi mal calculé son coup.");
                R(ref s, "<E333>Clearly he wasn't in his right mind.", "<E333>De toute évidence, il n'était pas dans son état normal.");
                R(ref s, "He didn't have full control of the power in his stroke.<E003 12>\r\n<E025 2><E330>Too distracted by malicious thoughts, <E003 6>perhaps...", "Il n'avait pas le plein contrôle de la force de sa frappe.<E003 12>\r\n<E025 2><E330>Trop obnubilé par des desseins funestes, <E003 6>sans doute...");
                R(ref s, "Well, <E003 6><E025 2>that wouldn't be surprising.", "Eh bien, <E003 6><E025 2>ce ne serait guère étonnant.");
                R(ref s, "After all...", "Après tout...");
                R(ref s, "...he was on an assassination mission.", "... il était en mission d'assassinat.");
                return s;
            };

            // [16] _sce04_evidence_eng#12
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#12"] = (en) => {
                string s = en;
                R(ref s, "<E007>(Let's have a look inside...)", "<E007>(Jetons un coup d'œil à l'intérieur...)");
                return s;
            };

            // [17] _sce04_evidence_eng#13
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#13"] = (en) => {
                string s = en;
                R(ref s, "Have you seen this huge gash across the side of the trunk\r\nhere?", "Avez-vous vu cette immense entaille sur le côté de la malle\r\nici ?");
                R(ref s, "<E330>It's gone right through the leather and into the metal\r\nbehind.", "<E330>Elle a transpercé le cuir pour s'enfoncer dans le métal\r\nen dessous.");
                R(ref s, "Gosh, <E003 8><E025 2>for a metal chest like this to have been so badly\r\ndamaged...", "Sapristi, <E003 8><E025 2>pour qu'un coffre métallique comme celui-ci ait été si lourdement\r\nendommagé...");
                R(ref s, "<E333>Whatever made the gash must have struck the side of the\r\ntrunk with considerable force.", "<E333>Ce qui a causé cette entaille a dû frapper le flanc de la\r\nmalle avec une force prodigieuse.");
                R(ref s, "<E007><E330>(I wonder how it happened...)", "<E007><E330>(Je me demande comment c'est arrivé...)");
                return s;
            };

            // [18] _sce04_evidence_eng#14
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#14"] = (en) => {
                string s = en;
                R(ref s, "What a charming little rabbity version of Mr Sholmes.", "Quelle ravissante petite version léporine de monsieur Sholmes.");
                R(ref s, "Do you suppose this is how Iris sees him?", "Pensez-vous que c'est ainsi qu'Iris le voit ?");
                R(ref s, "Are you alright, <E003 6>Mr Naruhodo?<E003 10> Your eyes are veritably\r\nboring into the poor doll's ears.", "Tout va bien, <E003 6>monsieur Naruhodo ?<E003 10> Vos yeux semblent littéralement\r\ntranspercer les oreilles de cette pauvre poupée.");
                R(ref s, "Oh, <E003 8>sorry.<E003 10> <E025 2>I was just wondering...", "Oh, <E003 8>pardon.<E003 10> <E025 2>Je me demandais simplement...");
                R(ref s, "What do you suppose would happen <E003 8><E025 2><E330>if I were to tug its\r\nears with all my might right now?!", "Qu'est-ce qui se passerait d'après vous <E003 8><E025 2><E330>si je tirais de toutes\r\nmes forces sur ses oreilles là, maintenant ?!");
                R(ref s, "I'm sure that we'll find out...<E003 12><E025 2><E333>when the time is right.", "Je suis sûre que nous le découvrirons...<E003 12><E025 2><E333>le moment venu.");
                R(ref s, "To become a proper gentleman, <E003 10><E025 1><E332>you really must learn\r\nstoic patience!", "Pour devenir un parfait gentleman, <E003 10><E025 1><E332>vous devez impérativement faire\r\npreuve d'une patience stoïque !");
                R(ref s, "<E007>(...But I want to know!)", "<E007>(... Mais je veux savoir, moi !)");
                return s;
            };

            // [19] _sce04_evidence_eng#15
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#15"] = (en) => {
                string s = en;
                R(ref s, "The tip of the great sword...<E003 12>broken...", "La pointe de la grande lame...<E003 12>brisée...");
                R(ref s, "It's such a shame.<E003 8> It's been so meticulously cared for over\r\nthe years.", "C'est tellement dommage.<E003 8> Elle a été si méticuleusement entretenue au fil\r\ndes années.");
                R(ref s, "<E330>I can almost hear Karuma's sobs...", "<E330>J'entends presque les sanglots de Karuma...");
                R(ref s, "<E007>(Kazuma must have really taken a swing for that to\r\nhappen...)", "<E007>(Kazuma a dû frapper d'une force inouïe pour que cela\r\narrive...)");
                return s;
            };

            // [20] _sce04_evidence_eng#16
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#16"] = (en) => {
                string s = en;
                R(ref s, "‘Mighty Karuma, <E003 10>Twist thy head and watch them fall,<E003 12>\r\n<E025 2>All thy mortal foes!’", "« Ô noble Karuma, <E003 10>tourne la tête et contemple la chute<E003 12>\r\n<E025 2>de tous tes mortels ennemis ! »");
                R(ref s, "<E007>(That's the proper way to use the sword, <E003 6>is it?<E003 12>\r\n<E025 3>Maybe I should try it...)", "<E007>(C'est ainsi qu'on se sert de ce sabre ?<E003 12>\r\n<E025 3>Peut-être devrais-je essayer...)");
                R(ref s, "...It hurts my neck, <E003 8>that's the trouble.", "... Ça me fait mal au cou, voilà le problème.");
                R(ref s, "Um, <E003 6>Mr Naruhodo...<E003 12><E025 3>if I might make a suggestion?", "Hum, <E003 6>monsieur Naruhodo...<E003 12><E025 3>si je puis me permettre une suggestion ?");
                R(ref s, "I think perhaps <E003 15><E330><E025 3>it doesn't mean YOUR head.", "Je pense que <E003 15><E330><E025 3>cela ne désigne point VOTRE tête.");
                R(ref s, "Oh...", "Oh...");
                R(ref s, "I once studied the history and development of the katana\r\nsome time ago...", "J'ai autrefois étudié l'histoire et l'évolution du katana...");
                R(ref s, "...and as I'm sure you're probably aware, <E003 8><E025 3>the sword's\r\n‘head’ <E003 6><E025 2>is the part at the very end of the hilt.", "... et comme vous le savez très probablement, <E003 8><E025 3>la « tête »\r\ndu sabre <E003 6><E025 2>désigne la pièce à l'extrémité de la garde.");
                R(ref s, "It's written as ‘head’ in Japanese, <E003 12><E330>but it's pronounced as\r\n‘<E006>kashira<E005>’ <E003 6>I believe.", "Elle s'écrit avec le caractère de la « tête » en japonais, <E003 12><E330>mais se prononce\r\n« <E006>kashira<E005> », <E003 6>si je ne m'abuse.");
                R(ref s, "Kashira...?", "Kashira... ?");
                R(ref s, "So Mr Asogi's words really mean,<E003 8> <E025 3>‘twist <E006>the butt of the\r\nhilt<E005>’...?", "Les mots de M. Asogi signifient donc en vérité <E003 8><E025 3>« tourne <E006>le pommeau de la\r\ngarde<E005> »... ?");
                R(ref s, "You, <E003 12>you don't think...", "Vous, <E003 12>vous ne pensez tout de même pas...");
                R(ref s, "Ah!", "Ah !");
                R(ref s, "Look what's inside it!", "Regardez ce qu'il y a à l'intérieur !");
                R(ref s, "Is, <E003 12>is that...", "Est-ce, <E003 12>est-ce bien...");
                R(ref s, "...a tightly wound sheet of <E006>parchment<E005>?!", "... une feuille de <E006>parchemin<E005> soigneusement enroulée ?!");
                R(ref s, "S-<E003 8><E025 1>Scarlet ink!<E003 16> <E025 1>It's written in <E006>scarlet<E005> ink!", "À...<E003 8><E025 1>à l'encre écarlate !<E003 16> <E025 1>C'est écrit à l'encre <E006>écarlate<E005> !");
                R(ref s, "‘I pen this, <E003 10>my last will and testament, <E003 12>in the final\r\nmoments before my inevitable and willing death.’", "« Je rédige ces lignes, <E003 10>mes dernières volontés et testament, <E003 12>dans les ultimes\r\ninstants précédant ma mort inéluctable et consentie. »");
                R(ref s, "This, <E003 12><E025 3><E338><E342>this is it, <E003 8>isn't it...?", "C'est, <E003 12><E025 3><E338><E342>c'est bien cela, <E003 8>n'est-ce pas... ?");
                R(ref s, "Mr Naruhodo!<E003 20> <E025 1><E338><E342>Look at <E006>the signature<E005> at the end!", "Monsieur Naruhodo !<E003 20> <E025 1><E338><E342>Regardez <E006>la signature<E005> tout en bas !");
                R(ref s, "Klint van Zieks...<E003 15>\r\n<E025 3>And the date...<E003 14><E025 1><E338><E342>ten years ago, <E003 12>on that fateful night!", "Klint Van Peers...<E003 15>\r\n<E025 3>Et la date...<E003 14><E025 1><E338><E342>il y a dix ans, <E003 12>en cette nuit fatidique !");
                R(ref s, "So for ten years...<E003 12><E025 2>it's been silently concealed inside\r\nKaruma and nobody knew...", "Ainsi, dix années durant...<E003 12><E025 2>il est resté silencieusement dissimulé dans\r\nKaruma à l'insu de tous...");
                R(ref s, "<E006>The last will and testament<E005> of Lord Klint van Zieks!", "<E006>Le testament<E005> de Lord Klint Van Peers !");
                R(ref s, "Wait...<E003 16> <E025 3>Oh my goodness...", "Attendez...<E003 16> <E025 3>Grand Dieu...");
                R(ref s, "<E007>(Look at this...)", "<E007>(Regardez ça...)");
                R(ref s, "<E007>(This is unbelievable...)", "<E007>(C'est tout bonnement incroyable...)");
                R(ref s, "<E007>Klint van Zieks's will has been\r\nentered into the Court Record.", "<E007>Le testament de Klint Van Peers a été\r\najouté au dossier de l'affaire.");
                return s;
            };

            // [21] _sce04_evidence_eng#17
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#17"] = (en) => {
                string s = en;
                R(ref s, "‘Twist thy head and watch them fall, <E003 8>All thy mortal foes...’", "« Tourne la tête et contemple la chute, <E003 8>de tous tes mortels ennemis... »");
                R(ref s, "Kazuma's father certainly had a way with words.", "Le père de Kazuma avait décidément le sens de la formule.");
                R(ref s, "And he certainly thought up an ingenious hiding place,\r\ntoo.", "Et il a assurément imaginé une cachette d'une ingéniosité hors pair.");
                R(ref s, "It seems almost playful at first, <E003 8>but I do wonder if over the\r\nyears perhaps...", "Cela paraît presque espiègle au premier abord, <E003 8>mais je me demande si, au fil\r\ndes ans...");
                R(ref s, "...the duties of the Asogi clan have actually called for such\r\ninventiveness.", "... les devoirs du clan Asogi n'ont pas véritablement exigé une telle\r\ningéniosité.");
                R(ref s, "Protecting great secrets, <E003 6>you mean?<E003 12>\r\n<E025 2>Those sorts of duties?", "Protéger de grands secrets, <E003 6>voulez-vous dire ?<E003 12>\r\n<E025 2>Ce genre de devoirs ?");
                R(ref s, "<E007>(Well, <E003 8><E025 2>I could believe that.)", "<E007>(Eh bien, <E003 8><E025 2>je n'aurais aucun mal à le croire.)");
                R(ref s, "<E007>(Kazuma conducts himself like someone with the weight\r\nof his clan's long and noble history on his shoulders.)", "<E007>(Kazuma se comporte comme quelqu'un qui porte tout le poids\r\nde la longue et noble histoire de son clan sur les épaules.)");
                return s;
            };

            // [22] _sce04_evidence_eng#18
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#18"] = (en) => {
                string s = en;
                R(ref s, "Karuma, <E003 8>the great blade...<E003 14>\r\n<E025 2>It's such a thing of beauty, <E003 6>I want to gaze on it for hours.", "Karuma, <E003 8>la grande lame...<E003 14>\r\n<E025 2>C'est une telle merveille <E003 6>que je pourrais la contempler des heures durant.");
                return s;
            };

            // [23] _sce04_evidence_eng#19
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#19"] = (en) => {
                string s = en;
                R(ref s, "Karuma, <E003 8>the great blade...<E003 14>\r\n<E025 2>It's such a thing of beauty, <E003 6>I want to gaze on it for hours.", "Karuma, <E003 8>la grande lame...<E003 14>\r\n<E025 2>C'est une telle merveille <E003 6>que je pourrais la contempler des heures durant.");
                return s;
            };

            // [24] _sce04_evidence_eng#20
            entryTranslators["BB\\script\\output\\_sce04_evidence_eng#20"] = (en) => {
                string s = en;
                R(ref s, "You see these little things all over the place,<E003 6> don't you?", "On en voit un peu partout de ces petites choses-là,<E003 6> pas vrai ?");
                R(ref s, "It's the part on the top of a pocket watch that you twist to\r\nset the time, <E003 6>isn't it?", "C'est la pièce au sommet d'une montre à gousset qu'on tourne pour\r\nrégler l'heure, <E003 6>n'est-ce pas ?");
                R(ref s, "It's called ‘<E006>the crown<E005>’, <E003 8>I believe.<E003 12>\r\nA watch would be quite useless without one.", "On appelle cela « <E006>la couronne<E005> », <E003 8>je crois.<E003 12>\r\nUne montre serait bien inutile sans elle.");
                R(ref s, "The crown?<E003 10> <E025 2>Like what sits on top of a monarch's head?<E003 12>\r\nThat's a very grand name for such a tiny part.", "La couronne ?<E003 10> <E025 2>Comme celle qui coiffe la tête d'un monarque ?<E003 12>\r\nC'est un bien grand mot pour une si petite pièce.");
                R(ref s, "But actually...", "Mais à vrai dire...");
                R(ref s, "Yes, Mr Naruhodo?", "Oui, monsieur Naruhodo ?");
                R(ref s, "...if this is a crown...", "... si ceci est une couronne...");
                R(ref s, "...I have a feeling I might have seen a monarch around\r\nhere somewhere with a very bare head!", "... j'ai l'impression d'avoir aperçu dans les parages un monarque\r\nqui avait la tête bien dégarnie !");
                R(ref s, "...If by monarch you mean pocket watch, <E003 12><E346><E025 1>then I'm quite\r\nsure you have!", "... Si par monarque vous entendez montre à gousset, <E003 12><E346><E025 1>je suis alors\r\ncertaine que c'est le cas !");
                return s;
            };
        }
    }
}
