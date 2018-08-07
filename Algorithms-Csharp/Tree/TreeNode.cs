using System;

namespace Algorithms_Csharp.Tree
{
    public class TreeNode
    { // Binary Search Tree
        TreeNode left;
        TreeNode right;

        int val;

        public TreeNode(int x)
        {
            this.val = x;
        }

        public void insert(int value)
        {
            if (value <= val)
            {
                if (left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                    left.insert(value);
                }
            }
            else
            {
                // go to right
                if (right == null)
                {
                    right = new TreeNode(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }

        public bool contains(int value)
        {
            if (value == val)
            {
                return true;
            }
            else if (value < val)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }

            // return false;
        }

        public void printInOrder()
        {
            // left => root => right

            if (left != null)
            {
                left.printInOrder();
            }

            Console.WriteLine(val);

            if (right != null)
            {
                right.printInOrder();
            }
        }


        public void printPreOrder()
        {
            // root => left => right
            Console.WriteLine(val);

            if (left != null)
            {
                left.printPreOrder();
            }

            if (right != null)
            {
                right.printPreOrder();
            }
        }

        public void printPostOrder()
        {
            // left => right => root
            if (left != null)
            {
                left.printPostOrder();
            }

            if (right != null)
            {
                right.printPostOrder();
            }

            Console.WriteLine(val);
        }
    }
}
