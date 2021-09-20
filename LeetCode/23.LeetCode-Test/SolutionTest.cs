using LeetCode_23;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _23.LeetCode_Test
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
            var node1 = new ListNode(5, null);
            var node2 = new ListNode(4, node1);
            var nodeA = new ListNode(1, node2);

            var node3 = new ListNode(4, null);
            var node4 = new ListNode(3, node3);
            var nodeB = new ListNode(1, node4);

            var node5 = new ListNode(6, null);
            var nodeC = new ListNode(2, node5);

            var result = _solution.MergeKLists(new ListNode[] { nodeA, nodeB, nodeC });

            Assert.IsNotNull(result);
        }
    }
}
