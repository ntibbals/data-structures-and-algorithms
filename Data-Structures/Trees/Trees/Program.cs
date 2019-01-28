using System;
using Trees.Classes;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree tree = new BinaryTree();
            tree.Insert(3);
            tree.Insert(10);
            tree.Insert(20);
            Console.WriteLine(tree.Root.Value);
            tree.PostOrder(tree.ReturnRoot());
            tree.InOrder(tree.ReturnRoot());
            tree.PreOrder(tree.ReturnRoot());
        }
    }
}

