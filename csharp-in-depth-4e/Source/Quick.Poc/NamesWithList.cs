using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;

namespace Quick.Poc
{

    public class NamesWithList
    {

        // Temporary Fix
        private static readonly IGenerateName _nameGenerator = new GenerateName();

        public static void ShowDemo()
        {
            List<string> names = GenerateNames();
            PrintNames(names);
        }

        private static List<string> GenerateNames()
        {
            List<string> names = new();

            for (int i = 0; i < 5; i++)
            {
                names.Add(_nameGenerator.GetName());
            }

            return names;
        }

        static void PrintNames(List<string> names)
        {
            names.ForEach(name =>
            {
                Console.WriteLine(name);
            });
        }

    }

}
