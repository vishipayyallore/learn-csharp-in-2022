using ArrayListDemos.Run.Apps;
using ArrayListDemos.Run.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using static System.Console;

// Generate a provider
var serviceProvider = ConfigureNamesArrayListDemoApp.ConfigureServices();

Console.ResetColor();

serviceProvider?.GetService<NamesArrayListDemoApp>()?.Run();

WriteLine("\n\nPress any key ...");
ReadKey();
