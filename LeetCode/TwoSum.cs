using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 1. Two Sum
    ///
    /// </summary>
    public class TwoSumSolution
    {
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
    }
}