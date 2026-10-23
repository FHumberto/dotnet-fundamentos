namespace Desafios.LeetCode;

public sealed class LTC009PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        string palindrome = x.ToString();

        return new string(palindrome.Reverse().ToArray()) == palindrome;
    }
}
