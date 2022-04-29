using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using System.Collections;

IGenerateName _nameGenerator = new GenerateName();

ArrayList? names = GenerateNames();
PrintNames(names);


