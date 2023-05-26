using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;

namespace BF1ClientAPI;

public class Program
{
    public const string Host = "http://0.0.0.0:10086";

    public static void Main(string[] args)
    {
        Console.Title = "BF1ClientAPI | By CrazyZhang666";

        if (!Memory.Initialize())
        {
            Console.WriteLine("Battlefield 1 client API initialization failed, program terminated");
            Console.WriteLine();

            Console.WriteLine("Press any key to close this window...");
            Console.Read();

            return;
        }

        if (!Chat.AllocateMemory())
        {
            Console.WriteLine("Request for Chinese chat memory space failed, program terminated");
            Console.WriteLine();

            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();

            return;
        }

        Console.WriteLine("Battlefield 1 client API initialization successful!");
        Console.WriteLine();

        Console.WriteLine("----------------------------");
        Console.WriteLine($"ProcessId: \t{Memory.Bf1ProId}");
        Console.WriteLine($"ProcessHandle: \t{Memory.Bf1ProHandle}");
        Console.WriteLine($"BaseAddressַ: \t0x{Memory.Bf1ProBaseAddress:X}");
        Console.WriteLine($"WindowHandle: \t{Memory.Bf1WinHandle}");
        Console.WriteLine($"MemAddress: \t0x{Chat.AllocateMemAddress:x}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

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
    }
}
