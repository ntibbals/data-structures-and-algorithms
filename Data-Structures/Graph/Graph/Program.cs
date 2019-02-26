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
            List<Node> expected = new List<Node>();
            expected.Add(testV1);
            expected.Add(testV2);

            graph.BreadFirst(testV1);
            Console.WriteLine("Hello World!");
            //DGraph graph = new DGraph();
            //NodeD testV1 = new NodeD("Test1");
            //NodeD testV2 = new NodeD("Test2");
            //NodeD testV3 = new NodeD("Test3");

            //graph.AddNode(testV1);
            //graph.AddNode(testV2);
            //graph.AddNode(testV3);
            //graph.AddEdge(testV1, testV2, 4);
            //graph.AddEdge(testV2, testV3, 8);
            //List<NodeD> expected = new List<NodeD>();
            //expected.Add(testV1);
            //expected.Add(testV2);
            //expected.Add(testV3);
            //graph.BreadthFirst(testV1);
        }
    }
}
