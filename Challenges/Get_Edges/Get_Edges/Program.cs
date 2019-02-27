using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Get_Edges
{
    class Program
    {
        static void Main(string[] args)
        {

            Graphs graph = new Graphs();
            Node testV1 = new Node("Sea");
            Node testV2 = new Node("Chi");
            Node testV3 = new Node("SF");

            graph.AddNode(testV1);
            graph.AddNode(testV2);
            //graph.AddNode(testV3);
            graph.AddEdge(testV1, testV2, 150);
            //graph.AddEdge(testV2, testV3, 250);

            string[] travel = new string[] { "Sea" , "Chi" };
            //List<Node> nodes = graph.GetNodes();
            //foreach (var item in nodes)
            //{
            //    Console.WriteLine(item.Value.ToString());
            //}
            List<Edge> edges = graph.GetNeighbors(testV1);
            foreach (var item in edges)
            {
                Console.WriteLine(item.Weight.ToString());
            }
            Console.WriteLine(GetEdge(graph, travel));
        }

        public static string GetEdge(Graphs graph, string[] cities)
        {

            Node city1 = new Node(cities[0]);
            Node city2 = new Node(cities[1]);

            List<Edge> neighbors = graph.GetNeighbors(city1);
            foreach (var v in neighbors)
            {
                if (v.V1 == city1 && v.V2 == city2 || v.V2 == city1 && v.V1 == city2)
                {
                    return $"True, ${v.Weight}";
                }
            }
            neighbors = graph.GetNeighbors(city2);
            foreach (var v in neighbors)
            {
                if (v.V1 == city1 && v.V2 == city2 || v.V2 == city1 && v.V1 == city2)
                {
                    return $"True, ${v.Weight}";
                }
            }

            return "False, $0 ";

        }
    }
}
