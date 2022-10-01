using ShoppingCartDemo.Clients;
using ShoppingCartDemo.Factories;

using static System.Console;

Title = "Design Pattern - AbstractFactory";

ForegroundColor = ConsoleColor.Cyan;

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
