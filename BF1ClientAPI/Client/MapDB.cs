using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class MapDB
{
    private const string AHU = "奥匈帝国";
    private const string GER = "德意志帝国";
    private const string OTM = "奥斯曼帝国";
    private const string ITA = "意大利王国";
    private const string UK = "大英帝国";
    private const string RM = "皇家海军陆战队";
    private const string USA = "美国";
    private const string FRA = "法国";
    private const string RUS = "俄罗斯帝国";
    private const string BOL = "苏联红军";

    /// <summary>
    /// 地图数据
    /// </summary>
    public readonly static List<MapInfo> AllMapInfo = new()
    {
        new() { Id="ID_M_LEVEL_MENU", Name="大厅菜单" },
        new() { Id="ID_M_MP_LEVEL_MOUNTAIN_FORT", Name="格拉巴山", Team1Name=ITA, Team2Name=AHU, Team1Image="ITA.png", Team2Image="AHU.png", Image="MP_MountainFort_LandscapeLarge-8a517533.jpg" },
        new() { Id="ID_M_MP_LEVEL_FOREST", Name="阿尔贡森林", Team1Name=USA, Team2Name=GER, Team1Image="USA.png", Team2Image="GER.png", Image="MP_Forest_LandscapeLarge-dfbbe910.jpg" },
        new() { Id="ID_M_MP_LEVEL_ITALIAN_COAST", Name="帝国边境", Team1Name=ITA, Team2Name=AHU, Team1Image="ITA.png", Team2Image="AHU.png", Image="MP_ItalianCoast_LandscapeLarge-1503eec7.jpg" },
        new() { Id="ID_M_MP_LEVEL_CHATEAU", Name="流血宴厅", Team1Name=USA, Team2Name=GER, Team1Image="USA.png", Team2Image="GER.png", Image="MP_Chateau_LandscapeLarge-244d5987.jpg" },
        new() { Id="ID_M_MP_LEVEL_SCAR", Name="圣康坦的伤痕", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Scar_LandscapeLarge-ee25fbd6.jpg" },
        new() { Id="ID_M_MP_LEVEL_DESERT", Name="西奈沙漠", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Desert_LandscapeLarge-d8f749da.jpg" },
        new() { Id="ID_M_MP_LEVEL_AMIENS", Name="亚眠", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Amiens_LandscapeLarge-e195589d.jpg" },
        new() { Id="ID_M_MP_LEVEL_SUEZ", Name="苏伊士", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Suez_LandscapeLarge-f630fc76.jpg" },
        new() { Id="ID_M_MP_LEVEL_FAO_FORTRESS", Name="法欧堡", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_FaoFortress_LandscapeLarge-cad1748e.jpg" },
        new() { Id="ID_M_MP_LEVEL_GIANT", Name="庞然暗影", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Giant_LandscapeLarge-dd0b93ef.jpg" },
        new() { Id="ID_M_MP_LEVEL_FIELDS", Name="苏瓦松", Team1Name=FRA, Team2Name=GER, Team1Image="FRA.png", Team2Image="GER.png", Image="MP_Fields_LandscapeLarge-5f53ddc4.jpg" },
        new() { Id="ID_M_MP_LEVEL_GRAVEYARD", Name="决裂", Team1Name=FRA, Team2Name=GER, Team1Image="FRA.png", Team2Image="GER.png", Image="MP_Graveyard_LandscapeLarge-bd1012e6.jpg" },
        new() { Id="ID_M_MP_LEVEL_UNDERWORLD", Name="法乌克斯要塞", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Underworld_LandscapeLarge-b6c5c7e7.jpg" },
        new() { Id="ID_M_MP_LEVEL_VERDUN", Name="凡尔登高地", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Verdun_LandscapeLarge-1a364063.jpg" },
        new() { Id="ID_M_MP_LEVEL_TRENCH", Name="尼维尔之夜", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Trench_LandscapeLarge-dbd1248f.jpg" },
        new() { Id="ID_M_MP_LEVEL_SHOVELTOWN", Name="攻占托尔", Team1Name=GER, Team2Name=FRA, Team1Image="GER.png", Team2Image="FRA.png", Image="MP_Shoveltown_LandscapeLarge-d0aa5920.jpg" },
        new() { Id="ID_M_MP_LEVEL_BRIDGE", Name="勃鲁希洛夫关口", Team1Name=RUS, Team2Name=AHU, Team1Image="RUS.png", Team2Image="AHU.png", Image="MP_Bridge_LandscapeLarge-5b7f1b62.jpg" },
        new() { Id="ID_M_MP_LEVEL_ISLANDS", Name="阿尔比恩", Team1Name=GER, Team2Name=RUS, Team1Image="GER.png", Team2Image="RUS.png", Image="MP_Islands_LandscapeLarge-c9d8272b.jpg" },
        new() { Id="ID_M_MP_LEVEL_RAVINES", Name="武普库夫山口", Team1Name=AHU, Team2Name=RUS, Team1Image="AHU.png", Team2Image="RUS.png", Image="MP_Ravines_LandscapeLarge-1fe0d3f6.jpg" },
        new() { Id="ID_M_MP_LEVEL_VALLEY", Name="加利西亚", Team1Name=RUS, Team2Name=AHU, Team1Image="RUS.png", Team2Image="AHU.png", Image="MP_Valley_LandscapeLarge-8dc1c7ca.jpg" },
        new() { Id="ID_M_MP_LEVEL_TSARITSYN", Name="察里津", Team1Name=BOL, Team2Name=RUS, Team1Image="BOL.png", Team2Image="RUS.png", Image="MP_Tsaritsyn_LandscapeLarge-2dbd3bf5.jpg" },
        new() { Id="ID_M_MP_LEVEL_VOLGA", Name="窝瓦河", Team1Name=BOL, Team2Name=RUS, Team1Image="BOL.png", Team2Image="RUS.png", Image="MP_Volga_LandscapeLarge-6ac49c25.jpg" },
        new() { Id="ID_M_MP_LEVEL_BEACHHEAD", Name="海丽丝岬", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Beachhead_LandscapeLarge-5a13c655.jpg" },
        new() { Id="ID_M_MP_LEVEL_HARBOR", Name="泽布吕赫", Team1Name=RM, Team2Name=GER, Team1Image="RM.png", Team2Image="GER.png", Image="MP_Harbor_LandscapeLarge-d382c7ea.jpg" },
        new() { Id="ID_M_MP_LEVEL_NAVAL", Name="黑尔戈兰湾", Team1Name=RM, Team2Name=GER, Team1Image="RM.png", Team2Image="GER.png", Image="MP_Naval_LandscapeLarge-dc2e8daf.jpg" },
        new() { Id="ID_M_MP_LEVEL_RIDGE", Name="阿奇巴巴", Team1Name=UK, Team2Name=OTM, Team1Image="UK.png", Team2Image="OTM.png", Image="MP_Ridge_LandscapeLarge-8c057a19.jpg" },
        new() { Id="ID_M_MP_LEVEL_OFFENSIVE", Name="索姆河", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Offensive_LandscapeLarge-6dabdea3.jpg" },
        new() { Id="ID_M_MP_LEVEL_HELL", Name="帕斯尚尔", Team1Name=UK, Team2Name=GER, Team1Image="UK.png", Team2Image="GER.png", Image="MP_Hell_LandscapeLarge-7176911c.jpg" },
        new() { Id="ID_M_MP_LEVEL_RIVER", Name="卡波雷托", Team1Name=AHU, Team2Name=ITA, Team1Image="AHU.png", Team2Image="ITA.png", Image="MP_River_LandscapeLarge-21443ae9.jpg" },
        new() { Id="ID_M_MP_LEVEL_ALPS", Name="剃刀边缘", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Alps_LandscapeLarge-7ab30e3e.jpg" },
        new() { Id="ID_M_MP_LEVEL_BLITZ", Name="伦敦的呼唤：夜袭", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_Blitz_LandscapeLarge-5e26212f.jpg" },
        new() { Id="ID_M_MP_LEVEL_LONDON", Name="伦敦的呼唤：灾祸", Team1Name=GER, Team2Name=UK, Team1Image="GER.png", Team2Image="UK.png", Image="MP_London_LandscapeLarge-0b51fe46.jpg" }
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
