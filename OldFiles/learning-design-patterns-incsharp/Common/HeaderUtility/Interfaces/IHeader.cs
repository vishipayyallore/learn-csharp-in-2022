namespace HeaderUtility.Interfaces
{

    public interface IHeader
    {
        void PrintHeader(char header, string title, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Cyan);
    }

}