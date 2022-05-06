using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumSolution
    {
        /// <summary>
        /// Solution for LeetCode 1. Two Sum
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ans = new int[1];
            for (var x = 0; x < nums.Count(); x++)
            {
                for (var y = 0; y < nums.Count(); y++)
                {
                    if (x != y)
                    {
                        if (nums[x] + nums[y] == target)
                        {
                            ans = new int[] { x, y };
                            return ans;
                        }
                    }
                }
            }
            return ans;
        }

        /// <summary>
        /// Solution for LeetCode 167. Two Sum II
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        public int[] TwoSum2(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;
            while (true)
            {
                var sum = numbers[l] + numbers[r];
                if (sum > target)
                    r--;
                if (sum < target)
                    l++;
                if (sum == target)
                    return new int[] { l + 1, r + 1 };
            }
        }
    }
}