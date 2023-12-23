﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class AddTwoNums
    {
      public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }
 
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
            {
                if (l1 == null && l2 == null && carry == 0) return null;

                int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                carry = total / 10;
                return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
            }
        }
    }
}
