using System;
using Xunit;
using Trees.Classes;
using BreadFirstTraversal.Classes;

namespace Breadth_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void BreadthFirstBeginsatRoot()
        {
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftLeftLeaf = new Nodeb(15);
            testTree.Root.Left.Left = leftLeftLeaf;

            Nodeb leftRightLeaf = new Nodeb(20);
            testTree.Root.Left.Right = leftRightLeaf;

            Nodeb rightLeftLeaf = new Nodeb(30);
            testTree.Root.Right.Left = rightLeftLeaf;

            Nodeb rightRightLeaf = new Nodeb(35);
            testTree.Root.Right.Right = rightRightLeaf;

        }
    }
}
