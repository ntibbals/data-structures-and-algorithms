using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    class BinarySearchTree
    {
        public BinaryTree BiTree { get; set; }

        public BinarySearchTree(BinaryTree biTree)
        {
            BiTree = biTree;
        }
        public void Add(Node node)
        {
            Node Root = node;
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (node.Value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = node;
                            return;
                        }
                    }
                }
            }
        }

        public Node Search(int value)
        {
            Node newNode = new Node(value);
            Node root = newNode;

            while (root != null)
            {
                if( root.Value == value)
                {
                    return root;
                }
                else if (root.Value > value)
                {
                    root = root.Left;
                }
                else
                {
                    root = root.Right;
                }
            }
            return null;
        }
    }
}
