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


    public static async Task<string> StartGame(string GameId, bool DisableGPU, bool Spectator, int Timeout)
    {
        Timeout = Timeout == 0 ? 30 : Timeout;

        string PathFolderEaDesktop = Path.Join(Environment.GetEnvironmentVariable("LocalAppData"), "Electronic Arts", "EA Desktop");

        KillProcesses("EADesktop", "bf1");

        List<string> ParamsCLI = GenerateGameParams(GameId, DisableGPU, Spectator);

        await EditIniFileAsync(PathFolderEaDesktop, ParamsCLI).ConfigureAwait(false);

        await LaunchGameAndInitializeMemoryAsync(Timeout).ConfigureAwait(false);

        return "OK";
    }

    private static void KillProcesses(params string[] processNames)
    {
        foreach (var name in processNames)
        {
            var processes = Process.GetProcessesByName(name);
            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }

    private static List<string> GenerateGameParams(string GameId, bool DisableGPU, bool Spectator)
    {
        List<string> ParamsCLI = new List<string>();

        if (DisableGPU)
        {
            ParamsCLI.AddRange(new string[]
            {
                "Window.Fullscreen false",
                "RenderDevice.MinDriverRequired false",
                "Window.Fullscreen false",
                "RenderDevice.MinDriverRequired false",
                "Core.HardwareGpuBias -1",
                "Core.HardwareCpuBias -1",
                "Core.HardwareProfile Hardware_Low",
                "RenderDevice.CreateMinimalWindow true",
                "RenderDevice.NullDriverEnable true",
                "Texture.LoadingEnabled false",
                "Texture.RenderTexturesEnabled false",
                "Client.TerrainEnabled false",
                "Decal.SystemEnable false"
        });
        }

        string EntityType = !Spectator ? "soldier" : "spectator";
        ParamsCLI.AddRange(new string[]
        {
            "webMode MP",
            "Origin_NoAppFocus",
            "-activate-webhelper",
            "requestState State_ClaimReservation",
            $"gameId {GameId}",
            "gameMode MP",
            $"role {EntityType}",
            $"asSpectator {Spectator.ToString().ToLower()}"

        });

        return ParamsCLI;
    }

    private static async Task EditIniFileAsync(string pathFolder, List<string> paramsCLI)
    {

        string[] dirs = await Task.Run(() => Directory.GetFiles(pathFolder, $"user_*.ini")).ConfigureAwait(false);

        if (dirs.Length == 0)
        {
            throw new Exception("No valid .ini file was found.");
        }

        string pathFileIni = dirs[0];
        string currentContent = await Task.Run(() => File.ReadAllText(pathFileIni)).ConfigureAwait(false);

        await Task.Run(() => File.WriteAllText(pathFileIni, "[]\n" + currentContent)).ConfigureAwait(false);

        var configFile = new IniFile(pathFileIni);
        configFile.Write("user.gamecommandline.origin.ofr.50.0000557", "-" + String.Join(" -", paramsCLI), "");

        var allLines = await Task.Run(() => File.ReadAllLines(pathFileIni)).ConfigureAwait(false);
        await Task.Run(() => File.WriteAllLines(pathFileIni, allLines.Skip(1))).ConfigureAwait(false);
    }


    private static async Task LaunchGameAndInitializeMemoryAsync(int timeout)
    {
        Process.Start(Program.Globals.Battlefield1Path);

        bool wasInitialized = false;
        for (int counter = 0; counter <= timeout; counter++)
        {
            wasInitialized = Memory.Initialize();
            if (wasInitialized)
            {
                break;
            }
            await Task.Delay(1000).ConfigureAwait(false);
        }

        if (!wasInitialized)
        {
            throw new Exception("Battlefield1 memory initialization failed.");
        }

        if (!Chat.AllocateMemory())
        {
            throw new Exception("Battlefield1 chat memory initialization failed.");
        }
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