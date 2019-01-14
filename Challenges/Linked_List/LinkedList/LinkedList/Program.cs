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
        }

        static void NewNode(int num)
        {
            Node node = new Node(num);
            Console.WriteLine(node.Value);

            LiList myList = new LiList();
        }
    }
}
