using DocumentDemo.Subjects;
using static System.Console;

Title = "Design Pattern - Proxy";

ForegroundColor = ConsoleColor.Cyan;

// without proxy
WriteLine("Constructing document.");
var document = new Document("MyDocument.pdf");
WriteLine("Document constructed.");
document.DisplayDocument();

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
