namespace Algorithms_Csharp.linkedlist
{
    using System;

    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }

    public class MyLinkedList
    {
        public Node head;

        public void append(int data)
        {
            if (head == null) {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.next != null) {
                current = current.next;
            }

            current.next = new Node(data);
        }

        public void prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void insertAfterHead(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node newNode = new Node(data);
            newNode.next = head.next;
            head.next = newNode;
        }

        public bool search(int data)
        {
            if (head == null) { return false; }

            Node current = head; 
            while(current != null)
            {
                if (current.data == data)
                {
                    return true;
                }

                current = current.next;
            }

            return false;  
        }

        public void deleteWithValue(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void traverse()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine("Node Value: {0}", current.data);
                current = current.next;
            }
        }

        public void traverseReversal()
        {
            if (head != null)
            {
                traverseReversal(head);
                
            }
        }

        public void traverseReversal(Node node)
        {
            if (node != null)
            {
                traverseReversal(node.next);
                Console.WriteLine("Node Value: {0}", node.data);
            }
        }

        public Node reverseList(Node head)
        {               
            if (head == null)
            {
                return null;
            }

            Node nodeResult = null;

            Node nodePre = null;
            Node current = head;

            while (current != null)
            {

                Node nodeNext = current.next;

                if (nodeNext == null)
                {
                    nodeResult = current;
                }

                current.next = nodePre;
                nodePre = current;
                current = nodeNext;
            }

            return nodeResult;
        }
                    
        public static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.head = new Node(1);
            list.append(3);
            list.append(4);

            list.insertAfterHead(2);

            list.traverse();
            list.traverseReversal();
            Console.WriteLine(list.search(3));
            Console.WriteLine(list.search(6));
        }
    }
}
                                     