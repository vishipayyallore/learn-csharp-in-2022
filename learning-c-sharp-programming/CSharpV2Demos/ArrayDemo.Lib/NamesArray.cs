using ArrayDemo.Lib.Interfaces;
using NameGenerator.Lib.Interfaces;

namespace ArrayDemo.Lib
{

    public class NamesArray : INamesArray
    {
        private readonly INameGenerator _nameGenerator;

        public NamesArray(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public string[] GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            string[] names = new string[numberOfNames];

            for (int index = 0; index < numberOfNames; index++)
            {
                names[index] = _nameGenerator.GenerateName(nameLength);
            }

            return names;
        }

    }

}