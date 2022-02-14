using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using System.Collections.Specialized;

namespace QuickPoc.Set2
{
    public class NamesWithStringCollection
    {
        // Temporary Fix
        private static readonly IGenerateName _nameGenerator = new GenerateName();

        public static void ShowDemo()
        {
            StringCollection names = GenerateNames();
            PrintNames(names);
        }

        private static StringCollection GenerateNames()
        {
            StringCollection names = new();

            for (int i = 0; i < 5; i++)
            {
                names.Add(_nameGenerator.GetName());
            }

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
