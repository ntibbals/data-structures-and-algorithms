using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Graphs Graph { get; set; }

        public Node(object value)
        {
            Value = value;
        }

    }
}
