using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using System.Collections;

using static System.Console;

IGenerateName _nameGenerator = new GenerateName();

ArrayList? names = GenerateNames();
PrintNames(names);

ArrayList GenerateNames()
{
    ArrayList? names = new();

    for (int i = 0; i < 5; i++)
    {
        names.Add(_nameGenerator.GetName());
    }

    return names;
}

void PrintNames(ArrayList names)
{
    foreach (string name in names)
    {
        WriteLine(name);
    }
}
