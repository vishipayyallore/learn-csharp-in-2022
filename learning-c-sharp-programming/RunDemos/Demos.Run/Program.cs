using ArrayDemo.Lib.Sample;
using Demos.Run.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using OutVariablesDemo.Lib.Sample;
using static System.Console;


// Generate a provider
var serviceProvider = ConfigureServices();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
serviceProvider.GetService<OutVariablesDemoApp>().Run();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
serviceProvider.GetService<ArrayDemoApp>().Run();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

WriteLine("\n\nPress any key ...");
ReadKey();

static ServiceProvider ConfigureServices()
{
    // create service collection
    IServiceCollection services = new ServiceCollection();

    services.ConfigureOutVariablesServices();

    services.ConfigureArrayDemoServices();

    return services.BuildServiceProvider();
}
