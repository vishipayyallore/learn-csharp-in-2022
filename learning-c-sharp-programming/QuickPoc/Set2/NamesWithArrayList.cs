using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using System.Collections;

using static System.Console;

namespace QuickPoc.Set2
{
    public class NamesWithArrayList
    {
        // Temporary Fix
        private static readonly IGenerateName _nameGenerator = new GenerateName();

        public static void ShowDemo()
        {
            ArrayList? names = GenerateNames();
            PrintNames(names);
        }

        private static ArrayList GenerateNames()
        {
            ArrayList? names = new();

            for (int i = 0; i < 5; i++)
            {
                names.Add(_nameGenerator.GetName());
            }

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
