﻿using System;
using Trees.Classes;

namespace Binary_Tree_Balancer
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

            Nodeb leftRightLeaf = new Nodeb(200);
            tree.Root.Left.Right = leftRightLeaf;

            Nodeb rightLeftLeaf = new Nodeb(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Nodeb rightRightLeaf = new Nodeb(150);
            tree.Root.Right.Right = rightRightLeaf;
            Nodeb rightRightRightLeaf = new Nodeb(160);
            tree.Root.Right.Right.Right = rightRightRightLeaf;
            Nodeb rightRightRightRightLeaf = new Nodeb(160);
            tree.Root.Right.Right.Right.Right = rightRightRightRightLeaf;



            Console.WriteLine(IsBinaryTreeBalanced(tree.Root));
        }

        public static bool IsBinaryTreeBalanced(Nodeb root)
        {
            Nodeb temp = root;
            int HeightHelper (Nodeb helperHeight)
            {
                if (helperHeight == null)
                {
                    return 0;
                }
                return (1 + Math.Max(HeightHelper(helperHeight.Left), HeightHelper(helperHeight.Right))); ///Math.Max compares the given arguments and determines the greater, similiar to a conditional statement
            }

            bool ComparisonHelper(Nodeb helperComparison)
            {
                if (helperComparison == null)
                {
                    return true;
                }
                int difference = HeightHelper(helperComparison.Left) - HeightHelper(helperComparison.Right);

                if (Math.Abs(difference) > 1)
                {
                    return false;
                }
                else
                {
                    return ComparisonHelper(helperComparison.Left) && ComparisonHelper(helperComparison.Right);
                }
            }
            return ComparisonHelper(temp);
            
        }
    }
}
