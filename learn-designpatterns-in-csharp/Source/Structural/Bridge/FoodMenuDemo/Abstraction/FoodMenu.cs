using FoodMenuDemo.Implementor;

namespace FoodMenuDemo.Abstraction
{

    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class FoodMenu
    {
        public readonly ICoupon _coupon;
        public abstract int CalculatePrice();

        public FoodMenu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }

}
