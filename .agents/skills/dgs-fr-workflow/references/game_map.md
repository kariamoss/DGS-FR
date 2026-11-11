# Carte des conteneurs du jeu (`GO` = DGS1, `BB` = DGS2)

Source de vérité : `tools/dgs_lib.py` (`GMD_BEARING_ARCS`, `CONTAINER_GAME_MAP`, `STRICT_ZERO_ENGLISH_ARCS`).

## 1. Les 18 archives `.arc` contenant du texte `.gmd`

| Conteneur (relatif à `nativeDX11x64/archive/`) | Jeu | Contenu / Épisode | Ratchet 0 EN |
|---|---|---|---|
| `GO/sce00_eng.arc` | DGS1 (`GO`) | Épisode 1 — L'aventure du Grand Départ | Oui |
| `GO/sce01_eng.arc` | DGS1 (`GO`) | Épisode 2 — L'incassable ruban moucheté | Oui |
| `GO/sce02_eng.arc` | DGS1 (`GO`) | Épisode 3 — La Chambre close mouvante | Oui |
| `GO/sce03_eng.arc` | DGS1 (`GO`) | Épisode 4 — Mon Kokoro un soir de brume | Oui |
| `GO/sce04_eng.arc` | DGS1 (`GO`) | Épisode 5 — Le Récit indicible | Oui |
| `GO/msg_title_eng.arc` | DGS1 (`GO`) | UI / Lieux / Noms / Preuves / OpDemo | Non |
| `BB/sce00_eng.arc` | DGS2 (`BB`) | Épisode 1 — L'avocat en herbe | Oui |
| `BB/sce01_eng.arc` | DGS2 (`BB`) | Épisode 2 — Carnets de souvenirs de mon Kokoro | Oui |
| `BB/sce02_eng.arc` | DGS2 (`BB`) | Épisode 3 — Le retour de la grande âme égarée | Non |
| `BB/sce03_eng.arc` | DGS2 (`BB`) | Épisode 4 — Karma tordu et dernier coup d'archet | Non |
| `BB/sce04_eng.arc` | DGS2 (`BB`) | Épisode 5 — La détermination de Hikari Yûno | Non |
| `BB/msg_title_eng.arc` | DGS2 (`BB`) | UI / Lieux / Noms / Preuves / OpDemo | Non |
| `msg_cmn_eng.arc` | Commun | UI commune & titres chapitres GO/BB | Non |
| `msg_sys_eng.arc` | Commun | Système, sauvegardes, options, guide, lieux | Non |
| `special_cmn_eng.arc` | Commun | Contenus spéciaux, crédits, galerie, musique | Non |
| `title_launcher_eng.arc` | Commun | Lanceur / Écran titre général | Non |
| `title_select_eng.arc` | Commun | Sélection du jeu DGS1/DGS2 | Non |
| `common/title_select_eng.arc` | Commun | Sélection du jeu (copie `common/`) | Non |

## 2. Les 69 fichiers `.gmd` loose et les doublons
- Répartis directement sous `nativeDX11x64/` (`GO/script/output/*.gmd`, `BB/script/output/*.gmd`, `GO/msg/*.gmd`, `BB/msg/*.gmd`, etc.).
- Certains `gmd_key` existent simultanément en `.arc` et en loose (ou dans plusieurs `.arc`), notamment :
  - `GO/script/output/_macro00..04_eng` ;
  - `BB/script/output/_macro00..04_eng` ;
  - `BB/script/output/_sce04_c100_0000_eng` (`BB/sce00_eng.arc` et `BB/sce04_eng.arc`) ;
  - `msgCommon/UI_eng` (`msg_cmn_eng.arc`, `GO/msg_title_eng.arc`, `BB/msg_title_eng.arc`).
- Toujours laisser `tools/dgs_lib.py` (`sync_duplicates=True`) mettre à jour toutes les copies en parallèle ; `tools/verify_all.py` bloque sur toute divergence (`[SYNC]`).
