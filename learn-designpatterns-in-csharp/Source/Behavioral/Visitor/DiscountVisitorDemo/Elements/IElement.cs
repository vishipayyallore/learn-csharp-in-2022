using DiscountVisitorDemo.Visitors;

namespace DiscountVisitorDemo.Elements
{

    /// <summary>
    /// Element
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

}
