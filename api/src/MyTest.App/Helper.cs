using System.Diagnostics.CodeAnalysis;

namespace MyTest.App;

[ExcludeFromCodeCoverage]
public static class Helper
{
    public static string GetHelloWorld() => "Hello, World!";

    public static string GetGoodbye() => "Goodbye!";
}
