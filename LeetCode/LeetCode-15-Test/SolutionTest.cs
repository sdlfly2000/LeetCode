using LeetCode_15;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            // Act
            var result = _solution.ThreeSum(nums);

            // Assert
            Assert.IsTrue(result.Contains(new List<int> { -1, -1, 2 }));
            Assert.IsTrue(result.Contains(new List<int> { -1, 0, 1 }));
        }
    }
}
