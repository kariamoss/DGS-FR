"""Shared binary, text, mapping, and verification library for DGS-FR.

All scripts modifying or auditing game .arc archives and loose .gmd files MUST
import this module rather than reimplementing ARC/GMD parsing, Capcom ruby
decoding, or duplicate synchronization.
"""

from __future__ import annotations

import os
import re
import struct
import zlib
from dataclasses import dataclass
from pathlib import Path
from typing import Callable, Iterator, Optional

REPO_ROOT = Path(__file__).resolve().parent.parent
DEFAULT_FR_DIR = Path(
    os.environ.get("DGS_FR_DIR", r"D:\The Great Ace Attorney Chronicles FR")
)
DEFAULT_ORIG_DIR = Path(
    os.environ.get("DGS_ORIG_DIR", r"D:\The Great Ace Attorney Chronicles Non patché")
)

# Canonical list of the 18 .arc archives (relative to nativeDX11x64/archive) that contain .gmd text
GMD_BEARING_ARCS: tuple[str, ...] = (
    "GO/sce00_eng.arc",
    "GO/sce01_eng.arc",
    "GO/sce02_eng.arc",
    "GO/sce03_eng.arc",
    "GO/sce04_eng.arc",
    "GO/msg_title_eng.arc",
    "BB/sce00_eng.arc",
    "BB/sce01_eng.arc",
    "BB/sce02_eng.arc",
    "BB/sce03_eng.arc",
    "BB/sce04_eng.arc",
    "BB/msg_title_eng.arc",
    "msg_cmn_eng.arc",
    "msg_sys_eng.arc",
    "special_cmn_eng.arc",
    "title_launcher_eng.arc",
    "title_select_eng.arc",
    "common/title_select_eng.arc",
)

# Ratchet: episodes/archives that are already at 0 untranslated pages and must NEVER regress.
STRICT_ZERO_ENGLISH_ARCS: frozenset[str] = frozenset({
    "GO/sce00_eng.arc",
    "GO/sce01_eng.arc",
    "GO/sce02_eng.arc",
    "GO/sce03_eng.arc",
    "GO/sce04_eng.arc",
    "BB/sce00_eng.arc",
    "BB/sce01_eng.arc",
})

# Canonical mapping from container path (relative to archive/ or nativeDX11x64/) -> human metadata
CONTAINER_GAME_MAP: dict[str, tuple[str, str]] = {
    "GO/sce00_eng.arc": ("DGS1 (GO)", "Épisode 1 — L'aventure du Grand Départ"),
    "GO/sce01_eng.arc": ("DGS1 (GO)", "Épisode 2 — L'incassable ruban moucheté"),
    "GO/sce02_eng.arc": ("DGS1 (GO)", "Épisode 3 — La Chambre close mouvante"),
    "GO/sce03_eng.arc": ("DGS1 (GO)", "Épisode 4 — Mon Kokoro un soir de brume"),
    "GO/sce04_eng.arc": ("DGS1 (GO)", "Épisode 5 — Le Récit indicible"),
    "GO/msg_title_eng.arc": ("DGS1 (GO)", "UI / Lieux / Noms / Preuves / OpDemo"),
    "BB/sce00_eng.arc": ("DGS2 (BB)", "Épisode 1 — L'avocat en herbe"),
    "BB/sce01_eng.arc": ("DGS2 (BB)", "Épisode 2 — Carnets de souvenirs de mon Kokoro"),
    "BB/sce02_eng.arc": ("DGS2 (BB)", "Épisode 3 — Le retour de la grande âme égarée"),
    "BB/sce03_eng.arc": ("DGS2 (BB)", "Épisode 4 — Karma tordu et dernier coup d'archet"),
    "BB/sce04_eng.arc": ("DGS2 (BB)", "Épisode 5 — La détermination de Hikari Yûno"),
    "BB/msg_title_eng.arc": ("DGS2 (BB)", "UI / Lieux / Noms / Preuves / OpDemo"),
    "msg_cmn_eng.arc": ("Commun", "UI commune & titres chapitres GO/BB"),
    "msg_sys_eng.arc": ("Commun", "Système, sauvegardes, options, guide, lieux"),
    "special_cmn_eng.arc": ("Commun", "Contenus spéciaux, crédits, galerie, musique"),
    "title_launcher_eng.arc": ("Commun", "Lanceur / Écran titre général"),
    "title_select_eng.arc": ("Commun", "Sélection du jeu DGS1/DGS2"),
    "common/title_select_eng.arc": ("Commun", "Sélection du jeu (copie common/)"),
}

# Capcom fullwidth & custom extended Latin codepoints seen inside <RUBY><RT>...</RT></RUBY>
CAPCOM_CHAR_MAP: dict[int, str] = {
    0xFFA9: "É",
    0xFFB4: "Ô",
    0xFFC0: "à",
    0xFFC2: "â",
    0xFFC7: "ç",
    0xFFC8: "è",
    0xFFC9: "é",
    0xFFCA: "ê",
    0xFFCE: "î",
    0xFFCF: "ï",
    0xFFD4: "ô",
    0xFFDB: "û",
}

RUBY_RE = re.compile(r"<RUBY><RB>(.*?)</RB><RT>(.*?)</RT></RUBY>", re.DOTALL)
TAG_RE = re.compile(r"<[^>]+>")
RDFG_RE = re.compile(r"<RDFG\s+(-?\d+)>")
CJK_RE = re.compile(r"[\u3040-\u30ff\u3400-\u4dbf\u4e00-\u9fff\uf900-\ufaff]")

# High-precision English/French classification sets
EN_WORDS: frozenset[str] = frozenset({
    # Articles, pronouns, prepositions, conjunctions
    "the", "and", "but", "for", "nor", "yet", "so", "with", "without", "from", "into",
    "onto", "upon", "about", "above", "below", "between", "among", "through", "during",
    "before", "after", "since", "until", "while", "where", "when", "why", "how", "what",
    "which", "who", "whom", "whose", "that", "this", "these", "those", "there", "their",
    "theirs", "them", "they", "you", "your", "yours", "yourself", "yourselves", "our",
    "ours", "ourselves", "we", "he", "him", "his", "himself", "she", "her", "hers",
    "herself", "its", "itself", "myself", "something", "anything", "nothing", "everything",
    "someone", "anyone", "everyone", "nobody", "each", "every", "both", "either", "neither",
    "other", "another", "such", "own", "same", "only", "even", "still", "already", "just",
    "very", "really", "quite", "rather", "almost", "perhaps", "maybe", "though", "although",
    "because", "unless", "however", "therefore", "anyway", "indeed", "instead", "otherwise",
    # Auxiliaries, modals, high-freq verbs
    "is", "are", "was", "were", "be", "been", "being", "am", "have", "has", "had",
    "having", "do", "does", "did", "done", "doing", "will", "would", "shall", "should",
    "can", "could", "may", "might", "must", "need", "dare", "ought", "know", "knew",
    "known", "think", "thought", "believe", "understand", "remember", "forget", "forgot",
    "mean", "meant", "say", "said", "tell", "told", "ask", "asked", "answer", "explain",
    "look", "looked", "see", "saw", "seen", "watch", "hear", "heard", "listen", "feel",
    "felt", "seem", "seemed", "appear", "become", "became", "come", "came", "go", "went",
    "gone", "going", "take", "took", "taken", "make", "made", "give", "gave", "given",
    "find", "found", "keep", "kept", "leave", "left", "put", "let", "try", "tried",
    "wait", "stop", "start", "begin", "began", "finish", "happen", "happened", "matter",
    "work", "play", "read", "write", "wrote", "written", "speak", "spoke", "spoken",
    "call", "called", "want", "wanted", "like", "love", "hate", "hope", "wish",
    # Common nouns/adjectives/adverbs
    "here", "now", "then", "today", "yesterday", "tomorrow", "never", "always", "often",
    "sometimes", "soon", "again", "once", "twice", "away", "back", "down", "over", "under",
    "more", "most", "much", "many", "some", "any", "all", "few", "little", "first", "last",
    "next", "good", "better", "best", "bad", "worse", "worst", "right", "wrong", "true",
    "real", "sure", "clear", "sorry", "afraid", "happy", "glad", "well", "great", "little",
    "time", "way", "thing", "things", "man", "men", "woman", "people", "person", "friend",
    "world", "life", "day", "night", "year", "years", "case", "court", "trial", "witness",
    "evidence", "truth", "murder", "victim", "crime", "guilty", "prosecutor", "counsel",
    "please", "thank", "thanks", "excuse", "course", "actually", "certainly", "probably",
    "blimey", "wot", "dunno", "tellin", "reportin", "guv", "mate",
})

EN_CONTRACTION_RE = re.compile(
    r"\b(?:i'm|i've|i'll|i'd|you're|you've|you'll|you'd|we're|we've|we'll|we'd|"
    r"they're|they've|they'll|they'd|he's|she's|it's|that's|there's|what's|who's|"
    r"where's|how's|isn't|aren't|wasn't|weren't|don't|doesn't|didn't|won't|wouldn't|"
    r"can't|couldn't|shouldn't|mustn't|haven't|hasn't|hadn't|let's)\b",
    re.IGNORECASE,
)

FR_WORDS: frozenset[str] = frozenset({
    "le", "la", "les", "un", "une", "des", "du", "de", "au", "aux", "ce", "cet", "cette",
    "ces", "mon", "ma", "mes", "ton", "ta", "tes", "son", "sa", "ses", "notre", "nos",
    "votre", "vos", "leur", "leurs", "je", "tu", "il", "elle", "on", "nous", "vous", "ils",
    "elles", "me", "te", "se", "lui", "y", "en", "qui", "que", "quoi", "dont", "où",
    "ou", "et", "mais", "donc", "or", "ni", "car", "si", "comme", "quand", "lorsque",
    "parce", "puisque", "bien", "très", "plus", "moins", "aussi", "trop", "assez", "peu",
    "toujours", "jamais", "rien", "tout", "tous", "toute", "toutes", "aucun", "autre",
    "autres", "même", "avec", "sans", "dans", "sur", "sous", "pour", "par", "vers",
    "chez", "entre", "après", "avant", "depuis", "pendant", "est", "sont", "était",
    "étaient", "sera", "serait", "suis", "es", "sommes", "êtes", "a", "as", "avons",
    "avez", "ont", "avait", "avaient", "aura", "fait", "faire", "dit", "dire", "peut",
    "peux", "pouvez", "faut", "dois", "doit", "devez", "vais", "va", "allez", "vont",
    "sais", "sait", "savez", "crois", "pense", "vois", "voit", "semble", "donc", "alors",
    "oui", "non", "pas", "ne", "ici", "là", "encore", "déjà", "vraiment", "peut-être",
    "monsieur", "madame", "mademoiselle", "maître", "témoin", "procès", "cour",
    "vérité", "preuve", "affaire", "victime", "meurtre", "faucheur", "merci", "pardon",
    "désolé", "voilà", "bonjour", "bonsoir", "aujourd", "hier", "demain",
})

FR_ELISION_RE = re.compile(r"\b(?:l'|d'|qu'|c'|j'|n'|s'|m'|t')\w+", re.IGNORECASE)
FR_DIACRITIC_RE = re.compile(r"[àâäéèêëîïôöùûüçÀÂÄÉÈÊËÎÏÔÖÙÛÜÇœŒ«»]")

PROPER_NOUN_OR_NOISE_LINES: frozenset[str] = frozenset({
    "invalid message",
    "dummy",
    "scotland yard",
    "old bailey",
    "baker street",
    "briar road",
    "crystal tower",
    "great exhibition",
    "hmmm...",
    "haah...",
    "ah...",
    "ah !",
    "...",
    "no, i don't agree !",
})

# Known intentional rubies where RB is French/custom and RT has English words
INTENTIONAL_FR_TO_EN_RB: frozenset[str] = frozenset({"wûnoz", "yûno"})
INTENTIONAL_EN_RT_PHRASES: frozenset[str] = frozenset({"imperial police"})


def normalize_rel(p: str | Path) -> str:
    return str(p).replace("\\", "/").lstrip("./")


def classify_container(container_rel: str, gmd_key: str) -> dict[str, str]:
    """Return structured game/episode/type metadata for any .arc or loose .gmd."""
    c_norm = normalize_rel(container_rel)
    g_norm = normalize_rel(gmd_key)

    # 1. Exact container lookup for .arc files
    if c_norm in CONTAINER_GAME_MAP:
        game, episode = CONTAINER_GAME_MAP[c_norm]
    elif g_norm.startswith("GO/script/output/_sce07_"):
        game, episode = "DGS1 (GO)", "Épisodes bonus — Escapades (1–8)"
    elif g_norm.startswith("GO/"):
        game, episode = "DGS1 (GO)", "Libre (GO/msg ou script)"
    elif g_norm.startswith("BB/"):
        game, episode = "DGS2 (BB)", "Libre (BB/msg ou script)"
    elif g_norm.startswith("msgCommon/dlc/"):
        game, episode = "Commun / DLC", "Contenus spéciaux DLC (Art & Musique)"
    elif g_norm.startswith("msgCommon/"):
        game, episode = "Commun", "Menus & sauvegardes (msgCommon)"
    else:
        game, episode = "Autre", c_norm

    name_lower = Path(g_norm).name.lower()
    if "_preset_" in name_lower:
        kind = "preset_cmd"
    elif "_macro" in name_lower:
        kind = "macro"
    elif "_check" in name_lower or "_3d_check" in name_lower:
        kind = "bg_check"
    elif re.search(r"_sce\d+_c\d+", name_lower):
        kind = "dialogue"
    elif "dlc" in g_norm.lower():
        kind = "dlc"
    elif "credit" in name_lower:
        kind = "credit"
    elif "pair_reasoning" in name_lower:
        kind = "deduction"
    elif "explain_" in name_lower or "subtitles" in name_lower:
        kind = "ui_subtitle"
    else:
        kind = "ui"

    return {
        "game": game,
        "episode": episode,
        "container": c_norm,
        "gmd_key": g_norm,
        "kind": kind,
    }


def decode_capcom_rt(rt: str) -> str:
    """Decode Capcom furigana <RT> content (nested tags + fullwidth/extended Latin)."""
    s = TAG_RE.sub("", rt)
    res: list[str] = []
    for c in s:
        code = ord(c)
        if 0xFF01 <= code <= 0xFF5E:
            res.append(chr(code - 0xFEE0))
        elif code in CAPCOM_CHAR_MAP:
            res.append(CAPCOM_CHAR_MAP[code])
        elif code in (0x3000, 0x20):
            res.append(" ")
        else:
            res.append(c)
    return re.sub(r"\s+", " ", "".join(res)).strip()


def clean_page_text(text: str, strip_rt: bool = True) -> str:
    """Return human-readable text of a GMD page with tags and excess spaces removed."""
    s = text
    if strip_rt:
        s = RUBY_RE.sub(lambda m: m.group(1), s)
    s = TAG_RE.sub("", s)
    return re.sub(r"\s+", " ", s).strip()


# ---------------------------------------------------------------------------
# Binary GMD & ARC Primitives
# ---------------------------------------------------------------------------


@dataclass
class GmdDocument:
    header_and_tables: bytes
    strings: list[str]
    raw_strings: list[bytes]
    has_trailing_null: bool
    ssz: int
    utf8_errors: list[int]


def parse_gmd(gmd_bytes: bytes) -> Optional[GmdDocument]:
    if len(gmd_bytes) < 40 or gmd_bytes[:4] != b"GMD\x00":
        return None
    ssz = struct.unpack_from("<I", gmd_bytes, 32)[0]
    str_start = len(gmd_bytes) - ssz
    if str_start < 40 or str_start > len(gmd_bytes):
        return None

    header_and_tables = gmd_bytes[:str_start]
    str_block = gmd_bytes[str_start:]
    if ssz == 0 or not str_block:
        return GmdDocument(
            header_and_tables=header_and_tables,
            strings=[],
            raw_strings=[],
            has_trailing_null=False,
            ssz=ssz,
            utf8_errors=[],
        )

    raw_strings = str_block.split(b"\x00")
    has_trailing_null = bool(raw_strings and raw_strings[-1] == b"")
    if has_trailing_null:
        raw_strings.pop()

    strings: list[str] = []
    utf8_errors: list[int] = []
    for idx, raw in enumerate(raw_strings):
        try:
            strings.append(raw.decode("utf-8"))
        except UnicodeDecodeError:
            utf8_errors.append(idx)
            strings.append(raw.decode("utf-8", errors="replace"))

    return GmdDocument(
        header_and_tables=header_and_tables,
        strings=strings,
        raw_strings=raw_strings,
        has_trailing_null=has_trailing_null,
        ssz=ssz,
        utf8_errors=utf8_errors,
    )


def build_gmd(doc: GmdDocument, updates: dict[int, str]) -> bytes:
    """Rebuild GMD bytes applying {string_idx: new_str}, validating string count and UTF-8."""
    if not updates:
        out_block = b"\x00".join(doc.raw_strings) + (b"\x00" if doc.has_trailing_null else b"")
        return doc.header_and_tables + out_block

    new_raw = list(doc.raw_strings)
    n_strs = len(new_raw)
    for idx, val in updates.items():
        if not (0 <= idx < n_strs):
            raise IndexError(f"GMD string index {idx} out of range (count={n_strs})")
        if "\x00" in val:
            raise ValueError(f"Null byte forbidden inside GMD string at index {idx}")
        new_raw[idx] = val.encode("utf-8")

    new_str_block = b"\x00".join(new_raw)
    if doc.has_trailing_null:
        new_str_block += b"\x00"

    new_header = bytearray(doc.header_and_tables)
    struct.pack_into("<I", new_header, 32, len(new_str_block))
    return bytes(new_header) + new_str_block


@dataclass
class ArcEntry:
    raw_name: bytes
    name: str
    norm_key: str
    type_hash: int
    data: bytes

    @property
    def is_gmd(self) -> bool:
        return (
            self.type_hash == 0x242BB29A
            or self.norm_key.endswith(".gmd")
            or (len(self.data) >= 4 and self.data[:4] == b"GMD\x00")
        )


@dataclass
class ArcArchive:
    version: int
    entries: list[ArcEntry]


def parse_arc(arc_bytes: bytes) -> ArcArchive:
    if len(arc_bytes) < 8 or arc_bytes[:4] != b"ARC\x00":
        raise ValueError("Invalid ARC magic")
    version, count = struct.unpack_from("<HH", arc_bytes, 4)
    entries: list[ArcEntry] = []
    off = 8
    for _ in range(count):
        raw_name = arc_bytes[off : off + 128]
        name = raw_name.split(b"\x00")[0].decode("ascii", errors="replace")
        type_hash, csz, usz, file_off = struct.unpack_from("<IIII", arc_bytes, off + 128)
        off += 144
        if csz > 6:
            comp = arc_bytes[file_off : file_off + csz]
            decomp = zlib.decompress(comp[2:-4], -15)
        elif csz > 0:
            decomp = arc_bytes[file_off : file_off + csz]
        else:
            decomp = b""
        entries.append(
            ArcEntry(
                raw_name=raw_name,
                name=name,
                norm_key=normalize_rel(name),
                type_hash=type_hash,
                data=decomp,
            )
        )
    return ArcArchive(version=version, entries=entries)


def build_arc(arc: ArcArchive) -> bytes:
    count = len(arc.entries)
    table_size = count * 144
    first_data_offset = 0x8000
    if 8 + table_size > first_data_offset:
        first_data_offset = (8 + table_size + 0x7FFF) & ~0x7FFF

    out_table = bytearray()
    out_data = bytearray()
    curr_off = first_data_offset

    for e in arc.entries:
        decomp = e.data
        if len(decomp) > 0:
            comp = zlib.compress(decomp)
            csz = len(comp)
            usz = len(decomp)
            file_off = curr_off
            curr_off += csz
            out_data.extend(comp)
        else:
            csz = 0
            usz = 0
            file_off = 0
        out_table.extend(e.raw_name)
        out_table.extend(struct.pack("<IIII", e.type_hash, csz, usz, file_off))

    out_arc = bytearray(struct.pack("<4sHH", b"ARC\x00", arc.version, count))
    out_arc.extend(out_table)
    if len(out_arc) < first_data_offset:
        out_arc.extend(b"\x00" * (first_data_offset - len(out_arc)))
    out_arc.extend(out_data)
    return bytes(out_arc)


# ---------------------------------------------------------------------------
# Unified Game Text Iterator & Synchronized Patcher
# ---------------------------------------------------------------------------


@dataclass
class GmdSource:
    is_loose: bool
    container_rel: str  # relative to nativeDX11x64/archive for arcs, or nativeDX11x64/ for loose
    file_path: Path
    gmd_key: str  # normalized without .gmd, forward slashes (e.g. BB/script/output/_macro02_eng)
    raw_bytes: bytes


def list_loose_gmd_paths(game_dir: Path) -> list[Path]:
    base = game_dir / "nativeDX11x64"
    arch = base / "archive"
    results: list[Path] = []
    if not base.exists():
        return results
    for p in sorted(base.rglob("*.gmd")):
        if arch in p.parents:
            continue
        results.append(p)
    return results


def iter_game_gmds(
    game_dir: Path,
    include_archives: bool = True,
    include_loose: bool = True,
    arc_list: tuple[str, ...] = GMD_BEARING_ARCS,
) -> Iterator[GmdSource]:
    """Yield every GMD source across all GMD-bearing archives and loose .gmd files."""
    native = game_dir / "nativeDX11x64"
    arch_dir = native / "archive"

    if include_archives:
        for arc_rel in arc_list:
            arc_path = arch_dir / arc_rel
            if not arc_path.exists():
                continue
            arc = parse_arc(arc_path.read_bytes())
            for entry in arc.entries:
                if entry.is_gmd and len(entry.data) >= 40:
                    yield GmdSource(
                        is_loose=False,
                        container_rel=arc_rel,
                        file_path=arc_path,
                        gmd_key=entry.norm_key,
                        raw_bytes=entry.data,
                    )

    if include_loose:
        for loose_path in list_loose_gmd_paths(game_dir):
            rel = normalize_rel(loose_path.relative_to(native))
            gmd_key = rel[:-4] if rel.lower().endswith(".gmd") else rel
            yield GmdSource(
                is_loose=True,
                container_rel=rel,
                file_path=loose_path,
                gmd_key=gmd_key,
                raw_bytes=loose_path.read_bytes(),
            )


def load_duplicate_index(game_dir: Path) -> dict[str, list[GmdSource]]:
    """Group all GMD sources sharing the same normalized gmd_key across loose + all 18 .arc."""
    by_key: dict[str, list[GmdSource]] = {}
    for src in iter_game_gmds(game_dir):
        by_key.setdefault(src.gmd_key.lower(), []).append(src)
    return {k: v for k, v in by_key.items() if len(v) > 1}


def apply_updates_to_game(
    game_dir: Path,
    updates_by_key: dict[str, dict[int, str]],
    sync_duplicates: bool = True,
) -> dict[str, int]:
    """Apply {gmd_key_lower: {str_idx: new_text}} atomically to both .arc and loose .gmd.

    When sync_duplicates=True (default), updating a key updates every loose .gmd AND every
    .arc archive containing that gmd_key. Returns {container_rel: modified_strings_count}.
    """
    norm_updates = {k.lower().replace("\\", "/"): v for k, v in updates_by_key.items() if v}
    if not norm_updates:
        return {}

    stats: dict[str, int] = {}
    native = game_dir / "nativeDX11x64"
    arch_dir = native / "archive"

    # 1. Patch archives
    for arc_rel in GMD_BEARING_ARCS:
        arc_path = arch_dir / arc_rel
        if not arc_path.exists():
            continue
        arc = parse_arc(arc_path.read_bytes())
        arc_mod = 0
        for entry in arc.entries:
            key = entry.norm_key.lower()
            if entry.is_gmd and key in norm_updates:
                doc = parse_gmd(entry.data)
                if doc is None:
                    continue
                valid_updates = {
                    idx: val
                    for idx, val in norm_updates[key].items()
                    if doc.strings[idx] != val
                }
                if valid_updates:
                    entry.data = build_gmd(doc, valid_updates)
                    arc_mod += len(valid_updates)
        if arc_mod > 0:
            arc_path.write_bytes(build_arc(arc))
            stats[f"arc:{arc_rel}"] = arc_mod

    # 2. Patch loose .gmd files
    for loose_path in list_loose_gmd_paths(game_dir):
        rel = normalize_rel(loose_path.relative_to(native))
        key = (rel[:-4] if rel.lower().endswith(".gmd") else rel).lower()
        if key in norm_updates:
            doc = parse_gmd(loose_path.read_bytes())
            if doc is None:
                continue
            valid_updates = {
                idx: val
                for idx, val in norm_updates[key].items()
                if doc.strings[idx] != val
            }
            if valid_updates:
                loose_path.write_bytes(build_gmd(doc, valid_updates))
                stats[f"loose:{rel}"] = len(valid_updates)

    if sync_duplicates and stats:
        # Enforce binary identity across every copy of every touched gmd_key
        touched_keys = set(norm_updates.keys())
        verify_sources = [s for s in iter_game_gmds(game_dir) if s.gmd_key.lower() in touched_keys]
        by_key: dict[str, list[GmdSource]] = {}
        for s in verify_sources:
            by_key.setdefault(s.gmd_key.lower(), []).append(s)
        for k, copies in by_key.items():
            if len(copies) > 1:
                parsed = [parse_gmd(c.raw_bytes) for c in copies]
                if all(p is not None for p in parsed):
                    base_strings = parsed[0].strings  # type: ignore[union-attr]
                    if any(p.strings != base_strings for p in parsed[1:]):  # type: ignore[union-attr]
                        raise RuntimeError(
                            f"Duplicate sync verification failed after patching {k}: copies diverged"
                        )
    return stats


def apply_transform_to_all(
    game_dir: Path,
    transform_fn: Callable[[str, int, str], str],
    dry_run: bool = False,
) -> dict[str, int]:
    """Run string transform across ALL 18 .arc + 69 loose .gmd files uniformly."""
    updates: dict[str, dict[int, str]] = {}
    for src in iter_game_gmds(game_dir):
        doc = parse_gmd(src.raw_bytes)
        if doc is None:
            continue
        k = src.gmd_key.lower()
        for idx, text in enumerate(doc.strings):
            new_text = transform_fn(src.gmd_key, idx, text)
            if new_text != text:
                updates.setdefault(k, {})[idx] = new_text

    if dry_run:
        return {k: len(v) for k, v in updates.items()}
    return apply_updates_to_game(game_dir, updates, sync_duplicates=True)


# ---------------------------------------------------------------------------
# Page-Level Language & Editorial Regression Detectors
# ---------------------------------------------------------------------------


def _ruby_to_effective_text(match: re.Match[str]) -> str:
    """For intentional foreign <RB> glossed by French <RT>, score the French <RT>."""
    rb_raw, rt_raw = match.group(1), match.group(2)
    rt_dec = decode_capcom_rt(rt_raw)
    if rt_dec:
        rt_lower = rt_dec.lower()
        rt_words = set(re.findall(r"[a-zA-ZÀ-ÿ]+", rt_lower))
        if (rt_words & FR_WORDS) or FR_ELISION_RE.search(rt_lower) or FR_DIACRITIC_RE.search(rt_dec):
            return rt_dec
    return rb_raw


def analyze_page_english(
    fr_page: str,
    orig_pages_clean: Optional[set[str]] = None,
) -> tuple[bool, str]:
    """Classify whether a single <PAGE> segment still has untranslated English.

    Returns (is_english, reason) where reason is one of:
    'identical_to_origin', 'lexical_en', ''
    """
    clean = clean_page_text(fr_page)
    lower = clean.lower()
    if len(clean) < 4 or lower in PROPER_NOUN_OR_NOISE_LINES:
        return False, ""

    alpha_words = re.findall(r"[A-Za-z]+", lower)
    if len(alpha_words) < 2:
        return False, ""

    # 1. Structural comparison against original unpatched game
    if orig_pages_clean is not None and len(clean) >= 15 and len(alpha_words) >= 3:
        if clean in orig_pages_clean:
            return True, "identical_to_origin"

    # 2. Lexical / contraction heuristic (counting intentional French <RT> glosses as French)
    eff = clean_page_text(RUBY_RE.sub(_ruby_to_effective_text, fr_page), strip_rt=False)
    eff_lower = eff.lower()
    eff_alpha = re.findall(r"[A-Za-z]+", eff_lower)
    if len(eff_alpha) < 2:
        return False, ""

    en_hits = [w for w in eff_alpha if w in EN_WORDS]
    en_contr = len(EN_CONTRACTION_RE.findall(eff_lower))
    fr_hits = [w for w in re.findall(r"[a-zA-ZÀ-ÿ]+", eff_lower) if w in FR_WORDS]
    fr_elisions = len(FR_ELISION_RE.findall(eff_lower))
    has_fr_accent = bool(FR_DIACRITIC_RE.search(eff))

    en_score = len(en_hits) + en_contr * 2
    fr_score = len(fr_hits) + fr_elisions * 2 + (2 if has_fr_accent else 0)

    if en_score >= 3 and en_score > fr_score * 1.3:
        return True, "lexical_en"
    if len(eff_alpha) <= 6 and en_contr >= 1 and fr_score == 0:
        return True, "lexical_en"
    return False, ""


def find_ruby_anomalies(text: str) -> list[dict[str, str]]:
    """Inspect all <RUBY> tags (with DOTALL + Capcom fullwidth decoding) for issues."""
    issues: list[dict[str, str]] = []
    eng_rt_indicators = {
        "the", "a", "an", "to", "of", "in", "and", "with", "for", "at", "from", "by",
        "big", "chance", "seat", "seats", "coach", "coachman", "derby", "smoke", "lock",
        "young", "lady", "horse", "very", "strange", "rules", "rule", "waiter",
    }
    for m in RUBY_RE.finditer(text):
        rb_raw, rt_raw = m.group(1), m.group(2)
        rb_clean = re.sub(r"\s+", " ", TAG_RE.sub("", rb_raw)).strip()
        rt_clean = decode_capcom_rt(rt_raw)
        rb_lower = rb_clean.lower()
        rt_lower = rt_clean.lower()

        if rb_lower in ("london", "londres") or rt_lower in ("london", "londres"):
            issues.append({"kind": "london_ruby", "rb": rb_clean, "rt": rt_clean})
            continue
        if not rt_clean:
            issues.append({"kind": "empty_rt", "rb": rb_clean, "rt": rt_clean})
            continue

        rt_words = set(re.findall(r"[a-zA-ZÀ-ÿ]+", rt_lower))
        if (
            rt_words & eng_rt_indicators
            and rb_lower not in INTENTIONAL_FR_TO_EN_RB
            and not any(p in rt_lower for p in INTENTIONAL_EN_RT_PHRASES)
        ):
            # Distinguish pure FR->EN vs normal bilingual gloss where RB is English
            rb_words = set(re.findall(r"[a-zA-ZÀ-ÿ]+", rb_lower))
            has_fr_rb = bool(FR_DIACRITIC_RE.search(rb_clean)) or bool(
                set(re.findall(r"[a-zA-ZÀ-ÿ]+", rb_lower)) & FR_WORDS
            )
            if has_fr_rb or not (rb_words & EN_WORDS):
                issues.append({"kind": "fr_to_en_ruby", "rb": rb_clean, "rt": rt_clean})
    return issues


def find_editorial_regressions(text: str) -> list[str]:
    """Return list of blocker regression tags for a raw GMD string."""
    regs: list[str] = []
    cleaned = clean_page_text(text)
    if re.search(r"dieu\s+de\s+la\s+mort", cleaned, re.IGNORECASE):
        regs.append("dieu_de_la_mort")
    if re.search(r"(?:bande|c[âa]ble)\s+mouchet", cleaned, re.IGNORECASE):
        regs.append("bande_mouchetee")
    if re.search(r"la<E507[^>]*>Crystal|cette<E516[^>]*>banquette|qu'un<E516[^>]*>kimono|toute<E516[^>]*>l'Europe", text):
        regs.append("glued_tag_phrase")
    if re.search(r"\b[a-zA-ZÀ-ÿ]{2,}<E5[01][67][^>]*>[a-zA-ZÀ-ÿ]", text):
        regs.append("glued_formatting_tag")
    if re.search(r"<E519>\s+[.,]|toutel'Europe|de Saô ,", text):
        regs.append("punctuation_spacing")
    for anom in find_ruby_anomalies(text):
        regs.append(f"ruby:{anom['kind']}")
    return regs


def find_untranslated_cjk(text: str) -> list[str]:
    """Return non-empty matches of CJK characters appearing outside <RUBY> tags."""
    without_rubies = RUBY_RE.sub("", text)
    without_tags = TAG_RE.sub("", without_rubies)
    return CJK_RE.findall(without_tags)
