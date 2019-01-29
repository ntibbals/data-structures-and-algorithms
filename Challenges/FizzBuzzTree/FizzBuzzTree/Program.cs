using System;
using System.Collections.Generic;
using Trees.Classes;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    class Program
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

        static BinaryTree<object> FizzBuzzTree(BinaryTree<object> bt)
        {
            Node<object> root = bt.Root;

            void Helper(Node<object> helperRoot)
            {
                if (helperRoot == null)
                {
                    return;
                }
                Helper(helperRoot.Left);
                Helper(helperRoot.Right);
                if (Convert.ToInt32(helperRoot.Value) % 15 == 0)
                {
                    helperRoot.Value = "FizzBuzz";
                }
                else if (Convert.ToInt32(helperRoot.Value) % 5 == 0)
                {
                    helperRoot.Value = "Buzz";
                }
                else if (Convert.ToInt32(helperRoot.Value) % 3 == 0)
                {
                    helperRoot.Value = "Fizz";

                }
            }

            Helper(root);
            return bt;

        }

    }
}
