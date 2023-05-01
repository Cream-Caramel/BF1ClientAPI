using BF1ClientAPI.Models;

namespace BF1ClientAPI.Utils;

public static class PlayerUtil
{
    /// <summary>
    /// 获取不同武器槽详情数据
    /// </summary>
    /// <param name="weapon"></param>
    /// <param name="kind"></param>
    /// <returns></returns>
    public static Weapon GetPlayerWeapon(string weapon, string kind)
    {
        var weaponInfo = ClientUtil.GetWeaponInfo(weapon);
        if (weaponInfo != null)
        {
            return new Weapon()
            {
                Kind = kind,
                Guid = weaponInfo.Guid,
                Id = weaponInfo.Id,
                Name = weaponInfo.Name,
                Image = weaponInfo.GetWeaponImage(),
                Image2 = weaponInfo.GetWeapon2Image()
            };
        }

        return new Weapon()
        {
            Kind = kind,
            Name = weapon
        };
    }

    /// <summary>
    /// 计算玩家KD
    /// </summary>
    /// <param name="kill">击杀数</param>
    /// <param name="dead">死亡数</param>
    /// <returns></returns>
    public static float GetPlayerKD(int kill, int dead)
    {
        if (kill == 0 && dead >= 0)
            return 0.0f;
        else if (kill > 0 && dead == 0)
            return kill;
        else
            return (float)kill / dead;
    }

    /// <summary>
    /// 计算玩家KPM，传入时间为秒
    /// </summary>
    /// <param name="kill">击杀数</param>
    /// <param name="second">秒</param>
    /// <returns></returns>
    public static float GetPlayerKPMBySecond(float kill, float second)
    {
        if (second <= 0.0f)
            return 0.0f;

        var ts = TimeSpan.FromSeconds(second);
        return kill / (float)ts.TotalMinutes;
    }
}
