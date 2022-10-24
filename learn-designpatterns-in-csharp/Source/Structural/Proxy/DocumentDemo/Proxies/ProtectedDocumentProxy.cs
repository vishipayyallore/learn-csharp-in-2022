using DocumentDemo.Subjects;

using static System.Console;

namespace DocumentDemo.Proxies
{

    /// <summary>
    /// Protected Proxy
    /// </summary>
    public class ProtectedDocumentProxy : IDocument
    {
        private readonly string _fileName;
        private readonly string _userRole;
        private readonly DocumentProxy _documentProxy;

        public ProtectedDocumentProxy(string fileName, string userRole)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));

            _userRole = userRole ?? throw new ArgumentNullException(nameof(userRole));

            _documentProxy = new DocumentProxy(_fileName);
        }

        public void DisplayDocument()
        {
            WriteLine($"Entering DisplayDocument in {nameof(ProtectedDocumentProxy)}.");

            if (_userRole != "Viewer")
            {
                throw new UnauthorizedAccessException();
            }

            _documentProxy.DisplayDocument();

            WriteLine($"Exiting DisplayDocument in {nameof(ProtectedDocumentProxy)}.");
        }
    }

}
