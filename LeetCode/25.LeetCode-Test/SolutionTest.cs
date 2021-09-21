using LeetCode_25;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _25.LeetCode_Test
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
            var node5 = new ListNode(5, null);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);

            var result = _solution.ReverseKGroup(node1, 3);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node2 = new ListNode(2, null);
            var node1 = new ListNode(1, node2);

            var result = _solution.ReverseKGroup(node1, 2);

            Assert.IsNotNull(result);
        }
    }
}
