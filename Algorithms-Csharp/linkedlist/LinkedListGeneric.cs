using System;

namespace Algorithms_Csharp.linkedlist
{
    class LinkedListGeneric
    {
        static void printList(Node<string> head)
        {
            Node<String> current = head;
            while (current != null)
            {
                Console.WriteLine(current.item);
                current = current.next;
            }
        }

        static void printListRev(Node<String> head)
        {
            //倒序遍历链表主要用了递归的思想
            if (head != null)
            {
                printListRev(head.next);
                Console.WriteLine(head.item);
            }
        }

        // 单链表反转 主要是逐一改变两个节点间的链接关系来完成
        static Node<String> revList(Node<String> head)
        {

            if (head == null)
            {
                return null;
            }

            Node<String> nodeResult = null;

            Node<String> nodePre = null;
            Node<String> current = head;

            while (current != null)
            {
                Node<String> nodeNext = current.next;

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
    }

    class Node<E>
    {

        internal E item;
        internal Node<E> next;

        // 构造函数
        Node(E element)
        {
            this.item = element;
            this.next = null;
        }
    }
}