# Week 14:
In week 14, I learned about the tree data structure, how to create them, and how to traverse them.

## Trees
A tree organizes values in a hierarchy, using a structure called a node to hold each value. Each node also holds a reference to its children nodes, of which in a binary tree there can be only be two child nodes: left and right nodes. Nodes cannot have more than one parent node. The tree's first node is referred to as the "root node". A heap is also a kind of tree, which is used in algorithms such as HeapSort.


**Node class**
```public class TreeNode
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
```

## Tree Traversal

###Pre-Order Traversal

```
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
```

###In-Order Traversal
``` private void InOrderTraversal(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            InOrderTraversal(currentNode.LeftNode);

            Console.WriteLine(currentNode.Key);

            InOrderTraversal(currentNode.RightNode);
        }
```

###Post-Order Traversal
```
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
```
