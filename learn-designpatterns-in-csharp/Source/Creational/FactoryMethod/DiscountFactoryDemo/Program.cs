using DiscountFactoryDemo.Creators;

using static System.Console;

Title = "Design Pattern - Factory Method";

var factories = new List<DiscountFactory> {
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE") };

ForegroundColor = ConsoleColor.Cyan;

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
}

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
