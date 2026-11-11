using System;
using System.IO;
using System.Text;
using DgsPatcher;

namespace PatchLinguistic {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Application des correctifs qualitatifs DGS2 ===");

            string arc0Path = @"analyse\patched\BB\sce00_eng.arc";
            string arc1Path = @"analyse\patched\BB\sce01_eng.arc";

            // ----------------------------------------------------
            // ÉPISODE 2 : sce01_eng.arc
            // ----------------------------------------------------
            Console.WriteLine("\n--- Traitement de sce01_eng.arc (Épisode 2) ---");
            ArcFile arc1 = ArcFile.Read(arc1Path);

            // 1. Tasse de thé & invité
            string t1 = "la tasse de thé<E003 4> dans\r\nlaquelle Mr Jakespeare <E507 a b>buvait<E519>... son thé.";
            string r1 = "l'une des tasses<E003 4> dans\r\nlesquelles Mr Jakespeare et son invité ont bu hier soir.";
            int c1 = arc1.ReplaceInAllGMDs(t1, r1);
            Console.WriteLine("1. Tasse de thé & invité : " + c1 + " modif(s)");

            // 2. Tache de suif sous le compteur
            string t2 = "regarde un peu ici :<E003 10>\r\n<E333>Il y a une tache sombre sur le plancher.";
            string r2 = "regarde cette tache sombre sur le plancher,<E003 10>\r\n<E333>juste sous le compteur.";
            int c2 = arc1.ReplaceInAllGMDs(t2, r2);
            Console.WriteLine("2. Tache sous le compteur : " + c2 + " modif(s)");

            // 3. Attribution verbe badigeonner
            string t3 = "du poison aurait badigeonné le tuyau !";
            string r3 = "le tuyau ait été badigeonné de poison !";
            int c3 = arc1.ReplaceInAllGMDs(t3, r3);
            Console.WriteLine("3. Poison badigeonné : " + c3 + " modif(s)");

            // 4a. Pompe à eau gelée (Garrideb)
            string t4a = "... les tuyaux d'eau avaient gelé,<E003 5> je me suis\r\nmême démené pour acheter de l'eau <E003 4>à chauffer.";
            string r4a = "... comme la pompe à eau publique dehors avait gelé,<E003 5> je me suis\r\nmême démené pour acheter de l'eau en bouteille à chauffer.";
            int c4a = arc1.ReplaceInAllGMDs(t4a, r4a);
            Console.WriteLine("4a. Pompe à eau publique gelée (Garrideb) : " + c4a + " modif(s)");

            // 4b. Echo pompe à eau gelée (Ryunosuke)
            string t4b = "<E025 3>Euh... <E003 3>Les tuyaux d'eau<E003 4> avaient gelé<E025 6>...<E025 2> ?<E023><PAGE>";
            string r4b = "<E025 3>Euh... <E003 3>La pompe à eau publique<E003 4> avait gelé<E025 6>...<E025 2> ?<E023><PAGE>";
            int c4b = arc1.ReplaceInAllGMDs(t4b, r4b);
            Console.WriteLine("4b. Echo pompe gelée (Ryunosuke) : " + c4b + " modif(s)");

            // 5. Enfer de gaz
            string t5 = "de la maison s'éteignent, et c'est l'enfer de gaz !";
            string r5 = "de la maison s'éteignent, et on court à la catastrophe !";
            int c5 = arc1.ReplaceInAllGMDs(t5, r5);
            Console.WriteLine("5. Calque 'enfer de gaz' : " + c5 + " modif(s)");

            arc1.Save(arc1Path);
            Console.WriteLine("Sauvegarde de sce01_eng.arc terminée (" + new FileInfo(arc1Path).Length + " octets).");

            // ----------------------------------------------------
            // ÉPISODE 1 : sce00_eng.arc
            // ----------------------------------------------------
            Console.WriteLine("\n--- Traitement de sce00_eng.arc (Épisode 1) ---");
            ArcFile arc0 = ArcFile.Read(arc0Path);

            // 6. Lourdeur Gizelle coupable
            string t6 = "<E025 4>Et le <E006>coupable<E005> dans cette affaire<E025 6>... <E049><E003 10>\r\n<E025 3>était une coupable, <E145 8 7><E144 8><E330>Gizelle Brett.";
            string r6 = "<E025 4>Et la <E006>coupable<E005> dans cette affaire<E025 6>... <E049><E003 10>\r\n<E025 3>n'était autre que <E145 8 7><E144 8><E330>Gizelle Brett.";
            int c6 = arc0.ReplaceInAllGMDs(t6, r6);
            Console.WriteLine("6. Lourdeur Gizelle coupable : " + c6 + " modif(s)");

            // 7a. Mobile Shanghai départ
            string t7a = "Miss Gizelle Brett\r\nserait envoyée à";
            string r7a = "Miss Gizelle Brett\r\npartait pour";
            int c7a = arc0.ReplaceInAllGMDs(t7a, r7a);
            Console.WriteLine("7a. Mobile Shanghai départ : " + c7a + " modif(s)");

            // 7b. Mobile Shanghai lever la main
            string t7b = "occasion <E049><E003 8><E025 4>de lever la main contre elle.";
            string r7b = "occasion <E049><E003 8><E025 4>de lever la main sur elle.";
            int c7b = arc0.ReplaceInAllGMDs(t7b, r7b);
            Console.WriteLine("7b. Lever la main sur elle : " + c7b + " modif(s)");

            // 8. Anachronisme OK (Sémémo)
            string t8 = "c'est mes mots à moi, alors taisez-vous, OK ?";
            string r8 = "ce sont mes mots à moi, alors silence, un peu !";
            int c8 = arc0.ReplaceInAllGMDs(t8, r8);
            Console.WriteLine("8. Anachronisme OK (Sémémo) : " + c8 + " modif(s)");

            arc0.Save(arc0Path);
            Console.WriteLine("Sauvegarde de sce00_eng.arc terminée (" + new FileInfo(arc0Path).Length + " octets).");

            Console.WriteLine("\n=== TOUS LES CORRECTIFS APPLIQUÉS AVEC SUCCÈS ===");
        }
    }
}
