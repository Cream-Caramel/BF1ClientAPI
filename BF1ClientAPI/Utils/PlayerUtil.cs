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

        return null;
    }
}
