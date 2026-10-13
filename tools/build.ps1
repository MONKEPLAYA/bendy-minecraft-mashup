# Build script (PowerShell)

# Requires: dotnet SDK (for building the C# project) and BepInEx runtime for actual testing.

dotnet build -c Release

# After build, copy the built DLL to build/ for packaging.

mkdir -Force build
copy -Force bin\Release\net48\*.dll build\
