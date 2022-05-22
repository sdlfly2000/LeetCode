using LeetCode_31;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _31.LeetCode_Test
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
            // Arrange
            var nums = new int[] { 1, 2, 3 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(1, nums[0]);
            Assert.AreEqual(3, nums[1]);
            Assert.AreEqual(2, nums[2]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] { 3, 2, 1 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(1, nums[0]);
            Assert.AreEqual(2, nums[1]);
            Assert.AreEqual(3, nums[2]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 1, 3, 2 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(2, nums[0]);
            Assert.AreEqual(1, nums[1]);
            Assert.AreEqual(3, nums[2]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var nums = new int[] { 2, 3, 1 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(3, nums[0]);
            Assert.AreEqual(1, nums[1]);
            Assert.AreEqual(2, nums[2]);
        }


        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            var nums = new int[] { 5, 4, 7, 5, 3, 2 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(5, nums[0]);
            Assert.AreEqual(5, nums[1]);
            Assert.AreEqual(2, nums[2]);
            Assert.AreEqual(3, nums[3]);
            Assert.AreEqual(4, nums[4]);
            Assert.AreEqual(7, nums[5]);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            var nums = new int[] { 2, 2, 7, 5, 4, 3, 2, 2, 1 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(2, nums[0]);
            Assert.AreEqual(3, nums[1]);
            Assert.AreEqual(1, nums[2]);
            Assert.AreEqual(2, nums[3]);
            Assert.AreEqual(2, nums[4]);
            Assert.AreEqual(2, nums[5]);
            Assert.AreEqual(4, nums[6]);
            Assert.AreEqual(5, nums[7]);
            Assert.AreEqual(7, nums[8]);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            var nums = new int[] { 4, 2, 0, 2, 3, 2, 0 };

            // Action
            _solution.NextPermutation(nums);

            // Assert
            Assert.IsNotNull(nums);
            Assert.AreEqual(4, nums[0]);
            Assert.AreEqual(2, nums[1]);
            Assert.AreEqual(0, nums[2]);
            Assert.AreEqual(3, nums[3]);
            Assert.AreEqual(0, nums[4]);
            Assert.AreEqual(2, nums[5]);
            Assert.AreEqual(2, nums[6]);
        }
    }
}
