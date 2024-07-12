namespace MyTest.App;

[Obsolete("Class should be ignored by the SC code analyzer")]
public static class Helper
{
    public static string GetHelloWorld() => "Hello, World!";

    public static string GetGoodbye() => "Goodbye!";
}
