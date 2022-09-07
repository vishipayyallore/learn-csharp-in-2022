using NameGenerator.Lib.Interfaces;
using NamesArrayDemo.Lib.Interfaces;

namespace NamesArrayDemo.Lib
{

    public class NamesArray : INamesArray
    {
        private readonly IGenerateName _nameGenerator;

        public NamesArray(IGenerateName nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public string[] GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            string[] names = new string[numberOfNames];

            for (int index = 0; index < numberOfNames; index++)
            {
                names[index] = _nameGenerator.GetName(nameLength);
            }

            return names;
        }

    }

}