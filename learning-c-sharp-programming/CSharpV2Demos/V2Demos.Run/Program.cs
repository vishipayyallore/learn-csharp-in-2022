using Microsoft.Extensions.DependencyInjection;
using V2Demos.Run.Apps;
using V2Demos.Run.Dependencies;
using static System.Console;

// Generate a provider
var serviceProvider = ConfigureServices();

Console.ResetColor();

serviceProvider?.GetService<ArrayDemoApp>()?.Run();

WriteLine("\n\nPress any key ...");
ReadKey();

static ServiceProvider ConfigureServices()
{
    // create service collection
    IServiceCollection services = new ServiceCollection();

    services.ConfigureArrayDemoServices();
    services.ConfigureHeaderFooterServices();

    return services.BuildServiceProvider();
}
