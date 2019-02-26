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
            Console.ReadLine();

        }
    }
}
