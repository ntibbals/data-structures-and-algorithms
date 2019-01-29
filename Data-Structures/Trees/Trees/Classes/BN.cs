using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Nodeb
    {
        /// <summary>
        /// Sets Node property for value
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// set Node property for left child
        /// </summary>
        public Nodeb Left { get; set; }
        /// <summary>
        /// set Node property for right child
        /// </summary>
        public Nodeb Right { get; set; }


        public Nodeb()
        {

        }

        /// <summary>
        /// Constructor for node
        /// </summary>
        /// <param name="value">integer value</param>
        public Nodeb(int value)
        {
            Value = value;
        }
    }
}
