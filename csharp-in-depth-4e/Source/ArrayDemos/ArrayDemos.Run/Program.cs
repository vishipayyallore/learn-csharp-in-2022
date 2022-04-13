using ArrayDemos.Run.Apps;
using ArrayDemos.Run.Dependencies;
using Microsoft.Extensions.DependencyInjection;

using static System.Console;

// Generate a provider
var serviceProvider = ConfigureNamesArrayDemoApp.ConfigureServices();

Console.ResetColor();

serviceProvider?.GetService<NamesArrayDemoApp>()?.Run();

WriteLine("\n\nPress any key ...");
ReadKey();
