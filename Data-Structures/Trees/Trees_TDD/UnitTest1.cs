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
            /// testing that I can instantiate a root
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Assert.Equal(100, testTree.Root.Value);
        }

        [Fact]
        public void InstantiateLeftBT()
        {
            /// testing that it is instantiating Left or right accordingly
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
            /// Testing pre order traversal on odd number of branches
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
            /// testing pre order on even number of branches
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
            /// Testing pre order on empty tree
            BT testTree = new BT();
            Assert.Null(BT.PeOrder(testTree.Root));
        }

        [Fact]
        public void InOrderEvenBT()
        {
            /// Testing In order traversal on even amoutn of branches
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
        public void InOrderOddBT()
        {
            /// Testing in order traversal on odd number of branches
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(20);
            testTree.Root.Left.Right = leftRightLeaf;
            List<int> expected = new List<int> { 5, 20, 100, 10 };
            Assert.Equal(expected, BT.IOrder(testTree.Root));
        }

        [Fact]
        public void InOrderNull()
        {
            ///Testing In order on empty tree
            BT testTree = new BT();
            Assert.Null(BT.IOrder(testTree.Root));
        }
        [Fact]
        public void PostOrderEvenBT()
        {
            /// Testing post order on even amoutn of branches in tree
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            List<int> expected = new List<int> { 5, 10, 100 };
            Assert.Equal(expected, BT.PstOrder(testTree.Root));
        }

        [Fact]
        public void PostOrderOddBT()
        {
            /// Testing Post order traversal on odd number of branches
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(20);
            testTree.Root.Left.Right = leftRightLeaf;
            List<int> expected = new List<int> { 20, 5, 10, 100 };
            Assert.Equal(expected, BT.PstOrder(testTree.Root));
        }
        [Fact]
        public void PostOrderNull()
        {
            /// testing post order on empty tree
            BT testTree = new BT();
            Assert.Null(BT.PstOrder(testTree.Root));
        }
    }
}
