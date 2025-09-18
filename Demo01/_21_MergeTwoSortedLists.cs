using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _21_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode(-1); // node giả
            var current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Gắn nốt phần còn lại
            if (list1 != null) current.next = list1;
            if (list2 != null) current.next = list2;

            return dummy.next; // bỏ node giả đi
        }

        public ListNode CreateListNode(List<int> listItem)
        {
            if (listItem == null || listItem?.Count() == 0) return null;

            // tạo node head
            var head = new ListNode(listItem[0]);
            var current = head;

            // duyệt từ phần tử thứ 2 trở đi
            for (int i = 1; i < listItem.Count; i++)
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
