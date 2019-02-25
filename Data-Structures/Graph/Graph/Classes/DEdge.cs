using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class DEdge
    {
        Node Vertex { get; set; }
        int Weight { get; set; }

        public DEdge(Node vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }
}
