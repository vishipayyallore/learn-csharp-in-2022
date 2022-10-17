using FoodMenuDemo.Abstraction;
using FoodMenuDemo.Implementor;
using static System.Console;

Title = "Design Pattern - Bridge";

ForegroundColor = ConsoleColor.Cyan;

IList<ICoupon> coupons = new List<ICoupon>()
{
    new NoCoupon(),
    new OneEuroCoupon(),
    new TwoEuroCoupon()
};

foreach (var coupon in coupons)
{
    var meatBasedMenu = new MeatBasedMenu(coupon);
    WriteLine($"\nMeat based menu, {coupon}: {meatBasedMenu.CalculatePrice()} euro.");

    var vegetarianMenu = new VegetarianMenu(coupon);
    WriteLine($"\nVegetarian menu, {coupon}: {vegetarianMenu.CalculatePrice()} euro.");
}

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
