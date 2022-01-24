using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using QuickPoc.Set1;
using QuickPoc.Set2;
using static System.Console;

IHeader header = new Header();
IFooter footer = new Footer();

AssemblyTypesAndMethodsDemo.ShowDemo();
BasicDataTypesRangeDemo.ShowDemo();

header.DisplayHeader('=', "Names With ArrayList");
NamesWithArrayList.ShowDemo();
footer.DisplayFooter('-');

header.DisplayHeader('=', "Names With String Collection");
NamesWithStringCollection.ShowDemo();
footer.DisplayFooter('-');

header.DisplayHeader('=', "Names With List");
NamesWithList.ShowDemo();
footer.DisplayFooter('-');

header.DisplayHeader('=', "Generic Method Demo");
GenericMethodDemo.ShowDemo();
footer.DisplayFooter('-');

header.DisplayHeader('=', "TypeOf() Demo");
TypeOfDemo.ShowDemo();
footer.DisplayFooter('-');

// Test Run
//IGenerateName _nameGenerator = new GenerateName();
//for (int i = 0; i < 1_00_00_000; i++)
//{
//    Console.WriteLine(_nameGenerator.GetName());
//}


WriteLine("\n\n Press any key ...");