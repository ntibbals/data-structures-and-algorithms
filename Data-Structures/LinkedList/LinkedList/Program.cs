﻿using System;
using LinkedList.Classes;


namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 3;
            int num1 = 6;
            int num2 = 7;
            NewList(num, num1, num2);
            
            Console.ReadLine();
        }
        /// <summary>
        /// Create a new node
        /// </summary>
        /// <param name="num">value of node</param>
        static void NewNode(int num)
        {
            Node node1 = new Node(num);
            Console.WriteLine(node1.Value);
            Node node2 = new Node(num * num);
            Console.WriteLine(node2.Value);
        }

        /// <summary>
        /// Instantiates a New Linked List  and inserts new nodes into list
        /// </summary>
        /// <param name="num">value of node</param>
        static void NewList(int num, int num1, int num2)
        {
            LiList myList = new LiList();
            myList.Insert(num);
            myList.Insert(num * 2);
            myList.Insert(num * 3);
            myList.Insert(num * 4);
            myList.Print();
            myList.Append(12);
            myList.Print();
            myList.InsertBefore(num1, num2);
            myList.Print();
            myList.InsertAfter(num1, num2);
            myList.Print();

        }
    }
}
