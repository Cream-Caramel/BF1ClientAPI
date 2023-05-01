namespace BF1ClientAPI.SDK;

public static class Chat
{
    /// <summary>
    /// 申请的内存地址
    /// </summary>
    public static IntPtr AllocateMemAddress { get; private set; } = IntPtr.Zero;

    //////////////////////////////////////////////////////////////////

    /// <summary>
    /// 申请内存空间
    /// </summary>
    /// <returns></returns>
    public static bool AllocateMemory()
    {
        if (AllocateMemAddress == IntPtr.Zero)
            AllocateMemAddress = Win32.VirtualAllocEx(Memory.Bf1ProHandle, IntPtr.Zero, (IntPtr)0x300, AllocationType.Commit, MemoryProtection.ReadWrite);

        return AllocateMemAddress != IntPtr.Zero;
    }

    /// <summary>
    /// 释放申请的内存空间
    /// </summary>
    public static void FreeMemory()
    {
        if (AllocateMemAddress != IntPtr.Zero)
            Win32.VirtualFreeEx(Memory.Bf1ProHandle, AllocateMemAddress, 0, AllocationType.Reset);
    }

    //////////////////////////////////////////////////////////////////

    /// <summary>
    /// 判断战地1聊天框是否开启，开启返回true，关闭或其他返回false
    /// </summary>
    /// <returns></returns>
    public static bool GetIsOpenChat()
    {
        var address = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x39F1E50);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x08);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x00);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x20);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x18);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x38);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x40);
        if (!Memory.IsValid(address))
            return false;

        return Memory.Read<byte>(address + 0x30) == 0x01;
    }

    /// <summary>
    /// 获取聊天框指针，成功返回指针，失败返回0
    /// </summary>
    /// <returns></returns>
    public static long ChatMessagePointer()
    {
        var address = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x3A327E0);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x20);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x18);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x38);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x08);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x68);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0xB8);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x10);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x10);
        if (!Memory.IsValid(address))
            return 0;

        return address;
    }

    /// <summary>
    /// 获取聊天框列表，成功返回指针，失败返回0
    /// </summary>
    /// <returns></returns>
    public static long ChatListPointer()
    {
        var address = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x39F1E50);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x70);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x20);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x18);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x38);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0xD8);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x50);
        if (!Memory.IsValid(address))
            return 0;

        return address;
    }

    /// <summary>
    /// 获取最后聊天发送者
    /// </summary>
    /// <returns></returns>
    public static string GetLastChatSender()
    {
        if (!Memory.IsValid(ChatListPointer()))
            return string.Empty;

        var pSender = Memory.Read<long>(ChatListPointer() + Offsets.OFFSET_CHAT_LAST_SENDER);
        if (!Memory.IsValid(pSender))
            return string.Empty;

        return Memory.ReadString(Memory.Read<long>(pSender), 32).Replace(":", "");
    }

    /// <summary>
    /// 获取最后聊天发送内容
    /// </summary>
    /// <returns></returns>
    public static string GetLastChatContent()
    {
        if (!Memory.IsValid(ChatListPointer()))
            return string.Empty;

        var pContent = Memory.Read<long>(ChatListPointer() + Offsets.OFFSET_CHAT_LAST_CONTENT);
        if (!Memory.IsValid(pContent))
            return string.Empty;

        return Memory.ReadString(Memory.Read<long>(pContent), 256);
    }

    //////////////////////////////////////////////////////////////////

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="delay"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static async Task SendMessage(int delay, string message)
    {
        if (GetIsMinimized())
            return;

        // 将战地1窗口置前
        for (int i = 0; i < 5; i++)
        {
            Memory.SetBF1WindowForeground();
            await Task.Delay(delay);

            if (GetIsOpenChat())
                await Memory.KeyPress(WinVK.RETURN);

            if (GetIsTopWindow())
                break;
        }

        if (!GetIsTopWindow())
            return;

        // 模拟聊天框按键
        for (int i = 0; i < 5; i++)
        {
            await Memory.KeyPress(WinVK.J, delay);

            if (GetIsOpenChat())
                break;
        }

        if (!GetIsOpenChat())
            return;

        // 挂起战地1进程
        Memory.SuspendBF1Process();

        var length = GetTextLength(message.Trim());
        Memory.WriteString(AllocateMemAddress.ToInt64(), message);

        var startPtr = ChatMessagePointer() + Offsets.OFFSET_CHAT_MESSAGE_START;
        var endPtr = ChatMessagePointer() + Offsets.OFFSET_CHAT_MESSAGE_END;

        var oldStartPtr = Memory.Read<long>(startPtr);
        var oldEndPtr = Memory.Read<long>(endPtr);

        Memory.Write(startPtr, AllocateMemAddress.ToInt64());
        Memory.Write(endPtr, AllocateMemAddress.ToInt64() + length);

        // 恢复战地1进程
        Memory.ResumeBF1Process();

        // 模拟按下回车键
        await Memory.KeyPress(WinVK.RETURN, delay);

        // 挂起战地1进程
        Memory.SuspendBF1Process();
        Memory.Write(startPtr, oldStartPtr);
        Memory.Write(endPtr, oldEndPtr);
        // 恢复战地1进程
        Memory.ResumeBF1Process();
    }

    /// <summary>
    /// 战地1窗口是否在最前
    /// </summary>
    /// <returns></returns>
    public static bool GetIsTopWindow()
    {
        var address = Memory.Read<long>(Offsets.OFFSET_DXRENDERER);
        if (!Memory.IsValid(address))
            return false;

        address = Memory.Read<long>(address + 0x820);
        if (!Memory.IsValid(address))
            return false;

        return Memory.Read<byte>(address + 0x5F) == 0x01;
    }

    /// <summary>
    /// 战地1窗口是否最小化
    /// </summary>
    /// <returns></returns>
    public static bool GetIsMinimized()
    {
        var address = Memory.Read<long>(Offsets.OFFSET_DXRENDERER);
        if (!Memory.IsValid(address))
            return false;

        address = Memory.Read<long>(address + 0x820);
        if (!Memory.IsValid(address))
            return false;

        return Memory.Read<byte>(address + 0x60) == 0x01;
    }

    /// <summary>
    /// 判断战地1输入框字符串长度，中文3，英文1
    /// </summary>
    /// <param name="text">需要判断的字符串</param>
    /// <returns></returns>
    public static int GetTextLength(string text)
    {
        text = text.Trim();
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        var tempLen = 0;
        var bytes = new ASCIIEncoding().GetBytes(text);
        for (int i = 0; i < bytes.Length; i++)
        {
            if (bytes[i] == 63)
                tempLen += 3;
            else
                tempLen += 1;
        }

        return tempLen;
    }
}
