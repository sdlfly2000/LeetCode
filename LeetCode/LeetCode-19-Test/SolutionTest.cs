using LeetCode_19;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_19_Test
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
            var node2 = new Solution.ListNode(2);
            var head = new Solution.ListNode(1, node2);

            var result = _solution.RemoveNthFromEnd(head, 1);

            Assert.AreEqual(1, result.val);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var head = new Solution.ListNode(1);

            var result = _solution.RemoveNthFromEnd(head, 1);

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var node5 = new Solution.ListNode(5);
            var node4 = new Solution.ListNode(4, node5);
            var node3 = new Solution.ListNode(3, node4);
            var node2 = new Solution.ListNode(2, node3);
            var head = new Solution.ListNode(1, node2);

            var result = _solution.RemoveNthFromEnd(head, 2);

            Assert.AreEqual(5, result.next.next.next.val);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var node2 = new Solution.ListNode(2);
            var head = new Solution.ListNode(1, node2);

            var result = _solution.RemoveNthFromEnd(head, 2);

            Assert.AreEqual(2, result.val);
        }
    }
}
