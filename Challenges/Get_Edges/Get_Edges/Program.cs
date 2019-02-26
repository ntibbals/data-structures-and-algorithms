using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Get_Edges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GetEdge(DGraph graph, string[] cities)
        {

            NodeD city1 = new NodeD(cities[0]);
            NodeD city2 = new NodeD(cities[1]);


            if (!graph.AdjList.ContainsKey(city1) || !graph.AdjList.ContainsKey(city1))
            {
                return "False, $0";
            }
        }
    }
}
