using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;

            // Recursively check if the left and right subtrees are identical
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
