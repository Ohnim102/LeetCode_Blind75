using Demo01;
using Demo01.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TestBlind70
    {
        [TestMethod]
        public void TestIsAnagram01()
        {
            Assert.IsTrue(Blind70.IsAnagram("anagram", "nagaram"));
        }

        [TestMethod]
        public void TestIsAnagram02()
        {
            Assert.IsFalse(Blind70.IsAnagram("ab", "a"));
        }

        [TestMethod]
        public void TestMissingNumber01()
        {
            var rs = Blind70.MissingNumber([3, 0, 1]);
            Assert.AreEqual(2, rs);
        }

        [TestMethod]
        public void TestMissingNumber02()
        {
            var rs = Blind70.MissingNumber([0, 1]);
            Assert.AreEqual(2, rs);
        }

        [TestMethod]
        public void TestMissingNumber03()
        {
            var rs = Blind70.MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]);
            Assert.AreEqual(8, rs);
        }

        [TestMethod]
        public void TestIsSubtree01()
        {
            var root = ComService.BuildTree([3, 4, 5, 1, 2]);
            var subRoot = ComService.BuildTree([4, 1, 2]);
            Assert.IsTrue(Blind70.IsSubtree(root, subRoot));
        }

        [TestMethod]
        public void TestIsSubtree02()
        {
            var root = ComService.BuildTree([3, 4, 5, 1, 2, null, null, null, null, 0]);
            var subRoot = ComService.BuildTree([4, 1, 2]);
            Assert.IsFalse(Blind70.IsSubtree(root, subRoot));
        }

        [TestMethod]
        public void TestIsSubtree03()
        {
            var root = ComService.BuildTree([1, null, 1, null, 1, null, 1, null, 1, null, 1, null, 1, null, 1, null, 1, null, 1, null, 1, 2]);
            var subRoot = ComService.BuildTree([1, null, 1, null, 1, null, 1, null, 1, null, 1, 2]);
            Assert.IsTrue(Blind70.IsSubtree(root, subRoot));
        }

        [TestMethod]
        public void TestLengthOfLongestSubstring01()
        {
            Assert.AreEqual(3, Blind70.LengthOfLongestSubstring("abcabcbb"));
        }

        [TestMethod]
        public void TestLongestPalindrome01()
        {
            Assert.AreEqual("bab", Blind70.LongestPalindrome("babad"));
        }

        [TestMethod]
        public void TestLongestPalindrome02()
        {
            Assert.AreEqual("a", Blind70.LongestPalindrome("a"));
        }

        [TestMethod]
        public void TestLongestPalindrome03()
        {
            Assert.AreEqual("bb", Blind70.LongestPalindrome("bb"));
        }

        [TestMethod]
        public void TestMaxArea01()
        {
            Assert.AreEqual(49, Blind70.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
        }
        
        [TestMethod]
        public void TestRemoveNthFromEnd01()
        {
            var input = ComService.CreateListNodeByArray([1, 2, 3, 4, 5]);

            var expect = ComService.CreateListNodeByArray([1, 2, 3, 5]);
            var actual = Blind70.RemoveNthFromEnd(input, 2);

            var isEqual = ComService.AreListNodesEqual(expect, actual);
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void TestRemoveNthFromEnd02()
        {
            var input = ComService.CreateListNodeByArray([1]);

            var expect = ComService.CreateListNodeByArray([]);
            var actual = Blind70.RemoveNthFromEnd(input, 1);

            var isEqual = ComService.AreListNodesEqual(expect, actual);
            Assert.IsTrue(isEqual);
        }

        //[TestMethod]
        //public void TestThreeSum01()
        //{
        //    Assert.AreEqual([[-1, -1, 2], [-1, 0, 1]], Blind70.ThreeSum([-1, 0, 1, 2, -1, -4]));
        //}
        
        //[TestMethod]
        //public void TestThreeSum02()
        //{
        //    Assert.AreEqual([], Blind70.ThreeSum([0, 1, 1]));
        //}
        
        //[TestMethod]
        //public void TestThreeSum03()
        //{
        //    Assert.AreEqual([[0, 0, 0]], Blind70.ThreeSum([0, 0, 0]));
        //}



    }
}
