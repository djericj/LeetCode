using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Solution for LeetCode 2. Add Two Numbers
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode runNodes = new ListNode();
            ListNode returnSumNodes = runNodes;

            var transfer = 0;

            while (true)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + transfer;

                runNodes.val = sum % 10;

                transfer = sum / 10;

                l1 = l1?.next;
                l2 = l2?.next;

                if (l1 == null && l2 == null && transfer == 0)
                {
                    break;
                }

                runNodes.next = new ListNode();
                runNodes = runNodes.next;
            }

            return returnSumNodes;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}