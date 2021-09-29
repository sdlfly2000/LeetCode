using LeetCode_27;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _27.LeetCode_Test
{
    [TestClass]
    public class SolutionTest
    {
        private Solution _solution;

        [TestInitialize]
        public void TestIntialize()
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 3, 2, 2, 3 };
            var val = 3;

            var result = _solution.RemoveElement(nums, val);

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;

            var result = _solution.RemoveElement(nums, val);

            Assert.IsNotNull(result);
        }
    }
}
