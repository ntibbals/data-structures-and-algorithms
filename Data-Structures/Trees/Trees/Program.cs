using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
        public void CreateMainBinaryTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Node<int> root = new Node<int>(100);
            Node<int> leftChild = new Node<int>(5);
            root.Left = leftChild;

            Node<int> rightChild = new Node<int>(10);
            root.Right = rightChild;

            Node<int> leftLeftLeaf = new Node<int>(15);
            leftChild.Left = leftLeftLeaf;

            Node<int> leftRightLeaf = new Node<int>(20);
            leftChild.Right = leftRightLeaf;

            Node<int> rightLeftLeaf = new Node<int>(30);
            rightChild.Left = rightLeftLeaf;

            Node<int> rightRightLeaf = new Node<int>(35);
            rightChild.Right = rightRightLeaf;

        }

    }
}

