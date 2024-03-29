﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using VisionSystem.Core.DependencyInjection;
using VisionSystem.Core.IServices;
using VisionSystem.Core.Services;

namespace VisionSystem.Core
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
            Log.Information("注册 Ioc 服务...");

            var services = new ServiceCollection();

            #region Regist Ioc Service

            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<IHomeService, HomeService>();

            #endregion


            Log.Information("注册 Customer Ioc 服务...");

            iocRegistAction?.Invoke(services);

            Ioc.ConfigureServices(services.BuildServiceProvider());


            Log.Information("Ioc 服务注册完成");

            return this;
        }
    }
}
