using RomanExpressionDemoV1.AbstractExpressions;
using RomanExpressionDemoV1.Contexts;

namespace RomanExpressionDemoV1.TerminalExpressions
{

    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class RomanTenExpression : RomanExpression
    {
        public override void Interpret(RomanContext value)
        {
            InterpretValue(value, 90, "XC");

            InterpretValue(value, 50, "L");

            InterpretValue(value, 40, "XL");

            InterpretValue(value, 10, "X");
        }

    }

}