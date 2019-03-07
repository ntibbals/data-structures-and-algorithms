using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graphs
    {
        public List<Edge> Edges { get; set; }

        public List<Node> Vertices { get; set; }

        public int Size { get; set; }

        /// <summary>
        /// Empty Graph Constructor
        /// </summary>
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

        /// <summary>
        /// Graph constructor with edges and vertices
        /// </summary>
        /// <param name="edges">Graph Edges</param>
        /// <param name="vertices">Graph Vertices</param>
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

        /// <summary>
        /// Method addes a vertex to the graph and increases size by 1
        /// </summary>
        /// <param name="vertices">Vertices</param>
        public void AddNode(Node vertices)
        {
            Vertices.Add(vertices);
            vertices.Graph = this;
            Size = 1 + Size;
        }

        /// <summary>
        /// Method adds an edge to the graph
        /// </summary>
        /// <param name="edge">Edge to add</param>
        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        /// <summary>
        /// Method adds an edge based on v1
        /// </summary>
        /// <param name="v1">starting vertex</param>
        /// <param name="v2">Ending vertex</param>
        /// <param name="weight">Weight</param>
        public void AddEdge(Node v1, Node v2, int weight)
        {
            Edges.Add(new Edge(v1, v2, weight));
        }


        /// <summary>
        /// Removes an edge from graph
        /// </summary>
        /// <param name="edge">Removes edge from graph</param>
        public void RemoveEdge(Edge edge)
        {
            Edges.Remove(edge);
        }

        /// <summary>
        /// Method removes a vertex from graph
        /// </summary>
        /// <param name="vertices">Vertices to remove</param>
        public void RemoveVertex(Node vertices)
        {
            Edges.RemoveAll(edge => edge.V2 == vertices || edge.V1 == vertices);
            Vertices.Remove(vertices);
        }

        /// <summary>
        /// Method retreives all nodes from a graph
        /// </summary>
        /// <returns>A list of all nodes</returns>
        public List<Node> GetNodes()
        {
            if(Size < 1)
            {
                return null;
            }
            List<Node> vList = new List<Node>();
            foreach (Node v in Vertices)
            {
                vList.Add(v);
            }

            return vList;
        }

        /// <summary>
        /// Method determines edges of given vertex
        /// </summary>
        /// <param name="vertex">Given vertex</param>
        /// <returns>List of edges</returns>
        public List<Edge> GetNeighbors(Node vertex)
        {
            List<Edge> neighbors = new List<Edge>();

            foreach (Edge v in vertex.Graph.Edges)
            {
                neighbors.Add(v);
            }

            return neighbors;
        }

        /// <summary>
        /// Retreive the size of the graph
        /// </summary>
        /// <returns>size of graph</returns>
        public int GetSize()
        {
            return Size;
        }

        /// <summary>
        /// Traverse a graph using breadth first approach
        /// </summary>
        /// <param name="node">Starting point</param>
        /// <returns>List of nodes traversed</returns>
        public List<Node> BreadFirst(Node node)
        {
            List<Node> order = new List<Node>();
            Hashtable table = new Hashtable(); 
            Queue<Node> que = new Queue<Node>();

            que.Enqueue(node);

            while (que.TryPeek(out node))
            {
                Node front = que.Dequeue();
                order.Add(front);

                foreach (Edge child in front.Graph.GetNeighbors(front))
                {
                    if (!table.Contains(front) && !front.Visited)
                    {
                        
                        table.Add(child.V2, front.Value);
                        front.Visited = true;
                        que.Enqueue(child.V2);
                        
                        //order.Add(front);
                    }
                }
            }
            return order;
        }
    }
}
