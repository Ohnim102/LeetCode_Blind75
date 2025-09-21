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

    }
}
