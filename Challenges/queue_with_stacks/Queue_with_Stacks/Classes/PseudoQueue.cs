using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace Queue_with_Stacks.Classes
{
    public class PseudoQueue
    {
        public Stack Primary = new Stack();
        public Stack Secondary = new Stack();


        public void Enqueue1(int value)
        {

                Primary.Push(value);
        }

        public Node Dequeue1()
        {
            if(Primary.Top == null)
            {
                return null;
            }
            else
            {
                while (Primary.Top != null)
                {
                    Node newNode = Primary.Pop();
                    Secondary.Push(newNode.Value);
                }

                    Node temp = Secondary.Top;
                   while (Secondary.Top != null)
                {
                    Primary.Top = temp.Next;
                    temp.Next = null;
                    Node newNode = Secondary.Pop();
                    Primary.Push(newNode.Value);
                }
            }
            return Secondary.Pop();
        }
    }
}
