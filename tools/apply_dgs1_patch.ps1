# Script d'application chirurgicale du patch DGS1 (Episodes 1 a 5)
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8

$frGoDir = "D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO"

if (-not (Test-Path $frGoDir)) {
    Write-Error "Dossier du jeu introuvable : $frGoDir"
    exit 1
}

# Charger ArcPatcher C#
Add-Type -Path "tools\ArcPatcher.cs"

Write-Host "=== DEBUT DU PATCHAGE DE DGS1 ==="

# 1. Sauvegarde automatique .bak
$arcsToPatch = @("sce00_eng.arc", "sce02_eng.arc", "sce03_eng.arc")

foreach ($arcName in $arcsToPatch) {
    $src = Join-Path $frGoDir $arcName
    $bak = "$src.bak"
    if (-not (Test-Path $bak)) {
        Copy-Item -Path $src -Destination $bak -Force
        Write-Host "Sauvegarde creee : $bak"
    } else {
        Write-Host "Sauvegarde existante preservee : $bak"
    }
}

# --- EPISODE 1 : sce00_eng.arc ---
Write-Host "`n--- Application des corrections sur DGS1 Episode 1 (sce00_eng.arc) ---"
$arc1Path = Join-Path $frGoDir "sce00_eng.arc"
$arc1 = [DgsPatcher.ArcFile]::Read($arc1Path)

$fixesEp1 = @(
    # 1. Contresens greffier (glares -> regards noirs)
    @{
        File = "GO\script\output\_sce00_c000_0001_eng"
        Target = "Vous pouvez me fixer de ce regard implorant, ça ne sert à rien ! Espèce... de sale meurtrier !"
        Replacement = "Vous pouvez me lancer vos regards noirs, ça ne sert à rien ! Espèce... de sale meurtrier !"
        Desc = "Contresens greffier (glares)"
    },
    # 2. Anachronisme Jezaille Brett (OK ?)
    @{
        File = "GO\script\output\_sce00_c013_0000_eng"
        Target = "À ce moment-là, je mangeais juste un steak tout en trinquant avec le professeur, OK ?"
        Replacement = "À ce moment-là, je me contentais de déguster mon steak tout en portant un toast avec le professeur. Rien de plus."
        Desc = "Anachronisme Jezaille Brett (OK ?)"
    },
    # 3. Anglicisme résiduel Brett (deary me)
    @{
        File = "GO\script\output\_sce00_c012_0004_eng"
        Target = "Ah, deary me... Pardonnez-moi si mes propos vous blessent."
        Replacement = "Ah, mon Dieu... Pardonnez-moi si mes propos vous blessent."
        Desc = "Anglicisme residuel Brett (deary me)"
    },
    # 4. Formule du Amen de Brett (donnant sens a la replique suivante de Ryunosuke)
    @{
        File = "GO\script\output\_sce00_c013_0000_eng"
        Target = "reçoive la juste rétribution pour ses actes."
        Replacement = "reçoive la plus sévère des punitions. Amen."
        Desc = "Restauration du Amen de Brett"
    },
    # 5. Registre familier Ryunosuke devant le juge
    @{
        File = "GO\script\output\_sce00_c016_0000_eng"
        Target = "ce truc dont"
        Replacement = "cette affaire de juridiction dont"
        Desc = "Registre familier Ryunosuke"
    },
    # 6. Calque lourd d'extraterritorialite
    @{
        File = "GO\script\output\_sce00_c016_0000_eng"
        Target = "ça ne devrait pas être facile d'invoquer"
        Replacement = "ils ne peuvent tout de même pas invoquer"
        Desc = "Calque lourd d'extraterritorialite"
    }
)

foreach ($f in $fixesEp1) {
    $ok = $arc1.ReplaceInGMD($f.File, $f.Target, $f.Replacement)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc) : cible non trouvee dans $($f.File)"
    }
}
$arc1.Save($arc1Path)
Write-Host "Episode 1 patché et sauvegardé avec succès !"

# --- EPISODE 3 : sce02_eng.arc ---
Write-Host "`n--- Application des corrections sur DGS1 Episode 3 (sce02_eng.arc) ---"
$arc3Path = Join-Path $frGoDir "sce02_eng.arc"
$arc3 = [DgsPatcher.ArcFile]::Read($arc3Path)

$fixesEp3 = @(
    # 1. Titre du procureur (Faucheuse d'Old Bailey au lieu de Dieu de la Mort)
    @{
        File = "GO\script\output\_sce02_c100_0000_eng"
        Target = "C'est à cause... du Dieu de la Mort."
        Replacement = "C'est à cause... de la Faucheuse d'Old Bailey."
        Desc = "Titre Van Peers : Faucheuse d'Old Bailey"
    },
    @{
        File = "GO\script\output\_sce02_c100_0000_eng"
        Target = "Le... ""Dieu de la Mort"" ?"
        Replacement = "La... ""Faucheuse d'Old Bailey"" ?"
        Desc = "Reaction Ryunosuke : Faucheuse"
    },
    @{
        File = "GO\script\output\_sce02_c100_0000_eng"
        Target = "serait un ""Dieu de la Mort"" ?"
        Replacement = "serait ""la Faucheuse de la cour"" ?"
        Desc = "Interrogation Faucheuse de la cour"
    }
)

foreach ($f in $fixesEp3) {
    $ok = $arc3.ReplaceInGMD($f.File, $f.Target, $f.Replacement)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc) : cible non trouvee dans $($f.File)"
    }
}
$arc3.Save($arc3Path)
Write-Host "Episode 3 patché et sauvegardé avec succès !"

# --- EPISODE 4 : sce03_eng.arc ---
Write-Host "`n--- Application des corrections sur DGS1 Episode 4 (sce03_eng.arc) ---"
$arc4Path = Join-Path $frGoDir "sce03_eng.arc"
$arc4 = [DgsPatcher.ArcFile]::Read($arc4Path)

$fixesEp4 = @(
    @{
        File = "GO\script\output\_sce03_bg0202_3d_check_0_eng"
        Target = "combien ça doit être désespérant d'être impliqué dans une affaire à l'étranger"
        Replacement = "combien cela doit être terriblement angoissant d'être mêlé à une telle affaire en terre étrangère"
        Desc = "Registre d'angoisse de Soseki"
    }
)

foreach ($f in $fixesEp4) {
    $ok = $arc4.ReplaceInGMD($f.File, $f.Target, $f.Replacement)
    if ($ok) {
        Write-Host "  [OK] $($f.Desc)"
    } else {
        Write-Warning "  [ECHEC] $($f.Desc) : cible non trouvee dans $($f.File)"
    }
}
$arc4.Save($arc4Path)
Write-Host "Episode 4 patché et sauvegardé avec succès !"

Write-Host "`n=== PATCHAGE DE DGS1 TERMINE AVEC SUCCES ! ==="
