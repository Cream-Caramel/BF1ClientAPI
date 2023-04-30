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

    public string Kit { get; set; }
    public string KitName { get; set; }
    public string KitImage { get; set; }
    public string KitImage2 { get; set; }

    public Weapon WeaponS0 { get; set; }
    public Weapon WeaponS1 { get; set; }
    public Weapon WeaponS2 { get; set; }
    public Weapon WeaponS3 { get; set; }
    public Weapon WeaponS4 { get; set; }
    public Weapon WeaponS5 { get; set; }
    public Weapon WeaponS6 { get; set; }
    public Weapon WeaponS7 { get; set; }
}

public class Weapon
{
    public string Kind { get; set; }
    public string Guid { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Image2 { get; set; }
}