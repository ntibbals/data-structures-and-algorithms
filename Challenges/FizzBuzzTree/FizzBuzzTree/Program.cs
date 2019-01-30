using System;
using System.Collections.Generic;
using Trees.Classes;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree<object> fTree = new BinaryTree<object>();
            fTree.Root = new Node<object>(5);
            fTree.Root.Left = new Node<object>(7);
            fTree.Root.Right = new Node<object>(3);
            fTree.Root.Left.Left = new Node<object>(15);
            fTree.Root.Right.Right = new Node<object>(25);
            FizzBuzzTree(fTree);

        }

        public static BinaryTree<object> FizzBuzzTree(BinaryTree<object> bt)
        {
            Node<object> root = bt.Root; ///holder for tree root

            void Helper(Node<object> helperRoot) /// helper method to run recursion, not alter root
            {
                if (helperRoot == null) /// break point for recursion
                {
                    return;
                }
                Helper(helperRoot.Left); /// looks left
                Helper(helperRoot.Right);/// checks right
                if (Int32.TryParse(helperRoot.Value.ToString(), out int value))
                    {
                    if (value % 15 == 0)
                    {
                        helperRoot.Value = "FizzBuzz";
                    }
                    else if (value % 5 == 0)
                    {
                        helperRoot.Value = "Buzz";
                    }
                    else if (value % 3 == 0)
                    {
                        helperRoot.Value = "Fizz";

                    }
                }
            }

            Helper(root); ///begins the recursion
            return bt;

        }

    }
}
