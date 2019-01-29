using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BT
    {
        public Nodeb Root { get; set; }
        public List<int> BiTreeList { get; set; }

        public bool IsEmpty
        {
            get { return Root == null; }
        }

        public int Count { get; private set; }
        public BT()
        {
            Root = null;
        }

        public BT(Nodeb root)
        {
            Root = root;
            Count = 0;
        }

        public void CBT()
        {

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
            tree.Root.Right.Right= rightRightLeaf;

        }
        /// <summary>
        /// Pre order tree method
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>list of pre order nodes</returns>
        public static List<int> PeOrder(Nodeb root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return null;
            }
            list.Add(root.Value);
            if (root.Left != null)
            {
                PeOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PeOrder(root.Right, list);
            }
            return list;
        }
        /// <summary>
        /// Pre order tree method - overload
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="list">pre order list of nodes</param>
        /// <returns></returns>
        public static List<int> PeOrder(Nodeb root, List<int> list)
        {
            if (root == null)
            {
                return null;
            }

            list.Add(root.Value);
            if (root.Left != null)
            {
                PeOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PeOrder(root.Right, list);
            }
            return list;
        }

        /// <summary>
        /// Inorder Tree Method
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>inorder list of nodes</returns>
        public static List<int> IOrder(Nodeb root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                IOrder(root.Left, list);
            }

            list.Add(root.Value);

            if (root.Right != null)
            {
                IOrder(root.Right, list);
            }
            return list;
        }

        /// <summary>
        /// Inorder overload method
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="list">in order list of tree nodes</param>
        /// <returns></returns>
        public static List<int> IOrder(Nodeb root, List<int> list)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                IOrder(root.Left, list);
            }

            list.Add(root.Value);

            if (root.Right != null)
            {
                IOrder(root.Right, list);
            }
            return list;
        }

        /// <summary>
        /// Returns list of post ordered tree values
        /// </summary>
        /// <param name="root">root of tree</param>
        /// <returns>List of Nodes post order</returns>
        public static List<int> PstOrder(Nodeb root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PstOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PstOrder(root.Right, list);
            }

            list.Add(root.Value);
            return list;
        }
        /// <summary>
        /// Overloaded post order method
        /// </summary>
        /// <param name="root">root value</param>
        /// <param name="list">list created in intitial method</param>
        /// <returns>post order list of nodes</returns>
        public static List<int> PstOrder(Node<int> root, List<int> list)
        {

            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PstOrder(root.Left, list);
            }
            if (root.Right != null)
            {
                PstOrder(root.Right, list);
            }
            list.Add(root.Value);
            return list;
        }

        public Nodeb ReturnRoot()
        {
            return Root;
        }
    }
}
