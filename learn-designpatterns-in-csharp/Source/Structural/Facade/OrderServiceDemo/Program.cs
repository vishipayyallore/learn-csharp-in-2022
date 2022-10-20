using OrderServiceDemo.Facades;
using static System.Console;

Title = "Design Pattern - Facade";

ForegroundColor = ConsoleColor.Cyan;

var facade = new DiscountFacade();
WriteLine($"Discount percentage for customer with id 1: {facade.CalculateDiscountPercentage(1)}");
WriteLine($"Discount percentage for customer with id 10: {facade.CalculateDiscountPercentage(10)}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
