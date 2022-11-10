using RomanExpressionDemoV1.Contexts;

namespace RomanExpressionDemoV1.AbstractExpressions
{

    /// <summary>
    /// AbstractExpression
    /// </summary>
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext value);

        protected void InterpretValue(RomanContext value, int numberValue, string romanValue)
        {
            while (value.Input - numberValue >= 0)
            {
                value.Output += romanValue;
                value.Input -= numberValue;
            }
        }

    }

}
