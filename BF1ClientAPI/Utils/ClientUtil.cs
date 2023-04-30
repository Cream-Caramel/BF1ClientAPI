using BF1ClientAPI.Client;

namespace BF1ClientAPI.Utils;

public static class ClientUtil
{
    /// <summary>
    /// 获取本地服务器图片链接
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string GetHostImageURL(string url)
    {
        return $"{Program.Host}\\images\\{url}";
    }

    /// <summary>
    /// 获取地图对应中文名称
    /// </summary>
    /// <param name="map"></param>
    /// <returns></returns>
    public static string GetMapChsName(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.Chinese;

        return string.Empty;
    }

    /// <summary>
    /// 获取地图对应预览图
    /// </summary>
    /// <param name="map"></param>
    /// <returns></returns>
    public static string GetMapImage(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.GetMapImage();

        return string.Empty;
    }

    /// <summary>
    /// 获取当前地图游戏模式
    /// </summary>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static string GetGameMode(string mode)
    {
        var result = ModeDB.AllModeInfo.Find(var => var.Mark == mode);
        if (result != null)
            return result.Chinese;

        return string.Empty;
    }

    /// <summary>
    /// 获取武器简短名称，用于踢人理由
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns></returns>
    public static string GetWeaponShortTxt(string weapon)
    {
        var result = WeaponDB.AllWeaponInfo.Find(var => var.English == weapon);
        if (result != null)
            return result.ShortName;

        return string.Empty;
    }

    /// <summary>
    /// 获取武器Guid
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns></returns>
    public static string GetWeaponGuid(string weapon)
    {
        var result = WeaponDB.AllWeaponInfo.Find(var => var.English == weapon);
        if (result != null)
            return result.Guid;

        return string.Empty;
    }

    /// <summary>
    /// 获取武器对应中文名称
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns></returns>
    public static string GetWeaponChsName(string weapon)
    {
        if (string.IsNullOrWhiteSpace(weapon))
            return string.Empty;

        if (weapon.Contains("_KBullet"))
            return "K 弹";

        if (weapon.Contains("_RGL_Frag"))
            return "步枪手榴弹（破片）";

        if (weapon.Contains("_RGL_Smoke"))
            return "步枪手榴弹（烟雾）";

        if (weapon.Contains("_RGL_HE"))
            return "步枪手榴弹（高爆）";

        var result = WeaponDB.AllWeaponInfo.Find(var => var.English == weapon);
        if (result != null)
            return result.Chinese;

        return string.Empty;
    }

    /// <summary>
    /// 获取武器对应图片路径
    /// </summary>
    /// <param name="weapon"></param>
    /// <param name="isGetWhite"></param>
    /// <returns></returns>
    public static string GetWeaponImagePath(string weapon, bool isGetWhite = false)
    {
        if (string.IsNullOrWhiteSpace(weapon))
            return string.Empty;

        var tempName = string.Empty;

        if (weapon.Contains("_KBullet"))
            tempName = "_KBullet";
        else if (weapon.Contains("_RGL_Frag"))
            tempName = "_RGL_Frag";
        else if (weapon.Contains("_RGL_Smoke"))
            tempName = "_RGL_Smoke";
        else if (weapon.Contains("_RGL_HE"))
            tempName = "_RGL_HE";

        // 如果 tempName 不为空，则使用 tempName 匹配，否则继续使用 englishName 匹配
        var result = WeaponDB.AllWeaponInfo.Find(var => var.English == (tempName != string.Empty ? tempName : weapon));
        if (result != null)
            return isGetWhite ? result.GetWeaponImage() : result.GetWeapon2Image();

        return string.Empty;
    }

    /// <summary>
    /// 获取小队的中文名称
    /// </summary>
    /// <param name="squadId"></param>
    /// <returns></returns>
    public static string GetSquadNameById(int squadId)
    {
        return squadId switch
        {
            0 => "无",
            1 => "苹果",
            2 => "奶油",
            3 => "查理",
            4 => "达夫",
            5 => "爱德华",
            6 => "弗莱迪",
            7 => "乔治",
            8 => "哈利",
            9 => "墨水",
            10 => "强尼",
            11 => "国王",
            12 => "伦敦",
            13 => "猿猴",
            14 => "疯子",
            15 => "橘子",
            _ => squadId.ToString(),
        };
    }

    /// <summary>
    /// 获取队伍1阵营中文名称
    /// </summary>
    /// <param name="map"></param>
    /// <returns></returns>
    public static string GetTeam1ChsName(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.Team1;

        return string.Empty;
    }

    /// <summary>
    /// 获取队伍2阵营中文名称
    /// </summary>
    /// <param name="map"></param>
    /// <returns></returns>
    public static string GetTeam2ChsName(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.Team2;

        return string.Empty;
    }

    /// <summary>
    /// 获取队伍1阵营图片路径
    /// </summary>
    /// <param name="map"></param>
    public static string GetTeam1Image(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.GetTeam1Image();

        return string.Empty;
    }

    /// <summary>
    /// 获取队伍2阵营图片路径
    /// </summary>
    /// <param name="map"></param>
    public static string GetTeam2Image(string map)
    {
        var result = MapDB.AllMapInfo.Find(var => var.English == map);
        if (result != null)
            return result.GetTeam2Image();

        return string.Empty;
    }

    /// <summary>
    /// 获取玩家当前兵种名称
    /// </summary>
    /// <param name="kit"></param>
    /// <returns></returns>
    public static string GetPlayerKitName(string kit)
    {
        var result = KitDB.AllKitInfo.Find(var => var.English == kit);
        if (result != null)
            return result.Chinese;

        return string.Empty;
    }

    /// <summary>
    /// 获取玩家当前兵种图片
    /// </summary>
    /// <param name="kit"></param>
    /// <param name="isGetWhite"></param>
    /// <returns></returns>
    public static string GetPlayerKitImage(string kit, bool isGetWhite = false)
    {
        var result = KitDB.AllKitInfo.Find(var => var.English == kit);
        if (result != null)
            return isGetWhite ? result.GetKitImage() : result.GetKit2Image();

        return string.Empty;
    }
}
