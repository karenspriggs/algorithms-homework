using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAssignment
{
    public class TreeNode
    {
        public int Key;
        public TreeNode LeftNode;
        public TreeNode RightNode;

        public TreeNode(int _key)
        {
            Key = _key;
            LeftNode = null;
            RightNode = null;
        }
    }

    public class BinaryTree
    {
        private TreeNode RootNode;

        // Takes values from an array and recursively adds it to the binary tree
        public TreeNode InsertValueInLevelOrder(int[] data, int index)
        {
            TreeNode rootNode = null;

            if (index < data.Length)
            {
                rootNode = new TreeNode(data[index]);

                rootNode.LeftNode = InsertValueInLevelOrder(data, 2 * index + 1);
                rootNode.RightNode = InsertValueInLevelOrder(data, 2 * index + 2);
            }

            return rootNode;
        }

        // Sets the node values from the elements in the array and then
        // prints the tree using the three traversal strategies
        public BinaryTree(int[] data)
        {
            RootNode = InsertValueInLevelOrder(data, 0);

            PostOrderTraversal(RootNode);
            InOrderTraversal(RootNode);
            PreOrderTraversal(RootNode);
        }

        // Postorder traversal is used to delete a binary search tree
        // or to get the postfix expression of a an expression tree
        private void PostOrderTraversal(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            PostOrderTraversal(currentNode.LeftNode);
            PostOrderTraversal(currentNode.RightNode);

            Console.WriteLine(currentNode.Key);
        }

        // In order traversal gives the nodes in a non-decreasing order
        private void InOrderTraversal(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            InOrderTraversal(currentNode.LeftNode);

            Console.WriteLine(currentNode.Key);

            InOrderTraversal(currentNode.RightNode);
        }

        // Pre order traversal is often used to create a copy of a binary
        // tree, or to get the prefix expression on an expression tree
        private void PreOrderTraversal(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            Console.WriteLine(currentNode.Key);

            PreOrderTraversal(currentNode.LeftNode);
            PreOrderTraversal(currentNode.RightNode);
        }
    }
}
