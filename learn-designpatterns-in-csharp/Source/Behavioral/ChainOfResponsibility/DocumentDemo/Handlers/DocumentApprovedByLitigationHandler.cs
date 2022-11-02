﻿using DocumentDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace DocumentDemo.Handlers
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class DocumentApprovedByLitigationHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (!document.ApprovedByLitigation)
            {
                // validation doesn't check out
                throw new ValidationException(
                    new ValidationResult(
                        "Document must be approved by litigation",
                        new List<string>() { "ApprovedByLitigation" }), null, null);
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
