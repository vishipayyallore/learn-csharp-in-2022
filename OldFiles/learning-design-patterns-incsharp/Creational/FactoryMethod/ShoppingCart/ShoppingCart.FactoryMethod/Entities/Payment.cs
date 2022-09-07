namespace ShoppingCart.FactoryMethod.Entities
{

    public class Payment
    {
        public decimal Amount { get; set; }

        public PaymentProvider PaymentProvider { get; set; }
    }

}
