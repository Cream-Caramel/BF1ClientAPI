using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ServerController : ControllerBase
{
    /// <summary>
    /// 获取当前服务器名称
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<ServerData> GetServerData()
    {
        var serverData = new ServerData();

        // 服务器名称
        serverData.Name = Server.GetServerName();
        // 服务器数字Id
        serverData.GameId = Server.GetGameId();
        // 服务器时间
        serverData.Time = Server.GetServerTime();
        // 服务器时间 - 字符串
        serverData.GameTime = GameUtil.GetMMSSStrBySecond(serverData.Time);

        // 服务器游戏模式
        serverData.GameMode = Server.GetGameMode();
        // 服务器游戏模式中文名称
        serverData.GameMode2 = ClientUtil.GetGameMode(serverData.GameMode);

        // 服务器地图名称
        serverData.MapName = Server.GetMapName();
        // 服务器地图中文名称
        serverData.MapName2 = ClientUtil.GetMapChsName(serverData.MapName);

        // 服务器地图预览图
        serverData.MapImage = ClientUtil.GetMapImage(serverData.MapName);

        // 队伍1
        serverData.Team1.Name = ClientUtil.GetTeam1Name(serverData.MapName);
        serverData.Team1.Image = ClientUtil.GetTeam1Image(serverData.MapName);
        // 队伍1分数
        serverData.Team1.MaxScore = Server.GetServerMaxScore();
        serverData.Team1.AllScore = Server.GetTeamScore(1);
        serverData.Team1.ScoreKill = Server.GetTeamKillScore(1);
        serverData.Team1.ScoreFlag = Server.GetTeamFlagScore(1);

        // 队伍2
        serverData.Team2.Name = ClientUtil.GetTeam2Name(serverData.MapName);
        serverData.Team2.Image = ClientUtil.GetTeam2Image(serverData.MapName);
        serverData.Team2.MaxScore = Server.GetServerMaxScore();
        // 队伍2分数
        serverData.Team2.AllScore = Server.GetTeamScore(2);
        serverData.Team2.ScoreKill = Server.GetTeamKillScore(2);
        serverData.Team2.ScoreFlag = Server.GetTeamFlagScore(2);

        return Ok(serverData);
    }
}
