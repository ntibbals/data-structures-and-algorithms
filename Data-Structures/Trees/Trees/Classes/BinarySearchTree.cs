using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    class BinarySearchTree<T>
    {
        public BinaryTree<T> BiTree { get; set; }

        public BinarySearchTree(BinaryTree<T> biTree)
        {
            BiTree = biTree;
        }

        /// <summary>
        /// Adds nodes to binary search tree
        /// </summary>
        /// <param name="node">node to add</param>
        public void Add(Node<T> node)
        {
            Node<T> Root = node;
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Node<T> current = Root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (node < current)
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
            Node<T> newNode = new Node<T>(value);
            Node<T> root = newNode;

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
