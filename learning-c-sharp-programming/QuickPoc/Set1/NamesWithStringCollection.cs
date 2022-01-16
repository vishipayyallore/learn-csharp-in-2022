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

            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");

            return names;
        }

        private static void PrintNames(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }

}
