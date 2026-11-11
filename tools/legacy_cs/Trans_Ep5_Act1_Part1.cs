using System;
using System.Collections.Generic;

namespace TranslatorEp5Act1 {
    public partial class Program {
        public static void RegisterPart1() {

            // [0] BB\script\output\_sce04_c100_0000_eng#6
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#6"] = (s) => {
                s = s.Replace("3rd November, 9:14 a.m.\r\n<CNTR><E003 5>The Old Bailey, Defendants' Antechamber", "3 novembre, 9 h 14\r\n<CNTR><E003 5>Old Bailey, antichambre des accusés");
                s = s.Replace("(So...<E003 12>the time's finally come.)", "(Ça y est...<E003 12>l'heure est enfin venue.)");
                s = s.Replace("(Today...<E003 14><E025 1><E338><E341>we unravel everything!)", "(Aujourd'hui...<E003 14><E025 1><E338><E341>nous ferons toute la lumière sur cette affaire !)");
                s = s.Replace("I'll be counting on your support more than ever today,<E003 8>\r\nMiss Susato!", "Je compte sur votre soutien plus que jamais aujourd'hui,<E003 8>\r\nmademoiselle Susato !");
                s = s.Replace("Um...<E003 12>Miss Susato?", "Euh...<E003 12>mademoiselle Susato ?");
                s = s.Replace("<E606>Oh no!<E049><E003 15>\r\n<E025 1>W-<E049><E003 10><E331>What's the matter, <E049><E003 4><E341>Mr Naruhodo?", "<E606>Oh non !<E049><E003 15>\r\n<E025 1>Q-<E049><E003 10><E331>Qu'y a-t-il, <E049><E003 4><E341>M. Naruhodo ?");
                s = s.Replace("Um...<E003 12>nothing?<E003 12> <E025 2>I was just saying that I'll be relying on your\r\nsupport today, <E003 8><E025 3>but...", "Euh...<E003 12>rien ?<E003 12> <E025 2>Je disais simplement que je comptais sur votre\r\nsoutien aujourd'hui, <E003 8><E025 3>mais...");
                s = s.Replace("I'm so sorry!<E049><E003 16> <E145 3 83><E335>Of course!<E003 8>\r\n<E025 2>I, <E003 8>I know I can be rather incompetent at times, <E049><E003 6><E025 3>but...", "Je suis tellement désolée !<E049><E003 16> <E145 3 83><E335>Bien entendu !<E003 8>\r\n<E025 2>Je, <E003 8>je sais que je peux me montrer bien maladroite parfois, <E049><E003 6><E025 3>mais...");
                s = s.Replace("...I shan't let you down!", "...je ne vous décevrai pas !");
                s = s.Replace("...Would you mind helping me to my feet, then?", "...Vous voudriez bien m'aider à me relever, dans ce cas ?");
                s = s.Replace("Oh dear!<E049><E003 12>\r\n<E025 1><E341>I'm really very sorry!", "Oh ciel !<E049><E003 12>\r\n<E025 1><E341>Pardonnez-moi, je vous en conjure !");
                return s;
            };

            // [1] BB\script\output\_sce04_c100_0000_eng#7
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#7"] = (s) => {
                s = s.Replace("(Susato-san isn't her usual self at all.)", "(Susato n'est pas du tout dans son assiette habituelle.)");
                s = s.Replace("(But that's hardly surprising,<E003 8> <E025 3>I suppose.)", "(Mais ce n'est guère surprenant,<E003 8> <E025 3>j'imagine.)");
                s = s.Replace("(She's just found out that her father is the partner of a\r\nworld-famous detective.<E003 8> <E025 3>Not to mention...)", "(Elle vient d'apprendre que son père est le partenaire d'un\r\ndétective mondialement connu.<E003 8> <E025 3>Sans parler de...)");
                s = s.Replace("Ah!<E003 12> G-<E049><E003 8><E025 1><E145 3 92><E117 3 6><E335>Good morning, sir!", "Ah !<E003 12> B-<E049><E003 8><E025 1><E145 3 92><E117 3 6><E335>Bonjour, milord !");
                s = s.Replace("Lord van Zieks!", "Lord Van Peers !");
                s = s.Replace("Have you made peace with your maker, <E049><E003 6>Nipponese?", "Avez-vous fait la paix avec votre Créateur, <E049><E003 6>le Japonais ?");
                s = s.Replace("...Because today, <E049><E003 6><E145 18 10><E118 18 0.7><E003 10>you take up arms on the battlefield.", "...Car aujourd'hui, <E049><E003 6><E145 18 10><E118 18 0.7><E003 10>vous montez au front sur le champ de bataille.");
                s = s.Replace("I-In court, <E049><E003 4>you mean?", "A-Au tribunal, <E049><E003 4>vous voulez dire ?");
                s = s.Replace("The prosecutor that faces you today <E049><E003 8><E025 3>wields a terrible blade\r\nand holds an undying grudge.", "Le procureur qui vous fera face aujourd'hui <E049><E003 8><E025 3>manie une lame terrible\r\net nourrit une rancœur inextinguible.");
                s = s.Replace("He will stop at nothing <E049><E003 6><E025 1>to cut you down where you stand.", "Rien ne l'arrêtera <E049><E003 6><E025 1>pour vous pourfendre sur-le-champ.");
                s = s.Replace("...I am aware.", "...J'en suis parfaitement conscient.");
                s = s.Replace("And yet here you stand.<E049><E003 14> <E025 3>In defence of the Reaper.", "Et pourtant, vous voici à la barre.<E049><E003 14> <E025 3>Pour défendre le Faucheur.");
                s = s.Replace("...To tell you the truth, <E049><E003 6>I did consider running away.", "...À dire vrai, <E049><E003 6>j'ai bien envisagé de prendre la fuite.");
                s = s.Replace("Mr Naruhodo!", "M. Naruhodo !");
                s = s.Replace("The Reaper?<E049><E003 13>\r\nI suppose in hindsight...", "Le Faucheur ?<E049><E003 13>\r\nAvec le recul, j'imagine...");
                s = s.Replace("...I shouldn't have allowed that misconception<E049><E003 6> <E145 18 0><E003 6>to go\r\nunchallenged.", "...que je n'aurais pas dû laisser cette funeste légende<E049><E003 6> <E145 18 0><E003 6>prospérer\r\nsans mot dire.");
                s = s.Replace("Huh?", "Pardon ?");
                s = s.Replace("It was my tacit acceptance of that pseudonym...", "Mon acceptation tacite de ce funeste sobriquet...");
                s = s.Replace("My failure to stop the Reaper becoming something more\r\nthan a mere legend...<E003 12><E025 3>that led to all this.", "Mon incapacité à empêcher le Faucheur de devenir bien plus\r\nqu'une simple légende...<E003 12><E025 3>c'est ce qui a causé tout cela.");
                s = s.Replace("But you're not to blame for that,<E003 10> <E341>Lord van Zieks!", "Mais vous n'y êtes pour rien,<E003 10> <E341>Lord Van Peers !");
                s = s.Replace("It's only because serious crime in the capital dropped off\r\nso sharply when the public started calling you that.", "C'est uniquement parce que les grands crimes ont chuté si drastiquement\r\ndans la capitale quand le public a commencé à vous nommer ainsi.");
                s = s.Replace("That's why you didn't say anything, <E003 6>isn't it?", "C'est pour cela que vous avez gardé le silence, <E003 6>n'est-ce pas ?");
                s = s.Replace("...To be frank, <E049><E003 12><E239><E025 2>I'm not sure that was the sole reason.", "...Pour être franc, <E049><E003 12><E239><E025 2>je ne suis pas certain que ce fût la seule raison.");
                s = s.Replace("What do you mean?", "Que voulez-vous dire ?");
                s = s.Replace("There was a rumour at the time <E049><E003 8><E025 3>that the Reaper was\r\nreally the ghost of my late brother.", "Une rumeur courait à l'époque <E049><E003 8><E025 3>selon laquelle le Faucheur\r\nétait le fantôme de mon défunt frère.");
                s = s.Replace("That having been slain by that evil killer, <E049><E003 8><E025 2>Klint's restless\r\nspirit returned as some sort of demigod...", "Qu'ayant été terrassé par ce tueur sanguinaire, <E049><E003 8><E025 2>l'esprit tourmenté de Clint\r\nétait revenu tel une sorte de demi-dieu vengateur...");
                s = s.Replace("...to wield a deadly blade of justice where I,<E049><E003 8> by dint of the\r\nlaw,<E049><E003 10> <E025 3>could not.", "...pour abattre le glaive impitoyable de la justice là où moi,<E049><E003 8> par les voies\r\nde la loi,<E049><E003 10> <E025 3>j'avais échoué.");
                s = s.Replace("Yes...<E003 10>we've heard that story too.", "Oui...<E003 10>nous avons entendu ce récit nous aussi.");
                s = s.Replace("When I lost him...", "Quand je l'ai perdu...");
                s = s.Replace("...I felt as though I'd lost my guiding light.<E003 12>\r\n<E025 2>I didn't know where to go or what to do.", "...j'ai eu l'impression de perdre mon étoile directrice.<E003 12>\r\n<E025 2>J'ignorais où aller et que faire de ma vie.");
                s = s.Replace("And so...", "Et ainsi...");
                s = s.Replace("...in some small way, <E003 10><E025 2><E239>I wonder if perhaps those rumours\r\nmade me feel his absence a little less keenly.", "...au fond de moi, <E003 10><E025 2><E239>je me demande si ces rumeurs n'adoucissaient\r\npas un peu la morsure cruelle de son absence.");
                s = s.Replace("Even if I knew it was just an illusion.<E049><E003 12> <E025 2>Just some nonsense\r\nconjured up by an over-imaginative public.", "Même si je savais pertinemment que ce n'était qu'une illusion.<E049><E003 12> <E025 2>Une pure invention\r\nfaçonnée par l'imagination débordante du peuple.");
                s = s.Replace("He was obviously extremely important to you.", "Il était de toute évidence infiniment cher à vos yeux.");
                s = s.Replace("Lord Klint van Zieks...", "Lord Clint Van Peers...");
                s = s.Replace("Well...<E003 10><E025 2>what's important now is uncovering the truth.<E003 10>\r\nThat's all that matters.", "Eh bien...<E003 10><E025 2>l'essentiel désormais est de faire éclater la vérité.<E003 10>\r\nC'est la seule chose qui compte.");
                s = s.Replace("I...<E003 12><E025 2><E330>know that you didn't take anyone's life.", "Je...<E003 12><E025 2><E330>sais au fond de moi que vous n'avez ôté la vie à personne.");
                s = s.Replace("And I intend to prove that beyond a shadow of a doubt in\r\ncourt today.", "Et j'ai la ferme intention de le prouver aujourd'hui au tribunal,\r\nsans l'ombre d'un doute.");
                s = s.Replace("I never thought I'd say this...", "Je n'aurais jamais songé dire cela un jour...");
                s = s.Replace("...but I can see it in your eyes.<E049><E003 10> That burning desire to cut\r\nthrough all the lies and deception.", "...mais je le lis distinctement dans votre regard.<E049><E003 10> Cette volonté ardente\r\nde pourfendre les mensonges et les faux-semblants.");
                s = s.Replace("I can't deny it any longer.<E049><E003 16>\r\n<E025 3>You...<E003 12>are a lawyer of absolute integrity.", "Je ne puis le nier plus longtemps.<E049><E003 16>\r\n<E025 3>Vous...<E003 12>êtes un avocat d'une intégrité sans faille.");
                s = s.Replace("...Thank you.", "...Merci.");
                return s;
            };

            // [2] BB\script\output\_sce04_c100_0000_eng#8
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#8"] = (s) => {
                s = s.Replace("Now tell me...", "Dites-moi un peu...");
                s = s.Replace("...why do I detect the scent of expensive tea leaves in the\r\nair?", "...pourquoi donc humé-je ici l'arôme de feuilles de thé de grand cru ?");
                s = s.Replace("Oh!<E003 10> <E025 2><E342>Iris!<E003 15>\r\n<E025 2>When did you get here?", "Oh !<E003 10> <E025 2><E342>Iris !<E003 15>\r\n<E025 2>Quand es-tu arrivée ?");
                s = s.Replace("I brought you one of my special blends!", "Je vous ai apporté un de mes mélanges maison !");
                s = s.Replace("Hurley loves it.<E049><E003 14> <E025 1><E333>He says it helps him to clear his head!", "Hurley en raffole.<E049><E003 14> <E025 1><E333>Il dit que ça lui éclaircit les idées !");
                s = s.Replace("...I thank you.", "...Je vous remercie.");
                s = s.Replace("Oh...<E003 10> <E025 2>Hee hee...", "Oh...<E003 10> <E025 2>Hi hi...");
                s = s.Replace("(That's surely the first and last time I'll ever see a sight\r\nlike this...)", "(C'est assurément la première et dernière fois que je verrai un tel tableau...)");
                s = s.Replace("You seem different today, <E003 4>Iris.", "Tu as l'air différente aujourd'hui, <E003 4>Iris.");
                s = s.Replace("Oh...?", "Ah bon... ?");
                s = s.Replace("Sort of...<E003 12><E025 3>subdued, <E003 8>I suppose.", "Un peu...<E003 12><E025 3>morose, <E003 8>j'imagine.");
                s = s.Replace("I am not!", "Pas du tout !");
                s = s.Replace("(What happened yesterday <E145 4 74><E118 4 0.8>is obviously still playing on\r\nher mind a lot.)", "(Ce qui s'est passé hier <E145 4 74><E118 4 0.8>lui pèse de toute évidence\r\nencore lourdement sur le cœur.)");
                s = s.Replace("(She's clearly very troubled about having stolen that\r\nautopsy report from Dr Sithe's laboratory.)", "(Elle est visiblement rongée par le vol du rapport d'autopsie\r\ndans le laboratoire de la Dre Sithe.)");
                s = s.Replace("Alright then...<E049><E003 10><E025 1><E164 4 67 1 2 8 0 1 1><E139 4>good luck to you both!", "Bon eh bien...<E049><E003 10><E025 1><E164 4 67 1 2 8 0 1 1><E139 4>bonne chance à vous deux !");
                s = s.Replace("I have to make a move now.", "Il faut que je file, maintenant.");
                s = s.Replace("Oh!<E003 12> <E025 2>You're not staying?", "Oh !<E003 12> <E025 2>Tu ne restes pas avec nous ?");
                s = s.Replace("I thought you'd want to watch today's proceedings.", "Je croyais que tu voulais assister au procès aujourd'hui.");
                s = s.Replace("Well...<E003 10><E025 2>I'd like to cheer you on, <E049><E003 6>obviously.", "Ben...<E003 10><E025 2>j'aimerais vous encourager, <E049><E003 6>bien sûr.");
                s = s.Replace("But I've got lots to get ready.", "Mais j'ai plein de préparatifs sur le feu.");
                s = s.Replace("Get ready?<E003 12> For what?", "Des préparatifs ?<E003 12> Pour quoi faire ?");
                s = s.Replace("Oh, yes.<E049><E003 8> <E025 1><E164 4 66 1 2 6 0 0 1><E118 4 1.4><E139 4><E060 0 151 0 0>Would you take this?", "Ah, au fait.<E049><E003 8> <E025 1><E164 4 66 1 2 6 0 0 1><E118 4 1.4><E139 4><E060 0 151 0 0>Prenez ceci avec vous !");
                s = s.Replace("Isn't that one of the little felt dolls that's usually dangling\r\nfrom your knapsack?", "N'est-ce pas une des poupées de feutre qui pendent d'ordinaire\r\nà ton sac à malice ?");
                s = s.Replace("Yes!<E049><E003 14> <E025 1><E346>It's a lucky charm!<E049><E003 12>\r\n<E025 2>A little Hurley that I made once.", "Oui !<E049><E003 14> <E025 1><E346>C'est un porte-bonheur !<E049><E003 12>\r\n<E025 2>Un petit Hurley que j'ai cousu moi-même.");
                s = s.Replace("A ‘Hurley’?<E003 12>\r\n<E025 3><E007>(It looks more like a ‘Hareley’ to me...)", "Un « Hurley » ?<E003 12>\r\n<E025 3><E007>(On dirait plutôt un « Lapin-Hurley » à mes yeux...)");
                s = s.Replace("If feels like Hurley's watching over you...<E049><E003 12>\r\n<E025 1>when you've got it, <E049><E003 6><E346>see?", "On dirait que Hurley veille sur vous...<E049><E003 12>\r\n<E025 1>quand on le garde sur soi, <E049><E003 6><E346>vous comprenez ?");
                s = s.Replace("Don't worry, <E049><E003 6>Iris.<E049><E003 10> <E025 2><E145 3 65><E118 3 1.2>Mr Naruhodo and I are going to\r\nuncover the truth today.<E049><E003 10> <E025 1>I promise!", "Ne t'en fais pas, <E049><E003 6>Iris.<E049><E003 10> <E025 2><E145 3 65><E118 3 1.2>M. Naruhodo et moi allons\r\nfaire éclater la vérité aujourd'hui.<E049><E003 10> <E025 1>C'est une promesse !");
                s = s.Replace("I know you are.<E049><E003 12> <E025 2>You're the best!", "Je le sais bien.<E049><E003 12> <E025 2>Vous êtes les meilleurs !");
                s = s.Replace("Lord Barok!<E049><E003 12> Good luck to you as well!", "Lord Drake !<E049><E003 12> Bonne chance à vous aussi !");
                s = s.Replace("...Young lady.", "...Petite demoiselle.");
                s = s.Replace("Farewell, then!", "Adieu alors !");
                s = s.Replace("Farewell? <E003 10><E341>That's a bit extreme, isn't it?<E003 12>\r\n<E025 2>Surely she means ‘see you later’...", "Adieu ? <E003 10><E341>C'est un peu fort de café, non ?<E003 12>\r\n<E025 2>Elle voulait sans doute dire « à tout à l'heure »...");
                return s;
            };

            // [3] BB\script\output\_sce04_c100_0000_eng#9
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#9"] = (s) => {
                s = s.Replace("A talisman from Iris has to bring you good luck,<E003 6>\r\nMr Naruhodo!", "Un talisman offert par Iris ne peut que vous porter chance,<E003 6>\r\nM. Naruhodo !");
                s = s.Replace("Yes, <E003 8>I'm sure it will.", "Oui, <E003 8>j'en suis persuadé.");
                s = s.Replace("I'll hold it close to my heart throughout today's\r\nproceedings.", "Je le garderai précieusement contre mon cœur tout au long des débats.");
                return s;
            };

            // [4] BB\script\output\_sce04_c100_0000_eng#10
            entryTranslators[@"BB\script\output\_sce04_c100_0000_eng#10"] = (s) => {
                s = s.Replace("Excuse me, sir! <E003 6>The court is ready for you!", "Excusez-moi, monsieur ! <E003 6>La cour est prête à vous accueillir !");
                s = s.Replace("I suppose it's time, then.", "Le moment est venu, alors.");
                s = s.Replace("Yes.<E049><E003 10> <E025 2>I shall await you at the defence's bench.", "Oui.<E049><E003 10> <E025 2>Je vous attends au banc de la défense.");
                s = s.Replace("...Listen, Nipponese.", "...Écoutez-moi, le Japonais.");
                s = s.Replace("Yes?", "Oui ?");
                s = s.Replace("I have one request of you.", "J'ai une dernière requête à vous formuler.");
                s = s.Replace("A request?", "Une requête ?");
                s = s.Replace("If...<E049><E003 8>after all is said and done today...<E049><E003 10><E025 3><E145 18 10><E118 18 0.7><E003 10>the court decides\r\nthat I should take the fall...", "Si...<E049><E003 8>au terme des débats du jour...<E049><E003 10><E025 3><E145 18 10><E118 18 0.7><E003 10>la cour conclut\r\nque je dois être condamné...");
                s = s.Replace("...I beg you to put your emotions to one side.", "...je vous conjure de faire taire vos sentiments.");
                s = s.Replace("Lord van Zieks...", "Lord Van Peers...");
                s = s.Replace("Accept the gavel's fall.<E049><E003 12> <E025 3>The will of the court.", "Acceptez le coup de marteau fatidique.<E049><E003 12> <E025 3>La sentence souveraine.");
                s = s.Replace("Promise me that.<E049><E003 12> <E025 2>As my defence counsel.", "Promettez-le-moi.<E049><E003 12> <E025 2>En tant qu'avocat de ma défense.");
                s = s.Replace("...No, Lord van Zieks.", "...Non, Lord Van Peers.");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("I refuse to make any such promise.", "Je refuse de vous faire une telle promesse.");
                s = s.Replace("...Because I believe in you.", "...Car j'ai une confiance absolue en vous.");
                s = s.Replace("And today, <E049><E003 6>I'm going to tear this mystery apart to find the\r\ntruth!", "Et aujourd'hui, <E049><E003 6>je ferai voler en éclats ce mystère pour atteindre la vérité !");
                s = s.Replace("...Very well.<E049><E003 10> <E025 2>Then we shall duel, <E049><E003 6>it seems.", "...Soit.<E049><E003 10> <E025 2>Alors nous nous affronterons en duel, <E049><E003 6>semble-t-il.");
                s = s.Replace("In this arena of blood and tears.<E049><E003 12> <E025 3>Until the bitter end.", "Dans cette arène de sang et de larmes.<E049><E003 12> <E025 3>Jusqu'au dénouement tragique.");
                return s;
            };

            // [5] BB\script\output\_sce04_c101_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0000_eng#2"] = (s) => {
                s = s.Replace("3rd November, 9:55 a.m.\r\n<CNTR><E003 5>The Old Bailey, Courtroom No. 1", "3 novembre, 9 h 55\r\n<CNTR><E003 5>Old Bailey, salle d'audience n° 1");
                s = s.Replace("(Here we go again...)", "(C'est reparti pour un tour...)");
                s = s.Replace("(The courtroom atmosphere is just as tense and heavy as\r\nyesterday.)", "(L'atmosphère de la salle est tout aussi pesante et électrique qu'hier.)");
                s = s.Replace("Mr Naruhodo, <E003 8>please...<E003 10>take this.", "M. Naruhodo, <E003 8>je vous prie...<E003 10>prenez ceci.");
                s = s.Replace("Susato-san...<E003 10>what is it?", "Susato...<E003 10>qu'est-ce que c'est ?");
                s = s.Replace("A talisman that Iris made for you.", "Un porte-bonheur qu'Iris a confectionné pour vous.");
                s = s.Replace("Iris did?", "Iris ?");
                s = s.Replace("Yes, <E003 8>she said that Hurley always keeps one in his pocket\r\nwhen he's on an investigation.", "Oui, <E003 8>elle dit que Hurley en a toujours un dans sa poche\r\nlorsqu'il part en enquête.");
                s = s.Replace("...Though looking at him, <E003 8>one might question its efficacy.", "...Bien qu'à le voir agir, <E003 8>on puisse s'interroger sur ses vertus.");
                s = s.Replace("Thank you. <E003 8>I'll be sure to treasure it.", "Merci. <E003 8>Je veillerai à le garder précieusement.");
                s = s.Replace("Iris's Talisman has been entered\r\ninto the Court Record.", "Le porte-bonheur d'Iris a été versé\r\nau dossier de l'affaire.");
                s = s.Replace("Iris was in such a state yesterday...<E003 10>\r\n...I really feel for her.", "Iris était tellement bouleversée hier...<E003 10>\r\n...je compatis sincèrement avec elle.");
                s = s.Replace("She still seemed deeply troubled when she left earlier.", "Elle semblait encore terriblement anxieuse en partant tout à l'heure.");
                s = s.Replace("Whatever the truth turns out to be...<E003 10>\r\n...I pray it brings her solace.", "Quelle que soit la vérité...<E003 10>\r\n...je prie pour qu'elle lui apporte enfin la paix de l'âme.");
                return s;
            };

            // [6] BB\script\output\_sce04_c101_0010_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0010_eng#2"] = (s) => {
                s = s.Replace("In the name of Her Majesty the Queen, <E049><E003 8>I hereby declare\r\nthis court to be in session...", "Au nom de Sa Majesté la Reine, <E049><E003 8>je déclare la séance\r\nouverte...");
                s = s.Replace("...for the trial of Barok van Zieks, <E049><E003 10><E164 61 11 1 2 8 0 2 1><E139 61><E025 1>who officially stands\r\naccused of murder.", "...dans le cadre du procès de Drake Van Peers, <E049><E003 10><E164 61 11 1 2 8 0 2 1><E139 61><E025 1>officiellement\r\naccusé de meurtre.");
                s = s.Replace("Counsels for the prosecution and defence...<E049><E003 12>are you in full\r\nreadiness to proceed?", "Messieurs les procureur et avocat de la défense...<E049><E003 12>êtes-vous prêts\r\nà engager les débats ?");
                s = s.Replace("The defence is ready...<E049><E003 12><E025 2>My Lord.", "La défense est prête...<E049><E003 12><E025 2>Votre Honneur.");
                s = s.Replace("As is the prosecution.", "L'accusation l'est également.");
                s = s.Replace("Yesterday's proceedings brought to light a shocking and\r\ndisturbing fact:", "L'audience d'hier a révélé un fait aussi choquant\r\nque troublant :");
                s = s.Replace("There was a side to the victim, <E049><E003 6><E025 3>Inspector Tobias Gregson,<E049><E003 10>\r\n<E025 2>that was unknown to his superiors at Scotland Yard.", "Il existait chez la victime, <E049><E003 6><E025 3>l'inspecteur Tobias Gregson,<E049><E003 10>\r\n<E025 2>une facette totalement ignorée de ses supérieurs de Scotland Yard.");
                s = s.Replace("Yes, <E049><E003 8><E025 2>he was carrying out operations in secret, <E049><E003 6>which\r\nScotland Yard knew nothing about.", "Oui, <E049><E003 8><E025 2>il menait de sombres opérations en secret, <E049><E003 6>dont\r\nScotland Yard ne savait absolument rien.");
                s = s.Replace("And in those clandestine operations, <E049><E003 8><E025 3><E145 61 0><E118 61 0.5><E003 8>he had <E006>an\r\naccomplice<E005>.", "Et au cœur de ces menées clandestines, <E049><E003 8><E025 3><E145 61 0><E118 61 0.5><E003 8>il bénéficiait de <E006>la complicité\r\nd'un tiers<E005>.");
                s = s.Replace("Mr Daley Vigil, <E049><E003 8><E025 2>who would be given the inspector's\r\nidentification...", "M. Daley Vigil, <E049><E003 8><E025 2>qui recevait l'insigne d'inspecteur de Gregson...");
                s = s.Replace("...and present himself around the capital in order to\r\nestablish credible alibis for Gregson.", "...pour se pavaner aux quatre coins de Londres et forger\r\ndes alibis imparables pour Gregson.");
                s = s.Replace("In that way, <E049><E003 10><E330><E025 2>Gregson appeared to be carrying out his\r\nregular Scotland Yard work<E003 4> when in fact<E049><E003 8> he wasn't.", "De cette manière, <E049><E003 10><E330><E025 2>Gregson semblait accomplir ses rondes officielles<E003 4>\r\nalors qu'en réalité,<E049><E003 8> il n'en était rien.");
                s = s.Replace("At the end of yesterday's session, <E049><E003 6>Mr Vigil, <E049><E003 8>who had been\r\nsuffering from amnesia, <E049><E003 6>regained his memory.", "À l'issue de l'audience d'hier, <E049><E003 6>M. Vigil, <E049><E003 8>qui souffrait\r\nd'amnésie, <E049><E003 6>a miraculeusement recouvré ses souvenirs.");
                s = s.Replace("It would appear <E049><E003 6><E025 2>he buried his memories of the time deep\r\ninside himself as a means of self-preservation.", "Il semble <E049><E003 6><E025 2>qu'il ait enfoui le souvenir de cette époque au plus\r\nprofond de lui-même par pur instinct de survie.");
                s = s.Replace("Because whilst he was engaged as chief warder at Barclay\r\nPrison, <E049><E003 6><E145 61 0><E118 61 0.6><E003 10><E025 3><E330>he abetted the convict's escape.", "Puisqu'alors qu'il officiait comme surveillant-chef à la prison de Barclay, <E049><E003 6><E145 61 0><E118 61 0.6><E003 10><E025 3><E330>il avait facilité l'évasion du condamné.");
                s = s.Replace("Mr Vigil is currently recuperating at St Synner's.", "M. Vigil est actuellement en convalescence à Saint-Synner.");
                s = s.Replace("He's recovered enough to give a signed statement about\r\nhis movements on the day prior to the incident.", "Son état s'est suffisamment stabilisé pour qu'il signe une déclaration\r\nsur ses faits et gestes la veille du drame.");
                s = s.Replace("He's formally admitted to posing as Gregson whilst\r\ninvestigating the Red-Headed League.", "Il a formellement avoué s'être fait passer pour Gregson durant\r\nles investigations sur la Ligue des Rouquins.");
                s = s.Replace("Which brings us to the crucial issue <E049><E003 8><E025 3>of the victim's <E006>time of\r\ndeath<E005>.", "Ce qui nous amène à la question primordiale <E049><E003 8><E025 3>de <E006>l'heure du décès<E005>\r\nde la victime.");
                s = s.Replace("The defence yesterday proposed a suggestion <E049><E003 6>that the\r\nvictim may have been killed <E006>one day earlier<E005>.", "La défense a émis hier l'hypothèse <E049><E003 6>selon laquelle la victime\r\naurait pu être assassinée <E006>un jour plus tôt<E005>.");
                s = s.Replace("And according to testimony from the coroner,<E049><E003 8> <E145 61 10><E003 8>Dr Sithe,\r\n<E049><E003 10><E025 2>that suggestion <E049><E003 10><E238><E025 3><E006>could not be\r\nruled out<E005>.", "Et selon le témoignage du médecin légiste,<E049><E003 8> <E145 61 10><E003 8>la Dre Sithe,\r\n<E049><E003 10><E025 2>cette éventualité <E049><E003 10><E238><E025 3><E006>ne pouvait être écartée<E005>.");
                s = s.Replace("It's entirely possible that Inspector Gregson was killed on\r\n31st October –<E049><E003 8> the day before his body was discovered.", "Il est tout à fait envisageable que l'inspecteur Gregson ait été abattu\r\nle 31 octobre...<E049><E003 8> la veille même de la découverte du corps.");
                s = s.Replace("I have here an updated autopsy report that includes the\r\namended details.", "J'ai ici un rapport d'autopsie rectifié consignant l'ensemble\r\nde ces précisions.");
                s = s.Replace("But the official opinion of the investigation team was made\r\nclear yesterday.", "Mais la position officielle de la brigade criminelle a été exposée\r\nhier sans ambiguïté.");
                s = s.Replace("That the time of death <E049><E003 10>was 5 p.m. on 1st November.", "L'heure du décès <E049><E003 10>a été fixée au 1er novembre, à 17 heures.");
                s = s.Replace("There are indications of an attempt to <E006>disguise<E005> the real\r\ntime of death, <E049><E003 4>however.", "Il existe cependant des indices tendant à prouver une volonté de <E006>maquiller<E005>\r\nl'heure véritable de la mort.");
                s = s.Replace("It seems that the natural decaying process of the victim's\r\nbody may have been slowed by keeping it chilled.", "Il apparaît que la décomposition du corps a pu être ralentie\r\nen maintenant la dépouille au froid.");
                s = s.Replace("That's out of the question.", "C'est purement impensable.");
                s = s.Replace("There are no refrigeration devices in that part of London\r\nlarge enough to accommodate a human corpse.", "Il n'existe dans ce quartier de Londres aucun dispositif frigorifique\r\nassez vaste pour y loger une dépouille humaine.");
                s = s.Replace("My Lord!<E049><E003 10> <E145 1 7><E003 8><E025 2>This is more than just conjecture.", "Votre Honneur !<E049><E003 10> <E145 1 7><E003 8><E025 2>Il ne s'agit nullement d'une simple conjecture.");
                s = s.Replace("There's evidence to support the idea.<E049><E003 12>\r\nWe must investigate it thoroughly.", "Des preuves matérielles corroborent cette thèse.<E049><E003 12>\r\nNous nous devons de l'examiner à fond.");
                s = s.Replace("...Very well.", "...Fort bien.");
                s = s.Replace("The court will accept the new report as evidence.", "La cour accepte ce nouveau rapport comme pièce à conviction.");
                s = s.Replace("However, <E049><E003 8><E025 2>if this updated report is deemed to be\r\naccurate...", "Néanmoins, <E049><E003 8><E025 2>si ce document révisé est reconnu comme\r\nexact...");
                s = s.Replace("...it would give renewed significance to the movements of\r\nthe victim on <E006>the day before<E005> the Fresno Street incident.", "...il conférerait un poids capital aux déplacements de la victime\r\n<E006>la veille<E005> des événements de la rue Fresno.");
                s = s.Replace("It would, <E049><E003 8>yes.<E049><E003 12>\r\n<E025 2>Especially since on that day...", "Tout à fait, <E049><E003 8>en effet.<E049><E003 12>\r\n<E025 2>D'autant plus qu'en ce jour précis...");
                s = s.Replace("...Inspector Gregson was using Mr Vigil to cover up his\r\nreal movements.", "...l'inspecteur Gregson utilisait M. Vigil pour masquer\r\nses véritables agissements.");
                s = s.Replace("It's conceivable that he was killed <E049><E003 4><E145 112 4><E118 112 1.2><E003 20><E333><E025 3>in the course of his\r\nsecret activities.", "Il est fort concevable qu'il ait été assassiné <E049><E003 4><E145 112 4><E118 112 1.2><E003 20><E333><E025 3>dans l'exercice\r\nmême de ses opérations occultes.");
                s = s.Replace("Do I sense<E049><E003 12> <E145 61 7>that the prosecution has some information\r\nregarding those activities?", "Dois-je comprendre<E049><E003 12> <E145 61 7>que l'accusation détient des éléments\r\nquant à ces activités ?");
                s = s.Replace("Scotland Yard put an enormous effort into investigating\r\nthat precise matter yesterday.", "Scotland Yard a déployé hier des efforts considérables pour faire\r\ntoute la lumière sur cette piste.");
                s = s.Replace("I think we should begin by presenting the results of that\r\ninvestigation work.", "J'estime que nous devrions commencer par exposer les conclusions\r\nde ces investigations.");
                s = s.Replace("So the prosecution <E049><E003 8><E025 1><E164 112 10 1 2 5 1 1 1><E139 112>calls its first witness now!", "L'accusation appelle dès lors son premier témoin à la barre !");
                return s;
            };

            // [7] BB\script\output\_sce04_c101_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0020_eng#2"] = (s) => {
                s = s.Replace("Witness...<E049><E003 8>please state your name and profession for the\r\ncourt.", "Témoin...<E049><E003 8>veuillez décliner vos nom et profession devant la cour.");
                s = s.Replace("I'm Gina Lestrade.<E049><E003 12> Apprentice detective at Scotland Yard.", "Moi c'est Gina Lestrade.<E049><E003 12> Apprentie inspectrice à Scotland Yard.");
                s = s.Replace("Gina!", "Gina !");
                s = s.Replace("...Mr Naruhodo.", "...M. Naruhodo.");
                s = s.Replace("Yesterday, <E049><E003 8>the witness made an exhaustive search of\r\nInspector Gregson's secret office.", "Hier, <E049><E003 8>le témoin a procédé à une perquisition méticuleuse\r\ndu bureau secret de l'inspecteur Gregson.");
                s = s.Replace("She found some interesting evidence concerning the\r\nvictim's movements on the day before the murder.", "Elle y a découvert des pièces d'une importance capitale quant aux\r\ndéplacements de la victime la veille du meurtre.");
                s = s.Replace("Evidence?", "Des preuves ?");
                s = s.Replace("She will now formally testify to the details.", "Elle va à présent en faire la déposition solennelle.");
                s = s.Replace("Gina...<E049><E003 8><E025 2>are you alright to testify in court?", "Gina...<E049><E003 8><E025 2>vous sentez-vous en état de déposer devant la cour ?");
                s = s.Replace("I know this must be terribly difficult for you, so soon\r\nafter...", "Je sais combien cela doit être douloureux pour vous, si peu de temps après...");
                s = s.Replace("I ain't gonna lie, <E049><E003 6>'Oddo.<E049><E003 10> <E025 2>I could cry me eyes out,<E049><E003 6> I'm\r\nthat miserable.", "J'vais pas vous mentir, <E049><E003 6>'Odoh.<E049><E003 10> <E025 2>J'pourrais en chialer toutes les larmes\r\nd'mon corps tellement j'suis anéantie.");
                s = s.Replace("I just feel empty inside.", "J'ai l'impression d'être toute vide au-d'dans.");
                s = s.Replace("But I can't just curl up in a ball, can I?", "Mais j'peux pas rester roulée en boule, pas vrai ?");
                s = s.Replace("I've gotta find out the truth!<E049><E003 12> <E025 1>For the boss!", "J'dois découvrir la vérité !<E049><E003 12> <E025 1>Pour l'patron !");
                s = s.Replace("I understand. <E003 8>You're a detective now.", "Je comprends. <E003 8>Vous êtes une inspectrice à présent.");
                s = s.Replace("Miss Lestrade, <E049><E003 8>if you would...", "Mademoiselle Lestrade, <E049><E003 8>si vous voulez bien...");
                return s;
            };

            // [8] BB\script\output\_sce04_c101_0030_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0030_eng#2"] = (s) => {
                s = s.Replace("Tell the court what you uncovered during your search of\r\nthe secret office.", "Exposez à la cour les conclusions de vos fouilles dans le bureau\r\nsecret.");
                s = s.Replace("Right.<E049><E003 10> <E025 2>I'll tell you wot the lower-rankin' detectives reckon\r\nwas goin' on.", "Ça roule.<E049><E003 10> <E025 2>J'vais vous dire c'que les p'tits gars du Yard ont\r\nréussi à reconstituer.");
                return s;
            };

            // [9] BB\script\output\_sce04_c101_0030_eng#3
            entryTranslators[@"BB\script\output\_sce04_c101_0030_eng#3"] = (s) => {
                s = s.Replace("Gregson was lookin' into a deal that was goin' down at a\r\nclub called ‘The Grouse’...", "Gregson surveillait une transaction véreuse qui devait avoir\r\nlieu dans un club appelé « The Grouse »...");
                s = s.Replace("...which involved some <E006>smuggled goods<E005>.", "...portant sur un gros trafic de <E006>contrebande<E005>.");
                s = s.Replace("Smuggled goods?", "De la contrebande ?");
                s = s.Replace("Yes.<E049><E003 10> <E025 2>An investigation into a black market deal.", "Exactement.<E049><E003 10> <E025 2>Une enquête ciblant une filière du marché noir.");
                s = s.Replace("And the items being traded were of a confidential nature.", "Et la nature même des marchandises était couverte par le secret d'État.");
                s = s.Replace("Wait...<E049><E003 6><E025 2>do you mean they involved international secrets?", "Attendez...<E049><E003 6><E025 2>voulez-vous dire que cela touchait aux secrets internationaux ?");
                s = s.Replace("That's something the Yard hasn't got to the bottom of yet.", "C'est un point que le Yard n'a pas encore entièrement élucidé.");
                s = s.Replace("No doubt Gregson was trying to avoid details of his\r\ninvestigations being leaked to the involved parties.", "Gregson cherchait de toute évidence à éviter que ses filatures\r\nne s'ébruitent auprès des complices.");
                s = s.Replace("That would explain why he was operating on his own\r\nauthority, <E049><E003 6>without the Yard's knowledge.", "Cela expliquerait pourquoi il opérait de son propre chef, <E049><E003 6>à l'insu\r\nde ses pairs de Scotland Yard.");
                s = s.Replace("And do we know where the dealings were taking place\r\nthis time?", "Et savons-nous où la transaction devait avoir lieu cette fois-ci ?");
                s = s.Replace("In a particular room of a certain exclusive London\r\ngentleman's club.", "Dans un salon privé d'un club de gentlemen très sélect de la capitale.");
                s = s.Replace("And on the day in question...<E049><E003 10><E146 112 4><E118 112 1.1><E144 112><E333>the accused is known to have\r\nbeen there.", "Et le jour en question...<E049><E003 10><E146 112 4><E118 112 1.1><E144 112><E333>il est avéré que l'accusé s'y trouvait.");
                s = s.Replace("That's the conclusion of Scotland Yard's investigation into\r\nthe matter.", "Telle est la conclusion irréfutable des investigations du Yard.");
                s = s.Replace("That can't be...!<E049><E003 14>\r\n<E025 1><E341><E007>(We haven't heard anything about any of this!)", "Ce n'est pas possible... !<E049><E003 14>\r\n<E025 1><E341><E007>(Nous n'avions jamais entendu parler de tout cela !)");
                s = s.Replace("Members of the club have testified to it.", "Plusieurs membres éminents du club en ont apporté le témoignage.");
                s = s.Replace("There's no question:<E049><E003 8> <E145 112 0><E118 112 0.6><E149 112 0 0><E003 15><E025 3><E330>the accused, <E049><E003 6>Barok van Zieks,<E049><E003 12> <E025 4>was\r\npresent.", "Il n'y a aucun doute possible :<E049><E003 8> <E145 112 0><E118 112 0.6><E149 112 0 0><E003 15><E025 3><E330>l'accusé, <E049><E003 6>Drake Van Peers,<E049><E003 12> <E025 4>était bel et bien sur les lieux.");
                s = s.Replace("That would be very significant testimony, then.", "Voilà qui constitue un témoignage des plus accablants.");
                s = s.Replace("Oh my!<E049><E003 12>\r\n<E025 3>But, <E049><E003 6>but...", "Grands dieux !<E049><E003 12>\r\n<E025 3>Mais... mais...");
                s = s.Replace("...Lord van Zieks has made no mention of this!<E049><E003 12><E145 9 16><E117 9 10>\r\nAt all!", "...Lord Van Peers ne nous en a soufflé mot !<E049><E003 12><E145 9 16><E117 9 10>\r\nPas un seul mot !");
                s = s.Replace("In short, <E049><E003 2><E145 112 15><E003 20><E238>Lord van Zieks had ample opportunity to murder\r\nthe victim.", "En résumé, <E049><E003 2><E145 112 15><E003 20><E238>Lord Van Peers disposait de l'occasion idéale pour tuer\r\nla victime.");
                s = s.Replace("Very well, then.<E049><E003 12> <E025 2>Counsel for the Defence,<E049><E003 12> <E025 1><E338>begin your\r\ncross-examination!", "Très bien.<E049><E003 12> <E025 2>Maître Naruhodo,<E049><E003 12> <E025 1><E338>entamez votre contre-interrogatoire !");
                return s;
            };

            // [10] BB\script\output\_sce04_c101_0040_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#2"] = (s) => {
                s = s.Replace("– The Victim's Movements –", "– Les déplacements de la victime –");
                return s;
            };

            // [11] BB\script\output\_sce04_c101_0040_eng#4
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#4"] = (s) => {
                s = s.Replace("All Yard detectives are s'posed to follow orders an'\r\ninvestigate wot they're told.", "Tous les inspecteurs du Yard sont censés obéir aux ordres et\r\nenquêter sur c'qu'on leur dit.");
                return s;
            };

            // [12] BB\script\output\_sce04_c101_0040_eng#5
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#5"] = (s) => {
                s = s.Replace("But a little search o' the boss's office turned up a notebook\r\nthat 'ad a load of secret meetin's in it.", "Mais une p'tite fouille du bureau du patron a révélé un carnet\r\nrempli d'rendez-vous secrets.");
                return s;
            };

            // [13] BB\script\output\_sce04_c101_0040_eng#6
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#6"] = (s) => {
                s = s.Replace("Accordin' to that, the boss was lookin' into some smuggled\r\ngoods dealin's that day.", "D'après ses notes, l'patron enquêtait sur un trafic d'contrebande\r\nce jour-là.");
                return s;
            };

            // [14] BB\script\output\_sce04_c101_0040_eng#7
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#7"] = (s) => {
                s = s.Replace("Apparently the smuggled goods deal was gonna 'appen\r\nat a gentleman's club called ‘The Grouse’.", "Apparemment, la combine devait s'passer dans un club de gentlemen\r\nappelé « The Grouse ».");
                return s;
            };

            // [15] BB\script\output\_sce04_c101_0040_eng#8
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#8"] = (s) => {
                s = s.Replace("Looks like it was a big job an' all. But the coppers weren't\r\non to it yet.", "Ça avait l'air d'un gros coup. Mais la flicaille était pas encore\r\nau parfum.");
                return s;
            };

            // [16] BB\script\output\_sce04_c101_0040_eng#9
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#9"] = (s) => {
                s = s.Replace("Wot matters most is, there's witnesses wot saw the Reaper\r\nat the place, too!", "C'qui compte le plus, c'est qu'y a des témoins qui ont vu l'Faucheur\r\nsur place lui aussi !");
                return s;
            };

            // [17] BB\script\output\_sce04_c101_0040_eng#10
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#10"] = (s) => {
                s = s.Replace("So...<E049><E003 8><E145 1 85><E003 8><E025 2>you follow orders, do you, <E003 4>Gina?", "Alors...<E049><E003 8><E145 1 85><E003 8><E025 2>vous obéissez aux ordres, vous, <E003 4>Gina ?");
                s = s.Replace("Nah, <E049><E003 6>not me.<E049><E003 8> <E025 2>I'm above all that, <E049><E003 6>see.", "Nan, <E049><E003 6>pas moi.<E049><E003 8> <E025 2>J'suis au-d'ssus d'tout ça, <E049><E003 6>voyez.");
                s = s.Replace("The boss always 'ad special orders for me.", "L'patron avait toujours des ordres spéciaux pour moi.");
                s = s.Replace("‘Grab us some fish an' chips’<E049><E003 8> or ‘Go an' give Toby 'is\r\ngrub’...<E003 12> That kind o' thing.", "« Va nous chercher un fish and chips »<E049><E003 8> ou « Va nourrir Toby »...<E003 12>\r\nCe genre d'ordres-là.");
                s = s.Replace("...So ‘errands’ more than ‘orders’ then.", "...Des « commissions » plus que des « ordres », alors.");
                s = s.Replace("This ‘detective’ is still an apprentice, after all.", "Cette « inspectrice » n'est encore qu'une simple apprentie, après tout.");
                s = s.Replace("Yeah, well, <E049><E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.2><E139 122>this ‘apprentice’ ain't one to sit around an' wait\r\nto be told wot to do...<E003 10><E025 2>even by the boss.", "Ouais, ben, <E049><E025 1><E164 122 83 1 2 8 0 2 1><E118 122 1.2><E139 122>cette « apprentie » est pas du genre à rester les bras\r\ncroisés...<E003 10><E025 2>même quand ça vient du patron.");
                s = s.Replace("That's why I've been doin' me own investigations into wot\r\n'appened.<E049><E003 10> <E025 3>I didn't find much at first...", "C'est pour ça qu'j'ai mené mes propres fouilles sur c'qui s'est passé.<E049><E003 10> <E025 3>Au début j'ai pas trouvé grand-chose...");
                return s;
            };

            // [18] BB\script\output\_sce04_c101_0040_eng#11
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#11"] = (s) => {
                s = s.Replace("So you went through Inspector Gregson's things?", "Vous avez donc fouillé dans les affaires de l'inspecteur Gregson ?");
                s = s.Replace("Yup!<E049><E003 12> As part o' the independent<E003 10> <E333>Lestrade investigation!", "Ouaip !<E049><E003 12> Dans l'cadre des investigations indépendantes<E003 10> <E333>de Lestrade !");
                s = s.Replace("And where did you find this notebook?", "Et où avez-vous déniché ce carnet ?");
                s = s.Replace("Inside 'is coat pocket.<E049><E003 10> <E025 2>The one 'e was wearin' when 'e died.", "Dans la poche d'son manteau.<E049><E003 10> <E025 2>Celui qu'il portait au moment d'sa mort.");
                s = s.Replace("It was tucked away in a secret compartment.", "Il était fourré dans une doublure secrète.");
                s = s.Replace("A secret compartment...?", "Une doublure secrète... ?");
                s = s.Replace("The boss always kept 'is most private notes in there.", "L'patron y planquait toujours ses notes les plus confidentielles.");
                s = s.Replace("And what exactly is written in it?", "Et qu'y a-t-il écrit exactement à l'intérieur ?");
                s = s.Replace("Dates, places, names...<E049><E003 10>all kinds o' stuff.", "Des dates, des lieux, des noms...<E049><E003 10>tout un tas d'choses.");
                s = s.Replace("Gregson's Secret Notebook has been\r\nentered into the Court Record.", "Le carnet secret de Gregson a été versé\r\nau dossier de l'affaire.");
                return s;
            };

            // [19] BB\script\output\_sce04_c101_0040_eng#12
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#12"] = (s) => {
                s = s.Replace("The Grouse?<E049><E003 14>\r\n<E025 2>What sort of a club is that?", "The Grouse ?<E049><E003 14>\r\n<E025 2>Quel genre de club est-ce là ?");
                s = s.Replace("I ain't got the foggiest.<E049><E003 12>\r\n<E025 2>Clubs ain't exactly my thing.", "J'en ai pas la moindre idée.<E049><E003 12>\r\n<E025 2>Les clubs, c'est pas trop mon rayon.");
                s = s.Replace("But...<E049><E003 6><E025 1><E164 122 89 1 2 6 0 0 1><E139 122>I am kind o' curious!", "Mais...<E049><E003 6><E025 1><E164 122 89 1 2 6 0 0 1><E139 122>j'suis drôlement curieuse !");
                s = s.Replace("They're not places where a foreign student like you\r\nwould be readily admitted.", "Ce ne sont point des lieux où un étudiant étranger de votre acabit\r\npourrait entrer facilement.");
                s = s.Replace("Have you looked in the mirror recently?", "Vous vous êtes regardé dans un miroir récemment ?");
                s = s.Replace("I tell ya wot!", "J'vais vous dire !");
                s = s.Replace("Me and Chief Inspector Toby could go in undercover!", "Moi et l'commissaire divisionnaire Toby, on pourrait infiltrer l'bazar en douce !");
                s = s.Replace("Could you, <E049><E003 4>though?", "Vous le pourriez, <E049><E003 4>vraiment ?");
                s = s.Replace("I could pick out a few good marks <E049><E003 10><E025 1><E346>an' see wot else I could\r\nfind out while I was in there!", "J'pourrais repérer quelques bons pigeons <E049><E003 10><E025 1><E346>et voir c'que j'peux\r\nchiper comme infos là-d'dans !");
                s = s.Replace("...I really don't think you should go<E003 4> ‘picking’ out anything.", "...Je ne crois pas que vous devriez « chiper » quoi que ce soit.");
                s = s.Replace("Anyway, <E049><E003 10>that's where these black market dealings were\r\ngoing to take place, <E003 4>is it?", "Quoi qu'il en soit, <E049><E003 10>c'est là que cette transaction au marché noir\r\ndevait se tenir, <E003 4>c'est bien cela ?");
                s = s.Replace("Yeah, <E049><E003 8>it's gotta be.<E049><E003 8> That's wot the lower-rankin' detectives\r\nat the Yard reckon.", "Ouais, <E049><E003 8>ça fait aucun doute.<E049><E003 8> C'est c'que pensent les p'tits gars\r\nde Scotland Yard.");
                s = s.Replace("(Says the even lower-ranking detective...)", "(Dit l'inspectrice encore plus subalterne...)");
                return s;
            };

            // [20] BB\script\output\_sce04_c101_0040_eng#13
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#13"] = (s) => {
                s = s.Replace("This is a closed court.<E049><E003 10>\r\nThe proceedings are confidential.", "Ce tribunal siège à huis clos.<E049><E003 10>\r\nLes débats sont strictement confidentiels.");
                s = s.Replace("There shouldn't be any possibility of the information\r\nbeing leaked.", "Il ne devrait y avoir aucun risque de fuite de ces informations.");
                s = s.Replace("As I explained, <E049><E003 8><E025 2>there is some possibility of politicians\r\nbeing involved in this affair.", "Comme je l'ai précisé, <E049><E003 8><E025 2>il est possible que des personnalités\r\npolitiques soient impliquées dans cette affaire.");
                s = s.Replace("The prosecution is rightfully exercising caution,<E049><E003 6><E025 3><E145 61 7><E118 61 0.5><E003 6> I imagine.", "L'accusation fait preuve d'une prudence bien légitime,<E049><E003 6><E025 3><E145 61 7><E118 61 0.5><E003 6> j'imagine.");
                s = s.Replace("No, <E049><E003 8>My Lord.<E049><E003 10> The prosecution has no objection.", "Non, <E049><E003 8>Votre Honneur.<E049><E003 10> L'accusation n'a aucune objection.");
                s = s.Replace("Kazuma?", "Kazuma ?");
                s = s.Replace("There's no question that Inspector Gregson was looking\r\ninto these black market dealings.<E049><E003 8> <E025 3>However...", "Il est indéniable que l'inspecteur Gregson enquêtait\r\nsur cette filière du marché noir.<E049><E003 8> <E025 3>Cependant...");
                s = s.Replace("...it's not yet been established <E049><E003 8><E025 3>that he was on that\r\nparticular trail on the day in question.", "...il n'est pas encore démontré <E049><E003 8><E025 3>qu'il suivait cette piste précise\r\nle jour en question.");
                s = s.Replace("If the defence requires to know the club's name, <E049><E003 4><E145 112 2><E003 4>the\r\nprosecution has no intention of being obstructive.", "Si la défense exige de connaître le nom du club, <E049><E003 4><E145 112 2><E003 4>l'accusation\r\nn'a nulle intention de faire obstruction.");
                s = s.Replace("Right then!", "Parfait alors !");
                s = s.Replace("I get to show off<E049><E003 12> <E346><E025 1>me readin' skills!", "J'vais pouvoir épater la galerie<E049><E003 12> <E346><E025 1>avec mes talents d'lecture !");
                return s;
            };

            // [21] BB\script\output\_sce04_c101_0040_eng#14
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#14"] = (s) => {
                s = s.Replace("(Gina's only just learnt to read.<E003 8> <E025 2>There's a good chance she\r\nmight <E006>make a mistake<E007>...)", "(Gina vient à peine d'apprendre à lire.<E003 8> <E025 2>Elle a de fortes chances\r\nde <E006>commettre une erreur<E007>...)");
                s = s.Replace("(I worry she might mix up the letters <E149 1 0 0><E003 6><E330>‘p’ and ‘q’ <E003 8>and\r\n‘b’ and ‘d’...)", "(J'ai peur qu'elle confonde le <E149 1 0 0><E003 6><E330>« p » et le « q », <E003 8>ou le\r\n« b » et le « d »...)");
                s = s.Replace("That's enough o' your cheek, <E049><E003 10><E025 1><E335>'Oddo!", "Ça va bien l'insolence, <E049><E003 10><E025 1><E335>'Odoh !");
                s = s.Replace("I'm way past ‘E’ now!<E049><E003 6> <E164 122 91 1 2 8 0 2 1><E118 122 1.2><E139 122><E025 1>I've got all the way to ‘V’!", "J'ai dépassé le « E » depuis des lustres !<E049><E003 6> <E164 122 91 1 2 8 0 2 1><E118 122 1.2><E139 122><E025 1>J'suis rendue jusqu'au « V » !");
                s = s.Replace("Just to err on the side of caution, <E049><E003 10><E025 1><E346>the defence will wait\r\nuntil the witness can read all the letters up to ‘Z’!", "Par simple souci de prudence, <E049><E003 10><E025 1><E346>la défense préfère attendre\r\nque le témoin sache lire jusqu'au « Z » !");
                s = s.Replace("Grrr...", "Grrr...");
                s = s.Replace("In that case, <E049><E003 6>let's get back to the witness's testimony,<E049><E003 8><E025 3> shall\r\nwe?", "Dans ce cas, <E049><E003 6>revenons à la déposition du témoin,<E049><E003 8><E025 3> si vous le voulez bien.");
                return s;
            };

            // [22] BB\script\output\_sce04_c101_0040_eng#15
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#15"] = (s) => {
                s = s.Replace("The Grouse?<E049><E003 14>\r\n<E025 2>What sort of a club is that?", "The Grouse ?<E049><E003 14>\r\n<E025 2>Quel genre d'établissement est-ce là ?");
                s = s.Replace("I ain't got the foggiest.<E049><E003 12>\r\n<E025 2>Clubs ain't exactly my thing.", "J'en sais fichtre rien.<E049><E003 12>\r\n<E025 2>Les clubs huppés, c'est pas mon truc.");
                s = s.Replace("But...<E049><E003 6><E025 1><E164 122 89 1 2 6 0 0 1><E139 122>I am kind o' curious!", "Mais...<E049><E003 6><E025 1><E164 122 89 1 2 6 0 0 1><E139 122>j'suis quand même bien curieuse !");
                s = s.Replace("They're not places where a foreign student like you\r\nwould be readily admitted.", "Ce ne sont guère des cercles où un étudiant étranger comme vous\r\npourrait franchir le seuil.");
                s = s.Replace("Have you looked in the mirror recently?", "Vous vous êtes regardé dans un miroir récemment ?");
                s = s.Replace("I tell ya wot!", "J'ai une idée !");
                s = s.Replace("Me and Chief Inspector Toby could go in undercover!", "Moi et l'commissaire divisionnaire Toby, on pourrait y aller sous couverture !");
                s = s.Replace("Could you, <E049><E003 4>though?", "Vous le pourriez, <E049><E003 4>sérieusement ?");
                s = s.Replace("I could pick out a few good marks <E049><E003 10><E025 1><E346>an' see wot else I could\r\nfind out while I was in there!", "J'pourrais repérer quelques bons pigeons <E049><E003 10><E025 1><E346>et fouiner pour voir\r\nc'que j'peux dégoter là-bas !");
                s = s.Replace("...I really don't think you should go<E003 4> ‘picking’ out anything.", "...Je vous déconseille formellement de vous mettre à « chiper » quoi que ce soit.");
                s = s.Replace("Anyway, <E049><E003 10>that's where these black market dealings were\r\ngoing to take place, <E003 4>is it?", "Quoi qu'il en soit, <E049><E003 10>c'est là que cette affaire de contrebande\r\ndevait se conclure, <E003 4>n'est-ce pas ?");
                s = s.Replace("Yeah, <E049><E003 8>it's gotta be.<E049><E003 8> That's wot the lower-rankin' detectives\r\nat the Yard reckon.", "Ouais, <E049><E003 8>c'est certain.<E049><E003 8> C'est c'que pensent les gars\r\ndu Yard.");
                s = s.Replace("(Says the even lower-ranking detective...)", "(Dit l'inspectrice encore plus subalterne...)");
                return s;
            };

            // [23] BB\script\output\_sce04_c101_0040_eng#16
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#16"] = (s) => {
                s = s.Replace("So how had Inspector Gregson come to find out about it,<E049><E003 8>\r\nin that case?", "Comment l'inspecteur Gregson en avait-il été informé,<E049><E003 8>\r\ndans ce cas ?");
                s = s.Replace("From an informant.<E049><E003 12> That's wot 'is notes say, anyway.", "Par un indic.<E049><E003 12> C'est c'que disent ses notes, en tout cas.");
                s = s.Replace("An informant?", "Un informateur ?");
                s = s.Replace("Yeah, <E049><E003 6>some bludger from the London docks.", "Ouais, <E049><E003 6>un lascar des docks de Londres.");
                s = s.Replace("And were there details about this informant in the\r\nnotebook?", "Y avait-il des précisions sur cet informateur dans son carnet ?");
                s = s.Replace("Just a surname.<E049><E003 12> <E145 122 71>‘Sandwich’.", "Juste un nom d'famille.<E049><E003 12> <E145 122 71>« Sandwich ».");
                s = s.Replace("Sandwich?!", "Sandwich ?!");
                s = s.Replace("Sounds delicious...<E003 12><E025 2>though maybe not quite as filling as\r\nsoba noodles.", "Ça sonne appétissant...<E003 12><E025 2>bien que sans doute moins nourrissant\r\nqu'un bon bol de nouilles soba.");
                s = s.Replace("I know that name!<E049><E003 10> <E025 2>He was one of the street sellers we\r\nspoke to yesterday!", "Je connais ce nom !<E049><E003 10> <E025 2>C'était l'un des marchands ambulants que\r\nnous avons interrogés hier !");
                s = s.Replace("Barlun Sandwich!<E049><E003 12> The boardman!", "Barlun Sandwich !<E049><E003 12> L'homme-sandwich !");
                s = s.Replace("So he was Gregson's informant...", "C'était donc lui, l'informateur de Gregson...");
                return s;
            };

            // [24] BB\script\output\_sce04_c101_0040_eng#17
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#17"] = (s) => {
                s = s.Replace("So who was it that saw Lord van Zieks at the club?", "Qui a donc aperçu Lord Van Peers dans ce club ?");
                s = s.Replace("Some o' the staff there.", "Des employés de l'établissement.");
                s = s.Replace("And they're certain it was him?", "Et ils sont catégoriques ?");
                s = s.Replace("Yup.<E049><E003 10> Said 'e was wearin' 'is usual dark coat with the collar\r\nturned up.", "Ouaip.<E049><E003 10> Ils ont dit qu'il portait sa grande cape sombre habituelle avec\r\nle col relevé.");
                s = s.Replace("...It's hardly an everyday garment, <E049><E003 6>I suppose.", "...Ce n'est guère une tenue commune, <E049><E003 6>j'en conviens.");
                s = s.Replace("And did the staff hear what was said?", "Et le personnel a-t-il entendu ce qui s'est dit ?");
                s = s.Replace("Nah.<E049><E003 8> The door to the private room was shut tight.", "Nan.<E049><E003 8> La porte du salon privé était bien verrouillée.");
                s = s.Replace("So they only saw him going in and coming out.", "Ils ne l'ont donc vu qu'entrer et sortir.");
                s = s.Replace("That's it.<E049><E003 10> But there ain't no doubt 'e was in there with the\r\nboss.", "C'est tout.<E049><E003 10> Mais ça fait aucun doute qu'il était là-d'dans avec\r\nl'patron.");
                return s;
            };

            // [25] BB\script\output\_sce04_c101_0040_eng#18
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#18"] = (s) => {
                s = s.Replace("Witness.<E049><E003 10> When you say ‘The Grouse’...", "Témoin.<E049><E003 10> Lorsque vous dites « The Grouse »...");
                s = s.Replace("...are you certain that refers to a gentleman's club?", "...êtes-vous absolument certaine qu'il s'agit d'un club de gentlemen ?");
                s = s.Replace("Course I am!<E049><E003 10> Wot else could it be?", "Bien sûr que oui !<E049><E003 10> Qu'est-ce que ça s'rait d'autre ?");
                s = s.Replace("Look closely at the notebook in your hands.", "Examinez attentivement le carnet entre vos mains.");
                s = s.Replace("What about it?", "Qu'est-ce qu'il a ?");
                s = s.Replace("The name ‘Grouse’...<E049><E003 10><E025 2>doesn't refer to a club at all.", "Le nom « Grouse »...<E049><E003 10><E025 2>ne désigne pas du tout un club.");
                s = s.Replace("Wot?!<E049><E003 12> Then wot does it mean?!", "Quoi ?!<E049><E003 12> Alors ça veut dire quoi ?!");
                s = s.Replace("It refers to...", "Il fait référence à...");
                return s;
            };

            // [26] BB\script\output\_sce04_c101_0040_eng#26
            entryTranslators[@"BB\script\output\_sce04_c101_0040_eng#26"] = (s) => {
                s = s.Replace("The name ‘Grouse’ in the victim's notebook...", "Le nom « Grouse » consigné dans le carnet de la victime...");
                s = s.Replace("...doesn't refer to a club in London.", "...ne fait absolument pas référence à un club londonien.");
                s = s.Replace("It's the name of a ship!<E049><E003 12> A steamship!", "C'est le nom d'un navire !<E049><E003 12> Un navire à vapeur !");
                s = s.Replace("A ship?!", "Un navire ?!");
                s = s.Replace("I have evidence to prove it, My Lord!", "Et j'ai la preuve formelle pour l'attester, Votre Honneur !");
                s = s.Replace("Show the court this evidence of yours, then!", "Montrez donc cette preuve à la cour dans ce cas !");
                return s;
            };

            // [27] BB\script\output\_sce04_c101_0050_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0050_eng#2"] = (s) => {
                s = s.Replace("I have here a ticket for passage upon the SS Grouse!", "J'ai entre les mains un billet de traversée à bord du SS Grouse !");
                s = s.Replace("It was found in the victim's secret office!", "Il a été retrouvé dans le bureau secret de la victime !");
                s = s.Replace("‘This dark-suited young man is not in the least bit\r\nuntrustworthy.’", "« Ce jeune homme vêtu de sombre n'est en rien indigne de confiance. »");
                s = s.Replace("Ah!<E049><E003 12> <E169 1 0>Um...<E003 10><E169 1 3><E025 2><E145 1 11><E003 8><E330>the other side, <E049><E003 6>My Lord.", "Ah !<E049><E003 12> <E169 1 0>Hum...<E003 10><E169 1 3><E025 2><E145 1 11><E003 8><E330>de l'autre côté, <E049><E003 6>Votre Honneur.");
                s = s.Replace("...Be more specific next time.", "...Soyez plus explicite la prochaine fois.");
                s = s.Replace("Ah...<E049><E003 10> <E025 2>This would appear to be a ticket for passage upon a\r\nsteamship, <E049><E003 6><E025 3>yes...", "Ah...<E049><E003 10> <E025 2>Il apparaît en effet qu'il s'agit d'un titre de transport\r\npour un vapeur, <E049><E003 6><E025 3>en effet...");
                s = s.Replace("The SS Grouse...", "Le SS Grouse...");
                s = s.Replace("So there's a steamship named the Grouse <E049><E003 10><E025 2><E145 112 13><E118 112 1.5><E003 6>that happens to\r\nshare a name with the club.", "Il existe donc un vapeur baptisé le Grouse <E049><E003 10><E025 2><E145 112 13><E118 112 1.5><E003 6>qui porte par hasard\r\nle même nom que le club.");
                s = s.Replace("But I'm afraid to say...", "Mais je crains de devoir vous faire remarquer...");
                s = s.Replace("...there's a flaw in your logic there.", "...qu'il y a une faille béante dans votre raisonnement.");
                s = s.Replace("How?", "Laquelle ?");
                s = s.Replace("Look at the ticket.<E049><E003 10> <E145 112 0><E118 112 0.6><E003 12><E025 2>Notice the date of arrival in port.", "Regardez ce billet.<E049><E003 10> <E145 112 0><E118 112 0.6><E003 12><E025 2>Notez bien la date d'accostage au port.");
                s = s.Replace("The ship arrived at the Port of Dover <E049><E003 8><E025 3>on 1st November.<E049><E003 10>\r\n<E025 1><E145 61 5><E118 61 1.2><E003 8><E334>...Ah!", "Le navire est arrivé au port de Douvres <E049><E003 8><E025 3>le 1er novembre.<E049><E003 10>\r\n<E025 1><E145 61 5><E118 61 1.2><E003 8><E334>...Ah !");
                s = s.Replace("The day on which the sound like a gunshot was heard on\r\nFresno Street.", "Le jour même où la détonation a retenti dans la rue Fresno.");
                s = s.Replace("In other words...", "En d'autres termes...");
                s = s.Replace("...on the day in question here –<E049><E003 6><E025 3> 31st October –<E049><E003 8> <E025 2>when the\r\nvictim was on his clandestine mission...", "...le jour des faits ici en cause...<E049><E003 6><E025 3> le 31 octobre...<E049><E003 8> <E025 2>alors que la\r\nvictime menait sa mission clandestine...");
                s = s.Replace("...that ship hadn't yet docked on British shores!", "...ce navire n'avait pas encore abordé les côtes britanniques !");
                s = s.Replace("That would certainly make an undercover investigation<E049><E003 6>\r\n<E145 61 5><E118 61 0.7><E003 10><E025 3><E338><E341>somewhat challenging.", "Cela rendrait pour le moins ardue toute tentative de filature<E049><E003 6>\r\n<E145 61 5><E118 61 0.7><E003 10><E025 3><E338><E341>à bord de ce bâtiment.");
                s = s.Replace("The fact that the steamship hadn't yet reached Britain...", "Le fait que le navire n'ait pas encore atteint la Grande-Bretagne...");
                s = s.Replace("...substantiates the defence's assertion that the victim was\r\ninvestigating the SS Grouse on the day in question!", "...corrobore précisément la thèse de la défense affirmant que la victime\r\nenquêtait à bord du SS Grouse ce jour-là !");
                s = s.Replace("Then show your evidence for that assertion!", "Présentez donc une preuve de cette affirmation péremptoire !");
                return s;
            };

            // [28] BB\script\output\_sce04_c101_0060_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#2"] = (s) => {
                s = s.Replace("In that case, <E049><E003 6>Counsel for the Defence, <E049><E003 8><E025 2>present your\r\nevidence to the court now.", "Dans ce cas, <E049><E003 6>la défense, <E049><E003 8><E025 2>produisez votre pièce à conviction\r\ndevant le tribunal dès à présent.");
                return s;
            };

            // [29] BB\script\output\_sce04_c101_0060_eng#3
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#3"] = (s) => {
                s = s.Replace("Evidence that substantiates your claim that the victim was\r\ninvestigating the SS Grouse on 31st October.", "La preuve attestant que la victime menait une enquête à bord du SS Grouse le 31 octobre.");
                return s;
            };

            // [30] BB\script\output\_sce04_c101_0060_eng#4
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#4"] = (s) => {
                s = s.Replace("It's proven...<E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>by this evidence here!", "C'est prouvé...<E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>par cette pièce à conviction !");
                s = s.Replace("Yes, <E049><E003 4><E145 1 66><E003 15><E025 2><E238>this evidence proves it...<E003 10><E025 3>I think...", "Oui, <E049><E003 4><E145 1 66><E003 15><E025 2><E238>cette preuve le démontre...<E003 10><E025 3>du moins je crois...");
                s = s.Replace("The, <E049><E003 4><E145 1 11><E003 15><E025 2><E239>the proof is in the pudding?", "C'est... <E049><E003 4><E145 1 11><E003 15><E025 2><E239>clair comme de l'eau de roche, non ?");
                s = s.Replace("Those three equally nonsensical statements <E049><E003 10><E333><E025 3>wasted\r\nfifteen seconds <E049><E003 6><E025 2>of the court's time.", "Ces trois déclarations aussi absurdes qu'incohérentes <E049><E003 10><E333><E025 3>ont fait perdre\r\nquinze secondes <E049><E003 6><E025 2>au temps précieux de cette cour.");
                s = s.Replace("You will accordingly suffer fifteen seconds' worth of\r\npenalty, <E049><E003 6><E025 3>Counsel.", "Vous subirez en conséquence une pénalité équivalente à ces quinze secondes,\r\n<E049><E003 6><E025 3>Maître.");
                s = s.Replace("(I need to work on picking a more succinct turn of\r\nphrase.)", "(Il faut vraiment que j'apprenne à être plus concis.)");
                s = s.Replace("I think you might need to work on picking a more\r\nappropriate piece of evidence first.", "Je pense que vous devriez d'abord apprendre à choisir une preuve\r\nplus pertinente.");
                s = s.Replace("(I'm sure Gregson was on board that ship the day before\r\nhis body was found.)", "(Je suis certain que Gregson était à bord de ce navire la veille\r\nde la découverte de son corps.)");
                s = s.Replace("(And we know the SS Grouse stopped at the Port of\r\nDunkirk in France for the night...)", "(Et nous savons que le SS Grouse a fait escale au port de Dunkerque\r\nen France pour la nuit...)");
                s = s.Replace("I take it from your expression <E049><E003 6><E145 61 9><E003 10><E239><E025 3>that you intend to risk\r\nfurther penalty.", "Je déduis de votre mine déconfite <E049><E003 6><E145 61 9><E003 10><E239><E025 3>que vous comptez risquer\r\nune nouvelle sanction.");
                return s;
            };

            // [31] BB\script\output\_sce04_c101_0060_eng#5
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#5"] = (s) => {
                s = s.Replace("What's this?<E049><E003 10> <E025 2><E145 61 7><E118 61 0.6>A passport for travel issued to the victim?", "Qu'est-ce donc ?<E049><E003 10> <E025 2><E145 61 7><E118 61 0.6>Un passeport de voyage délivré à la victime ?");
                s = s.Replace("Dated 31st October?<E049><E003 10>\r\n<E025 3><E145 61 5><E118 61 0.5><E003 12><E239>...What are you suggesting?", "En date du 31 octobre ?<E049><E003 10>\r\n<E025 3><E145 61 5><E118 61 0.5><E003 12><E239>...Que sous-entendez-vous ?");
                s = s.Replace("This passport proves <E049><E003 8><E025 2>that on 31st October, <E049><E003 8><E025 3>the victim,\r\nInspector Tobias Gregson...", "Ce passeport prouve <E049><E003 8><E025 2>que le 31 octobre, <E049><E003 8><E025 3>la victime,\r\nl'inspecteur Tobias Gregson...");
                s = s.Replace("...travelled to France upon the SS Grouse!", "...a voyagé en France à bord du SS Grouse !");
                s = s.Replace("He travelled to France?!", "Il s'est rendu en France ?!");
                s = s.Replace("It was during that voyage <E049><E003 8><E025 3>that he was carrying out his\r\ninvestigation.", "C'est durant cette traversée <E049><E003 8><E025 3>qu'il menait sa discrète\r\nenquête.");
                s = s.Replace("The passport was found on the victim's person.", "Ce passeport a été découvert sur la victime elle-même.");
                s = s.Replace("Which means that Inspector Gregson was indeed on that\r\nship.", "Ce qui signifie que l'inspecteur Gregson se trouvait bel et bien à bord.");
                s = s.Replace("And the SS Grouse was in international waters that day.", "Et le SS Grouse naviguait dans les eaux internationales ce jour-là.");
                s = s.Replace("It would have been physically impossible <E049><E003 8><E025 2>for Lord van\r\nZieks to have met him at a London club!", "Il était par conséquent matériellement impossible <E049><E003 8><E025 2>que Lord Van\r\nPeers l'ait rencontré dans un club londonien !");
                s = s.Replace("Order! Order in the gallery!", "Silence ! Silence dans l'assistance !");
                s = s.Replace("Prosecutor Asogi. <E049><E003 8>Explain this.", "Procureur Asogi. <E049><E003 8>Expliquez-vous.");
                s = s.Replace("The prosecution does not dispute <E049><E003 6><E025 2>that Gregson travelled to\r\nFrance on 31st October.", "L'accusation ne conteste nullement <E049><E003 6><E025 2>que Gregson ait voyagé vers\r\nla France le 31 octobre.");
                s = s.Replace("You don't?", "Vous ne le contestez pas ?");
                s = s.Replace("However, <E049><E003 6>that does not exonerate the accused.", "Toutefois, <E049><E003 6>cela n'innocente en rien l'accusé.");
                s = s.Replace("Because the notebook in Miss Lestrade's hands <E049><E003 8><E025 2>proves that\r\nthere was another meeting.", "Car le carnet que détient mademoiselle Lestrade <E049><E003 8><E025 2>atteste de l'existence\r\nd'un autre rendez-vous.");
                s = s.Replace("Another meeting?", "Un autre rendez-vous ?");
                s = s.Replace("A meeting between the victim and the Reaper.", "Une rencontre secrète entre la victime et le Faucheur.");
                return s;
            };

            // [32] BB\script\output\_sce04_c101_0060_eng#6
            entryTranslators[@"BB\script\output\_sce04_c101_0060_eng#6"] = (s) => {
                s = s.Replace("The prosecution wishes to submit that the notebook in\r\nquestion...", "L'accusation entend démontrer que le carnet en question...");
                s = s.Replace("That doesn't contain details of secret investigations at all.", "...ne consigne nullement de simples filatures secrètes.");
                s = s.Replace("It describes ten years of <E006>assassination plots<E005> to be carried\r\nout by the Reaper of the Bailey.", "Il détaille dix années de <E006>contrats d'assassinat<E005> exécutés par\r\nle Faucheur de l'Old Bailey.");
                s = s.Replace("Yer lyin'!", "C'est du flan !");
                s = s.Replace("Even if all them bludgers wot got taken out 'ad it comin'...", "Même si tous ces pourris ont eu c'qu'ils méritaient...");
                s = s.Replace("...the boss <E049><E003 10><E025 1><E335>weren't the Reaper!", "...l'patron <E049><E003 10><E025 1><E335>était pas l'Faucheur !");
                s = s.Replace("Poor Gina...", "Pauvre Gina...");
                s = s.Replace("There's no question that Tobias Gregson was heavily\r\ninvolved in the Reaper's activities.", "Il est incontestable que Tobias Gregson a trempé jusqu'au cou dans les agissements du Faucheur.");
                s = s.Replace("You may just be an apprentice, <E049><E003 8><E025 2>but if you've spent any\r\ntime at Scotland Yard, <E049><E003 8>you must have heard rumours...", "Vous n'êtes qu'une apprentie, <E049><E003 8><E025 2>mais quiconque a mis les pieds\r\nà Scotland Yard <E049><E003 8>a forcément entendu ces rumeurs...");
                s = s.Replace("I ain't 'eard nuffin'!<E049><E003 14>\r\n<E341>An' I don't believe a word of it!", "J'ai rien entendu du tout !<E049><E003 14>\r\n<E341>Et j'crois pas un traître mot d'vos salades !");
                s = s.Replace("Then testify again.<E049><E003 10>\r\n<E025 3>As a representative of Scotland Yard.", "Dans ce cas, déposez à nouveau.<E049><E003 10>\r\n<E025 3>En qualité de représentante de Scotland Yard.");
                s = s.Replace("Consider it...<E003 7><E145 112 1><E118 112 0.85><E003 10><E025 2>your chance to defend your ‘boss’.", "Voyez-y...<E003 7><E145 112 1><E118 112 0.85><E003 10><E025 2>l'opportunité de laver l'honneur de votre « patron ».");
                s = s.Replace("I, <E049><E003 8>I don't...", "Je... <E049><E003 8>j'sais pas...");
                s = s.Replace("I concur.<E049><E003 10> <E025 3>The witness will give a new formal testimony.", "J'y consens.<E049><E003 10> <E025 3>Le témoin va formuler une nouvelle déposition officielle.");
                s = s.Replace("Miss Lestrade, <E049><E003 8><E025 1>you will tell the court everything you\r\nknow about Inspector Gregson's secret notebook!", "Mademoiselle Lestrade, <E049><E003 8><E025 1>vous direz à la cour tout ce que vous\r\nsavez sur le carnet secret de l'inspecteur Gregson !");
                return s;
            };

            // [33] BB\script\output\_sce04_c101_0070_eng#2
            entryTranslators[@"BB\script\output\_sce04_c101_0070_eng#2"] = (s) => {
                s = s.Replace("– The Secret of the Notebook –", "– Le secret du carnet –");
                return s;
            };

            // [34] BB\script\output\_sce04_c102_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c102_0000_eng#2"] = (s) => {
                s = s.Replace("– The Reaper's Notebook –", "– Le carnet du Faucheur –");
                s = s.Replace("Yeah, <E049><E003 6><E025 2>this notebook does 'ave a load o' stuff about wot the\r\nReaper got up to these past ten years.", "Ouais, <E049><E003 6><E025 2>ce carnet contient un tas d'trucs sur les coups montés\r\npar l'Faucheur ces dix dernières années.");
                s = s.Replace("Names o' victims, <E049><E003 6>dates <E049><E003 6>an' places an' stuff...<E049><E003 12>\r\n<E025 2>An' the last entry in there was 31st October.", "Des noms d'victimes, <E049><E003 6>des dates, <E049><E003 6>des endroits...<E049><E003 12>\r\n<E025 2>Et la dernière ligne, c'était l'31 octobre.");
                s = s.Replace("It said ‘Grouse’ for the place on that date, <E049><E003 10><E333>and then the\r\nname o' the mark.", "Y avait écrit « Grouse » pour le lieu, <E049><E003 10><E333>et l'nom de la cible juste à côté.");
                s = s.Replace("There was a note about 'im bein' a criminal wot got away\r\nfrom the Reaper in court ten years ago or summat.", "Y avait une note disant qu'c'était un truand qui avait échappé au\r\nFaucheur au tribunal y a dix piges.");
                s = s.Replace("But honest!<E049><E003 12> The boss didn't do none of it!<E049><E003 12>\r\n<E025 3>'E was...<E003 12> <E025 1><E345>'E was just investigatin' the Reaper,<E049><E003 6> that's all!", "Mais j'vous jure !<E049><E003 12> L'patron a rien fait d'tout ça !<E049><E003 12>\r\n<E025 3>Il était...<E003 12> <E025 1><E345>il enquêtait juste sur l'Faucheur,<E049><E003 6> c'est tout !");
                return s;
            };

        }
    }
}
