using Demo01._100_SameTree;
using Demo01._226_InvertBinaryTree;
using Demo01.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_226_InvertBinaryTree
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _226_InvertBinaryTree();
            var result = ex.InvertTree(ComService.CreateTreeNodeByArray([4, 2, 7, 1, 3, 6, 9]));
            var expect = ComService.CreateTreeNodeByArray([4, 7, 2, 9, 6, 3, 1]);
            Assert.IsTrue(new _100_SameTree().IsSameTree(expect, result));
        }

        [TestMethod]
        public void TestEx02()
        {
            var ex = new _226_InvertBinaryTree();
            var result = ex.InvertTree(ComService.CreateTreeNodeByArray([1, 2]));
            var expect = ComService.CreateTreeNodeByArray([1, null, 2]);
            Assert.IsTrue(new _100_SameTree().IsSameTree(expect, result));
        }
    }
}
