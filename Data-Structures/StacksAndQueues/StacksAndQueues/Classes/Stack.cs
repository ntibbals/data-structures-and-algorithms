using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {

        public Node Top { get; set; } = null;
        public int Size = 0;

        public Stack()
        {

        }
        public Stack(Node node)
        {

        }
        public Stack(int value)
        {

        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            Size++;
        }

        public Node Pop()
        {

            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            Size--;
            return temp;
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
