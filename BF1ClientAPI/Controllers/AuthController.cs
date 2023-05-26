using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// Authentication
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    /// <summary>
    /// Local Memory SessionId
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Scan the SessionId of the currently logged-in user from memory, if the SessionId is not found, please refresh the in-game server list and try again
    /// 
    /// Returns the Guid type string after successful acquisition
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
