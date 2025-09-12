using Demo01._141_LinkedListCycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_141_LinkedListCycle
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _141_LinkedListCycle();
            var input = ex.CreateListNodeCycle([3, 2, 0, -4], 1);
            Assert.IsTrue(ex.HasCycle(input));
        }
        [TestMethod]
        public void TestEx02()
        {
            var ex = new _141_LinkedListCycle();
            var input = ex.CreateListNodeCycle([1, 2], 0);
            Assert.IsTrue(ex.HasCycle(input));
        }
        [TestMethod]
        public void TestEx03()
        {
            var ex = new _141_LinkedListCycle();
            var input = ex.CreateListNodeCycle([1], -1);
            Assert.IsFalse(ex.HasCycle(input));
        }
    }
}
