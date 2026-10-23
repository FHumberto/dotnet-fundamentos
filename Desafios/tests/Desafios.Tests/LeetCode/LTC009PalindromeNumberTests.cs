using Desafios.LeetCode;

namespace Desafios.Tests.LeetCode;

public sealed class LTC009PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome_ShouldReturnExpectedResult(int x, bool expected)
    {
        // Arrange
        LTC009PalindromeNumber solution = new();

        // Act
        bool result = solution.IsPalindrome(x);

        // Assert
        Assert.Equal(expected, result);
    }
}
