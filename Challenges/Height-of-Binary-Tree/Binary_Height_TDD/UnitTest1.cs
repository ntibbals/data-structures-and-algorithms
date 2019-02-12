using Height_of_Binary_Tree;
using System;
using Trees.Classes;
using Xunit;

namespace Binary_Height_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestHeightofOne()
        {
            /// Test height of two
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;


            Assert.Equal(1, Program.CalculateBinaryTreeHeight(testTree));
        }

        [Fact]
        public void TestHeightofThree()
        {
            /// Test height of three
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftLeftChild = new Nodeb(15);
            testTree.Root.Left.Left = leftLeftChild;

            Nodeb leftRightChild = new Nodeb(20);
            testTree.Root.Left.Right = leftRightChild;

            Nodeb rightLeftChild = new Nodeb(25);
            testTree.Root.Right.Left = rightLeftChild;

            Nodeb rightRightChild = new Nodeb(30);
            testTree.Root.Right.Right = rightRightChild;

            Assert.Equal(3, Program.CalculateBinaryTreeHeight(testTree));
        }
   
        [Fact]
        public void TestSingleRoot()
        {
            //test height of one
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);


            Assert.Equal(0, Program.CalculateBinaryTreeHeight(testTree));
        }

        [Fact]
        public void TestHeightofNull()
        {
            /// Test empty tree
            BT testTree = new BT();
            Assert.Throws<NullReferenceException>(() => Program.CalculateBinaryTreeHeight(testTree));
        }

        [Fact]
        public void TestNonPerfectTree()
        {
            /// Test non perfect tree
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb rightRightChild = new Nodeb(15);
            testTree.Root.Right.Right = rightRightChild;

            Assert.Equal(2, Program.CalculateBinaryTreeHeight(testTree));
        }
        [Fact]
        public void TestLevelofOne()
        {
            /// Test height of two
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);


            Assert.Equal(1, Program.FindLevel(testTree));
        }

        [Fact]
        public void TestLevelofThree()
        {
            /// Test height of three
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftLeftChild = new Nodeb(15);
            testTree.Root.Left.Left = leftLeftChild;

            Nodeb leftRightChild = new Nodeb(20);
            testTree.Root.Left.Right = leftRightChild;


            Assert.Equal(3, Program.FindLevel(testTree));
        }


        [Fact]
        public void TestLevelofNull()
        {
            /// Test empty tree
            BT testTree = new BT();
            Assert.Throws<NullReferenceException>(() => Program.FindLevel(testTree));
        }

        [Fact]
        public void TestNonPerfectLevelTree()
        {
            /// Test non perfect tree
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb rightRightChild = new Nodeb(15);
            testTree.Root.Right.Right = rightRightChild;

            Assert.Equal(3, Program.FindLevel(testTree));
        }
    }
}
