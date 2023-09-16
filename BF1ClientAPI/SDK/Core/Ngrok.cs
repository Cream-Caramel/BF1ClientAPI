namespace BF1ClientAPI.SDK;
using System.Net.Http;
using System.Text.Json;

public static class Ngrok
{

    /// <summary>
    /// Configure ngrok to use token
    /// </summary>
    public static void Configure(string token)
    {
        //Start the process
        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        pProcess.StartInfo.FileName = Program.Globals.NgrokPath;
        pProcess.StartInfo.Arguments = $"config add-authtoken {token}";
        pProcess.StartInfo.UseShellExecute = false;
        pProcess.StartInfo.RedirectStandardOutput = true;
        pProcess.Start();
    }
    /// <summary>
    /// Start ngrok on port and read output
    /// </summary>
    public static string Start(string NgrokPath, int PortNumber) 
    {
        //Start the process
        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        pProcess.StartInfo.FileName = NgrokPath;
        pProcess.StartInfo.Arguments = $"http {PortNumber}";
        pProcess.StartInfo.UseShellExecute = false;
        pProcess.StartInfo.RedirectStandardOutput = true;
        pProcess.Start();
        return GetNgrokHost();
    }

    /// <summary>
    /// read and return Ngrok public uri
    /// </summary>

    public static string GetNgrokHost() 
    {
        // Read and return proces link
        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("http://127.0.0.1:4040/api/tunnels").Result;
        string content = response.Content.ReadAsStringAsync().Result;
        var ngrok = JsonSerializer.Deserialize<NgrokJSON>(content);
        return ngrok.tunnels[0].public_url;
    }

    /// <summary>
    /// Kill ngrok process
    /// </summary>
    public static void Stop() 
    {
        Process[] procs = Process.GetProcessesByName("ngrok");
        if (procs.Length > 0)
        {
            foreach (Process proc in procs)
            {
                proc.Kill();
            }
        }
    }
}

public class NgrokConns
{
    public int count { get; set; }
    public int gauge { get; set; }
    public float rate1 { get; set; }
    public float rate5 { get; set; }
    public float rate15 { get; set; }
    public float p50 { get; set; }
    public float p90 { get; set; }
    public float p95 { get; set; }
    public float p99 { get; set; }
}

public class NgrokHTTP
{
    public int count { get; set; }
    public float rate1 { get; set; }
    public float rate5 { get; set; }
    public float rate15 { get; set; }
    public float p50 { get; set; }
    public float p90 { get; set; }
    public float p95 { get; set; }
    public float p99 { get; set; }
}    

public class NgrokConfig
{
    public string addr { get; set; }
    public bool inspect { get; set; }    
}

public class NgrokMetrics
{
    public NgrokConns conns { get; set; }
    public NgrokHTTP http { get; set; }
}

public class NgrokTunnel
{
    public string name { get; set; }
    public string ID { get; set; }
    public string uri { get; set; }
    public string public_url { get; set; }
    public string proto { get; set; }
    public NgrokConfig config { get; set; }

    public NgrokMetrics metrics { get; set; }
}

public class NgrokJSON
{
    public List<NgrokTunnel> tunnels { get; set; }
    public string uri { get; set; }
}