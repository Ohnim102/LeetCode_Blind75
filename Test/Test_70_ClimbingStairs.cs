using Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_70_ClimbingStairs
    {
        [TestMethod]
        public void TestEx01()
        {
            var rs = new _70_ClimbingStairs().ClimbStairs03(5);
            Assert.AreEqual(8, rs);
        }
        [TestMethod]
        public void TestEx02()
        {
            var rs = new _70_ClimbingStairs().ClimbStairs03(4);
            Assert.AreEqual(5, rs);
        }
        [TestMethod]
        public void TestEx03()
        {
            var rs = new _70_ClimbingStairs().ClimbStairs03(3);
            Assert.AreEqual(3, rs);
        }
        [TestMethod]
        public void TestEx04()
        {
            var rs = new _70_ClimbingStairs().ClimbStairs03(44);
            Console.WriteLine($"Total: {rs}");
            Assert.IsTrue(true);
        }
    }
}
