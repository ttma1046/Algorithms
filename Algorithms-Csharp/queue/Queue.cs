﻿namespace Algorithms_Csharp.queue
{
    class Queue
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node(int x)
            {
                this.val = x;
            }
        }

        private Node head; // remove from the head

        private Node tail; // add node

        public bool isEmpty()
        {
            return head == null;
        }

        public int peek()
        {
            // ignore corner case (null pointer check)..
            if (head != null)
            {
                return head.val;
            }
            return 0;
        }

        public void queue(int val)
        {
            Node node = new Node(val);
            if (tail != null)
            {
                tail.next = node;
            }

            tail = node;

            if (head == null)
            {
                head = node;
            }
        }

        public int dequeue()
        {
            int returnValue = head.val;
            if (head.next != null)
            {
                head = head.next;
            }
            else
            {
                head = null;
                tail = null;
            }

            return returnValue;
        }
    }

}
