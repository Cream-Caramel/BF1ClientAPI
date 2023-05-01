using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// 权限
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    /// <summary>
    /// 获取本地内存SessionId
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 从内存中扫描当前登录用户的SessionId，如果未发现SessionId，请刷新游戏内服务器列表后重试
    /// 
    /// 获取成功后返回Guid类型字符串
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public async Task<ActionResult<string>> GetLocalSessionId()
    {
        var sessionId = await Scan.GetGatewaySession();
        if (string.IsNullOrWhiteSpace(sessionId))
            return NotFound();

        return Ok(sessionId);
    }
}
