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

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        public void AddEdge(Vertex v1, Vertex v2, int weight)
        {
            Edges.Add(new Edge(v1, v2, weight));
        }

        public void AddVertex(Vertex vertices)
        {
            Vertices.Add(vertices);
            vertices.Graph = this;
        }

        public void RemoveEdge(Edge edge)
        {
            Edges.Remove(edge);
        }

        public void RemoveVertex(Vertex vertices)
        {
            Edges.RemoveAll(edge => edge.V2 == vertices || edge.V1 == vertices);
            Vertices.Remove(vertices);
        }
    }
}
