using LeetCode_14;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_14_Test
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
            string[] test = { "flower", "flow", "flight" };

            // Act
            var result = _solution.LongestCommonPrefix(test);

            // Assert
            Assert.AreEqual("fl", result);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void TestMethod_2()
        {
            // Arrange
            string[] test = { "ab", "a"};

            // Act
            var result = _solution.LongestCommonPrefix(test);

            // Assert
            Assert.AreEqual("a", result);
        }
    }
}
