using Quick.Poc.Interfaces;
using Quick.Poc.Set1.Helpers;

namespace Quick.Poc.Set1
{

    public class GenericCounterDemo : IDemoProgram
    {

        public void ShowDemo()
        {
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }

    }

}
