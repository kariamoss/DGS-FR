using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorEp4Act2 {
    public partial class Program {
        public static void RegisterPart4() {
            entryTranslators[@"BB\script\output\_sce03_chr106_01_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("That's not my fault!", "Ce n'est pas ma faute !");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("(That made me jump.)", "(Elle m'a fait sursauter.)");
                s = s.Replace("Then please!", "Alors de grâce !");
                s = s.Replace("Tell us what happened!", "Dites-nous ce qui s'est passé !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr106_01_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("About this photograph, Dr Gorey...", "À propos de cette photographie, Mademoiselle Pétrie...");
                s = s.Replace("Who's that?", "Qui est-ce ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("It's, it's Inspector Gregson, of course!", "C'est... c'est l'inspecteur Gregson, bien sûr !");
                s = s.Replace("The victim of the case!", "La victime dans cette affaire !");
                s = s.Replace("Ah, I see. I don't remember the faces.", "Ah, je vois. Je ne me rappelle pas des visages.");
                s = s.Replace("Internal organs, muscle tissue, bullet trauma...", "Les organes internes, les tissus musculaires, les plaies par balle...");
                s = s.Replace("Those are things I remember.", "C'est cela dont je me souviens.");
                s = s.Replace("Well...please try to also remember that I don't want to\r\nknow anything about all of that.", "Eh bien... tâchez de vous rappeler aussi que je préfère\r\nn'en rien savoir du tout.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr106_01_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("I don't know why...", "Je ne sais pas pourquoi...");
                s = s.Replace("Don't know why what?", "Pourquoi quoi ?");
                s = s.Replace("Why I couldn't write a time of death on that report.", "Pourquoi je n'ai pas pu noter l'heure du décès sur ce rapport.");
                s = s.Replace("It's just...", "C'est juste que...");
                s = s.Replace("the Lord Chief Justice was so insistent.", "le Lord Primat de la Justice s'est montré si insistant.");
                s = s.Replace("I couldn't bring myself to defy him.", "Je n'ai pas eu le cran de lui désobéir.");
                s = s.Replace("just like Mama.", "tout comme Maman.");
                s = s.Replace("(It looks like she's as troubled by all of this as we are, in\r\nher own way.)", "(On dirait que toute cette histoire la tourmente tout autant que nous,\r\nà sa manière.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr106_01_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("The Professor's execution was Mama's first big case.", "L'exécution du Démon Assassin était la première grande affaire de Maman.");
                s = s.Replace("She had to be in attendance at Barclay Prison's execution\r\nchamber...", "Elle devait être présente dans la chambre d'exécution de la prison de Barclay...");
                s = s.Replace("...and sign the certificate to confirm the convict's death.", "... et signer le certificat attestant de la mort du condamné.");
                s = s.Replace("Mama is the best coroner in the world, you know.", "Maman est le meilleur médecin légiste du monde, vous savez.");
                s = s.Replace("I was...", "J'étais...");
                s = s.Replace("so proud of her.", "si fière d'elle.");
                s = s.Replace("But the execution didn't actually take place.", "Mais l'exécution n'a pas réellement eu lieu.");
                s = s.Replace("No. And worse still, Mama actually helped with the\r\njailbreak.", "Non. Et pire encore, Maman a en réalité participé à l'évasion.");
                s = s.Replace("...I didn't want to know.", "... Je ne voulais pas le savoir.");
                s = s.Replace("Oh dear... You found out recently, you mean?", "Grand Dieu... Vous voulez dire que vous l'avez appris récemment ?");
                s = s.Replace("I believed in her. In Mama.\r\nBut...", "J'avais confiance en elle. En Maman.\r\nMais...");
                s = s.Replace("...now I wonder if I'm starting down the same path as her.", "... à présent je me demande si je ne glisse pas sur la même pente qu'elle.");
                s = s.Replace("You mean, because you omitted the time of death on this\r\nautopsy report?", "Vous voulez dire, parce que vous avez omis l'heure du décès sur ce\r\nrapport d'autopsie ?");
                s = s.Replace("But that's because Lord Stronghart forbade you from\r\nincluding it.", "Mais c'est parce que Lord Caine vous avait expressément interdit de\r\nl'indiquer.");
                s = s.Replace("...Just like Mama.\r\nI'm sure she was coerced by somebody, too.", "... Tout comme Maman.\r\nJe suis sûre qu'on a fait pression sur elle aussi.");
                s = s.Replace("Yes, that's my feeling as well.", "Oui, c'est également mon sentiment.");
                s = s.Replace("There's no doubt that there were powerful forces at play\r\nten years ago.", "Il ne fait aucun doute que de puissantes forces étaient à l'œuvre\r\nil y a dix ans.");
                s = s.Replace("The execution couldn't have been staged without a lot of\r\npeople at the prison knowing about it.", "L'exécution n'aurait jamais pu être simulée sans que de nombreuses\r\npersonnes à la prison soient dans la confidence.");
                s = s.Replace("Obviously the prison governor must have been in on it as\r\nwell.", "De toute évidence, le gouverneur de la prison devait tremper dedans\r\nlui aussi.");
                s = s.Replace("The big man with the little handcuffs?\r\nAccording to what he told us...", "Le grand monsieur avec les petites menottes ?\r\nD'après ce qu'il nous a dit...");
                s = s.Replace("...he was tricked by the chief warder.\r\nHe says he knew nothing about it.", "... il s'est fait berner par le gardien-chef.\r\nIl affirme qu'il n'en savait rien.");
                s = s.Replace("Of course he said that.\r\nI'd say the same thing.", "Évidemment qu'il a dit ça.\r\nJ'en aurais fait autant.");
                s = s.Replace("(Just who was behind that jailbreak all those years ago?)", "(Mais qui donc se cachait derrière cette évasion il y a dix ans ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr106_01_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("You mentioned the autopsy of Klint van Zieks...", "Vous avez mentionné l'autopsie de Klimt Van Peers...");
                s = s.Replace("It was at a time when carrying out autopsies of murder\r\nvictims was very unusual.", "C'était à une époque où pratiquer une autopsie sur les victimes de\r\nmeurtre était très inhabituel.");
                s = s.Replace("It's still not a practice that's observed in our country, even\r\nnow.", "Ce n'est toujours pas une pratique courante dans notre pays, même\r\nà l'heure actuelle.");
                s = s.Replace("It turned out that he was the Professor's final victim.\r\nAnd when the autopsy was performed...", "Il s'est avéré qu'il était la dernière victime du Démon Assassin.\r\nEt lorsque l'autopsie a été pratiquée...");
                s = s.Replace("...Mama was present...although only as the secondary\r\nassistant.", "... Maman était présente... mais seulement comme seconde\r\nassistante.");
                s = s.Replace("The person leading the procedure was called Dr John H.\r\nWilson.", "Le responsable qui dirigeait la procédure s'appelait le Dr John H.\r\nWilson.");
                s = s.Replace("That's right. My daddy!", "C'est exact. Mon papa !");
                s = s.Replace("And there was one other person present: the primary\r\nassistant.", "Et il y avait une autre personne présente : le premier\r\nassistant.");
                s = s.Replace("He was a visiting student from the Far East.", "C'était un étudiant stagiaire venu d'Extrême-Orient.");
                s = s.Replace("Wait...a visiting student?!", "Attendez... un étudiant étranger ?!");
                s = s.Replace("It must have been my father...Yujin Mikotoba.", "Ce devait être mon père... Yujin Mikotoba.");
                s = s.Replace("(I had no idea Professor Mikotoba had been involved in\r\nsomething so important!)", "(Je n'avais pas la moindre idée que le professeur Mikotoba avait été mêlé\r\nà quelque chose d'aussi crucial !)");
                s = s.Replace("But the outcome of that historic autopsy...", "Mais le résultat de cette autopsie historique...");
                s = s.Replace("...was the discovery of a vital piece of evidence that led to\r\nthe capture of the Professor!", "... fut la découverte d'une preuve capitale qui permit la\r\ncapture du Démon Assassin !");
                s = s.Replace("(So that's how they came to identify Genshin Asogi as the\r\ninfamous mass murderer...)", "(C'est donc ainsi qu'ils ont identifié Genshin Asogi comme étant ce\r\nsanguinaire meurtrier en série...)");
                s = s.Replace("Do you happen to know anything about that piece of\r\nevidence? Can you tell us any more?", "Savez-vous quoi que ce soit sur cette pièce à conviction ? Pouvez-vous\r\nnous en dire davantage ?");
                s = s.Replace("Would you like to see the records for yourself?", "Voudriez-vous consulter les dossiers par vous-même ?");
                s = s.Replace("Wha... Would, would that be alright?", "Qu... Serait-ce... vraiment permis ?");
                s = s.Replace("What's the point of keeping records if people can't look at\r\nthem?", "À quoi bon garder des archives si personne ne peut les regarder ?");
                s = s.Replace("They're filed under ‘V’ at the back of those cupboards.\r\nWith the other records from the last decade.", "Ils sont classés sous la lettre « V » au fond de ces armoires.\r\nAvec les autres dossiers de la dernière décennie.");
                s = s.Replace("Thank you!", "Merci !");
                s = s.Replace("(Let's see... Van Zieks...\r\nVan Zieks...)", "(Voyons voir... Van Peers...\r\nVan Peers...)");
                s = s.Replace("Um...that's strange.", "Euh... c'est étrange.");
                s = s.Replace("What, Mr Naruhodo?", "Qu'y a-t-il, monsieur Naruhodo ?");
                s = s.Replace("They...aren't here.\r\nThere's nothing under ‘van Zieks’.", "Ils... ne sont pas là.\r\nIl n'y a rien sous « Van Peers ».");
                s = s.Replace("There must be!", "C'est impossible !");
                s = s.Replace("Perhaps somebody took them away?", "Quelqu'un les aurait-il emportés ?");
                s = s.Replace("No. No one's allowed to take documents related to the\r\nProfessor case out of this room.", "Non. Personne n'a le droit de sortir de cette pièce des documents\r\nliés à l'affaire du Démon Assassin.");
                s = s.Replace("...But you're right. They're gone!", "... Mais vous avez raison. Ils ont disparu !");
                s = s.Replace("Well, when was the last time somebody looked at them?\r\nDo you remember?", "Eh bien, à quand remonte la dernière consultation ?\r\nVous en souvenez-vous ?");
                s = s.Replace("It was... Oh yes, I remember now!\r\nIt was two years ago.", "C'était... Oh oui, je m'en rappelle à présent !\r\nC'était il y a deux ans.");
                s = s.Replace("A ‘consulting detective’ came one day saying that he'd like\r\nto see the records.", "Un « détective consultant » est venu un jour en disant qu'il\r\nsouhaitait examiner les dossiers.");
                s = s.Replace("No...\r\nYou, you don't mean...?", "Non...\r\nVous... vous ne voulez pas dire... ?");
                s = s.Replace("Herlock Sholmes was his name.", "Herlock Sholmes, tel était son nom.");
                s = s.Replace("(Deep down, I knew that was coming.)", "(Au fond de moi, je sentais venir le coup.)");
                s = s.Replace("Do you think...he stole the records?", "Pensez-vous... qu'il ait volé les dossiers ?");
                s = s.Replace("Oh no, surely not! Iris, that can't be right...can it?", "Oh non, sûrement pas ! Iris, ce n'est pas possible... n'est-ce pas ?");
                s = s.Replace("I-Iris?", "I-Iris ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("It's getting on for a year now.\r\nSince what happened on the SS Burya.", "Cela va bientôt faire un an.\r\nDepuis ce qui s'est produit sur le SS Burya.");
                s = s.Replace("(We were heading across the oceans from Japan to Great\r\nBritain...)", "(Nous traversions les mers depuis le Japon vers la\r\nGrande-Bretagne...)");
                s = s.Replace("(...when a bizarre serious of coincidences led to those\r\ntragic events.)", "(... lorsqu'un funeste concours de circonstances a conduit à ce\r\ntragique dénouement.)");
                s = s.Replace("I thought...I'd lost my best friend forever.", "Je croyais... avoir perdu mon meilleur ami à jamais.");
                s = s.Replace("...I must have been unconscious for a long time.\r\nWhen I awoke, I was lying on a bed.", "... J'ai dû rester inconscient un long moment.\r\nÀ mon réveil, j'étais étendu sur un lit.");
                s = s.Replace("It was a narrow little room. There was a posy of flowers\r\nby the pillow.", "C'était une petite pièce étroite. Il y avait un bouquet de fleurs\r\nprès de l'oreiller.");
                s = s.Replace("It took me a little while to realise that I was in the cabin of\r\na ship.", "Il m'a fallu un instant pour comprendre que j'étais dans la cabine\r\nd'un navire.");
                s = s.Replace("I slipped out of the room and headed up onto the deck.", "Je me suis glissé hors de la pièce pour monter sur le pont.");
                s = s.Replace("Were you already suffering from amnesia at that point?", "Étais-tu déjà amnésique à ce moment-là ?");
                s = s.Replace("Yes. I didn't know what had happened or where I was.\r\nThere was just this voice in my head.", "Oui. J'ignorais ce qui s'était passé et où je me trouvais.\r\nIl n'y avait que cette voix dans ma tête.");
                s = s.Replace("You have something you have to do.\r\nSomething no one else can know about.", "Tu as un devoir à accomplir.\r\nQuelque chose que personne d'autre ne doit savoir.");
                s = s.Replace("Go to Great Britain.\r\nYour task awaits you there...", "Rends-toi en Grande-Bretagne.\r\nTa tâche t'attend là-bas...");
                s = s.Replace("It was a calling I couldn't ignore.\r\nIt compelled me relentlessly.", "C'était un appel impérieux que je ne pouvais ignorer.\r\nIl me poussait sans répit.");
                s = s.Replace("Out on deck, I saw that I was on a huge steamship and we\r\nwere docked in a large port.", "Sur le pont, j'ai vu que je me trouvais à bord d'un immense paquebot\r\net que nous étions amarrés dans un grand port.");
                s = s.Replace("It must have been Hong Kong!", "Ce devait être Hong Kong !");
                s = s.Replace("Yes, it must have been. Presumably just before they were\r\ndue to carry your ‘body’ off the ship.", "Oui, très certainement. Juste avant qu'ils ne débarquent ton\r\n« corps » du navire.");
                s = s.Replace("I had no idea of the situation. But I did have the feeling\r\nthat this was in some way my last chance.", "J'ignorais tout de la situation. Mais j'avais le pressentiment\r\nqu'il s'agissait là de ma dernière chance.");
                s = s.Replace("So I concealed myself among the disembarking passengers\r\nand went ashore.", "Je me suis donc mêlé aux passagers qui débarquaient\r\npour descendre à terre.");
                s = s.Replace("Then I disappeared into the crowded streets of that \r\nforeign port city...", "Puis j'ai disparu dans les rues bondées de cette ville portuaire\r\nétrangère...");
                s = s.Replace("...so I could plan my onward journey to Great Britain.", "... afin d'organiser la suite de mon voyage vers la Grande-Bretagne.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Just under a year ago, with all my past memories lost to\r\nme, I was left behind in Hong Kong.", "Il y a un peu moins d'un an, privé de tous mes souvenirs,\r\nje me suis retrouvé abandonné à Hong Kong.");
                s = s.Replace("Everything was foreign to me. The sights, the sounds, the\r\nsmells. My head reeled. I was truly at a loss.", "Tout m'était inconnu. Les paysages, les bruits, les\r\nodeurs. La tête me tournait. J'étais totalement perdu.");
                s = s.Replace("I realise now that I'd escaped as a dead man. With nothing\r\nbut the clothes on my back. No money, of course.", "Je réalise à présent que je m'étais échappé comme un fantôme.\r\nSans rien d'autre que les vêtements que je portais. Sans le sou, bien sûr.");
                s = s.Replace("Oh, how terrifying for you...", "Oh, quelle angoisse cela a dû être pour vous...");
                s = s.Replace("Luckily though, I had two feathers in my cap.", "Fort heureusement, j'avais deux cartes maîtresses dans mon jeu.");
                s = s.Replace("One being your knowledge of English, I suppose?", "La première étant ta maîtrise de l'anglais, je présume ?");
                s = s.Replace("That's right. And on the back of that, I was able to pick up\r\nsome work as a deck hand on a cargo ship.", "Exactement. Grâce à cela, j'ai pu me faire engager comme matelot\r\nsur un cargo.");
                s = s.Replace("Eventually, after calling at countless ports, I finally\r\narrived at Dover.", "Au bout du compte, après d'innombrables escales,\r\nj'ai enfin accosté à Douvres.");
                s = s.Replace("That must have been some three months ago now.", "Cela doit faire environ trois mois de cela.");
                s = s.Replace("...Your formidable tenacity of purpose showing itself\r\nagain.", "... Ta prodigieuse ténacité s'est manifestée une nouvelle fois.");
                s = s.Replace("(I mean, the man had lost his memory and had literally\r\nnothing to his name...)", "(Je veux dire, cet homme avait perdu la mémoire et ne possédait\r\nstrictement rien au monde...)");
                s = s.Replace("(...but he still managed to make his way to London on the\r\nopposite side of the world.)", "(... et il a quand même réussi à rallier Londres à l'autre bout de la Terre.)");
                s = s.Replace("Of course, I had no idea why I'd moved heaven and earth\r\nto get here at that point.", "Évidemment, j'ignorais complètement à ce moment-là pourquoi j'avais\r\nremué ciel et terre pour venir jusqu'ici.");
                s = s.Replace("So...how did you end up becoming Lord van Zieks's\r\napprentice, then?", "Alors... comment es-tu devenu le disciple de Lord Van Peers,\r\ndans ce cas ?");
                s = s.Replace("That...can only be called an extraordinary stroke of luck\r\nreally.", "Cela... ne peut être qualifié que d'extraordinaire coup de chance,\r\nà vrai dire.");
                s = s.Replace("You see, I was stopped at the border because I had no\r\npapers.", "Voyez-vous, j'ai été retenu à la frontière faute de papiers.");
                s = s.Replace("They took me straight to Scotland Yard.", "Ils m'ont conduit directement à Scotland Yard.");
                s = s.Replace("And by sheer coincidence, Lord Stronghart was there to\r\nattend a meeting.", "Et par un pur hasard, Lord Caine s'y trouvait justement pour une réunion.");
                s = s.Replace("That's when the second feather in my cap came into play.", "C'est alors que mon second atout est entré en scène.");
                s = s.Replace("Would that have been your knowledge of the law?", "Serait-ce votre connaissance du droit ?");
                s = s.Replace("Yes, exactly.\r\nLord Stronghart was curious about an Easterner with\r\nintimate knowledge of British law.", "Oui, précisément.\r\nLord Caine était intrigué par un oriental maîtrisant sur le bout des\r\ndoigts les lois britanniques.");
                s = s.Replace("He took me back with him to the Supreme Court and\r\nassigned me to the Prosecutor's Office.", "Il m'a ramené avec lui à la Cour suprême et m'a assigné\r\nau bureau du procureur.");
                s = s.Replace("And then, nine days ago...", "Et ensuite, il y a neuf jours de cela...");
                s = s.Replace("...you finally got your memory back after the trial\r\ninvolving Drebber.", "... tu as enfin recouvré la mémoire après le procès impliquant\r\nDrebber.");
                s = s.Replace("Yes...I did.", "Oui... c'est bien cela.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Ever since I first met you at Yumei, you talked about\r\nyour dream.", "Depuis notre première rencontre à Yumei, tu me parlais\r\nde ton grand rêve.");
                s = s.Replace("Mark my words, Ryunosuke. I'll be chosen as a visiting\r\nstudent, and make my way to Great Britain someday.", "Retiens bien mes paroles, Ryunosuke. Je serai choisi comme étudiant\r\nétranger et je foulerai le sol de Grande-Bretagne un jour.");
                s = s.Replace("Did you know the entire time?\r\nAbout what happened to your father here?", "Savais-tu depuis le début ?\r\nCe qui était arrivé à ton père ici ?");
                s = s.Replace("Sixteen years ago...", "Il y a seize ans de cela...");
                s = s.Replace("...when my father left on that exciting trip to Great\r\nBritain, I was just a boy.", "... lorsque mon père est parti pour ce voyage mémorable en Grande-Bretagne,\r\nje n'étais qu'un petit garçon.");
                s = s.Replace("We took a photograph together the day before his\r\ndeparture. ...It's my last memory of him.", "Nous avons pris une photo ensemble la veille de son départ.\r\n... C'est mon dernier souvenir de lui.");
                s = s.Replace("But what I remember most about my father...is his\r\nunswerving sense of justice.", "Mais ce qui m'a le plus marqué chez mon père...\r\nc'est son sens inébranlable de la justice.");
                s = s.Replace("Six years after he left, a gentleman called at our family\r\nhome.", "Six ans après son départ, un monsieur s'est présenté à notre domicile.");
                s = s.Replace("He told me that Genshin – my father – had been taken\r\nill in England and passed away.", "Il m'a annoncé que Genshin — mon père — était tombé gravement\r\nmalade en Angleterre et s'était éteint.");
                s = s.Replace("It was Professor Mikotoba.\r\nYour father, Susato-san.", "C'était le professeur Mikotoba.\r\nVotre père, mademoiselle Susato.");
                s = s.Replace("Oh my!", "Ciel !");
                s = s.Replace("Ever since then, the professor was very good to me.", "Depuis ce jour-là, le professeur a toujours été très bon envers moi.");
                s = s.Replace("He even helped to fund my university education at\r\nYumei. I'll be forever in his debt.", "Il a même contribué à financer mes études universitaires à Yumei.\r\nJe lui en serai éternellement reconnaissant.");
                s = s.Replace("But nevertheless...I just couldn't bring myself to believe\r\nwhat he'd told me.", "Mais pourtant... je ne parvenais pas à me résoudre à croire\r\nce qu'il m'avait raconté.");
                s = s.Replace("Oh...", "Oh...");
                s = s.Replace("Then one day, a letter arrived at our house from Britain.", "Puis un jour, une lettre en provenance de Grande-Bretagne est arrivée chez nous.");
                s = s.Replace("There was no indication of the sender, so I opened it\r\nassuming it was from an old acquaintance of my father.", "Il n'y avait aucun nom d'expéditeur, je l'ai donc ouverte en pensant\r\nqu'elle venait d'une vieille connaissance de mon père.");
                s = s.Replace("What I read in that letter changed my entire life.", "Ce que j'ai lu dans cette lettre a bouleversé ma vie tout entière.");
                s = s.Replace("What did it say?", "Que disait-elle ?");
                s = s.Replace("It said that my father had been a mass murderer, and the\r\nwriter cursed the Asogi name.", "Elle affirmait que mon père avait été un tueur sanguinaire, et l'auteur\r\ny maudissait le nom des Asogi.");
                s = s.Replace("Oh no!", "Grand Dieu !");
                s = s.Replace("As a result of that letter, I found out what had been\r\nhidden from me all those years.", "À la suite de cette lettre, j'ai découvert ce qu'on m'avait caché\r\npendant toutes ces années.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Presumably the letter was sent from a relative of one of\r\nthe victims.", "Vraisemblablement, la lettre provenait d'un proche de l'une des\r\nvictimes.");
                s = s.Replace("If whoever it was had been a member of the judiciary, he\r\ncould have been present at the closed trial.", "Si cet individu appartenait au corps judiciaire, il avait très bien\r\npu assister au procès à huis clos.");
                s = s.Replace("The letter revealed that my father had been sentenced to\r\ndeath. Executed for being a killer.", "La lettre révélait que mon père avait été condamné à mort.\r\nExécuté comme un vulgaire meurtrier.");
                s = s.Replace("I'm, I'm so sorry you had to find out that way...", "Je... je suis tellement navré que tu aies dû l'apprendre ainsi...");
                s = s.Replace("I imagine the British government did its very best to\r\nsilence whoever sent that letter.", "J'imagine que le gouvernement britannique a tout fait pour museler\r\nl'auteur de cette lettre.");
                s = s.Replace("But someone who knew the truth and couldn't bear the\r\nresentment was always going to be a problem.", "Mais quelqu'un qui connaissait la vérité et ne pouvait contenir sa\r\nrancœur finirait toujours par poser problème.");
                s = s.Replace("But still! It, it could have been written by anyone.\r\nWhy would you believe such a thing?", "Mais tout de même ! N'importe qui aurait pu l'écrire !\r\nPourquoi accorder foi à une telle abomination ?");
                s = s.Replace("There was a newspaper cutting included with the letter.", "Une coupure de journal était jointe à la lettre.");
                s = s.Replace("It was the first I'd ever heard of the Professor and his\r\nterrible killing spree.", "C'était la première fois que j'entendais parler du Démon Assassin\r\net de ses sinistres méfaits.");
                s = s.Replace("Well...what did my father have to say about the letter?", "Mais... qu'a dit mon père au sujet de cette lettre ?");
                s = s.Replace("...I couldn't bring myself to show it to him.", "... Je n'ai pas eu le cœur de la lui montrer.");
                s = s.Replace("What? Why not?", "Quoi ? Et pourquoi donc ?");
                s = s.Replace("Because he'd deliberately concealed the truth from me\r\nby telling me my father was taken by a fatal illness.", "Parce qu'il m'avait sciemment caché la vérité en prétendant\r\nque mon père avait été emporté par la maladie.");
                s = s.Replace("That couldn't have been easy for him. And he'd done it\r\nout of consideration for my feelings.", "Cela n'avait pas dû être facile pour lui. Et il l'avait fait par\r\népure délicatesse pour mes sentiments.");
                s = s.Replace("So instead...I showed the letter to Judge Jigoku.", "Alors au lieu de cela... j'ai montré la lettre au juge Jigoku.");
                s = s.Replace("Ah, to the other visiting student...", "Ah, à l'autre étudiant envoyé en Angleterre...");
                s = s.Replace("He faltered for the briefest of moments, but then he just\r\nlaughed the letter off.", "Il a flanché l'espace d'une fraction de seconde, puis il a balayé\r\nla lettre d'un rire nerveux.");
                s = s.Replace("But in that moment, I saw it on his face.\r\nHe was undeniably shocked. Shaken momentarily,\r\nbefore recovering his poise.", "Mais à cet instant précis, je l'ai lu sur son visage.\r\nIl était incontestablement sous le choc. Ébranlé un instant,\r\navant de retrouver toute sa contenance.");
                s = s.Replace("A year later, my bereaved mother succumbed to the\r\nstrain of grief, and she too passed away.", "Un an plus tard, ma mère accablée de chagrin a succombé à la douleur,\r\net elle s'est éteinte à son tour.");
                s = s.Replace("That's when I made up my mind.\r\nThat one day...without fail...\r\n...I would cross the seas to Britain and seek the truth for\r\nmyself.", "C'est alors que ma résolution a été prise.\r\nQu'un jour... coûte que coûte...\r\n... je franchirais les mers vers la Grande-Bretagne pour chercher la\r\nvérité par moi-même.");
                s = s.Replace("The truth about my father, Genshin Asogi.\r\nAnd I wouldn't let anyone stand in my way!", "La vérité sur mon père, Genshin Asogi.\r\nEt je ne laisserais personne se dresser sur ma route !");
                s = s.Replace("Oh, Kazuma-sama...", "Oh, monsieur Kiyô...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("What we learnt today in court turned things completely\r\non their head.", "Ce que nous avons appris aujourd'hui à l'audience a totalement\r\nbouleversé la situation.");
                s = s.Replace("It was an impressive piece of lawyering...Ryunosuke\r\nNaruhodo.", "C'était une impressionnante plaidoirie... Ryunosuke\r\nNaruhodo.");
                s = s.Replace("Lord van Zieks isn't the Reaper, you know.", "Lord Van Peers n'est pas le Faucheur, tu sais.");
                s = s.Replace("I almost don't want to believe it myself, but it turns out\r\nthat Inspector Gregson himself, the victim, was...", "J'ai moi-même peine à y croire, mais il s'avère\r\nque l'inspecteur Gregson lui-même, la victime, était...");
                s = s.Replace("It's clear that the inspector was behind the Reaper's\r\nactivity all along.", "Il est clair que l'inspecteur tirait les ficelles du Faucheur\r\ndepuis le départ.");
                s = s.Replace("Wha...?\r\n(You mean, you knew?!)", "Quoi... ?\r\n(Tu veux dire que... tu le savais ?!)");
                s = s.Replace("The real question is, who's been giving orders to the\r\ninspector?", "La véritable question est : qui a donné les ordres à\r\nl'inspecteur ?");
                s = s.Replace("Yes, Barok van Zieks is the real Reaper.", "Oui, Drake Van Peers est le véritable Faucheur.");
                s = s.Replace("And I know that ten years ago, it was him...", "Et je sais qu'il y a dix ans, c'est lui...");
                s = s.Replace("...who decided my father must be a mass murderer and\r\nsent him to his grave!", "... qui a décrété que mon père était un assassin sanguinaire\r\net qui l'a expédié dans la tombe !");
                s = s.Replace("No! He was merely seeing that justice was done as the\r\nlaw dictates. He's not to blame.", "Non ! Il veillait simplement à ce que justice soit rendue conformément\r\nà la loi. Il n'est pas responsable.");
                s = s.Replace("Ultimately, it's people who condemn people.\r\nThe law is just a tool that they use to do it.", "En définitive, ce sont les hommes qui condamnent les hommes.\r\nLa loi n'est qu'un instrument dont ils usent à cet effet.");
                s = s.Replace("And when a man condemns another, he must take\r\nresponsibility for his actions. Of course he must.", "Et quand un homme en condamne un autre, il doit assumer\r\npleinement ses actes. C'est indéniable.");
                s = s.Replace("But I know for certain...that my father would never have\r\ntaken another man's life.", "Mais je sais avec certitude... que mon père n'aurait jamais ôté\r\nla vie d'un autre homme.");
                s = s.Replace("Kazuma...", "Kazuma...");
                s = s.Replace("On the contrary, my father's life was taken...\r\nby the Reaper!", "Bien au contraire, c'est la vie de mon père qui a été ravie...\r\npar le Faucheur !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Kazuma...what do you make of this?", "Kazuma... que penses-tu de cela ?");
                s = s.Replace("There's only one place where defence lawyers and\r\nprosecutors should discuss evidence. The courtroom.", "Il n'y a qu'un lieu où avocats de la défense et procureurs\r\ndoivent débattre des preuves. Le prétoire.");
                s = s.Replace("So it seems you're still confused by the situation.", "Il semble donc que tu sois encore bien désorienté.");
                s = s.Replace("...That's what I make of it.", "... Voilà ce que j'en pense.");
                s = s.Replace("(...I get the feeling my friend's always going to have the\r\nedge over me, isn't he?)", "(... J'ai le pressentiment que mon ami gardera toujours un temps d'avance\r\nsur moi...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("This came up in the trial, didn't it?\r\nAs something a little dubious, I mean.", "Cela a été soulevé lors du procès, n'est-ce pas ?\r\nComme un élément pour le moins douteux, je veux dire.");
                s = s.Replace("The fact that no time of death was recorded on Inspector\r\nGregson's autopsy report.", "Le fait qu'aucune heure de décès n'ait été consignée sur le rapport\r\nd'autopsie de l'inspecteur Gregson.");
                s = s.Replace("Yes, there were some unexpected turns in the courtroom\r\nearlier.\r\nThe suggestion you came up with certainly took everyone\r\nby surprise.", "Oui, l'audience a pris des tournures imprévues tout à l'heure.\r\nL'hypothèse que tu as avancée a pris tout le monde de court.");
                s = s.Replace("The idea that the victim died the previous day at some\r\nother location is quite something.", "L'idée selon laquelle la victime serait morte la veille en un autre\r\nlieu est plutôt audacieuse.");
                s = s.Replace("Well, considering when the pocket watch had stopped\r\nand the scorch marks on the candle...", "Eh bien, compte tenu de l'arrêt de la montre à gousset\r\net des traces de suie sur la bougie...");
                s = s.Replace("...it's certainly a distinct possibility. The evidence and the\r\nscene both point to it.", "... c'est une éventualité tout à fait plausible. Les indices et la\r\nscène concordent.");
                s = s.Replace("To be honest, it bothered me too.", "Pour être franc, cela me tracassait également.");
                s = s.Replace("So I paid a visit to the autopsy room earlier.", "Je me suis donc rendu à la morgue plus tôt dans la journée.");
                s = s.Replace("The coroner responsible wasn't there, but I got a name.\r\nIt's Dr Gorey.", "Le médecin légiste n'y était pas, mais j'ai obtenu un nom.\r\nC'est le Dr Pétrie.");
                s = s.Replace("Um, if it wouldn't trouble you, Kazuma-sama...\r\n...we'd very much like to speak with the coroner too!", "Euh, si cela ne vous ennuie pas, monsieur Kiyô...\r\n... nous aimerions beaucoup parler au médecin légiste nous aussi !");
                s = s.Replace("Of course. The last thing I want is for anything to be\r\nbrushed under the carpet.", "Bien sûr. La dernière chose que je souhaite, c'est qu'on étouffe\r\nquoi que ce soit.");
                s = s.Replace("Scotland Yard's autopsy laboratory is behind Lowgate\r\nCemetery.", "Le laboratoire d'autopsie de Scotland Yard se situe derrière le\r\ncimetière de Lowgate.");
                s = s.Replace("Lowgate Ceme...\r\nBy Barclay Prison, you mean?", "Le cimetière de Low...\r\nPrès de la prison de Barclay, tu veux dire ?");
                s = s.Replace("Ah, you know it, do you?\r\nThe prison where my father was incarcerated...\r\nand robbed of his life.", "Ah, tu connais cet endroit ?\r\nLa prison où mon père a été incarcéré...\r\net où on lui a volé la vie.");
                s = s.Replace("Kazuma-sama...", "Monsieur Kiyô...");
                s = s.Replace("Well...thank you. We'll pay a visit to the laboratory later\r\ntoday.", "Eh bien... merci. Nous irons faire un tour au laboratoire\r\nplus tard aujourd'hui.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Kazuma...this is your armband.", "Kazuma... voici ton brassard.");
                s = s.Replace("Actually, I think it's yours now.", "En vérité, j'estime qu'il t'appartient désormais.");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("You're the defence lawyer. You have a talent for it.\r\n...I've always known that you would.", "Tu es l'avocat de la défense. Tu as un don pour cela.\r\n... J'ai toujours su que tu excellerais.");
                s = s.Replace("And now you've chosen to take that path in life.", "Et tu as désormais choisi d'emprunter cette voie.");
                s = s.Replace("As your friend, I couldn't be happier for you.\r\nOr more proud.", "En tant qu'ami, je ne pourrais être plus heureux pour toi.\r\nNi plus fier.");
                s = s.Replace("Kazuma...", "Kazuma...");
                s = s.Replace("So you keep hold of that.", "Garde-le donc précieusement.");
                s = s.Replace("Besides, I'm a prosecutor now.\r\nThat armband would have no meaning for me.", "De plus, je suis procureur à présent.\r\nCe brassard n'aurait plus aucun sens pour moi.");
                s = s.Replace("Well, if you're sure.\r\nThank you...my friend.", "Eh bien, si tu en es sûr.\r\nMerci... mon ami.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("I was shocked when I found out they were related to the\r\ncase. The Red-Headed League, I mean.", "J'étais abasourdi d'apprendre qu'ils étaient mêlés à l'affaire.\r\nLa Ligue des Rouquins, je veux dire.");
                s = s.Replace("Personally it wasn't their plan to swindle everyone that\r\nsurprised me.", "Personnellement, ce n'est pas leur plan pour escroquer tout le monde\r\nqui m'a surpris.");
                s = s.Replace("It was the fact that so many red-headed people gathered\r\nfrom all over London that day.", "C'est plutôt le fait que tant de rouquins aient pu affluer\r\nde tout Londres ce jour-là.");
                s = s.Replace("(A certain great detective being among them...)", "(Un certain grand détective figurant parmi eux...)");
                s = s.Replace("I expect those two are in their cells as we speak, wishing\r\nthey'd never dreamt up their little plan.", "Je suppose que ces deux-là sont en cellule à l'heure qu'il est, à maudire\r\nl'instant où ils ont échafaudé leur combine.");
                s = s.Replace("(Or maybe they're busy plotting their next one...)", "(Ou peut-être sont-ils déjà en train de comploter leur prochain coup...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr160_01_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("The Reaper... At last I get to take my revenge.", "Le Faucheur... Je tiens enfin ma vengeance.");
                s = s.Replace("Kazuma...", "Kazuma...");
                s = s.Replace("Lord van Zieks isn't responsible for your father's death.\r\nAnd he's not the Reaper.", "Lord Van Peers n'est pas coupable de la mort de ton père.\r\nEt il n'est pas le Faucheur.");
                s = s.Replace("He's the defendant and deserving of a fair trial.", "C'est l'accusé, et il a droit à un procès impartial.");
                s = s.Replace("You mean like the one my father had?", "Tu veux dire, comme celui qu'a eu mon père ?");
                s = s.Replace("It's a closed trial now, too. The conditions are exactly as\r\nthey were ten years ago.", "Ce procès se tient à huis clos lui aussi. Les conditions sont exactement\r\nles mêmes qu'il y a dix ans.");
                s = s.Replace("And even if it ruffles some feathers...I have a plan to show\r\nthat man for what he really is!", "Et même si cela doit faire grincer des dents... j'ai un plan pour révéler\r\ncet homme sous son vrai jour !");
                s = s.Replace("(Kazuma...)", "(Kazuma...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Inspector Gregson was obviously engaged in a special\r\noperation of some sort.", "L'inspecteur Gregson était manifestement engagé dans une opération\r\nspéciale de quelque nature.");
                s = s.Replace("He was investigating something that even Scotland Yard\r\ncouldn't know about.", "Il enquêtait sur une affaire que même Scotland Yard devait\r\nignorer.");
                s = s.Replace("(Details of the Reaper's marks, yes...)", "(Des renseignements sur les cibles du Faucheur, oui...)");
                s = s.Replace("It was when he had to carry out those investigations that\r\nI would take his identification and impersonate him.", "C'est lorsqu'il devait mener ces investigations que j'empruntais\r\nsa plaque pour me faire passer pour lui.");
                s = s.Replace("You'd pretend to be the inspector and carry out\r\ninvestigations on his behalf?", "Vous vous faisiez passer pour l'inspecteur et vous meniez l'enquête\r\nà sa place ?");
                s = s.Replace("Oh no! Never! A common street pedlar couldn't possibly\r\ncarry out a proper police investigation!", "Oh non ! Jamais de la vie ! Un simple camelot comme moi ne saurait\r\nconduire une véritable enquête policière !");
                s = s.Replace("All I would do is go to the specified location and make a\r\nlittle hoo-ha.", "Tout ce que je faisais, c'était me rendre à l'endroit désigné et faire\r\nun peu de vacarme.");
                s = s.Replace("Just something to leave an impression. So everyone there\r\nwould think, ‘A detective called Gregson was here.’", "Juste histoire de marquer les esprits. Pour que les gens se disent :\r\n« Un détective nommé Gregson est venu ici. »");
                s = s.Replace("So...that's what you were doing on the day prior to the\r\nincident?", "Donc... c'est ce que vous faisiez la veille des faits ?");
                s = s.Replace("Yes. He asked me to make an appearance at the park on\r\nLime Street for the Red-Headed League event.", "Oui. Il m'avait demandé de faire acte de présence au parc de\r\nLime Street lors de la réunion de la Ligue des Rouquins.");
                s = s.Replace("So as usual, I flashed the inspector's identification around\r\nand was very vocal about my presence.", "Alors comme d'habitude, j'ai exhibé sa carte à la ronde\r\net j'ai fait le plus de tapage possible.");
                s = s.Replace("But then you were taken prisoner!\r\nBy those red-headed fraudsters.", "Mais vous avez été fait prisonnier !\r\nPar ces escrocs à la chevelure rousse.");
                s = s.Replace("Yes.", "Oui.");
                s = s.Replace("So...you would always make a point of showing Gregson's\r\nidentification and generally being loud?", "Ainsi... vous mettiez un point d'honneur à brandir les papiers de Gregson\r\net à vous faire copieusement remarquer ?");
                s = s.Replace("That's what the inspector asked me to do, yes.", "C'est précisément ce que l'inspecteur m'avait enjoint de faire, oui.");
                s = s.Replace("Well that's one way of becoming a legendary detective,\r\nI suppose. ...Not a good one, though.", "C'est une façon de se forger une réputation de policier légendaire,\r\nje suppose. ... Pas franchement reluisante, en vérité.");
                s = s.Replace("And as you know, I suffered this bruising around my neck\r\nat their hands.", "Et comme vous le savez, j'ai écopé de ces ecchymoses au cou\r\nde leurs mains.");
                s = s.Replace("But the following day they kept their word and released\r\nme.", "Mais le lendemain, ils ont tenu parole et m'ont relâché.");
                s = s.Replace("Without returning the inspector's identification to you,\r\nhowever.", "Sans toutefois vous restituer la plaque de l'inspecteur.");
                s = s.Replace("We had arranged to meet in the Fresno Street room at\r\nfive that day so I could report back to the inspector.", "Nous avions convenu de nous retrouver dans la chambre de Fresno Street\r\nà dix-sept heures pour que je fasse mon rapport.");
                s = s.Replace("But at the agreed time, that's when I heard the gunshot.", "Mais à l'heure convenue, c'est alors que la détonation a retenti.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("It was at midnight on 17th June ten years ago.\r\nThat was the time scheduled for the execution.", "C'était à minuit, le 17 juin d'il y a dix ans.\r\nTelle était l'heure fixée pour l'exécution.");
                s = s.Replace("But the Professor's execution never actually took place,\r\ndid it?", "Mais l'exécution du Démon Assassin n'a jamais eu lieu en réalité,\r\nn'est-ce pas ?");
                s = s.Replace("Or rather, the execution itself must have been used to\r\neffect the plan of escape.", "Ou plutôt, l'exécution elle-même a dû servir de couverture pour\r\nmettre à exécution le plan d'évasion.");
                s = s.Replace("I hardly dare to imagine what a chilling plan it was...", "J'ose à peine imaginer le machiavélisme d'un tel plan...");
                s = s.Replace("Barclay was renowned for being the highest security\r\nprison in the country.", "Barclay était réputée pour être la prison la plus sécurisée\r\nde tout le pays.");
                s = s.Replace("Everything that went in or out of the place was searched\r\nmultiple times.", "Tout ce qui y entrait ou en sortait était fouillé à maintes\r\nreprises.");
                s = s.Replace("there was one notable exception.", "il y avait une exception notoire.");
                s = s.Replace("Or rather, one notable loophole.\r\nSomething that was never questioned.", "Ou pour mieux dire, une faille béante.\r\nUne chose que personne ne songeait à vérifier.");
                s = s.Replace("I have a feeling I know what that loophole was now.", "J'ai l'impression de comprendre quelle était cette faille.");
                s = s.Replace("The coffins into which the bodies of the executed convicts\r\nwere placed, correct?", "Les cercueils dans lesquels étaient déposés les corps des condamnés\r\naprès l'exécution, c'est bien cela ?");
                s = s.Replace("...Yes.", "... Oui.");
                s = s.Replace("Once the coroner had confirmed the death of a\r\ncondemned convict...", "Dès lors que le médecin légiste avait certifié le décès du condamné...");
                s = s.Replace("...the body was taken in its coffin for immediate burial in\r\nLowgate Cemetery just behind the prison.", "... la dépouille était enfermée dans son cercueil pour être immédiatement\r\ninhumée au cimetière de Lowgate, juste derrière la prison.");
                s = s.Replace("The chief warder first had to sign the necessary papers.", "Le gardien-chef devait d'abord signer les registres officiels.");
                s = s.Replace("And after that no member of staff was permitted to touch\r\nthe coffin containing the body again.", "Et passé cette formalité, nul membre du personnel n'avait le droit\r\nde toucher à nouveau au cercueil.");
                s = s.Replace("When executions took place, only the executioner and the\r\ncoroner were permitted inside the chamber.", "Lors des exécutions, seuls le bourreau et le médecin légiste\r\navaient accès à la pièce.");
                s = s.Replace("I would wait in the adjacent room for word that the\r\ncondemned convict was dead.", "J'attendais dans la salle voisine qu'on m'annonce la mort du\r\ncondamné.");
                s = s.Replace("On that occasion, once I had that confirmation, I went\r\ninto the mortuary to find a lone coffin, as usual.", "Cette nuit-là, dès réception de cette confirmation, je suis entré\r\ndans la morgue pour y trouver un cercueil isolé, comme d'accoutumée.");
                s = s.Replace("The procedure was that I would sign the paperwork\r\nhaving checked the coffin, then nail it shut.", "La procédure exigeait que je signe les actes après inspection\r\ndu cercueil, puis que je le cloue.");
                s = s.Replace("But for some reason that day, the coffin was already\r\nnailed shut.", "Mais pour une raison inexplicable ce jour-là, la bière était déjà\r\nhermétiquement clouée.");
                s = s.Replace("No!", "Ce n'est pas vrai !");
                s = s.Replace("I didn't think anything of it at the time.", "Je n'ai pas cherché plus loin sur l'instant.");
                s = s.Replace("I assumed that my deputy must have checked the coffin\r\nand nailed it shut before I arrived.", "J'ai supposé que mon adjoint avait procédé à l'inspection et avait\r\ncloué le cercueil avant mon passage.");
                s = s.Replace("So...you mean...?!", "Alors... vous voulez dire... ?!");
                s = s.Replace("The coffin contained...", "Le cercueil contenait...");
                s = s.Replace("Yes. I can only imagine that Asogi, having escaped his\r\nexecution somehow, was alive inside the coffin.", "Oui. Je ne puis que supposer qu'Asogi, ayant mystérieusement survécu\r\nà la potence, était bien vivant à l'intérieur.");
                s = s.Replace("The coffin was then taken out through the main gates and\r\ndeposited in Lowgate Cemetery.", "Le cercueil a ensuite franchi la porte d'honneur avant d'être conduit\r\nau cimetière de Lowgate.");
                s = s.Replace("Presumably there wouldn't have been enough air inside\r\nto breathe for long.", "Il n'y avait sans doute guère d'air pour respirer bien longtemps.");
                s = s.Replace("So in the early hours following the burial, somebody dug\r\nup the coffin again to set Genshin free.", "Ainsi, dans les heures qui ont suivi l'enterrement, quelqu'un a déterré\r\nla bière pour libérer Genshin.");
                s = s.Replace("But in the end...", "Mais au final...");
                s = s.Replace("...he was fatally shot in the graveyard anyway.", "... il a quand même été abattu dans le cimetière.");
                s = s.Replace("What on earth really happened in Lowgate Cemetery that\r\nnight, I wonder?", "Que s'est-il donc réellement passé au cimetière de Lowgate cette\r\nnuit-là, je me le demande ?");
                s = s.Replace("I'm afraid I really don't know.\r\nAll I can say with certainty are two things:", "J'ai bien peur de ne point le savoir.\r\nTout ce que je puis affirmer avec certitude se résume à deux choses :");
                s = s.Replace("Asogi couldn't possibly have escaped that way without\r\nhelp from somebody working in the prison.", "Asogi n'aurait jamais pu s'évader ainsi sans l'aide complice de\r\nquelqu'un travaillant au sein de la prison.");
                s = s.Replace("And that somebody...was not me.", "Et ce complice... ce n'était point moi.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Obviously, you knew the man then?", "De toute évidence, vous le connaissiez personnellement ?");
                s = s.Replace("The Professor, I mean.\r\nGenshin Asogi.", "Le Démon Assassin, je veux dire.\r\nGenshin Asogi.");
                s = s.Replace("Yes. I remember him well, in fact.", "Oui. Je me souviens fort bien de lui, en vérité.");
                s = s.Replace("Would you mind...telling us what you know?", "Auriez-vous l'obligeance... de nous faire part de ce que vous savez ?");
                s = s.Replace("Well, having been condemned to death as he was, any\r\ncontact I had with the man was short, obviously.", "Eh bien, ayant été condamné à mort, les échanges que j'ai pu avoir\r\navec lui furent évidemment bien brefs.");
                s = s.Replace("After that trial, which was carried out behind closed\r\ndoors, attended only by elite members of the judiciary...", "Après ce procès tenu à huis clos, auquel n'assistait que la haute\r\nhiérarchie judiciaire...");
                s = s.Replace("...they called for his execution to be carried out at the\r\nearliest possible opportunity.", "... ils ont ordonné que son exécution se déroule dans les plus brefs\r\ndélais.");
                s = s.Replace("The outcome of the trial was set from the beginning,\r\nwasn't it?", "L'issue du procès était scellée d'avance, n'est-ce pas ?");
                s = s.Replace("It was a time of delicate diplomacy, when Britain and\r\nJapan were in the process of signing an important treaty.", "C'était une période diplomatique délicate, alors que la Grande-Bretagne\r\net le Japon négociaient un traité capital.");
                s = s.Replace("That meant that this potentially destabilising case had to\r\nbe dealt with swiftly and discreetly.", "Cette affaire hautement explosive devait donc être réglée promptement\r\net dans la plus stricte discrétion.");
                s = s.Replace("The man had less than a week in total.", "Cet homme disposait de moins d'une semaine en tout et pour tout.");
                s = s.Replace("As I was the chief warder, I oversaw his short stay in the\r\ncells until his final hour.", "En tant que gardien-chef, j'ai veillé sur sa cellule jusqu'à sa\r\ndernière heure.");
                s = s.Replace("I remember being struck deeply by his noble character\r\nand incredible resilience.", "Je me souviens d'avoir été profondément impressionné par sa noblesse\r\nd'âme et son stoïcisme sans faille.");
                s = s.Replace("What do you mean exactly?", "Que voulez-vous dire exactement ?");
                s = s.Replace("He was a killer of many men, but he was always quiet\r\nand polite.", "On l'accusait d'avoir tué de nombreux hommes, et pourtant il restait\r\ntoujours digne et courtois.");
                s = s.Replace("He was a gentleman, and a man of intellect.", "C'était un vrai gentleman, et un esprit des plus brillants.");
                s = s.Replace("In fact, I couldn't bring myself to believe what he'd done,\r\nso I asked him one day.", "À dire vrai, je ne pouvais me résoudre à le croire coupable, si bien que\r\nje lui ai posé la question un jour.");
                s = s.Replace("Those five members of the aristocracy whose lives were\r\ntaken... Were you really responsible?", "Ces cinq membres de la haute aristocratie à qui l'on a arraché la vie...\r\nÉtiez-vous réellement coupable de leur mort ?");
                s = s.Replace("...I'm guilty of the unforgivable crime of ending another\r\nhuman's life, yes.", "... Je suis coupable du crime impardonnable d'avoir ravi la vie d'un\r\nautre être humain, oui.");
                s = s.Replace("The following day, the closed trial took place.\r\nAnd the verdict was no surprise.", "Le lendemain se tenait le procès à huis clos.\r\nEt le verdict ne fut guère une surprise.");
                s = s.Replace("Guilty.", "Coupable.");
                s = s.Replace("That night, when he was brought back to his cell...\r\n...I saw something.\r\nSomething...unusual.", "Cette nuit-là, lorsqu'il a été reconduit dans sa cellule...\r\n... j'ai aperçu quelque chose.\r\nQuelque chose... d'insolite.");
                s = s.Replace("Something unusual?\r\nWhat?", "Quelque chose d'insolite ?\r\nQuoi donc ?");
                s = s.Replace("The last will and testament...of Genshin Asogi.", "Le testament olographe... de Genshin Asogi.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("As I said, it was on the night following his trial, after he'd\r\nbeen found guilty.", "Comme je l'ai dit, c'était la nuit après son jugement, après qu'il eut\r\nété déclaré coupable.");
                s = s.Replace("I was doing the rounds of the cells, and when I looked\r\ninto Asogi's...\r\n...I noticed that he seemed to have a sheet of paper in his\r\nhand.", "Je faisais ma ronde dans le couloir, et quand j'ai regardé dans la\r\ncellule d'Asogi...\r\n... j'ai remarqué qu'il tenait une feuille de papier à la main.");
                s = s.Replace("Ah...\r\n(His last will and testament then, presumably.)", "Ah...\r\n(Son testament donc, très certainement.)");
                s = s.Replace("As soon as he noticed me, he hurriedly shoved it behind\r\nhis back.", "Dès qu'il m'a aperçu, il l'a dissimulée à la hâte derrière son dos.");
                s = s.Replace("But...why did you find that so unusual?\r\nIsn't it normal for a man to pen a will when he knows his\r\ndeath is nigh?", "Mais... pourquoi avez-vous trouvé cela insolite ?\r\nN'est-il pas courant qu'un homme écrive son testament quand il sent\r\nsa fin imminente ?");
                s = s.Replace("Yes, that's true. But there were special conditions to\r\nAsogi's incarceration, you see.", "Oui, c'est vrai. Mais il y avait des conditions bien particulières\r\nà la détention d'Asogi, voyez-vous.");
                s = s.Replace("What sort of conditions?", "Quel genre de conditions ?");
                s = s.Replace("Well...even though he was held in a cell designed for\r\ncondemned inmates...", "Eh bien... même s'il était enfermé dans une cellule pour condamnés\r\nà mort...");
                s = s.Replace("...he was allowed to keep his personal effects with him,\r\nwith one exception.", "... il avait la permission de garder ses effets personnels,\r\nà une exception près.");
                s = s.Replace("Really? He was allowed his things?\r\n(That is unusual, certainly.)", "Vraiment ? Il avait le droit de conserver ses affaires ?\r\n(Voilà qui est pour le moins singulier.)");
                s = s.Replace("Of course, he'd been convicted of killing five members of\r\nthe aristocracy...", "Certes, il avait été condamné pour l'assassinat de cinq membres de\r\nla noblesse...");
                s = s.Replace("...but at the same time he was a guest in our country from\r\nthe Empire of Japan.", "... mais dans le même temps, il était l'invité d'honneur de notre pays,\r\nvenu de l'Empire du Japon.");
                s = s.Replace("The powers that be were determined that his final days\r\nshouldn't be needlessly uncomfortable.", "Les hautes instances tenaient à ce que ses derniers instants ne soient\r\npas inutilement austères.");
                s = s.Replace("And what was the exception you mentioned...to the\r\npersonal effects he was allowed?", "Et quelle était cette fameuse exception parmi les affaires autorisées ?");
                s = s.Replace("That's the point. He wasn't permitted to have writing\r\nmaterials.", "C'est précisément là que le bât blesse. Il lui était rigoureusement\r\ninterdit de détenir du matériel d'écriture.");
                s = s.Replace("Specifically, no pens or paper.", "Plus précisément, ni plume, ni encre, ni papier.");
                s = s.Replace("So...he was prevented from leaving any written record of\r\nwhat had happened to him?", "Ainsi... on voulait l'empêcher de laisser le moindre témoignage écrit\r\nde ce qui lui arrivait ?");
                s = s.Replace("Yes, that was the long and the short of it.\r\nI've no idea where he obtained that paper.", "Oui, c'était la consigne stricte.\r\nJ'ignore totalement où il avait pu dégoter cette feuille.");
                s = s.Replace("Any writing materials would have been confiscated from\r\nhim upon his incarceration.", "Tout matériel de ce genre lui avait été retiré dès son admission.");
                s = s.Replace("As I said, he hid the paper behind his back and then he\r\npleaded with me:", "Comme je le disais, il a masqué la feuille derrière lui et m'a supplié :");
                s = s.Replace("What did you just hide behind your back?", "Qu'avez-vous donc caché derrière votre dos ?");
                s = s.Replace("Please... Please, turn a blind eye.\r\nThis...is my lifeline.", "De grâce... Je vous en supplie, fermez les yeux.\r\nCeci... est mon ultime planche de salut.");
                s = s.Replace("But...you know it's against the rules.", "Mais... vous savez bien que c'est contraire au règlement.");
                s = s.Replace("You're the only person who's seen.\r\nIf you just agree to keep quiet...", "Vous êtes la seule personne à l'avoir vu.\r\nSi vous acceptiez simplement de garder le silence...");
                s = s.Replace("Alright then.\r\nBut what's on that paper?", "Soit, entendu.\r\nMais qu'y a-t-il sur cette feuille ?");
                s = s.Replace("...A last will and testament.", "... Un testament olographe.");
                s = s.Replace("This will is...the only weapon I have left now.", "Ce testament est... la dernière arme dont je dispose à présent.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("Alright then.\r\nBut what's on that paper?", "Soit, entendu.\r\nMais qu'y a-t-il sur cette feuille ?");
                s = s.Replace("...A last will and testament.", "... Un testament olographe.");
                s = s.Replace("This will is...the only weapon I have left now.", "Ce testament est... la dernière arme dont je dispose à présent.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("(How can a will be a weapon?)", "(En quoi un testament peut-il bien servir d'arme ?)");
                s = s.Replace("So I decided to pretend I'd seen nothing.\r\nAnd I let him keep his will.", "J'ai donc résolu de feindre de n'avoir rien vu.\r\nEt je l'ai laissé conserver son testament.");
                s = s.Replace("But then later...", "Mais plus tard...");
                s = s.Replace("...it just seemed to vanish without trace.", "... il s'est tout bonnement volatilisé sans laisser de trace.");
                s = s.Replace("What?!\r\nWhat do you mean, it vanished?", "Quoi ?!\r\nComment ça, il s'est volatilisé ?");
                s = s.Replace("It would seem that isn't the end of the story of this\r\nmysterious will.", "Il semble bien que l'histoire de cette mystérieuse lettre ne s'arrête\r\npas là.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("I was the only person who saw Asogi's will, but...", "J'étais la seule personne à avoir vu le testament d'Asogi, et pourtant...");
                s = s.Replace("...But somehow it disappeared.", "... Pourtant, il s'est évanoui dans la nature.");
                s = s.Replace("It was after Asogi's ‘execution’.", "C'était après la soi-disant « exécution » d'Asogi.");
                s = s.Replace("Which was actually an elaborate jailbreak!", "Qui était en réalité une évasion montée de toutes pièces !");
                s = s.Replace("The warders gathered up Asogi's possessions that were in\r\nhis cell.", "Les geôliers ont rassemblé tous les effets d'Asogi restés en cellule.");
                s = s.Replace("They were all to be sent back to his family home in Japan,\r\nyou see.", "Ils devaient être expédiés à sa famille au Japon, voyez-vous.");
                s = s.Replace("To poor Kazuma-sama...", "Au pauvre monsieur Kiyô...");
                s = s.Replace("And you're saying that it wasn't anywhere to be found\r\namong his personal effects?", "Et vous dites qu'on ne l'a trouvé nulle part parmi ses effets ?");
                s = s.Replace("The will, I mean.", "Le testament, je veux dire.");
                s = s.Replace("That's right.\r\nThough I didn't search through them myself.", "C'est exact.\r\nBien que je n'aie pas fouillé moi-même dans ses malles.");
                s = s.Replace("But Governor Caidin was livid. He was screaming,\r\n‘It cannae have disappeared completely!’", "Mais le gouverneur Caidin était fou de rage. Il hurlait :\r\n« C'est impossible qu'il se soit envolé par enchantement ! »");
                s = s.Replace("That...doesn't quite make sense though, does it?", "Cela... n'a pas vraiment de sens, vous ne trouvez pas ?");
                s = s.Replace("In what way?", "Dans quel sens ?");
                s = s.Replace("Well, we'd understood that only Mr Vigil was aware of\r\nthe will's existence.", "Eh bien, nous avions cru comprendre que seul M. Vigil connaissait\r\nl'existence de ce document.");
                s = s.Replace("In which case, how did the prison governor know to look\r\nfor it?", "Dans ce cas, comment le gouverneur savait-il qu'il fallait le chercher ?");
                s = s.Replace("Oh yes! You're right!", "Mais oui ! Tu as parfaitement raison !");
                s = s.Replace("I really don't know how he knew.\r\nBut it certainly seemed as though he knew of the will's\r\nexistence from the outset.", "J'ignore totalement comment il l'a su.\r\nMais il semblait indubitablement en connaître l'existence dès l'origine.");
                s = s.Replace("Only he didn't refer to it as a will.\r\nWhat he said was...", "Sauf qu'il ne parlait point d'un testament.\r\nIl parlait plutôt...");
                s = s.Replace("...the ‘Asogi Papers’.", "... des « Dossiers Asogi ».");
                s = s.Replace("The Asogi Papers...", "Les Dossiers Asogi...");
                s = s.Replace("I really can't tell you anything of the subsequent events.", "Je ne peux hélas rien vous dire des événements qui ont suivi.");
                s = s.Replace("Because...well...of what happened.", "Parce que... eh bien... à cause de ce qui est arrivé.");
                s = s.Replace("(Your dismissal...and the way you blocked it all from your\r\nmemory...)", "(Votre renvoi brutal... et ce blocage total de votre mémoire...)");
                s = s.Replace("I'd forgotten all this until today.\r\nI don't suppose it's relevant to the case, though.", "J'avais tout enfoui jusqu'à ce jour.\r\nMais je doute que cela ait un rapport avec votre affaire.");
                s = s.Replace("Well anyway, thank you very much for sharing it with\r\nus, Mr Vigil. We're very grateful.", "En tout cas, merci infiniment d'avoir partagé cela avec nous, monsieur Vigil.\r\nNous vous en sommes très reconnaissants.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr232_01_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Mr Vigil, would you mind casting your eyes over this?", "Monsieur Vigil, auriez-vous l'obligeance de jeter un œil à ceci ?");
                s = s.Replace("Ugh... My head...\r\nIt's, it's throbbing...", "Argh... Ma tête...\r\nÇa... ça me lance affreusement...");
                s = s.Replace("Oh no!", "Oh non !");
                s = s.Replace("It's too soon, Mr Naruhodo!\r\nIt's too much for him!", "C'est bien trop tôt, monsieur Naruhodo !\r\nC'est trop d'émotions pour lui !");
                s = s.Replace("It's too much for me seeing him swoon like that.", "Ça me fait de la peine de le voir défaillir ainsi.");
                s = s.Replace("(Maybe I should lay off the evidence for a while...)", "(Je devrais peut-être cesser de lui montrer des pièces à conviction...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("Forgive me for asking, Mrs Vigil, but...have we met\r\nsomewhere before? Quite recently, perhaps?", "Pardonnez ma curiosité, madame Vigil, mais... ne nous serions-nous\r\npas déjà croisés quelque part ? Tout récemment, peut-être ?");
                s = s.Replace("Oh my!", "Ciel !");
                s = s.Replace("Pshaw! My dear fellow, what is your intention?", "Pff ! Mon cher confrère, qu'avez-vous donc en tête ?");
                s = s.Replace("Clearly you have no ability to differentiate the facial\r\nfeatures of the English.", "De toute évidence, vous avez les plus grandes peines à distinguer\r\nles traits d'un visage britannique.");
                s = s.Replace("If you wish to invite the lady to tea, you must do so in a\r\nmore gentlemanly fashion. ", "Si vous brûlez d'inviter cette dame à prendre le thé, ayez la courtoisie\r\nde le faire avec plus de galanterie. ");
                s = s.Replace("Is it possible...", "Serait-il possible...");
                s = s.Replace("...that you're the nice young lawyer from the trial I\r\nattended last week?", "... que vous soyez ce charmant jeune avocat du procès auquel j'ai\r\nassisté la semaine passée ?");
                s = s.Replace("Ah!\r\n(I knew I recognised her!)", "Ah !\r\n(Je savais bien que je la reconnaissais !)");
                s = s.Replace("To have a man's fate in the palm of one's hand...\r\nOh gosh! Oh golly! It sends shivers down my spine.", "Avoir le destin d'un homme au creux de sa main...\r\nOh là là ! Ça me donne des frissons dans tout le dos !");
                s = s.Replace("(I didn't quite recognise her because she's acting so\r\ndifferently now.)", "(Je ne l'avais pas reconnue de prime abord parce qu'elle se comporte\r\ntout autrement à présent.)");
                s = s.Replace("It must be very difficult for you as a lawyer.\r\nBeing hard of hearing, I mean.", "Cela doit être bien pénible pour vous en tant qu'avocat.\r\nD'avoir l'oreille si dure, je veux dire.");
                s = s.Replace("Pardon?", "Pardon ?");
                s = s.Replace("Oh dear! I'm so sorry! Don't worry if you can't hear.\r\nIt was frippery really, nothing more.", "Grand Dieu ! Je suis si confuse ! Ne vous tracassez pas si vous entendez mal.\r\nCe n'était qu'un bavardage futile, rien de plus.");
                s = s.Replace("(Now look what you've started, Mr Sholmes.\r\nThank you very much.)", "(Voilà le résultat de vos bêtises, monsieur Sholmes.\r\nMerci infiniment.)");
                s = s.Replace("I believe it would be prudent for you to sit quietly in the\r\ncorner.", "J'estime qu'il serait prudent de votre part de vous asseoir bien sagement\r\ndans un coin.");
                s = s.Replace("...Yes.", "... Bien reçu.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("Tell us about your husband, madam.", "Parlez-nous de votre époux, chère madame.");
                s = s.Replace("Mr Vigil – my Daley – is forty years of age.", "M. Vigil — mon Daley — a quarante ans accomplis.");
                s = s.Replace("I have a photograph here...", "J'ai une photographie ici même...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Hm...an entirely unremarkable gentleman...by appearance\r\nat least.", "Hum... un monsieur des plus quelconques... en apparence\r\ndu moins.");
                s = s.Replace("How long have you been married?", "Depuis combien de temps êtes-vous unis par les liens du mariage ?");
                s = s.Replace("It will be fifteen years this year.", "Cela fera quinze années cette année.");
                s = s.Replace("We have a cordial relationship, and my husband's income\r\nis more than adequate so we live quite comfortably.", "Nous vivons en parfaite harmonie, et les revenus de mon mari sont fort\r\ngénéreux, si bien que nous ne manquons de rien.");
                s = s.Replace("As it would appear.\r\nI need only look at you to know these things.", "Comme de juste.\r\nIl me suffit de vous contempler pour le déduire sur-le-champ.");
                s = s.Replace("Oh gosh!", "Ciel !");
                s = s.Replace("Your dress is the latest style, your hat clearly regularly\r\ngroomed and your eyes are animated.", "Votre parure est du dernier cri, votre chapeau impeccablement brossé\r\net vos yeux pleins de vivacité.");
                s = s.Replace("In short, you have no inkling as to why your husband\r\nmight have disappeared. Correct?", "Bref, vous n'avez pas le moindre soupçon quant aux motifs de la disparition\r\nde votre époux. N'est-il pas ?");
                s = s.Replace("That's right. He's a kind man with a strong sense of\r\nloyalty...and he rather dotes on me.", "C'est tout à fait cela. C'est un homme doux et d'une loyauté absolue...\r\net il m'adore.");
                s = s.Replace("Which would point to the possibility...", "Ce qui nous oriente vers la probabilité...");
                s = s.Replace("...that he has become embroiled in some incident or other.", "... qu'il se soit retrouvé mêlé à quelque fâcheuse mésaventure.");
                s = s.Replace("Oh, that is exactly what I fear must have happened,\r\nMr Sholmes! I'm quite beside myself!", "Oh, c'est précisément ce que je redoute, monsieur Sholmes !\r\nJ'en suis malade d'inquiétude !");
                s = s.Replace("My husband's employment is somewhat unusual, you see.", "La profession de mon mari est quelque peu singulière, voyez-vous.");
                s = s.Replace("What if he's incurred some miscreant's ill will?", "Et s'il s'était attiré les foudres de quelque malfaiteur ?");
                s = s.Replace("What exactly is your husband's line of work?", "En quoi consiste au juste le gagne-pain de votre époux ?");
                s = s.Replace("He's a warder at the prison. ", "Il est gardien à la prison. ");
                s = s.Replace("(A guard? That is ‘somewhat unusual’.)", "(Gardien de prison ? C'est en effet « quelque peu singulier ».)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("So...your husband is a prison warder.", "Ainsi donc... votre mari est gardien de prison.");
                s = s.Replace("That's right, yes. Well, in actual fact, he's the chief\r\nwarder.", "Tout à fait. Enfin, pour tout dire, il est même le gardien-chef.");
                s = s.Replace("Indeed? I see...", "Vraiment ? Fort bien...");
                s = s.Replace("Well, chief prison warder certainly qualifies as something\r\nof a specialist occupation.", "Eh bien, gardien-chef de prison relève indéniablement d'une fonction\r\nparticulièrement spécialisée.");
                s = s.Replace("Yes, it does indeed.", "Oui, tout à fait.");
                s = s.Replace("My poor husband must prepare those dreadful\r\npunishments...and see that they're carried out.", "Mon pauvre époux doit préparer ces terribles supplices...\r\net veiller à leur accomplissement.");
                s = s.Replace("(‘Dreadful punishments’?...\r\nDoes she mean capital punishments?)", "(Des « terribles supplices »... ?\r\nFait-elle référence aux exécutions ?)");
                s = s.Replace("And at such times, he must occasionally spend a night or\r\ntwo in the prison dormitory.", "Et dans ces moments-là, il lui arrive de dormir une nuit ou deux\r\ndans les quartiers de la prison.");
                s = s.Replace("But for that extra responsibility, he is remunerated more\r\nhandsomely than the other warders.", "Mais pour ce fardeau, il est rétribué bien plus grassement\r\nque les simples gardiens.");
                s = s.Replace("Of course, we make no mention of my husband's work to\r\nthe neighbours.", "Évidemment, nous taisons scrupuleusement son métier devant le voisinage.");
                s = s.Replace("Yes...I believe your prudence is justified.\r\nTell me, at what prison is your husband engaged?", "Oui... je souscris pleinement à une telle prudence.\r\nDites-moi, dans quelle prison officie donc votre cher et tendre ?");
                s = s.Replace("Barclay Prison, Mr Sholmes.", "À la prison de Barclay, monsieur Sholmes.");
                s = s.Replace("Really? Barclay?\r\nOh, a fine establishment!", "Vraiment ? Barclay ?\r\nOh, un établissement de tout premier ordre !");
                s = s.Replace("If I'm not mistaken, there is a large cemetery just behind\r\nit.", "Si mes souvenirs sont exacts, un vaste cimetière s'étend juste derrière\r\nses hauts murs.");
                s = s.Replace("Yes, that's correct. \r\nLowgate Cemetery.", "Oui, c'est parfaitement exact.\r\nLe cimetière de Lowgate.");
                s = s.Replace("(No!)", "(Ce n'est pas possible !)");
                s = s.Replace("(Lowgate Cemetery?\r\nThe very place we were discussing in court!)", "(Le cimetière de Lowgate ?\r\nL'endroit même évoqué à l'audience !)");
                s = s.Replace("(That's unbelievable!)", "(C'est tout simplement incroyable !)");
                s = s.Replace("Unbelievable, my dear fellow, and yet undeniable.", "Incroyable, mon cher confrère, et pourtant irréfutable.");
                s = s.Replace("Sorry, Mr Sholmes, I'm afraid you've lost me.", "Pardonnez-moi, monsieur Sholmes, mais vous m'avez égarée.");
                s = s.Replace("Ah, pay no heed, madam, pay no heed.\r\nA private matter.", "Ah, ne faites point attention, chère madame, n'y prenez point garde.\r\nUne simple affaire de routine.");
                s = s.Replace("(This can't really be a coincidence...can it?)", "(Il ne peut pas s'agir d'une simple coïncidence... si ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("So...to the matter of your husband's disappearance.\r\nWhen did you realise he was missing?", "Venons-en donc... à l'affaire de la disparition de votre mari.\r\nQuand avez-vous constaté son absence ?");
                s = s.Replace("...Please try not to laugh.\r\nIt was yesterday.", "... Je vous en prie, ne riez pas.\r\nC'était hier.");
                s = s.Replace("I'm sorry? Yesterday?", "Plaît-il ? Hier seulement ?");
                s = s.Replace("(That really is recent. Laughably so.)", "(C'est en effet tout frais. À en sourire presque.)");
                s = s.Replace("The truth is my husband does at times have occasion to\r\nspend the night away for his work.", "La vérité est que mon époux est parfois retenu la nuit entière\r\npour ses obligations.");
                s = s.Replace("It's not at all out of the ordinary for him not to return\r\nhome at night. But this is different!", "Il n'y a donc rien d'anormal à ce qu'il ne rentre pas dormir chez nous.\r\nMais cette fois, c'est différent !");
                s = s.Replace("For him not to make any contact for a whole day!\r\nThat has certainly never happened before!", "Ne donner aucun signe de vie pendant vingt-quatre heures entières !\r\nCela ne s'était jamais, au grand jamais, produit !");
                s = s.Replace("Oh, my dear Daley!\r\nWhatever can have happened?", "Oh, mon pauvre Daley d'amour !\r\nQue peut-il bien lui être arrivé ?");
                s = s.Replace("My dear Mrs Vigil, please, calm yourself.", "Chère madame Vigil, de grâce, calmez-vous.");
                s = s.Replace("Now then...have you contacted the police?", "Voyons... avez-vous prévenu les services de police ?");
                s = s.Replace("Why, naturally!\r\nBut sadly...", "Mais assurément !\r\nHélas...");
                s = s.Replace("...they refused to listen to my pleas as my husband has\r\nonly been missing for one day.", "... ils ont rejeté mes appels au motif que mon mari n'avait disparu\r\nque depuis une seule journée.");
                s = s.Replace("I was asked to wait patiently at home.", "Ils m'ont intimé l'ordre d'attendre patiemment à la maison.");
                s = s.Replace("In truth, Mrs Vigil, I concur with the police.", "En vérité, madame Vigil, je partage l'avis des forces de l'ordre.");
                s = s.Replace("However! Let us not be hasty!", "Néanmoins ! Ne soyons pas trop hâtifs !");
                s = s.Replace("I see no reason why we should not engage my deductive\r\npowers to track your husband down anyway.", "Rien ne s'oppose à ce que nous mettions à contribution mes fulgurantes\r\nfacultés déductives pour retrouver votre moitié.");
                s = s.Replace("Oh, thank you, Mr Sholmes!", "Oh, merci mille fois, monsieur Sholmes !");
                s = s.Replace("And furthermore! Let me assure you!\r\nA chance to solve the greatest problem known to man for\r\nanother month has no bearing on my decision.", "Et de surcroît ! Laissez-moi vous en donner l'assurance !\r\nL'opportunité de régler mon loyer pour un mois supplémentaire n'entre en rien\r\ndans ma détermination.");
                s = s.Replace("I seek only to put a sweet smile on another Londoner's\r\nface. ...That's really all there is to it.", "Je n'aspire qu'à faire refleurir le doux sourire sur le visage d'une honnête\r\nLondonienne. ... C'est véritablement là ma seule motivation.");
                s = s.Replace("You have my eternal gratitude!\r\nI shall pay any sum you care to mention!", "Vous avez mon infinie gratitude !\r\nJe m'acquitterai de la moindre somme que vous daignerez fixer !");
                s = s.Replace("(You seek only to put this suite's rent in your landlady's\r\npurse. THAT's all there is to it.)", "(Vous n'aspirez qu'à remplir la bourse de votre logeuse.\r\nC'EST là votre seule et unique motivation.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr323_00_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("Mrs Vigil, would you mind casting your eyes over this?", "Madame Vigil, voudriez-vous jeter un regard là-dessus ?");
                s = s.Replace("Oh my poor Daley... Where have you gone?\r\nWhat's become of you?", "Oh, mon pauvre Daley chéri... Où es-tu parti ?\r\nQu'est-il advenu de toi ?");
                s = s.Replace("I'm afraid she's too worried about her husband to pay any\r\nattention, Mr Naruhodo.", "J'ai bien peur qu'elle ne soit trop angoissée pour son mari pour y prêter\r\nattention, monsieur Naruhodo.");
                s = s.Replace("...Either that, or she just doesn't want to be bothered with\r\nme.", "... Ou bien elle ne veut tout simplement pas s'embarrasser de ma personne.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("I said, get oot!", "J'ai dit : foutez l'camp !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("Governor Caidin, could I at least show you this?", "Directeur Caidin, pourrais-je au moins vous présenter ceci ?");
                s = s.Replace("(How many times can one man turn his back on you in a\r\nsingle conversation?)", "(Combien de fois un homme peut-il tourner le dos en une seule conversation ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("If you'd just cast your eyes over this, Governor Caidin...", "Si vous daigniez jeter un œil à ceci, directeur Caidin...");
                s = s.Replace("What's this then? You cannae pull the wool over my eyes,\r\nyou good-fer-nothin' Japanese student!", "Qu'est-ce que c'est qu'ça ? C'est pas à un vieux singe qu'on apprend à faire\r\ndes grimaces, bon-à-rien d'étudiant japonais !");
                s = s.Replace("Mikotoba?\r\nThat, that young jock from the forensics laboratory?\r\nThat Mikotoba?", "Mikotoba ?\r\nCe... ce p'tit gars du labo médico-légal ?\r\nCe Mikotoba-là ?");
                s = s.Replace("Yes! Exactly! Him!", "Oui ! Précisément ! Lui-même !");
                s = s.Replace("Oh dear, perhaps I should have said something sooner...\r\nI'm Yujin Mikotoba's daughter, Susato.", "Ciel, j'aurais dû me présenter plus tôt...\r\nJe suis Susato, la fille de Yujin Mikotoba.");
                s = s.Replace("Jings! You're the young man's daughter?\r\nAnd ya did'nae think to mention that afore?", "Nom d'un chien ! Vous êtes la fille d'ce brave gars ?\r\nEt vous n'avez point pensé à l'dire plus tôt ?");
                s = s.Replace("I, I do apologise...", "Je... je vous prie de m'excuser...");
                s = s.Replace("Aye, well, ye'd best take a seat then.\r\nCan I offer you a cup of tea, perhaps?", "Ouais, eh ben, asseyez-vous donc là, ma p'tite dame.\r\nPuis-je vous offrir une tasse de thé, par hasard ?");
                s = s.Replace("And dinnae forget to try one of these wee handcuff\r\nbiscuits!", "Et n'oubliez point d'goûter à ces p'tits biscuits menottes !");
                s = s.Replace("Your father's influence is nothing short of amazing...", "L'influence de votre père est absolument prodigieuse...");
                s = s.Replace("I'm bitterly regretting not announcing who I was from the\r\noutset now.", "Je regrette amèrement de ne pas m'être présentée dès mon arrivée.");
                s = s.Replace("So then...what can I do for you, hen?", "Alors voyons... que puis-je faire pour vous, fillette ?");
                s = s.Replace("Well...we're currently investigating a case.", "Eh bien... nous menons actuellement une enquête.");
                s = s.Replace("It's one of your warders, you see.\r\nHe's gone missing.", "Il s'agit d'un de vos gardiens, voyez-vous.\r\nIl a disparu.");
                s = s.Replace("Missing?", "Disparu ?");
                s = s.Replace("That's right. It's surely been reported to you as well,\r\nbeing the prison governor.", "C'est cela. On a dû vous le signaler, en tant que directeur.");
                s = s.Replace("I have'nae heard nothing of the sort.\r\nThere's no missing persons in my prison!", "J'ai point ouï dire de pareille fadaise.\r\nY a pas d'disparu dans ma prison !");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("(But...how can that be?)", "(Mais... comment est-ce possible ?)");
                s = s.Replace("It's Mr Daley Vigil, your chief warder...", "Il s'agit de M. Daley Vigil, votre gardien-chef...");
                s = s.Replace("Eh? Vigil?", "Hein ? Vigil ?");
                s = s.Replace("That's right. His wife came to us and asked us to\r\ninvestigate his disappearance.", "Tout à fait. Son épouse nous a priés d'enquêter sur sa disparition.");
                s = s.Replace("(Let's skip the part about him only going missing\r\nyesterday for now...)", "(Passons sous silence pour l'instant le fait qu'il n'ait disparu qu'hier...)");
                s = s.Replace("(Clearly that means something to him...)", "(Ce nom fait visiblement mouche...)");
                s = s.Replace("Would you be so kind as to tell us what you know, sir?", "Auriez-vous la bonté de nous dire ce que vous savez, monsieur ?");
                s = s.Replace("Aye... Aye, of course.", "Ouais... Bien sûr, naturellement.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#5"] = (en) => {
                string s = en;
                s = s.Replace("We understand that Mr Vigil is the chief warder here at\r\nthe prison.", "Nous savons que M. Vigil était le gardien-chef de cette prison.");
                s = s.Replace("Aye, that he was.\r\nStrong sense of responsibility and dedicated to the job, no\r\ndoubt aboot it. He was a fine warder.", "Ouais, il l'était, ma foi.\r\nUn sens du devoir exemplaire et dévoué à sa tâche, sans conteste.\r\nC'était un fichu bon gardien.");
                s = s.Replace("Sorry, did you say ‘was’?", "Pardon, avez-vous dit « l'était » ?");
                s = s.Replace("Aye. He does'nae work here no more.\r\nHe left the job.", "Ouais. Y travaille plus ici depuis un bail.\r\nIl a quitté l'boulot.");
                s = s.Replace("Oh my!", "Ciel !");
                s = s.Replace("When was this exactly?", "Quand cela s'est-il passé exactement ?");
                s = s.Replace("There's a question. When was it aboot...?\r\nIt cannae have been much less than...\r\n...ten years ago now.", "Bonne question. Quand est-ce que c'était déjà... ?\r\nÇa n'doit pas faire moins de...\r\n... dix bonnes années maintenant.");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("T-Ten years ago?\r\nHe stopped working here ten years ago?!", "D-Dix ans ?\r\nIl a cessé de travailler ici il y a dix ans ?!");
                s = s.Replace("Aye, as I mind it. D'you ken, I have'nae heard the fella's\r\nname in all that time.", "Ouais, d'aussi loin que j'm'en souvienne. Dites-vous bien que j'ai plus\r\nentendu parler d'lui depuis tout ce temps.");
                s = s.Replace("That's a worry if he's gone missing, though.", "Mais c'est fort inquiétant s'il s'est volatilisé.");
                s = s.Replace("But, but Mrs Vigil made no mention of it...", "Mais... Mme Vigil n'a pas soufflé mot de tout cela...");
                s = s.Replace("I think perhaps, Mr Naruhodo, that his wife simply doesn't\r\nknow.", "J'ai bien l'impression, monsieur Naruhodo, que son épouse n'en sait rien.");
                s = s.Replace("I think she's unaware that he no longer works here.", "Elle ignore manifestement qu'il n'est plus en fonction ici.");
                s = s.Replace("Governor Caidin, can you tell us what happened?\r\nWhy did Mr Vigil give up his job here?", "Directeur Caidin, pouvez-vous nous expliquer ?\r\nPourquoi M. Vigil a-t-il abandonné son poste ?");
                s = s.Replace("That's...important, is it?", "C'est... capital, ma foi ?");
                s = s.Replace("Yes, I believe it may be.", "Oui, j'ai tout lieu de le penser.");
                s = s.Replace("What are you thinking, Mr Naruhodo?", "À quoi songez-vous, monsieur Naruhodo ?");
                s = s.Replace("I can't help wondering...given that it was ten years ago...", "Je ne peux m'empêcher de songer... au fait que cela remonte à dix ans...");
                s = s.Replace("Ah!", "Ah !");
                s = s.Replace("(Which was exactly when the Professor was being held at\r\nthis prison.)", "(C'est précisément l'époque où le Démon Assassin était écroué\r\ndans cette prison.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("So Mr Vigil actually resigned from the position of chief\r\nwarder ten years ago, you're telling us?\r\nWhat happened to make him leave the job?", "Ainsi M. Vigil a en fait démissionné de ses fonctions de gardien-chef\r\nil y a dix ans ?\r\nQue s'est-il passé pour qu'il s'en aille ?");
                s = s.Replace("In actual fact, he did'nae leave the job willingly.\r\nHe had no choice in the matter.", "En réalité, il est point parti de son plein gré.\r\nIl n'a point eu le choix.");
                s = s.Replace("You mean...he was dismissed?", "Vous voulez dire... qu'il a été congédié ?");
                s = s.Replace("It was...after a particular walk.", "C'était... après une certaine « promenade ».");
                s = s.Replace("Sorry? A walk?", "Pardon ? Une promenade ?");
                s = s.Replace("Aye, that's oor word for it in here.\r\nA walk to the gallows.", "Ouais, c'est notre jargon par chez nous.\r\nLa promenade jusqu'au gibet.");
                s = s.Replace("An, an execution...", "Une... une exécution...");
                s = s.Replace("It's the job of the chief warder to prepare the gallows tree\r\nand oversee any executions, you see.", "C'est la charge du gardien-chef de dresser la potence\r\net de superviser les exécutions, voyez-vous.");
                s = s.Replace("Only...Vigil did something unthinkable on that last walk\r\nhe was manning.", "Sauf que... Vigil a commis l'impensable lors de cette dernière promenade.");
                s = s.Replace("What did he do?", "Qu'a-t-il donc fait ?");
                s = s.Replace("I'm sorry, but...I cannae reveal that information.", "Navré, mais... j'peux point divulguer cette information.");
                s = s.Replace("But I can tell you that it's verra rare for a chief warder to\r\nbe relieved of his post.", "Tout c'que j'peux vous confier, c'est qu'c'est bigrement rare qu'un gardien-chef\r\nsoit déchu de son titre.");
                s = s.Replace("But why wouldn't Mrs Vigil know about it?\r\nShe appears to be under the impression that her husband\r\nstill works here.", "Mais pourquoi Mme Vigil n'en saurait-elle rien ?\r\nElle est persuadée que son époux y travaille toujours.");
                s = s.Replace("I would'nae ken anything aboot that, I'm afraid.", "J'en sais fichtre rien, j'le crains bien.");
                s = s.Replace("Can you perhaps answer one more question about the\r\ncircumstances of his dismissal?", "Pourriez-vous éclairer un dernier point sur ce renvoi ?");
                s = s.Replace("And what would that be, hen?", "Et qu'est-ce que ce s'rait, fillette ?");
                s = s.Replace("That last execution that Mr Vigil was responsible for\r\noverseeing...\r\nWas it by any chance...the Professor's?", "Cette ultime exécution dont M. Vigil avait la responsabilité...\r\nÉtait-ce par hasard... celle du Démon Assassin ?");
                s = s.Replace("(My thoughts exactly...)", "(C'est exactement ce que je me demandais...)");
                s = s.Replace("I'm sorry, I really am.\r\nBut I'm no at liberty to answer that.", "J'suis désolé, vraiment.\r\nMais je n'ai point la liberté de répondre.");
                s = s.Replace("I see...", "Je vois...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("My father came to Britain all those years ago in order to\r\nstudy forensic medicine.\r\nBut you seem to have been well acquainted.", "Mon père est venu en Grande-Bretagne il y a toutes ces années pour y étudier la médecine légale.\r\nMais vous sembliez fort bien vous connaître.");
                s = s.Replace("The dead room, the prison and the cemetery have a lot to\r\ndo wi' one another.\r\nAfter all, they need fresh corpses for forensic research.\r\nD'you ken?", "La morgue, la taule et le cimetière ont bien des affaires ensemble.\r\nAprès tout, y leur faut de la chair fraîche pour la recherche médico-légale.\r\nVous pigez ?");
                s = s.Replace("...Yes, I can imagine.", "... Oui, je conçois.");
                s = s.Replace("The advancement of medical science isn't always\r\nparticularly palatable...", "Les progrès de la science médicale ne sont pas toujours très ragoûtants...");
                s = s.Replace("Your father worked in the laboratory just on the far side\r\nof the graveyard.\r\nIn the basement of St Synner's.\r\nIt's still in use today.", "Votre père travaillait dans l'labo juste de l'autre côté du champ de repos.\r\nDans les sous-sols de Saint-Synner.\r\nC'est encore ouvert aujourd'hui.");
                s = s.Replace("St Synner's...\r\n(That's come up before, I'm sure...)", "Saint-Synner...\r\n(Ce nom a déjà été mentionné, j'en suis sûr...)");
                s = s.Replace("Yes, that's right. We've been there.", "Oui, tout à fait. Nous nous y sommes déjà rendus.");
                s = s.Replace("Mikotoba and I aft used to ride in a carriage together and\r\nnegotiate terms.", "Mikotoba et moi, on prenait souvent l'fiacre pour négocier les conditions.");
                s = s.Replace("(For more ‘fresh’ material, I suppose...)", "(Pour obtenir du matériel plus « frais », je suppose...)");
                s = s.Replace("Aye, and we used to sit in here for hours and gab on\r\naboot dissection and all sorts. Och, it takes me back.\r\nOver a pot of tea and a plate of cuff biscuits, of course.", "Ouais, et on restait assis là des heures à papoter dissection et mille autres choses. Ah, ça m'rajeunit point.\r\nAutour d'un thé et d'une assiette de biscuits menottes, bien entendu.");
                s = s.Replace("How charming...", "Comme c'est charmant...");
                s = s.Replace("He was a good fella, your father. Reliable, and dead set on\r\nhis work.", "C'était un chic bonhomme, votre père. Fiable, et acharné à la tâche.");
                s = s.Replace("But I'm afraid...\r\n...I'll never understand you Japanese.", "Mais j'ai bien peur...\r\n... que j'comprendrai jamais vos manières, vous autres les Japonais.");
                s = s.Replace("(Because of Genshin Asogi, I suppose...)", "(À cause de Genshin Asogi, sans doute...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Um, Governor Caidin, would you have a look at this?", "Euh, directeur Caidin, pourriez-vous examiner ceci ?");
                s = s.Replace("Och, would'nae you rather have a wee handcuff biscuit?", "Ah, vous préféreriez point un p'tit biscuit menotte ?");
                s = s.Replace("Oh...no, thanks.\r\nI'd rather you just cast your eyes over this.", "Oh... non, merci.\r\nJe préférerais simplement que vous jetiez un œil à ceci.");
                s = s.Replace("Or maybe you prefer real handcuffs, eh?", "Ou p'têt que vous préférez d'vraies menottes, hein ?");
                s = s.Replace("No no! Neither for me, please!\r\nLovely offers, though!", "Non non ! Ni l'un ni l'autre pour moi, je vous en prie !\r\nFort aimable à vous de proposer, cela dit !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("What's that there, then?", "Qu'est-ce que c'est qu'ce bidule, alors ?");
                s = s.Replace("It's actually the sign of a Japanese defence lawyer.", "C'est l'insigne officiel d'avocat de la défense japonais.");
                s = s.Replace("Well...if you have to wear something like that to prove\r\nwho ye are...\r\n...perhaps I should wear these handcuffs, eh?", "Eh ben... si vous devez arborer un truc pareil pour prouver qui vous êtes...\r\n... j'devrais p'têt porter ces menottes, moi aussi, hein ?");
                s = s.Replace("I think maybe they're more of a sign of the people you\r\ncatch than you yourself.", "Je crois qu'elles seraient plutôt le signe des gens que vous arrêtez que le vôtre.");
                s = s.Replace("Aye, that's true.\r\nYe've got me there, hen.", "Ouais, c'est pas faux.\r\nVous m'avez bien mouché, fillette.");
                s = s.Replace("(They're not actually a sign of anything, are they?)", "(Elles ne sont le signe d'absolument rien, en fait...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_00_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("Well...how aboot that? A friend of Mikotoba turnin' up\r\nafter all these years.\r\nAnd his wee bairn, even.", "Ça alors ! Un compère de Mikotoba qui s'ramène après tout ce temps.\r\nEt sa propre fillette par-dessus l'marché.");
                s = s.Replace("My father speaks highly of you, sir.", "Mon père parle de vous avec beaucoup d'estime, monsieur.");
                s = s.Replace("D'you ken, I can see the resemblance now.", "Figurez-vous que j'vois la ressemblance à présent.");
                s = s.Replace("Oh!", "Oh !");
                s = s.Replace("Aye, especially around your eyes.\r\nYe look dead like him.", "Ouais, tout particulièrement autour des yeux.\r\nVous êtes son portrait craché.");
                s = s.Replace("What an interesting observation.", "Voilà une remarque des plus intéressantes.");
                s = s.Replace("(Not the delighted reaction from Susato-san that he might\r\nhave been expecting...)", "(Pas tout à fait la réaction enjouée à laquelle il pouvait s'attendre de sa part...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("That murderer's botched execution...\r\nAnd the whole miserable escape...", "L'exécution bâclée de ce maudit criminel...\r\nEt toute cette piteuse évasion...");
                s = s.Replace("They were Barclay's darkest hour, aye.\r\nA shocking embarrassment.", "Ç'a été l'heure la plus noire de Barclay, ouais.\r\nUne honte monumentale.");
                s = s.Replace("Because the convict had a collaborator on the prison staff,\r\nyou mean?", "Parce que le détenu bénéficiait d'un complice parmi les gardiens, voulez-vous dire ?");
                s = s.Replace("...Aye, for shame.\r\nThe coroner who confirmed the death o' the man after his\r\nexecution, Courtney Sithe.", "... Ouais, misère.\r\nLe médecin légiste qui a certifié la mort du bougre après la potence, Cyriella Pétrie.");
                s = s.Replace("And my chief warder at the time, Vigil, who was in\r\ncharge o' the whole affair.", "Et mon gardien-chef de l'époque, Vigil, qui chapeautait toute l'affaire.");
                s = s.Replace("But Mr Vigil says he didn't know anything about it.", "Mais M. Vigil assure qu'il n'était au courant de rien.");
                s = s.Replace("The rascal would'nae say otherwise, eh?\r\n...More handcuffs?", "Ce renard n'allait point prétendre l'contraire, hein ?\r\n... Encore des menottes ?");
                s = s.Replace("Oh! How could I say no?\r\n...You can never have too much iron in your diet!", "Oh ! Comment refuser ?\r\n... On n'a jamais trop de fer dans son régime !");
                s = s.Replace("When Mr Vigil was handed his dismissal notice as a\r\nresult of what had happened...\r\n...he was so despairing, he jumped out of your office\r\nwindow, didn't he?", "Lorsque M. Vigil a reçu sa lettre de renvoi par suite de cette tragédie...\r\n... il était si accablé qu'il a sauté par la fenêtre de votre bureau, n'est-ce pas ?");
                s = s.Replace("I dinnae like to say, but that's just Vigil trying to get oot\r\nof it.\r\nDo you no think he would'nae have jumped from the\r\nshock of his crimes being exposed, eh? ...I do.", "J'aime point médire, mais c'est bien la tactique de Vigil pour s'dédouaner.\r\nCroyez-vous point qu'il a sauté sous l'coup de voir ses turpitudes démasquées, hein ? ... Moi, oui.");
                s = s.Replace("(You would'nae say otherwise though, would you?)", "(Vous n'alliez point dire le contraire non plus, j'imagine...)");
                s = s.Replace("Of course, I cannae shun all responsibility myself.\r\nI should'nae have let him deceive me.", "Évidemment, j'peux point fuir toutes mes responsabilités.\r\nJ'aurais point dû m'laisser berner par ce zigoto.");
                s = s.Replace("Actually, there's barely anybody that kens what went on\r\nat the time now.\r\nWi' Gregson having been murdered, and Dr Sithe\r\nforbidden from having any visitors.", "En vérité, y a quasiment plus âme qui vive qui sait c'qui s'est tramé à l'époque.\r\nAvec Gregson qui s'est fait occire, et la Dre Pétrie privée de visites.");
                s = s.Replace("(No visitors? Someone obviously doesn't want her giving\r\nanything away...)", "(Aucune visite ? Quelqu'un ne veut visiblement pas qu'elle vende la mèche...)");
                s = s.Replace("Well...we're not going home empty-handed!", "Eh bien... nous ne repartirons pas bredouilles !");
                s = s.Replace("And I would'nae dream of sending you packing wi' nowt,\r\nkimmer. Here...take a handcuff or two!", "Et j'oserais point vous renvoyer les mains vides, fillette.\r\nTenez... prenez donc une menotte ou deux !");
                s = s.Replace("Oh! Well it would be rude to say no!\r\n...Wouldn't want to become anaemic!", "Oh ! Ce serait un affront de décliner !\r\n... Il ne faudrait pas souffrir d'anémie !");
                s = s.Replace("I suppose...if there's anybody who might still ken aboot\r\nwhat happened back then...\r\n...it'd be that lass from the forensic division.\r\nMaria Gorey.", "J'imagine... que s'il reste quelqu'un qui saurait c'qui s'est passé en ce temps-là...\r\n... ce s'rait cette gamine de la médecine légale.\r\nMaria Gorey.");
                s = s.Replace("Maria...Gorey?", "Maria... Gorey ?");
                s = s.Replace("Aye, Sithe's daughter. She did'nae have no more.\r\nJust the one.\r\nBut the wee bairn's followed in her mam's footsteps.\r\nYou dinnae ever see her wi'out a scalpel in her hand.", "Ouais, la fille de Pétrie. Elle n'en a point eu d'autre.\r\nJuste celle-là.\r\nMais la p'tiote a marché sur les traces de sa daronne.\r\nOn la voit jamais sans un scalpel entre les doigts.");
                s = s.Replace("Mama, what is this?", "Maman, qu'est-ce que c'est ?");
                s = s.Replace("...Agh!\r\n(Wh-Where did SHE spring from?)", "... Argh !\r\n(D-D'où est-ce qu'ELLE sort, celle-là ?)");
                s = s.Replace("(And...did she just call the doctor, ‘Mama’?)", "(Et... vient-elle d'appeler le médecin « Maman » ?)");
                s = s.Replace("(Dr Sithe's daughter, Maria Gorey...\r\nWe could do with talking to her...)", "(La fille de la Dre Pétrie, Maria Gorey...\r\nIl serait bon d'aller lui toucher deux mots...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("So...she's Dr Sithe's daughter, but her surname is Gorey?", "Ainsi... c'est la fille de la Dre Pétrie, mais son nom de famille est Gorey ?");
                s = s.Replace("Aye, there's some family history, I'm sure, but I dinnae ken\r\nthe ins and oots of it.", "Ouais, y a une sombre histoire d'famille, sûrement, mais j'connais point les tenants et les aboutissants.");
                s = s.Replace("She grew up watching her mam working wi' the bodies of\r\nfolk who'd died in strange circumstances...\r\n...and decided to do the same wi' her own life.\r\nI cannae understand it myself.", "Elle a grandi en voyant sa génitrice disséquer les corps de macchabées trépassés de façon louche...\r\n... et elle a voulu faire pareil de ses dix doigts.\r\nJ'y comprends que couic, ma parole.");
                s = s.Replace("Perhaps she was driven by a deep respect for her\r\nmother...", "Peut-être était-elle animée par un profond respect pour sa mère...");
                s = s.Replace("Perhaps... Anyhoo, she was in charge of Gregson's\r\nautopsy, I believe.", "Peut-être... Quoi qu'il en soit, elle s'occupait de l'autopsie de Gregson,\r\nà c'qu'on dit.");
                s = s.Replace("(Right. And the coroner responsible for this incomplete\r\nreport...)", "(C'est cela. Et le médecin légiste responsable de ce rapport incomplet...)");
                s = s.Replace("Someone told me once that the wee lassie always loved\r\nher mam's stories aboot cutting up bodies.", "On m'a conté un jour que la gamine adorait les récits de sa mère où l'on découpait des corps.");
                s = s.Replace("There's even a rumour that she used to listen to the\r\nfuneral march as a lullaby.", "Y a même un ragot disant qu'elle s'endormait au son de la marche funèbre.");
                s = s.Replace("Well then perhaps...her mother might have told her about\r\nthe autopsy from the case ten years ago!", "Eh bien dans ce cas... sa mère lui a peut-être parlé de l'autopsie d'il y a dix ans !");
                s = s.Replace("Aye, I'd say there's a fighting chance at least.", "Ouais, j'dirais qu'y a de fortes chances, en effet.");
                s = s.Replace("After all, that was a life-changing case for all of us.", "Après tout, c'te maudite affaire a chamboulé notre existence à tous.");
                s = s.Replace("(We really need to speak to Miss Gorey herself about this,\r\nI think.)\r\nWell...thank you very much.", "(Il nous faut impérativement interroger Mademoiselle Pétrie à ce sujet,\r\nje crois.)\r\nEh bien... merci infiniment.");
                s = s.Replace("I'm no happy aboot any part o' this.\r\nIt took years for Londoners to finally forget the whole\r\nProfessor business.", "J'suis point enchanté par tout ce tintouin.\r\nIl a fallu des années pour que les Londoniens oublient enfin toute l'histoire du Démon Assassin.");
                s = s.Replace("Can you no gi' up on this, laddie?\r\nStop asking pointless questions.", "Vous pouvez point laisser tomber, gamin ?\r\nCessez d'poser des questions stériles.");
                s = s.Replace("...I'm sorry. I don't like dredging up these painful\r\nmemories for everyone.", "... Pardonnez-moi. Je n'aime guère remuer ces douloureux souvenirs.");
                s = s.Replace("Can you no just stay away noo?\r\nLeave me alone and dinnae come back here, eh?", "Vous pouvez point déguerpir pour de bon ?\r\nFichez-moi la paix et n'remettez plus les pieds céans, pigé ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("How d'you come to ken aboot that, laddie?\r\nThere's no many folk even here in the prison who've\r\nheard o' those papers.", "Comment diantre êtes-vous au courant d'ça, gamin ?\r\nY a quasiment personne ici à Barclay qui a ouï parler d'ces papiers.");
                s = s.Replace("Ah...well...\r\n(I can't tell him Mr Vigil told me...)", "Euh... eh bien...\r\n(Je ne peux pas lui révéler que cela vient de M. Vigil...)");
                s = s.Replace("I'm afraid our sources must remain confidential, sir.", "J'ai bien peur que nos sources ne doivent rester confidentielles, monsieur.");
                s = s.Replace("Hmph...", "Humph...");
                s = s.Replace("We've been led to believe the papers are actually a last\r\nwill and testament. Is that right?", "Nous avons de bonnes raisons de penser que ces documents sont en fait un testament.\r\nEst-ce exact ?");
                s = s.Replace("The Professor's...\r\nOr rather, Genshin Asogi's...", "Celui du Démon Assassin...\r\nOu plutôt, celui de Genshin Asogi...");
                s = s.Replace("Aye, that's right.\r\n...You're well informed, Jimmy.", "Ouais, c'est l'cas.\r\n... Vous êtes bigrement bien renseigné, p'tit gars.");
                s = s.Replace("(Oh, is that the end of the silent treatment?)", "(Tiens, serait-ce la fin du vœu de silence ?)");
                s = s.Replace("But then after the convict's execution, it mysteriously\r\nvanished from his cell, didn't it?", "Mais après l'exécution du condamné, il a mystérieusement disparu de sa cellule,\r\nn'est-ce pas ?");
                s = s.Replace("Havers, no! You're off at half-cock there.\r\nI think you did'nae quite get your facts straight.", "Foutaises ! Vous vous emballez pour rien, là.\r\nJ'crois bien que vous mélangez tout.");
                s = s.Replace("It was there in the cell, exactly where it should've been.", "Il était bel et bien dans la cellule, pile où il devait être.");
                s = s.Replace("Oh...\r\n(Not what we heard elsewhere...)", "Oh...\r\n(Ce n'est pas tout à fait ce qu'on nous a raconté...)");
                s = s.Replace("Let me just have a wee holk aroond in here.\r\nI'm sure I can find it...", "Laissez-moi farfouiller deux secondes par là.\r\nJ'suis bien certain de pouvoir mettre la main dessus...");
                s = s.Replace("Aye, here ye are.\r\nSee?", "Ouais, v'là l'travail.\r\nVous voyez ?");
                s = s.Replace("‘The Last Will and Testament of Genshin Asogi’...\r\nWritten with a calligraphy brush...", "« Testament olographe de Genshin Asogi »...\r\nRédigé au pinceau de calligraphie...");
                s = s.Replace("Of course, I cannae read a word of those Japanese\r\nsquiggles.\r\nBut I mind it says he leaves all his worldly possessions to\r\nhis son back in his homeland.", "Évidemment, j'entrave que pouic à ces gribouillages japonais.\r\nMais j'me rappelle qu'il lègue tous ses biens terrestres à son rejeton resté au pays.");
                s = s.Replace("Yes, that's correct.\r\nThat's the gist of it.", "Oui, c'est parfaitement exact.\r\nC'est la substance du document.");
                s = s.Replace("So these...are the Asogi Papers?", "Alors voici... les fameux Dossiers Asogi ?");
                s = s.Replace("Aye, of course they are!\r\nPapers written by Asogi, nae doubt aboot it.\r\nThere's no mystery here, laddie.\r\nThat's your lot!", "Ouais, qu'est-ce que vous croyez !\r\nDes paperasses écrites par Asogi en personne, sans l'ombre d'un doute.\r\nY a pas d'mystère là-dedans, gamin.\r\nEmballé, c'est pesé !");
                s = s.Replace("After all the stramash o' that slaister of an execution...\r\n...we sent the man's possessions back to his clan in Japan...\r\nand that was the end of it!", "Après tout l'ramdam causé par ce fiasco d'exécution...\r\n... on a expédié les hardes du gaillard à son clan au Japon...\r\net l'affaire était pliée !");
                s = s.Replace("I think we ought to make a record of this, Mr Naruhodo.\r\nJust in case.", "Je pense que nous devrions noter ceci dans nos dossiers, monsieur Naruhodo.\r\nAu cas où.");
                s = s.Replace("The Asogi Papers have been\r\nentered into the Court Record.", "Les Dossiers Asogi ont été versés\r\nau dossier de l'affaire.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce03_chr326_01_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("One thing afore you go on your way, Mr Naruhodo...", "Une dernière chose avant qu'vous mettiez les voiles, monsieur Naruhodo...");
                s = s.Replace("Oh...yes?", "Oh... oui ?");
                s = s.Replace("Those papers are nowt to do wi' Gregson's death.\r\nI'd prefer it if you did'nae make no mention of them\r\nootside this office. Or rather...", "Ces papiers n'ont aucun rapport avec la mort de Gregson.\r\nJ'préférerais que vous n'en souffliez mot hors de ce bureau. Ou plutôt...");
                s = s.Replace("...I would'nae just prefer it. Consider it an order from the\r\nhighest levels of oor government.", "... ce n'est point un simple souhait. Considérez cela comme un ordre formel\r\némanant des plus hautes sphères de notre gouvernement.");
                s = s.Replace("...I understand.", "... C'est bien compris.");
                return s;
            };

        }
    }
}
