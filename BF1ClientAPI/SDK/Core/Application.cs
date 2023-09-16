namespace BF1ClientAPI.SDK;
using System.Linq;
using System.Threading;
public static class Application
{
    private class CanReadAddress
    {
        public long Address;
        public int Size;
    }

    /// <summary>
    /// Start game with CLI params
    /// </summary>
    public static async Task<string> StartGame(string GameId, bool DisableGPU, bool Spectator, int Timeout) 
    {
        return await Task.Run(() => 
        {   
            if (Timeout == 0) {
                Timeout = 30;
            }
            int TimeoutCounter = 0; // In seconds
            // Get EA Desktop path
            string PathFolderEaDesktop = Path.Join(Environment.GetEnvironmentVariable("LocalAppData"), "Electronic Arts", "EA Desktop");
            // Kill EA Desktop and BF1
            Process[] procsEA = Process.GetProcessesByName("EADesktop");
            Process[] procBF1 = Process.GetProcessesByName("bf1");
            Process[] procALL = procsEA.Concat(procBF1).ToArray();
            if (procALL.Length > 0)
            {
                foreach (Process proc in procALL)
                {
                    proc.Kill();
                }
            }
            // Set game command params for .ini
            List<string> ParamsCLI = new List<string>();
            if (DisableGPU)
            {
                ParamsCLI.Add("Window.Fullscreen false");
                ParamsCLI.Add("RenderDevice.MinDriverRequired false");
                ParamsCLI.Add("Core.HardwareGpuBias -1");
                ParamsCLI.Add("Core.HardwareCpuBias -1");
                ParamsCLI.Add("Core.HardwareProfile Hardware_Low");
                ParamsCLI.Add("RenderDevice.CreateMinimalWindow true");
                ParamsCLI.Add("RenderDevice.NullDriverEnable true");
                ParamsCLI.Add("Texture.LoadingEnabled false");
                ParamsCLI.Add("Texture.RenderTexturesEnabled false");
                ParamsCLI.Add("Client.TerrainEnabled false");
                ParamsCLI.Add("Decal.SystemEnable false");                     
            }
            string EntityType = !Spectator ? "soldier" : "spectator";
            ParamsCLI.Add("webMode MP");
            ParamsCLI.Add("Origin_NoAppFocus");
            ParamsCLI.Add("-activate-webhelper");
            ParamsCLI.Add("requestState State_ClaimReservation");
            ParamsCLI.Add($"gameId {GameId}");
            ParamsCLI.Add("gameMode MP");
            ParamsCLI.Add($"role {EntityType}");
            ParamsCLI.Add($"asSpectator {Spectator.ToString().ToLower()}");
            string[] ArrayCLI = ParamsCLI.ToArray();
            string StringCLI = "-" + String.Join(" -", ArrayCLI);
            // Edit .ini file
            string[] dirs = Directory.GetFiles(PathFolderEaDesktop, $"user_*.ini");
            if (dirs.Length == 0) 
            {
                throw new Exception("No valid .ini file was found.");
            }
            string PathFileIni = dirs[0];
            string currentContent = File.ReadAllText(PathFileIni);
            File.WriteAllText(PathFileIni, "[]\n" + currentContent);
            var ConfigFile = new IniFile(PathFileIni);
            ConfigFile.Write("user.gamecommandline.origin.ofr.50.0000557", StringCLI, "");
            File.WriteAllLines(PathFileIni, File.ReadAllLines(PathFileIni).Skip(1));
            // Launch bf1.exe
            Process.Start(Program.Globals.Battlefield1Path);
            // Try several times to initialize memory (until game is loaded)
            bool WasInitialized = false;
            while (TimeoutCounter <= Timeout){
                WasInitialized = Memory.Initialize();
                if (WasInitialized) 
                {
                    break;
                }
                TimeoutCounter += 1;
                Thread.Sleep(1000);
            }
            if (!WasInitialized)
            {
                throw new Exception("Battlefield1 memory initialization failed.");
            }
            // Allocate Chat
            if (!Chat.AllocateMemory())
            {
                throw new Exception("Battlefield1 chat memory initialization failed.");
            }
            return "OK";
        });
    }

    /// <summary>
    /// Closes EA and BF1 applications
    /// </summary>
    public static void StopGame() 
    {
        Process[] procsEA = Process.GetProcessesByName("EADesktop");
        Process[] procBF1 = Process.GetProcessesByName("bf1");
        Process[] procALL = procsEA.Concat(procBF1).ToArray();
        if (procALL.Length > 0)
        {
            foreach (Process proc in procALL)
            {
                proc.Kill();
            }
        }
    }
}