using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    /// <summary>
    /// 获取本地内存SessionId
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<string>> GetLocalSessionId()
    {
        var sessionId = await Scan.GetGatewaySession();
        if (string.IsNullOrWhiteSpace(sessionId))
            return NotFound();

        return Ok(sessionId);
    }
}
