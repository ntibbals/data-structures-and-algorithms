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


        public static List<Node> PreOrder(Node root, List<Node> array = null)
        {
            if( root == null)
            {
                return null;
            }
            if (array == null)
            {
                array = new List<Node>();
                array.Add(root);
            }
            if (root.Left != null)
            {
                PreOrder(root.Left, array);
            }
            if (root.Right != null)
            {
                PreOrder(root.Right, array);
            }
            return array;
        }

        public static List<Node> InOrder(Node root, List<Node> array = null)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                InOrder(root.Left, array);
            }
            if (array == null)
            {
                array = new List<Node>();
                array.Add(root);
            }
            if (root.Right != null)
            {
                InOrder(root.Right, array);
            }
            return array;
        }

        public static List<Node> PostOrder(Node root, List<Node> array = null)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Left != null)
            {
                PostOrder(root.Left, array);
            }
 
            if (root.Right != null)
            {
                InOrder(root.Right, array);
            }
            if (array == null)
            {
                array = new List<Node>();
                array.Add(root);
            }
            return array;

        }

        public Node ReturnRoot()
        {
            return Root;
        }

    }
}
