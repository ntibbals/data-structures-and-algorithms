using System;
using Trees.Classes;
using BreadFirstTraversal.Classes;
using System.Collections.Generic;

namespace BreadFirstTraversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BT tree = new BT();
            tree.Root = new Nodeb(100);

            Nodeb leftChild = new Nodeb(5);
            tree.Root.Left = leftChild;

            Nodeb rightChild = new Nodeb(10);
            tree.Root.Right = rightChild;

            Nodeb leftLeftLeaf = new Nodeb(15);
            tree.Root.Left.Left = leftLeftLeaf;

            Nodeb leftRightLeaf = new Nodeb(20);
            tree.Root.Left.Right = leftRightLeaf;

            Nodeb rightLeftLeaf = new Nodeb(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Nodeb rightRightLeaf = new Nodeb(35);
            tree.Root.Right.Right = rightRightLeaf;

            BreadthFirst(tree);
        }

        public static List<int> BreadthFirst (BT tree)
        {
            List<int> list = new List<int>();
            Queue bfQueue = new Queue();
            bfQueue.Enqueue(tree.Root);
            if (tree.Root == null)
            {
                return null;
            }
            while(bfQueue.Front != null)
            {
                Nodeb temp = bfQueue.Dequeue();
                list.Add(temp.Value);
                Console.Write($" {temp.Value} =>");
                if(temp.Left != null)
                {
                    bfQueue.Enqueue(temp.Left);
                }
                if(temp.Right != null)
                {
                    bfQueue.Enqueue(temp.Right);
                }
            }
            return list;

        }
    }
}
