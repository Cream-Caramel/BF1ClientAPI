using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

using ChineseConverter;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// Chat
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class ChatController : ControllerBase
{
    /// <summary>
    /// Get the last chat message from the server
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Get the last chat text message posted in the server and the senders name, because it is a weak pointer, there is a probability of not getting it or the being garbled
    /// 
    /// During use, it is recommended to obtain the last speech at regular intervals (for example, every 200ms), and do a good job of recording and de-duplicating the content to prevent data loss.
    /// </remarks>
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<ChatData> GetLastChatData()
    {
        var sender = Chat.GetLastChatSender();
        var content = Chat.GetLastChatContent();

        return Ok(new ChatData()
        {
            Sender = sender,
            Content = content
        });
    }

    /// <summary>
    /// Send a chat message to the server
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Send custom message content (max 256 characters), input method needs to be in English
    /// 
    /// delay (ms) set between 50 or 100 ms
    /// </remarks>
    [HttpPost("{delay}")]
    [Produces("application/json")]
    public async Task<ActionResult> SendChatMessage(int delay, [FromBody] string message)
    {
        if (delay <= 0)
            return BadRequest();

        if (string.IsNullOrWhiteSpace(message))
            return NoContent();

        if (!GameUtil.IsInGame())
            return BadRequest();

        await Chat.SendMessage(delay, ChineseConvert.ToTraditional(message));

        return Ok();
    }
}
