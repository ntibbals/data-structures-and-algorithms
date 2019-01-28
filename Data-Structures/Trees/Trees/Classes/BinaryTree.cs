using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees.Classes
{
    class BinaryTree
    {

        public Node Root;

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

        public void  PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(Root.Value + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
                return;
            }
        }
    }
}
