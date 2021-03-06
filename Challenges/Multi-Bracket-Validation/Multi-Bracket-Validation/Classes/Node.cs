﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Bracket_Validation.Classes
{
    public class Node
    {
        /// <summary>
        /// Sets Node property for value
        /// </summary>
        public char Value { get; set; }
        /// <summary>
        /// set Node property for next
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for node
        /// </summary>
        /// <param name="value">integer value</param>
        public Node(char value)
        {
            Value = value;
        }
    }
}
