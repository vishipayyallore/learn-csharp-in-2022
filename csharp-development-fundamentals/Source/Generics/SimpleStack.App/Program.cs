using SimpleStack.App.Helpers;
using SimpleStack.Lib.V1;
using static System.Console;

ShowSimpleStackDemoV1.StackDoubles();
StackStrings();

WriteLine("\n\nPress any key ...");



static void StackStrings()
{
    var stack = new SimpleStackString();
    stack.Push("Pluralsight");
    stack.Push("Udemy");
    stack.Push("Cloud Academy");

    while (stack.Count > 0)
    {
        Console.WriteLine(stack.Pop());
    }
}