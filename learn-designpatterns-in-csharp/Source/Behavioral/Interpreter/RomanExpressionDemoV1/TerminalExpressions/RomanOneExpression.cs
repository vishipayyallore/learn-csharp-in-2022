using RomanExpressionDemoV1.AbstractExpressions;
using RomanExpressionDemoV1.Contexts;

namespace RomanExpressionDemoV1.TerminalExpressions
{

    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class RomanOneExpression : RomanExpression
    {
        public override void Interpret(RomanContext value)
        {
            InterpretValue(value, 9, "IX");

            InterpretValue(value, 5, "V");

            InterpretValue(value, 4, "IV");

            InterpretValue(value, 1, "I");
        }
    }

}