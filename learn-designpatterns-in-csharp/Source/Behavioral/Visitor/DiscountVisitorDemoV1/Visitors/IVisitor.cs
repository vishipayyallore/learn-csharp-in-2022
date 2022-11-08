using DiscountVisitorDemoV1.Elements;

namespace DiscountVisitorDemoV1.Visitors
{

    /// <summary>
    /// Visitor
    /// </summary>
    public interface IVisitor
    {
        void VisitCustomer(Customer customer);

        void VisitEmployee(Employee employee);
    }

}
