using System;
using System.IO;

public static class ResourceProvider
{
    public static string MinecraftPath { get; private set; }

    public static void Initialize()
    {
        // Prefer environment variable (set by Melty at launch), fallback to default Roaming path
        MinecraftPath = Environment.GetEnvironmentVariable("MINECRAFT_PATH");
        if (string.IsNullOrEmpty(MinecraftPath))
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            MinecraftPath = Path.Combine(appdata, ".minecraft");
        }
    }

    public static string GetTexturePath(string relative)
    {
        // relative: minecraft:block/dirt.png -> assets/minecraft/textures/block/dirt.png in resourcepacks or assets
        // Simple resolver: check resourcepacks first, then default jar extracted path (not implemented here)
        var rp = Path.Combine(MinecraftPath, "resourcepacks");
        // Caller should handle missing files; this method just forms an expected path.
        return Path.Combine(rp, relative.Replace('/', Path.DirectorySeparatorChar));
    }
}
