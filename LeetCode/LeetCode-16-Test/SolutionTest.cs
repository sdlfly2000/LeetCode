using LeetCode_16;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_16_Test
{
    [TestClass]
    public class SolutionTest
    {
        private Solution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var num = new int[] { -1, 2, 1, -4 };
            var target = 1;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var num = new int[] { 0, 1, 2 };
            var target = 0;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var num = new int[] { -3, -2, -5, 3, -4};
            var target = -1;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var num = new int[] { 1, -3, 3, 5, 4, 1};
            var target = 1;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var num = new int[] { 0, 2, 1, -3};
            var target = 1;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var num = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            var target = 82;

            var result = _solution.ThreeSumClosest(num, target);

            Assert.AreEqual(82, result);
        }
    }
}
