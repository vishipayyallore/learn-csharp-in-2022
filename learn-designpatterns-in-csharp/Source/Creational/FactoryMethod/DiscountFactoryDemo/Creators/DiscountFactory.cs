using DiscountFactoryDemo.Products;

namespace DiscountFactoryDemo.Creators
{

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

}
