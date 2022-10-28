using ExportServiceDemo.Contexts;

using static System.Console;

namespace ExportServiceDemo.Strategies
{
    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            WriteLine($"Exporting {order.Name} to XML.");
        }
    }

}
