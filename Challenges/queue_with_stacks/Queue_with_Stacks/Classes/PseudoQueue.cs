using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace Queue_with_Stacks.Classes
{
    public class PseudoQueue
    {
      public Stack Primary { get; set; }
      public Stack Secondary { get; set; }

        public PseudoQueue(Stack stack)
        {
            Primary = stack;
            Secondary = stack;
        }

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
                while(Primary.Top != null)
                {
                    Node temp = Primary.Top;
                    Primary.Top = temp.Next;
                    temp.Next = null;
                    Secondary.Push(Primary.Pop().Value);
                    Secondary.Push(Primary.Pop().Value);
                }
            }
            return Secondary.Pop();
        }
    }
}
