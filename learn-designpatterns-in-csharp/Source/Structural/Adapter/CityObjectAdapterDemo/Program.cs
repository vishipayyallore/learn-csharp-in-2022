using CityObjectAdapterDemo.Adapters;
using CityObjectAdapterDemo.Targets;
using static System.Console;

Title = "Design Pattern - Object Adapter";

ForegroundColor = ConsoleColor.Cyan;

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

WriteLine($"{city.FullName}, {city.Inhabitants}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
