using System;
using Xunit;
using Trees.Classes;
using Trees;
using System.Collections.Generic;

namespace Trees_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateRootBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Assert.Equal(100, testTree.Root.Value);
        }

        [Fact]
        public void InstantiateLeftBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            Assert.Equal(10, testTree.Root.Right.Value);
        }

        [Fact]
        public void PreOrderOddBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(20);
            testTree.Root.Left.Right = leftRightLeaf;
            BT.PeOrder(testTree.Root);
            List<int> expected = new List<int> { 100, 5, 20, 10 };
            Assert.Equal(expected, BT.PeOrder(testTree.Root));
        }
        [Fact]
        public void PreOrderEvenBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            BT.PeOrder(testTree.Root);
            List<int> expected = new List<int> { 100, 5, 10 };
            Assert.Equal(expected, BT.PeOrder(testTree.Root));
        }

        [Fact]
        public void PreOrderNull()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            BT.PeOrder(testTree.Root);
            List<int> expected = new List<int> { 100, 5, 10 };
            Assert.Equal(expected, BT.PeOrder(testTree.Root));
        }

        [Fact]
        public void InOrderBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            List<int> expected = new List<int> { 5, 100, 10 };
            Assert.Equal(expected, BT.IOrder(testTree.Root));
        }

        [Fact]
        public void PostOrderBT()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            List<int> expected = new List<int> { 5, 10, 100 };
            Assert.Equal(expected, BT.PstOrder(testTree.Root));
        }
    }
}
