using System.Globalization;

namespace QuickPoc.Set2
{
    public class TypeOfDemo
    {
        public static void ShowDemo()
        {

            PrintType<decimal>();
            List<decimal> prices = new() { 1.5m, 2.3m };
            PrintItems(prices);

            PrintType<float>();
            List<float> sales = new() { 11.55f, 22.33f };
            PrintItems(sales);

            PrintType<int>();
            List<int> rollNumbers = new() { 1, 2 };
            PrintItems(rollNumbers);

            PrintType<string>();
        }

        private static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

        private static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }

    }
}
