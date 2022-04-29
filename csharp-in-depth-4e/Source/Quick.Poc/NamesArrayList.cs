using NameGenerator.Lib.Interfaces;
using System.Collections;

namespace Quick.Poc
{
    public class NamesArrayList
    {
        private readonly IGenerateName _nameGenerator;

        public NamesArrayList(IGenerateName nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public ArrayList GenerateNames()
        {
            ArrayList? names = new();

            for (int i = 0; i < 5; i++)
            {
                names.Add(_nameGenerator.GetName());
            }

            return names;
        }



    }
}
