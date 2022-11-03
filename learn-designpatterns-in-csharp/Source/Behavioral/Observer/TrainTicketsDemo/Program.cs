using TrainTicketsDemo.Observers;
using TrainTicketsDemo.Subjects;
using static System.Console;

Title = "Design Pattern - Observer";

ForegroundColor = ConsoleColor.Cyan;

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

// add two observers
orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

// notify
orderService.CompleteTicketSale(1, 2);

// remove one observer
orderService.RemoveObserver(ticketResellerService);

// notify
orderService.CompleteTicketSale(2, 4);

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

