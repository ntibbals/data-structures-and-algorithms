using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node
    {
        /// <summary>
        /// Sets Node property for value
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// set Node property for left child
        /// </summary>
        public Node Left { get; set; }
        /// <summary>
        /// set Node property for right child
        /// </summary>
        public Node Right{ get; set; }


        public Node()
        {

        }

        /// <summary>
        /// Constructor for node
        /// </summary>
        /// <param name="value">integer value</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
