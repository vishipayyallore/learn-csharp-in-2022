using CityClassAdapterDemo.Adapters;
using CityClassAdapterDemo.Targets;
using static System.Console;

Title = "Design Pattern - Class Adapter";

ForegroundColor = ConsoleColor.Cyan;

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

WriteLine($"{city.FullName}, {city.Inhabitants}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
