using Graph.Classes;
using System;
using System.Collections.Generic;

namespace Depth_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");

            graph.AddNode(testV1);
            graph.AddNode(testV2);
            graph.AddEdge(testV1, testV2, 4);
            DepthFirst(graph);
        }

        public static List<Node> DepthFirst(Graphs graph)
        {
            List<Node> allNodes = graph.GetNodes();
            Node root = new Node("root");
            foreach (var item in allNodes)
            {
                root = item;
                break;
            }
            List<Node> preOrder = new List<Node>();

            Stack<Node> depth = new Stack<Node>();

            depth.Push(root);

            while (depth.TryPeek(out root))
            {
                Node top = depth.Pop();
                List<Node> child = new List<Node>();

                while(!top.Visited)
                {

                }
            }

            return preOrder;
        }
    }
}
