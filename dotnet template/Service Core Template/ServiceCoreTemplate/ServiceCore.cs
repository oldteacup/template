using ServiceCoreTemplate.DependencyInjection;
using ServiceCoreTemplate.IServices;
using ServiceCoreTemplate.Services;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Events;
using Serilog;
using System.Diagnostics.CodeAnalysis;

namespace ServiceCoreTemplate
{
    public class ServiceCore
    {
        public Ioc Ioc { get; private set; } = new();

        public ServiceCore() : this($"Logs/logs_{DateTime.Now:yyyyMMdd}.log")
        { 
        }

        public ServiceCore(string logFilePath) : this(new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
            .CreateLogger())
        {
        }

        public ServiceCore(ILogger loggerConfiguration)
        {
            Log.Logger = loggerConfiguration;
        }


        public ServiceCore ConfigureIocService([AllowNull] Action<IServiceCollection> iocRegistAction = null)
        {
            Log.Information("注册Ioc服务...");

            var services = new ServiceCollection();

            #region Regist Ioc Service

            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<IHomeService, HomeService>();

            #endregion

            iocRegistAction?.Invoke(services);

            Ioc.ConfigureServices(services.BuildServiceProvider());


            Log.Information("Ioc服务注册完成");

            return this;
        }
    }
}
