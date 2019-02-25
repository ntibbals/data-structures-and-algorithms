using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graphs
    {
        public List<Edge> Edges { get; set; }

        public List<Node> Vertices { get; set; }

        public int Size { get; set; }

        public Graphs()
        {
            List<Edge> edges = new List<Edge>();
            Edges = edges;
            List<Node> vertices = new List<Node>();
            Vertices = vertices;
            foreach (Node v in vertices)
            {
                v.Graph = this;
            }
            Size = 0;
        }


        public Graphs(List<Edge> edges, List<Node> vertices)
        {
            Edges = edges;
            Vertices = vertices;
            foreach (Node v in vertices)
            {
                v.Graph = this;
            }
            Size = 0;
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        public void AddEdge(Node v1, Node v2, int weight)
        {
            Edges.Add(new Edge(v1, v2, weight));
        }

        public void AddVertex(Node vertices)
        {
            Vertices.Add(vertices);
            vertices.Graph = this;
            Size = 1 + Size;
        }

        public void RemoveEdge(Edge edge)
        {
            Edges.Remove(edge);
        }

        public void RemoveVertex(Node vertices)
        {
            Edges.RemoveAll(edge => edge.V2 == vertices || edge.V1 == vertices);
            Vertices.Remove(vertices);
        }

        public List<Node> GetNodes()
        {
            List<Node> vList = new List<Node>();
            foreach (Node v in Vertices)
            {
                vList.Add(v);
            }

            return vList;
        }

        public List<Edge> GetNeighbors(Node vertex)
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
