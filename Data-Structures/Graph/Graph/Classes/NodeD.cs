using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class NodeD
    {
        public object Value { get; set; }
        public bool Visisted { get; set; }

        public NodeD(object value)
        {
            Value = value;
            Visisted = false;
        }
    }
}
