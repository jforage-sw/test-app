using System.Diagnostics.CodeAnalysis;

namespace MyTest.App;

[ExcludeFromCodeCoverage]
public static class Helper
{
    public static string GetHelloWorld() => "Hello, World!";

    public static string GetGoodbye() => "Goodbye!";

    public static void DoStuff()
    {
        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine(i);
        }

        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine(i);
        }

        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine(i);
        }

        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine(i);
        }

        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine(i);
        }
    }
}
