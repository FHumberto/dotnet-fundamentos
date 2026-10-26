using Desafios.LeetCode;

namespace Desafios.Tests.LeetCode;

public sealed class LTC014LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_ShouldReturnExpectedResult(string[] words, string expected)
    {
        // Arrange
        LTC014LongestCommonPrefix solution = new();

        // Act
        string result = solution.LongestCommonPrefix(words);

        // Assert
        Assert.Equal(result, expected);
    }
}
