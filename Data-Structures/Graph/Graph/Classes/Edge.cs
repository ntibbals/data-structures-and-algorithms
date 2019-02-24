using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Edge
    {


        public Vertex V1 { get; set; }
        public Vertex V2 { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex neightbor1, Vertex neighbor2, int weight)
        {
            V1 = neightbor1;
            V2 = neighbor2;
            Weight = weight;
        }
    }
}
