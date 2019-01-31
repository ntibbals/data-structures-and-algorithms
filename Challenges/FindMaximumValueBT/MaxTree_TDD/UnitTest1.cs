using System;
using Xunit;
using Trees.Classes;
using FindMaximumValueBT;

namespace MaxTree_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaxOnLastBranch()
        {
            /// Test when maximum value is right most branch
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(200);
            testTree.Root.Right.Right = leftRightLeaf;

            Assert.Equal(200, Program.FindMaxValue(testTree));
        }

        [Fact]
        public void TestMaxOnMiddleBranch()
        {
            /// Test when maximum value is left most branch
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(130);
            testTree.Root.Left.Left = leftRightLeaf;

            Assert.Equal(130, Program.FindMaxValue(testTree));
        }
        [Fact]
        public void TestMaxOnRoot()
        {
            /// Test when maximum value is root
            BT testTree = new BT();
            testTree.Root = new Nodeb(200);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(130);
            testTree.Root.Left.Left = leftRightLeaf;

            Assert.Equal(200, Program.FindMaxValue(testTree));
        }
        [Fact]
        public void TestMaxOnEmptyTree()
        {
            /// Test when maximum value is root
            BT testTree = new BT();
             
            Assert.Throws<NullReferenceException>(() =>Program.FindMaxValue(testTree));
        }
    }
}
