using System;
using Xunit;
using Hashtables.Classes;
using Trees.Classes;
using Tree_Intersection;
using System.Collections.Generic;

namespace tree_intersection_tdd
{
    public class UnitTest1
    {
        [Fact]
        public void FindTwoIntersections()
        {
            /// Find two pairs between both trees
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(20);
            testTree.Root.Left.Right = leftRightLeaf;

            BT testTree2 = new BT();
            testTree2.Root = new Nodeb(99);
            Nodeb leftChild2 = new Nodeb(5);
            testTree2.Root.Left = leftChild2;

            Nodeb rightChild2 = new Nodeb(15);
            testTree2.Root.Right = rightChild2;

            Nodeb leftRightLeaf2 = new Nodeb(20);
            testTree2.Root.Left.Right = leftRightLeaf2;
            List<int> expected = new List<int> { 20, 5 };
            Assert.Equal(expected, Program.TreeIntersection(testTree, testTree2));

        }

        [Fact]
        public void FindRootIntersection()
        {
            /// Find root pairs
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(2);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(21);
            testTree.Root.Left.Right = leftRightLeaf;

            BT testTree2 = new BT();
            testTree2.Root = new Nodeb(100);
            Nodeb leftChild2 = new Nodeb(5);
            testTree2.Root.Left = leftChild2;

            Nodeb rightChild2 = new Nodeb(15);
            testTree2.Root.Right = rightChild2;

            Nodeb leftRightLeaf2 = new Nodeb(20);
            testTree2.Root.Left.Right = leftRightLeaf2;
            List<int> expected = new List<int> { 100 };
            Assert.Equal(expected, Program.TreeIntersection(testTree, testTree2));

        }
        [Fact]
        public void FindEmptyTreeIntersection()
        {
            /// Find intersection on empty list
            BT testTree = new BT();

            BT testTree2 = new BT();

            List<int> expected = new List<int> { };
            Assert.Equal(expected, Program.TreeIntersection(testTree, testTree2));

        }
        [Fact]
        public void FindNoIntersection()
        {
            /// Look for intersection where none exist
            BT testTree = new BT();
            testTree.Root = new Nodeb(99);
            Nodeb leftChild = new Nodeb(2);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(21);
            testTree.Root.Left.Right = leftRightLeaf;

            BT testTree2 = new BT();
            testTree2.Root = new Nodeb(100);
            Nodeb leftChild2 = new Nodeb(5);
            testTree2.Root.Left = leftChild2;

            Nodeb rightChild2 = new Nodeb(15);
            testTree2.Root.Right = rightChild2;

            Nodeb leftRightLeaf2 = new Nodeb(20);
            testTree2.Root.Left.Right = leftRightLeaf2;
            List<int> expected = new List<int> { };
            Assert.Equal(expected, Program.TreeIntersection(testTree, testTree2));

        }
    }
}
