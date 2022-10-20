namespace OrderServiceDemo.Subsystems
{

    /// <summary>
    /// Subsystem class
    /// </summary>
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId)
        {
            // does the customer have enough orders?  
            // fake calculation for demo purposes
            return (customerId > 5);
        }
    }

}
