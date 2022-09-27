using LoggerDemo;
using static System.Console;

Console.Title = "Singleton";

// call the property getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the SAME.");
}
else
{
    Console.WriteLine("Instances are the DIFFERENT.");
}

instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

WriteLine("\n\nPress any key ...");
ReadKey();