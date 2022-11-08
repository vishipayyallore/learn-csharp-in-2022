using DiscountVisitorDemoV1.Visitors;
using static System.Console;

namespace DiscountVisitorDemoV1.Elements
{

    /// <summary>
    /// ConcreteElement
    /// </summary>
    public class Customer : IElement
    {
        public decimal AmountOrdered { get; private set; }

        public decimal Discount { get; set; }

        public string Name { get; private set; }

        public Customer(string name, decimal amountOrdered)
        {
            Name = name;

            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            WriteLine($"Visited {nameof(Customer)} {Name}, discount given: {Discount}");
        }
    }

}
