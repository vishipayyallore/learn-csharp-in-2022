using DocumentDemo.Subjects;

namespace DocumentDemo.Proxies
{

    /// <summary>
    /// Proxy
    /// </summary>
    public class DocumentProxy : IDocument
    {
        // avoid creating the document until we need it 
        private readonly Lazy<Document> _document;
        private readonly string _fileName;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));

            _document = new Lazy<Document>(() => new Document(_fileName));
        }

        public void DisplayDocument()
        {
            _document.Value.DisplayDocument();
        }
    }

}
