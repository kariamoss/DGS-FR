# Générateur des archives patchées DGS1 dans analyse\patched\GO\
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8

$frGoDir = "D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO"
$outDir = "analyse\patched\GO"

Add-Type -Path "tools\ArcPatcher.cs"

Write-Host "=== GENERATION DU PATCH DGS1 DANS $outDir ==="

# --- 1. DGS1 EPISODE 1 (sce00_eng.arc) ---
Write-Host "`nPatching sce00_eng.arc (Episode 1)..."
$arc1 = [DgsPatcher.ArcFile]::Read((Join-Path $frGoDir "sce00_eng.arc"))

$fixesEp1 = @(
    @{ Entry = "GO\script\output\_sce00_c000_0001_eng"; Target = "regard implorant"; Rep = "regards noirs"; Desc = "Contresens greffier (glares)" },
    @{ Entry = "GO\script\output\_sce00_c013_0000_eng"; Target = "professeur, OK ?"; Rep = "professeur. Rien de plus."; Desc = "Anachronisme Jezaille Brett (OK ?)" },
    @{ Entry = "GO\script\output\_sce00_c012_0004_eng"; Target = "deary me"; Rep = "mon Dieu"; Desc = "Anglicisme residuel Brett (deary me)" },
    @{ Entry = "GO\script\output\_sce00_c013_0000_eng"; Target = "rétribution pour ses actes."; Rep = "rétribution pour ses actes. Amen."; Desc = "Restauration Amen de Brett" },
    @{ Entry = "GO\script\output\_sce00_c016_0000_eng"; Target = "ce truc dont"; Rep = "cette affaire dont"; Desc = "Registre familier Ryunosuke" },
    @{ Entry = "GO\script\output\_sce00_c016_0000_eng"; Target = "ça ne devrait pas être facile d'invoquer"; Rep = "ils ne peuvent tout de même pas invoquer"; Desc = "Calque extraterritorialite" }
)

foreach ($f in $fixesEp1) {
    $ok = $arc1.ReplaceInGMD($f.Entry, $f.Target, $f.Rep)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc)"
    }
}
$out1 = Join-Path $outDir "sce00_eng.arc"
$arc1.Save($out1)
Write-Host "  -> Sauvegardé dans $out1 ($((Get-Item $out1).Length) octets)"

# --- 2. DGS1 EPISODE 3 (sce02_eng.arc) ---
Write-Host "`nPatching sce02_eng.arc (Episode 3)..."
$arc3 = [DgsPatcher.ArcFile]::Read((Join-Path $frGoDir "sce02_eng.arc"))

$fixesEp3 = @(
    @{ Entry = "GO\script\output\_sce02_c100_0000_eng"; Target = "du Dieu de la Mort"; Rep = "de la Faucheuse d'Old Bailey"; Desc = "Titre Van Peers 1" },
    @{ Entry = "GO\script\output\_sce02_c100_0000_eng"; Target = "Dieu de la Mort"; Rep = "Faucheuse d'Old Bailey"; Desc = "Titre Van Peers 2" }
)

foreach ($f in $fixesEp3) {
    $ok = $arc3.ReplaceInGMD($f.Entry, $f.Target, $f.Rep)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc)"
    }
}
$out3 = Join-Path $outDir "sce02_eng.arc"
$arc3.Save($out3)
Write-Host "  -> Sauvegardé dans $out3 ($((Get-Item $out3).Length) octets)"

# --- 3. DGS1 EPISODE 4 (sce03_eng.arc) ---
Write-Host "`nPatching sce03_eng.arc (Episode 4)..."
$arc4 = [DgsPatcher.ArcFile]::Read((Join-Path $frGoDir "sce03_eng.arc"))

$fixesEp4 = @(
    @{ Entry = "GO\script\output\_sce03_bg0202_3d_check_0_eng"; Target = "combien ça doit être désespérant"; Rep = "combien cela doit être angoissant"; Desc = "Registre angoisse Sôseki" }
)

foreach ($f in $fixesEp4) {
    $ok = $arc4.ReplaceInGMD($f.Entry, $f.Target, $f.Rep)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc)"
    }
}
$out4 = Join-Path $outDir "sce03_eng.arc"
$arc4.Save($out4)
Write-Host "  -> Sauvegardé dans $out4 ($((Get-Item $out4).Length) octets)"

Write-Host "`n=== TOUTES LES ARCHIVES SONT GENEREES ET VALIDEES ! ==="
