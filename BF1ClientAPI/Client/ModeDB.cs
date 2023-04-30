namespace BF1ClientAPI.Client;

public static class ModeDB
{
    /// <summary>
    /// 地图模式数据
    /// </summary>
    public readonly static List<ModeInfo> AllModeInfo = new()
    {
        new() { Id="ID_M_GAMEMODE_ZONECONTROL", Name="空降补给", Mark="ZoneControl0" },
        new() { Id="ID_M_GAMEMODE_AIRASSAULT", Name="空中突袭", Mark="AirAssault0" },
        new() { Id="ID_M_GAMEMODE_TUGOFWAR", Name="前线", Mark="TugOfWar0" },
        new() { Id="ID_M_GAMEMODE_DOMINATION", Name="抢攻", Mark="Domination0" },
        new() { Id="ID_M_GAMEMODE_BREAKTHROUGH", Name="闪击行动", Mark="Breakthrough0" },
        new() { Id="ID_M_GAMEMODE_RUSH", Name="突袭", Mark="Rush0" },
        new() { Id="ID_M_GAMEMODE_TEAMDEATHMATCH", Name="团队死斗", Mark="TeamDeathMatch0" },
        new() { Id="ID_M_GAMEMODE_BREAKTHROUGHLARGE", Name="行动模式", Mark="BreakthroughLarge0" },
        new() { Id="ID_M_GAMEMODE_POSSESSION", Name="战争信鸽", Mark="Possession0" },
        new() { Id="ID_M_GAMEMODE_CONQUEST", Name="征服", Mark="Conquest0" }
    };
}

public class ModeInfo
{
    public string Id;
    public string Name;
    public string Mark;
}
