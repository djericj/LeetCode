namespace LeetCode
{
    /// <summary>
    /// Solution for Leet COde 8. String to Integer (atoi)
    /// https://leetcode.com/problems/string-to-integer-atoi/
    /// </summary>
    public class Atoi
    {
        public int MyAtoi(string s)
        {
            var neg = false;
            var pos = false;
            var startIndex = 0;
            var integer = "";
            int result = 0;
            if (s.Length == 0) return 0;
            s = s.TrimStart();
            if (s.Length > 1)
            {
                neg = s.StartsWith("-");
                pos = s.StartsWith("+");
            }
            if (neg || pos) startIndex++;
            else if (!neg && !pos) pos = true;
            var regex = new Regex("^[0-9]+$");
            for (int i = startIndex; i < s.Length; i++)
            {
                if (regex.IsMatch(s[i].ToString()))
                {
                    integer += s[i];
                }
                else
                {
                    break;
                }
            }
            if (int.TryParse(integer.ToString(), out result))
            {
                if (result >= int.MinValue && result <= int.MaxValue)
                {
                    if (neg) result = result * -1;
                    return result;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(integer))
                {
                    if (neg) result = int.MinValue;
                    if (pos) result = int.MaxValue;
                }
            }
            return result;
        }
    }
}