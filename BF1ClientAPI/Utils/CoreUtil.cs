namespace BF1ClientAPI.Utils;

public static class CoreUtil
{
    [DllImport("user32.dll", EntryPoint = "FindWindow")]
    private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
    [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
    private extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);
    [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
    private extern static IntPtr RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

    /// <summary>
    /// 禁用控制台关闭按钮
    /// </summary>
    /// <param name="title"></param>
    public static void DisbleConsoleCloseButton(string title)
    {
        var windowHandle = FindWindow(null, title);
        var closeMenu = GetSystemMenu(windowHandle, IntPtr.Zero);

        RemoveMenu(closeMenu, 0xF060, 0x0);
    }
}
