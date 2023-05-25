namespace BF1ClientAPI.Client;

public static class ModeDB
{
    /// <summary>
    /// Map Mode Data
    /// </summary>
    public readonly static List<ModeInfo> AllModeInfo = new()
    {
        new() { Id="ID_M_GAMEMODE_ZONECONTROL", Name="Supply Drop", Mark="ZoneControl0" },
        new() { Id="ID_M_GAMEMODE_AIRASSAULT", Name="Air Superiority", Mark="AirAssault0" },
        new() { Id="ID_M_GAMEMODE_TUGOFWAR", Name="Frontlines", Mark="TugOfWar0" },
        new() { Id="ID_M_GAMEMODE_DOMINATION", Name="Domination", Mark="Domination0" },
        new() { Id="ID_M_GAMEMODE_BREAKTHROUGH", Name="Shock Operations", Mark="Breakthrough0" },
        new() { Id="ID_M_GAMEMODE_RUSH", Name="Rush", Mark="Rush0" },
        new() { Id="ID_M_GAMEMODE_TEAMDEATHMATCH", Name="Team Deathmatch", Mark="TeamDeathMatch0" },
        new() { Id="ID_M_GAMEMODE_BREAKTHROUGHLARGE", Name="Operations", Mark="BreakthroughLarge0" },
        new() { Id="ID_M_GAMEMODE_POSSESSION", Name="War Pigeons", Mark="Possession0" },
        new() { Id="ID_M_GAMEMODE_CONQUEST", Name="Conquest", Mark="Conquest0" }
    };
}

public class ModeInfo
{
    public string Id;
    public string Name;
    public string Mark;
}
