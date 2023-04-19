using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmProjectTemplate.ViewModel.WindowViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace MvvmProjectTemplate.ViewModel
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
