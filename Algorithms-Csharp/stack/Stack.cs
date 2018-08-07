namespace Algorithms_Csharp.stack
{
    public class Stack
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

        public Node top; // Add and remove here

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            // ignore corner case (null pointer check)..
            if (top != null)
            {
                return top.val;
            }
            return 0;
        }

        public void push(int value)
        {
            Node newNode = new Node(value);

            newNode.next = top;

            top = newNode;

        }

        public int pop()
        {
            int value = top.val;

            top = top.next;

            return value;
        }
    }
}
