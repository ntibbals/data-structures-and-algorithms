using System;
using Xunit;
using Trees.Classes;
using FizzBuzzTree;

namespace Fizz_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanItTraversewithNonNumeric()
        {
            BinaryTree<object> testTree = new BinaryTree<object>();
            testTree.Root = new Node<object>(5);
            testTree.Root.Left = new Node<object>(7);
            testTree.Root.Right = new Node<object>("Tree");
            testTree.Root.Left.Left = new Node<object>(15);
            testTree.Root.Right.Right = new Node<object>(25);
            Program.FizzBuzzTree(testTree);

            Assert.Equal("Fizz", Program.FizzBuzzTree(testTree).Root.Value);

        }
    }
}
