using LeetCode_20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20.LeetCode_Test
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
            var s = "()";

            var result = _solution.IsValid(s);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var s = "()[]{}";

            var result = _solution.IsValid(s);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var s = "(]";

            var result = _solution.IsValid(s);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var s = "([)]";

            var result = _solution.IsValid(s);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var s = "{[]}";

            var result = _solution.IsValid(s);

            Assert.IsTrue(result);
        }
    }
}
