using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// Servers
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class ServerController : ControllerBase
{
    /// <summary>
    /// Get current server data
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get server related data for Battlefield 1 currently joined the server
    /// 
    /// Conquest mode can get server time and score information, due to weak pointers, there is a low probability of failure to get them.
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<ServerData> GetServerData()
    {
        var serverData = new ServerData
        {
            // ServerName
            Name = Server.GetServerName(),
            // GameId
            GameId = Server.GetGameId(),
            // ServerTime
            Time = Server.GetServerTime(),
            // GameMode
            GameMode = Server.GetGameMode(),
            // MapName
            MapName = Server.GetMapName()
        };

        // Server Time - String
        serverData.GameTime = GameUtil.GetMMSSStrBySecond(serverData.Time);
        // Pretty Game Mode Name
        serverData.GameMode2 = ClientUtil.GetGameMode(serverData.GameMode);
        // Pretty Map Name
        serverData.MapName2 = ClientUtil.GetMapChsName(serverData.MapName);
        // Map Preview
        serverData.MapImage = ClientUtil.GetMapImage(serverData.MapName);

        // Team 1
        serverData.Team1.Name = ClientUtil.GetTeam1Name(serverData.MapName);
        serverData.Team1.Image = ClientUtil.GetTeam1Image(serverData.MapName);
        // Team 1 Score
        serverData.Team1.MaxScore = Server.GetServerMaxScore();
        serverData.Team1.AllScore = Server.GetTeamScore(1);
        serverData.Team1.ScoreKill = Server.GetTeamKillScore(1);
        serverData.Team1.ScoreFlag = Server.GetTeamFlagScore(1);

        // Team 2
        serverData.Team2.Name = ClientUtil.GetTeam2Name(serverData.MapName);
        serverData.Team2.Image = ClientUtil.GetTeam2Image(serverData.MapName);
        serverData.Team2.MaxScore = Server.GetServerMaxScore();
        // Team 2 Score
        serverData.Team2.AllScore = Server.GetTeamScore(2);
        serverData.Team2.ScoreKill = Server.GetTeamKillScore(2);
        serverData.Team2.ScoreFlag = Server.GetTeamFlagScore(2);

        return Ok(serverData);
    }
}
