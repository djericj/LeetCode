using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// Soluton to LeetCodd 12. Integer to Roman
    /// https://leetcode.com/problems/integer-to-roman/
    /// </summary>
    public class IntegerToRomanNumeral
    {
        public string IntToRoman(int num)
        {
            var result = "";

            var romanNumerals = new List<(string symbol, int value)>
            {
                ("I", 1),
                ("IV", 4),
                ("V", 5),
                ("IX", 9),
                ("X", 10),
                ("XL", 40),
                ("L", 50),
                ("XC", 90),
                ("C", 100),
                ("CD", 400),
                ("D", 500),
                ("CM", 900),
                ("M", 1000)
            };

            foreach (var numeral in romanNumerals.OrderByDescending(x => x.value))
            {
                result += string.Concat(Enumerable.Repeat(numeral.symbol, (num / numeral.value)));
                num = num % numeral.value;
            }

            return result;
        }
    }
}