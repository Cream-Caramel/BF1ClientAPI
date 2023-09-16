using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// Application
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class ApplicationController : ControllerBase
{
    /// <summary>
    /// Start bf1.exe
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Calling this endpoint will start bf1.exe
    /// </remarks>
    [HttpPost]
    [Produces("application/json")]
    public async Task<ActionResult<string>> StartGame(string GameId, bool DisableGPU, bool Spectator, int Timeout)
    {
        var result = await Application.StartGame(GameId, DisableGPU, Spectator, Timeout);
        return Ok(result);
    }

    /// <summary>
    /// Close bf1.exe
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Calling this endpoint will stop bf1.exe
    /// </remarks>
    [HttpPost]
    [Produces("application/json")]
    public async Task<ActionResult<string>> Stop()
    {
        Application.StopGame();
        return Ok("OK");
    }
}
