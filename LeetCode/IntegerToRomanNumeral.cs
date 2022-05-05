using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class IntegerToRomanNumeral
    {
        /// <summary>
        /// Soluton to LeetCode 12. Integer to Roman
        /// https://leetcode.com/problems/integer-to-roman/
        /// </summary>
        public string IntToRoman(int num)
        {
            var result = "";

            foreach (var numeral in GetRomanNumerals().OrderByDescending(x => x.value))
            {
                result += string.Concat(Enumerable.Repeat(numeral.symbol, (num / numeral.value)));
                num = num % numeral.value;
            }

            return result;
        }

        /// <summary>
        /// Soluton to LeetCode 13. Roman to Integer
        /// https://leetcode.com/problems/roman-to-integer/
        /// </summary>
        public int RomanToInt(string s)
        {
            int num = 0;
            string roman = s;

            var romanNumerals = GetRomanNumerals();

            while (!string.IsNullOrEmpty(roman))
            {
                for (int i = 2; i > 0; i--)
                {
                    if (roman.Length == 1) i = 1;
                    var key = roman.Substring(0, i);
                    var v = romanNumerals.Where(x => x.symbol == key).FirstOrDefault();
                    if (v != (null, 0))
                    {
                        num += v.value;
                        roman = roman.Substring(i);
                        break;
                    }
                }
            }
            return num;
        }

        private List<(string symbol, int value)> GetRomanNumerals()
        {
            return new List<(string symbol, int value)>
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
        }
    }
}