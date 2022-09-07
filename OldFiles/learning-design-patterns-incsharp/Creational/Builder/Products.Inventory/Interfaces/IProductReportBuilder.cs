namespace Products.Inventory.Interfaces
{

    public interface IProductReportBuilder
    {
        IProductReportBuilder AddHeader(string headerTitle);

        IProductReportBuilder AddProductDetails(IEnumerable<Product> products);

        IProductReportBuilder AddFooter(string footerText);

        IProductReportBuilder AddLogisticsDetails(string logisticsInfo);
    }

}
