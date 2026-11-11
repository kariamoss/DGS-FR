using System;
using System.Text;
using System.Collections.Generic;

namespace TranslatorAct6 {
    public partial class Program {
        public static void RegisterPart2_C() {
            entryTranslators[@"BB\script\output\_sce02_chr070_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("As a detective, what do you make of this?", "En tant qu'inspecteur, qu'en pensez-vous ?");
                s = s.Replace("Personally speakin', nine times out of ten I find clues turn\r\nout to be red herrings.", "Personnellement, neuf fois sur dix, les indices finissent par être des fausses pistes.");
                s = s.Replace("So there's every chance that's totally irrelevant.", "Y'a donc de fortes chances pour que ce soit complètement sans rapport.");
                s = s.Replace("(That's actually a fairly persuasive argument...)", "(C'est un argument assez convaincant, en vérité...)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr070_00_eng#7"] = (en) => {
                string s = en;
                s = s.Replace("This is the symbol of a defence lawyer where I come\r\nfrom, Inspector.", "C'est l'insigne d'avocat de la défense de mon pays, inspecteur.");
                s = s.Replace("Well, it doesn't pass muster here in London.", "Eh bien, ça n'a aucune valeur ici à Londres.");
                s = s.Replace("You might as well chuck it in the deep fat fryer.", "Vous feriez aussi bien d'le jeter dans la friture.");
                s = s.Replace("...No one's ever said that to me before.", "...Personne ne m'avait jamais dit ça auparavant.");
                s = s.Replace("Mr Sholmes suggested I feed it to a dog, though.", "M. Holmes m'a suggéré de le donner à manger à un chien, cela dit.");
                s = s.Replace("If you fry it first, you can feed it to me.", "Si vous l'faites frire d'abord, vous pouvez m'le donner à moi.");
                s = s.Replace("(...Does he think it's made of potato?)", "(...Croit-il que c'est fait en pomme de terre ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr070_00_eng#8"] = (en) => {
                string s = en;
                s = s.Replace("Inspector, have you read this paper?", "Inspecteur, avez-vous lu ce journal ?");
                s = s.Replace("Yeah, two unwelcome blasts back to back. This one at\r\nthe exhibition, and the Reaper gettin' attacked.", "Ouais, deux sales coups coup sur coup. L'explosion à l'exposition, et l'Faucheur qui s'fait attaquer.");
                s = s.Replace("I know. Terrible news to wake up to, wasn't it?", "Je sais. De bien tristes nouvelles au réveil, n'est-ce pas ?");
                s = s.Replace("I tried to pretend I hadn't read it and turned over for\r\nanother forty winks.", "J'ai essayé d'faire semblant d'rien avoir vu et j'me suis rendormi.");
                s = s.Replace("Thanks to that, I was late up and got a roastin' from the\r\nsuper.", "À cause d'ça, j'me suis pointé en retard et j'me suis fait passer un savon par l'commissaire.");
                s = s.Replace("Some mornings are like that, aren't they?", "Il y a des matins comme ça, n'est-ce pas ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("I actually came here today to ask for your permission.", "Je suis venu aujourd'hui pour solliciter votre autorisation.");
                s = s.Replace("...Go on.", "...Continuez.");
                s = s.Replace("Six months ago, my right to work in court as a lawyer\r\nwas revoked and I was told to spend my time studying.", "Il y a six mois, mon droit d'exercer au barreau a été révoqué et on m'a ordonné de consacrer mon temps à l'étude.");
                s = s.Replace("Obviously, I'm very sorry for what happened.\r\nBut the thing is...", "Évidemment, je regrette profondément ce qui s'est produit. Mais le fait est...");
                s = s.Replace("...it made me understand what it really means to defend\r\nsomebody under the rules of a foreign justice system.", "...que cela m'a permis de comprendre ce que signifie réellement défendre quelqu'un sous les règles d'un système judiciaire étranger.");
                s = s.Replace("And I desperately want to have another go.\r\nPlease! Permit me to enter the courtroom again!", "Et je désire ardemment retenter ma chance. De grâce ! Autorisez-moi à plaider de nouveau !");
                s = s.Replace("Mr Naruhodo...", "M. Naruhodo...");
                s = s.Replace("Y-Yes?", "O-Oui ?");
                s = s.Replace("(Ugh...here it comes...)", "(Aïe... nous y voilà...)");
                s = s.Replace("I'm sure you haven't forgotten your position here, have\r\nyou?", "J'ose espérer que vous n'avez pas oublié votre statut ici, n'est-ce pas ?");
                s = s.Replace("At best, you are a substitute for your compatriot.\r\nThis was never your intended role.", "Au mieux, vous n'êtes que le remplaçant de votre compatriote. Ce rôle ne vous était nullement destiné.");
                s = s.Replace("(Well, that's true.)", "(Eh bien, c'est vrai.)");
                s = s.Replace("(The Japanese government actually sent my best friend on\r\nthis study tour, not me. It should have been Kazuma.)", "(Le gouvernement japonais avait envoyé mon meilleur ami pour ce voyage d'études, pas moi. Cela aurait dû être Kazuma.)");
                s = s.Replace("(He was so determined to bring change to our own justice\r\nsystem at home. That was his calling.)", "(Il était si déterminé à réformer notre système judiciaire au Japon. C'était sa véritable vocation.)");
                s = s.Replace("(If that tragic accident hadn't happened...)", "(Si ce tragique accident n'avait pas eu lieu...)");
                s = s.Replace("(...I wouldn't be here in this office now.)", "(...je ne serais pas dans ce bureau aujourd'hui.)");
                s = s.Replace("Mr Asogi was my best friend, you see.", "M. Asogi était mon meilleur ami, voyez-vous.");
                s = s.Replace("That's why I can't leave it unfinished.\r\nI have to fulfil his calling for him.", "C'est pourquoi je ne peux pas laisser les choses inachevées. Je me dois d'accomplir sa mission à sa place.");
                s = s.Replace("Hm, his ‘calling’, you say...\r\nHas it never occurred to you...", "Hum, sa « vocation », dites-vous... Ne vous est-il jamais venu à l'esprit...");
                s = s.Replace("...that perhaps you know nothing of his true calling?", "...que vous ignorez peut-être tout de sa véritable mission ?");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("The mission with which that young law student was\r\ncharged. What do you suppose it really was?", "La mission dont ce jeune étudiant en droit avait été chargé. De quoi s'agissait-il en réalité selon vous ?");
                s = s.Replace("Wh-What do you mean?", "Qu... Qu'entendez-vous par là ?");
                s = s.Replace("(‘Mission’? He's not making any sense.)", "(Une « mission » ? Ça n'a aucun sens.)");
                s = s.Replace("Never mind.", "Peu importe.");
                s = s.Replace("I've read all the reports you've submitted over the past\r\nsix months.", "J'ai lu tous les rapports que vous m'avez soumis au cours de ces six derniers mois.");
                s = s.Replace("It's clear to me that you regret your actions, and have\r\nbeen studiously obeying your revised instructions.", "Il m'apparaît clairement que vous regrettez vos actes et avez scrupuleusement obéi à mes consignes.");
                s = s.Replace("Do, do you mean...?", "Voulez... voulez-vous dire... ?");
                s = s.Replace("As of this moment, I reinstate your licence to practise law\r\nhere in Great Britain!", "À compter de cet instant, je rétablis votre autorisation d'exercer le droit ici en Grande-Bretagne !");
                s = s.Replace("Thank you!\r\nThank you so much!", "Merci !\r\nMerci infiniment !");
                s = s.Replace("That's wonderful news, Runo!", "C'est une merveilleuse nouvelle, Mister Yûno !");
                s = s.Replace("In fact, I believe I have the perfect case to mark your\r\ncomeback. A curious affair.", "En réalité, je crois tenir l'affaire idéale pour signer votre grand retour. Une affaire fort singulière.");
                s = s.Replace("You'll consider it, I hope?", "Vous accepterez d'y jeter un œil, j'espère ?");
                s = s.Replace("Of course! Please, tell me more!", "Bien entendu ! Je vous en prie, dites-m'en plus !");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("You described it as ‘a curious affair’...?", "Vous disiez qu'il s'agissait d'une « affaire fort singulière »... ?");
                s = s.Replace("Yes, that's right. I believe it was reported in the press.", "Oui, en effet. La presse s'en est fait l'écho, je crois.");
                s = s.Replace("Are you aware that there was a serious accident at the\r\nGreat Exhibition yesterday?", "Savez-vous qu'un grave accident est survenu à l'Exposition universelle hier ?");
                s = s.Replace("Oh. No.", "Oh. Non.");
                s = s.Replace("Yes! I read about it.", "Oui ! J'ai lu l'article.");
                s = s.Replace("A professor from Germany tried to carry out a crazy\r\nexperiment.", "Un professeur venu d'Allemagne a tenté une expérience insensée.");
                s = s.Replace("Let me see...how was it described...?\r\n‘Super-high-voltage instantaneous kinesis’ I think.", "Voyons voir... comment disaient-ils... ? « Téléportation cinétique instantanée à très haute tension », je crois.");
                s = s.Replace("Instantaneous kinesis?\r\nAs in...moving things with a click of the fingers?", "Téléportation cinétique ? C'est-à-dire... déplacer des choses d'un claquement de doigts ?");
                s = s.Replace("That's right... It's just what my herbal blends need:\r\na dash of devil-may-care!", "Exactement... C'est tout ce qui manque à mes infusions : une touche de folie furieuse !");
                s = s.Replace("(Whatever this serious accident was exactly, it's clearly\r\ncaptured Iris's imagination.)", "(Quel que soit cet accident, il a visiblement captivé l'imagination d'Iris.)");
                s = s.Replace("It's an unfortunate business. A large explosion engulfed\r\nthe public experimentation stage and a man lost his life.", "C'est une triste affaire. Une violente explosion a soufflé l'estrade de démonstration et un homme y a laissé la vie.");
                s = s.Replace("A certain Mr Odie Asman. An investor and a well known\r\nfigure in society.", "Un certain Odoril Asman. Un investisseur fort connu de la haute société.");
                s = s.Replace("A large explosion...?", "Une violente explosion... ?");
                s = s.Replace("A, a man died?", "Un... un homme est mort ?");
                s = s.Replace("The man responsible for the experiment was Professor\r\nAlbert Harebrayne.", "Le responsable de cette expérience est le professeur Samba Lonron.");
                s = s.Replace("He was detained immediately after the incident, and is\r\ndue to appear in court tomorrow.\r\nOn the charge of murder.", "Il a été arrêté aussitôt après l'incident et comparaîtra au tribunal dès demain. Sous l'inculpation de meurtre.");
                s = s.Replace("What?!\r\nMurder?!", "Quoi ?!\r\nDe meurtre ?!");
                s = s.Replace("If you intend to take on his defence, you should hurry to\r\nmeet with him at the prison.", "Si vous avez l'intention d'assurer sa défense, vous devriez vous hâter de le rencontrer à la maison d'arrêt.");
                s = s.Replace("There is very little time left for you to carry out any kind\r\nof investigation.", "Il vous reste fort peu de temps pour mener une quelconque enquête.");
                s = s.Replace("(The Great Exhibition... A scientific experiment gone\r\nwrong... And...murder...?)", "(L'Exposition universelle... Une expérience scientifique qui tourne mal... Et... un meurtre... ?)");
                s = s.Replace("(I feel out of my depth before I've even started.\r\nStill...)", "(Je me sens complètement dépassé avant même d'avoir commencé. Mais bon...)");
                s = s.Replace("We should go to the prison straight away then, and try to\r\nmeet with this German professor...don't you think?", "Nous devrions aller à la prison sans plus tarder pour rencontrer ce professeur allemand... tu ne crois pas ?");
                s = s.Replace("Definitely!", "Absolument !");
                s = s.Replace("Ah yes...one more thing about the case...\r\nThere's a connection with our mutual acquaintance...the\r\nReaper.", "Ah oui... un dernier détail à propos de cette affaire... Il existe un lien avec notre relation commune... le Faucheur.");
                s = s.Replace("Oh!\r\n(With Lord van Zieks? How?)", "Oh !\r\n(Avec Lord Van Peers ? Mais comment ?)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("All sorts of conferences have been taking place around\r\nthe world to coincide with the Great Exhibition.", "Toutes sortes de congrès se tiennent à travers le monde à l'occasion de l'Exposition universelle.");
                s = s.Replace("And next month, the largest and most important of them\r\nall will take place at last:", "Et le mois prochain s'ouvrira enfin le plus grandiose et le plus important de tous :");
                s = s.Replace("The International Forensic Science Symposium.", "Le Symposium international de médecine légale et police scientifique.");
                s = s.Replace("It does seem as though criminal investigation needs to\r\nembrace scientific methods, doesn't it?", "Il semble en effet indispensable que la criminologie s'approprie les méthodes scientifiques, n'est-ce pas ?");
                s = s.Replace("Exactly!", "Parfaitement !");
                s = s.Replace("Agh!", "Argh !");
                s = s.Replace("London - the global epicentre of culture, science and\r\nwealth – now has a population exceeding six million.", "Londres... épicentre planétaire de la culture, de la science et des richesses, dépasse désormais les six millions d'âmes.");
                s = s.Replace("Sadly, crime in the capital is growing at a similarly\r\nstartling rate.", "Hélas, la criminalité croît à un rythme tout aussi alarmant.");
                s = s.Replace("So it's imperative that we use the latest scientific methods\r\nto investigate and resolve cases as efficiently as possible.", "Il est donc impératif d'utiliser les méthodes scientifiques les plus modernes pour résoudre les affaires avec un maximum d'efficacité.");
                s = s.Replace("Which is what's known as ‘forensic science’, isn't it?", "C'est ce qu'on appelle la « police scientifique », n'est-ce pas ?");
                s = s.Replace("Exactly! The future of policing!", "Exactement ! L'avenir des enquêtes criminelles !");
                s = s.Replace("Regrettably however...\r\n...Britain is currently dragging its feet when it comes to\r\nthe adoption of forensic methods.", "Hélas, pour l'heure... la Grande-Bretagne se montre bien trop frileuse quant à l'adoption de ces méthodes scientifiques.");
                s = s.Replace("Oh dear. That's alarming.", "Ciel. C'est fort préoccupant.");
                s = s.Replace("Exactly! It's extremely alarming!", "Exactement ! C'est alarmant au plus haut point !");
                s = s.Replace("If I were Her Majesty's Attorney General, you can be\r\nsure...", "Si j'étais procureur général de Sa Majesté, soyez certains...");
                s = s.Replace("...the numbers of crimes committed and resolved in\r\nLondon would be very different to the current figures.", "...que le taux d'élucidation des crimes à Londres serait bien supérieur aux chiffres actuels.");
                s = s.Replace("And I can cite twelve solid arguments and two hundred\r\nand twenty-three individual reasons to support my claim!", "Et je peux invoquer douze arguments irréfutables ainsi que deux cent vingt-trois raisons précises pour appuyer mes dires !");
                s = s.Replace("Sorry?", "Pardon ?");
                s = s.Replace("By way of apology for keeping you waiting earlier, I shall\r\ndetail every one now!", "En guise d'excuses pour vous avoir fait attendre tout à l'heure, je vais vous les énumérer sans attendre !");
                s = s.Replace("WHAT?!", "QUOI ?!");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#4"] = (en) => {
                string s = en;
                s = s.Replace("Fortunately, Lord van Zieks emerged from the attack\r\nunscathed.", "Fort heureusement, Lord Van Peers est sorti indemne de cette agression.");
                s = s.Replace("Street ruffians are no match for that man.\r\nHe's a very capable fighter.", "Des voyous des bas-fonds ne font pas le poids face à lui. C'est un duelliste hors pair.");
                s = s.Replace("But, but that's incredible!\r\nThey were armed with guns!", "Mais... c'est incroyable ! Ils étaient armés de pistolets !");
                s = s.Replace("Why was he attacked, though?\r\nDo we know?", "Pourquoi a-t-il été attaqué au juste ? Le sait-on ?");
                s = s.Replace("It's related to events that occurred a month ago.", "C'est lié à des événements survenus le mois dernier.");
                s = s.Replace("A leader of one of the capital's criminal organisations was\r\nindicted and prosecuted...by van Zieks.", "Le chef d'une organisation criminelle de la capitale avait été inculpé et poursuivi... par Van Peers.");
                s = s.Replace("But the man was acquitted. I've no doubt large sums of\r\nmoney were involved behind the scenes.", "Mais l'individu a été acquitté. De fortes sommes d'argent ont circulé sous le manteau, sans l'ombre d'un doute.");
                s = s.Replace("Large sums of money?", "De fortes sommes d'argent ?");
                s = s.Replace("A deplorable situation. Members of the jury were bribed,\r\nit seems.", "Une situation déplorable. Des jurés ont été corrompus, semble-t-il.");
                s = s.Replace("However...despite winning his freedom...\r\n...the man in question met a dramatic end yesterday.", "Toutefois... après avoir recouvré la liberté... l'individu en question a trouvé une fin tragique hier.");
                s = s.Replace("But, but you're not suggesting that was the work of the\r\nReaper, surely?", "Mais... vous ne sous-entendez tout de même pas que c'est l'œuvre du Faucheur ?");
                s = s.Replace("The victim's henchmen certainly seem to think so.\r\nHe was a man by the name of Asman.\r\nMr Odie Asman.", "Les sbires de la victime en sont en tout cas convaincus. C'était un homme du nom d'Asman. M. Odoril Asman.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#6"] = (en) => {
                string s = en;
                s = s.Replace("Did...did you say Asman?", "Avez... avez-vous dit Asman ?");
                s = s.Replace("That's the man who died in the big explosion at the Great\r\nExhibition!", "C'est l'homme qui a péri dans la violente explosion à l'Exposition universelle !");
                s = s.Replace("Yes. Known publicly as an investor, but in reality...the\r\nhead of a significant criminal organisation.", "En effet. Connu en public sous les traits d'un investisseur, mais en vérité... à la tête d'une vaste pègre locale.");
                s = s.Replace("(Unbelievable...)", "(Incroyable...)");
                s = s.Replace("...I wonder, could I ask you something, Lord Stronghart?", "...Dites-moi, puis-je vous poser une question, Lord Harry Caine ?");
                s = s.Replace("Try me.", "Je vous écoute.");
                s = s.Replace("Why do you use Lord van Zieks as a prosecutor?", "Pourquoi faites-vous appel à Lord Van Peers comme procureur ?");
                s = s.Replace("All the criminals who manage to get off in court then\r\nmeet with mysterious ends outside the courtroom.", "Tous les criminels qui parviennent à se faire acquitter finissent par mourir mystérieusement hors du tribunal.");
                s = s.Replace("And fearful of that fate, they seek to strike at Lord van\r\nZieks first.", "Et terrifiés par ce sort, ils cherchent à frapper Lord Van Peers en premier.");
                s = s.Replace("I know there's no evidence that he actually is the Reaper\r\nin that sense, but still...\r\nSomething's clearly going on here!", "Je sais qu'il n'y a aucune preuve qu'il soit le Faucheur, mais tout de même... Il se passe quelque chose de louche !");
                s = s.Replace("I have van Zieks work for the prosecution service for two\r\nreasons:", "Si je confie des affaires à Van Peers, c'est pour deux raisons :");
                s = s.Replace("Firstly, the man is the best prosecutor in the capital, bar\r\nnone.", "Premièrement, cet homme est le meilleur procureur de la capitale, sans exception.");
                s = s.Replace("And secondly...\r\n...any deaths of criminals that have occurred outside the\r\ncourtroom following his trials...are nothing to do with him.", "Et deuxièmement... les morts de criminels survenues hors de l'enceinte judiciaire après ses procès... n'ont absolument rien à voir avec lui.");
                s = s.Replace("But that doesn't make sense! How can you explain the\r\nway so many have died if not by someone's hand?", "Mais cela n'a pas de sens ! Comment expliquer tant de disparitions si ce n'est par la main d'un assassin ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#9"] = (en) => {
                string s = en;
                s = s.Replace("Um, could I show you this, Lord Stronghart?", "Hum, pourrais-je vous montrer ceci, Lord Harry Caine ?");
                s = s.Replace("...I'm the Lord Chief Justice. I'm not here to offer advice\r\nabout evidence.", "...Je suis le juge en chef. Je ne suis pas là pour donner mon avis sur des pièces à conviction.");
                s = s.Replace("Oh...", "Oh...");
                s = s.Replace("Especially when the evidence in question is so dull.", "Tout particulièrement quand la pièce en question est si dénuée d'intérêt.");
                s = s.Replace("(Ah, so that's the real reason.)", "(Ah, c'est donc ça la vraie raison.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#10"] = (en) => {
                string s = en;
                s = s.Replace("Oh! That reminds me!\r\nHave you seen this?", "Oh ! Ça me fait penser ! Avez-vous vu ceci ?");
                s = s.Replace("The reports of the overwhelming success of the Great\r\nExhibition? Of course.", "Les éloges sur le triomphe éclatant de l'Exposition universelle ? Évidemment.");
                s = s.Replace("No no, not that. The story on the back page.", "Non, non, pas ça. L'article en dernière page.");
                s = s.Replace("What story...?", "Quel article... ?");
                s = s.Replace("‘The Reaper Attacked’...\r\nAh, that.\r\nYou've enjoyed some victories in court against my\r\nnumber one prosecutor, have you not?", "« Le Faucheur agressé »... Ah, cela. Vous avez remporté quelques victoires au tribunal contre mon procureur vedette, n'est-ce pas ?");
                s = s.Replace("Poor Mr Reaper...\r\nWhat happened to him?\r\nHe, he wasn't killed, was he?", "Pauvre M. le Faucheur... Que lui est-il arrivé ? Il... il n'a pas été tué, n'est-ce pas ?");
                s = s.Replace("There's no need for concern. Lord van Zieks would not\r\nbe so easily dispatched, I assure you.", "Inutile de vous inquiéter. Lord Van Peers ne se laisserait pas occire si facilement, je vous le garantis.");
                s = s.Replace("Can you tell us what happened?\r\nI'd really love to know!", "Pouvez-vous nous raconter ce qui s'est passé ? J'aimerais beaucoup savoir !");
                s = s.Replace("...Very well.\r\nIf it interests you.", "...Très bien. Si cela vous intéresse.");
                s = s.Replace("(It does...strangely.)", "(Bizarrement... oui, ça m'intéresse.)");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#11"] = (en) => {
                string s = en;
                s = s.Replace("By the way, Lord Stronghart, about this...", "À propos, Lord Harry Caine, regardez ceci...");
                s = s.Replace("The symbol of a defence lawyer in the Japanese judiciary.", "L'insigne d'avocat de la défense du système judiciaire japonais.");
                s = s.Replace("Oh!\r\nI, I didn't expect you'd know that.", "Oh ! J-Je ne m'attendais pas à ce que vous le sachiez.");
                s = s.Replace("We never accept foreign students before first researching\r\nthe legal systems of their home countries.\r\n...But such trinkets are merely for show. The only true\r\nmeasure of your worth is your performance in court.", "Nous n'acceptons jamais d'étudiants étrangers sans avoir au préalable étudié le système judiciaire de leur pays d'origine. ...Mais ces babioles ne sont que de la parade. La seule véritable mesure de votre valeur réside dans vos plaidoiries au tribunal.");
                s = s.Replace("Yes. Right...", "Oui. C'est vrai...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_00_eng#12"] = (en) => {
                string s = en;
                s = s.Replace("...Another to fall foul of the Reaper's curse.", "...Une autre victime de la malédiction du Faucheur.");
                s = s.Replace("What?", "Quoi ?");
                s = s.Replace("Odie Asman...\r\nThe ink was barely dry on the man's acquittal papers.\r\nHe'd just emerged from a trial in which he was being\r\nprosecuted...at the hand of Lord van Zieks.", "Odoril Asman... L'encre de son jugement d'acquittement était à peine sèche. Il sortait tout juste d'un procès où il avait été poursuivi... par Lord Van Peers.");
                s = s.Replace("Do you think the verdict was wrong?", "Pensez-vous que le verdict était erroné ?");
                s = s.Replace("The law is final. Verdicts are final.\r\nHowever, as long as mere mortals are the ones making\r\nthe decisions...there is always room for error.\r\nThe influence of large criminal organisations is sometimes\r\nfelt even in our highest courtrooms.", "La loi est souveraine. Les jugements sont irrévocables. Toutefois, tant que de simples mortels rendent les décisions... l'erreur reste toujours possible. L'influence de puissants syndicats du crime se fait parfois ressentir jusque dans nos plus hauts tribunaux.");
                s = s.Replace("That would be the dark and devilish side to London, I\r\nsuppose?", "C'est sans doute le côté sombre et démoniaque de Londres, j'imagine ?");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_01_eng#1"] = (en) => {
                string s = en;
                s = s.Replace("What exactly is the Forensic Investigation Team that you\r\nmentioned before?", "Qu'est-ce que cette brigade de police scientifique que vous avez mentionnée tout à l'heure ?");
                s = s.Replace("The British Empire's police force must become the \r\nmost exemplary in the world.", "La police de l'Empire britannique se doit de devenir la plus exemplaire au monde.");
                s = s.Replace("For that to happen, it's imperative that we embrace\r\nforensic science and everything it has to offer.", "Pour cela, il est impératif d'adopter la médecine légale et toutes les avancées scientifiques.");
                s = s.Replace("I first created the Forensic Investigation Team a year ago\r\nnow – unofficially of course – to pave the way.", "J'ai créé cette brigade de police scientifique il y a un an – à titre officieux bien sûr – pour ouvrir la voie.");
                s = s.Replace("Goodness! A year ago?", "Ciel ! Il y a un an ?");
                s = s.Replace("At next month's symposium, I intend to present the results\r\nof their work to the world.", "Lors du symposium le mois prochain, j'entends présenter les fruits de leurs travaux au monde entier.");
                s = s.Replace("Once I do that, the House of Lords will be powerless to\r\noppose the creation of a full-scale forensics division.", "Dès lors, la Chambre des Lords ne pourra plus s'opposer à la création d'une véritable division scientifique.");
                s = s.Replace("And once that happens, the position of Attorney General\r\nwill be mine...and criminals will suffer dearly.", "Et une fois cela fait, le poste de procureur général m'appartiendra... et les criminels payeront le prix fort.");
                s = s.Replace("What do you mean?", "Que voulez-vous dire ?");
                s = s.Replace("For too long, those scoundrels have made a mockery of\r\nour legal system with false evidence and bribes.\r\nBut London's scum is about to be rounded up and burnt in\r\nthe fires of Hell.", "Pendant trop longtemps, ces scélérats ont bafoué notre justice à coups de faux témoignages et de pots-de-vin. Mais la racaille de Londres est sur le point d'être traquée et consumée dans les flammes de l'enfer.");
                s = s.Replace("I intend to see to it personally.\r\nBy creating the finest police force the world has ever\r\nknown! To protect our honour...and our future!", "J'y veillerai en personne. En bâtissant la police la plus remarquable que la terre ait jamais portée ! Pour notre honneur... et pour notre avenir !");
                s = s.Replace("(Look at those eyes...\r\nHe means every word.)", "(Regardez cette lueur dans ses yeux... Il est habité par ses paroles.)");
                s = s.Replace("Doctor Sithe is an extremely reliable coroner.\r\nWhen I officially establish the forensics division at\r\nScotland Yard...\r\n...she will run it as my right-hand woman.", "Le docteur Cyriella Pétrie est une légiste d'une fiabilité absolue. Quand j'aurai officialisé la création de la division scientifique à Scotland Yard... c'est elle qui la dirigera en tant que mon bras droit.");
                s = s.Replace("Now then...speaking of the symposium, Miss Mikotoba...", "Bien... et pour en revenir au symposium, Mademoiselle Mikotoba...");
                s = s.Replace("Oh! Yes, My Lord?", "Oh ! Oui, Votre Seigneurie ?");
                s = s.Replace("Your father should be on the high seas as we speak,\r\nmaking his way here to represent the Empire of Japan.", "Votre père doit naviguer en haute mer à l'heure où nous parlons, faisant route pour représenter l'Empire du Japon.");
                s = s.Replace("Yes, that's right. I understand he will arrive at the\r\nbeginning of next month.", "Oui, c'est exact. Il devrait arriver au début du mois prochain.");
                s = s.Replace("Are you acquainted, Lord Stronghart?\r\nWith Professor Mikotoba, I mean.", "Faites-vous sa connaissance, Lord Harry Caine ? Avec le professeur Mikotoba, je veux dire.");
                s = s.Replace("It was many years ago now, but yes...I remember\r\nDr Mikotoba very well.", "C'était il y a de nombreuses années, mais oui... Je me souviens fort bien du docteur Mikotoba.");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_01_eng#2"] = (en) => {
                string s = en;
                s = s.Replace("If my memory serves, it was some fifteen years ago now\r\nthat your father came to Britain as a visiting student.", "Si ma mémoire est bonne, c'était il y a une quinzaine d'années que votre père est venu étudier en Grande-Bretagne.");
                s = s.Replace("It was the year I was born.\r\nSo yes, sixteen years ago in fact.", "C'était l'année de ma naissance. Donc oui, il y a seize ans en fait.");
                s = s.Replace("Mikotoba was a young practitioner of forensic science.\r\nAnd Jigoku accompanied him as a young, promising judge.\r\nThe punctiliousness and politeness of the Japanese at the\r\ntime impressed us greatly.\r\nNot that I wish to imply impoliteness or carelessness on\r\nyour part in any way.", "Mikotoba était un jeune adepte de médecine légale. Et Jigoku l'accompagnait en qualité de jeune juge très prometteur. La rigueur et la courtoisie des Japonais à cette époque nous avaient grandement impressionnés. Non pas que je veuille sous-entendre un quelconque manque d'égards de votre part.");
                s = s.Replace("...I didn't think that you were.", "...Je ne le pensais pas non plus.");
                s = s.Replace("Dr Mikotoba studied forensics at one of London's large\r\nhospitals.\r\nSt Synner's, if I'm not mistaken.\r\nDr Sithe was also there then, as it happens.", "Le Dr Mikotoba étudiait la médecine légale dans l'un des grands hôpitaux de Londres. À Sainte-Cène, si je ne m'abuse. Le Dr Pétrie s'y trouvait également à l'époque.");
                s = s.Replace("Then, Dr Sithe knows my father, does she?", "Dans ce cas, le Dr Pétrie connaît mon père ?");
                s = s.Replace("She was a young medical assistant at the time, so I doubt\r\ntheir paths crossed regularly.\r\nBut I've no doubt they knew each other superficially.\r\nAfter all, Dr Mikotoba was here studying his subject for\r\nsome six years in total.", "Elle n'était alors qu'une jeune assistante médicale, je doute que leurs chemins se soient souvent croisés. Mais ils se connaissaient de vue sans nul doute. Après tout, le Dr Mikotoba a étudié ici pendant près de six ans au total.");
                s = s.Replace("Six years... That's a long time to be studying abroad, isn't\r\nit?", "Six ans... C'est un bien long séjour d'études à l'étranger, n'est-ce pas ?");
                s = s.Replace("I lived with my grandmother in those years.", "J'ai vécu chez ma grand-mère durant toutes ces années.");
                s = s.Replace("(So he left his newly born daughter behind and went\r\noverseas for six whole years...?)", "(Il a donc laissé sa fille qui venait de naître pour partir à l'étranger durant six années entières...?)");
                s = s.Replace("It was a rather turbulent time at home...", "C'était une période assez tourmentée au pays...");
                return s;
            };

            entryTranslators[@"BB\script\output\_sce02_chr103_01_eng#3"] = (en) => {
                string s = en;
                s = s.Replace("It was a rather turbulent time at home...", "C'était une période assez tourmentée au pays...");
                return s;
            };

        }
    }
}
