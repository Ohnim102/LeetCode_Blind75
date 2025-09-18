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
    }
}
