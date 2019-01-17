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
            int k = 2;
            //NewList(num, num1, num2);
            InsertsLists();
            
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
            myList.InsertAfter(12, 99);
            myList.Print();
        }

        static void TestKValue (int k, int num)
        {
            LiList myList = new LiList();
            myList.Insert(num);
            myList.Insert(num * 2);
            myList.Insert(num * 3);
            myList.Insert(num * 4);
            myList.Print();
            Console.WriteLine($"k value: {k}");
            Console.WriteLine($"K value from end: {myList.FindKthFromEnd(k)}");
            Console.ReadLine();

        }
        static void InsertsLists()
        {
            Console.WriteLine("Hello World!");
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.InsertAfter(1, 2);
            listOne.InsertAfter(2, 3);
            listOne.InsertAfter(3, 9);
            listTwo.Insert(4);
            listTwo.InsertAfter(4, 5);
            listTwo.InsertAfter(5, 6);
            listOne.Print();
            listTwo.Print();
            LlMerge(listOne, listTwo);
            listOne.Print();


        }

        public static LiList LlMerge(LiList lOne, LiList lTwo)
        {
            lOne.Current = lOne.Head;
            int counterOne = 0;
            int counterTwo = 0;
            while (lOne.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                lOne.Current = lOne.Current.Next;
                counterOne++;
            }
            lTwo.Current = lTwo.Head;
            while (lTwo.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                lTwo.Current = lTwo.Current.Next;
                counterTwo++;
            }
            int newCount = counterOne + counterTwo;
            lOne.Current = lOne.Head;
            while (newCount > 1)
            {
                if (lOne.Current.Next != null)
                {
                    lOne.InsertAfter(lOne.Head.Value, lTwo.Current.Value);
                    lOne.Current = lOne.Current.Next;
                    //lTwo.Current = lTwo.Current.Next;
                }
                else
                {
                    lOne.Current = lTwo.Current.Next;
                }
                newCount--;
            }
            return lOne;
        }
    }
}
