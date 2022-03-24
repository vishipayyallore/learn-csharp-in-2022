using QuickPoc.Interfaces;

namespace QuickPoc.Set2
{

    public class GenericMethodDemo : IDemoProgram
    {

        public void ShowDemo()
        {
            List<int> numbersList = new() { 5, 10, 15, 20, 25 };
            List<string> namesList = new() { "Sri Varu", "Sri", "Maha Vishnu", "Apple", "Ant" };
            List<bool> boolList = new() { true, false, true, false, true };

            var firstTwoNumbers = CopyAtMost(numbersList, 2);
            DisplayListItems(firstTwoNumbers);

            var firstTwoNames = CopyAtMost(namesList, 2);
            DisplayListItems(firstTwoNames);

            DisplayListItems(CopyAtMost(boolList, 3));
        }

        private static List<T> CopyAtMost<T>(List<T> inputList, int maxElements)
        {
            var capacity = Math.Min(inputList.Count, maxElements);
            List<T> returnList = new(capacity);

            for (int i = 0; i < capacity; i++)
            {
                returnList.Add(inputList[i]);
            }

            return returnList;
        }

        private static void DisplayListItems<T>(List<T> inputList)
        {
            Console.WriteLine($"List Count: {inputList.Count}. Elements: {string.Join(", ", inputList)}");
        }

    }

}
