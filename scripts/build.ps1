# This file is intentionally minimal to avoid guessing a broad project setup.
# Review the repo and then run the script from PowerShell:
#   .\scripts\copy-unity-dlls.ps1
#   msbuild .\BendyMinecraftCompanion\BendyMinecraftCompanion.csproj /p:Configuration=Release

Write-Host "Copy local Unity DLLs from the Bendy install first, then build with MSBuild."
