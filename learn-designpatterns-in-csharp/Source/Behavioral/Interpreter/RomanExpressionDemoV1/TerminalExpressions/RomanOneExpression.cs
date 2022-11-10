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
            //while (value.Input - 9 >= 0)
            //{
            //    value.Output += "IX";
            //    value.Input -= 9;
            //}

            //while (value.Input - 5 >= 0)
            //{
            //    value.Output += "V";
            //    value.Input -= 5;
            //}

            //while (value.Input - 4 >= 0)
            //{
            //    value.Output += "IV";
            //    value.Input -= 4;
            //}

            //while (value.Input - 1 >= 0)
            //{
            //    value.Output += "I";
            //    value.Input -= 1;
            //}

            InterpretValue(value, 9, "IX");

            InterpretValue(value, 5, "V");

            InterpretValue(value, 4, "IV");

            InterpretValue(value, 1, "I");

        }

        private static void CalculateValue(RomanContext value, int numberValue, string romanValue)
        {
            while (value.Input - numberValue >= 0)
            {
                value.Output += romanValue;
                value.Input -= numberValue;
            }
        }
    }

}

// 9 = IX
// 8 = VIII
// 7 = VII
// 6 = VI
// 5 = V
// 4 = IV
// 3 = III
// 2 = II
// 1 = I

// simplified - each combination is reachable with substraction and these 4:
// 9 = IX 
// 5 = V
// 4 = IV
// 1 = I