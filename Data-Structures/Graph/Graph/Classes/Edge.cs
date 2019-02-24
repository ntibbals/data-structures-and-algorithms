using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Edge
    {


        public Vertex Vertex { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex neightbor, int weight)
        {
            Vertex = neightbor;
            Weight = weight;
        }
    }
}
