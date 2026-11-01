using System;
using System.Collections.Generic;

namespace TranslatorEp5Act1 {
    public partial class Program {
        public static void RegisterPart4() {

            // [100] BB\script\output\_sce04_c104_0050_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0050_eng#2"] = (s) => {
                s = s.Replace("W-<E049><E003 8><E341>What is this?", "Q-<E049><E003 8><E341>Qu'est-ce que c'est que ça ?");
                s = s.Replace("We have but minutes until the vessel puts to sea.<E003 10>\r\n<E025 3>No games now.", "Nous n'avons que quelques minutes avant que le navire ne prenne le large.<E003 10>\r\n<E025 3>Trêve de plaisanteries.");
                s = s.Replace("Time is of the essence!", "Le temps presse !");
                s = s.Replace("Mr Strogenov, <E049><E003 8><E146 51 65><E149 51 1 0><E492 51 -177 15 2>allow me to remind you of your earlier\r\nclaim:", "Monsieur Strogenov, <E049><E003 8><E146 51 65><E149 51 1 0><E492 51 -177 15 2>permettez-moi de vous rappeler vos déclarations\r\nprécédentes :");
                s = s.Replace("You told us that Jigoku left the ship some two hours ago.", "Vous nous avez affirmé que Jigoku avait quitté le bord il y a deux heures.");
                s = s.Replace("Da!<E049><E003 15> <E025 1>That is what I said!", "Da !<E049><E003 15> <E025 1>C'est exactement ce que moi avoir dit !");
                s = s.Replace("Sadly, <E049><E003 10>that was a rather clumsy lie.", "Hélas, <E049><E003 10>ce n'était là qu'un bien grossier mensonge.");
                s = s.Replace("You see, <E049><E003 10><E043>there is something in this room that quite clearly\r\n<E006>contradicts<E005> it.", "Figurez-vous <E049><E003 10><E043>qu'un élément dans cette pièce le <E006>contredit<E005>\r\nflagrannement.");
                s = s.Replace("What?!", "Quoi ?!");
                s = s.Replace("Ah!<E049><E003 16>\r\n<E025 3><E007>(Yes,<E003 8> of course...)", "Ah !<E049><E003 16>\r\n<E025 3><E007>(Mais oui,<E003 8> bien sûr...)");
                s = s.Replace("I see you've noted it too, <E003 4>Mikotoba.<E049><E003 10>\r\nThen please, <E049><E003 8>do take the lead...", "Je vois que vous l'avez remarqué aussi, <E003 4>Mikotoba.<E049><E003 10>\r\nDans ce cas, je vous en prie, <E049><E003 8>ouvrez le bal...");
                s = s.Replace("What in this cabin <E049><E003 12><E046><E025 1>shows the impossibility of Jigoku\r\nhaving disembarked two hours ago?", "Qu'est-ce qui dans cette cabine <E049><E003 12><E046><E025 1>rend impossible le fait que Jigoku\r\nait débarqué il y a deux heures ?");
                return s;
            };

            // [101] BB\script\output\_sce04_c104_0050_eng#7
            entryTranslators[@"BB\script\output\_sce04_c104_0050_eng#7"] = (s) => {
                s = s.Replace("Let's see what the last three years have done to your\r\nobservational skills then, <E003 8><E025 1><E346>Mikotoba!", "Voyons ce que ces trois dernières années ont fait de vos\r\ntalents d'observation, <E003 8><E025 1><E346>Mikotoba !");
                s = s.Replace("It's been ten years since we last did this, Sholmes, <E003 8>not\r\nthree.", "Cela fait dix ans que nous n'avons pas fait cela, Sholmes, <E003 8>et non\r\ntrois.");
                s = s.Replace("Why, <E003 8>of course it has!<E003 12> Quite!", "Mais <E003 8>évidemment !<E003 12> Tout à fait !");
                s = s.Replace("Now, <E003 8>all the clues are here in this cabin for your eyes to\r\nsee.", "À présent, <E003 8>tous les indices sont sous vos yeux dans cette cabine.");
                s = s.Replace("But as I always say, <E003 10><E330>you must not merely look, <E003 8><E025 3>but\r\nobserve.<E003 10> Observe <E003 10>and the answers become clear.", "Mais comme je le répète toujours, <E003 10><E330>il ne faut pas seulement regarder, <E003 8><E025 3>mais\r\nobserver.<E003 10> Observez <E003 10>et la lumière jaillira.");
                s = s.Replace("So...<E003 16><E332><E025 2>impress me!", "Alors... <E003 16><E332><E025 2>éblouissez-moi !");
                s = s.Replace("I think I can manage that!", "Je devrais pouvoir m'en sortir !");
                return s;
            };

            // [102] BB\script\output\_sce04_c104_0050_eng#8
            entryTranslators[@"BB\script\output\_sce04_c104_0050_eng#8"] = (s) => {
                s = s.Replace("Jigoku didn't disembark two hours ago at all.<E003 12>\r\n<E025 3><E333>That was a lie, <E003 8>wasn't it?", "Jigoku n'a absolument pas débarqué il y a deux heures.<E003 12>\r\n<E025 3><E333>C'était un mensonge, <E003 8>n'est-ce pas ?");
                s = s.Replace("Of course it was.<E003 10> And I had hoped you would be quicker\r\nto point out why.", "Bien sûr que c'en était un.<E003 10> Et j'espérais que vous seriez plus prompt\r\nà m'en indiquer la raison.");
                s = s.Replace("Otherwise...<E003 14><E025 1><E330>the evidence itself may melt away before our\r\nvery eyes!", "Autrement...<E003 14><E025 1><E330>la preuve risque de fondre sous nos propres\r\nyeux !");
                return s;
            };

            // [103] BB\script\output\_sce04_c104_0050_eng#11
            entryTranslators[@"BB\script\output\_sce04_c104_0050_eng#11"] = (s) => {
                s = s.Replace("What in this cabin shows the impossibility of Jigoku\r\nhaving disembarked two hours ago?", "Qu'est-ce qui dans cette cabine démontre l'impossibilité d'un\r\ndébarquement de Jigoku il y a deux heures ?");
                return s;
            };

            // [104] BB\script\output\_sce04_c104_0050_eng#12
            entryTranslators[@"BB\script\output\_sce04_c104_0050_eng#12"] = (s) => {
                s = s.Replace("Perhaps you should have cleared away that glass?", "Peut-être auriez-vous dû débarrasser ce verre ?");
                s = s.Replace("How curious<E003 6> that the ice shouldn't have melted despite it\r\nbeing abandoned two hours ago?", "N'est-il pas curieux<E003 6> que ces glaçons n'aient pas fondu s'ils ont été\r\nabandonnés voilà deux heures ?");
                s = s.Replace("Ah!<E003 20><E024>", "Ha !<E003 20><E024>");
                s = s.Replace("It would appear<E049><E003 8> that the man was here in this very cabin\r\nuntil moments before our arrival...", "Il semblerait<E049><E003 8> que cet homme se trouvait dans cette même cabine\r\nquelques instants à peine avant notre arrivée...");
                s = s.Replace("...with this well-chilled glass in hand!", "...avec ce verre bien frais entre les mains !");
                s = s.Replace("(Get your mind off the refreshments,<E003 6> Sholmes.)", "(Ne pensez pas qu'aux rafraîchissements,<E003 6> Sholmes.)");
                s = s.Replace("One might even conclude<E049><E003 10> <E333><E025 2>that somebody informed him of\r\nour boarding.", "On pourrait même conclure<E049><E003 10> <E333><E025 2>que quelqu'un l'a averti de\r\nnotre embarquement.");
                s = s.Replace("Wouldn't you agree, <E049><E003 8>Mr Strogenov?", "N'en convenez-vous pas, <E049><E003 8>monsieur Strogenov ?");
                s = s.Replace("Errr...", "Euuuh...");
                return s;
            };

            // [105] BB\script\output\_sce04_c104_0060_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0060_eng#2"] = (s) => {
                s = s.Replace("why would Seishiro run from us?", "pourquoi Seishiro s'enfuirait-il en nous voyant ?");
                s = s.Replace("Before we consider that question, <E003 8><E333>allow me to confirm one\r\nsmall matter:", "Avant d'aborder cette interrogation, <E003 8><E333>permettez-moi d'éclaircir un\r\ndétail :");
                s = s.Replace("Would I be correct in saying that these first-class cabins\r\nof the SS Grouse...", "Aurais-je raison d'affirmer que ces cabines de première classe\r\ndu SS Grouse...");
                s = s.Replace("...are the same ones in which you and Mr Jigoku were\r\naccommodated on your voyage from Japan?", "...sont les mêmes dans lesquelles M. Jigoku et vous avez été\r\nlogés lors de votre traversée depuis le Japon ?");
                s = s.Replace("Ah!<E003 14> <E025 3>That's...<E003 12><E025 2>that's right, <E003 8>they are.", "Ah !<E003 14> <E025 3>C'est... <E003 12><E025 2>c'est tout à fait exact, en effet.");
                s = s.Replace("I was in the cabin next door, <E003 8>and Seishiro was...<E003 12><E025 3>yes...", "J'étais dans la cabine voisine, <E003 8>et Seishiro occupait... <E003 12><E025 3>oui...");
                s = s.Replace("...fifty days in this very cabin during our voyage!", "...cinquante jours durant cette même cabine durant notre traversée !");
                s = s.Replace("As I suspected.<E003 12>\r\n<E025 3>For you see...", "Comme je le soupçonnais.<E003 12>\r\n<E025 3>Car voyez-vous...");
                s = s.Replace("...there are <E006>traces<E005> in this cabin of a dark secret that\r\nMr Jigoku had to hide.", "...il subsiste des <E006>traces<E005> dans cette pièce d'un sombre secret que\r\nM. Jigoku a dû dissimuler.");
                s = s.Replace("What traces?", "Quelles traces ?");
                s = s.Replace("I, <E049><E003 18><E335>I know nothing about this!", "M-, <E049><E003 18><E335>moi savoir rien du tout là-dessus !");
                s = s.Replace("Ah, <E049><E003 8>this is news to you, <E049><E003 8>is it, <E049><E003 6>Mr Strogenov?", "Ah, <E049><E003 8>vous tombez des nues, <E049><E003 8>n'est-ce pas, <E049><E003 6>monsieur Strogenov ?");
                s = s.Replace("Sholmes, <E049><E003 6><E341><E025 1>what exactly are you getting at?", "Sholmes, <E049><E003 6><E341><E025 1>où voulez-vous donc en venir ?");
                s = s.Replace("As I said, <E003 8><E330>there are <E006>traces<E005> in this cabin of some nefarious\r\nactivity.", "Comme je l'ai dit, <E003 8><E330>cette cabine porte les <E006>traces<E005> d'un bien funeste\r\nforfait.");
                s = s.Replace("Something that appears out of place, <E003 8><E333>which I'm quite sure\r\nwon't have escaped your notice.", "Quelque chose de déplacé, <E003 8><E333>qui n'aura sans nul doute pas\r\néchappé à votre sagacité.");
                s = s.Replace("(Something <E006>out of place<E007> in here...?)", "(Quelque chose <E006>d'anormal<E007> ici... ?)");
                s = s.Replace("That's the key to this, <E003 6>Mikotoba.", "C'est la clé de cette énigme, <E003 6>Mikotoba.");
                s = s.Replace("The remnants of the dark deed that took place in here<E049><E003 10><E025 1><E607> are\r\nbeing masked by something quite incongruous!", "Les vestiges du crime perpétré en ces lieux<E049><E003 10><E025 1><E607> sont\r\nmasqués par un élément parfaitement incongru !");
                return s;
            };

            // [106] BB\script\output\_sce04_c104_0060_eng#7
            entryTranslators[@"BB\script\output\_sce04_c104_0060_eng#7"] = (s) => {
                s = s.Replace("I must say, <E003 8>I didn't foresee ever doing this dance of\r\ndeduction with you again, <E003 6>Mikotoba.", "Je dois avouer que <E003 8>je ne prévoyais pas d'exécuter à nouveau cette danse\r\nde déduction avec vous, <E003 6>Mikotoba.");
                s = s.Replace("No, <E003 6>quite.<E003 10> <E025 2>But life is full of unexpected twists and turns,<E003 8> as\r\nwe well know.", "En effet.<E003 10> <E025 2>Mais l'existence réserve bien des surprises,<E003 8> comme\r\nnous le savons pertinemment.");
                s = s.Replace("Now then, <E003 10><E025 1><E332>let's see if I can't uncover the truth here...", "Bien, <E003 10><E025 1><E332>voyons si je ne parviens pas à faire éclater la vérité...");
                s = s.Replace("Yes, <E003 10><E607><E025 1>you have the floor, my dear fellow!", "Oui, <E003 10><E607><E025 1>la piste est à vous, mon cher associé !");
                return s;
            };

            // [107] BB\script\output\_sce04_c104_0060_eng#8
            entryTranslators[@"BB\script\output\_sce04_c104_0060_eng#8"] = (s) => {
                s = s.Replace("You must tilt your head to one side and listen carefully to\r\nthe faint cries of the scene.", "Vous devez pencher la tête sur le côté et écouter attentivement les\r\nsanglots ténus de la scène.");
                s = s.Replace("Hear the evidence calling out for you to find it.<E003 14>\r\n<E025 3><E330>‘Here I am,’ <E003 10><E025 1><E341>it cries!", "Entendez les preuves qui vous supplient de les découvrir.<E003 14>\r\n<E025 3><E330>« Je suis ici ! » <E003 10><E025 1><E341>clament-elles !");
                s = s.Replace("Well, <E003 8>your methods were never conventional.<E003 14>\r\n<E607><E025 1>But you know I've always been willing to give them a try!", "Eh bien, <E003 8>vos méthodes n'ont jamais été conventionnelles.<E003 14>\r\n<E607><E025 1>Mais vous savez que j'ai toujours été prêt à jouer le jeu !");
                s = s.Replace("Dear God, Mikotoba, <E003 8><E025 1>open your eyes!<E003 12>\r\nIt was a metaphorical listening that I was suggesting!", "Grand Dieu, Mikotoba, <E003 8><E025 1>ouvrez les yeux !<E003 12>\r\nC'était une écoute purement métaphorique que je suggérais !");
                return s;
            };

            // [108] BB\script\output\_sce04_c104_0060_eng#11
            entryTranslators[@"BB\script\output\_sce04_c104_0060_eng#11"] = (s) => {
                s = s.Replace("The remnants of the dark deed that took place in here are\r\nbeing masked by something quite incongruous!", "Les vestiges du sombre forfait perpétré en ces lieux sont\r\nmasqués par un élément parfaitement incongru !");
                return s;
            };

            // [109] BB\script\output\_sce04_c104_0060_eng#12
            entryTranslators[@"BB\script\output\_sce04_c104_0060_eng#12"] = (s) => {
                s = s.Replace("It's <E006>the Rules of Passage<E005> in this frame here.<E049><E003 10>\r\nThey're obviously out of place.", "C'est <E006>le Règlement de bord<E005> dans ce cadre ici.<E049><E003 10>\r\nIl est manifestement déplacé.");
                s = s.Replace("The way they're hanging crooked on the wall...<E003 14><E330><E025 2>as if they\r\nwere put there in a hurry.", "La façon dont il est accroché de travers au mur...<E003 14><E330><E025 2>comme s'il\r\navait été suspendu à la hâte.");
                s = s.Replace("Yes, <E049><E003 10><E025 2>as I'm sure you've already concluded...", "Oui, <E049><E003 10><E025 2>et comme vous l'avez sans nul doute déduit...");
                s = s.Replace("...that frame was originally over here.<E049><E003 10>\r\nThe shape and size are a perfect match.", "...ce cadre se trouvait à l'origine ici.<E049><E003 10>\r\nLa forme et les dimensions correspondent parfaitement.");
                s = s.Replace("Da!<E049><E003 12> You are right!<E049><E003 12>\r\n<E025 2>When did frame move...?", "Da !<E049><E003 12> Vous avez raison !<E049><E003 12>\r\n<E025 2>Quand cadre a bougé... ?");
                s = s.Replace("Hardly the most observant of crewmen, <E049><E003 8>are you,<E049><E003 6>\r\nMr Strogenov?", "Vous n'êtes guère le plus observateur des hommes d'équipage, <E049><E003 8>n'est-ce pas,<E049><E003 6>\r\nmonsieur Strogenov ?");
                s = s.Replace("I would think your captain is quite justified in having his\r\nreservations about your reliability.", "Je conçois aisément que votre capitaine ait des doutes quant\r\nà votre fiabilité.");
                s = s.Replace("Grrrrrr!", "Grrrrrr !");
                s = s.Replace("(Oh dear.<E003 8> That really seemed to touch a nerve.)", "(Aïe.<E003 8> Cela a vraiment touché une corde sensible.)");
                s = s.Replace("So, <E003 8>Mikotoba...<E003 16><E346><E025 1>why don't you lift that frame off the wall?", "Alors, <E003 8>Mikotoba...<E003 16><E346><E025 1>pourquoi ne décrocheriez-vous pas ce cadre du mur ?");
                return s;
            };

            // [110] BB\script\output\_sce04_c104_0070_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0070_eng#2"] = (s) => {
                s = s.Replace("That...<E003 12><E341>that looks...", "On...<E003 12><E341>on dirait...");
                s = s.Replace("...like <E006>a bullet hole<E005>!", "...comme <E006>un impact de balle<E005> !");
                s = s.Replace("What?!<E003 18> <E341>Who has been shooting walls?", "Quoi ?!<E003 18> <E341>Qui avoir tiré sur les murs ?");
                s = s.Replace("I see <E049><E003 12><E025 2>the projectile has been removed.", "Je constate <E049><E003 12><E025 2>que le projectile a été extrait.");
                s = s.Replace("Clearly the careful occupant of this room has already\r\ndisposed of it.", "À l'évidence, le méticuleux occupant de cette cabine s'en est déjà\r\ndébarrassé.");
                s = s.Replace("Now then, <E049><E003 8>Mr Strogenov...", "À présent, <E049><E003 8>monsieur Strogenov...");
                s = s.Replace("Agh!<E003 25><E024>", "Argh !<E003 25><E024>");
                s = s.Replace("...I have the distinct impression that you're attempting to\r\nshield said occupant.", "...j'ai la nette impression que vous tentez de protéger\r\nledit occupant.");
                s = s.Replace("I don't know what you are talking about!<E049><E003 15>\r\n<E332>Why would I try to protect Eastern stranger?", "Moi pas savoir de quoi vous parlez !<E049><E003 15>\r\n<E332>Pourquoi moi chercher à protéger étranger venu d'Orient ?");
                s = s.Replace("Ah, <E049><E003 6><E146 2 67><E492 2 130 15 2><E003 10><E025 3><E043>so we're talking about the same man, I see.<E049><E003 10>\r\nGood.", "Ah, <E049><E003 6><E146 2 67><E492 2 130 15 2><E003 10><E025 3><E043>nous parlons donc du même individu, à ce que je vois.<E049><E003 10>\r\nParfait.");
                s = s.Replace("Ugh!<E003 20><E024>", "Ough !<E003 20><E024>");
                s = s.Replace("I'm sure we can get to the bottom of this in no time...<E003 12>\r\n<E025 3>aren't you?", "Je suis persuadé que nous allons tirer tout cela au clair sous peu...<E003 12>\r\n<E025 3>n'est-il point vrai ?");
                s = s.Replace("Because there's some very noteworthy evidence<E049><E003 12><E333><E025 1> that\r\nexplains the reason why you're lying for the man!", "Car il subsiste un indice fort éloquent<E049><E003 12><E333><E025 1> qui\r\nexplique pourquoi vous couvrez cet individu !");
                s = s.Replace("Yes, <E049><E003 8>you've been told to keep up this pretence, <E049><E003 10><E025 2><E341>as clearly\r\nshown by...", "Oui, <E049><E003 8>on vous a ordonné de soutenir ce simulacre, <E049><E003 10><E025 2><E341>comme le montre clairement...");
                return s;
            };

            // [111] BB\script\output\_sce04_c104_0070_eng#7
            entryTranslators[@"BB\script\output\_sce04_c104_0070_eng#7"] = (s) => {
                s = s.Replace("I really don't know how to approach this one, Sholmes.", "Je ne sais vraiment pas par quel bout aborder la chose, Sholmes.");
                s = s.Replace("Ah, <E003 8>my dear Mikotoba, <E003 6>simply keep first principles in\r\nmind.", "Ah, <E003 8>mon cher Mikotoba, <E003 6>gardez simplement à l'esprit les principes fondamentaux.");
                s = s.Replace("Study your subject from every angle...", "Examinez votre sujet sous tous les angles...");
                s = s.Replace("...and I'm quite sure that you'll see it.<E003 14>\r\nIn fact, <E003 10><E025 1><E333>I'd put a wager on it!", "...et je suis persuadé que la réponse vous sautera aux yeux.<E003 14>\r\nEn réalité, <E003 10><E025 1><E333>j'en mettrais ma main au feu !");
                s = s.Replace("So I'm to glare at the fellow from all sides?<E003 12>\r\n<E025 3>Well, <E003 6><E025 2>I can certainly do that...", "Je dois donc dévisager cet homme sous toutes les coutures ?<E003 12>\r\n<E025 3>Eh bien, <E003 6><E025 2>cela, je puis tout à fait le faire...");
                return s;
            };

            // [112] BB\script\output\_sce04_c104_0070_eng#8
            entryTranslators[@"BB\script\output\_sce04_c104_0070_eng#8"] = (s) => {
                s = s.Replace("So a Russian crewman is aiding a Japanese man to evade\r\ncapture by an English detective...", "Ainsi, un marin russe aide un Japonais à échapper aux griffes\r\nd'un détective anglais...");
                s = s.Replace("Nationality needn't come into it.<E003 10>\r\nIn this respect at least, <E003 10><E333>all humans are the same.", "La nationalité n'a rien à voir là-dedans.<E003 10>\r\nSur ce point du moins, <E003 10><E333>tous les hommes sont semblables.");
                s = s.Replace("Ask yourself what can spur a man to do the bidding of\r\nanother about whom he knows precious little.", "Demandez-vous ce qui peut pousser un individu à exécuter les ordres\r\nd'un inconnu dont il ignore presque tout.");
                s = s.Replace("There is only one thing in the whole world <E003 10><E025 1><E332>with such\r\nrepugnant, bottomless power!", "Il n'y a qu'une seule chose en ce bas monde <E003 10><E025 1><E332>dotée d'un\r\npouvoir aussi répugnant et sans fond !");
                s = s.Replace("Let's not get carried away now, <E003 4>Sholmes.", "Ne nous emportons pas, <E003 4>Sholmes.");
                return s;
            };

            // [113] BB\script\output\_sce04_c104_0070_eng#11
            entryTranslators[@"BB\script\output\_sce04_c104_0070_eng#11"] = (s) => {
                s = s.Replace("Yes, you've been told to keep up this pretence, as clearly\r\nshown by...", "Oui, on vous a dit de soutenir ce mensonge, comme le montre\r\nclairement...");
                return s;
            };

            // [114] BB\script\output\_sce04_c104_0070_eng#12
            entryTranslators[@"BB\script\output\_sce04_c104_0070_eng#12"] = (s) => {
                s = s.Replace("It's almost too obvious for words.", "C'est presque trop évident pour être exprimé.");
                s = s.Replace("Quite.<E049><E003 10> <E025 3>The universal language of the world:<E049><E003 6> <E118 2 1.2><E164 2 71 1 2 6 0 0 1><E492 2 110 15 2><E139 2><E118 2 1><E025 2><E006>money<E005>.", "Tout à fait.<E049><E003 10> <E025 3>Le langage universel de ce bas monde :<E049><E003 6> <E118 2 1.2><E164 2 71 1 2 6 0 0 1><E492 2 110 15 2><E139 2><E118 2 1><E025 2><E006>l'argent<E005>.");
                s = s.Replace("And I'd wager that the Eastern fellow in question...", "Et je parierais bien que l'homme d'Orient en question...");
                s = s.Replace("...is Seishiro Jigoku.<E049><E003 10> <E025 3>Yes?", "...n'est autre que Seishiro Jigoku.<E049><E003 10> <E025 3>N'est-ce pas ?");
                s = s.Replace("Gaaagh!<E045><E003 30><E169 51 3><E024>", "Gaaargh !<E045><E003 30><E169 51 3><E024>");
                s = s.Replace("So, <E049><E003 8><E025 2>I presume you realise what this means?", "Alors, <E049><E003 8><E025 2>je présume que vous comprenez ce que cela implique ?");
                s = s.Replace("There are clear signs <E049><E003 6>that a crime has been committed in\r\nthis cabin.", "Il y a des signes indubitables <E049><E003 6>qu'un crime a été commis dans\r\ncette cabine.");
                s = s.Replace("And the way you're going, <E049><E003 6>sir, <E049><E003 12><E333>you'll find yourself accused\r\nof being an accomplice.", "Et au rythme où vous allez, <E049><E003 6>monsieur, <E049><E003 12><E333>vous allez vous retrouver\r\naccusé de complicité.");
                s = s.Replace("B-<E049><E003 8>But...", "M-<E049><E003 8>Mais...");
                return s;
            };

            // [115] BB\script\output\_sce04_c104_0080_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0080_eng#2"] = (s) => {
                s = s.Replace("I believe you know, <E049><E003 8>Mr Strogenov...", "Je crois que vous savez pertinemment, <E049><E003 8>monsieur Strogenov...");
                s = s.Replace("You know where Mr Jigoku is hiding <E003 12><E607><E025 1>at this precise\r\nmoment in time!", "Vous savez exactement où M. Jigoku se cache <E003 12><E607><E025 1>en cet instant\r\nprécis !");
                s = s.Replace("As always, <E049><E003 6>Mikotoba, <E049><E003 10><E025 2>in matters of deduction,<E049><E003 12><E330><E025 3> <E006>the furtive\r\nglance<E005> is your unfaltering ally.", "Comme toujours, <E049><E003 6>Mikotoba, <E049><E003 10><E025 2>en matière de déduction,<E049><E003 12><E330><E025 3> <E006>le regard\r\ndérobé<E005> est votre plus fidèle allié.");
                s = s.Replace("Yes, <E049><E003 8><E025 2>I think you're onto something there, Sholmes.<E049><E003 14>\r\n<E043><E025 1>You've found <E006>the chink<E005> in this burly fellow's armour!", "Oui, <E049><E003 8><E025 2>je crois que vous touchez au but, Sholmes.<E049><E003 14>\r\n<E043><E025 1>Vous avez trouvé <E006>la faille<E005> dans l'armure de ce rude gaillard !");
                s = s.Replace("to know where our\r\n<E006>prey<E005> is hiding...", "pour savoir où notre\r\n<E006>proie<E005> s'est tapie...");
                return s;
            };

            // [116] BB\script\output\_sce04_c104_0080_eng#7
            entryTranslators[@"BB\script\output\_sce04_c104_0080_eng#7"] = (s) => {
                s = s.Replace("The slightest flicker of the pupils...<E003 10>\r\n<E025 3>A minutely delayed blink...", "Le moindre frémissement de pupille...<E003 10>\r\n<E025 3>Le plus infime battement de paupière...");
                s = s.Replace("Nothing escapes my attention.<E003 10>\r\n<E025 3>Even that which is barely perceptible.", "Rien n'échappe à mon regard acéré.<E003 10>\r\n<E025 3>Pas même l'imperceptible.");
                s = s.Replace("You could hardly call this barely perceptible,<E003 4> Sholmes.<E003 12>\r\n<E025 3><E239>The man's turned his entire head.", "On peut difficilement qualifier cela d'imperceptible, <E003 4>Sholmes.<E003 12>\r\n<E025 3><E239>Cet homme a tourné la tête entière.");
                s = s.Replace("It's not exactly what you'd describe as a furtive glance,<E003 6> is\r\nit?<E003 12> It's almost too obvious...", "Ce n'est pas tout à fait ce qu'on appellerait un regard furtif,<E003 6> n'est-ce\r\npas ?<E003 12> C'est presque trop voyant...");
                s = s.Replace("We shall let your tapping toes decide, <E003 8><E025 1><E346>my dear fellow!", "Laissons vos claquettes en décider, <E003 8><E025 1><E346>mon cher ami !");
                return s;
            };

            // [117] BB\script\output\_sce04_c104_0080_eng#8
            entryTranslators[@"BB\script\output\_sce04_c104_0080_eng#8"] = (s) => {
                s = s.Replace("So...<E003 12><E025 3>you really think he's hiding in here as we speak?", "Alors...<E003 12><E025 3>vous pensez sincèrement qu'il se cache ici à l'instant même ?");
                s = s.Replace("Curled up in a ball at this very moment!", "Pelotonné en boule à la seconde où nous parlons !");
                s = s.Replace("But as I said earlier, <E003 8>we've no time for games today.", "Mais comme je l'ai dit plus tôt, <E003 8>nous n'avons point de temps à perdre aujourd'hui.");
                s = s.Replace("No, <E003 8>I quite understand.<E003 12>\r\n<E341><E025 1>I'll make this as quick as I can.", "Non, <E003 8>je comprends parfaitement.<E003 12>\r\n<E341><E025 1>Je vais faire aussi vite que possible.");
                s = s.Replace("Seaman Strogenov will be suffering neck fatigue before\r\nlong, <E003 6>I should think.", "Le matelot Strogenov va finir par avoir un torticolis avant\r\nlongtemps, <E003 6>j'en ai peur.");
                return s;
            };

            // [118] BB\script\output\_sce04_c104_0080_eng#11
            entryTranslators[@"BB\script\output\_sce04_c104_0080_eng#11"] = (s) => {
                s = s.Replace("We need only follow the man's gaze to know where\r\nour <E006>prey<E005> is hiding...", "Il suffit de suivre le regard de cet homme pour savoir où\r\nnotre <E006>proie<E005> se terre...");
                return s;
            };

            // [119] BB\script\output\_sce04_c104_0080_eng#12
            entryTranslators[@"BB\script\output\_sce04_c104_0080_eng#12"] = (s) => {
                s = s.Replace("You turned immediately <E049><E003 8><E330>to look at this large <E006>trunk<E005>, <E049><E003 6><E025 3>didn't\r\nyou?", "Vous vous êtes aussitôt tourné <E049><E003 8><E330>vers cette grande <E006>malle<E005>, <E049><E003 6><E025 3>n'est-ce\r\npas ?");
                s = s.Replace("Aaah!<E003 20><E024>", "Aaaah !<E003 20><E024>");
                s = s.Replace("The truth is, <E049><E003 8>Seishiro Jigoku was unable to escape from\r\nthe ship in time...", "La vérité, <E049><E003 8>c'est que Seishiro Jigoku n'a pas pu fuir le navire\r\nà temps...");
                s = s.Replace("...and is, <E049><E003 8>at this very moment, <E049><E003 8><E149 46 0 0><E172 46 -35 210 10 3 2><E492 46 210 10 3><E144 46><E607><E025 1>doing his best to stifle his\r\nbreath inside this trunk!", "...et s'efforce, <E049><E003 8>en cet instant précis, <E049><E003 8><E149 46 0 0><E172 46 -35 210 10 3 2><E492 46 210 10 3><E144 46><E607><E025 1>de retenir son\r\nsouffle dans cette malle !");
                s = s.Replace("If he still has a breath to take.<E049><E003 12> <E025 2><E044>I fear he may be running\r\ndangerously low on air.", "S'il lui reste un souffle d'air.<E049><E003 12> <E025 2><E044>J'ai bien peur qu'il commence\r\nà manquer cruellement d'oxygène.");
                s = s.Replace("I imagine <E145 2 64>he didn't count on us making a nuisance of\r\nourselves for quite so long.", "J'imagine <E145 2 64>qu'il ne s'attendait pas à ce que nous nous éternisions\r\nsi longtemps ici.");
                s = s.Replace("I think it would be in everyone's best interests <E049><E003 8>for us to\r\nopen the trunk as quickly as possible.", "Je pense qu'il serait dans l'intérêt de tous <E049><E003 8>d'ouvrir cette\r\nmalle sans perdre un instant.");
                return s;
            };

            // [120] BB\script\output\_sce04_c104_0090_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0090_eng#2"] = (s) => {
                s = s.Replace("B-<E003 8>But how can we?<E003 12> <E330>Are you forgetting about <E006>the\r\ncombination lock<E005>?", "M-<E003 8>Mais comment ?<E003 12> <E330>Oubliez-vous <E006>le cadenas\r\nà combinaison<E005> ?");
                s = s.Replace("We don't know the seven-digit code!", "Nous ignorons le code à sept chiffres !");
                s = s.Replace("The combination lock can't be opened from inside the\r\ntrunk.", "Le cadenas à combinaison ne peut pas s'ouvrir de l'intérieur de la\r\nmalle.");
                s = s.Replace("Therefore <E049><E003 8><E025 2>there must have been an arrangement <E049><E003 10><E330><E025 3>for\r\nsomebody to open it after our departure.", "Par conséquent, <E049><E003 8><E025 2>il doit y avoir eu un arrangement <E049><E003 10><E330><E025 3>pour\r\nque quelqu'un vienne l'ouvrir après notre départ.");
                s = s.Replace("In short, <E049><E003 8>before Jigoku hid himself inside that trunk...", "En résumé, <E049><E003 8>avant de se cacher dans cette malle...");
                s = s.Replace("...he must have told somebody the seven-digit <E006>number<E005>\r\nfor the lock.", "...il a forcément communiqué le <E006>numéro<E005> à sept chiffres\r\nde la serrure.");
                s = s.Replace("As I'm sure you can confirm...<E003 10><E341><E025 1>Mr Strogenov!", "Comme vous pouvez certainement nous le confirmer...<E003 10><E341><E025 1>monsieur Strogenov !");
                s = s.Replace("*Gulp!*<E003 20><E169 51 3><E024>", "*Gloups !*<E003 20><E169 51 3><E024>");
                s = s.Replace("No!<E049><E003 15> <E025 1><E603>I know nothing about combination code!", "Niet !<E049><E003 15> <E025 1><E603>Moi savoir rien sur code secret !");
                s = s.Replace("Don't move a muscle, <E049><E003 8>my good seaman!", "Ne bougez plus d'un cil, <E049><E003 8>mon cher matelot !");
                s = s.Replace("Now, <E049><E003 8>Mikotoba...<E049><E003 14><E025 2><E330>would you do the honours and open <E006>the\r\ntrunk<E005>?", "À présent, <E049><E003 8>Mikotoba...<E049><E003 14><E025 2><E330>auriez-vous l'obligeance d'ouvrir <E006>cette\r\nmalle<E005> ?");
                s = s.Replace("H-<E049><E003 8><E604><E145 46 88><E117 46 5><E490 46 22.564453 5.018341 -127.957687 5 3><E149 46 2 0>How on earth do you expect me...?", "C-<E049><E003 8><E604><E145 46 88><E117 46 5><E490 46 22.564453 5.018341 -127.957687 5 3><E149 46 2 0>Comment diable voulez-vous que je... ?");
                s = s.Replace("It's a seven-digit number, <E049><E003 6>remember.<E049><E003 14>\r\n<E607><E025 1>Quickly now!<E049><E003 12> We have little time!", "C'est un numéro à sept chiffres, <E049><E003 6>rappelez-vous.<E049><E003 14>\r\n<E607><E025 1>Vite !<E049><E003 12> Le temps nous est compté !");
                return s;
            };

            // [121] BB\script\output\_sce04_c104_0090_eng#4
            entryTranslators[@"BB\script\output\_sce04_c104_0090_eng#4"] = (s) => {
                s = s.Replace("No...<E003 12>it's refusing to open.", "Non...<E003 12>elle refuse de s'ouvrir.");
                s = s.Replace("Tell me, <E049><E003 8><E025 2>what number did you use?", "Dites-moi, <E049><E003 8><E025 2>quel numéro avez-vous composé ?");
                s = s.Replace("Well...<E003 12><E025 2>to begin with <E049><E003 8><E043>I thought I'd try my birthday.", "Eh bien...<E003 12><E025 2>pour commencer, <E049><E003 8><E043>j'ai pensé à tester ma date d'anniversaire.");
                s = s.Replace("Your birthday?<E049><E003 10> Interesting, <E049><E003 6>since as of today with that\r\nabsurd guesswork, <E049><E003 8>you're dead to me.", "Votre anniversaire ?<E049><E003 10> Fascinant... <E049><E003 6>car avec une supposition\r\naussi ridicule, <E049><E003 8>vous êtes mort à mes yeux.");
                s = s.Replace("...As measured as ever in response, <E049><E003 6>Sholmes.", "...Toujours aussi mesuré dans vos propos, <E049><E003 6>Sholmes.");
                return s;
            };

            // [122] BB\script\output\_sce04_c104_0090_eng#5
            entryTranslators[@"BB\script\output\_sce04_c104_0090_eng#5"] = (s) => {
                s = s.Replace("If you would only look in the right place, <E003 6>Mikotoba,<E003 10> <E025 3>the\r\nanswer would be staring you in the face.", "Si seulement vous regardiez au bon endroit, <E003 6>Mikotoba,<E003 10> <E025 3>la\r\nréponse vous sauterait aux yeux.");
                s = s.Replace("The right place...?", "Au bon endroit... ?");
                s = s.Replace("But if you're having a spot of bother, <E003 8><E043>I always find\r\nstanding on my head aids the cognitive processes.", "Mais si vous éprouvez la moindre difficulté, <E003 8><E043>je trouve toujours que\r\nfaire le poirier stimule grandement les facultés cognitives.");
                return s;
            };

            // [123] BB\script\output\_sce04_c104_0090_eng#8
            entryTranslators[@"BB\script\output\_sce04_c104_0090_eng#8"] = (s) => {
                s = s.Replace("*Click!*", "*Clic !*");
                s = s.Replace("(That did it!<E003 14> <E334><E025 1>It's open!)", "(Ça y est !<E003 14> <E334><E025 1>C'est ouvert !)");
                s = s.Replace("You had to meddle, <E003 6>didn't you...", "Il a fallu que tu te mêles de ce qui ne te regarde pas...");
                s = s.Replace("Well, Yujin, <E049><E003 12><E025 3>you've found me now.", "Eh bien, Yujin, <E049><E003 12><E025 3>tu m'as débusqué.");
                s = s.Replace("Seishiro...", "Seishiro...");
                return s;
            };

            // [124] BB\script\output\_sce04_c104_0100_eng#2
            entryTranslators[@"BB\script\output\_sce04_c104_0100_eng#2"] = (s) => {
                s = s.Replace("...I was really hoping beyond hope not to find you here, <E003 6>\r\n<E025 3>you know.", "...J'espérais de tout mon cœur me tromper et ne pas te trouver ici, <E003 6>\r\n<E025 3>tu sais.");
                s = s.Replace("But you're not entirely unsurprised, <E003 4>I take it?", "Mais tu n'es pas tout à fait surpris pour autant, <E003 4>j'imagine ?");
                s = s.Replace("No, <E003 8>quite.<E003 15><E025 3><E333> I just wish it were some other way.", "Non, <E003 8>hélas.<E003 15><E025 3><E333> J'aurais tant souhaité qu'il en fût autrement.");
                s = s.Replace("...Well?<E049><E003 8> <E172 47 7 193 20 3 9><E492 47 193 20 3><E003 4><E025 2><E330>Are you ever going to introduce me?", "...Alors ?<E049><E003 8> <E172 47 7 193 20 3 9><E492 47 193 20 3><E003 4><E025 2><E330>N'allez-vous donc point me présenter ?");
                s = s.Replace("Ah, <E049><E003 8>your reputation precedes you, <E003 4>Mr Sholmes.<E049><E171 47 1 1 1 3><E003 12><E145 2 64><E171 2 2 0 2 2>\r\nI've read stories of many of your exploits.", "Ah, <E049><E003 8>votre réputation vous précède, <E003 4>M. Sholmes.<E049><E171 47 1 1 1 3><E003 12><E145 2 64><E171 2 2 0 2 2>\r\nJ'ai lu les récits de plusieurs de vos exploits.");
                s = s.Replace("Excuse my manners, <E003 4>Sholmes.<E173 2 2 20 3><E003 14> <E025 2>This is Mr Jigoku, <E003 10>my old\r\nfriend and travelling companion.", "Pardonnez mes manières, <E003 4>Sholmes.<E173 2 2 20 3><E003 14> <E025 2>Voici M. Jigoku, <E003 10>mon vieil\r\nami et compagnon de voyage.");
                s = s.Replace("The devil is in the details, <E003 4><E025 3>Mikotoba.<E049><E003 10> I believe you meant\r\nto say:<E049><E003 12> <E025 3>your old friend and travelling companion...", "Le diable se niche dans les détails, <E003 4><E025 3>Mikotoba.<E049><E003 10> Je crois que vous vouliez\r\ndire :<E049><E003 12> <E025 3>votre vieil ami et compagnon de voyage...");
                s = s.Replace("...who made the cowardly decision to flee the country\r\nwithout a word to anyone when things turned sour.", "...qui a lâchement décidé de fuir le pays sans un mot\r\nà quiconque dès que les choses se sont gâtées.");
                s = s.Replace("...I see my reputation precedes me as well.<E049><E003 12>\r\nWhat an honour.", "...Je vois que ma réputation me précède également.<E049><E003 12>\r\nQuel insigne honneur.");
                s = s.Replace("Well, <E003 8>Seishiro?<E003 10><E145 47 64><E171 47 1 0 2 2><E003 4>\r\nAre you going to explain all this?", "Alors, <E003 8>Seishiro ?<E003 10><E145 47 64><E171 47 1 0 2 2><E003 4>\r\nVas-tu nous expliquer tout cela ?");
                s = s.Replace("You know it all by now, <E049><E003 6>I imagine.<E049><E003 12>\r\n<E025 2>What you didn't know, of course, <E049><E003 10><E025 3>is that three days ago...", "Vous savez déjà tout désormais, <E049><E003 6>j'imagine.<E049><E003 12>\r\n<E025 2>Ce que vous ignoriez, bien sûr, <E049><E003 10><E025 3>c'est qu'il y a trois jours...");
                s = s.Replace("...on the night before our arrival in Britain, <E049><E003 6><E118 47 1.3><E145 47 66><E003 10><E025 3>an attempt was\r\nmade on my life here on this very ship.", "...la veille de notre arrivée en Grande-Bretagne, <E049><E003 6><E118 47 1.3><E145 47 66><E003 10><E025 3>on a attenté\r\nà ma vie ici même sur ce navire.");
                s = s.Replace("By the Reaper of the Bailey?<E003 14>\r\n<E025 3>Yes, <E003 8><E025 2>I've since heard.", "Par le Faucheur de l'Old Bailey ?<E003 14>\r\n<E025 3>Oui, <E003 8><E025 2>on me l'a rapporté depuis.");
                s = s.Replace("Because you were once prosecuted by the Reaper,<E003 6>\r\nweren't you?<E003 10> <E025 2>Ten years ago now, <E003 6>mind you.", "Car vous avez jadis été poursuivi par le Faucheur,<E003 6>\r\nn'est-ce pas ?<E003 10> <E025 2>Il y a dix ans de cela, <E003 6>certes.");
                s = s.Replace("And I had no idea at the time <E049><E003 8><E025 3>what a dangerous individual\r\nhe was.", "Et j'ignorais totalement à l'époque <E049><E003 8><E025 3>à quel point cet individu\r\nétait dangereux.");
                s = s.Replace("Anyway, <E049><E003 8>when we arrived in London to find the\r\nsymposium was postponed until goodness knows when...", "Quoi qu'il en soit, <E049><E003 8>en arrivant à Londres pour constater que le\r\ncolloque était reporté aux calendes grecques...");
                s = s.Replace("...it became all too apparent to me <E049><E003 6><E025 3>that I might very well\r\nbe targeted again.", "...il m'est apparu comme une évidence <E049><E003 6><E025 3>que je pouvais fort bien\r\nêtre pris pour cible à nouveau.");
                s = s.Replace("So you decided to flee the capital, <E003 8>without saying a word\r\nto me about it?", "Alors tu as décidé de fuir la capitale, <E003 8>sans m'en toucher un seul\r\nmot ?");
                s = s.Replace("I'm afraid so, <E049><E003 8><E025 3>yes.<E049><E003 12>\r\n<E025 2>Of course, <E049><E003 6>I realise now...", "J'en ai bien peur, <E049><E003 8><E025 3>oui.<E049><E003 12>\r\n<E025 2>Naturellement, <E049><E003 6>je réalise maintenant...");
                s = s.Replace("...that I really ought to have confided in you.", "...que j'aurais vraiment dû me confier à toi.");
                s = s.Replace("It's somewhat surprising, <E003 8>I must say...<E172 47 14 193 20 3 9><E492 47 193 20 3>", "C'est assez curieux, <E003 8>je dois dire...<E172 47 14 193 20 3 9><E492 47 193 20 3>");
                s = s.Replace("What is?", "Qu'est-ce qui l'est ?");
                s = s.Replace("Well, <E049><E003 8>first-class cabins aboard luxury steamships are in\r\nvery short supply.", "Eh bien, <E049><E003 8>les cabines de première classe à bord des navires de luxe\r\nsont extrêmement rares.");
                s = s.Replace("It's more than a little hard to believe <E049><E003 8><E025 3>that this one just\r\nhappened to be available.", "Il est difficilement croyable <E049><E003 8><E025 3>que celle-ci se soit trouvée\r\nlibre comme par enchantement.");
                s = s.Replace("So says the protagonist of some colourful short stories.<E049><E003 10>\r\n<E025 3>Well, <E049><E003 6>I don't care for your opinion.", "Ainsi parle le héros de quelques fables de gare.<E049><E003 10>\r\n<E025 3>Eh bien, <E049><E003 6>votre opinion m'indiffère.");
                s = s.Replace("The cabin did just happen to be available.<E049><E003 12>\r\n<E025 3>So I purchased a ticket <E049><E003 8><E025 3>and here I am.", "Cette cabine était bel et bien disponible.<E049><E003 12>\r\n<E025 3>J'ai donc pris un billet <E049><E003 8><E025 3>et me voici.");
                s = s.Replace("I've just seen for myself <E003 6><E173 2 2 30 3><E171 47 1 0 2 2>the obvious <E006>remnants<E005> of that\r\nincident in this cabin.", "J'ai pu constater de mes yeux <E003 6><E173 2 2 30 3><E171 47 1 0 2 2>les <E006>traces<E005> irréfutables de cet\r\nincident dans cette cabine.");
                s = s.Replace("So you'd already purchased your return ticket before we\r\neven docked in Dover, <E003 6><E025 3>had you?", "Tu avais donc déjà acheté ton billet de retour avant même\r\nque nous accostions à Douvres, <E003 6><E025 3>n'est-ce pas ?");
                s = s.Replace("To prevent anyone else taking this cabin and seeing the\r\nevidence.<E003 12> <E025 3>Is that it?", "Pour empêcher qui que ce soit d'autre d'occuper la cabine et de découvrir ces preuves.<E003 12> <E025 3>C'est bien cela ?");
                s = s.Replace("Yujin...<E049><E003 16><E330><E025 3>I have nothing to say to you.", "Yujin...<E049><E003 16><E330><E025 3>je n'ai rien à te dire.");
                s = s.Replace("Well, <E049><E003 8><E171 47 1 1 1 3>in a mere five minutes, <E049><E003 6>this ship will set off on its\r\nonward voyage and not make port again until Italy.", "Eh bien, <E049><E003 8><E171 47 1 1 1 3>d'ici cinq minutes à peine, <E049><E003 6>ce navire reprendra sa\r\ntraversée et ne fera escale qu'en Italie.");
                s = s.Replace("I'm afraid we must insist that you disembark with us at\r\nonce.", "J'ai bien peur que nous ne devions insister pour que vous débarquiez avec nous sur-le-champ.");
                s = s.Replace("...You have no jurisdiction over my movements.", "...Vous n'avez aucune autorité sur mes déplacements.");
                s = s.Replace("We have this, <E003 6>Seishiro.<E003 14> <E060 0 157 0 0><E333><E092 0>Take it.", "Nous avons ceci, <E003 6>Seishiro.<E003 14> <E060 0 157 0 0><E333><E092 0>Prends-le.");
                s = s.Replace("What is it?", "Qu'est-ce que c'est ?");
                s = s.Replace("It's a subpoena from the Old Bailey.", "C'est une assignation à comparaître de l'Old Bailey.");
                s = s.Replace("You're a man of the law.", "Tu es un homme de loi.");
                s = s.Replace("You know what the ramifications of ignoring a document\r\nlike this from the British courts would be.", "Tu sais quelles conséquences aurait le refus d'obtempérer à un tel\r\ndocument émanant des tribunaux britanniques.");
                s = s.Replace("...You came prepared then, <E049><E003 6><E025 3>Yujin.", "...Tu avais donc tout prévu, <E049><E003 6><E025 3>Yujin.");
                s = s.Replace("Come on, <E003 8>let's go.", "Allons, <E003 8>partons.");
                s = s.Replace("One moment...", "Un instant...");
                s = s.Replace("What is it, <E003 6>Sholmes?", "Qu'y a-t-il, <E003 6>Sholmes ?");
                s = s.Replace("Inside Mr Jigoku's trunk...", "Dans la malle de M. Jigoku...");
                s = s.Replace("...I found this rather fascinating trinket.", "...j'ai déniché cette breloque des plus fascinantes.");
                s = s.Replace("What is that?<E003 12>\r\n<E025 2>Seishiro...?", "Qu'est-ce que c'est ?<E003 12>\r\n<E025 2>Seishiro... ?");
                s = s.Replace("I can't help you, I'm afraid.<E049><E003 10>\r\n<E025 3>Some small component from something.", "Je ne saurais vous éclairer, j'en ai peur.<E049><E003 10>\r\n<E025 3>Un petit composant d'un mécanisme quelconque.");
                s = s.Replace("But what, <E049><E003 6>I have no idea.", "Mais de quoi, <E049><E003 6>je n'en ai pas la moindre idée.");
                s = s.Replace("(By the look on his face...<E003 12>I think he genuinely doesn't\r\nknow.)", "(À voir son expression...<E003 12>je crois qu'il l'ignore sincèrement.)");
                s = s.Replace("Well, <E049><E003 8><E164 2 79 1 2 6 0 0 1><E139 2>let us pocket it as a small souvenir of our brief\r\nsojourn in France.", "Eh bien, <E049><E003 8><E164 2 79 1 2 6 0 0 1><E139 2>glissons-le dans notre poche en souvenir de notre bref\r\nséjour en France.");
                s = s.Replace("The small component has been\r\nentered into the Court Record.", "La petite pièce a été\r\najoutée au dossier de l'affaire.");
                s = s.Replace("(Well, <E003 6>young Naruhodo, <E003 10><E025 2>I think we've done as much as we\r\ncan, <E003 6><E025 3>I'm afraid.)", "(Eh bien, <E003 6>jeune Naruhodo, <E003 10><E025 2>nous avons fait tout ce qui était en notre\r\npouvoir, <E003 6><E025 3>j'en ai peur.)");
                s = s.Replace("(The rest <E003 15><E025 1><E046>will be on the shoulders of you and your\r\nassistant!)", "(Le reste <E003 15><E025 1><E046>repose désormais sur vos épaules et celles de votre\r\nassistante !)");
                return s;
            };

            // [125] BB\script\output\_sce04_c105_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c105_0000_eng#2"] = (s) => {
                s = s.Replace("3rd November, 12:10 p.m.\r\n<CNTR><E003 5>The Old Bailey Courtroom", "3 novembre, 12 h 10\r\n<CNTR><E003 5>Salle d'audience de l'Old Bailey");
                s = s.Replace("(Kazuma Asogi...)", "(Kazuma Asogi...)");
                s = s.Replace("(I know you, <E003 8>and I know you wouldn't lie.<E003 12>\r\n<E025 3>But still, <E003 10><E025 2>there's no doubt...)", "(Je te connais, <E003 8>et je sais que tu ne mentirais pas.<E003 12>\r\n<E025 3>Et pourtant, <E003 10><E025 2>il ne fait aucun doute...)");
                s = s.Replace("(...that you're holding something back.<E003 10>\r\n<E025 1><E145 1 85><E118 1 1.1><E003 15><E338><E341>You know more than you're saying!)", "(...que tu nous caches quelque chose.<E003 10>\r\n<E025 1><E145 1 85><E118 1 1.1><E003 15><E338><E341>Tu en sais bien plus que tu ne veux l'admettre !)");
                s = s.Replace("During the past thirty minutes while this court was\r\nadjourned, <E049><E003 8><E025 3>all possible efforts were expended...", "Durant les trente minutes de suspension de cette séance,\r\n<E049><E003 8><E025 3>tous les efforts possibles ont été déployés...");
                s = s.Replace("...but sadly <E049><E003 10>Mr Jigoku's whereabouts could not be\r\nascertained.", "...mais hélas, <E049><E003 10>la localisation de M. Jigoku n'a pu être\r\néquitablement établie.");
                s = s.Replace("We must accept the unfortunate conclusion<E049><E003 10><E145 112 13><E118 112 1.3><E144 112> that the\r\nReaper has already done the deed.", "Nous devons nous résoudre à la tragique conclusion<E049><E003 10><E145 112 13><E118 112 1.3><E144 112> que le\r\nFaucheur a déjà accompli son œuvre.");
                s = s.Replace("There's no sense in wasting any more of the court's time.<E049><E003 10>\r\n<E145 112 6><E118 112 0.6><E003 10><E025 2>The prosecution calls for an immediate verdict.", "Il est inutile de faire perdre plus de temps à ce tribunal.<E049><E003 10>\r\n<E145 112 6><E118 112 0.6><E003 10><E025 2>L'accusation réclame un verdict immédiat.");
                s = s.Replace("No.<E049><E003 12> The trial cannot end now.", "Non.<E049><E003 12> Ce procès ne peut s'achever ainsi.");
                s = s.Replace("You're a Japanese man, <E049><E003 6>Ryunosuke.<E049><E003 15>\r\n<E025 3>You should know when to lay down your sword.", "Tu es un Japonais, <E049><E003 6>Ryunosuke.<E049><E003 15>\r\n<E025 3>Tu devrais savoir quand rengainer ton sabre.");
                s = s.Replace("And you should know never to presume when the battle\r\nis won.", "Et tu devrais savoir qu'on ne présume jamais de l'issue d'une bataille.");
                s = s.Replace("The court has already been presented with all the\r\nevidence and heard all relevant testimony.", "Le tribunal a déjà reçu l'ensemble des pièces à conviction\r\net entendu tous les témoignages pertinents.");
                s = s.Replace("And there can only be one conclusion:<E049><E003 8> <E164 112 10 1 2 5 0 2 1><E149 112 0 0><E139 112><E025 1>that the accused is\r\nguilty!", "Et il n'y a qu'une seule conclusion possible :<E049><E003 8> <E164 112 10 1 2 5 0 2 1><E149 112 0 0><E139 112><E025 1>l'accusé est\r\ncoupable !");
                s = s.Replace("All relevant testimony?<E049><E003 12>\r\n<E025 3>Far from it.", "Tous les témoignages pertinents ?<E049><E003 12>\r\n<E025 3>Bien au contraire.");
                s = s.Replace("There's still a crucial witness <E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>from whom the court is yet\r\nto hear a single word of testimony!", "Il reste encore un témoin capital <E049><E003 10><E025 1><E164 1 8 1 2 8 0 2 1><E139 1>dont ce prétoire n'a pas encore\r\nentendu le moindre mot !");
                s = s.Replace("In that case, <E049><E003 6><E145 61 7><E118 61 0.7><E003 10><E239><E025 2>call your witness to the stand at once,<E003 6>\r\nCounsel.", "En ce cas, <E049><E003 6><E145 61 7><E118 61 0.7><E003 10><E239><E025 2>faites comparaître votre témoin sans délai à la barre,<E003 6>\r\nmaître.");
                s = s.Replace("...Yes, My Lord.<E049><E003 15> ...Tomorrow.<E049><E003 12>\r\n...If possible.", "...Oui, Votre Honneur.<E049><E003 15> ...Demain.<E049><E003 12>\r\n...Si possible.");
                s = s.Replace("The witness is already on his way <E049><E003 8><E145 9 83><E003 10>and scheduled to\r\n<E025 3>arrive tomorrow.", "Le témoin est d'ores et déjà en route <E049><E003 8><E145 9 83><E003 10>et son arrivée\r\n<E025 3>est prévue pour demain.");
                s = s.Replace("Who on earth is this crucial witness?", "Qui diable est donc ce témoin capital ?");
                s = s.Replace("...Seishiro Jigoku.", "...Seishiro Jigoku.");
                s = s.Replace("The very man allegedly murdered by the Reaper!", "L'homme précisément censé avoir été assassiné par le Faucheur !");
                s = s.Replace("J-<E049><E003 12>Judge Jigoku?!<E049><E003 16>\r\n<E025 2><E332>You've found him?!", "L-<E049><E003 12>Le juge Jigoku ?!<E049><E003 16>\r\n<E025 2><E332>Vous l'avez retrouvé ?!");
                s = s.Replace("But the investigations of every policing resource in the\r\ncapital suggest that Jigoku is already dead.", "Mais les recherches de l'ensemble des forces de police de la\r\ncapitale indiquent que Jigoku est déjà mort.");
                s = s.Replace("How in the name of God <E049><E003 10><E164 61 12 1 2 42 0 0 1><E118 61 1.3><E139 61><E025 3>did you find the man?", "Par quel prodige <E049><E003 10><E164 61 12 1 2 42 0 0 1><E118 61 1.3><E139 61><E025 3>avez-vous retrouvé cet homme ?");
                s = s.Replace("He was <E145 1 0><E118 1 1.3>located in France during the recess.<E049><E003 14>\r\n<E025 3><E333>At the Port of Dunkirk...", "Il a été <E145 1 0><E118 1 1.3>localisé en France pendant la suspension.<E049><E003 14>\r\n<E025 3><E333>Au port de Dunkerque...");
                s = s.Replace("...thanks to one of Mr Herlock Sholmes's famous\r\ndeductions.", "...grâce à l'une des célèbres déductions de M. Herlock Sholmes.");
                s = s.Replace("Herlock Sholmes...", "Herlock Sholmes...");
                s = s.Replace("Inspector Gregson almost certainly met with Mr Jigoku on\r\nthe night of his death.", "L'inspecteur Gregson a très certainement rencontré M. Jigoku la\r\nnuit de sa mort.");
                s = s.Replace("Because along with Prosecutor Asogi, <E049><E003 6>Gregson was on a\r\nmission to assassinate the man.", "Car aux côtés du procureur Asogi, <E049><E003 6>Gregson avait pour mission\r\nd'assassiner cet homme.");
                s = s.Replace("Which means that <E049><E003 8><E145 1 85><E003 8>Seishiro Jigoku is the sole witness...", "Ce qui signifie que <E049><E003 8><E145 1 85><E003 8>Seishiro Jigoku est le seul et unique témoin...");
                s = s.Replace("...who can clarify exactly what happened <E049><E003 7><E164 1 8 1 2 5 0 2 1><E139 1><E025 1><E092 1>aboard the\r\nSS Grouse on the 31st October!", "...capable d'expliquer ce qui s'est réellement passé <E049><E003 7><E164 1 8 1 2 5 0 2 1><E139 1><E025 1><E092 1>à bord du\r\nSS Grouse le 31 octobre !");
                s = s.Replace("Well...<E049><E003 10><E025 2><E145 61 0><E118 61 0.7><E144 61>it would appear that it's too soon to move to\r\nadjudication at this point.", "Eh bien...<E049><E003 10><E025 2><E145 61 0><E118 61 0.7><E144 61>il apparaît qu'il serait prématuré de rendre\r\nun jugement en l'état.");
                s = s.Replace("The prosecution concurs.<E049><E003 12> <E025 3>The court must hear Mr Jigoku's\r\ntestimony.", "L'accusation acquiesce.<E049><E003 12> <E025 3>Le tribunal se doit d'entendre le témoignage\r\nde M. Jigoku.");
                s = s.Replace("No judgement should be passed until all testimony has\r\nbeen considered.", "Aucun verdict ne saurait être prononcé avant d'avoir examiné\r\ntoutes les dépositions.");
                s = s.Replace("In that case, <E049><E003 8>I hereby call the end of today's proceedings.<E049><E003 14>\r\n<E025 3>Court will reconvene at the same hour tomorrow.", "Dans ces conditions, <E049><E003 8>je déclare levée la séance d'aujourd'hui.<E049><E003 14>\r\n<E025 3>L'audience reprendra demain à la même heure.");
                s = s.Replace("...No objections from either side?", "...Aucune objection des deux parties ?");
                s = s.Replace("No, <E049><E003 12>My Lord!", "Aucune objection, <E049><E003 12>Votre Honneur !");
                s = s.Replace("No objections, <E049><E003 12>My Lord.", "Aucune objection, <E049><E003 12>Votre Honneur.");
                s = s.Replace("(...We live to fight another day...<E003 15><E145 1 79><E118 1 0.9><E149 1 0 0><E003 15><E025 2><E239>by the skin of our teeth.)", "(...Nous avons gagné un répit...<E003 15><E145 1 79><E118 1 0.9><E149 1 0 0><E003 15><E025 2><E239>d'extrême justesse.)");
                return s;
            };

            // [126] BB\script\output\_sce04_c106_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c106_0000_eng#2"] = (s) => {
                s = s.Replace("It seems <E049><E003 10><E025 2>we've followed this single strand of reasoning to\r\nits unsatisfactory conclusion.", "Il semblerait <E049><E003 10><E025 2>que nous ayons suivi ce fil déductif jusqu'à une\r\nconclusion bien peu satisfaisante.");
                s = s.Replace("Perhaps you're a little out of practice after ten years of\r\nabsence from brilliance.", "Peut-être manquez-vous d'exercice après dix années loin de toute\r\nbrillance.");
                s = s.Replace("Well, <E049><E003 12><E043><E025 2>it's a long time to go without a paradiddle.<E003 10>\r\n<E025 2>I confess my feet are a little rusty.", "Eh bien, <E049><E003 12><E043><E025 2>cela fait longtemps sans faire de claquettes.<E003 10>\r\n<E025 2>J'avoue que mes pieds sont un peu rouillés.");
                s = s.Replace("Your feet are the least of your worries.<E049><E003 10>\r\n<E341><E025 3>The oxidation has gone to the brain, <E049><E003 6><E025 3>I fear.", "Vos pieds sont le cadet de vos soucis.<E049><E003 10>\r\n<E341><E025 3>C'est l'oxydation de votre cerveau que je crains, <E049><E003 6><E025 3>hélas.");
                s = s.Replace("Let us take to the dance floor again, <E049><E003 10><E085 0 49><E341>with renewed\r\nvigour!", "Remontons donc sur la piste de danse, <E049><E003 10><E085 0 49><E341>avec une ardeur\r\nrenouvelée !");
                s = s.Replace("Try to stop me!<E003 12> <E341>I'm itching to tap out the true answer to\r\nthis riddle!", "Essayez donc de m'en empêcher !<E003 12> <E341>Mes talons frémissent d'impatience à l'idée\r\nde marteler la solution de cette énigme !");
                return s;
            };

            // [127] BB\script\output\_sce04_c200_0000_eng#2
            entryTranslators[@"BB\script\output\_sce04_c200_0000_eng#2"] = (s) => {
                s = s.Replace("The unexpected halt of proceedings\r\n<E042><CNTR>sent a clamour around the courtroom.", "L'interruption inattendue des débats\r\n<E042><CNTR>suscita une vive clameur dans la salle d'audience.");
                s = s.Replace("But outside the Bailey, <E003 8>where Londoners knew nothing\r\n<E042><CNTR>of the secret trial within, <E003 8>it was a typical still night.", "Mais à l'extérieur de l'Old Bailey, où les Londoniens ignoraient tout\r\n<E042><CNTR>du procès secret à huis clos, régnaient le calme et la nuit.");
                s = s.Replace("Then, <E003 8>at a little past eight o'clock that evening...", "Puis, <E003 8>un peu après huit heures ce soir-là...");
                s = s.Replace("...Mr Sholmes and his partner returned to Baker Street.", "...M. Sholmes et son associé rentrèrent à Baker Street.");
                s = s.Replace("3rd November, 8:07 p.m.\r\n<CNTR><E003 5>Sholmes's Suite", "3 novembre, 20 h 07\r\n<CNTR><E003 5>Appartement de Sholmes");
                s = s.Replace("We have returned, <E049><E003 8>my dear fellows!", "Nous voici de retour, <E049><E003 8>mes chers amis !");
                s = s.Replace("Welcome back to Britain.<E003 12>\r\nAnd thank you for your timely help.", "Bienvenue en Angleterre.<E003 12>\r\nEt merci infiniment pour votre aide providentielle.");
                s = s.Replace("Think nothing of it!<E049><E003 8> <E164 2 80 1 2 6 0 0 1><E118 2 1.1><E139 2><E025 2>I believe you've had an even more\r\nwearing day than Mikotoba and I, <E049><E003 6><E025 3>no?", "Il n'y a pas de quoi !<E049><E003 8> <E164 2 80 1 2 6 0 0 1><E118 2 1.1><E139 2><E025 2>Je crois que votre journée a été bien plus\r\néprouvante encore que la nôtre, <E049><E003 6><E025 3>n'est-ce pas ?");
                s = s.Replace("You could say that.<E003 10> <E025 2>We were on the brink of defeat in<E145 2 64>\r\ncourt earlier.", "On peut le dire.<E003 10> <E025 2>Nous étions au bord du gouffre tout à l'heure<E145 2 64>\r\nau tribunal.");
                s = s.Replace("So this prosecutor, <E049><E003 6>Asogi, <E049><E003 8>had you on the ropes, <E049><E003 6>did he?<E049><E003 12>\r\n<E025 2>And he's your best friend, <E003 4>you say?", "Ainsi, ce procureur, <E049><E003 6>Asogi, <E049><E003 8>vous a acculé dans les cordes ?<E049><E003 12>\r\n<E025 2>Et vous dites qu'il est votre meilleur ami ?");
                s = s.Replace("...he's not really the man I knew in Japan any more.<E145 2 64><E003 16>\r\n<E025 3>Kazuma's...<E003 6><E145 46 70><E118 46 0.7><E003 4>changed.", "...il n'est plus vraiment l'homme que j'ai connu au Japon.<E145 2 64><E003 16>\r\n<E025 3>Kazuma a...<E003 6><E145 46 70><E118 46 0.7><E003 4>changé.");
                s = s.Replace("Oh, <E049><E003 6>Mr Naruhodo...", "Oh, <E049><E003 6>M. Naruhodo...");
                s = s.Replace("(I mean, <E003 6>it's incredible...)", "(Je veux dire... <E003 6>c'est insensé...)");
                s = s.Replace("(To think that he'd even entertain the idea of acting as the\r\nReaper's <E006>assassin<E007>...)", "(Penser qu'il a pu ne serait-ce qu'envisager d'agir comme\r\n<E006>l'assassin<E007> du Faucheur...)");
                s = s.Replace("Well nevertheless, <E049><E003 8>you must introduce me.", "Quoi qu'il en soit, <E049><E003 8>vous devez me le présenter.");
                s = s.Replace("After all...", "Après tout...");
                s = s.Replace("...I've only ever met the young man as <E006>a corpse<E005>.", "...je n'ai connu ce jeune homme que sous la forme d'un <E006>cadavre<E005>.");
                s = s.Replace("(When all this started...<E003 12>almost a year ago now.)", "(Quand toute cette histoire a commencé...<E003 12>il y a près d'un an.)");
                return s;
            };

            // [128] BB\script\output\_sce04_c200_0000_eng#3
            entryTranslators[@"BB\script\output\_sce04_c200_0000_eng#3"] = (s) => {
                s = s.Replace("(Mr Sholmes still hasn't told us the truth about what really\r\nhappened back then.)", "(M. Sholmes ne nous a toujours pas révélé la vérité sur ce qui s'est réellement\r\npassé à l'époque.)");
                s = s.Replace("(About the motivation for what he himself described as<E003 10>\r\n<E025 3><E333>a ‘<E006>great detective's lie<E007>’.)", "(Sur les motivations de ce qu'il a lui-même qualifié<E003 10>\r\n<E025 3><E333>de « <E006>mensonge de grand détective<E007> ».)");
                s = s.Replace("Now then, I must say...<E049><E003 12><E145 2 66>it's really quite a journey all the\r\nway to France.", "À présent, je dois avouer que...<E049><E003 12><E145 2 66>c'est une sacrée trotte jusqu'en\r\nFrance.");
                s = s.Replace("Well it is another country, <E003 4>Mr Sholmes.<E049><E003 8>\r\n<E025 3><E145 3 77><E117 3 14><E144 3>So...<E003 8><E145 3 92><E144 3><E025 1><E346>what news of Judge Jigoku?!", "C'est un autre pays après tout, <E003 4>M. Sholmes.<E049><E003 8>\r\n<E025 3><E145 3 77><E117 3 14><E144 3>Alors...<E003 8><E145 3 92><E144 3><E025 1><E346>quelles sont les nouvelles du juge Jigoku ?!");
                s = s.Replace("We took him to Scotland Yard.<E049><E003 10> <E145 46 74><E118 46 0.8><E003 10><E025 3>The investigating\r\ndetectives there have a lot of questions for the man.", "Nous l'avons conduit à Scotland Yard.<E049><E003 10> <E145 46 74><E118 46 0.8><E003 10><E025 3>Les inspecteurs\r\nen charge de l'enquête ont d'innombrables questions à lui poser.");
                s = s.Replace("(Poor Professor Mikotoba.<E003 12>\r\nThis must be quite a shock for him.)", "(Pauvre professeur Mikotoba.<E003 12>\r\nCela doit être un choc terrible pour lui.)");
                s = s.Replace("Ah yes, <E049><E003 8><E145 2 64><E003 6><E060 0 158 0 0>I picked this up at the telegraph office on our way\r\nhome.", "Ah oui, <E049><E003 8><E145 2 64><E003 6><E060 0 158 0 0>j'ai récupéré ceci au bureau du télégraphe sur notre chemin\r\ndu retour.");
                s = s.Replace("What is it?", "De quoi s'agit-il ?");
                s = s.Replace("Surely you haven't forgotten already.<E049><E003 10>\r\nI put upon you for the matter only yesterday.", "Vous n'avez tout de même pas déjà oublié !<E049><E003 10>\r\nJe vous ai sollicité à ce propos hier seulement.");
                s = s.Replace("You put upon me, <E049><E003 4><E025 3>Sholmes.<E049><E003 5> <E145 46 76><E003 15><E025 3><E330>I had to fill out your telegram\r\nto Japan and foot the bill as well.", "Vous m'avez sollicité, <E049><E003 4><E025 3>Sholmes ?<E049><E003 5> <E145 46 76><E003 15><E025 3><E330>J'ai dû rédiger votre télégramme\r\npour le Japon et en régler la facture de ma poche, oui !");
                s = s.Replace("Oh!<E049><E003 12>\r\nYou've had a reply already?", "Oh !<E049><E003 12>\r\nVous avez déjà reçu une réponse ?");
                s = s.Replace("What was so urgent though, <E003 6>Mr Sholmes?", "Mais qu'y avait-il de si urgent, <E003 6>M. Sholmes ?");
                s = s.Replace("Such matters can wait until later.<E049><E003 8> <E145 2 70><E003 12><E346><E025 1>I'm far too hungry for an\r\ninvolved conversation at present!", "Ces broutilles attendront plus tard !<E049><E003 8> <E145 2 70><E003 12><E346><E025 1>J'ai bien trop faim pour me lancer\r\ndans une longue dissertation à cette heure !");
                s = s.Replace("Well that's good news.<E049><E003 8>\r\n<E164 4 68 1 2 8 0 1 1><E118 4 1.1><E139 4>Because supper is ready, everyone!", "Eh bien c'est une excellente nouvelle !<E049><E003 8>\r\n<E164 4 68 1 2 8 0 1 1><E118 4 1.1><E139 4>Car le dîner est servi, tout le monde !");
                s = s.Replace("Ah, <E049><E003 12>and what a feast it is!<E049><E003 10> <E025 2><E341>If I were none the wiser,<E049><E003 8><E025 1> I'd\r\nthink the trial were won already!", "Ah, <E049><E003 12>et quel somptueux banquet !<E049><E003 10> <E025 2><E341>Si je ne savais rien,<E049><E003 8><E025 1> je croirais\r\nle procès d'ores et déjà gagné !");
                s = s.Replace("Roast beef, <E049><E003 7>kippers, <E049><E003 7>stew, <E049><E003 7>steak <E049><E003 7>and kidney pie,<E049><E145 4 64><E003 8> Yorkshire\r\npudding...", "Rôti de bœuf, <E049><E003 7>harengs saurs, <E049><E003 7>ragoût, <E049><E003 7>tourte à la viande,<E049><E145 4 64><E003 8> Yorkshire\r\npudding...");
                s = s.Replace("Tomorrow could be a very long day, <E049><E003 4><E025 1><E164 4 67 1 2 8 0 1 1><E139 4>so eat up!", "Demain risque d'être une longue journée, <E049><E003 4><E025 1><E164 4 67 1 2 8 0 1 1><E139 4>alors mangez bien !");
                s = s.Replace("In that case, <E049><E003 8>I think I'll seat myself just here.", "En ce cas, <E049><E003 8>je crois que je vais m'installer juste ici.");
                s = s.Replace("This place appears to be the only one set <E049><E003 10><E330>with a helping<E145 4 64>\r\nof pheasant as well.", "Ce couvert semble être le seul garni <E049><E003 10><E330>d'une part<E145 4 64>\r\nde faisan également.");
                s = s.Replace("Oh, sorry, Hurley, <E049><E003 8>not there.", "Oh, désolée Hurley, <E049><E003 8>pas là.");
                s = s.Replace("Hm?<E049><E003 12> <E169 2 3><E025 2>Why ever not?<E049><E003 10>\r\nAre we in set places this evening?", "Hein ?<E049><E003 12> <E169 2 3><E025 2>Et pourquoi donc ?<E049><E003 10>\r\nAvons-nous un plan de table ce soir ?");
                s = s.Replace("Yes!<E049><E003 12> <E025 2>And that place <E049><E003 3><E164 4 68 1 2 8 0 2 1><E139 4><E025 1>is for Susie's daddy.", "Oui !<E049><E003 12> <E025 2>Et cette place-là <E049><E003 3><E164 4 68 1 2 8 0 2 1><E139 4><E025 1>est pour le papa de Susie !");
                s = s.Replace("For me?!", "Pour moi ?!");
                s = s.Replace("That's right!<E049><E003 10> <E025 2>I made it especially for you,<E049><E003 6> <E025 2>Professor\r\nMickey!", "C'est ça !<E049><E003 10> <E025 2>Je l'ai préparé spécialement pour vous,<E049><E003 6> <E025 2>professeur\r\nMikotoba !");
                s = s.Replace("I see...<E049><E003 14>\r\n<E025 2>Well that's terribly kind of you.", "Je vois...<E049><E003 14>\r\n<E025 2>Eh bien, c'est adorable de votre part.");
                s = s.Replace("It's...<E049><E003 15><E145 4 65><E118 4 0.85><E003 25><E239><E025 3>a shame, <E049><E003 6>really.", "C'est...<E049><E003 15><E145 4 65><E118 4 0.85><E003 25><E239><E025 3>bien dommage, <E049><E003 6>quand même.");
                s = s.Replace("What do you mean?", "Que veux-tu dire ?");
                s = s.Replace("Well...<E049><E003 12><E025 2>for a brief moment, <E049><E003 6><E025 3>I believed it.", "Eh bien...<E049><E003 12><E025 2>pendant un bref instant, <E049><E003 6><E025 3>j'y ai cru.");
                s = s.Replace("That Susie and I were half-sisters, <E049><E003 6>I mean.", "Que Susie et moi étions demi-sœurs, <E049><E003 6>je veux dire.");
                return s;
            };

            // [129] BB\script\output\_sce04_c200_0000_eng#4
            entryTranslators[@"BB\script\output\_sce04_c200_0000_eng#4"] = (s) => {
                s = s.Replace("Iris, <E049><E003 10>do...<E049><E003 15><E025 3>do you mean...?", "Iris, <E049><E003 10>tu...<E049><E003 15><E025 3>tu veux dire que... ?");
                s = s.Replace("Yes, <E049><E003 12><E025 2>I know now.<E049><E003 12>\r\n<E025 2>I overheard yesterday.", "Oui, <E049><E003 12><E025 2>je sais tout maintenant.<E049><E003 12>\r\n<E025 2>J'ai tout entendu hier.");
                s = s.Replace("I secretly listened in to the conversation you had <E049><E003 10><E025 2><E164 4 68 1 2 7 0 0 1><E139 4>after I\r\ntricked you all into thinking I'd left.", "J'ai écouté en cachette la discussion que vous avez eue <E049><E003 10><E025 2><E164 4 68 1 2 7 0 0 1><E139 4>après vous\r\navoir fait croire que j'étais sortie.");
                s = s.Replace("Wha...<E003 20><E024>", "Qu...<E003 20><E024>");
                s = s.Replace("WHAAAAAAAAAT?!", "QUOOOOOOOOI ?!");
                return s;
            };

            // [130] BB\script\output\_sce04_c200_0000_eng#5
            entryTranslators[@"BB\script\output\_sce04_c200_0000_eng#5"] = (s) => {
                s = s.Replace("(The misunderstanding arose because of that autopsy\r\nreport from ten years ago.)", "(Le malentendu est né de ce rapport d'autopsie\r\nd'il y a dix ans.)");
                s = s.Replace("(But actually...)", "(Mais en vérité...)");
                s = s.Replace("(...it turned out that neither Dr Wilson nor Professor\r\nMikotoba are Iris's father.)", "(...il s'est avéré que ni le Dr Wilson ni le professeur\r\nMikotoba ne sont le père d'Iris.)");
                s = s.Replace("Yes, <E049><E003 8>about that, Iris.<E049><E003 10>\r\n<E025 3><E145 2 68><E118 2 0.7><E003 12>You know <E049><E003 10><E025 3>I...", "Oui, <E049><E003 8>à ce propos, Iris.<E049><E003 10>\r\n<E025 3><E145 2 68><E118 2 0.7><E003 12>Tu sais bien que <E049><E003 10><E025 3>je...");
                s = s.Replace("I know.<E049><E003 12> <E025 2>You can't tell me at the moment.", "Je sais.<E049><E003 12> <E025 2>Tu ne peux rien me dire pour l'instant.");
                s = s.Replace("Oh Iris...", "Oh, Iris...");
                s = s.Replace("The pheasant is by way of an apology.<E049><E003 10>\r\n<E025 3><E145 4 74><E118 4 1.3><E003 15>I'm sorry for eavesdropping.", "Le faisan, c'est en guise d'excuses.<E049><E003 10>\r\n<E025 3><E145 4 74><E118 4 1.3><E003 15>Je suis désolée d'avoir écouté aux portes.");
                s = s.Replace("Oh...<E003 12><E025 2>no no, <E049><E003 8><E025 2>that's quite alright.", "Oh...<E003 12><E025 2>non, non, <E049><E003 8><E025 2>ce n'est rien du tout.");
                s = s.Replace("Then why don't I get <E341>any apologetic pheasant?!", "Alors pourquoi n'ai-je point droit <E341>à un faisan d'excuses, moi ?!");
                s = s.Replace("(So just who is Iris's father?)", "(Mais alors, qui est le véritable père d'Iris ?)");
                s = s.Replace("(I suppose that's not something we'll be finding out today...)", "(J'imagine que ce n'est pas aujourd'hui que nous le saurons...)");
                s = s.Replace("So then, <E049><E003 8><E025 2>let us dine...<E049><E003 12><E341><E025 1>while our largely pheasantless plates\r\nare still piping hot!", "Sur ce, <E049><E003 8><E025 2>passons à table...<E049><E003 12><E341><E025 1>pendant que nos assiettes, quoique bien privées de faisan,\r\nsont encore bien chaudes !");
                s = s.Replace("A fine idea, Sholmes.<E049><E003 10> It all looks absolutely delicious.", "Excellente idée, Sholmes.<E049><E003 10> Tout cela a l'air délicieux.");
                s = s.Replace("Eat as much as you like!<E049><E003 12>\r\n<E341>There are always seconds!", "Mangez autant qu'il vous plaira !<E049><E003 12>\r\n<E341>Il y a du rab pour tout le monde !");
                s = s.Replace("(This could be our last chance to ask questions before\r\ntomorrow's trial.)", "(C'est sans doute notre dernière chance de poser des questions avant\r\nle procès de demain.)");
                s = s.Replace("(About that telegram from Japan...<E003 12>and about Kazuma.)", "(À propos de ce télégramme venu du Japon...<E003 12>et au sujet de Kazuma.)");
                s = s.Replace("(I can't let this opportunity slip away!)", "(Je ne dois pas laisser filer cette opportunité !)");
                return s;
            };

            // [131] BB\script\output\_sce04_c200_0020_eng#2
            entryTranslators[@"BB\script\output\_sce04_c200_0020_eng#2"] = (s) => {
                s = s.Replace("Alright, everyone!<E049><E003 12> <E341><E025 2>That's quite enough of all that serious\r\ntalk for one day.", "Très bien, tout le monde !<E049><E003 12> <E341><E025 2>C'est bien assez de discussions sérieuses\r\npour aujourd'hui.");
                s = s.Replace("Isn't it, Hurley?<E049><E003 12>\r\n<E025 2>I mean, <E049><E003 8><E164 4 66 1 2 8 0 2 1><E118 4 1.4><E139 4><E025 1>look at the time!", "N'est-ce pas, Hurley ?<E049><E003 12>\r\n<E025 2>Enfin, <E049><E003 8><E164 4 66 1 2 8 0 2 1><E118 4 1.4><E139 4><E025 1>regardez l'heure qu'il est !");
                s = s.Replace("Ah, <E049><E003 8>quite right, Iris.<E049><E003 12> <E025 2>We must conclude our preparations\r\nfor tomorrow.", "Ah, <E049><E003 8>tout à fait, Iris.<E049><E003 12> <E025 2>Nous devons achever nos préparatifs\r\npour demain.");
                s = s.Replace("(What preparations?)", "(Quels préparatifs ?)");
                s = s.Replace("Well, <E049><E003 4><E145 46 64><E003 20><E025 2>I think I shall make my way back to my hotel room\r\nnow.", "Bien, <E049><E003 4><E145 46 64><E003 20><E025 2>je crois que je vais regagner ma chambre d'hôtel\r\ndésormais.");
                s = s.Replace("This has certainly been a night to remember!", "Ce fut à n'en point douter une soirée mémorable !");
                s = s.Replace("It is <E049><E003 7><E145 4 64><E118 4 1.5><E003 15><E025 2><E330>a little bit sad, though.", "C'est quand même <E049><E003 7><E145 4 64><E118 4 1.5><E003 15><E025 2><E330>un petit peu triste...");
                s = s.Replace("I mean, <E049><E003 6>I liked the idea of you being my daddy.", "Enfin, <E049><E003 6>j'aimais bien l'idée que vous soyez mon papa.");
                s = s.Replace("Because then <E049><E003 8><E333><E145 46 68><E118 46 1.5><E149 46 0 0>Susie would have been my big sister.", "Parce que comme ça, <E049><E003 8><E333><E145 46 68><E118 46 1.5><E149 46 0 0>Susie aurait été ma grande sœur.");
                s = s.Replace("I'm sorry, Iris...", "Je suis désolé, Iris...");
                s = s.Replace("I know, Iris.<E049><E003 4> <E164 3 76 1 2 6 0 0 1><E118 3 1.2><E139 3>I was thinking quite the same thing.", "Je sais, Iris.<E049><E003 4> <E164 3 76 1 2 6 0 0 1><E118 3 1.2><E139 3>Je pensais exactement la même chose.");
                s = s.Replace("Were you?", "Vraiment ?");
                s = s.Replace("But if somebody like me would be worthy...", "Mais si quelqu'un comme moi en est digne...");
                s = s.Replace("...I would be delighted to become your sister!", "...je serais ravie d'être ta grande sœur !");
                s = s.Replace("What?<E049><E145 3 64><E118 3 1.2><E003 14> <E025 2>Really?!", "Vraiment ?<E049><E145 3 64><E118 3 1.2><E003 14> <E025 2>C'est vrai ?!");
                s = s.Replace("Oh yes!<E049><E003 12> Without question!", "Oh oui !<E049><E003 12> Sans la moindre hésitation !");
                s = s.Replace("So...<E049><E003 12><E025 2>you'll teach me all the ways you know to throw<E145 3 64> Runo\r\nto the floor?", "Alors...<E049><E003 12><E025 2>tu m'apprendras toutes les prises que tu connais pour plaquer<E145 3 64> Runo\r\nau tapis ?");
                s = s.Replace("Yes yes, <E049><E003 6>of course.<E049><E003 3><E164 3 74 1 2 8 0 2 1><E118 3 1.2><E139 3><E025 1><E160 4><E118 4 1.3>\r\nIt would be my pleasure!", "Oui, oui, <E049><E003 6>bien entendu.<E049><E003 3><E164 3 74 1 2 8 0 2 1><E118 3 1.2><E139 3><E025 1><E160 4><E118 4 1.3>\r\nCe sera un immense plaisir !");
                s = s.Replace("You didn't have to agree quite so readily...", "Vous n'étiez pas obligée d'accepter avec un tel empressement...");
                s = s.Replace("Oh, <E049><E003 12><E025 1>but wait a minute!<E049><E003 6><E145 4 65><E118 4 1.2><E003 15>\r\n<E025 2>If Susie's going to be my big sister...", "Oh, <E049><E003 12><E025 1>mais attendez une minute !<E049><E003 6><E145 4 65><E118 4 1.2><E003 15>\r\n<E025 2>Si Susie devient ma grande sœur...");
                s = s.Replace("...you could be my big brother if you want, Runo!", "...tu pourrais être mon grand frère si tu veux, Runo !");
                s = s.Replace("I, <E003 8>I mean, <E003 10><E025 1><E335>yes, of course!<E003 14>\r\n<E025 2>If you'll have me, <E003 6>I'll gladly be your brother.", "Je... <E003 8>enfin, <E003 10><E025 1><E335>oui, bien sûr !<E003 14>\r\n<E025 2>Si tu veux bien de moi, <E003 6>je serai ravi d'être ton grand frère.");
                s = s.Replace("Well done, Iris.<E049><E003 8> We must always be <E006>mindful of feelings<E005>.<E049><E003 8>\r\n<E164 19 81 1 2 8 0 0 1><E139 19><E025 1>I've raised you so well!", "Très bien parlé, Iris.<E049><E003 8> Il faut toujours ménager <E006>la sensibilité d'autrui<E005>.<E049><E003 8>\r\n<E164 19 81 1 2 8 0 0 1><E139 19><E025 1>Je t'ai si bien élevée !");
                s = s.Replace("Ah <E003 8><E025 1>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>hah!", "Ah <E003 8><E025 1>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>ha <E003 3>hah !");
                s = s.Replace("(Because being sensitive is your strong suit, <E003 6>naturally...)", "(Parce que la délicatesse est votre fort, <E003 6>évidemment...)");
                s = s.Replace("Right, <E049><E003 8>I'm going to work extra hard for tomorrow now...<E049><E003 6>\r\n<E025 1><E164 4 67 1 2 8 0 1 1><E139 4>because it's for my big brother and sister!", "Bien, <E049><E003 8>je vais redoubler d'efforts pour demain maintenant...<E049><E003 6>\r\n<E025 1><E164 4 67 1 2 8 0 1 1><E139 4>parce que c'est pour mon grand frère et ma grande sœur !");
                s = s.Replace("...what is all this talk about <E006>preparing for tomorrow<E005>?<E145 4 64><E003 14>\r\n<E025 3>Preparing what?", "...qu'est-ce que vous entendez par <E006>se préparer pour demain<E005> ?<E145 4 64><E003 14>\r\n<E025 3>Préparer quoi au juste ?");
                s = s.Replace("Hee hee!<E049><E003 20> <E164 4 66 1 2 6 0 0 1><E139 4><E169 4 3>You'll just have to wait and see!", "Hé hé !<E049><E003 20> <E164 4 66 1 2 6 0 0 1><E139 4><E169 4 3>Il faudra attendre demain pour le voir !");
                s = s.Replace("Good luck in court tomorrow.<E049><E003 10>\r\n<E025 1><E164 19 79 1 2 8 0 1 1><E139 19>I'm expecting a sterling performance!", "Bonne chance au tribunal demain.<E049><E003 10>\r\n<E025 1><E164 19 79 1 2 8 0 1 1><E139 19>Je compte sur une prestation magistrale !");
                s = s.Replace("I'll do my very best, <E003 8><E025 1>of course!", "Je ferai de mon mieux, <E003 8><E025 1>bien entendu !");
                s = s.Replace("So the overnight break in the trial's\r\n<E042><CNTR>proceedings became a crucial turning point...", "Cette nuit de répit accordée au procès\r\n<E042><CNTR>devint un tournant crucial des événements...");
                s = s.Replace("...exposing new truths <E003 6>whilst posing new conundrums.", "...révélant de nouvelles vérités <E003 6>tout en soulevant de nouveaux mystères.");
                s = s.Replace("That list of four names on the\r\n<E042><CNTR>telegram in Judge Jigoku's office...", "Cette liste de quatre noms sur le\r\n<E042><CNTR>télégramme dans le bureau du juge Jigoku...");
                s = s.Replace("...and the extraordinary assassination plot in which\r\n<E042><CNTR>my best friend had somehow become involved...", "...et l'extraordinaire complot d'assassinat dans lequel\r\n<E042><CNTR>mon meilleur ami s'était retrouvé impliqué...");
                s = s.Replace("I felt as though I had been plunged into an\r\n<E042><CNTR><E025 3>even greater darkness all of a sudden.", "J'avais l'impression d'avoir été subitement plongé\r\n<E042><CNTR><E025 3>dans des ténèbres plus épaisses encore.");
                s = s.Replace("But at the same time...<E003 15>\r\n<E042><CNTR>I felt sure I would see the light again soon.", "Mais dans le même temps...<E003 15>\r\n<E042><CNTR>j'avais la certitude que la lumière renaîtrait bientôt.");
                s = s.Replace("Because I was lucky enough to have...", "Car j'avais le privilège inestimable d'avoir...");
                s = s.Replace("...the most wonderful family in the world\r\n<E042><CNTR>standing steadfastly behind me.", "...la plus merveilleuse des familles au monde\r\n<E042><CNTR>veillant inconditionnellement sur moi.");
                return s;
            };

        }
    }
}
