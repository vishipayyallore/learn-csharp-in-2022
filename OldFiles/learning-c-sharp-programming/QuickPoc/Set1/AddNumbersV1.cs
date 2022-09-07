using QuickPoc.Interfaces;
using static System.Console;

namespace QuickPoc.Set1
{

    public class AddNumbersV1 : IDemoProgram
    {

        public void ShowDemo()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            WriteLine($"Sum of {string.Join(',', numbers)} = {AddNumbers(numbers)}");
        }

        private static int AddNumbers(int[] numbers)
        {
            var sum = numbers.Aggregate(0 /*Initial value of accumulator */,
                (total, num) => total + num /* Operation to perform on each value */);

            return sum;
        }

    }

}
