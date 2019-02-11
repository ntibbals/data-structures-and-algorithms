using System;
using Trees.Classes;

namespace Height_of_Binary_Tree
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

            Nodeb leftLeftLeftLeaf = new Nodeb(17);
            tree.Root.Left.Left.Left = leftLeftLeftLeaf;

            Nodeb leftRightLeaf = new Nodeb(200);
            tree.Root.Left.Right = leftRightLeaf;

            Nodeb rightLeftLeaf = new Nodeb(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Nodeb rightRightLeaf = new Nodeb(150);
            tree.Root.Right.Right = rightRightLeaf;
            Nodeb rightRightRightLeaf = new Nodeb(160);
            tree.Root.Right.Right.Right = rightRightRightLeaf;

            Nodeb rightRightRightRightLeaf = new Nodeb(170);
            tree.Root.Right.Right.Right.Right = rightRightRightRightLeaf;

            Console.WriteLine(CalculateBinaryTreeHeight(tree));
            Console.WriteLine(FindLevel(tree));
            Console.ReadLine();

        }

        /// <summary>
        /// Find height recursively
        /// </summary>
        /// <param name="tree">binary tree</param>
        /// <returns>height of tree</returns>
        public static int CalculateBinaryTreeHeight(BT tree)
        {
            if (tree.Root == null)
            {
                throw null;
            }

            Nodeb root = tree.Root;
            int currentCountLeft = 0;
            int currentCountRight = 0;
            void Helper(Nodeb temp)
            {
                if (temp == null)
                {
                    return;
                }
                Helper(temp.Left);
                Helper(temp.Right);

                if( temp.Left != null )
                {
                    currentCountLeft++;
                }

                if (temp.Right != null)
                {
                    currentCountRight++;
                }
            }
            Helper(root);

            if (currentCountLeft > currentCountRight)
            {
                return currentCountLeft;
            }
            else
            { 
                return currentCountRight;
            }
        }

        /// <summary>
        /// Find levels of tree
        /// </summary>
        /// <param name="tree">binary tree</param>
        /// <returns>level within a tree</returns>
        public static int FindLevel(BT tree)
        {
            if (tree.Root == null)
            {
                throw null;
            }

            Nodeb root = tree.Root;
            int currentCountLeft = 1;
            int currentCountRight = 1;
            void Helper(Nodeb temp)
            {
                if (temp == null)
                {
                    return;
                }
                Helper(temp.Left);
                Helper(temp.Right);
                if (temp.Left != null)
                {
                    currentCountLeft++;
                }
                if (temp.Right != null)
                {
                    currentCountRight++;
                }
            }
            Helper(root);

            if (currentCountLeft > currentCountRight)
            {
                return currentCountLeft;
            }
            else
            {
                return currentCountRight;
            }
        }
    }
}
