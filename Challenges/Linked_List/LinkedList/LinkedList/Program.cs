using System;
using LinkedList.Classes;


namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 3;
            NewNode(num);
            NewList(num);
        }

        static void NewNode(int num)
        {
            Node node1 = new Node(num);
            Console.WriteLine(node1.Value);
            Node node2 = new Node(num * num);
            Console.WriteLine(node2.Value);
        }

        static void NewList(int num)
        { 
            LiList myList = new LiList();
            myList.Insert(num);
            myList.Insert(num * 2);
            myList.Insert(num * 3);
            myList.Insert(num * 4);
            myList.Print();
            //if(myList.Includes(num * 3))
            //{
            //    Console.WriteLine($"{num * 3} is in list.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num * 3} is not in list.");
            //}


        }
    }
}
