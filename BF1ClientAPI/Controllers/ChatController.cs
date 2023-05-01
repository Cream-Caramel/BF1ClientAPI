using BF1ClientAPI.SDK;
using BF1ClientAPI.Models;

namespace BF1ClientAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ChatController : ControllerBase
{
    /// <summary>
    /// 获取服务器最后发言信息
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<ChatData> GetLastChatData()
    {
        var sender = Chat.GetLastChatSender(out long pSender);
        var content = Chat.GetLastChatContent(out long pContent);

        if (pSender == 0 || pContent == 0)
            return NotFound();

        return Ok(new ChatData()
        {
            Sender = sender,
            Content = content
        });
    }

    /// <summary>
    /// 发送游戏聊天消息
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult> SendChatMessage(string message, int delay = 50)
    {
        if (string.IsNullOrWhiteSpace(message))
            return NoContent();

        if (delay <= 0)
            return BadRequest();

        await Chat.SendMessageToGame(message, delay);

        return Ok();
    }
}
