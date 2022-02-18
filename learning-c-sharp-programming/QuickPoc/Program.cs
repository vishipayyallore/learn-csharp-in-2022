using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using QuickPoc.Interfaces;
using QuickPoc.Set;
using QuickPoc.Set1;
using QuickPoc.Set2;
using static System.Console;

IHeader _header = new Header();
IFooter _footer = new Footer();

// Set Group Programs
RunDemoProgram(new AssemblyTypesAndMethodsDemo(), "Assembly Types And Methods");
RunDemoProgram(new BasicDataTypesRangeDemo(), "Basic DataTypes Range Demo");

// Set 1 Group Programs
RunDemoProgram(new FindTypes(), "Find Types");
RunDemoProgram(new AddNumbersV1(), "Sum of numbers Array V1");
RunDemoProgram(new AddNumbersV2(), "Sum of numbers Array V2");

// Set 2 Group Programs
RunDemoProgram(new GenericMethodDemo(), "Generic Method Demo");
RunDemoProgram(new NamesWithArrayList(), "Names With ArrayList");
RunDemoProgram(new NamesWithList(), "Names With List");
RunDemoProgram(new NullableBoxingDemo(), "Nullable Boxing Demo");
RunDemoProgram(new TypeOfDemo(), "TypeOf() Demo");

void RunDemoProgram(IDemoProgram demoProgram, string programTitle = "No Title")
{
    _header.DisplayHeader('=', programTitle);

    ForegroundColor = ConsoleColor.Cyan;
    demoProgram.ShowDemo();
    Console.ResetColor();

    _footer.DisplayFooter('-');
}

WriteLine("\n\n Press any key ...");

