using Demo01;
using Demo01._100_SameTree;
using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_100_SameTree
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _100_SameTree();

            TreeNode p = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            TreeNode q = new TreeNode(2, new TreeNode(1), new TreeNode(3));

            var rs = ex.IsSameTree(p, q);
            Assert.IsTrue(rs);
        }
    }
}
