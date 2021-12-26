//using ArrayDemo.Lib;
//using ArrayDemo.Lib.Interfaces;
//using ArrayDemo.Run;
//using Microsoft.Extensions.DependencyInjection;
//using NameGenerator.Lib.Interfaces;
using static System.Console;

//// create service collection
//var services = ConfigureServices();

//// Generate a provider
//var serviceProvider = services.BuildServiceProvider();

//#pragma warning disable CS8602 // Dereference of a possibly null reference.
//serviceProvider.GetService<ArrayDemoApp>().Run();
//#pragma warning restore CS8602 // Dereference of a possibly null reference.

WriteLine("\n\nPress any key ...");
ReadKey();


//static IServiceCollection ConfigureServices()
//{
//    IServiceCollection services = new ServiceCollection();

//    // Register the Services
//    services.AddTransient<INameGenerator, NameGenerator.Lib.NameGenerator>();
//    services.AddTransient<INamesArray, NamesArray>();
//    services.AddTransient<IPrintHelper, PrintHelper>();

//    // IMPORTANT! Register the application entry point
//    services.AddTransient<ArrayDemoApp>();

//    return services;
//}
