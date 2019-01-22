using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {

        public Node Top { get; set; }

        public Stack(Node node)
        {

        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
    }
}
