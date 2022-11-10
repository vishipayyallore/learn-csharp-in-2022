using RomanExpressionDemoV1.AbstractExpressions;
using RomanExpressionDemoV1.Contexts;
using RomanExpressionDemoV1.TerminalExpressions;
using static System.Console;

Title = "Design Pattern - Interpreter";

ForegroundColor = ConsoleColor.Cyan;

var expressions = new List<RomanExpression>
{
    new RomanHunderdExpression(),
    new RomanTenExpression(),
    new RomanOneExpression(),
};

var context = new RomanContext(5);
foreach (var expression in expressions)
{
    expression.Interpret(context);
}
WriteLine($"Translating Arabic numerals to Roman numerals: 5 = {context.Output}");

context = new RomanContext(81);
foreach (var expression in expressions)
{
    expression.Interpret(context);
}
WriteLine($"Translating Arabic numerals to Roman numerals: 81 = {context.Output}");

context = new RomanContext(733);
foreach (var expression in expressions)
{
    expression.Interpret(context);
}
WriteLine($"Translating Arabic numerals to Roman numerals: 733 = {context.Output}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

