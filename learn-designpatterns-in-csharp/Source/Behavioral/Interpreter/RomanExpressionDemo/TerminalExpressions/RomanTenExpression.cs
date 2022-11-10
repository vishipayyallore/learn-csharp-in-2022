using RomanExpressionDemo.AbstractExpressions;
using RomanExpressionDemo.Contexts;

namespace RomanExpressionDemo.TerminalExpressions
{

    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class RomanTenExpression : RomanExpression
    {
        public override void Interpret(RomanContext value)
        {
            while ((value.Input - 90) >= 0)
            {
                value.Output += "XC";
                value.Input -= 90;
            }

            while ((value.Input - 50) >= 0)
            {
                value.Output += "L";
                value.Input -= 50;
            }

            while ((value.Input - 40) >= 0)
            {
                value.Output += "XL";
                value.Input -= 40;
            }

            while ((value.Input - 10) >= 0)
            {
                value.Output += "X";
                value.Input -= 10;
            }
        }
    }

}

// 90 = XC
// 80 = LIII
// 70 = LII
// 60 = LX
// 50 = L
// 40 = XL
// 30 = XXX
// 20 = XX
// 10 = X

// simplified - each combination is reachable with substraction and these 4:
// 90 = XC 
// 50 = L
// 40 = XL
// 10 = X