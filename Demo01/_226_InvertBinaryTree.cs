using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01._226_InvertBinaryTree
{
    public class _226_InvertBinaryTree
    {
        /// <summary>
        /// Given the root of a binary tree, invert the tree, and return its root.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            var leftTemp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(leftTemp);

            return root;
        }

    }

}
