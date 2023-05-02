using BF1ClientAPI.SDK;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// 玩家
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class PlayerController : ControllerBase
{
    /// <summary>
    /// 获取自己信息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取战地1自己账号的相关数据
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
    /// 获取游戏内玩家列表信息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取战地1当前进入服务器全部玩家数据
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
    /// 获取游戏内队伍0玩家列表信息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取战地1当前进入服务器观战和载入中玩家数据
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
    /// 获取游戏内队伍1玩家列表信息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取战地1当前进入服务器队伍1中玩家数据，已按照得分顺序排序
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
    /// 获取游戏内队伍2玩家列表信息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取战地1当前进入服务器队伍2中玩家数据，已按照得分顺序排序
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
