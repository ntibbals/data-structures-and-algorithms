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
        /// Adds nodes to binary search tree
        /// </summary>
        /// <param name="node">node to add</param>
        public void Add(Nodeb node)
        {
            Nodeb Root = node;
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Nodeb current = Root;
                Nodeb parent;
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
        public void Add(int value)
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
