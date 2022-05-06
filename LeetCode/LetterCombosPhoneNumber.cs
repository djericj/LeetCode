using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 17. Letter Combinations of a Phone Number
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    public class LetterCombosPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            var map = new List<(string digit, string letters)>()
            {
                ("2","abc"),
                ("3","def"),
                ("4","ghi"),
                ("5","jkl"),
                ("6","mno"),
                ("7","pqrs"),
                ("8","tuv"),
                ("9","wxyz"),
            };
            var list = new List<string>();

            void BackTrack(int i, string current)
            {
                if (current.Length == digits.Length)
                {
                    list.Add(current);
                    return;
                }

                foreach (var c in map.Where(x => x.digit == digits[i].ToString()))
                {
                    foreach (var f in c.letters)
                    {
                        BackTrack(i + 1, current + f);
                    }
                }
            }

            if (digits.Length > 0)
                BackTrack(0, "");

            return list;
        }
    }
}