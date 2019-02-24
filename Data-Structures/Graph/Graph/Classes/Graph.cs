using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graph
    {
        public List<Edge> Edges { get; set; }

        public List<Vertex> Vertices { get; set; }

        public Graph(List<Edge> edges, List<Vertex> vertices)
        {
            Edges = edges;
            Vertices = vertices;
            foreach (Vertex v in vertices)
            {
                v.Graph = this;
            }
        }
    }
}
