namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 6. Zigzag Conversion
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            var result = "";
            for (int i = 0; i < numRows; i++)
            {
                var increment = (numRows - 1) * 2;
                for (int j = i; j < s.Length; j += increment)
                {
                    result += s[j];
                    if (i > 0 && i < numRows - 1 && j + increment - (2 * i) < s.Length)
                    {
                        result += s[j + increment - (2 * i)];
                    }
                }
            }

            return result;
        }
    }
}