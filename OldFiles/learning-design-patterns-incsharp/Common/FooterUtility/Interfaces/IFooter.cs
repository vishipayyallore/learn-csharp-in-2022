namespace FooterUtility.Interfaces
{
    public interface IFooter
    {
        void PrintFooter(char footer, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Cyan);
    }
}
