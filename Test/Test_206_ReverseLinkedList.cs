using Demo01._206_ReverseLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_206_ReverseLinkedList
    {
        [TestMethod]
        public void TestEx01()
        {
            var Ex = new _206_ReverseLinkedList();

            var expect = Ex.ReverseList(Ex.CreateListNode([1, 2, 3, 4, 5]));
            var rs = Ex.ReverseList(Ex.CreateListNode([1, 2, 3, 4, 5]));
            Assert.IsTrue(Ex.AreEqual(expect, rs));

        }
    }
}
