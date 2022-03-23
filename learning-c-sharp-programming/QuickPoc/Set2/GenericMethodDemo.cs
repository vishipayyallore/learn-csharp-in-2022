using QuickPoc.Interfaces;

namespace QuickPoc.Set2
{

    public class GenericMethodDemo : IDemoProgram
    {

        public void ShowDemo()
        {
            List<int> numbersList = new() { 5, 10, 15, 20, 25 };

            List<int> firstTwoNumbers = CopyAtMost(numbersList, 2);
            Console.WriteLine($"List Count: {firstTwoNumbers.Count}. Elements: {string.Join(", ", firstTwoNumbers)}");
        }

        public static List<T> CopyAtMost<T>(List<T> numbersList, int maxElements)
        {
            var capacity = Math.Min(numbersList.Count, maxElements);
            List<T> returnList = new(capacity);

            for (int i = 0; i < capacity; i++)
            {
                returnList.Add(numbersList[i]);
            }

            return returnList;
        }

    }

}
