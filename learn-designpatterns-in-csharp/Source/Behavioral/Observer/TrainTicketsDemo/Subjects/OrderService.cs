using TrainTicketsDemo.Models;

using static System.Console;

namespace TrainTicketsDemo.Subjects
{

    /// <summary>
    /// ConcreteSubject
    /// </summary>
    public class OrderService : TicketChangeNotifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            // change local datastore.  Datastore omitted in demo implementation.
            WriteLine($"{nameof(OrderService)} is changing its state.");

            // notify observers 
            WriteLine($"{nameof(OrderService)} is notifying observers...");

            Notify(new TicketChange(artistId, amount));
        }
    }

}
