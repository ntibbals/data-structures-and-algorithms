using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    public class BinarySearchTree<T>
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        /// <summary>
        /// Adds nodes to binary search tree
        /// </summary>
        /// <param name="node">node to add</param>
        public void Add(Node<int> node)
        {
            Node<int> Root = node;
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Node<int> current = Root;
                Node<int> parent;
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
        /// Initial method call for add, uses recursion
        /// </summary>
        /// <param name="value">node to add</param>
        //public void AddT(T value)
        //{
        //    Root = AddT(value, Root);
        //}

        /// <summary>
        /// Overloaded method to identify proper placedment for new node
        /// </summary>
        /// <param name="value">value to add</param>
        /// <param name="node">current node</param>
        /// <returns></returns>
        //public Node<T> AddT( T value, Node<T> node)
        //{
        //    if (node == null) /// if null, add node to current position
        //    {
        //        return new Node<T>(value);
        //    }

        //    if (node.Value > value) /// if node is greater than the value, look to the left
        //    {
        //        node.Left = AddT(value, node.Left); //recussive call
        //    }

        //    else if (node.Value < value) /// if node is less than value, look to the right
        //    {
        //        node.Right = AddT(value, node.Right); // recurssive call
        //    }

        //    else
        //    {
        //        return node;
        //    }
        //    return node;
        //}
        /// <summary>
        /// Searches tree for specific node
        /// </summary>
        /// <param name="value">value of node to search</param>
        /// <returns>true if it contains, false if not in tree</returns>
        public bool Contain(int value)
        {
            Node<int> newNode = new Node<int>(value);
            Node<int> root = newNode;

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
