using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class NodeB
    {
        public object Value { get; set; }
        public bool Visited { get; set; }
        public List<Node> Children { get; set; }

    }
}
