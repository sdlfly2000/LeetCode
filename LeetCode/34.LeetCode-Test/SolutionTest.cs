using LeetCode_34;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _34.LeetCode_Test
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

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var target = 8;

            // Action
            var result = _solution.SearchRange(nums,target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var target = 6;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { };
            var target = 0;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod4()
        {
            // Arrange
            var nums = new int[] { 1 };
            var target = 1;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod5()
        {
            // Arrange
            var nums = new int[] { 2,2 };
            var target = 2;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod6()
        {
            // Arrange
            var nums = new int[] { 1, 4 };
            var target = 4;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod7()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3 };
            var target = 1;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod8()
        {
            // Arrange
            var nums = new int[] { 3, 3, 3 };
            var target = 3;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(2, result[1]);
        }        
        
        [TestMethod, TestCategory("LeetCode34")]
        public void TestMethod9()
        {
            // Arrange
            var nums = new int[] { 0, 1, 2, 3, 4, 4, 4 };
            var target = 2;

            // Action
            var result = _solution.SearchRange(nums, target);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}