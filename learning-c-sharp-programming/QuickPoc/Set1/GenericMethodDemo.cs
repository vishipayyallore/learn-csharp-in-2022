namespace QuickPoc.Set1
{

    public class GenericMethodDemo
    {

        public static void ShowDemo()
        {
            List<int> numbers = new() { 5, 10, 15, 20, 25 };

            List<int> firstTwo = CopyAtMost<int>(numbers, 2);
            Console.WriteLine($"List Count: {firstTwo.Count}. Elements: {string.Join(", ", firstTwo)}");
        }

        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            var capacity = Math.Min(input.Count, maxElements);
            List<T> returnList = new(capacity);

            for (int i = 0; i < capacity; i++)
            {
                returnList.Add(input[i]);
            }

            return returnList;
        }

    }

}
