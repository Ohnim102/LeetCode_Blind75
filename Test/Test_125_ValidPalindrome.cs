using Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_125_ValidPalindrome
    {
        [TestMethod]
        public void TestEx01()
        {
            _125_ValidPalindrome ex = new _125_ValidPalindrome();
            Assert.IsTrue(ex.IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
