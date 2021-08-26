using LeetCode_18;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_18_Test
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
            var nums = new int[] { 1, 0, -1, 0, -2, 2 };
            var target = 0;

            var results = _solution.FourSum(nums, target);

            var targetResult = new List<List<int>>();
            targetResult.Add(new List<int>{-2, -1, 1, 2});
            targetResult.Add(new List<int>{ -2, 0, 0, 2 });
            targetResult.Add(new List<int>{-1, 0, 0, 1 });

            Assert.IsTrue(results.All(r => targetResult.Contains(r)));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 2, 2, 2, 2, 2 };
            var target = 8;

            var results = _solution.FourSum(nums, target);

            var targetResult = new List<List<int>>();
            targetResult.Add(new List<int> { 2, 2, 2, 2 });

            Assert.IsTrue(results.All(r => targetResult.Contains(r)));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var nums = new int[] { 0,0,0};
            var target = 0;

            var results = _solution.FourSum(nums, target);

            Assert.IsTrue(results.Count == 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };

            var target = -1;

            var results = _solution.FourSum(nums, target);

            Assert.IsTrue(results.Count == 2);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var nums = new int[] { 2, -4, -5, -2, -3, -5, 0, 4, -2};

            var target = -14;

            var results = _solution.FourSum(nums, target);

            Assert.IsTrue(results.Count == 3);
        }
    }
}
