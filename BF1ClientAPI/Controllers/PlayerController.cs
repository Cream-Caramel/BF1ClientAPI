using BF1ClientAPI.SDK;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PlayerController : ControllerBase
{
    /// <summary>
    /// 获取本地玩家详细（自己）
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<LocalPlayer> GetLocalPlayer()
    {
        var localPlayer = Player.GetPlayerLocal();
        if (localPlayer is null)
            return NotFound();

        return Ok(localPlayer);
    }
}
