using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using BF1ClientAPI.Models;

using ChineseConverter;

namespace BF1ClientAPI.Controllers;

/// <summary>
/// 聊天
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class ChatController : ControllerBase
{
    /// <summary>
    /// 获取服务器最后发言消息
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 获取当前服务器最后发言的玩家Id和发言内容，由于是弱指针，有概率获取不到或者内容乱码
    /// 
    /// 使用过程中建议定时获取最后发言，并做好内容记录
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
    /// 发送聊天消息到服务器
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// 发送自定义消息内容（最大256字符，约85个汉字），输入法需要是英文状态
    /// 
    /// delay参数为发送延迟，单位毫秒，一般设置50即可
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
