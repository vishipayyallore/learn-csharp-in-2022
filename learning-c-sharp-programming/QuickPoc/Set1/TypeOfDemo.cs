namespace QuickPoc.Set1
{
    public class TypeOfDemo
    {
        public static void ShowDemo()
        {
            PrintType<string>();
            PrintType<int>();
        }

        private static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

    }
}
