﻿using System;
using Trees.Classes;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateBinaryTree();
            Console.ReadLine();

        }

        public static void CreateBinaryTree()
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node(100);

            Node leftChild = new Node(5);
            root.Left = leftChild;

            Node rightChild = new Node(10);
            root.Right = rightChild;

            Node leftLeftLeaf = new Node(15);
            leftChild.Left = leftLeftLeaf;

            Node leftRightLeaf = new Node(20);
            leftChild.Right = leftRightLeaf;

            Node rightLeftLeaf = new Node(30);
            rightChild.Left = rightLeftLeaf;

            Node rightRightLeaf = new Node(35);
            rightChild.Right = rightRightLeaf;

            var Tree = BinaryTree.PreOrder(root);

            foreach (Node item in Tree)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Value);
                }

            }
            //var Tree2 = BinaryTree.InOrder(root);

            //foreach (Node item in Tree2)
            //{
            //    if (item != null)
            //    {
            //        Console.WriteLine(item.Value);
            //    }

            //}
            //var Tree3 = BinaryTree.PostOrder(root);

            //foreach (Node item in Tree)
            //{
            //    if (item != null)
            //    {
            //        Console.WriteLine(item.Value);
            //    }

            //}




        }
    }
}

