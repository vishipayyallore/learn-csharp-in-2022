using QuickPoc.Interfaces;

namespace QuickPoc.Set1
{
    public class FindTypes : IDemoProgram
    {

        public void ShowDemo()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var type = numbers.GetType();

            do
            {
                System.Console.WriteLine(type.FullName);
                type = type.BaseType;
            }
            while (type != null);
        }

    }

}
