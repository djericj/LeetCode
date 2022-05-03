using System;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 5. Longest Palindromic Substring
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var len1 = Expand(s, i, i);
                var len2 = Expand(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }

            return s.Substring(start, (s.Length - end));
        }

        public int Expand(string s, int left, int right)
        {
            if (s == null || left > right) return 0;

            while (left >= 0 && right < s.Length && s.ElementAt(left) == s.ElementAt(right))
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}