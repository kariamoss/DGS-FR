$lines = Get-Content 'analyse\trans_ep3\act4_trial2_en_dump.txt'
$keys = @()
foreach ($l in $lines) {
    if ($l -match '^KEY:(.*)') {
        $keys += $matches[1]
    }
}
$groups = $keys | ForEach-Object { ($_ -split '#')[0] } | Group-Object
foreach ($g in $groups) {
    Write-Host "$($g.Count) : $($g.Name)"
}
