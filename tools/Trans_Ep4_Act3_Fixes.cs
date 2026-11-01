using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TranslatorEp4Act3 {
    public partial class Program {
        public static void RegisterFixes() {
            // 1) BB\script\output\_sce03_c102_0020_eng#21
            entryTranslators[@"BB\script\output\_sce03_c102_0020_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("Mr Gossip!", "Monsieur Ragot !");
                s = s.Replace("Do you have something to say?", "Avez-vous quelque chose à dire ?");
                s = s.Replace("Mr Boone!", "Monsieur Boone !");
                s = s.Replace("I do as it happens!", "Tout à fait, parbleu !");
                s = s.Replace("Your timing's perfect.", "Vous tombez à pic.");
                s = s.Replace("I've just got wind of a juicy tale that'll be right up your\r\nsnicket.", "J'viens d'avoir vent d'une histoire croustillante qui va vous\r\nplaire à coup sûr.");
                s = s.Replace("You don't want to let this one slip by, ", "Vous n'voudriez pas laisser passer ça, ");
                s = s.Replace("I tell ya.", "j'vous l'dis.");
                s = s.Replace("And sixpence is all I ask...", "Et six pence, c'est tout c'que j'demande...");
                s = s.Replace("...Maybe ", "... Essayez plutôt ");
                s = s.Replace("try Prosecutor Asogi instead.", "auprès du procureur Asogi.");
                s = s.Replace("I don't want your gossip, ", "Je n'ai que faire de vos ragots, ");
                s = s.Replace("Ryunosuke Naruhodo.", "Ryunosuke Naruhodo.");
                return s;
            };

            // 2) BB\script\output\_sce03_c102_0040_eng#2
            entryTranslators[@"BB\script\output\_sce03_c102_0040_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("I take it that you've formulated a proper hypothesis,<E003 6>\r\nCounsel?", "J'imagine que vous avez formulé une hypothèse convenable,<E003 6>\r\nMaître ?");
                s = s.Replace("Regarding this ", "Concernant cette ");
                s = s.Replace("apparent discrepancy between the\r\nwitness's account and the handprint found at the scene.", "divergence apparente entre la déposition\r\ndu témoin et la trace de main trouvée sur les lieux.");
                s = s.Replace("I have, ", "C'est le cas, ");
                s = s.Replace("My Lord.", "Votre Honneur.");
                return s;
            };

            // 3) BB\script\output\_sce03_c102_0050_eng#2
            entryTranslators[@"BB\script\output\_sce03_c102_0050_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So, Counsel, <E049><E003 8>I must ask you to clarify your assertion for\r\nthe court.", "Maître, <E049><E003 8>je vous prie d'éclaircir votre affirmation devant ce\r\ntribunal.");
                return s;
            };

            // 4) BB\script\output\_sce03_c103_0010_eng#16
            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("Said 'e 'adn't missed a day in the last ten years,<E049><E003 12> polishin' it\r\nan' windin' it.", "Y disait qu'y avait pas raté un jour depuis dix ans,<E049><E003 12> à la briquer\r\net à la r'monter.");
                s = s.Replace("It meant the world to 'im, ", "Elle comptait plus qu'tout pour lui, ");
                s = s.Replace("that watch did.", "c'te montre.");
                return s;
            };

            // 5) BB\script\output\_sce03_c103_0010_eng#18
            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("certainly know how to lie...", "savez décidément mentir...");
                s = s.Replace("Oh, ", "Oh, ");
                s = s.Replace("it was nothin' ", "c'était rien, ");
                s = s.Replace("really.", "franchement.");
                s = s.Replace("Just a little porky.", "Juste un p'tit bobard.");
                s = s.Replace("With not-so-little implications...", "Aux conséquences pas si petites...");
                s = s.Replace("Did you know?", "L'saviez-vous ?");
                s = s.Replace("Everythin' in the world apart from the truth ", "Tout dans l'monde à part la vérité ");
                s = s.Replace("is a big fat\r\nlie!", "est un gros mensonge\r\nbidon !");
                s = s.Replace("...If you believe that, ", "... Si vous y croyez, ");
                s = s.Replace("of course.", "bien sûr.");
                s = s.Replace("...I'm lost.", "... Je m'y perds.");
                s = s.Replace("As am I.", "Moi également.");
                s = s.Replace("This desecration of the truth is really rather\r\ndisturbing.", "Cette profanation de la vérité est pour le moins\r\ndérangeante.");
                s = s.Replace("I think perhaps we should move on to the next witness,\r\n<E169 15 0><E003 6>hm", "Je pense que nous devrions passer au témoin suivant,\r\n<E169 15 0><E003 6>hum");
                return s;
            };

            // 6) BB\script\output\_sce03_c103_0010_eng#24
            entryTranslators[@"BB\script\output\_sce03_c103_0010_eng#24"] = (en) => {
                string s = en;
                s = s.Replace("Mr Gossip!", "Monsieur Ragot !");
                s = s.Replace("Do you have something to say?", "Avez-vous quelque chose à dire ?");
                s = s.Replace("Mr Boone!", "Monsieur Boone !");
                s = s.Replace("I do as it happens!", "Tout à fait, parbleu !");
                s = s.Replace("Your timing's perfect.", "Vous tombez à pic.");
                s = s.Replace("I've just got wind of a juicy tale that'll be right up your\r\nsnicket.", "J'viens d'avoir vent d'une histoire croustillante qui va vous\r\nplaire à coup sûr.");
                s = s.Replace("You don't want to let this one slip by, ", "Vous n'voudriez pas laisser passer ça, ");
                s = s.Replace("I tell ya.", "j'vous l'dis.");
                s = s.Replace("And sixpence is all I ask...", "Et six pence, c'est tout c'que j'demande...");
                s = s.Replace("...Maybe ", "... Essayez plutôt ");
                s = s.Replace("try Prosecutor Asogi instead.", "auprès du procureur Asogi.");
                s = s.Replace("I don't want your gossip, ", "Je n'ai que faire de vos ragots, ");
                s = s.Replace("Ryunosuke Naruhodo.", "Ryunosuke Naruhodo.");
                return s;
            };

            // 7) BB\script\output\_sce03_c103_0050_eng#2
            entryTranslators[@"BB\script\output\_sce03_c103_0050_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Explain yourself then, <E003 4>Counsel.", "Expliquez-vous donc, <E003 4>Maître.");
                return s;
            };

            // 8) BB\script\output\_sce03_c103_0050_eng#3
            entryTranslators[@"BB\script\output\_sce03_c103_0050_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("A noise that sounds like a gunshot ", "Un bruit ressemblant à un coup de feu ");
                s = s.Replace("could have been made\r\nwith...", "a pu être produit\r\navec...");
                return s;
            };

            // 9) BB\script\output\_sce03_c103_0060_eng#2
            entryTranslators[@"BB\script\output\_sce03_c103_0060_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Your extravagant claim will have to be substantiated\r\nwith evidence, <E049><E003 6>Counsel.", "Votre thèse extravagante devra être étayée par des preuves,\r\n<E049><E003 6>Maître.");
                return s;
            };

            // 10) BB\script\output\_sce03_c103_0060_eng#7
            entryTranslators[@"BB\script\output\_sce03_c103_0060_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Pfft...", "Pfft...");
                s = s.Replace("Ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>hah!", "Ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>ha <E003 4>ha !");
                s = s.Replace("Oh, ", "Oh, ");
                s = s.Replace("very impressive, ", "très impressionnant, ");
                s = s.Replace("Ryunosuke <E049><E003 6>Naruhodo.", "Ryunosuke <E049><E003 6>Naruhodo.");
                s = s.Replace("K-<E049><E003 10>Kazuma?!", "K-<E049><E003 10>Kazuma ?!");
                s = s.Replace("I'm really quite amazed you've come this far.", "Je suis sincèrement stupéfait que tu sois parvenu jusqu'ici.");
                s = s.Replace("But after all, ", "Mais après tout, ");
                s = s.Replace("wasn't I the one who told you...", "n'est-ce point moi qui t'avais dit...");
                s = s.Replace("...that you ", "... que tu ");
                s = s.Replace("had all the makings of a great defence lawyer?", "avais l'étoffe d'un grand avocat de la défense ?");
                s = s.Replace("I also noted the lack of a time of death in this report.<E049><E003 10>\r\n<E025 3>A stark omission.", "J'avais également noté l'absence d'heure du décès dans ce rapport.<E049><E003 10>\r\n<E025 3>Une omission flagrante.");
                s = s.Replace("But as far as I'm concerned...", "Mais en ce qui me concerne...");
                s = s.Replace("this whole country's justice\r\nsystem leaves a lot to be desired!", "tout le système judiciaire de ce pays\r\nlaisse grandement à désirer !");
                s = s.Replace("Ordaaar!<E003 4> Ordaaar!<E003 4> Orrrdaaar!", "Du caaalme !<E003 4> Du caaalme !<E003 4> Du caaaalme !");
                s = s.Replace("Prosecutor Asogi!", "Procureur Asogi !");
                s = s.Replace("What on earth do you mean by that statement?", "Que voulez-vous dire par là, grand Dieu ?");
                s = s.Replace("I hear that many of the leading members of Britain's\r\njudiciary are present to observe this trial today.", "J'ai cru comprendre que de nombreux magistrats éminents de\r\nla justice britannique assistent à ce procès aujourd'hui.");
                s = s.Replace("So we cannot allow even the slightest doubt to be\r\noverlooked.", "Nous ne pouvons donc permettre au moindre doute d'être négligé.");
                s = s.Replace("The defence's assertion about the time of death based on\r\nthe victim's stopped watch ", "L'affirmation de la défense quant à l'heure du décès reposant\r\nsur la montre arrêtée de la victime ");
                s = s.Replace("is just <E006>conjecture<E005>.", "n'est qu'une <E006>conjecture<E005>.");
                s = s.Replace("But...", "Mais...");
                s = s.Replace("while the possibility exists that my learned friend\r\nmay be correct...", "tant qu'il subsiste une possibilité que mon confrère\r\nait raison...");
                s = s.Replace("we have a duty to explore it.", "nous avons le devoir de l'examiner.");
                s = s.Replace("Hmm<E341>m...", "Hum<E341>m...");
                s = s.Replace("Well, ", "Ma foi, ");
                s = s.Replace("certainly...", "assurément...");
                s = s.Replace("I would agree with you.", "je partage votre avis.");
                s = s.Replace("And what immediately comes to mind ", "Et ce qui vient immédiatement à l'esprit ");
                s = s.Replace("is of course...", "est bien sûr...");
                s = s.Replace("...what was Inspector Gregson doing ", "... que faisait l'inspecteur Gregson ");
                s = s.Replace("and where did he go", "et où s'est-il rendu");
                s = s.Replace("on <E006>the day before<E005> the incident?", "la <E006>veille<E005> des faits ?");
                s = s.Replace("Do you know?", "Le savez-vous ?");
                s = s.Replace("The inspector always carried out his investigative work\r\nalone.", "L'inspecteur menait toujours ses enquêtes en solitaire.");
                s = s.Replace("His movements were treated as confidential within\r\nScotland Yard.", "Ses déplacements étaient strictement confidentiels au sein\r\nmême de Scotland Yard.");
                s = s.Replace("Even within the Yard?", "Même au Yard ?");
                s = s.Replace("However, considering the evidence we've been presented\r\nwith so far...", "Cependant, au vu des pièces à conviction présentées\r\njusqu'à présent...");
                s = s.Replace("...I'd say it's fairly apparent what case the man was\r\npursuing. Wouldn't you, my learned friend?", "... j'estime qu'il est assez manifeste de savoir quelle affaire cet\r\nhomme poursuivait. N'est-ce pas, mon estimé confrère ?");
                s = s.Replace("I do have a feeling about what case he might have been\r\ninvestigating.", "J'ai en effet une idée quant à l'affaire sur laquelle il enquêtait.");
                s = s.Replace("Yes, I agree. Surely...", "Oui, je suis d'accord. Sûrement...");
                s = s.Replace("My Lord!", "Votre Honneur !");
                s = s.Replace("The defence believes it can explain to the court...", "La défense estime être en mesure d'exposer au tribunal...");
                s = s.Replace("...the case that was being investigated by Inspector\r\nGregson at the time of his death!", "... l'affaire sur laquelle enquêtait l'inspecteur\r\nGregson au moment de sa mort !");
                return s;
            };

            // 11) BB\script\output\_sce03_c103_0070_eng#2
            entryTranslators[@"BB\script\output\_sce03_c103_0070_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Very well, <E003 8>Counsel.<E049><E003 12>\r\n<E025 2>Present your argument to the court.", "Très bien, <E003 8>Maître.<E049><E003 12>\r\n<E025 2>Présentez votre raisonnement au tribunal.");
                return s;
            };

            // 12) BB\script\output\_sce03_c103_0070_eng#4
            entryTranslators[@"BB\script\output\_sce03_c103_0070_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Hm...<E003 12> <E169 15 3><E025 2>I can't say that I find your answer suggestive of\r\nanything in particular.", "Hum...<E003 12> <E169 15 3><E025 2>Je ne saurais dire en quoi votre réponse évoque\r\nquoi que ce soit de particulier.");
                s = s.Replace("Other than perhaps that it is utterly wrong.<E049><E003 12>\r\n<E025 2>That much you have clarified most expertly.", "Si ce n'est peut-être qu'elle est totalement erronée.<E049><E003 12>\r\n<E025 2>Voilà qui est clarifié de main de maître.");
                s = s.Replace("Wha...?", "Quoi... ?");
                s = s.Replace("Congratulations, <E003 6>Ryunosuke Naruhodo.", "Félicitations, <E003 6>Ryunosuke Naruhodo.");
                s = s.Replace("You deserve a reward for that expert display!", "Tu mérites une récompense pour cette magistrale démonstration !");
                s = s.Replace("AAAAAARGH", "AAAAAARGH");
                s = s.Replace("(Did, <E003 10>did you just draw Karuma on me, <E003 10><E341>my friend?)", "(Est... <E003 10>est-ce que tu viens de dégainer Karuma contre moi, <E003 10><E341>mon ami ?)");
                s = s.Replace("I think, <E049><E003 6>Mr Naruhodo, <E049><E003 8>that there's one particular piece of\r\nevidence...", "Je crois, <E049><E003 6>monsieur Naruhodo, <E049><E003 8>qu'il existe une pièce à conviction\r\nen particulier...");
                s = s.Replace("...that really does stand out in showing what case\r\nInspector Gregson was investigating.", "... qui indique on ne peut plus clairement quelle affaire\r\nl'inspecteur Gregson suivait.");
                s = s.Replace("My Lord! I have the answer now!", "Votre Honneur ! J'ai la réponse cette fois !");
                return s;
            };

            // 13) BB\script\output\_sce03_c103_0070_eng#5
            entryTranslators[@"BB\script\output\_sce03_c103_0070_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("I believe this red hairpiece points to the answer.", "J'estime que ce postiche roux nous fournit la réponse.");
                s = s.Replace("We might assume <E049><E003 4><E145 1 1><E003 8><E330>it was part of a disguise used to carry\r\nout <E006>an undercover investigation<E005>.", "Nous pouvons supposer <E049><E003 4><E145 1 1><E003 8><E330>qu'il servait de déguisement dans le cadre\r\nd'<E006>une mission d'infiltration<E005>.");
                s = s.Replace("Surely not!<E049><E003 12> Such a brightly coloured hairpiece would only\r\nserve to make the inspector more noticeable.", "Certainement point !<E049><E003 12> Un postiche d'une teinte aussi vive n'aurait\r\nfait que rendre l'inspecteur d'autant plus voyant.");
                s = s.Replace("Yes, <E049><E003 10>that's quite true.", "Oui, <E049><E003 10>c'est tout à fait vrai.");
                s = s.Replace("It would definitely have made him stand out in a crowd.", "Cela l'aurait indubitablement fait ressortir dans la foule.");
                s = s.Replace("Except, <E049><E003 8>that is...<E003 8><E060 0 113 1 0><E145 1 21><E003 15><E239><E025 2>in a crowd of gentlemen from <E006>the\r\nRed-Headed League<E005>.", "Sauf, <E049><E003 8>bien sûr...<E003 8><E060 0 113 1 0><E145 1 21><E003 15><E239><E025 2>au milieu d'un rassemblement de la <E006>Ligue\r\ndes Rouquins<E005>.");
                s = s.Replace("The, <E049><E003 10><E341>the Red-Headed League?", "La, <E049><E003 10><E341>la Ligue des Rouquins ?");
                s = s.Replace("So...<E049><E003 4><E145 112 15><E003 20><E025 2><E238>you'd already worked it out.", "Ainsi...<E049><E003 4><E145 112 15><E003 20><E025 2><E238>tu l'avais déjà compris.");
                s = s.Replace("What on earth <E145 15 0>is this all about?<E049><E003 12>\r\n<E025 2><E341>Is there such an extraordinary league of gentlemen?", "De quoi s'agit-il au juste <E145 15 0>, grand Dieu ?<E049><E003 12>\r\n<E025 2><E341>Existe-t-il véritablement une telle et insolite congrégation ?");
                s = s.Replace("The Red-Headed League is currently under investigation<E049><E003 12>\r\n<E025 3>for a grand deception.", "La Ligue des Rouquins fait actuellement l'objet d'une enquête<E049><E003 12>\r\n<E025 3>pour escroquerie de grande envergure.");
                s = s.Replace("A deception of what nature, <E049><E003 6>Counsel?", "Une escroquerie de quelle nature, <E049><E003 6>Maître ?");
                s = s.Replace("They've been targeting red-headed men across all of\r\nLondon and tricking them out of small sums of money.", "Ils ont ciblé des hommes roux dans tout Londres pour leur soutirer\r\nde coquettes sommes d'argent.");
                s = s.Replace("Two men were arrested for the misdemeanour only\r\nyesterday, <E049><E003 6>in fact.", "Deux hommes ont été appréhendés pour ce délit hier même,\r\n<E049><E003 6>en réalité.");
                s = s.Replace("My Lord!", "Votre Honneur !");
                s = s.Replace("The defence <E049><E003 10><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>calls for those two men to be summoned at\r\nonce!", "La défense <E049><E003 10><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>demande la convocation immédiate de ces deux\r\nhommes !");
                s = s.Replace("T-<E003 10><E025 1><E145 15 3><E331><E169 15 3>Two red-heads?!", "D-<E003 10><E025 1><E145 15 3><E331><E169 15 3>Deux rouquins ?!");
                s = s.Replace("Inspector Gregson <E049><E003 8><E060 0 119 1 0>clearly infiltrated the Red-Headed\r\nLeague using this hairpiece.", "L'inspecteur Gregson <E049><E003 8><E060 0 119 1 0>a manifestement infiltré la Ligue\r\ndes Rouquins au moyen de ce postiche.");
                s = s.Replace("So it's very likely that he had direct contact with these\r\ncriminals.", "Il est donc fort probable qu'il ait été en contact direct avec\r\nces malfaiteurs.");
                s = s.Replace("And it's quite possible that such contact led to...<E003 12><E025 3><E330>more\r\nserious events.", "Et il est tout à fait possible qu'un tel contact ait mené à...<E003 12><E025 3><E330>des\r\névénements bien plus graves.");
                s = s.Replace("I concur <E049><E003 6><E025 2><E145 15 0><E144 15>that we cannot in good conscience leave this new\r\navenue unexplored.", "Je conviens <E049><E003 6><E025 2><E145 15 0><E144 15>que notre conscience nous interdit de laisser cette\r\nnouvelle piste inexplorée.");
                s = s.Replace("Well done, <E049><E003 8><E341>Mr Naruhodo!", "Bien joué, <E049><E003 8><E341>monsieur Naruhodo !");
                s = s.Replace("Well...<E003 10><E025 2>it's another possible line of enquiry for us at least.", "Bien...<E003 10><E025 2>voilà au moins une autre piste d'investigation pour nous.");
                s = s.Replace("The prosecution <E145 15 7>will make immediate arrangements for\r\nthe charged men to appear.", "L'accusation <E145 15 7>prendra immédiatement les dispositions requises\r\npour faire comparaître les prévenus.");
                s = s.Replace("Bring these two Red-Headed League conspirators before\r\nme, <E049><E003 10><E145 15 5><E025 2><E346>Prosecutor Asogi!", "Faites comparaître devant moi ces deux conspirateurs de la\r\nLigue des Rouquins, <E049><E003 10><E145 15 5><E025 2><E346>procureur Asogi !");
                s = s.Replace("At once, <E049><E003 6>My Lord.", "À l'instant, <E049><E003 6>Votre Honneur.");
                s = s.Replace("Very good.<E049><E003 10> <E145 15 0><E025 2>We will have a thirty-minute recess.<E049><E003 12>\r\n<E025 2>Court is adjourned!", "Fort bien.<E049><E003 10> <E145 15 0><E025 2>Nous suspendons l'audience pour trente minutes.<E049><E003 12>\r\n<E025 2>La séance est levée !");
                return s;
            };

            // 14) BB\script\output\_sce03_c103_0000_eng#3
            entryTranslators[@"BB\script\output\_sce03_c103_0000_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Hmmm...<E003 14><E169 15 3><E145 15 7>\r\n<E025 3>So none of you can elaborate further... ", "Hummm...<E003 14><E169 15 3><E145 15 7>\r\n<E025 3>Ainsi aucun de vous ne peut en dire davantage... ");
                s = s.Replace("Shaken by the crime they witnessed, <E049><E003 8><E025 2>and with only the\r\nlight of a few candles and an oil lamp by which to see...", "Bouleversés par le crime dont ils ont été témoins, <E049><E003 8><E025 2>et avec pour seule\r\nlueur celle de quelques bougies et d'une lampe à huile...");
                s = s.Replace("...we can't expect these witnesses to be able to give a\r\nmore precise account of what happened.", "... nous ne pouvons exiger de ces témoins un compte rendu plus\r\nprécis de ce qui s'est produit.");
                s = s.Replace("That's right, <E049><E003 8>yeah.<E049><E003 10> <E145 100 65><E025 2>It don't pay to expect too much.", "C'est bien vrai, <E049><E003 8>ouais.<E049><E003 10> <E145 100 65><E025 2>Faut pas trop en d'mander.");
                s = s.Replace("It's m-<E003 6>man's endless quest for knowledge that's\r\nd-<E003 6>d-<E003 6>destroying the world.<E049><E003 10> <E025 3>That's w-<E003 6>what I think.", "C'est la quête sans fin d'savoir de l'h-<E003 6>homme qui\r\nd-<E003 6>d-<E003 6>détruit l'monde.<E049><E003 10> <E025 3>C'est c'-<E003 6>ce que j'pense.");
                s = s.Replace("...Do you?<E049><E003 10> Really.", "... Ah bon ?<E049><E003 10> Vraiment.");
                s = s.Replace("In any case, <E049><E003 8>as this testimony shows...", "Quoi qu'il en soit, <E049><E003 8>comme en atteste cette déposition...");
                s = s.Replace("...even if the noticeboard was moved by somebody\r\nfollowing the incident, <E049><E003 6>it makes no difference.", "... même si le panneau a été déplacé par quelqu'un\r\naprès les faits, <E049><E003 6>cela ne change rien.");
                s = s.Replace("When the gunshot rang out, <E049><E003 8><E238><E025 3>the accused was the only\r\nperson at the scene.", "Lorsque le coup de feu a retenti, <E049><E003 8><E238><E025 3>l'accusé était la seule\r\npersonne sur les lieux.");
                s = s.Replace("In short, <E049><E003 10>the only person who could possibly have\r\ncommitted this crime...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 2 1><E139 112>is Barok van Zieks!", "En somme, <E049><E003 10>la seule personne qui pouvait avoir\r\ncommis ce crime...<E049><E003 6><E025 1><E164 112 10 1 2 5 0 2 1><E139 112>est Drake Van Peers !");
                s = s.Replace("None of this wrangling over the board changes that simple\r\nfact.", "Aucune de ces querelles sur le panneau ne change ce simple\r\nfait.");
                s = s.Replace("Quite so, <E049><E003 8>quite so.", "Tout à fait, <E049><E003 8>tout à fait.");
                s = s.Replace("Does the defence still wish to cross-examine the\r\nwitnesses despite the circumstances?", "La défense souhaite-t-elle tout de même contre-interroger les\r\ntémoins malgré les circonstances ?");
                s = s.Replace("Most certainly, <E049><E003 10>My Lord!", "Très certainement, <E049><E003 10>Votre Honneur !");
                s = s.Replace("Very well.<E049><E003 10> <E145 15 0><E338><E341><E025 2>Then you may proceed, <E049><E003 4>Counsel.", "Fort bien.<E049><E003 10> <E145 15 0><E338><E341><E025 2>Vous pouvez procéder, <E049><E003 4>Maître.");
                return s;
            };
        }
    }
}
