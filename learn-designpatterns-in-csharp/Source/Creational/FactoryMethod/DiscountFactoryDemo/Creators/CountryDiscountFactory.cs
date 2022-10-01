using DiscountFactoryDemo.Products;

namespace DiscountFactoryDemo.Creators
{

    /// <summary>
    /// ConcretCreator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier ?? throw new ArgumentNullException(nameof(countryIdentifier));
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

}
