using LoggerDemo;
using static System.Console;

Title = "Design Pattern - Singleton";

// call the property getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    ForegroundColor = ConsoleColor.Green;
    WriteLine("Instances are the SAME.");
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine("Instances are the DIFFERENT.");
}

ForegroundColor = ConsoleColor.Cyan;
instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();