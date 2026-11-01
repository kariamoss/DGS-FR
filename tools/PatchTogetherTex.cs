using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using DgsPatcher;

class PatchTogetherTex
{
    static void Main()
    {
        Console.WriteLine("=== Patching together_topic textures for 'déduction parfaite' ===");

        Directory.CreateDirectory(@"tools\patched_png");
        Directory.CreateDirectory(@"tools\repacked_dds");

        // 1. Process Texture 2
        string path2 = @"tools\exported_png\together_topic00_2_BM_NOMIP_eng.png";
        using (Bitmap b2 = new Bitmap(path2))
        using (Bitmap out2 = new Bitmap(b2))
        {
            int srcX = 160, srcY = 394, w = 67, h = 104;
            int dstX = 477;
            int dstY = 560;

            using (Graphics g = Graphics.FromImage(out2))
            {
                g.DrawImage(b2, new Rectangle(dstX, dstY, w, h), new Rectangle(srcX, srcY, w, h), GraphicsUnit.Pixel);
            }
            out2.Save(@"tools\patched_png\together_topic00_2_BM_NOMIP_eng.png");
            Console.WriteLine("Saved patched Texture 2 PNG.");
        }

        // 2. Process Texture 1
        string path1 = @"tools\exported_png\together_topic00_1_BM_NOMIP_eng.png";
        using (Bitmap b1 = new Bitmap(path1))
        using (Bitmap out1 = new Bitmap(b1))
        {
            int srcX = 157, srcY = 390, w = 73, h = 112;
            int dstX = 474;
            int dstY = 556;

            using (Graphics g = Graphics.FromImage(out1))
            {
                g.DrawImage(b1, new Rectangle(dstX, dstY, w, h), new Rectangle(srcX, srcY, w, h), GraphicsUnit.Pixel);
            }
            out1.Save(@"tools\patched_png\together_topic00_1_BM_NOMIP_eng.png");
            Console.WriteLine("Saved patched Texture 1 PNG.");
        }

        // 3. Compress using texconv
        var psi = new ProcessStartInfo();
        psi.FileName = @"tools\texconv.exe";
        psi.Arguments = @"-f BC7_UNORM -m 1 -y -o tools\repacked_dds tools\patched_png\together_topic00_1_BM_NOMIP_eng.png tools\patched_png\together_topic00_2_BM_NOMIP_eng.png";
        psi.UseShellExecute = false;
        psi.RedirectStandardOutput = true;
        var p = Process.Start(psi);
        string output = p.StandardOutput.ReadToEnd();
        p.WaitForExit();
        Console.WriteLine(output);

        // 4. Update UI_cmn_eng.arc
        string arcPath = @"D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\UI_cmn_eng.arc";
        var arc = ArcFile.Read(arcPath);

        foreach (var entry in arc.Entries)
        {
            if (entry.Name == @"UI\3_mg\30_together\tex\together_topic00_1_BM_NOMIP_eng")
            {
                byte[] dds = File.ReadAllBytes(@"tools\repacked_dds\together_topic00_1_BM_NOMIP_eng.dds");
                byte[] newTex = new byte[24 + (dds.Length - 148)];
                Array.Copy(entry.Data, 0, newTex, 0, 24);
                Array.Copy(dds, 148, newTex, 24, dds.Length - 148);
                entry.Data = newTex;
                Console.WriteLine("Updated entry: {0} ({1} bytes)", entry.Name, newTex.Length);
            }
            else if (entry.Name == @"UI\3_mg\30_together\tex\together_topic00_2_BM_NOMIP_eng")
            {
                byte[] dds = File.ReadAllBytes(@"tools\repacked_dds\together_topic00_2_BM_NOMIP_eng.dds");
                byte[] newTex = new byte[24 + (dds.Length - 148)];
                Array.Copy(entry.Data, 0, newTex, 0, 24);
                Array.Copy(dds, 148, newTex, 24, dds.Length - 148);
                entry.Data = newTex;
                Console.WriteLine("Updated entry: {0} ({1} bytes)", entry.Name, newTex.Length);
            }
        }

        arc.Save(arcPath);
        Console.WriteLine("Successfully saved updated UI_cmn_eng.arc!");
    }
}
