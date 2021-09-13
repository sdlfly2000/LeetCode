using LeetCode_22;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _22.LeetCode_Test
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
            var n = 3;

            // Act
            var result = _solution.GenerateParenthesis(n);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
