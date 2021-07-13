using LeetCode_13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_13_Test
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
        public void TestMethod_1()
        {
            // Arrange
            var test = "DCXXI";

            // Act
            var result = _solution.RomanToInt(test);

            // Assert
            Assert.AreEqual(621, result);
        }
    }
}
