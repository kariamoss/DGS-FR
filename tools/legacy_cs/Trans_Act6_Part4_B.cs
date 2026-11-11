using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorAct6 {
    public partial class Program {
        public static void RegisterPart4_B() {
            entryTranslators[@"BB\script\output\_sce02_evidence_eng#37"] = (en) => {
                string s = en;
                s = s.Replace("Look, Mr Naruhodo...", "Regardez, Monsieur Naruhodo...");
                s = s.Replace("What is it?", "Qu'y a-t-il ?");
                s = s.Replace("On the bellows just here...there seem to be some very\r\ndark red stains.", "Sur le soufflet juste ici... il semble y avoir des taches\r\nrouge très sombre.");
                s = s.Replace("Yes, you're right...", "Oui, vous avez raison...");
                s = s.Replace("(It looks like blood actually...)", "(On dirait bien du sang, en vérité...)");
                s = s.Replace("Oh, oh my...", "Oh, grand dieu...");
                s = s.Replace("I'm, I'm sure it's not what you're thinking!\r\nHa ha ha...ha.", "Je, je suis certain que ce n'est pas ce que vous croyez !\r\nHa ha ha... ha.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#38"] = (en) => {
                string s = en;
                s = s.Replace("The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#39"] = (en) => {
                string s = en;
                s = s.Replace("The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#40"] = (en) => {
                string s = en;
                s = s.Replace("The details of the camera\r\nhave been updated in the Court Record.", "Les détails de l'appareil photo\r\nont été mis à jour dans le dossier.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#42"] = (en) => {
                string s = en;
                s = s.Replace("Oh look! The cover came open!", "Oh, regardez ! Le couvercle s'est ouvert !");
                s = s.Replace("Yes, now...there should be a glass plate inside.", "Oui, à présent... il devrait y avoir une plaque de verre à l'intérieur.");
                s = s.Replace("You have to change the plate with each new photograph\r\nyou want to take, you see.", "Il faut changer la plaque à chaque nouvelle photographie\r\nque l'on veut prendre, voyez-vous.");
                s = s.Replace("There is no plate.\r\nIt's been removed.", "Il n'y a pas de plaque.\r\nElle a été retirée.");
                s = s.Replace("Ah, what a pity.\r\nBut I suppose if you think about it...", "Ah, quel dommage.\r\nMais à la réflexion...");
                s = s.Replace("...this wouldn't be the actual camera that was used at the\r\ntime, just like the waxwork isn't the actual person.", "...ce ne doit pas être le véritable appareil utilisé à l'époque,\r\ntout comme la statue de cire n'est pas la personne vivante.");
                s = s.Replace("So we'd never have found a photographic print of the\r\nexecuted convict coming back to life anyway.", "Nous n'aurions donc de toute façon jamais trouvé de cliché\r\ndu condamné exécuté revenant à la vie.");
                s = s.Replace("Oh... Yes, you're quite right of course...", "Oh... Oui, vous avez tout à fait raison, bien sûr...");
                s = s.Replace("(Poor Susato-san. She looks devastated.)", "(Pauvre Mademoiselle Susato. Elle a l'air dévastée.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#43"] = (en) => {
                string s = en;
                s = s.Replace("This is where the photographic plate goes, I think, isn't it?", "C'est ici que vient la plaque photographique, si je ne m'abuse ?");
                s = s.Replace("Yes, that's right. Isn't it incredible to think that this is the\r\nactual camera Mr Drebber used that night?", "Oui, c'est exact. N'est-ce pas incroyable de songer que c'est le\r\nvéritable appareil que M. Drebber a utilisé cette nuit-là ?");
                s = s.Replace("I certainly never imagined a piece of evidence would be\r\non display in Madame Tusspells!", "Je n'aurais jamais imaginé qu'une pièce à conviction se trouverait\r\nexposée chez Madame Pétrie !");
                s = s.Replace("She's very keen on everything being as true to life as\r\npossible though, isn't she?", "Elle tient tellement à ce que tout soit aussi fidèle que\r\npossible à la réalité, n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#44"] = (en) => {
                string s = en;
                s = s.Replace("There's a little metal plaque here, look.", "Il y a une petite plaque de métal ici, regardez.");
                s = s.Replace("‘Fostering burgeoning talent for the future of scientific\r\ndiscovery’.", "« Encourager les jeunes talents pour l'avenir de la découverte\r\nscientifique ».");
                s = s.Replace("...It seems rather ironic, doesn't it?", "...C'est plutôt ironique, non ?");
                s = s.Replace("But clearly Mr Drebber really was a very talented\r\nscientist.", "Mais de toute évidence, M. Drebber était un scientifique\r\nvéritablement doué.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_evidence_eng#45"] = (en) => {
                string s = en;
                s = s.Replace("This lock does look very strong, doesn't it?", "Ce verrou a l'air très solide, pas vrai ?");
                s = s.Replace("There's definitely no way you could remove the mask\r\nyourself if it was put on you.", "Il est absolument impossible d'enlever le masque soi-même\r\nsi on vous le mettait sur la tête.");
                s = s.Replace("What a terrible way to treat someone, even a convicted\r\ncriminal.", "Quelle manière atroce de traiter quelqu'un, même un criminel\r\ncondamné.");
                s = s.Replace("I know. It's starting to make me livid, actually.", "Je sais. Cela commence vraiment à me mettre hors de moi.");
                s = s.Replace("Mr Naruhodo, please...", "Monsieur Naruhodo, je vous en prie...");
                s = s.Replace("I mean, just think about it!", "Non mais pensez-y un instant !");
                s = s.Replace("Imagine if you had an itch on your cheek all of a sudden!\r\nYou'd be utterly helpless!", "Imaginez que votre joue vous démange tout d'un coup !\r\nVous seriez totalement démuni !");
                s = s.Replace("Well, yes, that's true.", "Eh bien, oui, c'est vrai.");
                s = s.Replace("But I'm not sure...that warrants quite so much anger.", "Mais je ne suis pas sûre... que cela justifie une telle colère.");
                s = s.Replace("Oh...right...\r\nSorry.", "Oh... évidemment...\r\nDésolé.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#13"] = (en) => {
                string s = en;
                s = s.Replace("Guilty!", "Coupable !");
                s = s.Replace("Mr Albert Harebrayne, in accordance with the findings of\r\nthis court, I pronounce you...", "Professeur Samba Lonron, conformément aux conclusions de\r\ncette cour, je vous déclare...");
                s = s.Replace("I applaud the jurors for doing their civic duty and for\r\nfinding a swift resolution to this matter.", "Je félicite les jurés d'avoir accompli leur devoir civique et d'avoir\r\ntrouvé une issue rapide à cette affaire.");
                s = s.Replace("That is all. Court is adjourned!", "C'est tout. La séance est levée !");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#14"] = (en) => {
                string s = en;
                s = s.Replace("That last statement would seem to be at odds somehow\r\nwith the evidence!", "Cette dernière déclaration semble être en contradiction flagrante\r\navec les preuves !");
                s = s.Replace("It is your task, Counsel, to explain the ‘somehows’ to the\r\ncourt, not the other way around.", "C'est votre rôle, Maître, d'expliquer ces contradictions à la\r\ncour, et non l'inverse.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#15"] = (en) => {
                string s = en;
                s = s.Replace("...It just seems to jar, though.\r\nDon't you think?", "...Cela semble pourtant discordant.\r\nVous ne trouvez pas ?");
                s = s.Replace("What I think, is that this whole exchange has been\r\nextremely jarring, yes.", "Ce que je trouve, c'est que tout cet échange a été\r\nparticulièrement discordant, oui.");
                s = s.Replace("(Perhaps I need to reconsider this...)", "(Je devrais sans doute revoir ma copie...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#16"] = (en) => {
                string s = en;
                s = s.Replace("The defence would have to object to that last statement,\r\nMy Lord!", "La défense doit s'opposer formellement à cette dernière déposition,\r\nVotre Honneur !");
                s = s.Replace("And I would have to overrule your objection, Counsel.", "Et je me vois contraint de rejeter votre objection, Maître.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#17"] = (en) => {
                string s = en;
                s = s.Replace("The defence...would have to accept the penalty given.", "La défense... se doit d'accepter la sanction infligée.");
                s = s.Replace("Glad to hear it.\r\nAnd you would also have to think again, hm?", "Ravi de l'entendre.\r\nEt vous feriez bien d'y réfléchir à deux fois, n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#18"] = (en) => {
                string s = en;
                s = s.Replace("Surely something about that last statement seems odd,\r\ndoesn't it?", "Il y a assurément quelque chose qui cloche dans cette déclaration,\r\nvous ne trouvez pas ?");
                s = s.Replace("Would you care to mull over precisely what you find odd\r\nabout it on your return journey to Japan?", "Souhaitez-vous méditer sur ce qui cloche exactement\r\nlors de votre voyage de retour vers le Japon ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#19"] = (en) => {
                string s = en;
                s = s.Replace("...I wouldn't be back to give the court an answer for about\r\nfour months, though.", "...Mais je mettrais bien quatre mois avant de pouvoir apporter\r\nune réponse à la cour.");
                s = s.Replace("Rest assured, we should be happy to carry proceedings\r\nforward in your absence, Counsel.", "Soyez rassuré, nous nous ferons un plaisir de poursuivre les débats\r\nen votre absence, Maître.");
                s = s.Replace("(He sounds serious! I have to prove my worth before he\r\nreally does send me back home!)", "(Il a l'air sérieux ! Je dois faire mes preuves avant qu'il ne me\r\nrenvoie pour de bon au Japon !)");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#20"] = (en) => {
                string s = en;
                s = s.Replace("Those two statements are fundamentally at odds with one\r\nanother!", "Ces deux déclarations sont en totale contradiction l'une avec\r\nl'autre !");
                s = s.Replace("Well, Mr Foreman?", "Alors, Monsieur le Premier juré ?");
                s = s.Replace("...Ah, there's to be a new Herlock Sholmes adventure\r\npublished next month, by the looks...", "...Ah, on dirait bien qu'une nouvelle aventure de Sherlock Holmes\r\nva être publiée le mois prochain...");
                s = s.Replace("My, My Lord!\r\nThe foreman of the jury isn't listening!", "V-Votre Honneur !\r\nLe premier juré n'écoute pas un traître mot !");
                s = s.Replace("Is that so? Well, I shall have to reserve myself a copy at\r\nthe local newsagent, in that case.", "Vraiment ? Eh bien, il faudra que j'en réserve un exemplaire chez\r\nle marchand de journaux, dans ce cas.");
                s = s.Replace("Miss Susato, no one is listening to what I'm saying...", "Mademoiselle Susato, personne n'écoute ce que je raconte...");
                s = s.Replace("Perhaps this would be a good opportunity to have a\r\nrethink then, Mr Naruhodo?", "Peut-être est-ce une bonne occasion pour vous de réfléchir\r\nà nouveau, Monsieur Naruhodo ?");
                s = s.Replace("Fear not, my learned friend.\r\nI heard every sorry word.", "Ne crains rien, mon docte confrère.\r\nJ'ai entendu le moindre de tes piètres propos.");
                return s;
            };

            entryTranslators[@"BB\script\output\_macro02_eng#21"] = (en) => {
                string s = en;
                s = s.Replace("(Ugh... It sounds like I'm on the wrong track here.\r\nI'd better think again.)", "(Argh... On dirait que je fais fausse route.\r\nJe ferais mieux de revoir ma copie.)");
                return s;
            };

        }
    }
}
