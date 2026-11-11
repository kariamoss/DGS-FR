"""Unified editorial, glossary, ruby, and spacing patcher across ALL .arc and loose .gmd files.

Uses tools/dgs_lib.py so every fix is applied identically to all 18 GMD-bearing .arc
archives, all 69 loose .gmd files, and all duplicate groups.
"""

from __future__ import annotations

import argparse
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8")
sys.path.insert(0, str(Path(__file__).resolve().parent))
import dgs_lib

# Known book / case titles inside <RUBY> tags
TITLE_MAP: dict[str, str] = {
    "the speckled band": "« Le Ruban moucheté »",
    "the hound of the baskervilles": "« Le Chien des Baskerville »",
    "a study in scarlet": "« Une étude en rouge »",
    "the beryl coronet": "« Le Diadème de béryls »",
    "the boscombe valley mystery": "« Le Mystère du Val Boscombe »",
    "the adventure of the lion's mane": "« L'Aventure de la crinière du lion »",
    "the portrait of mr lecoq": "Portrait de Monsieur Lecoq",
    "the canterbury tales": "Les Contes de Canterbury",
    "gaboriau and the sea": "Gaboriau et la mer",
}

_ENG_RB_WORDS = frozenset(
    {"the", "to", "of", "in", "and", "with", "for", "at", "from", "a", "by", "just", "that"}
)
_ENG_RT_INDICATORS = frozenset({
    "the", "a", "an", "to", "of", "in", "and", "with", "for", "at", "from", "by",
    "big", "chance", "seat", "seats", "coach", "coachman", "derby", "smoke", "lock",
    "young", "lady", "horse", "very", "strange", "rules", "rule",
})


def transform_ruby(match: re.Match[str]) -> str:
    full = match.group(0)
    rb = match.group(1)
    rt = match.group(2)

    rb_clean = dgs_lib.TAG_RE.sub("", rb).strip()
    rt_clean = dgs_lib.decode_capcom_rt(rt)
    rb_lower = rb_clean.lower()

    # 1. London with any ruby -> pure London
    if rb_lower == "london":
        return "London"
    if rb_lower == "london police":
        return "police de London"

    # 2. Known book titles
    if rb_lower in TITLE_MAP:
        return TITLE_MAP[rb_lower]

    # 3. Honédé Rika special phrases
    if "je suis waiter" in rb_lower:
        return "Je suis serveur"
    if "j'étais in the kitchen" in rb_lower or "j'etais in the kitchen" in rb_lower:
        return "J'étais dans les cuisines"
    if rb_lower == "waiter":
        if "hé" in rt_clean.lower() or "garçon" in rt_clean.lower():
            return "Garçon"
        return "serveur"
    if rb_lower == "handbag":
        return "sac à main"

    # 4. English phrases in RB with French in RT
    words = set(rb_lower.split())
    if words & _ENG_RB_WORDS and rb_lower not in {"lord", "old bailey"}:
        if rt_clean:
            lead = " " if rb.startswith(" ") else ""
            trail = " " if rb.endswith(" ") else ""
            return lead + rt_clean + trail

    # 5. French text in RB with accidental English furigana in RT -> keep French RB
    rt_words = set(re.findall(r"[a-zA-ZÀ-ÿ]+", rt_clean.lower()))
    if (
        rt_words & _ENG_RT_INDICATORS
        and rb_lower not in dgs_lib.INTENTIONAL_FR_TO_EN_RB
        and not any(p in rt_clean.lower() for p in dgs_lib.INTENTIONAL_EN_RT_PHRASES)
    ):
        return rb

    return full


def patch_string_content(gmd_key: str, _idx: int, text: str) -> str:
    # 0. Repair known malformed / unbalanced <RUBY> tags caught by verify_all
    text = text.replace(
        '"Une heure<E003 4></RB><RT><COL f9e041ff></COL></RT></RUBY> et trente-cinq',
        '"Une heure<E003 4> et trente-cinq',
    )
    text = text.replace(
        "<RUBY><RB>Diligence</RB><RT><COL 54563C>   </COL></RT><RUBY>",
        "Diligence",
    )
    text = text.replace(
        "<E507 蝋燭 ろうそく><E507 蝋燭 ろうそく><RUBY><RB><RUBY><RB></RB><RT><COL 1b0894ff>ｂｏｕｇｉｅ</COL></RT></RUBY><E519>",
        "<E507 蝋燭 ろうそく><RUBY><RB>蝋燭</RB><RT><COL 1b0894ff>ｂｏｕｇｉｅ</COL></RT></RUBY><E519>",
    )
    text = text.replace("<RUBY><RB>Homme masqué<BLCT></BLCT>", "Homme masqué<BLCT></BLCT>")
    text = text.replace(
        "<RUBY><RB>依弟喪</RB><RT><COL 1b0894ff>Édémo</COL></RT>    <RB>似焼</RB><RT><COL 1b0894ff>Niyaku</COL></RT><BLCT></BLCT>",
        "<RUBY><RB>依弟喪</RB><RT><COL 1b0894ff>Édémo</COL></RT>    <RB>似焼</RB><RT><COL 1b0894ff>Niyaku</COL></RT></RUBY><BLCT></BLCT>",
    )
    text = text.replace(
        "<E507 a b>Cherchez parmi les sentiers vos chemins sereins.<E519><E507 a b><RUBY><E519>",
        "<E507 a b>Cherchez parmi les sentiers vos chemins sereins.<E519>",
    )

    # 1. Transform rubies
    text = dgs_lib.RUBY_RE.sub(transform_ruby, text)

    # 2. Harmonize 'Dieu de la Mort' -> 'Faucheur' (preserve case & spacing)
    text = re.sub(r"\ble\s{2,}(<E516\s+\d+>)", r"le \1", text)
    text = re.sub(r"qui hante le tribunal de Old Bailey", "qui hante le tribunal d'Old Bailey", text)
    text = re.sub(r"\bdu tribunal de Old Bailey", "du tribunal d'Old Bailey", text)
    text = re.sub(r"\btribunal de Old Bailey", "tribunal d'Old Bailey", text)

    text = text.replace('"Dieu de la Mort"? Comme un shinigami', '« Faucheur » ? Comme un shinigami')
    text = text.replace('"Dieu de la Mort" ? Comme un shinigami', '« Faucheur » ? Comme un shinigami')
    text = text.replace(
        '"le Dieu de\r\n<E042><CNTR>la Mort du <E042><CNTR><E516 54>tribunal d\'Old Bailey"',
        '"le Faucheur\r\n<E042><CNTR>du <E042><CNTR><E516 54>tribunal d\'Old Bailey"',
    )

    text = re.sub(r"\bdu\s+Dieu\s+de\s+la\s+Mort\b", "du Faucheur", text, flags=re.IGNORECASE)
    text = re.sub(r"\bau\s+Dieu\s+de\s+la\s+Mort\b", "au Faucheur", text, flags=re.IGNORECASE)
    text = re.sub(r"\bce\s+Dieu\s+de\s+la\s+Mort\b", "ce Faucheur", text, flags=re.IGNORECASE)
    text = re.sub(r"\bun\s+Dieu\s+de\s+la\s+Mort\b", "un Faucheur", text)
    text = re.sub(r"\bun\s+dieu\s+de\s+la\s+mort\b", "un faucheur", text)
    text = re.sub(r"\bLe\s+Dieu\s+de\s+la\s+Mort\b", "Le Faucheur", text)
    text = re.sub(r"\ble\s+Dieu\s+de\s+la\s+Mort\b", "le Faucheur", text)
    text = re.sub(r'["«]\s*Dieu\s+de\s+la\s+Mort\s*["»]', "« Faucheur »", text, flags=re.IGNORECASE)
    text = re.sub(r"\bDieu\s+de\s+la\s+Mort\b", "Faucheur", text)
    text = re.sub(r"\bdieu\s+de\s+la\s+mort\b", "faucheur", text)

    # 3. Harmonize 'Bande mouchetée' -> 'Ruban moucheté' (supports CRLF / quotes / inline tags)
    text = text.replace("L'aventure de l'incassable bande mouchetée", "L'aventure de l'incassable ruban moucheté")
    text = text.replace("l'incassable bande mouchetée", "l'incassable ruban moucheté")
    text = text.replace(
        'la mystérieuse\r\n"<E516 33>bande<E519> mouchetée"',
        'le mystérieux\r\n"<E516 33>ruban<E519> moucheté"',
    )
    text = text.replace(
        "Une bande<E025 6>... <E003 8><E025 3><E516 33>mouchetée<E519>",
        "Un ruban<E025 6>... <E003 8><E025 3><E516 33>moucheté<E519>",
    )
    text = text.replace(
        "cette <E338><E341><E006>bande <E516 33> mouchetée<E519>",
        "ce <E338><E341><E006>ruban <E516 33> moucheté<E519>",
    )
    text = text.replace(
        'cette "<E330>bande <E516 33> mouchetée<E519>"',
        'ce "<E330>ruban <E516 33> moucheté<E519>"',
    )
    text = text.replace(
        'de "La <E516 33>bande<E519> mouchetée"',
        'de "Le <E516 33>Ruban<E519> moucheté"',
    )
    text = re.sub(r"\bcette(\s+)bande(\s+)mouchetée", r"ce\1ruban\2moucheté", text, flags=re.IGNORECASE)
    text = re.sub(r"\bune(\s+[\"«]?\s*)bande(\s+)mouchetée", r"un\1ruban\2moucheté", text, flags=re.IGNORECASE)
    text = re.sub(r"\bLa(\s+)Bande(\s+)Mouchetée\b", r"Le\1Ruban\2moucheté", text)
    text = re.sub(r"\bla(\s+)bande(\s+)mouchetée\b", r"le\1ruban\2moucheté", text, flags=re.IGNORECASE)
    text = re.sub(r'(["«])bande(\s+)mouchetée(["»])', r"\1ruban\2moucheté\3", text)
    text = re.sub(r"\bc[âa]ble(\s+)moucheté\b", r"ruban\1moucheté", text, flags=re.IGNORECASE)

    # 4. Typographical fixes
    text = text.replace("mais viennent de toute<E516 231>l'Europe<E519> .", "mais viennent de toute <E516 231>l'Europe<E519>.")
    text = text.replace("toute<E516 231>l'Europe<E519> .", "toute <E516 231>l'Europe<E519>.")
    text = text.replace("de toutel'Europe .", "de toute l'Europe.")
    text = text.replace("<E516 216>France<E519> ,", "<E516 216>France<E519>,")
    text = text.replace("<E516 137>Allemagne<E519> ,", "<E516 137>Allemagne<E519>,")
    text = text.replace("<E516 232>Espagne<E519> ,", "<E516 232>Espagne<E519>,")
    text = text.replace("<E516 23>russe<E519> .", "<E516 23>russe<E519>.")
    text = text.replace("de Saô ,", "de Sôseki,")

    # 5. Formatting tag spacing
    text = text.replace("la<E507 a b>Crystal Tower", "la <E507 a b>Crystal Tower")
    text = text.replace("cette<E516 56>banquette", "cette <E516 56>banquette")
    text = text.replace("qu'un<E516 56>kimono", "qu'un <E516 56>kimono")
    text = re.sub(r"\b([a-zA-ZÀ-ÿ]{2,})(<E5[01][67][^>]*>)", r"\1 \2", text)
    text = re.sub(r"(<E519>)([a-zA-ZÀ-ÿ]{2,})", r"\1 \2", text)

    # 6. Blank RT rubies
    text = re.sub(
        r"<RUBY><RB>(.*?)</RB><RT>\s*(?:<COL[^>]*>)?\s*(?:</COL>)?\s*</RT></RUBY>",
        r"\1",
        text,
        flags=re.DOTALL,
    )

    # 7. Double ruby for London World Fair + remaining London harmonization
    text = re.sub(
        r"<E516 211><RUBY><RB>\s*pour la London\s*</RB><RT>.*?</RT></RUBY><E519>\s*"
        r"<E516 160><RUBY><RB>\s*World Fair\s*</RB><RT>.*?</RT></RUBY><E519>",
        "pour l'Exposition Universelle de London",
        text,
        flags=re.DOTALL,
    )
    text = text.replace("dans Londres", "dans London")
    text = text.replace("surnomme <E003 8><E516 211>Londres", "surnomme <E003 8><E516 211>London")
    text = text.replace("surnomme Londres", "surnomme London")

    return text


def main() -> None:
    parser = argparse.ArgumentParser(description="Apply unified Step 1 fixes to ARC + loose GMDs.")
    parser.add_argument("--fr-dir", type=Path, default=dgs_lib.DEFAULT_FR_DIR)
    parser.add_argument("--dry-run", action="store_true")
    args = parser.parse_args()

    print(f"Applying Step 1 editorial/ruby fixes ({'DRY-RUN' if args.dry_run else 'LIVE'})...")
    stats = dgs_lib.apply_transform_to_all(args.fr_dir, patch_string_content, dry_run=args.dry_run)
    for target, count in sorted(stats.items()):
        print(f"  {target}: {count} strings")
    print(f"Total containers/keys affected: {len(stats)}")


if __name__ == "__main__":
    main()
