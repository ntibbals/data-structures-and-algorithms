using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    class BinaryTree
    {

        public Node Root { get; set; }

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
        public BinaryTree(Node root)
        {
            Root = root;
            Count = 0;
        }


        public static List<Node> PreOrder(Node root)
        {
            List<Node> list = new List<Node>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PreOrder(root.Left, list);
            }

            list.Add(root);

            if (root.Right != null)
            {
                PreOrder(root.Right, list);
            }
            return list;
        }
        public static List<Node> PreOrder(Node root, List<Node> list)
        {
            List<Node> list2 = new List<Node>();
            if (root == null)
            {
                return null;
            }

            list2.Add(root);
            if (root.Left != null)
            {
                PreOrder(root.Left, list2);
            }


            if (root.Right != null)
            {
                PreOrder(root.Left, list2);
            }
            return list2;
        }
        public static List<int> InOrder(Node root)
        {
            List<int> list = new List<int>();
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
        public static List<int> InOrder(Node root, List<int> list)
        {
            List<int> list2 = new List<int>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                InOrder(root.Left, list2);
            }

                list2.Add(root.Value);
        
            if (root.Right != null)
            {
                InOrder(root.Left, list2);
            }
            return list2;
        }

        public static List<int> PostOrder(Node root)
        {
            List<int> list = new List<int>();
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
        public static List<int> PostOrder(Node root, List<int> list)
        {
            List<int> list2 = new List<int>();
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PostOrder(root.Left, list2);
            }


            if (root.Right != null)
            {
                PostOrder(root.Left, list2);
            }
            list2.Add(root.Value);
            return list2;
        }

        public Node ReturnRoot()
        {
            return Root;
        }

    }
}
