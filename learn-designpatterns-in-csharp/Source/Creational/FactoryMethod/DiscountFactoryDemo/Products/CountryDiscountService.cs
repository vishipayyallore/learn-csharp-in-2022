namespace DiscountFactoryDemo.Products
{

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier ?? throw new ArgumentNullException(nameof(countryIdentifier));
        }

        public override int DiscountPercentage
        {
            get
            {
                return _countryIdentifier switch
                {
                    // if you're from Belgium, you get a better discount :)
                    "BE" => 20,
                    _ => 10,
                };
            }
        }
    }

}
