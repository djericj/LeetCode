using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 20. Valid Parentheses
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var closeToOpen = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' },
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (closeToOpen.ContainsKey(s[i]))
                    if (stack.Count > 0 && stack.Peek() == closeToOpen[s[i]])
                        stack.Pop();
                    else
                        return false;
                else
                    stack.Push(s[i]);
            }
            return stack.Count == 0;
        }
    }
}
