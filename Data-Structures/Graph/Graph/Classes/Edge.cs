using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Edge
    {


        public Node V1 { get; set; }
        public Node V2 { get; set; }
        public int Weight { get; set; }

        public Edge()
        {

        }
        public Edge(Node neightbor1, Node neighbor2, int weight)
        {
            V1 = neightbor1;
            V2 = neighbor2;
            Weight = weight;
        }
    }
}
