using Microsoft.Extensions.DependencyInjection;
using DDDTemplateSolution.App.Service;
using DDDTemplateSolution.App.View.Windows;
using DDDTemplateSolution.App.ViewModel;
using DDDTemplateSolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DDDTemplateSolution.App;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DDDTemplateSolutionApplicationModule),
    typeof(DDDTemplateSolutionEntityFrameworkCoreModule)
    )]
public class AppModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddSingleton<MainWindow>();
        ServiceLocator.ConfigureServices(context);
        ViewModelLocator.ConfigureServices(context);
    }
}
