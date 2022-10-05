using GarageDemo.Builders;
using GarageDemo.Directors;

using static System.Console;

Title = "Design Pattern - Builder";

ForegroundColor = ConsoleColor.Cyan;

var garage = new Garage();

var miniBuilder = new MiniCarBuilder();
var bmwBuilder = new BMWCarBuilder();

garage.Construct(miniBuilder);
WriteLine(miniBuilder.Car.ToString());
garage.Show();

garage.Construct(bmwBuilder);
WriteLine(bmwBuilder.Car.ToString());
garage.Show();

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

