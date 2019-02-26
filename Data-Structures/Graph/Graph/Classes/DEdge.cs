using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class DEdge
    {
        NodeD Vertex { get; set; }
        int Weight { get; set; }

        public DEdge(NodeD vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }
}
