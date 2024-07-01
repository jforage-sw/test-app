using Xunit;

namespace MyTest.App.Tests;

public class HelperTests
{
    [Fact]
    public void GetHelloWorld_ReturnsHelloWorld()
    {
        // Arrange
        var expected = "Hello, World!";

        // Act
        var actual = Helper.GetHelloWorld();

        // Assert
        Assert.Equal(expected, actual);
    }

    /*[Fact]
    public void GetGoodbye_ReturnsGoodbye()
    {
        // Arrange
        var expected = "Goodbye!";

        // Act
        var actual = Helper.GetGoodbye();

        // Assert
        Assert.Equal(expected, actual);
    }*/
}
