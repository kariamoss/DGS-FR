# The Chronicles of Ace Attorney: A Great Era — Édition Complète

[![Fork](https://img.shields.io/badge/fork-kariamoss%2FDGS--FR-blue.svg)](https://github.com/kariamoss/DGS-FR)
[![Version](https://img.shields.io/badge/version-2.0.1--complète-green.svg)](https://github.com/kariamoss/DGS-FR/releases)
[![Français](https://img.shields.io/badge/langue-100%25%20Fran%C3%A7ais-brightgreen.svg)](#contenu-du-patch)

Patch de fan-traduction française intégrale pour **The Great Ace Attorney Chronicles** (*Dai Gyakuten Saiban 1 & 2*).

> [!NOTE]
> **À propos de ce dépôt** : Ce projet est un fork étendu du patch originel réalisé par l'équipe **AAI-fr**.  
> Alors que la fan-traduction initiale s'arrêtait à l'Épisode 2 du second volet, cette version apporte la **traduction pure intégrale à 100 % des Épisodes 3, 4 et 5 de The Great Ace Attorney 2: Resolve**, ainsi qu'une révision et harmonisation globale de l'ensemble des deux jeux.
>
> Pour toute question ou échange sur le projet original, rejoignez [le Discord de l'équipe d'origine](https://discord.gg/bye98cMs8S).

![Titre](titre.png)

---

## Sommaire
- [Contenu du patch](#contenu-du-patch)
  - [The Great Ace Attorney Adventures (DGS1)](#the-great-ace-attorney-adventures-dgs1)
  - [The Great Ace Attorney 2: Resolve (DGS2)](#the-great-ace-attorney-2-resolve-dgs2)
  - [Harmonisation linguistique et immersion](#harmonisation-linguistique-et-immersion)
- [Patcher le jeu](#patcher-le-jeu)
  - [Steam (PC)](#steam-pc)
  - [Nintendo Switch](#nintendo-switch)
  - [Nintendo 3DS](#nintendo-3ds)
- [Doublage](#doublage)
- [Bugs et problèmes connus / résolus](#bugs-et-problèmes-connus--résolus)
- [Crédits](#crédits)

---

## Contenu du patch

### The Great Ace Attorney Adventures (DGS1)
* **Jeu complet 100 % en français** (Affaires 1 à 5).
* DLCs et Contenu Spécial entièrement traduits.
* **Revue et harmonisation globale** :
  * Harmonisation stricte du titre officiel du procureur : **« Le Faucheur d'Old Bailey »** (élimination des incohérences grammaticales).
  * Adoption du titre canonique français d'Arthur Conan Doyle : **« Le Ruban moucheté »**.
  * Relecture générale, fluidification des répliques, élimination des anachronismes et d'anglicismes résiduels.

### The Great Ace Attorney 2: Resolve (DGS2)
* **Jeu complet 100 % en français (Affaires 1 à 5 — Intégrale terminée !)**
  * **Affaires 1 & 2** : Relecture minutieuse, ajustement des intonations, correction de formulations qui pouvaient induire en erreur et rétablissement d'éléments cruciaux pour la logique des déductions.
  * **Affaire 3 — NOUVEAU** :
    * Traduction intégrale en français.
    * Correction d'une anomalie du patch d'origine où des dialogues de tribunal apparaissaient en japonais non sous-titré.
  * **Affaire 4 — NOUVEAU** : Traduction intégrale en français (enquête et procès).
  * **Affaire 5 — NOUVEAU** : Traduction intégrale en français menant l'aventure jusqu'à son dénouement final.
* Contenu spécial et galeries 100 % traduits.

### Harmonisation linguistique et immersion
Pour une fidélité optimale à l'ambiance et au contexte historique de l'œuvre :
* **Cadre victorien britannique** : Standardisation soignée des formules de politesse anglaises (`Mr`, `Mrs`, `Miss`, `Lord`) selon les usages de l'époque.
* **Cadre japonais (Ère Meiji)** : Préservation des suffixes honorifiques traditionnels (`-sama`, `-san`) lorsque les personnages japonais s'adressent entre eux, respectant ainsi leurs liens et nuances culturelles.
* **Transcription occidentale naturelle** : Remplacement des caractères kanjis et furiganas par leur transcription phonétique en alphabet latin (`chômiryô`, `Yûno`, `Hikari`, `koban`), pour une lecture limpide et fluide dans la police principale du jeu.
* **Interface & Danse des Déductions** : Correction graphique et grammaticale de l'écran de conclusion de la Danse des Déductions (« Déduction parfaite ») avec typographie harmonisée.

---

## Patcher le jeu

### Steam (PC)
#### Prérequis :
* Le jeu installé via Steam.
* Si vous êtes sur Windows et avez installé le jeu sans choisir un emplacement, il devrait déjà être reconnu par le patcheur.
* Une fois le patch terminé, vous pouvez simplement lancer le jeu, qui sera en français.

### Nintendo Switch
#### Prérequis :
* Une Nintendo Switch hackée.
* Les clefs de déchiffrement du firmware (`prod.keys`).
* Une ROM du jeu (.nsp), que ce soit la version japonaise ou la version internationale.
* Une fois le patch terminé, copiez le dossier `010036e00fb20000` généré dans `atmosphere/contents/` sur votre carte SD (ou `0100d7f00fb1a000` pour la version japonaise).

### Nintendo 3DS
#### Prérequis :
* Une console Nintendo 3DS hackée (Luma3DS).
* Les ROMs japonaises déchiffrées (.3ds ou .cia) des deux jeux.
* Une fois les patchs terminés, installez les fichiers .cia générés avec FBI sur votre carte SD.
* Pour le bon fonctionnement des DLCs sur 3DS, consultez [ce guide](docs/DLC.md).

---

## Doublage

Il n'y a pas de doublage français en jeu, mais nous avons implémenté un doublage dit "immersif", qui utilise les voix japonaises et anglaises selon la situation. La seule exception est quelques interjections dans l'affaire 1 du premier jeu qui sont toujours en anglais à cause de limitations techniques.

---

## Bugs et problèmes connus / résolus

* **Résolu (DGS2 Épisode 3)** : Les dialogues de tribunal qui étaient restés en japonais non sous-titré dans le patch d'origine sont désormais intégralement en français.
* **Résolu (Genre du Faucheur)** : Harmonisation grammaticale masculine complète sur les deux jeux.
* **Résolu (Interface Danse des Déductions)** : Accord grammatical féminin (« Déduction parfaite ») avec graphisme harmonisé.
* **Résolu (Lisibilité des termes japonais)** : Remplacement des kanjis minuscules et furiganas par une translittération occidentale claire et lisible.
* **Steam Deck (Linux)** : Le patcheur fonctionne sous Linux via `patcheur_linux_steam_deck`.

---

## Crédits

### Équipe du projet original (AAI-fr)
* **Chef de projet** : Choky
* **Traduction** : Choky, N0vatique
* **Romhack, programmation, outils** : Aclios, Benji99
* **Graphismes** : Alexane B., Jau, Kikoro, N0vatique, Tolita, Tox, Aclios, Choky
* **Tests et relectures** : Alexandre Ad, Alexane B., Aude-Amélie T., Aurel_Hunty, Joe Monsters, Gunchap, Ned, Alexis TGF, Mellma, Ronano, Aclios, N0vatique, Mondher, Magaster, Hunty, Monkey D Subaru, Octi, Perfect Link
* **Doublage additionnel** : Kirill Morunov
* **Jaquettes et manuels** : Anthiflo, Tolita
* **Remerciements** : Scarlet Study pour les outils et spécifications des formats de Capcom, Ace Attorney Worldwide, Mr.LeoNov.

### Contributions de cette édition intégrale (Fork [kariamoss](https://github.com/kariamoss/DGS-FR))
* **Traduction pure intégrale de DGS2** : Traduction et localisation française complète des Épisodes 3, 4 et 5 (tribunal, enquête, Danse des Déductions, pièces à conviction).
* **Assainissement de l'Épisode 3** : Remplacement des dialogues japonais non traduits par les scripts français.
* **Harmonisation linguistique globale** : Revue des titres et adresses victoriennes en Angleterre, et maintien des honorifiques japonais pour les personnages du Japon.
* **Améliorations qualitatives** : Ajustement des intonations, clarification de formulations ambiguës et rétablissement d'éléments cruciaux pour la logique de progression.
* **Outils & Romhack** : Développement d'un pipeline d'extraction, réinjection et recompilation des archives de jeu.
