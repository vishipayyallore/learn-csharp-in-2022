namespace ShoppingCartDemo.ShippingCostProducts
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }

}