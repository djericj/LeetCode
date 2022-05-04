using System;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 11. Container With Most Water
    /// https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var result = 0;
            var start = 0;
            var end = height.Length - 1;
            while (end > start)
            {
                var minHeight = Math.Min(height[start], height[end]);
                var area = minHeight * (end - start);
                if (area > result)
                    result = area;
                if (height[start] > height[end])
                    end--;
                else
                    start++;
            }
            return result;
        }

        public int MaxAreaBruteForce(int[] height)
        {
            var result = 0;
            for (var i = 0; i < height.Length; i++)
            {
                for (var j = 0; j < height.Length; j++)
                {
                    if (j > i)
                    {
                        var area = Math.Min(height[i], height[j]);
                        var total = area * (j - i);
                        if (total > result)
                            result = total;
                    }
                }
            }
            return result;
        }
    }
}