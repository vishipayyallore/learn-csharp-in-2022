using SimpleStack.Lib.V1;

using static System.Console;

namespace SimpleStack.App.Helpers
{
    public static class ShowSimpleStackDemoV1
    {
        public static void StackDoubles()
        {
            var stack = new SimpleStackDouble();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                WriteLine($"Item: {item}");
                sum += item;
            }

            WriteLine($"Sum: {sum}");
        }

        public static void StackStrings()
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

    }

}
