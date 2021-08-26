using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_17;

namespace LeetCode_17_Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
            var digits = "23";

            var results = _solution.LetterCombinations(digits);

            var targets = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            Assert.IsTrue(results.All(r => targets.Contains(r)));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var digits = "";

            var results = _solution.LetterCombinations(digits);

            var targets = new List<string> {};

            Assert.IsTrue(results.All(r => targets.Contains(r)));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var digits = "2";

            var results = _solution.LetterCombinations(digits);

            var targets = new List<string> { "a", "b", "c" };

            Assert.IsTrue(results.All(r => targets.Contains(r)));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var digits = "234";

            var results = _solution.LetterCombinations(digits);

            var targets = new List<string> { "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi" };

            Assert.IsTrue(results.All(r => targets.Contains(r)));
        }
    }
}
