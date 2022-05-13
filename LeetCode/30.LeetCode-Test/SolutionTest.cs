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

        [TestMethod]
        public void TestMethod3()
        {
            var s = "wordgoodgoodgoodbestword";
            var words = new string[] { "word", "good", "best", "word" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var s = "barfoothefoobarman";
            var words = new string[] { "foo", "bar" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(9));
        }
        
        [TestMethod]
        public void TestMethod5()
        {
            var s = "wordgoodgoodgoodbestword";
            var words = new string[] { "word", "good", "best", "good" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains(8));
        }

        [TestMethod]
        public void TestMethod6()
        {
            var s = "aaa";
            var words = new string[] { "a", "a" };

            var result = _solution.FindSubstring(s, words);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(1));
        }
    }
}
