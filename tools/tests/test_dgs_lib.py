"""Unit tests for tools/dgs_lib.py."""

import struct
import sys
import unittest
import zlib
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent.parent))
import dgs_lib


def _make_fake_gmd(strings: list[str], trailing_null: bool = True) -> bytes:
    header = bytearray(b"GMD\x00" + b"\x00" * 36)
    if not strings:
        struct.pack_into("<I", header, 32, 0)
        return bytes(header)
    block = b"\x00".join(s.encode("utf-8") for s in strings)
    if trailing_null:
        block += b"\x00"
    struct.pack_into("<I", header, 32, len(block))
    return bytes(header) + block


def _make_fake_arc(entries: list[tuple[str, int, bytes]]) -> bytes:
    ver, count = 7, len(entries)
    first_data = 0x8000
    table = bytearray()
    data = bytearray()
    off = first_data
    for name, thash, raw in entries:
        raw_name = name.encode("ascii").ljust(128, b"\x00")
        comp = zlib.compress(raw) if raw else b""
        table.extend(raw_name)
        table.extend(struct.pack("<IIII", thash, len(comp), len(raw), off if comp else 0))
        off += len(comp)
        data.extend(comp)
    out = bytearray(struct.pack("<4sHH", b"ARC\x00", ver, count))
    out.extend(table)
    out.extend(b"\x00" * (first_data - len(out)))
    out.extend(data)
    return bytes(out)


class TestDgsLib(unittest.TestCase):
    def test_gmd_roundtrip_and_empty_block(self) -> None:
        empty_gmd = _make_fake_gmd([])
        doc_empty = dgs_lib.parse_gmd(empty_gmd)
        self.assertIsNotNone(doc_empty)
        self.assertEqual(doc_empty.strings, [])
        self.assertEqual(dgs_lib.build_gmd(doc_empty, {}), empty_gmd)

        sample = ["Bonjour", "Au revoir <PAGE>\r\nLondon"]
        gmd = _make_fake_gmd(sample, trailing_null=True)
        doc = dgs_lib.parse_gmd(gmd)
        self.assertIsNotNone(doc)
        self.assertEqual(doc.strings, sample)
        rebuilt = dgs_lib.build_gmd(doc, {1: "Au revoir <PAGE>\r\nParis"})
        doc2 = dgs_lib.parse_gmd(rebuilt)
        self.assertEqual(doc2.strings, ["Bonjour", "Au revoir <PAGE>\r\nParis"])

    def test_gmd_rejects_embedded_null(self) -> None:
        doc = dgs_lib.parse_gmd(_make_fake_gmd(["ok"]))
        with self.assertRaises(ValueError):
            dgs_lib.build_gmd(doc, {0: "bad\x00string"})

    def test_arc_roundtrip(self) -> None:
        g1 = _make_fake_gmd(["Test 1", "Test 2"])
        arc_bytes = _make_fake_arc([("GO\\script\\output\\_sce00_c000_0000_eng", 0x242BB29A, g1)])
        arc = dgs_lib.parse_arc(arc_bytes)
        self.assertEqual(len(arc.entries), 1)
        self.assertTrue(arc.entries[0].is_gmd)
        rebuilt = dgs_lib.parse_arc(dgs_lib.build_arc(arc))
        self.assertEqual(rebuilt.entries[0].data, g1)

    def test_decode_capcom_rt_nested_col(self) -> None:
        raw_rt = "<COL f9e041ff>\u3000ｔｈｅ\u3000ｂｉｇ\u3000ｃｈａｎｃｅ</COL>"
        self.assertEqual(dgs_lib.decode_capcom_rt(raw_rt), "the big chance")
        self.assertEqual(dgs_lib.decode_capcom_rt("<COL 1b0894ff>Ｍ．\uffc9</COL>"), "M.é")

    def test_ruby_anomalies_avoid_false_positive_on_diacritics(self) -> None:
        # "Aï" (Japanese love pun) must not split on ï into English 'a'
        self.assertEqual(dgs_lib.find_ruby_anomalies("<RUBY><RB>愛</RB><RT>Aï</RT></RUBY>"), [])
        self.assertEqual(
            dgs_lib.find_ruby_anomalies("<RUBY><RB>愛姫</RB><RT>Aï Hime</RT></RUBY>"),
            [],
        )
        # London / empty RT / FR->EN with <COL> must all be caught
        london = dgs_lib.find_ruby_anomalies("<RUBY><RB>London</RB><RT><COL f9e041ff>Ｌｏｎｄｒｅｓ</COL></RT></RUBY>")
        self.assertEqual(london[0]["kind"], "london_ruby")
        fr_en = dgs_lib.find_ruby_anomalies(
            "<RUBY><RB>l'occasion rêvée</RB><RT><COL f9e041ff>ｔｈｅ ｂｉｇ ｃｈａｎｃｅ</COL></RT></RUBY>"
        )
        self.assertEqual(fr_en[0]["kind"], "fr_to_en_ruby")
        empty = dgs_lib.find_ruby_anomalies("<RUBY><RB>test</RB><RT><COL f9e041ff>\u3000</COL></RT></RUBY>")
        self.assertEqual(empty[0]["kind"], "empty_rt")

    def test_page_language_classifier_and_editorial_regressions(self) -> None:
        orig = {"No doubt you're hungry to learn more of my deep love of game!"}
        is_en, reason = dgs_lib.analyze_page_english(
            "<E041 1 0>No doubt you're hungry to learn more of my deep love of game!",
            orig_pages_clean=orig,
        )
        self.assertTrue(is_en)
        self.assertEqual(reason, "identical_to_origin")

        is_en_fr, _ = dgs_lib.analyze_page_english(
            "<E041 1 0>Il n'y a vraiment rien d'anormal ici, M. Yûno !"
        )
        self.assertFalse(is_en_fr)

        self.assertIn(
            "glued_tag_phrase",
            dgs_lib.find_editorial_regressions("Hm, la<E507 a b>Crystal Tower..."),
        )
        self.assertIn(
            "bande_mouchetee",
            dgs_lib.find_editorial_regressions('il a vu une "bande\r\nmouchetée".'),
        )
        self.assertIn(
            "bande_mouchetee",
            dgs_lib.find_editorial_regressions('la mystérieuse "<E516 33>bande<E519> mouchetée"'),
        )
        self.assertIn(
            "dieu_de_la_mort",
            dgs_lib.find_editorial_regressions('le Dieu de\r\n<E042><CNTR>la Mort'),
        )
        # Valid French spacing before ! should NOT fail punctuation_spacing, whereas space before . DOES
        self.assertNotIn(
            "punctuation_spacing",
            dgs_lib.find_editorial_regressions("Mon <E507 a b>koban<E519> !"),
        )
        self.assertIn(
            "punctuation_spacing",
            dgs_lib.find_editorial_regressions("de toute <E516 231>l'Europe<E519> ."),
        )

    def test_bilingual_french_rt_not_flagged_as_english(self) -> None:
        # Intentional foreign flavor phrase glossed by French <RT> must count as translated
        page = (
            "<E025 3>Allez, tenez... <E516 116><RUBY><RB>That's your tip</RB>"
            "<RT><COL f9e041ff> Ｖｏｉｃｉ ｖｏｔｒｅ ｐｏｕｒｂｏｉｒｅ</COL></RT></RUBY><E519> !"
        )
        self.assertFalse(dgs_lib.analyze_page_english(page)[0])
        self.assertFalse(
            dgs_lib.analyze_page_english(
                "... <RUBY><RB>weren't you</RB><RT><COL f9e041ff>ｎ＇ｅｓｔ－ｃｅ ｐａｓ</COL></RT></RUBY> ?"
            )[0]
        )
        # Non-French RT must NOT hide an untranslated English phrase
        self.assertTrue(
            dgs_lib.analyze_page_english(
                "<RUBY><RB>That's your tip</RB><RT><COL f9e041ff>ｙｏｕｒ ｔｉｐ</COL></RT></RUBY>"
            )[0]
        )


if __name__ == "__main__":
    unittest.main()
