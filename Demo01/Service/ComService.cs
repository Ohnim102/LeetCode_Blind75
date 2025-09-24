using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Service
{
    public class ComService
    {

        ////Tạo cây nhị phân theo level-order
        ////[3,9,20,null,null,15,7]
        //public static TreeNode BuildTree(int?[] arr)
        //{
        //    if (arr == null || arr.Length == 0 || arr[0] == null) return null;

        //    TreeNode root = new TreeNode(arr[0].Value);

        //    Queue<TreeNode> queue = new Queue<TreeNode>();
        //    queue.Enqueue(root);

        //    int i = 1;
        //    while (i < arr.Length)
        //    {
        //        TreeNode currentNode = queue.Dequeue();

        //        // Left child
        //        if (i < arr.Length && arr[i] != null)
        //        {
        //            currentNode.left = new TreeNode(arr[i].Value);
        //            queue.Enqueue(currentNode);
        //        }
        //        i++;

        //        // Right child
        //        if (i < arr.Length && arr[i] != null)
        //        {
        //            currentNode.right = new TreeNode(arr[i].Value);
        //            queue.Enqueue(currentNode);
        //        }
        //        i++;
        //    }
        //    return root;
        //}

        //Tạo cây nhị phân theo level-order bằng recursive


        /// <summary>
        /// Tạo cây nhị phân theo level-order bằng recursive. 
        /// Example: [3,9,20,null,null,15,7]
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static TreeNode BuildTree(int?[] arr)
        {
            return BuildRecursive(arr, 0);
        }

        private static TreeNode BuildRecursive(int?[] arr, int index)
        {
            if (index >= arr.Length || arr[index] == null)
                return null;

            // Tạo node hiện tại
            TreeNode node = new TreeNode(arr[index].Value);

            // Đệ quy con trái và phải
            node.left = BuildRecursive(arr, 2 * index + 1);
            node.right = BuildRecursive(arr, 2 * index + 2);

            return node;
        }


        // List node
        public static ListNode CreateListNodeByArray(int[] listItem)
        {
            if (listItem.Length == 0) return null;

            var head = new ListNode(listItem[0]);
            var current = head;

            for (int i = 1; i < listItem.Length; i++)
            {
                current.next = new ListNode(listItem[i]);
                current = current.next;
            }

            return head;
        }
        public static bool AreListNodesEqual(ListNode l1, ListNode l2)
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
