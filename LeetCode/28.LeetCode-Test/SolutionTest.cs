using LeetCode_28;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _28.LeetCode_Test
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
            var haystack = "hello";
            var needle = "ll";

            var result = _solution.StrStr(haystack, needle);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var haystack = "aaaaa";
            var needle = "bba";

            var result = _solution.StrStr(haystack, needle);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var haystack = "";
            var needle = "";

            var result = _solution.StrStr(haystack, needle);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var haystack = "abc";
            var needle = "c";

            var result = _solution.StrStr(haystack, needle);

            Assert.AreEqual(2, result);
        }
    }
}
