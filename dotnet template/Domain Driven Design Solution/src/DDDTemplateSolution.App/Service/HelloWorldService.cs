using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using DDDTemplateSolution.App.IService;
using Volo.Abp.DependencyInjection;

namespace DDDTemplateSolution.App.Service;

internal class HelloWorldService : IHelloWorldService, ITransientDependency
{
    public ILogger<HelloWorldService> Logger { get; set; }

    public HelloWorldService()
    {
        Logger = NullLogger<HelloWorldService>.Instance;
    }

    public string SayHello()
    {
        Logger.LogInformation("Call SayHello");
        return "Hello world!";
    }

    public string SayGoodBye()
    {
        Logger.LogInformation("Call SayGoodBye");
        return "GoodBye~";
    }
}
