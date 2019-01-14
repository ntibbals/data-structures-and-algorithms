using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        /// <summary>
        /// Vale of Node
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Refrence to next node in Linked List
        /// </summary>
        public Node Next { get; set; }
        /// <summary>
        /// Constructor for initializing a value for the node
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
