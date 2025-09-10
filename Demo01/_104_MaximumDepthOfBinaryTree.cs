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

        //Tạo cây nhị phân theo level-order
        //[3,9,20,null,null,15,7]
        public static TreeNode BuildTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null) return null;

            TreeNode root = new TreeNode(arr[0].Value);
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                TreeNode currentNode = queue.Dequeue();

                // Left child
                if (i < arr.Length && arr[i] != null)
                {
                    currentNode.left = new TreeNode(arr[i].Value);
                    queue.Enqueue(currentNode);
                }
                i++;

                // Right child
                if (i < arr.Length && arr[i] != null)
                {
                    currentNode.right = new TreeNode(arr[i].Value);
                    queue.Enqueue(currentNode);
                }
                i++;
            }
            return root;
        }
        
        //Tạo cây nhị phân theo level-order bằng recursive
        public static TreeNode BuildTree2(int?[] arr)
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
