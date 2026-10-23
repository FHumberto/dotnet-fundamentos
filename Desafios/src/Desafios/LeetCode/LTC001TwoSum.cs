namespace Desafios.LeetCode;

public sealed class LTC001TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] sum = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    sum[0] = i;
                    sum[1] = j;

                    return sum;
                }
            }
        }

        return sum;
    }
}
