using ArrayDemo.Lib.Interfaces;

using static System.Console;

namespace ArrayDemo.Lib
{
    public class PrintHelper : IPrintHelper
    {
        public void Print(string[] names)
        {
            int index = 1;

            Array.ForEach(names, (name) =>
            {
                WriteLine($"{index++}. {name} ({name.Length})");
            });
        }
    }
}
