namespace Desafios.LeetCode;

public sealed class LTC013RomanToInteger
{
    public int RomanToInt(string s)
    {
        char[] characters = s.ToCharArray();
        int result = 0;

        Dictionary<char, int> romanValues = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        for (int i = 0; i < characters.Length; i++)
        {
            if (i + 1 < characters.Length && romanValues[characters[i]] < romanValues[characters[i + 1]])
            {
                result -= romanValues[characters[i]];
            }
            else
            {
                result += romanValues[characters[i]];
            }
        }

        return result;
    }
}

