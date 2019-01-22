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

        public Node Pop()
        {

            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
