using LeetCode_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_10_Test
{
    [TestClass]
    public class SolutionTest
    {
        private Solution2 _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new Solution2();
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_1()
        {
            // Arrange
            var s = "aa";
            var p = "a";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsFalse(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_2()
        {
            // Arrange
            var s = "aa";
            var p = "a*";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_3()
        {
            // Arrange
            var s = "ab";
            var p = ".*";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_4()
        {
            // Arrange
            var s = "aab";
            var p = "c*a*b";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_5()
        {
            // Arrange
            var s = "mississippi";
            var p = "mis*is*p*.";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsFalse(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_6()
        {
            // Arrange
            var s = "mississippi";
            var p = "mis*is*ip*.";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }


        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_7()
        {
            // Arrange
            var s = "abcd";
            var p = "d*";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsFalse(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_8()
        {
            // Arrange
            var s = "aa";
            var p = "aa";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_9()
        {
            // Arrange
            var s = "ab";
            var p = ".*c";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsFalse(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_10()
        {
            // Arrange
            var s = "aaa";
            var p = "aaaa";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsFalse(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_11()
        {
            // Arrange
            var s = "aaa";
            var p = "a*a";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void SolutionTest_12()
        {
            // Arrange
            var s = "aaa";
            var p = "ab*ac*a";

            // Act
            var output = _solution.IsMatch(s, p);

            // Assert
            Assert.IsTrue(output);
        }
    }
}
