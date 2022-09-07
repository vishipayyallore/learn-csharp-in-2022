using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using Quick.Poc.Interfaces;

using static System.Console;

namespace Quick.Poc.Helpers
{

    public static class DemoPrograms
    {

        private static readonly IHeader _header = new Header();
        private static readonly IFooter _footer = new Footer();

        public static void Run(IDemoProgram demoProgram, string programTitle = "No Title")
        {
            _header.DisplayHeader('=', programTitle);

            ForegroundColor = ConsoleColor.Cyan;
            demoProgram.ShowDemo();
            Console.ResetColor();

            _footer.DisplayFooter('-');
        }

    }

}
