using Demo01;
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
        public void MissingNumber01()
        {
            var rs = Blind70.MissingNumber([3, 0, 1]);
            Assert.AreEqual(2, rs);
        }

        [TestMethod]
        public void MissingNumber02()
        {
            var rs = Blind70.MissingNumber([0, 1]);
            Assert.AreEqual(2, rs);
        }

        [TestMethod]
        public void MissingNumber03()
        {
            var rs = Blind70.MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]);
            Assert.AreEqual(8, rs);
        }
    }
}
