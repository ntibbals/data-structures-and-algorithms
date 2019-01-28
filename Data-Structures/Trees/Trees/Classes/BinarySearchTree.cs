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

        /// <summary>
        /// Adds nodes to binary search tree
        /// </summary>
        /// <param name="node">node to add</param>
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

        /// <summary>
        /// Searches tree for specific node
        /// </summary>
        /// <param name="value">value of node to search</param>
        /// <returns>true if it contains, false if not in tree</returns>
        public bool Contain(int value)
        {
            Node newNode = new Node(value);
            Node root = newNode;

            while (root != null)
            {
                if( root.Value == value)
                {
                    return true;
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
            return false;
        }
    }
}
