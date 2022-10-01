using ShoppingCartDemo.DiscountProducts;
using ShoppingCartDemo.Factories;
using ShoppingCartDemo.ShippingCostProducts;

using static System.Console;

namespace ShoppingCartDemo.Clients
{

    /// <summary>
    /// Client class 
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;

        private readonly IShippingCostsService _shippingCostsService;

        private readonly int _orderCosts;

        // Constructor
        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();

            _shippingCostsService = factory.CreateShippingCostsService();

            // assume that the total cost of all the items we ordered = 200 euro
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
        }
    }

}
