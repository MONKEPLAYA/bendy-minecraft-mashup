$repo = Split-Path -Parent $MyInvocation.MyCommand.Path
$managed = 'C:\Program Files (x86)\Steam\steamapps\common\Bendy and the Ink Machine\Bendy_Data\Managed'
$libs = Join-Path $repo 'libs'

if (!(Test-Path $libs)) {
    New-Item -ItemType Directory -Force -Path $libs | Out-Null
}

$required = @(
    'UnityEngine.CoreModule.dll',
    'UnityEngine.dll',
    'UnityEngine.UI.dll',
    'Assembly-CSharp.dll'
)

foreach ($file in $required) {
    $src = Join-Path $managed $file
    $dst = Join-Path $libs $file
    if (Test-Path $src) {
        Copy-Item -Path $src -Destination $dst -Force
        Write-Host "Copied $file"
    } else {
        Write-Host "Missing: $file (not found in managed folder)"
    }
}

Write-Host "Local Unity DLLs copied to $libs"
Write-Host "Do not commit libs/ to GitHub."
