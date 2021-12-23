using static System.Console;

// See https://aka.ms/new-console-template for more information
WriteLine("Hello, World!");


var input1 = "12345";

IntTryParseV1(input1);
IntTryParseV2(input1);

// Changing to Non-Numeric value
input1 = "ABC";
IntTryParseV1(input1);
IntTryParseV2(input1);

void IntTryParseV1(string input)
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

void IntTryParseV2(string input)
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
