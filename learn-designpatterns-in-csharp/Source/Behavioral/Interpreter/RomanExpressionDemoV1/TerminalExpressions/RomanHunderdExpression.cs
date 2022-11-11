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

// 900 = CMr
// 800 = DCCC
// 700 = DCC
// 600 = DC
// 500 = D
// 400 = CD
// 300 = CCC
// 200 = CC
// 100 = C

// simplified - each combination is reachable with substraction and these 4:
// 900 = CM
// 500 = D
// 400 = CD
// 100 = C
