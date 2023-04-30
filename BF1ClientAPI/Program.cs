using BF1ClientAPI.SDK;

namespace BF1ClientAPI;

public class Program
{
    public const string Host = "http://127.0.0.1:10086";

    public static void Main(string[] args)
    {
        Console.Title = "战地1客户端API";

        if (!Memory.Initialize())
        {
            Console.WriteLine("战地1客户端API初始化失败，程序终止");

            Console.WriteLine("按任意键退出程序...");
            Console.ReadKey();

            return;
        }

        Console.WriteLine("战地1客户端API初始化成功！");

        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine($"进程Id：\t{Memory.Bf1ProId}");
        Console.WriteLine($"进程句柄：\t{Memory.Bf1ProHandle}");
        Console.WriteLine($"主模块基址：\t0x{Memory.Bf1ProBaseAddress:X}");
        Console.WriteLine($"窗口句柄：\t{Memory.Bf1WinHandle}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        Console.WriteLine("接口文档：http://127.0.0.1:10086/swagger/index.html");
        Console.WriteLine();

        ////////////////////////////////////////////////////////

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(cros =>
        {
            cros.AddPolicy("AllowAllOrigins", policy =>
            {
                policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
        });

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseCors("AllowAllOrigins");

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseStaticFiles();
        app.UseAuthorization();
        app.MapControllers();

        app.Run(Host);
    }
}
