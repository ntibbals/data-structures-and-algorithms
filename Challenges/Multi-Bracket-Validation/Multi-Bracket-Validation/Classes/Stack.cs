using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Bracket_Validation.Classes
{
    class Stack
    {
        /// <summary>
        /// Setting property of Top value in stack
        /// </summary>
        public Node Top { get; set; } = null;
        /// <summary>
        /// setting a counter variable for stack
        /// </summary>
        public int Size = 0;

        /// <summary>
        /// Instantiation of stack with a node
        /// </summary>
        /// <param name="node">node</param>
        public Stack(Node node)
        {

        }
        /// <summary>
        /// Instantiation of empty stack
        /// </summary>
        public Stack()
        {

        }
        /// <summary>
        /// Instantion of stack with an int value
        /// </summary>
        /// <param name="value">integer value</param>
        public Stack(int value)
        {

        }

        /// <summary>
        /// Push/adding a node/value to stack
        /// </summary>
        /// <param name="value">integer value</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            Size++;
        }

        /// <summary>
        /// Remove a node from the stack
        /// </summary>
        /// <returns>the temp node variable</returns>
        public Node Pop()
        {
            try
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                Size--;
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// Looks at top value in stack
        /// </summary>
        /// <returns>Top node</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
