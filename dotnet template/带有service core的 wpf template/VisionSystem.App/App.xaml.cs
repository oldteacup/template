// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Serilog;
using VisionSystem.App.ViewModel;
using VisionSystem.Core;
using VisionSystem.Core.DependencyInjection;

namespace VisionSystem.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static System.Threading.Mutex _mutex;
        private static ServiceCore s_serviceCore = new ServiceCore();

        public static Ioc Ioc => s_serviceCore.Ioc;

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                _mutex = new System.Threading.Mutex(true, $"__{nameof(VisionSystem.App.App)}__");

                if (!_mutex.WaitOne(0, false))
                {
                    Log.Information("Repeat. The program is already running!");
                    Environment.Exit(0);
                    return;
                }

                Log.Information("\r\n\r\n\r\n");
                Log.Information("Start the application.");

                Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

                Log.Information("An unhandled exception handler is attached.");

                s_serviceCore.ConfigureIocService(ioc =>
                {
                    ViewModelLocator.ConfigureServices(ioc);
                });

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
