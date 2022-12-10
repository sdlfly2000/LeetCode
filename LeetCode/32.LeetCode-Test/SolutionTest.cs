using LeetCode_32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _32.LeetCode_Test
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

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod1()
        {
            // Arrange
            var s = "(()";
            
            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod2()
        {
            // Arrange
            var s = ")()())";

            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod3()
        {
            // Arrange
            var s = "";

            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod4()
        {
            // Arrange
            var s = "(";

            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod5()
        {
            // Arrange
            var s = "()(())";

            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod, TestCategory("LeetCode32")]
        public void TestMethod6()
        {
            // Arrange
            var s = "()(()";

            // Action
            var result = _solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}