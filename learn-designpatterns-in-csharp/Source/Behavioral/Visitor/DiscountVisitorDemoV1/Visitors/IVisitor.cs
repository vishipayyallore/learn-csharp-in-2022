using DiscountVisitorDemoV1.Elements;

namespace DiscountVisitorDemoV1.Visitors
{

    /// <summary>
    /// Visitor (V1)
    /// </summary>
    public interface IVisitor
    {
        void Visit(IElement element);
    }

}
