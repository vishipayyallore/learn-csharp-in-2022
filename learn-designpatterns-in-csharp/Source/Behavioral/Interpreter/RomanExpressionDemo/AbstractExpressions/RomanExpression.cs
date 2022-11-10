using RomanExpressionDemo.Contexts;

namespace RomanExpressionDemo.AbstractExpressions
{

    /// <summary>
    /// AbstractExpression
    /// </summary>
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext value);
    }

}
