using ExportServiceDemo.Contexts;
using ExportServiceDemo.Strategies;

using static System.Console;

Title = "Design Pattern - Strategy";

ForegroundColor = ConsoleColor.Cyan;

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.Export(new CSVExportService());
order.Export(new JsonExportService());
order.Export(new XMLExportService());

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

