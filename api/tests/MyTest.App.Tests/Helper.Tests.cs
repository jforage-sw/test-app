using Xunit;

namespace MyTest.App.Tests;

public class HelperTests
{
    [Fact]
    public void GetHelloWorld_ReturnsExpected()
    {
        // Arrange
        const string expected = "Hello, World!!!!";

        // Act
        var actual = Helper.GetHelloWorld();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetGoodbye_ReturnsExpected()
    {
        // Arrange
        const string expected = "Goodbye!";

        // Act
        var actual = Helper.GetGoodbye();

        // Assert
        Assert.Equal(expected, actual);
    }
}
