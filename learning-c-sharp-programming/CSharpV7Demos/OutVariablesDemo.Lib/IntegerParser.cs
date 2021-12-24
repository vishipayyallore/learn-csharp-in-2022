using static System.Console;

namespace OutVariablesDemo.Lib
{

    public class IntegerParser : IIntegerParser
    {

        public void IntTryParseV1(string input)
        {
            int output;
            if (int.TryParse(input, out output))
            {
                WriteLine($"Input: {input}, Output: {output}");
            }
            else
            {
                WriteLine($"Could not parse {input}, Output: {output}");
            }
        }

        public void IntTryParseV2(string input)
        {
            if (int.TryParse(input, out var output))
            {
                WriteLine($"Input: {input}, Output: {output}");
            }
            else
            {
                WriteLine($"Could not parse {input}, Output: {output}");
            }
        }

    }

}