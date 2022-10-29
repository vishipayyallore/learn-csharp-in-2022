using ExportServiceDemo.Contexts;

using static System.Console;

namespace ExportServiceDemo.Strategies
{
    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
            WriteLine($"Exporting {order.Name} to CSV.");
        }
    }

}
