using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01._104_MaximumDepthOfBinaryTree
{
    public class _104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int maxLeft = MaxDepth(root.left);
            int maxRight = MaxDepth(root.right);
            return Math.Max(maxLeft, maxRight) + 1;
        }


        //[3,9,20,null,null,15,7]
        public TreeNode CreateListNode(List<int> listItem)
        {
            if (listItem == null || listItem?.Count() == 0) return null;

            // tạo node head
            var head = new TreeNode();
            var current = head;

            // duyệt từ phần tử thứ 2 trở đi
            for (int i = 1; i < listItem.Count; i = i + 2)
            {
                current.val = listItem[i];

                current.left = new TreeNode(listItem[i + 1]);
                current.right = new TreeNode(listItem[i + 2]);
            }

            return head;
        }
    }


    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
