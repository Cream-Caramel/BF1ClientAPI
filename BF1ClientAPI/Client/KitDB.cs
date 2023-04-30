using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class KitDB
{
    /// <summary>
    /// 兵种数据
    /// </summary>
    public readonly static List<KitInfo> AllKitInfo = new()
    {
        new() { English="ID_M_TANKER", Chinese="坦克", KitImage="KitIconTankerLarge.png" },
        new() { English="ID_M_PILOT", Chinese="飞机", KitImage="KitIconPilotLarge.png" },
        new() { English="ID_M_CAVALRY", Chinese="骑兵", KitImage="KitIconRiderLarge.png" },
        new() { English="ID_M_SENTRY", Chinese="哨兵", KitImage="KitIconSentryLarge.png" },
        new() { English="ID_M_FLAMETHROWER", Chinese="喷火兵", KitImage="KitIconFlamethrowerLarge.png" },
        new() { English="ID_M_INFILTRATOR", Chinese="入侵者", KitImage="KitIconInfiltratorLarge.png" },
        new() { English="ID_M_TRENCHRAIDER", Chinese="战壕奇兵", KitImage="KitIconTrenchRaiderLarge.png" },
        new() { English="ID_M_ANTITANK", Chinese="坦克猎手", KitImage="KitIconAntiTankLarge.png" },
        new() { English="ID_M_ASSAULT", Chinese="突击兵", KitImage="KitIconAssaultLarge.png" },
        new() { English="ID_M_MEDIC", Chinese="医疗兵", KitImage="KitIconMedicLarge.png" },
        new() { English="ID_M_SUPPORT", Chinese="支援兵", KitImage="KitIconSupportLarge.png" },
        new() { English="ID_M_SCOUT", Chinese="侦察兵", KitImage="KitIconScoutLarge.png" }
    };
}

public class KitInfo
{
    public string English;
    public string Chinese;
    public string KitImage;

    public string GetKitImage()
    {
        return ClientUtil.GetHostImageURL($"Kits\\{KitImage}.png");
    }

    public string GetKit2Image()
    {
        return ClientUtil.GetHostImageURL($"Kits2\\{KitImage}.png");
    }
}
