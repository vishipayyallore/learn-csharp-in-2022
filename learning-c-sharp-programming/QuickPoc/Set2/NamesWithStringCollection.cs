using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using QuickPoc.Interfaces;
using System.Collections.Specialized;

namespace QuickPoc.Set2
{

    public class NamesWithStringCollection : IDemoProgram
    {
        // Temporary Fix
        private static readonly IGenerateName _nameGenerator = new GenerateName();

        public void ShowDemo()
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

            foreach (string? name in names)
            {
                Console.WriteLine(name);
            }

        }

    }

}
