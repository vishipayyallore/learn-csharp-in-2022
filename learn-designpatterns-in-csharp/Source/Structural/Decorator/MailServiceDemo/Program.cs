using MailServiceDemo.Components;
using MailServiceDemo.Decorators;
using static System.Console;

Title = "Design Pattern - Decorator";

ForegroundColor = ConsoleColor.Cyan;

var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hi there.");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Hi there.");

// add behavior
var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wrapper.");

// add behavior
var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 1.");
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 2.");

foreach (var message in messageDatabaseDecorator.SentMessages)
{
    WriteLine($"Stored message: \"{message}\"");
}

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
