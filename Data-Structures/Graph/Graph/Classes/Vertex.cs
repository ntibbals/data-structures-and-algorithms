using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Vertex
    {
        public string Name { get; set; }
        public Dictionary<string, List<string>> weightTable { get; set; }
        public bool Visited { get; set; }
        public List<Edge> Edges { get; set; }

        public Vertex()
        {
           
        }
    }
}
