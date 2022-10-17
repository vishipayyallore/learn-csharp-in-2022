using FoodMenuDemo.Implementor;

namespace FoodMenuDemo.Abstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class VegetarianMenu : FoodMenu
    {
        public VegetarianMenu(ICoupon coupon) : base(coupon)
        {
        }

        public override int CalculatePrice() => 20 - _coupon.CouponValue;
    }

}
