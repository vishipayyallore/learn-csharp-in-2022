using QuickPoc.Interfaces;
using static System.Console;

namespace QuickPoc.Set1
{

    public class AddNumbersV2 : IDemoProgram
    {

        public void ShowDemo()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var sum = AddNumbers(numbers);

            WriteLine($"Sum of {string.Join(',', numbers)} = {sum}");
        }

        private static int AddNumbers(int[] numbers)
        {
            var sum = numbers.Aggregate(
                0,
                (total, num) =>
                {
                    Console.WriteLine($"total = {total}, num = {num}");
                    return total + num;
                }
            );

            return sum;
        }

    }

}
