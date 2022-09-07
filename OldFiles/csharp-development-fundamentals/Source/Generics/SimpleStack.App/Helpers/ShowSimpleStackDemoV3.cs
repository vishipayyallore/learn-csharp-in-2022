using SimpleStack.Lib.V3;
using static System.Console;

namespace SimpleStack.App.Helpers
{
    public static class ShowSimpleStackDemoV3
    {
        public static void StackDoubles()
        {
            var stack = new SimpleStackGeneric<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            WriteLine($"Sum: {sum}");
        }

        public static void StackStrings()
        {
            var stack = new SimpleStackGeneric<string>();
            stack.Push("Pluralsight");
            stack.Push("Udemy");
            stack.Push("Cloud Academy");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

    }

}
