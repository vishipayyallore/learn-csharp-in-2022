using DocumentDemo.Proxies;
using DocumentDemo.Subjects;
using static System.Console;

Title = "Design Pattern - Proxy";

const string DocumentName = "ReportDocument.pdf";
string[] userRoles = { "Viewer", "Non-Viewer" };

ForegroundColor = ConsoleColor.Cyan;

// without proxy
WriteLine("Constructing document.");
var document = new Document(DocumentName);
WriteLine("Document constructed.");
document.DisplayDocument();

// with proxy 
WriteLine("Constructing document proxy.");
var documentProxy = new DocumentProxy(DocumentName);
WriteLine("Document proxy constructed.");
documentProxy.DisplayDocument();

// with chained proxy
WriteLine("Constructing protected document proxy.");
var protectedDocumentProxy = new ProtectedDocumentProxy(DocumentName, userRoles[0]);
WriteLine("Protected document proxy constructed.");
protectedDocumentProxy.DisplayDocument();

// with chained proxy, no access
WriteLine("Constructing protected document proxy.");
protectedDocumentProxy = new ProtectedDocumentProxy(DocumentName, userRoles[1]);
WriteLine("Protected document proxy constructed.");
protectedDocumentProxy.DisplayDocument();

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
