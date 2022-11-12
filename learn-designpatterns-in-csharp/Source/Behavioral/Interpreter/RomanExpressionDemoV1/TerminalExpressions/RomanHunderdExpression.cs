using RomanExpressionDemoV1.AbstractExpressions;
using RomanExpressionDemoV1.Contexts;

namespace RomanExpressionDemoV1.TerminalExpressions
{

    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class RomanHunderdExpression : RomanExpression
    {
        public override void Interpret(RomanContext value)
        {
            InterpretValue(value, 900, "CM");

            InterpretValue(value, 500, "D");

            InterpretValue(value, 400, "CD");

            InterpretValue(value, 100, "C");
        }

    }

}