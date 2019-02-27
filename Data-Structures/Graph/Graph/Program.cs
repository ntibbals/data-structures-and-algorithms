using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");

            graph.AddNode(testV1);
            graph.AddNode(testV2);
            graph.AddEdge(testV1, testV2, 4);

            List<Node> ordered = graph.BreadFirst(testV1);
            foreach (Node item in ordered)
            {
                Console.Write($"{item.Value} => ");
            }

            DGraph dictGraph = new DGraph();
            NodeD node1 = new NodeD("Sea");
            NodeD node2 = new NodeD("Chi");

            dictGraph.AddNode(node1);
            dictGraph.AddNode(node2);
            dictGraph.AddEdge(node1, node2, 150);
            List<DEdge> edges = dictGraph.GetNeighbors(node2);
            foreach (DEdge item in edges)
            {
                Console.Write($"{item} => ");
            }
            Console.ReadLine();

        }
    }
}
