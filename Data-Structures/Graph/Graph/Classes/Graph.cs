using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graph
    {
        public List<Edge> Edges { get; set; }

        public List<Vertex> Vertices { get; set; }

        public int Size { get; set; }

        public Graph(List<Edge> edges, List<Vertex> vertices)
        {
            Edges = edges;
            Vertices = vertices;
            foreach (Vertex v in vertices)
            {
                v.Graph = this;
            }
            Size = 0;
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
            Size = 1 + Size;
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

        public List<Vertex> GetVertex(List<Vertex> vertices)
        {
            List<Vertex> vList = new List<Vertex>();
            foreach (Vertex v in vertices)
            {
                vList.Add(v);
            }

            return vList;
        }

        public List<Edge> GetNeighbors(Vertex vertex)
        {
            List<Edge> neighbors = new List<Edge>();

            foreach (var v in vertex.Graph.Edges)
            {
                neighbors.Add(v);
            }

            return neighbors;
        }

        public int GetSize()
        {
            return Size;
        }
    }
}
