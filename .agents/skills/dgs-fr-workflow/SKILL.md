---
name: dgs-fr-workflow
description: Workflow, architecture binaire (.arc/.gmd), outils unifiés et contrôle qualité pour maintenir, auditer et livrer le patch français DGS-FR (Steam).
---

# Skill dgs-fr-workflow

Ce skill décrit les procédures opérationnelles pour diagnostiquer un texte vu en jeu, appliquer une correction sans divergence, auditer l'avancement et assembler une release Steam de *DGS-FR*.

## Références incluses
- [references/game_map.md](references/game_map.md) : correspondance exacte des 18 `.arc` et des 69 `.gmd` loose avec les épisodes de DGS1 (`GO`) et DGS2 (`BB`), ainsi que les 7 archives protégées par le ratchet zéro anglais.
- [references/tags_and_encoding.md](references/tags_and_encoding.md) : format binaire ARC/GMD, balises `<PAGE>`, `<RUBY>`, `<E507>`/`<E516>`/`<E519>` et table `CAPCOM_CHAR_MAP`.

---

## Procédure 1 : Corriger un retour capture d'écran
1. **Localiser instantanément la chaîne (< 0,2 s)** :
   ```powershell
   python tools/build_text_index.py --find "extrait exact ou approximatif"
   ```
   Si `analyse/cache/text_index.json` n'existe pas encore (ou après une grosse passe de traduction), le régénérer avec `python tools/build_text_index.py`.
2. **Inspecter les copies et l'original** :
   - Noter le `gmd_key`, l'index et tous les `containers` retournés (souvent plusieurs `.arc` + un `.gmd` loose).
   - Vérifier la chaîne brute avec un script court importé depuis `tools/dgs_lib.py` (mode `@' ... '@ | python -` sous PowerShell).
3. **Appliquer la correction de façon atomique et synchronisée** :
   - Pour une règle transversale durable (glossaire, `<RUBY>`, espaces autour des balises) : ajouter la règle dans [tools/apply_step1_fixes.py](../../../tools/apply_step1_fixes.py) et la détection associée dans `dgs_lib.find_editorial_regressions()`, puis exécuter `python tools/apply_step1_fixes.py --dry-run` avant le live.
   - Pour une retouche ciblée : appeler `dgs_lib.apply_updates_to_game(fr_dir, {gmd_key: {idx: new_str}}, sync_duplicates=True)`.
4. **Tester et vérifier** :
   - Exécuter `python -m unittest tools/tests/test_dgs_lib.py -v`
   - Exécuter `python tools/verify_all.py` (doit retourner le code `0` avec `Errors: 0`)
   - Régénérer l'index si nécessaire (`python tools/build_text_index.py`).

---

## Procédure 2 : Auditer la progression DGS1 / DGS2 / DLC
```powershell
python tools/audit_english.py
```
- Compare page par page (`<PAGE>`) le dossier patché contre `D:\The Great Ace Attorney Chronicles Non patché`.
- Met à jour :
  - [analyse/rapports/00_synthese.md](../../../analyse/rapports/00_synthese.md) (tableau synthétique suivi dans Git) ;
  - [analyse/backlog/step3_remaining_targets.json](../../../analyse/backlog/step3_remaining_targets.json) (backlog priorisé de toutes les cibles encore en anglais ou avec JP résiduel).

---

## Procédure 3 : Construire une release Steam
1. Vérifier que les tests et la porte d'entrée passent :
   ```powershell
   python -m unittest tools/tests/test_dgs_lib.py -v
   python tools/verify_all.py
   ```
2. Lancer l'orchestrateur avec la nouvelle version mineure incrémentée (ex. `2.0.3`) :
   ```powershell
   python tools/release_steam.py --version 2.0.3
   ```
   Cet outil vérifie l'absence d'erreurs bloquantes, met à jour `tools/build_steam_aapatch.py` et `README.md`, reconstruit `patch_steam.aapatch` (~7–8 min) puis découpe les parties `< 100 MiB`.
3. Mettre à jour [RELEASE_NOTES.md](../../../RELEASE_NOTES.md) avec un bloc court et incrémental (uniquement les changements de la nouvelle version).
4. **Ne jamais faire** de `git commit`, `git tag` ou `git push` sans accord explicite de l'utilisateur. Ne pas modifier `.github/workflows/build.yml` (Switch/3DS figé en `v1.1.1`).
