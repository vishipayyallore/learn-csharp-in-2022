using DocumentDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace DocumentDemo.Handlers
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class DocumentLastModifiedHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (document.LastModified < DateTime.UtcNow.AddDays(-30))
            {
                // validation doesn't check out
                throw new ValidationException(
                    new ValidationResult(
                        "Document must be modified in the last 30 days",
                        new List<string>() { "LastModified" }), null, null);
            }

            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }


}
