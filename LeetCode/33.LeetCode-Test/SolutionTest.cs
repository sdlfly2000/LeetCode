using LeetCode_33;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _33.LeetCode_Test
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


        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 0;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(4, result);
        }

        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 3;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(-1, result);
        }

        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1 };
            var target = 0;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(-1, result);
        }

        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod4()
        {
            // Arrange
            var nums = new int[] { 1,3 };
            var target = 0;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(-1, result);
        }

        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod5()
        {
            // Arrange
            var nums = new int[] { 1, 3, 4, 5, 6, 8 };
            var target = 9;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(-1, result);
        }

        [TestMethod, TestCategory("LeetCode33")]
        public void TestMethod6()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 6, 7, 9 };
            var target = 0;

            // Action
            var result = _solution.Search(nums, target);

            // Asserts
            Assert.AreEqual(-1, result);
        }
    }
}