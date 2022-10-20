namespace OrderServiceDemo.Subsystems
{
    /// <summary>
    /// Subsystem class
    /// </summary>
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId)
        {
            // fake calculation for demo purposes
            return (customerId > 8) ? 10 : 20;
        }
    }

}
