using BepInEx;
using UnityEngine;

[BepInPlugin("com.monkeplaya.bendy.minecraft", "BendyMinecraftCompanion", "0.1.0")]
public class BendyMinecraftCompanion : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Bendy-Minecraft companion plugin loaded.");
        ResourceProvider.Initialize();
        InventorySystem.Initialize();
    }

    private void Update()
    {
        InventorySystem.Tick(Time.deltaTime);
        PlacementSystem.Tick(Time.deltaTime);
        MiningSystem.Tick(Time.deltaTime);
    }
}
