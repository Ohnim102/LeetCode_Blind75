using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01._141_LinkedListCycle
{
    public class _141_LinkedListCycle
    {
        /// <summary>
        /// Return true if there is a cycle in the linked list. Otherwise, return false.
        /// (More info: Floyd’s Cycle Detection)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            //Approach 1: Brute force
            List<ListNode> list = new List<ListNode>();
            var current = head;
            while (current != null)
            {
                list.Add(current);
                current = current.next;
                if (list.Contains(current))
                {
                    return true;
                }
            }
            return false;

            //Approach 2: Floyd’s Cycle Detection
            //One slow, one fast
        }

        /// <summary>
        /// Create list node from an array of int
        /// </summary>
        /// <param name="listItem"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listItem">array of node</param>
        /// <param name="pos">pos is used to denote the index of the node that tail's next pointer is connected to</param>
        /// <returns></returns>
        public ListNode CreateListNodeCycle(int[] listItem, int pos)
        {
            var head = new ListNode(listItem[0]);
            var current = head;

            var last = new ListNode(-1);
            if (0 == pos)
            {
                last = current;
            }

            for (int i = 1; i < listItem.Length; i++)
            {
                current.next = new ListNode(listItem[i]);

                current = current.next;
                if (i == pos)
                {
                    last = current;
                }
            }

            if (pos != -1)
            {
                current.next = last;
            }
            return head;
        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
