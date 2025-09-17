using Demo01._100_SameTree;
using Demo01._226_InvertBinaryTree;
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
            var result = ex.InvertTree(ex.BuildTree([4, 2, 7, 1, 3, 6, 9]));
            var expect = ex.BuildTree([4, 7, 2, 9, 6, 3, 1]);
            Assert.IsTrue(new _100_SameTree().IsSameTree(expect, result));
        }

        [TestMethod]
        public void TestEx02()
        {

        }
    }
}
