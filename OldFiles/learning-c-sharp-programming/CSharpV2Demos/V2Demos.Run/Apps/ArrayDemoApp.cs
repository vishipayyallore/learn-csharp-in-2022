﻿using ArrayDemo.Lib.Interfaces;
using HeaderFooter.Lib.Interfaces;

using static System.Console;

namespace V2Demos.Run.Apps
{
    public class ArrayDemoApp
    {

        private readonly INamesArray _namesArray;
        private readonly IPrintHelper _printHelper;
        private readonly IHeader _header;
        private readonly IFooter _footer;

        public ArrayDemoApp(INamesArray namesArray, IPrintHelper printHelper, IHeader header, IFooter footer)
        {
            _namesArray = namesArray ?? throw new ArgumentNullException(nameof(namesArray));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));

            _header = header ?? throw new ArgumentNullException(nameof(header));

            _footer = footer ?? throw new ArgumentNullException(nameof(footer));
        }

        public void Run()
        {
            Random _random = new();

            _header.DisplayHeader('=', "Names Array Demo");

            ForegroundColor = ConsoleColor.Cyan;
            _printHelper.Print(_namesArray.GenerateNames(numberOfNames: 10, nameLength: _random.Next(1, 10)));
            ResetColor();

            _footer.DisplayFooter('-');
        }

    }

}
