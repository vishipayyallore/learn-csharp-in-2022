using DocumentDemo.Handlers;
using DocumentDemo.Models;
using System.ComponentModel.DataAnnotations;
using static System.Console;

Title = "Design Pattern - ChainOfResponsibility";

ForegroundColor = ConsoleColor.Cyan;

var validDocument = new Document("How to Avoid Java Development", DateTimeOffset.UtcNow, true, true);

var invalidDocument = new Document("How to Avoid Java Development", DateTimeOffset.UtcNow, false, true);

// chain a set of handlers
var documentHandlerChain = new DocumentTitleHandler();
documentHandlerChain
    .SetSuccessor(new DocumentLastModifiedHandler())
    .SetSuccessor(new DocumentApprovedByLitigationHandler())
    .SetSuccessor(new DocumentApprovedByManagementHandler());

try
{
    documentHandlerChain.Handle(validDocument);
    WriteLine("Valid document is valid.");

    documentHandlerChain.Handle(invalidDocument);
    WriteLine("Invalid document is valid.");
}
catch (ValidationException validationException)
{
    WriteLine(validationException.Message);
}

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

