namespace RomanExpressionDemoV1.Contexts
{

    /// <summary>
    /// Context
    /// </summary>
    public class RomanContext
    {
        public int Input { get; set; }

        public string Output { get; set; } = string.Empty;

        public RomanContext(int input)
        {
            Input = input;
        }

    }

}
