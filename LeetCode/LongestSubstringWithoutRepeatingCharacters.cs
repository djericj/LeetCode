using System;
using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 3. Longest Substring Without Repeating Characters
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var charPosition = new Dictionary<char, int>();
            var res = 0;
            var left = -1;

            for (var i = 0; i < s.Length; i++)
            {
                if (charPosition.ContainsKey(s[i]))
                {
                    left = Math.Max(left, charPosition[s[i]]);
                }
                charPosition[s[i]] = i;
                res = Math.Max(res, i - left);
            }

            return res;
        }
    }
}