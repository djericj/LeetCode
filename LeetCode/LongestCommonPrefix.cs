using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 14. Longest Common Prefix
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string longest = "";
            for (int i = 0; i < strs.Min(x => x.Length); i++)
            {
                var first = strs[0].Substring(0, i + 1);
                if (strs.All(x => x.Substring(0, i + 1) == first))
                    longest = first;
                else
                    break;
            }
            return longest;
        }
    }
}