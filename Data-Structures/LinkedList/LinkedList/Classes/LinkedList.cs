﻿using System;
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
            if (Head != null)
            {
                Current = Head;
                Console.WriteLine("Linked List node values:");
                while (Current.Next != null)
                {
                    Console.Write($" {Current.Value} =>");
                    Current = Current.Next;
                }

                Console.WriteLine($" {Current.Value} => NULL");
            }
            else
            {
                System.Console.WriteLine("Your Linked List is empty.");
            }
        }

        /// <summary>
        /// Adds a new node with a given value to end of the list
        /// </summary>
        /// <param name="value">value for node</param>
        public void Append(int value)
        {
            if (Head == null)
            {
                Insert(value);
            }
            else
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Node node = new Node(value);

                Current.Next = node;
            }
        }

        /// <summary>
        /// Adds new node with given value immediately before first value node
        /// </summary>
        /// <param name="value">value to identify</param>
        /// <param name="newValue">new value to insert</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if(Current.Value == value)
            {
                Insert(newValue);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Add new node with newly given value immediately after first node of input value
        /// </summary>
        /// <param name="value">current value</param>
        /// <param name="newValue">new value node</param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;

            if (Current.Value == value)
            {
                Node node = new Node(newValue);
                node.Next = Current.Next;
                Current.Next = node;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
  
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                Node node = new Node(newValue);
                node.Next = Current.Next;
                Current.Next = node;
                return;
            }
        }

        /// <summary>
        /// Find the kth node from the end of a link list and return the value
        /// </summary>
        /// <param name="k">node position to return</param>
        /// <returns>kth node value from end</returns>
        public int FindKthFromEnd2( int k)
        {
            try
            {


                Current = Head;
                int counter = 1;
                while (Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
                {
                    Current = Current.Next;
                    counter++;
                }
                if (k > (counter - 1))
                {
                    throw Exception;
                }
                counter = counter - k; //set new counter eqaul to counter less k to find positioning
                Current = Head;
                while (counter > 1) /// interated through until counter less than one to find variable
                {
                    Current = Current.Next;
                    counter--; /// deduct from counter each iteration

                }
                return Current.Value;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
