using Microsoft.Extensions.DependencyInjection;
using V7Demos.Run.Apps;
using V7Demos.Run.Dependencies;
using static System.Console;

// Generate a provider
var serviceProvider = ConfigureServices();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
serviceProvider.GetService<OutVariablesDemoApp>().Run();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

WriteLine("\n\nPress any key ...");
ReadKey();

static ServiceProvider ConfigureServices()
{
    // create service collection
    IServiceCollection services = new ServiceCollection();

    services.ConfigureOutVariablesServices();

    return services.BuildServiceProvider();
}
