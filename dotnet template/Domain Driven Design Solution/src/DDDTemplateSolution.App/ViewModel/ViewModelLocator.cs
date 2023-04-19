using Microsoft.Extensions.DependencyInjection;
using DDDTemplateSolution.App.ViewModel.Windows;
using Volo.Abp.Modularity;

namespace DDDTemplateSolution.App.ViewModel
{
    public class ViewModelLocator
    {
        public static void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindowViewModel>();
        }
    }
}
