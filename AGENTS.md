# Règles du projet DGS-FR

Ce dépôt maintient la traduction française PC Steam de *The Great Ace Attorney Chronicles* (`DGS1 = GO`, `DGS2 = BB`).

## 1. Architecture binaire double couche et doublons
- Le jeu patché cible (`D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\`) comporte **deux couches** de texte :
  1. **18 archives `.arc`** contenant des `.gmd` (`dgs_lib.GMD_BEARING_ARCS` sous `archive/`) ;
  2. **69 fichiers `.gmd` loose** (sous `GO/script/output/`, `BB/script/output/`, `GO/msg/`, `BB/msg/`, etc.).
- Un même `gmd_key` peut exister simultanément en `.gmd` loose et dans plusieurs `.arc` (ex. `_macro00..04_eng`, `msgCommon/UI_eng`, `_sce04_c100_0000_eng`).
- **Règle stricte** : toute modification doit s'appliquer à **tous les exemplaires** d'un `gmd_key` (`sync_duplicates=True`). Ne jamais modifier un seul `.arc` ou un seul `.gmd` isolément.

## 2. API binaire unique (`tools/dgs_lib.py`)
- Tous les scripts lisant, modifiant ou auditant le jeu **doivent** importer [tools/dgs_lib.py](tools/dgs_lib.py) (`parse_arc`, `build_arc`, `parse_gmd`, `build_gmd`, `iter_game_gmds`, `apply_updates_to_game`, `apply_transform_to_all`, `decode_capcom_rt`).
- Ne jamais réimplémenter de parseur `.arc`/`.gmd` ou de décodeur furigana dans des scripts ponctuels.
- Préserver la gestion du cas `ssz == 0` dans `parse_gmd()` (6 fichiers `.gmd` système sans table de chaînes).

## 3. Glossaire et typographie figés
- **Le Faucheur** (`le Faucheur d'Old Bailey`, `du Faucheur`, `au Faucheur`) — jamais *Dieu de la mort*.
- **Le Ruban moucheté** (`ruban moucheté`) — jamais *bande mouchetée* ni *câble moucheté*.
- **London** — conserver *London* sans jamais le traduire en *Londres* ni l'annoter dans `<RUBY>`.
- **Noms et honorifiques** : `Yûno`, `Hikari`, `Amimo`, `Kiyô`, `Sôsséki`, `Mr/Mrs/Miss/Lord`, `-sama/-san`, `chômiryô`, `koban`.
- **Balises et ponctuation** :
  - Toujours séparer un mot des balises `<E507 ...>` / `<E516 ...>` adjacentes (`cette <E516 56>banquette`, `qu'un <E516 56>kimono`, `la <E507 a b>Crystal Tower`, `toute <E516 231>l'Europe<E519>.`).
  - Supprimer tout `<RUBY><RT>` contenant de l'anglais résiduel non intentionnel (ex. `the big chance`, `waiter`, `seats`) ou un `<RT>` vide.
  - Décoder les caractères pleine largeur Capcom (`\uff01-\uff5e` et `dgs_lib.CAPCOM_CHAR_MAP`) via `decode_capcom_rt()`, et inclure les diacritiques (`[a-zA-ZÀ-ÿ]+`) dans les regex pour préserver `Aï` et les mots accentués.

## 4. Workflow « retour capture d'écran » (index-first)
- Avant de parcourir les archives sur disque, rechercher l'extrait dans l'index local (< 0,2 s) :
  ```powershell
  python tools/build_text_index.py --find "<extrait>"
  ```
- Si `analyse/cache/text_index.json` est absent ou périmé, lancer `python tools/build_text_index.py`.
- Vérifier systématiquement tous les doublons (`.arc` + `.gmd` loose), corriger via `apply_updates_to_game(..., sync_duplicates=True)` ou `tools/apply_step1_fixes.py`, puis ajouter une règle de non-régression dans `dgs_lib.find_editorial_regressions()` / `apply_step1_fixes.py`.

## 5. Vérification bloquante avant build (`verify_all.py`)
- Exécuter `python tools/verify_all.py` (< 10 s) avant toute génération de patch.
- Sont **bloquants** :
  - invalidité binaire `.arc`/`.gmd` ou UTF-8 ;
  - différence du nombre de chaînes vs `D:\The Great Ace Attorney Chronicles Non patché` ;
  - déséquilibre `<RUBY>` / `<RB>` / `<RT>` ;
  - régressions éditoriales critiques ou divergence entre doublons ;
  - **ratchet zéro anglais** sur les 7 archives terminées (`GO/sce00..04_eng.arc`, `BB/sce00..01_eng.arc`).
- La progression de traduction restante (DGS2 Ép. 3–5 et DLC) est mesurée par `python tools/audit_english.py`, qui régénère `analyse/rapports/00_synthese.md` et `analyse/backlog/step3_remaining_targets.json`.

## 6. Releases Steam, CI Switch/3DS figée et notes de version
- La génération d'une release Steam passe par :
  ```powershell
  python tools/release_steam.py --version X.Y.Z
  ```
  (`verify_all.py` -> mise à jour version dans `tools/build_steam_aapatch.py` et `README.md` -> build `patch_steam.aapatch` -> découpage `< 100 MiB`).
- Ne jamais exécuter `git commit`, `git tag` ou `git push` sans accord explicite de l'utilisateur.
- Le workflow Switch/3DS (`.github/workflows/build.yml`) est **figé en `v1.1.1`** et ne doit pas être modifié pour les releases Steam.
- `RELEASE_NOTES.md` : incrémenter la version mineure à chaque livraison, rédiger des notes courtes et incrémentales (sans répéter les versions antérieures).

## 7. Hygiène du dépôt et shell Windows
- PowerShell 5.1 refuse `&&` (utiliser `;`) et altère les guillemets dans `-c "..."` (utiliser `@' ... '@ | python -` ou un script dédié).
- Tout script Python écrit pour le projet doit configurer `sys.stdout.reconfigure(encoding="utf-8")`.
- Ne jamais laisser de scripts temporaires, captures ou dumps texte à la racine du dépôt ou dans `tools/`. Les anciens outils C#/PS1 sont archivés dans `tools/legacy_cs/`.
