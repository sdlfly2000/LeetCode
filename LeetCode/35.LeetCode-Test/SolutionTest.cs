using LeetCode_35;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _35.LeetCode_Test
{
    [TestClass]
    public class SolutionTest
    {
        private Solution _solution;

        [TestInitialize]
        public void TestInitialize()
        {
            _solution= new Solution();
        }

        [TestMethod, TestCategory("LeetCode35")]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 1,3,5,6 };
            var target = 5;

            // Action
            var result = _solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(2, result);
        }        
        
        [TestMethod, TestCategory("LeetCode35")]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 1,3,5,6 };
            var target = 2;

            // Action
            var result = _solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod, TestCategory("LeetCode35")]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 7;

            // Action
            var result = _solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}