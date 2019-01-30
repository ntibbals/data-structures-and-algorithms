using System;
using Xunit;
using Trees.Classes;
using FizzBuzzTree;

namespace Fizz_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestForBuzz()
        {
            ///test for buzz
            BinaryTree<object> testTree = new BinaryTree<object>();
            testTree.Root = new Node<object>(5);
            testTree.Root.Left = new Node<object>(7);
            testTree.Root.Right = new Node<object>(13);
            testTree.Root.Left.Left = new Node<object>(15);
            testTree.Root.Right.Right = new Node<object>(25);
            Program.FizzBuzzTree(testTree);

            Assert.Equal("Buzz", Program.FizzBuzzTree(testTree).Root.Value);

        }
        [Fact]
        public void TestForFizz()
        {
            ///test for fizz
            BinaryTree<object> testTree = new BinaryTree<object>();
            testTree.Root = new Node<object>(5);
            testTree.Root.Left = new Node<object>(3);
            testTree.Root.Right = new Node<object>(15);
            testTree.Root.Left.Left = new Node<object>(15);
            testTree.Root.Right.Right = new Node<object>(25);
            Program.FizzBuzzTree(testTree);

            Assert.Equal("Fizz", Program.FizzBuzzTree(testTree).Root.Left.Value);

        }
        [Fact]
        public void TestForFizzBuzz()
        {
            ///test for fizzbuzz
            BinaryTree<object> testTree = new BinaryTree<object>();
            testTree.Root = new Node<object>(5);
            testTree.Root.Left = new Node<object>(3);
            testTree.Root.Right = new Node<object>(15);
            testTree.Root.Left.Left = new Node<object>(15);
            testTree.Root.Right.Right = new Node<object>(25);
            Program.FizzBuzzTree(testTree);

            Assert.Equal("FizzBuzz", Program.FizzBuzzTree(testTree).Root.Right.Value);

        }
    }
}
