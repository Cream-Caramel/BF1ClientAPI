using BF1ClientAPI.SDK;

namespace BF1ClientAPI.Utils;

public static class CoreUtil
{
    /// <summary>
    /// 禁用控制台关闭按钮
    /// </summary>
    /// <param name="title"></param>
    public static void DisbleConsoleCloseButton(string title)
    {
        var windowHandle = Win32.FindWindow(null, title);
        var closeMenu = Win32.GetSystemMenu(windowHandle, IntPtr.Zero);

        Win32.RemoveMenu(closeMenu, 0xF060, 0x0);
    }

    /// <summary>
    /// 向剪贴板中添加文本
    /// </summary>
    /// <param name="text">文本</param>
    public static void SetText(string text)
    {
        if (!Win32.OpenClipboard(IntPtr.Zero))
        {
            SetText(text);
            return;
        }

        Win32.EmptyClipboard();
        Win32.SetClipboardData(13, Marshal.StringToHGlobalUni(text));
        Win32.CloseClipboard();
    }

    /// <summary>
    /// 内存回收
    /// </summary>
    public static void ClearMemory()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();

        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            _ = Win32.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
    }
}
