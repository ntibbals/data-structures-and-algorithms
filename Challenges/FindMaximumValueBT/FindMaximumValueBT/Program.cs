using System;
using Trees.Classes;

namespace FindMaximumValueBT
{
    public class Program
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

            Nodeb leftRightLeaf = new Nodeb(200);
            tree.Root.Left.Right = leftRightLeaf;

            Nodeb rightLeftLeaf = new Nodeb(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Nodeb rightRightLeaf = new Nodeb(150);
            tree.Root.Right.Right = rightRightLeaf;

            Console.WriteLine(FindMaxValue(tree));
            Console.ReadLine();
        }
        /// <summary>
        /// Initial method that takes in a binary tree and determines the maximum value
        /// </summary>
        /// <param name="tree">binary tree</param>
        /// <returns>maximum value</returns>
        public static int FindMaxValue(BT tree)
        {

            if( tree.Root == null)
            {
                throw null;
            }
            int temp = FindMaxValue(tree.Root);
            

            return temp;
        }

        /// <summary>
        /// Recursive method to do the traversal and logic to determine max value
        /// </summary>
        /// <param name="root">root of binary tree</param>
        /// <returns>Return maximum value to initial method</returns>
        public static int FindMaxValue(Nodeb root)
        {
            int temp = root.Value;
            int leftMax = 0;
            int rightMax = 0;

            if (root == null)
            {
                throw null;
            }

            if(root.Left != null)
            {
                leftMax = FindMaxValue(root.Left);
            }

            if(root.Right != null)
            {
                rightMax = FindMaxValue(root.Right);
            }

            if(temp< leftMax)
            {
                temp = leftMax;
            }

            if(temp < rightMax)
            {
                temp = rightMax;
            }
            return temp;
        }
    }
}
