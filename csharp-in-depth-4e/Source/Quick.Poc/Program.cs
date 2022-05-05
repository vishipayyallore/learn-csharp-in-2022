using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using Quick.Poc.Interfaces;
using Quick.Poc.Set1;
using static System.Console;

IHeader _header = new Header();
IFooter _footer = new Footer();

// Set 2 Group Programs
RunDemoProgram(new NamesWithStringCollection(), "Names With ArrayList");
RunDemoProgram(new NamesWithList(), "Names With List");
RunDemoProgram(new NullableBoxingDemo(), "Nullable Boxing Demo");

Console.WriteLine("\nPress any key ...");

void RunDemoProgram(IDemoProgram demoProgram, string programTitle = "No Title")
{
    _header.DisplayHeader('=', programTitle);

    ForegroundColor = ConsoleColor.Cyan;
    demoProgram.ShowDemo();
    Console.ResetColor();

    _footer.DisplayFooter('-');
}
