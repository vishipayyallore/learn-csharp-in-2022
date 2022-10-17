using FoodMenuDemo.Implementor;

namespace FoodMenuDemo.Abstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class MeatBasedMenu : FoodMenu
    {
        public MeatBasedMenu(ICoupon coupon) : base(coupon)
        {
        }
        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }

}
