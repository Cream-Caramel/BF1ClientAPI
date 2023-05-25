using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class KitDB
{
    /// <summary>
    /// Kit Data
    /// </summary>
    public readonly static List<KitInfo> AllKitInfo = new()
    {
        new() { Id="ID_M_TANKER", Name="Tanker", Image="KitIconTankerLarge.png" },
        new() { Id="ID_M_PILOT", Name="Pilot", Image="KitIconPilotLarge.png" },
        new() { Id="ID_M_CAVALRY", Name="Cavalry", Image="KitIconRiderLarge.png" },
        new() { Id="ID_M_SENTRY", Name="Sentry", Image="KitIconSentryLarge.png" },
        new() { Id="ID_M_FLAMETHROWER", Name="Flamethrower", Image="KitIconFlamethrowerLarge.png" },
        new() { Id="ID_M_INFILTRATOR", Name="Infiltrator", Image="KitIconInfiltratorLarge.png" },
        new() { Id="ID_M_TRENCHRAIDER", Name="Trench Raider", Image="KitIconTrenchRaiderLarge.png" },
        new() { Id="ID_M_ANTITANK", Name="Tank Hunter", Image="KitIconAntiTankLarge.png" },
        new() { Id="ID_M_ASSAULT", Name="Assault", Image="KitIconAssaultLarge.png" },
        new() { Id="ID_M_MEDIC", Name="Medic", Image="KitIconMedicLarge.png" },
        new() { Id="ID_M_SUPPORT", Name="Support", Image="KitIconSupportLarge.png" },
        new() { Id="ID_M_SCOUT", Name="Scout", Image="KitIconScoutLarge.png" }
    };
}

public class KitInfo
{
    public string Id;
    public string Name;
    public string Image;

    public string GetKitImage()
    {
        return ClientUtil.GetHostImageURL($"Kits\\{Image}");
    }

    public string GetKit2Image()
    {
        return ClientUtil.GetHostImageURL($"Kits2\\{Image}");
    }
}
