using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class DGraph
    {
        public Dictionary<Node, LinkedList<DEdge>> Neighbors { get; set; }
        public int Size { get; set; }

        public DGraph()
        {
            Dictionary<Node, LinkedList<DEdge>> neighbors = new Dictionary<Node, LinkedList<DEdge>>();
            Neighbors = neighbors;
            Size = 0;
        }
    }
}
