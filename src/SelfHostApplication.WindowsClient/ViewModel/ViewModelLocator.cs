using CommunityToolkit.Mvvm.DependencyInjection;
using SelfHostApplication.WindowsClient.ViewModel.WindowViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace SelfHostApplication.WindowsClient.ViewModel
{
    public class ViewModelLocator
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            return services;
        }

        public static MainWindowViewModel MainWindowViewModel => Ioc.Default.GetService<MainWindowViewModel>();
    }
}
