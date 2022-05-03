namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 9. Palindrome Number
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var s = x.ToString();
            var start = 0;
            var end = s.Length - 1;
            while (true)
            {
                if (start >= end)
                    break;
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}