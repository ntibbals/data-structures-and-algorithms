using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Vertex
    {
        public object Value { get; set; }
        public Graphs Graph { get; set; }

        public Vertex(object value)
        {
            Value = value;
        }

    }
}
