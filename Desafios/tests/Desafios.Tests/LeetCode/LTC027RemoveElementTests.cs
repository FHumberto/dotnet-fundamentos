using Desafios.LeetCode;

namespace Desafios.Tests.LeetCode;

public sealed class LTC027RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 0, 1, 3, 4 })]
    public void RemoveElement_ShouldReturnExpectedResult(int[] nums, int val, int[] expected)
    {
        // Arrange
        LTC027RemoveElement solution = new();

        // Act
        int result = solution.RemoveElement(nums, val);

        // Assert
        Assert.Equal(expected.Length, result);
        Assert.Equal(expected, nums.Take(result).OrderBy(x => x));
    }
}
