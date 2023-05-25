using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class MapDB
{
    private const string AHU = "Austro-Hungarian Empire";
    private const string GER = "German Empire";
    private const string OTM = "Ottoman Empire";
    private const string ITA = "Kingdom of Italy";
    private const string UK = "British Empire";
    private const string RM = "Royal Marines";
    private const string USA = "U.S.A.";
    private const string FRA = "France";
    private const string RUS = "Russian Empire";
    private const string BOL = "Red Army";

    /// <summary>
    /// Map Data
    /// </summary>
    public readonly static List<MapInfo> AllMapInfo = new()
    {
        new() { Id="ID_M_LEVEL_MENU", Name="Main Menu" },
        new() { Id="ID_M_MP_LEVEL_MOUNTAIN_FORT", Name="Monte Grappa", Team1Name=ITA, Team2Name=AHU, Team1Image="ITA.png", Team2Image="AHU.png", Image="MP_MountainFort_LandscapeLarge-8a517533.jpg" },
        new() { Id="ID_M_MP_LEVEL_FOREST", Name="Argonne Forest", Team1Name=USA, Team2Name=GER, Team1Image="USA.png", Team2Image="GER.png", Image="MP_Forest_LandscapeLarge-dfbbe910.jpg" },
        new() { Id="ID_M_MP_LEVEL_ITALIAN_COAST", Name="Empire's Edge", Team1Name=ITA, Team2Name=AHU, Team1Image="ITA.png", Team2Image="AHU.png", Image="MP_ItalianCoast_LandscapeLarge-1503eec7.jpg" },
        new() { Id="ID_M_MP_LEVEL_CHATEAU", Name="Ballroom Blitz", Team1Name=USA, Team2Name=GER, Team1Image="USA.png", Team2Image="GER.png", Image="MP_Chateau_LandscapeLarge-244d5987.jpg" },
        new() { Id="ID_M_MP_LEVEL_SCAR", Name="St. Quentin Scar", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Scar_LandscapeLarge-ee25fbd6.jpg" },
        new() { Id="ID_M_MP_LEVEL_DESERT", Name="Sinai Desert", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Desert_LandscapeLarge-d8f749da.jpg" },
        new() { Id="ID_M_MP_LEVEL_AMIENS", Name="Amiens", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Amiens_LandscapeLarge-e195589d.jpg" },
        new() { Id="ID_M_MP_LEVEL_SUEZ", Name="Suez", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Suez_LandscapeLarge-f630fc76.jpg" },
        new() { Id="ID_M_MP_LEVEL_FAO_FORTRESS", Name="Fao Fortress", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_FaoFortress_LandscapeLarge-cad1748e.jpg" },
        new() { Id="ID_M_MP_LEVEL_GIANT", Name="Giant's Shadow", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Giant_LandscapeLarge-dd0b93ef.jpg" },
        new() { Id="ID_M_MP_LEVEL_FIELDS", Name="Soissons", Team1Name=FRA, Team2Name=GER, Team1Image="FRA.png", Team2Image="GER.png", Image="MP_Fields_LandscapeLarge-5f53ddc4.jpg" },
        new() { Id="ID_M_MP_LEVEL_GRAVEYARD", Name="Rupture", Team1Name=FRA, Team2Name=GER, Team1Image="FRA.png", Team2Image="GER.png", Image="MP_Graveyard_LandscapeLarge-bd1012e6.jpg" },
        new() { Id="ID_M_MP_LEVEL_UNDERWORLD", Name="Fort de Vaux", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Underworld_LandscapeLarge-b6c5c7e7.jpg" },
        new() { Id="ID_M_MP_LEVEL_VERDUN", Name="Verdun", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Verdun_LandscapeLarge-1a364063.jpg" },
        new() { Id="ID_M_MP_LEVEL_TRENCH", Name="Nivelle Nights", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Trench_LandscapeLarge-dbd1248f.jpg" },
        new() { Id="ID_M_MP_LEVEL_SHOVELTOWN", Name="Prise de Tahure", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Shoveltown_LandscapeLarge-d0aa5920.jpg" },
        new() { Id="ID_M_MP_LEVEL_BRIDGE", Name="Brusilov Keep", Team1Name=RUS, Team2Name=AHU, Team1Image="RUS.png", Team2Image="AHU.png", Image="MP_Bridge_LandscapeLarge-5b7f1b62.jpg" },
        new() { Id="ID_M_MP_LEVEL_ISLANDS", Name="Albion", Team1Name=GER, Team2Name=RUS, Team1Image="GER.png", Team2Image="RUS.png", Image="MP_Islands_LandscapeLarge-c9d8272b.jpg" },
        new() { Id="ID_M_MP_LEVEL_RAVINES", Name="Łupków Pass", Team1Name=AHU, Team2Name=RUS, Team1Image="AHU.png", Team2Image="RUS.png", Image="MP_Ravines_LandscapeLarge-1fe0d3f6.jpg" },
        new() { Id="ID_M_MP_LEVEL_VALLEY", Name="Galicia", Team1Name=RUS, Team2Name=AHU, Team1Image="RUS.png", Team2Image="AHU.png", Image="MP_Valley_LandscapeLarge-8dc1c7ca.jpg" },
        new() { Id="ID_M_MP_LEVEL_TSARITSYN", Name="Tsaritsyn", Team1Name=BOL, Team2Name=RUS, Team1Image="BOL.png", Team2Image="RUS.png", Image="MP_Tsaritsyn_LandscapeLarge-2dbd3bf5.jpg" },
        new() { Id="ID_M_MP_LEVEL_VOLGA", Name="Volga River", Team1Name=BOL, Team2Name=RUS, Team1Image="BOL.png", Team2Image="RUS.png", Image="MP_Volga_LandscapeLarge-6ac49c25.jpg" },
        new() { Id="ID_M_MP_LEVEL_BEACHHEAD", Name="Cape Helles", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Beachhead_LandscapeLarge-5a13c655.jpg" },
        new() { Id="ID_M_MP_LEVEL_HARBOR", Name="Zeebrugge", Team1Name=RM, Team2Name=GER, Team1Image="RM.png", Team2Image="GER.png", Image="MP_Harbor_LandscapeLarge-d382c7ea.jpg" },
        new() { Id="ID_M_MP_LEVEL_NAVAL", Name="Heligoland Blight", Team1Name=RM, Team2Name=GER, Team1Image="RM.png", Team2Image="GER.png", Image="MP_Naval_LandscapeLarge-dc2e8daf.jpg" },
        new() { Id="ID_M_MP_LEVEL_RIDGE", Name="Achibaba", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Ridge_LandscapeLarge-8c057a19.jpg" },
        new() { Id="ID_M_MP_LEVEL_OFFENSIVE", Name="Somme", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Offensive_LandscapeLarge-6dabdea3.jpg" },
        new() { Id="ID_M_MP_LEVEL_HELL", Name="帕斯尚尔", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Hell_LandscapeLarge-7176911c.jpg" },
        new() { Id="ID_M_MP_LEVEL_RIVER", Name="Caporetto", Team1Name=AHU, Team2Name=ITA, Team1Image="AHU.png", Team2Image="ITA.png", Image="MP_River_LandscapeLarge-21443ae9.jpg" },
        new() { Id="ID_M_MP_LEVEL_ALPS", Name="Razor's Edge", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Alps_LandscapeLarge-7ab30e3e.jpg" },
        new() { Id="ID_M_MP_LEVEL_BLITZ", Name="Call of London: Blitz", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Blitz_LandscapeLarge-5e26212f.jpg" },
        new() { Id="ID_M_MP_LEVEL_LONDON", Name="Call of London: Night Raid", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_London_LandscapeLarge-0b51fe46.jpg" }
    };
}

public class MapInfo
{
    public string Id;
    public string Name;
    public string Team1Name;
    public string Team2Name;
    public string Team1Image;
    public string Team2Image;
    public string Image;

    public string GetTeam1Image()
    {
        return ClientUtil.GetHostImageURL($"Teams\\{Team1Image}");
    }

    public string GetTeam2Image()
    {
        return ClientUtil.GetHostImageURL($"Teams\\{Team2Image}");
    }

    public string GetMapImage()
    {
        return ClientUtil.GetHostImageURL($"Maps\\{Image}");
    }
}
