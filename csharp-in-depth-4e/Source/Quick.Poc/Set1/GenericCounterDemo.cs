using Quick.Poc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Poc.Set1
{
    
    public class GenericCounterDemo : IDemoProgram
    {
        public void ShowDemo()
        {
            throw new NotImplementedException();
        }
    }

    public class GenericCounter<T>
    {
        private static int value;

        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }

}
