using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    class BinaryTree<T>
    {

        public Node<T> Root { get; set; }

        public bool IsEmpty
        {
            get { return Root == null;  }
        }

        public int Count { get; private set; }

        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }
        public BinaryTree(Node<T> root)
        {
            Root = root;
            Count = 0;
        }

        /// <summary>
        /// Pre order tree method
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>list of pre order nodes</returns>
        public static List<T> PreOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            if (root == null)
            {
                return null;
            }
            list.Add(root.Value);
            if (root.Left != null)
            {
                PreOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PreOrder(root.Right, list);
            }
            return list;
        }
        /// <summary>
        /// Pre order tree method - overload
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="list">pre order list of nodes</param>
        /// <returns></returns>
        public static List<T> PreOrder(Node<T> root, List<T> list)
        {
            if (root == null)
            {
                return null;
            }

            list.Add(root.Value);
            if (root.Left != null)
            {
                PreOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PreOrder(root.Left, list);
            }
            return list;
        }

        /// <summary>
        /// Inorder Tree Method
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>inorder list of nodes</returns>
        public static List<T> InOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                InOrder(root.Left, list);
            }

                list.Add(root.Value);

            if (root.Right != null)
            {
                InOrder(root.Right, list);
            }
            return list;
        }

        /// <summary>
        /// Inorder overload method
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="list">in order list of tree nodes</param>
        /// <returns></returns>
        public static List<T> InOrder(Node<T> root, List<T> list)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                InOrder(root.Left, list);
            }

                list.Add(root.Value);
        
            if (root.Right != null)
            {
                InOrder(root.Left, list);
            }
            return list;
        }

        /// <summary>
        /// Returns list of post ordered tree values
        /// </summary>
        /// <param name="root">root of tree</param>
        /// <returns>List of Nodes post order</returns>
        public static List<T> PostOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PostOrder(root.Left, list);
            }

            if (root.Right != null)
            {
                PostOrder(root.Right, list);
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
        public static List<T> PostOrder(Node<T> root, List<T> list)
        {

            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PostOrder(root.Left, list);
            }


            if (root.Right != null)
            {
                PostOrder(root.Left, list);
            }
            list.Add(root.Value);
            return list;
        }

        public Node<T> ReturnRoot()
        {
            return Root;
        }

    }
}
