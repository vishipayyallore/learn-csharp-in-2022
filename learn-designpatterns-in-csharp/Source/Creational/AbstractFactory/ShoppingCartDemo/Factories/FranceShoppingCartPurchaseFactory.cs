using ShoppingCartDemo.DiscountProducts;
using ShoppingCartDemo.ShippingCostProducts;

namespace ShoppingCartDemo.Factories
{
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }

}
