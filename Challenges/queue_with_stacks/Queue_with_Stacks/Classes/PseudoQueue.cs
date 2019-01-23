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

        public PseudoQueue()
        {
            Primary = new Stack();
            Secondary = new Stack();
        }
        public void Enqueue1(int value)
        {

                Primary.Push(value);
        }

        /// <summary>
        /// extracts value using first-in first out approach
        /// </summary>
        /// <returns> value removed</returns>
        public Node Dequeue1()
        {
            if(Primary.Top == null)
            {
                return null;
            }
       
            else if(Primary.Top.Next == null)
            {
              Node newNode = Primary.Pop();
                return newNode;

            }
            else
            {
                while (Primary.Top.Next != null)
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
