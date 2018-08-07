using System.Collections.Generic;

namespace Algorithms_Csharp.linkedlist
{
    public class ListNode
    {
        int val;
        public ListNode next;
        ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class CycleLinkedList
    {
        public bool hasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode fast = head.next;
            ListNode slow = head;
            while (fast != null && fast.next != null && slow != null)
            {
                if (fast == slow)
                {
                    return true;
                }
                fast = fast.next.next;
                slow = slow.next;
            }
            return false;
        }

        public bool hasCyclewithHashTable(ListNode head) {
            if (head == null) return false;
            HashSet<ListNode> visited = new HashSet<ListNode>();

            ListNode current = head;
            while (current != null)
            {
                if (visited.Contains(current)) return true;
                visited.Add(current);
                current = current.next;
            }

            return false;
        }
    }

}
