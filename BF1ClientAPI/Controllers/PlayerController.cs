using BF1ClientAPI.SDK;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// Player
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class PlayerController : ControllerBase
{
    /// <summary>
    /// Get information about yourself
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get data about your own account in Battlefield 1
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<LocalPlayer> GetLocalPlayer()
    {
        var localPlayer = Player.GetLocalPlayer();
        if (localPlayer is null)
            return NotFound();

        return Ok(localPlayer);
    }

    /// <summary>
    /// Get in-game player list information
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get the data of all players currently entering the server for Battlefield 1
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<List<GamePlayer>> GetGamePlayerList()
    {
        var gamePlayerList = Player.GetGamePlayerList();
        if (gamePlayerList.Count == 0)
            return NotFound();

        for (int i = 0; i < gamePlayerList.Count; i++)
            gamePlayerList[i].Index = i + 1;

        return Ok(gamePlayerList);
    }

    /// <summary>
    /// Get in-game team 0 player list information
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get Battlefield 1 data for players currently in spectator and loading screen 
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<List<GamePlayer>> GetTeam0GamePlayerList()
    {
        var gamePlayerList = Player.GetGamePlayerList();
        if (gamePlayerList.Count == 0)
            return NotFound();

        var team1List = new List<GamePlayer>();
        foreach (var item in gamePlayerList)
        {
            if (item.TeamId != 0)
                continue;

            team1List.Add(item);
        }

        if (team1List.Count == 0)
            return NotFound();

        for (int i = 0; i < team1List.Count; i++)
            team1List[i].Index = i + 1;

        return Ok(team1List);
    }

    /// <summary>
    /// Get in-game team 1 player list information
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get Battlefield 1 current entry server team 1 in the player data, has been sorted by score order
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<List<GamePlayer>> GetTeam1GamePlayerList()
    {
        var gamePlayerList = Player.GetGamePlayerList();
        if (gamePlayerList.Count == 0)
            return NotFound();

        var team1List = new List<GamePlayer>();
        foreach (var item in gamePlayerList)
        {
            if (item.TeamId != 1)
                continue;

            team1List.Add(item);
        }

        if (team1List.Count == 0)
            return NotFound();

        team1List.Sort((a, b) => b.Score.CompareTo(a.Score));

        for (int i = 0; i < team1List.Count; i++)
            team1List[i].Index = i + 1;

        return Ok(team1List);
    }

    /// <summary>
    /// Get in-game team 2 player list information
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get Battlefield 1 current entry server team 2 in the player data, has been sorted according to the score order
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<List<GamePlayer>> GetTeam2GamePlayerList()
    {
        var gamePlayerList = Player.GetGamePlayerList();
        if (gamePlayerList.Count == 0)
            return NotFound();

        var team2List = new List<GamePlayer>();
        foreach (var item in gamePlayerList)
        {
            if (item.TeamId != 2)
                continue;

            team2List.Add(item);
        }

        if (team2List.Count == 0)
            return NotFound();

        team2List.Sort((a, b) => b.Score.CompareTo(a.Score));

        for (int i = 0; i < team2List.Count; i++)
            team2List[i].Index = i + 1;

        return Ok(team2List);
    }
}
