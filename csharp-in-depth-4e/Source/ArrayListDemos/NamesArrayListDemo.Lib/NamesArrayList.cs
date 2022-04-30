using NameGenerator.Lib.Interfaces;
using NamesArrayListDemo.Lib.Interfaces;
using System.Collections;

namespace NamesArrayListDemo.Lib
{

    public class NamesArrayList : INamesArrayList
    {
        private readonly IGenerateName _nameGenerator;

        public NamesArrayList(IGenerateName nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public ArrayList GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            ArrayList? names = new();

            for (int i = 0; i < numberOfNames; i++)
            {
                names.Add(_nameGenerator.GetName(nameLength));
            }

            return names;
        }

    }


}
