using HeaderFooter.Lib.Interfaces;
using NamesArrayListDemo.Lib.Interfaces;

using static System.Console;

namespace ArrayListDemos.Run.Apps
{
    public class NamesArrayListDemoApp
    {
        private readonly INamesArrayList _namesArrayList;
        private readonly IPrintHelper _printHelper;
        private readonly IHeader _header;
        private readonly IFooter _footer;

        public NamesArrayListDemoApp(INamesArrayList namesArrayList, IPrintHelper printHelper, IHeader header, IFooter footer)
        {
            _namesArrayList = namesArrayList ?? throw new ArgumentNullException(nameof(namesArrayList));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));

            _header = header ?? throw new ArgumentNullException(nameof(header));

            _footer = footer ?? throw new ArgumentNullException(nameof(footer));
        }

        public void Run()
        {
            Random _random = new();

            _header.DisplayHeader('=', "Names ArrayList Demo");

            ForegroundColor = ConsoleColor.Cyan;
            _printHelper.Print(_namesArrayList.GenerateNames(numberOfNames: 10, nameLength: _random.Next(1, 10)));
            ResetColor();

            _footer.DisplayFooter('-');
        }

    }

}
