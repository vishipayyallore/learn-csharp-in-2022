using ShoppingCartDemo.DiscountProducts;
using ShoppingCartDemo.ShippingCostProducts;

namespace ShoppingCartDemo.Factories
{

    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostsService CreateShippingCostsService();
    }

}
