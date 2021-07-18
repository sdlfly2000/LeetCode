using LeetCode_15;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_15_Test
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

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod2()
        {
            // Arrange
            var nums = new int[] {};

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod3()
        {
            // Arrange
            var nums = new int[] { 0 };

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod4()
        {
            // Arrange
            var nums = new int[] { 0, 0, 0 };

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod5()
        {
            // Arrange
            var nums = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            //Assert.AreEqual("[[-4, 0, 4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]");
        }
    }
}
