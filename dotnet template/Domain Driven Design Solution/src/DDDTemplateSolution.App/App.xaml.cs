using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using DDDTemplateSolution.App.View.Windows;
using DDDTemplateSolution.Data;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Volo.Abp;

namespace DDDTemplateSolution.App;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private IAbpApplicationWithInternalServiceProvider _abpApplication;


    protected async override void OnStartup(StartupEventArgs e)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File($"Logs/logs_{DateTime.Now:yyyyMMddHH}.log"))
            .CreateLogger();

        try
        {
            Log.Information("\r\n\r\n\r\n");
            Log.Information("启动应用程序");

            Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            _abpApplication = await AbpApplicationFactory.CreateAsync<AppModule>(options =>
            {
                options.UseAutofac();
                options.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            });

            await _abpApplication.InitializeAsync();

            await _abpApplication
                .ServiceProvider
                .GetRequiredService<DDDTemplateSolutionDbMigrationService>()
                .MigrateAsync();

            _abpApplication.Services.GetRequiredService<MainWindow>()?.Show();

        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly!");
        }
    }


    private void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        Log.Fatal(e.Exception, "Dispatcher Unhandled Exception!");
        e.Handled = true;
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Log.Fatal(e.ExceptionObject as Exception, "Unhandled Exception!");
    }

    private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
    {
        Log.Fatal(e.Exception, "Unobserved Task Exception!");
        e.SetObserved();
    }

    protected async override void OnExit(ExitEventArgs e)
    {
        await _abpApplication.ShutdownAsync();
        Log.Information("应用程序关闭");
        Log.CloseAndFlush();
    }
}
