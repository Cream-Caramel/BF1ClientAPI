using BF1ClientAPI.SDK;
using BF1ClientAPI.Utils;

namespace BF1ClientAPI;

public class Program
{
    public const string Host = "http://127.0.0.1:10086";

    public static void Main(string[] args)
    {
        Console.Title = "战地1客户端API | DS By CrazyZhang666";

        if (!Memory.Initialize())
        {
            Console.WriteLine("战地1客户端API初始化失败，程序终止");
            Console.WriteLine();

            Console.WriteLine("按任意键关闭此窗口...");
            Console.ReadKey();

            return;
        }

        if (!Chat.AllocateMemory())
        {
            Console.WriteLine("申请中文聊天内存空间失败，程序终止");
            Console.WriteLine();

            Console.WriteLine("按任意键关闭此窗口...");
            Console.ReadKey();

            return;
        }

        Console.WriteLine("战地1客户端API初始化成功！");
        Console.WriteLine();

        Console.WriteLine("----------------------------");
        Console.WriteLine($"进程Id: \t{Memory.Bf1ProId}");
        Console.WriteLine($"进程句柄: \t{Memory.Bf1ProHandle}");
        Console.WriteLine($"主模块基址: \t0x{Memory.Bf1ProBaseAddress:X}");
        Console.WriteLine($"窗口句柄: \t{Memory.Bf1WinHandle}");
        Console.WriteLine($"申请空间地址: \t0x{Chat.AllocateMemAddress:x}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        Console.WriteLine($"接口文档：{Host}/index.html");
        Console.WriteLine("按 Ctrl+C 键结束程序");
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
                Title = "战地1客户端API",
                Description = "从战地1客户端内存中获取数据，方便其他语言调用，玩家可根据此API自定义开发服管工具",
                Contact = new OpenApiContact()
                {
                    Name = "GitHub地址",
                    Url = new Uri("https://github.com/CrazyZhang666/BF1ClientAPI")
                }
            });
            // 显示文档注释
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename), true);
        });

        var app = builder.Build();

        app.UseCors("AllowAllOrigins");

        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/V1/swagger.json", "API版本 V1");
            options.RoutePrefix = string.Empty;
        });

        app.UseStaticFiles();
        app.UseAuthorization();
        app.MapControllers();

        app.Run(Host);
    }

    private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
    {
        // 释放中文聊天指针内存
        Chat.FreeMemory();
        // 释放内存模块相关资源
        Memory.UnInitialize();
    }
}
