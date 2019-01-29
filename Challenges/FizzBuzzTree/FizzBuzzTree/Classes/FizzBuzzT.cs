using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace FizzBuzzTree.Classes
{
    class FizzBuzzT<T>
    {


        static BinaryTree<T> FizzBuzzTree(BinaryTree<T> bt)
        {
            BinaryTree<T> fizzTree = new BinaryTree<T>();

            try
            {
                if (bt.Root == null)
                {
                    return null;
                }
                bt.Add(bt.Root.Value);
                if (bt.Root.Left != null)
                {
                    FizzBuzzTree(bt.Root.Left, fizzTree);
                }

                if (bt.Root.Right != null)
                {
                    FizzBuzzTree(bt.Root.Right, fizzTree);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fizzTree;
        }

        static BinaryTree<T> FizzBuzzTree(Node<T> root, BinaryTree<T> list)
        {
            BinaryTree<T> fizzTree = new BinaryTree<T>();

            return fizzTree;
  
        }
    }
}
