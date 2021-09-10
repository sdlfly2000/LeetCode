using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_21;

namespace _21.LeetCode_Test
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
            // Arrange
            var temp = new ListNode(4);
            temp = new ListNode(2, temp);
            var l1 = new ListNode(1, temp);

            temp = new ListNode(4);
            temp = new ListNode(3, temp);
            var l2 = new ListNode(1, temp);

            // Act
            var result = _solution.MergeTwoLists(l1, l2);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
