using System.Collections;

using static System.Console;

namespace QuickPoc
{
    public class NamesWithArrayList
    {
        public static void ShowDemo()
        {
            ArrayList? names = GenerateNames();
            PrintNames(names);
        }

        private static ArrayList GenerateNames()
        {
            ArrayList? names = new();

            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");

            return names;
        }

        private static void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                WriteLine(name);
            }
        }
    }
}
