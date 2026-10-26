namespace Desafios.LeetCode;

public sealed class LTC014LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        string common = string.Empty;

        for (int j = 0; j < strs[0].Length; j++)
        {
            char temp = strs[0][j];

            for (int i = 0; i < strs.Length; i++)
            {
                if (j >= strs[i].Length || temp != strs[i][j])
                    return common;
            }

            common += temp;
        }

        return common;
    }
}
