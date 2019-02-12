using Binary_Tree_Balancer;
using System;
using Trees.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestBalancedTree()
        {
            /// Test balanced tree
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;


            Assert.True(Program.IsBinaryTreeBalanced(testTree.Root));
        }

        [Fact]
        public void TestUnbalancedTree()
        {
            /// Test unbalanced tree
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;
            Nodeb rightRightChild = new Nodeb(10);
            testTree.Root.Right.Right = rightRightChild;
            Nodeb rightRightRightChild = new Nodeb(10);
            testTree.Root.Right.Right.Right = rightRightRightChild;

            Assert.False(Program.IsBinaryTreeBalanced(testTree.Root));
        }
        [Fact]
        public void TestEmptyTree()
        {
            /// Test empty tree
            BT testTree = new BT();
            Assert.Throws<NullReferenceException>(() => Program.IsBinaryTreeBalanced(testTree.Root));
        }

    }
}
