using leetCode_26;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _26.LeetCode_Test
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
            var nums = new int[]{ 1, 1, 2 };

            var result = _solution.RemoveDuplicates(nums);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var result = _solution.RemoveDuplicates(nums);

            Assert.AreEqual(5, result);
        }
    }
}
