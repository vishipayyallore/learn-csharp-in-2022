using HeaderUtility.Interfaces;

using static System.Console;

namespace HeaderUtility
{

    public class Header : IHeader
    {

        public void PrintHeader(char headerPattern, string title, int length = 100)
        {
            var leftPadValue = ((length - title.Length) / 2) + title.Length;
            string headerValue = new(headerPattern, length);

            WriteLine($"\n\n{headerValue}");
            WriteLine(title.PadLeft(leftPadValue));
            WriteLine($"{headerValue}\n");
        }

    }

}