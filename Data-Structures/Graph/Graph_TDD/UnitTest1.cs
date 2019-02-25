using System;
using Xunit;
using Graph.Classes;
using System.Collections.Generic;

namespace Graph_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertexToGraph()
        {
            Graphs graph = new Graphs();
            Vertex testVertex = new Vertex("Test");

            graph.AddVertex(testVertex);

            List<Vertex> expected = new List<Vertex>();
            expected.Add(testVertex);

            Assert.Equal(expected, graph.GetVertex());
        }

        [Fact]
        public void AddEdgeToGraph()
        {
            Graphs graph = new Graphs();
            Vertex testV1 = new Vertex("Test1");
            Vertex testV2 = new Vertex("Test2");

            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            Edge testEdge = new Edge(testV1, testV2, 4);
            List<Edge> expected = new List<Edge>();
            expected.Add(testEdge);
   
            Assert.Equal(expected, graph.GetNeighbors(testV2));

        }
    }
}
