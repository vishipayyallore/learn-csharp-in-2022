namespace QuickPoc.Set1
{
    public class NamesWithList
    {

        public static void ShowDemo()
        {
            List<string> names = GenerateNames();
            PrintNames(names);
        }


        private static List<string> GenerateNames()
        {
            List<string> names = new List<string>();

            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");

            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }

}
