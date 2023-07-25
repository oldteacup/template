// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using VisionSystem.App.ViewModel.WindowViewModels;

namespace VisionSystem.App.ViewModel
{
    public class ViewModelLocator
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();


            return services;
        }

        public static MainWindowViewModel MainWindowViewModel => App.Ioc.GetService<MainWindowViewModel>();
    }
}
