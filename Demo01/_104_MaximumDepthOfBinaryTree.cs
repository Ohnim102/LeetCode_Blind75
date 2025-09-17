using Demo01.Model;
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

    }

}
