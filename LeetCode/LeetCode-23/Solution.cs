using System;

namespace LeetCode_23
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if(lists == null || lists.Length == 0)
            {
                return null;
            }

            ListNode headNode = null;
            ListNode dummyNode = null;

            while (Continue(lists))
            {
                var (minNode, index) = GetMinNode(lists);
                if (dummyNode != null)
                {
                    dummyNode.next = new ListNode(minNode.val);
                    dummyNode = dummyNode.next;
                }
                else
                {
                    dummyNode = new ListNode(minNode.val);
                    headNode = dummyNode;
                }

                lists[index] = lists[index].next;
            }

            return headNode;
        }

        private bool Continue(ListNode[] lists)
        {
            var cont = false;
            foreach(var list in lists)
            {
                if(list != null)
                {
                    cont = true;
                }
            }

            return cont;
        }

        private (ListNode, int) GetMinNode(ListNode[] lists)
        {
            if(lists.Length == 0)
            {
                return (null, 0);
            }

            ListNode minNode = GetNotNullListNode(lists);
            var index = 0;

            for (var i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null && lists[i].val <= minNode.val)
                {
                    minNode = lists[i];
                    index = i;
                }
            }

            return (minNode, index);
        }

        private ListNode GetNotNullListNode(ListNode[] lists)
        {
            ListNode listNode = null;

            foreach (var list in lists)
            {
                if (list != null)
                {
                    listNode = list;
                    break;
                }
            }

            return listNode;
        }
    }
}
