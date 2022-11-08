using DiscountVisitorDemo.Elements;
using DiscountVisitorDemoV1.Elements;

namespace DiscountVisitorDemo.Visitors
{

    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountGiven { get; set; }

        public void VisitCustomer(Customer customer)
        {
            // percentage of total amount
            var discount = customer.AmountOrdered / 10;

            // set it on the customer
            customer.Discount = discount;

            // add it to the total amount
            TotalDiscountGiven += discount;
        }

        public void VisitEmployee(Employee employee)
        {
            // fixed value depending on the amount of years employed
            var discount = employee.YearsEmployed < 10 ? 100 : 200;

            // set it on the employee
            employee.Discount = discount;

            // add it to the total amount
            TotalDiscountGiven += discount;
        }
    }

}
