using System;
using Trees.Classes;
using BreadFirstTraversal.Classes;

namespace BreadFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
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

        static void BreadthFirst (BT tree)
        {
            Queue bfQueue = new Queue();
            bfQueue.Enqueue(tree.Root.Value);

            while(bfQueue.Front != null)
            {
                Nodeb temp = bfQueue.Dequeue();
                Console.Write($" {temp.Value} =>");
                if(temp.Left != null)
                {
                    bfQueue.Enqueue(temp.Left.Value);
                }
                if(temp.Right != null)
                {
                    bfQueue.Enqueue(temp.Right.Value);
                }
            }

        }
    }
}
