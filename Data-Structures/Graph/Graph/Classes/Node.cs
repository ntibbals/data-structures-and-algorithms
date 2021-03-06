﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Graphs Graph { get; set; }
        public bool Visited { get; set; }
        public List<Node> Children { get; set; }

        public Node(object value)
        {
            Value = value;
            Visited = false;
        }

    }
}
