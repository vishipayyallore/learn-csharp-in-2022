using FooterUtility.Interfaces;

using static System.Console;

namespace FooterUtility
{
    public class Footer : IFooter
    {
        public void PrintFooter(char footer, int length = 100)
        {
            WriteLine($"\n{new string(footer, length)}\n");
        }

    }
    
}