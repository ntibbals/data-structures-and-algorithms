using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Get_Edges
{
    class Program
    {
        static void Main(string[] args)
        {

            DGraph graph = new DGraph();
            NodeD testV1 = new NodeD("Sea");
            NodeD testV2 = new NodeD("Chi");
            NodeD testV3 = new NodeD("SF");

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
            List<DEdge> edges = graph.GetNeighbors(testV1);
            foreach (DEdge item in edges)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GetEdge(graph, travel));
        }

        public static string GetEdge(DGraph graph, string[] cities)
        {

            NodeD city1 = new NodeD(cities[0]);
            NodeD city2 = new NodeD(cities[1]);
            if(graph.AdjList.ContainsKey(city1) && graph.AdjList.ContainsKey(city2))
            {


            List<DEdge> neighbors = graph.GetNeighbors(city1);
            foreach (var v in neighbors)
            {
                if (v.Start == city1 && v.End == city2 || v.Start == city1 && v.End == city2)
                {
                    return $"True, ${v.Weight}";
                }
            }
            neighbors = graph.GetNeighbors(city2);
            foreach (var v in neighbors)
            {
                if (v.Start == city1 && v.End == city2 || v.End== city1 && v.Start == city2)
                {
                    return $"True, ${v.Weight}";
                }
            }
            }

            return "False, $0 ";

        }
    }
}
