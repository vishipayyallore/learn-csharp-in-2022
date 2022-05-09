namespace Quick.Poc.Set1.Helpers
{

    public class GenericCounter<T>
    {

        private static int _value;

        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            _value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), _value);
        }

    }

}
