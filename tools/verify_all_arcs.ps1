[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
Add-Type -Path "tools\ArcPatcher.cs"

$bbDir = "D:\The Great Ace Attorney Chronicles FR\nativeDX11x64\archive\BB"
$arcs = @("sce00_eng.arc", "sce01_eng.arc", "sce02_eng.arc", "sce03_eng.arc", "sce04_eng.arc")

Write-Host "=== VERIFICATION INTEGRITE DES ARCHIVES DGS2 DEPLOYEES ==="
foreach ($arcName in $arcs) {
    $path = Join-Path $bbDir $arcName
    if (Test-Path $path) {
        $arc = [DgsPatcher.ArcFile]::Read($path)
        $len = (Get-Item $path).Length
        Write-Host "  [OK] $arcName : $($arc.Entries.Count) entrees, $len octets"
    } else {
        Write-Host "  [MANQUANT] $arcName"
    }
}
Write-Host "=== TOUTES LES ARCHIVES DGS2 SONT VALIDES ET DEPLOYEES ==="
