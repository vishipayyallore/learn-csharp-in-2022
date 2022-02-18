using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using QuickPoc.Set;
using QuickPoc.Set1;
using QuickPoc.Set2;
using static System.Console;

IHeader _header = new Header();
IFooter _footer = new Footer();

_header.DisplayHeader('=', "Find Types");
ForegroundColor = ConsoleColor.Cyan;
FindTypes.ShowDemo();
Console.ResetColor();
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Sum of numbers Array V1");
ForegroundColor = ConsoleColor.Cyan;
AddNumbersV1.ShowDemo();
Console.ResetColor();
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Sum of numbers Array V2");
ForegroundColor = ConsoleColor.Cyan;
AddNumbersV2.ShowDemo();
Console.ResetColor();
_footer.DisplayFooter('-');

AssemblyTypesAndMethodsDemo.ShowDemo();
BasicDataTypesRangeDemo.ShowDemo();

_header.DisplayHeader('=', "Names With ArrayList");
NamesWithArrayList.ShowDemo();
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Names With String Collection");
ForegroundColor = ConsoleColor.Cyan;
NamesWithStringCollection.ShowDemo();
ForegroundColor = ConsoleColor.White;
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Names With List");
ForegroundColor = ConsoleColor.Cyan;
NamesWithList.ShowDemo();
ForegroundColor = ConsoleColor.White;
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Generic Method Demo");
ForegroundColor = ConsoleColor.Cyan;
GenericMethodDemo.ShowDemo();
ForegroundColor = ConsoleColor.White;
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "TypeOf() Demo", foregroundColor: ConsoleColor.Yellow);
ForegroundColor = ConsoleColor.Cyan;
TypeOfDemo.ShowDemo();
ForegroundColor = ConsoleColor.White;
_footer.DisplayFooter('-');

_header.DisplayHeader('=', "Nullable Boxing Demo", foregroundColor: ConsoleColor.Yellow);
ForegroundColor = ConsoleColor.Cyan;
NullableBoxingDemo.ShowDemo();
ResetColor();
_footer.DisplayFooter('-');

WriteLine("\n\n Press any key ...");

