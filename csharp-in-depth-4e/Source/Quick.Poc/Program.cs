using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using Quick.Poc.Helpers;
using Quick.Poc.Interfaces;
using Quick.Poc.Set1;
using static System.Console;

// Set 2 Group Programs
DemoPrograms.Run(new NamesWithStringCollection(), "Names With ArrayList");
DemoPrograms.Run(new NamesWithList(), "Names With List");
DemoPrograms.Run(new NullableBoxingDemo(), "Nullable Boxing Demo");

Console.WriteLine("\nPress any key ...");


