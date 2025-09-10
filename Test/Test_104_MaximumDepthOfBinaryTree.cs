using Demo01._104_MaximumDepthOfBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_104_MaximumDepthOfBinaryTree
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _104_MaximumDepthOfBinaryTree();

            //[3,9,20,null,null,15,7]
            TreeNode input = new TreeNode(
                3,
                new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7))
            );

            var rs = ex.MaxDepth(input);
            Assert.AreEqual(3, rs);

            //TreeNode p = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            //TreeNode q = new TreeNode(2, new TreeNode(1), new TreeNode(3));

            //var rs = ex.IsSameTree(p, q);
            //Assert.IsTrue(rs);
        }

    }
}
