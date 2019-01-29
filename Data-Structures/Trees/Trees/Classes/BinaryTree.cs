using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    public class BinaryTree<T>
    {

        public Node<T> Root { get; set; }

        public bool IsEmpty
        {
            get { return Root == null;  }
        }

        public int Count { get; private set; }
        public BinaryTree()
        {

        }

        public BinaryTree(Node<T> root)
        {
            Root = root;
            Count = 0;
        }

        public void CreateBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(100);

            Node<int> leftChild = new Node<int>(5);
            tree.Root.Left = leftChild;

            Node<int> rightChild = new Node<int>(10);
            tree.Root.Right = rightChild;

            Node<int> leftLeftLeaf = new Node<int>(15);
            tree.Root.Left.Left = leftLeftLeaf;

            Node<int> leftRightLeaf = new Node<int>(20);
            tree.Root.Left.Right = leftRightLeaf;

            Node<int> rightLeftLeaf = new Node<int>(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Node<int> rightRightLeaf = new Node<int>(35);
            tree.Root.Right.Right = rightRightLeaf;

        }

        public void CreateObjectTree()
        {
            BinaryTree<object> tree = new BinaryTree<object>();
            tree.Root = new Node<object>(100);

            Node<object> leftChild = new Node<object>(5);
            tree.Root.Left = leftChild;

            Node<object> rightChild = new Node<object>(10);
            tree.Root.Right = rightChild;

            Node<object> leftLeftLeaf = new Node<object>(15);
            tree.Root.Left.Left = leftLeftLeaf;

            Node<object> leftRightLeaf = new Node<object>(20);
            tree.Root.Left.Right = leftRightLeaf;

            Node<object> rightLeftLeaf = new Node<object>(30);
            tree.Root.Right.Left = rightLeftLeaf;

            Node<object> rightRightLeaf = new Node<object>(35);
            tree.Root.Right.Right = rightRightLeaf;
        }

        /// <summary>
        /// Pre order tree method
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>list of pre order nodes</returns>
        public static List<T> PreOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            try
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
                    PreOrder(root.Right, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
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
                    PreOrder(root.Right, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
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
                    InOrder(root.Right, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
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
                    InOrder(root.Right, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
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
                    PostOrder(root.Right, list);
                }

                list.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            try
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
                    PostOrder(root.Right, list);
                }
                list.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }

        public Node<T> ReturnRoot()
        {
            return Root;
        }

    }
}
