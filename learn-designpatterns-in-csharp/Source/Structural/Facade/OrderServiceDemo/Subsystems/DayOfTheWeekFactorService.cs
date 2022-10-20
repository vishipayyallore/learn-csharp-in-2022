namespace OrderServiceDemo.Subsystems
{
    /// <summary>
    /// Subsystem class
    /// </summary>
    public class DayOfTheWeekFactorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            // fake calculation for demo purposes
            return DateTime.UtcNow.DayOfWeek switch
            {
                DayOfWeek.Saturday or DayOfWeek.Sunday => 0.8,
                _ => 1.2,
            };
        }
    }

}
