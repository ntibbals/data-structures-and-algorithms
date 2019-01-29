using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BTS
    {
        public Nodeb Root { get; set; }

        public BTS()
        {
            Root = null;
        }

        public BTS(int value)
        {
            Nodeb newNode = new Nodeb(value);
            Root = newNode;
        }

        /// <summary>
        /// Initial method call for add, uses recursion
        /// </summary>
        /// <param name="value">node to add</param>
        public void Add(int value)
        {
            Root = Add(value, Root);
        }

        /// <summary>
        /// Overloaded method to identify proper placedment for new node
        /// </summary>
        /// <param name="value">value to add</param>
        /// <param name="node">current node</param>
        /// <returns></returns>
        public Nodeb Add(int value, Nodeb node)
        {
            if (node == null) /// if null, add node to current position
            {
                return new Nodeb(value);
            }

            if (node.Value > value) /// if node is greater than the value, look to the left
            {
                node.Left = Add(value, node.Left); //recussive call
            }

            else if (node.Value < value) /// if node is less than value, look to the right
            {
                node.Right = Add(value, node.Right); // recurssive call
            }

            else
            {
                return node;
            }
            return node;
        }

        /// <summary>
        /// Initial Add attempt method
        /// </summary>
        /// <param name="value"></param>
        public void Add2(int value)
        {
            Nodeb newNode = new Nodeb(value);
            Nodeb Root = newNode;
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Nodeb current = Root;
                Nodeb parent;
                parent = current;
                while (true)
                {

                    if (value < current.Value)
                    {
                        if (parent.Left == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                        else
                        {
                            parent = parent.Left;
                        }
                    }
                    else
                    {
                        if (parent.Right == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                        else
                        {
                            parent = parent.Right;
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
            Nodeb newNode = new Nodeb(value);
            Nodeb root = newNode;

            while (root != null)
            {
                if (root.Value == value)
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
