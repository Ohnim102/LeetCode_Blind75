using Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass] 
    public class Test_217_ContainsDuplicate
    {
        [TestMethod]
        public void TestEx01()
        {
            var ex = new _217_ContainsDuplicate();
            Assert.IsTrue(ex.ContainsDuplicate([1, 2, 3, 1]));
        }

        [TestMethod]
        public void TestEx02()
        {
            var ex = new _217_ContainsDuplicate();
            Assert.IsFalse(ex.ContainsDuplicate([1, 2, 3, 4]));
        }

        [TestMethod]
        public void TestEx03()
        {
            var ex = new _217_ContainsDuplicate();
            Assert.IsTrue(ex.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
        }
    }
}
