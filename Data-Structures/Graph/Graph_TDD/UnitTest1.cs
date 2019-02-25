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
    }
}
