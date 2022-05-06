using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 15. Three Sum
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    int sum = 0;

                    while (left < right)
                    {
                        sum = nums[i] + nums[left] + nums[right];
                        if (sum < 0)
                        {
                            ++left;
                        }
                        else if (sum > 0)
                        {
                            --right;
                        }
                        else
                        {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });
                            ++left;
                            --right;

                            while (left < right && nums[left] == nums[left - 1])
                                ++left;
                        }
                    }
                }
            }
            return result;
        }
    }
}