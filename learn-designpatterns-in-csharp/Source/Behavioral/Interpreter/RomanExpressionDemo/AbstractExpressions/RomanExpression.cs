using RomanExpressionDemo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanExpressionDemo.AbstractExpressions
{

    /// <summary>
    /// AbstractExpression
    /// </summary>
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext value);
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

}
