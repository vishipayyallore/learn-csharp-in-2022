namespace DiscountVisitorDemo.Visitors
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
