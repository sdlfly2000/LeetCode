using LeetCode_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_9_Test
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
        public void SolutionTest_1()
        {
            // Arrange
            var test = 121;

            // Act
            var result = _solution.IsPalindrome(test);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SolutionTest_2()
        {
            // Arrange
            var test = -121;

            // Act
            var result = _solution.IsPalindrome(test);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SolutionTest_3()
        {
            // Arrange
            var test = 10;

            // Act
            var result = _solution.IsPalindrome(test);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SolutionTest_4()
        {
            // Arrange
            var test = -101;

            // Act
            var result = _solution.IsPalindrome(test);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
