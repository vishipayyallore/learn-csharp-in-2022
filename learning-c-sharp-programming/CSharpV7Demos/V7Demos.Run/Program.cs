using Microsoft.Extensions.DependencyInjection;
using V7Demos.Run.Apps;
using V7Demos.Run.Dependencies;
using static System.Console;

// Generate a provider
var serviceProvider = ConfigureServices();

serviceProvider?.GetService<OutVariablesDemoApp>()?.Run();

WriteLine("\n\nPress any key ...");
ReadKey();

static ServiceProvider ConfigureServices()
{
    // create service collection
    IServiceCollection services = new ServiceCollection();

    services.ConfigureOutVariablesServices();

    return services.BuildServiceProvider();
}
