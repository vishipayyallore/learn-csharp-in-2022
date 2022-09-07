using FooterUtility;
using FooterUtility.Interfaces;
using HeaderUtility;
using HeaderUtility.Interfaces;
using Products.Inventory.Interfaces;

using static System.Console;

namespace Products.Inventory
{

    public class ProductReportBuilder : IProductReportBuilder
    {

        const int _patternLength = 170;

        // TODO: These should come from Dependency Injection
        readonly IHeader _header = new Header();
        readonly IFooter _footer = new Footer();

        public IProductReportBuilder AddHeader(string headerTitle)
        {
            _header.PrintHeader('*', headerTitle, _patternLength);

            return this;
        }

        public IProductReportBuilder AddProductDetails(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                WriteLine(product);
            }

            return this;
        }

        public IProductReportBuilder AddLogisticsDetails(string logisticsInfo)
        {
            WriteLine($"Report was signed by {logisticsInfo} on {DateTime.Now}");

            return this;
        }

        public IProductReportBuilder AddFooter(string footerText)
        {
            _footer.PrintFooter('-', _patternLength);

            return this;
        }

    }

}
