using RomanExpressionDemoV1.Contexts;

namespace RomanExpressionDemoV1.AbstractExpressions
{

    /// <summary>
    /// AbstractExpression
    /// </summary>
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext value);
    }

}
