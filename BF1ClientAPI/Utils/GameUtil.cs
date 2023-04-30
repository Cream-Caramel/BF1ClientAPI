namespace BF1ClientAPI.Utils;

public static class GameUtil
{
    /// <summary>
    /// 修复载具分类
    /// </summary>
    /// <param name="name1"></param>
    /// <param name="name2"></param>
    /// <returns></returns>
    public static bool FixVehicleKits(string name1, string name2)
    {
        switch (name1)
        {
            // 巡航坦克
            case "ID_P_VNAME_MARKV":
                if (name2 == "U_GBR_MarkV_Package_Mortar" || name2 == "U_GBR_MarkV_Package_AntiTank" || name2 == "U_GBR_MarkV_Package_SquadSupport")
                    return true;
                else
                    return false;
            // 重型坦克
            case "ID_P_VNAME_A7V":
                if (name2 == "U_GER_A7V_Package_Assault" || name2 == "U_GER_A7V_Package_Breakthrough" || name2 == "U_GER_A7V_Package_Flamethrower")
                    return true;
                else
                    return false;
            // 轻型坦克
            case "ID_P_VNAME_FT17":
                if (name2 == "U_FRA_FT_Package_37mm" || name2 == "U_FRA_FT_Package_20mm" || name2 == "U_FRA_FT_Package_75mm")
                    return true;
                else
                    return false;
            // 火炮装甲车
            case "ID_P_VNAME_ARTILLERYTRUCK":
                if (name2 == "U_GBR_PierceArrow_Package_Artillery" || name2 == "U_GBR_PierceArrow_Package_AntiAircraft" || name2 == "U_GBR_PierceArrow_Package_Mortar")
                    return true;
                else
                    return false;
            // 攻击坦克
            case "ID_P_VNAME_STCHAMOND":
                if (name2 == "U_FRA_StChamond_Package_Assault" || name2 == "U_FRA_StChamond_Package_Gas" || name2 == "U_FRA_StChamond_Package_Standoff")
                    return true;
                else
                    return false;
            // 突袭装甲车
            case "ID_P_VNAME_ASSAULTTRUCK":
                if (name2 == "U_RU_PutilovGarford_Package_AssaultGun" || name2 == "U_RU_PutilovGarford_Package_AntiVehicle" || name2 == "U_RU_PutilovGarford_Package_Recon")
                    return true;
                else
                    return false;
            // 攻击机
            case "ID_P_VNAME_HALBERSTADT":
            case "ID_P_VNAME_BRISTOL":
            case "ID_P_VNAME_SALMSON":
            case "ID_P_VNAME_RUMPLER":
                if (name2 == "U_2Seater_Package_GroundSupport" || name2 == "U_2Seater_Package_TankHunter" || name2 == "U_2Seater_Package_AirshipBuster")
                    return true;
                else
                    return false;
            // 轰炸机
            case "ID_P_VNAME_GOTHA":
            case "ID_P_VNAME_CAPRONI":
            case "ID_P_VNAME_DH10":
            case "ID_P_VNAME_HBG1":
                if (name2 == "U_Bomber_Package_Barrage" || name2 == "U_Bomber_Package_Firestorm" || name2 == "U_Bomber_Package_Torpedo")
                    return true;
                else
                    return false;
            // 战斗机
            case "ID_P_VNAME_SPAD":
            case "ID_P_VNAME_SOPWITH":
            case "ID_P_VNAME_DR1":
            case "ID_P_VNAME_ALBATROS":
                if (name2 == "U_Scout_Package_Dogfighter" || name2 == "U_Scout_Package_BomberKiller" || name2 == "U_Scout_Package_TrenchFighter")
                    return true;
                else
                    return false;
            // 重型轰炸机
            case "ID_P_VNAME_ILYAMUROMETS":
                if (name2 == "U_HeavyBomber_Package_Strategic" || name2 == "U_HeavyBomber_Package_Demolition" || name2 == "U_HeavyBomber_Package_Support")
                    return true;
                else
                    return false;
            // 飞船
            case "ID_P_VNAME_ASTRATORRES":
                if (name2 == "U_CoastalAirship_Package_Observation" || name2 == "U_CoastalAirship_Package_Raider")
                    return true;
                else
                    return false;
            // 驱逐舰
            case "ID_P_VNAME_HMS_LANCE":
                if (name2 == "U_HMS_Lance_Package_Destroyer" || name2 == "U_HMS_Lance_Package_Minelayer")
                    return true;
                else
                    return false;
            default:
                return false;
        }
    }
}
