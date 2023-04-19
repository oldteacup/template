using CoreServiceTemplate.DependencyInjection;
using CoreServiceTemplate.IServices;
using CoreServiceTemplate.Services;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Events;
using Serilog;

namespace CoreServiceTemplate
{
    public static class Service
    {
        public static Ioc Ioc => Ioc.Default;

        public static void Run()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File($"Logs/logs_{DateTime.Now:yyyyMMdd}.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("初始化开始");
            
            Initialization();

            Log.Information("初始化完成");
        }

        private static void Initialization()
        {
            Log.Information("注册Ioc服务");
            ConfigureIocService();
        }


        private static IServiceProvider ConfigureIocService()
        {
            var services = new ServiceCollection();

            #region Regist Ioc Service

            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<IHomeService, HomeService>();

            #endregion

            Ioc.Default.ConfigureServices(services.BuildServiceProvider());
            return Ioc.Default;
        }
    }
}
