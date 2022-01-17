using System.Collections.Specialized;

namespace QuickPoc.Set1
{
    public class NamesWithStringCollection
    {
        public static void ShowDemo()
        {
            StringCollection names = GenerateNames();
            PrintNames(names);
        }

        private static StringCollection GenerateNames()
        {
            StringCollection names = new();

            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");

            return names;
        }

        private static void PrintNames(StringCollection names)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            foreach (string name in names)
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            {
                Console.WriteLine(name);
            }
        }

    }

}
