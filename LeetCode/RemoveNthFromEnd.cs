using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 19. Remove Nth Node From End of List
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// </summary>
    public class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var start = new ListNode(0, head);
            var left = start;
            var right = head;

            while (n > 0 && right != null)
            {
                right = right.next;
                n--;
            }

            while (right != null)
            {
                left = left.next;
                right = right.next;
            }

            left.next = left.next.next;
            return start.next;
        }
    }
}
