using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node<T>
    {
        /// <summary>
        /// Sets Node property for value
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// set Node property for left child
        /// </summary>
        public Node<T> Left { get; set; }
        /// <summary>
        /// set Node property for right child
        /// </summary>
        public Node<T> Right{ get; set; }


        public Node()
        {

        }

        /// <summary>
        /// Constructor for node
        /// </summary>
        /// <param name="value">integer value</param>
        public Node(T value)
        {
            Value = value;
        }
    }
}
