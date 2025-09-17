using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01._100_SameTree
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
}
