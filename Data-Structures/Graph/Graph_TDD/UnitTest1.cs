using System;
using Xunit;
using Graph.Classes;
using System.Collections.Generic;

namespace Graph_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void AddNodeToGraph()
        {

            ///Test that vertex can be added to graph
            Graphs graph = new Graphs();
            Node testVertex = new Node("Test");

            graph.AddVertex(testVertex);

            List<Node> expected = new List<Node>();
            expected.Add(testVertex);

            Assert.Equal(expected, graph.GetNodes());
        }

        [Fact]
        public void AddEdgeToGraph()
        {
            ///Test that edge can be successfully added
            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");

            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            Edge testEdge = new Edge(testV1, testV2, 4);
            List<Node> expected = new List<Node>();
            expected.Add(testEdge.V1);
            List<Edge> graphEdges = graph.GetNeighbors(testV2);
            List<Node> actual = new List<Node>();
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
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");

            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            List<Node> expected = new List<Node>();
            expected.Add(testV1);
            expected.Add(testV2);
            Assert.Equal(expected, graph.GetNodes());

        }

        [Fact]
        public void RetreiveAllNodeNeighbors()
        {
            ///Test that all node neighbors can be retreived
            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");
            Node testV3 = new Node("Test3");
            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            graph.AddEdge(testV2, testV3, 8);
            Edge testEdge = new Edge(testV1, testV2, 4);
            Edge testEdge2 = new Edge(testV2, testV3, 8);
            List<Node> expected = new List<Node>();
            expected.Add(testEdge.V1);
            expected.Add(testEdge2.V1);
            List<Edge> graphEdges = graph.GetNeighbors(testV2);
            List<Node> actual = new List<Node>();
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
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");
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
        [Fact]
        public void RetreiveGraphSize()
        {
            ///Test graph size returns accordingly
            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");
            Node testV2 = new Node("Test2");
            Node testV3 = new Node("Test3");
            graph.AddVertex(testV1);
            graph.AddVertex(testV2);
            graph.AddEdge(testV1, testV2, 4);
            graph.AddEdge(testV2, testV3, 8);

            int expected = 2;
            Assert.Equal(expected, graph.GetSize());

        }
        [Fact]
        public void RetreiveSingleNodeandEdge()
        {
            ///Test that a single vertex and edge can be found
            Graphs graph = new Graphs();
            Node testV1 = new Node("Test1");

            graph.AddVertex(testV1);
            graph.AddEdge(testV1, testV1, 4);
            Edge testEdge = new Edge(testV1, testV1, 4);
            List<Node> expected = new List<Node>();
            expected.Add(testEdge.V1);
            List<Edge> graphEdges = graph.GetNeighbors(testV1);
            List<Node> actual = new List<Node>();
            foreach (Edge e in graphEdges)
            {
                actual.Add(e.V1);
            }
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestEmptyGraph()
        {
            Graphs graph = new Graphs();
            Assert.Null(graph.GetNodes());
        }
    }
}
