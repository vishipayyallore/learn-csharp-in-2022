using NamesArrayListDemo.Lib.Interfaces;
using System.Collections;

using static System.Console;

namespace NamesArrayListDemo.Lib
{

    public class PrintHelper : IPrintHelper
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
