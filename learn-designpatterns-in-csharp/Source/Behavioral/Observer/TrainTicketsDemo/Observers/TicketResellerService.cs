using TrainTicketsDemo.Models;

using static System.Console;

namespace TrainTicketsDemo.Observers
{

    /// <summary>
    /// ConcreteObserver
    /// </summary>
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            // update local datastore (datastore omitted in demo implementation)
            WriteLine($"{nameof(TicketResellerService)} notified of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
        }
    }


}
