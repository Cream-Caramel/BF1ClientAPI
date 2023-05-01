using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    /// <summary>
    /// 获取本地玩家内存SessionId
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<string>> GetLocalPlayerSessionId()
    {
        var sessionId = await Scan.GetGatewaySession();
        if (string.IsNullOrWhiteSpace(sessionId))
            return NotFound();

        return Ok(sessionId);
    }
}
