using Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Test_20_ValidParentheses
    {
        [TestMethod]
        public void TestEx01()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("()");
            Assert.IsTrue(rs);
        }

        [TestMethod]
        public void TestEx02()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("()[]{}");
            Assert.IsTrue(rs);
        }

        [TestMethod]
        public void TestEx03()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("(]");
            Assert.IsFalse(rs);

        }

        [TestMethod]
        public void TestEx04()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("([])");
            Assert.IsTrue(rs);
        }

        [TestMethod]
        public void TestEx05()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("([)]");
            Assert.IsFalse(rs);
        }

        [TestMethod]
        public void TestEx06()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("]");
            Assert.IsFalse(rs);
        }

        [TestMethod]
        public void TestEx07()
        {
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            var rs = _20_ValidParentheses.IsValid("[([]])");
            Assert.IsFalse(rs);
        }

    }
}
