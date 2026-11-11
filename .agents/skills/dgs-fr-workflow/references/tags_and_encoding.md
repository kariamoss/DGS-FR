# Formats binaires, balises et encodage Capcom

## 1. Conteneurs `.arc` et `.gmd`
- **ARC (`ARC\x00`)** : en-tête `<HH` (`version`, `count`), table d'entrées de `144` octets (`128` octets de nom ASCII + `<IIII` pour `type_hash`, `csz`, `usz`, `file_off`). Les entrées avec `csz > 6` sont compressées en zlib brut sans en-tête (`decomp = zlib.decompress(comp[2:-4], -15)`). Les données commencent à partir de `first_data_offset >= 0x8000` (aligné à `0x8000`).
- **GMD (`GMD\x00`)** : la taille du bloc de chaînes `ssz` est stockée en `<I` à l'offset `32` (`len(gmd_bytes) >= 40`, `str_start = len(gmd_bytes) - ssz`).
- **Piège `ssz == 0`** : plusieurs `.gmd` système ont une table de chaînes vide (`ssz == 0`, `raw_strings = []`). Ne jamais faire `b"".split(b"\x00")` qui produirait une fausse chaîne vide `[""]` ; `dgs_lib.parse_gmd()` retourne `strings = []`.
- Toujours reconstruire via `dgs_lib.build_gmd()` et `dgs_lib.build_arc()`, sans jamais modifier le nombre de chaînes vs le jeu original ni introduire d'octet nul `\x00` dans une chaîne.

## 2. Balises de texte et furigana (`<RUBY>`)
- **`<PAGE>`** : délimite les boîtes/pages affichées à l'écran. L'audit `audit_english.py` et le ratchet `verify_all.py` évaluent le texte **par `<PAGE>`**.
- **`<RUBY><RB>...</RB><RT>...</RT></RUBY>`** : annotation au-dessus du texte (`RB` = base, `RT` = texte au-dessus, parfois entouré de `<COL ...>...</COL>`).
  - Les balises `<RUBY>` doivent être équilibrées (`<RUBY>`, `</RUBY>`, `<RB>`, `</RB>`, `<RT>`, `</RT>`).
  - Un `<RUBY>` peut contenir des sauts de ligne : toujours utiliser `re.DOTALL`.
  - L'encodage `<RT>` utilise souvent des caractères pleine largeur (`U+FF01`..`U+FF5E`, décalage `-0xFEE0`), espace idéographique `U+3000`, ainsi que des points de code Capcom étendus mappés par `dgs_lib.CAPCOM_CHAR_MAP` :
    - `0xFFA9 -> É`, `0xFFB4 -> Ô`, `0xFFC0 -> à`, `0xFFC2 -> â`, `0xFFC7 -> ç`, `0xFFC8 -> è`, `0xFFC9 -> é`, `0xFFCA -> ê`, `0xFFCE -> î`, `0xFFCF -> ï`, `0xFFD4 -> ô`, `0xFFDB -> û`.
  - Toujours décoder avec `dgs_lib.decode_capcom_rt()`.

## 3. Balises de couleur / mise en forme (`<E507>`, `<E516>`, `<E519>`)
- Les couleurs et styles sont encadrés par `<E507 ...>texte<E519>` ou `<E516 ...>texte<E519>`.
- **Règles d'espacement obligatoires** :
  - Toujours laisser une espace entre un mot et la balise ouvrante qui suit (`cette <E516 56>banquette`, `qu'un <E516 56>kimono`, `la <E507 a b>Crystal Tower`), et après `<E519>` suivi d'un mot ;
  - Éviter toute espace superflue avant `,` ou `.` après `<E519>` (ex. corriger `toute <E516 231>l'Europe<E519> .` et `de Saô ,`).
  - Attention : `<E519> !` et `<E519> ?` avec espace insécable/normale sont valides en français.
- **Regex et diacritiques** : utiliser `[a-zA-ZÀ-ÿ]+` pour ne pas scinder les mots accentués (sinon `Aï` est découpé en `'a'` + isolé et génère des faux positifs).
