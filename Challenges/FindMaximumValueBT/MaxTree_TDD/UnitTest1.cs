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
            BT testTree = new BT();
            testTree.Root = new Nodeb(100);
            Nodeb leftChild = new Nodeb(5);
            testTree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            testTree.Root.Right = rightChild;

            Nodeb leftRightLeaf = new Nodeb(200);
            testTree.Root.Left.Right = leftRightLeaf;

            Assert.Equal(200, Program.FindMaxValue(testTree));
        }
    }
}
