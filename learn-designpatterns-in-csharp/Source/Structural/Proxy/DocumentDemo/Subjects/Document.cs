using static System.Console;

namespace DocumentDemo.Subjects
{

    /// <summary>
    /// RealSubject
    /// </summary>
    public class Document : IDocument
    {
        private readonly string _fileName;

        public string? Title { get; private set; }

        public string? Content { get; private set; }

        public int AuthorId { get; private set; }

        public DateTimeOffset LastAccessed { get; private set; }


        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(fileName);
        }

        private void LoadDocument(string fileName)
        {
            WriteLine("Executing expensive action: loading a file from disk");

            // fake loading...
            Thread.Sleep(1000);

            Title = "An expensive document";
            Content = "Lots and lots of content";
            AuthorId = 1;
            LastAccessed = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
        {
            WriteLine($"Title: {Title}, Content: {Content}.\n");
        }
    }

}
