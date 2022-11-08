using DiscountVisitorDemoV1.Visitors;

namespace DiscountVisitorDemoV1.Elements
{

    /// <summary>
    /// Element
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

}
