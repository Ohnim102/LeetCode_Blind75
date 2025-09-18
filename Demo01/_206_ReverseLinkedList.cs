using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01._206_ReverseLinkedList
{
    public class _206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head; 
            ListNode prev = null;

            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }


        public ListNode CreateListNode(int[] listItem)
        {
            var head = new ListNode(listItem[0]);
            var current = head;

            for (int i = 1; i < listItem.Length; i++)
            {
                current.next = new ListNode(listItem[i]);
                current = current.next;
            }

            return head;
        }
        public bool AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val) return false;
                l1 = l1.next;
                l2 = l2.next;
            }

            // Nếu cả hai cùng null thì giống hệt
            return l1 == null && l2 == null;
        }
    }

}
