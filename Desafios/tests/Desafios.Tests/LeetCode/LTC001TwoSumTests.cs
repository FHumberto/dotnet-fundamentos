using Desafios.LeetCode;

namespace Desafios.Tests.LeetCode;

public sealed class LTC001TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_ShouldReturnCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Arrange
        LTC001TwoSum? solution = new();

        // Act
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}
