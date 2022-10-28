using ExportServiceDemo.Contexts;

namespace ExportServiceDemo.Strategies
{

    /// <summary>
    /// Strategy
    /// </summary>
    public interface IExportService
    {
        void Export(Order order);
    }

}
