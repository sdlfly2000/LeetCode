namespace LeetCode_25
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
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if(head == null)
            {
                return null;
            }

            var dummyNode = new ListNode(0, null);
            var headNode = dummyNode;            

            while (head != null)
            {
                var groupNodes = new ListNode[k];

                for (var i = 0; i < k; i++)
                {
                    groupNodes[i] = head;

                    if(head == null)
                    {
                        break;
                    }

                    head = head.next;
                }

                dummyNode.next = ReverseNodes(groupNodes);

                for(var i = 0; i < k && dummyNode != null; i++)
                {
                    dummyNode = dummyNode.next;
                }
            }

            return headNode.next;
        }

        private ListNode ReverseNodes(ListNode[] nodes)
        {
            ListNode head = new ListNode(0, null);
            var duplicateHead = head;

            for (var i = nodes.Length - 1; i >= 0; i--)
            {
                if(nodes[i] != null)
                {
                    nodes[i].next = null;
                    head.next = nodes[i];
                    head = head.next;
                }
                else
                {
                    return nodes[0];
                }
            }
            
            return duplicateHead.next;
        }
    }
}
