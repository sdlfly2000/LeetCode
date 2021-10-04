using LeetCode_29;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _29.LeetCode_Test
{
    [TestClass]
    public class SolutionTest
    {
        private Solution _solution;

        [TestInitialize]
        public void TestInitialize()
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var dividend = 10;
            var divisor = 3;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var dividend = 7;
            var divisor = -3;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var dividend = 0;
            var divisor = 1;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var dividend = 1;
            var divisor = 1;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var dividend = -2147483648;
            var divisor = -1;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(2147483647, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var dividend = -2147483648;
            var divisor = 2;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-1073741824, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var dividend = -2147483648;
            var divisor = -2;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(1073741824, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var dividend = 1;
            var divisor = 2;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var dividend = 2147483647;
            var divisor = 2;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(1073741823, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var dividend = -2147483648;
            var divisor = -1017100424;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var dividend = -12;
            var divisor = 3;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-4, result);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var dividend = 1043146863;
            var divisor = -562512009;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var dividend = -2147483648;
            var divisor = 2147483647;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var dividend = -2147483648;
            var divisor = 4;

            var result = _solution.Divide(dividend, divisor);

            Assert.AreEqual(-536870912, result);
        }
    }
}
