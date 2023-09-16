namespace BF1ClientAPI.SDK;
using System.Net;
using System.Net.Http;
using System;
using System.Text.Json;
using System.Management;

public static class Misc
{
    /// <summary>
    /// Get Local IPV4 Address for display and ImAlive
    /// </summary>
    /// <returns></returns>
    public static string GetLocalIPAddress()
    {
        string strHostName = System.Net.Dns.GetHostName();
        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
        IPAddress[] addr = ipEntry.AddressList;
        return addr[addr.Length-1].ToString();
    }

    /// <summary>
    /// Get Public IPV4 Address
    /// </summary>
    /// <returns></returns>
    // public static async Task<IPAddress> GetPublicIpAddress()
    public static string GetPublicIPAddress()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("https://api.myip.com/").Result;
        MyIP r = JsonSerializer.Deserialize<MyIP>(response.Content.ReadAsStringAsync().Result);
        return r.ip;
    }

    /// <summary>
    /// Announce client capabilities
    /// </summary>
    /// <returns></returns>
    public static bool AnnounceClient(string APIHost, string IP, string Alias, string Host, string Capabilities)
    {
        Client SeedClient = new Client();
        HttpClient client = new HttpClient();
        SeedClient.ip = IP;
        SeedClient.server_alias = Alias;
        SeedClient.host = Host;
        SeedClient.capabilities = Capabilities;
        HttpContent httpContent = new StringContent(JsonSerializer.Serialize<Client>(SeedClient));
        string request = APIHost + "/seed/client";
        HttpResponseMessage response = client.PostAsync(request, httpContent).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return true;
    }

    /// <summary>
    /// Close client
    /// </summary>
    /// <returns></returns>
    public static void CloseClient(string APIHost, string Host)
    {
        HttpClient client = new HttpClient();
        HttpContent httpContent = new StringContent($"{{\"host\": \"{Host}\"}}");
        string request = APIHost + "/seed/client";
        HttpResponseMessage response = client.PatchAsync(request, httpContent).Result;
        var content = response.Content.ReadAsStringAsync().Result;
    }

    /// <summary>
    /// Get GPU capabilities
    /// </summary>
    /// <returns></returns> 
    public static string GetGPU()
    {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
        string graphicsCard = string.Empty;
        foreach (ManagementObject obj in searcher.Get())
        {
            if (obj["CurrentBitsPerPixel"] != null && obj["CurrentHorizontalResolution"] != null)
            {
                    graphicsCard = obj["Name"].ToString();
            }
        }
        return graphicsCard;
    }

    /// <summary>
    /// Get installed RAM amount
    /// </summary>
    /// <returns></returns> 
    public static int GetRAM()
    {
        var query = "SELECT Capacity FROM Win32_PhysicalMemory";
        var searcher = new ManagementObjectSearcher(query);
        foreach (var WniPART in searcher.Get())
        {
            var capacity = Convert.ToUInt64(WniPART.Properties["Capacity"].Value);
            var capacityKB = capacity / 1024;
            var capacityMB = capacityKB / 1024;
            var capacityGB = capacityMB / 1024;
            return (int) capacityGB;
        }
        return 0;
    }

    /// <summary>
    /// Return client capabilities
    /// </summary>
    /// <returns></returns>
    public static string GetCapabilities() 
    {
        ClientCapabilities props = new ClientCapabilities();
        props.GPU = GetGPU();
        props.CPUCount = Environment.ProcessorCount;
        props.RAM = GetRAM();
        return JsonSerializer.Serialize<ClientCapabilities>(props);
    }

    /// <summary>
    /// Read .ini file
    /// </summary>
    /// <returns></returns>
    public static Config ReadConfig()
    {
        string PathFileExec = System.Reflection.Assembly.GetEntryAssembly().Location;
        string PathFolderExec = System.IO.Path.GetDirectoryName(PathFileExec);
        string[] dirsIni = Directory.GetFiles(PathFolderExec, $"config.ini");
        if (dirsIni.Length == 0)
        {
            throw new Exception("No valid config.ini file was found.");
        }
        string PathFileIni = dirsIni[0]; 
        var ConfigFile = new IniFile(PathFileIni);
        Config ConfigParameters = new Config();
        ConfigParameters.bf1_path = ConfigFile.Read("bf1_path", "Client");
        ConfigParameters.ngrok_path = ConfigFile.Read("ngrok_path", "Client");
        ConfigParameters.ngrok_token = ConfigFile.Read("ngrok_token", "Client");
        ConfigParameters.server = ConfigFile.Read("server", "Client");
        ConfigParameters.server = ConfigFile.Read("server", "Client");
        ConfigParameters.alias = ConfigFile.Read("alias", "Client");
        return ConfigParameters;
    }
}

public class Client
{
    public string ip {get; set; }
    public string server_alias {get; set; }
    public string host {get; set; }
    public string capabilities { get; set; }
}

class MyIP{
    public string ip {get; set; }
    public string country {get; set; }
    public string cc {get; set; }
}

class ClientCapabilities
{
    public string GPU { get; set; }
    public int CPUCount { get; set; }
    public int RAM { get; set; }
}

class IniFile
{
    string Path;
    string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

    public IniFile(string IniPath = null)
    {
        Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
    }

    public string Read(string Key, string Section = null)
    {
        var RetVal = new StringBuilder(255);
        GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
        return RetVal.ToString();
    }

    public void Write(string Key, string Value, string Section = null)
    {
        WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
    }

    public void DeleteKey(string Key, string Section = null)
    {
        Write(Key, null, Section ?? EXE);
    }

    public void DeleteSection(string Section = null)
    {
        Write(null, null, Section ?? EXE);
    }

    public bool KeyExists(string Key, string Section = null)
    {
        return Read(Key, Section).Length > 0;
    }
}

public class Config 
{
    public string ngrok_token { get; set; }
    public string server { get; set; }
    public string bf1_path { get; set; }
    public string ngrok_path { get; set; }
    public string alias { get; set; }
}