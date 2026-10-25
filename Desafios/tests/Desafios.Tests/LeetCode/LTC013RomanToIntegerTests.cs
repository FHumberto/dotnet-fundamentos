using Desafios.LeetCode;

namespace Desafios.Tests.LeetCode;

public sealed class LTC013RomanToIntegerTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ShouldReturnExpectedResult(string x, int expected)
    {
        // Arrange
        LTC013RomanToInteger solution = new();

        // Act
        int result = solution.RomanToInt(x);

        // Assert
        Assert.Equal(expected, result);
    }
}
