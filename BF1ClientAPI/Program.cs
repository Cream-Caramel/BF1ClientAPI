using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;
using System.Threading;

namespace BF1ClientAPI;

public class Program
{
    public const string Host = "http://127.0.0.1:10086";
    public static class Globals
    {
        public static string NgrokURI;
        public static string NgrokPath;
        public static string ServerHost;
        public static string Battlefield1Path;
    }

    public static void Main(string[] args)
    {
        Console.Title = "WatchDoge API";
        string LocalIP = Misc.GetLocalIPAddress();
        string PublicIP = Misc.GetPublicIPAddress();
        string ClientCapabilities = Misc.GetCapabilities();
        Config ClientConfig = Misc.ReadConfig();
        Globals.ServerHost = ClientConfig.server;
        Globals.NgrokPath = ClientConfig.ngrok_path;
        Globals.Battlefield1Path = ClientConfig.bf1_path;

        Console.WriteLine("WatchDoge initialized successfully.");  
        Console.WriteLine("----------------------------");
        Console.WriteLine($"LocalClientIP:  \t{LocalIP}");
        Console.WriteLine($"PublicClientIP: \t{PublicIP}");
        Console.WriteLine("----------------------------");
        Ngrok.Configure(ClientConfig.ngrok_token);
        Globals.NgrokURI = Ngrok.Start(ClientConfig.ngrok_path, 10086);

        Console.WriteLine($"Waiting for response from server {Globals.ServerHost}. Retrying in 3s ...");
        while (!Misc.AnnounceClient(Globals.ServerHost, PublicIP, ClientConfig.alias, Globals.NgrokURI, ClientCapabilities)) 
        {
            Console.WriteLine($"Waiting for response from server {Globals.ServerHost}. Retrying in 3s ...");
            Thread.Sleep(3000);
        }
        Console.WriteLine("Connected with orchestator server. API is ready.");
        Console.WriteLine($"Client alias {ClientConfig.alias}.");
        Console.WriteLine($"Client ngrok {Globals.NgrokURI}.");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Docs @ {Host}/index.html");
        Console.WriteLine("Press Ctrl+C to end the program");
        Console.WriteLine();

        ////////////////////////////////////////////////////////

        CoreUtil.DisbleConsoleCloseButton(Console.Title);
        AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

        ////////////////////////////////////////////////////////

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(cros =>
        {
            cros.AddPolicy("AllowAllOrigins", policy =>
            {
                policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
        });

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("V1", new OpenApiInfo
            {
                Version = "V1",
                Title = "BF1ClientAPI",
                Description = "Obtain data from the memory of the Battlefield 1 client, which is convenient for calling in other languages. Players can customize and develop server management tools based on this API",
                Contact = new OpenApiContact()
                {
                    Name = "GitHub-URL",
                    Url = new Uri("https://github.com/CrazyZhang666/BF1ClientAPI")
                }
            });
            // doc comments
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename), true);
        });

        var app = builder.Build();

        app.UseCors("AllowAllOrigins");

        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/V1/swagger.json", "API V1");
            options.RoutePrefix = string.Empty;
        });

        app.UseStaticFiles();
        app.UseAuthorization();
        app.MapControllers();

        app.Run(Host);
    }

    private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
    {
        // Release memory
        Chat.FreeMemory();
        Memory.UnInitialize();
        // Close ngrok and bf1
        Ngrok.Stop();
        Application.StopGame();
        Misc.CloseClient(Globals.ServerHost, Globals.NgrokURI);
    }

}
