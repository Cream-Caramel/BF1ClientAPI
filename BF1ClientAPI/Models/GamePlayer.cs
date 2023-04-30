using BF1ClientAPI.Client;

namespace BF1ClientAPI.Models;

public class GamePlayer
{
    public byte Mark { get; set; }
    public int TeamId { get; set; }
    public byte Spectator { get; set; }
    public bool IsSpectator { get; set; }
    public string Clan { get; set; }
    public string Name { get; set; }
    public long PersonaId { get; set; }

    public int SquadId { get; set; }
    public string SquadName { get; set; }

    public int Rank { get; set; }
    public int Kill { get; set; }
    public int Dead { get; set; }
    public int Score { get; set; }

    public float KD { get; set; }
    public float KPM { get; set; }

    public float LifeKD { get; set; }
    public float LifeKPM { get; set; }
    public int LifeTime { get; set; }
    public int LifeStar { get; set; }

    public string Kit { get; set; }
    public string KitName { get; set; }
    public string KitImage { get; set; }

    public WeaponInfo WeaponS0 { get; set; }
    public WeaponInfo WeaponS1 { get; set; }
    public WeaponInfo WeaponS2 { get; set; }
    public WeaponInfo WeaponS3 { get; set; }
    public WeaponInfo WeaponS4 { get; set; }
    public WeaponInfo WeaponS5 { get; set; }
    public WeaponInfo WeaponS6 { get; set; }
    public WeaponInfo WeaponS7 { get; set; }
}