using ArrayDemo.Lib.Interfaces;

namespace V2Demos.Run.Apps
{
    public class ArrayDemoApp
    {

        private readonly INamesArray _namesArray;
        private readonly IPrintHelper _printHelper;

        public ArrayDemoApp(INamesArray namesArray, IPrintHelper printHelper)
        {
            _namesArray = namesArray ?? throw new ArgumentNullException(nameof(namesArray));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));
        }

        public void Run()
        {
            Random _random = new();
            _printHelper.Print(_namesArray.GenerateNames(numberOfNames: 10, nameLength: _random.Next(1, 10)));
        }
    }
}
