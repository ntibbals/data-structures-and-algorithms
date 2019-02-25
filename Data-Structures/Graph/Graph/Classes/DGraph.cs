using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph.Classes
{
    class DGraph
    {
        public Dictionary<Node, LinkedList<DEdge>> AdjList { get; set; }
        public int Size { get; set; }

        public DGraph()
        {
            Dictionary<Node, LinkedList<DEdge>> adjList = new Dictionary<Node, LinkedList<DEdge>>();
            AdjList = adjList;
            Size = 0;
        }

        public void AddNode(Node vertices)
        {
            LinkedList<DEdge> neighbor = new LinkedList<DEdge>();
            AdjList.Add(vertices, neighbor);
            Size = 1 + Size;
        }

        public void AddEdge(Node v1, Node v2, int weight)
        {
            if(AdjList.ContainsKey(v1) && AdjList.ContainsKey(v2))
            {
                LinkedList<DEdge> neighbor = new LinkedList<DEdge>();
                AdjList.TryGetValue(v1, out neighbor);
                DEdge edge = new DEdge(v2, weight);
                neighbor.AddFirst(edge);
                AdjList[v1] = neighbor;
            }
            else
            {
                throw null;
            }
        }

        public List<Node> GetNodes()
        {
            if(Size < 1)
            {
                return null;
            }
           return AdjList.Keys.ToList();
        }
    }
}
