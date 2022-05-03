using System;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 7. Reverse Integer
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var result = 0;
            while (x != 0)
            {
                var digit = Convert.ToInt32(x % 10);
                x = Convert.ToInt32(x / 10);
                if (result > Convert.ToInt32(int.MaxValue / 10) || (result == Convert.ToInt32(int.MaxValue / 10) && digit >= int.MaxValue % 10))
                    return 0;
                if (result < Convert.ToInt32(int.MinValue / 10) || (result == Convert.ToInt32(int.MinValue / 10) && digit <= int.MinValue % 10))
                    return 0;
                result = (result * 10) + digit;
            }
            return result;
        }
    }
}