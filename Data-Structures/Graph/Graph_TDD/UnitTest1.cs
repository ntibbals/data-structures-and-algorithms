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

            ///Test that vertex can be added to graph
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
            ///Test that edge can be successfully added
            Graphs graph = new Graphs();
            Vertex testV1 = new Vertex("Test1");
            Vertex testV2 = new Vertex("Test2");

            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            Edge testEdge = new Edge(testV1, testV2, 4);
            List<Vertex> expected = new List<Vertex>();
            expected.Add(testEdge.V1);
            List<Edge> graphEdges = graph.GetNeighbors(testV2);
            List<Vertex> actual = new List<Vertex>();
            foreach (Edge e in graphEdges)
            {
                actual.Add(e.V1);
            }
            
   
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RetreiveVertices()
        {
            ///test that method will return all vertices/Vertex
            Graphs graph = new Graphs();
            Vertex testV1 = new Vertex("Test1");
            Vertex testV2 = new Vertex("Test2");

            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            List<Vertex> expected = new List<Vertex>();
            expected.Add(testV1);
            expected.Add(testV2);
            Assert.Equal(expected, graph.GetVertex());

        }

        [Fact]
        public void RetreiveAllNodeNeighbors()
        {
            ///Test that all node neighbors can be retreived
            Graphs graph = new Graphs();
            Vertex testV1 = new Vertex("Test1");
            Vertex testV2 = new Vertex("Test2");
            Vertex testV3 = new Vertex("Test3");
            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            graph.AddEdge(testV2, testV3, 8);
            Edge testEdge = new Edge(testV1, testV2, 4);
            Edge testEdge2 = new Edge(testV2, testV3, 8);
            List<Vertex> expected = new List<Vertex>();
            expected.Add(testEdge.V1);
            expected.Add(testEdge2.V1);
            List<Edge> graphEdges = graph.GetNeighbors(testV2);
            List<Vertex> actual = new List<Vertex>();
            foreach (Edge e in graphEdges)
            {
                actual.Add(e.V1);
            }

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RetreiveWeightNeighbors()
        {
            ///Test that all weight can be retrieved from neighbors
            Graphs graph = new Graphs();
            Vertex testV1 = new Vertex("Test1");
            Vertex testV2 = new Vertex("Test2");
            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            Edge testEdge = new Edge(testV1, testV2, 4);
            List<Edge> graphEdges = graph.GetNeighbors(testV2);
            int weight = 0;
            foreach (Edge e in graphEdges)
            {
                weight = e.Weight;
            }

            Assert.Equal(testEdge.Weight, weight);

        }
    }
}
