// See https://aka.ms/new-console-template for more information

using static System.Console;


if (args.Length > 0)
{
    await DisplayReceivedArguments(args);
}

WriteLine("\n\nPress any key ...");

static async Task DisplayReceivedArguments(string[] args)
{
    for (int n = 0; n < args.Length; n++)
    {
        Console.WriteLine("arg[{0}] = {1}", n, args[n]);
    }

    await Task.CompletedTask;
}
