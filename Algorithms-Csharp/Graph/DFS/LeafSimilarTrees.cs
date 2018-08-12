using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.Graph.DFS
{
    class LeafSimilarTrees
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null)
            {
                return false;
            }

            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            ReturnLeafValueSequence(root1, result1);
            ReturnLeafValueSequence(root2, result2);

            return result1.SequenceEqual(result2);
        }

        public void ReturnLeafValueSequence(TreeNode node, List<int> result)
        {
            if (node == null) {      
                return;
            }

            if (node.left == null && node.right == null) {
                result.Add(node.val);
            }

            if (node.left != null)
            {
                ReturnLeafValueSequence(node.left, result);
            }

            if (node.right != null)
            {
                ReturnLeafValueSequence(node.right, result);
            }
        }

        public static void main(string[] args)
        {
            var root1 = new TreeNode(3) {
                left = new TreeNode(5) {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                },
                right = new TreeNode(1) {
                    left = new TreeNode(9),
                    right = new TreeNode(8)
                }
            };

            var root2 = new TreeNode(3) {
                left = new TreeNode(5) {
                    left = new TreeNode(6),
                    right = new TreeNode(7)
                },
                right = new TreeNode(1) {
                    left = new TreeNode(4),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(9),
                        right = new TreeNode(8)
                    }
                }
            };

            Console.WriteLine(new LeafSimilarTrees().LeafSimilar(root1, root2));
        }
    }
}
