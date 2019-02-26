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

            graph.AddNode(testV1);
            graph.AddNode(testV2);
            graph.AddEdge(testV1, testV2, 150);
            string[] travel = new string[] { "Sea, Chi" };
            Console.WriteLine(GetEdge(graph, travel));
        }

        public static string GetEdge(Graphs graph, string[] cities)
        {

            Node city1 = new Node(cities[0]);
            Node city2 = new Node(cities[1]);

            List<Edge> neighbors1 = graph.GetNeighbors(city1);
            foreach (var v in city1.Graph.Edges)
            {
                if(v.V1 == city1 && v.V2 == city2 || v.V2 == city1 && v.V1 == city2)
                {
                    return $"True, ${v.Weight}";
                }
            }
            neighbors1 = graph.GetNeighbors(city2);
            foreach (var v in city2.Graph.Edges)
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
