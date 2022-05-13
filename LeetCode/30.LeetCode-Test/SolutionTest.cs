using LeetCode_30;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _30.LeetCode_Test
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
            var s = "barfoothefoobarman";
            var words = new string[] { "foo", "bar" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var s = "wordgoodgoodgoodbestword";
            var words = new string[] { "word", "good", "best", "word" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
        }
    }
}
