using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class DEdge
    {
        public NodeD Start { get; set; }
        public NodeD End { get; set; }
        public int Weight { get; set; }

        public DEdge(NodeD start, NodeD end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }
    }
}
