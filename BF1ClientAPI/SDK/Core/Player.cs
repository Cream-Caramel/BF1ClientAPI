using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.SDK;

public static class Player
{
    /// <summary>
    /// 服务器最大玩家数量
    /// </summary>
    private const int MaxPlayer = 74;

    /// <summary>
    /// 获取自己信息
    /// </summary>
    /// <returns></returns>
    public static LocalPlayer GetLocalPlayer()
    {
        var baseAddress = Obfuscation.GetLocalPlayer();
        if (!Memory.IsValid(baseAddress))
            return null;

        return new LocalPlayer()
        {
            Name = Memory.ReadString(baseAddress + 0x40, 64),
            PersonaId = Memory.Read<long>(baseAddress + 0x38),
            FullName = Memory.ReadString(baseAddress + 0x2156, 64)
        };
    }

    /// <summary>
    /// 获取游戏内玩家列表信息
    /// </summary>
    /// <returns></returns>
    public static List<GamePlayer> GetGamePlayerList()
    {
        var _playerList = new List<GamePlayer>();
        var _weaponSlot = new string[8] { "", "", "", "", "", "", "", "" };

        ////////////////////// 玩家数据 //////////////////////

        for (int i = 0; i < MaxPlayer; i++)
        {
            var baseAddress = Obfuscation.GetPlayerById(i);
            // 过滤无效数据
            if (!Memory.IsValid(baseAddress))
                continue;

            // 玩家数字Id
            var personaId = Memory.Read<long>(baseAddress + 0x38);
            if (personaId == 0)
                continue;

            // 玩家标记，用于和得分板数据匹配（按照玩家进入服务器顺序）
            var mark = Memory.Read<byte>(baseAddress + 0x1D7C);
            // 玩家队伍Id，0/1/2
            var teamId = Memory.Read<int>(baseAddress + 0x1C34);
            // 是否为观战玩家，bool类型（0x01为观战，否则不是）
            var spectator = Memory.Read<byte>(baseAddress + 0x1C31);
            // 小队Id，枚举值
            var squadId = Memory.Read<int>(baseAddress + 0x1E50);
            // 玩家队标
            var clan = Memory.ReadString(baseAddress + 0x2151, 8);
            // 玩家名称
            var name = Memory.ReadString(baseAddress + 0x40, 64);

            // 玩家兵种
            var offset = Memory.Read<long>(baseAddress + 0x11A8);
            var kit = Memory.ReadString(Memory.Read<long>(offset + 0x28), 64);

            // 清空武器槽
            for (int j = 0; j < 8; j++)
                _weaponSlot[j] = string.Empty;

            // 判断玩家是步兵还是进入了载具
            var pClientVehicleEntity = Memory.Read<long>(baseAddress + 0x1D38);
            if (Memory.IsValid(pClientVehicleEntity))
            {
                // 载具

                // 判断载具生命值指针是否有效
                var pVehicleHealthComponent = Memory.Read<long>(pClientVehicleEntity + 0x1D0);
                if (!Memory.IsValid(pVehicleHealthComponent))
                {
                    // 玩家死亡后，兵种信息不会清除，这里要手动清除
                    kit = string.Empty;
                    goto NO_WEAPON;
                }

                var health = Memory.Read<float>(pVehicleHealthComponent + 0x40);
                // 判断载具是否死亡
                if (health <= 0)
                {
                    // 玩家死亡后，兵种信息不会清除，这里要手动清除
                    kit = string.Empty;
                    goto NO_WEAPON;
                }

                // 载具实体数据指针
                var pVehicleEntityData = Memory.Read<long>(pClientVehicleEntity + 0x30);
                // 读取载具名称
                _weaponSlot[0] = Memory.ReadString(Memory.Read<long>(pVehicleEntityData + 0x2F8), 64);

                // 载具具体名称（弱指针，不稳定）
                for (int j = 0; j < 100; j++)
                {
                    var tempMultiUnlockAsset = Memory.Read<long>(baseAddress + j * 0x8 + 0x13A8);
                    if (!Memory.IsValid(tempMultiUnlockAsset))
                        continue;

                    var vtable = Memory.Read<long>(tempMultiUnlockAsset);
                    if (vtable == 0x142B8CFA8)
                    {
                        var tempVehicleName = Memory.ReadString(Memory.Read<long>(tempMultiUnlockAsset + 0x20), 64);
                        if (GameUtil.FixVehicleKits(_weaponSlot[0], tempVehicleName))
                        {
                            _weaponSlot[1] = tempVehicleName;
                            break;
                        }
                    }
                }
            }
            else
            {
                // 玩家
                var pClientSoldierEntity = Memory.Read<long>(baseAddress + 0x1D48);
                if (!Memory.IsValid(pClientSoldierEntity))
                {
                    // 玩家死亡后，兵种信息不会清除，这里要手动清除
                    kit = string.Empty;
                    goto NO_WEAPON;
                }

                // 判断玩家生命值指针是否有效
                var pSoldierHealthComponent = Memory.Read<long>(pClientSoldierEntity + 0x1D0);
                if (!Memory.IsValid(pSoldierHealthComponent))
                {
                    // 玩家死亡后，兵种信息不会清除，这里要手动清除
                    kit = string.Empty;
                    goto NO_WEAPON;
                }

                // 判断玩家是否死亡
                var health = Memory.Read<float>(pSoldierHealthComponent + 0x40);
                if (health <= 0)
                {
                    // 玩家死亡后，兵种信息不会清除，这里要手动清除
                    kit = string.Empty;
                    goto NO_WEAPON;
                }

                // 获取玩家武器组件
                var pClientSoldierWeaponComponent = Memory.Read<long>(pClientSoldierEntity + 0x698);
                var m_handler = Memory.Read<long>(pClientSoldierWeaponComponent + 0x8A8);
                // 获取玩家不同武器槽位的武器名称
                for (int j = 0; j < 8; j++)
                {
                    var offset0 = Memory.Read<long>(m_handler + j * 0x8);
                    offset0 = Memory.Read<long>(offset0 + 0x4A30);
                    offset0 = Memory.Read<long>(offset0 + 0x20);
                    offset0 = Memory.Read<long>(offset0 + 0x38);
                    offset0 = Memory.Read<long>(offset0 + 0x20);
                    _weaponSlot[j] = Memory.ReadString(offset0, 64);
                }
            }

        NO_WEAPON:
            // Filter duplicate players and populate data
            var index = _playerList.FindIndex(val => val.PersonaId == personaId);
            if (index == -1)
            {
                _playerList.Add(new()
                {
                    Mark = mark,
                    TeamId = teamId,
                    Spectator = spectator,
                    IsSpectator = GameUtil.IsSpectator(spectator),
                    Clan = clan,
                    Name = name,
                    PersonaId = personaId,

                    SquadId = squadId,
                    SquadName = ClientUtil.GetSquadNameById(squadId),

                    Kit = kit,
                    KitName = ClientUtil.GetPlayerKitName(kit),
                    KitImage = ClientUtil.GetPlayerKitImage(kit, true),
                    KitImage2 = ClientUtil.GetPlayerKitImage(kit),

                    // 0 Main Weapon
                    WeaponS0 = PlayerUtil.GetPlayerWeapon(_weaponSlot[0], "MAIN"),
                    // 1 Sidearm Weapon
                    WeaponS1 = PlayerUtil.GetPlayerWeapon(_weaponSlot[1], "SIDEARM"),
                    // 2 First Gadget Slot
                    WeaponS2 = PlayerUtil.GetPlayerWeapon(_weaponSlot[2], "GADGET1"),
                    // 3 Mask Slot (Gas)
                    WeaponS3 = PlayerUtil.GetPlayerWeapon(_weaponSlot[3], "MASK"),
                    // 4 V Type Selector Fire
                    WeaponS4 = PlayerUtil.GetPlayerWeapon(_weaponSlot[4], "VTYPE"),
                    // 5 Second Gadget Slot
                    WeaponS5 = PlayerUtil.GetPlayerWeapon(_weaponSlot[5], "GADGET2"),
                    // 6 Grenade
                    WeaponS6 = PlayerUtil.GetPlayerWeapon(_weaponSlot[6], "GRENADE"),
                    // 7 Melee Weapon
                    WeaponS7 = PlayerUtil.GetPlayerWeapon(_weaponSlot[7], "MELEE"),
                });
            }
        }

        ////////////////////// Scoreboard Data //////////////////////

        // Get scoreboard pointer (chain table)
        var pClientScoreBA = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x39EB8D8);
        pClientScoreBA = Memory.Read<long>(pClientScoreBA + 0x68);

        for (int i = 0; i < MaxPlayer; i++)
        {
            pClientScoreBA = Memory.Read<long>(pClientScoreBA);
            var pClientScoreOffset = Memory.Read<long>(pClientScoreBA + 0x10);
            if (!Memory.IsValid(pClientScoreOffset))
                continue;

            // Get scoreboard data
            var mark = Memory.Read<byte>(pClientScoreOffset + 0x300);
            var rank = Memory.Read<int>(pClientScoreOffset + 0x304);
            var kill = Memory.Read<int>(pClientScoreOffset + 0x308);
            var dead = Memory.Read<int>(pClientScoreOffset + 0x30C);
            var score = Memory.Read<int>(pClientScoreOffset + 0x314);

            // Populate scoreboard data
            var player = _playerList.Find(val => val.Mark == mark);
            if (player != null)
            {
                player.Rank = rank;
                player.Kill = kill;
                player.Dead = dead;
                player.Score = score;
            }
        }

        return _playerList;
    }
}