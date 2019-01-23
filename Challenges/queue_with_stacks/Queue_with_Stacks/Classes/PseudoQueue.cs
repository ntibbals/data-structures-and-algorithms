using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace Queue_with_Stacks.Classes
{
    class PseudoQueue
    {
      public Stack Primary { get; set; }
      public Stack Secondary { get; set; }

        public PseudoQueue()
        {
            Primary = Primary;
            Secondary = Secondary;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            Secondary.Push(value);
        }

        public Node Dequeue()
        {
            if(Primary.Top == null)
            {
                return Secondary.Pop();
            }
            else
            {
                while(Primary.Top != null)
                {
                    Secondary.Push(Primary.Pop());
                }
            }
            return Secondary.Pop();
        }
    }
}
