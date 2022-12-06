# Week 14:
In week 14, I learned about the tree data structure, how to create them, and how to traverse them.

## Trees
A tree organizes values in a hierarchy, using a structure called a node to hold each value. Each node also holds a reference to its children nodes, of which in a binary tree there can be only be two child nodes: left and right nodes. The tree's first node is referred to as the "root node". 
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
