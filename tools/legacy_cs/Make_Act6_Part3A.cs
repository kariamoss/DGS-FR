using System;
using System.IO;
using System.Text;

class MakeAct6Part3A {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct6 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart3_A() {");

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

        // [91] KEY:BB\script\output\_sce02_chr103_01_eng#4
        add(@"BB\script\output\_sce02_chr103_01_eng#4", new string[,] {
            { "Oh...", "Oh..." },
            { "Perhaps Father wanted a reason to get away.", "Peut-être que mon père cherchait une raison de s'éloigner." },
            { "What do you mean? Why?", "Que veux-tu dire ? Pourquoi donc ?" },
            { "(Well...)\r\n(...clearly something was going on at the time.)", "(Eh bien... il se passait visiblement quelque chose à l'époque.)" }
        });

        // [92] KEY:BB\script\output\_sce02_chr103_01_eng#5
        add(@"BB\script\output\_sce02_chr103_01_eng#5", new string[,] {
            { "I wanted to ask you about Lord van Zieks, actually.", "Je voulais vous poser une question au sujet de Lord Van Peers en fait." },
            { "I heard that his older brother was killed some years ago.", "J'ai appris que son frère aîné avait été assassiné il y a quelques années." },
            { "By a mass murderer known as the Professor, who\r\ntargeted nobles and royalty. Is that right?", "Par un tueur en série surnommé le Démon Assassin, qui prenait pour cible nobles et têtes couronnées. Est-ce exact ?" },
            { "...You Japanese are a thorough lot.\r\nYou've done your research well.", "...Vous autres Japonais êtes bien méticuleux. Vous avez mené vos recherches avec soin." },
            { "Yes...\r\n...and you could say it was that very incident...that gave\r\nrise to the Reaper.", "Oui... et l'on pourrait dire que c'est précisément ce drame... qui a donné naissance au Faucheur." },
            { "What?\r\nWhy?", "Quoi ?\r\nPourquoi donc ?" },
            { "When his brother, Klint van Zieks, was murdered...", "Quand son frère, Klimt Van Peers, a été assassiné..." },
            { "...it was just after young Barok had graduated from the\r\nUniversity of London and become a prosecutor.", "...le jeune Drake venait tout juste d'être diplômé de l'université de Londres et d'entrer au parquet." },
            { "When obvious criminals who managed to evade\r\nconviction in court started ‘disappearing’...\r\n...rumours quickly spread throughout the capital.", "Quand des criminels avérés ayant échappé à la condamnation ont commencé à « disparaître »... des rumeurs se sont promptement répandues dans toute la capitale." },
            { "Londoners started to say that wherever Barok van Zieks\r\nwent, the ghost of his dead brother wasn't far behind.", "Les Londoniens se sont mis à murmurer que partout où allait Drake Van Peers, le spectre de son défunt frère ne tardait pas à frapper." },
            { "Oh my word!", "Bonté divine !" },
            { "So...Lord van Zieks isn't the Reaper...\r\nIt's the ghost of his brother?!", "Ainsi... Lord Van Peers ne serait pas le Faucheur... Ce serait le fantôme de son frère ?!" },
            { "Ever since that time, he became a very aloof figure in\r\nLondon's legal circles.", "Depuis cette tragédie, il est devenu une figure particulièrement solitaire et distante dans le monde judiciaire londonien." }
        });

        // [93] KEY:BB\script\output\_sce02_chr105_01_eng#1
        add(@"BB\script\output\_sce02_chr105_01_eng#1", new string[,] {
            { "So, you want to know what the Forensic Investigation\r\nTeam determined from its examination of the scene?", "Ainsi, vous désirez savoir ce que la brigade de police scientifique a déduit de ses constatations sur la scène ?" },
            { "The victim, Mr Odie Asman, who disappeared from the\r\nexperimentation stage amid an explosion...\r\n...and the Mr Asman who appeared moments later\r\npart-way up the Crystal Tower...\r\n...were without question one and the same person.\r\nThat is the team's conclusion.", "La victime, M. Odoril Asman, disparu de l'estrade d'expérimentation lors de la déflagration... et le M. Asman apparu un instant plus tard à mi-hauteur de la Tour de Cristal... étaient sans conteste une seule et même personne. Telle est la conclusion irréfutable de mon équipe." },
            { "But...but that can't be right!", "Mais... mais c'est impossible !" },
            { "If it was an elaborate trick, we can only speculate about\r\nhow it was carried out.", "S'il s'agissait d'une supercherie élaborée, nous ne pouvons que spéculer sur la manière dont elle a été exécutée." },
            { "Let's see...if two people who looked very similar to each\r\nother were involved...\r\n...they could have made it appear as if one single person\r\nhad switched places, couldn't they?", "Voyons... si deux personnes qui se ressemblaient énormément étaient complices... elles auraient pu donner l'illusion qu'un seul et même individu s'était téléporté, n'est-ce pas ?" },
            { "Very true. But sadly in this instance...that was not the\r\ncase.\r\nThe man who disappeared and the man who\r\nsubsequently reappeared was the same person.\r\nThe fingerprints at the scene make that quite evident.", "C'est fort juste. Hélas en l'occurrence... ce n'était pas le cas. L'homme qui s'est volatilisé et celui réapparu ensuite étaient la même personne. Les empreintes digitales relevées sur les lieux l'attestent sans équivoque." },
            { "Ah, fingerprints...", "Ah, les empreintes digitales..." },
            { "They're not yet officially recognised as forensic evidence\r\nin the British justice system.\r\nBut one day...they will be used as an investigative aid as a\r\nmatter of course.", "Elles ne sont pas encore reconnues officiellement comme preuves légales par la justice britannique. Mais un jour... elles deviendront un outil d'investigation systématique." },
            { "Oh my! But that would mean...\r\n...that the instantaneous kinesis actually took place!\r\nSo...where does that leave us?", "Ciel ! Mais cela signifierait... que la téléportation instantanée a bel et bien eu lieu ! Alors... où cela nous mène-t-il ?" },
            { "My team was tasked with investigating.\r\nNot drawing conclusions.", "Mon équipe avait pour mission d'enquêter. Pas de tirer des conclusions." },
            { "(Instantaneous kinesis is impossible...and yet the body did\r\nmove from one place to the other.)\r\n(This hasn't cleared anything up at all.\r\nIt's made the whole thing even more of a mystery!)", "(La téléportation instantanée est impossible... et pourtant le corps s'est bien déplacé d'un endroit à un autre.)\r\n(Cela n'éclaircit rien du tout. Au contraire, le mystère s'épaissit encore davantage !)" }
        });

        // [94] KEY:BB\script\output\_sce02_chr105_01_eng#3
        add(@"BB\script\output\_sce02_chr105_01_eng#3", new string[,] {
            { "Dr Sithe, would you be good enough to take a look at this?", "Docteur Pétrie, auriez-vous l'amabilité de jeter un coup d'œil à ceci ?" },
            { "Oh, you think I'm ‘good enough’, do you?", "Oh, vous pensez que j'ai « l'amabilité » requise ?" },
            { "Ah! No no, I didn't mean...", "Ah ! Non, non, je ne voulais pas dire..." },
            { "So I'm not good enough? In that case, why would you\r\nshow me anything?", "Alors je ne suis pas assez bien ? Dans ce cas, pourquoi vouloir me montrer quoi que ce soit ?" },
            { "(Ugh, clearly you're too good for me to show you anything\r\nagain...ever!)", "(Pfff, vous êtes visiblement bien trop hautaine pour que je vous remontre quoi que ce soit... un jour !)" }
        });

        // [95] KEY:BB\script\output\_sce02_chr230_00_eng#1
        add(@"BB\script\output\_sce02_chr230_00_eng#1", new string[,] {
            { "Um, you mentioned the demonstration yesterday...", "Hum, vous avez évoqué la démonstration d'hier..." },
            { "The papers have called it a spectacular failure.\r\nAfter all, a man died in the explosion, didn't he?", "Les journaux ont parlé d'un échec cuisant. Après tout, un homme a péri dans l'explosion, n'est-ce pas ?" },
            { "AAAAAAAAAAAAAAAAAAAARGH! Yes, you could\r\ninterpret the results that way if you really wanted to!", "AAAAAAAAAAAAAAAAAAAARGH ! Oui, on pourrait interpréter les résultats ainsi si l'on y tenait absolument !" },
            { "Well, I, I suppose in the strictest sense...", "Eh bien, j-j'imagine qu'au sens le plus strict..." },
            { "...the experiment was a failure.\r\nBut at the same time, it was a great success!", "...l'expérience s'est soldée par un échec. Mais en même temps, ce fut un triomphe absolu !" },
            { "...You've lost me.", "...Vous m'avez perdu." },
            { "I saw it with my own eyes! Right there in front of me!\r\nMr Asman was spontaneously disassembled!", "Je l'ai vu de mes propres yeux ! Juste là, devant moi ! M. Asman s'est spontanément désassemblé !" },
            { "Until then, everything was going exactly as my\r\ncalculations had predicted!", "Jusque-là, tout se déroulait exactement selon mes calculs prévisionnels !" },
            { "At that point, he should have been beamed to the Crystal\r\nTower by instantaneous kinesis!", "À cet instant précis, il aurait dû être transféré à la Tour de Cristal par téléportation cinétique !" },
            { "However...", "Cependant..." },
            { "...The machine exploded and Mr Asman in fact perished?", "...La machine a explosé et M. Asman y a en réalité trouvé la mort ?" },
            { "Yes. I can't deny that part of the experiment was a failure.", "Oui. Je ne puis nier que cette phase de l'expérience fut un échec." },
            { "So what you're really saying is, the large explosion that\r\nkilled Mr Asman was an accident, correct?", "Ce que vous voulez dire, c'est que la déflagration fatale à M. Asman était un accident, n'est-ce pas ?" },
            { "But the bigwigs had you arrested on suspicion of murder.", "Mais les autorités vous ont fait arrêter sous l'inculpation de meurtre." },
            { "I was responsible for a man's death. That is the immutable\r\ntruth here.\r\nAnd for that, I wish to be punished.\r\nAt once!", "J'ai causé la mort d'un homme. C'est la vérité immuable en cette affaire. Et pour cela, je demande à être châtié. Sur-le-champ !" },
            { "B-But...\r\n...murder?! Never in a million years!\r\nIt, it was an accident! Simply an accident!", "M-Mais... un meurtre ?! Jamais de la vie ! C-C'était un accident ! Un malheureux accident !" },
            { "...I see.", "...Je vois." },
            { "Hurley and I were talking this morning, you know.\r\nHe said the situation would change completely depending\r\non whether it was treated as an accident or murder.", "Sherlockinou et moi en discutions ce matin. Il disait que la situation changeait du tout au tout selon qu'il s'agissait d'un accident ou d'un meurtre." },
            { "How exactly?", "En quel sens exactement ?" }
        });

        // [96] KEY:BB\script\output\_sce02_chr230_00_eng#2
        add(@"BB\script\output\_sce02_chr230_00_eng#2", new string[,] {
            { "So in short...there was a terrible accident at the Great\r\nExhibition showground yesterday.", "En résumé... un terrible accident est survenu hier sur le site de l'Exposition universelle." },
            { "Yes! Or rather no. The devil is in the details!\r\nStrictly speaking, there was a terrible explosion.", "Oui ! Ou plutôt non. Le diable se cache dans les détails ! À strictement parler, il y a eu une terrible explosion." },
            { "(Sounds the same to me...)", "(Pour moi, ça revient exactement au même...)" },
            { "You were demonstrating super-high-voltage\r\ninstantaneous kinesis, weren't you? How fascinating!", "Vous faisiez la démonstration de la téléportation instantanée à très haute tension, n'est-ce pas ? Comme c'est fascinant !" },
            { "Humans, like all matter, are made up of particles that are\r\nheld together by electrical bonds.\r\nSo it must be possible, using a sufficiently high voltage, to\r\nbreak those bonds and beam the particles through space!", "Les êtres humains, comme toute matière, sont constitués de particules liées entre elles par des forces électriques. Il doit donc être possible, avec une tension électrique adéquate, de briser ces liaisons et de propulser les particules à travers l'espace !" },
            { "That's, that's it in a nutshell! That's my idea, you see?\r\nThat's my amazing hypothesis!", "C'est... c'est exactement cela en résumé ! Vous comprenez l'idée ? C'est ma fabuleuse hypothèse !" },
            { "Gosh... That's unimaginably high-level science.", "Bonté divine... C'est d'une complexité scientifique inouïe." },
            { "Oh, but dare to imagine it!\r\nDare to dream of such incredible technology!\r\nJust think! One moment I could be here in this cell, and\r\nthe next...I could be at the Great Exhibition again!", "Mais osez l'imaginer ! Osez rêver d'une technologie aussi extraordinaire ! Songez-y ! Un instant je serais ici dans cette cellule, et le suivant... je me retrouverais à l'Exposition universelle !" },
            { "Well, yes! That would be incredible.", "Eh bien, oui ! Ce serait fabuleux." },
            { "And the next, in the mere blink of an eye, I could be at a\r\ngreat Parisian theatre, say!\r\nThe possibilities are endless! The whole of our vast planet\r\nwould be within reach!", "Et l'instant d'après, en un clignement de paupières, je pourrais assister à une pièce dans un grand théâtre parisien ! Les possibilités sont illimitées ! Notre vaste planète entière serait à portée de main !" },
            { "(...So no more hiding in wardrobes on rocky seas for fifty\r\ndays?)", "(...Plus besoin de se cacher dans une penderie sur une mer agitée pendant cinquante jours ?)" },
            { "Hm, I don't really see it like that.", "Hum, je ne le vois pas vraiment sous cet angle." },
            { "What do you mean, Iris?", "Que veux-tu dire, Iris ?" },
            { "Well, if you could travel anywhere in the world\r\ninstantly...\r\n...the planet wouldn't really seem vast any more, would it?\r\nI think it would feel like it had shrunk.", "Eh bien, si l'on pouvait se rendre n'importe où sur Terre en un instant... la planète ne semblerait plus si vaste que cela, n'est-ce pas ? J'ai plutôt l'impression qu'elle semblerait avoir rétréci." },
            { "My word! That's, that's exactly right!", "Ciel ! C'est... c'est parfaitement exact !" },
            { "Wh-What are the implications...? What does this mean?", "Qu... Quelles en sont les conséquences... ? Qu'est-ce que cela implique ?" },
            { "Oops, that's got Professor Bunnybrain really worried by\r\nthe look of it.", "Oups, voilà le professeur Lonron tout chamboulé par cette perspective." },
            { "(Clearly this is yet another case of ‘just because you can,\r\ndoesn't mean you should’, I suppose...)", "(Voilà un cas typique où « ce n'est pas parce qu'on peut le faire qu'on doit forcément le faire », j'imagine...)" }
        });

        // [97] KEY:BB\script\output\_sce02_chr230_00_eng#3
        add(@"BB\script\output\_sce02_chr230_00_eng#3", new string[,] {
            { "I understand Lord van Zieks is a friend of yours from\r\nyour university days?", "J'ai cru comprendre que Lord Van Peers était l'un de vos amis de vos années d'université ?" },
            { "Yes, that's right. He was studying law whilst I was\r\nstudying science.", "Oui, tout à fait. Il étudiait le droit tandis que j'étudiais les sciences." },
            { "What was he like back then?", "Comment était-il à l'époque ?" },
            { "Hm, a good question...\r\nUnassuming...gentlemanly...\r\nAn all-round nice fellow, really.", "Hum, excellente question... Modeste... courtois... Un chic type sous tous rapports, en vérité." },
            { "Sorry, I, I think you misheard me.\r\nI'm talking about the cold-hearted, merciless prosecutor\r\nBarok van Zieks...\r\nWhat was he like when he was at university?", "Pardonnez-moi, mais je crois que vous m'avez mal compris. Je parle du procureur impitoyable et glacial Drake Van Peers... Comment était-il donc à l'université ?" },
            { "...Talk about a leading question, Runo.", "...Voilà ce qui s'appelle orienter le témoin, Mister Yûno." },
            { "As I said: an unassuming and extremely pleasant\r\ngentleman.\r\nAfter all, he is the little darling of the van Zieks family,\r\nwith all its great aristocratic origins.", "Comme je l'ai dit : un parfait gentleman, doux et fort agréable. Après tout, c'était le benjamin chéri de l'illustre lignée des Van Peers, avec toutes ses lettres de noblesse." },
            { "I, I didn't realise he had quite such noble blood!", "J-Je n'imaginais pas qu'il avait le sang si bleu !" },
            { "Little darling?!", "Le benjamin chéri ?!" },
            { "It was a bit of a shock when I came back to Britain and\r\nlearnt what he'd become.\r\nThe Reaper of the Bailey no less!", "Ce fut tout un choc à mon retour en Grande-Bretagne d'apprendre ce qu'il était devenu. Le Faucheur d'Old Bailey, rien de moins !" },
            { "Yes, that's right.", "Oui, c'est bien cela." },
            { "I did hear, though...\r\n...that there was a very big event in his life that\r\ncompletely changed him after graduation.", "J'ai pourtant ouï dire... qu'un terrible événement survenu après l'obtention de son diplôme l'avait métamorphosé du tout au tout." },
            { "Really?\r\nWhat sort of event?", "Vraiment ?\r\nQuelle sorte d'événement ?" },
            { "I'm, I'm sorry, but I don't know any more.\r\nI wasn't in the country at the time.\r\nI was in Germany already.", "Je... je suis navré, mais je n'en sais pas plus. Je n'étais plus sur le sol britannique à cette époque. J'étais déjà parti pour l'Allemagne." },
            { "Oh. ...Yes, of course.", "Oh. ...Oui, bien sûr." },
            { "(If he's heard all about the Reaper...)\r\n(...I really don't have the heart to tell him that Lord van\r\nZieks will be the prosecutor in court tomorrow.)", "(S'il est au courant pour la légende du Faucheur... je n'ai vraiment pas le cœur de lui annoncer que Lord Van Peers mènera l'accusation à son procès demain.)" }
        });

        // [98] KEY:BB\script\output\_sce02_chr230_00_eng#4
        add(@"BB\script\output\_sce02_chr230_00_eng#4", new string[,] {
            { "The full name of the man who died in yesterday's\r\naccident was Mr Odie Asman, wasn't it?\r\nWhat exactly was your relationship with the man?", "Le nom complet de la victime de l'accident d'hier était bien M. Odoril Asman, n'est-ce pas ? Quels liens entreteniez-vous avec lui au juste ?" },
            { "He first visited me in my laboratory in Germany a year\r\nago now.\r\nHe said he wanted to invest in my immaculate hypothesis.\r\nI thanked my lucky stars!", "Il est venu me trouver dans mon laboratoire en Allemagne il y a un an de cela. Il a manifesté le désir d'investir dans ma théorie novatrice. J'ai béni ma bonne étoile !" },
            { "I see... So you hadn't really known each other until then.", "Je vois... Vous ne vous connaissiez donc pas avant cela." },
            { "Money for scientific research...\r\nI'm so envious!", "Des fonds pour la recherche scientifique... Quelle chance inouïe !" },
            { "As far as I was concerned, the man was an angel!", "En ce qui me concernait, cet homme était un ange descendu du ciel !" },
            { "Oh...really?", "Ah... vraiment ?" },
            { "An archangel, even!\r\nHe was prepared to fund a practical demonstration of my\r\nhypothesis for presentation at the Great Exhibition!\r\nAnd if that went well, I could expect additional financial\r\nsupport for my research from the British government!\r\nMr Asman provided me with money and an exceptional\r\nengineer.", "Un archange, devrais-je dire ! Il était prêt à financer une démonstration grandeur nature de mon hypothèse à l'Exposition universelle ! Et si tout réussissait, je pouvais espérer des subsides supplémentaires de la part du gouvernement britannique ! M. Asman m'a fourni les capitaux ainsi qu'un ingénieur hors pair." }
        });

        // [99] KEY:BB\script\output\_sce02_chr230_00_eng#6
        add(@"BB\script\output\_sce02_chr230_00_eng#6", new string[,] {
            { "He produced a machine to my precise specifications.", "Il a conçu un appareil répondant rigoureusement à mes spécifications." },
            { "But then your dreams were blown to dust in one\r\nenormous explosion.", "Mais tous vos espoirs ont été pulvérisés dans une gigantesque déflagration." },
            { "As you can see, I owed everything to Mr Asman.\r\nI would never, ever have thought of taking the man's life!", "Comme vous le constatez, je devais tout à M. Asman. Jamais, au grand jamais, je n'aurais songé à lui ôter la vie !" },
            { "(Well, he seems genuine enough.\r\nI don't think he's lying.)", "(Il m'a l'air parfaitement sincère. Je ne pense pas qu'il mente.)" }
        });

        // [100] KEY:BB\script\output\_sce02_chr230_00_eng#8
        add(@"BB\script\output\_sce02_chr230_00_eng#8", new string[,] {
            { "Professor Harebrayne, what do you make of this?", "Professeur Lonron, qu'en pensez-vous ?" },
            { "Oh yes! That's just what we need to prove my hypothesis,\r\nisn't it?", "Oh oui ! C'est exactement ce qu'il nous faut pour corroborer mon hypothèse, pas vrai ?" },
            { "Um...no.\r\nIt's nothing to do with your hypothesis, actually.", "Hum... non. Cela n'a absolument aucun rapport avec votre hypothèse, en fait." },
            { "Then take it away! I don't want to be bothered with\r\nanything that doesn't assist my science!", "Alors débarrassez-m'en ! Je refuse d'être distrait par quoi que ce soit qui ne serve pas la cause de ma science !" },
            { "(Alright...keep your abundant hair on...)", "(C'est bon... pas la peine de vous crêper le chignon...)" }
        });

        // [101] KEY:BB\script\output\_sce02_chr230_00_eng#9
        add(@"BB\script\output\_sce02_chr230_00_eng#9", new string[,] {
            { "Ah, fascinating, yes!", "Ah, passionnant, tout à fait !" },
            { "In Japan, where I come from, it's the symbol of a defence\r\nlawyer. Wearing it is very bracing, I find.", "Au Japon, d'où je viens, c'est l'insigne d'avocat de la défense. Le porter me donne une belle contenance." },
            { "Hm, your words make some sense to me, but they are\r\nentirely illogical.\r\n...What do you mean?\r\nWell, for example, I find this white laboratory coat that I\r\nwear for my work very bracing, too.\r\nHowever, in my case, there is a perfectly logical reason\r\nfor that feeling.", "Hum, vos propos ne manquent pas de sens, mais ils sont totalement dénués de logique. ...Que voulez-vous dire ? Eh bien, par exemple, je trouve cette blouse blanche de laboratoire que je porte pour mes recherches particulièrement seyante elle aussi. Cependant, dans mon cas, cette sensation repose sur une raison rigoureusement logique." },
            { "Oh! Really?\r\nWhat is it?", "Oh ! Vraiment ? Et laquelle ?" },
            { "I, I purchased the wrong size by mistake.\r\nThis one is too small for me.\r\nThe sleeves, especially, are extremely bracing.\r\nI can barely move my wrists.", "J-J'ai acheté la mauvaise taille par inadvertance. Elle est bien trop étroite pour moi. Les manches, tout particulièrement, me serrent considérablement. J'arrive à peine à bouger mes poignets." },
            { "That's what you call logical, is it?", "C'est ce que vous appelez logique ?" },
            { "Of course! It's entirely logical!\r\nThat's science, Mr Naruhodo!", "Évidemment ! C'est la logique même ! C'est cela, la science, Monsieur Naruhodo !" }
        });

        // [102] KEY:BB\script\output\_sce02_chr230_00_eng#12
        add(@"BB\script\output\_sce02_chr230_00_eng#12", new string[,] {
            { "Ugh...how could this have happened?", "Argh... comment une telle chose a-t-elle pu se produire ?" },
            { "You must feel awful. As well as a man losing his life, the\r\nCrystal Tower was greatly damaged, too.", "Vous devez être bouleversé. En plus de la mort d'un homme, la Tour de Cristal a été gravement endommagée." },
            { "I, I know what happened!\r\nIt must have been that!", "J-Je sais ce qui s'est passé ! Cela ne peut être que ça !" },
            { "‘That’?", "« Ça » ?" },
            { "The day before the demonstration, I had my usual meal\r\nof frankfurters at the hotel restaurant.\r\nWhen I paid the bill, they gave me three shillings too\r\nmuch in change.\r\nBut...instead of saying anything, I just slipped the coins\r\ninto my pocket! They're still there now!\r\nIt's divine retribution for my wrongdoing, that's what this\r\nis!", "La veille de la démonstration, j'ai pris mon habituel repas de saucisses de Francfort au restaurant de l'hôtel. Au moment de régler, le garçon m'a rendu trois shillings de trop. Mais... au lieu de lui signaler son erreur, j'ai discrètement glissé la monnaie dans ma poche ! Les pièces y sont encore ! C'est le châtiment divin qui s'abat sur moi pour mon péché, voilà tout ce que c'est !" },
            { "(For a scientist, he has some very illogical anecdotes.\r\nLong and illogical.)", "(Pour un érudit, ses anecdotes sont sacrément irrationnelles. Longues et irrationnelles.)" }
        });

        // [103] KEY:BB\script\output\_sce02_chr230_00_eng#13
        add(@"BB\script\output\_sce02_chr230_00_eng#13", new string[,] {
            { "Professor, do you recognise this?", "Professeur, reconnaissez-vous ceci ?" },
            { "Oh, it's Andrew!\r\nMy faithful friend!", "Oh, c'est Andrew ! Mon fidèle compagnon !" },
            { "How have you been? Are you alright?\r\nNobody's mistreated you, have they?", "Comment te portes-tu ? Tu vas bien ? Personne ne t'a maltraité, j'espère ?" },
            { "Don't worry, he's being very well looked after.", "Ne vous en faites pas, nous en prenons grand soin." },
            { "I always rub him with machine oil until he's gleaming.\r\n...Right.\r\nAnd then, when I come to tighten a screw with him, he\r\nslips in my hand and I can't do it!\r\nHaha, it's that age-old problem faced by driverphiles the\r\nworld over, isn't it?", "Je le frotte toujours à l'huile pour machine jusqu'à ce qu'il étincelle. ...Je vois. Et ensuite, quand je tente de resserrer une vis avec, il m'échappe des mains ! Ah ah, c'est l'éternel dilemme auquel font face les tournevisphiles du monde entier, pas vrai ?" },
            { "I...really wouldn't know, I'm afraid.", "Je... n'en ai pas la moindre idée, je le crains." }
        });

        // [104] KEY:BB\script\output\_sce02_chr230_01_eng#1
        add(@"BB\script\output\_sce02_chr230_01_eng#1", new string[,] {
            { "...Everything I believed in has been turned on its head.\r\nMy research...Mr Asman...the kinesis machine...\r\nMy hypothesis, even...", "...Tout ce en quoi j'avais foi a volé en éclats. Mes recherches... M. Asman... l'appareil cinétique... Et même mon hypothèse..." },
            { "I'm sorry it's come to this.\r\nThere was really no other way.", "Je suis désolé qu'on en soit arrivés là. Il n'y avait pas d'autre solution." },
            { "No, it's not your fault. I wanted to protect my work, but\r\nin the end, there was nothing worth protecting.", "Non, vous n'y êtes pour rien. Je voulais protéger mes travaux, mais en fin de compte, il n'y avait rien qui en valût la peine." },
            { "It was never my intention to deceive anyone.\r\nI didn't want to trick the public.", "Mon intention n'a jamais été d'abuser qui que ce soit. Je n'ai jamais voulu duper le public." },
            { "No...of course you didn't...", "Non... bien sûr que non..." },
            { "But in court this morning, I realised something.\r\nOh?\r\nIf you've done something wrong without knowing it...\r\n...you've still done something wrong. Logically, it makes\r\nno difference if you were aware of it or not.\r\nIgnorance is a poor excuse.\r\nThe blame still lies with me.", "Mais au tribunal ce matin, j'ai réalisé une chose. Ah ? Quand on commet une faute à son insu... cela reste malgré tout une faute. Logiquement parlant, que l'on en soit conscient ou non ne change rien au résultat. L'ignorance est une bien piètre excuse. La responsabilité m'incombe pleinement." },
            { "Oh, Professor...", "Oh, Professeur..." },
            { "He believed in me this morning, you know.\r\nBarok did. He believed in my hypothesis.", "Il a cru en moi ce matin, vous savez. Drake. Il croyait en mon hypothèse." },
            { "Well, I think...\r\n...that was just a necessary factor in the prosecution\r\nestablishing its case.", "Eh bien, je crois plutôt... que c'était simplement nécessaire à l'accusation pour monter son dossier." },
            { "No no, Barok wouldn't do something like that.\r\nI'm sure he genuinely believed it.", "Non, non, Drake ne ferait jamais une chose pareille. Je suis convaincu qu'il y croyait sincèrement." },
            { "(Did he...?)", "(Vraiment...?)" },
            { "I think I understand now.\r\nWhy it was that he decided to take on the prosecution in\r\nmy trial, I mean.", "Je crois comprendre à présent. Pourquoi il a tenu à soutenir l'accusation lors de mon procès, je veux dire." }
        });

        // [105] KEY:BB\script\output\_sce02_chr230_01_eng#2
        add(@"BB\script\output\_sce02_chr230_01_eng#2", new string[,] {
            { "After the terrible accident happened, nobody would\r\nbelieve in my hypothesis any more.\r\nNot the police. Not the prosecution service.\r\nNot any lawyers, even...", "Après cet affreux accident, plus personne ne voulait accorder le moindre crédit à mon hypothèse. Ni la police. Ni le parquet. Pas même le moindre avocat..." },
            { "(...I feel like I dealt some kind of finishing blow there.)", "(...J'ai l'impression de lui avoir asséné le coup de grâce à l'instant.)" },
            { "So if any other prosecutor had taken the case...\r\nIf it was anyone other than Barok...\r\n...I'm sure the prosecution would have declared my\r\nhypothesis a c-complete and utter nonsense.", "Alors si n'importe quel autre procureur avait hérité du dossier... Si cela avait été quelqu'un d'autre que Drake... l'accusation aurait à coup sûr relégué mon hypothèse au rang de pure et totale absurdité." },
            { "And in that case, you would have been declared a fraud\r\nyourself, Professor.", "Et dans cette éventualité, vous auriez été publiquement qualifié d'imposteur, Professeur." },
            { "Exactly. Which would have been a fate worse than death\r\nfor me.\r\nBut Barok insisted that I was a proper man of science\r\nfrom start to finish.", "Précisément. Ce qui aurait été un sort pire que la mort pour moi. Mais Drake s'est obstiné à me considérer comme un homme de science authentique du début à la fin." },
            { "You, you think that's why he...?", "V-Vous croyez que c'est pour cette raison qu'il... ?" },
            { "I know him very well indeed.\r\nHe's an extremely kind-hearted soul.", "Je le connais fort bien. C'est une âme d'une générosité sans pareille." },
            { "But...that extremely kind-hearted soul...\r\n...spent all morning trying to paint you as a murderer,\r\ndidn't he?", "Mais... cette âme d'une générosité sans pareille... a passé toute sa matinée à vous dépeindre sous les traits d'un assassin, n'est-ce pas ?" },
            { "Well...admittedly, that part of the analysis appears to have\r\nsome flaws in it...", "Eh bien... certes, cette partie de l'analyse souffre manifestement de quelques lacunes..." },
            { "(And what about the whole Reaper side of things?)\r\n(How does that fit in with the ‘kind-hearted soul’ idea?)", "(Et que faire de toute cette histoire de Faucheur ? Comment concilier cela avec une âme bienveillante ?)" }
        });

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        File.WriteAllText(@"tools\Trans_Act6_Part3_A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part3_A written.");
    }
}
