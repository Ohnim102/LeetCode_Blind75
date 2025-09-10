using Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_121_BestTimeToBuyAndSellStock
    {
        [TestMethod]
        public void TestEx01()
        {
            _121_BestTimeToBuyAndSellStock ex = new _121_BestTimeToBuyAndSellStock();
            var rs = ex.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(5, rs);
        }

        [TestMethod]
        public void TestEx02()
        {
            _121_BestTimeToBuyAndSellStock ex = new _121_BestTimeToBuyAndSellStock();
            var rs = ex.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, rs);
        }
        [TestMethod]
        public void TestEx03()
        {
            _121_BestTimeToBuyAndSellStock ex = new _121_BestTimeToBuyAndSellStock();
            var rs = ex.MaxProfit(new int[] {
                225, 130, 661, 808, 236, 798, 659, 987, 564, 244, 886, 158, 304, 705, 365, 344, 560, 424, 11, 876, 12, 803, 805, 82, 484,
                117, 491, 962, 709, 2, 377, 566, 380, 844, 670, 278, 455, 59, 829, 719, 980, 647, 12, 751, 938, 234, 399, 472, 635, 634,
                78, 31, 363, 201, 453, 368, 548, 267, 387, 823, 654, 71, 178, 273, 727, 657, 58, 845, 487, 698, 337, 188, 390, 177, 256, 1000 });
            Assert.AreEqual(999, rs);
        }
        [TestMethod]
        public void TestEx04()
        {
            _121_BestTimeToBuyAndSellStock ex = new _121_BestTimeToBuyAndSellStock();
            var rs = ex.MaxProfit(new int[] {7, 20, 5, 1, 4 });
            Assert.AreEqual(13, rs);
        }
    }
}
