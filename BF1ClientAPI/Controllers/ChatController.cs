using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

using ChineseConverter;

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
        var sender = Chat.GetLastChatSender();
        var content = Chat.GetLastChatContent();

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
    public async Task<ActionResult> SendChatMessage(int delay, string message)
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
