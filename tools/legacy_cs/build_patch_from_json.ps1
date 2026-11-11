# Applique les règles de patch_rules.json vers analyse\patched\GO\
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8

$frGoDir = "D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\GO"
$outDir = "analyse\patched\GO"

Add-Type -Path "tools\ArcPatcher.cs"

$rulesJson = Get-Content "tools\patch_rules.json" -Raw -Encoding UTF8 | ConvertFrom-Json
$rulesByArc = $rulesJson | Group-Object Arc

foreach ($grp in $rulesByArc) {
    $arcName = $grp.Name
    Write-Host "`nTraitement de $arcName..."
    $arcPath = Join-Path $frGoDir $arcName
    $arc = [DgsPatcher.ArcFile]::Read($arcPath)
    
    foreach ($r in $grp.Group) {
        $ok = $arc.ReplaceInGMD($r.Entry, $r.Target, $r.Replacement)
        if ($ok) {
            Write-Host "  [OK] $($r.Desc)"
        } else {
            Write-Warning "  [ECHEC] $($r.Desc)"
        }
    }
    
    $outPath = Join-Path $outDir $arcName
    $arc.Save($outPath)
    Write-Host "  -> Sauvegardé dans $outPath ($((Get-Item $outPath).Length) octets)"
}

Write-Host "`n=== PATCH DGS1 GENERE AVEC SUCCES DANS $outDir ==="
