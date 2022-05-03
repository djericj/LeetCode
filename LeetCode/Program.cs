using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var t = new Program();
            t.Run();
        }

        public void Run()
        {
            Console.WriteLine(MyAtoi("21474836460"));
        }

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