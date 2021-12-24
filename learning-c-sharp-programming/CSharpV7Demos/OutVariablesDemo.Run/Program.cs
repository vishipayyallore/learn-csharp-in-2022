// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using OutVariablesDemo.Lib;
using OutVariablesDemo.Run;
using static System.Console;

// create service collection
var services = ConfigureServices();

// Generate a provider
var serviceProvider = services.BuildServiceProvider();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
serviceProvider.GetService<OutVariablesDemoApp>().Run();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

WriteLine("\n\nPress any key ...");
ReadKey();

static IServiceCollection ConfigureServices()
{
    IServiceCollection services = new ServiceCollection();

    // Register the Services
    services.AddTransient<IIntegerParser, IntegerParser>();

    // IMPORTANT! Register the application entry point
    services.AddTransient<OutVariablesDemoApp>();

    return services;
}
