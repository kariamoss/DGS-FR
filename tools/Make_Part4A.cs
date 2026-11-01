using System;
using System.IO;
using System.Text;

class Program {
    static void Main() {
        var sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace TranslatorAct5 {");
        sb.AppendLine("    public partial class Program {");
        sb.AppendLine("        public static void RegisterPart4_A() {");

        // Clé 208
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c306_0070_eng#6""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""...when I arrived at the Crystal Tower\nand saw the\nbirdcage..."", ""...lorsque je suis arrivée à la Tour de Cristal\net que j'ai vu la\ncage aux oiseaux..."");");
        sb.AppendLine(@"                s = s.Replace(""...my heart nearly stopped beating."", ""...mon cœur a presque cessé de battre."");");
        sb.AppendLine(@"                s = s.Replace(""That memory from a decade ago\nthat I'd done my best to\nbury deep inside myself..."", ""Ce souvenir d'il y a dix ans,\nque j'avais tant tenté d'enfouir\nau plus profond de moi..."");");
        sb.AppendLine(@"                s = s.Replace(""It was the Professor again,\nstaring me in the face."", ""C'était à nouveau le Démon Assassin,\nqui me fixait droit dans les yeux."");");
        sb.AppendLine(@"                s = s.Replace(""And then,\nbefore I had a chance to react,\nI noticed\nsomething else."", ""Et puis,\navant que je n'aie le temps de réagir,\nj'ai remarqué\nautre chose."");");
        sb.AppendLine(@"                s = s.Replace(""There was a note\ntucked inside the model's jacket."", ""Il y avait un mot\nglissé dans la veste du mannequin."");");
        sb.AppendLine(@"                s = s.Replace(""‘Dr Sithe,\nYou will go along with my plan.’"", ""« Dr Pétrie,\nVous allez vous plier à mon plan. »"");");
        sb.AppendLine(@"                s = s.Replace(""‘From someone who knows the truth about what really\nhappened that night\nten years ago.’"", ""« De la part de quelqu'un qui connaît la vérité sur ce qui s'est\nvraiment passé cette nuit-là,\nil y a dix ans. »"");");
        sb.AppendLine(@"                s = s.Replace(""All the instructions were there in the note.\nEvery detail was meticulously written out."", ""Toutes les instructions se trouvaient dans ce mot.\nChaque détail était méticuleusement consigné."");");
        sb.AppendLine(@"                s = s.Replace(""I had no choice but to do what it said."", ""Je n'avais d'autre choix que d'obéir."");");
        sb.AppendLine(@"                s = s.Replace(""I made the necessary ‘alterations’ to the scene\nand\nfabricated the autopsy report as instructed."", ""J'ai apporté les « retouches » nécessaires sur la scène\net j'ai\nfabriqué le rapport d'autopsie comme prescrit."");");
        sb.AppendLine(@"                s = s.Replace(""There was really no other choice.\nIt had to be done to\nprotect the judiciary."", ""Il n'y avait véritablement aucune autre issue.\nIl le fallait pour\nprotéger l'institution judiciaire."");");
        sb.AppendLine(@"                s = s.Replace(""...I can only apologise now."", ""...Je ne peux désormais que vous présenter mes excuses."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 209
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c306_0070_eng#7""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Thank you, Counsel,\nthat will do."", ""Merci, maître,\ncela suffira."");");
        sb.AppendLine(@"                s = s.Replace(""But,\nbut, My Lord,\nwait!\nThe defence is still in the process\nof establishing its argument..."", ""Mais,\nmais, Votre Honneur,\nattendez !\nLa défense n'en a pas terminé\navec son argumentation..."");");
        sb.AppendLine(@"                s = s.Replace(""No further analysis is necessary,\nI feel."", ""Aucune analyse supplémentaire n'est requise,\nselon moi."");");
        sb.AppendLine(@"                s = s.Replace(""As such,\nI shall be requesting the final decisions of the\nmembers of the jury."", ""Par conséquent,\nje vais demander l'avis définitif des\nmembres du jury."");");
        sb.AppendLine(@"                s = s.Replace(""It's been an honour to serve,\nMy Lord.\nAnd we know exactly what we think now."", ""Ce fut un honneur de siéger,\nVotre Honneur.\nEt notre décision est désormais unanime."");");
        sb.AppendLine(@"                s = s.Replace(""Guilty!"", ""Coupable !"");");
        sb.AppendLine(@"                s = s.Replace(""Mr Albert Harebrayne,\nin accordance with the findings of\nthis court,\nI pronounce you..."", ""Dr Samba Lonron,\nconformément aux délibérations de\ncette cour,\nje vous déclare..."");");
        sb.AppendLine(@"                s = s.Replace(""I applaud the jurors for doing their civic duty\nand for\nfinding a swift resolution to this matter."", ""Je félicite les jurés d'avoir accompli leur devoir civique\net d'avoir\napporté une conclusion rapide à cette affaire."");");
        sb.AppendLine(@"                s = s.Replace(""That is all.\nCourt is adjourned!"", ""C'est tout.\nLa séance est levée !"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 210
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c306_0080_eng#2""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Why on earth would you buckle now?"", ""Pourquoi diable vous dégonfler maintenant ?!"");");
        sb.AppendLine(@"                s = s.Replace(""Well\nthere's no point trying to hide it any more, is there?"", ""Eh bien,\nà quoi bon tenter de le dissimuler plus longtemps ?"");");
        sb.AppendLine(@"                s = s.Replace(""I would have done anything to stop it coming out.\nEven collaborate in a murder."", ""J'aurais tout fait pour empêcher la vérité d'éclater.\nMême tremper dans un meurtre."");");
        sb.AppendLine(@"                s = s.Replace(""But the great lie about that execution ten years ago\nhas\nbeen exposed."", ""Mais le grand mensonge autour de cette exécution d'il y a dix ans\na\nété mis au jour."");");
        sb.AppendLine(@"                s = s.Replace(""Whatever happens...\nI'm finished."", ""Quoi qu'il arrive désormais...\nje suis perdue."");");
        sb.AppendLine(@"                s = s.Replace(""So then, Mr Drebber,\nwhat do you say to that?"", ""Alors, M. Drebber,\nqu'avez-vous à répondre à cela ?"");");
        sb.AppendLine(@"                s = s.Replace(""Your accomplice\nhas admitted everything."", ""Votre complice\na tout avoué."");");
        sb.AppendLine(@"                s = s.Replace(""Surely it goes without saying."", ""Cela va pourtant de soi."");");
        sb.AppendLine(@"                s = s.Replace(""You admit your part in it too, then?"", ""Vous reconnaissez donc votre participation vous aussi ?"");");
        sb.AppendLine(@"                s = s.Replace(""I admit nothing!\nAt all!"", ""Je ne reconnais rien du tout !\nAbsolument rien !"");");
        sb.AppendLine(@"                s = s.Replace(""Wha...?!"", ""Quoi...?!"");");
        sb.AppendLine(@"                s = s.Replace(""Have you forgotten that the kinesis machine\nwas ripped\nto shreds by an explosion?"", ""Avez-vous oublié que la machine télékinétique\na été pulvérisée\npar une formidable explosion ?"");");
        sb.AppendLine(@"                s = s.Replace(""Short of me admitting to a crime,\nthere's really no\npossible way for you to prove\nI did anything wrong."", ""À moins que je n'avoue de mon propre chef,\nil vous est totalement\nimpossible de prouver\nla moindre faute de ma part."");");
        sb.AppendLine(@"                s = s.Replace(""NOOOOOOOOO!"", ""NOOOOOOON !"");");
        sb.AppendLine(@"                s = s.Replace(""Ordaaar!\nOrdaaar!\nOrdaaaaaar!!!"", ""Du caaalme !\nDu caaalme !\nSilence dans la saaaalle !!!"");");
        sb.AppendLine(@"                s = s.Replace(""Whatever this man says,\nI admit everything."", ""Quoi que prétende cet individu,\nje confesse tout."");");
        sb.AppendLine(@"                s = s.Replace(""He threatened to expose my secret,\nso I went along with\nhis plan."", ""Il a menacé de divulguer mon secret,\nalors j'ai prêté mon concours à\nson plan."");");
        sb.AppendLine(@"                s = s.Replace(""And Lord van Zieks..."", ""Et Lord Van Peers..."");");
        sb.AppendLine(@"                s = s.Replace(""Yes?"", ""Oui ?"");");
        sb.AppendLine(@"                s = s.Replace(""I hope you'll accept my apologies.\n...What happens next\nis in your hands, of course."", ""J'espère que vous accepterez mes excuses.\n...Ce qu'il adviendra par la suite\nest entre vos mains, naturellement."");");
        sb.AppendLine(@"                s = s.Replace(""I have heard more than enough now."", ""J'en ai désormais plus qu'assez entendu."");");
        sb.AppendLine(@"                s = s.Replace(""I hereby present\nthe final findings of this court."", ""Je vais à présent énoncer\nles conclusions définitives de cette cour."");");
        sb.AppendLine(@"                s = s.Replace(""This trial\nis not the proper forum in which to pursue the\nalleged wrongdoings of Mr Drebber."", ""Ce procès\nn'est pas le cadre approprié pour instruire les\nsupposés méfaits de M. Drebber."");");
        sb.AppendLine(@"                s = s.Replace(""The defendant\nis Professor Albert Harebrayne."", ""L'accusé\nest le professeur Samba Lonron."");");
        sb.AppendLine(@"                s = s.Replace(""Very true.\nIt had slipped my mind."", ""Fort juste.\nCela m'était sorti de l'esprit."");");
        sb.AppendLine(@"                s = s.Replace(""...Isn't he one of your closest friends?"", ""...N'est-il pourtant pas l'un de vos plus proches amis ?"");");
        sb.AppendLine(@"                s = s.Replace(""As the court has heard,\nDr Sithe has admitted to the\nallegations brought by the defence..."", ""Comme la cour vient de l'entendre,\nle Dr Pétrie a acquiescé aux\nallégations soulevées par la défense..."");");
        sb.AppendLine(@"                s = s.Replace(""...thereby absolving the defendant\nof any possible guilt."", ""...disculpant par là même l'accusé\nde toute culpabilité possible."");");
        sb.AppendLine(@"                s = s.Replace(""You,\nyou mean..."", ""Vous...\nvoulez dire..."");");
        sb.AppendLine(@"                s = s.Replace(""At the present time,\nit is the conclusion of this court\nthat\nthe defendant was\nnot involved\nin any wrongdoing."", ""À l'heure actuelle,\ncette cour a acquis la conviction intime\nque\nl'accusé n'a trempé dans aucun crime."");");
        sb.AppendLine(@"                s = s.Replace(""Does the prosecution have any objection?"", ""L'accusation a-t-elle la moindre objection ?"");");
        sb.AppendLine(@"                s = s.Replace(""...None,\nMy Lord."", ""...Aucune,\nVotre Honneur."");");
        sb.AppendLine(@"                s = s.Replace(""Oh, congratulations,\nMr Naruhodo!"", ""Oh, toutes mes félicitations,\nM. Naruhodo !"");");
        sb.AppendLine(@"                s = s.Replace(""You've proven Professor Harebrayne's innocence!"", ""Vous avez prouvé l'innocence du professeur Lonron !"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 211
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0000_eng#2""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Without further ado then,\nthe adjudication."", ""Sans plus tarder donc,\nle verdict."");");
        sb.AppendLine(@"                s = s.Replace(""Unless the prosecution or defence have any other matters\nto discuss?"", ""À moins que l'accusation ou la défense n'ait d'autres éléments\nà faire valoir ?"");");
        sb.AppendLine(@"                s = s.Replace(""(I don't know...\nThis doesn't feel quite right.)"", ""(Je ne sais pas...\nIl y a quelque chose qui cloche.)"");");
        sb.AppendLine(@"                s = s.Replace(""(Why did Dr Sithe\nsuddenly admit to it like that?)"", ""(Pourquoi le Dr Pétrie\na-t-elle ainsi tout avoué d'un coup ?)"");");
        sb.AppendLine(@"                s = s.Replace(""Is everything alright,\nMr Naruhodo?"", ""Tout va bien,\nM. Naruhodo ?"");");
        sb.AppendLine(@"                s = s.Replace(""Like you said before,\nthe way the trial is set to end now..."", ""Comme vous l'avez dit tout à l'heure,\nvu la tournure que prend le procès..."");");
        sb.AppendLine(@"                s = s.Replace(""...the judge will certainly deliver a verdict of not guilty."", ""...le juge va infailliblement prononcer l'acquittement."");");
        sb.AppendLine(@"                s = s.Replace(""(But is that really\nwhat we want?)"", ""(Mais est-ce vraiment\nce que nous voulons ?)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 212
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0000_eng#3""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""(What the defence should be pushing for now is...)"", ""(Ce que la défense doit réclamer maintenant, c'est...)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 213
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0000_eng#4""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""(If the judge gives his verdict now,\nProfessor Harebrayne\nwill be found not guilty,\nwithout any doubt.)"", ""(Si le juge rend son verdict maintenant,\nle professeur Lonron\nsera déclaré non coupable,\nsans le moindre doute.)"");");
        sb.AppendLine(@"                s = s.Replace(""Is something troubling you, perhaps?"", ""Quelque chose vous tourmente-t-il ?"");");
        sb.AppendLine(@"                s = s.Replace(""Yes...\nBut it's probably nothing."", ""Oui...\nMais ce n'est probablement rien."");");
        sb.AppendLine(@"                s = s.Replace(""(In the antechamber during the recess earlier...)"", ""(Dans le parloir tout à l'heure durant l'interruption...)"");");
        sb.AppendLine(@"                s = s.Replace(""(...I did give Mr Sholmes my word though,\ndidn't I?)"", ""(...j'ai pourtant donné ma parole à M. Holmes, n'est-ce pas ?)"");");
        sb.AppendLine(@"                s = s.Replace(""(I told him I'd pursue any doubts I had about the truth to\nthe absolute last.)"", ""(Je lui ai promis de poursuivre le moindre doute jusqu'à faire éclater\nla vérité absolue.)"");");
        sb.AppendLine(@"                s = s.Replace(""If you gave Mr Sholmes your word,\nthen it most certainly\nisn't nothing!"", ""Si vous avez donné votre parole à M. Holmes,\nalors ce n'est certainement\npas rien !"");");
        sb.AppendLine(@"                s = s.Replace(""And it means\nthere's only one right answer here."", ""Et cela signifie\nqu'il n'y a qu'une seule et unique bonne décision."");");
        sb.AppendLine(@"                s = s.Replace(""...Yes,\nyou're right."", ""...Oui,\nvous avez raison."");");
        sb.AppendLine(@"                s = s.Replace(""(I don't know why I was ever wavering.)"", ""(J'ignore ce qui a bien pu me faire hésiter.)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 214
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0000_eng#5""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The defence\nobjects to the trial ending at this time,\nMy Lord."", ""La défense\ns'oppose à la clôture des débats en cet instant,\nVotre Honneur."");");
        sb.AppendLine(@"                s = s.Replace(""I beg your pardon?"", ""Plaît-il ?"");");
        sb.AppendLine(@"                s = s.Replace(""We demand...\none final testimony!"", ""Nous exigeons...\nun ultime témoignage !"");");
        sb.AppendLine(@"                s = s.Replace(""WHAT?!"", ""COMMENT ?!"");");
        sb.AppendLine(@"                s = s.Replace(""You do realise I'm about to adjudicate\nin favour of your\nclient, I presume?"", ""Avez-vous bien conscience que je m'apprêtais à statuer\nen faveur de votre\nclient, jeune homme ?"");");
        sb.AppendLine(@"                s = s.Replace(""What are you playing at now,\nmy Nipponese friend?"", ""À quoi rime ce manège,\nmon cher confrère nippon ?"");");
        sb.AppendLine(@"                s = s.Replace(""Why would you want to obstruct the conclusion of the\ntrial at this point?"", ""Pourquoi vouloir entraver l'issue de ce procès\nà ce stade précis ?"");");
        sb.AppendLine(@"                s = s.Replace(""No defence lawyer in his right mind\nwould do that."", ""Aucun avocat de la défense sain d'esprit\nne ferait pareille chose."");");
        sb.AppendLine(@"                s = s.Replace(""Mr Naruhodo,\nwhat exactly are you thinking?"", ""M. Naruhodo,\nà quoi pensez-vous au juste ?"");");
        sb.AppendLine(@"                s = s.Replace(""The truth –\nthe whole truth –\nand a way to bring it all\nout into the open."", ""À la vérité –\ntoute la vérité –\net au moyen de la mettre enfin\nau grand jour."");");
        sb.AppendLine(@"                s = s.Replace(""Right!"", ""Bien dit !"");");
        sb.AppendLine(@"                s = s.Replace(""(Yes,\nin hindsight...)"", ""(Oui,\navec le recul...)"");");
        sb.AppendLine(@"                s = s.Replace(""Ah yes,\none word of warning before I go:"", ""Ah oui,\nun mot d'avertissement avant que je ne parte :"");");
        sb.AppendLine(@"                s = s.Replace(""If,\nin the course of the trial this afternoon,\nyou perceive\neven a shadow of doubt about the truth..."", ""Si,\nau cours de l'audience de cet après-midi,\nvous percevez\nne serait-ce que l'ombre d'un doute sur la vérité..."");");
        sb.AppendLine(@"                s = s.Replace(""...don't let it out of your sight.\nPursue it like a dog with a bone."", ""...ne le lâchez pas du regard.\nPoursuivez-le sans jamais démordre."");");
        sb.AppendLine(@"                s = s.Replace(""To the bitter end, you understand.\nDo not falter,\nwhatever may come to pass."", ""Jusqu'au bout, m'avez-vous compris.\nNe flanchez point,\nquoi qu'il puisse advenir."");");
        sb.AppendLine(@"                s = s.Replace(""(...I'm sure Mr Sholmes knew.)"", ""(...Je suis convaincu que M. Holmes savait.)"");");
        sb.AppendLine(@"                s = s.Replace(""(He must have deduced that this would happen.)"", ""(Il a dû déduire que les événements prendraient cette tournure.)"");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nI'm here in court to advocate for my client."", ""Oui,\nje suis devant cette cour pour défendre mon client."");");
        sb.AppendLine(@"                s = s.Replace(""And to secure an acquittal."", ""Et pour obtenir son acquittement."");");
        sb.AppendLine(@"                s = s.Replace(""Obviously."", ""C'est évident."");");
        sb.AppendLine(@"                s = s.Replace(""But that's not all.\nI believe that I have a duty to the court..."", ""Mais ce n'est pas tout.\nJ'estime avoir un devoir sacré envers cette cour..."");");
        sb.AppendLine(@"                s = s.Replace(""...to pursue the whole truth of the case\nuntil every last\ndetail is laid bare!"", ""...celui de traquer la vérité intégrale de cette affaire\njusqu'à ce que le moindre\ndétail soit mis à nu !"");");
        sb.AppendLine(@"                s = s.Replace(""And that is why the defence\ncalls for further testimony\nfrom Dr Sithe."", ""Et voilà pourquoi la défense\nréclame un témoignage complémentaire\ndu Dr Pétrie."");");
        sb.AppendLine(@"                s = s.Replace(""Testimony from me?\nAbout what?"", ""Un témoignage de ma part ?\nÀ quel propos ?"");");
        sb.AppendLine(@"                s = s.Replace(""About the nature of your collaboration\nwith Mr Enoch\nDrebber!"", ""Sur la nature exacte de votre complicité\navec M. Enoch\nDrebber !"");");
        sb.AppendLine(@"                s = s.Replace(""Hah!\nIn case it's escaped your attention,\nI've already\nadmitted to everything I did."", ""Ha !\nAu cas où cela vous aurait échappé,\nj'ai d'ores et déjà\navoué l'intégralité de mes actes."");");
        sb.AppendLine(@"                s = s.Replace(""The whole truth\nhas already been revealed."", ""La vérité tout entière\na déjà été dévoilée."");");
        sb.AppendLine(@"                s = s.Replace(""So stop wasting everyone's time."", ""Cessez donc de faire perdre son temps à tout le monde."");");
        sb.AppendLine(@"                s = s.Replace(""Agh!"", ""Argh !"");");
        sb.AppendLine(@"                s = s.Replace(""As His Lordship made very plain,\nyour client will get the\nacquittal you wanted for him."", ""Comme Sa Seigneurie l'a très clairement stipulé,\nvotre client bénéficiera de l'acquittement\nque vous convoitiez tant."");");
        sb.AppendLine(@"                s = s.Replace(""There's simply no point protracting this business further\nwith another tedious cross-examination."", ""Il n'y a nul intérêt à prolonger ce procès\navec un énième et fastidieux contre-interrogatoire."");");
        sb.AppendLine(@"                s = s.Replace(""...Pray forgive my careless handling of that hallowed\nbottle.\nI slipped."", ""...Veuillez pardonner ma maladresse avec cette vénérable\nbouteille.\nMa main a glissé."");");
        sb.AppendLine(@"                s = s.Replace(""(That's what you call it?)"", ""(C'est comme ça qu'il appelle ça ?)"");");
        sb.AppendLine(@"                s = s.Replace(""W-\nWhat is your objection, Lord van Zieks?"", ""Q-\nQuelle est votre objection, Lord Van Peers ?"");");
        sb.AppendLine(@"                s = s.Replace(""The prosecution..."", ""L'accusation..."");");
        sb.AppendLine(@"                s = s.Replace(""...also calls for supplementary testimony from the witness."", ""...exige également un témoignage supplémentaire du témoin."");");
        sb.AppendLine(@"                s = s.Replace(""Don't be stupid!"", ""Ne soyez pas stupide !"");");
        sb.AppendLine(@"                s = s.Replace(""If there is more to this case than has yet come to light..."", ""S'il reste des zones d'ombre dans cette affaire..."");");
        sb.AppendLine(@"                s = s.Replace(""...then I will join my learned friend in pursuing the facts\nuntil the bitter end."", ""...je me joindrai à mon confrère pour en élucider les faits\njusqu'au dénouement absolu."");");
        sb.AppendLine(@"                s = s.Replace(""You'll what...?"", ""Vous ferez quoi... ?"");");
        sb.AppendLine(@"                s = s.Replace(""Lord van Zieks..."", ""Lord Van Peers..."");");
        sb.AppendLine(@"                s = s.Replace(""This is most irregular, to say the least."", ""Voilà qui est des plus singuliers, pour ne pas dire irrégulier."");");
        sb.AppendLine(@"                s = s.Replace(""However,\nas the prosecution also calls for it,\nI will uphold\nthe request."", ""Néanmoins,\nl'accusation en faisant également la demande,\nj'accède à cette\nrequête."");");
        sb.AppendLine(@"                s = s.Replace(""Dr Sithe,\nyou will testify for the court..."", ""Dr Pétrie,\nvous allez déposer devant cette cour..."");");
        sb.AppendLine(@"                s = s.Replace(""...explaining the full extent of your involvement\nin the\nmurder apparently committed by Mr Drebber."", ""...pour expliciter toute l'étendue de votre implication\ndans le meurtre\napparemment perpétré par M. Drebber."");");
        sb.AppendLine(@"                s = s.Replace(""I...\n...Very well."", ""Je...\n...Bien, Votre Honneur."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 215
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0010_eng#2""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""– The Waxwork Plot –"", ""– Le complot de cire –"");");
        sb.AppendLine(@"                s = s.Replace(""It all began at the scene when I saw the waxwork and the\nnote tucked inside its jacket."", ""Tout a commencé sur les lieux quand j'ai aperçu la statue de cire et le\nmot dissimulé dans sa veste."");");
        sb.AppendLine(@"                s = s.Replace(""The actual body of the victim,\nas indicated in the note's\ninstructions,\nwas beneath the experimentation stage."", ""Le corps véritable de la victime,\ncomme l'indiquaient les instructions\ndu mot,\ngisait sous la scène d'expérimentation."");");
        sb.AppendLine(@"                s = s.Replace(""The body had to be ‘arranged’ in certain ways to\nimplicate the defendant...\nwhich was my job."", ""Le cadavre devait être « maquillé » de manière\nà accuser le professeur...\nce qui était ma mission."");");
        sb.AppendLine(@"                s = s.Replace(""I enlisted the help of the entire Forensic Investigation\nTeam to dress the scene appropriately."", ""J'ai réquisitionné l'ensemble de l'équipe médico-légale\npour préparer la scène comme il se devait."");");
        sb.AppendLine(@"                s = s.Replace(""The truth about the execution ten years ago is a state\nsecret of the highest level.\nI had to protect it."", ""La vérité quant à l'exécution d'il y a dix ans relève du\nsecret d'État le plus absolu.\nJe devais la protéger à tout prix."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 216
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0010_eng#3""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""So I was right:\nthe stage and the machine were all\nspecially designed for the deception."", ""J'avais donc vu juste :\nla scène et la machine étaient toutes deux\nspécialement conçues pour cette supercherie."");");
        sb.AppendLine(@"                s = s.Replace(""So it seems.\nAnd all meticulously prepared.\nYou did well to see through it."", ""C'est exact.\nEt tout a été méticuleusement préparé.\nBeau travail pour avoir percé ce mystère."");");
        sb.AppendLine(@"                s = s.Replace(""You're a very shrewd boy."", ""Vous êtes un jeune homme particulièrement perspicace."");");
        sb.AppendLine(@"                s = s.Replace(""So kind of you to say..."", ""C'est bien aimable à vous..."");");
        sb.AppendLine(@"                s = s.Replace(""And what about this autopsy report, then?"", ""Et qu'en est-il donc de ce rapport d'autopsie ?"");");
        sb.AppendLine(@"                s = s.Replace(""All I did was record the location of the body as being in\nthe Crystal Tower\ninstead of under the stage."", ""Je me suis contentée d'indiquer que le corps se trouvait dans\nla Tour de Cristal\nau lieu de sous l'estrade."");");
        sb.AppendLine(@"                s = s.Replace(""That's all...?\nThat's a terrible corruption!"", ""C'est tout... ?!\nMais c'est une altération gravissime !"");");
        sb.AppendLine(@"                s = s.Replace(""Only my team were aware of the deceit,\nand then\nonly\nunder my explicit instructions."", ""Seule mon équipe était au courant de ce subterfuge,\net encore,\nuniquement\nsous mes ordres formels."");");
        sb.AppendLine(@"                s = s.Replace(""Nobody else at Scotland Yard knew anything about it,\nI\nassure you."", ""Nul autre à Scotland Yard n'en a eu vent,\nje vous\nl'assure."");");
        sb.AppendLine(@"                s = s.Replace(""Hm...\nwe must be thankful for small mercies,\nI suppose."", ""Hum...\nestimons-nous heureux de cet infime soulagement,\nj'imagine."");");
        sb.AppendLine(@"                s = s.Replace(""Well,\nI believe that testimony has clarified everything."", ""Bien,\nj'estime que ce témoignage a tout clarifié."");");
        sb.AppendLine(@"                s = s.Replace(""There's no particular need for a cross-examination,\nI\nwould say..."", ""Un contre-interrogatoire ne s'impose guère,\nme semble-t-il..."");");
        sb.AppendLine(@"                s = s.Replace(""(No,\nI disagree.\nI can't shake the feeling that something's wrong.)"", ""(Non,\nje ne suis pas d'accord.\nJ'ai la conviction profonde que quelque chose cloche.)"");");
        sb.AppendLine(@"                s = s.Replace(""(Just look at that expression on Dr Sithe's face.)"", ""(Regardez seulement l'expression sur le visage du Dr Pétrie.)"");");
        sb.AppendLine(@"                s = s.Replace(""It's the defence's right\nto cross-examine any witness\nfollowing testimony!"", ""C'est le droit inaliénable de la défense\nde contre-interroger tout témoin\naprès sa déposition !"");");
        sb.AppendLine(@"                s = s.Replace(""Tsk!\nWhat is it about you Japanese\nthat makes you all so\ndoggedly persistent?"", ""Tss !\nQu'avez-vous donc, vous autres Japonais,\npour vous obstiner ainsi\navec un tel acharnement ?"");");
        sb.AppendLine(@"                s = s.Replace(""Very well.\nIf you so desire, Counsel,\nproceed with the\ncross-examination!"", ""Soit.\nSi vous le désirez tant, maître,\nprocédez au\ncontre-interrogatoire !"");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nMy Lord!"", ""Bien,\nVotre Honneur !"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 217
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#2""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""– The Waxwork Plot –"", ""– Le complot de cire –"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clés 218 à 224 (dépositions du cross-exam)
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#4""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""It all began at the scene when I saw the waxwork and the\nnote tucked inside its jacket."", ""Tout a commencé sur les lieux quand j'ai aperçu la statue de cire et le\nmot dissimulé dans sa veste."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#5""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The actual body of the victim, as indicated in the note's\ninstructions, was beneath the experimentation stage."", ""Le corps véritable de la victime, comme l'indiquaient les instructions\ndu mot, gisait sous la scène d'expérimentation."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#6""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The body had to be ‘arranged’ in certain ways to\nimplicate the defendant...which was my job."", ""Le cadavre devait être « maquillé » de manière\nà accuser le professeur... ce qui était ma mission."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#7""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The actual cause of death was the neck trauma Asman\nsuffered from the thirty-foot fall."", ""La cause réelle du décès était le traumatisme cervical subi par Asman\nlors de sa chute de près de dix mètres."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#8""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""I stood over the victim's corpse where it lay in the\ntoppled cage and plunged the screwdriver into the chest."", ""Je me suis penchée sur le cadavre couché dans la\ncage renversée et j'ai enfoncé le tournevis dans sa poitrine."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#9""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""I enlisted the help of the entire Forensic Investigation\nTeam to dress the scene appropriately."", ""J'ai réquisitionné l'ensemble de l'équipe médico-légale\npour préparer la scène comme il se devait."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#10""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The truth about the execution ten years ago is a state\nsecret of the highest level. I had to protect it."", ""La vérité quant à l'exécution d'il y a dix ans relève du\nsecret d'État le plus absolu. Je devais la protéger à tout prix."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 225
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#11""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""From what you described before,\nit sounds like the note\nwas anonymous."", ""D'après votre récit précédent,\nil semblerait que ce mot\nétait anonyme."");");
        sb.AppendLine(@"                s = s.Replace(""Did you have any idea of who was behind it?"", ""Aviez-vous la moindre idée de son auteur ?"");");
        sb.AppendLine(@"                s = s.Replace(""There are very few people in the know about what really\nhappened ten years ago to start with."", ""Pour commencer, très peu de personnes savent ce qu'il s'est réellement\npassé cette nuit-là il y a dix ans."");");
        sb.AppendLine(@"                s = s.Replace(""But anyway,\nI'd never heard of this engineer.\nSo no,\nI had no idea."", ""Mais de toute façon,\nje n'avais jamais entendu parler de cet ingénieur.\nDonc non,\nje n'en avais aucune idée."");");
        sb.AppendLine(@"                s = s.Replace(""Yet despite not knowing who was behind the plan,\nyou\nwent along with it?"", ""Et pourtant, sans savoir qui tirait les ficelles,\nvous\navez obtempéré ?"");");
        sb.AppendLine(@"                s = s.Replace(""I had no choice.\nProtecting the Professor secret was my\nonly concern."", ""Je n'avais pas le choix.\nProtéger le secret du Démon Assassin était ma\nseule préoccupation."");");
        sb.AppendLine(@"                s = s.Replace(""But the horse has bolted now.\nAnd the stable door\nwill never shut again."", ""Mais les dés sont jetés à présent.\nEt ce qui a été révélé\nne pourra plus jamais être enfoui."");");
        sb.AppendLine(@"                s = s.Replace(""Scotland Yard's reputation\nwill be immeasurably damaged\nas a result of all this."", ""La réputation de Scotland Yard\nen sortira irrémédiablement souillée\naprès un tel scandale."");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nthank you, Lord van Zieks.\nI'm well aware of that."", ""Oui,\nmerci, Lord Van Peers.\nJ'en suis parfaitement consciente."");");
        sb.AppendLine(@"                s = s.Replace(""So, as I understand it,\nwhat you found in the birdcage\nwas\nthe waxwork model.\nWhere, then,\nwas the victim's body?"", ""Ainsi donc, si je comprends bien,\nce que vous avez découvert dans la cage\nétait\nle mannequin de cire.\nOù se trouvait donc,\nle corps de la victime ?"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 226
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#12""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""So you knew about the special construction of the stage\nused to carry out the trick, then?"", ""Vous étiez donc informée de l'agencement spécial de la scène\nutilisée pour ce tour d'illusionnisme ?"");");
        sb.AppendLine(@"                s = s.Replace(""It\nwas quite obvious what had happened with the victim\nand the waxwork."", ""Ce qui s'était produit avec la victime\net la statue de cire sautait aux yeux."");");
        sb.AppendLine(@"                s = s.Replace(""And you\nswitched\nthe two over, didn't you?\nIn other words..."", ""Et vous avez\néchangé\nles deux, n'est-ce pas ?\nEn d'autres termes..."");");
        sb.AppendLine(@"                s = s.Replace(""...you recorded the victim's body as having been\ndiscovered in the Crystal Tower.\nAnd the waxwork...?"", ""...vous avez consigné que le cadavre avait été\ndécouvert dans la Tour de Cristal.\nEt la statue de cire... ?"");");
        sb.AppendLine(@"                s = s.Replace(""I wrapped it and sent it by carriage to the specified\naddress\nat the specified time."", ""Je l'ai emballée et expédiée par fiacre à l'adresse indiquée,\nà l'horaire précis stipulé dans le mot."");");
        sb.AppendLine(@"                s = s.Replace(""And why were you given such directions?"", ""Et pourquoi vous avait-on donné de telles instructions ?"");");
        sb.AppendLine(@"                s = s.Replace(""Presumably\nso it could be recovered by Drebber\nand\nreturned to Madame Tusspells."", ""Sans doute\npour que Drebber puisse la récupérer\net\nla restituer à Madame Pétrie."");");
        sb.AppendLine(@"                s = s.Replace(""I see.\nAnd then you put the birdcage back on the\nexperimentation stage?"", ""Je vois.\nEt ensuite, vous avez replacé la cage à oiseaux sur\nla scène d'expérimentation ?"");");
        sb.AppendLine(@"                s = s.Replace(""Yes.\nAlthough someone obviously made a mistake about\nwhich cage should go where."", ""Oui.\nBien que quelqu'un ait visiblement commis une bourde quant à\nl'emplacement respectif de chaque cage."");");
        sb.AppendLine(@"                s = s.Replace(""I thought I'd made it perfectly clear to the team,\nbut still..."", ""Je pensais pourtants avoir été claire avec mes hommes,\nmais passons..."");");
        sb.AppendLine(@"                s = s.Replace(""I suppose\nyou were focused on the victim's body,\nthat\nbeing a more important detail."", ""J'imagine que\nvotre attention était mobilisée par le cadavre,\nce qui était\nautrement plus crucial."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 227
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#13""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""When you say ‘arranged’,\nI presume you mean\nwith this?"", ""Quand vous dites « maquillé »,\nj'imagine que vous voulez dire\navec ceci ?"");");
        sb.AppendLine(@"                s = s.Replace(""Yes.\nThe instructions in the engineer's note said\nsomething along the lines of:"", ""Oui.\nLes consignes dans le mot de l'ingénieur disaient\nquelque chose du genre :"");");
        sb.AppendLine(@"                s = s.Replace(""‘Fabricate some evidence to make it clear\nthat\nHarebrayne alone could have killed Asman.’"", ""« Fabriquez un indice démontrant sans équivoque\nque\nseul Lonron a pu assassiner Asman. »"");");
        sb.AppendLine(@"                s = s.Replace(""So...you mean\nthat was your doing?"", ""Alors... vous voulez dire\nque c'était votre œuvre ?"");");
        sb.AppendLine(@"                s = s.Replace(""I fetched Harebrayne's ridiculous screwdriver from the\nstage..."", ""Je suis allée chercher le ridicule tournevis de Lonron sur\nl'estrade..."");");
        sb.AppendLine(@"                s = s.Replace(""...and took it with me –\nalone –\nto the ‘abyss’ under the\nstage where the birdcage had fallen."", ""...et je l'ai apporté avec moi –\nseule –\ndans la fosse sous la\nscène où la cage s'était écrasée."");");
        sb.AppendLine(@"                s = s.Replace(""Alone,\nDoctor?"", ""Seule,\nDocteur ?"");");
        sb.AppendLine(@"                s = s.Replace(""I didn't feel it would be appropriate to involve anybody\nelse in that particular part of the deception."", ""Je n'estimais pas opportun d'impliquer quiconque\nd'autre dans cette étape précise du forfait."");");
        sb.AppendLine(@"                s = s.Replace(""There was a void under the stage where\nI found the birdcage lying in the dirt."", ""Il y avait une fosse sous la scène où\nj'ai trouvé la cage gisant dans la poussière."");");
        sb.AppendLine(@"                s = s.Replace(""I approached it,\nleaned down\nand slowly opened it up."", ""Je me suis approchée,\nje me suis penchée\net j'ai lentement ouvert la porte."");");
        sb.AppendLine(@"                s = s.Replace(""Then\nI took the screwdriver in both hands...\nand plunged it into the man's chest!"", ""Puis\nj'ai saisi le tournevis à deux mains...\net je l'ai enfoncé en plein dans la poitrine de l'homme !"");");
        sb.AppendLine(@"                s = s.Replace(""And then you noted that in your fake autopsy report...\n...as a fictitious cause of death."", ""Et vous avez ensuite consigné cela dans votre faux rapport...\n...comme étant la cause fictive du décès."");");
        sb.AppendLine(@"                s = s.Replace(""Exactly."", ""Parfaitement."");");
        sb.AppendLine(@"                s = s.Replace(""So\nthe actual cause of death was...?"", ""Alors\nla cause véritable du décès était... ?"");");
        sb.AppendLine(@"                s = s.Replace(""The trauma resulting from the thirty-foot drop."", ""Le traumatisme causé par cette chute de près de dix mètres."");");
        sb.AppendLine(@"                s = s.Replace(""My word..."", ""Grand Dieu..."");");
        sb.AppendLine(@"                s = s.Replace(""What is it,\nMiss Susato?"", ""Qu'y a-t-il,\nMlle Susato ?"");");
        sb.AppendLine(@"                s = s.Replace(""Something about Dr Sithe's last statement...\n...is playing on my mind,\nthat's all."", ""Il y a quelque chose dans la dernière déclaration du Dr Pétrie...\n...qui me tracasse l'esprit,\nc'est tout."");");
        sb.AppendLine(@"                s = s.Replace(""Yes...\nmine too."", ""Oui...\nmoi aussi."");");
        sb.AppendLine(@"                s = s.Replace(""Dr Sithe!"", ""Dr Pétrie !"");");
        sb.AppendLine(@"                s = s.Replace(""There's really no need to shout.\nI can hear you perfectly well."", ""Il n'est vraiment pas nécessaire de crier.\nJe vous entends parfaitement."");");
        sb.AppendLine(@"                s = s.Replace(""The defence calls for you to add\nwhat you just said to\nyour formal testimony!"", ""La défense exige que vous ajoutiez\nce que vous venez d'affirmer\nà votre déposition officielle !"");");
        sb.AppendLine(@"                s = s.Replace(""Oh?\nWhich part?"", ""Vraiment ?\nQuelle partie ?"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 228
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#14""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""(What I want her to supplement her testimony with is...)"", ""(Ce que je souhaite qu'elle ajoute à son témoignage, c'est...)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 229
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#15""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The real cause of death being the fall of thirty feet!\nThat part!"", ""Que la véritable cause du décès était la chute de dix mètres !\nC'est cette partie !"");");
        sb.AppendLine(@"                s = s.Replace(""Fine,\nif that's what you want.\nJust stop yelling, please."", ""Soit,\nsi c'est ce que vous exigez.\nCessez de hurler, je vous prie."");");
        sb.AppendLine(@"                s = s.Replace(""...The prosecution\nconcurs."", ""...L'accusation\ny souscrit."");");
        sb.AppendLine(@"                s = s.Replace(""Very well.\nYou will supplement your testimony now,\nwitness."", ""Fort bien.\nComplétez votre témoignage sur-le-champ,\ntémoin."");");
        sb.AppendLine(@"                s = s.Replace(""If you wish,\nMy Lord."", ""Comme vous l'ordonnez,\nVotre Honneur."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 230
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#16""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""How you stabbed Mr Asman in the chest!\nThat part!"", ""La manière dont vous avez poignardé M. Asman à la poitrine !\nC'est cette partie !"");");
        sb.AppendLine(@"                s = s.Replace(""Fine,\nif that's what you want.\nBut there's really no need to point."", ""Soit,\nsi c'est ce que vous désirez.\nMais il n'est nullement séant de me pointer du doigt."");");
        sb.AppendLine(@"                s = s.Replace(""...The prosecution...\nconcurs."", ""...L'accusation...\ny souscrit."");");
        sb.AppendLine(@"                s = s.Replace(""Very well.\nYou will supplement your testimony now,\nwitness."", ""Fort bien.\nComplétez votre témoignage sur-le-champ,\ntémoin."");");
        sb.AppendLine(@"                s = s.Replace(""If you wish,\nMy Lord."", ""Comme vous l'ordonnez,\nVotre Honneur."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 231
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#17""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""You mean what you did with this,\ncorrect?"", ""Vous parlez de ce que vous avez commis avec ceci,\nn'est-ce pas ?"");");
        sb.AppendLine(@"                s = s.Replace(""I was merely carrying out the engineer's instructions.\nIn his words:"", ""Je n'ai fait qu'exécuter les consignes de l'ingénieur.\nSelon ses propres termes :"");");
        sb.AppendLine(@"                s = s.Replace(""‘Fabricate some evidence to make it clear\nthat\nHarebrayne alone could have killed Asman.’"", ""« Fabriquez un indice démontrant sans équivoque\nque\nseul Lonron a pu assassiner Asman. »"");");
        sb.AppendLine(@"                s = s.Replace(""And so you went,\nwithout any of your team,\nto where\nAsman had fallen."", ""Et vous vous êtes donc rendue,\nsans aucun membre de votre équipe,\nlà où\nAsman s'était écrasé."");");
        sb.AppendLine(@"                s = s.Replace(""That's right,\nyes."", ""C'est exact,\noui."");");
        sb.AppendLine(@"                s = s.Replace(""I leaned down over the birdcage\nand opened it up."", ""Je me suis penchée sur la cage à oiseaux\net j'ai ouvert sa porte."");");
        sb.AppendLine(@"                s = s.Replace(""Then\nI took the screwdriver in both hands...\nand plunged it into the man's chest!"", ""Puis\nj'ai saisi le tournevis à deux mains...\net je l'ai enfoncé dans la poitrine de l'homme !"");");
        sb.AppendLine(@"                s = s.Replace(""After that,\nit was simply a matter of recording the stab\nwound as the cause of death on the autopsy report."", ""Après cela,\nil suffisait d'inscrire la blessure à l'arme blanche\ncomme cause du décès sur le rapport d'autopsie."");");
        sb.AppendLine(@"                s = s.Replace(""The real cause of death being the fall,\nof course."", ""La cause réelle de la mort étant bien sûr la chute."");");
        sb.AppendLine(@"                s = s.Replace(""(I'm sure there's something here in this testimony...)"", ""(Je suis certain qu'il y a un détail crucial dans cette déposition...)"");");
        sb.AppendLine(@"                s = s.Replace(""You know,\nif you think it would be appropriate..."", ""Vous savez,\nsi vous estimez que cela est nécessaire..."");");
        sb.AppendLine(@"                s = s.Replace(""...I'm sure you could ask Dr Sithe to change the\nsupplementary testimony she gave before."", ""...je pense que vous pourriez demander au Dr Pétrie de modifier\nla déposition complémentaire qu'elle a ajoutée."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 232
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#18""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""(Hm,\nwhat should I ask her to do with the statement she\nadded?)"", ""(Hum,\nque devrais-je lui demander concernant la phrase\nqu'elle a ajoutée ?)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 233
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#21""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Dr Sithe,\nwhat you said before about the real cause of\ndeath..."", ""Dr Pétrie,\nce que vous disiez tout à l'heure sur la cause réelle\ndu décès..."");");
        sb.AppendLine(@"                s = s.Replace(""I believe that may be significant,\nso could you change\nyour supplementary statement to explain that instead?"", ""J'ai le pressentiment que cela est capital,\npourriez-vous reformuler\nvotre phrase ajoutée pour expliquer ce détail ?"");");
        sb.AppendLine(@"                s = s.Replace(""I don't think\nthere's any need to ask her to change it."", ""Je ne pense pas\nqu'il soit nécessaire de lui demander de changer."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 234
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#22""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Dr Sithe,\nwhat you said before about what you did to the\nvictim's body..."", ""Dr Pétrie,\nce que vous disiez tout à l'heure sur ce que vous avez fait au\ncorps de la victime..."");");
        sb.AppendLine(@"                s = s.Replace(""I believe that may be significant,\nso could you change\nyour supplementary statement to explain that instead?"", ""J'ai le pressentiment que cela est capital,\npourriez-vous reformuler\nvotre phrase ajoutée pour expliquer ce détail ?"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 235
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#23""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""I don't think\nthere's any need to ask her to change it."", ""Je ne pense pas\nqu'il soit nécessaire de lui demander de la changer."");");
        sb.AppendLine(@"                s = s.Replace(""Of course,\nI'm sure you're right."", ""Bien sûr,\nje suis certaine que vous avez raison."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 236
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#24""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""You're quite sure of that?\nIt was as a result of a broken neck?"", ""Vous en êtes absolument certaine ?\nC'était la conséquence d'une nuque brisée ?"");");
        sb.AppendLine(@"                s = s.Replace(""Yes.\nAs a professional,\nthat was more than apparent."", ""Oui.\nPour une professionnelle,\nc'était plus qu'évident."");");
        sb.AppendLine(@"                s = s.Replace(""You'd never know\njust by looking at the photograph of the\nvictim though,\nwould you?"", ""On ne le devinerait jamais\nsimplement en observant la photographie de la\nvictime,\nn'est-ce pas ?"");");
        sb.AppendLine(@"                s = s.Replace(""No,\nthat's very true."", ""Non,\nc'est très vrai."");");
        sb.AppendLine(@"                s = s.Replace(""Obviously not."", ""Évidemment non."");");
        sb.AppendLine(@"                s = s.Replace(""Which is precisely why coroners are needed to\ndetermine the actual facts."", ""C'est précisément la raison pour laquelle les médecins légistes sont requis\npour attester des faits réels."");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nassuming they can be trusted."", ""Oui,\nà supposer qu'on puisse leur faire confiance."");");
        sb.AppendLine(@"                s = s.Replace(""There's no point calling her assessment into question\nwithout evidence.\nLet's get back to the testimony."", ""Inutile de contester ses conclusions d'experte\nsans la moindre preuve tangible.\nRevenons-en au témoignage."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 237
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#25""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""So it was you who stabbed Asman with this!"", ""C'est donc vous qui avez poignardé Asman avec ceci !"");");
        sb.AppendLine(@"                s = s.Replace(""Yes.\nFar easier than dissection, I assure you."", ""Oui.\nBien plus aisé qu'une dissection, croyez-moi."");");
        sb.AppendLine(@"                s = s.Replace(""No precision required."", ""Nulle précision requise."");");
        sb.AppendLine(@"                s = s.Replace(""What a welcome change..."", ""Un changement fort appréciable..."");");
        sb.AppendLine(@"                s = s.Replace(""The victim died instantly from a snapped neck."", ""La victime a péri sur le coup d'une nuque brisée net."");");
        sb.AppendLine(@"                s = s.Replace(""All I did was carry out the instructions I'd been given."", ""Je n'ai fait qu'accomplir les consignes reçues."");");
        sb.AppendLine(@"                s = s.Replace(""As unflinchingly as ever,\nno doubt."", ""Avec votre impassibilité coutumière,\nsans l'ombre d'un doute."");");
        sb.AppendLine(@"                s = s.Replace(""I imagine you didn't bat an eyelid\nwhen you drove the\nweapon into his body."", ""J'imagine que vous n'avez pas cillé d'un millimètre\nen plantant cette arme\ndans sa chair."");");
        sb.AppendLine(@"                s = s.Replace(""There was no need to bat my eyelids."", ""Je n'avais aucune raison de ciller."");");
        sb.AppendLine(@"                s = s.Replace(""And what else did you do to twist the facts?\nRemind the court,\nwhy don't you?"", ""Et qu'avez-vous commis d'autre pour travestir la vérité ?\nRappelez-le donc à cette cour,\nje vous prie."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 238
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#26""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""The entire team?\nIn perverting the course of justice?"", ""L'équipe tout entière ?!\nPour entraver le cours de la justice ?!"");");
        sb.AppendLine(@"                s = s.Replace(""My team consists of the very best investigators there are."", ""Mon équipe est composée des meilleurs experts du royaume."");");
        sb.AppendLine(@"                s = s.Replace(""I demand loyalty from all members.\nWe operate on a code of chivalry of sorts."", ""J'exige une loyauté sans faille de chacun de mes membres.\nNous obéissons à une sorte de code de chevalerie."");");
        sb.AppendLine(@"                s = s.Replace(""You aid and abet a murderer,\ncommit perjury\nand dare\nto talk of chivalry?!"", ""Vous prêtez main-forte à un meurtrier,\nvous parjurez effrontément,\net vous osez\nparler de chevalerie ?!"");");
        sb.AppendLine(@"                s = s.Replace(""It was\na matter of priorities."", ""Ce n'était\nqu'une question de priorités."");");
        sb.AppendLine(@"                s = s.Replace(""Nothing was more important\nthan protecting the secret of\nthe Professor."", ""Rien n'était plus vital\nque de préserver le secret entourant\nle Démon Assassin."");");
        sb.AppendLine(@"                s = s.Replace(""My team did what was necessary\nwithout losing sight of\nthe primary goal.\nI consider their conduct\nexemplary."", ""Mon équipe a fait le nécessaire\nsans jamais perdre de vue\nl'objectif suprême.\nJe tiens leur conduite\npour exemplaire."");");
        sb.AppendLine(@"                s = s.Replace(""Ugh..."", ""Argh..."");");
        sb.AppendLine(@"                s = s.Replace(""Don't concede the point, Mr Naruhodo!\nYou mustn't let her win!"", ""Ne cédez pas de terrain, M. Naruhodo !\nNe la laissez pas avoir le dernier mot !"");");
        sb.AppendLine(@"                s = s.Replace(""(I need a lawyer...)"", ""(J'aurais bien besoin d'un avocat...)"");");
        sb.AppendLine(@"                s = s.Replace(""I'll take that silence as tacit acceptance.\nNow...\ncan we move on?"", ""Je prendrai ce silence pour un acquiescement tacite.\nÀ présent...\npouvons-nous passer à la suite ?"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 239
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#27""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""But at what cost?\nFaith in Scotland Yard is going to suffer\na terrible blow as a result of this."", ""Mais à quel prix ?!\nLa confiance populaire envers Scotland Yard essuiera\nun revers cataclysmique suite à cela !"");");
        sb.AppendLine(@"                s = s.Replace(""And\nyour precious secret is out now anyway."", ""Et de toute façon,\nvotre précieux secret est éventé à présent."");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nas you say.\nAnd I take full responsibility."", ""Oui,\ncomme vous le dites.\nEt j'en assume l'entière responsabilité."");");
        sb.AppendLine(@"                s = s.Replace(""Blow me down...\nDr Sithe!"", ""Ça alors...\nDr Pétrie !"");");
        sb.AppendLine(@"                s = s.Replace(""Surely there was some other way you could have\nprotected the secret?"", ""N'y avait-il vraiment aucune autre issue pour protéger\nce secret d'État ?"");");
        sb.AppendLine(@"                s = s.Replace(""No,\nthere really wasn't.\nI've done my utmost,\nbelieve me."", ""Non,\naucune autre.\nJ'ai fait tout ce qui était en mon pouvoir,\ncroyez-moi."");");
        sb.AppendLine(@"                s = s.Replace(""In many ways,\nI respect your determination."", ""À bien des égards,\nj'admire votre détermination."");");
        sb.AppendLine(@"                s = s.Replace(""Whew.\nI nearly froze under that cold stare as she said\nthat."", ""Ouf.\nJ'ai failli me pétrifier sous ce regard de glace lorsqu'elle\na prononcé ces mots."");");
        sb.AppendLine(@"                s = s.Replace(""I do believe she was being genuine though,\nMr Naruhodo."", ""Je crois pourtant qu'elle était sincère,\nM. Naruhodo."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 240
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#33""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Thank you, Counsel,\nthat will do."", ""Merci, maître,\ncela suffira."");");
        sb.AppendLine(@"                s = s.Replace(""Guilty!"", ""Coupable !"");");
        sb.AppendLine(@"                s = s.Replace(""Court is adjourned!"", ""La séance est levée !"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 241
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#35""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""(So that's her story...)"", ""(Voilà donc sa version des faits...)"");");
        sb.AppendLine(@"                s = s.Replace(""She's admitted everything\nand revealed her full\ninvolvement in the crime."", ""Elle a tout avoué\net révélé sa participation intégrale\nau forfait."");");
        sb.AppendLine(@"                s = s.Replace(""I do wonder if there could really be much more to it."", ""Je me demande s'il peut réellement subsister autre chose."");");
        sb.AppendLine(@"                s = s.Replace(""Well,\nI don't know.\nBut...\nI just have a feeling."", ""Eh bien,\nje l'ignore.\nMais...\nj'ai une drôle d'intuition."");");
        sb.AppendLine(@"                s = s.Replace(""Do you, Mr Naruhodo?\nThe truth is,\nI find it strange, too."", ""Vraiment, M. Naruhodo ?\nÀ vrai dire,\nje trouve cela étrange moi aussi."");");
        sb.AppendLine(@"                s = s.Replace(""How those two are reacting to this\nin completely\nopposite ways, I mean."", ""Cette divergence flagrante dans la façon dont ces deux-là réagissent,\nje veux dire."");");
        sb.AppendLine(@"                s = s.Replace(""Yes,\nexactly."", ""Oui,\nexactement."");");
        sb.AppendLine(@"                s = s.Replace(""(For some reason,\nI feel sure they're still trying to hide\nsomething...)"", ""(J'ai la conviction profonde qu'ils essaient encore\nde nous dissimuler quelque chose...)"");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        // Clé 242
        sb.AppendLine(@"            entryTranslators[@""BB\script\output\_sce02_c307_0020_eng#38""] = s => {");
        sb.AppendLine(@"                s = s.Replace(""Mr Drebber!\nIs something wrong?"", ""M. Drebber !\nUn problème ?"");");
        sb.AppendLine(@"                s = s.Replace(""Mr Drebber!"", ""M. Drebber !"");");
        sb.AppendLine(@"                s = s.Replace(""It would appear his only answer\nis that rather bewitching\nmechanical wiggle."", ""Il semblerait que son unique réponse\nsoit ce fascinant déhanchement\nmécanique."");");
        sb.AppendLine(@"                s = s.Replace(""...He could have just said no."", ""...Il aurait pu se contenter de dire non."");");
        sb.AppendLine(@"                return s;");
        sb.AppendLine(@"            };");

        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(@"tools\Trans_Act5_Part4_A.cs", sb.ToString(), Encoding.UTF8);
        Console.WriteLine("Part4_A generated successfully.");
    }
}
