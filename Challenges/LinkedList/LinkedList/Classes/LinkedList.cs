using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList.Classes
{
    public class LiList
    {
        /// <summary>
        /// First node in Linked List.
        /// </summary>
        public Node Head { get; set; } = null;
        /// <summary>
        /// Indicates current node in Linked List
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Inserts value into node at the stark of the linked list and then refernces the head to point to newly added node.
        /// </summary>
        /// <param name="value">value of added node</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }
        /// <summary>
        /// Validates if a node contains a value in Linked List.
        /// </summary>
        /// <param name="value">value to identify</param>
        /// <returns>true if value found</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if(Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if(Current.Value == value)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prints out Linked list node at each value
        /// </summary>
        public void Print()
        {
            Current = Head;
            Console.WriteLine("Linked List node values:");
            while (Current.Next != null)
            {
                Console.Write($" {Current.Value} ");
                Current = Current.Next;
            }
            if(Current.Next == null)
            {
                Console.WriteLine("NULL");
            }
        }
    }
}
