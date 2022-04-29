using System.Collections;

using static System.Console;

namespace Quick.Poc
{
    public class PrintHelper
    {

        public void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                WriteLine(name);
            }
        }

    }

}
