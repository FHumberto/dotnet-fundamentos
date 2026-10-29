namespace Desafios.LeetCode;

public sealed class LTC027RemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {
        int e = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[e] = nums[i];
                e++;
            }
        }

        return e;
    }
}
