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
            while (value.Input - 900 >= 0)
            {
                value.Output += "CM";
                value.Input -= 900;
            }

            while (value.Input - 500 >= 0)
            {
                value.Output += "D";
                value.Input -= 500;
            }

            while (value.Input - 400 >= 0)
            {
                value.Output += "CD";
                value.Input -= 400;
            }

            while (value.Input - 100 >= 0)
            {
                value.Output += "C";
                value.Input -= 100;
            }
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
