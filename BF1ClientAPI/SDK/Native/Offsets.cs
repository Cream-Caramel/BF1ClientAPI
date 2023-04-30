namespace BF1ClientAPI.SDK;

public static class Offsets
{
    public const long OFFSET_CLIENTGAMECONTEXT = 0x1437F7758;
    public const long OFFSET_GAMERENDERER = 0x1439E6D08;
    public const long OFFSET_OBFUSCATIONMGR = 0x14351D058;
    public const long OFFSET_DXRENDERER = 0x1439E75F8;

    ////////////////////////////////////////////////////////////////////

    public const int Player_PersonaId = 0x38;       // long
    public const int Player_Name = 0x40;            // string   64

    public const int Player_Spectator = 0x1C31;     // byte
    public const int Player_TeamId = 0x1C34;        // int      0/1/2
    public const int Player_Mark = 0x1D7C;          // byte
    public const int Player_SquadId = 0x1E50;       // int
    public const int Player_Clan = 0x2151;          // string   64
    public const int Player_FullName = 0x2156;      // string   64

    public const int Player_PKit = 0x11A8;          // long pointer
    public const int Player_PKit_Name = 0x28;       // string

    ////////////////////////////////////////////////////////////////////

    public const long OFFSET_SCORE = 0x39EB8D8;
    public const int Score_Offset1 = 0x68;
    public const int Score_Offset2 = 0x10;

    // 0x39EB8D8 0x68 0 0x10
    public const int Score_Mark = 0x300;            // byte
    public const int Score_Rank = 0x304;            // int
    public const int Score_Kill = 0x308;            // int
    public const int Score_Dead = 0x30C;            // int
    public const int Score_Score = 0x314;           // int

    ////////////////////////////////////////////////////////////////////

    public const int Server_Name = 0x3A1F3F8;
    public const int Server_Id = 0x37FF1A0;

    public const int Server_Time = 0x3A31138;
    public const int Server_Score = 0x3A0FC40;
}
