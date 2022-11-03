using TrainTicketsDemo.Models;

namespace TrainTicketsDemo.Observers
{

    /// <summary>
    /// Observer
    /// </summary>
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }

}