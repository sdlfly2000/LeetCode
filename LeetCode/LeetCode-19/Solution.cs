using System;

namespace LeetCode_19
{
    public class Solution
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

        private int _nodeTotalLength = 0;
        private int _target = 0;
        private int _current = 1;
        private ListNode _prevNode;
        private ListNode _nextNode;

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            _target = n;

            GetNextNode(head);

            if(_prevNode != null &&
                _nextNode != null)
            {
                _prevNode.next = _nextNode;
            }

            if (_prevNode == null &&
                _nextNode != null)
            {
                return _nextNode;
            }

            if (_nodeTotalLength == 1 && n == 1)
            {
                return null;
            }

            return head;            
        }

        private void GetNextNode(ListNode currentNode)
        {
            _nodeTotalLength++;

            if (currentNode.next == null)
            {
                return;
            }

            GetNextNode(currentNode.next);
            _current++;

            if(_current == _target)
            {
                _nextNode = currentNode.next;
            }

            if(_current == _target + 1)
            {
                _prevNode = currentNode;
            }

            if(_current == 2 && _target == 1)
            {
                currentNode.next = null;
            }
        }
    }
}
