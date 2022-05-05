using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using Quick.Poc.Interfaces;

namespace Quick.Poc.Set1
{

    public class NamesWithList : IDemoProgram
    {

        // Temporary Fix
        private static readonly IGenerateName _nameGenerator = new GenerateName();

        public void ShowDemo()
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
