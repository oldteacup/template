using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace SelfHostApplication.WindowsClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider ServiceProvider { get; } = ConfigureServices();

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            ViewModel.ViewModelLocator.ConfigureServices(services);
            Ioc.Default.ConfigureServices(services.BuildServiceProvider());
            return Ioc.Default;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File($"Logs/WindowsClient/logs_{DateTime.Now:yyyyMMdd}.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                Log.Information("\r\n\r\n\r\n");
                Log.Information("Start the application.");

                Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

                base.OnStartup(e);

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

        private void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            Log.Fatal(e.Exception, "Unobserved Task Exception!");
            e.SetObserved();
        }
        protected override void OnExit(ExitEventArgs e)
        {
            Log.Information("Application Exit");
            Log.CloseAndFlush();
        }
    }
}
