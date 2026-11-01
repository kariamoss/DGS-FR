using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslatorEp5Act5 {
    public partial class Program {
        public static void RegisterPart3() {
            entryTranslators["BB\\script\\output\\_macro04_eng#6"] = en => {
                string s = en;
                R(ref s, "We've wasted enough time!",
                         "Nous avons perdu assez de temps !");
                R(ref s, "It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.",
                         "Il est clair à mes yeux <E049><E003 8><E025 2>que prolonger les débats sur\r\ncette affaire ne mènera à rien.");
                R(ref s, "Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...",
                         "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que même si vos actes\r\nétaient dévoyés...");
                R(ref s, "...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...",
                         "... vous avez agi par soif de justice.<E049><E003 12>\r\n<E025 3>Même s'il m'est pénible d'aboutir à une telle conclusion...");
                R(ref s, "No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!",
                         "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                R(ref s, "In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...",
                         "Au vu des éléments apportés devant cette cour, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                R(ref s, "That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!",
                         "L'affaire est close.<E049><E003 10>\r\n<E025 2>La séance est levée !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#7"] = en => {
                string s = en;
                R(ref s, "We've wasted enough time!",
                         "Nous avons perdu assez de temps !");
                R(ref s, "It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.",
                         "Il est clair à mes yeux <E049><E003 8><E025 2>que prolonger les débats sur\r\ncette affaire ne mènera à rien.");
                R(ref s, "Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...",
                         "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que même si vos actes\r\nétaient dévoyés...");
                R(ref s, "...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...",
                         "... vous avez agi par soif de justice.<E049><E003 12>\r\n<E025 3>Même s'il m'est pénible d'aboutir à une telle conclusion...");
                R(ref s, "No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!",
                         "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                R(ref s, "In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...",
                         "Au vu des éléments apportés devant cette cour, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                R(ref s, "That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!",
                         "L'affaire est close.<E049><E003 10>\r\n<E025 2>La séance est levée !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#8"] = en => {
                string s = en;
                R(ref s, "We've wasted enough time!",
                         "Nous avons perdu assez de temps !");
                R(ref s, "It's clear to me <E049><E003 8><E025 2>that any further discussion of this case will\r\nbe fruitless.",
                         "Il est clair à mes yeux <E049><E003 8><E025 2>que prolonger les débats sur\r\ncette affaire ne mènera à rien.");
                R(ref s, "Barok van Zieks, <E049><E003 8><E025 2>I would like to think that however\r\nmisguided...",
                         "Drake Van Peers, <E049><E003 8><E025 2>j'ose croire que même si vos actes\r\nétaient dévoyés...");
                R(ref s, "...you acted out of a sense of justice nonetheless.<E049><E003 12>\r\n<E025 3>Though it pains me to have reached this conclusion...",
                         "... vous avez agi par soif de justice.<E049><E003 12>\r\n<E025 3>Même s'il m'est pénible d'aboutir à une telle conclusion...");
                R(ref s, "No!<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Wait, My Lord!",
                         "Non !<E049><E003 8>\r\n<E025 1><E164 1 71 1 2 1 0 2 1><E139 1>Attendez, Votre Honneur !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#9"] = en => {
                string s = en;
                R(ref s, "In accordance with the findings of this court, <E049><E003 6><E025 3>I hereby\r\npronounce the defendant, <E049><E003 6><E025 3>Barok van Zieks...",
                         "Au vu des éléments apportés devant cette cour, <E049><E003 6><E025 3>je déclare\r\npar la présente l'accusé, <E049><E003 6><E025 3>Drake Van Peers...");
                R(ref s, "That concludes business.<E049><E003 10>\r\n<E025 2>Court is adjourned!",
                         "L'affaire est close.<E049><E003 10>\r\n<E025 2>La séance est levée !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#10"] = en => {
                string s = en;
                R(ref s, "...Enough!<E049><E003 16>\r\n<E025 2>No further discussion is required.",
                         "... Assez !<E049><E003 16>\r\n<E025 2>Aucune autre discussion n'est requise.");
                R(ref s, "For the preservation of law and order in London,<E049><E003 8> and for\r\nthe triumph of justice...",
                         "Pour la préservation de l'ordre public à Londres,<E049><E003 8> et pour\r\nle triomphe de la justice...");
                R(ref s, "...the only correct course of action <E049><E003 4><E164 61 33 1 2 5 0 2 1><E139 61><E025 1>has been unanimously\r\nacknowledged by the clear majority here present!",
                         "... la seule décision légitime <E049><E003 4><E164 61 33 1 2 5 0 2 1><E139 61><E025 1>a été unanimement\r\napprouvée par la nette majorité ici présente !");
                R(ref s, "All mention of that which has been discussed in this\r\ncourtroom today <E049><E003 10><E025 3>will be struck from the records.",
                         "Toute mention de ce qui a été débattu dans ce\r\nprétoire aujourd'hui <E049><E003 10><E025 3>sera rayée des procès-verbaux.");
                R(ref s, "Barok van Zieks –<E049><E003 10> or should I say, <E049><E003 8>Reaper of the Bailey...",
                         "Drake Van Peers...<E049><E003 10> ou devrais-je dire, <E049><E003 8>Faucheur de la Cour...");
                R(ref s, "...the heinous crimes committed by your brother,<E049><E003 6> Klint\r\nvan Zieks, <E049><E003 8>will be lost in obscurity, <E049><E003 8><E025 3>this time forever.",
                         "... les crimes odieux perpétrés par votre frère,<E049><E003 6> Klint\r\nVan Peers, <E049><E003 8>sombreront dans l'oubli, <E049><E003 8><E025 3>cette fois à tout jamais.");
                R(ref s, "May you also find peace now <E049><E003 8>as you join your sibling in\r\nthe eternal darkness.",
                         "Puissiez-vous également trouver la paix, à présent <E049><E003 8>que vous\r\nrejoignez votre frère dans les ténèbres éternelles.");
                R(ref s, "In accordance with the findings of this court, <E049><E003 8>I hereby\r\npronounce the defendant, <E049><E003 8><E025 3>Barok van Zieks...",
                         "Au vu des éléments apportés devant cette cour, <E049><E003 8>je déclare\r\npar la présente l'accusé, <E049><E003 8><E025 3>Drake Van Peers...");
                R(ref s, "Court is adjourned!",
                         "La séance est levée !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#12"] = en => {
                string s = en;
                R(ref s, "The evidence...<E049><E003 8><E164 1 71 1 2 8 0 1 1><E139 1><E025 1>is this!",
                         "La preuve...<E049><E003 8><E164 1 71 1 2 8 0 1 1><E139 1><E025 1>la voici !");
                R(ref s, "...<E003 8><E025 2>You perplex me, <E049><E003 6>Counsel, <E049><E003 8>by looking so pleased with\r\nyourself despite this quite displeasing answer.",
                         "...<E003 8><E025 2>Vous me laissez perplexe, <E049><E003 6>Maître, <E049><E003 8>à vous montrer si satisfait de\r\nvous malgré cette réponse des plus déplaisantes.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#13"] = en => {
                string s = en;
                R(ref s, "Well...<E003 8><E025 2>I think it takes a certain genius <E049><E003 6><E164 4 102 1 2 8 0 1 1><E139 4><E025 1>to give such a \r\ncompletely wrong answer, <E003 6>personally.",
                         "Eh bien...<E003 8><E025 2> il faut un génie certain, <E049><E003 6><E164 4 102 1 2 8 0 1 1><E139 4><E025 1>selon moi, pour fournir une\r\nréponse aussi complètement fausse.");
                R(ref s, "The kind of genius <E003 6><E341>I could really do without.<E003 10>\r\n<E007>(Time to think again...)",
                         "Le genre de génie <E003 6><E341>dont je me passerais bien volontiers.<E003 10>\r\n<E007>(Il est temps de revoir ma copie...)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#14"] = en => {
                string s = en;
                R(ref s, "The witness's last statement...<E003 8><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>exhibits a fundamental\r\ninconsistency!",
                         "La dernière déposition du témoin...<E003 8><E164 1 8 1 2 8 0 2 1><E139 1><E025 1>présente une contradiction\r\nfondamentale !");
                R(ref s, "Not one that any British court would recognise, <E049><E003 6>Counsel.",
                         "Pas une seule contradiction qu'un tribunal britannique daignerait reconnaître, <E049><E003 6>Maître.");
                R(ref s, "Wha...?!",
                         "Quoi... ?!");
                R(ref s, "Remember, <E049><E003 8>this is a closed court.<E049><E003 8> <E145 61 5><E144 61><E025 3><E239>Whatever fate befalls\r\nyou in here, <E049><E003 8>no one outside will ever know.",
                         "N'oubliez pas <E049><E003 8>que ce tribunal siège à huis clos.<E049><E003 8> <E145 61 5><E144 61><E025 3><E239>Quel que soit le sort qui\r\nvous attend ici, <E049><E003 8>nul au-dehors n'en saura jamais rien.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#15"] = en => {
                string s = en;
                R(ref s, "(...Should I be wondering if I'll make it out of this\r\ncourtroom alive?)",
                         "(... Devrais-je me demander si je sortirai vivant de cette\r\nsalle d'audience ?)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#16"] = en => {
                string s = en;
                R(ref s, "That last statement...<E003 12><E025 2>seemed a little questionable to me.<E049><E003 8>\r\n<E025 1><E145 1 7><E144 1><E346>What do you think, My Lord?",
                         "Cette dernière déclaration...<E003 12><E025 2> m'a paru quelque peu douteuse.<E049><E003 8>\r\n<E025 1><E145 1 7><E144 1><E346>Qu'en pensez-vous, Votre Honneur ?");
                R(ref s, "I see no inconsistency there.<E049><E003 8>\r\n<E145 61 5><E144 61>...Do you?",
                         "Je n'y vois aucune contradiction.<E049><E003 8>\r\n<E145 61 5><E144 61>... Et vous ?");
                R(ref s, "Erm...",
                         "Euh...");
                R(ref s, "You could span the Straits of Dover with those wide eyes,<E049><E003 6>\r\n<E025 3>Counsel.<E049><E003 10> <E025 2>And be gone from this island forever, <E049><E003 6><E025 3>I hope.",
                         "On pourrait enjamber le pas de Calais avec de si grands yeux écarquillés,<E049><E003 6>\r\n<E025 3>Maître.<E049><E003 10> <E025 2>Et quitter cette île à tout jamais, <E049><E003 6><E025 3>je l'espère.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#17"] = en => {
                string s = en;
                R(ref s, "(Do you want me to fill the English Channel with tears?)",
                         "(Voulez-vous donc que je remplisse la Manche de mes larmes ?)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#18"] = en => {
                string s = en;
                R(ref s, "My Lord!<E049><E003 10> <E025 2>As counsel for the defence,<E049> <E003 12><E025 1><E332>I must object to that\r\nlast statement!",
                         "Votre Honneur !<E049><E003 10> <E025 2>En ma qualité d'avocat de la défense,<E049> <E003 12><E025 1><E332>je dois m'opposer à cette\r\ndernière déclaration !");
                R(ref s, "And as the judge, <E049><E003 6>I must deny your objection.<E049><E003 12>\r\n<E238>There is no contradiction here.",
                         "Et en ma qualité de juge, <E049><E003 6>je dois rejeter votre objection.<E049><E003 12>\r\n<E238>Il n'y a aucune contradiction en l'espèce.");
                R(ref s, "No contradiction, <E049><E003 8><E025 2>other than the fact <E049><E003 10><E025 1><E332>that a Far Eastern\r\nlawyer is practising in a British courtroom!",
                         "Aucune contradiction, <E049><E003 8><E025 2>hormis le fait <E049><E003 10><E025 1><E332>qu'un avocat venu d'Extrême-Orient\r\nexerce dans un prétoire britannique !");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#19"] = en => {
                string s = en;
                R(ref s, "(...Put there by a not-so-far away Lord Chief Justice,<E003 8> if\r\nyou remember.)",
                         "(... Avocat désigné par un lord juge en chef pas si lointain,<E003 8> si\r\nma mémoire est bonne.)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#20"] = en => {
                string s = en;
                R(ref s, "(Nothing much of note here, I'd say.)",
                         "(Rien de bien notable par ici, ma foi.)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#21"] = en => {
                string s = en;
                R(ref s, "(Nothing particular of note...)",
                         "(Rien de particulier à signaler...)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#22"] = en => {
                string s = en;
                R(ref s, "I can't find anything out of place.",
                         "Je ne trouve rien d'anormal.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#23"] = en => {
                string s = en;
                R(ref s, "Lord van Zieks!",
                         "Lord Van Peers !");
                R(ref s, "Let me guess:<E049><E003 10> <E238><E025 2>is there something about the witness's last\r\nstatement that troubles me?",
                         "Laissez-moi deviner :<E049><E003 10> <E238><E025 2>y a-t-il quelque chose dans la dernière déposition\r\ndu témoin qui me contrarie ?");
                R(ref s, "Is that what you wish to ask?",
                         "Est-ce là ce que vous souhaitiez demander ?");
                R(ref s, "Y-<E049><E003 6>Yes...<E003 12> Exactly...<E049><E003 8><E145 1 64><E003 8>\r\n<E025 2>You're very perceptive.",
                         "O-<E049><E003 6>Oui...<E003 12> Tout à fait...<E049><E003 8><E145 1 64><E003 8>\r\n<E025 2>Vous êtes fort perspicace.");
                R(ref s, "Whereas you...<E003 12><E025 3>would appear not to be.",
                         "Alors que vous...<E003 12><E025 3> semblez bien loin de l'être.");
                R(ref s, "Huh?",
                         "Hein ?");
                R(ref s, "You really need to learn how to read your fellow man...<E049><E003 12>\r\n<E025 3>my Nipponese friend.",
                         "Vous devriez vraiment apprendre à sonder vos semblables...<E049><E003 12>\r\n<E025 3>mon ami nippon.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#24"] = en => {
                string s = en;
                R(ref s, "(...Read them...<E003 12>or ‘reap’ them?)",
                         "(... Les sonder...<E003 12> ou les faucher ?)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#25"] = en => {
                string s = en;
                R(ref s, "(...Read them...<E003 12>or ‘reap’ them?)",
                         "(... Les sonder...<E003 12> ou les faucher ?)");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#26"] = en => {
                string s = en;
                R(ref s, "Something on your mind, <E049><E003 8><E341>Governor Caidin?",
                         "Quelque chose vous préoccupe, <E049><E003 8><E341>directeur Caidin ?");
                R(ref s, "Eh?",
                         "Hein ?");
                R(ref s, "It looked as though you were lost in thought there for a\r\nmoment.",
                         "Vous aviez l'air d'être perdu dans vos pensées à l'instant.");
                R(ref s, "Och, <E049><E003 20><E025 2>I cannae relax when I'm no at the prison, <E049><E003 6><E025 3>do ya ken?<E049><E003 12>\r\n<E025 2>I'm all het up worryin' aboot inmates escapin'...",
                         "Ah, <E049><E003 20><E025 2>j'peux point m'détendre quand j'suis point à la taule, <E049><E003 6><E025 3>vous m'suivez ?<E049><E003 12>\r\n<E025 2>J'me mets la rate au court-bouillon d'peur qu'des taulards s'fassent la malle...");
                R(ref s, "I thought that Barclay was the most secure prison in all\r\nof Britain?",
                         "Je croyais pourtant que Barclay était la prison la plus sûre de\r\ntoute la Grande-Bretagne ?");
                R(ref s, "A-<E049><E003 10><E025 1><E335>Aye, <E049><E003 8>that's right,<E049><E003 6><E025 2> it is!<E049><E003 16>\r\n<E025 3>I'm...<E049><E003 16><E025 2><E341>sure I dinnae ought worry...",
                         "O-<E049><E003 10><E025 1><E335>Ouais, <E049><E003 8>c'est ben vrai,<E049><E003 6><E025 2> elle l'est !<E049><E003 16>\r\n<E025 3>J'suis...<E049><E003 16><E025 2><E341> sûr qu'j'ai point d'quoi m'tracasser...");
                R(ref s, "Well in that case, <E049><E003 6><E025 2>do you think perhaps you could\r\nconcentrate on the testimony?",
                         "Eh bien dans ce cas, <E049><E003 6><E025 2>pourriez-vous faire l'effort de\r\nvous concentrer sur le témoignage ?");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#27"] = en => {
                string s = en;
                R(ref s, "Mr Vigil!<E049><E003 10> Is something wrong?",
                         "Monsieur Vigil !<E049><E003 10> Quelque chose ne va pas ?");
                R(ref s, "Oh no!<E049><E003 12>\r\nYou, <E049><E003 8><E330>you haven't lost your memory again, <E003 4>have you?",
                         "Oh non !<E049><E003 12>\r\nVous... <E049><E003 8><E330>vous n'avez tout de même pas encore perdu la mémoire ?");
                R(ref s, "No no, <E049><E003 6>not at all.<E049><E003 12> I was merely in a brown study.",
                         "Non non, <E049><E003 6>pas du tout.<E049><E003 12> J'étais simplement perdu dans mon cabinet d'étude.");
                R(ref s, "...You can think about how you want to decorate your\r\nhouse later.<E049><E003 10> <E025 3>For now, <E049><E003 6>please focus on the testimony.",
                         "... Vous réfléchirez à la décoration de votre intérieur plus tard.<E049><E003 10>\r\n<E025 3>Pour l'heure, <E049><E003 6>veuillez vous concentrer sur le témoignage.");
                R(ref s, "So sorry...",
                         "Toutes mes excuses...");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#28"] = en => {
                string s = en;
                R(ref s, "The tip of Karuma...<E003 10> <E025 2>So this is how it was broken.",
                         "La pointe de Karuma...<E003 10> <E025 2>C'est donc ainsi qu'elle a été brisée.");
                R(ref s, "Kazuma's swordsmanship is second to none.<E003 12>\r\n<E025 3>I can't believe he'd misjudge it like that.",
                         "Kazuma manie le sabre à la perfection.<E003 12>\r\n<E025 3>Je n'arrive pas à croire qu'il ait pu commettre une telle erreur d'appréciation.");
                R(ref s, "Clearly he wasn't in his right mind.",
                         "Il n'avait de toute évidence pas toute sa tête.");
                R(ref s, "He didn't have full control of the power in his stroke.<E003 12>\r\n<E025 2><E330>Too distracted by malicious thoughts, <E003 6>perhaps...",
                         "Il n'a pas su maîtriser la puissance de son coup.<E003 12>\r\n<E025 2><E330>Trop obnubilé par des pensées malveillantes, <E003 6>sans doute...");
                R(ref s, "Well, <E003 6><E025 2>that wouldn't be surprising.",
                         "Eh bien, <E003 6><E025 2>cela n'aurait rien de surprenant.");
                R(ref s, "After all...",
                         "Après tout...");
                R(ref s, "...he was on an assassination mission.",
                         "... il était en mission d'assassinat.");
                return s;
            };

            entryTranslators["BB\\script\\output\\_macro04_eng#29"] = en => {
                string s = en;
                R(ref s, "Karuma, <E003 8>the great blade...<E003 14>\r\n<E025 2>It's such a thing of beauty, <E003 6>I want to gaze on it for hours.",
                         "Karuma, <E003 8>la noble lame...<E003 14>\r\n<E025 2>Elle est d'une telle beauté que je pourrais la contempler des heures durant.");
                return s;
            };
        }
    }
}
