using Demo01;
using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_21_MergeTwoSortedLists
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode listNode2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode listNodeResult = ex.CreateListNode(new List<int>() { 1, 1, 2, 3, 4, 4 });

            var rs = ex.MergeTwoLists(listNode1, listNode2);
            Assert.IsTrue(ex.AreEqual(rs, listNodeResult));
        }
        
        [TestMethod]
        public void TestEx02()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = null;
            ListNode listNode2 = null;
            ListNode listNodeResult = ex.CreateListNode(new List<int>() {  });

            var rs = ex.MergeTwoLists(listNode1, listNode2);
            Assert.IsTrue(ex.AreEqual(rs, listNodeResult));
        }

        [TestMethod]
        public void TestEx03()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = ex.CreateListNode(new List<int>() { 1 }); ;
            ListNode listNode2 = null;
            ListNode listNodeResult = ex.CreateListNode(new List<int>() { 1 });

            var rs = ex.MergeTwoLists(listNode1, listNode2);
            Assert.IsTrue(ex.AreEqual(rs, listNodeResult));
        }

        [TestMethod]
        public void TestEx04()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = ex.CreateListNode(new List<int>() { -9, 3 });
            ListNode listNode2 = ex.CreateListNode(new List<int>() { 5, 7 });
            ListNode listNodeResult = ex.CreateListNode(new List<int>() { -9, 3, 5, 7 });

            var rs = ex.MergeTwoLists(listNode1, listNode2);
            Assert.IsTrue(ex.AreEqual(rs, listNodeResult));
        }
        
        [TestMethod]
        public void TestEx05()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = ex.CreateListNode(new List<int>() { -10, -9, -6, -4, 1, 9, 9 });
            ListNode listNode2 = ex.CreateListNode(new List<int>() { -5, -3, 0, 7, 8, 8 });
            ListNode listNodeResult = ex.CreateListNode(new List<int>() { -10, -9, -6, -5, -4, -3, 0, 1, 7, 8, 8, 9, 9 });

            var rs = ex.MergeTwoLists(listNode1, listNode2);
            Assert.IsTrue(ex.AreEqual(rs, listNodeResult));
        }

        [TestMethod]
        public void TestEx()
        {
            var ex = new _21_MergeTwoSortedLists();

            ListNode listNode1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var listNode2 = ex.CreateListNode(new List<int>() { 1, 2, 4 });

            Assert.IsTrue(true);
        }


    }
}
