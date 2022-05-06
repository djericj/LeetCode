using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Sums
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

        /// <summary>
        /// Solution for LeetCode 15. 3Sum
        /// https://leetcode.com/problems/3sum/
        /// </summary>
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

        /// <summary>
        /// Solution for LeetCode 18.  4Sum
        /// https://leetcode.com/problems/4sum/
        /// </summary>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 3; i++)
            {
                while (i != 0 && i < nums.Length && nums[i] == nums[i - 1]) { i++; }
                for (int j = nums.Length - 1; j > i; j--)
                {
                    while (j != nums.Length - 1 && j > 0 && nums[j] == nums[j + 1]) { j--; }
                    var newTarget = target - (nums[i] + nums[j]);
                    int lo = i + 1, hi = j - 1;
                    while (lo < hi)
                    {
                        int currentSum = nums[lo] + nums[hi];
                        if (currentSum < newTarget || lo != i + 1 && nums[lo] == nums[lo - 1])
                        {
                            lo++;
                        }
                        else if (currentSum > newTarget || hi != j - 1 && nums[hi] == nums[hi + 1])
                        {
                            hi--;
                        }
                        else
                        {
                            result.Add(new int[] { nums[i], nums[lo++], nums[hi--], nums[j] });
                        }
                    }
                }
            }
            return result;
        }
    }
}