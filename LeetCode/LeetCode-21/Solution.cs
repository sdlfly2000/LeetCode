namespace LeetCode_21
{
    using System.ComponentModel;

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode l1Point, l2Point, headNode;

            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            if (l1.val < l2.val)
            {
                headNode = l1;
                l1Point = l1.next;
                l2Point = l2;
            }
            else
            {
                headNode = l2;
                l2Point = l2.next;
                l1Point = l1;
            }

            var ret = headNode;

            while (l1Point != null || l2Point != null)
            {
                if (l2Point != null && l1Point == null)
                {
                    headNode.next = l2Point;
                    l2Point = l2Point.next;
                }

                if (l1Point != null && l2Point == null)
                {
                    headNode.next = l1Point;
                    l1Point = l1Point.next;
                }

                if (l1Point != null && l2Point != null)
                {
                    if (l1Point.val < l2Point.val)
                    {
                        headNode.next = l1Point;
                        l1Point = l1Point.next;
                    }
                    else
                    {
                        headNode.next = l2Point;
                        l2Point = l2Point.next;
                    }
                }

                headNode = headNode.next;
            }

            return ret;
        }
    }
    
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
    }
}
