using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class KitDB
{
    /// <summary>
    /// 兵种数据
    /// </summary>
    public readonly static List<KitInfo> AllKitInfo = new()
    {
        new() { Id="ID_M_TANKER", Name="坦克", Image="KitIconTankerLarge.png" },
        new() { Id="ID_M_PILOT", Name="飞机", Image="KitIconPilotLarge.png" },
        new() { Id="ID_M_CAVALRY", Name="骑兵", Image="KitIconRiderLarge.png" },
        new() { Id="ID_M_SENTRY", Name="哨兵", Image="KitIconSentryLarge.png" },
        new() { Id="ID_M_FLAMETHROWER", Name="喷火兵", Image="KitIconFlamethrowerLarge.png" },
        new() { Id="ID_M_INFILTRATOR", Name="入侵者", Image="KitIconInfiltratorLarge.png" },
        new() { Id="ID_M_TRENCHRAIDER", Name="战壕奇兵", Image="KitIconTrenchRaiderLarge.png" },
        new() { Id="ID_M_ANTITANK", Name="坦克猎手", Image="KitIconAntiTankLarge.png" },
        new() { Id="ID_M_ASSAULT", Name="突击兵", Image="KitIconAssaultLarge.png" },
        new() { Id="ID_M_MEDIC", Name="医疗兵", Image="KitIconMedicLarge.png" },
        new() { Id="ID_M_SUPPORT", Name="支援兵", Image="KitIconSupportLarge.png" },
        new() { Id="ID_M_SCOUT", Name="侦察兵", Image="KitIconScoutLarge.png" }
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
