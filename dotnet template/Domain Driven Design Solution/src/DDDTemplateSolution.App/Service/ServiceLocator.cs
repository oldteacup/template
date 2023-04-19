using Microsoft.Extensions.DependencyInjection;
using DDDTemplateSolution.App.IService;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DDDTemplateSolution.App.Service
{
    public class ServiceLocator
    {
        public static void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<IHelloWorldService, HelloWorldService>();
        }
    }
}
