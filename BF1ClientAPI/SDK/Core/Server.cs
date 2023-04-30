﻿namespace BF1ClientAPI.SDK;

public static class Server
{
    /// <summary>
    /// 获取服务器名称
    /// </summary>
    /// <returns></returns>
    public static string GetServerName()
    {
        long pointer = Memory.Read<long>(Memory.Bf1ProBaseAddress + Offsets.Server_Name);
        pointer = Memory.Read<long>(pointer + 0x30);

        return Memory.ReadString(pointer, 64);
    }

    /// <summary>
    /// 获取服务器数字Id
    /// </summary>
    /// <returns></returns>
    public static long GetGameId()
    {
        long pointer = Memory.Read<long>(Memory.Bf1ProBaseAddress + Offsets.Server_Id);

        return Memory.Read<long>(pointer + 0x418);
    }

    /// <summary>
    /// 获取服务器地图名称
    /// </summary>
    /// <returns></returns>
    public static string GetMapName()
    {
        long pointer = Memory.Read<long>(Offsets.OFFSET_CLIENTGAMECONTEXT);
        pointer = Memory.Read<long>(pointer + 0x30);
        pointer = Memory.Read<long>(pointer + 0x18);
        pointer = Memory.Read<long>(pointer + 0xB0);

        return Memory.ReadString(pointer, 64);
    }

    /// <summary>
    /// 获取服务器游戏模式
    /// </summary>
    /// <returns></returns>
    public static string GetGameMode()
    {
        long pointer = Memory.Read<long>(Offsets.OFFSET_CLIENTGAMECONTEXT);
        pointer = Memory.Read<long>(pointer + 0x30);
        pointer = Memory.Read<long>(pointer + 0x30);
        pointer = Memory.Read<long>(pointer + 0x08);

        return Memory.ReadString(pointer, 64);
    }

    /// <summary>
    /// 获取服务器时间
    /// </summary>
    /// <returns></returns>
    public static float GetServerTime()
    {
        long pointer = Memory.Read<long>(Memory.Bf1ProBaseAddress + Offsets.Server_Time);
        pointer = Memory.Read<long>(pointer + 0x20);
        pointer = Memory.Read<long>(pointer + 0x38);
        pointer = Memory.Read<long>(pointer + 0x58);

        return Memory.Read<float>(pointer + 0x78);
    }

    /// <summary>
    /// 获取服务器分数指针
    /// </summary>
    /// <returns></returns>
    public static long GetServerScorePtr()
    {
        long pointer = Memory.Read<long>(Memory.Bf1ProBaseAddress + Offsets.Server_Score);
        pointer = Memory.Read<long>(pointer + 0x58);
        pointer = Memory.Read<long>(pointer + 0x18);

        return Memory.Read<long>(pointer + 0x08);
    }

    /// <summary>
    /// 获取服务器最大比分
    /// </summary>
    /// <returns></returns>
    public static int GetServerMaxScore()
    {
        return Memory.Read<int>(GetServerScorePtr() + 0x120);
    }

    /// <summary>
    /// 获取服务器队伍分数
    /// </summary>
    /// <returns></returns>
    public static int GetTeamScore(int teamId)
    {
        if (teamId == 1)
            return Memory.Read<int>(GetServerScorePtr() + 0xE8);
        else if (teamId == 2)
            return Memory.Read<int>(GetServerScorePtr() + 0x118);
        else
            return 0;
    }

    /// <summary>
    /// 获取服务器队伍从击杀获取得分
    /// </summary>
    /// <returns></returns>
    public static int GetTeamKillScore(int teamId)
    {
        if (teamId == 1)
            return Memory.Read<int>(GetServerScorePtr() + 0x230);
        else if (teamId == 2)
            return Memory.Read<int>(GetServerScorePtr() + 0x238);
        else
            return 0;
    }

    /// <summary>
    /// 获取服务器队伍从旗帜获取得分
    /// </summary>
    /// <returns></returns>
    public static int GetTeamFlagScore(int teamId)
    {
        if (teamId == 1)
            return Memory.Read<int>(GetServerScorePtr() + 0x250);
        else if (teamId == 2)
            return Memory.Read<int>(GetServerScorePtr() + 0x258);
        else
            return 0;
    }
}
