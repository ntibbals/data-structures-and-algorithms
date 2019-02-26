using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph.Classes
{
    public class DGraph
    {
        public Dictionary<NodeD, LinkedList<DEdge>> AdjList { get; set; }
        public int Size { get; set; }

        public DGraph()
        {
            Dictionary<NodeD, LinkedList<DEdge>> adjList = new Dictionary<NodeD, LinkedList<DEdge>>();
            AdjList = adjList;
            Size = 0;
        }

        public void AddNode(NodeD vertices)
        {
            LinkedList<DEdge> neighbor = new LinkedList<DEdge>();
            AdjList.Add(vertices, neighbor);
            Size = 1 + Size;
        }

        public void AddEdge(NodeD v1, NodeD v2, int weight)
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

        public List<NodeD> GetNodes()
        {
            if(Size < 1)
            {
                return null;
            }
           return AdjList.Keys.ToList();
        }

        public List<DEdge> GetNeighbors(NodeD vertex)
        {
            LinkedList<DEdge> neighbor = new LinkedList<DEdge>();
            AdjList.TryGetValue(vertex, out neighbor);
            return neighbor.ToList();
        }

        public int GetSize()
        {
            return Size;
        }

        public List<object> BreadthFirst(NodeD root)
        {
            List<object> order = new List<object>();
            Hashtable table = new Hashtable();
            Queue<NodeD> breadth = new Queue<NodeD>();

            breadth.Enqueue(root);

            while(breadth.TryPeek(out root))
            {
                NodeD front = breadth.Dequeue();

                   LinkedList<DEdge> neighbor = new LinkedList<DEdge>();
                    AdjList.TryGetValue(front, out neighbor);
                    foreach (DEdge child in neighbor)
                    {

                    if (!table.ContainsKey(child))
                    {


                        table.Add(front.Value, front.Value);
                        breadth.Enqueue(front);
                        order.Add(front);
                    }
                }

            }
            return order;
        }
    }
}
