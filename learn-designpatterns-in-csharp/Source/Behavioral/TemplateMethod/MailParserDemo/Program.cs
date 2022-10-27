using MailParserDemo.TemplateMethods;
using static System.Console;

Title = "Design Pattern - TemplateMethod";

ForegroundColor = ConsoleColor.Cyan;

ExchangeMailParser exchangeMailParser = new();
WriteLine(exchangeMailParser.ParseMailBody("bf3a298c-9990-4b02-873d-3d3c98ad16d2"));
WriteLine();

ApacheMailParser apacheMailParser = new();
WriteLine(apacheMailParser.ParseMailBody("07b8a8c7-c598-4b6c-9049-ecce9fe4a56b"));
WriteLine();

EudoraMailParser eudoraMailParser = new();
WriteLine(eudoraMailParser.ParseMailBody("789fe935-ced2-4fbd-865b-172909560a93"));

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
